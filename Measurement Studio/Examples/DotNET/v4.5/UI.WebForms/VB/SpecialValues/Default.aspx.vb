Imports NationalInstruments.UI
Imports System.Drawing

Partial Class DefaultAspx
    Inherits Page

    Private Const NumberOfPoints As Integer = 75
    Private Const YRange As Integer = 10
    Private Const NumberOfSineWaves As Integer = 3

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

        If Not IsPostBack Then
            Dim nanData As Double()
            nanData = GenerateSineWave(NumberOfPoints, YRange, NumberOfSineWaves)
            For i As Int32 = 1 To nanData.Length - 1
                If ((i Mod 7) = 0) Then
                    nanData(i) = Double.NaN
                End If
            Next i
            waveformGraph.Plots(0).PlotY(nanData)

            Dim infinityData As Double()
            infinityData = GenerateSineWave(NumberOfPoints, YRange, NumberOfSineWaves)
            For i As Int32 = 1 To infinityData.Length - 1
                If ((i Mod 20) = 0) Then
                    infinityData(i) = Double.PositiveInfinity
                ElseIf ((i Mod 10) = 0) Then
                    infinityData(i) = Double.NegativeInfinity
                End If
            Next i
            waveformGraph.Plots(1).PlotY(infinityData, -5, 1)

        End If
    End Sub

    Protected Sub OnLegendItemNanBeforeDraw(ByVal sender As Object, ByVal e As BeforeDrawLegendItemEventArgs)
        DrawLegendItem(e, waveformGraph.Plots(0))
    End Sub

    Protected Sub OnLegendItemInfinityBeforeDraw(ByVal sender As Object, ByVal e As BeforeDrawLegendItemEventArgs)
        DrawLegendItem(e, waveformGraph.Plots(1))
    End Sub

    Private Sub DrawLegendItem(ByVal e As BeforeDrawLegendItemEventArgs, ByVal plot As XYPlot)
        e.Cancel = True
        e.Graphics.FillRectangle(Brushes.Black, e.ItemBounds)
        plot.DrawLines(New ComponentDrawArgs(e.Graphics, e.ItemBounds))
        e.Item.DrawText(New ComponentDrawArgs(e.Graphics, e.Bounds))
        waveformGraph.PlotAreaBorder.Draw(e.Item, New BorderDrawArgs(e.Graphics, e.ItemBounds))
    End Sub

    Private Function GenerateSineWave(ByVal numberOfPoints As Int32, ByVal yRange As Int32, ByVal numberOfSineWaves As Int32) As Double()
        If numberOfPoints < 0 Then
            Throw New ArgumentOutOfRangeException("numberOfPoints")
        End If

        If yRange < 0 Then
            Throw New ArgumentOutOfRangeException("yRange")
        End If

        If numberOfSineWaves < 0 Then
            Throw New ArgumentOutOfRangeException("numberOfSineWaves")
        End If

        Dim data(numberOfPoints) As Double
        For i As Int32 = 0 To data.Length - 1
            data(i) = yRange / 2 * (1 - Math.Sin(i * 2 * Math.PI / ((numberOfPoints / numberOfSineWaves) - 1)))
        Next i

        Return data
    End Function

End Class
