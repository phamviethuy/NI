Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports NationalInstruments.Controls
Imports NationalInstruments.Controls.Data
Imports NationalInstruments.Controls.Rendering

Class MainWindow
    Inherits Window
    Public Sub New()
        InitializeComponent()
        InitializeGraph()
        AddHandler graph.InputData.Changed, AddressOf OnInputDataChanged
    End Sub

    'Graph initialization can be time consuming.  The code below initializes the graph during application load time.
    'This ensures that there will not be a delay during execution of your application.
    Private Sub InitializeGraph()
        graph.DataSource = New Double(1) {}
    End Sub

    Private Sub GenerateData()
        Dim random As New Random()
        Dim dataCount As Integer = 101

        Dim newData As Double() = New Double(dataCount - 1) {}
        For i As Integer = 0 To dataCount - 1
            newData(i) = random.NextDouble() * 100
        Next

        graph.DataSource = newData
    End Sub

    Private Sub OnInputDataChanged(sender As Object, e As EventArgs)
        Dim collection As InputDataCollection = DirectCast(sender, InputDataCollection)
        dataCountTextBox.Text = collection.Count.ToString()
    End Sub

    Private Sub OnGenerateDataButtonClicked(sender As Object, e As RoutedEventArgs)
        GenerateData()
    End Sub

    Private Sub OnNewInputPlotButtonClicked(sender As Object, e As RoutedEventArgs)
        'The SelectedPlot is cleared so that a new input plot will be generated
        graph.SelectedPlot = Nothing
    End Sub

    Private Sub OnDrawPlotRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        graph.DefaultInteraction = GraphEditInteraction.EditWaveform
    End Sub

    Private Sub OnZoomOutRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        graph.DefaultInteraction = GraphInteraction.ZoomOut
    End Sub

    Private Sub OnZoomInRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        graph.DefaultInteraction = GraphInteraction.ZoomIn
    End Sub

    Private Sub OnPanRadioButtonChecked(sender As Object, e As RoutedEventArgs)
        graph.DefaultInteraction = GraphInteraction.Pan
    End Sub

    Private Sub OnComboBoxSelectionChanged(sender As Object, e As System.Windows.Controls.SelectionChangedEventArgs)
        Dim box As ComboBox = DirectCast(sender, ComboBox)
        Select Case box.SelectedIndex
            Case 0
                InputData.SetDataInterval(horizontalAxis, 1)
                Exit Select
            Case 1
                InputData.SetDataInterval(horizontalAxis, 5)
                Exit Select
            Case 2
                InputData.SetDataInterval(horizontalAxis, 10)
                Exit Select
        End Select
    End Sub
End Class