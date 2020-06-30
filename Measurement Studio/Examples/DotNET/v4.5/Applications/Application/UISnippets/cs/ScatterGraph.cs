using System;
using System.Collections.Generic;
using System.Drawing;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;


namespace NationalInstruments.Examples.Snippets
{
    sealed class SnipsScatterGraph : SnipsXYGraph
    {
        private ScatterGraph scatGraph;
        const int Len = 50;
        
        /// <summary>
        /// Creates a new scattergraph object for use in this 
        /// code snippets example
        /// </summary>
        /// <param name="scatterGraph">The ScatterGraph to be used internally</param>
        public SnipsScatterGraph(ScatterGraph scatterGraph)
            : base(scatterGraph, scatterGraph.Plots[0])
        {
            scatGraph = scatterGraph;
            ResetToDefaultState();
            scatGraph.PlotsChanged += new System.ComponentModel.CollectionChangeEventHandler(scatGraph_PlotsChanged);
            scatGraph.AfterDrawPlotArea += new AfterDrawEventHandler(scatGraph_AfterDrawPlotArea);
        }

        #region Code Snippets for NationalInsruments.UI.WindowsForms.ScatterGraph

        /// <summary>
        /// Plots a single y value against a single x value. 
        /// It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotXY(double, double)</signature>
        /// <ExampleMethod />
        public void PlotXY_double_double()
        {
            // The following example demonstrates plotting a single point
            // on a ScatterGraph object.
            double xVal = RandNumberGenerator.NextDouble() * 10;
            double yVal = RandNumberGenerator.NextDouble() * 10;

            scatGraph.PlotXY(xVal, yVal);
        }

        /// <summary>
        /// Plots a subset of an array of y values against an array of x values.
        /// It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotXY(double[], double[], int, int)</signature>
        /// <ExampleMethod />
        public void PlotXY_doubleArray_doubleArray_int_int()
        {
            // The following example demonstrates plotting multiple data points
            // on a ScatterGraph object.
            double[] xData, yData;            
            
            // get some random data
            GetXYCircleData(out xData, out yData);
            // plot all x values against all y values starting at 
            // the first item of each array
            scatGraph.PlotXY(xData, yData, 0, xData.Length);
        }

        /// <summary>
        /// Plots a single y value against a single x value by appending the x and y
        /// value to the existing data. It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotXYAppend(double, double)</signature>
        /// <ExampleMethod />
        public void PlotXYAppend_double_double()
        {
            // The following example demonstrates appending a single point to
            // an existing ScatterGraph plot.
            double xVal = RandNumberGenerator.NextDouble() * 10;
            double yVal = RandNumberGenerator.NextDouble() * 10;

            scatGraph.PlotXYAppend(xVal, yVal);
        }

        /// <summary>
        /// Plots a subset of an array of y values against an array of x values by appending
        /// the x and y values to the existing data.  It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotXYAppend(double[], double[], int, int)</signature>
        /// <ExampleMethod />
        public void PlotXYAppend_doubleArray_doubleArray_int_int()
        {
            // The following example demonstrates appending a subset of an array of data 
            // to an existing ScatterGraph plot beginning at the fifth index in the data
            // arrays and continuing for 10 data points.
            double[] xData, yData;            
            int start = 5;
            int len = 10;

            // get some random data
            GetXYCircleData(out xData, out yData);
            // plot 10 x values against 10 y values starting at 
            // the fifth index of each array
            scatGraph.PlotXYAppend(xData, yData, start, len);
        }

        /// <summary>
        /// Plots a 2D array of y values with the specified orientation against an 
        /// array of x values.  It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotXYMultiple(double[], double[,], DataOrientation)</signature>
        /// <ExampleMethod />
        public void PlotXYMultiple_doubleArray_double2DArray_DataOrientation()
        {
            // The following example demonstrates plotting multiple datasets arranged in rows
            // of data to multiple ScatterGraph plots.
            double[] xData;
            double[,] yDataMatrix;

            // get some random data
            GetXYCircleData(out xData, out yDataMatrix, 3);
            scatGraph.PlotXYMultiple(xData, yDataMatrix, DataOrientation.DataInRows);
        }

