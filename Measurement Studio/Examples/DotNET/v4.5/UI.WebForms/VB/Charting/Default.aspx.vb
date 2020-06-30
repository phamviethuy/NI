
Imports NationalInstruments.UI

Partial Class DefaultAspx
    Inherits Page

    Private Const SessionKeyIsVertical As String = "Charting-IsVertical"
    Private Const SessionKeyData As String = "Charting-Data"
    Private Const SessionKeyIndex As String = "Charting-Index"
    Private Const SessionKeyCurrentX As String = "Charting-CurrentX"

    Private Const NumberOfPoints As Int32 = 100
    Private Const YRange As Int32 = 10

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)

        If Not IsPostBack Then
            Reset()
            UpdateAutoRefreshInterval()
            IsVertical = False
        End If

    End Sub

    Protected Sub OnEnabledStateChanged(ByVal sender As Object, ByVal e As ActionEventArgs)
        Reset()
        refresh.Enabled = enabled.Value
    End Sub

    Protected Sub OnChartVerticallyStateChanged(ByVal sender As Object, ByVal e As ActionEventArgs)
        IsVertical = chartVertically.Value
        Reset()
    End Sub

    Protected Sub OnRefresh(ByVal sender As Object, ByVal e As RefreshEventArgs)
        Dim x As Double
        Dim y As Double
        GetNextPoint(x, y)

        If (IsVertical) Then
            graph.PlotXAppend(x)
        Else
            graph.PlotYAppend(y)
        End If
    End Sub

    Protected Sub OnChartingModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Reset()
    End Sub

    Protected Sub OnRefreshIntervalSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateAutoRefreshInterval()
    End Sub

    Private Sub Reset()
        Dim xAxis As XAxis = graph.XAxes.Item(0)
        Dim yAxis As YAxis = graph.YAxes.Item(0)
        Dim chartingAxis As Axis = Nothing
        Dim scaleAxis As Axis = Nothing

        If chartVertically.Value Then
            chartingAxis = yAxis
            scaleAxis = xAxis
        Else
            chartingAxis = xAxis
            scaleAxis = yAxis
        End If

        scaleAxis.Mode = AxisMode.AutoScaleLoose
        Dim mode As AxisMode = CType([Enum].Parse(GetType(AxisMode), chartingMode.SelectedValue), AxisMode)
        chartingAxis.Mode = mode

        Index = -1
        CurrentX = 0

        xAxis.Range = New Range(0, 10)
        yAxis.Range = New Range(0, 10)
        graph.ClearData()

    End Sub

    Private Sub UpdateAutoRefreshInterval()
        Dim interval As Double = Double.Parse(refreshInterval.SelectedValue)
        refresh.Interval = TimeSpan.FromSeconds(interval)
    End Sub

    Private Property IsVertical() As Boolean
        Get
            Dim vertical As Boolean = False
            Dim sessionVertical As Object = Session.Item(SessionKeyIsVertical)
            If sessionVertical IsNot Nothing Then
                vertical = CType(sessionVertical, Boolean)
            End If

            Return vertical
        End Get
        Set(ByVal value As Boolean)
            Session(SessionKeyIsVertical) = value
        End Set
    End Property

    Private Property Index() As Int32
        Get
            Dim indexValue As Int32 = -1
            Dim sessionIndex As Object = Session.Item(SessionKeyIndex)
            If sessionIndex IsNot Nothing Then
                indexValue = CType(sessionIndex, Int32)
            End If

            Return indexValue
        End Get
        Set(ByVal value As Int32)
            Session.Item(SessionKeyIndex) = value
        End Set
    End Property

    Private Property CurrentX() As Double
        Get
            Dim currentXValue As Double = 0
            Dim sessionCurrentX As Object = Session.Item(SessionKeyCurrentX)
            If sessionCurrentX IsNot Nothing Then
                currentXValue = CType(sessionCurrentX, Double)
            End If

            Return currentXValue
        End Get
        Set(ByVal value As Double)
            Session.Item(SessionKeyCurrentX) = value
        End Set
    End Property

    Private Sub GetNextPoint(ByRef x As Double, ByRef y As Double)
        Index += 1
        If Index = NumberOfPoints Then
            Index = 1
        End If

        Dim data As Double() = GetData()

        If Not IsVertical Then
            x = CurrentX
            y = data(Index)
        Else
            x = data(Index)
            y = CurrentX
        End If

        CurrentX += 1

    End Sub

    Private Function GetData() As Double()
        Dim data As Double() = CType(Session.Item(SessionKeyData), Double())
        If data Is Nothing Then
            data = GenerateSineWave(NumberOfPoints, YRange)
            Session.Item(SessionKeyData) = data
        End If

        Return data
    End Function


    Private Shared Function GenerateSineWave(ByVal xRange As Int32, ByVal yRange As Int32) As Double()
        If xRange < 0 Then
            Throw New ArgumentOutOfRangeException("xRange")
        End If

        If yRange < 0 Then
            Throw New ArgumentOutOfRangeException("yRange")
        End If

        Dim data(xRange) As Double
        For i As Int32 = 0 To data.Length - 1
            data(i) = yRange / 2 * (1 - CType(Math.Sin(i * 2 * Math.PI / (xRange - 1)), Single))
        Next i

        Return data
    End Function





End Class
