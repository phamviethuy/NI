/*******************************************************************************
*
* Example program:
*   Power Vs Time Zero Span
*
* Category:
*   NI-RFSA
*
* Description:
*   Use this example to learn how to acquire I/Q data using the RF vector signal analyzer. 
*   The example shows how to configure NI-RFSA for continuous I/Q acquisition,
*   how to set the carrier frequency and the I/Q rate, and how to fetch I/Q data. 
*   The dBm calculation is applied to I/Q magnitude to produce signal power and display it on the graph.
*
* Instructions for running:
*   1. Configure RFSA device in the MAX for the program to run. 
*
*	2. Configure the Reference Level in the UI. 
*		The reference level represents the maximum expected power of an input RF signal.
*
*	3. Configure the Carrier Frequency in the UI.
*
*	4. COnfigure the IQ Rate and the Samples to Read Per Block in the UI.
*
*	5. Select Start Button for RFSA to start acquiring the data and display a graph of Signal Power Vs Time in the UI.
*		Select RMS for Root Mean Square Power and Peak for the Peak Power in the Graph.
*
*	6. Use the Stop Button to stop the acquisition.
*		
* I/O Connections Overview:
*   Make sure your signal input terminals match the Physical Channel I/O
*   Controls.  If you have a PXI chassis, ensure that it has been properly
*   identified in MAX.  
*
*******************************************************************************/
using System;
using System.Windows.Forms;
using NationalInstruments.ModularInstruments.NIRfsa;
using NationalInstruments.ModularInstruments.SystemServices.DeviceServices;

namespace NationalInstruments.Examples.PowerVsTimeZeroSpan
{
    public partial class MainForm : Form
    {
        NIRfsa rfsaSession;
        ComplexDouble[] iqData;
        double[] powerVsTimeData;
        RfsaWaveformInfo waveformInfo;
       
        const int DefaultNumberOfSamples = 100000;
        const double DefaultFetchTimeSpan = 10.0;
        const double MinimumPowerLevel = 0.00000001;
        const double RMSScaleFactor = 1.0;
        const double DefaultImpedance = 50.0; // for Calculating Power.
        const double ConversionRateWattsToMilliWatts = 1000.0;
        const int BelToDecibelConstant = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadRfsaDeviceNames()
        {
            //
            // Populate the ResourceComboBox with all the Resource Name of type NI-RFSA in the system.
            // The Device Names are the names of RFSA configured in MAX.
            //

            ModularInstrumentsSystem modularInstrumentsSystem = new ModularInstrumentsSystem("NI-RFSA");
            foreach (DeviceInfo device in modularInstrumentsSystem.DeviceCollection)
                resourceNameComboBox.Items.Add(device.Name);
            if (modularInstrumentsSystem.DeviceCollection.Count > 0)
                resourceNameComboBox.SelectedIndex = 0;
            else
            {
                ShowError("No RFSA Resource Found. Configure RFSA Device in MAX." + Environment.NewLine + "The Application will exit.");
                this.Close();
            }
        }

        #region Values from UI

        private string RFSAResourceName
        {
            get
            {
                return this.resourceNameComboBox.Text;
            }
        }

        private double ReferenceLevel
        {
            get
            {
                return this.referenceLevelNumeric.Value;
            }
        }

        private double CarrierFrequency
        {
            get
            {
                return this.carrierFrequencyNumeric.Value;
            }
        }

        private double IQRate
        {
            get
            {
                return this.iqRateNumeric.Value;
            }
        }

        private int NumberOfSamples
        {
            get
            {
                return Convert.ToInt32(this.samplesPerBlockNumeric.Value);
            }
        }

        private bool PeakScaling
        {
            get
            {
                return peakRadioButton.Checked;
            }
        }

        #endregion

        private void OnStartButtonClick(object sender, System.EventArgs e)
        {
            // Steps:
            // 1. Change all the controls on the UI to Disable State except the Stop Button.
            // 2. Initialize the RFSA Session.
            // 3. Configure the various properties in RFSA for the IQ Acquisition.
            // 4. Initiate the Acquisition.
            // 5. Enable the timer so that the Acquisition is done after every particular interval configured.

            // In-Case of the error Catch the Exception raised and Display it.
            // Close the RFSA Session and reset the UI Controls to Enabled Sate.
            try
            {
                ChangeControlState(false);
                InitializeRfsaSession();
                ConfigureForIQ();
                InitiateAcquisition();
                this.timer.Enabled = true;
            }
            catch (System.Exception ex)
            {
                ShowError(ex.Message);
                CloseSession();
                ChangeControlState(true);
            }
        }

        private static void ShowError(string message)
        {
            MessageBox.Show(message, "Error");
        }

