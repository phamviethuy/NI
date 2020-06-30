Imports NationalInstruments.Analysis.SignalGeneration
Imports NationalInstruments.Analysis.Dsp.Filters
Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

        'Setting the range supported by the .NET Analysis Library
        Dim range As NationalInstruments.UI.Range = New NationalInstruments.UI.Range(1, Int32.MaxValue)
        numberOfSamplesNumericEdit.Range = range
        filterOrderNumericEdit.Range = range

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
    Friend WithEvents orignalPulseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents samplesLabel As System.Windows.Forms.Label
    Friend WithEvents additiveNoiseLabel As System.Windows.Forms.Label
    Friend WithEvents filterOrderLabel As System.Windows.Forms.Label
    Friend WithEvents goButton As System.Windows.Forms.Button
    Friend WithEvents sentSignal As NationalInstruments.UI.WaveformPlot
    Friend WithEvents receivedSignal As NationalInstruments.UI.WaveformPlot
    Friend WithEvents XAxis As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis As NationalInstruments.UI.YAxis
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents additiveNoiseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents filterOrderNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents orginalAndDetectedPulseWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.orignalPulseGroupBox = New System.Windows.Forms.GroupBox
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.additiveNoiseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.filterOrderNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.samplesLabel = New System.Windows.Forms.Label
        Me.additiveNoiseLabel = New System.Windows.Forms.Label
        Me.filterOrderLabel = New System.Windows.Forms.Label
        Me.goButton = New System.Windows.Forms.Button
        Me.orginalAndDetectedPulseWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.sentSignal = New NationalInstruments.UI.WaveformPlot
        Me.XAxis = New NationalInstruments.UI.XAxis
        Me.YAxis = New NationalInstruments.UI.YAxis
        Me.receivedSignal = New NationalInstruments.UI.WaveformPlot
        Me.orignalPulseGroupBox.SuspendLayout()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.additiveNoiseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.filterOrderNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orginalAndDetectedPulseWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'orignalPulseGroupBox
        '
        Me.orignalPulseGroupBox.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.orignalPulseGroupBox.Controls.Add(Me.additiveNoiseNumericEdit)
        Me.orignalPulseGroupBox.Controls.Add(Me.filterOrderNumericEdit)
        Me.orignalPulseGroupBox.Controls.Add(Me.samplesLabel)
        Me.orignalPulseGroupBox.Controls.Add(Me.additiveNoiseLabel)
        Me.orignalPulseGroupBox.Controls.Add(Me.filterOrderLabel)
        Me.orignalPulseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.orignalPulseGroupBox.Location = New System.Drawing.Point(12, 7)
        Me.orignalPulseGroupBox.Name = "orignalPulseGroupBox"
        Me.orignalPulseGroupBox.Size = New System.Drawing.Size(120, 200)
        Me.orignalPulseGroupBox.TabIndex = 1
        Me.orignalPulseGroupBox.TabStop = False
        Me.orignalPulseGroupBox.Text = "Original Pulse"
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(16, 164)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(68, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 2
        Me.numberOfSamplesNumericEdit.Value = 256
        '
        'additiveNoiseNumericEdit
        '
        Me.additiveNoiseNumericEdit.CoercionInterval = 0.01
        Me.additiveNoiseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.additiveNoiseNumericEdit.Location = New System.Drawing.Point(16, 108)
        Me.additiveNoiseNumericEdit.Name = "additiveNoiseNumericEdit"
        Me.additiveNoiseNumericEdit.Range = New NationalInstruments.UI.Range(0, 1)
        Me.additiveNoiseNumericEdit.Size = New System.Drawing.Size(68, 20)
        Me.additiveNoiseNumericEdit.TabIndex = 1
        Me.additiveNoiseNumericEdit.Value = 0.23
        '
        'filterOrderNumericEdit
        '
        Me.filterOrderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.filterOrderNumericEdit.Location = New System.Drawing.Point(16, 48)
        Me.filterOrderNumericEdit.Name = "filterOrderNumericEdit"
        Me.filterOrderNumericEdit.Size = New System.Drawing.Size(68, 20)
        Me.filterOrderNumericEdit.TabIndex = 0
        Me.filterOrderNumericEdit.Value = 5
        '
        'samplesLabel
        '
        Me.samplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplesLabel.Location = New System.Drawing.Point(16, 148)
        Me.samplesLabel.Name = "samplesLabel"
        Me.samplesLabel.Size = New System.Drawing.Size(60, 16)
        Me.samplesLabel.TabIndex = 5
        Me.samplesLabel.Text = "Samples:"
        '
        'additiveNoiseLabel
        '
        Me.additiveNoiseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.additiveNoiseLabel.Location = New System.Drawing.Point(16, 92)
        Me.additiveNoiseLabel.Name = "additiveNoiseLabel"
        Me.additiveNoiseLabel.Size = New System.Drawing.Size(88, 16)
        Me.additiveNoiseLabel.TabIndex = 4
        Me.additiveNoiseLabel.Text = "Additive Noise:"
        '
        'filterOrderLabel
        '
        Me.filterOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterOrderLabel.Location = New System.Drawing.Point(16, 32)
        Me.filterOrderLabel.Name = "filterOrderLabel"
        Me.filterOrderLabel.Size = New System.Drawing.Size(72, 16)
        Me.filterOrderLabel.TabIndex = 3
        Me.filterOrderLabel.Text = "Filter Order:"
        '
        'goButton
        '
        Me.goButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.goButton.Location = New System.Drawing.Point(12, 219)
        Me.goButton.Name = "goButton"
        Me.goButton.Size = New System.Drawing.Size(120, 28)
        Me.goButton.TabIndex = 0
        Me.goButton.Text = "Go"
        '
        'orginalAndDetectedPulseWaveformGraph
        '
        Me.orginalAndDetectedPulseWaveformGraph.Caption = "Original and Detected Pulse"
        Me.orginalAndDetectedPulseWaveformGraph.Dock = System.Windows.Forms.DockStyle.Right
        Me.orginalAndDetectedPulseWaveformGraph.Location = New System.Drawing.Point(148, 0)
        Me.orginalAndDetectedPulseWaveformGraph.Name = "orginalAndDetectedPulseWaveformGraph"
		Me.orginalAndDetectedPulseWaveformGraph.UseColorGenerator = True
        Me.orginalAndDetectedPulseWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.sentSignal, Me.receivedSignal})
        Me.orginalAndDetectedPulseWaveformGraph.Size = New System.Drawing.Size(364, 255)
        Me.orginalAndDetectedPulseWaveformGraph.TabIndex = 8
        Me.orginalAndDetectedPulseWaveformGraph.TabStop = False
        Me.orginalAndDetectedPulseWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis})
        Me.orginalAndDetectedPulseWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis})
        '
        'sentSignal
        '
        Me.sentSignal.XAxis = Me.XAxis
        Me.sentSignal.YAxis = Me.YAxis
        '
        'receivedSignal
        '
        Me.receivedSignal.XAxis = Me.XAxis
        Me.receivedSignal.YAxis = Me.YAxis
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(512, 255)
        Me.Controls.Add(Me.orginalAndDetectedPulseWaveformGraph)
        Me.Controls.Add(Me.goButton)
        Me.Controls.Add(Me.orignalPulseGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transmitter"
        Me.orignalPulseGroupBox.ResumeLayout(False)
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.additiveNoiseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.filterOrderNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orginalAndDetectedPulseWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Function Transmitter(ByVal numSamples As Integer) As Double()
        Dim data As Double() = PatternGeneration.Pulse(numSamples, 1, 64, 128)
        sentSignal.PlotY(data)
        Dim sine As SineSignal = New SineSignal(numSamples / 4, 1.0)
        Dim sineWave As Double() = sine.Generate(numSamples, numSamples)

        For x As Integer = 0 To data.Length - 1
            data(x) *= sineWave(x)
        Next

        Return data
    End Function

    Private Function Receiver(ByVal numSamples As Integer, ByVal pulsePattern As Double()) As Double()
        Dim output(numSamples) As Double

        Dim sine As SineSignal = New SineSignal(numSamples / 4, 2)
        Dim sineWave As Double() = sine.Generate(numSamples, numSamples)

        For x As Integer = 0 To pulsePattern.Length - 1
            output(x) = pulsePattern(x) * sineWave(x)
        Next

        Return output
    End Function


    Private Sub ButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles goButton.Click

        Dim pulsePattern As Double() = Transmitter(numberOfSamplesNumericEdit.Value)
        Dim noise As WhiteNoiseSignal = New WhiteNoiseSignal(additiveNoiseNumericEdit.Value, 0)
        Dim noiseSignal As Double() = noise.Generate(numberOfSamplesNumericEdit.Value, numberOfSamplesNumericEdit.Value)

        For x As Integer = 0 To pulsePattern.Length - 1
            pulsePattern(x) += noiseSignal(x)
        Next

        Dim output As Double() = Receiver(numberOfSamplesNumericEdit.Value, pulsePattern)

        Dim filter As IirFilterBase = New BesselLowpassFilter(filterOrderNumericEdit.Value, 1, 0.125)
        Dim filterData As Double() = filter.FilterData(output)

        receivedSignal.PlotY(filterData)
    End Sub

End Class
