Imports System
Imports NationalInstruments.UI

Public Class SineSignal
    '========================================================================================== 
    ' This is a helper class that is used to generate the data and timing information to create 
    ' an analog waveform. The data this generates is a sine wave. 
    '========================================================================================== 

    Private numberOfSamples As Integer = 1000
    Private sampleIntervalMode As WaveformSampleIntervalMode = WaveformSampleIntervalMode.None
    Private frequency As Double = 3
    Private amplitude As Double = 10
    Private baseTime As DateTime = DateTime.Now

    Public Sub New()
    End Sub

    Public Sub Configure(ByVal noOfSamples As Integer, ByVal intervalMode As WaveformSampleIntervalMode, ByVal freq As Double, ByVal amp As Double)
        numberOfSamples = noOfSamples
        sampleIntervalMode = intervalMode
        frequency = freq
        amplitude = amp
    End Sub

    Public Function GenerateData() As Double()
        Dim data As Double() = New Double(numberOfSamples - 1) {}
        For i As Integer = 0 To data.Length - 1
            data(i) = amplitude * (Math.Sin(2 * i * Math.PI * frequency / numberOfSamples))
        Next
        Return data
    End Function

    Public Function GenerateTiming() As WaveformTiming
        Dim timing As WaveformTiming
        If sampleIntervalMode = WaveformSampleIntervalMode.None Then
            timing = WaveformTiming.CreateWithNoInterval(baseTime)
        ElseIf sampleIntervalMode = WaveformSampleIntervalMode.Regular Then
            timing = WaveformTiming.CreateWithRegularInterval(New TimeSpan(0, 0, 1), baseTime)
            baseTime += New TimeSpan(0, 0, numberOfSamples)
        Else
            Dim times As DateTime() = New DateTime(numberOfSamples - 1) {}
            times(0) = baseTime
            Dim r As New Random()
            For j As Integer = 1 To numberOfSamples - 1
                times(j) = times(j - 1) + New TimeSpan(0, 0, r.[Next](10))
            Next
            baseTime = times(numberOfSamples - 1) + New TimeSpan(0, 0, r.[Next](10))
            timing = WaveformTiming.CreateWithIrregularInterval(times)
        End If
        Return timing
    End Function
End Class
