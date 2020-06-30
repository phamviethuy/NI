
Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports NationalInstruments.Controls
Imports NationalInstruments.Controls.Primitives

Partial Public Class MainWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()

        timestamp.Value = Date.Now
    End Sub

    Private Sub OnInteractionModeCheckBoxClicked(sender As Object, e As RoutedEventArgs)
        Dim checkbox As CheckBox = e.OriginalSource
        Dim flag As TimeStampTextBoxInteractionModes = checkbox.Content
        If checkbox.IsChecked Then
            timestamp.InteractionMode = timestamp.InteractionMode Or flag
        Else
            timestamp.InteractionMode = timestamp.InteractionMode And Not flag
        End If
    End Sub

    Private Sub OnRangeRadioButtonClicked(sender As Object, e As RoutedEventArgs)
        Dim button As RadioButton = e.OriginalSource
        Dim parent As Panel = button.Parent
        Dim index As Integer = parent.Children.IndexOf(button)

        Dim range As Range(Of Date)
        Dim interval As TimeSpan
        Select Case index
            Case 1
                Dim today As Date = Date.Now
                range = New Range(Of Date)(today, today.AddDays(1).AddSeconds(-1))
                interval = TimeSpan.FromHours(1)
            Case 2
                Dim year As New Date(Date.Now.Year, 1, 1)
                range = New Range(Of Date)(year, year.AddYears(1).AddSeconds(-1))
                interval = TimeSpan.FromDays(1)
            Case Else
                range = New Range(Of Date)(Date.MinValue, Date.MaxValue)
                interval = TimeSpan.FromSeconds(1)
        End Select

        timestamp.Range = range
        timestamp.Interval = interval
    End Sub

    Private Sub OnFormatRadioButtonClicked(sender As Object, e As RoutedEventArgs)
        Dim button As RadioButton = e.OriginalSource
        Dim format As String = button.Tag

        timestamp.ValueFormatter = New TimeValueFormatter(format)
    End Sub

End Class
