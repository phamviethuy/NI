'==================================================================================================
'
' Title      : MainForm.vb
' Purpose    : This example shows the user how to use the PeakDetector function to find peaks and 
'              valleys on any kind of signal waveform.
'
'==================================================================================================

Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Global Variables.
    Dim amplitudePeak() As Double
    Dim amplitudeValley() As Double
    Dim locationPeak() As Double
    Dim locationValley() As Double
    Dim secondDerivativePeak() As Double
    Dim secondDerivativeValley() As Double
    Dim numOfPeaksFound As Integer
    Dim numOfValleysFound As Integer
    Dim detectPeaksClicked As Integer = 0

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        signalSourceComboBox.SelectedIndex = 0

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
    Friend WithEvents signalSourceLabel As System.Windows.Forms.Label
    Friend WithEvents numOfCyclesSinLabel As System.Windows.Forms.Label
    Friend WithEvents numOfCyclesCosLabel As System.Windows.Forms.Label
    Friend WithEvents filterOrderLabel As System.Windows.Forms.Label
    Friend WithEvents peak2ndDerivLabel As System.Windows.Forms.Label
    Friend WithEvents peakLocationLabel As System.Windows.Forms.Label
    Friend WithEvents peakAmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents peaksFoundLabel As System.Windows.Forms.Label
    Friend WithEvents valleysFoundLabel As System.Windows.Forms.Label
    Friend WithEvents valleyLocationLabel As System.Windows.Forms.Label
    Friend WithEvents valleyAmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents valley2ndDerivLabel As System.Windows.Forms.Label
    Friend WithEvents thresholdPLabel As System.Windows.Forms.Label
    Friend WithEvents pdWidthLabel As System.Windows.Forms.Label
    Friend WithEvents thresholdVLabel As System.Windows.Forms.Label
    Friend WithEvents numOfSamplesLabel As System.Windows.Forms.Label
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents amplitudeValleyPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents amplitudePeakPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents signalPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents numOfCosineCyclesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents filterOrderNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numOfSineCyclesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valleyLocationIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peak2ndDerivativeIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakLocationIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valleyAmplitudeIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakAmplitudeIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valley2ndDerivativeIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valley2ndDerivativeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valleyAmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valleyLocationNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peak2ndDerivativeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakAmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peakLocationNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valleysFoundNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents peaksFoundNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents thresholdValleyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents pdWidthNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents thresholdPeakNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents inputSignalGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents outputParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents signalScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents signalSourceComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents detectPeaksButton As System.Windows.Forms.Button
    Friend WithEvents peakDetectorHelpButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.inputSignalGroupBox = New System.Windows.Forms.GroupBox
        Me.numOfCosineCyclesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.filterOrderNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numOfSineCyclesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.signalSourceLabel = New System.Windows.Forms.Label
        Me.signalSourceComboBox = New System.Windows.Forms.ComboBox
        Me.numOfCyclesSinLabel = New System.Windows.Forms.Label
        Me.numOfCyclesCosLabel = New System.Windows.Forms.Label
        Me.filterOrderLabel = New System.Windows.Forms.Label
        Me.outputParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.valleyLocationIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peak2ndDerivativeIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peakLocationIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.valleyAmplitudeIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peakAmplitudeIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.valley2ndDerivativeIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.valley2ndDerivativeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.valleyAmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.valleyLocationNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peak2ndDerivativeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peakAmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peakLocationNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.valleysFoundNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peaksFoundNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peak2ndDerivLabel = New System.Windows.Forms.Label
        Me.peakLocationLabel = New System.Windows.Forms.Label
        Me.peakAmplitudeLabel = New System.Windows.Forms.Label
        Me.peaksFoundLabel = New System.Windows.Forms.Label
        Me.valleysFoundLabel = New System.Windows.Forms.Label
        Me.valleyLocationLabel = New System.Windows.Forms.Label
        Me.valleyAmplitudeLabel = New System.Windows.Forms.Label
        Me.valley2ndDerivLabel = New System.Windows.Forms.Label
        Me.thresholdPLabel = New System.Windows.Forms.Label
        Me.pdWidthLabel = New System.Windows.Forms.Label
        Me.thresholdVLabel = New System.Windows.Forms.Label
        Me.detectPeaksButton = New System.Windows.Forms.Button
        Me.thresholdValleyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.peakDetectorHelpButton = New System.Windows.Forms.Button
        Me.pdWidthNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.thresholdPeakNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numOfSamplesLabel = New System.Windows.Forms.Label
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.amplitudeValleyPlot = New NationalInstruments.UI.ScatterPlot
        Me.amplitudePeakPlot = New NationalInstruments.UI.ScatterPlot
        Me.signalPlot = New NationalInstruments.UI.ScatterPlot
        Me.signalScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.inputSignalGroupBox.SuspendLayout()
        CType(Me.numOfCosineCyclesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filterOrderNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numOfSineCyclesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.outputParametersGroupBox.SuspendLayout()
        CType(Me.valleyLocationIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peak2ndDerivativeIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakLocationIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valleyAmplitudeIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakAmplitudeIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valley2ndDerivativeIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valley2ndDerivativeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valleyAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valleyLocationNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peak2ndDerivativeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peakLocationNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valleysFoundNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.peaksFoundNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresholdValleyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pdWidthNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresholdPeakNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.signalScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputSignalGroupBox
        '
        Me.inputSignalGroupBox.Controls.Add(Me.numOfCosineCyclesNumericEdit)
        Me.inputSignalGroupBox.Controls.Add(Me.filterOrderNumericEdit)
        Me.inputSignalGroupBox.Controls.Add(Me.numOfSineCyclesNumericEdit)
        Me.inputSignalGroupBox.Controls.Add(Me.signalSourceLabel)
        Me.inputSignalGroupBox.Controls.Add(Me.signalSourceComboBox)
        Me.inputSignalGroupBox.Controls.Add(Me.numOfCyclesSinLabel)
        Me.inputSignalGroupBox.Controls.Add(Me.numOfCyclesCosLabel)
        Me.inputSignalGroupBox.Controls.Add(Me.filterOrderLabel)
        Me.inputSignalGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.inputSignalGroupBox.Location = New System.Drawing.Point(9, 8)
        Me.inputSignalGroupBox.Name = "inputSignalGroupBox"
        Me.inputSignalGroupBox.Size = New System.Drawing.Size(208, 176)
        Me.inputSignalGroupBox.TabIndex = 14
        Me.inputSignalGroupBox.TabStop = False
        Me.inputSignalGroupBox.Text = "Input Signal"
        '
        'numOfCosineCyclesNumericEdit
        '
        Me.numOfCosineCyclesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numOfCosineCyclesNumericEdit.Location = New System.Drawing.Point(16, 144)
        Me.numOfCosineCyclesNumericEdit.Name = "numOfCosineCyclesNumericEdit"
        Me.numOfCosineCyclesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numOfCosineCyclesNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.numOfCosineCyclesNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.numOfCosineCyclesNumericEdit.TabIndex = 3
        Me.numOfCosineCyclesNumericEdit.Value = 1
        '
        'filterOrderNumericEdit
        '
        Me.filterOrderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.filterOrderNumericEdit.Location = New System.Drawing.Point(128, 96)
        Me.filterOrderNumericEdit.Name = "filterOrderNumericEdit"
        Me.filterOrderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.filterOrderNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.filterOrderNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.filterOrderNumericEdit.TabIndex = 2
        Me.filterOrderNumericEdit.Value = 2
        '
        'numOfSineCyclesNumericEdit
        '
        Me.numOfSineCyclesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numOfSineCyclesNumericEdit.Location = New System.Drawing.Point(16, 96)
        Me.numOfSineCyclesNumericEdit.Name = "numOfSineCyclesNumericEdit"
        Me.numOfSineCyclesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numOfSineCyclesNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.numOfSineCyclesNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.numOfSineCyclesNumericEdit.TabIndex = 1
        Me.numOfSineCyclesNumericEdit.Value = 20
        '
        'signalSourceLabel
        '
        Me.signalSourceLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalSourceLabel.Location = New System.Drawing.Point(16, 24)
        Me.signalSourceLabel.Name = "signalSourceLabel"
        Me.signalSourceLabel.Size = New System.Drawing.Size(88, 16)
        Me.signalSourceLabel.TabIndex = 1
        Me.signalSourceLabel.Text = "Signal Source:"
        '
        'signalSourceComboBox
        '
        Me.signalSourceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.signalSourceComboBox.Items.AddRange(New Object() {"Sine + Cosine", "Filtered Noise"})
        Me.signalSourceComboBox.Location = New System.Drawing.Point(16, 40)
        Me.signalSourceComboBox.Name = "signalSourceComboBox"
        Me.signalSourceComboBox.Size = New System.Drawing.Size(96, 21)
        Me.signalSourceComboBox.TabIndex = 0
        '
        'numOfCyclesSinLabel
        '
        Me.numOfCyclesSinLabel.Enabled = False
        Me.numOfCyclesSinLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numOfCyclesSinLabel.Location = New System.Drawing.Point(16, 80)
        Me.numOfCyclesSinLabel.Name = "numOfCyclesSinLabel"
        Me.numOfCyclesSinLabel.Size = New System.Drawing.Size(80, 16)
        Me.numOfCyclesSinLabel.TabIndex = 12
        Me.numOfCyclesSinLabel.Text = "Cycles of Sine:"
        '
        'numOfCyclesCosLabel
        '
        Me.numOfCyclesCosLabel.Enabled = False
        Me.numOfCyclesCosLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numOfCyclesCosLabel.Location = New System.Drawing.Point(16, 128)
        Me.numOfCyclesCosLabel.Name = "numOfCyclesCosLabel"
        Me.numOfCyclesCosLabel.Size = New System.Drawing.Size(80, 16)
        Me.numOfCyclesCosLabel.TabIndex = 12
        Me.numOfCyclesCosLabel.Text = "Cycles of Cos:"
        '
        'filterOrderLabel
        '
        Me.filterOrderLabel.Enabled = False
        Me.filterOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterOrderLabel.Location = New System.Drawing.Point(128, 80)
        Me.filterOrderLabel.Name = "filterOrderLabel"
        Me.filterOrderLabel.Size = New System.Drawing.Size(64, 16)
        Me.filterOrderLabel.TabIndex = 1
        Me.filterOrderLabel.Text = "Filter Order:"
        '
        'outputParametersGroupBox
        '
        Me.outputParametersGroupBox.Controls.Add(Me.valleyLocationIndexNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peak2ndDerivativeIndexNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peakLocationIndexNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.valleyAmplitudeIndexNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peakAmplitudeIndexNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.valley2ndDerivativeIndexNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.valley2ndDerivativeNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.valleyAmplitudeNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.valleyLocationNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peak2ndDerivativeNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peakAmplitudeNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peakLocationNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.valleysFoundNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peaksFoundNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.peak2ndDerivLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.peakLocationLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.peakAmplitudeLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.peaksFoundLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.valleysFoundLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.valleyLocationLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.valleyAmplitudeLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.valley2ndDerivLabel)
        Me.outputParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.outputParametersGroupBox.Location = New System.Drawing.Point(225, 264)
        Me.outputParametersGroupBox.Name = "outputParametersGroupBox"
        Me.outputParametersGroupBox.Size = New System.Drawing.Size(504, 160)
        Me.outputParametersGroupBox.TabIndex = 13
        Me.outputParametersGroupBox.TabStop = False
        Me.outputParametersGroupBox.Text = "Output Parameters"
        '
        'valleyLocationIndexNumericEdit
        '
        Me.valleyLocationIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.valleyLocationIndexNumericEdit.Location = New System.Drawing.Point(336, 32)
        Me.valleyLocationIndexNumericEdit.Name = "valleyLocationIndexNumericEdit"
        Me.valleyLocationIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.valleyLocationIndexNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.valleyLocationIndexNumericEdit.Size = New System.Drawing.Size(40, 20)
        Me.valleyLocationIndexNumericEdit.TabIndex = 4
        Me.valleyLocationIndexNumericEdit.Value = 1
        '
        'peak2ndDerivativeIndexNumericEdit
        '
        Me.peak2ndDerivativeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.peak2ndDerivativeIndexNumericEdit.Location = New System.Drawing.Point(152, 128)
        Me.peak2ndDerivativeIndexNumericEdit.Name = "peak2ndDerivativeIndexNumericEdit"
        Me.peak2ndDerivativeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.peak2ndDerivativeIndexNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.peak2ndDerivativeIndexNumericEdit.Size = New System.Drawing.Size(40, 20)
        Me.peak2ndDerivativeIndexNumericEdit.TabIndex = 3
        Me.peak2ndDerivativeIndexNumericEdit.Value = 1
        '
        'peakLocationIndexNumericEdit
        '
        Me.peakLocationIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.peakLocationIndexNumericEdit.Location = New System.Drawing.Point(152, 32)
        Me.peakLocationIndexNumericEdit.Name = "peakLocationIndexNumericEdit"
        Me.peakLocationIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.peakLocationIndexNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.peakLocationIndexNumericEdit.Size = New System.Drawing.Size(40, 20)
        Me.peakLocationIndexNumericEdit.TabIndex = 1
        Me.peakLocationIndexNumericEdit.Value = 1
        '
        'valleyAmplitudeIndexNumericEdit
        '
        Me.valleyAmplitudeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.valleyAmplitudeIndexNumericEdit.Location = New System.Drawing.Point(336, 80)
        Me.valleyAmplitudeIndexNumericEdit.Name = "valleyAmplitudeIndexNumericEdit"
        Me.valleyAmplitudeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.valleyAmplitudeIndexNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.valleyAmplitudeIndexNumericEdit.Size = New System.Drawing.Size(40, 20)
        Me.valleyAmplitudeIndexNumericEdit.TabIndex = 5
        Me.valleyAmplitudeIndexNumericEdit.Value = 1
        '
        'peakAmplitudeIndexNumericEdit
        '
        Me.peakAmplitudeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.peakAmplitudeIndexNumericEdit.Location = New System.Drawing.Point(152, 80)
        Me.peakAmplitudeIndexNumericEdit.Name = "peakAmplitudeIndexNumericEdit"
        Me.peakAmplitudeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.peakAmplitudeIndexNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.peakAmplitudeIndexNumericEdit.Size = New System.Drawing.Size(40, 20)
        Me.peakAmplitudeIndexNumericEdit.TabIndex = 2
        Me.peakAmplitudeIndexNumericEdit.Value = 1
        '
        'valley2ndDerivativeIndexNumericEdit
        '
        Me.valley2ndDerivativeIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.valley2ndDerivativeIndexNumericEdit.Location = New System.Drawing.Point(336, 128)
        Me.valley2ndDerivativeIndexNumericEdit.Name = "valley2ndDerivativeIndexNumericEdit"
        Me.valley2ndDerivativeIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.valley2ndDerivativeIndexNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.valley2ndDerivativeIndexNumericEdit.Size = New System.Drawing.Size(40, 20)
        Me.valley2ndDerivativeIndexNumericEdit.TabIndex = 6
        Me.valley2ndDerivativeIndexNumericEdit.Value = 1
        '
        'valley2ndDerivativeNumericEdit
        '
        Me.valley2ndDerivativeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.valley2ndDerivativeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.valley2ndDerivativeNumericEdit.Location = New System.Drawing.Point(376, 128)
        Me.valley2ndDerivativeNumericEdit.Name = "valley2ndDerivativeNumericEdit"
        Me.valley2ndDerivativeNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.valley2ndDerivativeNumericEdit.TabIndex = 14
        Me.valley2ndDerivativeNumericEdit.TabStop = False
        '
        'valleyAmplitudeNumericEdit
        '
        Me.valleyAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.valleyAmplitudeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.valleyAmplitudeNumericEdit.Location = New System.Drawing.Point(376, 80)
        Me.valleyAmplitudeNumericEdit.Name = "valleyAmplitudeNumericEdit"
        Me.valleyAmplitudeNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.valleyAmplitudeNumericEdit.TabIndex = 13
        Me.valleyAmplitudeNumericEdit.TabStop = False
        '
        'valleyLocationNumericEdit
        '
        Me.valleyLocationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.valleyLocationNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.valleyLocationNumericEdit.Location = New System.Drawing.Point(376, 32)
        Me.valleyLocationNumericEdit.Name = "valleyLocationNumericEdit"
        Me.valleyLocationNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.valleyLocationNumericEdit.TabIndex = 12
        Me.valleyLocationNumericEdit.TabStop = False
        '
        'peak2ndDerivativeNumericEdit
        '
        Me.peak2ndDerivativeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.peak2ndDerivativeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peak2ndDerivativeNumericEdit.Location = New System.Drawing.Point(192, 128)
        Me.peak2ndDerivativeNumericEdit.Name = "peak2ndDerivativeNumericEdit"
        Me.peak2ndDerivativeNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.peak2ndDerivativeNumericEdit.TabIndex = 11
        Me.peak2ndDerivativeNumericEdit.TabStop = False
        '
        'peakAmplitudeNumericEdit
        '
        Me.peakAmplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.peakAmplitudeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peakAmplitudeNumericEdit.Location = New System.Drawing.Point(192, 80)
        Me.peakAmplitudeNumericEdit.Name = "peakAmplitudeNumericEdit"
        Me.peakAmplitudeNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.peakAmplitudeNumericEdit.TabIndex = 10
        Me.peakAmplitudeNumericEdit.TabStop = False
        '
        'peakLocationNumericEdit
        '
        Me.peakLocationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.peakLocationNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peakLocationNumericEdit.Location = New System.Drawing.Point(196, 33)
        Me.peakLocationNumericEdit.Name = "peakLocationNumericEdit"
        Me.peakLocationNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.peakLocationNumericEdit.TabIndex = 9
        Me.peakLocationNumericEdit.TabStop = False
        '
        'valleysFoundNumericEdit
        '
        Me.valleysFoundNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.valleysFoundNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.valleysFoundNumericEdit.Location = New System.Drawing.Point(16, 80)
        Me.valleysFoundNumericEdit.Name = "valleysFoundNumericEdit"
        Me.valleysFoundNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.valleysFoundNumericEdit.TabIndex = 8
        Me.valleysFoundNumericEdit.TabStop = False
        '
        'peaksFoundNumericEdit
        '
        Me.peaksFoundNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.peaksFoundNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.peaksFoundNumericEdit.Location = New System.Drawing.Point(16, 32)
        Me.peaksFoundNumericEdit.Name = "peaksFoundNumericEdit"
        Me.peaksFoundNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.peaksFoundNumericEdit.TabIndex = 7
        Me.peaksFoundNumericEdit.TabStop = False
        '
        'peak2ndDerivLabel
        '
        Me.peak2ndDerivLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.peak2ndDerivLabel.Location = New System.Drawing.Point(192, 112)
        Me.peak2ndDerivLabel.Name = "peak2ndDerivLabel"
        Me.peak2ndDerivLabel.Size = New System.Drawing.Size(112, 16)
        Me.peak2ndDerivLabel.TabIndex = 6
        Me.peak2ndDerivLabel.Text = "Peak 2nd Derivative:"
        '
        'peakLocationLabel
        '
        Me.peakLocationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.peakLocationLabel.Location = New System.Drawing.Point(192, 16)
        Me.peakLocationLabel.Name = "peakLocationLabel"
        Me.peakLocationLabel.Size = New System.Drawing.Size(88, 16)
        Me.peakLocationLabel.TabIndex = 6
        Me.peakLocationLabel.Text = "Peak Location:"
        '
        'peakAmplitudeLabel
        '
        Me.peakAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.peakAmplitudeLabel.Location = New System.Drawing.Point(192, 64)
        Me.peakAmplitudeLabel.Name = "peakAmplitudeLabel"
        Me.peakAmplitudeLabel.Size = New System.Drawing.Size(88, 16)
        Me.peakAmplitudeLabel.TabIndex = 6
        Me.peakAmplitudeLabel.Text = "Peak Amplitude:"
        '
        'peaksFoundLabel
        '
        Me.peaksFoundLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.peaksFoundLabel.Location = New System.Drawing.Point(16, 16)
        Me.peaksFoundLabel.Name = "peaksFoundLabel"
        Me.peaksFoundLabel.Size = New System.Drawing.Size(88, 16)
        Me.peaksFoundLabel.TabIndex = 6
        Me.peaksFoundLabel.Text = "# Peaks Found:"
        '
        'valleysFoundLabel
        '
        Me.valleysFoundLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.valleysFoundLabel.Location = New System.Drawing.Point(16, 64)
        Me.valleysFoundLabel.Name = "valleysFoundLabel"
        Me.valleysFoundLabel.Size = New System.Drawing.Size(88, 16)
        Me.valleysFoundLabel.TabIndex = 6
        Me.valleysFoundLabel.Text = "# Valleys Found:"
        '
        'valleyLocationLabel
        '
        Me.valleyLocationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.valleyLocationLabel.Location = New System.Drawing.Point(376, 16)
        Me.valleyLocationLabel.Name = "valleyLocationLabel"
        Me.valleyLocationLabel.Size = New System.Drawing.Size(88, 16)
        Me.valleyLocationLabel.TabIndex = 6
        Me.valleyLocationLabel.Text = "Valley Location:"
        '
        'valleyAmplitudeLabel
        '
        Me.valleyAmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.valleyAmplitudeLabel.Location = New System.Drawing.Point(376, 64)
        Me.valleyAmplitudeLabel.Name = "valleyAmplitudeLabel"
        Me.valleyAmplitudeLabel.Size = New System.Drawing.Size(104, 16)
        Me.valleyAmplitudeLabel.TabIndex = 6
        Me.valleyAmplitudeLabel.Text = "Valley Amplitude:"
        '
        'valley2ndDerivLabel
        '
        Me.valley2ndDerivLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.valley2ndDerivLabel.Location = New System.Drawing.Point(376, 112)
        Me.valley2ndDerivLabel.Name = "valley2ndDerivLabel"
        Me.valley2ndDerivLabel.Size = New System.Drawing.Size(120, 16)
        Me.valley2ndDerivLabel.TabIndex = 6
        Me.valley2ndDerivLabel.Text = "Valley 2nd Derivative:"
        '
        'thresholdPLabel
        '
        Me.thresholdPLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.thresholdPLabel.Location = New System.Drawing.Point(25, 256)
        Me.thresholdPLabel.Name = "thresholdPLabel"
        Me.thresholdPLabel.Size = New System.Drawing.Size(88, 16)
        Me.thresholdPLabel.TabIndex = 20
        Me.thresholdPLabel.Text = "Threshold Peak:"
        '
        'pdWidthLabel
        '
        Me.pdWidthLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.pdWidthLabel.Location = New System.Drawing.Point(137, 208)
        Me.pdWidthLabel.Name = "pdWidthLabel"
        Me.pdWidthLabel.Size = New System.Drawing.Size(64, 16)
        Me.pdWidthLabel.TabIndex = 18
        Me.pdWidthLabel.Text = "PD Width:"
        '
        'thresholdVLabel
        '
        Me.thresholdVLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.thresholdVLabel.Location = New System.Drawing.Point(137, 256)
        Me.thresholdVLabel.Name = "thresholdVLabel"
        Me.thresholdVLabel.Size = New System.Drawing.Size(88, 16)
        Me.thresholdVLabel.TabIndex = 22
        Me.thresholdVLabel.Text = "Threshold Valley:"
        '
        'detectPeaksButton
        '
        Me.detectPeaksButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.detectPeaksButton.Location = New System.Drawing.Point(34, 320)
        Me.detectPeaksButton.Name = "detectPeaksButton"
        Me.detectPeaksButton.Size = New System.Drawing.Size(128, 32)
        Me.detectPeaksButton.TabIndex = 11
        Me.detectPeaksButton.Text = "Detect Peaks"
        '
        'thresholdValleyNumericEdit
        '
        Me.thresholdValleyNumericEdit.CoercionInterval = 0.01
        Me.thresholdValleyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.thresholdValleyNumericEdit.Location = New System.Drawing.Point(137, 272)
        Me.thresholdValleyNumericEdit.Name = "thresholdValleyNumericEdit"
        Me.thresholdValleyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.thresholdValleyNumericEdit.Range = New NationalInstruments.UI.Range(-2, 0)
        Me.thresholdValleyNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.thresholdValleyNumericEdit.TabIndex = 23
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(25, 224)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfSamplesNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 17
        Me.numberOfSamplesNumericEdit.Value = 100
        '
        'peakDetectorHelpButton
        '
        Me.peakDetectorHelpButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.peakDetectorHelpButton.Location = New System.Drawing.Point(33, 368)
        Me.peakDetectorHelpButton.Name = "peakDetectorHelpButton"
        Me.peakDetectorHelpButton.Size = New System.Drawing.Size(128, 32)
        Me.peakDetectorHelpButton.TabIndex = 12
        Me.peakDetectorHelpButton.Text = "Help"
        '
        'pdWidthNumericEdit
        '
        Me.pdWidthNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.pdWidthNumericEdit.Location = New System.Drawing.Point(137, 224)
        Me.pdWidthNumericEdit.Name = "pdWidthNumericEdit"
        Me.pdWidthNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.pdWidthNumericEdit.Range = New NationalInstruments.UI.Range(3, Double.PositiveInfinity)
        Me.pdWidthNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.pdWidthNumericEdit.TabIndex = 19
        Me.pdWidthNumericEdit.Value = 3
        '
        'thresholdPeakNumericEdit
        '
        Me.thresholdPeakNumericEdit.CoercionInterval = 0.01
        Me.thresholdPeakNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.thresholdPeakNumericEdit.Location = New System.Drawing.Point(25, 272)
        Me.thresholdPeakNumericEdit.Name = "thresholdPeakNumericEdit"
        Me.thresholdPeakNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.thresholdPeakNumericEdit.Range = New NationalInstruments.UI.Range(0, 2)
        Me.thresholdPeakNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.thresholdPeakNumericEdit.TabIndex = 21
        '
        'numOfSamplesLabel
        '
        Me.numOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numOfSamplesLabel.Location = New System.Drawing.Point(25, 208)
        Me.numOfSamplesLabel.Name = "numOfSamplesLabel"
        Me.numOfSamplesLabel.Size = New System.Drawing.Size(104, 16)
        Me.numOfSamplesLabel.TabIndex = 16
        Me.numOfSamplesLabel.Text = "Number of Samples:"
        '
        'yAxis
        '
        Me.yAxis.Caption = "Amplitude"
        '
        'xAxis
        '
        Me.xAxis.Caption = "Number Of Samples"
        '
        'amplitudeValleyPlot
        '
        Me.amplitudeValleyPlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.amplitudeValleyPlot.PointColor = System.Drawing.Color.White
        Me.amplitudeValleyPlot.PointStyle = NationalInstruments.UI.PointStyle.SolidCircle
        Me.amplitudeValleyPlot.XAxis = Me.xAxis
        Me.amplitudeValleyPlot.YAxis = Me.yAxis
        '
        'amplitudePeakPlot
        '
        Me.amplitudePeakPlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.amplitudePeakPlot.PointColor = System.Drawing.Color.Blue
        Me.amplitudePeakPlot.PointStyle = NationalInstruments.UI.PointStyle.SolidCircle
        Me.amplitudePeakPlot.XAxis = Me.xAxis
        Me.amplitudePeakPlot.YAxis = Me.yAxis
        '
        'signalPlot
        '
        Me.signalPlot.XAxis = Me.xAxis
        Me.signalPlot.YAxis = Me.yAxis
        '
        'signalScatterGraph
        '
        Me.signalScatterGraph.Location = New System.Drawing.Point(225, 8)
        Me.signalScatterGraph.Name = "signalScatterGraph"
        Me.signalScatterGraph.UseColorGenerator = True
        Me.signalScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.signalPlot, Me.amplitudePeakPlot, Me.amplitudeValleyPlot})
        Me.signalScatterGraph.Size = New System.Drawing.Size(504, 250)
        Me.signalScatterGraph.TabIndex = 15
        Me.signalScatterGraph.TabStop = False
        Me.signalScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.signalScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(738, 432)
        Me.Controls.Add(Me.inputSignalGroupBox)
        Me.Controls.Add(Me.outputParametersGroupBox)
        Me.Controls.Add(Me.thresholdPLabel)
        Me.Controls.Add(Me.pdWidthLabel)
        Me.Controls.Add(Me.thresholdVLabel)
        Me.Controls.Add(Me.detectPeaksButton)
        Me.Controls.Add(Me.thresholdValleyNumericEdit)
        Me.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.Controls.Add(Me.peakDetectorHelpButton)
        Me.Controls.Add(Me.pdWidthNumericEdit)
        Me.Controls.Add(Me.thresholdPeakNumericEdit)
        Me.Controls.Add(Me.numOfSamplesLabel)
        Me.Controls.Add(Me.signalScatterGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peak Detector"
        Me.inputSignalGroupBox.ResumeLayout(False)
        CType(Me.numOfCosineCyclesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filterOrderNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numOfSineCyclesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.outputParametersGroupBox.ResumeLayout(False)
        CType(Me.valleyLocationIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peak2ndDerivativeIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakLocationIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valleyAmplitudeIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakAmplitudeIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valley2ndDerivativeIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valley2ndDerivativeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valleyAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valleyLocationNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peak2ndDerivativeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakAmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peakLocationNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valleysFoundNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.peaksFoundNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresholdValleyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pdWidthNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresholdPeakNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.signalScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub
    ' Detection of Peaks and Valleys.
    Private Sub DetectionOfPeaks()
        Dim i As Integer
        Dim waveform() As Double = New Double(numberOfSamplesNumericEdit.Value - 1) {}
        Dim xwave() As Double = New Double(numberOfSamplesNumericEdit.Value - 1) {}

        Dim peakPolarity As NationalInstruments.Analysis.Monitoring.PeakPolarity = peakPolarity.Peaks
        Dim peakDetect As NationalInstruments.Analysis.Monitoring.PeakDetector = New NationalInstruments.Analysis.Monitoring.PeakDetector(thresholdPeakNumericEdit.Value, pdWidthNumericEdit.Value, peakPolarity)

        'Generation of signal.
        Select Case signalSourceComboBox.SelectedIndex

            Case 0
                ' Sin + Cos
                ' Initialize a new signal generator with a sine wave
                Dim sigGen As New SignalGenerator(numberOfSamplesNumericEdit.Value, numberOfSamplesNumericEdit.Value, New SineSignal(numOfSineCyclesNumericEdit.Value, 1.0, 0.0))
                sigGen.Signals.Add(New SineSignal(numOfCosineCyclesNumericEdit.Value, 1.0, 90.0)) ' add a cosine wave to the signal collection
                waveform = sigGen.Generate()    ' generate the sum of the two signals
            Case 1
                'Filtered(Noise)
                Dim noiseWaveform() As Double = New Double(numberOfSamplesNumericEdit.Value - 1) {}
                Dim gaussianNoise As NationalInstruments.Analysis.SignalGeneration.GaussianNoiseSignal = New GaussianNoiseSignal(1.0, 1)
                Dim ellipticFilter As NationalInstruments.Analysis.Dsp.Filters.EllipticLowpassFilter = New EllipticLowpassFilter(filterOrderNumericEdit.Value, 1.0, 0.125, 1.0, 60.0)
                noiseWaveform = gaussianNoise.Generate(100.0, numberOfSamplesNumericEdit.Value)
                waveform = ellipticFilter.FilterData(noiseWaveform)
            Case Else
                ' Sin + Cos
                Dim sigGenDefault As New SignalGenerator(numberOfSamplesNumericEdit.Value, numberOfSamplesNumericEdit.Value, New SineSignal(numOfSineCyclesNumericEdit.Value, 1.0, 0.0))
                sigGenDefault.Signals.Add(New SineSignal(numOfCosineCyclesNumericEdit.Value, 1.0, 90.0))
                waveform = sigGenDefault.Generate()
        End Select

        'Detection of Peaks
        peakDetect.Detect(waveform, True, amplitudePeak, locationPeak, secondDerivativePeak)
        numOfPeaksFound = amplitudePeak.Length
        'set the value of numOfPeaksFound in the numberOfPeaksFound text box.
        peaksFoundNumericEdit.Text = numOfPeaksFound

        For i = 0 To (numberOfSamplesNumericEdit.Value - 1)
            xwave(i) = i
        Next i
        'Plotting of signal and peaks.
        signalPlot.PlotXY(xwave, waveform) 'Plot signal waveform.
        amplitudePeakPlot.PlotXY(locationPeak, amplitudePeak) 'Plot Peaks on the signal waveform.

        'Detection of Valleys
        peakPolarity = NationalInstruments.Analysis.Monitoring.PeakPolarity.Valleys
        peakDetect.Reset(thresholdValleyNumericEdit.Value, pdWidthNumericEdit.Value, peakPolarity)
        peakDetect.Detect(waveform, True, amplitudeValley, locationValley, secondDerivativeValley)
        numOfValleysFound = amplitudeValley.Length
        valleysFoundNumericEdit.Text = numOfValleysFound 'Set the number of Valleys Found in the text box.
        amplitudeValleyPlot.PlotXY(locationValley, amplitudeValley) 'Plot Valleys on the signal waveform.
        UpdatePeaksAndValleys()

    End Sub
    Private Sub UpdatePeaksAndValleys()
        ' Update Output Parameters by forcing a downButton event
        peakLocationIndexNumericEdit.Value = 2
        peakLocationIndexNumericEdit.DownButton()
        peakAmplitudeIndexNumericEdit.Value = 2
        peakAmplitudeIndexNumericEdit.DownButton()
        peak2ndDerivativeIndexNumericEdit.Value = 2
        peak2ndDerivativeIndexNumericEdit.DownButton()
        valley2ndDerivativeIndexNumericEdit.Value = 2
        valley2ndDerivativeIndexNumericEdit.DownButton()
        valleyAmplitudeIndexNumericEdit.Value = 2
        valleyAmplitudeIndexNumericEdit.DownButton()
        valleyLocationIndexNumericEdit.Value = 2
        valleyLocationIndexNumericEdit.DownButton()
    End Sub
    '
    ' On change of value of Peak Location Index control. 
    '
    Private Sub peakLocationIndex_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peakLocationIndexNumericEdit.ValueChanged
        If peakLocationIndexNumericEdit.Value > numOfPeaksFound Then
            peakLocationNumericEdit.Enabled = False
        Else
            peakLocationNumericEdit.Enabled = True
            peakLocationNumericEdit.Value = locationPeak(peakLocationIndexNumericEdit.Value - 1)
        End If
    End Sub
    '
    ' On change of value of Peak Amplitude Index control.
    '
    Private Sub peakAmplitudeIndex_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peakAmplitudeIndexNumericEdit.ValueChanged
        If peakAmplitudeIndexNumericEdit.Value > numOfPeaksFound Then
            peakAmplitudeNumericEdit.Enabled = False
        Else
            peakAmplitudeNumericEdit.Enabled = True
            peakAmplitudeNumericEdit.Value = amplitudePeak(peakAmplitudeIndexNumericEdit.Value - 1)
        End If
    End Sub

    '
    ' On change of value of Peak 2ndDerivative Index control.
    '
    Private Sub peak2ndDerivativeIndex_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peak2ndDerivativeIndexNumericEdit.ValueChanged
        If peak2ndDerivativeIndexNumericEdit.Value > numOfPeaksFound Then
            peak2ndDerivativeNumericEdit.Enabled = False
        Else
            peak2ndDerivativeNumericEdit.Enabled = True
            peak2ndDerivativeNumericEdit.Value = secondDerivativePeak(peak2ndDerivativeIndexNumericEdit.Value - 1)
        End If
    End Sub

    '
    ' On change of value of Valley Location Index control.
    '
    Private Sub valleyLocationIndex_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valleyLocationIndexNumericEdit.ValueChanged
        If valleyLocationIndexNumericEdit.Value > numOfValleysFound Then
            valleyLocationNumericEdit.Enabled = False
        Else
            valleyLocationNumericEdit.Enabled = True
            valleyLocationNumericEdit.Value = locationValley(valleyLocationIndexNumericEdit.Value - 1)
        End If
    End Sub

    '
    ' On change of value of Valley Amplitude Index control.
    '
    Private Sub valleyAmplitudeIndex_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valleyAmplitudeIndexNumericEdit.ValueChanged
        If valleyAmplitudeIndexNumericEdit.Value > numOfValleysFound Then
            valleyAmplitudeNumericEdit.Enabled = False
        Else
            valleyAmplitudeNumericEdit.Enabled = True
            valleyAmplitudeNumericEdit.Value = amplitudeValley(valleyAmplitudeIndexNumericEdit.Value - 1)
        End If
    End Sub

    '
    ' On change of value of Valley 2ndDerivative Index control.
    '
    Private Sub valley2ndDerivativeIndex_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles valley2ndDerivativeIndexNumericEdit.ValueChanged
        If valley2ndDerivativeIndexNumericEdit.Value > numOfValleysFound Then
            valley2ndDerivativeNumericEdit.Enabled = False
        Else
            valley2ndDerivativeNumericEdit.Enabled = True
            valley2ndDerivativeNumericEdit.Value = secondDerivativeValley(valley2ndDerivativeIndexNumericEdit.Value - 1)
        End If
    End Sub

    '
    ' On change of Value of ThresholdPeak control.
    '
    Private Sub thresholdPeak_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles thresholdPeakNumericEdit.ValueChanged
        DetectionOfPeaks()
    End Sub

    '
    ' On change of value of ThresholdValley control on the panel.
    '
    Private Sub thresholdValley_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles thresholdValleyNumericEdit.ValueChanged
        DetectionOfPeaks()
    End Sub

    '
    ' On click of detectPeaks button on the panel.
    '
    Private Sub detectPeaks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles detectPeaksButton.Click
        'detectPeaksClicked is 1 once detectPeak button is pressed.
        detectPeaksClicked = 1
        DetectionOfPeaks()
    End Sub

    '
    ' On click of Help button on the panel.
    '
    Private Sub helpMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles peakDetectorHelpButton.Click
        MessageBox.Show("This example demonstrates the use of the Peak Detector. Threshold Peak and Threshold Valley controls are used to set threshold for peaks and valleys. The default value of threshold is 0.0. PD Width controls the number of consecutive data points to be used in the quadratic least squares fit for the detection of peaks.", "HELP")
    End Sub


    '
    ' When the user selects a signal source on the panel.
    '
    Private Sub signalSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signalSourceComboBox.SelectedIndexChanged
        Select Case signalSourceComboBox.SelectedIndex
            Case 0
                numOfSineCyclesNumericEdit.Enabled = True
                numOfCosineCyclesNumericEdit.Enabled = True
                numOfCyclesCosLabel.Enabled = True
                numOfCyclesSinLabel.Enabled = True
                filterOrderNumericEdit.Enabled = False
                filterOrderLabel.Enabled = False

            Case 1
                numOfSineCyclesNumericEdit.Enabled = False
                numOfCosineCyclesNumericEdit.Enabled = False
                numOfCyclesCosLabel.Enabled = False
                numOfCyclesSinLabel.Enabled = False
                filterOrderNumericEdit.Enabled = True
                filterOrderLabel.Enabled = True
        End Select
        If (detectPeaksClicked = 1) Then
            DetectionOfPeaks()
        End If
    End Sub

    'When the value of cyclesOfSin control is changed by the user.
    Private Sub numOfSineCycles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numOfSineCyclesNumericEdit.ValueChanged
        If (detectPeaksClicked = 1) Then
            DetectionOfPeaks() 'call the detectionPeaks()function to recalculate the peaks and valleys.
        End If
    End Sub

    'When the value of cycelsOfCos control is changed by the user.
    Private Sub numOfCosineCycles_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numOfCosineCyclesNumericEdit.ValueChanged
        If (detectPeaksClicked = 1) Then
            DetectionOfPeaks() 'call the detectionPeaks()function to recalculate the peaks and valleys.
        End If
    End Sub

    'When the value of filterOrder control is changed by the user.
    Private Sub filterOrder_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filterOrderNumericEdit.ValueChanged
        If (detectPeaksClicked = 1) Then
            DetectionOfPeaks() 'call the detectionPeaks()function to recalculate the peaks and valleys.
        End If
    End Sub

    'When the value of NumberOfSamples control is changed by the user.
    Private Sub numberOfSamples_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numberOfSamplesNumericEdit.ValueChanged
        If (detectPeaksClicked = 1) Then
            DetectionOfPeaks() 'call the detectionPeaks()function to recalculate the peaks and valleys.
        End If
    End Sub

    'When the value of PDWidth control is changed by the user.
    Private Sub pdWidth_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pdWidthNumericEdit.ValueChanged
        If (detectPeaksClicked = 1) Then
            DetectionOfPeaks() 'call the detectionPeaks()function to recalculate the peaks and valleys.
        End If
    End Sub
End Class
