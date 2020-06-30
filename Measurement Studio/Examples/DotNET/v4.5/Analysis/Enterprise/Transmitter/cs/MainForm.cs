using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.Dsp.Filters;

namespace NationalInstruments.Examples.Transmitter
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Button goButton;
        private NationalInstruments.UI.WaveformPlot sentSignal;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.WaveformPlot receivedSignal;
        private System.Windows.Forms.GroupBox orignalPulseGroupBox;
        private System.Windows.Forms.Label samplesLabel;
        private System.Windows.Forms.Label additiveNoiseLabel;
        private System.Windows.Forms.Label filterOrderLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit additiveNoiseNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit filterOrderNumericEdit;
        private NationalInstruments.UI.WindowsForms.WaveformGraph orginalAndDetectedPulseWaveformGraph;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            // Setting the range supported by the .NET Analysis Library
            NationalInstruments.UI.Range range = new UI.Range(1, Int32.MaxValue);
            numberOfSamplesNumericEdit.Range = range;
            filterOrderNumericEdit.Range = range;
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
            this.orginalAndDetectedPulseWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.sentSignal = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.receivedSignal = new NationalInstruments.UI.WaveformPlot();
            this.goButton = new System.Windows.Forms.Button();
            this.orignalPulseGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.additiveNoiseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.filterOrderNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.samplesLabel = new System.Windows.Forms.Label();
            this.additiveNoiseLabel = new System.Windows.Forms.Label();
            this.filterOrderLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orginalAndDetectedPulseWaveformGraph)).BeginInit();
            this.orignalPulseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additiveNoiseNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterOrderNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // orginalAndDetectedPulseWaveformGraph
            // 
            this.orginalAndDetectedPulseWaveformGraph.Caption = "Original and Detected Pulse";
            this.orginalAndDetectedPulseWaveformGraph.Location = new System.Drawing.Point(148, 0);
            this.orginalAndDetectedPulseWaveformGraph.Name = "orginalAndDetectedPulseWaveformGraph";
			this.orginalAndDetectedPulseWaveformGraph.UseColorGenerator = true;
            this.orginalAndDetectedPulseWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.sentSignal,
            this.receivedSignal});
            this.orginalAndDetectedPulseWaveformGraph.Size = new System.Drawing.Size(364, 255);
            this.orginalAndDetectedPulseWaveformGraph.TabIndex = 0;
            this.orginalAndDetectedPulseWaveformGraph.TabStop = false;
            this.orginalAndDetectedPulseWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.orginalAndDetectedPulseWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // sentSignal
            // 
            this.sentSignal.XAxis = this.xAxis;
            this.sentSignal.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            // 
            // yAxis
            // 
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            // 
            // receivedSignal
            // 
            this.receivedSignal.XAxis = this.xAxis;
            this.receivedSignal.YAxis = this.yAxis;
            // 
            // goButton
            // 
            this.goButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.goButton.Location = new System.Drawing.Point(12, 220);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(120, 28);
            this.goButton.TabIndex = 0;
            this.goButton.Text = "Go";
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // orignalPulseGroupBox
            // 
            this.orignalPulseGroupBox.Controls.Add(this.numberOfSamplesNumericEdit);
            this.orignalPulseGroupBox.Controls.Add(this.additiveNoiseNumericEdit);
            this.orignalPulseGroupBox.Controls.Add(this.filterOrderNumericEdit);
            this.orignalPulseGroupBox.Controls.Add(this.samplesLabel);
            this.orignalPulseGroupBox.Controls.Add(this.additiveNoiseLabel);
            this.orignalPulseGroupBox.Controls.Add(this.filterOrderLabel);
            this.orignalPulseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.orignalPulseGroupBox.Location = new System.Drawing.Point(12, 8);
            this.orignalPulseGroupBox.Name = "orignalPulseGroupBox";
            this.orignalPulseGroupBox.Size = new System.Drawing.Size(120, 200);
            this.orignalPulseGroupBox.TabIndex = 1;
            this.orignalPulseGroupBox.TabStop = false;
            this.orignalPulseGroupBox.Text = "Original Pulse";
            // 
            // numberOfSamplesNumericEdit
            // 
            this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(20, 156);
            this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
            this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(76, 20);
            this.numberOfSamplesNumericEdit.TabIndex = 8;
            this.numberOfSamplesNumericEdit.Value = 256;
            // 
            // additiveNoiseNumericEdit
            // 
            this.additiveNoiseNumericEdit.CoercionInterval = 0.01;
            this.additiveNoiseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.additiveNoiseNumericEdit.Location = new System.Drawing.Point(20, 100);
            this.additiveNoiseNumericEdit.Name = "additiveNoiseNumericEdit";
            this.additiveNoiseNumericEdit.Range = new NationalInstruments.UI.Range(0, 1);
            this.additiveNoiseNumericEdit.Size = new System.Drawing.Size(76, 20);
            this.additiveNoiseNumericEdit.TabIndex = 7;
            this.additiveNoiseNumericEdit.Value = 0.23;
            // 
            // filterOrderNumericEdit
            // 
            this.filterOrderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.filterOrderNumericEdit.Location = new System.Drawing.Point(20, 44);
            this.filterOrderNumericEdit.Name = "filterOrderNumericEdit";
            this.filterOrderNumericEdit.Size = new System.Drawing.Size(76, 20);
            this.filterOrderNumericEdit.TabIndex = 6;
            this.filterOrderNumericEdit.Value = 5;
            // 
            // samplesLabel
            // 
            this.samplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplesLabel.Location = new System.Drawing.Point(20, 140);
            this.samplesLabel.Name = "samplesLabel";
            this.samplesLabel.Size = new System.Drawing.Size(60, 16);
            this.samplesLabel.TabIndex = 5;
            this.samplesLabel.Text = "Samples:";
            // 
            // additiveNoiseLabel
            // 
            this.additiveNoiseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.additiveNoiseLabel.Location = new System.Drawing.Point(20, 84);
            this.additiveNoiseLabel.Name = "additiveNoiseLabel";
            this.additiveNoiseLabel.Size = new System.Drawing.Size(84, 16);
            this.additiveNoiseLabel.TabIndex = 4;
            this.additiveNoiseLabel.Text = "Additive Noise:";
            // 
            // filterOrderLabel
            // 
            this.filterOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filterOrderLabel.Location = new System.Drawing.Point(20, 28);
            this.filterOrderLabel.Name = "filterOrderLabel";
            this.filterOrderLabel.Size = new System.Drawing.Size(61, 16);
            this.filterOrderLabel.TabIndex = 3;
            this.filterOrderLabel.Text = "Filter Order:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(510, 256);
            this.Controls.Add(this.orignalPulseGroupBox);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.orginalAndDetectedPulseWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transmitter";
            ((System.ComponentModel.ISupportInitialize)(this.orginalAndDetectedPulseWaveformGraph)).EndInit();
            this.orignalPulseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additiveNoiseNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterOrderNumericEdit)).EndInit();
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

        private double[] Transmitter(int numSamples)
        {
            double[] data = PatternGeneration.Pulse(numSamples, 1, 64, 128);
            sentSignal.PlotY(data);
            SineSignal sine = new SineSignal(numSamples / 4, 1.0);
            double[] sineWave = sine.Generate(numSamples, numSamples);
            
            for(int x = 0; x < data.Length; x++)
                data[x] *= sineWave[x];

            return data;
        }

        private double[] Receiver(int numSamples, double[] pulsePattern)
        {
            double[] output = new double[numSamples];

            SineSignal sine = new SineSignal(numSamples / 4, 2);
            double[] sineWave = sine.Generate(numSamples, numSamples);
            
            for(int x = 0; x < pulsePattern.Length; x++)
                output[x] = pulsePattern[x] * sineWave[x];

            return output;
        }

        private void goButton_Click(object sender, System.EventArgs e)
        {
            int numSamples = (int)numberOfSamplesNumericEdit.Value;

            double[] pulsePattern = Transmitter(numSamples);
            WhiteNoiseSignal noise = new WhiteNoiseSignal(additiveNoiseNumericEdit.Value, 0);
            double[] noiseSignal = noise.Generate(numSamples,numSamples);
            
            for(int x = 0; x < pulsePattern.Length; x++)
                pulsePattern[x] += noiseSignal[x];

            double[] output = Receiver(numSamples, pulsePattern);
            
            IirFilterBase filter = new BesselLowpassFilter((int)filterOrderNumericEdit.Value, 1, .1250);
            double[] filterData = filter.FilterData(output);

            receivedSignal.PlotY(filterData);
        }
	}
}
