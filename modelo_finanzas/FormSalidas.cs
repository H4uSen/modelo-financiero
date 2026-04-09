using modelo_finanzas.Forms.Salidas;
using modelo_finanzas.Models;
using modelo_finanzas.Utils;
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
    public partial class FormSalidas : Form
    {
        private readonly CostoCapital _costoCapital;
        private readonly List<FlujoCajaLibre> _flujos;

        public FormSalidas(CostoCapital costoCapital, List<FlujoCajaLibre> flujos)
        {
            InitializeComponent();
            _costoCapital = costoCapital;
            this.Load += FormSalidas_Load;
            _flujos = flujos;
        }

        private void FormSalidas_Load(object? sender, EventArgs e)
        {
            FormCostoCapital formCostoCapital = new FormCostoCapital(_costoCapital);
            ChildForm.Open(formCostoCapital, new Point(0, 0), pnlCostoCapital);

            FormFlujoCaja formFlujoCaja = new FormFlujoCaja(_flujos);
            ChildForm.Open(formFlujoCaja, new Point(0, 0), pnlFlujoCaja);

        }
    }
}
