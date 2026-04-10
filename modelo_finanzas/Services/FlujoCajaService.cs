using Microsoft.Data.SqlClient;
using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Services
{
    public class FlujoCajaService
    {
        public async Task<int> InsertFlujoCajaLibre(FlujoCajaLibre datos)
        {
            DbConnection db = DbConnection.Instance;

            if (!await db.TestConnectionAsync())
            {
                throw new Exception("FlujoCajaLibreService: No se pudo conectar a la base de datos");
            }

            using (SqlConnection conn = await db.GetConnectionAsync())
            {
                string query = @"
                    INSERT INTO flujoCajaLibre
                    (
                        id_escenario, anio, utilidad_neta, gasto_financiero, impuestos_causados,
                        ebit, impuestos_ajustados, ebit_uodi, depreciacion, flujo_bruto,
                        inversion_capital_trabajo, inversion_activos_fijos, flujo_caja_libre
                    )
                    VALUES
                    (
                        @id_escenario, @anio, @utilidad_neta, @gasto_financiero, @impuestos_causados,
                        @ebit, @impuestos_ajustados, @ebit_uodi, @depreciacion, @flujo_bruto,
                        @inversion_capital_trabajo, @inversion_activos_fijos, @flujo_caja_libre
                    );

                    SELECT SCOPE_IDENTITY();
                ";

                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_escenario", datos.IdEscenario);
                cmd.Parameters.AddWithValue("@anio", datos.Anio);
                cmd.Parameters.AddWithValue("@utilidad_neta", datos.UtilidadNeta);
                cmd.Parameters.AddWithValue("@gasto_financiero", datos.GastoFinanciero);
                cmd.Parameters.AddWithValue("@impuestos_causados", datos.ImpuestosCausados);
                cmd.Parameters.AddWithValue("@ebit", datos.EBIT);
                cmd.Parameters.AddWithValue("@impuestos_ajustados", datos.ImpuestosAjustados);
                cmd.Parameters.AddWithValue("@ebit_uodi", datos.EBITUODI);
                cmd.Parameters.AddWithValue("@depreciacion", datos.Depreciacion);
                cmd.Parameters.AddWithValue("@flujo_bruto", datos.FlujoBruto);
                cmd.Parameters.AddWithValue("@inversion_capital_trabajo", datos.InversionCapitalTrabajo);
                cmd.Parameters.AddWithValue("@inversion_activos_fijos", datos.InversionActivosFijos);
                cmd.Parameters.AddWithValue("@flujo_caja_libre", datos.FlujoCajaLibreValor);

                var result = await cmd.ExecuteScalarAsync();
                conn.Close();

                return Convert.ToInt32(result);
            }
        }
        public async Task<int> InsertResultado(FlujoCajaResultado datos)
        {
            DbConnection db = DbConnection.Instance;

            if (!await db.TestConnectionAsync())
            {
                throw new Exception("FlujoCajaResultadoService: No se pudo conectar a la base de datos");
            }

            using (SqlConnection conn = await db.GetConnectionAsync())
            {
                string query = @"
                    INSERT INTO resultados_caja_libre
                    (
                        id_escenario,
                        valor_terminal,
                        valor_presente_flujos,
                        valor_presente_terminal,
                        valor_mercado_negocio,
                        inversion_inicial_activos,
                        valor_presente_neto
                    )
                    VALUES
                    (
                        @id_escenario,
                        @valor_terminal,
                        @valor_presente_flujos,
                        @valor_presente_terminal,
                        @valor_mercado_negocio,
                        @inversion_inicial_activos,
                        @valor_presente_neto
                    );

                    SELECT SCOPE_IDENTITY();
                ";

                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_escenario", datos.IdEscenario);
                cmd.Parameters.AddWithValue("@valor_terminal", datos.ValorTerminal);
                cmd.Parameters.AddWithValue("@valor_presente_flujos", datos.ValorPresenteFlujos);
                cmd.Parameters.AddWithValue("@valor_presente_terminal", datos.ValorPresenteVT);
                cmd.Parameters.AddWithValue("@valor_mercado_negocio", datos.ValorMercadoNegocio);
                cmd.Parameters.AddWithValue("@inversion_inicial_activos", datos.InversionInicialActivos);
                cmd.Parameters.AddWithValue("@valor_presente_neto", datos.ValorPresenteNeto);

                var result = await cmd.ExecuteScalarAsync();
                conn.Close();

                return Convert.ToInt32(result);
            }
        }
    }
}
