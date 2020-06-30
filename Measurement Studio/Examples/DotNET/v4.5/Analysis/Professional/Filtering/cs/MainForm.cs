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
using NationalInstruments;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.Filtering
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label numberOfSamplesLabel;
        private System.Windows.Forms.Label filterDesignLabel;
        private System.Windows.Forms.Label filterTypeLabel;
        private System.Windows.Forms.Label rippleLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label lowerCutoffLabel;
        private System.Windows.Forms.Label higherCutoffLabel;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.ScatterPlot signalPlot;
        private NationalInstruments.UI.ScatterPlot phasePlot;
        private NationalInstruments.UI.ScatterPlot magnitudePlot;
        private NationalInstruments.UI.XAxis magnitudeXAxis;
        private NationalInstruments.UI.YAxis magnitudeYAxis;
        private NationalInstruments.UI.XAxis phaseXAxis;
        private NationalInstruments.UI.YAxis phaseYAxis;
        private System.Windows.Forms.Label attenuationLabel;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.Label displayModeLabel;
        private NationalInstruments.UI.ScatterPlot signalWithNoisePlot;
        private System.Windows.Forms.Label signalSourceLabel;
        private System.Windows.Forms.Label frequencyLabel;
        double []waveform;
        double []xwave;
        double []xwaveform;
        double []noiseWaveform;
        double []filteredwave;
        double []magnitudes;
        double []subsetOfMagnitudes; 
        double []phases;
        double []subsetOfPhases; 
        double []logMagnitudes; 
        NationalInstruments.ComplexDouble[] FFTValue;
        bool calculateFFTofTheFilteredSignalClicked = false;
        bool calculateFFTofTheFilteredNoisySignalClicked = false;
        bool calculateFFTofTheUnfilteredSignalClicked = false;
        bool calculateFFTofTheUnfilteredNoisySignalClicked = false;
        bool displayNoisySignalClicked = false;
        bool displaySignalClicked = false;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label noiseAmplitudeLabel;
        private System.Windows.Forms.Label signalAmplitudeLabel;
		private System.Windows.Forms.ComboBox signalSourceComboBox;
		private System.Windows.Forms.ComboBox filterTypeComboBox;
		private System.Windows.Forms.ComboBox filterDesignComboBox;
		private System.Windows.Forms.ComboBox displayModeComboBox;
		private NationalInstruments.UI.WindowsForms.NumericEdit attenuationNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit orderNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit lowerCutoffNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit upperCutoffNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit rippleNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit samplingRateNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit frequencyNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit signalAmplitudeNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit noiseAmplitudeNumericEdit;
		private System.Windows.Forms.Button displaySignalButton;
		private System.Windows.Forms.Button calculateFFTOfFilteredSignalButton;
		private System.Windows.Forms.Button calculateFFTBeforeFilteringButton;
		private System.Windows.Forms.Button displaySignalWithNoiseButton;
		private System.Windows.Forms.Button calculateFFTOfNoisySignalButton;
		private System.Windows.Forms.Button calculateFFTOfFilteredNoisySignalButton;
		private NationalInstruments.UI.WindowsForms.ScatterGraph signalScatterGraph;
		private NationalInstruments.UI.WindowsForms.ScatterGraph phaseScatterGraph;
		private NationalInstruments.UI.WindowsForms.ScatterGraph magnitudeScatterGraph;
		private System.Windows.Forms.GroupBox filterParametersGroupBox;
		private System.Windows.Forms.GroupBox signalParametersGroupBox;
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

            signalSourceComboBox.SelectedIndex =0;
            displayModeComboBox.SelectedIndex = 0 ;
            filterTypeComboBox.SelectedIndex = 0;
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
			this.numberOfSamplesLabel = new System.Windows.Forms.Label();
			this.filterParametersGroupBox = new System.Windows.Forms.GroupBox();
			this.rippleLabel = new System.Windows.Forms.Label();
			this.filterDesignLabel = new System.Windows.Forms.Label();
			this.orderLabel = new System.Windows.Forms.Label();
			this.lowerCutoffLabel = new System.Windows.Forms.Label();
			this.filterTypeLabel = new System.Windows.Forms.Label();
			this.higherCutoffLabel = new System.Windows.Forms.Label();
			this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
			this.filterDesignComboBox = new System.Windows.Forms.ComboBox();
			this.attenuationLabel = new System.Windows.Forms.Label();
			this.attenuationNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.orderNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.lowerCutoffNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.upperCutoffNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.rippleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.displayModeComboBox = new System.Windows.Forms.ComboBox();
			this.displayModeLabel = new System.Windows.Forms.Label();
			this.signalScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
			this.signalPlot = new NationalInstruments.UI.ScatterPlot();
			this.xAxis = new NationalInstruments.UI.XAxis();
			this.yAxis = new NationalInstruments.UI.YAxis();
			this.signalWithNoisePlot = new NationalInstruments.UI.ScatterPlot();
			this.phaseScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
			this.phasePlot = new NationalInstruments.UI.ScatterPlot();
			this.phaseXAxis = new NationalInstruments.UI.XAxis();
			this.phaseYAxis = new NationalInstruments.UI.YAxis();
			this.magnitudeScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
			this.magnitudePlot = new NationalInstruments.UI.ScatterPlot();
			this.magnitudeXAxis = new NationalInstruments.UI.XAxis();
			this.magnitudeYAxis = new NationalInstruments.UI.YAxis();
			this.displaySignalButton = new System.Windows.Forms.Button();
			this.samplingRateLabel = new System.Windows.Forms.Label();
			this.signalSourceComboBox = new System.Windows.Forms.ComboBox();
			this.signalSourceLabel = new System.Windows.Forms.Label();
			this.frequencyLabel = new System.Windows.Forms.Label();
			this.calculateFFTOfFilteredSignalButton = new System.Windows.Forms.Button();
			this.signalParametersGroupBox = new System.Windows.Forms.GroupBox();
			this.samplingRateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.frequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.noiseAmplitudeLabel = new System.Windows.Forms.Label();
			this.signalAmplitudeLabel = new System.Windows.Forms.Label();
			this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.signalAmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.noiseAmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.calculateFFTBeforeFilteringButton = new System.Windows.Forms.Button();
			this.displaySignalWithNoiseButton = new System.Windows.Forms.Button();
			this.calculateFFTOfNoisySignalButton = new System.Windows.Forms.Button();
			this.calculateFFTOfFilteredNoisySignalButton = new System.Windows.Forms.Button();
			this.helpLabel = new System.Windows.Forms.Label();
			this.filterParametersGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.attenuationNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lowerCutoffNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.upperCutoffNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rippleNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.signalScatterGraph)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phaseScatterGraph)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.magnitudeScatterGraph)).BeginInit();
			this.signalParametersGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.signalAmplitudeNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.noiseAmplitudeNumericEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// numberOfSamplesLabel
			// 
			this.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.numberOfSamplesLabel.Location = new System.Drawing.Point(16, 160);
			this.numberOfSamplesLabel.Name = "numberOfSamplesLabel";
			this.numberOfSamplesLabel.Size = new System.Drawing.Size(104, 16);
			this.numberOfSamplesLabel.TabIndex = 4;
			this.numberOfSamplesLabel.Text = "Number Of Samples:";
			// 
			// filterParametersGroupBox
			// 
			this.filterParametersGroupBox.Controls.Add(this.rippleLabel);
			this.filterParametersGroupBox.Controls.Add(this.filterDesignLabel);
			this.filterParametersGroupBox.Controls.Add(this.orderLabel);
			this.filterParametersGroupBox.Controls.Add(this.lowerCutoffLabel);
			this.filterParametersGroupBox.Controls.Add(this.filterTypeLabel);
			this.filterParametersGroupBox.Controls.Add(this.higherCutoffLabel);
			this.filterParametersGroupBox.Controls.Add(this.filterTypeComboBox);
			this.filterParametersGroupBox.Controls.Add(this.filterDesignComboBox);
			this.filterParametersGroupBox.Controls.Add(this.attenuationLabel);
			this.filterParametersGroupBox.Controls.Add(this.attenuationNumericEdit);
			this.filterParametersGroupBox.Controls.Add(this.orderNumericEdit);
			this.filterParametersGroupBox.Controls.Add(this.lowerCutoffNumericEdit);
			this.filterParametersGroupBox.Controls.Add(this.upperCutoffNumericEdit);
			this.filterParametersGroupBox.Controls.Add(this.rippleNumericEdit);
			this.filterParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.filterParametersGroupBox.Location = new System.Drawing.Point(600, 8);
			this.filterParametersGroupBox.Name = "filterParametersGroupBox";
			this.filterParametersGroupBox.Size = new System.Drawing.Size(128, 352);
			this.filterParametersGroupBox.TabIndex = 8;
			this.filterParametersGroupBox.TabStop = false;
			this.filterParametersGroupBox.Text = "Filter Parameters";
			// 
			// rippleLabel
			// 
			this.rippleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rippleLabel.Location = new System.Drawing.Point(16, 112);
			this.rippleLabel.Name = "rippleLabel";
			this.rippleLabel.Size = new System.Drawing.Size(88, 16);
			this.rippleLabel.TabIndex = 1;
			this.rippleLabel.Text = "Ripple:";
			// 
			// filterDesignLabel
			// 
			this.filterDesignLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.filterDesignLabel.Location = new System.Drawing.Point(16, 64);
			this.filterDesignLabel.Name = "filterDesignLabel";
			this.filterDesignLabel.Size = new System.Drawing.Size(88, 16);
			this.filterDesignLabel.TabIndex = 1;
			this.filterDesignLabel.Text = "Filter Design:";
			// 
			// orderLabel
			// 
			this.orderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.orderLabel.Location = new System.Drawing.Point(16, 208);
			this.orderLabel.Name = "orderLabel";
			this.orderLabel.Size = new System.Drawing.Size(88, 16);
			this.orderLabel.TabIndex = 1;
			this.orderLabel.Text = "Order:";
			// 
			// lowerCutoffLabel
			// 
			this.lowerCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lowerCutoffLabel.Location = new System.Drawing.Point(16, 256);
			this.lowerCutoffLabel.Name = "lowerCutoffLabel";
			this.lowerCutoffLabel.Size = new System.Drawing.Size(88, 16);
			this.lowerCutoffLabel.TabIndex = 1;
			this.lowerCutoffLabel.Text = "Lower Cutoff:";
			// 
			// filterTypeLabel
			// 
			this.filterTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.filterTypeLabel.Location = new System.Drawing.Point(16, 16);
			this.filterTypeLabel.Name = "filterTypeLabel";
			this.filterTypeLabel.Size = new System.Drawing.Size(88, 16);
			this.filterTypeLabel.TabIndex = 1;
			this.filterTypeLabel.Text = "Filter Type:";
			// 
			// higherCutoffLabel
			// 
			this.higherCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.higherCutoffLabel.Location = new System.Drawing.Point(16, 304);
			this.higherCutoffLabel.Name = "higherCutoffLabel";
			this.higherCutoffLabel.Size = new System.Drawing.Size(88, 16);
			this.higherCutoffLabel.TabIndex = 1;
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
			this.filterTypeComboBox.Size = new System.Drawing.Size(96, 21);
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
			this.filterDesignComboBox.Size = new System.Drawing.Size(96, 21);
			this.filterDesignComboBox.TabIndex = 1;
			this.filterDesignComboBox.SelectedIndexChanged += new System.EventHandler(this.filterDesign_SelectedIndexChanged);
			// 
			// attenuationLabel
			// 
			this.attenuationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.attenuationLabel.Location = new System.Drawing.Point(16, 160);
			this.attenuationLabel.Name = "attenuationLabel";
			this.attenuationLabel.Size = new System.Drawing.Size(88, 16);
			this.attenuationLabel.TabIndex = 1;
			this.attenuationLabel.Text = "Attenuation:";
			// 
			// attenuationNumericEdit
			// 
			this.attenuationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
			this.attenuationNumericEdit.Location = new System.Drawing.Point(16, 176);
			this.attenuationNumericEdit.Name = "attenuationNumericEdit";
			this.attenuationNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.attenuationNumericEdit.Range = new NationalInstruments.UI.Range(1, 1000);
			this.attenuationNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.attenuationNumericEdit.TabIndex = 3;
			this.attenuationNumericEdit.Value = 60;
			this.attenuationNumericEdit.ValueChanged += new System.EventHandler(this.attenuation_ValueChanged);
			// 
			// orderNumericEdit
			// 
			this.orderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.orderNumericEdit.Location = new System.Drawing.Point(16, 224);
			this.orderNumericEdit.Name = "orderNumericEdit";
			this.orderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.orderNumericEdit.Range = new NationalInstruments.UI.Range(1, 50);
			this.orderNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.orderNumericEdit.TabIndex = 4;
			this.orderNumericEdit.Value = 2;
			this.orderNumericEdit.ValueChanged += new System.EventHandler(this.order_ValueChanged);
			// 
			// lowerCutoffNumericEdit
			// 
			this.lowerCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.lowerCutoffNumericEdit.Location = new System.Drawing.Point(16, 272);
			this.lowerCutoffNumericEdit.Name = "lowerCutoffNumericEdit";
			this.lowerCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.lowerCutoffNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.lowerCutoffNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.lowerCutoffNumericEdit.TabIndex = 5;
			this.lowerCutoffNumericEdit.Value = 250;
			this.lowerCutoffNumericEdit.ValueChanged += new System.EventHandler(this.lowerCutoff_ValueChanged);
			// 
			// upperCutoffNumericEdit
			// 
			this.upperCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.upperCutoffNumericEdit.Location = new System.Drawing.Point(16, 320);
			this.upperCutoffNumericEdit.Name = "upperCutoffNumericEdit";
			this.upperCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.upperCutoffNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.upperCutoffNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.upperCutoffNumericEdit.TabIndex = 6;
			this.upperCutoffNumericEdit.Value = 450;
			this.upperCutoffNumericEdit.ValueChanged += new System.EventHandler(this.upperCutoff_ValueChanged);
			// 
			// rippleNumericEdit
			// 
			this.rippleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
			this.rippleNumericEdit.Location = new System.Drawing.Point(16, 136);
			this.rippleNumericEdit.Name = "rippleNumericEdit";
			this.rippleNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.rippleNumericEdit.Range = new NationalInstruments.UI.Range(1, 1000);
			this.rippleNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.rippleNumericEdit.TabIndex = 2;
			this.rippleNumericEdit.Value = 2;
			this.rippleNumericEdit.ValueChanged += new System.EventHandler(this.ripple_ValueChanged);
			// 
			// displayModeComboBox
			// 
			this.displayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.displayModeComboBox.Items.AddRange(new object[] {
																	 "Linear",
																	 "Logarithmic"});
			this.displayModeComboBox.Location = new System.Drawing.Point(24, 352);
			this.displayModeComboBox.Name = "displayModeComboBox";
			this.displayModeComboBox.Size = new System.Drawing.Size(96, 21);
			this.displayModeComboBox.TabIndex = 7;
			this.displayModeComboBox.SelectedIndexChanged += new System.EventHandler(this.displayMode_SelectedIndexChanged);
			// 
			// displayModeLabel
			// 
			this.displayModeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.displayModeLabel.Location = new System.Drawing.Point(24, 336);
			this.displayModeLabel.Name = "displayModeLabel";
			this.displayModeLabel.Size = new System.Drawing.Size(116, 16);
			this.displayModeLabel.TabIndex = 12;
			this.displayModeLabel.Text = "Display Mode of FFT:";
			// 
			// signalScatterGraph
			// 
			this.signalScatterGraph.Caption = "Signal Graph";
			this.signalScatterGraph.Location = new System.Drawing.Point(160, 8);
			this.signalScatterGraph.Name = "signalScatterGraph";
            this.signalScatterGraph.UseColorGenerator = true;
			this.signalScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
																								this.signalPlot,
																								this.signalWithNoisePlot});
			this.signalScatterGraph.Size = new System.Drawing.Size(432, 136);
			this.signalScatterGraph.TabIndex = 6;
			this.signalScatterGraph.TabStop = false;
			this.signalScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
																						  this.xAxis});
			this.signalScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
																						  this.yAxis});
			// 
			// signalPlot
			// 
			this.signalPlot.XAxis = this.xAxis;
			this.signalPlot.YAxis = this.yAxis;
			// 
			// xAxis
			// 
			this.xAxis.Caption = "Number Of Samples";
			// 
			// yAxis
			// 
			this.yAxis.Caption = "Amplitude";
			// 
			// signalWithNoisePlot
			// 
			this.signalWithNoisePlot.XAxis = this.xAxis;
			this.signalWithNoisePlot.YAxis = this.yAxis;
			// 
			// phaseScatterGraph
			// 
			this.phaseScatterGraph.Caption = "Phase Graph";
			this.phaseScatterGraph.Location = new System.Drawing.Point(160, 328);
			this.phaseScatterGraph.Name = "phaseScatterGraph";
			this.phaseScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
																							   this.phasePlot});
			this.phaseScatterGraph.Size = new System.Drawing.Size(432, 144);
			this.phaseScatterGraph.TabIndex = 7;
			this.phaseScatterGraph.TabStop = false;
			this.phaseScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
																						 this.phaseXAxis});
			this.phaseScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
																						 this.phaseYAxis});
			// 
			// phasePlot
			// 
			this.phasePlot.XAxis = this.phaseXAxis;
			this.phasePlot.YAxis = this.phaseYAxis;
			// 
			// phaseXAxis
			// 
			this.phaseXAxis.Caption = "Frequency";
			// 
			// phaseYAxis
			// 
			this.phaseYAxis.Caption = "Phase (radian)";
			// 
			// magnitudeScatterGraph
			// 
			this.magnitudeScatterGraph.Caption = "Magnitude Graph";
			this.magnitudeScatterGraph.Location = new System.Drawing.Point(160, 152);
			this.magnitudeScatterGraph.Name = "magnitudeScatterGraph";
			this.magnitudeScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
																								   this.magnitudePlot});
			this.magnitudeScatterGraph.Size = new System.Drawing.Size(432, 168);
			this.magnitudeScatterGraph.TabIndex = 7;
			this.magnitudeScatterGraph.TabStop = false;
			this.magnitudeScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
																							 this.magnitudeXAxis});
			this.magnitudeScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
																							 this.magnitudeYAxis});
			// 
			// magnitudePlot
			// 
			this.magnitudePlot.XAxis = this.magnitudeXAxis;
			this.magnitudePlot.YAxis = this.magnitudeYAxis;
			// 
			// magnitudeXAxis
			// 
			this.magnitudeXAxis.Caption = "Frequency";
			// 
			// magnitudeYAxis
			// 
			this.magnitudeYAxis.Caption = "Magnitude";
			// 
			// displaySignalButton
			// 
			this.displaySignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.displaySignalButton.Location = new System.Drawing.Point(48, 480);
			this.displaySignalButton.Name = "displaySignalButton";
			this.displaySignalButton.Size = new System.Drawing.Size(152, 24);
			this.displaySignalButton.TabIndex = 0;
			this.displaySignalButton.Text = "Display Signal ";
			this.displaySignalButton.Click += new System.EventHandler(this.displaySignal_Click);
			// 
			// samplingRateLabel
			// 
			this.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.samplingRateLabel.Location = new System.Drawing.Point(16, 112);
			this.samplingRateLabel.Name = "samplingRateLabel";
			this.samplingRateLabel.Size = new System.Drawing.Size(104, 16);
			this.samplingRateLabel.TabIndex = 10;
			this.samplingRateLabel.Text = "Sampling Rate:";
			// 
			// signalSourceComboBox
			// 
			this.signalSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.signalSourceComboBox.Items.AddRange(new object[] {
																	  "Sine",
																	  "Cosine",
																	  "Square"});
			this.signalSourceComboBox.Location = new System.Drawing.Point(16, 32);
			this.signalSourceComboBox.Name = "signalSourceComboBox";
			this.signalSourceComboBox.Size = new System.Drawing.Size(96, 21);
			this.signalSourceComboBox.TabIndex = 0;
			this.signalSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.signalSource_SelectedIndexChanged);
			// 
			// signalSourceLabel
			// 
			this.signalSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.signalSourceLabel.Location = new System.Drawing.Point(16, 16);
			this.signalSourceLabel.Name = "signalSourceLabel";
			this.signalSourceLabel.Size = new System.Drawing.Size(88, 16);
			this.signalSourceLabel.TabIndex = 14;
			this.signalSourceLabel.Text = "Signal Source:";
			// 
			// frequencyLabel
			// 
			this.frequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.frequencyLabel.Location = new System.Drawing.Point(16, 64);
			this.frequencyLabel.Name = "frequencyLabel";
			this.frequencyLabel.Size = new System.Drawing.Size(96, 16);
			this.frequencyLabel.TabIndex = 16;
			this.frequencyLabel.Text = "Frequency:";
			// 
			// calculateFFTOfFilteredSignalButton
			// 
			this.calculateFFTOfFilteredSignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calculateFFTOfFilteredSignalButton.Location = new System.Drawing.Point(472, 480);
			this.calculateFFTOfFilteredSignalButton.Name = "calculateFFTOfFilteredSignalButton";
			this.calculateFFTOfFilteredSignalButton.Size = new System.Drawing.Size(208, 24);
			this.calculateFFTOfFilteredSignalButton.TabIndex = 2;
			this.calculateFFTOfFilteredSignalButton.Text = "Calculate FFT of the Filtered Signal";
			this.calculateFFTOfFilteredSignalButton.Click += new System.EventHandler(this.calculateFFTOfFilteredSignal_Click);
			// 
			// signalParametersGroupBox
			// 
			this.signalParametersGroupBox.Controls.Add(this.samplingRateNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.frequencyNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.frequencyLabel);
			this.signalParametersGroupBox.Controls.Add(this.signalSourceComboBox);
			this.signalParametersGroupBox.Controls.Add(this.signalSourceLabel);
			this.signalParametersGroupBox.Controls.Add(this.samplingRateLabel);
			this.signalParametersGroupBox.Controls.Add(this.noiseAmplitudeLabel);
			this.signalParametersGroupBox.Controls.Add(this.signalAmplitudeLabel);
			this.signalParametersGroupBox.Controls.Add(this.numberOfSamplesLabel);
			this.signalParametersGroupBox.Controls.Add(this.numberOfSamplesNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.signalAmplitudeNumericEdit);
			this.signalParametersGroupBox.Controls.Add(this.noiseAmplitudeNumericEdit);
			this.signalParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.signalParametersGroupBox.Location = new System.Drawing.Point(8, 8);
			this.signalParametersGroupBox.Name = "signalParametersGroupBox";
			this.signalParametersGroupBox.Size = new System.Drawing.Size(128, 304);
			this.signalParametersGroupBox.TabIndex = 6;
			this.signalParametersGroupBox.TabStop = false;
			this.signalParametersGroupBox.Text = "Signal Parameters";
			// 
			// samplingRateNumericEdit
			// 
			this.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.samplingRateNumericEdit.Location = new System.Drawing.Point(16, 128);
			this.samplingRateNumericEdit.Name = "samplingRateNumericEdit";
			this.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.samplingRateNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.samplingRateNumericEdit.Size = new System.Drawing.Size(96, 20);
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
			this.frequencyNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.frequencyNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.frequencyNumericEdit.TabIndex = 1;
			this.frequencyNumericEdit.Value = 100;
			this.frequencyNumericEdit.ValueChanged += new System.EventHandler(this.frequency_ValueChanged);
			// 
			// noiseAmplitudeLabel
			// 
			this.noiseAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.noiseAmplitudeLabel.Location = new System.Drawing.Point(16, 256);
			this.noiseAmplitudeLabel.Name = "noiseAmplitudeLabel";
			this.noiseAmplitudeLabel.Size = new System.Drawing.Size(88, 16);
			this.noiseAmplitudeLabel.TabIndex = 4;
			this.noiseAmplitudeLabel.Text = "Noise Amplitude:";
			// 
			// signalAmplitudeLabel
			// 
			this.signalAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.signalAmplitudeLabel.Location = new System.Drawing.Point(16, 208);
			this.signalAmplitudeLabel.Name = "signalAmplitudeLabel";
			this.signalAmplitudeLabel.Size = new System.Drawing.Size(96, 16);
			this.signalAmplitudeLabel.TabIndex = 10;
			this.signalAmplitudeLabel.Text = "Signal Amplitude:";
			// 
			// numberOfSamplesNumericEdit
			// 
			this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(16, 176);
			this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
			this.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.numberOfSamplesNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.numberOfSamplesNumericEdit.TabIndex = 3;
			this.numberOfSamplesNumericEdit.Value = 100;
			this.numberOfSamplesNumericEdit.ValueChanged += new System.EventHandler(this.numberOfSamples_ValueChanged);
			// 
			// signalAmplitudeNumericEdit
			// 
			this.signalAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
			this.signalAmplitudeNumericEdit.Location = new System.Drawing.Point(16, 224);
			this.signalAmplitudeNumericEdit.Name = "signalAmplitudeNumericEdit";
			this.signalAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.signalAmplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.signalAmplitudeNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.signalAmplitudeNumericEdit.TabIndex = 4;
			this.signalAmplitudeNumericEdit.Value = 1;
			this.signalAmplitudeNumericEdit.ValueChanged += new System.EventHandler(this.signalAmplitude_ValueChanged);
			// 
			// noiseAmplitudeNumericEdit
			// 
			this.noiseAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
			this.noiseAmplitudeNumericEdit.Location = new System.Drawing.Point(16, 272);
			this.noiseAmplitudeNumericEdit.Name = "noiseAmplitudeNumericEdit";
			this.noiseAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.noiseAmplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.noiseAmplitudeNumericEdit.Size = new System.Drawing.Size(96, 20);
			this.noiseAmplitudeNumericEdit.TabIndex = 5;
			this.noiseAmplitudeNumericEdit.Value = 0.01;
			this.noiseAmplitudeNumericEdit.ValueChanged += new System.EventHandler(this.noiseAmplitude_ValueChanged);
			// 
			// calculateFFTBeforeFilteringButton
			// 
			this.calculateFFTBeforeFilteringButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calculateFFTBeforeFilteringButton.Location = new System.Drawing.Point(208, 480);
			this.calculateFFTBeforeFilteringButton.Name = "calculateFFTBeforeFilteringButton";
			this.calculateFFTBeforeFilteringButton.Size = new System.Drawing.Size(256, 24);
			this.calculateFFTBeforeFilteringButton.TabIndex = 1;
			this.calculateFFTBeforeFilteringButton.Text = "Calculate FFT of Signal(before filtering)";
			this.calculateFFTBeforeFilteringButton.Click += new System.EventHandler(this.calculateFFTBeforeFiltering_Click);
			// 
			// displaySignalWithNoiseButton
			// 
			this.displaySignalWithNoiseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.displaySignalWithNoiseButton.Location = new System.Drawing.Point(48, 512);
			this.displaySignalWithNoiseButton.Name = "displaySignalWithNoiseButton";
			this.displaySignalWithNoiseButton.Size = new System.Drawing.Size(152, 24);
			this.displaySignalWithNoiseButton.TabIndex = 3;
			this.displaySignalWithNoiseButton.Text = "Display  Noisy Signal";
			this.displaySignalWithNoiseButton.Click += new System.EventHandler(this.displaySignalWithNoise_Click);
			// 
			// calculateFFTOfNoisySignalButton
			// 
			this.calculateFFTOfNoisySignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calculateFFTOfNoisySignalButton.Location = new System.Drawing.Point(208, 512);
			this.calculateFFTOfNoisySignalButton.Name = "calculateFFTOfNoisySignalButton";
			this.calculateFFTOfNoisySignalButton.Size = new System.Drawing.Size(256, 24);
			this.calculateFFTOfNoisySignalButton.TabIndex = 4;
			this.calculateFFTOfNoisySignalButton.Text = "Calculate FFT of Noisy Signal (before filtering)";
			this.calculateFFTOfNoisySignalButton.Click += new System.EventHandler(this.calculateFFTOfNoisySignal_Click);
			// 
			// calculateFFTOfFilteredNoisySignalButton
			// 
			this.calculateFFTOfFilteredNoisySignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.calculateFFTOfFilteredNoisySignalButton.Location = new System.Drawing.Point(472, 512);
			this.calculateFFTOfFilteredNoisySignalButton.Name = "calculateFFTOfFilteredNoisySignalButton";
			this.calculateFFTOfFilteredNoisySignalButton.Size = new System.Drawing.Size(208, 24);
			this.calculateFFTOfFilteredNoisySignalButton.TabIndex = 5;
			this.calculateFFTOfFilteredNoisySignalButton.Text = "Calculate FFT of Filtered Noisy Signal";
			this.calculateFFTOfFilteredNoisySignalButton.Click += new System.EventHandler(this.calculateFFTOfFilteredNoisySignal_Click);
			// 
			// helpLabel
			// 
			this.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.helpLabel.Location = new System.Drawing.Point(80, 544);
			this.helpLabel.Name = "helpLabel";
			this.helpLabel.Size = new System.Drawing.Size(576, 40);
			this.helpLabel.TabIndex = 23;
			this.helpLabel.Text = @"This example shows the FFT of a filtered signal\filtered noisy signal\unfiltered signal\unfiltered noisy signal waveform data. Both upper and lower cutoff frequency must be less than half of the sampling rate to satisfy Nyquist's Criterion. Lower cutoff must be lesser than the upper cutoff and the attenuation must be greater than the ripple.";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(738, 591);
			this.Controls.Add(this.helpLabel);
			this.Controls.Add(this.calculateFFTOfFilteredNoisySignalButton);
			this.Controls.Add(this.calculateFFTOfNoisySignalButton);
			this.Controls.Add(this.displaySignalWithNoiseButton);
			this.Controls.Add(this.calculateFFTBeforeFilteringButton);
			this.Controls.Add(this.calculateFFTOfFilteredSignalButton);
			this.Controls.Add(this.displaySignalButton);
			this.Controls.Add(this.phaseScatterGraph);
			this.Controls.Add(this.signalScatterGraph);
			this.Controls.Add(this.filterParametersGroupBox);
			this.Controls.Add(this.magnitudeScatterGraph);
			this.Controls.Add(this.displayModeLabel);
			this.Controls.Add(this.displayModeComboBox);
			this.Controls.Add(this.signalParametersGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Filtering";
			this.filterParametersGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.attenuationNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lowerCutoffNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.upperCutoffNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rippleNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.signalScatterGraph)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phaseScatterGraph)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.magnitudeScatterGraph)).EndInit();
			this.signalParametersGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.signalAmplitudeNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.noiseAmplitudeNumericEdit)).EndInit();
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

        // Displays the signal on the graph.
        private void displaySignal_Click(object sender, System.EventArgs e)
        {
            displaySignalClicked = true;
            signalWithNoisePlot.ClearData();
            ShowSignalSource(); 
            
        }

        // when the filter type selected by the user gets changed.
        private void filterType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(filterTypeComboBox.SelectedIndex == 0 || filterTypeComboBox.SelectedIndex == 1)
               upperCutoffNumericEdit.Enabled = false;
            else
                upperCutoffNumericEdit.Enabled = true;
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        // When the signal source is changed on the panel.
        private void signalSource_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();

            if(displaySignalClicked)
                displaySignalButton.PerformClick();
            if(displayNoisySignalClicked)
                displaySignalWithNoiseButton.PerformClick();
            
        }
        // When the CalculateFFTofFilteredSignal button is clicked.
        private void calculateFFTOfFilteredSignal_Click(object sender, System.EventArgs e)
        {  
            calculateFFTofTheFilteredSignalClicked = true;
            calculateFFTofTheFilteredNoisySignalClicked = false;
            calculateFFTofTheUnfilteredSignalClicked = false;
            calculateFFTofTheUnfilteredNoisySignalClicked = false;
            ShowSignalSource(); // Displays the signal source.
            FilterSignal(waveform); // Filter the waveform.
            CalculateFFTFunction(filteredwave); // Calculate fft of filtered wave.
       }
       // To display signal source on the graph.
       void ShowSignalSource()
       {
            waveform = new double[(int)numberOfSamplesNumericEdit.Value];
            xwave = new double[(int)numberOfSamplesNumericEdit.Value];
            int i;
            
            switch(signalSourceComboBox.SelectedIndex)
            {
                case 0:
                    NationalInstruments.Analysis.SignalGeneration.SineSignal sin = 
                        new SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value,0.0);
                    waveform = sin.Generate(samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
                case 1:
                    NationalInstruments.Analysis.SignalGeneration.SineSignal cos 
                        = new SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 90.0);
                    waveform = cos.Generate(samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
                case 2:
                    NationalInstruments.Analysis.SignalGeneration.SquareSignal square
                        = new SquareSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 90.0,50.0);
                    waveform = square.Generate(samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
                default:
                    NationalInstruments.Analysis.SignalGeneration.SineSignal sinDefault 
                        = new SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 0.0);
                    waveform = sinDefault.Generate(samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
                    break;
            }

            for (i=0; i<(int)numberOfSamplesNumericEdit.Value; i++)
            {
                xwave[i] = i;
            }

            // plot the signal waveform.
            signalPlot.PlotXY(xwave, waveform);
        }
        // When Calculate FFT Before Filtering button is clicked.
        private void calculateFFTBeforeFiltering_Click(object sender, System.EventArgs e)
        {
            calculateFFTofTheFilteredSignalClicked = false;
            calculateFFTofTheFilteredNoisySignalClicked = false;
            calculateFFTofTheUnfilteredSignalClicked = true;
            calculateFFTofTheUnfilteredNoisySignalClicked = false;
            ShowSignalSource();// Displays signal source.
            CalculateFFTFunction(waveform);// Calculate FFT of unfiltered waveform. 
        }
        // Filter signal with the appropriate filter speciefied by the user.
        void FilterSignal(double []waveform)
        {
            filteredwave = new double[(int)numberOfSamplesNumericEdit.Value];

            try
            {
                switch(filterDesignComboBox.SelectedIndex)
                {
                    case 0: // Filter selected is elliptic.
                    switch(filterTypeComboBox.SelectedIndex)
                    {
                        case 0: // elliptic lowpass
                            NationalInstruments.Analysis.Dsp.Filters.EllipticLowpassFilter ellipticLowpass 
                                = new EllipticLowpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = ellipticLowpass.FilterData(waveform);
                            break;

                        case 1: // elliptic highpass
                            NationalInstruments.Analysis.Dsp.Filters.EllipticHighpassFilter ellipticHighpass 
                                = new EllipticHighpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = ellipticHighpass.FilterData(waveform);
                            break;

                        case 2: // elliptic bandpass
                            NationalInstruments.Analysis.Dsp.Filters.EllipticBandpassFilter ellipticBandpass 
                                = new EllipticBandpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = ellipticBandpass.FilterData(waveform);
                            break;

                        case 3: // elliptic bandstop
                            NationalInstruments.Analysis.Dsp.Filters.EllipticBandstopFilter ellipticBandstop 
                                = new EllipticBandstopFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = ellipticBandstop.FilterData(waveform);
                            break;
                    }
                        break;

                    case 1: // Bessel filter is selected.
                    switch(filterTypeComboBox.SelectedIndex)
                    {
                        case 0: // bessel lowpass
                            NationalInstruments.Analysis.Dsp.Filters.BesselLowpassFilter besselLowpass 
                                = new BesselLowpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value,lowerCutoffNumericEdit.Value);
                            filteredwave = besselLowpass.FilterData(waveform);
                            break;

                        case 1: // bessel highpass
                            NationalInstruments.Analysis.Dsp.Filters.BesselHighpassFilter besselHighpass 
                                = new BesselHighpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value);
                            filteredwave = besselHighpass.FilterData(waveform);
                            break;

                        case 2: // bessel bandpass
                            NationalInstruments.Analysis.Dsp.Filters.BesselBandpassFilter besselBandpass 
                                = new BesselBandpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value);
                            filteredwave = besselBandpass.FilterData(waveform);
                            break;

                        case 3: // bessel bandstop
                            NationalInstruments.Analysis.Dsp.Filters.BesselBandstopFilter besselBandstop 
                                = new BesselBandstopFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value);
                            filteredwave = besselBandstop.FilterData(waveform);
                            break;
                    }
                        break;

                    case 2: // Butterworth filter is selected.
                    switch(filterTypeComboBox.SelectedIndex)
                    {
                        case 0: // butterworth lowpass
                            NationalInstruments.Analysis.Dsp.Filters.ButterworthLowpassFilter butterworthLowpass 
                                = new ButterworthLowpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value,lowerCutoffNumericEdit.Value);
                            filteredwave = butterworthLowpass.FilterData(waveform);
                            break;

                        case 1: // butterworth highpass
                            NationalInstruments.Analysis.Dsp.Filters.ButterworthHighpassFilter butterworthHighpass 
                                = new ButterworthHighpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value);
                            filteredwave = butterworthHighpass.FilterData(waveform);
                            break;

                        case 2: // butterworth bandpass
                            NationalInstruments.Analysis.Dsp.Filters.ButterworthBandpassFilter butterworthBandpass 
                                = new ButterworthBandpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value);
                            filteredwave = butterworthBandpass.FilterData(waveform);
                            break;

                        case 3: // butterworth bandstop
                            NationalInstruments.Analysis.Dsp.Filters.ButterworthBandstopFilter butterworthBandstop 
                                = new ButterworthBandstopFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value);
                            filteredwave = butterworthBandstop.FilterData(waveform);
                            break;
                    }
                        break;

                    case 3: // Chebyshev filter is selected.
                    switch(filterTypeComboBox.SelectedIndex)
                    {
                        case 0: // chebyshev lowpass
                            NationalInstruments.Analysis.Dsp.Filters.ChebyshevLowpassFilter chebyshevLowpass 
                                = new ChebyshevLowpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value,
                                lowerCutoffNumericEdit.Value, rippleNumericEdit.Value);
                            filteredwave = chebyshevLowpass.FilterData(waveform);
                            break;

                        case 1: // chebyshev highpass
                            NationalInstruments.Analysis.Dsp.Filters.ChebyshevHighpassFilter chebyshevHighpass 
                                = new ChebyshevHighpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, rippleNumericEdit.Value);
                            filteredwave = chebyshevHighpass.FilterData(waveform);
                            break;

                        case 2: // chebyshev bandpass
                            NationalInstruments.Analysis.Dsp.Filters.ChebyshevBandpassFilter chebyshevBandpass
                                = new ChebyshevBandpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, rippleNumericEdit.Value);
                            filteredwave = chebyshevBandpass.FilterData(waveform);
                            break;

                        case 3: // chebyshev bandstop 
                            NationalInstruments.Analysis.Dsp.Filters.ChebyshevBandstopFilter chebyshevBandstop 
                                = new ChebyshevBandstopFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, rippleNumericEdit.Value);
                            filteredwave = chebyshevBandstop.FilterData(waveform);
                            break;
                    }
                        break;

                    case 4: // Inverse chebyshev filter is selected.
                    switch(filterTypeComboBox.SelectedIndex)
                    {
                        case 0: // Inverse chebyshev lowpass
                            NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevLowpassFilter inverseChebyshevLowpass 
                                = new InverseChebyshevLowpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value,
                                lowerCutoffNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = inverseChebyshevLowpass.FilterData(waveform);
                            break;

                        case 1: // Inverse chebyshev highpass.
                            NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevHighpassFilter inverseChebyshevHighpass 
                                = new InverseChebyshevHighpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = inverseChebyshevHighpass.FilterData(waveform);

                            break;

                        case 2: // Inverse chebyshev bandpass
                            NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevBandpassFilter inverseChebyshevBandpass 
                                = new InverseChebyshevBandpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = inverseChebyshevBandpass.FilterData(waveform);
                            break;

                        case 3: // Inverse chebyshev bandstop
                            NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevBandstopFilter inverseChebyshevBandstop 
                                = new InverseChebyshevBandstopFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value,
                                lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, attenuationNumericEdit.Value);
                            filteredwave = inverseChebyshevBandstop.FilterData(waveform);
                            break;
                    }
                        break;

                    default:
                        NationalInstruments.Analysis.Dsp.Filters.EllipticLowpassFilter ellipticLowpassDefault 
                            = new EllipticLowpassFilter((int)orderNumericEdit.Value, samplingRateNumericEdit.Value, 
                            lowerCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value);
                        filteredwave = ellipticLowpassDefault.FilterData(waveform);
                        break;
                }
            }
            catch (Exception exp)
            {
               MessageBox.Show(exp.Message);
            }

        }
        // Mix noise to the signal.
        void MixNoiseToSignal()
        {
            noiseWaveform = new double[(int)numberOfSamplesNumericEdit.Value];
            int i;
            // Create white noise of specified amplitude.
            NationalInstruments.Analysis.SignalGeneration.WhiteNoiseSignal whiteNoise 
                = new WhiteNoiseSignal(noiseAmplitudeNumericEdit.Value, 1);
            noiseWaveform = whiteNoise.Generate(samplingRateNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value);
            // Add noise to signal.
            for (i=0; i<(int)numberOfSamplesNumericEdit.Value; i++)
            {
               noiseWaveform[i] = noiseWaveform[i] + waveform[i];
            }
        }
        // Calculate FFT of the waveform.
        void CalculateFFTFunction(double []waveform)
        {
            //waveform data size
            int datasize = waveform.Length;
            
            //number of samples for FFT data
            int fftnumofSamples = datasize/2;

            xwaveform = new double[fftnumofSamples];
            magnitudes = new double[datasize];
            subsetOfMagnitudes = new double[fftnumofSamples]; 
            phases = new double[datasize];
            subsetOfPhases = new double[fftnumofSamples]; 
            logMagnitudes =  new double[fftnumofSamples];
            FFTValue = new ComplexDouble[datasize];
            int i;
            
            try
            {                
                // Calculate the FFT of waveform array.
                FFTValue = NationalInstruments.Analysis.Dsp.Transforms.RealFft(waveform);
                
                // Get the magnitudes and phases of FFT array..
                NationalInstruments.ComplexDouble.DecomposeArrayPolar(FFTValue, out magnitudes, out phases);
                
                double scalingFactor = 1.0/(double)datasize;
                
                double deltaFreq = samplingRateNumericEdit.Value * scalingFactor;
                
                subsetOfMagnitudes[0] = magnitudes[0] * scalingFactor;

                // It's sufficient to plot just the half of numberOfSamples points to show the FFT.
                // Because the other half will be just the mirror image of the first half.
                for(i=1; i<fftnumofSamples; i++)
                {
                    // Generating xwaveform with respect to which magnitude and phase will be plotted.
                    xwaveform[i] = deltaFreq * i; 
                    subsetOfMagnitudes[i] = magnitudes[i]*scalingFactor*Math.Sqrt(2.0); // Storing only half the magnitudes array.
                    subsetOfPhases[i] = phases[i]; // Storing only half of the phases array.
                }

                // Display mode: linear or exponential
                switch(displayModeComboBox.SelectedIndex)
                {
                        // Plot the magnitudes and the phases.
                    default:
                    case 0: // Linear mode.
                        magnitudePlot.YAxis.Caption = "Magnitude VRMS";
                        magnitudePlot.PlotXY(xwaveform, subsetOfMagnitudes);
                        phasePlot.PlotXY(xwaveform, subsetOfPhases);
                        break;
                    case 1: // Exponential mode.
                        for(i=0; i<fftnumofSamples; i++)
                        {
                            logMagnitudes[i] = 20.0*System.Math.Log10(magnitudes[i]);
                        }
                        magnitudePlot.YAxis.Caption = "Magnitude in dB";
                        magnitudePlot.PlotXY(xwaveform, logMagnitudes);
                        phasePlot.PlotXY(xwaveform, subsetOfPhases);
                        break;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        // When DisplaySignalWithNoise button is clicked.
        private void displaySignalWithNoise_Click(object sender, System.EventArgs e)
        {
            displayNoisySignalClicked = true; // Status is true indicating that this button is clicked.
            ShowSignalSource(); // Plot signal source
            MixNoiseToSignal(); // White noise is added to signal
            //signalPlot.ClearData();
            signalWithNoisePlot.PlotXY(xwave, noiseWaveform); // Plot noisy wave.
        }
        // When CalculateFFTOFNoisySignal button is clicked.
        private void calculateFFTOfNoisySignal_Click(object sender, System.EventArgs e)
        {
            // Status of the different buttons clicked.
            calculateFFTofTheFilteredSignalClicked = false; 
            calculateFFTofTheFilteredNoisySignalClicked = false;
            calculateFFTofTheUnfilteredSignalClicked = false;
            calculateFFTofTheUnfilteredNoisySignalClicked = true;
            ShowSignalSource(); // Plot signal source.
            MixNoiseToSignal(); // Plot noisy signal.
            CalculateFFTFunction(noiseWaveform); // Calculate FFT of noisy waveform and plot it on the graph.
        }
        
        // When CalculateFFTOFFilteredNoisySignal button is clicked.
        private void calculateFFTOfFilteredNoisySignal_Click(object sender, System.EventArgs e)
        {
            // Status of the different buttons clicked.
            calculateFFTofTheFilteredSignalClicked = false;
            calculateFFTofTheFilteredNoisySignalClicked = true;
            calculateFFTofTheUnfilteredSignalClicked = false;
            calculateFFTofTheUnfilteredNoisySignalClicked = false;
            ShowSignalSource(); // Plot signal source.
            MixNoiseToSignal(); // Plot noisy signal.
            FilterSignal(noiseWaveform); // Filter noisy signal.
            CalculateFFTFunction(filteredwave); // Calculate FFT of filetered waveform and plot it on the waveform.
        }
        
        // When Frequency is changed on the panel.
        private void frequency_ValueChanged(object sender, System.EventArgs e)
        {
            signalScatterGraph.ClearData();

            // Updation of displayed graphs.
           if(displaySignalClicked)
                displaySignalButton.PerformClick();
           if(displayNoisySignalClicked)
                displaySignalWithNoiseButton.PerformClick();
           if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        // When Sampling Rate is changed on the panel.
        private void samplingRate_ValueChanged(object sender, System.EventArgs e)
        {
            signalScatterGraph.ClearData();

             // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();

            if(displaySignalClicked)
                displaySignalButton.PerformClick();
            if(displayNoisySignalClicked)
                displaySignalWithNoiseButton.PerformClick();
            
        }

        // When Number Of Samples is changed on the panel. 
        private void numberOfSamples_ValueChanged(object sender, System.EventArgs e)
        {
            signalScatterGraph.ClearData();

             // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();

            if(displaySignalClicked)
                displaySignalButton.PerformClick();
            if(displayNoisySignalClicked)
                displaySignalWithNoiseButton.PerformClick();
            
        }

        private void signalAmplitude_ValueChanged(object sender, System.EventArgs e)
        {
            signalScatterGraph.ClearData();

            // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();

            if(displaySignalClicked)
                displaySignalButton.PerformClick();
            if(displayNoisySignalClicked)
                displaySignalWithNoiseButton.PerformClick();
            
        }

        private void noiseAmplitude_ValueChanged(object sender, System.EventArgs e)
        {
             // Updation of displayed graphs.
            if(displaySignalClicked)
                displaySignalButton.PerformClick();
            if(displayNoisySignalClicked)
                displaySignalWithNoiseButton.PerformClick();
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
         }

        private void filterDesign_SelectedIndexChanged(object sender, System.EventArgs e)
        {
             // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        private void ripple_ValueChanged(object sender, System.EventArgs e)
        {
             // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        private void attenuation_ValueChanged(object sender, System.EventArgs e)
        {
             // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        private void order_ValueChanged(object sender, System.EventArgs e)
        {
            // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        private void lowerCutoff_ValueChanged(object sender, System.EventArgs e)
        {
            // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        private void upperCutoff_ValueChanged(object sender, System.EventArgs e)
        {
            // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }

        private void displayMode_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // Updation of displayed graphs.
            if(calculateFFTofTheFilteredSignalClicked)
                calculateFFTOfFilteredSignalButton.PerformClick();
            else if(calculateFFTofTheFilteredNoisySignalClicked)
                calculateFFTOfFilteredNoisySignalButton.PerformClick();
            else if(calculateFFTofTheUnfilteredSignalClicked)
                calculateFFTBeforeFilteringButton.PerformClick();
            else if(calculateFFTofTheUnfilteredNoisySignalClicked)
                calculateFFTOfNoisySignalButton.PerformClick();
        }
    }
}
