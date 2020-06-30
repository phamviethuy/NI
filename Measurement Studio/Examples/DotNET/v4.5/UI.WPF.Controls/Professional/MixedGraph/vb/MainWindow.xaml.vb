
Imports System
Imports System.Windows
Imports NationalInstruments.Controls

Partial Public Class MainWindow
    Inherits Window

    Private Const DataCount As Integer = 66

    Public Sub New()
        InitializeComponent()
        PlotDigitalData()
        PlotAnalogData()
    End Sub

    Private Sub OnPlotDigitalDataClicked(sender As Object, e As RoutedEventArgs)
        PlotDigitalData()
    End Sub

    Private Sub OnPlotAnalogDataClicked(sender As Object, e As RoutedEventArgs)
        PlotAnalogData()
    End Sub

    Private Sub OnClearDataClicked(sender As Object, e As RoutedEventArgs)
        mixedGraph.Data.Clear()
    End Sub

    Private Sub PlotDigitalData()
        Const DigitalReductionFactor As Integer = 10

        Dim random As New Random()
        Dim randomValues As Byte() = New Byte(1 + DataCount / DigitalReductionFactor) {}
        random.NextBytes(randomValues)

        Dim digitalData As Byte() = New Byte(DataCount) {}
        For i As Integer = 0 To DataCount - 1
            digitalData(i) = randomValues(i / DigitalReductionFactor)
        Next

        mixedGraph.Data(0) = digitalData
    End Sub

    Private Sub PlotAnalogData()
        Dim random As New Random()
        Dim analogData As Double() = New Double(DataCount) {}
        For i As Integer = 0 To DataCount - 1
            Dim value As Double = 12.3 * random.NextDouble() * Math.Sin(i * Math.PI * Math.PI / DataCount)
            analogData(i) = value
        Next

        mixedGraph.Data(1) = analogData
    End Sub

    Private Sub OnAnalogPositionSliderValueChanged(sender As Object, e As ValueChangedEventArgs(Of Integer))
        Dim change As Double = e.NewValue - e.OldValue
        Dim currentRange As Range(Of Double) = yAxis.Range
        yAxis.Range = New Range(Of Double)(currentRange.Minimum + change, currentRange.Maximum + change)
    End Sub

End Class
