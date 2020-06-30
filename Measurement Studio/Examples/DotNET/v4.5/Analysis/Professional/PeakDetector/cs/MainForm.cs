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

namespace NationalInstruments.Examples.PeakDetector
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label numOfSamplesLabel;
        private System.Windows.Forms.Label peaksFoundLabel;
        private System.Windows.Forms.Label valleysFoundLabel;
        private System.Windows.Forms.Label peak2ndDerivLabel;
        private System.Windows.Forms.Label peakAmplitudeLabel;
        private NationalInstruments.UI.ScatterPlot signalPlot;
        private NationalInstruments.UI.ScatterPlot amplitudePeakPlot;
        private NationalInstruments.UI.ScatterPlot amplitudeValleyPlot;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.XAxis xAxis;
        private System.Windows.Forms.Label filterOrderLabel;
        
        private System.Windows.Forms.Label signalSourceLabel;
        int numberOfPeaksFound;
        int numberOfValleysFound;
        double []amplitudesPeak;
        double []locationsPeak;
        double []secondDerivativesPeak;
        double []amplitudesValley;
        double []locationsValley;
        double []secondDerivativesValley;
        private System.Windows.Forms.Label thresholdPLabel;
        private System.Windows.Forms.Label thresholdVLabel;
        private System.Windows.Forms.Label numOfCyclesSinLabel;
        private System.Windows.Forms.Label numOfCyclesCosLabel;
        private System.Windows.Forms.Label valleyLocationLabel;
        private System.Windows.Forms.Label valleyAmplitudeLabel;
        private System.Windows.Forms.Label valley2ndDerivLabel;
        private System.Windows.Forms.Label peakLocationLabel;
        private System.Windows.Forms.Label pdWidthLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit numOfCosineCyclesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit filterOrderNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numOfSineCyclesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit valleyLocationIndexNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peak2ndDerivativeIndexNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peakLocationIndexNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit valleyAmplitudeIndexNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peakAmplitudeIndexNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit valley2ndDerivativeIndexNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit pdWidthNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit thresholdPeakNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit thresholdValleyNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit valley2ndDerivativeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit valleyAmplitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit valleyLocationNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peak2ndDerivativeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peakAmplitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peakLocationNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit valleysFoundNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit peaksFoundNumericEdit;
        private System.Windows.Forms.GroupBox inputSignalGroupBox;
        private System.Windows.Forms.GroupBox outputParametersGroupBox;
        private System.Windows.Forms.Button detectPeaksButton;
        private System.Windows.Forms.ComboBox signalSourceComboBox;
        private NationalInstruments.UI.WindowsForms.ScatterGraph signalScatterGraph;
        private System.Windows.Forms.Button peakDetectorHelpButton;
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
            this.signalSourceComboBox = new System.Windows.Forms.ComboBox();
            this.signalSourceLabel = new System.Windows.Forms.Label();
            this.numOfSamplesLabel = new System.Windows.Forms.Label();
            this.peaksFoundLabel = new System.Windows.Forms.Label();
            this.valleysFoundLabel = new System.Windows.Forms.Label();
            this.valleyLocationLabel = new System.Windows.Forms.Label();
            this.valleyAmplitudeLabel = new System.Windows.Forms.Label();
            this.valley2ndDerivLabel = new System.Windows.Forms.Label();
            this.peak2ndDerivLabel = new System.Windows.Forms.Label();
            this.peakAmplitudeLabel = new System.Windows.Forms.Label();
            this.peakLocationLabel = new System.Windows.Forms.Label();
            this.signalScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.signalPlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.amplitudePeakPlot = new NationalInstruments.UI.ScatterPlot();
            this.amplitudeValleyPlot = new NationalInstruments.UI.ScatterPlot();
            this.filterOrderLabel = new System.Windows.Forms.Label();
            this.pdWidthLabel = new System.Windows.Forms.Label();
            this.detectPeaksButton = new System.Windows.Forms.Button();
            this.thresholdPLabel = new System.Windows.Forms.Label();
            this.thresholdVLabel = new System.Windows.Forms.Label();
            this.numOfCyclesSinLabel = new System.Windows.Forms.Label();
            this.numOfCyclesCosLabel = new System.Windows.Forms.Label();
            this.inputSignalGroupBox = new System.Windows.Forms.GroupBox();
            this.numOfCosineCyclesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.filterOrderNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numOfSineCyclesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.outputParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.valleyLocationIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peak2ndDerivativeIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peakLocationIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.valleyAmplitudeIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peakAmplitudeIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.valley2ndDerivativeIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.valley2ndDerivativeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.valleyAmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.valleyLocationNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peak2ndDerivativeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peakAmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peakLocationNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.valleysFoundNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peaksFoundNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peakDetectorHelpButton = new System.Windows.Forms.Button();
            this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.pdWidthNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.thresholdPeakNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.thresholdValleyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.signalScatterGraph)).BeginInit();
            this.inputSignalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOfCosineCyclesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterOrderNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfSineCyclesNumericEdit)).BeginInit();
            this.outputParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valleyLocationIndexNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peak2ndDerivativeIndexNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakLocationIndexNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleyAmplitudeIndexNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakAmplitudeIndexNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valley2ndDerivativeIndexNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valley2ndDerivativeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleyAmplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleyLocationNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peak2ndDerivativeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakAmplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakLocationNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleysFoundNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peaksFoundNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdWidthNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdPeakNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValleyNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // signalSourceComboBox
            // 
            this.signalSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signalSourceComboBox.Items.AddRange(new object[] {
                                                                      "Sine + Cosine",
                                                                      "Filtered Noise"});
            this.signalSourceComboBox.Location = new System.Drawing.Point(16, 40);
            this.signalSourceComboBox.Name = "signalSourceComboBox";
            this.signalSourceComboBox.Size = new System.Drawing.Size(96, 21);
            this.signalSourceComboBox.TabIndex = 0;
            this.signalSourceComboBox.SelectedIndexChanged += new System.EventHandler(this.signalSource_SelectedIndexChanged);
            // 
            // signalSourceLabel
            // 
            this.signalSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signalSourceLabel.Location = new System.Drawing.Point(16, 24);
            this.signalSourceLabel.Name = "signalSourceLabel";
            this.signalSourceLabel.Size = new System.Drawing.Size(88, 16);
            this.signalSourceLabel.TabIndex = 1;
            this.signalSourceLabel.Text = "Signal Source:";
            // 
            // numOfSamplesLabel
            // 
            this.numOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numOfSamplesLabel.Location = new System.Drawing.Point(24, 208);
            this.numOfSamplesLabel.Name = "numOfSamplesLabel";
            this.numOfSamplesLabel.Size = new System.Drawing.Size(104, 16);
            this.numOfSamplesLabel.TabIndex = 3;
            this.numOfSamplesLabel.Text = "Number of Samples:";
            // 
            // peaksFoundLabel
            // 
            this.peaksFoundLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.peaksFoundLabel.Location = new System.Drawing.Point(16, 16);
            this.peaksFoundLabel.Name = "peaksFoundLabel";
            this.peaksFoundLabel.Size = new System.Drawing.Size(88, 16);
            this.peaksFoundLabel.TabIndex = 6;
            this.peaksFoundLabel.Text = "# Peaks Found:";
            // 
            // valleysFoundLabel
            // 
            this.valleysFoundLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.valleysFoundLabel.Location = new System.Drawing.Point(16, 64);
            this.valleysFoundLabel.Name = "valleysFoundLabel";
            this.valleysFoundLabel.Size = new System.Drawing.Size(88, 16);
            this.valleysFoundLabel.TabIndex = 6;
            this.valleysFoundLabel.Text = "# Valleys Found:";
            // 
            // valleyLocationLabel
            // 
            this.valleyLocationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.valleyLocationLabel.Location = new System.Drawing.Point(376, 16);
            this.valleyLocationLabel.Name = "valleyLocationLabel";
            this.valleyLocationLabel.Size = new System.Drawing.Size(88, 16);
            this.valleyLocationLabel.TabIndex = 6;
            this.valleyLocationLabel.Text = "Valley Location:";
            // 
            // valleyAmplitudeLabel
            // 
            this.valleyAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.valleyAmplitudeLabel.Location = new System.Drawing.Point(376, 64);
            this.valleyAmplitudeLabel.Name = "valleyAmplitudeLabel";
            this.valleyAmplitudeLabel.Size = new System.Drawing.Size(104, 16);
            this.valleyAmplitudeLabel.TabIndex = 6;
            this.valleyAmplitudeLabel.Text = "Valley Amplitude:";
            // 
            // valley2ndDerivLabel
            // 
            this.valley2ndDerivLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.valley2ndDerivLabel.Location = new System.Drawing.Point(376, 112);
            this.valley2ndDerivLabel.Name = "valley2ndDerivLabel";
            this.valley2ndDerivLabel.Size = new System.Drawing.Size(120, 16);
            this.valley2ndDerivLabel.TabIndex = 6;
            this.valley2ndDerivLabel.Text = "Valley 2nd Derivative:";
            // 
            // peak2ndDerivLabel
            // 
            this.peak2ndDerivLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.peak2ndDerivLabel.Location = new System.Drawing.Point(192, 112);
            this.peak2ndDerivLabel.Name = "peak2ndDerivLabel";
            this.peak2ndDerivLabel.Size = new System.Drawing.Size(112, 16);
            this.peak2ndDerivLabel.TabIndex = 6;
            this.peak2ndDerivLabel.Text = "Peak 2nd Derivative:";
            // 
            // peakAmplitudeLabel
            // 
            this.peakAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.peakAmplitudeLabel.Location = new System.Drawing.Point(192, 64);
            this.peakAmplitudeLabel.Name = "peakAmplitudeLabel";
            this.peakAmplitudeLabel.Size = new System.Drawing.Size(88, 16);
            this.peakAmplitudeLabel.TabIndex = 6;
            this.peakAmplitudeLabel.Text = "Peak Amplitude:";
            // 
            // peakLocationLabel
            // 
            this.peakLocationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.peakLocationLabel.Location = new System.Drawing.Point(192, 16);
            this.peakLocationLabel.Name = "peakLocationLabel";
            this.peakLocationLabel.Size = new System.Drawing.Size(88, 16);
            this.peakLocationLabel.TabIndex = 6;
            this.peakLocationLabel.Text = "Peak Location:";
            // 
            // signalScatterGraph
            // 
            this.signalScatterGraph.Location = new System.Drawing.Point(224, 8);
            this.signalScatterGraph.Name = "signalScatterGraph";
            this.signalScatterGraph.UseColorGenerator = true;
            this.signalScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                this.signalPlot,
                                                                                                this.amplitudePeakPlot,
                                                                                                this.amplitudeValleyPlot});
            this.signalScatterGraph.Size = new System.Drawing.Size(504, 250);
            this.signalScatterGraph.TabIndex = 3;
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
            // amplitudePeakPlot
            // 
            this.amplitudePeakPlot.LineStyle = NationalInstruments.UI.LineStyle.None;
            this.amplitudePeakPlot.PointColor = System.Drawing.Color.Blue;
            this.amplitudePeakPlot.PointStyle = NationalInstruments.UI.PointStyle.SolidCircle;
            this.amplitudePeakPlot.XAxis = this.xAxis;
            this.amplitudePeakPlot.YAxis = this.yAxis;
            // 
            // amplitudeValleyPlot
            // 
            this.amplitudeValleyPlot.LineStyle = NationalInstruments.UI.LineStyle.None;
            this.amplitudeValleyPlot.PointColor = System.Drawing.Color.White;
            this.amplitudeValleyPlot.PointStyle = NationalInstruments.UI.PointStyle.SolidCircle;
            this.amplitudeValleyPlot.XAxis = this.xAxis;
            this.amplitudeValleyPlot.YAxis = this.yAxis;
            // 
            // filterOrderLabel
            // 
            this.filterOrderLabel.Enabled = false;
            this.filterOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filterOrderLabel.Location = new System.Drawing.Point(128, 80);
            this.filterOrderLabel.Name = "filterOrderLabel";
            this.filterOrderLabel.Size = new System.Drawing.Size(64, 16);
            this.filterOrderLabel.TabIndex = 1;
            this.filterOrderLabel.Text = "Filter Order:";
            // 
            // pdWidthLabel
            // 
            this.pdWidthLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pdWidthLabel.Location = new System.Drawing.Point(136, 208);
            this.pdWidthLabel.Name = "pdWidthLabel";
            this.pdWidthLabel.Size = new System.Drawing.Size(64, 16);
            this.pdWidthLabel.TabIndex = 5;
            this.pdWidthLabel.Text = "PD Width:";
            // 
            // detectPeaksButton
            // 
            this.detectPeaksButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.detectPeaksButton.Location = new System.Drawing.Point(32, 320);
            this.detectPeaksButton.Name = "detectPeaksButton";
            this.detectPeaksButton.Size = new System.Drawing.Size(128, 32);
            this.detectPeaksButton.TabIndex = 0;
            this.detectPeaksButton.Text = "Detect Peaks";
            this.detectPeaksButton.Click += new System.EventHandler(this.detectPeaks_Click);
            // 
            // thresholdPLabel
            // 
            this.thresholdPLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.thresholdPLabel.Location = new System.Drawing.Point(24, 256);
            this.thresholdPLabel.Name = "thresholdPLabel";
            this.thresholdPLabel.Size = new System.Drawing.Size(88, 16);
            this.thresholdPLabel.TabIndex = 7;
            this.thresholdPLabel.Text = "Threshold Peak:";
            // 
            // thresholdVLabel
            // 
            this.thresholdVLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.thresholdVLabel.Location = new System.Drawing.Point(136, 256);
            this.thresholdVLabel.Name = "thresholdVLabel";
            this.thresholdVLabel.Size = new System.Drawing.Size(88, 16);
            this.thresholdVLabel.TabIndex = 9;
            this.thresholdVLabel.Text = "Threshold Valley:";
            // 
            // numOfCyclesSinLabel
            // 
            this.numOfCyclesSinLabel.Enabled = false;
            this.numOfCyclesSinLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numOfCyclesSinLabel.Location = new System.Drawing.Point(16, 80);
            this.numOfCyclesSinLabel.Name = "numOfCyclesSinLabel";
            this.numOfCyclesSinLabel.Size = new System.Drawing.Size(80, 16);
            this.numOfCyclesSinLabel.TabIndex = 12;
            this.numOfCyclesSinLabel.Text = "Cycles of Sine:";
            // 
            // numOfCyclesCosLabel
            // 
            this.numOfCyclesCosLabel.Enabled = false;
            this.numOfCyclesCosLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numOfCyclesCosLabel.Location = new System.Drawing.Point(16, 128);
            this.numOfCyclesCosLabel.Name = "numOfCyclesCosLabel";
            this.numOfCyclesCosLabel.Size = new System.Drawing.Size(80, 16);
            this.numOfCyclesCosLabel.TabIndex = 12;
            this.numOfCyclesCosLabel.Text = "Cycles of Cos:";
            // 
            // inputSignalGroupBox
            // 
            this.inputSignalGroupBox.Controls.Add(this.numOfCosineCyclesNumericEdit);
            this.inputSignalGroupBox.Controls.Add(this.filterOrderNumericEdit);
            this.inputSignalGroupBox.Controls.Add(this.numOfSineCyclesNumericEdit);
            this.inputSignalGroupBox.Controls.Add(this.signalSourceLabel);
            this.inputSignalGroupBox.Controls.Add(this.signalSourceComboBox);
            this.inputSignalGroupBox.Controls.Add(this.numOfCyclesSinLabel);
            this.inputSignalGroupBox.Controls.Add(this.numOfCyclesCosLabel);
            this.inputSignalGroupBox.Controls.Add(this.filterOrderLabel);
            this.inputSignalGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputSignalGroupBox.Location = new System.Drawing.Point(8, 8);
            this.inputSignalGroupBox.Name = "inputSignalGroupBox";
            this.inputSignalGroupBox.Size = new System.Drawing.Size(208, 176);
            this.inputSignalGroupBox.TabIndex = 2;
            this.inputSignalGroupBox.TabStop = false;
            this.inputSignalGroupBox.Text = "Input Signal";
            // 
            // numOfCosineCyclesNumericEdit
            // 
            this.numOfCosineCyclesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numOfCosineCyclesNumericEdit.Location = new System.Drawing.Point(16, 144);
            this.numOfCosineCyclesNumericEdit.Name = "numOfCosineCyclesNumericEdit";
            this.numOfCosineCyclesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numOfCosineCyclesNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.numOfCosineCyclesNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.numOfCosineCyclesNumericEdit.TabIndex = 3;
            this.numOfCosineCyclesNumericEdit.Value = 1;
            this.numOfCosineCyclesNumericEdit.ValueChanged += new System.EventHandler(this.numOfCosineCycles_ValueChanged);
            // 
            // filterOrderNumericEdit
            // 
            this.filterOrderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.filterOrderNumericEdit.Location = new System.Drawing.Point(128, 96);
            this.filterOrderNumericEdit.Name = "filterOrderNumericEdit";
            this.filterOrderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.filterOrderNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.filterOrderNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.filterOrderNumericEdit.TabIndex = 2;
            this.filterOrderNumericEdit.Value = 2;
            this.filterOrderNumericEdit.ValueChanged += new System.EventHandler(this.filterOrder_ValueChanged);
            // 
            // numOfSineCyclesNumericEdit
            // 
            this.numOfSineCyclesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numOfSineCyclesNumericEdit.Location = new System.Drawing.Point(16, 96);
            this.numOfSineCyclesNumericEdit.Name = "numOfSineCyclesNumericEdit";
            this.numOfSineCyclesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numOfSineCyclesNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.numOfSineCyclesNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.numOfSineCyclesNumericEdit.TabIndex = 1;
            this.numOfSineCyclesNumericEdit.Value = 20;
            this.numOfSineCyclesNumericEdit.ValueChanged += new System.EventHandler(this.numOfSineCycles_ValueChanged);
            // 
            // outputParametersGroupBox
            // 
            this.outputParametersGroupBox.Controls.Add(this.valleyLocationIndexNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peak2ndDerivativeIndexNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peakLocationIndexNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.valleyAmplitudeIndexNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peakAmplitudeIndexNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.valley2ndDerivativeIndexNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.valley2ndDerivativeNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.valleyAmplitudeNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.valleyLocationNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peak2ndDerivativeNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peakAmplitudeNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peakLocationNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.valleysFoundNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peaksFoundNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.peak2ndDerivLabel);
            this.outputParametersGroupBox.Controls.Add(this.peakLocationLabel);
            this.outputParametersGroupBox.Controls.Add(this.peakAmplitudeLabel);
            this.outputParametersGroupBox.Controls.Add(this.peaksFoundLabel);
            this.outputParametersGroupBox.Controls.Add(this.valleysFoundLabel);
            this.outputParametersGroupBox.Controls.Add(this.valleyLocationLabel);
            this.outputParametersGroupBox.Controls.Add(this.valleyAmplitudeLabel);
            this.outputParametersGroupBox.Controls.Add(this.valley2ndDerivLabel);
            this.outputParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.outputParametersGroupBox.Location = new System.Drawing.Point(224, 264);
            this.outputParametersGroupBox.Name = "outputParametersGroupBox";
            this.outputParametersGroupBox.Size = new System.Drawing.Size(504, 160);
            this.outputParametersGroupBox.TabIndex = 1;
            this.outputParametersGroupBox.TabStop = false;
            this.outputParametersGroupBox.Text = "Output Parameters";
            // 
            // valleyLocationIndexNumericEdit
            // 
            this.valleyLocationIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.valleyLocationIndexNumericEdit.Location = new System.Drawing.Point(336, 32);
            this.valleyLocationIndexNumericEdit.Name = "valleyLocationIndexNumericEdit";
            this.valleyLocationIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.valleyLocationIndexNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.valleyLocationIndexNumericEdit.Size = new System.Drawing.Size(40, 20);
            this.valleyLocationIndexNumericEdit.TabIndex = 4;
            this.valleyLocationIndexNumericEdit.Value = 1;
            this.valleyLocationIndexNumericEdit.ValueChanged += new System.EventHandler(this.valleyLocationIndex_ValueChanged);
            // 
            // peak2ndDerivativeIndexNumericEdit
            // 
            this.peak2ndDerivativeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.peak2ndDerivativeIndexNumericEdit.Location = new System.Drawing.Point(152, 128);
            this.peak2ndDerivativeIndexNumericEdit.Name = "peak2ndDerivativeIndexNumericEdit";
            this.peak2ndDerivativeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.peak2ndDerivativeIndexNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.peak2ndDerivativeIndexNumericEdit.Size = new System.Drawing.Size(40, 20);
            this.peak2ndDerivativeIndexNumericEdit.TabIndex = 3;
            this.peak2ndDerivativeIndexNumericEdit.Value = 1;
            this.peak2ndDerivativeIndexNumericEdit.ValueChanged += new System.EventHandler(this.peak2ndDerivativeIndex_ValueChanged);
            // 
            // peakLocationIndexNumericEdit
            // 
            this.peakLocationIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.peakLocationIndexNumericEdit.Location = new System.Drawing.Point(152, 32);
            this.peakLocationIndexNumericEdit.Name = "peakLocationIndexNumericEdit";
            this.peakLocationIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.peakLocationIndexNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.peakLocationIndexNumericEdit.Size = new System.Drawing.Size(40, 20);
            this.peakLocationIndexNumericEdit.TabIndex = 1;
            this.peakLocationIndexNumericEdit.Value = 1;
            this.peakLocationIndexNumericEdit.ValueChanged += new System.EventHandler(this.peakLocationIndex_ValueChanged);
            // 
            // valleyAmplitudeIndexNumericEdit
            // 
            this.valleyAmplitudeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.valleyAmplitudeIndexNumericEdit.Location = new System.Drawing.Point(336, 80);
            this.valleyAmplitudeIndexNumericEdit.Name = "valleyAmplitudeIndexNumericEdit";
            this.valleyAmplitudeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.valleyAmplitudeIndexNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.valleyAmplitudeIndexNumericEdit.Size = new System.Drawing.Size(40, 20);
            this.valleyAmplitudeIndexNumericEdit.TabIndex = 5;
            this.valleyAmplitudeIndexNumericEdit.Value = 1;
            this.valleyAmplitudeIndexNumericEdit.ValueChanged += new System.EventHandler(this.valleyAmplitudeIndex_ValueChanged);
            // 
            // peakAmplitudeIndexNumericEdit
            // 
            this.peakAmplitudeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.peakAmplitudeIndexNumericEdit.Location = new System.Drawing.Point(152, 80);
            this.peakAmplitudeIndexNumericEdit.Name = "peakAmplitudeIndexNumericEdit";
            this.peakAmplitudeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.peakAmplitudeIndexNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.peakAmplitudeIndexNumericEdit.Size = new System.Drawing.Size(40, 20);
            this.peakAmplitudeIndexNumericEdit.TabIndex = 2;
            this.peakAmplitudeIndexNumericEdit.Value = 1;
            this.peakAmplitudeIndexNumericEdit.ValueChanged += new System.EventHandler(this.peakAmplitudeIndex_ValueChanged);
            // 
            // valley2ndDerivativeIndexNumericEdit
            // 
            this.valley2ndDerivativeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.valley2ndDerivativeIndexNumericEdit.Location = new System.Drawing.Point(336, 128);
            this.valley2ndDerivativeIndexNumericEdit.Name = "valley2ndDerivativeIndexNumericEdit";
            this.valley2ndDerivativeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.valley2ndDerivativeIndexNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.valley2ndDerivativeIndexNumericEdit.Size = new System.Drawing.Size(40, 20);
            this.valley2ndDerivativeIndexNumericEdit.TabIndex = 6;
            this.valley2ndDerivativeIndexNumericEdit.Value = 1;
            this.valley2ndDerivativeIndexNumericEdit.ValueChanged += new System.EventHandler(this.valley2ndDerivativeIndex_ValueChanged);
            // 
            // valley2ndDerivativeNumericEdit
            // 
            this.valley2ndDerivativeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.valley2ndDerivativeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.valley2ndDerivativeNumericEdit.Location = new System.Drawing.Point(376, 128);
            this.valley2ndDerivativeNumericEdit.Name = "valley2ndDerivativeNumericEdit";
            this.valley2ndDerivativeNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.valley2ndDerivativeNumericEdit.TabIndex = 14;
            this.valley2ndDerivativeNumericEdit.TabStop = false;
            // 
            // valleyAmplitudeNumericEdit
            // 
            this.valleyAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.valleyAmplitudeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.valleyAmplitudeNumericEdit.Location = new System.Drawing.Point(376, 80);
            this.valleyAmplitudeNumericEdit.Name = "valleyAmplitudeNumericEdit";
            this.valleyAmplitudeNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.valleyAmplitudeNumericEdit.TabIndex = 13;
            this.valleyAmplitudeNumericEdit.TabStop = false;
            // 
            // valleyLocationNumericEdit
            // 
            this.valleyLocationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.valleyLocationNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.valleyLocationNumericEdit.Location = new System.Drawing.Point(376, 32);
            this.valleyLocationNumericEdit.Name = "valleyLocationNumericEdit";
            this.valleyLocationNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.valleyLocationNumericEdit.TabIndex = 12;
            this.valleyLocationNumericEdit.TabStop = false;
            // 
            // peak2ndDerivativeNumericEdit
            // 
            this.peak2ndDerivativeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.peak2ndDerivativeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peak2ndDerivativeNumericEdit.Location = new System.Drawing.Point(192, 128);
            this.peak2ndDerivativeNumericEdit.Name = "peak2ndDerivativeNumericEdit";
            this.peak2ndDerivativeNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.peak2ndDerivativeNumericEdit.TabIndex = 11;
            this.peak2ndDerivativeNumericEdit.TabStop = false;
            // 
            // peakAmplitudeNumericEdit
            // 
            this.peakAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.peakAmplitudeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peakAmplitudeNumericEdit.Location = new System.Drawing.Point(192, 80);
            this.peakAmplitudeNumericEdit.Name = "peakAmplitudeNumericEdit";
            this.peakAmplitudeNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.peakAmplitudeNumericEdit.TabIndex = 10;
            this.peakAmplitudeNumericEdit.TabStop = false;
            // 
            // peakLocationNumericEdit
            // 
            this.peakLocationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.peakLocationNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peakLocationNumericEdit.Location = new System.Drawing.Point(192, 32);
            this.peakLocationNumericEdit.Name = "peakLocationNumericEdit";
            this.peakLocationNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.peakLocationNumericEdit.TabIndex = 9;
            this.peakLocationNumericEdit.TabStop = false;
            // 
            // valleysFoundNumericEdit
            // 
            this.valleysFoundNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.valleysFoundNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.valleysFoundNumericEdit.Location = new System.Drawing.Point(16, 80);
            this.valleysFoundNumericEdit.Name = "valleysFoundNumericEdit";
            this.valleysFoundNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.valleysFoundNumericEdit.TabIndex = 8;
            this.valleysFoundNumericEdit.TabStop = false;
            // 
            // peaksFoundNumericEdit
            // 
            this.peaksFoundNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.peaksFoundNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peaksFoundNumericEdit.Location = new System.Drawing.Point(16, 32);
            this.peaksFoundNumericEdit.Name = "peaksFoundNumericEdit";
            this.peaksFoundNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.peaksFoundNumericEdit.TabIndex = 7;
            this.peaksFoundNumericEdit.TabStop = false;
            // 
            // peakDetectorHelpButton
            // 
            this.peakDetectorHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.peakDetectorHelpButton.Location = new System.Drawing.Point(32, 368);
            this.peakDetectorHelpButton.Name = "peakDetectorHelpButton";
            this.peakDetectorHelpButton.Size = new System.Drawing.Size(128, 32);
            this.peakDetectorHelpButton.TabIndex = 1;
            this.peakDetectorHelpButton.Text = "Help";
            this.peakDetectorHelpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // numberOfSamplesNumericEdit
            // 
            this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(24, 224);
            this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
            this.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfSamplesNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.numberOfSamplesNumericEdit.TabIndex = 4;
            this.numberOfSamplesNumericEdit.Value = 100;
            this.numberOfSamplesNumericEdit.ValueChanged += new System.EventHandler(this.numberOfSamples_ValueChanged);
            // 
            // pdWidthNumericEdit
            // 
            this.pdWidthNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.pdWidthNumericEdit.Location = new System.Drawing.Point(136, 224);
            this.pdWidthNumericEdit.Name = "pdWidthNumericEdit";
            this.pdWidthNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.pdWidthNumericEdit.Range = new NationalInstruments.UI.Range(3, System.Double.PositiveInfinity);
            this.pdWidthNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.pdWidthNumericEdit.TabIndex = 6;
            this.pdWidthNumericEdit.Value = 3;
            this.pdWidthNumericEdit.ValueChanged += new System.EventHandler(this.pdWidth_ValueChanged);
            // 
            // thresholdPeakNumericEdit
            // 
            this.thresholdPeakNumericEdit.CoercionInterval = 0.01;
            this.thresholdPeakNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.thresholdPeakNumericEdit.Location = new System.Drawing.Point(24, 272);
            this.thresholdPeakNumericEdit.Name = "thresholdPeakNumericEdit";
            this.thresholdPeakNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.thresholdPeakNumericEdit.Range = new NationalInstruments.UI.Range(0, 2);
            this.thresholdPeakNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.thresholdPeakNumericEdit.TabIndex = 8;
            this.thresholdPeakNumericEdit.ValueChanged += new System.EventHandler(this.thresholdPeak_ValueChanged);
            // 
            // thresholdValleyNumericEdit
            // 
            this.thresholdValleyNumericEdit.CoercionInterval = 0.01;
            this.thresholdValleyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.thresholdValleyNumericEdit.Location = new System.Drawing.Point(136, 272);
            this.thresholdValleyNumericEdit.Name = "thresholdValleyNumericEdit";
            this.thresholdValleyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.thresholdValleyNumericEdit.Range = new NationalInstruments.UI.Range(-2, 0);
            this.thresholdValleyNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.thresholdValleyNumericEdit.TabIndex = 10;
            this.thresholdValleyNumericEdit.ValueChanged += new System.EventHandler(this.thresholdValley_ValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(738, 432);
            this.Controls.Add(this.numberOfSamplesNumericEdit);
            this.Controls.Add(this.peakDetectorHelpButton);
            this.Controls.Add(this.outputParametersGroupBox);
            this.Controls.Add(this.inputSignalGroupBox);
            this.Controls.Add(this.numOfSamplesLabel);
            this.Controls.Add(this.thresholdPLabel);
            this.Controls.Add(this.thresholdVLabel);
            this.Controls.Add(this.pdWidthLabel);
            this.Controls.Add(this.detectPeaksButton);
            this.Controls.Add(this.signalScatterGraph);
            this.Controls.Add(this.pdWidthNumericEdit);
            this.Controls.Add(this.thresholdPeakNumericEdit);
            this.Controls.Add(this.thresholdValleyNumericEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peak Detector";
            ((System.ComponentModel.ISupportInitialize)(this.signalScatterGraph)).EndInit();
            this.inputSignalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numOfCosineCyclesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterOrderNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOfSineCyclesNumericEdit)).EndInit();
            this.outputParametersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valleyLocationIndexNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peak2ndDerivativeIndexNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakLocationIndexNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleyAmplitudeIndexNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakAmplitudeIndexNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valley2ndDerivativeIndexNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valley2ndDerivativeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleyAmplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleyLocationNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peak2ndDerivativeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakAmplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakLocationNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valleysFoundNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peaksFoundNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pdWidthNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdPeakNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdValleyNumericEdit)).EndInit();
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

        // When Detect Peak button is clicked.
        private void detectPeaks_Click(object sender, System.EventArgs e)
        {
          DetectionOfPeaks(); 
        }

        // On change of peakLocationIndex.
        private void peakLocationIndex_ValueChanged(object sender, System.EventArgs e)
        {
            if((int)peakLocationIndexNumericEdit.Value > numberOfPeaksFound)
                peakLocationNumericEdit.Enabled = false; // Disable peakLocation if index is beyond the number of peaks found.
            else
            {
                peakLocationNumericEdit.Enabled = true;
                peakLocationNumericEdit.Value= locationsPeak[((int)peakLocationIndexNumericEdit.Value - 1)];
            }
        }

        // On change of peakAmplitudeIndex.
        private void peakAmplitudeIndex_ValueChanged(object sender, System.EventArgs e)
        {
            if((int)peakAmplitudeIndexNumericEdit.Value > numberOfPeaksFound)
                peakAmplitudeNumericEdit.Enabled = false;
            else
            {
                peakAmplitudeNumericEdit.Enabled = true;
                peakAmplitudeNumericEdit.Value= amplitudesPeak[((int)peakAmplitudeIndexNumericEdit.Value - 1)];
            }
        }

         // On change of peak2ndDErivativeIndex.
        private void peak2ndDerivativeIndex_ValueChanged(object sender, System.EventArgs e)
        {
            if((int)peak2ndDerivativeIndexNumericEdit.Value > numberOfPeaksFound)
                peak2ndDerivativeNumericEdit.Enabled = false;
            else
            {
                peak2ndDerivativeNumericEdit.Enabled = true;
                peak2ndDerivativeNumericEdit.Value = secondDerivativesPeak[((int)peak2ndDerivativeIndexNumericEdit.Value - 1)];
            }
        }

         // On change of valleysLocationIndex.
        private void valleyLocationIndex_ValueChanged(object sender, System.EventArgs e)
        {
            if((int)valleyLocationIndexNumericEdit.Value > numberOfValleysFound)
                valleyLocationNumericEdit.Enabled = false;
            else
            {
                valleyLocationNumericEdit.Enabled = true;
                valleyLocationNumericEdit.Value= locationsValley[((int)valleyLocationIndexNumericEdit.Value - 1)];
            }
        }

        // On change of valleysAmplitudeIndex.
        private void valleyAmplitudeIndex_ValueChanged(object sender, System.EventArgs e)
        {
            if((int)valleyAmplitudeIndexNumericEdit.Value > numberOfValleysFound) 
                valleyAmplitudeNumericEdit.Enabled = false;
            else
            {
                valleyAmplitudeNumericEdit.Enabled = true;
                valleyAmplitudeNumericEdit.Value = amplitudesValley[((int)valleyAmplitudeIndexNumericEdit.Value - 1)];
            }
        }

        // On change of valleys2ndDerivativeIndex.
        private void valley2ndDerivativeIndex_ValueChanged(object sender, System.EventArgs e)
        {
            if((int)valley2ndDerivativeIndexNumericEdit.Value > numberOfValleysFound) 
                valley2ndDerivativeNumericEdit.Enabled = false;
            else
            {
                valley2ndDerivativeNumericEdit.Enabled = true;
                valley2ndDerivativeNumericEdit.Value = secondDerivativesValley[((int)valley2ndDerivativeIndexNumericEdit.Value - 1)];
            }
        }

        // On change of thresholdPeak value.
        private void thresholdPeak_ValueChanged(object sender, System.EventArgs e)
        {
          DetectionOfPeaks();
        }

        // On change of thresholdValley value.
        private void thresholdValley_ValueChanged(object sender, System.EventArgs e)
        {
            DetectionOfPeaks();
        }
        
        // On change of signal source.
        private void signalSource_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (signalSourceComboBox.SelectedIndex)
            {
                    // Sin + Cos
                case 0:
                    numOfSineCyclesNumericEdit.Enabled = true;
                    numOfCosineCyclesNumericEdit.Enabled = true;
                    numOfCyclesCosLabel.Enabled = true;
                    numOfCyclesSinLabel.Enabled = true;
                    filterOrderNumericEdit.Enabled = false;
                    filterOrderLabel.Enabled = false;
                    break;
                    // Filtered Noise
                case 1:
                    filterOrderNumericEdit.Enabled = true;
                    filterOrderLabel.Enabled = true;
                    numOfSineCyclesNumericEdit.Enabled = false;
                    numOfCosineCyclesNumericEdit.Enabled = false;
                    numOfCyclesCosLabel.Enabled = false;
                    numOfCyclesSinLabel.Enabled = false;
                    break;
            }
            detectPeaksButton.PerformClick(); // Detect peaks.
        }

        private void helpButton_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("This example demonstrates the use of the Peak Detector. Threshold Peak and Threshold Valley controls are used to set threshold for peaks and valleys. The default value of threshold is 0.0. PD Width controls the number of consecutive data points to be used in the quadratic least squares fit for the detection of peaks.","HELP");
        
        }

        // Detection of peaks.
        void DetectionOfPeaks()
        {
            int i;
            double []waveform = new double[(int)numberOfSamplesNumericEdit.Value];
            double []xwave = new double[(int)numberOfSamplesNumericEdit.Value];
            
            PeakPolarity peakPolarity = PeakPolarity.Peaks;
            NationalInstruments.Analysis.Monitoring.PeakDetector peakDetect 
                = new NationalInstruments.Analysis.Monitoring.PeakDetector(thresholdPeakNumericEdit.Value,(int)pdWidthNumericEdit.Value, peakPolarity);
            switch(signalSourceComboBox.SelectedIndex)
            {
                // Sin + Cos.
                case 0:
                default:
                    // initialize signal generator with a sine wave
                    SignalGenerator sigGen 
                        = new SignalGenerator(numberOfSamplesNumericEdit.Value, (int)numberOfSamplesNumericEdit.Value, 
                        new SineSignal(numOfSineCyclesNumericEdit.Value, 1.0, 0.0));
                    sigGen.Signals.Add(new SineSignal(numOfCosineCyclesNumericEdit.Value, 1.0, 90.0));// add a cosine wave to the existing waveform
                    waveform = sigGen.Generate();//generate the combined waveform
                    break;
                // Filtered Noise.
                case 1:
                    double []noiseWaveform = new double[(int)numberOfSamplesNumericEdit.Value];
                    GaussianNoiseSignal gaussianNoise = new GaussianNoiseSignal(1.0, 1);
                    EllipticLowpassFilter ellipticFilter 
                        = new EllipticLowpassFilter((int)filterOrderNumericEdit.Value,1.0, 0.125,1.0 ,60.0 );
                    noiseWaveform = gaussianNoise.Generate(100.0, (int)numberOfSamplesNumericEdit.Value);
                    waveform = ellipticFilter.FilterData(noiseWaveform);
                    break;
            }
            
            // Detection and Plotting of Peaks           
            peakDetect.Detect(waveform, true, out amplitudesPeak, out locationsPeak, out secondDerivativesPeak);
            numberOfPeaksFound = amplitudesPeak.Length;
            peaksFoundNumericEdit.Value= numberOfPeaksFound;
            for(i=0; i< (int)numberOfSamplesNumericEdit.Value ; i++)
            {
                xwave[i] = i;
            }
            signalPlot.PlotXY(xwave, waveform);
            amplitudePeakPlot.LineStyle = LineStyle.None;
            amplitudePeakPlot.PointStyle = PointStyle.SolidCircle;
            amplitudePeakPlot.PlotXY(locationsPeak, amplitudesPeak);
                                
            // Detection and Plotting of Valleys
            peakPolarity = PeakPolarity.Valleys;
            peakDetect.Reset(thresholdValleyNumericEdit.Value, (int)pdWidthNumericEdit.Value, peakPolarity);
            peakDetect.Detect(waveform, true, out amplitudesValley, out locationsValley, out secondDerivativesValley);
            numberOfValleysFound = amplitudesValley.Length;
            valleysFoundNumericEdit.Value = numberOfValleysFound;
            amplitudeValleyPlot.LineStyle = LineStyle.None;
            amplitudeValleyPlot.PointStyle = PointStyle.SolidCircle;
            amplitudeValleyPlot.PlotXY(locationsValley, amplitudesValley);

            UpdatePeaksAndValleys();        
            
            }

        private void UpdatePeaksAndValleys()
        {
            // Update Output Parameters by forcing a downButton event
            peakLocationIndexNumericEdit.Value = 2;
            peakLocationIndexNumericEdit.DownButton();
            peakAmplitudeIndexNumericEdit.Value = 2;
            peakAmplitudeIndexNumericEdit.DownButton();
            peak2ndDerivativeIndexNumericEdit.Value = 2;
            peak2ndDerivativeIndexNumericEdit.DownButton();
            valley2ndDerivativeIndexNumericEdit.Value = 2;
            valley2ndDerivativeIndexNumericEdit.DownButton();
            valleyAmplitudeIndexNumericEdit.Value = 2;
            valleyAmplitudeIndexNumericEdit.DownButton();
            valleyLocationIndexNumericEdit.Value = 2;
            valleyLocationIndexNumericEdit.DownButton();
        }

        private void numberOfSamples_ValueChanged(object sender, System.EventArgs e)
        {
            detectPeaksButton.PerformClick();
        }

        private void pdWidth_ValueChanged(object sender, System.EventArgs e)
        {
            detectPeaksButton.PerformClick();
        }

        private void numOfSineCycles_ValueChanged(object sender, System.EventArgs e)
        {
            detectPeaksButton.PerformClick();
        
        }

        private void filterOrder_ValueChanged(object sender, System.EventArgs e)
        {
            detectPeaksButton.PerformClick();
        }

        private void numOfCosineCycles_ValueChanged(object sender, System.EventArgs e)
        {
            detectPeaksButton.PerformClick();
        }

    }
}
