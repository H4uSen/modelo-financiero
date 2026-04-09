using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace modelo_finanzas

{
    public partial class FormSensibilidadFactibleVPN : Form
    {
        public FormSensibilidadFactibleVPN()
        {
            InitializeComponent();
            this.Load += FormSensibilidadFactibleVPN_Load;
        }

        private void FormSensibilidadFactibleVPN_Load(object sender, EventArgs e)
        {
            dgvSensibilidad.Dock = DockStyle.Fill;
            ConfigurarDataGrid();
            CargarDatosIniciales();
            //CalcularResultados();
        }

        private void ConfigurarDataGrid()
        {
            dgvSensibilidad.AllowUserToAddRows = false;
            dgvSensibilidad.RowHeadersVisible = false;
            dgvSensibilidad.EnableHeadersVisualStyles = false;
            dgvSensibilidad.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSensibilidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSensibilidad.Columns.Clear();

            // Columna principal (variables)
            dgvSensibilidad.Columns.Add("Variable", " ");
            dgvSensibilidad.Columns["Variable"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSensibilidad.Columns["Variable"].DefaultCellStyle.Font = new Font(dgvSensibilidad.Font.FontFamily, 9, FontStyle.Bold);
            dgvSensibilidad.Columns["Variable"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Columnas de valores
            dgvSensibilidad.Columns.Add("ValorMinimo", "Valor Mínimo");
            dgvSensibilidad.Columns.Add("ValorActual", "Valor Actual");
            dgvSensibilidad.Columns.Add("ValorMaximo", "Valor Máximo");

            // Columnas de resultados
            dgvSensibilidad.Columns.Add("VariacionNeta", "Variación neta del resultado");
            dgvSensibilidad.Columns.Add("GradoSensibilidad", "Grado de Sensibilidad");

            // Encabezado rosa solo para las columnas de valores
            Color colorRosa = Color.LightPink;
            dgvSensibilidad.Columns["ValorMinimo"].HeaderCell.Style.BackColor = colorRosa;
            dgvSensibilidad.Columns["ValorActual"].HeaderCell.Style.BackColor = colorRosa;
            dgvSensibilidad.Columns["ValorMaximo"].HeaderCell.Style.BackColor = colorRosa;
            dgvSensibilidad.Columns["ValorMinimo"].HeaderCell.Style.ForeColor = Color.Black;
            dgvSensibilidad.Columns["ValorActual"].HeaderCell.Style.ForeColor = Color.Black;
            dgvSensibilidad.Columns["ValorMaximo"].HeaderCell.Style.ForeColor = Color.Black;

        }

        private void CargarDatosIniciales()
        {
            dgvSensibilidad.Rows.Clear();

            // Agregar variables fila por fila
            AgregarVariable("PARTICIPACIÓN EN EL MERCADO", 0.035, 0.04, 0.042, 50000000, 49916443, 50000000, 50033423, true);
            AgregarVariable("CRECIMIENTO DEL MERCADO", 0.018, 0.02, 0.024, 50000000, 48364833, 50000000, 53301789, true);
            AgregarVariable("PRECIO DE VENTA", 7200, 7200, 7250, 50000000, 50000000, 50000000, 54627077, false);
            AgregarVariable("COSTO DE PRODUCCIÓN", 3500, 3500, 3550, 50000000, 50000000, 50000000, 43577855, false);
            AgregarVariable("INFLACIÓN - IPC", 0.03, 0.035, 0.038, 50000000, 47022810, 50000000, 51802909, true);
            AgregarVariable("GASTOS OPERATIVOS", 0.23, 0.25, 0.25, 50000000, 68564988, 50000000, 50000000, true);


        }

        private void AgregarVariable(string nombre, double valMin, double valAct, double valMax,
                                     double absMin, double absAct, double absMax, double absExtra, bool esPorcentaje)
        {
            // Fila de valores 
            var fila = dgvSensibilidad.Rows.Add(nombre, valMin, valAct, valMax, "", "");

            if (esPorcentaje)
            {
                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.Format = "P1";
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.Format = "P1";
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.Format = "P1";

                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.BackColor = Color.LightGreen;
            }
            else
            {
                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.Format = "N0";
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.Format = "N0";
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.Format = "N0";

                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.BackColor = Color.LightGreen;

            }

            // Fila de valores de análisis (verde claro)
            dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["VariacionNeta"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["GradoSensibilidad"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Fila de valores 50,000,000 
            int filaAbsoluta = dgvSensibilidad.Rows.Add(absMin.ToString("N0"), absAct.ToString("N0"), absMax.ToString("N0"), absExtra.ToString("N0"), "", "");
            for (int col = 0; col < dgvSensibilidad.Columns.Count; col++)
            {
                //
                dgvSensibilidad.Rows[filaAbsoluta].Cells[col].Style.Font = new Font(dgvSensibilidad.Font, FontStyle.Regular);
                dgvSensibilidad.Rows[filaAbsoluta].Cells[col].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void CalcularResultados()
        {
            // Iterar solo las filas de valores absolutos (cada 2ª fila)
            for (int i = 1; i < dgvSensibilidad.Rows.Count; i += 2)
            {
                DataGridViewRow fila = dgvSensibilidad.Rows[i];

                double valorMin = double.Parse(fila.Cells["ValorMinimo"].Value.ToString().Replace(",", ""));
                double valorAct = double.Parse(fila.Cells["ValorActual"].Value.ToString().Replace(",", ""));
                double valorMax = double.Parse(fila.Cells["ValorMaximo"].Value.ToString().Replace(",", ""));

                // Variación neta
                double variacionNeta = (valorMax - valorAct) + (valorMin - valorAct);
                fila.Cells["VariacionNeta"].Value = variacionNeta.ToString("N0");

                // Grado de Sensibilidad
                double gradoSensibilidad = valorAct != 0 ? variacionNeta / valorAct : 0;
                fila.Cells["GradoSensibilidad"].Value = gradoSensibilidad.ToString("P1");

                // Color según signo
                fila.Cells["GradoSensibilidad"].Style.ForeColor = gradoSensibilidad < 0 ? Color.Red : Color.Green;
            }
        }

        private void t_Click(object sender, EventArgs e)
        {
            CalcularResultados();
        }
    }
}