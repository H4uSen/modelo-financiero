using System;
using System.Collections.Generic;
using Microsoft.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using Microsoft.Data;

namespace modelo_finanzas.Models
{
    public class DatosEntrada
    {
        public int Id { get; set; }
        public string NombreEscenario { get; set; }
        public DateTime FechaCreacion    { get; set; } = DateTime.Parse(DateTime.Now.ToString("G"));
        public int TamanioMercado      { get; set; }
        public decimal CrecimientoMercado  { get; set; }
        public int Encuestas           { get; set; }
        public int PersonasInteresadas { get; set; }
        public decimal ObjetivoMercado   { get; set; }
        public decimal InversionEquipos    { get; set; }
        public int DepreciacionAnios   { get; set; }
        public decimal PrecioInicial       { get; set; }
        public decimal IncrementoPrecio  {  get; set; }
        public decimal Inflacion         { get; set; }
        public decimal Ipp               { get; set; }
        public decimal CostoProduccionInicial { get; set; }
        public decimal OtrosIngresos     { get; set; }
        public decimal GastosOperativos  { get; set; }
        public decimal CapitalTrabajo    { get; set; }
        public decimal PorcentajeDeuda   { get; set; }
        public int PlazoCredito        { get; set; }
        public decimal TasaLibreRiesgo   { get; set; }
        public decimal BetaSector        { get; set; }
        public decimal PrimaRiesgoMercado { get; set; }
        public decimal GradienteFlujos   { get; set; }
        public decimal TasaImpuestos     { get; set; }


    }
}