
using NationalInstruments;
using NationalInstruments.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int NumerSamples = 25;
    private const float Frequency = 2;

    private double[] GenerateData(double phase)
    {
        double[] data = new double[NumerSamples];
        double angle;

        for (int x = 0; x < data.Length; x++)
        {
            angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase;
            data[x] = Math.Sin(angle);
        }

        return data;
    }

    private TValue ParseValue<TValue>(string value)
    {
        TypeConverter converter = TypeDescriptor.GetConverter(typeof(TValue));
        return (TValue)converter.ConvertFromInvariantString(value);
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        WaveformPlot plot1 = WaveformGraph1.Plots[0];
        WaveformPlot plot2 = WaveformGraph1.Plots[1];
        double baseValue;

        if (double.TryParse(baseValueDropDown.SelectedValue, out baseValue))
        {
            WaveformGraph1.PlotY(GenerateData(0));
            plot1.BaseYValue = baseValue;
            plot1.LineStep = LineStep.CenteredXYStep;
            plot1.FillBase = XYPlotFillBase.YValue;
        }
        else //to plot
        {

            plot1.PlotY(GenerateData(0));
            plot2.PlotY(GenerateData(Math.PI / 2));
            plot1.BasePlot = plot2;
            plot1.FillBase = XYPlotFillBase.Plot;
            plot1.LineStep = LineStep.None;
        }

    }

    protected void fillColorDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        WaveformPlot plot = WaveformGraph1.Plots[0];
        plot.FillToBaseColor = ParseValue<Color>(fillColorDropDown.SelectedValue);
    }

    protected void fillStyleDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        WaveformPlot plot = WaveformGraph1.Plots[0];
        plot.FillToBaseStyle = ParseValue<FillStyle>(fillStyleDropDown.SelectedValue);
    }

    protected void fillModeDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        WaveformPlot plot = WaveformGraph1.Plots[0];
        plot.FillMode = ParseValue<PlotFillMode>(fillModeDropDown.SelectedValue);
    }

    protected void lineColorDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        WaveformPlot plot = WaveformGraph1.Plots[0];
        plot.LineToBaseColor = ParseValue<Color>(lineColorDropDown.SelectedValue);
    }

    protected void lineStyleDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        WaveformPlot plot = WaveformGraph1.Plots[0];
        plot.LineToBaseStyle = ParseValue<LineStyle>(lineStyleDropDown.SelectedValue);
    }
}
