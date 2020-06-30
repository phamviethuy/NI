
using System;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomErrorData
{

	public class ExplicitErrorMode : XYErrorDataMode
	{
        private readonly ScatterPlot plot;
        private double[] errorData;

		public ExplicitErrorMode(ScatterPlot plot)
		{
            this.plot = plot;
		}

		public override void GetErrorData(XYErrorDataArgs args, out double[] highErrorData, out double[] lowErrorData)
		{
            // Use whatever error data we were given when PlotXYWithError was called last.
            highErrorData = errorData;
            lowErrorData = errorData;
        }

        public void PlotXYWithError(double[] xData, double[] yData, double[] errorData)
        {
            this.errorData = errorData;

            plot.PlotXY(xData, yData);
        }

	}

}
