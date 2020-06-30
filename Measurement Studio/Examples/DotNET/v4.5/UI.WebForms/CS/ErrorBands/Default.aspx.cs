
using NationalInstruments.UI;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int DefaultDataLength = 61;

    private const int NoneIndex = 0;
    private const int ConstantIndex = 1;
    private const int PercentIndex = 2;

    private const int StaticDataIndex = 0;
    private const int PlottedDataIndex = 1;


	protected override void OnLoad(EventArgs e)
	{
        if (!IsPostBack)
        {
            UpdateErrorMode();
            Plot.PlotY(GenerateData(DefaultDataLength));
        }
	}

    protected void errorMode_SelectedIndexChanged(object sender, EventArgs e)
    {
        UpdateErrorMode();
    }

    protected void UpdateErrorMode()
    {
        switch (errorModeDropDownList.SelectedIndex)
        {
            case NoneIndex:
                Plot.YErrorDataMode = XYErrorDataMode.CreateNoneMode();
                break;

            case ConstantIndex:
                Plot.YErrorDataMode = XYErrorDataMode.CreateConstantErrorMode(6.0, 3.0);
                break;

            case PercentIndex:
                Plot.YErrorDataMode = XYErrorDataMode.CreatePercentErrorMode(5.0);
                break;
        }
    }

    protected void exampleData_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (exampleDataDropDownList.SelectedIndex)
        {
            case StaticDataIndex:
                refresh.Enabled = false;
                Plot.PlotY(GenerateData(DefaultDataLength));
                break;

            case PlottedDataIndex:
                Plot.PlotY(0);
                refresh.Enabled = true;
                break;
        }
    }

    protected void OnRefresh(object sender, RefreshEventArgs e)
    {
        Plot.PlotYAppend(Plot.HistoryCount);
    }


    private WaveformPlot Plot
    {
        get
        {
            return waveformGraph.Plots[0];
        }
    }

	private static double[] GenerateData(int length)
	{
        double[] data = new double[length];

        int halfWay = length / 2;
        for (int i = 0; i < length; ++i)
        {
            data[i] = i - halfWay;
        }

		return data;
	}
}
