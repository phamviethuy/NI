namespace NationalInstruments.Examples.PlotComplexWaveform
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.plotWaveformGroupBox = new System.Windows.Forms.GroupBox();
            this.irregularIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.regularIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.noIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.scaledDataRadioButton = new System.Windows.Forms.RadioButton();
            this.rawDataRadioButton = new System.Windows.Forms.RadioButton();
            this.historyCapacityNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.historyCapacityLabel = new System.Windows.Forms.Label();
            this.plotScaleModeGroupBox = new System.Windows.Forms.GroupBox();
            this.plotDisplayModeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeRadioButton = new System.Windows.Forms.RadioButton();
            this.samplesRadioButton = new System.Windows.Forms.RadioButton();
            this.plotToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.dataToPlotGroupBox = new System.Windows.Forms.GroupBox();
            this.magnitudeRadioButton = new System.Windows.Forms.RadioButton();
            this.phaseRadioButton = new System.Windows.Forms.RadioButton();
            this.imaginaryRadioButton = new System.Windows.Forms.RadioButton();
            this.realRadioButton = new System.Windows.Forms.RadioButton();
            this.plotDataAppendTimer = new System.Windows.Forms.Timer(this.components);
            this.chartWaveformCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.plotWaveformGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyCapacityNumericEdit)).BeginInit();
            this.plotScaleModeGroupBox.SuspendLayout();
            this.plotDisplayModeGroupBox.SuspendLayout();
            this.dataToPlotGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // yAxis
            // 
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis.Range = new NationalInstruments.UI.Range(0, 2);
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Caption = "National Instruments 2D Waveform Graph with ComplexWaveform";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(13, 6);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(523, 389);
            this.sampleWaveformGraph.TabIndex = 14;
            this.plotToolTip.SetToolTip(this.sampleWaveformGraph, "ComplexWaveformPlot");
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // waveformPlot
            // 
            this.waveformPlot.DefaultTiming = NationalInstruments.WaveformTiming.CreateWithRegularInterval(System.TimeSpan.Parse("00:00:00.0010000"), new System.DateTime(2000, 1, 1, 0, 0, 0, 0));
            this.waveformPlot.DefaultWaveformPrecisionTiming = NationalInstruments.PrecisionWaveformTiming.CreateWithRegularInterval(new NationalInstruments.PrecisionTimeSpan(((long)(0)), ((ulong)(18446744073709551ul))), new NationalInstruments.PrecisionDateTime(((long)(63082281600)), ((ulong)(0))));
            this.waveformPlot.XAxis = this.xAxis;
            this.waveformPlot.YAxis = this.yAxis;
            // 
            // plotWaveformGroupBox
            // 
            this.plotWaveformGroupBox.Controls.Add(this.irregularIntervalRadioButton);
            this.plotWaveformGroupBox.Controls.Add(this.regularIntervalRadioButton);
            this.plotWaveformGroupBox.Controls.Add(this.noIntervalRadioButton);
            this.plotWaveformGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotWaveformGroupBox.Location = new System.Drawing.Point(553, 6);
            this.plotWaveformGroupBox.Name = "plotWaveformGroupBox";
            this.plotWaveformGroupBox.Size = new System.Drawing.Size(176, 91);
            this.plotWaveformGroupBox.TabIndex = 19;
            this.plotWaveformGroupBox.TabStop = false;
            this.plotWaveformGroupBox.Text = "Waveform Timing Interval";
            // 
            // irregularIntervalRadioButton
            // 
            this.irregularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.irregularIntervalRadioButton.Location = new System.Drawing.Point(5, 65);
            this.irregularIntervalRadioButton.Name = "irregularIntervalRadioButton";
            this.irregularIntervalRadioButton.Size = new System.Drawing.Size(107, 17);
            this.irregularIntervalRadioButton.TabIndex = 2;
            this.irregularIntervalRadioButton.TabStop = true;
            this.irregularIntervalRadioButton.Text = "Irregular Interval";
            this.plotToolTip.SetToolTip(this.irregularIntervalRadioButton, "The waveform to be plotted uses the specified DateTime array to retrieve the timi" +
                    "ng information.");
            this.irregularIntervalRadioButton.CheckedChanged += new System.EventHandler(this.irregularIntervalRadioButton_CheckedChanged);
            // 
            // regularIntervalRadioButton
            // 
            this.regularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.regularIntervalRadioButton.Location = new System.Drawing.Point(5, 42);
            this.regularIntervalRadioButton.Name = "regularIntervalRadioButton";
            this.regularIntervalRadioButton.Size = new System.Drawing.Size(107, 17);
            this.regularIntervalRadioButton.TabIndex = 1;
            this.regularIntervalRadioButton.TabStop = true;
            this.regularIntervalRadioButton.Text = "Regular Interval";
            this.plotToolTip.SetToolTip(this.regularIntervalRadioButton, "The waveform to be plotted uses a specified TimeSpan object for the sample interv" +
                    "al.\r\nThe DefaultTiming property of the plot is used to retrieve the start time.");
            this.regularIntervalRadioButton.CheckedChanged += new System.EventHandler(this.regularIntervalRadioButton_CheckedChanged);
            // 
            // noIntervalRadioButton
            // 
            this.noIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noIntervalRadioButton.Location = new System.Drawing.Point(5, 19);
            this.noIntervalRadioButton.Name = "noIntervalRadioButton";
            this.noIntervalRadioButton.Size = new System.Drawing.Size(77, 17);
            this.noIntervalRadioButton.TabIndex = 0;
            this.noIntervalRadioButton.TabStop = true;
            this.noIntervalRadioButton.Text = "No Interval";
            this.plotToolTip.SetToolTip(this.noIntervalRadioButton, "The waveform to be plotted uses a specified time stamp for the start time.\r\nThe D" +
                    "efaultTiming property of the plot is used to retrieve the sample interval.");
            this.noIntervalRadioButton.CheckedChanged += new System.EventHandler(this.noIntervalRadioButton_CheckedChanged);
            // 
            // scaledDataRadioButton
            // 
            this.scaledDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scaledDataRadioButton.Location = new System.Drawing.Point(8, 40);
            this.scaledDataRadioButton.Name = "scaledDataRadioButton";
            this.scaledDataRadioButton.Size = new System.Drawing.Size(104, 24);
            this.scaledDataRadioButton.TabIndex = 1;
            this.scaledDataRadioButton.Text = "Scaled Data";
            this.scaledDataRadioButton.CheckedChanged += new System.EventHandler(this.scaledDataRadioButton_CheckedChanged);
            // 
            // rawDataRadioButton
            // 
            this.rawDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rawDataRadioButton.Location = new System.Drawing.Point(8, 16);
            this.rawDataRadioButton.Name = "rawDataRadioButton";
            this.rawDataRadioButton.Size = new System.Drawing.Size(104, 24);
            this.rawDataRadioButton.TabIndex = 0;
            this.rawDataRadioButton.Text = "Raw Data";
            this.rawDataRadioButton.CheckedChanged += new System.EventHandler(this.rawDataRadioButton_CheckedChanged);
            // 
            // historyCapacityNumericEdit
            // 
            this.historyCapacityNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.historyCapacityNumericEdit.Location = new System.Drawing.Point(553, 375);
            this.historyCapacityNumericEdit.Name = "historyCapacityNumericEdit";
            this.historyCapacityNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.historyCapacityNumericEdit.Range = new NationalInstruments.UI.Range(1, 10000);
            this.historyCapacityNumericEdit.Size = new System.Drawing.Size(144, 20);
            this.historyCapacityNumericEdit.TabIndex = 18;
            this.historyCapacityNumericEdit.Value = 10000;
            this.historyCapacityNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.historyCapacityNumeric_AfterChangeValue);
            // 
            // historyCapacityLabel
            // 
            this.historyCapacityLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.historyCapacityLabel.Location = new System.Drawing.Point(550, 354);
            this.historyCapacityLabel.Name = "historyCapacityLabel";
            this.historyCapacityLabel.Size = new System.Drawing.Size(96, 16);
            this.historyCapacityLabel.TabIndex = 17;
            this.historyCapacityLabel.Text = "History Capacity:";
            // 
            // plotScaleModeGroupBox
            // 
            this.plotScaleModeGroupBox.Controls.Add(this.scaledDataRadioButton);
            this.plotScaleModeGroupBox.Controls.Add(this.rawDataRadioButton);
            this.plotScaleModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotScaleModeGroupBox.Location = new System.Drawing.Point(553, 174);
            this.plotScaleModeGroupBox.Name = "plotScaleModeGroupBox";
            this.plotScaleModeGroupBox.Size = new System.Drawing.Size(176, 72);
            this.plotScaleModeGroupBox.TabIndex = 16;
            this.plotScaleModeGroupBox.TabStop = false;
            this.plotScaleModeGroupBox.Text = "Plot Scale Mode";
            // 
            // plotDisplayModeGroupBox
            // 
            this.plotDisplayModeGroupBox.Controls.Add(this.timeRadioButton);
            this.plotDisplayModeGroupBox.Controls.Add(this.samplesRadioButton);
            this.plotDisplayModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotDisplayModeGroupBox.Location = new System.Drawing.Point(553, 103);
            this.plotDisplayModeGroupBox.Name = "plotDisplayModeGroupBox";
            this.plotDisplayModeGroupBox.Size = new System.Drawing.Size(176, 65);
            this.plotDisplayModeGroupBox.TabIndex = 15;
            this.plotDisplayModeGroupBox.TabStop = false;
            this.plotDisplayModeGroupBox.Text = "Plot Display Mode";
            // 
            // timeRadioButton
            // 
            this.timeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timeRadioButton.Location = new System.Drawing.Point(8, 40);
            this.timeRadioButton.Name = "timeRadioButton";
            this.timeRadioButton.Size = new System.Drawing.Size(104, 24);
            this.timeRadioButton.TabIndex = 1;
            this.timeRadioButton.Text = "Against Time";
            this.timeRadioButton.CheckedChanged += new System.EventHandler(this.timeRadioButton_CheckedChanged);
            // 
            // samplesRadioButton
            // 
            this.samplesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplesRadioButton.Location = new System.Drawing.Point(8, 16);
            this.samplesRadioButton.Name = "samplesRadioButton";
            this.samplesRadioButton.Size = new System.Drawing.Size(104, 24);
            this.samplesRadioButton.TabIndex = 0;
            this.samplesRadioButton.Text = "As Samples";
            this.samplesRadioButton.CheckedChanged += new System.EventHandler(this.samplesRadioButton_CheckedChanged);
            // 
            // dataToPlotGroupBox
            // 
            this.dataToPlotGroupBox.Controls.Add(this.magnitudeRadioButton);
            this.dataToPlotGroupBox.Controls.Add(this.phaseRadioButton);
            this.dataToPlotGroupBox.Controls.Add(this.imaginaryRadioButton);
            this.dataToPlotGroupBox.Controls.Add(this.realRadioButton);
            this.dataToPlotGroupBox.Location = new System.Drawing.Point(553, 252);
            this.dataToPlotGroupBox.Name = "dataToPlotGroupBox";
            this.dataToPlotGroupBox.Size = new System.Drawing.Size(176, 70);
            this.dataToPlotGroupBox.TabIndex = 21;
            this.dataToPlotGroupBox.TabStop = false;
            this.dataToPlotGroupBox.Text = "Data to Plot";
            // 
            // magnitudeRadioButton
            // 
            this.magnitudeRadioButton.AutoSize = true;
            this.magnitudeRadioButton.Location = new System.Drawing.Point(87, 42);
            this.magnitudeRadioButton.Name = "magnitudeRadioButton";
            this.magnitudeRadioButton.Size = new System.Drawing.Size(75, 17);
            this.magnitudeRadioButton.TabIndex = 3;
            this.magnitudeRadioButton.TabStop = true;
            this.magnitudeRadioButton.Text = "Magnitude";
            this.magnitudeRadioButton.UseVisualStyleBackColor = true;
            this.magnitudeRadioButton.CheckedChanged += new System.EventHandler(this.magnitudeRadioButton_CheckedChanged);
            // 
            // phaseRadioButton
            // 
            this.phaseRadioButton.AutoSize = true;
            this.phaseRadioButton.Location = new System.Drawing.Point(87, 19);
            this.phaseRadioButton.Name = "phaseRadioButton";
            this.phaseRadioButton.Size = new System.Drawing.Size(55, 17);
            this.phaseRadioButton.TabIndex = 2;
            this.phaseRadioButton.TabStop = true;
            this.phaseRadioButton.Text = "Phase";
            this.phaseRadioButton.UseVisualStyleBackColor = true;
            this.phaseRadioButton.CheckedChanged += new System.EventHandler(this.phaseRadioButton_CheckedChanged);
            // 
            // imaginaryRadioButton
            // 
            this.imaginaryRadioButton.AutoSize = true;
            this.imaginaryRadioButton.Location = new System.Drawing.Point(6, 42);
            this.imaginaryRadioButton.Name = "imaginaryRadioButton";
            this.imaginaryRadioButton.Size = new System.Drawing.Size(70, 17);
            this.imaginaryRadioButton.TabIndex = 1;
            this.imaginaryRadioButton.TabStop = true;
            this.imaginaryRadioButton.Text = "Imaginary";
            this.imaginaryRadioButton.UseVisualStyleBackColor = true;
            this.imaginaryRadioButton.CheckedChanged += new System.EventHandler(this.imaginaryRadioButton_CheckedChanged);
            // 
            // realRadioButton
            // 
            this.realRadioButton.AutoSize = true;
            this.realRadioButton.Location = new System.Drawing.Point(6, 19);
            this.realRadioButton.Name = "realRadioButton";
            this.realRadioButton.Size = new System.Drawing.Size(47, 17);
            this.realRadioButton.TabIndex = 0;
            this.realRadioButton.TabStop = true;
            this.realRadioButton.Text = "Real";
            this.realRadioButton.UseVisualStyleBackColor = true;
            this.realRadioButton.CheckedChanged += new System.EventHandler(this.realRadioButton_CheckedChanged);
            // 
            // plotDataAppendTimer
            // 
            this.plotDataAppendTimer.Interval = 2000;
            this.plotDataAppendTimer.Tick += new System.EventHandler(this.plotDataAppendTimer_Tick);
            // 
            // chartWaveformCheckBox
            // 
            this.chartWaveformCheckBox.AutoSize = true;
            this.chartWaveformCheckBox.Location = new System.Drawing.Point(553, 328);
            this.chartWaveformCheckBox.Name = "chartWaveformCheckBox";
            this.chartWaveformCheckBox.Size = new System.Drawing.Size(103, 17);
            this.chartWaveformCheckBox.TabIndex = 0;
            this.chartWaveformCheckBox.Text = "Chart Waveform";
            this.chartWaveformCheckBox.UseVisualStyleBackColor = true;
            this.chartWaveformCheckBox.CheckedChanged += new System.EventHandler(this.chartWaveformCheckBox_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 409);
            this.Controls.Add(this.chartWaveformCheckBox);
            this.Controls.Add(this.dataToPlotGroupBox);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.plotWaveformGroupBox);
            this.Controls.Add(this.historyCapacityNumericEdit);
            this.Controls.Add(this.historyCapacityLabel);
            this.Controls.Add(this.plotScaleModeGroupBox);
            this.Controls.Add(this.plotDisplayModeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Plot ComplexWaveform Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            this.plotWaveformGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historyCapacityNumericEdit)).EndInit();
            this.plotScaleModeGroupBox.ResumeLayout(false);
            this.plotDisplayModeGroupBox.ResumeLayout(false);
            this.dataToPlotGroupBox.ResumeLayout(false);
            this.dataToPlotGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot;
        private NationalInstruments.UI.XAxis xAxis;
        private System.Windows.Forms.GroupBox plotWaveformGroupBox;
        private System.Windows.Forms.RadioButton irregularIntervalRadioButton;
        private System.Windows.Forms.ToolTip plotToolTip;
        private System.Windows.Forms.RadioButton regularIntervalRadioButton;
        private System.Windows.Forms.RadioButton noIntervalRadioButton;
        private System.Windows.Forms.RadioButton scaledDataRadioButton;
        private System.Windows.Forms.RadioButton rawDataRadioButton;
        private NationalInstruments.UI.WindowsForms.NumericEdit historyCapacityNumericEdit;
        private System.Windows.Forms.Label historyCapacityLabel;
        private System.Windows.Forms.GroupBox plotScaleModeGroupBox;
        private System.Windows.Forms.GroupBox plotDisplayModeGroupBox;
        private System.Windows.Forms.RadioButton timeRadioButton;
        private System.Windows.Forms.RadioButton samplesRadioButton;
        private System.Windows.Forms.GroupBox dataToPlotGroupBox;
        private System.Windows.Forms.RadioButton magnitudeRadioButton;
        private System.Windows.Forms.RadioButton phaseRadioButton;
        private System.Windows.Forms.RadioButton imaginaryRadioButton;
        private System.Windows.Forms.RadioButton realRadioButton;
        private System.Windows.Forms.CheckBox chartWaveformCheckBox;
        private System.Windows.Forms.Timer plotDataAppendTimer;

    }
}

