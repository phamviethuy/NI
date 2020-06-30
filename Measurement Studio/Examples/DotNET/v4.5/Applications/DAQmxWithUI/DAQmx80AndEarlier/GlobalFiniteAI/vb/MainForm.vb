'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' Example program:
'   GlobalFiniteAI
'
' Description:
'   This example shows how to load a finite analog input task from the Measurement & 
'   Automation Explorer (MAX) and use it to acquire and plot samples from a device.
'
' Instructions for running:
'   1.  Create a finite analog input NI-DAQmx global task in MAX. For help, refer to 
'       "Creating Tasks and Channels" in the Measurement & Automation Explorer Help. 
'       To access this help, select Start>>All Programs>>National Instruments>>
'       Measurement & Automation. In MAX, select Help>>MAX Help.
'
'       Note: If you prefer, you can import a finite AI task and a simulated 
'       device into MAX from the GlobalFiniteAI.nce file, which is located in the 
'       example directory. Refer to "Using the Configuration Import Wizard" in the 
'       Measurement & Automation Explorer Help for more information.
'
'   2.  Run the application, select the task from the drop-down list, and click 
'       the Read button.
'
' Steps:
'   1.  Load the task from MAX.
'   2.  Read the data from all of the channels in the task.
'   3.  Initialize an array of colors so that if the task has more than one channel
'       then the corresponding plots can be distinguished on the graph. 
'       Assign color(s) to the plot(s) and create a legend.
'   4.  Plot the data on a waveform graph.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports NationalInstruments
Imports NationalInstruments.DAQmx
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data


Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private taskComboBox As System.Windows.Forms.ComboBox
    Private globalFiniteAIWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private xAxis1 As NationalInstruments.UI.XAxis
    Private yAxis1 As NationalInstruments.UI.YAxis
    Private waveformPlot1 As NationalInstruments.UI.WaveformPlot
    Private WithEvents readButton As System.Windows.Forms.Button
    Private finiteTask As Task
    Private data(,) As Double
    Private daqmxTaskGroupBox As System.Windows.Forms.GroupBox
    Private daqmxTaskLabel As System.Windows.Forms.Label
    Private channelLegend As NationalInstruments.UI.WindowsForms.Legend
    Private infoLabel As System.Windows.Forms.Label
    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        MyBase.New()
        Application.EnableVisualStyles()
        Application.DoEvents()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        '
        ' Initialize UI
        '
        readButton.Enabled = False

        Dim t As Task = Nothing

        For Each s As String In DaqSystem.Local.Tasks
            Try
                t = DaqSystem.Local.LoadTask(s)
                t.Control(TaskAction.Verify)
                If ((t.AIChannels.Count > 0) _
                            AndAlso (t.Timing.SampleQuantityMode = SampleQuantityMode.FiniteSamples)) Then
                    taskComboBox.Items.Add(s)
                    readButton.Enabled = True
                End If
            Catch ex As DaqException
                ' Ignore invalid tasks
            Finally
                t.Dispose()
            End Try
        Next

        If (taskComboBox.Items.Count > 0) Then
            taskComboBox.SelectedIndex = 0
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.daqmxTaskGroupBox = New System.Windows.Forms.GroupBox
        Me.taskComboBox = New System.Windows.Forms.ComboBox
        Me.daqmxTaskLabel = New System.Windows.Forms.Label
        Me.globalFiniteAIWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.readButton = New System.Windows.Forms.Button
        Me.channelLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.infoLabel = New System.Windows.Forms.Label
        Me.daqmxTaskGroupBox.SuspendLayout()
        CType(Me.globalFiniteAIWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.channelLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'daqmxTaskGroupBox
        '
        Me.daqmxTaskGroupBox.Controls.Add(Me.taskComboBox)
        Me.daqmxTaskGroupBox.Controls.Add(Me.daqmxTaskLabel)
        Me.daqmxTaskGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.daqmxTaskGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.daqmxTaskGroupBox.Name = "daqmxTaskGroupBox"
        Me.daqmxTaskGroupBox.Size = New System.Drawing.Size(328, 72)
        Me.daqmxTaskGroupBox.TabIndex = 0
        Me.daqmxTaskGroupBox.TabStop = False
        Me.daqmxTaskGroupBox.Text = "Global DAQmx Task"
        '
        'taskComboBox
        '
        Me.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.taskComboBox.Location = New System.Drawing.Point(104, 32)
        Me.taskComboBox.Name = "taskComboBox"
        Me.taskComboBox.Size = New System.Drawing.Size(216, 21)
        Me.taskComboBox.TabIndex = 1
        '
        'daqmxTaskLabel
        '
        Me.daqmxTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.daqmxTaskLabel.Location = New System.Drawing.Point(8, 32)
        Me.daqmxTaskLabel.Name = "daqmxTaskLabel"
        Me.daqmxTaskLabel.Size = New System.Drawing.Size(80, 24)
        Me.daqmxTaskLabel.TabIndex = 0
        Me.daqmxTaskLabel.Text = "DAQmx Task:"
        '
        'globalFiniteAIWaveformGraph
        '
        Me.globalFiniteAIWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.globalFiniteAIWaveformGraph.Location = New System.Drawing.Point(8, 96)
        Me.globalFiniteAIWaveformGraph.Name = "globalFiniteAIWaveformGraph"
        Me.globalFiniteAIWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1})
        Me.globalFiniteAIWaveformGraph.Size = New System.Drawing.Size(504, 304)
        Me.globalFiniteAIWaveformGraph.TabIndex = 2
        Me.globalFiniteAIWaveformGraph.TabStop = False
        Me.globalFiniteAIWaveformGraph.UseColorGenerator = True
        Me.globalFiniteAIWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.globalFiniteAIWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'waveformPlot1
        '
        Me.waveformPlot1.XAxis = Me.xAxis1
        Me.waveformPlot1.YAxis = Me.yAxis1
        '
        'readButton
        '
        Me.readButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.readButton.Location = New System.Drawing.Point(437, 40)
        Me.readButton.Name = "readButton"
        Me.readButton.TabIndex = 1
        Me.readButton.Text = "Read"
        '
        'channelLegend
        '
        Me.channelLegend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.channelLegend.Location = New System.Drawing.Point(520, 96)
        Me.channelLegend.Name = "channelLegend"
        Me.channelLegend.Size = New System.Drawing.Size(264, 304)
        Me.channelLegend.TabIndex = 3
        Me.channelLegend.TabStop = False
        '
        'infoLabel
        '
        Me.infoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoLabel.Location = New System.Drawing.Point(520, 8)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(264, 80)
        Me.infoLabel.TabIndex = 4
        Me.infoLabel.Text = "Before running this application make sure you have a finite analog input task in " & _
        "MAX.  The GlobalFiniteAI.nce file in the example directory contains a task that " & _
        "you can import to MAX. Double click on the nce file, MAX will be launched and th" & _
        "en follow the installation directions."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(794, 408)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.channelLegend)
        Me.Controls.Add(Me.readButton)
        Me.Controls.Add(Me.globalFiniteAIWaveformGraph)
        Me.Controls.Add(Me.daqmxTaskGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Global Finite Analog Input"
        Me.daqmxTaskGroupBox.ResumeLayout(False)
        CType(Me.globalFiniteAIWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.channelLegend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub readButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles readButton.Click
        Me.Cursor = Cursors.WaitCursor
        globalFiniteAIWaveformGraph.ClearData()
        globalFiniteAIWaveformGraph.Plots.Clear()
        channelLegend.Items.Clear()
        Try
            finiteTask = DaqSystem.Local.LoadTask(taskComboBox.SelectedItem.ToString)

            SetupUI(finiteTask)

            Dim reader As AnalogMultiChannelReader = New AnalogMultiChannelReader(finiteTask.Stream)
            data = reader.ReadMultiSample(CInt(finiteTask.Timing.SamplesPerChannel))

            globalFiniteAIWaveformGraph.PlotYMultiple(data)
        Catch ex As DaqException
            MessageBox.Show(ex.Message)
        Finally
            finiteTask.Dispose()
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub SetupUI(ByVal finiteTask As Task)
        finiteTask.Control(TaskAction.Verify)
        Dim i As Integer = 0
        For Each chan As AIChannel In finiteTask.AIChannels
            Dim plot As WaveformPlot = New WaveformPlot
            globalFiniteAIWaveformGraph.Plots.Add(plot)
            channelLegend.Items.Add(New LegendItem(plot, (chan.VirtualName + (": " + chan.PhysicalName))))
            i = (i + 1)
        Next
    End Sub
End Class

