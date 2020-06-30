Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        AddHandler plotDataButton.Click, AddressOf Me.OnPlotDataButtonClick
        AddHandler autoscaleXRadioButton.CheckedChanged, AddressOf Me.OnXAxisScaleChanged
        AddHandler manualXRadioButton.CheckedChanged, AddressOf Me.OnXAxisScaleChanged
        AddHandler minXNumericEdit.AfterChangeValue, AddressOf Me.OnXAxisRangeChanged
        AddHandler maxXNumericEdit.AfterChangeValue, AddressOf Me.OnXAxisRangeChanged
        AddHandler minXNumericEdit.BeforeChangeValue, AddressOf Me.BeforeMinXNumUpDownChanged
        AddHandler maxXNumericEdit.BeforeChangeValue, AddressOf Me.BeforeMaxXNumUpDownChanged
        AddHandler autoscaleYRadioButton.CheckedChanged, AddressOf Me.OnYAxisScaleChanged
        AddHandler manualYRadioButton.CheckedChanged, AddressOf Me.OnYAxisScaleChanged
        AddHandler minYNumericEdit.ValueChanged, AddressOf Me.OnYAxisRangeChanged
        AddHandler maxYNumericEdit.ValueChanged, AddressOf Me.OnYAxisRangeChanged
        AddHandler minYNumericEdit.BeforeChangeValue, AddressOf Me.BeforeMinYNumUpDownChanged
        AddHandler maxYNumericEdit.BeforeChangeValue, AddressOf Me.BeforeMaxYNumUpDownChanged
        'Add any initialization after the InitializeComponent() call

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

    Private Const DefaultDataLength As Integer = 100

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents xAxisGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents maxXLabel As System.Windows.Forms.Label
    Friend WithEvents minXLabel As System.Windows.Forms.Label
    Friend WithEvents manualXRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents autoscaleXRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents yAxisGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents maxYLabel As System.Windows.Forms.Label
    Friend WithEvents minYLabel As System.Windows.Forms.Label
    Friend WithEvents autoscaleYRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents manualYRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents plotDataButton As System.Windows.Forms.Button
    Friend WithEvents YAxis As NationalInstruments.UI.YAxis
    Friend WithEvents XAxis As NationalInstruments.UI.XAxis
    Friend WithEvents WaveformPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents minXNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents maxXNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents minYNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents maxYNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.xAxisGroupBox = New System.Windows.Forms.GroupBox
        Me.maxXLabel = New System.Windows.Forms.Label
        Me.minXLabel = New System.Windows.Forms.Label
        Me.manualXRadioButton = New System.Windows.Forms.RadioButton
        Me.autoscaleXRadioButton = New System.Windows.Forms.RadioButton
        Me.minXNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.maxXNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.yAxisGroupBox = New System.Windows.Forms.GroupBox
        Me.maxYLabel = New System.Windows.Forms.Label
        Me.minYLabel = New System.Windows.Forms.Label
        Me.autoscaleYRadioButton = New System.Windows.Forms.RadioButton
        Me.manualYRadioButton = New System.Windows.Forms.RadioButton
        Me.minYNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.maxYNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.WaveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.XAxis = New NationalInstruments.UI.XAxis
        Me.YAxis = New NationalInstruments.UI.YAxis
        Me.plotDataButton = New System.Windows.Forms.Button
        Me.xAxisGroupBox.SuspendLayout()
        CType(Me.minXNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxXNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.yAxisGroupBox.SuspendLayout()
        CType(Me.minYNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxYNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xAxisGroupBox
        '
        Me.xAxisGroupBox.Controls.Add(Me.maxXLabel)
        Me.xAxisGroupBox.Controls.Add(Me.minXLabel)
        Me.xAxisGroupBox.Controls.Add(Me.manualXRadioButton)
        Me.xAxisGroupBox.Controls.Add(Me.autoscaleXRadioButton)
        Me.xAxisGroupBox.Controls.Add(Me.minXNumericEdit)
        Me.xAxisGroupBox.Controls.Add(Me.maxXNumericEdit)
        Me.xAxisGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.xAxisGroupBox.Location = New System.Drawing.Point(34, 304)
        Me.xAxisGroupBox.Name = "xAxisGroupBox"
        Me.xAxisGroupBox.Size = New System.Drawing.Size(284, 88)
        Me.xAxisGroupBox.TabIndex = 6
        Me.xAxisGroupBox.TabStop = False
        Me.xAxisGroupBox.Text = "XAxis"
        '
        'maxXLabel
        '
        Me.maxXLabel.Location = New System.Drawing.Point(136, 56)
        Me.maxXLabel.Name = "maxXLabel"
        Me.maxXLabel.Size = New System.Drawing.Size(64, 16)
        Me.maxXLabel.TabIndex = 7
        Me.maxXLabel.Text = "Maximum:"
        '
        'minXLabel
        '
        Me.minXLabel.Location = New System.Drawing.Point(136, 24)
        Me.minXLabel.Name = "minXLabel"
        Me.minXLabel.Size = New System.Drawing.Size(64, 16)
        Me.minXLabel.TabIndex = 6
        Me.minXLabel.Text = "Minimum:"
        '
        'manualXRadioButton
        '
        Me.manualXRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.manualXRadioButton.Location = New System.Drawing.Point(24, 56)
        Me.manualXRadioButton.Name = "manualXRadioButton"
        Me.manualXRadioButton.Size = New System.Drawing.Size(96, 16)
        Me.manualXRadioButton.TabIndex = 1
        Me.manualXRadioButton.Text = "Manual"
        '
        'autoscaleXRadioButton
        '
        Me.autoscaleXRadioButton.Checked = True
        Me.autoscaleXRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.autoscaleXRadioButton.Location = New System.Drawing.Point(24, 24)
        Me.autoscaleXRadioButton.Name = "autoscaleXRadioButton"
        Me.autoscaleXRadioButton.Size = New System.Drawing.Size(104, 16)
        Me.autoscaleXRadioButton.TabIndex = 0
        Me.autoscaleXRadioButton.TabStop = True
        Me.autoscaleXRadioButton.Text = "AutoScale"
        '
        'minXNumericEdit
        '
        Me.minXNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.minXNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.minXNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.minXNumericEdit.Location = New System.Drawing.Point(200, 24)
        Me.minXNumericEdit.Name = "minXNumericEdit"
        Me.minXNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.minXNumericEdit.Range = New NationalInstruments.UI.Range(-10, 50)
        Me.minXNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.minXNumericEdit.TabIndex = 2
        '
        'maxXNumericEdit
        '
        Me.maxXNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.maxXNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.maxXNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.maxXNumericEdit.Location = New System.Drawing.Point(200, 56)
        Me.maxXNumericEdit.Name = "maxXNumericEdit"
        Me.maxXNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.maxXNumericEdit.Range = New NationalInstruments.UI.Range(10, 200)
        Me.maxXNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.maxXNumericEdit.TabIndex = 3
        Me.maxXNumericEdit.Value = 100
        '
        'yAxisGroupBox
        '
        Me.yAxisGroupBox.Controls.Add(Me.maxYLabel)
        Me.yAxisGroupBox.Controls.Add(Me.minYLabel)
        Me.yAxisGroupBox.Controls.Add(Me.autoscaleYRadioButton)
        Me.yAxisGroupBox.Controls.Add(Me.manualYRadioButton)
        Me.yAxisGroupBox.Controls.Add(Me.minYNumericEdit)
        Me.yAxisGroupBox.Controls.Add(Me.maxYNumericEdit)
        Me.yAxisGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.yAxisGroupBox.Location = New System.Drawing.Point(34, 416)
        Me.yAxisGroupBox.Name = "yAxisGroupBox"
        Me.yAxisGroupBox.Size = New System.Drawing.Size(284, 88)
        Me.yAxisGroupBox.TabIndex = 7
        Me.yAxisGroupBox.TabStop = False
        Me.yAxisGroupBox.Text = "YAxis"
        '
        'maxYLabel
        '
        Me.maxYLabel.Location = New System.Drawing.Point(136, 56)
        Me.maxYLabel.Name = "maxYLabel"
        Me.maxYLabel.Size = New System.Drawing.Size(64, 16)
        Me.maxYLabel.TabIndex = 9
        Me.maxYLabel.Text = "Maximum:"
        '
        'minYLabel
        '
        Me.minYLabel.Location = New System.Drawing.Point(136, 24)
        Me.minYLabel.Name = "minYLabel"
        Me.minYLabel.Size = New System.Drawing.Size(64, 16)
        Me.minYLabel.TabIndex = 8
        Me.minYLabel.Text = "Minimum:"
        '
        'autoscaleYRadioButton
        '
        Me.autoscaleYRadioButton.Checked = True
        Me.autoscaleYRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.autoscaleYRadioButton.Location = New System.Drawing.Point(24, 24)
        Me.autoscaleYRadioButton.Name = "autoscaleYRadioButton"
        Me.autoscaleYRadioButton.Size = New System.Drawing.Size(96, 16)
        Me.autoscaleYRadioButton.TabIndex = 0
        Me.autoscaleYRadioButton.TabStop = True
        Me.autoscaleYRadioButton.Text = "AutoScale"
        '
        'manualYRadioButton
        '
        Me.manualYRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.manualYRadioButton.Location = New System.Drawing.Point(24, 56)
        Me.manualYRadioButton.Name = "manualYRadioButton"
        Me.manualYRadioButton.Size = New System.Drawing.Size(104, 16)
        Me.manualYRadioButton.TabIndex = 1
        Me.manualYRadioButton.Text = "Manual"
        '
        'minYNumericEdit
        '
        Me.minYNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.minYNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.minYNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.minYNumericEdit.Location = New System.Drawing.Point(200, 24)
        Me.minYNumericEdit.Name = "minYNumericEdit"
        Me.minYNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.minYNumericEdit.Range = New NationalInstruments.UI.Range(-10, 50)
        Me.minYNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.minYNumericEdit.TabIndex = 2
        '
        'maxYNumericEdit
        '
        Me.maxYNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.maxYNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.maxYNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.maxYNumericEdit.Location = New System.Drawing.Point(200, 56)
        Me.maxYNumericEdit.Name = "maxYNumericEdit"
        Me.maxYNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.maxYNumericEdit.Range = New NationalInstruments.UI.Range(1, 100)
        Me.maxYNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.maxYNumericEdit.TabIndex = 3
        Me.maxYNumericEdit.Value = 10
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Caption = "National Instruments 2D Graph"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(8, 16)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.WaveformPlot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(320, 232)
        Me.sampleWaveformGraph.TabIndex = 0
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis})
        '
        'WaveformPlot
        '
        Me.WaveformPlot.XAxis = Me.XAxis
        Me.WaveformPlot.YAxis = Me.YAxis
        '
        'plotDataButton
        '
        Me.plotDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotDataButton.Location = New System.Drawing.Point(112, 264)
        Me.plotDataButton.Name = "plotDataButton"
        Me.plotDataButton.Size = New System.Drawing.Size(112, 32)
        Me.plotDataButton.TabIndex = 1
        Me.plotDataButton.Text = "Plot Data"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(336, 526)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Controls.Add(Me.plotDataButton)
        Me.Controls.Add(Me.xAxisGroupBox)
        Me.Controls.Add(Me.yAxisGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Axes Example"
        Me.xAxisGroupBox.ResumeLayout(False)
        CType(Me.minXNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxXNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.yAxisGroupBox.ResumeLayout(False)
        CType(Me.minYNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxYNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub OnXAxisScaleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SetXAxisScale()
    End Sub

    Private Sub OnXAxisRangeChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs)
        If (manualXRadioButton.Checked) Then
            SetXAxisRange()
        End If
    End Sub

    Private Sub BeforeMinXNumUpDownChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs)
        If (e.NewValue >= maxXNumericEdit.Value) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BeforeMaxXNumUpDownChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs)
        If (e.NewValue <= minXNumericEdit.Value) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub SetXAxisScale()
        If (autoscaleXRadioButton.Checked) Then
            XAxis.Mode = AxisMode.AutoScaleLoose
        ElseIf (manualXRadioButton.Checked) Then
            XAxis.Mode = AxisMode.Fixed
            SetXAxisRange()
        End If
    End Sub

    Private Sub SetXAxisRange()
        XAxis.Range = New Range(CType(minXNumericEdit.Value, Double), CType(maxXNumericEdit.Value, Double))
    End Sub

    Private Sub OnYAxisScaleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SetYAxisScale()
    End Sub

    Private Sub OnYAxisRangeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If (manualYRadioButton.Checked) Then
            SetYAxisRange()
        End If
    End Sub

    Private Sub BeforeMinYNumUpDownChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs)
        If (e.NewValue >= maxYNumericEdit.Value) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub BeforeMaxYNumUpDownChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs)
        If (e.NewValue <= minYNumericEdit.Value) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub SetYAxisScale()
        If (autoscaleYRadioButton.Checked) Then
            YAxis.Mode = AxisMode.AutoScaleLoose
        ElseIf (manualYRadioButton.Checked) Then
            YAxis.Mode = AxisMode.Fixed
            SetYAxisRange()
        End If
    End Sub

    Private Sub SetYAxisRange()
        YAxis.Range = New Range(CType(minYNumericEdit.Value, Double), CType(maxYNumericEdit.Value, Double))
    End Sub

    Private Sub OnPlotDataButtonClick(ByVal sender As Object, ByVal e As System.EventArgs)
        sampleWaveformGraph.PlotY(GenerateData())
    End Sub

    Private Shared Function GenerateData() As Double()
        Return GenerateData(DefaultDataLength)
    End Function

    Private Shared Function GenerateData(ByVal dataLength As Integer) As Double()
        If dataLength < 1 Then
            Throw New ArgumentOutOfRangeException("dataLength", dataLength, "Data length must be positive.")
        End If

        Dim data() As Double = New Double(dataLength - 1) {}
        Dim rnd As Random = New Random

        Dim i As Integer
        For i = 0 To dataLength - 1
            data(i) = (rnd.NextDouble() * Math.Sin(i / 3.15))
        Next

        Return data
    End Function

    Private Sub autoscaleXRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autoscaleXRadioButton.CheckedChanged
        minXNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator
        maxXNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator
    End Sub

    Private Sub manualXRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manualXRadioButton.CheckedChanged
        minXNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys Or NumericEditInteractionModes.Buttons Or NumericEditInteractionModes.Text
        maxXNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys Or NumericEditInteractionModes.Buttons Or NumericEditInteractionModes.Text
    End Sub

    Private Sub autoscaleYRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles autoscaleYRadioButton.CheckedChanged
        minYNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator
        maxYNumericEdit.InteractionMode = NumericEditInteractionModes.Indicator
    End Sub

    Private Sub manualYRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles manualYRadioButton.CheckedChanged
        minYNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys Or NumericEditInteractionModes.Buttons Or NumericEditInteractionModes.Text
        maxYNumericEdit.InteractionMode = NumericEditInteractionModes.ArrowKeys Or NumericEditInteractionModes.Buttons Or NumericEditInteractionModes.Text
    End Sub
End Class
