namespace NationalInstruments.Examples.Subscriber
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
                if (_subscriber != null)
                    _subscriber.Dispose();

                if (components != null)
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
            this.displayWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.timeStampTextBox = new System.Windows.Forms.TextBox();
            this.qualityTextBox = new System.Windows.Forms.TextBox();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.timeStampLabel = new System.Windows.Forms.Label();
            this.qualityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // displayWaveformGraph
            // 
            this.displayWaveformGraph.Location = new System.Drawing.Point(12, 12);
            this.displayWaveformGraph.Name = "displayWaveformGraph";
            this.displayWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.displayWaveformGraph.Size = new System.Drawing.Size(347, 168);
            this.displayWaveformGraph.TabIndex = 0;
            this.displayWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.displayWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(273, 198);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(86, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(273, 224);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(86, 23);
            this.disconnectButton.TabIndex = 2;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(109, 198);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(129, 20);
            this.statusTextBox.TabIndex = 3;
            this.statusTextBox.Text = "Disconnected";
            // 
            // timeStampTextBox
            // 
            this.timeStampTextBox.Location = new System.Drawing.Point(109, 224);
            this.timeStampTextBox.Name = "timeStampTextBox";
            this.timeStampTextBox.ReadOnly = true;
            this.timeStampTextBox.Size = new System.Drawing.Size(129, 20);
            this.timeStampTextBox.TabIndex = 4;
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.Location = new System.Drawing.Point(109, 250);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.ReadOnly = true;
            this.qualityTextBox.Size = new System.Drawing.Size(129, 20);
            this.qualityTextBox.TabIndex = 5;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(9, 201);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.connectionStatusLabel.TabIndex = 6;
            this.connectionStatusLabel.Text = "Connection Status:";
            // 
            // timeStampLabel
            // 
            this.timeStampLabel.AutoSize = true;
            this.timeStampLabel.Location = new System.Drawing.Point(9, 227);
            this.timeStampLabel.Name = "timeStampLabel";
            this.timeStampLabel.Size = new System.Drawing.Size(66, 13);
            this.timeStampLabel.TabIndex = 7;
            this.timeStampLabel.Text = "Time Stamp:";
            // 
            // qualityLabel
            // 
            this.qualityLabel.AutoSize = true;
            this.qualityLabel.Location = new System.Drawing.Point(12, 253);
            this.qualityLabel.Name = "qualityLabel";
            this.qualityLabel.Size = new System.Drawing.Size(42, 13);
            this.qualityLabel.TabIndex = 8;
            this.qualityLabel.Text = "Quality:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 283);
            this.Controls.Add(this.qualityLabel);
            this.Controls.Add(this.timeStampLabel);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.qualityTextBox);
            this.Controls.Add(this.timeStampTextBox);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.displayWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Subscriber";
            ((System.ComponentModel.ISupportInitialize)(this.displayWaveformGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.WaveformGraph displayWaveformGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox timeStampTextBox;
        private System.Windows.Forms.TextBox qualityTextBox;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label timeStampLabel;
        private System.Windows.Forms.Label qualityLabel;

    }
}

