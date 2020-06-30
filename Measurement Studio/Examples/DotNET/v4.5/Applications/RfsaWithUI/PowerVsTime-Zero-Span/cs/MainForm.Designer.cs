namespace NationalInstruments.Examples.PowerVsTimeZeroSpan
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
            this.referenceLevelLabel = new System.Windows.Forms.Label();
            this.carrierFrequencyLabel = new System.Windows.Forms.Label();
            this.iqRateLabel = new System.Windows.Forms.Label();
            this.samplesPerBlockLabel = new System.Windows.Forms.Label();
            this.meanPowerLabel = new System.Windows.Forms.Label();
            this.meanPowerTextBox = new System.Windows.Forms.TextBox();
            this.resourceNameLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.rmsRadioButton = new System.Windows.Forms.RadioButton();
            this.peakRadioButton = new System.Windows.Forms.RadioButton();
            this.peakScalingGroupBox = new System.Windows.Forms.GroupBox();
            this.powerVsTimeWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.resourceNameComboBox = new System.Windows.Forms.ComboBox();
            this.samplesPerBlockNumeric = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.iqRateNumeric = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.referenceLevelNumeric = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.carrierFrequencyNumeric = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.peakScalingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerVsTimeWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesPerBlockNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqRateNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLevelNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierFrequencyNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // referenceLevelLabel
            // 
            this.referenceLevelLabel.AutoSize = true;
            this.referenceLevelLabel.Location = new System.Drawing.Point(14, 64);
            this.referenceLevelLabel.Name = "referenceLevelLabel";
            this.referenceLevelLabel.Size = new System.Drawing.Size(116, 13);
            this.referenceLevelLabel.TabIndex = 0;
            this.referenceLevelLabel.Text = "Reference Level (dBm)";
            // 
            // carrierFrequencyLabel
            // 
            this.carrierFrequencyLabel.AutoSize = true;
            this.carrierFrequencyLabel.Location = new System.Drawing.Point(14, 115);
            this.carrierFrequencyLabel.Name = "carrierFrequencyLabel";
            this.carrierFrequencyLabel.Size = new System.Drawing.Size(112, 13);
            this.carrierFrequencyLabel.TabIndex = 1;
            this.carrierFrequencyLabel.Text = "Carrier Frequency (Hz)";
            // 
            // iqRateLabel
            // 
            this.iqRateLabel.AutoSize = true;
            this.iqRateLabel.Location = new System.Drawing.Point(14, 166);
            this.iqRateLabel.Name = "iqRateLabel";
            this.iqRateLabel.Size = new System.Drawing.Size(70, 13);
            this.iqRateLabel.TabIndex = 2;
            this.iqRateLabel.Text = "IQ Rate (S/s)";
            // 
            // samplesPerBlockLabel
            // 
            this.samplesPerBlockLabel.AutoSize = true;
            this.samplesPerBlockLabel.Location = new System.Drawing.Point(14, 217);
            this.samplesPerBlockLabel.Name = "samplesPerBlockLabel";
            this.samplesPerBlockLabel.Size = new System.Drawing.Size(136, 13);
            this.samplesPerBlockLabel.TabIndex = 3;
            this.samplesPerBlockLabel.Text = "Samples to Read per Block";
            // 
            // meanPowerLabel
            // 
            this.meanPowerLabel.AutoSize = true;
            this.meanPowerLabel.Location = new System.Drawing.Point(388, 271);
            this.meanPowerLabel.Name = "meanPowerLabel";
            this.meanPowerLabel.Size = new System.Drawing.Size(97, 13);
            this.meanPowerLabel.TabIndex = 4;
            this.meanPowerLabel.Text = "Mean Power (dBm)";
            // 
            // meanPowerTextBox
            // 
            this.meanPowerTextBox.Location = new System.Drawing.Point(388, 287);
            this.meanPowerTextBox.Name = "meanPowerTextBox";
            this.meanPowerTextBox.ReadOnly = true;
            this.meanPowerTextBox.Size = new System.Drawing.Size(116, 20);
            this.meanPowerTextBox.TabIndex = 11;
            this.meanPowerTextBox.Text = "0.00000000000000E+0";
            // 
            // resourceNameLabel
            // 
            this.resourceNameLabel.AutoSize = true;
            this.resourceNameLabel.Location = new System.Drawing.Point(14, 12);
            this.resourceNameLabel.Name = "resourceNameLabel";
            this.resourceNameLabel.Size = new System.Drawing.Size(84, 13);
            this.resourceNameLabel.TabIndex = 12;
            this.resourceNameLabel.Text = "Resource Name";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(14, 337);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "&Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.OnStartButtonClick);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(104, 337);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 7;
            this.stopButton.Text = "S&top";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.OnStopButtonClick);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // rmsRadioButton
            // 
            this.rmsRadioButton.AutoSize = true;
            this.rmsRadioButton.Location = new System.Drawing.Point(27, 19);
            this.rmsRadioButton.Name = "rmsRadioButton";
            this.rmsRadioButton.Size = new System.Drawing.Size(49, 17);
            this.rmsRadioButton.TabIndex = 0;
            this.rmsRadioButton.Text = "RMS";
            this.rmsRadioButton.UseVisualStyleBackColor = true;
            // 
            // peakRadioButton
            // 
            this.peakRadioButton.AutoSize = true;
            this.peakRadioButton.Checked = true;
            this.peakRadioButton.Location = new System.Drawing.Point(27, 37);
            this.peakRadioButton.Name = "peakRadioButton";
            this.peakRadioButton.Size = new System.Drawing.Size(53, 17);
            this.peakRadioButton.TabIndex = 1;
            this.peakRadioButton.TabStop = true;
            this.peakRadioButton.Text = "PEAK";
            this.peakRadioButton.UseVisualStyleBackColor = true;
            // 
            // peakScalingGroupBox
            // 
            this.peakScalingGroupBox.Controls.Add(this.rmsRadioButton);
            this.peakScalingGroupBox.Controls.Add(this.peakRadioButton);
            this.peakScalingGroupBox.Location = new System.Drawing.Point(229, 271);
            this.peakScalingGroupBox.Name = "peakScalingGroupBox";
            this.peakScalingGroupBox.Size = new System.Drawing.Size(131, 62);
            this.peakScalingGroupBox.TabIndex = 5;
            this.peakScalingGroupBox.TabStop = false;
            this.peakScalingGroupBox.Text = "Peak Scaling";
            // 
            // powerVsTimeWaveformGraph
            // 
            this.powerVsTimeWaveformGraph.Location = new System.Drawing.Point(152, 12);
            this.powerVsTimeWaveformGraph.Name = "powerVsTimeWaveformGraph";
            this.powerVsTimeWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.powerVsTimeWaveformGraph.Size = new System.Drawing.Size(357, 252);
            this.powerVsTimeWaveformGraph.TabIndex = 10;
            this.powerVsTimeWaveformGraph.UseColorGenerator = true;
            this.powerVsTimeWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.powerVsTimeWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // resourceNameComboBox
            // 
            this.resourceNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.resourceNameComboBox.FormattingEnabled = true;
            this.resourceNameComboBox.Location = new System.Drawing.Point(14, 34);
            this.resourceNameComboBox.Name = "resourceNameComboBox";
            this.resourceNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.resourceNameComboBox.TabIndex = 0;
            // 
            // samplesPerBlockNumeric
            // 
            this.samplesPerBlockNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.samplesPerBlockNumeric.Location = new System.Drawing.Point(14, 239);
            this.samplesPerBlockNumeric.Name = "samplesPerBlockNumeric";
            this.samplesPerBlockNumeric.Range = new NationalInstruments.UI.Range(1D, 4294967295D);
            this.samplesPerBlockNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.samplesPerBlockNumeric.Size = new System.Drawing.Size(116, 20);
            this.samplesPerBlockNumeric.TabIndex = 13;
            this.samplesPerBlockNumeric.Value = 10000D;
            // 
            // iqRateNumeric
            // 
            this.iqRateNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.iqRateNumeric.Location = new System.Drawing.Point(14, 188);
            this.iqRateNumeric.Name = "iqRateNumeric";
            this.iqRateNumeric.Range = new NationalInstruments.UI.Range(0D, 2147483647D);
            this.iqRateNumeric.Size = new System.Drawing.Size(116, 20);
            this.iqRateNumeric.TabIndex = 14;
            this.iqRateNumeric.Value = 100000D;
            // 
            // referenceLevelNumeric
            // 
            this.referenceLevelNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.referenceLevelNumeric.Location = new System.Drawing.Point(14, 86);
            this.referenceLevelNumeric.Name = "referenceLevelNumeric";
            this.referenceLevelNumeric.Size = new System.Drawing.Size(116, 20);
            this.referenceLevelNumeric.TabIndex = 15;
            // 
            // carrierFrequencyNumeric
            // 
            this.carrierFrequencyNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.carrierFrequencyNumeric.Location = new System.Drawing.Point(14, 137);
            this.carrierFrequencyNumeric.Name = "carrierFrequencyNumeric";
            this.carrierFrequencyNumeric.Range = new NationalInstruments.UI.Range(0D, double.PositiveInfinity);
            this.carrierFrequencyNumeric.Size = new System.Drawing.Size(116, 20);
            this.carrierFrequencyNumeric.TabIndex = 16;
            this.carrierFrequencyNumeric.Value = 1000000000D;
            // 
            // MainForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 370);
            this.Controls.Add(this.carrierFrequencyNumeric);
            this.Controls.Add(this.referenceLevelNumeric);
            this.Controls.Add(this.iqRateNumeric);
            this.Controls.Add(this.samplesPerBlockNumeric);
            this.Controls.Add(this.resourceNameComboBox);
            this.Controls.Add(this.powerVsTimeWaveformGraph);
            this.Controls.Add(this.peakScalingGroupBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.resourceNameLabel);
            this.Controls.Add(this.referenceLevelLabel);
            this.Controls.Add(this.carrierFrequencyLabel);
            this.Controls.Add(this.iqRateLabel);
            this.Controls.Add(this.samplesPerBlockLabel);
            this.Controls.Add(this.meanPowerLabel);
            this.Controls.Add(this.meanPowerTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RFSA Power Vs Time (Zero-Span)";
            this.Load += new System.EventHandler(this.OnMainFormLoad);
            this.peakScalingGroupBox.ResumeLayout(false);
            this.peakScalingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerVsTimeWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesPerBlockNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iqRateNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceLevelNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrierFrequencyNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label referenceLevelLabel;
        private System.Windows.Forms.Label carrierFrequencyLabel;
        private System.Windows.Forms.Label iqRateLabel;
        private System.Windows.Forms.Label samplesPerBlockLabel;
        private System.Windows.Forms.Label meanPowerLabel;
        private System.Windows.Forms.TextBox meanPowerTextBox;
        private System.Windows.Forms.Label resourceNameLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton rmsRadioButton;
        private System.Windows.Forms.RadioButton peakRadioButton;
        private System.Windows.Forms.GroupBox peakScalingGroupBox;
        private UI.WindowsForms.WaveformGraph powerVsTimeWaveformGraph;
        private UI.WaveformPlot waveformPlot1;
        private UI.XAxis xAxis1;
        private UI.YAxis yAxis1;
        private System.Windows.Forms.ComboBox resourceNameComboBox;
        private UI.WindowsForms.NumericEdit samplesPerBlockNumeric;
        private UI.WindowsForms.NumericEdit iqRateNumeric;
        private UI.WindowsForms.NumericEdit referenceLevelNumeric;
        private UI.WindowsForms.NumericEdit carrierFrequencyNumeric;

    }
}
