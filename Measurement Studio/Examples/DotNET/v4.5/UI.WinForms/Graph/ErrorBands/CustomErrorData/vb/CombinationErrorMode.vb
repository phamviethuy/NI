
Imports System
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class CombinationErrorMode
    Inherits XYErrorDataMode
    Private ReadOnly constantOffset As Double
    Private ReadOnly percentOffset As Double
    Private ReadOnly threshold As Integer

    Public Sub New(ByVal constantOffset As Double, ByVal percentOffset As Double, ByVal threshold As Integer)
        Me.constantOffset = constantOffset
        Me.percentOffset = percentOffset
        Me.threshold = threshold
    End Sub

    Public Overrides Sub GetErrorData(ByVal args As XYErrorDataArgs, ByRef highErrorData() As Double, ByRef lowErrorData() As Double)
        Dim data() As Double
        Dim xData() As Double = args.GetXData()
        Select Case args.PrimaryErrorDataType
            Case XYDataType.XData
                data = xData

            Case XYDataType.YData
                data = args.GetYData()

            Case Else
                data = New Double(0) {}
        End Select

        highErrorData = New Double(data.Length - 1) {}
        lowErrorData = New Double(data.Length - 1) {}
        Dim offset As Double
        Dim i As Integer
        For i = 0 To data.Length - 1
            If xData(i) > threshold Then
                ' If the x value of a data point goes over the threshold, use a percentage.
                offset = data(i) * percentOffset
            Else
                ' Otherwise, use a constant value.
                offset = constantOffset
            End If

            highErrorData(i) = offset
            lowErrorData(i) = offset
        Next
    End Sub

End Class

