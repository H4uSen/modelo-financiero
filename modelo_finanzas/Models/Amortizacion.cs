using modelo_finanzas.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class Amortizacion
    {
        public int Id { get; set; }
        public int IdEscenario { get; set; }
        public int Anio { get; set; }
        public decimal SaldoInicial { get; set; } = 0;
        public decimal Cuota { get; set; } = 0;
        public decimal Interes { get; set; } = 0;
        public decimal AbonoCapital { get; set; } = 0;
        public decimal SaldoFinal { get; set; } = 0;

        public List<Amortizacion> Calcular(DatosEntrada entrada)
        {
            var amortizacionService = new AmortizacionService();

            decimal objetivo = (decimal)entrada.ObjetivoMercado;
            if (objetivo < 1) objetivo = objetivo * 100m;


            decimal inversionEquipos = (decimal)entrada.InversionEquipos;
            decimal inversionTotal = inversionEquipos * objetivo;

            double financiamiento = (double)(inversionTotal * (decimal)entrada.PorcentajeDeuda);

            double costoDeudaRaw = (double)new RangoInteres().ObtenerTasa((decimal)entrada.PorcentajeDeuda * 100m);
            double costoDeudaFinal = (costoDeudaRaw < 1) ? costoDeudaRaw * 100 : costoDeudaRaw;

            int plazo = entrada.PlazoCredito;

            return amortizacionService.CalcularTabla(financiamiento, costoDeudaFinal, plazo);


        }
    }
}
