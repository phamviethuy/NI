using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System.Globalization;

namespace NationalInstruments.Examples.Snippets
{
    sealed class SnipsComplexGraph : SnipsGraph
    {
        private ComplexGraph cxGraph;
        const double RealPos = 2d;
        const double ImgPos = 2d;

        public SnipsComplexGraph(ComplexGraph complexGraph)
            : base(complexGraph)
        {
            cxGraph = complexGraph;
            ResetToDefaultState();
            cxGraph.PlotsChanged += new System.ComponentModel.CollectionChangeEventHandler(cxGraph_PlotsChanged);
            cxGraph.AfterDrawPlotArea += new AfterDrawEventHandler(cxGraph_AfterDrawPlotArea);
        }

        #region Code Snippets for NationalInstruments.UI.WindowsForms.ComplexGraph

        /// <summary>
        /// Returns a ComplexGraphHitTestInfo that specifies where on the control the given
        /// point is located.  It is implemented in the ComplexGraph class. To run this method,
        /// you must first click the run snippet button, and then click somewhere inside 
        /// the graph area. 
        /// </summary>
        /// <signature>HitTest(int, int)</signature>
        /// <OtherMethods>
        /// ComplexGraph.GetAnnotationAt(int, int)
        /// ComplexGraph.GetCursorAt(int, int)
        /// ComplexGraph.GetErrorBandAt(int, int, out double, out double, out double)
        /// ComplexGraph.GetPlotAt(int, int, out double, out double, out double)
        /// ComplexGraph.GetXAxisAt(int, int)
        /// ComplexGraph.GetYAxisAt(int, int)
        /// </OtherMethods>
        /// <ExampleMethod />
        [EventBased("MouseDown")]
        public void ComplexGraph_HitTest_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates using the HitTest method to determine
            // where a user clicked on a ComplexGraph object.
            ComplexPlot plot;
            int index;
            ComplexDouble plotData;
            ComplexGraphHitTestInfo hitTestRegion;
            Color randomColor = Color.FromArgb(RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            hitTestRegion = cxGraph.HitTest(e.X, e.Y);
            switch (hitTestRegion)
            {
                case ComplexGraphHitTestInfo.Annotation:
                    ComplexPointAnnotation annot = cxGraph.GetAnnotationAt (e.X, e.Y) as ComplexPointAnnotation;
                    annot.ShapeFillColor = randomColor;
                    Debug.WriteLine("Annotation selected");
                    Debug.WriteLine(string.Format("Annotation real position: {0}, annotation imaginary position {1}",
                                                annot.Position.Real.ToString(), annot.Position.Imaginary.ToString()));
                    break;
                case ComplexGraphHitTestInfo.Cursor:
                    ComplexCursor cursor = cxGraph.GetCursorAt(e.X, e.Y);
                    cursor.Color = randomColor;
                    Debug.WriteLine("Cursor selected");
                    Debug.WriteLine(string.Format("Cursor real position: {0}, cursor imaginary position: {1}",
                                                cursor.Position.Real.ToString(), cursor.Position.Imaginary.ToString()));
                    break;
                case ComplexGraphHitTestInfo.ErrorBand:
                    ComplexDouble errData;
                    string realErrString, imgErrString;

                    plot = cxGraph.GetErrorBandAt(e.X, e.Y, out errData, out index);
                    plot.LineColor = randomColor;
                    plotData = plot.GetDataPoint(index);

                    if (errData.Real > plotData.Real)
                        realErrString = "upper bound is " + errData.Real.ToString(CultureInfo.CurrentCulture);
                    else if (errData.Real < plotData.Real)
                        realErrString = "lower bound is " + errData.Real.ToString(CultureInfo.CurrentCulture);
                    else
                        realErrString = "is not set";

                    if (errData.Imaginary > plotData.Imaginary)
                        imgErrString = "upper bound is " + errData.Imaginary.ToString(CultureInfo.CurrentCulture) + "i";
                    else if (errData.Imaginary < plotData.Imaginary)
                        imgErrString = "lower bound is " + errData.Imaginary.ToString(CultureInfo.CurrentCulture) + "i";
                    else
                        imgErrString= "is not set";

                    Debug.WriteLine(string.Format("The real error data {0}{1}The imaginary error data {2}",
                                                    realErrString, Environment.NewLine, imgErrString));
                    break;
                case ComplexGraphHitTestInfo.Plot:
                    plot = cxGraph.GetPlotAt(e.X, e.Y, out plotData, out index);
                    plot.LineColor = randomColor;
                    Debug.WriteLine(string.Format("Data point {0} is located at {1} + {2}i", index, plotData.Real, plotData.Imaginary));
                    break;
                case ComplexGraphHitTestInfo.PlotArea:
                    Debug.WriteLine("Plot area was clicked");
                    break;
                case ComplexGraphHitTestInfo.XAxis:
                    ComplexXAxis xAxis = cxGraph.GetXAxisAt(e.X, e.Y);
                    xAxis.CaptionBackColor = randomColor;
                    Debug.WriteLine("Real axis Selected");
                    Debug.WriteLine(string.Format("Real Axis range minimum: {0}, real axis range maximum: {1}",
                                                xAxis.Range.Minimum.ToString(), xAxis.Range.Maximum.ToString()));
                    break;
                case ComplexGraphHitTestInfo.YAxis:
                    ComplexYAxis yAxis = cxGraph.GetYAxisAt(e.X, e.Y);
                    yAxis.CaptionBackColor = randomColor;
                    Debug.WriteLine("Imaginary Selected");
                    Debug.WriteLine(string.Format("Imaginary axis range minimum: {0}, Imaginary axis range maximum: {1}",
                                                yAxis.Range.Minimum.ToString(), yAxis.Range.Maximum.ToString()));
                    break;
                case ComplexGraphHitTestInfo.None:
                    Debug.WriteLine("Unknown graph area clicked");
                    break;
            }
        }

