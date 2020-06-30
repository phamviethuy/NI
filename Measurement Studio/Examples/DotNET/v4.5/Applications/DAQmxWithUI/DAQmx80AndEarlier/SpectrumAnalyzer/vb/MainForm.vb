' This example only compiles with Enterprise Analysis
Public Class MainForm
    Inherits System.Windows.Forms.Form

    ' This example only compiles if you install NI-DAQmx support from the Device Drivers CD.
    Dim myTask As Task
    Dim reader As AnalogSingleChannelReader
    Dim samplingRate As Double
    Dim samplesPerChannel As Integer
    Dim runningTask As Task
    Dim autoPowerSpectrum() As Double
    Dim searchFrequency As Double
    Dim equivalentNoiseBandwidth As Double
    Dim coherentGain As Double
    Dim df As Double


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
            If Not (myTask Is Nothing) Then
                runningTask = Nothing
                myTask.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents freqPeakLabel As System.Windows.Forms.Label
    Friend WithEvents powerPeakLabel As System.Windows.Forms.Label
    Friend WithEvents AcquisitionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents samplesPerChannelLabel As System.Windows.Forms.Label
    Friend WithEvents physicalChannelLabel As System.Windows.Forms.Label
    Friend WithEvents samplingRateLabel As System.Windows.Forms.Label
    Friend WithEvents channelTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents windowComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents windowLabel As System.Windows.Forms.Label
    Friend WithEvents unitsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents unitsLabel As System.Windows.Forms.Label
    Friend WithEvents scaleLabel As System.Windows.Forms.Label
    Friend WithEvents scaleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents acquisitionStateSwitch As NationalInstruments.UI.WindowsForms.Switch
    Friend WithEvents acquiredDataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents waveformPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents waveformXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents waveformYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents powerSpectrumWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents xyCursor As NationalInstruments.UI.XYCursor
    Friend WithEvents powerSpectrumPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents powerSpectrumxAxis As NationalInstruments.UI.XAxis
    Friend WithEvents powerSpectrumYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents acquisitionLabel As System.Windows.Forms.Label
    Friend WithEvents samplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents rateNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakPowerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.freqPeakLabel = New System.Windows.Forms.Label()
        Me.powerPeakLabel = New System.Windows.Forms.Label()
        Me.AcquisitionGroupBox = New System.Windows.Forms.GroupBox()
        Me.rateNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.samplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.samplesPerChannelLabel = New System.Windows.Forms.Label()
        Me.physicalChannelLabel = New System.Windows.Forms.Label()
        Me.samplingRateLabel = New System.Windows.Forms.Label()
        Me.channelTextBox = New System.Windows.Forms.TextBox()
        Me.SettingsGroupBox = New System.Windows.Forms.GroupBox()
        Me.windowComboBox = New System.Windows.Forms.ComboBox()
        Me.windowLabel = New System.Windows.Forms.Label()
        Me.unitsComboBox = New System.Windows.Forms.ComboBox()
        Me.unitsLabel = New System.Windows.Forms.Label()
        Me.scaleComboBox = New System.Windows.Forms.ComboBox()
        Me.scaleLabel = New System.Windows.Forms.Label()
        Me.acquisitionStateSwitch = New NationalInstruments.UI.WindowsForms.Switch()
        Me.acquiredDataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph()
        Me.waveformPlot = New NationalInstruments.UI.WaveformPlot()
        Me.waveformXAxis = New NationalInstruments.UI.XAxis()
        Me.waveformYAxis = New NationalInstruments.UI.YAxis()
        Me.powerSpectrumWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph()
        Me.xyCursor = New NationalInstruments.UI.XYCursor()
        Me.powerSpectrumPlot = New NationalInstruments.UI.WaveformPlot()
        Me.powerSpectrumxAxis = New NationalInstruments.UI.XAxis()
        Me.powerSpectrumYAxis = New NationalInstruments.UI.YAxis()
        Me.acquisitionLabel = New System.Windows.Forms.Label()
        Me.peakPowerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.peakFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.AcquisitionGroupBox.SuspendLayout()
        CType(Me.rateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsGroupBox.SuspendLayout()
        CType(Me.acquisitionStateSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acquiredDataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.powerSpectrumWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xyCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakPowerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'freqPeakLabel
        '
        Me.freqPeakLabel.Location = New System.Drawing.Point(432, 464)
        Me.freqPeakLabel.Name = "freqPeakLabel"
        Me.freqPeakLabel.Size = New System.Drawing.Size(96, 16)
        Me.freqPeakLabel.TabIndex = 8
        Me.freqPeakLabel.Text = "Frequency Peak:"
        '
        'powerPeakLabel
        '
        Me.powerPeakLabel.Location = New System.Drawing.Point(216, 464)
        Me.powerPeakLabel.Name = "powerPeakLabel"
        Me.powerPeakLabel.Size = New System.Drawing.Size(72, 16)
        Me.powerPeakLabel.TabIndex = 6
        Me.powerPeakLabel.Text = "Power Peak:"
        '
        'AcquisitionGroupBox
        '
        Me.AcquisitionGroupBox.Controls.Add(Me.rateNumericEdit)
        Me.AcquisitionGroupBox.Controls.Add(Me.samplesNumericEdit)
        Me.AcquisitionGroupBox.Controls.Add(Me.samplesPerChannelLabel)
        Me.AcquisitionGroupBox.Controls.Add(Me.physicalChannelLabel)
        Me.AcquisitionGroupBox.Controls.Add(Me.samplingRateLabel)
        Me.AcquisitionGroupBox.Controls.Add(Me.channelTextBox)
        Me.AcquisitionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.AcquisitionGroupBox.Location = New System.Drawing.Point(16, 16)
        Me.AcquisitionGroupBox.Name = "AcquisitionGroupBox"
        Me.AcquisitionGroupBox.Size = New System.Drawing.Size(160, 192)
        Me.AcquisitionGroupBox.TabIndex = 0
        Me.AcquisitionGroupBox.TabStop = False
        Me.AcquisitionGroupBox.Text = "Acquisition Settings"
        '
        'rateNumericEdit
        '
        Me.rateNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval
        Me.rateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.rateNumericEdit.Location = New System.Drawing.Point(27, 99)
        Me.rateNumericEdit.Name = "rateNumericEdit"
        Me.rateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.rateNumericEdit.Range = New NationalInstruments.UI.Range(1.0R, 33554432.0R)
        Me.rateNumericEdit.Size = New System.Drawing.Size(88, 20)
        Me.rateNumericEdit.TabIndex = 5
        Me.rateNumericEdit.Value = 1000.0R
        '
        'samplesNumericEdit
        '
        Me.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.samplesNumericEdit.Location = New System.Drawing.Point(27, 155)
        Me.samplesNumericEdit.Name = "samplesNumericEdit"
        Me.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplesNumericEdit.Range = New NationalInstruments.UI.Range(1.0R, 6666666.0R)
        Me.samplesNumericEdit.Size = New System.Drawing.Size(88, 20)
        Me.samplesNumericEdit.TabIndex = 3
        Me.samplesNumericEdit.Value = 10000.0R
        '
        'samplesPerChannelLabel
        '
        Me.samplesPerChannelLabel.Location = New System.Drawing.Point(24, 136)
        Me.samplesPerChannelLabel.Name = "samplesPerChannelLabel"
        Me.samplesPerChannelLabel.Size = New System.Drawing.Size(120, 16)
        Me.samplesPerChannelLabel.TabIndex = 4
        Me.samplesPerChannelLabel.Text = "Samples per Channel"
        '
        'physicalChannelLabel
        '
        Me.physicalChannelLabel.Location = New System.Drawing.Point(24, 24)
        Me.physicalChannelLabel.Name = "physicalChannelLabel"
        Me.physicalChannelLabel.Size = New System.Drawing.Size(96, 16)
        Me.physicalChannelLabel.TabIndex = 0
        Me.physicalChannelLabel.Text = "Physical Channel:"
        '
        'samplingRateLabel
        '
        Me.samplingRateLabel.Location = New System.Drawing.Point(24, 80)
        Me.samplingRateLabel.Name = "samplingRateLabel"
        Me.samplingRateLabel.Size = New System.Drawing.Size(112, 16)
        Me.samplingRateLabel.TabIndex = 2
        Me.samplingRateLabel.Text = "Sampling Rate (Hz):"
        '
        'channelTextBox
        '
        Me.channelTextBox.Location = New System.Drawing.Point(24, 40)
        Me.channelTextBox.Name = "channelTextBox"
        Me.channelTextBox.Size = New System.Drawing.Size(88, 20)
        Me.channelTextBox.TabIndex = 1
        Me.channelTextBox.Text = "Dev1/ai0"
        '
        'SettingsGroupBox
        '
        Me.SettingsGroupBox.Controls.Add(Me.windowComboBox)
        Me.SettingsGroupBox.Controls.Add(Me.windowLabel)
        Me.SettingsGroupBox.Controls.Add(Me.unitsComboBox)
        Me.SettingsGroupBox.Controls.Add(Me.unitsLabel)
        Me.SettingsGroupBox.Controls.Add(Me.scaleComboBox)
        Me.SettingsGroupBox.Controls.Add(Me.scaleLabel)
        Me.SettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SettingsGroupBox.Location = New System.Drawing.Point(16, 216)
        Me.SettingsGroupBox.Name = "SettingsGroupBox"
        Me.SettingsGroupBox.Size = New System.Drawing.Size(160, 184)
        Me.SettingsGroupBox.TabIndex = 2
        Me.SettingsGroupBox.TabStop = False
        Me.SettingsGroupBox.Text = "Display Settings"
        '
        'windowComboBox
        '
        Me.windowComboBox.Items.AddRange(New Object() {"Rectangular", "Hanning", "Hamming", "Blackman-Harris", "Exact Blackman", "Blackman", "FlatTop", "4Term B-Harris", "7Term B-Harris"})
        Me.windowComboBox.Location = New System.Drawing.Point(24, 48)
        Me.windowComboBox.Name = "windowComboBox"
        Me.windowComboBox.Size = New System.Drawing.Size(112, 21)
        Me.windowComboBox.TabIndex = 1
        Me.windowComboBox.Text = "FlatTop"
        '
        'windowLabel
        '
        Me.windowLabel.Location = New System.Drawing.Point(24, 32)
        Me.windowLabel.Name = "windowLabel"
        Me.windowLabel.Size = New System.Drawing.Size(72, 16)
        Me.windowLabel.TabIndex = 0
        Me.windowLabel.Text = "Window"
        '
        'unitsComboBox
        '
        Me.unitsComboBox.Items.AddRange(New Object() {"Vrms", "Vrms^2", "Vrms/rt(Hz)", "Vpk^2/Hz", "Vpk", "Vpk^2", "Vpk/rt(Hz)", "Vrms^2/Hz"})
        Me.unitsComboBox.Location = New System.Drawing.Point(24, 96)
        Me.unitsComboBox.Name = "unitsComboBox"
        Me.unitsComboBox.Size = New System.Drawing.Size(112, 21)
        Me.unitsComboBox.TabIndex = 3
        Me.unitsComboBox.Text = "Vrms"
        '
        'unitsLabel
        '
        Me.unitsLabel.Location = New System.Drawing.Point(24, 80)
        Me.unitsLabel.Name = "unitsLabel"
        Me.unitsLabel.Size = New System.Drawing.Size(40, 16)
        Me.unitsLabel.TabIndex = 2
        Me.unitsLabel.Text = "Units"
        '
        'scaleComboBox
        '
        Me.scaleComboBox.Items.AddRange(New Object() {"Linear", "dB", "dBm"})
        Me.scaleComboBox.Location = New System.Drawing.Point(24, 144)
        Me.scaleComboBox.Name = "scaleComboBox"
        Me.scaleComboBox.Size = New System.Drawing.Size(112, 21)
        Me.scaleComboBox.TabIndex = 5
        Me.scaleComboBox.Text = "Linear"
        '
        'scaleLabel
        '
        Me.scaleLabel.Location = New System.Drawing.Point(24, 128)
        Me.scaleLabel.Name = "scaleLabel"
        Me.scaleLabel.Size = New System.Drawing.Size(48, 16)
        Me.scaleLabel.TabIndex = 4
        Me.scaleLabel.Text = "Scale"
        '
        'acquisitionStateSwitch
        '
        Me.acquisitionStateSwitch.CaptionPosition = NationalInstruments.UI.CaptionPosition.Left
        Me.acquisitionStateSwitch.Location = New System.Drawing.Point(120, 400)
        Me.acquisitionStateSwitch.Name = "acquisitionStateSwitch"
        Me.acquisitionStateSwitch.OffColor = System.Drawing.Color.OrangeRed
        Me.acquisitionStateSwitch.OnColor = System.Drawing.Color.LawnGreen
        Me.acquisitionStateSwitch.Size = New System.Drawing.Size(56, 96)
        Me.acquisitionStateSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.acquisitionStateSwitch.TabIndex = 5
        '
        'acquiredDataWaveformGraph
        '
        Me.acquiredDataWaveformGraph.Caption = "Acquired Data"
        Me.acquiredDataWaveformGraph.Location = New System.Drawing.Point(192, 8)
        Me.acquiredDataWaveformGraph.Name = "acquiredDataWaveformGraph"
        Me.acquiredDataWaveformGraph.PlotAreaColor = System.Drawing.Color.White
        Me.acquiredDataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot})
        Me.acquiredDataWaveformGraph.Size = New System.Drawing.Size(456, 216)
        Me.acquiredDataWaveformGraph.TabIndex = 0
        Me.acquiredDataWaveformGraph.TabStop = False
        Me.acquiredDataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.waveformXAxis})
        Me.acquiredDataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.waveformYAxis})
        '
        'waveformPlot
        '
        Me.waveformPlot.LineColor = System.Drawing.Color.Red
        Me.waveformPlot.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor
        Me.waveformPlot.XAxis = Me.waveformXAxis
        Me.waveformPlot.YAxis = Me.waveformYAxis
        '
        'waveformXAxis
        '
        Me.waveformXAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue
        Me.waveformXAxis.MajorDivisions.GridVisible = True
        '
        'waveformYAxis
        '
        Me.waveformYAxis.Caption = "Volts"
        Me.waveformYAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue
        Me.waveformYAxis.MajorDivisions.GridVisible = True
        '
        'powerSpectrumWaveformGraph
        '
        Me.powerSpectrumWaveformGraph.Caption = "Power Spectrum"
        Me.powerSpectrumWaveformGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.xyCursor})
        Me.powerSpectrumWaveformGraph.Location = New System.Drawing.Point(192, 232)
        Me.powerSpectrumWaveformGraph.Name = "powerSpectrumWaveformGraph"
        Me.powerSpectrumWaveformGraph.PlotAreaColor = System.Drawing.Color.White
        Me.powerSpectrumWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.powerSpectrumPlot})
        Me.powerSpectrumWaveformGraph.Size = New System.Drawing.Size(456, 216)
        Me.powerSpectrumWaveformGraph.TabIndex = 3
        Me.powerSpectrumWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.powerSpectrumxAxis})
        Me.powerSpectrumWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.powerSpectrumYAxis})
        '
        'xyCursor
        '
        Me.xyCursor.Color = System.Drawing.Color.SeaGreen
        Me.xyCursor.Plot = Me.powerSpectrumPlot
        '
        'powerSpectrumPlot
        '
        Me.powerSpectrumPlot.LineColor = System.Drawing.Color.Red
        Me.powerSpectrumPlot.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor
        Me.powerSpectrumPlot.XAxis = Me.powerSpectrumxAxis
        Me.powerSpectrumPlot.YAxis = Me.powerSpectrumYAxis
        '
        'powerSpectrumxAxis
        '
        Me.powerSpectrumxAxis.Caption = "Hertz"
        Me.powerSpectrumxAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue
        Me.powerSpectrumxAxis.MajorDivisions.GridVisible = True
        '
        'powerSpectrumYAxis
        '
        Me.powerSpectrumYAxis.Caption = "Vms"
        Me.powerSpectrumYAxis.MajorDivisions.GridColor = System.Drawing.Color.DodgerBlue
        Me.powerSpectrumYAxis.MajorDivisions.GridVisible = True
        Me.powerSpectrumYAxis.MinorDivisions.GridColor = System.Drawing.Color.Chartreuse
        Me.powerSpectrumYAxis.Range = New NationalInstruments.UI.Range(-2.0R, 8.0R)
        '
        'acquisitionLabel
        '
        Me.acquisitionLabel.Location = New System.Drawing.Point(8, 448)
        Me.acquisitionLabel.Name = "acquisitionLabel"
        Me.acquisitionLabel.Size = New System.Drawing.Size(112, 16)
        Me.acquisitionLabel.TabIndex = 4
        Me.acquisitionLabel.Text = "Acquisition ON/OFF"
        '
        'peakPowerNumericEdit
        '
        Me.peakPowerNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.peakPowerNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.peakPowerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peakPowerNumericEdit.Location = New System.Drawing.Point(296, 464)
        Me.peakPowerNumericEdit.Name = "peakPowerNumericEdit"
        Me.peakPowerNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.peakPowerNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.peakPowerNumericEdit.TabIndex = 7
        Me.peakPowerNumericEdit.TabStop = False
        '
        'peakFrequencyNumericEdit
        '
        Me.peakFrequencyNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.peakFrequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.peakFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peakFrequencyNumericEdit.Location = New System.Drawing.Point(536, 464)
        Me.peakFrequencyNumericEdit.Name = "peakFrequencyNumericEdit"
        Me.peakFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.peakFrequencyNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.peakFrequencyNumericEdit.TabIndex = 9
        Me.peakFrequencyNumericEdit.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(672, 502)
        Me.Controls.Add(Me.peakFrequencyNumericEdit)
        Me.Controls.Add(Me.peakPowerNumericEdit)
        Me.Controls.Add(Me.acquisitionLabel)
        Me.Controls.Add(Me.powerSpectrumWaveformGraph)
        Me.Controls.Add(Me.acquiredDataWaveformGraph)
        Me.Controls.Add(Me.acquisitionStateSwitch)
        Me.Controls.Add(Me.freqPeakLabel)
        Me.Controls.Add(Me.powerPeakLabel)
        Me.Controls.Add(Me.AcquisitionGroupBox)
        Me.Controls.Add(Me.SettingsGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Benchtop Spectrum Analyzer"
        Me.AcquisitionGroupBox.ResumeLayout(False)
        Me.AcquisitionGroupBox.PerformLayout()
        CType(Me.rateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsGroupBox.ResumeLayout(False)
        CType(Me.acquisitionStateSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acquiredDataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.powerSpectrumWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xyCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakPowerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub acquisitionStateSwitch_StateChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.ActionEventArgs) Handles acquisitionStateSwitch.StateChanged
        Try
            ' Acquisition on
            If (acquisitionStateSwitch.Value And (runningTask Is Nothing)) Then

                samplingRate = rateNumericEdit.Value
                samplesPerChannel = Convert.ToInt16(samplesNumericEdit.Value)

                myTask = New Task("aiTask")

                myTask.AIChannels.CreateVoltageChannel(channelTextBox.Text, "aiChannel", AITerminalConfiguration.Differential, -10.0, 10.0, AIVoltageUnits.Volts)
                myTask.Timing.ConfigureSampleClock("", samplingRate, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, samplesPerChannel)

                runningTask = myTask
                reader = New AnalogSingleChannelReader(myTask.Stream)
                reader.SynchronizeCallbacks = True
                reader.BeginReadMultiSample(samplesPerChannel, New AsyncCallback(AddressOf myCallback), myTask)

                rateNumericEdit.Enabled = False
                samplesNumericEdit.Enabled = False
                channelTextBox.Enabled = False

                'Acquisition off
            Else
                If Not (runningTask Is Nothing) Then
                    runningTask = Nothing
                    myTask.Dispose()
                End If
                rateNumericEdit.Enabled = True
                samplesNumericEdit.Enabled = True
                channelTextBox.Enabled = True
            End If

        Catch ex As DaqException
            MessageBox.Show(ex.Message)
            runningTask = Nothing
            myTask.Dispose()
        End Try

    End Sub

    Private Sub myCallback(ByVal ar As IAsyncResult)
        Dim data() As Double
        Try
            If (Not (runningTask Is Nothing)) AndAlso runningTask Is ar.AsyncState Then
                data = reader.EndReadMultiSample(ar)
                acquiredDataWaveformGraph.PlotY(data)
                getUnitConvertedAutoPowerSpectrum(data) ' Get power spectrum of signal waveform. 
                ' Call the following function to calculate current powerPeak and frequencyPeak.
                currentPeakData()
                ' continue to acquire if task still running
                reader.BeginReadMultiSample(samplesPerChannel, New AsyncCallback(AddressOf myCallback), myTask)
            End If

        Catch ex As DaqException
            MessageBox.Show(ex.Message)
            runningTask = Nothing
            myTask.Dispose()
        End Try
    End Sub

    Private Sub getUnitConvertedAutoPowerSpectrum(ByVal waveform() As Double)
        Dim unitConvertedSpectrum() As Double
        Dim subsetOfUnitConvertedSpectrum() As Double = New Double(samplesPerChannel / 2 - 1) {}
        Dim unit As System.Text.StringBuilder
        Dim i As Integer


        Dim scaleMode As ScalingMode = ScalingMode.Linear
        Dim unitOfdisplay As DisplayUnits = DisplayUnits.VoltsRms
        Dim scaleWindow As ScaledWindow

        'Set Window Type specified by the user.
        Select Case windowComboBox.SelectedIndex
            Case 0
                scaleWindow = ScaledWindow.CreateRectangularWindow()
            Case 1
                scaleWindow = ScaledWindow.CreateHanningWindow()
            Case 2
                scaleWindow = ScaledWindow.CreateHammingWindow()
            Case 3
                scaleWindow = ScaledWindow.CreateBlackmanHarrisWindow()
            Case 4
                scaleWindow = ScaledWindow.CreateExactBlackmanWindow()
            Case 5
                scaleWindow = ScaledWindow.CreateBlackmanWindow()
            Case 6
                scaleWindow = ScaledWindow.CreateFlatTopWindow()
            Case 7
                scaleWindow = ScaledWindow.CreateBlackmanHarris4TermWindow()
            Case 8
                scaleWindow = ScaledWindow.CreateBlackmanHarris7TermWindow()
            Case Else
                scaleWindow = ScaledWindow.CreateFlatTopWindow()
        End Select

        'Units selected by the user in which auto power spectrum has to be displayed.
        Select Case unitsComboBox.SelectedIndex
            Case 0

                unitOfdisplay = DisplayUnits.VoltsRms
            Case 1
                unitOfdisplay = DisplayUnits.VoltsRmsSquared
            Case 2
                unitOfdisplay = DisplayUnits.VoltsRmsPerRootHZ
            Case 3
                unitOfdisplay = DisplayUnits.VoltsPeakSquaredPerHZ
            Case 4
                unitOfdisplay = DisplayUnits.VoltsPeak
            Case 5
                unitOfdisplay = DisplayUnits.VoltsPeakSquared
            Case 6
                unitOfdisplay = DisplayUnits.VoltsPeakPerRootHZ
            Case 7
                unitOfdisplay = DisplayUnits.VoltsRmsSquaredPerHZ
            Case Else
                unitOfdisplay = DisplayUnits.VoltsRms
        End Select

        'Scale Selection: Linear, dB or dBm
        Select Case scaleComboBox.SelectedIndex
            Case 0
                scaleMode = ScalingMode.Linear
            Case 1
                scaleMode = ScalingMode.DB
            Case 2
                scaleMode = ScalingMode.DBM
        End Select

        'Apply window on the noisy waveform.
        scaleWindow.Apply(waveform, equivalentNoiseBandwidth, coherentGain)
        'Calculate the auto power spectrum of signal waveform.
        autoPowerSpectrum = New Double(samplesPerChannel - 1) {}
        autoPowerSpectrum = Measurements.AutoPowerSpectrum(waveform, 1.0 / samplingRate, df)
        unit = New System.Text.StringBuilder("V", 256)
        'Unit conversion of auto power spectrum as specified by the user.
        unitConvertedSpectrum = New Double(samplesPerChannel - 1) {}
        unitConvertedSpectrum = Measurements.SpectrumUnitConversion(autoPowerSpectrum, NationalInstruments.Analysis.SpectralMeasurements.SpectrumType.Power, scaleMode, unitOfdisplay, df, equivalentNoiseBandwidth, coherentGain, unit)
        'Set the caption of yAxis according to the chosen unit of display.
        powerSpectrumYAxis.Caption = unit.ToString()

        For i = 0 To samplesPerChannel / 2 - 1
            subsetOfUnitConvertedSpectrum(i) = unitConvertedSpectrum(i)
        Next i
        'Plot unitConvertedSpectrum.        
        powerSpectrumWaveformGraph.PlotY(subsetOfUnitConvertedSpectrum, 0, df)
    End Sub

    Private Sub currentPeakData()
        Dim frequencyPeak As Double
        Dim powerPeak As Double

        searchFrequency = xyCursor.XPosition    'Get the current XPosition of cursor.
        'Apply PowerFrequencyEstimate function.
        Measurements.PowerFrequencyEstimate(autoPowerSpectrum, searchFrequency, equivalentNoiseBandwidth, coherentGain, df, 7, frequencyPeak, powerPeak)
        peakFrequencyNumericEdit.Value = frequencyPeak
        peakPowerNumericEdit.Value = powerPeak
    End Sub

End Class
