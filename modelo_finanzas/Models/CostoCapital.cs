using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class CostoCapital
    {
        public int Id { get; set; }
        public int IdEscenario { get; set; }

        public decimal PorcentajeDeuda { get; set; }
        public decimal PorcentajeAportes { get; set; }
        public decimal CostoDeuda { get; set; } 
        public decimal CostoDeudaDespuesImpuestos { get; set; }
        public decimal BetaLSector { get; set; }
        public decimal CostoPatrimonio { get; set; } 
        public decimal CostoCapitalTotal { get; set; }

        public void CalcularCostoCapital(DatosEscenarios escenario, DatosEntrada entrada)
        {
            PorcentajeDeuda = entrada.PorcentajeDeuda;
            PorcentajeAportes = 1 - PorcentajeDeuda;
            CostoDeuda = escenario.Costo_deuda;
            CostoDeudaDespuesImpuestos = CostoDeuda * (1 - entrada.TasaImpuestos);
            BetaLSector = (entrada.BetaSector * (1 + (escenario.Financiado_con_credito/escenario.Financiado_con_aportes) * (1-entrada.TasaImpuestos)));
            CostoPatrimonio = (entrada.TasaLibreRiesgo + BetaLSector * entrada.PrimaRiesgoMercado + 0.06m);
            CostoCapitalTotal = PorcentajeDeuda * CostoDeudaDespuesImpuestos + PorcentajeAportes * CostoPatrimonio;
        }
    }
}
