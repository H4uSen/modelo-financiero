namespace Prueba1
{
    partial class EscenariosGuardados
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
            dgvEscenarios = new DataGridView();
            btnCompararEscenarios = new Button();
            tabControl2 = new TabControl();
            TcComparativoVPN = new TabPage();
            TcComparativoVentas = new TabPage();
            btnCargarEscenarios = new Button();
            btnEliminar = new Button();
            btnMenuPrincipal = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEscenarios).BeginInit();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEscenarios
            // 
            dgvEscenarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEscenarios.Location = new Point(35, 21);
            dgvEscenarios.Name = "dgvEscenarios";
            dgvEscenarios.RowHeadersWidth = 51;
            dgvEscenarios.Size = new Size(515, 190);
            dgvEscenarios.TabIndex = 0;
            // 
            // btnCompararEscenarios
            // 
            btnCompararEscenarios.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompararEscenarios.Location = new Point(581, 254);
            btnCompararEscenarios.Name = "btnCompararEscenarios";
            btnCompararEscenarios.Size = new Size(260, 75);
            btnCompararEscenarios.TabIndex = 1;
            btnCompararEscenarios.Text = "Comparar Escenarios Seleccionados";
            btnCompararEscenarios.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(TcComparativoVPN);
            tabControl2.Controls.Add(TcComparativoVentas);
            tabControl2.Location = new Point(41, 254);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(509, 197);
            tabControl2.TabIndex = 2;
            // 
            // TcComparativoVPN
            // 
            TcComparativoVPN.Location = new Point(4, 29);
            TcComparativoVPN.Name = "TcComparativoVPN";
            TcComparativoVPN.Padding = new Padding(3);
            TcComparativoVPN.Size = new Size(501, 164);
            TcComparativoVPN.TabIndex = 0;
            TcComparativoVPN.Text = "Comparativo VPN";
            TcComparativoVPN.UseVisualStyleBackColor = true;
            // 
            // TcComparativoVentas
            // 
            TcComparativoVentas.Location = new Point(4, 29);
            TcComparativoVentas.Name = "TcComparativoVentas";
            TcComparativoVentas.Padding = new Padding(3);
            TcComparativoVentas.Size = new Size(501, 164);
            TcComparativoVentas.TabIndex = 1;
            TcComparativoVentas.Text = "Comparativo Ventas";
            TcComparativoVentas.UseVisualStyleBackColor = true;
            // 
            // btnCargarEscenarios
            // 
            btnCargarEscenarios.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarEscenarios.Location = new Point(48, 503);
            btnCargarEscenarios.Name = "btnCargarEscenarios";
            btnCargarEscenarios.Size = new Size(206, 69);
            btnCargarEscenarios.TabIndex = 3;
            btnCargarEscenarios.Text = "Cargar Escenario";
            btnCargarEscenarios.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(499, 503);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(206, 69);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnMenuPrincipal
            // 
            btnMenuPrincipal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenuPrincipal.Location = new Point(267, 607);
            btnMenuPrincipal.Name = "btnMenuPrincipal";
            btnMenuPrincipal.Size = new Size(206, 69);
            btnMenuPrincipal.TabIndex = 3;
            btnMenuPrincipal.Text = "Menú Principal";
            btnMenuPrincipal.UseVisualStyleBackColor = true;
            // 
            // EscenariosGuardados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 739);
            Controls.Add(btnEliminar);
            Controls.Add(btnMenuPrincipal);
            Controls.Add(btnCargarEscenarios);
            Controls.Add(tabControl2);
            Controls.Add(btnCompararEscenarios);
            Controls.Add(dgvEscenarios);
            Name = "EscenariosGuardados";
            Text = "EscenariosGuardados";
            FormClosed += EscenariosGuardados_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvEscenarios).EndInit();
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEscenarios;
        private Button btnCompararEscenarios;
        private TabControl tabControl2;
        private TabPage TcComparativoVPN;
        private TabPage TcComparativoVentas;
        private Button btnCargarEscenarios;
        private Button btnEliminar;
        private Button btnMenuPrincipal;
    }
}