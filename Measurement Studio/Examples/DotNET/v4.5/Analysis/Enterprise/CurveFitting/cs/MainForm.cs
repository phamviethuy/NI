//==================================================================================================
//
// Title      : MainForm.cs
// Purpose    : This example shows the user how to use the Analysis curve fitting
//              functions.   
//
//==================================================================================================

using System;
using System.Data;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.SignalGeneration;

namespace NationalInstruments.Examples.CurveFitting
{
    /// <summary>
    /// This example shows the user how to use the Analysis curve fitting functions.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label samplesLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label coeff1Label;
        private System.Windows.Forms.Label coeff2Label;
        private System.Windows.Forms.Label coeff3Label;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.LegendItem legendItem1;
        private NationalInstruments.UI.LegendItem legendItem2;
        private NationalInstruments.UI.ScatterPlot dataPlot;
        private NationalInstruments.UI.ScatterPlot fittedPlot;
        private NationalInstruments.UI.WindowsForms.ScatterGraph curveFitScatterGraph;
        private NationalInstruments.UI.WindowsForms.Legend PlotLegend;
        private NationalInstruments.UI.WindowsForms.NumericEdit coeff1NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit coeff2NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit coeff3NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit mseNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit samplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit orderNumericEdit;
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
            this.samplesLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.orderLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.coeff1Label = new System.Windows.Forms.Label();
            this.coeff2Label = new System.Windows.Forms.Label();
            this.coeff3Label = new System.Windows.Forms.Label();
            this.curveFitScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.dataPlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.fittedPlot = new NationalInstruments.UI.ScatterPlot();
            this.PlotLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.legendItem1 = new NationalInstruments.UI.LegendItem();
            this.legendItem2 = new NationalInstruments.UI.LegendItem();
            this.samplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.orderNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.coeff1NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.coeff2NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.coeff3NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.mseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.curveFitScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlotLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeff1NumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeff2NumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeff3NumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mseNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // samplesLabel
            // 
            this.samplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplesLabel.Location = new System.Drawing.Point(16, 8);
            this.samplesLabel.Name = "samplesLabel";
            this.samplesLabel.Size = new System.Drawing.Size(110, 16);
            this.samplesLabel.TabIndex = 2;
            this.samplesLabel.Text = "Number of Samples:";
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.updateButton.Location = new System.Drawing.Point(16, 312);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 32);
            this.updateButton.TabIndex = 0;
            this.updateButton.Text = "Update Plot";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // orderLabel
            // 
            this.orderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.orderLabel.Location = new System.Drawing.Point(16, 56);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(102, 16);
            this.orderLabel.TabIndex = 6;
            this.orderLabel.Text = "Polynomial Order:";
            // 
            // meanLabel
            // 
            this.meanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.meanLabel.Location = new System.Drawing.Point(16, 256);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(110, 16);
            this.meanLabel.TabIndex = 8;
            this.meanLabel.Text = "Mean Squared Error:";
            // 
            // coeff1Label
            // 
            this.coeff1Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coeff1Label.Location = new System.Drawing.Point(16, 112);
            this.coeff1Label.Name = "coeff1Label";
            this.coeff1Label.Size = new System.Drawing.Size(86, 16);
            this.coeff1Label.TabIndex = 10;
            this.coeff1Label.Text = "First Coefficient:";
            // 
            // coeff2Label
            // 
            this.coeff2Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coeff2Label.Location = new System.Drawing.Point(16, 160);
            this.coeff2Label.Name = "coeff2Label";
            this.coeff2Label.Size = new System.Drawing.Size(110, 16);
            this.coeff2Label.TabIndex = 14;
            this.coeff2Label.Text = "Second Coefficient:";
            // 
            // coeff3Label
            // 
            this.coeff3Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coeff3Label.Location = new System.Drawing.Point(16, 208);
            this.coeff3Label.Name = "coeff3Label";
            this.coeff3Label.Size = new System.Drawing.Size(102, 16);
            this.coeff3Label.TabIndex = 16;
            this.coeff3Label.Text = "Third Coefficient:";
            // 
            // curveFitScatterGraph
            // 
            this.curveFitScatterGraph.Location = new System.Drawing.Point(128, 24);
            this.curveFitScatterGraph.Name = "curveFitScatterGraph";
            this.curveFitScatterGraph.UseColorGenerator = true;
            this.curveFitScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                  this.dataPlot,
                                                                                                  this.fittedPlot});
            this.curveFitScatterGraph.Size = new System.Drawing.Size(360, 320);
            this.curveFitScatterGraph.TabIndex = 21;
            this.curveFitScatterGraph.TabStop = false;
            this.curveFitScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                            this.xAxis1});
            this.curveFitScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                            this.yAxis1});
            // 
            // dataPlot
            // 
            this.dataPlot.XAxis = this.xAxis1;
            this.dataPlot.YAxis = this.yAxis1;
            // 
            // fittedPlot
            // 
            this.fittedPlot.XAxis = this.xAxis1;
            this.fittedPlot.YAxis = this.yAxis1;
            // 
            // PlotLegend
            // 
            this.PlotLegend.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
                                                                                       this.legendItem1,
                                                                                       this.legendItem2});
            this.PlotLegend.Location = new System.Drawing.Point(504, 288);
            this.PlotLegend.Name = "PlotLegend";
            this.PlotLegend.Size = new System.Drawing.Size(104, 56);
            this.PlotLegend.TabIndex = 22;
            this.PlotLegend.TabStop = false;
            // 
            // legendItem1
            // 
            this.legendItem1.Source = this.dataPlot;
            this.legendItem1.Text = "Input Signal";
            // 
            // legendItem2
            // 
            this.legendItem2.Source = this.fittedPlot;
            this.legendItem2.Text = "Fitted Data";
            // 
            // samplesNumericEdit
            // 
            this.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.samplesNumericEdit.Location = new System.Drawing.Point(16, 24);
            this.samplesNumericEdit.Name = "samplesNumericEdit";
            this.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.samplesNumericEdit.Range = new NationalInstruments.UI.Range(3, System.Double.PositiveInfinity);
            this.samplesNumericEdit.Size = new System.Drawing.Size(94, 20);
            this.samplesNumericEdit.TabIndex = 1;
            this.samplesNumericEdit.Value = 50;
            // 
            // orderNumericEdit
            // 
            this.orderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.orderNumericEdit.Location = new System.Drawing.Point(16, 72);
            this.orderNumericEdit.Name = "orderNumericEdit";
            this.orderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.orderNumericEdit.Range = new NationalInstruments.UI.Range(2, 50);
            this.orderNumericEdit.Size = new System.Drawing.Size(94, 20);
            this.orderNumericEdit.TabIndex = 2;
            this.orderNumericEdit.Value = 2;
            // 
            // coeff1NumericEdit
            // 
            this.coeff1NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6);
            this.coeff1NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.coeff1NumericEdit.Location = new System.Drawing.Point(16, 128);
            this.coeff1NumericEdit.Name = "coeff1NumericEdit";
            this.coeff1NumericEdit.Size = new System.Drawing.Size(94, 20);
            this.coeff1NumericEdit.TabIndex = 2;
            this.coeff1NumericEdit.TabStop = false;
            // 
            // coeff2NumericEdit
            // 
            this.coeff2NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6);
            this.coeff2NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.coeff2NumericEdit.Location = new System.Drawing.Point(16, 176);
            this.coeff2NumericEdit.Name = "coeff2NumericEdit";
            this.coeff2NumericEdit.Size = new System.Drawing.Size(94, 20);
            this.coeff2NumericEdit.TabIndex = 2;
            this.coeff2NumericEdit.TabStop = false;
            // 
            // coeff3NumericEdit
            // 
            this.coeff3NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6);
            this.coeff3NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.coeff3NumericEdit.Location = new System.Drawing.Point(16, 224);
            this.coeff3NumericEdit.Name = "coeff3NumericEdit";
            this.coeff3NumericEdit.Size = new System.Drawing.Size(94, 20);
            this.coeff3NumericEdit.TabIndex = 2;
            this.coeff3NumericEdit.TabStop = false;
            // 
            // mseNumericEdit
            // 
            this.mseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6);
            this.mseNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.mseNumericEdit.Location = new System.Drawing.Point(16, 272);
            this.mseNumericEdit.Name = "mseNumericEdit";
            this.mseNumericEdit.Size = new System.Drawing.Size(94, 20);
            this.mseNumericEdit.TabIndex = 2;
            this.mseNumericEdit.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(618, 360);
            this.Controls.Add(this.orderNumericEdit);
            this.Controls.Add(this.samplesNumericEdit);
            this.Controls.Add(this.PlotLegend);
            this.Controls.Add(this.curveFitScatterGraph);
            this.Controls.Add(this.coeff3Label);
            this.Controls.Add(this.coeff2Label);
            this.Controls.Add(this.coeff1Label);
            this.Controls.Add(this.meanLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.samplesLabel);
            this.Controls.Add(this.coeff1NumericEdit);
            this.Controls.Add(this.coeff2NumericEdit);
            this.Controls.Add(this.coeff3NumericEdit);
            this.Controls.Add(this.mseNumericEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curve Fitting";
            ((System.ComponentModel.ISupportInitialize)(this.curveFitScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlotLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeff1NumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeff2NumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coeff3NumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mseNumericEdit)).EndInit();
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

        private void updateButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                // Initialization.
                double mean;
                double [] coeffArray;
                int samples = (int)samplesNumericEdit.Value;
                double [] xArray = new double [samples]; 
                double [] dataArray = new double [samples];
                double [] fittedArray = new double [samples];
                BasicFunctionGenerator functionGen = new BasicFunctionGenerator(BasicFunctionGeneratorSignal.Sine, 2.0/(double)samples, BasicFunctionGenerator.DefaultAmplitude, BasicFunctionGenerator.DefaultPhase, BasicFunctionGenerator.DefaultOffset, 1.0, samples);
            
                // Generate the sine wave and the fitted plot.
                xArray = PatternGeneration.Ramp(samples, 0, samples - 1);
                dataArray = functionGen.Generate();
                fittedArray = CurveFit.PolynomialFit(xArray, dataArray, (int)orderNumericEdit.Value, PolynomialFitAlgorithm.Svd, out coeffArray, out mean);
                
                // Display the mean and coefficient data.
                mseNumericEdit.Value = mean;
                coeff1NumericEdit.Value = coeffArray[0];
                coeff2NumericEdit.Value= coeffArray[1];
                coeff3NumericEdit.Value = coeffArray[2];
            
                // Plot the data on the graph.
                dataPlot.PlotXY(xArray, dataArray);
                fittedPlot.PlotXY(xArray, fittedArray);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

    }
}
