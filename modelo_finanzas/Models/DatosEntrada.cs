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
        public SqlString NombreEscenario    { get; set; } = $"Escenario: {DateTime.Now.ToString("G")}";
        public SqlDateTime FechaCreacion    { get; set; } = SqlDateTime.Parse(DateTime.Now.ToString("G"));
        public SqlInt32 TamanioMercado      { get; set; }
        public SqlDecimal CrecimientoMercado  { get; set; }
        public SqlInt32 Encuestas           { get; set; }
        public SqlInt32 PersonasInteresadas { get; set; }
        public SqlDecimal ObjetivoMercado   { get; set; }
        public SqlMoney InversionEquipos    { get; set; }
        public SqlInt16 DepreciacionAnios   { get; set; }
        public SqlMoney PrecioInicial       { get; set; }
        public SqlDecimal IncrementoPrecio  {  get; set; }
        public SqlDecimal Inflacion         { get; set; }
        public SqlDecimal Ipp               { get; set; }
        public SqlMoney CostoProduccionInicial { get; set; }
        public SqlDecimal OtrosIngresos     { get; set; }
        public SqlDecimal GastosOperativos  { get; set; }
        public SqlDecimal CapitalTrabajo    { get; set; }
        public SqlDecimal PorcentajeDeuda   { get; set; }
        public SqlInt16 PlazoCredito        { get; set; }
        public SqlDecimal TasaLibreRiesgo   { get; set; }
        public SqlDecimal BetaSector        { get; set; }
        public SqlDecimal PrimaRiesgoMercado { get; set; }
        public SqlDecimal GradienteFlujos   { get; set; }
        public SqlDecimal TasaImpuestos     { get; set; }


    }
}