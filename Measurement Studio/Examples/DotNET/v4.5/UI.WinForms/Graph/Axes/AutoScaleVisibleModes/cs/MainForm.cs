using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.AutoScaleVisibleModes
{
    public class MainForm : System.Windows.Forms.Form
    {
        private WaveformGraph autoScaleVisibleWaveformGraph;
        private WaveformPlot autoScaleVisibleWaveformPlot;
        private XAxis autoScaleVisibleXAxis;
        private YAxis autoScaleVisibleYAxis;
        private WaveformGraph autoScaleWaveformGraph;
        private WaveformPlot autoScaleWaveformPlot;
        private XAxis autoScaleXAxis;
        private YAxis autoScaleYAxis;
        private GroupBox plotControlGroupBox;
        private Button clearButton;
        private CheckBox pauseCheckBox;
        private Timer plotTimer;
        private GroupBox aboutGroupBox;
        private TextBox aboutTextBox;
        private System.ComponentModel.IContainer components;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            // Initialize about box text and increase font size.
            aboutGroupBox.Text = "About the \"" + Text + "\" Example";
            aboutTextBox.Font = new Font(Font.FontFamily, Font.Size + 2);

            // Begin plotting.
            pauseCheckBox.Checked = false;
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            this.autoScaleVisibleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.autoScaleVisibleWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.autoScaleVisibleXAxis = new NationalInstruments.UI.XAxis();
            this.autoScaleVisibleYAxis = new NationalInstruments.UI.YAxis();
            this.autoScaleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.autoScaleWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.autoScaleXAxis = new NationalInstruments.UI.XAxis();
            this.autoScaleYAxis = new NationalInstruments.UI.YAxis();
            this.plotControlGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.pauseCheckBox = new System.Windows.Forms.CheckBox();
            this.plotTimer = new System.Windows.Forms.Timer(this.components);
            this.aboutGroupBox = new System.Windows.Forms.GroupBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.autoScaleVisibleWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScaleWaveformGraph)).BeginInit();
            this.plotControlGroupBox.SuspendLayout();
            this.aboutGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoScaleVisibleWaveformGraph
            // 
            this.autoScaleVisibleWaveformGraph.Caption = "AutoScaleVisibleLoose Axis Mode";
            this.autoScaleVisibleWaveformGraph.InteractionMode = NationalInstruments.UI.GraphInteractionModes.PanX;
            this.autoScaleVisibleWaveformGraph.Location = new System.Drawing.Point(12, 12);
            this.autoScaleVisibleWaveformGraph.Name = "autoScaleVisibleWaveformGraph";
            this.autoScaleVisibleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.autoScaleVisibleWaveformPlot});
            this.autoScaleVisibleWaveformGraph.Size = new System.Drawing.Size(333, 227);
            this.autoScaleVisibleWaveformGraph.TabIndex = 0;
            this.autoScaleVisibleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.autoScaleVisibleXAxis});
            this.autoScaleVisibleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.autoScaleVisibleYAxis});
            // 
            // autoScaleVisibleWaveformPlot
            // 
            this.autoScaleVisibleWaveformPlot.XAxis = this.autoScaleVisibleXAxis;
            this.autoScaleVisibleWaveformPlot.YAxis = this.autoScaleVisibleYAxis;
            // 
            // autoScaleVisibleXAxis
            // 
            this.autoScaleVisibleXAxis.Caption = "StripChart axis";
            this.autoScaleVisibleXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.autoScaleVisibleXAxis.RangeChanged += new System.EventHandler(this.autoScaleVisibleXAxis_RangeChanged);
            // 
            // autoScaleVisibleYAxis
            // 
            this.autoScaleVisibleYAxis.Caption = "AutoScaleVisible axis";
            this.autoScaleVisibleYAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleVisibleLoose;
            this.autoScaleVisibleYAxis.Range = new NationalInstruments.UI.Range(-0.5, 0.5);
            // 
            // autoScaleWaveformGraph
            // 
            this.autoScaleWaveformGraph.Caption = "AutoScaleLoose Axis Mode";
            this.autoScaleWaveformGraph.InteractionMode = NationalInstruments.UI.GraphInteractionModes.PanX;
            this.autoScaleWaveformGraph.Location = new System.Drawing.Point(365, 12);
            this.autoScaleWaveformGraph.Name = "autoScaleWaveformGraph";
            this.autoScaleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.autoScaleWaveformPlot});
            this.autoScaleWaveformGraph.Size = new System.Drawing.Size(333, 227);
            this.autoScaleWaveformGraph.TabIndex = 1;
            this.autoScaleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.autoScaleXAxis});
            this.autoScaleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.autoScaleYAxis});
            // 
            // autoScaleWaveformPlot
            // 
            this.autoScaleWaveformPlot.XAxis = this.autoScaleXAxis;
            this.autoScaleWaveformPlot.YAxis = this.autoScaleYAxis;
            // 
            // autoScaleXAxis
            // 
            this.autoScaleXAxis.Caption = "StripChart axis";
            this.autoScaleXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.autoScaleXAxis.RangeChanged += new System.EventHandler(this.autoScaleXAxis_RangeChanged);
            // 
            // autoScaleYAxis
            // 
            this.autoScaleYAxis.Caption = "AutoScaleLoose axis";
            this.autoScaleYAxis.Range = new NationalInstruments.UI.Range(-0.5, 0.5);
            // 
            // plotControlGroupBox
            // 
            this.plotControlGroupBox.Controls.Add(this.clearButton);
            this.plotControlGroupBox.Controls.Add(this.pauseCheckBox);
            this.plotControlGroupBox.Location = new System.Drawing.Point(12, 263);
            this.plotControlGroupBox.Name = "plotControlGroupBox";
            this.plotControlGroupBox.Size = new System.Drawing.Size(686, 52);
            this.plotControlGroupBox.TabIndex = 3;
            this.plotControlGroupBox.TabStop = false;
            this.plotControlGroupBox.Text = "Control Data Plotting";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(407, 19);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // pauseCheckBox
            // 
            this.pauseCheckBox.AutoSize = true;
            this.pauseCheckBox.Checked = true;
            this.pauseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pauseCheckBox.Location = new System.Drawing.Point(227, 23);
            this.pauseCheckBox.Name = "pauseCheckBox";
            this.pauseCheckBox.Size = new System.Drawing.Size(93, 17);
            this.pauseCheckBox.TabIndex = 0;
            this.pauseCheckBox.Text = "&Pause plotting";
            this.pauseCheckBox.UseVisualStyleBackColor = true;
            this.pauseCheckBox.CheckedChanged += new System.EventHandler(this.pauseCheckBox_CheckedChanged);
            // 
            // plotTimer
            // 
            this.plotTimer.Interval = 300;
            this.plotTimer.Tick += new System.EventHandler(this.plotTimer_Tick);
            // 
            // aboutGroupBox
            // 
            this.aboutGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.aboutGroupBox.Controls.Add(this.aboutTextBox);
            this.aboutGroupBox.Location = new System.Drawing.Point(12, 334);
            this.aboutGroupBox.Name = "aboutGroupBox";
            this.aboutGroupBox.Padding = new System.Windows.Forms.Padding(8, 8, 3, 3);
            this.aboutGroupBox.Size = new System.Drawing.Size(686, 216);
            this.aboutGroupBox.TabIndex = 4;
            this.aboutGroupBox.TabStop = false;
            this.aboutGroupBox.Text = "About the \"AutoScale Axis Modes Comparison\" Example";
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutTextBox.Location = new System.Drawing.Point(8, 21);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.ReadOnly = true;
            this.aboutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.aboutTextBox.Size = new System.Drawing.Size(675, 192);
            this.aboutTextBox.TabIndex = 0;
            this.aboutTextBox.Text = resources.GetString("aboutTextBox.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(710, 562);
            this.Controls.Add(this.aboutGroupBox);
            this.Controls.Add(this.plotControlGroupBox);
            this.Controls.Add(this.autoScaleWaveformGraph);
            this.Controls.Add(this.autoScaleVisibleWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoScale AxisModes Comparison";
            ((System.ComponentModel.ISupportInitialize)(this.autoScaleVisibleWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoScaleWaveformGraph)).EndInit();
            this.plotControlGroupBox.ResumeLayout(false);
            this.plotControlGroupBox.PerformLayout();
            this.aboutGroupBox.ResumeLayout(false);
            this.aboutGroupBox.PerformLayout();
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


        private void pauseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            plotTimer.Enabled = !pauseCheckBox.Checked;

            // Enable graph interaction when paused.
            GraphDefaultInteractionMode interactionMode = (pauseCheckBox.Checked ? GraphDefaultInteractionMode.PanX : GraphDefaultInteractionMode.None);
            autoScaleVisibleWaveformGraph.InteractionModeDefault = interactionMode;
            autoScaleWaveformGraph.InteractionModeDefault = interactionMode;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            autoScaleVisibleWaveformPlot.ClearData();
            autoScaleWaveformPlot.ClearData();
        }


        // Pan both graphs simultaneously.
        private void autoScaleVisibleXAxis_RangeChanged(object sender, EventArgs e)
        {
            autoScaleXAxis.Range = autoScaleVisibleXAxis.Range;
        }

        private void autoScaleXAxis_RangeChanged(object sender, EventArgs e)
        {
            autoScaleVisibleXAxis.Range = autoScaleXAxis.Range;
        }


        // Plot random data on every timer tick.
        Random random = new Random();
        const int NoiseFrequency = 20;
        int counter = NoiseFrequency / 2;
        private void plotTimer_Tick(object sender, EventArgs e)
        {
            ++counter;
            double dataPoint = random.NextDouble() - 0.5;

            // Introduce extra noise every few points.
            if (counter % NoiseFrequency == 0)
                dataPoint *= NoiseFrequency * 2;

            autoScaleVisibleWaveformPlot.PlotYAppend(dataPoint);
            autoScaleWaveformPlot.PlotYAppend(dataPoint);
        }

    }
}
