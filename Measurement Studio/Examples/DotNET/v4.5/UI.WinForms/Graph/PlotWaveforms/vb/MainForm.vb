Imports NationalInstruments
Imports NationalInstruments.UI
Public Class MainForm
    Inherits System.Windows.Forms.Form
    Const SampleCount As Integer = 100
    Dim plotOptions As AnalogWaveformPlotOptions
    Dim times(SampleCount - 1) As System.DateTime

    Private WithEvents xAxis As NationalInstruments.UI.XAxis
    Private WithEvents yAxis As NationalInstruments.UI.YAxis
    Private WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private WithEvents waveformPlot As NationalInstruments.UI.WaveformPlot
    Private WithEvents plotWaveformGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents waveformTimingIntervalLabel As System.Windows.Forms.Label
    Private WithEvents irregularIntervalRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents plotToolTip As System.Windows.Forms.ToolTip
    Private WithEvents plotWaveformButton As System.Windows.Forms.Button
    Private WithEvents regularIntervalRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents noIntervalRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents chartWaveformGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents plotWaveformAppendButton As System.Windows.Forms.Button
    Private WithEvents rawDataRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents historyCapacityNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents historyCapacityLabel As System.Windows.Forms.Label
    Private WithEvents plotScaleModeGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents scaledDataRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents samplesRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents plotDisplayModeGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents timeRadioButton As System.Windows.Forms.RadioButton

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        plotOptions = New AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Samples, AnalogWaveformPlotScaleMode.Scaled)
        'Initialize the Date-Time array
        times(0) = New System.DateTime(1970, 1, 1, 0, 0, 0)
        Dim i As Integer = 0
        For i = 0 To (SampleCount - 1)
            times(i) = times(0).AddMilliseconds(i)
        Next i

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.waveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.plotWaveformGroupBox = New System.Windows.Forms.GroupBox
        Me.waveformTimingIntervalLabel = New System.Windows.Forms.Label
        Me.irregularIntervalRadioButton = New System.Windows.Forms.RadioButton
        Me.plotWaveformButton = New System.Windows.Forms.Button
        Me.regularIntervalRadioButton = New System.Windows.Forms.RadioButton
        Me.noIntervalRadioButton = New System.Windows.Forms.RadioButton
        Me.chartWaveformGroupBox = New System.Windows.Forms.GroupBox
        Me.plotWaveformAppendButton = New System.Windows.Forms.Button
        Me.plotToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.rawDataRadioButton = New System.Windows.Forms.RadioButton
        Me.historyCapacityNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.historyCapacityLabel = New System.Windows.Forms.Label
        Me.plotScaleModeGroupBox = New System.Windows.Forms.GroupBox
        Me.scaledDataRadioButton = New System.Windows.Forms.RadioButton
        Me.samplesRadioButton = New System.Windows.Forms.RadioButton
        Me.plotDisplayModeGroupBox = New System.Windows.Forms.GroupBox
        Me.timeRadioButton = New System.Windows.Forms.RadioButton
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotWaveformGroupBox.SuspendLayout()
        Me.chartWaveformGroupBox.SuspendLayout()
        CType(Me.historyCapacityNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotScaleModeGroupBox.SuspendLayout()
        Me.plotDisplayModeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'yAxis
        '
        Me.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.yAxis.Range = New NationalInstruments.UI.Range(-70, 70)
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Caption = "National Instruments 2D Waveform Graph"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(12, 9)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(493, 382)
        Me.sampleWaveformGraph.TabIndex = 14
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'waveformPlot
        '
        Me.waveformPlot.DefaultTiming = NationalInstruments.WaveformTiming.CreateWithRegularInterval(System.TimeSpan.Parse("00:00:00.0010000"), New Date(2000, 1, 1, 0, 0, 0, 0))
        Me.waveformPlot.XAxis = Me.xAxis
        Me.waveformPlot.YAxis = Me.yAxis
        '
        'plotWaveformGroupBox
        '
        Me.plotWaveformGroupBox.Controls.Add(Me.waveformTimingIntervalLabel)
        Me.plotWaveformGroupBox.Controls.Add(Me.irregularIntervalRadioButton)
        Me.plotWaveformGroupBox.Controls.Add(Me.plotWaveformButton)
        Me.plotWaveformGroupBox.Controls.Add(Me.regularIntervalRadioButton)
        Me.plotWaveformGroupBox.Controls.Add(Me.noIntervalRadioButton)
        Me.plotWaveformGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotWaveformGroupBox.Location = New System.Drawing.Point(515, 9)
        Me.plotWaveformGroupBox.Name = "plotWaveformGroupBox"
        Me.plotWaveformGroupBox.Size = New System.Drawing.Size(176, 139)
        Me.plotWaveformGroupBox.TabIndex = 19
        Me.plotWaveformGroupBox.TabStop = False
        Me.plotWaveformGroupBox.Text = "Plot Waveform"
        '
        'waveformTimingIntervalLabel
        '
        Me.waveformTimingIntervalLabel.AutoSize = True
        Me.waveformTimingIntervalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.waveformTimingIntervalLabel.Location = New System.Drawing.Point(10, 58)
        Me.waveformTimingIntervalLabel.Name = "waveformTimingIntervalLabel"
        Me.waveformTimingIntervalLabel.Size = New System.Drawing.Size(131, 13)
        Me.waveformTimingIntervalLabel.TabIndex = 3
        Me.waveformTimingIntervalLabel.Text = "Waveform Timing Interval:"
        '
        'irregularIntervalRadioButton
        '
        Me.irregularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.irregularIntervalRadioButton.Location = New System.Drawing.Point(10, 120)
        Me.irregularIntervalRadioButton.Name = "irregularIntervalRadioButton"
        Me.irregularIntervalRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.irregularIntervalRadioButton.TabIndex = 2
        Me.irregularIntervalRadioButton.TabStop = True
        Me.irregularIntervalRadioButton.Text = "Irregular Interval"
        Me.plotToolTip.SetToolTip(Me.irregularIntervalRadioButton, "The waveform to be plotted uses the specified DateTime array to retrieve the timi" & _
                "ng information.")
        '
        'plotWaveformButton
        '
        Me.plotWaveformButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotWaveformButton.Location = New System.Drawing.Point(11, 22)
        Me.plotWaveformButton.Name = "plotWaveformButton"
        Me.plotWaveformButton.Size = New System.Drawing.Size(160, 23)
        Me.plotWaveformButton.TabIndex = 0
        Me.plotWaveformButton.Text = "Plot Waveform"
        '
        'regularIntervalRadioButton
        '
        Me.regularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regularIntervalRadioButton.Location = New System.Drawing.Point(10, 97)
        Me.regularIntervalRadioButton.Name = "regularIntervalRadioButton"
        Me.regularIntervalRadioButton.Size = New System.Drawing.Size(107, 17)
        Me.regularIntervalRadioButton.TabIndex = 1
        Me.regularIntervalRadioButton.TabStop = True
        Me.regularIntervalRadioButton.Text = "Regular Interval"
        Me.plotToolTip.SetToolTip(Me.regularIntervalRadioButton, "The waveform to be plotted uses a specified TimeSpan object for the sample interv" & _
                "al." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The DefaultTiming property of the plot is used to retrieve the start time.")
        '
        'noIntervalRadioButton
        '
        Me.noIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noIntervalRadioButton.Location = New System.Drawing.Point(10, 74)
        Me.noIntervalRadioButton.Name = "noIntervalRadioButton"
        Me.noIntervalRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.noIntervalRadioButton.TabIndex = 0
        Me.noIntervalRadioButton.TabStop = True
        Me.noIntervalRadioButton.Text = "No Interval"
        Me.plotToolTip.SetToolTip(Me.noIntervalRadioButton, "The waveform to be plotted uses a specified time stamp for the start time." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "The D" & _
                "efaultTiming property of the plot is used to retrieve the sample interval.")
        '
        'chartWaveformGroupBox
        '
        Me.chartWaveformGroupBox.Controls.Add(Me.plotWaveformAppendButton)
        Me.chartWaveformGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chartWaveformGroupBox.Location = New System.Drawing.Point(515, 149)
        Me.chartWaveformGroupBox.Name = "chartWaveformGroupBox"
        Me.chartWaveformGroupBox.Size = New System.Drawing.Size(176, 46)
        Me.chartWaveformGroupBox.TabIndex = 20
        Me.chartWaveformGroupBox.TabStop = False
        Me.chartWaveformGroupBox.Text = "Chart Waveform"
        '
        'plotWaveformAppendButton
        '
        Me.plotWaveformAppendButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotWaveformAppendButton.Location = New System.Drawing.Point(10, 19)
        Me.plotWaveformAppendButton.Name = "plotWaveformAppendButton"
        Me.plotWaveformAppendButton.Size = New System.Drawing.Size(160, 23)
        Me.plotWaveformAppendButton.TabIndex = 0
        Me.plotWaveformAppendButton.Text = "Chart Waveform"
        '
        'rawDataRadioButton
        '
        Me.rawDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rawDataRadioButton.Location = New System.Drawing.Point(13, 19)
        Me.rawDataRadioButton.Name = "rawDataRadioButton"
        Me.rawDataRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.rawDataRadioButton.TabIndex = 0
        Me.rawDataRadioButton.Text = "Raw Data"
        '
        'historyCapacityNumericEdit
        '
        Me.historyCapacityNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.historyCapacityNumericEdit.Location = New System.Drawing.Point(514, 374)
        Me.historyCapacityNumericEdit.Name = "historyCapacityNumericEdit"
        Me.historyCapacityNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.historyCapacityNumericEdit.Range = New NationalInstruments.UI.Range(1, 10000)
        Me.historyCapacityNumericEdit.Size = New System.Drawing.Size(144, 20)
        Me.historyCapacityNumericEdit.TabIndex = 18
        Me.historyCapacityNumericEdit.Value = 1000
        '
        'historyCapacityLabel
        '
        Me.historyCapacityLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.historyCapacityLabel.Location = New System.Drawing.Point(511, 354)
        Me.historyCapacityLabel.Name = "historyCapacityLabel"
        Me.historyCapacityLabel.Size = New System.Drawing.Size(96, 16)
        Me.historyCapacityLabel.TabIndex = 17
        Me.historyCapacityLabel.Text = "History Capacity:"
        '
        'plotScaleModeGroupBox
        '
        Me.plotScaleModeGroupBox.Controls.Add(Me.scaledDataRadioButton)
        Me.plotScaleModeGroupBox.Controls.Add(Me.rawDataRadioButton)
        Me.plotScaleModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotScaleModeGroupBox.Location = New System.Drawing.Point(515, 279)
        Me.plotScaleModeGroupBox.Name = "plotScaleModeGroupBox"
        Me.plotScaleModeGroupBox.Size = New System.Drawing.Size(176, 72)
        Me.plotScaleModeGroupBox.TabIndex = 16
        Me.plotScaleModeGroupBox.TabStop = False
        Me.plotScaleModeGroupBox.Text = "Plot Scale Mode"
        '
        'scaledDataRadioButton
        '
        Me.scaledDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.scaledDataRadioButton.Location = New System.Drawing.Point(13, 43)
        Me.scaledDataRadioButton.Name = "scaledDataRadioButton"
        Me.scaledDataRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.scaledDataRadioButton.TabIndex = 1
        Me.scaledDataRadioButton.Text = "Scaled Data"
        '
        'samplesRadioButton
        '
        Me.samplesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplesRadioButton.Location = New System.Drawing.Point(13, 19)
        Me.samplesRadioButton.Name = "samplesRadioButton"
        Me.samplesRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.samplesRadioButton.TabIndex = 0
        Me.samplesRadioButton.Text = "As Samples"
        '
        'plotDisplayModeGroupBox
        '
        Me.plotDisplayModeGroupBox.Controls.Add(Me.timeRadioButton)
        Me.plotDisplayModeGroupBox.Controls.Add(Me.samplesRadioButton)
        Me.plotDisplayModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotDisplayModeGroupBox.Location = New System.Drawing.Point(515, 201)
        Me.plotDisplayModeGroupBox.Name = "plotDisplayModeGroupBox"
        Me.plotDisplayModeGroupBox.Size = New System.Drawing.Size(176, 72)
        Me.plotDisplayModeGroupBox.TabIndex = 15
        Me.plotDisplayModeGroupBox.TabStop = False
        Me.plotDisplayModeGroupBox.Text = "Plot Display Mode"
        '
        'timeRadioButton
        '
        Me.timeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.timeRadioButton.Location = New System.Drawing.Point(13, 43)
        Me.timeRadioButton.Name = "timeRadioButton"
        Me.timeRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.timeRadioButton.TabIndex = 1
        Me.timeRadioButton.Text = "Against Time"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(700, 403)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Controls.Add(Me.plotWaveformGroupBox)
        Me.Controls.Add(Me.chartWaveformGroupBox)
        Me.Controls.Add(Me.historyCapacityNumericEdit)
        Me.Controls.Add(Me.historyCapacityLabel)
        Me.Controls.Add(Me.plotScaleModeGroupBox)
        Me.Controls.Add(Me.plotDisplayModeGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Plot Waveforms Example"
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotWaveformGroupBox.ResumeLayout(False)
        Me.plotWaveformGroupBox.PerformLayout()
        Me.chartWaveformGroupBox.ResumeLayout(False)
        CType(Me.historyCapacityNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotScaleModeGroupBox.ResumeLayout(False)
        Me.plotDisplayModeGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub historyCapacityNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As AfterChangeNumericValueEventArgs) Handles historyCapacityNumericEdit.AfterChangeValue
        waveformPlot.HistoryCapacity = CType(historyCapacityNumericEdit.Value, Integer)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        scaledDataRadioButton.Checked = True
        samplesRadioButton.Checked = True
        irregularIntervalRadioButton.Checked = True
        historyCapacityNumericEdit.Value = waveformPlot.HistoryCapacity
    End Sub

    'Generates a single AnalogWaveform object, representing a sine wave of a particular amplitude and frequency.
    'The timing information is taken from the private DateTime array, which is initialized in the constructor.
#If NETFX2_0 Then
    Private Function GenerateAnalogWaveform() As AnalogWaveform(Of Double)
#Else
    Private Function GenerateAnalogWaveform() As AnalogWaveform
#End If
        Dim freq As Integer = 2
        Dim amplitude As Integer = 30
        Dim data() As Double = New Double((SampleCount) - 1) {}
        Dim i As Integer = 0
        For i = 0 To (data.Length - 1)
            data(i) = (amplitude * Math.Sin((2 * i * Math.PI * freq) / SampleCount))
        Next i
#If NETFX2_0 Then
        Dim waveform As AnalogWaveform(Of Double) = AnalogWaveform(Of Double).FromArray1D(data)
#Else
        Dim waveform As AnalogWaveform = AnalogWaveform.FromArray1D(data)
#End If
        waveform.ScaleMode = WaveformScaleMode.CreateLinearMode(2, 0)
        If noIntervalRadioButton.Checked Then
            waveform.Timing = WaveformTiming.CreateWithNoInterval(times(0))
        ElseIf regularIntervalRadioButton.Checked Then
            waveform.Timing = WaveformTiming.CreateWithRegularInterval(waveformPlot.DefaultTiming.SampleInterval)
        ElseIf irregularIntervalRadioButton.Checked Then
            waveform.Timing = WaveformTiming.CreateWithIrregularInterval(times)
        End If
        Return waveform
    End Function

    Private Sub SetAnalogWaveformPlotOptions(ByVal displayMode As AnalogWaveformPlotDisplayMode, ByVal scaleMode As AnalogWaveformPlotScaleMode)
        plotOptions = New AnalogWaveformPlotOptions(displayMode, scaleMode)
    End Sub

    Private Sub rawDataRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rawDataRadioButton.Click
        If rawDataRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetAnalogWaveformPlotOptions(plotOptions.DisplayMode, AnalogWaveformPlotScaleMode.Raw)
        End If
    End Sub

    Private Sub scaledDataRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles scaledDataRadioButton.Click
        If scaledDataRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            SetAnalogWaveformPlotOptions(plotOptions.DisplayMode, AnalogWaveformPlotScaleMode.Scaled)
        End If
    End Sub

    Private Sub samplesRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles samplesRadioButton.Click
        If samplesRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Numeric, "G5")
            SetAnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Samples, plotOptions.ScaleMode)
        End If
    End Sub

    Private Sub timeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timeRadioButton.Click
        If timeRadioButton.Checked Then
            sampleWaveformGraph.ClearData()
            xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "m:ss.fff")
            SetAnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, plotOptions.ScaleMode)
        End If
    End Sub

    Private Sub plotWaveformButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotWaveformButton.Click
        sampleWaveformGraph.PlotWaveform(GenerateAnalogWaveform(), plotOptions)
    End Sub

    Private Sub plotWaveformAppendButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotWaveformAppendButton.Click
#If NETFX2_0 Then
        Dim waveform As AnalogWaveform(Of Double) = GenerateAnalogWaveform()
#Else
        Dim waveform As AnalogWaveform = GenerateAnalogWaveform()
#End If

        'Modify the timing information so that the waveform charted is continuous.
        Dim latestDateTime As DateTime = New DateTime(0)
        Dim defaultInterval As TimeSpan = waveformPlot.DefaultTiming.SampleInterval
        If (waveformPlot.HistoryCount > 0) Then
            latestDateTime = CType(DataConverter.Convert(waveformPlot.GetXData((waveformPlot.HistoryCount - 1)), GetType(DateTime)), DateTime)
        End If
        waveform.Timing = WaveformTiming.CreateWithRegularInterval(defaultInterval, latestDateTime.AddMilliseconds(defaultInterval.Milliseconds))
        sampleWaveformGraph.PlotWaveformAppend(waveform)
    End Sub
End Class
