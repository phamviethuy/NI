
Imports NationalInstruments
Imports NationalInstruments.UI
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Class DefaultAspx
    Inherits Page

    Private Const DataLength As Integer = 100
    Private Const Frequency As Single = 1
    Private Const Phase As Double = 0

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)

        If Not IsPostBack Then
            graph.PlotComplex(GenerateData(DataLength, Phase))
        End If
    End Sub

    Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
        MyBase.OnPreRender(e)

        AddHandler realPosition.AfterChangeValue, AddressOf OnRealPositionAfterChangeValue
        AddHandler imaginaryPosition.AfterChangeValue, AddressOf OnimaginaryPositionAfterChangeValue

        Dim cursor As ComplexCursor = graph.Cursors(0)
        realPosition.Value = cursor.Position.Real
        imaginaryPosition.Value = cursor.Position.Imaginary
        currentIndex.Value = cursor.GetCurrentIndex()
    End Sub

    Protected Sub OnMovePreviousClick(ByVal sender As Object, ByVal e As EventArgs)
        graph.Cursors(0).MovePrevious()
    End Sub

    Protected Sub OnMoveNextClick(ByVal sender As Object, ByVal e As EventArgs)
        graph.Cursors(0).MoveNext()
    End Sub

    Protected Sub OnLabelVisibleCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        graph.Cursors(0).LabelVisible = labelVisible.Checked
    End Sub

    Protected Sub OnSnapToPlotCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If snapToPlot.Checked Then
            graph.Cursors(0).SnapMode = CursorSnapMode.ToPlot
        Else
            graph.Cursors(0).SnapMode = CursorSnapMode.Floating
        End If
    End Sub

    Protected Sub OnRealPositionAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdatePosition()
    End Sub

    Protected Sub OnImaginaryPositionAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdatePosition()
    End Sub

    Protected Sub OnCurrentIndexAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        Dim index As Integer = CInt(currentIndex.Value)
        Dim cursor As ComplexCursor = graph.Cursors(0)

        If index >= 0 And index < cursor.Plot.HistoryCount Then
            cursor.MoveCursor(index)
        End If
    End Sub

    Private Sub UpdatePosition()
        graph.Cursors(0).MoveCursor(New ComplexDouble(realPosition.Value, imaginaryPosition.Value))
    End Sub

    Private Shared Function GenerateData(ByVal length As Integer, ByVal phase As Double) As ComplexDouble()
        Dim halfLength As Integer = length / 2
        Dim indices(length) As Double
        Dim data(length) As Double
        Dim rand As New Random()

        Dim x As Integer
        For x = 0 To data.Length - 1
            Dim angle As Double = x * (2 * Math.PI) * Frequency / (data.Length - 1) + phase
            data(x) = Math.Sin(angle) + rand.NextDouble() / 5
            indices(x) = x - halfLength
        Next x

        Return ComplexDouble.ComposeArray(indices, data)
    End Function
End Class