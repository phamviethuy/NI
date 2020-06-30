
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms


Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private WithEvents plotContextMenu As System.Windows.Forms.ContextMenu

    Private WithEvents mainMenu As System.Windows.Forms.MainMenu

    Private WithEvents selectPolesMenu As System.Windows.Forms.MenuItem

    Private WithEvents zerosPlot As NationalInstruments.UI.ComplexPlot

    Private WithEvents selectZerosMenu As System.Windows.Forms.MenuItem

    Private WithEvents selectionMenu As System.Windows.Forms.ContextMenu

    Private WithEvents selectOutsideMenu As System.Windows.Forms.MenuItem

    Private WithEvents selectRightMenu As System.Windows.Forms.MenuItem

    Private WithEvents polesPlot As NationalInstruments.UI.ComplexPlot

    Private WithEvents addPoleButton As System.Windows.Forms.Button

    Private WithEvents poleDataGrid As System.Windows.Forms.DataGrid

    Private WithEvents zeroDataGrid As System.Windows.Forms.DataGrid

    Private WithEvents addZeroButton As System.Windows.Forms.Button

    Private WithEvents poleZeroComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph

    Private samplingFrequencyLabel As System.Windows.Forms.Label

    Private numberOfPointsLabel As System.Windows.Forms.Label

    Private gainLabel As System.Windows.Forms.Label

    Private poleZeroEditorGroupBox As System.Windows.Forms.GroupBox


    Private complexXAxis As NationalInstruments.UI.ComplexXAxis

    Private complexYAxis As NationalInstruments.UI.ComplexYAxis



    Private WithEvents numberOfPointsNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit

    Private WithEvents magnitudeSpectrumScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph

    Private WithEvents magnitudePlot As NationalInstruments.UI.ScatterPlot

    Private filterGroupBox As System.Windows.Forms.GroupBox

    Private unitCircleLegendItem As NationalInstruments.UI.LegendItem

    Private poleslegendItem As NationalInstruments.UI.LegendItem

    Private zerosLegendItem As NationalInstruments.UI.LegendItem

    Private poleZeroEditorLegend As NationalInstruments.UI.WindowsForms.Legend

    Private components As System.ComponentModel.IContainer

    Private WithEvents exitMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectPolesMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectZerosMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectInsideUnitCircleMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectOutsideUnitCircleMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectAboveRealAxisMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectBelowRealAxisMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectLeftHalfMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectRightHalfMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents actionMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents helpMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents editorHelpMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectInsideMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectAboveMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectBelowMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectLeftHalfMenu As System.Windows.Forms.MenuItem

    Private WithEvents invertRealContextMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents invertImaginaryContextMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents mirrorImaginaryContextMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents mirrorRealContextMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents removeContextMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents mirrorRealMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents mirrorImaginaryMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents invertRealMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents invertImaginaryMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents removePoleZeroMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents selectMenuItem As System.Windows.Forms.MenuItem

    Private WithEvents hideShowButton As System.Windows.Forms.Button

    Private isMoving As Boolean

    Private multipleSelectPressed As Boolean

    Private selectedPoles As ArrayList

    Private selectedZeros As ArrayList

    Private polesData As ArrayList

    Private zerosData As ArrayList

    Private selectedPlot As ComplexPlot

    Private LargeFormSize As Size

    Private SmallFormSize As Size

    Private frequencyXAxis As NationalInstruments.UI.XAxis

    Private magnitudeYAxis As NationalInstruments.UI.YAxis

    Private showFilterCharacterictics As Boolean

    Private Shared DefaultPole As ComplexDouble = ComplexDouble.Zero

    Private Shared DefaultZero As ComplexDouble = ComplexDouble.Zero

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        magnitudeYAxis.Range = New Range(0, 10)
        polesData = New ArrayList
        zerosData = New ArrayList
        selectedPoles = New ArrayList
        selectedZeros = New ArrayList
        poleDataGrid.Enabled = False
        zeroDataGrid.Enabled = False
        SetupDataGrid(poleDataGrid)
        SetupDataGrid(zeroDataGrid)
        LargeFormSize = Me.ClientSize
        SmallFormSize = New Size(Me.ClientSize.Width, (Me.ClientSize.Height _
                        - filterGroupBox.Height))
        showFilterCharacterictics = True
    End Sub

    ' <summary>
    ' Required method for Designer support - do not modify
    ' the contents of this method with the code editor.
    ' </summary>
    Private WithEvents menuItemEditor As System.Windows.Forms.MenuItem
    Private WithEvents dataGridPanel As System.Windows.Forms.Panel
    Private WithEvents parametersPanel As System.Windows.Forms.Panel
    Private WithEvents samplingFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents gainNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents unitMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.menuItemEditor = New System.Windows.Forms.MenuItem
        Me.exitMenuItem = New System.Windows.Forms.MenuItem
        Me.magnitudePlot = New NationalInstruments.UI.ScatterPlot
        Me.frequencyXAxis = New NationalInstruments.UI.XAxis
        Me.magnitudeYAxis = New NationalInstruments.UI.YAxis
        Me.invertRealContextMenuItem = New System.Windows.Forms.MenuItem
        Me.invertImaginaryContextMenuItem = New System.Windows.Forms.MenuItem
        Me.mirrorImaginaryContextMenuItem = New System.Windows.Forms.MenuItem
        Me.plotContextMenu = New System.Windows.Forms.ContextMenu
        Me.mirrorRealContextMenuItem = New System.Windows.Forms.MenuItem
        Me.removeContextMenuItem = New System.Windows.Forms.MenuItem
        Me.filterGroupBox = New System.Windows.Forms.GroupBox
        Me.magnitudeSpectrumScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.dataGridPanel = New System.Windows.Forms.Panel
        Me.samplingFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.samplingFrequencyLabel = New System.Windows.Forms.Label
        Me.numberOfPointsNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfPointsLabel = New System.Windows.Forms.Label
        Me.gainNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.gainLabel = New System.Windows.Forms.Label
        Me.mainMenu = New System.Windows.Forms.MainMenu
        Me.selectMenuItem = New System.Windows.Forms.MenuItem
        Me.selectPolesMenuItem = New System.Windows.Forms.MenuItem
        Me.selectZerosMenuItem = New System.Windows.Forms.MenuItem
        Me.selectInsideUnitCircleMenuItem = New System.Windows.Forms.MenuItem
        Me.selectOutsideUnitCircleMenuItem = New System.Windows.Forms.MenuItem
        Me.selectAboveRealAxisMenuItem = New System.Windows.Forms.MenuItem
        Me.selectBelowRealAxisMenuItem = New System.Windows.Forms.MenuItem
        Me.selectLeftHalfMenuItem = New System.Windows.Forms.MenuItem
        Me.selectRightHalfMenuItem = New System.Windows.Forms.MenuItem
        Me.actionMenuItem = New System.Windows.Forms.MenuItem
        Me.mirrorRealMenuItem = New System.Windows.Forms.MenuItem
        Me.mirrorImaginaryMenuItem = New System.Windows.Forms.MenuItem
        Me.invertRealMenuItem = New System.Windows.Forms.MenuItem
        Me.invertImaginaryMenuItem = New System.Windows.Forms.MenuItem
        Me.removePoleZeroMenuItem = New System.Windows.Forms.MenuItem
        Me.helpMenuItem = New System.Windows.Forms.MenuItem
        Me.editorHelpMenuItem = New System.Windows.Forms.MenuItem
        Me.selectPolesMenu = New System.Windows.Forms.MenuItem
        Me.zerosPlot = New NationalInstruments.UI.ComplexPlot
        Me.complexXAxis = New NationalInstruments.UI.ComplexXAxis
        Me.complexYAxis = New NationalInstruments.UI.ComplexYAxis
        Me.selectInsideMenuItem = New System.Windows.Forms.MenuItem
        Me.selectZerosMenu = New System.Windows.Forms.MenuItem
        Me.selectionMenu = New System.Windows.Forms.ContextMenu
        Me.selectOutsideMenu = New System.Windows.Forms.MenuItem
        Me.selectAboveMenuItem = New System.Windows.Forms.MenuItem
        Me.selectBelowMenuItem = New System.Windows.Forms.MenuItem
        Me.selectLeftHalfMenu = New System.Windows.Forms.MenuItem
        Me.selectRightMenu = New System.Windows.Forms.MenuItem
        Me.polesPlot = New NationalInstruments.UI.ComplexPlot
        Me.poleZeroEditorGroupBox = New System.Windows.Forms.GroupBox
        Me.parametersPanel = New System.Windows.Forms.Panel
        Me.addPoleButton = New System.Windows.Forms.Button
        Me.addZeroButton = New System.Windows.Forms.Button
        Me.poleDataGrid = New System.Windows.Forms.DataGrid
        Me.zeroDataGrid = New System.Windows.Forms.DataGrid
        Me.poleZeroEditorLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.unitCircleLegendItem = New NationalInstruments.UI.LegendItem
        Me.poleslegendItem = New NationalInstruments.UI.LegendItem
        Me.zerosLegendItem = New NationalInstruments.UI.LegendItem
        Me.poleZeroComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.unitMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.hideShowButton = New System.Windows.Forms.Button
        Me.filterGroupBox.SuspendLayout()
        CType(Me.magnitudeSpectrumScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dataGridPanel.SuspendLayout()
        CType(Me.samplingFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfPointsNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gainNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.poleZeroEditorGroupBox.SuspendLayout()
        Me.parametersPanel.SuspendLayout()
        CType(Me.poleDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.zeroDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.poleZeroEditorLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.poleZeroComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuItemEditor
        '
        Me.menuItemEditor.Index = 0
        Me.menuItemEditor.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.exitMenuItem})
        Me.menuItemEditor.Text = "&Editor"
        '
        'exitMenuItem
        '
        Me.exitMenuItem.Index = 0
        Me.exitMenuItem.Text = "E&xit"
        '
        'magnitudePlot
        '
        Me.magnitudePlot.ProcessSpecialValues = True
        Me.magnitudePlot.XAxis = Me.frequencyXAxis
        Me.magnitudePlot.YAxis = Me.magnitudeYAxis
        '
        'frequencyXAxis
        '
        Me.frequencyXAxis.Caption = "Frequency (Hz)"
        Me.frequencyXAxis.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S'Hz'")
        '
        'magnitudeYAxis
        '
        Me.magnitudeYAxis.Caption = "Magnitude (db)"
        Me.magnitudeYAxis.MajorDivisions.GridVisible = True
        '
        'invertRealContextMenuItem
        '
        Me.invertRealContextMenuItem.Index = 2
        Me.invertRealContextMenuItem.Text = "Invert about Real Axis"
        '
        'invertImaginaryContextMenuItem
        '
        Me.invertImaginaryContextMenuItem.Index = 3
        Me.invertImaginaryContextMenuItem.Text = "Invert about Imaginary Axis"
        '
        'mirrorImaginaryContextMenuItem
        '
        Me.mirrorImaginaryContextMenuItem.Index = 1
        Me.mirrorImaginaryContextMenuItem.Text = "Mirror about Imaginary Axis"
        '
        'plotContextMenu
        '
        Me.plotContextMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mirrorRealContextMenuItem, Me.mirrorImaginaryContextMenuItem, Me.invertRealContextMenuItem, Me.invertImaginaryContextMenuItem, Me.removeContextMenuItem})
        '
        'mirrorRealContextMenuItem
        '
        Me.mirrorRealContextMenuItem.Index = 0
        Me.mirrorRealContextMenuItem.Text = "Mirror about Real Axis"
        '
        'removeContextMenuItem
        '
        Me.removeContextMenuItem.Index = 4
        Me.removeContextMenuItem.Text = "Remove"
        '
        'filterGroupBox
        '
		Me.filterGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.filterGroupBox.Controls.Add(Me.magnitudeSpectrumScatterGraph)
        Me.filterGroupBox.Controls.Add(Me.dataGridPanel)
        Me.filterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterGroupBox.Location = New System.Drawing.Point(5, 370)
        Me.filterGroupBox.Name = "filterGroupBox"
        Me.filterGroupBox.Size = New System.Drawing.Size(690, 302)
        Me.filterGroupBox.TabIndex = 2
        Me.filterGroupBox.TabStop = False
        Me.filterGroupBox.Text = "Filter Characteristics"
        '
        'magnitudeSpectrumScatterGraph
        '
        Me.magnitudeSpectrumScatterGraph.Border = NationalInstruments.UI.Border.SolidBlack
        Me.magnitudeSpectrumScatterGraph.Caption = "Magnitude Spectrum"
        Me.magnitudeSpectrumScatterGraph.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.magnitudeSpectrumScatterGraph.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.magnitudeSpectrumScatterGraph.InteractionMode = CType(((((NationalInstruments.UI.GraphInteractionModes.ZoomX Or NationalInstruments.UI.GraphInteractionModes.ZoomY) _
                    Or NationalInstruments.UI.GraphInteractionModes.ZoomAroundPoint) _
                    Or NationalInstruments.UI.GraphInteractionModes.DragCursor) _
                    Or NationalInstruments.UI.GraphInteractionModes.DragAnnotationCaption), NationalInstruments.UI.GraphInteractionModes)
        Me.magnitudeSpectrumScatterGraph.Location = New System.Drawing.Point(3, 56)
        Me.magnitudeSpectrumScatterGraph.Name = "magnitudeSpectrumScatterGraph"
        Me.magnitudeSpectrumScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.magnitudePlot})
        Me.magnitudeSpectrumScatterGraph.Size = New System.Drawing.Size(684, 243)
        Me.magnitudeSpectrumScatterGraph.TabIndex = 1
        Me.magnitudeSpectrumScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.frequencyXAxis})
        Me.magnitudeSpectrumScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.magnitudeYAxis})
        '
        'dataGridPanel
        '
        Me.dataGridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dataGridPanel.Controls.Add(Me.samplingFrequencyNumericEdit)
        Me.dataGridPanel.Controls.Add(Me.samplingFrequencyLabel)
        Me.dataGridPanel.Controls.Add(Me.numberOfPointsNumericEdit)
        Me.dataGridPanel.Controls.Add(Me.numberOfPointsLabel)
        Me.dataGridPanel.Controls.Add(Me.gainNumericEdit)
        Me.dataGridPanel.Controls.Add(Me.gainLabel)
        Me.dataGridPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.dataGridPanel.Location = New System.Drawing.Point(3, 16)
        Me.dataGridPanel.Name = "dataGridPanel"
        Me.dataGridPanel.Size = New System.Drawing.Size(684, 40)
        Me.dataGridPanel.TabIndex = 0
        '
        'samplingFrequencyNumericEdit
        '
        Me.samplingFrequencyNumericEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.samplingFrequencyNumericEdit.Location = New System.Drawing.Point(136, 8)
        Me.samplingFrequencyNumericEdit.Name = "samplingFrequencyNumericEdit"
        Me.samplingFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplingFrequencyNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.samplingFrequencyNumericEdit.Size = New System.Drawing.Size(80, 22)
        Me.samplingFrequencyNumericEdit.TabIndex = 1
        Me.samplingFrequencyNumericEdit.Value = 4800
        '
        'samplingFrequencyLabel
        '
        Me.samplingFrequencyLabel.AutoSize = True
        Me.samplingFrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplingFrequencyLabel.Location = New System.Drawing.Point(8, 11)
        Me.samplingFrequencyLabel.Name = "samplingFrequencyLabel"
        Me.samplingFrequencyLabel.Size = New System.Drawing.Size(136, 16)
        Me.samplingFrequencyLabel.TabIndex = 0
        Me.samplingFrequencyLabel.Text = "Sampling Frequency (Hz):"
        '
        'numberOfPointsNumericEdit
        '
        Me.numberOfPointsNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval
        Me.numberOfPointsNumericEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numberOfPointsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfPointsNumericEdit.Location = New System.Drawing.Point(360, 8)
        Me.numberOfPointsNumericEdit.Name = "numberOfPointsNumericEdit"
        Me.numberOfPointsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfPointsNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.numberOfPointsNumericEdit.Size = New System.Drawing.Size(80, 22)
        Me.numberOfPointsNumericEdit.TabIndex = 3
        Me.numberOfPointsNumericEdit.Value = 256
        '
        'numberOfPointsLabel
        '
        Me.numberOfPointsLabel.AutoSize = True
        Me.numberOfPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numberOfPointsLabel.Location = New System.Drawing.Point(264, 11)
        Me.numberOfPointsLabel.Name = "numberOfPointsLabel"
        Me.numberOfPointsLabel.Size = New System.Drawing.Size(95, 16)
        Me.numberOfPointsLabel.TabIndex = 2
        Me.numberOfPointsLabel.Text = "Number of Points:"
        '
        'gainNumericEdit
        '
        Me.gainNumericEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gainNumericEdit.Location = New System.Drawing.Point(592, 8)
        Me.gainNumericEdit.Name = "gainNumericEdit"
        Me.gainNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.gainNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.gainNumericEdit.Size = New System.Drawing.Size(80, 22)
        Me.gainNumericEdit.TabIndex = 5
        Me.gainNumericEdit.Value = 1
        '
        'gainLabel
        '
        Me.gainLabel.AutoSize = True
        Me.gainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gainLabel.Location = New System.Drawing.Point(552, 9)
        Me.gainLabel.Name = "gainLabel"
        Me.gainLabel.Size = New System.Drawing.Size(31, 16)
        Me.gainLabel.TabIndex = 4
        Me.gainLabel.Text = "Gain:"
        '
        'mainMenu
        '
        Me.mainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItemEditor, Me.selectMenuItem, Me.actionMenuItem, Me.helpMenuItem})
        '
        'selectMenuItem
        '
        Me.selectMenuItem.Index = 1
        Me.selectMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.selectPolesMenuItem, Me.selectZerosMenuItem, Me.selectInsideUnitCircleMenuItem, Me.selectOutsideUnitCircleMenuItem, Me.selectAboveRealAxisMenuItem, Me.selectBelowRealAxisMenuItem, Me.selectLeftHalfMenuItem, Me.selectRightHalfMenuItem})
        Me.selectMenuItem.Text = "&Select"
        '
        'selectPolesMenuItem
        '
        Me.selectPolesMenuItem.Index = 0
        Me.selectPolesMenuItem.Text = "Select &Poles"
        '
        'selectZerosMenuItem
        '
        Me.selectZerosMenuItem.Index = 1
        Me.selectZerosMenuItem.Text = "Select &Zeros"
        '
        'selectInsideUnitCircleMenuItem
        '
        Me.selectInsideUnitCircleMenuItem.Index = 2
        Me.selectInsideUnitCircleMenuItem.Text = "Select &Inside Unit Circle"
        '
        'selectOutsideUnitCircleMenuItem
        '
        Me.selectOutsideUnitCircleMenuItem.Index = 3
        Me.selectOutsideUnitCircleMenuItem.Text = "Select &Outside Unit Circle"
        '
        'selectAboveRealAxisMenuItem
        '
        Me.selectAboveRealAxisMenuItem.Index = 4
        Me.selectAboveRealAxisMenuItem.Text = "Select &Above Real Axis"
        '
        'selectBelowRealAxisMenuItem
        '
        Me.selectBelowRealAxisMenuItem.Index = 5
        Me.selectBelowRealAxisMenuItem.Text = "Select &Below Real Axis"
        '
        'selectLeftHalfMenuItem
        '
        Me.selectLeftHalfMenuItem.Index = 6
        Me.selectLeftHalfMenuItem.Text = "Select &Left Half"
        '
        'selectRightHalfMenuItem
        '
        Me.selectRightHalfMenuItem.Index = 7
        Me.selectRightHalfMenuItem.Text = "Select &Right Half"
        '
        'actionMenuItem
        '
        Me.actionMenuItem.Index = 2
        Me.actionMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mirrorRealMenuItem, Me.mirrorImaginaryMenuItem, Me.invertRealMenuItem, Me.invertImaginaryMenuItem, Me.removePoleZeroMenuItem})
        Me.actionMenuItem.Text = "&Action"
        '
        'mirrorRealMenuItem
        '
        Me.mirrorRealMenuItem.Index = 0
        Me.mirrorRealMenuItem.Text = "Mirror about &Real Axis"
        '
        'mirrorImaginaryMenuItem
        '
        Me.mirrorImaginaryMenuItem.Index = 1
        Me.mirrorImaginaryMenuItem.Text = "Mirror about &Imaginary Axis"
        '
        'invertRealMenuItem
        '
        Me.invertRealMenuItem.Index = 2
        Me.invertRealMenuItem.Text = "Invert about R&eal Axis"
        '
        'invertImaginaryMenuItem
        '
        Me.invertImaginaryMenuItem.Index = 3
        Me.invertImaginaryMenuItem.Text = "Invert about I&maginary Axis"
        '
        'removePoleZeroMenuItem
        '
        Me.removePoleZeroMenuItem.Index = 4
        Me.removePoleZeroMenuItem.Text = "Remove Pole/Zero"
        '
        'helpMenuItem
        '
        Me.helpMenuItem.Index = 3
        Me.helpMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.editorHelpMenuItem})
        Me.helpMenuItem.Text = "&Help"
        '
        'editorHelpMenuItem
        '
        Me.editorHelpMenuItem.Index = 0
        Me.editorHelpMenuItem.Text = "E&ditor Help"
        '
        'selectPolesMenu
        '
        Me.selectPolesMenu.Index = 0
        Me.selectPolesMenu.Text = "Select All Poles"
        '
        'zerosPlot
        '
        Me.zerosPlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.zerosPlot.PointSize = New System.Drawing.Size(8, 8)
        Me.zerosPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle
        Me.zerosPlot.XAxis = Me.complexXAxis
        Me.zerosPlot.YAxis = Me.complexYAxis
        '
        'complexXAxis
        '
        Me.complexXAxis.Caption = "Real Axis"
        Me.complexXAxis.MajorDivisions.GridVisible = True
        Me.complexXAxis.MinorDivisions.GridVisible = True
        Me.complexXAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.complexXAxis.OriginLineWidth = 2.0!
        Me.complexXAxis.Range = New NationalInstruments.UI.Range(-1.5, 1.5)
        '
        'complexYAxis
        '
        Me.complexYAxis.Caption = "Imaginary Axis"
        Me.complexYAxis.MajorDivisions.GridVisible = True
        Me.complexYAxis.MinorDivisions.GridVisible = True
        Me.complexYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.complexYAxis.OriginLineWidth = 2.0!
        Me.complexYAxis.Range = New NationalInstruments.UI.Range(-1.5, 1.5)
        '
        'selectInsideMenuItem
        '
        Me.selectInsideMenuItem.Index = 2
        Me.selectInsideMenuItem.Text = "Select Inside Unit Circle"
        '
        'selectZerosMenu
        '
        Me.selectZerosMenu.Index = 1
        Me.selectZerosMenu.Text = "Select All Zeros"
        '
        'selectionMenu
        '
        Me.selectionMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.selectPolesMenu, Me.selectZerosMenu, Me.selectInsideMenuItem, Me.selectOutsideMenu, Me.selectAboveMenuItem, Me.selectBelowMenuItem, Me.selectLeftHalfMenu, Me.selectRightMenu})
        '
        'selectOutsideMenu
        '
        Me.selectOutsideMenu.Index = 3
        Me.selectOutsideMenu.Text = "Select Outside Unit Circle"
        '
        'selectAboveMenuItem
        '
        Me.selectAboveMenuItem.Index = 4
        Me.selectAboveMenuItem.Text = "Select Above Real Axis"
        '
        'selectBelowMenuItem
        '
        Me.selectBelowMenuItem.Index = 5
        Me.selectBelowMenuItem.Text = "Select Below Real Axis"
        '
        'selectLeftHalfMenu
        '
        Me.selectLeftHalfMenu.Index = 6
        Me.selectLeftHalfMenu.Text = "Select Left Half"
        '
        'selectRightMenu
        '
        Me.selectRightMenu.Index = 7
        Me.selectRightMenu.Text = "Select Right Half"
        '
        'polesPlot
        '
        Me.polesPlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.polesPlot.PointColor = System.Drawing.Color.OrangeRed
        Me.polesPlot.PointSize = New System.Drawing.Size(8, 8)
        Me.polesPlot.PointStyle = NationalInstruments.UI.PointStyle.Cross
        Me.polesPlot.XAxis = Me.complexXAxis
        Me.polesPlot.YAxis = Me.complexYAxis
        '
        'poleZeroEditorGroupBox
        '
        Me.poleZeroEditorGroupBox.Controls.Add(Me.parametersPanel)
        Me.poleZeroEditorGroupBox.Controls.Add(Me.poleZeroComplexGraph)
        Me.poleZeroEditorGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.poleZeroEditorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.poleZeroEditorGroupBox.Location = New System.Drawing.Point(0, 0)
        Me.poleZeroEditorGroupBox.Name = "poleZeroEditorGroupBox"
        Me.poleZeroEditorGroupBox.Size = New System.Drawing.Size(697, 332)
        Me.poleZeroEditorGroupBox.TabIndex = 0
        Me.poleZeroEditorGroupBox.TabStop = False
        Me.poleZeroEditorGroupBox.Text = "Pole - Zero Editor"
        '
        'parametersPanel
        '
        Me.parametersPanel.Controls.Add(Me.addPoleButton)
        Me.parametersPanel.Controls.Add(Me.addZeroButton)
        Me.parametersPanel.Controls.Add(Me.poleDataGrid)
        Me.parametersPanel.Controls.Add(Me.zeroDataGrid)
        Me.parametersPanel.Controls.Add(Me.poleZeroEditorLegend)
        Me.parametersPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.parametersPanel.Location = New System.Drawing.Point(3, 16)
        Me.parametersPanel.Name = "parametersPanel"
        Me.parametersPanel.Size = New System.Drawing.Size(272, 313)
        Me.parametersPanel.TabIndex = 0
        '
        'addPoleButton
        '
        Me.addPoleButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.addPoleButton.Location = New System.Drawing.Point(8, 2)
        Me.addPoleButton.Name = "addPoleButton"
        Me.addPoleButton.Size = New System.Drawing.Size(120, 24)
        Me.addPoleButton.TabIndex = 0
        Me.addPoleButton.Text = "Add Pole"
        '
        'addZeroButton
        '
        Me.addZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.addZeroButton.Location = New System.Drawing.Point(144, 2)
        Me.addZeroButton.Name = "addZeroButton"
        Me.addZeroButton.Size = New System.Drawing.Size(120, 24)
        Me.addZeroButton.TabIndex = 1
        Me.addZeroButton.Text = "Add Zero"
        '
        'poleDataGrid
        '
        Me.poleDataGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.poleDataGrid.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.poleDataGrid.CaptionText = "Poles"
        Me.poleDataGrid.DataMember = ""
        Me.poleDataGrid.GridLineColor = System.Drawing.SystemColors.Window
        Me.poleDataGrid.HeaderBackColor = System.Drawing.SystemColors.Window
        Me.poleDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.poleDataGrid.Location = New System.Drawing.Point(8, 33)
        Me.poleDataGrid.Name = "poleDataGrid"
        Me.poleDataGrid.ParentRowsBackColor = System.Drawing.SystemColors.Highlight
        Me.poleDataGrid.ReadOnly = True
        Me.poleDataGrid.RowHeadersVisible = False
        Me.poleDataGrid.RowHeaderWidth = 0
        Me.poleDataGrid.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.poleDataGrid.SelectionForeColor = System.Drawing.SystemColors.Window
        Me.poleDataGrid.Size = New System.Drawing.Size(256, 116)
        Me.poleDataGrid.TabIndex = 2
        '
        'zeroDataGrid
        '
        Me.zeroDataGrid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.zeroDataGrid.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace
        Me.zeroDataGrid.CaptionText = "Zeros"
        Me.zeroDataGrid.DataMember = ""
        Me.zeroDataGrid.GridLineColor = System.Drawing.SystemColors.Window
        Me.zeroDataGrid.HeaderBackColor = System.Drawing.SystemColors.Window
        Me.zeroDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.zeroDataGrid.Location = New System.Drawing.Point(8, 155)
        Me.zeroDataGrid.Name = "zeroDataGrid"
        Me.zeroDataGrid.ParentRowsBackColor = System.Drawing.SystemColors.Highlight
        Me.zeroDataGrid.ReadOnly = True
        Me.zeroDataGrid.RowHeadersVisible = False
        Me.zeroDataGrid.RowHeaderWidth = 0
        Me.zeroDataGrid.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.zeroDataGrid.SelectionForeColor = System.Drawing.SystemColors.Window
        Me.zeroDataGrid.Size = New System.Drawing.Size(256, 116)
        Me.zeroDataGrid.TabIndex = 3
        '
        'poleZeroEditorLegend
        '
        Me.poleZeroEditorLegend.Border = NationalInstruments.UI.Border.Etched
        Me.poleZeroEditorLegend.Items.AddRange(New NationalInstruments.UI.LegendItem() {Me.unitCircleLegendItem, Me.poleslegendItem, Me.zerosLegendItem})
        Me.poleZeroEditorLegend.Location = New System.Drawing.Point(8, 277)
        Me.poleZeroEditorLegend.Name = "poleZeroEditorLegend"
        Me.poleZeroEditorLegend.Size = New System.Drawing.Size(256, 32)
        Me.poleZeroEditorLegend.TabIndex = 4
        Me.poleZeroEditorLegend.TabStop = False
        '
        'unitCircleLegendItem
        '
        Me.unitCircleLegendItem.Text = "Unit Circle"
        '
        'poleslegendItem
        '
        Me.poleslegendItem.Source = Me.polesPlot
        Me.poleslegendItem.Text = "Poles"
        '
        'zerosLegendItem
        '
        Me.zerosLegendItem.Source = Me.zerosPlot
        Me.zerosLegendItem.Text = "Zeros"
        '
        'poleZeroComplexGraph
        '
        Me.poleZeroComplexGraph.Annotations.AddRange(New NationalInstruments.UI.ComplexAnnotation() {Me.unitMagnitudeCircleAnnotation})
        Me.poleZeroComplexGraph.ContextMenu = Me.selectionMenu
        Me.poleZeroComplexGraph.Dock = System.Windows.Forms.DockStyle.Right
        Me.poleZeroComplexGraph.InteractionMode = CType(((NationalInstruments.UI.ComplexGraphInteractionModes.ZoomX Or NationalInstruments.UI.ComplexGraphInteractionModes.ZoomY) _
                    Or NationalInstruments.UI.ComplexGraphInteractionModes.ZoomAroundPoint), NationalInstruments.UI.ComplexGraphInteractionModes)
        Me.poleZeroComplexGraph.Location = New System.Drawing.Point(294, 16)
        Me.poleZeroComplexGraph.Name = "poleZeroComplexGraph"
        Me.poleZeroComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.polesPlot, Me.zerosPlot})
        Me.poleZeroComplexGraph.Size = New System.Drawing.Size(400, 313)
        Me.poleZeroComplexGraph.TabIndex = 1
        Me.poleZeroComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.complexXAxis})
        Me.poleZeroComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.complexYAxis})
        '
        'unitMagnitudeCircleAnnotation
        '
        Me.unitMagnitudeCircleAnnotation.ArrowHeadMagnitude = 1
        Me.unitMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitMagnitudeCircleAnnotation.Caption = "Unit Circle"
        Me.unitMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitMagnitudeCircleAnnotation.Magnitude = 1
        Me.unitMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'hideShowButton
        '
        Me.hideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hideShowButton.Location = New System.Drawing.Point(5, 340)
        Me.hideShowButton.Name = "hideShowButton"
        Me.hideShowButton.Size = New System.Drawing.Size(200, 24)
        Me.hideShowButton.TabIndex = 1
        Me.hideShowButton.Text = "<< Hide Filter Characteristics"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(697, 674)
        Me.Controls.Add(Me.hideShowButton)
        Me.Controls.Add(Me.filterGroupBox)
        Me.Controls.Add(Me.poleZeroEditorGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Menu = Me.mainMenu
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pole-Zero Editor"
        Me.filterGroupBox.ResumeLayout(False)
        CType(Me.magnitudeSpectrumScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dataGridPanel.ResumeLayout(False)
        CType(Me.samplingFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfPointsNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gainNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.poleZeroEditorGroupBox.ResumeLayout(False)
        Me.parametersPanel.ResumeLayout(False)
        CType(Me.poleDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.zeroDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.poleZeroEditorLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.poleZeroComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Shared Sub SetupDataGrid(ByVal dataGrid As DataGrid)
        Dim ts As DataGridTableStyle = New DataGridTableStyle
        ts.MappingName = "ArrayList"
        Dim columnWidth As Integer = ((dataGrid.ClientSize.Width _
                    - (ts.RowHeaderWidth - SystemInformation.VerticalScrollBarWidth)) _
                    / 2)
        Dim tbc As DataGridTextBoxColumn = New DataGridTextBoxColumn
        tbc.MappingName = "Real"
        tbc.HeaderText = "Real"
        tbc.Format = "f4"
        tbc.Width = columnWidth
        ts.GridColumnStyles.Add(tbc)
        tbc = New DataGridTextBoxColumn
        tbc.MappingName = "Imaginary"
        tbc.HeaderText = "Imaginary"
        tbc.Format = "f4"
        tbc.Width = columnWidth
        ts.GridColumnStyles.Add(tbc)
        dataGrid.TableStyles.Clear()
        dataGrid.TableStyles.Add(ts)
        dataGrid.ReadOnly = False
    End Sub

    Private Sub CalculateMagnitudePhase(ByVal samplingFrequency As Double, ByVal numberOfPoints As Integer, ByVal gain As Double)
        Dim array() As ComplexDouble = New ComplexDouble((numberOfPoints) - 1) {}
        Dim theta() As Double = New Double((numberOfPoints) - 1) {}
        Dim i As Integer = 0
        Do While (i < numberOfPoints)
            theta(i) = ((Math.PI * i) _
                        / numberOfPoints)
            array(i) = ComplexDouble.FromPolar(1, theta(i))
            i = i + 1
        Loop

        Dim zeros() As ComplexDouble = zerosPlot.GetComplexData
        Dim poles() As ComplexDouble = polesPlot.GetComplexData
        Dim zerosProduct() As ComplexDouble = New ComplexDouble((numberOfPoints) - 1) {}
        Dim polesProduct() As ComplexDouble = New ComplexDouble((numberOfPoints) - 1) {}
        Dim data() As ComplexDouble = New ComplexDouble((numberOfPoints) - 1) {}

        i = 0
        Do While (i < numberOfPoints)
            zerosProduct(i) = New ComplexDouble(1, 1)
            polesProduct(i) = New ComplexDouble(1, 1)
            Dim j As Integer = 0
            Do While (j < zeros.Length)
                If (Not (zeros(j).Real = 0.0 And zeros(j).Imaginary = 0.0)) Then
                    zerosProduct(i) = (zerosProduct(i).Multiply((array(i).Subtract(zeros(j)))))
                End If
                j = j + 1
            Loop
            j = 0
            Do While (j < poles.Length)
                If (Not (poles(j).Real = 0.0 And poles(j).Imaginary = 0.0)) Then
                    polesProduct(i) = (polesProduct(i).Multiply((array(i).Subtract(poles(j)))))
                End If
                j = j + 1
            Loop
            data(i) = (ComplexDouble.FromDouble(gain).Multiply(zerosProduct(i).Divide(polesProduct(i))))
            i = i + 1
        Loop
        Dim phase() As Double = Nothing
        Dim magnitude() As Double = Nothing
        ComplexDouble.DecomposeArrayPolar(data, magnitude, phase)
        i = 0
        Do While (i < numberOfPoints)
            theta(i) = ((theta(i) / (2 * Math.PI)) _
                        * samplingFrequency)
            magnitude(i) = (20 * Math.Log10(magnitude(i)))
            i = i + 1
        Loop

        magnitudeSpectrumScatterGraph.PlotXY(theta, magnitude)
    End Sub
    Private Sub OnaddPoleButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addPoleButton.Click
        polesData.Add(DefaultPole)
        poleDataGrid.DataSource = polesData
        poleDataGrid.Enabled = True
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OnaddZeroButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addZeroButton.Click
        zerosData.Add(DefaultZero)
        zeroDataGrid.DataSource = zerosData
        zeroDataGrid.Enabled = True
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OnPoleZeroGraphPlotAreaMouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles poleZeroComplexGraph.PlotAreaMouseDown
        Dim complexDataPoint As ComplexDouble = ComplexDouble.Zero
        selectedPlot = poleZeroComplexGraph.GetPlotAt(e.X, e.Y, complexDataPoint)
        Select Case (e.Button)
            Case Windows.Forms.MouseButtons.Left
                If (multipleSelectPressed = False) Then
                    selectedPoles.Clear()
                    selectedZeros.Clear()
                    isMoving = True
                End If
                If (Not (selectedPlot) Is Nothing) Then
                    If (selectedPlot Is polesPlot) Then
                        selectedPoles.Add(complexDataPoint)
                    ElseIf (selectedPlot Is zerosPlot) Then
                        selectedZeros.Add(complexDataPoint)
                    End If
                End If
                poleZeroComplexGraph.Invalidate()
            Case Windows.Forms.MouseButtons.Right
                If (Not (selectedPlot) Is Nothing) Then
                    Dim flag As Boolean = False
                    For Each cz As ComplexDouble In selectedZeros
                        If cz.Equals(complexDataPoint) Then
                            flag = True
                        End If
                    Next
                    For Each cz As ComplexDouble In selectedPoles
                        If cz.Equals(complexDataPoint) Then
                            flag = True
                        End If
                    Next
                    If (flag = False) Then
                        selectedPoles.Clear()
                        selectedZeros.Clear()
                        If (selectedPlot Is zerosPlot) Then
                            selectedZeros.Add(complexDataPoint)
                        ElseIf (selectedPlot Is polesPlot) Then
                            selectedPoles.Add(complexDataPoint)
                        End If
                    End If
                    poleZeroComplexGraph.Invalidate()
                    plotContextMenu.Show(poleZeroComplexGraph, New Point(e.X, e.Y))
                Else
                    selectedPoles.Clear()
                    selectedZeros.Clear()
                End If
        End Select
        RefreshPlot()
    End Sub

    Private Sub RefreshPlot()
        polesPlot.ClearData()
        zerosPlot.ClearData()
        If (zerosData.Count <> 0) Then
            zerosPlot.PlotComplexAppend(CType(zerosData.ToArray(GetType(ComplexDouble)), ComplexDouble()))
        End If
        If (polesData.Count <> 0) Then
            polesPlot.PlotComplexAppend(CType(polesData.ToArray(GetType(ComplexDouble)), ComplexDouble()))
        End If
    End Sub

    Private Sub OnPoleZeroGraphPlotDataChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.ComplexPlotDataChangedEventArgs) Handles poleZeroComplexGraph.PlotDataChanged
        CalculateMagnitudePhase(samplingFrequencyNumericEdit.Value, CType(numberOfPointsNumericEdit.Value, Integer), gainNumericEdit.Value)
        If (Not (polesData) Is Nothing) Then
            Dim cm As CurrencyManager = CType(Me.poleDataGrid.BindingContext(polesData), CurrencyManager)
            If (Not (cm) Is Nothing) Then
                cm.Refresh()
            End If
        End If
        If (Not (zerosData) Is Nothing) Then
            Dim cm As CurrencyManager = CType(Me.zeroDataGrid.BindingContext(zerosData), CurrencyManager)
            If (Not (cm) Is Nothing) Then
                cm.Refresh()
            End If
        End If
    End Sub

    Private Sub OnPoleZeroGraphPlotAreaMouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles poleZeroComplexGraph.PlotAreaMouseMove
        If (isMoving = True) Then
            Dim complexDataPoint As ComplexDouble = New ComplexDouble(Double.NaN, Double.NaN)
            If ((selectedPlot Is polesPlot) _
                        AndAlso (selectedPoles.Count = 1)) Then
                RemoveSelectedPoints()
                complexDataPoint = polesPlot.InverseMapDataPoint(poleZeroComplexGraph.PlotAreaBounds, New PointF(e.X, e.Y))
                polesData.Add(complexDataPoint)
                selectedPoles.Clear()
                selectedPoles.Add(complexDataPoint)
            ElseIf ((selectedPlot Is zerosPlot) _
                        AndAlso (selectedZeros.Count = 1)) Then
                RemoveSelectedPoints()
                complexDataPoint = zerosPlot.InverseMapDataPoint(poleZeroComplexGraph.PlotAreaBounds, New PointF(e.X, e.Y))
                zerosData.Add(complexDataPoint)
                selectedZeros.Clear()
                selectedZeros.Add(complexDataPoint)
            End If
            RefreshPlot()
        End If
    End Sub

    Private Sub OnPoleZeroGraphPlotAreaMouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles poleZeroComplexGraph.PlotAreaMouseUp
        isMoving = False
    End Sub

    Private Sub OnPoleZeroGraphKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles poleZeroComplexGraph.KeyDown
        If (e.KeyCode = Keys.Delete) Then
            RemoveSelectedPoints()
            selectedPoles.Clear()
            selectedZeros.Clear()
            RefreshPlot()
        End If
        If ((e.KeyData And Keys.Control) _
                    = Keys.Control) Then
            multipleSelectPressed = True
        End If
    End Sub

    Private Sub OnPoleZeroGraphKeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles poleZeroComplexGraph.KeyUp
        multipleSelectPressed = False
    End Sub

    Private Sub OnPoleZeroGraphBeforeDrawPlot(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeDrawComplexPlotEventArgs) Handles poleZeroComplexGraph.BeforeDrawPlot
        Dim g As Graphics = e.Graphics
        Dim mappedPoint As PointF
        Dim bounds As Rectangle
        Dim pen As Pen = New Pen(Color.Blue, 1)
        Dim brush As SolidBrush = New SolidBrush(Color.FromArgb(60, Color.SteelBlue))
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
        For Each complexDataPoint As ComplexDouble In selectedPoles
            mappedPoint = e.Plot.MapDataPoint(e.Bounds, complexDataPoint)
            bounds = New Rectangle(CType((mappedPoint.X _
                            - ((e.Plot.PointSize.Width / 2 + 2) _
                            )), Integer), CType((mappedPoint.Y _
                            - ((e.Plot.PointSize.Height / 2 + 2) _
                            )), Integer), e.Plot.PointSize.Width _
                            + 3, e.Plot.PointSize.Height _
                            + 3)
            g.FillEllipse(brush, bounds)
            g.DrawEllipse(pen, bounds)
        Next
        For Each complexDataPoint As ComplexDouble In selectedZeros
            mappedPoint = e.Plot.MapDataPoint(e.Bounds, complexDataPoint)
            bounds = New Rectangle(CType((mappedPoint.X _
                            - ((e.Plot.PointSize.Width / 2 + 2) _
                            )), Integer), CType((mappedPoint.Y _
                            - ((e.Plot.PointSize.Height / 2 + 2) _
                            )), Integer), e.Plot.PointSize.Width _
                            + 3, e.Plot.PointSize.Height _
                            + 3)
            g.FillEllipse(brush, bounds)
            g.DrawEllipse(pen, bounds)
        Next
    End Sub

    Private Sub RemoveSelectedPoints()
        For Each complexDataPoint As ComplexDouble In selectedPoles
            polesData.Remove(complexDataPoint)
        Next
        For Each complexDataPoint As ComplexDouble In selectedZeros
            zerosData.Remove(complexDataPoint)
        Next
    End Sub

    Private Sub OnexitMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitMenuItem.Click
        Close()
    End Sub

    Private Sub OnFilterCharacteristicsNumericEditsValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles samplingFrequencyNumericEdit.ValueChanged, numberOfPointsNumericEdit.ValueChanged, gainNumericEdit.ValueChanged
        CalculateMagnitudePhase(samplingFrequencyNumericEdit.Value, CType(numberOfPointsNumericEdit.Value, Integer), gainNumericEdit.Value)
    End Sub

    Private Sub OneditorHelpMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editorHelpMenuItem.Click
        Dim dlg As HelpDlg = New HelpDlg
        dlg.Owner = Me
        dlg.Show()
    End Sub

    Private Sub OnpoleDataGridCurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles poleDataGrid.CurrentCellChanged
        UpdatepoleDataGrid()
    End Sub

    Private Sub OnzeroDataGridCurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zeroDataGrid.CurrentCellChanged
        UpdatezeroDataGrid()
    End Sub

    Private Sub OnpoleDataGridLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles poleDataGrid.Leave
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OnzeroDataGridLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zeroDataGrid.Leave
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub UpdatepoleDataGrid()
        Dim complexDataPoint As ComplexDouble = New ComplexDouble(CType(poleDataGrid(poleDataGrid.CurrentCell.RowNumber, 0), Double), CType(poleDataGrid(poleDataGrid.CurrentCell.RowNumber, 1), Double))
        polesData(poleDataGrid.CurrentCell.RowNumber) = complexDataPoint
        selectedPoles.Clear()
        selectedZeros.Clear()
        selectedPoles.Add(complexDataPoint)
        RefreshPlot()
    End Sub

    Private Sub UpdatezeroDataGrid()
        Dim complexDataPoint As ComplexDouble = New ComplexDouble(CType(zeroDataGrid(zeroDataGrid.CurrentCell.RowNumber, 0), Double), CType(zeroDataGrid(zeroDataGrid.CurrentCell.RowNumber, 1), Double))
        zerosData(zeroDataGrid.CurrentCell.RowNumber) = complexDataPoint
        selectedPoles.Clear()
        selectedZeros.Clear()
        selectedZeros.Add(complexDataPoint)
        RefreshPlot()
    End Sub

    Private Sub OnpoleDataGridEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles poleDataGrid.Enter
        UpdatepoleDataGrid()
    End Sub

    Private Sub OnzeroDataGridEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zeroDataGrid.Enter
        UpdatezeroDataGrid()
    End Sub

    Private Sub OnselectPolesMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectPolesMenuItem.Click, selectPolesMenu.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In polesPlot.GetComplexData
            selectedPoles.Add(complexDataPoint)
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OnselectZerosMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectZerosMenuItem.Click, selectZerosMenu.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In zerosPlot.GetComplexData
            selectedZeros.Add(complexDataPoint)
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OnselectInsideMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectInsideUnitCircleMenuItem.Click, selectInsideMenuItem.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In zerosPlot.GetComplexData
            If (complexDataPoint.Magnitude <= 1) Then
                selectedZeros.Add(complexDataPoint)
            End If
        Next
        For Each complexDataPoint As ComplexDouble In polesPlot.GetComplexData
            If (complexDataPoint.Magnitude <= 1) Then
                selectedPoles.Add(complexDataPoint)
            End If
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OnselectMenuItemOutsideClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectOutsideUnitCircleMenuItem.Click, selectOutsideMenu.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In zerosPlot.GetComplexData
            If (complexDataPoint.Magnitude > 1) Then
                selectedZeros.Add(complexDataPoint)
            End If
        Next
        For Each complexDataPoint As ComplexDouble In polesPlot.GetComplexData
            If (complexDataPoint.Magnitude > 1) Then
                selectedPoles.Add(complexDataPoint)
            End If
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OnselectAboveMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectAboveRealAxisMenuItem.Click, selectAboveMenuItem.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In zerosPlot.GetComplexData
            If (complexDataPoint.Imaginary > 0) Then
                selectedZeros.Add(complexDataPoint)
            End If
        Next
        For Each complexDataPoint As ComplexDouble In polesPlot.GetComplexData
            If (complexDataPoint.Imaginary > 0) Then
                selectedPoles.Add(complexDataPoint)
            End If
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OnselectBelowMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectBelowRealAxisMenuItem.Click, selectBelowMenuItem.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In zerosPlot.GetComplexData
            If (complexDataPoint.Imaginary <= 0) Then
                selectedZeros.Add(complexDataPoint)
            End If
        Next
        For Each complexDataPoint As ComplexDouble In polesPlot.GetComplexData
            If (complexDataPoint.Imaginary <= 0) Then
                selectedPoles.Add(complexDataPoint)
            End If
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OnselectMenuItemLeftClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectLeftHalfMenuItem.Click, selectLeftHalfMenu.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In zerosPlot.GetComplexData
            If (complexDataPoint.Real <= 0) Then
                selectedZeros.Add(complexDataPoint)
            End If
        Next
        For Each complexDataPoint As ComplexDouble In polesPlot.GetComplexData
            If (complexDataPoint.Real <= 0) Then
                selectedPoles.Add(complexDataPoint)
            End If
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OnselectMenuItemRightClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selectRightHalfMenuItem.Click, selectRightMenu.Click
        selectedPoles.Clear()
        selectedZeros.Clear()
        For Each complexDataPoint As ComplexDouble In zerosPlot.GetComplexData
            If (complexDataPoint.Real > 0) Then
                selectedZeros.Add(complexDataPoint)
            End If
        Next
        For Each complexDataPoint As ComplexDouble In polesPlot.GetComplexData
            If (complexDataPoint.Real > 0) Then
                selectedPoles.Add(complexDataPoint)
            End If
        Next
        poleZeroComplexGraph.Invalidate()
    End Sub

    Private Sub OninvertRealMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invertRealContextMenuItem.Click, invertRealMenuItem.Click
        For Each complexDataPoint As ComplexDouble In selectedZeros
            zerosData.Remove(complexDataPoint)
            zerosData.Add(complexDataPoint.ComplexConjugate)
        Next
        For Each complexDataPoint As ComplexDouble In selectedPoles
            polesData.Remove(complexDataPoint)
            polesData.Add(complexDataPoint.ComplexConjugate)
        Next
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OnmirrorRealMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mirrorRealContextMenuItem.Click, mirrorRealMenuItem.Click
        For Each complexDataPoint As ComplexDouble In selectedZeros
            zerosData.Add(complexDataPoint.ComplexConjugate)
        Next
        For Each complexDataPoint As ComplexDouble In selectedPoles
            polesData.Add(complexDataPoint.ComplexConjugate)
        Next
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OnmirrorImaginaryMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mirrorImaginaryContextMenuItem.Click, mirrorImaginaryMenuItem.Click
        Dim mirrorImaginary As ComplexDouble
        For Each complexDataPoint As ComplexDouble In selectedZeros
            mirrorImaginary = New ComplexDouble((complexDataPoint.Real * -1), complexDataPoint.Imaginary)
            zerosData.Add(mirrorImaginary)
        Next
        For Each complexDataPoint As ComplexDouble In selectedPoles
            mirrorImaginary = New ComplexDouble((complexDataPoint.Real * -1), complexDataPoint.Imaginary)
            polesData.Add(mirrorImaginary)
        Next
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OninvertImaginaryMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invertImaginaryContextMenuItem.Click, invertImaginaryMenuItem.Click
        Dim mirrorImaginary As ComplexDouble
        For Each complexDataPoint As ComplexDouble In selectedZeros
            mirrorImaginary = New ComplexDouble((complexDataPoint.Real * -1), complexDataPoint.Imaginary)
            zerosData.Remove(complexDataPoint)
            zerosData.Add(mirrorImaginary)
        Next
        For Each complexDataPoint As ComplexDouble In selectedPoles
            mirrorImaginary = New ComplexDouble((complexDataPoint.Real * -1), complexDataPoint.Imaginary)
            polesData.Remove(complexDataPoint)
            polesData.Add(mirrorImaginary)
        Next
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OnremovePoleZeroMenuItemClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles removeContextMenuItem.Click, removePoleZeroMenuItem.Click
        RemoveSelectedPoints()
        selectedPoles.Clear()
        selectedZeros.Clear()
        RefreshPlot()
    End Sub

    Private Sub OnButtonHideShowClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hideShowButton.Click
        If showFilterCharacterictics Then
            showFilterCharacterictics = False
            Me.ClientSize = SmallFormSize
            Me.AutoScroll = False
            hideShowButton.Text = "Show Filter Characteristics >>"
        Else
            showFilterCharacterictics = True
            Me.ClientSize = LargeFormSize
            Me.AutoScroll = True
            hideShowButton.Text = "<< Hide Filter Characteristics"
        End If
    End Sub

    Private Sub MainForm_HelpRequested(ByVal sender As Object, ByVal hlpevent As System.Windows.Forms.HelpEventArgs) Handles MyBase.HelpRequested
        OneditorHelpMenuItemClick(Me, System.EventArgs.Empty)
        hlpevent.Handled = True
    End Sub
End Class


