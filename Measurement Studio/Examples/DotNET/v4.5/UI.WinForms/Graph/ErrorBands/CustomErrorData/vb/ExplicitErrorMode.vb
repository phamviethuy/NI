
Imports System
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class ExplicitErrorMode
    Inherits XYErrorDataMode
    Private ReadOnly plot As ScatterPlot
    Private errorData() As Double

    Public Sub New(ByVal plot As ScatterPlot)
        Me.plot = plot
    End Sub

    Public Overrides Sub GetErrorData(ByVal args As XYErrorDataArgs, ByRef highErrorData() As Double, ByRef lowErrorData() As Double)
        ' Use whatever error data we were given when PlotXYWithError was called last.
        highErrorData = errorData
        lowErrorData = errorData
    End Sub

    Public Sub PlotXYWithError(ByVal xData() As Double, ByVal yData() As Double, ByVal errorData() As Double)
        Me.errorData = errorData

        plot.PlotXY(xData, yData)
    End Sub

End Class
