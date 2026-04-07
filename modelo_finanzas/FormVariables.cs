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
        private DatosEntrada datosEntrada;
        private DatosEscenarios datosEscenarios;

        public FormVariables(DatosEntrada de, DatosEscenarios ds)
        {
            InitializeComponent();
            datosEntrada = de;
            datosEscenarios = ds;
        }

        private void FormVariables_Load(object sender, EventArgs e)
        {
            ConfigurarTabla();
            CalcularYMostrar(datosEntrada, datosEscenarios);
        }

 
        private void ConfigurarTabla()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            // Que el DataGridView ocupe todo el formulario
            dataGridView1.Dock = DockStyle.Fill;
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
            for (int i = 0; i <= 5; i++)
            {
                Variables v = new Variables();
                v.Anio = i;

                v.CalcularVariables(v, de, ds, anterior);

                lista.Add(v);
                anterior = v;
            }

            //  LLENAR TABLA CORRECTAMENTE
            for (int col = 0; col <= 5; col++)
            {
                var v = lista[col];

                dataGridView1.Rows[0].Cells[col + 1].Value = Math.Round(v.TamanioMercado, 0);
                dataGridView1.Rows[1].Cells[col + 1].Value = v.ParticipacionMercado;
                dataGridView1.Rows[2].Cells[col + 1].Value = v.UnidadesVendidas;
                dataGridView1.Rows[3].Cells[col + 1].Value = Math.Round(v.PrecioVenta, 0);
                dataGridView1.Rows[4].Cells[col + 1].Value = Math.Round(v.CostoProduccion, 0);
            }
        }
    }
}

