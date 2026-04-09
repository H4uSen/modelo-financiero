using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas
{
    public class EscenarioFinanciero
    {
        /*// --- Mercado y Producto ---
        double tamanoActualMercado = 800000;          // 1
        double crecimientoMercado = 0.02;            // 2 (2.00%)
        int encuestasRealizadas = 400;              // 3
        int manifestaronComprar = 9;                // 4
        double objetivoMercado = 0.08;               // 5 (4.00%)
        double precioVentaInicial = 7200;            // 6
        double costoProduccionUnitario = 3500;       // 7
        // --- Macro y Tiempos ---
        double inflacionAnualIPC = 0.035;            // 8 (3.50%)
        double incrementoRealPrecio = 0.008;         // 9 (0.80%)
        double ippRealCostos = 0.01;                 // 10 (1.00%)
        double tasaImpositiva = 0.34;               // 11 (34.00%)
        int horizonteEvaluacion = 5;                 // 12 (Años)
        // --- Inversión y Financiación ---
        double inversionEquiposPorPunto = 55000000;  // 13
        int plazoDepreciacion = 8;                   // 14 (Años)
        double porcentajeFinanciado = 0.40;          // 15 (40.00%)
        int plazoCredito = 5;                        // 16 (Años)
        double costoDeudaEA = 0.16;                  // 17 (16.00%)
        // --- Gastos y Capital de Trabajo ---
        double gastosOperativosPorc = 0.25;          // 18 (25.00%)
        double otrosIngresosPorc = 0.01;             // 19 (1.00%)
        double capitalTrabajoPorc = 0.09;            // 20 (9.00%)
        // --- Variables de Riesgo (WACC) ---
        double tasaLibreRiesgo = 0.11;              // 21 (4.50%)
        double bUdelSector = 0.80;                   // 22 (Beta desapalancado)
        double primaRiesgoMercado = 0.086;                   // Prima de riesgo del mercado 
        double gradienteFlujos = 0.05;*/

        // --- Mercado y Producto ---
        // Esta línea permite que el escenario sea "Global"
        public static EscenarioFinanciero EscenarioActual { get; set; }

        public double tamanoActualMercado { get; set; }          // 1
        public double crecimientoMercado { get; set; }            // 2 (2.00%)
        public int encuestasRealizadas { get; set; }              // 3
        public int manifestaronComprar { get; set; }                // 4
        public double objetivoMercado { get; set; }              // 5 (4.00%)
        public double precioVentaInicial { get; set; }           // 6
        public double costoProduccionUnitario { get; set; }       // 7

        // --- Macro y Tiempos ---
        public double inflacionAnualIPC { get; set; }            // 8 (3.50%)
        public double incrementoRealPrecio { get; set; }         // 9 (0.80%)
        public double ippRealCostos { get; set; }                 // 10 (1.00%)
        public double tasaImpositiva { get; set; }               // 11 (34.00%)
        public int horizonteEvaluacion { get; set; }                 // 12 (Años)

        // --- Inversión y Financiación ---
        public double inversionEquiposPorPunto { get; set; }  // 13
        public int plazoDepreciacion { get; set; }                 // 14 (Años)
        public double porcentajeFinanciado { get; set; }        // 15 (40.00%)
        public int plazoCredito { get; set; }                       // 16 (Años)
        public double costoDeudaEA { get; set; }                  // 17 (16.00%)

        // --- Gastos y Capital de Trabajo ---
        public double gastosOperativosPorc { get; set; }         // 18 (25.00%)
        public double otrosIngresosPorc { get; set; }             // 19 (1.00%)
        public double capitalTrabajoPorc { get; set; }            // 20 (9.00%)

        // --- Variables de Riesgo (WACC) ---
        public double tasaLibreRiesgo { get; set; }              // 21 (4.50%)
        public double bUdelSector { get; set; }                   // 22 (Beta desapalancado)

        public double primaRiesgoMercado { get; set; }                   // Prima de riesgo del mercado 
        public double gradienteFlujos { get; set; }

    }
}
