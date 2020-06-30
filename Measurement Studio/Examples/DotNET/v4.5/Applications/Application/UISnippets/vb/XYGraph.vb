Imports System.Globalization
Imports System.Drawing.Imaging
Imports NationalInstruments.UI.WindowsForms

Class SnipsXYGraph
    Inherits SnipsGraph
    Private xyGraph As XYGraph
    Private xyPlot As XYPlot

    Const AnnotationXPos As Double = 6.0
    Const AnnotationYPos As Double = 2.0

    Public Sub New(ByVal graphToUse As XYGraph, ByVal PlotToUse As XYPlot)
        MyBase.New(graphToUse)
        xyGraph = graphToUse
        xyPlot = PlotToUse
    End Sub

#Region "Code snippets for NationalInstruments.UI.WindowsForms.XYGraph"

    ''' <summary>
    ''' To run this method, you must first click the run snippet button, and then
    ''' click somewhere within the plot area.  This method zooms around the 
    ''' specified data point with the specified zoom factor and reference plot.  
    ''' It is implemented in the XYGraph class. 
    ''' </summary>
    ''' <signature>ZoomAroundPoint(Single, XYPlot, Double, Double)</signature>
    ''' <OtherMethods>PointToVirtual</OtherMethods>
    ''' <ExampleMethod />
    <EventBased("PlotAreaMouseDown")> _
    Public Sub ZoomAroundPoint_float_XYPlot_double_double(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates zooming in by 125% around a point 
        ' on a XYGraph object.  The point to be zoomed around is determined 
        ' by handling the PlotAreaMouseDown event.
        Dim virtualPoint As PointF
        Dim xPos As Double, yPos As Double
        Dim rangeMin As Double, rangeMax As Double
        Dim zoomFactor As Single = 1.25F

        ' only zoom in when the left mouse button is clicked
        If e.Button = MouseButtons.Left Then
            ' get the virtual position of the mouse click so that we can 
            ' map to data coordinates on the graph.
            virtualPoint = xyGraph.PointToVirtual(e.Location)

            rangeMin = xyGraph.XAxes(0).Range.Minimum
            rangeMax = xyGraph.XAxes(0).Range.Maximum
            xPos = (rangeMax - rangeMin) * virtualPoint.X + rangeMin

            rangeMin = xyGraph.YAxes(0).Range.Minimum
            rangeMax = xyGraph.YAxes(0).Range.Maximum
            yPos = (rangeMax - rangeMin) * virtualPoint.Y + rangeMin

            xyGraph.ZoomAroundPoint(zoomFactor, xyPlot, xPos, yPos)
        End If
    End Sub

    ''' <summary>
    ''' Returns a XYGraphHitTestInfo that specifies where on the control the given
    ''' point is located.  It is implemented in the XYGraph class. To run this method,
    ''' you must first click the run snippet button, and then click somewhere inside 
    ''' the graph area. 
    ''' </summary>
    ''' <signature>HitTest(Integer, Integer)</signature>
    ''' <OtherMethods>
    ''' XYGraph.GetAnnotationAt(Integer, Integer)
    ''' XYGraph.GetCursorAt(Integer, Integer)
    ''' XYGraph.GetErrorBandAt(Integer, Integer, out Double, out Double, out Double)
    ''' XYGraph.GetPlotAt(Integer, Integer, out Double, out Double, out Double)
    ''' XYGraph.GetXAxisAt(Integer, Integer)
    ''' XYGraph.GetYAxisAt(Integer, Integer)
    ''' </OtherMethods>
    ''' <ExampleMethod />
    <EventBased("MouseDown")> _
    Public Sub XYGraph_HitTest_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates using the HitTest method to determine
        ' where a user clicked on a XYGraph object.
        Dim hitTestRegion As XYGraphHitTestInfo
        Dim plot As XYPlot
        Dim index As Integer
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        hitTestRegion = xyGraph.HitTest(e.X, e.Y)
        Select Case hitTestRegion
            Case XYGraphHitTestInfo.Annotation
                Dim annot As XYPointAnnotation = TryCast(xyGraph.GetAnnotationAt(e.X, e.Y), XYPointAnnotation)
                annot.ShapeFillColor = randomColor
                Debug.WriteLine("Annotation selected")
                Debug.WriteLine(String.Format("Annotation X position: {0}, Annotation Y position {1}", annot.XPosition.ToString(), annot.YPosition.ToString()))
                Exit Select
            Case XYGraphHitTestInfo.Cursor
                Dim cursor As XYCursor = xyGraph.GetCursorAt(e.X, e.Y)
                cursor.Color = randomColor
                Debug.WriteLine("Cursor selected")
                Debug.WriteLine(String.Format("Cursor X position: {0}, Cursor Y position: {1}", cursor.XPosition.ToString(), cursor.YPosition.ToString()))
                Exit Select
            Case XYGraphHitTestInfo.ErrorBand
                Dim xVal As Double, yVal As Double, xErrData As Double, yErrData As Double
                Dim xErrString As String, yErrString As String

                plot = xyGraph.GetErrorBandAt(e.X, e.Y, xErrData, yErrData, index)
                plot.LineColor = randomColor
                xVal = CDbl(plot.GetXData().GetValue(index))
                yVal = CDbl(plot.GetYData().GetValue(index))

                If xErrData > xVal Then
                    xErrString = "upper bound is " & xErrData.ToString(CultureInfo.CurrentCulture)
                ElseIf xErrData < xVal Then
                    xErrString = "lower bound is " & xErrData.ToString(CultureInfo.CurrentCulture)
                Else
                    xErrString = "is not set"
                End If

                If yErrData > yVal Then
                    yErrString = "upper bound is " & yErrData.ToString(CultureInfo.CurrentCulture)
                ElseIf yErrData < yVal Then
                    yErrString = "lower bound is " & yErrData.ToString(CultureInfo.CurrentCulture)
                Else
                    yErrString = "is not set"
                End If

                Debug.WriteLine(String.Format("The x error data {0}{1}The y error data {2}", xErrString, Environment.NewLine, yErrString))
                Exit Select
            Case XYGraphHitTestInfo.Plot
                Dim xData As Double, yData As Double

                plot = xyGraph.GetPlotAt(e.X, e.Y, xData, yData, index)
                plot.LineColor = randomColor
                Debug.WriteLine(String.Format("Data point {0} is located at ({1}, {2})", index, xData, yData))
                Exit Select
            Case XYGraphHitTestInfo.PlotArea
                Debug.WriteLine("Plot area was clicked")
                Exit Select
            Case XYGraphHitTestInfo.XAxis
                Dim xAxis As XAxis = xyGraph.GetXAxisAt(e.X, e.Y)
                xAxis.CaptionBackColor = randomColor
                Debug.WriteLine("XAxis Selected")
                Debug.WriteLine(String.Format("X-Axis range minimum: {0}, X-Axis range maximum: {1}", xAxis.Range.Minimum, xAxis.Range.Maximum))
                Exit Select
            Case XYGraphHitTestInfo.YAxis
                Dim yAxis As YAxis = xyGraph.GetYAxisAt(e.X, e.Y)
                yAxis.CaptionBackColor = randomColor
                Debug.WriteLine("Y-Axis was clicked")
                Debug.WriteLine(String.Format("Y-Axis range minimum: {0}, Y-Axis range maximum: {1}", yAxis.Range.Minimum, yAxis.Range.Maximum))
                Exit Select
            Case XYGraphHitTestInfo.None
                Debug.WriteLine("Unknown graph area was clicked")
                Exit Select
        End Select
    End Sub

    ''' <summary>
    ''' Draws the origin lines in the plot area of the graph.  For this method
    ''' to draw anything, origin lines must be visible on the plot.
    ''' </summary>
    ''' <signature>DrawOriginLines(ComponentDrawArgs)</signature>
    ''' <ExampleMethod />
    <EventBased("AfterDrawPlotArea", "Invalidate")> _
    Public Sub XYGraph_DrawOriginLines_ComponentDrawArgs(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        ' The following example demonstrates drawing a XYGraph object's origin lines
        ' to a .png image in response to the AfterDrawPlotArea event.
        Dim imageFileName As String = "XYGraphOriginLinesImage.png"
        Using bmp As New Bitmap(xyGraph.PlotAreaBounds.Width, xyGraph.PlotAreaBounds.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim args As New ComponentDrawArgs(g, New Rectangle(0, 0, bmp.Width, bmp.Height))

            xyGraph.DrawOriginLines(args)
            bmp.Save(imageFileName, ImageFormat.Png)
        End Using
        Debug.WriteLine(String.Format("file {0} has been saved", imageFileName))
    End Sub

    ''' <summary>
    ''' Zooms to the region of the plot area specified by the x location, y 
    ''' location, region width, region height, and reference plot.  It is 
    ''' implemented in the XYGraph class. 
    ''' </summary>
    ''' <signature>ZoomXY(XYPlot, Double, Double, Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub ZoomXY_XYPlot_double_double_double_double()
        ' The following example demonstrates zooming to a specifically sized
        ' rectangle on a XYGraph plot.
        Dim leftXPoint As Double = 2.0
        Dim bottomYPoint As Double = 3.0
        Dim height As Double = 2.0
        Dim width As Double = 3.0

        xyGraph.ZoomXY(xyPlot, leftXPoint, bottomYPoint, width, height)
    End Sub

#End Region

#Region "helper methods for the SnipsXYGraph class"

    Public Overrides Sub ResetToDefaultState()
        MyBase.ResetToDefaultState()

        xyGraph.Annotations.Clear()
        CreateSampleAnnotation()

        xyGraph.Cursors.Clear()
        CreateSampleCursor()
    End Sub

    ''' <summary>
    ''' helper function to create an annotation on the XY graph
    ''' </summary>
    Private Sub CreateSampleAnnotation()
        'create an annotation
        Dim graphAnnotation As New XYPointAnnotation()

        graphAnnotation.Caption = "Sample Annotation"
        graphAnnotation.Visible = True
        graphAnnotation.ShapeFillColor = Color.Aqua
        graphAnnotation.XAxis = xyGraph.XAxes(0)
        graphAnnotation.YAxis = xyGraph.YAxes(0)
        ' Create an annotation in the middle of the graph
        graphAnnotation.SetPosition(AnnotationXPos, AnnotationYPos)
        xyGraph.Annotations.Add(graphAnnotation)
    End Sub

    ''' <summary>
    ''' helper function to create a cursor on the XY graph
    ''' </summary>
    Private Sub CreateSampleCursor()
        Dim cursor As New XYCursor(xyPlot)

        cursor.VerticalCrosshairMode = CursorCrosshairMode.FullLength
        cursor.HorizontalCrosshairMode = CursorCrosshairMode.FullLength
        cursor.SnapMode = CursorSnapMode.ToPlot
        cursor.MoveNext()
        cursor.Color = Color.Maroon
        xyGraph.Cursors.Add(cursor)
    End Sub

#End Region
End Class