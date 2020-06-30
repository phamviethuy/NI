Imports NationalInstruments.UI

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private rand As Random
    Private graphCursor As XYCursor

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        rand = New Random
        graphCursor = New XYCursor(WaveformPlot)
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

    Friend WithEvents chartTimer As System.Windows.Forms.Timer
    Friend WithEvents dataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents WaveformPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents XAxis As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis As NationalInstruments.UI.YAxis
    Friend WithEvents dataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents generateSwitch As NationalInstruments.UI.WindowsForms.Switch
    Friend WithEvents switchLabel As System.Windows.Forms.Label
    Friend WithEvents stopLabel As System.Windows.Forms.Label
    Friend WithEvents cursorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents showCursorLabelCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents addRemoveCursorButton As System.Windows.Forms.Button
    Friend WithEvents plotGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents plotToolTipCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents toolTipDescriptionLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.chartTimer = New System.Windows.Forms.Timer(Me.components)
        Me.dataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.WaveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.XAxis = New NationalInstruments.UI.XAxis
        Me.YAxis = New NationalInstruments.UI.YAxis
        Me.dataGroupBox = New System.Windows.Forms.GroupBox
        Me.generateSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.switchLabel = New System.Windows.Forms.Label
        Me.stopLabel = New System.Windows.Forms.Label
        Me.cursorGroupBox = New System.Windows.Forms.GroupBox
        Me.showCursorLabelCheckBox = New System.Windows.Forms.CheckBox
        Me.addRemoveCursorButton = New System.Windows.Forms.Button
        Me.plotGroupBox = New System.Windows.Forms.GroupBox
        Me.plotToolTipCheckBox = New System.Windows.Forms.CheckBox
        Me.toolTipDescriptionLabel = New System.Windows.Forms.Label
        CType(Me.dataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataGroupBox.SuspendLayout()
        CType(Me.generateSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cursorGroupBox.SuspendLayout()
        Me.plotGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'chartTimer
        '
        '
        'dataWaveformGraph
        '
        Me.dataWaveformGraph.Caption = "National Instruments Waveform Graph"
        Me.dataWaveformGraph.Location = New System.Drawing.Point(12, 12)
        Me.dataWaveformGraph.Name = "dataWaveformGraph"
        Me.dataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.WaveformPlot})
        Me.dataWaveformGraph.Size = New System.Drawing.Size(428, 196)
        Me.dataWaveformGraph.TabIndex = 8
        Me.dataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis})
        Me.dataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis})
        '
        'WaveformPlot
        '
        Me.WaveformPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle
        Me.WaveformPlot.ToolTipsEnabled = True
        Me.WaveformPlot.XAxis = Me.XAxis
        Me.WaveformPlot.YAxis = Me.YAxis
        '
        'XAxis
        '
        Me.XAxis.Mode = NationalInstruments.UI.AxisMode.StripChart
        Me.XAxis.Range = New NationalInstruments.UI.Range(0, 20)
        '
        'dataGroupBox
        '
        Me.dataGroupBox.Controls.Add(Me.generateSwitch)
        Me.dataGroupBox.Controls.Add(Me.switchLabel)
        Me.dataGroupBox.Controls.Add(Me.stopLabel)
        Me.dataGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dataGroupBox.Location = New System.Drawing.Point(5, 224)
        Me.dataGroupBox.Name = "dataGroupBox"
        Me.dataGroupBox.Size = New System.Drawing.Size(112, 120)
        Me.dataGroupBox.TabIndex = 15
        Me.dataGroupBox.TabStop = False
        Me.dataGroupBox.Text = "Data"
        '
        'generateSwitch
        '
        Me.generateSwitch.Location = New System.Drawing.Point(16, 32)
        Me.generateSwitch.Name = "generateSwitch"
        Me.generateSwitch.Size = New System.Drawing.Size(60, 64)
        Me.generateSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide3D
        Me.generateSwitch.TabIndex = 3
        '
        'switchLabel
        '
        Me.switchLabel.AutoSize = True
        Me.switchLabel.Location = New System.Drawing.Point(8, 16)
        Me.switchLabel.Name = "switchLabel"
        Me.switchLabel.Size = New System.Drawing.Size(86, 13)
        Me.switchLabel.TabIndex = 4
        Me.switchLabel.Text = "Generate Values"
        '
        'stopLabel
        '
        Me.stopLabel.AutoSize = True
        Me.stopLabel.Location = New System.Drawing.Point(32, 96)
        Me.stopLabel.Name = "stopLabel"
        Me.stopLabel.Size = New System.Drawing.Size(29, 13)
        Me.stopLabel.TabIndex = 5
        Me.stopLabel.Text = "Stop"
        '
        'cursorGroupBox
        '
        Me.cursorGroupBox.Controls.Add(Me.showCursorLabelCheckBox)
        Me.cursorGroupBox.Controls.Add(Me.addRemoveCursorButton)
        Me.cursorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cursorGroupBox.Location = New System.Drawing.Point(301, 224)
        Me.cursorGroupBox.Name = "cursorGroupBox"
        Me.cursorGroupBox.Size = New System.Drawing.Size(136, 120)
        Me.cursorGroupBox.TabIndex = 14
        Me.cursorGroupBox.TabStop = False
        Me.cursorGroupBox.Text = "Cursor"
        '
        'showCursorLabelCheckBox
        '
        Me.showCursorLabelCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.showCursorLabelCheckBox.Location = New System.Drawing.Point(8, 16)
        Me.showCursorLabelCheckBox.Name = "showCursorLabelCheckBox"
        Me.showCursorLabelCheckBox.Size = New System.Drawing.Size(120, 24)
        Me.showCursorLabelCheckBox.TabIndex = 8
        Me.showCursorLabelCheckBox.Text = "Show cursor label"
        '
        'addRemoveCursorButton
        '
        Me.addRemoveCursorButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.addRemoveCursorButton.Location = New System.Drawing.Point(8, 72)
        Me.addRemoveCursorButton.Name = "addRemoveCursorButton"
        Me.addRemoveCursorButton.Size = New System.Drawing.Size(96, 23)
        Me.addRemoveCursorButton.TabIndex = 7
        Me.addRemoveCursorButton.Text = "Add Cursor"
        '
        'plotGroupBox
        '
        Me.plotGroupBox.Controls.Add(Me.plotToolTipCheckBox)
        Me.plotGroupBox.Controls.Add(Me.toolTipDescriptionLabel)
        Me.plotGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotGroupBox.Location = New System.Drawing.Point(133, 224)
        Me.plotGroupBox.Name = "plotGroupBox"
        Me.plotGroupBox.Size = New System.Drawing.Size(152, 120)
        Me.plotGroupBox.TabIndex = 13
        Me.plotGroupBox.TabStop = False
        Me.plotGroupBox.Text = "Plot"
        '
        'plotToolTipCheckBox
        '
        Me.plotToolTipCheckBox.Checked = True
        Me.plotToolTipCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.plotToolTipCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotToolTipCheckBox.Location = New System.Drawing.Point(8, 16)
        Me.plotToolTipCheckBox.Name = "plotToolTipCheckBox"
        Me.plotToolTipCheckBox.Size = New System.Drawing.Size(128, 24)
        Me.plotToolTipCheckBox.TabIndex = 6
        Me.plotToolTipCheckBox.Text = "Enable data tool tip"
        '
        'toolTipDescriptionLabel
        '
        Me.toolTipDescriptionLabel.Location = New System.Drawing.Point(8, 48)
        Me.toolTipDescriptionLabel.Name = "toolTipDescriptionLabel"
        Me.toolTipDescriptionLabel.Size = New System.Drawing.Size(136, 64)
        Me.toolTipDescriptionLabel.TabIndex = 9
        Me.toolTipDescriptionLabel.Text = "Check enable data tool tip to display a tool tip for each point.  Hover mouse ove" & _
            "r data point to see its value."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(458, 351)
        Me.Controls.Add(Me.dataGroupBox)
        Me.Controls.Add(Me.cursorGroupBox)
        Me.Controls.Add(Me.plotGroupBox)
        Me.Controls.Add(Me.dataWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Data Inspection"
        CType(Me.dataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataGroupBox.ResumeLayout(False)
        Me.dataGroupBox.PerformLayout()
        CType(Me.generateSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cursorGroupBox.ResumeLayout(False)
        Me.plotGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chartTimer.Tick
        WaveformPlot.PlotYAppend(rand.NextDouble * 10)
    End Sub

    Private Sub generateSwitch_StateChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.ActionEventArgs) Handles generateSwitch.StateChanged
        chartTimer.Enabled = Not chartTimer.Enabled
    End Sub

    Private Sub plotToolTipCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotToolTipCheckBox.CheckedChanged
        WaveformPlot.ToolTipsEnabled = plotToolTipCheckBox.Checked
    End Sub

    Private Sub showCursorLabelCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showCursorLabelCheckBox.CheckedChanged
        graphCursor.LabelVisible = showCursorLabelCheckBox.Checked
    End Sub

    Private Sub addRemoveCursorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addRemoveCursorButton.Click
        If dataWaveformGraph.Cursors.Count > 0 Then
            dataWaveformGraph.Cursors.Clear()
            addRemoveCursorButton.Text = "Add Cursor"
        Else
            dataWaveformGraph.Cursors.Add(graphCursor)
            Dim xValue As Double = (XAxis.Range.Maximum + XAxis.Range.Minimum) / 2
            Dim yValue As Double = (YAxis.Range.Maximum + YAxis.Range.Minimum) / 2

            graphCursor.MoveCursor(xValue, yValue)
            addRemoveCursorButton.Text = "Remove Cursor"

        End If
    End Sub

    Public Shared Sub main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub
End Class
