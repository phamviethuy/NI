''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
'
' Example program:
'   SynchronizeTwoAIContinuous
'
' Category:
'   Synchronization
'
' Description:
'   This example demonstrates how to continuosly acquire analog input
'   data using two DAQ devices' internal clocks.  It also synchronizes these
'   devices depending on the device family (E Series, M Series, or DSA) to 
'   simultaneously acquire the data.
'
' Instructions for running:
'   1.  Select the synchronization type according to the devices you are using
'       for acquisition.
'   2.  Select the physical channels which correspond to where your signals are
'       input on the DAQ device.
'   3.  Enter the minimum and maximum voltage ranges for the physical channels.
'   4.  Set the number of samples to acquire per channel.
'   5.  Set the rate of the acquisition, in Hertz.
'   6.  Specify whether you want synchronization on or off.
'   7.  Turn on the acquisition.
'
' Steps:
'   1.  Create an analog input voltage channel for both the master and slave
'       devices.
'   2.  Set timing parameters for the acquisition.
'   3.  Call master.SynchronizeMaster() to configure the master device for
'       synchronization, depending on the synchronization type.
'   4.  Call slave.SynchronizeSlave(master) to configure the slave device for
'       synchronization, depending on the synchronization type.
'   5.  Start the tasks.  The slave task must be started first so that it can
'       wait on the master's start trigger.
'   6.  Read all of the analog input data from both devices.
'   7.  Dispose the Task object to clean-up any resources associated with the
'       task.
'   8.  Handle any DaqExceptions, if they occur.
'
' I/O Connections Overview:
'   Make sure your signal input terminals match the Physical Channel I/O
'   Controls.  If you have a PXI chassis, ensure that it has been properly
'   identified in MAX.  If you have devices with a RTSI bus, ensure that they
'   are connected with a RTSI cable and that the RTSI cable is registered in
'   MAX.
'
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Imports NationalInstruments
Imports NationalInstruments.Analysis.Math
Imports NationalInstruments.DAQmx
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Namespace NationalInstruments.Examples.SynchronizeTwoAIContinuous
    Public Class MainForm
        Inherits System.Windows.Forms.Form

        Private masterSyncTask As SyncTask
        Private slaveSyncTask As SyncTask
        Private runningMasterTask As SyncTask
        Private runningSlaveTask As SyncTask
        Private masterAsyncResult As IAsyncResult
        Private slaveAsyncResult As IAsyncResult
        Private masterCallback As AsyncCallback
        Private slaveCallback As AsyncCallback
        Private samples As Integer
        Private masterData As AnalogWaveform(Of Double)()
        Private slaveData As AnalogWaveform(Of Double)()
        Private samplesPerChannel As Integer

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Fill the physical channel combo boxes with the analog input
            ' channels in the system and choose one of the values.
            masterPhysicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External))
            slavePhysicalChannelComboBox.Items.AddRange(DaqSystem.Local.GetPhysicalChannels(PhysicalChannelTypes.AI, PhysicalChannelAccess.External))
            If masterPhysicalChannelComboBox.Items.Count > 0 Then
                masterPhysicalChannelComboBox.SelectedIndex = 0
            End If

            If slavePhysicalChannelComboBox.Items.Count > 1 Then
                slavePhysicalChannelComboBox.SelectedIndex = 1
            ElseIf slavePhysicalChannelComboBox.Items.Count > 0 Then
                slavePhysicalChannelComboBox.SelectedIndex = 0
            End If

            syncTypeComboBox.SelectedIndex = 0
        End Sub

        'Form overrides dispose to clean up the component list.
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not (components Is Nothing) Then
                    components.Dispose()
                End If
                If Not (masterSyncTask Is Nothing) Then
                    runningMasterTask = Nothing
                    masterSyncTask.Dispose()
                End If
                If Not (slaveSyncTask Is Nothing) Then
                    runningSlaveTask = Nothing
                    slaveSyncTask.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        Friend WithEvents runGroupBox As System.Windows.Forms.GroupBox
        Friend WithEvents synchronizationOnLabel As System.Windows.Forms.Label
        Friend WithEvents synchronizationOffLabel As System.Windows.Forms.Label
        Friend WithEvents synchronizationLabel As System.Windows.Forms.Label
        Friend WithEvents synchronizationSwitch As WindowsForms.Switch
        Friend WithEvents acquisitionOnLabel As System.Windows.Forms.Label
        Friend WithEvents acquistionOffLabel As System.Windows.Forms.Label
        Friend WithEvents acquisitionSwitchLabel As System.Windows.Forms.Label
        Friend WithEvents acquisitionSwitch As WindowsForms.Switch
        Friend WithEvents dataPanel As System.Windows.Forms.Panel
        Friend WithEvents dataSplitter As System.Windows.Forms.Splitter
        Friend WithEvents slavePlot As WaveformPlot
        Friend WithEvents slaveXAxis As XAxis
        Friend WithEvents slaveYAxis As YAxis
        Friend WithEvents masterWaveformPlot As WaveformPlot
        Friend WithEvents masterXAxis As XAxis
        Friend WithEvents masterYAxis As YAxis
        Friend WithEvents syncGroupBox As System.Windows.Forms.GroupBox
        Friend WithEvents syncTypeLabel As System.Windows.Forms.Label
        Friend WithEvents syncTypeComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents slaveGroupBox As System.Windows.Forms.GroupBox
        Friend WithEvents slaveMinValNumericEdit As WindowsForms.NumericEdit
        Friend WithEvents slaveMaxValNumericEdit As WindowsForms.NumericEdit
        Friend WithEvents slavePhysicalChannelComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents slavePhysChanLabel As System.Windows.Forms.Label
        Friend WithEvents slaveMaxValLabel As System.Windows.Forms.Label
        Friend WithEvents slaveMinValLabel As System.Windows.Forms.Label
        Friend WithEvents masterGroupBox As System.Windows.Forms.GroupBox
        Friend WithEvents masterMinValNumericEdit As WindowsForms.NumericEdit
        Friend WithEvents masterMaxValNumericEdit As WindowsForms.NumericEdit
        Friend WithEvents masterPhysicalChannelComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents masterPhysChanLabel As System.Windows.Forms.Label
        Friend WithEvents masterMaxValLabel As System.Windows.Forms.Label
        Friend WithEvents masterMinValLabel As System.Windows.Forms.Label
        Friend WithEvents timingGroupBox As System.Windows.Forms.GroupBox
        Friend WithEvents rateNumericEdit As WindowsForms.NumericEdit
        Friend WithEvents samplesPerChannelNumericEdit As WindowsForms.NumericEdit
        Friend WithEvents samplesPerChannelLabel As System.Windows.Forms.Label
        Friend WithEvents rateLabel As System.Windows.Forms.Label
        Friend WithEvents slaveWaveformGraph As WindowsForms.WaveformGraph
        Friend WithEvents masterWaveformGraph As WindowsForms.WaveformGraph
        <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
            Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
            Me.runGroupBox = New System.Windows.Forms.GroupBox
            Me.synchronizationOnLabel = New System.Windows.Forms.Label
            Me.synchronizationOffLabel = New System.Windows.Forms.Label
            Me.synchronizationLabel = New System.Windows.Forms.Label
            Me.synchronizationSwitch = New WindowsForms.Switch
            Me.acquisitionOnLabel = New System.Windows.Forms.Label
            Me.acquistionOffLabel = New System.Windows.Forms.Label
            Me.acquisitionSwitchLabel = New System.Windows.Forms.Label
            Me.acquisitionSwitch = New WindowsForms.Switch
            Me.dataPanel = New System.Windows.Forms.Panel
            Me.slaveWaveformGraph = New WindowsForms.WaveformGraph
            Me.slavePlot = New WaveformPlot
            Me.slaveXAxis = New XAxis
            Me.slaveYAxis = New YAxis
            Me.dataSplitter = New System.Windows.Forms.Splitter
            Me.masterWaveformGraph = New WindowsForms.WaveformGraph
            Me.masterWaveformPlot = New WaveformPlot
            Me.masterXAxis = New XAxis
            Me.masterYAxis = New YAxis
            Me.syncGroupBox = New System.Windows.Forms.GroupBox
            Me.syncTypeLabel = New System.Windows.Forms.Label
            Me.syncTypeComboBox = New System.Windows.Forms.ComboBox
            Me.slaveGroupBox = New System.Windows.Forms.GroupBox
            Me.slaveMinValNumericEdit = New WindowsForms.NumericEdit
            Me.slaveMaxValNumericEdit = New WindowsForms.NumericEdit
            Me.slavePhysicalChannelComboBox = New System.Windows.Forms.ComboBox
            Me.slavePhysChanLabel = New System.Windows.Forms.Label
            Me.slaveMaxValLabel = New System.Windows.Forms.Label
            Me.slaveMinValLabel = New System.Windows.Forms.Label
            Me.masterGroupBox = New System.Windows.Forms.GroupBox
            Me.masterMinValNumericEdit = New WindowsForms.NumericEdit
            Me.masterMaxValNumericEdit = New WindowsForms.NumericEdit
            Me.masterPhysicalChannelComboBox = New System.Windows.Forms.ComboBox
            Me.masterPhysChanLabel = New System.Windows.Forms.Label
            Me.masterMaxValLabel = New System.Windows.Forms.Label
            Me.masterMinValLabel = New System.Windows.Forms.Label
            Me.timingGroupBox = New System.Windows.Forms.GroupBox
            Me.rateNumericEdit = New WindowsForms.NumericEdit
            Me.samplesPerChannelNumericEdit = New WindowsForms.NumericEdit
            Me.samplesPerChannelLabel = New System.Windows.Forms.Label
            Me.rateLabel = New System.Windows.Forms.Label
            Me.runGroupBox.SuspendLayout()
            CType(Me.synchronizationSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.acquisitionSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dataPanel.SuspendLayout()
            CType(Me.slaveWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.masterWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.syncGroupBox.SuspendLayout()
            Me.slaveGroupBox.SuspendLayout()
            CType(Me.slaveMinValNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.slaveMaxValNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.masterGroupBox.SuspendLayout()
            CType(Me.masterMinValNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.masterMaxValNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.timingGroupBox.SuspendLayout()
            CType(Me.rateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.samplesPerChannelNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'runGroupBox
            '
            Me.runGroupBox.Controls.Add(Me.synchronizationOnLabel)
            Me.runGroupBox.Controls.Add(Me.synchronizationOffLabel)
            Me.runGroupBox.Controls.Add(Me.synchronizationLabel)
            Me.runGroupBox.Controls.Add(Me.synchronizationSwitch)
            Me.runGroupBox.Controls.Add(Me.acquisitionOnLabel)
            Me.runGroupBox.Controls.Add(Me.acquistionOffLabel)
            Me.runGroupBox.Controls.Add(Me.acquisitionSwitchLabel)
            Me.runGroupBox.Controls.Add(Me.acquisitionSwitch)
            Me.runGroupBox.Location = New System.Drawing.Point(4, 422)
            Me.runGroupBox.Name = "runGroupBox"
            Me.runGroupBox.Size = New System.Drawing.Size(336, 80)
            Me.runGroupBox.TabIndex = 12
            Me.runGroupBox.TabStop = False
            Me.runGroupBox.Text = "Run"
            '
            'synchronizationOnLabel
            '
            Me.synchronizationOnLabel.Location = New System.Drawing.Point(180, 45)
            Me.synchronizationOnLabel.Name = "synchronizationOnLabel"
            Me.synchronizationOnLabel.Size = New System.Drawing.Size(24, 23)
            Me.synchronizationOnLabel.TabIndex = 0
            Me.synchronizationOnLabel.Text = "On"
            Me.synchronizationOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'synchronizationOffLabel
            '
            Me.synchronizationOffLabel.Location = New System.Drawing.Point(288, 45)
            Me.synchronizationOffLabel.Name = "synchronizationOffLabel"
            Me.synchronizationOffLabel.Size = New System.Drawing.Size(24, 23)
            Me.synchronizationOffLabel.TabIndex = 0
            Me.synchronizationOffLabel.Text = "Off"
            Me.synchronizationOffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'synchronizationLabel
            '
            Me.synchronizationLabel.Location = New System.Drawing.Point(194, 16)
            Me.synchronizationLabel.Name = "synchronizationLabel"
            Me.synchronizationLabel.TabIndex = 0
            Me.synchronizationLabel.Text = "Synchronization:"
            Me.synchronizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'synchronizationSwitch
            '
            Me.synchronizationSwitch.Location = New System.Drawing.Point(212, 40)
            Me.synchronizationSwitch.Name = "synchronizationSwitch"
            Me.synchronizationSwitch.Size = New System.Drawing.Size(64, 32)
            Me.synchronizationSwitch.SwitchStyle = SwitchStyle.HorizontalSlide
            Me.synchronizationSwitch.TabIndex = 11
            '
            'acquisitionOnLabel
            '
            Me.acquisitionOnLabel.Location = New System.Drawing.Point(24, 45)
            Me.acquisitionOnLabel.Name = "acquisitionOnLabel"
            Me.acquisitionOnLabel.Size = New System.Drawing.Size(24, 23)
            Me.acquisitionOnLabel.TabIndex = 0
            Me.acquisitionOnLabel.Text = "On"
            Me.acquisitionOnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'acquistionOffLabel
            '
            Me.acquistionOffLabel.Location = New System.Drawing.Point(132, 45)
            Me.acquistionOffLabel.Name = "acquistionOffLabel"
            Me.acquistionOffLabel.Size = New System.Drawing.Size(24, 23)
            Me.acquistionOffLabel.TabIndex = 0
            Me.acquistionOffLabel.Text = "Off"
            Me.acquistionOffLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'acquisitionSwitchLabel
            '
            Me.acquisitionSwitchLabel.Location = New System.Drawing.Point(42, 16)
            Me.acquisitionSwitchLabel.Name = "acquisitionSwitchLabel"
            Me.acquisitionSwitchLabel.TabIndex = 0
            Me.acquisitionSwitchLabel.Text = "Acquistion:"
            Me.acquisitionSwitchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'acquisitionSwitch
            '
            Me.acquisitionSwitch.Location = New System.Drawing.Point(60, 40)
            Me.acquisitionSwitch.Name = "acquisitionSwitch"
            Me.acquisitionSwitch.Size = New System.Drawing.Size(64, 32)
            Me.acquisitionSwitch.SwitchStyle = SwitchStyle.HorizontalSlide
            Me.acquisitionSwitch.TabIndex = 10
            '
            'dataPanel
            '
            Me.dataPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dataPanel.Controls.Add(Me.slaveWaveformGraph)
            Me.dataPanel.Controls.Add(Me.dataSplitter)
            Me.dataPanel.Controls.Add(Me.masterWaveformGraph)
            Me.dataPanel.Location = New System.Drawing.Point(356, 6)
            Me.dataPanel.Name = "dataPanel"
            Me.dataPanel.Size = New System.Drawing.Size(480, 496)
            Me.dataPanel.TabIndex = 11
            '
            'slaveWaveformGraph
            '
            Me.slaveWaveformGraph.Caption = "Slave"
            Me.slaveWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill
            Me.slaveWaveformGraph.Location = New System.Drawing.Point(0, 251)
            Me.slaveWaveformGraph.Name = "slaveWaveformGraph"
            Me.slaveWaveformGraph.Plots.AddRange(New WaveformPlot() {Me.slavePlot})
            Me.slaveWaveformGraph.Size = New System.Drawing.Size(480, 245)
            Me.slaveWaveformGraph.TabIndex = 13
            Me.slaveWaveformGraph.XAxes.AddRange(New XAxis() {Me.slaveXAxis})
            Me.slaveWaveformGraph.YAxes.AddRange(New YAxis() {Me.slaveYAxis})
            '
            'slavePlot
            '
            Me.slavePlot.XAxis = Me.slaveXAxis
            Me.slavePlot.YAxis = Me.slaveYAxis
            '
            'dataSplitter
            '
            Me.dataSplitter.BackColor = System.Drawing.SystemColors.ControlDark
            Me.dataSplitter.Dock = System.Windows.Forms.DockStyle.Top
            Me.dataSplitter.Location = New System.Drawing.Point(0, 246)
            Me.dataSplitter.Name = "dataSplitter"
            Me.dataSplitter.Size = New System.Drawing.Size(480, 5)
            Me.dataSplitter.TabIndex = 1
            Me.dataSplitter.TabStop = False
            '
            'masterWaveformGraph
            '
            Me.masterWaveformGraph.Caption = "Master"
            Me.masterWaveformGraph.Dock = System.Windows.Forms.DockStyle.Top
            Me.masterWaveformGraph.Location = New System.Drawing.Point(0, 0)
            Me.masterWaveformGraph.Name = "masterWaveformGraph"
            Me.masterWaveformGraph.Plots.AddRange(New WaveformPlot() {Me.masterWaveformPlot})
            Me.masterWaveformGraph.Size = New System.Drawing.Size(480, 246)
            Me.masterWaveformGraph.TabIndex = 12
            Me.masterWaveformGraph.XAxes.AddRange(New XAxis() {Me.masterXAxis})
            Me.masterWaveformGraph.YAxes.AddRange(New YAxis() {Me.masterYAxis})
            '
            'masterWaveformPlot
            '
            Me.masterWaveformPlot.XAxis = Me.masterXAxis
            Me.masterWaveformPlot.YAxis = Me.masterYAxis
            '
            'syncGroupBox
            '
            Me.syncGroupBox.Controls.Add(Me.syncTypeLabel)
            Me.syncGroupBox.Controls.Add(Me.syncTypeComboBox)
            Me.syncGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.syncGroupBox.Location = New System.Drawing.Point(4, 6)
            Me.syncGroupBox.Name = "syncGroupBox"
            Me.syncGroupBox.Size = New System.Drawing.Size(336, 56)
            Me.syncGroupBox.TabIndex = 7
            Me.syncGroupBox.TabStop = False
            Me.syncGroupBox.Text = "Synchronization Parameters"
            '
            'syncTypeLabel
            '
            Me.syncTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.syncTypeLabel.Location = New System.Drawing.Point(16, 24)
            Me.syncTypeLabel.Name = "syncTypeLabel"
            Me.syncTypeLabel.Size = New System.Drawing.Size(120, 16)
            Me.syncTypeLabel.TabIndex = 0
            Me.syncTypeLabel.Text = "Synchronization Type:"
            '
            'syncTypeComboBox
            '
            Me.syncTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.syncTypeComboBox.Items.AddRange(New Object() {"E-Series", "M-Series (PCI)", "M-Series (PXI)", "DSA Sample Clock Timebase", "DSA Reference Clock"})
            Me.syncTypeComboBox.Location = New System.Drawing.Point(152, 22)
            Me.syncTypeComboBox.Name = "syncTypeComboBox"
            Me.syncTypeComboBox.Size = New System.Drawing.Size(168, 21)
            Me.syncTypeComboBox.TabIndex = 1
            '
            'slaveGroupBox
            '
            Me.slaveGroupBox.Controls.Add(Me.slaveMinValNumericEdit)
            Me.slaveGroupBox.Controls.Add(Me.slaveMaxValNumericEdit)
            Me.slaveGroupBox.Controls.Add(Me.slavePhysicalChannelComboBox)
            Me.slaveGroupBox.Controls.Add(Me.slavePhysChanLabel)
            Me.slaveGroupBox.Controls.Add(Me.slaveMaxValLabel)
            Me.slaveGroupBox.Controls.Add(Me.slaveMinValLabel)
            Me.slaveGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.slaveGroupBox.Location = New System.Drawing.Point(4, 198)
            Me.slaveGroupBox.Name = "slaveGroupBox"
            Me.slaveGroupBox.Size = New System.Drawing.Size(336, 120)
            Me.slaveGroupBox.TabIndex = 9
            Me.slaveGroupBox.TabStop = False
            Me.slaveGroupBox.Text = "Channel Parameters - Slave"
            '
            'slaveMinValNumericEdit
            '
            Me.slaveMinValNumericEdit.FormatMode = NumericFormatMode.CreateSimpleDoubleMode(2)
            Me.slaveMinValNumericEdit.Location = New System.Drawing.Point(152, 88)
            Me.slaveMinValNumericEdit.Name = "slaveMinValNumericEdit"
            Me.slaveMinValNumericEdit.Range = New Range(-10, 10)
            Me.slaveMinValNumericEdit.Size = New System.Drawing.Size(168, 20)
            Me.slaveMinValNumericEdit.TabIndex = 7
            Me.slaveMinValNumericEdit.Value = -10
            '
            'slaveMaxValNumericEdit
            '
            Me.slaveMaxValNumericEdit.FormatMode = NumericFormatMode.CreateSimpleDoubleMode(2)
            Me.slaveMaxValNumericEdit.Location = New System.Drawing.Point(152, 56)
            Me.slaveMaxValNumericEdit.Name = "slaveMaxValNumericEdit"
            Me.slaveMaxValNumericEdit.Range = New Range(-10, 10)
            Me.slaveMaxValNumericEdit.Size = New System.Drawing.Size(168, 20)
            Me.slaveMaxValNumericEdit.TabIndex = 6
            Me.slaveMaxValNumericEdit.Value = 10
            '
            'slavePhysicalChannelComboBox
            '
            Me.slavePhysicalChannelComboBox.Location = New System.Drawing.Point(152, 24)
            Me.slavePhysicalChannelComboBox.Name = "slavePhysicalChannelComboBox"
            Me.slavePhysicalChannelComboBox.Size = New System.Drawing.Size(168, 21)
            Me.slavePhysicalChannelComboBox.TabIndex = 5
            Me.slavePhysicalChannelComboBox.Text = "Dev2/ai0"
            '
            'slavePhysChanLabel
            '
            Me.slavePhysChanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.slavePhysChanLabel.Location = New System.Drawing.Point(16, 24)
            Me.slavePhysChanLabel.Name = "slavePhysChanLabel"
            Me.slavePhysChanLabel.Size = New System.Drawing.Size(96, 16)
            Me.slavePhysChanLabel.TabIndex = 0
            Me.slavePhysChanLabel.Text = "Physical Channel:"
            '
            'slaveMaxValLabel
            '
            Me.slaveMaxValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.slaveMaxValLabel.Location = New System.Drawing.Point(16, 56)
            Me.slaveMaxValLabel.Name = "slaveMaxValLabel"
            Me.slaveMaxValLabel.Size = New System.Drawing.Size(96, 16)
            Me.slaveMaxValLabel.TabIndex = 2
            Me.slaveMaxValLabel.Text = "Maximum Value:"
            '
            'slaveMinValLabel
            '
            Me.slaveMinValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.slaveMinValLabel.Location = New System.Drawing.Point(16, 88)
            Me.slaveMinValLabel.Name = "slaveMinValLabel"
            Me.slaveMinValLabel.Size = New System.Drawing.Size(96, 16)
            Me.slaveMinValLabel.TabIndex = 4
            Me.slaveMinValLabel.Text = "Minimum Value:"
            '
            'masterGroupBox
            '
            Me.masterGroupBox.Controls.Add(Me.masterMinValNumericEdit)
            Me.masterGroupBox.Controls.Add(Me.masterMaxValNumericEdit)
            Me.masterGroupBox.Controls.Add(Me.masterPhysicalChannelComboBox)
            Me.masterGroupBox.Controls.Add(Me.masterPhysChanLabel)
            Me.masterGroupBox.Controls.Add(Me.masterMaxValLabel)
            Me.masterGroupBox.Controls.Add(Me.masterMinValLabel)
            Me.masterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.masterGroupBox.Location = New System.Drawing.Point(4, 70)
            Me.masterGroupBox.Name = "masterGroupBox"
            Me.masterGroupBox.Size = New System.Drawing.Size(336, 120)
            Me.masterGroupBox.TabIndex = 8
            Me.masterGroupBox.TabStop = False
            Me.masterGroupBox.Text = "Channel Parameters - Master"
            '
            'masterMinValNumericEdit
            '
            Me.masterMinValNumericEdit.FormatMode = NumericFormatMode.CreateSimpleDoubleMode(2)
            Me.masterMinValNumericEdit.Location = New System.Drawing.Point(152, 88)
            Me.masterMinValNumericEdit.Name = "masterMinValNumericEdit"
            Me.masterMinValNumericEdit.Range = New Range(-10, 10)
            Me.masterMinValNumericEdit.Size = New System.Drawing.Size(168, 20)
            Me.masterMinValNumericEdit.TabIndex = 4
            Me.masterMinValNumericEdit.Value = -10
            '
            'masterMaxValNumericEdit
            '
            Me.masterMaxValNumericEdit.FormatMode = NumericFormatMode.CreateSimpleDoubleMode(2)
            Me.masterMaxValNumericEdit.Location = New System.Drawing.Point(152, 56)
            Me.masterMaxValNumericEdit.Name = "masterMaxValNumericEdit"
            Me.masterMaxValNumericEdit.Range = New Range(-10, 10)
            Me.masterMaxValNumericEdit.Size = New System.Drawing.Size(168, 20)
            Me.masterMaxValNumericEdit.TabIndex = 3
            Me.masterMaxValNumericEdit.Value = 10
            '
            'masterPhysicalChannelComboBox
            '
            Me.masterPhysicalChannelComboBox.Location = New System.Drawing.Point(152, 24)
            Me.masterPhysicalChannelComboBox.Name = "masterPhysicalChannelComboBox"
            Me.masterPhysicalChannelComboBox.Size = New System.Drawing.Size(168, 21)
            Me.masterPhysicalChannelComboBox.TabIndex = 2
            Me.masterPhysicalChannelComboBox.Text = "Dev1/ai0"
            '
            'masterPhysChanLabel
            '
            Me.masterPhysChanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.masterPhysChanLabel.Location = New System.Drawing.Point(16, 24)
            Me.masterPhysChanLabel.Name = "masterPhysChanLabel"
            Me.masterPhysChanLabel.Size = New System.Drawing.Size(96, 16)
            Me.masterPhysChanLabel.TabIndex = 0
            Me.masterPhysChanLabel.Text = "Physical Channel:"
            '
            'masterMaxValLabel
            '
            Me.masterMaxValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.masterMaxValLabel.Location = New System.Drawing.Point(16, 56)
            Me.masterMaxValLabel.Name = "masterMaxValLabel"
            Me.masterMaxValLabel.Size = New System.Drawing.Size(96, 16)
            Me.masterMaxValLabel.TabIndex = 2
            Me.masterMaxValLabel.Text = "Maximum Value:"
            '
            'masterMinValLabel
            '
            Me.masterMinValLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.masterMinValLabel.Location = New System.Drawing.Point(16, 88)
            Me.masterMinValLabel.Name = "masterMinValLabel"
            Me.masterMinValLabel.Size = New System.Drawing.Size(96, 16)
            Me.masterMinValLabel.TabIndex = 4
            Me.masterMinValLabel.Text = "Minimum Value:"
            '
            'timingGroupBox
            '
            Me.timingGroupBox.Controls.Add(Me.rateNumericEdit)
            Me.timingGroupBox.Controls.Add(Me.samplesPerChannelNumericEdit)
            Me.timingGroupBox.Controls.Add(Me.samplesPerChannelLabel)
            Me.timingGroupBox.Controls.Add(Me.rateLabel)
            Me.timingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.timingGroupBox.Location = New System.Drawing.Point(4, 326)
            Me.timingGroupBox.Name = "timingGroupBox"
            Me.timingGroupBox.Size = New System.Drawing.Size(336, 88)
            Me.timingGroupBox.TabIndex = 10
            Me.timingGroupBox.TabStop = False
            Me.timingGroupBox.Text = "Timing Parameters"
            '
            'rateNumericEdit
            '
            Me.rateNumericEdit.CoercionInterval = 100
            Me.rateNumericEdit.FormatMode = NumericFormatMode.CreateSimpleDoubleMode(2)
            Me.rateNumericEdit.Location = New System.Drawing.Point(152, 56)
            Me.rateNumericEdit.Name = "rateNumericEdit"
            Me.rateNumericEdit.Range = New Range(0, Double.PositiveInfinity)
            Me.rateNumericEdit.Size = New System.Drawing.Size(168, 20)
            Me.rateNumericEdit.TabIndex = 9
            Me.rateNumericEdit.Value = 1000
            '
            'samplesPerChannelNumericEdit
            '
            Me.samplesPerChannelNumericEdit.CoercionInterval = 10
            Me.samplesPerChannelNumericEdit.FormatMode = NumericFormatMode.CreateSimpleDoubleMode(0)
            Me.samplesPerChannelNumericEdit.Location = New System.Drawing.Point(152, 24)
            Me.samplesPerChannelNumericEdit.Name = "samplesPerChannelNumericEdit"
            Me.samplesPerChannelNumericEdit.Range = New Range(0, Double.PositiveInfinity)
            Me.samplesPerChannelNumericEdit.Size = New System.Drawing.Size(168, 20)
            Me.samplesPerChannelNumericEdit.TabIndex = 8
            Me.samplesPerChannelNumericEdit.Value = 200
            '
            'samplesPerChannelLabel
            '
            Me.samplesPerChannelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.samplesPerChannelLabel.Location = New System.Drawing.Point(16, 24)
            Me.samplesPerChannelLabel.Name = "samplesPerChannelLabel"
            Me.samplesPerChannelLabel.Size = New System.Drawing.Size(120, 16)
            Me.samplesPerChannelLabel.TabIndex = 0
            Me.samplesPerChannelLabel.Text = "Samples Per Channel:"
            '
            'rateLabel
            '
            Me.rateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.rateLabel.Location = New System.Drawing.Point(16, 56)
            Me.rateLabel.Name = "rateLabel"
            Me.rateLabel.Size = New System.Drawing.Size(96, 16)
            Me.rateLabel.TabIndex = 2
            Me.rateLabel.Text = "Rate (Hz):"
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.ClientSize = New System.Drawing.Size(840, 509)
            Me.Controls.Add(Me.runGroupBox)
            Me.Controls.Add(Me.dataPanel)
            Me.Controls.Add(Me.syncGroupBox)
            Me.Controls.Add(Me.slaveGroupBox)
            Me.Controls.Add(Me.masterGroupBox)
            Me.Controls.Add(Me.timingGroupBox)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.Text = "Synchronize Two Analog Acquisition Boards"
            Me.runGroupBox.ResumeLayout(False)
            CType(Me.synchronizationSwitch, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.acquisitionSwitch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.dataPanel.ResumeLayout(False)
            CType(Me.slaveWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.masterWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
            Me.syncGroupBox.ResumeLayout(False)
            Me.slaveGroupBox.ResumeLayout(False)
            CType(Me.slaveMinValNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.slaveMaxValNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.masterGroupBox.ResumeLayout(False)
            CType(Me.masterMinValNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.masterMaxValNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.timingGroupBox.ResumeLayout(False)
            CType(Me.rateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.samplesPerChannelNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.DoEvents()
            Application.Run(New MainForm)
        End Sub

        Private Sub acquisitionSwitch_StateChanged(ByVal sender As Object, ByVal e As ActionEventArgs) Handles acquisitionSwitch.StateChanged
            If acquisitionSwitch.Value Then
                acquisitionSwitch.Value = StartAcquisition()
            Else
                StopAcquisition()
            End If
            SetControlEnableStateForAcquisition(Not acquisitionSwitch.Value)
        End Sub

        Private Function StartAcquisition() As Boolean
            '
            ' Change the mouse to an hourglass for the duration of this function.
            '
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            masterWaveformGraph.ClearData()
            slaveWaveformGraph.ClearData()
            Dim success As Boolean = False

            Try
                '
                ' Note: This example uses the SyncTask helper class
                ' that extends the Task class from the DAQmx API.
                ' See the SyncTask.cs file in this example for the
                ' implementation of the SyncTask class.
                '

                '
                ' Configure both tasks with the values selected on the UI.
                '
                samplesPerChannel = Convert.ToInt32(samplesPerChannelNumericEdit.Value)

                '
                ' Create the master and slave tasks
                '
                masterSyncTask = New SyncTask("master", syncTypeComboBox.SelectedIndex)
                runningMasterTask = masterSyncTask
                masterSyncTask.Configure(masterPhysicalChannelComboBox.Text, masterMinValNumericEdit.Value, masterMaxValNumericEdit.Value, samplesPerChannel, rateNumericEdit.Value)

                slaveSyncTask = New SyncTask("slave", syncTypeComboBox.SelectedIndex)
                runningSlaveTask = slaveSyncTask
                slaveSyncTask.Configure(slavePhysicalChannelComboBox.Text, slaveMinValNumericEdit.Value, slaveMaxValNumericEdit.Value, samplesPerChannel, rateNumericEdit.Value)
                If synchronizationSwitch.Value Then
                    masterSyncTask.SynchronizeMaster()
                    masterCallback = New AsyncCallback(AddressOf SynchronizedAnalogInCallback)
                    slaveSyncTask.SynchronizeSlave(masterSyncTask)
                    slaveCallback = Nothing
                Else
                    masterCallback = New AsyncCallback(AddressOf MasterAnalogInCallback)
                    slaveCallback = New AsyncCallback(AddressOf SlaveAnalogInCallback)
                End If

                ' 
                ' Start the slave acquisition first so that it can wait on the master.
                '
                slaveSyncTask.Start()
                masterSyncTask.Start()

                slaveAsyncResult = slaveSyncTask.BeginRead(slaveCallback)
                masterAsyncResult = masterSyncTask.BeginRead(masterCallback)
                success = True
            Catch exception As DaqException
                MessageBox.Show(exception.Message, "Error")
                StopAcquisition()
                success = False
            End Try

            Return success
        End Function

        Private Sub StopAcquisition()
            '
            ' Change the mouse to an hourglass for the duration of this function.
            '
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            If masterSyncTask IsNot Nothing Then
                runningMasterTask = Nothing
                masterSyncTask.Dispose()
            End If
            If slaveSyncTask IsNot Nothing Then
                runningSlaveTask = Nothing
                slaveSyncTask.Dispose()
            End If
            SetControlEnableStateForAcquisition(True)
            acquisitionSwitch.Value = False
        End Sub

        Private Sub MasterAnalogInCallback(asyncResult As IAsyncResult)
            Try
                If runningMasterTask IsNot Nothing AndAlso masterAsyncResult.AsyncState Is asyncResult.AsyncState Then
                    masterData = masterSyncTask.EndRead(masterAsyncResult)
                    '
                    ' The syncTask instance specifies which graph to plot to.
                    '
                    masterWaveformGraph.PlotWaveformsAppend(masterData)
                    '
                    ' Start another read operation.
                    '
                    masterSyncTask.BeginRead(masterCallback)
                End If
            Catch exception As DaqException
                '
                ' If anything fails, shut the entire system down.
                '
                MessageBox.Show(exception.Message, "Error")
                StopAcquisition()
            End Try
        End Sub
        Private Sub SlaveAnalogInCallback(asyncResult As IAsyncResult)
            Try
                If runningSlaveTask IsNot Nothing AndAlso slaveAsyncResult.AsyncState Is asyncResult.AsyncState Then
                    slaveData = slaveSyncTask.EndRead(slaveAsyncResult)
                    slaveWaveformGraph.PlotWaveformsAppend(slaveData)
                    '
                    ' Start another read operation.
                    '
                    slaveSyncTask.BeginRead(slaveCallback)

                End If
            Catch exception As DaqException
                '
                ' If anything fails, shut the entire system down.
                '
                MessageBox.Show(exception.Message, "Error")
                StopAcquisition()
            End Try
        End Sub

        Private Sub SynchronizedAnalogInCallback(asyncResult As IAsyncResult)
            If runningMasterTask Is Nothing OrElse runningSlaveTask Is Nothing Then
                Return
            End If
            Try
                '
                ' Get the data from both readers. This is always safe only 
                ' because we configured this callback to be invoked on the
                ' same thread from which we began the reads. If we allow
                ' the DAQmx library to invoke the callbacks on any thread,
                ' we must handle the case where the master task read can 
                ' finish before the slave task read begins.
                '
                masterData = masterSyncTask.EndRead(masterAsyncResult)
                slaveData = slaveSyncTask.EndRead(slaveAsyncResult)
                masterWaveformGraph.PlotWaveformsAppend(masterData)
                slaveWaveformGraph.PlotWaveformsAppend(slaveData)
                '
                ' Start another pair of read operations.
                '
                slaveAsyncResult = slaveSyncTask.BeginRead(slaveCallback)
                masterAsyncResult = masterSyncTask.BeginRead(masterCallback)
            Catch exception As DaqException
                '
                ' If anything fails, shut the entire system down.
                '
                MessageBox.Show(exception.Message, "Error")
                StopAcquisition()
            End Try
        End Sub

        Private Sub SetControlEnableStateForAcquisition(enable As Boolean)
            '
            ' Enable or disable all controls except the graphs and the 
            ' the acquisition button.
            '
            For Each control As Control In Controls
                If Not (control Is dataPanel) AndAlso Not (control Is runGroupBox) Then
                    control.Enabled = enable
                End If
            Next

            synchronizationSwitch.Enabled = enable
        End Sub
    End Class
End Namespace
