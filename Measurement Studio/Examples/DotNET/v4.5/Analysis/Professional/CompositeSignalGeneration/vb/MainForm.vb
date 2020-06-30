'==================================================================================================
'
' Title      : MainForm.vb
' Purpose    : This program demonstrates the use of the Analysis SignalGenerator class
'              in forming composite signals.
'
'==================================================================================================

Imports System
Imports NationalInstruments.Analysis.SignalGeneration
Imports NationalInstruments.Analysis

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()


        ' Initialization.
        signalGen = New SignalGenerator(1.0, NumberOfSamples)
        sineSignal1 = New SineSignal()
        sineSignal2 = New SineSignal()
        noiseSignal = New WhiteNoiseSignal()
        signalGen.Signals.Add(sineSignal1)
        signalGen.Signals.Add(sineSignal2)
        signalGen.Signals.Add(noiseSignal)
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

    ' Private variables.
    Const NumberOfSamples As Integer = 10
    Const FrequencyNumber As Double = 50.0

    Dim sineSignal1 As NationalInstruments.Analysis.SignalGeneration.SineSignal
    Dim sineSignal2 As NationalInstruments.Analysis.SignalGeneration.SineSignal
    Dim noiseSignal As NationalInstruments.Analysis.SignalGeneration.WhiteNoiseSignal
    Dim signalGen As NationalInstruments.Analysis.SignalGeneration.SignalGenerator

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents signal2GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents phase2Label As System.Windows.Forms.Label
    Friend WithEvents freq2Label As System.Windows.Forms.Label
    Friend WithEvents amp2Label As System.Windows.Forms.Label
    Friend WithEvents signal1GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents phase1Label As System.Windows.Forms.Label
    Friend WithEvents freq1Label As System.Windows.Forms.Label
    Friend WithEvents amp1Label As System.Windows.Forms.Label
    Friend WithEvents noiseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents amp3Label As System.Windows.Forms.Label
    Friend WithEvents signalPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents offLabel As System.Windows.Forms.Label
    Friend WithEvents onLabel As System.Windows.Forms.Label
    Friend WithEvents onOffSwitch As NationalInstruments.UI.WindowsForms.Switch
    Private WithEvents updateTimer As System.Windows.Forms.Timer
    Friend WithEvents amp2NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents freq2NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents phase2NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents amp1NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents freq1NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents phase1NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents amp3NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents compositeSignalWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.signal2GroupBox = New System.Windows.Forms.GroupBox
        Me.amp2NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.freq2NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.phase2NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.phase2Label = New System.Windows.Forms.Label
        Me.freq2Label = New System.Windows.Forms.Label
        Me.amp2Label = New System.Windows.Forms.Label
        Me.signal1GroupBox = New System.Windows.Forms.GroupBox
        Me.amp1NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.phase1Label = New System.Windows.Forms.Label
        Me.freq1Label = New System.Windows.Forms.Label
        Me.amp1Label = New System.Windows.Forms.Label
        Me.freq1NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.phase1NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.noiseGroupBox = New System.Windows.Forms.GroupBox
        Me.amp3NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amp3Label = New System.Windows.Forms.Label
        Me.compositeSignalWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.signalPlot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.offLabel = New System.Windows.Forms.Label
        Me.onLabel = New System.Windows.Forms.Label
        Me.onOffSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.signal2GroupBox.SuspendLayout()
        CType(Me.amp2NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.freq2NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phase2NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.signal1GroupBox.SuspendLayout()
        CType(Me.amp1NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.freq1NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phase1NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.noiseGroupBox.SuspendLayout()
        CType(Me.amp3NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.compositeSignalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.onOffSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'updateTimer
        '
        Me.updateTimer.Interval = 500
        '
        'signal2GroupBox
        '
        Me.signal2GroupBox.Controls.Add(Me.amp2NumericEdit)
        Me.signal2GroupBox.Controls.Add(Me.freq2NumericEdit)
        Me.signal2GroupBox.Controls.Add(Me.phase2NumericEdit)
        Me.signal2GroupBox.Controls.Add(Me.phase2Label)
        Me.signal2GroupBox.Controls.Add(Me.freq2Label)
        Me.signal2GroupBox.Controls.Add(Me.amp2Label)
        Me.signal2GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signal2GroupBox.Location = New System.Drawing.Point(17, 96)
        Me.signal2GroupBox.Name = "signal2GroupBox"
        Me.signal2GroupBox.Size = New System.Drawing.Size(208, 72)
        Me.signal2GroupBox.TabIndex = 13
        Me.signal2GroupBox.TabStop = False
        Me.signal2GroupBox.Text = "Sine Signal 2"
        '
        'amp2NumericEdit
        '
        Me.amp2NumericEdit.CoercionInterval = 0.5
        Me.amp2NumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.amp2NumericEdit.Name = "amp2NumericEdit"
        Me.amp2NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.amp2NumericEdit.Range = New NationalInstruments.UI.Range(0, 5)
        Me.amp2NumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.amp2NumericEdit.TabIndex = 0
        Me.amp2NumericEdit.Value = 1
        '
        'freq2NumericEdit
        '
        Me.freq2NumericEdit.CoercionInterval = 0.5
        Me.freq2NumericEdit.Location = New System.Drawing.Point(80, 40)
        Me.freq2NumericEdit.Name = "freq2NumericEdit"
        Me.freq2NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.freq2NumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.freq2NumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.freq2NumericEdit.TabIndex = 1
        Me.freq2NumericEdit.Value = 2.5
        '
        'phase2NumericEdit
        '
        Me.phase2NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.phase2NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.phase2NumericEdit.Location = New System.Drawing.Point(144, 40)
        Me.phase2NumericEdit.Name = "phase2NumericEdit"
        Me.phase2NumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.phase2NumericEdit.TabIndex = 2
        Me.phase2NumericEdit.TabStop = False
        '
        'phase2Label
        '
        Me.phase2Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.phase2Label.Location = New System.Drawing.Point(144, 24)
        Me.phase2Label.Name = "phase2Label"
        Me.phase2Label.Size = New System.Drawing.Size(40, 16)
        Me.phase2Label.TabIndex = 9
        Me.phase2Label.Text = "Phase:"
        Me.phase2Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'freq2Label
        '
        Me.freq2Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.freq2Label.Location = New System.Drawing.Point(80, 24)
        Me.freq2Label.Name = "freq2Label"
        Me.freq2Label.Size = New System.Drawing.Size(64, 16)
        Me.freq2Label.TabIndex = 6
        Me.freq2Label.Text = "Frequency:"
        '
        'amp2Label
        '
        Me.amp2Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amp2Label.Location = New System.Drawing.Point(16, 24)
        Me.amp2Label.Name = "amp2Label"
        Me.amp2Label.Size = New System.Drawing.Size(64, 16)
        Me.amp2Label.TabIndex = 2
        Me.amp2Label.Text = "Amplitude:"
        '
        'signal1GroupBox
        '
        Me.signal1GroupBox.Controls.Add(Me.amp1NumericEdit)
        Me.signal1GroupBox.Controls.Add(Me.phase1Label)
        Me.signal1GroupBox.Controls.Add(Me.freq1Label)
        Me.signal1GroupBox.Controls.Add(Me.amp1Label)
        Me.signal1GroupBox.Controls.Add(Me.freq1NumericEdit)
        Me.signal1GroupBox.Controls.Add(Me.phase1NumericEdit)
        Me.signal1GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signal1GroupBox.Location = New System.Drawing.Point(17, 8)
        Me.signal1GroupBox.Name = "signal1GroupBox"
        Me.signal1GroupBox.Size = New System.Drawing.Size(208, 72)
        Me.signal1GroupBox.TabIndex = 12
        Me.signal1GroupBox.TabStop = False
        Me.signal1GroupBox.Text = "Sine Signal 1"
        '
        'amp1NumericEdit
        '
        Me.amp1NumericEdit.CoercionInterval = 0.5
        Me.amp1NumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.amp1NumericEdit.Name = "amp1NumericEdit"
        Me.amp1NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.amp1NumericEdit.Range = New NationalInstruments.UI.Range(0, 5)
        Me.amp1NumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.amp1NumericEdit.TabIndex = 0
        Me.amp1NumericEdit.Value = 3
        '
        'phase1Label
        '
        Me.phase1Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.phase1Label.Location = New System.Drawing.Point(144, 24)
        Me.phase1Label.Name = "phase1Label"
        Me.phase1Label.Size = New System.Drawing.Size(40, 16)
        Me.phase1Label.TabIndex = 6
        Me.phase1Label.Text = "Phase:"
        Me.phase1Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'freq1Label
        '
        Me.freq1Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.freq1Label.Location = New System.Drawing.Point(80, 24)
        Me.freq1Label.Name = "freq1Label"
        Me.freq1Label.Size = New System.Drawing.Size(64, 16)
        Me.freq1Label.TabIndex = 4
        Me.freq1Label.Text = "Frequency:"
        '
        'amp1Label
        '
        Me.amp1Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amp1Label.Location = New System.Drawing.Point(16, 24)
        Me.amp1Label.Name = "amp1Label"
        Me.amp1Label.Size = New System.Drawing.Size(64, 16)
        Me.amp1Label.TabIndex = 2
        Me.amp1Label.Text = "Amplitude:"
        '
        'freq1NumericEdit
        '
        Me.freq1NumericEdit.CoercionInterval = 0.5
        Me.freq1NumericEdit.Location = New System.Drawing.Point(80, 40)
        Me.freq1NumericEdit.Name = "freq1NumericEdit"
        Me.freq1NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.freq1NumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.freq1NumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.freq1NumericEdit.TabIndex = 1
        Me.freq1NumericEdit.Value = 1
        '
        'phase1NumericEdit
        '
        Me.phase1NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.phase1NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.phase1NumericEdit.Location = New System.Drawing.Point(144, 40)
        Me.phase1NumericEdit.Name = "phase1NumericEdit"
        Me.phase1NumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.phase1NumericEdit.TabIndex = 2
        Me.phase1NumericEdit.TabStop = False
        '
        'noiseGroupBox
        '
        Me.noiseGroupBox.Controls.Add(Me.amp3NumericEdit)
        Me.noiseGroupBox.Controls.Add(Me.amp3Label)
        Me.noiseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noiseGroupBox.Location = New System.Drawing.Point(17, 176)
        Me.noiseGroupBox.Name = "noiseGroupBox"
        Me.noiseGroupBox.Size = New System.Drawing.Size(88, 72)
        Me.noiseGroupBox.TabIndex = 14
        Me.noiseGroupBox.TabStop = False
        Me.noiseGroupBox.Text = "White Noise"
        '
        'amp3NumericEdit
        '
        Me.amp3NumericEdit.CoercionInterval = 0.5
        Me.amp3NumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.amp3NumericEdit.Name = "amp3NumericEdit"
        Me.amp3NumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.amp3NumericEdit.Range = New NationalInstruments.UI.Range(0, 5)
        Me.amp3NumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.amp3NumericEdit.TabIndex = 0
        Me.amp3NumericEdit.Value = 1
        '
        'amp3Label
        '
        Me.amp3Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amp3Label.Location = New System.Drawing.Point(16, 24)
        Me.amp3Label.Name = "amp3Label"
        Me.amp3Label.Size = New System.Drawing.Size(64, 16)
        Me.amp3Label.TabIndex = 2
        Me.amp3Label.Text = "Amplitude:"
        '
        'compositeSignalWaveformGraph
        '
        Me.compositeSignalWaveformGraph.Caption = "Composite Signal"
        Me.compositeSignalWaveformGraph.Location = New System.Drawing.Point(233, 8)
        Me.compositeSignalWaveformGraph.Name = "compositeSignalWaveformGraph"
        Me.compositeSignalWaveformGraph.UseColorGenerator = True
        Me.compositeSignalWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.signalPlot})
        Me.compositeSignalWaveformGraph.Size = New System.Drawing.Size(280, 248)
        Me.compositeSignalWaveformGraph.TabIndex = 16
        Me.compositeSignalWaveformGraph.TabStop = False
        Me.compositeSignalWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.compositeSignalWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'signalPlot
        '
        Me.signalPlot.XAxis = Me.xAxis1
        Me.signalPlot.YAxis = Me.yAxis1
        '
        'xAxis1
        '
        Me.xAxis1.Caption = "Number Of Samples"
        '
        'yAxis1
        '
        Me.yAxis1.Caption = "Amplitude"
        '
        'offLabel
        '
        Me.offLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.offLabel.Location = New System.Drawing.Point(189, 240)
        Me.offLabel.Name = "offLabel"
        Me.offLabel.Size = New System.Drawing.Size(32, 16)
        Me.offLabel.TabIndex = 11
        Me.offLabel.Text = "Stop"
        Me.offLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'onLabel
        '
        Me.onLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.onLabel.Location = New System.Drawing.Point(189, 184)
        Me.onLabel.Name = "onLabel"
        Me.onLabel.Size = New System.Drawing.Size(32, 16)
        Me.onLabel.TabIndex = 15
        Me.onLabel.Text = "Start"
        Me.onLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'onOffSwitch
        '
        Me.onOffSwitch.Location = New System.Drawing.Point(185, 192)
        Me.onOffSwitch.Name = "onOffSwitch"
        Me.onOffSwitch.Size = New System.Drawing.Size(40, 48)
        Me.onOffSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.onOffSwitch.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(530, 272)
        Me.Controls.Add(Me.signal1GroupBox)
        Me.Controls.Add(Me.noiseGroupBox)
        Me.Controls.Add(Me.compositeSignalWaveformGraph)
        Me.Controls.Add(Me.offLabel)
        Me.Controls.Add(Me.onLabel)
        Me.Controls.Add(Me.onOffSwitch)
        Me.Controls.Add(Me.signal2GroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Composite Signal Generation "
        Me.signal2GroupBox.ResumeLayout(False)
        CType(Me.amp2NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.freq2NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phase2NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.signal1GroupBox.ResumeLayout(False)
        CType(Me.amp1NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.freq1NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phase1NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.noiseGroupBox.ResumeLayout(False)
        CType(Me.amp3NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.compositeSignalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.onOffSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub amp1Numeric_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amp1NumericEdit.ValueChanged
        If updateTimer.Enabled = True Then
            sineSignal1.Amplitude = amp1NumericEdit.Value

        End If
    End Sub

    Private Sub amp2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amp2NumericEdit.ValueChanged
        If updateTimer.Enabled = True Then
            sineSignal2.Amplitude = amp2NumericEdit.Value
        End If
    End Sub

    Private Sub amp3Numeric_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amp3NumericEdit.ValueChanged
        If updateTimer.Enabled = True Then
            noiseSignal.Amplitude = amp3NumericEdit.Value
        End If
    End Sub

    Private Sub freq1Numeric_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles freq1NumericEdit.ValueChanged
        If updateTimer.Enabled = True Then
            sineSignal1.Frequency = freq1NumericEdit.Value / FrequencyNumber
        End If
    End Sub

    Private Sub freq2Numeric_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles freq2NumericEdit.ValueChanged
        If updateTimer.Enabled = True Then
            sineSignal2.Frequency = freq2NumericEdit.Value / FrequencyNumber
        End If
    End Sub

    Private Sub onOffSwitch_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles onOffSwitch.ValueChanged
        If onOffSwitch.Value = True Then
            ' Start running the program.
            sineSignal1.Amplitude = amp1NumericEdit.Value
            sineSignal1.Frequency = freq1NumericEdit.Value / FrequencyNumber
            sineSignal2.Amplitude = amp2NumericEdit.Value
            sineSignal2.Frequency = freq2NumericEdit.Value / FrequencyNumber
            noiseSignal.Amplitude = amp3NumericEdit.Value

            updateTimer.Enabled = True
            updateTimer.Start()
        Else
            ' Stop running the program.
            updateTimer.Stop()
            updateTimer.Enabled = False
        End If
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateTimer.Tick

        phase1NumericEdit.Value = sineSignal1.Phase
        phase2NumericEdit.Value = sineSignal2.Phase
        ' advance the plot along the X axis
        signalPlot.PlotYAppend(signalGen.Generate())
    End Sub

End Class
