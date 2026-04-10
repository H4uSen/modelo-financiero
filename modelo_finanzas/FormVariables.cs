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
    public partial class FormVariables : Form
    {
        private readonly DatosEntrada _datosEntrada;
        private readonly DatosEscenarios _datosEscenarios;

        public FormVariables(DatosEntrada de, DatosEscenarios ds)
        {
            InitializeComponent();

            _datosEntrada = de;
            _datosEscenarios = ds;
            dataGridView1.Enabled = false;
            this.Load += FormVariables_Load;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Enabled = false;
            
            
        }

        private void FormVariables_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();


            CalcularYMostrar(_datosEntrada, _datosEscenarios);
            dataGridView1.ClearSelection();

        }

        private void ConfigurarTabla()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Que el DataGridView ocupe todo el formulario
            //dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Primera columna
            dataGridView1.Columns.Add("Variable", "VARIABLES");

            // Columnas de años (0 al 5)
            for (int i = 0; i <= 5; i++)
            {
                dataGridView1.Columns.Add("Anio" + i, "Año " + i);
            }

            // Filas (variables)
            dataGridView1.Rows.Add("Tamaño Mercado");
            dataGridView1.Rows.Add("Participación Mercado");
            dataGridView1.Rows.Add("Unidades Vendidas");
            dataGridView1.Rows.Add("Precio Venta");
            dataGridView1.Rows.Add("Costo Producción");
        }
        private void CalcularYMostrar(DatosEntrada de, DatosEscenarios ds)
        {
            List<Variables> lista = new List<Variables>();
            Variables anterior = null;

            // Generar datos Año 0 a Año 5
            lista = new Variables().CalcularVariables(de, ds);

            // LLENAR TABLA
            for (int col = 0; col <= 5; col++)
            {
                var v = lista[col];

                // Tamaño del mercado siempre se muestra
                dataGridView1.Rows[0].Cells[col + 1].Value =
                    Math.Round(v.TamanioMercado, 0, MidpointRounding.AwayFromZero).ToString("N0");

                // Participación en el mercado
                if (col == 0)
                    dataGridView1.Rows[1].Cells[col + 1].Value = ""; // Año 0 en blanco
                else
                    dataGridView1.Rows[1].Cells[col + 1].Value = v.ParticipacionMercado.ToString("P2");

                // Precio de venta
                if (col == 0)
                    dataGridView1.Rows[3].Cells[col + 1].Value = ""; // Año 0
                else
                    dataGridView1.Rows[3].Cells[col + 1].Value =
                        Math.Round(v.PrecioVenta, 0, MidpointRounding.AwayFromZero).ToString("N0");

                // Costo de producción
                if (col == 0)
                    dataGridView1.Rows[4].Cells[col + 1].Value = ""; // Año 0
                else
                    dataGridView1.Rows[4].Cells[col + 1].Value =
                        Math.Round(v.CostoProduccion, 0, MidpointRounding.AwayFromZero).ToString("N0");

                // Unidades vendidas
                if (col == 0)
                    dataGridView1.Rows[2].Cells[col + 1].Value = ""; // Año 0
                else
                    dataGridView1.Rows[2].Cells[col + 1].Value =
                        v.UnidadesVendidas.ToString("N0");
            }
        }

    }
}

