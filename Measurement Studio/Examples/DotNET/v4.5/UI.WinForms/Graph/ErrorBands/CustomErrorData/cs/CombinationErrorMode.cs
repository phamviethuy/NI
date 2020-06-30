
using System;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomErrorData
{

	public class CombinationErrorMode : XYErrorDataMode
	{
        private readonly double constantOffset;
        private readonly double percentOffset;
        private readonly int threshold;

		public CombinationErrorMode(double constantOffset, double percentOffset, int threshold)
		{
            this.constantOffset = constantOffset;
            this.percentOffset = percentOffset;
			this.threshold = threshold;
		}

		public override void GetErrorData(XYErrorDataArgs args, out double[] highErrorData, out double[] lowErrorData)
		{
			double[] data;
            double[] xData = args.GetXData();
            switch(args.PrimaryErrorDataType)
			{
				case XYDataType.XData:
					data = xData;
					break;

				case XYDataType.YData:
					data = args.GetYData();
					break;

				default:
					data = new double[0];
					break;
			}

			highErrorData = new double[data.Length];
			lowErrorData = new double[data.Length];
            double offset;
            for(int i = 0; i < data.Length; ++i)
			{
				// If the x value of a data point goes over the threshold, use a percentage.
				if(xData[i] > threshold)
				{
                    offset = data[i] * (percentOffset / 100);
				}
				// Otherwise, use a constant value.
				else
				{
					offset = constantOffset;
				}

                highErrorData[i] = offset;
                lowErrorData[i] = offset;
			}
		}

	}

}
