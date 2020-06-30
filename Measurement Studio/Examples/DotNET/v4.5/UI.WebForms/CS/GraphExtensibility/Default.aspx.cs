
using NationalInstruments;
using NationalInstruments.UI;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    protected override void OnInit(EventArgs e)
    {
        waveformGraph.BeforeDrawPlot += new BeforeDrawXYPlotEventHandler(OnBeforeDrawPlot);
        waveformGraph.AfterDrawPlot += new AfterDrawXYPlotEventHandler(OnAfterDrawPlot);
        waveformGraph.BeforeDrawPlotArea += new BeforeDrawEventHandler(OnBeforeDrawPlotArea);
    }

    protected override void OnLoad(EventArgs e)
    {
        if (!IsPostBack)
        {
            DateTime start;
            DateTime end;
            TimeSpan increment;

            start = DateTime.Today;
            end = DateTime.Today + TimeSpan.FromHours(24);
            increment = TimeSpan.FromMinutes(30);

            XAxis xAxis = waveformGraph.XAxes[0];
            YAxis yAxis = waveformGraph.YAxes[0];

            xAxis.Mode = AxisMode.Fixed;
            xAxis.AutoSpacing = false;
            xAxis.MajorDivisions.Base = (double) DataConverter.Convert(start, typeof(double));
            xAxis.MajorDivisions.Interval = (double) DataConverter.Convert(TimeSpan.FromHours(6), typeof(double));
            xAxis.MinorDivisions.Interval = (double) DataConverter.Convert(TimeSpan.FromHours(1), typeof(double));
            xAxis.Range = new Range((double) DataConverter.Convert(start, typeof(double)), (double) DataConverter.Convert(end, typeof(double)));

            yAxis.Mode = AxisMode.Fixed;
            yAxis.Range = new Range(-1.0, 1.0);

            waveformGraph.Plots[0].PlotY(GenerateData(), start, increment);
        }
    }

    protected void OnAfterDrawPlot(object sender, AfterDrawXYPlotEventArgs e)
    {
        if (listExtensibleStyles.SelectedValue.Equals("HighlightMinMax"))
        {
            double yMin = Double.MaxValue, yMax = Double.MinValue;
            double xIndexMin = 0, xIndexMax = 0;
            double currentY = 0, currentX = 0;

            for (int i = 0; i < e.Plot.HistoryCount; ++i)
            {
                e.Plot.GetDataPoint(i, out currentX, out currentY);

                if (currentY < yMin)
                {
                    yMin = currentY;
                    xIndexMin = currentX;
                }
                if (currentY > yMax)
                {
                    yMax = currentY;
                    xIndexMax = currentX;
                }
            }

            HighlightDataPoint(e, xIndexMin, yMin);
            HighlightDataPoint(e, xIndexMax, yMax);
        }
    }

    protected void OnBeforeDrawPlot(object sender, BeforeDrawXYPlotEventArgs e)
    {
        if (listExtensibleStyles.SelectedValue.Equals("HighlightIncDec"))
        {
            // Clip data, iterate through clipped data, map, and draw.
            XYPlot plot = e.Plot;
            double[] clippedXData = null, clippedYData = null;
            plot.ClipDataPoints(out clippedXData, out clippedYData);
            for (int i = 0; i < clippedXData.Length - 1; ++i)
            {
                double x1 = clippedXData[i], x2 = clippedXData[i + 1], y1 = clippedYData[i], y2 = clippedYData[i + 1];

                PointF point1 = plot.MapDataPoint(e.Bounds, x1, y1);
                PointF point2 = plot.MapDataPoint(e.Bounds, x1, y2);
                PointF point3 = plot.MapDataPoint(e.Bounds, x2, y2);

                Pen pen = null;
                if (y2 > y1)
                    pen = Pens.LimeGreen;
                else if (y2 == y1)
                    pen = Pens.Yellow;
                else
                    pen = Pens.Red;

                Graphics g = e.Graphics;
                g.DrawLines(pen, new PointF[] { point1, point2, point3 });
            }

            e.Cancel = true;
        }
    }

    protected void OnBeforeDrawPlotArea(object sender, NationalInstruments.UI.BeforeDrawEventArgs e)
    {
        if (listExtensibleStyles.SelectedValue.Equals("HighlightPlotArea"))
        {
            int segmentWidth = e.Bounds.Width / 4;
            Rectangle amBounds = new Rectangle(e.Bounds.X, e.Bounds.Y, segmentWidth, e.Bounds.Height);
            Rectangle pmBounds = new Rectangle(e.Bounds.X + (segmentWidth * 3), e.Bounds.Y, segmentWidth, e.Bounds.Height);

            e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
            e.Graphics.FillRectangle(Brushes.Navy, amBounds);
            e.Graphics.FillRectangle(Brushes.Navy, pmBounds);
        }
    }

    private double[] GenerateData()
    {
        double[] data = new double[49];
        Random rnd = new Random();

        for (int i = 0; i < data.Length; ++i)
            data[i] = (rnd.NextDouble() * Math.Sin(i / 3.15));

        return data;
    }

    private void HighlightDataPoint(AfterDrawXYPlotEventArgs e, double x, double y)
    {
        Graphics g = e.Graphics;
        PointF mappedPoint = e.Plot.MapDataPoint(e.Bounds, x, y);
        Rectangle bounds = new Rectangle((int) (mappedPoint.X - 8), (int) (mappedPoint.Y - 8), 16, 16);

        using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Red)))
        {
            g.FillEllipse(brush, bounds);
        }

        g.DrawEllipse(Pens.Yellow, bounds);
    }
}
