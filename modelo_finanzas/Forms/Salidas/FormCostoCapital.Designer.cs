namespace modelo_finanzas.Forms.Salidas
{
    partial class FormCostoCapital
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
            txtBetaLSector = new TextBox();
            label7 = new Label();
            txtCostoCapital = new TextBox();
            label6 = new Label();
            txtCostoPatrimonio = new TextBox();
            label5 = new Label();
            txtCostDeuDespImp = new TextBox();
            label4 = new Label();
            txtCostoDeuda = new TextBox();
            label3 = new Label();
            txtPorcAportes = new TextBox();
            label2 = new Label();
            txtPorcDeuda = new TextBox();
            label1 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtBetaLSector
            // 
            txtBetaLSector.Location = new Point(1, 247);
            txtBetaLSector.Name = "txtBetaLSector";
            txtBetaLSector.Size = new Size(161, 23);
            txtBetaLSector.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1, 229);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 26;
            label7.Text = "BetaL del sector:";
            // 
            // txtCostoCapital
            // 
            txtCostoCapital.Location = new Point(1, 335);
            txtCostoCapital.Name = "txtCostoCapital";
            txtCostoCapital.Size = new Size(161, 23);
            txtCostoCapital.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 317);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 24;
            label6.Text = "Costo del capital:";
            // 
            // txtCostoPatrimonio
            // 
            txtCostoPatrimonio.Location = new Point(1, 291);
            txtCostoPatrimonio.Name = "txtCostoPatrimonio";
            txtCostoPatrimonio.Size = new Size(161, 23);
            txtCostoPatrimonio.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 273);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 22;
            label5.Text = "Costo del patrimonio:";
            // 
            // txtCostDeuDespImp
            // 
            txtCostDeuDespImp.Location = new Point(1, 203);
            txtCostDeuDespImp.Name = "txtCostDeuDespImp";
            txtCostDeuDespImp.Size = new Size(161, 23);
            txtCostDeuDespImp.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 170);
            label4.Name = "label4";
            label4.Size = new Size(139, 30);
            label4.TabIndex = 20;
            label4.Text = "Costo de deuda despues \r\nde impuestos:";
            // 
            // txtCostoDeuda
            // 
            txtCostoDeuda.Location = new Point(1, 142);
            txtCostoDeuda.Name = "txtCostoDeuda";
            txtCostoDeuda.Size = new Size(161, 23);
            txtCostoDeuda.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 124);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 18;
            label3.Text = "Costo de la deuda:";
            // 
            // txtPorcAportes
            // 
            txtPorcAportes.Location = new Point(1, 98);
            txtPorcAportes.Name = "txtPorcAportes";
            txtPorcAportes.Size = new Size(161, 23);
            txtPorcAportes.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 16;
            label2.Text = "% de aportes:";
            // 
            // txtPorcDeuda
            // 
            txtPorcDeuda.Location = new Point(1, 54);
            txtPorcDeuda.Name = "txtPorcDeuda";
            txtPorcDeuda.Size = new Size(161, 23);
            txtPorcDeuda.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 36);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 14;
            label1.Text = "% de deuda:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(1, 9);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 28;
            label8.Text = "Costo de capital";
            // 
            // FormCostoCapital
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(175, 379);
            Controls.Add(label8);
            Controls.Add(txtBetaLSector);
            Controls.Add(label7);
            Controls.Add(txtCostoCapital);
            Controls.Add(label6);
            Controls.Add(txtCostoPatrimonio);
            Controls.Add(label5);
            Controls.Add(txtCostDeuDespImp);
            Controls.Add(label4);
            Controls.Add(txtCostoDeuda);
            Controls.Add(label3);
            Controls.Add(txtPorcAportes);
            Controls.Add(label2);
            Controls.Add(txtPorcDeuda);
            Controls.Add(label1);
            Name = "FormCostoCapital";
            Text = "FormCostoCapital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBetaLSector;
        private Label label7;
        private TextBox txtCostoCapital;
        private Label label6;
        private TextBox txtCostoPatrimonio;
        private Label label5;
        private TextBox txtCostDeuDespImp;
        private Label label4;
        private TextBox txtCostoDeuda;
        private Label label3;
        private TextBox txtPorcAportes;
        private Label label2;
        private TextBox txtPorcDeuda;
        private Label label1;
        private Label label8;
    }
}