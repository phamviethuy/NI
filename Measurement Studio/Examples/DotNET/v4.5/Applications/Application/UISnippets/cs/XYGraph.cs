using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System.Globalization;

namespace NationalInstruments.Examples.Snippets
{
    class SnipsXYGraph : SnipsGraph
    {
        XYGraph xyGraph;
        XYPlot xyPlot;

        const double AnnotationXPos = 6d;
        const double AnnotationYPos = 2d;

        public SnipsXYGraph(XYGraph graphToUse, XYPlot PlotToUse)
            : base(graphToUse)
        {
            xyGraph = graphToUse;
            xyPlot = PlotToUse;
        }

        #region Code snippets for NationalInstruments.UI.WindowsForms.XYGraph

        /// <summary>
        /// To run this method, you must first click the run snippet button, and then
        /// click somewhere within the plot area.  This method zooms around the 
        /// specified data point with the specified zoom factor and reference plot.  
        /// It is implemented in the XYGraph class. 
        /// </summary>
        /// <signature>ZoomAroundPoint(float, XYPlot, double, double)</signature>
        /// <OtherMethods>PointToVirtual</OtherMethods>
        /// <ExampleMethod />
        [EventBased("PlotAreaMouseDown")]
        public void ZoomAroundPoint_float_XYPlot_double_double(object sender, MouseEventArgs e)
        {
            // The following example demonstrates zooming in by 125% around a point 
            // on a XYGraph object.  The point to be zoomed around is determined 
            // by handling the PlotAreaMouseDown event.
            PointF virtualPoint;
            double xPos, yPos;
            double rangeMin, rangeMax;
            float zoomFactor = 1.25f;

            // only zoom in when the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // get the virtual position of the mouse click so that we can 
                // map to data coordinates on the graph.
                virtualPoint = xyGraph.PointToVirtual(e.Location);

                rangeMin = xyGraph.XAxes[0].Range.Minimum;
                rangeMax = xyGraph.XAxes[0].Range.Maximum;
                xPos = (rangeMax - rangeMin) * virtualPoint.X + rangeMin;

                rangeMin = xyGraph.YAxes[0].Range.Minimum;
                rangeMax = xyGraph.YAxes[0].Range.Maximum;
                yPos = (rangeMax - rangeMin) * virtualPoint.Y + rangeMin;

                xyGraph.ZoomAroundPoint(zoomFactor, xyPlot, xPos, yPos);
            }
        }

