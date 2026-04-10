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

namespace modelo_finanzas
{
    public partial class FormFlujoCaja : Form
    {
        private readonly List<FlujoCajaLibre> _flujos;
        public FormFlujoCaja(List<FlujoCajaLibre> flujos)
        {
            InitializeComponent();
            dgvFlujoCaja.Enabled = false;
            _flujos = flujos;  
            this.Load += FormFlujoCaja_Load;
        }

        private void FormFlujoCaja_Load(object? sender, EventArgs e)
        {

            dgvFlujoCaja.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFlujoCaja.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvFlujoCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;


            dgvFlujoCaja.Rows.Add("Utilidad Neta");
            dgvFlujoCaja.Rows.Add("Gasto Financiero");
            dgvFlujoCaja.Rows.Add("Impuestos Causados");
            dgvFlujoCaja.Rows.Add("EBIT");
            dgvFlujoCaja.Rows.Add("Impuestos Ajustados");
            dgvFlujoCaja.Rows.Add("EBIT (1-tx)");
            dgvFlujoCaja.Rows.Add("Depreciación");
            dgvFlujoCaja.Rows.Add("Flujo Bruto");
            dgvFlujoCaja.Rows.Add("Inversión en Capital de Trabajo");
            dgvFlujoCaja.Rows.Add("Inversión Inicial en Activos Fijos");
            dgvFlujoCaja.Rows.Add("Flujo Caja Libre");

            for (int col = 0; col < 6; col++)
            {   
                var flujo = _flujos[col];
                dgvFlujoCaja.Rows[0].Cells[col+1].Value = flujo.UtilidadNeta.ToString("N0");
                dgvFlujoCaja.Rows[1].Cells[col+1].Value = flujo.GastoFinanciero.ToString("N0");
                dgvFlujoCaja.Rows[2].Cells[col + 1].Value = flujo.ImpuestosCausados.ToString("N0");
                dgvFlujoCaja.Rows[3].Cells[col + 1].Value = flujo.EBIT.ToString("N0");
                dgvFlujoCaja.Rows[4].Cells[col + 1].Value = flujo.ImpuestosAjustados.ToString("N0");
                dgvFlujoCaja.Rows[5].Cells[col + 1].Value = flujo.EBITUODI.ToString("N0");
                dgvFlujoCaja.Rows[6].Cells[col + 1].Value = flujo.Depreciacion.ToString("N0");
                dgvFlujoCaja.Rows[7].Cells[col + 1].Value = flujo.FlujoBruto.ToString("N0");
                dgvFlujoCaja.Rows[8].Cells[col + 1].Value = flujo.InversionCapitalTrabajo.ToString("N0");
                dgvFlujoCaja.Rows[9].Cells[col + 1].Value = flujo.InversionActivosFijos.ToString("N0");
                dgvFlujoCaja.Rows[10].Cells[col + 1].Value = flujo.FlujoCajaLibreValor.ToString("N0");
            }

            dgvFlujoCaja.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

        }
    }
}
