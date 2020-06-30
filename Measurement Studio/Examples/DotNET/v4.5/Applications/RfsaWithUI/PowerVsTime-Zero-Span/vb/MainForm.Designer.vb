Partial Class MainForm
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.referenceLevelLabel = New System.Windows.Forms.Label()
		Me.carrierFrequencyLabel = New System.Windows.Forms.Label()
		Me.iqRateLabel = New System.Windows.Forms.Label()
		Me.samplesPerBlockLabel = New System.Windows.Forms.Label()
		Me.meanPowerLabel = New System.Windows.Forms.Label()
		Me.meanPowerTextBox = New System.Windows.Forms.TextBox()
		Me.resourceNameLabel = New System.Windows.Forms.Label()
		Me.startButton = New System.Windows.Forms.Button()
		Me.stopButton = New System.Windows.Forms.Button()
		Me.timer = New System.Windows.Forms.Timer(Me.components)
		Me.rmsRadioButton = New System.Windows.Forms.RadioButton()
		Me.peakRadioButton = New System.Windows.Forms.RadioButton()
		Me.peakScalingGroupBox = New System.Windows.Forms.GroupBox()
		Me.powerVsTimeWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph()
		Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot()
		Me.xAxis1 = New NationalInstruments.UI.XAxis()
		Me.yAxis1 = New NationalInstruments.UI.YAxis()
		Me.resourceNameComboBox = New System.Windows.Forms.ComboBox()
		Me.samplesPerBlockNumeric = New NationalInstruments.UI.WindowsForms.NumericEdit()
		Me.iqRateNumeric = New NationalInstruments.UI.WindowsForms.NumericEdit()
		Me.referenceLevelNumeric = New NationalInstruments.UI.WindowsForms.NumericEdit()
		Me.carrierFrequencyNumeric = New NationalInstruments.UI.WindowsForms.NumericEdit()
		Me.peakScalingGroupBox.SuspendLayout()
		DirectCast(Me.powerVsTimeWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.samplesPerBlockNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.iqRateNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.referenceLevelNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.carrierFrequencyNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' referenceLevelLabel
		' 
		Me.referenceLevelLabel.AutoSize = True
		Me.referenceLevelLabel.Location = New System.Drawing.Point(14, 64)
		Me.referenceLevelLabel.Name = "referenceLevelLabel"
		Me.referenceLevelLabel.Size = New System.Drawing.Size(116, 13)
		Me.referenceLevelLabel.TabIndex = 0
		Me.referenceLevelLabel.Text = "Reference Level (dBm)"
		' 
		' carrierFrequencyLabel
		' 
		Me.carrierFrequencyLabel.AutoSize = True
		Me.carrierFrequencyLabel.Location = New System.Drawing.Point(14, 115)
		Me.carrierFrequencyLabel.Name = "carrierFrequencyLabel"
		Me.carrierFrequencyLabel.Size = New System.Drawing.Size(112, 13)
		Me.carrierFrequencyLabel.TabIndex = 1
		Me.carrierFrequencyLabel.Text = "Carrier Frequency (Hz)"
		' 
		' iqRateLabel
		' 
		Me.iqRateLabel.AutoSize = True
		Me.iqRateLabel.Location = New System.Drawing.Point(14, 166)
		Me.iqRateLabel.Name = "iqRateLabel"
		Me.iqRateLabel.Size = New System.Drawing.Size(70, 13)
		Me.iqRateLabel.TabIndex = 2
		Me.iqRateLabel.Text = "IQ Rate (S/s)"
		' 
		' samplesPerBlockLabel
		' 
		Me.samplesPerBlockLabel.AutoSize = True
		Me.samplesPerBlockLabel.Location = New System.Drawing.Point(14, 217)
		Me.samplesPerBlockLabel.Name = "samplesPerBlockLabel"
		Me.samplesPerBlockLabel.Size = New System.Drawing.Size(136, 13)
		Me.samplesPerBlockLabel.TabIndex = 3
		Me.samplesPerBlockLabel.Text = "Samples to Read per Block"
		' 
		' meanPowerLabel
		' 
		Me.meanPowerLabel.AutoSize = True
		Me.meanPowerLabel.Location = New System.Drawing.Point(388, 271)
		Me.meanPowerLabel.Name = "meanPowerLabel"
		Me.meanPowerLabel.Size = New System.Drawing.Size(97, 13)
		Me.meanPowerLabel.TabIndex = 4
		Me.meanPowerLabel.Text = "Mean Power (dBm)"
		' 
		' meanPowerTextBox
		' 
		Me.meanPowerTextBox.Location = New System.Drawing.Point(388, 287)
		Me.meanPowerTextBox.Name = "meanPowerTextBox"
		Me.meanPowerTextBox.[ReadOnly] = True
		Me.meanPowerTextBox.Size = New System.Drawing.Size(116, 20)
		Me.meanPowerTextBox.TabIndex = 11
		Me.meanPowerTextBox.Text = "0.00000000000000E+0"
		' 
		' resourceNameLabel
		' 
		Me.resourceNameLabel.AutoSize = True
		Me.resourceNameLabel.Location = New System.Drawing.Point(14, 12)
		Me.resourceNameLabel.Name = "resourceNameLabel"
		Me.resourceNameLabel.Size = New System.Drawing.Size(84, 13)
		Me.resourceNameLabel.TabIndex = 12
		Me.resourceNameLabel.Text = "Resource Name"
		' 
		' startButton
		' 
		Me.startButton.Location = New System.Drawing.Point(14, 337)
		Me.startButton.Name = "startButton"
		Me.startButton.Size = New System.Drawing.Size(75, 23)
		Me.startButton.TabIndex = 6
		Me.startButton.Text = "&Start"
		Me.startButton.UseVisualStyleBackColor = True
		AddHandler Me.startButton.Click, New System.EventHandler(AddressOf Me.OnStartButtonClick)
		' 
		' stopButton
		' 
		Me.stopButton.Enabled = False
		Me.stopButton.Location = New System.Drawing.Point(104, 337)
		Me.stopButton.Name = "stopButton"
		Me.stopButton.Size = New System.Drawing.Size(75, 23)
		Me.stopButton.TabIndex = 7
		Me.stopButton.Text = "S&top"
		Me.stopButton.UseVisualStyleBackColor = True
		AddHandler Me.stopButton.Click, New System.EventHandler(AddressOf Me.OnStopButtonClick)
		' 
		' timer
		' 
		AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
		' 
		' rmsRadioButton
		' 
		Me.rmsRadioButton.AutoSize = True
		Me.rmsRadioButton.Location = New System.Drawing.Point(27, 19)
		Me.rmsRadioButton.Name = "rmsRadioButton"
		Me.rmsRadioButton.Size = New System.Drawing.Size(49, 17)
		Me.rmsRadioButton.TabIndex = 0
		Me.rmsRadioButton.Text = "RMS"
		Me.rmsRadioButton.UseVisualStyleBackColor = True
		' 
		' peakRadioButton
		' 
		Me.peakRadioButton.AutoSize = True
		Me.peakRadioButton.Checked = True
		Me.peakRadioButton.Location = New System.Drawing.Point(27, 37)
		Me.peakRadioButton.Name = "peakRadioButton"
		Me.peakRadioButton.Size = New System.Drawing.Size(53, 17)
		Me.peakRadioButton.TabIndex = 1
		Me.peakRadioButton.TabStop = True
		Me.peakRadioButton.Text = "PEAK"
		Me.peakRadioButton.UseVisualStyleBackColor = True
		' 
		' peakScalingGroupBox
		' 
		Me.peakScalingGroupBox.Controls.Add(Me.rmsRadioButton)
		Me.peakScalingGroupBox.Controls.Add(Me.peakRadioButton)
		Me.peakScalingGroupBox.Location = New System.Drawing.Point(229, 271)
		Me.peakScalingGroupBox.Name = "peakScalingGroupBox"
		Me.peakScalingGroupBox.Size = New System.Drawing.Size(131, 62)
		Me.peakScalingGroupBox.TabIndex = 5
		Me.peakScalingGroupBox.TabStop = False
		Me.peakScalingGroupBox.Text = "Peak Scaling"
		' 
		' powerVsTimeWaveformGraph
		' 
		Me.powerVsTimeWaveformGraph.Location = New System.Drawing.Point(152, 12)
		Me.powerVsTimeWaveformGraph.Name = "powerVsTimeWaveformGraph"
		Me.powerVsTimeWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1})
		Me.powerVsTimeWaveformGraph.Size = New System.Drawing.Size(357, 252)
		Me.powerVsTimeWaveformGraph.TabIndex = 10
		Me.powerVsTimeWaveformGraph.UseColorGenerator = True
		Me.powerVsTimeWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
		Me.powerVsTimeWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
		' 
		' waveformPlot1
		' 
		Me.waveformPlot1.XAxis = Me.xAxis1
		Me.waveformPlot1.YAxis = Me.yAxis1
		' 
		' resourceNameComboBox
		' 
		Me.resourceNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.resourceNameComboBox.FormattingEnabled = True
		Me.resourceNameComboBox.Location = New System.Drawing.Point(14, 34)
		Me.resourceNameComboBox.Name = "resourceNameComboBox"
		Me.resourceNameComboBox.Size = New System.Drawing.Size(121, 21)
		Me.resourceNameComboBox.TabIndex = 0
		' 
		' samplesPerBlockNumeric
		' 
		Me.samplesPerBlockNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
		Me.samplesPerBlockNumeric.Location = New System.Drawing.Point(14, 239)
		Me.samplesPerBlockNumeric.Name = "samplesPerBlockNumeric"
		Me.samplesPerBlockNumeric.Range = New NationalInstruments.UI.Range(1.0, 4294967295.0)
		Me.samplesPerBlockNumeric.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.samplesPerBlockNumeric.Size = New System.Drawing.Size(116, 20)
		Me.samplesPerBlockNumeric.TabIndex = 13
		Me.samplesPerBlockNumeric.Value = 10000.0
		' 
		' iqRateNumeric
		' 
		Me.iqRateNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
		Me.iqRateNumeric.Location = New System.Drawing.Point(14, 188)
		Me.iqRateNumeric.Name = "iqRateNumeric"
		Me.iqRateNumeric.Range = New NationalInstruments.UI.Range(0.0, 2147483647.0)
		Me.iqRateNumeric.Size = New System.Drawing.Size(116, 20)
		Me.iqRateNumeric.TabIndex = 14
		Me.iqRateNumeric.Value = 100000.0
		' 
		' referenceLevelNumeric
		' 
		Me.referenceLevelNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
		Me.referenceLevelNumeric.Location = New System.Drawing.Point(14, 86)
		Me.referenceLevelNumeric.Name = "referenceLevelNumeric"
		Me.referenceLevelNumeric.Size = New System.Drawing.Size(116, 20)
		Me.referenceLevelNumeric.TabIndex = 15
		' 
		' carrierFrequencyNumeric
		' 
		Me.carrierFrequencyNumeric.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
		Me.carrierFrequencyNumeric.Location = New System.Drawing.Point(14, 137)
		Me.carrierFrequencyNumeric.Name = "carrierFrequencyNumeric"
		Me.carrierFrequencyNumeric.Range = New NationalInstruments.UI.Range(0.0, Double.PositiveInfinity)
		Me.carrierFrequencyNumeric.Size = New System.Drawing.Size(116, 20)
		Me.carrierFrequencyNumeric.TabIndex = 16
		Me.carrierFrequencyNumeric.Value = 1000000000.0
		' 
		' MainForm
		' 
		Me.AcceptButton = Me.startButton
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(524, 370)
		Me.Controls.Add(Me.carrierFrequencyNumeric)
		Me.Controls.Add(Me.referenceLevelNumeric)
		Me.Controls.Add(Me.iqRateNumeric)
		Me.Controls.Add(Me.samplesPerBlockNumeric)
		Me.Controls.Add(Me.resourceNameComboBox)
		Me.Controls.Add(Me.powerVsTimeWaveformGraph)
		Me.Controls.Add(Me.peakScalingGroupBox)
		Me.Controls.Add(Me.stopButton)
		Me.Controls.Add(Me.startButton)
		Me.Controls.Add(Me.resourceNameLabel)
		Me.Controls.Add(Me.referenceLevelLabel)
		Me.Controls.Add(Me.carrierFrequencyLabel)
		Me.Controls.Add(Me.iqRateLabel)
		Me.Controls.Add(Me.samplesPerBlockLabel)
		Me.Controls.Add(Me.meanPowerLabel)
		Me.Controls.Add(Me.meanPowerTextBox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "MainForm"
		Me.Text = "RFSA Power Vs Time (Zero-Span)"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.OnMainFormLoad)
		Me.peakScalingGroupBox.ResumeLayout(False)
		Me.peakScalingGroupBox.PerformLayout()
		DirectCast(Me.powerVsTimeWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.samplesPerBlockNumeric, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.iqRateNumeric, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.referenceLevelNumeric, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.carrierFrequencyNumeric, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	#End Region

	Private referenceLevelLabel As System.Windows.Forms.Label
	Private carrierFrequencyLabel As System.Windows.Forms.Label
	Private iqRateLabel As System.Windows.Forms.Label
	Private samplesPerBlockLabel As System.Windows.Forms.Label
	Private meanPowerLabel As System.Windows.Forms.Label
	Private meanPowerTextBox As System.Windows.Forms.TextBox
	Private resourceNameLabel As System.Windows.Forms.Label
	Private startButton As System.Windows.Forms.Button
	Private stopButton As System.Windows.Forms.Button
	Private timer As System.Windows.Forms.Timer
	Private rmsRadioButton As System.Windows.Forms.RadioButton
	Private peakRadioButton As System.Windows.Forms.RadioButton
	Private peakScalingGroupBox As System.Windows.Forms.GroupBox
	Private powerVsTimeWaveformGraph As UI.WindowsForms.WaveformGraph
	Private waveformPlot1 As UI.WaveformPlot
	Private xAxis1 As UI.XAxis
	Private yAxis1 As UI.YAxis
	Private resourceNameComboBox As System.Windows.Forms.ComboBox
	Private samplesPerBlockNumeric As UI.WindowsForms.NumericEdit
	Private iqRateNumeric As UI.WindowsForms.NumericEdit
	Private referenceLevelNumeric As UI.WindowsForms.NumericEdit
	Private carrierFrequencyNumeric As UI.WindowsForms.NumericEdit

End Class
