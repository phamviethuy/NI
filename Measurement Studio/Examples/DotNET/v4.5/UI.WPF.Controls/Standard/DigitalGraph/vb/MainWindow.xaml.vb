
Imports System.Windows

Partial Public Class MainWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()

        ' Populate the graph with example data.
        Dim data As String() = New String() {"0X01000X1Z1Z101101", "0X01010X1Z0Z111010"}
        Dim waveform As New DigitalWaveform(data(0).Length, data.Length)
        For signalIndex As Integer = 0 To waveform.Signals.Count - 1
            Dim signal = waveform.Signals(signalIndex)
            For sampleIndex As Integer = 0 To waveform.Samples.Count - 1
                Dim state As DigitalState
                DigitalStateUtility.TryGetState(data(signalIndex)(sampleIndex), state)
                signal.States(sampleIndex) = state
            Next
        Next

        digitalGraph.DataSource = waveform
    End Sub

End Class
