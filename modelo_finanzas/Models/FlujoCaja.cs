using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class FlujoCajaLibre
    {
        public int Id { get; set; }
        public int IdEscenario { get; set; }

        public int Anio { get; set; }

        public decimal UtilidadNeta { get; set; }
        public decimal GastoFinanciero { get; set; }
        public decimal ImpuestosCausados { get; set; }
        public decimal EBIT { get; set; }
        public decimal ImpuestosAjustados { get; set; }
        public decimal EBITUODI { get; set; }
        public decimal Depreciacion { get; set; }
        public decimal FlujoBruto { get; set; }
        public decimal InversionCapitalTrabajo { get; set; }
        public decimal InversionActivosFijos { get; set; }
        public decimal FlujoCajaLibreValor { get; set; }


        public List<FlujoCajaLibre> Calcular(DatosEntrada entrada, DatosEscenarios escenario, List<EstadoResultados> estados)
        {
            List<FlujoCajaLibre> flujos = new List<FlujoCajaLibre>();

            for(int i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    FlujoCajaLibre flujo = new FlujoCajaLibre();

                    flujo.Anio = i;
                    flujo.UtilidadNeta = 0;
                    flujo.GastoFinanciero = 0;
                    flujo.ImpuestosCausados = 0;
                    flujo.EBIT = 0;
                    flujo.ImpuestosAjustados = 0;
                    flujo.EBITUODI = 0;
                    flujo.Depreciacion = 0;
                    flujo.InversionCapitalTrabajo = 0;
                    flujo.InversionActivosFijos = escenario.Valor_inversion_inicial;
                    flujo.FlujoBruto = 0;
                    flujo.FlujoCajaLibreValor = -(escenario.Valor_inversion_inicial);
                    flujos.Add(flujo);
                }
                else
                {

                    FlujoCajaLibre flujo = new FlujoCajaLibre();


                    flujo.Anio = i;
                    flujo.UtilidadNeta = estados[i].UtilidadNeta;
                    flujo.GastoFinanciero = estados[i].GastosFinancieros;
                    flujo.ImpuestosCausados = estados[i].Impuestos;
                    flujo.EBIT = flujo.UtilidadNeta + flujo.GastoFinanciero + flujo.ImpuestosCausados;
                    flujo.ImpuestosAjustados = (flujo.EBIT > 0) ? (flujo.EBIT * entrada.TasaImpuestos) : 0;
                    flujo.EBITUODI = flujo.EBIT - flujo.ImpuestosAjustados;
                    flujo.Depreciacion = estados[i].Depreciacion;
                    flujo.InversionCapitalTrabajo = (i == 1) ? estados[i].CapitalTrabajo : estados[i].CapitalTrabajo - estados[i - 1].CapitalTrabajo;
                    flujo.InversionActivosFijos = i == 0 ? escenario.Valor_inversion_inicial : 0;
                    
                    flujo.FlujoBruto = flujo.EBITUODI + flujo.Depreciacion;
                    flujo.FlujoCajaLibreValor = flujo.FlujoBruto - flujo.InversionCapitalTrabajo - flujo.InversionActivosFijos;
                    flujos.Add(flujo);
                }
            }

            return flujos;
        }

        
    }

}
