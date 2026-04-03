using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class EstadoResultados
    {
        public SqlInt32 Id { get; set; }
        public SqlInt32 IdEscenario { get; set; }

        public SqlInt32 Anio { get; set; }
        public SqlDecimal Ventas { get; set; } = 0;
        public SqlDecimal CostoVentas { get; set; } = 0;
        public SqlDecimal UtilidadBruta { get; set; } = 0;
        public SqlDecimal GastosOperativos { get; set; } = 0;
        public SqlDecimal Depreciacion { get; set; } = 0;
        public SqlDecimal TotalGastos { get; set; } = 0;
        public SqlDecimal UtilidadOperativa { get; set; } = 0;
        public SqlDecimal GastosFinancieros { get; set; } = 0;
        public SqlDecimal OtrosIngresos { get; set; } = 0;
        public SqlDecimal NetoOtrosIngresos { get; set; } = 0;
        public SqlDecimal UtilidadAntesImpuestos { get; set; } = 0;
        public SqlDecimal Impuestos { get; set; } = 0;
        public SqlDecimal UtilidadNeta { get; set; } = 0;
        public SqlDecimal CapitalTrabajo { get; set; } = 0;

        public void CalcularEstadoResultados(EstadoResultados estado, Variables variables, DatosEntrada datosEntrada, DatosEscenarios escenarios, Amortizacion amortizacion)
        {
            //TODO: Implementar la lógica de cálculo del estado de resultados utilizando las variables y datos de entrada
        }
    }
}
