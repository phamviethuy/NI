using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.UI.WindowsForms;
using System.Reflection;
using NationalInstruments.Analysis.Math;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.Windowing
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        internal NationalInstruments.UI.WaveformPlot freqDomainPlot;
        internal NationalInstruments.UI.XAxis freqDomainXAxis;
        internal NationalInstruments.UI.YAxis freqDomainYAxis;
        internal NationalInstruments.UI.YAxis windowedDataYAxis;
        internal NationalInstruments.UI.XAxis windowsXAxis;
        internal NationalInstruments.UI.YAxis addTimeDomainYAxis;
        internal System.Windows.Forms.Label scaledWindowTypesLabel;
        internal NationalInstruments.UI.WaveformPlot addTimeDomainPlot;
        internal NationalInstruments.UI.XAxis addTimeDomainXAxis;
        internal NationalInstruments.UI.WaveformPlot windowedDataPlot;
        internal NationalInstruments.UI.XAxis windowedDataXAxis;
        internal NationalInstruments.UI.YAxis windowsYAxis;
        internal NationalInstruments.UI.WaveformPlot windowsPlot;
        internal System.Windows.Forms.Label dbLabel;
        internal System.Windows.Forms.Label linearLabel;
        internal System.Windows.Forms.GroupBox inputSignal1GroupBox;
        internal System.Windows.Forms.Label signal1AmplitudeLabel;
        internal System.Windows.Forms.Label signal1FrequencyLabel;
        internal System.Windows.Forms.GroupBox inputSignal2GroupBox;
        internal System.Windows.Forms.Label signal2AmplitudeLabel;
        internal System.Windows.Forms.Label signal2FrequencyLabel;
        internal NationalInstruments.UI.WindowsForms.NumericEdit input1AmplitudeNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit input1FrequencyNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit input2AmplitudeNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit input2FrequencyNumericEdit;
        internal NationalInstruments.UI.WindowsForms.WaveformGraph freqDomainWaveformGraph;
        internal NationalInstruments.UI.WindowsForms.WaveformGraph addTimeDomainWaveformGraph;
        internal NationalInstruments.UI.WindowsForms.WaveformGraph windowedDataWaveformGraph;
        internal NationalInstruments.UI.WindowsForms.WaveformGraph windowsWaveformGraph;
        internal System.Windows.Forms.ComboBox windowTypesComboBox;
        internal NationalInstruments.UI.WindowsForms.Switch linearLogSwitch;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public MainForm()
        {           
            InitializeComponent();
            
            input1AmplitudeNumericEdit.ValueChanged += new EventHandler(RecalculateSignals);
            input1FrequencyNumericEdit.ValueChanged += new EventHandler(RecalculateSignals);
            input2FrequencyNumericEdit.ValueChanged += new EventHandler(RecalculateSignals);
            input2AmplitudeNumericEdit.ValueChanged += new EventHandler(RecalculateSignals);
            linearLogSwitch.ValueChanged +=new EventHandler(RecalculateSignals);
            windowTypesComboBox.SelectedIndexChanged +=new EventHandler(RecalculateSignals);

            FillComboBoxes();
            RecalculateAndDrawGraphs();
        }

        private void FillComboBoxes()
        {
            foreach(string name in Enum.GetNames(typeof(ScaledWindowType)))
                windowTypesComboBox.Items.Add(name);
            
            windowTypesComboBox.SelectedIndex = 0;
        }

        private void RecalculateAndDrawGraphs()
        {
            double [] addedSignals = new double[500];
            double [] temp = new Double[500];
            double [] halfValues = new Double[500/2];
            ScaledWindow scaledWindow = GetSelectedWindow();
            SignalGenerator generator = new SignalGenerator(500, 500);
            
            SineSignal signal1 = new SineSignal((double)input1FrequencyNumericEdit.Value, (double)input1AmplitudeNumericEdit.Value);
            SineSignal signal2 = new SineSignal((double)input2FrequencyNumericEdit.Value, (double)input2AmplitudeNumericEdit.Value);
            
            generator.Signals.Add(signal1);
            generator.Signals.Add(signal2);
            addedSignals = generator.Generate();
            
            addTimeDomainWaveformGraph.PlotY(addedSignals);
        
            temp = ArrayOperation.LinearEvaluation1D(temp, 0, 1);
            
            scaledWindow.Apply(temp);
            windowsWaveformGraph.PlotY(temp);
            
            scaledWindow.Apply(addedSignals);
            windowedDataWaveformGraph.PlotY(addedSignals);
            
            Transforms.PowerSpectrum(addedSignals);
            
            int x;
            for(x = 0; x < 250; x++)
            {
                halfValues[x] = addedSignals[x];
                
                if(!linearLogSwitch.Value)
                    halfValues[x] = 20*Math.Log10(halfValues[x]); //User chose dB
            }
            
            freqDomainWaveformGraph.PlotY(halfValues);
        
        }


        private ScaledWindowType GetSelectedWindowType()
        {
            int x;
            string item = windowTypesComboBox.SelectedItem as string;
            if(item == null)
                return ScaledWindowType.Rectangular;

            for(x = 0; x < windowTypesComboBox.Items.Count; x++)
                if(item == Enum.GetNames(typeof(ScaledWindowType))[x])
                    return (ScaledWindowType)((int[])Enum.GetValues(typeof(ScaledWindowType)))[x];

            return ScaledWindowType.Rectangular;
        }

        private ScaledWindow GetSelectedWindow()
        {
            ScaledWindowType scaledWindowSelected = GetSelectedWindowType();
            switch (scaledWindowSelected)
            {
                case ScaledWindowType.Blackman:
                    return ScaledWindow.CreateBlackmanWindow();
                case ScaledWindowType.BlackmanHarris:
                    return ScaledWindow.CreateBlackmanHarrisWindow();
                case ScaledWindowType.BlackmanHarris4Term:
                    return ScaledWindow.CreateBlackmanHarris4TermWindow();
                case ScaledWindowType.BlackmanHarris7Term:
                    return ScaledWindow.CreateBlackmanHarris7TermWindow();
                case ScaledWindowType.BlackmanNuttall:
                    return ScaledWindow.CreateBlackmanNuttallWindow();
                case ScaledWindowType.DolphChebyshev:
                    return ScaledWindow.CreateDolphChebyshevWindow();
                case ScaledWindowType.ExactBlackman:
                    return ScaledWindow.CreateExactBlackmanWindow();
                case ScaledWindowType.FlatTop:
                    return ScaledWindow.CreateFlatTopWindow();
                case ScaledWindowType.Gaussian:
                    return ScaledWindow.CreateGaussianWindow();
                case ScaledWindowType.Hamming:
                    return ScaledWindow.CreateHammingWindow();
                case ScaledWindowType.Hanning:
                    return ScaledWindow.CreateHanningWindow();
                case ScaledWindowType.Kaiser:
                    return ScaledWindow.CreateKaiserWindow();
                case ScaledWindowType.LowSidelobe:
                    return ScaledWindow.CreateLowSideLobeWindow();
                case ScaledWindowType.Rectangular:
                    return ScaledWindow.CreateRectangularWindow();
                case ScaledWindowType.Triangle:
                    return ScaledWindow.CreateTriangleWindow();
                default:
                    return ScaledWindow.CreateHanningWindow();

            }
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
            this.freqDomainPlot = new NationalInstruments.UI.WaveformPlot();
            this.freqDomainXAxis = new NationalInstruments.UI.XAxis();
            this.freqDomainYAxis = new NationalInstruments.UI.YAxis();
            this.windowedDataYAxis = new NationalInstruments.UI.YAxis();
            this.windowsXAxis = new NationalInstruments.UI.XAxis();
            this.addTimeDomainYAxis = new NationalInstruments.UI.YAxis();
            this.scaledWindowTypesLabel = new System.Windows.Forms.Label();
            this.freqDomainWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.addTimeDomainWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.addTimeDomainPlot = new NationalInstruments.UI.WaveformPlot();
            this.addTimeDomainXAxis = new NationalInstruments.UI.XAxis();
            this.windowedDataPlot = new NationalInstruments.UI.WaveformPlot();
            this.windowedDataXAxis = new NationalInstruments.UI.XAxis();
            this.windowedDataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.windowsYAxis = new NationalInstruments.UI.YAxis();
            this.windowsPlot = new NationalInstruments.UI.WaveformPlot();
            this.dbLabel = new System.Windows.Forms.Label();
            this.linearLabel = new System.Windows.Forms.Label();
            this.linearLogSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.windowTypesComboBox = new System.Windows.Forms.ComboBox();
            this.windowsWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.inputSignal1GroupBox = new System.Windows.Forms.GroupBox();
            this.input1AmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.signal1AmplitudeLabel = new System.Windows.Forms.Label();
            this.signal1FrequencyLabel = new System.Windows.Forms.Label();
            this.input1FrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.inputSignal2GroupBox = new System.Windows.Forms.GroupBox();
            this.signal2AmplitudeLabel = new System.Windows.Forms.Label();
            this.signal2FrequencyLabel = new System.Windows.Forms.Label();
            this.input2AmplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.input2FrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.freqDomainWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTimeDomainWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowedDataWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearLogSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsWaveformGraph)).BeginInit();
            this.inputSignal1GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input1AmplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1FrequencyNumericEdit)).BeginInit();
            this.inputSignal2GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input2AmplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2FrequencyNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // freqDomainPlot
            // 
            this.freqDomainPlot.XAxis = this.freqDomainXAxis;
            this.freqDomainPlot.YAxis = this.freqDomainYAxis;
            // 
            // freqDomainXAxis
            // 
            this.freqDomainXAxis.Caption = "Frequency";
            this.freqDomainXAxis.Range = new NationalInstruments.UI.Range(0, 250);
            // 
            // freqDomainYAxis
            // 
            this.freqDomainYAxis.Caption = "Amplitude";
            // 
            // windowedDataYAxis
            // 
            this.windowedDataYAxis.Caption = "Frequency";
            // 
            // addTimeDomainYAxis
            // 
            this.addTimeDomainYAxis.Caption = "Amplitude";
            // 
            // scaledWindowTypesLabel
            // 
            this.scaledWindowTypesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scaledWindowTypesLabel.Location = new System.Drawing.Point(25, 122);
            this.scaledWindowTypesLabel.Name = "scaledWindowTypesLabel";
            this.scaledWindowTypesLabel.Size = new System.Drawing.Size(120, 16);
            this.scaledWindowTypesLabel.TabIndex = 48;
            this.scaledWindowTypesLabel.Text = "Scaled Window Types:";
            // 
            // freqDomainWaveformGraph
            // 
            this.freqDomainWaveformGraph.Caption = " Frequency Domain";
            this.freqDomainWaveformGraph.Location = new System.Drawing.Point(361, 240);
            this.freqDomainWaveformGraph.Name = "freqDomainWaveformGraph";
            this.freqDomainWaveformGraph.UseColorGenerator = true;
            this.freqDomainWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                      this.freqDomainPlot});
            this.freqDomainWaveformGraph.Size = new System.Drawing.Size(360, 216);
            this.freqDomainWaveformGraph.TabIndex = 44;
            this.freqDomainWaveformGraph.TabStop = false;
            this.freqDomainWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                               this.freqDomainXAxis});
            this.freqDomainWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                               this.freqDomainYAxis});
            // 
            // addTimeDomainWaveformGraph
            // 
            this.addTimeDomainWaveformGraph.Caption = "Time Domain (Signal 1 + Signal2)";
            this.addTimeDomainWaveformGraph.Location = new System.Drawing.Point(361, 6);
            this.addTimeDomainWaveformGraph.Name = "addTimeDomainWaveformGraph";
            this.addTimeDomainWaveformGraph.UseColorGenerator = true;
            this.addTimeDomainWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                         this.addTimeDomainPlot});
            this.addTimeDomainWaveformGraph.Size = new System.Drawing.Size(360, 216);
            this.addTimeDomainWaveformGraph.TabIndex = 43;
            this.addTimeDomainWaveformGraph.TabStop = false;
            this.addTimeDomainWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                                  this.addTimeDomainXAxis});
            this.addTimeDomainWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                                  this.addTimeDomainYAxis});
            // 
            // addTimeDomainPlot
            // 
            this.addTimeDomainPlot.XAxis = this.addTimeDomainXAxis;
            this.addTimeDomainPlot.YAxis = this.addTimeDomainYAxis;
            // 
            // addTimeDomainXAxis
            // 
            this.addTimeDomainXAxis.Caption = "Number Of Samples";
            // 
            // windowedDataPlot
            // 
            this.windowedDataPlot.XAxis = this.windowedDataXAxis;
            this.windowedDataPlot.YAxis = this.windowedDataYAxis;
            // 
            // windowedDataXAxis
            // 
            this.windowedDataXAxis.Caption = "Number Of Samples";
            // 
            // windowedDataWaveformGraph
            // 
            this.windowedDataWaveformGraph.Caption = "Windowed Data";
            this.windowedDataWaveformGraph.Location = new System.Drawing.Point(25, 320);
            this.windowedDataWaveformGraph.Name = "windowedDataWaveformGraph";
            this.windowedDataWaveformGraph.UseColorGenerator = true;
            this.windowedDataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                        this.windowedDataPlot});
            this.windowedDataWaveformGraph.Size = new System.Drawing.Size(304, 136);
            this.windowedDataWaveformGraph.TabIndex = 49;
            this.windowedDataWaveformGraph.TabStop = false;
            this.windowedDataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                                 this.windowedDataXAxis});
            this.windowedDataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                                 this.windowedDataYAxis});
            // 
            // windowsPlot
            // 
            this.windowsPlot.XAxis = this.windowsXAxis;
            this.windowsPlot.YAxis = this.windowsYAxis;
            // 
            // dbLabel
            // 
            this.dbLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dbLabel.Location = new System.Drawing.Point(496, 474);
            this.dbLabel.Name = "dbLabel";
            this.dbLabel.Size = new System.Drawing.Size(21, 16);
            this.dbLabel.TabIndex = 46;
            this.dbLabel.Text = " dB";
            // 
            // linearLabel
            // 
            this.linearLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.linearLabel.Location = new System.Drawing.Point(560, 474);
            this.linearLabel.Name = "linearLabel";
            this.linearLabel.Size = new System.Drawing.Size(36, 16);
            this.linearLabel.TabIndex = 47;
            this.linearLabel.Text = "Linear";
            // 
            // linearLogSwitch
            // 
            this.linearLogSwitch.Location = new System.Drawing.Point(505, 462);
            this.linearLogSwitch.Name = "linearLogSwitch";
            this.linearLogSwitch.Size = new System.Drawing.Size(64, 40);
            this.linearLogSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalToggle3D;
            this.linearLogSwitch.TabIndex = 3;
            // 
            // windowTypesComboBox
            // 
            this.windowTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.windowTypesComboBox.Location = new System.Drawing.Point(145, 120);
            this.windowTypesComboBox.Name = "windowTypesComboBox";
            this.windowTypesComboBox.Size = new System.Drawing.Size(136, 21);
            this.windowTypesComboBox.TabIndex = 2;
            // 
            // windowsWaveformGraph
            // 
            this.windowsWaveformGraph.Caption = "Window Preview";
            this.windowsWaveformGraph.Location = new System.Drawing.Point(25, 168);
            this.windowsWaveformGraph.Name = "windowsWaveformGraph";
            this.windowsWaveformGraph.UseColorGenerator = true;
            this.windowsWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                   this.windowsPlot});
            this.windowsWaveformGraph.Size = new System.Drawing.Size(304, 136);
            this.windowsWaveformGraph.TabIndex = 45;
            this.windowsWaveformGraph.TabStop = false;
            this.windowsWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                            this.windowsXAxis});
            this.windowsWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                            this.windowsYAxis});
            // 
            // inputSignal1GroupBox
            // 
            this.inputSignal1GroupBox.Controls.Add(this.input1AmplitudeNumericEdit);
            this.inputSignal1GroupBox.Controls.Add(this.signal1AmplitudeLabel);
            this.inputSignal1GroupBox.Controls.Add(this.signal1FrequencyLabel);
            this.inputSignal1GroupBox.Controls.Add(this.input1FrequencyNumericEdit);
            this.inputSignal1GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputSignal1GroupBox.Location = new System.Drawing.Point(24, 8);
            this.inputSignal1GroupBox.Name = "inputSignal1GroupBox";
            this.inputSignal1GroupBox.Size = new System.Drawing.Size(152, 96);
            this.inputSignal1GroupBox.TabIndex = 0;
            this.inputSignal1GroupBox.TabStop = false;
            this.inputSignal1GroupBox.Text = "Input Signal 1";
            // 
            // input1AmplitudeNumericEdit
            // 
            this.input1AmplitudeNumericEdit.CoercionInterval = 0.1;
            this.input1AmplitudeNumericEdit.Location = new System.Drawing.Point(72, 24);
            this.input1AmplitudeNumericEdit.Name = "input1AmplitudeNumericEdit";
            this.input1AmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.input1AmplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0.1, System.Double.PositiveInfinity);
            this.input1AmplitudeNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.input1AmplitudeNumericEdit.TabIndex = 0;
            this.input1AmplitudeNumericEdit.Value = 0.1;
            // 
            // signal1AmplitudeLabel
            // 
            this.signal1AmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signal1AmplitudeLabel.Location = new System.Drawing.Point(8, 26);
            this.signal1AmplitudeLabel.Name = "signal1AmplitudeLabel";
            this.signal1AmplitudeLabel.Size = new System.Drawing.Size(58, 16);
            this.signal1AmplitudeLabel.TabIndex = 39;
            this.signal1AmplitudeLabel.Text = "Amplitude:";
            // 
            // signal1FrequencyLabel
            // 
            this.signal1FrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signal1FrequencyLabel.Location = new System.Drawing.Point(8, 58);
            this.signal1FrequencyLabel.Name = "signal1FrequencyLabel";
            this.signal1FrequencyLabel.Size = new System.Drawing.Size(61, 16);
            this.signal1FrequencyLabel.TabIndex = 40;
            this.signal1FrequencyLabel.Text = "Frequency:";
            // 
            // input1FrequencyNumericEdit
            // 
            this.input1FrequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.input1FrequencyNumericEdit.Location = new System.Drawing.Point(72, 56);
            this.input1FrequencyNumericEdit.Name = "input1FrequencyNumericEdit";
            this.input1FrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.input1FrequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.input1FrequencyNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.input1FrequencyNumericEdit.TabIndex = 1;
            this.input1FrequencyNumericEdit.Value = 100;
            // 
            // inputSignal2GroupBox
            // 
            this.inputSignal2GroupBox.Controls.Add(this.signal2AmplitudeLabel);
            this.inputSignal2GroupBox.Controls.Add(this.signal2FrequencyLabel);
            this.inputSignal2GroupBox.Controls.Add(this.input2AmplitudeNumericEdit);
            this.inputSignal2GroupBox.Controls.Add(this.input2FrequencyNumericEdit);
            this.inputSignal2GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputSignal2GroupBox.Location = new System.Drawing.Point(184, 8);
            this.inputSignal2GroupBox.Name = "inputSignal2GroupBox";
            this.inputSignal2GroupBox.Size = new System.Drawing.Size(152, 96);
            this.inputSignal2GroupBox.TabIndex = 1;
            this.inputSignal2GroupBox.TabStop = false;
            this.inputSignal2GroupBox.Text = "Input Signal 2";
            // 
            // signal2AmplitudeLabel
            // 
            this.signal2AmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signal2AmplitudeLabel.Location = new System.Drawing.Point(4, 26);
            this.signal2AmplitudeLabel.Name = "signal2AmplitudeLabel";
            this.signal2AmplitudeLabel.Size = new System.Drawing.Size(58, 16);
            this.signal2AmplitudeLabel.TabIndex = 40;
            this.signal2AmplitudeLabel.Text = "Amplitude:";
            // 
            // signal2FrequencyLabel
            // 
            this.signal2FrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signal2FrequencyLabel.Location = new System.Drawing.Point(4, 58);
            this.signal2FrequencyLabel.Name = "signal2FrequencyLabel";
            this.signal2FrequencyLabel.Size = new System.Drawing.Size(61, 16);
            this.signal2FrequencyLabel.TabIndex = 39;
            this.signal2FrequencyLabel.Text = "Frequency:";
            // 
            // input2AmplitudeNumericEdit
            // 
            this.input2AmplitudeNumericEdit.Location = new System.Drawing.Point(68, 24);
            this.input2AmplitudeNumericEdit.Name = "input2AmplitudeNumericEdit";
            this.input2AmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.input2AmplitudeNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.input2AmplitudeNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.input2AmplitudeNumericEdit.TabIndex = 0;
            this.input2AmplitudeNumericEdit.Value = 100;
            // 
            // input2FrequencyNumericEdit
            // 
            this.input2FrequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.input2FrequencyNumericEdit.Location = new System.Drawing.Point(68, 56);
            this.input2FrequencyNumericEdit.Name = "input2FrequencyNumericEdit";
            this.input2FrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.input2FrequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
            this.input2FrequencyNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.input2FrequencyNumericEdit.TabIndex = 1;
            this.input2FrequencyNumericEdit.Value = 25;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(738, 509);
            this.Controls.Add(this.inputSignal2GroupBox);
            this.Controls.Add(this.scaledWindowTypesLabel);
            this.Controls.Add(this.freqDomainWaveformGraph);
            this.Controls.Add(this.addTimeDomainWaveformGraph);
            this.Controls.Add(this.windowedDataWaveformGraph);
            this.Controls.Add(this.windowsWaveformGraph);
            this.Controls.Add(this.dbLabel);
            this.Controls.Add(this.linearLabel);
            this.Controls.Add(this.windowTypesComboBox);
            this.Controls.Add(this.inputSignal1GroupBox);
            this.Controls.Add(this.linearLogSwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(744, 536);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windowing";
            ((System.ComponentModel.ISupportInitialize)(this.freqDomainWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addTimeDomainWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowedDataWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearLogSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowsWaveformGraph)).EndInit();
            this.inputSignal1GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input1AmplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1FrequencyNumericEdit)).EndInit();
            this.inputSignal2GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.input2AmplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2FrequencyNumericEdit)).EndInit();
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

        private void RecalculateSignals(object sender, EventArgs e)
        {
            RecalculateAndDrawGraphs();
        }

    
        
    }
}