        /// <summary>
        /// Returns a XYGraphHitTestInfo that specifies where on the control the given
        /// point is located.  It is implemented in the XYGraph class. To run this method,
        /// you must first click the run snippet button, and then click somewhere inside 
        /// the graph area. 
        /// </summary>
        /// <signature>HitTest(int, int)</signature>
        /// <OtherMethods>
        /// XYGraph.GetAnnotationAt(int, int)
        /// XYGraph.GetCursorAt(int, int)
        /// XYGraph.GetErrorBandAt(int, int, out double, out double, out double)
        /// XYGraph.GetPlotAt(int, int, out double, out double, out double)
        /// XYGraph.GetXAxisAt(int, int)
        /// XYGraph.GetYAxisAt(int, int)
        /// </OtherMethods>
        /// <ExampleMethod />
        [EventBased("MouseDown")]
        public void XYGraph_HitTest_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates using the HitTest method to determine
            // where a user clicked on a XYGraph object.
            XYGraphHitTestInfo hitTestRegion;
            XYPlot plot;
            int index;
            Color randomColor = Color.FromArgb(RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            hitTestRegion = xyGraph.HitTest(e.X, e.Y);
            switch (hitTestRegion)
            {
                case XYGraphHitTestInfo.Annotation:
                    XYPointAnnotation annot = xyGraph.GetAnnotationAt(e.X, e.Y) as XYPointAnnotation;
                    annot.ShapeFillColor = randomColor;
                    Debug.WriteLine("Annotation selected");
                    Debug.WriteLine(string.Format("Annotation X position: {0}, Annotation Y position {1}",
                                                annot.XPosition.ToString(), annot.YPosition.ToString()));
                    break;
                case XYGraphHitTestInfo.Cursor:
                    XYCursor cursor = xyGraph.GetCursorAt(e.X, e.Y);
                    cursor.Color = randomColor;
                    Debug.WriteLine("Cursor selected");
                    Debug.WriteLine(string.Format("Cursor X position: {0}, Cursor Y position: {1}",
                                                cursor.XPosition.ToString(), cursor.YPosition.ToString()));
                    break;
                case XYGraphHitTestInfo.ErrorBand:
                    double xVal, yVal, xErrData, yErrData;
                    string xErrString, yErrString;
                    
                    plot = xyGraph.GetErrorBandAt(e.X, e.Y, out xErrData, out yErrData, out index);
                    plot.LineColor = randomColor;
                    xVal = (double)plot.GetXData().GetValue(index);
                    yVal = (double)plot.GetYData().GetValue(index);

                    if (xErrData > xVal)
                        xErrString = "upper bound is " + xErrData.ToString(CultureInfo.CurrentCulture);
                    else if (xErrData < xVal)
                        xErrString = "lower bound is " + xErrData.ToString(CultureInfo.CurrentCulture);
                    else
                        xErrString = "is not set";

                    if (yErrData > yVal)
                        yErrString = "upper bound is " + yErrData.ToString(CultureInfo.CurrentCulture);
                    else if (yErrData < yVal)
                        yErrString = "lower bound is " + yErrData.ToString(CultureInfo.CurrentCulture);
                    else
                        yErrString = "is not set";

                    Debug.WriteLine(string.Format("The x error data {0}{1}The y error data {2}",
                                                    xErrString, Environment.NewLine, yErrString));
                    break;
                case XYGraphHitTestInfo.Plot:
                    double xData, yData;

                    plot = xyGraph.GetPlotAt(e.X, e.Y, out xData, out yData, out index);
                    plot.LineColor = randomColor;
                    Debug.WriteLine(string.Format("Data point {0} is located at ({1}, {2})", index, xData, yData));
                    break;
                case XYGraphHitTestInfo.PlotArea:
                    Debug.WriteLine("Plot area was clicked");
                    break;
                case XYGraphHitTestInfo.XAxis:
                    XAxis xAxis = xyGraph.GetXAxisAt(e.X, e.Y);
                    xAxis.CaptionBackColor = randomColor;
                    Debug.WriteLine("XAxis Selected");
                    Debug.WriteLine(string.Format("X-Axis range minimum: {0}, X-Axis range maximum: {1}",
                        xAxis.Range.Minimum, xAxis.Range.Maximum));
                    break;
                case XYGraphHitTestInfo.YAxis:
                    YAxis yAxis = xyGraph.GetYAxisAt(e.X, e.Y);
                    yAxis.CaptionBackColor = randomColor;
                    Debug.WriteLine("Y-Axis was clicked");
                    Debug.WriteLine(string.Format("Y-Axis range minimum: {0}, Y-Axis range maximum: {1}",
                        yAxis.Range.Minimum, yAxis.Range.Maximum));
                    break;
                case XYGraphHitTestInfo.None:
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
        public void XYGraph_DrawOriginLines_ComponentDrawArgs(object sender, AfterDrawEventArgs e)
        {
            // The following example demonstrates drawing a XYGraph object's origin lines
            // to a .png image in response to the AfterDrawPlotArea event.
            string imageFileName = "XYGraphOriginLinesImage.png";
            using (Bitmap bmp = new Bitmap(xyGraph.PlotAreaBounds.Width, xyGraph.PlotAreaBounds.Height))
            {
                Graphics g = Graphics.FromImage(bmp);
                ComponentDrawArgs args = new ComponentDrawArgs(g, new Rectangle(0, 0, bmp.Width, bmp.Height));

                xyGraph.DrawOriginLines(args);
                bmp.Save(imageFileName, ImageFormat.Png);
            }
            Debug.WriteLine(string.Format("file {0} has been saved", imageFileName));
        }

        /// <summary>
        /// Zooms to the region of the plot area specified by the x location, y 
        /// location, region width, region height, and reference plot.  It is 
        /// implemented in the XYGraph class. 
        /// </summary>
        /// <signature>ZoomXY(XYPlot, double, double, double, double)</signature>
        /// <ExampleMethod />
        public void ZoomXY_XYPlot_double_double_double_double()
        {
            // The following example demonstrates zooming to a specifically sized
            // rectangle on a XYGraph plot.
            double leftXPoint = 2d;
            double bottomYPoint = 3d;
            double height = 2d;
            double width = 3d;
            
            xyGraph.ZoomXY(xyPlot, leftXPoint, bottomYPoint, width, height);
        }
        
        #endregion

        #region helper methods for the SnipsXYGraph class

        public override void ResetToDefaultState()
        {
            base.ResetToDefaultState();

            xyGraph.Annotations.Clear();
            CreateSampleAnnotation();

            xyGraph.Cursors.Clear();
            CreateSampleCursor();
        }

        /// <summary>
        /// helper function to create an annotation on the XY graph
        /// </summary>
        private void CreateSampleAnnotation()
        {
            //create an annotation
            XYPointAnnotation graphAnnotation = new XYPointAnnotation();

            graphAnnotation.Caption = "Sample Annotation";
            graphAnnotation.Visible = true;
            graphAnnotation.ShapeFillColor = Color.Aqua;
            graphAnnotation.XAxis = xyGraph.XAxes[0];
            graphAnnotation.YAxis = xyGraph.YAxes[0];
            // Create an annotation in the middle of the graph
            graphAnnotation.SetPosition(AnnotationXPos, AnnotationYPos);
            xyGraph.Annotations.Add(graphAnnotation);
        }

        /// <summary>
        /// helper function to create a cursor on the XY graph
        /// </summary>
        private void CreateSampleCursor()
        {
            XYCursor cursor = new XYCursor(xyPlot);

            cursor.VerticalCrosshairMode = CursorCrosshairMode.FullLength;
            cursor.HorizontalCrosshairMode = CursorCrosshairMode.FullLength;
            cursor.SnapMode = CursorSnapMode.ToPlot;
            cursor.MoveNext();
            cursor.Color = Color.Maroon;
            xyGraph.Cursors.Add(cursor);
        }

        #endregion
    }
}
