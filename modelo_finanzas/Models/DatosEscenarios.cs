using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo_finanzas.Models
{
    public class DatosEscenarios
    {
        public int Id { get; set; }
        public int Escenario_id { get; set; }

        public decimal Mercado_esperado_anio1 { get; set; } //Encuestas / PersonasInteresadas
        public decimal Variacion_nominal_precio { get; set; } // (1 + Inflacion) * (1 + IncrementoPrecio) - 1
        public decimal Variacion_nominal_ipp { get; set; }// (1 + Inflacion) * (1 + Ipp) - 1
        public decimal Valor_inversion_inicial { get; set; }// InversionEquipos*(ObjetivoMercado*100)
        public decimal Financiado_con_credito { get; set; }//valor_inversion_inicial * PorcentajeDeuda
        public decimal Costo_deuda { get; set; }// % que se saca de la tabla de intereses en el excel
        public decimal Financiado_con_aportes { get; set; }//valor_inversion_inicial - Financiado_con_credito

        public void CalcularDatosEscenarios(DatosEscenarios datosEscenarios, DatosEntrada datosEntrada)
        {
            datosEscenarios.Mercado_esperado_anio1 =  (decimal)datosEntrada.PersonasInteresadas / (decimal)datosEntrada.Encuestas;
            datosEscenarios.Variacion_nominal_precio = ((1 + (decimal)datosEntrada.Inflacion) * (1 + (decimal)datosEntrada.IncrementoPrecio)) - 1;
            datosEscenarios.Variacion_nominal_ipp = ((1 + (decimal)datosEntrada.Inflacion) * (1 + (decimal)datosEntrada.Ipp)) - 1;
            datosEscenarios.Valor_inversion_inicial = (decimal)datosEntrada.InversionEquipos * ((decimal)datosEntrada.ObjetivoMercado * 100);
            datosEscenarios.Financiado_con_credito = datosEscenarios.Valor_inversion_inicial * (decimal)datosEntrada.PorcentajeDeuda;
            RangoInteres rangoInteres = new RangoInteres();
            datosEscenarios.Costo_deuda = rangoInteres.ObtenerTasa((decimal)datosEntrada.PorcentajeDeuda*100);
            datosEscenarios.Financiado_con_aportes = datosEscenarios.Valor_inversion_inicial - datosEscenarios.Financiado_con_credito;
        }
    }
}
