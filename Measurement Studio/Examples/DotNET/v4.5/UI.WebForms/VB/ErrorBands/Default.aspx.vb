
Imports NationalInstruments.UI
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class DefaultAspx
    Inherits Page

    Const DefaultDataLength As Integer = 60

    Const NoneIndex As Integer = 0
    Const ConstantIndex As Integer = 1
    Const PercentIndex As Integer = 2

    Const StaticDataIndex As Integer = 0
    Const PlottedDataIndex As Integer = 1



    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        If Not IsPostBack Then
            UpdateErrorMode()
            Plot.PlotY(GenerateData(DefaultDataLength))
        End If
    End Sub

    Protected Sub errorMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles errorModeDropDownList.SelectedIndexChanged
        UpdateErrorMode()
    End Sub

    Protected Sub UpdateErrorMode()
        Select Case errorModeDropDownList.SelectedIndex
            Case NoneIndex
                Plot.YErrorDataMode = XYErrorDataMode.CreateNoneMode()
                Exit Sub

            Case ConstantIndex
                Plot.YErrorDataMode = XYErrorDataMode.CreateConstantErrorMode(6.0, 3.0)
                Exit Sub

            Case PercentIndex
                Plot.YErrorDataMode = XYErrorDataMode.CreatePercentErrorMode(5.0)
                Exit Sub
        End Select
    End Sub

    Protected Sub exampleData_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles exampleDataDropDownList.SelectedIndexChanged
        Select Case exampleDataDropDownList.SelectedIndex
            Case StaticDataIndex
                refresh.Enabled = False
                Plot.PlotY(GenerateData(DefaultDataLength))
                Exit Sub

            Case PlottedDataIndex
                Plot.PlotY(0)
                refresh.Enabled = True
                Exit Sub
        End Select
    End Sub
    Protected Sub OnRefresh(ByVal sender As Object, ByVal e As RefreshEventArgs)
        Plot.PlotYAppend(Plot.HistoryCount)
    End Sub


    Private ReadOnly Property Plot() As WaveformPlot
        Get
            Return waveformGraph.Plots(0)
        End Get
    End Property

    Private Shared Function GenerateData(ByVal length As Integer) As Double()
        Dim data() As Double = New Double(length) {}

        Dim halfWay As Integer = length / 2
        Dim i As Integer
        For i = 0 To length
            data(i) = i - halfWay
        Next

        Return data
    End Function
End Class