        /// <summary>
        /// To run this method, you must first click the run snippet button, and then
        /// click on an annotation in the plot area.  This method gets the annotation 
        /// at the specified location. It is implemented in the ComplexGraph class. 
        /// </summary>
        /// <signature>GetAnnotationAt(int, int)</signature>
        /// <ExampleMethod />
        [EventBased("PlotAreaMouseDown")]
        public void ComplexGraph_GetAnnotationAt_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates determining which annotation a user
            // clicked on by calling the GetAnnotationAt method of the ComplexGraph class
            // in response to the PlotAreaMouseDown event.
            Color randomColor = Color.FromArgb( RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            ComplexPointAnnotation annot = (ComplexPointAnnotation)cxGraph.GetAnnotationAt(e.X, e.Y);

            if (annot != null)
            {
                annot.ShapeFillColor = randomColor;
                annot.ShapeLineColor = randomColor;
                annot.ArrowColor = randomColor;
            }
            else
            {
                Debug.WriteLine("There was no annotation at the selected location");
            }
        }

        /// <summary>
        /// To run this method, you must first click the run snippet button, and then
        /// click on cursor in the plot area.  This method gets the cursor 
        /// at the specified location. It is implemented in the ComplexGraph class. 
        /// </summary>
        /// <signature>GetCursorAt(int, int)</signature>
        /// <ExampleMethod />
        [EventBased("PlotAreaMouseDown")]
        public void ComplexGraph_GetCursorAt_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates determinng which cursor a user
            // clicked on by calling the GetCursorAt method of the ComplexGraph class
            // in response to the PlotAreaMouseDown event.
            Color randomColor = Color.FromArgb( RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            ComplexCursor cursor = (ComplexCursor)cxGraph.GetCursorAt(e.X, e.Y);

            if (cursor != null)
            {
                cursor.Color = randomColor;
                cursor.MoveNext();
            }
            else
            {
                Debug.WriteLine("There was no cursor at the selected location");
            }
        }

        /// <summary>
        /// Draws the origin lines in the plot area of the graph.  For this method
        /// to draw anything, origin lines must be visible on the plot.
        /// </summary>
        /// <signature>DrawOriginLines(ComponentDrawArgs)</signature>
        /// <ExampleMethod />
        [EventBased("AfterDrawPlotArea", "Invalidate")]
        public void ComplexGraph_DrawOriginLines_ComponentDrawArgs(object sender, AfterDrawEventArgs e)
        {
            // The following example demonstrates drawing a ComplexGraph object's origin lines
            // to a .png image in response to the AfterDrawPlotArea event.
            string imageFileName = "ComplexGraphOriginLinesImage.png";
            using (Bitmap bmp = new Bitmap(cxGraph.PlotAreaBounds.Width, cxGraph.PlotAreaBounds.Height))
            {
                Graphics g = Graphics.FromImage(bmp);
                ComponentDrawArgs args = new ComponentDrawArgs(g, new Rectangle(0, 0, bmp.Width, bmp.Height));

                cxGraph.DrawOriginLines(args);
                bmp.Save(imageFileName, ImageFormat.Png);
            }
            Debug.WriteLine(string.Format("file {0} has been saved", imageFileName));
        }

