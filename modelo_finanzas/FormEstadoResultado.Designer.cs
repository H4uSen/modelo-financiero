namespace modelo_finanzas
{
    partial class FormEstadoResultado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvEstadoResultado = new DataGridView();
            CEstadoResultado = new DataGridViewTextBoxColumn();
            CAnio0 = new DataGridViewTextBoxColumn();
            CAnio1 = new DataGridViewTextBoxColumn();
            CAnio2 = new DataGridViewTextBoxColumn();
            CAnio3 = new DataGridViewTextBoxColumn();
            CAnio4 = new DataGridViewTextBoxColumn();
            CAnio5 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoResultado).BeginInit();
            SuspendLayout();
            // 
            // dgvEstadoResultado
            // 
            dgvEstadoResultado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoResultado.Columns.AddRange(new DataGridViewColumn[] { CEstadoResultado, CAnio0, CAnio1, CAnio2, CAnio3, CAnio4, CAnio5 });
            dgvEstadoResultado.Enabled = false;
            dgvEstadoResultado.Location = new Point(2, 2);
            dgvEstadoResultado.Margin = new Padding(3, 2, 3, 2);
            dgvEstadoResultado.Name = "dgvEstadoResultado";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEstadoResultado.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEstadoResultado.RowHeadersVisible = false;
            dgvEstadoResultado.RowHeadersWidth = 20;
            dgvEstadoResultado.Size = new Size(870, 276);
            dgvEstadoResultado.TabIndex = 0;
            // 
            // CEstadoResultado
            // 
            CEstadoResultado.HeaderText = "ESTADO DE RESULTADOS";
            CEstadoResultado.MinimumWidth = 6;
            CEstadoResultado.Name = "CEstadoResultado";
            CEstadoResultado.ReadOnly = true;
            CEstadoResultado.Width = 125;
            // 
            // CAnio0
            // 
            CAnio0.HeaderText = "Año 0";
            CAnio0.MinimumWidth = 6;
            CAnio0.Name = "CAnio0";
            CAnio0.Width = 125;
            // 
            // CAnio1
            // 
            CAnio1.HeaderText = "Año 1";
            CAnio1.MinimumWidth = 6;
            CAnio1.Name = "CAnio1";
            CAnio1.Width = 125;
            // 
            // CAnio2
            // 
            CAnio2.HeaderText = "Año 2";
            CAnio2.MinimumWidth = 6;
            CAnio2.Name = "CAnio2";
            CAnio2.Width = 125;
            // 
            // CAnio3
            // 
            CAnio3.HeaderText = "Año 3";
            CAnio3.MinimumWidth = 6;
            CAnio3.Name = "CAnio3";
            CAnio3.Width = 125;
            // 
            // CAnio4
            // 
            CAnio4.HeaderText = "Año 4";
            CAnio4.MinimumWidth = 6;
            CAnio4.Name = "CAnio4";
            CAnio4.Width = 125;
            // 
            // CAnio5
            // 
            CAnio5.HeaderText = "Año 5";
            CAnio5.MinimumWidth = 6;
            CAnio5.Name = "CAnio5";
            CAnio5.Width = 125;
            // 
            // FormEstadoResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 277);
            Controls.Add(dgvEstadoResultado);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEstadoResultado";
            Text = "EstadoResultados";
            Load += EstadoResultados_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstadoResultado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEstadoResultado;
        private DataGridViewTextBoxColumn CEstadoResultado;
        private DataGridViewTextBoxColumn CAnio0;
        private DataGridViewTextBoxColumn CAnio1;
        private DataGridViewTextBoxColumn CAnio2;
        private DataGridViewTextBoxColumn CAnio3;
        private DataGridViewTextBoxColumn CAnio4;
        private DataGridViewTextBoxColumn CAnio5;
    }
}