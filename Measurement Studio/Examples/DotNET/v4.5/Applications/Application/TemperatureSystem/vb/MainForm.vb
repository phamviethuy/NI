Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms
Imports NationalInstruments.Analysis.Math

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private random As random
    Private analysisPlot As WaveformPlot
    Private utilityHelper As utilityHelper
    Private lastStatus As String


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        analysisPlot = New WaveformPlot
        analysisPlot.XAxis = New XAxis
        analysisPlot.YAxis = New YAxis
        InitializeComponent()
        random = New random
        
        upperLimitCursor.YPosition = 85
        lowerLimitCursor.YPosition = 75

        coldAnnotaion.RangeFillColor = Color.FromArgb(90, Color.Aqua)
        coldAnnotaion.RangeFillStyle = FillStyle.CreateVerticalGradient(coldAnnotaion.RangeFillColor, Color.Aqua)
        hotAnnotaion.RangeFillColor = Color.FromArgb(90, Color.Red)
        hotAnnotaion.RangeFillStyle = FillStyle.CreateVerticalGradient(Color.Red, hotAnnotaion.RangeFillColor)

        utilityHelper = New utilityHelper
        InitializeMenuHelperStrings(mainMenu.MenuItems)
        InitializeToolTips(mainToolBar.Buttons)
        MapToolBarAndMenuItems()

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
    Friend WithEvents analyzeMenu As System.Windows.Forms.MenuItem
    Friend WithEvents seperatorMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents exitMenu As System.Windows.Forms.MenuItem
    Friend WithEvents fileMenu As System.Windows.Forms.MenuItem
    Friend WithEvents acquireMenu As System.Windows.Forms.MenuItem
    Friend WithEvents systemDemoMenu As System.Windows.Forms.MenuItem
    Friend WithEvents rightPanel As System.Windows.Forms.Panel
    Friend WithEvents stdTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents meanTempTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents currentTemperatureThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents temperatureHistogramScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents temperatureHistoryWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents histogramPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents histogramXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents histogramYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents hotAnnotaion As NationalInstruments.UI.XYRangeAnnotation
    Friend WithEvents historyXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents historyYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents coldAnnotaion As NationalInstruments.UI.XYRangeAnnotation
    Friend WithEvents lowerLimitCursor As NationalInstruments.UI.XYCursor
    Friend WithEvents historyPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents upperLimitCursor As NationalInstruments.UI.XYCursor
    Friend WithEvents viewMenu As System.Windows.Forms.MenuItem
    Friend WithEvents toolBarMenu As System.Windows.Forms.MenuItem
    Friend WithEvents statusBarMenu As System.Windows.Forms.MenuItem
    Friend WithEvents helpMenu As System.Windows.Forms.MenuItem
    Friend WithEvents mainSplitter As System.Windows.Forms.Splitter
    Friend WithEvents toolBarImages As System.Windows.Forms.ImageList
    Friend WithEvents analyzeToolBar As System.Windows.Forms.ToolBarButton
    Friend WithEvents acquireToolBar As System.Windows.Forms.ToolBarButton
    Friend WithEvents leftPanel As System.Windows.Forms.Panel
    Friend WithEvents temperatureGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents upperLimitKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents lowLimitKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents histogramSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents minimumBinNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents minimumBinLabel As System.Windows.Forms.Label
    Friend WithEvents maximumBinNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents maximumBinLabel As System.Windows.Forms.Label
    Friend WithEvents offAcquireLabel As System.Windows.Forms.Label
    Friend WithEvents offAnalyzeLabel As System.Windows.Forms.Label
    Friend WithEvents onAcquireLabel As System.Windows.Forms.Label
    Friend WithEvents onAnalyzeLabel As System.Windows.Forms.Label
    Friend WithEvents updateRateSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents analyzeSwitch As NationalInstruments.UI.WindowsForms.Switch
    Friend WithEvents acquireSwitch As NationalInstruments.UI.WindowsForms.Switch
    Friend WithEvents mainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mainStatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents mainTimer As System.Windows.Forms.Timer
    Friend WithEvents mainToolBar As System.Windows.Forms.ToolBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.analyzeMenu = New System.Windows.Forms.MenuItem
        Me.seperatorMenuItem = New System.Windows.Forms.MenuItem
        Me.exitMenu = New System.Windows.Forms.MenuItem
        Me.fileMenu = New System.Windows.Forms.MenuItem
        Me.acquireMenu = New System.Windows.Forms.MenuItem
        Me.systemDemoMenu = New System.Windows.Forms.MenuItem
        Me.rightPanel = New System.Windows.Forms.Panel
        Me.stdTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.meanTempTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.currentTemperatureThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.temperatureHistogramScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.histogramPlot = New NationalInstruments.UI.ScatterPlot
        Me.histogramXAxis = New NationalInstruments.UI.XAxis
        Me.histogramYAxis = New NationalInstruments.UI.YAxis
        Me.temperatureHistoryWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.hotAnnotaion = New NationalInstruments.UI.XYRangeAnnotation
        Me.historyXAxis = New NationalInstruments.UI.XAxis
        Me.historyYAxis = New NationalInstruments.UI.YAxis
        Me.coldAnnotaion = New NationalInstruments.UI.XYRangeAnnotation
        Me.lowerLimitCursor = New NationalInstruments.UI.XYCursor
        Me.historyPlot = New NationalInstruments.UI.WaveformPlot
        Me.upperLimitCursor = New NationalInstruments.UI.XYCursor
        Me.viewMenu = New System.Windows.Forms.MenuItem
        Me.toolBarMenu = New System.Windows.Forms.MenuItem
        Me.statusBarMenu = New System.Windows.Forms.MenuItem
        Me.helpMenu = New System.Windows.Forms.MenuItem
        Me.mainSplitter = New System.Windows.Forms.Splitter
        Me.toolBarImages = New System.Windows.Forms.ImageList(Me.components)
        Me.analyzeToolBar = New System.Windows.Forms.ToolBarButton
        Me.acquireToolBar = New System.Windows.Forms.ToolBarButton
        Me.leftPanel = New System.Windows.Forms.Panel
        Me.temperatureGroupBox = New System.Windows.Forms.GroupBox
        Me.upperLimitKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.lowLimitKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.histogramSettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.minimumBinNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.minimumBinLabel = New System.Windows.Forms.Label
        Me.maximumBinNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.maximumBinLabel = New System.Windows.Forms.Label
        Me.offAcquireLabel = New System.Windows.Forms.Label
        Me.offAnalyzeLabel = New System.Windows.Forms.Label
        Me.onAcquireLabel = New System.Windows.Forms.Label
        Me.onAnalyzeLabel = New System.Windows.Forms.Label
        Me.updateRateSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.analyzeSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.acquireSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.mainMenu = New System.Windows.Forms.MainMenu
        Me.mainStatusBar = New System.Windows.Forms.StatusBar
        Me.mainTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mainToolBar = New System.Windows.Forms.ToolBar
        Me.rightPanel.SuspendLayout()
        CType(Me.stdTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.meanTempTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.currentTemperatureThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.temperatureHistogramScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.temperatureHistoryWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lowerLimitCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upperLimitCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.leftPanel.SuspendLayout()
        Me.temperatureGroupBox.SuspendLayout()
        CType(Me.upperLimitKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lowLimitKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.histogramSettingsGroupBox.SuspendLayout()
        CType(Me.minimumBinNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maximumBinNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updateRateSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.analyzeSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.acquireSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'analyzeMenu
        '
        Me.analyzeMenu.Checked = True
        Me.analyzeMenu.Index = 1
        Me.analyzeMenu.Text = "Analyze"
        '
        'seperatorMenuItem
        '
        Me.seperatorMenuItem.Index = 2
        Me.seperatorMenuItem.Text = "-"
        '
        'exitMenu
        '
        Me.exitMenu.Index = 3
        Me.exitMenu.Text = "Exit"
        '
        'fileMenu
        '
        Me.fileMenu.Index = 0
        Me.fileMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.acquireMenu, Me.analyzeMenu, Me.seperatorMenuItem, Me.exitMenu})
        Me.fileMenu.Text = "File"
        '
        'acquireMenu
        '
        Me.acquireMenu.Checked = True
        Me.acquireMenu.Index = 0
        Me.acquireMenu.Text = "Acquire"
        '
        'systemDemoMenu
        '
        Me.systemDemoMenu.Index = 0
        Me.systemDemoMenu.Text = "About System Demo..."
        '
        'rightPanel
        '
        Me.rightPanel.AutoScroll = True
        Me.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.rightPanel.Controls.Add(Me.stdTank)
        Me.rightPanel.Controls.Add(Me.meanTempTank)
        Me.rightPanel.Controls.Add(Me.currentTemperatureThermometer)
        Me.rightPanel.Controls.Add(Me.temperatureHistogramScatterGraph)
        Me.rightPanel.Controls.Add(Me.temperatureHistoryWaveformGraph)
        Me.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rightPanel.Location = New System.Drawing.Point(267, 28)
        Me.rightPanel.Name = "rightPanel"
        Me.rightPanel.Size = New System.Drawing.Size(677, 599)
        Me.rightPanel.TabIndex = 9
        '
        'stdTank
        '
        Me.stdTank.Caption = "Std Dev"
        Me.stdTank.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdTank.Location = New System.Drawing.Point(584, 344)
        Me.stdTank.Name = "stdTank"
        Me.stdTank.Size = New System.Drawing.Size(64, 224)
        Me.stdTank.TabIndex = 4
        Me.stdTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D
        '
        'meanTemptank
        '
        Me.meanTempTank.Caption = "Mean Temp"
        Me.meanTempTank.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meanTempTank.Location = New System.Drawing.Point(512, 344)
        Me.meanTempTank.Name = "meanTemptank"
        Me.meanTempTank.Range = New NationalInstruments.UI.Range(70, 90)
        Me.meanTempTank.Size = New System.Drawing.Size(64, 224)
        Me.meanTempTank.TabIndex = 3
        Me.meanTempTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D
        Me.meanTempTank.Value = 70
        '
        'currentTemperature
        '
        Me.currentTemperatureThermometer.Caption = "Currrent Temp"
        Me.currentTemperatureThermometer.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentTemperatureThermometer.Location = New System.Drawing.Point(584, 32)
        Me.currentTemperatureThermometer.Name = "currentTemperature"
        Me.currentTemperatureThermometer.Range = New NationalInstruments.UI.Range(70, 90)
        Me.currentTemperatureThermometer.Size = New System.Drawing.Size(72, 280)
        Me.currentTemperatureThermometer.TabIndex = 2
        Me.currentTemperatureThermometer.Value = 70
        '
        'temperatureHistogramGraph
        '
        Me.temperatureHistogramScatterGraph.Border = NationalInstruments.UI.Border.ThickFrame3D
        Me.temperatureHistogramScatterGraph.Caption = "Temperature Histogram"
        Me.temperatureHistogramScatterGraph.Location = New System.Drawing.Point(24, 336)
        Me.temperatureHistogramScatterGraph.Name = "temperatureHistogramGraph"
        Me.temperatureHistogramScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.histogramPlot})
        Me.temperatureHistogramScatterGraph.Size = New System.Drawing.Size(456, 232)
        Me.temperatureHistogramScatterGraph.TabIndex = 1
        Me.temperatureHistogramScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.histogramXAxis})
        Me.temperatureHistogramScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.histogramYAxis})
        '
        'histogramPlot
        '
        Me.histogramPlot.FillMode = NationalInstruments.UI.PlotFillMode.FillAndBins
        Me.histogramPlot.FillToBaseColor = System.Drawing.Color.DeepSkyBlue
        Me.histogramPlot.FillToBaseStyle = NationalInstruments.UI.FillStyle.VerticalGradient
        Me.histogramPlot.LineColor = System.Drawing.Color.Aqua
        Me.histogramPlot.LineStep = NationalInstruments.UI.LineStep.CenteredXYStep
        Me.histogramPlot.LineToBaseColor = System.Drawing.Color.Aqua
        Me.histogramPlot.XAxis = Me.histogramXAxis
        Me.histogramPlot.YAxis = Me.histogramYAxis
        '
        'histogramXAxis
        '
        Me.histogramXAxis.AutoSpacing = False
        Me.histogramXAxis.MinorDivisions.TickVisible = True
        Me.histogramXAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.histogramXAxis.Range = New NationalInstruments.UI.Range(65, 95)
        '
        'histogramYAxis
        '
        Me.histogramYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        '
        'temperatureHistoryGraph
        '
        Me.temperatureHistoryWaveformGraph.Annotations.AddRange(New NationalInstruments.UI.XYAnnotation() {Me.hotAnnotaion, Me.coldAnnotaion})
        Me.temperatureHistoryWaveformGraph.Border = NationalInstruments.UI.Border.ThickFrame3D
        Me.temperatureHistoryWaveformGraph.Caption = "Temperature History"
        Me.temperatureHistoryWaveformGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.lowerLimitCursor, Me.upperLimitCursor})
        Me.temperatureHistoryWaveformGraph.Location = New System.Drawing.Point(24, 24)
        Me.temperatureHistoryWaveformGraph.Name = "temperatureHistoryGraph"
        Me.temperatureHistoryWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.historyPlot})
        Me.temperatureHistoryWaveformGraph.Size = New System.Drawing.Size(536, 288)
        Me.temperatureHistoryWaveformGraph.TabIndex = 0
        Me.temperatureHistoryWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.historyXAxis})
        Me.temperatureHistoryWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.historyYAxis})
        '
        'hotAnnotaion
        '
        Me.hotAnnotaion.ArrowVisible = False
        Me.hotAnnotaion.Caption = "Hot"
        Me.hotAnnotaion.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopCenter, 0.0!, 5.0!)
        Me.hotAnnotaion.RangeFillColor = System.Drawing.Color.Red
        Me.hotAnnotaion.XAxis = Me.historyXAxis
        Me.hotAnnotaion.XRange = NationalInstruments.UI.Range.All
        Me.hotAnnotaion.YAxis = Me.historyYAxis
        Me.hotAnnotaion.YRange = New NationalInstruments.UI.Range(85, Double.PositiveInfinity)
        '
        'historyXAxis
        '
        Me.historyXAxis.AutoMinorDivisionFrequency = 4
        Me.historyXAxis.MajorDivisions.GridVisible = True
        Me.historyXAxis.MinorDivisions.GridVisible = True
        Me.historyXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart
        Me.historyXAxis.Range = New NationalInstruments.UI.Range(0, 100)
        '
        'historyYAxis
        '
        Me.historyYAxis.AutoMinorDivisionFrequency = 4
        Me.historyYAxis.MajorDivisions.GridVisible = True
        Me.historyYAxis.MinorDivisions.GridVisible = True
        Me.historyYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.historyYAxis.Range = New NationalInstruments.UI.Range(70, 90)
        '
        'coldAnnotaion
        '
        Me.coldAnnotaion.ArrowVisible = False
        Me.coldAnnotaion.Caption = "Cold"
        Me.coldAnnotaion.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.BottomCenter, 0.0!, -5.0!)
        Me.coldAnnotaion.RangeFillColor = System.Drawing.Color.Aqua
        Me.coldAnnotaion.XAxis = Me.historyXAxis
        Me.coldAnnotaion.XRange = NationalInstruments.UI.Range.All
        Me.coldAnnotaion.YAxis = Me.historyYAxis
        Me.coldAnnotaion.YRange = New NationalInstruments.UI.Range(Double.NegativeInfinity, 75)
        '
        'lowerLimitCursor
        '
        Me.lowerLimitCursor.Color = System.Drawing.Color.Aqua
        Me.lowerLimitCursor.Plot = Me.historyPlot
        Me.lowerLimitCursor.PointSize = New System.Drawing.Size(0, 0)
        Me.lowerLimitCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating
        Me.lowerLimitCursor.VerticalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None
        Me.lowerLimitCursor.YPosition = 75
        '
        'historyPlot
        '
        Me.historyPlot.LineColor = System.Drawing.Color.White
        Me.historyPlot.LineWidth = 2.0!
        Me.historyPlot.ToolTipsEnabled = True
        Me.historyPlot.XAxis = Me.historyXAxis
        Me.historyPlot.YAxis = Me.historyYAxis
        '
        'upperLimitCursor
        '
        Me.upperLimitCursor.Color = System.Drawing.Color.Red
        Me.upperLimitCursor.Plot = Me.historyPlot
        Me.upperLimitCursor.PointSize = New System.Drawing.Size(0, 0)
        Me.upperLimitCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating
        Me.upperLimitCursor.VerticalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None
        Me.upperLimitCursor.YPosition = 85
        '
        'viewMenu
        '
        Me.viewMenu.Index = 1
        Me.viewMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.toolBarMenu, Me.statusBarMenu})
        Me.viewMenu.Text = "View"
        '
        'toolBarMenu
        '
        Me.toolBarMenu.Checked = True
        Me.toolBarMenu.Index = 0
        Me.toolBarMenu.Text = "ToolBar"
        '
        'statusBarMenu
        '
        Me.statusBarMenu.Checked = True
        Me.statusBarMenu.Index = 1
        Me.statusBarMenu.Text = "Status Bar"
        '
        'helpMenu
        '
        Me.helpMenu.Index = 2
        Me.helpMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.systemDemoMenu})
        Me.helpMenu.Text = "Help"
        '
        'splitter1
        '
        Me.mainSplitter.Location = New System.Drawing.Point(264, 28)
        Me.mainSplitter.Name = "splitter1"
        Me.mainSplitter.Size = New System.Drawing.Size(3, 599)
        Me.mainSplitter.TabIndex = 8
        Me.mainSplitter.TabStop = False
        '
        'toolBarImages
        '
        Me.toolBarImages.ImageStream = CType(resources.GetObject("toolBarImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.toolBarImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'analyzeToolBar
        '
        Me.analyzeToolBar.ImageIndex = 1
        Me.analyzeToolBar.Pushed = True
        Me.analyzeToolBar.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'acquireToolBar
        '
        Me.acquireToolBar.ImageIndex = 0
        Me.acquireToolBar.Pushed = True
        Me.acquireToolBar.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'leftPanel
        '
        Me.leftPanel.AutoScroll = True
        Me.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.leftPanel.Controls.Add(Me.temperatureGroupBox)
        Me.leftPanel.Controls.Add(Me.histogramSettingsGroupBox)
        Me.leftPanel.Controls.Add(Me.offAcquireLabel)
        Me.leftPanel.Controls.Add(Me.offAnalyzeLabel)
        Me.leftPanel.Controls.Add(Me.onAcquireLabel)
        Me.leftPanel.Controls.Add(Me.onAnalyzeLabel)
        Me.leftPanel.Controls.Add(Me.updateRateSlide)
        Me.leftPanel.Controls.Add(Me.analyzeSwitch)
        Me.leftPanel.Controls.Add(Me.acquireSwitch)
        Me.leftPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.leftPanel.Location = New System.Drawing.Point(0, 28)
        Me.leftPanel.Name = "leftPanel"
        Me.leftPanel.Size = New System.Drawing.Size(264, 599)
        Me.leftPanel.TabIndex = 7
        '
        'temperatureGroupBox
        '
        Me.temperatureGroupBox.Controls.Add(Me.upperLimitKnob)
        Me.temperatureGroupBox.Controls.Add(Me.lowLimitKnob)
        Me.temperatureGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.temperatureGroupBox.Location = New System.Drawing.Point(16, 272)
        Me.temperatureGroupBox.Name = "temperatureGroupBox"
        Me.temperatureGroupBox.Size = New System.Drawing.Size(232, 176)
        Me.temperatureGroupBox.TabIndex = 12
        Me.temperatureGroupBox.TabStop = False
        Me.temperatureGroupBox.Text = "Temperature Range"
        '
        'upperLimitKnob
        '
        Me.upperLimitKnob.AutoDivisionSpacing = False
        Me.upperLimitKnob.Caption = "Upper Limit"
        Me.upperLimitKnob.DialColor = System.Drawing.Color.Red
        Me.upperLimitKnob.Location = New System.Drawing.Point(112, 24)
        Me.upperLimitKnob.Name = "upperLimitKnob"
        Me.upperLimitKnob.Range = New NationalInstruments.UI.Range(70, 90)
        Me.upperLimitKnob.Size = New System.Drawing.Size(112, 144)
        Me.upperLimitKnob.TabIndex = 4
        Me.upperLimitKnob.Value = 85
        '
        'lowLimitknob
        '
        Me.lowLimitKnob.AutoDivisionSpacing = False
        Me.lowLimitKnob.Caption = "Low Limit"
        Me.lowLimitKnob.DialColor = System.Drawing.Color.Aqua
        Me.lowLimitKnob.Location = New System.Drawing.Point(8, 24)
        Me.lowLimitKnob.Name = "lowLimitknob"
        Me.lowLimitKnob.Range = New NationalInstruments.UI.Range(70, 90)
        Me.lowLimitKnob.Size = New System.Drawing.Size(112, 144)
        Me.lowLimitKnob.TabIndex = 3
        Me.lowLimitKnob.Value = 75
        '
        'histogramSettingsGroupbox
        '
        Me.histogramSettingsGroupBox.Controls.Add(Me.minimumBinNumericEdit)
        Me.histogramSettingsGroupBox.Controls.Add(Me.minimumBinLabel)
        Me.histogramSettingsGroupBox.Controls.Add(Me.maximumBinNumericEdit)
        Me.histogramSettingsGroupBox.Controls.Add(Me.maximumBinLabel)
        Me.histogramSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.histogramSettingsGroupBox.Location = New System.Drawing.Point(16, 464)
        Me.histogramSettingsGroupBox.Name = "histogramSettingsGroupbox"
        Me.histogramSettingsGroupBox.Size = New System.Drawing.Size(232, 100)
        Me.histogramSettingsGroupBox.TabIndex = 11
        Me.histogramSettingsGroupBox.TabStop = False
        Me.histogramSettingsGroupBox.Text = "Histogram Settings"
        '
        'minimumBin
        '
        Me.minimumBinNumericEdit.Enabled = False
        Me.minimumBinNumericEdit.Location = New System.Drawing.Point(96, 24)
        Me.minimumBinNumericEdit.Name = "minimumBin"
        Me.minimumBinNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.minimumBinNumericEdit.Range = New NationalInstruments.UI.Range(70, Double.PositiveInfinity)
        Me.minimumBinNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.minimumBinNumericEdit.TabIndex = 10
        Me.minimumBinNumericEdit.Value = 70
        '
        'minimumBinLabel
        '
        Me.minimumBinLabel.AutoSize = True
        Me.minimumBinLabel.Location = New System.Drawing.Point(16, 24)
        Me.minimumBinLabel.Name = "minimumBinLabel"
        Me.minimumBinLabel.Size = New System.Drawing.Size(66, 13)
        Me.minimumBinLabel.TabIndex = 12
        Me.minimumBinLabel.Text = "Minimum Bin"
        '
        'maximumBin
        '
        Me.maximumBinNumericEdit.Enabled = False
        Me.maximumBinNumericEdit.Location = New System.Drawing.Point(96, 64)
        Me.maximumBinNumericEdit.Name = "maximumBin"
        Me.maximumBinNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.maximumBinNumericEdit.Range = New NationalInstruments.UI.Range(Double.NegativeInfinity, 90)
        Me.maximumBinNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.maximumBinNumericEdit.TabIndex = 9
        Me.maximumBinNumericEdit.Value = 90
        '
        'maximumBinLabel
        '
        Me.maximumBinLabel.AutoSize = True
        Me.maximumBinLabel.Location = New System.Drawing.Point(16, 64)
        Me.maximumBinLabel.Name = "maximumBinLabel"
        Me.maximumBinLabel.Size = New System.Drawing.Size(69, 13)
        Me.maximumBinLabel.TabIndex = 11
        Me.maximumBinLabel.Text = "Maximum Bin"
        '
        'offAcquireLabel
        '
        Me.offAcquireLabel.AutoSize = True
        Me.offAcquireLabel.Location = New System.Drawing.Point(208, 104)
        Me.offAcquireLabel.Name = "offAcquireLabel"
        Me.offAcquireLabel.Size = New System.Drawing.Size(21, 13)
        Me.offAcquireLabel.TabIndex = 8
        Me.offAcquireLabel.Text = "Off"
        '
        'offAnalyzeLabel
        '
        Me.offAnalyzeLabel.AutoSize = True
        Me.offAnalyzeLabel.Location = New System.Drawing.Point(88, 104)
        Me.offAnalyzeLabel.Name = "offAnalyzeLabel"
        Me.offAnalyzeLabel.Size = New System.Drawing.Size(21, 13)
        Me.offAnalyzeLabel.TabIndex = 7
        Me.offAnalyzeLabel.Text = "Off"
        '
        'onAcquireLabel
        '
        Me.onAcquireLabel.AutoSize = True
        Me.onAcquireLabel.Location = New System.Drawing.Point(208, 48)
        Me.onAcquireLabel.Name = "onAcquireLabel"
        Me.onAcquireLabel.Size = New System.Drawing.Size(21, 13)
        Me.onAcquireLabel.TabIndex = 6
        Me.onAcquireLabel.Text = "On"
        '
        'onAnalyzeLabel
        '
        Me.onAnalyzeLabel.AutoSize = True
        Me.onAnalyzeLabel.Location = New System.Drawing.Point(88, 48)
        Me.onAnalyzeLabel.Name = "onAnalyzeLabel"
        Me.onAnalyzeLabel.Size = New System.Drawing.Size(21, 13)
        Me.onAnalyzeLabel.TabIndex = 5
        Me.onAnalyzeLabel.Text = "On"
        '
        'updateRateSlide
        '
        Me.updateRateSlide.AutoDivisionSpacing = False
        Me.updateRateSlide.Caption = "Update Rate (s)"
        Me.updateRateSlide.FillMode = NationalInstruments.UI.NumericFillMode.None
        Me.updateRateSlide.Location = New System.Drawing.Point(8, 152)
        Me.updateRateSlide.MajorDivisions.Base = 0.05
        Me.updateRateSlide.MajorDivisions.Interval = 0.19
        Me.updateRateSlide.MinorDivisions.Base = 0.05
        Me.updateRateSlide.MinorDivisions.Interval = 0.095
        Me.updateRateSlide.Name = "updateRateSlide"
        Me.updateRateSlide.Range = New NationalInstruments.UI.Range(0.05, 1)
        Me.updateRateSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.updateRateSlide.Size = New System.Drawing.Size(240, 96)
        Me.updateRateSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip
        Me.updateRateSlide.TabIndex = 2
        Me.updateRateSlide.Value = 0.07
        '
        'analyzeSwitch
        '
        Me.analyzeSwitch.Caption = "Analyze"
        Me.analyzeSwitch.Location = New System.Drawing.Point(16, 16)
        Me.analyzeSwitch.Name = "analyzeSwitch"
        Me.analyzeSwitch.Size = New System.Drawing.Size(64, 120)
        Me.analyzeSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide3D
        Me.analyzeSwitch.TabIndex = 1
        Me.analyzeSwitch.Value = True
        '
        'acquireSwitch
        '
        Me.acquireSwitch.Caption = "Acquire"
        Me.acquireSwitch.Location = New System.Drawing.Point(136, 16)
        Me.acquireSwitch.Name = "acquireSwitch"
        Me.acquireSwitch.Size = New System.Drawing.Size(64, 120)
        Me.acquireSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide3D
        Me.acquireSwitch.TabIndex = 0
        Me.acquireSwitch.Value = True
        '
        'mainMenu
        '
        Me.mainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.fileMenu, Me.viewMenu, Me.helpMenu})
        '
        'mainStatusPanel
        '
        Me.mainStatusBar.Location = New System.Drawing.Point(0, 627)
        Me.mainStatusBar.Name = "mainStatusPanel"
        Me.mainStatusBar.Size = New System.Drawing.Size(944, 22)
        Me.mainStatusBar.TabIndex = 6
        Me.mainStatusBar.Text = "Acquiring..."
        '
        'mainTimer
        '
        Me.mainTimer.Enabled = True
        Me.mainTimer.Interval = 70
        '
        'mainToolBar
        '
        Me.mainToolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.mainToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.acquireToolBar, Me.analyzeToolBar})
        Me.mainToolBar.DropDownArrows = True
        Me.mainToolBar.ImageList = Me.toolBarImages
        Me.mainToolBar.Location = New System.Drawing.Point(0, 0)
        Me.mainToolBar.Name = "mainToolBar"
        Me.mainToolBar.ShowToolTips = True
        Me.mainToolBar.Size = New System.Drawing.Size(944, 28)
        Me.mainToolBar.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(944, 649)
        Me.Controls.Add(Me.rightPanel)
        Me.Controls.Add(Me.mainSplitter)
        Me.Controls.Add(Me.leftPanel)
        Me.Controls.Add(Me.mainStatusBar)
        Me.Controls.Add(Me.mainToolBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu
        Me.Name = "MainForm"
        Me.Text = "Temperature System Demo"
        Me.rightPanel.ResumeLayout(False)
        CType(Me.stdTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.meanTempTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.currentTemperatureThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.temperatureHistogramScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.temperatureHistoryWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lowerLimitCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upperLimitCursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.leftPanel.ResumeLayout(False)
        Me.leftPanel.PerformLayout()
        Me.temperatureGroupBox.ResumeLayout(False)
        CType(Me.upperLimitKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lowLimitKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.histogramSettingsGroupBox.ResumeLayout(False)
        Me.histogramSettingsGroupBox.PerformLayout()
        CType(Me.minimumBinNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maximumBinNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updateRateSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.analyzeSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.acquireSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub InitializeMenuHelperStrings(ByVal menuItems As Menu.MenuItemCollection)
        For Each item As MenuItem In menuItems
            If Not item.Text = "-" Then
                utilityHelper.AddMenuString(item)
                AddHandler item.Select, AddressOf OnMenuSelect
            End If
            InitializeMenuHelperStrings(item.MenuItems)
        Next
    End Sub

    Private Sub InitializeToolTips(ByVal buttons As ToolBar.ToolBarButtonCollection)
        Dim helpIndex As Integer = 0
        For Each button As ToolBarButton In buttons
            If Not button.Style = ToolBarButtonStyle.Separator Then
                button.ToolTipText = utilityHelper.GetToolTip(helpIndex)
                helpIndex += 1
            End If
        Next

    End Sub

    Private Sub MapToolBarAndMenuItems()
        utilityHelper.MapMenuAndToolBar(acquireToolBar, acquireMenu)
        utilityHelper.MapMenuAndToolBar(analyzeToolBar, analyzeMenu)
    End Sub

    Protected Overrides Sub OnMenuStart(ByVal e As EventArgs)
        MyBase.OnMenuStart(e)
        lastStatus = mainStatusBar.Text
    End Sub

    Protected Overrides Sub OnMenuComplete(ByVal e As EventArgs)
        MyBase.OnMenuComplete(e)
        mainStatusBar.Text = lastStatus
    End Sub

    Private Sub OnMenuSelect(ByVal sender As Object, ByVal e As EventArgs)
        mainStatusBar.Text = utilityHelper.GetMenuString(sender)
    End Sub

    Private Sub mainToolBar_ButtonClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles mainToolBar.ButtonClick
        Dim item As MenuItem = utilityHelper.FromToolBarButton(e.Button)
        item.PerformClick()
    End Sub

    Private Sub mainTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainTimer.Tick
        'Get random new temperature between 70 and 90
        Dim currentTemp As Double = (random.NextDouble() * 20) + 70
        currentTemperatureThermometer.Value = currentTemp

        'update TemperatureGraph
        temperatureHistoryWaveformGraph.PlotYAppend(currentTemp)

        UpdateAnalysis(currentTemp)

    End Sub


    Private Sub UpdateAnalysis(ByVal currentTemp As Double)
        If analyzeSwitch.Value Then
            analysisPlot.PlotYAppend(currentTemp)
            Dim analysisPoints As Double() = analysisPlot.GetYData

            Dim centerValues As Double() = Nothing

            Dim histogram As Int32() = Statistics.Histogram(analysisPoints, minimumBinNumericEdit.Value, maximumBinNumericEdit.Value, 25, centerValues)
            Dim histogramData As Double() = CType(DataConverter.Convert(histogram, GetType(Double())), Double())

            temperatureHistogramScatterGraph.PlotXY(centerValues, histogramData)
            Dim maxValue As Double = ArrayOperation.GetMax(histogramData)
            If maxValue > 0 Then
                histogramYAxis.Range = New Range(0, maxValue)
            End If

            stdTank.Value = Statistics.StandardDeviation(analysisPoints)
            meanTemptank.Value = Statistics.Mean(analysisPoints)

        End If

    End Sub

    Private Sub updateRateSlide_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles updateRateSlide.AfterChangeValue
        mainTimer.Interval = CType(e.NewValue * 1000, Integer)
    End Sub


    Private Sub acquireSwitch_StateChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.ActionEventArgs) Handles acquireSwitch.StateChanged
        mainTimer.Enabled = acquireSwitch.Value

        If acquireSwitch.Value Then
            mainStatusBar.Text = "Acquiring..."
            ClearHistogramData()
        Else
            mainStatusBar.Text = "Ready."
        End If

        If Not e.Action = NationalInstruments.UI.Action.Programmatic Then
            acquireMenu.PerformClick()
        End If


    End Sub

    Private Sub analyzeSwitch_StateChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.ActionEventArgs) Handles analyzeSwitch.StateChanged

        ClearHistogramData()
        If Not e.Action = NationalInstruments.UI.Action.Programmatic Then
            analyzeMenu.PerformClick()
        End If

    End Sub

    Private Sub ClearHistogramData()
        If analyzeSwitch.Value Then
            minimumBinNumericEdit.Enabled = False
            maximumBinNumericEdit.Enabled = False

            temperatureHistogramScatterGraph.ClearData()
            analysisPlot.ClearData()
            stdTank.Value = stdTank.Range.Minimum
            meanTemptank.Value = meanTemptank.Range.Minimum
        Else
            minimumBinNumericEdit.Enabled = True
            maximumBinNumericEdit.Enabled = True
        End If
    End Sub

    Private Sub LowerCursorBeforeMoved(ByVal sender As System.Object, ByVal e As BeforeMoveXYCursorEventArgs) Handles lowerLimitCursor.BeforeMove
        If (e.YPosition > upperLimitCursor.YPosition) Then
            e.Cancel = True
        Else
            coldAnnotaion.YRange = New Range(coldAnnotaion.YRange.Minimum, e.YPosition)
            lowLimitKnob.Value = e.YPosition
        End If
    End Sub

    Private Sub UpperCursorBeforeMoved(ByVal sender As Object, ByVal e As BeforeMoveXYCursorEventArgs) Handles upperLimitCursor.BeforeMove
        If (e.YPosition < lowerLimitCursor.YPosition) Then
            e.Cancel = True
        Else
            hotAnnotaion.YRange = New Range(e.YPosition, hotAnnotaion.YRange.Maximum)
            upperLimitKnob.Value = e.YPosition
        End If
    End Sub

    Private Sub lowLimitknob_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles lowLimitKnob.AfterChangeValue
        lowerLimitCursor.YPosition = lowLimitKnob.Value
    End Sub

    Private Sub upperLimitKnob_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles upperLimitKnob.AfterChangeValue
        upperLimitCursor.YPosition = upperLimitKnob.Value
    End Sub

    Private Sub AnalyzeMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles analyzeMenu.Click
        analyzeMenu.Checked = Not analyzeMenu.Checked
        analyzeSwitch.Value = analyzeMenu.Checked
        Dim button As ToolBarButton = utilityHelper.FromMenuItem(analyzeMenu)
        button.Pushed = analyzeMenu.Checked
    End Sub

    Private Sub AcquireMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles acquireMenu.Click
        acquireMenu.Checked = Not acquireMenu.Checked
        acquireSwitch.Value = acquireMenu.Checked
        Dim button As ToolBarButton = utilityHelper.FromMenuItem(acquireMenu)
        button.Pushed = acquireMenu.Checked
    End Sub

    Private Sub ToolBarMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles toolBarMenu.Click
        toolBarMenu.Checked = Not toolBarMenu.Checked
        mainToolBar.Visible = toolBarMenu.Checked
    End Sub

    Private Sub StatusBarMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles statusBarMenu.Click
        statusBarMenu.Checked = Not statusBarMenu.Checked
        mainStatusBar.Visible = statusBarMenu.Checked
    End Sub

    Private Sub ExitMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitMenu.Click
        Close()
    End Sub

    Private Sub SystemDemoMenuClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles systemDemoMenu.Click
        Dim dlg As AboutDlg = New AboutDlg
        dlg.ShowDialog()
    End Sub


    Private Sub minimumBin_BeforeChangeValue(ByVal sender As Object, ByVal e As UI.BeforeChangeNumericValueEventArgs) Handles minimumBinNumericEdit.BeforeChangeValue
        If e.NewValue >= maximumBinNumericEdit.Value Then
            e.Cancel = True
        End If
    End Sub


    Private Sub maximumBin_BeforeChangeValue(ByVal sender As Object, ByVal e As UI.BeforeChangeNumericValueEventArgs) Handles maximumBinNumericEdit.BeforeChangeValue
        If e.NewValue <= minimumBinNumericEdit.Value Then
            e.Cancel = True
        End If
    End Sub


End Class
