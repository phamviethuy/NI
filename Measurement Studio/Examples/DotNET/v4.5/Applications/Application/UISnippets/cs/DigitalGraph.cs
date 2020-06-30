using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System.Globalization;

namespace NationalInstruments.Examples.Snippets
{
    sealed class SnipsDigitalGraph : SnipsGraph
    {
        private DigitalWaveformGraph digiGraph;
        private int chanNum = 0;

        /// <summary>
        /// Creates a new digital waveform graph object for use in this 
        /// code snippets example
        /// </summary>
        /// <param name="digitalGraph">The DigitalWaveformGraph to be used internally</param>
        public SnipsDigitalGraph(DigitalWaveformGraph digitalGraph)
            : base(digitalGraph)
        {
            digiGraph = digitalGraph;
            digiGraph.PlotLabelMode = new SnipsLabelMode();            
            digiGraph.AfterDrawPlotArea += new AfterDrawEventHandler(digiGraph_AfterDrawPlotArea);
            ResetToDefaultState();
        }

        #region Code Snippets for NationalInstruments.UI.WindowsForms.DigitalGraph

        /// <summary>
        /// Plots a DigitalWaveform. It is implemented
        /// in the DigitalWaveformGraph class.
        /// </summary>
        /// <signature>PlotWaveform(DigitalWaveform)</signature>
        /// <ExampleMethod />
        public void PlotWaveform_DigitalWaveform()
        {
            // The following example demonstrates plotting a digital waveform
            // to a DigitalWaveformGraph object.
            DigitalWaveform wave;

            // get some DigitalWaveform data
            GenerateRandomDigitalWaveformData(out wave);
            digiGraph.PlotWaveform(wave);
        }

        /// <summary>
        /// Plots a DigitalWaveform with the choice to copy the digital waveform. It is
        /// implemented in the DigitalWaveformGraph class.
        /// </summary>
        /// <signature>PlotWaveform(DigitalWaveform, bool)</signature>
        /// <ExampleMethod />
        public void PlotWaveform_DigitalWaveform_bool()
        {
            // The following example demonstrates plotting a digital waveform
            // to a DigitalWaveformGraph object, and electing to create a copy
            // of the DigitalWaveform object for the purpose of plotting.
            DigitalWaveform wave;

            // get some DigitalWaveform data
            GenerateRandomDigitalWaveformData(out wave);
            //Passing value of true copies the wave array when plotted. 
            digiGraph.PlotWaveform(wave, true);
        }

        /// <summary>
        /// Plots a DigitalWaveform array. It is implemented
        /// in the DigitalWaveformGraph class.
        /// </summary>
        /// <signature>PlotWaveforms(DigitalWaveform[])</signature>
        /// <ExampleMethod />
        public void PlotWaveforms_DigitalWaveformArray()
        {
            // The following example demonstrates plotting an array of DigitalWaveforms
            // to a DigitalWaveformGraph object.
            DigitalWaveform[] waves;

            // get some DigitalWaveform data
            GenerateRandomDigitalWaveformData(out waves);
            digiGraph.PlotWaveforms(waves);
        }

        /// <summary>
        /// Plots a DigitalWaveform array with the choice to copy the digital 
        /// waveform. It is implemented in the DigitalWaveformGraph class.
        /// </summary>
        /// <signature>PlotWaveforms(DigitalWaveform[], bool)</signature>
        /// <ExampleMethod />
        public void PlotWaveforms_DigitalWaveformArray_bool()
        {
            // The following example demonstrates plotting an array of DigitalWaveforms
            // to a DigitalWaveformGraph object and electing to create a copy of the 
            // DigitalWaveformObject objects for the purpose of plotting.
            DigitalWaveform[] waves;

            // get some DigitalWaveform data
            GenerateRandomDigitalWaveformData(out waves);
            //Passing value of true copies the wave array when plotted. 
            digiGraph.PlotWaveforms(waves, true);
        }

