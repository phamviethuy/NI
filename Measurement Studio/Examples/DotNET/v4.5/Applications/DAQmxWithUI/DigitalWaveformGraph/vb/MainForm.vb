Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents channelParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lineGroupingLabel As System.Windows.Forms.Label
    Friend WithEvents channelConfigComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents physicalChannelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents readButton As System.Windows.Forms.Button
    Friend WithEvents timingParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents samplesToReadLabel As System.Windows.Forms.Label
    Friend WithEvents samplesPerChannelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents samplingRateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents samplingRateLabel As System.Windows.Forms.Label
    Friend WithEvents taskGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents newTaskRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents existingTaskRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents savedTaskComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents savedTaskLabel As System.Windows.Forms.Label
    Friend WithEvents graphGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents graphHelpLabel As System.Windows.Forms.Label
    Friend WithEvents graphParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents daqmxPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents sampleClockSourceLabel As System.Windows.Forms.Label
    Friend WithEvents sampleClockSourceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents daqmxDigitalWaveformGraph As NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
    Friend WithEvents physicalChannelLabel As System.Windows.Forms.Label
    Friend WithEvents toUnDoZoomLabel As System.Windows.Forms.Label
    Friend WithEvents toPanLabel As System.Windows.Forms.Label
    Friend WithEvents ToUndoPanLabel As System.Windows.Forms.Label
    Friend WithEvents toUndoAllZoomsOrPansLabel As System.Windows.Forms.Label
    Friend WithEvents graphAxisFormatLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.daqmxDigitalWaveformGraph = New NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
        Me.channelParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.physicalChannelLabel = New System.Windows.Forms.Label
        Me.lineGroupingLabel = New System.Windows.Forms.Label
        Me.channelConfigComboBox = New System.Windows.Forms.ComboBox
        Me.physicalChannelTextBox = New System.Windows.Forms.TextBox
        Me.readButton = New System.Windows.Forms.Button
        Me.timingParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.samplesToReadLabel = New System.Windows.Forms.Label
        Me.samplesPerChannelTextBox = New System.Windows.Forms.TextBox
        Me.samplingRateTextBox = New System.Windows.Forms.TextBox
        Me.samplingRateLabel = New System.Windows.Forms.Label
        Me.sampleClockSourceTextBox = New System.Windows.Forms.TextBox
        Me.sampleClockSourceLabel = New System.Windows.Forms.Label
        Me.taskGroupBox = New System.Windows.Forms.GroupBox
        Me.newTaskRadioButton = New System.Windows.Forms.RadioButton
        Me.existingTaskRadioButton = New System.Windows.Forms.RadioButton
        Me.savedTaskComboBox = New System.Windows.Forms.ComboBox
        Me.savedTaskLabel = New System.Windows.Forms.Label
        Me.graphGroupBox = New System.Windows.Forms.GroupBox
        Me.graphHelpLabel = New System.Windows.Forms.Label
        Me.toUnDoZoomLabel = New System.Windows.Forms.Label
        Me.toPanLabel = New System.Windows.Forms.Label
        Me.ToUndoPanLabel = New System.Windows.Forms.Label
        Me.toUndoAllZoomsOrPansLabel = New System.Windows.Forms.Label
        Me.graphParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.daqmxPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.graphAxisFormatLabel = New System.Windows.Forms.Label
        CType(Me.daqmxDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.channelParametersGroupBox.SuspendLayout()
        Me.timingParametersGroupBox.SuspendLayout()
        Me.taskGroupBox.SuspendLayout()
        Me.graphGroupBox.SuspendLayout()
        Me.graphParametersGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'daqmxDigitalWaveformGraph
        '
        Me.daqmxDigitalWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.daqmxDigitalWaveformGraph.Location = New System.Drawing.Point(8, 235)
        Me.daqmxDigitalWaveformGraph.Name = "daqmxDigitalWaveformGraph"
        Me.daqmxDigitalWaveformGraph.Size = New System.Drawing.Size(856, 264)
        Me.daqmxDigitalWaveformGraph.TabIndex = 7
        '
        'channelParametersGroupBox
        '
        Me.channelParametersGroupBox.Controls.Add(Me.physicalChannelLabel)
        Me.channelParametersGroupBox.Controls.Add(Me.lineGroupingLabel)
        Me.channelParametersGroupBox.Controls.Add(Me.channelConfigComboBox)
        Me.channelParametersGroupBox.Controls.Add(Me.physicalChannelTextBox)
        Me.channelParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.channelParametersGroupBox.Location = New System.Drawing.Point(8, 107)
        Me.channelParametersGroupBox.Name = "channelParametersGroupBox"
        Me.channelParametersGroupBox.Size = New System.Drawing.Size(304, 88)
        Me.channelParametersGroupBox.TabIndex = 12
        Me.channelParametersGroupBox.TabStop = False
        Me.channelParametersGroupBox.Text = "Channel Parameters"
        '
        'physicalChannelLabel
        '
        Me.physicalChannelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.physicalChannelLabel.Location = New System.Drawing.Point(16, 24)
        Me.physicalChannelLabel.Name = "physicalChannelLabel"
        Me.physicalChannelLabel.Size = New System.Drawing.Size(96, 16)
        Me.physicalChannelLabel.TabIndex = 5
        Me.physicalChannelLabel.Text = "Physical Channel:"
        '
        'lineGroupingLabel
        '
        Me.lineGroupingLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lineGroupingLabel.Location = New System.Drawing.Point(16, 48)
        Me.lineGroupingLabel.Name = "lineGroupingLabel"
        Me.lineGroupingLabel.Size = New System.Drawing.Size(96, 16)
        Me.lineGroupingLabel.TabIndex = 5
        Me.lineGroupingLabel.Text = "Line Grouping:"
        '
        'channelConfigComboBox
        '
        Me.channelConfigComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.channelConfigComboBox.Items.AddRange(New Object() {"One channel for each line", "One channel for all lines"})
        Me.channelConfigComboBox.Location = New System.Drawing.Point(128, 48)
        Me.channelConfigComboBox.Name = "channelConfigComboBox"
        Me.channelConfigComboBox.Size = New System.Drawing.Size(160, 21)
        Me.channelConfigComboBox.TabIndex = 4
        '
        'physicalChannelTextBox
        '
        Me.physicalChannelTextBox.Location = New System.Drawing.Point(128, 24)
        Me.physicalChannelTextBox.Name = "physicalChannelTextBox"
        Me.physicalChannelTextBox.Size = New System.Drawing.Size(160, 20)
        Me.physicalChannelTextBox.TabIndex = 0
        Me.physicalChannelTextBox.Text = "Dev1/port0/line7:0"
        '
        'readButton
        '
        Me.readButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.readButton.Location = New System.Drawing.Point(384, 203)
        Me.readButton.Name = "readButton"
        Me.readButton.TabIndex = 8
        Me.readButton.Text = "&Read"
        '
        'timingParametersGroupBox
        '
        Me.timingParametersGroupBox.Controls.Add(Me.samplesToReadLabel)
        Me.timingParametersGroupBox.Controls.Add(Me.samplesPerChannelTextBox)
        Me.timingParametersGroupBox.Controls.Add(Me.samplingRateTextBox)
        Me.timingParametersGroupBox.Controls.Add(Me.samplingRateLabel)
        Me.timingParametersGroupBox.Controls.Add(Me.sampleClockSourceTextBox)
        Me.timingParametersGroupBox.Controls.Add(Me.sampleClockSourceLabel)
        Me.timingParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.timingParametersGroupBox.Location = New System.Drawing.Point(320, 11)
        Me.timingParametersGroupBox.Name = "timingParametersGroupBox"
        Me.timingParametersGroupBox.Size = New System.Drawing.Size(304, 109)
        Me.timingParametersGroupBox.TabIndex = 13
        Me.timingParametersGroupBox.TabStop = False
        Me.timingParametersGroupBox.Text = "Timing Parameters"
        '
        'samplesToReadLabel
        '
        Me.samplesToReadLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplesToReadLabel.Location = New System.Drawing.Point(16, 24)
        Me.samplesToReadLabel.Name = "samplesToReadLabel"
        Me.samplesToReadLabel.Size = New System.Drawing.Size(96, 16)
        Me.samplesToReadLabel.TabIndex = 5
        Me.samplesToReadLabel.Text = "Sample to read:"
        '
        'samplesPerChannelTextBox
        '
        Me.samplesPerChannelTextBox.Location = New System.Drawing.Point(128, 24)
        Me.samplesPerChannelTextBox.Name = "samplesPerChannelTextBox"
        Me.samplesPerChannelTextBox.Size = New System.Drawing.Size(160, 20)
        Me.samplesPerChannelTextBox.TabIndex = 1
        Me.samplesPerChannelTextBox.Text = "20"
        '
        'samplingRateTextBox
        '
        Me.samplingRateTextBox.Location = New System.Drawing.Point(128, 48)
        Me.samplingRateTextBox.Name = "samplingRateTextBox"
        Me.samplingRateTextBox.Size = New System.Drawing.Size(160, 20)
        Me.samplingRateTextBox.TabIndex = 1
        Me.samplingRateTextBox.Text = "1000"
        '
        'samplingRateLabel
        '
        Me.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplingRateLabel.Location = New System.Drawing.Point(16, 48)
        Me.samplingRateLabel.Name = "samplingRateLabel"
        Me.samplingRateLabel.Size = New System.Drawing.Size(104, 16)
        Me.samplingRateLabel.TabIndex = 5
        Me.samplingRateLabel.Text = "Sampling Rate (Hz):"
        '
        'sampleClockSourceTextBox
        '
        Me.sampleClockSourceTextBox.Location = New System.Drawing.Point(128, 72)
        Me.sampleClockSourceTextBox.Name = "sampleClockSourceTextBox"
        Me.sampleClockSourceTextBox.Size = New System.Drawing.Size(160, 20)
        Me.sampleClockSourceTextBox.TabIndex = 1
        Me.sampleClockSourceTextBox.Text = "OnboardClock"
        '
        'sampleClockSourceLabel
        '
        Me.sampleClockSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.sampleClockSourceLabel.Location = New System.Drawing.Point(16, 72)
        Me.sampleClockSourceLabel.Name = "sampleClockSourceLabel"
        Me.sampleClockSourceLabel.Size = New System.Drawing.Size(104, 16)
        Me.sampleClockSourceLabel.TabIndex = 5
        Me.sampleClockSourceLabel.Text = "Sampling Clock"
        '
        'taskGroupBox
        '
        Me.taskGroupBox.Controls.Add(Me.newTaskRadioButton)
        Me.taskGroupBox.Controls.Add(Me.existingTaskRadioButton)
        Me.taskGroupBox.Controls.Add(Me.savedTaskComboBox)
        Me.taskGroupBox.Controls.Add(Me.savedTaskLabel)
        Me.taskGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.taskGroupBox.Location = New System.Drawing.Point(8, 11)
        Me.taskGroupBox.Name = "taskGroupBox"
        Me.taskGroupBox.Size = New System.Drawing.Size(304, 96)
        Me.taskGroupBox.TabIndex = 11
        Me.taskGroupBox.TabStop = False
        Me.taskGroupBox.Text = "Task"
        '
        'newTaskRadioButton
        '
        Me.newTaskRadioButton.Checked = True
        Me.newTaskRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.newTaskRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.newTaskRadioButton.Name = "newTaskRadioButton"
        Me.newTaskRadioButton.Size = New System.Drawing.Size(120, 16)
        Me.newTaskRadioButton.TabIndex = 0
        Me.newTaskRadioButton.TabStop = True
        Me.newTaskRadioButton.Text = "Create a new Task"
        '
        'existingTaskRadioButton
        '
        Me.existingTaskRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.existingTaskRadioButton.Location = New System.Drawing.Point(16, 40)
        Me.existingTaskRadioButton.Name = "existingTaskRadioButton"
        Me.existingTaskRadioButton.Size = New System.Drawing.Size(152, 16)
        Me.existingTaskRadioButton.TabIndex = 0
        Me.existingTaskRadioButton.Text = "Use a Task saved in MAX"
        '
        'savedTaskComboBox
        '
        Me.savedTaskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.savedTaskComboBox.Enabled = False
        Me.savedTaskComboBox.Location = New System.Drawing.Point(128, 64)
        Me.savedTaskComboBox.Name = "savedTaskComboBox"
        Me.savedTaskComboBox.Size = New System.Drawing.Size(160, 21)
        Me.savedTaskComboBox.TabIndex = 4
        '
        'savedTaskLabel
        '
        Me.savedTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.savedTaskLabel.Location = New System.Drawing.Point(16, 64)
        Me.savedTaskLabel.Name = "savedTaskLabel"
        Me.savedTaskLabel.Size = New System.Drawing.Size(104, 16)
        Me.savedTaskLabel.TabIndex = 5
        Me.savedTaskLabel.Text = "Saved Task Name:"
        '
        'graphGroupBox
        '
        Me.graphGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graphGroupBox.Controls.Add(Me.graphHelpLabel)
        Me.graphGroupBox.Controls.Add(Me.toUnDoZoomLabel)
        Me.graphGroupBox.Controls.Add(Me.toPanLabel)
        Me.graphGroupBox.Controls.Add(Me.ToUndoPanLabel)
        Me.graphGroupBox.Controls.Add(Me.toUndoAllZoomsOrPansLabel)
        Me.graphGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.graphGroupBox.Location = New System.Drawing.Point(632, 11)
        Me.graphGroupBox.Name = "graphGroupBox"
        Me.graphGroupBox.Size = New System.Drawing.Size(232, 184)
        Me.graphGroupBox.TabIndex = 9
        Me.graphGroupBox.TabStop = False
        Me.graphGroupBox.Text = "Using the Graph"
        '
        'graphHelpLabel
        '
        Me.graphHelpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.graphHelpLabel.Location = New System.Drawing.Point(16, 32)
        Me.graphHelpLabel.Name = "graphHelpLabel"
        Me.graphHelpLabel.Size = New System.Drawing.Size(192, 16)
        Me.graphHelpLabel.TabIndex = 7
        Me.graphHelpLabel.Text = "To Zoom :  <Shift> + left click or drag"
        '
        'toUnDoZoomLabel
        '
        Me.toUnDoZoomLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toUnDoZoomLabel.Location = New System.Drawing.Point(16, 56)
        Me.toUnDoZoomLabel.Name = "toUnDoZoomLabel"
        Me.toUnDoZoomLabel.Size = New System.Drawing.Size(192, 16)
        Me.toUnDoZoomLabel.TabIndex = 7
        Me.toUnDoZoomLabel.Text = "To Undo Zoom :  <Shift> + right click"
        '
        'toPanLabel
        '
        Me.toPanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toPanLabel.Location = New System.Drawing.Point(16, 80)
        Me.toPanLabel.Name = "toPanLabel"
        Me.toPanLabel.Size = New System.Drawing.Size(128, 16)
        Me.toPanLabel.TabIndex = 7
        Me.toPanLabel.Text = "To Pan :  <Ctrl> + drag"
        '
        'ToUndoPanLabel
        '
        Me.ToUndoPanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ToUndoPanLabel.Location = New System.Drawing.Point(16, 104)
        Me.ToUndoPanLabel.Name = "ToUndoPanLabel"
        Me.ToUndoPanLabel.Size = New System.Drawing.Size(208, 16)
        Me.ToUndoPanLabel.TabIndex = 7
        Me.ToUndoPanLabel.Text = "To Undo Pan :  <Ctrl> + right click"
        '
        'toUndoAllZoomsOrPansLabel
        '
        Me.toUndoAllZoomsOrPansLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toUndoAllZoomsOrPansLabel.Location = New System.Drawing.Point(16, 128)
        Me.toUndoAllZoomsOrPansLabel.Name = "toUndoAllZoomsOrPansLabel"
        Me.toUndoAllZoomsOrPansLabel.Size = New System.Drawing.Size(208, 24)
        Me.toUndoAllZoomsOrPansLabel.TabIndex = 7
        Me.toUndoAllZoomsOrPansLabel.Text = "To Undo All Zooms or Pans: <Ctrl> + <Alt> + <Backspace>"
        '
        'graphParametersGroupBox
        '
        Me.graphParametersGroupBox.Controls.Add(Me.daqmxPropertyEditor)
        Me.graphParametersGroupBox.Controls.Add(Me.graphAxisFormatLabel)
        Me.graphParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.graphParametersGroupBox.Location = New System.Drawing.Point(320, 123)
        Me.graphParametersGroupBox.Name = "graphParametersGroupBox"
        Me.graphParametersGroupBox.Size = New System.Drawing.Size(304, 72)
        Me.graphParametersGroupBox.TabIndex = 10
        Me.graphParametersGroupBox.TabStop = False
        Me.graphParametersGroupBox.Text = "Graph Parameters"
        '
        'daqmxPropertyEditor
        '
        Me.daqmxPropertyEditor.Location = New System.Drawing.Point(128, 32)
        Me.daqmxPropertyEditor.Name = "daqmxPropertyEditor"
        Me.daqmxPropertyEditor.Size = New System.Drawing.Size(160, 20)
        Me.daqmxPropertyEditor.TabIndex = 7
        '
        'graphAxisFormatLabel
        '
        Me.graphAxisFormatLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.graphAxisFormatLabel.Location = New System.Drawing.Point(16, 32)
        Me.graphAxisFormatLabel.Name = "graphAxisFormatLabel"
        Me.graphAxisFormatLabel.Size = New System.Drawing.Size(104, 16)
        Me.graphAxisFormatLabel.TabIndex = 5
        Me.graphAxisFormatLabel.Text = "Axis Format:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(872, 510)
        Me.Controls.Add(Me.daqmxDigitalWaveformGraph)
        Me.Controls.Add(Me.channelParametersGroupBox)
        Me.Controls.Add(Me.readButton)
        Me.Controls.Add(Me.timingParametersGroupBox)
        Me.Controls.Add(Me.taskGroupBox)
        Me.Controls.Add(Me.graphGroupBox)
        Me.Controls.Add(Me.graphParametersGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Digital Waveform Graph with DAQmx"
        CType(Me.daqmxDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.channelParametersGroupBox.ResumeLayout(False)
        Me.timingParametersGroupBox.ResumeLayout(False)
        Me.taskGroupBox.ResumeLayout(False)
        Me.graphGroupBox.ResumeLayout(False)
        Me.graphParametersGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub 'Main

    Private Sub Read(ByVal t As Task)
        Dim reader As New DigitalMultiChannelReader(t.Stream)

        Dim data As DigitalWaveform() = reader.ReadWaveform(System.Int32.Parse(samplesPerChannelTextBox.Text))

        daqmxDigitalWaveformGraph.PlotWaveforms(data)
    End Sub 'Read

    Private Sub readButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles readButton.Click
        Try
            If existingTaskRadioButton.Checked Then
                ' Load a task from MAX
                Dim t As Task = DaqSystem.Local.LoadTask(savedTaskComboBox.Text)
                Try
                    Read(t)
                Finally
                    t.Dispose()
                End Try
            Else
                ' Create a new task
                Dim t As New Task(Nothing)
                Try
                    Dim grouping As ChannelLineGrouping = ChannelLineGrouping.OneChannelForAllLines
                    If channelConfigComboBox.Text = "One channel for each line" Then
                        grouping = ChannelLineGrouping.OneChannelForEachLine
                    End If

                    t.DIChannels.CreateChannel(physicalChannelTextBox.Text, Nothing, grouping)

                    t.Timing.ConfigureSampleClock(sampleClockSourceTextBox.Text, System.Double.Parse(samplingRateTextBox.Text), _
                        SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, System.Int32.Parse(samplesPerChannelTextBox.Text))

                    Read(t)
                Finally
                    t.Dispose()
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub existingTaskRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles existingTaskRadioButton.CheckedChanged
        Dim existing As Boolean = existingTaskRadioButton.Checked

        ' Dim controls as necessary
        channelParametersGroupBox.Enabled = Not existing
        timingParametersGroupBox.Enabled = Not existing
        savedTaskComboBox.Enabled = existing

        If existing Then
            ' Repopulate tasks from MAX
            savedTaskComboBox.Items.Clear()
            savedTaskComboBox.Items.AddRange(DaqSystem.Local.Tasks)
            If savedTaskComboBox.Items.Count >= 1 Then
                savedTaskComboBox.SelectedIndex = 0
            End If
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        channelConfigComboBox.SelectedIndex = 1
        daqmxPropertyEditor.Source = New PropertyEditorSource(daqmxDigitalWaveformGraph.XAxis.MajorDivisions, "LabelFormat")
    End Sub
End Class
