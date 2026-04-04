using System.Configuration;
using System.Data.SqlTypes;
using modelo_finanzas.Models;
using modelo_finanzas.Utils;
using modelo_finanzas.Logic;
using Prueba1;
namespace modelo_finanzas
{
    public partial class FormEntradaDatos : Form
    {
        public FormEntradaDatos()
        {
            InitializeComponent();

            txtNombreEscenario.MaxLength = 50;
            txtNombreEscenario.Tag = "optional";

            txtFechaCreacion.MaxLength = 50;
            txtFechaCreacion.Enabled = false;
            txtFechaCreacion.Tag = "optional";
            txtFechaCreacion.Text = DateTime.Now.ToString("G");

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

        private async void button3_Click(object sender, EventArgs e)
        {
            if (!FormValidator.ValidateRequired(this, errorProvider1))
            {
                MessageBox.Show("Rellene los campos marcados.");
                return;
            }

            try
            {
                DatosEntrada datos = new DatosEntrada();
                DatosService controller = new DatosService();
                datos.NombreEscenario = (txtNombreEscenario.Text.Length == 0) ?
                    $"Escenario: {DateTime.Now.ToString("G")}"
                    : txtNombreEscenario.Text;
                datos.FechaCreacion = DateTime.Parse(txtFechaCreacion.Text);
                //Mercado y demanda
                datos.TamanioMercado = SqlInt32.Parse(txtTamanioMercado.Text.Replace(",", ""));
                datos.CrecimientoMercado = SqlDecimal.Parse(txtCrecimientoAnualMerc.Text.Replace("%", ""));
                datos.Encuestas = SqlInt32.Parse(txtEncRealizadas.Text.Replace(",", ""));
                datos.ObjetivoMercado = SqlDecimal.Parse(txtObjeMer.Text.Replace("%", ""));
                datos.PersonasInteresadas = SqlInt32.Parse(txtManiComp.Text.Replace(",", ""));
                //Costos
                datos.CostoProduccionInicial = SqlMoney.Parse(txtCostProdIni.Text);
                datos.CapitalTrabajo = SqlDecimal.Parse(txtCapTrab.Text.Replace("%", ""));
                datos.GastosOperativos = SqlDecimal.Parse(txtGastOper.Text.Replace("%", ""));
                //Precios e inflacion
                datos.PrecioInicial = SqlMoney.Parse(txtPrecioProducto.Text);
                datos.IncrementoPrecio = SqlDecimal.Parse(txtIncRealPrec.Text.Replace("%", ""));
                datos.Ipp = SqlDecimal.Parse(txtIPP.Text.Replace("%", ""));
                datos.Inflacion = SqlDecimal.Parse(txtInflaAnual.Text.Replace("%", ""));
                //Inversion, financiamiento y otros
                datos.InversionEquipos = SqlMoney.Parse(txtInvEquiXPart.Text);
                datos.OtrosIngresos = SqlDecimal.Parse(txtRecupSobreCosto.Text.Replace("%", ""));
                datos.TasaLibreRiesgo = SqlDecimal.Parse(txtTasaLibRiesgo.Text.Replace("%", ""));
                datos.PrimaRiesgoMercado = SqlDecimal.Parse(txtPrimRiesgMerc.Text.Replace("%", ""));
                datos.GradienteFlujos = SqlDecimal.Parse(txtGradFlujos.Text.Replace("%", ""));
                datos.DepreciacionAnios = SqlInt16.Parse(txtPlazoDep.Text.Replace(" años", ""));
                datos.PorcentajeDeuda = SqlDecimal.Parse(txtFinanCredito.Text.Replace("%", ""));
                datos.PlazoCredito = SqlInt16.Parse(txtPlazoCredito.Text.Replace(" años", ""));
                datos.BetaSector = SqlDecimal.Parse(txtBetaSector.Text.Replace("%", ""));
                datos.TasaImpuestos = SqlDecimal.Parse(txtTasaImpositiva.Text.Replace("%", ""));

                int escenarioID = await controller.InsertDatos(datos);
                datos.Id = escenarioID;

                DatosEscenarios escenarios = new DatosEscenarios();
                Variables variables = new Variables();
                Amortizacion amortizacion = new Amortizacion();
                EstadoResultado estadoResultados = new EstadoResultado();

                variables.IdEscenario = escenarioID;
                variables.CalcularVariables(variables, datos, escenarios);

                amortizacion.IdEscenario = escenarioID;
                amortizacion.CalcularAmortizacion(amortizacion, datos, variables, escenarios);

               // estadoResultados.IdEscenario = escenarioID;
               // estadoResultados.CalcularEstadoResultados(estadoResultados, variables, datos, escenarios, amortizacion);

                if (escenarioID > 0)
                {
                    MessageBox.Show("Datos insertados correctamente.");
                    //TODO: Limpiar formulario o redirigir a la pantalla de calculos
                    //this.Close();
                    //FormCalculos formCalculos = new FormCalculos();
                }
                else
                {
                    MessageBox.Show("Error al insertar los datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos de entrada: \n" + ex.Message.ToString());
            }
        }

        private Form activeForm = null  ;

        private void OpenChildForm(Form childForm)
        {
            // Close previous form if exists
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            // Important settings
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Add to panel
            panel2.Controls.Clear();
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var form = new MenuPrincipal();
            OpenChildForm(form);
        }
    }
}
