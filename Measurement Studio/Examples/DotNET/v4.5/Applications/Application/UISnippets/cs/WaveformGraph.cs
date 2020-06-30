using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System.Globalization;

namespace NationalInstruments.Examples.Snippets
{
    sealed class SnipsWaveformGraph : SnipsXYGraph
    {
        private WaveformGraph wvfmGraph;
        private FormatString timeFormatString = new FormatString(CultureInfo.CurrentCulture, FormatStringMode.DateTime, "h:mm:ss tt");
        private FormatString samplesFormatString = new FormatString(CultureInfo.CurrentCulture, FormatStringMode.Numeric, "G5");

        /// <summary>
        /// Creates a new waveformGraph object for use in this 
        /// code snippets example
        /// </summary>
        /// <param name="waveformGraph">The Waveform graph to be used internally</param>
        public SnipsWaveformGraph(WaveformGraph waveformGraph)
            : base(waveformGraph, waveformGraph.Plots[0])
        {
            wvfmGraph = waveformGraph;

            wvfmGraph.PlotsChanged += new System.ComponentModel.CollectionChangeEventHandler(wvfmGraph_PlotsChanged);            
            wvfmGraph.AfterDrawPlotArea += new AfterDrawEventHandler(wvfmGraph_AfterDrawPlotArea);
            ResetToDefaultState();
        }

        #region Code Snippets for NationalInstruments.UI.WindowsForms.WaveformGraph

        /// <summary>
        /// Plots a single x value against the default starting y value. 
        /// It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotX(double)</signature>
        /// <ExampleMethod />
        public void PlotX_double()
        {
            // The following example demonstrates plotting a single x value against
            // the default starting y value.
            double xData = RandNumberGenerator.NextDouble();

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // plot random y value
            wvfmGraph.PlotX(xData);
        }

        /// <summary>
        /// Plots a subset of an array of x values against the specified DateTime as the 
        /// starting y value with the specified PlotDateTimePrecisionMode. PlotX uses the 
        /// specified TimeSpan to increment y values. It is implmented in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotX(double[], Int32, Int32, DateTime, TimeSpan, PlotDateTimePrecisionMode)</signature>        
        /// <ExampleMethod />
        public void PlotX_doubleArray_Int32_Int32_TimeSpan_PlotDateTimePrecisionMode()
        {
            // The following example demonstrates plotting a subset of an array of x values 
            // against the starting y DateTime value of DateTime.Now with the specified 
            // PlotDateTimePrecisionMode of Default.

            // Create random x data
            double[] xData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;
            TimeSpan increment = TimeSpan.FromSeconds(1d);
            DateTime stamp = DateTime.Now;

            for (int i = 0; i < xData.Length; i++)
                xData[i] = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display time
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = timeFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot 6 elements from the xData array beginning from the element at index 2.
            // Increment Y values at 1 second per element, with default precision
            wvfmGraph.PlotX(xData, 2, 6, stamp, increment, PlotDateTimePrecisionMode.Default);
        }

        /// <summary>
        /// Plots a subset of an array of x values against the specified starting y 
        /// value using the specified value to increment y values.  It is implemented 
        /// in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotX(double[], int, int, double, double)</signature>
        /// <ExampleMethod />
        public void PlotX_doubleArray_int_int_double_double()
        {
            // The following example demonstrates plotting a subset of an array of x values
            // against a starting y value of 6.5 using a value of 1.5 to increment the y-values.

            // Create random x data
            double[] xData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < xData.Length; i++)
                xData[i] = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot all elements of the xData array, incrementing
            // Y values 1.5 units per xData element, starting at x value 6.5
            wvfmGraph.PlotX(xData, 0, xData.Length, 6.5d, 1.5d);
        }

        /// <summary>
        /// Plots a single x value against a starting y value by appending 
        /// the x and y values to the existing data using the specified value
        /// to increment y values. It is implemented in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotXAppend(double, double)</signature>        
        /// <ExampleMethod />
        public void PlotXAppend_double_double()
        {
            // The following example demonstrates appending a single x value with 
            // a y increment of 1.0.
            double xData = RandNumberGenerator.NextDouble() * 10;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // plot random X Value with a 1.0 increment
            wvfmGraph.PlotXAppend(xData, 1.0);
        }

        /// <summary>
        /// Plots a single x value against a starting y value by appending the x and y 
        /// values to the existing data using the specified TimeSpan to increment y 
        /// values.  It is implemented in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotXAppend(double, TimeSpan)</signature>        
        /// <ExampleMethod />
        public void PlotXAppend_double_TimeSpan()
        {
            // The following example demonstrates plotting a single x value with
            // a y increment of 3.5 seconds.
            double xData = RandNumberGenerator.NextDouble() * 10;
            TimeSpan increment = TimeSpan.FromSeconds(3.5d);

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display time
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = timeFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // plot random X Value with a 1.0 increment
            wvfmGraph.PlotXAppend(xData, increment);
        }

