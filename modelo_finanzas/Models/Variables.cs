using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace modelo_finanzas.Models
{
    public class Variables
    {
        public int Anio { get; set; }

        public decimal TamanioMercado { get; set; }
        public decimal ParticipacionMercado { get; set; }
        public int UnidadesVendidas { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal CostoProduccion { get; set; }

        public List<Variables> CalcularVariables(
        DatosEntrada entrada,
        DatosEscenarios escenario)
        {
            List<Variables> result = new List<Variables>();
            decimal incremento = (entrada.ObjetivoMercado - escenario.Mercado_esperado_anio1) / 4;


            for (int i = 0; i < 6; i++)
            {
                Variables variable = new Variables();
                
                variable.Anio = i;
                if(i == 0)
                {
                    // Año 0: solo tamaño del mercado
                    variable.TamanioMercado = entrada.TamanioMercado;
                    variable.ParticipacionMercado = 0;
                    variable.PrecioVenta = 0;
                    variable.CostoProduccion = 0;
                    variable.UnidadesVendidas = 0;
                    result.Add(variable);
                }
                else {
                    //Año 1: se ponen los datos iniciales
                    //anterior * (1+entrada.crecMerc)
                    variable.TamanioMercado = result[i-1].TamanioMercado * (1+entrada.CrecimientoMercado);
                    //Año 1: escenario.PartMerc - despues: (entrada.ObjMerc - escenario.PartMerc) / 4 + anterior.PartMerc
                    variable.ParticipacionMercado = 
                        (i == 1) ? escenario.Mercado_esperado_anio1 : (entrada.ObjetivoMercado - escenario.Mercado_esperado_anio1) / 4 + result[i-1].ParticipacionMercado;
                    ;
                    //Año 1:entrada.precioVenta - despues: anterior.precioVenta * (1 + escenario.Variacion_nominal_precio)
                    variable.PrecioVenta = (i == 1) ? entrada.PrecioInicial : result[i-1].PrecioVenta*(1+escenario.Variacion_nominal_precio);
                    //Año 1: entrada.costoProduccion - despues: anterior.costoProduccion * (1 + escenario.Variacion_nominal_ipp)
                    variable.CostoProduccion = (i == 1) ? entrada.CostoProduccionInicial : result[i-1].CostoProduccion*(1+escenario.Variacion_nominal_ipp);
                    //tamanioMercado * PartMerc
                    variable.UnidadesVendidas = (int)(variable.TamanioMercado * variable.ParticipacionMercado);
                    result.Add(variable);
                }

            }
            return result;

            //if (actual.Anio == 0)
            //{
            //    // Año 0: solo tamaño del mercado
            //    actual.TamanioMercado = datosEntrada.TamanioMercado;
            //    actual.ParticipacionMercado = 0;
            //    actual.PrecioVenta = 0;
            //    actual.CostoProduccion = 0;
            //    actual.UnidadesVendidas = 0;
            //}



            //if (actual.Anio == 1)
            //{
            //    // Año 1: valores iniciales
            //    actual.TamanioMercado = anterior.TamanioMercado * (1 + datosEntrada.CrecimientoMercado);
            //    actual.PrecioVenta = datosEntrada.PrecioInicial;         
            //    actual.CostoProduccion = datosEntrada.CostoProduccionInicial; 
            //    actual.ParticipacionMercado = datosEscenarios.Mercado_esperado_anio1; 
            //    actual.UnidadesVendidas = (int)Math.Round(actual.TamanioMercado * actual.ParticipacionMercado, 0, MidpointRounding.AwayFromZero);
            //}
            //else
            //{
            //    // Años 2 en adelante
            //    actual.TamanioMercado = anterior.TamanioMercado * (1 + datosEntrada.CrecimientoMercado);
            //    actual.PrecioVenta = anterior.PrecioVenta * (1 + datosEscenarios.Variacion_nominal_precio);
            //    actual.CostoProduccion = anterior.CostoProduccion * (1 + datosEscenarios.Variacion_nominal_ipp);
            //    actual.ParticipacionMercado = anterior.ParticipacionMercado + incremento;
            //    actual.UnidadesVendidas = (int)Math.Round(actual.TamanioMercado * actual.ParticipacionMercado, 0, MidpointRounding.AwayFromZero);
            //}
        }
    }
}