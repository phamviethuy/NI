/*******************************************************************************
*
* Example program:
*   GlobalContinuousAI_USB
*
* Description:
*   This example shows how to load a continuous analog input task from the Measurement & 
*   Automation Explorer (MAX) and use it to acquire and plot samples from a USB device.
*   This example should also work with E-Series and M-Series devices.
*
* Instructions for running:
*   1.  Create a continuous analog input NI-DAQmx global task in MAX. For help, refer to 
*       "Creating Tasks and Channels" in the Measurement & Automation Explorer Help. 
*       To access this help, select Start>>All Programs>>National Instruments>>
*       Measurement & Automation. In MAX, select Help>>MAX Help.
*
*       Note: If you prefer, you can import a continuous AI task and a simulated USB
*       device into MAX from the GlobalContinuousAI_USB.nce file, which is located in the 
*       example directory. Refer to "Using the Configuration Import Wizard" in the 
*       Measurement & Automation Explorer Help for more information.
*
*   2.  Run the application, select the task from the drop-down list, and click 
*       the Start button.
*
* Steps:
*   1.  Load the task from MAX.
*   2.  Read the data from all of the channels in the task.
*   3.  Stop reading data once the user clicks the "Stop" button.
*   4.  Initialize an array of colors so that if the task has more than one channel
*       then the corresponding plots can be distinguished on the graph. 
*       Assign color(s) to the plot(s) and create a legend.
*   5.  Plot the data on a waveform graph.
*******************************************************************************/

