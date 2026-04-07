using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using modelo_finanzas.Models;

namespace modelo_finanzas.Services
{
    public class EstadoResultadosService
    {
        // Tu cadena de conexión verificada
        //private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=hausencito247_finanzas;Integrated Security=True;";
        private string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=hausencito247_finanzas;Integrated Security=True;MultipleActiveResultSets=True;";

        public void GenerarTodoElEstado(int idEscenario)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1. LIMPIEZA: Borrar cálculos previos para evitar duplicados
                string deleteQuery = "DELETE FROM estadoResultados WHERE id_escenario = @id";
                using (SqlCommand delCmd = new SqlCommand(deleteQuery, conn))
                {
                    delCmd.Parameters.AddWithValue("@id", idEscenario);
                    delCmd.ExecuteNonQuery();
                }

                // 2. EL QUERY MAESTRO: Une Entradas, Variables, Datos de Escenario y 
                    string query = @"
                    SELECT 
                        e.id_escenario, e.tasa_impuestos, e.gastos_operativos, e.inversion_equipos, 
                        e.depreciacion_anios, e.otros_ingresos, e.capital_trabajo,
                        v.anio, v.unidades_vendidas, v.precio_venta, v.costo_produccion,
                        d.valor_inversion_inicial,
                        a.interes as gasto_financiero
                    FROM entradasEscenarios e
                    INNER JOIN variables v ON e.id_escenario = v.id_escenario
                    LEFT JOIN datosEscenarios d ON e.id_escenario = d.escenario_id
                    LEFT JOIN amortizacion a ON e.id_escenario = a.id_escenario AND v.anio = a.anio
                    WHERE e.id_escenario = @id
                    ORDER BY v.anio ASC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", idEscenario);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Instanciamos tu modelo para llenar los datos
                            EstadoResultados fila = new EstadoResultados();

                            // --- EXTRACCIÓN DE DATOS DE SQL ---
                            fila.IdEscenario = idEscenario;
                            fila.Anio = reader.GetInt32(reader.GetOrdinal("anio"));

                            decimal unidades = Convert.ToDecimal(reader["unidades_vendidas"]);
                            decimal precio = Convert.ToDecimal(reader["precio_venta"]);
                            decimal costoUnitario = Convert.ToDecimal(reader["costo_produccion"]);
                            decimal porcGastosOp = Convert.ToDecimal(reader["gastos_operativos"]) / 100;
                            decimal inversionInicial = Convert.ToDecimal(reader["valor_inversion_inicial"]);
                            int vidaUtil = reader.GetInt32(reader.GetOrdinal("depreciacion_anios"));
                            decimal intereses = reader["gasto_financiero"] != DBNull.Value ? Convert.ToDecimal(reader["gasto_financiero"]) : 0;
                            decimal tasaImp = Convert.ToDecimal(reader["tasa_impuestos"]) / 100;
                            decimal porcCapTrabajo = Convert.ToDecimal(reader["capital_trabajo"]) / 100;
                            decimal porcOtrosIng = Convert.ToDecimal(reader["otros_ingresos"]) / 100;

                            // --- LÓGICA DE CÁLCULO (Tu lógica de negocio) ---
                            fila.Ventas = unidades * precio;
                            fila.CostoVentas = unidades * costoUnitario;
                            fila.UtilidadBruta = fila.Ventas - fila.CostoVentas;

                            fila.GastosOperativos = fila.Ventas * porcGastosOp;

                            // Regla de Depreciación
                            fila.Depreciacion = (fila.Anio <= vidaUtil) ? (inversionInicial / vidaUtil) : 0;

                            fila.TotalGastos = fila.GastosOperativos + fila.Depreciacion;
                            fila.UtilidadOperativa = fila.UtilidadBruta - fila.TotalGastos;

                            // Parte Financiera
                            fila.GastosFinancieros = intereses;
                            fila.OtrosIngresos = fila.CostoVentas * porcOtrosIng; // Otros ingresos según tu código
                            fila.NetoOtrosIngresos = fila.OtrosIngresos - fila.GastosFinancieros;

                            fila.UtilidadAntesImpuestos = fila.UtilidadOperativa + fila.NetoOtrosIngresos;

                            // Regla de Impuestos: Solo si hay ganancia
                            fila.Impuestos = (fila.UtilidadAntesImpuestos > 0) ? (fila.UtilidadAntesImpuestos * tasaImp) : 0;

                            fila.UtilidadNeta = fila.UtilidadAntesImpuestos - fila.Impuestos;

                            // Cálculo de Capital de Trabajo pedido
                            fila.CapitalTrabajo = fila.Ventas * porcCapTrabajo;

                            // 3. GUARDAR CADA AÑO (Llamamos al método de inserción abajo)
                            InsertarFilaSql(fila);
                        }
                    }
                }
            }
        }

        private void InsertarFilaSql(EstadoResultados f)
        {
            // Query basado en las columnas exactas de tu tabla estadoResultados
            string sql = @"INSERT INTO estadoResultados 
                (id_escenario, anio, ventas, costo_ventas, utilidad_bruta, gastos_operativos, depreciacion, 
                 total_gastos, utilidad_operativa, gastos_financieros, otros_ingresos, neto_otros_ingresos, 
                 utilidad_antes_impuestos, impuestos, utilidad_neta, capital_trabajo) 
                VALUES 
                (@id, @anio, @v, @cv, @ub, @go, @dep, @tg, @uo, @gf, @oi, @noi, @uai, @imp, @un, @ct)";

            using (SqlConnection connInsert = new SqlConnection(connectionString))
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
                connInsert.Open();
                cmd.ExecuteNonQuery();
                }
            }

        }
    }
}