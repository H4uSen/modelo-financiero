namespace modelo_finanzas.Forms.Analisis
{
    partial class FormSensiPuntual
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
            dataGridView1 = new DataGridView();
            Concepto = new DataGridViewTextBoxColumn();
            menos = new DataGridViewTextBoxColumn();
            zero = new DataGridViewTextBoxColumn();
            mas = new DataGridViewTextBoxColumn();
            varPorc = new DataGridViewTextBoxColumn();
            gradSen = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnCalcular = new Button();
            txtPorcentaje = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentaje).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Concepto, menos, zero, mas, varPorc, gradSen });
            dataGridView1.Location = new Point(3, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(667, 354);
            dataGridView1.TabIndex = 0;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Sensibilidad puntual";
            Concepto.Name = "Concepto";
            // 
            // menos
            // 
            menos.HeaderText = "-1";
            menos.Name = "menos";
            // 
            // zero
            // 
            zero.HeaderText = "0";
            zero.Name = "zero";
            // 
            // mas
            // 
            mas.HeaderText = "+1";
            mas.Name = "mas";
            // 
            // varPorc
            // 
            varPorc.HeaderText = "Variacion porcentual";
            varPorc.Name = "varPorc";
            // 
            // gradSen
            // 
            gradSen.HeaderText = "Grado de sensibilidad";
            gradSen.Name = "gradSen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(287, 21);
            label1.TabIndex = 1;
            label1.Text = "Análisis de sensibilidad puntual del VPN";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(220, 56);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(164, 33);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPorcentaje.Location = new Point(3, 60);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(211, 29);
            txtPorcentaje.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 36);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 4;
            label2.Text = "Variación porcentual:";
            // 
            // FormSensiPuntual
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtPorcentaje);
            Controls.Add(btnCalcular);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormSensiPuntual";
            Text = "FormSensiPuntual";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn menos;
        private DataGridViewTextBoxColumn zero;
        private DataGridViewTextBoxColumn mas;
        private DataGridViewTextBoxColumn varPorc;
        private DataGridViewTextBoxColumn gradSen;
        private Label label1;
        private Button btnCalcular;
        private NumericUpDown txtPorcentaje;
        private Label label2;
    }
}