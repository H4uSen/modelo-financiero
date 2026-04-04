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
    public partial class EstadoResultado : Form
    {
        public EstadoResultado()
        {
            InitializeComponent();
        }

        private void EstadoResultados_Load(object sender, EventArgs e)
        {
            // Bloquear edición
            dgvEstadoResultado.ReadOnly = true;
            dgvEstadoResultado.AllowUserToAddRows = false;
            //dgvEstadoResultado.AllowUserToAddColumns = false;
            dgvEstadoResultado.AllowUserToDeleteRows = false;
            // Agregar filas de texto en la primera columna
            dgvEstadoResultado.Rows.Add("Ventas");
            dgvEstadoResultado.Rows.Add("Costo de ventas");
            dgvEstadoResultado.Rows.Add("UTILIDAD BRUTA");
            dgvEstadoResultado.Rows.Add("Gastos operativos");
            dgvEstadoResultado.Rows.Add("Depreciación");
            dgvEstadoResultado.Rows.Add("TOTAL GASTOS");
            dgvEstadoResultado.Rows.Add("UTILIDAD OPERACIONAL");
            dgvEstadoResultado.Rows.Add("Gasto financiero");
            dgvEstadoResultado.Rows.Add("Otros ingresos - recuperaciones");
            dgvEstadoResultado.Rows.Add("NETO OTROS INGRESOS Y EGRESOS");
            dgvEstadoResultado.Rows.Add("UTILIDAD ANTES DE IMPUESTOS");
            dgvEstadoResultado.Rows.Add("Impuestos");
            dgvEstadoResultado.Rows.Add("UTILIDAD NETA");
            dgvEstadoResultado.Rows.Add("Capital de trabajo");

            // Ejemplo: poner en negrita la fila de Utilidad Bruta
            dgvEstadoResultado.Rows[2].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvEstadoResultado.Rows[5].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvEstadoResultado.Rows[6].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvEstadoResultado.Rows[9].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvEstadoResultado.Rows[10].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dgvEstadoResultado.Rows[12].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);


            // Ejemplo: poner en verde la fila de Utilidad Neta
            //dgvEstadoResultado.Rows[12].DefaultCellStyle.BackColor = Color.LightGreen;
            // 🔹 Aplicar color verde SOLO a las filas clave
            dgvEstadoResultado.Rows[2].DefaultCellStyle.ForeColor = Color.Green;  // UTILIDAD BRUTA
            //dgvEstadoResultado.Rows[5].DefaultCellStyle.ForeColor = Color.Green;  // TOTAL GASTOS
            dgvEstadoResultado.Rows[6].DefaultCellStyle.ForeColor = Color.Green;  // UTILIDAD OPERACIONAL
            //dgvEstadoResultado.Rows[9].DefaultCellStyle.ForeColor = Color.Green;  // NETO OTROS INGRESOS Y EGRESOS
            dgvEstadoResultado.Rows[10].DefaultCellStyle.ForeColor = Color.Green; // UTILIDAD ANTES DE IMPUESTOS
            dgvEstadoResultado.Rows[12].DefaultCellStyle.ForeColor = Color.Green; // UTILIDAD NETA

        }
    }
}
