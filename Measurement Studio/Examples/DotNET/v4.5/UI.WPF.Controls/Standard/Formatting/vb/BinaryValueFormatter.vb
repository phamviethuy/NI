Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports NationalInstruments.Controls.Primitives
Imports NationalInstruments.DataInfrastructure.Descriptors

''' <summary>
'''  This class is a ValueFormatter which converts numeric values to a binary string.
''' </summary>
Public Class BinaryValueFormatter
    Inherits ValueFormatter
    Private padding As Integer

    Public Sub New(pad As Integer)
        padding = pad
    End Sub

    Protected Overrides Function FormatCore(Of TData)(value As TData, args As ValuePresenterArgs) As String
        If value Is Nothing Then
            Return String.Empty
        End If
        Dim integerValue As Long = Convert.ToInt64(value)

        ' Convert the integer value to a binary string and then apply padding if necessary
        Dim result As New StringBuilder(Convert.ToString(integerValue, 2))
        While result.Length < padding
            result.Insert(0, "0")
        End While
        Return result.ToString()
    End Function

    Public Overrides Function Parse(Of TData)(value As String, args As ValuePresenterArgs) As TData
        Dim integerValue As Long = Convert.ToInt64(value, 2)
        ' In order to convert the integer into the specific TData type we get a formatter for TData
        ' and then use that formatter to convert a string of the integer into type TData
        Dim formatter As IOpFormat(Of TData) = TryCast(DataTypeDescriptors.GetDescriptorInstance(Of TData)(), IOpFormat(Of TData))
        If formatter Is Nothing Then
            Throw New System.ArgumentException("Cannot parse into type {" + GetType(TData).Name + "}", "TData")
        End If

        Dim parsedValue As TData = formatter.Parse(integerValue.ToString(args.Culture), Nothing, args.Culture)

        Return parsedValue
    End Function

    Public Overrides Function TryParse(Of TData)(value As String, args As ValuePresenterArgs, ByRef parsedValue As TData) As Boolean
        Dim integerValue As Long = Convert.ToInt64(value, 2)

        ' In order to convert the integer into the specific TData type we get a formatter for TData
        ' and then use that formatter to convert a string of the integer into type TData
        Dim formatter As IOpFormat(Of TData) = TryCast(DataTypeDescriptors.GetDescriptorInstance(Of TData)(), IOpFormat(Of TData))
        Dim succeeded As Boolean
        If formatter Is Nothing Then
            succeeded = False
            parsedValue = Nothing
        Else
            succeeded = formatter.TryParse(integerValue.ToString(args.Culture), Nothing, args.Culture, parsedValue)
        End If

        Return succeeded
    End Function

    Protected Overrides Function CreateInstanceCore() As System.Windows.Freezable
        Return New BinaryValueFormatter(0)
    End Function
End Class