Imports System
Imports System.Windows
Imports System.Windows.Media
Imports NationalInstruments.Controls
Imports NationalInstruments.Controls.Rendering

Class MainWindow
    Inherits Window
    Private Shared ReadOnly linePlotRenderer As New LinePlotRenderer() With { _
     .Stroke = Brushes.Red, _
     .StrokeThickness = 2 _
    }
    Private Shared ReadOnly areaPlotRenderer As New AreaPlotRenderer() With { _
     .Fill = Brushes.Blue _
    }
    Private Shared ReadOnly pointPlotRenderer As New PointPlotRenderer() With { _
     .Stroke = Brushes.Green, _
     .Fill = Brushes.RoyalBlue, _
     .Shape = PointShape.Diamond, _
     .Size = New Size(10, 10) _
    }
    Private Shared ReadOnly barPlotRenderer As New BarPlotRenderer() With { _
     .Stroke = Brushes.Orange, _
     .Fill = Brushes.Purple, _
     .StrokeThickness = 3, _
     .BarWidth = 0.5 _
    }
    Private Shared ReadOnly plotRendererGroup As New PlotRendererGroup()
    Private Shared ReadOnly random As New Random()

    Public Sub New()
        InitializeComponent()
        plotRendererGroup.PlotRenderers.Add(linePlotRenderer)
        plotRendererGroup.PlotRenderers.Add(pointPlotRenderer)
        GenerateData()
    End Sub

    Private Sub GenerateData()
        Dim dataCount As Integer = 41

        Dim newData As Double() = New Double(dataCount - 1) {}
        For i As Integer = 0 To dataCount - 1
            newData(i) = (random.NextDouble() * 40) - 20
        Next

        graph.DataSource = newData
    End Sub

    Private Sub OnGenerateDataButtonClicked(sender As Object, e As RoutedEventArgs)
        GenerateData()
    End Sub

    Private Sub EnableFillToRadioButtons()
        If fillToZeroRadioButton IsNot Nothing Then
            fillToZeroRadioButton.IsEnabled = True
        End If

        If fillToPositiveInfinityRadioButton IsNot Nothing Then
            fillToPositiveInfinityRadioButton.IsEnabled = True
        End If

        If fillToNegativeInfinityRadioButton IsNot Nothing Then
            fillToNegativeInfinityRadioButton.IsEnabled = True
        End If
    End Sub

    Private Sub DisableFillToRadioButtons()
        If fillToZeroRadioButton IsNot Nothing Then
            fillToZeroRadioButton.IsEnabled = False
        End If

        If fillToPositiveInfinityRadioButton IsNot Nothing Then
            fillToPositiveInfinityRadioButton.IsEnabled = False
        End If

        If fillToNegativeInfinityRadioButton IsNot Nothing Then
            fillToNegativeInfinityRadioButton.IsEnabled = False
        End If
    End Sub

    Private Sub OnBarPlotRendererRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        EnableFillToRadioButtons()
        graph.Plots(0).Renderer = barPlotRenderer
    End Sub

    Private Sub OnPointPlotRendererRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        DisableFillToRadioButtons()
        graph.Plots(0).Renderer = pointPlotRenderer
    End Sub

    Private Sub OnLinePlotRendererRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        DisableFillToRadioButtons()
        graph.Plots(0).Renderer = linePlotRenderer
    End Sub

    Private Sub OnAreaPlotRendererRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        EnableFillToRadioButtons()
        graph.Plots(0).Renderer = areaPlotRenderer
    End Sub

    Private Sub OnPlotRendererGroupRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        DisableFillToRadioButtons()
        graph.Plots(0).Renderer = plotRendererGroup
    End Sub

    Private Sub OnFillToZeroRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        areaPlotRenderer.FillBaseline = FillBaseline.Zero
        barPlotRenderer.FillBaseline = FillBaseline.Zero
    End Sub

    Private Sub OnFillToPositiveInfinityRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        areaPlotRenderer.FillBaseline = FillBaseline.PositiveInfinity
        barPlotRenderer.FillBaseline = FillBaseline.PositiveInfinity
    End Sub

    Private Sub OnFillToNegativeInfinityRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        areaPlotRenderer.FillBaseline = FillBaseline.NegativeInfinity
        barPlotRenderer.FillBaseline = FillBaseline.NegativeInfinity
    End Sub
End Class
