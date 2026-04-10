using Microsoft.Data.SqlClient;
using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Services
{
    public class DatosEscenariosService
    {
        public async Task<int> insertEscenario(DatosEscenarios datos)
        {
            String query = @"INSERT INTO datosEscenarios 
            (escenario_id, mercado_esperado_anio1, variacion_nominal_precio, variacion_nominal_ipp,
            valor_inversion_inicial, financiado_con_credito, costo_deuda, financiado_con_aportes) 
            VALUES 
            (@escenarioID, @mercEsp, @varNomPrecio, @varNomIPP, @valInvIni,
            @finCredito, @costoDeuda, @finAportes);
            SELECT SCOPE_IDENTITY();";

            DbConnection db = DbConnection.Instance;
            if (await db.TestConnectionAsync())
            {
                var connection = await db.GetConnectionAsync();
                var command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@escenarioID", datos.Escenario_id);
                command.Parameters.AddWithValue("@mercEsp", datos.Mercado_esperado_anio1);
                command.Parameters.AddWithValue("@varNomPrecio", datos.Variacion_nominal_precio);
                command.Parameters.AddWithValue("@varNomIPP", datos.Variacion_nominal_ipp);
                command.Parameters.AddWithValue("@valInvIni", datos.Valor_inversion_inicial);
                command.Parameters.AddWithValue("@finCredito", datos.Financiado_con_credito);
                command.Parameters.AddWithValue("@costoDeuda", datos.Costo_deuda);
                command.Parameters.AddWithValue("@finAportes", datos.Financiado_con_aportes);

                var result = await command.ExecuteScalarAsync();
                connection.Close();

                return Convert.ToInt32(result);

            }
            return -1;
            throw new Exception("Datos Escenarios Service: Ocurrio un error al insertar");
        }
    }


}
   
