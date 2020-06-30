
Imports NationalInstruments.UI
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class DefaultAspx
    Inherits Page

    Private Const TwoPi As Double = Math.PI * 2
    Private Const HalfPi As Double = Math.PI / 2

    Protected Sub OnPlotCircleButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Const pointCount As Integer = 50
        Const divisor As Integer = pointCount - 1
        Dim dataX(pointCount) As Double
        Dim dataY(pointCount) As Double

        For i As Integer = 0 To pointCount
            Dim current As Double = (CType(i, Double) / divisor) * TwoPi
            dataX(i) = Math.Cos(current) * HalfPi
            dataY(i) = Math.Sin(current) * HalfPi
        Next

        xyDataGraph.PlotXY(dataX, dataY)
        xDataGraph.PlotY(dataX)
        yDataGraph.PlotY(dataY)
    End Sub

    Protected Sub OnPlotOctagonButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Const numberOfSides As Integer = 8
        Const pointCount As Integer = numberOfSides + 1

        Dim dataX(pointCount) As Double
        Dim dataY(pointCount) As Double

        For i As Integer = 0 To pointCount
            dataX(i) = Math.Cos(((i + 0.5) / numberOfSides) * TwoPi)
            dataY(i) = Math.Sin(((i + 0.5) / numberOfSides) * TwoPi)
        Next

        xyDataGraph.PlotXY(dataX, dataY)
        xDataGraph.PlotY(dataX)
        yDataGraph.PlotY(dataY)
    End Sub

    Protected Sub OnPlotPolarButtonClick(ByVal sender As Object, ByVal e As EventArgs)
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

        xyDataGraph.PlotXY(dataX, dataY)
        xDataGraph.PlotY(dataX)
        yDataGraph.PlotY(dataY)
    End Sub

    Protected Sub OnPlotSpiralButtonClick(ByVal sender As Object, ByVal e As EventArgs)
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

        xyDataGraph.PlotXY(dataX, dataY)
        xDataGraph.PlotY(dataX)
        yDataGraph.PlotY(dataY)
    End Sub
End Class
