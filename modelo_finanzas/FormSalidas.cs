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
        private readonly FlujoCajaResultado _cajaResultado;

        public FormSalidas(CostoCapital costoCapital, List<FlujoCajaLibre> flujos, FlujoCajaResultado cajaResultado)
        {
            InitializeComponent();
            _costoCapital = costoCapital;
            _flujos = flujos;
            _cajaResultado = cajaResultado;
            this.Load += FormSalidas_Load;
        }

        private void FormSalidas_Load(object? sender, EventArgs e)
        {
            FormCostoCapital formCostoCapital = new FormCostoCapital(_costoCapital);
            ChildForm.Open(formCostoCapital, new Point(0, 0), pnlCostoCapital);

            FormFlujoCaja formFlujoCaja = new FormFlujoCaja(_flujos);
            ChildForm.Open(formFlujoCaja, new Point(0, 0), pnlFlujoCaja);

            FormFlujoCajaResultados formFlujoCajaResultados = new FormFlujoCajaResultados(_cajaResultado);
            ChildForm.Open(formFlujoCajaResultados, new Point(0, 0), pnlCajaResultados);

        }

        private void FormSalidas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
