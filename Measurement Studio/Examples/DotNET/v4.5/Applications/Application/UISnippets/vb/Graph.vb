Imports NationalInstruments.UI.WindowsForms
Imports System.Drawing.Imaging

Class SnipsGraph
    Inherits SnipsControlBase
    Private graph As Graph

    Public Sub New(ByVal graphToUse As Graph)
        MyBase.New(graphToUse)
        graph = graphToUse
    End Sub

#Region "code snippets for NationalInstruments.UI.WindowsForms.Graph"

    ''' <summary>
    ''' Removes all data from the history of all plots on the graph.
    ''' It is implemented in the Graph class. 
    ''' </summary>
    ''' <signature>ClearData()</signature>
    ''' <ExampleMethod />
    Public Sub ClearData()
        graph.ClearData()
    End Sub

    ''' <summary>
    ''' Zooms around the center of the plot area using the specified zoom factor.
    ''' It is implemented in the Graph class.
    ''' </summary>
    ''' <signature>ZoomAroundPoint(Single)</signature>
    ''' <ExampleMethod />
    Public Sub ZoomAroundPoint_float()
        ' The following example demonstrates zooming in around the center
        ' of the plot on a Graph object area by a factor of 150%.

        ' the percentage to zoom by - in this case 150%
        Dim zoomFactor As Single = 1.5F

        ' When you only specify a zoom factor, the
        ' zoom is centered around the center of the graph
        graph.ZoomAroundPoint(zoomFactor)

    End Sub

    ''' <summary>
    ''' To run this method, you must first click the run snippet button, and then
    ''' click on an annotation in the plot area.  This method zooms around the 
    ''' specified x and y coordinates with the specified zoom factor.  It is 
    ''' implemented in the Graph class.
    ''' </summary>
    ''' <signature>ZoomAroundPoint(Single, Single, Single)</signature>
    ''' <OtherMethods>PointToVirtual(Point)</OtherMethods>
    ''' <ExampleMethod />
    <EventBased("PlotAreaMouseDown")> _
    Public Sub ZoomAroundPoint_float_float_float(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates zooming in by a factor of 125% around a 
        ' point on a Graph object obtained from handling the PlotAreaMouseDown event.
        Dim virtualPoint As PointF
        Dim zoomFactor As Single = 1.25F

        ' only zoom in when the left mouse button is clicked
        If e.Button = MouseButtons.Left Then
            ' get the virtual position of the mouse click 
            virtualPoint = graph.PointToVirtual(e.Location)
            graph.ZoomAroundPoint(zoomFactor, virtualPoint.X, virtualPoint.Y)
        End If
    End Sub

    ''' <summary>
    ''' To run this method, you must first click the run snippet button, and then
    ''' click on an annotation in the plot area.  This method zooms around the 
    ''' specified point with the specified zoom factor. It is implemented in 
    ''' the Graph class.
    ''' </summary>
    ''' <signature>ZoomAroundPoint(Single, PointF)</signature>
    ''' <OtherMethods>PointToVirtual(Point)</OtherMethods>
    ''' <ExampleMethod />
    <EventBased("PlotAreaMouseDown")> _
    Public Sub ZoomAroundPoint_float_PointF(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates zooming in by a factor of 125% around a 
        ' point on a Graph object obtained from handling the PlotAreaMouseDown event.
        Dim virtualPoint As PointF
        Dim zoomFactor As Single = 1.25F

        ' only zoom in when the left mouse button is clicked
        If e.Button = MouseButtons.Left Then
            ' get the virtual position of the mouse click 
            virtualPoint = graph.PointToVirtual(e.Location)
            graph.ZoomAroundPoint(zoomFactor, virtualPoint)
        End If
    End Sub

    ''' <summary>
    ''' Draws the grid lines in the plot area of the graph.  For this method
    ''' to draw anything, gridlines must be visible on the plot. It is 
    ''' implemented in the Graph class. 
    ''' </summary>
    ''' <signature>DrawGridLines(ComponentDrawArgs)</signature>
    ''' <ExampleMethod />
    <EventBased("AfterDrawPlotArea", "Invalidate")> _
    Public Sub DrawGridLines_ComponentDrawArgs(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        ' The following example demonstrates drawing a Graph object's origin lines
        ' to a .png image in response to the AfterDrawPlotArea event.
        Dim imageFileName As String = "GridLinesImage.png"
        Using bmp As New Bitmap(graph.PlotAreaBounds.Width, graph.PlotAreaBounds.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim args As New ComponentDrawArgs(g, New Rectangle(0, 0, bmp.Width, bmp.Height))

            graph.DrawGridLines(args)
            bmp.Save(imageFileName, ImageFormat.Png)
        End Using
        Debug.WriteLine(String.Format("file {0} has been saved", imageFileName))
    End Sub

    ''' <summary>
    ''' Draws the plot area components of the graph.  It is implemented in the Graph class. 
    ''' </summary>
    ''' <signature>DrawPlotAreaComponents(ComponentDrawArgs)</signature>
    ''' <ExampleMethod />
    <EventBased("AfterDrawPlotArea", "Invalidate")> _
    Public Sub DrawPlotAreaComponents_ComponentDrawArgs(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        ' The following example demonstrates drawing a Graph object's plot area components
        ' to a .png image in response to the AfterDrawPlotArea event.
        Dim imageFileName As String = "PlotAreaComponentsImage.png"
        Using bmp As New Bitmap(graph.PlotAreaBounds.Width, graph.PlotAreaBounds.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim args As New ComponentDrawArgs(g, New Rectangle(0, 0, bmp.Width, bmp.Height))

            graph.DrawPlotAreaComponents(args)
            bmp.Save(imageFileName, ImageFormat.Png)
        End Using
        Debug.WriteLine(String.Format("file {0} has been saved", imageFileName))
    End Sub

    ''' <summary>
    ''' Draws the plot area image of the graph.  For this method to draw anything, 
    ''' the plot must have a background image asssociated with it.  It is implemented
    ''' in the Graph class. 
    ''' </summary>
    ''' <signature>DrawPlotAreaImage(ComponentDrawArgs)</signature>
    ''' <ExampleMethod />
    <EventBased("AfterDrawPlotArea", "Invalidate")> _
    Public Sub DrawPlotAreaImage_ComponentDrawArgs(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        ' The following example demonstrates drawing a Graph object's plot area image
        ' to a .png image in response to the AfterDrawPlotArea event.
        Dim imageFileName As String = "PlotAreaImage.png"
        Using bmp As New Bitmap(graph.PlotAreaBounds.Width, graph.PlotAreaBounds.Height)
            Dim g As Graphics = Graphics.FromImage(bmp)
            Dim args As New ComponentDrawArgs(g, New Rectangle(0, 0, bmp.Width, bmp.Height))

            graph.DrawPlotAreaImage(args)
            bmp.Save(imageFileName, ImageFormat.Png)
        End Using
        Debug.WriteLine(String.Format("file {0} has been saved", imageFileName))
    End Sub

    ''' <summary>
    ''' Zooms to the region of the plot area specified by the given rectangle. 
    ''' It is implemented in the Graph class.
    ''' </summary>
    ''' <signature>ZoomXY(RectangleF)</signature>
    ''' <OtherMethods>RectangleToVirtual(Rectangle)</OtherMethods>
    ''' <ExampleMethod />
    Public Sub ZoomXY_RectangleF()
        ' The following example demonstrates zooming in on a Graph object
        ' to a particular region specified by a rectangle 150 px high and wide.

        ' The the bounds of the plot area - in client coordinates
        Dim bounds As Rectangle = graph.PlotAreaBounds
        Dim clientRect As New Rectangle()
        Dim virtualRect As RectangleF

        ' create a client rect.  Top left of the rect is at the 
        ' center of the plot, and it is 150 pixels high and wide
        clientRect.Y = bounds.Height \ 2 + bounds.Y
        clientRect.X = bounds.Width \ 2 + bounds.X
        clientRect.Height = 150
        clientRect.Width = 150

        ' RectangleToVirtual converts a rect from client coordinates
        ' to virtual coordinates, which are required by ZoomXY
        virtualRect = graph.RectangleToVirtual(clientRect)
        graph.ZoomXY(virtualRect)
    End Sub

    ''' <summary>
    ''' Zooms to the region of the plot area specified by the x location, y location, 
    ''' width, and height.  It is implemented in the Graph class.
    ''' </summary>
    ''' <signature>ZoomXY(Single, Single, Single, Single)</signature>        
    ''' <ExampleMethod />
    Public Sub ZoomXY_float_float_float_float()
        ' The following example demonstrates zooming in on a Graph object
        ' to a particular region specified by the x location, y location, 
        ' height and width of a rectangle.
        Dim virtualRect As New RectangleF()

        ' zoom in on a rectangle that begins 25% from the x and y
        ' origins, and continues for the next 50% of the plot area
        virtualRect.Y = 0.25F
        virtualRect.X = 0.25F
        virtualRect.Height = 0.5F
        virtualRect.Width = 0.5F

        graph.ZoomXY(virtualRect.X, virtualRect.Y, virtualRect.Width, virtualRect.Height)
    End Sub

    ''' <summary>
    ''' Pans the plot area according to the specified horizontal and vertical factors.  
    ''' It is implemented in the Graph class.
    ''' </summary>
    ''' <signature>PanXY(Single, Single)</signature>        
    ''' <ExampleMethod />
    Public Sub PanXY_float_float()
        ' The following example demonstrates panning 20% of a Graphs plot area 
        ' to the right and 10% of the plot area upwards.

        ' Positive pan values pan from right to left and top to bottom.
        ' Negative pan values pan from left to right and bottom to top.
        ' The pan values are in virtual coordinates - 0 does not pan, 1
        ' pans an entire plot area
        graph.PanXY(0.2F, 0.1F)
    End Sub

    ''' <summary>
    ''' This method calls the PointToVirtual(Point point)
    ''' method of the Graph class
    ''' </summary>
    ''' <signature>PointToVirtual(Point)</signature>
    ''' <ExampleMethod />
    Public Sub PointToVirtual_clientPoint()
        ' The following example demonstrates converting a point in client 
        ' coordinates to a point in virtual coordinates.
        Dim clientPoint As New Point()
        Dim bounds As Rectangle = graph.PlotAreaBounds
        Dim virtualPoint As PointF
        ' get the client point for the center of the plot
        clientPoint.X = CInt(bounds.Width) \ 2 + bounds.X
        clientPoint.Y = CInt(bounds.Height) \ 2 + bounds.Y
        ' PointToVirtual converts a point from client coordinates
        ' to virtual coordinate
        virtualPoint = graph.PointToVirtual(clientPoint)

        Debug.WriteLine("PointToVirtual Inputs: clientPoint.X: " & clientPoint.X.ToString() & " clientPoint.Y: " & clientPoint.Y.ToString())
        Debug.WriteLine("PointToVirtual Outputs: virtualPoint X: " & virtualPoint.X.ToString() & " virtualPoint.Y: " & virtualPoint.Y.ToString())
    End Sub

    ''' <summary>
    ''' This method call the 
    ''' RectangletoVirtual_Rectangle() method of the Graph class
    ''' See Output Window
    ''' </summary>
    ''' <signature>RectangletoVirtual(Rectangle)</signature>
    ''' <ExampleMethod />
    Public Sub RectangletoVirtual_Rectangle()
        ' The following example demonstrates converting a rectangle in client 
        ' coordinates to a rectangle in virtual coordinates.
        Dim clientPoint As New Point()
        Dim clientRect As New Rectangle()
        Dim virtualRect As New RectangleF()

        ' RectangleToVirtual takes the device coordinates from the client rectangle and converts 
        ' Them to virtual coordinates, which are values from 0.0 to 1.0, where 
        ' (0.0, 0.0) represents the left-bottom corner of the plot area and (1.0, 1.0)
        ' represents the right-top corner of the plot area. 
        clientRect = New Rectangle(clientPoint.X, clientPoint.Y, graph.Width / 2, graph.Height / 2)
        virtualRect = graph.RectangleToVirtual(clientRect)

        Debug.WriteLine("RectangletoVirtual Inputs: clientRect.X: " & clientRect.X.ToString() & " clientRect.Y: " & clientRect.Y.ToString() & " clientRect.Height: " & clientRect.Height.ToString() & " clientRect.Width: " & clientRect.Width.ToString())
        Debug.WriteLine("RectangletoVirtual Outputs: virtualRect X: " & virtualRect.X.ToString() & " PointToVirtual Outputs: virtualRect Y: " & virtualRect.Y.ToString() & " virtualRect.Height: " & clientRect.Height.ToString() & " virtualRect.Width: " & clientRect.Width.ToString())
    End Sub

#End Region

#Region "helper methods for the SnipsGraph class"

    Public Overrides Sub ResetToDefaultState()
        MyBase.ResetToDefaultState()
        ClearData()
    End Sub

    Public Overrides Function ToString() As String
        Return graph.ToString()
    End Function

#End Region
End Class
