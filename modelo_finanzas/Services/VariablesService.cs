using Microsoft.Data.SqlClient;
using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Services
{
    public class VariablesService
    {
        public async Task<int> insertVariables(Variables datos)
        {
            DbConnection db = DbConnection.Instance;
            if(!await db.TestConnectionAsync())
            {
                throw new Exception("VariablesService: No se pudo conectar a la base de datos");
            }
            using (SqlConnection conn = await db.GetConnectionAsync())
            {
                string query = @"
                        INSERT INTO variables
                            (id_escenario, anio, tamanio_mercado, participacion_mercado, 
                            unidades_vendidas, precio_venta, costo_produccion)
                        VALUES
                            (@id_escenario, @anio, @tamanio_mercado, @participacion_mercado, 
                            @unidades_vendidas, @precio_venta, @costo_produccion);
                        SELECT SCOPE_IDENTITY();
                    ";

                var cmd = new SqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@id_escenario", datos.IdEscenario);
                cmd.Parameters.AddWithValue("@anio", datos.Anio);
                cmd.Parameters.AddWithValue("@tamanio_mercado", datos.TamanioMercado);
                cmd.Parameters.AddWithValue("@participacion_mercado", datos.ParticipacionMercado);
                cmd.Parameters.AddWithValue("@unidades_vendidas", datos.UnidadesVendidas);
                cmd.Parameters.AddWithValue("@precio_venta", datos.PrecioVenta);
                cmd.Parameters.AddWithValue("@costo_produccion", datos.CostoProduccion);

                var result = await cmd.ExecuteScalarAsync();
                conn.Close();
                return Convert.ToInt32(result);
                
            }
        }
    }
}
