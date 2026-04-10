namespace modelo_finanzas.Forms.Salidas
{
    partial class FormFlujoCajaResultados
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtVT = new TextBox();
            txtVPF = new TextBox();
            txtVPVT = new TextBox();
            txtVMN = new TextBox();
            txtIIAF = new TextBox();
            txtVPN = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor Terminal - VT:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 9);
            label2.Name = "label2";
            label2.Size = new Size(152, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor Presente de los Flujos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 9);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 2;
            label3.Text = "Valor Presente del VT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 55);
            label4.Name = "label4";
            label4.Size = new Size(169, 15);
            label4.TabIndex = 3;
            label4.Text = "Valor de Mercado del Negocio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(263, 55);
            label5.Name = "label5";
            label5.Size = new Size(177, 15);
            label5.TabIndex = 4;
            label5.Text = "Inversión Inicial en Activos Fijos:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(528, 55);
            label6.Name = "label6";
            label6.Size = new Size(147, 15);
            label6.TabIndex = 5;
            label6.Text = "Valor Presente Neto - VPN:";
            // 
            // txtVT
            // 
            txtVT.Location = new Point(3, 27);
            txtVT.Name = "txtVT";
            txtVT.Size = new Size(153, 23);
            txtVT.TabIndex = 6;
            // 
            // txtVPF
            // 
            txtVPF.Location = new Point(263, 27);
            txtVPF.Name = "txtVPF";
            txtVPF.Size = new Size(153, 23);
            txtVPF.TabIndex = 7;
            // 
            // txtVPVT
            // 
            txtVPVT.Location = new Point(528, 27);
            txtVPVT.Name = "txtVPVT";
            txtVPVT.Size = new Size(153, 23);
            txtVPVT.TabIndex = 8;
            // 
            // txtVMN
            // 
            txtVMN.Location = new Point(3, 73);
            txtVMN.Name = "txtVMN";
            txtVMN.Size = new Size(153, 23);
            txtVMN.TabIndex = 9;
            // 
            // txtIIAF
            // 
            txtIIAF.Location = new Point(263, 73);
            txtIIAF.Name = "txtIIAF";
            txtIIAF.Size = new Size(153, 23);
            txtIIAF.TabIndex = 10;
            // 
            // txtVPN
            // 
            txtVPN.Location = new Point(528, 73);
            txtVPN.Name = "txtVPN";
            txtVPN.Size = new Size(153, 23);
            txtVPN.TabIndex = 11;
            // 
            // FormFlujoCajaResultados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(703, 108);
            Controls.Add(txtVPN);
            Controls.Add(txtIIAF);
            Controls.Add(txtVMN);
            Controls.Add(txtVPVT);
            Controls.Add(txtVPF);
            Controls.Add(txtVT);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormFlujoCajaResultados";
            Text = "FormFlujoCajaResultados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtVT;
        private TextBox txtVPF;
        private TextBox txtVPVT;
        private TextBox txtVMN;
        private TextBox txtIIAF;
        private TextBox txtVPN;
    }
}