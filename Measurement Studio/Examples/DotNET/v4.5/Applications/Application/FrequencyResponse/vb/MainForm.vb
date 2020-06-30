Option Explicit On 
Imports System.Math

Public Class MainForm
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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
    Friend WithEvents currentFrequencyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents currentFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents currentFrequencyMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents frequencyResponseScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents frequenciesPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents decibelAxis As NationalInstruments.UI.XAxis
    Friend WithEvents frequencyAxis As NationalInstruments.UI.YAxis
    Friend WithEvents linearlyEvaluatedFrequenciesPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents curveFitPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents curveFitButton As System.Windows.Forms.Button
    Friend WithEvents RunTestButton As System.Windows.Forms.Button
    Friend WithEvents frequencyGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents stepsLabel As System.Windows.Forms.Label
    Friend WithEvents stepsNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents stopFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents startFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents stopFrequencyKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents startFrequencyKnob As NationalInstruments.UI.WindowsForms.Knob
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.currentFrequencyGroupBox = New System.Windows.Forms.GroupBox
        Me.currentFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.currentFrequencyMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.frequencyResponseScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.frequenciesPlot = New NationalInstruments.UI.ScatterPlot
        Me.decibelAxis = New NationalInstruments.UI.XAxis
        Me.frequencyAxis = New NationalInstruments.UI.YAxis
        Me.linearlyEvaluatedFrequenciesPlot = New NationalInstruments.UI.ScatterPlot
        Me.curveFitPlot = New NationalInstruments.UI.ScatterPlot
        Me.curveFitButton = New System.Windows.Forms.Button
        Me.runTestButton = New System.Windows.Forms.Button
        Me.frequencyGroupBox = New System.Windows.Forms.GroupBox
        Me.stepsLabel = New System.Windows.Forms.Label
        Me.stepsNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.stopFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.stopFrequencyKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.startFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.startFrequencyKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.currentFrequencyGroupBox.SuspendLayout()
        CType(Me.currentFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentFrequencyMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frequencyResponseScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frequencyGroupBox.SuspendLayout()
        CType(Me.stepsNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stopFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stopFrequencyKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startFrequencyKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'currentFrequencyGroupBox
        '
        Me.currentFrequencyGroupBox.Controls.Add(Me.currentFrequencyNumericEdit)
        Me.currentFrequencyGroupBox.Controls.Add(Me.currentFrequencyMeter)
        Me.currentFrequencyGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.currentFrequencyGroupBox.Location = New System.Drawing.Point(503, 2)
        Me.currentFrequencyGroupBox.Name = "currentFrequencyGroupBox"
        Me.currentFrequencyGroupBox.Size = New System.Drawing.Size(216, 184)
        Me.currentFrequencyGroupBox.TabIndex = 9
        Me.currentFrequencyGroupBox.TabStop = False
        '
        'currentFrequencyNumeric
        '
        Me.currentFrequencyNumericEdit.ImmediateUpdates = True
        Me.currentFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.currentFrequencyNumericEdit.Location = New System.Drawing.Point(56, 152)
        Me.currentFrequencyNumericEdit.Name = "currentFrequencyNumeric"
        Me.currentFrequencyNumericEdit.Source = Me.currentFrequencyMeter
        Me.currentFrequencyNumericEdit.TabIndex = 11
        '
        'currentFrequencyMeter
        '
        Me.currentFrequencyMeter.Caption = "Current Frequency"
        Me.currentFrequencyMeter.ImmediateUpdates = True
        Me.currentFrequencyMeter.Location = New System.Drawing.Point(24, 8)
        Me.currentFrequencyMeter.Name = "currentFrequencyMeter"
        Me.currentFrequencyMeter.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.currentFrequencyMeter.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.currentFrequencyMeter.Size = New System.Drawing.Size(184, 112)
        Me.currentFrequencyMeter.TabIndex = 10
        '
        'frequencyResponseGraph
        '
        Me.frequencyResponseScatterGraph.ImmediateUpdates = True
        Me.frequencyResponseScatterGraph.Location = New System.Drawing.Point(7, 194)
        Me.frequencyResponseScatterGraph.Name = "frequencyResponseGraph"
        Me.frequencyResponseScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.frequenciesPlot, Me.linearlyEvaluatedFrequenciesPlot, Me.curveFitPlot})
        Me.frequencyResponseScatterGraph.Size = New System.Drawing.Size(712, 208)
        Me.frequencyResponseScatterGraph.TabIndex = 12
        Me.frequencyResponseScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.decibelAxis})
        Me.frequencyResponseScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.frequencyAxis})
        '
        'frequenciesPlot
        '
        Me.frequenciesPlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.frequenciesPlot.PointColor = System.Drawing.Color.Red
        Me.frequenciesPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptySquare
        Me.frequenciesPlot.XAxis = Me.decibelAxis
        Me.frequenciesPlot.YAxis = Me.frequencyAxis
        '
        'decibelAxis
        '
        Me.decibelAxis.BaseLineVisible = True
        Me.decibelAxis.Caption = "Decibels"
        Me.decibelAxis.MajorDivisions.GridVisible = True
        Me.decibelAxis.MinorDivisions.GridVisible = True
        Me.decibelAxis.Mode = NationalInstruments.UI.AxisMode.StripChart
        Me.decibelAxis.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.decibelAxis.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        '
        'frequencyAxis
        '
        Me.frequencyAxis.Caption = "Frequencies"
        Me.frequencyAxis.MajorDivisions.GridVisible = True
        Me.frequencyAxis.Range = New NationalInstruments.UI.Range(-60, 0)
        '
        'linearlyEvaluatedFrequenciesPlot
        '
        Me.linearlyEvaluatedFrequenciesPlot.AntiAliased = True
        Me.linearlyEvaluatedFrequenciesPlot.LineColor = System.Drawing.Color.Yellow
        Me.linearlyEvaluatedFrequenciesPlot.XAxis = Me.decibelAxis
        Me.linearlyEvaluatedFrequenciesPlot.YAxis = Me.frequencyAxis
        '
        'curveFitPlot
        '
        Me.curveFitPlot.AntiAliased = True
        Me.curveFitPlot.LineColor = System.Drawing.Color.White
        Me.curveFitPlot.XAxis = Me.decibelAxis
        Me.curveFitPlot.YAxis = Me.frequencyAxis
        '
        'curveFitButton
        '
        Me.curveFitButton.Enabled = False
        Me.curveFitButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.curveFitButton.Location = New System.Drawing.Point(407, 66)
        Me.curveFitButton.Name = "curveFitButton"
        Me.curveFitButton.Size = New System.Drawing.Size(88, 32)
        Me.curveFitButton.TabIndex = 8
        Me.curveFitButton.Text = "Curve Fit"
        '
        'RunTestButton
        '
        Me.RunTestButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RunTestButton.Location = New System.Drawing.Point(407, 26)
        Me.RunTestButton.Name = "RunTestButton"
        Me.RunTestButton.Size = New System.Drawing.Size(88, 32)
        Me.RunTestButton.TabIndex = 7
        Me.RunTestButton.Text = "Run Test"
        '
        'frequencyGroupBox
        '
        Me.frequencyGroupBox.Controls.Add(Me.stepsLabel)
        Me.frequencyGroupBox.Controls.Add(Me.stepsNumericEdit)
        Me.frequencyGroupBox.Controls.Add(Me.stopFrequencyNumericEdit)
        Me.frequencyGroupBox.Controls.Add(Me.startFrequencyNumericEdit)
        Me.frequencyGroupBox.Controls.Add(Me.stopFrequencyKnob)
        Me.frequencyGroupBox.Controls.Add(Me.startFrequencyKnob)
        Me.frequencyGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.frequencyGroupBox.Location = New System.Drawing.Point(7, 2)
        Me.frequencyGroupBox.Name = "frequencyGroupBox"
        Me.frequencyGroupBox.Size = New System.Drawing.Size(392, 184)
        Me.frequencyGroupBox.TabIndex = 0
        Me.frequencyGroupBox.TabStop = False
        '
        'stepsLabel
        '
        Me.stepsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stepsLabel.Location = New System.Drawing.Point(318, 48)
        Me.stepsLabel.Name = "stepsLabel"
        Me.stepsLabel.Size = New System.Drawing.Size(48, 16)
        Me.stepsLabel.TabIndex = 5
        Me.stepsLabel.Text = "Steps"
        '
        'stepsNumeric
        '
        Me.stepsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.stepsNumericEdit.Location = New System.Drawing.Point(320, 64)
        Me.stepsNumericEdit.Name = "stepsNumeric"
        Me.stepsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.stepsNumericEdit.Range = New NationalInstruments.UI.Range(6, 200)
        Me.stepsNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.stepsNumericEdit.TabIndex = 6
        Me.stepsNumericEdit.Value = 50
        '
        'stopFrequencyNumeric
        '
        Me.stopFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.stopFrequencyNumericEdit.Location = New System.Drawing.Point(201, 152)
        Me.stopFrequencyNumericEdit.Name = "stopFrequencyNumeric"
        Me.stopFrequencyNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.stopFrequencyNumericEdit.Source = Me.stopFrequencyKnob
        Me.stopFrequencyNumericEdit.TabIndex = 4
        Me.stopFrequencyNumericEdit.Value = 1000
        '
        'stopFrequencyKnob
        '
        Me.stopFrequencyKnob.AutoDivisionSpacing = False
        Me.stopFrequencyKnob.Caption = "Stop Frequency"
        Me.stopFrequencyKnob.Location = New System.Drawing.Point(160, 8)
        Me.stopFrequencyKnob.MajorDivisions.Interval = 250
        Me.stopFrequencyKnob.MinorDivisions.TickVisible = False
        Me.stopFrequencyKnob.Name = "stopFrequencyKnob"
        Me.stopFrequencyKnob.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.stopFrequencyKnob.Size = New System.Drawing.Size(152, 144)
        Me.stopFrequencyKnob.TabIndex = 3
        Me.stopFrequencyKnob.Value = 1000
        '
        'startFrequencyNumeric
        '
        Me.startFrequencyNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.startFrequencyNumericEdit.Location = New System.Drawing.Point(48, 152)
        Me.startFrequencyNumericEdit.Name = "startFrequencyNumeric"
        Me.startFrequencyNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.startFrequencyNumericEdit.Source = Me.startFrequencyKnob
        Me.startFrequencyNumericEdit.TabIndex = 2
        Me.startFrequencyNumericEdit.Value = 1
        '
        'startFrequencyKnob
        '
        Me.startFrequencyKnob.AutoDivisionSpacing = False
        Me.startFrequencyKnob.Caption = "Start Frequency"
        Me.startFrequencyKnob.Location = New System.Drawing.Point(8, 8)
        Me.startFrequencyKnob.MajorDivisions.Interval = 250
        Me.startFrequencyKnob.MinorDivisions.TickVisible = False
        Me.startFrequencyKnob.Name = "startFrequencyKnob"
        Me.startFrequencyKnob.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.startFrequencyKnob.Size = New System.Drawing.Size(152, 144)
        Me.startFrequencyKnob.TabIndex = 1
        Me.startFrequencyKnob.Value = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(726, 404)
        Me.Controls.Add(Me.currentFrequencyGroupBox)
        Me.Controls.Add(Me.frequencyResponseScatterGraph)
        Me.Controls.Add(Me.curveFitButton)
        Me.Controls.Add(Me.RunTestButton)
        Me.Controls.Add(Me.frequencyGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Frequency Response"
        Me.currentFrequencyGroupBox.ResumeLayout(False)
        CType(Me.currentFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentFrequencyMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frequencyResponseScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frequencyGroupBox.ResumeLayout(False)
        CType(Me.stepsNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stopFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stopFrequencyKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startFrequencyKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim frequencies As Double()
    Dim dbValues As Double()
    Dim Offset As Double = 0.0
    Dim Amplitude As Double = 10.0
    Dim SamplingRate As Double = 1
    Dim NumberOfSamples As Integer = 1024

    Private Sub runTestbutton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunTestButton.Click
        Cursor = Cursors.WaitCursor
        ' Disable interaction with the knobs to prevent users from changing the values
        startFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.Indicator
        stopFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.Indicator

        Dim numberOfElements As Integer = CType(stepsNumericEdit.Value, Integer)
        frequencies = New Double(numberOfElements - 1) {}
        dbValues = New Double(numberOfElements - 1) {}

        ' Setup the array of frequencies based on the step and frequency range
        Dim increment As Double = (stopFrequencyKnob.Value - startFrequencyKnob.Value) / (stepsNumericEdit.Value - 1)
        Dim i As Integer
        For i = 0 To stepsNumericEdit.Value - 1 Step +1
            frequencies(i) = (startFrequencyKnob.Value + (i * increment)) / 100000.0
        Next

        frequencyResponseScatterGraph.ClearData()

        ' Loop through frequencies and generate sine wave and analyze response
        Dim voltages As Double() = New Double(numberOfElements - 1) {}

        For i = 0 To stepsNumericEdit.Value - 1 Step +1
            Dim phase As Double = 0.0
            Dim sinewave() As Double = BasicFunctionGenerator.GenerateSineWave(frequencies(i), Amplitude, phase, Offset, SamplingRate, NumberOfSamples)
            Dim filterOrder As Integer = 5
            Dim samplingFrequency As Double = 100000
            Dim lowerCutoffFrequency As Double = 200
            Dim upperCutoffFrequency As Double = 600
            Dim filter As ButterworthBandpassFilter = New ButterworthBandpassFilter(filterOrder, samplingFrequency, lowerCutoffFrequency, upperCutoffFrequency)
            Dim output() As Double = filter.FilterData(sinewave)

            voltages(i) = Statistics.RootMeanSquared(output)
            voltages(i) = (voltages(i) * Sqrt(2)) / 10.0
            dbValues(i) = 20.0 * Log10(voltages(i))

            ' Draw point on graph for this calculation and update current frequency
            frequenciesPlot.PlotXYAppend(frequencies(i) * 100000, dbValues(i))
            currentFrequencyMeter.Value = frequencies(i) * 100000
        Next

        ' Reset frequencies to range for display and plot line
        Dim slope As Double = 100000
        frequencies = ArrayOperation.LinearEvaluation1D(frequencies, slope, Offset)
        linearlyEvaluatedFrequenciesPlot.PlotXY(frequencies, dbValues)

        ' Enable Curve Fit button
        curveFitButton.Enabled = True

        ' Enable interaction with the knobs
        startFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.DragPointer Or RadialNumericPointerInteractionModes.SnapPointer
        stopFrequencyKnob.InteractionMode = RadialNumericPointerInteractionModes.DragPointer Or RadialNumericPointerInteractionModes.SnapPointer

        Cursor = Cursors.Default
    End Sub

    Private Sub curveFitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles curveFitButton.Click
        Dim order As Integer = 5

        ' Calculate 5th order polynomial fit and plot it to the graph
        Dim fittedCurveData() As Double = CurveFit.PolynomialFit(frequencies, dbValues, order, PolynomialFitAlgorithm.Svd)
        curveFitPlot.PlotXY(frequencies, fittedCurveData)
    End Sub

    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub
End Class
