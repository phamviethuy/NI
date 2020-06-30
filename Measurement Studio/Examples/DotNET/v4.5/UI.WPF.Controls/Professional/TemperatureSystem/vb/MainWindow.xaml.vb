Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports NationalInstruments.Controls
Imports NationalInstruments.Analysis.Math
Imports System.Collections.Generic
Imports System.Windows.Threading

''' <summary>
''' This example simulates acquiring temperatures using a histogram and a waveform graph.
''' </summary>
Partial Public Class MainWindow
    Inherits Window
    Private random As Random
    Private chartCollection As ChartCollection(Of Double)
    Private pointsForAnalysis As List(Of Double)
    Private timer As DispatcherTimer
    Private lastStatus As String

    Const UPPERLIMIT As Double = 90
    Const LOWERLIMIT As Double = 70

    Public Sub New()
        timer = New DispatcherTimer()
        AddHandler timer.Tick, AddressOf OnMainTimerTick

        InitializeComponent()

        AddHandler lowerLimitRangeCursor.PositionChanged, AddressOf OnLowerLimitRangeCursorPositionChanged
        AddHandler upperLimitRangeCursor.PositionChanged, AddressOf OnUpperLimitRangeCursorPositionChanged
        AddHandler lowLimitKnob.ValueChanged, AddressOf OnLowLimitKnobValueChanged
        AddHandler upperLimitKnob.ValueChanged, AddressOf OnUpperLimitKnobValueChanged

        chartCollection = New ChartCollection(Of Double)(1000)
        temperatureGraph.DataSource = chartCollection

        random = New Random()
        pointsForAnalysis = New List(Of Double)()
    End Sub

    Private Sub OnMainTimerTick(sender As Object, e As EventArgs)
        ' Get random new temperature between 70 and 90
        Dim currentTemp As Double = (random.NextDouble() * 20) + 70
        currentTemperature.Value = currentTemp

        ' Update TemperatureGraph
        chartCollection.Append(currentTemp)

        UpdateAnalysis(currentTemp)
    End Sub

    Private Sub UpdateAnalysis(currentTemp As Double)
        If analyze.Value Then
            pointsForAnalysis.Add(currentTemp)
            If pointsForAnalysis.Count >= 1000 Then
                pointsForAnalysis.RemoveAt(0)
            End If
            Dim analysisPoints As Double() = pointsForAnalysis.ToArray()

            Dim centerValues As Double()

            Dim histogram As Integer() = Statistics.Histogram(analysisPoints, minimumBin.Value, maximumBin.Value, 25, centerValues)

            Dim histogramData As Point() = New Point(histogram.Length - 1) {}
            For i As Integer = 0 To histogram.Length - 1
                histogramData(i) = New Point(centerValues(i), histogram(i))
            Next

            temperatureHistogram.DataSource = histogramData

            standardDeviation.Value = Statistics.StandardDeviation(analysisPoints)
            meanTemperature.Value = Statistics.Mean(analysisPoints)
        End If
    End Sub

    Private Sub OnUpdateRateValueChanged(sender As Object, e As ValueChangedEventArgs(Of Double))
        timer.Interval = New TimeSpan(0, 0, 0, 0, CInt(e.NewValue * 1000))
    End Sub

    Private Sub OnAcquireValueChanged(sender As Object, e As RoutedEventArgs)
        If acquire.Value Then
            timer.Start()
            statusBar.Text = "Acquiring..."
            ClearHistogramData()
            acquireMenuItem.IsChecked = True
            acquireToolbarButton.IsChecked = True
        Else
            timer.[Stop]()
            statusBar.Text = "Ready."
            acquireMenuItem.IsChecked = False
            acquireToolbarButton.IsChecked = False
        End If
    End Sub

    Private Sub OnAnalyzeValueChanged(sender As Object, e As RoutedEventArgs)
        ClearHistogramData()
        analyzeMenuItem.IsChecked = analyze.Value
        analyzeToolbarButton.IsChecked = analyze.Value
    End Sub

    Private Sub ClearHistogramData()
        If analyze.Value Then
            minimumBin.IsEnabled = False
            maximumBin.IsEnabled = False

            temperatureHistogram.DataSource = Nothing
            pointsForAnalysis.Clear()
            standardDeviation.Value = standardDeviation.Range.Minimum
            meanTemperature.Value = meanTemperature.Range.Minimum
        Else
            minimumBin.IsEnabled = True

            maximumBin.IsEnabled = True
        End If
    End Sub

    Private Sub OnUpperLimitRangeCursorPositionChanged(sender As Object, e As EventArgs)
        If CDbl(upperLimitRangeCursor.ActualVerticalRange.GetMinimum()) < CDbl(lowerLimitRangeCursor.ActualVerticalRange.GetMaximum()) Then
            upperLimitRangeCursor.VerticalRange = Range.Create(lowerLimitRangeCursor.ActualVerticalRange.GetMaximum(), UPPERLIMIT)
        End If
        If CDbl(upperLimitRangeCursor.ActualVerticalRange.GetMaximum()) < UPPERLIMIT Then
            upperLimitRangeCursor.VerticalRange = Range.Create(upperLimitRangeCursor.ActualVerticalRange.GetMinimum(), UPPERLIMIT)
        End If
        If CDbl(upperLimitRangeCursor.ActualVerticalRange.GetMinimum()) > UPPERLIMIT Then
            upperLimitRangeCursor.VerticalRange = Range.Create(UPPERLIMIT, UPPERLIMIT)
        End If
        upperLimitKnob.Value = CDbl(upperLimitRangeCursor.ActualVerticalRange.GetMinimum())
    End Sub

    Private Sub OnLowerLimitRangeCursorPositionChanged(sender As Object, e As EventArgs)
        If CDbl(upperLimitRangeCursor.ActualVerticalRange.GetMinimum()) < CDbl(lowerLimitRangeCursor.ActualVerticalRange.GetMaximum()) Then
            lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, upperLimitRangeCursor.ActualVerticalRange.GetMinimum())
        End If
        If CDbl(lowerLimitRangeCursor.ActualVerticalRange.GetMinimum()) > LOWERLIMIT Then
            lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, lowerLimitRangeCursor.ActualVerticalRange.GetMaximum())
        End If
        If CDbl(lowerLimitRangeCursor.ActualVerticalRange.GetMaximum()) < LOWERLIMIT Then
            lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, LOWERLIMIT)
        End If
        lowLimitKnob.Value = CDbl(lowerLimitRangeCursor.ActualVerticalRange.GetMaximum())
    End Sub

    Private Sub OnLowLimitKnobValueChanged(sender As Object, e As ValueChangedEventArgs(Of Double))
        If e.NewValue < LOWERLIMIT Then
            lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, LOWERLIMIT)
            lowLimitKnob.Value = LOWERLIMIT
        Else
            lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, e.NewValue)
        End If
    End Sub

    Private Sub OnUpperLimitKnobValueChanged(sender As Object, e As ValueChangedEventArgs(Of Double))
        If e.NewValue > UPPERLIMIT Then
            upperLimitRangeCursor.VerticalRange = Range.Create(UPPERLIMIT, UPPERLIMIT)
            upperLimitKnob.Value = UPPERLIMIT
        Else
            upperLimitRangeCursor.VerticalRange = Range.Create(e.NewValue, UPPERLIMIT)
        End If
    End Sub

    Private Sub OnMinimumBinValueChanging(sender As Object, e As ValueChangingEventArgs(Of Double))
        If e.NewValue >= maximumBin.Value OrElse e.NewValue < LOWERLIMIT Then
            e.Cancel = True
        End If
    End Sub

    Private Sub OnMaximumBinValueChanging(sender As Object, e As ValueChangingEventArgs(Of Double))
        If e.NewValue <= minimumBin.Value OrElse e.NewValue > UPPERLIMIT Then
            e.Cancel = True
        End If
    End Sub

    Private Sub OnAnalyzeMenuChecked(sender As Object, e As RoutedEventArgs)
        analyze.Value = True
    End Sub

    Private Sub OnAnalyzeMenuUnchecked(sender As Object, e As RoutedEventArgs)
        analyze.Value = False
    End Sub

    Private Sub OnAcquireMenuChecked(sender As Object, e As RoutedEventArgs)
        acquire.Value = True
    End Sub

    Private Sub OnAcquireMenuUnchecked(sender As Object, e As RoutedEventArgs)
        acquire.Value = False
    End Sub

    Private Sub OnExitMenuItemClick(sender As Object, e As RoutedEventArgs)
        Close()
    End Sub

    Private Sub OnAcquireToolbarButtonClick(sender As Object, e As RoutedEventArgs)
        acquire.Value = acquireToolbarButton.IsChecked.Value
    End Sub

    Private Sub OnAnalyzeToolbarButtonClick(sender As Object, e As RoutedEventArgs)
        analyze.Value = analyzeToolbarButton.IsChecked.Value
    End Sub

    Private Sub OnMenuItemMouseEnter(sender As Object, e As System.Windows.Input.MouseEventArgs)
        Dim item As MenuItem = TryCast(sender, MenuItem)
        If item IsNot Nothing Then
            lastStatus = statusBar.Text
            Dim newStatus As String = TryCast(item.ToolTip, String)
            statusBar.Text = If(newStatus Is Nothing, lastStatus, newStatus)
        End If
    End Sub

    Private Sub OnMenuItemMouseLeave(sender As Object, e As System.Windows.Input.MouseEventArgs)
        statusBar.Text = lastStatus
    End Sub
End Class