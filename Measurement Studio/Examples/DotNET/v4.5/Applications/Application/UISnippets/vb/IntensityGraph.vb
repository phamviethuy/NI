Imports NationalInstruments.UI.WindowsForms
Imports System.Drawing.Imaging

NotInheritable Class SnipsIntensityGraph
    Inherits SnipsGraph
    Private intensityGraph As IntensityGraph
    Const Amplitude As Double = 5

    Public Sub New(ByVal iGraph As IntensityGraph)
        MyBase.New(iGraph)
        intensityGraph = iGraph
        AddHandler intensityGraph.AfterDrawPlotArea, AddressOf IntegerensityGraph_AfterDrawPlotArea
        ResetToDefaultState()
    End Sub

#Region "code snippets for NationalInstruments.UI.WindowsForms.IntensityGraph"

    ''' <summary>
    ''' Plots a 2D rectangluar array of values against the specified start and increment 
    ''' values, with an option to transpose the input array before plotting.  It is 
    ''' implemented in the IntensityGraph class. 
    ''' </summary>
    ''' <signature>Plot(Double[,], Double, Double, Double, Double, bool)</signature>
    ''' <ExampleMethod />
    Public Sub Plot_double2DArray_double_double_double_double_bool()
        ' The following example demonstrates plotting a 2-D rectangular array
        ' at an offset of 0 and and increment of 1 to an IntensityGraph object.
        Dim zData As Double(,)

        zData = GetIntensityData()
        ' plot data starting at index 0 of both x and y data
        ' sets.  Do not transpose the data being plotted.
        intensityGraph.Plot(zData, 0, 1, 0, 1, False)
    End Sub

    ''' <summary>
    ''' Plots a 2D rectangluar array of values by appending the array to the existing 
    ''' data in the vertical direction, with an option to transpose the input array 
    ''' before plotting.  It is implemented in the IntensityGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppend(Double[,], bool)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppend_double2DArray_bool()
        ' The following example demonstrates appending a 2-D array of data to
        ' and existing IntensityGraph plot.
        Dim zData As Double(,)

        zData = GetIntensityData()

        ' ensure we can append the data in the vertical direction
        If intensityGraph.Plots(0).HistoryCountX <> zData.GetLength(1) Then
            intensityGraph.ClearData()
        End If

        ' Append data vertically, but do not transpose the data
        intensityGraph.PlotYAppend(zData, False)
    End Sub

    ''' <summary>
    ''' Plots a 2D rectangluar array of values by appending the array to the existing 
    ''' data in the horizontal direction, with an option to transpose the input array 
    ''' before plotting.  It is implemented in the IntensityGraph class. 
    ''' </summary>
    ''' <signature>PlotXAppend(Double[,], bool)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXAppend_double2DArray_bool()
        ' The following example demonstrates appending a 2-D array of data to
        ' and existing IntensityGraph plot.
        Dim zData As Double(,)

        zData = GetIntensityData()

        ' ensure we can append the data in the horizontal direction
        If intensityGraph.Plots(0).HistoryCountY <> zData.GetLength(0) Then
            intensityGraph.ClearData()
        End If

        ' Append data horizontally, but do not transpose the data
        intensityGraph.PlotXAppend(zData, False)
    End Sub

    ''' <summary>
    ''' To run this method, you must first click the run snippet button, and then
    ''' click somewhere within in the plot area.  This method zooms around the 
    ''' specified data point with the specified zoom factor and reference plot.  
    ''' It is implemented in the IntensityGraph class. 
    ''' </summary>
    ''' <signature>ZoomAroundPoint(Single, IntensityPlot, Double, Double)</signature>
    ''' <OtherMethods>PointToVirtual</OtherMethods>
    ''' <ExampleMethod />
    <EventBased("PlotAreaMouseDown")> _
    Public Sub ZoomAroundPoint_float_IntensityPlot_double_double(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates zooming around a point on an IntensityGraph
        ' graph obtained from handling the PlotAreaMouseDown event.
        Dim virtualPoint As PointF
        Dim xPos As Double, yPos As Double
        Dim rangeMin As Double, rangeMax As Double
        Dim zoomFactor As Single = 1.25F

        ' only zoom in when the left mouse button is clicked
        If e.Button = MouseButtons.Left Then
            ' get the virtual position of the mouse click so that we can 
            ' map to data coordinates on the graph.
            virtualPoint = intensityGraph.PointToVirtual(e.Location)

            rangeMin = intensityGraph.XAxes(0).Range.Minimum
            rangeMax = intensityGraph.XAxes(0).Range.Maximum
            xPos = (rangeMax - rangeMin) * virtualPoint.X + rangeMin

            rangeMin = intensityGraph.YAxes(0).Range.Minimum
            rangeMax = intensityGraph.YAxes(0).Range.Maximum
            yPos = (rangeMax - rangeMin) * virtualPoint.Y + rangeMin

            intensityGraph.ZoomAroundPoint(zoomFactor, intensityGraph.Plots(0), xPos, yPos)
        End If
    End Sub

    ''' <summary>
    ''' Zooms to the region of the plot area specified by the x location, y 
    ''' location, region width, region height, and reference plot.  It is 
    ''' implemented in the IntensityGraph class. 
    ''' </summary>
    ''' <signature>ZoomXY(IntensityPlot, Double, Double, Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub ZoomXY_IntensityPlot_double_double_double_double()
        ' The following example demonstrates zooming to a region defined by 
        ' a rectangle.
        Dim leftXPoint As Double = 10.0
        Dim bottomYPoint As Double = 20.0
        Dim height As Double = 15.0
        Dim width As Double = 25.0

        intensityGraph.ZoomXY(intensityGraph.Plots(0), leftXPoint, bottomYPoint, width, height)
    End Sub

    ''' <summary>
    ''' Returns a IntensityGraphHitTestInfo that specifies where on the control the
    ''' specified point is located.  It is implemented in the IntensityGraph class. 
    ''' </summary>
    ''' <signature>HitTest(Integer, Integer)</signature>
    ''' <OtherMethods>
    ''' IntensityGraph.GetPlotAt(Integer, Integer, out Double, out Double, out Double, out Integer, out Integer)
    ''' IntensityGraph.GetXAxisAt(Integer, Integer)
    ''' IntensityGraph.GetYAxisAt(Integer, Integer)
    ''' IntensityGraph.GetColorScaleAt(Integer, Integer)
    ''' </OtherMethods>
    ''' <ExampleMethod />
    <EventBased("MouseDown")> _
    Public Sub IntensityGraph_HitTest_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates using the HitTest method to determine
        ' where a user clicked on a IntensityGraph object.
        Dim hitTestRegion As IntensityGraphHitTestInfo
        Dim plot As IntensityPlot
        Dim scale As ColorScale
        Dim index As Integer
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        hitTestRegion = intensityGraph.HitTest(e.X, e.Y)
        Select Case hitTestRegion
            Case IntensityGraphHitTestInfo.ColorScale
                index = 0
                scale = intensityGraph.GetColorScaleAt(e.X, e.Y)
                scale.CaptionBackColor = randomColor
                For Each entry As ColorMapEntry In scale.ColorMap
                    Debug.WriteLine(String.Format("Color map entry {0} has value {1} and color {2}", System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1), entry.Value, entry.Color.Name))
                Next
                Exit Select
            Case IntensityGraphHitTestInfo.Plot
                plot = intensityGraph.GetPlotAt(e.X, e.Y)
                Debug.WriteLine(String.Format("tooltips enabled: {0}", plot.ToolTipsEnabled))
                Debug.WriteLine(String.Format("interpolation enabled: {0}", plot.PixelInterpolation))
                Debug.WriteLine(String.Format("{0} x values", plot.HistoryCountX))
                Debug.WriteLine(String.Format("{0} y values", plot.HistoryCountY))
                Exit Select
            Case IntensityGraphHitTestInfo.PlotArea
                Debug.WriteLine("Plot area was clicked")
                Exit Select
            Case IntensityGraphHitTestInfo.XAxis
                Dim xAxis As IntensityXAxis = intensityGraph.GetXAxisAt(e.X, e.Y)
                xAxis.CaptionBackColor = randomColor
                Debug.WriteLine("X-Axis was clicked")
                Debug.WriteLine(String.Format("X-Axis range minimum: {0}, X-Axis range maximum: {1}", xAxis.Range.Minimum, xAxis.Range.Maximum))
                Exit Select
            Case IntensityGraphHitTestInfo.YAxis
                Dim yAxis As IntensityYAxis = intensityGraph.GetYAxisAt(e.X, e.Y)
                yAxis.CaptionBackColor = randomColor
                Debug.WriteLine("Y-Axis was clicked")
                Debug.WriteLine(String.Format("Y-Axis range minimum: {0}, Y-Axis range maximum: {1}", yAxis.Range.Minimum, yAxis.Range.Maximum))
                Exit Select
            Case IntensityGraphHitTestInfo.None
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
    Public Sub IntensityGraph_DrawOriginLines_ComponentDrawArgs(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        ' The following example demonstrates drawing a IntensityGrapyh object's origin lines
        ' to a .png image in response to the AfterDrawPlotArea event.
        Dim imageFileName As String = "IntensityGraphOriginLinesImage.png"
        Using bmp As New Bitmap(intensityGraph.PlotAreaBounds.Width, intensityGraph.PlotAreaBounds.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim args As New ComponentDrawArgs(g, New Rectangle(0, 0, bmp.Width, bmp.Height))

            intensityGraph.DrawOriginLines(args)
            bmp.Save(imageFileName, ImageFormat.Png)
        End Using
        Debug.WriteLine(String.Format("file {0} has been saved", imageFileName))
    End Sub

#End Region

#Region "helper methods for the SnipsIntensityGraph class"

    Private Sub IntegerensityGraph_AfterDrawPlotArea(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        If TypeOf sender Is IntensityGraph Then
            Dim graph As IntensityGraph = DirectCast(sender, IntensityGraph)
            Dim legendItems As New List(Of SnipsLegendItem)(graph.Plots.Count)
            For Each plot As IntensityPlot In graph.Plots
                Dim item As New SnipsLegendItem(plot, plot.ToString(), plot.GetZData().Length > 0)
                legendItems.Add(item)
            Next
            MainForm.Legend.SetItems(legendItems)
        End If
    End Sub

    Public Overrides Sub ResetToDefaultState()
        Dim inc As Double, divisions As Double = 6

        MyBase.ResetToDefaultState()

        intensityGraph.ColorScales(0).ColorMap.Clear()
        inc = Amplitude / divisions * 2
        Dim entries As ColorMapEntry() = {New ColorMapEntry(0.0, Color.Green), _
                                          New ColorMapEntry(inc, Color.YellowGreen), _
                                          New ColorMapEntry(inc * 2, Color.Yellow), _
                                          New ColorMapEntry(inc * 3, Color.Gold), _
                                          New ColorMapEntry(inc * 4, Color.Orange), _
                                          New ColorMapEntry(inc * 5, Color.OrangeRed), _
                                          New ColorMapEntry(inc * 6, Color.Red)}
        intensityGraph.ColorScales(0).LowColor = Color.Green
        intensityGraph.ColorScales(0).HighColor = Color.Red
        intensityGraph.ColorScales(0).ColorMap.AddRange(entries)

        Plot_double2DArray_double_double_double_double_bool()
    End Sub

    Private Function GetIntensityData() As Double(,)
        Dim data As Double(,) = New Double(50, 50) {}

        For i As Integer = 0 To data.GetLength(0) - 1
            For j As Integer = 0 To data.GetLength(1) - 1
                Dim randomizer As Double = RandNumberGenerator.NextDouble() / 5.0
                data(i, j) = Math.Sin((CDbl(j) + i) / (2.5 * Math.PI) + randomizer) * Amplitude + Amplitude
            Next
        Next
        Return data
    End Function

#End Region
End Class
