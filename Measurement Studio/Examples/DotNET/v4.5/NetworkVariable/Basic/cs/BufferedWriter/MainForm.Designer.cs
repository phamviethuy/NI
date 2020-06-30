namespace NationalInstruments.Examples.BufferedWriter
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
            if (disposing)
            {
                if (_bufferedWriter != null)
                    _bufferedWriter.Dispose();

                if (_doubleBufferedWriter != null)
                    _doubleBufferedWriter.Dispose();

                if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.startButton = new System.Windows.Forms.Button();
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.stopButton = new System.Windows.Forms.Button();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.connectionTextBox = new System.Windows.Forms.TextBox();
            this.amplitudeSlide = new NationalInstruments.UI.WindowsForms.Slide();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(20, 263);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 23);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start Writing";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Location = new System.Drawing.Point(89, 12);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(288, 206);
            this.sampleWaveformGraph.TabIndex = 5;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // yAxis1
            // 
            this.yAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis1.Range = new NationalInstruments.UI.Range(-10, 10);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(122, 263);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(91, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop Writing";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "Disconnected";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(17, 230);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.connectionStatusLabel.TabIndex = 8;
            this.connectionStatusLabel.Text = "Connection Status:";
            // 
            // connectionTextBox
            // 
            this.connectionTextBox.Location = new System.Drawing.Point(122, 227);
            this.connectionTextBox.Name = "connectionTextBox";
            this.connectionTextBox.ReadOnly = true;
            this.connectionTextBox.Size = new System.Drawing.Size(157, 20);
            this.connectionTextBox.TabIndex = 9;
            this.connectionTextBox.Text = "Disconnected";
            // 
            // amplitudeSlide
            // 
            this.amplitudeSlide.Caption = "Amplitude";
            this.amplitudeSlide.Location = new System.Drawing.Point(15, 12);
            this.amplitudeSlide.Name = "amplitudeSlide";
            this.amplitudeSlide.Size = new System.Drawing.Size(68, 206);
            this.amplitudeSlide.TabIndex = 10;
            this.amplitudeSlide.Value = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 297);
            this.Controls.Add(this.amplitudeSlide);
            this.Controls.Add(this.connectionTextBox);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Buffered Writer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeSlide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.TextBox connectionTextBox;
        private NationalInstruments.UI.WindowsForms.Slide amplitudeSlide;
    }
}

