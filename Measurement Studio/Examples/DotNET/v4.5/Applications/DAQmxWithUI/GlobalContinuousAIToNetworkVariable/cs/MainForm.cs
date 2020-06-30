/*******************************************************************************
*
* Example program:
*   GlobalContinuousAIToNetworkVariable
*
* Description:
*   This example shows how to load a continuous analog input task from the Measurement & 
*   Automation Explorer (MAX) and use it to acquire and plot samples from a USB device.
*   The application also demonstrates publishing the data onto a NetworkVariable.
*
* Instructions for running:
*   1.  Create a continuous analog input NI-DAQmx global task in MAX. For help, refer to 
*       "Creating Tasks and Channels" in the Measurement & Automation Explorer Help. 
*       To access this help, select Start>>All Programs>>National Instruments>>
*       Measurement & Automation. In MAX, select Help>>MAX Help.
*
*       Note: If you prefer, you can import a continuous AI task and a simulated USB
*       device into MAX from the GlobalContinuousAIToNetworkVariable.nce file, which is 
*       located in the example directory. Refer to "Using the Configuration Import Wizard"
*       in the Measurement & Automation Explorer Help for more information.
* 
*   2.  Make sure that you have a NetworkVariable hosted where you can write to. The data
*       published by this application will  be an "Array of Double Waveform".
*       See "Creating Shared or Network Variables with the Variable Manager" in 
*       Help >> Variable Manager Help section in the Variable Manager application.
*
*   3.  Run the application, select the task from the drop-down list.
* 
*   4.  Select a NetworkVariable to publish to. You can type in the location of the variable
*       or click on the Browse button to browse to the Variable.
* 
*   5.  Click Start button to start acquiring the samples and publish them to the network variable
*
* Steps:
*   1.  Load the task from MAX.
*   2.  Read the data from all of the channels in the task.
*   3.  Stop reading data once the user clicks the "Stop" button.
*   4.  Initialize an array of colors so that if the task has more than one channel
*       then the corresponding plots can be distinguished on the graph. 
*       Assign color(s) to the plot(s) and create a legend.
*   5.  Plot the data on a waveform graph.
*   6.  Publish the data onto the NetworkVariable.
*******************************************************************************/

using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.NetworkVariable.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;

namespace NationalInstruments.Examples.GlobalContinuousAIToNetworkVariable
{
    public partial class MainForm : Form
    {

        private bool stoppedExecution = true;
        private Task runningTask;
        private Task continuousTask;
        private AnalogMultiChannelReader reader;
        private AsyncCallback daqReadCallBack;
        private NetworkVariableBufferedWriter<AnalogWaveform<double>[]> outputWriter = null;
        private AnalogWaveform<double>[] data;

        public MainForm()
        {
            InitializeComponent();

            startButton.Enabled = false;
            stopButton.Enabled = false;
            browseButton.Enabled = false;
            connectionStatusLed.Value = false;

            foreach (string taskName in DaqSystem.Local.Tasks)
            {
                try
                {
                    using (Task newTask = DaqSystem.Local.LoadTask(taskName))
                    {
                        newTask.Control(TaskAction.Verify);

                        if (newTask.AIChannels.Count > 0 &&
                            newTask.Timing.SampleQuantityMode == SampleQuantityMode.ContinuousSamples)
                        {
                            taskComboBox.Items.Add(taskName);
                        }
                    }
                }
                catch (DaqException)
                {
                    // Ignore invalid tasks
                }
            }

            if (taskComboBox.Items.Count > 0)
            {
                taskComboBox.SelectedIndex = 0;
                browseButton.Enabled = true;
                outputLocationTextBox.Text = string.Empty;
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (continuousTask != null)
                {
                    runningTask = null;
                    continuousTask.Dispose();
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (outputNetworkVariableBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                outputLocationTextBox.Text = outputNetworkVariableBrowserDialog.SelectedLocation;
                startButton.Enabled = true;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            channelLegend.Items.Clear();
            outputWaveformGraph.ClearData();
            outputWaveformGraph.Plots.Clear();
            stoppedExecution = false;
            try
            {
                string taskName = taskComboBox.SelectedItem.ToString();
                continuousTask = DaqSystem.Local.LoadTask(taskName);

                outputWriter = new NetworkVariableBufferedWriter<AnalogWaveform<double>[]>(outputLocationTextBox.Text);
                outputWriter.Connect();
                connectionStatusLed.Value = true;

                SetupUI();

                runningTask = continuousTask;
                reader = new AnalogMultiChannelReader(continuousTask.Stream);

                outputWriter.SynchronizeCallbacks = true;
                outputWriter.Connect(TimeSpan.FromSeconds(10));

                reader.SynchronizeCallbacks = true;
                daqReadCallBack = new AsyncCallback(ReadCallBack);
                reader.BeginReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), daqReadCallBack, continuousTask);

                stopButton.Enabled = true;
                startButton.Enabled = false;
                taskComboBox.Enabled = false;
                browseButton.Enabled = false;
            }
            catch (DaqException ex)
            {
                Stopped(ex.Message);
            }
            catch (NetworkVariableException ex)
            {
                Stopped(ex.Message);
            }
            catch (TimeoutException ex)
            {
                Stopped(ex.Message);
            }
        }

        public void ReadCallBack(IAsyncResult ar)
        {
            if (!stoppedExecution)
            {
                try
                {
                    if (runningTask != null && runningTask == ar.AsyncState)
                    {
                        data = reader.EndReadWaveform(ar);
                        outputWaveformGraph.PlotWaveformsAppend(data);

                        outputWriter.WriteData(new NetworkVariableData<AnalogWaveform<double>[]>(data));

                        reader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), daqReadCallBack, continuousTask, data);
                    }
                }
                catch (DaqException ex)
                {
                    Stopped(ex.Message);
                }
                catch (TimeoutException ex)
                {
                    Stopped(ex.Message);
                }
            }
        }

        private void SetupUI()
        {
            continuousTask.Control(TaskAction.Verify);
            int i = 0;
            foreach (AIChannel chan in continuousTask.AIChannels)
            {
                WaveformPlot plot = new WaveformPlot();
                outputWaveformGraph.Plots.Add(plot);
                channelLegend.Items.Add(new LegendItem(plot, chan.VirtualName + ": " + chan.PhysicalName));
                i++;
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            Stopped(null);
        }

        private void Stopped(string message)
        {
            stoppedExecution = true;
            try
            {
                if (continuousTask != null)
                {
                    continuousTask.Stop();
                    continuousTask.Dispose();
                }
            }
            catch (DaqException ex)
            {
                message = ex.Message;
            }

            try
            {
                if (outputWriter != null)
                {
                    outputWriter.Disconnect();
                }
            }
            catch (NetworkVariableException ex)
            {
                message = ex.Message;
            }

            if (message != null)
                MessageBox.Show(message);
            runningTask = null;
            continuousTask = null;
            outputWriter = null;

            startButton.Enabled = true;
            taskComboBox.Enabled = true;
            stopButton.Enabled = false;
            connectionStatusLed.Value = false;
        }
    }
}
