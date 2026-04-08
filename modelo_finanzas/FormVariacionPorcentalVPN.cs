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
    public partial class FormVariacionPorcentalVPN : Form
    {
        public FormVariacionPorcentalVPN()
        {
            InitializeComponent();
        }

        private void FormVariacionPorcentalVPN_Load(object sender, EventArgs e)
        {
            // 1. Configuración de limpieza visual
            dgvInflacion.AllowUserToAddRows = false;
            dgvInflacion.RowHeadersVisible = false;
            dgvInflacion.EnableHeadersVisualStyles = false; // Permite pintar los encabezados
            dgvInflacion.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvInflacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Crear las 6 columnas (la primera para el eje y 5 para datos)
            dgvInflacion.Columns.Clear();
            for (int i = 0; i < 6; i++)
            {
                dgvInflacion.Columns.Add($"Col{i}", ""); // Sin texto en el encabezado
            }

            // 3. Crear las 7 filas
            dgvInflacion.Rows.Clear();
            for (int i = 0; i < 7; i++)
            {
                dgvInflacion.Rows.Add();
            }

            // 4. Aplicar los colores de la imagen (sin texto)

            // Color azul a la primera columna
            dgvInflacion.Columns[0].DefaultCellStyle.BackColor = Color.LightSkyBlue;

            // Color azul a todos los encabezados superiores
            foreach (DataGridViewColumn col in dgvInflacion.Columns)
            {
                col.HeaderCell.Style.BackColor = Color.LightSkyBlue;
            }

            // El cuadro verde en el lateral (Fila 4 en la imagen, índice 3)
            dgvInflacion.Rows[3].Cells[0].Style.BackColor = Color.Green;

            // El cuadro verde en el encabezado (Columna 4 en la imagen, índice 3)
            dgvInflacion.Columns[3].HeaderCell.Style.BackColor = Color.DarkGreen;

            // Quitar el color azul de selección al iniciar para que se vean los colores reales
            dgvInflacion.ClearSelection();
        }


    }
}
