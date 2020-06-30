'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' Example program:
'   GlobalContinuousAIToNetworkVariable
'
' Description:
'   This example shows how to load a continuous analog input task from the Measurement & 
'   Automation Explorer (MAX) and use it to acquire and plot samples from a USB device.
'   The application also demonstrates publishing the data onto a NetworkVariable.
'
' Instructions for running:
'   1.  Create a continuous analog input NI-DAQmx global task in MAX. For help, refer to 
'       "Creating Tasks and Channels" in the Measurement & Automation Explorer Help. 
'       To access this help, select Start>>All Programs>>National Instruments>>
'       Measurement & Automation. In MAX, select Help>>MAX Help.
'
'       Note: If you prefer, you can import a continuous AI task and a simulated USB
'       device into MAX from the GlobalContinuousAIToNetworkVariable.nce file, which is 
'       located in the example directory. Refer to "Imports the Configuration Import Wizard"
'       in the Measurement & Automation Explorer Help for more information.
' 
'   2.  Make sure that you have a NetworkVariable hosted where you can write to. The data
'       published by this application will  be an "Array of Double Waveform".
'       See "Creating Shared or Network Variables with the Variable Manager" in 
'       Help >> Variable Manager Help section in the Variable Manager application.
'
'   3.  Run the application, select the task from the drop-down list.
' 
'   4.  Select a NetworkVariable to publish to. You can type in the location of the variable
'       or click on the Browse button to browse to the Variable.
' 
'   5.  Click Start button to start acquiring the samples and publish them to the network variable
'
' Steps:
'   1.  Load the task from MAX.
'   2.  Read the data from all of the channels in the task.
'   3.  Stop reading data once the user clicks the "Stop" button.
'   4.  Initialize an array of colors so that if the task has more than one channel
'       then the corresponding plots can be distinguished on the graph. 
'       Assign color(s) to the plot(s) and create a legend.
'   5.  Plot the data on a waveform graph.
'   6.  Publish the data onto the NetworkVariable.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports NationalInstruments
Imports NationalInstruments.DAQmx
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms
Imports NationalInstruments.NetworkVariable.WindowsForms
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports NationalInstruments.NetworkVariable


Public Class MainForm

    Private stoppedExecution As Boolean = True
    Private runningTask As Task
    Private continuousTask As Task
    Private reader As AnalogMultiChannelReader
    Private daqReadCallBack As AsyncCallback
    Private outputWriter As NetworkVariableBufferedWriter(Of AnalogWaveform(Of Double)())
    Private data As AnalogWaveform(Of Double)()

    <STAThread()> Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm())
    End Sub

    Public Sub New()
        InitializeComponent()

        startButton.Enabled = False
        stopButton.Enabled = False
        browseButton.Enabled = False
        connectionStatusLed.Value = False

        Dim taskName As String
        For Each taskName In DaqSystem.Local.Tasks
            Try
                Using NewTask As Task = DaqSystem.Local.LoadTask(taskName)
                    NewTask.Control(TaskAction.Verify)
                    If NewTask.AIChannels.Count > 0 And NewTask.Timing.SampleQuantityMode = SampleQuantityMode.ContinuousSamples Then
                        taskComboBox.Items.Add(taskName)
                    End If
                End Using
            Catch
                ' Ignore invalid tasks
            End Try
        Next

        If taskComboBox.Items.Count > 0 Then
            taskComboBox.SelectedIndex = 0
            browseButton.Enabled = True
            outputLocationTextBox.Text = String.Empty
        End If

    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If continuousTask IsNot Nothing Then
                runningTask = Nothing
                continuousTask.Dispose()
            End If
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private Sub startButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        channelLegend.Items.Clear()
        outputWaveformGraph.ClearData()
        outputWaveformGraph.Plots.Clear()
        stoppedExecution = False
        Try
            Dim taskName As String = taskComboBox.SelectedItem.ToString()
            continuousTask = DaqSystem.Local.LoadTask(taskName)

            outputWriter = New NetworkVariableBufferedWriter(Of AnalogWaveform(Of Double)())(outputLocationTextBox.Text)
            outputWriter.Connect()
            connectionStatusLed.Value = True

            SetupUI()

            runningTask = continuousTask
            reader = New AnalogMultiChannelReader(continuousTask.Stream)

            outputWriter.SynchronizeCallbacks = True
            outputWriter.Connect(TimeSpan.FromSeconds(10))

            reader.SynchronizeCallbacks = True
            daqReadCallBack = New AsyncCallback(AddressOf ReadCallBack)
            reader.BeginReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), daqReadCallBack, continuousTask)

            stopButton.Enabled = True
            startButton.Enabled = False
            taskComboBox.Enabled = False
            browseButton.Enabled = False
        Catch ex As DaqException
            Stopped(ex.Message)
        Catch ex As NetworkVariableException
            Stopped(ex.Message)
        Catch ex As TimeoutException
            Stopped(ex.Message)
        End Try
    End Sub
    Public Sub ReadCallBack(ByVal ar As IAsyncResult)
        If Not stoppedExecution Then
            Try
                If runningTask IsNot Nothing AndAlso ReferenceEquals(runningTask, ar.AsyncState) Then
                    data = reader.EndReadWaveform(ar)
                    outputWaveformGraph.PlotWaveformsAppend(data)
                    outputWriter.WriteData(New NetworkVariableData(Of AnalogWaveform(Of Double)())(data))
                    reader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), daqReadCallBack, continuousTask, data)
                End If
            Catch ex As DaqException
                Stopped(ex.Message)
            Catch ex As TimeoutException
                Stopped(ex.Message)
            End Try
        End If
    End Sub

    Private Sub stopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopButton.Click
        Stopped(Nothing)
    End Sub

    Private Sub browseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseButton.Click
        If outputNetworkVariableBrowserDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            outputLocationTextBox.Text = outputNetworkVariableBrowserDialog.SelectedLocation
            startButton.Enabled = True
        End If
    End Sub

    Private Sub Stopped(ByVal message As String)
        stoppedExecution = True
        Try
            If Not continuousTask Is Nothing Then
                continuousTask.Stop()
                continuousTask.Dispose()
            End If
        Catch ex As DaqException
            message = ex.Message
        End Try

        Try
            If Not outputWriter Is Nothing Then
                outputWriter.Disconnect()
            End If
        Catch ex As NetworkVariableException
            message = ex.Message
        End Try

        If Not message Is Nothing Then
            MessageBox.Show(message)
        End If
        runningTask = Nothing
        continuousTask = Nothing
        outputWriter = Nothing

        startButton.Enabled = True
        taskComboBox.Enabled = True
        stopButton.Enabled = False
        connectionStatusLed.Value = False
    End Sub

    Private Sub SetupUI()
        continuousTask.Control(TaskAction.Verify)
        Dim i As Integer = 0
        Dim chan As AIChannel
        For Each chan In continuousTask.AIChannels
            Dim plot As WaveformPlot = New WaveformPlot()
            outputWaveformGraph.Plots.Add(plot)
            channelLegend.Items.Add(New LegendItem(plot, chan.VirtualName + ": " + chan.PhysicalName))
            i = i + 1
        Next
    End Sub


End Class
