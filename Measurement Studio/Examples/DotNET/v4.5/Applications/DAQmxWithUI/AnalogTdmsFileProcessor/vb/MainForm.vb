''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' Example program:
'   AnalogTdmsFileProcessor
'
' Category:
'   File I/O
'
' Description:
'   This example demonstrates how to easily write DAQmx-acquired data to files 
'   and how to read the files back into an application and display the data on 
'   a graph. Use the Configure menu to configure either a real DAQmx voltage 
'   acquisition or a simulated acquisition. Use the Acquire menu to acquire 
'   DAQmx data or to generate simulated data. Use the File>>Save All menu item 
'   to save the entire data set. Move the cursors and use the 
'   File>>Save Selection menu item to save the data between the cursors. Use the
'   File>>Open menu item to open a file that you previously saved and plot the 
'   data it contains on the graph.
'
' Instructions for running:
'   1.  If you have a data acquisition device with an analog input channel, 
'       select Configure>>DAQmx Acquisition
'       1.  Select the physical channel which correspond to where your signal
'           is input on the DAQ device.
'       2.  Enter the minimum and maximum voltage ranges for the physical 
'           channels.
'       3.  Set the number of samples to acquire per channel.
'       4.  Set the rate of the acquisition, in Hertz.
'       5.  If you want to save the data acquired at the same time it's being
'           acquired, check the box labeled "Enable High-Speed TDMS Streaming"
'           and proceed to select the target file by either entering a file
'           path in the text box or clicking the button next to the text box
'           to invoke a save file dialog.
'       6.  Select OK to save your settings.
'       7.  Select Acquire>>DAQmx Data.
'   2.  If you do not have a data acquisition device, select 
'       Configure>>Simulated Acquisition.
'       1.  Select a signal type to simulate.
'       2.  Specify characteristics of the signal to simulate.
'       3.  Select OK to save your settings.
'       4.  Select Acquire>>Simulated Data.
'   3.  Select File>>Save All to save all the data to a file.
'   4.  Manipulate the cursors and select File>>Save Selection to save the
'       subset of the data between the cursors.
'   5.  Select File>>Open to open and view saved data files.
'
' I/O Connections Overview:
'   Make sure your signal input terminals match the Physical Channel I/O
'   Controls.  If you have a PXI chassis, ensure that it has been properly
'   identified in MAX.  
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports System.Resources
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports NationalInstruments.Tdms

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private daqmxAnalogInputTask As Task
    Private analogConfigureDAQmxAcquisitionForm As ConfigureDAQmxAcquisitionForm
    Private simulatedDataGenerator As BasicFunctionGenerator
    Private analogConfigureSimulatedAcquisitionForm As ConfigureSimulatedAcquisitionForm
    Private resources As ResourceManager
    Private activeWaveform As AnalogWaveform(Of Double)
    Private activeWaveformSaved As Boolean = True


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        resources = New ResourceManager(Me.GetType)

        analogConfigureDAQmxAcquisitionForm = New ConfigureDAQmxAcquisitionForm

        simulatedDataGenerator = New BasicFunctionGenerator
        analogConfigureSimulatedAcquisitionForm = New ConfigureSimulatedAcquisitionForm(simulatedDataGenerator)
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
            If Not (daqmxAnalogInputTask Is Nothing) Then
                daqmxAnalogInputTask.Dispose()
            End If
            If Not (analogConfigureDAQmxAcquisitionForm Is Nothing) Then
                analogConfigureDAQmxAcquisitionForm.Dispose()
            End If
            If Not (analogConfigureSimulatedAcquisitionForm Is Nothing) Then
                analogConfigureSimulatedAcquisitionForm.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents mainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mainMenuFileItem As System.Windows.Forms.MenuItem
    Friend WithEvents fileMenuOpenItem As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents fileMenuSaveAllItem As System.Windows.Forms.MenuItem
    Friend WithEvents fileMenuSaveSelectionItem As System.Windows.Forms.MenuItem
    Friend WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents fileMenuExitItem As System.Windows.Forms.MenuItem
    Friend WithEvents mainMenuAcquisitionItem As System.Windows.Forms.MenuItem
    Friend WithEvents configureMenuDAQmxItem As System.Windows.Forms.MenuItem
    Friend WithEvents configureMenuSimulatedItem As System.Windows.Forms.MenuItem
    Friend WithEvents mainMenuAcquireItem As System.Windows.Forms.MenuItem
    Friend WithEvents acquireMenuDAQmxItem As System.Windows.Forms.MenuItem
    Friend WithEvents acquireMenuSimulationItem As System.Windows.Forms.MenuItem
    Friend WithEvents dataCursor1 As NationalInstruments.UI.XYCursor
    Friend WithEvents waveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents dataCursor2 As NationalInstruments.UI.XYCursor
    Friend WithEvents _saveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents _openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents analogDataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me._saveFileDialog = New System.Windows.Forms.SaveFileDialog
        Me.mainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mainMenuFileItem = New System.Windows.Forms.MenuItem
        Me.fileMenuOpenItem = New System.Windows.Forms.MenuItem
        Me.menuItem7 = New System.Windows.Forms.MenuItem
        Me.fileMenuSaveAllItem = New System.Windows.Forms.MenuItem
        Me.fileMenuSaveSelectionItem = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        Me.fileMenuExitItem = New System.Windows.Forms.MenuItem
        Me.mainMenuAcquisitionItem = New System.Windows.Forms.MenuItem
        Me.configureMenuDAQmxItem = New System.Windows.Forms.MenuItem
        Me.configureMenuSimulatedItem = New System.Windows.Forms.MenuItem
        Me.mainMenuAcquireItem = New System.Windows.Forms.MenuItem
        Me.acquireMenuDAQmxItem = New System.Windows.Forms.MenuItem
        Me.acquireMenuSimulationItem = New System.Windows.Forms.MenuItem
        Me._openFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.analogDataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.dataCursor1 = New NationalInstruments.UI.XYCursor
        Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.dataCursor2 = New NationalInstruments.UI.XYCursor
        CType(Me.analogDataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCursor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCursor2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_saveFileDialog
        '
        Me._saveFileDialog.DefaultExt = "adf"
        Me._saveFileDialog.Filter = "TDMS files|*.tdms"
        Me._saveFileDialog.Title = "Save DAQmx Analog TDMS File"
        '
        'mainMenu
        '
        Me.mainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mainMenuFileItem, Me.mainMenuAcquisitionItem, Me.mainMenuAcquireItem})
        '
        'mainMenuFileItem
        '
        Me.mainMenuFileItem.Index = 0
        Me.mainMenuFileItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.fileMenuOpenItem, Me.menuItem7, Me.fileMenuSaveAllItem, Me.fileMenuSaveSelectionItem, Me.menuItem6, Me.fileMenuExitItem})
        Me.mainMenuFileItem.Text = "&File"
        '
        'fileMenuOpenItem
        '
        Me.fileMenuOpenItem.Index = 0
        Me.fileMenuOpenItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.fileMenuOpenItem.Text = "&Open"
        '
        'menuItem7
        '
        Me.menuItem7.Index = 1
        Me.menuItem7.Text = "-"
        '
        'fileMenuSaveAllItem
        '
        Me.fileMenuSaveAllItem.Index = 2
        Me.fileMenuSaveAllItem.Shortcut = System.Windows.Forms.Shortcut.CtrlA
        Me.fileMenuSaveAllItem.Text = "Save &All"
        '
        'fileMenuSaveSelectionItem
        '
        Me.fileMenuSaveSelectionItem.Index = 3
        Me.fileMenuSaveSelectionItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.fileMenuSaveSelectionItem.Text = "&Save Selection"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 4
        Me.menuItem6.Text = "-"
        '
        'fileMenuExitItem
        '
        Me.fileMenuExitItem.Index = 5
        Me.fileMenuExitItem.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.fileMenuExitItem.Text = "E&xit"
        '
        'mainMenuAcquisitionItem
        '
        Me.mainMenuAcquisitionItem.Index = 1
        Me.mainMenuAcquisitionItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.configureMenuDAQmxItem, Me.configureMenuSimulatedItem})
        Me.mainMenuAcquisitionItem.Text = "&Configure"
        '
        'configureMenuDAQmxItem
        '
        Me.configureMenuDAQmxItem.Index = 0
        Me.configureMenuDAQmxItem.Text = "&DAQmx Acquistion"
        '
        'configureMenuSimulatedItem
        '
        Me.configureMenuSimulatedItem.Index = 1
        Me.configureMenuSimulatedItem.Text = "&Simulated Acquisition"
        '
        'mainMenuAcquireItem
        '
        Me.mainMenuAcquireItem.Index = 2
        Me.mainMenuAcquireItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.acquireMenuDAQmxItem, Me.acquireMenuSimulationItem})
        Me.mainMenuAcquireItem.Text = "&Acquire"
        '
        'acquireMenuDAQmxItem
        '
        Me.acquireMenuDAQmxItem.Index = 0
        Me.acquireMenuDAQmxItem.Text = "&DAQmx Data"
        '
        'acquireMenuSimulationItem
        '
        Me.acquireMenuSimulationItem.Index = 1
        Me.acquireMenuSimulationItem.Text = "&Simulated Data"
        '
        '_openFileDialog
        '
        Me._openFileDialog.DefaultExt = "adf"
        Me._openFileDialog.Filter = "TDMS files|*.tdms"
        Me._openFileDialog.Title = "Open DAQmx Analog TDMS File"
        '
        'analogDataWaveformGraph
        '
        Me.analogDataWaveformGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.dataCursor1, Me.dataCursor2})
        Me.analogDataWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.analogDataWaveformGraph.Location = New System.Drawing.Point(0, 0)
        Me.analogDataWaveformGraph.Name = "analogDataWaveformGraph"
        Me.analogDataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1})
        Me.analogDataWaveformGraph.Size = New System.Drawing.Size(520, 345)
        Me.analogDataWaveformGraph.TabIndex = 1
        Me.analogDataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.analogDataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'dataCursor1
        '
        Me.dataCursor1.HorizontalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None
        Me.dataCursor1.LabelVisible = True
        Me.dataCursor1.Plot = Me.waveformPlot1
        '
        'waveformPlot1
        '
        Me.waveformPlot1.XAxis = Me.xAxis1
        Me.waveformPlot1.YAxis = Me.yAxis1
        '
        'xAxis1
        '
        Me.xAxis1.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "mm:ss.fff")
        '
        'dataCursor2
        '
        Me.dataCursor2.HorizontalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None
        Me.dataCursor2.LabelVisible = True
        Me.dataCursor2.Plot = Me.waveformPlot1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(520, 345)
        Me.Controls.Add(Me.analogDataWaveformGraph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu
        Me.Name = "MainForm"
        Me.Text = "DAQmx Analog TDMS File Processor"
        CType(Me.analogDataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCursor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCursor2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub fileMenuOpenItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fileMenuOpenItem.Click
        If _openFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim waveform As AnalogWaveform(Of Double) = Nothing
            If ReadWaveformFromFile(_openFileDialog.FileName, waveform) Then
                activeWaveform = waveform
                PlotWaveformRecord()
            End If
        End If
    End Sub

    Private Sub fileMenuSaveAllItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fileMenuSaveAllItem.Click
        Dim fileName As String = vbNullString
        If PromptForSaveFileName(fileName) Then
            WriteWaveformToFile(fileName, activeWaveform)
        End If
    End Sub

    Private Sub fileMenuSaveSelectionItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fileMenuSaveSelectionItem.Click
        Dim fileName As String = vbNullString
        If PromptForSaveFileName(fileName) Then
            Dim startIndex As Long = System.Math.Min(dataCursor1.GetCurrentIndex(), dataCursor2.GetCurrentIndex())
            Dim endIndex As Long = System.Math.Max(dataCursor1.GetCurrentIndex(), dataCursor2.GetCurrentIndex())
            Dim numberOfSamples As Long = endIndex - startIndex + 1

            Dim data() As Double = activeWaveform.GetScaledData(startIndex, numberOfSamples)
            Dim waveform As AnalogWaveform(Of Double) = AnalogWaveform(Of Double).FromArray1D(data)

            Dim startTime As DateTime = DateTime.SpecifyKind(activeWaveform.GetTimeStamps(startIndex, 1)(0), DateTimeKind.Local)
            waveform.Timing = WaveformTiming.CreateWithRegularInterval(activeWaveform.Timing.SampleInterval, startTime, TimeSpan.Zero)

            WriteWaveformToFile(fileName, waveform)
        End If

    End Sub

    Private Sub fileMenuExitItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fileMenuExitItem.Click
        Close()
    End Sub

    Private Sub configureMenuDAQmxItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles configureMenuDAQmxItem.Click
        analogConfigureDAQmxAcquisitionForm.DaqTask = daqmxAnalogInputTask
        If analogConfigureDAQmxAcquisitionForm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            daqmxAnalogInputTask = analogConfigureDAQmxAcquisitionForm.DaqTask
        End If
    End Sub

    Private Sub configureMenuSimulatedItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles configureMenuSimulatedItem.Click
        analogConfigureSimulatedAcquisitionForm.ShowDialog()
    End Sub

    Private Sub acquireMenuDAQmxItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acquireMenuDAQmxItem.Click
        If daqmxAnalogInputTask Is Nothing Then
            MessageBox.Show("You must configure the DAQmx Acquistion before you can acquire data.", "Error")
            Return
        Else
            '
            ' Update the reference to the task because the configuration dialog box
            ' might have created a new one.
            '
            daqmxAnalogInputTask = analogConfigureDAQmxAcquisitionForm.DaqTask
        End If
        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            Dim reader As New AnalogSingleChannelReader(daqmxAnalogInputTask.Stream)
            activeWaveform = reader.ReadWaveform(-1)
            activeWaveformSaved = False
            PlotWaveformRecord()
        Catch ex As DaqException
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub acquireMenuSimulationItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acquireMenuSimulationItem.Click
        '
        ' The timespan between samples is the inverse of the sampling rate.
        '
        activeWaveform = AnalogWaveform(Of Double).FromArray1D(simulatedDataGenerator.Generate())
        activeWaveform.Timing = WaveformTiming.CreateWithRegularInterval(TimeSpan.FromMinutes(1.0 / simulatedDataGenerator.SamplingRate), DateTime.Now)
        activeWaveformSaved = False
        PlotWaveformRecord()
    End Sub

    Private Sub PlotWaveformRecord()
        analogDataWaveformGraph.PlotWaveform(activeWaveform)
        dataCursor1.MoveCursor(0)
        dataCursor2.MoveCursor(activeWaveform.Samples.Count - 1)
    End Sub

    Private Sub WriteWaveformToFile(ByVal filePath As String, ByVal waveform As AnalogWaveform(Of Double))
        If File.Exists(filePath) Then
            TdmsFile.Delete(filePath)
        End If

        '
        ' Create the TDMS file
        '
        Dim targetFile As New TdmsFile(filePath, New TdmsFileOptions())
        targetFile.Title = "Analog Measurement"
        targetFile.Description = "This TDMS file was generated using Measurement Studio's AnalogTdmsFileProcessor DAQmxWithUI example."

        '
        ' Set up the channel group.
        '
        Dim channelGroupName As New String("TdmsDataProcessorExample")
        Dim channelGroup As New TdmsChannelGroup(channelGroupName)
        Dim channelGroups As TdmsChannelGroupCollection = targetFile.GetChannelGroups()
        channelGroups.Add(channelGroup)

        '
        ' Set up the channel
        '
        Dim dataChannelName As New String("Voltage")
        Dim dataChannel As New TdmsChannel(dataChannelName, TdmsDataType.Double)
        Dim channels As TdmsChannelCollection = channelGroup.GetChannels()
        channels.Add(dataChannel)

        '
        ' Write the data
        ' 
        channelGroup.AppendAnalogWaveform(dataChannel, waveform)

        targetFile.Close()
    End Sub

    Private Function ReadWaveformFromFile(ByVal filePath As String, ByRef waveform As AnalogWaveform(Of Double)) As Boolean
        Try
            '
            ' Open the file for read access.
            '
            Dim sourceFile As New TdmsFile(filePath, New TdmsFileOptions(TdmsFileFormat.Version20, TdmsFileAccess.Read))

            '
            ' Get the channel group.
            '
            Dim channelGroups As TdmsChannelGroupCollection = sourceFile.GetChannelGroups()
            Dim channelGroup As TdmsChannelGroup = channelGroups(0)

            '
            ' Get the channel.
            '
            Dim channels As TdmsChannelCollection = channelGroup.GetChannels()
            Dim dataChannel As TdmsChannel = channels(0)

            '
            ' Read the data
            ' 
            waveform = channelGroup.GetAnalogWaveform(Of Double)(dataChannel)

            '
            ' Close the file
            '
            sourceFile.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Reading File")
            Return False
        End Try
        Return True
    End Function

    Private Function PromptForSaveFileName(ByRef fileName As String) As Boolean
        If analogDataWaveformGraph.Plots(0).HistoryCount = 0 Then
            MessageBox.Show("No data to save. Acquire data or open a data file.", "Error")
            Return False
        ElseIf _saveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            fileName = _saveFileDialog.FileName
            Return True
        End If
        Return False
    End Function

    Private Sub MainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not activeWaveformSaved Then
            e.Cancel = (MessageBox.Show("You are quitting without saving your data. Continue?", "Warning", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No)
        End If
    End Sub
End Class
