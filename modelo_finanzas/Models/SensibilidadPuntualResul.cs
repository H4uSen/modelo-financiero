using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class SensiPuntResult
    {
        public decimal ValorMenos { get; set; }
        public decimal ValorBase { get; set; }
        public decimal ValorMas { get; set; }

        public decimal VariacionPorcentual { get; set; }
        public decimal GradoSensibilidad { get; set; }
    }
}
