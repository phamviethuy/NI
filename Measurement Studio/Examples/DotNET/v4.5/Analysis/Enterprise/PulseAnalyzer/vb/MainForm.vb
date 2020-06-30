'==================================================================================================
'
' Title      : MainForm.cs
' Purpose    : This example shows the user how to use the Pulse Parameter function.
'
'==================================================================================================
Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Global Variables.
    Dim demoPulseWave() As Double = New Double(100) {}
    Dim pulseWave() As Double
    Dim xPosition() As Double
    Dim xWave() As Double = New Double(100) {}
    Dim counter As Integer = 0
    Dim demoClicked As Boolean = False
    Dim acquireClicked As Boolean = False
    Dim numOfTimerClick As Integer = 0  'records how many times timer has ticked.

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
    Friend WithEvents amp90Label As System.Windows.Forms.Label
    Friend WithEvents amp50Label As System.Windows.Forms.Label
    Friend WithEvents amp10Label As System.Windows.Forms.Label
    Friend WithEvents baseValueLabel As System.Windows.Forms.Label
    Friend WithEvents topValueLabel As System.Windows.Forms.Label
    Friend WithEvents overshootLabel As System.Windows.Forms.Label
    Friend WithEvents delayLabel As System.Windows.Forms.Label
    Friend WithEvents undershootLabel As System.Windows.Forms.Label
    Friend WithEvents widthLabel As System.Windows.Forms.Label
    Friend WithEvents fallTimeLabel As System.Windows.Forms.Label
    Friend WithEvents riseTimeLabel As System.Windows.Forms.Label
    Friend WithEvents slewRateLabel As System.Windows.Forms.Label
    Friend WithEvents messageDisplayLabel As System.Windows.Forms.Label
    Friend WithEvents demoButton As System.Windows.Forms.Button
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents pointPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xyCursor As NationalInstruments.UI.XYCursor
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Private WithEvents instructionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents acquireButton As System.Windows.Forms.Button
    Friend WithEvents analyzePulseButton As System.Windows.Forms.Button
    Friend WithEvents amp90NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents slewRateNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents fallTimeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents riseTimeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents dataWidthNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents delayNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents undershootNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents overshootNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents baseValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents topValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents amp10NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents amp50NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents pulseScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents outputParametersGroupBox As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.instructionTextBox = New System.Windows.Forms.TextBox
        Me.outputParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.amp90NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.slewRateNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.fallTimeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.riseTimeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.dataWidthNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.delayNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.undershootNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.overshootNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.baseValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.topValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amp10NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amp50NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amp90Label = New System.Windows.Forms.Label
        Me.amp50Label = New System.Windows.Forms.Label
        Me.amp10Label = New System.Windows.Forms.Label
        Me.baseValueLabel = New System.Windows.Forms.Label
        Me.topValueLabel = New System.Windows.Forms.Label
        Me.overshootLabel = New System.Windows.Forms.Label
        Me.delayLabel = New System.Windows.Forms.Label
        Me.undershootLabel = New System.Windows.Forms.Label
        Me.widthLabel = New System.Windows.Forms.Label
        Me.fallTimeLabel = New System.Windows.Forms.Label
        Me.riseTimeLabel = New System.Windows.Forms.Label
        Me.slewRateLabel = New System.Windows.Forms.Label
        Me.messageDisplayLabel = New System.Windows.Forms.Label
        Me.demoButton = New System.Windows.Forms.Button
        Me.acquireButton = New System.Windows.Forms.Button
        Me.analyzePulseButton = New System.Windows.Forms.Button
        Me.pulseScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.xyCursor = New NationalInstruments.UI.XYCursor
        Me.pointPlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.outputParametersGroupBox.SuspendLayout()
        CType(Me.amp90NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slewRateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fallTimeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.riseTimeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataWidthNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delayNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.undershootNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.overshootNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.baseValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.topValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amp10NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amp50NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pulseScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xyCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'instructionTextBox
        '
        Me.instructionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionTextBox.Location = New System.Drawing.Point(16, 8)
        Me.instructionTextBox.Multiline = True
        Me.instructionTextBox.Name = "instructionTextBox"
        Me.instructionTextBox.ReadOnly = True
        Me.instructionTextBox.Size = New System.Drawing.Size(472, 64)
        Me.instructionTextBox.TabIndex = 10
        Me.instructionTextBox.TabStop = False
        Me.instructionTextBox.Text = "Step 1 - Click the Aquire button to start a recording." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Step 2 - Create a pulse w" & _
        "aveform by dragging the graph cursor from left to right. " & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Step 3 - When you are" & _
        " done, stop the acquisition by choosing the Analyze button"
        '
        'outputParametersGroupBox
        '
        Me.outputParametersGroupBox.Controls.Add(Me.amp90NumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.slewRateNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.fallTimeNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.riseTimeNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.dataWidthNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.delayNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.undershootNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.overshootNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.baseValueNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.topValueNumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.amp10NumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.amp50NumericEdit)
        Me.outputParametersGroupBox.Controls.Add(Me.amp90Label)
        Me.outputParametersGroupBox.Controls.Add(Me.amp50Label)
        Me.outputParametersGroupBox.Controls.Add(Me.amp10Label)
        Me.outputParametersGroupBox.Controls.Add(Me.baseValueLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.topValueLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.overshootLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.delayLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.undershootLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.widthLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.fallTimeLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.riseTimeLabel)
        Me.outputParametersGroupBox.Controls.Add(Me.slewRateLabel)
        Me.outputParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.outputParametersGroupBox.Location = New System.Drawing.Point(16, 144)
        Me.outputParametersGroupBox.Name = "outputParametersGroupBox"
        Me.outputParametersGroupBox.Size = New System.Drawing.Size(320, 224)
        Me.outputParametersGroupBox.TabIndex = 11
        Me.outputParametersGroupBox.TabStop = False
        Me.outputParametersGroupBox.Text = "Output Parameters"
        '
        'amp90NumericEdit
        '
        Me.amp90NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.amp90NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.amp90NumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.amp90NumericEdit.Name = "amp90NumericEdit"
        Me.amp90NumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.amp90NumericEdit.TabIndex = 14
        Me.amp90NumericEdit.TabStop = False
        '
        'slewRateNumericEdit
        '
        Me.slewRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.slewRateNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.slewRateNumericEdit.Location = New System.Drawing.Point(224, 184)
        Me.slewRateNumericEdit.Name = "slewRateNumericEdit"
        Me.slewRateNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.slewRateNumericEdit.TabIndex = 13
        Me.slewRateNumericEdit.TabStop = False
        '
        'fallTimeNumericEdit
        '
        Me.fallTimeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.fallTimeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.fallTimeNumericEdit.Location = New System.Drawing.Point(120, 184)
        Me.fallTimeNumericEdit.Name = "fallTimeNumericEdit"
        Me.fallTimeNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.fallTimeNumericEdit.TabIndex = 12
        Me.fallTimeNumericEdit.TabStop = False
        '
        'riseTimeNumericEdit
        '
        Me.riseTimeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.riseTimeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.riseTimeNumericEdit.Location = New System.Drawing.Point(16, 184)
        Me.riseTimeNumericEdit.Name = "riseTimeNumericEdit"
        Me.riseTimeNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.riseTimeNumericEdit.TabIndex = 11
        Me.riseTimeNumericEdit.TabStop = False
        '
        'dataWidthNumericEdit
        '
        Me.dataWidthNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.dataWidthNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.dataWidthNumericEdit.Location = New System.Drawing.Point(224, 136)
        Me.dataWidthNumericEdit.Name = "dataWidthNumericEdit"
        Me.dataWidthNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.dataWidthNumericEdit.TabIndex = 10
        Me.dataWidthNumericEdit.TabStop = False
        '
        'delayNumericEdit
        '
        Me.delayNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.delayNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.delayNumericEdit.Location = New System.Drawing.Point(120, 136)
        Me.delayNumericEdit.Name = "delayNumericEdit"
        Me.delayNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.delayNumericEdit.TabIndex = 9
        Me.delayNumericEdit.TabStop = False
        '
        'undershootNumericEdit
        '
        Me.undershootNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.undershootNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.undershootNumericEdit.Location = New System.Drawing.Point(16, 136)
        Me.undershootNumericEdit.Name = "undershootNumericEdit"
        Me.undershootNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.undershootNumericEdit.TabIndex = 8
        Me.undershootNumericEdit.TabStop = False
        '
        'overshootNumericEdit
        '
        Me.overshootNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.overshootNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.overshootNumericEdit.Location = New System.Drawing.Point(224, 88)
        Me.overshootNumericEdit.Name = "overshootNumericEdit"
        Me.overshootNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.overshootNumericEdit.TabIndex = 7
        Me.overshootNumericEdit.TabStop = False
        '
        'baseValueNumericEdit
        '
        Me.baseValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.baseValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.baseValueNumericEdit.Location = New System.Drawing.Point(120, 88)
        Me.baseValueNumericEdit.Name = "baseValueNumericEdit"
        Me.baseValueNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.baseValueNumericEdit.TabIndex = 6
        Me.baseValueNumericEdit.TabStop = False
        '
        'topValueNumericEdit
        '
        Me.topValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.topValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.topValueNumericEdit.Location = New System.Drawing.Point(16, 88)
        Me.topValueNumericEdit.Name = "topValueNumericEdit"
        Me.topValueNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.topValueNumericEdit.TabIndex = 5
        Me.topValueNumericEdit.TabStop = False
        '
        'amp10NumericEdit
        '
        Me.amp10NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.amp10NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.amp10NumericEdit.Location = New System.Drawing.Point(224, 40)
        Me.amp10NumericEdit.Name = "amp10NumericEdit"
        Me.amp10NumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.amp10NumericEdit.TabIndex = 4
        Me.amp10NumericEdit.TabStop = False
        '
        'amp50NumericEdit
        '
        Me.amp50NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.amp50NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.amp50NumericEdit.Location = New System.Drawing.Point(120, 40)
        Me.amp50NumericEdit.Name = "amp50NumericEdit"
        Me.amp50NumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.amp50NumericEdit.TabIndex = 3
        Me.amp50NumericEdit.TabStop = False
        '
        'amp90Label
        '
        Me.amp90Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amp90Label.Location = New System.Drawing.Point(16, 24)
        Me.amp90Label.Name = "amp90Label"
        Me.amp90Label.Size = New System.Drawing.Size(88, 16)
        Me.amp90Label.TabIndex = 1
        Me.amp90Label.Text = "90 % Amplitude:"
        '
        'amp50Label
        '
        Me.amp50Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amp50Label.Location = New System.Drawing.Point(120, 24)
        Me.amp50Label.Name = "amp50Label"
        Me.amp50Label.Size = New System.Drawing.Size(88, 16)
        Me.amp50Label.TabIndex = 1
        Me.amp50Label.Text = "50 % Amplitude:"
        '
        'amp10Label
        '
        Me.amp10Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.amp10Label.Location = New System.Drawing.Point(224, 24)
        Me.amp10Label.Name = "amp10Label"
        Me.amp10Label.Size = New System.Drawing.Size(88, 16)
        Me.amp10Label.TabIndex = 1
        Me.amp10Label.Text = "10 % Amplitude:"
        '
        'baseValueLabel
        '
        Me.baseValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.baseValueLabel.Location = New System.Drawing.Point(120, 72)
        Me.baseValueLabel.Name = "baseValueLabel"
        Me.baseValueLabel.Size = New System.Drawing.Size(88, 16)
        Me.baseValueLabel.TabIndex = 1
        Me.baseValueLabel.Text = "Base Value:"
        '
        'topValueLabel
        '
        Me.topValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.topValueLabel.Location = New System.Drawing.Point(16, 72)
        Me.topValueLabel.Name = "topValueLabel"
        Me.topValueLabel.Size = New System.Drawing.Size(88, 16)
        Me.topValueLabel.TabIndex = 1
        Me.topValueLabel.Text = "Top Value:"
        '
        'overshootLabel
        '
        Me.overshootLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.overshootLabel.Location = New System.Drawing.Point(224, 72)
        Me.overshootLabel.Name = "overshootLabel"
        Me.overshootLabel.Size = New System.Drawing.Size(88, 16)
        Me.overshootLabel.TabIndex = 1
        Me.overshootLabel.Text = "Overshoot:"
        '
        'delayLabel
        '
        Me.delayLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.delayLabel.Location = New System.Drawing.Point(120, 120)
        Me.delayLabel.Name = "delayLabel"
        Me.delayLabel.Size = New System.Drawing.Size(88, 16)
        Me.delayLabel.TabIndex = 1
        Me.delayLabel.Text = "Delay:"
        '
        'undershootLabel
        '
        Me.undershootLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.undershootLabel.Location = New System.Drawing.Point(16, 120)
        Me.undershootLabel.Name = "undershootLabel"
        Me.undershootLabel.Size = New System.Drawing.Size(88, 16)
        Me.undershootLabel.TabIndex = 1
        Me.undershootLabel.Text = "Undershoot:"
        '
        'widthLabel
        '
        Me.widthLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.widthLabel.Location = New System.Drawing.Point(224, 120)
        Me.widthLabel.Name = "widthLabel"
        Me.widthLabel.Size = New System.Drawing.Size(88, 16)
        Me.widthLabel.TabIndex = 1
        Me.widthLabel.Text = "Width:"
        '
        'fallTimeLabel
        '
        Me.fallTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.fallTimeLabel.Location = New System.Drawing.Point(120, 168)
        Me.fallTimeLabel.Name = "fallTimeLabel"
        Me.fallTimeLabel.Size = New System.Drawing.Size(88, 16)
        Me.fallTimeLabel.TabIndex = 1
        Me.fallTimeLabel.Text = "Fall Time:"
        '
        'riseTimeLabel
        '
        Me.riseTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.riseTimeLabel.Location = New System.Drawing.Point(16, 168)
        Me.riseTimeLabel.Name = "riseTimeLabel"
        Me.riseTimeLabel.Size = New System.Drawing.Size(88, 16)
        Me.riseTimeLabel.TabIndex = 1
        Me.riseTimeLabel.Text = "Rise Time:"
        '
        'slewRateLabel
        '
        Me.slewRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.slewRateLabel.Location = New System.Drawing.Point(224, 168)
        Me.slewRateLabel.Name = "slewRateLabel"
        Me.slewRateLabel.Size = New System.Drawing.Size(88, 16)
        Me.slewRateLabel.TabIndex = 1
        Me.slewRateLabel.Text = "Slew Rate:"
        '
        'messageDisplayLabel
        '
        Me.messageDisplayLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.messageDisplayLabel.Location = New System.Drawing.Point(496, 72)
        Me.messageDisplayLabel.Name = "messageDisplayLabel"
        Me.messageDisplayLabel.Size = New System.Drawing.Size(256, 16)
        Me.messageDisplayLabel.TabIndex = 12
        Me.messageDisplayLabel.Text = "Plotting a series of points simulating a pulsed signal..."
        Me.messageDisplayLabel.Visible = False
        '
        'demoButton
        '
        Me.demoButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.demoButton.Location = New System.Drawing.Point(16, 96)
        Me.demoButton.Name = "demoButton"
        Me.demoButton.Size = New System.Drawing.Size(96, 24)
        Me.demoButton.TabIndex = 0
        Me.demoButton.Text = "Demo"
        Me.toolTip.SetToolTip(Me.demoButton, "Plot a series of points simulating a pulsed signal.")
        '
        'acquireButton
        '
        Me.acquireButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.acquireButton.Location = New System.Drawing.Point(128, 96)
        Me.acquireButton.Name = "acquireButton"
        Me.acquireButton.Size = New System.Drawing.Size(96, 24)
        Me.acquireButton.TabIndex = 1
        Me.acquireButton.Text = "Acquire"
        Me.toolTip.SetToolTip(Me.acquireButton, "Begin Recording - Create a pulse waveform by dragging the graph cursor.")
        '
        'analyzePulseButton
        '
        Me.analyzePulseButton.Enabled = False
        Me.analyzePulseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.analyzePulseButton.Location = New System.Drawing.Point(240, 96)
        Me.analyzePulseButton.Name = "analyzePulseButton"
        Me.analyzePulseButton.Size = New System.Drawing.Size(96, 24)
        Me.analyzePulseButton.TabIndex = 2
        Me.analyzePulseButton.Text = "Analyze Pulse"
        '
        'pulseScatterGraph
        '
        Me.pulseScatterGraph.Caption = "Pulse Waveform"
        Me.pulseScatterGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.xyCursor})
        Me.pulseScatterGraph.Location = New System.Drawing.Point(352, 88)
        Me.pulseScatterGraph.Name = "pulseScatterGraph"
        Me.pulseScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.pointPlot})
        Me.pulseScatterGraph.Size = New System.Drawing.Size(416, 280)
        Me.pulseScatterGraph.TabIndex = 16
        Me.pulseScatterGraph.TabStop = False
        Me.pulseScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.pulseScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'xyCursor
        '
        Me.xyCursor.Color = System.Drawing.Color.Yellow
        Me.xyCursor.Plot = Me.pointPlot
        Me.xyCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating
        Me.xyCursor.XPosition = 0
        '
        'pointPlot
        '
        Me.pointPlot.LineWidth = 3.0!
        Me.pointPlot.PointSize = New System.Drawing.Size(3, 3)
        Me.pointPlot.XAxis = Me.xAxis
        Me.pointPlot.YAxis = Me.yAxis
        '
        'xAxis
        '
        Me.xAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.xAxis.Range = New NationalInstruments.UI.Range(0, 100)
        '
        'yAxis
        '
        Me.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.yAxis.Range = New NationalInstruments.UI.Range(-50, 50)
        '
        'timer
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(778, 381)
        Me.Controls.Add(Me.messageDisplayLabel)
        Me.Controls.Add(Me.pulseScatterGraph)
        Me.Controls.Add(Me.acquireButton)
        Me.Controls.Add(Me.analyzePulseButton)
        Me.Controls.Add(Me.demoButton)
        Me.Controls.Add(Me.outputParametersGroupBox)
        Me.Controls.Add(Me.instructionTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pulse Analyzer "
        Me.toolTip.SetToolTip(Me, "This example features the PulseParameter function in the Advanced Analysis librar" & _
        "y.")
        Me.outputParametersGroupBox.ResumeLayout(False)
        CType(Me.amp90NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.slewRateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fallTimeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.riseTimeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataWidthNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delayNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.undershootNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.overshootNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.baseValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.topValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amp10NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amp50NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pulseScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xyCursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub


    Private Sub timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
        'When the demo button is clicked and timer has ticked.
        If demoClicked Then
            If (numOfTimerClick = 0) Then
                demoPulseWave.Initialize()
                xWave.Initialize()
            End If
            messageDisplayLabel.Visible = True
            timer.Interval = 100 'Set timer interval as 100 mili seconds.
            pointPlot.LineStyle = LineStyle.None
            pointPlot.PointStyle = PointStyle.SolidCircle
            pointPlot.PointColor = System.Drawing.Color.White
            'Bring the cursor to the current point that is being plotted.
            xyCursor.XPosition = numOfTimerClick
            xyCursor.YPosition = demoPulseWave(numOfTimerClick)
            'Plot point by point pulseWave.
            pointPlot.PlotXYAppend(numOfTimerClick, demoPulseWave(numOfTimerClick))
            numOfTimerClick = numOfTimerClick + 1
            If (numOfTimerClick = 101) Then
                numOfTimerClick = 0
                timer.Enabled = False 'Disable the timer.
                pointPlot.LineStyle = LineStyle.Solid
                pointPlot.LineColor = System.Drawing.Color.Tomato
                xyCursor.XPosition = 0
                xyCursor.YPosition = 5
                'Plot continuous pulse waveform.
                pointPlot.PlotXY(xWave, demoPulseWave)
                demoClicked = 0 'Make it zero as the demo is finished.
                PerformAnalysis(demoPulseWave) 'analyze the pulse and display data.
                messageDisplayLabel.Visible = False
            End If
        End If

        'When the acquire button is clicked and timer has ticked.
        If (acquireClicked) Then
            messageDisplayLabel.Visible = False
            timer.Interval = 20 'Set timer interval as 10 mili seconds.
            xPosition(counter) = xyCursor.XPosition 'Store cursor x position. 
            pulseWave(counter) = xyCursor.YPosition 'Store cursor y position.
            pointPlot.LineStyle = LineStyle.None
            pointPlot.PointStyle = PointStyle.SolidCircle
            pointPlot.PointColor = System.Drawing.Color.White
            'Plot the points of pulse.
            pointPlot.PlotXYAppend(xyCursor.XPosition, xyCursor.YPosition)
            counter = counter + 1 'Increment the counter. 
            'If xPosition and pulseWave array gets full, start filling it from zero, but it will result
            'in the loss of previous data. 
            If (counter = 1000) Then
                counter = 0
            End If
        End If

    End Sub

    Private Sub demoButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles demoButton.Click
        Dim i As Integer
        Dim upRamp() As Double = New Double(4) {}
        Dim downRamp() As Double = New Double(4) {}
        Dim noise() As Double = New Double(100) {}
        'Dim pulseWave() As Double = New Double(100) {}
        'Dim xWave() As Double = New Double(100) {}

        downRamp.Initialize()
        timer.Enabled = False 'disable the timer.
        pulseScatterGraph.ClearData() 'clear graph.
        numOfTimerClick = 0

        'Message displayed in the text box placed over the graph.
        messageDisplayLabel.Visible = True

        'Status of buttons.
        demoClicked = True
        acquireClicked = False

        'Generate an UpRamp of size 5.
        upRamp = PatternGeneration.Ramp(5, 0, 45)
        'Generate a downRamp of size 5.
        downRamp = PatternGeneration.Ramp(5, 45, 0)
        'Generation of White Noise.
        Dim whiteNoise As WhiteNoiseSignal = New WhiteNoiseSignal(1.0)
        noise = whiteNoise.Generate(10000, 101)

        'Generation of Noisy Pulse wave.
        For i = 0 To 4
            demoPulseWave(5 + i) = upRamp(i)
            demoPulseWave(10 + i) = 45
            demoPulseWave(15 + i) = downRamp(i)
        Next i
        For i = 0 To 100
            demoPulseWave(i) = demoPulseWave(i) + noise(i)
            xWave(i) = i
        Next i
        'Start the timer.
        timer.Start()
    End Sub

    Private Sub acquire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acquireButton.Click
        'Status of buttons.
        acquireClicked = True
        demoClicked = False

        'Make the counter zero.
        counter = 0
        pulseWave = New Double(1000) {}
        xPosition = New Double(1000) {}

        'Cursor is visible on the Graph.
        xyCursor.Visible = True
        'Initial position of the cursor.
        xyCursor.XPosition = 0
        xyCursor.YPosition = 5

        analyzePulseButton.Enabled = True 'Enable Stop Acquire Button.
        pulseScatterGraph.ClearData()
        timer.Start() ' Start the timer.
    End Sub

    Private Sub analyzePulse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles analyzePulseButton.Click
        Dim i As Integer
        'Allocate memory to store data points of pulse wave drawn by user.
        Dim xPulse() As Double = New Double(counter - 1) {}
        Dim yPulse() As Double = New Double(counter - 1) {}

        timer.Stop() 'Stop the timer.

        'Status of buttons on the panel.
        demoClicked = False
        acquireClicked = False

        'Store the xPosition and pulseWave in to xPulse and yPulse arrays.
        For i = 0 To (counter - 1)
            xPulse(i) = xPosition(i)
            yPulse(i) = pulseWave(i)
        Next i
        pointPlot.LineStyle = LineStyle.Solid
        pointPlot.LineColor = System.Drawing.Color.Tomato
        'Plot the continuous pulse wave.
        pointPlot.PlotXY(xPulse, yPulse)
        counter = 0 'Set counter equal to zero for the next acquiring of pulse wave.
        PerformAnalysis(yPulse) 'analyze the pulse and display data.
        analyzePulseButton.Enabled = False

    End Sub

    'To analyse pulse wave that has been drawn by user.
    Private Sub PerformAnalysis(ByVal yWave() As Double)
        Dim amplitude90Percent, amplitude50Percent, amplitude10Percent As Double
        Dim topVal, baseVal, overshootVal, undershootVal, slewRateVal As Double
        Dim delayVal, widthVal, riseTimeVal, fallTimeVal As Integer

        'Pulse parameters are being returned by the following function.
        SignalProcessing.PulseParameters(yWave, amplitude90Percent, amplitude50Percent, amplitude10Percent, topVal, baseVal, overshootVal, undershootVal, delayVal, widthVal, riseTimeVal, fallTimeVal, slewRateVal)

        'Display the data in the text boxes.
        amp90NumericEdit.Value = amplitude90Percent
        amp50NumericEdit.Value = amplitude50Percent
        amp10NumericEdit.Value = amplitude10Percent
        topValueNumericEdit.Value = topVal
        baseValueNumericEdit.Value = baseVal
        overshootNumericEdit.Value = overshootVal
        undershootNumericEdit.Value = undershootVal
        delayNumericEdit.Value = delayVal
        dataWidthNumericEdit.Value = widthVal
        riseTimeNumericEdit.Value = riseTimeVal
        fallTimeNumericEdit.Value = fallTimeVal
        slewRateNumericEdit.Value = slewRateVal
    End Sub


End Class
