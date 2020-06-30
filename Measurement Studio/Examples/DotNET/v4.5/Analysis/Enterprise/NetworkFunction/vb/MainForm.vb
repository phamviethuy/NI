
Public Class MainForm
    Inherits System.Windows.Forms.Form
    'Global Variables
    Dim waveform() As Double
    Dim xwave() As Double
    Dim xWaveform() As Double
    Dim noiseWaveform() As Double
    Dim crossPowerSpectrumMagnitude() As Double
    Dim crossPowerSpectrumPhase() As Double
    Dim frequencyResponseMagnitude() As Double
    Dim frequencyResponsePhase() As Double
    Dim coherence() As Double
    Dim impulseResponse() As Double
    Dim filteredwave() As Double
    Dim showStimulusClicked As Boolean = False
    Dim showResponseClicked As Boolean = False
    Dim impulseResponseClicked As Boolean = False
    Dim powerSpectrumMagnitudeClicked As Boolean = False
    Dim powerSpectrumPhaseClicked As Boolean = False
    Dim frequencyResponseMagnitudeClicked As Boolean = False
    Dim frequencyResponsePhaseClicked As Boolean = False

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        signalSourceComboBox.SelectedIndex = 0
        filterTypeComboBox.SelectedIndex = 0
        filterDesignComboBox.SelectedIndex = 0

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
    Friend WithEvents exampleDescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents filterDesignLabel As System.Windows.Forms.Label
    Friend WithEvents orderLabel As System.Windows.Forms.Label
    Friend WithEvents lowerCutoffLabel As System.Windows.Forms.Label
    Friend WithEvents filterTypeLabel As System.Windows.Forms.Label
    Friend WithEvents higherCutoffLabel As System.Windows.Forms.Label
    Friend WithEvents frequencyLabel As System.Windows.Forms.Label
    Friend WithEvents signalSourceLabel As System.Windows.Forms.Label
    Friend WithEvents samplingRateLabel As System.Windows.Forms.Label
    Friend WithEvents numberOfSamplesLabel As System.Windows.Forms.Label
    Friend WithEvents noiseAmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents signalAmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents impulseResponsePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents responsePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis2 As NationalInstruments.UI.XAxis
    Friend WithEvents plotStimulusButton As System.Windows.Forms.Button
    Friend WithEvents plotResponseButton As System.Windows.Forms.Button
    Friend WithEvents powerSpectrumMagnitudePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents yAxis2 As NationalInstruments.UI.YAxis
    Friend WithEvents frequencyResponseMagnitudePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents stimulusPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents powerSpectrumPhasePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents frequencyResponsePhasePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents lowerCutoffNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents orderNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents upperCutoffNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents noiseAmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents signalAmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents samplingRateNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents frequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents plotCrossPowerSpectrumMagnitudeButton As System.Windows.Forms.Button
    Friend WithEvents plotFrequencyResponseMagnitudeButton As System.Windows.Forms.Button
    Friend WithEvents plotFrequencyResponsePhaseButton As System.Windows.Forms.Button
    Friend WithEvents plotCrossPowerSpectrumPhaseButton As System.Windows.Forms.Button
    Friend WithEvents plotImpulseResponseButton As System.Windows.Forms.Button
    Friend WithEvents magnitudeScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents signalScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents phaseScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents filterTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents filterDesignComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents signalSourceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents filterOrderGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents signalSourceGroupBox As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.exampleDescriptionLabel = New System.Windows.Forms.Label
        Me.filterOrderGroupBox = New System.Windows.Forms.GroupBox
        Me.lowerCutoffNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.orderNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.filterDesignLabel = New System.Windows.Forms.Label
        Me.orderLabel = New System.Windows.Forms.Label
        Me.lowerCutoffLabel = New System.Windows.Forms.Label
        Me.filterTypeLabel = New System.Windows.Forms.Label
        Me.higherCutoffLabel = New System.Windows.Forms.Label
        Me.filterTypeComboBox = New System.Windows.Forms.ComboBox
        Me.filterDesignComboBox = New System.Windows.Forms.ComboBox
        Me.upperCutoffNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.signalSourceGroupBox = New System.Windows.Forms.GroupBox
        Me.noiseAmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.signalAmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.samplingRateNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.frequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.frequencyLabel = New System.Windows.Forms.Label
        Me.signalSourceComboBox = New System.Windows.Forms.ComboBox
        Me.signalSourceLabel = New System.Windows.Forms.Label
        Me.samplingRateLabel = New System.Windows.Forms.Label
        Me.numberOfSamplesLabel = New System.Windows.Forms.Label
        Me.noiseAmplitudeLabel = New System.Windows.Forms.Label
        Me.signalAmplitudeLabel = New System.Windows.Forms.Label
        Me.impulseResponsePlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.responsePlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis2 = New NationalInstruments.UI.XAxis
        Me.plotStimulusButton = New System.Windows.Forms.Button
        Me.plotResponseButton = New System.Windows.Forms.Button
        Me.plotCrossPowerSpectrumMagnitudeButton = New System.Windows.Forms.Button
        Me.magnitudeScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.powerSpectrumMagnitudePlot = New NationalInstruments.UI.ScatterPlot
        Me.yAxis2 = New NationalInstruments.UI.YAxis
        Me.frequencyResponseMagnitudePlot = New NationalInstruments.UI.ScatterPlot
        Me.signalScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.stimulusPlot = New NationalInstruments.UI.ScatterPlot
        Me.plotFrequencyResponseMagnitudeButton = New System.Windows.Forms.Button
        Me.plotFrequencyResponsePhaseButton = New System.Windows.Forms.Button
        Me.plotCrossPowerSpectrumPhaseButton = New System.Windows.Forms.Button
        Me.plotImpulseResponseButton = New System.Windows.Forms.Button
        Me.phaseScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.powerSpectrumPhasePlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.frequencyResponsePhasePlot = New NationalInstruments.UI.ScatterPlot
        Me.filterOrderGroupBox.SuspendLayout()
        CType(Me.lowerCutoffNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upperCutoffNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.signalSourceGroupBox.SuspendLayout()
        CType(Me.noiseAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signalAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.magnitudeScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signalScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phaseScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exampleDescriptionLabel
        '
        Me.exampleDescriptionLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.exampleDescriptionLabel.Location = New System.Drawing.Point(160, 496)
        Me.exampleDescriptionLabel.Name = "exampleDescriptionLabel"
        Me.exampleDescriptionLabel.Size = New System.Drawing.Size(424, 40)
        Me.exampleDescriptionLabel.TabIndex = 66
        Me.exampleDescriptionLabel.Text = "This example calculates network transfer functions from stimulus and response dat" & _
        "a. Cross Power Spectrum and Transfer functions between stimulus and response are" & _
        " computed and their results are shown in the corresponding graphs."
        '
        'filterOrderGroupBox
        '
        Me.filterOrderGroupBox.Controls.Add(Me.lowerCutoffNumericEdit)
        Me.filterOrderGroupBox.Controls.Add(Me.orderNumericEdit)
        Me.filterOrderGroupBox.Controls.Add(Me.filterDesignLabel)
        Me.filterOrderGroupBox.Controls.Add(Me.orderLabel)
        Me.filterOrderGroupBox.Controls.Add(Me.lowerCutoffLabel)
        Me.filterOrderGroupBox.Controls.Add(Me.filterTypeLabel)
        Me.filterOrderGroupBox.Controls.Add(Me.higherCutoffLabel)
        Me.filterOrderGroupBox.Controls.Add(Me.filterTypeComboBox)
        Me.filterOrderGroupBox.Controls.Add(Me.filterDesignComboBox)
        Me.filterOrderGroupBox.Controls.Add(Me.upperCutoffNumericEdit)
        Me.filterOrderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterOrderGroupBox.Location = New System.Drawing.Point(8, 312)
        Me.filterOrderGroupBox.Name = "filterOrderGroupBox"
        Me.filterOrderGroupBox.Size = New System.Drawing.Size(136, 264)
        Me.filterOrderGroupBox.TabIndex = 62
        Me.filterOrderGroupBox.TabStop = False
        Me.filterOrderGroupBox.Text = "Filter Parameters"
        '
        'lowerCutoffNumericEdit
        '
        Me.lowerCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.lowerCutoffNumericEdit.Location = New System.Drawing.Point(16, 175)
        Me.lowerCutoffNumericEdit.Name = "lowerCutoffNumericEdit"
        Me.lowerCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.lowerCutoffNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.lowerCutoffNumericEdit.Size = New System.Drawing.Size(104, 20)
        Me.lowerCutoffNumericEdit.TabIndex = 49
        Me.lowerCutoffNumericEdit.Value = 250
        '
        'orderNumericEdit
        '
        Me.orderNumericEdit.Location = New System.Drawing.Point(16, 128)
        Me.orderNumericEdit.Name = "orderNumericEdit"
        Me.orderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.orderNumericEdit.Range = New NationalInstruments.UI.Range(2, Double.PositiveInfinity)
        Me.orderNumericEdit.Size = New System.Drawing.Size(104, 20)
        Me.orderNumericEdit.TabIndex = 48
        Me.orderNumericEdit.Value = 2
        '
        'filterDesignLabel
        '
        Me.filterDesignLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterDesignLabel.Location = New System.Drawing.Point(16, 64)
        Me.filterDesignLabel.Name = "filterDesignLabel"
        Me.filterDesignLabel.Size = New System.Drawing.Size(88, 16)
        Me.filterDesignLabel.TabIndex = 41
        Me.filterDesignLabel.Text = "Filter Design:"
        '
        'orderLabel
        '
        Me.orderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.orderLabel.Location = New System.Drawing.Point(16, 112)
        Me.orderLabel.Name = "orderLabel"
        Me.orderLabel.Size = New System.Drawing.Size(40, 16)
        Me.orderLabel.TabIndex = 44
        Me.orderLabel.Text = "Order:"
        '
        'lowerCutoffLabel
        '
        Me.lowerCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lowerCutoffLabel.Location = New System.Drawing.Point(16, 160)
        Me.lowerCutoffLabel.Name = "lowerCutoffLabel"
        Me.lowerCutoffLabel.Size = New System.Drawing.Size(88, 16)
        Me.lowerCutoffLabel.TabIndex = 47
        Me.lowerCutoffLabel.Text = "Lower Cutoff:"
        '
        'filterTypeLabel
        '
        Me.filterTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterTypeLabel.Location = New System.Drawing.Point(16, 16)
        Me.filterTypeLabel.Name = "filterTypeLabel"
        Me.filterTypeLabel.Size = New System.Drawing.Size(88, 16)
        Me.filterTypeLabel.TabIndex = 46
        Me.filterTypeLabel.Text = "Filter Type:"
        '
        'higherCutoffLabel
        '
        Me.higherCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.higherCutoffLabel.Location = New System.Drawing.Point(16, 208)
        Me.higherCutoffLabel.Name = "higherCutoffLabel"
        Me.higherCutoffLabel.Size = New System.Drawing.Size(88, 16)
        Me.higherCutoffLabel.TabIndex = 37
        Me.higherCutoffLabel.Text = "Upper Cutoff:"
        '
        'filterTypeComboBox
        '
        Me.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterTypeComboBox.Items.AddRange(New Object() {"Lowpass", "Highpass", "Bandpass", "Bandstop"})
        Me.filterTypeComboBox.Location = New System.Drawing.Point(16, 32)
        Me.filterTypeComboBox.Name = "filterTypeComboBox"
        Me.filterTypeComboBox.Size = New System.Drawing.Size(104, 21)
        Me.filterTypeComboBox.TabIndex = 0
        '
        'filterDesignComboBox
        '
        Me.filterDesignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterDesignComboBox.Items.AddRange(New Object() {"Elliptic", "Bessel", "Butterworth", "Chebyshev", "Inv Chebyshev"})
        Me.filterDesignComboBox.Location = New System.Drawing.Point(16, 80)
        Me.filterDesignComboBox.Name = "filterDesignComboBox"
        Me.filterDesignComboBox.Size = New System.Drawing.Size(104, 21)
        Me.filterDesignComboBox.TabIndex = 1
        '
        'upperCutoffNumericEdit
        '
        Me.upperCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.upperCutoffNumericEdit.Location = New System.Drawing.Point(16, 224)
        Me.upperCutoffNumericEdit.Name = "upperCutoffNumericEdit"
        Me.upperCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.upperCutoffNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.upperCutoffNumericEdit.Size = New System.Drawing.Size(104, 20)
        Me.upperCutoffNumericEdit.TabIndex = 49
        Me.upperCutoffNumericEdit.Value = 450
        '
        'signalSourceGroupBox
        '
        Me.signalSourceGroupBox.Controls.Add(Me.noiseAmplitudeNumericEdit)
        Me.signalSourceGroupBox.Controls.Add(Me.signalAmplitudeNumericEdit)
        Me.signalSourceGroupBox.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.signalSourceGroupBox.Controls.Add(Me.samplingRateNumericEdit)
        Me.signalSourceGroupBox.Controls.Add(Me.frequencyNumericEdit)
        Me.signalSourceGroupBox.Controls.Add(Me.frequencyLabel)
        Me.signalSourceGroupBox.Controls.Add(Me.signalSourceComboBox)
        Me.signalSourceGroupBox.Controls.Add(Me.signalSourceLabel)
        Me.signalSourceGroupBox.Controls.Add(Me.samplingRateLabel)
        Me.signalSourceGroupBox.Controls.Add(Me.numberOfSamplesLabel)
        Me.signalSourceGroupBox.Controls.Add(Me.noiseAmplitudeLabel)
        Me.signalSourceGroupBox.Controls.Add(Me.signalAmplitudeLabel)
        Me.signalSourceGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalSourceGroupBox.Location = New System.Drawing.Point(8, 0)
        Me.signalSourceGroupBox.Name = "signalSourceGroupBox"
        Me.signalSourceGroupBox.Size = New System.Drawing.Size(136, 304)
        Me.signalSourceGroupBox.TabIndex = 61
        Me.signalSourceGroupBox.TabStop = False
        Me.signalSourceGroupBox.Text = "Signal Parameters"
        '
        'noiseAmplitudeNumericEdit
        '
        Me.noiseAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.noiseAmplitudeNumericEdit.Location = New System.Drawing.Point(14, 272)
        Me.noiseAmplitudeNumericEdit.Name = "noiseAmplitudeNumericEdit"
        Me.noiseAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.noiseAmplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.noiseAmplitudeNumericEdit.Size = New System.Drawing.Size(103, 20)
        Me.noiseAmplitudeNumericEdit.TabIndex = 5
        Me.noiseAmplitudeNumericEdit.Value = 0.01
        '
        'signalAmplitudeNumericEdit
        '
        Me.signalAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.signalAmplitudeNumericEdit.Location = New System.Drawing.Point(14, 224)
        Me.signalAmplitudeNumericEdit.Name = "signalAmplitudeNumericEdit"
        Me.signalAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.signalAmplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.signalAmplitudeNumericEdit.Size = New System.Drawing.Size(103, 20)
        Me.signalAmplitudeNumericEdit.TabIndex = 4
        Me.signalAmplitudeNumericEdit.Value = 1
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(14, 176)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfSamplesNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(103, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 3
        Me.numberOfSamplesNumericEdit.Value = 100
        '
        'samplingRateNumericEdit
        '
        Me.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.samplingRateNumericEdit.Location = New System.Drawing.Point(14, 128)
        Me.samplingRateNumericEdit.Name = "samplingRateNumericEdit"
        Me.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplingRateNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.samplingRateNumericEdit.Size = New System.Drawing.Size(103, 20)
        Me.samplingRateNumericEdit.TabIndex = 2
        Me.samplingRateNumericEdit.Value = 1000
        '
        'frequencyNumericEdit
        '
        Me.frequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.frequencyNumericEdit.Location = New System.Drawing.Point(14, 80)
        Me.frequencyNumericEdit.Name = "frequencyNumericEdit"
        Me.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.frequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.frequencyNumericEdit.Size = New System.Drawing.Size(103, 20)
        Me.frequencyNumericEdit.TabIndex = 1
        Me.frequencyNumericEdit.Value = 100
        '
        'frequencyLabel
        '
        Me.frequencyLabel.Enabled = False
        Me.frequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.frequencyLabel.Location = New System.Drawing.Point(14, 64)
        Me.frequencyLabel.Name = "frequencyLabel"
        Me.frequencyLabel.Size = New System.Drawing.Size(95, 16)
        Me.frequencyLabel.TabIndex = 33
        Me.frequencyLabel.Text = "Frequency:"
        '
        'signalSourceComboBox
        '
        Me.signalSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.signalSourceComboBox.Items.AddRange(New Object() {"Impulse", "Sine", "Cosine", "Square", "Triangle", "SawTooth"})
        Me.signalSourceComboBox.Location = New System.Drawing.Point(14, 32)
        Me.signalSourceComboBox.Name = "signalSourceComboBox"
        Me.signalSourceComboBox.Size = New System.Drawing.Size(103, 21)
        Me.signalSourceComboBox.TabIndex = 0
        '
        'signalSourceLabel
        '
        Me.signalSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalSourceLabel.Location = New System.Drawing.Point(14, 16)
        Me.signalSourceLabel.Name = "signalSourceLabel"
        Me.signalSourceLabel.Size = New System.Drawing.Size(87, 16)
        Me.signalSourceLabel.TabIndex = 31
        Me.signalSourceLabel.Text = "Signal Source:"
        '
        'samplingRateLabel
        '
        Me.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplingRateLabel.Location = New System.Drawing.Point(14, 112)
        Me.samplingRateLabel.Name = "samplingRateLabel"
        Me.samplingRateLabel.Size = New System.Drawing.Size(103, 16)
        Me.samplingRateLabel.TabIndex = 29
        Me.samplingRateLabel.Text = "Sampling Rate:"
        '
        'numberOfSamplesLabel
        '
        Me.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numberOfSamplesLabel.Location = New System.Drawing.Point(14, 160)
        Me.numberOfSamplesLabel.Name = "numberOfSamplesLabel"
        Me.numberOfSamplesLabel.Size = New System.Drawing.Size(111, 16)
        Me.numberOfSamplesLabel.TabIndex = 26
        Me.numberOfSamplesLabel.Text = "Number Of Samples:"
        '
        'noiseAmplitudeLabel
        '
        Me.noiseAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noiseAmplitudeLabel.Location = New System.Drawing.Point(14, 256)
        Me.noiseAmplitudeLabel.Name = "noiseAmplitudeLabel"
        Me.noiseAmplitudeLabel.Size = New System.Drawing.Size(111, 16)
        Me.noiseAmplitudeLabel.TabIndex = 27
        Me.noiseAmplitudeLabel.Text = "Noise Amplitude:"
        '
        'signalAmplitudeLabel
        '
        Me.signalAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalAmplitudeLabel.Location = New System.Drawing.Point(14, 208)
        Me.signalAmplitudeLabel.Name = "signalAmplitudeLabel"
        Me.signalAmplitudeLabel.Size = New System.Drawing.Size(103, 16)
        Me.signalAmplitudeLabel.TabIndex = 28
        Me.signalAmplitudeLabel.Text = "Signal Amplitude:"
        '
        'impulseResponsePlot
        '
        Me.impulseResponsePlot.XAxis = Me.xAxis
        Me.impulseResponsePlot.YAxis = Me.yAxis
        '
        'xAxis
        '
        Me.xAxis.Caption = "Seconds"
        '
        'yAxis
        '
        Me.yAxis.Caption = "Amplitude"
        '
        'responsePlot
        '
        Me.responsePlot.XAxis = Me.xAxis
        Me.responsePlot.YAxis = Me.yAxis
        '
        'xAxis2
        '
        Me.xAxis2.Caption = "Frequency"
        '
        'plotStimulusButton
        '
        Me.plotStimulusButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotStimulusButton.Location = New System.Drawing.Point(600, 48)
        Me.plotStimulusButton.Name = "plotStimulusButton"
        Me.plotStimulusButton.Size = New System.Drawing.Size(128, 24)
        Me.plotStimulusButton.TabIndex = 54
        Me.plotStimulusButton.Text = " Show Stimulus "
        '
        'plotResponseButton
        '
        Me.plotResponseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotResponseButton.Location = New System.Drawing.Point(600, 80)
        Me.plotResponseButton.Name = "plotResponseButton"
        Me.plotResponseButton.Size = New System.Drawing.Size(128, 24)
        Me.plotResponseButton.TabIndex = 55
        Me.plotResponseButton.Text = "Show Response"
        '
        'plotCrossPowerSpectrumMagnitudeButton
        '
        Me.plotCrossPowerSpectrumMagnitudeButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotCrossPowerSpectrumMagnitudeButton.Location = New System.Drawing.Point(600, 216)
        Me.plotCrossPowerSpectrumMagnitudeButton.Name = "plotCrossPowerSpectrumMagnitudeButton"
        Me.plotCrossPowerSpectrumMagnitudeButton.Size = New System.Drawing.Size(128, 32)
        Me.plotCrossPowerSpectrumMagnitudeButton.TabIndex = 57
        Me.plotCrossPowerSpectrumMagnitudeButton.Text = "Cross Power Spectrum Magnitude"
        '
        'magnitudeScatterGraph
        '
        Me.magnitudeScatterGraph.Caption = "Magnitude Plot"
        Me.magnitudeScatterGraph.Location = New System.Drawing.Point(152, 168)
        Me.magnitudeScatterGraph.Name = "magnitudeScatterGraph"
        Me.magnitudeScatterGraph.UseColorGenerator = True
        Me.magnitudeScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.powerSpectrumMagnitudePlot, Me.frequencyResponseMagnitudePlot})
        Me.magnitudeScatterGraph.Size = New System.Drawing.Size(432, 152)
        Me.magnitudeScatterGraph.TabIndex = 64
        Me.magnitudeScatterGraph.TabStop = False
        Me.magnitudeScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis2})
        Me.magnitudeScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis2})
        '
        'powerSpectrumMagnitudePlot
        '
        Me.powerSpectrumMagnitudePlot.XAxis = Me.xAxis2
        Me.powerSpectrumMagnitudePlot.YAxis = Me.yAxis2
        '
        'yAxis2
        '
        Me.yAxis2.Caption = "Magnitude"
        '
        'frequencyResponseMagnitudePlot
        '
        Me.frequencyResponseMagnitudePlot.XAxis = Me.xAxis2
        Me.frequencyResponseMagnitudePlot.YAxis = Me.yAxis2
        '
        'signalScatterGraph
        '
        Me.signalScatterGraph.Location = New System.Drawing.Point(152, 8)
        Me.signalScatterGraph.Name = "signalScatterGraph"
        Me.signalScatterGraph.UseColorGenerator = True
        Me.signalScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.stimulusPlot, Me.responsePlot, Me.impulseResponsePlot})
        Me.signalScatterGraph.Size = New System.Drawing.Size(432, 152)
        Me.signalScatterGraph.TabIndex = 63
        Me.signalScatterGraph.TabStop = False
        Me.signalScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.signalScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'stimulusPlot
        '
        Me.stimulusPlot.XAxis = Me.xAxis
        Me.stimulusPlot.YAxis = Me.yAxis
        '
        'plotFrequencyResponseMagnitudeButton
        '
        Me.plotFrequencyResponseMagnitudeButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotFrequencyResponseMagnitudeButton.Location = New System.Drawing.Point(600, 256)
        Me.plotFrequencyResponseMagnitudeButton.Name = "plotFrequencyResponseMagnitudeButton"
        Me.plotFrequencyResponseMagnitudeButton.Size = New System.Drawing.Size(128, 32)
        Me.plotFrequencyResponseMagnitudeButton.TabIndex = 58
        Me.plotFrequencyResponseMagnitudeButton.Text = "Frequency Response Magnitude"
        '
        'plotFrequencyResponsePhaseButton
        '
        Me.plotFrequencyResponsePhaseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotFrequencyResponsePhaseButton.Location = New System.Drawing.Point(600, 416)
        Me.plotFrequencyResponsePhaseButton.Name = "plotFrequencyResponsePhaseButton"
        Me.plotFrequencyResponsePhaseButton.Size = New System.Drawing.Size(128, 32)
        Me.plotFrequencyResponsePhaseButton.TabIndex = 60
        Me.plotFrequencyResponsePhaseButton.Text = "Frequency Response Phase"
        '
        'plotCrossPowerSpectrumPhaseButton
        '
        Me.plotCrossPowerSpectrumPhaseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotCrossPowerSpectrumPhaseButton.Location = New System.Drawing.Point(600, 376)
        Me.plotCrossPowerSpectrumPhaseButton.Name = "plotCrossPowerSpectrumPhaseButton"
        Me.plotCrossPowerSpectrumPhaseButton.Size = New System.Drawing.Size(128, 32)
        Me.plotCrossPowerSpectrumPhaseButton.TabIndex = 59
        Me.plotCrossPowerSpectrumPhaseButton.Text = "Cross Power Spectrum Phase"
        '
        'plotImpulseResponseButton
        '
        Me.plotImpulseResponseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotImpulseResponseButton.Location = New System.Drawing.Point(600, 112)
        Me.plotImpulseResponseButton.Name = "plotImpulseResponseButton"
        Me.plotImpulseResponseButton.Size = New System.Drawing.Size(128, 24)
        Me.plotImpulseResponseButton.TabIndex = 56
        Me.plotImpulseResponseButton.Text = "Impulse Response"
        '
        'phaseScatterGraph
        '
        Me.phaseScatterGraph.Caption = "Phase Plot"
        Me.phaseScatterGraph.Location = New System.Drawing.Point(152, 328)
        Me.phaseScatterGraph.Name = "phaseScatterGraph"
        Me.phaseScatterGraph.UseColorGenerator = True
        Me.phaseScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.powerSpectrumPhasePlot, Me.frequencyResponsePhasePlot})
        Me.phaseScatterGraph.Size = New System.Drawing.Size(432, 152)
        Me.phaseScatterGraph.TabIndex = 65
        Me.phaseScatterGraph.TabStop = False
        Me.phaseScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.phaseScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'powerSpectrumPhasePlot
        '
        Me.powerSpectrumPhasePlot.XAxis = Me.xAxis1
        Me.powerSpectrumPhasePlot.YAxis = Me.yAxis1
        '
        'xAxis1
        '
        Me.xAxis1.Caption = "Frequency"
        '
        'yAxis1
        '
        Me.yAxis1.Caption = "Phase"
        '
        'frequencyResponsePhasePlot
        '
        Me.frequencyResponsePhasePlot.XAxis = Me.xAxis1
        Me.frequencyResponsePhasePlot.YAxis = Me.yAxis1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(746, 584)
        Me.Controls.Add(Me.exampleDescriptionLabel)
        Me.Controls.Add(Me.filterOrderGroupBox)
        Me.Controls.Add(Me.signalSourceGroupBox)
        Me.Controls.Add(Me.plotStimulusButton)
        Me.Controls.Add(Me.plotResponseButton)
        Me.Controls.Add(Me.plotCrossPowerSpectrumMagnitudeButton)
        Me.Controls.Add(Me.magnitudeScatterGraph)
        Me.Controls.Add(Me.signalScatterGraph)
        Me.Controls.Add(Me.plotFrequencyResponseMagnitudeButton)
        Me.Controls.Add(Me.plotFrequencyResponsePhaseButton)
        Me.Controls.Add(Me.plotCrossPowerSpectrumPhaseButton)
        Me.Controls.Add(Me.plotImpulseResponseButton)
        Me.Controls.Add(Me.phaseScatterGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Function"
        Me.filterOrderGroupBox.ResumeLayout(False)
        CType(Me.lowerCutoffNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upperCutoffNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.signalSourceGroupBox.ResumeLayout(False)
        CType(Me.noiseAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signalAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.magnitudeScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signalScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phaseScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    'Generation of signal source.
    Private Sub GenerateSignalSource()
        Dim i As Integer

        waveform = New Double(numberOfSamplesNumericEdit.Value - 1) {}
        xwave = New Double(numberOfSamplesNumericEdit.Value - 1) {}

        Select Case signalSourceComboBox.SelectedIndex
            Case 0 'Impulse.
                waveform = PatternGeneration.Impulse(numberOfSamplesNumericEdit.Value, signalAmplitudeNumericEdit.Value, 0)
            Case 1  'Sin Wave.
                Dim sin As SineSignal = New SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 0.0)
                waveform = sin.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
            Case 2 'Cos Wave.
                Dim cos As SineSignal = New SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 90.0)
                waveform = cos.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
            Case 3 'Square.
                Dim square As SquareSignal = New SquareSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value)
                waveform = square.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
            Case 4 'Triangle. 
                Dim triangle As TriangleSignal = New TriangleSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value)
                waveform = triangle.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
            Case 5 'SawTooth.
                Dim sawtooth As SawtoothSignal = New SawtoothSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value)
                waveform = sawtooth.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
            Case Else
                waveform = PatternGeneration.Impulse(numberOfSamplesNumericEdit.Value, signalAmplitudeNumericEdit.Value, 0)
        End Select
        For i = 0 To (numberOfSamplesNumericEdit.Value - 1)
            xwave(i) = i * 1 / samplingRateNumericEdit.Value
        Next i
    End Sub

    'Filter signal with the selected filter.
    Private Sub FilterSignal(ByVal waveform() As Double)
        filteredwave = New Double(numberOfSamplesNumericEdit.Value - 1) {}

        Select Case filterDesignComboBox.SelectedIndex
            Case 0 'Filter selected is elliptic.
                Select Case filterTypeComboBox.SelectedIndex
                    Case 0 'elliptic lowpass
                        Dim ellipticLowpass As EllipticLowpassFilter = New EllipticLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticLowpass.FilterData(waveform)
                    Case 1 'elliptic highpass
                        Dim ellipticHighpass As EllipticHighpassFilter = New EllipticHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticHighpass.FilterData(waveform)
                    Case 2 'elliptic bandpass
                        Dim ellipticBandpass As EllipticBandpassFilter = New EllipticBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticBandpass.FilterData(waveform)
                    Case 3 'elliptic bandstop
                        Dim ellipticBandstop As EllipticBandstopFilter = New EllipticBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticBandstop.FilterData(waveform)
                End Select
            Case 1 'Bessel filter is selected.
                Select Case filterTypeComboBox.SelectedIndex
                    Case 0 'bessel lowpass
                        Dim besselLowpass As BesselLowpassFilter = New BesselLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                        filteredwave = besselLowpass.FilterData(waveform)
                    Case 1 'bessel highpass
                        Dim besselHighpass As BesselHighpassFilter = New BesselHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                        filteredwave = besselHighpass.FilterData(waveform)
                    Case 2 'bessel bandpass
                        Dim besselBandpass As BesselBandpassFilter = New BesselBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                        filteredwave = besselBandpass.FilterData(waveform)
                    Case 3 'bessel bandstop
                        Dim besselBandstop As BesselBandstopFilter = New BesselBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                        filteredwave = besselBandstop.FilterData(waveform)
                End Select
            Case 2 'Butterworth filter is selected.
                Select Case filterTypeComboBox.SelectedIndex
                    Case 0 'butterworth lowpass
                        Dim butterworthLowpass As ButterworthLowpassFilter = New ButterworthLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                        filteredwave = butterworthLowpass.FilterData(waveform)
                    Case 1 'butterworth highpass
                        Dim butterworthHighpass As ButterworthHighpassFilter = New ButterworthHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                        filteredwave = butterworthHighpass.FilterData(waveform)
                    Case 2 'butterworth bandpass
                        Dim butterworthBandpass As ButterworthBandpassFilter = New ButterworthBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                        filteredwave = butterworthBandpass.FilterData(waveform)
                    Case 3 'butterworth bandstop
                        Dim butterworthBandstop As ButterworthBandstopFilter = New ButterworthBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                        filteredwave = butterworthBandstop.FilterData(waveform)
                End Select
            Case 3 'Chebyshev filter is selected.
                Select Case filterTypeComboBox.SelectedIndex
                    Case 0 'chebyshev lowpass
                        Dim chebyshevLowpass As ChebyshevLowpassFilter = New ChebyshevLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 1.0)
                        filteredwave = chebyshevLowpass.FilterData(waveform)
                    Case 1 'chebyshev highpass
                        Dim chebyshevHighpass As ChebyshevHighpassFilter = New ChebyshevHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 1.0)
                        filteredwave = chebyshevHighpass.FilterData(waveform)
                    Case 2 'chebyshev bandpass
                        Dim chebyshevBandpass As ChebyshevBandpassFilter = New ChebyshevBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 1.0)
                        filteredwave = chebyshevBandpass.FilterData(waveform)
                    Case 3 'chebyshev bandstop 
                        Dim chebyshevBandstop As ChebyshevBandstopFilter = New ChebyshevBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 1.0)
                        filteredwave = chebyshevBandstop.FilterData(noiseWaveform)
                End Select
            Case 4 'Inverse chebyshev filter is selected.
                Select Case filterTypeComboBox.SelectedIndex
                    Case 0 'Inverse chebyshev lowpass
                        Dim inverseChebyshevLowpass As InverseChebyshevLowpassFilter = New InverseChebyshevLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 60.0)
                        filteredwave = inverseChebyshevLowpass.FilterData(waveform)
                    Case 1 'Inverse chebyshev highpass.
                        Dim inverseChebyshevHighpass As InverseChebyshevHighpassFilter = New InverseChebyshevHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 60.0)
                        filteredwave = inverseChebyshevHighpass.FilterData(waveform)
                    Case 2 'Inverse chebyshev bandpass
                        Dim inverseChebyshevBandpass As InverseChebyshevBandpassFilter = New InverseChebyshevBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 60.0)
                        filteredwave = inverseChebyshevBandpass.FilterData(waveform)
                    Case 3 'Inverse chebyshev bandstop
                        Dim inverseChebyshevBandstop As InverseChebyshevBandstopFilter = New InverseChebyshevBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 60.0)
                        filteredwave = inverseChebyshevBandstop.FilterData(waveform)
                End Select
            Case Else
                Select Case filterTypeComboBox.SelectedIndex
                    Case 0 'elliptic lowpass
                        Dim ellipticLowpass As EllipticLowpassFilter = New EllipticLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticLowpass.FilterData(waveform)
                    Case 1 'elliptic highpass
                        Dim ellipticHighpass As EllipticHighpassFilter = New EllipticHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticHighpass.FilterData(waveform)
                    Case 2 'elliptic bandpass
                        Dim ellipticBandpass As EllipticBandpassFilter = New EllipticBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticBandpass.FilterData(waveform)
                    Case 3 'elliptic bandstop
                        Dim ellipticBandstop As EllipticBandstopFilter = New EllipticBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, 1, 60.0)
                        filteredwave = ellipticBandstop.FilterData(waveform)
                End Select
        End Select
    End Sub
    'Mix noise to the signal.
    Private Sub MixNoiseToSignal()
        Dim i As Integer

        noiseWaveform = New Double(numberOfSamplesNumericEdit.Value - 1) {}
        'Create white noise of specified amplitude
        Dim whiteNoise As WhiteNoiseSignal = New WhiteNoiseSignal(noiseAmplitudeNumericEdit.Value, 1)
        noiseWaveform = whiteNoise.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
        'Add noise to signal
        For i = 0 To (numberOfSamplesNumericEdit.Value - 1)
            noiseWaveform(i) = noiseWaveform(i) + waveform(i)
        Next i
    End Sub

    'Application of network functions
    Private Function CalculateNetworkFunction() As Boolean
        Dim i As Integer
        Dim stimulusSignal(,) As Double
        Dim responseSignal(,) As Double
        Dim df As Double

        Try
            Dim numSamples As Integer = CInt(numberOfSamplesNumericEdit.Value)
            xWaveform = New Double(System.Math.Floor(numSamples / 2) - 1) {}
            GenerateSignalSource() 'generate signal source
            MixNoiseToSignal() 'Mix noise to signal to create noisy signal.
            FilterSignal(noiseWaveform) 'filter the noisy signal through the filter selected by the user.

            stimulusSignal = New Double(0, numSamples - 1) {}
            responseSignal = New Double(0, numSamples - 1) {}

            For i = 0 To (numSamples - 1)
                stimulusSignal(0, i) = noiseWaveform(i) 'Stimulus is the Noisy signal that is fed to the IIR filter. 
                responseSignal(0, i) = filteredwave(i) 'Response is the filtered wave from the filter. Here we are taking filter as the 
                'device performing filtering operation and creating the response signal.
            Next i

            'Apply Network functions
            Transforms.NetworkFunctions(stimulusSignal, responseSignal, 1 / samplingRateNumericEdit.Value, _
            crossPowerSpectrumMagnitude, crossPowerSpectrumPhase, frequencyResponseMagnitude, _
            frequencyResponsePhase, coherence, impulseResponse, df)

            'xWaveform against which powerSPectrum and frequencyResponse will be plotted
            For i = 0 To (System.Math.Floor(numSamples / 2) - 1)
                xWaveform(i) = i * df
            Next i
            Return True
        Catch exp As Exception
            MessageBox.Show(exp.Message)
            Return False
        End Try
    End Function

    Private Sub plotStimulusButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotStimulusButton.Click
        'Status of buttons.
        showStimulusClicked = True
        showResponseClicked = False
        impulseResponseClicked = False

        signalScatterGraph.ClearData()
        signalScatterGraph.Caption = "Stimulus"
        If (CalculateNetworkFunction()) Then
            stimulusPlot.PlotXY(xwave, noiseWaveform)
        End If
    End Sub

    Private Sub plotResponseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotResponseButton.Click
        'Status of buttons.
        showStimulusClicked = False
        showResponseClicked = True
        impulseResponseClicked = False

        signalScatterGraph.ClearData()
        signalScatterGraph.Caption = "Response of the filtered Stimulus"
        If (CalculateNetworkFunction()) Then
            responsePlot.PlotXY(xwave, filteredwave)
        End If
    End Sub

    Private Sub plotImpulseResponse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotImpulseResponseButton.Click
        'Status of buttons.
        showStimulusClicked = False
        showResponseClicked = False
        impulseResponseClicked = True

        signalScatterGraph.ClearData()
        signalScatterGraph.Caption = "Impulse Response"
        If (CalculateNetworkFunction()) Then
            impulseResponsePlot.PlotXY(xwave, impulseResponse)
        End If
    End Sub

    Private Sub plotCrossPowerSpectrumMagnitude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotCrossPowerSpectrumMagnitudeButton.Click
        'Status of buttons.
        powerSpectrumMagnitudeClicked = True
        frequencyResponseMagnitudeClicked = False

        magnitudeScatterGraph.ClearData()
        magnitudeScatterGraph.Caption = " Cross Power Spectrum Magnitude"
        If (CalculateNetworkFunction()) Then
            powerSpectrumMagnitudePlot.PlotXY(xWaveform, crossPowerSpectrumMagnitude)
        End If
    End Sub

    Private Sub plotFrequencyResponseMagnitude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotFrequencyResponseMagnitudeButton.Click
        'Status of buttons.
        powerSpectrumMagnitudeClicked = False
        frequencyResponseMagnitudeClicked = True

        magnitudeScatterGraph.ClearData()
        magnitudeScatterGraph.Caption = " Frequency Response Magnitude"
        If (CalculateNetworkFunction()) Then
            frequencyResponseMagnitudePlot.PlotXY(xWaveform, frequencyResponseMagnitude)
        End If
    End Sub

    Private Sub plotCrossPowerSpectrumPhase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotCrossPowerSpectrumPhaseButton.Click
        'Status of buttons.
        powerSpectrumPhaseClicked = True
        frequencyResponsePhaseClicked = False

        phaseScatterGraph.ClearData()
        phaseScatterGraph.Caption = " Cross Power Spectrum Phase"
        If (CalculateNetworkFunction()) Then
            powerSpectrumPhasePlot.PlotXY(xWaveform, crossPowerSpectrumPhase)
        End If
    End Sub

    Private Sub plotFrequencyResponsePhase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotFrequencyResponsePhaseButton.Click
        'Status of buttons
        powerSpectrumPhaseClicked = False
        frequencyResponsePhaseClicked = True

        phaseScatterGraph.ClearData()
        phaseScatterGraph.Caption = "Frequency Response Phase"
        If (CalculateNetworkFunction()) Then
            frequencyResponsePhasePlot.PlotXY(xWaveform, frequencyResponsePhase)
        End If
    End Sub

    Private Sub numberOfSamples_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numberOfSamplesNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub signalSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signalSourceComboBox.SelectedIndexChanged
        If (signalSourceComboBox.SelectedIndex = 0) Then
            frequencyNumericEdit.Enabled = False
            frequencyLabel.Enabled = False
        Else
            frequencyNumericEdit.Enabled = True
            frequencyLabel.Enabled = True
        End If

        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If

    End Sub

    Private Sub frequency_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frequencyNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub samplingRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles samplingRateNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub signalAmplitude_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signalAmplitudeNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub noiseAmplitude_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noiseAmplitudeNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub filterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterTypeComboBox.SelectedIndexChanged
        If (filterTypeComboBox.SelectedIndex = 0) Then
            upperCutoffNumericEdit.Enabled = False
        ElseIf (filterTypeComboBox.SelectedIndex = 1) Then
            upperCutoffNumericEdit.Enabled = False
        Else
            upperCutoffNumericEdit.Enabled = True
        End If
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub filterDesign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterDesignComboBox.SelectedIndexChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub order_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub lowerCutoff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lowerCutoffNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub

    Private Sub upperCutoff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upperCutoffNumericEdit.ValueChanged
        If (showStimulusClicked) Then
            plotStimulusButton.PerformClick()
        End If
        If (showResponseClicked) Then
            plotResponseButton.PerformClick()
        End If
        If (impulseResponseClicked) Then
            plotImpulseResponseButton.PerformClick()
        End If
        If (powerSpectrumMagnitudeClicked) Then
            plotCrossPowerSpectrumMagnitudeButton.PerformClick()
        End If
        If (powerSpectrumPhaseClicked) Then
            plotCrossPowerSpectrumPhaseButton.PerformClick()
        End If
        If (frequencyResponseMagnitudeClicked) Then
            plotFrequencyResponseMagnitudeButton.PerformClick()
        End If
        If (frequencyResponsePhaseClicked) Then
            plotFrequencyResponsePhaseButton.PerformClick()
        End If
    End Sub


End Class
