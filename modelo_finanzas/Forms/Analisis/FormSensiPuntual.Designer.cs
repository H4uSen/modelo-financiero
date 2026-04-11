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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv = new DataGridView();
            Concepto = new DataGridViewTextBoxColumn();
            menos = new DataGridViewTextBoxColumn();
            zero = new DataGridViewTextBoxColumn();
            mas = new DataGridViewTextBoxColumn();
            varPorc = new DataGridViewTextBoxColumn();
            gradSen = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnCalcular = new Button();
            btnPdf = new Button();
            txtPorcentaje = new NumericUpDown();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentaje).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Concepto, menos, zero, mas, varPorc, gradSen });
            dgv.Location = new Point(3, 95);
            dgv.Name = "dgv";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv.RowHeadersVisible = false;
            dgv.Size = new Size(651, 467);
            dgv.TabIndex = 0;
            // 
            // Concepto
            // 
            Concepto.HeaderText = "Sensibilidad puntual";
            Concepto.Name = "Concepto";
            Concepto.Width = 127;
            // 
            // menos
            // 
            menos.HeaderText = "-1";
            menos.Name = "menos";
            menos.Width = 43;
            // 
            // zero
            // 
            zero.HeaderText = "0";
            zero.Name = "zero";
            zero.Width = 38;
            // 
            // mas
            // 
            mas.HeaderText = "+1";
            mas.Name = "mas";
            mas.Width = 46;
            // 
            // varPorc
            // 
            varPorc.HeaderText = "Variacion porcentual";
            varPorc.Name = "varPorc";
            varPorc.Width = 128;
            // 
            // gradSen
            // 
            gradSen.HeaderText = "Grado de sensibilidad";
            gradSen.Name = "gradSen";
            gradSen.Width = 133;
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
            // btnPdf
            // 
            btnPdf.Location = new Point(390, 56);
            btnPdf.Name = "btnPdf";
            btnPdf.Size = new Size(164, 33);
            btnPdf.TabIndex = 5;
            btnPdf.Text = "Guardar como PDF";
            btnPdf.UseVisualStyleBackColor = true;
            btnPdf.Click += btnPdf_Click;
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
            AutoSize = true;
            ClientSize = new Size(655, 565);
            Controls.Add(label2);
            Controls.Add(txtPorcentaje);
            Controls.Add(btnCalcular);
            Controls.Add(btnPdf);
            Controls.Add(label1);
            Controls.Add(dgv);
            Name = "FormSensiPuntual";
            Text = "FormSensiPuntual";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPorcentaje).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private DataGridViewTextBoxColumn Concepto;
        private DataGridViewTextBoxColumn menos;
        private DataGridViewTextBoxColumn zero;
        private DataGridViewTextBoxColumn mas;
        private DataGridViewTextBoxColumn varPorc;
        private DataGridViewTextBoxColumn gradSen;
        private Label label1;
        private Button btnCalcular;
        private Button btnPdf;
        private NumericUpDown txtPorcentaje;
        private Label label2;
    }
}