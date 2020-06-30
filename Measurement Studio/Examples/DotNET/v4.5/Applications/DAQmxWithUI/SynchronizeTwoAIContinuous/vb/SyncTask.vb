Imports System.Diagnostics
Imports NationalInstruments.DAQmx
Imports System.ComponentModel

Namespace NationalInstruments.Examples.SynchronizeTwoAIContinuous
    Public Enum SyncType
        ESeries = 0
        MSeries = 1
        MSeriesPXI = 2
        DsaSampleClock = 3
        DsaReferenceClock = 4
    End Enum

    ''' <summary>
    ''' This class is used for both the master and slave tasks
    ''' in this example.
    '''
    ''' Both the master and slave task are
    ''' created, configured, and read in the same manner.
    ''' The only difference is that you should call
    ''' SynchronizeSlave on the slave task, and not on the
    ''' master task.
    ''' </summary>
    Public Class SyncTask
        Private myTask As Task
        Private reader As AnalogMultiChannelReader
        Private syncType As SyncType
        Private dataColumn As System.Data.DataColumn()
        Private dataTable As New System.Data.DataTable()
        Private data As AnalogWaveform(Of Double)()
        Private _samplesPerChannel As Integer

        ''' <summary>
        ''' Create the Task and name it.
        ''' </summary>
        Public Sub New(name As String, sync As Integer)
            myTask = New Task(name)
            reader = New AnalogMultiChannelReader(myTask.Stream)
            reader.SynchronizeCallbacks = True
            syncType = CType(sync, SyncType)
        End Sub

        ''' <summary>
        ''' Configure the task by creating a channel
        ''' and setting up the timing.
        ''' </summary>
        Public Sub Configure(physicalChannelName As String, minimumValue As Double, maximumValue As Double, samplesPerChannel As Integer, rate As Double)

            '
            ' First, create a AI voltage channel, allowing the NI-DAQ driver to choose
            ' the terminal configuration.
            '
            myTask.AIChannels.CreateVoltageChannel(physicalChannelName, String.Empty, DirectCast(-1, AITerminalConfiguration), minimumValue, maximumValue, AIVoltageUnits.Volts)

            '
            ' Next, configure the onboard sample clock.
            '
            myTask.Timing.ConfigureSampleClock(String.Empty, rate, SampleClockActiveEdge.Rising, SampleQuantityMode.ContinuousSamples, samplesPerChannel)
            _samplesPerChannel = samplesPerChannel

            myTask.Control(TaskAction.Verify)
        End Sub

        Public Sub SynchronizeMaster()
            Select Case syncType
                Case SyncType.ESeries
                    '
                    ' E-Series synchronization requires no additional
                    ' configuration.
                    '
                    Exit Select
                Case SyncType.MSeries
                    '
                    ' M-Series PCI synchronization
                    '
                    myTask.Timing.ReferenceClockSource = "OnboardClock"
                    Exit Select
                Case SyncType.MSeriesPXI
                    '
                    ' M-Series PXI synchronization
                    '
                    myTask.Timing.ReferenceClockSource = "PXI_Clk10"
                    myTask.Timing.ReferenceClockRate = 10000000
                    Exit Select
                Case SyncType.DsaSampleClock
                    '
                    ' DSA Sample Clock Timebase synchronization requires no additional
                    ' configuration.
                    '
                    Exit Select
                Case SyncType.DsaReferenceClock
                    ' 
                    ' DSA Reference Clock synchronization
                    '
                    myTask.Timing.ReferenceClockSource = "PXI_Clk10"
                    Exit Select
                Case Else
                    Debug.Assert(False, "Unknown synchronization type.")
                    Exit Select
            End Select
        End Sub

        Public Sub SynchronizeSlave(master As SyncTask)
            '
            ' First, verify the master task so we can query its properties.
            '
            master.Task.Control(TaskAction.Verify)

            '
            ' Next, find out what device the master is using.
            ' This is so we can build terminal strings using the
            ' master device name.
            '
            Dim firstPhysChanName As String = master.Task.AIChannels(0).PhysicalName
            Dim deviceName As String = firstPhysChanName.Split("/"c)(0)
            Dim terminalNameBase As String = "/" & deviceName & "/"

            '
            ' Depending on what kind of device, synchronize accordingly
            '
            Select Case syncType
                Case SyncType.ESeries
                    '
                    ' E-Series synchronization
                    '
                    myTask.Timing.MasterTimebaseSource = master.Task.Timing.MasterTimebaseSource
                    myTask.Timing.MasterTimebaseRate = master.Task.Timing.MasterTimebaseRate
                    Exit Select
                Case SyncType.MSeries
                    '
                    ' M-Series PCI synchronization
                    '
                    myTask.Timing.ReferenceClockSource = master.Task.Timing.ReferenceClockSource
                    myTask.Timing.ReferenceClockRate = master.Task.Timing.ReferenceClockRate
                    Exit Select
                Case SyncType.MSeriesPXI
                    '
                    ' M-Series PXI synchronization
                    '
                    myTask.Timing.ReferenceClockSource = master.Task.Timing.ReferenceClockSource
                    '"PXI_Clk10";
                    myTask.Timing.ReferenceClockRate = master.Task.Timing.ReferenceClockRate
                    '10000000;
                    Exit Select
                Case SyncType.DsaSampleClock
                    '
                    ' DSA Sample Clock Timebase synchronization
                    '
                    myTask.Timing.SampleClockTimebaseSource = terminalNameBase & "SampleClockTimebase"
                    myTask.Timing.SynchronizationPulseSource = terminalNameBase & "SyncPulse"
                    Exit Select
                Case SyncType.DsaReferenceClock
                    '
                    ' DSA Reference Clock synchronization
                    '
                    myTask.Timing.SynchronizationPulseSource = terminalNameBase & "SyncPulse"
                    myTask.Timing.ReferenceClockSource = master.Task.Timing.ReferenceClockSource
                    '"PXI_Clk10";
                    Exit Select
                Case Else
                    Debug.Assert(False, "Unknown synchronization type.")
                    Exit Select
            End Select

            ' Configure a digital edge start trigger so both tasks
            ' start together.
            myTask.Triggers.StartTrigger.ConfigureDigitalEdgeTrigger(terminalNameBase & "ai/StartTrigger", DigitalEdgeStartTriggerEdge.Rising)
        End Sub

        Public Sub Start()
            myTask.Start()
        End Sub

        Public Sub Dispose()
            myTask.Dispose()
        End Sub

        ''' <summary>
        ''' Read the data.
        ''' </summary>
        Public Function BeginRead(callback As AsyncCallback) As IAsyncResult
            If data Is Nothing Then
                data = New AnalogWaveform(Of Double)(myTask.AIChannels.Count - 1) {}
                For iCnt As Integer = 0 To data.GetLength(0) - 1
                    data(iCnt) = New AnalogWaveform(Of Double)(_samplesPerChannel)
                Next
            End If
            Return reader.BeginMemoryOptimizedReadWaveform(_samplesPerChannel, callback, myTask, data)
        End Function

        Public Function EndRead(ar As IAsyncResult) As AnalogWaveform(Of Double)()
            data = reader.EndReadWaveform(ar)
            Return data
        End Function

        Private ReadOnly Property Task() As Task
            Get
                Return myTask
            End Get
        End Property
    End Class
End Namespace
