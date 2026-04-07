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
            btnEscenariosGuardados = new Button();
            btnCargarEscenario = new Button();
            btnSalir = new Button();
            button1 = new Button();
            panel1 = new Panel();
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
            // btnEscenariosGuardados
            // 
            btnEscenariosGuardados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscenariosGuardados.Location = new Point(10, 184);
            btnEscenariosGuardados.Margin = new Padding(3, 2, 3, 2);
            btnEscenariosGuardados.Name = "btnEscenariosGuardados";
            btnEscenariosGuardados.Size = new Size(276, 47);
            btnEscenariosGuardados.TabIndex = 0;
            btnEscenariosGuardados.Text = "Resultado Escenario Actual";
            btnEscenariosGuardados.UseVisualStyleBackColor = true;
            btnEscenariosGuardados.Click += btnEscenariosGuardados_Click;
            // 
            // btnCargarEscenario
            // 
            btnCargarEscenario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarEscenario.Location = new Point(10, 83);
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
            btnSalir.Location = new Point(10, 236);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 47);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(10, 135);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(224, 44);
            button1.TabIndex = 1;
            button1.Text = "Amortizacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(321, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(409, 354);
            panel1.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 372);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnCargarEscenario);
            Controls.Add(btnEscenariosGuardados);
            Controls.Add(btnIngresarDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresarDatos;
        private Button btnEscenariosGuardados;
        private Button btnCargarEscenario;
        private Button btnSalir;
        private Button button1;
        private Panel panel1;
    }
}