using NationalInstruments;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NationalInstruments.Examples.GlobalContinuousAI_USB
{
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ComboBox taskComboBox;
        private Task runningTask;
        private Task continuousTask;
        private AnalogMultiChannelReader reader;
        private AsyncCallback callBack;
        private System.Windows.Forms.GroupBox daqmxTaskGroupBox;
        private System.Windows.Forms.Label daqmxTaskLabel;
        private NationalInstruments.UI.WindowsForms.Legend channelLegend;
        private System.Windows.Forms.Label infoLabel;
        private NationalInstruments.UI.WindowsForms.WaveformGraph globalContinuousAIWaveformGraph;
        private AnalogWaveform<double>[] data;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            startButton.Enabled = false;
            stopButton.Enabled = false;

            foreach (string s in DaqSystem.Local.Tasks)
            {
                try
                {
                    using (Task t = DaqSystem.Local.LoadTask(s))
                    {
                        t.Control(TaskAction.Verify);

                        if (t.AIChannels.Count > 0 &&
                            t.Timing.SampleQuantityMode == SampleQuantityMode.ContinuousSamples)
                        {
                            taskComboBox.Items.Add(s);
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
                startButton.Enabled = true;
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
                if (continuousTask != null)
                {
                    runningTask = null;
                    continuousTask.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.globalContinuousAIWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.taskComboBox = new System.Windows.Forms.ComboBox();
            this.daqmxTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.daqmxTaskLabel = new System.Windows.Forms.Label();
            this.channelLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.globalContinuousAIWaveformGraph)).BeginInit();
            this.daqmxTaskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.channelLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // globalContinuousAIWaveformGraph
            // 
            this.globalContinuousAIWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.globalContinuousAIWaveformGraph.Location = new System.Drawing.Point(8, 107);
            this.globalContinuousAIWaveformGraph.Name = "globalContinuousAIWaveformGraph";
            this.globalContinuousAIWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.globalContinuousAIWaveformGraph.Size = new System.Drawing.Size(504, 293);
            this.globalContinuousAIWaveformGraph.TabIndex = 3;
            this.globalContinuousAIWaveformGraph.TabStop = false;
            this.globalContinuousAIWaveformGraph.UseColorGenerator = true;
            this.globalContinuousAIWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.globalContinuousAIWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // startButton
            // 
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startButton.Location = new System.Drawing.Point(352, 40);
            this.startButton.Name = "startButton";
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.stopButton.Location = new System.Drawing.Point(437, 40);
            this.stopButton.Name = "stopButton";
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // taskComboBox
            // 
            this.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskComboBox.Location = new System.Drawing.Point(104, 32);
            this.taskComboBox.Name = "taskComboBox";
            this.taskComboBox.Size = new System.Drawing.Size(216, 21);
            this.taskComboBox.TabIndex = 1;
            // 
            // daqmxTaskGroupBox
            // 
            this.daqmxTaskGroupBox.Controls.Add(this.daqmxTaskLabel);
            this.daqmxTaskGroupBox.Controls.Add(this.taskComboBox);
            this.daqmxTaskGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.daqmxTaskGroupBox.Location = new System.Drawing.Point(8, 8);
            this.daqmxTaskGroupBox.Name = "daqmxTaskGroupBox";
            this.daqmxTaskGroupBox.Size = new System.Drawing.Size(328, 72);
            this.daqmxTaskGroupBox.TabIndex = 0;
            this.daqmxTaskGroupBox.TabStop = false;
            this.daqmxTaskGroupBox.Text = "Global DAQmx Task";
            // 
            // daqmxTaskLabel
            // 
            this.daqmxTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.daqmxTaskLabel.Location = new System.Drawing.Point(8, 32);
            this.daqmxTaskLabel.Name = "daqmxTaskLabel";
            this.daqmxTaskLabel.Size = new System.Drawing.Size(80, 24);
            this.daqmxTaskLabel.TabIndex = 0;
            this.daqmxTaskLabel.Text = "DAQmx Task:";
            // 
            // channelLegend
            // 
            this.channelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.channelLegend.Location = new System.Drawing.Point(520, 107);
            this.channelLegend.Name = "channelLegend";
            this.channelLegend.Size = new System.Drawing.Size(264, 293);
            this.channelLegend.TabIndex = 4;
            this.channelLegend.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.infoLabel.Location = new System.Drawing.Point(520, 8);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(264, 96);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(792, 406);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.channelLegend);
            this.Controls.Add(this.daqmxTaskGroupBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.globalContinuousAIWaveformGraph);
            this.Controls.Add(this.stopButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Continuous Analog Input - USB";
            ((System.ComponentModel.ISupportInitialize)(this.globalContinuousAIWaveformGraph)).EndInit();
            this.daqmxTaskGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.channelLegend)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new MainForm());
        }

        private void startButton_Click(object sender, System.EventArgs e)
        {
            channelLegend.Items.Clear();
            globalContinuousAIWaveformGraph.ClearData();
            globalContinuousAIWaveformGraph.Plots.Clear();

            try
            {
                string taskName = taskComboBox.SelectedItem.ToString();
                continuousTask = DaqSystem.Local.LoadTask(taskName);

                SetupUI();

                runningTask = continuousTask;
                reader = new AnalogMultiChannelReader(continuousTask.Stream);

                callBack = new AsyncCallback(ReadCallBack);

                reader.SynchronizeCallbacks = true;
                reader.BeginReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), callBack, continuousTask);

                stopButton.Enabled = true;
                startButton.Enabled = false;
                taskComboBox.Enabled = false;
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                continuousTask.Dispose();
            }
        }

        public void ReadCallBack(IAsyncResult ar)
        {
            try
            {
                if (runningTask != null && runningTask == ar.AsyncState)
                {
                    data = reader.EndReadWaveform(ar);

                    globalContinuousAIWaveformGraph.PlotWaveformsAppend(data);

                    reader.BeginMemoryOptimizedReadWaveform(Convert.ToInt32(continuousTask.Timing.SamplesPerChannel), callBack, continuousTask, data);
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                continuousTask.Dispose();

                runningTask = null;
                startButton.Enabled = true;
                stopButton.Enabled = false;
                taskComboBox.Enabled = true;
            }
        }

        private void stopButton_Click(object sender, System.EventArgs e)
        {
            stopButton.Enabled = false;
            runningTask = null;

            try
            {
                continuousTask.Stop();
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }

            continuousTask.Dispose();
            startButton.Enabled = true;
            taskComboBox.Enabled = true;

        }

        private void SetupUI()
        {
            continuousTask.Control(TaskAction.Verify);
            int i = 0;
            foreach (AIChannel chan in continuousTask.AIChannels)
            {
                WaveformPlot plot = new WaveformPlot();
                globalContinuousAIWaveformGraph.Plots.Add(plot);
                channelLegend.Items.Add(new LegendItem(plot, chan.VirtualName + ": " + chan.PhysicalName));
                i++;
            }
        }
    }
}
