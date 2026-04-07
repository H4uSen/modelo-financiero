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

        public void CalcularVariables(
    Variables actual,
    DatosEntrada datosEntrada,
    DatosEscenarios datosEscenarios,
    Variables anterior = null)
        {
            decimal incremento = (datosEntrada.ObjetivoMercado - datosEscenarios.Mercado_esperado_anio1) / 4;

            if (actual.Anio == 0)
            {
                // Año 0: solo tamaño del mercado
                actual.TamanioMercado = datosEntrada.TamanioMercado;
                actual.ParticipacionMercado = 0;
                actual.PrecioVenta = datosEntrada.PrecioInicial;
                actual.CostoProduccion = datosEntrada.CostoProduccionInicial;
                actual.UnidadesVendidas = 0;
            }
            else if (actual.Anio == 1)
            {
                // Año 1: valores iniciales
                actual.TamanioMercado = anterior.TamanioMercado * (1 + datosEntrada.CrecimientoMercado);
                actual.PrecioVenta = datosEntrada.PrecioInicial;         
                actual.CostoProduccion = datosEntrada.CostoProduccionInicial; 
                actual.ParticipacionMercado = datosEscenarios.Mercado_esperado_anio1; 
                actual.UnidadesVendidas = (int)Math.Round(actual.TamanioMercado * actual.ParticipacionMercado, 0, MidpointRounding.AwayFromZero);
            }
            else
            {
                // Años 2 en adelante
                actual.TamanioMercado = anterior.TamanioMercado * (1 + datosEntrada.CrecimientoMercado);
                actual.PrecioVenta = anterior.PrecioVenta * (1 + datosEscenarios.Variacion_nominal_precio);
                actual.CostoProduccion = anterior.CostoProduccion * (1 + datosEscenarios.Variacion_nominal_ipp);
                actual.ParticipacionMercado = anterior.ParticipacionMercado + incremento;
                actual.UnidadesVendidas = (int)Math.Round(actual.TamanioMercado * actual.ParticipacionMercado, 0, MidpointRounding.AwayFromZero);
            }
        }
    }
}