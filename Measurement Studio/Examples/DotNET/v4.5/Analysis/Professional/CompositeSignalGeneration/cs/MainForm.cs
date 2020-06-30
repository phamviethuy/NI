//==================================================================================================
//
// Title      : MainForm.cs
// Purpose    : This program demonstrates the use of the Analysis SignalGenerator class
//              in forming composite signals.
//
//==================================================================================================

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis.SignalGeneration;

namespace NationalInstruments.Examples.CompositeSignalGeneration
{
	/// <summary>
    /// This program demonstrates the use of the Analysis SignalGenerator class
    /// in forming composite signals.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
    {
        // Private variables.
        private const int NumberOfSamples = 10;
        private const double FrequencyNumber = 50.0;

        private NationalInstruments.Analysis.SignalGeneration.SineSignal sineSignal1;
        private NationalInstruments.Analysis.SignalGeneration.SineSignal sineSignal2;
        private NationalInstruments.Analysis.SignalGeneration.WhiteNoiseSignal noiseSignal;
        private NationalInstruments.Analysis.SignalGeneration.SignalGenerator signalGen;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.GroupBox signal1GroupBox;
        private System.Windows.Forms.Label amp1Label;
        private System.Windows.Forms.GroupBox signal2GroupBox;
        private System.Windows.Forms.Label amp2Label;
        private System.Windows.Forms.Label freq1Label;
        private System.Windows.Forms.Label freq2Label;
        private System.Windows.Forms.GroupBox noiseGroupBox;
        private System.Windows.Forms.Label amp3Label;
        private System.Windows.Forms.Label phase1Label;
        private System.Windows.Forms.Label phase2Label;
        private NationalInstruments.UI.WindowsForms.Switch onOffSwitch;
        private System.Windows.Forms.Label onLabel;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.Timer updateTimer;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
		private NationalInstruments.UI.WindowsForms.NumericEdit amp1NumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit freq1NumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit phase1NumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit amp2NumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit freq2NumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit phase2NumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit amp3NumericEdit;
		private NationalInstruments.UI.WindowsForms.WaveformGraph compositeSignalWaveformGraph;
        private NationalInstruments.UI.WaveformPlot signalPlot;


		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            
            // Initialization.
            signalGen = new SignalGenerator(1.0, NumberOfSamples);
            sineSignal1 = new SineSignal();
            sineSignal2 = new SineSignal();
            noiseSignal = new WhiteNoiseSignal();
            signalGen.Signals.Add(sineSignal1);
            signalGen.Signals.Add(sineSignal2);
            signalGen.Signals.Add(noiseSignal);
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.updateTimer = new System.Windows.Forms.Timer(this.components);
			this.amp1Label = new System.Windows.Forms.Label();
			this.signal1GroupBox = new System.Windows.Forms.GroupBox();
			this.amp1NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.phase1Label = new System.Windows.Forms.Label();
			this.freq1Label = new System.Windows.Forms.Label();
			this.freq1NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.phase1NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.signal2GroupBox = new System.Windows.Forms.GroupBox();
			this.amp2NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.freq2NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.phase2NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.phase2Label = new System.Windows.Forms.Label();
			this.freq2Label = new System.Windows.Forms.Label();
			this.amp2Label = new System.Windows.Forms.Label();
			this.noiseGroupBox = new System.Windows.Forms.GroupBox();
			this.amp3NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.amp3Label = new System.Windows.Forms.Label();
			this.onOffSwitch = new NationalInstruments.UI.WindowsForms.Switch();
			this.onLabel = new System.Windows.Forms.Label();
			this.offLabel = new System.Windows.Forms.Label();
			this.compositeSignalWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
			this.signalPlot = new NationalInstruments.UI.WaveformPlot();
			this.xAxis1 = new NationalInstruments.UI.XAxis();
			this.yAxis1 = new NationalInstruments.UI.YAxis();
			this.signal1GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.amp1NumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.freq1NumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phase1NumericEdit)).BeginInit();
			this.signal2GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.amp2NumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.freq2NumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phase2NumericEdit)).BeginInit();
			this.noiseGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.amp3NumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.onOffSwitch)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.compositeSignalWaveformGraph)).BeginInit();
			this.SuspendLayout();
			// 
			// updateTimer
			// 
			this.updateTimer.Interval = 500;
			this.updateTimer.Tick += new System.EventHandler(this.Timer_Tick);
			// 
			// amp1Label
			// 
			this.amp1Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.amp1Label.Location = new System.Drawing.Point(16, 24);
			this.amp1Label.Name = "amp1Label";
			this.amp1Label.Size = new System.Drawing.Size(64, 16);
			this.amp1Label.TabIndex = 2;
			this.amp1Label.Text = "Amplitude:";
			// 
			// signal1GroupBox
			// 
			this.signal1GroupBox.Controls.Add(this.amp1NumericEdit);
			this.signal1GroupBox.Controls.Add(this.phase1Label);
			this.signal1GroupBox.Controls.Add(this.freq1Label);
			this.signal1GroupBox.Controls.Add(this.amp1Label);
			this.signal1GroupBox.Controls.Add(this.freq1NumericEdit);
			this.signal1GroupBox.Controls.Add(this.phase1NumericEdit);
			this.signal1GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.signal1GroupBox.Location = new System.Drawing.Point(16, 16);
			this.signal1GroupBox.Name = "signal1GroupBox";
			this.signal1GroupBox.Size = new System.Drawing.Size(208, 72);
			this.signal1GroupBox.TabIndex = 1;
			this.signal1GroupBox.TabStop = false;
			this.signal1GroupBox.Text = "Sine Signal 1";
			// 
			// amp1NumericEdit
			// 
			this.amp1NumericEdit.CoercionInterval = 0.5;
			this.amp1NumericEdit.Location = new System.Drawing.Point(16, 40);
			this.amp1NumericEdit.Name = "amp1NumericEdit";
			this.amp1NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.amp1NumericEdit.Range = new NationalInstruments.UI.Range(0, 5);
			this.amp1NumericEdit.Size = new System.Drawing.Size(56, 20);
			this.amp1NumericEdit.TabIndex = 0;
			this.amp1NumericEdit.Value = 3;
			this.amp1NumericEdit.ValueChanged += new System.EventHandler(this.amp1_ValueChanged);
			// 
			// phase1Label
			// 
			this.phase1Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.phase1Label.Location = new System.Drawing.Point(144, 24);
			this.phase1Label.Name = "phase1Label";
			this.phase1Label.Size = new System.Drawing.Size(40, 16);
			this.phase1Label.TabIndex = 6;
			this.phase1Label.Text = "Phase:";
			this.phase1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// freq1Label
			// 
			this.freq1Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.freq1Label.Location = new System.Drawing.Point(80, 24);
			this.freq1Label.Name = "freq1Label";
			this.freq1Label.Size = new System.Drawing.Size(64, 16);
			this.freq1Label.TabIndex = 4;
			this.freq1Label.Text = "Frequency:";
			// 
			// freq1NumericEdit
			// 
			this.freq1NumericEdit.CoercionInterval = 0.5;
			this.freq1NumericEdit.Location = new System.Drawing.Point(80, 40);
			this.freq1NumericEdit.Name = "freq1NumericEdit";
			this.freq1NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.freq1NumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.freq1NumericEdit.Size = new System.Drawing.Size(56, 20);
			this.freq1NumericEdit.TabIndex = 1;
			this.freq1NumericEdit.Value = 1;
			this.freq1NumericEdit.ValueChanged += new System.EventHandler(this.freq1_ValueChanged);
			// 
			// phase1NumericEdit
			// 
			this.phase1NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.phase1NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
			this.phase1NumericEdit.Location = new System.Drawing.Point(144, 40);
			this.phase1NumericEdit.Name = "phase1NumericEdit";
			this.phase1NumericEdit.Size = new System.Drawing.Size(56, 20);
			this.phase1NumericEdit.TabIndex = 2;
			this.phase1NumericEdit.TabStop = false;
			// 
			// signal2GroupBox
			// 
			this.signal2GroupBox.Controls.Add(this.amp2NumericEdit);
			this.signal2GroupBox.Controls.Add(this.freq2NumericEdit);
			this.signal2GroupBox.Controls.Add(this.phase2NumericEdit);
			this.signal2GroupBox.Controls.Add(this.phase2Label);
			this.signal2GroupBox.Controls.Add(this.freq2Label);
			this.signal2GroupBox.Controls.Add(this.amp2Label);
			this.signal2GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.signal2GroupBox.Location = new System.Drawing.Point(16, 104);
			this.signal2GroupBox.Name = "signal2GroupBox";
			this.signal2GroupBox.Size = new System.Drawing.Size(208, 72);
			this.signal2GroupBox.TabIndex = 2;
			this.signal2GroupBox.TabStop = false;
			this.signal2GroupBox.Text = "Sine Signal 2";
			// 
			// amp2NumericEdit
			// 
			this.amp2NumericEdit.CoercionInterval = 0.5;
			this.amp2NumericEdit.Location = new System.Drawing.Point(16, 40);
			this.amp2NumericEdit.Name = "amp2NumericEdit";
			this.amp2NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.amp2NumericEdit.Range = new NationalInstruments.UI.Range(0, 5);
			this.amp2NumericEdit.Size = new System.Drawing.Size(56, 20);
			this.amp2NumericEdit.TabIndex = 0;
			this.amp2NumericEdit.Value = 1;
			this.amp2NumericEdit.ValueChanged += new System.EventHandler(this.amp2_ValueChanged);
			// 
			// freq2NumericEdit
			// 
			this.freq2NumericEdit.CoercionInterval = 0.5;
			this.freq2NumericEdit.Location = new System.Drawing.Point(80, 40);
			this.freq2NumericEdit.Name = "freq2NumericEdit";
			this.freq2NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.freq2NumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.freq2NumericEdit.Size = new System.Drawing.Size(56, 20);
			this.freq2NumericEdit.TabIndex = 1;
			this.freq2NumericEdit.Value = 2.5;
			this.freq2NumericEdit.ValueChanged += new System.EventHandler(this.freq2_ValueChanged);
			// 
			// phase2NumericEdit
			// 
			this.phase2NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.phase2NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
			this.phase2NumericEdit.Location = new System.Drawing.Point(144, 40);
			this.phase2NumericEdit.Name = "phase2NumericEdit";
			this.phase2NumericEdit.Size = new System.Drawing.Size(56, 20);
			this.phase2NumericEdit.TabIndex = 2;
			this.phase2NumericEdit.TabStop = false;
			// 
			// phase2Label
			// 
			this.phase2Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.phase2Label.Location = new System.Drawing.Point(144, 24);
			this.phase2Label.Name = "phase2Label";
			this.phase2Label.Size = new System.Drawing.Size(40, 16);
			this.phase2Label.TabIndex = 9;
			this.phase2Label.Text = "Phase:";
			this.phase2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// freq2Label
			// 
			this.freq2Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.freq2Label.Location = new System.Drawing.Point(80, 24);
			this.freq2Label.Name = "freq2Label";
			this.freq2Label.Size = new System.Drawing.Size(64, 16);
			this.freq2Label.TabIndex = 6;
			this.freq2Label.Text = "Frequency:";
			// 
			// amp2Label
			// 
			this.amp2Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.amp2Label.Location = new System.Drawing.Point(16, 24);
			this.amp2Label.Name = "amp2Label";
			this.amp2Label.Size = new System.Drawing.Size(64, 16);
			this.amp2Label.TabIndex = 2;
			this.amp2Label.Text = "Amplitude:";
			// 
			// noiseGroupBox
			// 
			this.noiseGroupBox.Controls.Add(this.amp3NumericEdit);
			this.noiseGroupBox.Controls.Add(this.amp3Label);
			this.noiseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.noiseGroupBox.Location = new System.Drawing.Point(16, 184);
			this.noiseGroupBox.Name = "noiseGroupBox";
			this.noiseGroupBox.Size = new System.Drawing.Size(88, 72);
			this.noiseGroupBox.TabIndex = 3;
			this.noiseGroupBox.TabStop = false;
			this.noiseGroupBox.Text = "White Noise";
			// 
			// amp3NumericEdit
			// 
			this.amp3NumericEdit.CoercionInterval = 0.5;
			this.amp3NumericEdit.Location = new System.Drawing.Point(16, 40);
			this.amp3NumericEdit.Name = "amp3NumericEdit";
			this.amp3NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.amp3NumericEdit.Range = new NationalInstruments.UI.Range(0, 5);
			this.amp3NumericEdit.Size = new System.Drawing.Size(56, 20);
			this.amp3NumericEdit.TabIndex = 0;
			this.amp3NumericEdit.Value = 1;
			this.amp3NumericEdit.ValueChanged += new System.EventHandler(this.amp3_ValueChanged);
			// 
			// amp3Label
			// 
			this.amp3Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.amp3Label.Location = new System.Drawing.Point(16, 24);
			this.amp3Label.Name = "amp3Label";
			this.amp3Label.Size = new System.Drawing.Size(64, 16);
			this.amp3Label.TabIndex = 2;
			this.amp3Label.Text = "Amplitude:";
			// 
			// onOffSwitch
			// 
			this.onOffSwitch.Location = new System.Drawing.Point(184, 208);
			this.onOffSwitch.Name = "onOffSwitch";
			this.onOffSwitch.Size = new System.Drawing.Size(40, 48);
			this.onOffSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
			this.onOffSwitch.TabIndex = 0;
			this.onOffSwitch.ValueChanged += new System.EventHandler(this.onOffSwitch_ValueChanged);
			// 
			// onLabel
			// 
			this.onLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.onLabel.Location = new System.Drawing.Point(188, 196);
			this.onLabel.Name = "onLabel";
			this.onLabel.Size = new System.Drawing.Size(32, 16);
			this.onLabel.TabIndex = 7;
			this.onLabel.Text = "Start";
			this.onLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// offLabel
			// 
			this.offLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.offLabel.Location = new System.Drawing.Point(188, 252);
			this.offLabel.Name = "offLabel";
			this.offLabel.Size = new System.Drawing.Size(32, 16);
			this.offLabel.TabIndex = 1;
			this.offLabel.Text = "Stop";
			this.offLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// compositeSignalWaveformGraph
			// 
			this.compositeSignalWaveformGraph.Caption = "Composite Signal";
			this.compositeSignalWaveformGraph.Location = new System.Drawing.Point(232, 16);
			this.compositeSignalWaveformGraph.Name = "compositeSignalWaveformGraph";
            this.compositeSignalWaveformGraph.UseColorGenerator = true;
			this.compositeSignalWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
																										   this.signalPlot});
			this.compositeSignalWaveformGraph.Size = new System.Drawing.Size(280, 248);
			this.compositeSignalWaveformGraph.TabIndex = 9;
			this.compositeSignalWaveformGraph.TabStop = false;
			this.compositeSignalWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
																									this.xAxis1});
			this.compositeSignalWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
																									this.yAxis1});
			// 
			// signalPlot
			// 
			this.signalPlot.XAxis = this.xAxis1;
			this.signalPlot.YAxis = this.yAxis1;
			// 
			// xAxis1
			// 
			this.xAxis1.Caption = "Number Of Samples";
			// 
			// yAxis1
			// 
			this.yAxis1.Caption = "Amplitude";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(530, 288);
			this.Controls.Add(this.compositeSignalWaveformGraph);
			this.Controls.Add(this.offLabel);
			this.Controls.Add(this.onLabel);
			this.Controls.Add(this.onOffSwitch);
			this.Controls.Add(this.noiseGroupBox);
			this.Controls.Add(this.signal2GroupBox);
			this.Controls.Add(this.signal1GroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Composite Signal Generation ";
			this.signal1GroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.amp1NumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.freq1NumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phase1NumericEdit)).EndInit();
			this.signal2GroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.amp2NumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.freq2NumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phase2NumericEdit)).EndInit();
			this.noiseGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.amp3NumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.onOffSwitch)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.compositeSignalWaveformGraph)).EndInit();
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

        private void amp1_ValueChanged(object sender, System.EventArgs e)
        {
            if (updateTimer.Enabled)
                sineSignal1.Amplitude = amp1NumericEdit.Value;
        }

        private void amp2_ValueChanged(object sender, System.EventArgs e)
        {
            if (updateTimer.Enabled)
                sineSignal2.Amplitude = amp2NumericEdit.Value;
        }

        private void amp3_ValueChanged(object sender, System.EventArgs e)
        {
            if (updateTimer.Enabled)
                noiseSignal.Amplitude = amp3NumericEdit.Value;
        }

        private void freq1_ValueChanged(object sender, System.EventArgs e)
        {
            if (updateTimer.Enabled)
                sineSignal1.Frequency = freq1NumericEdit.Value/FrequencyNumber;
        }

        private void freq2_ValueChanged(object sender, System.EventArgs e)
        {
            if (updateTimer.Enabled)
                sineSignal2.Frequency = freq2NumericEdit.Value/FrequencyNumber;
        }

        private void onOffSwitch_ValueChanged(object sender, System.EventArgs e)
        {
            if(onOffSwitch.Value == true)
            {
                // Start running the program.
                sineSignal1.Amplitude = amp1NumericEdit.Value;
                sineSignal1.Frequency = freq1NumericEdit.Value/FrequencyNumber;
                sineSignal2.Amplitude = amp2NumericEdit.Value;
                sineSignal2.Frequency = freq2NumericEdit.Value/FrequencyNumber;
                noiseSignal.Amplitude = amp3NumericEdit.Value;

                updateTimer.Enabled = true;
                updateTimer.Start();
            }
            else
            {
                // Stop running the program.
                updateTimer.Stop();
                updateTimer.Enabled = false;
            }
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            phase1NumericEdit.Value= sineSignal1.Phase;
            phase2NumericEdit.Value= sineSignal2.Phase;
            signalPlot.PlotYAppend(signalGen.Generate());
        }
	}
}
