
using Microsoft.Data.SqlClient;
using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modelo_finanzas.Services
{
    public class AmortizacionService
    {
        public List<Amortizacion> CalcularTabla(double montoPrestamo, double tasaAnual, int plazoAnios)
        {
            var lista = new List<Amortizacion>();
     

            double i = tasaAnual / 100;

        
            lista.Add(new Amortizacion
            {
                Anio = 0,
                SaldoFinal = (decimal)montoPrestamo
            });

           
            double cuotaFija = montoPrestamo * (i / (1 - Math.Pow(1 + i, -plazoAnios)));

            decimal saldoAnterior = (decimal)montoPrestamo;

            for (int a = 1; a <= 5; a++) 
            {
             
                decimal cuota = (a <= plazoAnios) ? (decimal)cuotaFija : 0;

                decimal saldoInicial = saldoAnterior;

             
                decimal interes = (a <= plazoAnios) ? saldoInicial * (decimal)i : 0;

             
                decimal abonoCapital = cuota - interes;

                decimal saldoFinal = saldoInicial - abonoCapital;

                lista.Add(new Amortizacion
                {
                    Anio = a,
                    SaldoInicial = Math.Round(saldoInicial, 2),
                    Cuota = Math.Round(cuota, 2),
                    Interes = Math.Round(interes, 2),
                    AbonoCapital = Math.Round(abonoCapital, 2),
                    SaldoFinal = Math.Round(Math.Max(0, saldoFinal), 2)
                });

                saldoAnterior = saldoFinal;
            }
            return lista;
        }

        public async Task<int> insertAmortizacion(Amortizacion datos)
        {
            DbConnection db = DbConnection.Instance;

            if (!await db.TestConnectionAsync())
            {
                throw new Exception("AmortizacionService: No se pudo conectar a la base de datos");
            }

            using (SqlConnection conn = await db.GetConnectionAsync())
            {
                string query = @"
                    INSERT INTO amortizacion
                        (id_escenario, anio, saldo_inicial, cuota, interes, abono_capital, saldo_final)
                    VALUES
                        (@id_escenario, @anio, @saldo_inicial, @cuota, @interes, @abono_capital, @saldo_final);
                    
                    SELECT SCOPE_IDENTITY();
                ";

                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_escenario", datos.IdEscenario);
                cmd.Parameters.AddWithValue("@anio", datos.Anio);
                cmd.Parameters.AddWithValue("@saldo_inicial", datos.SaldoInicial);
                cmd.Parameters.AddWithValue("@cuota", datos.Cuota);
                cmd.Parameters.AddWithValue("@interes", datos.Interes);
                cmd.Parameters.AddWithValue("@abono_capital", datos.AbonoCapital);
                cmd.Parameters.AddWithValue("@saldo_final", datos.SaldoFinal);

                var result = await cmd.ExecuteScalarAsync();
                conn.Close();

                return Convert.ToInt32(result);
            }
        }
    }
}
       