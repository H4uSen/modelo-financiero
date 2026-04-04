namespace modelo_finanzas
{
    partial class FormEntradaDatos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            gpbMercado = new GroupBox();
            txtObjeMer = new TextBox();
            txtManiComp = new TextBox();
            txtEncRealizadas = new TextBox();
            txtCrecimientoAnualMerc = new TextBox();
            txtTamanioMercado = new TextBox();
            btnTest = new Button();
            gpbPrecios = new GroupBox();
            txtInflaAnual = new TextBox();
            txtIPP = new TextBox();
            txtIncRealPrec = new TextBox();
            txtPrecioProducto = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label13 = new Label();
            gpbCostos = new GroupBox();
            txtGastOper = new TextBox();
            txtCapTrab = new TextBox();
            txtCostProdIni = new TextBox();
            label10 = new Label();
            label12 = new Label();
            label15 = new Label();
            gpbInversion = new GroupBox();
            txtTasaImpositiva = new TextBox();
            txtBetaSector = new TextBox();
            txtPlazoCredito = new TextBox();
            txtFinanCredito = new TextBox();
            txtPlazoDep = new TextBox();
            txtGradFlujos = new TextBox();
            txtPrimRiesgMerc = new TextBox();
            txtTasaLibRiesgo = new TextBox();
            txtRecupSobreCosto = new TextBox();
            txtInvEquiXPart = new TextBox();
            label24 = new Label();
            label23 = new Label();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label14 = new Label();
            label16 = new Label();
            label17 = new Label();
            label25 = new Label();
            label3 = new Label();
            txtNombreEscenario = new TextBox();
            txtFechaCreacion = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel2 = new Panel();
            gpbMercado.SuspendLayout();
            gpbPrecios.SuspendLayout();
            gpbCostos.SuspendLayout();
            gpbInversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(154, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese los siguientes datos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(135, 17);
            label2.TabIndex = 1;
            label2.Text = "Tamaño del mercado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 66);
            label4.Name = "label4";
            label4.Size = new Size(213, 19);
            label4.TabIndex = 3;
            label4.Text = "% crecimiento anual del mercado:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 116);
            label5.Name = "label5";
            label5.Size = new Size(135, 19);
            label5.TabIndex = 4;
            label5.Text = "Encuestas realizadas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 68);
            label6.Name = "label6";
            label6.Size = new Size(148, 19);
            label6.TabIndex = 5;
            label6.Text = "Manifestaron comprar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(252, 24);
            label7.Name = "label7";
            label7.Size = new Size(152, 19);
            label7.TabIndex = 6;
            label7.Text = "% objetivo de mercado:";
            // 
            // gpbMercado
            // 
            gpbMercado.Controls.Add(txtObjeMer);
            gpbMercado.Controls.Add(txtManiComp);
            gpbMercado.Controls.Add(txtEncRealizadas);
            gpbMercado.Controls.Add(txtCrecimientoAnualMerc);
            gpbMercado.Controls.Add(txtTamanioMercado);
            gpbMercado.Controls.Add(label2);
            gpbMercado.Controls.Add(label7);
            gpbMercado.Controls.Add(label4);
            gpbMercado.Controls.Add(label6);
            gpbMercado.Controls.Add(label5);
            gpbMercado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbMercado.ForeColor = SystemColors.ActiveCaptionText;
            gpbMercado.Location = new Point(10, 24);
            gpbMercado.Margin = new Padding(3, 2, 3, 2);
            gpbMercado.Name = "gpbMercado";
            gpbMercado.Padding = new Padding(3, 2, 3, 2);
            gpbMercado.Size = new Size(470, 184);
            gpbMercado.TabIndex = 8;
            gpbMercado.TabStop = false;
            gpbMercado.Text = "Mercado y demanda";
            // 
            // txtObjeMer
            // 
            txtObjeMer.Location = new Point(252, 40);
            txtObjeMer.Margin = new Padding(3, 2, 3, 2);
            txtObjeMer.Name = "txtObjeMer";
            txtObjeMer.PlaceholderText = "ej. 4%";
            txtObjeMer.Size = new Size(187, 26);
            txtObjeMer.TabIndex = 15;
            // 
            // txtManiComp
            // 
            txtManiComp.Location = new Point(251, 89);
            txtManiComp.Margin = new Padding(3, 2, 3, 2);
            txtManiComp.Name = "txtManiComp";
            txtManiComp.PlaceholderText = "ej. 9";
            txtManiComp.Size = new Size(187, 26);
            txtManiComp.TabIndex = 14;
            // 
            // txtEncRealizadas
            // 
            txtEncRealizadas.Location = new Point(6, 134);
            txtEncRealizadas.Name = "txtEncRealizadas";
            txtEncRealizadas.PlaceholderText = "ej. 400";
            txtEncRealizadas.Size = new Size(213, 26);
            txtEncRealizadas.TabIndex = 13;
            // 
            // txtCrecimientoAnualMerc
            // 
            txtCrecimientoAnualMerc.Location = new Point(6, 88);
            txtCrecimientoAnualMerc.Name = "txtCrecimientoAnualMerc";
            txtCrecimientoAnualMerc.PlaceholderText = "ej. 2.0%";
            txtCrecimientoAnualMerc.Size = new Size(213, 26);
            txtCrecimientoAnualMerc.TabIndex = 12;
            // 
            // txtTamanioMercado
            // 
            txtTamanioMercado.Location = new Point(6, 40);
            txtTamanioMercado.Name = "txtTamanioMercado";
            txtTamanioMercado.PlaceholderText = "ej. 800,000";
            txtTamanioMercado.Size = new Size(213, 26);
            txtTamanioMercado.TabIndex = 11;
            txtTamanioMercado.KeyPress += txtTamanioMercado_KeyPress;
            // 
            // btnTest
            // 
            btnTest.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTest.Location = new Point(9, 498);
            btnTest.Margin = new Padding(3, 2, 3, 2);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(128, 33);
            btnTest.TabIndex = 9;
            btnTest.Text = "test connection";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += button1_Click;
            // 
            // gpbPrecios
            // 
            gpbPrecios.AutoSize = true;
            gpbPrecios.Controls.Add(txtInflaAnual);
            gpbPrecios.Controls.Add(txtIPP);
            gpbPrecios.Controls.Add(txtIncRealPrec);
            gpbPrecios.Controls.Add(txtPrecioProducto);
            gpbPrecios.Controls.Add(label8);
            gpbPrecios.Controls.Add(label9);
            gpbPrecios.Controls.Add(label11);
            gpbPrecios.Controls.Add(label13);
            gpbPrecios.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbPrecios.ForeColor = SystemColors.ActiveCaptionText;
            gpbPrecios.Location = new Point(486, 24);
            gpbPrecios.Margin = new Padding(3, 2, 3, 2);
            gpbPrecios.Name = "gpbPrecios";
            gpbPrecios.Padding = new Padding(3, 2, 3, 2);
            gpbPrecios.Size = new Size(506, 194);
            gpbPrecios.TabIndex = 9;
            gpbPrecios.TabStop = false;
            gpbPrecios.Text = "Precios e inflación";
            // 
            // txtInflaAnual
            // 
            txtInflaAnual.Location = new Point(299, 45);
            txtInflaAnual.Margin = new Padding(3, 2, 3, 2);
            txtInflaAnual.Name = "txtInflaAnual";
            txtInflaAnual.PlaceholderText = "ej. 3.5%";
            txtInflaAnual.Size = new Size(187, 26);
            txtInflaAnual.TabIndex = 18;
            // 
            // txtIPP
            // 
            txtIPP.Location = new Point(5, 145);
            txtIPP.Margin = new Padding(3, 2, 3, 2);
            txtIPP.Name = "txtIPP";
            txtIPP.PlaceholderText = "ej. 1%";
            txtIPP.Size = new Size(187, 26);
            txtIPP.TabIndex = 18;
            // 
            // txtIncRealPrec
            // 
            txtIncRealPrec.Location = new Point(5, 96);
            txtIncRealPrec.Margin = new Padding(3, 2, 3, 2);
            txtIncRealPrec.Name = "txtIncRealPrec";
            txtIncRealPrec.PlaceholderText = "ej. 0.8%";
            txtIncRealPrec.Size = new Size(187, 26);
            txtIncRealPrec.TabIndex = 18;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(6, 41);
            txtPrecioProducto.Margin = new Padding(3, 2, 3, 2);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.PlaceholderText = "ej. 7200";
            txtPrecioProducto.Size = new Size(187, 26);
            txtPrecioProducto.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 22);
            label8.Name = "label8";
            label8.Size = new Size(127, 17);
            label8.TabIndex = 1;
            label8.Text = "Precio del producto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(299, 24);
            label9.Name = "label9";
            label9.Size = new Size(193, 19);
            label9.TabIndex = 2;
            label9.Text = "% de inflación anual esperado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 75);
            label11.Name = "label11";
            label11.Size = new Size(341, 19);
            label11.TabIndex = 3;
            label11.Text = "% de incremento real al precio por encima de inflación:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 124);
            label13.Name = "label13";
            label13.Size = new Size(202, 19);
            label13.TabIndex = 4;
            label13.Text = "% de IPP adicional a la inflación:";
            // 
            // gpbCostos
            // 
            gpbCostos.AutoSize = true;
            gpbCostos.Controls.Add(txtGastOper);
            gpbCostos.Controls.Add(txtCapTrab);
            gpbCostos.Controls.Add(txtCostProdIni);
            gpbCostos.Controls.Add(label10);
            gpbCostos.Controls.Add(label12);
            gpbCostos.Controls.Add(label15);
            gpbCostos.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbCostos.ForeColor = SystemColors.ActiveCaptionText;
            gpbCostos.Location = new Point(9, 216);
            gpbCostos.Margin = new Padding(3, 2, 3, 2);
            gpbCostos.Name = "gpbCostos";
            gpbCostos.Padding = new Padding(3, 2, 3, 2);
            gpbCostos.Size = new Size(476, 188);
            gpbCostos.TabIndex = 9;
            gpbCostos.TabStop = false;
            gpbCostos.Text = "Costos";
            // 
            // txtGastOper
            // 
            txtGastOper.Location = new Point(234, 41);
            txtGastOper.Margin = new Padding(3, 2, 3, 2);
            txtGastOper.Name = "txtGastOper";
            txtGastOper.PlaceholderText = "ej. 25%";
            txtGastOper.Size = new Size(187, 26);
            txtGastOper.TabIndex = 17;
            // 
            // txtCapTrab
            // 
            txtCapTrab.Location = new Point(6, 87);
            txtCapTrab.Margin = new Padding(3, 2, 3, 2);
            txtCapTrab.Name = "txtCapTrab";
            txtCapTrab.PlaceholderText = "ej. 9%";
            txtCapTrab.Size = new Size(187, 26);
            txtCapTrab.TabIndex = 16;
            // 
            // txtCostProdIni
            // 
            txtCostProdIni.Location = new Point(6, 41);
            txtCostProdIni.Margin = new Padding(3, 2, 3, 2);
            txtCostProdIni.Name = "txtCostProdIni";
            txtCostProdIni.PlaceholderText = "ej. 3500";
            txtCostProdIni.Size = new Size(187, 26);
            txtCostProdIni.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 22);
            label10.Name = "label10";
            label10.Size = new Size(170, 17);
            label10.TabIndex = 1;
            label10.Text = "Costo de producción inicial:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(234, 20);
            label12.Name = "label12";
            label12.Size = new Size(236, 19);
            label12.TabIndex = 2;
            label12.Text = "% de gastos operativos sobre ventas:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 69);
            label15.Name = "label15";
            label15.Size = new Size(233, 19);
            label15.TabIndex = 3;
            label15.Text = "% de capital de trabajo sobre ventas:";
            // 
            // gpbInversion
            // 
            gpbInversion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            gpbInversion.AutoSize = true;
            gpbInversion.Controls.Add(txtTasaImpositiva);
            gpbInversion.Controls.Add(txtBetaSector);
            gpbInversion.Controls.Add(txtPlazoCredito);
            gpbInversion.Controls.Add(txtFinanCredito);
            gpbInversion.Controls.Add(txtPlazoDep);
            gpbInversion.Controls.Add(txtGradFlujos);
            gpbInversion.Controls.Add(txtPrimRiesgMerc);
            gpbInversion.Controls.Add(txtTasaLibRiesgo);
            gpbInversion.Controls.Add(txtRecupSobreCosto);
            gpbInversion.Controls.Add(txtInvEquiXPart);
            gpbInversion.Controls.Add(label24);
            gpbInversion.Controls.Add(label23);
            gpbInversion.Controls.Add(label22);
            gpbInversion.Controls.Add(label21);
            gpbInversion.Controls.Add(label20);
            gpbInversion.Controls.Add(label19);
            gpbInversion.Controls.Add(label18);
            gpbInversion.Controls.Add(label14);
            gpbInversion.Controls.Add(label16);
            gpbInversion.Controls.Add(label17);
            gpbInversion.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbInversion.ForeColor = SystemColors.ActiveCaptionText;
            gpbInversion.Location = new Point(492, 216);
            gpbInversion.Margin = new Padding(3, 2, 3, 2);
            gpbInversion.Name = "gpbInversion";
            gpbInversion.Padding = new Padding(3, 2, 3, 2);
            gpbInversion.Size = new Size(500, 315);
            gpbInversion.TabIndex = 10;
            gpbInversion.TabStop = false;
            gpbInversion.Text = "Inversión, financiamiento y otros parámetros";
            // 
            // txtTasaImpositiva
            // 
            txtTasaImpositiva.Location = new Point(293, 229);
            txtTasaImpositiva.Margin = new Padding(3, 2, 3, 2);
            txtTasaImpositiva.Name = "txtTasaImpositiva";
            txtTasaImpositiva.PlaceholderText = "ej. 34%";
            txtTasaImpositiva.Size = new Size(187, 26);
            txtTasaImpositiva.TabIndex = 27;
            // 
            // txtBetaSector
            // 
            txtBetaSector.Location = new Point(293, 179);
            txtBetaSector.Margin = new Padding(3, 2, 3, 2);
            txtBetaSector.Name = "txtBetaSector";
            txtBetaSector.PlaceholderText = "ej. 0.8";
            txtBetaSector.Size = new Size(187, 26);
            txtBetaSector.TabIndex = 26;
            // 
            // txtPlazoCredito
            // 
            txtPlazoCredito.Location = new Point(293, 130);
            txtPlazoCredito.Margin = new Padding(3, 2, 3, 2);
            txtPlazoCredito.Name = "txtPlazoCredito";
            txtPlazoCredito.PlaceholderText = "ej. 5 años";
            txtPlazoCredito.Size = new Size(187, 26);
            txtPlazoCredito.TabIndex = 25;
            // 
            // txtFinanCredito
            // 
            txtFinanCredito.Location = new Point(293, 87);
            txtFinanCredito.Margin = new Padding(3, 2, 3, 2);
            txtFinanCredito.Name = "txtFinanCredito";
            txtFinanCredito.PlaceholderText = "ej. 40%";
            txtFinanCredito.Size = new Size(187, 26);
            txtFinanCredito.TabIndex = 24;
            // 
            // txtPlazoDep
            // 
            txtPlazoDep.Location = new Point(293, 41);
            txtPlazoDep.Margin = new Padding(3, 2, 3, 2);
            txtPlazoDep.Name = "txtPlazoDep";
            txtPlazoDep.PlaceholderText = "ej. 8 años";
            txtPlazoDep.Size = new Size(187, 26);
            txtPlazoDep.TabIndex = 23;
            // 
            // txtGradFlujos
            // 
            txtGradFlujos.Location = new Point(6, 229);
            txtGradFlujos.Margin = new Padding(3, 2, 3, 2);
            txtGradFlujos.Name = "txtGradFlujos";
            txtGradFlujos.PlaceholderText = "ej. 5%";
            txtGradFlujos.Size = new Size(187, 26);
            txtGradFlujos.TabIndex = 22;
            // 
            // txtPrimRiesgMerc
            // 
            txtPrimRiesgMerc.Location = new Point(6, 179);
            txtPrimRiesgMerc.Margin = new Padding(3, 2, 3, 2);
            txtPrimRiesgMerc.Name = "txtPrimRiesgMerc";
            txtPrimRiesgMerc.PlaceholderText = "ej. 8.6%";
            txtPrimRiesgMerc.Size = new Size(187, 26);
            txtPrimRiesgMerc.TabIndex = 21;
            // 
            // txtTasaLibRiesgo
            // 
            txtTasaLibRiesgo.Location = new Point(6, 134);
            txtTasaLibRiesgo.Margin = new Padding(3, 2, 3, 2);
            txtTasaLibRiesgo.Name = "txtTasaLibRiesgo";
            txtTasaLibRiesgo.PlaceholderText = "ej. 11%";
            txtTasaLibRiesgo.Size = new Size(187, 26);
            txtTasaLibRiesgo.TabIndex = 20;
            // 
            // txtRecupSobreCosto
            // 
            txtRecupSobreCosto.Location = new Point(6, 87);
            txtRecupSobreCosto.Margin = new Padding(3, 2, 3, 2);
            txtRecupSobreCosto.Name = "txtRecupSobreCosto";
            txtRecupSobreCosto.PlaceholderText = "ej. 1%";
            txtRecupSobreCosto.Size = new Size(187, 26);
            txtRecupSobreCosto.TabIndex = 19;
            // 
            // txtInvEquiXPart
            // 
            txtInvEquiXPart.Location = new Point(6, 41);
            txtInvEquiXPart.Margin = new Padding(3, 2, 3, 2);
            txtInvEquiXPart.Name = "txtInvEquiXPart";
            txtInvEquiXPart.PlaceholderText = "ej. 55000000";
            txtInvEquiXPart.Size = new Size(187, 26);
            txtInvEquiXPart.TabIndex = 19;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(293, 207);
            label24.Name = "label24";
            label24.Size = new Size(137, 19);
            label24.TabIndex = 10;
            label24.Text = "% de tasa impositiva:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 207);
            label23.Name = "label23";
            label23.Size = new Size(180, 19);
            label23.TabIndex = 9;
            label23.Text = "% de gradiente de los flujos:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 160);
            label22.Name = "label22";
            label22.Size = new Size(201, 19);
            label22.TabIndex = 8;
            label22.Text = "% prima de riesgo del mercado:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(293, 156);
            label21.Name = "label21";
            label21.Size = new Size(102, 19);
            label21.TabIndex = 7;
            label21.Text = "Beta del sector:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(6, 113);
            label20.Name = "label20";
            label20.Size = new Size(161, 19);
            label20.TabIndex = 6;
            label20.Text = "% de tasa libre de riesgo:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(293, 109);
            label19.Name = "label19";
            label19.Size = new Size(112, 19);
            label19.TabIndex = 5;
            label19.Text = "Plazo del crédito:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(293, 69);
            label18.Name = "label18";
            label18.Size = new Size(161, 19);
            label18.TabIndex = 4;
            label18.Text = "% financiado con crédito:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(6, 21);
            label14.Name = "label14";
            label14.Size = new Size(280, 17);
            label14.TabIndex = 1;
            label14.Text = "Inversión en equipos X punto de participación:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(293, 20);
            label16.Name = "label16";
            label16.Size = new Size(143, 19);
            label16.TabIndex = 2;
            label16.Text = "Plazo de depreciación:";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 66);
            label17.Name = "label17";
            label17.Size = new Size(275, 19);
            label17.TabIndex = 3;
            label17.Text = "% de recuperaciones sobre costo de ventas:";
            // 
            // label25
            // 
            label25.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(10, 439);
            label25.Name = "label25";
            label25.Size = new Size(159, 20);
            label25.TabIndex = 18;
            label25.Text = "Nombre del escenario:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(244, 437);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 19;
            label3.Text = "Fecha de creación:";
            // 
            // txtNombreEscenario
            // 
            txtNombreEscenario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombreEscenario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEscenario.Location = new Point(9, 459);
            txtNombreEscenario.Margin = new Padding(3, 2, 3, 2);
            txtNombreEscenario.Name = "txtNombreEscenario";
            txtNombreEscenario.PlaceholderText = "ej. 'Escen: 2026-03-14'";
            txtNombreEscenario.Size = new Size(210, 27);
            txtNombreEscenario.TabIndex = 16;
            // 
            // txtFechaCreacion
            // 
            txtFechaCreacion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtFechaCreacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaCreacion.Location = new Point(241, 459);
            txtFechaCreacion.Margin = new Padding(3, 2, 3, 2);
            txtFechaCreacion.Name = "txtFechaCreacion";
            txtFechaCreacion.Size = new Size(207, 27);
            txtFechaCreacion.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelar.Location = new Point(168, 498);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 33);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.Location = new Point(321, 498);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(128, 33);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar y Calcular";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Location = new Point(998, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(278, 496);
            panel2.TabIndex = 24;
            // 
            // FormEntradaDatos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1277, 542);
            Controls.Add(panel2);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtFechaCreacion);
            Controls.Add(txtNombreEscenario);
            Controls.Add(label3);
            Controls.Add(gpbInversion);
            Controls.Add(label25);
            Controls.Add(gpbCostos);
            Controls.Add(gpbPrecios);
            Controls.Add(btnTest);
            Controls.Add(gpbMercado);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1293, 581);
            Name = "FormEntradaDatos";
            Text = "Modelo Financiero";
            WindowState = FormWindowState.Maximized;
            gpbMercado.ResumeLayout(false);
            gpbMercado.PerformLayout();
            gpbPrecios.ResumeLayout(false);
            gpbPrecios.PerformLayout();
            gpbCostos.ResumeLayout(false);
            gpbCostos.PerformLayout();
            gpbInversion.ResumeLayout(false);
            gpbInversion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox gpbMercado;
        private Button btnTest;
        private GroupBox gpbPrecios;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label13;
        private GroupBox gpbCostos;
        private Label label10;
        private Label label12;
        private Label label15;
        private GroupBox gpbInversion;
        private Label label14;
        private Label label16;
        private Label label17;
        private Label label19;
        private Label label18;
        private Label label24;
        private Label label23;
        private Label label22;
        private Label label21;
        private Label label20;
        private TextBox txtTamanioMercado;
        private TextBox txtCrecimientoAnualMerc;
        private TextBox txtEncRealizadas;
        private TextBox txtObjeMer;
        private TextBox txtManiComp;
        private TextBox txtGastOper;
        private TextBox txtCapTrab;
        private TextBox txtCostProdIni;
        private TextBox txtInflaAnual;
        private TextBox txtIPP;
        private TextBox txtIncRealPrec;
        private TextBox txtPrecioProducto;
        private TextBox txtTasaImpositiva;
        private TextBox txtBetaSector;
        private TextBox txtPlazoCredito;
        private TextBox txtFinanCredito;
        private TextBox txtPlazoDep;
        private TextBox txtGradFlujos;
        private TextBox txtPrimRiesgMerc;
        private TextBox txtTasaLibRiesgo;
        private TextBox txtRecupSobreCosto;
        private TextBox txtInvEquiXPart;
        private Label label25;
        private TextBox txtNombreEscenario;
        private TextBox txtFechaCreacion;
        private Button btnCancelar;
        private Button btnGuardar;
        private ErrorProvider errorProvider1;
        private Panel panel2;
    }
}
