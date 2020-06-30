Imports System.Drawing.Imaging
Imports NationalInstruments.UI.WindowsForms


NotInheritable Class SnipsScatterGraph
    Inherits SnipsXYGraph
    Private scatGraph As ScatterGraph
    Const Len As Integer = 50

    ''' <summary>
    ''' Creates a new scattergraph object for use in this 
    ''' code snippets example
    ''' </summary>
    ''' <param name="scatterGraph">The ScatterGraph to be used Integerernally</param>
    Public Sub New(ByVal scatterGraph As ScatterGraph)
        MyBase.New(scatterGraph, scatterGraph.Plots(0))
        scatGraph = scatterGraph
        ResetToDefaultState()
        AddHandler scatGraph.PlotsChanged, AddressOf scatGraph_PlotsChanged
        AddHandler scatGraph.AfterDrawPlotArea, AddressOf scatGraph_AfterDrawPlotArea
    End Sub

#Region "Code Snippets for NationalInsruments.UI.WindowsForms.ScatterGraph"

    ''' <summary>
    ''' Plots a single y value against a single x value. 
    ''' It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotXY(Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXY_double_double()
        ' The following example demonstrates plotting a single point
        ' on a ScatterGraph object.
        Dim xVal As Double = RandNumberGenerator.NextDouble() * 10
        Dim yVal As Double = RandNumberGenerator.NextDouble() * 10

        scatGraph.PlotXY(xVal, yVal)
    End Sub

    ''' <summary>
    ''' Plots a subset of an array of y values against an array of x values.
    ''' It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotXY(Double[], Double[], Integer, Integer)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXY_doubleArray_doubleArray_int_int()
        ' The following example demonstrates plotting multiple data points
        ' on a ScatterGraph object.
        Dim xData As Double() = Nothing
        Dim yData As Double() = Nothing

        ' get some random data
        GetXYCircleData(xData, yData)
        ' plot all x values against all y values starting at 
        ' the first item of each array
        scatGraph.PlotXY(xData, yData, 0, xData.Length)
    End Sub

    ''' <summary>
    ''' Plots a single y value against a single x value by appending the x and y
    ''' value to the existing data. It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotXYAppend(Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXYAppend_double_double()
        ' The following example demonstrates appending a single point to
        ' an existing ScatterGraph plot.
        Dim xVal As Double = RandNumberGenerator.NextDouble() * 10
        Dim yVal As Double = RandNumberGenerator.NextDouble() * 10

        scatGraph.PlotXYAppend(xVal, yVal)
    End Sub

    ''' <summary>
    ''' Plots a subset of an array of y values against an array of x values by appending
    ''' the x and y values to the existing data.  It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotXYAppend(Double[], Double[], Integer, Integer)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXYAppend_doubleArray_doubleArray_int_int()
        ' The following example demonstrates appending a subset of an array of data 
        ' to an existing ScatterGraph plot beginning at the fifth index in the data
        ' arrays and continuing for 10 data points.
        Dim xData As Double() = Nothing
        Dim yData As Double() = Nothing
        Dim start As Integer = 5
        Dim len As Integer = 10

        ' get some random data
        GetXYCircleData(xData, yData)
        ' plot 10 x values against 10 y values starting at 
        ' the fifth index of each array
        scatGraph.PlotXYAppend(xData, yData, start, len)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of y values with the specified orientation against an 
    ''' array of x values.  It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotXYMultiple(Double[], Double[,], DataOrientation)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXYMultiple_doubleArray_double2DArray_DataOrientation()
        ' The following example demonstrates plotting multiple datasets arranged in rows
        ' of data to multiple ScatterGraph plots.
        Dim xData As Double() = Nothing
        Dim yDataMatrix As Double(,) = Nothing

        ' get some random data
        GetXYCircleData(xData, yDataMatrix, 3)
        scatGraph.PlotXYMultiple(xData, yDataMatrix, DataOrientation.DataInRows)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of y values with the specified orientation against an 
    ''' array of x values by appending the x and y values to the existing data.
    ''' It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotXYAppendMultiple(Double[], Double[,], DataOrientation)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXYAppendMultiple_doubleArray_double2DArray_DataOrientation()
        ' The following example demonstrates appending multiple datasets arranged in rows
        ' of data to multiple ScatterGraph plots.
        Dim xData As Double() = Nothing
        Dim yDataMatrix As Double(,) = Nothing

        ' get some random data
        GetXYCircleData(xData, yDataMatrix, 3)
        scatGraph.PlotXYAppendMultiple(xData, yDataMatrix, DataOrientation.DataInRows)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of x values with the specified orientation against an array 
    ''' of y values.  It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotYXMultiple(Double[], Double[,], DataOrientation)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYXMultiple_doubleArray_double2DArray_DataOrientation()
        ' The following example demonstrates plotting multiple datasets arranged in rows
        ' of data to multiple ScatterGraph plots.
        Dim xDataMatrix As Double(,) = Nothing
        Dim yData As Double() = Nothing

        ' get some random data
        GetYXCircleData(yData, xDataMatrix, 3)
        scatGraph.PlotYXMultiple(yData, xDataMatrix, DataOrientation.DataInRows)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of x values with the specified orientation against an 
    ''' array of y values by appending the x and y values to the existing data. 
    ''' It is implemented in the ScatterGraph class. 
    ''' </summary>
    ''' <signature>PlotYXAppendMultiple(Double[], Double[,], DataOrientation)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYXAppendMultiple_doubleArray_double2DArray_DataOrientation()
        ' The following example demonstrates appending multiple datasets arranged in rows
        ' of data to multiple ScatterGraph plots.
        Dim xDataMatrix As Double(,) = Nothing
        Dim yData As Double() = Nothing

        ' get some random data
        GetYXCircleData(yData, xDataMatrix, 3)
        scatGraph.PlotYXAppendMultiple(yData, xDataMatrix, DataOrientation.DataInRows)
    End Sub

#End Region

#Region "helper methods for the SnipsScatterGraph class"

    Private Sub scatGraph_AfterDrawPlotArea(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        If TypeOf sender Is ScatterGraph Then
            Dim graph As ScatterGraph = DirectCast(sender, ScatterGraph)
            Dim legendItems As New List(Of SnipsLegendItem)(graph.Plots.Count)
            For Each plot As ScatterPlot In graph.Plots
                Dim item As New SnipsLegendItem(plot, plot.ToString(), plot.GetYData().Length > 0)
                legendItems.Add(item)
            Next
            MainForm.Legend.SetItems(legendItems)
        End If
    End Sub

    Private Sub scatGraph_PlotsChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If TypeOf sender Is ScatterGraph Then
            Dim graph As ScatterGraph = DirectCast(sender, ScatterGraph)
            For Each plot As ScatterPlot In graph.Plots
                plot.PointStyle = PointStyle.EmptyCircle
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
        PlotXY_doubleArray_doubleArray_int_int()
    End Sub

    Private Sub GetXYCircleData(ByRef xData As Double(), ByRef yData As Double())
        Const divisor As Integer = Len - 1
        Dim xVals As Double() = New Double(Len - 1) {}
        Dim yVals As Double() = New Double(Len - 1) {}
        Dim radius As Double = RandNumberGenerator.NextDouble() * 10 + 6

        For i As Integer = 0 To Len - 1
            Dim current As Double = (CDbl(i) / divisor) * Math.PI * 2
            xVals(i) = Math.Cos(current) * radius
            yVals(i) = Math.Sin(current) * radius
        Next

        xData = xVals
        yData = yVals
    End Sub

    Private Sub GetXYCircleData(ByRef xData As Double(), ByRef yData As Double(,), ByVal numPlots As Integer)
        Dim xVals As Double() = New Double(Len - 1) {}
        Dim yVals As Double(,) = New Double(numPlots - 1, Len - 1) {}
        Dim divisor As Double = Len - 1
        Dim radius As Double = RandNumberGenerator.NextDouble() * 10 + 6

        ' Generate some xData
        For i As Integer = 0 To Len - 1
            Dim current As Double = (CDbl(i) / divisor) * Math.PI * 2
            xVals(i) = Math.Cos(current) * radius
        Next

        ' Generate the yData
        For row As Integer = 0 To numPlots - 1
            radius = RandNumberGenerator.NextDouble() * 10
            For col As Integer = 0 To Len - 1
                Dim current As Double = (CDbl(col) / divisor) * Math.PI * 2
                yVals(row, col) = Math.Sin(current) * radius
            Next
        Next

        xData = xVals
        yData = yVals
    End Sub

    Private Sub GetYXCircleData(ByRef yData As Double(), ByRef xData As Double(,), ByVal numPlots As Integer)
        GetXYCircleData(yData, xData, numPlots)
    End Sub

#End Region
End Class