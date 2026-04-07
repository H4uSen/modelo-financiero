using Microsoft.Data.SqlClient;
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
        public int Id { get; set; }
        public int IdEscenario { get; set; }

        public int Anio { get; set; }
        public decimal Ventas { get; set; } = 0;
        public decimal CostoVentas { get; set; } = 0;
        public decimal UtilidadBruta { get; set; } = 0;
        public decimal GastosOperativos { get; set; } = 0;
        public decimal Depreciacion { get; set; } = 0;
        public decimal TotalGastos { get; set; } = 0;
        public decimal UtilidadOperativa { get; set; } = 0;
        public decimal GastosFinancieros { get; set; } = 0;
        public decimal OtrosIngresos { get; set; } = 0;
        public decimal NetoOtrosIngresos { get; set; } = 0;
        public decimal UtilidadAntesImpuestos { get; set; } = 0;
        public decimal Impuestos { get; set; } = 0;
        public decimal UtilidadNeta { get; set; } = 0;
        public decimal CapitalTrabajo { get; set; } = 0;

        public List<EstadoResultados> CalcularEstado(DatosEntrada entrada, List<Variables> variables,
            DatosEscenarios escenarios, List<Amortizacion> amortizaciones)
        {
            try
            {
                if (variables.Count != 6)
                    throw new Exception("La lista de variables debe contener 6 elementos.");

                if (amortizaciones.Count != 6)
                    throw new Exception("La lista de amortizaciones debe contener 6 elementos.");

                List<EstadoResultados> fila = new List<EstadoResultados>();
                for (int i = 0; i < 6; i++)
                {
                    var variable = variables[i];
                    var amortizacion = amortizaciones[i];
                    var estado = new EstadoResultados();

                    estado.Anio = variable.Anio;

                    decimal unidades = variable.UnidadesVendidas;
                    decimal precio = variable.PrecioVenta;
                    decimal costoUnitario = variable.CostoProduccion;
                    decimal porcGastosOp = entrada.GastosOperativos;
                    decimal inversionInicial = escenarios.Valor_inversion_inicial;
                    int vidaUtil = entrada.DepreciacionAnios;
                    decimal intereses = amortizacion.Interes;
                    decimal tasaImp = entrada.TasaImpuestos;
                    decimal porcCapTrabajo = entrada.CapitalTrabajo;
                    decimal porcOtrosIng = entrada.OtrosIngresos;

                    // --- LÓGICA DE CÁLCULO (Tu lógica de negocio) ---
                    estado.Ventas = unidades * precio;
                    estado.CostoVentas = unidades * costoUnitario;
                    estado.UtilidadBruta = estado.Ventas - estado.CostoVentas;

                    estado.GastosOperativos = estado.Ventas * porcGastosOp;

                    // Regla de Depreciación
                    estado.Depreciacion = (estado.Anio <= vidaUtil) ? (inversionInicial / vidaUtil) : 0;

                    estado.TotalGastos = estado.GastosOperativos + estado.Depreciacion;
                    estado.UtilidadOperativa = estado.UtilidadBruta - estado.TotalGastos;

                    // Parte Financiera
                    estado.GastosFinancieros = intereses;
                    estado.OtrosIngresos = estado.CostoVentas * porcOtrosIng; // Otros ingresos según tu código
                    estado.NetoOtrosIngresos = estado.OtrosIngresos - estado.GastosFinancieros;

                    estado.UtilidadAntesImpuestos = estado.UtilidadOperativa + estado.NetoOtrosIngresos;

                    // Regla de Impuestos: Solo si hay ganancia
                    estado.Impuestos = (estado.UtilidadAntesImpuestos > 0) ? (estado.UtilidadAntesImpuestos * tasaImp) : 0;

                    estado.UtilidadNeta = estado.UtilidadAntesImpuestos - estado.Impuestos;

                    // Cálculo de Capital de Trabajo pedido
                    estado.CapitalTrabajo = estado.Ventas * porcCapTrabajo;

                    fila.Add(estado);
                }

                return fila;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar estado de resultados: " + ex.Message);
            }
        }

        /*public void CalcularEstadoResultados(EstadoResultados estado, Variables variables, DatosEntrada datosEntrada, DatosEscenarios escenarios, Amortizacion amortizacion)
        {
            //TODO: Implementar la lógica de cálculo del estado de resultados utilizando las variables y datos de entrada

        }*/
        /* public void CalcularEstadoResultados(EstadoResultados estado, Variables variables, DatosEntrada datosEntrada, DatosEscenarios escenarios, Amortizacion amortizacion)
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
             if (estado.Anio.Value <= datosEntrada.DepreciacionAnios.Value)
             {
                 estado.Depreciacion = escenarios.Valor_inversion_inicial / datosEntrada.DepreciacionAnios.Value;
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
         }*/


    }
}
