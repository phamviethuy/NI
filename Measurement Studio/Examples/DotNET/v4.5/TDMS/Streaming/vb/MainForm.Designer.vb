<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.dataGeneratorComponent = New System.ComponentModel.BackgroundWorker
        Me.generateAndAppendButton = New System.Windows.Forms.Button
        Me.browseButton = New System.Windows.Forms.Button
        Me.filePathTextBox = New System.Windows.Forms.TextBox
        Me.tdmsFileSaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.configurationGroupBox = New System.Windows.Forms.GroupBox
        Me.sampleIntervalModeTextBox = New System.Windows.Forms.TextBox
        Me.numberOfChannelsNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfChannelsLabel = New System.Windows.Forms.Label
        Me.amplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.frequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sampleIntervalModeLabel2 = New System.Windows.Forms.Label
        Me.samplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amplitudeLabel = New System.Windows.Forms.Label
        Me.frequencyLabel = New System.Windows.Forms.Label
        Me.numberOfSamplesLabel = New System.Windows.Forms.Label
        Me.numberOfWaveformsNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfWaveformsLabel = New System.Windows.Forms.Label
        Me.setUpTDMSFileButton = New System.Windows.Forms.Button
        Me.tdmsFileSetUpGroupBox = New System.Windows.Forms.GroupBox
        Me.sampleIntervalModeComboBox = New System.Windows.Forms.ComboBox
        Me.filePathLabel = New System.Windows.Forms.Label
        Me.sampleIntervalModeLabel = New System.Windows.Forms.Label
        Me.statusGroupBox = New System.Windows.Forms.GroupBox
        Me.statusTextBox = New System.Windows.Forms.TextBox
        Me.configurationGroupBox.SuspendLayout()
        CType(Me.numberOfChannelsNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfWaveformsNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tdmsFileSetUpGroupBox.SuspendLayout()
        Me.statusGroupBox.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' dataGeneratorComponent 
        ' 
        ' 
        ' generateAndAppendButton 
        ' 
        Me.generateAndAppendButton.Location = New System.Drawing.Point(38, 204)
        Me.generateAndAppendButton.Name = "generateAndAppendButton"
        Me.generateAndAppendButton.Size = New System.Drawing.Size(200, 23)
        Me.generateAndAppendButton.TabIndex = 5
        Me.generateAndAppendButton.Text = "&Generate and Append to TDMS File"
        Me.generateAndAppendButton.UseVisualStyleBackColor = True
        ' 
        ' browseButton 
        ' 
        Me.browseButton.Location = New System.Drawing.Point(243, 19)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(25, 22)
        Me.browseButton.TabIndex = 1
        Me.browseButton.Text = "..."
        Me.browseButton.UseVisualStyleBackColor = True
        ' 
        ' filePathTextBox 
        ' 
        Me.filePathTextBox.Location = New System.Drawing.Point(80, 20)
        Me.filePathTextBox.Name = "filePathTextBox"
        Me.filePathTextBox.Size = New System.Drawing.Size(163, 20)
        Me.filePathTextBox.TabIndex = 0
        Me.filePathTextBox.Text = "waveforms.tdms"
        ' 
        ' tdmsFileSaveFileDialog 
        ' 
        Me.tdmsFileSaveFileDialog.FileName = "waveforms.tdms"
        Me.tdmsFileSaveFileDialog.Filter = "TDMS files|*.tdms"
        Me.tdmsFileSaveFileDialog.Title = "Save TDMS file as"
        ' 
        ' configurationGroupBox 
        ' 
        Me.configurationGroupBox.Controls.Add(Me.sampleIntervalModeTextBox)
        Me.configurationGroupBox.Controls.Add(Me.numberOfChannelsNumericEdit)
        Me.configurationGroupBox.Controls.Add(Me.numberOfChannelsLabel)
        Me.configurationGroupBox.Controls.Add(Me.amplitudeNumericEdit)
        Me.configurationGroupBox.Controls.Add(Me.frequencyNumericEdit)
        Me.configurationGroupBox.Controls.Add(Me.generateAndAppendButton)
        Me.configurationGroupBox.Controls.Add(Me.sampleIntervalModeLabel2)
        Me.configurationGroupBox.Controls.Add(Me.samplesNumericEdit)
        Me.configurationGroupBox.Controls.Add(Me.amplitudeLabel)
        Me.configurationGroupBox.Controls.Add(Me.frequencyLabel)
        Me.configurationGroupBox.Controls.Add(Me.numberOfSamplesLabel)
        Me.configurationGroupBox.Location = New System.Drawing.Point(301, 12)
        Me.configurationGroupBox.Name = "configurationGroupBox"
        Me.configurationGroupBox.Size = New System.Drawing.Size(270, 236)
        Me.configurationGroupBox.TabIndex = 1
        Me.configurationGroupBox.TabStop = False
        Me.configurationGroupBox.Text = "Signal Configuration"
        ' 
        ' sampleIntervalModeTextBox 
        ' 
        Me.sampleIntervalModeTextBox.Location = New System.Drawing.Point(144, 93)
        Me.sampleIntervalModeTextBox.Name = "sampleIntervalModeTextBox"
        Me.sampleIntervalModeTextBox.ReadOnly = True
        Me.sampleIntervalModeTextBox.Size = New System.Drawing.Size(120, 20)
        Me.sampleIntervalModeTextBox.TabIndex = 1
        Me.sampleIntervalModeTextBox.TabStop = False
        ' 
        ' numberOfChannelsNumericEdit 
        ' 
        Me.numberOfChannelsNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.numberOfChannelsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfChannelsNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.numberOfChannelsNumericEdit.Location = New System.Drawing.Point(144, 19)
        Me.numberOfChannelsNumericEdit.Name = "numberOfChannelsNumericEdit"
        Me.numberOfChannelsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfChannelsNumericEdit.Range = New NationalInstruments.UI.Range(1, 10)
        Me.numberOfChannelsNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.numberOfChannelsNumericEdit.TabIndex = 1
        Me.numberOfChannelsNumericEdit.TabStop = False
        Me.numberOfChannelsNumericEdit.Value = 2
        ' 
        ' numberOfChannelsLabel 
        ' 
        Me.numberOfChannelsLabel.AutoSize = True
        Me.numberOfChannelsLabel.Location = New System.Drawing.Point(12, 23)
        Me.numberOfChannelsLabel.Name = "numberOfChannelsLabel"
        Me.numberOfChannelsLabel.Size = New System.Drawing.Size(106, 13)
        Me.numberOfChannelsLabel.TabIndex = 14
        Me.numberOfChannelsLabel.Text = "Number of Channels:"
        ' 
        ' amplitudeNumericEdit 
        ' 
        Me.amplitudeNumericEdit.Location = New System.Drawing.Point(144, 167)
        Me.amplitudeNumericEdit.Name = "amplitudeNumericEdit"
        Me.amplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.amplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, 1000000)
        Me.amplitudeNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.amplitudeNumericEdit.TabIndex = 4
        Me.amplitudeNumericEdit.Value = 10
        ' 
        ' frequencyNumericEdit 
        ' 
        Me.frequencyNumericEdit.Location = New System.Drawing.Point(144, 130)
        Me.frequencyNumericEdit.Name = "frequencyNumericEdit"
        Me.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.frequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, 1000000)
        Me.frequencyNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.frequencyNumericEdit.TabIndex = 3
        Me.frequencyNumericEdit.Value = 3
        ' 
        ' sampleIntervalModeLabel2 
        ' 
        Me.sampleIntervalModeLabel2.AutoSize = True
        Me.sampleIntervalModeLabel2.Location = New System.Drawing.Point(12, 97)
        Me.sampleIntervalModeLabel2.Name = "sampleIntervalModeLabel2"
        Me.sampleIntervalModeLabel2.Size = New System.Drawing.Size(113, 13)
        Me.sampleIntervalModeLabel2.TabIndex = 14
        Me.sampleIntervalModeLabel2.Text = "Sample Interval Mode:"
        ' 
        ' samplesNumericEdit 
        ' 
        Me.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.samplesNumericEdit.Location = New System.Drawing.Point(144, 56)
        Me.samplesNumericEdit.Name = "samplesNumericEdit"
        Me.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplesNumericEdit.Range = New NationalInstruments.UI.Range(1, 1000000)
        Me.samplesNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.samplesNumericEdit.TabIndex = 1
        Me.samplesNumericEdit.Value = 1000
        ' 
        ' amplitudeLabel 
        ' 
        Me.amplitudeLabel.AutoSize = True
        Me.amplitudeLabel.Location = New System.Drawing.Point(12, 171)
        Me.amplitudeLabel.Name = "amplitudeLabel"
        Me.amplitudeLabel.Size = New System.Drawing.Size(56, 13)
        Me.amplitudeLabel.TabIndex = 13
        Me.amplitudeLabel.Text = "Amplitude:"
        ' 
        ' frequencyLabel 
        ' 
        Me.frequencyLabel.AutoSize = True
        Me.frequencyLabel.Location = New System.Drawing.Point(12, 134)
        Me.frequencyLabel.Name = "frequencyLabel"
        Me.frequencyLabel.Size = New System.Drawing.Size(60, 13)
        Me.frequencyLabel.TabIndex = 12
        Me.frequencyLabel.Text = "Frequency:"
        ' 
        ' numberOfSamplesLabel 
        ' 
        Me.numberOfSamplesLabel.AutoSize = True
        Me.numberOfSamplesLabel.Location = New System.Drawing.Point(12, 60)
        Me.numberOfSamplesLabel.Name = "numberOfSamplesLabel"
        Me.numberOfSamplesLabel.Size = New System.Drawing.Size(102, 13)
        Me.numberOfSamplesLabel.TabIndex = 15
        Me.numberOfSamplesLabel.Text = "Number of Samples:"
        ' 
        ' numberOfWaveformsNumericEdit 
        ' 
        Me.numberOfWaveformsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfWaveformsNumericEdit.Location = New System.Drawing.Point(148, 51)
        Me.numberOfWaveformsNumericEdit.Name = "numberOfWaveformsNumericEdit"
        Me.numberOfWaveformsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfWaveformsNumericEdit.Range = New NationalInstruments.UI.Range(1, 10)
        Me.numberOfWaveformsNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.numberOfWaveformsNumericEdit.TabIndex = 2
        Me.numberOfWaveformsNumericEdit.Value = 2
        ' 
        ' numberOfWaveformsLabel 
        ' 
        Me.numberOfWaveformsLabel.AutoSize = True
        Me.numberOfWaveformsLabel.Location = New System.Drawing.Point(6, 54)
        Me.numberOfWaveformsLabel.Name = "numberOfWaveformsLabel"
        Me.numberOfWaveformsLabel.Size = New System.Drawing.Size(116, 13)
        Me.numberOfWaveformsLabel.TabIndex = 14
        Me.numberOfWaveformsLabel.Text = "Number of Waveforms:"
        ' 
        ' setUpTDMSFileButton 
        ' 
        Me.setUpTDMSFileButton.Location = New System.Drawing.Point(68, 114)
        Me.setUpTDMSFileButton.Name = "setUpTDMSFileButton"
        Me.setUpTDMSFileButton.Size = New System.Drawing.Size(115, 23)
        Me.setUpTDMSFileButton.TabIndex = 4
        Me.setUpTDMSFileButton.Text = "&Set Up TDMS File"
        Me.setUpTDMSFileButton.UseVisualStyleBackColor = True
        ' 
        ' tdmsFileSetUpGroupBox 
        ' 
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.browseButton)
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.sampleIntervalModeComboBox)
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.numberOfWaveformsNumericEdit)
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.filePathTextBox)
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.filePathLabel)
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.sampleIntervalModeLabel)
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.numberOfWaveformsLabel)
        Me.tdmsFileSetUpGroupBox.Controls.Add(Me.setUpTDMSFileButton)
        Me.tdmsFileSetUpGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.tdmsFileSetUpGroupBox.Name = "tdmsFileSetUpGroupBox"
        Me.tdmsFileSetUpGroupBox.Size = New System.Drawing.Size(279, 147)
        Me.tdmsFileSetUpGroupBox.TabIndex = 0
        Me.tdmsFileSetUpGroupBox.TabStop = False
        Me.tdmsFileSetUpGroupBox.Text = "TDMS File Setup"
        ' 
        ' sampleIntervalModeComboBox 
        ' 
        Me.sampleIntervalModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sampleIntervalModeComboBox.FormattingEnabled = True
        Me.sampleIntervalModeComboBox.Location = New System.Drawing.Point(148, 82)
        Me.sampleIntervalModeComboBox.Name = "sampleIntervalModeComboBox"
        Me.sampleIntervalModeComboBox.Size = New System.Drawing.Size(120, 21)
        Me.sampleIntervalModeComboBox.TabIndex = 3
        ' 
        ' filePathLabel 
        ' 
        Me.filePathLabel.AutoSize = True
        Me.filePathLabel.Location = New System.Drawing.Point(6, 24)
        Me.filePathLabel.Name = "filePathLabel"
        Me.filePathLabel.Size = New System.Drawing.Size(51, 13)
        Me.filePathLabel.TabIndex = 0
        Me.filePathLabel.Text = "File Path:"
        ' 
        ' sampleIntervalModeLabel 
        ' 
        Me.sampleIntervalModeLabel.AutoSize = True
        Me.sampleIntervalModeLabel.Location = New System.Drawing.Point(6, 84)
        Me.sampleIntervalModeLabel.Name = "sampleIntervalModeLabel"
        Me.sampleIntervalModeLabel.Size = New System.Drawing.Size(113, 13)
        Me.sampleIntervalModeLabel.TabIndex = 14
        Me.sampleIntervalModeLabel.Text = "Sample Interval Mode:"
        ' 
        ' statusGroupBox 
        ' 
        Me.statusGroupBox.Controls.Add(Me.statusTextBox)
        Me.statusGroupBox.Location = New System.Drawing.Point(12, 163)
        Me.statusGroupBox.Name = "statusGroupBox"
        Me.statusGroupBox.Size = New System.Drawing.Size(279, 85)
        Me.statusGroupBox.TabIndex = 2
        Me.statusGroupBox.TabStop = False
        Me.statusGroupBox.Text = "Status"
        ' 
        ' statusTextBox 
        ' 
        Me.statusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.statusTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.statusTextBox.Location = New System.Drawing.Point(3, 16)
        Me.statusTextBox.Multiline = True
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(273, 66)
        Me.statusTextBox.TabIndex = 0
        Me.statusTextBox.TabStop = False
        ' 
        ' MainForm 
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 260)
        Me.Controls.Add(Me.statusGroupBox)
        Me.Controls.Add(Me.tdmsFileSetUpGroupBox)
        Me.Controls.Add(Me.configurationGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "TDMS Streaming"
        Me.configurationGroupBox.ResumeLayout(False)
        Me.configurationGroupBox.PerformLayout()
        CType(Me.numberOfChannelsNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfWaveformsNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tdmsFileSetUpGroupBox.ResumeLayout(False)
        Me.tdmsFileSetUpGroupBox.PerformLayout()
        Me.statusGroupBox.ResumeLayout(False)
        Me.statusGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dataGeneratorComponent As System.ComponentModel.BackgroundWorker
    Private WithEvents generateAndAppendButton As System.Windows.Forms.Button
    Private WithEvents browseButton As System.Windows.Forms.Button
    Private WithEvents filePathTextBox As System.Windows.Forms.TextBox
    Private WithEvents tdmsFileSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Private WithEvents configurationGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents amplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents frequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents samplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents numberOfWaveformsNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents amplitudeLabel As System.Windows.Forms.Label
    Private WithEvents frequencyLabel As System.Windows.Forms.Label
    Private WithEvents numberOfSamplesLabel As System.Windows.Forms.Label
    Private WithEvents numberOfWaveformsLabel As System.Windows.Forms.Label
    Private WithEvents setUpTDMSFileButton As System.Windows.Forms.Button
    Private WithEvents tdmsFileSetUpGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents numberOfChannelsNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents numberOfChannelsLabel As System.Windows.Forms.Label
    Private WithEvents statusGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents statusTextBox As System.Windows.Forms.TextBox
    Private WithEvents sampleIntervalModeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents filePathLabel As System.Windows.Forms.Label
    Private WithEvents sampleIntervalModeLabel As System.Windows.Forms.Label
    Private WithEvents sampleIntervalModeLabel2 As System.Windows.Forms.Label
    Private WithEvents sampleIntervalModeTextBox As System.Windows.Forms.TextBox

End Class
