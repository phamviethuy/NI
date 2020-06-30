Imports System
Imports System.IO
Imports System.Windows.Forms
Imports System.ComponentModel
Imports NationalInstruments
Imports NationalInstruments.Tdms

Public Class MainForm
    '========================================================================================== 
    ' This example demonstrates streaming waveform data to a TDMS file. 
    ' The data in this example is a sine signal and is generated programatically. To read data from a hardware API instead, 
    ' you can replace the dataGeneratorComponent with code that reads data from the hardware API. 
    ' For example, to read data from DAQmx, replace the dataGeneratorComponent with a DAQComponent. 
    ' Make sure to set up the TDMS file for the appropriate waveform configuration before writing the waveforms. 
    '========================================================================================== 

    Private file As TdmsFile = Nothing
    Private channelGroup As TdmsChannelGroup
    Private waveformChannels As TdmsChannel()
    Private signal As SineSignal
    Private Shared tdmsFileSet As Boolean = False
    Private Const setUpTDMSFileMessage As String = "Set up TDMS file before writing."
    Private Const tdmsFileSetUpCompletedMessage As String = "TDMS file is set up for current configuration. You can now append data to this TDMS file."
    Private Const generateAndAppendMessage As String = "Generated waveforms and appended to TDMS file. To generate and append more data to this TDMS file, click on ""Generate and Append to TDMS file"" button again. To set up another TDMS file, change the file setup configuration and click on ""Set Up TDMS File"" button."
    <System.STAThread()> _
    Public Shared Sub Main()
        System.Windows.Forms.Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        System.Windows.Forms.Application.Run(New MainForm)
    End Sub

    Public Sub New()
        InitializeComponent()

        ' Initialize Sample Interval Mode ComboBoxes 
        sampleIntervalModeComboBox.Items.AddRange([Enum].GetNames(GetType(WaveformSampleIntervalMode)))
        AddHandler Me.sampleIntervalModeComboBox.SelectedIndexChanged, AddressOf TDMSFileConfiguration_Changed
        sampleIntervalModeComboBox.SelectedItem = sampleIntervalModeComboBox.Items(0)

        generateAndAppendButton.Enabled = False
        tdmsFileSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory()
        statusTextBox.Text = setUpTDMSFileMessage
    End Sub

    Private Sub setUpTDMSFileButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles setUpTDMSFileButton.Click
        If filePathTextBox.Text = "" Then
            MessageBox.Show("TDMS file path cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Return
        End If

        Dim exception As Exception = Nothing
        Try
            SetUpTDMSFile()
        Catch tdmsException As Exception
            exception = tdmsException
        Finally
            If exception IsNot Nothing Then
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
            Else
                ' Update the status 
                statusTextBox.Text = tdmsFileSetUpCompletedMessage

                signal = New SineSignal()
                setUpTDMSFileButton.Enabled = False
                generateAndAppendButton.Enabled = True
                generateAndAppendButton.Focus()
                tdmsFileSet = True
            End If
        End Try
    End Sub
    Private Sub SetUpTDMSFile()

        ' Delete the TDMS file and the index file if already present 
        If System.IO.File.Exists(filePathTextBox.Text) Then
            TdmsFile.Delete(filePathTextBox.Text)
        End If

        ' Create new TDMS file. 
        file = New TdmsFile(filePathTextBox.Text, New TdmsFileOptions())
        file.AutoSave = True

        ' Set up the channel group. 
        Dim channelGroups As TdmsChannelGroupCollection = file.GetChannelGroups()
        channelGroup = New TdmsChannelGroup("Main Group")
        channelGroups.Add(channelGroup)

        ' Set the WaveformLayout of the TdmsChannelGroup 
        Dim tdmsChannels As TdmsChannelCollection = channelGroup.GetChannels()
        waveformChannels = New TdmsChannel(CInt(numberOfChannelsNumericEdit.Value) - 1) {}
        If sampleIntervalModeComboBox.SelectedItem.Equals(WaveformSampleIntervalMode.Irregular.ToString()) Then
            channelGroup.WaveformLayout = TdmsWaveformLayout.PairedTimeAndSampleChannels
        Else
            channelGroup.WaveformLayout = TdmsWaveformLayout.NoTimeChannel
        End If
        For i As Integer = 0 To CInt(numberOfChannelsNumericEdit.Value) - 1

            ' Set up the channels required for writing the waveforms. 
            ' For waveforms with RegularTiming or NoTiming, we use one channel for each waveform. This channel stores the sample values. 
            ' For waveforms with IrregularTiming, we use two channels for each waveform. The first channel stores the time values 
            ' and the second channel stores the sample values. 
            If channelGroup.WaveformLayout = TdmsWaveformLayout.PairedTimeAndSampleChannels Then
                ' Set up the time channel. 
                Dim timeChannelName As String = "Time Channel " + i.ToString()
                Dim timeChannel As New TdmsChannel(timeChannelName, TdmsDataType.DateTime)
                tdmsChannels.Add(timeChannel)
            End If
            Dim channelName As String = "Waveform Channel " + i.ToString()
            waveformChannels(i) = New TdmsChannel(channelName, TdmsDataType.[Double])
            tdmsChannels.Add(waveformChannels(i))
        Next
    End Sub

    Private Sub generateAndAppendButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles generateAndAppendButton.Click
        generateAndAppendButton.Enabled = False
        statusTextBox.Text = ""

        ' Configure the signal 
        Dim numberOfSamples As Integer = CInt(samplesNumericEdit.Value)
        Dim sampleIntervalMode As WaveformSampleIntervalMode = DirectCast([Enum].Parse(GetType(WaveformSampleIntervalMode), DirectCast(sampleIntervalModeComboBox.SelectedItem, String)), WaveformSampleIntervalMode)
        Dim frequency As Double = frequencyNumericEdit.Value
        Dim amplitude As Double = amplitudeNumericEdit.Value
        signal.Configure(numberOfSamples, sampleIntervalMode, frequency, amplitude)

        ' Generate the data asynchronously 
        dataGeneratorComponent.RunWorkerAsync(CInt(numberOfChannelsNumericEdit.Value))
    End Sub

    ' This method reads the data asyncronously. 
    Private Sub dataGeneratorComponent_Read(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles dataGeneratorComponent.DoWork
        Dim numberOfChannels As Integer = CInt(e.Argument)
        Dim generatedData As AnalogWaveform(Of Double)() = New AnalogWaveform(Of Double)(numberOfChannels - 1) {}
        Dim timing As WaveformTiming = signal.GenerateTiming()
        For i As Integer = 0 To numberOfChannels - 1

            Dim data As Double() = signal.GenerateData()
            generatedData(i) = AnalogWaveform(Of Double).FromArray1D(data)
            generatedData(i).Timing = timing
        Next
        e.Result = generatedData
    End Sub

    ' This method gets called after the read is completed 
    Private Sub dataGeneratorComponent_ReadCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles dataGeneratorComponent.RunWorkerCompleted
        Dim exception As Exception = e.[Error]

        If exception Is Nothing Then
            ' Get the acquired data 
            Dim acquiredData As AnalogWaveform(Of Double)() = TryCast(e.Result, AnalogWaveform(Of Double)())

            Try
                ' Append the waveforms to the channels in the TDMS file 
                channelGroup.AppendAnalogWaveforms(Of Double)(waveformChannels, acquiredData)
            Catch tdmsException As Exception
                exception = tdmsException
            End Try
        End If

        ' Update the status 
        If exception IsNot Nothing Then
            MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            statusTextBox.Text = generateAndAppendMessage
        End If
        generateAndAppendButton.Enabled = True
        generateAndAppendButton.Focus()
    End Sub

    Private Sub browseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseButton.Click
        If tdmsFileSaveFileDialog.ShowDialog() = DialogResult.OK Then
            filePathTextBox.Text = tdmsFileSaveFileDialog.FileName
        End If
    End Sub

    Private Sub TDMSFileConfiguration_Changed(ByVal sender As Object, ByVal e As EventArgs) Handles numberOfWaveformsNumericEdit.ValueChanged, filePathTextBox.TextChanged
        If tdmsFileSet Then
            If file IsNot Nothing AndAlso file.IsOpen Then
                file.Close()
            End If
            file = Nothing
            channelGroup = Nothing
            waveformChannels = Nothing
            setUpTDMSFileButton.Enabled = True
            generateAndAppendButton.Enabled = False
            statusTextBox.Text = setUpTDMSFileMessage
            tdmsFileSet = False
        End If

        numberOfChannelsNumericEdit.Value = numberOfWaveformsNumericEdit.Value
        sampleIntervalModeTextBox.Text = DirectCast(sampleIntervalModeComboBox.SelectedItem, String)

    End Sub

    Private Sub TdmsStreamingForm_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs)
        If file IsNot Nothing AndAlso file.IsOpen Then
            file.Close()
        End If
    End Sub
End Class