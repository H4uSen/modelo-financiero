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
using static System.Net.WebRequestMethods;

namespace modelo_finanzas

{
    public partial class FormSensibilidadFactibleVPN : Form
    {
        private readonly DatosEntrada _entrada = new DatosEntrada();
        private readonly DatosEscenarios _escenarios = new DatosEscenarios();
        private readonly Variables _variables = new Variables();
        private readonly List<Variables> _listaVariables = new List<Variables>();
        private readonly    Amortizacion _amortizacion = new Amortizacion();
        private readonly List<Amortizacion> _listaAmortizaciones = new List<Amortizacion>();
        private readonly EstadoResultados _estadoResultados = new EstadoResultados();
        private readonly List<EstadoResultados> _listaEstados = new List<EstadoResultados>();
        private readonly CostoCapital _costoCapital = new CostoCapital();
        private readonly FlujoCajaLibre _flujoCaja = new FlujoCajaLibre();
        private readonly List<FlujoCajaLibre> _listaFlujos = new List<FlujoCajaLibre>();
        private readonly FlujoCajaResultado _resultadoCajaLibre = new FlujoCajaResultado();
        public FormSensibilidadFactibleVPN(DatosEntrada entrada, DatosEscenarios escenario, Variables variables, Amortizacion amortizacion)
        {
            InitializeComponent();
            _entrada = entrada;
            _escenarios = escenario;
            _variables = variables;
            _amortizacion = amortizacion;
            this.Load += FormSensibilidadFactibleVPN_Load;
        }

        private void FormSensibilidadFactibleVPN_Load(object sender, EventArgs e)
        {
            dgvSensibilidad.Dock = DockStyle.Fill;
            ConfigurarDataGrid();
            CargarDatosIniciales();
            
            CalcularResultados();
        }

