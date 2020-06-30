Imports NationalInstruments.UI


Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private lastPoint As Int32

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        AddHandler realPhaseNumericEdit.AfterChangeValue, AddressOf AfterChangeValue
        AddHandler realFrequencyNumericEdit.AfterChangeValue, AddressOf AfterChangeValue
        AddHandler imaginaryFrequencyNumericEdit.AfterChangeValue, AddressOf AfterChangeValue
        AddHandler imaginaryPhaseNumericEdit.AfterChangeValue, AddressOf AfterChangeValue

        PlotData()
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
    Friend WithEvents realGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents realFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents realPhaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents realWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents imaginaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents imaginaryWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents imaginaryFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents imaginaryPhaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sampleComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph
    Friend WithEvents complexPlot As NationalInstruments.UI.ComplexPlot
    Friend WithEvents realPhaseLabel As System.Windows.Forms.Label
    Friend WithEvents realFrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents imaginaryPhaseLabel As System.Windows.Forms.Label
    Friend WithEvents imaginaryFrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents realPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents realXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents realYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents imaginaryPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents imaginaryXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents imaginaryYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents complexXAxis As NationalInstruments.UI.ComplexXAxis
    Friend WithEvents complexYAxis As NationalInstruments.UI.ComplexYAxis
    Friend WithEvents plotTimer As System.Windows.Forms.Timer
    Friend WithEvents plotArrowsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents arrowDirectionLabel As System.Windows.Forms.Label
    Friend WithEvents arrowStyleLabel As System.Windows.Forms.Label
    Friend WithEvents arrowDirectionPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents arrowStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.plotTimer = New System.Windows.Forms.Timer(Me.components)
        Me.realPlot = New NationalInstruments.UI.WaveformPlot
        Me.realXAxis = New NationalInstruments.UI.XAxis
        Me.realYAxis = New NationalInstruments.UI.YAxis
        Me.realGroupBox = New System.Windows.Forms.GroupBox
        Me.realFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.realPhaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.realPhaseLabel = New System.Windows.Forms.Label
        Me.realFrequencyLabel = New System.Windows.Forms.Label
        Me.realWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.imaginaryGroupBox = New System.Windows.Forms.GroupBox
        Me.imaginaryPhaseLabel = New System.Windows.Forms.Label
        Me.imaginaryWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.imaginaryPlot = New NationalInstruments.UI.WaveformPlot
        Me.imaginaryXAxis = New NationalInstruments.UI.XAxis
        Me.imaginaryYAxis = New NationalInstruments.UI.YAxis
        Me.imaginaryFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.imaginaryPhaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.imaginaryFrequencyLabel = New System.Windows.Forms.Label
        Me.sampleComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.complexPlot = New NationalInstruments.UI.ComplexPlot
        Me.complexXAxis = New NationalInstruments.UI.ComplexXAxis
        Me.complexYAxis = New NationalInstruments.UI.ComplexYAxis
        Me.plotArrowsGroupBox = New System.Windows.Forms.GroupBox
        Me.arrowDirectionLabel = New System.Windows.Forms.Label
        Me.arrowStyleLabel = New System.Windows.Forms.Label
        Me.arrowDirectionPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.arrowStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.realGroupBox.SuspendLayout()
        CType(Me.realFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.realPhaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.realWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.imaginaryGroupBox.SuspendLayout()
        CType(Me.imaginaryWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imaginaryFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imaginaryPhaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotArrowsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'plotTimer
        '
        Me.plotTimer.Enabled = True
        '
        'realPlot
        '
        Me.realPlot.XAxis = Me.realXAxis
        Me.realPlot.YAxis = Me.realYAxis
        '
        'realXAxis
        '
        Me.realXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart
        Me.realXAxis.Range = New NationalInstruments.UI.Range(0, 100)
        '
        'realGroupBox
        '
        Me.realGroupBox.Controls.Add(Me.realFrequencyNumericEdit)
        Me.realGroupBox.Controls.Add(Me.realPhaseNumericEdit)
        Me.realGroupBox.Controls.Add(Me.realPhaseLabel)
        Me.realGroupBox.Controls.Add(Me.realFrequencyLabel)
        Me.realGroupBox.Controls.Add(Me.realWaveformGraph)
        Me.realGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.realGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.realGroupBox.Name = "realGroupBox"
        Me.realGroupBox.Size = New System.Drawing.Size(376, 160)
        Me.realGroupBox.TabIndex = 1
        Me.realGroupBox.TabStop = False
        Me.realGroupBox.Text = "Real Data"
        '
        'realFrequencyNumericEdit
        '
        Me.realFrequencyNumericEdit.Location = New System.Drawing.Point(96, 64)
        Me.realFrequencyNumericEdit.Name = "realFrequencyNumericEdit"
        Me.realFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.realFrequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.realFrequencyNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.realFrequencyNumericEdit.TabIndex = 1
        Me.realFrequencyNumericEdit.Value = 10
        '
        'realPhaseNumericEdit
        '
        Me.realPhaseNumericEdit.CoercionInterval = 0.1
        Me.realPhaseNumericEdit.Location = New System.Drawing.Point(96, 32)
        Me.realPhaseNumericEdit.Name = "realPhaseNumericEdit"
        Me.realPhaseNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.realPhaseNumericEdit.TabIndex = 0
        '
        'realPhaseLabel
        '
        Me.realPhaseLabel.Location = New System.Drawing.Point(8, 32)
        Me.realPhaseLabel.Name = "realPhaseLabel"
        Me.realPhaseLabel.Size = New System.Drawing.Size(88, 16)
        Me.realPhaseLabel.TabIndex = 3
        Me.realPhaseLabel.Text = "Phase (Rad):"
        '
        'realFrequencyLabel
        '
        Me.realFrequencyLabel.Location = New System.Drawing.Point(8, 64)
        Me.realFrequencyLabel.Name = "realFrequencyLabel"
        Me.realFrequencyLabel.Size = New System.Drawing.Size(88, 16)
        Me.realFrequencyLabel.TabIndex = 4
        Me.realFrequencyLabel.Text = "Frequency (Hz):"
        '
        'realWaveformGraph
        '
        Me.realWaveformGraph.Location = New System.Drawing.Point(176, 24)
        Me.realWaveformGraph.Name = "realWaveformGraph"
        Me.realWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.realPlot})
        Me.realWaveformGraph.Size = New System.Drawing.Size(192, 120)
        Me.realWaveformGraph.TabIndex = 2
        Me.realWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.realXAxis})
        Me.realWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.realYAxis})
        '
        'imaginaryGroupBox
        '
        Me.imaginaryGroupBox.Controls.Add(Me.imaginaryPhaseLabel)
        Me.imaginaryGroupBox.Controls.Add(Me.imaginaryWaveformGraph)
        Me.imaginaryGroupBox.Controls.Add(Me.imaginaryFrequencyNumericEdit)
        Me.imaginaryGroupBox.Controls.Add(Me.imaginaryPhaseNumericEdit)
        Me.imaginaryGroupBox.Controls.Add(Me.imaginaryFrequencyLabel)
        Me.imaginaryGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.imaginaryGroupBox.Location = New System.Drawing.Point(8, 168)
        Me.imaginaryGroupBox.Name = "imaginaryGroupBox"
        Me.imaginaryGroupBox.Size = New System.Drawing.Size(376, 160)
        Me.imaginaryGroupBox.TabIndex = 2
        Me.imaginaryGroupBox.TabStop = False
        Me.imaginaryGroupBox.Text = "Imaginary Data"
        '
        'imaginaryPhaseLabel
        '
        Me.imaginaryPhaseLabel.Location = New System.Drawing.Point(8, 32)
        Me.imaginaryPhaseLabel.Name = "imaginaryPhaseLabel"
        Me.imaginaryPhaseLabel.Size = New System.Drawing.Size(88, 16)
        Me.imaginaryPhaseLabel.TabIndex = 3
        Me.imaginaryPhaseLabel.Text = "Phase (Rad):"
        '
        'imaginaryWaveformGraph
        '
        Me.imaginaryWaveformGraph.Location = New System.Drawing.Point(176, 24)
        Me.imaginaryWaveformGraph.Name = "imaginaryWaveformGraph"
        Me.imaginaryWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.imaginaryPlot})
        Me.imaginaryWaveformGraph.Size = New System.Drawing.Size(192, 120)
        Me.imaginaryWaveformGraph.TabIndex = 2
        Me.imaginaryWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.imaginaryXAxis})
        Me.imaginaryWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.imaginaryYAxis})
        '
        'imaginaryPlot
        '
        Me.imaginaryPlot.XAxis = Me.imaginaryXAxis
        Me.imaginaryPlot.YAxis = Me.imaginaryYAxis
        '
        'imaginaryXAxis
        '
        Me.imaginaryXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart
        Me.imaginaryXAxis.Range = New NationalInstruments.UI.Range(0, 100)
        '
        'imaginaryFrequencyNumericEdit
        '
        Me.imaginaryFrequencyNumericEdit.Location = New System.Drawing.Point(96, 64)
        Me.imaginaryFrequencyNumericEdit.Name = "imaginaryFrequencyNumericEdit"
        Me.imaginaryFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.imaginaryFrequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.imaginaryFrequencyNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.imaginaryFrequencyNumericEdit.TabIndex = 1
        Me.imaginaryFrequencyNumericEdit.Value = 20
        '
        'imaginaryPhaseNumericEdit
        '
        Me.imaginaryPhaseNumericEdit.CoercionInterval = 0.1
        Me.imaginaryPhaseNumericEdit.Location = New System.Drawing.Point(96, 32)
        Me.imaginaryPhaseNumericEdit.Name = "imaginaryPhaseNumericEdit"
        Me.imaginaryPhaseNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.imaginaryPhaseNumericEdit.TabIndex = 0
        '
        'imaginaryFrequencyLabel
        '
        Me.imaginaryFrequencyLabel.Location = New System.Drawing.Point(8, 64)
        Me.imaginaryFrequencyLabel.Name = "imaginaryFrequencyLabel"
        Me.imaginaryFrequencyLabel.Size = New System.Drawing.Size(88, 16)
        Me.imaginaryFrequencyLabel.TabIndex = 4
        Me.imaginaryFrequencyLabel.Text = "Frequency (Hz):"
        '
        'sampleComplexGraph
        '
        Me.sampleComplexGraph.Caption = "2D Complex Graph"
        Me.sampleComplexGraph.Location = New System.Drawing.Point(392, 8)
        Me.sampleComplexGraph.Name = "sampleComplexGraph"
        Me.sampleComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.complexPlot})
        Me.sampleComplexGraph.Size = New System.Drawing.Size(480, 384)
        Me.sampleComplexGraph.TabIndex = 0
        Me.sampleComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.complexXAxis})
        Me.sampleComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.complexYAxis})
        '
        'complexPlot
        '
        Me.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode
        Me.complexPlot.XAxis = Me.complexXAxis
        Me.complexPlot.YAxis = Me.complexYAxis
        '
        'plotArrowsGroupBox
        '
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowDirectionLabel)
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowStyleLabel)
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowDirectionPropertyEditor)
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowStylePropertyEditor)
        Me.plotArrowsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotArrowsGroupBox.Location = New System.Drawing.Point(8, 336)
        Me.plotArrowsGroupBox.Name = "plotArrowsGroupBox"
        Me.plotArrowsGroupBox.Size = New System.Drawing.Size(376, 56)
        Me.plotArrowsGroupBox.TabIndex = 4
        Me.plotArrowsGroupBox.TabStop = False
        Me.plotArrowsGroupBox.Text = "Plot arrows"
        '
        'arrowDirectionLabel
        '
        Me.arrowDirectionLabel.Location = New System.Drawing.Point(208, 23)
        Me.arrowDirectionLabel.Name = "arrowDirectionLabel"
        Me.arrowDirectionLabel.Size = New System.Drawing.Size(80, 17)
        Me.arrowDirectionLabel.TabIndex = 3
        Me.arrowDirectionLabel.Text = "Arrow direction"
        '
        'arrowStyleLabel
        '
        Me.arrowStyleLabel.Location = New System.Drawing.Point(8, 23)
        Me.arrowStyleLabel.Name = "arrowStyleLabel"
        Me.arrowStyleLabel.Size = New System.Drawing.Size(62, 17)
        Me.arrowStyleLabel.TabIndex = 2
        Me.arrowStyleLabel.Text = "Arrow style"
        '
        'arrowDirectionPropertyEditor
        '
        Me.arrowDirectionPropertyEditor.Location = New System.Drawing.Point(288, 21)
        Me.arrowDirectionPropertyEditor.Name = "arrowDirectionPropertyEditor"
        Me.arrowDirectionPropertyEditor.Size = New System.Drawing.Size(80, 20)
        Me.arrowDirectionPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.complexPlot, "ArrowDirection")
        Me.arrowDirectionPropertyEditor.TabIndex = 1
        '
        'arrowStylePropertyEditor
        '
        Me.arrowStylePropertyEditor.Location = New System.Drawing.Point(72, 21)
        Me.arrowStylePropertyEditor.Name = "arrowStylePropertyEditor"
        Me.arrowStylePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.arrowStylePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.complexPlot, "ArrowStyle")
        Me.arrowStylePropertyEditor.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(874, 400)
        Me.Controls.Add(Me.plotArrowsGroupBox)
        Me.Controls.Add(Me.imaginaryGroupBox)
        Me.Controls.Add(Me.sampleComplexGraph)
        Me.Controls.Add(Me.realGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plotting Example"
        Me.realGroupBox.ResumeLayout(False)
        CType(Me.realFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.realPhaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.realWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.imaginaryGroupBox.ResumeLayout(False)
        CType(Me.imaginaryWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imaginaryFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imaginaryPhaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotArrowsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs)
        PlotData()
    End Sub

    Private Sub plotTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotTimer.Tick
        PlotDataAppend()
    End Sub


    Private Shared Function GenerateSineWave(ByVal numberOfSamples As Integer, ByVal amplitude As Double, ByVal frequency As Double, ByVal samplingRate As Double, ByVal phase As Double, ByRef initialPoint As Integer) As Double()
        If numberOfSamples < 0 Then
            Throw New ArgumentOutOfRangeException("xRange")
        End If

        If amplitude < 0 Then
            Throw New ArgumentOutOfRangeException("yRange")
        End If

        Dim f As Double = (2 * Math.PI * frequency) / samplingRate

        Dim data() As Double = New Double(numberOfSamples - 1) {}
        Dim i As Integer

        For i = 0 To numberOfSamples - 1
            data(i) = amplitude * Math.Sin((f * (i + initialPoint) + phase))
        Next i
        initialPoint = initialPoint + numberOfSamples

        Return data
    End Function


    Private Shared Function GenerateComplexData(ByVal realData() As Double, ByVal imaginaryData() As Double) As ComplexDouble()
        Dim numberOfSamples As Integer
        If realData.Length < imaginaryData.Length Then
            numberOfSamples = realData.Length
        Else
            numberOfSamples = imaginaryData.Length
        End If

        Dim data() As ComplexDouble = New ComplexDouble(numberOfSamples - 1) {}

        Dim i As Integer
        For i = 0 To numberOfSamples - 1
            data(i) = New ComplexDouble(realData(i), imaginaryData(i))
        Next i

        Return data
    End Function

    Private Sub PlotData()
        Dim numberOfSamples As Integer = 100
        Dim initialPoint As Integer = 0

        realWaveformGraph.ClearData()
        realXAxis.Range = New Range(0, 100)
        Dim realData As Double() = GenerateSineWave(numberOfSamples, 1, realFrequencyNumericEdit.Value, 1000, realPhaseNumericEdit.Value, initialPoint)
        realWaveformGraph.PlotY(realData)

        imaginaryWaveformGraph.ClearData()
        imaginaryXAxis.Range = New Range(0, 100)
        initialPoint = 0
        Dim imaginaryData As Double() = GenerateSineWave(numberOfSamples, 1, imaginaryFrequencyNumericEdit.Value, 1000, imaginaryPhaseNumericEdit.Value, initialPoint)
        imaginaryWaveformGraph.PlotY(imaginaryData)

        sampleComplexGraph.ClearData()
        complexXAxis.Range = New Range(0, 100)
        Dim data As ComplexDouble() = GenerateComplexData(realData, imaginaryData)
        sampleComplexGraph.PlotComplex(data)

        lastPoint = initialPoint
    End Sub

    Private Sub PlotDataAppend()
        Dim numberOfSamples As Int32 = 1
        Dim initialPoint As Int32 = lastPoint

        Dim realData As Double() = GenerateSineWave(numberOfSamples, 1, realFrequencyNumericEdit.Value, 1000, realPhaseNumericEdit.Value, initialPoint)
        realWaveformGraph.PlotYAppend(realData)

        initialPoint = lastPoint
        Dim imaginaryData As Double() = GenerateSineWave(numberOfSamples, 1, imaginaryFrequencyNumericEdit.Value, 1000, imaginaryPhaseNumericEdit.Value, initialPoint)
        imaginaryWaveformGraph.PlotYAppend(imaginaryData)

        Dim data As ComplexDouble() = GenerateComplexData(realData, imaginaryData)
        sampleComplexGraph.PlotComplexAppend(data)

        lastPoint = initialPoint
    End Sub
End Class
