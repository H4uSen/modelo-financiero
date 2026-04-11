namespace modelo_finanzas
{
    partial class FormComparacionEscenarios
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
            cboEscenarios1 = new ComboBox();
            cboEscenarios2 = new ComboBox();
            dgvResumen1 = new DataGridView();
            dgvResumen2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvResumen1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen2).BeginInit();
            SuspendLayout();
            // 
            // cboEscenarios1
            // 
            cboEscenarios1.FormattingEnabled = true;
            cboEscenarios1.Location = new Point(63, 56);
            cboEscenarios1.Name = "cboEscenarios1";
            cboEscenarios1.Size = new Size(212, 23);
            cboEscenarios1.TabIndex = 0;
            cboEscenarios1.SelectedIndexChanged += cboEscenarios1_SelectedIndexChanged;
            cboEscenarios1.SelectedValueChanged += comboBox1_SelectedValueChanged;
            // 
            // cboEscenarios2
            // 
            cboEscenarios2.FormattingEnabled = true;
            cboEscenarios2.Location = new Point(439, 56);
            cboEscenarios2.Name = "cboEscenarios2";
            cboEscenarios2.Size = new Size(209, 23);
            cboEscenarios2.TabIndex = 1;
            cboEscenarios2.SelectedIndexChanged += cboEscenarios2_SelectedIndexChanged;
            // 
            // dgvResumen1
            // 
            dgvResumen1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen1.Location = new Point(24, 96);
            dgvResumen1.Name = "dgvResumen1";
            dgvResumen1.Size = new Size(291, 144);
            dgvResumen1.TabIndex = 2;
            // 
            // dgvResumen2
            // 
            dgvResumen2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumen2.Location = new Point(392, 96);
            dgvResumen2.Name = "dgvResumen2";
            dgvResumen2.Size = new Size(299, 144);
            dgvResumen2.TabIndex = 3;
            dgvResumen2.CellContentClick += dgvResumen2_CellContentClick;
            // 
            // FormComparacionEscenarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 270);
            Controls.Add(dgvResumen2);
            Controls.Add(dgvResumen1);
            Controls.Add(cboEscenarios2);
            Controls.Add(cboEscenarios1);
            Name = "FormComparacionEscenarios";
            Text = "FormComparacionEscenarios";
            ((System.ComponentModel.ISupportInitialize)dgvResumen1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumen2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cboEscenarios1;
        private ComboBox cboEscenarios2;
        private DataGridView dgvResumen1;
        private DataGridView dgvResumen2;
    }
}