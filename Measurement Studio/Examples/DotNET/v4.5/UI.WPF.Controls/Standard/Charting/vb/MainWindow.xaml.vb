
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports NationalInstruments.Controls.Data
Imports System.Windows.Threading
Imports NationalInstruments.Controls

Partial Public Class MainWindow
    Inherits Window
    Private ReadOnly data As New ChartCollection(Of Double)(100)
    Private ReadOnly timer As New DispatcherTimer()
    Private ReadOnly rand As New Random()

    Public Sub New()
        InitializeComponent()
        graph.DataSource = data
        AddHandler timer.Tick, AddressOf OnTimerTick
        timer.Interval = New TimeSpan(0, 0, 0, 0, 100)
        timer.Start()
    End Sub

    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
        GenerateData()
    End Sub

    Private Sub GenerateData()
        data.Append(rand.NextDouble())
    End Sub

    Private Sub OnContinuousChecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        xAxis.Adjuster = RangeAdjuster.ContinuousChart
    End Sub

    Private Sub OnPagedChecked(ByVal sender As Object, ByVal e As RoutedEventArgs)
        xAxis.Adjuster = RangeAdjuster.PagedChart
    End Sub
End Class
