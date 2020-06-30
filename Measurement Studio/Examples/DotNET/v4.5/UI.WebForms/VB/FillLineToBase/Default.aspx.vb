
Imports NationalInstruments.UI
Imports System.ComponentModel
Imports System.Drawing

Partial Class DefaultAspx
    Inherits Page

    Private Const NumerSamples As Integer = 25
    Private Const Frequency As Single = 2

    Private Function GenerateData(ByVal phase As Double) As Double()
        Dim data(NumerSamples) As Double
        Dim angle As Double

        For x As Int32 = 0 To data.Length - 1
            angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase
            data(x) = Math.Sin(angle)
        Next x

        Return data
    End Function

    Private Function ParseValue(Of TValue)(ByVal value As String) As TValue
        Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(TValue))
        Return CType(converter.ConvertFromInvariantString(value), TValue)
    End Function

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        Dim plot1 As WaveformPlot = WaveformGraph1.Plots.Item(0)
        Dim plot2 As WaveformPlot = WaveformGraph1.Plots.Item(1)
        Dim baseValue As Double

        If (Double.TryParse(baseValueDropDown.SelectedValue, baseValue)) Then
            WaveformGraph1.PlotY(GenerateData(0))
            plot1.BaseYValue = baseValue
            plot1.LineStep = LineStep.CenteredXYStep
            plot1.FillBase = XYPlotFillBase.YValue
        Else
            plot1.PlotY(GenerateData(0))
            plot2.PlotY(GenerateData(Math.PI / 2))
            plot1.BasePlot = plot2
            plot1.FillBase = XYPlotFillBase.Plot
            plot1.LineStep = LineStep.None
        End If
    End Sub

    Protected Sub fillColorDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim plot As WaveformPlot = WaveformGraph1.Plots.Item(0)
        plot.FillToBaseColor = ParseValue(Of Color)(fillColorDropDown.SelectedValue)
    End Sub

    Protected Sub fillStyleDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim plot As WaveformPlot = WaveformGraph1.Plots.Item(0)
        plot.FillToBaseStyle = ParseValue(Of FillStyle)(fillStyleDropDown.SelectedValue)
    End Sub

    Protected Sub fillModeDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim plot As WaveformPlot = WaveformGraph1.Plots.Item(0)
        plot.FillMode = ParseValue(Of PlotFillMode)(fillModeDropDown.SelectedValue)
    End Sub

    Protected Sub lineColorDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim plot As WaveformPlot = WaveformGraph1.Plots.Item(0)
        plot.LineToBaseColor = ParseValue(Of Color)(lineColorDropDown.SelectedValue)
    End Sub

    Protected Sub lineStyleDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim plot As WaveformPlot = WaveformGraph1.Plots.Item(0)
        plot.LineToBaseStyle = ParseValue(Of LineStyle)(lineStyleDropDown.SelectedValue)
    End Sub
End Class
