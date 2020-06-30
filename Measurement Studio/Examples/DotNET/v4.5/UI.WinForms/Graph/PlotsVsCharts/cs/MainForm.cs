using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.PlotsVsCharts
{
	public class MainForm : System.Windows.Forms.Form
	{	
        private const int Points = 50;

        private Random rnd;

		private System.Windows.Forms.GroupBox plotGroupBox;
		private System.Windows.Forms.GroupBox appendGroupBox;
		private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button waveformPlot2Button;
        private System.Windows.Forms.Button waveformPlot1Button;
        private System.Windows.Forms.Button appendPlot1Button;
        private System.Windows.Forms.Button appendPlot2Button;
        private System.Windows.Forms.Button clearDataButton;
		private NationalInstruments.UI.WaveformPlot waveformPlot1;
		private NationalInstruments.UI.WaveformPlot waveformPlot2;
		private NationalInstruments.UI.XAxis xAxis;
		private NationalInstruments.UI.YAxis yAxis;
		private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
		private NationalInstruments.UI.WindowsForms.Legend graphLegend;
		private System.Windows.Forms.Label historyCapacityLabel;
        private NationalInstruments.UI.LegendItem plot1LegendItem;
        private NationalInstruments.UI.LegendItem plot2LegendItem;
        private NationalInstruments.UI.WindowsForms.NumericEdit historyCapacityNumericEdit;
		private System.ComponentModel.IContainer components;

		public MainForm ()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();	

            rnd = new Random();
			historyCapacityNumericEdit.Value = waveformPlot1.HistoryCapacity;
			waveformPlot2.HistoryCapacity = waveformPlot1.HistoryCapacity;
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
            this.plotGroupBox = new System.Windows.Forms.GroupBox();
            this.waveformPlot2Button = new System.Windows.Forms.Button();
            this.waveformPlot1Button = new System.Windows.Forms.Button();
            this.appendGroupBox = new System.Windows.Forms.GroupBox();
            this.appendPlot1Button = new System.Windows.Forms.Button();
            this.appendPlot2Button = new System.Windows.Forms.Button();
            this.clearDataButton = new System.Windows.Forms.Button();
            this.historyCapacityLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.graphLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.plot1LegendItem = new NationalInstruments.UI.LegendItem();
            this.plot2LegendItem = new NationalInstruments.UI.LegendItem();
            this.historyCapacityNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.plotGroupBox.SuspendLayout();
            this.appendGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyCapacityNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // plotGroupBox
            // 
            this.plotGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plotGroupBox.Controls.Add(this.waveformPlot2Button);
            this.plotGroupBox.Controls.Add(this.waveformPlot1Button);
            this.plotGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotGroupBox.Location = new System.Drawing.Point(392, 8);
            this.plotGroupBox.Name = "plotGroupBox";
            this.plotGroupBox.Size = new System.Drawing.Size(144, 120);
            this.plotGroupBox.TabIndex = 1;
            this.plotGroupBox.TabStop = false;
            this.plotGroupBox.Text = "Plot";
            // 
            // waveformPlot2Button
            // 
            this.waveformPlot2Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.waveformPlot2Button.Location = new System.Drawing.Point(16, 72);
            this.waveformPlot2Button.Name = "waveformPlot2Button";
            this.waveformPlot2Button.Size = new System.Drawing.Size(112, 32);
            this.waveformPlot2Button.TabIndex = 3;
            this.waveformPlot2Button.Text = "Plot 2";
            this.toolTip.SetToolTip(this.waveformPlot2Button, "Plot 50 points in Plot 2");
            this.waveformPlot2Button.Click += new System.EventHandler(this.OnPlot2ButtonClick);
            // 
            // waveformPlot1Button
            // 
            this.waveformPlot1Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.waveformPlot1Button.Location = new System.Drawing.Point(16, 24);
            this.waveformPlot1Button.Name = "waveformPlot1Button";
            this.waveformPlot1Button.Size = new System.Drawing.Size(112, 32);
            this.waveformPlot1Button.TabIndex = 2;
            this.waveformPlot1Button.Text = "Plot 1";
            this.toolTip.SetToolTip(this.waveformPlot1Button, "Plot 50 points in Plot 1");
            this.waveformPlot1Button.Click += new System.EventHandler(this.OnPlot1ButtonClick);
            // 
            // appendGroupBox
            // 
            this.appendGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.appendGroupBox.Controls.Add(this.appendPlot1Button);
            this.appendGroupBox.Controls.Add(this.appendPlot2Button);
            this.appendGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.appendGroupBox.Location = new System.Drawing.Point(392, 136);
            this.appendGroupBox.Name = "appendGroupBox";
            this.appendGroupBox.Size = new System.Drawing.Size(144, 120);
            this.appendGroupBox.TabIndex = 4;
            this.appendGroupBox.TabStop = false;
            this.appendGroupBox.Text = "Append (Chart)";
            // 
            // appendPlot1Button
            // 
            this.appendPlot1Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.appendPlot1Button.Location = new System.Drawing.Point(16, 24);
            this.appendPlot1Button.Name = "appendPlot1Button";
            this.appendPlot1Button.Size = new System.Drawing.Size(112, 32);
            this.appendPlot1Button.TabIndex = 5;
            this.appendPlot1Button.Text = "Plot 1";
            this.toolTip.SetToolTip(this.appendPlot1Button, "Append 50 points to Plot 1");
            this.appendPlot1Button.Click += new System.EventHandler(this.OnAppendPlot1ButtonClick);
            // 
            // appendPlot2Button
            // 
            this.appendPlot2Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.appendPlot2Button.Location = new System.Drawing.Point(16, 72);
            this.appendPlot2Button.Name = "appendPlot2Button";
            this.appendPlot2Button.Size = new System.Drawing.Size(112, 32);
            this.appendPlot2Button.TabIndex = 6;
            this.appendPlot2Button.Text = "Plot 2";
            this.toolTip.SetToolTip(this.appendPlot2Button, "Append 50 points to Plot 2");
            this.appendPlot2Button.Click += new System.EventHandler(this.OnAppendPlot2ButtonClick);
            // 
            // clearDataButton
            // 
            this.clearDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearDataButton.Location = new System.Drawing.Point(408, 280);
            this.clearDataButton.Name = "clearDataButton";
            this.clearDataButton.Size = new System.Drawing.Size(112, 32);
            this.clearDataButton.TabIndex = 7;
            this.clearDataButton.Text = "Clear Data";
            this.toolTip.SetToolTip(this.clearDataButton, "Clear data from both plots");
            this.clearDataButton.Click += new System.EventHandler(this.OnClearDataButtonClick);
            // 
            // historyCapacityLabel
            // 
            this.historyCapacityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyCapacityLabel.Location = new System.Drawing.Point(392, 336);
            this.historyCapacityLabel.Name = "historyCapacityLabel";
            this.historyCapacityLabel.Size = new System.Drawing.Size(104, 16);
            this.historyCapacityLabel.TabIndex = 8;
            this.historyCapacityLabel.Text = "History Capacity:";
            this.toolTip.SetToolTip(this.historyCapacityLabel, "The number of data points stored in each plot");
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Caption = "2D Waveform Graph";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(24, 16);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1,
            this.waveformPlot2});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(344, 312);
            this.sampleWaveformGraph.TabIndex = 10;
            this.toolTip.SetToolTip(this.sampleWaveformGraph, "National Instruments Waveform Graph");
            this.sampleWaveformGraph.UseColorGenerator = true;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis;
            this.waveformPlot1.YAxis = this.yAxis;
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.XAxis = this.xAxis;
            this.waveformPlot2.YAxis = this.yAxis;
            // 
            // graphLegend
            // 
            this.graphLegend.HorizontalScrollMode = NationalInstruments.UI.ScrollMode.Auto;
            this.graphLegend.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
            this.plot1LegendItem,
            this.plot2LegendItem});
            this.graphLegend.Location = new System.Drawing.Point(213, 328);
            this.graphLegend.Name = "graphLegend";
            this.graphLegend.Size = new System.Drawing.Size(155, 56);
            this.graphLegend.TabIndex = 11;
            this.toolTip.SetToolTip(this.graphLegend, "National Instruments Legend");
            // 
            // plot1LegendItem
            // 
            this.plot1LegendItem.Source = this.waveformPlot1;
            this.plot1LegendItem.Text = "Plot 1";
            // 
            // plot2LegendItem
            // 
            this.plot2LegendItem.Source = this.waveformPlot2;
            this.plot2LegendItem.Text = "Plot 2";
            // 
            // historyCapacityNumericEdit
            // 
            this.historyCapacityNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.historyCapacityNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.historyCapacityNumericEdit.Location = new System.Drawing.Point(392, 352);
            this.historyCapacityNumericEdit.Name = "historyCapacityNumericEdit";
            this.historyCapacityNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.historyCapacityNumericEdit.Range = new NationalInstruments.UI.Range(1, 10000);
            this.historyCapacityNumericEdit.Size = new System.Drawing.Size(144, 20);
            this.historyCapacityNumericEdit.TabIndex = 9;
            this.toolTip.SetToolTip(this.historyCapacityNumericEdit, "The number of data points stored in each plot");
            this.historyCapacityNumericEdit.Value = 1000;
            this.historyCapacityNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnHistoryCapacityChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(544, 392);
            this.Controls.Add(this.historyCapacityNumericEdit);
            this.Controls.Add(this.graphLegend);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.historyCapacityLabel);
            this.Controls.Add(this.clearDataButton);
            this.Controls.Add(this.appendGroupBox);
            this.Controls.Add(this.plotGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 384);
            this.Name = "MainForm";
            this.Text = "Plots Vs Charts Example";
            this.plotGroupBox.ResumeLayout(false);
            this.appendGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyCapacityNumericEdit)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        private void OnPlot1ButtonClick(object sender, System.EventArgs e)
        {
            xAxis.Mode = AxisMode.Fixed;
            xAxis.Range = new Range(0, Points+1);
            waveformPlot1.PlotY(GenerateData(Points, 5, 10));	        
        }

        private void OnPlot2ButtonClick(object sender, System.EventArgs e)
        {
            xAxis.Mode = AxisMode.Fixed;
            xAxis.Range = new Range(0, Points+1);
            waveformPlot2.PlotY(GenerateData(Points, 0, 5));        
        }

        private void OnAppendPlot1ButtonClick(object sender, System.EventArgs e)
        {
            xAxis.Mode = AxisMode.StripChart;			
            waveformPlot1.PlotYAppend(GenerateData(Points, 5, 10));        
        }

        private void OnAppendPlot2ButtonClick(object sender, System.EventArgs e)
        {
            xAxis.Mode = AxisMode.StripChart;
            waveformPlot2.PlotYAppend(GenerateData(Points, 0, 5));        
        }

        private void OnClearDataButtonClick(object sender, System.EventArgs e)
        {             
			waveformPlot1.ClearData();
			waveformPlot2.ClearData();
			xAxis.Mode = AxisMode.Fixed;
			xAxis.Range = new Range(0, Points+1);
        }

        private void OnHistoryCapacityChanged(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            waveformPlot1.HistoryCapacity = System.Convert.ToInt32(historyCapacityNumericEdit.Value);
            waveformPlot2.HistoryCapacity = System.Convert.ToInt32(historyCapacityNumericEdit.Value);        
        }

        private double[] GenerateData(int count, int minValue, int maxValue)
        {
            double[] data = new double[count];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = rnd.Next(minValue, maxValue);
            }
            return data;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm ());
        }
	}
}
