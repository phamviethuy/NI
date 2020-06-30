Imports System.Globalization
Imports NationalInstruments.UI.WindowsForms

NotInheritable Class SnipsDigitalGraph
    Inherits SnipsGraph
    Private digiGraph As DigitalWaveformGraph
    Private chanNum As Integer

    ''' <summary>
    ''' Creates a new digital waveform graph object for use in this 
    ''' code snippets example
    ''' </summary>
    ''' <param name="digitalGraph">The DigitalWaveformGraph to be used Integerernally</param>
    Public Sub New(ByVal digitalGraph As DigitalWaveformGraph)
        MyBase.New(digitalGraph)
        digiGraph = digitalGraph
        digiGraph.PlotLabelMode = New SnipsLabelMode()
        AddHandler digiGraph.AfterDrawPlotArea, AddressOf digiGraph_AfterDrawPlotArea
        ResetToDefaultState()
    End Sub

#Region "Code Snippets for NationalInstruments.UI.WindowsForms.DigitalGraph"

    ''' <summary>
    ''' Plots a DigitalWaveform. It is implemented
    ''' in the DigitalWaveformGraph class.
    ''' </summary>
    ''' <signature>PlotWaveform(DigitalWaveform)</signature>
    ''' <ExampleMethod />
    Public Sub PlotWaveform_DigitalWaveform()
        ' The following example demonstrates plotting a digital waveform
        ' to a DigitalWaveformGraph object.
        Dim wave As DigitalWaveform = Nothing

        ' get some DigitalWaveform data
        GenerateRandomDigitalWaveformData(wave)
        digiGraph.PlotWaveform(wave)
    End Sub

    ''' <summary>
    ''' Plots a DigitalWaveform with the choice to copy the digital waveform. It is
    ''' implemented in the DigitalWaveformGraph class.
    ''' </summary>
    ''' <signature>PlotWaveform(DigitalWaveform, bool)</signature>
    ''' <ExampleMethod />
    Public Sub PlotWaveform_DigitalWaveform_bool()
        ' The following example demonstrates plotting a digital waveform
        ' to a DigitalWaveformGraph object, and electing to create a copy
        ' of the DigitalWaveform object for the purpose of plotting.
        Dim wave As DigitalWaveform = Nothing

        ' get some DigitalWaveform data
        GenerateRandomDigitalWaveformData(wave)
        'Passing value of true copies the wave array when plotted. 
        digiGraph.PlotWaveform(wave, True)
    End Sub

    ''' <summary>
    ''' Plots a DigitalWaveform array. It is implemented
    ''' in the DigitalWaveformGraph class.
    ''' </summary>
    ''' <signature>PlotWaveforms(DigitalWaveform[])</signature>
    ''' <ExampleMethod />
    Public Sub PlotWaveforms_DigitalWaveformArray()
        ' The following example demonstrates plotting an array of DigitalWaveforms
        ' to a DigitalWaveformGraph object.
        Dim waves As DigitalWaveform() = Nothing

        ' get some DigitalWaveform data
        GenerateRandomDigitalWaveformData(waves)
        digiGraph.PlotWaveforms(waves)
    End Sub

    ''' <summary>
    ''' Plots a DigitalWaveform array with the choice to copy the digital 
    ''' waveform. It is implemented in the DigitalWaveformGraph class.
    ''' </summary>
    ''' <signature>PlotWaveforms(DigitalWaveform[], bool)</signature>
    ''' <ExampleMethod />
    Public Sub PlotWaveforms_DigitalWaveformArray_bool()
        ' The following example demonstrates plotting an array of DigitalWaveforms
        ' to a DigitalWaveformGraph object and electing to create a copy of the 
        ' DigitalWaveformObject objects for the purpose of plotting.
        Dim waves As DigitalWaveform() = Nothing

        ' get some DigitalWaveform data
        GenerateRandomDigitalWaveformData(waves)
        'Passing value of true copies the wave array when plotted. 
        digiGraph.PlotWaveforms(waves, True)
    End Sub

    ''' <summary>
    ''' Returns a DigitalWaveform array containing DigitalWaveform references. 
    ''' It is implemented in the DigitalWaveformGraph class. 
    ''' </summary>
    ''' <signature>GetWaveforms()</signature>
    ''' <ExampleMethod />        
    Public Sub GetWaveforms()
        ' The following example demonstrates getting all the DigitalWaveform
        ' objects associated with a DigitalWaveformGraph object, and printing
        ' the states of each waveform to debug output.
        Dim waves As DigitalWaveform()

        waves = digiGraph.GetWaveforms()

        For Each wave As DigitalWaveform In waves
            Debug.WriteLine(wave.ChannelName + ": ")
            For Each signal As DigitalWaveformSignal In wave.Signals
                Dim i As Integer = 0
                Debug.Write(vbTab + signal.Name & ": ")
                For Each state As DigitalState In signal.States
                    If (i Mod 10) <> 0 Then
                        Debug.Write(state.ToString() & " ")
                    Else
                        Debug.Write(Environment.NewLine & vbTab & vbTab & state.ToString() & " ")
                    End If
                    i += 1
                Next
                Debug.Write(Environment.NewLine)
            Next
        Next
    End Sub

    ''' <summary>
    ''' Collapses all digital signals on each digital waveform plot. 
    ''' It is implemented in the DigitalGraph class.
    ''' </summary>
    ''' <signature>CollapseSignals()</signature>
    ''' <ExampleMethod />
    Public Sub CollapseSignals()
        digiGraph.CollapseSignals()
    End Sub

    ''' <summary>
    ''' Returns a DigitalWaveformGraphHitTestInfo that specifies where on the control the 
    ''' given point is located.  It is implemented in the DigitalWavformGraph class. To 
    ''' run this method, you must first click the run snippet button, and then click 
    ''' somewhere inside the graph area. 
    ''' </summary>
    ''' <signature>HitTest(Integer, Integer)</signature>
    ''' <OtherMethods>
    ''' DigitalWaveformGraph.GetSignalPlotAt(Integer, Integer, out DigitalState, out Integer, out Integer, out Integer)
    ''' DigitalWaveformGraph.GetWaveformPlotAt(Integer, Integer, out DigitalWaveformSample, out Integer, out Integer)
    ''' </OtherMethods>
    ''' <ExampleMethod />
    <EventBased("MouseDown")> _
    Public Sub DigitalGraph_HitTest_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates using the HitTest method to determine
        ' where a user clicked on a DigitalWaveformGraph object.
        Dim hitTestRegion As DigitalWaveformGraphHitTestInfo
        Dim waveformIndex As Integer, sampleIndex As Integer, signalIndex As Integer
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        hitTestRegion = digiGraph.HitTest(e.X, e.Y)

        Select Case hitTestRegion
            Case DigitalWaveformGraphHitTestInfo.HorizontalScrollBar
                Debug.WriteLine("Horizontal scrollbar selected")
                Exit Select
            Case DigitalWaveformGraphHitTestInfo.PlotArea
                Debug.WriteLine("Plot area selected")
                Exit Select
            Case DigitalWaveformGraphHitTestInfo.SignalPlot
                Dim signalPlot As DigitalSignalPlot
                Dim theState As DigitalState

                signalPlot = digiGraph.GetSignalPlotAt(e.X, e.Y, theState, waveformIndex, sampleIndex, signalIndex)
                signalPlot.LineColor = randomColor
                Debug.WriteLine("Signal plot selected")
                Debug.WriteLine(String.Format("Sample {0} in signal {1} of waveform {2} has state {3}", sampleIndex, signalIndex, waveformIndex, theState.ToString()))
                Exit Select
            Case DigitalWaveformGraphHitTestInfo.VerticalScrollBar
                Debug.WriteLine("Vertical scrollbar selected")
                Exit Select
            Case DigitalWaveformGraphHitTestInfo.WaveformPlot
                Dim sample As DigitalWaveformSample = Nothing
                Dim plot As DigitalWaveformPlot
                Dim states As New List(Of String)(10)

                plot = digiGraph.GetWaveformPlotAt(e.X, e.Y, sample, waveformIndex, sampleIndex)
                plot.LineColor = randomColor
                For Each state As DigitalState In sample.States
                    states.Add(state.ToString())
                Next
                Debug.WriteLine("Waveform plot selected")
                Debug.WriteLine(String.Format("Waveform {0}'s sample number {1} has states {2}", waveformIndex, sampleIndex, String.Join(" ", states.ToArray())))
                Exit Select
            Case DigitalWaveformGraphHitTestInfo.XAxis
                digiGraph.XAxis.CaptionBackColor = randomColor
                Debug.WriteLine("XAxis selected")
                Debug.WriteLine(String.Format("X Axis range minimum is {0}, XAxis range maximum is {1}", digiGraph.XAxis.Range.Minimum, digiGraph.XAxis.Range.Maximum))
                Exit Select
            Case DigitalWaveformGraphHitTestInfo.YAxis
                Debug.WriteLine("YAxis selected")
                Debug.WriteLine(String.Format("The major divisions grid is {0}visible{1}The minor divisions grid is {2}visible", If(digiGraph.YAxis.MajorGridVisible, "", "not "), Environment.NewLine, If(digiGraph.YAxis.MinorGridVisible, "", "not ")))
                Exit Select
        End Select
    End Sub

#End Region

#Region "helper methods and classes for the SnipsDigitalGraph class"

    Private Sub digiGraph_AfterDrawPlotArea(ByVal sender As Object, ByVal e As AfterDrawEventArgs)
        If TypeOf sender Is DigitalWaveformGraph Then
            Dim graph As DigitalWaveformGraph = DirectCast(sender, DigitalWaveformGraph)
            Dim legendItems As New List(Of SnipsLegendItem)(graph.Plots.Count)
            Dim waves As DigitalWaveform() = graph.GetWaveforms()
            For Each plot As DigitalWaveformPlot In graph.Plots
                Try
                    Dim tempPlot As DigitalWaveformPlot = plot
                    Dim wave As DigitalWaveform = waves.First(Function(w) tempPlot.Label.Equals(w.ChannelName))
                    Dim item As New SnipsLegendItem(plot, wave.ChannelName, wave.Samples.Count > 0)
                    legendItems.Add(item)
                Catch generatedExceptionName As InvalidOperationException
                End Try
            Next
            MainForm.Legend.SetItems(legendItems)
        End If
    End Sub

    ''' <summary>
    ''' Reset the graph to it's default state.  This is done by
    ''' clearing the data, and then re-plotting the sample data.
    ''' </summary>
    Public Overrides Sub ResetToDefaultState()
        MyBase.ResetToDefaultState()
        PlotWaveforms_DigitalWaveformArray()
    End Sub

    Private Sub GenerateRandomDigitalWaveformData(ByRef waveform As DigitalWaveform)
        Dim randValue As Double
        Dim state As DigitalState
        Dim wvfrm As New DigitalWaveform(40, 3)

        ' generate some random data
        For sig As Integer = 0 To wvfrm.Signals.Count - 1
            For samp As Integer = 0 To wvfrm.Samples.Count - 1
                randValue = RandNumberGenerator.NextDouble()
                If randValue < 0.4875 Then
                    state = DigitalState.ForceUp
                ElseIf randValue < 0.975 Then
                    state = DigitalState.ForceDown
                ElseIf randValue < 0.9875 Then
                    state = DigitalState.ForceOff
                Else
                    state = DigitalState.CompareUnknown
                End If

                wvfrm.Signals(sig).States(samp) = state
                wvfrm.Signals(sig).Name = "Signal " & sig.ToString(CultureInfo.CurrentCulture)
            Next
        Next
        wvfrm.ChannelName = "Channel " & chanNum.ToString(CultureInfo.CurrentCulture)
        chanNum += 1
        waveform = wvfrm
    End Sub

    Private Sub GenerateRandomDigitalWaveformData(ByRef waveforms As DigitalWaveform())
        Dim wvfrms As DigitalWaveform() = New DigitalWaveform(3) {}

        ' generate some random data
        For i As Integer = 0 To wvfrms.Length - 1
            GenerateRandomDigitalWaveformData(wvfrms(i))
        Next
        waveforms = wvfrms
    End Sub

    Private Class SnipsLabelMode
        Inherits DigitalPlotLabelMode
        Public Overrides Function GetSignalPlotLabel(ByVal context As Object, ByVal args As DigitalPlotLabelModeArgs) As String
            Return args.Waveform.Signals(args.SignalIndex).Name
        End Function

        Public Overrides Function GetWaveformPlotLabel(ByVal context As Object, ByVal args As DigitalPlotLabelModeArgs) As String
            If TypeOf context Is DigitalWaveformGraph Then
                Dim graph As DigitalWaveformGraph = DirectCast(context, DigitalWaveformGraph)
                graph.Plots(args.WaveformIndex).Label = args.Waveform.ChannelName
            End If
            Return args.Waveform.ChannelName
        End Function
    End Class
#End Region
End Class
