
using NationalInstruments.UI;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NationalInstruments;

public partial class Default : Page
{
    protected void OnPlotRealButtonClick(object sender, EventArgs e)
    {
        xDataGraph.Caption = "X Data (Timing)";
        yDataGraph.Caption = "Y Data (Real)";
        xyDataGraph.XAxes[0].Caption = "Timing";
        xyDataGraph.YAxes[0].Caption = "Real";

        int freq = 2;
        int numberOfSamples = 50;
        int amplitude = 30;

        ComplexDouble[] complexArray = new ComplexDouble[numberOfSamples];

        for (int x = 0; x < complexArray.Length; x++)
        {
            complexArray[x] = new ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)));
        }

        ComplexWaveform<ComplexDouble> complexWaveform = ComplexWaveform<ComplexDouble>.FromArray1D(complexArray);
        ComplexWaveformPlotOptions complexPlotOptions = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Real);
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(new PrecisionTimeSpan(new TimeSpan(0, 0, 2)), new PrecisionDateTime(new DateTime(1)));
        xyDataGraph.XAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xyDataGraph.PlotComplexWaveform<ComplexDouble>(complexWaveform, complexPlotOptions);

        xDataGraph.YAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xDataGraph.PlotY(xyDataGraph.Plots[0].GetXData());
        yDataGraph.PlotY(xyDataGraph.Plots[0].GetYData());
    }

    protected void OnPlotImaginaryButtonClick(object sender, EventArgs e)
    {
        xDataGraph.Caption = "X Data (Timing)";
        yDataGraph.Caption = "Y Data (Imaginary)";
        xyDataGraph.XAxes[0].Caption = "Timing";
        xyDataGraph.YAxes[0].Caption = "Imaginary";

        int freq = 2;
        int numberOfSamples = 50;
        int amplitude = 30;

        ComplexDouble[] complexArray = new ComplexDouble[numberOfSamples];

        for (int x = 0; x < complexArray.Length; x++)
        {
            complexArray[x] = new ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)));
        }

        ComplexWaveform<ComplexDouble> complexWaveform = ComplexWaveform<ComplexDouble>.FromArray1D(complexArray);
        ComplexWaveformPlotOptions complexPlotOptions = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Imaginary);
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(new PrecisionTimeSpan(new TimeSpan(0, 0, 2)), new PrecisionDateTime(new DateTime(1)));
        xyDataGraph.XAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xyDataGraph.PlotComplexWaveform<ComplexDouble>(complexWaveform, complexPlotOptions);

        xDataGraph.YAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xDataGraph.PlotY(xyDataGraph.Plots[0].GetXData());
        yDataGraph.PlotY(xyDataGraph.Plots[0].GetYData());
    }

    protected void OnPlotPhaseButtonClick(object sender, EventArgs e)
    {
        xDataGraph.Caption = "X Data (Timing)";
        yDataGraph.Caption = "Y Data (Phase)";
        xyDataGraph.XAxes[0].Caption = "Timing";
        xyDataGraph.YAxes[0].Caption = "Phase";
        
        int freq = 2;
        int numberOfSamples = 50;
        int amplitude = 30;

        ComplexDouble[] complexArray = new ComplexDouble[numberOfSamples];

        for (int x = 0; x < complexArray.Length; x++)
        {
            complexArray[x] = new ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)));
        }

        ComplexWaveform<ComplexDouble> complexWaveform = ComplexWaveform<ComplexDouble>.FromArray1D(complexArray);
        ComplexWaveformPlotOptions complexPlotOptions = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Phase);
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(new PrecisionTimeSpan(new TimeSpan(0, 0, 2)), new PrecisionDateTime(new DateTime(1)));
        xyDataGraph.XAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xyDataGraph.PlotComplexWaveform<ComplexDouble>(complexWaveform, complexPlotOptions);

        xDataGraph.YAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xDataGraph.PlotY(xyDataGraph.Plots[0].GetXData());
        yDataGraph.PlotY(xyDataGraph.Plots[0].GetYData());
    }

    protected void OnPlotMagnitudeButtonClick(object sender, EventArgs e)
    {
        xDataGraph.Caption = "X Data (Timing)";
        yDataGraph.Caption = "Y Data (Magnitude)";
        xyDataGraph.XAxes[0].Caption = "Timing";
        xyDataGraph.YAxes[0].Caption = "Magnitude";
        
        int freq = 2;
        int numberOfSamples = 50;
        int amplitude = 30;

        ComplexDouble[] complexArray = new ComplexDouble[numberOfSamples];

        for (int x = 0; x < complexArray.Length; x++)
        {
            complexArray[x] = new ComplexDouble(amplitude * (Math.Sin(2 * x * Math.PI * freq / numberOfSamples)), amplitude * (Math.Cos(2 * x * Math.PI * freq / numberOfSamples)));
        }

        ComplexWaveform<ComplexDouble> complexWaveform = ComplexWaveform<ComplexDouble>.FromArray1D(complexArray);
        ComplexWaveformPlotOptions complexPlotOptions = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Scaled, ComplexDataPart.Magnitude);
        complexWaveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(new PrecisionTimeSpan(new TimeSpan(0, 0, 2)), new PrecisionDateTime(new DateTime(1)));
        xyDataGraph.XAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xyDataGraph.PlotComplexWaveform<ComplexDouble>(complexWaveform, complexPlotOptions);

        xDataGraph.YAxes[0].MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss");
        xDataGraph.PlotY(xyDataGraph.Plots[0].GetXData());
        yDataGraph.PlotY(xyDataGraph.Plots[0].GetYData());
    }
}
