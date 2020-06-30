Imports System
Imports System.Windows

''' <summary>
''' Example of how to write data to a graph in WPF. Specifically, we look at writing
''' XY data to a graph using an array of points. There are three graphs displayed:
''' the XY Plot of the data, the X component of the data, and then the Y component
''' of the data.
''' </summary>
Partial Public Class MainWindow
    Inherits Window
    Const TwoPi As Double = Math.PI * 2

    Public Sub New()
        InitializeComponent()
        InitializeGraph()
    End Sub

    'Graph initialization can be time consuming.  The code below initializes the graph during application load time.
    'This ensures that there will not be a delay during execution of your application.
    Private Sub InitializeGraph()
        xGraph.DataSource = New Double(1) {}
        yGraph.DataSource = New Double(1) {}
        xyGraph.DataSource = New Point(1) {}
    End Sub

    Public Sub OnPlotCircleButtonClick(sender As Object, e As RoutedEventArgs)
        Const numberOfPoints As Integer = 100
        Const radius As Integer = 10
        Const angleIncrementFactor As Double = TwoPi / (numberOfPoints - 1)

        Dim dataX As Double() = New Double(numberOfPoints - 1) {}
        Dim dataY As Double() = New Double(numberOfPoints - 1) {}
        Dim dataXY As Point() = New Point(numberOfPoints - 1) {}

        Dim angle As Double = 0
        For i As Integer = 0 To numberOfPoints - 1
            angle += angleIncrementFactor
            dataX(i) = radius * Math.Cos(angle)
            dataY(i) = radius * Math.Sin(angle)
            dataXY(i) = New Point(dataX(i), dataY(i))
        Next

        xGraph.DataSource = dataX
        yGraph.DataSource = dataY
        xyGraph.DataSource = dataXY

    End Sub

    Private Sub OnPlotOctagonButtonClick(sender As Object, e As RoutedEventArgs)
        Const numberOfSides As Integer = 8
        Const numberOfPoints As Integer = numberOfSides + 1

        Dim dataX As Double() = New Double(numberOfPoints - 1) {}
        Dim dataY As Double() = New Double(numberOfPoints - 1) {}
        Dim dataXY As Point() = New Point(numberOfPoints - 1) {}

        For i As Integer = 0 To numberOfPoints - 1
            dataX(i) = Math.Cos(((i + 0.5) / numberOfSides) * TwoPi)
            dataY(i) = Math.Sin(((i + 0.5) / numberOfSides) * TwoPi)
            dataXY(i) = New Point(dataX(i), dataY(i))
        Next

        xGraph.DataSource = dataX
        yGraph.DataSource = dataY
        xyGraph.DataSource = dataXY
    End Sub

    Private Sub OnPlotPolarButtonClick(sender As Object, e As RoutedEventArgs)
        Const numberOfPoints As Integer = 360
        Const divisor As Integer = numberOfPoints - 1
        Dim radiusData As Double() = New Double(numberOfPoints - 1) {}
        Dim angleData As Double() = New Double(numberOfPoints - 1) {}
        Dim dataX As Double() = New Double(numberOfPoints - 1) {}
        Dim dataY As Double() = New Double(numberOfPoints - 1) {}
        Dim dataXY As Point() = New Point(numberOfPoints - 1) {}

        ' Calculate data in polar coordinates.
        For i As Integer = 0 To numberOfPoints - 1
            angleData(i) = i
            radiusData(i) = Math.Sin((CDbl(i) / divisor) * TwoPi * 3) + 0.5
        Next

        ' Convert polar coordinates to XY coordinates.
        For i As Integer = 0 To numberOfPoints - 1
            Dim current As Double = (angleData(i) / numberOfPoints) * TwoPi
            dataX(i) = Math.Cos(current) * radiusData(i)
            dataY(i) = Math.Sin(current) * radiusData(i)
            dataXY(i) = New Point(dataX(i), dataY(i))
        Next

        xGraph.DataSource = dataX
        yGraph.DataSource = dataY
        xyGraph.DataSource = dataXY
    End Sub

    Private Sub OnPlotSpiralButtonClick(sender As Object, e As RoutedEventArgs)
        Dim numberOfPoints As Integer = 1000

        Dim dataX As Double() = New Double(numberOfPoints - 1) {}
        Dim dataY As Double() = New Double(numberOfPoints - 1) {}
        Dim dataXY As Point() = New Point(numberOfPoints - 1) {}

        Dim angleIncrementFactor As Double = 0.05
        For i As Integer = 0 To numberOfPoints - 1
            dataX(i) = Math.Cos(i * angleIncrementFactor) * i
            dataY(i) = Math.Sin(i * angleIncrementFactor) * i
            dataXY(i) = New Point(dataX(i), dataY(i))
        Next

        xGraph.DataSource = dataX
        yGraph.DataSource = dataY
        xyGraph.DataSource = dataXY
    End Sub
End Class