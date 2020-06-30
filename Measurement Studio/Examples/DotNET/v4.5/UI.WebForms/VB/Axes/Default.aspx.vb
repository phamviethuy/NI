
Imports NationalInstruments.UI
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class DefaultAspx
    Inherits Page

    Const DefaultDataLength As Integer = 100

    Protected Sub OnAutoscaleXRadioButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetXAxisScale()
    End Sub

    Protected Sub OnManualXRadioButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetXAxisScale()
    End Sub

    Protected Sub OnMinXAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetXAxisRange()
    End Sub

    Protected Sub OnMaxXAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetXAxisRange()
    End Sub

    Protected Sub OnAutoscaleYRadioButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetYAxisScale()
    End Sub

    Protected Sub OnManualYRadioButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetYAxisScale()
    End Sub

    Protected Sub OnMinYAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetYAxisRange()
    End Sub

    Protected Sub OnMaxYAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetYAxisRange()
    End Sub

    Protected Sub OnPlotDataButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        waveformGraph.PlotY(GenerateData())
    End Sub

    Private Sub SetXAxisScale()
        Dim axis As XAxis = waveformGraph.XAxes(0)

        If (autoscaleXRadioButton.Checked) Then
            axis.Mode = AxisMode.AutoScaleLoose
        ElseIf (manualXRadioButton.Checked) Then
            axis.Mode = AxisMode.Fixed
            SetXAxisRange()
        End If

        Dim manualXEnabled As Boolean = manualXRadioButton.Checked
        minX.Enabled = manualXEnabled
        maxX.Enabled = manualXEnabled
    End Sub

    Private Sub SetXAxisRange()
        Dim axis As XAxis = waveformGraph.XAxes(0)
        axis.Range = New Range(minX.Value, maxX.Value)
    End Sub

    Private Sub SetYAxisScale()
        Dim axis As YAxis = waveformGraph.YAxes(0)

        If (autoscaleYRadioButton.Checked) Then
            axis.Mode = AxisMode.AutoScaleLoose
        ElseIf (manualYRadioButton.Checked) Then
            axis.Mode = AxisMode.Fixed
            SetYAxisRange()
        End If

        Dim manualYEnabled As Boolean = manualYRadioButton.Checked
        minY.Enabled = manualYEnabled
        maxY.Enabled = manualYEnabled
    End Sub

    Private Sub SetYAxisRange()
        Dim axis As YAxis = waveformGraph.YAxes(0)
        axis.Range = New Range(minY.Value, maxY.Value)
    End Sub

    Private Shared Function GenerateData() As Double()
        Return GenerateData(DefaultDataLength)
    End Function

    Private Shared Function GenerateData(ByVal dataLength As Integer) As Double()
        If (dataLength < 0) Then
            Throw New ArgumentNullException("dataLength")
        End If

        Dim data(dataLength) As Double
        Dim rnd As Random = New Random()

        For i As Integer = 0 To dataLength
            data(i) = rnd.NextDouble() * Math.Sin(i / 3.15)
        Next

        Return data
    End Function
End Class
