
using NationalInstruments;
using NationalInstruments.UI;
using System;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
	private const int NumberOfPoints = 75;
	private const int YRange = 10;
	private const int NumberOfSineWaves = 3;

	protected override void OnLoad(EventArgs e)
	{
		base.OnLoad(e);

		if (!IsPostBack)
		{
			double[] nanData = GenerateSineWave(NumberOfPoints, YRange, NumberOfSineWaves);
			for (int i = 1; i < nanData.Length; i++)
			{
				if ((i % 7) == 0)
					nanData[i] = Double.NaN;
			}
			waveformGraph.Plots[0].PlotY(nanData);

			double[] infinityData = GenerateSineWave(NumberOfPoints, YRange, NumberOfSineWaves);
			for (int i = 1; i < infinityData.Length; i++)
			{
				if ((i % 20) == 0)
					infinityData[i] = Double.PositiveInfinity;
				else if ((i % 10) == 0)
					infinityData[i] = Double.NegativeInfinity;
			}
			waveformGraph.Plots[1].PlotY(infinityData, -5, 1);
		}
	}

	protected void OnLegendItemNanBeforeDraw(object sender, NationalInstruments.UI.BeforeDrawLegendItemEventArgs e)
	{
		DrawLegendItem(e, waveformGraph.Plots[0]);
	}

	protected void OnLegendItemInfinityBeforeDraw(object sender, NationalInstruments.UI.BeforeDrawLegendItemEventArgs e)
	{
		DrawLegendItem(e, waveformGraph.Plots[1]);
	}

	private void DrawLegendItem(BeforeDrawLegendItemEventArgs e, XYPlot plot)
	{
		e.Cancel = true;
		e.Graphics.FillRectangle(Brushes.Black, e.ItemBounds);
		plot.DrawLines(new ComponentDrawArgs(e.Graphics, e.ItemBounds));
		e.Item.DrawText(new ComponentDrawArgs(e.Graphics, e.Bounds));
		waveformGraph.PlotAreaBorder.Draw(e.Item, new BorderDrawArgs(e.Graphics, e.ItemBounds));
	}

	private double[] GenerateSineWave(int numberOfPoints, int yRange, int numberOfSineWaves)
	{
		if (numberOfPoints < 0)
			throw new ArgumentOutOfRangeException("numberOfPoints");

		if (yRange < 0)
			throw new ArgumentOutOfRangeException("yRange");

		if (numberOfSineWaves < 0)
			throw new ArgumentOutOfRangeException("numberOfSineWaves");

		double[] data = new double[numberOfPoints];
		for (int i = 0; i < numberOfPoints; ++i)
			data[i] = yRange / 2 * (1 - (float)Math.Sin(i * 2 * Math.PI / ((numberOfPoints / numberOfSineWaves) - 1)));

		return data;
	}
}
