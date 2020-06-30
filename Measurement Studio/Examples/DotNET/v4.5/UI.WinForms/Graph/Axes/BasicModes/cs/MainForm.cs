using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.BasicModes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private const int DefaultDataLength = 100;
		private System.Windows.Forms.RadioButton autoscaleXRadioButton;
		private System.Windows.Forms.RadioButton autoscaleYRadioButton;
		private System.Windows.Forms.RadioButton manualXRadioButton;
		private System.Windows.Forms.RadioButton manualYRadioButton;
		private System.Windows.Forms.GroupBox xAxisGroupBox;
		private System.Windows.Forms.GroupBox yAxisGroupBox;
		private System.Windows.Forms.Label minXLabel;
		private System.Windows.Forms.Label minYLabel;
		private System.Windows.Forms.Label maxXLabel;
		private System.Windows.Forms.Label maxYLabel;
		private System.Windows.Forms.Button plotDataButton;		
		private System.Windows.Forms.ToolTip toolTip;
		private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
		private NationalInstruments.UI.XAxis xAxis;
		private NationalInstruments.UI.YAxis yAxis;
		private NationalInstruments.UI.WaveformPlot waveformPlot;
        private NationalInstruments.UI.WindowsForms.NumericEdit minXNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit maxXNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit minYNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit maxYNumericEdit;
		private System.ComponentModel.IContainer components;
		
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.autoscaleXRadioButton = new System.Windows.Forms.RadioButton();
            this.manualXRadioButton = new System.Windows.Forms.RadioButton();
            this.autoscaleYRadioButton = new System.Windows.Forms.RadioButton();
            this.manualYRadioButton = new System.Windows.Forms.RadioButton();
            this.xAxisGroupBox = new System.Windows.Forms.GroupBox();
            this.maxXLabel = new System.Windows.Forms.Label();
            this.minXLabel = new System.Windows.Forms.Label();
            this.minXNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.maxXNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.yAxisGroupBox = new System.Windows.Forms.GroupBox();
            this.maxYLabel = new System.Windows.Forms.Label();
            this.minYLabel = new System.Windows.Forms.Label();
            this.maxYNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.minYNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.plotDataButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.xAxisGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minXNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxXNumericEdit)).BeginInit();
            this.yAxisGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxYNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // autoscaleXRadioButton
            // 
            this.autoscaleXRadioButton.Checked = true;
            this.autoscaleXRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoscaleXRadioButton.Location = new System.Drawing.Point(24, 24);
            this.autoscaleXRadioButton.Name = "autoscaleXRadioButton";
            this.autoscaleXRadioButton.Size = new System.Drawing.Size(104, 16);
            this.autoscaleXRadioButton.TabIndex = 0;
            this.autoscaleXRadioButton.TabStop = true;
            this.autoscaleXRadioButton.Text = "AutoScale";
            this.toolTip.SetToolTip(this.autoscaleXRadioButton, "\"Autoscales the X Axis\"");
            this.autoscaleXRadioButton.Click += new System.EventHandler(this.OnXAxisScaleChanged);
            this.autoscaleXRadioButton.CheckedChanged += new System.EventHandler(this.autoscaleXRadioButton_CheckedChanged);
            // 
            // manualXRadioButton
            // 
            this.manualXRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.manualXRadioButton.Location = new System.Drawing.Point(24, 56);
            this.manualXRadioButton.Name = "manualXRadioButton";
            this.manualXRadioButton.Size = new System.Drawing.Size(96, 16);
            this.manualXRadioButton.TabIndex = 1;
            this.manualXRadioButton.Text = "Manual";
            this.toolTip.SetToolTip(this.manualXRadioButton, "\"Manually scale the X Axis\"");
            this.manualXRadioButton.Click += new System.EventHandler(this.OnXAxisScaleChanged);
            this.manualXRadioButton.CheckedChanged += new System.EventHandler(this.manualXRadioButton_CheckedChanged);
            // 
            // autoscaleYRadioButton
            // 
            this.autoscaleYRadioButton.Checked = true;
            this.autoscaleYRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.autoscaleYRadioButton.Location = new System.Drawing.Point(24, 24);
            this.autoscaleYRadioButton.Name = "autoscaleYRadioButton";
            this.autoscaleYRadioButton.Size = new System.Drawing.Size(96, 16);
            this.autoscaleYRadioButton.TabIndex = 0;
            this.autoscaleYRadioButton.TabStop = true;
            this.autoscaleYRadioButton.Text = "AutoScale";
            this.toolTip.SetToolTip(this.autoscaleYRadioButton, "\"Autoscale the Y Axis\"");
            this.autoscaleYRadioButton.Click += new System.EventHandler(this.OnYAxisScaleChanged);
            this.autoscaleYRadioButton.CheckedChanged += new System.EventHandler(this.autoscaleYRadioButton_CheckedChanged);
            // 
            // manualYRadioButton
            // 
            this.manualYRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.manualYRadioButton.Location = new System.Drawing.Point(24, 56);
            this.manualYRadioButton.Name = "manualYRadioButton";
            this.manualYRadioButton.Size = new System.Drawing.Size(104, 16);
            this.manualYRadioButton.TabIndex = 1;
            this.manualYRadioButton.Text = "Manual";
            this.toolTip.SetToolTip(this.manualYRadioButton, "\"Manually scale the Y Axis\"");
            this.manualYRadioButton.Click += new System.EventHandler(this.OnYAxisScaleChanged);
            this.manualYRadioButton.CheckedChanged += new System.EventHandler(this.manualYRadioButton_CheckedChanged);
            // 
            // xAxisGroupBox
            // 
            this.xAxisGroupBox.Controls.Add(this.maxXLabel);
            this.xAxisGroupBox.Controls.Add(this.minXLabel);
            this.xAxisGroupBox.Controls.Add(this.manualXRadioButton);
            this.xAxisGroupBox.Controls.Add(this.autoscaleXRadioButton);
            this.xAxisGroupBox.Controls.Add(this.minXNumericEdit);
            this.xAxisGroupBox.Controls.Add(this.maxXNumericEdit);
            this.xAxisGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.xAxisGroupBox.Location = new System.Drawing.Point(34, 304);
            this.xAxisGroupBox.Name = "xAxisGroupBox";
            this.xAxisGroupBox.Size = new System.Drawing.Size(284, 88);
            this.xAxisGroupBox.TabIndex = 6;
            this.xAxisGroupBox.TabStop = false;
            this.xAxisGroupBox.Text = "XAxis";
            // 
            // maxXLabel
            // 
            this.maxXLabel.Location = new System.Drawing.Point(136, 56);
            this.maxXLabel.Name = "maxXLabel";
            this.maxXLabel.Size = new System.Drawing.Size(64, 16);
            this.maxXLabel.TabIndex = 7;
            this.maxXLabel.Text = "Maximum:";
            this.toolTip.SetToolTip(this.maxXLabel, "\"Maximum value for the X axis when manually scaled\"");
            // 
            // minXLabel
            // 
            this.minXLabel.Location = new System.Drawing.Point(136, 24);
            this.minXLabel.Name = "minXLabel";
            this.minXLabel.Size = new System.Drawing.Size(64, 16);
            this.minXLabel.TabIndex = 6;
            this.minXLabel.Text = "Minimum:";
            this.toolTip.SetToolTip(this.minXLabel, "\"Minimum value for the X axis when manually scaled\"");
            // 
            // minXNumericEdit
            // 
            this.minXNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.minXNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.minXNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.minXNumericEdit.Location = new System.Drawing.Point(200, 24);
            this.minXNumericEdit.Name = "minXNumericEdit";
            this.minXNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.minXNumericEdit.Range = new NationalInstruments.UI.Range(-10, 50);
            this.minXNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.minXNumericEdit.TabIndex = 2;
            this.minXNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnXAxisRangeChanged);
            this.minXNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.minXNumUpDown_BeforeChangeValue);
            // 
            // maxXNumericEdit
            // 
            this.maxXNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.maxXNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.maxXNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.maxXNumericEdit.Location = new System.Drawing.Point(200, 56);
            this.maxXNumericEdit.Name = "maxXNumericEdit";
            this.maxXNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.maxXNumericEdit.Range = new NationalInstruments.UI.Range(10, 200);
            this.maxXNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.maxXNumericEdit.TabIndex = 3;
            this.maxXNumericEdit.Value = 100;
            this.maxXNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnXAxisRangeChanged);
            this.maxXNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.maxXNumUpDown_BeforeChangeValue);
            // 
            // yAxisGroupBox
            // 
            this.yAxisGroupBox.Controls.Add(this.maxYLabel);
            this.yAxisGroupBox.Controls.Add(this.minYLabel);
            this.yAxisGroupBox.Controls.Add(this.autoscaleYRadioButton);
            this.yAxisGroupBox.Controls.Add(this.manualYRadioButton);
            this.yAxisGroupBox.Controls.Add(this.maxYNumericEdit);
            this.yAxisGroupBox.Controls.Add(this.minYNumericEdit);
            this.yAxisGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.yAxisGroupBox.Location = new System.Drawing.Point(34, 416);
            this.yAxisGroupBox.Name = "yAxisGroupBox";
            this.yAxisGroupBox.Size = new System.Drawing.Size(284, 88);
            this.yAxisGroupBox.TabIndex = 7;
            this.yAxisGroupBox.TabStop = false;
            this.yAxisGroupBox.Text = "YAxis";
            // 
            // maxYLabel
            // 
            this.maxYLabel.Location = new System.Drawing.Point(136, 56);
            this.maxYLabel.Name = "maxYLabel";
            this.maxYLabel.Size = new System.Drawing.Size(64, 16);
            this.maxYLabel.TabIndex = 9;
            this.maxYLabel.Text = "Maximum:";
            this.toolTip.SetToolTip(this.maxYLabel, "\"Maximum value for the Y axis when manually scaled\"");
            // 
            // minYLabel
            // 
            this.minYLabel.Location = new System.Drawing.Point(136, 24);
            this.minYLabel.Name = "minYLabel";
            this.minYLabel.Size = new System.Drawing.Size(64, 16);
            this.minYLabel.TabIndex = 8;
            this.minYLabel.Text = "Minimum:";
            this.toolTip.SetToolTip(this.minYLabel, "\"Minimum value for the Y axis when manually scaled\"");
            // 
            // maxYNumericEdit
            // 
            this.maxYNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.maxYNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.maxYNumericEdit.Location = new System.Drawing.Point(200, 56);
            this.maxYNumericEdit.Name = "maxYNumericEdit";
            this.maxYNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.maxYNumericEdit.Range = new NationalInstruments.UI.Range(1, 100);
            this.maxYNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.maxYNumericEdit.TabIndex = 3;
            this.maxYNumericEdit.Value = 10;
            this.maxYNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnYAxisRangeChanged);
            this.maxYNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.maxYNumUpDown_BeforeChangeValue);
            // 
            // minYNumericEdit
            // 
            this.minYNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.minYNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.minYNumericEdit.Location = new System.Drawing.Point(200, 24);
            this.minYNumericEdit.Name = "minYNumericEdit";
            this.minYNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.minYNumericEdit.Range = new NationalInstruments.UI.Range(-10, 50);
            this.minYNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.minYNumericEdit.TabIndex = 2;
            this.minYNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnYAxisRangeChanged);
            this.minYNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.minYNumUpDown_BeforeChangeValue);
            // 
            // plotDataButton
            // 
            this.plotDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotDataButton.Location = new System.Drawing.Point(120, 256);
            this.plotDataButton.Name = "plotDataButton";
            this.plotDataButton.Size = new System.Drawing.Size(112, 32);
            this.plotDataButton.TabIndex = 1;
            this.plotDataButton.Text = "Plot Data";
            this.toolTip.SetToolTip(this.plotDataButton, "\"Plot One Hundred Points of Data\"");
            this.plotDataButton.Click += new System.EventHandler(this.plotDataButton_Click_1);
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Caption = "National Instruments 2D Graph";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(16, 8);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(320, 232);
            this.sampleWaveformGraph.TabIndex = 0;
            this.toolTip.SetToolTip(this.sampleWaveformGraph, "\"National Instruments 2D Graph\"");
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // waveformPlot
            // 
            this.waveformPlot.XAxis = this.xAxis;
            this.waveformPlot.YAxis = this.yAxis;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(352, 518);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.plotDataButton);
            this.Controls.Add(this.yAxisGroupBox);
            this.Controls.Add(this.xAxisGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axes Example";
            this.xAxisGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minXNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxXNumericEdit)).EndInit();
            this.yAxisGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maxYNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minYNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
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
		

		private void plotDataButton_Click_1(object sender, System.EventArgs e)
		{
			sampleWaveformGraph.PlotY(GenerateData());
		}	
	
		private static double[] GenerateData()
		{
			return GenerateData(DefaultDataLength);
		}

		private static double[] GenerateData(int dataLength)
		{
			if (dataLength < 0)
			{
				throw new ArgumentOutOfRangeException("dataLength", dataLength, "Data length must be positive.");
			}

			double[] data = new double[dataLength];
			Random rnd = new Random();

			for (int i = 0; i < dataLength; ++i)
			{
				data[i] = (rnd.NextDouble() * Math.Sin(i / 3.15));
			}

			return data;
		}

		private void SetYAxisScale()
		{
			if (autoscaleYRadioButton.Checked)
			{	
				yAxis.Mode = AxisMode.AutoScaleLoose;
			}
			else if (manualYRadioButton.Checked)
			{
				yAxis.Mode = AxisMode.Fixed;
				SetYAxisRange();
			}
		}

		private void SetYAxisRange()
		{
			yAxis.Range = new Range((double) minYNumericEdit.Value, (double) maxYNumericEdit.Value);
		}

		private void SetXAxisScale()
		{
			if (autoscaleXRadioButton.Checked)
			{
				xAxis.Mode = AxisMode.AutoScaleLoose;
			}
			else if (manualXRadioButton.Checked)
			{
				xAxis.Mode = AxisMode.Fixed;
				SetXAxisRange();
			}
		}

		private void SetXAxisRange()
		{
			xAxis.Range = new Range((double) minXNumericEdit.Value, (double) maxXNumericEdit.Value);
		}

		private void OnYAxisScaleChanged(object sender, System.EventArgs e)
		{
			SetYAxisScale();
		}

        private void OnYAxisRangeChanged(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (manualYRadioButton.Checked)
            {
                SetYAxisRange();
            }
        }		

        private void OnXAxisScaleChanged(object sender, System.EventArgs e)
		{
			SetXAxisScale();
		}

        private void OnXAxisRangeChanged(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (manualXRadioButton.Checked)
            {
                SetXAxisRange();
            }
        }

        private void minXNumUpDown_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            if (manualXRadioButton.Checked)
            {
                SetXAxisRange();
            }
        }

        private void minXNumUpDown_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            if(e.NewValue >= maxXNumericEdit.Value)
            {
                e.Cancel = true;
            }
        }

        private void maxXNumUpDown_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            if(e.NewValue <= minXNumericEdit.Value)
            {
                e.Cancel = true;
            }
        }

        private void minYNumUpDown_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            if(e.NewValue >= maxYNumericEdit.Value)
            {
                e.Cancel = true;
            }
        }

        private void maxYNumUpDown_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            if(e.NewValue <= minYNumericEdit.Value)
            {
                e.Cancel = true;
            }
        }

        private void autoscaleXRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator;
            maxXNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator;
        }

        private void manualXRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys | NumericEditInteractionModes.Buttons | NumericEditInteractionModes.Text;
            maxXNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys | NumericEditInteractionModes.Buttons | NumericEditInteractionModes.Text;
        }

        private void autoscaleYRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minYNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator;
            maxYNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator;
        }

        private void manualYRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minYNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys | NumericEditInteractionModes.Buttons | NumericEditInteractionModes.Text;
            maxYNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys | NumericEditInteractionModes.Buttons | NumericEditInteractionModes.Text;
        }

    }
}