        /// <summary>
        /// Plots a 2D array of y values with the specified orientation against an 
        /// array of x values by appending the x and y values to the existing data.
        /// It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotXYAppendMultiple(double[], double[,], DataOrientation)</signature>
        /// <ExampleMethod />
        public void PlotXYAppendMultiple_doubleArray_double2DArray_DataOrientation()
        {
            // The following example demonstrates appending multiple datasets arranged in rows
            // of data to multiple ScatterGraph plots.
            double[] xData;
            double[,] yDataMatrix;

            // get some random data
            GetXYCircleData(out xData, out yDataMatrix, 3);
            scatGraph.PlotXYAppendMultiple(xData, yDataMatrix, DataOrientation.DataInRows);
        }

        /// <summary>
        /// Plots a 2D array of x values with the specified orientation against an array 
        /// of y values.  It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotYXMultiple(double[], double[,], DataOrientation)</signature>
        /// <ExampleMethod />
        public void PlotYXMultiple_doubleArray_double2DArray_DataOrientation()
        {
            // The following example demonstrates plotting multiple datasets arranged in rows
            // of data to multiple ScatterGraph plots.
            double[,] xDataMatrix;
            double[] yData;

            // get some random data
            GetYXCircleData(out yData, out xDataMatrix, 3);
            scatGraph.PlotYXMultiple(yData, xDataMatrix, DataOrientation.DataInRows);
        }

        /// <summary>
        /// Plots a 2D array of x values with the specified orientation against an 
        /// array of y values by appending the x and y values to the existing data. 
        /// It is implemented in the ScatterGraph class. 
        /// </summary>
        /// <signature>PlotYXAppendMultiple(double[], double[,], DataOrientation)</signature>
        /// <ExampleMethod />
        public void PlotYXAppendMultiple_doubleArray_double2DArray_DataOrientation()
        {
            // The following example demonstrates appending multiple datasets arranged in rows
            // of data to multiple ScatterGraph plots.
            double[,] xDataMatrix;
            double[] yData;

            // get some random data
            GetYXCircleData(out yData, out xDataMatrix, 3);
            scatGraph.PlotYXAppendMultiple(yData, xDataMatrix, DataOrientation.DataInRows);
        }

        #endregion

        #region helper methods for the SnipsScatterGraph class

        void scatGraph_AfterDrawPlotArea(object sender, AfterDrawEventArgs e)
        {
            ScatterGraph graph = sender as ScatterGraph;
            if (graph != null)
            {                
                List<SnipsLegendItem> legendItems = new List<SnipsLegendItem>(graph.Plots.Count);
                foreach (ScatterPlot plot in graph.Plots)
                {
                    SnipsLegendItem item = new SnipsLegendItem(plot, plot.ToString(), plot.GetYData().Length > 0);
                    legendItems.Add(item);
                }
                MainForm.Legend.SetItems(legendItems);
            }
        }

        void scatGraph_PlotsChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e)
        {
            ScatterGraph graph = sender as ScatterGraph;
            if (graph != null)
            {
                foreach (ScatterPlot plot in graph.Plots)
                {
                    plot.PointStyle = PointStyle.EmptyCircle;
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
            PlotXY_doubleArray_doubleArray_int_int();
        }

        private void GetXYCircleData(out double[] xData, out double[] yData)
        {
            const int divisor = Len - 1;
            double[] xVals = new double[Len];
            double[] yVals = new double[Len];
            double radius = RandNumberGenerator.NextDouble() * 10 + 6;

            for (int i = 0; i < Len; i++)
            {
                double current = ((double)i / divisor) * Math.PI * 2;
                xVals[i] = Math.Cos(current) * radius;
                yVals[i] = Math.Sin(current) * radius;
            }

            xData = xVals;
            yData = yVals;
        }

        private void GetXYCircleData(out double[] xData, out double[,] yData, int numPlots)
        {
            double[] xVals = new double[Len];
            double[,] yVals = new double[numPlots, Len];
            double divisor = Len - 1;
            double radius = RandNumberGenerator.NextDouble() * 10 + 6;

            // Generate some xData
            for (int i = 0; i < Len; i++)
            {
                double current = ((double)i / divisor) * Math.PI * 2;
                xVals[i] = Math.Cos(current) * radius;
            }

            // Generate the yData
            for (int row = 0; row < numPlots; row++)
            {
                radius = RandNumberGenerator.NextDouble() * 10;
                for (int col = 0; col < Len; col++)
                {
                    double current = ((double)col / divisor) * Math.PI * 2;
                    yVals[row, col] = Math.Sin(current) * radius;
                }
            }

            xData = xVals;
            yData = yVals;
        }

        private void GetYXCircleData(out double[] yData, out double[,] xData, int numPlots)
        {
            GetXYCircleData(out yData, out xData, numPlots);
        }

        #endregion
    }
}
