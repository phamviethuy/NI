Public Class MainForm
    Inherits System.Windows.Forms.Form
    Dim autoPowerSpectrum() As Double
    Dim waveform() As Double
    Dim noiseWave() As Double
    Dim searchFrequency As Double
    Dim equivalentNoiseBandwidth As Double
    Dim coherentGain As Double
    Dim df As Double
    Dim powerFrequencyEstimateClicked As Boolean = False


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        inputSignalComboBox.SelectedIndex = 0
        windowComboBox.SelectedIndex = 0
        unitsComboBox.SelectedIndex = 0
        scaleComboBox.SelectedIndex = 0

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
    Friend WithEvents inputSignalLabel As System.Windows.Forms.Label
    Friend WithEvents unitsLabel As System.Windows.Forms.Label
    Friend WithEvents scaleLabel As System.Windows.Forms.Label
    Friend WithEvents noiseRatioLabel As System.Windows.Forms.Label
    Friend WithEvents peakFrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents powerPeakLabel As System.Windows.Forms.Label
    Friend WithEvents inputSignalPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents powerPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents xyCursor As NationalInstruments.UI.XYCursor
    Friend WithEvents settingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents windowOpsLabel As System.Windows.Forms.Label
    Friend WithEvents inputXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents inputYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents powerXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents powerYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents descriptionLabel As System.Windows.Forms.Label
    Friend WithEvents inputSignalComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents windowComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents unitsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents scaleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents powerFrequencyEstimateButton As System.Windows.Forms.Button
    Friend WithEvents noiseRatioNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakPowerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents inputSignalWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents powerSpectrumWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.settingsGroupBox = New System.Windows.Forms.GroupBox
        Me.noiseRatioNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.inputSignalComboBox = New System.Windows.Forms.ComboBox
        Me.inputSignalLabel = New System.Windows.Forms.Label
        Me.windowComboBox = New System.Windows.Forms.ComboBox
        Me.windowOpsLabel = New System.Windows.Forms.Label
        Me.unitsComboBox = New System.Windows.Forms.ComboBox
        Me.unitsLabel = New System.Windows.Forms.Label
        Me.scaleComboBox = New System.Windows.Forms.ComboBox
        Me.scaleLabel = New System.Windows.Forms.Label
        Me.noiseRatioLabel = New System.Windows.Forms.Label
        Me.peakFrequencyLabel = New System.Windows.Forms.Label
        Me.powerPeakLabel = New System.Windows.Forms.Label
        Me.powerFrequencyEstimateButton = New System.Windows.Forms.Button
        Me.inputSignalWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.inputSignalPlot = New NationalInstruments.UI.WaveformPlot
        Me.inputXAxis = New NationalInstruments.UI.XAxis
        Me.inputYAxis = New NationalInstruments.UI.YAxis
        Me.powerSpectrumWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.xyCursor = New NationalInstruments.UI.XYCursor
        Me.powerPlot = New NationalInstruments.UI.WaveformPlot
        Me.powerXAxis = New NationalInstruments.UI.XAxis
        Me.powerYAxis = New NationalInstruments.UI.YAxis
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.peakFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peakPowerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.descriptionLabel = New System.Windows.Forms.Label
        Me.settingsGroupBox.SuspendLayout()
        CType(Me.noiseRatioNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.inputSignalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.powerSpectrumWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xyCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakPowerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'settingsGroupBox
        '
        Me.settingsGroupBox.Controls.Add(Me.noiseRatioNumericEdit)
        Me.settingsGroupBox.Controls.Add(Me.inputSignalComboBox)
        Me.settingsGroupBox.Controls.Add(Me.inputSignalLabel)
        Me.settingsGroupBox.Controls.Add(Me.windowComboBox)
        Me.settingsGroupBox.Controls.Add(Me.windowOpsLabel)
        Me.settingsGroupBox.Controls.Add(Me.unitsComboBox)
        Me.settingsGroupBox.Controls.Add(Me.unitsLabel)
        Me.settingsGroupBox.Controls.Add(Me.scaleComboBox)
        Me.settingsGroupBox.Controls.Add(Me.scaleLabel)
        Me.settingsGroupBox.Controls.Add(Me.noiseRatioLabel)
        Me.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.settingsGroupBox.Location = New System.Drawing.Point(24, 8)
        Me.settingsGroupBox.Name = "settingsGroupBox"
        Me.settingsGroupBox.Size = New System.Drawing.Size(136, 264)
        Me.settingsGroupBox.TabIndex = 1
        Me.settingsGroupBox.TabStop = False
        Me.settingsGroupBox.Text = "Signal Parameters"
        '
        'noiseRatioNumericEdit
        '
        Me.noiseRatioNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.noiseRatioNumericEdit.Location = New System.Drawing.Point(16, 232)
        Me.noiseRatioNumericEdit.Name = "noiseRatioNumericEdit"
        Me.noiseRatioNumericEdit.Size = New System.Drawing.Size(104, 20)
        Me.noiseRatioNumericEdit.TabIndex = 4
        '
        'inputSignalComboBox
        '
        Me.inputSignalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.inputSignalComboBox.Items.AddRange(New Object() {"Square", "SineWave", "Triangular"})
        Me.inputSignalComboBox.Location = New System.Drawing.Point(16, 40)
        Me.inputSignalComboBox.Name = "inputSignalComboBox"
        Me.inputSignalComboBox.Size = New System.Drawing.Size(104, 21)
        Me.inputSignalComboBox.TabIndex = 0
        '
        'inputSignalLabel
        '
        Me.inputSignalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.inputSignalLabel.Location = New System.Drawing.Point(16, 24)
        Me.inputSignalLabel.Name = "inputSignalLabel"
        Me.inputSignalLabel.Size = New System.Drawing.Size(72, 16)
        Me.inputSignalLabel.TabIndex = 3
        Me.inputSignalLabel.Text = "Input Signal:"
        '
        'windowComboBox
        '
        Me.windowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.windowComboBox.Items.AddRange(New Object() {"None", "Hanning", "Hamming", "Blackman-Harris", "Exact Blackman", "Blackman", "FlatTop", "4Term B-Harris", "7Term B-Harris", "Low Side Lobe", "BlackmanNuttall", "Dolph Chebyshev", "Triangle", "Kaiser", "Gaussian"})
        Me.windowComboBox.Location = New System.Drawing.Point(16, 88)
        Me.windowComboBox.Name = "windowComboBox"
        Me.windowComboBox.Size = New System.Drawing.Size(104, 21)
        Me.windowComboBox.TabIndex = 1
        '
        'windowOpsLabel
        '
        Me.windowOpsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.windowOpsLabel.Location = New System.Drawing.Point(16, 72)
        Me.windowOpsLabel.Name = "windowOpsLabel"
        Me.windowOpsLabel.Size = New System.Drawing.Size(112, 16)
        Me.windowOpsLabel.TabIndex = 3
        Me.windowOpsLabel.Text = "Windows:"
        '
        'unitsComboBox
        '
        Me.unitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unitsComboBox.Items.AddRange(New Object() {"Vrms", "Vrms^2", "Vrms/rt(Hz)", "Vpk^2/Hz", "Vpk", "Vpk^2", "Vpk/rt(Hz)", "Vrms^2/Hz"})
        Me.unitsComboBox.Location = New System.Drawing.Point(16, 136)
        Me.unitsComboBox.Name = "unitsComboBox"
        Me.unitsComboBox.Size = New System.Drawing.Size(104, 21)
        Me.unitsComboBox.TabIndex = 2
        '
        'unitsLabel
        '
        Me.unitsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.unitsLabel.Location = New System.Drawing.Point(16, 120)
        Me.unitsLabel.Name = "unitsLabel"
        Me.unitsLabel.Size = New System.Drawing.Size(40, 16)
        Me.unitsLabel.TabIndex = 3
        Me.unitsLabel.Text = "Units:"
        '
        'scaleComboBox
        '
        Me.scaleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.scaleComboBox.Items.AddRange(New Object() {"Linear", "dB", "dBm"})
        Me.scaleComboBox.Location = New System.Drawing.Point(16, 184)
        Me.scaleComboBox.Name = "scaleComboBox"
        Me.scaleComboBox.Size = New System.Drawing.Size(104, 21)
        Me.scaleComboBox.TabIndex = 3
        '
        'scaleLabel
        '
        Me.scaleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.scaleLabel.Location = New System.Drawing.Point(16, 168)
        Me.scaleLabel.Name = "scaleLabel"
        Me.scaleLabel.Size = New System.Drawing.Size(48, 16)
        Me.scaleLabel.TabIndex = 3
        Me.scaleLabel.Text = "Scale:"
        '
        'noiseRatioLabel
        '
        Me.noiseRatioLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noiseRatioLabel.Location = New System.Drawing.Point(16, 216)
        Me.noiseRatioLabel.Name = "noiseRatioLabel"
        Me.noiseRatioLabel.Size = New System.Drawing.Size(80, 16)
        Me.noiseRatioLabel.TabIndex = 7
        Me.noiseRatioLabel.Text = "Noise Ratio:"
        '
        'peakFrequencyLabel
        '
        Me.peakFrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.peakFrequencyLabel.Location = New System.Drawing.Point(40, 288)
        Me.peakFrequencyLabel.Name = "peakFrequencyLabel"
        Me.peakFrequencyLabel.Size = New System.Drawing.Size(104, 16)
        Me.peakFrequencyLabel.TabIndex = 17
        Me.peakFrequencyLabel.Text = "Peak Frequency:"
        '
        'powerPeakLabel
        '
        Me.powerPeakLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.powerPeakLabel.Location = New System.Drawing.Point(40, 328)
        Me.powerPeakLabel.Name = "powerPeakLabel"
        Me.powerPeakLabel.Size = New System.Drawing.Size(104, 16)
        Me.powerPeakLabel.TabIndex = 16
        Me.powerPeakLabel.Text = "Power Peak:"
        '
        'powerFrequencyEstimateButton
        '
        Me.powerFrequencyEstimateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.powerFrequencyEstimateButton.Location = New System.Drawing.Point(16, 376)
        Me.powerFrequencyEstimateButton.Name = "powerFrequencyEstimateButton"
        Me.powerFrequencyEstimateButton.Size = New System.Drawing.Size(152, 32)
        Me.powerFrequencyEstimateButton.TabIndex = 0
        Me.powerFrequencyEstimateButton.Text = "Power Frequency Estimate"
        Me.toolTip.SetToolTip(Me.powerFrequencyEstimateButton, "Calculate the estimated power and frequency around a peak in the Power Spectrum.")
        '
        'inputSignalWaveformGraph
        '
        Me.inputSignalWaveformGraph.Caption = "Input Signal"
        Me.inputSignalWaveformGraph.Location = New System.Drawing.Point(192, 8)
        Me.inputSignalWaveformGraph.Name = "inputSignalWaveformGraph"
        Me.inputSignalWaveformGraph.UseColorGenerator = True
        Me.inputSignalWaveformGraph.PlotAreaColor = System.Drawing.Color.White
        Me.inputSignalWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.inputSignalPlot})
        Me.inputSignalWaveformGraph.Size = New System.Drawing.Size(408, 192)
        Me.inputSignalWaveformGraph.TabIndex = 20
        Me.inputSignalWaveformGraph.TabStop = False
        Me.inputSignalWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.inputXAxis})
        Me.inputSignalWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.inputYAxis})
        '
        'inputSignalPlot
        '
        Me.inputSignalPlot.XAxis = Me.inputXAxis
        Me.inputSignalPlot.YAxis = Me.inputYAxis
        '
        'inputXAxis
        '
        Me.inputXAxis.Caption = "Sec"
        Me.inputXAxis.MajorDivisions.GridColor = System.Drawing.Color.Cyan
        Me.inputXAxis.MajorDivisions.GridVisible = True
        Me.inputXAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact
        '
        'inputYAxis
        '
        Me.inputYAxis.Caption = "Amplitude"
        '
        'powerSpectrumWaveformGraph
        '
        Me.powerSpectrumWaveformGraph.Caption = "Power Spectrum"
        Me.powerSpectrumWaveformGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.xyCursor})
        Me.powerSpectrumWaveformGraph.Location = New System.Drawing.Point(192, 216)
        Me.powerSpectrumWaveformGraph.Name = "powerSpectrumWaveformGraph"
        Me.powerSpectrumWaveformGraph.UseColorGenerator = True
        Me.powerSpectrumWaveformGraph.PlotAreaColor = System.Drawing.Color.White
        Me.powerSpectrumWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.powerPlot})
        Me.powerSpectrumWaveformGraph.Size = New System.Drawing.Size(408, 192)
        Me.powerSpectrumWaveformGraph.TabIndex = 21
        Me.powerSpectrumWaveformGraph.TabStop = False
        Me.powerSpectrumWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.powerXAxis})
        Me.powerSpectrumWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.powerYAxis})
        '
        'xyCursor
        '
        Me.xyCursor.Color = System.Drawing.Color.Green
        Me.xyCursor.Plot = Me.powerPlot
        Me.xyCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating
        Me.xyCursor.XPosition = 0
        Me.xyCursor.YPosition = 0.5
        '
        'powerPlot
        '
        Me.powerPlot.XAxis = Me.powerXAxis
        Me.powerPlot.YAxis = Me.powerYAxis
        '
        'powerXAxis
        '
        Me.powerXAxis.Caption = "Hz"
        '
        'powerYAxis
        '
        Me.powerYAxis.Caption = "Vrms"
        '
        'peakFrequencyNumericEdit
        '
        Me.peakFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peakFrequencyNumericEdit.Location = New System.Drawing.Point(40, 304)
        Me.peakFrequencyNumericEdit.Name = "peakFrequencyNumericEdit"
        Me.peakFrequencyNumericEdit.Size = New System.Drawing.Size(104, 20)
        Me.peakFrequencyNumericEdit.TabIndex = 22
        Me.peakFrequencyNumericEdit.TabStop = False
        '
        'peakPowerNumericEdit
        '
        Me.peakPowerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peakPowerNumericEdit.Location = New System.Drawing.Point(40, 344)
        Me.peakPowerNumericEdit.Name = "peakPowerNumericEdit"
        Me.peakPowerNumericEdit.Size = New System.Drawing.Size(104, 20)
        Me.peakPowerNumericEdit.TabIndex = 23
        Me.peakPowerNumericEdit.TabStop = False
        '
        'descriptionLabel
        '
        Me.descriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.descriptionLabel.Location = New System.Drawing.Point(24, 424)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(576, 50)
        Me.descriptionLabel.TabIndex = 29
        Me.descriptionLabel.Text = "This program uses the Spectrum and PowerFrequencyEstimate functions. The top grap" & _
        "h displays the input signal in the time domain and the bottom graph displays the" & _
        " power spectrum of the filtered input signal. Moving the graph cursor around the" & _
        " plot area will display the peak frequency and the power at that location."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(618, 493)
        Me.Controls.Add(Me.descriptionLabel)
        Me.Controls.Add(Me.peakPowerNumericEdit)
        Me.Controls.Add(Me.peakFrequencyNumericEdit)
        Me.Controls.Add(Me.powerSpectrumWaveformGraph)
        Me.Controls.Add(Me.inputSignalWaveformGraph)
        Me.Controls.Add(Me.powerFrequencyEstimateButton)
        Me.Controls.Add(Me.peakFrequencyLabel)
        Me.Controls.Add(Me.powerPeakLabel)
        Me.Controls.Add(Me.settingsGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Power Frequency Estimator"
        Me.settingsGroupBox.ResumeLayout(False)
        CType(Me.noiseRatioNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.inputSignalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.powerSpectrumWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xyCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakPowerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    'When PowerFrequecnyEstimate button is clicked.
    Private Sub powerFrequencyEstimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles powerFrequencyEstimateButton.Click
        GenerateInputSignal() 'Generate Input Signal.
        GetUnitConvertedAutoPowerSpectrum(waveform) ' Get the power spectrum of waveform signal.
        'Call the following function to calculate current powerPeak and frequencyPeak.
        CurrentPeakData()
    End Sub

    'Calculates the estimated power and frequency around a peak in the power spectrum of a time-domain signal.
    Private Sub CurrentPeakData()
        Dim frequencyPeak As Double
        Dim powerPeak As Double
        If (powerFrequencyEstimateClicked) Then 'To check that atleast once PowerFrequencyEstimate button is clicked.
            searchFrequency = xyCursor.XPosition    'Get the current XPosition of cursor.
            'Apply PowerFrequencyEstimate function.
            Measurements.PowerFrequencyEstimate(autoPowerSpectrum, searchFrequency, equivalentNoiseBandwidth, coherentGain, df, 7, frequencyPeak, powerPeak)
            peakFrequencyNumericEdit.Text = String.Format("{0:F4}", frequencyPeak)
            peakPowerNumericEdit.Text = String.Format("{0:F4}", powerPeak)
        Else
            powerFrequencyEstimateButton.PerformClick()
        End If
    End Sub

    ' Generate noise based on the value of noiseRatio.
    Private Sub GenerateNoise()
        Dim noise As Double
        noise = noiseRatioNumericEdit.Value 'Take the value of noise from noise ratio slide.
        noise = noise / 100
        noiseWave = New Double(512 - 1) {}
        noiseWave.Initialize()
        'Generate white noise. 
        Dim whiteNoise As WhiteNoiseSignal = New WhiteNoiseSignal(noise, 0)
        noiseWave = whiteNoise.Generate(512, 512)
    End Sub

    Private Sub GetUnitConvertedAutoPowerSpectrum(ByVal waveform() As Double)

        Dim unitConvertedSpectrum() As Double
        Dim subsetOfUnitConvertedSpectrum() As Double = New Double(128 - 1) {}
        Dim unit As System.Text.StringBuilder
        Dim i As Integer

        powerFrequencyEstimateClicked = True

        Dim scaleMode As ScalingMode = ScalingMode.Linear
        Dim unitOfdisplay As DisplayUnits = DisplayUnits.VoltsRms

        'Set Window Type specified by the user.
        'Create a scaled window of type specified 

        Dim scaleWindow As ScaledWindow
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
            Case 9
                scaleWindow = ScaledWindow.CreateLowSideLobeWindow()
            Case 10
                scaleWindow = ScaledWindow.CreateBlackmanNuttallWindow()
            Case 11
                scaleWindow = ScaledWindow.CreateDolphChebyshevWindow()
            Case 12
                scaleWindow = ScaledWindow.CreateTriangleWindow()
            Case 13
                scaleWindow = ScaledWindow.CreateKaiserWindow()
            Case 14
                scaleWindow = ScaledWindow.CreateGaussianWindow()
            Case Else
                scaleWindow = ScaledWindow.CreateHanningWindow()

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



        ' Apply noisy waveform
        scaleWindow.Apply(waveform, equivalentNoiseBandwidth, coherentGain)
        'Calculate the auto power spectrum of signal waveform.
        autoPowerSpectrum = New Double(512 / 2 - 1) {}
        autoPowerSpectrum = Measurements.AutoPowerSpectrum(waveform, 1.0 / 512, df)
        unit = New System.Text.StringBuilder("V", 256)
        'Unit conversion of auto power spectrum as specified by the user.
        unitConvertedSpectrum = New Double(512 / 2 - 1) {}
        unitConvertedSpectrum = Measurements.SpectrumUnitConversion(autoPowerSpectrum, NationalInstruments.Analysis.SpectralMeasurements.SpectrumType.Power, scaleMode, unitOfdisplay, df, equivalentNoiseBandwidth, coherentGain, unit)
        'Set the caption of yAxis according to the chosen unit of display.
        powerYAxis.Caption = unit.ToString()
        For i = 0 To 127
            subsetOfUnitConvertedSpectrum(i) = unitConvertedSpectrum(i)
        Next i
        'Plot unitConvertedSpectrum.
        powerPlot.PlotY(subsetOfUnitConvertedSpectrum, 0, df)
    End Sub

    Private Sub GenerateInputSignal()
        Dim i As Integer
        waveform = New Double(512 - 1) {} 'Allocate memory for 512 samples.
        waveform.Initialize()

        'Generate input signal.
        Select Case inputSignalComboBox.SelectedIndex
            Case 0 ' Create square wave of frequency 5Hz.

                Dim squareWave As SquareSignal = New SquareSignal(5, 1.0, 0.0, 50.0)
                waveform = squareWave.Generate(512, 512) 'Sampling Rate: 512/s, numberOfSamples:512.

            Case 1 'Create sine wave of frequency 5Hz.
                Dim sineWave As SineSignal = New SineSignal(5, 1.0, 0.0)
                waveform = sineWave.Generate(512, 512) 'Sampling Rate: 512/s, numberOfSamples:512.

            Case 2 'Create triangular wave of frequency 5Hz.
                Dim triangularWave As TriangleSignal = New TriangleSignal(5, 1.0, 0.0)
                waveform = triangularWave.Generate(512, 512) 'Sampling Rate: 512/s, numberOfSamples:512.
            Case Else
                Dim squareWave As SquareSignal = New SquareSignal(5, 1.0, 0.0, 50.0)
                waveform = squareWave.Generate(512, 512) 'Sampling Rate: 512/s, numberOfSamples:512.
        End Select

        'Generate noise.
        GenerateNoise()

        'Add noise to signal waveform
        For i = 0 To (512 - 1)
            waveform(i) = waveform(i) + noiseWave(i)
        Next i

        'Plot noisy waveform.
        inputSignalPlot.PlotY(waveform, 0.0, 1.0 / 512.0)

    End Sub

    Private Sub inputSignal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inputSignalComboBox.SelectedIndexChanged
        If (powerFrequencyEstimateClicked) Then
            powerFrequencyEstimateButton.PerformClick()
        End If
    End Sub

    Private Sub noiseRatio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noiseRatioNumericEdit.ValueChanged
        If (powerFrequencyEstimateClicked) Then
            powerFrequencyEstimateButton.PerformClick()
        End If
    End Sub

    Private Sub xyCursor_BeforeMove(ByVal sender As Object, ByVal e As UI.BeforeMoveXYCursorEventArgs) Handles xyCursor.BeforeMove
        If (powerFrequencyEstimateClicked) Then
            CurrentPeakData()
        End If
    End Sub

    Private Sub window_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles windowComboBox.SelectedIndexChanged
        If (powerFrequencyEstimateClicked) Then
            GetUnitConvertedAutoPowerSpectrum(waveform) ' Get the power spectrum of waveform signal.
            'Call the following function to calculate current powerPeak and frequencyPeak.
            CurrentPeakData()
        End If
    End Sub

    Private Sub units_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles unitsComboBox.SelectedIndexChanged
        If (powerFrequencyEstimateClicked) Then
            GetUnitConvertedAutoPowerSpectrum(waveform) ' Get the power spectrum of waveform signal.
            'Call the following function to calculate current powerPeak and frequencyPeak.
            CurrentPeakData()
        End If
    End Sub

    Private Sub scale_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scaleComboBox.SelectedIndexChanged
        If (powerFrequencyEstimateClicked) Then
            GetUnitConvertedAutoPowerSpectrum(waveform) ' Get the power spectrum of waveform signal.
            'Call the following function to calculate current powerPeak and frequencyPeak.
            CurrentPeakData()
        End If
    End Sub
End Class
