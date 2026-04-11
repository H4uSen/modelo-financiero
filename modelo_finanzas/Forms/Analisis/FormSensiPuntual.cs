using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace modelo_finanzas.Forms.Analisis
{
    public partial class FormSensiPuntual : Form
    {
        private List<SensibilidadPuntual> sensi;
        private DatosEntrada _entrada;
        private DatosEscenarios _escenario;
        private CostoCapital _costoCapital;

        public FormSensiPuntual(DatosEntrada entrada, DatosEscenarios escenario, CostoCapital costoCapital, int variacion)
        {
            InitializeComponent();
            _entrada = entrada;
            _escenario = escenario;
            _costoCapital = costoCapital;
            txtPorcentaje.Value = variacion;
            CalcularOpciones(entrada, escenario, costoCapital, variacion);
            this.Load += FormSensiPuntual_Load;
            btnCalcular.Click += BtnCalcular_Click;
        }

        private void BtnCalcular_Click(object? sender, EventArgs e)
        {
            int variacion = (int)txtPorcentaje.Value;
            CalcularOpciones(_entrada, _escenario, _costoCapital, variacion);
        }

        private void CalcularOpciones(DatosEntrada entrada, DatosEscenarios escenario, CostoCapital costoCapital, int variacion)
        {
            dgv.Rows.Clear();
            sensi = new List<SensibilidadPuntual>();
            decimal porcentaje = (decimal)variacion / 100m;

            for (int i = -1; i <= 1; i++)
            {
                decimal factor = 1 + (i * porcentaje);
                sensi.Add(new SensibilidadPuntual
                {
                    ValorEquiposPorPunto = entrada.InversionEquipos * factor,
                    TamanoMercado = (decimal)entrada.TamanioMercado * factor,
                    CrecimientoMercado = entrada.CrecimientoMercado * factor,
                    ParticipacionMercado = entrada.ObjetivoMercado * factor,
                    PrecioVenta = entrada.PrecioInicial * factor,
                    InflacionAnualEsperada = entrada.Inflacion * factor,
                    CostoProduccion = entrada.CostoProduccionInicial * factor,
                    GastosOperativos = entrada.GastosOperativos * factor,
                    GradienteFlujos = entrada.GradienteFlujos * factor,
                    TasaImpositiva = entrada.TasaImpuestos * factor,
                    CostoCapital = costoCapital.CostoCapitalTotal * factor
                });
            }

            //calculo de VPN para menos
            SensiPuntResult valorEquipoVPN = new SensiPuntResult();
            SensiPuntResult tamanoMercadoVPN = new SensiPuntResult();
            SensiPuntResult crecimientoMercadoVPN = new SensiPuntResult();
            SensiPuntResult participacionMercadoVPN = new SensiPuntResult();
            SensiPuntResult precioVentaVPN = new SensiPuntResult();
            SensiPuntResult inflacionVPN = new SensiPuntResult();
            SensiPuntResult costoProduccionVPN = new SensiPuntResult();
            SensiPuntResult gastosOperativosVPN = new SensiPuntResult();
            SensiPuntResult gradienteFlujosVPN = new SensiPuntResult();
            SensiPuntResult tasaImpositivaVPN = new SensiPuntResult();
            SensiPuntResult costoCapitalVPN = new SensiPuntResult();
            
            // Menos
            valorEquipoVPN.ValorMenos = CalcularVPN(entrada, overrideEquipos: sensi[0].ValorEquiposPorPunto);
            tamanoMercadoVPN.ValorMenos = CalcularVPN(entrada, overrideTamano: sensi[0].TamanoMercado);
            crecimientoMercadoVPN.ValorMenos = CalcularVPN(entrada, overrideCrecimiento: sensi[0].CrecimientoMercado);
            participacionMercadoVPN.ValorMenos = CalcularVPN(entrada, overrideParticipacion: sensi[0].ParticipacionMercado);
            precioVentaVPN.ValorMenos = CalcularVPN(entrada, overridePrecio: sensi[0].PrecioVenta);
            inflacionVPN.ValorMenos = CalcularVPN(entrada, overrideInflacion: sensi[0].InflacionAnualEsperada);
            costoProduccionVPN.ValorMenos = CalcularVPN(entrada, overrideCostoProd: sensi[0].CostoProduccion);
            gastosOperativosVPN.ValorMenos = CalcularVPN(entrada, overrideGastosOperativos: sensi[0].GastosOperativos);
            gradienteFlujosVPN.ValorMenos = CalcularVPN(entrada, overrideGradiente: sensi[0].GradienteFlujos);
            tasaImpositivaVPN.ValorMenos = CalcularVPN(entrada, overrideTasaImp: sensi[0].TasaImpositiva);
            costoCapitalVPN.ValorMenos = CalcularVPN(entrada, overrideCostoCap: sensi[0].CostoCapital);

            // Base
            valorEquipoVPN.ValorBase = CalcularVPN(entrada, overrideEquipos: sensi[1].ValorEquiposPorPunto);
            tamanoMercadoVPN.ValorBase = CalcularVPN(entrada, overrideTamano: sensi[1].TamanoMercado);
            crecimientoMercadoVPN.ValorBase = CalcularVPN(entrada, overrideCrecimiento: sensi[1].CrecimientoMercado);
            participacionMercadoVPN.ValorBase = CalcularVPN(entrada, overrideParticipacion: sensi[1].ParticipacionMercado);
            precioVentaVPN.ValorBase = CalcularVPN(entrada, overridePrecio: sensi[1].PrecioVenta);
            inflacionVPN.ValorBase = CalcularVPN(entrada, overrideInflacion: sensi[1].InflacionAnualEsperada);
            costoProduccionVPN.ValorBase = CalcularVPN(entrada, overrideCostoProd: sensi[1].CostoProduccion);
            gastosOperativosVPN.ValorBase = CalcularVPN(entrada, overrideGastosOperativos: sensi[1].GastosOperativos);
            gradienteFlujosVPN.ValorBase = CalcularVPN(entrada, overrideGradiente: sensi[1].GradienteFlujos);
            tasaImpositivaVPN.ValorBase = CalcularVPN(entrada, overrideTasaImp: sensi[1].TasaImpositiva);
            costoCapitalVPN.ValorBase = CalcularVPN(entrada, overrideCostoCap: sensi[1].CostoCapital);

            // Mas
            valorEquipoVPN.ValorMas = CalcularVPN(entrada, overrideEquipos: sensi[2].ValorEquiposPorPunto);
            tamanoMercadoVPN.ValorMas = CalcularVPN(entrada, overrideTamano: sensi[2].TamanoMercado);
            crecimientoMercadoVPN.ValorMas = CalcularVPN(entrada, overrideCrecimiento: sensi[2].CrecimientoMercado);
            participacionMercadoVPN.ValorMas = CalcularVPN(entrada, overrideParticipacion: sensi[2].ParticipacionMercado);
            precioVentaVPN.ValorMas = CalcularVPN(entrada, overridePrecio: sensi[2].PrecioVenta);
            inflacionVPN.ValorMas = CalcularVPN(entrada, overrideInflacion: sensi[2].InflacionAnualEsperada);
            costoProduccionVPN.ValorMas = CalcularVPN(entrada, overrideCostoProd: sensi[2].CostoProduccion);
            gastosOperativosVPN.ValorMas = CalcularVPN(entrada, overrideGastosOperativos: sensi[2].GastosOperativos);
            gradienteFlujosVPN.ValorMas = CalcularVPN(entrada, overrideGradiente: sensi[2].GradienteFlujos);
            tasaImpositivaVPN.ValorMas = CalcularVPN(entrada, overrideTasaImp: sensi[2].TasaImpositiva);
            costoCapitalVPN.ValorMas = CalcularVPN(entrada, overrideCostoCap: sensi[2].CostoCapital);

            AgregarFilaSensi("VALOR EQUIPOS (por punto)", "N0", valorEquipoVPN, sensi[0].ValorEquiposPorPunto, sensi[1].ValorEquiposPorPunto, sensi[2].ValorEquiposPorPunto, porcentaje);
            AgregarFilaSensi("TAMAÑO DEL MERCADO", "N0", tamanoMercadoVPN, sensi[0].TamanoMercado, sensi[1].TamanoMercado, sensi[2].TamanoMercado, porcentaje);
            AgregarFilaSensi("CRECIMIENTO DEL MERCADO", "P1", crecimientoMercadoVPN, sensi[0].CrecimientoMercado, sensi[1].CrecimientoMercado, sensi[2].CrecimientoMercado, porcentaje);
            AgregarFilaSensi("PARTICIPACIÓN EN EL MERCADO", "P1", participacionMercadoVPN, sensi[0].ParticipacionMercado, sensi[1].ParticipacionMercado, sensi[2].ParticipacionMercado, porcentaje);
            AgregarFilaSensi("PRECIO DE VENTA", "N0", precioVentaVPN, sensi[0].PrecioVenta, sensi[1].PrecioVenta, sensi[2].PrecioVenta, porcentaje);
            AgregarFilaSensi("INFLACIÓN ANUAL ESPERADA", "P1", inflacionVPN, sensi[0].InflacionAnualEsperada, sensi[1].InflacionAnualEsperada, sensi[2].InflacionAnualEsperada, porcentaje);
            AgregarFilaSensi("COSTO DE PRODUCCIÓN", "N0", costoProduccionVPN, sensi[0].CostoProduccion, sensi[1].CostoProduccion, sensi[2].CostoProduccion, porcentaje);
            AgregarFilaSensi("GASTOS OPERATIVOS", "P1", gastosOperativosVPN, sensi[0].GastosOperativos, sensi[1].GastosOperativos, sensi[2].GastosOperativos, porcentaje);
            AgregarFilaSensi("GRADIENTE DE LOS FLUJOS", "P1", gradienteFlujosVPN, sensi[0].GradienteFlujos, sensi[1].GradienteFlujos, sensi[2].GradienteFlujos, porcentaje);
            AgregarFilaSensi("TASA IMPOSITIVA", "P1", tasaImpositivaVPN, sensi[0].TasaImpositiva, sensi[1].TasaImpositiva, sensi[2].TasaImpositiva, porcentaje);
            AgregarFilaSensi("COSTO DE CAPITAL", "P2", costoCapitalVPN, sensi[0].CostoCapital, sensi[1].CostoCapital, sensi[2].CostoCapital, porcentaje);

        }

        private void AgregarFilaSensi(string nombre, string formatoVar, SensiPuntResult resultVPN, decimal valMenos, decimal valCero, decimal valMas, decimal porcentajeVarX)
        {
            // Fila 1: Valores de la variable
            int indexVar = dgv.Rows.Add(nombre, valMenos.ToString(formatoVar), valCero.ToString(formatoVar), valMas.ToString(formatoVar), "", "");
            dgv.Rows[indexVar].DefaultCellStyle.BackColor = Color.LightGreen;

            // Calcular GSP y % Y
            decimal deltaY = 0;
            if (resultVPN.ValorBase != 0)
                deltaY = (resultVPN.ValorMas - resultVPN.ValorBase) / Math.Abs(resultVPN.ValorBase);

            decimal gsp = 0;
            if (porcentajeVarX != 0)
                gsp = deltaY / porcentajeVarX;

            // Fila 2: VPNs
            int indexVpn = dgv.Rows.Add(
                resultVPN.ValorBase.ToString("N0"), 
                resultVPN.ValorMenos.ToString("N0"), 
                resultVPN.ValorBase.ToString("N0"), 
                resultVPN.ValorMas.ToString("N0"), 
                deltaY.ToString("P1").Replace("-", "(").Replace(" %", "%)"), 
                gsp.ToString("N1")
            );
            dgv.Rows[indexVpn].Cells[0].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void FormSensiPuntual_Load(object? sender, EventArgs e)
        {

        }

        public decimal CalcularVPN(
            DatosEntrada dEntradaOriginal, 
            decimal? overrideCostoCap = null, 
            decimal? overrideParticipacion = null,
            decimal? overrideEquipos = null,
            decimal? overrideTamano = null,
            decimal? overrideCrecimiento = null,
            decimal? overridePrecio = null,
            decimal? overrideInflacion = null,
            decimal? overrideCostoProd = null,
            decimal? overrideGastosOperativos = null,
            decimal? overrideGradiente = null,
            decimal? overrideTasaImp = null)
        {
            DatosEntrada dEntrada = new DatosEntrada
            {
                TamanioMercado = dEntradaOriginal.TamanioMercado,
                CrecimientoMercado = dEntradaOriginal.CrecimientoMercado,
                Encuestas = dEntradaOriginal.Encuestas,
                PersonasInteresadas = dEntradaOriginal.PersonasInteresadas,
                ObjetivoMercado = dEntradaOriginal.ObjetivoMercado,
                InversionEquipos = dEntradaOriginal.InversionEquipos,
                DepreciacionAnios = dEntradaOriginal.DepreciacionAnios,
                PrecioInicial = dEntradaOriginal.PrecioInicial,
                IncrementoPrecio = dEntradaOriginal.IncrementoPrecio,
                Inflacion = dEntradaOriginal.Inflacion,
                Ipp = dEntradaOriginal.Ipp,
                CostoProduccionInicial = dEntradaOriginal.CostoProduccionInicial,
                OtrosIngresos = dEntradaOriginal.OtrosIngresos,
                GastosOperativos = dEntradaOriginal.GastosOperativos,
                CapitalTrabajo = dEntradaOriginal.CapitalTrabajo,
                PorcentajeDeuda = dEntradaOriginal.PorcentajeDeuda,
                PlazoCredito = dEntradaOriginal.PlazoCredito,
                TasaLibreRiesgo = dEntradaOriginal.TasaLibreRiesgo,
                BetaSector = dEntradaOriginal.BetaSector,
                PrimaRiesgoMercado = dEntradaOriginal.PrimaRiesgoMercado,
                GradienteFlujos = dEntradaOriginal.GradienteFlujos,
                TasaImpuestos = dEntradaOriginal.TasaImpuestos
            };

            if (overrideEquipos.HasValue) dEntrada.InversionEquipos = overrideEquipos.Value;
            if (overrideTamano.HasValue) dEntrada.TamanioMercado = (int)overrideTamano.Value;
            if (overrideCrecimiento.HasValue) dEntrada.CrecimientoMercado = overrideCrecimiento.Value;
            if (overridePrecio.HasValue) dEntrada.PrecioInicial = overridePrecio.Value;
            if (overrideInflacion.HasValue) dEntrada.Inflacion = overrideInflacion.Value;
            if (overrideCostoProd.HasValue) dEntrada.CostoProduccionInicial = overrideCostoProd.Value;
            if (overrideGastosOperativos.HasValue) dEntrada.GastosOperativos = overrideGastosOperativos.Value;
            if (overrideGradiente.HasValue) dEntrada.GradienteFlujos = overrideGradiente.Value;
            if (overrideTasaImp.HasValue) dEntrada.TasaImpuestos = overrideTasaImp.Value;
            if (overrideParticipacion.HasValue)
            {
                // Modificamos personas interesadas para que el cálculo inicial de participación cuadre
                dEntrada.PersonasInteresadas = (int)Math.Round(dEntrada.Encuestas * overrideParticipacion.Value);
            }

            EscenarioFinanciero datos = dEntrada.ToEscenarioFinanciero();

            // Para el costo de capital, pasamos la modificación como una bandera pero en EscenarioFinanciero 
            // no hay forma directa.
            // Si overrideCostoCap está presente, quizás CalculadorFinanciero no lo use
            // pero intentemos primero usar CalculadorFinanciero.
            CalculadorFinanciero calculador = new CalculadorFinanciero();

            // En CalculadorFinanciero.CalcularSoloVPN, el costo de capital (WACC) se calcula internamente, 
            // así que no podemos sobreescribirlo directamente al llamar a esa función. 
            // Por lo que el overrideCostoCap puede no funcionar perfectamente igual 
            // a menos que podamos pasarlo de alguna manera... pero probemos esto.
            decimal vpn = (decimal)calculador.CalcularSoloVPN(datos, datos.inflacionAnualIPC, datos.objetivoMercado, true);
            return vpn;
        }

        private void btnPdf_Click(object? sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo PDF (*.pdf)|*.pdf";
            sfd.FileName = "Analisis_Sensibilidad_Puntual.pdf";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4.Rotate(), 10f, 10f, 20f, 10f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();

                        // Título
                        Paragraph title = new Paragraph("Análisis de sensibilidad puntual del VPN", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                        title.Alignment = Element.ALIGN_CENTER;
                        title.SpacingAfter = 10f;
                        pdfDoc.Add(title);

                        PdfPTable pdfTable = new PdfPTable(dgv.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        // Agregar cabeceras
                        foreach (DataGridViewColumn column in dgv.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10)));
                            cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                            pdfTable.AddCell(cell);
                        }

                        // Agregar filas
                        foreach (DataGridViewRow row in dgv.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string valor = cell.Value != null ? cell.Value.ToString() : "";
                                    PdfPCell pCell = new PdfPCell(new Phrase(valor, FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                                    // Comprobar si debemos alinear a la derecha - para números, suele ser buena idea.
                                    if (cell.ColumnIndex > 0)
                                        pCell.HorizontalAlignment = Element.ALIGN_RIGHT;

                                    if (row.DefaultCellStyle.BackColor == System.Drawing.Color.LightGreen)
                                        pCell.BackgroundColor = new iTextSharp.text.BaseColor(144, 238, 144);

                                    pdfTable.AddCell(pCell);
                                }
                            }
                        }

                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();
                    }

                    MessageBox.Show("Archivo PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al generar PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
