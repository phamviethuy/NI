Imports NationalInstruments.UI


Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private Enum ChartingModes
        Strip
        Scope
    End Enum

    Private data As DataManager

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        AddHandler optionStripChartRadioButton.CheckedChanged, AddressOf OnChartingModeChanged
        AddHandler optionScopeChartRadioButton.CheckedChanged, AddressOf OnChartingModeChanged
        AddHandler optionVerticalCheckBox.CheckedChanged, AddressOf OnOptionVerticalCheckedChanged
        AddHandler timer.Tick, AddressOf OnTimerTick

        data = New DataManager
        SetAxisModes()

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
    Friend WithEvents settingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents optionScopeChartRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents optionStripChartRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents optionVerticalCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents waveformPlot As NationalInstruments.UI.WaveformPlot
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.settingsGroupBox = New System.Windows.Forms.GroupBox
        Me.optionScopeChartRadioButton = New System.Windows.Forms.RadioButton
        Me.optionStripChartRadioButton = New System.Windows.Forms.RadioButton
        Me.optionVerticalCheckBox = New System.Windows.Forms.CheckBox
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.waveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.settingsGroupBox.SuspendLayout()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'settingsGroupBox
        '
        Me.settingsGroupBox.Controls.Add(Me.optionScopeChartRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.optionStripChartRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.optionVerticalCheckBox)
        Me.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.settingsGroupBox.Location = New System.Drawing.Point(16, 288)
        Me.settingsGroupBox.Name = "settingsGroupBox"
        Me.settingsGroupBox.Size = New System.Drawing.Size(296, 120)
        Me.settingsGroupBox.TabIndex = 2
        Me.settingsGroupBox.TabStop = False
        Me.settingsGroupBox.Text = "Chart Settings"
        '
        'optionScopeChartRadioButton
        '
        Me.optionScopeChartRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionScopeChartRadioButton.Location = New System.Drawing.Point(16, 80)
        Me.optionScopeChartRadioButton.Name = "optionScopeChartRadioButton"
        Me.optionScopeChartRadioButton.Size = New System.Drawing.Size(112, 24)
        Me.optionScopeChartRadioButton.TabIndex = 2
        Me.optionScopeChartRadioButton.Text = "Scope Chart"
        '
        'optionStripChartRadioButton
        '
        Me.optionStripChartRadioButton.Checked = True
        Me.optionStripChartRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionStripChartRadioButton.Location = New System.Drawing.Point(16, 32)
        Me.optionStripChartRadioButton.Name = "optionStripChartRadioButton"
        Me.optionStripChartRadioButton.Size = New System.Drawing.Size(112, 32)
        Me.optionStripChartRadioButton.TabIndex = 1
        Me.optionStripChartRadioButton.TabStop = True
        Me.optionStripChartRadioButton.Text = "Strip Chart"
        '
        'optionVerticalCheckBox
        '
        Me.optionVerticalCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionVerticalCheckBox.Location = New System.Drawing.Point(176, 32)
        Me.optionVerticalCheckBox.Name = "optionVerticalCheckBox"
        Me.optionVerticalCheckBox.Size = New System.Drawing.Size(112, 24)
        Me.optionVerticalCheckBox.TabIndex = 0
        Me.optionVerticalCheckBox.Text = "Vertical"
        Me.toolTip.SetToolTip(Me.optionVerticalCheckBox, """Chart vertically""")
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Caption = "2D Waveform Graph"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(16, 16)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(288, 256)
        Me.sampleWaveformGraph.TabIndex = 4
        Me.toolTip.SetToolTip(Me.sampleWaveformGraph, """National Instruments 2D WaveformGraph""")
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'waveformPlot
        '
        Me.waveformPlot.XAxis = Me.xAxis
        Me.waveformPlot.YAxis = Me.yAxis
        '
        'timer
        '
        Me.timer.Enabled = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(330, 424)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Controls.Add(Me.settingsGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Charting Example"
        Me.settingsGroupBox.ResumeLayout(False)
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub OnChartingModeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SetAxisModes()
    End Sub

    Private Sub OnOptionVerticalCheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        sampleWaveformGraph.ClearData()
        data.IsVertical = optionVerticalCheckBox.Checked
        SetAxisModes()
    End Sub

    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim x As Double
        Dim y As Double
        data.GetNextPoint(x, y)
        If optionVerticalCheckBox.Checked Then
            sampleWaveformGraph.PlotXAppend(x)
        Else
            sampleWaveformGraph.PlotYAppend(y)
        End If
    End Sub

    Private Sub SetAxisModes()
        If optionStripChartRadioButton.Checked Then
            SetAxisModes(ChartingModes.Strip)
        ElseIf optionScopeChartRadioButton.Checked Then
            SetAxisModes(ChartingModes.Scope)
        End If
    End Sub

    Private Sub SetAxisModes(ByVal mode As ChartingModes)
        Dim chartingAxis As Axis
        Dim scaleAxis As Axis

        If Not data.IsVertical Then
            chartingAxis = xAxis
            scaleAxis = yAxis
        Else
            chartingAxis = yAxis
            scaleAxis = xAxis
        End If

        scaleAxis.Mode = AxisMode.AutoScaleLoose
        If mode = ChartingModes.Scope Then
            chartingAxis.Mode = AxisMode.ScopeChart
        Else
            chartingAxis.Mode = AxisMode.StripChart
        End If

        sampleWaveformGraph.ClearData()
        data.Reset()
    End Sub

    Private Class DataManager
        Private Const NumberOfPoints As Integer = 100
        Private Const YRange As Integer = 10

        Private data As Double()
        Private index As Integer
        Private currentX As Double
        Private vertical As Boolean

        Public Sub New()
            data = GenerateSineWave(NumberOfPoints, YRange)
            Reset()
        End Sub

        Property IsVertical() As Boolean
            Get
                Return vertical
            End Get

            Set(ByVal Value As Boolean)
                vertical = Value
                Reset()
            End Set
        End Property

        Public Sub Reset()
            index = -1
            currentX = 0
        End Sub

        Public Sub GetNextPoint(ByRef x As Double, ByRef y As Double)
            index += 1
            If index = NumberOfPoints Then
                index = 1
            End If

            If Not vertical Then
                x = currentX
                y = data(index)
            Else
                x = data(index)
                y = currentX
            End If

            currentX += 1
        End Sub

        Private Shared Function GenerateSineWave(ByVal xRange As Integer, ByVal yRange As Integer) As Double()
            If xRange < 0 Then
                Throw New ArgumentOutOfRangeException("xRange")
            End If

            If yRange < 0 Then
                Throw New ArgumentOutOfRangeException("yRange")
            End If

            Dim wave(xRange) As Double
            Dim i As Integer
            For i = 0 To xRange
                wave(i) = yRange / 2 * (1 - CType(Math.Sin(i * 2 * Math.PI / (xRange - 1)), Single))
            Next

            Return wave
        End Function
    End Class

End Class
