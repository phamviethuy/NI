Imports System
Imports System.Windows
Imports NationalInstruments.Controls

Partial Public Class MainWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub powerLimitSlider_ValueChanging(sender As Object, e As ValueChangingEventArgs(Of Double))
        If e.NewValue < powerGauge.Value Then
            e.NewValue = powerGauge.Value
        End If
    End Sub

    Private Sub voltageSlider_ValueChanging(sender As Object, e As ValueChangingEventArgs(Of Double))
        Dim power As Double = GetPower(e.NewValue, resistanceSlider.Value)
        If power > powerLimitSlider.Value Then
            e.NewValue = Math.Sqrt(powerLimitSlider.Value * resistanceSlider.Value)
            voltageSlider.Value = e.NewValue
        End If
    End Sub

    Private Sub voltageSlider_ValueChanged(sender As Object, e As ValueChangedEventArgs(Of Double))
        powerGauge.Value = GetPower(e.NewValue, resistanceSlider.Value)
    End Sub

    Private Sub resistanceSlider_ValueChanging(sender As Object, e As ValueChangingEventArgs(Of Double))
        Dim power As Double = GetPower(voltageSlider.Value, e.NewValue)
        If power > powerLimitSlider.Value Then
            e.NewValue = GetPower(voltageSlider.Value, powerLimitSlider.Value)
        End If
    End Sub

    Private Sub resistanceSlider_ValueChanged(sender As Object, e As ValueChangedEventArgs(Of Double))
        powerGauge.Value = GetPower(voltageSlider.Value, e.NewValue)
    End Sub

    Private Function GetPower(voltage As Double, resistance As Double) As Double
        Return (voltage * voltage) / resistance
    End Function
End Class
