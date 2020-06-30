using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Plotting
{
	public class MainForm : System.Windows.Forms.Form
	{
        private const int MaxValue = 10;

        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private NationalInstruments.UI.WindowsForms.Switch stackedSwitch;
        private System.Windows.Forms.Label stackedLabel;
        private System.Windows.Forms.Label unstackedLabel;
        private System.Windows.Forms.TrackBar numberOfPlotsTrackBar;
        private System.Windows.Forms.TrackBar pointsPerPlotTrackBar;
        private System.Windows.Forms.Label numberOfPlotsLabel;
        private System.Windows.Forms.Label pointsPerPlotLabel;
        private System.Windows.Forms.Timer plotTimer;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.WaveformPlot plot;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.ToolTip applicationToolTip;
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
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.plot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.stackedSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.stackedLabel = new System.Windows.Forms.Label();
            this.numberOfPlotsTrackBar = new System.Windows.Forms.TrackBar();
            this.pointsPerPlotTrackBar = new System.Windows.Forms.TrackBar();
            this.numberOfPlotsLabel = new System.Windows.Forms.Label();
            this.pointsPerPlotLabel = new System.Windows.Forms.Label();
            this.plotTimer = new System.Windows.Forms.Timer(this.components);
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.unstackedLabel = new System.Windows.Forms.Label();
            this.applicationToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackedSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlotsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsPerPlotTrackBar)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleWaveformGraph.Caption = "Waveform Graph";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.plot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(304, 264);
            this.sampleWaveformGraph.TabIndex = 0;
            this.applicationToolTip.SetToolTip(this.sampleWaveformGraph, "National Instruments Waveform Graph");
            this.sampleWaveformGraph.UseColorGenerator = true;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // plot
            // 
            this.plot.XAxis = this.xAxis;
            this.plot.YAxis = this.yAxis;
            // 
            // stackedSwitch
            // 
            this.stackedSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stackedSwitch.Location = new System.Drawing.Point(232, 40);
            this.stackedSwitch.Name = "stackedSwitch";
            this.stackedSwitch.Size = new System.Drawing.Size(64, 112);
            this.stackedSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.stackedSwitch.TabIndex = 7;
            this.applicationToolTip.SetToolTip(this.stackedSwitch, "Toggle between stacked and unstacked plots");
            this.stackedSwitch.Value = true;
            // 
            // stackedLabel
            // 
            this.stackedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.stackedLabel.Location = new System.Drawing.Point(224, 8);
            this.stackedLabel.Name = "stackedLabel";
            this.stackedLabel.Size = new System.Drawing.Size(72, 24);
            this.stackedLabel.TabIndex = 6;
            this.stackedLabel.Text = "Stack Plots";
            this.stackedLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // numberOfPlotsTrackBar
            // 
            this.numberOfPlotsTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.numberOfPlotsTrackBar.LargeChange = 1;
            this.numberOfPlotsTrackBar.Location = new System.Drawing.Point(8, 44);
            this.numberOfPlotsTrackBar.Minimum = 1;
            this.numberOfPlotsTrackBar.Name = "numberOfPlotsTrackBar";
            this.numberOfPlotsTrackBar.Size = new System.Drawing.Size(208, 45);
            this.numberOfPlotsTrackBar.TabIndex = 3;
            this.numberOfPlotsTrackBar.Value = 3;
            this.numberOfPlotsTrackBar.Scroll += new System.EventHandler(this.numberOfPlotsBar_Scroll);
            // 
            // pointsPerPlotTrackBar
            // 
            this.pointsPerPlotTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pointsPerPlotTrackBar.LargeChange = 15;
            this.pointsPerPlotTrackBar.Location = new System.Drawing.Point(8, 128);
            this.pointsPerPlotTrackBar.Maximum = 100;
            this.pointsPerPlotTrackBar.Minimum = 10;
            this.pointsPerPlotTrackBar.Name = "pointsPerPlotTrackBar";
            this.pointsPerPlotTrackBar.Size = new System.Drawing.Size(208, 45);
            this.pointsPerPlotTrackBar.TabIndex = 5;
            this.pointsPerPlotTrackBar.TickFrequency = 5;
            this.pointsPerPlotTrackBar.Value = 20;
            // 
            // numberOfPlotsLabel
            // 
            this.numberOfPlotsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.numberOfPlotsLabel.Location = new System.Drawing.Point(16, 20);
            this.numberOfPlotsLabel.Name = "numberOfPlotsLabel";
            this.numberOfPlotsLabel.Size = new System.Drawing.Size(104, 16);
            this.numberOfPlotsLabel.TabIndex = 2;
            this.numberOfPlotsLabel.Text = "Number of Plots:";
            this.numberOfPlotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pointsPerPlotLabel
            // 
            this.pointsPerPlotLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.pointsPerPlotLabel.Location = new System.Drawing.Point(16, 104);
            this.pointsPerPlotLabel.Name = "pointsPerPlotLabel";
            this.pointsPerPlotLabel.Size = new System.Drawing.Size(104, 16);
            this.pointsPerPlotLabel.TabIndex = 4;
            this.pointsPerPlotLabel.Text = "Points Per Plot:";
            this.pointsPerPlotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plotTimer
            // 
            this.plotTimer.Enabled = true;
            this.plotTimer.Interval = 200;
            this.plotTimer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.Controls.Add(this.stackedSwitch);
            this.settingsGroupBox.Controls.Add(this.unstackedLabel);
            this.settingsGroupBox.Controls.Add(this.numberOfPlotsLabel);
            this.settingsGroupBox.Controls.Add(this.numberOfPlotsTrackBar);
            this.settingsGroupBox.Controls.Add(this.pointsPerPlotLabel);
            this.settingsGroupBox.Controls.Add(this.pointsPerPlotTrackBar);
            this.settingsGroupBox.Controls.Add(this.stackedLabel);
            this.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsGroupBox.Location = new System.Drawing.Point(8, 280);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(304, 184);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Settings";
            // 
            // unstackedLabel
            // 
            this.unstackedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.unstackedLabel.Location = new System.Drawing.Point(224, 152);
            this.unstackedLabel.Name = "unstackedLabel";
            this.unstackedLabel.Size = new System.Drawing.Size(72, 24);
            this.unstackedLabel.TabIndex = 8;
            this.unstackedLabel.Text = "Overlay Plots";
            this.unstackedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(322, 472);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.sampleWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(328, 504);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plotting Example";
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackedSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlotsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsPerPlotTrackBar)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
		#endregion

        private void OnTimerTick(object sender, System.EventArgs e)
        {
            int numberOfPlots = Math.Max(numberOfPlotsTrackBar.Value, 1);
            int pointsPerPlot = Math.Max(pointsPerPlotTrackBar.Value, 1);

            double[,] data = new double[numberOfPlots, pointsPerPlot];
            Random rnd = new Random();

            for (int plotIndex = 0; plotIndex < numberOfPlots; ++plotIndex)
            {
                for (int pointIndex = 0; pointIndex < pointsPerPlot; ++pointIndex)
                {
                    double point = rnd.NextDouble() * MaxValue;
                    if (stackedSwitch.Value)
                    {
                        point = (point / numberOfPlots) + (MaxValue / numberOfPlots) * plotIndex;
                    }

                    data[plotIndex, pointIndex] = point;
                }
            }

            sampleWaveformGraph.PlotYMultiple(data);
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

		private void numberOfPlotsBar_Scroll(object sender, System.EventArgs e)
		{
			sampleWaveformGraph.ClearData();
		}
	}
}