        /// <summary>
        /// plots a subset of an array of x values against a starting y value with the specified 
        /// PlotDateTimePrecisionMode. PlotXAppend appends the x and y values to the existing 
        /// data using the specified TimeSpan to increment y values.  It is implmented in the 
        /// WaveformGraph class.
        /// </summary>
        /// <signature>PlotXAppend(double[], Int32, Int32, TimeSpan, PlotDateTimePrecisionMode)</signature>        
        /// <ExampleMethod />
        public void PlotXAppend_doubleArray_Int32_Int32_TimeSpan_PlotDateTimePrecisionMode()
        {
            // The following example demonstrates appending a subset of an array of x values 
            // with a y increment of 1 second and a specified PlotDateTimePrecisionMode of Default.
 
            // Create random x data
            double[] xData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < xData.Length; i++)
                xData[i] = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display time
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = timeFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot 6 elements from the xData array beginning from the element at index 2.
            // Increment Y values at 1 second per element, with default precision
            wvfmGraph.PlotXAppend(xData, 2, 6, TimeSpan.FromSeconds(1d), PlotDateTimePrecisionMode.Default);
        }

        /// <summary>
        /// Plots a subset of an array of x values against a starting y value by 
        /// appending the x and y values to the existing data using the specified 
        /// value to increment y values. It is implemented in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotXAppend(double[], Int32, Int32, double)</signature>
        /// <ExampleMethod />
        public void PlotXAppend_doubleArray_Int32_Int32_double()
        {
            // The following example demonstrates appending a subset of x values with
            // a y increment of 1.5.

            // Create random x data
            double[] xData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < xData.Length; i++)
                xData[i] = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot all elements of the xData array, incrementing
            // Y values 1.5 units per xData element.
            wvfmGraph.PlotXAppend(xData, 0, xData.Length, 1.5d);
        }

        /// <summary>
        /// Plots a 2D array of x values with the specified data orientation against the
        /// specified starting y value. PlotXMultiple uses the specified value to 
        /// increment y values.   It is implemented in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotXMultiple(double[,], DataOrientation, double, double)</signature>
        /// <ExampleMethod />
        public void PlotXMultiple_double2DArray_DataOrientation_double_double()
        {
            // The following example demonstrates plotting multiple sets of data organized in 
            // rows against a starting y value of 0 and at an increment of 1.5.
            double[,] xData = new double[3, 50];
            double amp;

            // Create random x data
            for (int row = 0; row < xData.GetLength(0); row++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int col = 0; col < xData.GetLength(1); col++)
                {
                    xData[row, col] = amp * Math.Sin(2 * col * Math.PI / xData.GetLength(1)) + amp;
                }
            }

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot all elements of the xData array, incrementing
            // Y values 1.5 units per xData element.  Because there are
            // three rows of data, specify the DataOrientation to be in rows
            wvfmGraph.PlotXMultiple(xData, DataOrientation.DataInRows, 0.0d, 1.5d);
        }

        /// <summary>
        /// Plots a 2D array of x values with the specified data orientation against the 
        /// specified DateTime as the starting y value. PlotXMultiple uses the specified 
        /// TimeSpan to increment y values.    It is implemented in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotXMultiple(double[,], DataOrientation, DateTime, TimeSpan)</signature>
        /// <ExampleMethod />
        public void PlotXMultiple_double2DArray_DataOrientation_DateTime_TimeSpan()
        {
            // The following example demonstrates plotting multiple sets of data organized in 
            // columns against a starting y value of DateTime.Now and at an increment of 2.75 seconds.
            double[,] xData = new double[50, 3];
            double amp;
            TimeSpan increment = TimeSpan.FromSeconds(2.75d);
            DateTime timeStamp = DateTime.Now;

            // Create random x data
            for (int col = 0; col < xData.GetLength(1); col++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int row = 0; row < xData.GetLength(0); row++)
                {
                    xData[row, col] = amp * Math.Sin(2 * row * Math.PI / xData.GetLength(0)) + amp;
                }
            }

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display time
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = timeFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot all elements of the xData array, incrementing
            // Y values by 2.75 seconds with each value.  Because there are three
            // columns of data, specify the DataOrientation to be in columns
            wvfmGraph.PlotXMultiple(xData, DataOrientation.DataInColumns, timeStamp, increment);
        }

        /// <summary>
        /// Plots a 2D array of x values with the specified orientation against a starting y 
        /// value by appending the x and y values to the existing data using the specified 
        /// value to increment y values.  It is implemented in the WaveformGraph class.
        /// </summary>
        /// <signature>PlotXAppendMultiple(double[,], DataOrientation, double)</signature>
        /// <ExampleMethod />
        public void PlotXAppendMultiple_double2DArray_DataOrientation_double()
        {
            // The following example demonstrates appending multiple sets of data organized in 
            // rows at an increment of 1.5.
            double[,] xData = new double[3, 50];
            double amp;

            // Create random x data
            for (int row = 0; row < xData.GetLength(0); row++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int col = 0; col < xData.GetLength(1); col++)
                {
                    xData[row, col] = amp * Math.Sin(2 * col * Math.PI / xData.GetLength(1)) + amp;
                }
            }

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot all elements of the xData array, incrementing
            // Y values 1.5 units per xData element.  Because there are
            // three rows of data, specify the DataOrientation to be in rows
            wvfmGraph.PlotXAppendMultiple(xData, DataOrientation.DataInRows, 1.5d);
        }

        /// <summary>
        /// Plots a 2D array of x values with the specified orientation against a 
        /// starting y value by appending the x and y values to the existing data using 
        /// the specified TimeSpan to increment y values.   It is implemented in the 
        /// WaveformGraph class.
        /// </summary>
        /// <signature>PlotXAppendMultiple(double[,], DataOrientation, TimeSpan)</signature>
        /// <ExampleMethod />
        public void PlotXAppendMultiple_double2DArray_DataOrientation_TimeSpan()
        {
            // The following example demonstrates appending multiple sets of data organized in 
            // columns at an increment of 2.75 seconds.
            double[,] xData = new double[50, 3];
            double amp;
            TimeSpan increment = TimeSpan.FromSeconds(2.75d);

            // Create random x data
            for (int col = 0; col < xData.GetLength(1); col++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int row = 0; row < xData.GetLength(0); row++)
                {
                    xData[row, col] = amp * Math.Sin(2 * row * Math.PI / xData.GetLength(0)) + amp;
                }
            }

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display time
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = timeFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotX)
                wvfmGraph.ClearData();
            // Plot all elements of the xData array, incrementing
            // Y values by 2.75 seconds with each value.  Because there are three
            // columns of data, specify the DataOrientation to be in columns
            wvfmGraph.PlotXAppendMultiple(xData, DataOrientation.DataInColumns, increment);
        }

        /// <summary>
        /// Plots a single y value against the default starting x value. 
        /// It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotY(double)</signature>
        /// <ExampleMethod />
        public void PlotY_double()
        {
            // The following example demonstrates plotting a single y value against the 
            // default starting x value.
            double yData = RandNumberGenerator.NextDouble();

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // plot random y value
            wvfmGraph.PlotY(yData);
        }

        /// <summary>
        /// Plots a single y value against a starting x value by appending the 
        /// x and y values to the existing data using the specified value to
        /// increment x values.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYAppend(double, double)</signature>
        /// <ExampleMethod />
        public void PlotYAppend_double_double()
        {
            // The following example demonstrates appending a single y value with
            // a y increment of 2.0
            double yData = RandNumberGenerator.NextDouble();

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // plot random y value incrementing by 2
            wvfmGraph.PlotYAppend(yData, 2d);
        }

        /// <summary>
        /// Plots a single y value against a starting x value by appending the x 
        /// and y values to the existing data using the specified TimeSpan to 
        /// increment x values.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYAppend(double, TimeSpan)</signature>
        /// <ExampleMethod />
        public void PlotYAppend_double_TimeSpan()
        {
            // The following example demonstrates appending a single y value with
            // a y increment of 2.0 seconds 
            double yData = RandNumberGenerator.NextDouble();
            TimeSpan increment = TimeSpan.FromSeconds(2d);

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // plot random y value incrementing by 2 seconds
            wvfmGraph.PlotYAppend(yData, increment);
        }

        /// <summary>
        /// Plots an array of y values against the default starting x value using the 
        /// default increment value. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotY(double[])</signature>
        /// <ExampleMethod />
        public void PlotY_doubleArray()
        {
            // The following example demonstrates plotting an array of y values
            // against the default starting x value using the default increment value.
            double[] yData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;

            // Create random y data
            for (int i = 0; i < yData.Length; i++)
                yData[i] = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // plot random y values 
            wvfmGraph.PlotY(yData);
        }

        /// <summary>
        /// Plots an array of y values against a starting x value by appending 
        /// the x and y values to the existing data.  It is implemented in the 
        /// WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYAppend(double[])</signature>
        /// <ExampleMethod />
        public void PlotYAppend_doubleArray()
        {
            // The following example demonstrates appending an array of y values
            // against the default starting x value using the default increment value.
            double[] yData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;

            // Create random y data
            for (int i = 0; i < yData.Length; i++)
                yData[i] = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // plot random y values 
            wvfmGraph.PlotYAppend(yData);
        }

        /// <summary>
        /// Plots an array of y values against the specified DateTime as the starting x 
        /// value using the specified TimeSpan to increment x values. It is implemented 
        /// in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotY(double[], int, int, DateTime, TimeSpan)</signature>
        /// <ExampleMethod />
        public void PlotY_doubleArray_int_int_DateTime_TimeSpan()
        {
            // The following example demonstrates plotting a subset of an array of y values
            // against the starting x value of DateTime.Now and incrementing at 1.0 seconds.

            // Create random y data
            double[] yData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;
            DateTime stamp = DateTime.Now;
            TimeSpan increment = TimeSpan.FromSeconds(1d);

            for (int i = 0; i < yData.Length; i++)
                yData[i] = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            
            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            //plot yData starting at x value 4 with an increment of 1.0
            wvfmGraph.PlotY(yData, 0, yData.Length, stamp, increment);
        }

        /// <summary>
        /// Plots a subset of an array of y values against a starting x value by 
        /// appending the x and y values to the existing data using the specified 
        /// TimeSpan to increment x values. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYAppend(double[], int, int, TimeSpan, PlotDateTimePrecisionMode)</signature>
        /// <ExampleMethod />
        public void PlotYAppend_doubleArray_int_int_TimeSpan_PlotDateTimePrecisionMode()
        {
            // The following example demonstrates appending a subset of an array of y values
            // with an increment of 1.0 seconds.

            // Create random y data
            double[] yData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;
            TimeSpan increment = TimeSpan.FromSeconds(1d);

            for (int i = 0; i < yData.Length; i++)
                yData[i] = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // plot yData starting at x value 4 with an increment of 1.0 
            // seconds with the default precision mode
            wvfmGraph.PlotYAppend(yData, 0, yData.Length, increment, PlotDateTimePrecisionMode.Default);
        }

        /// <summary>
        /// Plots an array of y values against the specified starting x value using 
        /// the specified value to increment x values. It is implemented in the
        /// WaveformGraph class. 
        /// </summary>
        /// <signature>PlotY(double[], int, int, double, double)</signature>
        /// <ExampleMethod />
        public void PlotY_doubleArray_int_int_double_double()
        {
            // The following example demonstrates plotting a subset of an array of y values
            // starting at an x value of 4.0 and incrementing with a value of 1.0.

            // Create random y data
            double[] yData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < yData.Length; i++)
                yData[i] = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            //plot yData starting at x value 4 with an increment of 1.0
            wvfmGraph.PlotY(yData, 0, yData.Length, 4d, 1d);
        }

        /// <summary>
        /// Plots a subset of an array of y values against a starting x value by 
        /// appending the x and y values to the existing data using the specified 
        /// value to increment x values. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYAppend(double[], int, int, double)</signature>
        /// <ExampleMethod />
        public void PlotYAppend_doubleArray_int_int_double()
        {
            // The following example demonstrates appending a subset of an array of y 
            // values incrementing with a value of 1.0.

            // Create random y data
            double[] yData = new double[50];
            double amp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < yData.Length; i++)
                yData[i] = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp;

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            //plot yData with an increment of 1.0
            wvfmGraph.PlotYAppend(yData, 0, yData.Length, 1d);
        }

        /// <summary>
        /// Plots a 2D array of y values with the specified data orientation against the 
        /// specified DateTime as the starting x value with the specified PlotDateTimePrecisionMode. 
        /// PlotYMultiple uses the specified TimeSpan to increment y values.  It is implemented 
        /// in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYMultiple(double[,], DataOrientation, DateTime, TimeSpan, PlotDateTimePrecisionMode)</signature>
        /// <ExampleMethod />
        public void PlotYMultiple_double2DArray_DataOrientation_DateTime_TimeSpan_PlotDateTimePrecisionMode()
        {
            // The following example demonstrates plotting multiple y data sets orgainized in columns
            // starting at an x value of DateTime.Now and incrementing at an interval of 2.75 seconds.
            double[,] yData = new double[50, 3];
            double amp;
            TimeSpan increment = TimeSpan.FromSeconds(2.75d);
            DateTime stamp = DateTime.Now;

            // Create sinusoidal y data
            for (int col = 0; col < yData.GetLength(1); col++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int row = 0; row < yData.GetLength(0); row++)
                {
                    yData[row, col] = amp * Math.Sin(2 * row * Math.PI / yData.GetLength(0)) + amp;
                }
            }

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // Plot all elements of the yData array, incrementing
            // X values by 2.75 seconds with each value.  Because there are three
            // columns of data, specify the DataOrientation to be in columns
            wvfmGraph.PlotYMultiple(yData, DataOrientation.DataInColumns, stamp, increment, PlotDateTimePrecisionMode.Default);
        }

        /// <summary>
        /// Plots a 2D array of y values with the specified orientation against a 
        /// starting y value with the specified PlotDateTimePrecisionMode. 
        /// PlotYAppendMultiple appends the x and y values to the existing data using .
        /// the specified TimeSpan to increment x values.  It is implemented in the 
        /// WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYAppendMultiple(double[,], DataOrientation, TimeSpan, PlotDateTimePrecisionMode)</signature>
        /// <ExampleMethod />
        public void PlotYAppendMultiple_double2DArray_DataOrientation_TimeSpan_PlotDateTimePrecisionMode()
        {
            // The following example demonstrates appending multiple y data sets orgainized in columns
            // incrementing at an interval of 2.75 seconds.
            double[,] yData = new double[50, 3];
            double amp;
            TimeSpan increment = TimeSpan.FromSeconds(2.75d);

            // Create sinusoidal y data
            for (int col = 0; col < yData.GetLength(1); col++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int row = 0; row < yData.GetLength(0); row++)
                {
                    yData[row, col] = amp * Math.Sin(2 * row * Math.PI / yData.GetLength(0)) + amp;
                }
            }

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // Plot all elements of the yData array, incrementing
            // X values by 2.75 seconds with each value.  Because there are three
            // columns of data, specify the DataOrientation to be in columns
            wvfmGraph.PlotYAppendMultiple(yData, DataOrientation.DataInColumns, increment, PlotDateTimePrecisionMode.Default);
        }

        /// <summary>
        /// Plots a 2D array of y values with the specified data orientation against 
        /// the specified starting x value. PlotYMultiple uses the specified value 
        /// to increment x values. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYMultiple(double[,], DataOrientation, double, double)</signature>
        /// <ExampleMethod />
        public void PlotYMultiple_double2DArray_DataOrientation_double_double()
        {
            // The following example demonstrates plotting multiple y data sets orgainized in rows
            // starting at an x value of 12.0 and incrementing at an interval of 3.0.
            double[,] yData = new double[3, 50];
            double amp;

            // Create sinusoidal y data
            for (int row = 0; row < yData.GetLength(0); row++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int col = 0; col < yData.GetLength(1); col++)
                {
                    yData[row, col] = amp * Math.Sin(2 * col * Math.PI / yData.GetLength(0)) + amp;
                }
            }

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // Plot all elements of the yData array, incrementing
            // X values by 3 with each value.  Because there are three
            // rows of data, specify the DataOrientation to be in rows
            wvfmGraph.PlotYMultiple(yData, DataOrientation.DataInRows, 12d, 3d);
        }

        /// <summary>
        /// Plots a 2D array of y values with the specified data orientation against 
        /// the specified starting x value. PlotYMultiple uses the specified value 
        /// to increment x values. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotYAppendMultiple(double[,], DataOrientation, double)</signature>
        /// <ExampleMethod />
        public void PlotYAppendMultiple_double2DArray_DataOrientation_double()
        {
            // The following example demonstrates appending multiple y data sets orgainized in rows
            // incrementing at an interval of 3.0.
            double[,] yData = new double[3, 50];
            double amp;

            // Create sinusoidal y data
            for (int row = 0; row < yData.GetLength(0); row++)
            {
                amp = RandNumberGenerator.NextDouble() * 10;
                for (int col = 0; col < yData.GetLength(1); col++)
                {
                    yData[row, col] = amp * Math.Sin(2 * col * Math.PI / yData.GetLength(0)) + amp;
                }
            }

            // Set the X-Axis to display samples
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = samplesFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotY)
                wvfmGraph.ClearData();
            // Plot all elements of the yData array, incrementing
            // X values by 3 with each value.  Because there are three
            // rows of data, specify the DataOrientation to be in rows
            wvfmGraph.PlotYAppendMultiple(yData, DataOrientation.DataInRows, 3d);
        }

        /// <summary>
        /// Plots AnalogWaveform&lt;TData&gt; data using the specified plot options.
        /// It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotWaveform&lt;TData&gt;(AnalogWaveform&lt;TData&gt;, AnalogWaveformPlotOptions)</signature>
        /// <ExampleMethod />
        public void GenericPlotWaveform_GenericAnalogWaveform_AnalogWaveformPlotOptions()
        {
            // The following example demonstrates plotting an AnalogWaveform on a 
            // WaveformGraph object.
            AnalogWaveform<double> waveform;
            AnalogWaveformPlotOptions plotOptions = new AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw);

            GetRandomWaveformData(out waveform);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotWaveform)
                wvfmGraph.ClearData();
            wvfmGraph.PlotWaveform<double>(waveform, plotOptions);
        }

        /// <summary>
        /// Plots AnalogWaveform&lt;TData&gt; data by appending the waveform to the existing 
        /// data. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotWaveformAppend&lt;TData&gt;(AnalogWaveform&lt;TData&gt;)</signature>
        /// <ExampleMethod />
        public void GenericPlotWaveformAppend_GenericAnalogWaveform()
        {
            // The following example demonstrates appending an AnalogWaveform to an 
            // existing WaveformGraph plot.
            AnalogWaveform<double> waveform;

            GetRandomWaveformData(out waveform);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotWaveform)
                wvfmGraph.ClearData();
            try
            {
                wvfmGraph.PlotWaveformAppend<double>(waveform);
            }
            catch (InvalidOperationException ioe)
            {
                wvfmGraph.ClearData();
                Debug.WriteLine(string.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}",
                    Environment.NewLine, ioe.Message));
                wvfmGraph.PlotWaveformAppend<double>(waveform);
            }
        }

        /// <summary>
        /// Plots a 1D array of AnalogWaveform&lt;TData&gt; data against the waveform sample 
        /// units or against time.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotWaveforms&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[], AnalogWaveformPlotOptions)</signature>
        /// <ExampleMethod />
        public void GenericPlotWaveforms_GenericAnalogWaveformArray_AnalogWaveformPlotOptions()
        {
            // The following example demonstrates plotting multiple AnalogWaveforms to 
            // a WaveformGraph object.
            AnalogWaveform<double>[] waveforms;
            AnalogWaveformPlotOptions plotOptions = new AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw);

            GetRandomWaveformData(out waveforms, 3);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotWaveform)
                wvfmGraph.ClearData();
            wvfmGraph.PlotWaveforms<double>(waveforms, plotOptions);
        }

        /// <summary>
        /// Plots an array of AnalogWaveform&lt;TData&gt; data by appending the waveforms to the 
        /// existing data. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotWaveformsAppend&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[])</signature>
        /// <ExampleMethod />
        public void GenericPlotWaveformsAppend_GenericAnalogWaveformArray()
        {
            // The following example demonstrates appending multiple AnalogWaveforms to 
            // existing WaveformGraph plots.
            AnalogWaveform<double>[] waveforms;

            GetRandomWaveformData(out waveforms, 3);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotWaveform)
                wvfmGraph.ClearData();
            try
            {
                wvfmGraph.PlotWaveformsAppend<double>(waveforms);
            }
            catch (InvalidOperationException ioe)
            {
                wvfmGraph.ClearData();
                Debug.WriteLine(string.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}",
                    Environment.NewLine, ioe.Message));
                wvfmGraph.PlotWaveformsAppend<double>(waveforms);
            }
        }

        /// <summary>
        /// Plots a 2D array of AnalogWaveform&lt;TData&gt; data against the waveform sample units
        /// or against time.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotWaveformsMultiple&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[,], AnalogWaveformPlotOptions)</signature>
        /// <ExampleMethod />
        public void GenericPlotWaveformsMultiple_GenericAnalogWaveform2DArray_AnalogWaveformPlotOptions()
        {
            // The following example demonstrates plotting multiple AnalogWaveforms to 
            // a WaveformGraph object.
            AnalogWaveform<double>[,] waveforms;
            AnalogWaveformPlotOptions plotOptions = new AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw);

            GetRandomWaveformData(out waveforms, 2);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotWaveform)
                wvfmGraph.ClearData();
            wvfmGraph.PlotWaveformsMultiple<double>(waveforms, plotOptions);
        }

        /// <summary>
        /// Plots a 2D array of AnalogWaveform&lt;TData&gt; data by appending the waveforms against
        /// the existing data. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotWaveformsAppendMultiple&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[,])</signature>
        /// <ExampleMethod />
        public void GenericPlotWaveformsAppendMultiple_GenericAnalogWaveform2DArray()
        {
            // The following example demonstrates appending multiple AnalogWaveforms to 
            // existing WaveformGraph plots.
            AnalogWaveform<double>[,] waveforms;

            GetRandomWaveformData(out waveforms, 2);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotWaveform)
                wvfmGraph.ClearData();
            try
            {
                wvfmGraph.PlotWaveformsAppendMultiple<double>(waveforms);
            }
            catch (InvalidOperationException ioe)
            {
                wvfmGraph.ClearData();
                Debug.WriteLine(string.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}",
                    Environment.NewLine, ioe.Message));
                wvfmGraph.PlotWaveformsAppendMultiple<double>(waveforms);
            }
        }

        /// <summary>
        /// Plots ComplexWaveform&lt;TData&gt; data using the specified plot options.  
        /// It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotComplexWaveform&lt;TData&gt;(ComplexWaveform&lt;TData&gt;, ComplexWaveformPlotOptions)</signature>
        /// <ExampleMethod />
        public void GenericPlotComplexWaveform_GenericComplexWaveform_ComplexWaveformPlotOptions()
        {
            // The following example demonstrates plotting a ComplexWaveform to 
            // a WaveformGraph object.
            ComplexWaveform<ComplexDouble> waveform;
            ComplexWaveformPlotOptions options = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time,
                                                                                ComplexWaveformPlotScaleMode.Raw,
                                                                                ComplexDataPart.Real);

            GetRandomComplexWaveformData(out waveform);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotComplexWaveform)
                wvfmGraph.ClearData();
            wvfmGraph.PlotComplexWaveform<ComplexDouble>(waveform, options);
        }

        /// <summary>
        /// Plots ComplexWaveform&lt;TData&gt; data by appending the waveform to the 
        /// existing data.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotComplexWaveformAppend&lt;TData&gt;(ComplexWaveform&lt;TData&gt;)</signature>
        /// <ExampleMethod />
        public void GenericPlotComplexWaveformAppend_GenericComplexWaveform()
        {
            // The following example demonstrates appending a ComplexWaveform to 
            // an existing WaveformGraph plot.
            ComplexWaveform<ComplexDouble> waveform;

            GetRandomComplexWaveformData(out waveform);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotComplexWaveform)
                wvfmGraph.ClearData();

            try
            {
                wvfmGraph.PlotComplexWaveformAppend<ComplexDouble>(waveform);
            }
            catch (InvalidOperationException ioe)
            {
                wvfmGraph.ClearData();
                Debug.WriteLine(string.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}",
                    Environment.NewLine, ioe.Message));
                wvfmGraph.PlotComplexWaveformAppend<ComplexDouble>(waveform);
            }
        }

        /// <summary>
        /// Plots a 1D array of ComplexWaveform&lt;TData&gt; data using the specified 
        /// plot options.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotComplexWaveforms&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[], ComplexWaveformPlotOptions)</signature>
        /// <ExampleMethod />
        public void GenericPlotComplexWaveforms_GenericComplexWaveformArray_ComplexWaveformPlotOptions()
        {
            // The following example demonstrates plotting multiple ComplexWaveforms to 
            // a WaveformGraph object.
            ComplexWaveform<ComplexDouble>[] waveforms;
            ComplexWaveformPlotOptions options = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time,
                                                                                ComplexWaveformPlotScaleMode.Raw,
                                                                                ComplexDataPart.Real);

            GetRandomComplexWaveformData(out waveforms, 2);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotComplexWaveform)
                wvfmGraph.ClearData();
            wvfmGraph.PlotComplexWaveforms<ComplexDouble>(waveforms, options);
        }

        /// <summary>
        /// Plots an array of ComplexWaveform&lt;TData&gt; data by appending the waveforms 
        /// to the existing data.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotComplexWaveformsAppend&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[])</signature>
        /// <ExampleMethod />
        public void GenericPlotComplexWaveformsAppend_GenericComplexWaveformArray()
        {
            // The following example demonstrates appending multiple ComplexWaveforms to 
            // existing WaveformGraph plots.
            ComplexWaveform<ComplexDouble>[] waveforms;

            GetRandomComplexWaveformData(out waveforms, 2);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotComplexWaveform)
                wvfmGraph.ClearData();
            try
            {
                wvfmGraph.PlotComplexWaveformsAppend<ComplexDouble>(waveforms);
            }
            catch (InvalidOperationException ioe)
            {
                wvfmGraph.ClearData();
                Debug.WriteLine(string.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}",
                    Environment.NewLine, ioe.Message));
                wvfmGraph.PlotComplexWaveformsAppend<ComplexDouble>(waveforms);
            }
        }

        /// <summary>
        /// Plots a 2D array of ComplexWaveform&lt;TData&gt; data using the specified plot 
        /// options.  It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotComplexWaveformsMultiple&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[,], ComplexWaveformPlotOptions)</signature>
        /// <ExampleMethod />
        public void GenericPlotComplexWaveformsMultiple_GenericComplexWaveform2DArray_ComplexWaveformPlotOptions()
        {
            // The following example demonstrates plotting multiple ComplexWaveforms to 
            // a WaveformGraph object.
            ComplexWaveform<ComplexDouble>[,] waveforms;
            ComplexWaveformPlotOptions options = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time,
                                                                                ComplexWaveformPlotScaleMode.Raw,
                                                                                ComplexDataPart.Real);

            GetRandomComplexWaveformData(out waveforms, 2);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotComplexWaveform)
                wvfmGraph.ClearData();
            wvfmGraph.PlotComplexWaveformsMultiple<ComplexDouble>(waveforms, options);
        }

        /// <summary>
        /// Plots a 2D array of ComplexWaveform&lt;TData&gt; data by appending the 
        /// waveforms against the existing data. It is implemented in the WaveformGraph class. 
        /// </summary>
        /// <signature>PlotComplexWaveformsAppendMultiple&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[,])</signature>
        /// <ExampleMethod />
        public void GenericPlotComplexWaveformsAppendMultiple_GenericComplexWaveform2DArray()
        {
            // The following example demonstrates appending multiple ComplexWaveforms to 
            // existing WaveformGraph plots.
            ComplexWaveform<ComplexDouble>[,] waveforms;

            GetRandomComplexWaveformData(out waveforms, 2);

            // Set the X-Axis to display time
            wvfmGraph.XAxes[0].MajorDivisions.LabelFormat = timeFormatString;
            // Set the Y-Axis to display samples
            wvfmGraph.YAxes[0].MajorDivisions.LabelFormat = samplesFormatString;

            if (wvfmGraph.Plots[0].Mode != WaveformPlotMode.PlotComplexWaveform)
                wvfmGraph.ClearData();
            try
            {
                wvfmGraph.PlotComplexWaveformsAppendMultiple<ComplexDouble>(waveforms);
            }
            catch (InvalidOperationException ioe)
            {
                wvfmGraph.ClearData();
                Debug.WriteLine(string.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}",
                    Environment.NewLine, ioe.Message));
                wvfmGraph.PlotComplexWaveformsAppendMultiple<ComplexDouble>(waveforms);
            }
        }
        #endregion

        #region helper methods for the SnipsWaveformGraph class

        private void wvfmGraph_AfterDrawPlotArea(object sender, AfterDrawEventArgs e)
        {
            WaveformGraph graph = sender as WaveformGraph;
            if (graph != null)
            {                
                List<SnipsLegendItem> legendItems = new List<SnipsLegendItem>(graph.Plots.Count);
                foreach (WaveformPlot plot in graph.Plots)
                {
                    SnipsLegendItem item = new SnipsLegendItem(plot, plot.ToString(), plot.GetYData().Length > 0);
                    legendItems.Add(item);
                }
                MainForm.Legend.SetItems(legendItems);
            }
        }

        private void wvfmGraph_PlotsChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e)
        {
            WaveformGraph graph = sender as WaveformGraph;
            if (graph != null)
            {
                foreach (WaveformPlot plot in graph.Plots)
                {
                    plot.PointStyle = PointStyle.Cross;
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
            PlotY_doubleArray();
        }

        private void GetRandomWaveformData(out AnalogWaveform<double> waveform)
        {
            AnalogWaveform<double> wvform;
            double[] data = new double[50];
            DateTime[] times = new DateTime[data.Length];
            double amp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = amp * Math.Sin(2 * i * Math.PI / data.Length) + amp;
                times[i] = DateTime.Now.AddSeconds(RandNumberGenerator.NextDouble() + i);
            }

            wvform = AnalogWaveform<double>.FromArray1D(data);
            wvform.Timing = WaveformTiming.CreateWithIrregularInterval(times);
            waveform = wvform;
        }

        private void GetRandomWaveformData(out AnalogWaveform<double>[] waveformArray, int numPlots)
        {
            AnalogWaveform<double>[] wvformArray = new AnalogWaveform<double>[numPlots];
            double[,] data = new double[3, 50];
            double secondsOffset;
            double amp = RandNumberGenerator.NextDouble() * 10;
            TimeSpan increment = TimeSpan.FromSeconds(1.0d);
            DateTime stamp = DateTime.Now;

            for (int row = 0; row < data.GetLength(0); row++)
                for (int col = 0; col < data.GetLength(1); col++)
                    data[row, col] = amp * Math.Sin(2 * col * Math.PI / data.GetLength(1)) + amp;

            wvformArray = AnalogWaveform<double>.FromArray2D(data);

            for (int i = 0; i < wvformArray.Length; i++)
            {
                secondsOffset = i > 0 ? increment.Seconds * wvformArray[i - 1].SampleCount * i : 0;
                stamp = DateTime.Now.AddSeconds(secondsOffset);
                wvformArray[i].Timing = WaveformTiming.CreateWithRegularInterval(increment, stamp);
            }
            waveformArray = wvformArray;
        }

        private void GetRandomWaveformData(out AnalogWaveform<double>[,] waveformArray, int numPlots)
        {
            AnalogWaveform<double>[,] wvformArray = new AnalogWaveform<double>[numPlots, 3];
            AnalogWaveform<double>[] wvforms;

            for (int plot = 0; plot < numPlots; plot++)
            {
                GetRandomWaveformData(out wvforms, wvformArray.GetLength(1));
                for (int col = 0; col < wvformArray.GetLength(1); col++)
                {
                    wvformArray[plot, col] = wvforms[col];
                }
            }
            waveformArray = wvformArray;
        }

        private void GetRandomComplexWaveformData(out ComplexWaveform<ComplexDouble> waveform)
        {
            ComplexWaveform<ComplexDouble> wvform;
            ComplexDouble[] data = new ComplexDouble[100];
            PrecisionDateTime stamp = new PrecisionDateTime(DateTime.Now);
            PrecisionTimeSpan increment = new PrecisionTimeSpan(TimeSpan.FromSeconds(2.0d));
            double realAmp = RandNumberGenerator.NextDouble() * 10;
            double imaginaryAmp = RandNumberGenerator.NextDouble() * 10;

            for (int i = 0; i < data.Length; i++)
            {
                data[i].Real = realAmp * Math.Sin(2 * i * Math.PI / data.Length) + realAmp;
                data[i].Imaginary = imaginaryAmp * Math.Sin(2 * i * Math.PI / data.Length) + imaginaryAmp;
            }

            wvform = ComplexWaveform<ComplexDouble>.FromArray1D(data);
            wvform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(increment, stamp);

            waveform = wvform;
        }

        private void GetRandomComplexWaveformData(out ComplexWaveform<ComplexDouble>[] waveforms, int numPlots)
        {
            double secondsOffset;
            ComplexWaveform<ComplexDouble>[] wvforms = new ComplexWaveform<ComplexDouble>[numPlots];
            PrecisionTimeSpan increment = new PrecisionTimeSpan(TimeSpan.FromSeconds(2.0d));
            PrecisionDateTime stamp;

            for (int i = 0; i < wvforms.Length; i++)
            {
                GetRandomComplexWaveformData(out wvforms[i]);
                secondsOffset = i > 0 ? increment.Seconds * wvforms[i - 1].SampleCount * i : 0;
                stamp = new PrecisionDateTime(DateTime.Now.AddSeconds(secondsOffset));
                wvforms[i].PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(increment, stamp);
            }
            waveforms = wvforms;
        }

        private void GetRandomComplexWaveformData(out ComplexWaveform<ComplexDouble>[,] waveforms, int numPlots)
        {
            ComplexWaveform<ComplexDouble>[,] wvformArray = new ComplexWaveform<ComplexDouble>[numPlots, 3];
            ComplexWaveform<ComplexDouble>[] wvforms;

            for (int plot = 0; plot < numPlots; plot++)
            {
                GetRandomComplexWaveformData(out wvforms, wvformArray.GetLength(1));
                for (int col = 0; col < wvformArray.GetLength(1); col++)
                {
                    wvformArray[plot, col] = wvforms[col];
                }
            }
            waveforms = wvformArray;
        }
        #endregion
    }
}
