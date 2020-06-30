namespace NationalInstruments.Examples.GlobalContinuousAIToNetworkVariable
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.outputNetworkVariableBrowserDialog = new NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBrowserDialog(this.components);
            this.daqmxTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.daqmxTaskLabel = new System.Windows.Forms.Label();
            this.taskComboBox = new System.Windows.Forms.ComboBox();
            this.startButton = new System.Windows.Forms.Button();
            this.outputWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.stopButton = new System.Windows.Forms.Button();
            this.networkVariableGroupBox = new System.Windows.Forms.GroupBox();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.outputLocationLabel = new System.Windows.Forms.Label();
            this.connectionStatusLed = new NationalInstruments.UI.WindowsForms.Led();
            this.outputLocationTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.channelLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.daqmxTaskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputWaveformGraph)).BeginInit();
            this.networkVariableGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStatusLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // outputNetworkVariableBrowserDialog
            // 
            this.outputNetworkVariableBrowserDialog.Text = "Select Output Network Variable";
            // 
            // daqmxTaskGroupBox
            // 
            this.daqmxTaskGroupBox.Controls.Add(this.daqmxTaskLabel);
            this.daqmxTaskGroupBox.Controls.Add(this.taskComboBox);
            this.daqmxTaskGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.daqmxTaskGroupBox.Location = new System.Drawing.Point(12, 12);
            this.daqmxTaskGroupBox.Name = "daqmxTaskGroupBox";
            this.daqmxTaskGroupBox.Size = new System.Drawing.Size(423, 72);
            this.daqmxTaskGroupBox.TabIndex = 4;
            this.daqmxTaskGroupBox.TabStop = false;
            this.daqmxTaskGroupBox.Text = "Global DAQmx Task";
            // 
            // daqmxTaskLabel
            // 
            this.daqmxTaskLabel.AutoSize = true;
            this.daqmxTaskLabel.Location = new System.Drawing.Point(8, 34);
            this.daqmxTaskLabel.Name = "daqmxTaskLabel";
            this.daqmxTaskLabel.Size = new System.Drawing.Size(73, 13);
            this.daqmxTaskLabel.TabIndex = 2;
            this.daqmxTaskLabel.Text = "DAQmx Task:";
            // 
            // taskComboBox
            // 
            this.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskComboBox.Location = new System.Drawing.Point(122, 30);
            this.taskComboBox.Name = "taskComboBox";
            this.taskComboBox.Size = new System.Drawing.Size(226, 21);
            this.taskComboBox.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Location = new System.Drawing.Point(23, 195);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // outputWaveformGraph
            // 
            this.outputWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputWaveformGraph.Location = new System.Drawing.Point(12, 230);
            this.outputWaveformGraph.Name = "outputWaveformGraph";
            this.outputWaveformGraph.UseColorGenerator = true;
            this.outputWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.outputWaveformGraph.Size = new System.Drawing.Size(424, 298);
            this.outputWaveformGraph.TabIndex = 7;
            this.outputWaveformGraph.TabStop = false;
            this.outputWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.outputWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stopButton.Location = new System.Drawing.Point(134, 195);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // networkVariableGroupBox
            // 
            this.networkVariableGroupBox.Controls.Add(this.connectionStatusLabel);
            this.networkVariableGroupBox.Controls.Add(this.outputLocationLabel);
            this.networkVariableGroupBox.Controls.Add(this.connectionStatusLed);
            this.networkVariableGroupBox.Controls.Add(this.outputLocationTextBox);
            this.networkVariableGroupBox.Controls.Add(this.browseButton);
            this.networkVariableGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.networkVariableGroupBox.Location = new System.Drawing.Point(12, 90);
            this.networkVariableGroupBox.Name = "networkVariableGroupBox";
            this.networkVariableGroupBox.Size = new System.Drawing.Size(423, 93);
            this.networkVariableGroupBox.TabIndex = 5;
            this.networkVariableGroupBox.TabStop = false;
            this.networkVariableGroupBox.Text = "Output NetworkVariable";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.Location = new System.Drawing.Point(8, 59);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(97, 13);
            this.connectionStatusLabel.TabIndex = 6;
            this.connectionStatusLabel.Text = "Connection Status:";
            // 
            // outputLocationLabel
            // 
            this.outputLocationLabel.AutoSize = true;
            this.outputLocationLabel.Location = new System.Drawing.Point(8, 25);
            this.outputLocationLabel.Name = "outputLocationLabel";
            this.outputLocationLabel.Size = new System.Drawing.Size(86, 13);
            this.outputLocationLabel.TabIndex = 5;
            this.outputLocationLabel.Text = "Output Location:";
            // 
            // connectionStatusLed
            // 
            this.connectionStatusLed.ImmediateUpdates = true;
            this.connectionStatusLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.connectionStatusLed.Location = new System.Drawing.Point(122, 45);
            this.connectionStatusLed.Name = "connectionStatusLed";
            this.connectionStatusLed.Size = new System.Drawing.Size(43, 40);
            this.connectionStatusLed.TabIndex = 4;
            // 
            // outputLocationTextBox
            // 
            this.outputLocationTextBox.Location = new System.Drawing.Point(122, 21);
            this.outputLocationTextBox.Name = "outputLocationTextBox";
            this.outputLocationTextBox.ReadOnly = true;
            this.outputLocationTextBox.Size = new System.Drawing.Size(226, 20);
            this.outputLocationTextBox.TabIndex = 3;
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(354, 21);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(63, 23);
            this.browseButton.TabIndex = 2;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.infoLabel.Location = new System.Drawing.Point(447, 12);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(259, 171);
            this.infoLabel.TabIndex = 8;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // channelLegend
            // 
            this.channelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.channelLegend.Location = new System.Drawing.Point(450, 230);
            this.channelLegend.Name = "channelLegend";
            this.channelLegend.Size = new System.Drawing.Size(256, 298);
            this.channelLegend.TabIndex = 9;
            this.channelLegend.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(742, 541);
            this.Controls.Add(this.channelLegend);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.networkVariableGroupBox);
            this.Controls.Add(this.daqmxTaskGroupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputWaveformGraph);
            this.Controls.Add(this.stopButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(750, 575);
            this.Name = "MainForm";
            this.Text = "Continuous Analog Input To Network Variable ";
            this.daqmxTaskGroupBox.ResumeLayout(false);
            this.daqmxTaskGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputWaveformGraph)).EndInit();
            this.networkVariableGroupBox.ResumeLayout(false);
            this.networkVariableGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connectionStatusLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelLegend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBrowserDialog outputNetworkVariableBrowserDialog;
        private System.Windows.Forms.GroupBox daqmxTaskGroupBox;
        private System.Windows.Forms.ComboBox taskComboBox;
        private System.Windows.Forms.Button startButton;
        private NationalInstruments.UI.WindowsForms.WaveformGraph outputWaveformGraph;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.GroupBox networkVariableGroupBox;
        private System.Windows.Forms.TextBox outputLocationTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label infoLabel;
        private NationalInstruments.UI.WindowsForms.Led connectionStatusLed;
        private System.Windows.Forms.Label connectionStatusLabel;
        private System.Windows.Forms.Label outputLocationLabel;
        private System.Windows.Forms.Label daqmxTaskLabel;
        private NationalInstruments.UI.WindowsForms.Legend channelLegend;
    }
}

