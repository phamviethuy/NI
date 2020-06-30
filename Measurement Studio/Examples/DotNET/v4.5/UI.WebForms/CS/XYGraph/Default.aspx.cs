
using NationalInstruments.UI;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const double TwoPi = Math.PI * 2;
    private const double HalfPi = Math.PI / 2;

    protected void OnPlotCircleButtonClick(object sender, EventArgs e)
    {
        const int pointCount = 50;
        const int divisor = pointCount - 1;

        double[] dataX = new double[pointCount];
        double[] dataY = new double[pointCount];

        for (int i = 0; i < pointCount; ++i)
        {
            double current = ((double)i / divisor) * TwoPi;
            dataX[i] = Math.Cos(current) * HalfPi;
            dataY[i] = Math.Sin(current) * HalfPi;
        }

        xyDataGraph.PlotXY(dataX, dataY);
        xDataGraph.PlotY(dataX);
        yDataGraph.PlotY(dataY);
    }

    protected void OnPlotOctagonButtonClick(object sender, EventArgs e)
    {
        const int numberOfSides = 8;
        const int pointCount = numberOfSides + 1;

        double[] dataX = new double[pointCount];
        double[] dataY = new double[pointCount];

        for (int i = 0; i < pointCount; ++i)
        {
            dataX[i] = Math.Cos(((i + 0.5) / numberOfSides) * TwoPi);
            dataY[i] = Math.Sin(((i + 0.5) / numberOfSides) * TwoPi);
        }

        xyDataGraph.PlotXY(dataX, dataY);
        xDataGraph.PlotY(dataX);
        yDataGraph.PlotY(dataY);
    }

    protected void OnPlotPolarButtonClick(object sender, EventArgs e)
    {
        const int numberOfPoints = 360;
        const int divisor = numberOfPoints - 1;
        double[] dataR = new double[numberOfPoints];
        double[] dataP = new double[numberOfPoints];
        double[] dataX = new double[numberOfPoints];
        double[] dataY = new double[numberOfPoints];

        // Calculate data in polar coordinates.
        for (int i = 0; i < numberOfPoints; ++i)
        {
            dataP[i] = i;
            dataR[i] = Math.Sin(((double)i / divisor) * TwoPi * 3) + 0.5;
        }

        // Convert polar coordinates to XY coordinates.
        for (int i = 0; i < numberOfPoints; ++i)
        {
            double current = (dataP[i] / numberOfPoints) * TwoPi;
            dataX[i] = Math.Cos(current) * dataR[i];
            dataY[i] = Math.Sin(current) * dataR[i];
        }

        xyDataGraph.PlotXY(dataX, dataY);
        xDataGraph.PlotY(dataX);
        yDataGraph.PlotY(dataY);
    }

    protected void OnPlotSpiralButtonClick(object sender, EventArgs e)
    {
        const int numberOfPoints = 360;
        double[] dataR = new double[numberOfPoints];
        double[] dataP = new double[numberOfPoints];
        double[] dataX = new double[numberOfPoints];
        double[] dataY = new double[numberOfPoints];

        // Calculate data in polar coordinates.
        for (int i = 0; i < numberOfPoints; ++i)
        {
            dataP[i] = i * 10;
            dataR[i] = Math.Pow(i, 2) / 70000;
        }

        // Convert polar coordinates to XY coordinates.
        for (int i = 0; i < numberOfPoints; ++i)
        {
            double current = (dataP[i] / numberOfPoints) * TwoPi;
            dataX[i] = Math.Cos(current) * dataR[i];
            dataY[i] = Math.Sin(current) * dataR[i];
        }

        xyDataGraph.PlotXY(dataX, dataY);
        xDataGraph.PlotY(dataX);
        yDataGraph.PlotY(dataY);
    }
}
