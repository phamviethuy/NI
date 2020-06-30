using System;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using NationalInstruments;
using NationalInstruments.Tdms;

namespace NationalInstruments.Examples.Streaming
{

    public partial class MainForm : Form
    {
        //==========================================================================================        
        // This example demonstrates streaming waveform data to a TDMS file.
        // The data in this example is a sine signal and is generated programatically. To read data from a hardware API instead,
        // you can replace the dataGeneratorComponent with code that reads data from the hardware API. 
        // For example, to read data from DAQmx, replace the dataGeneratorComponent with a DAQComponent.
        // Make sure to set up the TDMS file for the appropriate waveform configuration before writing the waveforms.
        //==========================================================================================        

        private TdmsFile file = null;
        private TdmsChannelGroup channelGroup; 
        private TdmsChannel[] waveformChannels;

        private SineSignal signal;
        private static bool tdmsFileSet = false;
        private const string setUpTDMSFileMessage = "Set up TDMS file before writing.";
        private const string tdmsFileSetUpCompletedMessage = "TDMS file is set up for current configuration. You can now append data to this TDMS file.";
        private const string generateAndAppendMessage = "Generated waveforms and appended to TDMS file. To generate and append more data to this TDMS file, click on \"Generate and Append to TDMS file\" button again. To set up another TDMS file, change the file setup configuration and click on \"Set Up TDMS File\" button.";

        public MainForm()
        {
            InitializeComponent();

            // Initialize Sample Interval Mode ComboBoxes
            sampleIntervalModeComboBox.Items.AddRange(Enum.GetNames(typeof(WaveformSampleIntervalMode)));
            this.sampleIntervalModeComboBox.SelectedIndexChanged += new System.EventHandler(TDMSFileConfiguration_Changed);
            sampleIntervalModeComboBox.SelectedItem = sampleIntervalModeComboBox.Items[0];

            generateAndAppendButton.Enabled = false;
            tdmsFileSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
            statusTextBox.Text = setUpTDMSFileMessage;
        }

