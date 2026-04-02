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
            btnCompararEscenarios = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnIngresarDatos
            // 
            btnIngresarDatos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresarDatos.Location = new Point(105, 43);
            btnIngresarDatos.Name = "btnIngresarDatos";
            btnIngresarDatos.Size = new Size(179, 63);
            btnIngresarDatos.TabIndex = 0;
            btnIngresarDatos.Text = "Ingresar Datos";
            btnIngresarDatos.UseVisualStyleBackColor = true;
            // 
            // btnEscenariosGuardados
            // 
            btnEscenariosGuardados.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEscenariosGuardados.Location = new Point(105, 136);
            btnEscenariosGuardados.Name = "btnEscenariosGuardados";
            btnEscenariosGuardados.Size = new Size(305, 63);
            btnEscenariosGuardados.TabIndex = 0;
            btnEscenariosGuardados.Text = "Ver Escenarios Guardados";
            btnEscenariosGuardados.UseVisualStyleBackColor = true;
            // 
            // btnCompararEscenarios
            // 
            btnCompararEscenarios.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCompararEscenarios.Location = new Point(105, 231);
            btnCompararEscenarios.Name = "btnCompararEscenarios";
            btnCompararEscenarios.Size = new Size(262, 63);
            btnCompararEscenarios.TabIndex = 0;
            btnCompararEscenarios.Text = "Comparar Escenarios";
            btnCompararEscenarios.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(105, 329);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 63);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCompararEscenarios);
            Controls.Add(btnEscenariosGuardados);
            Controls.Add(btnIngresarDatos);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresarDatos;
        private Button btnEscenariosGuardados;
        private Button btnCompararEscenarios;
        private Button btnSalir;
    }
}