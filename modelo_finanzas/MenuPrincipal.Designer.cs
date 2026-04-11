namespace Prueba1
{
    partial class MenuPrincipal
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
            btnIngresarDatos = new Button();
            btnCargarEscenario = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            label1 = new Label();
            btnTestConnection = new Button();
            btnComparar = new Button();
            SuspendLayout();
            // 
            // btnIngresarDatos
            // 
            btnIngresarDatos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresarDatos.Location = new Point(10, 32);
            btnIngresarDatos.Margin = new Padding(3, 2, 3, 2);
            btnIngresarDatos.Name = "btnIngresarDatos";
            btnIngresarDatos.Size = new Size(289, 47);
            btnIngresarDatos.TabIndex = 0;
            btnIngresarDatos.Text = "Ingresar Datos";
            btnIngresarDatos.UseVisualStyleBackColor = true;
            btnIngresarDatos.Click += btnIngresarDatos_Click;
            // 
            // btnCargarEscenario
            // 
            btnCargarEscenario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarEscenario.Location = new Point(10, 167);
            btnCargarEscenario.Margin = new Padding(3, 2, 3, 2);
            btnCargarEscenario.Name = "btnCargarEscenario";
            btnCargarEscenario.Size = new Size(289, 47);
            btnCargarEscenario.TabIndex = 0;
            btnCargarEscenario.Text = "Cargar escenario guardado";
            btnCargarEscenario.UseVisualStyleBackColor = true;
            btnCargarEscenario.Click += btnCompararEscenarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(12, 296);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(287, 47);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(321, 32);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 331);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(321, 5);
            label1.Name = "label1";
            label1.Size = new Size(210, 25);
            label1.TabIndex = 3;
            label1.Text = "Escenarios guardados:";
            // 
            // btnTestConnection
            // 
            btnTestConnection.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestConnection.Location = new Point(10, 236);
            btnTestConnection.Margin = new Padding(3, 2, 3, 2);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(289, 47);
            btnTestConnection.TabIndex = 4;
            btnTestConnection.Text = "Probar conexión";
            btnTestConnection.UseVisualStyleBackColor = true;
            btnTestConnection.Click += button1_Click_1;
            // 
            // btnComparar
            // 
            btnComparar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComparar.Location = new Point(10, 95);
            btnComparar.Margin = new Padding(3, 2, 3, 2);
            btnComparar.Name = "btnComparar";
            btnComparar.Size = new Size(289, 47);
            btnComparar.TabIndex = 5;
            btnComparar.Text = "Comparar escenarios";
            btnComparar.UseVisualStyleBackColor = true;
            btnComparar.Click += btnComparar_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 372);
            Controls.Add(btnComparar);
            Controls.Add(btnTestConnection);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(btnCargarEscenario);
            Controls.Add(btnIngresarDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresarDatos;
        private Button btnEscenariosGuardados;
        private Button btnCargarEscenario;
        private Button btnSalir;
        private Button btnTestConnection;
        private Panel panel1;
        private Button bntVariables;
        private Button button2;
        private Label label1;
        private Button btnComparar;
    }
}