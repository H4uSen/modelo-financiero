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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            txtEncRealizadas = new TextBox();
            txtCrecimientoAnualMerc = new TextBox();
            txtTamanioMercado = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            groupBox3 = new GroupBox();
            label10 = new Label();
            label12 = new Label();
            label15 = new Label();
            groupBox4 = new GroupBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            txtManiComp = new TextBox();
            txtObjeMer = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los siguientes datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 1;
            label2.Text = "Tamaño del mercado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(213, 19);
            label4.TabIndex = 3;
            label4.Text = "% crecimiento anual del mercado:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 116);
            label5.Name = "label5";
            label5.Size = new Size(135, 19);
            label5.TabIndex = 4;
            label5.Text = "Encuestas realizadas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(256, 116);
            label6.Name = "label6";
            label6.Size = new Size(148, 19);
            label6.TabIndex = 5;
            label6.Text = "Manifestaron comprar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(256, 66);
            label7.Name = "label7";
            label7.Size = new Size(152, 19);
            label7.TabIndex = 6;
            label7.Text = "% objetivo de mercado:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtObjeMer);
            groupBox1.Controls.Add(txtManiComp);
            groupBox1.Controls.Add(txtEncRealizadas);
            groupBox1.Controls.Add(txtCrecimientoAnualMerc);
            groupBox1.Controls.Add(txtTamanioMercado);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(10, 24);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(502, 165);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mercado y demanda";
            // 
            // txtEncRealizadas
            // 
            txtEncRealizadas.Location = new Point(6, 134);
            txtEncRealizadas.Name = "txtEncRealizadas";
            txtEncRealizadas.PlaceholderText = "ej. 5000";
            txtEncRealizadas.Size = new Size(213, 26);
            txtEncRealizadas.TabIndex = 13;
            // 
            // txtCrecimientoAnualMerc
            // 
            txtCrecimientoAnualMerc.Location = new Point(6, 88);
            txtCrecimientoAnualMerc.Name = "txtCrecimientoAnualMerc";
            txtCrecimientoAnualMerc.PlaceholderText = "ej. 2.5%";
            txtCrecimientoAnualMerc.Size = new Size(213, 26);
            txtCrecimientoAnualMerc.TabIndex = 12;
            // 
            // txtTamanioMercado
            // 
            txtTamanioMercado.Location = new Point(6, 40);
            txtTamanioMercado.Name = "txtTamanioMercado";
            txtTamanioMercado.PlaceholderText = "ej. 2000000";
            txtTamanioMercado.Size = new Size(213, 26);
            txtTamanioMercado.TabIndex = 11;
            txtTamanioMercado.KeyPress += txtTamanioMercado_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(75, 440);
            button1.Name = "button1";
            button1.Size = new Size(89, 44);
            button1.TabIndex = 9;
            button1.Text = "test connection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label13);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ActiveCaptionText;
            groupBox2.Location = new Point(534, 24);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(476, 165);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Precios e inflación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 22);
            label8.Name = "label8";
            label8.Size = new Size(127, 17);
            label8.TabIndex = 1;
            label8.Text = "Precio del producto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(256, 20);
            label9.Name = "label9";
            label9.Size = new Size(193, 19);
            label9.TabIndex = 2;
            label9.Text = "% de inflación anual esperado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 65);
            label11.Name = "label11";
            label11.Size = new Size(341, 19);
            label11.TabIndex = 3;
            label11.Text = "% de incremento real al precio por encima de inflación:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 115);
            label13.Name = "label13";
            label13.Size = new Size(202, 19);
            label13.TabIndex = 4;
            label13.Text = "% de IPP adicional a la inflación:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label15);
            groupBox3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ActiveCaptionText;
            groupBox3.Location = new Point(10, 204);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(502, 117);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Costos";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 22);
            label10.Name = "label10";
            label10.Size = new Size(170, 17);
            label10.TabIndex = 1;
            label10.Text = "Costo de producción inicial:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(256, 20);
            label12.Name = "label12";
            label12.Size = new Size(236, 19);
            label12.TabIndex = 2;
            label12.Text = "% de gastos operativos sobre ventas:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 65);
            label15.Name = "label15";
            label15.Size = new Size(230, 19);
            label15.TabIndex = 3;
            label15.Text = "% de capital de trabajo sobre ventas";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label24);
            groupBox4.Controls.Add(label23);
            groupBox4.Controls.Add(label22);
            groupBox4.Controls.Add(label21);
            groupBox4.Controls.Add(label20);
            groupBox4.Controls.Add(label19);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label17);
            groupBox4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox4.ForeColor = SystemColors.ActiveCaptionText;
            groupBox4.Location = new Point(534, 204);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(502, 280);
            groupBox4.TabIndex = 10;
            groupBox4.TabStop = false;
            groupBox4.Text = "Inversión, financiamiento y otros parámetros";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(306, 207);
            label24.Name = "label24";
            label24.Size = new Size(137, 19);
            label24.TabIndex = 10;
            label24.Text = "% de tasa impositiva:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 207);
            label23.Name = "label23";
            label23.Size = new Size(180, 19);
            label23.TabIndex = 9;
            label23.Text = "% de gradiente de los flujos:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 160);
            label22.Name = "label22";
            label22.Size = new Size(201, 19);
            label22.TabIndex = 8;
            label22.Text = "% prima de riesgo del mercado:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(306, 160);
            label21.Name = "label21";
            label21.Size = new Size(102, 19);
            label21.TabIndex = 7;
            label21.Text = "Beta del sector:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 113);
            label20.Name = "label20";
            label20.Size = new Size(161, 19);
            label20.TabIndex = 6;
            label20.Text = "% de tasa libre de riesgo:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(306, 113);
            label19.Name = "label19";
            label19.Size = new Size(112, 19);
            label19.TabIndex = 5;
            label19.Text = "Plazo del crédito:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(306, 66);
            label18.Name = "label18";
            label18.Size = new Size(161, 19);
            label18.TabIndex = 4;
            label18.Text = "% financiado con crédito:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(6, 21);
            label14.Name = "label14";
            label14.Size = new Size(280, 17);
            label14.TabIndex = 1;
            label14.Text = "Inversión en equipos X punto de participación:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(306, 19);
            label16.Name = "label16";
            label16.Size = new Size(143, 19);
            label16.TabIndex = 2;
            label16.Text = "Plazo de depreciación:";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 66);
            label17.Name = "label17";
            label17.Size = new Size(275, 19);
            label17.TabIndex = 3;
            label17.Text = "% de recuperaciones sobre costo de ventas:";
            // 
            // txtManiComp
            // 
            txtManiComp.Location = new Point(256, 134);
            txtManiComp.Name = "txtManiComp";
            txtManiComp.PlaceholderText = "ej. 5000";
            txtManiComp.Size = new Size(213, 26);
            txtManiComp.TabIndex = 14;
            // 
            // txtObjeMer
            // 
            txtObjeMer.Location = new Point(256, 88);
            txtObjeMer.Name = "txtObjeMer";
            txtObjeMer.PlaceholderText = "ej. 2.5%";
            txtObjeMer.Size = new Size(213, 26);
            txtObjeMer.TabIndex = 15;
            // 
            // FormEntradaDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 511);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormEntradaDatos";
            Text = "Modelo Financiero";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
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
        private Button button1;
        private GroupBox groupBox2;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label13;
        private GroupBox groupBox3;
        private Label label10;
        private Label label12;
        private Label label15;
        private GroupBox groupBox4;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label18;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox txtTamanioMercado;
        private TextBox txtCrecimientoAnualMerc;
        private TextBox txtEncRealizadas;
        private TextBox txtObjeMer;
        private TextBox txtManiComp;
    }
}
