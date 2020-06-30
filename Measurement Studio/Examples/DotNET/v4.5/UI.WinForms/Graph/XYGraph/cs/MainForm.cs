
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NationalInstruments.Examples.XYGraph
{
    public class MainForm : System.Windows.Forms.Form
    {
        private const double TwoPi = Math.PI * 2;
        private const double HalfPi = Math.PI / 2;
        private NationalInstruments.UI.XAxis xyPlotXAxis;
        private NationalInstruments.UI.YAxis xyPlotYAxis;
        private NationalInstruments.UI.ScatterPlot xyPlot;
        private NationalInstruments.UI.XAxis xDataXAxis;
        private NationalInstruments.UI.YAxis xDataYAxis;
        private NationalInstruments.UI.WaveformPlot xPlot;
        private NationalInstruments.UI.XAxis yDataXAxis;
        private NationalInstruments.UI.YAxis yDataYAxis;
        private NationalInstruments.UI.WaveformPlot yPlot;
        private System.Windows.Forms.GroupBox separatorGroupBox;
		private NationalInstruments.UI.WindowsForms.ScatterGraph xyDataScatterGraph;
		private NationalInstruments.UI.WindowsForms.WaveformGraph xDataWaveformGraph;
		private NationalInstruments.UI.WindowsForms.WaveformGraph yDataWaveformGraph;
		private System.Windows.Forms.Button plotCircleButton;
		private System.Windows.Forms.Button plotOctagonButton;
		private System.Windows.Forms.Button plotPolarButton;
		private System.Windows.Forms.Button plotSpiralButton;
        private System.ComponentModel.Container components = null;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xyDataScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.xyPlot = new NationalInstruments.UI.ScatterPlot();
            this.xyPlotXAxis = new NationalInstruments.UI.XAxis();
            this.xyPlotYAxis = new NationalInstruments.UI.YAxis();
            this.xDataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xPlot = new NationalInstruments.UI.WaveformPlot();
            this.xDataXAxis = new NationalInstruments.UI.XAxis();
            this.xDataYAxis = new NationalInstruments.UI.YAxis();
            this.yDataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.yPlot = new NationalInstruments.UI.WaveformPlot();
            this.yDataXAxis = new NationalInstruments.UI.XAxis();
            this.yDataYAxis = new NationalInstruments.UI.YAxis();
            this.plotCircleButton = new System.Windows.Forms.Button();
            this.plotOctagonButton = new System.Windows.Forms.Button();
            this.plotPolarButton = new System.Windows.Forms.Button();
            this.plotSpiralButton = new System.Windows.Forms.Button();
            this.separatorGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.xyDataScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDataWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDataWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // xyDataScatterGraph
            // 
            this.xyDataScatterGraph.Caption = "XY Plot";
            this.xyDataScatterGraph.Location = new System.Drawing.Point(4, 4);
            this.xyDataScatterGraph.Name = "xyDataScatterGraph";
            this.xyDataScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.xyPlot});
            this.xyDataScatterGraph.Size = new System.Drawing.Size(484, 200);
            this.xyDataScatterGraph.TabIndex = 0;
            this.xyDataScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xyPlotXAxis});
            this.xyDataScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.xyPlotYAxis});
            // 
            // xyPlot
            // 
            this.xyPlot.XAxis = this.xyPlotXAxis;
            this.xyPlot.YAxis = this.xyPlotYAxis;
            // 
            // xDataWaveformGraph
            // 
            this.xDataWaveformGraph.Caption = "X Data";
            this.xDataWaveformGraph.Location = new System.Drawing.Point(4, 208);
            this.xDataWaveformGraph.Name = "xDataWaveformGraph";
            this.xDataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.xPlot});
            this.xDataWaveformGraph.Size = new System.Drawing.Size(240, 140);
            this.xDataWaveformGraph.TabIndex = 1;
            this.xDataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xDataXAxis});
            this.xDataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.xDataYAxis});
            // 
            // xPlot
            // 
            this.xPlot.XAxis = this.xDataXAxis;
            this.xPlot.YAxis = this.xDataYAxis;
            // 
            // yDataWaveformGraph
            // 
            this.yDataWaveformGraph.Caption = "Y Data";
            this.yDataWaveformGraph.Location = new System.Drawing.Point(248, 208);
            this.yDataWaveformGraph.Name = "yDataWaveformGraph";
            this.yDataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.yPlot});
            this.yDataWaveformGraph.Size = new System.Drawing.Size(240, 140);
            this.yDataWaveformGraph.TabIndex = 2;
            this.yDataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.yDataXAxis});
            this.yDataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yDataYAxis});
            // 
            // yPlot
            // 
            this.yPlot.XAxis = this.yDataXAxis;
            this.yPlot.YAxis = this.yDataYAxis;
            // 
            // plotCircleButton
            // 
            this.plotCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotCircleButton.Location = new System.Drawing.Point(8, 368);
            this.plotCircleButton.Name = "plotCircleButton";
            this.plotCircleButton.Size = new System.Drawing.Size(112, 23);
            this.plotCircleButton.TabIndex = 3;
            this.plotCircleButton.Text = "Plot Circle";
            this.plotCircleButton.Click += new System.EventHandler(this.OnPlotCircleClick);
            // 
            // plotOctagonButton
            // 
            this.plotOctagonButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotOctagonButton.Location = new System.Drawing.Point(129, 368);
            this.plotOctagonButton.Name = "plotOctagonButton";
            this.plotOctagonButton.Size = new System.Drawing.Size(112, 23);
            this.plotOctagonButton.TabIndex = 4;
            this.plotOctagonButton.Text = "Plot Octagon";
            this.plotOctagonButton.Click += new System.EventHandler(this.OnPlotOctagonClick);
            // 
            // plotPolarButton
            // 
            this.plotPolarButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotPolarButton.Location = new System.Drawing.Point(250, 368);
            this.plotPolarButton.Name = "plotPolarButton";
            this.plotPolarButton.Size = new System.Drawing.Size(112, 23);
            this.plotPolarButton.TabIndex = 5;
            this.plotPolarButton.Text = "Plot Polar";
            this.plotPolarButton.Click += new System.EventHandler(this.OnPlotPolarClick);
            // 
            // plotSpiralButton
            // 
            this.plotSpiralButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotSpiralButton.Location = new System.Drawing.Point(371, 368);
            this.plotSpiralButton.Name = "plotSpiralButton";
            this.plotSpiralButton.Size = new System.Drawing.Size(112, 23);
            this.plotSpiralButton.TabIndex = 6;
            this.plotSpiralButton.Text = "Plot Spiral";
            this.plotSpiralButton.Click += new System.EventHandler(this.OnPlotSpiralClick);
            // 
            // separatorGroupBox
            // 
            this.separatorGroupBox.Location = new System.Drawing.Point(4, 352);
            this.separatorGroupBox.Name = "separatorGroupBox";
            this.separatorGroupBox.Size = new System.Drawing.Size(484, 8);
            this.separatorGroupBox.TabIndex = 7;
            this.separatorGroupBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(492, 395);
            this.Controls.Add(this.separatorGroupBox);
            this.Controls.Add(this.plotSpiralButton);
            this.Controls.Add(this.plotPolarButton);
            this.Controls.Add(this.plotOctagonButton);
            this.Controls.Add(this.plotCircleButton);
            this.Controls.Add(this.yDataWaveformGraph);
            this.Controls.Add(this.xDataWaveformGraph);
            this.Controls.Add(this.xyDataScatterGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "XY Graph";
            ((System.ComponentModel.ISupportInitialize)(this.xyDataScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xDataWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yDataWaveformGraph)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                    components.Dispose();
            }

            base.Dispose(disposing);
        }

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }

        private void OnPlotCircleClick(object sender, System.EventArgs e)
        {
            const int pointCount = 50;
            const int divisor = pointCount - 1;
            double[] dataX = new double[pointCount];
            double[] dataY = new double[pointCount];

            for (int i = 0; i < pointCount; ++i)
            {
                double current = ((double)i / divisor) * TwoPi;
                dataX[i] = Math.Cos(current) * HalfPi;
                dataY[i] = Math.Sin(current) * HalfPi;
            }

            xyPlot.PlotXY(dataX, dataY);
            xPlot.PlotY(dataX);
            yPlot.PlotY(dataY);
        }

        private void OnPlotOctagonClick(object sender, System.EventArgs e)
        {
            const int numberOfSides = 8;
            const int pointCount = numberOfSides + 1;

            double[] dataX = new double[pointCount];
            double[] dataY = new double[pointCount];

            for (int i = 0; i < pointCount; ++i)
            {
                dataX[i] = Math.Cos(((i + 0.5) / numberOfSides) * TwoPi);
                dataY[i] = Math.Sin(((i + 0.5) / numberOfSides) * TwoPi);
            }

            xyPlot.PlotXY(dataX, dataY);
            xPlot.PlotY(dataX);
            yPlot.PlotY(dataY);
        }

        private void OnPlotPolarClick(object sender, System.EventArgs e)
        {
            const int numberOfPoints = 360;
            const int divisor = numberOfPoints - 1;
            double[] dataR = new double[numberOfPoints];
            double[] dataP = new double[numberOfPoints];
            double[] dataX = new double[numberOfPoints];
            double[] dataY = new double[numberOfPoints];

            // Calculate data in polar coordinates.
            for (int i = 0; i < numberOfPoints; ++i)
            {
                dataP[i] = i;
                dataR[i] = Math.Sin(((double)i / divisor) * TwoPi * 3) + 0.5;
            }

            // Convert polar coordinates to XY coordinates.
            for (int i = 0; i < numberOfPoints; ++i)
            {
                double current = (dataP[i] / numberOfPoints) * TwoPi;
                dataX[i] = Math.Cos(current) * dataR[i];
                dataY[i] = Math.Sin(current) * dataR[i];
            }

            xyPlot.PlotXY(dataX, dataY);
            xPlot.PlotY(dataX);
            yPlot.PlotY(dataY);
        }

        private void OnPlotSpiralClick(object sender, System.EventArgs e)
        {
            const int numberOfPoints = 360;
            double[] dataR = new double[numberOfPoints];
            double[] dataP = new double[numberOfPoints];
            double[] dataX = new double[numberOfPoints];
            double[] dataY = new double[numberOfPoints];

            // Calculate data in polar coordinates.
            for (int i = 0; i < numberOfPoints; ++i)
            {
                dataP[i] = i * 10;
                dataR[i] = Math.Pow(i, 2) / 70000;
            }

            // Convert polar coordinates to XY coordinates.
            for (int i = 0; i < numberOfPoints; ++i)
            {
                double current = (dataP[i] / numberOfPoints) * TwoPi;
                dataX[i] = Math.Cos(current) * dataR[i];
                dataY[i] = Math.Sin(current) * dataR[i];
            }

            xyPlot.PlotXY(dataX, dataY);
            xPlot.PlotY(dataX);
            yPlot.PlotY(dataY);
        }
    }
}

