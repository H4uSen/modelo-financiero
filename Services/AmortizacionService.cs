
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
                anio = 0,
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
                    anio = a,
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
        public async Task GuardarTablaAmortizacion(List<Amortizacion> lista, int escenarioId)
        {
         
            var db = DbConnection.Instance;

            using (var connection = await db.GetConnectionAsync())
            {
                string deleteQuery = "DELETE FROM amortizacion WHERE id_escenario = @id";
                using (var deleteCmd = new SqlCommand(deleteQuery, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@id", escenarioId);
                    await deleteCmd.ExecuteNonQueryAsync();
                }
                string insertQuery = @"INSERT INTO amortizacion 
                    (id_escenario, anio, saldo_inicial, cuota, interes, abono_capital, saldo_final) 
                    VALUES (@id, @anio, @ini, @cuota, @int, @cap, @fin)";

                foreach (var fila in lista)
                {
                    using (var cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", escenarioId);
                        cmd.Parameters.AddWithValue("@anio", fila.anio);
                        cmd.Parameters.AddWithValue("@ini", fila.SaldoInicial);
                        cmd.Parameters.AddWithValue("@cuota", fila.Cuota);
                        cmd.Parameters.AddWithValue("@int", fila.Interes);
                        cmd.Parameters.AddWithValue("@cap", fila.AbonoCapital);
                        cmd.Parameters.AddWithValue("@fin", fila.SaldoFinal);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
        }
    }
}
       