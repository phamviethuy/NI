
using NationalInstruments.UI;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int DefaultDataLength = 100;

    protected void OnAutoscaleXRadioButtonCheckedChanged(object sender, EventArgs e)
    {
        SetXAxisScale();
    }

    protected void OnManualXRadioButtonCheckedChanged(object sender, EventArgs e)
    {
        SetXAxisScale();
    }

    protected void OnMinXAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetXAxisRange();
    }

    protected void OnMaxXAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetXAxisRange();
    }

    protected void OnAutoscaleYRadioButtonCheckedChanged(object sender, EventArgs e)
    {
        SetYAxisScale();
    }

    protected void OnManualYRadioButtonCheckedChanged(object sender, EventArgs e)
    {
        SetYAxisScale();
    }

    protected void OnMinYAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetYAxisRange();
    }

    protected void OnMaxYAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetYAxisRange();
    }

    protected void OnPlotDataButtonClick(object sender, EventArgs e)
    {
        waveformGraph.PlotY(GenerateData());
    }

    private void SetXAxisScale()
    {
        XAxis xAxis = waveformGraph.XAxes[0];

        if (autoscaleXRadioButton.Checked)
            xAxis.Mode = AxisMode.AutoScaleLoose;
        else if (manualXRadioButton.Checked)
        {
            xAxis.Mode = AxisMode.Fixed;
            SetXAxisRange();
        }

        bool manualXEnabled = manualXRadioButton.Checked;
        minX.Enabled = manualXEnabled;
        maxX.Enabled = manualXEnabled;
    }

    private void SetXAxisRange()
    {
        XAxis xAxis = waveformGraph.XAxes[0];
        xAxis.Range = new Range(minX.Value, maxX.Value);
    }

    private void SetYAxisScale()
    {
        YAxis yAxis = waveformGraph.YAxes[0];

        if (autoscaleYRadioButton.Checked)
            yAxis.Mode = AxisMode.AutoScaleLoose;
        else if (manualYRadioButton.Checked)
        {
            yAxis.Mode = AxisMode.Fixed;
            SetYAxisRange();
        }

        bool manualYEnabled = manualYRadioButton.Checked;
        minY.Enabled = manualYEnabled;
        maxY.Enabled = manualYEnabled;
    }

    private void SetYAxisRange()
    {
        YAxis yAxis = waveformGraph.YAxes[0];
        yAxis.Range = new Range(minY.Value, maxY.Value);
    }

    private static double[] GenerateData()
    {
        return GenerateData(DefaultDataLength);
    }

    private static double[] GenerateData(int dataLength)
    {
        if (dataLength < 0)
            throw new ArgumentOutOfRangeException("dataLength", dataLength, "Data length must be positive.");

        double[] data = new double[dataLength];
        Random rnd = new Random();

        for (int i = 0; i < dataLength; ++i)
            data[i] = (rnd.NextDouble() * Math.Sin(i / 3.15));

        return data;
    }
}
