
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomErrorData
{

	public class MainForm : System.Windows.Forms.Form
	{
        const int pointCount = 61;
        private double[] xData;
        private double[] yData;
        private ExplicitErrorMode explicitErrorMode;
        private CombinationErrorMode combinationErrorMode;
        
        private NationalInstruments.UI.YAxis yAxis;
		private NationalInstruments.UI.XAxis xAxis;
		private NationalInstruments.UI.ScatterPlot scatterPlot;
		private System.Windows.Forms.GroupBox errorModeGroupBox;
		private System.Windows.Forms.RadioButton noneModeRadioButton;
		private System.Windows.Forms.RadioButton explicitModeRadioButton;
		private System.Windows.Forms.RadioButton combinationModeRadioButton;
        private System.Windows.Forms.Label constantOffsetLabel;
		private System.ComponentModel.Container components = null;
        private NationalInstruments.UI.WindowsForms.NumericEdit constantNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit percentNumericEdit;
        private System.Windows.Forms.Label percentOffsetLabel;
        private System.Windows.Forms.Label thresholdLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit limitNumericEdit;
        private System.Windows.Forms.Label limitLabel;
        private System.Windows.Forms.Panel spacerPanel;
        private NationalInstruments.UI.WindowsForms.ScatterGraph sampleScatterGraph;
        private NationalInstruments.UI.WindowsForms.NumericEdit thresholdNumericEdit;

		public MainForm()
		{
			InitializeComponent();
		}

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
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.scatterPlot = new NationalInstruments.UI.ScatterPlot();
            this.sampleScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.errorModeGroupBox = new System.Windows.Forms.GroupBox();
            this.limitNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.limitLabel = new System.Windows.Forms.Label();
            this.thresholdNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.thresholdLabel = new System.Windows.Forms.Label();
            this.percentNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.percentOffsetLabel = new System.Windows.Forms.Label();
            this.constantNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.constantOffsetLabel = new System.Windows.Forms.Label();
            this.explicitModeRadioButton = new System.Windows.Forms.RadioButton();
            this.combinationModeRadioButton = new System.Windows.Forms.RadioButton();
            this.noneModeRadioButton = new System.Windows.Forms.RadioButton();
            this.spacerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).BeginInit();
            this.errorModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constantNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // scatterPlot
            // 
            this.scatterPlot.CanScaleYAxis = true;
            this.scatterPlot.XAxis = this.xAxis;
            this.scatterPlot.YAxis = this.yAxis;
            // 
            // sampleScatterGraph
            // 
            this.sampleScatterGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleScatterGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleScatterGraph.Name = "scatterGraph";
            this.sampleScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot});
            this.sampleScatterGraph.Size = new System.Drawing.Size(376, 262);
            this.sampleScatterGraph.TabIndex = 5;
            this.sampleScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // errorModeGroupBox
            // 
            this.errorModeGroupBox.Controls.Add(this.limitNumericEdit);
            this.errorModeGroupBox.Controls.Add(this.limitLabel);
            this.errorModeGroupBox.Controls.Add(this.thresholdNumericEdit);
            this.errorModeGroupBox.Controls.Add(this.thresholdLabel);
            this.errorModeGroupBox.Controls.Add(this.percentNumericEdit);
            this.errorModeGroupBox.Controls.Add(this.percentOffsetLabel);
            this.errorModeGroupBox.Controls.Add(this.constantNumericEdit);
            this.errorModeGroupBox.Controls.Add(this.constantOffsetLabel);
            this.errorModeGroupBox.Controls.Add(this.explicitModeRadioButton);
            this.errorModeGroupBox.Controls.Add(this.combinationModeRadioButton);
            this.errorModeGroupBox.Controls.Add(this.noneModeRadioButton);
            this.errorModeGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorModeGroupBox.Location = new System.Drawing.Point(8, 278);
            this.errorModeGroupBox.Name = "errorModeGroupBox";
            this.errorModeGroupBox.Size = new System.Drawing.Size(376, 224);
            this.errorModeGroupBox.TabIndex = 0;
            this.errorModeGroupBox.TabStop = false;
            this.errorModeGroupBox.Text = "Custom &Error Data Modes";
            // 
            // limitNumericEdit
            // 
            this.limitNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.limitNumericEdit.Location = new System.Drawing.Point(72, 80);
            this.limitNumericEdit.Name = "limitNumericEdit";
            this.limitNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.limitNumericEdit.Range = new NationalInstruments.UI.Range(0, double.PositiveInfinity);
            this.limitNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.limitNumericEdit.TabIndex = 5;
            this.limitNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.limitNumericEdit.Value = 2;
            this.limitNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.limitNumericEdit_AfterChangeValue);
            // 
            // limitLabel
            // 
            this.limitLabel.Location = new System.Drawing.Point(32, 80);
            this.limitLabel.Name = "limitLabel";
            this.limitLabel.Size = new System.Drawing.Size(32, 20);
            this.limitLabel.TabIndex = 4;
            this.limitLabel.Text = "&Limit:";
            this.limitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // thresholdNumericEdit
            // 
            this.thresholdNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.thresholdNumericEdit.Location = new System.Drawing.Point(128, 192);
            this.thresholdNumericEdit.Name = "thresholdNumericEdit";
            this.thresholdNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.thresholdNumericEdit.Range = new NationalInstruments.UI.Range(0, double.PositiveInfinity);
            this.thresholdNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.thresholdNumericEdit.TabIndex = 12;
            this.thresholdNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.thresholdNumericEdit.Value = 10;
            this.thresholdNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.thresholdNumericEdit_AfterChangeValue);
            // 
            // thresholdLabel
            // 
            this.thresholdLabel.Location = new System.Drawing.Point(32, 192);
            this.thresholdLabel.Name = "thresholdLabel";
            this.thresholdLabel.Size = new System.Drawing.Size(88, 20);
            this.thresholdLabel.TabIndex = 11;
            this.thresholdLabel.Text = "&Threshold:";
            this.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // percentNumericEdit
            // 
            this.percentNumericEdit.CoercionInterval = 0.1;
            this.percentNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("0.###\'%\'");
            this.percentNumericEdit.Location = new System.Drawing.Point(128, 164);
            this.percentNumericEdit.Name = "percentNumericEdit";
            this.percentNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.percentNumericEdit.Range = new NationalInstruments.UI.Range(0, double.PositiveInfinity);
            this.percentNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.percentNumericEdit.TabIndex = 10;
            this.percentNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.percentNumericEdit.Value = 25;
            this.percentNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.percentNumericEdit_AfterChangeValue);
            // 
            // percentOffsetLabel
            // 
            this.percentOffsetLabel.Location = new System.Drawing.Point(32, 164);
            this.percentOffsetLabel.Name = "percentOffsetLabel";
            this.percentOffsetLabel.Size = new System.Drawing.Size(88, 20);
            this.percentOffsetLabel.TabIndex = 9;
            this.percentOffsetLabel.Text = "&Percent Offset:";
            this.percentOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // constantNumericEdit
            // 
            this.constantNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0");
            this.constantNumericEdit.Location = new System.Drawing.Point(128, 136);
            this.constantNumericEdit.Name = "constantNumericEdit";
            this.constantNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.constantNumericEdit.Range = new NationalInstruments.UI.Range(0, double.PositiveInfinity);
            this.constantNumericEdit.Size = new System.Drawing.Size(77, 20);
            this.constantNumericEdit.TabIndex = 8;
            this.constantNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.constantNumericEdit.Value = 2;
            this.constantNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.constantNumericEdit_AfterChangeValue);
            // 
            // constantOffsetLabel
            // 
            this.constantOffsetLabel.Location = new System.Drawing.Point(32, 136);
            this.constantOffsetLabel.Name = "constantOffsetLabel";
            this.constantOffsetLabel.Size = new System.Drawing.Size(88, 20);
            this.constantOffsetLabel.TabIndex = 7;
            this.constantOffsetLabel.Text = "C&onstant Offset:";
            this.constantOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // explicitModeRadioButton
            // 
            this.explicitModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.explicitModeRadioButton.Location = new System.Drawing.Point(16, 52);
            this.explicitModeRadioButton.Name = "explicitModeRadioButton";
            this.explicitModeRadioButton.Size = new System.Drawing.Size(128, 24);
            this.explicitModeRadioButton.TabIndex = 1;
            this.explicitModeRadioButton.Text = "&Explicit Error values";
            this.explicitModeRadioButton.CheckedChanged += new System.EventHandler(this.explicitModeRadioButton_CheckedChanged);
            // 
            // combinationModeRadioButton
            // 
            this.combinationModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.combinationModeRadioButton.Location = new System.Drawing.Point(16, 108);
            this.combinationModeRadioButton.Name = "combinationModeRadioButton";
            this.combinationModeRadioButton.Size = new System.Drawing.Size(200, 24);
            this.combinationModeRadioButton.TabIndex = 6;
            this.combinationModeRadioButton.Text = "&Combination Constant/Percent";
            this.combinationModeRadioButton.CheckedChanged += new System.EventHandler(this.combinationModeRadioButton_CheckedChanged);
            // 
            // noneModeRadioButton
            // 
            this.noneModeRadioButton.Checked = true;
            this.noneModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noneModeRadioButton.Location = new System.Drawing.Point(16, 24);
            this.noneModeRadioButton.Name = "noneModeRadioButton";
            this.noneModeRadioButton.Size = new System.Drawing.Size(128, 24);
            this.noneModeRadioButton.TabIndex = 0;
            this.noneModeRadioButton.TabStop = true;
            this.noneModeRadioButton.Text = "&None";
            this.noneModeRadioButton.CheckedChanged += new System.EventHandler(this.noneModeRadioButton_CheckedChanged);
            // 
            // spacerPanel
            // 
            this.spacerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.spacerPanel.Location = new System.Drawing.Point(8, 270);
            this.spacerPanel.Name = "spacerPanel";
            this.spacerPanel.Size = new System.Drawing.Size(376, 8);
            this.spacerPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(392, 510);
            this.Controls.Add(this.sampleScatterGraph);
            this.Controls.Add(this.spacerPanel);
            this.Controls.Add(this.errorModeGroupBox);
            this.DockPadding.All = 8;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(250, 456);
            this.Name = "MainForm";
            this.Text = "Custom Error Data";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).EndInit();
            this.errorModeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.limitNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thresholdNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constantNumericEdit)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

        private void MainForm_Load(object sender, System.EventArgs e)
		{
			xData = new double[pointCount];
			yData = new double[pointCount];

			const int regions = 3;
			const int regionThreshold = pointCount / regions;
			int threshold = -1;

			double current = 0.0;
			bool largeIncrement = false;
			double pointIncrement = 0.0;
			for (int i = 0; i < pointCount; ++i)
			{
				if (i > threshold)
				{
					threshold += regionThreshold;
					largeIncrement = !largeIncrement;
					pointIncrement = (largeIncrement ? 2.0 : -1.0);
				}

				xData[i] = i;
				yData[i] = current;

				current += pointIncrement;
			}

			scatterPlot.PlotXY(xData, yData);

            limitNumericEdit.Range = new Range(0, pointCount / 2);
            thresholdNumericEdit.Range = new Range(0, pointCount);


            ResetCombinationErrorMode();
            explicitErrorMode = new ExplicitErrorMode(scatterPlot);
            noneModeRadioButton.Checked = true;
        }

		private void noneModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			scatterPlot.YErrorDataMode = XYErrorDataMode.CreateNoneMode();
		}


        private void explicitModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
            ResetExplicitErrorMode();
        }

        private void limitNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            ResetExplicitErrorMode();
            explicitModeRadioButton.Checked = true;
        }

        private void ResetExplicitErrorMode()
        {
            if(explicitErrorMode != null)
            {
                // Create explicit error data to plot along with our data.
                double[] errorData = new double[pointCount];

                const double min = 1.0;
                double max = min + limitNumericEdit.Value;

                double increment = 0.5;
                double current = min;
                for(int i = 0; i < pointCount; ++i)
                {
                    errorData[i] = current;

                    current += increment;

                    if(current < min || current > max)
                    {
                        increment = -increment;

                        current += increment;
                    }
                }


                scatterPlot.YErrorDataMode = explicitErrorMode;
                explicitErrorMode.PlotXYWithError(xData, yData, errorData);
            }
        }


		private void combinationModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
            scatterPlot.YErrorDataMode = combinationErrorMode;
        }

        private void constantNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            ResetCombinationErrorMode();
            combinationModeRadioButton.Checked = true;
        }

        private void percentNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            ResetCombinationErrorMode();
            combinationModeRadioButton.Checked = true;
        }

        private void thresholdNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            ResetCombinationErrorMode();
            combinationModeRadioButton.Checked = true;
        }

        private void ResetCombinationErrorMode()
        {
            combinationErrorMode = new CombinationErrorMode(constantNumericEdit.Value, percentNumericEdit.Value, (int)thresholdNumericEdit.Value);

            if(combinationModeRadioButton.Checked)
            {
                scatterPlot.YErrorDataMode = combinationErrorMode;
            }
        }
	}

}
