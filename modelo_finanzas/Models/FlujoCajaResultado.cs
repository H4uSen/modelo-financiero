using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class FlujoCajaResultado
    {
        public int Id { get; set; }
        public int IdEscenario { get; set; }

        public decimal ValorTerminal { get; set; }
        public decimal ValorPresenteFlujos { get; set; }
        public decimal ValorPresenteVT { get; set; }
        public decimal ValorMercadoNegocio { get; set; }
        public decimal InversionInicialActivos { get; set; }
        public decimal ValorPresenteNeto { get; set; }

        public void Calcular(List<FlujoCajaLibre> flujos, DatosEscenarios escenario, CostoCapital costoCapital, DatosEntrada entrada)
        {
            //FCL del año 5 * (1 + entrada.gradienteflujos) / (costoCapital.CostoCapital - entrada.gradienteFlujos)
            ValorTerminal = flujos[5].FlujoCajaLibreValor * (1 + entrada.GradienteFlujos) / (costoCapital.CostoCapitalTotal - entrada.GradienteFlujos);

            ValorPresenteFlujos = flujos.Sum(f =>
                (f.Anio > 0) ?
                f.FlujoCajaLibreValor / (decimal)Math.Pow((double)(1 + costoCapital.CostoCapitalTotal), f.Anio):0);

            ValorPresenteVT = ValorTerminal / (decimal)Math.Pow((double)(1 + costoCapital.CostoCapitalTotal), 5);
            ValorMercadoNegocio = ValorTerminal + ValorPresenteFlujos;
            InversionInicialActivos = escenario.Valor_inversion_inicial;
            ValorPresenteNeto = ValorMercadoNegocio - InversionInicialActivos;
        }
    }
}
