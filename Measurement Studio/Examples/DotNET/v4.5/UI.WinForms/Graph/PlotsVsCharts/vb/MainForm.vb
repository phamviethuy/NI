Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        rnd = New Random()
        historyCapacityNumericEdit.Value = waveformPlot1.HistoryCapacity
        waveformPlot2.HistoryCapacity = waveformPlot1.HistoryCapacity
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

    Private Const Points As Integer = 50

    Private rnd As Random

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.

    Friend WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents waveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents waveformPlot2 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents historyCapacityLabel As System.Windows.Forms.Label
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents appendGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents plotGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents clearDataButton As System.Windows.Forms.Button
    Friend WithEvents appendPlot1Button As System.Windows.Forms.Button
    Friend WithEvents appendPlot2Button As System.Windows.Forms.Button
    Friend WithEvents waveformPlot2Button As System.Windows.Forms.Button
    Friend WithEvents waveformPlot1Button As System.Windows.Forms.Button
    Friend WithEvents graphLegend As NationalInstruments.UI.WindowsForms.Legend
    Friend WithEvents plot1LegendItem As NationalInstruments.UI.LegendItem
    Friend WithEvents plot2LegendItem As NationalInstruments.UI.LegendItem
    Friend WithEvents historyCapacityNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.historyCapacityLabel = New System.Windows.Forms.Label
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.waveformPlot2 = New NationalInstruments.UI.WaveformPlot
        Me.clearDataButton = New System.Windows.Forms.Button
        Me.appendPlot1Button = New System.Windows.Forms.Button
        Me.appendPlot2Button = New System.Windows.Forms.Button
        Me.waveformPlot2Button = New System.Windows.Forms.Button
        Me.waveformPlot1Button = New System.Windows.Forms.Button
        Me.graphLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.plot1LegendItem = New NationalInstruments.UI.LegendItem
        Me.plot2LegendItem = New NationalInstruments.UI.LegendItem
        Me.appendGroupBox = New System.Windows.Forms.GroupBox
        Me.plotGroupBox = New System.Windows.Forms.GroupBox
        Me.historyCapacityNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.graphLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.appendGroupBox.SuspendLayout()
        Me.plotGroupBox.SuspendLayout()
        CType(Me.historyCapacityNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'historyCapacityLabel
        '
        Me.historyCapacityLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.historyCapacityLabel.Location = New System.Drawing.Point(352, 312)
        Me.historyCapacityLabel.Name = "historyCapacityLabel"
        Me.historyCapacityLabel.Size = New System.Drawing.Size(104, 16)
        Me.historyCapacityLabel.TabIndex = 8
        Me.historyCapacityLabel.Text = "History Capacity:"
        Me.toolTip.SetToolTip(Me.historyCapacityLabel, "The number of data points stored in each plot")
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleWaveformGraph.Caption = "2D Waveform Graph"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(16, 8)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1, Me.waveformPlot2})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(312, 288)
        Me.sampleWaveformGraph.TabIndex = 0
        Me.toolTip.SetToolTip(Me.sampleWaveformGraph, "National Instruments Waveform Graph")
        Me.sampleWaveformGraph.UseColorGenerator = True
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'waveformPlot1
        '
        Me.waveformPlot1.XAxis = Me.xAxis
        Me.waveformPlot1.YAxis = Me.yAxis
        '
        'xAxis
        '
        Me.xAxis.Mode = NationalInstruments.UI.AxisMode.StripChart
        Me.xAxis.Range = New NationalInstruments.UI.Range(3, 103)
        '
        'waveformPlot2
        '
        Me.waveformPlot2.XAxis = Me.xAxis
        Me.waveformPlot2.YAxis = Me.yAxis
        '
        'clearDataButton
        '
        Me.clearDataButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clearDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.clearDataButton.Location = New System.Drawing.Point(360, 264)
        Me.clearDataButton.Name = "clearDataButton"
        Me.clearDataButton.Size = New System.Drawing.Size(112, 32)
        Me.clearDataButton.TabIndex = 7
        Me.clearDataButton.Text = "Clear Data"
        Me.toolTip.SetToolTip(Me.clearDataButton, "Clear data on both plots")
        '
        'appendPlot1Button
        '
        Me.appendPlot1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.appendPlot1Button.Location = New System.Drawing.Point(16, 24)
        Me.appendPlot1Button.Name = "appendPlot1Button"
        Me.appendPlot1Button.Size = New System.Drawing.Size(112, 32)
        Me.appendPlot1Button.TabIndex = 5
        Me.appendPlot1Button.Text = "Plot 1"
        Me.toolTip.SetToolTip(Me.appendPlot1Button, "Append 50 points to Plot 1")
        '
        'appendPlot2Button
        '
        Me.appendPlot2Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.appendPlot2Button.Location = New System.Drawing.Point(16, 72)
        Me.appendPlot2Button.Name = "appendPlot2Button"
        Me.appendPlot2Button.Size = New System.Drawing.Size(112, 32)
        Me.appendPlot2Button.TabIndex = 6
        Me.appendPlot2Button.Text = "Plot 2"
        Me.toolTip.SetToolTip(Me.appendPlot2Button, "Append 50 points to Plot 2")
        '
        'waveformPlot2Button
        '
        Me.waveformPlot2Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.waveformPlot2Button.Location = New System.Drawing.Point(16, 72)
        Me.waveformPlot2Button.Name = "waveformPlot2Button"
        Me.waveformPlot2Button.Size = New System.Drawing.Size(112, 32)
        Me.waveformPlot2Button.TabIndex = 3
        Me.waveformPlot2Button.Text = "Plot 2"
        Me.toolTip.SetToolTip(Me.waveformPlot2Button, "Plot 50 points in Plot 2")
        '
        'waveformPlot1Button
        '
        Me.waveformPlot1Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.waveformPlot1Button.Location = New System.Drawing.Point(16, 24)
        Me.waveformPlot1Button.Name = "waveformPlot1Button"
        Me.waveformPlot1Button.Size = New System.Drawing.Size(112, 32)
        Me.waveformPlot1Button.TabIndex = 2
        Me.waveformPlot1Button.Text = "Plot 1"
        Me.toolTip.SetToolTip(Me.waveformPlot1Button, "Plot 50 points in Plot 1")
        '
        'graphLegend
        '
        Me.graphLegend.HorizontalScrollMode = NationalInstruments.UI.ScrollMode.Auto
        Me.graphLegend.Items.AddRange(New NationalInstruments.UI.LegendItem() {Me.plot1LegendItem, Me.plot2LegendItem})
        Me.graphLegend.Location = New System.Drawing.Point(183, 304)
        Me.graphLegend.Name = "graphLegend"
        Me.graphLegend.Size = New System.Drawing.Size(145, 56)
        Me.graphLegend.TabIndex = 10
        Me.toolTip.SetToolTip(Me.graphLegend, "National Instruments Legend")
        '
        'plot1LegendItem
        '
        Me.plot1LegendItem.Source = Me.waveformPlot1
        Me.plot1LegendItem.Text = "Plot 1"
        '
        'plot2LegendItem
        '
        Me.plot2LegendItem.Source = Me.waveformPlot2
        Me.plot2LegendItem.Text = "Plot 2"
        '
        'appendGroupBox
        '
        Me.appendGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.appendGroupBox.Controls.Add(Me.appendPlot1Button)
        Me.appendGroupBox.Controls.Add(Me.appendPlot2Button)
        Me.appendGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.appendGroupBox.Location = New System.Drawing.Point(344, 136)
        Me.appendGroupBox.Name = "appendGroupBox"
        Me.appendGroupBox.Size = New System.Drawing.Size(144, 120)
        Me.appendGroupBox.TabIndex = 4
        Me.appendGroupBox.TabStop = False
        Me.appendGroupBox.Text = "Append (Chart)"
        '
        'plotGroupBox
        '
        Me.plotGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.plotGroupBox.Controls.Add(Me.waveformPlot2Button)
        Me.plotGroupBox.Controls.Add(Me.waveformPlot1Button)
        Me.plotGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotGroupBox.Location = New System.Drawing.Point(344, 8)
        Me.plotGroupBox.Name = "plotGroupBox"
        Me.plotGroupBox.Size = New System.Drawing.Size(144, 120)
        Me.plotGroupBox.TabIndex = 1
        Me.plotGroupBox.TabStop = False
        Me.plotGroupBox.Text = "Plot"
        '
        'historyCapacityNumericEdit
        '
        Me.historyCapacityNumericEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.historyCapacityNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.historyCapacityNumericEdit.Location = New System.Drawing.Point(352, 328)
        Me.historyCapacityNumericEdit.Name = "historyCapacityNumericEdit"
        Me.historyCapacityNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.historyCapacityNumericEdit.Range = New NationalInstruments.UI.Range(1, 10000)
        Me.historyCapacityNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.historyCapacityNumericEdit.TabIndex = 9
        Me.historyCapacityNumericEdit.Value = 1000
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(514, 368)
        Me.Controls.Add(Me.historyCapacityNumericEdit)
        Me.Controls.Add(Me.graphLegend)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Controls.Add(Me.historyCapacityLabel)
        Me.Controls.Add(Me.clearDataButton)
        Me.Controls.Add(Me.appendGroupBox)
        Me.Controls.Add(Me.plotGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(520, 384)
        Me.Name = "MainForm"
        Me.Text = "Plots Vs Charts Example"
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.graphLegend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.appendGroupBox.ResumeLayout(False)
        Me.plotGroupBox.ResumeLayout(False)
        CType(Me.historyCapacityNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub OnPlot1ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waveformPlot1Button.Click
        xAxis.Mode = AxisMode.Fixed
        xAxis.Range = New Range(0, Points + 1)
        waveformPlot1.PlotY(GenerateData(Points, 5, 10))
    End Sub

    Private Sub OnPlot2ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles waveformPlot2Button.Click
        xAxis.Mode = AxisMode.Fixed
        xAxis.Range = New Range(0, Points + 1)
        waveformPlot2.PlotY(GenerateData(Points, 0, 5))
    End Sub

    Private Sub OnAppendPlot1ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appendPlot1Button.Click
        xAxis.Mode = AxisMode.StripChart
        waveformPlot1.PlotYAppend(GenerateData(Points, 5, 10))
    End Sub

    Private Sub OnAppendPlot2ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appendPlot2Button.Click
        xAxis.Mode = AxisMode.StripChart
        waveformPlot2.PlotYAppend(GenerateData(Points, 0, 5))
    End Sub

    Private Sub OnClearDataButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearDataButton.Click
        waveformPlot1.ClearData()
        waveformPlot2.ClearData()
        xAxis.Mode = AxisMode.Fixed
        xAxis.Range = New Range(0, Points + 1)
    End Sub

    Private Sub OnHistoryCapacityChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles historyCapacityNumericEdit.AfterChangeValue
        waveformPlot1.HistoryCapacity = System.Convert.ToInt32(historyCapacityNumericEdit.Value)
        waveformPlot2.HistoryCapacity = System.Convert.ToInt32(historyCapacityNumericEdit.Value)
    End Sub

    Private Function GenerateData(ByVal count As Integer, ByVal minValue As Integer, ByVal maxValue As Integer) As Double()
        Dim data() As Double = New Double(count) {}
        Dim i As Integer
        For i = 0 To data.Length - 1
            data(i) = rnd.Next(minValue, maxValue)
        Next
        Return data
    End Function
End Class