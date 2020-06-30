' Form used to configure a DAQmx analog acquisition. When the DialogResult 
' property value is DialogResult.OK after a call to ShowDialog, the caller
' must get the DaqTask property value and store a reference to that Task 
' object. The caller is responsible for calling Task.Dispose() on that object. 
' 	
' The caller can optionally set the DaqTask property prior to calling ShowDialog().
' The Task that the caller passes in is expected to be verified.
' In this case, ConfigureDAQmxAcquisitionForm uses the Task settings as 
' initial configuration values. If the result of the ShowDialog call is 
' DialogResult.OK, ConfigureDAQmxAcquisitionForm disposes the Task. If the 
' DialogResult property value is DialogResult.Cancel, the Task is still valid. 
Public Class ConfigureDAQmxAcquisitionForm
    Inherits System.Windows.Forms.Form

    Private _task As Task

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        '
        ' Populate physicalChannelComboBox with the physical channels.
        ' 
        physicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External))

        '
        ' Populate terminalConfigurationComboBox with the possible terminal 
        ' types and initialize it to the most common value.
        '
        terminalConfigurationComboBox.Items.AddRange([Enum].GetNames(GetType(AITerminalConfiguration)))
        terminalConfigurationComboBox.SelectedItem = AITerminalConfiguration.Differential.ToString()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
            '
            ' We do not dispose the task here; the owner of this dialog
            ' is responsible for disposing the task.
            '
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents timingConfigurationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents samplingRateNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents samplingRateLabel As System.Windows.Forms.Label
    Friend WithEvents numberOfSamplesLabel As System.Windows.Forms.Label
    Friend WithEvents channelConfigurationGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents maximumValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents maximumValueLabel As System.Windows.Forms.Label
    Friend WithEvents terminalConfigurationComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents minimumValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents minimumValueLabel As System.Windows.Forms.Label
    Friend WithEvents terminalConfigurationLabel As System.Windows.Forms.Label
    Friend WithEvents physicalChannelLabel As System.Windows.Forms.Label
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents _cancelButton As System.Windows.Forms.Button
    Private WithEvents tdmsStreamingConfigurationGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents highSpeedTdmsStreamingCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents browseButton As System.Windows.Forms.Button
    Private WithEvents filePathTextBox As System.Windows.Forms.TextBox
    Private WithEvents filePathLabel As System.Windows.Forms.Label
    Private WithEvents tdmsFileSaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents physicalChannelComboBox As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.timingConfigurationGroupBox = New System.Windows.Forms.GroupBox
        Me.samplingRateNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.samplingRateLabel = New System.Windows.Forms.Label
        Me.numberOfSamplesLabel = New System.Windows.Forms.Label
        Me.channelConfigurationGroupBox = New System.Windows.Forms.GroupBox
        Me.physicalChannelComboBox = New System.Windows.Forms.ComboBox
        Me.maximumValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.maximumValueLabel = New System.Windows.Forms.Label
        Me.terminalConfigurationComboBox = New System.Windows.Forms.ComboBox
        Me.minimumValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.minimumValueLabel = New System.Windows.Forms.Label
        Me.terminalConfigurationLabel = New System.Windows.Forms.Label
        Me.physicalChannelLabel = New System.Windows.Forms.Label
        Me._cancelButton = New System.Windows.Forms.Button
        Me.okButton = New System.Windows.Forms.Button
        Me.tdmsStreamingConfigurationGroupBox = New System.Windows.Forms.GroupBox
        Me.highSpeedTdmsStreamingCheckBox = New System.Windows.Forms.CheckBox
        Me.browseButton = New System.Windows.Forms.Button
        Me.filePathTextBox = New System.Windows.Forms.TextBox
        Me.filePathLabel = New System.Windows.Forms.Label
        Me.tdmsFileSaveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.timingConfigurationGroupBox.SuspendLayout()
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.channelConfigurationGroupBox.SuspendLayout()
        CType(Me.maximumValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimumValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tdmsStreamingConfigurationGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'timingConfigurationGroupBox
        '
        Me.timingConfigurationGroupBox.Controls.Add(Me.samplingRateNumericEdit)
        Me.timingConfigurationGroupBox.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.timingConfigurationGroupBox.Controls.Add(Me.samplingRateLabel)
        Me.timingConfigurationGroupBox.Controls.Add(Me.numberOfSamplesLabel)
        Me.timingConfigurationGroupBox.Location = New System.Drawing.Point(7, 195)
        Me.timingConfigurationGroupBox.Name = "timingConfigurationGroupBox"
        Me.timingConfigurationGroupBox.Size = New System.Drawing.Size(312, 100)
        Me.timingConfigurationGroupBox.TabIndex = 18
        Me.timingConfigurationGroupBox.TabStop = False
        Me.timingConfigurationGroupBox.Text = "Timing Configuration"
        '
        'samplingRateNumericEdit
        '
        Me.samplingRateNumericEdit.CoercionInterval = 100
        Me.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.samplingRateNumericEdit.Location = New System.Drawing.Point(148, 55)
        Me.samplingRateNumericEdit.Name = "samplingRateNumericEdit"
        Me.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplingRateNumericEdit.Range = New NationalInstruments.UI.Range(0.001, 1000000)
        Me.samplingRateNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.samplingRateNumericEdit.TabIndex = 14
        Me.samplingRateNumericEdit.Value = 1000
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.CoercionInterval = 100
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(148, 23)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfSamplesNumericEdit.Range = New NationalInstruments.UI.Range(0, 100000)
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 12
        Me.numberOfSamplesNumericEdit.Value = 1000
        '
        'samplingRateLabel
        '
        Me.samplingRateLabel.Location = New System.Drawing.Point(12, 55)
        Me.samplingRateLabel.Name = "samplingRateLabel"
        Me.samplingRateLabel.Size = New System.Drawing.Size(129, 23)
        Me.samplingRateLabel.TabIndex = 13
        Me.samplingRateLabel.Text = "Sampling Rate:"
        '
        'numberOfSamplesLabel
        '
        Me.numberOfSamplesLabel.Location = New System.Drawing.Point(12, 23)
        Me.numberOfSamplesLabel.Name = "numberOfSamplesLabel"
        Me.numberOfSamplesLabel.Size = New System.Drawing.Size(129, 23)
        Me.numberOfSamplesLabel.TabIndex = 11
        Me.numberOfSamplesLabel.Text = "Number of Samples:"
        '
        'channelConfigurationGroupBox
        '
        Me.channelConfigurationGroupBox.Controls.Add(Me.physicalChannelComboBox)
        Me.channelConfigurationGroupBox.Controls.Add(Me.maximumValueNumericEdit)
        Me.channelConfigurationGroupBox.Controls.Add(Me.maximumValueLabel)
        Me.channelConfigurationGroupBox.Controls.Add(Me.terminalConfigurationComboBox)
        Me.channelConfigurationGroupBox.Controls.Add(Me.minimumValueNumericEdit)
        Me.channelConfigurationGroupBox.Controls.Add(Me.minimumValueLabel)
        Me.channelConfigurationGroupBox.Controls.Add(Me.terminalConfigurationLabel)
        Me.channelConfigurationGroupBox.Controls.Add(Me.physicalChannelLabel)
        Me.channelConfigurationGroupBox.Location = New System.Drawing.Point(7, 11)
        Me.channelConfigurationGroupBox.Name = "channelConfigurationGroupBox"
        Me.channelConfigurationGroupBox.Size = New System.Drawing.Size(312, 176)
        Me.channelConfigurationGroupBox.TabIndex = 17
        Me.channelConfigurationGroupBox.TabStop = False
        Me.channelConfigurationGroupBox.Text = "Channel Configuration"
        '
        'physicalChannelComboBox
        '
        Me.physicalChannelComboBox.Location = New System.Drawing.Point(152, 21)
        Me.physicalChannelComboBox.Name = "physicalChannelComboBox"
        Me.physicalChannelComboBox.Size = New System.Drawing.Size(152, 21)
        Me.physicalChannelComboBox.TabIndex = 11
        Me.physicalChannelComboBox.Text = "Dev1/ai0"
        '
        'maximumValueNumericEdit
        '
        Me.maximumValueNumericEdit.CoercionInterval = 10
        Me.maximumValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.maximumValueNumericEdit.Location = New System.Drawing.Point(152, 144)
        Me.maximumValueNumericEdit.Name = "maximumValueNumericEdit"
        Me.maximumValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.maximumValueNumericEdit.Range = New NationalInstruments.UI.Range(-10, 10)
        Me.maximumValueNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.maximumValueNumericEdit.TabIndex = 9
        Me.maximumValueNumericEdit.Value = 10
        '
        'maximumValueLabel
        '
        Me.maximumValueLabel.Location = New System.Drawing.Point(8, 144)
        Me.maximumValueLabel.Name = "maximumValueLabel"
        Me.maximumValueLabel.Size = New System.Drawing.Size(129, 23)
        Me.maximumValueLabel.TabIndex = 8
        Me.maximumValueLabel.Text = "Maximum Value:"
        '
        'terminalConfigurationComboBox
        '
        Me.terminalConfigurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.terminalConfigurationComboBox.Location = New System.Drawing.Point(152, 61)
        Me.terminalConfigurationComboBox.Name = "terminalConfigurationComboBox"
        Me.terminalConfigurationComboBox.Size = New System.Drawing.Size(152, 21)
        Me.terminalConfigurationComboBox.TabIndex = 5
        '
        'minimumValueNumericEdit
        '
        Me.minimumValueNumericEdit.CoercionInterval = 10
        Me.minimumValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.minimumValueNumericEdit.Location = New System.Drawing.Point(152, 101)
        Me.minimumValueNumericEdit.Name = "minimumValueNumericEdit"
        Me.minimumValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.minimumValueNumericEdit.Range = New NationalInstruments.UI.Range(-10, 10)
        Me.minimumValueNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.minimumValueNumericEdit.TabIndex = 7
        Me.minimumValueNumericEdit.Value = -10
        '
        'minimumValueLabel
        '
        Me.minimumValueLabel.Location = New System.Drawing.Point(8, 101)
        Me.minimumValueLabel.Name = "minimumValueLabel"
        Me.minimumValueLabel.Size = New System.Drawing.Size(129, 23)
        Me.minimumValueLabel.TabIndex = 6
        Me.minimumValueLabel.Text = "Minimum Value:"
        '
        'terminalConfigurationLabel
        '
        Me.terminalConfigurationLabel.Location = New System.Drawing.Point(8, 61)
        Me.terminalConfigurationLabel.Name = "terminalConfigurationLabel"
        Me.terminalConfigurationLabel.Size = New System.Drawing.Size(129, 23)
        Me.terminalConfigurationLabel.TabIndex = 4
        Me.terminalConfigurationLabel.Text = "Terminal Configuration:"
        '
        'physicalChannelLabel
        '
        Me.physicalChannelLabel.Location = New System.Drawing.Point(8, 21)
        Me.physicalChannelLabel.Name = "physicalChannelLabel"
        Me.physicalChannelLabel.Size = New System.Drawing.Size(129, 23)
        Me.physicalChannelLabel.TabIndex = 2
        Me.physicalChannelLabel.Text = "Physical Channel:"
        '
        '_cancelButton
        '
        Me._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._cancelButton.Location = New System.Drawing.Point(174, 410)
        Me._cancelButton.Name = "_cancelButton"
        Me._cancelButton.Size = New System.Drawing.Size(75, 23)
        Me._cancelButton.TabIndex = 20
        Me._cancelButton.Text = "&Cancel"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(78, 410)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(75, 23)
        Me.okButton.TabIndex = 19
        Me.okButton.Text = "&OK"
        '
        'tdmsStreamingConfigurationGroupBox
        '
        Me.tdmsStreamingConfigurationGroupBox.Controls.Add(Me.highSpeedTdmsStreamingCheckBox)
        Me.tdmsStreamingConfigurationGroupBox.Controls.Add(Me.browseButton)
        Me.tdmsStreamingConfigurationGroupBox.Controls.Add(Me.filePathTextBox)
        Me.tdmsStreamingConfigurationGroupBox.Controls.Add(Me.filePathLabel)
        Me.tdmsStreamingConfigurationGroupBox.Location = New System.Drawing.Point(8, 298)
        Me.tdmsStreamingConfigurationGroupBox.Name = "tdmsStreamingConfigurationGroupBox"
        Me.tdmsStreamingConfigurationGroupBox.Size = New System.Drawing.Size(312, 100)
        Me.tdmsStreamingConfigurationGroupBox.TabIndex = 22
        Me.tdmsStreamingConfigurationGroupBox.TabStop = False
        Me.tdmsStreamingConfigurationGroupBox.Text = "TDMS Streaming Configuration"
        '
        'highSpeedTdmsStreamingCheckBox
        '
        Me.highSpeedTdmsStreamingCheckBox.AutoSize = True
        Me.highSpeedTdmsStreamingCheckBox.Location = New System.Drawing.Point(12, 23)
        Me.highSpeedTdmsStreamingCheckBox.Name = "highSpeedTdmsStreamingCheckBox"
        Me.highSpeedTdmsStreamingCheckBox.Size = New System.Drawing.Size(202, 17)
        Me.highSpeedTdmsStreamingCheckBox.TabIndex = 5
        Me.highSpeedTdmsStreamingCheckBox.Text = "Enable High-Speed TDMS Streaming"
        Me.highSpeedTdmsStreamingCheckBox.UseVisualStyleBackColor = True
        '
        'browseButton
        '
        Me.browseButton.Enabled = False
        Me.browseButton.Location = New System.Drawing.Point(275, 54)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(25, 22)
        Me.browseButton.TabIndex = 4
        Me.browseButton.Text = "..."
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'filePathTextBox
        '
        Me.filePathTextBox.Enabled = False
        Me.filePathTextBox.Location = New System.Drawing.Point(148, 55)
        Me.filePathTextBox.Name = "filePathTextBox"
        Me.filePathTextBox.Size = New System.Drawing.Size(125, 20)
        Me.filePathTextBox.TabIndex = 3
        Me.filePathTextBox.Text = "waveforms.tdms"
        '
        'filePathLabel
        '
        Me.filePathLabel.Location = New System.Drawing.Point(12, 55)
        Me.filePathLabel.Name = "filePathLabel"
        Me.filePathLabel.Size = New System.Drawing.Size(129, 23)
        Me.filePathLabel.TabIndex = 2
        Me.filePathLabel.Text = "File Path:"
        '
        'tdmsFileSaveFileDialog
        '
        Me.tdmsFileSaveFileDialog.FileName = "waveforms.tdms"
        Me.tdmsFileSaveFileDialog.Filter = "TDMS files|*.tdms"
        Me.tdmsFileSaveFileDialog.Title = "Save TDMS file as"
        '
        'ConfigureDAQmxAcquisitionForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(328, 448)
        Me.Controls.Add(Me.tdmsStreamingConfigurationGroupBox)
        Me.Controls.Add(Me.timingConfigurationGroupBox)
        Me.Controls.Add(Me.channelConfigurationGroupBox)
        Me.Controls.Add(Me._cancelButton)
        Me.Controls.Add(Me.okButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ConfigureDAQmxAcquisitionForm"
        Me.Text = "Configure DAQmx Acquisition "
        Me.timingConfigurationGroupBox.ResumeLayout(False)
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.channelConfigurationGroupBox.ResumeLayout(False)
        CType(Me.maximumValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimumValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tdmsStreamingConfigurationGroupBox.ResumeLayout(False)
        Me.tdmsStreamingConfigurationGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    ' The task being configured. The caller can specify an initial task
    ' before calling ShowDialog(). If ShowDialog() returns DialogResult.OK,
    ' the caller must take ownership of the underlying task object and
    ' call Dispose on it as appropriate.
    Public Property DaqTask() As Task
        Get
            Return _task
        End Get
        Set(ByVal Value As Task)
            _task = Value
        End Set
    End Property

    Private Sub ConfigureDAQmxAcquisitionForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateControls()
    End Sub

    Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
        '
        ' Create a temporary task so that we don't modify the existing task
        ' if an error occurs verifying the task.
        '
        Dim newTask As Task = Nothing
        Try
            newTask = New Task

            If Not ConfigureTaskFromControls(newTask) Then
                newTask.Dispose()
                Return
            End If
            If Not _task Is Nothing Then

                '
                ' We dispose the original task. The caller is expected
                ' to get a reference to the new task through the Task
                ' property.
                '
                _task.Dispose()
            End If
            _task = newTask
            DialogResult = Windows.Forms.DialogResult.OK
            Close()

        Catch ex As Exception
            If Not newTask Is Nothing Then
                newTask.Dispose()
            End If
            Throw
        End Try
    End Sub

    Private Function ConfigureTaskFromControls(ByVal daqTask As Task) As Boolean
        Try
            daqTask.AIChannels.CreateVoltageChannel(physicalChannelComboBox.Text, "Voltage", DirectCast([Enum].Parse(GetType(AITerminalConfiguration), terminalConfigurationComboBox.SelectedItem.ToString()), AITerminalConfiguration), minimumValueNumericEdit.Value, maximumValueNumericEdit.Value, AIVoltageUnits.Volts)
            daqTask.Timing.ConfigureSampleClock("", samplingRateNumericEdit.Value, SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, CType(numberOfSamplesNumericEdit.Value, Integer))
            If highSpeedTdmsStreamingCheckBox.Checked Then
                daqTask.ConfigureLogging(filePathTextBox.Text, TdmsLoggingOperation.CreateOrReplace, LoggingMode.LogAndRead, "TdmsDataProcessorExample")
            Else
                daqTask.Stream.LoggingMode = LoggingMode.Off
            End If
            daqTask.Control(TaskAction.Verify)
        Catch ex As DaqException
            MessageBox.Show(ex.Message, "Error Configuring DAQ Task")
            Return False
        End Try

        Return True
    End Function
    Private Sub PopulateControls()
        If _task Is Nothing Then
            '
            ' No previous task information. Use the control default values.
            '
            Return
        End If
        If _task.AIChannels.Count = 0 Then
            '
            ' No previous channel information. Use the control default values.
            '
            Return
        End If
        Dim channel As AIChannel = _task.AIChannels(0)
        physicalChannelComboBox.Text = channel.PhysicalName

        terminalConfigurationComboBox.SelectedItem = channel.TerminalConfiguration.ToString()

        minimumValueNumericEdit.Value = channel.Minimum
        maximumValueNumericEdit.Value = channel.Maximum

        numberOfSamplesNumericEdit.Value = _task.Timing.SamplesPerChannel
        samplingRateNumericEdit.Value = _task.Timing.SampleClockRate

        If _task.Stream.LoggingMode = LoggingMode.LogAndRead Then
            highSpeedTdmsStreamingCheckBox.Checked = True
            filePathTextBox.Text = _task.Stream.LoggingFilePath
        Else
            highSpeedTdmsStreamingCheckBox.Checked = False
        End If
    End Sub

    Private Sub highSpeedTdmsStreamingCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles highSpeedTdmsStreamingCheckBox.CheckedChanged
        filePathTextBox.Enabled = highSpeedTdmsStreamingCheckBox.Checked
        browseButton.Enabled = highSpeedTdmsStreamingCheckBox.Checked
    End Sub

    Private Sub browseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseButton.Click
        If tdmsFileSaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            filePathTextBox.Text = tdmsFileSaveFileDialog.FileName
        End If
    End Sub
End Class
