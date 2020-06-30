using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.NetworkFunction
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.ScatterPlot stimulusPlot;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private NationalInstruments.UI.ScatterPlot responsePlot;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label signalSourceLabel;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.Label numberOfSamplesLabel;
        private System.Windows.Forms.Label noiseAmplitudeLabel;
        private System.Windows.Forms.Label signalAmplitudeLabel;
        private System.Windows.Forms.Label filterDesignLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label lowerCutoffLabel;
        private System.Windows.Forms.Label filterTypeLabel;
        private System.Windows.Forms.Label higherCutoffLabel;
        private System.ComponentModel.Container components = null;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		// Global Variables
        double []waveform;
        double []xwave;
        double []xWaveform;
        double []noiseWaveform;
        double []crossPowerSpectrumMagnitude;
        double []crossPowerSpectrumPhase;
        double []frequencyResponseMagnitude;
        double []frequencyResponsePhase;
        double []coherence;
        double []impulseResponse;
        bool showStimulusClicked = false;
        bool showResponseClicked = false;
        bool impulseResponseClicked = false;
        bool powerSpectrumMagnitudeClicked = false;
        bool powerSpectrumPhaseClicked = false;
        bool frequencyResponseMagnitudeClicked = false;
        bool frequencyResponsePhaseClicked = false;
       
        private NationalInstruments.UI.ScatterPlot powerSpectrumMagnitudePlot;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.ScatterPlot frequencyResponsePhasePlot;
        private NationalInstruments.UI.ScatterPlot powerSpectrumPhasePlot;
        private System.Windows.Forms.Button plotStimulusButton;
        private System.Windows.Forms.Button plotResponseButton;
        private NationalInstruments.UI.ScatterPlot frequencyResponseMagnitudePlot;
        private NationalInstruments.UI.ScatterPlot impulseResponsePlot;
		private System.Windows.Forms.Label exampleDescriptionLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit noiseAmplitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit signalAmplitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit samplingRateNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit frequencyNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit lowerCutoffNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit orderNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit upperCutoffNumericEdit;
        private System.Windows.Forms.Button plotCrossPowerSpectrumMagnitudeButton;
        private System.Windows.Forms.Button plotFrequencyResponseMagnitudeButton;
        private System.Windows.Forms.Button plotFrequencyResponsePhaseButton;
        private System.Windows.Forms.Button plotCrossPowerSpectrumPhaseButton;
        private System.Windows.Forms.Button plotImpulseResponseButton;
        private NationalInstruments.UI.WindowsForms.ScatterGraph signalScatterGraph;
        private NationalInstruments.UI.WindowsForms.ScatterGraph magnitudeScatterGraph;
        private NationalInstruments.UI.WindowsForms.ScatterGraph phaseScatterGraph;
        private System.Windows.Forms.ComboBox signalSourceComboBox;
        private System.Windows.Forms.ComboBox filterTypeComboBox;
        private System.Windows.Forms.ComboBox filterDesignComboBox;
        private System.Windows.Forms.GroupBox signalSourceGroupBox;
        private System.Windows.Forms.GroupBox filterOrderGroupBox;
        double []filteredwave; 
      

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            signalSourceComboBox.SelectedIndex =0;
            filterTypeComboBox.SelectedIndex =0;
            filterDesignComboBox.SelectedIndex =0;
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
            this.signalScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.stimulusPlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.responsePlot = new NationalInstruments.UI.ScatterPlot();
            this.impulseResponsePlot = new NationalInstruments.UI.ScatterPlot();
            this.magnitudeScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.powerSpectrumMagnitudePlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.frequencyResponseMagnitudePlot = new NationalInstruments.UI.ScatterPlot();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.signalSourceComboBox = new System.Windows.Forms.ComboBox();
            this.signalSourceLabel = new System.Windows.Forms.Label();
            this.samplingRateLabel = new System.Windows.Forms.Label();
            this.numberOfSamplesLabel = new System.Windows.Forms.Label();
            this.noiseAmplitudeLabel = new System.Windows.Forms.Label();
            this.signalAmplitudeLabel = new System.Windows.Forms.Label();
            this.filterDesignLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.lowerCutoffLabel = new System.Windows.Forms.Label();
            this.filterTypeLabel = new System.Windows.Forms.Label();
            this.higherCutoffLabel = new System.Windows.Forms.Label();
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.filterDesignComboBox = new System.Windows.Forms.ComboBox();
            this.phaseScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.powerSpectrumPhasePlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.frequencyResponsePhasePlot = new NationalInstruments.UI.ScatterPlot();
            this.plotStimulusButton = new System.Windows.Forms.Button();
            this.plotResponseButton = new System.Windows.Forms.Button();
            this.plotCrossPowerSpectrumMagnitudeButton = new System.Windows.Forms.Button();
            this.plotFrequencyResponseMagnitudeButton = new System.Windows.Forms.Button();
            this.plotFrequencyResponsePhaseButton = new System.Windows.Forms.Button();
            this.plotCrossPowerSpectrumPhaseButton = new System.Windows.Forms.Button();
            this.plotImpulseResponseButton = new System.Windows.Forms.Button();
            this.signalSourceGroupBox = new System.Windows.Forms.GroupBox();
            this.noiseAmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.signalAmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.samplingRateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.frequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.filterOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.lowerCutoffNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.orderNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.upperCutoffNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.exampleDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.signalScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitudeScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseScatterGraph)).BeginInit();
            this.signalSourceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseAmplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalAmplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).BeginInit();
            this.filterOrderGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lowerCutoffNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperCutoffNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // signalScatterGraph
            // 
            this.signalScatterGraph.Location = new System.Drawing.Point(152, 8);
            this.signalScatterGraph.Name = "signalScatterGraph";
            this.signalScatterGraph.UseColorGenerator = true;
            this.signalScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                this.stimulusPlot,
                                                                                                this.responsePlot,
                                                                                                this.impulseResponsePlot});
            this.signalScatterGraph.Size = new System.Drawing.Size(432, 152);
            this.signalScatterGraph.TabIndex = 20;
            this.signalScatterGraph.TabStop = false;
            this.signalScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                          this.xAxis});
            this.signalScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                          this.yAxis});
            // 
            // stimulusPlot
            // 
            this.stimulusPlot.XAxis = this.xAxis;
            this.stimulusPlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.Caption = "Seconds";
            // 
            // yAxis
            // 
            this.yAxis.Caption = "Amplitude";
            // 
            // responsePlot
            // 
            this.responsePlot.XAxis = this.xAxis;
            this.responsePlot.YAxis = this.yAxis;
            // 
            // impulseResponsePlot
            // 
            this.impulseResponsePlot.XAxis = this.xAxis;
            this.impulseResponsePlot.YAxis = this.yAxis;
            // 
            // magnitudeScatterGraph
            // 
            this.magnitudeScatterGraph.Caption = "Magnitude Plot";
            this.magnitudeScatterGraph.Location = new System.Drawing.Point(152, 168);
            this.magnitudeScatterGraph.Name = "magnitudeScatterGraph";
            this.magnitudeScatterGraph.UseColorGenerator = true;
            this.magnitudeScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                   this.powerSpectrumMagnitudePlot,
                                                                                                   this.frequencyResponseMagnitudePlot});
            this.magnitudeScatterGraph.Size = new System.Drawing.Size(432, 152);
            this.magnitudeScatterGraph.TabIndex = 21;
            this.magnitudeScatterGraph.TabStop = false;
            this.magnitudeScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                             this.xAxis2});
            this.magnitudeScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                             this.yAxis2});
            // 
            // powerSpectrumMagnitudePlot
            // 
            this.powerSpectrumMagnitudePlot.XAxis = this.xAxis2;
            this.powerSpectrumMagnitudePlot.YAxis = this.yAxis2;
            // 
            // xAxis2
            // 
            this.xAxis2.Caption = "Frequency";
            // 
            // yAxis2
            // 
            this.yAxis2.Caption = "Magnitude";
            // 
            // frequencyResponseMagnitudePlot
            // 
            this.frequencyResponseMagnitudePlot.XAxis = this.xAxis2;
            this.frequencyResponseMagnitudePlot.YAxis = this.yAxis2;
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.Enabled = false;
            this.frequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.frequencyLabel.Location = new System.Drawing.Point(16, 64);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(95, 16);
            this.frequencyLabel.TabIndex = 33;
            this.frequencyLabel.Text = "Frequency:";
            // 
            // signalSourceComboBox
            // 
            this.signalSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signalSourceComboBox.Items.AddRange(new object[] {
                                                                      "Impulse",
                                                                      "Sine",
                                                                      "Cosine",
                                                                      "Square",
                                                                      "Triangle",
                                                                      "SawTooth"});
            this.signalSourceComboBox.Location = new System.Drawing.Point(16, 32);
            this.signalSourceComboBox.Name = "signalSourceComboBox";
            this.signalSourceComboBox.Size = new System.Drawing.Size(103, 21);
            this.signalSourceComboBox.TabIndex = 0;
            this.signalSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.signalSource_SelectedIndexChanged);
            // 
            // signalSourceLabel
            // 
            this.signalSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signalSourceLabel.Location = new System.Drawing.Point(16, 16);
            this.signalSourceLabel.Name = "signalSourceLabel";
            this.signalSourceLabel.Size = new System.Drawing.Size(87, 16);
            this.signalSourceLabel.TabIndex = 31;
            this.signalSourceLabel.Text = "Signal Source:";
            // 
            // samplingRateLabel
            // 
            this.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplingRateLabel.Location = new System.Drawing.Point(16, 112);
            this.samplingRateLabel.Name = "samplingRateLabel";
            this.samplingRateLabel.Size = new System.Drawing.Size(103, 16);
            this.samplingRateLabel.TabIndex = 29;
            this.samplingRateLabel.Text = "Sampling Rate:";
            // 
            // numberOfSamplesLabel
            // 
            this.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numberOfSamplesLabel.Location = new System.Drawing.Point(16, 160);
            this.numberOfSamplesLabel.Name = "numberOfSamplesLabel";
            this.numberOfSamplesLabel.Size = new System.Drawing.Size(111, 16);
            this.numberOfSamplesLabel.TabIndex = 26;
            this.numberOfSamplesLabel.Text = "Number Of Samples:";
            // 
            // noiseAmplitudeLabel
            // 
            this.noiseAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noiseAmplitudeLabel.Location = new System.Drawing.Point(16, 256);
            this.noiseAmplitudeLabel.Name = "noiseAmplitudeLabel";
            this.noiseAmplitudeLabel.Size = new System.Drawing.Size(111, 16);
            this.noiseAmplitudeLabel.TabIndex = 27;
            this.noiseAmplitudeLabel.Text = "Noise Amplitude:";
            // 
            // signalAmplitudeLabel
            // 
            this.signalAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signalAmplitudeLabel.Location = new System.Drawing.Point(16, 208);
            this.signalAmplitudeLabel.Name = "signalAmplitudeLabel";
            this.signalAmplitudeLabel.Size = new System.Drawing.Size(103, 16);
            this.signalAmplitudeLabel.TabIndex = 28;
            this.signalAmplitudeLabel.Text = "Signal Amplitude:";
            // 
            // filterDesignLabel
            // 
            this.filterDesignLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filterDesignLabel.Location = new System.Drawing.Point(16, 64);
            this.filterDesignLabel.Name = "filterDesignLabel";
            this.filterDesignLabel.Size = new System.Drawing.Size(88, 16);
            this.filterDesignLabel.TabIndex = 41;
            this.filterDesignLabel.Text = "Filter Design:";
            // 
            // orderLabel
            // 
            this.orderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.orderLabel.Location = new System.Drawing.Point(16, 112);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(40, 16);
            this.orderLabel.TabIndex = 44;
            this.orderLabel.Text = "Order:";
            // 
            // lowerCutoffLabel
            // 
            this.lowerCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lowerCutoffLabel.Location = new System.Drawing.Point(16, 160);
            this.lowerCutoffLabel.Name = "lowerCutoffLabel";
            this.lowerCutoffLabel.Size = new System.Drawing.Size(88, 16);
            this.lowerCutoffLabel.TabIndex = 47;
            this.lowerCutoffLabel.Text = "Lower Cutoff:";
            // 
            // filterTypeLabel
            // 
            this.filterTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filterTypeLabel.Location = new System.Drawing.Point(16, 16);
            this.filterTypeLabel.Name = "filterTypeLabel";
            this.filterTypeLabel.Size = new System.Drawing.Size(88, 16);
            this.filterTypeLabel.TabIndex = 46;
            this.filterTypeLabel.Text = "Filter Type:";
            // 
            // higherCutoffLabel
            // 
            this.higherCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.higherCutoffLabel.Location = new System.Drawing.Point(16, 208);
            this.higherCutoffLabel.Name = "higherCutoffLabel";
            this.higherCutoffLabel.Size = new System.Drawing.Size(88, 16);
            this.higherCutoffLabel.TabIndex = 37;
            this.higherCutoffLabel.Text = "Upper Cutoff:";
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.Items.AddRange(new object[] {
                                                                    "Lowpass",
                                                                    "Highpass",
                                                                    "Bandpass",
                                                                    "Bandstop"});
            this.filterTypeComboBox.Location = new System.Drawing.Point(16, 32);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(104, 21);
            this.filterTypeComboBox.TabIndex = 0;
            this.filterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.filterType_SelectedIndexChanged);
            // 
            // filterDesignComboBox
            // 
            this.filterDesignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterDesignComboBox.Items.AddRange(new object[] {
                                                                      "Elliptic",
                                                                      "Bessel",
                                                                      "Butterworth",
                                                                      "Chebyshev",
                                                                      "Inv Chebyshev"});
            this.filterDesignComboBox.Location = new System.Drawing.Point(16, 80);
            this.filterDesignComboBox.Name = "filterDesignComboBox";
            this.filterDesignComboBox.Size = new System.Drawing.Size(104, 21);
            this.filterDesignComboBox.TabIndex = 1;
            this.filterDesignComboBox.SelectedIndexChanged += new System.EventHandler(this.filterDesign_SelectedIndexChanged);
            // 
            // phaseScatterGraph
            // 
            this.phaseScatterGraph.Caption = "Phase Plot";
            this.phaseScatterGraph.Location = new System.Drawing.Point(152, 328);
            this.phaseScatterGraph.Name = "phaseScatterGraph";
            this.phaseScatterGraph.UseColorGenerator = true;
            this.phaseScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                               this.powerSpectrumPhasePlot,
                                                                                               this.frequencyResponsePhasePlot});
            this.phaseScatterGraph.Size = new System.Drawing.Size(432, 152);
            this.phaseScatterGraph.TabIndex = 48;
            this.phaseScatterGraph.TabStop = false;
            this.phaseScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                         this.xAxis1});
            this.phaseScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                         this.yAxis1});
            // 
            // powerSpectrumPhasePlot
            // 
            this.powerSpectrumPhasePlot.XAxis = this.xAxis1;
            this.powerSpectrumPhasePlot.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "Frequency";
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Phase";
            // 
            // frequencyResponsePhasePlot
            // 
            this.frequencyResponsePhasePlot.XAxis = this.xAxis1;
            this.frequencyResponsePhasePlot.YAxis = this.yAxis1;
            // 
            // plotStimulusButton
            // 
            this.plotStimulusButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotStimulusButton.Location = new System.Drawing.Point(600, 48);
            this.plotStimulusButton.Name = "plotStimulusButton";
            this.plotStimulusButton.Size = new System.Drawing.Size(128, 24);
            this.plotStimulusButton.TabIndex = 0;
            this.plotStimulusButton.Text = " Show Stimulus ";
            this.plotStimulusButton.Click += new System.EventHandler(this.plotStimulusButton_Click);
            // 
            // plotResponseButton
            // 
            this.plotResponseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotResponseButton.Location = new System.Drawing.Point(600, 80);
            this.plotResponseButton.Name = "plotResponseButton";
            this.plotResponseButton.Size = new System.Drawing.Size(128, 24);
            this.plotResponseButton.TabIndex = 1;
            this.plotResponseButton.Text = "Show Response";
            this.plotResponseButton.Click += new System.EventHandler(this.plotResponseButton_Click);
            // 
            // plotCrossPowerSpectrumMagnitudeButton
            // 
            this.plotCrossPowerSpectrumMagnitudeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotCrossPowerSpectrumMagnitudeButton.Location = new System.Drawing.Point(600, 216);
            this.plotCrossPowerSpectrumMagnitudeButton.Name = "plotCrossPowerSpectrumMagnitudeButton";
            this.plotCrossPowerSpectrumMagnitudeButton.Size = new System.Drawing.Size(128, 32);
            this.plotCrossPowerSpectrumMagnitudeButton.TabIndex = 3;
            this.plotCrossPowerSpectrumMagnitudeButton.Text = "Cross Power Spectrum Magnitude";
            this.plotCrossPowerSpectrumMagnitudeButton.Click += new System.EventHandler(this.plotCrossPowerSpectrumMagnitude_Click);
            // 
            // plotFrequencyResponseMagnitudeButton
            // 
            this.plotFrequencyResponseMagnitudeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotFrequencyResponseMagnitudeButton.Location = new System.Drawing.Point(600, 256);
            this.plotFrequencyResponseMagnitudeButton.Name = "plotFrequencyResponseMagnitudeButton";
            this.plotFrequencyResponseMagnitudeButton.Size = new System.Drawing.Size(128, 32);
            this.plotFrequencyResponseMagnitudeButton.TabIndex = 4;
            this.plotFrequencyResponseMagnitudeButton.Text = "Frequency Response Magnitude";
            this.plotFrequencyResponseMagnitudeButton.Click += new System.EventHandler(this.plotFrequencyResponseMagnitude_Click);
            // 
            // plotFrequencyResponsePhaseButton
            // 
            this.plotFrequencyResponsePhaseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotFrequencyResponsePhaseButton.Location = new System.Drawing.Point(600, 416);
            this.plotFrequencyResponsePhaseButton.Name = "plotFrequencyResponsePhaseButton";
            this.plotFrequencyResponsePhaseButton.Size = new System.Drawing.Size(128, 32);
            this.plotFrequencyResponsePhaseButton.TabIndex = 6;
            this.plotFrequencyResponsePhaseButton.Text = "Frequency Response Phase";
            this.plotFrequencyResponsePhaseButton.Click += new System.EventHandler(this.plotFrequencyResponsePhase_Click);
            // 
            // plotCrossPowerSpectrumPhaseButton
            // 
            this.plotCrossPowerSpectrumPhaseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotCrossPowerSpectrumPhaseButton.Location = new System.Drawing.Point(600, 376);
            this.plotCrossPowerSpectrumPhaseButton.Name = "plotCrossPowerSpectrumPhaseButton";
            this.plotCrossPowerSpectrumPhaseButton.Size = new System.Drawing.Size(128, 32);
            this.plotCrossPowerSpectrumPhaseButton.TabIndex = 5;
            this.plotCrossPowerSpectrumPhaseButton.Text = "Cross Power Spectrum Phase";
            this.plotCrossPowerSpectrumPhaseButton.Click += new System.EventHandler(this.plotCrossPowerSpectrumPhase_Click);
            // 
            // plotImpulseResponseButton
            // 
            this.plotImpulseResponseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotImpulseResponseButton.Location = new System.Drawing.Point(600, 112);
            this.plotImpulseResponseButton.Name = "plotImpulseResponseButton";
            this.plotImpulseResponseButton.Size = new System.Drawing.Size(128, 24);
            this.plotImpulseResponseButton.TabIndex = 2;
            this.plotImpulseResponseButton.Text = "Impulse Response";
            this.plotImpulseResponseButton.Click += new System.EventHandler(this.plotImpulseResponse_Click);
            // 
            // signalSourceGroupBox
            // 
            this.signalSourceGroupBox.Controls.Add(this.noiseAmplitudeNumericEdit);
            this.signalSourceGroupBox.Controls.Add(this.signalAmplitudeNumericEdit);
            this.signalSourceGroupBox.Controls.Add(this.numberOfSamplesNumericEdit);
            this.signalSourceGroupBox.Controls.Add(this.samplingRateNumericEdit);
            this.signalSourceGroupBox.Controls.Add(this.frequencyNumericEdit);
            this.signalSourceGroupBox.Controls.Add(this.frequencyLabel);
            this.signalSourceGroupBox.Controls.Add(this.signalSourceComboBox);
            this.signalSourceGroupBox.Controls.Add(this.signalSourceLabel);
            this.signalSourceGroupBox.Controls.Add(this.samplingRateLabel);
            this.signalSourceGroupBox.Controls.Add(this.numberOfSamplesLabel);
            this.signalSourceGroupBox.Controls.Add(this.noiseAmplitudeLabel);
            this.signalSourceGroupBox.Controls.Add(this.signalAmplitudeLabel);
            this.signalSourceGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signalSourceGroupBox.Location = new System.Drawing.Point(8, 0);
            this.signalSourceGroupBox.Name = "signalSourceGroupBox";
            this.signalSourceGroupBox.Size = new System.Drawing.Size(136, 304);
            this.signalSourceGroupBox.TabIndex = 7;
            this.signalSourceGroupBox.TabStop = false;
            this.signalSourceGroupBox.Text = "Signal Parameters";
            // 
            // noiseAmplitudeNumericEdit
            // 
            this.noiseAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.noiseAmplitudeNumericEdit.Location = new System.Drawing.Point(16, 272);
            this.noiseAmplitudeNumericEdit.Name = "noiseAmplitudeNumericEdit";
            this.noiseAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.noiseAmplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.noiseAmplitudeNumericEdit.Size = new System.Drawing.Size(103, 20);
            this.noiseAmplitudeNumericEdit.TabIndex = 5;
            this.noiseAmplitudeNumericEdit.Value = 0.01;
            this.noiseAmplitudeNumericEdit.ValueChanged += new System.EventHandler(this.noiseAmplitude_ValueChanged);
            // 
            // signalAmplitudeNumericEdit
            // 
            this.signalAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.signalAmplitudeNumericEdit.Location = new System.Drawing.Point(16, 224);
            this.signalAmplitudeNumericEdit.Name = "signalAmplitudeNumericEdit";
            this.signalAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.signalAmplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.signalAmplitudeNumericEdit.Size = new System.Drawing.Size(103, 20);
            this.signalAmplitudeNumericEdit.TabIndex = 4;
            this.signalAmplitudeNumericEdit.Value = 1;
            this.signalAmplitudeNumericEdit.ValueChanged += new System.EventHandler(this.signalAmplitude_ValueChanged);
            // 
            // numberOfSamplesNumericEdit
            // 
            this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(16, 176);
            this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
            this.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfSamplesNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(103, 20);
            this.numberOfSamplesNumericEdit.TabIndex = 3;
            this.numberOfSamplesNumericEdit.Value = 100;
            this.numberOfSamplesNumericEdit.ValueChanged += new System.EventHandler(this.numberOfSamples_ValueChanged);
            // 
            // samplingRateNumericEdit
            // 
            this.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.samplingRateNumericEdit.Location = new System.Drawing.Point(16, 128);
            this.samplingRateNumericEdit.Name = "samplingRateNumericEdit";
            this.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.samplingRateNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.samplingRateNumericEdit.Size = new System.Drawing.Size(103, 20);
            this.samplingRateNumericEdit.TabIndex = 2;
            this.samplingRateNumericEdit.Value = 1000;
            this.samplingRateNumericEdit.ValueChanged += new System.EventHandler(this.samplingRate_ValueChanged);
            // 
            // frequencyNumericEdit
            // 
            this.frequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.frequencyNumericEdit.Location = new System.Drawing.Point(16, 80);
            this.frequencyNumericEdit.Name = "frequencyNumericEdit";
            this.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.frequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.frequencyNumericEdit.Size = new System.Drawing.Size(103, 20);
            this.frequencyNumericEdit.TabIndex = 1;
            this.frequencyNumericEdit.Value = 100;
            this.frequencyNumericEdit.ValueChanged += new System.EventHandler(this.frequency_ValueChanged);
            // 
            // filterOrderGroupBox
            // 
            this.filterOrderGroupBox.Controls.Add(this.lowerCutoffNumericEdit);
            this.filterOrderGroupBox.Controls.Add(this.orderNumericEdit);
            this.filterOrderGroupBox.Controls.Add(this.filterDesignLabel);
            this.filterOrderGroupBox.Controls.Add(this.orderLabel);
            this.filterOrderGroupBox.Controls.Add(this.lowerCutoffLabel);
            this.filterOrderGroupBox.Controls.Add(this.filterTypeLabel);
            this.filterOrderGroupBox.Controls.Add(this.higherCutoffLabel);
            this.filterOrderGroupBox.Controls.Add(this.filterTypeComboBox);
            this.filterOrderGroupBox.Controls.Add(this.filterDesignComboBox);
            this.filterOrderGroupBox.Controls.Add(this.upperCutoffNumericEdit);
            this.filterOrderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filterOrderGroupBox.Location = new System.Drawing.Point(8, 312);
            this.filterOrderGroupBox.Name = "filterOrderGroupBox";
            this.filterOrderGroupBox.Size = new System.Drawing.Size(136, 264);
            this.filterOrderGroupBox.TabIndex = 8;
            this.filterOrderGroupBox.TabStop = false;
            this.filterOrderGroupBox.Text = "Filter Parameters";
            // 
            // lowerCutoffNumericEdit
            // 
            this.lowerCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.lowerCutoffNumericEdit.Location = new System.Drawing.Point(16, 175);
            this.lowerCutoffNumericEdit.Name = "lowerCutoffNumericEdit";
            this.lowerCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.lowerCutoffNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.lowerCutoffNumericEdit.Size = new System.Drawing.Size(104, 20);
            this.lowerCutoffNumericEdit.TabIndex = 49;
            this.lowerCutoffNumericEdit.Value = 250;
            this.lowerCutoffNumericEdit.ValueChanged += new System.EventHandler(this.lowerCutoff_ValueChanged);
            // 
            // orderNumericEdit
            // 
            this.orderNumericEdit.Location = new System.Drawing.Point(16, 128);
            this.orderNumericEdit.Name = "orderNumericEdit";
            this.orderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.orderNumericEdit.Range = new NationalInstruments.UI.Range(2, System.Double.PositiveInfinity);
            this.orderNumericEdit.Size = new System.Drawing.Size(104, 20);
            this.orderNumericEdit.TabIndex = 48;
            this.orderNumericEdit.Value = 2;
            this.orderNumericEdit.ValueChanged += new System.EventHandler(this.order_ValueChanged);
            // 
            // upperCutoffNumericEdit
            // 
            this.upperCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.upperCutoffNumericEdit.Location = new System.Drawing.Point(16, 224);
            this.upperCutoffNumericEdit.Name = "upperCutoffNumericEdit";
            this.upperCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.upperCutoffNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.upperCutoffNumericEdit.Size = new System.Drawing.Size(104, 20);
            this.upperCutoffNumericEdit.TabIndex = 49;
            this.upperCutoffNumericEdit.Value = 450;
            this.upperCutoffNumericEdit.ValueChanged += new System.EventHandler(this.upperCutoff_ValueChanged);
            // 
            // exampleDescriptionLabel
            // 
            this.exampleDescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exampleDescriptionLabel.Location = new System.Drawing.Point(160, 496);
            this.exampleDescriptionLabel.Name = "exampleDescriptionLabel";
            this.exampleDescriptionLabel.Size = new System.Drawing.Size(424, 40);
            this.exampleDescriptionLabel.TabIndex = 53;
            this.exampleDescriptionLabel.Text = "This example calculates network transfer functions from stimulus and response dat" +
                "a. Cross Power Spectrum and Transfer functions between stimulus and response are" +
                " computed and their results are shown in the corresponding graphs.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(738, 584);
            this.Controls.Add(this.exampleDescriptionLabel);
            this.Controls.Add(this.filterOrderGroupBox);
            this.Controls.Add(this.signalSourceGroupBox);
            this.Controls.Add(this.plotStimulusButton);
            this.Controls.Add(this.phaseScatterGraph);
            this.Controls.Add(this.magnitudeScatterGraph);
            this.Controls.Add(this.signalScatterGraph);
            this.Controls.Add(this.plotResponseButton);
            this.Controls.Add(this.plotCrossPowerSpectrumMagnitudeButton);
            this.Controls.Add(this.plotFrequencyResponseMagnitudeButton);
            this.Controls.Add(this.plotFrequencyResponsePhaseButton);
            this.Controls.Add(this.plotCrossPowerSpectrumPhaseButton);
            this.Controls.Add(this.plotImpulseResponseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Function ";
            ((System.ComponentModel.ISupportInitialize)(this.signalScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitudeScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseScatterGraph)).EndInit();
            this.signalSourceGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noiseAmplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signalAmplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).EndInit();
            this.filterOrderGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lowerCutoffNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperCutoffNumericEdit)).EndInit();
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

       
        // Generation of signal source.
        void GenerateSignalSource()
        {
            waveform = new double[(int)numberOfSamplesNumericEdit.Value];
            xwave = new double[(int)numberOfSamplesNumericEdit.Value];
            int i;
            
            switch(signalSourceComboBox.SelectedIndex)
            {
                case 0: // Impulse.
                default:
                    waveform = PatternGeneration.Impulse((int)numberOfSamplesNumericEdit.Value, (double)signalAmplitudeNumericEdit.Value, 0); 
                    break;
                case 1: // Sin Wave.
                    SineSignal sin = new SineSignal((double)frequencyNumericEdit.Value, (double)signalAmplitudeNumericEdit.Value, 0.0);
                    waveform = sin.Generate((double)samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
                case 2: // Cos Wave.
                    SineSignal cos = new SineSignal((double)frequencyNumericEdit.Value, (double)signalAmplitudeNumericEdit.Value, 90.0);
                    waveform = cos.Generate((double)samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
                case 3: // Sqaure.
                    SquareSignal square = new SquareSignal((double)frequencyNumericEdit.Value, (double)signalAmplitudeNumericEdit.Value);
                    waveform = square.Generate((double)samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
                case 4: // Triangle. 
                    TriangleSignal triangle = new TriangleSignal((double)frequencyNumericEdit.Value, (double)signalAmplitudeNumericEdit.Value);
                    waveform = triangle.Generate((double)samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
                case 5: // SawTooth.
                    SawtoothSignal sawtooth = new SawtoothSignal((double)frequencyNumericEdit.Value, (double)signalAmplitudeNumericEdit.Value);
                    waveform = sawtooth.Generate((double)samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
            }
            for (i=0; i<(int)numberOfSamplesNumericEdit.Value; i++)
            {
                xwave[i] = i*1/(double)samplingRateNumericEdit.Value;  
            }
           
        }

        // Filter signal with the selected filter.
        void FilterSignal(double []waveform)
        {
            filteredwave = new double[(int)numberOfSamplesNumericEdit.Value];

            switch(filterDesignComboBox.SelectedIndex)
            {
                case 0: // Filter selected is elliptic.
                switch(filterTypeComboBox.SelectedIndex)
                {
                    case 0: // elliptic lowpass
                        EllipticLowpassFilter ellipticLowpass = new EllipticLowpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, 1, 60.0);
                        filteredwave = ellipticLowpass.FilterData(waveform);
                        break;
                    case 1: // elliptic highpass
                        EllipticHighpassFilter ellipticHighpass = new EllipticHighpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, 1, 60.0);
                        filteredwave = ellipticHighpass.FilterData(waveform);
                        break;
                    case 2: // elliptic bandpass
                        EllipticBandpassFilter ellipticBandpass = new EllipticBandpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value, 1, 60.0);
                        filteredwave = ellipticBandpass.FilterData(waveform);
                        break;
                    case 3: // elliptic bandstop
                        EllipticBandstopFilter ellipticBandstop = new EllipticBandstopFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value, 1, 60.0);
                        filteredwave = ellipticBandstop.FilterData(waveform);
                        break;
                }
                    break;
                case 1: // Bessel filter is selected.
                switch(filterTypeComboBox.SelectedIndex)
                {
                    case 0: // bessel lowpass
                        BesselLowpassFilter besselLowpass = new BesselLowpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value,(double)lowerCutoffNumericEdit.Value);
                        filteredwave = besselLowpass.FilterData(waveform);
                        break;
                    case 1: // bessel highpass
                        BesselHighpassFilter besselHighpass = new BesselHighpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value);
                        filteredwave = besselHighpass.FilterData(waveform);
                        break;
                    case 2: // bessel bandpass
                        BesselBandpassFilter besselBandpass = new BesselBandpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value);
                        filteredwave = besselBandpass.FilterData(waveform);
                        break;
                    case 3: // bessel bandstop
                        BesselBandstopFilter besselBandstop = new BesselBandstopFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value);
                        filteredwave = besselBandstop.FilterData(waveform);
                        break;
                }
                    break;
                case 2: // Butterworth filter is selected.
                switch(filterTypeComboBox.SelectedIndex)
                {
                    case 0: // butterworth lowpass
                        ButterworthLowpassFilter butterworthLowpass = new ButterworthLowpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value,(double)lowerCutoffNumericEdit.Value);
                        filteredwave = butterworthLowpass.FilterData(waveform);
                        break;
                    case 1: // butterworth highpass
                        ButterworthHighpassFilter butterworthHighpass = new ButterworthHighpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value);
                        filteredwave = butterworthHighpass.FilterData(waveform);
                        break;
                    case 2: // butterworth bandpass
                        ButterworthBandpassFilter butterworthBandpass = new ButterworthBandpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value);
                        filteredwave = butterworthBandpass.FilterData(waveform);
                        break;
                    case 3: // butterworth bandstop
                        ButterworthBandstopFilter butterworthBandstop = new ButterworthBandstopFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value);
                        filteredwave = butterworthBandstop.FilterData(waveform);
                        break;
                }
                    break;
                case 3: // Chebyshev filter is selected.
                switch(filterTypeComboBox.SelectedIndex)
                {
                    case 0: // chebyshev lowpass
                        ChebyshevLowpassFilter chebyshevLowpass = new ChebyshevLowpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value,(double)lowerCutoffNumericEdit.Value, 1.0);
                        filteredwave = chebyshevLowpass.FilterData(waveform);
                        break;
                    case 1: // chebyshev highpass
                        ChebyshevHighpassFilter chebyshevHighpass = new ChebyshevHighpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, 1.0);
                        filteredwave = chebyshevHighpass.FilterData(waveform);
                        break;
                    case 2: // chebyshev bandpass
                        ChebyshevBandpassFilter chebyshevBandpass = new ChebyshevBandpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value, 1.0);
                        filteredwave = chebyshevBandpass.FilterData(waveform);
                        break;
                    case 3: // chebyshev bandstop 
                        ChebyshevBandstopFilter chebyshevBandstop = new ChebyshevBandstopFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value, 1.0);
                        filteredwave = chebyshevBandstop.FilterData(noiseWaveform);
                        break;
                }
                    break;
                case 4: // Inverse chebyshev filter is selected.
                switch(filterTypeComboBox.SelectedIndex)
                {
                    case 0: // Inverse chebyshev lowpass
                        InverseChebyshevLowpassFilter inverseChebyshevLowpass = new InverseChebyshevLowpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value,(double)lowerCutoffNumericEdit.Value, 60.0);
                        filteredwave = inverseChebyshevLowpass.FilterData(waveform);
                        break;
                    case 1: // Inverse chebyshev highpass.
                        InverseChebyshevHighpassFilter inverseChebyshevHighpass = new InverseChebyshevHighpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, 60.0);
                        filteredwave = inverseChebyshevHighpass.FilterData(waveform);
                        break;
                    case 2: // Inverse chebyshev bandpass
                        InverseChebyshevBandpassFilter inverseChebyshevBandpass = new InverseChebyshevBandpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value, 60.0);
                        filteredwave = inverseChebyshevBandpass.FilterData(waveform);
                        break;
                    case 3: // Inverse chebyshev bandstop
                        InverseChebyshevBandstopFilter inverseChebyshevBandstop = new InverseChebyshevBandstopFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, (double)upperCutoffNumericEdit.Value, 60.0);
                        filteredwave = inverseChebyshevBandstop.FilterData(waveform);
                        break;
                }
                    break;
                default:
                    EllipticLowpassFilter ellipticLowpassDefault = new EllipticLowpassFilter((int)orderNumericEdit.Value, (double)samplingRateNumericEdit.Value, (double)lowerCutoffNumericEdit.Value, 1.0, 60.0);
                    filteredwave = ellipticLowpassDefault.FilterData(waveform);
                    break;
            }
        }
        // Mix noise to the signal.
        void MixNoiseToSignal()
        {
            noiseWaveform = new double[(int)numberOfSamplesNumericEdit.Value];
            int i;
            // Create white noise of specified amplitude.
            WhiteNoiseSignal whiteNoise = new WhiteNoiseSignal((double)noiseAmplitudeNumericEdit.Value, 1);
            noiseWaveform = whiteNoise.Generate((double)samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
            // Add noise to signal.
            for (i=0; i<(int)numberOfSamplesNumericEdit.Value; i++)
            {
                noiseWaveform[i] = noiseWaveform[i] + waveform[i];
            }
        }

        // Application of network functions.
        bool CalculateNetworkFunction()
        {
            int i;
            double [,]stimulusSignal;
            double [,]responseSignal;
            
            xWaveform = new double[(int)numberOfSamplesNumericEdit.Value/2];
            double df;

            try
            {
                GenerateSignalSource(); // generate signal source
                MixNoiseToSignal();   // Mix noise to signal to create noisy signal.
            
                FilterSignal(noiseWaveform); // filter the noisy signal through the filter selected by the user.
                stimulusSignal = new double[1, (int)numberOfSamplesNumericEdit.Value];
                responseSignal = new double[1, (int)numberOfSamplesNumericEdit.Value];

                for(i=0; i < (int)numberOfSamplesNumericEdit.Value; i++)
                {
                    stimulusSignal[0, i] = noiseWaveform[i]; // Stimulus is the Noisy signal that is fed to the IIR filter. 
                    responseSignal[0, i] = filteredwave[i]; //Response is the filtered wave from the filter. Here we are taking filter as the 
                    // device performing filtering operation and creating the response signal.
                }
            
                // Apply Network functions.
                Transforms.NetworkFunctions(stimulusSignal, responseSignal,
                    1/(double)samplingRateNumericEdit.Value, out crossPowerSpectrumMagnitude, out crossPowerSpectrumPhase,
                    out frequencyResponseMagnitude, out frequencyResponsePhase, out coherence, out impulseResponse, out df); 
            
                // xWaveform against which powerSPectrum and frequencyResponse will be plotted.
                for(i=0; i<(int)numberOfSamplesNumericEdit.Value/2; i++)
                {
                    xWaveform[i] = i*df;
                }
                return true;
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                return false;
            }
            
        }
        
       
        private void plotStimulusButton_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            showStimulusClicked = true;
            showResponseClicked = false;
            impulseResponseClicked = false;

            signalScatterGraph.ClearData();
            signalScatterGraph.Caption = "Stimulus";
            if (CalculateNetworkFunction())
            {
                stimulusPlot.PlotXY(xwave, noiseWaveform);
            }
        
        }

        private void plotResponseButton_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            showStimulusClicked = false;
            showResponseClicked = true;
            impulseResponseClicked = false;
            
            signalScatterGraph.ClearData();
            signalScatterGraph.Caption = "Response of the filtered Stimulus";
            if (CalculateNetworkFunction())
            {
                responsePlot.PlotXY(xwave, filteredwave);
            }
        }

        private void plotCrossPowerSpectrumMagnitude_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            powerSpectrumMagnitudeClicked = true;
            frequencyResponseMagnitudeClicked = false;

            magnitudeScatterGraph.ClearData();
            magnitudeScatterGraph.Caption = " Cross Power Spectrum Magnitude";
            if (CalculateNetworkFunction())
            {
                powerSpectrumMagnitudePlot.PlotXY(xWaveform, crossPowerSpectrumMagnitude);
            }
        }

        private void plotFrequencyResponseMagnitude_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            powerSpectrumMagnitudeClicked = true;
            frequencyResponseMagnitudeClicked = false;
            
            magnitudeScatterGraph.ClearData();
            magnitudeScatterGraph.Caption = " Frequency Response Magnitude";
            if (CalculateNetworkFunction())
            {
                frequencyResponseMagnitudePlot.PlotXY(xWaveform, frequencyResponseMagnitude);
            }
           
        }

        private void plotCrossPowerSpectrumPhase_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            powerSpectrumPhaseClicked = true;
            frequencyResponsePhaseClicked = false;

            phaseScatterGraph.ClearData(); 
            phaseScatterGraph.Caption = " Cross Power Spectrum Phase";
            if (CalculateNetworkFunction())
            {
                powerSpectrumPhasePlot.PlotXY(xWaveform, crossPowerSpectrumPhase);
            }
        }

        private void plotFrequencyResponsePhase_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            powerSpectrumPhaseClicked = false;
            frequencyResponsePhaseClicked = true;
            
            phaseScatterGraph.ClearData();
            phaseScatterGraph.Caption = "Frequency Response Phase";
            if (CalculateNetworkFunction())
            {
                frequencyResponsePhasePlot.PlotXY(xWaveform, frequencyResponsePhase);
            }
        }

        private void plotImpulseResponse_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            showStimulusClicked = false;
            showResponseClicked = false;
            impulseResponseClicked = true;

            signalScatterGraph.ClearData();
            signalScatterGraph.Caption = "Impulse Response";
            if (CalculateNetworkFunction())
            {
                impulseResponsePlot.PlotXY(xwave, impulseResponse);
            }
        }


        private void signalSource_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(signalSourceComboBox.SelectedIndex == 0)
            {
                frequencyNumericEdit.Enabled = false;
                frequencyLabel.Enabled = false;
            }
            else
            {
                frequencyNumericEdit.Enabled = true;
                frequencyLabel.Enabled = true;
            }

            if(showStimulusClicked)
               plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
            
        }

        private void filterType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(filterTypeComboBox.SelectedIndex == 0 || filterTypeComboBox.SelectedIndex == 1)
                upperCutoffNumericEdit.Enabled = false;
            else
                upperCutoffNumericEdit.Enabled = true;
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
            
        }

        private void frequency_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
            
        }

        private void samplingRate_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
           }

        private void numberOfSamples_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
        }

        private void signalAmplitude_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
        }

        private void noiseAmplitude_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
        }

        private void filterDesign_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
        }

        private void lowerCutoff_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
        }

        private void order_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
       }

        private void upperCutoff_ValueChanged(object sender, System.EventArgs e)
        {
            if(showStimulusClicked)
                plotStimulusButton.PerformClick();
            if(showResponseClicked)
                plotResponseButton.PerformClick();
            if(impulseResponseClicked)
                plotImpulseResponseButton.PerformClick();
            if(powerSpectrumMagnitudeClicked)
                plotCrossPowerSpectrumMagnitudeButton.PerformClick();
            if(powerSpectrumPhaseClicked)
                plotCrossPowerSpectrumPhaseButton.PerformClick();
            if(frequencyResponseMagnitudeClicked)
                plotFrequencyResponseMagnitudeButton.PerformClick();
            if(frequencyResponsePhaseClicked)
                plotFrequencyResponsePhaseButton.PerformClick();
       }
	}
}
