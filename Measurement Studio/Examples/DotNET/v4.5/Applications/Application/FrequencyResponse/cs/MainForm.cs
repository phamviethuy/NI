using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.Dsp.Filters;

namespace NationalInstruments.Examples.FrequencyResponse
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.GroupBox frequencyGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit stopFrequencyNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit startFrequencyNumericEdit;
        private NationalInstruments.UI.WindowsForms.Knob stopFrequencyKnob;
        private NationalInstruments.UI.WindowsForms.Knob startFrequencyKnob;
        private NationalInstruments.UI.WindowsForms.Meter currentFrequencyMeter;
        private System.Windows.Forms.Button runTestButton;
        private System.Windows.Forms.Button curveFitButton;
        private NationalInstruments.UI.WindowsForms.NumericEdit stepsNumericEdit;
        private NationalInstruments.UI.ScatterPlot curveFitPlot;
        private NationalInstruments.UI.WindowsForms.ScatterGraph frequencyResponseScatterGraph;
        private NationalInstruments.UI.WindowsForms.NumericEdit currentFrequencyNumericEdit;
        private System.Windows.Forms.GroupBox currentFrequencyGroupBox;
        private System.Windows.Forms.Label stepsLabel;
        private NationalInstruments.UI.ScatterPlot linearlyEvaluatedFrequenciesPlot;
        private NationalInstruments.UI.ScatterPlot frequenciesPlot;
        private double[] frequencies;
        private double[] dbValues;
        private NationalInstruments.UI.XAxis decibelAxis;
        private NationalInstruments.UI.YAxis frequencyAxis;
        private const double Offset = 0.0;
        private const double Amplitude = 10.0; 
        private const double SamplingRate = 1;
        private const int NumberOfSamples = 1024;
        private const double Phase = 0.0;
        private const int Order = 5;
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
            this.frequencyGroupBox = new System.Windows.Forms.GroupBox();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.stepsNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.stopFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.startFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.stopFrequencyKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.startFrequencyKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.runTestButton = new System.Windows.Forms.Button();
            this.curveFitButton = new System.Windows.Forms.Button();
            this.currentFrequencyGroupBox = new System.Windows.Forms.GroupBox();
            this.currentFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.currentFrequencyMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.frequencyResponseScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.frequenciesPlot = new NationalInstruments.UI.ScatterPlot();
            this.decibelAxis = new NationalInstruments.UI.XAxis();
            this.frequencyAxis = new NationalInstruments.UI.YAxis();
            this.linearlyEvaluatedFrequenciesPlot = new NationalInstruments.UI.ScatterPlot();
            this.curveFitPlot = new NationalInstruments.UI.ScatterPlot();
            this.frequencyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopFrequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFrequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopFrequencyKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFrequencyKnob)).BeginInit();
            this.currentFrequencyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentFrequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFrequencyMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyResponseScatterGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // frequencyGroupBox
            // 
            this.frequencyGroupBox.Controls.Add(this.stepsLabel);
            this.frequencyGroupBox.Controls.Add(this.stepsNumericEdit);
            this.frequencyGroupBox.Controls.Add(this.stopFrequencyNumericEdit);
            this.frequencyGroupBox.Controls.Add(this.startFrequencyNumericEdit);
            this.frequencyGroupBox.Controls.Add(this.stopFrequencyKnob);
            this.frequencyGroupBox.Controls.Add(this.startFrequencyKnob);
            this.frequencyGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.frequencyGroupBox.Location = new System.Drawing.Point(8, 0);
            this.frequencyGroupBox.Name = "frequencyGroupBox";
            this.frequencyGroupBox.Size = new System.Drawing.Size(392, 184);
            this.frequencyGroupBox.TabIndex = 0;
            this.frequencyGroupBox.TabStop = false;
            // 
            // stepsLabel
            // 
            this.stepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.stepsLabel.Location = new System.Drawing.Point(318, 48);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(48, 16);
            this.stepsLabel.TabIndex = 5;
            this.stepsLabel.Text = "Steps";
            // 
            // stepsNumeric
            // 
            this.stepsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.stepsNumericEdit.Location = new System.Drawing.Point(320, 64);
            this.stepsNumericEdit.Name = "stepsNumeric";
            this.stepsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.stepsNumericEdit.Range = new NationalInstruments.UI.Range(6, 200);
            this.stepsNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.stepsNumericEdit.TabIndex = 6;
            this.stepsNumericEdit.Value = 50;
            // 
            // stopFrequencyNumeric
            // 
            this.stopFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.stopFrequencyNumericEdit.Location = new System.Drawing.Point(201, 152);
            this.stopFrequencyNumericEdit.Name = "stopFrequencyNumeric";
            this.stopFrequencyNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.stopFrequencyNumericEdit.TabIndex = 4;
            this.stopFrequencyNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.stopFrequencyNumeric_AfterChangeValue);
            // 
            // startFrequencyNumeric
            // 
            this.startFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.startFrequencyNumericEdit.Location = new System.Drawing.Point(48, 152);
            this.startFrequencyNumericEdit.Name = "startFrequencyNumeric";
            this.startFrequencyNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.startFrequencyNumericEdit.TabIndex = 2;
            this.startFrequencyNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.startFrequencyNumeric_AfterChangeValue);
            // 
            // stopFrequencyKnob
            // 
            this.stopFrequencyKnob.AutoDivisionSpacing = false;
            this.stopFrequencyKnob.Caption = "Stop Frequency";
            this.stopFrequencyKnob.Location = new System.Drawing.Point(160, 8);
            this.stopFrequencyKnob.MajorDivisions.Interval = 250;
            this.stopFrequencyKnob.MinorDivisions.TickVisible = false;
            this.stopFrequencyKnob.Name = "stopFrequencyKnob";
            this.stopFrequencyKnob.Range = new NationalInstruments.UI.Range(0, 1000);
            this.stopFrequencyKnob.Size = new System.Drawing.Size(152, 144);
            this.stopFrequencyKnob.TabIndex = 3;
            this.stopFrequencyKnob.Value = 1000;
            this.stopFrequencyKnob.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.stopFrequencyKnob_BeforeChangeValue);
            this.stopFrequencyKnob.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.stopFrequencyKnob_AfterChangeValue);
            // 
            // startFrequencyKnob
            // 
            this.startFrequencyKnob.AutoDivisionSpacing = false;
            this.startFrequencyKnob.Caption = "Start Frequency";
            this.startFrequencyKnob.Location = new System.Drawing.Point(8, 8);
            this.startFrequencyKnob.MajorDivisions.Interval = 250;
            this.startFrequencyKnob.MinorDivisions.TickVisible = false;
            this.startFrequencyKnob.Name = "startFrequencyKnob";
            this.startFrequencyKnob.Range = new NationalInstruments.UI.Range(0, 1000);
            this.startFrequencyKnob.Size = new System.Drawing.Size(152, 144);
            this.startFrequencyKnob.TabIndex = 1;
            this.startFrequencyKnob.Value = 1;
            this.startFrequencyKnob.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.startFrequencyKnob_BeforeChangeValue);
            this.startFrequencyKnob.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.startFrequencyKnob_AfterChangeValue);
            // 
            // runTestbutton
            // 
            this.runTestButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.runTestButton.Location = new System.Drawing.Point(408, 24);
            this.runTestButton.Name = "runTestbutton";
            this.runTestButton.Size = new System.Drawing.Size(88, 32);
            this.runTestButton.TabIndex = 7;
            this.runTestButton.Text = "Run Test";
            this.runTestButton.Click += new System.EventHandler(this.runTestbutton_Click);
            // 
            // curveFitButton
            // 
            this.curveFitButton.Enabled = false;
            this.curveFitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.curveFitButton.Location = new System.Drawing.Point(408, 64);
            this.curveFitButton.Name = "curveFitButton";
            this.curveFitButton.Size = new System.Drawing.Size(88, 32);
            this.curveFitButton.TabIndex = 8;
            this.curveFitButton.Text = "Curve Fit";
            this.curveFitButton.Click += new System.EventHandler(this.curveFitButton_Click);
            // 
            // currentFrequencyGroupBox
            // 
            this.currentFrequencyGroupBox.Controls.Add(this.currentFrequencyNumericEdit);
            this.currentFrequencyGroupBox.Controls.Add(this.currentFrequencyMeter);
            this.currentFrequencyGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.currentFrequencyGroupBox.Location = new System.Drawing.Point(504, 0);
            this.currentFrequencyGroupBox.Name = "currentFrequencyGroupBox";
            this.currentFrequencyGroupBox.Size = new System.Drawing.Size(216, 184);
            this.currentFrequencyGroupBox.TabIndex = 9;
            this.currentFrequencyGroupBox.TabStop = false;
            // 
            // currentFrequencyNumeric
            // 
            this.currentFrequencyNumericEdit.ImmediateUpdates = true;
            this.currentFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.currentFrequencyNumericEdit.Location = new System.Drawing.Point(56, 152);
            this.currentFrequencyNumericEdit.Name = "currentFrequencyNumeric";
            this.currentFrequencyNumericEdit.Source = this.currentFrequencyMeter;
            this.currentFrequencyNumericEdit.TabIndex = 11;
            // 
            // currentFrequencyMeter
            // 
            this.currentFrequencyMeter.Caption = "Current Frequency";
            this.currentFrequencyMeter.ImmediateUpdates = true;
            this.currentFrequencyMeter.Location = new System.Drawing.Point(24, 8);
            this.currentFrequencyMeter.Name = "currentFrequencyMeter";
            this.currentFrequencyMeter.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.currentFrequencyMeter.Range = new NationalInstruments.UI.Range(0, 1000);
            this.currentFrequencyMeter.Size = new System.Drawing.Size(184, 112);
            this.currentFrequencyMeter.TabIndex = 10;
            // 
            // frequencyResponseGraph
            // 
            this.frequencyResponseScatterGraph.ImmediateUpdates = true;
            this.frequencyResponseScatterGraph.Location = new System.Drawing.Point(8, 192);
            this.frequencyResponseScatterGraph.Name = "frequencyResponseGraph";
            this.frequencyResponseScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                    this.frequenciesPlot,
                                                                                                    this.linearlyEvaluatedFrequenciesPlot,
                                                                                                    this.curveFitPlot});
            this.frequencyResponseScatterGraph.Size = new System.Drawing.Size(712, 208);
            this.frequencyResponseScatterGraph.TabIndex = 12;
            this.frequencyResponseScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                              this.decibelAxis});
            this.frequencyResponseScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                              this.frequencyAxis});
            // 
            // frequenciesPlot
            // 
            this.frequenciesPlot.LineStyle = NationalInstruments.UI.LineStyle.None;
            this.frequenciesPlot.PointColor = System.Drawing.Color.Red;
            this.frequenciesPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptySquare;
            this.frequenciesPlot.XAxis = this.decibelAxis;
            this.frequenciesPlot.YAxis = this.frequencyAxis;
            // 
            // decibelAxis
            // 
            this.decibelAxis.BaseLineVisible = true;
            this.decibelAxis.Caption = "Decibels";
            this.decibelAxis.MajorDivisions.GridVisible = true;
            this.decibelAxis.MinorDivisions.GridVisible = true;
            this.decibelAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.decibelAxis.Range = new NationalInstruments.UI.Range(0, 1000);
            this.decibelAxis.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            // 
            // frequencyAxis
            // 
            this.frequencyAxis.Caption = "Frequencies";
            this.frequencyAxis.MajorDivisions.GridVisible = true;
            this.frequencyAxis.Range = new NationalInstruments.UI.Range(-60, 0);
            // 
            // linearlyEvaluatedFrequenciesPlot
            // 
            this.linearlyEvaluatedFrequenciesPlot.AntiAliased = true;
            this.linearlyEvaluatedFrequenciesPlot.LineColor = System.Drawing.Color.Yellow;
            this.linearlyEvaluatedFrequenciesPlot.XAxis = this.decibelAxis;
            this.linearlyEvaluatedFrequenciesPlot.YAxis = this.frequencyAxis;
            // 
            // curveFitPlot
            // 
            this.curveFitPlot.AntiAliased = true;
            this.curveFitPlot.LineColor = System.Drawing.Color.White;
            this.curveFitPlot.XAxis = this.decibelAxis;
            this.curveFitPlot.YAxis = this.frequencyAxis;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(728, 406);
            this.Controls.Add(this.frequencyResponseScatterGraph);
            this.Controls.Add(this.currentFrequencyGroupBox);
            this.Controls.Add(this.curveFitButton);
            this.Controls.Add(this.runTestButton);
            this.Controls.Add(this.frequencyGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Frequency Response";
            this.frequencyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stepsNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopFrequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFrequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopFrequencyKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startFrequencyKnob)).EndInit();
            this.currentFrequencyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.currentFrequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentFrequencyMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyResponseScatterGraph)).EndInit();
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
            Application.Run(new MainForm());
        }

        private void runTestbutton_Click(object sender, System.EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            // Disable interaction with the knobs to prevent users from changing the values
            startFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.Indicator;
            stopFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.Indicator;
            
            frequencies = new double[(int)stepsNumericEdit.Value];
            dbValues = new double[(int)stepsNumericEdit.Value];

            // Setup the array of frequencies based on the step and frequency range
            double increment = ( stopFrequencyKnob.Value - startFrequencyKnob.Value)/(stepsNumericEdit.Value - 1);
            for (int i = 0; i < stepsNumericEdit.Value; ++i)
                frequencies[i] = (startFrequencyKnob.Value + (i * increment)) / 100000.0;

            frequencyResponseScatterGraph.ClearData();

            
            // Loop through frequencies and generate sine wave and analyze response
            double[] voltages = new double[(int)stepsNumericEdit.Value];
            
            for(int i=0; i < stepsNumericEdit.Value; ++i) 
            {
                double[] sinewave = BasicFunctionGenerator.GenerateSineWave(frequencies[i], Amplitude, Phase, Offset, SamplingRate, NumberOfSamples); 
                int filterOrder = 5;
                double samplingFrequency = 100000;
                double lowerCutoffFrequency = 200;
                double upperCutoffFrequency = 600;
                ButterworthBandpassFilter filter = new ButterworthBandpassFilter(filterOrder, samplingFrequency, lowerCutoffFrequency, upperCutoffFrequency);
                double[] output = filter.FilterData(sinewave);
                
                voltages[i] = Statistics.RootMeanSquared(output);
                voltages[i] = (voltages[i] * Math.Sqrt(2)) / 10.0;
                dbValues[i] = 20.0 * Math.Log10(voltages[i]);
                
                // Draw point on graph for this calculation and update current frequency
                frequenciesPlot.PlotXYAppend(frequencies[i] * 100000, dbValues[i]);
                currentFrequencyMeter.Value = frequencies[i] * 100000;
            }

            // Reset frequencies to range for display and plot line
            double slope = 100000;
            frequencies =  ArrayOperation.LinearEvaluation1D(frequencies, slope, Offset);
            linearlyEvaluatedFrequenciesPlot.PlotXY(frequencies, dbValues);

            // Enable Curve Fit button
            curveFitButton.Enabled = true;

            // Enable interaction with the knobs
            startFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.DragPointer | RadialNumericPointerInteractionModes.SnapPointer;
            stopFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.DragPointer | RadialNumericPointerInteractionModes.SnapPointer;

            Cursor = Cursors.Default;
        }

        private void curveFitButton_Click(object sender, System.EventArgs e)
        {
            // Calculate 5th order polynomial fit and plot it to the graph
            double[] fittedCurveData = CurveFit.PolynomialFit(frequencies, dbValues, Order, PolynomialFitAlgorithm.Svd);            
            curveFitPlot.PlotXY(frequencies, fittedCurveData);
        }

        private void startFrequencyKnob_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            if (e.NewValue < 1)
            {
                startFrequencyKnob.Value = 1;
                e.Cancel = true;
            }
            
        }

        private void startFrequencyKnob_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            startFrequencyNumericEdit.Value = e.NewValue;
        }

        private void stopFrequencyKnob_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            stopFrequencyNumericEdit.Value = e.NewValue;
        }

        private void stopFrequencyKnob_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            if (e.NewValue < 1)
            {
                stopFrequencyKnob.Value = 1;
                e.Cancel = true;
            }
        }

        private void startFrequencyNumeric_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            startFrequencyKnob.Value = e.NewValue; 
        }

        private void stopFrequencyNumeric_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            stopFrequencyKnob.Value = e.NewValue; 
        }
        
    }
}
