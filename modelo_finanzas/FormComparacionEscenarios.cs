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

namespace modelo_finanzas
{
    public partial class FormComparacionEscenarios : Form
    {
        // MARCOS: Asegúrate de incluir el MultipleActiveResultSets=True para evitar el error de DataReader abierto

        // MARCOS: Usamos localhost,1435 y las credenciales del usuario 'sa'
        string connectionString = "Server=localhost,1435;Database=hausencito247_finanzas;User ID=sa;Password=finanzas123#;Encrypt=False;TrustServerCertificate=True;MultipleActiveResultSets=True;";
        //string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=hausencito247_finanzas;Integrated Security=True;MultipleActiveResultSets=True;";
        public FormComparacionEscenarios()
        {
            InitializeComponent();
            CargarComboEscenarios(); // Llama al método al iniciar
        }
        private void CargarComboEscenarios()
        {
            string query = "SELECT id_escenario, nombre_escenario FROM entradasEscenarios";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da1 = new SqlDataAdapter(query, conn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);

                    // Clonamos la tabla para el segundo combo para evitar problemas de selección vinculada
                    DataTable dt2 = dt1.Copy();

                    // Configurar Combo 1
                    cboEscenarios1.DataSource = dt1;
                    cboEscenarios1.DisplayMember = "nombre_escenario";
                    cboEscenarios1.ValueMember = "id_escenario";
                    cboEscenarios1.SelectedIndex = -1; // Para que empiece vacío

                    // Configurar Combo 2
                    cboEscenarios2.DataSource = dt2;
                    cboEscenarios2.DisplayMember = "nombre_escenario";
                    cboEscenarios2.ValueMember = "id_escenario";
                    cboEscenarios2.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de conexión: " + ex.Message);
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // Verificamos que sea una selección válida
            /* if (cboEscenarios1.SelectedValue != null && int.TryParse(cboEscenarios1.SelectedValue.ToString(), out int id))
             {
                 // Pasamos el ID y el nombre del DataGridView que tenés en tu diseño
                // CargarComparacionEnDGV(id, dgvResumen1);
             }*/
        }

        public void LlenarComparacion(int idEscenario, DataGridView dgv)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Indicador Financiero");
            dt.Columns.Add("Valor del Escenario");

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Quitamos la TIR del SELECT porque no existe en tu tabla todavía
                string query = @"
            SELECT 
                r.valor_presente_neto, 
                r.valor_terminal,
                r.inversion_inicial_activos,
                c.costo_capital,
                (SELECT SUM(interes) FROM amortizacion WHERE id_escenario = @id) as total_interes
            FROM resultados_caja_libre r
            LEFT JOIN costoCapital c ON r.id_escenario = c.id_escenario
            WHERE r.id_escenario = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", idEscenario);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // Mostramos solo lo que sí existe en tus tablas actualmente
                        dt.Rows.Add("VPN Final", Convert.ToDecimal(reader["valor_presente_neto"]).ToString("C2"));

                        // Si llegamos a calcular la TIR, la ponemos aquí. Por ahora la omitimos para que no de error.
                        // dt.Rows.Add("TIR", "Calculando..."); 

                        dt.Rows.Add("Valor Terminal", Convert.ToDecimal(reader["valor_terminal"]).ToString("C2"));
                        dt.Rows.Add("Inversión Inicial", Convert.ToDecimal(reader["inversion_inicial_activos"]).ToString("C2"));
                        dt.Rows.Add("WACC (Costo Cap.)", (Convert.ToDecimal(reader["costo_capital"]) / 100).ToString("P2"));
                        dt.Rows.Add("Intereses Totales", Convert.ToDecimal(reader["total_interes"]).ToString("C2"));
                    }
                    else
                    {
                        dt.Rows.Add("Aviso", "No hay datos para este escenario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            // --- EL DISEÑO QUE TE GUSTA (AZUL CELESTE) ---
            dgv.DataSource = dt;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Colores y Negritas
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SkyBlue;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }



        private void cboEscenarios1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEscenarios1.SelectedValue != null && int.TryParse(cboEscenarios1.SelectedValue.ToString(), out int id))
            {
                // Actualiza el DGV de la izquierda
                LlenarComparacion(id, dgvResumen1);
            }
        }

        private void cboEscenarios2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEscenarios2.SelectedValue != null && int.TryParse(cboEscenarios2.SelectedValue.ToString(), out int id))
            {
                // Actualiza el DGV de la derecha
                LlenarComparacion(id, dgvResumen2);
            }
        }

        private void dgvResumen2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
