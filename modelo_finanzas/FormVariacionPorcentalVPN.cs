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
            // Esto estira las columnas para que llenen el ancho del control
            dgvVariacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // Esto quita la fila vacía del final
            dgvVariacion.AllowUserToAddRows = false;
            // 1. Centrar contenido de celdas y encabezados
            dgvVariacion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVariacion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 2. Ajustar diseño para eliminar lo gris y llenar el ancho
            dgvVariacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVariacion.BackgroundColor = Color.White; // Quita el fondo gris
            dgvVariacion.RowHeadersVisible = false;      // Quita la columna gris de la izquierda

            // 3. Estilo de los encabezados (Azul)
            dgvVariacion.EnableHeadersVisualStyles = false;
            dgvVariacion.ColumnHeadersDefaultCellStyle.BackColor = Color.DeepSkyBlue;
            dgvVariacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            // 1. Ajustar el alto de la fila de encabezados para que sea igual a las otras
            dgvVariacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVariacion.ColumnHeadersHeight = 30; // Ajusta este número según el alto de tus otras filas

            // 2. Asegurar que el texto del encabezado esté centrado vertical y horizontalmente
            dgvVariacion.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /* // 1. Configuración de limpieza visual
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
             dgvVariacion.ClearSelection();*/
        }

        private void btnVariacion_Click(object sender, EventArgs e)
        {
            if (dgvVariacion.Columns.Count == 0)
            {
                for (int c = 0; c < 6; c++) { dgvVariacion.Columns.Add("col" + c, ""); }
            }

            dgvVariacion.Rows.Clear();
            var datosBase = EscenarioFinanciero.EscenarioActual;
            CalculadorFinanciero motor = new CalculadorFinanciero();
            if (datosBase == null) return;

            double objetivoBase = datosBase.objetivoMercado;
            double inflacionBase = datosBase.inflacionAnualIPC;
            double vpnbase = motor.CalcularSoloVPN(datosBase, inflacionBase, objetivoBase);



            double salto = 0.002;

            // --- CONFIGURACIÓN DE FUENTE GLOBAL ---
            // Creamos una fuente un poco más grande (Tamaño 11 y en Negrita para encabezados)
            Font fuenteGrandeNegrita = new Font("Segoe UI", 11, FontStyle.Bold);
            Font fuenteGrandeNormal = new Font("Segoe UI", 10);

            // --- CONFIGURACIÓN DE ENCABEZADOS (FILA SUPERIOR) ---
            dgvVariacion.Columns[0].HeaderText = vpnbase.ToString("N1");
            dgvVariacion.Columns[0].HeaderCell.Style.BackColor = Color.SlateBlue; // Morado elegante
            dgvVariacion.Columns[0].HeaderCell.Style.ForeColor = Color.White;
            dgvVariacion.Columns[0].HeaderCell.Style.Font = fuenteGrandeNegrita;
            dgvVariacion.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            for (int j = -2; j <= 2; j++)
            {
                double inflacionCol = inflacionBase + (j * salto);
                int indiceCol = j + 3;
                dgvVariacion.Columns[indiceCol].HeaderText = inflacionCol.ToString("P1");
                dgvVariacion.Columns[indiceCol].HeaderCell.Style.Font = fuenteGrandeNegrita;
                dgvVariacion.Columns[indiceCol].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                if (j == 0)
                {
                    dgvVariacion.Columns[indiceCol].HeaderCell.Style.BackColor = Color.Green;
                }
                else
                {
                    dgvVariacion.Columns[indiceCol].HeaderCell.Style.BackColor = Color.DeepSkyBlue;
                }
                dgvVariacion.Columns[indiceCol].HeaderCell.Style.ForeColor = Color.White;
            }

            // --- LLENADO DE FILAS Y DATOS ---
            for (int i = -3; i <= 3; i++)
            {
                double objetivoFila = objetivoBase + (i * salto);
                int nFila = dgvVariacion.Rows.Add();

                // Aplicar fuente más grande a la fila
                dgvVariacion.Rows[nFila].DefaultCellStyle.Font = fuenteGrandeNormal;

                // Etiqueta vertical
                dgvVariacion.Rows[nFila].Cells[0].Value = objetivoFila.ToString("P1");
                dgvVariacion.Rows[nFila].Cells[0].Style.Font = fuenteGrandeNegrita; // Negrita para el eje Y

                if (i == 0)
                {
                    dgvVariacion.Rows[nFila].Cells[0].Style.BackColor = Color.Green;
                    dgvVariacion.Rows[nFila].Cells[0].Style.ForeColor = Color.White;
                }
                else
                {
                    dgvVariacion.Rows[nFila].Cells[0].Style.BackColor = Color.LightSkyBlue;
                    dgvVariacion.Rows[nFila].Cells[0].Style.ForeColor = Color.Black;
                }

                for (int j = -2; j <= 2; j++)
                {
                    double inflacionCol = inflacionBase + (j * salto);
                    double vpnCalculado = motor.CalcularSoloVPN(datosBase, inflacionCol, objetivoFila);
                    dgvVariacion.Rows[nFila].Cells[j + 3].Value = vpnCalculado.ToString("N1");
                }
            }

            // --- CÓDIGO FINAL DEL BOTÓN ---
            dgvVariacion.ClearSelection();

            double variaMercado2 = CalculadorFinanciero.F127 / CalculadorFinanciero.F126 - 1;
            double variaInfla2 = CalculadorFinanciero.G126 / CalculadorFinanciero.F126 - 1;

            varInfla.Text = $"Variación Inflación: {variaInfla2:P2}";
            varMercado.Text = $"Variación Mercado: {variaMercado2:P2}";

            CalculadorFinanciero.F126 = 0; // Reiniciar acumulado de esta corrida
            CalculadorFinanciero.F127 = 0; // Reiniciar acumulado de esta corrida
            CalculadorFinanciero.G126 = 0; // Reiniciar acumulado de esta corrida
            CalculadorFinanciero.TotalCalculosRealizados = 0; // Reiniciar contador de cálculos


            // Mensaje informativo
            //int calculosDeEstaVez = 35; // Sabemos que son 35 por la matriz 7x5
            /* string mensaje = $"Simulación completada con éxito.\n\n" +
                              $"• Cálculos en esta tabla: {variaInfla2}\n" +
                              $"• Total acumulado global: {variaMercado2}";

             MessageBox.Show(mensaje, "Reporte del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
             */
        }


    }
}
