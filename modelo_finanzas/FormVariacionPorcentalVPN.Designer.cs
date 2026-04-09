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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvVariacion = new DataGridView();
            btnVariacion = new Button();
            label1 = new Label();
            varMercado = new Label();
            label2 = new Label();
            varInfla = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVariacion).BeginInit();
            SuspendLayout();
            // 
            // dgvVariacion
            // 
            dgvVariacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVariacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvVariacion.DefaultCellStyle = dataGridViewCellStyle1;
            dgvVariacion.Location = new Point(12, 40);
            dgvVariacion.Name = "dgvVariacion";
            dgvVariacion.Size = new Size(583, 176);
            dgvVariacion.TabIndex = 0;
            // 
            // btnVariacion
            // 
            btnVariacion.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVariacion.Location = new Point(12, 228);
            btnVariacion.Name = "btnVariacion";
            btnVariacion.Size = new Size(160, 44);
            btnVariacion.TabIndex = 1;
            btnVariacion.Text = "Variación VPN";
            btnVariacion.UseVisualStyleBackColor = true;
            btnVariacion.Click += btnVariacion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 228);
            label1.Name = "label1";
            label1.Size = new Size(444, 15);
            label1.TabIndex = 2;
            label1.Text = "La Variación porcentual del VPN ante cambios en la participación en el mercado es:\r\n";
            // 
            // varMercado
            // 
            varMercado.AutoSize = true;
            varMercado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            varMercado.ForeColor = Color.Red;
            varMercado.Location = new Point(196, 250);
            varMercado.Name = "varMercado";
            varMercado.Size = new Size(13, 20);
            varMercado.TabIndex = 3;
            varMercado.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 289);
            label2.Name = "label2";
            label2.Size = new Size(343, 15);
            label2.TabIndex = 4;
            label2.Text = "La Variación porcentual del VPN ante cambios en la inflación es:";
            // 
            // varInfla
            // 
            varInfla.AutoSize = true;
            varInfla.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            varInfla.ForeColor = Color.Red;
            varInfla.Location = new Point(200, 315);
            varInfla.Name = "varInfla";
            varInfla.Size = new Size(13, 20);
            varInfla.TabIndex = 5;
            varInfla.Text = " ";
            // 
            // FormVariacionPorcentalVPN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 358);
            Controls.Add(varInfla);
            Controls.Add(label2);
            Controls.Add(varMercado);
            Controls.Add(label1);
            Controls.Add(btnVariacion);
            Controls.Add(dgvVariacion);
            Name = "FormVariacionPorcentalVPN";
            Text = "FormVariacionPorcentalVPN";
            Load += FormVariacionPorcentalVPN_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVariacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvVariacion;
        private Button btnVariacion;
        private Label label1;
        private Label varMercado;
        private Label label2;
        private Label varInfla;
    }
}