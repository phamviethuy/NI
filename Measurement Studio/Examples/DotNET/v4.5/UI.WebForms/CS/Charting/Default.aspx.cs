
using NationalInstruments.UI;
using System;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const string SessionKeyIsVertical = "Charting-IsVertical";
    private const string SessionKeyData = "Charting-Data";
    private const string SessionKeyIndex = "Charting-Index";
    private const string SessionKeyCurrentX = "Charting-CurrentX";

    private const int NumberOfPoints = 100;
    private const int YRange = 10;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!IsPostBack)
        {
            Reset();
            UpdateAutoRefreshInterval();

            IsVertical = false;
        }
    }

    protected void OnEnabledStateChanged(object sender, ActionEventArgs e)
    {
        Reset();
        refresh.Enabled = enabled.Value;
    }

    protected void OnChartVerticallyStateChanged(object sender, ActionEventArgs e)
    {
        IsVertical = chartVertically.Value;
        Reset();
    }

    protected void OnRefresh(object sender, RefreshEventArgs e)
    {
        double x, y;
        GetNextPoint(out x, out y);

        if (IsVertical)
            graph.PlotXAppend(x);
        else
            graph.PlotYAppend(y);
    }

    protected void OnChartingModeSelectedIndexChanged(object sender, EventArgs e)
    {
        Reset();
    }

    protected void OnRefreshIntervalSelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateAutoRefreshInterval();
    }

    private void Reset()
    {
        XAxis xAxis = graph.XAxes[0];
        YAxis yAxis = graph.YAxes[0];

        Axis chartingAxis = null, scaleAxis = null;
        if (chartVertically.Value)
        {
            chartingAxis = yAxis;
            scaleAxis = xAxis;
        }
        else
        {
            chartingAxis = xAxis;
            scaleAxis = yAxis;
        }

        scaleAxis.Mode = AxisMode.AutoScaleLoose;
        AxisMode mode = (AxisMode)Enum.Parse(typeof(AxisMode), chartingMode.SelectedValue);
        chartingAxis.Mode = mode;

        Index = -1;
        CurrentX = 0;

        xAxis.Range = yAxis.Range = new Range(0, 10);
        graph.ClearData();
    }

    private void UpdateAutoRefreshInterval()
    {
        double interval = Double.Parse(refreshInterval.SelectedValue);
        refresh.Interval = TimeSpan.FromSeconds(interval);
    }

    private bool IsVertical
    {
        get
        {
            bool vertical = false;

            object sessionVertical = Session[SessionKeyIsVertical];
            if (sessionVertical != null)
                vertical = (bool)sessionVertical;

            return vertical;
        }

        set
        {
            Session[SessionKeyIsVertical] = value;
            Reset();
        }
    }

    private int Index
    {
        get
        {
            int index = -1;

            object sessionIndex = Session[SessionKeyIndex];
            if (sessionIndex != null)
                index = (int)sessionIndex;

            return index;
        }

        set
        {
            Session[SessionKeyIndex] = value;
        }
    }

    private double CurrentX
    {
        get
        {
            double currentX = 0;

            object sessionCurrentX = Session[SessionKeyCurrentX];
            if (sessionCurrentX != null)
                currentX = (double)sessionCurrentX;

            return currentX;
        }

        set
        {
            Session[SessionKeyCurrentX] = value;
        }
    }

    private void GetNextPoint(out double x, out double y)
    {
        ++Index;
        if (Index == NumberOfPoints)
            Index = 1;

        double[] data = GetData();
        if (!IsVertical)
        {
            x = CurrentX;
            y = data[Index];
        }
        else
        {
            x = data[Index];
            y = CurrentX;
        }

        ++CurrentX;
    }

    private double[] GetData()
    {
        double[] data = Session[SessionKeyData] as double[];
        if (data == null)
        {
            data = GenerateSineWave(NumberOfPoints, YRange);
            Session[SessionKeyData] = data;
        }

        return data;
    }

    private static double[] GenerateSineWave(int xRange, int yRange)
    {
        if (xRange < 0)
            throw new ArgumentOutOfRangeException("xRange");

        if (yRange < 0)
            throw new ArgumentOutOfRangeException("yRange");

        double[] data = new double[xRange];
        for (int i = 0; i < xRange; ++i)
            data[i] = yRange / 2 * (1 - (float)Math.Sin(i * 2 * Math.PI / (xRange - 1)));

        return data;
    }
}
