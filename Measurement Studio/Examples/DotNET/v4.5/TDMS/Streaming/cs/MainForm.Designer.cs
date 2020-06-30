namespace NationalInstruments.Examples.Streaming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGeneratorComponent = new System.ComponentModel.BackgroundWorker();
            this.generateAndAppendButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.tdmsFileSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.configurationGroupBox = new System.Windows.Forms.GroupBox();
            this.sampleIntervalModeTextBox = new System.Windows.Forms.TextBox();
            this.numberOfChannelsNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numberOfChannelsLabel = new System.Windows.Forms.Label();
            this.amplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.frequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.sampleIntervalModeLabel2 = new System.Windows.Forms.Label();
            this.samplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.numberOfSamplesLabel = new System.Windows.Forms.Label();
            this.numberOfWaveformsNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numberOfWaveformsLabel = new System.Windows.Forms.Label();
            this.setUpTDMSFileButton = new System.Windows.Forms.Button();
            this.tdmsFileSetUpGroupBox = new System.Windows.Forms.GroupBox();
            this.sampleIntervalModeComboBox = new System.Windows.Forms.ComboBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.sampleIntervalModeLabel = new System.Windows.Forms.Label();
            this.statusGroupBox = new System.Windows.Forms.GroupBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.configurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfChannelsNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfWaveformsNumericEdit)).BeginInit();
            this.tdmsFileSetUpGroupBox.SuspendLayout();
            this.statusGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGeneratorComponent
            // 
            this.dataGeneratorComponent.DoWork += new System.ComponentModel.DoWorkEventHandler(this.dataGeneratorComponent_Read);
            this.dataGeneratorComponent.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.dataGeneratorComponent_ReadCompleted);
            // 
            // generateAndAppendButton
            // 
            this.generateAndAppendButton.Location = new System.Drawing.Point(38, 204);
            this.generateAndAppendButton.Name = "generateAndAppendButton";
            this.generateAndAppendButton.Size = new System.Drawing.Size(200, 23);
            this.generateAndAppendButton.TabIndex = 5;
            this.generateAndAppendButton.Text = "&Generate and Append to TDMS File";
            this.generateAndAppendButton.UseVisualStyleBackColor = true;
            this.generateAndAppendButton.Click += new System.EventHandler(this.generateAndAppendButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(243, 19);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(25, 22);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(80, 20);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(163, 20);
            this.filePathTextBox.TabIndex = 0;
            this.filePathTextBox.Text = "waveforms.tdms";
            this.filePathTextBox.TextChanged += new System.EventHandler(this.TDMSFileConfiguration_Changed);
            // 
            // tdmsFileSaveFileDialog
            // 
            this.tdmsFileSaveFileDialog.FileName = "waveforms.tdms";
            this.tdmsFileSaveFileDialog.Filter = "TDMS files|*.tdms";
            this.tdmsFileSaveFileDialog.Title = "Save TDMS file as";
            // 
            // configurationGroupBox
            // 
            this.configurationGroupBox.Controls.Add(this.sampleIntervalModeTextBox);
            this.configurationGroupBox.Controls.Add(this.numberOfChannelsNumericEdit);
            this.configurationGroupBox.Controls.Add(this.numberOfChannelsLabel);
            this.configurationGroupBox.Controls.Add(this.amplitudeNumericEdit);
            this.configurationGroupBox.Controls.Add(this.frequencyNumericEdit);
            this.configurationGroupBox.Controls.Add(this.generateAndAppendButton);
            this.configurationGroupBox.Controls.Add(this.sampleIntervalModeLabel2);
            this.configurationGroupBox.Controls.Add(this.samplesNumericEdit);
            this.configurationGroupBox.Controls.Add(this.amplitudeLabel);
            this.configurationGroupBox.Controls.Add(this.frequencyLabel);
            this.configurationGroupBox.Controls.Add(this.numberOfSamplesLabel);
            this.configurationGroupBox.Location = new System.Drawing.Point(301, 12);
            this.configurationGroupBox.Name = "configurationGroupBox";
            this.configurationGroupBox.Size = new System.Drawing.Size(270, 236);
            this.configurationGroupBox.TabIndex = 1;
            this.configurationGroupBox.TabStop = false;
            this.configurationGroupBox.Text = "Signal Configuration";
            // 
            // sampleIntervalModeTextBox
            // 
            this.sampleIntervalModeTextBox.Location = new System.Drawing.Point(144, 93);
            this.sampleIntervalModeTextBox.Name = "sampleIntervalModeTextBox";
            this.sampleIntervalModeTextBox.ReadOnly = true;
            this.sampleIntervalModeTextBox.Size = new System.Drawing.Size(120, 20);
            this.sampleIntervalModeTextBox.TabIndex = 1;
            this.sampleIntervalModeTextBox.TabStop = false;
            // 
            // numberOfChannelsNumericEdit
            // 
            this.numberOfChannelsNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.numberOfChannelsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfChannelsNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.numberOfChannelsNumericEdit.Location = new System.Drawing.Point(144, 19);
            this.numberOfChannelsNumericEdit.Name = "numberOfChannelsNumericEdit";
            this.numberOfChannelsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfChannelsNumericEdit.Range = new NationalInstruments.UI.Range(1, 10);
            this.numberOfChannelsNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.numberOfChannelsNumericEdit.TabIndex = 1;
            this.numberOfChannelsNumericEdit.TabStop = false;
            this.numberOfChannelsNumericEdit.Value = 2;
            // 
            // numberOfChannelsLabel
            // 
            this.numberOfChannelsLabel.AutoSize = true;
            this.numberOfChannelsLabel.Location = new System.Drawing.Point(12, 23);
            this.numberOfChannelsLabel.Name = "numberOfChannelsLabel";
            this.numberOfChannelsLabel.Size = new System.Drawing.Size(106, 13);
            this.numberOfChannelsLabel.TabIndex = 14;
            this.numberOfChannelsLabel.Text = "Number of Channels:";
            // 
            // amplitudeNumericEdit
            // 
            this.amplitudeNumericEdit.Location = new System.Drawing.Point(144, 167);
            this.amplitudeNumericEdit.Name = "amplitudeNumericEdit";
            this.amplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.amplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, 1000000);
            this.amplitudeNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.amplitudeNumericEdit.TabIndex = 4;
            this.amplitudeNumericEdit.Value = 10;
            // 
            // frequencyNumericEdit
            // 
            this.frequencyNumericEdit.Location = new System.Drawing.Point(144, 130);
            this.frequencyNumericEdit.Name = "frequencyNumericEdit";
            this.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.frequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, 1000000);
            this.frequencyNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.frequencyNumericEdit.TabIndex = 3;
            this.frequencyNumericEdit.Value = 3;
            // 
            // sampleIntervalModeLabel2
            // 
            this.sampleIntervalModeLabel2.AutoSize = true;
            this.sampleIntervalModeLabel2.Location = new System.Drawing.Point(12, 97);
            this.sampleIntervalModeLabel2.Name = "sampleIntervalModeLabel2";
            this.sampleIntervalModeLabel2.Size = new System.Drawing.Size(113, 13);
            this.sampleIntervalModeLabel2.TabIndex = 14;
            this.sampleIntervalModeLabel2.Text = "Sample Interval Mode:";
            // 
            // samplesNumericEdit
            // 
            this.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.samplesNumericEdit.Location = new System.Drawing.Point(144, 56);
            this.samplesNumericEdit.Name = "samplesNumericEdit";
            this.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.samplesNumericEdit.Range = new NationalInstruments.UI.Range(1, 1000000);
            this.samplesNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.samplesNumericEdit.TabIndex = 1;
            this.samplesNumericEdit.Value = 1000;
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.AutoSize = true;
            this.amplitudeLabel.Location = new System.Drawing.Point(12, 171);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(56, 13);
            this.amplitudeLabel.TabIndex = 13;
            this.amplitudeLabel.Text = "Amplitude:";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.AutoSize = true;
            this.frequencyLabel.Location = new System.Drawing.Point(12, 134);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(60, 13);
            this.frequencyLabel.TabIndex = 12;
            this.frequencyLabel.Text = "Frequency:";
            // 
            // numberOfSamplesLabel
            // 
            this.numberOfSamplesLabel.AutoSize = true;
            this.numberOfSamplesLabel.Location = new System.Drawing.Point(12, 60);
            this.numberOfSamplesLabel.Name = "numberOfSamplesLabel";
            this.numberOfSamplesLabel.Size = new System.Drawing.Size(102, 13);
            this.numberOfSamplesLabel.TabIndex = 15;
            this.numberOfSamplesLabel.Text = "Number of Samples:";
            // 
            // numberOfWaveformsNumericEdit
            // 
            this.numberOfWaveformsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfWaveformsNumericEdit.Location = new System.Drawing.Point(148, 51);
            this.numberOfWaveformsNumericEdit.Name = "numberOfWaveformsNumericEdit";
            this.numberOfWaveformsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfWaveformsNumericEdit.Range = new NationalInstruments.UI.Range(1, 10);
            this.numberOfWaveformsNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.numberOfWaveformsNumericEdit.TabIndex = 2;
            this.numberOfWaveformsNumericEdit.Value = 2;
            this.numberOfWaveformsNumericEdit.ValueChanged += new System.EventHandler(this.TDMSFileConfiguration_Changed);
            // 
            // numberOfWaveformsLabel
            // 
            this.numberOfWaveformsLabel.AutoSize = true;
            this.numberOfWaveformsLabel.Location = new System.Drawing.Point(6, 54);
            this.numberOfWaveformsLabel.Name = "numberOfWaveformsLabel";
            this.numberOfWaveformsLabel.Size = new System.Drawing.Size(116, 13);
            this.numberOfWaveformsLabel.TabIndex = 14;
            this.numberOfWaveformsLabel.Text = "Number of Waveforms:";
            // 
            // setUpTDMSFileButton
            // 
            this.setUpTDMSFileButton.Location = new System.Drawing.Point(68, 114);
            this.setUpTDMSFileButton.Name = "setUpTDMSFileButton";
            this.setUpTDMSFileButton.Size = new System.Drawing.Size(115, 23);
            this.setUpTDMSFileButton.TabIndex = 4;
            this.setUpTDMSFileButton.Text = "&Set Up TDMS File";
            this.setUpTDMSFileButton.UseVisualStyleBackColor = true;
            this.setUpTDMSFileButton.Click += new System.EventHandler(this.setUpTDMSFileButton_Click);
            // 
            // tdmsFileSetUpGroupBox
            // 
            this.tdmsFileSetUpGroupBox.Controls.Add(this.browseButton);
            this.tdmsFileSetUpGroupBox.Controls.Add(this.sampleIntervalModeComboBox);
            this.tdmsFileSetUpGroupBox.Controls.Add(this.numberOfWaveformsNumericEdit);
            this.tdmsFileSetUpGroupBox.Controls.Add(this.filePathTextBox);
            this.tdmsFileSetUpGroupBox.Controls.Add(this.filePathLabel);
            this.tdmsFileSetUpGroupBox.Controls.Add(this.sampleIntervalModeLabel);
            this.tdmsFileSetUpGroupBox.Controls.Add(this.numberOfWaveformsLabel);
            this.tdmsFileSetUpGroupBox.Controls.Add(this.setUpTDMSFileButton);
            this.tdmsFileSetUpGroupBox.Location = new System.Drawing.Point(12, 12);
            this.tdmsFileSetUpGroupBox.Name = "tdmsFileSetUpGroupBox";
            this.tdmsFileSetUpGroupBox.Size = new System.Drawing.Size(279, 147);
            this.tdmsFileSetUpGroupBox.TabIndex = 0;
            this.tdmsFileSetUpGroupBox.TabStop = false;
            this.tdmsFileSetUpGroupBox.Text = "TDMS File Setup";
            // 
            // sampleIntervalModeComboBox
            // 
            this.sampleIntervalModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sampleIntervalModeComboBox.FormattingEnabled = true;
            this.sampleIntervalModeComboBox.Location = new System.Drawing.Point(148, 82);
            this.sampleIntervalModeComboBox.Name = "sampleIntervalModeComboBox";
            this.sampleIntervalModeComboBox.Size = new System.Drawing.Size(120, 21);
            this.sampleIntervalModeComboBox.TabIndex = 3;
            // 
            // filePathLabel
            // 
            this.filePathLabel.AutoSize = true;
            this.filePathLabel.Location = new System.Drawing.Point(6, 24);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(51, 13);
            this.filePathLabel.TabIndex = 0;
            this.filePathLabel.Text = "File Path:";
            // 
            // sampleIntervalModeLabel
            // 
            this.sampleIntervalModeLabel.AutoSize = true;
            this.sampleIntervalModeLabel.Location = new System.Drawing.Point(6, 84);
            this.sampleIntervalModeLabel.Name = "sampleIntervalModeLabel";
            this.sampleIntervalModeLabel.Size = new System.Drawing.Size(113, 13);
            this.sampleIntervalModeLabel.TabIndex = 14;
            this.sampleIntervalModeLabel.Text = "Sample Interval Mode:";
            // 
            // statusGroupBox
            // 
            this.statusGroupBox.Controls.Add(this.statusTextBox);
            this.statusGroupBox.Location = new System.Drawing.Point(12, 163);
            this.statusGroupBox.Name = "statusGroupBox";
            this.statusGroupBox.Size = new System.Drawing.Size(279, 85);
            this.statusGroupBox.TabIndex = 2;
            this.statusGroupBox.TabStop = false;
            this.statusGroupBox.Text = "Status";
            // 
            // statusTextBox
            // 
            this.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusTextBox.Location = new System.Drawing.Point(3, 16);
            this.statusTextBox.Multiline = true;
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(273, 66);
            this.statusTextBox.TabIndex = 0;
            this.statusTextBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 260);
            this.Controls.Add(this.statusGroupBox);
            this.Controls.Add(this.tdmsFileSetUpGroupBox);
            this.Controls.Add(this.configurationGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TDMS Streaming";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TdmsStreamingForm_FormClosed);
            this.configurationGroupBox.ResumeLayout(false);
            this.configurationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfChannelsNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfWaveformsNumericEdit)).EndInit();
            this.tdmsFileSetUpGroupBox.ResumeLayout(false);
            this.tdmsFileSetUpGroupBox.PerformLayout();
            this.statusGroupBox.ResumeLayout(false);
            this.statusGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker dataGeneratorComponent;
        private System.Windows.Forms.Button generateAndAppendButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.SaveFileDialog tdmsFileSaveFileDialog;
        private System.Windows.Forms.GroupBox configurationGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit amplitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit frequencyNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit samplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfWaveformsNumericEdit;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label numberOfSamplesLabel;
        private System.Windows.Forms.Label numberOfWaveformsLabel;
        private System.Windows.Forms.Button setUpTDMSFileButton;
        private System.Windows.Forms.GroupBox tdmsFileSetUpGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfChannelsNumericEdit;
        private System.Windows.Forms.Label numberOfChannelsLabel;
        private System.Windows.Forms.GroupBox statusGroupBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.ComboBox sampleIntervalModeComboBox;
        private System.Windows.Forms.Label filePathLabel;
        private System.Windows.Forms.Label sampleIntervalModeLabel;
        private System.Windows.Forms.Label sampleIntervalModeLabel2;
        private System.Windows.Forms.TextBox sampleIntervalModeTextBox;
    }
}

