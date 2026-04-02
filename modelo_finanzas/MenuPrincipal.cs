using modelo_finanzas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Menú Principal";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            FormEntradaDatos vistaEntradaDatos = new FormEntradaDatos();
            vistaEntradaDatos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaProcesosFinancieros vistaProceFinancieros = new VistaProcesosFinancieros();
            vistaProceFinancieros.Show();
            this.Hide();
        }

        private void btnEscenariosGuardados_Click(object sender, EventArgs e)
        {
            VistaResultadosFinales vistaResltadosFinales = new VistaResultadosFinales();
            vistaResltadosFinales.Show();
            this.Hide();
        }

        private void btnCompararEscenarios_Click(object sender, EventArgs e)
        {
            EscenariosGuardados vistaEscenariosGuardados = new EscenariosGuardados();
            vistaEscenariosGuardados.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
