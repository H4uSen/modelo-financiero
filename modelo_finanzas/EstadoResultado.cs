using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace modelo_finanzas
{
    public partial class EstadoResultado : Form
    {
        public EstadoResultado()
        {
            InitializeComponent();
        }

        private async void EstadoResultados_Load(object sender, EventArgs e)
        {
            // Bloquear edición
            dgvEstadoResultado.ReadOnly = true;
            dgvEstadoResultado.AllowUserToAddRows = false;
            dgvEstadoResultado.AllowUserToDeleteRows = false;

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
            string query = "SELECT anio, ventas, costo_ventas, utilidad_bruta, gastos_operativos, depreciacion, total_gastos, utilidad_operativa, gastos_financieros, otros_ingresos, neto_otros_ingresos, utilidad_antes_impuestos, impuestos, utilidad_neta, capital_trabajo FROM estadoResultados where id_escenario = 1 ORDER BY anio";

            var db = DbConnection.Instance;
            if(await db.TestConnectionAsync())
            {
                var conn = await db.GetConnectionAsync();
                SqlCommand cmd = new SqlCommand(query, conn);
                MessageBox.Show("Conexión exitosa!");

                SqlDataReader reader = cmd.ExecuteReader();

                int colIndex = 2; // la primera columna (0) es el concepto, empezamos a llenar desde la columna 1
                while (reader.Read())
                {
                    dgvEstadoResultado.Rows[0].Cells[colIndex].Value = reader["ventas"];
                    dgvEstadoResultado.Rows[1].Cells[colIndex].Value = reader["costo_ventas"];
                    dgvEstadoResultado.Rows[2].Cells[colIndex].Value = reader["utilidad_bruta"];
                    dgvEstadoResultado.Rows[3].Cells[colIndex].Value = reader["gastos_operativos"];
                    dgvEstadoResultado.Rows[4].Cells[colIndex].Value = reader["depreciacion"];
                    dgvEstadoResultado.Rows[5].Cells[colIndex].Value = reader["total_gastos"];
                    dgvEstadoResultado.Rows[6].Cells[colIndex].Value = reader["utilidad_operativa"];
                    dgvEstadoResultado.Rows[7].Cells[colIndex].Value = reader["gastos_financieros"];
                    dgvEstadoResultado.Rows[8].Cells[colIndex].Value = reader["otros_ingresos"];
                    dgvEstadoResultado.Rows[9].Cells[colIndex].Value = reader["neto_otros_ingresos"];
                    dgvEstadoResultado.Rows[10].Cells[colIndex].Value = reader["utilidad_antes_impuestos"];
                    dgvEstadoResultado.Rows[11].Cells[colIndex].Value = reader["impuestos"];
                    dgvEstadoResultado.Rows[12].Cells[colIndex].Value = reader["utilidad_neta"];
                    dgvEstadoResultado.Rows[13].Cells[colIndex].Value = reader["capital_trabajo"];

                    colIndex++; // siguiente columna para el siguiente año
                }

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

                conn.Close();
            }
            ;
                
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
