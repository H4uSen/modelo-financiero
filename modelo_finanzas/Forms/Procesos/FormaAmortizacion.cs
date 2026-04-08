using System;
using System.Collections.Generic;
using System.Windows.Forms;
using modelo_finanzas.Services;
using modelo_finanzas.Models;
using System.Diagnostics;
using System.Data;

namespace Prueba1
{
    public partial class FormaAmortizacion : Form
    {

        private AmortizacionService _amortizacionService = new AmortizacionService();
        private VariablesService _varsService = new VariablesService();

        public FormaAmortizacion(List<Amortizacion> amortizaciones)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Amortizacion";
            this.Enabled = false;
            dgvTablaAmortiCredito.RowHeadersVisible = false;
            dgvTablaAmortiCredito.DataSource = null;
            dgvTablaAmortiCredito.CellFormatting += dgvTablaAmortiCredito_CellFormatting;

        EjecutarCalculoAutomatico(amortizaciones);
        }

        private void dgvTablaAmortiCredito_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Skip header column
            if (e.ColumnIndex == 0 || e.RowIndex < 0)
                return;

            // Get the concept name from the first column
            var concepto = dgvTablaAmortiCredito.Rows[e.RowIndex].Cells[0].Value?.ToString();

            if (concepto == "Saldo Inicial" || concepto == "Saldo Final" || concepto == "Cuota" || concepto == "Abono a Capital")
            {
                // Format as currency
                if (e.Value is decimal dec)
                    e.Value = dec.ToString("N0");
                e.FormattingApplied = true;
            }
            else if (concepto == "Interés")
            {
                // Format as currency, but you could use a different style if needed
                if (e.Value is decimal dec)
                    e.Value = dec.ToString("N0");
                e.FormattingApplied = true;
            }
        }


        private void EjecutarCalculoAutomatico(List<Amortizacion> amortizaciones)
        {
            try
            {

                if (amortizaciones != null)
                {


                    List<Amortizacion> resultado = amortizaciones;
                    dgvTablaAmortiCredito.DataSource = PivotAmortizacion(resultado);
                    dgvTablaAmortiCredito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvTablaAmortiCredito.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                    dgvTablaAmortiCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                    dgvTablaAmortiCredito.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dgvTablaAmortiCredito.Refresh();


                    var filaAnio1 = resultado.FirstOrDefault(x => x.Anio == 1);
                    if (filaAnio1 != null)
                    {
                        lblCuotaFija.Text = filaAnio1.Cuota.ToString("C2");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tabla actualizada con el último escenario de la base de datos.");


        }

        private void VistaProcesosFinancieros_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void dgvTablaAmortiCredito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEstadoResultados_Click(object sender, EventArgs e)
        {



        }

        private void lblCuotaFija_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormaAmortizacion_Load(object sender, EventArgs e)
        {

        }
        private DataTable PivotAmortizacion(List<Amortizacion> amortizaciones)
        {
            var dt = new DataTable();

            // Agrega la columna de propiedad (primera columna)
            dt.Columns.Add("Concepto");

            // Agrega una columna por cada año
            foreach (var anio in amortizaciones.Select(a => a.Anio).Distinct())
            {
                dt.Columns.Add("Año " + anio, typeof(decimal));
            }

            // Helper para agregar filas
            void AddRow(string concepto, Func<Amortizacion, decimal> selector)
            {
                var row = dt.NewRow();
                row[0] = concepto;
                int col = 1;
                foreach (var a in amortizaciones)
                {
                    row[col++] = selector(a);
                }
                dt.Rows.Add(row);
            }

            AddRow("Saldo Inicial", a => a.SaldoInicial);
            AddRow("Cuota", a => a.Cuota);
            AddRow("Interés", a => a.Interes);
            AddRow("Abono a Capital", a => a.AbonoCapital);
            AddRow("Saldo Final", a => a.SaldoFinal);

            return dt;
        }
    }
}

