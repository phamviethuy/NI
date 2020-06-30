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
    Friend WithEvents signalPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents samplesAxis As NationalInstruments.UI.XAxis
    Friend WithEvents amplitudeAxis As NationalInstruments.UI.YAxis
    Friend WithEvents signalParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents amplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents frequencyLabel As System.Windows.Forms.Label
    Friend WithEvents samplesLabel As System.Windows.Forms.Label
    Friend WithEvents offsetLabel As System.Windows.Forms.Label
    Friend WithEvents samplingRateLabel As System.Windows.Forms.Label
    Friend WithEvents signalTypeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents squareRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents samplingRateNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents offsetNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents samplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents frequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents amplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sawtoothRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents triangleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents sineRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents signalWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.signalWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.signalPlot = New NationalInstruments.UI.WaveformPlot
        Me.samplesAxis = New NationalInstruments.UI.XAxis
        Me.amplitudeAxis = New NationalInstruments.UI.YAxis
        Me.signalParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.samplingRateNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.offsetNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.samplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.frequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amplitudeLabel = New System.Windows.Forms.Label
        Me.frequencyLabel = New System.Windows.Forms.Label
        Me.samplesLabel = New System.Windows.Forms.Label
        Me.offsetLabel = New System.Windows.Forms.Label
        Me.samplingRateLabel = New System.Windows.Forms.Label
        Me.signalTypeGroupBox = New System.Windows.Forms.GroupBox
        Me.sawtoothRadioButton = New System.Windows.Forms.RadioButton
        Me.squareRadioButton = New System.Windows.Forms.RadioButton
        Me.triangleRadioButton = New System.Windows.Forms.RadioButton
        Me.sineRadioButton = New System.Windows.Forms.RadioButton
        Me.generateButton = New System.Windows.Forms.Button
        CType(Me.signalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.signalParametersGroupBox.SuspendLayout()
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.offsetNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.signalTypeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'signalWaveformGraph
        '
        Me.signalWaveformGraph.Caption = "Generated Signal"
        Me.signalWaveformGraph.Location = New System.Drawing.Point(8, 8)
        Me.signalWaveformGraph.Name = "signalWaveformGraph"
        Me.signalWaveformGraph.UseColorGenerator = True
        Me.signalWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.signalPlot})
        Me.signalWaveformGraph.Size = New System.Drawing.Size(320, 272)
        Me.signalWaveformGraph.TabIndex = 22
        Me.signalWaveformGraph.TabStop = False
        Me.signalWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.samplesAxis})
        Me.signalWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.amplitudeAxis})
        '
        'signalPlot
        '
        Me.signalPlot.XAxis = Me.samplesAxis
        Me.signalPlot.YAxis = Me.amplitudeAxis
        '
        'samplesAxis
        '
        Me.samplesAxis.Caption = "Number Of Samples"
        '
        'amplitudeAxis
        '
        Me.amplitudeAxis.Caption = "Amplitude"
        '
        'signalParametersGroupBox
        '
        Me.signalParametersGroupBox.Controls.Add(Me.samplingRateNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.offsetNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.samplesNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.frequencyNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.amplitudeNumericEdit)
        Me.signalParametersGroupBox.Controls.Add(Me.amplitudeLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.frequencyLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.samplesLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.offsetLabel)
        Me.signalParametersGroupBox.Controls.Add(Me.samplingRateLabel)
        Me.signalParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalParametersGroupBox.Location = New System.Drawing.Point(120, 296)
        Me.signalParametersGroupBox.Name = "signalParametersGroupBox"
        Me.signalParametersGroupBox.Size = New System.Drawing.Size(210, 192)
        Me.signalParametersGroupBox.TabIndex = 20
        Me.signalParametersGroupBox.TabStop = False
        Me.signalParametersGroupBox.Text = "Signal Parameters"
        '
        'samplingRateNumericEdit
        '
        Me.samplingRateNumericEdit.Location = New System.Drawing.Point(112, 160)
        Me.samplingRateNumericEdit.Name = "samplingRateNumericEdit"
        Me.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplingRateNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.samplingRateNumericEdit.Size = New System.Drawing.Size(88, 20)
        Me.samplingRateNumericEdit.TabIndex = 4
        Me.samplingRateNumericEdit.Value = 100
        '
        'offsetNumericEdit
        '
        Me.offsetNumericEdit.Location = New System.Drawing.Point(112, 126)
        Me.offsetNumericEdit.Name = "offsetNumericEdit"
        Me.offsetNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.offsetNumericEdit.Size = New System.Drawing.Size(88, 20)
        Me.offsetNumericEdit.TabIndex = 3
        '
        'samplesNumericEdit
        '
        Me.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.samplesNumericEdit.Location = New System.Drawing.Point(112, 92)
        Me.samplesNumericEdit.Name = "samplesNumericEdit"
        Me.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplesNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.samplesNumericEdit.Size = New System.Drawing.Size(88, 20)
        Me.samplesNumericEdit.TabIndex = 2
        Me.samplesNumericEdit.Value = 100
        '
        'frequencyNumericEdit
        '
        Me.frequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.frequencyNumericEdit.Location = New System.Drawing.Point(112, 58)
        Me.frequencyNumericEdit.Name = "frequencyNumericEdit"
        Me.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.frequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.frequencyNumericEdit.Size = New System.Drawing.Size(88, 20)
        Me.frequencyNumericEdit.TabIndex = 1
        Me.frequencyNumericEdit.Value = 2
        '
        'amplitudeNumericEdit
        '
        Me.amplitudeNumericEdit.Location = New System.Drawing.Point(112, 24)
        Me.amplitudeNumericEdit.Name = "amplitudeNumericEdit"
        Me.amplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.amplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.amplitudeNumericEdit.Size = New System.Drawing.Size(88, 20)
        Me.amplitudeNumericEdit.TabIndex = 0
        Me.amplitudeNumericEdit.Value = 5
        '
        'amplitudeLabel
        '
        Me.amplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amplitudeLabel.Location = New System.Drawing.Point(16, 26)
        Me.amplitudeLabel.Name = "amplitudeLabel"
        Me.amplitudeLabel.Size = New System.Drawing.Size(72, 16)
        Me.amplitudeLabel.TabIndex = 7
        Me.amplitudeLabel.Text = "Amplitude:"
        '
        'frequencyLabel
        '
        Me.frequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.frequencyLabel.Location = New System.Drawing.Point(16, 61)
        Me.frequencyLabel.Name = "frequencyLabel"
        Me.frequencyLabel.Size = New System.Drawing.Size(88, 14)
        Me.frequencyLabel.TabIndex = 9
        Me.frequencyLabel.Text = "Frequency:"
        '
        'samplesLabel
        '
        Me.samplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplesLabel.Location = New System.Drawing.Point(16, 96)
        Me.samplesLabel.Name = "samplesLabel"
        Me.samplesLabel.Size = New System.Drawing.Size(88, 12)
        Me.samplesLabel.TabIndex = 11
        Me.samplesLabel.Text = "Samples:"
        '
        'offsetLabel
        '
        Me.offsetLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.offsetLabel.Location = New System.Drawing.Point(16, 128)
        Me.offsetLabel.Name = "offsetLabel"
        Me.offsetLabel.Size = New System.Drawing.Size(48, 17)
        Me.offsetLabel.TabIndex = 13
        Me.offsetLabel.Text = "Offset:"
        '
        'samplingRateLabel
        '
        Me.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplingRateLabel.Location = New System.Drawing.Point(16, 162)
        Me.samplingRateLabel.Name = "samplingRateLabel"
        Me.samplingRateLabel.Size = New System.Drawing.Size(88, 17)
        Me.samplingRateLabel.TabIndex = 15
        Me.samplingRateLabel.Text = "Sampling Rate:"
        '
        'signalTypeGroupBox
        '
        Me.signalTypeGroupBox.Controls.Add(Me.sawtoothRadioButton)
        Me.signalTypeGroupBox.Controls.Add(Me.squareRadioButton)
        Me.signalTypeGroupBox.Controls.Add(Me.triangleRadioButton)
        Me.signalTypeGroupBox.Controls.Add(Me.sineRadioButton)
        Me.signalTypeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalTypeGroupBox.Location = New System.Drawing.Point(8, 296)
        Me.signalTypeGroupBox.Name = "signalTypeGroupBox"
        Me.signalTypeGroupBox.Size = New System.Drawing.Size(104, 152)
        Me.signalTypeGroupBox.TabIndex = 21
        Me.signalTypeGroupBox.TabStop = False
        Me.signalTypeGroupBox.Text = "Signal Type"
        '
        'sawtoothRadioButton
        '
        Me.sawtoothRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.sawtoothRadioButton.Location = New System.Drawing.Point(8, 120)
        Me.sawtoothRadioButton.Name = "sawtoothRadioButton"
        Me.sawtoothRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.sawtoothRadioButton.TabIndex = 3
        Me.sawtoothRadioButton.Text = "Sawtooth"
        '
        'squareRadioButton
        '
        Me.squareRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.squareRadioButton.Location = New System.Drawing.Point(8, 88)
        Me.squareRadioButton.Name = "squareRadioButton"
        Me.squareRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.squareRadioButton.TabIndex = 2
        Me.squareRadioButton.Text = "Square"
        '
        'triangleRadioButton
        '
        Me.triangleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.triangleRadioButton.Location = New System.Drawing.Point(8, 56)
        Me.triangleRadioButton.Name = "triangleRadioButton"
        Me.triangleRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.triangleRadioButton.TabIndex = 1
        Me.triangleRadioButton.Text = "Triangle"
        '
        'sineRadioButton
        '
        Me.sineRadioButton.Checked = True
        Me.sineRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.sineRadioButton.Location = New System.Drawing.Point(8, 24)
        Me.sineRadioButton.Name = "sineRadioButton"
        Me.sineRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.sineRadioButton.TabIndex = 0
        Me.sineRadioButton.TabStop = True
        Me.sineRadioButton.Text = "Sine"
        '
        'generateButton
        '
        Me.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.generateButton.Location = New System.Drawing.Point(8, 464)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(104, 23)
        Me.generateButton.TabIndex = 19
        Me.generateButton.Text = "Generate"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(338, 496)
        Me.Controls.Add(Me.signalWaveformGraph)
        Me.Controls.Add(Me.signalParametersGroupBox)
        Me.Controls.Add(Me.signalTypeGroupBox)
        Me.Controls.Add(Me.generateButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic Signal Generation"
        CType(Me.signalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.signalParametersGroupBox.ResumeLayout(False)
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.offsetNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.signalTypeGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Function GetSelectedSignalType() As BasicFunctionGeneratorSignal
        If (sineRadioButton.Checked) Then
            Return BasicFunctionGeneratorSignal.Sine
        ElseIf (triangleRadioButton.Checked) Then
            Return BasicFunctionGeneratorSignal.Triangle
        ElseIf (squareRadioButton.Checked) Then
            Return BasicFunctionGeneratorSignal.Square
        ElseIf (sawtoothRadioButton.Checked) Then
            Return BasicFunctionGeneratorSignal.Sawtooth
        Else
            Return BasicFunctionGeneratorSignal.Sine
        End If
    End Function

    Private Sub generateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateButton.Click
        Dim functionGenerator As BasicFunctionGenerator _
        = New BasicFunctionGenerator(GetSelectedSignalType())

        functionGenerator.Amplitude = amplitudeNumericEdit.Value
        functionGenerator.Frequency = frequencyNumericEdit.Value
        functionGenerator.NumberOfSamples = samplesNumericEdit.Value
        functionGenerator.Offset = offsetNumericEdit.Value
        functionGenerator.SamplingRate = samplingRateNumericEdit.Value

        signalPlot.PlotY(functionGenerator.Generate())
    End Sub
End Class
