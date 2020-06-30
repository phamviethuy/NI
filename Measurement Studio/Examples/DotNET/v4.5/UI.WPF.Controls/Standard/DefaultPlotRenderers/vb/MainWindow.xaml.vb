Imports System.Windows.Controls.Primitives
Imports NationalInstruments.Controls.Rendering

Class MainWindow
    Private ReadOnly modifiedRenderer As New LinePlotRenderer() With { _
         .Stroke = Brushes.Aquamarine, _
         .StrokeThickness = 3, _
         .StrokeDashArray = New DoubleCollection() From {4, 2}
        }

    Private ReadOnly alternateDefaultRenderers As New PlotRendererCollection() From { _
            New LinePlotRenderer() With { _
             .Stroke = Brushes.Yellow, _
             .StrokeThickness = 5 _
            }, _
            New LinePlotRenderer() With { _
             .Stroke = Brushes.Purple, _
             .StrokeThickness = 5 _
            }, _
            New LinePlotRenderer() With { _
             .Stroke = Brushes.Orange, _
             .StrokeThickness = 5 _
            } _
        }


    Public Sub New()
        InitializeComponent()
        GenerateData()
    End Sub

    Private Sub GenerateData()
        Dim random As New Random()
        Dim rows As Integer = graph.Plots.Count
        Dim columns As Integer = 21

        Dim data As Double(,) = New Double(rows - 1, columns - 1) {}
        For i As Integer = 0 To rows - 1
            For j As Integer = 0 To columns - 1
                data(i, j) = i + random.NextDouble()
            Next
        Next

        graph.DataSource = data
    End Sub

    Private Sub OnChangeDefaultStylesButtonClicked(sender As Object, e As RoutedEventArgs)
        Dim button As ToggleButton = DirectCast(sender, ToggleButton)
        If CBool(button.IsChecked) Then
            graph.DefaultPlotRenderers.ReplaceAll(alternateDefaultRenderers)
        Else
            graph.DefaultPlotRenderers.Clear()
        End If
    End Sub

    Private Sub OnResetRenderersButtonClicked(sender As Object, e As RoutedEventArgs)
        For Each plot As Plot In graph.Plots
            plot.Renderer = Nothing
        Next

        Plot1DefaultRendererCheckBox.IsChecked = True
        Plot2DefaultRendererCheckBox.IsChecked = True
        Plot3DefaultRendererCheckBox.IsChecked = True
    End Sub

    Private Sub OnGenerateDataButtonClicked(sender As Object, e As RoutedEventArgs)
        GenerateData()
    End Sub

    Private Sub OnAddPlotButtonClicked(sender As Object, e As RoutedEventArgs)
        graph.Plots.Add(New Plot("Plot " & (graph.Plots.Count + 1)))
        GenerateData()
    End Sub

    Private Sub OnDefaultRendererCheckBoxChecked(sender As Object, e As RoutedEventArgs)
        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)
        Dim plot As Plot = DirectCast(checkbox.Tag, Plot)
        If plot IsNot Nothing Then
            plot.Renderer = Nothing
        End If
    End Sub

    Private Sub OnDefaultRendererCheckBoxUnchecked(sender As Object, e As RoutedEventArgs)
        Dim checkbox As CheckBox = DirectCast(sender, CheckBox)
        Dim plot As Plot = DirectCast(checkbox.Tag, Plot)
        If plot IsNot Nothing Then
            plot.Renderer = modifiedRenderer
        End If
    End Sub
End Class
