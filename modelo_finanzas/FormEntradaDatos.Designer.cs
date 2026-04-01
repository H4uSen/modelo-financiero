namespace modelo_finanzas
{
    partial class FormEntradaDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los siguientes datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 26);
            label2.Name = "label2";
            label2.Size = new Size(182, 25);
            label2.TabIndex = 1;
            label2.Text = "Tamano del mercado:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 28);
            label3.Name = "label3";
            label3.Size = new Size(246, 23);
            label3.TabIndex = 2;
            label3.Text = "% de crecimiento del mercado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 88);
            label4.Name = "label4";
            label4.Size = new Size(269, 23);
            label4.TabIndex = 3;
            label4.Text = "% crecimiento anual del mercado:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 155);
            label5.Name = "label5";
            label5.Size = new Size(169, 23);
            label5.TabIndex = 4;
            label5.Text = "Encuestas realizadas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(292, 155);
            label6.Name = "label6";
            label6.Size = new Size(183, 23);
            label6.TabIndex = 5;
            label6.Text = "Manifestaron comprar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(292, 88);
            label7.Name = "label7";
            label7.Size = new Size(190, 23);
            label7.TabIndex = 6;
            label7.Text = "% objetivo de mercado:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(544, 241);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mercado y demanda";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 614);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Modelo Financiero";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Label label7;
        private GroupBox groupBox1;
    }
}
