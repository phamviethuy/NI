Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        Dim start As DateTime
        Dim endTime As DateTime
        Dim increment As TimeSpan

        'This call is required by the Windows Form Designer.
        InitializeComponent()                

        start = DateTime.Today()
        endTime = DateTime.Today().Add(TimeSpan.FromHours(24))
        increment = TimeSpan.FromMinutes(30)

        xAxis.Mode = AxisMode.Fixed
        xAxis.AutoSpacing = False        

        xAxis.MajorDivisions.Base = CDbl(DataConverter.Convert(start, Type.GetType("System.Double")))        
        xAxis.MajorDivisions.Interval = CDbl(DataConverter.Convert(TimeSpan.FromHours(6), Type.GetType("System.Double")))
        xAxis.MinorDivisions.Interval = CDbl(DataConverter.Convert(TimeSpan.FromHours(1), Type.GetType("System.Double")))
        xAxis.Range = New Range(CDbl(DataConverter.Convert(start, Type.GetType("System.Double"))), CDbl(DataConverter.Convert(endTime, Type.GetType("System.Double"))))

        yAxis.Mode = AxisMode.Fixed
        yAxis.Range = New Range(-1.0, 1.0)

        plotWaveformPlot.PlotY(GenerateData(), start, increment)        

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
    Friend WithEvents plotWaveformPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents extensWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents extensibleStylesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents backgroundRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents incDecRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents minMaxRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents defaultRadioButton As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.plotWaveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.extensWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.extensibleStylesGroupBox = New System.Windows.Forms.GroupBox
        Me.backgroundRadioButton = New System.Windows.Forms.RadioButton
        Me.incDecRadioButton = New System.Windows.Forms.RadioButton
        Me.minMaxRadioButton = New System.Windows.Forms.RadioButton
        Me.defaultRadioButton = New System.Windows.Forms.RadioButton
        CType(Me.extensWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.extensibleStylesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'plotWaveformPlot
        '
        Me.plotWaveformPlot.XAxis = Me.xAxis
        Me.plotWaveformPlot.YAxis = Me.yAxis
        '
        'xAxis
        '
        Me.xAxis.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "h:mm:ss tt")
        Me.xAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact
        '
        'yAxis
        '
        Me.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.yAxis.Range = New NationalInstruments.UI.Range(-1.5, 1.5)
        '
        'extensWaveformGraph
        '
        Me.extensWaveformGraph.Location = New System.Drawing.Point(4, 24)
        Me.extensWaveformGraph.Name = "extensWaveformGraph"
        Me.extensWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.plotWaveformPlot})
        Me.extensWaveformGraph.Size = New System.Drawing.Size(632, 240)
        Me.extensWaveformGraph.TabIndex = 4
        Me.extensWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.extensWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'extensibleStylesGroupBox
        '
        Me.extensibleStylesGroupBox.Controls.Add(Me.backgroundRadioButton)
        Me.extensibleStylesGroupBox.Controls.Add(Me.incDecRadioButton)
        Me.extensibleStylesGroupBox.Controls.Add(Me.minMaxRadioButton)
        Me.extensibleStylesGroupBox.Controls.Add(Me.defaultRadioButton)
        Me.extensibleStylesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.extensibleStylesGroupBox.Location = New System.Drawing.Point(4, 279)
        Me.extensibleStylesGroupBox.Name = "extensibleStylesGroupBox"
        Me.extensibleStylesGroupBox.Size = New System.Drawing.Size(632, 152)
        Me.extensibleStylesGroupBox.TabIndex = 3
        Me.extensibleStylesGroupBox.TabStop = False
        Me.extensibleStylesGroupBox.Text = "Extensible Styles"
        '
        'backgroundRadioButton
        '
        Me.backgroundRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.backgroundRadioButton.Location = New System.Drawing.Point(8, 112)
        Me.backgroundRadioButton.Name = "backgroundRadioButton"
        Me.backgroundRadioButton.Size = New System.Drawing.Size(608, 32)
        Me.backgroundRadioButton.TabIndex = 3
        Me.backgroundRadioButton.Text = "Highlight plot area background regions via custom pre-plot area drawing"
        '
        'incDecRadioButton
        '
        Me.incDecRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.incDecRadioButton.Location = New System.Drawing.Point(8, 80)
        Me.incDecRadioButton.Name = "incDecRadioButton"
        Me.incDecRadioButton.Size = New System.Drawing.Size(608, 32)
        Me.incDecRadioButton.TabIndex = 2
        Me.incDecRadioButton.Text = "Highlight increasing/decreasing values via custom pre-plot drawing"
        '
        'minMaxRadioButton
        '
        Me.minMaxRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.minMaxRadioButton.Location = New System.Drawing.Point(8, 48)
        Me.minMaxRadioButton.Name = "minMaxRadioButton"
        Me.minMaxRadioButton.Size = New System.Drawing.Size(608, 32)
        Me.minMaxRadioButton.TabIndex = 1
        Me.minMaxRadioButton.Text = "Highlight min/max via custom post-plot drawing"
        '
        'defaultRadioButton
        '
        Me.defaultRadioButton.Checked = True
        Me.defaultRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultRadioButton.Location = New System.Drawing.Point(8, 16)
        Me.defaultRadioButton.Name = "defaultRadioButton"
        Me.defaultRadioButton.Size = New System.Drawing.Size(608, 32)
        Me.defaultRadioButton.TabIndex = 0
        Me.defaultRadioButton.TabStop = True
        Me.defaultRadioButton.Text = "Default"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(648, 454)
        Me.Controls.Add(Me.extensWaveformGraph)
        Me.Controls.Add(Me.extensibleStylesGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Extensibility"
        CType(Me.extensWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.extensibleStylesGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub extensWaveformGraph_AfterDrawPlot(ByVal sender As Object, ByVal e As NationalInstruments.UI.AfterDrawXYPlotEventArgs) Handles extensWaveformGraph.AfterDrawPlot

        If (minMaxRadioButton.Checked) Then

            Dim yMin As Double = Double.MaxValue
            Dim yMax As Double = Double.MinValue
            Dim xIndexMin As Double = 0
            Dim xIndexMax As Double = 0
            Dim currentY As Double = 0
            Dim currentX As Double = 0

            For i As Integer = 0 To e.Plot.HistoryCount - 1
                e.Plot.GetDataPoint(i, currentX, currentY)
                If (currentY < yMin) Then
                    yMin = currentY
                    xIndexMin = currentX
                End If
                If (currentY > yMax) Then
                    yMax = currentY
                    xIndexMax = currentX
                End If
            Next i

            HighlightDataPoint(e, xIndexMin, yMin)
            HighlightDataPoint(e, xIndexMax, yMax)
        End If
    End Sub

    Private Sub extensWaveformGraph_BeforeDrawPlot(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeDrawXYPlotEventArgs) Handles extensWaveformGraph.BeforeDrawPlot
        If (incDecRadioButton.Checked) Then
            'Clip data, iterate through clipped data, map, and draw.
            Dim plot As XYPlot = e.Plot
            Dim clippedXData() As Double = Nothing
            Dim clippedYData() As Double = Nothing
            plot.ClipDataPoints(clippedXData, clippedYData)

            For i As Integer = 0 To clippedXData.Length - 2
                Dim x1 As Double = clippedXData(i)
                Dim x2 As Double = clippedXData(i + 1)
                Dim y1 As Double = clippedYData(i)
                Dim y2 As Double = clippedYData(i + 1)
                Dim point1 As PointF = plot.MapDataPoint(e.Bounds, x1, y1)
                Dim point2 As PointF = plot.MapDataPoint(e.Bounds, x1, y2)
                Dim point3 As PointF = plot.MapDataPoint(e.Bounds, x2, y2)
                Dim pen As Pen = Nothing

                If (y2 > y1) Then
                    pen = Pens.LimeGreen
                ElseIf (y2 = y1) Then
                    pen = Pens.Yellow
                Else
                    pen = Pens.Red
                End If

                Dim g As Graphics = e.Graphics
                Dim points As PointF() = New PointF() {point1, point2, point3}
                g.DrawLines(pen, points)
            Next i
            e.Cancel = True
        End If
    End Sub

    Private Sub extensWaveformGraph_BeforeDrawPlotArea(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeDrawEventArgs) Handles extensWaveformGraph.BeforeDrawPlotArea

        If (backgroundRadioButton.Checked) Then
            Dim segmentWidth As Double = e.Bounds.Width / 4
            Dim amBounds As RectangleF = New RectangleF(e.Bounds.X, e.Bounds.Y, segmentWidth, e.Bounds.Height)
            Dim pmBounds As RectangleF = New RectangleF(e.Bounds.X + (segmentWidth * 3), e.Bounds.Y, segmentWidth, e.Bounds.Height)
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
            e.Graphics.FillRectangle(Brushes.Navy, amBounds)
            e.Graphics.FillRectangle(Brushes.Navy, pmBounds)
        End If

    End Sub

    Private Shared Function GenerateData() As Double()
        Dim data(49) As Double
        Dim rnd As Random = New Random
        For i As Integer = 0 To 49
            data(i) = rnd.NextDouble() * Math.Sin(i / Math.PI)
        Next
        Return data
    End Function

    Private Shared Sub HighlightDataPoint(ByVal e As AfterDrawXYPlotEventArgs, ByVal x As Double, ByVal y As Double)
        Dim g As Graphics = e.Graphics
        Dim mappedPoint As PointF = e.Plot.MapDataPoint(e.Bounds, x, y)
        Dim bounds As Rectangle = New Rectangle(CInt(mappedPoint.X - 8), CInt(mappedPoint.Y - 8), 16, 16)
        Dim brush As Brush = New SolidBrush(Color.FromArgb(128, Color.Red))
        g.FillEllipse(brush, bounds)
        g.DrawEllipse(Pens.Yellow, bounds)
        brush.Dispose()
    End Sub


    Private Sub defaultRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles defaultRadioButton.CheckedChanged
        extensWaveformGraph.Invalidate()
    End Sub

    Private Sub minMaxRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minMaxRadioButton.CheckedChanged
        extensWaveformGraph.Invalidate()
    End Sub

    Private Sub incDecRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles incDecRadioButton.CheckedChanged
        extensWaveformGraph.Invalidate()
    End Sub

    Private Sub backgroundRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backgroundRadioButton.CheckedChanged
        extensWaveformGraph.Invalidate()
    End Sub
End Class