        private void setUpTDMSFileButton_Click(object sender, EventArgs e)
        {
            if (filePathTextBox.Text == "")
            {
                MessageBox.Show("TDMS file path cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Exception exception = null;
            try
            {
                SetUpTDMSFile();
            }
            catch (Exception tdmsException)
            {
                exception = tdmsException;
            }
            finally
            {
                if (exception != null)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Update the status
                    statusTextBox.Text = tdmsFileSetUpCompletedMessage;

                    signal = new SineSignal();
                    setUpTDMSFileButton.Enabled = false;
                    generateAndAppendButton.Enabled = true;
                    generateAndAppendButton.Focus();
                    tdmsFileSet = true;
                }
            }
        }

        private void SetUpTDMSFile()
        {
            // Delete the TDMS file and the index file if already present
            if (File.Exists(filePathTextBox.Text))
                TdmsFile.Delete(filePathTextBox.Text);

            // Create new TDMS file.
            file = new TdmsFile(filePathTextBox.Text, new TdmsFileOptions());
            file.AutoSave = true;

            // Set up the channel group.
            TdmsChannelGroupCollection channelGroups = file.GetChannelGroups();
            channelGroup = new TdmsChannelGroup("Main Group");
            channelGroups.Add(channelGroup);

            // Set the WaveformLayout of the TdmsChannelGroup 
            TdmsChannelCollection tdmsChannels = channelGroup.GetChannels();
            waveformChannels = new TdmsChannel[(int)numberOfChannelsNumericEdit.Value];
            if (sampleIntervalModeComboBox.SelectedItem.Equals(WaveformSampleIntervalMode.Irregular.ToString()))
                channelGroup.WaveformLayout = TdmsWaveformLayout.PairedTimeAndSampleChannels;
            else
                channelGroup.WaveformLayout = TdmsWaveformLayout.NoTimeChannel;

            // Set up the channels required for writing the waveforms. 
            // For waveforms with RegularTiming or NoTiming, we use one channel for each waveform. This channel stores the sample values. 
            // For waveforms with IrregularTiming, we use two channels for each waveform. The first channel stores the time values 
            // and the second channel stores the sample values.
            for (int i = 0; i < (int)numberOfChannelsNumericEdit.Value; i++)
            {
                if (channelGroup.WaveformLayout == TdmsWaveformLayout.PairedTimeAndSampleChannels)
                {
                    // Set up the time channel.
                    string timeChannelName = "Time Channel " + i.ToString();
                    TdmsChannel timeChannel = new TdmsChannel(timeChannelName, TdmsDataType.DateTime);
                    tdmsChannels.Add(timeChannel);
                }
                string channelName = "Waveform Channel " + i.ToString();
                waveformChannels[i] = new TdmsChannel(channelName, TdmsDataType.Double);
                tdmsChannels.Add(waveformChannels[i]);
            }
        }

        private void generateAndAppendButton_Click(object sender, EventArgs e)
        {
            generateAndAppendButton.Enabled = false;
            statusTextBox.Text = "";

            // Configure the signal
            int numberOfSamples = (int)samplesNumericEdit.Value;
            WaveformSampleIntervalMode sampleIntervalMode = (WaveformSampleIntervalMode)Enum.Parse(typeof(WaveformSampleIntervalMode), (string)sampleIntervalModeComboBox.SelectedItem);
            double frequency = frequencyNumericEdit.Value;
            double amplitude = amplitudeNumericEdit.Value;
            signal.Configure(numberOfSamples, sampleIntervalMode, frequency, amplitude);

            // Generate the data asynchronously
            dataGeneratorComponent.RunWorkerAsync((int)numberOfChannelsNumericEdit.Value);
        }

        // This method reads the data asyncronously. 
        private void dataGeneratorComponent_Read(object sender, DoWorkEventArgs e)
        {
            int numberOfChannels = (int)e.Argument;
            AnalogWaveform<double>[] generatedData = new AnalogWaveform<double>[numberOfChannels];
            WaveformTiming timing = signal.GenerateTiming();

            for (int i = 0; i < numberOfChannels; i++)
            {
                double[] data = signal.GenerateData();
                generatedData[i] = AnalogWaveform<double>.FromArray1D(data);
                generatedData[i].Timing = timing;
            }
            e.Result = generatedData;
        }

        // This method gets called after the read is completed
        private void dataGeneratorComponent_ReadCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Exception exception = e.Error;

            if (exception == null)
            {
                // Get the acquired data
                AnalogWaveform<double>[] acquiredData = e.Result as AnalogWaveform<double>[];

                try
                {
                    // Append the waveforms to the channels in the TDMS file
                    channelGroup.AppendAnalogWaveforms<double>(waveformChannels, acquiredData);
                }
                catch (Exception tdmsException)
                {
                    exception = tdmsException;
                }
            }

            // Update the status
            if(exception != null)
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                statusTextBox.Text = generateAndAppendMessage;
            generateAndAppendButton.Enabled = true;
            generateAndAppendButton.Focus();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            if (tdmsFileSaveFileDialog.ShowDialog() == DialogResult.OK)
                filePathTextBox.Text = tdmsFileSaveFileDialog.FileName;
        }

        private void TDMSFileConfiguration_Changed(object sender, EventArgs e)
        {
            if (tdmsFileSet)
            {
                if (file != null && file.IsOpen)
                    file.Close();
                file = null;
                channelGroup = null;
                waveformChannels = null;
                setUpTDMSFileButton.Enabled = true;
                generateAndAppendButton.Enabled = false;
                statusTextBox.Text = setUpTDMSFileMessage;
                tdmsFileSet = false;
            }

            numberOfChannelsNumericEdit.Value = numberOfWaveformsNumericEdit.Value;
            sampleIntervalModeTextBox.Text = (string)sampleIntervalModeComboBox.SelectedItem;

        }

        private void TdmsStreamingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (file != null && file.IsOpen)
                file.Close();
        }
    }
}