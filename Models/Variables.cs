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
        public SqlInt32 Id { get; set; }
        public SqlInt32 IdEscenario { get; set; }

        public SqlInt32 Anio { get; set; }
        public SqlDecimal TamanioMercado { get; set; } = 0;
        public SqlDecimal ParticipacionMercado { get; set; } = 0;
        public SqlInt32 UnidadesVendidas { get; set; } = 0;
        public SqlMoney PrecioVenta { get; set; } = 0;
        public SqlMoney CostoProduccion { get; set; } = 0;

        public SqlDecimal InversionOpciones { get; set; } = 0;
        public SqlDecimal TasaInteresAnual { get; set; } = 0;
        public SqlInt32 PlazoMeses { get; set; } = 0;

        public void CalcularVariables(Variables variables, DatosEntrada datosEntrada, DatosEscenarios datosEscenarios)
        {
            //TODO: Implementar la lógica para calcular las variables a partir de los datos de entrada y los datos de escenarios
        }
    }
}