        /// <summary>
        /// Returns a DigitalWaveform array containing DigitalWaveform references. 
        /// It is implemented in the DigitalWaveformGraph class. 
        /// </summary>
        /// <signature>GetWaveforms()</signature>
        /// <ExampleMethod />        
        public void GetWaveforms()
        {
            // The following example demonstrates getting all the DigitalWaveform
            // objects associated with a DigitalWaveformGraph object, and printing
            // the states of each waveform to debug output.
            DigitalWaveform[] waves;

            waves = digiGraph.GetWaveforms();

            foreach (DigitalWaveform wave in waves)
            {
                Debug.WriteLine(wave.ChannelName + ": ");
                foreach (DigitalWaveformSignal signal in wave.Signals)
                {
                    int i = 0;
                    Debug.Write("\t" + signal.Name + ": ");
                    foreach (DigitalState state in signal.States)
                    {
                        if ((i % 10) != 0)
                            Debug.Write(state.ToString() + " ");
                        else
                            Debug.Write(Environment.NewLine + "\t\t" + state.ToString() + " ");
                        i++;
                    }
                    Debug.Write(Environment.NewLine);
                }
            }
        }

        /// <summary>
        /// Collapses all digital signals on each digital waveform plot. 
        /// It is implemented in the DigitalGraph class.
        /// </summary>
        /// <signature>CollapseSignals()</signature>
        /// <ExampleMethod />
        public void CollapseSignals()
        {
            digiGraph.CollapseSignals();
        }

        /// <summary>
        /// Returns a DigitalWaveformGraphHitTestInfo that specifies where on the control the 
        /// given point is located.  It is implemented in the DigitalWavformGraph class. To 
        /// run this method, you must first click the run snippet button, and then click 
        /// somewhere inside the graph area. 
        /// </summary>
        /// <signature>HitTest(int, int)</signature>
        /// <OtherMethods>
        /// DigitalWaveformGraph.GetSignalPlotAt(int, int, out DigitalState, out int, out int, out int)
        /// DigitalWaveformGraph.GetWaveformPlotAt(int, int, out DigitalWaveformSample, out int, out int)
        /// </OtherMethods>
        /// <ExampleMethod />
        [EventBased("MouseDown")]
        public void DigitalGraph_HitTest_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates using the HitTest method to determine
            // where a user clicked on a DigitalWaveformGraph object.
            DigitalWaveformGraphHitTestInfo hitTestRegion;
            int waveformIndex, sampleIndex, signalIndex;
            Color randomColor = Color.FromArgb(RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            hitTestRegion = digiGraph.HitTest(e.X, e.Y);

            switch (hitTestRegion)
            {
                case DigitalWaveformGraphHitTestInfo.HorizontalScrollBar:
                    Debug.WriteLine("Horizontal scrollbar selected");
                    break;
                case DigitalWaveformGraphHitTestInfo.PlotArea:
                    Debug.WriteLine("Plot area selected");
                    break;
                case DigitalWaveformGraphHitTestInfo.SignalPlot:
                    DigitalSignalPlot signalPlot;
                    DigitalState theState;

                    signalPlot = digiGraph.GetSignalPlotAt(e.X, e.Y, out theState, out waveformIndex,
                                                            out sampleIndex, out signalIndex);
                    signalPlot.LineColor = randomColor;
                    Debug.WriteLine("Signal plot selected");
                    Debug.WriteLine(string.Format("Sample {0} in signal {1} of waveform {2} has state {3}",
                                                    sampleIndex, signalIndex, waveformIndex, theState.ToString()));
                    break;
                case DigitalWaveformGraphHitTestInfo.VerticalScrollBar:
                    Debug.WriteLine("Vertical scrollbar selected");
                    break;
                case DigitalWaveformGraphHitTestInfo.WaveformPlot:
                    DigitalWaveformSample sample;
                    DigitalWaveformPlot plot;
                    List<string> states = new List<string>(10);

                    plot = digiGraph.GetWaveformPlotAt(e.X, e.Y, out sample, out waveformIndex, out sampleIndex);
                    plot.LineColor = randomColor;
                    foreach (DigitalState state in sample.States)
                        states.Add(state.ToString());
                    Debug.WriteLine("Waveform plot selected");
                    Debug.WriteLine(string.Format("Waveform {0}'s sample number {1} has states {2}",
                                    waveformIndex, sampleIndex, string.Join(" ", states.ToArray<string>())));
                    break;
                case DigitalWaveformGraphHitTestInfo.XAxis:
                    digiGraph.XAxis.CaptionBackColor = randomColor;
                    Debug.WriteLine("XAxis selected");
                    Debug.WriteLine(string.Format("X Axis range minimum is {0}, XAxis range maximum is {1}",
                                                    digiGraph.XAxis.Range.Minimum, digiGraph.XAxis.Range.Maximum));
                    break;
                case DigitalWaveformGraphHitTestInfo.YAxis:
                    Debug.WriteLine("YAxis selected");
                    Debug.WriteLine(string.Format("The major divisions grid is {0}visible{1}The minor divisions grid is {2}visible",
                                                    digiGraph.YAxis.MajorGridVisible ? "" : "not ",
                                                    Environment.NewLine,
                                                    digiGraph.YAxis.MinorGridVisible ? "" : "not "));
                    break;
            }
        }

