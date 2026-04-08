namespace modelo_finanzas
{
    partial class FormVariacionPorcentalVPN
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
            dgvInflacion = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvInflacion).BeginInit();
            SuspendLayout();
            // 
            // dgvInflacion
            // 
            dgvInflacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInflacion.Location = new Point(37, 46);
            dgvInflacion.Name = "dgvInflacion";
            dgvInflacion.Size = new Size(583, 206);
            dgvInflacion.TabIndex = 0;
            // 
            // FormVariacionPorcentalVPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 283);
            Controls.Add(dgvInflacion);
            Name = "FormVariacionPorcentalVPN";
            Text = "FormVariacionPorcentalVPN";
            Load += FormVariacionPorcentalVPN_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInflacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvInflacion;
    }
}