        private void ChangeControlState(bool state)
        {
            this.resourceNameComboBox.Enabled = state;
            this.referenceLevelNumeric.Enabled = state;
            this.carrierFrequencyNumeric.Enabled = state;
            this.iqRateNumeric.Enabled = state;
            this.startButton.Enabled = state;
            this.samplesPerBlockNumeric.Enabled = state;
            this.stopButton.Enabled = !state;
        }

        private void OnStopButtonClick(object sender, System.EventArgs e)
        {
            //
            // Stop the timer and Change the Controls State to Enable and finally Close the Session.
            //
            this.timer.Enabled = false;
            ChangeControlState(true);
            CloseSession();
        }

        private void OnTimerTick(object sender, System.EventArgs e)
        {
            //
            // On each timer tick perform the steps in PowerVsTime method.
            //
            PowerVsTime();
        }

        private void InitializeRfsaSession()
        {
            //
            // Close the Session if already Open.
            // Initialize the RFSA Session and subscribe for the Warnings from the Driver.
            //
            CloseSession();
            rfsaSession = new NIRfsa(RFSAResourceName, true, false);
            rfsaSession.DriverOperation.Warning += new System.EventHandler<RfsaWarningEventArgs>(DriverOperationWarning);
        }

        //
        // Handles the Warnings raised from the Driver.
        //
        private void DriverOperationWarning(object sender, RfsaWarningEventArgs e)
        {
            MessageBox.Show(e.Warning.ToString(), "Warning");
        }

        private void ConfigureForIQ()
        {
            // Configure the reference level.
            // Configure the acquisition type to I/Q.
            // Configure the carrier frequency.
            // Configure the Number Of Samples and Number of Samples Finite to False.
            // Configure the I/Q rate.
            // Configure the NI-RFSA device for a continuous acquisition.
            rfsaSession.Configuration.Vertical.ReferenceLevel = ReferenceLevel;
            rfsaSession.Configuration.AcquisitionType = RfsaAcquisitionType.IQ;
            rfsaSession.Configuration.IQ.CarrierFrequency = CarrierFrequency;
            rfsaSession.Configuration.IQ.NumberOfSamples = DefaultNumberOfSamples;
            rfsaSession.Configuration.IQ.NumberOfSamplesIsFinite = false;
            rfsaSession.Configuration.IQ.IQRate = IQRate;
        }

        //
        // Initiate the Acquisition.
        //
        private void InitiateAcquisition()
        {
            rfsaSession.Acquisition.IQ.Initiate();
        }

        //
        // This method is called every time the timer expires. The method performs following operations
        // 1. It fetch the IQ data from the device.
        // 2. Perform neccessary calculations and converts the data in to the Power Vs Time data.
        // 3. Plots the data in the form of a Waveform Graph on the UI.
        private void PowerVsTime()
        {
            double scaleFactor;
            double mean;

            if (PeakScaling)
            {
                // Case of Peak Scaling being "PEAK"
                scaleFactor = System.Math.Sqrt(2.0);
            }
            else
            {
                // Case of Peak Scaling being "RMS"
                scaleFactor = RMSScaleFactor;
            }

            PrecisionTimeSpan timespan = new PrecisionTimeSpan(DefaultFetchTimeSpan);
            iqData = rfsaSession.Acquisition.IQ.FetchIQSingleRecordComplex<ComplexDouble>(0, NumberOfSamples, timespan, out waveformInfo);
            powerVsTimeData = new double[NumberOfSamples];
            double sum = 0.0;
            for (int index = 0; index < NumberOfSamples; ++index)
            {
                powerVsTimeData[index] = Math.Sqrt(Math.Pow(iqData[index].Imaginary, 2) + Math.Pow(iqData[index].Real, 2));
                /* Handle this because log(0) return a error. */ 
                if (powerVsTimeData[index] == 0.0)
                {
                    powerVsTimeData[index] = MinimumPowerLevel;
                }
                powerVsTimeData[index] = BelToDecibelConstant * Math.Log10(Math.Pow(powerVsTimeData[index] / scaleFactor, 2.0) * ConversionRateWattsToMilliWatts / DefaultImpedance);
                sum += powerVsTimeData[index];
            }

            mean = sum / NumberOfSamples;
            this.meanPowerTextBox.Text = mean.ToString();
            powerVsTimeWaveformGraph.PlotY(powerVsTimeData, waveformInfo.RelativeInitialX, waveformInfo.XIncrement);
        }

        private void CloseSession()
        {
            // Closes the Rfsa Session.
            if (rfsaSession != null)
            {
                try
                {
                    rfsaSession.Close();
                    rfsaSession = null;
                }
                catch (Exception ex)
                {
                    ShowError("Unable to Close Session, Reset the device.\n" + "Error : " + ex.Message);
                    Application.Exit();
                }
            }
        }

        private void OnMainFormLoad(object sender, EventArgs e)
        {
            LoadRfsaDeviceNames();
        } 
    }
}