        /// <summary>
        /// Zooms around the specified data point with the specified zoom factor and 
        /// reference plot. It is implemented in the ComplexGraph class. 
        /// </summary>
        /// <signature>ZoomAroundPoint(float, ComplexPlot, ComplexDouble)</signature>
        /// <ExampleMethod />
        [EventBased("PlotAreaMouseDown")]
        public void ZoomAroundPoint_float_ComplexPlot_ComplexDouble(object sender, MouseEventArgs e)
        {
            // The following example demonstrates zooming in by 125% around a point 
            // on a ComplexGraph object.  The point to be zoomed around is determined 
            // by handling the PlotAreaMouseDown event.
            float zoomFactor = 1.25f;
            ComplexDouble dataPoint = new ComplexDouble();
            PointF virtualPoint;
            double rangeMin, rangeMax;

            // only zoom in when the left mouse button is clicked
            if (e.Button == MouseButtons.Left)
            {
                // get the virtual position of the mouse click so that we can 
                // map to data coordinates on the graph.
                virtualPoint = cxGraph.PointToVirtual(e.Location);

                rangeMin = cxGraph.XAxes[0].Range.Minimum;
                rangeMax = cxGraph.XAxes[0].Range.Maximum;
                dataPoint.Real = (rangeMax - rangeMin) * virtualPoint.X + rangeMin;

                rangeMin = cxGraph.YAxes[0].Range.Minimum;
                rangeMax = cxGraph.YAxes[0].Range.Maximum;
                dataPoint.Imaginary = (rangeMax - rangeMin) * virtualPoint.Y + rangeMin;

                cxGraph.ZoomAroundPoint(zoomFactor, cxGraph.Plots[0], dataPoint);
            }
        }

        /// <summary>
        /// Plots the imaginary part against the real part of a ComplexDouble data value.  
        /// It is implemented in the ComplexGraph class.
        /// </summary>
        /// <signature>PlotComplex(ComplexDouble)</signature>
        /// <ExampleMethod />
        public void PlotComplex_ComplexDouble()
        {
            // The following example demonstrates plotting a single ComplexDouble
            // data point on a ComplexGraph.
            ComplexDouble data = new ComplexDouble();

            data.Real = RandNumberGenerator.NextDouble() * 3;
            data.Imaginary = RandNumberGenerator.NextDouble() * 3;
            cxGraph.PlotComplex(data);
        }

        /// <summary>
        /// Plots the imaginary parts against the real parts of an array of 
        /// ComplexDouble data values. It is implemented in the ComplexGraph class.
        /// </summary>
        /// <signature>PlotComplex(ComplexDouble[])</signature>
        /// <ExampleMethod />
        public void PlotComplex_ComplexDoubleArray()
        {
            // The following example demonstrates plotting an array of ComplexDouble
            // data points on a ComplexGraph.
            ComplexDouble[] data;

            // get some complex data
            data = GenerateComplexData();
            cxGraph.PlotComplex(data);
        }

        /// <summary>
        /// Plots the imaginary parts against the real parts of a subset of an array of 
        /// ComplexDouble data values.  It is implemented in the ComplexGraph class.
        /// </summary>
        /// <signature>PlotComplex(ComplexDouble[], int, int)</signature>
        /// <ExampleMethod />
        public void PlotComplex_ComplexDoubleArray_int_int()
        {
            // The following example demonstrates plotting an array of ComplexDouble
            // data points by specifying the starting array index and the number of 
            // elements to plot.
            ComplexDouble[] data;
            int start = 3;
            int len = 50;

            // get some DigitalWaveform data
            data = GenerateComplexData();
            // plot 10 ComplexDouble values starting at the third index
            cxGraph.PlotComplex(data, start, len);
        }

        /// <summary>
        /// Plots the imaginary part against the real part of a ComplexDouble 
        /// data value by appending to the existing data.  It is implemented 
        /// in the ComplexGraph class.
        /// </summary>
        /// <signature>PlotComplexAppend(ComplexDouble)</signature>
        /// <ExampleMethod />
        public void PlotComplexAppend_ComplexDouble()
        {
            // The following example demonstrates appending a ComplexDouble data
            // point to an existing ComplexGraph plot.
            ComplexDouble data = new ComplexDouble();

            data.Real = RandNumberGenerator.NextDouble() * 3;
            data.Imaginary = RandNumberGenerator.NextDouble() * 3;
            cxGraph.PlotComplexAppend(data);
        }

        /// <summary>
        /// Plots the imaginary parts against the real parts of an array of 
        /// ComplexDouble data values by appending to the existing data.  It 
        /// is implemented in the ComplexGraph class.
        /// </summary>
        /// <signature>PlotComplexAppend(ComplexDouble[])</signature>
        /// <ExampleMethod />
        public void PlotComplexAppend_ComplexDoubleArray()
        {
            // The following example demonstrates appending an array of ComplexDouble
            // data points to an existing ComplexGraph plot.
            ComplexDouble[] data;

            // get some DigitalWaveform data
            data = GenerateComplexData();
            cxGraph.PlotComplexAppend(data);
        }

