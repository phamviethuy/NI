<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.commentTextBox = New System.Windows.Forms.TextBox()
        Me.controlsTabControl = New System.Windows.Forms.TabControl()
        Me.waveformGraphTabPage = New System.Windows.Forms.TabPage()
        Me.waveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph()
        Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot()
        Me.xAxis2 = New NationalInstruments.UI.XAxis()
        Me.yAxis2 = New NationalInstruments.UI.YAxis()
        Me.scatterGraphTabPage = New System.Windows.Forms.TabPage()
        Me.scatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph()
        Me.scatterPlot1 = New NationalInstruments.UI.ScatterPlot()
        Me.xAxis1 = New NationalInstruments.UI.XAxis()
        Me.yAxis1 = New NationalInstruments.UI.YAxis()
        Me.complexGraphTabPage = New System.Windows.Forms.TabPage()
        Me.complexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph()
        Me.complexPlot1 = New NationalInstruments.UI.ComplexPlot()
        Me.complexXAxis1 = New NationalInstruments.UI.ComplexXAxis()
        Me.complexYAxis1 = New NationalInstruments.UI.ComplexYAxis()
        Me.digitalWaveformGraphTabPage = New System.Windows.Forms.TabPage()
        Me.digitalWaveformGraph = New NationalInstruments.UI.WindowsForms.DigitalWaveformGraph()
        Me.intensityGraphTabPage = New System.Windows.Forms.TabPage()
        Me.intensityGraph = New NationalInstruments.UI.WindowsForms.IntensityGraph()
        Me.colorScale1 = New NationalInstruments.UI.ColorScale()
        Me.intensityPlot1 = New NationalInstruments.UI.IntensityPlot()
        Me.intensityXAxis1 = New NationalInstruments.UI.IntensityXAxis()
        Me.intensityYAxis1 = New NationalInstruments.UI.IntensityYAxis()
        Me.numericControlsTabPage = New System.Windows.Forms.TabPage()
        Me.slide = New NationalInstruments.UI.WindowsForms.Slide()
        Me.gauge = New NationalInstruments.UI.WindowsForms.Gauge()
        Me.uiLegend = New NationalInstruments.UI.WindowsForms.Legend()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.errorbandsLabel = New System.Windows.Forms.Label()
        Me.tooltipsLabel = New System.Windows.Forms.Label()
        Me.interpolateLabel = New System.Windows.Forms.Label()
        Me.animateLabel = New System.Windows.Forms.Label()
        Me.optionsLabel = New System.Windows.Forms.Label()
        Me.optionsSwitches = New NationalInstruments.UI.WindowsForms.SwitchArray()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.runSnippetButton = New System.Windows.Forms.Button()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.controlsComboBox = New System.Windows.Forms.ComboBox()
        Me.availableControlsLabel = New System.Windows.Forms.Label()
        Me.snipsComboBox = New System.Windows.Forms.ComboBox()
        Me.availableSnippetsLabel = New System.Windows.Forms.Label()
        Me.tableLayoutPanel1.SuspendLayout()
        Me.controlsTabControl.SuspendLayout()
        Me.waveformGraphTabPage.SuspendLayout()
        CType(Me.waveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scatterGraphTabPage.SuspendLayout()
        CType(Me.scatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.complexGraphTabPage.SuspendLayout()
        CType(Me.complexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.digitalWaveformGraphTabPage.SuspendLayout()
        CType(Me.digitalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.intensityGraphTabPage.SuspendLayout()
        CType(Me.intensityGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.numericControlsTabPage.SuspendLayout()
        CType(Me.slide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        Me.panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tableLayoutPanel1
        '
        Me.tableLayoutPanel1.ColumnCount = 3
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0!))
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.tableLayoutPanel1.Controls.Add(Me.commentTextBox, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.controlsTabControl, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.uiLegend, 2, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.panel1, 2, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.panel2, 2, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.panel3, 1, 3)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.tableLayoutPanel1.MinimumSize = New System.Drawing.Size(672, 0)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 4
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0!))
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(792, 572)
        Me.tableLayoutPanel1.TabIndex = 15
        '
        'commentTextBox
        '
        Me.commentTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.commentTextBox.Location = New System.Drawing.Point(3, 415)
        Me.commentTextBox.Multiline = True
        Me.commentTextBox.Name = "commentTextBox"
        Me.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.commentTextBox.Size = New System.Drawing.Size(356, 154)
        Me.commentTextBox.TabIndex = 10
        '
        'controlsTabControl
        '
        Me.tableLayoutPanel1.SetColumnSpan(Me.controlsTabControl, 2)
        Me.controlsTabControl.Controls.Add(Me.waveformGraphTabPage)
        Me.controlsTabControl.Controls.Add(Me.scatterGraphTabPage)
        Me.controlsTabControl.Controls.Add(Me.complexGraphTabPage)
        Me.controlsTabControl.Controls.Add(Me.digitalWaveformGraphTabPage)
        Me.controlsTabControl.Controls.Add(Me.intensityGraphTabPage)
        Me.controlsTabControl.Controls.Add(Me.numericControlsTabPage)
        Me.controlsTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.controlsTabControl.Location = New System.Drawing.Point(5, 5)
        Me.controlsTabControl.Margin = New System.Windows.Forms.Padding(5)
        Me.controlsTabControl.Name = "controlsTabControl"
        Me.tableLayoutPanel1.SetRowSpan(Me.controlsTabControl, 3)
        Me.controlsTabControl.SelectedIndex = 0
        Me.controlsTabControl.Size = New System.Drawing.Size(612, 402)
        Me.controlsTabControl.TabIndex = 1
        '
        'waveformGraphTabPage
        '
        Me.waveformGraphTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.waveformGraphTabPage.Controls.Add(Me.waveformGraph)
        Me.waveformGraphTabPage.Location = New System.Drawing.Point(4, 22)
        Me.waveformGraphTabPage.Name = "waveformGraphTabPage"
        Me.waveformGraphTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.waveformGraphTabPage.Size = New System.Drawing.Size(604, 376)
        Me.waveformGraphTabPage.TabIndex = 0
        Me.waveformGraphTabPage.Text = "Waveform Graph"
        Me.waveformGraphTabPage.UseVisualStyleBackColor = True
        '
        'waveformGraph
        '
        Me.waveformGraph.Caption = "Waveform Graph"
        Me.waveformGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.waveformGraph.Location = New System.Drawing.Point(3, 3)
        Me.waveformGraph.Name = "waveformGraph"
        Me.waveformGraph.PlotLineColorGenerator = NationalInstruments.UI.FixedSetColorGenerator.Dark
        Me.waveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1})
        Me.waveformGraph.Size = New System.Drawing.Size(598, 370)
        Me.waveformGraph.TabIndex = 0
        Me.waveformGraph.UseColorGenerator = True
        Me.waveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis2})
        Me.waveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis2})
        '
        'waveformPlot1
        '
        Me.waveformPlot1.LineColor = System.Drawing.Color.Sienna
        Me.waveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor
        Me.waveformPlot1.PointColor = System.Drawing.Color.GhostWhite
        Me.waveformPlot1.PointStyle = NationalInstruments.UI.PointStyle.Cross
        Me.waveformPlot1.XAxis = Me.xAxis2
        Me.waveformPlot1.YAxis = Me.yAxis2
        '
        'xAxis2
        '
        Me.xAxis2.Caption = "X-Axis"
        Me.xAxis2.MajorDivisions.GridColor = System.Drawing.Color.DimGray
        '
        'yAxis2
        '
        Me.yAxis2.Caption = "Y-Axis"
        Me.yAxis2.MajorDivisions.GridColor = System.Drawing.Color.DimGray
        Me.yAxis2.MajorDivisions.GridVisible = True
        '
        'scatterGraphTabPage
        '
        Me.scatterGraphTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.scatterGraphTabPage.Controls.Add(Me.scatterGraph)
        Me.scatterGraphTabPage.Location = New System.Drawing.Point(4, 22)
        Me.scatterGraphTabPage.Name = "scatterGraphTabPage"
        Me.scatterGraphTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.scatterGraphTabPage.Size = New System.Drawing.Size(604, 376)
        Me.scatterGraphTabPage.TabIndex = 1
        Me.scatterGraphTabPage.Text = "Scatter Graph"
        Me.scatterGraphTabPage.UseVisualStyleBackColor = True
        '
        'scatterGraph
        '
        Me.scatterGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scatterGraph.Location = New System.Drawing.Point(3, 3)
        Me.scatterGraph.Name = "scatterGraph"
        Me.scatterGraph.PlotLineColorGenerator = NationalInstruments.UI.FixedSetColorGenerator.Dark
        Me.scatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.scatterPlot1})
        Me.scatterGraph.Size = New System.Drawing.Size(598, 370)
        Me.scatterGraph.TabIndex = 0
        Me.scatterGraph.UseColorGenerator = True
        Me.scatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.scatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'scatterPlot1
        '
        Me.scatterPlot1.LineColor = System.Drawing.Color.Sienna
        Me.scatterPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor
        Me.scatterPlot1.PointColor = System.Drawing.Color.GhostWhite
        Me.scatterPlot1.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle
        Me.scatterPlot1.XAxis = Me.xAxis1
        Me.scatterPlot1.YAxis = Me.yAxis1
        '
        'xAxis1
        '
        Me.xAxis1.Caption = "X-Axis"
        '
        'yAxis1
        '
        Me.yAxis1.Caption = "Y-Axis"
        '
        'complexGraphTabPage
        '
        Me.complexGraphTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.complexGraphTabPage.Controls.Add(Me.complexGraph)
        Me.complexGraphTabPage.Location = New System.Drawing.Point(4, 22)
        Me.complexGraphTabPage.Name = "complexGraphTabPage"
        Me.complexGraphTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.complexGraphTabPage.Size = New System.Drawing.Size(604, 376)
        Me.complexGraphTabPage.TabIndex = 2
        Me.complexGraphTabPage.Text = "Complex Graph"
        Me.complexGraphTabPage.UseVisualStyleBackColor = True
        '
        'complexGraph
        '
        Me.complexGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.complexGraph.Location = New System.Drawing.Point(3, 3)
        Me.complexGraph.Name = "complexGraph"
        Me.complexGraph.PlotLineColorGenerator = NationalInstruments.UI.FixedSetColorGenerator.Dark
        Me.complexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.complexPlot1})
        Me.complexGraph.Size = New System.Drawing.Size(598, 370)
        Me.complexGraph.TabIndex = 0
        Me.complexGraph.UseColorGenerator = True
        Me.complexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.complexXAxis1})
        Me.complexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.complexYAxis1})
        '
        'complexPlot1
        '
        Me.complexPlot1.LineColor = System.Drawing.Color.Sienna
        Me.complexPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor
        Me.complexPlot1.PointColor = System.Drawing.Color.GhostWhite
        Me.complexPlot1.PointStyle = NationalInstruments.UI.PointStyle.EmptyDiamond
        Me.complexPlot1.XAxis = Me.complexXAxis1
        Me.complexPlot1.YAxis = Me.complexYAxis1
        '
        'complexXAxis1
        '
        Me.complexXAxis1.Caption = "Real Axis"
        '
        'complexYAxis1
        '
        Me.complexYAxis1.Caption = "Imaginary Axis"
        '
        'digitalWaveformGraphTabPage
        '
        Me.digitalWaveformGraphTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.digitalWaveformGraphTabPage.Controls.Add(Me.digitalWaveformGraph)
        Me.digitalWaveformGraphTabPage.Location = New System.Drawing.Point(4, 22)
        Me.digitalWaveformGraphTabPage.Name = "digitalWaveformGraphTabPage"
        Me.digitalWaveformGraphTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.digitalWaveformGraphTabPage.Size = New System.Drawing.Size(604, 376)
        Me.digitalWaveformGraphTabPage.TabIndex = 3
        Me.digitalWaveformGraphTabPage.Text = "Digital Waveform Graph"
        Me.digitalWaveformGraphTabPage.UseVisualStyleBackColor = True
        '
        'digitalWaveformGraph
        '
        Me.digitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.digitalWaveformGraph.Location = New System.Drawing.Point(3, 3)
        Me.digitalWaveformGraph.Name = "digitalWaveformGraph"
        Me.digitalWaveformGraph.Size = New System.Drawing.Size(598, 370)
        Me.digitalWaveformGraph.TabIndex = 0
        '
        '
        '
        Me.digitalWaveformGraph.XAxis.Caption = "X - Axis"
        '
        'intensityGraphTabPage
        '
        Me.intensityGraphTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.intensityGraphTabPage.Controls.Add(Me.intensityGraph)
        Me.intensityGraphTabPage.Location = New System.Drawing.Point(4, 22)
        Me.intensityGraphTabPage.Name = "intensityGraphTabPage"
        Me.intensityGraphTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.intensityGraphTabPage.Size = New System.Drawing.Size(604, 376)
        Me.intensityGraphTabPage.TabIndex = 5
        Me.intensityGraphTabPage.Text = "Intensity Graph"
        '
        'intensityGraph
        '
        Me.intensityGraph.ColorScales.AddRange(New NationalInstruments.UI.ColorScale() {Me.colorScale1})
        Me.intensityGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.intensityGraph.Location = New System.Drawing.Point(3, 3)
        Me.intensityGraph.Name = "intensityGraph"
        Me.intensityGraph.Plots.AddRange(New NationalInstruments.UI.IntensityPlot() {Me.intensityPlot1})
        Me.intensityGraph.Size = New System.Drawing.Size(598, 370)
        Me.intensityGraph.TabIndex = 0
        Me.intensityGraph.XAxes.AddRange(New NationalInstruments.UI.IntensityXAxis() {Me.intensityXAxis1})
        Me.intensityGraph.YAxes.AddRange(New NationalInstruments.UI.IntensityYAxis() {Me.intensityYAxis1})
        '
        'colorScale1
        '
        Me.colorScale1.Caption = "Colorscale Axis"
        '
        'intensityPlot1
        '
        Me.intensityPlot1.ColorScale = Me.colorScale1
        Me.intensityPlot1.XAxis = Me.intensityXAxis1
        Me.intensityPlot1.YAxis = Me.intensityYAxis1
        '
        'intensityXAxis1
        '
        Me.intensityXAxis1.Caption = "X-Axis"
        '
        'intensityYAxis1
        '
        Me.intensityYAxis1.Caption = "Y-Axis"
        '
        'numericControlsTabPage
        '
        Me.numericControlsTabPage.BackColor = System.Drawing.SystemColors.Window
        Me.numericControlsTabPage.Controls.Add(Me.slide)
        Me.numericControlsTabPage.Controls.Add(Me.gauge)
        Me.numericControlsTabPage.Location = New System.Drawing.Point(4, 22)
        Me.numericControlsTabPage.Name = "numericControlsTabPage"
        Me.numericControlsTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.numericControlsTabPage.Size = New System.Drawing.Size(604, 376)
        Me.numericControlsTabPage.TabIndex = 4
        Me.numericControlsTabPage.Text = "Numeric Controls"
        '
        'slide
        '
        Me.slide.Caption = "Slide"
        Me.slide.Dock = System.Windows.Forms.DockStyle.Left
        Me.slide.InteractionMode = NationalInstruments.UI.LinearNumericPointerInteractionModes.Indicator
        Me.slide.Location = New System.Drawing.Point(3, 3)
        Me.slide.Name = "slide"
        Me.slide.ScaleBaseLineVisible = True
        Me.slide.Size = New System.Drawing.Size(123, 370)
        Me.slide.TabIndex = 1
        '
        'gauge
        '
        Me.gauge.Caption = "Gauge"
        Me.gauge.Dock = System.Windows.Forms.DockStyle.Right
        Me.gauge.Location = New System.Drawing.Point(239, 3)
        Me.gauge.Name = "gauge"
        Me.gauge.ScaleBaseLineVisible = True
        Me.gauge.Size = New System.Drawing.Size(362, 370)
        Me.gauge.TabIndex = 0
        '
        'uiLegend
        '
        Me.uiLegend.Border = NationalInstruments.UI.Border.ThinFrame3D
        Me.uiLegend.Caption = "Legend"
        Me.uiLegend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uiLegend.Location = New System.Drawing.Point(627, 5)
        Me.uiLegend.Margin = New System.Windows.Forms.Padding(5)
        Me.uiLegend.Name = "uiLegend"
        Me.uiLegend.Size = New System.Drawing.Size(160, 130)
        Me.uiLegend.TabIndex = 2
        Me.uiLegend.VerticalScrollMode = NationalInstruments.UI.ScrollMode.[Auto]
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.errorbandsLabel)
        Me.panel1.Controls.Add(Me.tooltipsLabel)
        Me.panel1.Controls.Add(Me.interpolateLabel)
        Me.panel1.Controls.Add(Me.animateLabel)
        Me.panel1.Controls.Add(Me.optionsLabel)
        Me.panel1.Controls.Add(Me.optionsSwitches)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(625, 143)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(164, 154)
        Me.panel1.TabIndex = 6
        '
        'errorbandsLabel
        '
        Me.errorbandsLabel.AutoSize = True
        Me.errorbandsLabel.Location = New System.Drawing.Point(50, 129)
        Me.errorbandsLabel.Name = "errorbandsLabel"
        Me.errorbandsLabel.Size = New System.Drawing.Size(90, 13)
        Me.errorbandsLabel.TabIndex = 16
        Me.errorbandsLabel.Text = "Show error bands"
        '
        'tooltipsLabel
        '
        Me.tooltipsLabel.AutoSize = True
        Me.tooltipsLabel.Location = New System.Drawing.Point(50, 97)
        Me.tooltipsLabel.Name = "tooltipsLabel"
        Me.tooltipsLabel.Size = New System.Drawing.Size(100, 13)
        Me.tooltipsLabel.TabIndex = 18
        Me.tooltipsLabel.Text = "Show graph tooltips"
        '
        'interpolateLabel
        '
        Me.interpolateLabel.AutoSize = True
        Me.interpolateLabel.Location = New System.Drawing.Point(50, 66)
        Me.interpolateLabel.Name = "interpolateLabel"
        Me.interpolateLabel.Size = New System.Drawing.Size(88, 13)
        Me.interpolateLabel.TabIndex = 19
        Me.interpolateLabel.Text = "Interpolate colors"
        '
        'animateLabel
        '
        Me.animateLabel.AutoSize = True
        Me.animateLabel.Location = New System.Drawing.Point(50, 35)
        Me.animateLabel.Name = "animateLabel"
        Me.animateLabel.Size = New System.Drawing.Size(90, 13)
        Me.animateLabel.TabIndex = 17
        Me.animateLabel.Text = "Animate numerics"
        '
        'optionsLabel
        '
        Me.optionsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.optionsLabel.Location = New System.Drawing.Point(2, 3)
        Me.optionsLabel.Name = "optionsLabel"
        Me.optionsLabel.Size = New System.Drawing.Size(160, 20)
        Me.optionsLabel.TabIndex = 15
        Me.optionsLabel.Text = "Options"
        Me.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'optionsSwitches
        '
        '
        '
        '
        Me.optionsSwitches.ItemTemplate.Location = New System.Drawing.Point(0, 0)
        Me.optionsSwitches.ItemTemplate.Name = ""
        Me.optionsSwitches.ItemTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optionsSwitches.ItemTemplate.Size = New System.Drawing.Size(50, 30)
        Me.optionsSwitches.ItemTemplate.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalSlide3D
        Me.optionsSwitches.ItemTemplate.TabIndex = 0
        Me.optionsSwitches.ItemTemplate.TabStop = False
        Me.optionsSwitches.ItemTemplate.Value = True
        Me.optionsSwitches.Location = New System.Drawing.Point(2, 26)
        Me.optionsSwitches.Name = "optionsSwitches"
        Me.optionsSwitches.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(4)
        Me.optionsSwitches.Size = New System.Drawing.Size(53, 132)
        Me.optionsSwitches.TabIndex = 14
        '
        'panel2
        '
        Me.panel2.Controls.Add(Me.resetButton)
        Me.panel2.Controls.Add(Me.runSnippetButton)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel2.Location = New System.Drawing.Point(625, 303)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(164, 68)
        Me.panel2.TabIndex = 9
        '
        'resetButton
        '
        Me.resetButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.resetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resetButton.Location = New System.Drawing.Point(0, 36)
        Me.resetButton.Margin = New System.Windows.Forms.Padding(5)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(164, 32)
        Me.resetButton.TabIndex = 11
        Me.resetButton.Text = "Reset &Example"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'runSnippetButton
        '
        Me.runSnippetButton.Dock = System.Windows.Forms.DockStyle.Top
        Me.runSnippetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.runSnippetButton.Location = New System.Drawing.Point(0, 0)
        Me.runSnippetButton.Margin = New System.Windows.Forms.Padding(5)
        Me.runSnippetButton.Name = "runSnippetButton"
        Me.runSnippetButton.Size = New System.Drawing.Size(164, 32)
        Me.runSnippetButton.TabIndex = 9
        Me.runSnippetButton.Text = "Run &Snippet"
        Me.runSnippetButton.UseVisualStyleBackColor = True
        '
        'panel3
        '
        Me.tableLayoutPanel1.SetColumnSpan(Me.panel3, 2)
        Me.panel3.Controls.Add(Me.controlsComboBox)
        Me.panel3.Controls.Add(Me.availableControlsLabel)
        Me.panel3.Controls.Add(Me.snipsComboBox)
        Me.panel3.Controls.Add(Me.availableSnippetsLabel)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(365, 415)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(424, 154)
        Me.panel3.TabIndex = 11
        '
        'controlsComboBox
        '
        Me.controlsComboBox.FormattingEnabled = True
        Me.controlsComboBox.Location = New System.Drawing.Point(8, 27)
        Me.controlsComboBox.Name = "controlsComboBox"
        Me.controlsComboBox.Size = New System.Drawing.Size(409, 21)
        Me.controlsComboBox.TabIndex = 12
        '
        'availableControlsLabel
        '
        Me.availableControlsLabel.AutoSize = True
        Me.availableControlsLabel.Location = New System.Drawing.Point(8, 11)
        Me.availableControlsLabel.Name = "availableControlsLabel"
        Me.availableControlsLabel.Size = New System.Drawing.Size(91, 13)
        Me.availableControlsLabel.TabIndex = 11
        Me.availableControlsLabel.Text = "Available Controls"
        '
        'snipsComboBox
        '
        Me.snipsComboBox.FormattingEnabled = True
        Me.snipsComboBox.Location = New System.Drawing.Point(8, 74)
        Me.snipsComboBox.Name = "snipsComboBox"
        Me.snipsComboBox.Size = New System.Drawing.Size(409, 21)
        Me.snipsComboBox.TabIndex = 9
        '
        'availableSnippetsLabel
        '
        Me.availableSnippetsLabel.AutoSize = True
        Me.availableSnippetsLabel.Location = New System.Drawing.Point(8, 58)
        Me.availableSnippetsLabel.Name = "availableSnippetsLabel"
        Me.availableSnippetsLabel.Size = New System.Drawing.Size(190, 13)
        Me.availableSnippetsLabel.TabIndex = 10
        Me.availableSnippetsLabel.Text = "Available Snippets for Selected Control"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 572)
        Me.Controls.Add(Me.tableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(680, 560)
        Me.Name = "MainForm"
        Me.Text = "Measurement Studio UI Code Snippets"
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        Me.controlsTabControl.ResumeLayout(False)
        Me.waveformGraphTabPage.ResumeLayout(False)
        CType(Me.waveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scatterGraphTabPage.ResumeLayout(False)
        CType(Me.scatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.complexGraphTabPage.ResumeLayout(False)
        CType(Me.complexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.digitalWaveformGraphTabPage.ResumeLayout(False)
        CType(Me.digitalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.intensityGraphTabPage.ResumeLayout(False)
        CType(Me.intensityGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.numericControlsTabPage.ResumeLayout(False)
        CType(Me.slide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiLegend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.panel1.PerformLayout()
        Me.panel2.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents commentTextBox As System.Windows.Forms.TextBox
    Private WithEvents controlsTabControl As System.Windows.Forms.TabControl
    Private WithEvents waveformGraphTabPage As System.Windows.Forms.TabPage
    Private WithEvents waveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private WithEvents waveformPlot1 As NationalInstruments.UI.WaveformPlot
    Private WithEvents xAxis2 As NationalInstruments.UI.XAxis
    Private WithEvents yAxis2 As NationalInstruments.UI.YAxis
    Private WithEvents scatterGraphTabPage As System.Windows.Forms.TabPage
    Private WithEvents scatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Private WithEvents scatterPlot1 As NationalInstruments.UI.ScatterPlot
    Private WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Private WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Private WithEvents complexGraphTabPage As System.Windows.Forms.TabPage
    Private WithEvents complexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph
    Private WithEvents complexPlot1 As NationalInstruments.UI.ComplexPlot
    Private WithEvents complexXAxis1 As NationalInstruments.UI.ComplexXAxis
    Private WithEvents complexYAxis1 As NationalInstruments.UI.ComplexYAxis
    Private WithEvents digitalWaveformGraphTabPage As System.Windows.Forms.TabPage
    Private WithEvents digitalWaveformGraph As NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
    Private WithEvents intensityGraphTabPage As System.Windows.Forms.TabPage
    Private WithEvents intensityGraph As NationalInstruments.UI.WindowsForms.IntensityGraph
    Private WithEvents colorScale1 As NationalInstruments.UI.ColorScale
    Private WithEvents intensityPlot1 As NationalInstruments.UI.IntensityPlot
    Private WithEvents intensityXAxis1 As NationalInstruments.UI.IntensityXAxis
    Private WithEvents intensityYAxis1 As NationalInstruments.UI.IntensityYAxis
    Private WithEvents numericControlsTabPage As System.Windows.Forms.TabPage
    Private WithEvents slide As NationalInstruments.UI.WindowsForms.Slide
    Private WithEvents gauge As NationalInstruments.UI.WindowsForms.Gauge
    Private WithEvents uiLegend As NationalInstruments.UI.WindowsForms.Legend
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents errorbandsLabel As System.Windows.Forms.Label
    Private WithEvents tooltipsLabel As System.Windows.Forms.Label
    Private WithEvents interpolateLabel As System.Windows.Forms.Label
    Private WithEvents animateLabel As System.Windows.Forms.Label
    Private WithEvents optionsLabel As System.Windows.Forms.Label
    Private WithEvents optionsSwitches As NationalInstruments.UI.WindowsForms.SwitchArray
    Private WithEvents panel2 As System.Windows.Forms.Panel
    Private WithEvents resetButton As System.Windows.Forms.Button
    Private WithEvents runSnippetButton As System.Windows.Forms.Button
    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents controlsComboBox As System.Windows.Forms.ComboBox
    Private WithEvents availableControlsLabel As System.Windows.Forms.Label
    Private WithEvents snipsComboBox As System.Windows.Forms.ComboBox
    Private WithEvents availableSnippetsLabel As System.Windows.Forms.Label

End Class
