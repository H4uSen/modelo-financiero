using Microsoft.Data.SqlClient;
using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modelo_finanzas;

namespace modelo_finanzas.Services
{
    public class EstadoResultadosService
    {
        // Usamos la clase dbConnection
        //private readonly DbConnection_db = new DbConnection();
        // Usamos la instancia única de DbConnection (con D mayúscula y b minúscula)
        private readonly DbConnection _db = DbConnection.Instance;
        public async Task<int> InsertEstadoResutados(EstadoResultados datos)
        {
            try
            {
                // Usamos await porque el método de Andrés es Asíncrono
                using (var connection = await _db.GetConnectionAsync())
                {
                    // El resto del código del INSERT sigue igual
                    string query = @"INSERT INTO estadoResultados 
                           (anio, ventas, costo_ventas, utilidad_bruta, gastos_operativos, depreciacion, total_gastos, utilidad_operativa) 
                           VALUES (@anio, @ventas, @costo, @utilidadB, @gastosO, @depre, @totalG, @utilidadO)";

                    using (var command = new SqlCommand(query, connection))
                    {
                        SqlParameter sqlParameter = command.Parameters.AddWithValue("@anio", datos.Anio.Value);
                        command.Parameters.AddWithValue("@ventas", datos.Ventas.Value);
                        command.Parameters.AddWithValue("@costo", datos.CostoVentas);
                        command.Parameters.AddWithValue("@utilidadB", datos.UtilidadBruta);
                        command.Parameters.AddWithValue("@gastosO", datos.GastosOperativos);
                        command.Parameters.AddWithValue("@depre", datos.Depreciacion);
                        command.Parameters.AddWithValue("@totalG", datos.TotalGastos);
                        command.Parameters.AddWithValue("@utilidadO", datos.UtilidadOperativa);

                        return await command.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al insertar: " + ex.Message);
            }
        }
    }
}