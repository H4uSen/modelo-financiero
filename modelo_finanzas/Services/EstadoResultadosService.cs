using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using modelo_finanzas.Models;

namespace modelo_finanzas.Services
{
    public class EstadoResultadosService
    {

        public async Task<int> InsertEstadoResultados(EstadoResultados datos)
        {
            DbConnection db = DbConnection.Instance;

            if (!await db.TestConnectionAsync())
            {
                throw new Exception("EstadoResultadosService: No se pudo conectar a la base de datos");
            }

            using (SqlConnection conn = await db.GetConnectionAsync())
            {
                string query = @"
                    INSERT INTO estadoResultados
                    (
                        id_escenario, anio, ventas, costo_ventas, utilidad_bruta,
                        gastos_operativos, depreciacion, total_gastos, utilidad_operativa,
                        gastos_financieros, otros_ingresos, neto_otros_ingresos,
                        utilidad_antes_impuestos, impuestos, utilidad_neta, capital_trabajo
                    )
                    VALUES
                    (
                        @id_escenario, @anio, @ventas, @costo_ventas, @utilidad_bruta,
                        @gastos_operativos, @depreciacion, @total_gastos, @utilidad_operativa,
                        @gastos_financieros, @otros_ingresos, @neto_otros_ingresos,
                        @utilidad_antes_impuestos, @impuestos, @utilidad_neta, @capital_trabajo
                    );

                    SELECT SCOPE_IDENTITY();
                ";

                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_escenario", datos.IdEscenario);
                cmd.Parameters.AddWithValue("@anio", datos.Anio);
                cmd.Parameters.AddWithValue("@ventas", datos.Ventas);
                cmd.Parameters.AddWithValue("@costo_ventas", datos.CostoVentas);
                cmd.Parameters.AddWithValue("@utilidad_bruta", datos.UtilidadBruta);
                cmd.Parameters.AddWithValue("@gastos_operativos", datos.GastosOperativos);
                cmd.Parameters.AddWithValue("@depreciacion", datos.Depreciacion);
                cmd.Parameters.AddWithValue("@total_gastos", datos.TotalGastos);
                cmd.Parameters.AddWithValue("@utilidad_operativa", datos.UtilidadOperativa);
                cmd.Parameters.AddWithValue("@gastos_financieros", datos.GastosFinancieros);
                cmd.Parameters.AddWithValue("@otros_ingresos", datos.OtrosIngresos);
                cmd.Parameters.AddWithValue("@neto_otros_ingresos", datos.NetoOtrosIngresos);
                cmd.Parameters.AddWithValue("@utilidad_antes_impuestos", datos.UtilidadAntesImpuestos);
                cmd.Parameters.AddWithValue("@impuestos", datos.Impuestos);
                cmd.Parameters.AddWithValue("@utilidad_neta", datos.UtilidadNeta);
                cmd.Parameters.AddWithValue("@capital_trabajo", datos.CapitalTrabajo);

                var result = await cmd.ExecuteScalarAsync();
                conn.Close();

                return Convert.ToInt32(result);
            }
        }
    }
}