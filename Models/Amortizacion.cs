
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;


using System;

namespace modelo_finanzas.Models
{
    public class Amortizacion
    {
        public int anio{ get; set; }
        public decimal SaldoInicial { get; set; }
        public decimal Cuota { get; set; }
        public decimal Interes { get; set; }

        public decimal AbonoCapital { get; set; }
        public decimal SaldoFinal { get; set; }
    }
}