using modelo_finanzas;
using modelo_finanzas.Models;
using modelo_finanzas.Utils;
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

            panel1.Width = 700;
            FormCargarEscenario formCargar = new FormCargarEscenario();
            ChildForm.Open(formCargar, new Point(0, 0), panel1);
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
            FormCargarEscenario cargarEscenario = new FormCargarEscenario();
            cargarEscenario.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnVariables_Click(object sender, EventArgs e)
        {
            DatosEntrada de = new DatosEntrada();
            DatosEscenarios ds = new DatosEscenarios();

            FormVariables frm = new FormVariables(de, ds);
            frm.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormVariacionPorcentalVPN variacionPorcentalVPN = new FormVariacionPorcentalVPN();
            variacionPorcentalVPN.Show();
        }

        private async void button1_Click_1(object sender, EventArgs e)
        {
            var con = DbConnection.Instance;
            if (await con.TestConnectionAsync())
            {
                MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo conectar a la base de datos. Verifique la configuración.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
