'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' Example program:
'   GlobalDigitalPortIO_USB
'
' Description:
'   This example shows how to load a digital port input/output task from the Measurement & 
'   Automation Explorer (MAX) and use it to read/write the lowest 8 bits from/to the digital port.
'   This example should also work with E-Series and M-Series devices.
'
' Instructions for running:
'   1.  Create an on demand digital port I/O NI-DAQmx global task in MAX. For help, refer to 
'       "Creating Tasks and Channels" in the Measurement & Automation Explorer Help. 
'       To access this help, select Start>>All Programs>>National Instruments>>
'       Measurement & Automation. In MAX, select Help>>MAX Help.
'
'       Note: If you prefer, you can import an on demand digital port I/O task and a simulated USB
'       device into MAX from the GlobalDigitalPort[Input/Output]_USB.nce file, which is located in the 
'       example directory. Refer to "Using the Configuration Import Wizard" in the 
'       Measurement & Automation Explorer Help for more information.
'
'   2.  Run the application, select the task from the drop-down list, and then toggle to switches
'       to write values to the port or click the Read button to read values from the port
'
' Steps:
'  Write
'   1.  Load the task from MAX.
'   2.  Create a DigitalSingleChannelWriter and call WriteSingleSamplePort to write the data
'       to the digital port.
'  Read
'   1.  Load the task from MAX.
'   2.  Create a DigitalSingleChannelReader and call ReadSingleSamplePortInt32 to read the data
'       from the digital port.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports NationalInstruments.DAQmx
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms


Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private line7Switch As NationalInstruments.UI.WindowsForms.Switch
    Private line7Led As NationalInstruments.UI.WindowsForms.Led
    Private writeGroupBox As System.Windows.Forms.GroupBox
    Private line6Switch As NationalInstruments.UI.WindowsForms.Switch
    Private line5Switch As NationalInstruments.UI.WindowsForms.Switch
    Private line4Switch As NationalInstruments.UI.WindowsForms.Switch
    Private line3Switch As NationalInstruments.UI.WindowsForms.Switch
    Private line2Switch As NationalInstruments.UI.WindowsForms.Switch
    Private line1Switch As NationalInstruments.UI.WindowsForms.Switch
    Private line0Switch As NationalInstruments.UI.WindowsForms.Switch
    Private readGroupBox As System.Windows.Forms.GroupBox
    Private line6Led As NationalInstruments.UI.WindowsForms.Led
    Private line5Led As NationalInstruments.UI.WindowsForms.Led
    Private line4Led As NationalInstruments.UI.WindowsForms.Led
    Private line3Led As NationalInstruments.UI.WindowsForms.Led
    Private line2Led As NationalInstruments.UI.WindowsForms.Led
    Private line1Led As NationalInstruments.UI.WindowsForms.Led
    Private line0Led As NationalInstruments.UI.WindowsForms.Led
    Private readButton As System.Windows.Forms.Button
    Private writeLabel As Label
    Private writeComboBox As ComboBox
    Private readLabel As Label
    Private readComboBox As ComboBox
    Private infoLabel As Label
    Private readInfoLabel As Label
    Private ledLine7Label As Label
    Private ledLine0Label As Label
    Private switchLine7Label As Label
    Private switchLine0Label As Label
    Private resettingSwitches As Boolean
    Private components As System.ComponentModel.Container = Nothing
    Private digitalWriteTask As Task
    Private digitalReadTask As Task


    Public Sub New()
        MyBase.New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        readButton.Enabled = False

        ' Add valid digital input and output tasks to the combo boxes
        Dim t As Task = Nothing

        For Each s As String In DaqSystem.Local.Tasks
            Try
                t = DaqSystem.Local.LoadTask(s)
                t.Control(TaskAction.Verify)
                If ((t.DOChannels.Count > 0) _
                            AndAlso (t.Timing.SampleTimingType = SampleTimingType.OnDemand)) Then
                    writeComboBox.Items.Add(s)
                    readComboBox.Items.Add(s)
                End If
                If ((t.DIChannels.Count > 0) _
                            AndAlso (t.Timing.SampleTimingType = SampleTimingType.OnDemand)) Then
                    readComboBox.Items.Add(s)
                End If
            Catch ex As DaqException
                ' Ignore invalid tasks
            Finally
                If Not t Is Nothing Then
                    t.Dispose()
                End If
            End Try
        Next

        ' By default select the first item in the combo boxes
        If (writeComboBox.Items.Count > 0) Then
            writeComboBox.SelectedIndex = 0
        End If
        If (readComboBox.Items.Count > 0) Then
            readComboBox.SelectedIndex = 0
            readButton.Enabled = True
        End If
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If (Not (components) Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.line7Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.line7Led = New NationalInstruments.UI.WindowsForms.Led
        Me.writeGroupBox = New System.Windows.Forms.GroupBox
        Me.switchLine7Label = New System.Windows.Forms.Label
        Me.switchLine0Label = New System.Windows.Forms.Label
        Me.infoLabel = New System.Windows.Forms.Label
        Me.writeLabel = New System.Windows.Forms.Label
        Me.writeComboBox = New System.Windows.Forms.ComboBox
        Me.line6Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.line5Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.line4Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.line3Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.line2Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.line1Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.line0Switch = New NationalInstruments.UI.WindowsForms.Switch
        Me.readGroupBox = New System.Windows.Forms.GroupBox
        Me.ledLine7Label = New System.Windows.Forms.Label
        Me.ledLine0Label = New System.Windows.Forms.Label
        Me.readInfoLabel = New System.Windows.Forms.Label
        Me.readLabel = New System.Windows.Forms.Label
        Me.readComboBox = New System.Windows.Forms.ComboBox
        Me.readButton = New System.Windows.Forms.Button
        Me.line6Led = New NationalInstruments.UI.WindowsForms.Led
        Me.line5Led = New NationalInstruments.UI.WindowsForms.Led
        Me.line4Led = New NationalInstruments.UI.WindowsForms.Led
        Me.line3Led = New NationalInstruments.UI.WindowsForms.Led
        Me.line2Led = New NationalInstruments.UI.WindowsForms.Led
        Me.line1Led = New NationalInstruments.UI.WindowsForms.Led
        Me.line0Led = New NationalInstruments.UI.WindowsForms.Led
        CType(Me.line7Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line7Led, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.writeGroupBox.SuspendLayout()
        CType(Me.line6Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line5Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line4Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line3Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line2Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line1Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line0Switch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.readGroupBox.SuspendLayout()
        CType(Me.line6Led, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line5Led, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line4Led, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line3Led, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line2Led, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line1Led, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.line0Led, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'line7Switch
        '
        Me.line7Switch.Location = New System.Drawing.Point(16, 73)
        Me.line7Switch.Name = "line7Switch"
        Me.line7Switch.Size = New System.Drawing.Size(40, 70)
        Me.line7Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line7Switch.TabIndex = 0
        AddHandler line7Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'line7Led
        '
        Me.line7Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line7Led.Location = New System.Drawing.Point(16, 94)
        Me.line7Led.Name = "line7Led"
        Me.line7Led.Size = New System.Drawing.Size(35, 35)
        Me.line7Led.TabIndex = 1
        '
        'writeGroupBox
        '
        Me.writeGroupBox.Controls.Add(Me.switchLine7Label)
        Me.writeGroupBox.Controls.Add(Me.switchLine0Label)
        Me.writeGroupBox.Controls.Add(Me.infoLabel)
        Me.writeGroupBox.Controls.Add(Me.writeLabel)
        Me.writeGroupBox.Controls.Add(Me.writeComboBox)
        Me.writeGroupBox.Controls.Add(Me.line7Switch)
        Me.writeGroupBox.Controls.Add(Me.line6Switch)
        Me.writeGroupBox.Controls.Add(Me.line5Switch)
        Me.writeGroupBox.Controls.Add(Me.line4Switch)
        Me.writeGroupBox.Controls.Add(Me.line3Switch)
        Me.writeGroupBox.Controls.Add(Me.line2Switch)
        Me.writeGroupBox.Controls.Add(Me.line1Switch)
        Me.writeGroupBox.Controls.Add(Me.line0Switch)
        Me.writeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.writeGroupBox.Location = New System.Drawing.Point(40, 16)
        Me.writeGroupBox.Name = "writeGroupBox"
        Me.writeGroupBox.Size = New System.Drawing.Size(745, 156)
        Me.writeGroupBox.TabIndex = 2
        Me.writeGroupBox.TabStop = False
        Me.writeGroupBox.Text = "Digital Write"
        '
        'switchLine7Label
        '
        Me.switchLine7Label.AutoSize = True
        Me.switchLine7Label.Location = New System.Drawing.Point(30, 136)
        Me.switchLine7Label.Name = "switchLine7Label"
        Me.switchLine7Label.Size = New System.Drawing.Size(13, 13)
        Me.switchLine7Label.TabIndex = 8
        Me.switchLine7Label.Text = "7"
        '
        'switchLine0Label
        '
        Me.switchLine0Label.AutoSize = True
        Me.switchLine0Label.Location = New System.Drawing.Point(422, 137)
        Me.switchLine0Label.Name = "switchLine0Label"
        Me.switchLine0Label.Size = New System.Drawing.Size(13, 13)
        Me.switchLine0Label.TabIndex = 7
        Me.switchLine0Label.Text = "0"
        '
        'infoLabel
        '
        Me.infoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.infoLabel.Location = New System.Drawing.Point(475, 32)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(264, 96)
        Me.infoLabel.TabIndex = 6
        Me.infoLabel.Text = resources.GetString("infoLabel.Text")
        '
        'writeLabel
        '
        Me.writeLabel.AutoSize = True
        Me.writeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.writeLabel.Location = New System.Drawing.Point(21, 40)
        Me.writeLabel.Name = "writeLabel"
        Me.writeLabel.Size = New System.Drawing.Size(62, 13)
        Me.writeLabel.TabIndex = 3
        Me.writeLabel.Text = "Write Task:"
        '
        'writeComboBox
        '
        Me.writeComboBox.Location = New System.Drawing.Point(103, 32)
        Me.writeComboBox.Name = "writeComboBox"
        Me.writeComboBox.Size = New System.Drawing.Size(172, 21)
        Me.writeComboBox.TabIndex = 2
        AddHandler writeComboBox.SelectedIndexChanged, AddressOf Me.writeComboBox_SelectedIndexChanged
        '
        'line6Switch
        '
        Me.line6Switch.Location = New System.Drawing.Point(72, 73)
        Me.line6Switch.Name = "line6Switch"
        Me.line6Switch.Size = New System.Drawing.Size(40, 70)
        Me.line6Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line6Switch.TabIndex = 0
        AddHandler line6Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'line5Switch
        '
        Me.line5Switch.Location = New System.Drawing.Point(128, 73)
        Me.line5Switch.Name = "line5Switch"
        Me.line5Switch.Size = New System.Drawing.Size(40, 70)
        Me.line5Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line5Switch.TabIndex = 0
        AddHandler line5Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'line4Switch
        '
        Me.line4Switch.Location = New System.Drawing.Point(184, 73)
        Me.line4Switch.Name = "line4Switch"
        Me.line4Switch.Size = New System.Drawing.Size(40, 70)
        Me.line4Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line4Switch.TabIndex = 0
        AddHandler line4Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'line3Switch
        '
        Me.line3Switch.Location = New System.Drawing.Point(240, 73)
        Me.line3Switch.Name = "line3Switch"
        Me.line3Switch.Size = New System.Drawing.Size(40, 70)
        Me.line3Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line3Switch.TabIndex = 0
        AddHandler line3Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'line2Switch
        '
        Me.line2Switch.Location = New System.Drawing.Point(296, 73)
        Me.line2Switch.Name = "line2Switch"
        Me.line2Switch.Size = New System.Drawing.Size(40, 70)
        Me.line2Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line2Switch.TabIndex = 0
        AddHandler line2Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'line1Switch
        '
        Me.line1Switch.Location = New System.Drawing.Point(352, 73)
        Me.line1Switch.Name = "line1Switch"
        Me.line1Switch.Size = New System.Drawing.Size(40, 70)
        Me.line1Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line1Switch.TabIndex = 0
        AddHandler line1Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'line0Switch
        '
        Me.line0Switch.Location = New System.Drawing.Point(408, 73)
        Me.line0Switch.Name = "line0Switch"
        Me.line0Switch.Size = New System.Drawing.Size(40, 70)
        Me.line0Switch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.line0Switch.TabIndex = 0
        AddHandler line0Switch.StateChanged, AddressOf Me.lineSwitch_StateChanged
        '
        'readGroupBox
        '
        Me.readGroupBox.Controls.Add(Me.ledLine7Label)
        Me.readGroupBox.Controls.Add(Me.ledLine0Label)
        Me.readGroupBox.Controls.Add(Me.readInfoLabel)
        Me.readGroupBox.Controls.Add(Me.readLabel)
        Me.readGroupBox.Controls.Add(Me.readComboBox)
        Me.readGroupBox.Controls.Add(Me.readButton)
        Me.readGroupBox.Controls.Add(Me.line7Led)
        Me.readGroupBox.Controls.Add(Me.line6Led)
        Me.readGroupBox.Controls.Add(Me.line5Led)
        Me.readGroupBox.Controls.Add(Me.line4Led)
        Me.readGroupBox.Controls.Add(Me.line3Led)
        Me.readGroupBox.Controls.Add(Me.line2Led)
        Me.readGroupBox.Controls.Add(Me.line1Led)
        Me.readGroupBox.Controls.Add(Me.line0Led)
        Me.readGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.readGroupBox.Location = New System.Drawing.Point(40, 243)
        Me.readGroupBox.Name = "readGroupBox"
        Me.readGroupBox.Size = New System.Drawing.Size(745, 156)
        Me.readGroupBox.TabIndex = 3
        Me.readGroupBox.TabStop = False
        Me.readGroupBox.Text = "Digital Read"
        '
        'ledLine7Label
        '
        Me.ledLine7Label.AutoSize = True
        Me.ledLine7Label.Location = New System.Drawing.Point(27, 130)
        Me.ledLine7Label.Name = "ledLine7Label"
        Me.ledLine7Label.Size = New System.Drawing.Size(13, 13)
        Me.ledLine7Label.TabIndex = 8
        Me.ledLine7Label.Text = "7"
        '
        'ledLine0Label
        '
        Me.ledLine0Label.AutoSize = True
        Me.ledLine0Label.Location = New System.Drawing.Point(419, 130)
        Me.ledLine0Label.Name = "ledLine0Label"
        Me.ledLine0Label.Size = New System.Drawing.Size(13, 13)
        Me.ledLine0Label.TabIndex = 7
        Me.ledLine0Label.Text = "0"
        '
        'readInfoLabel
        '
        Me.readInfoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.readInfoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.readInfoLabel.Location = New System.Drawing.Point(475, 33)
        Me.readInfoLabel.Name = "readInfoLabel"
        Me.readInfoLabel.Size = New System.Drawing.Size(264, 96)
        Me.readInfoLabel.TabIndex = 6
        Me.readInfoLabel.Text = resources.GetString("readInfoLabel.Text")
        '
        'readLabel
        '
        Me.readLabel.AutoSize = True
        Me.readLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.readLabel.Location = New System.Drawing.Point(21, 46)
        Me.readLabel.Name = "readLabel"
        Me.readLabel.Size = New System.Drawing.Size(63, 13)
        Me.readLabel.TabIndex = 3
        Me.readLabel.Text = "Read Task:"
        '
        'readComboBox
        '
        Me.readComboBox.Location = New System.Drawing.Point(103, 38)
        Me.readComboBox.Name = "readComboBox"
        Me.readComboBox.Size = New System.Drawing.Size(172, 21)
        Me.readComboBox.TabIndex = 2
        AddHandler readComboBox.SelectedIndexChanged, AddressOf Me.readComboBox_SelectedIndexChanged
        '
        'readButton
        '
        Me.readButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.readButton.Location = New System.Drawing.Point(317, 38)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(75, 23)
        Me.readButton.TabIndex = 2
        Me.readButton.Text = "Read"
        AddHandler readButton.Click, AddressOf Me.readButton_Click
        '
        'line6Led
        '
        Me.line6Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line6Led.Location = New System.Drawing.Point(72, 94)
        Me.line6Led.Name = "line6Led"
        Me.line6Led.Size = New System.Drawing.Size(35, 35)
        Me.line6Led.TabIndex = 1
        '
        'line5Led
        '
        Me.line5Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line5Led.Location = New System.Drawing.Point(128, 94)
        Me.line5Led.Name = "line5Led"
        Me.line5Led.Size = New System.Drawing.Size(35, 35)
        Me.line5Led.TabIndex = 1
        '
        'line4Led
        '
        Me.line4Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line4Led.Location = New System.Drawing.Point(184, 94)
        Me.line4Led.Name = "line4Led"
        Me.line4Led.Size = New System.Drawing.Size(35, 35)
        Me.line4Led.TabIndex = 1
        '
        'line3Led
        '
        Me.line3Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line3Led.Location = New System.Drawing.Point(240, 94)
        Me.line3Led.Name = "line3Led"
        Me.line3Led.Size = New System.Drawing.Size(35, 35)
        Me.line3Led.TabIndex = 1
        '
        'line2Led
        '
        Me.line2Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line2Led.Location = New System.Drawing.Point(296, 94)
        Me.line2Led.Name = "line2Led"
        Me.line2Led.Size = New System.Drawing.Size(35, 35)
        Me.line2Led.TabIndex = 1
        '
        'line1Led
        '
        Me.line1Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line1Led.Location = New System.Drawing.Point(352, 94)
        Me.line1Led.Name = "line1Led"
        Me.line1Led.Size = New System.Drawing.Size(35, 35)
        Me.line1Led.TabIndex = 1
        '
        'line0Led
        '
        Me.line0Led.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.line0Led.Location = New System.Drawing.Point(408, 94)
        Me.line0Led.Name = "line0Led"
        Me.line0Led.Size = New System.Drawing.Size(35, 35)
        Me.line0Led.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(822, 445)
        Me.Controls.Add(Me.readGroupBox)
        Me.Controls.Add(Me.writeGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Global Digital Port IO - USB"
        CType(Me.line7Switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line7Led, System.ComponentModel.ISupportInitialize).EndInit()
        Me.writeGroupBox.ResumeLayout(False)
        Me.writeGroupBox.PerformLayout()
        CType(Me.line6Switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line5Switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line4Switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line3Switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line2Switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line1Switch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line0Switch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.readGroupBox.ResumeLayout(False)
        Me.readGroupBox.PerformLayout()
        CType(Me.line6Led, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line5Led, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line4Led, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line3Led, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line2Led, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line1Led, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.line0Led, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
#End Region

    Private Sub lineSwitch_StateChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.ActionEventArgs)
        If Not resettingSwitches Then
            Try

                ' Get the task name and load from MAX
                Dim taskName As String = writeComboBox.SelectedItem.ToString
                digitalWriteTask = DaqSystem.Local.LoadTask(taskName)

                ' Get switch values
                Dim dataArray() As Integer = New Integer((8) - 1) {}
                dataArray(0) = Convert.ToInt32(line0Switch.Value)
                dataArray(1) = Convert.ToInt32(line1Switch.Value)
                dataArray(2) = Convert.ToInt32(line2Switch.Value)
                dataArray(3) = Convert.ToInt32(line3Switch.Value)
                dataArray(4) = Convert.ToInt32(line4Switch.Value)
                dataArray(5) = Convert.ToInt32(line5Switch.Value)
                dataArray(6) = Convert.ToInt32(line6Switch.Value)
                dataArray(7) = Convert.ToInt32(line7Switch.Value)

                Dim dataValue As Integer = 0

                ' Convert switch values (0/1) into a decimal value
                Dim i As Integer = 0
                Do While (i < 8)
                    If (dataArray(i) = 1) Then
                        dataValue = (dataValue + Convert.ToInt32(Math.Pow(2, CType(i, Double))))
                    End If
                    i = (i + 1)
                Loop

                ' Write data to the port
                Dim writer As DigitalSingleChannelWriter = New DigitalSingleChannelWriter(digitalWriteTask.Stream)
                writer.WriteSingleSamplePort(True, dataValue)
            Catch ex As DaqException
                MessageBox.Show(ex.Message)
                ResetSwitches()
            Finally
                If Not digitalWriteTask Is Nothing Then
                    digitalWriteTask.Dispose()
                End If
            End Try
        End If
    End Sub

    Private Sub readButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Try

            ' Get the task name and load from MAX
            Dim taskName As String = readComboBox.SelectedItem.ToString
            digitalReadTask = DaqSystem.Local.LoadTask(taskName)

            ' Read data from the port
            Dim reader As DigitalSingleChannelReader = New DigitalSingleChannelReader(digitalReadTask.Stream)
            Dim dataValueRead As Integer = reader.ReadSingleSamplePortInt32

            ' Check which bits of the read value are set to 1
            Dim dataArray() As Boolean = New Boolean((8) - 1) {}

            Dim i As Integer = 0
            Do While (i < 8)
                If (((dataValueRead >> i) And 1) = 1) Then
                    dataArray(i) = True
                End If
                i = (i + 1)
            Loop

            ' Display set bits
            line0Led.Value = dataArray(0)
            line1Led.Value = dataArray(1)
            line2Led.Value = dataArray(2)
            line3Led.Value = dataArray(3)
            line4Led.Value = dataArray(4)
            line5Led.Value = dataArray(5)
            line6Led.Value = dataArray(6)
            line7Led.Value = dataArray(7)
        Catch ex As DaqException
            MessageBox.Show(ex.Message)
            ResetLeds()
        Finally
            If Not digitalReadTask Is Nothing Then
                digitalReadTask.Dispose()
            End If
        End Try
    End Sub

    Private Sub writeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        ResetSwitches()
    End Sub

    Private Sub readComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        ResetLeds()
    End Sub

    Private Sub ResetSwitches()
        resettingSwitches = True

        line0Switch.Value = False
        line1Switch.Value = False
        line2Switch.Value = False
        line3Switch.Value = False
        line4Switch.Value = False
        line5Switch.Value = False
        line6Switch.Value = False
        line7Switch.Value = False

        resettingSwitches = False
    End Sub

    Private Sub ResetLeds()
        line0Led.Value = False
        line1Led.Value = False
        line2Led.Value = False
        line3Led.Value = False
        line4Led.Value = False
        line5Led.Value = False
        line6Led.Value = False
        line7Led.Value = False
    End Sub
End Class