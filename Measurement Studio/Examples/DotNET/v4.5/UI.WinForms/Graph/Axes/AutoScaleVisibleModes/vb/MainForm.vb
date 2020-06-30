Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private autoScaleVisibleWaveformGraph As WaveformGraph
    Private autoScaleVisibleWaveformPlot As WaveformPlot
    Private autoScaleVisibleXAxis As XAxis
    Private autoScaleVisibleYAxis As YAxis
    Private autoScaleWaveformGraph As WaveformGraph
    Private autoScaleWaveformPlot As WaveformPlot
    Private autoScaleXAxis As XAxis
    Private autoScaleYAxis As YAxis
    Private plotControlGroupBox As GroupBox
    Private clearButton As Button
    Private pauseCheckBox As CheckBox
    Private plotTimer As Timer
    Private aboutGroupBox As GroupBox
    Private aboutTextBox As TextBox
    Private components As System.ComponentModel.IContainer

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        ' Initialize about box text and increase font size.
        aboutGroupBox.Text = "About the """ + Text + """ Example"
        aboutTextBox.Font = New Font(Font.FontFamily, Font.Size + 2)

        ' Begin plotting.
        pauseCheckBox.Checked = False
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.autoScaleVisibleWaveformGraph = New Global.NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.autoScaleVisibleWaveformPlot = New Global.NationalInstruments.UI.WaveformPlot
        Me.autoScaleVisibleXAxis = New Global.NationalInstruments.UI.XAxis
        Me.autoScaleVisibleYAxis = New Global.NationalInstruments.UI.YAxis
        Me.autoScaleWaveformGraph = New Global.NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.autoScaleWaveformPlot = New Global.NationalInstruments.UI.WaveformPlot
        Me.autoScaleXAxis = New Global.NationalInstruments.UI.XAxis
        Me.autoScaleYAxis = New Global.NationalInstruments.UI.YAxis
        Me.plotControlGroupBox = New System.Windows.Forms.GroupBox
        Me.clearButton = New System.Windows.Forms.Button
        Me.pauseCheckBox = New System.Windows.Forms.CheckBox
        Me.plotTimer = New System.Windows.Forms.Timer(Me.components)
        Me.aboutGroupBox = New System.Windows.Forms.GroupBox
        Me.aboutTextBox = New System.Windows.Forms.TextBox
        CType(Me.autoScaleVisibleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.autoScaleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotControlGroupBox.SuspendLayout()
        Me.aboutGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'autoScaleVisibleWaveformGraph
        '
        Me.autoScaleVisibleWaveformGraph.Caption = "AutoScaleVisibleLoose Axis Mode"
        Me.autoScaleVisibleWaveformGraph.InteractionMode = Global.NationalInstruments.UI.GraphInteractionModes.PanX
        Me.autoScaleVisibleWaveformGraph.Location = New System.Drawing.Point(12, 12)
        Me.autoScaleVisibleWaveformGraph.Name = "autoScaleVisibleWaveformGraph"
        Me.autoScaleVisibleWaveformGraph.Plots.AddRange(New Global.NationalInstruments.UI.WaveformPlot() {Me.autoScaleVisibleWaveformPlot})
        Me.autoScaleVisibleWaveformGraph.Size = New System.Drawing.Size(333, 227)
        Me.autoScaleVisibleWaveformGraph.TabIndex = 0
        Me.autoScaleVisibleWaveformGraph.XAxes.AddRange(New Global.NationalInstruments.UI.XAxis() {Me.autoScaleVisibleXAxis})
        Me.autoScaleVisibleWaveformGraph.YAxes.AddRange(New Global.NationalInstruments.UI.YAxis() {Me.autoScaleVisibleYAxis})
        '
        'autoScaleVisibleWaveformPlot
        '
        Me.autoScaleVisibleWaveformPlot.XAxis = Me.autoScaleVisibleXAxis
        Me.autoScaleVisibleWaveformPlot.YAxis = Me.autoScaleVisibleYAxis
        '
        'autoScaleVisibleXAxis
        '
        Me.autoScaleVisibleXAxis.Caption = "StripChart axis"
        Me.autoScaleVisibleXAxis.Mode = Global.NationalInstruments.UI.AxisMode.StripChart
        AddHandler Me.autoScaleVisibleXAxis.RangeChanged, AddressOf autoScaleVisibleXAxis_RangeChanged
        '
        'autoScaleVisibleYAxis
        '
        Me.autoScaleVisibleYAxis.Caption = "AutoScaleVisibleLoose axis"
        Me.autoScaleVisibleYAxis.Mode = Global.NationalInstruments.UI.AxisMode.AutoScaleVisibleLoose
        Me.autoScaleVisibleYAxis.Range = New Global.NationalInstruments.UI.Range(-0.5, 0.5)
        '
        'autoScaleWaveformGraph
        '
        Me.autoScaleWaveformGraph.Caption = "AutoScaleLoose Axis Mode"
        Me.autoScaleWaveformGraph.InteractionMode = Global.NationalInstruments.UI.GraphInteractionModes.PanX
        Me.autoScaleWaveformGraph.Location = New System.Drawing.Point(365, 12)
        Me.autoScaleWaveformGraph.Name = "autoScaleWaveformGraph"
        Me.autoScaleWaveformGraph.Plots.AddRange(New Global.NationalInstruments.UI.WaveformPlot() {Me.autoScaleWaveformPlot})
        Me.autoScaleWaveformGraph.Size = New System.Drawing.Size(333, 227)
        Me.autoScaleWaveformGraph.TabIndex = 1
        Me.autoScaleWaveformGraph.XAxes.AddRange(New Global.NationalInstruments.UI.XAxis() {Me.autoScaleXAxis})
        Me.autoScaleWaveformGraph.YAxes.AddRange(New Global.NationalInstruments.UI.YAxis() {Me.autoScaleYAxis})
        '
        'autoScaleWaveformPlot
        '
        Me.autoScaleWaveformPlot.XAxis = Me.autoScaleXAxis
        Me.autoScaleWaveformPlot.YAxis = Me.autoScaleYAxis
        '
        'autoScaleXAxis
        '
        Me.autoScaleXAxis.Caption = "StripChart axis"
        Me.autoScaleXAxis.Mode = Global.NationalInstruments.UI.AxisMode.StripChart
        AddHandler Me.autoScaleXAxis.RangeChanged, AddressOf autoScaleXAxis_RangeChanged
        '
        'autoScaleYAxis
        '
        Me.autoScaleYAxis.Caption = "AutoScaleLoose axis"
        Me.autoScaleYAxis.Range = New Global.NationalInstruments.UI.Range(-0.5, 0.5)
        '
        'plotControlGroupBox
        '
        Me.plotControlGroupBox.Controls.Add(Me.clearButton)
        Me.plotControlGroupBox.Controls.Add(Me.pauseCheckBox)
        Me.plotControlGroupBox.Location = New System.Drawing.Point(12, 263)
        Me.plotControlGroupBox.Name = "plotControlGroupBox"
        Me.plotControlGroupBox.Size = New System.Drawing.Size(686, 52)
        Me.plotControlGroupBox.TabIndex = 3
        Me.plotControlGroupBox.TabStop = False
        Me.plotControlGroupBox.Text = "Control Data Plotting"
        '
        'clearButton
        '
        Me.clearButton.Location = New System.Drawing.Point(407, 19)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(75, 23)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "&Clear"
        Me.clearButton.UseVisualStyleBackColor = True
        AddHandler Me.clearButton.Click, AddressOf clearButton_Click
        '
        'pauseCheckBox
        '
        Me.pauseCheckBox.AutoSize = True
        Me.pauseCheckBox.Checked = True
        Me.pauseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.pauseCheckBox.Location = New System.Drawing.Point(227, 23)
        Me.pauseCheckBox.Name = "pauseCheckBox"
        Me.pauseCheckBox.Size = New System.Drawing.Size(93, 17)
        Me.pauseCheckBox.TabIndex = 0
        Me.pauseCheckBox.Text = "&Pause plotting"
        Me.pauseCheckBox.UseVisualStyleBackColor = True
        AddHandler Me.pauseCheckBox.CheckedChanged, AddressOf pauseCheckBox_CheckedChanged
        '
        'plotTimer
        '
        Me.plotTimer.Interval = 300
        AddHandler Me.plotTimer.Tick, AddressOf plotTimer_Tick
        '
        'aboutGroupBox
        '
        Me.aboutGroupBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aboutGroupBox.Controls.Add(Me.aboutTextBox)
        Me.aboutGroupBox.Location = New System.Drawing.Point(12, 334)
        Me.aboutGroupBox.Name = "aboutGroupBox"
        Me.aboutGroupBox.Padding = New System.Windows.Forms.Padding(8, 8, 3, 3)
        Me.aboutGroupBox.Size = New System.Drawing.Size(686, 216)
        Me.aboutGroupBox.TabIndex = 4
        Me.aboutGroupBox.TabStop = False
        Me.aboutGroupBox.Text = "About the ""AutoScale Axis Modes Comparison"" Example"
        '
        'aboutTextBox
        '
        Me.aboutTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aboutTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.aboutTextBox.Location = New System.Drawing.Point(8, 21)
        Me.aboutTextBox.Multiline = True
        Me.aboutTextBox.Name = "aboutTextBox"
        Me.aboutTextBox.ReadOnly = True
        Me.aboutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.aboutTextBox.Size = New System.Drawing.Size(675, 192)
        Me.aboutTextBox.TabIndex = 0
        Me.aboutTextBox.Text = resources.GetString("aboutTextBox.Text")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(710, 562)
        Me.Controls.Add(Me.aboutGroupBox)
        Me.Controls.Add(Me.plotControlGroupBox)
        Me.Controls.Add(Me.autoScaleWaveformGraph)
        Me.Controls.Add(Me.autoScaleVisibleWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoScale AxisModes Comparison"
        CType(Me.autoScaleVisibleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.autoScaleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotControlGroupBox.ResumeLayout(False)
        Me.plotControlGroupBox.PerformLayout()
        Me.aboutGroupBox.ResumeLayout(False)
        Me.aboutGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub


    Private Sub pauseCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        plotTimer.Enabled = Not pauseCheckBox.Checked

        ' Enable graph interaction when paused.
        Dim interactionMode As GraphDefaultInteractionMode = (IIf(pauseCheckBox.Checked, GraphDefaultInteractionMode.PanX, GraphDefaultInteractionMode.None))
        autoScaleVisibleWaveformGraph.InteractionModeDefault = interactionMode
        autoScaleWaveformGraph.InteractionModeDefault = interactionMode
    End Sub

    Private Sub clearButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        autoScaleVisibleWaveformPlot.ClearData()
        autoScaleWaveformPlot.ClearData()
    End Sub


    ' Pan both graphs simultaneously.
    Private Sub autoScaleVisibleXAxis_RangeChanged(ByVal sender As Object, ByVal e As EventArgs)
        autoScaleXAxis.Range = autoScaleVisibleXAxis.Range
    End Sub

    Private Sub autoScaleXAxis_RangeChanged(ByVal sender As Object, ByVal e As EventArgs)
        autoScaleVisibleXAxis.Range = autoScaleXAxis.Range
    End Sub


    ' Plot random data on every timer tick.
    Private random As New Random()
    Const NoiseFrequency As Integer = 20
    Private counter As Integer = NoiseFrequency / 2
    Private Sub plotTimer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        counter += 1
        Dim dataPoint As Double = random.NextDouble() - 0.5

        ' Introduce extra noise every few points.
        If counter Mod NoiseFrequency = 0 Then
            dataPoint *= NoiseFrequency * 2
        End If

        autoScaleVisibleWaveformPlot.PlotYAppend(dataPoint)
        autoScaleWaveformPlot.PlotYAppend(dataPoint)
    End Sub

End Class
