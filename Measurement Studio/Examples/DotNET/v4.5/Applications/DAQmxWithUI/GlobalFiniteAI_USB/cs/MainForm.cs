/*******************************************************************************
*
* Example program:
*   GlobalFiniteAI_USB
*
* Description:
*   This example shows how to load a finite analog input task from the Measurement & 
*   Automation Explorer (MAX) and use it to acquire and plot samples from a USB device. 
*   This example should also work with E-Series and M-Series devices.
*
* Instructions for running:
*   1.  Create a finite analog input NI-DAQmx global task in MAX. For help, refer to 
*       "Creating Tasks and Channels" in the Measurement & Automation Explorer Help. 
*       To access this help, select Start>>All Programs>>National Instruments>>
*       Measurement & Automation. In MAX, select Help>>MAX Help.
*
*       Note: If you prefer, you can import a finite AI task and a simulated USB
*       device into MAX from the GlobalFiniteAI_USB.nce file, which is located in the 
*       example directory. Refer to "Using the Configuration Import Wizard" in the 
*       Measurement & Automation Explorer Help for more information.
*
*   2.  Run the application, select the task from the drop-down list, and click 
*       the Read button.
*
* Steps:
*   1.  Load the task from MAX.
*   2.  Read the data from all of the channels in the task.
*   3.  Initialize an array of colors so that if the task has more than one channel
*       then the corresponding plots can be distinguished on the graph. 
*       Assign color(s) to the plot(s) and create a legend.
*   4.  Plot the data on a waveform graph.
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

namespace NationalInstruments.Examples.GlobalFiniteAI_USB
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ComboBox taskComboBox;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private System.Windows.Forms.Button readButton;
        private Color [] plotColors = {Color.Green, Color.Brown, Color.Aqua,
                                       Color.Yellow, Color.DarkMagenta, Color.Beige, Color.Crimson,
                                       Color.BurlyWood, Color.DarkTurquoise, Color.Blue};
        private System.Windows.Forms.GroupBox daqmxTaskGroupBox;
        private System.Windows.Forms.Label daqmxTaskLabel;
        private NationalInstruments.UI.WindowsForms.Legend channelLegend;
        private System.Windows.Forms.Label infoLabel;
        private NationalInstruments.UI.WindowsForms.WaveformGraph globalFiniteAIUsbWaveformGraph;
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

            //
            // Initialize UI
            //

            readButton.Enabled = false;

            foreach (String s in DaqSystem.Local.Tasks)
            {
                try
                {
                    using (Task t = DaqSystem.Local.LoadTask(s))
                    {
                        t.Control(TaskAction.Verify);

                        if (t.AIChannels.Count > 0 && 
                            t.Timing.SampleQuantityMode == SampleQuantityMode.FiniteSamples)
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
                readButton.Enabled = true;
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.daqmxTaskGroupBox = new System.Windows.Forms.GroupBox();
            this.taskComboBox = new System.Windows.Forms.ComboBox();
            this.daqmxTaskLabel = new System.Windows.Forms.Label();
            this.globalFiniteAIUsbWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.readButton = new System.Windows.Forms.Button();
            this.channelLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.infoLabel = new System.Windows.Forms.Label();
            this.daqmxTaskGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.globalFiniteAIUsbWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.channelLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // daqmxTaskGroupBox
            // 
            this.daqmxTaskGroupBox.Controls.Add(this.taskComboBox);
            this.daqmxTaskGroupBox.Controls.Add(this.daqmxTaskLabel);
            this.daqmxTaskGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.daqmxTaskGroupBox.Location = new System.Drawing.Point(8, 8);
            this.daqmxTaskGroupBox.Name = "daqmxTaskGroupBox";
            this.daqmxTaskGroupBox.Size = new System.Drawing.Size(328, 72);
            this.daqmxTaskGroupBox.TabIndex = 0;
            this.daqmxTaskGroupBox.TabStop = false;
            this.daqmxTaskGroupBox.Text = "Global DAQmx Task";
            // 
            // taskComboBox
            // 
            this.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taskComboBox.Location = new System.Drawing.Point(104, 32);
            this.taskComboBox.Name = "taskComboBox";
            this.taskComboBox.Size = new System.Drawing.Size(216, 21);
            this.taskComboBox.TabIndex = 1;
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
            // globalFiniteAIUsbWaveformGraph
            // 
            this.globalFiniteAIUsbWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.globalFiniteAIUsbWaveformGraph.Location = new System.Drawing.Point(8, 105);
            this.globalFiniteAIUsbWaveformGraph.Name = "globalFiniteAIUsbWaveformGraph";
            this.globalFiniteAIUsbWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.globalFiniteAIUsbWaveformGraph.Size = new System.Drawing.Size(502, 294);
            this.globalFiniteAIUsbWaveformGraph.TabIndex = 2;
            this.globalFiniteAIUsbWaveformGraph.TabStop = false;
            this.globalFiniteAIUsbWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.globalFiniteAIUsbWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // readButton
            // 
            this.readButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.readButton.Location = new System.Drawing.Point(437, 40);
            this.readButton.Name = "readButton";
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Read";
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // channelLegend
            // 
            this.channelLegend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.channelLegend.Location = new System.Drawing.Point(518, 105);
            this.channelLegend.Name = "channelLegend";
            this.channelLegend.Size = new System.Drawing.Size(264, 294);
            this.channelLegend.TabIndex = 3;
            this.channelLegend.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.infoLabel.Location = new System.Drawing.Point(518, 8);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(264, 93);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(792, 406);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.channelLegend);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.globalFiniteAIUsbWaveformGraph);
            this.Controls.Add(this.daqmxTaskGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Finite Analog Input - USB";
            this.daqmxTaskGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.globalFiniteAIUsbWaveformGraph)).EndInit();
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

        private void readButton_Click(object sender, System.EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            globalFiniteAIUsbWaveformGraph.ClearData();
            globalFiniteAIUsbWaveformGraph.Plots.Clear();
            channelLegend.Items.Clear();

            try
            {
                using (Task finiteTask = DaqSystem.Local.LoadTask(taskComboBox.SelectedItem.ToString()))
                {
                    SetupUI(finiteTask);

                    AnalogMultiChannelReader reader = new AnalogMultiChannelReader(finiteTask.Stream);

                    // Passing '-1' to Read...() reads all samples.
                    AnalogWaveform<double>[] data = reader.ReadWaveform(-1);

                    globalFiniteAIUsbWaveformGraph.PlotWaveforms(data);
                }
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Cursor = Cursors.Default;
        }

        private void SetupUI(Task finiteTask)
        {
            finiteTask.Control(TaskAction.Verify);
            int i = 0;
            foreach ( AIChannel chan in finiteTask.AIChannels)
            {     
                WaveformPlot plot = new WaveformPlot();
                globalFiniteAIUsbWaveformGraph.Plots.Add(plot);
                plot.LineColor = plotColors[i % plotColors.Length];
                channelLegend.Items.Add(new LegendItem(plot, chan.VirtualName + ": " + chan.PhysicalName));
                i++;
            }
        }
    }
}
