Imports NationalInstruments.UI
Imports System
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports NationalInstruments

Partial Class DefaultAspx
    Inherits Page

    Protected Sub OnPlotRealButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        xDataGraph.Caption = "X Data (Timing)"
        yDataGraph.Caption = "Y Data (Real)"
        xyDataGraph.XAxes(0).Caption = "Timing"
        xyDataGraph.YAxes(0).Caption = "Real"

        Dim x As Integer
        Const numberOfSamples As Integer = 50
        Const freq As Integer = 2
        Dim complexArray(numberOfSamples - 1) As ComplexDouble
        Dim amplitude As Integer = 30

        For x = 0 To complexArray.Length - 1
            complexArray(x) = New ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)))
        Next

        Dim complexWaveform As ComplexWaveform(Of ComplexDouble)
        complexWaveform = NationalInstruments.ComplexWaveform(Of NationalInstruments.ComplexDouble).FromArray1D(complexArray)
        Dim complexPlotOptions As ComplexWaveformPlotOptions = New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Real)
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(New PrecisionTimeSpan(New TimeSpan(0, 0, 2)), New PrecisionDateTime(New DateTime(1)))
        xyDataGraph.XAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xyDataGraph.PlotComplexWaveform(Of ComplexDouble)(complexWaveform, complexPlotOptions)

        xDataGraph.YAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xDataGraph.PlotY(xyDataGraph.Plots(0).GetXData())
        yDataGraph.PlotY(xyDataGraph.Plots(0).GetYData())
    End Sub
    Protected Sub OnPlotImaginaryButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        xDataGraph.Caption = "X Data (Timing)"
        yDataGraph.Caption = "Y Data (Imaginary)"
        xyDataGraph.XAxes(0).Caption = "Timing"
        xyDataGraph.YAxes(0).Caption = "Imaginary"

        Dim x As Integer
        Const numberOfSamples As Integer = 50
        Const freq As Integer = 2
        Dim complexArray(numberOfSamples - 1) As ComplexDouble
        Dim amplitude As Integer = 30

        For x = 0 To complexArray.Length - 1
            complexArray(x) = New ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)))
        Next

        Dim complexWaveform As ComplexWaveform(Of ComplexDouble)
        complexWaveform = NationalInstruments.ComplexWaveform(Of NationalInstruments.ComplexDouble).FromArray1D(complexArray)
        Dim complexPlotOptions As ComplexWaveformPlotOptions = New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Imaginary)
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(New PrecisionTimeSpan(New TimeSpan(0, 0, 2)), New PrecisionDateTime(New DateTime(1)))
        xyDataGraph.XAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xyDataGraph.PlotComplexWaveform(Of ComplexDouble)(complexWaveform, complexPlotOptions)

        xDataGraph.YAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xDataGraph.PlotY(xyDataGraph.Plots(0).GetXData())
        yDataGraph.PlotY(xyDataGraph.Plots(0).GetYData())
    End Sub

    Protected Sub OnPlotPhaseButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        xDataGraph.Caption = "X Data (Timing)"
        yDataGraph.Caption = "Y Data (Phase)"
        xyDataGraph.XAxes(0).Caption = "Timing"
        xyDataGraph.YAxes(0).Caption = "Phase"

        Dim x As Integer
        Const numberOfSamples As Integer = 50
        Const freq As Integer = 2
        Dim complexArray(numberOfSamples - 1) As ComplexDouble
        Dim amplitude As Integer = 30

        For x = 0 To complexArray.Length - 1
            complexArray(x) = New ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)))
        Next

        Dim complexWaveform As ComplexWaveform(Of ComplexDouble)
        complexWaveform = NationalInstruments.ComplexWaveform(Of NationalInstruments.ComplexDouble).FromArray1D(complexArray)
        Dim complexPlotOptions As ComplexWaveformPlotOptions = New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Phase)
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(New PrecisionTimeSpan(New TimeSpan(0, 0, 2)), New PrecisionDateTime(New DateTime(1)))
        xyDataGraph.XAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xyDataGraph.PlotComplexWaveform(Of ComplexDouble)(complexWaveform, complexPlotOptions)

        xDataGraph.YAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xDataGraph.PlotY(xyDataGraph.Plots(0).GetXData())
        yDataGraph.PlotY(xyDataGraph.Plots(0).GetYData())
    End Sub

    Protected Sub OnPlotMagnitudeButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        xDataGraph.Caption = "X Data (Timing)"
        yDataGraph.Caption = "Y Data (Magnitude)"
        xyDataGraph.XAxes(0).Caption = "Timing"
        xyDataGraph.YAxes(0).Caption = "Magnitude"

        Dim x As Integer
        Const numberOfSamples As Integer = 50
        Const freq As Integer = 2
        Dim complexArray(numberOfSamples - 1) As ComplexDouble
        Dim amplitude As Integer = 30

        For x = 0 To complexArray.Length - 1
            complexArray(x) = New ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)))
        Next

        Dim complexWaveform As ComplexWaveform(Of ComplexDouble)
        complexWaveform = NationalInstruments.ComplexWaveform(Of NationalInstruments.ComplexDouble).FromArray1D(complexArray)
        Dim complexPlotOptions As ComplexWaveformPlotOptions = New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Magnitude)
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(New PrecisionTimeSpan(New TimeSpan(0, 0, 2)), New PrecisionDateTime(New DateTime(1)))
        xyDataGraph.XAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xyDataGraph.PlotComplexWaveform(Of ComplexDouble)(complexWaveform, complexPlotOptions)

        xDataGraph.YAxes(0).MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss")
        xDataGraph.PlotY(xyDataGraph.Plots(0).GetXData())
        yDataGraph.PlotY(xyDataGraph.Plots(0).GetYData())
    End Sub


End Class
