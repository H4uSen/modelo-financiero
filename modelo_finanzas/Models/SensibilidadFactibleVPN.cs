using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class SensibilidadFactibleVpn
    {
        public int Id { get; set; }
        public int IdEscenario { get; set; }

        public decimal CrecimientoMercado { get; set; }
        public decimal CrecimientoMercadoVpn { get; set; }

        public decimal ParticipacionMercado { get; set; }
        public decimal ParticipacionMercadoVpn { get; set; }

        public decimal PrecioVenta { get; set; }
        public decimal PrecioVentaVpn { get; set; }

        public decimal InflacionAnual { get; set; }
        public decimal InflacionAnualVpn { get; set; }

        public decimal CostoProduccion { get; set; }
        public decimal CostoProduccionVpn { get; set; }

        public decimal GastosOperativos { get; set; }
        public decimal GastosOperativosVpn { get; set; }
    }
}
