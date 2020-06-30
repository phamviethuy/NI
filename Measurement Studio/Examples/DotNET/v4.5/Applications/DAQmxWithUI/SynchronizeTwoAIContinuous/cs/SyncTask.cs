using System;
using System.Diagnostics;
using NationalInstruments.DAQmx;
using System.ComponentModel;

namespace NationalInstruments.Examples.SynchronizeTwoAIContinuous
{
    public enum SyncType
    {
        ESeries = 0,
        MSeries = 1,
        MSeriesPXI = 2,
        DsaSampleClock = 3,
        DsaReferenceClock = 4
    };

    /// <summary>
    /// This class is used for both the master and slave tasks
    /// in this example.
    ///
    /// Both the master and slave task are
    /// created, configured, and read in the same manner.
    /// The only difference is that you should call
    /// SynchronizeSlave on the slave task, and not on the
    /// master task.
    /// </summary>
    public class SyncTask
    {
        private Task myTask;
        private AnalogMultiChannelReader reader;
        private SyncType syncType;
        private System.Data.DataColumn[] dataColumn;
        private System.Data.DataTable dataTable = new System.Data.DataTable();
        private AnalogWaveform<double>[] data;
        private int _samplesPerChannel;

        /// <summary>
        /// Create the Task and name it.
        /// </summary>
        public SyncTask(string name, int sync)
        {
            myTask = new Task(name);
            reader = new AnalogMultiChannelReader(myTask.Stream);
            reader.SynchronizeCallbacks = true;
            syncType = (SyncType)sync;
        }

        /// <summary>
        /// Configure the task by creating a channel
        /// and setting up the timing.
        /// </summary>
        public void Configure(string physicalChannelName, double minimumValue, double maximumValue, int samplesPerChannel, double rate)
        {

            //
            // First, create a AI voltage channel, allowing the NI-DAQ driver to choose
            // the terminal configuration.
            //
            myTask.AIChannels.CreateVoltageChannel(physicalChannelName,
                string.Empty,
                (AITerminalConfiguration)(-1),
                minimumValue,
                maximumValue,
                AIVoltageUnits.Volts);

            //
            // Next, configure the onboard sample clock.
            //
            myTask.Timing.ConfigureSampleClock(
                string.Empty,
                rate,
                SampleClockActiveEdge.Rising,
                SampleQuantityMode.ContinuousSamples,
                samplesPerChannel);
            _samplesPerChannel = samplesPerChannel;

            myTask.Control(TaskAction.Verify);
        }

        public void SynchronizeMaster()
        {
            switch (syncType)
            {
                case SyncType.ESeries:
                    //
                    // E-Series synchronization requires no additional
                    // configuration.
                    //
                    break;
                case SyncType.MSeries:
                    //
                    // M-Series PCI synchronization
                    //
                    myTask.Timing.ReferenceClockSource = "OnboardClock";
                    break;
                case SyncType.MSeriesPXI:
                    //
                    // M-Series PXI synchronization
                    //
                    myTask.Timing.ReferenceClockSource = "PXI_Clk10";
                    myTask.Timing.ReferenceClockRate = 10000000;
                    break;
                case SyncType.DsaSampleClock:
                    //
                    // DSA Sample Clock Timebase synchronization requires no additional
                    // configuration.
                    //
                    break;
                case SyncType.DsaReferenceClock:
                    // 
                    // DSA Reference Clock synchronization
                    //
                    myTask.Timing.ReferenceClockSource = "PXI_Clk10";
                    break;
                default:
                    Debug.Assert(false, "Unknown synchronization type.");
                    break;
            }
        }

        public void SynchronizeSlave(SyncTask master)
        {
            //
            // First, verify the master task so we can query its properties.
            //
            master.Task.Control(TaskAction.Verify);

            //
            // Next, find out what device the master is using.
            // This is so we can build terminal strings using the
            // master device name.
            //
            string firstPhysChanName = master.Task.AIChannels[0].PhysicalName;
            string deviceName = firstPhysChanName.Split('/')[0];
            string terminalNameBase = "/" + deviceName + "/";

            //
            // Depending on what kind of device, synchronize accordingly
            //
            switch (syncType)
            {
                case SyncType.ESeries:
                    //
                    // E-Series synchronization
                    //
                    myTask.Timing.MasterTimebaseSource = master.Task.Timing.MasterTimebaseSource;
                    myTask.Timing.MasterTimebaseRate = master.Task.Timing.MasterTimebaseRate;
                    break;
                case SyncType.MSeries:
                    //
                    // M-Series PCI synchronization
                    //
                    myTask.Timing.ReferenceClockSource = master.Task.Timing.ReferenceClockSource;
                    myTask.Timing.ReferenceClockRate = master.Task.Timing.ReferenceClockRate;
                    break;
                case SyncType.MSeriesPXI:
                    //
                    // M-Series PXI synchronization
                    //
                    myTask.Timing.ReferenceClockSource = master.Task.Timing.ReferenceClockSource; //"PXI_Clk10";
                    myTask.Timing.ReferenceClockRate = master.Task.Timing.ReferenceClockRate; //10000000;
                    break;
                case SyncType.DsaSampleClock:
                    //
                    // DSA Sample Clock Timebase synchronization
                    //
                    myTask.Timing.SampleClockTimebaseSource = terminalNameBase + "SampleClockTimebase";
                    myTask.Timing.SynchronizationPulseSource = terminalNameBase + "SyncPulse";
                    break;
                case SyncType.DsaReferenceClock:
                    //
                    // DSA Reference Clock synchronization
                    //
                    myTask.Timing.SynchronizationPulseSource = terminalNameBase + "SyncPulse";
                    myTask.Timing.ReferenceClockSource = master.Task.Timing.ReferenceClockSource; //"PXI_Clk10";
                    break;
                default:
                    Debug.Assert(false, "Unknown synchronization type.");
                    break;
            }

            // Configure a digital edge start trigger so both tasks
            // start together.
            myTask.Triggers.StartTrigger.ConfigureDigitalEdgeTrigger(
                terminalNameBase + "ai/StartTrigger",
                DigitalEdgeStartTriggerEdge.Rising);
        }

        public void Start()
        {
            myTask.Start();
        }

        public void Dispose()
        {
            myTask.Dispose();
        }

        /// <summary>
        /// Read the data.
        /// </summary>
        public IAsyncResult BeginRead(AsyncCallback callback)
        {
            if (data == null)
            {
                data = new AnalogWaveform<double>[myTask.AIChannels.Count];
                for (int iCnt = 0; iCnt < data.GetLength(0); iCnt++)
                {
                    data[iCnt] = new AnalogWaveform<double>(_samplesPerChannel);
                }
            }
            return reader.BeginMemoryOptimizedReadWaveform(_samplesPerChannel, callback, myTask, data);
        }

        public AnalogWaveform<double>[] EndRead(IAsyncResult ar)
        {
            data = reader.EndReadWaveform(ar);
            return data;
        }

        private Task Task
        {
            get
            {
                return myTask;
            }
        }
    }
}
