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
            btnCalcular = new Button();
            errorProvider1 = new ErrorProvider(components);
            panel2 = new Panel();
            btnGuardar = new Button();
            btnSalidas = new Button();
            btnAnalisisSensiVPN = new Button();
            btnAnalisisVPN = new Button();
            pnlFlujoResultados = new Panel();
            button2 = new Button();
            gpbMercado.SuspendLayout();
            gpbPrecios.SuspendLayout();
            gpbCostos.SuspendLayout();
            gpbInversion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 1;
            label2.Text = "Tamaño del mercado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 70);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(187, 15);
            label4.TabIndex = 3;
            label4.Text = "% crecimiento anual del mercado:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 124);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 4;
            label5.Text = "Encuestas realizadas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 72);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(128, 15);
            label6.TabIndex = 5;
            label6.Text = "Manifestaron comprar:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 25);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
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
            gpbMercado.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbMercado.ForeColor = SystemColors.ActiveCaptionText;
            gpbMercado.Location = new Point(9, 8);
            gpbMercado.Margin = new Padding(2);
            gpbMercado.Name = "gpbMercado";
            gpbMercado.Padding = new Padding(2);
            gpbMercado.Size = new Size(384, 179);
            gpbMercado.TabIndex = 8;
            gpbMercado.TabStop = false;
            gpbMercado.Text = "Mercado y demanda";
            // 
            // txtObjeMer
            // 
            txtObjeMer.Location = new Point(213, 41);
            txtObjeMer.Margin = new Padding(2);
            txtObjeMer.Name = "txtObjeMer";
            txtObjeMer.PlaceholderText = "ej. 4%";
            txtObjeMer.Size = new Size(157, 23);
            txtObjeMer.TabIndex = 15;
            // 
            // txtManiComp
            // 
            txtManiComp.Location = new Point(213, 94);
            txtManiComp.Margin = new Padding(2);
            txtManiComp.Name = "txtManiComp";
            txtManiComp.PlaceholderText = "ej. 9";
            txtManiComp.Size = new Size(158, 23);
            txtManiComp.TabIndex = 14;
            // 
            // txtEncRealizadas
            // 
            txtEncRealizadas.Location = new Point(6, 143);
            txtEncRealizadas.Margin = new Padding(2, 3, 2, 3);
            txtEncRealizadas.Name = "txtEncRealizadas";
            txtEncRealizadas.PlaceholderText = "ej. 400";
            txtEncRealizadas.Size = new Size(195, 23);
            txtEncRealizadas.TabIndex = 13;
            // 
            // txtCrecimientoAnualMerc
            // 
            txtCrecimientoAnualMerc.Location = new Point(6, 94);
            txtCrecimientoAnualMerc.Margin = new Padding(2, 3, 2, 3);
            txtCrecimientoAnualMerc.Name = "txtCrecimientoAnualMerc";
            txtCrecimientoAnualMerc.PlaceholderText = "ej. 2.0%";
            txtCrecimientoAnualMerc.Size = new Size(195, 23);
            txtCrecimientoAnualMerc.TabIndex = 12;
            // 
            // txtTamanioMercado
            // 
            txtTamanioMercado.Location = new Point(6, 42);
            txtTamanioMercado.Margin = new Padding(2, 3, 2, 3);
            txtTamanioMercado.Name = "txtTamanioMercado";
            txtTamanioMercado.PlaceholderText = "ej. 800,000";
            txtTamanioMercado.Size = new Size(195, 23);
            txtTamanioMercado.TabIndex = 11;
            txtTamanioMercado.KeyPress += txtTamanioMercado_KeyPress;
            // 
            // btnTest
            // 
            btnTest.Location = new Point(6, 691);
            btnTest.Margin = new Padding(2);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(92, 44);
            btnTest.TabIndex = 9;
            btnTest.Text = "test connection";
            btnTest.UseVisualStyleBackColor = false;
            btnTest.Click += button1_Click;
            // 
            // gpbPrecios
            // 
            gpbPrecios.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gpbPrecios.Controls.Add(txtInflaAnual);
            gpbPrecios.Controls.Add(txtIPP);
            gpbPrecios.Controls.Add(txtIncRealPrec);
            gpbPrecios.Controls.Add(txtPrecioProducto);
            gpbPrecios.Controls.Add(label8);
            gpbPrecios.Controls.Add(label9);
            gpbPrecios.Controls.Add(label11);
            gpbPrecios.Controls.Add(label13);
            gpbPrecios.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbPrecios.ForeColor = SystemColors.ActiveCaptionText;
            gpbPrecios.Location = new Point(8, 194);
            gpbPrecios.Margin = new Padding(2);
            gpbPrecios.Name = "gpbPrecios";
            gpbPrecios.Padding = new Padding(2);
            gpbPrecios.Size = new Size(385, 153);
            gpbPrecios.TabIndex = 9;
            gpbPrecios.TabStop = false;
            gpbPrecios.Text = "Precios e inflación";
            // 
            // txtInflaAnual
            // 
            txtInflaAnual.Location = new Point(200, 43);
            txtInflaAnual.Margin = new Padding(2);
            txtInflaAnual.Name = "txtInflaAnual";
            txtInflaAnual.PlaceholderText = "ej. 3.5%";
            txtInflaAnual.Size = new Size(171, 23);
            txtInflaAnual.TabIndex = 18;
            // 
            // txtIPP
            // 
            txtIPP.Location = new Point(201, 113);
            txtIPP.Margin = new Padding(2);
            txtIPP.Name = "txtIPP";
            txtIPP.PlaceholderText = "ej. 1%";
            txtIPP.Size = new Size(171, 23);
            txtIPP.TabIndex = 18;
            // 
            // txtIncRealPrec
            // 
            txtIncRealPrec.Location = new Point(5, 114);
            txtIncRealPrec.Margin = new Padding(2);
            txtIncRealPrec.Name = "txtIncRealPrec";
            txtIncRealPrec.PlaceholderText = "ej. 0.8%";
            txtIncRealPrec.Size = new Size(171, 23);
            txtIncRealPrec.TabIndex = 18;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(6, 44);
            txtPrecioProducto.Margin = new Padding(2);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.PlaceholderText = "ej. 7200";
            txtPrecioProducto.Size = new Size(171, 23);
            txtPrecioProducto.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(6, 23);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 1;
            label8.Text = "Precio del producto:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(200, 25);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(168, 15);
            label9.TabIndex = 2;
            label9.Text = "% de inflación anual esperado:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 80);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(191, 30);
            label11.TabIndex = 3;
            label11.Text = "% de incremento real al precio por \r\nencima de inflación:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(201, 95);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(177, 15);
            label13.TabIndex = 4;
            label13.Text = "% de IPP adicional a la inflación:";
            // 
            // gpbCostos
            // 
            gpbCostos.Controls.Add(txtGastOper);
            gpbCostos.Controls.Add(txtCapTrab);
            gpbCostos.Controls.Add(txtCostProdIni);
            gpbCostos.Controls.Add(label10);
            gpbCostos.Controls.Add(label12);
            gpbCostos.Controls.Add(label15);
            gpbCostos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbCostos.ForeColor = SystemColors.ActiveCaptionText;
            gpbCostos.Location = new Point(397, 11);
            gpbCostos.Margin = new Padding(2);
            gpbCostos.Name = "gpbCostos";
            gpbCostos.Padding = new Padding(2);
            gpbCostos.Size = new Size(421, 131);
            gpbCostos.TabIndex = 9;
            gpbCostos.TabStop = false;
            gpbCostos.Text = "Costos";
            // 
            // txtGastOper
            // 
            txtGastOper.Location = new Point(214, 44);
            txtGastOper.Margin = new Padding(2);
            txtGastOper.Name = "txtGastOper";
            txtGastOper.PlaceholderText = "ej. 25%";
            txtGastOper.Size = new Size(171, 23);
            txtGastOper.TabIndex = 17;
            // 
            // txtCapTrab
            // 
            txtCapTrab.Location = new Point(6, 93);
            txtCapTrab.Margin = new Padding(2);
            txtCapTrab.Name = "txtCapTrab";
            txtCapTrab.PlaceholderText = "ej. 9%";
            txtCapTrab.Size = new Size(171, 23);
            txtCapTrab.TabIndex = 16;
            // 
            // txtCostProdIni
            // 
            txtCostProdIni.Location = new Point(6, 44);
            txtCostProdIni.Margin = new Padding(2);
            txtCostProdIni.Name = "txtCostProdIni";
            txtCostProdIni.PlaceholderText = "ej. 3500";
            txtCostProdIni.Size = new Size(171, 23);
            txtCostProdIni.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(6, 23);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(155, 15);
            label10.TabIndex = 1;
            label10.Text = "Costo de producción inicial:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(214, 22);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(200, 15);
            label12.TabIndex = 2;
            label12.Text = "% de gastos operativos sobre ventas:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 74);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(199, 15);
            label15.TabIndex = 3;
            label15.Text = "% de capital de trabajo sobre ventas:";
            // 
            // gpbInversion
            // 
            gpbInversion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
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
            gpbInversion.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gpbInversion.ForeColor = SystemColors.ActiveCaptionText;
            gpbInversion.Location = new Point(8, 351);
            gpbInversion.Margin = new Padding(2);
            gpbInversion.Name = "gpbInversion";
            gpbInversion.Padding = new Padding(2);
            gpbInversion.Size = new Size(385, 273);
            gpbInversion.TabIndex = 10;
            gpbInversion.TabStop = false;
            gpbInversion.Text = "Inversión, financiamiento y otros parámetros";
            // 
            // txtTasaImpositiva
            // 
            txtTasaImpositiva.Location = new Point(201, 241);
            txtTasaImpositiva.Margin = new Padding(2);
            txtTasaImpositiva.Name = "txtTasaImpositiva";
            txtTasaImpositiva.PlaceholderText = "ej. 34%";
            txtTasaImpositiva.Size = new Size(171, 23);
            txtTasaImpositiva.TabIndex = 27;
            // 
            // txtBetaSector
            // 
            txtBetaSector.Location = new Point(201, 198);
            txtBetaSector.Margin = new Padding(2);
            txtBetaSector.Name = "txtBetaSector";
            txtBetaSector.PlaceholderText = "ej. 0.8";
            txtBetaSector.Size = new Size(171, 23);
            txtBetaSector.TabIndex = 26;
            // 
            // txtPlazoCredito
            // 
            txtPlazoCredito.Location = new Point(201, 154);
            txtPlazoCredito.Margin = new Padding(2);
            txtPlazoCredito.Name = "txtPlazoCredito";
            txtPlazoCredito.PlaceholderText = "ej. 5 años";
            txtPlazoCredito.Size = new Size(171, 23);
            txtPlazoCredito.TabIndex = 25;
            // 
            // txtFinanCredito
            // 
            txtFinanCredito.Location = new Point(201, 111);
            txtFinanCredito.Margin = new Padding(2);
            txtFinanCredito.Name = "txtFinanCredito";
            txtFinanCredito.PlaceholderText = "ej. 40%";
            txtFinanCredito.Size = new Size(171, 23);
            txtFinanCredito.TabIndex = 24;
            // 
            // txtPlazoDep
            // 
            txtPlazoDep.Location = new Point(201, 53);
            txtPlazoDep.Margin = new Padding(2);
            txtPlazoDep.Name = "txtPlazoDep";
            txtPlazoDep.PlaceholderText = "ej. 8 años";
            txtPlazoDep.Size = new Size(171, 23);
            txtPlazoDep.TabIndex = 23;
            // 
            // txtGradFlujos
            // 
            txtGradFlujos.Location = new Point(7, 241);
            txtGradFlujos.Margin = new Padding(2);
            txtGradFlujos.Name = "txtGradFlujos";
            txtGradFlujos.PlaceholderText = "ej. 5%";
            txtGradFlujos.Size = new Size(171, 23);
            txtGradFlujos.TabIndex = 22;
            // 
            // txtPrimRiesgMerc
            // 
            txtPrimRiesgMerc.Location = new Point(6, 198);
            txtPrimRiesgMerc.Margin = new Padding(2);
            txtPrimRiesgMerc.Name = "txtPrimRiesgMerc";
            txtPrimRiesgMerc.PlaceholderText = "ej. 8.6%";
            txtPrimRiesgMerc.Size = new Size(171, 23);
            txtPrimRiesgMerc.TabIndex = 21;
            // 
            // txtTasaLibRiesgo
            // 
            txtTasaLibRiesgo.Location = new Point(5, 154);
            txtTasaLibRiesgo.Margin = new Padding(2);
            txtTasaLibRiesgo.Name = "txtTasaLibRiesgo";
            txtTasaLibRiesgo.PlaceholderText = "ej. 11%";
            txtTasaLibRiesgo.Size = new Size(171, 23);
            txtTasaLibRiesgo.TabIndex = 20;
            // 
            // txtRecupSobreCosto
            // 
            txtRecupSobreCosto.Location = new Point(4, 111);
            txtRecupSobreCosto.Margin = new Padding(2);
            txtRecupSobreCosto.Name = "txtRecupSobreCosto";
            txtRecupSobreCosto.PlaceholderText = "ej. 1%";
            txtRecupSobreCosto.Size = new Size(171, 23);
            txtRecupSobreCosto.TabIndex = 19;
            // 
            // txtInvEquiXPart
            // 
            txtInvEquiXPart.Location = new Point(4, 53);
            txtInvEquiXPart.Margin = new Padding(2);
            txtInvEquiXPart.Name = "txtInvEquiXPart";
            txtInvEquiXPart.PlaceholderText = "ej. 55000000";
            txtInvEquiXPart.Size = new Size(171, 23);
            txtInvEquiXPart.TabIndex = 19;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(201, 222);
            label24.Margin = new Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new Size(118, 15);
            label24.TabIndex = 10;
            label24.Text = "% de tasa impositiva:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(4, 222);
            label23.Margin = new Padding(2, 0, 2, 0);
            label23.Name = "label23";
            label23.Size = new Size(155, 15);
            label23.TabIndex = 9;
            label23.Text = "% de gradiente de los flujos:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(5, 178);
            label22.Margin = new Padding(2, 0, 2, 0);
            label22.Name = "label22";
            label22.Size = new Size(174, 15);
            label22.TabIndex = 8;
            label22.Text = "% prima de riesgo del mercado:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(201, 178);
            label21.Margin = new Padding(2, 0, 2, 0);
            label21.Name = "label21";
            label21.Size = new Size(87, 15);
            label21.TabIndex = 7;
            label21.Text = "Beta del sector:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(4, 135);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(137, 15);
            label20.TabIndex = 6;
            label20.Text = "% de tasa libre de riesgo:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(201, 135);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(97, 15);
            label19.TabIndex = 5;
            label19.Text = "Plazo del crédito:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(201, 93);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(142, 15);
            label18.TabIndex = 4;
            label18.Text = "% financiado con crédito:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(5, 18);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(161, 30);
            label14.TabIndex = 1;
            label14.Text = "Inversión en equipos X punto\r\n de participación:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(201, 34);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(125, 15);
            label16.TabIndex = 2;
            label16.Text = "Plazo de depreciación:";
            label16.Click += label16_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(4, 77);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(183, 30);
            label17.TabIndex = 3;
            label17.Text = "% de recuperaciones sobre costo \r\nde ventas:";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label25.Location = new Point(7, 635);
            label25.Margin = new Padding(2, 0, 2, 0);
            label25.Name = "label25";
            label25.Size = new Size(159, 20);
            label25.TabIndex = 18;
            label25.Text = "Nombre del escenario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(209, 636);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 19;
            label3.Text = "Fecha de creación:";
            // 
            // txtNombreEscenario
            // 
            txtNombreEscenario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreEscenario.Location = new Point(6, 658);
            txtNombreEscenario.Margin = new Padding(2);
            txtNombreEscenario.Name = "txtNombreEscenario";
            txtNombreEscenario.PlaceholderText = "ej. 'Escen: 2026-03-14'";
            txtNombreEscenario.Size = new Size(181, 27);
            txtNombreEscenario.TabIndex = 16;
            txtNombreEscenario.TextChanged += txtNombreEscenario_TextChanged;
            // 
            // txtFechaCreacion
            // 
            txtFechaCreacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFechaCreacion.Location = new Point(208, 658);
            txtFechaCreacion.Margin = new Padding(2);
            txtFechaCreacion.Name = "txtFechaCreacion";
            txtFechaCreacion.Size = new Size(172, 27);
            txtFechaCreacion.TabIndex = 20;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(108, 691);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 44);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(199, 691);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(84, 44);
            btnCalcular.TabIndex = 22;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button3_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.Location = new Point(397, 145);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(685, 540);
            panel2.TabIndex = 24;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(295, 691);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(84, 44);
            btnGuardar.TabIndex = 25;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSalidas
            // 
            btnSalidas.Location = new Point(825, 93);
            btnSalidas.Name = "btnSalidas";
            btnSalidas.Size = new Size(217, 32);
            btnSalidas.TabIndex = 26;
            btnSalidas.Text = "Ver Flujo de Caja";
            btnSalidas.UseVisualStyleBackColor = true;
            btnSalidas.Click += btnSalidas_Click;
            // 
            // btnAnalisisSensiVPN
            // 
            btnAnalisisSensiVPN.Location = new Point(1048, 34);
            btnAnalisisSensiVPN.Name = "btnAnalisisSensiVPN";
            btnAnalisisSensiVPN.Size = new Size(219, 32);
            btnAnalisisSensiVPN.TabIndex = 27;
            btnAnalisisSensiVPN.Text = "Ver Análisis de Sensibilidad del VPN";
            btnAnalisisSensiVPN.UseVisualStyleBackColor = true;
            btnAnalisisSensiVPN.Click += button1_Click_1;
            // 
            // btnAnalisisVPN
            // 
            btnAnalisisVPN.Location = new Point(825, 34);
            btnAnalisisVPN.Name = "btnAnalisisVPN";
            btnAnalisisVPN.Size = new Size(219, 32);
            btnAnalisisVPN.TabIndex = 28;
            btnAnalisisVPN.Text = "Ver Análisis de VPN";
            btnAnalisisVPN.UseVisualStyleBackColor = true;
            btnAnalisisVPN.Click += button1_Click_2;
            // 
            // pnlFlujoResultados
            // 
            pnlFlujoResultados.AutoSize = true;
            pnlFlujoResultados.Location = new Point(397, 686);
            pnlFlujoResultados.Name = "pnlFlujoResultados";
            pnlFlujoResultados.Size = new Size(685, 97);
            pnlFlujoResultados.TabIndex = 29;
            // 
            // button2
            // 
            button2.Location = new Point(1048, 93);
            button2.Name = "button2";
            button2.Size = new Size(219, 32);
            button2.TabIndex = 30;
            button2.Text = "Ver Análisis de Sensibilidad Puntual";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormEntradaDatos
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            ClientSize = new Size(1273, 792);
            Controls.Add(button2);
            Controls.Add(pnlFlujoResultados);
            Controls.Add(btnAnalisisVPN);
            Controls.Add(btnAnalisisSensiVPN);
            Controls.Add(btnSalidas);
            Controls.Add(btnGuardar);
            Controls.Add(panel2);
            Controls.Add(btnCalcular);
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
            Margin = new Padding(2);
            Name = "FormEntradaDatos";
            SizeGripStyle = SizeGripStyle.Show;
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
        private Button btnCalcular;
        private ErrorProvider errorProvider1;
        private Panel panel2;
        private Button btnGuardar;
        private Button btnSalidas;
        private Button btnAnalisisSensiVPN;
        private Button btnAnalisisVPN;
        private Panel pnlFlujoResultados;
        private Button button1;
        private Button button2;
    }
}
