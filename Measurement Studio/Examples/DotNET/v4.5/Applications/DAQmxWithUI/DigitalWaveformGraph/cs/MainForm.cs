using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.DigitalWaveformGraph
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.TextBox physicalChannelTextBox;
        private System.Windows.Forms.TextBox samplesPerChannelTextBox;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.ComboBox channelConfigComboBox;
        private System.Windows.Forms.GroupBox channelParametersGroupBox;
        private System.Windows.Forms.GroupBox timingParametersGroupBox;
        private System.Windows.Forms.Label lineGroupingLabel;
        private System.Windows.Forms.Label samplesToReadLabel;
        private System.Windows.Forms.TextBox samplingRateTextBox;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.GroupBox taskGroupBox;
        private System.Windows.Forms.RadioButton newTaskRadioButton;
        private System.Windows.Forms.RadioButton existingTaskRadioButton;
        private System.Windows.Forms.ComboBox savedTaskComboBox;
        private System.Windows.Forms.Label savedTaskLabel;
        private System.Windows.Forms.Label graphHelpLabel;
        private System.Windows.Forms.GroupBox graphGroupBox;
        private System.Windows.Forms.GroupBox graphParametersGroupBox;
        private NationalInstruments.UI.WindowsForms.PropertyEditor daqmxPropertyEditor;
        private System.Windows.Forms.TextBox sampleClockSourceTextBox;
        private System.Windows.Forms.Label sampleClockSourceLabel;
        private NationalInstruments.UI.WindowsForms.DigitalWaveformGraph daqmxDigitalWaveformGraph;
        private System.Windows.Forms.Label toUndoZoomLabel;
        private System.Windows.Forms.Label toPanLabel;
        private System.Windows.Forms.Label toUndoPanLabel;
        private System.Windows.Forms.Label toUndoAllZoomsOrPansLabel;
        private System.Windows.Forms.Label physicalChannelLabel;
        private System.Windows.Forms.Label graphAxisFormatLabel;
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
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.physicalChannelTextBox = new System.Windows.Forms.TextBox();
            this.samplesPerChannelTextBox = new System.Windows.Forms.TextBox();
            this.daqmxDigitalWaveformGraph = new NationalInstruments.UI.WindowsForms.DigitalWaveformGraph();
            this.readButton = new System.Windows.Forms.Button();
            this.channelConfigComboBox = new System.Windows.Forms.ComboBox();
            this.physicalChannelLabel = new System.Windows.Forms.Label();
            this.samplesToReadLabel = new System.Windows.Forms.Label();
            this.lineGroupingLabel = new System.Windows.Forms.Label();
            this.channelParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.timingParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.sampleClockSourceLabel = new System.Windows.Forms.Label();
            this.samplingRateTextBox = new System.Windows.Forms.TextBox();
            this.samplingRateLabel = new System.Windows.Forms.Label();
            this.sampleClockSourceTextBox = new System.Windows.Forms.TextBox();
            this.graphHelpLabel = new System.Windows.Forms.Label();
            this.taskGroupBox = new System.Windows.Forms.GroupBox();
            this.newTaskRadioButton = new System.Windows.Forms.RadioButton();
            this.existingTaskRadioButton = new System.Windows.Forms.RadioButton();
            this.savedTaskComboBox = new System.Windows.Forms.ComboBox();
            this.savedTaskLabel = new System.Windows.Forms.Label();
            this.graphGroupBox = new System.Windows.Forms.GroupBox();
            this.toUndoZoomLabel = new System.Windows.Forms.Label();
            this.toPanLabel = new System.Windows.Forms.Label();
            this.toUndoPanLabel = new System.Windows.Forms.Label();
            this.toUndoAllZoomsOrPansLabel = new System.Windows.Forms.Label();
            this.graphParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.graphAxisFormatLabel = new System.Windows.Forms.Label();
            this.daqmxPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            ((System.ComponentModel.ISupportInitialize)(this.daqmxDigitalWaveformGraph)).BeginInit();
            this.channelParametersGroupBox.SuspendLayout();
            this.timingParametersGroupBox.SuspendLayout();
            this.taskGroupBox.SuspendLayout();
            this.graphGroupBox.SuspendLayout();
            this.graphParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // physicalChannelTextBox
            // 
            this.physicalChannelTextBox.Location = new System.Drawing.Point(128, 24);
            this.physicalChannelTextBox.Name = "physicalChannelTextBox";
            this.physicalChannelTextBox.Size = new System.Drawing.Size(160, 20);
            this.physicalChannelTextBox.TabIndex = 0;
            this.physicalChannelTextBox.Text = "Dev1/port0/line7:0";
            // 
            // samplesPerChannelTextBox
            // 
            this.samplesPerChannelTextBox.Location = new System.Drawing.Point(128, 24);
            this.samplesPerChannelTextBox.Name = "samplesPerChannelTextBox";
            this.samplesPerChannelTextBox.Size = new System.Drawing.Size(160, 20);
            this.samplesPerChannelTextBox.TabIndex = 1;
            this.samplesPerChannelTextBox.Text = "20";
            // 
            // daqmxDigitalWaveformGraph
            // 
            this.daqmxDigitalWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.daqmxDigitalWaveformGraph.Location = new System.Drawing.Point(8, 232);
            this.daqmxDigitalWaveformGraph.Name = "daqmxDigitalWaveformGraph";
            this.daqmxDigitalWaveformGraph.Size = new System.Drawing.Size(856, 264);
            this.daqmxDigitalWaveformGraph.TabIndex = 2;
            // 
            // readButton
            // 
            this.readButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.readButton.Location = new System.Drawing.Point(384, 200);
            this.readButton.Name = "readButton";
            this.readButton.TabIndex = 3;
            this.readButton.Text = "&Read";
            this.readButton.Click += new System.EventHandler(this.readButton_Click);
            // 
            // channelConfigComboBox
            // 
            this.channelConfigComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.channelConfigComboBox.Items.AddRange(new object[] {
            "One channel for each line",
            "One channel for all lines"});
            this.channelConfigComboBox.Location = new System.Drawing.Point(128, 56);
            this.channelConfigComboBox.Name = "channelConfigComboBox";
            this.channelConfigComboBox.Size = new System.Drawing.Size(160, 21);
            this.channelConfigComboBox.TabIndex = 4;
            // 
            // physicalChannelLabel
            // 
            this.physicalChannelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.physicalChannelLabel.Location = new System.Drawing.Point(16, 24);
            this.physicalChannelLabel.Name = "physicalChannelLabel";
            this.physicalChannelLabel.Size = new System.Drawing.Size(96, 16);
            this.physicalChannelLabel.TabIndex = 5;
            this.physicalChannelLabel.Text = "Physical Channel:";
            // 
            // samplesToReadLabel
            // 
            this.samplesToReadLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplesToReadLabel.Location = new System.Drawing.Point(16, 24);
            this.samplesToReadLabel.Name = "samplesToReadLabel";
            this.samplesToReadLabel.Size = new System.Drawing.Size(96, 16);
            this.samplesToReadLabel.TabIndex = 5;
            this.samplesToReadLabel.Text = "Sample to read:";
            // 
            // lineGroupingLabel
            // 
            this.lineGroupingLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineGroupingLabel.Location = new System.Drawing.Point(16, 56);
            this.lineGroupingLabel.Name = "lineGroupingLabel";
            this.lineGroupingLabel.Size = new System.Drawing.Size(96, 16);
            this.lineGroupingLabel.TabIndex = 5;
            this.lineGroupingLabel.Text = "Line Grouping:";
            // 
            // channelParametersGroupBox
            // 
            this.channelParametersGroupBox.Controls.Add(this.physicalChannelLabel);
            this.channelParametersGroupBox.Controls.Add(this.lineGroupingLabel);
            this.channelParametersGroupBox.Controls.Add(this.channelConfigComboBox);
            this.channelParametersGroupBox.Controls.Add(this.physicalChannelTextBox);
            this.channelParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.channelParametersGroupBox.Location = new System.Drawing.Point(8, 104);
            this.channelParametersGroupBox.Name = "channelParametersGroupBox";
            this.channelParametersGroupBox.Size = new System.Drawing.Size(304, 88);
            this.channelParametersGroupBox.TabIndex = 6;
            this.channelParametersGroupBox.TabStop = false;
            this.channelParametersGroupBox.Text = "Channel Parameters";
            // 
            // timingParametersGroupBox
            // 
            this.timingParametersGroupBox.Controls.Add(this.sampleClockSourceLabel);
            this.timingParametersGroupBox.Controls.Add(this.samplesToReadLabel);
            this.timingParametersGroupBox.Controls.Add(this.samplesPerChannelTextBox);
            this.timingParametersGroupBox.Controls.Add(this.samplingRateTextBox);
            this.timingParametersGroupBox.Controls.Add(this.samplingRateLabel);
            this.timingParametersGroupBox.Controls.Add(this.sampleClockSourceTextBox);
            this.timingParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timingParametersGroupBox.Location = new System.Drawing.Point(320, 8);
            this.timingParametersGroupBox.Name = "timingParametersGroupBox";
            this.timingParametersGroupBox.Size = new System.Drawing.Size(304, 120);
            this.timingParametersGroupBox.TabIndex = 6;
            this.timingParametersGroupBox.TabStop = false;
            this.timingParametersGroupBox.Text = "Timing Parameters";
            // 
            // sampleClockSourceLabel
            // 
            this.sampleClockSourceLabel.Location = new System.Drawing.Point(16, 88);
            this.sampleClockSourceLabel.Name = "sampleClockSourceLabel";
            this.sampleClockSourceLabel.Size = new System.Drawing.Size(96, 16);
            this.sampleClockSourceLabel.TabIndex = 6;
            this.sampleClockSourceLabel.Text = "Sample Clock";
            // 
            // samplingRateTextBox
            // 
            this.samplingRateTextBox.Location = new System.Drawing.Point(128, 56);
            this.samplingRateTextBox.Name = "samplingRateTextBox";
            this.samplingRateTextBox.Size = new System.Drawing.Size(160, 20);
            this.samplingRateTextBox.TabIndex = 1;
            this.samplingRateTextBox.Text = "1000";
            // 
            // samplingRateLabel
            // 
            this.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplingRateLabel.Location = new System.Drawing.Point(16, 56);
            this.samplingRateLabel.Name = "samplingRateLabel";
            this.samplingRateLabel.Size = new System.Drawing.Size(104, 16);
            this.samplingRateLabel.TabIndex = 5;
            this.samplingRateLabel.Text = "Sampling Rate (Hz):";
            // 
            // sampleClockSourceTextBox
            // 
            this.sampleClockSourceTextBox.Location = new System.Drawing.Point(128, 88);
            this.sampleClockSourceTextBox.Name = "sampleClockSourceTextBox";
            this.sampleClockSourceTextBox.Size = new System.Drawing.Size(160, 20);
            this.sampleClockSourceTextBox.TabIndex = 1;
            this.sampleClockSourceTextBox.Text = "OnboardClock";
            // 
            // graphHelpLabel
            // 
            this.graphHelpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.graphHelpLabel.Location = new System.Drawing.Point(16, 32);
            this.graphHelpLabel.Name = "graphHelpLabel";
            this.graphHelpLabel.Size = new System.Drawing.Size(192, 16);
            this.graphHelpLabel.TabIndex = 7;
            this.graphHelpLabel.Text = "To Zoom :  <Shift> + left click or drag";
            // 
            // taskGroupBox
            // 
            this.taskGroupBox.Controls.Add(this.newTaskRadioButton);
            this.taskGroupBox.Controls.Add(this.existingTaskRadioButton);
            this.taskGroupBox.Controls.Add(this.savedTaskComboBox);
            this.taskGroupBox.Controls.Add(this.savedTaskLabel);
            this.taskGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.taskGroupBox.Location = new System.Drawing.Point(8, 8);
            this.taskGroupBox.Name = "taskGroupBox";
            this.taskGroupBox.Size = new System.Drawing.Size(304, 96);
            this.taskGroupBox.TabIndex = 6;
            this.taskGroupBox.TabStop = false;
            this.taskGroupBox.Text = "Task";
            // 
            // newTaskRadioButton
            // 
            this.newTaskRadioButton.Checked = true;
            this.newTaskRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.newTaskRadioButton.Location = new System.Drawing.Point(16, 24);
            this.newTaskRadioButton.Name = "newTaskRadioButton";
            this.newTaskRadioButton.Size = new System.Drawing.Size(120, 16);
            this.newTaskRadioButton.TabIndex = 0;
            this.newTaskRadioButton.TabStop = true;
            this.newTaskRadioButton.Text = "Create a new Task";
            // 
            // existingTaskRadioButton
            // 
            this.existingTaskRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.existingTaskRadioButton.Location = new System.Drawing.Point(16, 40);
            this.existingTaskRadioButton.Name = "existingTaskRadioButton";
            this.existingTaskRadioButton.Size = new System.Drawing.Size(152, 16);
            this.existingTaskRadioButton.TabIndex = 0;
            this.existingTaskRadioButton.Text = "Use a Task saved in MAX";
            this.existingTaskRadioButton.CheckedChanged += new System.EventHandler(this.RadioButtonChanged);
            // 
            // savedTaskComboBox
            // 
            this.savedTaskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.savedTaskComboBox.Enabled = false;
            this.savedTaskComboBox.Location = new System.Drawing.Point(128, 64);
            this.savedTaskComboBox.Name = "savedTaskComboBox";
            this.savedTaskComboBox.Size = new System.Drawing.Size(160, 21);
            this.savedTaskComboBox.TabIndex = 4;
            // 
            // savedTaskLabel
            // 
            this.savedTaskLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.savedTaskLabel.Location = new System.Drawing.Point(16, 64);
            this.savedTaskLabel.Name = "savedTaskLabel";
            this.savedTaskLabel.Size = new System.Drawing.Size(104, 16);
            this.savedTaskLabel.TabIndex = 5;
            this.savedTaskLabel.Text = "Saved Task Name:";
            // 
            // graphGroupBox
            // 
            this.graphGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphGroupBox.Controls.Add(this.graphHelpLabel);
            this.graphGroupBox.Controls.Add(this.toUndoZoomLabel);
            this.graphGroupBox.Controls.Add(this.toPanLabel);
            this.graphGroupBox.Controls.Add(this.toUndoPanLabel);
            this.graphGroupBox.Controls.Add(this.toUndoAllZoomsOrPansLabel);
            this.graphGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.graphGroupBox.Location = new System.Drawing.Point(632, 8);
            this.graphGroupBox.Name = "graphGroupBox";
            this.graphGroupBox.Size = new System.Drawing.Size(232, 184);
            this.graphGroupBox.TabIndex = 6;
            this.graphGroupBox.TabStop = false;
            this.graphGroupBox.Text = "Using the Graph";
            // 
            // toUndoZoomLabel
            // 
            this.toUndoZoomLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toUndoZoomLabel.Location = new System.Drawing.Point(16, 56);
            this.toUndoZoomLabel.Name = "toUndoZoomLabel";
            this.toUndoZoomLabel.Size = new System.Drawing.Size(192, 16);
            this.toUndoZoomLabel.TabIndex = 7;
            this.toUndoZoomLabel.Text = "To Undo Zoom :  <Shift> + right click";
            // 
            // toPanLabel
            // 
            this.toPanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toPanLabel.Location = new System.Drawing.Point(16, 80);
            this.toPanLabel.Name = "toPanLabel";
            this.toPanLabel.Size = new System.Drawing.Size(128, 16);
            this.toPanLabel.TabIndex = 7;
            this.toPanLabel.Text = "To Pan :  <Ctrl> + drag";
            // 
            // toUndoPanLabel
            // 
            this.toUndoPanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toUndoPanLabel.Location = new System.Drawing.Point(16, 104);
            this.toUndoPanLabel.Name = "toUndoPanLabel";
            this.toUndoPanLabel.Size = new System.Drawing.Size(208, 16);
            this.toUndoPanLabel.TabIndex = 7;
            this.toUndoPanLabel.Text = "To Undo Pan :  <Ctrl> + right click";
            // 
            // toUndoAllZoomsOrPansLabel
            // 
            this.toUndoAllZoomsOrPansLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toUndoAllZoomsOrPansLabel.Location = new System.Drawing.Point(16, 128);
            this.toUndoAllZoomsOrPansLabel.Name = "toUndoAllZoomsOrPansLabel";
            this.toUndoAllZoomsOrPansLabel.Size = new System.Drawing.Size(208, 24);
            this.toUndoAllZoomsOrPansLabel.TabIndex = 7;
            this.toUndoAllZoomsOrPansLabel.Text = "To Undo All Zooms or Pans: <Ctrl> + <Alt> + <Backspace>";
            // 
            // graphParametersGroupBox
            // 
            this.graphParametersGroupBox.Controls.Add(this.graphAxisFormatLabel);
            this.graphParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.graphParametersGroupBox.Location = new System.Drawing.Point(320, 128);
            this.graphParametersGroupBox.Name = "graphParametersGroupBox";
            this.graphParametersGroupBox.Size = new System.Drawing.Size(304, 64);
            this.graphParametersGroupBox.TabIndex = 6;
            this.graphParametersGroupBox.TabStop = false;
            this.graphParametersGroupBox.Text = "Graph Parameters";
            // 
            // graphAxisFormatLabel
            // 
            this.graphAxisFormatLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.graphAxisFormatLabel.Location = new System.Drawing.Point(16, 24);
            this.graphAxisFormatLabel.Name = "graphAxisFormatLabel";
            this.graphAxisFormatLabel.Size = new System.Drawing.Size(104, 16);
            this.graphAxisFormatLabel.TabIndex = 5;
            this.graphAxisFormatLabel.Text = "Axis Format:";
            // 
            // daqmxPropertyEditor
            // 
            this.daqmxPropertyEditor.Location = new System.Drawing.Point(0, 0);
            this.daqmxPropertyEditor.Name = "daqmxPropertyEditor";
            this.daqmxPropertyEditor.Size = new System.Drawing.Size(120, 16);
            this.daqmxPropertyEditor.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(872, 510);
            this.Controls.Add(this.daqmxDigitalWaveformGraph);
            this.Controls.Add(this.channelParametersGroupBox);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.timingParametersGroupBox);
            this.Controls.Add(this.taskGroupBox);
            this.Controls.Add(this.graphGroupBox);
            this.Controls.Add(this.graphParametersGroupBox);
            this.Name = "MainForm";
            this.Text = "Waveform Graph with DAQmx";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.daqmxDigitalWaveformGraph)).EndInit();
            this.channelParametersGroupBox.ResumeLayout(false);
            this.timingParametersGroupBox.ResumeLayout(false);
            this.taskGroupBox.ResumeLayout(false);
            this.graphGroupBox.ResumeLayout(false);
            this.graphParametersGroupBox.ResumeLayout(false);
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
            Application.Run(new MainForm());
        }

        private void Read(Task t)
        {
            DigitalMultiChannelReader reader = new DigitalMultiChannelReader(t.Stream);

            DigitalWaveform[] data = reader.ReadWaveform(System.Int32.Parse(samplesPerChannelTextBox.Text));

            daqmxDigitalWaveformGraph.PlotWaveforms(data);
        }

        private void readButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(existingTaskRadioButton.Checked)
                {
                    // Load a task from MAX
                    using(Task t = DaqSystem.Local.LoadTask(savedTaskComboBox.Text))
                    {
                        Read(t);
                    }
                }
                else
                {
                    // Create a new task
                    using(Task t = new Task(null))
                    {
                        ChannelLineGrouping grouping = ChannelLineGrouping.OneChannelForAllLines;
                        if(channelConfigComboBox.Text == "One channel for each line")
                        {
                            grouping = ChannelLineGrouping.OneChannelForEachLine;
                        }

                        t.DIChannels.CreateChannel(physicalChannelTextBox.Text,"",grouping);

                        t.Timing.ConfigureSampleClock(sampleClockSourceTextBox.Text,Double.Parse(samplingRateTextBox.Text),
                            SampleClockActiveEdge.Rising,SampleQuantityMode.FiniteSamples,Int32.Parse(samplesPerChannelTextBox.Text));

                        Read(t);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            channelConfigComboBox.SelectedIndex = 1;
            daqmxPropertyEditor.Source = new PropertyEditorSource(daqmxDigitalWaveformGraph.XAxis.MajorDivisions,"LabelFormat");
        }

        private void RadioButtonChanged(object sender, System.EventArgs e)
        {
            bool existing = existingTaskRadioButton.Checked;

            // Dim controls as necessary
            channelParametersGroupBox.Enabled = !existing;
            timingParametersGroupBox.Enabled = !existing;
            savedTaskComboBox.Enabled = existing;

            if(existing)
            {
                // Repopulate tasks from MAX
                savedTaskComboBox.Items.Clear();
                savedTaskComboBox.Items.AddRange(DaqSystem.Local.Tasks);
                if(savedTaskComboBox.Items.Count >= 1)
                    savedTaskComboBox.SelectedIndex = 0;
            }
        }
    }
}
