Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media
Imports NationalInstruments.Controls

''' <summary>
''' This example shows how different coercion modes work for a Knob of type Double. The user 
''' can see how the coercion works when directly manipulating the Knob and when a 
''' value is sent to the Knob.
''' </summary>
Partial Public Class MainWindow
    Inherits Window
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub CoercedValueChanged(sender As Object, args As Controls.ValueChangedEventArgs(Of Double))
        previousValueDouble.Value = doubleKnob.CoercionMode.GetMultipleIncrementValue(doubleKnob, doubleKnob.CoercedValue, -1)
        nextValueDouble.Value = doubleKnob.CoercionMode.GetMultipleIncrementValue(doubleKnob, doubleKnob.CoercedValue, 1)
    End Sub

    Private Sub OnNoneCoercionModeButtonChecked(sender As Object, e As RoutedEventArgs)
        doubleKnob.CoercionMode = NumericPointerCoercionMode.None
    End Sub

    Private Sub OnToDivisionsCoercionModeButtonChecked(sender As Object, e As RoutedEventArgs)
        doubleKnob.CoercionMode = NumericPointerCoercionMode.ToDivisions
    End Sub

    Private Sub OnToIntervalFromMinimumCoercionModeButtonChecked(sender As Object, e As RoutedEventArgs)
        doubleKnob.CoercionMode = NumericPointerCoercionMode.ToIntervalFromMinimum
    End Sub

    Private Sub OnToIntervalFromBaseCoercionModeButtonChecked(sender As Object, e As RoutedEventArgs)
        doubleKnob.CoercionMode = NumericPointerCoercionMode.CreateToIntervalFromBaseMode(intervalBaseDouble.Value)
    End Sub

    Private Sub OnIntervalBaseDoubleValueChanged(sender As Object, e As ValueChangedEventArgs(Of Double))
        doubleKnob.CoercionMode = NumericPointerCoercionMode.CreateToIntervalFromBaseMode(intervalBaseDouble.Value)
    End Sub

    Private Sub OnCommitButtonClick(sender As Object, e As RoutedEventArgs)
        doubleKnob.Value = setValueDouble.Value
    End Sub
End Class

