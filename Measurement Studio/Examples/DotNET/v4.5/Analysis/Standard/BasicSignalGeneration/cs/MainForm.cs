using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using NationalInstruments.Analysis.SignalGeneration;

namespace NationalInstruments.Examples.BasicSignalGeneration
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.GroupBox signalTypeGroupBox;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label samplesLabel;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.GroupBox signalParametersGroupBox;
        private System.Windows.Forms.Button generateButton;
		private NationalInstruments.UI.WaveformPlot signalPlot;
		private NationalInstruments.UI.YAxis amplitudeAxis;
		private NationalInstruments.UI.XAxis samplesAxis;
		private System.Windows.Forms.RadioButton sineRadioButton;
		private System.Windows.Forms.RadioButton triangleRadioButton;
		private System.Windows.Forms.RadioButton squareRadioButton;
		private System.Windows.Forms.RadioButton sawtoothRadioButton;
		private NationalInstruments.UI.WindowsForms.NumericEdit amplitudeNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit samplingRateNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit offsetNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit samplesNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit frequencyNumericEdit;
		private NationalInstruments.UI.WindowsForms.WaveformGraph signalWaveformGraph;
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

            //
            // Set minimum and maximum allowable values for numeric controls.
            //
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
			this.sineRadioButton = new System.Windows.Forms.RadioButton();
			this.triangleRadioButton = new System.Windows.Forms.RadioButton();
			this.squareRadioButton = new System.Windows.Forms.RadioButton();
			this.sawtoothRadioButton = new System.Windows.Forms.RadioButton();
			this.signalTypeGroupBox = new System.Windows.Forms.GroupBox();
			this.amplitudeLabel = new System.Windows.Forms.Label();
			this.frequencyLabel = new System.Windows.Forms.Label();
			this.samplesLabel = new System.Windows.Forms.Label();
			this.offsetLabel = new System.Windows.Forms.Label();
			this.samplingRateLabel = new System.Windows.Forms.Label();
			this.generateButton = new System.Windows.Forms.Button();
			this.signalParametersGroupBox = new System.Windows.Forms.GroupBox();
			this.samplingRateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.offsetNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.samplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.frequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.amplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.signalWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
			this.signalPlot = new NationalInstruments.UI.WaveformPlot();
			this.samplesAxis = new NationalInstruments.UI.XAxis();
			this.amplitudeAxis = new NationalInstruments.UI.YAxis();
			this.signalTypeGroupBox.SuspendLayout();
			this.signalParametersGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.offsetNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.signalWaveformGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// sineRadioButton
			// 
			this.sineRadioButton.Checked = true;
			this.sineRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.sineRadioButton.Location = new System.Drawing.Point(8, 24);
			this.sineRadioButton.Name = "sineRadioButton";
			this.sineRadioButton.Size = new System.Drawing.Size(80, 24);
			this.sineRadioButton.TabIndex = 0;
			this.sineRadioButton.TabStop = true;
			this.sineRadioButton.Text = "Sine";
			// 
			// triangleRadioButton
			// 
			this.triangleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.triangleRadioButton.Location = new System.Drawing.Point(8, 56);
			this.triangleRadioButton.Name = "triangleRadioButton";
			this.triangleRadioButton.Size = new System.Drawing.Size(80, 24);
			this.triangleRadioButton.TabIndex = 1;
			this.triangleRadioButton.Text = "Triangle";
			// 
			// squareRadioButton
			// 
			this.squareRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.squareRadioButton.Location = new System.Drawing.Point(8, 88);
			this.squareRadioButton.Name = "squareRadioButton";
			this.squareRadioButton.Size = new System.Drawing.Size(80, 24);
			this.squareRadioButton.TabIndex = 2;
			this.squareRadioButton.Text = "Square";
			// 
			// sawtoothRadioButton
			// 
			this.sawtoothRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.sawtoothRadioButton.Location = new System.Drawing.Point(8, 120);
			this.sawtoothRadioButton.Name = "sawtoothRadioButton";
			this.sawtoothRadioButton.Size = new System.Drawing.Size(80, 24);
			this.sawtoothRadioButton.TabIndex = 3;
			this.sawtoothRadioButton.Text = "Sawtooth";
			// 
			// signalTypeGroupBox
			// 
			this.signalTypeGroupBox.Controls.Add(this.sawtoothRadioButton);
			this.signalTypeGroupBox.Controls.Add(this.squareRadioButton);
			this.signalTypeGroupBox.Controls.Add(this.triangleRadioButton);
			this.signalTypeGroupBox.Controls.Add(this.sineRadioButton);
			this.signalTypeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.signalTypeGroupBox.Location = new System.Drawing.Point(14, 306);
			this.signalTypeGroupBox.Name = "signalTypeGroupBox";
			this.signalTypeGroupBox.Size = new System.Drawing.Size(104, 152);
			this.signalTypeGroupBox.TabIndex = 2;
			this.signalTypeGroupBox.TabStop = false;
			this.signalTypeGroupBox.Text = "Signal Type";
			// 
			// amplitudeLabel
			// 
			this.amplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.amplitudeLabel.Location = new System.Drawing.Point(16, 26);
			this.amplitudeLabel.Name = "amplitudeLabel";
			this.amplitudeLabel.Size = new System.Drawing.Size(72, 16);
			this.amplitudeLabel.TabIndex = 7;
			this.amplitudeLabel.Text = "Amplitude:";
			// 
			// frequencyLabel
			// 
			this.frequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.frequencyLabel.Location = new System.Drawing.Point(16, 61);
			this.frequencyLabel.Name = "frequencyLabel";
			this.frequencyLabel.Size = new System.Drawing.Size(88, 14);
			this.frequencyLabel.TabIndex = 9;
			this.frequencyLabel.Text = "Frequency:";
			// 
			// samplesLabel
			// 
			this.samplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.samplesLabel.Location = new System.Drawing.Point(16, 96);
			this.samplesLabel.Name = "samplesLabel";
			this.samplesLabel.Size = new System.Drawing.Size(88, 12);
			this.samplesLabel.TabIndex = 11;
			this.samplesLabel.Text = "Samples:";
			// 
			// offsetLabel
			// 
			this.offsetLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.offsetLabel.Location = new System.Drawing.Point(16, 128);
			this.offsetLabel.Name = "offsetLabel";
			this.offsetLabel.Size = new System.Drawing.Size(48, 17);
			this.offsetLabel.TabIndex = 13;
			this.offsetLabel.Text = "Offset:";
			// 
			// samplingRateLabel
			// 
			this.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.samplingRateLabel.Location = new System.Drawing.Point(16, 162);
			this.samplingRateLabel.Name = "samplingRateLabel";
			this.samplingRateLabel.Size = new System.Drawing.Size(88, 17);
			this.samplingRateLabel.TabIndex = 15;
			this.samplingRateLabel.Text = "Sampling Rate:";
			// 
			// generateButton
			// 
			this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.generateButton.Location = new System.Drawing.Point(14, 475);
			this.generateButton.Name = "generateButton";
			this.generateButton.Size = new System.Drawing.Size(104, 23);
			this.generateButton.TabIndex = 0;
			this.generateButton.Text = "Generate";
			this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
			// 
			// signalParametersGroupBox
			// 
			this.signalParametersGroupBox.Controls.Add(this.samplingRateNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.offsetNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.samplesNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.frequencyNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.amplitudeNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.amplitudeLabel);
			this.signalParametersGroupBox.Controls.Add(this.frequencyLabel);
			this.signalParametersGroupBox.Controls.Add(this.samplesLabel);
			this.signalParametersGroupBox.Controls.Add(this.offsetLabel);
			this.signalParametersGroupBox.Controls.Add(this.samplingRateLabel);
			this.signalParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.signalParametersGroupBox.Location = new System.Drawing.Point(126, 306);
			this.signalParametersGroupBox.Name = "signalParametersGroupBox";
			this.signalParametersGroupBox.Size = new System.Drawing.Size(210, 192);
			this.signalParametersGroupBox.TabIndex = 1;
			this.signalParametersGroupBox.TabStop = false;
			this.signalParametersGroupBox.Text = "Signal Parameters";
			// 
			// samplingRateNumericEdit
			// 
			this.samplingRateNumericEdit.Location = new System.Drawing.Point(112, 160);
			this.samplingRateNumericEdit.Name = "samplingRateNumericEdit";
			this.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.samplingRateNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.samplingRateNumericEdit.Size = new System.Drawing.Size(88, 20);
			this.samplingRateNumericEdit.TabIndex = 4;
			this.samplingRateNumericEdit.Value = 100;
			// 
			// offsetNumericEdit
			// 
			this.offsetNumericEdit.Location = new System.Drawing.Point(112, 126);
			this.offsetNumericEdit.Name = "offsetNumericEdit";
			this.offsetNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.offsetNumericEdit.Size = new System.Drawing.Size(88, 20);
			this.offsetNumericEdit.TabIndex = 3;
			// 
			// samplesNumericEdit
			// 
			this.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.samplesNumericEdit.Location = new System.Drawing.Point(112, 92);
			this.samplesNumericEdit.Name = "samplesNumericEdit";
			this.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.samplesNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.samplesNumericEdit.Size = new System.Drawing.Size(88, 20);
			this.samplesNumericEdit.TabIndex = 2;
			this.samplesNumericEdit.Value = 100;
			// 
			// frequencyNumericEdit
			// 
			this.frequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.frequencyNumericEdit.Location = new System.Drawing.Point(112, 58);
			this.frequencyNumericEdit.Name = "frequencyNumericEdit";
			this.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.frequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.frequencyNumericEdit.Size = new System.Drawing.Size(88, 20);
			this.frequencyNumericEdit.TabIndex = 1;
			this.frequencyNumericEdit.Value = 2;
			// 
			// amplitudeNumericEdit
			// 
			this.amplitudeNumericEdit.Location = new System.Drawing.Point(112, 24);
			this.amplitudeNumericEdit.Name = "amplitudeNumericEdit";
			this.amplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.amplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, 5);
			this.amplitudeNumericEdit.Size = new System.Drawing.Size(88, 20);
			this.amplitudeNumericEdit.TabIndex = 0;
			this.amplitudeNumericEdit.Value = 5;
			// 
			// signalWaveformGraph
			// 
			this.signalWaveformGraph.Caption = "Generated Signal";
			this.signalWaveformGraph.Location = new System.Drawing.Point(16, 16);
			this.signalWaveformGraph.Name = "signalWaveformGraph";
            this.signalWaveformGraph.UseColorGenerator = true;
			this.signalWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
																								  this.signalPlot});
			this.signalWaveformGraph.Size = new System.Drawing.Size(320, 272);
			this.signalWaveformGraph.TabIndex = 18;
			this.signalWaveformGraph.TabStop = false;
			this.signalWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
																						   this.samplesAxis});
			this.signalWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
																						   this.amplitudeAxis});
			// 
			// signalPlot
			// 
			this.signalPlot.XAxis = this.samplesAxis;
			this.signalPlot.YAxis = this.amplitudeAxis;
			// 
			// samplesAxis
			// 
			this.samplesAxis.Caption = "Number Of Samples";
			// 
			// amplitudeAxis
			// 
			this.amplitudeAxis.Caption = "Amplitude";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(349, 510);
			this.Controls.Add(this.signalWaveformGraph);
			this.Controls.Add(this.generateButton);
			this.Controls.Add(this.signalParametersGroupBox);
			this.Controls.Add(this.signalTypeGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(640, 640);
			this.MinimumSize = new System.Drawing.Size(355, 440);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Basic Signal Generation";
			this.signalTypeGroupBox.ResumeLayout(false);
			this.signalParametersGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.offsetNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.signalWaveformGraph)).EndInit();
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

        private void generateButton_Click(object sender, System.EventArgs e)
        {
			BasicFunctionGenerator functionGenerator 
                = new BasicFunctionGenerator(GetSelectedSignalType());            
			functionGenerator.Amplitude = amplitudeNumericEdit.Value;
			functionGenerator.Frequency = frequencyNumericEdit.Value;
			functionGenerator.NumberOfSamples = (int)samplesNumericEdit.Value;
			functionGenerator.Offset = offsetNumericEdit.Value;
			functionGenerator.SamplingRate = samplingRateNumericEdit.Value;

			signalPlot.PlotY(functionGenerator.Generate());		
        }

        private BasicFunctionGeneratorSignal GetSelectedSignalType()
        {
            if (sineRadioButton.Checked)
                return BasicFunctionGeneratorSignal.Sine;
            else if (triangleRadioButton.Checked)
                return BasicFunctionGeneratorSignal.Triangle;
            else if (squareRadioButton.Checked)
                return BasicFunctionGeneratorSignal.Square;
            else if (sawtoothRadioButton.Checked)
                return BasicFunctionGeneratorSignal.Sawtooth;
            else
                return BasicFunctionGeneratorSignal.Sine;
        }
    }
}
