using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using modelo_finanzas.Models;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data.SqlTypes;

namespace modelo_finanzas.Logic
{

    public class DatosService
    {
        private readonly DbConnection db = DbConnection.Instance;
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
            @BetaSector, @PrimaRiesgoMercado,@GradienteFlujos,@TasaImpuestos);
    
            SELECT CAST(SCOPE_IDENTITY() AS int);
            ";


            if (await db.TestConnectionAsync())
            {
                var connection = await db.GetConnectionAsync();
                var command = new SqlCommand(query, connection);

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

                var result = await command.ExecuteScalarAsync();
                connection.Close();
                return Convert.ToInt32(result);

            }
            return -1;
            throw new Exception("No se pudo establecer conexión con la base de datos en insertDatos()");
        }

        public async Task<List<DatosEntrada>> GetAllDatos()
        {
            List<DatosEntrada> datosList = new List<DatosEntrada>();
            String query = "SELECT * FROM entradasEscenarios";
            if (await db.TestConnectionAsync())
            {
                var connection = db.GetConnectionAsync().Result;
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    DatosEntrada datos = new DatosEntrada
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("id_escenario")),
                        NombreEscenario = reader.GetString(reader.GetOrdinal("nombre_escenario")),
                        FechaCreacion = reader.GetDateTime(reader.GetOrdinal("fecha_creacion")),
                        TamanioMercado = reader.GetInt32(reader.GetOrdinal("tamano_mercado")),
                        CrecimientoMercado = reader.GetDecimal(reader.GetOrdinal("crecimiento_mercado")),
                        Encuestas = reader.GetInt32(reader.GetOrdinal("encuestas")),
                        PersonasInteresadas = reader.GetInt32(reader.GetOrdinal("personas_interesadas")),
                        ObjetivoMercado = reader.GetDecimal(reader.GetOrdinal("objetivo_mercado")),
                        InversionEquipos = reader.GetDecimal(reader.GetOrdinal("inversion_equipos")),
                        DepreciacionAnios = reader.GetInt32(reader.GetOrdinal("depreciacion_anios")),
                        PrecioInicial = reader.GetDecimal(reader.GetOrdinal("precio_inicial")),
                        IncrementoPrecio = reader.GetDecimal(reader.GetOrdinal("incremento_precio")),
                        Inflacion = reader.GetDecimal(reader.GetOrdinal("inflacion")),
                        Ipp = reader.GetDecimal(reader.GetOrdinal("ipp")),
                        CostoProduccionInicial = reader.GetDecimal(reader.GetOrdinal("costo_produccion_inicial")),
                        OtrosIngresos = reader.GetDecimal(reader.GetOrdinal("otros_ingresos")),
                        GastosOperativos = reader.GetDecimal(reader.GetOrdinal("gastos_operativos")),
                        CapitalTrabajo = reader.GetDecimal(reader.GetOrdinal("capital_trabajo")),
                        PorcentajeDeuda = reader.GetDecimal(reader.GetOrdinal("porcentaje_deuda")),
                        PlazoCredito = reader.GetInt32(reader.GetOrdinal("plazo_credito")),
                        TasaLibreRiesgo = reader.GetDecimal(reader.GetOrdinal("tasa_libre_riesgo")),
                        BetaSector = reader.GetDecimal(reader.GetOrdinal("beta_sector")),
                        PrimaRiesgoMercado = reader.GetDecimal(reader.GetOrdinal("prima_riesgo_mercado")),
                        GradienteFlujos = reader.GetDecimal(reader.GetOrdinal("gradiente_flujos")),
                        TasaImpuestos = reader.GetDecimal(reader.GetOrdinal("tasa_impuestos"))

                    };
                    datosList.Add(datos);
                }
                return datosList;
            }
            else
            {
                throw new Exception("No se pudo establecer conexión con la base de datos en getAllDatos().");
            }
        }
    }
}
