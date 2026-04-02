using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using modelo_finanzas.Models;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace modelo_finanzas.Logic
{
    
    public class DatosController
    {
        public async Task<int> InsertDatos(DatosEntrada datos)
        {
            String query = @"
            INSERT INTO entradasEscenarios 
            (nombre_escenario, fecha_creacion, tamano_mercado, crecimiento_mercado, 
            encuestas, personas_interesadas, objetivo_mercado, inversion_equipos, 
            depreciacion_anios, precio_inicial, incremento_precio, inflacion, 
            ipp, costo_produccion_inicial, otros_ingresos, gastos_operativos, 
            capital_trabajo, porcentaje_deuda, plazo_credito, tasa_libre_riesgo, 
            beta_sector, prima_riesgo_mercado, gradiente_flujos, tasa_impuestos) 
            VALUES 
            (@NombreEscenario, @FechaCreacion, @TamanioMercado, @CrecimientoMercado, 
            @Encuestas, @PersonasInteresadas, @ObjetivoMercado, @InversionEquipos, 
            @DepreciacionAnios, @PrecioInicial, @IncrementoPrecio, @Inflacion, 
            @Ipp, @CostoProduccionInicial, @OtrosIngresos, @GastosOperativos, 
            @CapitalTrabajo, @PorcentajeDeuda, @PlazoCredito, @TasaLibreRiesgo, 
            @BetaSector, @PrimaRiesgoMercado,@GradienteFlujos,@TasaImpuestos)";

            DbConnection db = DbConnection.Instance;
            if (await db.TestConnectionAsync())
            {
                var connection = await db.GetConnectionAsync();
                var command = new SqlCommand(query,connection);

                command.Parameters.AddWithValue("@NombreEscenario", datos.NombreEscenario);
                command.Parameters.AddWithValue("@FechaCreacion", datos.FechaCreacion);
                command.Parameters.AddWithValue("@TamanioMercado", datos.TamanioMercado);
                command.Parameters.AddWithValue("@CrecimientoMercado", datos.CrecimientoMercado);
                command.Parameters.AddWithValue("@Encuestas", datos.Encuestas);
                command.Parameters.AddWithValue("@PersonasInteresadas", datos.PersonasInteresadas);
                command.Parameters.AddWithValue("@ObjetivoMercado", datos.ObjetivoMercado);
                command.Parameters.AddWithValue("@InversionEquipos", datos.InversionEquipos);
                command.Parameters.AddWithValue("@DepreciacionAnios", datos.DepreciacionAnios);
                command.Parameters.AddWithValue("@PrecioInicial", datos.PrecioInicial);
                command.Parameters.AddWithValue("@IncrementoPrecio", datos.IncrementoPrecio);
                command.Parameters.AddWithValue("@Inflacion", datos.Inflacion);
                command.Parameters.AddWithValue("@Ipp", datos.Ipp);
                command.Parameters.AddWithValue("@CostoProduccionInicial", datos.CostoProduccionInicial);
                command.Parameters.AddWithValue("@OtrosIngresos", datos.OtrosIngresos);
                command.Parameters.AddWithValue("@GastosOperativos", datos.GastosOperativos);
                command.Parameters.AddWithValue("@CapitalTrabajo", datos.CapitalTrabajo);
                command.Parameters.AddWithValue("@PorcentajeDeuda", datos.PorcentajeDeuda);
                command.Parameters.AddWithValue("@PlazoCredito", datos.PlazoCredito); 
                command.Parameters.AddWithValue("@TasaLibreRiesgo", datos.TasaLibreRiesgo); 
                command.Parameters.AddWithValue("@BetaSector", datos.BetaSector);
                command.Parameters.AddWithValue("@PrimaRiesgoMercado", datos.PrimaRiesgoMercado);
                command.Parameters.AddWithValue("@GradienteFlujos", datos.GradienteFlujos);
                command.Parameters.AddWithValue("@TasaImpuestos", datos.TasaImpuestos);

                return await command.ExecuteNonQueryAsync();
                
            }
            return -1;
            throw new Exception("No se pudo establecer conexión con la base de datos.");
        }
    }
}
