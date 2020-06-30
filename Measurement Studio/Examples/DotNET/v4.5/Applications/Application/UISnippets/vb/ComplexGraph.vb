Imports System.Globalization
Imports System.Drawing.Imaging
Imports NationalInstruments.UI.WindowsForms

NotInheritable Class SnipsComplexGraph
    Inherits SnipsGraph
    Private cxGraph As ComplexGraph
    Const RealPos As Double = 2.0
    Const ImgPos As Double = 2.0

    Public Sub New(ByVal complexGraph As ComplexGraph)
        MyBase.New(complexGraph)
        cxGraph = complexGraph
        ResetToDefaultState()
        AddHandler cxGraph.PlotsChanged, AddressOf cxGraph_PlotsChanged
        AddHandler cxGraph.AfterDrawPlotArea, AddressOf cxGraph_AfterDrawPlotArea
    End Sub

#Region "Code Snippets for NationalInstruments.UI.WindowsForms.ComplexGraph"

    ''' <summary>
    ''' Returns a ComplexGraphHitTestInfo that specifies where on the control the given
    ''' point is located.  It is implemented in the ComplexGraph class. To run this method,
    ''' you must first click the run snippet button, and then click somewhere inside 
    ''' the graph area. 
    ''' </summary>
    ''' <signature>HitTest(Integer, Integer)</signature>
    ''' <OtherMethods>
    ''' ComplexGraph.GetAnnotationAt(Integer, Integer)
    ''' ComplexGraph.GetCursorAt(Integer, Integer)
    ''' ComplexGraph.GetErrorBandAt(Integer, Integer, out Double, out Double, out Double)
    ''' ComplexGraph.GetPlotAt(Integer, Integer, out Double, out Double, out Double)
    ''' ComplexGraph.GetXAxisAt(Integer, Integer)
    ''' ComplexGraph.GetYAxisAt(Integer, Integer)
    ''' </OtherMethods>
    ''' <ExampleMethod />
    <EventBased("MouseDown")> _
    Public Sub ComplexGraph_HitTest_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates using the HitTest method to determine
        ' where a user clicked on a ComplexGraph object.
        Dim plot As ComplexPlot
        Dim index As Integer
        Dim plotData As ComplexDouble
        Dim hitTestRegion As ComplexGraphHitTestInfo
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        hitTestRegion = cxGraph.HitTest(e.X, e.Y)
        Select Case hitTestRegion
            Case ComplexGraphHitTestInfo.Annotation
                Dim annot As ComplexPointAnnotation = TryCast(cxGraph.GetAnnotationAt(e.X, e.Y), ComplexPointAnnotation)
                annot.ShapeFillColor = randomColor
                Debug.WriteLine("Annotation selected")
                Debug.WriteLine(String.Format("Annotation real position: {0}, annotation imaginary position {1}", annot.Position.Real.ToString(), annot.Position.Imaginary.ToString()))
                Exit Select
            Case ComplexGraphHitTestInfo.Cursor
                Dim cursor As ComplexCursor = cxGraph.GetCursorAt(e.X, e.Y)
                cursor.Color = randomColor
                Debug.WriteLine("Cursor selected")
                Debug.WriteLine(String.Format("Cursor real position: {0}, cursor imaginary position: {1}", cursor.Position.Real.ToString(), cursor.Position.Imaginary.ToString()))
                Exit Select
            Case ComplexGraphHitTestInfo.ErrorBand
                Dim errData As ComplexDouble
                Dim realErrString As String, imgErrString As String

                plot = cxGraph.GetErrorBandAt(e.X, e.Y, errData, index)
                plot.LineColor = randomColor
                plotData = plot.GetDataPoint(index)

                If errData.Real > plotData.Real Then
                    realErrString = "upper bound is " & errData.Real.ToString(CultureInfo.CurrentCulture)
                ElseIf errData.Real < plotData.Real Then
                    realErrString = "lower bound is " & errData.Real.ToString(CultureInfo.CurrentCulture)
                Else
                    realErrString = "is not set"
                End If

                If errData.Imaginary > plotData.Imaginary Then
                    imgErrString = "upper bound is " & errData.Imaginary.ToString(CultureInfo.CurrentCulture) & "i"
                ElseIf errData.Imaginary < plotData.Imaginary Then
                    imgErrString = "lower bound is " & errData.Imaginary.ToString(CultureInfo.CurrentCulture) & "i"
                Else
                    imgErrString = "is not set"
                End If

                Debug.WriteLine(String.Format("The real error data {0}{1}The imaginary error data {2}", realErrString, Environment.NewLine, imgErrString))
                Exit Select
            Case ComplexGraphHitTestInfo.Plot
                plot = cxGraph.GetPlotAt(e.X, e.Y, plotData, index)
                plot.LineColor = randomColor
                Debug.WriteLine(String.Format("Data point {0} is located at {1} + {2}i", index, plotData.Real, plotData.Imaginary))
                Exit Select
            Case ComplexGraphHitTestInfo.PlotArea
                Debug.WriteLine("Plot area was clicked")
                Exit Select
            Case ComplexGraphHitTestInfo.XAxis
                Dim xAxis As ComplexXAxis = cxGraph.GetXAxisAt(e.X, e.Y)
                xAxis.CaptionBackColor = randomColor
                Debug.WriteLine("Real axis Selected")
                Debug.WriteLine(String.Format("Real Axis range minimum: {0}, real axis range maximum: {1}", xAxis.Range.Minimum.ToString(), xAxis.Range.Maximum.ToString()))
                Exit Select
            Case ComplexGraphHitTestInfo.YAxis
                Dim yAxis As ComplexYAxis = cxGraph.GetYAxisAt(e.X, e.Y)
                yAxis.CaptionBackColor = randomColor
                Debug.WriteLine("Imaginary Selected")
                Debug.WriteLine(String.Format("Imaginary axis range minimum: {0}, Imaginary axis range maximum: {1}", yAxis.Range.Minimum.ToString(), yAxis.Range.Maximum.ToString()))
                Exit Select
            Case ComplexGraphHitTestInfo.None
                Debug.WriteLine("Unknown graph area clicked")
                Exit Select
        End Select
    End Sub

    ''' <summary>
    ''' To run this method, you must first click the run snippet button, and then
    ''' click on an annotation in the plot area.  This method gets the annotation 
    ''' at the specified location. It is implemented in the ComplexGraph class. 
    ''' </summary>
    ''' <signature>GetAnnotationAt(Integer, Integer)</signature>
    ''' <ExampleMethod />
    <EventBased("PlotAreaMouseDown")> _
    Public Sub ComplexGraph_GetAnnotationAt_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates determining which annotation a user
        ' clicked on by calling the GetAnnotationAt method of the ComplexGraph class
        ' in response to the PlotAreaMouseDown event.
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        Dim annot As ComplexPointAnnotation = DirectCast(cxGraph.GetAnnotationAt(e.X, e.Y), ComplexPointAnnotation)

        If annot IsNot Nothing Then
            annot.ShapeFillColor = randomColor
            annot.ShapeLineColor = randomColor
            annot.ArrowColor = randomColor
        Else
            Debug.WriteLine("There was no annotation at the selected location")
        End If
    End Sub

    ''' <summary>
    ''' To run this method, you must first click the run snippet button, and then
    ''' click on cursor in the plot area.  This method gets the cursor 
    ''' at the specified location. It is implemented in the ComplexGraph class. 
    ''' </summary>
    ''' <signature>GetCursorAt(Integer, Integer)</signature>
    ''' <ExampleMethod />
    <EventBased("PlotAreaMouseDown")> _
    Public Sub ComplexGraph_GetCursorAt_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates determinng which cursor a user
        ' clicked on by calling the GetCursorAt method of the ComplexGraph class
        ' in response to the PlotAreaMouseDown event.
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        Dim cursor As ComplexCursor = DirectCast(cxGraph.GetCursorAt(e.X, e.Y), ComplexCursor)

        If cursor IsNot Nothing Then
            cursor.Color = randomColor
            cursor.MoveNext()
        Else
            Debug.WriteLine("There was no cursor at the selected location")
        End If
    End Sub

    ''' <summary>
    ''' Draws the origin lines in the plot area of the graph.  For this method
    ''' to draw anything, origin lines must be visible on the plot.
    ''' </summary>
    ''' <signature>DrawOriginLines(ComponentDrawArgs)</signature>
    ''' <ExampleMethod />
    <EventBased("AfterDrawPlotArea", "Invalidate")> _
    Public Sub ComplexGraph_DrawOriginLines_ComponentDrawArgs(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        ' The following example demonstrates drawing a ComplexGraph object's origin lines
        ' to a .png image in response to the AfterDrawPlotArea event.
        Dim imageFileName As String = "ComplexGraphOriginLinesImage.png"
        Using bmp As New Bitmap(cxGraph.PlotAreaBounds.Width, cxGraph.PlotAreaBounds.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim args As New ComponentDrawArgs(g, New Rectangle(0, 0, bmp.Width, bmp.Height))

            cxGraph.DrawOriginLines(args)
            bmp.Save(imageFileName, ImageFormat.Png)
        End Using
        Debug.WriteLine(String.Format("file {0} has been saved", imageFileName))
    End Sub

    ''' <summary>
    ''' Zooms around the specified data point with the specified zoom factor and 
    ''' reference plot. It is implemented in the ComplexGraph class. 
    ''' </summary>
    ''' <signature>ZoomAroundPoint(Single, ComplexPlot, ComplexDouble)</signature>
    ''' <ExampleMethod />
    <EventBased("PlotAreaMouseDown")> _
    Public Sub ZoomAroundPoint_float_ComplexPlot_ComplexDouble(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates zooming in by 125% around a point 
        ' on a ComplexGraph object.  The point to be zoomed around is determined 
        ' by handling the PlotAreaMouseDown event.
        Dim zoomFactor As Single = 1.25F
        Dim dataPoint As New ComplexDouble()
        Dim virtualPoint As PointF
        Dim rangeMin As Double, rangeMax As Double

        ' only zoom in when the left mouse button is clicked
        If e.Button = MouseButtons.Left Then
            ' get the virtual position of the mouse click so that we can 
            ' map to data coordinates on the graph.
            virtualPoint = cxGraph.PointToVirtual(e.Location)

            rangeMin = cxGraph.XAxes(0).Range.Minimum
            rangeMax = cxGraph.XAxes(0).Range.Maximum
            dataPoint.Real = (rangeMax - rangeMin) * virtualPoint.X + rangeMin

            rangeMin = cxGraph.YAxes(0).Range.Minimum
            rangeMax = cxGraph.YAxes(0).Range.Maximum
            dataPoint.Imaginary = (rangeMax - rangeMin) * virtualPoint.Y + rangeMin

            cxGraph.ZoomAroundPoint(zoomFactor, cxGraph.Plots(0), dataPoint)
        End If
    End Sub

    ''' <summary>
    ''' Plots the imaginary part against the real part of a ComplexDouble data value.  
    ''' It is implemented in the ComplexGraph class.
    ''' </summary>
    ''' <signature>PlotComplex(ComplexDouble)</signature>
    ''' <ExampleMethod />
    Public Sub PlotComplex_ComplexDouble()
        ' The following example demonstrates plotting a single ComplexDouble
        ' data point on a ComplexGraph.
        Dim data As New ComplexDouble()

        data.Real = RandNumberGenerator.NextDouble() * 3
        data.Imaginary = RandNumberGenerator.NextDouble() * 3
        cxGraph.PlotComplex(data)
    End Sub

    ''' <summary>
    ''' Plots the imaginary parts against the real parts of an array of 
    ''' ComplexDouble data values. It is implemented in the ComplexGraph class.
    ''' </summary>
    ''' <signature>PlotComplex(ComplexDouble[])</signature>
    ''' <ExampleMethod />
    Public Sub PlotComplex_ComplexDoubleArray()
        ' The following example demonstrates plotting an array of ComplexDouble
        ' data points on a ComplexGraph.
        Dim data As ComplexDouble()

        ' get some complex data
        data = GenerateComplexData()
        cxGraph.PlotComplex(data)
    End Sub

    ''' <summary>
    ''' Plots the imaginary parts against the real parts of a subset of an array of 
    ''' ComplexDouble data values.  It is implemented in the ComplexGraph class.
    ''' </summary>
    ''' <signature>PlotComplex(ComplexDouble[], Integer, Integer)</signature>
    ''' <ExampleMethod />
    Public Sub PlotComplex_ComplexDoubleArray_int_int()
        ' The following example demonstrates plotting an array of ComplexDouble
        ' data points by specifying the starting array index and the number of 
        ' elements to plot.
        Dim data As ComplexDouble()
        Dim start As Integer = 3
        Dim len As Integer = 50

        ' get some DigitalWaveform data
        data = GenerateComplexData()
        ' plot 10 ComplexDouble values starting at the third index
        cxGraph.PlotComplex(data, start, len)
    End Sub

    ''' <summary>
    ''' Plots the imaginary part against the real part of a ComplexDouble 
    ''' data value by appending to the existing data.  It is implemented 
    ''' in the ComplexGraph class.
    ''' </summary>
    ''' <signature>PlotComplexAppend(ComplexDouble)</signature>
    ''' <ExampleMethod />
    Public Sub PlotComplexAppend_ComplexDouble()
        ' The following example demonstrates appending a ComplexDouble data
        ' point to an existing ComplexGraph plot.
        Dim data As New ComplexDouble()

        data.Real = RandNumberGenerator.NextDouble() * 3
        data.Imaginary = RandNumberGenerator.NextDouble() * 3
        cxGraph.PlotComplexAppend(data)
    End Sub

    ''' <summary>
    ''' Plots the imaginary parts against the real parts of an array of 
    ''' ComplexDouble data values by appending to the existing data.  It 
    ''' is implemented in the ComplexGraph class.
    ''' </summary>
    ''' <signature>PlotComplexAppend(ComplexDouble[])</signature>
    ''' <ExampleMethod />
    Public Sub PlotComplexAppend_ComplexDoubleArray()
        ' The following example demonstrates appending an array of ComplexDouble
        ' data points to an existing ComplexGraph plot.
        Dim data As ComplexDouble()

        ' get some DigitalWaveform data
        data = GenerateComplexData()
        cxGraph.PlotComplexAppend(data)
    End Sub

    ''' <summary>
    ''' Plots the imaginary parts against the real parts of a subset of an 
    ''' array of ComplexDouble data values by appending to existing data.  
    ''' It is implemented in the ComplexGraph class.
    ''' </summary>
    ''' <signature>PlotComplexAppend(ComplexDouble[], Integer, Integer)</signature>
    ''' <ExampleMethod />
    Public Sub PlotComplexAppend_ComplexDoubleArray_int_int()
        ' The following example demonstrates appending an array of ComplexDouble
        ' data points to an existing ComplexGraph plot by specifying the starting 
        ' array index and the number of elements to plot.
        Dim data As ComplexDouble()
        Dim start As Integer = 3
        Dim len As Integer = 50

        ' get some DigitalWaveform data
        data = GenerateComplexData()
        ' plot 10 ComplexDouble values starting at the third index
        cxGraph.PlotComplexAppend(data, start, len)
    End Sub

    ''' <summary>
    ''' Zooms to the region of the plot area specified by the data value, region 
    ''' width, region height, and reference plot.  It is implemented in the 
    ''' ComplexGraph class. 
    ''' </summary>
    ''' <signature>ZoomXY(ComplexPlot, ComplexDouble, Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub ZoomXY_ComplexPlot_ComplexDouble_double_double()
        ' The following example demonstrates zooming to a specifically sized
        ' rectangle on a ComplexGraph plot.
        Dim width As Double = 3
        Dim height As Double = 2
        Dim corner As New ComplexDouble(-2.0, -3.0)

        cxGraph.ZoomXY(cxGraph.Plots(0), corner, width, height)
    End Sub
#End Region

#Region "helper methosd for the SnipsComplexGraph class"

    Private Sub cxGraph_AfterDrawPlotArea(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        If TypeOf sender Is ComplexGraph Then
            Dim graph As ComplexGraph = DirectCast(sender, ComplexGraph)
            Dim legendItems As New List(Of SnipsLegendItem)(graph.Plots.Count)
            For Each plot As ComplexPlot In graph.Plots
                Dim item As New SnipsLegendItem(plot, plot.ToString(), plot.GetComplexData().Length > 0)
                legendItems.Add(item)
            Next
            MainForm.Legend.SetItems(legendItems)
        End If
    End Sub

    Private Sub cxGraph_PlotsChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If TypeOf sender Is ComplexGraph Then
            Dim graph As ComplexGraph = DirectCast(sender, ComplexGraph)
            For Each plot As ComplexPlot In graph.Plots
                plot.PointStyle = PointStyle.EmptyDiamond
                plot.PointColor = Color.GhostWhite
            Next
        End If
    End Sub

    ''' <summary>
    ''' Reset the graph to it's default state.  This is done by
    ''' clearing the data, and then re-plotting the sample data.
    ''' </summary>
    Public Overrides Sub ResetToDefaultState()
        MyBase.ResetToDefaultState()

        cxGraph.Annotations.Clear()
        cxGraph.Cursors.Clear()
        CreateSampleAnnotation()
        CreateSampleCursor()

        PlotComplex_ComplexDoubleArray()
    End Sub

    ''' <summary>
    ''' Integerernal helper function to create an annotation on the XY graph
    ''' </summary>
    Private Sub CreateSampleAnnotation()
        'create an annotation
        Dim graphAnnotation As New ComplexPointAnnotation()
        Dim position As New ComplexDouble(RealPos, ImgPos)

        graphAnnotation.Caption = "Sample Annotation"
        graphAnnotation.Visible = True
        graphAnnotation.ShapeFillColor = Color.Aqua
        graphAnnotation.XAxis = cxGraph.XAxes(0)
        graphAnnotation.YAxis = cxGraph.YAxes(0)
        ' Create an annotation in the middle of the graph
        graphAnnotation.SetPosition(position)
        cxGraph.Annotations.Add(graphAnnotation)
    End Sub

    Private Sub CreateSampleCursor()
        Dim cursor As New ComplexCursor(cxGraph.Plots(0))

        cursor.VerticalCrosshairMode = CursorCrosshairMode.FullLength
        cursor.HorizontalCrosshairMode = CursorCrosshairMode.FullLength
        cursor.SnapMode = CursorSnapMode.ToPlot
        cursor.MoveNext()
        cursor.Color = Color.Maroon
        cxGraph.Cursors.Add(cursor)
    End Sub

    Private Function GenerateComplexData() As ComplexDouble()
        Dim data As ComplexDouble() = New ComplexDouble(99) {}
        Dim imgAmp As Double = RandNumberGenerator.NextDouble() * 10
        Dim realAmp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To data.Length - 1
            data(i).Imaginary = imgAmp * Math.Sin(2 * i * Math.PI / (data.Length - 1))
            data(i).Real = realAmp * Math.Sin(4 * i * Math.PI / (data.Length - 1))
        Next
        Return data
    End Function

#End Region
End Class