using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prueba1
{
    public partial class EscenariosGuardados : Form
    {
        public EscenariosGuardados()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Escenarios Guardados";
        }

        private void EscenariosGuardados_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
