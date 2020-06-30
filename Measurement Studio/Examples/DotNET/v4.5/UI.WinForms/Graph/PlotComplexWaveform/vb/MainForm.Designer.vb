<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.plotToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.chartWaveformCheckBox = New System.Windows.Forms.CheckBox
        Me.timeRadioButton = New System.Windows.Forms.RadioButton
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.waveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.irregularIntervalRadioButton = New System.Windows.Forms.RadioButton
        Me.regularIntervalRadioButton = New System.Windows.Forms.RadioButton
        Me.noIntervalRadioButton = New System.Windows.Forms.RadioButton
        Me.dataToPlotGroupBox = New System.Windows.Forms.GroupBox
        Me.magnitudeRadioButton = New System.Windows.Forms.RadioButton
        Me.phaseRadioButton = New System.Windows.Forms.RadioButton
        Me.imaginaryRadioButton = New System.Windows.Forms.RadioButton
        Me.realRadioButton = New System.Windows.Forms.RadioButton
        Me.samplesRadioButton = New System.Windows.Forms.RadioButton
        Me.plotDataAppendTimer = New System.Windows.Forms.Timer(Me.components)
        Me.plotWaveformGroupBox = New System.Windows.Forms.GroupBox
        Me.historyCapacityNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.scaledDataRadioButton = New System.Windows.Forms.RadioButton
        Me.plotScaleModeGroupBox = New System.Windows.Forms.GroupBox
        Me.rawDataRadioButton = New System.Windows.Forms.RadioButton
        Me.plotDisplayModeGroupBox = New System.Windows.Forms.GroupBox
        Me.historyCapacityLabel = New System.Windows.Forms.Label
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataToPlotGroupBox.SuspendLayout()
        Me.plotWaveformGroupBox.SuspendLayout()
        CType(Me.historyCapacityNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotScaleModeGroupBox.SuspendLayout()
        Me.plotDisplayModeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'chartWaveformCheckBox
        '
        Me.chartWaveformCheckBox.AutoSize = True
        Me.chartWaveformCheckBox.Location = New System.Drawing.Point(549, 340)
        Me.chartWaveformCheckBox.Name = "chartWaveformCheckBox"
        Me.chartWaveformCheckBox.Size = New System.Drawing.Size(103, 17)
        Me.chartWaveformCheckBox.TabIndex = 22
        Me.chartWaveformCheckBox.Text = "Chart Waveform"
        Me.chartWaveformCheckBox.UseVisualStyleBackColor = True
        '
        'timeRadioButton
        '
        Me.timeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.timeRadioButton.Location = New System.Drawing.Point(9, 40)
        Me.timeRadioButton.Name = "timeRadioButton"
        Me.timeRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.timeRadioButton.TabIndex = 1
        Me.timeRadioButton.Text = "Against Time"
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Caption = "National Instruments 2D Waveform Graph with ComplexWaveform"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(13, 6)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(523, 389)
        Me.sampleWaveformGraph.TabIndex = 23
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'waveformPlot
        '
        Me.waveformPlot.DefaultTiming = NationalInstruments.WaveformTiming.CreateWithRegularInterval(System.TimeSpan.Parse("00:00:00.0010000"), New Date(2000, 1, 1, 0, 0, 0, 0))
        Me.waveformPlot.DefaultWaveformPrecisionTiming = NationalInstruments.PrecisionWaveformTiming.CreateWithRegularInterval(New NationalInstruments.PrecisionTimeSpan(CType(0, Long), CType(18446744073709551UL, ULong)), New NationalInstruments.PrecisionDateTime(CType(63082281600, Long), CType(0, ULong)))
        Me.waveformPlot.XAxis = Me.xAxis
        Me.waveformPlot.YAxis = Me.yAxis
        '
        'yAxis
        '
        Me.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.yAxis.Range = New NationalInstruments.UI.Range(0, 2)
        '
        'irregularIntervalRadioButton
        '
        Me.irregularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.irregularIntervalRadioButton.Location = New System.Drawing.Point(6, 65)
        Me.irregularIntervalRadioButton.Name = "irregularIntervalRadioButton"
        Me.irregularIntervalRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.irregularIntervalRadioButton.TabIndex = 2
        Me.irregularIntervalRadioButton.TabStop = True
        Me.irregularIntervalRadioButton.Text = "Irregular Interval"
        '
        'regularIntervalRadioButton
        '
        Me.regularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regularIntervalRadioButton.Location = New System.Drawing.Point(6, 42)
        Me.regularIntervalRadioButton.Name = "regularIntervalRadioButton"
        Me.regularIntervalRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.regularIntervalRadioButton.TabIndex = 1
        Me.regularIntervalRadioButton.TabStop = True
        Me.regularIntervalRadioButton.Text = "Regular Interval"
        '
        'noIntervalRadioButton
        '
        Me.noIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noIntervalRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.noIntervalRadioButton.Name = "noIntervalRadioButton"
        Me.noIntervalRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.noIntervalRadioButton.TabIndex = 0
        Me.noIntervalRadioButton.TabStop = True
        Me.noIntervalRadioButton.Text = "No Interval"
        '
        'dataToPlotGroupBox
        '
        Me.dataToPlotGroupBox.Controls.Add(Me.magnitudeRadioButton)
        Me.dataToPlotGroupBox.Controls.Add(Me.phaseRadioButton)
        Me.dataToPlotGroupBox.Controls.Add(Me.imaginaryRadioButton)
        Me.dataToPlotGroupBox.Controls.Add(Me.realRadioButton)
        Me.dataToPlotGroupBox.Location = New System.Drawing.Point(549, 264)
        Me.dataToPlotGroupBox.Name = "dataToPlotGroupBox"
        Me.dataToPlotGroupBox.Size = New System.Drawing.Size(176, 70)
        Me.dataToPlotGroupBox.TabIndex = 29
        Me.dataToPlotGroupBox.TabStop = False
        Me.dataToPlotGroupBox.Text = "Data to Plot"
        '
        'magnitudeRadioButton
        '
        Me.magnitudeRadioButton.AutoSize = True
        Me.magnitudeRadioButton.Location = New System.Drawing.Point(88, 42)
        Me.magnitudeRadioButton.Name = "magnitudeRadioButton"
        Me.magnitudeRadioButton.Size = New System.Drawing.Size(75, 17)
        Me.magnitudeRadioButton.TabIndex = 3
        Me.magnitudeRadioButton.TabStop = True
        Me.magnitudeRadioButton.Text = "Magnitude"
        Me.magnitudeRadioButton.UseVisualStyleBackColor = True
        '
        'phaseRadioButton
        '
        Me.phaseRadioButton.AutoSize = True
        Me.phaseRadioButton.Location = New System.Drawing.Point(88, 19)
        Me.phaseRadioButton.Name = "phaseRadioButton"
        Me.phaseRadioButton.Size = New System.Drawing.Size(55, 17)
        Me.phaseRadioButton.TabIndex = 2
        Me.phaseRadioButton.TabStop = True
        Me.phaseRadioButton.Text = "Phase"
        Me.phaseRadioButton.UseVisualStyleBackColor = True
        '
        'imaginaryRadioButton
        '
        Me.imaginaryRadioButton.AutoSize = True
        Me.imaginaryRadioButton.Location = New System.Drawing.Point(7, 42)
        Me.imaginaryRadioButton.Name = "imaginaryRadioButton"
        Me.imaginaryRadioButton.Size = New System.Drawing.Size(70, 17)
        Me.imaginaryRadioButton.TabIndex = 1
        Me.imaginaryRadioButton.TabStop = True
        Me.imaginaryRadioButton.Text = "Imaginary"
        Me.imaginaryRadioButton.UseVisualStyleBackColor = True
        '
        'realRadioButton
        '
        Me.realRadioButton.AutoSize = True
        Me.realRadioButton.Location = New System.Drawing.Point(7, 19)
        Me.realRadioButton.Name = "realRadioButton"
        Me.realRadioButton.Size = New System.Drawing.Size(47, 17)
        Me.realRadioButton.TabIndex = 0
        Me.realRadioButton.TabStop = True
        Me.realRadioButton.Text = "Real"
        Me.realRadioButton.UseVisualStyleBackColor = True
        '
        'samplesRadioButton
        '
        Me.samplesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplesRadioButton.Location = New System.Drawing.Point(9, 16)
        Me.samplesRadioButton.Name = "samplesRadioButton"
        Me.samplesRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.samplesRadioButton.TabIndex = 0
        Me.samplesRadioButton.Text = "As Samples"
        '
        'plotDataAppendTimer
        '
        Me.plotDataAppendTimer.Interval = 2000
        '
        'plotWaveformGroupBox
        '
        Me.plotWaveformGroupBox.Controls.Add(Me.irregularIntervalRadioButton)
        Me.plotWaveformGroupBox.Controls.Add(Me.regularIntervalRadioButton)
        Me.plotWaveformGroupBox.Controls.Add(Me.noIntervalRadioButton)
        Me.plotWaveformGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotWaveformGroupBox.Location = New System.Drawing.Point(549, 11)
        Me.plotWaveformGroupBox.Name = "plotWaveformGroupBox"
        Me.plotWaveformGroupBox.Size = New System.Drawing.Size(176, 91)
        Me.plotWaveformGroupBox.TabIndex = 28
        Me.plotWaveformGroupBox.TabStop = False
        Me.plotWaveformGroupBox.Text = "Waveform Timing Interval"
        '
        'historyCapacityNumericEdit
        '
        Me.historyCapacityNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.historyCapacityNumericEdit.Location = New System.Drawing.Point(549, 375)
        Me.historyCapacityNumericEdit.Name = "historyCapacityNumericEdit"
        Me.historyCapacityNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.historyCapacityNumericEdit.Range = New NationalInstruments.UI.Range(1, 10000)
        Me.historyCapacityNumericEdit.Size = New System.Drawing.Size(144, 20)
        Me.historyCapacityNumericEdit.TabIndex = 27
        Me.historyCapacityNumericEdit.Value = 10000
        '
        'scaledDataRadioButton
        '
        Me.scaledDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.scaledDataRadioButton.Location = New System.Drawing.Point(9, 40)
        Me.scaledDataRadioButton.Name = "scaledDataRadioButton"
        Me.scaledDataRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.scaledDataRadioButton.TabIndex = 1
        Me.scaledDataRadioButton.Text = "Scaled Data"
        '
        'plotScaleModeGroupBox
        '
        Me.plotScaleModeGroupBox.Controls.Add(Me.scaledDataRadioButton)
        Me.plotScaleModeGroupBox.Controls.Add(Me.rawDataRadioButton)
        Me.plotScaleModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotScaleModeGroupBox.Location = New System.Drawing.Point(549, 186)
        Me.plotScaleModeGroupBox.Name = "plotScaleModeGroupBox"
        Me.plotScaleModeGroupBox.Size = New System.Drawing.Size(176, 72)
        Me.plotScaleModeGroupBox.TabIndex = 25
        Me.plotScaleModeGroupBox.TabStop = False
        Me.plotScaleModeGroupBox.Text = "Plot Scale Mode"
        '
        'rawDataRadioButton
        '
        Me.rawDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rawDataRadioButton.Location = New System.Drawing.Point(9, 16)
        Me.rawDataRadioButton.Name = "rawDataRadioButton"
        Me.rawDataRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.rawDataRadioButton.TabIndex = 0
        Me.rawDataRadioButton.Text = "Raw Data"
        '
        'plotDisplayModeGroupBox
        '
        Me.plotDisplayModeGroupBox.Controls.Add(Me.timeRadioButton)
        Me.plotDisplayModeGroupBox.Controls.Add(Me.samplesRadioButton)
        Me.plotDisplayModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotDisplayModeGroupBox.Location = New System.Drawing.Point(549, 108)
        Me.plotDisplayModeGroupBox.Name = "plotDisplayModeGroupBox"
        Me.plotDisplayModeGroupBox.Size = New System.Drawing.Size(176, 72)
        Me.plotDisplayModeGroupBox.TabIndex = 24
        Me.plotDisplayModeGroupBox.TabStop = False
        Me.plotDisplayModeGroupBox.Text = "Plot Display Mode"
        '
        'historyCapacityLabel
        '
        Me.historyCapacityLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.historyCapacityLabel.Location = New System.Drawing.Point(546, 360)
        Me.historyCapacityLabel.Name = "historyCapacityLabel"
        Me.historyCapacityLabel.Size = New System.Drawing.Size(96, 16)
        Me.historyCapacityLabel.TabIndex = 26
        Me.historyCapacityLabel.Text = "History Capacity:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 407)
        Me.Controls.Add(Me.chartWaveformCheckBox)
        Me.Controls.Add(Me.dataToPlotGroupBox)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Controls.Add(Me.plotWaveformGroupBox)
        Me.Controls.Add(Me.historyCapacityNumericEdit)
        Me.Controls.Add(Me.plotScaleModeGroupBox)
        Me.Controls.Add(Me.plotDisplayModeGroupBox)
        Me.Controls.Add(Me.historyCapacityLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataToPlotGroupBox.ResumeLayout(False)
        Me.dataToPlotGroupBox.PerformLayout()
        Me.plotWaveformGroupBox.ResumeLayout(False)
        CType(Me.historyCapacityNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotScaleModeGroupBox.ResumeLayout(False)
        Me.plotDisplayModeGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents plotToolTip As System.Windows.Forms.ToolTip
    Private WithEvents chartWaveformCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents timeRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private WithEvents waveformPlot As NationalInstruments.UI.WaveformPlot
    Private WithEvents xAxis As NationalInstruments.UI.XAxis
    Private WithEvents yAxis As NationalInstruments.UI.YAxis
    Private WithEvents irregularIntervalRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents regularIntervalRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents noIntervalRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents dataToPlotGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents magnitudeRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents phaseRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents imaginaryRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents realRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents samplesRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents plotDataAppendTimer As System.Windows.Forms.Timer
    Private WithEvents plotWaveformGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents historyCapacityNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents scaledDataRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents plotScaleModeGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents rawDataRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents plotDisplayModeGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents historyCapacityLabel As System.Windows.Forms.Label

End Class
