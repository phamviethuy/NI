namespace NationalInstruments.Examples.OnDemandReader
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
                if (_reader != null)
                    _reader.Dispose();

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
            this.disconnectButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.displayWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.readButton = new System.Windows.Forms.Button();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.displayWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(15, 243);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(86, 23);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(15, 214);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(86, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // displayWaveformGraph
            // 
            this.displayWaveformGraph.Location = new System.Drawing.Point(12, 12);
            this.displayWaveformGraph.Name = "displayWaveformGraph";
            this.displayWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.displayWaveformGraph.Size = new System.Drawing.Size(278, 168);
            this.displayWaveformGraph.TabIndex = 5;
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
            // readButton
            // 
            this.readButton.Enabled = false;
            this.readButton.Location = new System.Drawing.Point(112, 214);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(86, 23);
            this.readButton.TabIndex = 6;
            this.readButton.Text = "Read";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(12, 191);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.connectionStatusLabel.TabIndex = 8;
            this.connectionStatusLabel.Text = "Connection Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(112, 188);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(129, 20);
            this.statusTextBox.TabIndex = 7;
            this.statusTextBox.Text = "Disconnected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 279);
            this.Controls.Add(this.connectionStatusLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.displayWaveformGraph);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.connectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "On Demand Reader";
            ((System.ComponentModel.ISupportInitialize)(this.displayWaveformGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Button connectButton;
        private NationalInstruments.UI.WindowsForms.WaveformGraph displayWaveformGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
    }
}

