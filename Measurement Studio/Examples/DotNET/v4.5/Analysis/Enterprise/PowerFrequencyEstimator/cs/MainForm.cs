//==================================================================================================
//
// Title      : MainForm.cs
// Purpose    : This example shows the user how to use the Spectrum and PowerFrequencyEstimate 
//              functions.
//
//==================================================================================================
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
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.PowerFrequencyEstimator
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        // Global Variables.
        double []waveform;
        double []autoPowerSpectrum;
        double []noiseWave;
        double searchFrequency;
        double equivalentNoiseBandwidth;
        double coherentGain;
        double df;
        internal NationalInstruments.UI.XYCursor xyCursor;
        internal NationalInstruments.UI.WaveformPlot powerPlot;
        internal NationalInstruments.UI.XAxis powerXAxis;
        internal NationalInstruments.UI.YAxis powerYAxis;
        internal NationalInstruments.UI.XAxis inputXAxis;
        internal NationalInstruments.UI.WaveformPlot inputSignalPlot;
        internal NationalInstruments.UI.YAxis inputYAxis;
        internal System.Windows.Forms.ToolTip toolTip;
        internal System.Windows.Forms.GroupBox settingsGroupBox;
        internal System.Windows.Forms.Label inputSignalLabel;
        internal System.Windows.Forms.Label windowOpsLabel;
        internal System.Windows.Forms.Label unitsLabel;
        internal System.Windows.Forms.Label scaleLabel;
        internal System.Windows.Forms.Label noiseRatioLabel;
        internal System.Windows.Forms.Label descriptionLabel;
        internal System.Windows.Forms.Label peakFrequencyLabel;
        internal System.Windows.Forms.Label powerPeakLabel;
        internal System.Windows.Forms.ComboBox inputSignalComboBox;
        internal System.Windows.Forms.ComboBox windowComboBox;
        internal System.Windows.Forms.ComboBox unitsComboBox;
        internal System.Windows.Forms.ComboBox scaleComboBox;
        internal NationalInstruments.UI.WindowsForms.NumericEdit noiseRatioNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit peakPowerNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit peakFrequencyNumericEdit;
        internal System.Windows.Forms.Button powerFrequencyEstimateButton;
        internal NationalInstruments.UI.WindowsForms.WaveformGraph powerSpectrumWaveformGraph;
        internal NationalInstruments.UI.WindowsForms.WaveformGraph inputSignalWaveformGraph;
        bool powerFrequencyEstimateClicked = false;
       

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            inputSignalComboBox.SelectedIndex = 0;
            windowComboBox.SelectedIndex = 0;
            scaleComboBox.SelectedIndex = 0;
            unitsComboBox.SelectedIndex = 0;
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
            this.xyCursor = new NationalInstruments.UI.XYCursor();
            this.powerPlot = new NationalInstruments.UI.WaveformPlot();
            this.powerXAxis = new NationalInstruments.UI.XAxis();
            this.powerYAxis = new NationalInstruments.UI.YAxis();
            this.inputXAxis = new NationalInstruments.UI.XAxis();
            this.inputSignalPlot = new NationalInstruments.UI.WaveformPlot();
            this.inputYAxis = new NationalInstruments.UI.YAxis();
            this.peakPowerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.powerFrequencyEstimateButton = new System.Windows.Forms.Button();
            this.peakFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.noiseRatioNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.inputSignalComboBox = new System.Windows.Forms.ComboBox();
            this.inputSignalLabel = new System.Windows.Forms.Label();
            this.windowComboBox = new System.Windows.Forms.ComboBox();
            this.windowOpsLabel = new System.Windows.Forms.Label();
            this.unitsComboBox = new System.Windows.Forms.ComboBox();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.scaleComboBox = new System.Windows.Forms.ComboBox();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.noiseRatioLabel = new System.Windows.Forms.Label();
            this.powerSpectrumWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.inputSignalWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.peakFrequencyLabel = new System.Windows.Forms.Label();
            this.powerPeakLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakPowerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakFrequencyNumericEdit)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noiseRatioNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSpectrumWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSignalWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // xyCursor
            // 
            this.xyCursor.Color = System.Drawing.Color.Green;
            this.xyCursor.Plot = this.powerPlot;
            this.xyCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating;
            this.xyCursor.XPosition = 0;
            this.xyCursor.YPosition = 0.5;
            // 
            // powerPlot
            // 
            this.powerPlot.XAxis = this.powerXAxis;
            this.powerPlot.YAxis = this.powerYAxis;
            // 
            // powerXAxis
            // 
            this.powerXAxis.Caption = "Hz";
            // 
            // powerYAxis
            // 
            this.powerYAxis.Caption = "Vrms";
            // 
            // inputXAxis
            // 
            this.inputXAxis.Caption = "Sec";
            this.inputXAxis.MajorDivisions.GridColor = System.Drawing.Color.Cyan;
            this.inputXAxis.MajorDivisions.GridVisible = true;
            this.inputXAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            // 
            // inputSignalPlot
            // 
            this.inputSignalPlot.XAxis = this.inputXAxis;
            this.inputSignalPlot.YAxis = this.inputYAxis;
            // 
            // inputYAxis
            // 
            this.inputYAxis.Caption = "Amplitude";
            // 
            // peakPowerNumericEdit
            // 
            this.peakPowerNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.peakPowerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peakPowerNumericEdit.Location = new System.Drawing.Point(40, 350);
            this.peakPowerNumericEdit.Name = "peakPowerNumericEdit";
            this.peakPowerNumericEdit.Size = new System.Drawing.Size(104, 20);
            this.peakPowerNumericEdit.TabIndex = 32;
            this.peakPowerNumericEdit.TabStop = false;
            // 
            // powerFrequencyEstimateButton
            // 
            this.powerFrequencyEstimateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.powerFrequencyEstimateButton.Location = new System.Drawing.Point(16, 382);
            this.powerFrequencyEstimateButton.Name = "powerFrequencyEstimateButton";
            this.powerFrequencyEstimateButton.Size = new System.Drawing.Size(152, 32);
            this.powerFrequencyEstimateButton.TabIndex = 0;
            this.powerFrequencyEstimateButton.Text = "Power Frequency Estimate";
            this.toolTip.SetToolTip(this.powerFrequencyEstimateButton, "Calculate the estimated power and frequency around a peak in the Power Spectrum.");
            this.powerFrequencyEstimateButton.Click += new System.EventHandler(this.powerFrequencyEstimate_Click);
            // 
            // peakFrequencyNumericEdit
            // 
            this.peakFrequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.peakFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.peakFrequencyNumericEdit.Location = new System.Drawing.Point(40, 310);
            this.peakFrequencyNumericEdit.Name = "peakFrequencyNumericEdit";
            this.peakFrequencyNumericEdit.Size = new System.Drawing.Size(104, 20);
            this.peakFrequencyNumericEdit.TabIndex = 31;
            this.peakFrequencyNumericEdit.TabStop = false;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.noiseRatioNumericEdit);
            this.settingsGroupBox.Controls.Add(this.inputSignalComboBox);
            this.settingsGroupBox.Controls.Add(this.inputSignalLabel);
            this.settingsGroupBox.Controls.Add(this.windowComboBox);
            this.settingsGroupBox.Controls.Add(this.windowOpsLabel);
            this.settingsGroupBox.Controls.Add(this.unitsComboBox);
            this.settingsGroupBox.Controls.Add(this.unitsLabel);
            this.settingsGroupBox.Controls.Add(this.scaleComboBox);
            this.settingsGroupBox.Controls.Add(this.scaleLabel);
            this.settingsGroupBox.Controls.Add(this.noiseRatioLabel);
            this.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsGroupBox.Location = new System.Drawing.Point(24, 14);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(136, 264);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Signal Parameters";
            // 
            // noiseRatioNumericEdit
            // 
            this.noiseRatioNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.noiseRatioNumericEdit.Location = new System.Drawing.Point(16, 232);
            this.noiseRatioNumericEdit.Name = "noiseRatioNumericEdit";
            this.noiseRatioNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.noiseRatioNumericEdit.Size = new System.Drawing.Size(104, 20);
            this.noiseRatioNumericEdit.TabIndex = 4;
            this.noiseRatioNumericEdit.ValueChanged += new System.EventHandler(this.noiseRatio_ValueChanged);
            // 
            // inputSignalComboBox
            // 
            this.inputSignalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputSignalComboBox.Items.AddRange(new object[] {
                                                                     "Square",
                                                                     "SineWave",
                                                                     "Triangular"});
            this.inputSignalComboBox.Location = new System.Drawing.Point(16, 40);
            this.inputSignalComboBox.Name = "inputSignalComboBox";
            this.inputSignalComboBox.Size = new System.Drawing.Size(104, 21);
            this.inputSignalComboBox.TabIndex = 0;
            this.inputSignalComboBox.SelectedIndexChanged += new System.EventHandler(this.inputSignal_SelectedIndexChanged);
            // 
            // inputSignalLabel
            // 
            this.inputSignalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputSignalLabel.Location = new System.Drawing.Point(16, 24);
            this.inputSignalLabel.Name = "inputSignalLabel";
            this.inputSignalLabel.Size = new System.Drawing.Size(72, 16);
            this.inputSignalLabel.TabIndex = 3;
            this.inputSignalLabel.Text = "Input Signal:";
            // 
            // windowComboBox
            // 
            this.windowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowComboBox.Items.AddRange(new object[] {
                                                                "None",
                                                                "Hanning",
                                                                "Hamming",
                                                                "Blackman-Harris",
                                                                "Exact Blackman",
                                                                "Blackman",
                                                                "FlatTop",
                                                                "4Term B-Harris",
                                                                "7Term B-Harris",
                                                                "Low Side Lobe",
                                                                "BlackmanNuttall",
                                                                "Dolph Chebyshev",
                                                                "Triangle",
                                                                "Kaiser",
                                                                "Gaussian"});
            this.windowComboBox.Location = new System.Drawing.Point(16, 88);
            this.windowComboBox.Name = "windowComboBox";
            this.windowComboBox.Size = new System.Drawing.Size(104, 21);
            this.windowComboBox.TabIndex = 1;
            this.windowComboBox.SelectedIndexChanged += new System.EventHandler(this.window_SelectedIndexChanged);
            // 
            // windowOpsLabel
            // 
            this.windowOpsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.windowOpsLabel.Location = new System.Drawing.Point(16, 72);
            this.windowOpsLabel.Name = "windowOpsLabel";
            this.windowOpsLabel.Size = new System.Drawing.Size(112, 16);
            this.windowOpsLabel.TabIndex = 3;
            this.windowOpsLabel.Text = "Windows:";
            // 
            // unitsComboBox
            // 
            this.unitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitsComboBox.Items.AddRange(new object[] {
                                                               "Vrms",
                                                               "Vrms^2",
                                                               "Vrms/rt(Hz)",
                                                               "Vpk^2/Hz",
                                                               "Vpk",
                                                               "Vpk^2",
                                                               "Vpk/rt(Hz)",
                                                               "Vrms^2/Hz"});
            this.unitsComboBox.Location = new System.Drawing.Point(16, 136);
            this.unitsComboBox.Name = "unitsComboBox";
            this.unitsComboBox.Size = new System.Drawing.Size(104, 21);
            this.unitsComboBox.TabIndex = 2;
            this.unitsComboBox.SelectedIndexChanged += new System.EventHandler(this.units_SelectedIndexChanged);
            // 
            // unitsLabel
            // 
            this.unitsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.unitsLabel.Location = new System.Drawing.Point(16, 120);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(40, 16);
            this.unitsLabel.TabIndex = 3;
            this.unitsLabel.Text = "Units:";
            // 
            // scaleComboBox
            // 
            this.scaleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.scaleComboBox.Items.AddRange(new object[] {
                                                               "Linear",
                                                               "dB",
                                                               "dBm"});
            this.scaleComboBox.Location = new System.Drawing.Point(16, 184);
            this.scaleComboBox.Name = "scaleComboBox";
            this.scaleComboBox.Size = new System.Drawing.Size(104, 21);
            this.scaleComboBox.TabIndex = 3;
            this.scaleComboBox.SelectedIndexChanged += new System.EventHandler(this.scale_SelectedIndexChanged);
            // 
            // scaleLabel
            // 
            this.scaleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scaleLabel.Location = new System.Drawing.Point(16, 168);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(48, 16);
            this.scaleLabel.TabIndex = 3;
            this.scaleLabel.Text = "Scale:";
            // 
            // noiseRatioLabel
            // 
            this.noiseRatioLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noiseRatioLabel.Location = new System.Drawing.Point(16, 216);
            this.noiseRatioLabel.Name = "noiseRatioLabel";
            this.noiseRatioLabel.Size = new System.Drawing.Size(80, 16);
            this.noiseRatioLabel.TabIndex = 7;
            this.noiseRatioLabel.Text = "Noise Ratio:";
            // 
            // powerSpectrumWaveformGraph
            // 
            this.powerSpectrumWaveformGraph.Caption = "Power Spectrum";
            this.powerSpectrumWaveformGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
                                                                                                       this.xyCursor});
            this.powerSpectrumWaveformGraph.Location = new System.Drawing.Point(192, 222);
            this.powerSpectrumWaveformGraph.Name = "powerSpectrumWaveformGraph";
            this.powerSpectrumWaveformGraph.UseColorGenerator = true;
            this.powerSpectrumWaveformGraph.PlotAreaColor = System.Drawing.Color.White;
            this.powerSpectrumWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                         this.powerPlot});
            this.powerSpectrumWaveformGraph.Size = new System.Drawing.Size(408, 192);
            this.powerSpectrumWaveformGraph.TabIndex = 30;
            this.powerSpectrumWaveformGraph.TabStop = false;
            this.powerSpectrumWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                                  this.powerXAxis});
            this.powerSpectrumWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                                  this.powerYAxis});
            this.powerSpectrumWaveformGraph.BeforeMoveCursor += new NationalInstruments.UI.BeforeMoveXYCursorEventHandler(this.powerSpectrumGraph_BeforeMoveCursor);
            // 
            // inputSignalWaveformGraph
            // 
            this.inputSignalWaveformGraph.Caption = "Input Signal";
            this.inputSignalWaveformGraph.Location = new System.Drawing.Point(192, 14);
            this.inputSignalWaveformGraph.Name = "inputSignalWaveformGraph";
            this.inputSignalWaveformGraph.UseColorGenerator = true;
            this.inputSignalWaveformGraph.PlotAreaColor = System.Drawing.Color.White;
            this.inputSignalWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                       this.inputSignalPlot});
            this.inputSignalWaveformGraph.Size = new System.Drawing.Size(408, 192);
            this.inputSignalWaveformGraph.TabIndex = 29;
            this.inputSignalWaveformGraph.TabStop = false;
            this.inputSignalWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                                this.inputXAxis});
            this.inputSignalWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                                this.inputYAxis});
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.descriptionLabel.Location = new System.Drawing.Point(32, 430);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(576, 50);
            this.descriptionLabel.TabIndex = 28;
            this.descriptionLabel.Text = @"This program uses the Spectrum and PowerFrequencyEstimate functions. The top graph displays the input signal in the time domain and the bottom graph displays the power spectrum of the filtered input signal. Moving the graph cursor around the plot area will display the peak frequency and the power at that location.";
            // 
            // peakFrequencyLabel
            // 
            this.peakFrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.peakFrequencyLabel.Location = new System.Drawing.Point(40, 294);
            this.peakFrequencyLabel.Name = "peakFrequencyLabel";
            this.peakFrequencyLabel.Size = new System.Drawing.Size(104, 16);
            this.peakFrequencyLabel.TabIndex = 27;
            this.peakFrequencyLabel.Text = "Peak Frequency:";
            // 
            // powerPeakLabel
            // 
            this.powerPeakLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.powerPeakLabel.Location = new System.Drawing.Point(40, 334);
            this.powerPeakLabel.Name = "powerPeakLabel";
            this.powerPeakLabel.Size = new System.Drawing.Size(104, 16);
            this.powerPeakLabel.TabIndex = 26;
            this.powerPeakLabel.Text = "Power Peak:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(624, 501);
            this.Controls.Add(this.powerFrequencyEstimateButton);
            this.Controls.Add(this.peakFrequencyNumericEdit);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.powerSpectrumWaveformGraph);
            this.Controls.Add(this.inputSignalWaveformGraph);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.peakFrequencyLabel);
            this.Controls.Add(this.powerPeakLabel);
            this.Controls.Add(this.peakPowerNumericEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Power Frequency Estimator";
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakPowerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peakFrequencyNumericEdit)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noiseRatioNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerSpectrumWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputSignalWaveformGraph)).EndInit();
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

        // When PowerFrequecnyEstimate button is clicked.
        private void powerFrequencyEstimate_Click(object sender, System.EventArgs e)
        {
            GenerateInputSignal(); //Generate Input Signal
            GetUnitConvertedAutoPowerSpectrum(waveform); // Get power spectrum of signal waveform. 
            // Call the following function to calculate current powerPeak and frequencyPeak.
            CurrentPeakData();
        }

        // Calculates the estimated power and frequency around a peak in the power spectrum of a time-domain signal.
        void CurrentPeakData()
        {
            double frequencyPeak;
            double powerPeak;
            if(powerFrequencyEstimateClicked) // To check that atleast once PowerFrequencyEstimate button is clicked.
            {
                searchFrequency = xyCursor.XPosition; // Get the current XPosition of cursor.
                // Apply PowerFrequencyEstimate function.
                NationalInstruments.Analysis.SpectralMeasurements.Measurements.PowerFrequencyEstimate(autoPowerSpectrum, searchFrequency,
                    equivalentNoiseBandwidth, coherentGain, df, 7, out frequencyPeak, out powerPeak);
                peakFrequencyNumericEdit.Value = frequencyPeak;
                peakPowerNumericEdit.Value = powerPeak;
            }
            else 
                powerFrequencyEstimateButton.PerformClick();
        }

        // Generate noise based on the value of noiseRatio.
        void GenerateNoise()
        {
            double noise;
            noise = (double)noiseRatioNumericEdit.Value; // Take the value of noise from noise ratio slide.
            noise = noise/100;  
            noiseWave = new double[512];
            noiseWave.Initialize();
            // Generate white noise. 
            WhiteNoiseSignal whiteNoise = new WhiteNoiseSignal(noise, 0);
            noiseWave = whiteNoise.Generate(512, 512);
        }

        void GetUnitConvertedAutoPowerSpectrum(double []waveform)
        {
            double []unitConvertedSpectrum;
            double []subsetOfUnitConvertedSpectrum = new double[128];
            System.Text.StringBuilder unit;
            int i;
           
            powerFrequencyEstimateClicked = true;
            ScalingMode scalingMode = ScalingMode.Linear;
            DisplayUnits displayUnit = DisplayUnits.VoltsRms;
            
            //  Set Window Type specified by the user.
            // Create a window of type specified by the user
            ScaledWindow scaleWindow;
            switch(windowComboBox.SelectedIndex)
            {
                case 0:
                    scaleWindow = ScaledWindow.CreateRectangularWindow();
                    break;
                case 1:
                default:
                    scaleWindow = ScaledWindow.CreateHanningWindow();
                    break;
                case 2:
                    scaleWindow = ScaledWindow.CreateHammingWindow();
                    break;
                case 3:
                    scaleWindow = ScaledWindow.CreateBlackmanHarrisWindow();
                    break;
                case 4:
                    scaleWindow = ScaledWindow.CreateExactBlackmanWindow();
                    break;
                case 5:
                    scaleWindow = ScaledWindow.CreateBlackmanWindow();
                    break;
                case 6:
                
                    scaleWindow = ScaledWindow.CreateFlatTopWindow();
                    break;
                case 7:
                    scaleWindow = ScaledWindow.CreateBlackmanHarris4TermWindow();
                    break;
                case 8:
                    scaleWindow = ScaledWindow.CreateBlackmanHarris7TermWindow();
                    break;
                case 9: 
                    scaleWindow = ScaledWindow.CreateLowSideLobeWindow();
                    break;
                case 10: 
                    scaleWindow = ScaledWindow.CreateBlackmanNuttallWindow();
                    break;
                case 11: 
                    scaleWindow = ScaledWindow.CreateDolphChebyshevWindow();
                    break;
                case 12: 
                    scaleWindow = ScaledWindow.CreateTriangleWindow();
                    break;
                case 13: 
                    scaleWindow = ScaledWindow.CreateKaiserWindow();
                    break;
                case 14: 
                    scaleWindow = ScaledWindow.CreateGaussianWindow();
                    break;
            }
            // Units selected by the user in which auto power spectrum has to be displayed.
            switch(unitsComboBox.SelectedIndex)
            {
                case 0:
                default:
                    displayUnit = DisplayUnits.VoltsRms;
                    break;
                case 1:
                    displayUnit = DisplayUnits.VoltsRmsSquared;
                     break;
                case 2:
                    displayUnit = DisplayUnits.VoltsRmsPerRootHZ;
                    break;
                case 3:
                    displayUnit = DisplayUnits.VoltsPeakSquaredPerHZ;
                    break;
                case 4:
                    displayUnit = DisplayUnits.VoltsPeak;
                    break;
                case 5:
                    displayUnit = DisplayUnits.VoltsPeakSquared;
                    break;
                case 6:
                    displayUnit = DisplayUnits.VoltsPeakPerRootHZ;
                    break;
                case 7:
                    displayUnit = DisplayUnits.VoltsRmsSquaredPerHZ;
                    break;
            }

            // Scale Selection: Linear, dB or dBm
            switch(scaleComboBox.SelectedIndex)
            {
                case 0:
                    scalingMode = ScalingMode.Linear;
                    break;
                case 1:
                    scalingMode = ScalingMode.DB;
                    break;
                case 2:
                    scalingMode = ScalingMode.DBM;
                    break;
            }

            // Apply window on the noisy waveform.
            scaleWindow.Apply(waveform, out equivalentNoiseBandwidth, out coherentGain); 
            // Calculate the auto power spectrum of signal waveform.
            autoPowerSpectrum = new double[512/2];
            autoPowerSpectrum = NationalInstruments.Analysis.SpectralMeasurements.Measurements.AutoPowerSpectrum(waveform, 1.0/512, out df);
            
            unit = new System.Text.StringBuilder("V", 256);
            // Unit conversion of auto power spectrum as specified by the user.
            unitConvertedSpectrum = new double[512/2];
            unitConvertedSpectrum = NationalInstruments.Analysis.SpectralMeasurements.Measurements.SpectrumUnitConversion(autoPowerSpectrum,
                NationalInstruments.Analysis.SpectralMeasurements.SpectrumType.Power, scalingMode, displayUnit, df, 
                equivalentNoiseBandwidth, coherentGain, unit);
            //Set the caption of yAxis according to the chosen unit of display.
            powerYAxis.Caption = unit.ToString();
            for(i=0; i<128; i++)
            {
                subsetOfUnitConvertedSpectrum[i] = unitConvertedSpectrum[i];
            }
            // Plot unitConvertedSpectrum.
            powerPlot.PlotY(subsetOfUnitConvertedSpectrum, 0, df);
        }

        private void GenerateInputSignal()
        {
            int i;
            waveform = new double[512]; // Allocate memory for 512 samples.
            waveform.Initialize();
            
            // Generate input signal.
            switch(inputSignalComboBox.SelectedIndex)
            {
                case 0:
                default: // Create square wave of frequency 5Hz.
                    SquareSignal squareWave = new SquareSignal(5, 1.0, 0.0, 50.0);
                    waveform = squareWave.Generate(512, 512); // Sampling Rate: 512/s, numberOfSamples:512.
                    break;
                case 1: // Create sine wave of frequency 5Hz.
                    SineSignal sineWave = new SineSignal(5, 1.0, 0.0);
                    waveform = sineWave.Generate(512, 512); // Sampling Rate: 512/s, numberOfSamples:512.
                    break;
                case 2: // Create triangular wave of frequency 5Hz.
                    TriangleSignal triangularWave = new TriangleSignal(5, 1.0, 0.0);
                    waveform = triangularWave.Generate(512, 512); // Sampling Rate: 512/s, numberOfSamples:512.
                    break;
            }
            
            // Generate noise.
            GenerateNoise();
            
            // Add noise to signal waveform
            for(i=0; i<512; i++)
            {
                waveform[i] = waveform[i] + noiseWave[i];
            }
            
            // Plot noisy waveform.
            inputSignalPlot.PlotY(waveform, 0.0, 1.0/512.0);
        }

        // When a window is selected by the user.
        private void window_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(powerFrequencyEstimateClicked)
            {
                GetUnitConvertedAutoPowerSpectrum(waveform); // Get power spectrum of signal waveform. 
                // Call the following function to calculate current powerPeak and frequencyPeak.
                CurrentPeakData();
            }
        }

        // When the inputSignal control's value is changed.
        private void inputSignal_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(powerFrequencyEstimateClicked)
                powerFrequencyEstimateButton.PerformClick();
        }

        // When the value of units control is changed.
        private void units_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(powerFrequencyEstimateClicked)
            {
                GetUnitConvertedAutoPowerSpectrum(waveform); // Get power spectrum of signal waveform. 
                // Call the following function to calculate current powerPeak and frequencyPeak.
                CurrentPeakData();
            }
        }

        // When the value of Scale control is changed by the user.
        private void scale_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(powerFrequencyEstimateClicked)
            {
                GetUnitConvertedAutoPowerSpectrum(waveform); // Get power spectrum of signal waveform. 
                // Call the following function to calculate current powerPeak and frequencyPeak.
                CurrentPeakData();
            }
        }
        
        private void noiseRatio_ValueChanged(object sender, System.EventArgs e)
        {
            if(powerFrequencyEstimateClicked)
                powerFrequencyEstimateButton.PerformClick();
        }

        private void powerSpectrumGraph_BeforeMoveCursor(object sender, NationalInstruments.UI.BeforeMoveXYCursorEventArgs e)
        {
            CurrentPeakData(); // Recalculate the power peak and frequecny peak. 
        }
    }
}
