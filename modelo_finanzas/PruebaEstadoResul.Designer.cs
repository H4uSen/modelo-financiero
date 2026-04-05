namespace modelo_finanzas
{
    partial class PruebaEstadoResul
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
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(165, 82);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(143, 71);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "button1";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // PruebaEstadoResul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGenerar);
            Name = "PruebaEstadoResul";
            Text = "PruebaEstadoResul";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerar;
    }
}