using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.DataInspection
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Timer chartTimer;
		private NationalInstruments.UI.WindowsForms.WaveformGraph dataWaveformGraph;
		private NationalInstruments.UI.WaveformPlot waveformPlot;
		private NationalInstruments.UI.XAxis xAxis;
		private NationalInstruments.UI.YAxis yAxis;
		private System.Windows.Forms.Label stopLabel;
		private System.Windows.Forms.Label switchLabel;
		private NationalInstruments.UI.WindowsForms.Switch generateSwitch;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.CheckBox plotToolTipCheckBox;
        private System.Windows.Forms.Label toolTipDescriptionLabel;
        private System.Windows.Forms.GroupBox plotGroupBox;
        private System.Windows.Forms.GroupBox cursorGroupBox;
        private System.Windows.Forms.CheckBox showCursorLabelCheckBox;
        private System.Windows.Forms.Button addRemoveCursorButton;
        private Random rand;
        private XYCursor cursor;

		public MainForm()
		{
			InitializeComponent();
            rand = new Random();
            cursor = new XYCursor(waveformPlot);
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
            this.dataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.stopLabel = new System.Windows.Forms.Label();
            this.switchLabel = new System.Windows.Forms.Label();
            this.generateSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.plotToolTipCheckBox = new System.Windows.Forms.CheckBox();
            this.addRemoveCursorButton = new System.Windows.Forms.Button();
            this.showCursorLabelCheckBox = new System.Windows.Forms.CheckBox();
            this.toolTipDescriptionLabel = new System.Windows.Forms.Label();
            this.plotGroupBox = new System.Windows.Forms.GroupBox();
            this.cursorGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateSwitch)).BeginInit();
            this.plotGroupBox.SuspendLayout();
            this.cursorGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataWaveformGraph
            // 
            this.dataWaveformGraph.Caption = "National Instruments Waveform Graph";
            this.dataWaveformGraph.Location = new System.Drawing.Point(12, 12);
            this.dataWaveformGraph.Name = "dataWaveformGraph";
            this.dataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot});
            this.dataWaveformGraph.Size = new System.Drawing.Size(428, 196);
            this.dataWaveformGraph.TabIndex = 0;
            this.dataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.dataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // waveformPlot
            // 
            this.waveformPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle;
            this.waveformPlot.ToolTipsEnabled = true;
            this.waveformPlot.XAxis = this.xAxis;
            this.waveformPlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.xAxis.Range = new NationalInstruments.UI.Range(0, 20);
            // 
            // chartTimer
            // 
            this.chartTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopLabel
            // 
            this.stopLabel.AutoSize = true;
            this.stopLabel.Location = new System.Drawing.Point(32, 96);
            this.stopLabel.Name = "stopLabel";
            this.stopLabel.Size = new System.Drawing.Size(29, 13);
            this.stopLabel.TabIndex = 5;
            this.stopLabel.Text = "Stop";
            // 
            // switchLabel
            // 
            this.switchLabel.AutoSize = true;
            this.switchLabel.Location = new System.Drawing.Point(8, 16);
            this.switchLabel.Name = "switchLabel";
            this.switchLabel.Size = new System.Drawing.Size(86, 13);
            this.switchLabel.TabIndex = 4;
            this.switchLabel.Text = "Generate Values";
            // 
            // generateSwitch
            // 
            this.generateSwitch.Location = new System.Drawing.Point(16, 32);
            this.generateSwitch.Name = "generateSwitch";
            this.generateSwitch.Size = new System.Drawing.Size(60, 64);
            this.generateSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide3D;
            this.generateSwitch.TabIndex = 3;
            this.generateSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.switch1_StateChanged);
            // 
            // plotToolTipCheckBox
            // 
            this.plotToolTipCheckBox.Checked = true;
            this.plotToolTipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.plotToolTipCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotToolTipCheckBox.Location = new System.Drawing.Point(8, 16);
            this.plotToolTipCheckBox.Name = "plotToolTipCheckBox";
            this.plotToolTipCheckBox.Size = new System.Drawing.Size(128, 24);
            this.plotToolTipCheckBox.TabIndex = 6;
            this.plotToolTipCheckBox.Text = "Enable data tool tip";
            this.plotToolTipCheckBox.CheckedChanged += new System.EventHandler(this.plotToolTipCheckBox_CheckedChanged);
            // 
            // addRemoveCursorButton
            // 
            this.addRemoveCursorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addRemoveCursorButton.Location = new System.Drawing.Point(8, 72);
            this.addRemoveCursorButton.Name = "addRemoveCursorButton";
            this.addRemoveCursorButton.Size = new System.Drawing.Size(96, 23);
            this.addRemoveCursorButton.TabIndex = 7;
            this.addRemoveCursorButton.Text = "Add Cursor";
            this.addRemoveCursorButton.Click += new System.EventHandler(this.addRemoveCursor_Click);
            // 
            // showCursorLabelCheckBox
            // 
            this.showCursorLabelCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showCursorLabelCheckBox.Location = new System.Drawing.Point(8, 16);
            this.showCursorLabelCheckBox.Name = "showCursorLabelCheckBox";
            this.showCursorLabelCheckBox.Size = new System.Drawing.Size(120, 24);
            this.showCursorLabelCheckBox.TabIndex = 8;
            this.showCursorLabelCheckBox.Text = "Show cursor label";
            this.showCursorLabelCheckBox.CheckedChanged += new System.EventHandler(this.showCursorLabelCheckBox_CheckedChanged);
            // 
            // toolTipDescriptionLabel
            // 
            this.toolTipDescriptionLabel.Location = new System.Drawing.Point(8, 48);
            this.toolTipDescriptionLabel.Name = "toolTipDescriptionLabel";
            this.toolTipDescriptionLabel.Size = new System.Drawing.Size(136, 64);
            this.toolTipDescriptionLabel.TabIndex = 9;
            this.toolTipDescriptionLabel.Text = "Check enable data tool tip to display a tool tip for each point.  Hover mouse ove" +
                "r data point to see its value.";
            // 
            // plotGroupBox
            // 
            this.plotGroupBox.Controls.Add(this.plotToolTipCheckBox);
            this.plotGroupBox.Controls.Add(this.toolTipDescriptionLabel);
            this.plotGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotGroupBox.Location = new System.Drawing.Point(136, 224);
            this.plotGroupBox.Name = "plotGroupBox";
            this.plotGroupBox.Size = new System.Drawing.Size(152, 120);
            this.plotGroupBox.TabIndex = 10;
            this.plotGroupBox.TabStop = false;
            this.plotGroupBox.Text = "Plot";
            // 
            // cursorGroupBox
            // 
            this.cursorGroupBox.Controls.Add(this.showCursorLabelCheckBox);
            this.cursorGroupBox.Controls.Add(this.addRemoveCursorButton);
            this.cursorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cursorGroupBox.Location = new System.Drawing.Point(304, 224);
            this.cursorGroupBox.Name = "cursorGroupBox";
            this.cursorGroupBox.Size = new System.Drawing.Size(136, 120);
            this.cursorGroupBox.TabIndex = 11;
            this.cursorGroupBox.TabStop = false;
            this.cursorGroupBox.Text = "Cursor";
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.generateSwitch);
            this.dataGroupBox.Controls.Add(this.switchLabel);
            this.dataGroupBox.Controls.Add(this.stopLabel);
            this.dataGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dataGroupBox.Location = new System.Drawing.Point(8, 224);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(112, 120);
            this.dataGroupBox.TabIndex = 12;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(458, 351);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.cursorGroupBox);
            this.Controls.Add(this.plotGroupBox);
            this.Controls.Add(this.dataWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Data Inspection";
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generateSwitch)).EndInit();
            this.plotGroupBox.ResumeLayout(false);
            this.cursorGroupBox.ResumeLayout(false);
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
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

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            dataWaveformGraph.PlotYAppend(rand.NextDouble() * 10);   
        }

        private void switch1_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            chartTimer.Enabled = generateSwitch.Value;
        }

        private void addRemoveCursor_Click(object sender, System.EventArgs e)
        {
            if(dataWaveformGraph.Cursors.Count > 0) //remove
            {
                dataWaveformGraph.Cursors.Clear();
                addRemoveCursorButton.Text = "Add Cursor";
            }
            else //add cursor
            {   
                dataWaveformGraph.Cursors.Add(cursor);

                double xValue = (xAxis.Range.Maximum + xAxis.Range.Minimum) / 2;
                double yValue = (yAxis.Range.Maximum + yAxis.Range.Minimum) / 2;
                
                cursor.MoveCursor(xValue, yValue);
                addRemoveCursorButton.Text = "Remove Cursor";
            }
        }

        private void showCursorLabelCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            cursor.LabelVisible = showCursorLabelCheckBox.Checked;
        }

        private void plotToolTipCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            waveformPlot.ToolTipsEnabled = plotToolTipCheckBox.Checked;
        }
	}
}
