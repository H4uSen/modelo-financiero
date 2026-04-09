using Microsoft.Data.SqlClient;
using modelo_finanzas.Models;
using modelo_finanzas.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelo_finanzas
{
    public partial class FormEstadoResultado : Form
    {
        private readonly List<EstadoResultados> _estados;
        public FormEstadoResultado(List<EstadoResultados> estados)
        {
            InitializeComponent();
            _estados = estados;
        }

        private void EstadoResultados_Load(object sender, EventArgs e)
        {
            // Bloquear edición
            dgvEstadoResultado.ReadOnly = true;
            dgvEstadoResultado.AllowUserToAddRows = false;
            dgvEstadoResultado.AllowUserToDeleteRows = false;

            dgvEstadoResultado.Dock = DockStyle.Fill;
            dgvEstadoResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstadoResultado.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            
            //dgvEstadoResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dgvEstadoResultado.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Paso 1: Definir las filas fijas
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

            // Paso 2: Traer datos de la base
            // string connectionString = "Server=TU_SERVIDOR;Database=TU_BASE;User Id=USUARIO;Password=CLAVE;";
            //string connectionString = "Server=MSI\\LOCALDB#1ACB50EC;Database=hausencito247_finanzas;Integrated Security=True;";
            //string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=hausencito247_finanzas;Integrated Security=True;";
            try
            {

                    //int colIndex = 2; // la primera columna (0) es el concepto, empezamos a llenar desde la columna 1
                    for(int i = 1; i <= _estados.Count; i++)
                    {
                        int colIndex = i - 1;
                        dgvEstadoResultado.Rows[0].Cells[i].Value = _estados[colIndex].Ventas;
                        dgvEstadoResultado.Rows[1].Cells[i].Value = _estados[colIndex].CostoVentas;
                        dgvEstadoResultado.Rows[2].Cells[i].Value = _estados[colIndex].UtilidadBruta;
                        dgvEstadoResultado.Rows[3].Cells[i].Value = _estados[colIndex].GastosOperativos;
                        dgvEstadoResultado.Rows[4].Cells[i].Value = _estados[colIndex].Depreciacion;
                        dgvEstadoResultado.Rows[5].Cells[i].Value = _estados[colIndex].TotalGastos;
                        dgvEstadoResultado.Rows[6].Cells[i].Value = _estados[colIndex].UtilidadOperativa;
                        dgvEstadoResultado.Rows[7].Cells[i].Value = _estados[colIndex].GastosFinancieros;
                        dgvEstadoResultado.Rows[8].Cells[i].Value = _estados[colIndex].OtrosIngresos;
                        dgvEstadoResultado.Rows[9].Cells[i].Value = _estados[colIndex].NetoOtrosIngresos;
                        dgvEstadoResultado.Rows[10].Cells[i].Value = _estados[colIndex].UtilidadAntesImpuestos;
                        dgvEstadoResultado.Rows[11].Cells[i].Value = _estados[colIndex].Impuestos;
                        dgvEstadoResultado.Rows[12].Cells[i].Value = _estados[colIndex].UtilidadNeta;
                        dgvEstadoResultado.Rows[13].Cells[i].Value = _estados[colIndex].CapitalTrabajo;

                        colIndex++; // siguiente columna para el siguiente año
                    }

                    // ESTE ES PARA EL FORMATO NUMÉRICO
                    foreach (DataGridViewColumn col in dgvEstadoResultado.Columns)
                    {
                        if (col.Index == 0 || col.Index == 1) continue; // Concepto no es numérico

                        col.DefaultCellStyle.Format = "N0"; // Formato con comas sin decimales
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }

                    // Alinear primera columna
                    //dgvEstadoResultado.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    // Ajustar ancho automático
                    //dgvEstadoResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvEstadoResultado.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    /*
                    //si después lo hago fijo este sería el código para poner un ancho fijo a las columnas de datos (excepto la primera)
                    for (int i = 1; i < dgvEstadoResultado.Columns.Count; i++)
                    {
                        dgvEstadoResultado.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                        dgvEstadoResultado.Columns[i].Width = 120; // o el ancho que quieras
                    }

                     */
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

                    dgvEstadoResultado.ClearSelection();

            }
            catch(Exception ex)
            {
                throw new Exception($"Error con el estado de resultados:{ex.Message}");
            }
        }

        /*private void EstadoResultados_Load(object sender, EventArgs e)
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

        }*/
    }
}
