namespace Prueba1
{
    partial class VistaProcesosFinancieros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTablaVentasProyectadas = new DataGridView();
            dgvTablaCostosGastos = new DataGridView();
            dgvTablaAmortiCredito = new DataGridView();
            btnEstadoResultados = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTablaVentasProyectadas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaCostosGastos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaAmortiCredito).BeginInit();
            SuspendLayout();
            // 
            // dgvTablaVentasProyectadas
            // 
            dgvTablaVentasProyectadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaVentasProyectadas.Location = new Point(32, 50);
            dgvTablaVentasProyectadas.Margin = new Padding(3, 2, 3, 2);
            dgvTablaVentasProyectadas.Name = "dgvTablaVentasProyectadas";
            dgvTablaVentasProyectadas.RowHeadersWidth = 51;
            dgvTablaVentasProyectadas.Size = new Size(541, 92);
            dgvTablaVentasProyectadas.TabIndex = 0;
            // 
            // dgvTablaCostosGastos
            // 
            dgvTablaCostosGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaCostosGastos.Location = new Point(32, 203);
            dgvTablaCostosGastos.Margin = new Padding(3, 2, 3, 2);
            dgvTablaCostosGastos.Name = "dgvTablaCostosGastos";
            dgvTablaCostosGastos.RowHeadersWidth = 51;
            dgvTablaCostosGastos.Size = new Size(541, 92);
            dgvTablaCostosGastos.TabIndex = 0;
            // 
            // dgvTablaAmortiCredito
            // 
            dgvTablaAmortiCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaAmortiCredito.Location = new Point(32, 364);
            dgvTablaAmortiCredito.Margin = new Padding(3, 2, 3, 2);
            dgvTablaAmortiCredito.Name = "dgvTablaAmortiCredito";
            dgvTablaAmortiCredito.RowHeadersWidth = 51;
            dgvTablaAmortiCredito.Size = new Size(541, 92);
            dgvTablaAmortiCredito.TabIndex = 0;
            // 
            // btnEstadoResultados
            // 
            btnEstadoResultados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstadoResultados.Location = new Point(142, 485);
            btnEstadoResultados.Margin = new Padding(3, 2, 3, 2);
            btnEstadoResultados.Name = "btnEstadoResultados";
            btnEstadoResultados.Size = new Size(364, 58);
            btnEstadoResultados.TabIndex = 1;
            btnEstadoResultados.Text = "Ver Estado de Resultados";
            btnEstadoResultados.UseVisualStyleBackColor = true;
            // 
            // VistaProcesosFinancieros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 584);
            Controls.Add(btnEstadoResultados);
            Controls.Add(dgvTablaAmortiCredito);
            Controls.Add(dgvTablaCostosGastos);
            Controls.Add(dgvTablaVentasProyectadas);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VistaProcesosFinancieros";
            Text = "VistaProcesosFinancieros";
            FormClosed += VistaProcesosFinancieros_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvTablaVentasProyectadas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaCostosGastos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTablaAmortiCredito).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTablaVentasProyectadas;
        private DataGridView dgvTablaCostosGastos;
        private DataGridView dgvTablaAmortiCredito;
        private Button btnEstadoResultados;
    }
}