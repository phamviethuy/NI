Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Threading
Imports NationalInstruments.Controls
Imports NationalInstruments.Controls.Data

Partial Public Class MainWindow
    Inherits Window
    Private ReadOnly data As ChartCollection(Of Double)
    Private ReadOnly timer As DispatcherTimer

    Public Sub New()
        data = New ChartCollection(Of Double)()
        DataContext = data

        InitializeComponent()

        timer = New DispatcherTimer(TimeSpan.FromSeconds(1.0 / 3.0), DispatcherPriority.Normal, AddressOf OnTimerTick, Dispatcher)
    End Sub

    Private Sub OnPauseChecked(sender As Object, e As RoutedEventArgs)
        timer.IsEnabled = False

        fitGraph.DefaultInteraction = GraphInteraction.PanHorizontal
        fitVisibleGraph.DefaultInteraction = GraphInteraction.PanHorizontal
    End Sub

    Private Sub OnPauseUnchecked(sender As Object, e As RoutedEventArgs)
        timer.IsEnabled = True

        fitGraph.DefaultInteraction = GraphInteraction.None
        fitVisibleGraph.DefaultInteraction = GraphInteraction.None
    End Sub

    Private Sub OnClearClicked(sender As Object, e As RoutedEventArgs)
        data.Clear()
    End Sub

    ' Plot random data on every timer tick.
    Private random As New Random()
    Private Const NoiseFrequency As Integer = 20
    Private counter As Integer = NoiseFrequency \ 2
    Private Sub OnTimerTick(sender As Object, e As EventArgs)
        counter += 1
        Dim dataPoint As Double = random.NextDouble() - 0.5

        ' Introduce extra noise every few points.
        If counter Mod NoiseFrequency = 0 Then
            dataPoint *= NoiseFrequency * 2
        End If

        data.Append(dataPoint)
    End Sub
End Class
