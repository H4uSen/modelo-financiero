using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class SensibilidadPuntual

    {
        public decimal ValorEquiposPorPunto { get; set; }

        public decimal TamanoMercado { get; set; }
        public decimal CrecimientoMercado { get; set; }

        public decimal ParticipacionMercado { get; set; }

        public decimal PrecioVenta { get; set; }

        public decimal InflacionAnualEsperada { get; set; }

        public decimal CostoProduccion { get; set; }

        public decimal GastosOperativos { get; set; }

        public decimal GradienteFlujos { get; set; }

        public decimal TasaImpositiva { get; set; }

        public decimal CostoCapital { get; set; }
    }
    
}
