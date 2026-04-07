using modelo_finanzas.Logic;
using modelo_finanzas.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using modelo_finanzas;


namespace modelo_finanzas
{
    public partial class FormCargarEscenario : Form
    {
        private FlowLayoutPanel flowLayoutPanel1;

        public FormCargarEscenario()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.Text = "Escenarios Guardados";
          //  this.Width = 500;using modelo_finanzas.Logic;


            // Configuramos un FlowLayoutPanel dinámico para mostrar las tarjetas
            flowLayoutPanel1 = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(10)
            };
            this.Controls.Add(flowLayoutPanel1);

            // Cargar los escenarios al iniciar
            this.Load += CargarEscenario_Load;
        }

        private void CargarEscenario_Load(object sender, EventArgs e)
        {
            CargarTarjetasEscenarios();
        }

        private async void CargarTarjetasEscenarios()
        {
            try
            {
                DatosService service = new DatosService();
                List<DatosEntrada> escenarios = await service.GetAllDatos();

                flowLayoutPanel1.Controls.Clear();

                foreach (var escenario in escenarios)
                {
                    Panel card = CrearTarjeta(escenario);
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los escenarios: " + ex.Message);
            }
        }

        private Panel CrearTarjeta(DatosEntrada escenario)
        {
            // Contenedor principal de la tarjeta
            Panel pnlCard = new Panel
            {
                Size = new Size(350, 100),
                BackColor = Color.White,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                Cursor = Cursors.Hand
            };

            // Título
            Label lblTitulo = new Label
            {
                Text = escenario.NombreEscenario,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true,
                ForeColor = Color.DarkBlue,
                Cursor = Cursors.Hand
            };

            // Descripción breve
            Label lblDesc = new Label
            {
                Text = $"Fecha: {escenario.FechaCreacion.ToShortDateString()}\nTamaño Mercado: {escenario.TamanioMercado:N0}\nInversión: {escenario.InversionEquipos:C}",
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Location = new Point(10, 40),
                AutoSize = true,
                Cursor = Cursors.Hand
            };

            // Eventos Click para la tarjeta y sus elementos
            pnlCard.Click += (s, e) => AbrirEscenario(escenario);
            lblTitulo.Click += (s, e) => AbrirEscenario(escenario);
            lblDesc.Click += (s, e) => AbrirEscenario(escenario);

            pnlCard.Controls.Add(lblTitulo);
            pnlCard.Controls.Add(lblDesc);

            return pnlCard;
        }

        private void AbrirEscenario(DatosEntrada escenario)
        {
            // Now FormEntradaDatos accepts a DatosEntrada object to prefill its text controls
            FormEntradaDatos frm = new FormEntradaDatos(escenario);

            frm.Show();
            this.Hide(); 
        }
    }
}
