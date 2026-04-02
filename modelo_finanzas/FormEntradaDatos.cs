using System.Configuration;
using modelo_finanzas.Utils;
namespace modelo_finanzas
{
    public partial class FormEntradaDatos : Form
    {
        public FormEntradaDatos()
        {
            InitializeComponent();

            txtTamanioMercado.MaxLength = 15;
            txtEncRealizadas.MaxLength = 15;
            txtCrecimientoAnualMerc.MaxLength = 5;



            txtCrecimientoAnualMerc.KeyPress += (s, e) =>
            {
                InputValidator.decimalValidation(txtCrecimientoAnualMerc, e);
            };
            txtEncRealizadas.KeyPress += (s, e) =>
            {
                InputValidator.integerValidation(txtEncRealizadas, e);
            };
            txtTamanioMercado.KeyPress += txtTamanioMercado_KeyPress;



            txtCrecimientoAnualMerc.Validated += (s, e) =>
            {
                if (double.TryParse(txtCrecimientoAnualMerc.Text, out double value))
                {
                    txtCrecimientoAnualMerc.Text = (value / 100).ToString("0.##%");
                }
            };

            txtTamanioMercado.Validated += (s, e) =>
            {
                if (int.TryParse(txtTamanioMercado.Text, out int value))
                {
                    txtTamanioMercado.Text = value.ToString("N0");
                }
            };
            txtTamanioMercado.Validated += (s, e) =>
            {
                if (int.TryParse(txtTamanioMercado.Text, System.Globalization.NumberStyles.AllowThousands, null, out int value))
                {
                    txtTamanioMercado.Text = value.ToString("N0");
                }
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            DbConnection db = DbConnection.Instance;
            if (await db.TestConnectionAsync())
            {
                MessageBox.Show("Conexión exitosa a la base de datos.");
            }
            else
            {
                MessageBox.Show("Error al conectar a la base de datos.");
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void txtTamanioMercado_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.integerValidation(txtTamanioMercado, e);
        }

        private void FormEntradaDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
