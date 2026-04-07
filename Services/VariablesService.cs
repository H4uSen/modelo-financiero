using modelo_finanzas.Models;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using System;

namespace modelo_finanzas.Services
{
    public class VariablesService
    {
        public async Task<Variables> ObtenerUltimasVariablesAsync()
        {
            Variables variables = null;

            try
            {
               
                using (var connection = await DbConnection.Instance.GetConnectionAsync())
                {
                    string query = "SELECT TOP 1 InversionOpciones, TasaInteresAnual, PlazoMeses FROM Variables ORDER BY Id DESC";

                    using (var command = new SqlCommand(query, connection))
                    {
                        using (var reader = await command.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                variables = new Variables
                                {
                                    InversionOpciones = reader.GetSqlDecimal(0),
                                    TasaInteresAnual = reader.GetSqlDecimal(1),
                                    PlazoMeses = reader.GetSqlInt32(2)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en DB: " + ex.Message);
            }

            return variables ?? new Variables { InversionOpciones = 88000000, TasaInteresAnual = 15, PlazoMeses = 60 };
        }

      
        public Variables ObtenerUltimasVariables()
        {
            return new Variables { InversionOpciones = 88000000, TasaInteresAnual = 15, PlazoMeses = 60 };
        }
    }
}