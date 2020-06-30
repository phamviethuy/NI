using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments.DAQmx;

namespace NationalInstruments.Examples.AnalogTdmsFileProcessor
{
	/// <summary>
	/// Form used to configure a DAQmx analog acquisition. When the DialogResult 
	/// property value is DialogResult.OK after a call to ShowDialog, the caller
	/// must get the Task property value and store a reference to that Task 
	/// object. The caller is responsible for calling Task.Dispose() on that object. 
	/// 	
    /// The caller can optionally set the Task property prior to calling ShowDialog().
    /// The Task that the caller passes in is expected to be verified.
	/// In this case, ConfigureDAQmxAcquisitionForm uses the Task settings as 
	/// initial configuration values. If the result of the ShowDialog call is 
	/// DialogResult.OK, ConfigureDAQmxAcquisitionForm disposes the Task. If the 
	/// DialogResult property value is DialogResult.Cancel, the Task is still valid. 
	/// </summary>
	public class ConfigureDAQmxAcquisitionForm : System.Windows.Forms.Form
	{
        private Task task;

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.GroupBox channelConfigurationGroupBox;
        private System.Windows.Forms.ComboBox terminalConfigurationComboBox;
        private System.Windows.Forms.Label minimumValueLabel;
        private System.Windows.Forms.Label physicalChannelLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit samplingRateNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
        private System.Windows.Forms.Label samplingRateLabel;
        private System.Windows.Forms.Label numberOfSamplesLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit minimumValueNumericEdit;
        private System.Windows.Forms.Label terminalConfigurationLabel;
        private System.Windows.Forms.GroupBox timingConfigurationGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit maximumValueNumericEdit;
        private System.Windows.Forms.Label maximumValueLabel;
        private System.Windows.Forms.ComboBox physicalChannelComboBox;
        private SaveFileDialog tdmsFileSaveFileDialog;
        private GroupBox tdmsStreamingConfigurationGroupBox;
        private Button browseButton;
        private TextBox filePathTextBox;
        private Label filePathLabel;
        private CheckBox highSpeedTdmsStreamingCheckBox;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ConfigureDAQmxAcquisitionForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            //
            // Populate physicalChannelComboBox with the physical channels.
            // 
            physicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));

            //
            // Populate terminalConfigurationComboBox with the possible terminal 
            // types and initialize it to the most common value.
            //
            terminalConfigurationComboBox.Items.AddRange(Enum.GetNames(typeof(AITerminalConfiguration)));
            terminalConfigurationComboBox.SelectedItem = AITerminalConfiguration.Differential.ToString();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
                //
                // We do not dispose the task here; the owner of this dialog
                // is responsible for disposing the task.
                //
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.channelConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.physicalChannelComboBox = new System.Windows.Forms.ComboBox();
            this.maximumValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.maximumValueLabel = new System.Windows.Forms.Label();
            this.terminalConfigurationComboBox = new System.Windows.Forms.ComboBox();
            this.minimumValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.minimumValueLabel = new System.Windows.Forms.Label();
            this.terminalConfigurationLabel = new System.Windows.Forms.Label();
            this.physicalChannelLabel = new System.Windows.Forms.Label();
            this.timingConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.samplingRateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.samplingRateLabel = new System.Windows.Forms.Label();
            this.numberOfSamplesLabel = new System.Windows.Forms.Label();
            this.tdmsFileSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tdmsStreamingConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.highSpeedTdmsStreamingCheckBox = new System.Windows.Forms.CheckBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.filePathLabel = new System.Windows.Forms.Label();
            this.channelConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maximumValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumValueNumericEdit)).BeginInit();
            this.timingConfigurationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
            this.tdmsStreamingConfigurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(175, 410);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 16;
            this.cancelButton.Text = "&Cancel";
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(79, 410);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 15;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // channelConfigurationGroupBox
            // 
            this.channelConfigurationGroupBox.Controls.Add(this.physicalChannelComboBox);
            this.channelConfigurationGroupBox.Controls.Add(this.maximumValueNumericEdit);
            this.channelConfigurationGroupBox.Controls.Add(this.maximumValueLabel);
            this.channelConfigurationGroupBox.Controls.Add(this.terminalConfigurationComboBox);
            this.channelConfigurationGroupBox.Controls.Add(this.minimumValueNumericEdit);
            this.channelConfigurationGroupBox.Controls.Add(this.minimumValueLabel);
            this.channelConfigurationGroupBox.Controls.Add(this.terminalConfigurationLabel);
            this.channelConfigurationGroupBox.Controls.Add(this.physicalChannelLabel);
            this.channelConfigurationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.channelConfigurationGroupBox.Location = new System.Drawing.Point(8, 8);
            this.channelConfigurationGroupBox.Name = "channelConfigurationGroupBox";
            this.channelConfigurationGroupBox.Size = new System.Drawing.Size(312, 176);
            this.channelConfigurationGroupBox.TabIndex = 1;
            this.channelConfigurationGroupBox.TabStop = false;
            this.channelConfigurationGroupBox.Text = "Channel Configuration";
            // 
            // physicalChannelComboBox
            // 
            this.physicalChannelComboBox.Location = new System.Drawing.Point(152, 21);
            this.physicalChannelComboBox.Name = "physicalChannelComboBox";
            this.physicalChannelComboBox.Size = new System.Drawing.Size(152, 21);
            this.physicalChannelComboBox.TabIndex = 10;
            this.physicalChannelComboBox.Text = "Dev1/ai0";
            // 
            // maximumValueNumericEdit
            // 
            this.maximumValueNumericEdit.CoercionInterval = 10;
            this.maximumValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.maximumValueNumericEdit.Location = new System.Drawing.Point(152, 144);
            this.maximumValueNumericEdit.Name = "maximumValueNumericEdit";
            this.maximumValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.maximumValueNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.maximumValueNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.maximumValueNumericEdit.TabIndex = 9;
            this.maximumValueNumericEdit.Value = 10;
            // 
            // maximumValueLabel
            // 
            this.maximumValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.maximumValueLabel.Location = new System.Drawing.Point(8, 144);
            this.maximumValueLabel.Name = "maximumValueLabel";
            this.maximumValueLabel.Size = new System.Drawing.Size(129, 23);
            this.maximumValueLabel.TabIndex = 8;
            this.maximumValueLabel.Text = "Maximum Value:";
            // 
            // terminalConfigurationComboBox
            // 
            this.terminalConfigurationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.terminalConfigurationComboBox.Location = new System.Drawing.Point(152, 61);
            this.terminalConfigurationComboBox.Name = "terminalConfigurationComboBox";
            this.terminalConfigurationComboBox.Size = new System.Drawing.Size(152, 21);
            this.terminalConfigurationComboBox.TabIndex = 5;
            // 
            // minimumValueNumericEdit
            // 
            this.minimumValueNumericEdit.CoercionInterval = 10;
            this.minimumValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.minimumValueNumericEdit.Location = new System.Drawing.Point(152, 101);
            this.minimumValueNumericEdit.Name = "minimumValueNumericEdit";
            this.minimumValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.minimumValueNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.minimumValueNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.minimumValueNumericEdit.TabIndex = 7;
            this.minimumValueNumericEdit.Value = -10;
            // 
            // minimumValueLabel
            // 
            this.minimumValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minimumValueLabel.Location = new System.Drawing.Point(8, 101);
            this.minimumValueLabel.Name = "minimumValueLabel";
            this.minimumValueLabel.Size = new System.Drawing.Size(129, 23);
            this.minimumValueLabel.TabIndex = 6;
            this.minimumValueLabel.Text = "Minimum Value:";
            // 
            // terminalConfigurationLabel
            // 
            this.terminalConfigurationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.terminalConfigurationLabel.Location = new System.Drawing.Point(8, 61);
            this.terminalConfigurationLabel.Name = "terminalConfigurationLabel";
            this.terminalConfigurationLabel.Size = new System.Drawing.Size(129, 23);
            this.terminalConfigurationLabel.TabIndex = 4;
            this.terminalConfigurationLabel.Text = "Terminal Configuration:";
            // 
            // physicalChannelLabel
            // 
            this.physicalChannelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.physicalChannelLabel.Location = new System.Drawing.Point(8, 21);
            this.physicalChannelLabel.Name = "physicalChannelLabel";
            this.physicalChannelLabel.Size = new System.Drawing.Size(129, 23);
            this.physicalChannelLabel.TabIndex = 2;
            this.physicalChannelLabel.Text = "Physical Channel:";
            // 
            // timingConfigurationGroupBox
            // 
            this.timingConfigurationGroupBox.Controls.Add(this.samplingRateNumericEdit);
            this.timingConfigurationGroupBox.Controls.Add(this.numberOfSamplesNumericEdit);
            this.timingConfigurationGroupBox.Controls.Add(this.samplingRateLabel);
            this.timingConfigurationGroupBox.Controls.Add(this.numberOfSamplesLabel);
            this.timingConfigurationGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timingConfigurationGroupBox.Location = new System.Drawing.Point(8, 192);
            this.timingConfigurationGroupBox.Name = "timingConfigurationGroupBox";
            this.timingConfigurationGroupBox.Size = new System.Drawing.Size(312, 100);
            this.timingConfigurationGroupBox.TabIndex = 10;
            this.timingConfigurationGroupBox.TabStop = false;
            this.timingConfigurationGroupBox.Text = "Timing Configuration";
            // 
            // samplingRateNumericEdit
            // 
            this.samplingRateNumericEdit.CoercionInterval = 100;
            this.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.samplingRateNumericEdit.Location = new System.Drawing.Point(148, 55);
            this.samplingRateNumericEdit.Name = "samplingRateNumericEdit";
            this.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.samplingRateNumericEdit.Range = new NationalInstruments.UI.Range(0.001, 1000000);
            this.samplingRateNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.samplingRateNumericEdit.TabIndex = 14;
            this.samplingRateNumericEdit.Value = 1000;
            // 
            // numberOfSamplesNumericEdit
            // 
            this.numberOfSamplesNumericEdit.CoercionInterval = 100;
            this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(148, 23);
            this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
            this.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfSamplesNumericEdit.Range = new NationalInstruments.UI.Range(0, 100000);
            this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.numberOfSamplesNumericEdit.TabIndex = 12;
            this.numberOfSamplesNumericEdit.Value = 1000;
            // 
            // samplingRateLabel
            // 
            this.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplingRateLabel.Location = new System.Drawing.Point(12, 55);
            this.samplingRateLabel.Name = "samplingRateLabel";
            this.samplingRateLabel.Size = new System.Drawing.Size(129, 23);
            this.samplingRateLabel.TabIndex = 13;
            this.samplingRateLabel.Text = "Sampling Rate:";
            // 
            // numberOfSamplesLabel
            // 
            this.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numberOfSamplesLabel.Location = new System.Drawing.Point(12, 23);
            this.numberOfSamplesLabel.Name = "numberOfSamplesLabel";
            this.numberOfSamplesLabel.Size = new System.Drawing.Size(129, 23);
            this.numberOfSamplesLabel.TabIndex = 11;
            this.numberOfSamplesLabel.Text = "Number of Samples:";
            // 
            // tdmsFileSaveFileDialog
            // 
            this.tdmsFileSaveFileDialog.FileName = "waveforms.tdms";
            this.tdmsFileSaveFileDialog.Filter = "TDMS files|*.tdms";
            this.tdmsFileSaveFileDialog.Title = "Save TDMS file as";
            // 
            // tdmsStreamingConfigurationGroupBox
            // 
            this.tdmsStreamingConfigurationGroupBox.Controls.Add(this.highSpeedTdmsStreamingCheckBox);
            this.tdmsStreamingConfigurationGroupBox.Controls.Add(this.browseButton);
            this.tdmsStreamingConfigurationGroupBox.Controls.Add(this.filePathTextBox);
            this.tdmsStreamingConfigurationGroupBox.Controls.Add(this.filePathLabel);
            this.tdmsStreamingConfigurationGroupBox.Location = new System.Drawing.Point(8, 298);
            this.tdmsStreamingConfigurationGroupBox.Name = "tdmsStreamingConfigurationGroupBox";
            this.tdmsStreamingConfigurationGroupBox.Size = new System.Drawing.Size(312, 100);
            this.tdmsStreamingConfigurationGroupBox.TabIndex = 20;
            this.tdmsStreamingConfigurationGroupBox.TabStop = false;
            this.tdmsStreamingConfigurationGroupBox.Text = "TDMS Streaming Configuration";
            // 
            // highSpeedTdmsStreamingCheckBox
            // 
            this.highSpeedTdmsStreamingCheckBox.AutoSize = true;
            this.highSpeedTdmsStreamingCheckBox.Location = new System.Drawing.Point(12, 23);
            this.highSpeedTdmsStreamingCheckBox.Name = "highSpeedTdmsStreamingCheckBox";
            this.highSpeedTdmsStreamingCheckBox.Size = new System.Drawing.Size(202, 17);
            this.highSpeedTdmsStreamingCheckBox.TabIndex = 5;
            this.highSpeedTdmsStreamingCheckBox.Text = "Enable High-Speed TDMS Streaming";
            this.highSpeedTdmsStreamingCheckBox.UseVisualStyleBackColor = true;
            this.highSpeedTdmsStreamingCheckBox.CheckedChanged += new System.EventHandler(this.highSpeedTdmsStreamingCheckBox_CheckedChanged);
            // 
            // browseButton
            // 
            this.browseButton.Enabled = false;
            this.browseButton.Location = new System.Drawing.Point(275, 54);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(25, 22);
            this.browseButton.TabIndex = 4;
            this.browseButton.Text = "...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.Location = new System.Drawing.Point(148, 55);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(125, 20);
            this.filePathTextBox.TabIndex = 3;
            this.filePathTextBox.Text = "waveforms.tdms";
            // 
            // filePathLabel
            // 
            this.filePathLabel.Location = new System.Drawing.Point(12, 55);
            this.filePathLabel.Name = "filePathLabel";
            this.filePathLabel.Size = new System.Drawing.Size(129, 23);
            this.filePathLabel.TabIndex = 2;
            this.filePathLabel.Text = "File Path:";
            // 
            // ConfigureDAQmxAcquisitionForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(328, 448);
            this.Controls.Add(this.tdmsStreamingConfigurationGroupBox);
            this.Controls.Add(this.timingConfigurationGroupBox);
            this.Controls.Add(this.channelConfigurationGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigureDAQmxAcquisitionForm";
            this.Text = "Configure DAQmx Acquisition";
            this.Load += new System.EventHandler(this.ConfigureDAQmxAcquisitionForm_Load);
            this.channelConfigurationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.maximumValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumValueNumericEdit)).EndInit();
            this.timingConfigurationGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
            this.tdmsStreamingConfigurationGroupBox.ResumeLayout(false);
            this.tdmsStreamingConfigurationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
		#endregion

        /// <summary>
        /// The task being configured. The caller can specify an initial task
        /// before calling ShowDialog(). If ShowDialog() returns DialogResult.OK,
        /// the caller must take ownership of the underlying task object and
        /// call Dispose on it as appropriate.
        /// </summary>
        public Task Task
        {
            get
            {
                return task;
            }
            set
            {
                task = value;
            }
        }

        private void ConfigureDAQmxAcquisitionForm_Load(object sender, EventArgs e)
        {
            PopulateControls();
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            //
            // Create a temporary task so that we don't modify the existing task
            // if an error occurs verifying the task.
            //
            Task newTask = null;
            try
            {
                newTask = new Task();
                if (!ConfigureTaskFromControls(newTask))
                {
                    newTask.Dispose();
                    return;
                }
                if (task != null)
                {
                    //
                    // We dispose the original task. The caller is expected
                    // to get a reference to the new task through the Task
                    // property.
                    //
                    task.Dispose();
                }
                task = newTask;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {   
                if (newTask != null)
                {
                    newTask.Dispose();
                }
                throw;
            }
        }

        private bool ConfigureTaskFromControls(Task task)
        {
            try
            {
                task.AIChannels.CreateVoltageChannel(physicalChannelComboBox.Text, "Voltage", (AITerminalConfiguration)Enum.Parse(typeof(AITerminalConfiguration), terminalConfigurationComboBox.SelectedItem.ToString()), minimumValueNumericEdit.Value, maximumValueNumericEdit.Value, AIVoltageUnits.Volts);
                task.Timing.ConfigureSampleClock("", samplingRateNumericEdit.Value, SampleClockActiveEdge.Rising, SampleQuantityMode.FiniteSamples, (int)numberOfSamplesNumericEdit.Value);
                if (highSpeedTdmsStreamingCheckBox.Checked)
                {
                    task.ConfigureLogging(filePathTextBox.Text, TdmsLoggingOperation.CreateOrReplace, LoggingMode.LogAndRead, "TdmsDataProcessorExample");
                }
                else
                {
                    task.Stream.LoggingMode = LoggingMode.Off;
                }

                task.Control(TaskAction.Verify);
            }
            catch (DaqException exception)
            {
                MessageBox.Show(exception.Message, "Error Configuring DAQ Task");
                return false;
            }

            return true;
        }

        private void PopulateControls()
        {
            if ((task == null) || (task.AIChannels.Count == 0))
            {
                //
                // No previous task or channel information. Use the control default values.
                //
                return;
            }
            AIChannel channel = task.AIChannels[0];
            physicalChannelComboBox.Text = channel.PhysicalName;

            terminalConfigurationComboBox.SelectedItem = channel.TerminalConfiguration.ToString();

            minimumValueNumericEdit.Value = channel.Minimum;
            maximumValueNumericEdit.Value = channel.Maximum;

            numberOfSamplesNumericEdit.Value = task.Timing.SamplesPerChannel;
            samplingRateNumericEdit.Value = task.Timing.SampleClockRate;

            if (task.Stream.LoggingMode == LoggingMode.LogAndRead)
            {
                highSpeedTdmsStreamingCheckBox.Checked = true;
                filePathTextBox.Text = task.Stream.LoggingFilePath;
            }
            else
            {
                highSpeedTdmsStreamingCheckBox.Checked = false;
            }
        }

        private void highSpeedTdmsStreamingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            filePathTextBox.Enabled = highSpeedTdmsStreamingCheckBox.Checked;
            browseButton.Enabled = highSpeedTdmsStreamingCheckBox.Checked;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (tdmsFileSaveFileDialog.ShowDialog() == DialogResult.OK)
                filePathTextBox.Text = tdmsFileSaveFileDialog.FileName;
        }
	}
}
