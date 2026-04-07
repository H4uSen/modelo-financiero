using modelo_finanzas.Forms.Salidas;
using modelo_finanzas.Logic;
using modelo_finanzas.Models;
using modelo_finanzas.Services;
using modelo_finanzas.Utils;
using Prueba1;
using System.Configuration;
using System.Data.SqlTypes;
namespace modelo_finanzas
{
    public partial class FormEntradaDatos : Form
    {
        private DatosEntrada datosCargados;

        public FormEntradaDatos(DatosEntrada datosExternos = null)
        {
            InitializeComponent();
            this.AutoScroll = true;

            datosCargados = datosExternos;

            txtNombreEscenario.MaxLength = 50;
            txtNombreEscenario.Tag = "optional";

            txtFechaCreacion.MaxLength = 50;
            txtFechaCreacion.Enabled = false;
            txtFechaCreacion.Tag = "optional";
            txtFechaCreacion.Text = DateTime.Now.ToString("G");

            txtNombreEscenario.TabIndex = 0;
            txtFechaCreacion.TabIndex = 1;
            txtTamanioMercado.TabIndex = 2;
            txtCrecimientoAnualMerc.TabIndex = 3;
            txtEncRealizadas.TabIndex = 4;
            txtObjeMer.TabIndex = 5;
            txtManiComp.TabIndex = 6;
            txtCostProdIni.TabIndex = 7;
            txtCapTrab.TabIndex = 8;
            txtGastOper.TabIndex = 9;
            txtPrecioProducto.TabIndex = 10;
            txtIncRealPrec.TabIndex = 11;
            txtIPP.TabIndex = 12;
            txtInflaAnual.TabIndex = 13;
            txtInvEquiXPart.TabIndex = 14;
            txtRecupSobreCosto.TabIndex = 15;
            txtTasaLibRiesgo.TabIndex = 16;
            txtPrimRiesgMerc.TabIndex = 17;
            txtGradFlujos.TabIndex = 18;
            txtPlazoDep.TabIndex = 19;
            txtFinanCredito.TabIndex = 20;
            txtPlazoCredito.TabIndex = 21;
            txtBetaSector.TabIndex = 22;
            txtTasaImpositiva.TabIndex = 23;
            btnTest.TabIndex = 24;
            btnCancelar.TabIndex = 25;
            btnCalcular.TabIndex = 26;

            gpbMercado.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Enter += InputValidator.removeFormat);
            gpbCostos.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Enter += InputValidator.removeFormat);
            gpbInversion.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Enter += InputValidator.removeFormat);
            gpbInversion.Controls.OfType<TextBox>().ToList().ForEach(tb => tb.Enter += InputValidator.removeFormat);

            #region Mercado y demanda


            txtTamanioMercado.MaxLength = 15;
            txtEncRealizadas.MaxLength = 15;
            txtCrecimientoAnualMerc.MaxLength = 5;
            txtObjeMer.MaxLength = 5;
            txtManiComp.MaxLength = 15;

            //Sanitizacioon inputs
            txtCrecimientoAnualMerc.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtCrecimientoAnualMerc, e);
            };
            txtObjeMer.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtObjeMer, e);
            };
            txtManiComp.KeyPress += (s, e) =>
            {
                InputValidator.integerValidation(txtManiComp, e);
            };
            txtEncRealizadas.KeyPress += (s, e) =>
            {
                InputValidator.integerValidation(txtEncRealizadas, e);
            };
            txtTamanioMercado.KeyPress += txtTamanioMercado_KeyPress;


            //Formateo de inputs 
            txtCrecimientoAnualMerc.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtObjeMer.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtTamanioMercado.Validated += (s, e) => inputFormatter.integerFormatter(s, e);
            txtEncRealizadas.Validated += (s, e) => inputFormatter.integerFormatter(s, e);
            txtManiComp.Validated += (s, e) => inputFormatter.integerFormatter(s, e);
            #endregion

            #region Costos
            txtCostProdIni.MaxLength = 15;
            txtCapTrab.MaxLength = 5;
            txtGastOper.MaxLength = 5;

            //Sanitizacion inputs
            txtCostProdIni.KeyPress += (s, e) =>
            {
                InputValidator.integerValidation(txtCostProdIni, e);
            };
            txtCapTrab.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtCapTrab, e);
            };
            txtGastOper.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtGastOper, e);
            };

            //Formateo de inputs
            txtCostProdIni.Validated += (s, e) => inputFormatter.integerFormatter(s, e);
            txtCapTrab.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtGastOper.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");

            #endregion

            #region Precios e inflacion
            txtPrecioProducto.MaxLength = 15;
            txtIncRealPrec.MaxLength = 5;
            txtIPP.MaxLength = 5;
            txtInflaAnual.MaxLength = 5;

            //Sanitizacion inputs
            txtPrecioProducto.KeyPress += (s, e) =>
            {
                InputValidator.integerValidation(txtPrecioProducto, e);
            };
            txtIncRealPrec.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtIncRealPrec, e);
            };
            txtIPP.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtIPP, e);
            };
            txtInflaAnual.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtInflaAnual, e);
            };

            //Formateo de inputs
            txtPrecioProducto.Validated += (s, e) => inputFormatter.integerFormatter(s, e);
            txtIncRealPrec.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtIPP.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtInflaAnual.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            #endregion

            #region Inversion, financiamiento y otros
            txtInvEquiXPart.MaxLength = 15;
            txtRecupSobreCosto.MaxLength = 5;
            txtTasaLibRiesgo.MaxLength = 5;
            txtPrimRiesgMerc.MaxLength = 5;
            txtGradFlujos.MaxLength = 5;
            txtPlazoDep.MaxLength = 2;
            txtFinanCredito.MaxLength = 5;
            txtPlazoCredito.MaxLength = 2;
            txtBetaSector.MaxLength = 5;
            txtTasaLibRiesgo.MaxLength = 5;

            //Sanitizacion inputs
            txtInvEquiXPart.KeyPress += (s, e) =>
                { InputValidator.integerValidation(txtInvEquiXPart, e); };
            txtRecupSobreCosto.KeyPress += (s, e) =>
                { InputValidator.decimalValidation(txtRecupSobreCosto, e); };
            txtTasaLibRiesgo.KeyPress += (s, e) =>
                { InputValidator.decimalValidation(txtTasaLibRiesgo, e); };
            txtPrimRiesgMerc.KeyPress += (s, e) =>
                { InputValidator.decimalValidation(txtPrimRiesgMerc, e); };
            txtGradFlujos.KeyPress += (s, e) =>
                { InputValidator.decimalValidation(txtGradFlujos, e); };
            txtPlazoDep.KeyPress += (s, e) =>
                { InputValidator.integerValidation(txtPlazoDep, e); };
            txtFinanCredito.KeyPress += (s, e) =>
                { InputValidator.decimalValidation(txtFinanCredito, e); };
            txtPlazoCredito.KeyPress += (s, e) =>
                { InputValidator.integerValidation(txtPlazoCredito, e); };
            txtBetaSector.KeyPress += (s, e) =>
                { InputValidator.decimalValidation(txtBetaSector, e); };
            txtTasaImpositiva.KeyPress += (s, e) =>
                { InputValidator.decimalValidation(txtTasaImpositiva, e); };

            //formateo de inputs
            txtInvEquiXPart.Validated += (s, e) => inputFormatter.integerFormatter(s, e);
            txtRecupSobreCosto.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtTasaLibRiesgo.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtPrimRiesgMerc.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtGradFlujos.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtPlazoDep.Validated += (s, e) => inputFormatter.integerFormatter(s, e, " años");
            txtFinanCredito.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");
            txtPlazoCredito.Validated += (s, e) => inputFormatter.integerFormatter(s, e, " años");
            txtBetaSector.Validated += (s, e) => inputFormatter.decimalFormatter(s, e);
            txtTasaImpositiva.Validated += (s, e) => inputFormatter.decimalFormatter(s, e, "%");

            #endregion

            this.Load += FormEntradaDatos_Load;
        }

        private void FormEntradaDatos_Load(object sender, EventArgs e)
        {
            if (datosCargados != null)
            {
                CargarDatosEnControles(datosCargados);
                button3_Click(this, EventArgs.Empty);
            }
        }

        private void CargarDatosEnControles(DatosEntrada d)
        {
            // Identificación
            txtNombreEscenario.Text = d.NombreEscenario;
            txtFechaCreacion.Text = d.FechaCreacion.ToString("G");

            // Mercado y demanda
            txtTamanioMercado.Text = d.TamanioMercado.ToString("N0");
            txtCrecimientoAnualMerc.Text = (d.CrecimientoMercado * 100).ToString("0.00") + "%";
            txtEncRealizadas.Text = d.Encuestas.ToString("N0");
            txtObjeMer.Text = (d.ObjetivoMercado * 100).ToString("0.00") + "%";
            txtManiComp.Text = d.PersonasInteresadas.ToString("N0");

            // Costos
            txtCostProdIni.Text = d.CostoProduccionInicial.ToString("N0");
            txtCapTrab.Text = (d.CapitalTrabajo * 100).ToString("0.00") + "%";
            txtGastOper.Text = (d.GastosOperativos * 100).ToString("0.00") + "%";

            // Precios e inflacion
            txtPrecioProducto.Text = d.PrecioInicial.ToString("N0");
            txtIncRealPrec.Text = (d.IncrementoPrecio * 100).ToString("0.00") + "%";
            txtIPP.Text = (d.Ipp * 100).ToString("0.00") + "%";
            txtInflaAnual.Text = (d.Inflacion * 100).ToString("0.00") + "%";

            // Inversion, financiamiento y otros
            txtInvEquiXPart.Text = d.InversionEquipos.ToString("N0");
            txtRecupSobreCosto.Text = (d.OtrosIngresos * 100).ToString("0.00") + "%";
            txtTasaLibRiesgo.Text = (d.TasaLibreRiesgo * 100).ToString("0.00") + "%";
            txtPrimRiesgMerc.Text = (d.PrimaRiesgoMercado * 100).ToString("0.00") + "%";
            txtGradFlujos.Text = (d.GradienteFlujos * 100).ToString("0.00") + "%";
            txtPlazoDep.Text = d.DepreciacionAnios.ToString() + " años";
            txtFinanCredito.Text = (d.PorcentajeDeuda * 100).ToString("0.00") + "%";
            txtPlazoCredito.Text = d.PlazoCredito.ToString() + " años";
            txtBetaSector.Text = d.BetaSector.ToString("0.00");
            txtTasaImpositiva.Text = (d.TasaImpuestos * 100).ToString("0.00") + "%";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DbConnection db = DbConnection.Instance;
            if (await db.TestConnectionAsync())
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos.");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtTamanioMercado_KeyPress(object? sender, KeyPressEventArgs e)
        {
            InputValidator.integerValidation(txtTamanioMercado, e);
        }

        DatosEntrada datos = new DatosEntrada();
        DatosEscenarios escenarios = new DatosEscenarios();
        Variables variables = new Variables();
        Amortizacion amortizacion = new Amortizacion();
        EstadoResultado estadoResultados = new EstadoResultado();

        private async void button3_Click(object sender, EventArgs e)
        {
          

            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Rellene los campos marcados.");
                return;
            }

            try
            {
                // Assign a fresh time before storing just in case
                txtFechaCreacion.Text = DateTime.Now.ToString("G");

                datos.NombreEscenario = (txtNombreEscenario.Text.Length == 0) ?
                    $"Escenario: {DateTime.Now.ToString("G")}"
                    : txtNombreEscenario.Text;
                datos.FechaCreacion = DateTime.Parse(txtFechaCreacion.Text);
                //Mercado y demanda
                datos.TamanioMercado = int.Parse(txtTamanioMercado.Text.Replace(",", ""));
                datos.CrecimientoMercado = decimal.Parse(txtCrecimientoAnualMerc.Text.Replace("%", "")) / 100;
                datos.Encuestas = int.Parse(txtEncRealizadas.Text.Replace(",", ""));
                datos.ObjetivoMercado = decimal.Parse(txtObjeMer.Text.Replace("%", "")) / 100;
                datos.PersonasInteresadas = int.Parse(txtManiComp.Text.Replace(",", ""));
                //Costos
                datos.CostoProduccionInicial = decimal.Parse(txtCostProdIni.Text);
                datos.CapitalTrabajo = decimal.Parse(txtCapTrab.Text.Replace("%", "")) / 100;
                datos.GastosOperativos = decimal.Parse(txtGastOper.Text.Replace("%", "")) / 100;
                //Precios e inflacion
                datos.PrecioInicial = decimal.Parse(txtPrecioProducto.Text);
                datos.IncrementoPrecio = decimal.Parse(txtIncRealPrec.Text.Replace("%", "")) / 100;
                datos.Ipp = decimal.Parse(txtIPP.Text.Replace("%", "")) / 100;
                datos.Inflacion = decimal.Parse(txtInflaAnual.Text.Replace("%", "")) / 100;
                //Inversion, financiamiento y otros
                datos.InversionEquipos = decimal.Parse(txtInvEquiXPart.Text);
                datos.OtrosIngresos = decimal.Parse(txtRecupSobreCosto.Text.Replace("%", "")) / 100;
                datos.TasaLibreRiesgo = decimal.Parse(txtTasaLibRiesgo.Text.Replace("%", "")) / 100;
                datos.PrimaRiesgoMercado = decimal.Parse(txtPrimRiesgMerc.Text.Replace("%", "")) / 100;
                datos.GradienteFlujos = decimal.Parse(txtGradFlujos.Text.Replace("%", "")) / 100;
                datos.DepreciacionAnios = int.Parse(txtPlazoDep.Text.Replace(" años", ""));
                datos.PorcentajeDeuda = decimal.Parse(txtFinanCredito.Text.Replace("%", "")) / 100;
                datos.PlazoCredito = int.Parse(txtPlazoCredito.Text.Replace(" años", ""));
                datos.BetaSector = decimal.Parse(txtBetaSector.Text.Replace("%", ""));
                datos.TasaImpuestos = decimal.Parse(txtTasaImpositiva.Text.Replace("%", "")) / 100;*/

                panel2.Controls.Clear();

                // Primero calcular escenario
                escenarios.CalcularDatosEscenarios(escenarios, datos);

                // Luego abrir el FormVariables que hará el cálculo y llenado del DataGridView
                FormVariables formVariables = new FormVariables(datos, escenarios);
                formVariables.Show();


                amortizacion.CalcularAmortizacion(amortizacion, datos, variables, escenarios);
                // estadoResultados.IdEscenario = escenarioID;
                // estadoResultados.CalcularEstadoResultados(estadoResultados, variables, datos, escenarios, amortizacion);

                FormDatosEscenario formDatosEscenario = new FormDatosEscenario(escenarios);
                ChildForm.Open(formDatosEscenario, new Point(0, 0), panel2);

                //Calculo de costo de capital
                CostoCapital costoCapital = new CostoCapital();
                costoCapital.CalcularCostoCapital(escenarios, datos);
                FormCostoCapital formCostoCapital = new FormCostoCapital(costoCapital);
                ChildForm.Open(formCostoCapital, new Point(215, 0), panel2);
                //TODO: Limpiar formulario o redirigir a la pantalla de calculos
                //this.Close();
                //FormCalculos formCalculos = new FormCalculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos de entrada: \n" + ex.Message.ToString());
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
            this.Dispose();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (datos != null)
            {
                txtFechaCreacion.Text = DateTime.Now.ToString("G");
                datos.NombreEscenario = txtNombreEscenario.Text;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DatosService datosService = new DatosService();
                int escenarioID = await datosService.InsertDatos(datos);

                datos.Id = escenarioID;
                variables.IdEscenario = escenarioID;
                escenarios.Escenario_id = escenarioID;
                amortizacion.IdEscenario = escenarioID;

                DatosEscenariosService escenariosService = new DatosEscenariosService();
                int escenID = await escenariosService.InsertEscenario(escenarios);
                if (escenID > 0)
                {
                    escenarios.Id = escenID;
                }
                else
                {
                    MessageBox.Show("Error al insertar los datos del escenario.");
                    return;
                }
                Cursor.Current = Cursors.Default;
                MessageBox.Show("Datos guardados exitosamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar los datos en la base de datos: \n" + ex.Message.ToString());
                return;
            } 

        }
    }
}
