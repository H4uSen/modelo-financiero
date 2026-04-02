using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using LiveChartsCore;
using LiveChartsCore.Measure;

namespace Prueba1
{
    partial class VistaResultadosFinales
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
            label1 = new Label();
            label2 = new Label();
            tabControl1 = new TabControl();
            TcVentasProyectadas = new TabPage();
            cartesianChart1 = new CartesianChart();
            TcCostosGastos = new TabPage();
            cartesianChart2 = new CartesianChart();
            TcAmortizaCredito = new TabPage();
            cartesianChart3 = new CartesianChart();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            LbCalculoVPN = new Label();
            LbRecomendacionAuto = new Label();
            tabControl1.SuspendLayout();
            TcVentasProyectadas.SuspendLayout();
            TcCostosGastos.SuspendLayout();
            TcAmortizaCredito.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(156, 28);
            label1.TabIndex = 0;
            label1.Text = "VPN Calculado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 103);
            label2.Name = "label2";
            label2.Size = new Size(167, 28);
            label2.TabIndex = 1;
            label2.Text = "Recomendación:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TcVentasProyectadas);
            tabControl1.Controls.Add(TcCostosGastos);
            tabControl1.Controls.Add(TcAmortizaCredito);
            tabControl1.Location = new Point(53, 166);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(696, 342);
            tabControl1.TabIndex = 2;
            // 
            // TcVentasProyectadas
            // 
            TcVentasProyectadas.Controls.Add(cartesianChart1);
            TcVentasProyectadas.Location = new Point(4, 29);
            TcVentasProyectadas.Name = "TcVentasProyectadas";
            TcVentasProyectadas.Padding = new Padding(3);
            TcVentasProyectadas.Size = new Size(688, 309);
            TcVentasProyectadas.TabIndex = 0;
            TcVentasProyectadas.Text = "Ventas Proyectadas";
            TcVentasProyectadas.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            cartesianChart1.Location = new Point(32, 63);
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(619, 222);
            cartesianChart1.TabIndex = 0;
            cartesianChart1.Text = "cartesianChart1";
            // 
            // TcCostosGastos
            // 
            TcCostosGastos.Controls.Add(cartesianChart2);
            TcCostosGastos.Location = new Point(4, 29);
            TcCostosGastos.Name = "TcCostosGastos";
            TcCostosGastos.Padding = new Padding(3);
            TcCostosGastos.Size = new Size(688, 309);
            TcCostosGastos.TabIndex = 1;
            TcCostosGastos.Text = "Costos y Gastos";
            TcCostosGastos.UseVisualStyleBackColor = true;
            // 
            // cartesianChart2
            // 
            cartesianChart2.Location = new Point(28, 67);
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(619, 222);
            cartesianChart2.TabIndex = 1;
            cartesianChart2.Text = "cartesianChart2";
            // 
            // TcAmortizaCredito
            // 
            TcAmortizaCredito.Controls.Add(cartesianChart3);
            TcAmortizaCredito.Location = new Point(4, 29);
            TcAmortizaCredito.Name = "TcAmortizaCredito";
            TcAmortizaCredito.Padding = new Padding(3);
            TcAmortizaCredito.Size = new Size(688, 309);
            TcAmortizaCredito.TabIndex = 2;
            TcAmortizaCredito.Text = "Amortización y Crédito";
            TcAmortizaCredito.UseVisualStyleBackColor = true;
            // 
            // cartesianChart3
            // 
            cartesianChart3.Location = new Point(32, 63);
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(619, 222);
            cartesianChart3.TabIndex = 1;
            cartesianChart3.Text = "cartesianChart3";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(161, 539);
            button1.Name = "button1";
            button1.Size = new Size(188, 70);
            button1.TabIndex = 3;
            button1.Text = "Exportar PDF";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(486, 539);
            button2.Name = "button2";
            button2.Size = new Size(188, 70);
            button2.TabIndex = 3;
            button2.Text = "Exportar Excel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(256, 624);
            button3.Name = "button3";
            button3.Size = new Size(294, 70);
            button3.TabIndex = 3;
            button3.Text = "Volver a Escenarios";
            button3.UseVisualStyleBackColor = true;
            // 
            // LbCalculoVPN
            // 
            LbCalculoVPN.AutoSize = true;
            LbCalculoVPN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbCalculoVPN.Location = new Point(273, 34);
            LbCalculoVPN.Name = "LbCalculoVPN";
            LbCalculoVPN.Size = new Size(169, 28);
            LbCalculoVPN.TabIndex = 0;
            LbCalculoVPN.Text = "Mostrar cálculos\r\n";
            // 
            // LbRecomendacionAuto
            // 
            LbRecomendacionAuto.AutoSize = true;
            LbRecomendacionAuto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LbRecomendacionAuto.Location = new Point(273, 103);
            LbRecomendacionAuto.Name = "LbRecomendacionAuto";
            LbRecomendacionAuto.Size = new Size(243, 28);
            LbRecomendacionAuto.TabIndex = 1;
            LbRecomendacionAuto.Text = "Mostrar Recomendación";
            // 
            // VistaResultadosFinales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 755);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Controls.Add(LbRecomendacionAuto);
            Controls.Add(label2);
            Controls.Add(LbCalculoVPN);
            Controls.Add(label1);
            Name = "VistaResultadosFinales";
            Text = "VistaResultadosFinales";
            tabControl1.ResumeLayout(false);
            TcVentasProyectadas.ResumeLayout(false);
            TcCostosGastos.ResumeLayout(false);
            TcAmortizaCredito.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TabControl tabControl1;
        private TabPage TcVentasProyectadas;
        private TabPage TcCostosGastos;
        private TabPage TcAmortizaCredito;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label LbCalculoVPN;
        private Label LbRecomendacionAuto;
        private CartesianChart cartesianChart1;
        private CartesianChart cartesianChart2;
        private CartesianChart cartesianChart3;
    }
}