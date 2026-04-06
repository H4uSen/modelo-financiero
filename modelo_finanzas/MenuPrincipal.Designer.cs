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
            btnIngresarDatos.Location = new Point(12, 42);
            btnIngresarDatos.Name = "btnIngresarDatos";
            btnIngresarDatos.Size = new Size(330, 63);
            btnIngresarDatos.TabIndex = 0;
            btnIngresarDatos.Text = "Ingresar Datos";
            btnIngresarDatos.UseVisualStyleBackColor = true;
            btnIngresarDatos.Click += btnIngresarDatos_Click;
            // 
            // btnEscenariosGuardados
            // 
            btnEscenariosGuardados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscenariosGuardados.Location = new Point(12, 245);
            btnEscenariosGuardados.Name = "btnEscenariosGuardados";
            btnEscenariosGuardados.Size = new Size(315, 63);
            btnEscenariosGuardados.TabIndex = 0;
            btnEscenariosGuardados.Text = "Resultado Escenario Actual";
            btnEscenariosGuardados.UseVisualStyleBackColor = true;
            btnEscenariosGuardados.Click += btnEscenariosGuardados_Click;
            // 
            // btnCargarEscenario
            // 
            btnCargarEscenario.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargarEscenario.Location = new Point(12, 111);
            btnCargarEscenario.Name = "btnCargarEscenario";
            btnCargarEscenario.Size = new Size(330, 63);
            btnCargarEscenario.TabIndex = 0;
            btnCargarEscenario.Text = "Cargar escenario guardado";
            btnCargarEscenario.UseVisualStyleBackColor = true;
            btnCargarEscenario.Click += btnCompararEscenarios_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(12, 314);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 63);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 180);
            button1.Name = "button1";
            button1.Size = new Size(256, 59);
            button1.TabIndex = 1;
            button1.Text = "Procesos Financieros";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(367, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 472);
            panel1.TabIndex = 2;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 496);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnCargarEscenario);
            Controls.Add(btnEscenariosGuardados);
            Controls.Add(btnIngresarDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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