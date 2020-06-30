
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.ErrorDataModes
{

    public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ComboBox displayModeComboBox;
		private System.Windows.Forms.Panel displayModePanel;
		private System.Windows.Forms.Label displayModeLabel;
		private System.Windows.Forms.GroupBox errorModeGroupBox;
		private System.Windows.Forms.RadioButton percentModeRadioButton;
		private System.Windows.Forms.RadioButton constantModeRadioButton;
		private System.Windows.Forms.RadioButton noneModeRadioButton;
		private NationalInstruments.UI.XAxis xAxis;
		private NationalInstruments.UI.YAxis yAxis;
		private NationalInstruments.UI.ScatterPlot scatterPlot;
        private NationalInstruments.UI.WindowsForms.ScatterGraph sampleScatterGraph;
		private System.ComponentModel.Container components = null;

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
            this.displayModePanel = new System.Windows.Forms.Panel();
            this.displayModeComboBox = new System.Windows.Forms.ComboBox();
            this.displayModeLabel = new System.Windows.Forms.Label();
            this.errorModeGroupBox = new System.Windows.Forms.GroupBox();
            this.percentModeRadioButton = new System.Windows.Forms.RadioButton();
            this.constantModeRadioButton = new System.Windows.Forms.RadioButton();
            this.noneModeRadioButton = new System.Windows.Forms.RadioButton();
            this.sampleScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.displayModePanel.SuspendLayout();
            this.errorModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // displayModePanel
            // 
            this.displayModePanel.Controls.Add(this.displayModeComboBox);
            this.displayModePanel.Controls.Add(this.displayModeLabel);
            this.displayModePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.displayModePanel.DockPadding.Bottom = 8;
            this.displayModePanel.DockPadding.Top = 8;
            this.displayModePanel.Location = new System.Drawing.Point(8, 265);
            this.displayModePanel.Name = "displayModePanel";
            this.displayModePanel.Size = new System.Drawing.Size(376, 37);
            this.displayModePanel.TabIndex = 1;
            // 
            // displayModeComboBox
            // 
            this.displayModeComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.displayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayModeComboBox.Location = new System.Drawing.Point(76, 8);
            this.displayModeComboBox.Name = "displayModeComboBox";
            this.displayModeComboBox.Size = new System.Drawing.Size(100, 21);
            this.displayModeComboBox.TabIndex = 1;
            this.displayModeComboBox.SelectedIndexChanged += new System.EventHandler(this.displayModeComboBox_SelectedIndexChanged);
            // 
            // displayModeLabel
            // 
            this.displayModeLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.displayModeLabel.Location = new System.Drawing.Point(0, 8);
            this.displayModeLabel.Name = "displayModeLabel";
            this.displayModeLabel.Size = new System.Drawing.Size(76, 21);
            this.displayModeLabel.TabIndex = 0;
            this.displayModeLabel.Text = "&Display Mode:";
            this.displayModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errorModeGroupBox
            // 
            this.errorModeGroupBox.Controls.Add(this.percentModeRadioButton);
            this.errorModeGroupBox.Controls.Add(this.constantModeRadioButton);
            this.errorModeGroupBox.Controls.Add(this.noneModeRadioButton);
            this.errorModeGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.errorModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.errorModeGroupBox.Location = new System.Drawing.Point(8, 302);
            this.errorModeGroupBox.Name = "errorModeGroupBox";
            this.errorModeGroupBox.Size = new System.Drawing.Size(376, 112);
            this.errorModeGroupBox.TabIndex = 0;
            this.errorModeGroupBox.TabStop = false;
            this.errorModeGroupBox.Text = "&Error Data Mode";
            // 
            // percentModeRadioButton
            // 
            this.percentModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.percentModeRadioButton.Location = new System.Drawing.Point(16, 80);
            this.percentModeRadioButton.Name = "percentModeRadioButton";
            this.percentModeRadioButton.Size = new System.Drawing.Size(120, 24);
            this.percentModeRadioButton.TabIndex = 2;
            this.percentModeRadioButton.Text = "&Percent (+/- 10%)";
            this.percentModeRadioButton.CheckedChanged += new System.EventHandler(this.percentModeRadioButton_CheckedChanged);
            // 
            // constantModeRadioButton
            // 
            this.constantModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.constantModeRadioButton.Location = new System.Drawing.Point(16, 52);
            this.constantModeRadioButton.Name = "constantModeRadioButton";
            this.constantModeRadioButton.Size = new System.Drawing.Size(112, 24);
            this.constantModeRadioButton.TabIndex = 1;
            this.constantModeRadioButton.Text = "&Constant (+/- 5)";
            this.constantModeRadioButton.CheckedChanged += new System.EventHandler(this.constantModeRadioButton_CheckedChanged);
            // 
            // noneModeRadioButton
            // 
            this.noneModeRadioButton.Checked = true;
            this.noneModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noneModeRadioButton.Location = new System.Drawing.Point(16, 24);
            this.noneModeRadioButton.Name = "noneModeRadioButton";
            this.noneModeRadioButton.TabIndex = 0;
            this.noneModeRadioButton.TabStop = true;
            this.noneModeRadioButton.Text = "&None";
            this.noneModeRadioButton.CheckedChanged += new System.EventHandler(this.noneModeRadioButton_CheckedChanged);
            // 
            // sampleScatterGraph
            // 
            this.sampleScatterGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleScatterGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleScatterGraph.Name = "sampleScatterGraph";
            this.sampleScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                                this.scatterPlot});
            this.sampleScatterGraph.Size = new System.Drawing.Size(376, 257);
            this.sampleScatterGraph.TabIndex = 2;
            this.sampleScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                          this.xAxis});
            this.sampleScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                          this.yAxis});
            // 
            // scatterPlot
            // 
            this.scatterPlot.CanScaleYAxis = true;
            this.scatterPlot.XAxis = this.xAxis;
            this.scatterPlot.YAxis = this.yAxis;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(392, 422);
            this.Controls.Add(this.sampleScatterGraph);
            this.Controls.Add(this.displayModePanel);
            this.Controls.Add(this.errorModeGroupBox);
            this.DockPadding.All = 8;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(200, 321);
            this.Name = "MainForm";
            this.Text = "Error Data Modes";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.displayModePanel.ResumeLayout(false);
            this.errorModeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).EndInit();
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
			const int pointCount = 61;
			double[] xData = new double[pointCount];
			double[] yData = new double[pointCount];

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


			foreach(ErrorBandDisplayModes displayMode in Enum.GetValues(typeof(ErrorBandDisplayModes)))
			{
				displayModeComboBox.Items.Add(displayMode);
			}
			displayModeComboBox.SelectedItem = scatterPlot.YErrorDisplayMode;
		}

		private void displayModeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			scatterPlot.YErrorDisplayMode = (ErrorBandDisplayModes)displayModeComboBox.SelectedItem;
		}

		private void noneModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			scatterPlot.YErrorDataMode = XYErrorDataMode.CreateNoneMode();
		}

		private void constantModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			scatterPlot.YErrorDataMode = XYErrorDataMode.CreateConstantErrorMode(5.0);
		}

		private void percentModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
		{
			scatterPlot.YErrorDataMode = XYErrorDataMode.CreatePercentErrorMode(10);
		}
	}

}
