using Microsoft.Data.SqlClient;
using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Services
{
    public class CostoCapitalService
    {
        public async Task<int> InsertCostoCapital(CostoCapital datos)
        {
            DbConnection db = DbConnection.Instance;

            if (!await db.TestConnectionAsync())
            {
                throw new Exception("CostoCapitalService: No se pudo conectar a la base de datos");
            }

            using (SqlConnection conn = await db.GetConnectionAsync())
            {
                string query = @"
                    INSERT INTO costoCapital
                    (
                        id_escenario,
                        porcentaje_deuda,
                        porcentaje_aportes,
                        costo_deuda,
                        costo_deuda_despues_impuestos,
                        betaL_sector,
                        costo_patrimonio,
                        costo_capital
                    )
                    VALUES
                    (
                        @id_escenario,
                        @porcentaje_deuda,
                        @porcentaje_aportes,
                        @costo_deuda,
                        @costo_deuda_despues_impuestos,
                        @betaL_sector,
                        @costo_patrimonio,
                        @costo_capital
                    );

                    SELECT SCOPE_IDENTITY();
                ";

                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_escenario", datos.IdEscenario);
                cmd.Parameters.AddWithValue("@porcentaje_deuda", datos.PorcentajeDeuda);
                cmd.Parameters.AddWithValue("@porcentaje_aportes", datos.PorcentajeAportes);
                cmd.Parameters.AddWithValue("@costo_deuda", datos.CostoDeuda);
                cmd.Parameters.AddWithValue("@costo_deuda_despues_impuestos", datos.CostoDeudaDespuesImpuestos);
                cmd.Parameters.AddWithValue("@betaL_sector", datos.BetaLSector);
                cmd.Parameters.AddWithValue("@costo_patrimonio", datos.CostoPatrimonio);
                cmd.Parameters.AddWithValue("@costo_capital", datos.CostoCapitalTotal);

                var result = await cmd.ExecuteScalarAsync();
                conn.Close();

                return Convert.ToInt32(result);
            }
        }
    }
}
