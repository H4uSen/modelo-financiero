using System;
using System.Collections.Generic;
using System.Windows.Forms;
using modelo_finanzas.Services;
using modelo_finanzas.Models;

namespace Prueba1
{
    public partial class FormaAmortizacion : Form
    {

        private AmortizacionService _amortizacionService = new AmortizacionService();
        private VariablesService _varsService = new VariablesService();

        public FormaAmortizacion()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Amortizacion";

            EjecutarCalculoAutomatico();
        }

        private async void EjecutarCalculoAutomatico()
        {
            try
            {
                var datosService = new modelo_finanzas.Logic.DatosService();
                var listaEntradas = await datosService.GetAllDatos();
                var ultimaEntrada = listaEntradas.FirstOrDefault();

                if (ultimaEntrada != null)
                {

                    decimal objetivo = (decimal)ultimaEntrada.ObjetivoMercado;
                    if (objetivo < 1) objetivo = objetivo * 100m;


                    decimal inversionEquipos = (decimal)ultimaEntrada.InversionEquipos;
                    decimal inversionTotal = inversionEquipos * objetivo;

                    double financiamiento = (double)(inversionTotal * (decimal)ultimaEntrada.PorcentajeDeuda);

                    double costoDeudaRaw = (double)new RangoInteres().ObtenerTasa((decimal)ultimaEntrada.PorcentajeDeuda * 100m);
                    double costoDeudaFinal = (costoDeudaRaw < 1) ? costoDeudaRaw * 100 : costoDeudaRaw;

                    int plazo = ultimaEntrada.PlazoCredito;


                    var resultado = _amortizacionService.CalcularTabla(financiamiento, costoDeudaFinal, plazo);


                    dgvTablaAmortiCredito.DataSource = null;
                    dgvTablaAmortiCredito.DataSource = resultado;

                    var filaAnio1 = resultado.FirstOrDefault(x => x.anio == 1);
                    if (filaAnio1 != null)
                    {
                        lblCuotaFija.Text = filaAnio1.Cuota.ToString("C2");
                    }

                    await _amortizacionService.GuardarTablaAmortizacion(resultado, ultimaEntrada.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            EjecutarCalculoAutomatico();
            MessageBox.Show("Tabla actualizada con el último escenario de la base de datos.");


        }

        private void VistaProcesosFinancieros_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void dgvTablaAmortiCredito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEstadoResultados_Click(object sender, EventArgs e)
        {



        }

        private void lblCuotaFija_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormaAmortizacion_Load(object sender, EventArgs e)
        {

        }
    }
}

