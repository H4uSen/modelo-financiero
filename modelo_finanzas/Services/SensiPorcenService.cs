using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Services
{
    public class SensiPorcenService
    {
        public async Task<int> InsertSensiPorcVpn(int idEscenario, decimal ipc, decimal partMerc, decimal vpn)
        {
            DbConnection db = DbConnection.Instance;

            if (!await db.TestConnectionAsync())
            {
                throw new Exception("AnalisisVpnService: No se pudo conectar a la base de datos");
            }

            using (SqlConnection conn = await db.GetConnectionAsync())
            {
                string query = @"
                    INSERT INTO analisis_vpn
                    (
                        id_escenario,
                        variacion_ipc,
                        variacion_participacion_mercado,
                        valor_presente_neto
                    )
                    VALUES
                    (
                        @id_escenario,
                        @variacion_ipc,
                        @variacion_participacion_mercado,
                        @valor_presente_neto
                    );

                    SELECT SCOPE_IDENTITY();
                ";

                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_escenario", idEscenario);
                cmd.Parameters.AddWithValue("@variacion_ipc", ipc);
                cmd.Parameters.AddWithValue("@variacion_participacion_mercado", partMerc);
                cmd.Parameters.AddWithValue("@valor_presente_neto", vpn);

                var result = await cmd.ExecuteScalarAsync();
                conn.Close();

                return Convert.ToInt32(result);
            }
        }

        public async void CalcularGuardar( double ipc,  double partMerc, double vpn, int idEscenario)
        {
            ipc= 0;
            partMerc = 0;
            vpn = 0;
            var datosBase = EscenarioFinanciero.EscenarioActual;
            CalculadorFinanciero motor = new CalculadorFinanciero();
            if (datosBase == null) return;

            partMerc = datosBase.objetivoMercado;
            ipc = datosBase.inflacionAnualIPC;
            double vpnbase = motor.CalcularSoloVPN(datosBase, ipc, partMerc);
            double salto = 0.002;

            for (int j = -2; j <= 2; j++)
            {
                double inflacionCol = ipc + (j * salto);
                int indiceCol = j + 3;

            }

            // --- LLENADO DE FILAS Y DATOS ---
            for (int i = -3; i <= 3; i++)
            {
                double objetivoFila = partMerc + (i * salto);

                for (int j = -2; j <= 2; j++)
                {
                    double inflacionCol = ipc + (j * salto);
                    double vpnCalculado = motor.CalcularSoloVPN(datosBase, inflacionCol, objetivoFila);
                    int id = await InsertSensiPorcVpn(idEscenario, (decimal)inflacionCol, (decimal)objetivoFila, (decimal)vpnCalculado);
                }
            }

            double variaMercado2 = CalculadorFinanciero.F127 / CalculadorFinanciero.F126 - 1;
            double variaInfla2 = CalculadorFinanciero.G126 / CalculadorFinanciero.F126 - 1;

            CalculadorFinanciero.F126 = 0; // Reiniciar acumulado de esta corrida
            CalculadorFinanciero.F127 = 0; // Reiniciar acumulado de esta corrida
            CalculadorFinanciero.G126 = 0; // Reiniciar acumulado de esta corrida
            CalculadorFinanciero.TotalCalculosRealizados = 0; // Reiniciar contador de cálculos
        }
    }
}
