
Imports NationalInstruments.UI
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Class DefaultAspx
    Inherits Page

    Private Const NumerSamples As Integer = 100
    Private Const Frequency As Single = 1

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)

        If Not IsPostBack Then
            graph.PlotY(GenerateData(0))
        End If
    End Sub

    Protected Overrides Sub OnPreRender(ByVal e As EventArgs)
        MyBase.OnPreRender(e)

        AddHandler xPosition.AfterChangeValue, AddressOf OnXPositionAfterChangeValue
        AddHandler yPosition.AfterChangeValue, AddressOf OnYPositionAfterChangeValue

        Dim cursor As XYCursor = graph.Cursors(0)
        xPosition.Value = cursor.XPosition
        yPosition.Value = cursor.YPosition
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

    Protected Sub OnXPositionAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdatePosition()
    End Sub

    Protected Sub OnYPositionAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdatePosition()
    End Sub

    Protected Sub OnCurrentIndexAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        Dim index As Integer = CInt(currentIndex.Value)
        Dim cursor As XYCursor = graph.Cursors(0)

        If index >= 0 And index < cursor.Plot.HistoryCount Then
            cursor.MoveCursor(index)
        End If
    End Sub

    Private Sub UpdatePosition()
        graph.Cursors(0).MoveCursor(xPosition.Value, yPosition.Value)
    End Sub

    Private Shared Function GenerateData(ByVal phase As Double) As Double()
        Dim data(NumerSamples) As Double
        Dim rand As New Random()

        Dim x As Integer
        For x = 0 To data.Length - 1
            Dim angle As Double = x * (2 * Math.PI) * Frequency / (data.Length - 1) + phase
            data(x) = Math.Sin(angle) + rand.NextDouble() / 5
        Next x

        Return data
    End Function
End Class