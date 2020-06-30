Public Class MainForm
    Inherits System.Windows.Forms.Form

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
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents parametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents numberOfPointsLabel As System.Windows.Forms.Label
    Friend WithEvents noiseLevelLabel As System.Windows.Forms.Label
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents scatteredDataPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents fitDataPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents noiseLevelNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents calculatedFitWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.parametersGroupBox = New System.Windows.Forms.GroupBox
        Me.noiseLevelNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfPointsLabel = New System.Windows.Forms.Label
        Me.noiseLevelLabel = New System.Windows.Forms.Label
        Me.calculateButton = New System.Windows.Forms.Button
        Me.calculatedFitWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.scatteredDataPlot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.fitDataPlot = New NationalInstruments.UI.WaveformPlot
        Me.parametersGroupBox.SuspendLayout()
        CType(Me.noiseLevelNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calculatedFitWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'parametersGroupBox
        '
        Me.parametersGroupBox.Controls.Add(Me.noiseLevelNumericEdit)
        Me.parametersGroupBox.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.parametersGroupBox.Controls.Add(Me.numberOfPointsLabel)
        Me.parametersGroupBox.Controls.Add(Me.noiseLevelLabel)
        Me.parametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.parametersGroupBox.Location = New System.Drawing.Point(12, 10)
        Me.parametersGroupBox.Name = "parametersGroupBox"
        Me.parametersGroupBox.Size = New System.Drawing.Size(132, 156)
        Me.parametersGroupBox.TabIndex = 1
        Me.parametersGroupBox.TabStop = False
        Me.parametersGroupBox.Text = "Parameters"
        '
        'noiseLevelNumericEdit
        '
        Me.noiseLevelNumericEdit.CoercionInterval = 0.1
        Me.noiseLevelNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.noiseLevelNumericEdit.Location = New System.Drawing.Point(16, 108)
        Me.noiseLevelNumericEdit.Name = "noiseLevelNumericEdit"
        Me.noiseLevelNumericEdit.Size = New System.Drawing.Size(91, 20)
        Me.noiseLevelNumericEdit.TabIndex = 1
        Me.noiseLevelNumericEdit.Value = 0.1
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(16, 52)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfSamplesNumericEdit.Range = New NationalInstruments.UI.Range(3, Double.PositiveInfinity)
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(91, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 0
        Me.numberOfSamplesNumericEdit.Value = 50
        '
        'numberOfPointsLabel
        '
        Me.numberOfPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numberOfPointsLabel.Location = New System.Drawing.Point(16, 28)
        Me.numberOfPointsLabel.Name = "numberOfPointsLabel"
        Me.numberOfPointsLabel.Size = New System.Drawing.Size(107, 16)
        Me.numberOfPointsLabel.TabIndex = 4
        Me.numberOfPointsLabel.Text = "Number of points:"
        '
        'noiseLevelLabel
        '
        Me.noiseLevelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noiseLevelLabel.Location = New System.Drawing.Point(16, 92)
        Me.noiseLevelLabel.Name = "noiseLevelLabel"
        Me.noiseLevelLabel.Size = New System.Drawing.Size(67, 16)
        Me.noiseLevelLabel.TabIndex = 5
        Me.noiseLevelLabel.Text = "Noise Level:"
        '
        'calculateButton
        '
        Me.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.calculateButton.Location = New System.Drawing.Point(20, 180)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(120, 28)
        Me.calculateButton.TabIndex = 0
        Me.calculateButton.Text = "Calculate Fit"
        '
        'calculatedFitWaveformGraph
        '
        Me.calculatedFitWaveformGraph.Dock = System.Windows.Forms.DockStyle.Right
        Me.calculatedFitWaveformGraph.Location = New System.Drawing.Point(154, 0)
        Me.calculatedFitWaveformGraph.Name = "calculatedFitWaveformGraph"
        Me.calculatedFitWaveformGraph.UseColorGenerator = True
        Me.calculatedFitWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.scatteredDataPlot, Me.fitDataPlot})
        Me.calculatedFitWaveformGraph.Size = New System.Drawing.Size(336, 224)
        Me.calculatedFitWaveformGraph.TabIndex = 9
        Me.calculatedFitWaveformGraph.TabStop = False
        Me.calculatedFitWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.calculatedFitWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'scatteredDataPlot
        '
        Me.scatteredDataPlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.scatteredDataPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle
        Me.scatteredDataPlot.XAxis = Me.xAxis
        Me.scatteredDataPlot.YAxis = Me.yAxis
        '
        'xAxis
        '
        Me.xAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact
        '
        'yAxis
        '
        Me.yAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact
        '
        'fitDataPlot
        '
        Me.fitDataPlot.XAxis = Me.xAxis
        Me.fitDataPlot.YAxis = Me.yAxis
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(490, 224)
        Me.Controls.Add(Me.calculatedFitWaveformGraph)
        Me.Controls.Add(Me.parametersGroupBox)
        Me.Controls.Add(Me.calculateButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Non-Linear Fit"
        Me.parametersGroupBox.ResumeLayout(False)
        CType(Me.noiseLevelNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calculatedFitWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub GenerateDataToFit(ByVal numSamples As Integer, ByVal noiseAmplitude As Double, ByRef xData As Double(), ByRef yData As Double())
        ReDim xData(numSamples - 1)
        ReDim yData(numSamples - 1)


        Dim noise As WhiteNoiseSignal = New WhiteNoiseSignal(noiseAmplitude, 0)

        Dim noiseData As Double() = noise.Generate(numSamples, numSamples)

        For x As Integer = 0 To xData.Length - 1
            xData(x) = x
            yData(x) = System.Math.Exp(-0.1 * x) + 2.0 + noiseData(x)
        Next
    End Sub

    Private Sub OnCalculate(ByVal sender As Object, ByVal e As EventArgs) Handles calculateButton.Click
        Dim numSamples As Integer = numberOfSamplesNumericEdit.Value
        Dim noiseAmplitude As Double = noiseLevelNumericEdit.Value
        Dim xData As Double() = {}
        Dim yData As Double() = {}
        Dim coefficients As Double() = {2, 0, 4}

        GenerateDataToFit(numSamples, noiseAmplitude, xData, yData)
        scatteredDataPlot.PlotY(yData)

        Dim mse As Double
        Dim callback As ModelFunctionCallback = New ModelFunctionCallback(AddressOf ModelFunction)
        Try
            Dim fittedData As Double() = CurveFit.NonLinearFit(xData, yData, callback, coefficients, mse)
            fitDataPlot.PlotY(fittedData)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try
    End Sub

    Private Function ModelFunction(ByVal x As Double, ByVal a As Double()) As Double
        Return (a(0) * System.Math.Exp(a(1) * x)) + a(2)
    End Function

End Class
