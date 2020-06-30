Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Partial Public Class MainForm
    Inherits Form
    Private Const SampleCount As Integer = 100
    Private precisionTimes As PrecisionDateTime()
    Private plotOptions As ComplexWaveformPlotOptions
    Private phaseRange As New Range(-4, 1)
    Private normalRange As New Range(-90, 90)

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub
    Public Sub New()
        InitializeComponent()

        plotOptions = New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Samples, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Magnitude)

        'Initialize the Precision Date-Time array
        precisionTimes = New PrecisionDateTime(SampleCount - 1) {}
        precisionTimes(0) = New PrecisionDateTime(New DateTime(1970, 1, 1, 0, 0, 0))
        For i As Integer = 1 To SampleCount - 1
            precisionTimes(i) = precisionTimes(i - 1).AddMilliseconds(i)
        Next
    End Sub

    Private Function GenerateComplexWaveform() As ComplexWaveform(Of ComplexDouble)
        Dim amplitude As Integer = 30
        Dim frequency As Integer = 5
        Dim data As ComplexDouble() = New ComplexDouble(SampleCount - 1) {}
        For i As Integer = 0 To data.Length - 1
            data(i).Real = amplitude * (Math.Sin(2 * i * Math.PI * frequency / SampleCount))
            data(i).Imaginary = amplitude * (Math.Sin(2 * i * Math.PI * frequency / SampleCount))
        Next
        Dim waveform As ComplexWaveform(Of ComplexDouble) = ComplexWaveform(Of ComplexDouble).FromArray1D(data)

        waveform.ScaleMode = ComplexWaveformScaleMode.CreateLinearMode(2, 0)
        If noIntervalRadioButton.Checked Then

            waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithNoInterval(precisionTimes(0))
        ElseIf regularIntervalRadioButton.Checked Then
            waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(WaveformPlot.DefaultWaveformPrecisionTiming.SampleInterval)
        ElseIf irregularIntervalRadioButton.Checked Then
            waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithIrregularInterval(precisionTimes)
        End If
        Return waveform
    End Function

    Private Sub SetComplexWaveformPlotOptions(ByVal displayMode As ComplexWaveformPlotDisplayMode, ByVal scaleMode As ComplexWaveformPlotScaleMode, ByVal dataToPlot As ComplexDataPart)
        plotOptions = New ComplexWaveformPlotOptions(displayMode, scaleMode, dataToPlot)
    End Sub

    Private Sub PlotWaveform()
        sampleWaveformGraph.PlotComplexWaveform(Of ComplexDouble)(GenerateComplexWaveform(), plotOptions)
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        scaledDataRadioButton.Checked = True
        samplesRadioButton.Checked = True
        irregularIntervalRadioButton.Checked = True
        magnitudeRadioButton.Checked = True
        historyCapacityNumericEdit.Value = WaveformPlot.HistoryCapacity
        sampleWaveformGraph.YAxes(0).Range = normalRange

        ' Plot the Waveform once the default properties are set.
        PlotWaveform()
    End Sub

    Private Sub historyCapacityNumeric_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs) Handles historyCapacityNumericEdit.AfterChangeValue
        WaveformPlot.HistoryCapacity = CInt(historyCapacityNumericEdit.Value)
    End Sub

    Private Sub noIntervalRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles noIntervalRadioButton.CheckedChanged
        PlotWaveform()
    End Sub

    Private Sub regularIntervalRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles regularIntervalRadioButton.CheckedChanged
        PlotWaveform()
    End Sub

    Private Sub irregularIntervalRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles irregularIntervalRadioButton.CheckedChanged
        PlotWaveform()
    End Sub

    Private Sub rawDataRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rawDataRadioButton.CheckedChanged
        If rawDataRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetComplexWaveformPlotOptions(plotOptions.DisplayMode, ComplexWaveformPlotScaleMode.Raw, plotOptions.DataToPlot)
            PlotWaveform()
        End If
    End Sub

    Private Sub scaledDataRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles scaledDataRadioButton.CheckedChanged
        If scaledDataRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetComplexWaveformPlotOptions(plotOptions.DisplayMode, ComplexWaveformPlotScaleMode.Scaled, plotOptions.DataToPlot)
            PlotWaveform()
        End If
    End Sub

    Private Sub samplesRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles samplesRadioButton.CheckedChanged
        If samplesRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            XAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Numeric, "G5")
            SetComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Samples, plotOptions.ScaleMode, plotOptions.DataToPlot)
            PlotWaveform()
        End If
    End Sub

    Private Sub timeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles timeRadioButton.CheckedChanged
        If timeRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss.fff")
            SetComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, plotOptions.ScaleMode, plotOptions.DataToPlot)
            PlotWaveform()
        End If
    End Sub

    Private Sub realRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles realRadioButton.CheckedChanged
        If realRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Real)
            sampleWaveformGraph.YAxes(0).Range = normalRange
            PlotWaveform()
        End If
    End Sub

    Private Sub imaginaryRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles imaginaryRadioButton.CheckedChanged
        If imaginaryRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Imaginary)
            sampleWaveformGraph.YAxes(0).Range = normalRange
            PlotWaveform()
        End If
    End Sub

    Private Sub phaseRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles phaseRadioButton.CheckedChanged
        If phaseRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Phase)
            sampleWaveformGraph.YAxes(0).Range = phaseRange
            PlotWaveform()
        End If
    End Sub

    Private Sub magnitudeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles magnitudeRadioButton.CheckedChanged
        If magnitudeRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Magnitude)
            sampleWaveformGraph.YAxes(0).Range = normalRange
            PlotWaveform()
        End If
    End Sub

    Private Sub ChartWaveform()
        Dim waveform As ComplexWaveform(Of ComplexDouble) = GenerateComplexWaveform()

        'Modify the timing information so that the waveform charted is continuous.
        Dim latestDateTime As New PrecisionDateTime(New DateTime(0))
        Dim defaultInterval As PrecisionTimeSpan = WaveformPlot.DefaultWaveformPrecisionTiming.SampleInterval

        If WaveformPlot.HistoryCount > 0 Then
            latestDateTime = DirectCast(DataConverter.Convert(WaveformPlot.GetXData()(WaveformPlot.HistoryCount - 1), GetType(PrecisionDateTime)), PrecisionDateTime)
        End If

        If irregularIntervalRadioButton.Checked Then
            Dim localPrecisionTimes As PrecisionDateTime() = New PrecisionDateTime(SampleCount - 1) {}
            Dim localStartTime As DateTime = DirectCast(DataConverter.Convert(latestDateTime.AddMilliseconds(defaultInterval.TotalMilliseconds), GetType(DateTime)), DateTime)
            localPrecisionTimes(0) = New PrecisionDateTime(localStartTime)
            For i As Integer = 1 To SampleCount - 1
                localPrecisionTimes(i) = localPrecisionTimes(i - 1).AddMilliseconds(i)
            Next
            waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithIrregularInterval(localPrecisionTimes)
        Else
            waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(defaultInterval, latestDateTime.AddMilliseconds(defaultInterval.TotalMilliseconds))
        End If

        sampleWaveformGraph.Plots(0).DefaultComplexWaveformPlotOptions = plotOptions
        sampleWaveformGraph.PlotComplexWaveformAppend(Of ComplexDouble)(waveform)
    End Sub

    Private Sub plotDataAppendTimer_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles plotDataAppendTimer.Tick
        If chartWaveformCheckBox.Checked Then
            ChartWaveform()
        End If
    End Sub

    Private Sub chartWaveformCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartWaveformCheckBox.CheckedChanged
        If chartWaveformCheckBox.Checked Then
            plotDataAppendTimer.Enabled = True
            ChartWaveform()
        Else
            plotDataAppendTimer.Enabled = False
            sampleWaveformGraph.ClearData()
            PlotWaveform()
        End If
    End Sub
End Class

