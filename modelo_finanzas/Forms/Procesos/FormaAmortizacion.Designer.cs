namespace Prueba1
{
    partial class FormaAmortizacion
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
            dgvTablaAmortiCredito = new DataGridView();
            lblCuotaFija = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTablaAmortiCredito).BeginInit();
            SuspendLayout();
            // 
            // dgvTablaAmortiCredito
            // 
            dgvTablaAmortiCredito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTablaAmortiCredito.Location = new Point(3, 24);
            dgvTablaAmortiCredito.Margin = new Padding(3, 2, 3, 2);
            dgvTablaAmortiCredito.Name = "dgvTablaAmortiCredito";
            dgvTablaAmortiCredito.RowHeadersWidth = 51;
            dgvTablaAmortiCredito.Size = new Size(520, 160);
            dgvTablaAmortiCredito.TabIndex = 0;
            dgvTablaAmortiCredito.CellContentClick += dgvTablaAmortiCredito_CellContentClick;
            // 
            // lblCuotaFija
            // 
            lblCuotaFija.AutoSize = true;
            lblCuotaFija.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCuotaFija.Location = new Point(71, 187);
            lblCuotaFija.Name = "lblCuotaFija";
            lblCuotaFija.Size = new Size(51, 21);
            lblCuotaFija.TabIndex = 2;
            lblCuotaFija.Text = "Cuota";
            lblCuotaFija.Click += lblCuotaFija_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 3;
            label1.Text = "Tabla de Amortizacion";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 188);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Cuota Final:";
            // 
            // FormaAmortizacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 212);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCuotaFija);
            Controls.Add(dgvTablaAmortiCredito);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormaAmortizacion";
            Text = "VistaAmortizaion";
            FormClosed += VistaProcesosFinancieros_FormClosed;
            Load += FormaAmortizacion_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTablaAmortiCredito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvTablaAmortiCredito;
        private Label lblCuotaFija;
        private Label label1;
        private Label label2;
    }
}