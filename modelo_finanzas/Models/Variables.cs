using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class Variables
    {
        public int Id { get; set; }
        public int IdEscenario { get; set; }

        public int Anio { get; set; }
        public decimal TamanioMercado { get; set; } = 0;
        public decimal ParticipacionMercado { get; set; } = 0;
        public int UnidadesVendidas { get; set; } = 0;
        public decimal PrecioVenta { get; set; } = 0;
        public decimal CostoProduccion { get; set; } = 0;

        public List<Variables> CalcularVariables(Variables variables, DatosEntrada datosEntrada, DatosEscenarios datosEscenarios)
        {
            //TODO: Implementar la lógica para calcular las variables a partir de los datos de entrada y los datos de escenarios
        }
    }
}
