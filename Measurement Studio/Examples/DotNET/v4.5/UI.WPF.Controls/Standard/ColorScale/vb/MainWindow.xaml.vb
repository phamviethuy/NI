Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports System.Windows.Shapes
Imports NationalInstruments.Controls

Partial Public Class MainWindow
    Inherits Window
    Private Shared ReadOnly GrayScaleMarkers As ColorScaleMarker() = {New ColorScaleMarker(0, Colors.Black), New ColorScaleMarker(10000, Colors.White)}
    Private Shared ReadOnly RedToneMarkers As ColorScaleMarker() = {New ColorScaleMarker(0, Colors.DarkRed), New ColorScaleMarker(2500, Colors.Brown), New ColorScaleMarker(5000, Colors.Red), New ColorScaleMarker(7500, Colors.Orange), New ColorScaleMarker(10000, Colors.Yellow)}
    Private Shared ReadOnly HighLowMarkers As ColorScaleMarker() = {New ColorScaleMarker(0, Colors.Blue), New ColorScaleMarker(10000, Colors.Red)}
    Private Shared ReadOnly HighNormalLowMarkers As ColorScaleMarker() = {New ColorScaleMarker(0, Colors.Blue), New ColorScaleMarker(5000, Colors.Lime), New ColorScaleMarker(10000, Colors.Red)}
    Private Shared ReadOnly RainbowMarkers As ColorScaleMarker() = {New ColorScaleMarker(0, Colors.DarkViolet), New ColorScaleMarker(1500, Colors.Indigo), New ColorScaleMarker(3000, Colors.Blue), New ColorScaleMarker(5000, Colors.Green), New ColorScaleMarker(7000, Colors.Yellow), New ColorScaleMarker(8500, Colors.Orange), _
        New ColorScaleMarker(10000, Colors.Red)}

    Private radioButtonsEnabled As Boolean

    Public Sub New()
        InitializeComponent()
        InitializeColorPickers()

        radioButtonsEnabled = True
        Dim data As Double(,) = GenerateIntensityData()
        intensityGraph.DataSource = data
        grayScaleColorsRadioButton.IsChecked = True
    End Sub

    Private Sub InitializeColorPickers()
        FillComboBoxWithColors(LowColorChooser)
        FillComboBoxWithColors(HighColorChooser)
        FillComboBoxWithColors(AddColorMarkerColorPicker)

        LowColorChooser.SelectedIndex = 0
        HighColorChooser.SelectedIndex = 1
        AddColorMarkerColorPicker.SelectedIndex = 1
    End Sub

    Private Shared Sub FillComboBoxWithColors(comboBox As ComboBox)
        AddColorToComboBox(comboBox, Colors.Black)
        AddColorToComboBox(comboBox, Colors.White)
        AddColorToComboBox(comboBox, Colors.Red)
        AddColorToComboBox(comboBox, Colors.Orange)
        AddColorToComboBox(comboBox, Colors.Yellow)
        AddColorToComboBox(comboBox, Colors.Green)
        AddColorToComboBox(comboBox, Colors.Cyan)
        AddColorToComboBox(comboBox, Colors.Blue)
        AddColorToComboBox(comboBox, Colors.Magenta)
        AddColorToComboBox(comboBox, Colors.Purple)
        AddColorToComboBox(comboBox, Colors.Transparent)
    End Sub

    Private Shared Sub AddColorToComboBox(ComboBox As ComboBox, color As Color)
        Dim rectangle As New Rectangle()
        rectangle.Margin = New Thickness(0, 4, 0, 4)
        rectangle.Width = 100
        rectangle.Height = 15
        rectangle.Fill = New SolidColorBrush(color)
        ComboBox.Items.Add(rectangle)
    End Sub

    Private Shared Function GetColor(comboBox As ComboBox) As Color
        Dim rectangle As Rectangle = TryCast(comboBox.SelectedItem, Rectangle)
        Return DirectCast(rectangle.Fill, SolidColorBrush).Color
    End Function

    Private Sub OnRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        ' A predefined ColorScale setting is selected. So just disable the custom radio button.
        If customColorsRadioButton.IsEnabled = True Then
            customColorsRadioButton.IsEnabled = False
        End If

        ConfigureColorScale()
    End Sub

    ' Configure the ColorScale for the selected predefined ColorScale setting.
    Private Sub ConfigureColorScale()
        If radioButtonsEnabled AndAlso Not CBool(customColorsRadioButton.IsChecked) Then
            colorScale.Markers.Clear()

            If CBool(grayScaleColorsRadioButton.IsChecked) Then
                colorScale.Markers.ReplaceAll(GrayScaleMarkers)
            ElseIf CBool(redToneColorsRadioButton.IsChecked) Then
                colorScale.Markers.ReplaceAll(RedToneMarkers)
            ElseIf CBool(highLowColorsRadioButton.IsChecked) Then
                colorScale.Markers.ReplaceAll(HighLowMarkers)
            ElseIf CBool(highNormalLowColorsRadioButton.IsChecked) Then
                colorScale.Markers.ReplaceAll(HighNormalLowMarkers)
            ElseIf CBool(rainbowColorsRadioButton.IsChecked) Then
                colorScale.Markers.ReplaceAll(RainbowMarkers)
            End If
        End If
    End Sub

    Private Function GenerateIntensityData() As Double(,)
        Dim size As Integer = 201
        Dim radius As Integer = 100
        Dim data As Double(,) = New Double(size - 1, size - 1) {}
        ' Here we generate data in a circular manner.
        ' Use the equation of a circle and transpose the origin.
        For i As Integer = -radius To radius
            For j As Integer = -radius To radius
                data(radius + i, radius + j) = i * i + j * j
            Next
        Next
        Return data
    End Function

    Private Sub OnLowColorChooserSelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Dim color As Color = GetColor(DirectCast(sender, ComboBox))
        colorScale.LowColor = color
    End Sub

    Private Sub OnHighColorChooserSelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Dim color As Color = GetColor(DirectCast(sender, ComboBox))
        colorScale.HighColor = color
    End Sub

    Private Sub OnAddColorMarkerButtonClicked(sender As Object, e As RoutedEventArgs)
        customColorsRadioButton.IsChecked = True
        customColorsRadioButton.IsEnabled = True

        Dim color As Color = GetColor(DirectCast(AddColorMarkerColorPicker, ComboBox))
        colorScale.Markers.Add(New ColorScaleMarker(AddColorMarkerNumericTextBox.Value, color))
    End Sub
End Class
