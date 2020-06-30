using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Snippets
{
    sealed class SnipsIntensityGraph : SnipsGraph
    {
        private IntensityGraph intensityGraph;
        const double Amplitude = 5;

        public SnipsIntensityGraph(IntensityGraph iGraph)
            : base(iGraph)
        {
            intensityGraph = iGraph;
            intensityGraph.AfterDrawPlotArea += new AfterDrawEventHandler(intensityGraph_AfterDrawPlotArea);
            ResetToDefaultState();
        }

        #region code snippets for NationalInstruments.UI.WindowsForms.IntensityGraph

        /// <summary>
        /// Plots a 2D rectangluar array of values against the specified start and increment 
        /// values, with an option to transpose the input array before plotting.  It is 
        /// implemented in the IntensityGraph class. 
        /// </summary>
        /// <signature>Plot(double[,], double, double, double, double, bool)</signature>
        /// <ExampleMethod />
        public void Plot_double2DArray_double_double_double_double_bool()
        {
            // The following example demonstrates plotting a 2-D rectangular array
            // at an offset of 0 and and increment of 1 to an IntensityGraph object.
            double[,] zData;

            zData = GetIntensityData();
            // plot data starting at index 0 of both x and y data
            // sets.  Do not transpose the data being plotted.
            intensityGraph.Plot(zData, 0, 1, 0, 1, false);
        }

        /// <summary>
        /// Plots a 2D rectangluar array of values by appending the array to the existing 
        /// data in the vertical direction, with an option to transpose the input array 
        /// before plotting.  It is implemented in the IntensityGraph class. 
        /// </summary>
        /// <signature>PlotYAppend(double[,], bool)</signature>
        /// <ExampleMethod />
        public void PlotYAppend_double2DArray_bool()
        {
            // The following example demonstrates appending a 2-D array of data to
            // and existing IntensityGraph plot.
            double[,] zData;

            zData = GetIntensityData();

            // ensure we can append the data in the vertical direction
            if (intensityGraph.Plots[0].HistoryCountX != zData.GetLength(1))
                intensityGraph.ClearData();
            
            // Append data vertically, but do not transpose the data
            intensityGraph.PlotYAppend(zData, false);
        }

        /// <summary>
        /// Plots a 2D rectangluar array of values by appending the array to the existing 
        /// data in the horizontal direction, with an option to transpose the input array 
        /// before plotting.  It is implemented in the IntensityGraph class. 
        /// </summary>
        /// <signature>PlotXAppend(double[,], bool)</signature>
        /// <ExampleMethod />
        public void PlotXAppend_double2DArray_bool()
        {
            // The following example demonstrates appending a 2-D array of data to
            // and existing IntensityGraph plot.
            double[,] zData;

            zData = GetIntensityData();

            // ensure we can append the data in the horizontal direction
            if (intensityGraph.Plots[0].HistoryCountY != zData.GetLength(0))
                intensityGraph.ClearData();

            // Append data horizontally, but do not transpose the data
            intensityGraph.PlotXAppend(zData, false);
        }

        /// <summary>
        /// To run this method, you must first click the run snippet button, and then
        /// click somewhere within in the plot area.  This method zooms around the 
        /// specified data point with the specified zoom factor and reference plot.  
        /// It is implemented in the IntensityGraph class. 
        /// </summary>
        /// <signature>ZoomAroundPoint(float, IntensityPlot, double, double)</signature>
        /// <OtherMethods>PointToVirtual</OtherMethods>
        /// <ExampleMethod />
        [EventBased("PlotAreaMouseDown")]
        public void ZoomAroundPoint_float_IntensityPlot_double_double(object sender, MouseEventArgs e)
        {
            // The following example demonstrates zooming around a point on an IntensityGraph
            // graph obtained from handling the PlotAreaMouseDown event.
            PointF virtualPoint;
            double xPos, yPos;
            double rangeMin, rangeMax;
            float zoomFactor = 1.25f;

            // only zoom in when the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // get the virtual position of the mouse click so that we can 
                // map to data coordinates on the graph.
                virtualPoint = intensityGraph.PointToVirtual(e.Location);

                rangeMin = intensityGraph.XAxes[0].Range.Minimum;
                rangeMax = intensityGraph.XAxes[0].Range.Maximum;
                xPos = (rangeMax - rangeMin) * virtualPoint.X + rangeMin;

                rangeMin = intensityGraph.YAxes[0].Range.Minimum;
                rangeMax = intensityGraph.YAxes[0].Range.Maximum;
                yPos = (rangeMax - rangeMin) * virtualPoint.Y + rangeMin;

                intensityGraph.ZoomAroundPoint(zoomFactor, intensityGraph.Plots[0], xPos, yPos);
            }
        }

        /// <summary>
        /// Zooms to the region of the plot area specified by the x location, y 
        /// location, region width, region height, and reference plot.  It is 
        /// implemented in the IntensityGraph class. 
        /// </summary>
        /// <signature>ZoomXY(IntensityPlot, double, double, double, double)</signature>
        /// <ExampleMethod />
        public void ZoomXY_IntensityPlot_double_double_double_double()
        {
            // The following example demonstrates zooming to a region defined by 
            // a rectangle.
            double leftXPoint = 10d;
            double bottomYPoint = 20d;
            double height = 15d;
            double width = 25d;

            intensityGraph.ZoomXY(intensityGraph.Plots[0], leftXPoint, bottomYPoint, width, height);
        }

        /// <summary>
        /// Returns a IntensityGraphHitTestInfo that specifies where on the control the
        /// specified point is located.  It is implemented in the IntensityGraph class. 
        /// </summary>
        /// <signature>HitTest(int, int)</signature>
        /// <OtherMethods>
        /// IntensityGraph.GetPlotAt(int, int, out double, out double, out double, out int, out int)
        /// IntensityGraph.GetXAxisAt(int, int)
        /// IntensityGraph.GetYAxisAt(int, int)
        /// IntensityGraph.GetColorScaleAt(int, int)
        /// </OtherMethods>
        /// <ExampleMethod />
        [EventBased("MouseDown")]
        public void IntensityGraph_HitTest_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates using the HitTest method to determine
            // where a user clicked on a IntensityGraph object.
            IntensityGraphHitTestInfo hitTestRegion;
            IntensityPlot plot;
            ColorScale scale;
            int index;
            Color randomColor = Color.FromArgb(RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            hitTestRegion = intensityGraph.HitTest(e.X, e.Y);
            switch (hitTestRegion)
            {
                case IntensityGraphHitTestInfo.ColorScale:
                    index = 0;
                    scale = intensityGraph.GetColorScaleAt(e.X, e.Y);
                    scale.CaptionBackColor = randomColor;
                    foreach (ColorMapEntry entry in scale.ColorMap)
                    {
                        Debug.WriteLine(string.Format("Color map entry {0} has value {1} and color {2}",
                            index++, entry.Value, entry.Color.Name));
                    }
                    break;
                case IntensityGraphHitTestInfo.Plot:
                    plot = intensityGraph.GetPlotAt(e.X, e.Y);
                    Debug.WriteLine(string.Format("tooltips enabled: {0}", plot.ToolTipsEnabled));
                    Debug.WriteLine(string.Format("interpolation enabled: {0}", plot.PixelInterpolation));
                    Debug.WriteLine(string.Format("{0} x values", plot.HistoryCountX));
                    Debug.WriteLine(string.Format("{0} y values", plot.HistoryCountY));
                    break;
                case IntensityGraphHitTestInfo.PlotArea:
                    Debug.WriteLine("Plot area was clicked");
                    break;
                case IntensityGraphHitTestInfo.XAxis:
                    IntensityXAxis xAxis = intensityGraph.GetXAxisAt(e.X, e.Y);
                    xAxis.CaptionBackColor = randomColor;
                    Debug.WriteLine("X-Axis was clicked");
                    Debug.WriteLine(string.Format("X-Axis range minimum: {0}, X-Axis range maximum: {1}",
                        xAxis.Range.Minimum, xAxis.Range.Maximum));
                    break;
                case IntensityGraphHitTestInfo.YAxis:
                    IntensityYAxis yAxis = intensityGraph.GetYAxisAt(e.X, e.Y);
                    yAxis.CaptionBackColor = randomColor;
                    Debug.WriteLine("Y-Axis was clicked");
                    Debug.WriteLine(string.Format("Y-Axis range minimum: {0}, Y-Axis range maximum: {1}",
                        yAxis.Range.Minimum, yAxis.Range.Maximum));
                    break;
                case IntensityGraphHitTestInfo.None:
                    Debug.WriteLine("Unknown graph area was clicked");
                    break;
            }
        }

        /// <summary>
        /// Draws the origin lines in the plot area of the graph.  For this method
        /// to draw anything, origin lines must be visible on the plot.
        /// </summary>
        /// <signature>DrawOriginLines(ComponentDrawArgs)</signature>
        /// <ExampleMethod />
        [EventBased("AfterDrawPlotArea", "Invalidate")]
        public void IntensityGraph_DrawOriginLines_ComponentDrawArgs(object sender, AfterDrawEventArgs e)
        {
            // The following example demonstrates drawing a IntensityGrapyh object's origin lines
            // to a .png image in response to the AfterDrawPlotArea event.
            string imageFileName = "IntensityGraphOriginLinesImage.png";
            using (Bitmap bmp = new Bitmap(intensityGraph.PlotAreaBounds.Width, intensityGraph.PlotAreaBounds.Height))
            {
                Graphics g = Graphics.FromImage(bmp);
                ComponentDrawArgs args = new ComponentDrawArgs(g, new Rectangle(0, 0, bmp.Width, bmp.Height));

                intensityGraph.DrawOriginLines(args);
                bmp.Save(imageFileName, ImageFormat.Png);
            }
            Debug.WriteLine(string.Format("file {0} has been saved", imageFileName));
        }

        #endregion

        #region helper methods for the SnipsIntensityGraph class

        private void intensityGraph_AfterDrawPlotArea(object sender, AfterDrawEventArgs e)
        {
            IntensityGraph graph = sender as IntensityGraph;
            if (graph != null)
            {
                List<SnipsLegendItem> legendItems = new List<SnipsLegendItem>(graph.Plots.Count);
                foreach (IntensityPlot plot in graph.Plots)
                {
                    SnipsLegendItem item = new SnipsLegendItem(plot, plot.ToString(), plot.GetZData().Length > 0);
                    legendItems.Add(item);
                }
                MainForm.Legend.SetItems(legendItems);
            }
        }

        public override void ResetToDefaultState()
        {
            double inc, divisions = 6;

            base.ResetToDefaultState();

            intensityGraph.ColorScales[0].ColorMap.Clear();
            inc = Amplitude / divisions * 2;
            ColorMapEntry[] entries = { new ColorMapEntry(0d, Color.Green), 
                                        new ColorMapEntry(inc, Color.YellowGreen),
                                        new ColorMapEntry(inc * 2, Color.Yellow),
                                        new ColorMapEntry(inc * 3, Color.Gold),
                                        new ColorMapEntry(inc * 4, Color.Orange),
                                        new ColorMapEntry(inc * 5, Color.OrangeRed),
                                        new ColorMapEntry(inc * 6, Color.Red)};
            intensityGraph.ColorScales[0].ColorMap.AddRange(entries);
            intensityGraph.ColorScales[0].HighColor = Color.Red;
            intensityGraph.ColorScales[0].LowColor = Color.Green;

            Plot_double2DArray_double_double_double_double_bool();
        }

        private double[,] GetIntensityData()
        {
            double[,] data = new double[51, 51];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    double randomizer = RandNumberGenerator.NextDouble() / 5d;
                    data[i, j] = Math.Sin(((double)j + i) / (2.5 * Math.PI) + randomizer) * Amplitude + Amplitude;
                }
            }
            return data;
        }

        #endregion
    }
}
