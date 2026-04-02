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
            dgvTablaVentasProyectadas.Location = new Point(37, 67);
            dgvTablaVentasProyectadas.Name = "dgvTablaVentasProyectadas";
            dgvTablaVentasProyectadas.RowHeadersWidth = 51;
            dgvTablaVentasProyectadas.Size = new Size(618, 122);
            dgvTablaVentasProyectadas.TabIndex = 0;
            // 
            // dgvTablaCostosGastos
            // 
            dgvTablaCostosGastos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaCostosGastos.Location = new Point(37, 271);
            dgvTablaCostosGastos.Name = "dgvTablaCostosGastos";
            dgvTablaCostosGastos.RowHeadersWidth = 51;
            dgvTablaCostosGastos.Size = new Size(618, 122);
            dgvTablaCostosGastos.TabIndex = 0;
            // 
            // dgvTablaAmortiCredito
            // 
            dgvTablaAmortiCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaAmortiCredito.Location = new Point(37, 485);
            dgvTablaAmortiCredito.Name = "dgvTablaAmortiCredito";
            dgvTablaAmortiCredito.RowHeadersWidth = 51;
            dgvTablaAmortiCredito.Size = new Size(618, 122);
            dgvTablaAmortiCredito.TabIndex = 0;
            // 
            // btnEstadoResultados
            // 
            btnEstadoResultados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEstadoResultados.Location = new Point(37, 651);
            btnEstadoResultados.Name = "btnEstadoResultados";
            btnEstadoResultados.Size = new Size(416, 77);
            btnEstadoResultados.TabIndex = 1;
            btnEstadoResultados.Text = "Ver Estado de Resultados";
            btnEstadoResultados.UseVisualStyleBackColor = true;
            // 
            // VistaProcesosFinancieros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 778);
            Controls.Add(btnEstadoResultados);
            Controls.Add(dgvTablaAmortiCredito);
            Controls.Add(dgvTablaCostosGastos);
            Controls.Add(dgvTablaVentasProyectadas);
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