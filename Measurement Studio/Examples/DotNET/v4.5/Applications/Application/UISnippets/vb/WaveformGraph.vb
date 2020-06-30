Imports System.Globalization
Imports NationalInstruments.UI.WindowsForms

NotInheritable Class SnipsWaveformGraph
    Inherits SnipsXYGraph
    Private wvfmGraph As WaveformGraph
    Private timeFormatString As New FormatString(CultureInfo.CurrentCulture, FormatStringMode.DateTime, "h:mm:ss tt")
    Private samplesFormatString As New FormatString(CultureInfo.CurrentCulture, FormatStringMode.Numeric, "G5")

    ''' <summary>
    ''' Creates a new waveformGraph object for use in this 
    ''' code snippets example
    ''' </summary>
    ''' <param name="waveformGraph">The Waveform graph to be used Integerernally</param>
    Public Sub New(ByVal waveformGraph As WaveformGraph)
        MyBase.New(waveformGraph, waveformGraph.Plots(0))
        wvfmGraph = waveformGraph

        AddHandler wvfmGraph.PlotsChanged, AddressOf wvfmGraph_PlotsChanged
        AddHandler wvfmGraph.AfterDrawPlotArea, AddressOf wvfmGraph_AfterDrawPlotArea
        ResetToDefaultState()
    End Sub

#Region "Code Snippets for NationalInstruments.UI.WindowsForms.WaveformGraph"

    ''' <summary>
    ''' Plots a single x value against the default starting y value. 
    ''' It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotX(Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotX_double()
        ' The following example demonstrates plotting a single x value against
        ' the default starting y value.
        Dim xData As Double = RandNumberGenerator.NextDouble()

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' plot random y value
        wvfmGraph.PlotX(xData)
    End Sub

    ''' <summary>
    ''' Plots a subset of an array of x values against the specified DateTime as the 
    ''' starting y value with the specified PlotDateTimePrecisionMode. PlotX uses the 
    ''' specified TimeSpan to increment y values. It is implmented in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotX(Double[], Int32, Int32, DateTime, TimeSpan, PlotDateTimePrecisionMode)</signature>        
    ''' <ExampleMethod />
    Public Sub PlotX_doubleArray_Int32_Int32_TimeSpan_PlotDateTimePrecisionMode()
        ' The following example demonstrates plotting a subset of an array of x values 
        ' against the starting y DateTime value of DateTime.Now with the specified 
        ' PlotDateTimePrecisionMode of Default.

        ' Create random x data
        Dim xData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10
        Dim increment As TimeSpan = TimeSpan.FromSeconds(1.0)
        Dim stamp As DateTime = DateTime.Now

        For i As Integer = 0 To xData.Length - 1
            xData(i) = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display time
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = timeFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot 6 elements from the xData array beginning from the element at index 2.
        ' Increment Y values at 1 second per element, with default precision
        wvfmGraph.PlotX(xData, 2, 6, stamp, increment, PlotDateTimePrecisionMode.[Default])
    End Sub

    ''' <summary>
    ''' Plots a subset of an array of x values against the specified starting y 
    ''' value using the specified value to increment y values.  It is implemented 
    ''' in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotX(Double[], Integer, Integer, Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotX_doubleArray_int_int_double_double()
        ' The following example demonstrates plotting a subset of an array of x values
        ' against a starting y value of 6.5 using a value of 1.5 to increment the y-values.

        ' Create random x data
        Dim xData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To xData.Length - 1
            xData(i) = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the xData array, incrementing
        ' Y values 1.5 units per xData element, starting at x value 6.5
        wvfmGraph.PlotX(xData, 0, xData.Length, 6.5, 1.5)
    End Sub

    ''' <summary>
    ''' Plots a single x value against a starting y value by appending 
    ''' the x and y values to the existing data using the specified value
    ''' to increment y values. It is implemented in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXAppend(Double, Double)</signature>        
    ''' <ExampleMethod />
    Public Sub PlotXAppend_double_double()
        ' The following example demonstrates appending a single x value with 
        ' a y increment of 1.0.
        Dim xData As Double = RandNumberGenerator.NextDouble() * 10

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' plot random X Value with a 1.0 increment
        wvfmGraph.PlotXAppend(xData, 1.0)
    End Sub

    ''' <summary>
    ''' Plots a single x value against a starting y value by appending the x and y 
    ''' values to the existing data using the specified TimeSpan to increment y 
    ''' values.  It is implemented in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXAppend(Double, TimeSpan)</signature>        
    ''' <ExampleMethod />
    Public Sub PlotXAppend_double_TimeSpan()
        ' The following example demonstrates plotting a single x value with
        ' a y increment of 3.5 seconds.
        Dim xData As Double = RandNumberGenerator.NextDouble() * 10
        Dim increment As TimeSpan = TimeSpan.FromSeconds(3.5)

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display time
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = timeFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' plot random X Value with a 1.0 increment
        wvfmGraph.PlotXAppend(xData, increment)
    End Sub

    ''' <summary>
    ''' plots a subset of an array of x values against a starting y value with the specified 
    ''' PlotDateTimePrecisionMode. PlotXAppend appends the x and y values to the existing 
    ''' data using the specified TimeSpan to increment y values.  It is implmented in the 
    ''' WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXAppend(Double[], Int32, Int32, TimeSpan, PlotDateTimePrecisionMode)</signature>        
    ''' <ExampleMethod />
    Public Sub PlotXAppend_doubleArray_Int32_Int32_TimeSpan_PlotDateTimePrecisionMode()
        ' The following example demonstrates appending a subset of an array of x values 
        ' with a y increment of 1 second and a specified PlotDateTimePrecisionMode of Default.

        ' Create random x data
        Dim xData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To xData.Length - 1
            xData(i) = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display time
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = timeFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot 6 elements from the xData array beginning from the element at index 2.
        ' Increment Y values at 1 second per element, with default precision
        wvfmGraph.PlotXAppend(xData, 2, 6, TimeSpan.FromSeconds(1.0), PlotDateTimePrecisionMode.[Default])
    End Sub

    ''' <summary>
    ''' Plots a subset of an array of x values against a starting y value by 
    ''' appending the x and y values to the existing data using the specified 
    ''' value to increment y values. It is implemented in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXAppend(Double[], Int32, Int32, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXAppend_doubleArray_Int32_Int32_double()
        ' The following example demonstrates appending a subset of x values with
        ' a y increment of 1.5.

        ' Create random x data
        Dim xData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To xData.Length - 1
            xData(i) = amp * Math.Sin(2 * i * Math.PI / xData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the xData array, incrementing
        ' Y values 1.5 units per xData element.
        wvfmGraph.PlotXAppend(xData, 0, xData.Length, 1.5)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of x values with the specified data orientation against the
    ''' specified starting y value. PlotXMultiple uses the specified value to 
    ''' increment y values.   It is implemented in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXMultiple(Double[,], DataOrientation, Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXMultiple_double2DArray_DataOrientation_double_double()
        ' The following example demonstrates plotting multiple sets of data organized in 
        ' rows against a starting y value of 0 and at an increment of 1.5.
        Dim xData As Double(,) = New Double(2, 49) {}
        Dim amp As Double

        ' Create random x data
        For row As Integer = 0 To xData.GetLength(0) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For col As Integer = 0 To xData.GetLength(1) - 1
                xData(row, col) = amp * Math.Sin(2 * col * Math.PI / xData.GetLength(1)) + amp
            Next
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the xData array, incrementing
        ' Y values 1.5 units per xData element.  Because there are
        ' three rows of data, specify the DataOrientation to be in rows
        wvfmGraph.PlotXMultiple(xData, DataOrientation.DataInRows, 0.0, 1.5)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of x values with the specified data orientation against the 
    ''' specified DateTime as the starting y value. PlotXMultiple uses the specified 
    ''' TimeSpan to increment y values.    It is implemented in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXMultiple(Double[,], DataOrientation, DateTime, TimeSpan)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXMultiple_double2DArray_DataOrientation_DateTime_TimeSpan()
        ' The following example demonstrates plotting multiple sets of data organized in 
        ' columns against a starting y value of DateTime.Now and at an increment of 2.75 seconds.
        Dim xData As Double(,) = New Double(49, 2) {}
        Dim amp As Double
        Dim increment As TimeSpan = TimeSpan.FromSeconds(2.75)
        Dim timeStamp As DateTime = DateTime.Now

        ' Create random x data
        For col As Integer = 0 To xData.GetLength(1) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For row As Integer = 0 To xData.GetLength(0) - 1
                xData(row, col) = amp * Math.Sin(2 * row * Math.PI / xData.GetLength(0)) + amp
            Next
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display time
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = timeFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the xData array, incrementing
        ' Y values by 2.75 seconds with each value.  Because there are three
        ' columns of data, specify the DataOrientation to be in columns
        wvfmGraph.PlotXMultiple(xData, DataOrientation.DataInColumns, timeStamp, increment)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of x values with the specified orientation against a starting y 
    ''' value by appending the x and y values to the existing data using the specified 
    ''' value to increment y values.  It is implemented in the WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXAppendMultiple(Double[,], DataOrientation, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXAppendMultiple_double2DArray_DataOrientation_double()
        ' The following example demonstrates appending multiple sets of data organized in 
        ' rows at an increment of 1.5.
        Dim xData As Double(,) = New Double(2, 49) {}
        Dim amp As Double

        ' Create random x data
        For row As Integer = 0 To xData.GetLength(0) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For col As Integer = 0 To xData.GetLength(1) - 1
                xData(row, col) = amp * Math.Sin(2 * col * Math.PI / xData.GetLength(1)) + amp
            Next
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the xData array, incrementing
        ' Y values 1.5 units per xData element.  Because there are
        ' three rows of data, specify the DataOrientation to be in rows
        wvfmGraph.PlotXAppendMultiple(xData, DataOrientation.DataInRows, 1.5)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of x values with the specified orientation against a 
    ''' starting y value by appending the x and y values to the existing data using 
    ''' the specified TimeSpan to increment y values.   It is implemented in the 
    ''' WaveformGraph class.
    ''' </summary>
    ''' <signature>PlotXAppendMultiple(Double[,], DataOrientation, TimeSpan)</signature>
    ''' <ExampleMethod />
    Public Sub PlotXAppendMultiple_double2DArray_DataOrientation_TimeSpan()
        ' The following example demonstrates appending multiple sets of data organized in 
        ' columns at an increment of 2.75 seconds.
        Dim xData As Double(,) = New Double(49, 2) {}
        Dim amp As Double
        Dim increment As TimeSpan = TimeSpan.FromSeconds(2.75)

        ' Create random x data
        For col As Integer = 0 To xData.GetLength(1) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For row As Integer = 0 To xData.GetLength(0) - 1
                xData(row, col) = amp * Math.Sin(2 * row * Math.PI / xData.GetLength(0)) + amp
            Next
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display time
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = timeFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotX Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the xData array, incrementing
        ' Y values by 2.75 seconds with each value.  Because there are three
        ' columns of data, specify the DataOrientation to be in columns
        wvfmGraph.PlotXAppendMultiple(xData, DataOrientation.DataInColumns, increment)
    End Sub

    ''' <summary>
    ''' Plots a single y value against the default starting x value. 
    ''' It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotY(Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotY_double()
        ' The following example demonstrates plotting a single y value against the 
        ' default starting x value.
        Dim yData As Double = RandNumberGenerator.NextDouble()

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' plot random y value
        wvfmGraph.PlotY(yData)
    End Sub

    ''' <summary>
    ''' Plots a single y value against a starting x value by appending the 
    ''' x and y values to the existing data using the specified value to
    ''' increment x values.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppend(Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppend_double_double()
        ' The following example demonstrates appending a single y value with
        ' a y increment of 2.0
        Dim yData As Double = RandNumberGenerator.NextDouble()

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' plot random y value incrementing by 2
        wvfmGraph.PlotYAppend(yData, 2.0)
    End Sub

    ''' <summary>
    ''' Plots a single y value against a starting x value by appending the x 
    ''' and y values to the existing data using the specified TimeSpan to 
    ''' increment x values.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppend(Double, TimeSpan)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppend_double_TimeSpan()
        ' The following example demonstrates appending a single y value with
        ' a y increment of 2.0 seconds 
        Dim yData As Double = RandNumberGenerator.NextDouble()
        Dim increment As TimeSpan = TimeSpan.FromSeconds(2.0)

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' plot random y value incrementing by 2 seconds
        wvfmGraph.PlotYAppend(yData, increment)
    End Sub

    ''' <summary>
    ''' Plots an array of y values against the default starting x value using the 
    ''' default increment value. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotY(Double[])</signature>
    ''' <ExampleMethod />
    Public Sub PlotY_doubleArray()
        ' The following example demonstrates plotting an array of y values
        ' against the default starting x value using the default increment value.
        Dim yData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        ' Create random y data
        For i As Integer = 0 To yData.Length - 1
            yData(i) = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' plot random y values 
        wvfmGraph.PlotY(yData)
    End Sub

    ''' <summary>
    ''' Plots an array of y values against a starting x value by appending 
    ''' the x and y values to the existing data.  It is implemented in the 
    ''' WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppend(Double[])</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppend_doubleArray()
        ' The following example demonstrates appending an array of y values
        ' against the default starting x value using the default increment value.
        Dim yData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        ' Create random y data
        For i As Integer = 0 To yData.Length - 1
            yData(i) = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' plot random y values 
        wvfmGraph.PlotYAppend(yData)
    End Sub

    ''' <summary>
    ''' Plots an array of y values against the specified DateTime as the starting x 
    ''' value using the specified TimeSpan to increment x values. It is implemented 
    ''' in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotY(Double[], Integer, Integer, DateTime, TimeSpan)</signature>
    ''' <ExampleMethod />
    Public Sub PlotY_doubleArray_int_int_DateTime_TimeSpan()
        ' The following example demonstrates plotting a subset of an array of y values
        ' against the starting x value of DateTime.Now and incrementing at 1.0 seconds.

        ' Create random y data
        Dim yData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10
        Dim stamp As DateTime = DateTime.Now
        Dim increment As TimeSpan = TimeSpan.FromSeconds(1.0)

        For i As Integer = 0 To yData.Length - 1
            yData(i) = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        'plot yData starting at x value 4 with an increment of 1.0
        wvfmGraph.PlotY(yData, 0, yData.Length, stamp, increment)
    End Sub

    ''' <summary>
    ''' Plots a subset of an array of y values against a starting x value by 
    ''' appending the x and y values to the existing data using the specified 
    ''' TimeSpan to increment x values. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppend(Double[], Integer, Integer, TimeSpan, PlotDateTimePrecisionMode)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppend_doubleArray_int_int_TimeSpan_PlotDateTimePrecisionMode()
        ' The following example demonstrates appending a subset of an array of y values
        ' with an increment of 1.0 seconds.

        ' Create random y data
        Dim yData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10
        Dim increment As TimeSpan = TimeSpan.FromSeconds(1.0)

        For i As Integer = 0 To yData.Length - 1
            yData(i) = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' plot yData starting at x value 4 with an increment of 1.0 
        ' seconds with the default precision mode
        wvfmGraph.PlotYAppend(yData, 0, yData.Length, increment, PlotDateTimePrecisionMode.[Default])
    End Sub

    ''' <summary>
    ''' Plots an array of y values against the specified starting x value using 
    ''' the specified value to increment x values. It is implemented in the
    ''' WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotY(Double[], Integer, Integer, Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotY_doubleArray_int_int_double_double()
        ' The following example demonstrates plotting a subset of an array of y values
        ' starting at an x value of 4.0 and incrementing with a value of 1.0.

        ' Create random y data
        Dim yData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To yData.Length - 1
            yData(i) = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        'plot yData starting at x value 4 with an increment of 1.0
        wvfmGraph.PlotY(yData, 0, yData.Length, 4.0, 1.0)
    End Sub

    ''' <summary>
    ''' Plots a subset of an array of y values against a starting x value by 
    ''' appending the x and y values to the existing data using the specified 
    ''' value to increment x values. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppend(Double[], Integer, Integer, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppend_doubleArray_int_int_double()
        ' The following example demonstrates appending a subset of an array of y 
        ' values incrementing with a value of 1.0.

        ' Create random y data
        Dim yData As Double() = New Double(49) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To yData.Length - 1
            yData(i) = amp * Math.Sin(2 * i * Math.PI / yData.Length) + amp
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        'plot yData with an increment of 1.0
        wvfmGraph.PlotYAppend(yData, 0, yData.Length, 1.0)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of y values with the specified data orientation against the 
    ''' specified DateTime as the starting x value with the specified PlotDateTimePrecisionMode. 
    ''' PlotYMultiple uses the specified TimeSpan to increment y values.  It is implemented 
    ''' in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYMultiple(Double[,], DataOrientation, DateTime, TimeSpan, PlotDateTimePrecisionMode)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYMultiple_double2DArray_DataOrientation_DateTime_TimeSpan_PlotDateTimePrecisionMode()
        ' The following example demonstrates plotting multiple y data sets orgainized in columns
        ' starting at an x value of DateTime.Now and incrementing at an Integererval of 2.75 seconds.
        Dim yData As Double(,) = New Double(49, 2) {}
        Dim amp As Double
        Dim increment As TimeSpan = TimeSpan.FromSeconds(2.75)
        Dim stamp As DateTime = DateTime.Now

        ' Create sinusoidal y data
        For col As Integer = 0 To yData.GetLength(1) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For row As Integer = 0 To yData.GetLength(0) - 1
                yData(row, col) = amp * Math.Sin(2 * row * Math.PI / yData.GetLength(0)) + amp
            Next
        Next

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the yData array, incrementing
        ' X values by 2.75 seconds with each value.  Because there are three
        ' columns of data, specify the DataOrientation to be in columns
        wvfmGraph.PlotYMultiple(yData, DataOrientation.DataInColumns, stamp, increment, PlotDateTimePrecisionMode.[Default])
    End Sub

    ''' <summary>
    ''' Plots a 2D array of y values with the specified orientation against a 
    ''' starting y value with the specified PlotDateTimePrecisionMode. 
    ''' PlotYAppendMultiple appends the x and y values to the existing data using .
    ''' the specified TimeSpan to increment x values.  It is implemented in the 
    ''' WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppendMultiple(Double[,], DataOrientation, TimeSpan, PlotDateTimePrecisionMode)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppendMultiple_double2DArray_DataOrientation_TimeSpan_PlotDateTimePrecisionMode()
        ' The following example demonstrates appending multiple y data sets orgainized in columns
        ' incrementing at an Integererval of 2.75 seconds.
        Dim yData As Double(,) = New Double(49, 2) {}
        Dim amp As Double
        Dim increment As TimeSpan = TimeSpan.FromSeconds(2.75)

        ' Create sinusoidal y data
        For col As Integer = 0 To yData.GetLength(1) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For row As Integer = 0 To yData.GetLength(0) - 1
                yData(row, col) = amp * Math.Sin(2 * row * Math.PI / yData.GetLength(0)) + amp
            Next
        Next

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the yData array, incrementing
        ' X values by 2.75 seconds with each value.  Because there are three
        ' columns of data, specify the DataOrientation to be in columns
        wvfmGraph.PlotYAppendMultiple(yData, DataOrientation.DataInColumns, increment, PlotDateTimePrecisionMode.[Default])
    End Sub

    ''' <summary>
    ''' Plots a 2D array of y values with the specified data orientation against 
    ''' the specified starting x value. PlotYMultiple uses the specified value 
    ''' to increment x values. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYMultiple(Double[,], DataOrientation, Double, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYMultiple_double2DArray_DataOrientation_double_double()
        ' The following example demonstrates plotting multiple y data sets orgainized in rows
        ' starting at an x value of 12.0 and incrementing at an Integererval of 3.0.
        Dim yData As Double(,) = New Double(2, 49) {}
        Dim amp As Double

        ' Create sinusoidal y data
        For row As Integer = 0 To yData.GetLength(0) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For col As Integer = 0 To yData.GetLength(1) - 1
                yData(row, col) = amp * Math.Sin(2 * col * Math.PI / yData.GetLength(0)) + amp
            Next
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the yData array, incrementing
        ' X values by 3 with each value.  Because there are three
        ' rows of data, specify the DataOrientation to be in rows
        wvfmGraph.PlotYMultiple(yData, DataOrientation.DataInRows, 12.0, 3.0)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of y values with the specified data orientation against 
    ''' the specified starting x value. PlotYMultiple uses the specified value 
    ''' to increment x values. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotYAppendMultiple(Double[,], DataOrientation, Double)</signature>
    ''' <ExampleMethod />
    Public Sub PlotYAppendMultiple_double2DArray_DataOrientation_double()
        ' The following example demonstrates appending multiple y data sets orgainized in rows
        ' incrementing at an Integererval of 3.0.
        Dim yData As Double(,) = New Double(2, 49) {}
        Dim amp As Double

        ' Create sinusoidal y data
        For row As Integer = 0 To yData.GetLength(0) - 1
            amp = RandNumberGenerator.NextDouble() * 10
            For col As Integer = 0 To yData.GetLength(1) - 1
                yData(row, col) = amp * Math.Sin(2 * col * Math.PI / yData.GetLength(0)) + amp
            Next
        Next

        ' Set the X-Axis to display samples
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = samplesFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotY Then
            wvfmGraph.ClearData()
        End If
        ' Plot all elements of the yData array, incrementing
        ' X values by 3 with each value.  Because there are three
        ' rows of data, specify the DataOrientation to be in rows
        wvfmGraph.PlotYAppendMultiple(yData, DataOrientation.DataInRows, 3.0)
    End Sub

    ''' <summary>
    ''' Plots AnalogWaveform&lt;TData&gt; data using the specified plot options.
    ''' It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotWaveform&lt;TData&gt;(AnalogWaveform&lt;TData&gt;, AnalogWaveformPlotOptions)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotWaveform_GenericAnalogWaveform_AnalogWaveformPlotOptions()
        ' The following example demonstrates plotting an AnalogWaveform on a 
        ' WaveformGraph object.
        Dim waveform As AnalogWaveform(Of Double) = Nothing
        Dim plotOptions As New AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw)

        GetRandomWaveformData(waveform)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotWaveform Then
            wvfmGraph.ClearData()
        End If
        wvfmGraph.PlotWaveform(Of Double)(waveform, plotOptions)
    End Sub

    ''' <summary>
    ''' Plots AnalogWaveform&lt;TData&gt; data by appending the waveform to the existing 
    ''' data. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotWaveformAppend&lt;TData&gt;(AnalogWaveform&lt;TData&gt;)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotWaveformAppend_GenericAnalogWaveform()
        ' The following example demonstrates appending an AnalogWaveform to an 
        ' existing WaveformGraph plot.
        Dim waveform As AnalogWaveform(Of Double) = Nothing

        GetRandomWaveformData(waveform)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotWaveform Then
            wvfmGraph.ClearData()
        End If
        Try
            wvfmGraph.PlotWaveformAppend(Of Double)(waveform)
        Catch ioe As InvalidOperationException
            wvfmGraph.ClearData()
            Debug.WriteLine(String.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}", Environment.NewLine, ioe.Message))
            wvfmGraph.PlotWaveformAppend(Of Double)(waveform)
        End Try
    End Sub

    ''' <summary>
    ''' Plots a 1D array of AnalogWaveform&lt;TData&gt; data against the waveform sample 
    ''' units or against time.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotWaveforms&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[], AnalogWaveformPlotOptions)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotWaveforms_GenericAnalogWaveformArray_AnalogWaveformPlotOptions()
        ' The following example demonstrates plotting multiple AnalogWaveforms to 
        ' a WaveformGraph object.
        Dim waveforms As AnalogWaveform(Of Double)() = Nothing
        Dim plotOptions As New AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw)

        GetRandomWaveformData(waveforms, 3)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotWaveform Then
            wvfmGraph.ClearData()
        End If
        wvfmGraph.PlotWaveforms(Of Double)(waveforms, plotOptions)
    End Sub

    ''' <summary>
    ''' Plots an array of AnalogWaveform&lt;TData&gt; data by appending the waveforms to the 
    ''' existing data. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotWaveformsAppend&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[])</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotWaveformsAppend_GenericAnalogWaveformArray()
        ' The following example demonstrates appending multiple AnalogWaveforms to 
        ' existing WaveformGraph plots.
        Dim waveforms As AnalogWaveform(Of Double)() = Nothing

        GetRandomWaveformData(waveforms, 3)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotWaveform Then
            wvfmGraph.ClearData()
        End If
        Try
            wvfmGraph.PlotWaveformsAppend(Of Double)(waveforms)
        Catch ioe As InvalidOperationException
            wvfmGraph.ClearData()
            Debug.WriteLine(String.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}", Environment.NewLine, ioe.Message))
            wvfmGraph.PlotWaveformsAppend(Of Double)(waveforms)
        End Try
    End Sub

    ''' <summary>
    ''' Plots a 2D array of AnalogWaveform&lt;TData&gt; data against the waveform sample units
    ''' or against time.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotWaveformsMultiple&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[,], AnalogWaveformPlotOptions)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotWaveformsMultiple_GenericAnalogWaveform2DArray_AnalogWaveformPlotOptions()
        ' The following example demonstrates plotting multiple AnalogWaveforms to 
        ' a WaveformGraph object.
        Dim waveforms As AnalogWaveform(Of Double)(,) = Nothing
        Dim plotOptions As New AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw)

        GetRandomWaveformData(waveforms, 2)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotWaveform Then
            wvfmGraph.ClearData()
        End If
        wvfmGraph.PlotWaveformsMultiple(Of Double)(waveforms, plotOptions)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of AnalogWaveform&lt;TData&gt; data by appending the waveforms against
    ''' the existing data. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotWaveformsAppendMultiple&lt;TData&gt;(AnalogWaveform&lt;TData&gt;[,])</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotWaveformsAppendMultiple_GenericAnalogWaveform2DArray()
        ' The following example demonstrates appending multiple AnalogWaveforms to 
        ' existing WaveformGraph plots.
        Dim waveforms As AnalogWaveform(Of Double)(,) = Nothing

        GetRandomWaveformData(waveforms, 2)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotWaveform Then
            wvfmGraph.ClearData()
        End If
        Try
            wvfmGraph.PlotWaveformsAppendMultiple(Of Double)(waveforms)
        Catch ioe As InvalidOperationException
            wvfmGraph.ClearData()
            Debug.WriteLine(String.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}", Environment.NewLine, ioe.Message))
            wvfmGraph.PlotWaveformsAppendMultiple(Of Double)(waveforms)
        End Try
    End Sub

    ''' <summary>
    ''' Plots ComplexWaveform&lt;TData&gt; data using the specified plot options.  
    ''' It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotComplexWaveform&lt;TData&gt;(ComplexWaveform&lt;TData&gt;, ComplexWaveformPlotOptions)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotComplexWaveform_GenericComplexWaveform_ComplexWaveformPlotOptions()
        ' The following example demonstrates plotting a ComplexWaveform to 
        ' a WaveformGraph object.
        Dim waveform As ComplexWaveform(Of ComplexDouble) = Nothing
        Dim options As New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Raw, ComplexDataPart.Real)

        GetRandomComplexWaveformData(waveform)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotComplexWaveform Then
            wvfmGraph.ClearData()
        End If
        wvfmGraph.PlotComplexWaveform(Of ComplexDouble)(waveform, options)
    End Sub

    ''' <summary>
    ''' Plots ComplexWaveform&lt;TData&gt; data by appending the waveform to the 
    ''' existing data.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotComplexWaveformAppend&lt;TData&gt;(ComplexWaveform&lt;TData&gt;)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotComplexWaveformAppend_GenericComplexWaveform()
        ' The following example demonstrates appending a ComplexWaveform to 
        ' an existing WaveformGraph plot.
        Dim waveform As ComplexWaveform(Of ComplexDouble) = Nothing

        GetRandomComplexWaveformData(waveform)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotComplexWaveform Then
            wvfmGraph.ClearData()
        End If

        Try
            wvfmGraph.PlotComplexWaveformAppend(Of ComplexDouble)(waveform)
        Catch ioe As InvalidOperationException
            wvfmGraph.ClearData()
            Debug.WriteLine(String.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}", Environment.NewLine, ioe.Message))
            wvfmGraph.PlotComplexWaveformAppend(Of ComplexDouble)(waveform)
        End Try
    End Sub

    ''' <summary>
    ''' Plots a 1D array of ComplexWaveform&lt;TData&gt; data using the specified 
    ''' plot options.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotComplexWaveforms&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[], ComplexWaveformPlotOptions)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotComplexWaveforms_GenericComplexWaveformArray_ComplexWaveformPlotOptions()
        ' The following example demonstrates plotting multiple ComplexWaveforms to 
        ' a WaveformGraph object.
        Dim waveforms As ComplexWaveform(Of ComplexDouble)() = Nothing
        Dim options As New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Raw, ComplexDataPart.Real)

        GetRandomComplexWaveformData(waveforms, 2)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotComplexWaveform Then
            wvfmGraph.ClearData()
        End If
        wvfmGraph.PlotComplexWaveforms(Of ComplexDouble)(waveforms, options)
    End Sub

    ''' <summary>
    ''' Plots an array of ComplexWaveform&lt;TData&gt; data by appending the waveforms 
    ''' to the existing data.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotComplexWaveformsAppend&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[])</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotComplexWaveformsAppend_GenericComplexWaveformArray()
        ' The following example demonstrates appending multiple ComplexWaveforms to 
        ' existing WaveformGraph plots.
        Dim waveforms As ComplexWaveform(Of ComplexDouble)() = Nothing

        GetRandomComplexWaveformData(waveforms, 2)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotComplexWaveform Then
            wvfmGraph.ClearData()
        End If
        Try
            wvfmGraph.PlotComplexWaveformsAppend(Of ComplexDouble)(waveforms)
        Catch ioe As InvalidOperationException
            wvfmGraph.ClearData()
            Debug.WriteLine(String.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}", Environment.NewLine, ioe.Message))
            wvfmGraph.PlotComplexWaveformsAppend(Of ComplexDouble)(waveforms)
        End Try
    End Sub

    ''' <summary>
    ''' Plots a 2D array of ComplexWaveform&lt;TData&gt; data using the specified plot 
    ''' options.  It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotComplexWaveformsMultiple&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[,], ComplexWaveformPlotOptions)</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotComplexWaveformsMultiple_GenericComplexWaveform2DArray_ComplexWaveformPlotOptions()
        ' The following example demonstrates plotting multiple ComplexWaveforms to 
        ' a WaveformGraph object.
        Dim waveforms As ComplexWaveform(Of ComplexDouble)(,) = Nothing
        Dim options As New ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, ComplexWaveformPlotScaleMode.Raw, ComplexDataPart.Real)

        GetRandomComplexWaveformData(waveforms, 2)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotComplexWaveform Then
            wvfmGraph.ClearData()
        End If
        wvfmGraph.PlotComplexWaveformsMultiple(Of ComplexDouble)(waveforms, options)
    End Sub

    ''' <summary>
    ''' Plots a 2D array of ComplexWaveform&lt;TData&gt; data by appending the 
    ''' waveforms against the existing data. It is implemented in the WaveformGraph class. 
    ''' </summary>
    ''' <signature>PlotComplexWaveformsAppendMultiple&lt;TData&gt;(ComplexWaveform&lt;TData&gt;[,])</signature>
    ''' <ExampleMethod />
    Public Sub GenericPlotComplexWaveformsAppendMultiple_GenericComplexWaveform2DArray()
        ' The following example demonstrates appending multiple ComplexWaveforms to 
        ' existing WaveformGraph plots.
        Dim waveforms As ComplexWaveform(Of ComplexDouble)(,) = Nothing

        GetRandomComplexWaveformData(waveforms, 2)

        ' Set the X-Axis to display time
        wvfmGraph.XAxes(0).MajorDivisions.LabelFormat = timeFormatString
        ' Set the Y-Axis to display samples
        wvfmGraph.YAxes(0).MajorDivisions.LabelFormat = samplesFormatString

        If wvfmGraph.Plots(0).Mode <> WaveformPlotMode.PlotComplexWaveform Then
            wvfmGraph.ClearData()
        End If
        Try
            wvfmGraph.PlotComplexWaveformsAppendMultiple(Of ComplexDouble)(waveforms)
        Catch ioe As InvalidOperationException
            wvfmGraph.ClearData()
            Debug.WriteLine(String.Format("Graph was cleared because InvalidOperationException occured.  Msg is: {0}{1}", Environment.NewLine, ioe.Message))
            wvfmGraph.PlotComplexWaveformsAppendMultiple(Of ComplexDouble)(waveforms)
        End Try
    End Sub
