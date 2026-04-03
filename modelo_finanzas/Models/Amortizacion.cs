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
        public SqlInt32 Id { get; set; }
        public SqlInt32 IdEscenario { get; set; }

        public SqlInt32 Anio { get; set; }
        public SqlDecimal SaldoInicial { get; set; } = 0;
        public SqlDecimal Cuota { get; set; } = 0;
        public SqlDecimal Interes { get; set; } = 0;
        public SqlDecimal AbonoCapital { get; set; } = 0;
        public SqlDecimal SaldoFinal { get; set; } = 0;

        public void CalcularAmortizacion(Amortizacion amortizacion, DatosEntrada datosEntrada, Variables variables, DatosEscenarios escenarios)
        {
            //TODO: Implementar el cálculo de amortización
        }
    }
}
