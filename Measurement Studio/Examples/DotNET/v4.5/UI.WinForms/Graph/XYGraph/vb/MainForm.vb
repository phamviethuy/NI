Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private Const TwoPi As Double = Math.PI * 2
    Private Const HalfPi As Double = Math.PI / 2

#Region "Windows Form Designer generated code"

    Public Sub New()
        MyBase.New()

        InitializeComponent()
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
    Friend WithEvents separatorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents xDataYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents xPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xDataXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents xyPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xyPlotXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents xyPlotYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents yDataYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents yPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents yDataXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents xDataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents plotCircleButton As System.Windows.Forms.Button
    Friend WithEvents xyDataScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents plotSpiralButton As System.Windows.Forms.Button
    Friend WithEvents plotPolarButton As System.Windows.Forms.Button
    Friend WithEvents plotOctagonButton As System.Windows.Forms.Button
    Friend WithEvents yDataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.separatorGroupBox = New System.Windows.Forms.GroupBox
        Me.xDataYAxis = New NationalInstruments.UI.YAxis
        Me.xPlot = New NationalInstruments.UI.WaveformPlot
        Me.xDataXAxis = New NationalInstruments.UI.XAxis
        Me.xDataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.xyPlot = New NationalInstruments.UI.ScatterPlot
        Me.xyPlotXAxis = New NationalInstruments.UI.XAxis
        Me.xyPlotYAxis = New NationalInstruments.UI.YAxis
        Me.plotCircleButton = New System.Windows.Forms.Button
        Me.xyDataScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.yDataYAxis = New NationalInstruments.UI.YAxis
        Me.plotSpiralButton = New System.Windows.Forms.Button
        Me.plotPolarButton = New System.Windows.Forms.Button
        Me.plotOctagonButton = New System.Windows.Forms.Button
        Me.yDataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.yPlot = New NationalInstruments.UI.WaveformPlot
        Me.yDataXAxis = New NationalInstruments.UI.XAxis
        CType(Me.xDataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xyDataScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yDataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'separatorGroupBox
        '
        Me.separatorGroupBox.Location = New System.Drawing.Point(4, 352)
        Me.separatorGroupBox.Name = "separatorGroupBox"
        Me.separatorGroupBox.Size = New System.Drawing.Size(484, 8)
        Me.separatorGroupBox.TabIndex = 15
        Me.separatorGroupBox.TabStop = False
        '
        'xPlot
        '
        Me.xPlot.XAxis = Me.xDataXAxis
        Me.xPlot.YAxis = Me.xDataYAxis
        '
        'xDataWaveformGraph
        '
        Me.xDataWaveformGraph.Caption = "X Data"
        Me.xDataWaveformGraph.Location = New System.Drawing.Point(4, 208)
        Me.xDataWaveformGraph.Name = "xDataWaveformGraph"
        Me.xDataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.xPlot})
        Me.xDataWaveformGraph.Size = New System.Drawing.Size(240, 140)
        Me.xDataWaveformGraph.TabIndex = 9
        Me.xDataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xDataXAxis})
        Me.xDataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.xDataYAxis})
        '
        'xyPlot
        '
        Me.xyPlot.XAxis = Me.xyPlotXAxis
        Me.xyPlot.YAxis = Me.xyPlotYAxis
        '
        'plotCircleButton
        '
        Me.plotCircleButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotCircleButton.Location = New System.Drawing.Point(8, 368)
        Me.plotCircleButton.Name = "plotCircleButton"
        Me.plotCircleButton.Size = New System.Drawing.Size(112, 23)
        Me.plotCircleButton.TabIndex = 11
        Me.plotCircleButton.Text = "Plot Circle"
        '
        'xyDataScatterGraph
        '
        Me.xyDataScatterGraph.Caption = "XY Plot"
        Me.xyDataScatterGraph.Location = New System.Drawing.Point(4, 4)
        Me.xyDataScatterGraph.Name = "xyDataScatterGraph"
        Me.xyDataScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.xyPlot})
        Me.xyDataScatterGraph.Size = New System.Drawing.Size(484, 200)
        Me.xyDataScatterGraph.TabIndex = 8
        Me.xyDataScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xyPlotXAxis})
        Me.xyDataScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.xyPlotYAxis})
        '
        'plotSpiralButton
        '
        Me.plotSpiralButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotSpiralButton.Location = New System.Drawing.Point(371, 368)
        Me.plotSpiralButton.Name = "plotSpiralButton"
        Me.plotSpiralButton.Size = New System.Drawing.Size(112, 23)
        Me.plotSpiralButton.TabIndex = 14
        Me.plotSpiralButton.Text = "Plot Spiral"
        '
        'plotPolarButton
        '
        Me.plotPolarButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotPolarButton.Location = New System.Drawing.Point(250, 368)
        Me.plotPolarButton.Name = "plotPolarButton"
        Me.plotPolarButton.Size = New System.Drawing.Size(112, 23)
        Me.plotPolarButton.TabIndex = 13
        Me.plotPolarButton.Text = "Plot Polar"
        '
        'plotOctagonButton
        '
        Me.plotOctagonButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotOctagonButton.Location = New System.Drawing.Point(129, 368)
        Me.plotOctagonButton.Name = "plotOctagonButton"
        Me.plotOctagonButton.Size = New System.Drawing.Size(112, 23)
        Me.plotOctagonButton.TabIndex = 12
        Me.plotOctagonButton.Text = "Plot Octagon"
        '
        'yDataWaveformGraph
        '
        Me.yDataWaveformGraph.Caption = "Y Data"
        Me.yDataWaveformGraph.Location = New System.Drawing.Point(248, 208)
        Me.yDataWaveformGraph.Name = "yDataWaveformGraph"
        Me.yDataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.yPlot})
        Me.yDataWaveformGraph.Size = New System.Drawing.Size(240, 140)
        Me.yDataWaveformGraph.TabIndex = 10
        Me.yDataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.yDataXAxis})
        Me.yDataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yDataYAxis})
        '
        'yPlot
        '
        Me.yPlot.XAxis = Me.yDataXAxis
        Me.yPlot.YAxis = Me.yDataYAxis
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(492, 395)
        Me.Controls.Add(Me.separatorGroupBox)
        Me.Controls.Add(Me.xDataWaveformGraph)
        Me.Controls.Add(Me.plotCircleButton)
        Me.Controls.Add(Me.xyDataScatterGraph)
        Me.Controls.Add(Me.plotSpiralButton)
        Me.Controls.Add(Me.plotPolarButton)
        Me.Controls.Add(Me.plotOctagonButton)
        Me.Controls.Add(Me.yDataWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "XY Graph"
        CType(Me.xDataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xyDataScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yDataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub OnPlotCircleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotCircleButton.Click
        Const pointCount As Integer = 50
        Const divisor As Integer = pointCount - 1
        Dim dataX(pointCount) As Double
        Dim dataY(pointCount) As Double

        For i As Integer = 0 To pointCount
            Dim current As Double = (CType(i, Double) / divisor) * TwoPi
            dataX(i) = Math.Cos(current) * HalfPi
            dataY(i) = Math.Sin(current) * HalfPi
        Next

        xyPlot.PlotXY(dataX, dataY)
        xPlot.PlotY(dataX)
        yPlot.PlotY(dataY)
    End Sub

    Private Sub OnPlotOctagonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotOctagonButton.Click
        Const numberOfSides As Integer = 8
        Const pointCount As Integer = numberOfSides + 1

        Dim dataX(pointCount) As Double
        Dim dataY(pointCount) As Double

        For i As Integer = 0 To pointCount
            dataX(i) = Math.Cos(((i + 0.5) / numberOfSides) * TwoPi)
            dataY(i) = Math.Sin(((i + 0.5) / numberOfSides) * TwoPi)
        Next

        xyPlot.PlotXY(dataX, dataY)
        xPlot.PlotY(dataX)
        yPlot.PlotY(dataY)
    End Sub

    Private Sub OnPlotPolarClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotPolarButton.Click
        Const numberOfPoints As Integer = 360
        Const divisor As Integer = numberOfPoints - 1

        Dim dataR(numberOfPoints) As Double
        Dim dataP(numberOfPoints) As Double
        Dim dataX(numberOfPoints) As Double
        Dim dataY(numberOfPoints) As Double

        ' Calculate data in polar coordinates.
        For i As Integer = 0 To numberOfPoints
            dataP(i) = i
            dataR(i) = Math.Sin((CType(i, Double) / divisor) * TwoPi * 3) + 0.5
        Next

        ' Convert polar coordinates to XY coordinates.
        For i As Integer = 0 To numberOfPoints
            Dim current As Double = (dataP(i) / numberOfPoints) * TwoPi
            dataX(i) = Math.Cos(current) * dataR(i)
            dataY(i) = Math.Sin(current) * dataR(i)
        Next

        xyPlot.PlotXY(dataX, dataY)
        xPlot.PlotY(dataX)
        yPlot.PlotY(dataY)
    End Sub

    Private Sub OnPlotSpiralClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotSpiralButton.Click
        Const numberOfPoints As Integer = 360

        Dim dataR(numberOfPoints) As Double
        Dim dataP(numberOfPoints) As Double
        Dim dataX(numberOfPoints) As Double
        Dim dataY(numberOfPoints) As Double

        ' Calculate data in polar coordinates.
        For i As Integer = 0 To numberOfPoints
            dataP(i) = i * 10
            dataR(i) = Math.Pow(i, 2) / 70000
        Next

        ' Convert polar coordinates to XY coordinates.
        For i As Integer = 0 To numberOfPoints
            Dim current As Double = (dataP(i) / numberOfPoints) * TwoPi
            dataX(i) = Math.Cos(current) * dataR(i)
            dataY(i) = Math.Sin(current) * dataR(i)
        Next

        xyPlot.PlotXY(dataX, dataY)
        xPlot.PlotY(dataX)
        yPlot.PlotY(dataY)
    End Sub
End Class

