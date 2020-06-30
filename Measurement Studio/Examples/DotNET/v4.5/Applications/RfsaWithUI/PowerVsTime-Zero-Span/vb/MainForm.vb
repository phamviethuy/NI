'******************************************************************************
'*
'* Example program:
'*   Power Vs Time Zero Span
'*
'* Category:
'*   NI-RFSA
'*
'* Description:
'*   Use this example to learn how to acquire I/Q data using the RF vector signal analyzer. 
'*   The example shows how to configure NI-RFSA for continuous I/Q acquisition,
'*   how to set the carrier frequency and the I/Q rate, and how to fetch I/Q data. 
'*   The dBm calculation is applied to I/Q magnitude to produce signal power and display it on the graph.
'*
'* Instructions for running:
'*   1. Configure RFSA device in the MAX for the program to run. 
'*
'*	2. Configure the Reference Level in the UI. 
'*		The reference level represents the maximum expected power of an input RF signal.
'*
'*	3. Configure the Carrier Frequency in the UI.
'*
'*	4. COnfigure the IQ Rate and the Samples to Read Per Block in the UI.
'*
'*	5. Select Start Button for RFSA to start acquiring the data and display a graph of Signal Power Vs Time in the UI.
'*		Select RMS for Root Mean Square Power and Peak for the Peak Power in the Graph.
'*
'*	6. Use the Stop Button to stop the acquisition.
'*		
'* I/O Connections Overview:
'*   Make sure your signal input terminals match the Physical Channel I/O
'*   Controls.  If you have a PXI chassis, ensure that it has been properly
'*   identified in MAX.  
'*
'******************************************************************************

Imports System.Windows.Forms
Imports NationalInstruments.ModularInstruments.NIRfsa
Imports NationalInstruments.ModularInstruments.SystemServices.DeviceServices

