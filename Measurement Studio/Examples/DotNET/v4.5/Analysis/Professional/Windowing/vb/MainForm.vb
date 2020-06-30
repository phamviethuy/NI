Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports NationalInstruments.Analysis.SignalGeneration
Imports NationalInstruments.Analysis.Dsp
Imports NationalInstruments.UI
Imports System.Reflection
Imports NationalInstruments.Analysis.Math

Public Class MainForm
    Inherits System.Windows.Forms.Form
    Public Sub New()
        MyBase.New()

        InitializeComponent()

        AddHandler windowTypesComboBox.SelectedIndexChanged, AddressOf RecalculateSignals
        AddHandler input1AmplitudeNumericEdit.ValueChanged, AddressOf RecalculateSignals
        AddHandler input1AmplitudeNumericEdit.Validated, AddressOf RecalculateSignals
        AddHandler input1FrequencyNumericEdit.ValueChanged, AddressOf RecalculateSignals
        AddHandler input1FrequencyNumericEdit.Validated, AddressOf RecalculateSignals
        AddHandler input2AmplitudeNumericEdit.ValueChanged, AddressOf RecalculateSignals
        AddHandler input2AmplitudeNumericEdit.Validated, AddressOf RecalculateSignals
        AddHandler input2FrequencyNumericEdit.ValueChanged, AddressOf RecalculateSignals
        AddHandler input2FrequencyNumericEdit.Validated, AddressOf RecalculateSignals
        AddHandler linearLogSwitch.ValueChanged, AddressOf RecalculateSignals

        FillComboBoxes()
        RecalculateAndDrawGraphs()


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
#Region " Windows Form Designer generated code "
    Friend WithEvents freqDomainPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents windowedDataPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents scaledWindowTypesLabel As System.Windows.Forms.Label
    Friend WithEvents addTimeDomainPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents windowsPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents dbLabel As System.Windows.Forms.Label
    Friend WithEvents linearLabel As System.Windows.Forms.Label
    Friend WithEvents windowedDataYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents freqDomainXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents freqDomainYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents windowsXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents windowedDataXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents windowsYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents addTimeDomainYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents addTimeDomainXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents signal1AmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents signal1FrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents signal2AmplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents signal2FrequencyLabel As System.Windows.Forms.Label
    Friend WithEvents inputSignal1GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents inputSignal2GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents input1AmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents input1FrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents input2AmplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents input2FrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents windowedDataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents freqDomainWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents addTimeDomainWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents windowsWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents windowTypesComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents linearLogSwitch As NationalInstruments.UI.WindowsForms.Switch
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.windowedDataYAxis = New NationalInstruments.UI.YAxis
        Me.freqDomainPlot = New NationalInstruments.UI.WaveformPlot
        Me.freqDomainXAxis = New NationalInstruments.UI.XAxis
        Me.freqDomainYAxis = New NationalInstruments.UI.YAxis
        Me.windowsXAxis = New NationalInstruments.UI.XAxis
        Me.windowedDataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.windowedDataPlot = New NationalInstruments.UI.WaveformPlot
        Me.windowedDataXAxis = New NationalInstruments.UI.XAxis
        Me.windowsYAxis = New NationalInstruments.UI.YAxis
        Me.scaledWindowTypesLabel = New System.Windows.Forms.Label
        Me.addTimeDomainYAxis = New NationalInstruments.UI.YAxis
        Me.freqDomainWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.addTimeDomainWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.addTimeDomainPlot = New NationalInstruments.UI.WaveformPlot
        Me.addTimeDomainXAxis = New NationalInstruments.UI.XAxis
        Me.windowsPlot = New NationalInstruments.UI.WaveformPlot
        Me.dbLabel = New System.Windows.Forms.Label
        Me.linearLabel = New System.Windows.Forms.Label
        Me.linearLogSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.windowTypesComboBox = New System.Windows.Forms.ComboBox
        Me.windowsWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.inputSignal1GroupBox = New System.Windows.Forms.GroupBox
        Me.input1AmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.signal1AmplitudeLabel = New System.Windows.Forms.Label
        Me.signal1FrequencyLabel = New System.Windows.Forms.Label
        Me.input1FrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.inputSignal2GroupBox = New System.Windows.Forms.GroupBox
        Me.signal2AmplitudeLabel = New System.Windows.Forms.Label
        Me.signal2FrequencyLabel = New System.Windows.Forms.Label
        Me.input2AmplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.input2FrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        CType(Me.windowedDataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.freqDomainWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addTimeDomainWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linearLogSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.windowsWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inputSignal1GroupBox.SuspendLayout()
        CType(Me.input1AmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input1FrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inputSignal2GroupBox.SuspendLayout()
        CType(Me.input2AmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.input2FrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'windowedDataYAxis
        '
        Me.windowedDataYAxis.Caption = "Frequency"
        '
        'freqDomainPlot
        '
        Me.freqDomainPlot.XAxis = Me.freqDomainXAxis
        Me.freqDomainPlot.YAxis = Me.freqDomainYAxis
        '
        'freqDomainXAxis
        '
        Me.freqDomainXAxis.Caption = "Frequency"
        Me.freqDomainXAxis.Range = New NationalInstruments.UI.Range(0, 250)
        '
        'freqDomainYAxis
        '
        Me.freqDomainYAxis.Caption = "Amplitude"
        '
        'windowedDataWaveformGraph
        '
        Me.windowedDataWaveformGraph.Caption = "Windowed Data"
        Me.windowedDataWaveformGraph.Location = New System.Drawing.Point(32, 320)
        Me.windowedDataWaveformGraph.Name = "windowedDataWaveformGraph"
        Me.windowedDataWaveformGraph.UseColorGenerator = True
        Me.windowedDataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.windowedDataPlot})
        Me.windowedDataWaveformGraph.Size = New System.Drawing.Size(304, 136)
        Me.windowedDataWaveformGraph.TabIndex = 33
        Me.windowedDataWaveformGraph.TabStop = False
        Me.windowedDataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.windowedDataXAxis})
        Me.windowedDataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.windowedDataYAxis})
        '
        'windowedDataPlot
        '
        Me.windowedDataPlot.XAxis = Me.windowedDataXAxis
        Me.windowedDataPlot.YAxis = Me.windowedDataYAxis
        '
        'windowedDataXAxis
        '
        Me.windowedDataXAxis.Caption = "Number Of Samples"
        '
        'scaledWindowTypesLabel
        '
        Me.scaledWindowTypesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.scaledWindowTypesLabel.Location = New System.Drawing.Point(32, 122)
        Me.scaledWindowTypesLabel.Name = "scaledWindowTypesLabel"
        Me.scaledWindowTypesLabel.Size = New System.Drawing.Size(120, 16)
        Me.scaledWindowTypesLabel.TabIndex = 32
        Me.scaledWindowTypesLabel.Text = "Scaled Window Types:"
        '
        'addTimeDomainYAxis
        '
        Me.addTimeDomainYAxis.Caption = "Amplitude"
        '
        'freqDomainWaveformGraph
        '
        Me.freqDomainWaveformGraph.Caption = " Frequency Domain"
        Me.freqDomainWaveformGraph.Location = New System.Drawing.Point(368, 240)
        Me.freqDomainWaveformGraph.Name = "freqDomainWaveformGraph"
        Me.freqDomainWaveformGraph.UseColorGenerator = True
        Me.freqDomainWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.freqDomainPlot})
        Me.freqDomainWaveformGraph.Size = New System.Drawing.Size(360, 216)
        Me.freqDomainWaveformGraph.TabIndex = 20
        Me.freqDomainWaveformGraph.TabStop = False
        Me.freqDomainWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.freqDomainXAxis})
        Me.freqDomainWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.freqDomainYAxis})
        '
        'addTimeDomainWaveformGraph
        '
        Me.addTimeDomainWaveformGraph.Caption = "Time Domain (Signal 1 + Signal2)"
        Me.addTimeDomainWaveformGraph.Location = New System.Drawing.Point(368, 6)
        Me.addTimeDomainWaveformGraph.Name = "addTimeDomainWaveformGraph"
        Me.addTimeDomainWaveformGraph.UseColorGenerator = True
        Me.addTimeDomainWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.addTimeDomainPlot})
        Me.addTimeDomainWaveformGraph.Size = New System.Drawing.Size(360, 216)
        Me.addTimeDomainWaveformGraph.TabIndex = 19
        Me.addTimeDomainWaveformGraph.TabStop = False
        Me.addTimeDomainWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.addTimeDomainXAxis})
        Me.addTimeDomainWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.addTimeDomainYAxis})
        '
        'addTimeDomainPlot
        '
        Me.addTimeDomainPlot.XAxis = Me.addTimeDomainXAxis
        Me.addTimeDomainPlot.YAxis = Me.addTimeDomainYAxis
        '
        'addTimeDomainXAxis
        '
        Me.addTimeDomainXAxis.Caption = "Number Of Samples"
        '
        'windowsPlot
        '
        Me.windowsPlot.XAxis = Me.windowsXAxis
        Me.windowsPlot.YAxis = Me.windowsYAxis
        '
        'dbLabel
        '
        Me.dbLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dbLabel.Location = New System.Drawing.Point(504, 470)
        Me.dbLabel.Name = "dbLabel"
        Me.dbLabel.Size = New System.Drawing.Size(21, 16)
        Me.dbLabel.TabIndex = 30
        Me.dbLabel.Text = " dB"
        '
        'linearLabel
        '
        Me.linearLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.linearLabel.Location = New System.Drawing.Point(560, 470)
        Me.linearLabel.Name = "linearLabel"
        Me.linearLabel.Size = New System.Drawing.Size(36, 16)
        Me.linearLabel.TabIndex = 31
        Me.linearLabel.Text = "Linear"
        '
        'linearLogSwitch
        '
        Me.linearLogSwitch.Location = New System.Drawing.Point(512, 458)
        Me.linearLogSwitch.Name = "linearLogSwitch"
        Me.linearLogSwitch.Size = New System.Drawing.Size(56, 40)
        Me.linearLogSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalToggle3D
        Me.linearLogSwitch.TabIndex = 3
        '
        'windowTypesComboBox
        '
        Me.windowTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.windowTypesComboBox.Location = New System.Drawing.Point(152, 120)
        Me.windowTypesComboBox.Name = "windowTypesComboBox"
        Me.windowTypesComboBox.Size = New System.Drawing.Size(136, 21)
        Me.windowTypesComboBox.TabIndex = 2
        '
        'windowsWaveformGraph
        '
        Me.windowsWaveformGraph.Caption = "Window Preview"
        Me.windowsWaveformGraph.Location = New System.Drawing.Point(32, 168)
        Me.windowsWaveformGraph.Name = "windowsWaveformGraph"
        Me.windowsWaveformGraph.UseColorGenerator = True
        Me.windowsWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.windowsPlot})
        Me.windowsWaveformGraph.Size = New System.Drawing.Size(304, 136)
        Me.windowsWaveformGraph.TabIndex = 21
        Me.windowsWaveformGraph.TabStop = False
        Me.windowsWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.windowsXAxis})
        Me.windowsWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.windowsYAxis})
        '
        'inputSignal1GroupBox
        '
        Me.inputSignal1GroupBox.Controls.Add(Me.input1AmplitudeNumericEdit)
        Me.inputSignal1GroupBox.Controls.Add(Me.signal1AmplitudeLabel)
        Me.inputSignal1GroupBox.Controls.Add(Me.signal1FrequencyLabel)
        Me.inputSignal1GroupBox.Controls.Add(Me.input1FrequencyNumericEdit)
        Me.inputSignal1GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.inputSignal1GroupBox.Location = New System.Drawing.Point(24, 8)
        Me.inputSignal1GroupBox.Name = "inputSignal1GroupBox"
        Me.inputSignal1GroupBox.Size = New System.Drawing.Size(152, 96)
        Me.inputSignal1GroupBox.TabIndex = 0
        Me.inputSignal1GroupBox.TabStop = False
        Me.inputSignal1GroupBox.Text = "Input Signal 1"
        '
        'input1AmplitudeNumericEdit
        '
        Me.input1AmplitudeNumericEdit.CoercionInterval = 0.1
        Me.input1AmplitudeNumericEdit.Location = New System.Drawing.Point(72, 24)
        Me.input1AmplitudeNumericEdit.Name = "input1AmplitudeNumericEdit"
        Me.input1AmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.input1AmplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0.1, Double.PositiveInfinity)
        Me.input1AmplitudeNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.input1AmplitudeNumericEdit.TabIndex = 0
        Me.input1AmplitudeNumericEdit.Value = 0.1
        '
        'signal1AmplitudeLabel
        '
        Me.signal1AmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signal1AmplitudeLabel.Location = New System.Drawing.Point(8, 26)
        Me.signal1AmplitudeLabel.Name = "signal1AmplitudeLabel"
        Me.signal1AmplitudeLabel.Size = New System.Drawing.Size(58, 16)
        Me.signal1AmplitudeLabel.TabIndex = 39
        Me.signal1AmplitudeLabel.Text = "Amplitude:"
        '
        'signal1FrequencyLabel
        '
        Me.signal1FrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signal1FrequencyLabel.Location = New System.Drawing.Point(8, 58)
        Me.signal1FrequencyLabel.Name = "signal1FrequencyLabel"
        Me.signal1FrequencyLabel.Size = New System.Drawing.Size(61, 16)
        Me.signal1FrequencyLabel.TabIndex = 40
        Me.signal1FrequencyLabel.Text = "Frequency:"
        '
        'input1FrequencyNumericEdit
        '
        Me.input1FrequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.input1FrequencyNumericEdit.Location = New System.Drawing.Point(72, 56)
        Me.input1FrequencyNumericEdit.Name = "input1FrequencyNumericEdit"
        Me.input1FrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.input1FrequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.input1FrequencyNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.input1FrequencyNumericEdit.TabIndex = 1
        Me.input1FrequencyNumericEdit.Value = 100
        '
        'inputSignal2GroupBox
        '
        Me.inputSignal2GroupBox.Controls.Add(Me.signal2AmplitudeLabel)
        Me.inputSignal2GroupBox.Controls.Add(Me.signal2FrequencyLabel)
        Me.inputSignal2GroupBox.Controls.Add(Me.input2AmplitudeNumericEdit)
        Me.inputSignal2GroupBox.Controls.Add(Me.input2FrequencyNumericEdit)
        Me.inputSignal2GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.inputSignal2GroupBox.Location = New System.Drawing.Point(184, 8)
        Me.inputSignal2GroupBox.Name = "inputSignal2GroupBox"
        Me.inputSignal2GroupBox.Size = New System.Drawing.Size(152, 96)
        Me.inputSignal2GroupBox.TabIndex = 1
        Me.inputSignal2GroupBox.TabStop = False
        Me.inputSignal2GroupBox.Text = "Input Signal 2"
        '
        'signal2AmplitudeLabel
        '
        Me.signal2AmplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signal2AmplitudeLabel.Location = New System.Drawing.Point(4, 26)
        Me.signal2AmplitudeLabel.Name = "signal2AmplitudeLabel"
        Me.signal2AmplitudeLabel.Size = New System.Drawing.Size(58, 16)
        Me.signal2AmplitudeLabel.TabIndex = 40
        Me.signal2AmplitudeLabel.Text = "Amplitude:"
        '
        'signal2FrequencyLabel
        '
        Me.signal2FrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signal2FrequencyLabel.Location = New System.Drawing.Point(4, 58)
        Me.signal2FrequencyLabel.Name = "signal2FrequencyLabel"
        Me.signal2FrequencyLabel.Size = New System.Drawing.Size(61, 16)
        Me.signal2FrequencyLabel.TabIndex = 39
        Me.signal2FrequencyLabel.Text = "Frequency:"
        '
        'input2AmplitudeNumericEdit
        '
        Me.input2AmplitudeNumericEdit.Location = New System.Drawing.Point(68, 24)
        Me.input2AmplitudeNumericEdit.Name = "input2AmplitudeNumericEdit"
        Me.input2AmplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.input2AmplitudeNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.input2AmplitudeNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.input2AmplitudeNumericEdit.TabIndex = 0
        Me.input2AmplitudeNumericEdit.Value = 100
        '
        'input2FrequencyNumericEdit
        '
        Me.input2FrequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.input2FrequencyNumericEdit.Location = New System.Drawing.Point(68, 56)
        Me.input2FrequencyNumericEdit.Name = "input2FrequencyNumericEdit"
        Me.input2FrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.input2FrequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.input2FrequencyNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.input2FrequencyNumericEdit.TabIndex = 1
        Me.input2FrequencyNumericEdit.Value = 25
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(770, 512)
        Me.Controls.Add(Me.inputSignal2GroupBox)
        Me.Controls.Add(Me.inputSignal1GroupBox)
        Me.Controls.Add(Me.dbLabel)
        Me.Controls.Add(Me.linearLabel)
        Me.Controls.Add(Me.windowedDataWaveformGraph)
        Me.Controls.Add(Me.scaledWindowTypesLabel)
        Me.Controls.Add(Me.freqDomainWaveformGraph)
        Me.Controls.Add(Me.addTimeDomainWaveformGraph)
        Me.Controls.Add(Me.linearLogSwitch)
        Me.Controls.Add(Me.windowTypesComboBox)
        Me.Controls.Add(Me.windowsWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(744, 536)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Windowing"
        CType(Me.windowedDataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.freqDomainWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addTimeDomainWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linearLogSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.windowsWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inputSignal1GroupBox.ResumeLayout(False)
        CType(Me.input1AmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input1FrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inputSignal2GroupBox.ResumeLayout(False)
        CType(Me.input2AmplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.input2FrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub 'Main

    Private Sub FillComboBoxes()
        Dim name As String
        For Each name In [Enum].GetNames(GetType(ScaledWindowType))
            windowTypesComboBox.Items.Add(name)
        Next name
        windowTypesComboBox.SelectedIndex = 0
    End Sub 'FillComboBoxes


    Private Sub RecalculateAndDrawGraphs()
        Dim addedSignals(500) As Double
        Dim temp() As Double = New [Double](500) {}
        Dim halfValues() As Double = New [Double](250) {}
        Dim generator As New SignalGenerator(500, 500)
        Dim signal1 As New SineSignal(CDbl(input1FrequencyNumericEdit.Value), CDbl(input1AmplitudeNumericEdit.Value))
        Dim signal2 As New SineSignal(CDbl(input2FrequencyNumericEdit.Value), CDbl(input2AmplitudeNumericEdit.Value))

        Dim scaledWindow As ScaledWindow = GetSelectedWindow()
        generator.Signals.Add(signal1)
        generator.Signals.Add(signal2)
        addedSignals = generator.Generate()

        addTimeDomainWaveformGraph.PlotY(addedSignals)

        temp = ArrayOperation.LinearEvaluation1D(temp, 0, 1)

        scaledWindow.Apply(temp)
        windowsWaveformGraph.PlotY(temp)

        scaledWindow.Apply(addedSignals)
        windowedDataWaveformGraph.PlotY(addedSignals)

        Transforms.PowerSpectrum(addedSignals)

        Dim x As Integer
        For x = 0 To 250
            halfValues(x) = addedSignals(x)

            If Not linearLogSwitch.Value Then
                halfValues(x) = 20 * Math.Log10(halfValues(x)) 'user chose dB
            End If
        Next x
        freqDomainWaveformGraph.PlotY(halfValues)
    End Sub 'RecalculateAndDrawGraphs
    Private Function GetSelectedWindowType() As ScaledWindowType
        Dim x As Integer
        Dim item As String = windowTypesComboBox.SelectedItem '
        If item Is Nothing Then
            Return ScaledWindowType.Rectangular
        End If
        For x = 0 To windowTypesComboBox.Items.Count - 1
            If item = [Enum].GetNames(GetType(ScaledWindowType))(x) Then
                Return CType(CType([Enum].GetValues(GetType(ScaledWindowType)), Integer())(x), ScaledWindowType)
            End If
        Next x
        Return ScaledWindowType.Rectangular
    End Function 'GetSelectedWindowType
    Private Function GetSelectedWindow() As ScaledWindow

        Dim scaledWindowSelected As ScaledWindowType = GetSelectedWindowType()
        Select Case scaledWindowSelected
            Case ScaledWindowType.Blackman
                Return ScaledWindow.CreateBlackmanWindow()
            Case ScaledWindowType.BlackmanHarris
                Return ScaledWindow.CreateBlackmanHarrisWindow()
            Case ScaledWindowType.BlackmanHarris4Term
                Return ScaledWindow.CreateBlackmanHarris4TermWindow()
            Case ScaledWindowType.BlackmanHarris7Term
                Return ScaledWindow.CreateBlackmanHarris7TermWindow()
            Case ScaledWindowType.BlackmanNuttall
                Return ScaledWindow.CreateBlackmanNuttallWindow()
            Case ScaledWindowType.DolphChebyshev
                Return ScaledWindow.CreateDolphChebyshevWindow()
            Case ScaledWindowType.ExactBlackman
                Return ScaledWindow.CreateExactBlackmanWindow()
            Case ScaledWindowType.FlatTop
                Return ScaledWindow.CreateFlatTopWindow()
            Case ScaledWindowType.Gaussian
                Return ScaledWindow.CreateGaussianWindow()
            Case ScaledWindowType.Hamming
                Return ScaledWindow.CreateHammingWindow()
            Case ScaledWindowType.Hanning
                Return ScaledWindow.CreateHanningWindow()
            Case ScaledWindowType.Kaiser
                Return ScaledWindow.CreateKaiserWindow()
            Case ScaledWindowType.LowSidelobe
                Return ScaledWindow.CreateLowSideLobeWindow()
            Case ScaledWindowType.Rectangular
                Return ScaledWindow.CreateRectangularWindow()
            Case ScaledWindowType.Triangle
                Return ScaledWindow.CreateTriangleWindow()
            Case Else
                Return ScaledWindow.CreateHanningWindow()
        End Select
    End Function
    Private Sub RecalculateSignals(ByVal sender As Object, ByVal e As EventArgs)
        RecalculateAndDrawGraphs()
    End Sub 'RecalculateSignals

End Class
