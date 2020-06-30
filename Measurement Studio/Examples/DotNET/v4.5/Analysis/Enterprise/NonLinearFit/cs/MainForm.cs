using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.Math;

namespace NationalInstruments.Examples.NonLinearFit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Button calculateButton;
        private NationalInstruments.UI.WaveformPlot fitDataPlot;
        private System.Windows.Forms.Label numberOfPointsLabel;
        private System.Windows.Forms.Label noiseLevelLabel;
        private NationalInstruments.UI.WaveformPlot scatteredDataPlot;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private System.Windows.Forms.GroupBox parametersGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit noiseLevelNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.WaveformGraph calculatedFitWaveformGraph;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.calculateButton = new System.Windows.Forms.Button();
            this.calculatedFitWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.scatteredDataPlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.fitDataPlot = new NationalInstruments.UI.WaveformPlot();
            this.numberOfPointsLabel = new System.Windows.Forms.Label();
            this.noiseLevelLabel = new System.Windows.Forms.Label();
            this.parametersGroupBox = new System.Windows.Forms.GroupBox();
            this.noiseLevelNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.calculatedFitWaveformGraph)).BeginInit();
            this.parametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseLevelNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculateButton.Location = new System.Drawing.Point(18, 184);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(120, 28);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Fit";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // calculatedFitWaveformGraph
            // 
            this.calculatedFitWaveformGraph.Dock = System.Windows.Forms.DockStyle.Right;
            this.calculatedFitWaveformGraph.Location = new System.Drawing.Point(166, 0);
            this.calculatedFitWaveformGraph.Name = "calculatedFitWaveformGraph";
            this.calculatedFitWaveformGraph.UseColorGenerator = true;
            this.calculatedFitWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                         this.scatteredDataPlot,
                                                                                                         this.fitDataPlot});
            this.calculatedFitWaveformGraph.Size = new System.Drawing.Size(336, 227);
            this.calculatedFitWaveformGraph.TabIndex = 1;
            this.calculatedFitWaveformGraph.TabStop = false;
            this.calculatedFitWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                                  this.xAxis});
            this.calculatedFitWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                                  this.yAxis});
            // 
            // scatteredDataPlot
            // 
            this.scatteredDataPlot.LineStyle = NationalInstruments.UI.LineStyle.None;
            this.scatteredDataPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle;
            this.scatteredDataPlot.XAxis = this.xAxis;
            this.scatteredDataPlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            // 
            // yAxis
            // 
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            // 
            // fitDataPlot
            // 
            this.fitDataPlot.XAxis = this.xAxis;
            this.fitDataPlot.YAxis = this.yAxis;
            // 
            // numberOfPointsLabel
            // 
            this.numberOfPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numberOfPointsLabel.Location = new System.Drawing.Point(12, 28);
            this.numberOfPointsLabel.Name = "numberOfPointsLabel";
            this.numberOfPointsLabel.Size = new System.Drawing.Size(90, 16);
            this.numberOfPointsLabel.TabIndex = 4;
            this.numberOfPointsLabel.Text = "Number of points";
            // 
            // noiseLevelLabel
            // 
            this.noiseLevelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noiseLevelLabel.Location = new System.Drawing.Point(12, 92);
            this.noiseLevelLabel.Name = "noiseLevelLabel";
            this.noiseLevelLabel.Size = new System.Drawing.Size(63, 16);
            this.noiseLevelLabel.TabIndex = 5;
            this.noiseLevelLabel.Text = "Noise Level";
            // 
            // parametersGroupBox
            // 
            this.parametersGroupBox.Controls.Add(this.noiseLevelNumericEdit);
            this.parametersGroupBox.Controls.Add(this.numberOfSamplesNumericEdit);
            this.parametersGroupBox.Controls.Add(this.numberOfPointsLabel);
            this.parametersGroupBox.Controls.Add(this.noiseLevelLabel);
            this.parametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.parametersGroupBox.Location = new System.Drawing.Point(12, 8);
            this.parametersGroupBox.Name = "parametersGroupBox";
            this.parametersGroupBox.Size = new System.Drawing.Size(132, 156);
            this.parametersGroupBox.TabIndex = 1;
            this.parametersGroupBox.TabStop = false;
            this.parametersGroupBox.Text = "Parameters";
            // 
            // noiseLevelNumericEdit
            // 
            this.noiseLevelNumericEdit.CoercionInterval = 0.1;
            this.noiseLevelNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.noiseLevelNumericEdit.Location = new System.Drawing.Point(12, 116);
            this.noiseLevelNumericEdit.Name = "noiseLevelNumericEdit";
            this.noiseLevelNumericEdit.Size = new System.Drawing.Size(92, 20);
            this.noiseLevelNumericEdit.TabIndex = 2;
            this.noiseLevelNumericEdit.Value = 0.1;
            // 
            // numberOfSamplesNumericEdit
            // 
            this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(12, 56);
            this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
            this.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfSamplesNumericEdit.Range = new NationalInstruments.UI.Range(3, System.Double.PositiveInfinity);
            this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(92, 20);
            this.numberOfSamplesNumericEdit.TabIndex = 1;
            this.numberOfSamplesNumericEdit.Value = 50;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(502, 227);
            this.Controls.Add(this.parametersGroupBox);
            this.Controls.Add(this.calculatedFitWaveformGraph);
            this.Controls.Add(this.calculateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Non-Linear Fit";
            ((System.ComponentModel.ISupportInitialize)(this.calculatedFitWaveformGraph)).EndInit();
            this.parametersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noiseLevelNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.DoEvents();
			Application.Run(new MainForm());
		}

        private void GenerateDataToFit(int numSamples, double noiseAmplitude, out double[] xData, out double[] yData)
        {
            xData = new double[numSamples];
            yData = new double[numSamples];

            WhiteNoiseSignal noise = new WhiteNoiseSignal(noiseAmplitude, 0);
            double[] noiseData = noise.Generate(numSamples, numSamples);

            for(int x = 0; x < xData.Length; x++)
            {
                xData[x] = x;
                yData[x] = System.Math.Exp(-.1*x) + 2.0 + noiseData[x];
            }
        }

        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            int numSamples = (int)numberOfSamplesNumericEdit.Value;
            double noiseAmplitude = noiseLevelNumericEdit.Value;
            double[] xData, yData;
            double[] coefficients = {2, 0, 4};

            GenerateDataToFit(numSamples, noiseAmplitude, out xData, out yData);
            scatteredDataPlot.PlotY(yData);
            
            double mse;
            ModelFunctionCallback callback = new ModelFunctionCallback(ModelFunction);
            try
            {
                double[] fittedData = CurveFit.NonLinearFit(xData, yData, callback, coefficients, out mse);
                fitDataPlot.PlotY(fittedData);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private double ModelFunction(double x, double[] a)
        {
            return (a[0]*System.Math.Exp(a[1]*x)) + a[2];
        }
	}
}