Public Partial Class MainForm
	Inherits Form
	Private rfsaSession As NIRfsa
	Private iqData As ComplexDouble()
	Private powerVsTimeData As Double()
	Private waveformInfo As RfsaWaveformInfo

	Const DefaultNumberOfSamples As Integer = 100000
	Const DefaultFetchTimeSpan As Double = 10.0
	Const MinimumPowerLevel As Double = 1E-08
    Const RMSScaleFactor As Double = 1.0
    Const DefaultImpedance As Double = 50.0 'Used In Calculating Power
    Const ConversionRateWattsToMilliWatts As Double = 1000.0
    Const BelToDecibelConstant As Integer = 10

	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub LoadRfsaDeviceNames()
		'
		' Populate the ResourceComboBox with all the Resource Name of type NI-RFSA in the system.
		' The Device Names are the names of RFSA configured in MAX.
		'

		Dim modularInstrumentsSystem As New ModularInstrumentsSystem("NI-RFSA")
		For Each device As DeviceInfo In modularInstrumentsSystem.DeviceCollection
			resourceNameComboBox.Items.Add(device.Name)
		Next
		If modularInstrumentsSystem.DeviceCollection.Count > 0 Then
			resourceNameComboBox.SelectedIndex = 0
		Else
			ShowError("No RFSA Resource Found. Configure RFSA Device in MAX." & Environment.NewLine & "The Application will exit.")
			Me.Close()
		End If
	End Sub

	#Region "Values from UI"

	Private ReadOnly Property RFSAResourceName() As String
		Get
			Return Me.resourceNameComboBox.Text
		End Get
	End Property

	Private ReadOnly Property ReferenceLevel() As Double
		Get
			Return Me.referenceLevelNumeric.Value
		End Get
	End Property

	Private ReadOnly Property CarrierFrequency() As Double
		Get
			Return Me.carrierFrequencyNumeric.Value
		End Get
	End Property

	Private ReadOnly Property IQRate() As Double
		Get
			Return Me.iqRateNumeric.Value
		End Get
	End Property

	Private ReadOnly Property NumberOfSamples() As Integer
		Get
			Return Convert.ToInt32(Me.samplesPerBlockNumeric.Value)
		End Get
	End Property

	Private ReadOnly Property PeakScaling() As Boolean
		Get
			Return peakRadioButton.Checked
		End Get
	End Property

	#End Region

	Private Sub OnStartButtonClick(sender As Object, e As System.EventArgs)
		' Steps:
		' 1. Change all the controls on the UI to Disable State except the Stop Button.
		' 2. Initialize the RFSA Session.
		' 3. Configure the various properties in RFSA for the IQ Acquisition.
		' 4. Initiate the Acquisition.
		' 5. Enable the timer so that the Acquisition is done after every particular interval configured.

		' In-Case of the error Catch the Exception raised and Display it.
		' Close the RFSA Session and reset the UI Controls to Enabled Sate.
		Try
			ChangeControlState(False)
			InitializeRfsaSession()
			ConfigureForIQ()
			InitiateAcquisition()
			Me.timer.Enabled = True
		Catch ex As System.Exception
			ShowError(ex.Message)
			CloseSession()
			ChangeControlState(True)
		End Try
	End Sub

	Private Shared Sub ShowError(message As String)
		MessageBox.Show(message, "Error")
	End Sub

	Private Sub ChangeControlState(state As Boolean)
		Me.resourceNameComboBox.Enabled = state
		Me.referenceLevelNumeric.Enabled = state
		Me.carrierFrequencyNumeric.Enabled = state
		Me.iqRateNumeric.Enabled = state
		Me.startButton.Enabled = state
		Me.samplesPerBlockNumeric.Enabled = state
		Me.stopButton.Enabled = Not state
	End Sub

	Private Sub OnStopButtonClick(sender As Object, e As System.EventArgs)
		'
		' Stop the timer and Change the Controls State to Enable and finally Close the Session.
		'
		Me.timer.Enabled = False
		ChangeControlState(True)
		CloseSession()
	End Sub

	Private Sub OnTimerTick(sender As Object, e As System.EventArgs)
		'
		' On each timer tick perform the steps in PowerVsTime method.
		'
		PowerVsTime()
	End Sub

	Private Sub InitializeRfsaSession()
		'
		' Close the Session if already Open.
		' Initialize the RFSA Session and subscribe for the Warnings from the Driver.
		'
		CloseSession()
		rfsaSession = New NIRfsa(RFSAResourceName, True, False)
		AddHandler rfsaSession.DriverOperation.Warning, New System.EventHandler(Of RfsaWarningEventArgs)(AddressOf DriverOperationWarning)
	End Sub

	'
	' Handles the Warnings raised from the Driver.
	'
	Private Sub DriverOperationWarning(sender As Object, e As RfsaWarningEventArgs)
		MessageBox.Show(e.Warning.ToString(), "Warning")
	End Sub

	Private Sub ConfigureForIQ()
		' Configure the reference level.
		' Configure the acquisition type to I/Q.
		' Configure the carrier frequency.
		' Configure the Number Of Samples and Number of Samples Finite to False.
		' Configure the I/Q rate.
		' Configure the NI-RFSA device for a continuous acquisition.
		rfsaSession.Configuration.Vertical.ReferenceLevel = ReferenceLevel
		rfsaSession.Configuration.AcquisitionType = RfsaAcquisitionType.IQ
		rfsaSession.Configuration.IQ.CarrierFrequency = CarrierFrequency
		rfsaSession.Configuration.IQ.NumberOfSamples = DefaultNumberOfSamples
		rfsaSession.Configuration.IQ.NumberOfSamplesIsFinite = False
		rfsaSession.Configuration.IQ.IQRate = IQRate
	End Sub

	'
	' Initiate the Acquisition.
	'
	Private Sub InitiateAcquisition()
		rfsaSession.Acquisition.IQ.Initiate()
	End Sub

	'
	' This method is called every time the timer expires. The method performs following operations
	' 1. It fetch the IQ data from the device.
	' 2. Perform neccessary calculations and converts the data in to the Power Vs Time data.
	' 3. Plots the data in the form of a Waveform Graph on the UI.
	Private Sub PowerVsTime()
		Dim scaleFactor As Double
		Dim mean As Double

		If PeakScaling Then
			' Case of Peak Scaling being "PEAK"
			scaleFactor = System.Math.Sqrt(2.0)
		Else
			' Case of Peak Scaling being "RMS"
			scaleFactor = RMSScaleFactor
		End If

		Dim timespan As New PrecisionTimeSpan(DefaultFetchTimeSpan)
		iqData = rfsaSession.Acquisition.IQ.FetchIQSingleRecordComplex(Of ComplexDouble)(0, NumberOfSamples, timespan, waveformInfo)
		powerVsTimeData = New Double(NumberOfSamples - 1) {}
		Dim sum As Double = 0.0
		For index As Integer = 0 To NumberOfSamples - 1
			powerVsTimeData(index) = Math.Sqrt(Math.Pow(iqData(index).Imaginary, 2) + Math.Pow(iqData(index).Real, 2))
			' Handle this because log(0) return a error. 

			If powerVsTimeData(index) = 0.0 Then
				powerVsTimeData(index) = MinimumPowerLevel
			End If
            powerVsTimeData(index) = BelToDecibelConstant * Math.Log10(Math.Pow(powerVsTimeData(index) / scaleFactor, 2.0) * ConversionRateWattsToMilliWatts / DefaultImpedance)
			sum += powerVsTimeData(index)
		Next

		mean = sum / NumberOfSamples
		Me.meanPowerTextBox.Text = mean.ToString()
		powerVsTimeWaveformGraph.PlotY(powerVsTimeData, waveformInfo.RelativeInitialX, waveformInfo.XIncrement)
	End Sub

	Private Sub CloseSession()
		' Closes the Rfsa Session.
		If rfsaSession IsNot Nothing Then
			Try
				rfsaSession.Close()
				rfsaSession = Nothing
			Catch ex As Exception
				ShowError("Unable to Close Session, Reset the device." & vbLf & "Error : " & ex.Message)
				Application.[Exit]()
			End Try
		End If
	End Sub

	Private Sub OnMainFormLoad(sender As Object, e As EventArgs)
		LoadRfsaDeviceNames()
	End Sub
End Class
