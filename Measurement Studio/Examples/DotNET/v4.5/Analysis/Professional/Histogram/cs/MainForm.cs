using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.SignalGeneration;

namespace NationalInstruments.Examples.Histogram
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.ScatterPlot histogramPlot;
        private NationalInstruments.UI.WindowsForms.NumericEdit numBinsNumericEdit;
        private System.Windows.Forms.Label numBinsLabel;        
        private System.Windows.Forms.Button genDataButton;
        private NationalInstruments.UI.WindowsForms.WaveformGraph dataWaveformGraph;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private const int datasize = 100;
        private NationalInstruments.UI.WindowsForms.ScatterGraph histogramScatterGraph;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.Label stdDevLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit standardDevNumericEdit;
        private System.ComponentModel.IContainer components=null;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            genDataButton_Click(null,null);
        
            //
            // TODO: Add any constructor code after InitializeComponent call
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
            this.histogramScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.histogramPlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.numBinsNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numBinsLabel = new System.Windows.Forms.Label();
            this.genDataButton = new System.Windows.Forms.Button();
            this.dataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.standardDevNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.stdDevLabel = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.histogramScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBinsNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardDevNumericEdit)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // histogramScatterGraph
            // 
            this.histogramScatterGraph.Caption = "Histogram";
            this.histogramScatterGraph.Location = new System.Drawing.Point(8, 216);
            this.histogramScatterGraph.Name = "histogramScatterGraph";
            this.histogramScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                   this.histogramPlot});
            this.histogramScatterGraph.Size = new System.Drawing.Size(424, 200);
            this.histogramScatterGraph.TabIndex = 2;
            this.histogramScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                             this.xAxis1});
            this.histogramScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                             this.yAxis1});
            // 
            // histogramPlot
            // 
            this.histogramPlot.FillMode = NationalInstruments.UI.PlotFillMode.FillAndBins;
            this.histogramPlot.LineColor = System.Drawing.Color.BurlyWood;
            this.histogramPlot.LineStep = NationalInstruments.UI.LineStep.CenteredXYStep;
            this.histogramPlot.XAxis = this.xAxis1;
            this.histogramPlot.YAxis = this.yAxis1;
            // 
            // numBinsNumericEdit
            // 
            this.numBinsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.numBinsNumericEdit.Location = new System.Drawing.Point(120, 16);
            this.numBinsNumericEdit.Name = "numBinsNumericEdit";
            this.numBinsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numBinsNumericEdit.Range = new NationalInstruments.UI.Range(1, 1000);
            this.numBinsNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.numBinsNumericEdit.TabIndex = 1;
            this.numBinsNumericEdit.Value = 20;
            // 
            // numBinsLabel
            // 
            this.numBinsLabel.Location = new System.Drawing.Point(8, 16);
            this.numBinsLabel.Name = "numBinsLabel";
            this.numBinsLabel.Size = new System.Drawing.Size(88, 16);
            this.numBinsLabel.TabIndex = 2;
            this.numBinsLabel.Text = "Number of Bins: ";
            // 
            // genDataButton
            // 
            this.genDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genDataButton.Location = new System.Drawing.Point(240, 432);
            this.genDataButton.Name = "genDataButton";
            this.genDataButton.Size = new System.Drawing.Size(192, 40);
            this.genDataButton.TabIndex = 0;
            this.genDataButton.Text = "Display Data";
            this.genDataButton.Click += new System.EventHandler(this.genDataButton_Click);
            // 
            // dataWaveformGraph
            // 
            this.dataWaveformGraph.Caption = "Raw Data";
            this.dataWaveformGraph.Location = new System.Drawing.Point(8, 8);
            this.dataWaveformGraph.Name = "dataWaveformGraph";
            this.dataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                this.waveformPlot1});
            this.dataWaveformGraph.Size = new System.Drawing.Size(424, 200);
            this.dataWaveformGraph.TabIndex = 3;
            this.dataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                         this.xAxis2});
            this.dataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                         this.yAxis2});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis2;
            this.waveformPlot1.YAxis = this.yAxis2;
            // 
            // standardDevNumericEdit
            // 
            this.standardDevNumericEdit.Location = new System.Drawing.Point(120, 48);
            this.standardDevNumericEdit.Name = "standardDevNumericEdit";
            this.standardDevNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.standardDevNumericEdit.Range = new NationalInstruments.UI.Range(0.1, 10000);
            this.standardDevNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.standardDevNumericEdit.TabIndex = 5;
            this.standardDevNumericEdit.Value = 1;
            // 
            // stdDevLabel
            // 
            this.stdDevLabel.Location = new System.Drawing.Point(8, 48);
            this.stdDevLabel.Name = "stdDevLabel";
            this.stdDevLabel.Size = new System.Drawing.Size(104, 16);
            this.stdDevLabel.TabIndex = 6;
            this.stdDevLabel.Text = "Standard Deviation: ";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.numBinsLabel);
            this.settingsGroupBox.Controls.Add(this.standardDevNumericEdit);
            this.settingsGroupBox.Controls.Add(this.stdDevLabel);
            this.settingsGroupBox.Controls.Add(this.numBinsNumericEdit);
            this.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsGroupBox.Location = new System.Drawing.Point(8, 424);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(216, 80);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Data Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(440, 512);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.dataWaveformGraph);
            this.Controls.Add(this.histogramScatterGraph);
            this.Controls.Add(this.genDataButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Histogram";
            ((System.ComponentModel.ISupportInitialize)(this.histogramScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBinsNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardDevNumericEdit)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
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

        private void genDataButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                int numBins = (int)numBinsNumericEdit.Value;
                int[] histogram;
                double[] centerValues;
                double[] data = new double[datasize];

                GaussianNoiseSignal signal = new GaussianNoiseSignal(standardDevNumericEdit.Value);
                data = signal.Generate(1000,datasize);
                dataWaveformGraph.PlotY(data);
                double minValue = ArrayOperation.GetMin(data);
                double maxValue = ArrayOperation.GetMax(data);
                histogram = Statistics.Histogram(data,minValue,maxValue,numBins,out centerValues);
             
                double[] doubleHistogram = (double[])DataConverter.Convert(histogram,typeof(double[]));
                histogramScatterGraph.PlotXY(centerValues,doubleHistogram);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
            
        }
    }
}
