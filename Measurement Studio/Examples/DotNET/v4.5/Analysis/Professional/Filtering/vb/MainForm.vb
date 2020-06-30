Public Class MainForm
    Inherits System.Windows.Forms.Form
    Dim waveform() As Double
    Dim xwave() As Double
    Dim xwaveform() As Double
    Dim noiseWaveform() As Double
    Dim filteredwave() As Double
    Dim magnitudes() As Double
    Dim subsetOfMagnitudes() As Double
    Dim phases() As Double
    Dim subsetOfPhases() As Double
    Dim logMagnitudes() As Double
    Dim FFTValue() As NationalInstruments.ComplexDouble
    Dim calculateFFTofTheFilteredSignalClicked As Boolean = False
    Dim calculateFFTofTheFilteredNoisySignalClicked As Boolean = False
    Dim calculateFFTofTheUnfilteredSignalClicked As Boolean = False
    Dim calculateFFTofTheUnfilteredNoisySignalClicked As Boolean = False
    Dim displayNoisySignalClicked As Boolean = False
    Dim displaySignalClicked As Boolean = False


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        signalSourceComboBox.SelectedIndex = 0
        displayModeComboBox.SelectedIndex = 0
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
    Friend WithEvents signalPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents signalWithNoisePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents rippleLabel As System.Windows.Forms.Label
    Friend WithEvents filterDesignLabel As System.Windows.Forms.Label
    Friend WithEvents orderLabel As System.Windows.Forms.Label
    Friend WithEvents lowerCutoffLabel As System.Windows.Forms.Label
    Friend WithEvents filterTypeLabel As System.Windows.Forms.Label
    Friend WithEvents higherCutoffLabel As System.Windows.Forms.Label
    Friend WithEvents attenuationLabel As System.Windows.Forms.Label
    Friend WithEvents phasePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents phaseXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents phaseYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents helpLabel As System.Windows.Forms.Label
    Friend WithEvents displayModeLabel As System.Windows.Forms.Label
    Friend WithEvents frequencyLabel As System.Windows.Forms.Label
    Friend WithEvents signalSourceLabel As System.Windows.Forms.Label
    Friend WithEvents samplingRateLabel As System.Windows.Forms.Label
    Friend WithEvents noiseAmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents signalAmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents numberOfSamplesLabel As System.Windows.Forms.Label
    Friend WithEvents magnitudePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents magnitudeXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents magnitudeYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents signalSourceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents filterTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents filterDesignComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents displayModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents attenuationNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents orderNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents lowerCutoffNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents upperCutoffNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents rippleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents samplingRateNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents frequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents signalAmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents noiseAmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents calculateFFTOfFilteredSignalButton As System.Windows.Forms.Button
    Friend WithEvents displaySignalButton As System.Windows.Forms.Button
    Friend WithEvents calculateFFTOfFilteredNoisySignalButton As System.Windows.Forms.Button
    Friend WithEvents calculateFFTOfNoisySignalButton As System.Windows.Forms.Button
    Friend WithEvents displaySignalWithNoiseButton As System.Windows.Forms.Button
    Friend WithEvents calculateFFTBeforeFilteringButton As System.Windows.Forms.Button
    Friend WithEvents signalScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents phaseScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents magnitudeScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents filterParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents signalParametersGroupBox As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.signalScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.signalPlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.signalWithNoisePlot = New NationalInstruments.UI.ScatterPlot
        Me.filterParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.rippleLabel = New System.Windows.Forms.Label
        Me.filterDesignLabel = New System.Windows.Forms.Label
        Me.orderLabel = New System.Windows.Forms.Label
        Me.lowerCutoffLabel = New System.Windows.Forms.Label
        Me.filterTypeLabel = New System.Windows.Forms.Label
        Me.higherCutoffLabel = New System.Windows.Forms.Label
        Me.filterTypeComboBox = New System.Windows.Forms.ComboBox
        Me.filterDesignComboBox = New System.Windows.Forms.ComboBox
        Me.attenuationLabel = New System.Windows.Forms.Label
        Me.attenuationNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.orderNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.lowerCutoffNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.upperCutoffNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.rippleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.calculateFFTOfFilteredSignalButton = New System.Windows.Forms.Button
        Me.displaySignalButton = New System.Windows.Forms.Button
        Me.phaseScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.phasePlot = New NationalInstruments.UI.ScatterPlot
        Me.phaseXAxis = New NationalInstruments.UI.XAxis
        Me.phaseYAxis = New NationalInstruments.UI.YAxis
        Me.helpLabel = New System.Windows.Forms.Label
        Me.calculateFFTOfFilteredNoisySignalButton = New System.Windows.Forms.Button
        Me.calculateFFTOfNoisySignalButton = New System.Windows.Forms.Button
        Me.displaySignalWithNoiseButton = New System.Windows.Forms.Button
        Me.calculateFFTBeforeFilteringButton = New System.Windows.Forms.Button
        Me.displayModeComboBox = New System.Windows.Forms.ComboBox
        Me.displayModeLabel = New System.Windows.Forms.Label
        Me.signalParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.samplingRateNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.frequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.frequencyLabel = New System.Windows.Forms.Label
        Me.signalSourceComboBox = New System.Windows.Forms.ComboBox
        Me.signalSourceLabel = New System.Windows.Forms.Label
        Me.samplingRateLabel = New System.Windows.Forms.Label
        Me.noiseAmplitudeLabel = New System.Windows.Forms.Label
        Me.signalAmplitudeLabel = New System.Windows.Forms.Label
        Me.numberOfSamplesLabel = New System.Windows.Forms.Label
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.signalAmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.noiseAmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.magnitudeScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.magnitudePlot = New NationalInstruments.UI.ScatterPlot
        Me.magnitudeXAxis = New NationalInstruments.UI.XAxis
        Me.magnitudeYAxis = New NationalInstruments.UI.YAxis
        CType(Me.signalScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.filterParametersGroupBox.SuspendLayout()
        CType(Me.attenuationNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lowerCutoffNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upperCutoffNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rippleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phaseScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.signalParametersGroupBox.SuspendLayout()
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signalAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.noiseAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.magnitudeScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'signalScatterGraph
        '
        Me.signalScatterGraph.Caption = "Signal Graph"
        Me.signalScatterGraph.Location = New System.Drawing.Point(157, 8)
        Me.signalScatterGraph.Name = "signalScatterGraph"
        Me.signalScatterGraph.UseColorGenerator = True
        Me.signalScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.signalPlot, Me.signalWithNoisePlot})
        Me.signalScatterGraph.Size = New System.Drawing.Size(432, 136)
        Me.signalScatterGraph.TabIndex = 30
        Me.signalScatterGraph.TabStop = False
        Me.signalScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.signalScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'signalPlot
        '
        Me.signalPlot.XAxis = Me.xAxis
        Me.signalPlot.YAxis = Me.yAxis
        '
        'xAxis
        '
        Me.xAxis.Caption = "Number Of Samples"
        '
        'yAxis
        '
        Me.yAxis.Caption = "Amplitude"
        '
        'signalWithNoisePlot
        '
        Me.signalWithNoisePlot.XAxis = Me.xAxis
        Me.signalWithNoisePlot.YAxis = Me.yAxis
        '
        'filterParametersGroupBox
        '
        Me.filterParametersGroupBox.Controls.Add(Me.rippleLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.filterDesignLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.orderLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.lowerCutoffLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.filterTypeLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.higherCutoffLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.filterTypeComboBox)
        Me.filterParametersGroupBox.Controls.Add(Me.filterDesignComboBox)
        Me.filterParametersGroupBox.Controls.Add(Me.attenuationLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.attenuationNumericEdit)
        Me.filterParametersGroupBox.Controls.Add(Me.orderNumericEdit)
        Me.filterParametersGroupBox.Controls.Add(Me.lowerCutoffNumericEdit)
        Me.filterParametersGroupBox.Controls.Add(Me.upperCutoffNumericEdit)
        Me.filterParametersGroupBox.Controls.Add(Me.rippleNumericEdit)
        Me.filterParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterParametersGroupBox.Location = New System.Drawing.Point(605, 8)
        Me.filterParametersGroupBox.Name = "filterParametersGroupBox"
        Me.filterParametersGroupBox.Size = New System.Drawing.Size(128, 352)
        Me.filterParametersGroupBox.TabIndex = 35
        Me.filterParametersGroupBox.TabStop = False
        Me.filterParametersGroupBox.Text = "Filter Parameters"
        '
        'rippleLabel
        '
        Me.rippleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rippleLabel.Location = New System.Drawing.Point(16, 112)
        Me.rippleLabel.Name = "rippleLabel"
        Me.rippleLabel.Size = New System.Drawing.Size(88, 16)
        Me.rippleLabel.TabIndex = 1
        Me.rippleLabel.Text = "Ripple:"
        '
        'filterDesignLabel
        '
        Me.filterDesignLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterDesignLabel.Location = New System.Drawing.Point(16, 64)
        Me.filterDesignLabel.Name = "filterDesignLabel"
        Me.filterDesignLabel.Size = New System.Drawing.Size(88, 16)
        Me.filterDesignLabel.TabIndex = 1
        Me.filterDesignLabel.Text = "Filter Design:"
        '
        'orderLabel
        '
        Me.orderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.orderLabel.Location = New System.Drawing.Point(16, 208)
        Me.orderLabel.Name = "orderLabel"
        Me.orderLabel.Size = New System.Drawing.Size(88, 16)
        Me.orderLabel.TabIndex = 1
        Me.orderLabel.Text = "Order:"
        '
        'lowerCutoffLabel
        '
        Me.lowerCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lowerCutoffLabel.Location = New System.Drawing.Point(16, 256)
        Me.lowerCutoffLabel.Name = "lowerCutoffLabel"
        Me.lowerCutoffLabel.Size = New System.Drawing.Size(88, 16)
        Me.lowerCutoffLabel.TabIndex = 1
        Me.lowerCutoffLabel.Text = "Lower Cutoff:"
        '
        'filterTypeLabel
        '
        Me.filterTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterTypeLabel.Location = New System.Drawing.Point(16, 16)
        Me.filterTypeLabel.Name = "filterTypeLabel"
        Me.filterTypeLabel.Size = New System.Drawing.Size(88, 16)
        Me.filterTypeLabel.TabIndex = 1
        Me.filterTypeLabel.Text = "Filter Type:"
        '
        'higherCutoffLabel
        '
        Me.higherCutoffLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.higherCutoffLabel.Location = New System.Drawing.Point(16, 304)
        Me.higherCutoffLabel.Name = "higherCutoffLabel"
        Me.higherCutoffLabel.Size = New System.Drawing.Size(88, 16)
        Me.higherCutoffLabel.TabIndex = 1
        Me.higherCutoffLabel.Text = "Upper Cutoff:"
        '
        'filterTypeComboBox
        '
        Me.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterTypeComboBox.Items.AddRange(New Object() {"Lowpass", "Highpass", "Bandpass", "Bandstop"})
        Me.filterTypeComboBox.Location = New System.Drawing.Point(16, 32)
        Me.filterTypeComboBox.Name = "filterTypeComboBox"
        Me.filterTypeComboBox.Size = New System.Drawing.Size(96, 21)
        Me.filterTypeComboBox.TabIndex = 0
        '
        'filterDesignComboBox
        '
        Me.filterDesignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterDesignComboBox.Items.AddRange(New Object() {"Elliptic", "Bessel", "Butterworth", "Chebyshev", "Inv Chebyshev"})
        Me.filterDesignComboBox.Location = New System.Drawing.Point(16, 80)
        Me.filterDesignComboBox.Name = "filterDesignComboBox"
        Me.filterDesignComboBox.Size = New System.Drawing.Size(96, 21)
        Me.filterDesignComboBox.TabIndex = 1
        '
        'attenuationLabel
        '
        Me.attenuationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.attenuationLabel.Location = New System.Drawing.Point(16, 160)
        Me.attenuationLabel.Name = "attenuationLabel"
        Me.attenuationLabel.Size = New System.Drawing.Size(88, 16)
        Me.attenuationLabel.TabIndex = 1
        Me.attenuationLabel.Text = "Attenuation:"
        '
        'attenuationNumericEdit
        '
        Me.attenuationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.attenuationNumericEdit.Location = New System.Drawing.Point(16, 176)
        Me.attenuationNumericEdit.Name = "attenuationNumericEdit"
        Me.attenuationNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.attenuationNumericEdit.Range = New NationalInstruments.UI.Range(1, 1000)
        Me.attenuationNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.attenuationNumericEdit.TabIndex = 3
        Me.attenuationNumericEdit.Value = 60
        '
        'orderNumericEdit
        '
        Me.orderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.orderNumericEdit.Location = New System.Drawing.Point(16, 224)
        Me.orderNumericEdit.Name = "orderNumericEdit"
        Me.orderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.orderNumericEdit.Range = New NationalInstruments.UI.Range(1, 50)
        Me.orderNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.orderNumericEdit.TabIndex = 4
        Me.orderNumericEdit.Value = 2
        '
        'lowerCutoffNumericEdit
        '
        Me.lowerCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.lowerCutoffNumericEdit.Location = New System.Drawing.Point(16, 272)
        Me.lowerCutoffNumericEdit.Name = "lowerCutoffNumericEdit"
        Me.lowerCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.lowerCutoffNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.lowerCutoffNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.lowerCutoffNumericEdit.TabIndex = 5
        Me.lowerCutoffNumericEdit.Value = 250
        '
        'upperCutoffNumericEdit
        '
        Me.upperCutoffNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.upperCutoffNumericEdit.Location = New System.Drawing.Point(16, 320)
        Me.upperCutoffNumericEdit.Name = "upperCutoffNumericEdit"
        Me.upperCutoffNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.upperCutoffNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.upperCutoffNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.upperCutoffNumericEdit.TabIndex = 6
        Me.upperCutoffNumericEdit.Value = 450
        '
        'rippleNumericEdit
        '
        Me.rippleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.rippleNumericEdit.Location = New System.Drawing.Point(16, 136)
        Me.rippleNumericEdit.Name = "rippleNumericEdit"
        Me.rippleNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.rippleNumericEdit.Range = New NationalInstruments.UI.Range(1, 1000)
        Me.rippleNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.rippleNumericEdit.TabIndex = 2
        Me.rippleNumericEdit.Value = 2
        '
        'calculateFFTOfFilteredSignalButton
        '
        Me.calculateFFTOfFilteredSignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.calculateFFTOfFilteredSignalButton.Location = New System.Drawing.Point(472, 472)
        Me.calculateFFTOfFilteredSignalButton.Name = "calculateFFTOfFilteredSignalButton"
        Me.calculateFFTOfFilteredSignalButton.Size = New System.Drawing.Size(208, 24)
        Me.calculateFFTOfFilteredSignalButton.TabIndex = 26
        Me.calculateFFTOfFilteredSignalButton.Text = "Calculate FFT of the Filtered Signal"
        '
        'displaySignalButton
        '
        Me.displaySignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.displaySignalButton.Location = New System.Drawing.Point(56, 472)
        Me.displaySignalButton.Name = "displaySignalButton"
        Me.displaySignalButton.Size = New System.Drawing.Size(152, 24)
        Me.displaySignalButton.TabIndex = 24
        Me.displaySignalButton.Text = "Display Signal "
        '
        'phaseScatterGraph
        '
        Me.phaseScatterGraph.Caption = "Phase Graph"
        Me.phaseScatterGraph.Location = New System.Drawing.Point(157, 320)
        Me.phaseScatterGraph.Name = "phaseScatterGraph"
        Me.phaseScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.phasePlot})
        Me.phaseScatterGraph.Size = New System.Drawing.Size(432, 144)
        Me.phaseScatterGraph.TabIndex = 34
        Me.phaseScatterGraph.TabStop = False
        Me.phaseScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.phaseXAxis})
        Me.phaseScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.phaseYAxis})
        '
        'phasePlot
        '
        Me.phasePlot.XAxis = Me.phaseXAxis
        Me.phasePlot.YAxis = Me.phaseYAxis
        '
        'phaseXAxis
        '
        Me.phaseXAxis.Caption = "Frequency"
        '
        'phaseYAxis
        '
        Me.phaseYAxis.Caption = "Phase (radian)"
        '
        'helpLabel
        '
        Me.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.helpLabel.Location = New System.Drawing.Point(86, 536)
        Me.helpLabel.Name = "helpLabel"
        Me.helpLabel.Size = New System.Drawing.Size(576, 40)
        Me.helpLabel.TabIndex = 37
        Me.helpLabel.Text = "This example shows the FFT of a filtered signal\filtered noisy signal\unfiltered " & _
        "signal\unfiltered noisy signal waveform data. Both upper and lower cutoff freque" & _
        "ncy must be less than half of the sampling rate to satisfy Nyquist's Criterion. " & _
        "Lower cutoff must be lesser than the upper cutoff and the attenuation must be gr" & _
        "eater than the ripple."
        '
        'calculateFFTOfFilteredNoisySignalButton
        '
        Me.calculateFFTOfFilteredNoisySignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.calculateFFTOfFilteredNoisySignalButton.Location = New System.Drawing.Point(472, 504)
        Me.calculateFFTOfFilteredNoisySignalButton.Name = "calculateFFTOfFilteredNoisySignalButton"
        Me.calculateFFTOfFilteredNoisySignalButton.Size = New System.Drawing.Size(208, 24)
        Me.calculateFFTOfFilteredNoisySignalButton.TabIndex = 29
        Me.calculateFFTOfFilteredNoisySignalButton.Text = "Calculate FFT of Filtered Noisy Signal"
        '
        'calculateFFTOfNoisySignalButton
        '
        Me.calculateFFTOfNoisySignalButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.calculateFFTOfNoisySignalButton.Location = New System.Drawing.Point(216, 504)
        Me.calculateFFTOfNoisySignalButton.Name = "calculateFFTOfNoisySignalButton"
        Me.calculateFFTOfNoisySignalButton.Size = New System.Drawing.Size(248, 24)
        Me.calculateFFTOfNoisySignalButton.TabIndex = 28
        Me.calculateFFTOfNoisySignalButton.Text = "Calculate FFT of Noisy Signal (before filtering)"
        '
        'displaySignalWithNoiseButton
        '
        Me.displaySignalWithNoiseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.displaySignalWithNoiseButton.Location = New System.Drawing.Point(56, 504)
        Me.displaySignalWithNoiseButton.Name = "displaySignalWithNoiseButton"
        Me.displaySignalWithNoiseButton.Size = New System.Drawing.Size(152, 24)
        Me.displaySignalWithNoiseButton.TabIndex = 27
        Me.displaySignalWithNoiseButton.Text = "Display  Noisy Signal"
        '
        'calculateFFTBeforeFilteringButton
        '
        Me.calculateFFTBeforeFilteringButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.calculateFFTBeforeFilteringButton.Location = New System.Drawing.Point(216, 472)
        Me.calculateFFTBeforeFilteringButton.Name = "calculateFFTBeforeFilteringButton"
        Me.calculateFFTBeforeFilteringButton.Size = New System.Drawing.Size(248, 24)
        Me.calculateFFTBeforeFilteringButton.TabIndex = 25
        Me.calculateFFTBeforeFilteringButton.Text = "Calculate FFT of Signal(before filtering)"
        '
        'displayModeComboBox
        '
        Me.displayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.displayModeComboBox.Items.AddRange(New Object() {"Linear", "Logarithmic"})
        Me.displayModeComboBox.Location = New System.Drawing.Point(29, 352)
        Me.displayModeComboBox.Name = "displayModeComboBox"
        Me.displayModeComboBox.Size = New System.Drawing.Size(96, 21)
        Me.displayModeComboBox.TabIndex = 32
        '
        'displayModeLabel
        '
        Me.displayModeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.displayModeLabel.Location = New System.Drawing.Point(29, 336)
        Me.displayModeLabel.Name = "displayModeLabel"
        Me.displayModeLabel.Size = New System.Drawing.Size(116, 16)
        Me.displayModeLabel.TabIndex = 36
        Me.displayModeLabel.Text = "Display Mode of FFT:"
        '
        'signalParametersGroupBox
        '
        Me.signalParametersGroupBox.Controls.Add(Me.samplingRateNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.frequencyNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.frequencyLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.signalSourceComboBox)
        Me.signalParametersGroupBox.Controls.Add(Me.signalSourceLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.samplingRateLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.noiseAmplitudeLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.signalAmplitudeLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.numberOfSamplesLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.signalAmplitudeNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.noiseAmplitudeNumericEdit)
        Me.signalParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalParametersGroupBox.Location = New System.Drawing.Point(13, 8)
        Me.signalParametersGroupBox.Name = "signalParametersGroupBox"
        Me.signalParametersGroupBox.Size = New System.Drawing.Size(128, 304)
        Me.signalParametersGroupBox.TabIndex = 31
        Me.signalParametersGroupBox.TabStop = False
        Me.signalParametersGroupBox.Text = "Signal Parameters"
        '
        'samplingRateNumericEdit
        '
        Me.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.samplingRateNumericEdit.Location = New System.Drawing.Point(16, 128)
        Me.samplingRateNumericEdit.Name = "samplingRateNumericEdit"
        Me.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplingRateNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.samplingRateNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.samplingRateNumericEdit.TabIndex = 2
        Me.samplingRateNumericEdit.Value = 1000
        '
        'frequencyNumericEdit
        '
        Me.frequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.frequencyNumericEdit.Location = New System.Drawing.Point(16, 80)
        Me.frequencyNumericEdit.Name = "frequencyNumericEdit"
        Me.frequencyNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.frequencyNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.frequencyNumericEdit.TabIndex = 1
        Me.frequencyNumericEdit.Value = 100
        '
        'frequencyLabel
        '
        Me.frequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.frequencyLabel.Location = New System.Drawing.Point(16, 64)
        Me.frequencyLabel.Name = "frequencyLabel"
        Me.frequencyLabel.Size = New System.Drawing.Size(96, 16)
        Me.frequencyLabel.TabIndex = 16
        Me.frequencyLabel.Text = "Frequency:"
        '
        'signalSourceComboBox
        '
        Me.signalSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.signalSourceComboBox.Items.AddRange(New Object() {"Sine", "Cosine", "Square"})
        Me.signalSourceComboBox.Location = New System.Drawing.Point(16, 32)
        Me.signalSourceComboBox.Name = "signalSourceComboBox"
        Me.signalSourceComboBox.Size = New System.Drawing.Size(96, 21)
        Me.signalSourceComboBox.TabIndex = 0
        '
        'signalSourceLabel
        '
        Me.signalSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalSourceLabel.Location = New System.Drawing.Point(16, 16)
        Me.signalSourceLabel.Name = "signalSourceLabel"
        Me.signalSourceLabel.Size = New System.Drawing.Size(88, 16)
        Me.signalSourceLabel.TabIndex = 14
        Me.signalSourceLabel.Text = "Signal Source:"
        '
        'samplingRateLabel
        '
        Me.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplingRateLabel.Location = New System.Drawing.Point(16, 112)
        Me.samplingRateLabel.Name = "samplingRateLabel"
        Me.samplingRateLabel.Size = New System.Drawing.Size(104, 16)
        Me.samplingRateLabel.TabIndex = 10
        Me.samplingRateLabel.Text = "Sampling Rate:"
        '
        'noiseAmplitudeLabel
        '
        Me.noiseAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noiseAmplitudeLabel.Location = New System.Drawing.Point(16, 256)
        Me.noiseAmplitudeLabel.Name = "noiseAmplitudeLabel"
        Me.noiseAmplitudeLabel.Size = New System.Drawing.Size(88, 16)
        Me.noiseAmplitudeLabel.TabIndex = 4
        Me.noiseAmplitudeLabel.Text = "Noise Amplitude:"
        '
        'signalAmplitudeLabel
        '
        Me.signalAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalAmplitudeLabel.Location = New System.Drawing.Point(16, 208)
        Me.signalAmplitudeLabel.Name = "signalAmplitudeLabel"
        Me.signalAmplitudeLabel.Size = New System.Drawing.Size(96, 16)
        Me.signalAmplitudeLabel.TabIndex = 10
        Me.signalAmplitudeLabel.Text = "Signal Amplitude:"
        '
        'numberOfSamplesLabel
        '
        Me.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numberOfSamplesLabel.Location = New System.Drawing.Point(16, 160)
        Me.numberOfSamplesLabel.Name = "numberOfSamplesLabel"
        Me.numberOfSamplesLabel.Size = New System.Drawing.Size(104, 16)
        Me.numberOfSamplesLabel.TabIndex = 4
        Me.numberOfSamplesLabel.Text = "Number Of Samples:"
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(16, 176)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfSamplesNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 3
        Me.numberOfSamplesNumericEdit.Value = 100
        '
        'signalAmplitudeNumericEdit
        '
        Me.signalAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.signalAmplitudeNumericEdit.Location = New System.Drawing.Point(16, 224)
        Me.signalAmplitudeNumericEdit.Name = "signalAmplitudeNumericEdit"
        Me.signalAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.signalAmplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.signalAmplitudeNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.signalAmplitudeNumericEdit.TabIndex = 4
        Me.signalAmplitudeNumericEdit.Value = 1
        '
        'noiseAmplitudeNumericEdit
        '
        Me.noiseAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.noiseAmplitudeNumericEdit.Location = New System.Drawing.Point(16, 272)
        Me.noiseAmplitudeNumericEdit.Name = "noiseAmplitudeNumericEdit"
        Me.noiseAmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.noiseAmplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.noiseAmplitudeNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.noiseAmplitudeNumericEdit.TabIndex = 5
        Me.noiseAmplitudeNumericEdit.Value = 0.01
        '
        'magnitudeScatterGraph
        '
        Me.magnitudeScatterGraph.Caption = "Magnitude Graph"
        Me.magnitudeScatterGraph.Location = New System.Drawing.Point(157, 152)
        Me.magnitudeScatterGraph.Name = "magnitudeScatterGraph"
        Me.magnitudeScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.magnitudePlot})
        Me.magnitudeScatterGraph.Size = New System.Drawing.Size(432, 160)
        Me.magnitudeScatterGraph.TabIndex = 33
        Me.magnitudeScatterGraph.TabStop = False
        Me.magnitudeScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.magnitudeXAxis})
        Me.magnitudeScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.magnitudeYAxis})
        '
        'magnitudePlot
        '
        Me.magnitudePlot.XAxis = Me.magnitudeXAxis
        Me.magnitudePlot.YAxis = Me.magnitudeYAxis
        '
        'magnitudeXAxis
        '
        Me.magnitudeXAxis.Caption = "Frequency"
        '
        'magnitudeYAxis
        '
        Me.magnitudeYAxis.Caption = "Magnitude"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(746, 583)
        Me.Controls.Add(Me.signalScatterGraph)
        Me.Controls.Add(Me.filterParametersGroupBox)
        Me.Controls.Add(Me.calculateFFTOfFilteredSignalButton)
        Me.Controls.Add(Me.displaySignalButton)
        Me.Controls.Add(Me.phaseScatterGraph)
        Me.Controls.Add(Me.helpLabel)
        Me.Controls.Add(Me.calculateFFTOfFilteredNoisySignalButton)
        Me.Controls.Add(Me.calculateFFTOfNoisySignalButton)
        Me.Controls.Add(Me.displaySignalWithNoiseButton)
        Me.Controls.Add(Me.calculateFFTBeforeFilteringButton)
        Me.Controls.Add(Me.displayModeComboBox)
        Me.Controls.Add(Me.displayModeLabel)
        Me.Controls.Add(Me.signalParametersGroupBox)
        Me.Controls.Add(Me.magnitudeScatterGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Filtering"
        CType(Me.signalScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.filterParametersGroupBox.ResumeLayout(False)
        CType(Me.attenuationNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lowerCutoffNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upperCutoffNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rippleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phaseScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.signalParametersGroupBox.ResumeLayout(False)
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signalAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.noiseAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.magnitudeScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub
    ' To display signal source on the graph.
    Private Sub ShowSignalSource()
        Dim i As Integer

        Try
            waveform = New Double(numberOfSamplesNumericEdit.Value - 1) {}
            xwave = New Double(numberOfSamplesNumericEdit.Value - 1) {}


            Select Case signalSourceComboBox.SelectedIndex
                Case 0
                    Dim sin As NationalInstruments.Analysis.SignalGeneration.SineSignal _
                    = New SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 0.0)
                    waveform = sin.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
                Case 1
                    Dim cos As NationalInstruments.Analysis.SignalGeneration.SineSignal _
                    = New SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 90.0)
                    waveform = cos.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
                Case 2
                    Dim square As NationalInstruments.Analysis.SignalGeneration.SquareSignal _
                    = New SquareSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 90.0, 50.0)
                    waveform = square.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
                Case Else
                    Dim sinDefault As NationalInstruments.Analysis.SignalGeneration.SineSignal _
                    = New SineSignal(frequencyNumericEdit.Value, signalAmplitudeNumericEdit.Value, 0.0)
                    waveform = sinDefault.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
            End Select

            For i = 0 To (numberOfSamplesNumericEdit.Value - 1)
                xwave(i) = i
            Next i
            'plot the signal waveform.

            signalPlot.PlotXY(xwave, waveform)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try

    End Sub

    'Filter signal with the appropriate filter speciefied by the user.
    Private Sub FilterSignal(ByVal waveform() As Double)

        Try
            filteredwave = New Double(numberOfSamplesNumericEdit.Value - 1) {}

            Select Case filterDesignComboBox.SelectedIndex
                Case 0 'Filter selected is elliptic.
                    Select Case filterTypeComboBox.SelectedIndex
                        Case 0 'elliptic lowpass
                            Dim ellipticLowpass As NationalInstruments.Analysis.Dsp.Filters.EllipticLowpassFilter _
                            = New EllipticLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = ellipticLowpass.FilterData(waveform)
                        Case 1 'elliptic highpass
                            Dim ellipticHighpass As NationalInstruments.Analysis.Dsp.Filters.EllipticHighpassFilter _
                            = New EllipticHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = ellipticHighpass.FilterData(waveform)
                        Case 2 'elliptic bandpass
                            Dim ellipticBandpass As NationalInstruments.Analysis.Dsp.Filters.EllipticBandpassFilter _
                            = New EllipticBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, _
                            rippleNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = ellipticBandpass.FilterData(waveform)
                        Case 3 'elliptic bandstop
                            Dim ellipticBandstop As NationalInstruments.Analysis.Dsp.Filters.EllipticBandstopFilter _
                            = New EllipticBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value, _
                            rippleNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = ellipticBandstop.FilterData(waveform)
                    End Select
                Case 1 'Bessel filter is selected.
                    Select Case filterTypeComboBox.SelectedIndex
                        Case 0 'bessel lowpass
                            Dim besselLowpass As NationalInstruments.Analysis.Dsp.Filters.BesselLowpassFilter _
                            = New BesselLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                            filteredwave = besselLowpass.FilterData(waveform)
                        Case 1 'bessel highpass
                            Dim besselHighpass As NationalInstruments.Analysis.Dsp.Filters.BesselHighpassFilter _
                            = New BesselHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                            filteredwave = besselHighpass.FilterData(waveform)
                        Case 2 'bessel bandpass
                            Dim besselBandpass As NationalInstruments.Analysis.Dsp.Filters.BesselBandpassFilter _
                            = New BesselBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                            filteredwave = besselBandpass.FilterData(waveform)
                        Case 3 'bessel bandstop
                            Dim besselBandstop As NationalInstruments.Analysis.Dsp.Filters.BesselBandstopFilter _
                            = New BesselBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                            filteredwave = besselBandstop.FilterData(waveform)
                    End Select
                Case 2 'Butterworth filter is selected.
                    Select Case filterTypeComboBox.SelectedIndex
                        Case 0 'butterworth lowpass
                            Dim butterworthLowpass As NationalInstruments.Analysis.Dsp.Filters.ButterworthLowpassFilter _
                            = New ButterworthLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                            filteredwave = butterworthLowpass.FilterData(waveform)
                        Case 1 ' butterworth highpass
                            Dim butterworthHighpass As NationalInstruments.Analysis.Dsp.Filters.ButterworthHighpassFilter _
                            = New ButterworthHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value)
                            filteredwave = butterworthHighpass.FilterData(waveform)
                        Case 2 'butterworth bandpass
                            Dim butterworthBandpass As NationalInstruments.Analysis.Dsp.Filters.ButterworthBandpassFilter _
                            = New ButterworthBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                            filteredwave = butterworthBandpass.FilterData(waveform)
                        Case 3 'butterworth bandstop
                            Dim butterworthBandstop As NationalInstruments.Analysis.Dsp.Filters.ButterworthBandstopFilter _
                            = New ButterworthBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, upperCutoffNumericEdit.Value)
                            filteredwave = butterworthBandstop.FilterData(waveform)
                    End Select
                Case 3 'Chebyshev filter is selected.
                    Select Case filterTypeComboBox.SelectedIndex
                        Case 0 'chebyshev lowpass
                            Dim chebyshevLowpass As NationalInstruments.Analysis.Dsp.Filters.ChebyshevLowpassFilter _
                            = New ChebyshevLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, _
                            rippleNumericEdit.Value)
                            filteredwave = chebyshevLowpass.FilterData(waveform)
                        Case 1 ' chebyshev highpass
                            Dim chebyshevHighpass As NationalInstruments.Analysis.Dsp.Filters.ChebyshevHighpassFilter _
                            = New ChebyshevHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, _
                            rippleNumericEdit.Value)
                            filteredwave = chebyshevHighpass.FilterData(waveform)
                        Case 2 'chebyshev bandpass
                            Dim chebyshevBandpass As NationalInstruments.Analysis.Dsp.Filters.ChebyshevBandpassFilter _
                            = New ChebyshevBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, _
                            upperCutoffNumericEdit.Value, rippleNumericEdit.Value)
                            filteredwave = chebyshevBandpass.FilterData(waveform)
                        Case 3 'chebyshev bandstop 
                            Dim chebyshevBandstop As NationalInstruments.Analysis.Dsp.Filters.ChebyshevBandstopFilter _
                            = New ChebyshevBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, _
                            upperCutoffNumericEdit.Value, rippleNumericEdit.Value)
                            filteredwave = chebyshevBandstop.FilterData(waveform)
                    End Select
                Case 4 'Inverse chebyshev filter is selected.
                    Select Case filterTypeComboBox.SelectedIndex
                        Case 0 'Inverse chebyshev lowpass
                            Dim inverseChebyshevLowpass As NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevLowpassFilter _
                            = New InverseChebyshevLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = inverseChebyshevLowpass.FilterData(waveform)
                        Case 1 'Inverse chebyshev highpass.
                            Dim inverseChebyshevHighpass As NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevHighpassFilter _
                            = New InverseChebyshevHighpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = inverseChebyshevHighpass.FilterData(waveform)
                        Case 2 'Inverse chebyshev bandpass
                            Dim inverseChebyshevBandpass As NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevBandpassFilter _
                            = New InverseChebyshevBandpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, _
                            upperCutoffNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = inverseChebyshevBandpass.FilterData(waveform)
                        Case 3 'Inverse chebyshev bandstop
                            Dim inverseChebyshevBandstop As NationalInstruments.Analysis.Dsp.Filters.InverseChebyshevBandstopFilter _
                            = New InverseChebyshevBandstopFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, _
                            upperCutoffNumericEdit.Value, attenuationNumericEdit.Value)
                            filteredwave = inverseChebyshevBandstop.FilterData(waveform)
                    End Select
                Case Else
                    Dim ellipticLowpassDefault As NationalInstruments.Analysis.Dsp.Filters.EllipticLowpassFilter _
                    = New EllipticLowpassFilter(orderNumericEdit.Value, samplingRateNumericEdit.Value, lowerCutoffNumericEdit.Value, rippleNumericEdit.Value, attenuationNumericEdit.Value)
                    filteredwave = ellipticLowpassDefault.FilterData(waveform)
            End Select
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try
    End Sub

    'Mix noise to the signal.
    Private Sub MixNoiseToSignal()
        Dim i As Integer

        noiseWaveform = New Double(numberOfSamplesNumericEdit.Value - 1) {}

        'Create white noise of specified amplitude.
        Dim whiteNoise As NationalInstruments.Analysis.SignalGeneration.WhiteNoiseSignal _
        = New WhiteNoiseSignal(noiseAmplitudeNumericEdit.Value, 1)
        noiseWaveform = whiteNoise.Generate(samplingRateNumericEdit.Value, numberOfSamplesNumericEdit.Value)
        'Add noise to signal.
        For i = 0 To (numberOfSamplesNumericEdit.Value - 1)
            noiseWaveform(i) = noiseWaveform(i) + waveform(i)
        Next i
    End Sub

    'Calculate FFT of the waveform.
    Private Sub CalculateFFTFunction(ByVal waveform() As Double)

        Dim datasize As Integer = waveform.Length
        Dim fftnumofSamples As Integer = datasize / 2

        xwaveform = New Double(fftnumofSamples - 1) {}
        magnitudes = New Double(datasize - 1) {}
        subsetOfMagnitudes = New Double(fftnumofSamples - 1) {}
        phases = New Double(datasize - 1) {}
        subsetOfPhases = New Double(fftnumofSamples - 1) {}
        logMagnitudes = New Double(fftnumofSamples - 1) {}
        FFTValue = New ComplexDouble(datasize - 1) {}
        Dim i As Integer

        'Calculate the FFT of waveform array.
        FFTValue = NationalInstruments.Analysis.Dsp.Transforms.RealFft(waveform)
        'Get the magnitudes and phases of FFT array..
        NationalInstruments.ComplexDouble.DecomposeArrayPolar(FFTValue, magnitudes, phases)

        Dim scalingFactor As Double = 1.0 / datasize
        Dim deltafreq As Double = samplingRateNumericEdit.Value * scalingFactor

        'scale DC value
        subsetOfMagnitudes(0) = magnitudes(0) * scalingFactor

        'It's sufficient to plot just the half of numberOfSamples points to show the FFT.
        ' Because the other half will be just the mirror image of the first half.
        For i = 1 To (fftnumofSamples - 1)

            'Generating xwaveform with respect to which magnitude and phase will be plotted.
            xwaveform(i) = deltafreq * i
            subsetOfMagnitudes(i) = magnitudes(i) * scalingFactor * System.Math.Sqrt(2.0) 'Storing only half the magnitudes array.
            subsetOfPhases(i) = phases(i) 'Storing only half of the phases array.
        Next i

        'Display mode: linear or exponential
        Select Case displayModeComboBox.SelectedIndex
            'Plot the magnitudes and the phases.
        Case 0 'Linear mode.
                magnitudePlot.YAxis.Caption = "Magnitude VRMS"
                magnitudePlot.PlotXY(xwaveform, subsetOfMagnitudes)
                phasePlot.PlotXY(xwaveform, subsetOfPhases)
            Case 1 'Exponential mode.
                For i = 0 To (numberOfSamplesNumericEdit.Value / 2 - 1)
                    logMagnitudes(i) = 20 * System.Math.Log10(magnitudes(i))

                    magnitudePlot.YAxis.Caption = "Magnitude in dB"
                    magnitudePlot.PlotXY(xwaveform, logMagnitudes)
                    phasePlot.PlotXY(xwaveform, subsetOfPhases)
                Next i
        End Select
    End Sub

    Private Sub displaySignal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displaySignalButton.Click
        displaySignalClicked = True
        signalWithNoisePlot.ClearData()
        ShowSignalSource()
    End Sub

    'When Calculate FFT Before Filtering button is clicked.
    Private Sub calculateFFTBeforeFiltering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateFFTBeforeFilteringButton.Click
        calculateFFTofTheFilteredSignalClicked = False
        calculateFFTofTheFilteredNoisySignalClicked = False
        calculateFFTofTheUnfilteredSignalClicked = True
        calculateFFTofTheUnfilteredNoisySignalClicked = False
        ShowSignalSource() 'Displays signal source.
        CalculateFFTFunction(waveform) 'Calculate FFT of unfiltered waveform. 
    End Sub

    'When the CalculateFFTofFilteredSignal button is clicked.
    Private Sub calculateFFTOfFilteredSignal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateFFTOfFilteredSignalButton.Click
        calculateFFTofTheFilteredSignalClicked = True
        calculateFFTofTheFilteredNoisySignalClicked = False
        calculateFFTofTheUnfilteredSignalClicked = False
        calculateFFTofTheUnfilteredNoisySignalClicked = False
        ShowSignalSource() 'Displays the signal source.
        FilterSignal(waveform) 'Filter the waveform.
        CalculateFFTFunction(filteredwave) 'Calculate fft of filtered wave.
    End Sub

    'When DisplaySignalWithNoise button is clicked.
    Private Sub displaySignalWithNoise_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displaySignalWithNoiseButton.Click
        displayNoisySignalClicked = True   'Status is true indicating that this button is clicked.
        ShowSignalSource() 'Plot signal source
        MixNoiseToSignal() 'White noise is added to signal
        'signalPlot.ClearData();
        signalWithNoisePlot.PlotXY(xwave, noiseWaveform) 'Plot noisy wave.
    End Sub

    'When CalculateFFTOFNoisySignal button is clicked.
    Private Sub calculateFFTOfNoisySignal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateFFTOfNoisySignalButton.Click
        'Status of the different buttons clicked.
        calculateFFTofTheFilteredSignalClicked = False
        calculateFFTofTheFilteredNoisySignalClicked = False
        calculateFFTofTheUnfilteredSignalClicked = False
        calculateFFTofTheUnfilteredNoisySignalClicked = True
        ShowSignalSource() 'Plot signal source.
        MixNoiseToSignal() 'Plot noisy signal.
        CalculateFFTFunction(noiseWaveform) 'Calculate FFT of noisy waveform and plot it on the graph.
    End Sub

    'When CalculateFFTOFFilteredNoisySignal button is clicked.
    Private Sub calculateFFTOfFilteredNoisySignal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculateFFTOfFilteredNoisySignalButton.Click
        'Status of the different buttons clicked.
        calculateFFTofTheFilteredSignalClicked = False
        calculateFFTofTheFilteredNoisySignalClicked = True
        calculateFFTofTheUnfilteredSignalClicked = False
        calculateFFTofTheUnfilteredNoisySignalClicked = False
        ShowSignalSource() 'Plot signal source.
        MixNoiseToSignal() 'Plot noisy signal.
        FilterSignal(noiseWaveform) 'Filter noisy signal.
        CalculateFFTFunction(filteredwave) 'Calculate FFT of filetered waveform and plot it on the waveform.
    End Sub

    Private Sub signalSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signalSourceComboBox.SelectedIndexChanged
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If

        If (displaySignalClicked) Then
            displaySignalButton.PerformClick()
        End If
        If (displayNoisySignalClicked) Then
            displaySignalWithNoiseButton.PerformClick()
        End If
    End Sub


    Private Sub frequency_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frequencyNumericEdit.ValueChanged
        signalScatterGraph.ClearData()

        'Updation of displayed graphs.
        If (displaySignalClicked) Then
            displaySignalButton.PerformClick()
        End If
        If (displayNoisySignalClicked) Then
            displaySignalWithNoiseButton.PerformClick()
        End If
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub samplingRate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles samplingRateNumericEdit.ValueChanged
        signalScatterGraph.ClearData()

        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If

        If (displaySignalClicked) Then
            displaySignalButton.PerformClick()
        End If
        If (displayNoisySignalClicked) Then
            displaySignalWithNoiseButton.PerformClick()
        End If
    End Sub

    Private Sub numberOfSamples_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numberOfSamplesNumericEdit.ValueChanged
        signalScatterGraph.ClearData()

        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
        If (displaySignalClicked) Then
            displaySignalButton.PerformClick()
        End If
        If (displayNoisySignalClicked) Then
            displaySignalWithNoiseButton.PerformClick()
        End If
    End Sub

    Private Sub signalAmplitude_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signalAmplitudeNumericEdit.ValueChanged
        signalScatterGraph.ClearData()

        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
        If (displaySignalClicked) Then
            displaySignalButton.PerformClick()
        End If
        If (displayNoisySignalClicked) Then
            displaySignalWithNoiseButton.PerformClick()
        End If
    End Sub

    Private Sub noiseAmplitude_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noiseAmplitudeNumericEdit.ValueChanged
        'Updation of displayed graphs.
        If (displaySignalClicked) Then
            displaySignalButton.PerformClick()
        End If
        If (displayNoisySignalClicked) Then
            displaySignalWithNoiseButton.PerformClick()
        End If
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub displayMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayModeComboBox.SelectedIndexChanged
        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub filterType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterTypeComboBox.SelectedIndexChanged
        If (filterTypeComboBox.SelectedIndex = 0 Or filterTypeComboBox.SelectedIndex = 1) Then
            upperCutoffNumericEdit.Enabled = False
        Else
            upperCutoffNumericEdit.Enabled = True
        End If
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub filterDesign_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterDesignComboBox.SelectedIndexChanged
        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub ripple_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rippleNumericEdit.ValueChanged
        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub attenuation_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles attenuationNumericEdit.ValueChanged
        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub order_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles orderNumericEdit.ValueChanged
        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub lowerCutoff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lowerCutoffNumericEdit.ValueChanged
        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

    Private Sub upperCutoff_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upperCutoffNumericEdit.ValueChanged
        'Updation of displayed graphs.
        If (calculateFFTofTheFilteredSignalClicked) Then
            calculateFFTOfFilteredSignalButton.PerformClick()
        ElseIf (calculateFFTofTheFilteredNoisySignalClicked) Then
            calculateFFTOfFilteredNoisySignalButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredSignalClicked) Then
            calculateFFTBeforeFilteringButton.PerformClick()
        ElseIf (calculateFFTofTheUnfilteredNoisySignalClicked) Then
            calculateFFTOfNoisySignalButton.PerformClick()
        End If
    End Sub

End Class
