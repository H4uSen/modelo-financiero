using modelo_finanzas.Forms.Analisis;
using modelo_finanzas.Forms.Salidas;
using modelo_finanzas.Logic;
using modelo_finanzas.Models;
using modelo_finanzas.Services;
using modelo_finanzas.Utils;
using Prueba1;
using System.Configuration;
using System.Data.SqlTypes;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace modelo_finanzas
{
    public partial class FormEntradaDatos : Form
    {
        private DatosEntrada datosCargados;

        public FormEntradaDatos(DatosEntrada datosExternos = null)
        {
            InitializeComponent();
            this.AutoScroll = true;
            panel2.BackColor = Color.AliceBlue;

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

        private DatosEntrada entrada = new DatosEntrada();
        private DatosEscenarios escenarios = new DatosEscenarios();
        private Variables variables = new Variables();
        private List<Variables> listaVariables = new List<Variables>();
        private Amortizacion amortizacion = new Amortizacion();
        private List<Amortizacion> listaAmortizaciones = new List<Amortizacion>();
        private EstadoResultados estadoResultados = new EstadoResultados();
        private List<EstadoResultados> listaEstados = new List<EstadoResultados>();
        private CostoCapital costoCapital = new CostoCapital();
        private FlujoCajaLibre flujoCaja = new FlujoCajaLibre();
        private List<FlujoCajaLibre> listaFlujos = new List<FlujoCajaLibre>();
        private FlujoCajaResultado resultadoCajaLibre = new FlujoCajaResultado();

        //Calcular
        private async void button3_Click(object sender, EventArgs e)
        {



            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Rellene los campos marcados.");
                return;
            }

            try
            {
                txtFechaCreacion.Text = DateTime.Now.ToString("G");

                entrada.NombreEscenario = (txtNombreEscenario.Text.Length == 0) ?
                $"Escenario: {DateTime.Now.ToString("G")}"
                : txtNombreEscenario.Text;
                entrada.FechaCreacion = DateTime.Parse(txtFechaCreacion.Text);
                //Mercado y demanda
                entrada.TamanioMercado = int.Parse(txtTamanioMercado.Text.Replace(",", ""));
                entrada.CrecimientoMercado = decimal.Parse(txtCrecimientoAnualMerc.Text.Replace("%", "")) / 100;
                entrada.Encuestas = int.Parse(txtEncRealizadas.Text.Replace(",", ""));
                entrada.ObjetivoMercado = decimal.Parse(txtObjeMer.Text.Replace("%", "")) / 100;
                entrada.PersonasInteresadas = int.Parse(txtManiComp.Text.Replace(",", ""));
                //Costos
                entrada.CostoProduccionInicial = decimal.Parse(txtCostProdIni.Text);
                entrada.CapitalTrabajo = decimal.Parse(txtCapTrab.Text.Replace("%", "")) / 100;
                entrada.GastosOperativos = decimal.Parse(txtGastOper.Text.Replace("%", "")) / 100;
                //Precios e inflacion
                entrada.PrecioInicial = decimal.Parse(txtPrecioProducto.Text);
                entrada.IncrementoPrecio = decimal.Parse(txtIncRealPrec.Text.Replace("%", "")) / 100;
                entrada.Ipp = decimal.Parse(txtIPP.Text.Replace("%", "")) / 100;
                entrada.Inflacion = decimal.Parse(txtInflaAnual.Text.Replace("%", "")) / 100;
                //Inversion, financiamiento y otros
                entrada.InversionEquipos = decimal.Parse(txtInvEquiXPart.Text);
                entrada.OtrosIngresos = decimal.Parse(txtRecupSobreCosto.Text.Replace("%", "")) / 100;
                entrada.TasaLibreRiesgo = decimal.Parse(txtTasaLibRiesgo.Text.Replace("%", "")) / 100;
                entrada.PrimaRiesgoMercado = decimal.Parse(txtPrimRiesgMerc.Text.Replace("%", "")) / 100;
                entrada.GradienteFlujos = decimal.Parse(txtGradFlujos.Text.Replace("%", "")) / 100;
                entrada.DepreciacionAnios = int.Parse(txtPlazoDep.Text.Replace(" años", ""));
                entrada.PorcentajeDeuda = decimal.Parse(txtFinanCredito.Text.Replace("%", "")) / 100;
                entrada.PlazoCredito = int.Parse(txtPlazoCredito.Text.Replace(" años", ""));
                entrada.BetaSector = decimal.Parse(txtBetaSector.Text.Replace("%", ""));
                entrada.TasaImpuestos = decimal.Parse(txtTasaImpositiva.Text.Replace("%", "")) / 100;


                escenarios.CalcularDatosEscenarios(escenarios, entrada);
                listaVariables = variables.CalcularVariables(entrada, escenarios);
                listaAmortizaciones = amortizacion.Calcular(entrada);
                listaEstados = estadoResultados.Calcular(entrada, listaVariables, escenarios, listaAmortizaciones);
                listaFlujos = flujoCaja.Calcular(entrada, escenarios, listaEstados);
                costoCapital.CalcularCostoCapital(escenarios, entrada);
                resultadoCajaLibre.Calcular(listaFlujos, escenarios, costoCapital, entrada);

                panel2.Controls.Clear();
                FormDatosEscenario formDatosEscenario = new FormDatosEscenario(escenarios);
                ChildForm.Open(formDatosEscenario, new Point(0, 0), panel2);

                FormVariables formVariables = new FormVariables(entrada, escenarios);
                ChildForm.Open(formVariables, new Point(190, 0), panel2);

                FormaAmortizacion formaAmortizacion = new FormaAmortizacion(listaAmortizaciones);
                ChildForm.Open(formaAmortizacion, new Point(800, 0), panel2);

                FormEstadoResultado formestadoresultado = new FormEstadoResultado(listaEstados);
                ChildForm.Open(formestadoresultado, new Point(190, 300), panel2);

                FormFlujoCajaResultados formFlujoCajaResultados = new FormFlujoCajaResultados(resultadoCajaLibre);
                ChildForm.Open(formFlujoCajaResultados, new Point(0, 0), pnlFlujoResultados);


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

            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Rellene los campos marcados.");
                return;
            }

            btnCalcular.PerformClick();


            if (entrada != null)
            {
                txtFechaCreacion.Text = DateTime.Now.ToString("G");
                entrada.NombreEscenario = (txtNombreEscenario.Text == "") ? $"Escenario: {txtFechaCreacion.Text}" : txtNombreEscenario.Text;
            }

            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DatosService datosService = new DatosService();
                int escenarioID = await datosService.InsertDatos(entrada);

                entrada.Id = escenarioID;
                escenarios.Escenario_id = escenarioID;
                variables.IdEscenario = escenarioID;
                listaVariables.ForEach(v => v.IdEscenario = escenarioID);
                amortizacion.IdEscenario = escenarioID;
                listaAmortizaciones.ForEach(v => v.IdEscenario = escenarioID);
                estadoResultados.IdEscenario = escenarioID;
                listaEstados.ForEach(v => v.IdEscenario = escenarioID);


                costoCapital.IdEscenario = escenarioID;
                flujoCaja.IdEscenario = escenarioID;
                listaFlujos.ForEach(v => v.IdEscenario = escenarioID);
                resultadoCajaLibre.IdEscenario = escenarioID;

                //Guardar datos en la DB
                DatosEscenariosService escenariosService = new DatosEscenariosService();
                int escenID = await escenariosService.insertEscenario(escenarios);
                VariablesService variablesService = new VariablesService();
                listaVariables.ForEach(async a => await variablesService.insertVariables(a));
                AmortizacionService amortizacionService = new AmortizacionService();
                listaAmortizaciones.ForEach(async a => await amortizacionService.insertAmortizacion(a));
                EstadoResultadosService estadoResultadosService = new EstadoResultadosService();
                listaEstados.ForEach(async a => await estadoResultadosService.InsertEstadoResultados(a));

                CostoCapitalService costoCapitalService = new CostoCapitalService();
                await costoCapitalService.InsertCostoCapital(costoCapital);
                FlujoCajaService flujoCajaService = new FlujoCajaService();
                listaFlujos.ForEach(async a => await flujoCajaService.InsertFlujoCajaLibre(a));
                await flujoCajaService.InsertResultado(resultadoCajaLibre);

                SensiPorcenService porcenService = new SensiPorcenService();
                fillEscenario();
                porcenService.CalcularGuardar((double)entrada.Inflacion, (double)entrada.ObjetivoMercado, (double)resultadoCajaLibre.ValorPresenteNeto, escenarioID);

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

                /*//aquí voy a comenzar a guardar las variables de todas las entradas para usarlas 
                //en la variación del VPN
                // 1. Aquí Creamos una nueva instancia de la hoja (el sobre vacío)
                EscenarioFinanciero nuevoEscenario = new EscenarioFinanciero();
                nuevoEscenario.tamanoActualMercado = double.Parse(txtTamanioMercado.Text);
                nuevoEscenario.crecimientoMercado = double.Parse(txtCrecimientoAnualMerc.Text.Replace("%", "")) / 100;
                nuevoEscenario.encuestasRealizadas = int.Parse(txtEncRealizadas.Text);
                nuevoEscenario.manifestaronComprar = int.Parse(txtManiComp.Text);
                nuevoEscenario.objetivoMercado = double.Parse(txtObjeMer.Text.Replace("%", "")) / 100;
                nuevoEscenario.precioVentaInicial = double.Parse(txtPrecioProducto.Text);
                nuevoEscenario.costoProduccionUnitario = double.Parse(txtCostProdIni.Text);
                nuevoEscenario.inflacionAnualIPC = double.Parse(txtInflaAnual.Text.Replace("%", "")) / 100;
                nuevoEscenario.incrementoRealPrecio = double.Parse(txtIncRealPrec.Text.Replace("%", "")) / 100;
                nuevoEscenario.ippRealCostos = double.Parse(txtIPP.Text.Replace("%", "")) / 100;
                nuevoEscenario.tasaImpositiva = double.Parse(txtTasaImpositiva.Text.Replace("%", "")) / 100;
                nuevoEscenario.inversionEquiposPorPunto = double.Parse(txtInvEquiXPart.Text);
                nuevoEscenario.plazoDepreciacion = int.Parse(txtPlazoDep.Text.Replace(" años", ""));
                nuevoEscenario.porcentajeFinanciado = double.Parse(txtFinanCredito.Text.Replace("%", "")) / 100;
                nuevoEscenario.plazoCredito = int.Parse(txtPlazoCredito.Text.Replace(" años", ""));
                nuevoEscenario.gastosOperativosPorc = double.Parse(txtGastOper.Text.Replace("%", "")) / 100;
                nuevoEscenario.otrosIngresosPorc = double.Parse(txtRecupSobreCosto.Text.Replace("%", "")) / 100;
                nuevoEscenario.capitalTrabajoPorc = double.Parse(txtCapTrab.Text.Replace("%", "")) / 100;
                nuevoEscenario.tasaLibreRiesgo = double.Parse(txtTasaLibRiesgo.Text.Replace("%", "")) / 100;
                nuevoEscenario.bUdelSector = double.Parse(txtBetaSector.Text.Replace("%", ""));
                nuevoEscenario.primaRiesgoMercado = double.Parse(txtPrimRiesgMerc.Text.Replace("%", "")) / 100;
                nuevoEscenario.gradienteFlujos = double.Parse(txtGradFlujos.Text.Replace("%", "")) / 100;
                // 3. Y aquí Guardamos este objeto en la variable estática
                EscenarioFinanciero.EscenarioActual = nuevoEscenario;*/

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al guardar los datos en la base de datos: \n" + ex.Message.ToString());
                return;
            }

        }

        private void txtNombreEscenario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalidas_Click(object sender, EventArgs e)
        {
            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Primero rellene los campos marcados.");
                return;
            }
            FormSalidas formSalidas = new FormSalidas(
                costoCapital,
                listaFlujos,
                resultadoCajaLibre);
            formSalidas.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Primero rellene los campos marcados.");
                return;
            }
            FormSensibilidadFactibleVPN formSensibilidad = new FormSensibilidadFactibleVPN(entrada, escenarios, variables, amortizacion);
            formSensibilidad.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Primero rellene los campos marcados.");
                return;
            }

            //aquí voy a comenzar a guardar las variables de todas las entradas para usarlas 
            //en la variación del VPN
            // 1. Aquí Creamos una nueva instancia de la hoja (el sobre vacío)
            EscenarioFinanciero nuevoEscenario = new EscenarioFinanciero();
            nuevoEscenario.tamanoActualMercado = double.Parse(txtTamanioMercado.Text);
            nuevoEscenario.crecimientoMercado = double.Parse(txtCrecimientoAnualMerc.Text.Replace("%", "")) / 100;
            nuevoEscenario.encuestasRealizadas = int.Parse(txtEncRealizadas.Text);
            nuevoEscenario.manifestaronComprar = int.Parse(txtManiComp.Text);
            nuevoEscenario.objetivoMercado = double.Parse(txtObjeMer.Text.Replace("%", "")) / 100;
            nuevoEscenario.precioVentaInicial = double.Parse(txtPrecioProducto.Text);
            nuevoEscenario.costoProduccionUnitario = double.Parse(txtCostProdIni.Text);
            nuevoEscenario.inflacionAnualIPC = double.Parse(txtInflaAnual.Text.Replace("%", "")) / 100;
            nuevoEscenario.incrementoRealPrecio = double.Parse(txtIncRealPrec.Text.Replace("%", "")) / 100;
            nuevoEscenario.ippRealCostos = double.Parse(txtIPP.Text.Replace("%", "")) / 100;
            nuevoEscenario.tasaImpositiva = double.Parse(txtTasaImpositiva.Text.Replace("%", "")) / 100;
            nuevoEscenario.inversionEquiposPorPunto = double.Parse(txtInvEquiXPart.Text);
            nuevoEscenario.plazoDepreciacion = int.Parse(txtPlazoDep.Text.Replace(" años", ""));
            nuevoEscenario.porcentajeFinanciado = double.Parse(txtFinanCredito.Text.Replace("%", "")) / 100;
            nuevoEscenario.plazoCredito = int.Parse(txtPlazoCredito.Text.Replace(" años", ""));
            nuevoEscenario.gastosOperativosPorc = double.Parse(txtGastOper.Text.Replace("%", "")) / 100;
            nuevoEscenario.otrosIngresosPorc = double.Parse(txtRecupSobreCosto.Text.Replace("%", "")) / 100;
            nuevoEscenario.capitalTrabajoPorc = double.Parse(txtCapTrab.Text.Replace("%", "")) / 100;
            nuevoEscenario.tasaLibreRiesgo = double.Parse(txtTasaLibRiesgo.Text.Replace("%", "")) / 100;
            nuevoEscenario.bUdelSector = double.Parse(txtBetaSector.Text.Replace("%", ""));
            nuevoEscenario.primaRiesgoMercado = double.Parse(txtPrimRiesgMerc.Text.Replace("%", "")) / 100;
            nuevoEscenario.gradienteFlujos = double.Parse(txtGradFlujos.Text.Replace("%", "")) / 100;
            // 3. Y aquí Guardamos este objeto en la variable estática
            EscenarioFinanciero.EscenarioActual = nuevoEscenario;


            FormVariacionPorcentalVPN formVariacion = new FormVariacionPorcentalVPN();
            formVariacion.Show();
        }

        private void btnSensFactibleVPN_Click(object sender, EventArgs e)
        {
            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Primero rellene los campos marcados.");
                return;
            }
        }

        private void fillEscenario()
        {
            // 1. Aquí Creamos una nueva instancia de la hoja (el sobre vacío)
            EscenarioFinanciero nuevoEscenario = new EscenarioFinanciero();
            nuevoEscenario.tamanoActualMercado = double.Parse(txtTamanioMercado.Text);
            nuevoEscenario.crecimientoMercado = double.Parse(txtCrecimientoAnualMerc.Text.Replace("%", "")) / 100;
            nuevoEscenario.encuestasRealizadas = int.Parse(txtEncRealizadas.Text);
            nuevoEscenario.manifestaronComprar = int.Parse(txtManiComp.Text);
            nuevoEscenario.objetivoMercado = double.Parse(txtObjeMer.Text.Replace("%", "")) / 100;
            nuevoEscenario.precioVentaInicial = double.Parse(txtPrecioProducto.Text);
            nuevoEscenario.costoProduccionUnitario = double.Parse(txtCostProdIni.Text);
            nuevoEscenario.inflacionAnualIPC = double.Parse(txtInflaAnual.Text.Replace("%", "")) / 100;
            nuevoEscenario.incrementoRealPrecio = double.Parse(txtIncRealPrec.Text.Replace("%", "")) / 100;
            nuevoEscenario.ippRealCostos = double.Parse(txtIPP.Text.Replace("%", "")) / 100;
            nuevoEscenario.tasaImpositiva = double.Parse(txtTasaImpositiva.Text.Replace("%", "")) / 100;
            nuevoEscenario.inversionEquiposPorPunto = double.Parse(txtInvEquiXPart.Text);
            nuevoEscenario.plazoDepreciacion = int.Parse(txtPlazoDep.Text.Replace(" años", ""));
            nuevoEscenario.porcentajeFinanciado = double.Parse(txtFinanCredito.Text.Replace("%", "")) / 100;
            nuevoEscenario.plazoCredito = int.Parse(txtPlazoCredito.Text.Replace(" años", ""));
            nuevoEscenario.gastosOperativosPorc = double.Parse(txtGastOper.Text.Replace("%", "")) / 100;
            nuevoEscenario.otrosIngresosPorc = double.Parse(txtRecupSobreCosto.Text.Replace("%", "")) / 100;
            nuevoEscenario.capitalTrabajoPorc = double.Parse(txtCapTrab.Text.Replace("%", "")) / 100;
            nuevoEscenario.tasaLibreRiesgo = double.Parse(txtTasaLibRiesgo.Text.Replace("%", "")) / 100;
            nuevoEscenario.bUdelSector = double.Parse(txtBetaSector.Text.Replace("%", ""));
            nuevoEscenario.primaRiesgoMercado = double.Parse(txtPrimRiesgMerc.Text.Replace("%", "")) / 100;
            nuevoEscenario.gradienteFlujos = double.Parse(txtGradFlujos.Text.Replace("%", "")) / 100;
            // 3. Y aquí Guardamos este objeto en la variable estática
            EscenarioFinanciero.EscenarioActual = nuevoEscenario;
        }

        //Botón sensibilidad puntual VPN
        private void button2_Click(object sender, EventArgs e)
        {
            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Primero rellene los campos marcados.");
                return;
            }

            btnCalcular.PerformClick();

            FormSensiPuntual formSensiPuntual = new FormSensiPuntual(entrada, escenarios, costoCapital, 4);
            formSensiPuntual.Show();
        }

        
            private void btnPdfGeneral_Click(object sender, EventArgs e)
            {
                if (!FormValidator.ValidateRequired(this, errorProvider1))
                {
                    MessageBox.Show("Primero rellene los campos marcados.");
                    return;
                }

                btnCalcular.PerformClick();
                fillEscenario();

                SaveFileDialog sfd = new SaveFileDialog
                {
                    Filter = "PDF (*.pdf)|*.pdf",
                    FileName = $"Reporte_Modelo_Financiero_{DateTime.Now:yyyyMMdd_HHmmss}.pdf"
                };

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;

                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            iTextSharp.text.Document pdfDoc = new iTextSharp.text.Document(PageSize.A4.Rotate(), 20f, 20f, 20f, 20f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();

                            // Lista de formularios que queremos exportar
                            List<Form> formsToPrint = new List<Form>
                            {
                                this, // Primero esta misma pantalla (FormEntradaDatos)
                                new FormSalidas(costoCapital, listaFlujos, resultadoCajaLibre),
                                new FormSensibilidadFactibleVPN(entrada, escenarios, variables, amortizacion),
                                new FormVariacionPorcentalVPN(),
                                new FormSensiPuntual(entrada, escenarios, costoCapital, 4)
                            };

                            foreach (Form fr in formsToPrint)
                            {
                                bool isSelf = (fr == this);

                                if (!isSelf)
                                {
                                    // Configurar para que no sea visible durante la renderización y forzar layout
                                    fr.StartPosition = FormStartPosition.Manual;
                                    fr.Location = new Point(-20000, -20000);
                                    fr.ShowInTaskbar = false;
                                    fr.FormBorderStyle = FormBorderStyle.None; // Quita el borde de la ventana
                                    fr.Show();
                                    fr.Refresh();
                                    Application.DoEvents();

                                    // Un pequeño retraso para permitir que los controles (como DataGridView) terminen de dibujarse
                                    System.Threading.Thread.Sleep(200);
                                    Application.DoEvents();
                                }

                                int width = fr.Width;
                                int height = fr.Height;

                                // Expandir para capturar todo el área de scroll si existe
                                if (fr.AutoScrollMinSize.Width > width) width = fr.AutoScrollMinSize.Width;
                                if (fr.AutoScrollMinSize.Height > height) height = fr.AutoScrollMinSize.Height;
                                // Para si isSelf, intentar capturar todo el DisplayRectangle
                                if (isSelf && this.DisplayRectangle.Height > height) height = this.DisplayRectangle.Height;

                                // Prevenir anchos/altos cero
                                if (width <= 0) width = 800;
                                if (height <= 0) height = 600;

                                using (Bitmap bmp = new Bitmap(width, height))
                                {
                                    // Guardar el estado de auto-scroll
                                    Point savedScroll = fr.AutoScrollPosition;
                                    fr.AutoScrollPosition = new Point(0, 0);

                                    fr.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, width, height));

                                    // Restaurar scroll
                                    if (savedScroll.X < 0 || savedScroll.Y < 0)
                                        fr.AutoScrollPosition = new Point(Math.Abs(savedScroll.X), Math.Abs(savedScroll.Y));

                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        bmp.Save(ms, ImageFormat.Png);
                                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ms.ToArray());

                                        // Agregar nueva página antes del texto (si no es el primero)
                                        if (fr != formsToPrint[0])
                                        {
                                            pdfDoc.NewPage();
                                        }

                                        Paragraph p = new Paragraph(fr.Text ?? "Reporte", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14));
                                        p.Alignment = Element.ALIGN_CENTER;
                                        p.SpacingAfter = 10f;
                                        pdfDoc.Add(p);

                                        // Ajustar la imagen al tamaño de la carta dejando espacio para el titulo
                                        img.ScaleToFit(pdfDoc.PageSize.Width - 40f, pdfDoc.PageSize.Height - 60f);
                                        img.Alignment = Element.ALIGN_CENTER;
                                        pdfDoc.Add(img);
                                    }
                                }

                                if (!isSelf)
                                {
                                    fr.Close();
                                }
                            }

                            pdfDoc.Close();
                        }

                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Reporte completo en PDF generado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        Cursor.Current = Cursors.Default;
                        MessageBox.Show("Error al generar PDF: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
