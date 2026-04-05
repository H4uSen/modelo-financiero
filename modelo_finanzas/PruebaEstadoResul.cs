using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modelo_finanzas.Services;
using modelo_finanzas.Models;

namespace modelo_finanzas
{
    public partial class PruebaEstadoResul : Form
    {
        public PruebaEstadoResul()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = 1;

                // 2. Llamar al Service que ya programamos
                // (Asegurate que el nombre de la clase sea el mismo que le pusiste)
                EstadoResultadosService service = new EstadoResultadosService();

                // Ejecutamos el motor de cálculo
                service.GenerarTodoElEstado(id);

                MessageBox.Show("¡Cálculos completados y guardados en la base de datos!");

                // 3. Abrir el segundo Form donde está la tabla
                // (Pasamos el ID para que el otro form sepa qué mostrar)
                //FormTablaResultados pantallaTabla = new FormTablaResultados(id);
                //pantallaTabla.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar: " + ex.Message);
            }
        }
    }
}
