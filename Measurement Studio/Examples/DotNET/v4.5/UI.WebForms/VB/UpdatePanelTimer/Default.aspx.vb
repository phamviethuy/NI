
Imports NationalInstruments.UI

Partial Class DefaultAspx
    Inherits Page

    Private Const SessionCurrentValueKey As String = "CurrentValue"
    Private Const SessionMinimumValueKey As String = "MinimumValue"
    Private Const SessionMaximumValueKey As String = "MaximumValue"
    Private Const SessionAverageValueKey As String = "AverageValue"

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

        If Not IsPostBack Then
            Initialize()
        End If

    End Sub

    Protected Sub Timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Dim plot As WaveformPlot = graph.Plots.Item(0)
        Dim rnd As Random = New Random()
        CurrentValue = (rnd.NextDouble() * 3.0) - ((CurrentValue - 2.0) * 0.85)

        currentValueID.Value = CurrentValue
        plot.PlotYAppend(CurrentValue)

        Dim values As Double() = plot.GetYData()
        Dim minimum As Double
        Dim maximum As Double
        GetMaxMin(values, minimum, maximum)
        Dim average As Double = GetAverageValue(values)

        If (maximum > MaximumValue) Then
            MaximumValue = maximum
            maximumValueID.Value = maximum
        End If

        If (minimum < MinimumValue) Then
            MinimumValue = minimum
            minimumValueID.Value = minimum
        End If

        If (Not (average = AverageValue)) Then
            AverageValue = average
            averageValueID.Value = average
        End If

    End Sub

    Protected Sub OnEnabledStateChanged(ByVal sender As Object, ByVal e As ActionEventArgs)
        timer.Enabled = enabled.Value

        If (enabled.Value) Then
            Initialize()
        Else
            UpdateControls()
        End If

    End Sub

    Private Sub UpdateControls()
        currentValueID.Value = CurrentValue
        minimumValueID.Value = MinimumValue
        maximumValueID.Value = MaximumValue
        averageValueID.Value = AverageValue
    End Sub

    Private Sub Initialize()
        CurrentValue = 0.0
        MinimumValue = 10.0
        MaximumValue = -10.0
        AverageValue = 0.0

        graph.ClearData()
    End Sub

    Private Property CurrentValue() As Double
        Get
            Return CType(Session.Item(SessionCurrentValueKey), Double)
        End Get
        Set(ByVal value As Double)
            Session.Item(SessionCurrentValueKey) = value
        End Set
    End Property

    Private Property MinimumValue() As Double
        Get
            Return CType(Session.Item(SessionMinimumValueKey), Double)
        End Get
        Set(ByVal value As Double)
            Session.Item(SessionMinimumValueKey) = value
        End Set
    End Property

    Private Property MaximumValue() As Double
        Get
            Return CType(Session.Item(SessionMaximumValueKey), Double)
        End Get
        Set(ByVal value As Double)
            Session.Item(SessionMaximumValueKey) = value
        End Set
    End Property

    Private Property AverageValue() As Double
        Get
            Return CType(Session.Item(SessionAverageValueKey), Double)
        End Get
        Set(ByVal value As Double)
            Session.Item(SessionAverageValueKey) = value
        End Set
    End Property

    Private Shared Sub GetMaxMin(ByVal values As Double(), ByRef minimum As Double, ByRef maximum As Double)
        If values Is Nothing Then
            Throw New ArgumentNullException("values")
        End If

        minimum = Double.MaxValue
        maximum = Double.MinValue

        For i As Int32 = 0 To values.Length - 1
            Dim currentValue As Double = values(i)

            If (currentValue < minimum) Then
                minimum = currentValue
            End If

            If (currentValue > maximum) Then
                maximum = currentValue
            End If
        Next i

    End Sub

    Private Shared Function GetAverageValue(ByVal values As Double()) As Double
        If values Is Nothing Then
            Throw New ArgumentNullException("values")
        End If

        Dim sum As Double = 0.0

        For i As Int32 = 0 To values.Length - 1
            sum += values(i)
        Next i

        Return sum / values.Length

    End Function

End Class

