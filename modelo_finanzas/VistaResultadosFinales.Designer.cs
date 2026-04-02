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
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaResultadosFinales));
            LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend3 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
            LiveChartsCore.Drawing.Padding padding5 = new LiveChartsCore.Drawing.Padding();
            LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip3 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
            LiveChartsCore.Drawing.Padding padding6 = new LiveChartsCore.Drawing.Padding();
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
            cartesianChart1.AutoUpdateEnabled = true;
            cartesianChart1.ChartTheme = null;
            skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend1.Content = null;
            skDefaultLegend1.IsValid = true;
            skDefaultLegend1.Opacity = 1F;
            padding1.Bottom = 0F;
            padding1.Left = 0F;
            padding1.Right = 0F;
            padding1.Top = 0F;
            skDefaultLegend1.Padding = padding1;
            skDefaultLegend1.RemoveOnCompleted = false;
            skDefaultLegend1.RotateTransform = 0F;
            skDefaultLegend1.X = 0F;
            skDefaultLegend1.Y = 0F;
            cartesianChart1.Legend = skDefaultLegend1;
            cartesianChart1.Location = new Point(32, 63);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(619, 222);
            cartesianChart1.TabIndex = 0;
            skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip1.Content = null;
            skDefaultTooltip1.IsValid = true;
            skDefaultTooltip1.Opacity = 1F;
            padding2.Bottom = 0F;
            padding2.Left = 0F;
            padding2.Right = 0F;
            padding2.Top = 0F;
            skDefaultTooltip1.Padding = padding2;
            skDefaultTooltip1.RemoveOnCompleted = false;
            skDefaultTooltip1.RotateTransform = 0F;
            skDefaultTooltip1.Wedge = 10;
            skDefaultTooltip1.X = 0F;
            skDefaultTooltip1.Y = 0F;
            cartesianChart1.Tooltip = skDefaultTooltip1;
            cartesianChart1.TooltipFindingStrategy = TooltipFindingStrategy.Automatic;
            cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
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
            cartesianChart2.AutoUpdateEnabled = true;
            cartesianChart2.ChartTheme = null;
            skDefaultLegend2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend2.Content = null;
            skDefaultLegend2.IsValid = true;
            skDefaultLegend2.Opacity = 1F;
            padding3.Bottom = 0F;
            padding3.Left = 0F;
            padding3.Right = 0F;
            padding3.Top = 0F;
            skDefaultLegend2.Padding = padding3;
            skDefaultLegend2.RemoveOnCompleted = false;
            skDefaultLegend2.RotateTransform = 0F;
            skDefaultLegend2.X = 0F;
            skDefaultLegend2.Y = 0F;
            cartesianChart2.Legend = skDefaultLegend2;
            cartesianChart2.Location = new Point(28, 67);
            cartesianChart2.MatchAxesScreenDataRatio = false;
            cartesianChart2.Name = "cartesianChart2";
            cartesianChart2.Size = new Size(619, 222);
            cartesianChart2.TabIndex = 1;
            skDefaultTooltip2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip2.Content = null;
            skDefaultTooltip2.IsValid = true;
            skDefaultTooltip2.Opacity = 1F;
            padding4.Bottom = 0F;
            padding4.Left = 0F;
            padding4.Right = 0F;
            padding4.Top = 0F;
            skDefaultTooltip2.Padding = padding4;
            skDefaultTooltip2.RemoveOnCompleted = false;
            skDefaultTooltip2.RotateTransform = 0F;
            skDefaultTooltip2.Wedge = 10;
            skDefaultTooltip2.X = 0F;
            skDefaultTooltip2.Y = 0F;
            cartesianChart2.Tooltip = skDefaultTooltip2;
            cartesianChart2.TooltipFindingStrategy = TooltipFindingStrategy.Automatic;
            cartesianChart2.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
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
            cartesianChart3.AutoUpdateEnabled = true;
            cartesianChart3.ChartTheme = null;
            skDefaultLegend3.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultLegend3.Content = null;
            skDefaultLegend3.IsValid = true;
            skDefaultLegend3.Opacity = 1F;
            padding5.Bottom = 0F;
            padding5.Left = 0F;
            padding5.Right = 0F;
            padding5.Top = 0F;
            skDefaultLegend3.Padding = padding5;
            skDefaultLegend3.RemoveOnCompleted = false;
            skDefaultLegend3.RotateTransform = 0F;
            skDefaultLegend3.X = 0F;
            skDefaultLegend3.Y = 0F;
            cartesianChart3.Legend = skDefaultLegend3;
            cartesianChart3.Location = new Point(32, 63);
            cartesianChart3.MatchAxesScreenDataRatio = false;
            cartesianChart3.Name = "cartesianChart3";
            cartesianChart3.Size = new Size(619, 222);
            cartesianChart3.TabIndex = 1;
            skDefaultTooltip3.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
            skDefaultTooltip3.Content = null;
            skDefaultTooltip3.IsValid = true;
            skDefaultTooltip3.Opacity = 1F;
            padding6.Bottom = 0F;
            padding6.Left = 0F;
            padding6.Right = 0F;
            padding6.Top = 0F;
            skDefaultTooltip3.Padding = padding6;
            skDefaultTooltip3.RemoveOnCompleted = false;
            skDefaultTooltip3.RotateTransform = 0F;
            skDefaultTooltip3.Wedge = 10;
            skDefaultTooltip3.X = 0F;
            skDefaultTooltip3.Y = 0F;
            cartesianChart3.Tooltip = skDefaultTooltip3;
            cartesianChart3.TooltipFindingStrategy = TooltipFindingStrategy.Automatic;
            cartesianChart3.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
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
            FormClosed += VistaResultadosFinales_FormClosed;
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