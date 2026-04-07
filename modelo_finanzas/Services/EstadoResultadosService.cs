using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using modelo_finanzas.Models;

namespace modelo_finanzas.Services
{
    public class EstadoResultadosService
    {

        private async void InsertarFilaSql(EstadoResultados f)
        {
            try
            {
                // Query basado en las columnas exactas de tu tabla estadoResultados
                string sql = @"INSERT INTO estadoResultados 
                (id_escenario, anio, ventas, costo_ventas, utilidad_bruta, gastos_operativos, depreciacion, 
                 total_gastos, utilidad_operativa, gastos_financieros, otros_ingresos, neto_otros_ingresos, 
                 utilidad_antes_impuestos, impuestos, utilidad_neta, capital_trabajo) 
                VALUES 
                (@id, @anio, @v, @cv, @ub, @go, @dep, @tg, @uo, @gf, @oi, @noi, @uai, @imp, @un, @ct)";
                var db = DbConnection.Instance;
                using (SqlConnection connInsert = await db.GetConnectionAsync())
                {
                    using (SqlCommand cmd = new SqlCommand(sql, connInsert))
                    {
                        cmd.Parameters.AddWithValue("@id", f.IdEscenario);
                        cmd.Parameters.AddWithValue("@anio", f.Anio);
                        cmd.Parameters.AddWithValue("@v", f.Ventas);
                        cmd.Parameters.AddWithValue("@cv", f.CostoVentas);
                        cmd.Parameters.AddWithValue("@ub", f.UtilidadBruta);
                        cmd.Parameters.AddWithValue("@go", f.GastosOperativos);
                        cmd.Parameters.AddWithValue("@dep", f.Depreciacion);
                        cmd.Parameters.AddWithValue("@tg", f.TotalGastos);
                        cmd.Parameters.AddWithValue("@uo", f.UtilidadOperativa);
                        cmd.Parameters.AddWithValue("@gf", f.GastosFinancieros);
                        cmd.Parameters.AddWithValue("@oi", f.OtrosIngresos);
                        cmd.Parameters.AddWithValue("@noi", f.NetoOtrosIngresos);
                        cmd.Parameters.AddWithValue("@uai", f.UtilidadAntesImpuestos);
                        cmd.Parameters.AddWithValue("@imp", f.Impuestos);
                        cmd.Parameters.AddWithValue("@un", f.UtilidadNeta);
                        cmd.Parameters.AddWithValue("@ct", f.CapitalTrabajo);
                        cmd.ExecuteNonQuery();
                        connInsert.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar fila en estadoResultados: " + ex.Message);
            }
        }
    }
}