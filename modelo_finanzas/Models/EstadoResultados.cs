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

        /*public void CalcularEstadoResultados(EstadoResultados estado, Variables variables, DatosEntrada datosEntrada, DatosEscenarios escenarios, Amortizacion amortizacion)
        {
            //TODO: Implementar la lógica de cálculo del estado de resultados utilizando las variables y datos de entrada

        }*/
        public void CalcularEstadoResultados(EstadoResultados estado, Variables variables, DatosEntrada datosEntrada, DatosEscenarios escenarios, Amortizacion amortizacion)
        {
            // 1. VENTAS Y COSTOS (Vienen de los escenarios o datos de entrada)
            estado.Ventas = variables.PrecioVenta * variables.UnidadesVendidas;
            estado.CostoVentas = variables.UnidadesVendidas * variables.CostoProduccion;
            // Aquí pondrías la lógica de proyección, por ahora usemos los valores que ya trae el 'estado'

            // 2. UTILIDAD BRUTA = Ventas - Costo de Ventas
            estado.UtilidadBruta = estado.Ventas - estado.CostoVentas;

            // 3. GASTOS Y DEPRECIACIÓN
            estado.GastosOperativos = estado.Ventas * datosEntrada.GastosOperativos;
            // La depreciación tiene la regla que viste en el Excel:
            if (estado.Anio.Value <= datosEntrada.DepreciacionAnios)
            {
                estado.Depreciacion = escenarios.Valor_inversion_inicial / datosEntrada.DepreciacionAnios;
            }
            else
            {
                estado.Depreciacion = 0;
            }

            estado.TotalGastos = estado.GastosOperativos + estado.Depreciacion;

            // 4. UTILIDAD OPERATIVA
            estado.UtilidadOperativa = estado.UtilidadBruta - estado.TotalGastos;

            // 5. RESULTADO FINANCIERO
            // Los gastos financieros los sacamos de la tabla de amortización de ese año
            estado.GastosFinancieros = amortizacion.Interes;
            estado.OtrosIngresos = estado.CostoVentas * datosEntrada.OtrosIngresos;
            estado.NetoOtrosIngresos = estado.OtrosIngresos - estado.GastosFinancieros;

            // 6. UTILIDAD ANTES DE IMPUESTOS
            estado.UtilidadAntesImpuestos = estado.UtilidadOperativa + estado.NetoOtrosIngresos;

            // 7. IMPUESTOS (Regla: Solo si hay ganancia)
            if (estado.UtilidadAntesImpuestos > 0)
            {
                estado.Impuestos = estado.UtilidadAntesImpuestos * (datosEntrada.TasaImpuestos / 100);
            }
            else
            {
                estado.Impuestos = 0;
            }

            // 8. UTILIDAD NETA
            estado.UtilidadNeta = estado.UtilidadAntesImpuestos - estado.Impuestos;
            estado.CapitalTrabajo = estado.Ventas * datosEntrada.CapitalTrabajo;
        }
    }
}
