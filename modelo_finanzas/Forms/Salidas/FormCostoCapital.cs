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
    public partial class FormCostoCapital : Form
    {
        public FormCostoCapital(CostoCapital costoCapital)
        {
            InitializeComponent();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Enabled = false;
                }
            }

            txtPorcDeuda.Text = costoCapital.PorcentajeDeuda.ToString("P2");
            txtPorcAportes.Text = costoCapital.PorcentajeAportes.ToString("P2");
            txtCostoDeuda.Text = costoCapital.CostoDeuda.ToString("P2");
            txtCostDeuDespImp.Text = costoCapital.CostoDeudaDespuesImpuestos.ToString("P2");
            txtBetaLSector.Text = costoCapital.BetaLSector.ToString("N3");
            txtCostoPatrimonio.Text = costoCapital.CostoPatrimonio.ToString("P2");
            txtCostoCapital.Text = costoCapital.CostoCapitalTotal.ToString("P2");
        }
    }
}
