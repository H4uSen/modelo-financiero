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

        public void CalcularAmortizacion(Amortizacion amortizacion, DatosEntrada datosEntrada, Variables variables, DatosEscenarios escenarios)
        {
            //TODO: Implementar el cálculo de amortización
        }
    }
}