        /// <summary>
        /// Plots the imaginary parts against the real parts of a subset of an 
        /// array of ComplexDouble data values by appending to existing data.  
        /// It is implemented in the ComplexGraph class.
        /// </summary>
        /// <signature>PlotComplexAppend(ComplexDouble[], int, int)</signature>
        /// <ExampleMethod />
        public void PlotComplexAppend_ComplexDoubleArray_int_int()
        {
            // The following example demonstrates appending an array of ComplexDouble
            // data points to an existing ComplexGraph plot by specifying the starting 
            // array index and the number of elements to plot.
            ComplexDouble[] data;
            int start = 3;
            int len = 50;

            // get some DigitalWaveform data
            data = GenerateComplexData();
            // plot 10 ComplexDouble values starting at the third index
            cxGraph.PlotComplexAppend(data, start, len);
        }
        
        /// <summary>
        /// Zooms to the region of the plot area specified by the data value, region 
        /// width, region height, and reference plot.  It is implemented in the 
        /// ComplexGraph class. 
        /// </summary>
        /// <signature>ZoomXY(ComplexPlot, ComplexDouble, double, double)</signature>
        /// <ExampleMethod />
        public void ZoomXY_ComplexPlot_ComplexDouble_double_double()
        {
            // The following example demonstrates zooming to a specifically sized
            // rectangle on a ComplexGraph plot.
            double width = 3;
            double height = 2;
            ComplexDouble corner = new ComplexDouble(-2d, -3d);

            cxGraph.ZoomXY(cxGraph.Plots[0], corner, width, height);
        }        
        #endregion

        #region helper methosd for the SnipsComplexGraph class

        private void cxGraph_AfterDrawPlotArea(object sender, AfterDrawEventArgs e)
        {
            ComplexGraph graph = sender as ComplexGraph;
            if (graph != null)
            {
                List<SnipsLegendItem> legendItems = new List<SnipsLegendItem>(graph.Plots.Count);
                foreach (ComplexPlot plot in graph.Plots)
                {
                    SnipsLegendItem item = new SnipsLegendItem(plot, plot.ToString(), plot.GetComplexData().Length > 0);
                    legendItems.Add(item);
                }
                MainForm.Legend.SetItems(legendItems);
            }
        }

        private void cxGraph_PlotsChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e)
        {
            ComplexGraph graph = sender as ComplexGraph;
            if (graph != null)
            {
                foreach (ComplexPlot plot in graph.Plots)
                {
                    plot.PointStyle = PointStyle.EmptyDiamond;
                    plot.PointColor = Color.GhostWhite;
                }
            }
        }

        /// <summary>
        /// Reset the graph to it's default state.  This is done by
        /// clearing the data, and then re-plotting the sample data.
        /// </summary>
        public override void ResetToDefaultState()
        {
            base.ResetToDefaultState();

            cxGraph.Annotations.Clear();
            cxGraph.Cursors.Clear();
            CreateSampleAnnotation();
            CreateSampleCursor();

            PlotComplex_ComplexDoubleArray();
        }

        /// <summary>
        /// internal helper function to create an annotation on the XY graph
        /// </summary>
        private void CreateSampleAnnotation()
        {
            //create an annotation
            ComplexPointAnnotation graphAnnotation = new ComplexPointAnnotation();
            ComplexDouble position = new ComplexDouble(RealPos, ImgPos);

            graphAnnotation.Caption = "Sample Annotation";
            graphAnnotation.Visible = true;
            graphAnnotation.ShapeFillColor = Color.Aqua;
            graphAnnotation.XAxis = cxGraph.XAxes[0];
            graphAnnotation.YAxis = cxGraph.YAxes[0];
            // Create an annotation in the middle of the graph
            graphAnnotation.SetPosition(position);
            cxGraph.Annotations.Add(graphAnnotation);
        }

        private void CreateSampleCursor()
        {
            ComplexCursor cursor = new ComplexCursor(cxGraph.Plots[0]);

            cursor.VerticalCrosshairMode = CursorCrosshairMode.FullLength;
            cursor.HorizontalCrosshairMode = CursorCrosshairMode.FullLength;
            cursor.SnapMode = CursorSnapMode.ToPlot;
            cursor.MoveNext();
            cursor.Color = Color.Maroon;
            cxGraph.Cursors.Add(cursor);
        }

        private ComplexDouble[] GenerateComplexData()
        {
            ComplexDouble[] data = new ComplexDouble[100];
            double imgAmp = RandNumberGenerator.NextDouble() * 10;
            double realAmp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < data.Length; i++)
            {
                data[i].Imaginary = imgAmp * Math.Sin(2 * i * Math.PI / (data.Length - 1));
                data[i].Real = realAmp * Math.Sin(4 * i * Math.PI / (data.Length - 1));
            }
            return data;
        }

        #endregion
    }
}
