using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Plotting
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.WindowsForms.ComplexGraph sampleComplexGraph;
        private NationalInstruments.UI.ComplexPlot complexPlot;
        private System.ComponentModel.IContainer components;

        private NationalInstruments.UI.WindowsForms.WaveformGraph realWaveformGraph;
        private NationalInstruments.UI.WindowsForms.WaveformGraph imaginaryWaveformGraph;
        private NationalInstruments.UI.WindowsForms.NumericEdit realPhaseNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit realFrequencyNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit imaginaryFrequencyNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit imaginaryPhaseNumericEdit;
        private System.Windows.Forms.GroupBox imaginaryGroupBox;
        private System.Windows.Forms.GroupBox realGroupBox;
        private System.Windows.Forms.Label realPhaseLabel;
        private System.Windows.Forms.Label realFrequencyLabel;
        private System.Windows.Forms.Label imaginaryFrequencyLabel;
        private System.Windows.Forms.Label imaginaryPhaseLabel;
        private NationalInstruments.UI.ComplexXAxis complexXAxis;
        private NationalInstruments.UI.ComplexYAxis complexYAxis;
        private NationalInstruments.UI.WaveformPlot realPlot;
        private NationalInstruments.UI.XAxis realXAxis;
        private NationalInstruments.UI.YAxis realYAxis;
        private NationalInstruments.UI.WaveformPlot imaginaryPlot;
        private NationalInstruments.UI.XAxis imaginaryXAxis;
        private NationalInstruments.UI.YAxis imaginaryYAxis;
        private System.Windows.Forms.Timer plotTimer;
		private System.Windows.Forms.GroupBox plotArrowsGroupBox;
		private NationalInstruments.UI.WindowsForms.PropertyEditor arrowStylePropertyEditor;
		private NationalInstruments.UI.WindowsForms.PropertyEditor arrowDirectionPropertyEditor;
		private System.Windows.Forms.Label arrowStyleLabel;
		private System.Windows.Forms.Label arrowDirectionLabel;

        private int lastPoint;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            PlotData();
        }

        private static double[] GenerateSineWave(int numberOfSamples, double amplitude, double frequency, double samplingRate, double phase, ref int initialPoint)
        {
            if (numberOfSamples < 0)
            {
                throw new ArgumentOutOfRangeException("xRange");
            }

            if (amplitude < 0)
            {
                throw new ArgumentOutOfRangeException("yRange");
            }

            double f = ((2 * Math.PI * frequency) / samplingRate);

            double[] data = new double[numberOfSamples];
            for (int i = 0; i < numberOfSamples; ++i)
            {
                data[i] = amplitude * (Math.Sin(f * (i + initialPoint) + phase));
            }
            initialPoint = initialPoint + numberOfSamples;

            return data;
        }

        private static ComplexDouble[] GenerateComplexData(double[] realData, double[] imaginaryData)
        {
            int numberOfSamples = realData.Length < imaginaryData.Length ? realData.Length : imaginaryData.Length;

            ComplexDouble[] data = new ComplexDouble[numberOfSamples];

            for(int i=0; i<numberOfSamples; i++)
            {
                data[i] = new ComplexDouble(realData[i], imaginaryData[i]);
            }

            return data;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.complexPlot = new NationalInstruments.UI.ComplexPlot();
            this.complexXAxis = new NationalInstruments.UI.ComplexXAxis();
            this.complexYAxis = new NationalInstruments.UI.ComplexYAxis();
            this.realWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.realPlot = new NationalInstruments.UI.WaveformPlot();
            this.realXAxis = new NationalInstruments.UI.XAxis();
            this.realYAxis = new NationalInstruments.UI.YAxis();
            this.imaginaryWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.imaginaryPlot = new NationalInstruments.UI.WaveformPlot();
            this.imaginaryXAxis = new NationalInstruments.UI.XAxis();
            this.imaginaryYAxis = new NationalInstruments.UI.YAxis();
            this.realPhaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.realFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.realPhaseLabel = new System.Windows.Forms.Label();
            this.realFrequencyLabel = new System.Windows.Forms.Label();
            this.imaginaryFrequencyLabel = new System.Windows.Forms.Label();
            this.imaginaryPhaseLabel = new System.Windows.Forms.Label();
            this.imaginaryFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.imaginaryPhaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.imaginaryGroupBox = new System.Windows.Forms.GroupBox();
            this.realGroupBox = new System.Windows.Forms.GroupBox();
            this.plotTimer = new System.Windows.Forms.Timer(this.components);
            this.plotArrowsGroupBox = new System.Windows.Forms.GroupBox();
            this.arrowDirectionLabel = new System.Windows.Forms.Label();
            this.arrowStyleLabel = new System.Windows.Forms.Label();
            this.arrowDirectionPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.arrowStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realPhaseNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realFrequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryFrequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryPhaseNumericEdit)).BeginInit();
            this.imaginaryGroupBox.SuspendLayout();
            this.realGroupBox.SuspendLayout();
            this.plotArrowsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleComplexGraph
            // 
            this.sampleComplexGraph.Caption = "2D Complex Graph";
            this.sampleComplexGraph.Location = new System.Drawing.Point(392, 8);
            this.sampleComplexGraph.Name = "sampleComplexGraph";
            this.sampleComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
            this.complexPlot});
            this.sampleComplexGraph.Size = new System.Drawing.Size(480, 384);
            this.sampleComplexGraph.TabIndex = 0;
            this.sampleComplexGraph.TabStop = false;
            this.sampleComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
            this.complexXAxis});
            this.sampleComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
            this.complexYAxis});
            // 
            // complexPlot
            // 
            this.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode();            
            this.complexPlot.XAxis = this.complexXAxis;
            this.complexPlot.YAxis = this.complexYAxis;
            // 
            // realWaveformGraph
            // 
            this.realWaveformGraph.Location = new System.Drawing.Point(176, 24);
            this.realWaveformGraph.Name = "realWaveformGraph";
            this.realWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.realPlot});
            this.realWaveformGraph.Size = new System.Drawing.Size(192, 120);
            this.realWaveformGraph.TabIndex = 3;
            this.realWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.realXAxis});
            this.realWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.realYAxis});
            // 
            // realPlot
            // 
            this.realPlot.XAxis = this.realXAxis;
            this.realPlot.YAxis = this.realYAxis;
            // 
            // realXAxis
            // 
            this.realXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.realXAxis.Range = new NationalInstruments.UI.Range(0, 100);
            // 
            // imaginaryWaveformGraph
            // 
            this.imaginaryWaveformGraph.Location = new System.Drawing.Point(176, 24);
            this.imaginaryWaveformGraph.Name = "imaginaryWaveformGraph";
            this.imaginaryWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.imaginaryPlot});
            this.imaginaryWaveformGraph.Size = new System.Drawing.Size(192, 120);
            this.imaginaryWaveformGraph.TabIndex = 4;
            this.imaginaryWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.imaginaryXAxis});
            this.imaginaryWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.imaginaryYAxis});
            // 
            // imaginaryPlot
            // 
            this.imaginaryPlot.XAxis = this.imaginaryXAxis;
            this.imaginaryPlot.YAxis = this.imaginaryYAxis;
            // 
            // imaginaryXAxis
            // 
            this.imaginaryXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.imaginaryXAxis.Range = new NationalInstruments.UI.Range(0, 100);
            // 
            // realPhaseNumericEdit
            // 
            this.realPhaseNumericEdit.CoercionInterval = 0.1;
            this.realPhaseNumericEdit.Location = new System.Drawing.Point(96, 32);
            this.realPhaseNumericEdit.Name = "realPhaseNumericEdit";
            this.realPhaseNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.realPhaseNumericEdit.TabIndex = 0;
            this.realPhaseNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.AfterChangeValue);
            // 
            // realFrequencyNumericEdit
            // 
            this.realFrequencyNumericEdit.Location = new System.Drawing.Point(96, 64);
            this.realFrequencyNumericEdit.Name = "realFrequencyNumericEdit";
            this.realFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.realFrequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, double.PositiveInfinity);
            this.realFrequencyNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.realFrequencyNumericEdit.TabIndex = 1;
            this.realFrequencyNumericEdit.Value = 10;
            this.realFrequencyNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.AfterChangeValue);
            // 
            // realPhaseLabel
            // 
            this.realPhaseLabel.Location = new System.Drawing.Point(8, 32);
            this.realPhaseLabel.Name = "realPhaseLabel";
            this.realPhaseLabel.Size = new System.Drawing.Size(88, 16);
            this.realPhaseLabel.TabIndex = 10;
            this.realPhaseLabel.Text = "Phase (Rad):";
            // 
            // realFrequencyLabel
            // 
            this.realFrequencyLabel.Location = new System.Drawing.Point(8, 64);
            this.realFrequencyLabel.Name = "realFrequencyLabel";
            this.realFrequencyLabel.Size = new System.Drawing.Size(88, 16);
            this.realFrequencyLabel.TabIndex = 12;
            this.realFrequencyLabel.Text = "Frequency (Hz):";
            // 
            // imaginaryFrequencyLabel
            // 
            this.imaginaryFrequencyLabel.Location = new System.Drawing.Point(8, 64);
            this.imaginaryFrequencyLabel.Name = "imaginaryFrequencyLabel";
            this.imaginaryFrequencyLabel.Size = new System.Drawing.Size(88, 16);
            this.imaginaryFrequencyLabel.TabIndex = 20;
            this.imaginaryFrequencyLabel.Text = "Frequency (Hz):";
            // 
            // imaginaryPhaseLabel
            // 
            this.imaginaryPhaseLabel.Location = new System.Drawing.Point(8, 32);
            this.imaginaryPhaseLabel.Name = "imaginaryPhaseLabel";
            this.imaginaryPhaseLabel.Size = new System.Drawing.Size(88, 16);
            this.imaginaryPhaseLabel.TabIndex = 18;
            this.imaginaryPhaseLabel.Text = "Phase (Rad):";
            // 
            // imaginaryFrequencyNumericEdit
            // 
            this.imaginaryFrequencyNumericEdit.Location = new System.Drawing.Point(96, 64);
            this.imaginaryFrequencyNumericEdit.Name = "imaginaryFrequencyNumericEdit";
            this.imaginaryFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.imaginaryFrequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, double.PositiveInfinity);
            this.imaginaryFrequencyNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.imaginaryFrequencyNumericEdit.TabIndex = 1;
            this.imaginaryFrequencyNumericEdit.Value = 20;
            this.imaginaryFrequencyNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.AfterChangeValue);
            // 
            // imaginaryPhaseNumericEdit
            // 
            this.imaginaryPhaseNumericEdit.CoercionInterval = 0.1;
            this.imaginaryPhaseNumericEdit.Location = new System.Drawing.Point(96, 32);
            this.imaginaryPhaseNumericEdit.Name = "imaginaryPhaseNumericEdit";
            this.imaginaryPhaseNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.imaginaryPhaseNumericEdit.TabIndex = 0;
            this.imaginaryPhaseNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.AfterChangeValue);
            // 
            // imaginaryGroupBox
            // 
            this.imaginaryGroupBox.Controls.Add(this.imaginaryPhaseLabel);
            this.imaginaryGroupBox.Controls.Add(this.imaginaryWaveformGraph);
            this.imaginaryGroupBox.Controls.Add(this.imaginaryFrequencyNumericEdit);
            this.imaginaryGroupBox.Controls.Add(this.imaginaryPhaseNumericEdit);
            this.imaginaryGroupBox.Controls.Add(this.imaginaryFrequencyLabel);
            this.imaginaryGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.imaginaryGroupBox.Location = new System.Drawing.Point(8, 168);
            this.imaginaryGroupBox.Name = "imaginaryGroupBox";
            this.imaginaryGroupBox.Size = new System.Drawing.Size(376, 160);
            this.imaginaryGroupBox.TabIndex = 2;
            this.imaginaryGroupBox.TabStop = false;
            this.imaginaryGroupBox.Text = "Imaginary Data";
            // 
            // realGroupBox
            // 
            this.realGroupBox.Controls.Add(this.realFrequencyNumericEdit);
            this.realGroupBox.Controls.Add(this.realPhaseNumericEdit);
            this.realGroupBox.Controls.Add(this.realPhaseLabel);
            this.realGroupBox.Controls.Add(this.realFrequencyLabel);
            this.realGroupBox.Controls.Add(this.realWaveformGraph);
            this.realGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.realGroupBox.Location = new System.Drawing.Point(8, 8);
            this.realGroupBox.Name = "realGroupBox";
            this.realGroupBox.Size = new System.Drawing.Size(376, 160);
            this.realGroupBox.TabIndex = 1;
            this.realGroupBox.TabStop = false;
            this.realGroupBox.Text = "Real Data";
            // 
            // plotTimer
            // 
            this.plotTimer.Enabled = true;
            this.plotTimer.Tick += new System.EventHandler(this.plotTimer_Tick);
            // 
            // plotArrowsGroupBox
            // 
            this.plotArrowsGroupBox.Controls.Add(this.arrowDirectionLabel);
            this.plotArrowsGroupBox.Controls.Add(this.arrowStyleLabel);
            this.plotArrowsGroupBox.Controls.Add(this.arrowDirectionPropertyEditor);
            this.plotArrowsGroupBox.Controls.Add(this.arrowStylePropertyEditor);
            this.plotArrowsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotArrowsGroupBox.Location = new System.Drawing.Point(8, 336);
            this.plotArrowsGroupBox.Name = "plotArrowsGroupBox";
            this.plotArrowsGroupBox.Size = new System.Drawing.Size(376, 56);
            this.plotArrowsGroupBox.TabIndex = 3;
            this.plotArrowsGroupBox.TabStop = false;
            this.plotArrowsGroupBox.Text = "Plot arrows";
            // 
            // arrowDirectionLabel
            // 
            this.arrowDirectionLabel.Location = new System.Drawing.Point(208, 23);
            this.arrowDirectionLabel.Name = "arrowDirectionLabel";
            this.arrowDirectionLabel.Size = new System.Drawing.Size(80, 17);
            this.arrowDirectionLabel.TabIndex = 3;
            this.arrowDirectionLabel.Text = "Arrow direction";
            // 
            // arrowStyleLabel
            // 
            this.arrowStyleLabel.Location = new System.Drawing.Point(8, 23);
            this.arrowStyleLabel.Name = "arrowStyleLabel";
            this.arrowStyleLabel.Size = new System.Drawing.Size(62, 17);
            this.arrowStyleLabel.TabIndex = 2;
            this.arrowStyleLabel.Text = "Arrow style";
            // 
            // arrowDirectionPropertyEditor
            // 
            this.arrowDirectionPropertyEditor.Location = new System.Drawing.Point(288, 21);
            this.arrowDirectionPropertyEditor.Name = "arrowDirectionPropertyEditor";
            this.arrowDirectionPropertyEditor.Size = new System.Drawing.Size(80, 20);
            this.arrowDirectionPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.complexPlot, "ArrowDirection");
            this.arrowDirectionPropertyEditor.TabIndex = 1;
            // 
            // arrowStylePropertyEditor
            // 
            this.arrowStylePropertyEditor.Location = new System.Drawing.Point(72, 21);
            this.arrowStylePropertyEditor.Name = "arrowStylePropertyEditor";
            this.arrowStylePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.arrowStylePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.complexPlot, "ArrowStyle");
            this.arrowStylePropertyEditor.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(874, 400);
            this.Controls.Add(this.plotArrowsGroupBox);
            this.Controls.Add(this.realGroupBox);
            this.Controls.Add(this.imaginaryGroupBox);
            this.Controls.Add(this.sampleComplexGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plotting Example";
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realPhaseNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realFrequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryFrequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imaginaryPhaseNumericEdit)).EndInit();
            this.imaginaryGroupBox.ResumeLayout(false);
            this.realGroupBox.ResumeLayout(false);
            this.plotArrowsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        #endregion

        private void PlotDataAppend()
        {
            int numberOfSamples = 1;
            int initialPoint = lastPoint;

            double[] realData = GenerateSineWave(numberOfSamples, 1, realFrequencyNumericEdit.Value, 1000, realPhaseNumericEdit.Value, ref initialPoint);
            realWaveformGraph.PlotYAppend(realData);

            initialPoint = lastPoint;
            double[] imaginaryData = GenerateSineWave(numberOfSamples, 1, imaginaryFrequencyNumericEdit.Value, 1000, imaginaryPhaseNumericEdit.Value, ref initialPoint);
            imaginaryWaveformGraph.PlotYAppend(imaginaryData);

            ComplexDouble[] data = GenerateComplexData(realData, imaginaryData);
            sampleComplexGraph.PlotComplexAppend(data);

            lastPoint = initialPoint;
        }

        private void PlotData()
        {
            int numberOfSamples = 100;
            int initialPoint = 0;

            realWaveformGraph.ClearData();
            realXAxis.Range = new Range(0, 100);
            double[] realData = GenerateSineWave(numberOfSamples, 1, realFrequencyNumericEdit.Value, 1000, realPhaseNumericEdit.Value, ref initialPoint);
            realWaveformGraph.PlotY(realData);

            imaginaryWaveformGraph.ClearData();
            imaginaryXAxis.Range = new Range(0, 100);
            initialPoint = 0;
            double[] imaginaryData = GenerateSineWave(numberOfSamples, 1, imaginaryFrequencyNumericEdit.Value, 1000, imaginaryPhaseNumericEdit.Value, ref initialPoint);
            imaginaryWaveformGraph.PlotY(imaginaryData);

            sampleComplexGraph.ClearData();
            complexXAxis.Range = new Range(0, 100);
            ComplexDouble[] data = GenerateComplexData(realData, imaginaryData);
            sampleComplexGraph.PlotComplex(data);

            lastPoint = initialPoint;
        }

        private void AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            PlotData();	
        }

        private void plotTimer_Tick(object sender, System.EventArgs e)
        {
            PlotDataAppend();
        }
    }
}