        #endregion

        #region helper methods and classes for the SnipsDigitalGraph class

        void digiGraph_AfterDrawPlotArea(object sender, AfterDrawEventArgs e)
        {
            DigitalWaveformGraph graph = sender as DigitalWaveformGraph;
            if (graph != null)
            {
                List<SnipsLegendItem> legendItems = new List<SnipsLegendItem>(graph.Plots.Count);
                DigitalWaveform[] waves = graph.GetWaveforms();
                foreach (DigitalWaveformPlot plot in graph.Plots)
                {
                    try
                    {
                        DigitalWaveformPlot tempPlot = plot;
                        DigitalWaveform wave = waves.First<DigitalWaveform>(w => tempPlot.Label.Equals(w.ChannelName));
                        SnipsLegendItem item = new SnipsLegendItem(plot, wave.ChannelName, wave.Samples.Count > 0);
                        legendItems.Add(item);
                    }
                    catch (InvalidOperationException) { }
                }
                MainForm.Legend.SetItems(legendItems);
            }
        }

        /// <summary>
        /// Reset the graph to it's default state.  This is done by
        /// clearing the data, and then re-plotting the sample data.
        /// </summary>
        public override void ResetToDefaultState()
        {
            base.ResetToDefaultState();
            PlotWaveforms_DigitalWaveformArray();
        }

        private void GenerateRandomDigitalWaveformData(out DigitalWaveform waveform)
        {
            double randValue;
            DigitalState state;
            DigitalWaveform wvForm = new DigitalWaveform(40, 3);

            // generate some random data
            for (int sig = 0; sig < wvForm.Signals.Count; sig++)
                for (int samp = 0; samp < wvForm.Samples.Count; samp++)
                {
                    randValue = RandNumberGenerator.NextDouble();
                    if (randValue < .4875)
                        state = DigitalState.ForceUp;
                    else if (randValue < .975)
                        state = DigitalState.ForceDown;
                    else if (randValue < .9875)
                        state = DigitalState.ForceOff;
                    else
                        state = DigitalState.CompareUnknown;

                    wvForm.Signals[sig].States[samp] = state;
                    wvForm.Signals[sig].Name = "Signal " + sig.ToString(CultureInfo.CurrentCulture);
                }
            wvForm.ChannelName = "Channel " + chanNum.ToString(CultureInfo.CurrentCulture);
            chanNum++;
            waveform = wvForm;
        }

        private void GenerateRandomDigitalWaveformData(out DigitalWaveform[] waveforms)
        {
            DigitalWaveform[] wvForms = new DigitalWaveform[4];

            // generate some random data
            for (int i = 0; i < wvForms.Length; i++)
            {
                GenerateRandomDigitalWaveformData(out wvForms[i]);
            }
            waveforms = wvForms;
        }

        private class SnipsLabelMode : DigitalPlotLabelMode
        {
            public override string GetSignalPlotLabel(object context, DigitalPlotLabelModeArgs args)
            {
                return args.Waveform.Signals[args.SignalIndex].Name;
            }

            public override string GetWaveformPlotLabel(object context, DigitalPlotLabelModeArgs args)
            {
                DigitalWaveformGraph graph = context as DigitalWaveformGraph;
                if (graph != null)
                {
                    graph.Plots[args.WaveformIndex].Label = args.Waveform.ChannelName;
                }
                return args.Waveform.ChannelName;
            }
        }
        #endregion
    }
}
