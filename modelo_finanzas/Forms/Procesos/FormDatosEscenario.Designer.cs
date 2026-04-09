namespace modelo_finanzas
{
    partial class FormDatosEscenario
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
            label1 = new Label();
            txtMercEsperado = new TextBox();
            label2 = new Label();
            txtVarNomPrecio = new TextBox();
            txtVarNomIPP = new TextBox();
            label3 = new Label();
            txtValInvInicial = new TextBox();
            label4 = new Label();
            txtFinanCredito = new TextBox();
            label5 = new Label();
            txtFinanAportes = new TextBox();
            label6 = new Label();
            txtCostoDeuda = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(137, 30);
            label1.TabIndex = 0;
            label1.Text = "% de mercado esperado \r\nen año 1:";
            label1.Click += label1_Click;
            // 
            // txtMercEsperado
            // 
            txtMercEsperado.Location = new Point(2, 34);
            txtMercEsperado.Name = "txtMercEsperado";
            txtMercEsperado.Size = new Size(138, 23);
            txtMercEsperado.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 60);
            label2.Name = "label2";
            label2.Size = new Size(105, 30);
            label2.TabIndex = 2;
            label2.Text = "Variación nominal \r\ndel precio:";
            // 
            // txtVarNomPrecio
            // 
            txtVarNomPrecio.Location = new Point(2, 92);
            txtVarNomPrecio.Name = "txtVarNomPrecio";
            txtVarNomPrecio.Size = new Size(138, 23);
            txtVarNomPrecio.TabIndex = 3;
            // 
            // txtVarNomIPP
            // 
            txtVarNomIPP.Location = new Point(2, 136);
            txtVarNomIPP.Name = "txtVarNomIPP";
            txtVarNomIPP.Size = new Size(138, 23);
            txtVarNomIPP.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 118);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 4;
            label3.Text = "Variación nominal del IPP:";
            // 
            // txtValInvInicial
            // 
            txtValInvInicial.Location = new Point(2, 180);
            txtValInvInicial.Name = "txtValInvInicial";
            txtValInvInicial.Size = new Size(138, 23);
            txtValInvInicial.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 162);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 6;
            label4.Text = "Valor inversión inicial:";
            // 
            // txtFinanCredito
            // 
            txtFinanCredito.Location = new Point(2, 268);
            txtFinanCredito.Name = "txtFinanCredito";
            txtFinanCredito.Size = new Size(138, 23);
            txtFinanCredito.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 250);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 8;
            label5.Text = "Financiado con crédito:";
            // 
            // txtFinanAportes
            // 
            txtFinanAportes.Location = new Point(2, 312);
            txtFinanAportes.Name = "txtFinanAportes";
            txtFinanAportes.Size = new Size(138, 23);
            txtFinanAportes.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 294);
            label6.Name = "label6";
            label6.Size = new Size(133, 15);
            label6.TabIndex = 10;
            label6.Text = "Financiado con aportes:";
            // 
            // txtCostoDeuda
            // 
            txtCostoDeuda.Location = new Point(2, 224);
            txtCostoDeuda.Name = "txtCostoDeuda";
            txtCostoDeuda.Size = new Size(138, 23);
            txtCostoDeuda.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 206);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 12;
            label7.Text = "Costo de deuda:";
            // 
            // FormDatosEscenario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(163, 386);
            Controls.Add(txtCostoDeuda);
            Controls.Add(label7);
            Controls.Add(txtFinanAportes);
            Controls.Add(label6);
            Controls.Add(txtFinanCredito);
            Controls.Add(label5);
            Controls.Add(txtValInvInicial);
            Controls.Add(label4);
            Controls.Add(txtVarNomIPP);
            Controls.Add(label3);
            Controls.Add(txtVarNomPrecio);
            Controls.Add(label2);
            Controls.Add(txtMercEsperado);
            Controls.Add(label1);
            Name = "FormDatosEscenario";
            Text = "DatosEscenario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMercEsperado;
        private Label label2;
        private TextBox txtVarNomPrecio;
        private TextBox txtVarNomIPP;
        private Label label3;
        private TextBox txtValInvInicial;
        private Label label4;
        private TextBox txtFinanCredito;
        private Label label5;
        private TextBox txtFinanAportes;
        private Label label6;
        private TextBox txtCostoDeuda;
        private Label label7;
    }
}