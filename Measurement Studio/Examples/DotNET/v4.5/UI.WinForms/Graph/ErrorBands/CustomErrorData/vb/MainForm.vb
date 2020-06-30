Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Const pointCount As Integer = 60
    Private xData() As Double
    Private yData() As Double
    Private explicitErrorMode As ExplicitErrorMode
    Private combinationErrorMode As combinationErrorMode

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
    Friend WithEvents errorModeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents limitNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents limitLabel As System.Windows.Forms.Label
    Friend WithEvents thresholdNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents thresholdLabel As System.Windows.Forms.Label
    Friend WithEvents percentNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents percentOffsetLabel As System.Windows.Forms.Label
    Friend WithEvents constantNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents constantOffsetLabel As System.Windows.Forms.Label
    Friend WithEvents explicitModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents combinationModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents noneModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents scatterPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents spacerPanel As System.Windows.Forms.Panel
    Friend WithEvents sampleScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.errorModeGroupBox = New System.Windows.Forms.GroupBox
        Me.limitNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.limitLabel = New System.Windows.Forms.Label
        Me.thresholdNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.thresholdLabel = New System.Windows.Forms.Label
        Me.percentNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.percentOffsetLabel = New System.Windows.Forms.Label
        Me.constantNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.constantOffsetLabel = New System.Windows.Forms.Label
        Me.explicitModeRadioButton = New System.Windows.Forms.RadioButton
        Me.combinationModeRadioButton = New System.Windows.Forms.RadioButton
        Me.noneModeRadioButton = New System.Windows.Forms.RadioButton
        Me.sampleScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.scatterPlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.spacerPanel = New System.Windows.Forms.Panel
        Me.errorModeGroupBox.SuspendLayout()
        CType(Me.limitNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.thresholdNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.percentNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.constantNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'errorModeGroupBox
        '
        Me.errorModeGroupBox.Controls.Add(Me.limitNumericEdit)
        Me.errorModeGroupBox.Controls.Add(Me.limitLabel)
        Me.errorModeGroupBox.Controls.Add(Me.thresholdNumericEdit)
        Me.errorModeGroupBox.Controls.Add(Me.thresholdLabel)
        Me.errorModeGroupBox.Controls.Add(Me.percentNumericEdit)
        Me.errorModeGroupBox.Controls.Add(Me.percentOffsetLabel)
        Me.errorModeGroupBox.Controls.Add(Me.constantNumericEdit)
        Me.errorModeGroupBox.Controls.Add(Me.constantOffsetLabel)
        Me.errorModeGroupBox.Controls.Add(Me.explicitModeRadioButton)
        Me.errorModeGroupBox.Controls.Add(Me.combinationModeRadioButton)
        Me.errorModeGroupBox.Controls.Add(Me.noneModeRadioButton)
        Me.errorModeGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.errorModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.errorModeGroupBox.Location = New System.Drawing.Point(8, 278)
        Me.errorModeGroupBox.Name = "errorModeGroupBox"
        Me.errorModeGroupBox.Size = New System.Drawing.Size(376, 224)
        Me.errorModeGroupBox.TabIndex = 7
        Me.errorModeGroupBox.TabStop = False
        Me.errorModeGroupBox.Text = "Custom &Error Data Modes"
        '
        'limitNumericEdit
        '
        Me.limitNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0")
        Me.limitNumericEdit.Location = New System.Drawing.Point(72, 80)
        Me.limitNumericEdit.Name = "limitNumericEdit"
        Me.limitNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.limitNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.limitNumericEdit.Size = New System.Drawing.Size(77, 20)
        Me.limitNumericEdit.TabIndex = 5
        Me.limitNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.limitNumericEdit.Value = 2
        '
        'limitLabel
        '
        Me.limitLabel.Location = New System.Drawing.Point(32, 80)
        Me.limitLabel.Name = "limitLabel"
        Me.limitLabel.Size = New System.Drawing.Size(32, 20)
        Me.limitLabel.TabIndex = 4
        Me.limitLabel.Text = "&Limit:"
        Me.limitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'thresholdNumericEdit
        '
        Me.thresholdNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0")
        Me.thresholdNumericEdit.Location = New System.Drawing.Point(128, 192)
        Me.thresholdNumericEdit.Name = "thresholdNumericEdit"
        Me.thresholdNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.thresholdNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.thresholdNumericEdit.Size = New System.Drawing.Size(77, 20)
        Me.thresholdNumericEdit.TabIndex = 12
        Me.thresholdNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.thresholdNumericEdit.Value = 10
        '
        'thresholdLabel
        '
        Me.thresholdLabel.Location = New System.Drawing.Point(32, 192)
        Me.thresholdLabel.Name = "thresholdLabel"
        Me.thresholdLabel.Size = New System.Drawing.Size(88, 20)
        Me.thresholdLabel.TabIndex = 11
        Me.thresholdLabel.Text = "&Threshold:"
        Me.thresholdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'percentNumericEdit
        '
        Me.percentNumericEdit.CoercionInterval = 0.1
        Me.percentNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("0.##%")
        Me.percentNumericEdit.Location = New System.Drawing.Point(128, 164)
        Me.percentNumericEdit.Name = "percentNumericEdit"
        Me.percentNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.percentNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.percentNumericEdit.Size = New System.Drawing.Size(77, 20)
        Me.percentNumericEdit.TabIndex = 10
        Me.percentNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.percentNumericEdit.Value = 0.25
        '
        'percentOffsetLabel
        '
        Me.percentOffsetLabel.Location = New System.Drawing.Point(32, 164)
        Me.percentOffsetLabel.Name = "percentOffsetLabel"
        Me.percentOffsetLabel.Size = New System.Drawing.Size(88, 20)
        Me.percentOffsetLabel.TabIndex = 9
        Me.percentOffsetLabel.Text = "&Percent Offset:"
        Me.percentOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'constantNumericEdit
        '
        Me.constantNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0")
        Me.constantNumericEdit.Location = New System.Drawing.Point(128, 136)
        Me.constantNumericEdit.Name = "constantNumericEdit"
        Me.constantNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.constantNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.constantNumericEdit.Size = New System.Drawing.Size(77, 20)
        Me.constantNumericEdit.TabIndex = 8
        Me.constantNumericEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.constantNumericEdit.Value = 2
        '
        'constantOffsetLabel
        '
        Me.constantOffsetLabel.Location = New System.Drawing.Point(32, 136)
        Me.constantOffsetLabel.Name = "constantOffsetLabel"
        Me.constantOffsetLabel.Size = New System.Drawing.Size(88, 20)
        Me.constantOffsetLabel.TabIndex = 7
        Me.constantOffsetLabel.Text = "C&onstant Offset:"
        Me.constantOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'explicitModeRadioButton
        '
        Me.explicitModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.explicitModeRadioButton.Location = New System.Drawing.Point(16, 52)
        Me.explicitModeRadioButton.Name = "explicitModeRadioButton"
        Me.explicitModeRadioButton.Size = New System.Drawing.Size(128, 24)
        Me.explicitModeRadioButton.TabIndex = 1
        Me.explicitModeRadioButton.Text = "&Explicit Error values"
        '
        'combinationModeRadioButton
        '
        Me.combinationModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.combinationModeRadioButton.Location = New System.Drawing.Point(16, 108)
        Me.combinationModeRadioButton.Name = "combinationModeRadioButton"
        Me.combinationModeRadioButton.Size = New System.Drawing.Size(200, 24)
        Me.combinationModeRadioButton.TabIndex = 6
        Me.combinationModeRadioButton.Text = "&Combination Constant/Percent"
        '
        'noneModeRadioButton
        '
        Me.noneModeRadioButton.Checked = True
        Me.noneModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noneModeRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.noneModeRadioButton.Name = "noneModeRadioButton"
        Me.noneModeRadioButton.Size = New System.Drawing.Size(128, 24)
        Me.noneModeRadioButton.TabIndex = 0
        Me.noneModeRadioButton.TabStop = True
        Me.noneModeRadioButton.Text = "&None"
        '
        'sampleScatterGraph
        '
        Me.sampleScatterGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleScatterGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleScatterGraph.Name = "scatterGraph"
        Me.sampleScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.scatterPlot})
        Me.sampleScatterGraph.Size = New System.Drawing.Size(376, 262)
        Me.sampleScatterGraph.TabIndex = 8
        Me.sampleScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'scatterPlot
        '
        Me.scatterPlot.CanScaleYAxis = True
        Me.scatterPlot.XAxis = Me.xAxis
        Me.scatterPlot.YAxis = Me.yAxis
        '
        'spacerPanel
        '
        Me.spacerPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.spacerPanel.Location = New System.Drawing.Point(8, 270)
        Me.spacerPanel.Name = "spacerPanel"
        Me.spacerPanel.Size = New System.Drawing.Size(376, 8)
        Me.spacerPanel.TabIndex = 9
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(392, 510)
        Me.Controls.Add(Me.sampleScatterGraph)
        Me.Controls.Add(Me.spacerPanel)
        Me.Controls.Add(Me.errorModeGroupBox)
        Me.DockPadding.All = 8
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(250, 456)
        Me.Name = "MainForm"
        Me.Text = "Custom Error Data"
        Me.errorModeGroupBox.ResumeLayout(False)
        CType(Me.limitNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.thresholdNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.percentNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.constantNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        xData = New Double(pointCount) {}
        yData = New Double(pointCount) {}

        Const regions As Integer = 3
        Const regionThreshold As Integer = pointCount / regions
        Dim threshold As Integer = -1

        Dim current As Double = 0.0
        Dim largeIncrement As Boolean = False
        Dim pointIncrement As Double = 0.0
        Dim i As Integer
        For i = 0 To pointCount
            If i > threshold Then
                threshold += regionThreshold
                largeIncrement = Not largeIncrement
                pointIncrement = IIf(largeIncrement, 2.0, -1.0)

            End If

            xData(i) = i
            yData(i) = current

            current += pointIncrement
        Next

        scatterPlot.PlotXY(xData, yData)

        limitNumericEdit.Range = New Range(0, pointCount / 2)
        thresholdNumericEdit.Range = New Range(0, pointCount)


        ResetCombinationErrorMode()
        explicitErrorMode = New ExplicitErrorMode(scatterPlot)
        noneModeRadioButton.Checked = True
    End Sub

    Private Sub noneModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noneModeRadioButton.CheckedChanged
        scatterPlot.YErrorDataMode = XYErrorDataMode.CreateNoneMode()
    End Sub


    Private Sub explicitModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles explicitModeRadioButton.CheckedChanged
        ResetExplicitErrorMode()
    End Sub

    Private Sub limitNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles limitNumericEdit.AfterChangeValue
        ResetExplicitErrorMode()
        explicitModeRadioButton.Checked = True
    End Sub

    Private Sub ResetExplicitErrorMode()
        If Not explicitErrorMode Is Nothing Then
            ' Create explicit error data to plot along with our data.
            Dim errorData() As Double = New Double(pointCount) {}

            Const min As Double = 1.0
            Dim max As Double = min + limitNumericEdit.Value

            Dim increment As Double = 0.5
            Dim current As Double = min
            Dim i As Integer
            For i = 0 To pointCount
                errorData(i) = current

                current += increment

                If current < min Or current > max Then
                    increment = -increment

                    current += increment
                End If
            Next


            scatterPlot.YErrorDataMode = explicitErrorMode
            explicitErrorMode.PlotXYWithError(xData, yData, errorData)
        End If
    End Sub


    Private Sub combinationModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combinationModeRadioButton.CheckedChanged
        scatterPlot.YErrorDataMode = combinationErrorMode
    End Sub

    Private Sub constantNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles constantNumericEdit.AfterChangeValue
        ResetCombinationErrorMode()
        combinationModeRadioButton.Checked = True
    End Sub

    Private Sub percentNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles percentNumericEdit.AfterChangeValue
        ResetCombinationErrorMode()
        combinationModeRadioButton.Checked = True
    End Sub

    Private Sub thresholdNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles thresholdNumericEdit.AfterChangeValue
        ResetCombinationErrorMode()
        combinationModeRadioButton.Checked = True
    End Sub

    Private Sub ResetCombinationErrorMode()
        combinationErrorMode = New CombinationErrorMode(constantNumericEdit.Value, percentNumericEdit.Value, CType(thresholdNumericEdit.Value, Integer))

        If combinationModeRadioButton.Checked Then
            scatterPlot.YErrorDataMode = combinationErrorMode
        End If
    End Sub
End Class
