
Imports System
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports NationalInstruments.Controls
Imports NationalInstruments.Controls.Data

Partial Public Class MainWindow
    Inherits Window

    Private Const DataCount As Integer = 56

    Public Sub New()
        InitializeComponent()
        InitializeGraph()

        AxisSynchronizer.AddSynchronizedAxis(graph, Orientation.Horizontal, horizontalAdjuster, horizontalMinimum, horizontalMaximum)
        AxisSynchronizer.AddSynchronizedAxis(graph, Orientation.Vertical, verticalAdjuster, verticalMinimum, verticalMaximum)
    End Sub

    'Graph initialization can be time consuming.  The code below initializes the graph during application load time.
    'This ensures that there will not be a delay during execution of your application.
    Private Sub InitializeGraph()
        graph.DataSource = New Double(1) {}
    End Sub

    Private Sub OnPlotDataClicked(sender As Object, e As RoutedEventArgs)
        ' Send a full plot of data to the graph.
        Dim random As New Random()
        Dim plotData As Double() = New Double(DataCount - 1) {}
        For i As Integer = 0 To DataCount - 1
            Dim value As Double = 1.2 * random.NextDouble() * Math.Sin(i * Math.PI * Math.PI / DataCount)
            plotData(i) = value
        Next

        graph.DataSource = plotData
    End Sub

    Private Sub OnChartDataClicked(sender As Object, e As RoutedEventArgs)
        ' Retrieve or create a chart collection, and append ten more points.
        Dim chartData = If(TryCast(graph.DataSource, ChartCollection(Of Double)), New ChartCollection(Of Double)(capacity:=DataCount))
        Dim random As New Random()
        Do
            Dim value As Double = 1.2 * random.NextDouble() * Math.Cos(chartData.Count * Math.PI * Math.PI / DataCount)
            chartData.Append(value)
        Loop While chartData.Count <= 1 OrElse Enumerable.Last(Of Sample(Of UInt64, Double))(chartData).Index Mod 10 <> 0

        graph.DataSource = chartData
    End Sub

    Private Sub OnClearDataClicked(sender As Object, e As RoutedEventArgs)
        ' Remove data from graph.
        graph.DataSource = Nothing
    End Sub


    Private NotInheritable Class AxisSynchronizer
        Private ReadOnly axis As AxisDouble
        Private ReadOnly minimum As NumericTextBoxDouble
        Private ReadOnly maximum As NumericTextBoxDouble
        Private updating As Boolean

        Public Shared Sub AddSynchronizedAxis(graph As Graph, orientation As Orientation, adjuster As ComboBox, minimum As NumericTextBoxDouble, maximum As NumericTextBoxDouble)
            ' Create axis for specified orientation and add to graph.
            Dim axis = New AxisDouble()
            axis.Orientation = orientation
            axis.Range = Range.Create(0.0, 20.0)
            graph.Axes.Add(axis)

            ' Bind adjuster to combo box's selection.
            adjuster.ItemsSource = EnumObject.GetValues(GetType(RangeAdjuster))
            adjuster.SelectedItem = axis.Adjuster
            Dim binding As New Binding()
            binding.Source = adjuster
            binding.Path = New PropertyPath(ComboBox.SelectedItemProperty)
            BindingOperations.SetBinding(axis, AxisDouble.AdjusterProperty, binding)

            ' Track changes to the axis range and the text boxes to keep values in sync.
            Dim synchronizer = New AxisSynchronizer(axis, minimum, maximum)
            synchronizer.OnAxisRangeChanged(axis, EventArgs.Empty)
        End Sub

        Private Sub New(axis As AxisDouble, minimum As NumericTextBoxDouble, maximum As NumericTextBoxDouble)
            Me.axis = axis
            Me.minimum = minimum
            Me.maximum = maximum

            AddHandler axis.RangeChanged, AddressOf OnAxisRangeChanged
            AddHandler minimum.ValueChanged, AddressOf OnValueChanged
            AddHandler maximum.ValueChanged, AddressOf OnValueChanged
        End Sub

        Private Sub OnAxisRangeChanged(sender As Object, e As EventArgs)
            If updating Then
                Return
            End If

            updating = True
            If True Then
                Dim range As Range(Of Double) = axis.Range
                minimum.Value = range.Minimum
                maximum.Value = range.Maximum
            End If
            updating = False
        End Sub

        Private Sub OnValueChanged(sender As Object, e As EventArgs)
            If updating Then
                Return
            End If

            Dim success As Boolean
            updating = True
            Try
                axis.Range = New Range(Of Double)(minimum.Value, maximum.Value)
                success = True
            Catch generatedExceptionName As ArgumentException
                success = False
            Finally
                updating = False
            End Try

            ' If the range was not valid, reset the text boxes to the current axis value.
            If Not success Then
                OnAxisRangeChanged(axis, EventArgs.Empty)
            End If
        End Sub
    End Class
End Class
