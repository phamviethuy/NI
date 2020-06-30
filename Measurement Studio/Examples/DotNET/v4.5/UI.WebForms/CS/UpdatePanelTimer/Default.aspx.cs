
using NationalInstruments.UI;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const string SessionCurrentValueKey = "CurrentValue";
    private const string SessionMinimumValueKey = "MinimumValue";
    private const string SessionMaximumValueKey = "MaximumValue";
    private const string SessionAverageValueKey = "AverageValue";

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!IsPostBack)
            Initialize();
    }

    protected void Timer_Tick(object sender, EventArgs e)
    {
        WaveformPlot plot = graph.Plots[0];

        Random rnd = new Random();
        CurrentValue = (rnd.NextDouble() * 3.0) - ((CurrentValue - 2.0) * 0.85);

        currentValue.Value = CurrentValue;
        plot.PlotYAppend(CurrentValue);

        double[] values = plot.GetYData();
        double minimum, maximum;
        GetMaxMin(values, out minimum, out maximum);
        double average = GetAverageValue(values);

        if (maximum > MaximumValue)
        {
            MaximumValue = maximum;
            maximumValue.Value = maximum;
        }

        if (minimum < MinimumValue)
        {
            MinimumValue = minimum;
            minimumValue.Value = minimum;
        }

        if (average != AverageValue)
        {
            AverageValue = average;
            averageValue.Value = average;
        }
    }

    protected void OnEnabledStateChanged(object sender, ActionEventArgs e)
    {
        timer.Enabled = enabled.Value;

        if (enabled.Value)
            Initialize();
        else
            UpdateControls();
    }

    private void UpdateControls()
    {
        currentValue.Value = CurrentValue;
        minimumValue.Value = MinimumValue;
        maximumValue.Value = MaximumValue;
        averageValue.Value = AverageValue;
    }

    private void Initialize()
    {
        CurrentValue = 0.0;
        MinimumValue = 10.0;
        MaximumValue = -10.0;
        AverageValue = 0.0;

        graph.ClearData();
    }

    private double CurrentValue
    {
        get
        {
            return (double)Session[SessionCurrentValueKey];
        }

        set
        {
            Session[SessionCurrentValueKey] = value;
        }
    }

    private double MinimumValue
    {
        get
        {
            return (double)Session[SessionMinimumValueKey];
        }

        set
        {
            Session[SessionMinimumValueKey] = value;
        }
    }

    private double MaximumValue
    {
        get
        {
            return (double)Session[SessionMaximumValueKey];
        }

        set
        {
            Session[SessionMaximumValueKey] = value;
        }
    }

    private double AverageValue
    {
        get
        {
            return (double)Session[SessionAverageValueKey];
        }

        set
        {
            Session[SessionAverageValueKey] = value;
        }
    }

    private static void GetMaxMin(double[] values, out double minimum, out double maximum)
    {
        if (values == null)
            throw new ArgumentNullException("values");

        minimum = Double.MaxValue;
        maximum = Double.MinValue;

        for (int i = 0; i < values.Length; ++i)
        {
            double currentValue = values[i];

            if (currentValue < minimum)
                minimum = currentValue;

            if (currentValue > maximum)
                maximum = currentValue;
        }
    }

    private static double GetAverageValue(double[] values)
    {
        if (values == null)
            throw new ArgumentNullException("values");

        double sum = 0.0;
        for (int i = 0; i < values.Length; ++i)
            sum += values[i];

        return sum / values.Length;
    }
}

