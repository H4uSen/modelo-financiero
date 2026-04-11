namespace modelo_finanzas
{
    partial class FormSensibilidadFactibleVPN
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
            dgvSensibilidad = new DataGridView();
            t = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSensibilidad).BeginInit();
            SuspendLayout();
            // 
            // dgvSensibilidad
            // 
            dgvSensibilidad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSensibilidad.Location = new Point(2, -3);
            dgvSensibilidad.Name = "dgvSensibilidad";
            dgvSensibilidad.Size = new Size(776, 349);
            dgvSensibilidad.TabIndex = 0;
            // 
            // t
            // 
            t.Anchor = AnchorStyles.Top;
            t.Location = new Point(2, 352);
            t.Name = "t";
            t.Size = new Size(133, 41);
            t.TabIndex = 1;
            t.Text = "Calcular";
            t.UseVisualStyleBackColor = true;
            t.Click += t_Click;
            // 
            // FormSensibilidadFactibleVPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 405);
            Controls.Add(t);
            Controls.Add(dgvSensibilidad);
            Name = "FormSensibilidadFactibleVPN";
            Text = "Analisis de Sensibilidad Factible del VPN";
            ((System.ComponentModel.ISupportInitialize)dgvSensibilidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSensibilidad;
        private Button t;
    }
}