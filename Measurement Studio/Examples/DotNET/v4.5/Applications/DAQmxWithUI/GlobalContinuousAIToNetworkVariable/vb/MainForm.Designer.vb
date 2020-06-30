<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.infoLabel = New System.Windows.Forms.Label
        Me.networkVariableGroupBox = New System.Windows.Forms.GroupBox
        Me.connectionStatusLabel = New System.Windows.Forms.Label
        Me.outputLocationLabel = New System.Windows.Forms.Label
        Me.connectionStatusLed = New NationalInstruments.UI.WindowsForms.Led
        Me.outputLocationTextBox = New System.Windows.Forms.TextBox
        Me.browseButton = New System.Windows.Forms.Button
        Me.daqmxTaskGroupBox = New System.Windows.Forms.GroupBox
        Me.daqmxTaskLabel = New System.Windows.Forms.Label
        Me.taskComboBox = New System.Windows.Forms.ComboBox
        Me.startButton = New System.Windows.Forms.Button
        Me.stopButton = New System.Windows.Forms.Button
        Me.channelLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.outputWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.outputNetworkVariableBrowserDialog = New NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBrowserDialog(Me.components)
        Me.networkVariableGroupBox.SuspendLayout()
        CType(Me.connectionStatusLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.daqmxTaskGroupBox.SuspendLayout()
        CType(Me.channelLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.outputWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'infoLabel
        '
        Me.infoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.infoLabel.Location = New System.Drawing.Point(447, 12)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(259, 171)
        Me.infoLabel.TabIndex = 13
        Me.infoLabel.Text = resources.GetString("infoLabel.Text")
        '
        'networkVariableGroupBox
        '
        Me.networkVariableGroupBox.Controls.Add(Me.connectionStatusLabel)
        Me.networkVariableGroupBox.Controls.Add(Me.outputLocationLabel)
        Me.networkVariableGroupBox.Controls.Add(Me.connectionStatusLed)
        Me.networkVariableGroupBox.Controls.Add(Me.outputLocationTextBox)
        Me.networkVariableGroupBox.Controls.Add(Me.browseButton)
        Me.networkVariableGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.networkVariableGroupBox.Location = New System.Drawing.Point(12, 90)
        Me.networkVariableGroupBox.Name = "networkVariableGroupBox"
        Me.networkVariableGroupBox.Size = New System.Drawing.Size(423, 93)
        Me.networkVariableGroupBox.TabIndex = 11
        Me.networkVariableGroupBox.TabStop = False
        Me.networkVariableGroupBox.Text = "Output NetworkVariable"
        '
        'connectionStatusLabel
        '
        Me.connectionStatusLabel.AutoSize = True
        Me.connectionStatusLabel.Location = New System.Drawing.Point(8, 59)
        Me.connectionStatusLabel.Name = "connectionStatusLabel"
        Me.connectionStatusLabel.Size = New System.Drawing.Size(97, 13)
        Me.connectionStatusLabel.TabIndex = 6
        Me.connectionStatusLabel.Text = "Connection Status:"
        '
        'outputLocationLabel
        '
        Me.outputLocationLabel.AutoSize = True
        Me.outputLocationLabel.Location = New System.Drawing.Point(8, 25)
        Me.outputLocationLabel.Name = "outputLocationLabel"
        Me.outputLocationLabel.Size = New System.Drawing.Size(86, 13)
        Me.outputLocationLabel.TabIndex = 5
        Me.outputLocationLabel.Text = "Output Location:"
        '
        'connectionStatusLed
        '
        Me.connectionStatusLed.ImmediateUpdates = True
        Me.connectionStatusLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.connectionStatusLed.Location = New System.Drawing.Point(122, 45)
        Me.connectionStatusLed.Name = "connectionStatusLed"
        Me.connectionStatusLed.Size = New System.Drawing.Size(43, 40)
        Me.connectionStatusLed.TabIndex = 4
        '
        'outputLocationTextBox
        '
        Me.outputLocationTextBox.Location = New System.Drawing.Point(122, 21)
        Me.outputLocationTextBox.Name = "outputLocationTextBox"
        Me.outputLocationTextBox.ReadOnly = True
        Me.outputLocationTextBox.Size = New System.Drawing.Size(226, 20)
        Me.outputLocationTextBox.TabIndex = 3
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(354, 21)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(63, 23)
        Me.browseButton.TabIndex = 2
        Me.browseButton.Text = "Browse"
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'daqmxTaskGroupBox
        '
        Me.daqmxTaskGroupBox.Controls.Add(Me.daqmxTaskLabel)
        Me.daqmxTaskGroupBox.Controls.Add(Me.taskComboBox)
        Me.daqmxTaskGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.daqmxTaskGroupBox.Location = New System.Drawing.Point(12, 12)
        Me.daqmxTaskGroupBox.Name = "daqmxTaskGroupBox"
        Me.daqmxTaskGroupBox.Size = New System.Drawing.Size(423, 72)
        Me.daqmxTaskGroupBox.TabIndex = 9
        Me.daqmxTaskGroupBox.TabStop = False
        Me.daqmxTaskGroupBox.Text = "Global DAQmx Task"
        '
        'daqmxTaskLabel
        '
        Me.daqmxTaskLabel.AutoSize = True
        Me.daqmxTaskLabel.Location = New System.Drawing.Point(8, 34)
        Me.daqmxTaskLabel.Name = "daqmxTaskLabel"
        Me.daqmxTaskLabel.Size = New System.Drawing.Size(73, 13)
        Me.daqmxTaskLabel.TabIndex = 2
        Me.daqmxTaskLabel.Text = "DAQmx Task:"
        '
        'taskComboBox
        '
        Me.taskComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.taskComboBox.Location = New System.Drawing.Point(122, 30)
        Me.taskComboBox.Name = "taskComboBox"
        Me.taskComboBox.Size = New System.Drawing.Size(226, 21)
        Me.taskComboBox.TabIndex = 1
        '
        'startButton
        '
        Me.startButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.startButton.Location = New System.Drawing.Point(23, 195)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 10
        Me.startButton.Text = "Start"
        '
        'stopButton
        '
        Me.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.stopButton.Location = New System.Drawing.Point(134, 195)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(75, 23)
        Me.stopButton.TabIndex = 12
        Me.stopButton.Text = "Stop"
        '
        'channelLegend
        '
        Me.channelLegend.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.channelLegend.Location = New System.Drawing.Point(450, 231)
        Me.channelLegend.Name = "channelLegend"
        Me.channelLegend.Size = New System.Drawing.Size(256, 298)
        Me.channelLegend.TabIndex = 15
        Me.channelLegend.TabStop = False
        '
        'outputWaveformGraph
        '
        Me.outputWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outputWaveformGraph.Location = New System.Drawing.Point(12, 231)
        Me.outputWaveformGraph.Name = "outputWaveformGraph"
        Me.outputWaveformGraph.UseColorGenerator = True
        Me.outputWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1})
        Me.outputWaveformGraph.Size = New System.Drawing.Size(424, 298)
        Me.outputWaveformGraph.TabIndex = 14
        Me.outputWaveformGraph.TabStop = False
        Me.outputWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.outputWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'waveformPlot1
        '
        Me.waveformPlot1.XAxis = Me.xAxis1
        Me.waveformPlot1.YAxis = Me.yAxis1
        '
        'outputNetworkVariableBrowserDialog
        '
        Me.outputNetworkVariableBrowserDialog.Text = "Select Output Network Variable"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(742, 541)
        Me.Controls.Add(Me.channelLegend)
        Me.Controls.Add(Me.outputWaveformGraph)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.networkVariableGroupBox)
        Me.Controls.Add(Me.daqmxTaskGroupBox)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.stopButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(750, 575)
        Me.Name = "MainForm"
        Me.Text = "Continuous Analog Input To Network Variable "
        Me.networkVariableGroupBox.ResumeLayout(False)
        Me.networkVariableGroupBox.PerformLayout()
        CType(Me.connectionStatusLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.daqmxTaskGroupBox.ResumeLayout(False)
        Me.daqmxTaskGroupBox.PerformLayout()
        CType(Me.channelLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.outputWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents infoLabel As System.Windows.Forms.Label
    Private WithEvents networkVariableGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents connectionStatusLabel As System.Windows.Forms.Label
    Private WithEvents outputLocationLabel As System.Windows.Forms.Label
    Private WithEvents connectionStatusLed As NationalInstruments.UI.WindowsForms.Led
    Private WithEvents outputLocationTextBox As System.Windows.Forms.TextBox
    Private WithEvents browseButton As System.Windows.Forms.Button
    Private WithEvents daqmxTaskGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents daqmxTaskLabel As System.Windows.Forms.Label
    Private WithEvents taskComboBox As System.Windows.Forms.ComboBox
    Private WithEvents startButton As System.Windows.Forms.Button
    Private WithEvents stopButton As System.Windows.Forms.Button
    Private WithEvents channelLegend As NationalInstruments.UI.WindowsForms.Legend
    Private WithEvents outputWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private WithEvents waveformPlot1 As NationalInstruments.UI.WaveformPlot
    Private WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Private WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Private WithEvents outputNetworkVariableBrowserDialog As NationalInstruments.NetworkVariable.WindowsForms.NetworkVariableBrowserDialog

End Class
