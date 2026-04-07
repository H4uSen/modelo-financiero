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
            decimal incremento =
                (datosEntrada.ObjetivoMercado - datosEscenarios.Mercado_esperado_anio1) / 4;

            if (actual.Anio == 0 || anterior == null)
            {
                actual.TamanioMercado = datosEntrada.TamanioMercado;
                actual.ParticipacionMercado = datosEntrada.ObjetivoMercado;
                actual.PrecioVenta = datosEntrada.PrecioInicial;
                actual.CostoProduccion = datosEntrada.CostoProduccionInicial;
            }
            else
            {
                actual.TamanioMercado =
                    anterior.TamanioMercado * (1 + datosEntrada.CrecimientoMercado);

                actual.PrecioVenta =
                    anterior.PrecioVenta * (1 + datosEscenarios.Variacion_nominal_precio);

                actual.CostoProduccion =
                    anterior.CostoProduccion * (1 + datosEscenarios.Variacion_nominal_ipp);

                if (actual.Anio == 1)
                {
                    actual.ParticipacionMercado =
                        datosEscenarios.Mercado_esperado_anio1;
                }
                else
                {
                    actual.ParticipacionMercado =
                        anterior.ParticipacionMercado + incremento;
                }
            }

            actual.UnidadesVendidas =
                (int)(actual.TamanioMercado * actual.ParticipacionMercado);
        }
    }
}