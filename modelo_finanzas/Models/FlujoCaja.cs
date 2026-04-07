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
    }
   
    //public async void Calcular(DatosEntrada entrada, )

}
