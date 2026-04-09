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
            dgvVariacion = new DataGridView();
            btnVariacion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVariacion).BeginInit();
            SuspendLayout();
            // 
            // dgvVariacion
            // 
            dgvVariacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVariacion.Location = new Point(37, 46);
            dgvVariacion.Name = "dgvVariacion";
            dgvVariacion.Size = new Size(583, 206);
            dgvVariacion.TabIndex = 0;
            // 
            // btnVariacion
            // 
            btnVariacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVariacion.Location = new Point(248, 272);
            btnVariacion.Name = "btnVariacion";
            btnVariacion.Size = new Size(129, 44);
            btnVariacion.TabIndex = 1;
            btnVariacion.Text = "Variación VPN";
            btnVariacion.UseVisualStyleBackColor = true;
            btnVariacion.Click += btnVariacion_Click;
            // 
            // FormVariacionPorcentalVPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 344);
            Controls.Add(btnVariacion);
            Controls.Add(dgvVariacion);
            Name = "FormVariacionPorcentalVPN";
            Text = "FormVariacionPorcentalVPN";
            Load += FormVariacionPorcentalVPN_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVariacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvVariacion;
        private Button btnVariacion;
    }
}