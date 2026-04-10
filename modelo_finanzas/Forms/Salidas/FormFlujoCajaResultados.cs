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

namespace modelo_finanzas.Forms.Salidas
{
    public partial class FormFlujoCajaResultados : Form
    {
        private readonly FlujoCajaResultado _resultadoCaja;
        public FormFlujoCajaResultados(FlujoCajaResultado resultadoCaja)
        {
            InitializeComponent();
            _resultadoCaja = resultadoCaja;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
            }
            this.Load += FormFlujoCajaResultados_Load;
        }

        private void FormFlujoCajaResultados_Load(object? sender, EventArgs e)
        {
            txtVT.Text = _resultadoCaja.ValorTerminal.ToString("N0");
            txtVPF.Text = _resultadoCaja.ValorPresenteFlujos.ToString("N0");
            txtVPVT.Text = _resultadoCaja.ValorPresenteVT.ToString("N0");
            txtVMN.Text = _resultadoCaja.ValorMercadoNegocio.ToString("N0");
            txtIIAF.Text = _resultadoCaja.InversionInicialActivos.ToString("N0");
            txtVPN.Text = _resultadoCaja.ValorPresenteNeto.ToString("N0");
        }
    }
}