#End Region

#Region "helper methods for the SnipsWaveformGraph class"

    Private Sub wvfmGraph_AfterDrawPlotArea(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        If TypeOf sender Is WaveformGraph Then
            Dim graph As WaveformGraph = DirectCast(sender, WaveformGraph)
            Dim legendItems As New List(Of SnipsLegendItem)(graph.Plots.Count)
            For Each plot As WaveformPlot In graph.Plots
                Dim item As New SnipsLegendItem(plot, plot.ToString(), plot.GetYData().Length > 0)
                legendItems.Add(item)
            Next
            MainForm.Legend.SetItems(legendItems)
        End If
    End Sub

    Private Sub wvfmGraph_PlotsChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If TypeOf sender Is WaveformGraph Then
            Dim graph As WaveformGraph = DirectCast(sender, WaveformGraph)
            For Each plot As WaveformPlot In graph.Plots
                plot.PointStyle = PointStyle.Cross
                plot.PointColor = Color.GhostWhite
            Next
        End If
    End Sub

    ''' <summary>
    ''' Reset the graph to it's default state.  This is done by
    ''' clearing the data, and then re-plotting the sample data.
    ''' </summary>
    Public Overrides Sub ResetToDefaultState()
        MyBase.ResetToDefaultState()
        PlotY_doubleArray()
    End Sub

    Private Sub GetRandomWaveformData(ByRef waveform As AnalogWaveform(Of Double))
        Dim wvfrm As AnalogWaveform(Of Double)
        Dim data As Double() = New Double(49) {}
        Dim times As DateTime() = New DateTime(data.Length - 1) {}
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To data.Length - 1
            data(i) = amp * Math.Sin(2 * i * Math.PI / data.Length) + amp
            times(i) = DateTime.Now.AddSeconds(RandNumberGenerator.NextDouble() + i)
        Next

        wvfrm = AnalogWaveform(Of Double).FromArray1D(data)
        wvfrm.Timing = WaveformTiming.CreateWithIrregularInterval(times)
        waveform = wvfrm
    End Sub

    Private Sub GetRandomWaveformData(ByRef waveformArray As AnalogWaveform(Of Double)(), ByVal numPlots As Integer)
        Dim wvfrmArray As AnalogWaveform(Of Double)() = New AnalogWaveform(Of Double)(numPlots - 1) {}
        Dim data As Double(,) = New Double(2, 49) {}
        Dim secondsOffset As Double
        Dim amp As Double = RandNumberGenerator.NextDouble() * 10
        Dim increment As TimeSpan = TimeSpan.FromSeconds(1.0)
        Dim stamp As DateTime = DateTime.Now

        For row As Integer = 0 To data.GetLength(0) - 1
            For col As Integer = 0 To data.GetLength(1) - 1
                data(row, col) = amp * Math.Sin(2 * col * Math.PI / data.GetLength(1)) + amp
            Next
        Next

        wvfrmArray = AnalogWaveform(Of Double).FromArray2D(data)

        For i As Integer = 0 To wvfrmArray.Length - 1
            secondsOffset = If(i > 0, increment.Seconds * wvfrmArray(i - 1).SampleCount * i, 0)
            stamp = DateTime.Now.AddSeconds(secondsOffset)
            wvfrmArray(i).Timing = WaveformTiming.CreateWithRegularInterval(increment, stamp)
        Next
        waveformArray = wvfrmArray
    End Sub

    Private Sub GetRandomWaveformData(ByRef waveformArray As AnalogWaveform(Of Double)(,), ByVal numPlots As Integer)
        Dim wvfrmArray As AnalogWaveform(Of Double)(,) = New AnalogWaveform(Of Double)(numPlots - 1, 2) {}
        Dim wvfrms As AnalogWaveform(Of Double)() = Nothing

        For plot As Integer = 0 To numPlots - 1
            GetRandomWaveformData(wvfrms, wvfrmArray.GetLength(1))
            For col As Integer = 0 To wvfrmArray.GetLength(1) - 1
                wvfrmArray(plot, col) = wvfrms(col)
            Next
        Next
        waveformArray = wvfrmArray
    End Sub

    Private Sub GetRandomComplexWaveformData(ByRef waveform As ComplexWaveform(Of ComplexDouble))
        Dim wvfrm As ComplexWaveform(Of ComplexDouble)
        Dim data As ComplexDouble() = New ComplexDouble(99) {}
        Dim stamp As New PrecisionDateTime(DateTime.Now)
        Dim increment As New PrecisionTimeSpan(TimeSpan.FromSeconds(2.0))
        Dim realAmp As Double = RandNumberGenerator.NextDouble() * 10
        Dim imaginaryAmp As Double = RandNumberGenerator.NextDouble() * 10

        For i As Integer = 0 To data.Length - 1
            data(i).Real = realAmp * Math.Sin(2 * i * Math.PI / data.Length) + realAmp
            data(i).Imaginary = imaginaryAmp * Math.Sin(2 * i * Math.PI / data.Length) + imaginaryAmp
        Next

        wvfrm = ComplexWaveform(Of ComplexDouble).FromArray1D(data)
        wvfrm.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(increment, stamp)

        waveform = wvfrm
    End Sub

    Private Sub GetRandomComplexWaveformData(ByRef waveforms As ComplexWaveform(Of ComplexDouble)(), ByVal numPlots As Integer)
        Dim secondsOffset As Double
        Dim wvfrms As ComplexWaveform(Of ComplexDouble)() = New ComplexWaveform(Of ComplexDouble)(numPlots - 1) {}
        Dim increment As New PrecisionTimeSpan(TimeSpan.FromSeconds(2.0))
        Dim stamp As PrecisionDateTime

        For i As Integer = 0 To wvfrms.Length - 1
            GetRandomComplexWaveformData(wvfrms(i))
            secondsOffset = If(i > 0, increment.Seconds * wvfrms(i - 1).SampleCount * i, 0)
            stamp = New PrecisionDateTime(DateTime.Now.AddSeconds(secondsOffset))
            wvfrms(i).PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(increment, stamp)
        Next
        waveforms = wvfrms
    End Sub

    Private Sub GetRandomComplexWaveformData(ByRef waveforms As ComplexWaveform(Of ComplexDouble)(,), ByVal numPlots As Integer)
        Dim wvfrmArray As ComplexWaveform(Of ComplexDouble)(,) = New ComplexWaveform(Of ComplexDouble)(numPlots - 1, 2) {}
        Dim wvfrms As ComplexWaveform(Of ComplexDouble)() = Nothing

        For plot As Integer = 0 To numPlots - 1
            GetRandomComplexWaveformData(wvfrms, wvfrmArray.GetLength(1))
            For col As Integer = 0 To wvfrmArray.GetLength(1) - 1
                wvfrmArray(plot, col) = wvfrms(col)
            Next
        Next
        waveforms = wvfrmArray
    End Sub
#End Region
End Class