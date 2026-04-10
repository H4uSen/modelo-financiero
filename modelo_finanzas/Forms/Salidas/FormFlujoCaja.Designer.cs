namespace modelo_finanzas
{
    partial class FormFlujoCaja
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
            dgvFlujoCaja = new DataGridView();
            Concepto = new DataGridViewTextBoxColumn();
            Anio0 = new DataGridViewTextBoxColumn();
            Anio1 = new DataGridViewTextBoxColumn();
            anio2 = new DataGridViewTextBoxColumn();
            Anio3 = new DataGridViewTextBoxColumn();
            Anio4 = new DataGridViewTextBoxColumn();
            Anio5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFlujoCaja).BeginInit();
            SuspendLayout();
            // 
            // dgvFlujoCaja
            // 
            dgvFlujoCaja.AllowUserToAddRows = false;
            dgvFlujoCaja.AllowUserToDeleteRows = false;
            dgvFlujoCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlujoCaja.Columns.AddRange(new DataGridViewColumn[] { Concepto, Anio0, Anio1, anio2, Anio3, Anio4, Anio5 });
            dgvFlujoCaja.Enabled = false;
            dgvFlujoCaja.Location = new Point(5, 4);
            dgvFlujoCaja.Name = "dgvFlujoCaja";
            dgvFlujoCaja.ReadOnly = true;
            dgvFlujoCaja.RowHeadersVisible = false;
            dgvFlujoCaja.RowHeadersWidth = 15;
            dgvFlujoCaja.Size = new Size(772, 220);
            dgvFlujoCaja.TabIndex = 0;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Flujo Caja";
            Concepto.Name = "Concepto";
            Concepto.ReadOnly = true;
            // 
            // Anio0
            // 
            Anio0.HeaderText = "Año 0";
            Anio0.Name = "Anio0";
            Anio0.ReadOnly = true;
            // 
            // Anio1
            // 
            Anio1.HeaderText = "Año 1";
            Anio1.Name = "Anio1";
            Anio1.ReadOnly = true;
            // 
            // anio2
            // 
            anio2.HeaderText = "Año 2";
            anio2.Name = "anio2";
            anio2.ReadOnly = true;
            // 
            // Anio3
            // 
            Anio3.HeaderText = "Año 3";
            Anio3.Name = "Anio3";
            Anio3.ReadOnly = true;
            // 
            // Anio4
            // 
            Anio4.HeaderText = "Año 4";
            Anio4.Name = "Anio4";
            Anio4.ReadOnly = true;
            // 
            // Anio5
            // 
            Anio5.HeaderText = "Año 5";
            Anio5.Name = "Anio5";
            Anio5.ReadOnly = true;
            // 
            // FormFlujoCaja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(781, 170);
            Controls.Add(dgvFlujoCaja);
            Name = "FormFlujoCaja";
            Text = "FormFlujoCaja";
            ((System.ComponentModel.ISupportInitialize)dgvFlujoCaja).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvFlujoCaja;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn Anio0;
        private DataGridViewTextBoxColumn Anio1;
        private DataGridViewTextBoxColumn anio2;
        private DataGridViewTextBoxColumn Anio3;
        private DataGridViewTextBoxColumn Anio4;
        private DataGridViewTextBoxColumn Anio5;
    }
}