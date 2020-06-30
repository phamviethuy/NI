Imports NationalInstruments.UI

Public Class CustomCoercion : Inherits NumericCoercionMode

    Private noCoercionRange As Range
    Private toIntervalRange As Range
    Private Const noCoercionInterval As Double = 0.1

    Sub New(ByVal noCoercionRange As Range, ByVal toIntervalRange As Range)
        Me.noCoercionRange = noCoercionRange
        Me.toIntervalRange = toIntervalRange
    End Sub

    Overrides Function GetNextValue( _
    ByVal context As INumericControl, _
    ByVal args As NumericCoercionModeArgs _
    ) As Double

        Dim currentValue As Double = args.Value

        If ((currentValue < toIntervalRange.Maximum) And (currentValue >= toIntervalRange.Minimum)) Then

            Return NumericCoercionMode.ToInterval.GetNextValue(context, args)

        ElseIf ((currentValue < noCoercionRange.Maximum) And (currentValue >= noCoercionRange.Minimum)) Then

            Return currentValue + noCoercionInterval

        Else
            Return NumericCoercionMode.ToDivisions.GetNextValue(context, args)
        End If
    End Function

    Overrides Function GetPreviousValue( _
    ByVal context As INumericControl, _
    ByVal args As NumericCoercionModeArgs _
    ) As Double

        Dim currentValue As Double = args.Value

        If ((currentValue <= toIntervalRange.Maximum) And (currentValue >= toIntervalRange.Minimum)) Then
            Return NumericCoercionMode.ToInterval.GetPreviousValue(context, args)
        ElseIf ((currentValue <= noCoercionRange.Maximum) And (currentValue >= noCoercionRange.Minimum)) Then
            Return (currentValue - noCoercionInterval)
        Else
            Return NumericCoercionMode.ToDivisions.GetPreviousValue(context, args)
        End If

    End Function

    Overrides Function CoerceValue( _
    ByVal context As INumericControl, _
    ByVal args As NumericCoercionModeArgs _
    ) As Double
        Dim currentValue As Double = args.Value

        If ((currentValue < toIntervalRange.Maximum) And (currentValue >= toIntervalRange.Minimum)) Then
            Return NumericCoercionMode.ToInterval.CoerceValue(context, args)
        ElseIf ((currentValue < noCoercionRange.Maximum) And (currentValue >= noCoercionRange.Minimum)) Then
            Return currentValue
        Else
            Return NumericCoercionMode.ToDivisions.CoerceValue(context, args)
        End If
    End Function

    Overrides ReadOnly Property Name() As String
        Get
            Return "Custom Coercion Mode"
        End Get
    End Property

End Class
