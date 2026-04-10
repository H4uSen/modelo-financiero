namespace modelo_finanzas
{
    partial class FormSalidas
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
            pnlCostoCapital = new Panel();
            pnlFlujoCaja = new Panel();
            pnlCajaResultados = new Panel();
            SuspendLayout();
            // 
            // pnlCostoCapital
            // 
            pnlCostoCapital.Location = new Point(0, 1);
            pnlCostoCapital.Name = "pnlCostoCapital";
            pnlCostoCapital.Size = new Size(198, 450);
            pnlCostoCapital.TabIndex = 0;
            // 
            // pnlFlujoCaja
            // 
            pnlFlujoCaja.AutoSize = true;
            pnlFlujoCaja.Location = new Point(204, 1);
            pnlFlujoCaja.Name = "pnlFlujoCaja";
            pnlFlujoCaja.Size = new Size(0, 0);
            pnlFlujoCaja.TabIndex = 1;
            // 
            // pnlCajaResultados
            // 
            pnlCajaResultados.AutoSize = true;
            pnlCajaResultados.Location = new Point(204, 236);
            pnlCajaResultados.Name = "pnlCajaResultados";
            pnlCajaResultados.Size = new Size(650, 151);
            pnlCajaResultados.TabIndex = 2;
            // 
            // FormSalidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(989, 450);
            Controls.Add(pnlCajaResultados);
            Controls.Add(pnlFlujoCaja);
            Controls.Add(pnlCostoCapital);
            Name = "FormSalidas";
            Text = "FormSalidas";
            Load += FormSalidas_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlCostoCapital;
        private Panel pnlFlujoCaja;
        private Panel pnlCajaResultados;
    }
}