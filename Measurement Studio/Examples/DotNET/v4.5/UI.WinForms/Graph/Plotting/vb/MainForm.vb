
Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private Const MaxValue As Integer = 10

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
    Private WithEvents plotTimer As System.Windows.Forms.Timer
    Private WithEvents settingsGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents stackedSwitch As NationalInstruments.UI.WindowsForms.Switch
    Private WithEvents unstackedLabel As System.Windows.Forms.Label
    Private WithEvents numberOfPlotsLabel As System.Windows.Forms.Label
    Private WithEvents numberOfPlotsTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents pointsPerPlotLabel As System.Windows.Forms.Label
    Private WithEvents pointsPerPlotTrackBar As System.Windows.Forms.TrackBar
    Private WithEvents stackedLabel As System.Windows.Forms.Label
    Private WithEvents xAxis As NationalInstruments.UI.XAxis
    Private WithEvents yAxis As NationalInstruments.UI.YAxis
    Private WithEvents applicationToolTip As System.Windows.Forms.ToolTip
    Private WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private WithEvents plot As NationalInstruments.UI.WaveformPlot
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.plotTimer = New System.Windows.Forms.Timer(Me.components)
        Me.settingsGroupBox = New System.Windows.Forms.GroupBox
        Me.stackedSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.unstackedLabel = New System.Windows.Forms.Label
        Me.numberOfPlotsLabel = New System.Windows.Forms.Label
        Me.numberOfPlotsTrackBar = New System.Windows.Forms.TrackBar
        Me.pointsPerPlotLabel = New System.Windows.Forms.Label
        Me.pointsPerPlotTrackBar = New System.Windows.Forms.TrackBar
        Me.stackedLabel = New System.Windows.Forms.Label
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.applicationToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.plot = New NationalInstruments.UI.WaveformPlot
        Me.settingsGroupBox.SuspendLayout()
        CType(Me.stackedSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfPlotsTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pointsPerPlotTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'plotTimer
        '
        Me.plotTimer.Enabled = True
        Me.plotTimer.Interval = 200
        '
        'settingsGroupBox
        '
        Me.settingsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsGroupBox.Controls.Add(Me.stackedSwitch)
        Me.settingsGroupBox.Controls.Add(Me.unstackedLabel)
        Me.settingsGroupBox.Controls.Add(Me.numberOfPlotsLabel)
        Me.settingsGroupBox.Controls.Add(Me.numberOfPlotsTrackBar)
        Me.settingsGroupBox.Controls.Add(Me.pointsPerPlotLabel)
        Me.settingsGroupBox.Controls.Add(Me.pointsPerPlotTrackBar)
        Me.settingsGroupBox.Controls.Add(Me.stackedLabel)
        Me.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.settingsGroupBox.Location = New System.Drawing.Point(8, 280)
        Me.settingsGroupBox.Name = "settingsGroupBox"
        Me.settingsGroupBox.Size = New System.Drawing.Size(304, 184)
        Me.settingsGroupBox.TabIndex = 1
        Me.settingsGroupBox.TabStop = False
        Me.settingsGroupBox.Text = "Settings"
        '
        'stackedSwitch
        '
        Me.stackedSwitch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stackedSwitch.Location = New System.Drawing.Point(224, 40)
        Me.stackedSwitch.Name = "stackedSwitch"
        Me.stackedSwitch.Size = New System.Drawing.Size(72, 112)
        Me.stackedSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.stackedSwitch.TabIndex = 7
        Me.applicationToolTip.SetToolTip(Me.stackedSwitch, "Toggle between stacked and unstacked plots")
        Me.stackedSwitch.Value = True
        '
        'unstackedLabel
        '
        Me.unstackedLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.unstackedLabel.Location = New System.Drawing.Point(224, 152)
        Me.unstackedLabel.Name = "unstackedLabel"
        Me.unstackedLabel.Size = New System.Drawing.Size(72, 24)
        Me.unstackedLabel.TabIndex = 8
        Me.unstackedLabel.Text = "Overlay Plots"
        Me.unstackedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'numberOfPlotsLabel
        '
        Me.numberOfPlotsLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numberOfPlotsLabel.Location = New System.Drawing.Point(16, 20)
        Me.numberOfPlotsLabel.Name = "numberOfPlotsLabel"
        Me.numberOfPlotsLabel.Size = New System.Drawing.Size(104, 16)
        Me.numberOfPlotsLabel.TabIndex = 2
        Me.numberOfPlotsLabel.Text = "Number of Plots:"
        Me.numberOfPlotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numberOfPlotsTrackBar
        '
        Me.numberOfPlotsTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.numberOfPlotsTrackBar.LargeChange = 1
        Me.numberOfPlotsTrackBar.Location = New System.Drawing.Point(8, 44)
        Me.numberOfPlotsTrackBar.Minimum = 1
        Me.numberOfPlotsTrackBar.Name = "numberOfPlotsTrackBar"
        Me.numberOfPlotsTrackBar.Size = New System.Drawing.Size(208, 45)
        Me.numberOfPlotsTrackBar.TabIndex = 3
        Me.numberOfPlotsTrackBar.Value = 3
        '
        'pointsPerPlotLabel
        '
        Me.pointsPerPlotLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pointsPerPlotLabel.Location = New System.Drawing.Point(16, 104)
        Me.pointsPerPlotLabel.Name = "pointsPerPlotLabel"
        Me.pointsPerPlotLabel.Size = New System.Drawing.Size(104, 16)
        Me.pointsPerPlotLabel.TabIndex = 4
        Me.pointsPerPlotLabel.Text = "Points Per Plot:"
        Me.pointsPerPlotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pointsPerPlotTrackBar
        '
        Me.pointsPerPlotTrackBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pointsPerPlotTrackBar.LargeChange = 15
        Me.pointsPerPlotTrackBar.Location = New System.Drawing.Point(8, 128)
        Me.pointsPerPlotTrackBar.Maximum = 100
        Me.pointsPerPlotTrackBar.Minimum = 10
        Me.pointsPerPlotTrackBar.Name = "pointsPerPlotTrackBar"
        Me.pointsPerPlotTrackBar.Size = New System.Drawing.Size(208, 45)
        Me.pointsPerPlotTrackBar.TabIndex = 5
        Me.pointsPerPlotTrackBar.TickFrequency = 5
        Me.pointsPerPlotTrackBar.Value = 20
        '
        'stackedLabel
        '
        Me.stackedLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.stackedLabel.Location = New System.Drawing.Point(224, 8)
        Me.stackedLabel.Name = "stackedLabel"
        Me.stackedLabel.Size = New System.Drawing.Size(72, 24)
        Me.stackedLabel.TabIndex = 6
        Me.stackedLabel.Text = "Stack Plots"
        Me.stackedLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleWaveformGraph.Caption = "2D Graph"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.plot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(304, 264)
        Me.sampleWaveformGraph.TabIndex = 0
        Me.applicationToolTip.SetToolTip(Me.sampleWaveformGraph, "National Instruments Waveform Graph")
        Me.sampleWaveformGraph.UseColorGenerator = True
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'plot
        '
        Me.plot.XAxis = Me.xAxis
        Me.plot.YAxis = Me.yAxis
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(322, 472)
        Me.Controls.Add(Me.settingsGroupBox)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(328, 504)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plotting Example"
        Me.settingsGroupBox.ResumeLayout(False)
        Me.settingsGroupBox.PerformLayout()
        CType(Me.stackedSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfPlotsTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pointsPerPlotTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub OnTimerTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotTimer.Tick
        Dim numberOfPlots As Integer = Math.Max(numberOfPlotsTrackBar.Value, 1)
        Dim pointsPerPlot As Integer = Math.Max(pointsPerPlotTrackBar.Value, 1)

        Dim data(numberOfPlots - 1, pointsPerPlot - 1) As Double
        Dim rnd As Random = New Random

        Dim plotIndex As Integer
        Dim pointIndex As Integer

        For plotIndex = 0 To numberOfPlots - 1
            For pointIndex = 0 To pointsPerPlot - 1
                Dim point As Double = rnd.NextDouble() * MaxValue
                If stackedSwitch.Value Then
                    point = (point / numberOfPlots) + (MaxValue / numberOfPlots) * plotIndex
                End If
                data(plotIndex, pointIndex) = point
            Next
        Next

        sampleWaveformGraph.PlotYMultiple(data)
    End Sub


    Private Sub numberOfPlotsBar_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numberOfPlotsTrackBar.Scroll
        sampleWaveformGraph.ClearData()
    End Sub
End Class