        private void ConfigurarDataGrid()
        {
            dgvSensibilidad.AllowUserToAddRows = false;
            dgvSensibilidad.RowHeadersVisible = false;
            dgvSensibilidad.EnableHeadersVisualStyles = false;
            dgvSensibilidad.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dgvSensibilidad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSensibilidad.Columns.Clear();

            // Columna principal (variables)
            dgvSensibilidad.Columns.Add("Variable", " ");
            dgvSensibilidad.Columns["Variable"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSensibilidad.Columns["Variable"].DefaultCellStyle.Font = new Font(dgvSensibilidad.Font.FontFamily, 9, FontStyle.Bold);
            dgvSensibilidad.Columns["Variable"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Columnas de valores
            dgvSensibilidad.Columns.Add("ValorMinimo", "Valor Mínimo");
            dgvSensibilidad.Columns.Add("ValorActual", "Valor Actual");
            dgvSensibilidad.Columns.Add("ValorMaximo", "Valor Máximo");

            // Columnas de resultados
            dgvSensibilidad.Columns.Add("VariacionNeta", "Variación neta del resultado");
            dgvSensibilidad.Columns.Add("GradoSensibilidad", "Grado de Sensibilidad");

            // Encabezado rosa solo para las columnas de valores
            Color colorRosa = Color.LightPink;
            dgvSensibilidad.Columns["ValorMinimo"].HeaderCell.Style.BackColor = colorRosa;
            dgvSensibilidad.Columns["ValorActual"].HeaderCell.Style.BackColor = colorRosa;
            dgvSensibilidad.Columns["ValorMaximo"].HeaderCell.Style.BackColor = colorRosa;
            dgvSensibilidad.Columns["ValorMinimo"].HeaderCell.Style.ForeColor = Color.Black;
            dgvSensibilidad.Columns["ValorActual"].HeaderCell.Style.ForeColor = Color.Black;
            dgvSensibilidad.Columns["ValorMaximo"].HeaderCell.Style.ForeColor = Color.Black;

        }
        
        private void CargarDatosIniciales()
        {

            dgvSensibilidad.Rows.Clear();

            SensibilidadFactibleVpn min = calcularFactibilidadVPN(-0.02m);

            SensibilidadFactibleVpn actual = calcularFactibilidadVPN(0m);
            SensibilidadFactibleVpn max = calcularFactibilidadVPN(0.02m);

            // Agregar variables fila por fila
            AgregarVariable("PARTICIPACIÓN EN EL MERCADO", min.ParticipacionMercado, actual.ParticipacionMercado, max.ParticipacionMercado, 
                min.ParticipacionMercadoVpn, actual.ParticipacionMercadoVpn, max.ParticipacionMercadoVpn, actual.ParticipacionMercadoVpn, true);

            AgregarVariable("CRECIMIENTO DEL MERCADO", min.CrecimientoMercado, actual.CrecimientoMercado, max.CrecimientoMercado, 
                min.CrecimientoMercadoVpn, actual.CrecimientoMercadoVpn, max.CrecimientoMercadoVpn, actual.CrecimientoMercadoVpn, true);

            AgregarVariable("PRECIO DE VENTA", min.PrecioVenta, actual.PrecioVenta, max.PrecioVenta, 
                min.PrecioVentaVpn, actual.PrecioVentaVpn, max.PrecioVentaVpn, actual.PrecioVentaVpn, false);

            AgregarVariable("COSTO DE PRODUCCIÓN", min.CostoProduccion, actual.CostoProduccion, max.CostoProduccion, 
                min.CostoProduccionVpn, actual.CostoProduccionVpn, max.CostoProduccionVpn, actual.CostoProduccionVpn, false);

            AgregarVariable("INFLACIÓN - IPC", min.InflacionAnual, actual.InflacionAnual, max.InflacionAnual, 
                min.InflacionAnualVpn, actual.InflacionAnualVpn, max.InflacionAnualVpn, actual.InflacionAnualVpn, true);

            AgregarVariable("GASTOS OPERATIVOS", min.GastosOperativos, actual.GastosOperativos, max.GastosOperativos, 
                min.GastosOperativosVpn, actual.GastosOperativosVpn, max.GastosOperativosVpn, actual.GastosOperativosVpn, true);


        }

        private void AgregarVariable(string nombre, decimal valMin, decimal valAct, decimal valMax,
                                     decimal absMin, decimal absAct, decimal absMax, decimal absExtra, bool esPorcentaje)
        {
            // Fila de valores 
            var fila = dgvSensibilidad.Rows.Add(nombre, valMin, valAct, valMax, "", "");

            if (esPorcentaje)
            {
                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.Format = "P1";
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.Format = "P1";
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.Format = "P1";

                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.BackColor = Color.LightGreen;
            }
            else
            {
                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.Format = "N0";
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.Format = "N0";
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.Format = "N0";

                dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.BackColor = Color.LightGreen;
                dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.BackColor = Color.LightGreen;

            }

            // Fila de valores de análisis (verde claro)
            dgvSensibilidad.Rows[fila].Cells["ValorMinimo"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["ValorActual"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["ValorMaximo"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["VariacionNeta"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvSensibilidad.Rows[fila].Cells["GradoSensibilidad"].Style.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Fila de valores 50,000,000 
            int filaAbsoluta = dgvSensibilidad.Rows.Add(absMin.ToString("N0"), absAct.ToString("N0"), absMax.ToString("N0"), absExtra.ToString("N0"), "", "");
            for (int col = 0; col < dgvSensibilidad.Columns.Count; col++)
            {
                //
                dgvSensibilidad.Rows[filaAbsoluta].Cells[col].Style.Font = new Font(dgvSensibilidad.Font, FontStyle.Regular);
                dgvSensibilidad.Rows[filaAbsoluta].Cells[col].Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void CalcularResultados()
        {
            // Iterar solo las filas de valores absolutos (cada 2ª fila)
            for (int i = 1; i < dgvSensibilidad.Rows.Count; i += 2)
            {
                DataGridViewRow fila = dgvSensibilidad.Rows[i];

                double valorMin = double.Parse(fila.Cells["ValorMinimo"].Value.ToString().Replace(",", ""));
                double valorAct = double.Parse(fila.Cells["ValorActual"].Value.ToString().Replace(",", ""));
                double valorMax = double.Parse(fila.Cells["ValorMaximo"].Value.ToString().Replace(",", ""));

                // Variación neta
                double variacionNeta = (valorMax - valorAct) + (valorMin - valorAct);
                fila.Cells["VariacionNeta"].Value = variacionNeta.ToString("N0");

                // Grado de Sensibilidad
                double gradoSensibilidad = valorAct != 0 ? variacionNeta / valorAct : 0;
                fila.Cells["GradoSensibilidad"].Value = gradoSensibilidad.ToString("P1");

                // Color según signo
                fila.Cells["GradoSensibilidad"].Style.ForeColor = gradoSensibilidad < 0 ? Color.Red : Color.Green;
            }
        }

        private void t_Click(object sender, EventArgs e)
        {
            CalcularResultados();
        }

        private SensibilidadFactibleVpn calcularFactibilidadVPN(decimal paso)
        { 
            SensibilidadFactibleVpn sensibilidadFactible = new SensibilidadFactibleVpn();
            CalculadorFinanciero calculador = new CalculadorFinanciero();
            EscenarioFinanciero datos = _entrada.ToEscenarioFinanciero();
            decimal vpnBase = (decimal)calculador.CalcularSoloVPN(datos,(double)datos.inflacionAnualIPC,(double)datos.objetivoMercado);
            decimal vpnCalc = 0;

            // Crecimiento del mercado
            while (true)
            {
                datos.crecimientoMercado += (double)paso/10;
                vpnCalc = (decimal)calculador.CalcularSoloVPN(datos, (double)datos.inflacionAnualIPC, (double)datos.objetivoMercado);
                if(paso > 0)                {
                    if (vpnCalc >= vpnBase)
                        break;
                }
                else
                {
                    if (vpnCalc <= vpnBase)
                        break;
                }

            }
            sensibilidadFactible.CrecimientoMercado = (decimal)datos.crecimientoMercado;
            sensibilidadFactible.CrecimientoMercadoVpn = vpnCalc;

            // Participación de mercado
            datos = _entrada.ToEscenarioFinanciero();
            while (true)
            {
                datos.objetivoMercado += (double)paso/10;
                vpnCalc = (decimal)calculador.CalcularSoloVPN(datos, (double)datos.inflacionAnualIPC, (double)datos.objetivoMercado);
                if (paso > 0)
                {
                    if (vpnCalc >= vpnBase)
                        break;
                }
                else
                {
                    if (vpnCalc <= vpnBase)
                        break;
                }
            }
            sensibilidadFactible.ParticipacionMercado = (decimal)datos.objetivoMercado;
            sensibilidadFactible.ParticipacionMercadoVpn = vpnCalc;

            //Precio venta
            datos = _entrada.ToEscenarioFinanciero();
            while (true)
            {
                datos.precioVentaInicial = datos.precioVentaInicial *(1 + (double)paso);
                vpnCalc = (decimal)calculador.CalcularSoloVPN(datos, (double)datos.inflacionAnualIPC, (double)datos.objetivoMercado);
                if (paso > 0)
                {
                    if (vpnCalc >= vpnBase)
                        break;
                }
                else
                {
                    datos.precioVentaInicial = (double)_entrada.PrecioInicial;
                    vpnCalc = vpnBase;
                    break;
                }
            }
            sensibilidadFactible.PrecioVenta = (decimal)datos.precioVentaInicial;
            sensibilidadFactible.PrecioVentaVpn = vpnCalc;

            // Costo producción
            datos = _entrada.ToEscenarioFinanciero();
            while (true) 
            {
                datos.costoProduccionUnitario = datos.costoProduccionUnitario * (1 + (double)paso);
                vpnCalc = (decimal)calculador.CalcularSoloVPN(datos, (double)datos.inflacionAnualIPC, (double)datos.objetivoMercado);

                if (paso > 0)
                {
                    if (vpnCalc <= vpnBase)
                        break;
                }
                else
                {
                    datos.costoProduccionUnitario = (double)_entrada.CostoProduccionInicial;
                    vpnCalc = vpnBase;
                    break;
                }
            } 
            sensibilidadFactible.CostoProduccion = (decimal)datos.costoProduccionUnitario;
            sensibilidadFactible.CostoProduccionVpn = vpnCalc;

            //IPC
            datos = _entrada.ToEscenarioFinanciero();
            while (true)
            {
                datos.inflacionAnualIPC += (double)paso / 10;
                vpnCalc = (decimal)calculador.CalcularSoloVPN(datos, (double)datos.inflacionAnualIPC, (double)datos.objetivoMercado);
                if (paso > 0)
                {
                    if (vpnCalc >= vpnBase)
                        break;
                }
                else
                {
                    if (vpnCalc <= vpnBase)
                        break;
                }
            } 
            sensibilidadFactible.InflacionAnual = (decimal)datos.inflacionAnualIPC;
            sensibilidadFactible.InflacionAnualVpn = vpnCalc;

            //Gastos operativos
            datos = _entrada.ToEscenarioFinanciero();
            int i = 0;
            while (true) 
            {
                datos.gastosOperativosPorc += (double)paso / 10;
                vpnCalc = (decimal)calculador.CalcularSoloVPN(datos, (double)datos.inflacionAnualIPC, (double)datos.objetivoMercado);
                if (paso > 0)
                {
                    if (vpnCalc >= vpnBase)
                        break;
                }
                else
                {
                    if (vpnCalc <= vpnBase)
                        break;
                }
                i++;
                if (i > 7) break;
            } 
            sensibilidadFactible.GastosOperativos = (decimal)datos.gastosOperativosPorc;
            sensibilidadFactible.GastosOperativosVpn = vpnCalc;


            return sensibilidadFactible;
        }
    }
}