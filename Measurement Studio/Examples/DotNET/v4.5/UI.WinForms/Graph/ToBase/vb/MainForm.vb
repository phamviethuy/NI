Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents fillModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents fillBaseComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents generateButton As System.Windows.Forms.Button
    Friend WithEvents lineToBaseStyleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents fillToBaseStyleComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents baseXValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents baseYValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents fillToBaseColorLed As NationalInstruments.UI.WindowsForms.Led
    Friend WithEvents lineToBaseColorLed As NationalInstruments.UI.WindowsForms.Led
    Friend WithEvents lineToBaseLineWidthNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numberOfPointsNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents fillToBaseWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents fillModeLabel As System.Windows.Forms.Label
    Friend WithEvents fillBaseLabel As System.Windows.Forms.Label
    Friend WithEvents baseYValueLabel As System.Windows.Forms.Label
    Friend WithEvents dataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents numberOfPointsLabel As System.Windows.Forms.Label
    Friend WithEvents lineToBaseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lineToBaseLedLabel As System.Windows.Forms.Label
    Friend WithEvents fillToBaseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents fillToBaseStyleLabel As System.Windows.Forms.Label
    Friend WithEvents fillToBaseLedLabel As System.Windows.Forms.Label
    Friend WithEvents baseXValueLabel As System.Windows.Forms.Label
    Friend WithEvents applicationColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents fillToBasePlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents mainXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents mainYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents lineToBaseLineWidthLabel As System.Windows.Forms.Label
    Friend WithEvents lineToBaseStyleLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.fillModeLabel = New System.Windows.Forms.Label
        Me.fillModeComboBox = New System.Windows.Forms.ComboBox
        Me.fillBaseLabel = New System.Windows.Forms.Label
        Me.fillBaseComboBox = New System.Windows.Forms.ComboBox
        Me.baseYValueLabel = New System.Windows.Forms.Label
        Me.dataGroupBox = New System.Windows.Forms.GroupBox
        Me.generateButton = New System.Windows.Forms.Button
        Me.numberOfPointsLabel = New System.Windows.Forms.Label
        Me.numberOfPointsNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.lineToBaseGroupBox = New System.Windows.Forms.GroupBox
        Me.lineToBaseLineWidthLabel = New System.Windows.Forms.Label
        Me.lineToBaseLedLabel = New System.Windows.Forms.Label
        Me.lineToBaseStyleComboBox = New System.Windows.Forms.ComboBox
        Me.lineToBaseStyleLabel = New System.Windows.Forms.Label
        Me.lineToBaseColorLed = New NationalInstruments.UI.WindowsForms.Led
        Me.lineToBaseLineWidthNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.fillToBaseGroupBox = New System.Windows.Forms.GroupBox
        Me.fillToBaseStyleLabel = New System.Windows.Forms.Label
        Me.fillToBaseStyleComboBox = New System.Windows.Forms.ComboBox
        Me.fillToBaseLedLabel = New System.Windows.Forms.Label
        Me.fillToBaseColorLed = New NationalInstruments.UI.WindowsForms.Led
        Me.applicationColorDialog = New System.Windows.Forms.ColorDialog
        Me.baseXValueLabel = New System.Windows.Forms.Label
        Me.fillToBaseWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.fillToBasePlot = New NationalInstruments.UI.WaveformPlot
        Me.mainXAxis = New NationalInstruments.UI.XAxis
        Me.mainYAxis = New NationalInstruments.UI.YAxis
        Me.baseXValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.baseYValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.dataGroupBox.SuspendLayout()
        CType(Me.numberOfPointsNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lineToBaseGroupBox.SuspendLayout()
        CType(Me.lineToBaseColorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lineToBaseLineWidthNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fillToBaseGroupBox.SuspendLayout()
        CType(Me.fillToBaseColorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fillToBaseWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.baseXValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.baseYValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fillModeLabel
        '
        Me.fillModeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fillModeLabel.Location = New System.Drawing.Point(16, 264)
        Me.fillModeLabel.Name = "fillModeLabel"
        Me.fillModeLabel.Size = New System.Drawing.Size(64, 16)
        Me.fillModeLabel.TabIndex = 32
        Me.fillModeLabel.Text = "Fill Mode:"
        '
        'fillModeComboBox
        '
        Me.fillModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fillModeComboBox.Location = New System.Drawing.Point(16, 280)
        Me.fillModeComboBox.Name = "fillModeComboBox"
        Me.fillModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.fillModeComboBox.TabIndex = 31
        '
        'fillBaseLabel
        '
        Me.fillBaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fillBaseLabel.Location = New System.Drawing.Point(16, 224)
        Me.fillBaseLabel.Name = "fillBaseLabel"
        Me.fillBaseLabel.Size = New System.Drawing.Size(64, 16)
        Me.fillBaseLabel.TabIndex = 30
        Me.fillBaseLabel.Text = "Fill Base:"
        '
        'fillBaseComboBox
        '
        Me.fillBaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fillBaseComboBox.Location = New System.Drawing.Point(16, 240)
        Me.fillBaseComboBox.Name = "fillBaseComboBox"
        Me.fillBaseComboBox.Size = New System.Drawing.Size(121, 21)
        Me.fillBaseComboBox.TabIndex = 29
        '
        'baseYValueLabel
        '
        Me.baseYValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.baseYValueLabel.Location = New System.Drawing.Point(96, 176)
        Me.baseYValueLabel.Name = "baseYValueLabel"
        Me.baseYValueLabel.Size = New System.Drawing.Size(80, 16)
        Me.baseYValueLabel.TabIndex = 28
        Me.baseYValueLabel.Text = "Base Y Value:"
        '
        'dataGroupBox
        '
        Me.dataGroupBox.Controls.Add(Me.generateButton)
        Me.dataGroupBox.Controls.Add(Me.numberOfPointsLabel)
        Me.dataGroupBox.Controls.Add(Me.numberOfPointsNumericEdit)
        Me.dataGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dataGroupBox.Location = New System.Drawing.Point(192, 176)
        Me.dataGroupBox.Name = "dataGroupBox"
        Me.dataGroupBox.Size = New System.Drawing.Size(168, 100)
        Me.dataGroupBox.TabIndex = 35
        Me.dataGroupBox.TabStop = False
        Me.dataGroupBox.Text = "Data"
        '
        'generateButton
        '
        Me.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.generateButton.Location = New System.Drawing.Point(16, 64)
        Me.generateButton.Name = "generateButton"
        Me.generateButton.Size = New System.Drawing.Size(120, 23)
        Me.generateButton.TabIndex = 3
        Me.generateButton.Text = "Generate"
        '
        'numberOfPointsLabel
        '
        Me.numberOfPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numberOfPointsLabel.Location = New System.Drawing.Point(16, 24)
        Me.numberOfPointsLabel.Name = "numberOfPointsLabel"
        Me.numberOfPointsLabel.Size = New System.Drawing.Size(120, 16)
        Me.numberOfPointsLabel.TabIndex = 2
        Me.numberOfPointsLabel.Text = "Number of Points"
        '
        'numberOfPointsNumericEdit
        '
        Me.numberOfPointsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfPointsNumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.numberOfPointsNumericEdit.Name = "numberOfPointsNumericEdit"
        Me.numberOfPointsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfPointsNumericEdit.Range = New NationalInstruments.UI.Range(2, Double.PositiveInfinity)
        Me.numberOfPointsNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.numberOfPointsNumericEdit.TabIndex = 40
        Me.numberOfPointsNumericEdit.Value = 10
        '
        'lineToBaseGroupBox
        '
        Me.lineToBaseGroupBox.Controls.Add(Me.lineToBaseLineWidthLabel)
        Me.lineToBaseGroupBox.Controls.Add(Me.lineToBaseLedLabel)
        Me.lineToBaseGroupBox.Controls.Add(Me.lineToBaseStyleComboBox)
        Me.lineToBaseGroupBox.Controls.Add(Me.lineToBaseStyleLabel)
        Me.lineToBaseGroupBox.Controls.Add(Me.lineToBaseColorLed)
        Me.lineToBaseGroupBox.Controls.Add(Me.lineToBaseLineWidthNumericEdit)
        Me.lineToBaseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lineToBaseGroupBox.Location = New System.Drawing.Point(192, 280)
        Me.lineToBaseGroupBox.Name = "lineToBaseGroupBox"
        Me.lineToBaseGroupBox.Size = New System.Drawing.Size(168, 168)
        Me.lineToBaseGroupBox.TabIndex = 34
        Me.lineToBaseGroupBox.TabStop = False
        Me.lineToBaseGroupBox.Text = "Line to Base"
        '
        'lineToBaseLineWidthLabel
        '
        Me.lineToBaseLineWidthLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lineToBaseLineWidthLabel.Location = New System.Drawing.Point(16, 64)
        Me.lineToBaseLineWidthLabel.Name = "lineToBaseLineWidthLabel"
        Me.lineToBaseLineWidthLabel.Size = New System.Drawing.Size(128, 16)
        Me.lineToBaseLineWidthLabel.TabIndex = 25
        Me.lineToBaseLineWidthLabel.Text = "Line to Base Line Width:"
        '
        'lineToBaseLedLabel
        '
        Me.lineToBaseLedLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lineToBaseLedLabel.Location = New System.Drawing.Point(64, 104)
        Me.lineToBaseLedLabel.Name = "lineToBaseLedLabel"
        Me.lineToBaseLedLabel.Size = New System.Drawing.Size(40, 16)
        Me.lineToBaseLedLabel.TabIndex = 19
        Me.lineToBaseLedLabel.Text = "Color"
        '
        'lineToBaseStyleComboBox
        '
        Me.lineToBaseStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lineToBaseStyleComboBox.Location = New System.Drawing.Point(16, 40)
        Me.lineToBaseStyleComboBox.Name = "lineToBaseStyleComboBox"
        Me.lineToBaseStyleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.lineToBaseStyleComboBox.TabIndex = 20
        '
        'lineToBaseStyleLabel
        '
        Me.lineToBaseStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lineToBaseStyleLabel.Location = New System.Drawing.Point(16, 24)
        Me.lineToBaseStyleLabel.Name = "lineToBaseStyleLabel"
        Me.lineToBaseStyleLabel.Size = New System.Drawing.Size(64, 16)
        Me.lineToBaseStyleLabel.TabIndex = 21
        Me.lineToBaseStyleLabel.Text = "Style:"
        '
        'lineToBaseColorLed
        '
        Me.lineToBaseColorLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.lineToBaseColorLed.Location = New System.Drawing.Point(56, 120)
        Me.lineToBaseColorLed.Name = "lineToBaseColorLed"
        Me.lineToBaseColorLed.Size = New System.Drawing.Size(40, 40)
        Me.lineToBaseColorLed.TabIndex = 40
        Me.lineToBaseColorLed.Value = True
        '
        'lineToBaseLineWidthNumericEdit
        '
        Me.lineToBaseLineWidthNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.lineToBaseLineWidthNumericEdit.Location = New System.Drawing.Point(16, 80)
        Me.lineToBaseLineWidthNumericEdit.Name = "lineToBaseLineWidthNumericEdit"
        Me.lineToBaseLineWidthNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.lineToBaseLineWidthNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.lineToBaseLineWidthNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.lineToBaseLineWidthNumericEdit.TabIndex = 39
        Me.lineToBaseLineWidthNumericEdit.Value = 1
        '
        'fillToBaseGroupBox
        '
        Me.fillToBaseGroupBox.Controls.Add(Me.fillToBaseStyleLabel)
        Me.fillToBaseGroupBox.Controls.Add(Me.fillToBaseStyleComboBox)
        Me.fillToBaseGroupBox.Controls.Add(Me.fillToBaseLedLabel)
        Me.fillToBaseGroupBox.Controls.Add(Me.fillToBaseColorLed)
        Me.fillToBaseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fillToBaseGroupBox.Location = New System.Drawing.Point(16, 320)
        Me.fillToBaseGroupBox.Name = "fillToBaseGroupBox"
        Me.fillToBaseGroupBox.Size = New System.Drawing.Size(160, 128)
        Me.fillToBaseGroupBox.TabIndex = 33
        Me.fillToBaseGroupBox.TabStop = False
        Me.fillToBaseGroupBox.Text = "Fill to Base"
        '
        'fillToBaseStyleLabel
        '
        Me.fillToBaseStyleLabel.Location = New System.Drawing.Point(16, 24)
        Me.fillToBaseStyleLabel.Name = "fillToBaseStyleLabel"
        Me.fillToBaseStyleLabel.Size = New System.Drawing.Size(96, 16)
        Me.fillToBaseStyleLabel.TabIndex = 18
        Me.fillToBaseStyleLabel.Text = "Style:"
        '
        'fillToBaseStyleComboBox
        '
        Me.fillToBaseStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.fillToBaseStyleComboBox.Location = New System.Drawing.Point(16, 40)
        Me.fillToBaseStyleComboBox.Name = "fillToBaseStyleComboBox"
        Me.fillToBaseStyleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.fillToBaseStyleComboBox.TabIndex = 17
        '
        'fillToBaseLedLabel
        '
        Me.fillToBaseLedLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fillToBaseLedLabel.Location = New System.Drawing.Point(56, 64)
        Me.fillToBaseLedLabel.Name = "fillToBaseLedLabel"
        Me.fillToBaseLedLabel.Size = New System.Drawing.Size(40, 16)
        Me.fillToBaseLedLabel.TabIndex = 14
        Me.fillToBaseLedLabel.Text = "Color"
        '
        'fillToBaseColorLed
        '
        Me.fillToBaseColorLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.fillToBaseColorLed.Location = New System.Drawing.Point(56, 80)
        Me.fillToBaseColorLed.Name = "fillToBaseColorLed"
        Me.fillToBaseColorLed.Size = New System.Drawing.Size(40, 40)
        Me.fillToBaseColorLed.TabIndex = 39
        Me.fillToBaseColorLed.Value = True
        '
        'baseXValueLabel
        '
        Me.baseXValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.baseXValueLabel.Location = New System.Drawing.Point(16, 176)
        Me.baseXValueLabel.Name = "baseXValueLabel"
        Me.baseXValueLabel.Size = New System.Drawing.Size(80, 16)
        Me.baseXValueLabel.TabIndex = 27
        Me.baseXValueLabel.Text = "Base X Value:"
        '
        'fillToBaseWaveformGraph
        '
        Me.fillToBaseWaveformGraph.Location = New System.Drawing.Point(7, 8)
        Me.fillToBaseWaveformGraph.Name = "fillToBaseWaveformGraph"
        Me.fillToBaseWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.fillToBasePlot})
        Me.fillToBaseWaveformGraph.Size = New System.Drawing.Size(352, 160)
        Me.fillToBaseWaveformGraph.TabIndex = 36
        Me.fillToBaseWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.mainXAxis})
        Me.fillToBaseWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.mainYAxis})
        '
        'fillToBasePlot
        '
        Me.fillToBasePlot.XAxis = Me.mainXAxis
        Me.fillToBasePlot.YAxis = Me.mainYAxis
        '
        'mainYAxis
        '
        Me.mainYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.mainYAxis.Range = New NationalInstruments.UI.Range(0, 100)
        '
        'baseXValueNumericEdit
        '
        Me.baseXValueNumericEdit.Location = New System.Drawing.Point(16, 192)
        Me.baseXValueNumericEdit.Name = "baseXValueNumericEdit"
        Me.baseXValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.baseXValueNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.baseXValueNumericEdit.TabIndex = 37
        '
        'baseYValueNumericEdit
        '
        Me.baseYValueNumericEdit.Location = New System.Drawing.Point(96, 192)
        Me.baseYValueNumericEdit.Name = "baseYValueNumericEdit"
        Me.baseYValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.baseYValueNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.baseYValueNumericEdit.TabIndex = 38
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(366, 460)
        Me.Controls.Add(Me.baseYValueNumericEdit)
        Me.Controls.Add(Me.baseXValueNumericEdit)
        Me.Controls.Add(Me.fillToBaseWaveformGraph)
        Me.Controls.Add(Me.fillModeComboBox)
        Me.Controls.Add(Me.fillBaseLabel)
        Me.Controls.Add(Me.fillBaseComboBox)
        Me.Controls.Add(Me.baseYValueLabel)
        Me.Controls.Add(Me.dataGroupBox)
        Me.Controls.Add(Me.lineToBaseGroupBox)
        Me.Controls.Add(Me.fillToBaseGroupBox)
        Me.Controls.Add(Me.baseXValueLabel)
        Me.Controls.Add(Me.fillModeLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "To Base"
        Me.dataGroupBox.ResumeLayout(False)
        CType(Me.numberOfPointsNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lineToBaseGroupBox.ResumeLayout(False)
        CType(Me.lineToBaseColorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lineToBaseLineWidthNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fillToBaseGroupBox.ResumeLayout(False)
        CType(Me.fillToBaseColorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fillToBaseWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.baseXValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.baseYValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Shared Function GenerateRandomData(ByVal numDataPoints As Integer) As Double()
        Dim data(numDataPoints) As Double
        Dim random As New Random
        Dim i As Integer
        For i = 0 To numDataPoints - 1
            data(i) = random.NextDouble() * 100
        Next i
        Return data
    End Function 'GenerateRandomData

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Setup the UI with the values from the control.
        baseXValueNumericEdit.Value = fillToBasePlot.BaseXValue
        baseYValueNumericEdit.Value = fillToBasePlot.BaseYValue

        fillBaseComboBox.Items.Add(NationalInstruments.UI.XYPlotFillBase.XValue)
        fillBaseComboBox.Items.Add(NationalInstruments.UI.XYPlotFillBase.YValue)
        fillBaseComboBox.SelectedItem = fillToBasePlot.FillBase

        fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.Bins)
        fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.Fill)
        fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.FillAndBins)
        fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.FillAndLines)
        fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.Lines)
        fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.None)
        fillModeComboBox.SelectedItem = fillToBasePlot.FillMode

        Dim values As Array = NationalInstruments.UI.FillStyle.GetValues(fillToBasePlot.FillToBaseStyle.UnderlyingType)
        Dim vls(values.Length - 1) As Object
        Dim i As Integer
        For i = 0 To values.Length - 1
            vls(i) = values.GetValue(i)
        Next i
        fillToBaseStyleComboBox.Items.AddRange(vls)
        fillToBaseStyleComboBox.SelectedItem = fillToBasePlot.FillToBaseStyle

        values = NationalInstruments.UI.LineStyle.GetValues(fillToBasePlot.LineToBaseStyle.UnderlyingType)
        vls = New Object(values.Length - 1) {}
        For i = 0 To values.Length - 1
            vls(i) = values.GetValue(i)
        Next i
        lineToBaseStyleComboBox.Items.AddRange(vls)
        lineToBaseStyleComboBox.SelectedItem = fillToBasePlot.LineToBaseStyle

        lineToBaseLineWidthNumericEdit.Value = fillToBasePlot.LineToBaseWidth

        fillToBaseColorLed.OnColor = fillToBasePlot.FillToBaseColor
        lineToBaseColorLed.OnColor = fillToBasePlot.LineToBaseColor

        Dim d As Double() = GenerateRandomData(10)
        fillToBaseWaveformGraph.PlotY(d)
    End Sub

    Private Sub baseXValueNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles baseXValueNumericEdit.AfterChangeValue
        fillToBasePlot.BaseXValue = e.NewValue
    End Sub

    Private Sub baseYValueNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles baseYValueNumericEdit.AfterChangeValue
        fillToBasePlot.BaseYValue = e.NewValue
    End Sub

    Private Sub fillBaseComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fillBaseComboBox.SelectedIndexChanged
        fillToBasePlot.FillBase = CType(fillBaseComboBox.SelectedItem, NationalInstruments.UI.XYPlotFillBase)
    End Sub

    Private Sub fillModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fillModeComboBox.SelectedIndexChanged
        fillToBasePlot.FillMode = CType(fillModeComboBox.SelectedItem, NationalInstruments.UI.PlotFillMode)
    End Sub

    Private Sub generateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateButton.Click
        Dim d As Double() = GenerateRandomData(Convert.ToInt32(numberOfPointsNumericEdit.Value))
        fillToBaseWaveformGraph.PlotY(d)
    End Sub

    Private Sub fillToBaseStyleComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fillToBaseStyleComboBox.SelectedIndexChanged
        fillToBasePlot.FillToBaseStyle = CType(fillToBaseStyleComboBox.SelectedItem, NationalInstruments.UI.FillStyle)
    End Sub

    Private Sub lineToBaseStyleComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lineToBaseStyleComboBox.SelectedIndexChanged
        fillToBasePlot.LineToBaseStyle = CType(lineToBaseStyleComboBox.SelectedItem, NationalInstruments.UI.LineStyle)
    End Sub

    Private Sub lineToBaseLineWidthNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles lineToBaseLineWidthNumericEdit.AfterChangeValue
        fillToBasePlot.LineToBaseWidth = Convert.ToSingle(e.NewValue)
    End Sub

    Private Sub fillToBaseColorLed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fillToBaseColorLed.Click
        applicationColorDialog.Color = fillToBasePlot.FillToBaseColor
        If applicationColorDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Return
        End If
        fillToBaseColorLed.OnColor = applicationColorDialog.Color
        fillToBasePlot.FillToBaseColor = applicationColorDialog.Color
    End Sub

    Private Sub lineToBaseColorLed_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lineToBaseColorLed.Click
        applicationColorDialog.Color = fillToBasePlot.LineToBaseColor
        If applicationColorDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Return
        End If
        lineToBaseColorLed.OnColor = applicationColorDialog.Color
        fillToBasePlot.LineToBaseColor = applicationColorDialog.Color
    End Sub
End Class
