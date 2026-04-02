using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class VistaProcesosFinancieros : Form
    {
        public VistaProcesosFinancieros()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Proyecciones y Cálculos";
        }

        private void VistaProcesosFinancieros_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
