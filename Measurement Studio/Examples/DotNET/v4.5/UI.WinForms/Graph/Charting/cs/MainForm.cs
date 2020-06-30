using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Charting
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private DataManager dataManager;
		private System.Windows.Forms.GroupBox settingsGroupBox;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.RadioButton optionStripChartRadioButton;
		private System.Windows.Forms.RadioButton optionScopeChartRadioButton;
		private System.Windows.Forms.CheckBox optionVerticalCheckBox;
		private System.Windows.Forms.ToolTip toolTip;
		private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
		private NationalInstruments.UI.WaveformPlot waveformPlot;
		private NationalInstruments.UI.XAxis xAxis;
		private NationalInstruments.UI.YAxis yAxis;
		private System.ComponentModel.IContainer components;
	
		private enum ChartingModes
		{
			Strip,
			Scope
		}

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			dataManager = new DataManager();
			SetAxisModes();
		}

		private class DataManager
		{
			private const int NumberOfPoints = 100;
			private const int YRange = 10;

			private double[] data;
			private int index;
			private double currentX;
			private bool vertical;

			public DataManager()
			{
				data = GenerateSineWave(NumberOfPoints, YRange);
				Reset();
			}

			public bool IsVertical
			{
				get
				{
					return vertical;
				}
				set
				{
					vertical = value;
					Reset();
				}
			}

			public void Reset()
			{
				index = -1;
				currentX = 0;
			}

			public void GetNextPoint(out double x, out double y)
			{
				++index;
				if (index == NumberOfPoints)
				{
					index = 1;
				}

				if (!vertical)
				{
					x = currentX;
					y = data[index];
				}
				else
				{
					x = data[index];
					y = currentX;
				}

				++currentX;
			}

			private static double[] GenerateSineWave(int xRange, int yRange)
			{
				if (xRange < 0)
				{
					throw new ArgumentOutOfRangeException("xRange");
				}

				if (yRange < 0)
				{
					throw new ArgumentOutOfRangeException("yRange");
				}

				double[] data = new double[xRange];
				for (int i = 0; i < xRange; ++i)
				{
					data[i] = yRange / 2 * (1 - (float)Math.Sin(i * 2 * Math.PI / (xRange - 1)));
				}

				return data;
			}
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
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.optionScopeChartRadioButton = new System.Windows.Forms.RadioButton();
            this.optionStripChartRadioButton = new System.Windows.Forms.RadioButton();
            this.optionVerticalCheckBox = new System.Windows.Forms.CheckBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.optionScopeChartRadioButton);
            this.settingsGroupBox.Controls.Add(this.optionStripChartRadioButton);
            this.settingsGroupBox.Controls.Add(this.optionVerticalCheckBox);
            this.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsGroupBox.Location = new System.Drawing.Point(16, 280);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(304, 128);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Chart Settings";
            // 
            // optionScopeChartRadioButton
            // 
            this.optionScopeChartRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionScopeChartRadioButton.Location = new System.Drawing.Point(24, 88);
            this.optionScopeChartRadioButton.Name = "optionScopeChartRadioButton";
            this.optionScopeChartRadioButton.Size = new System.Drawing.Size(112, 24);
            this.optionScopeChartRadioButton.TabIndex = 2;
            this.optionScopeChartRadioButton.Text = "Scope Chart";
            this.optionScopeChartRadioButton.CheckedChanged += new System.EventHandler(this.OnChartingModeChanged);
            // 
            // optionStripChartRadioButton
            // 
            this.optionStripChartRadioButton.Checked = true;
            this.optionStripChartRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionStripChartRadioButton.Location = new System.Drawing.Point(24, 32);
            this.optionStripChartRadioButton.Name = "optionStripChartRadioButton";
            this.optionStripChartRadioButton.Size = new System.Drawing.Size(112, 32);
            this.optionStripChartRadioButton.TabIndex = 1;
            this.optionStripChartRadioButton.TabStop = true;
            this.optionStripChartRadioButton.Text = "Strip Chart";
            this.optionStripChartRadioButton.CheckedChanged += new System.EventHandler(this.OnChartingModeChanged);
            // 
            // optionVerticalCheckBox
            // 
            this.optionVerticalCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionVerticalCheckBox.Location = new System.Drawing.Point(176, 32);
            this.optionVerticalCheckBox.Name = "optionVerticalCheckBox";
            this.optionVerticalCheckBox.Size = new System.Drawing.Size(72, 24);
            this.optionVerticalCheckBox.TabIndex = 0;
            this.optionVerticalCheckBox.Text = "Vertical";
            this.toolTip.SetToolTip(this.optionVerticalCheckBox, "\"Chart vertically\"");
            this.optionVerticalCheckBox.CheckedChanged += new System.EventHandler(this.OnOptionVerticalCheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Caption = "2D Waveform Graph";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(16, 16);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(296, 248);
            this.sampleWaveformGraph.TabIndex = 2;
            this.toolTip.SetToolTip(this.sampleWaveformGraph, "\"National Instruments 2D WaveformGraph\"");
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
            this.ClientSize = new System.Drawing.Size(338, 424);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.settingsGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charting Example";
            this.settingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		private void OnTimerTick(object sender, System.EventArgs e)
		{
			double x, y;
			dataManager.GetNextPoint(out x, out y);
			if (optionVerticalCheckBox.Checked)
			{
				sampleWaveformGraph.PlotXAppend(x);
			}
			else 
			{
				sampleWaveformGraph.PlotYAppend(y);
			}			
		}

		private void OnChartingModeChanged(object sender, System.EventArgs e)
		{
			SetAxisModes();
		}

		private void OnOptionVerticalCheckedChanged(object sender, System.EventArgs e)
		{		
			sampleWaveformGraph.ClearData();
			dataManager.IsVertical = optionVerticalCheckBox.Checked;
			SetAxisModes();
		}

		private void SetAxisModes()
		{
			if (optionStripChartRadioButton.Checked)
			{
				SetAxisModes(ChartingModes.Strip);
			}
			else if (optionScopeChartRadioButton.Checked)
			{
				SetAxisModes(ChartingModes.Scope);
			}
		}

		private void SetAxisModes(ChartingModes mode)
		{	
			Axis chartingAxis, scaleAxis;
			if (!dataManager.IsVertical)
			{
				chartingAxis = xAxis;
				scaleAxis = yAxis;
			}
			else
			{
				chartingAxis = yAxis;
				scaleAxis = xAxis;
			}

			scaleAxis.Mode = AxisMode.AutoScaleLoose;
			if (mode == ChartingModes.Scope)
			{
				chartingAxis.Mode = AxisMode.ScopeChart;
			}
			else
			{
				chartingAxis.Mode = AxisMode.StripChart;
			}
		
			sampleWaveformGraph.ClearData();
			dataManager.Reset();
		}

	}
}
