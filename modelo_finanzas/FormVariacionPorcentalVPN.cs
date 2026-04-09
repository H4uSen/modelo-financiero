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
            dgvVariacion.AllowUserToAddRows = false;
            dgvVariacion.RowHeadersVisible = false;
            dgvVariacion.EnableHeadersVisualStyles = false; // Permite pintar los encabezados
            dgvVariacion.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvVariacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 2. Crear las 6 columnas (la primera para el eje y 5 para datos)
            dgvVariacion.Columns.Clear();
            for (int i = 0; i < 6; i++)
            {
                dgvVariacion.Columns.Add($"Col{i}", ""); // Sin texto en el encabezado
            }

            // 3. Crear las 7 filas
            dgvVariacion.Rows.Clear();
            for (int i = 0; i < 7; i++)
            {
                dgvVariacion.Rows.Add();
            }

            // 4. Aplicar los colores de la imagen (sin texto)

            // Color azul a la primera columna
            dgvVariacion.Columns[0].DefaultCellStyle.BackColor = Color.LightSkyBlue;

            // Color azul a todos los encabezados superiores
            foreach (DataGridViewColumn col in dgvVariacion.Columns)
            {
                col.HeaderCell.Style.BackColor = Color.LightSkyBlue;
            }

            // El cuadro verde en el lateral (Fila 4 en la imagen, índice 3)
            dgvVariacion.Rows[3].Cells[0].Style.BackColor = Color.Green;

            // El cuadro verde en el encabezado (Columna 4 en la imagen, índice 3)
            dgvVariacion.Columns[3].HeaderCell.Style.BackColor = Color.DarkGreen;

            // Quitar el color azul de selección al iniciar para que se vean los colores reales
            dgvVariacion.ClearSelection();
        }

        private void btnVariacion_Click(object sender, EventArgs e)
        {
            // 1. Recuperamos los datos base y el motor
            var datosBase = EscenarioFinanciero.EscenarioActual;
            CalculadorFinanciero motor = new CalculadorFinanciero();

            // 2. Definimos los puntos de partida (los verdes)
            double objetivoBase = 0.04; // 4.0%
            double inflacionBase = 0.035; // 3.5%
            double salto = 0.002; // 0.2%

            objetivoBase = datosBase.objetivoMercado;
            inflacionBase = datosBase.inflacionAnualIPC;

            // 3. Limpiamos el DataGridView antes de empezar
            dgvVariacion.Rows.Clear();

            // --- EL BUCLE ANIDADO ---

            // Recorremos las FILAS (Objetivo de Mercado: del 3.4% al 4.6%)
            // Usamos i de -3 a 3 para cubrir 7 posiciones (4% es el centro)
            for (int i = -3; i <= 3; i++)
            {
                double objetivoFila = objetivoBase + (i * salto);

                // Creamos una nueva fila en el DGV
                int nFila = dgvVariacion.Rows.Add();

                // La primera columna muestra el porcentaje de la fila (ej: 3.4%)
                dgvVariacion.Rows[nFila].Cells[0].Value = objetivoFila.ToString("P1");

                // Recorremos las COLUMNAS (Inflación: del 3.1% al 3.9%)
                // j de -2 a 2 para las 5 columnas de datos
                for (int j = -2; j <= 2; j++)
                {
                    double inflacionColumna = inflacionBase + (j * salto);

                    // 4. ¡LA MAGIA! Llamamos al motor con los valores de esta celda
                    // El motor usa los 22 datos fijos pero reemplaza estos dos
                    double vpnCelda = motor.CalcularSoloVPN(datosBase, inflacionColumna, objetivoFila);

                    // 5. Asignamos el resultado a la celda correspondiente
                    // Sumamos 1 a j porque la columna 0 es la de las etiquetas
                    dgvVariacion.Rows[nFila].Cells[j + 3].Value = vpnCelda.ToString("N1");

                    // Pintar de verde si es el valor base (centro)
                    if (i == 0 && j == 0)
                    {
                        dgvVariacion.Rows[nFila].Cells[j + 3].Style.BackColor = Color.Green;
                        dgvVariacion.Rows[nFila].Cells[j + 3].Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
