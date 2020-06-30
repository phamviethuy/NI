
Imports System.Drawing
Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WebForms

Partial Class DefaultAspx
    Inherits Page

    Protected Overloads Overrides Sub OnInit(ByVal e As EventArgs)
        AddHandler WaveformGraph.BeforeDrawPlot, AddressOf OnBeforeDrawPlot
        AddHandler WaveformGraph.AfterDrawPlot, AddressOf OnAfterDrawPlot
        AddHandler WaveformGraph.BeforeDrawPlotArea, AddressOf OnBeforeDrawPlotArea
    End Sub

    Protected Overloads Overrides Sub OnLoad(ByVal e As EventArgs)
        If Not IsPostBack Then
            Dim start As DateTime
            Dim finish As DateTime
            Dim increment As TimeSpan
            start = DateTime.Today
            finish = DateTime.Today + TimeSpan.FromHours(24)
            increment = TimeSpan.FromMinutes(30)
            Dim xAxis As XAxis = WaveformGraph.XAxes(0)
            Dim yAxis As YAxis = WaveformGraph.YAxes(0)
            xAxis.Mode = AxisMode.Fixed
            xAxis.AutoSpacing = False
            xAxis.MajorDivisions.Base = CType(DataConverter.Convert(start, GetType(Double)), Double)
            xAxis.MajorDivisions.Interval = CType(DataConverter.Convert(TimeSpan.FromHours(6), GetType(Double)), Double)
            xAxis.MinorDivisions.Interval = CType(DataConverter.Convert(TimeSpan.FromHours(1), GetType(Double)), Double)
            xAxis.Range = New Range(CType(DataConverter.Convert(start, GetType(Double)), Double), CType(DataConverter.Convert(finish, GetType(Double)), Double))
            yAxis.Mode = AxisMode.Fixed
            yAxis.Range = New Range(-1, 1)
            WaveformGraph.Plots(0).PlotY(GenerateData(), start, increment)
        End If
    End Sub

    Protected Sub OnAfterDrawPlot(ByVal sender As Object, ByVal e As AfterDrawXYPlotEventArgs)
        If listExtensibleStyles.SelectedValue.Equals("HighlightMinMax") Then
            Dim yMin As Double = Double.MaxValue
            Dim yMax As Double = Double.MinValue
            Dim xIndexMin As Double = 0
            Dim xIndexMax As Double = 0
            Dim currentY As Double = 0
            Dim currentX As Double = 0
            Dim i As Integer = 0
            While i < e.Plot.HistoryCount
                e.Plot.GetDataPoint(i, currentX, currentY)
                If currentY < yMin Then
                    yMin = currentY
                    xIndexMin = currentX
                End If
                If currentY > yMax Then
                    yMax = currentY
                    xIndexMax = currentX
                End If
                i = i + 1
            End While

            HighlightDataPoint(e, xIndexMin, yMin)
            HighlightDataPoint(e, xIndexMax, yMax)
        End If
    End Sub

    Protected Sub OnBeforeDrawPlot(ByVal sender As Object, ByVal e As BeforeDrawXYPlotEventArgs)
        If listExtensibleStyles.SelectedValue.Equals("HighlightIncDec") Then
            Dim plot As XYPlot = e.Plot
            Dim clippedXData As Double() = Nothing
            Dim clippedYData As Double() = Nothing
            plot.ClipDataPoints(clippedXData, clippedYData)
            Dim i As Integer = 0
            While i < clippedXData.Length - 1
                Dim x1 As Double = clippedXData(i)
                Dim x2 As Double = clippedXData(i + 1)
                Dim y1 As Double = clippedYData(i)
                Dim y2 As Double = clippedYData(i + 1)
                Dim point1 As PointF = plot.MapDataPoint(e.Bounds, x1, y1)
                Dim point2 As PointF = plot.MapDataPoint(e.Bounds, x1, y2)
                Dim point3 As PointF = plot.MapDataPoint(e.Bounds, x2, y2)
                Dim pen As Pen = Nothing
                If y2 > y1 Then
                    pen = Pens.LimeGreen
                Else
                    If y2 = y1 Then
                        pen = Pens.Yellow
                    Else
                        pen = Pens.Red
                    End If
                End If
                Dim g As Graphics = e.Graphics
                g.DrawLines(pen, New PointF() {point1, point2, point3})
                i = i + 1
            End While
            e.Cancel = True
        End If
    End Sub

    Protected Sub OnBeforeDrawPlotArea(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeDrawEventArgs)
        If listExtensibleStyles.SelectedValue.Equals("HighlightPlotArea") Then
            Dim segmentWidth As Integer = Convert.ToInt32(e.Bounds.Width / 4)
            Dim amBounds As Rectangle = New Rectangle(e.Bounds.X, e.Bounds.Y, segmentWidth, e.Bounds.Height)
            Dim pmBounds As Rectangle = New Rectangle(e.Bounds.X + (segmentWidth * 3), e.Bounds.Y, segmentWidth, e.Bounds.Height)
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
            e.Graphics.FillRectangle(Brushes.Navy, amBounds)
            e.Graphics.FillRectangle(Brushes.Navy, pmBounds)
        End If
    End Sub

    Private Function GenerateData() As Double()
        Dim data(49) As Double
        Dim rnd As Random = New Random()
        Dim i As Integer = 0
        While i < data.Length
            data(i) = (rnd.NextDouble() * Math.Sin(i / 3.15))
            i = i + 1
        End While
        Return data
    End Function

    Private Sub HighlightDataPoint(ByVal e As AfterDrawXYPlotEventArgs, ByVal x As Double, ByVal y As Double)
        Dim g As Graphics = e.Graphics
        Dim mappedPoint As PointF = e.Plot.MapDataPoint(e.Bounds, x, y)
        Dim bounds As Rectangle = New Rectangle(CType((mappedPoint.X - 8), Integer), CType((mappedPoint.Y - 8), Integer), 16, 16)
        Using brush As Brush = New SolidBrush(Color.FromArgb(128, Color.Red))
            g.FillEllipse(brush, bounds)
            g.DrawEllipse(Pens.Yellow, bounds)
        End Using
    End Sub
End Class
