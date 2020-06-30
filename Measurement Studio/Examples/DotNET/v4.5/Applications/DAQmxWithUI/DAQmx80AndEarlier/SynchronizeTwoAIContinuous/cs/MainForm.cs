/*******************************************************************************
*
* Example program:
*   SynchronizeTwoAIContinuous
*
* Category:
*   Synchronization
*
* Description:
*   This example demonstrates how to continuosly acquire analog input
*   data using two DAQ devices' internal clocks.  It also synchronizes these
*   devices depending on the device family (E Series, M Series, or DSA) to 
*   simultaneously acquire the data.
*
* Instructions for running:
*   1.  Select the synchronization type according to the devices you are using
*       for acquisition.
*   2.  Select the physical channels which correspond to where your signals are
*       input on the DAQ device.
*   3.  Enter the minimum and maximum voltage ranges for the physical channels.
*   4.  Set the number of samples to acquire per channel.
*   5.  Set the rate of the acquisition, in Hertz.
*   6.  Specify whether you want synchronization on or off.
*   7.  Turn on the acquisition.
*
* Steps:
*   1.  Create an analog input voltage channel for both the master and slave
*       devices.
*   2.  Set timing parameters for the acquisition.
*   3.  Call master.SynchronizeMaster() to configure the master device for
*       synchronization, depending on the synchronization type.
*   4.  Call slave.SynchronizeSlave(master) to configure the slave device for
*       synchronization, depending on the synchronization type.
*   5.  Start the tasks.  The slave task must be started first so that it can
*       wait on the master's start trigger.
*   6.  Read all of the analog input data from both devices.
*   7.  Dispose the Task object to clean-up any resources associated with the
*       task.
*   8.  Handle any DaqExceptions, if they occur.
*
* I/O Connections Overview:
*   Make sure your signal input terminals match the Physical Channel I/O
*   Controls.  If you have a PXI chassis, ensure that it has been properly
*   identified in MAX.  If you have devices with a RTSI bus, ensure that they
*   are connected with a RTSI cable and that the RTSI cable is registered in
*   MAX.
*
*******************************************************************************/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.Analysis.Math;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.SynchronizeTwoAIContinuous
{
    /// <summary>
    /// Application main form.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private SyncTask masterSyncTask;
        private SyncTask slaveSyncTask;

        private SyncTask runningMasterTask;
        private SyncTask runningSlaveTask;

        private IAsyncResult masterAsyncResult;
        private IAsyncResult slaveAsyncResult;

        private AsyncCallback masterCallback;
        private AsyncCallback slaveCallback;

        private int samplesPerChannel;
        private AnalogWaveform<double>[] masterData;
        private AnalogWaveform<double>[] slaveData;

        private System.Windows.Forms.GroupBox masterGroupBox;
        private System.Windows.Forms.Label masterPhysChanLabel;
        private System.Windows.Forms.Label masterMaxValLabel;
        private System.Windows.Forms.Label masterMinValLabel;
        private System.Windows.Forms.GroupBox slaveGroupBox;
        private System.Windows.Forms.Label slavePhysChanLabel;
        private System.Windows.Forms.Label slaveMaxValLabel;
        private System.Windows.Forms.Label slaveMinValLabel;
        private System.Windows.Forms.GroupBox timingGroupBox;
        private System.Windows.Forms.Label samplesPerChannelLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.ComboBox masterPhysicalChannelComboBox;
        private System.Windows.Forms.ComboBox slavePhysicalChannelComboBox;
        private System.Windows.Forms.GroupBox syncGroupBox;
        private System.Windows.Forms.Label syncTypeLabel;
        private System.Windows.Forms.ComboBox syncTypeComboBox;
        private System.Windows.Forms.Panel dataPanel;
        private NationalInstruments.UI.WaveformPlot masterWaveformPlot;
        private System.Windows.Forms.Splitter dataSplitter;
        private NationalInstruments.UI.WaveformPlot slavePlot;
        private NationalInstruments.UI.WindowsForms.NumericEdit masterMaxValNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit masterMinValNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit slaveMaxValNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit slaveMinValNumericEdit;
        private System.Windows.Forms.GroupBox runGroupBox;
        private NationalInstruments.UI.WindowsForms.Switch acquisitionSwitch;
        private System.Windows.Forms.Label acquisitionSwitchLabel;
        private System.Windows.Forms.Label acquistionOffLabel;
        private System.Windows.Forms.Label acquisitionOnLabel;
        private System.Windows.Forms.Label synchronizationOnLabel;
        private System.Windows.Forms.Label synchronizationOffLabel;
        private NationalInstruments.UI.WindowsForms.Switch synchronizationSwitch;
        private NationalInstruments.UI.WindowsForms.NumericEdit samplesPerChannelNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit rateNumericEdit;
        private NationalInstruments.UI.XAxis masterXAxis;
        private NationalInstruments.UI.YAxis masterYAxis;
        private NationalInstruments.UI.XAxis slaveXAxis;
        private NationalInstruments.UI.YAxis slaveYAxis;
        private System.Windows.Forms.Label synchronizationLabel;
        private NationalInstruments.UI.WindowsForms.WaveformGraph masterWaveformGraph;
        private NationalInstruments.UI.WindowsForms.WaveformGraph slaveWaveformGraph;
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
            // Fill the physical channel combo boxes with the analog input
            // channels in the system and choose one of the values.
            //
            masterPhysicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
            slavePhysicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External));
            if (masterPhysicalChannelComboBox.Items.Count > 0)
            {
                masterPhysicalChannelComboBox.SelectedIndex = 0;
            }
            if (slavePhysicalChannelComboBox.Items.Count > 1)
            {
                slavePhysicalChannelComboBox.SelectedIndex = 1;
            }
            else if (slavePhysicalChannelComboBox.Items.Count > 0)
            {
                slavePhysicalChannelComboBox.SelectedIndex = 0;
            }

            syncTypeComboBox.SelectedIndex = 0;
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
                if (masterSyncTask != null)
                {
                    runningMasterTask = null;
                    masterSyncTask.Dispose();
                }
                if (slaveSyncTask != null)
                {
                    runningSlaveTask = null;
                    slaveSyncTask.Dispose();
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.masterGroupBox = new System.Windows.Forms.GroupBox();
            this.masterMinValNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.masterMaxValNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.masterPhysicalChannelComboBox = new System.Windows.Forms.ComboBox();
            this.masterPhysChanLabel = new System.Windows.Forms.Label();
            this.masterMaxValLabel = new System.Windows.Forms.Label();
            this.masterMinValLabel = new System.Windows.Forms.Label();
            this.slaveGroupBox = new System.Windows.Forms.GroupBox();
            this.slaveMinValNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.slaveMaxValNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.slavePhysicalChannelComboBox = new System.Windows.Forms.ComboBox();
            this.slavePhysChanLabel = new System.Windows.Forms.Label();
            this.slaveMaxValLabel = new System.Windows.Forms.Label();
            this.slaveMinValLabel = new System.Windows.Forms.Label();
            this.timingGroupBox = new System.Windows.Forms.GroupBox();
            this.rateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.samplesPerChannelNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.samplesPerChannelLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.syncGroupBox = new System.Windows.Forms.GroupBox();
            this.syncTypeLabel = new System.Windows.Forms.Label();
            this.syncTypeComboBox = new System.Windows.Forms.ComboBox();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.slaveWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.slavePlot = new NationalInstruments.UI.WaveformPlot();
            this.slaveXAxis = new NationalInstruments.UI.XAxis();
            this.slaveYAxis = new NationalInstruments.UI.YAxis();
            this.dataSplitter = new System.Windows.Forms.Splitter();
            this.masterWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.masterWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.masterXAxis = new NationalInstruments.UI.XAxis();
            this.masterYAxis = new NationalInstruments.UI.YAxis();
            this.runGroupBox = new System.Windows.Forms.GroupBox();
            this.synchronizationOnLabel = new System.Windows.Forms.Label();
            this.synchronizationOffLabel = new System.Windows.Forms.Label();
            this.synchronizationLabel = new System.Windows.Forms.Label();
            this.synchronizationSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.acquisitionOnLabel = new System.Windows.Forms.Label();
            this.acquistionOffLabel = new System.Windows.Forms.Label();
            this.acquisitionSwitchLabel = new System.Windows.Forms.Label();
            this.acquisitionSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.masterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterMinValNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterMaxValNumericEdit)).BeginInit();
            this.slaveGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slaveMinValNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaveMaxValNumericEdit)).BeginInit();
            this.timingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesPerChannelNumericEdit)).BeginInit();
            this.syncGroupBox.SuspendLayout();
            this.dataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slaveWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterWaveformGraph)).BeginInit();
            this.runGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.synchronizationSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // masterGroupBox
            // 
            this.masterGroupBox.Controls.Add(this.masterMinValNumericEdit);
            this.masterGroupBox.Controls.Add(this.masterMaxValNumericEdit);
            this.masterGroupBox.Controls.Add(this.masterPhysicalChannelComboBox);
            this.masterGroupBox.Controls.Add(this.masterPhysChanLabel);
            this.masterGroupBox.Controls.Add(this.masterMaxValLabel);
            this.masterGroupBox.Controls.Add(this.masterMinValLabel);
            this.masterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.masterGroupBox.Location = new System.Drawing.Point(8, 72);
            this.masterGroupBox.Name = "masterGroupBox";
            this.masterGroupBox.Size = new System.Drawing.Size(336, 120);
            this.masterGroupBox.TabIndex = 1;
            this.masterGroupBox.TabStop = false;
            this.masterGroupBox.Text = "Channel Parameters - Master";
            // 
            // masterMinValNumericEdit
            // 
            this.masterMinValNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.masterMinValNumericEdit.Location = new System.Drawing.Point(152, 88);
            this.masterMinValNumericEdit.Name = "masterMinValNumericEdit";
            this.masterMinValNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.masterMinValNumericEdit.Size = new System.Drawing.Size(168, 20);
            this.masterMinValNumericEdit.TabIndex = 4;
            this.masterMinValNumericEdit.Value = -10;
            // 
            // masterMaxValNumericEdit
            // 
            this.masterMaxValNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.masterMaxValNumericEdit.Location = new System.Drawing.Point(152, 56);
            this.masterMaxValNumericEdit.Name = "masterMaxValNumericEdit";
            this.masterMaxValNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.masterMaxValNumericEdit.Size = new System.Drawing.Size(168, 20);
            this.masterMaxValNumericEdit.TabIndex = 3;
            this.masterMaxValNumericEdit.Value = 10;
            // 
            // masterPhysicalChannelComboBox
            // 
            this.masterPhysicalChannelComboBox.Location = new System.Drawing.Point(152, 24);
            this.masterPhysicalChannelComboBox.Name = "masterPhysicalChannelComboBox";
            this.masterPhysicalChannelComboBox.Size = new System.Drawing.Size(168, 21);
            this.masterPhysicalChannelComboBox.TabIndex = 2;
            this.masterPhysicalChannelComboBox.Text = "Dev1/ai0";
            // 
            // masterPhysChanLabel
            // 
            this.masterPhysChanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.masterPhysChanLabel.Location = new System.Drawing.Point(16, 24);
            this.masterPhysChanLabel.Name = "masterPhysChanLabel";
            this.masterPhysChanLabel.Size = new System.Drawing.Size(96, 16);
            this.masterPhysChanLabel.TabIndex = 0;
            this.masterPhysChanLabel.Text = "Physical Channel:";
            // 
            // masterMaxValLabel
            // 
            this.masterMaxValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.masterMaxValLabel.Location = new System.Drawing.Point(16, 56);
            this.masterMaxValLabel.Name = "masterMaxValLabel";
            this.masterMaxValLabel.Size = new System.Drawing.Size(96, 16);
            this.masterMaxValLabel.TabIndex = 2;
            this.masterMaxValLabel.Text = "Maximum Value:";
            // 
            // masterMinValLabel
            // 
            this.masterMinValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.masterMinValLabel.Location = new System.Drawing.Point(16, 88);
            this.masterMinValLabel.Name = "masterMinValLabel";
            this.masterMinValLabel.Size = new System.Drawing.Size(96, 16);
            this.masterMinValLabel.TabIndex = 4;
            this.masterMinValLabel.Text = "Minimum Value:";
            // 
            // slaveGroupBox
            // 
            this.slaveGroupBox.Controls.Add(this.slaveMinValNumericEdit);
            this.slaveGroupBox.Controls.Add(this.slaveMaxValNumericEdit);
            this.slaveGroupBox.Controls.Add(this.slavePhysicalChannelComboBox);
            this.slaveGroupBox.Controls.Add(this.slavePhysChanLabel);
            this.slaveGroupBox.Controls.Add(this.slaveMaxValLabel);
            this.slaveGroupBox.Controls.Add(this.slaveMinValLabel);
            this.slaveGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slaveGroupBox.Location = new System.Drawing.Point(8, 200);
            this.slaveGroupBox.Name = "slaveGroupBox";
            this.slaveGroupBox.Size = new System.Drawing.Size(336, 120);
            this.slaveGroupBox.TabIndex = 2;
            this.slaveGroupBox.TabStop = false;
            this.slaveGroupBox.Text = "Channel Parameters - Slave";
            // 
            // slaveMinValNumericEdit
            // 
            this.slaveMinValNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.slaveMinValNumericEdit.Location = new System.Drawing.Point(152, 88);
            this.slaveMinValNumericEdit.Name = "slaveMinValNumericEdit";
            this.slaveMinValNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.slaveMinValNumericEdit.Size = new System.Drawing.Size(168, 20);
            this.slaveMinValNumericEdit.TabIndex = 7;
            this.slaveMinValNumericEdit.Value = -10;
            // 
            // slaveMaxValNumericEdit
            // 
            this.slaveMaxValNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.slaveMaxValNumericEdit.Location = new System.Drawing.Point(152, 56);
            this.slaveMaxValNumericEdit.Name = "slaveMaxValNumericEdit";
            this.slaveMaxValNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.slaveMaxValNumericEdit.Size = new System.Drawing.Size(168, 20);
            this.slaveMaxValNumericEdit.TabIndex = 6;
            this.slaveMaxValNumericEdit.Value = 10;
            // 
            // slavePhysicalChannelComboBox
            // 
            this.slavePhysicalChannelComboBox.Location = new System.Drawing.Point(152, 24);
            this.slavePhysicalChannelComboBox.Name = "slavePhysicalChannelComboBox";
            this.slavePhysicalChannelComboBox.Size = new System.Drawing.Size(168, 21);
            this.slavePhysicalChannelComboBox.TabIndex = 5;
            this.slavePhysicalChannelComboBox.Text = "Dev2/ai0";
            // 
            // slavePhysChanLabel
            // 
            this.slavePhysChanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slavePhysChanLabel.Location = new System.Drawing.Point(16, 24);
            this.slavePhysChanLabel.Name = "slavePhysChanLabel";
            this.slavePhysChanLabel.Size = new System.Drawing.Size(96, 16);
            this.slavePhysChanLabel.TabIndex = 0;
            this.slavePhysChanLabel.Text = "Physical Channel:";
            // 
            // slaveMaxValLabel
            // 
            this.slaveMaxValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slaveMaxValLabel.Location = new System.Drawing.Point(16, 56);
            this.slaveMaxValLabel.Name = "slaveMaxValLabel";
            this.slaveMaxValLabel.Size = new System.Drawing.Size(96, 16);
            this.slaveMaxValLabel.TabIndex = 2;
            this.slaveMaxValLabel.Text = "Maximum Value:";
            // 
            // slaveMinValLabel
            // 
            this.slaveMinValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slaveMinValLabel.Location = new System.Drawing.Point(16, 88);
            this.slaveMinValLabel.Name = "slaveMinValLabel";
            this.slaveMinValLabel.Size = new System.Drawing.Size(96, 16);
            this.slaveMinValLabel.TabIndex = 4;
            this.slaveMinValLabel.Text = "Minimum Value:";
            // 
            // timingGroupBox
            // 
            this.timingGroupBox.Controls.Add(this.rateNumericEdit);
            this.timingGroupBox.Controls.Add(this.samplesPerChannelNumericEdit);
            this.timingGroupBox.Controls.Add(this.samplesPerChannelLabel);
            this.timingGroupBox.Controls.Add(this.rateLabel);
            this.timingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timingGroupBox.Location = new System.Drawing.Point(8, 328);
            this.timingGroupBox.Name = "timingGroupBox";
            this.timingGroupBox.Size = new System.Drawing.Size(336, 88);
            this.timingGroupBox.TabIndex = 3;
            this.timingGroupBox.TabStop = false;
            this.timingGroupBox.Text = "Timing Parameters";
            // 
            // rateNumericEdit
            // 
            this.rateNumericEdit.CoercionInterval = 100;
            this.rateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.rateNumericEdit.Location = new System.Drawing.Point(152, 56);
            this.rateNumericEdit.Name = "rateNumericEdit";
            this.rateNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.rateNumericEdit.Size = new System.Drawing.Size(168, 20);
            this.rateNumericEdit.TabIndex = 9;
            this.rateNumericEdit.Value = 1000;
            // 
            // samplesPerChannelNumericEdit
            // 
            this.samplesPerChannelNumericEdit.CoercionInterval = 10;
            this.samplesPerChannelNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.samplesPerChannelNumericEdit.Location = new System.Drawing.Point(152, 24);
            this.samplesPerChannelNumericEdit.Name = "samplesPerChannelNumericEdit";
            this.samplesPerChannelNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.samplesPerChannelNumericEdit.Size = new System.Drawing.Size(168, 20);
            this.samplesPerChannelNumericEdit.TabIndex = 8;
            this.samplesPerChannelNumericEdit.Value = 200;
            // 
            // samplesPerChannelLabel
            // 
            this.samplesPerChannelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplesPerChannelLabel.Location = new System.Drawing.Point(16, 24);
            this.samplesPerChannelLabel.Name = "samplesPerChannelLabel";
            this.samplesPerChannelLabel.Size = new System.Drawing.Size(120, 16);
            this.samplesPerChannelLabel.TabIndex = 0;
            this.samplesPerChannelLabel.Text = "Samples Per Channel:";
            // 
            // rateLabel
            // 
            this.rateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rateLabel.Location = new System.Drawing.Point(16, 56);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(96, 16);
            this.rateLabel.TabIndex = 2;
            this.rateLabel.Text = "Rate (Hz):";
            // 
            // syncGroupBox
            // 
            this.syncGroupBox.Controls.Add(this.syncTypeLabel);
            this.syncGroupBox.Controls.Add(this.syncTypeComboBox);
            this.syncGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.syncGroupBox.Location = new System.Drawing.Point(8, 8);
            this.syncGroupBox.Name = "syncGroupBox";
            this.syncGroupBox.Size = new System.Drawing.Size(336, 56);
            this.syncGroupBox.TabIndex = 0;
            this.syncGroupBox.TabStop = false;
            this.syncGroupBox.Text = "Synchronization Parameters";
            // 
            // syncTypeLabel
            // 
            this.syncTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.syncTypeLabel.Location = new System.Drawing.Point(16, 24);
            this.syncTypeLabel.Name = "syncTypeLabel";
            this.syncTypeLabel.Size = new System.Drawing.Size(120, 16);
            this.syncTypeLabel.TabIndex = 0;
            this.syncTypeLabel.Text = "Synchronization Type:";
            // 
            // syncTypeComboBox
            // 
            this.syncTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.syncTypeComboBox.Items.AddRange(new object[] {
            "E-Series",
            "M-Series (PCI)",
            "M-Series (PXI)",
            "DSA Sample Clock Timebase",
            "DSA Reference Clock"});
            this.syncTypeComboBox.Location = new System.Drawing.Point(152, 22);
            this.syncTypeComboBox.Name = "syncTypeComboBox";
            this.syncTypeComboBox.Size = new System.Drawing.Size(168, 21);
            this.syncTypeComboBox.TabIndex = 1;
            // 
            // dataPanel
            // 
            this.dataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataPanel.Controls.Add(this.slaveWaveformGraph);
            this.dataPanel.Controls.Add(this.dataSplitter);
            this.dataPanel.Controls.Add(this.masterWaveformGraph);
            this.dataPanel.Location = new System.Drawing.Point(360, 8);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(480, 496);
            this.dataPanel.TabIndex = 5;
            // 
            // slaveWaveformGraph
            // 
            this.slaveWaveformGraph.Caption = "Slave";
            this.slaveWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slaveWaveformGraph.Location = new System.Drawing.Point(0, 251);
            this.slaveWaveformGraph.Name = "slaveWaveformGraph";
            this.slaveWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.slavePlot});
            this.slaveWaveformGraph.Size = new System.Drawing.Size(480, 245);
            this.slaveWaveformGraph.TabIndex = 13;
            this.slaveWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.slaveXAxis});
            this.slaveWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.slaveYAxis});
            // 
            // slavePlot
            // 
            this.slavePlot.XAxis = this.slaveXAxis;
            this.slavePlot.YAxis = this.slaveYAxis;
            // 
            // dataSplitter
            // 
            this.dataSplitter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dataSplitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataSplitter.Location = new System.Drawing.Point(0, 246);
            this.dataSplitter.Name = "dataSplitter";
            this.dataSplitter.Size = new System.Drawing.Size(480, 5);
            this.dataSplitter.TabIndex = 1;
            this.dataSplitter.TabStop = false;
            // 
            // masterWaveformGraph
            // 
            this.masterWaveformGraph.Caption = "Master";
            this.masterWaveformGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.masterWaveformGraph.Location = new System.Drawing.Point(0, 0);
            this.masterWaveformGraph.Name = "masterWaveformGraph";
            this.masterWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.masterWaveformPlot});
            this.masterWaveformGraph.Size = new System.Drawing.Size(480, 246);
            this.masterWaveformGraph.TabIndex = 12;
            this.masterWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.masterXAxis});
            this.masterWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.masterYAxis});
            // 
            // masterWaveformPlot
            // 
            this.masterWaveformPlot.XAxis = this.masterXAxis;
            this.masterWaveformPlot.YAxis = this.masterYAxis;
            // 
            // runGroupBox
            // 
            this.runGroupBox.Controls.Add(this.synchronizationOnLabel);
            this.runGroupBox.Controls.Add(this.synchronizationOffLabel);
            this.runGroupBox.Controls.Add(this.synchronizationLabel);
            this.runGroupBox.Controls.Add(this.synchronizationSwitch);
            this.runGroupBox.Controls.Add(this.acquisitionOnLabel);
            this.runGroupBox.Controls.Add(this.acquistionOffLabel);
            this.runGroupBox.Controls.Add(this.acquisitionSwitchLabel);
            this.runGroupBox.Controls.Add(this.acquisitionSwitch);
            this.runGroupBox.Location = new System.Drawing.Point(8, 424);
            this.runGroupBox.Name = "runGroupBox";
            this.runGroupBox.Size = new System.Drawing.Size(336, 80);
            this.runGroupBox.TabIndex = 6;
            this.runGroupBox.TabStop = false;
            this.runGroupBox.Text = "Run";
            // 
            // synchronizationOnLabel
            // 
            this.synchronizationOnLabel.Location = new System.Drawing.Point(180, 45);
            this.synchronizationOnLabel.Name = "synchronizationOnLabel";
            this.synchronizationOnLabel.Size = new System.Drawing.Size(24, 23);
            this.synchronizationOnLabel.TabIndex = 0;
            this.synchronizationOnLabel.Text = "On";
            this.synchronizationOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // synchronizationOffLabel
            // 
            this.synchronizationOffLabel.Location = new System.Drawing.Point(288, 45);
            this.synchronizationOffLabel.Name = "synchronizationOffLabel";
            this.synchronizationOffLabel.Size = new System.Drawing.Size(24, 23);
            this.synchronizationOffLabel.TabIndex = 0;
            this.synchronizationOffLabel.Text = "Off";
            this.synchronizationOffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // synchronizationLabel
            // 
            this.synchronizationLabel.Location = new System.Drawing.Point(194, 16);
            this.synchronizationLabel.Name = "synchronizationLabel";
            this.synchronizationLabel.TabIndex = 0;
            this.synchronizationLabel.Text = "Synchronization:";
            this.synchronizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // synchronizationSwitch
            // 
            this.synchronizationSwitch.Location = new System.Drawing.Point(212, 40);
            this.synchronizationSwitch.Name = "synchronizationSwitch";
            this.synchronizationSwitch.Size = new System.Drawing.Size(64, 32);
            this.synchronizationSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalSlide;
            this.synchronizationSwitch.TabIndex = 11;
            // 
            // acquisitionOnLabel
            // 
            this.acquisitionOnLabel.Location = new System.Drawing.Point(24, 45);
            this.acquisitionOnLabel.Name = "acquisitionOnLabel";
            this.acquisitionOnLabel.Size = new System.Drawing.Size(24, 23);
            this.acquisitionOnLabel.TabIndex = 0;
            this.acquisitionOnLabel.Text = "On";
            this.acquisitionOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acquistionOffLabel
            // 
            this.acquistionOffLabel.Location = new System.Drawing.Point(132, 45);
            this.acquistionOffLabel.Name = "acquistionOffLabel";
            this.acquistionOffLabel.Size = new System.Drawing.Size(24, 23);
            this.acquistionOffLabel.TabIndex = 0;
            this.acquistionOffLabel.Text = "Off";
            this.acquistionOffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // acquisitionSwitchLabel
            // 
            this.acquisitionSwitchLabel.Location = new System.Drawing.Point(42, 16);
            this.acquisitionSwitchLabel.Name = "acquisitionSwitchLabel";
            this.acquisitionSwitchLabel.TabIndex = 0;
            this.acquisitionSwitchLabel.Text = "Acquistion:";
            this.acquisitionSwitchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acquisitionSwitch
            // 
            this.acquisitionSwitch.Location = new System.Drawing.Point(60, 40);
            this.acquisitionSwitch.Name = "acquisitionSwitch";
            this.acquisitionSwitch.Size = new System.Drawing.Size(64, 32);
            this.acquisitionSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalSlide;
            this.acquisitionSwitch.TabIndex = 10;
            this.acquisitionSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.acquisitionSwitch_StateChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(840, 509);
            this.Controls.Add(this.runGroupBox);
            this.Controls.Add(this.dataPanel);
            this.Controls.Add(this.syncGroupBox);
            this.Controls.Add(this.slaveGroupBox);
            this.Controls.Add(this.masterGroupBox);
            this.Controls.Add(this.timingGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Synchronize Two Analog Acquisition Boards";
            this.masterGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterMinValNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterMaxValNumericEdit)).EndInit();
            this.slaveGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slaveMinValNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaveMaxValNumericEdit)).EndInit();
            this.timingGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rateNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplesPerChannelNumericEdit)).EndInit();
            this.syncGroupBox.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slaveWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterWaveformGraph)).EndInit();
            this.runGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.synchronizationSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquisitionSwitch)).EndInit();
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

        private void acquisitionSwitch_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            if (acquisitionSwitch.Value)
            {
                acquisitionSwitch.Value = StartAcquisition();
            }
            else
            {
                StopAcquisition();
            }
            SetControlEnableStateForAcquisition(!acquisitionSwitch.Value);
        }

        private bool StartAcquisition()
        {
            //
            // Change the mouse to an hourglass for the duration of this function.
            //
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
            masterWaveformGraph.ClearData();
            slaveWaveformGraph.ClearData();
            bool success = false;

            try
            {
                //
                // Note: This example uses the SyncTask helper class
                // that extends the Task class from the DAQmx API.
                // See the SyncTask.cs file in this example for the
                // implementation of the SyncTask class.
                //

                //
                // Configure both tasks with the values selected on the UI.
                //
                samplesPerChannel = Convert.ToInt32(samplesPerChannelNumericEdit.Value);

                //
                // Create the master and slave tasks
                //
                masterSyncTask = new SyncTask("master", syncTypeComboBox.SelectedIndex);
                runningMasterTask = masterSyncTask;
                masterSyncTask.Configure(masterPhysicalChannelComboBox.Text, masterMinValNumericEdit.Value,
                    masterMaxValNumericEdit.Value, samplesPerChannel, rateNumericEdit.Value);

                slaveSyncTask = new SyncTask("slave", syncTypeComboBox.SelectedIndex);
                runningSlaveTask = slaveSyncTask;
                slaveSyncTask.Configure(slavePhysicalChannelComboBox.Text, slaveMinValNumericEdit.Value,
                    slaveMaxValNumericEdit.Value, samplesPerChannel, rateNumericEdit.Value);
                if (synchronizationSwitch.Value)
                {
                    masterSyncTask.SynchronizeMaster();
                    masterCallback = new AsyncCallback(SynchronizedAnalogInCallback);
                    slaveSyncTask.SynchronizeSlave(masterSyncTask);
                    slaveCallback = null;
                }
                else
                {
                    masterCallback = new AsyncCallback(MasterAnalogInCallback);
                    slaveCallback = new AsyncCallback(SlaveAnalogInCallback);
                }

                // 
                // Start the slave acquisition first so that it can wait on the master.
                //
                slaveSyncTask.Start();
                masterSyncTask.Start();

                slaveAsyncResult = slaveSyncTask.BeginRead(slaveCallback);
                masterAsyncResult = masterSyncTask.BeginRead(masterCallback);
                success = true;
            }
            catch (DaqException exception)
            {
                MessageBox.Show(exception.Message, "Error");
                StopAcquisition();
                success = false;
            }

            return success;
        }

        private void StopAcquisition()
        {
            //
            // Change the mouse to an hourglass for the duration of this function.
            //
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;

            if (masterSyncTask != null)
            {
                runningMasterTask = null;
                masterSyncTask.Dispose();
            }
            if (slaveSyncTask != null)
            {
                runningSlaveTask = null;
                slaveSyncTask.Dispose();
            }
            SetControlEnableStateForAcquisition(true);
            acquisitionSwitch.Value = false;
        }

        private void MasterAnalogInCallback(IAsyncResult asyncResult)
        {
            try
            {
                if (runningMasterTask != null && masterAsyncResult.AsyncState == asyncResult.AsyncState)
                {
                    masterData = masterSyncTask.EndRead(masterAsyncResult);
                    //
                    // The syncTask instance specifies which graph to plot to.
                    //
                    masterWaveformGraph.PlotWaveformsAppend(masterData);
                    //
                    // Start another read operation.
                    //
                    masterSyncTask.BeginRead(masterCallback);
                }
            }
            catch (DaqException exception)
            {
                //
                // If anything fails, shut the entire system down.
                //
                MessageBox.Show(exception.Message, "Error");
                StopAcquisition();
            }
        }
        private void SlaveAnalogInCallback(IAsyncResult asyncResult)
        {
            try
            {
                if (runningSlaveTask != null && slaveAsyncResult.AsyncState == asyncResult.AsyncState)
                {
                    slaveData = slaveSyncTask.EndRead(slaveAsyncResult);
                    slaveWaveformGraph.PlotWaveformsAppend(slaveData);
                    //
                    // Start another read operation.
                    //
                    slaveSyncTask.BeginRead(slaveCallback);
                }

            }
            catch (DaqException exception)
            {
                //
                // If anything fails, shut the entire system down.
                //
                MessageBox.Show(exception.Message, "Error");
                StopAcquisition();
            }
        }

        private void SynchronizedAnalogInCallback(IAsyncResult asyncResult)
        {
            if (runningMasterTask == null || runningSlaveTask == null)
                return;
            try
            {
                //
                // Get the data from both readers. This is always safe only 
                // because we configured this callback to be invoked on the
                // same thread from which we began the reads. If we allow
                // the DAQmx library to invoke the callbacks on any thread,
                // we must handle the case where the master task read can 
                // finish before the slave task read begins.
                //
                masterData = masterSyncTask.EndRead(masterAsyncResult);
                slaveData = slaveSyncTask.EndRead(slaveAsyncResult);
                masterWaveformGraph.PlotWaveformsAppend(masterData);
                slaveWaveformGraph.PlotWaveformsAppend(slaveData);
                //
                // Start another pair of read operations.
                //
                slaveAsyncResult = slaveSyncTask.BeginRead(slaveCallback);
                masterAsyncResult = masterSyncTask.BeginRead(masterCallback);
            }
            catch (DaqException exception)
            {
                //
                // If anything fails, shut the entire system down.
                //
                MessageBox.Show(exception.Message, "Error");
                StopAcquisition();
            }
        }

        private void SetControlEnableStateForAcquisition(bool enable)
        {
            //
            // Enable or disable all controls except the graphs and the 
            // the acquisition button.
            //
            foreach (Control control in Controls)
            {
                if (!(control == dataPanel) && !(control == runGroupBox))
                {
                    control.Enabled = enable;
                }
            }

            synchronizationSwitch.Enabled = enable;
        }
    }
}
