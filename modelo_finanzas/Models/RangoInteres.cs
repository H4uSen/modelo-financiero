using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class RangoInteres
    {
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal Tasa { get; set; }

        static readonly List<RangoInteres> tabla =
        [
            new RangoInteres { Desde = 0, Hasta = 10, Tasa = 15m },
            new RangoInteres { Desde = 10, Hasta = 20, Tasa = 14.8m },
            new RangoInteres { Desde = 20, Hasta = 30, Tasa = 15.2m },
            new RangoInteres { Desde = 30, Hasta = 40, Tasa = 15.8m },
            new RangoInteres { Desde = 40, Hasta = 50, Tasa = 16.8m },
            new RangoInteres { Desde = 50, Hasta = 60, Tasa = 18.2m },
            new RangoInteres { Desde = 60, Hasta = 70, Tasa = 20m },
            new RangoInteres { Desde = 70, Hasta = 80, Tasa = 22m }
        ];

        public decimal ObtenerTasa(decimal porcentaje)
        {
            foreach (var rango in tabla)
            {
                if (porcentaje > rango.Desde && porcentaje <= rango.Hasta)
                {
                    return rango.Tasa;
                }
            }

            throw new Exception("El porcentaje está fuera de rango");
        }
    }
}
