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

namespace modelo_finanzas
{
    public partial class FormDatosEscenario : Form
    {
        public FormDatosEscenario(DatosEscenarios escenario)
        {
            InitializeComponent();
            
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
            }

            txtMercEsperado.Text = escenario.Mercado_esperado_anio1.ToString("P2");
            txtVarNomPrecio.Text = escenario.Variacion_nominal_precio.ToString("P2");
            txtVarNomIPP.Text = escenario.Variacion_nominal_ipp.ToString("P2");
            txtValInvInicial.Text = escenario.Valor_inversion_inicial.ToString("C2");
            txtCostoDeuda.Text = (escenario.Costo_deuda).ToString("P2");
            txtFinanCredito.Text = escenario.Financiado_con_credito.ToString("C2");
            txtFinanAportes.Text = escenario.Financiado_con_aportes.ToString("C2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
