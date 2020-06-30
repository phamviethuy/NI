Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()


        For Each value As Object In [Enum].GetValues(GetType(PropertyEditorInteractionMode))
            propertyEditorInteractionModeComboBox.Items.Add(value)
            If DefaultPropertyEditor.InteractionMode.Equals(value) Then
                propertyEditorInteractionModeComboBox.SelectedItem = value
            End If
        Next
        For Each value As Object In [Enum].GetValues(GetType(BorderStyle))
            propertyEditorBorderStyleComboBox.Items.Add(value)
            If DefaultPropertyEditor.BorderStyle.Equals(value) Then
                propertyEditorBorderStyleComboBox.SelectedItem = value
            End If
        Next
        For Each value As Object In [Enum].GetValues(GetType(PropertyEditorDisplayMode))
            propertyEditorDisplayModeComboBox.Items.Add(value)
            If DefaultPropertyEditor.DisplayMode.Equals(value) Then
                propertyEditorDisplayModeComboBox.SelectedItem = value
            End If
        Next
        For Each value As Object In [Enum].GetValues(GetType(HorizontalAlignment))
            propertyEditorTextAlignComboBox.Items.Add(value)
            If DefaultPropertyEditor.TextAlign.Equals(value) Then
                propertyEditorTextAlignComboBox.SelectedItem = value
            End If
        Next

        Dim data() As Double = New Double(19) {}
        random = New Random

        Dim i As Integer = 0
        Do While (i < data.Length)
            data(i) = (random.NextDouble * yAxis1.Range.Maximum)
            i = i + 1
        Loop

        sampleWaveformGraph.PlotY(data)
        xAxisLabelFormatPropertyEditor.Source = New PropertyEditorSource(xAxis1.MajorDivisions, "LabelFormat")

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

    Private WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Private WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Private WithEvents waveformPlot1 As NationalInstruments.UI.WaveformPlot
    Private WithEvents propertyEditorInteractionModeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorBorderStyleComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorDisplayModeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorTextAlignComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorInteractionModeLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorBorderStyleLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorDisplayModeLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorTextAlignLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents captionPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents annotationsPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents cursorsPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents canShowFocusPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents xAxisMajorDivisionsPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents xAxisModePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents xAxisLabelFormatPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents fontPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents borderPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents plotAreaColorPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents zoomFactorPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents interactionModePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents graphGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents captionLabel As System.Windows.Forms.Label
    Private WithEvents annotationsLabel As System.Windows.Forms.Label
    Private WithEvents cursorsLabel As System.Windows.Forms.Label
    Private WithEvents showFocusLabel As System.Windows.Forms.Label
    Private WithEvents xAxisMajorDivisionsLabel As System.Windows.Forms.Label
    Private WithEvents xAxisModeLabel As System.Windows.Forms.Label
    Private WithEvents xAxisLabelFormatLabel As System.Windows.Forms.Label
    Private WithEvents fontLabel As System.Windows.Forms.Label
    Private WithEvents borderLabel As System.Windows.Forms.Label
    Private WithEvents plotAreaColorLabel As System.Windows.Forms.Label
    Private WithEvents zoomFactorLabel As System.Windows.Forms.Label
    Private WithEvents interactionModeLabel As System.Windows.Forms.Label
    Private WithEvents sampleStatusBar As System.Windows.Forms.StatusBar
    Private WithEvents statusBarPanel As System.Windows.Forms.StatusBarPanel
    Private WithEvents chartButton As System.Windows.Forms.Button
    Private WithEvents timer As System.Windows.Forms.Timer
    Private WithEvents boundCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents boundSwitch As NationalInstruments.UI.WindowsForms.Switch
    Private WithEvents twoWayBindingGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents bindingdesciptionLabel As System.Windows.Forms.Label
    Private WithEvents switchPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents checkBoxPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private WithEvents checkBoxValueLabel As Label
    Private WithEvents switchValueLabel As Label
    Private random As Random

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.propertyEditorInteractionModeComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorBorderStyleComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorDisplayModeComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorTextAlignComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorInteractionModeLabel = New System.Windows.Forms.Label
        Me.propertyEditorBorderStyleLabel = New System.Windows.Forms.Label
        Me.propertyEditorDisplayModeLabel = New System.Windows.Forms.Label
        Me.propertyEditorTextAlignLabel = New System.Windows.Forms.Label
        Me.propertyEditorGroupBox = New System.Windows.Forms.GroupBox
        Me.graphGroupBox = New System.Windows.Forms.GroupBox
        Me.captionLabel = New System.Windows.Forms.Label
        Me.captionPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.annotationsLabel = New System.Windows.Forms.Label
        Me.annotationsPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.cursorsLabel = New System.Windows.Forms.Label
        Me.cursorsPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.showFocusLabel = New System.Windows.Forms.Label
        Me.canShowFocusPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.xAxisMajorDivisionsLabel = New System.Windows.Forms.Label
        Me.xAxisMajorDivisionsPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.xAxisModeLabel = New System.Windows.Forms.Label
        Me.xAxisModePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.xAxisLabelFormatLabel = New System.Windows.Forms.Label
        Me.xAxisLabelFormatPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.fontLabel = New System.Windows.Forms.Label
        Me.fontPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.borderLabel = New System.Windows.Forms.Label
        Me.borderPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.plotAreaColorLabel = New System.Windows.Forms.Label
        Me.plotAreaColorPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.zoomFactorLabel = New System.Windows.Forms.Label
        Me.zoomFactorPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.interactionModeLabel = New System.Windows.Forms.Label
        Me.interactionModePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.sampleStatusBar = New System.Windows.Forms.StatusBar
        Me.statusBarPanel = New System.Windows.Forms.StatusBarPanel
        Me.chartButton = New System.Windows.Forms.Button
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.twoWayBindingGroupBox = New System.Windows.Forms.GroupBox
        Me.switchValueLabel = New System.Windows.Forms.Label
        Me.checkBoxValueLabel = New System.Windows.Forms.Label
        Me.bindingdesciptionLabel = New System.Windows.Forms.Label
        Me.boundCheckBox = New System.Windows.Forms.CheckBox
        Me.switchPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.boundSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.checkBoxPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.propertyEditorGroupBox.SuspendLayout()
        Me.graphGroupBox.SuspendLayout()
        CType(Me.statusBarPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.twoWayBindingGroupBox.SuspendLayout()
        CType(Me.boundSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(536, 166)
        Me.sampleWaveformGraph.TabIndex = 0
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'waveformPlot1
        '
        Me.waveformPlot1.XAxis = Me.xAxis1
        Me.waveformPlot1.YAxis = Me.yAxis1
        '
        'propertyEditorInteractionModeComboBox
        '
        Me.propertyEditorInteractionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorInteractionModeComboBox.Location = New System.Drawing.Point(16, 64)
        Me.propertyEditorInteractionModeComboBox.Name = "propertyEditorInteractionModeComboBox"
        Me.propertyEditorInteractionModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorInteractionModeComboBox.TabIndex = 1
        '
        'propertyEditorBorderStyleComboBox
        '
        Me.propertyEditorBorderStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorBorderStyleComboBox.Location = New System.Drawing.Point(144, 64)
        Me.propertyEditorBorderStyleComboBox.Name = "propertyEditorBorderStyleComboBox"
        Me.propertyEditorBorderStyleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorBorderStyleComboBox.TabIndex = 3
        '
        'propertyEditorDisplayModeComboBox
        '
        Me.propertyEditorDisplayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorDisplayModeComboBox.Location = New System.Drawing.Point(272, 64)
        Me.propertyEditorDisplayModeComboBox.Name = "propertyEditorDisplayModeComboBox"
        Me.propertyEditorDisplayModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorDisplayModeComboBox.TabIndex = 5
        '
        'propertyEditorTextAlignComboBox
        '
        Me.propertyEditorTextAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorTextAlignComboBox.Location = New System.Drawing.Point(400, 64)
        Me.propertyEditorTextAlignComboBox.Name = "propertyEditorTextAlignComboBox"
        Me.propertyEditorTextAlignComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorTextAlignComboBox.TabIndex = 7
        '
        'propertyEditorInteractionModeLabel
        '
        Me.propertyEditorInteractionModeLabel.Location = New System.Drawing.Point(16, 32)
        Me.propertyEditorInteractionModeLabel.Name = "propertyEditorInteractionModeLabel"
        Me.propertyEditorInteractionModeLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorInteractionModeLabel.TabIndex = 0
        Me.propertyEditorInteractionModeLabel.Text = "Interaction Mode:"
        '
        'propertyEditorBorderStyleLabel
        '
        Me.propertyEditorBorderStyleLabel.Location = New System.Drawing.Point(144, 32)
        Me.propertyEditorBorderStyleLabel.Name = "propertyEditorBorderStyleLabel"
        Me.propertyEditorBorderStyleLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorBorderStyleLabel.TabIndex = 2
        Me.propertyEditorBorderStyleLabel.Text = "Border Style:"
        '
        'propertyEditorDisplayModeLabel
        '
        Me.propertyEditorDisplayModeLabel.Location = New System.Drawing.Point(272, 32)
        Me.propertyEditorDisplayModeLabel.Name = "propertyEditorDisplayModeLabel"
        Me.propertyEditorDisplayModeLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorDisplayModeLabel.TabIndex = 4
        Me.propertyEditorDisplayModeLabel.Text = "Display Mode:"
        '
        'propertyEditorTextAlignLabel
        '
        Me.propertyEditorTextAlignLabel.Location = New System.Drawing.Point(400, 32)
        Me.propertyEditorTextAlignLabel.Name = "propertyEditorTextAlignLabel"
        Me.propertyEditorTextAlignLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorTextAlignLabel.TabIndex = 6
        Me.propertyEditorTextAlignLabel.Text = "Text Align:"
        '
        'propertyEditorGroupBox
        '
        Me.propertyEditorGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorDisplayModeComboBox)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorInteractionModeLabel)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorBorderStyleComboBox)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorInteractionModeComboBox)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorBorderStyleLabel)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorTextAlignComboBox)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorTextAlignLabel)
        Me.propertyEditorGroupBox.Controls.Add(Me.propertyEditorDisplayModeLabel)
        Me.propertyEditorGroupBox.Location = New System.Drawing.Point(8, 214)
        Me.propertyEditorGroupBox.Name = "propertyEditorGroupBox"
        Me.propertyEditorGroupBox.Size = New System.Drawing.Size(536, 104)
        Me.propertyEditorGroupBox.TabIndex = 2
        Me.propertyEditorGroupBox.TabStop = False
        Me.propertyEditorGroupBox.Text = "Property Editor"
        '
        'graphGroupBox
        '
        Me.graphGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graphGroupBox.Controls.Add(Me.captionLabel)
        Me.graphGroupBox.Controls.Add(Me.captionPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.annotationsLabel)
        Me.graphGroupBox.Controls.Add(Me.annotationsPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.cursorsLabel)
        Me.graphGroupBox.Controls.Add(Me.cursorsPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.showFocusLabel)
        Me.graphGroupBox.Controls.Add(Me.canShowFocusPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.xAxisMajorDivisionsLabel)
        Me.graphGroupBox.Controls.Add(Me.xAxisMajorDivisionsPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.xAxisModeLabel)
        Me.graphGroupBox.Controls.Add(Me.xAxisModePropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.xAxisLabelFormatLabel)
        Me.graphGroupBox.Controls.Add(Me.xAxisLabelFormatPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.fontLabel)
        Me.graphGroupBox.Controls.Add(Me.fontPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.borderLabel)
        Me.graphGroupBox.Controls.Add(Me.borderPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.plotAreaColorLabel)
        Me.graphGroupBox.Controls.Add(Me.plotAreaColorPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.zoomFactorLabel)
        Me.graphGroupBox.Controls.Add(Me.zoomFactorPropertyEditor)
        Me.graphGroupBox.Controls.Add(Me.interactionModeLabel)
        Me.graphGroupBox.Controls.Add(Me.interactionModePropertyEditor)
        Me.graphGroupBox.Location = New System.Drawing.Point(8, 334)
        Me.graphGroupBox.Name = "graphGroupBox"
        Me.graphGroupBox.Size = New System.Drawing.Size(536, 232)
        Me.graphGroupBox.TabIndex = 3
        Me.graphGroupBox.TabStop = False
        Me.graphGroupBox.Text = "Graph"
        '
        'captionLabel
        '
        Me.captionLabel.Location = New System.Drawing.Point(400, 24)
        Me.captionLabel.Name = "captionLabel"
        Me.captionLabel.Size = New System.Drawing.Size(100, 23)
        Me.captionLabel.TabIndex = 6
        Me.captionLabel.Text = "Caption:"
        '
        'captionPropertyEditor
        '
        Me.captionPropertyEditor.Location = New System.Drawing.Point(400, 56)
        Me.captionPropertyEditor.Name = "captionPropertyEditor"
        Me.captionPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.captionPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Caption")
        Me.captionPropertyEditor.TabIndex = 7
        '
        'annotationsLabel
        '
        Me.annotationsLabel.Location = New System.Drawing.Point(400, 168)
        Me.annotationsLabel.Name = "annotationsLabel"
        Me.annotationsLabel.Size = New System.Drawing.Size(100, 23)
        Me.annotationsLabel.TabIndex = 22
        Me.annotationsLabel.Text = "Annotations:"
        '
        'annotationsPropertyEditor
        '
        Me.annotationsPropertyEditor.BackColor = System.Drawing.SystemColors.Control
        Me.annotationsPropertyEditor.Location = New System.Drawing.Point(400, 200)
        Me.annotationsPropertyEditor.Name = "annotationsPropertyEditor"
        Me.annotationsPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.annotationsPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Annotations")
        Me.annotationsPropertyEditor.TabIndex = 23
        '
        'cursorsLabel
        '
        Me.cursorsLabel.Location = New System.Drawing.Point(272, 168)
        Me.cursorsLabel.Name = "cursorsLabel"
        Me.cursorsLabel.Size = New System.Drawing.Size(100, 23)
        Me.cursorsLabel.TabIndex = 20
        Me.cursorsLabel.Text = "Cursors:"
        '
        'cursorsPropertyEditor
        '
        Me.cursorsPropertyEditor.BackColor = System.Drawing.SystemColors.Control
        Me.cursorsPropertyEditor.Location = New System.Drawing.Point(272, 200)
        Me.cursorsPropertyEditor.Name = "cursorsPropertyEditor"
        Me.cursorsPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.cursorsPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Cursors")
        Me.cursorsPropertyEditor.TabIndex = 21
        '
        'showFocusLabel
        '
        Me.showFocusLabel.Location = New System.Drawing.Point(272, 24)
        Me.showFocusLabel.Name = "showFocusLabel"
        Me.showFocusLabel.Size = New System.Drawing.Size(100, 23)
        Me.showFocusLabel.TabIndex = 4
        Me.showFocusLabel.Text = "Show Focus:"
        '
        'canShowFocusPropertyEditor
        '
        Me.canShowFocusPropertyEditor.Location = New System.Drawing.Point(272, 56)
        Me.canShowFocusPropertyEditor.Name = "canShowFocusPropertyEditor"
        Me.canShowFocusPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.canShowFocusPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "CanShowFocus")
        Me.canShowFocusPropertyEditor.TabIndex = 5
        '
        'xAxisMajorDivisionsLabel
        '
        Me.xAxisMajorDivisionsLabel.Location = New System.Drawing.Point(144, 168)
        Me.xAxisMajorDivisionsLabel.Name = "xAxisMajorDivisionsLabel"
        Me.xAxisMajorDivisionsLabel.Size = New System.Drawing.Size(120, 23)
        Me.xAxisMajorDivisionsLabel.TabIndex = 18
        Me.xAxisMajorDivisionsLabel.Text = "XAxis Major Divisions:"
        '
        'xAxisMajorDivisionsPropertyEditor
        '
        Me.xAxisMajorDivisionsPropertyEditor.BackColor = System.Drawing.SystemColors.Control
        Me.xAxisMajorDivisionsPropertyEditor.Location = New System.Drawing.Point(144, 200)
        Me.xAxisMajorDivisionsPropertyEditor.Name = "xAxisMajorDivisionsPropertyEditor"
        Me.xAxisMajorDivisionsPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.xAxisMajorDivisionsPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.xAxis1, "MajorDivisions")
        Me.xAxisMajorDivisionsPropertyEditor.TabIndex = 19
        '
        'xAxisModeLabel
        '
        Me.xAxisModeLabel.Location = New System.Drawing.Point(16, 168)
        Me.xAxisModeLabel.Name = "xAxisModeLabel"
        Me.xAxisModeLabel.Size = New System.Drawing.Size(100, 23)
        Me.xAxisModeLabel.TabIndex = 16
        Me.xAxisModeLabel.Text = "XAxis Mode:"
        '
        'xAxisModePropertyEditor
        '
        Me.xAxisModePropertyEditor.Location = New System.Drawing.Point(16, 200)
        Me.xAxisModePropertyEditor.Name = "xAxisModePropertyEditor"
        Me.xAxisModePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.xAxisModePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.xAxis1, "Mode")
        Me.xAxisModePropertyEditor.TabIndex = 17
        '
        'xAxisLabelFormatLabel
        '
        Me.xAxisLabelFormatLabel.Location = New System.Drawing.Point(400, 96)
        Me.xAxisLabelFormatLabel.Name = "xAxisLabelFormatLabel"
        Me.xAxisLabelFormatLabel.Size = New System.Drawing.Size(120, 23)
        Me.xAxisLabelFormatLabel.TabIndex = 14
        Me.xAxisLabelFormatLabel.Text = "XAxis Label Format:"
        '
        'xAxisLabelFormatPropertyEditor
        '
        Me.xAxisLabelFormatPropertyEditor.Location = New System.Drawing.Point(400, 128)
        Me.xAxisLabelFormatPropertyEditor.Name = "xAxisLabelFormatPropertyEditor"
        Me.xAxisLabelFormatPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.xAxisLabelFormatPropertyEditor.TabIndex = 15
        '
        'fontLabel
        '
        Me.fontLabel.Location = New System.Drawing.Point(272, 96)
        Me.fontLabel.Name = "fontLabel"
        Me.fontLabel.Size = New System.Drawing.Size(100, 23)
        Me.fontLabel.TabIndex = 12
        Me.fontLabel.Text = "Font:"
        '
        'fontPropertyEditor
        '
        Me.fontPropertyEditor.Location = New System.Drawing.Point(272, 128)
        Me.fontPropertyEditor.Name = "fontPropertyEditor"
        Me.fontPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.fontPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Font")
        Me.fontPropertyEditor.TabIndex = 13
        '
        'borderLabel
        '
        Me.borderLabel.Location = New System.Drawing.Point(16, 96)
        Me.borderLabel.Name = "borderLabel"
        Me.borderLabel.Size = New System.Drawing.Size(100, 23)
        Me.borderLabel.TabIndex = 8
        Me.borderLabel.Text = "Border:"
        '
        'borderPropertyEditor
        '
        Me.borderPropertyEditor.Location = New System.Drawing.Point(16, 128)
        Me.borderPropertyEditor.Name = "borderPropertyEditor"
        Me.borderPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.borderPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Border")
        Me.borderPropertyEditor.TabIndex = 9
        '
        'plotAreaColorLabel
        '
        Me.plotAreaColorLabel.Location = New System.Drawing.Point(144, 96)
        Me.plotAreaColorLabel.Name = "plotAreaColorLabel"
        Me.plotAreaColorLabel.Size = New System.Drawing.Size(100, 23)
        Me.plotAreaColorLabel.TabIndex = 10
        Me.plotAreaColorLabel.Text = "Plot Area Color:"
        '
        'plotAreaColorPropertyEditor
        '
        Me.plotAreaColorPropertyEditor.Location = New System.Drawing.Point(144, 128)
        Me.plotAreaColorPropertyEditor.Name = "plotAreaColorPropertyEditor"
        Me.plotAreaColorPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.plotAreaColorPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "PlotAreaColor")
        Me.plotAreaColorPropertyEditor.TabIndex = 11
        '
        'zoomFactorLabel
        '
        Me.zoomFactorLabel.Location = New System.Drawing.Point(144, 24)
        Me.zoomFactorLabel.Name = "zoomFactorLabel"
        Me.zoomFactorLabel.Size = New System.Drawing.Size(100, 23)
        Me.zoomFactorLabel.TabIndex = 2
        Me.zoomFactorLabel.Text = "Zoom Factor:"
        '
        'zoomFactorPropertyEditor
        '
        Me.zoomFactorPropertyEditor.Location = New System.Drawing.Point(144, 56)
        Me.zoomFactorPropertyEditor.Name = "zoomFactorPropertyEditor"
        Me.zoomFactorPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.zoomFactorPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "ZoomFactor")
        Me.zoomFactorPropertyEditor.TabIndex = 3
        '
        'interactionModeLabel
        '
        Me.interactionModeLabel.Location = New System.Drawing.Point(16, 24)
        Me.interactionModeLabel.Name = "interactionModeLabel"
        Me.interactionModeLabel.Size = New System.Drawing.Size(100, 23)
        Me.interactionModeLabel.TabIndex = 0
        Me.interactionModeLabel.Text = "Interaction Mode:"
        '
        'interactionModePropertyEditor
        '
        Me.interactionModePropertyEditor.Location = New System.Drawing.Point(16, 56)
        Me.interactionModePropertyEditor.Name = "interactionModePropertyEditor"
        Me.interactionModePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.interactionModePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "InteractionMode")
        Me.interactionModePropertyEditor.TabIndex = 1
        '
        'sampleStatusBar
        '
        Me.sampleStatusBar.Location = New System.Drawing.Point(0, 726)
        Me.sampleStatusBar.Name = "sampleStatusBar"
        Me.sampleStatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.statusBarPanel})
        Me.sampleStatusBar.ShowPanels = True
        Me.sampleStatusBar.Size = New System.Drawing.Size(552, 22)
        Me.sampleStatusBar.TabIndex = 5
        '
        'statusBarPanel
        '
        Me.statusBarPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.statusBarPanel.Width = 535
        '
        'chartButton
        '
        Me.chartButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chartButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chartButton.Location = New System.Drawing.Point(464, 190)
        Me.chartButton.Name = "chartButton"
        Me.chartButton.Size = New System.Drawing.Size(72, 23)
        Me.chartButton.TabIndex = 1
        Me.chartButton.Text = "Chart"
        '
        'timer
        '
        Me.timer.Interval = 300
        '
        'twoWayBindingGroupBox
        '
        Me.twoWayBindingGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.twoWayBindingGroupBox.Controls.Add(Me.switchValueLabel)
        Me.twoWayBindingGroupBox.Controls.Add(Me.checkBoxValueLabel)
        Me.twoWayBindingGroupBox.Controls.Add(Me.bindingdesciptionLabel)
        Me.twoWayBindingGroupBox.Controls.Add(Me.boundCheckBox)
        Me.twoWayBindingGroupBox.Controls.Add(Me.switchPropertyEditor)
        Me.twoWayBindingGroupBox.Controls.Add(Me.boundSwitch)
        Me.twoWayBindingGroupBox.Controls.Add(Me.checkBoxPropertyEditor)
        Me.twoWayBindingGroupBox.Location = New System.Drawing.Point(16, 582)
        Me.twoWayBindingGroupBox.Name = "twoWayBindingGroupBox"
        Me.twoWayBindingGroupBox.Size = New System.Drawing.Size(528, 136)
        Me.twoWayBindingGroupBox.TabIndex = 4
        Me.twoWayBindingGroupBox.TabStop = False
        Me.twoWayBindingGroupBox.Text = "Two-way Binding"
        '
        'switchValueLabel
        '
        Me.switchValueLabel.AutoSize = True
        Me.switchValueLabel.Location = New System.Drawing.Point(375, 80)
        Me.switchValueLabel.Name = "switchValueLabel"
        Me.switchValueLabel.Size = New System.Drawing.Size(109, 13)
        Me.switchValueLabel.TabIndex = 7
        Me.switchValueLabel.Text = "Property Editor Value:"
        '
        'checkBoxValueLabel
        '
        Me.checkBoxValueLabel.AutoSize = True
        Me.checkBoxValueLabel.Location = New System.Drawing.Point(183, 80)
        Me.checkBoxValueLabel.Name = "checkBoxValueLabel"
        Me.checkBoxValueLabel.Size = New System.Drawing.Size(109, 13)
        Me.checkBoxValueLabel.TabIndex = 6
        Me.checkBoxValueLabel.Text = "Property Editor Value:"
        '
        'bindingdesciptionLabel
        '
        Me.bindingdesciptionLabel.Location = New System.Drawing.Point(16, 24)
        Me.bindingdesciptionLabel.Name = "bindingdesciptionLabel"
        Me.bindingdesciptionLabel.Size = New System.Drawing.Size(144, 96)
        Me.bindingdesciptionLabel.TabIndex = 0
        Me.bindingdesciptionLabel.Text = "Change the value on the controls and property editors and verify the values stay " & _
            "in sync."
        '
        'boundCheckBox
        '
        Me.boundCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.boundCheckBox.Location = New System.Drawing.Point(184, 24)
        Me.boundCheckBox.Name = "boundCheckBox"
        Me.boundCheckBox.Size = New System.Drawing.Size(112, 24)
        Me.boundCheckBox.TabIndex = 1
        Me.boundCheckBox.Text = "CheckBox"
        '
        'switchPropertyEditor
        '
        Me.switchPropertyEditor.Location = New System.Drawing.Point(376, 105)
        Me.switchPropertyEditor.Name = "switchPropertyEditor"
        Me.switchPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.switchPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.boundSwitch, "Value")
        Me.switchPropertyEditor.TabIndex = 4
        '
        'boundSwitch
        '
        Me.boundSwitch.Border = NationalInstruments.UI.Border.Solid
        Me.boundSwitch.Location = New System.Drawing.Point(376, 19)
        Me.boundSwitch.Name = "boundSwitch"
        Me.boundSwitch.Size = New System.Drawing.Size(136, 48)
        Me.boundSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalSlide
        Me.boundSwitch.TabIndex = 3
        '
        'checkBoxPropertyEditor
        '
        Me.checkBoxPropertyEditor.Location = New System.Drawing.Point(184, 105)
        Me.checkBoxPropertyEditor.Name = "checkBoxPropertyEditor"
        Me.checkBoxPropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.checkBoxPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.boundCheckBox, "Checked")
        Me.checkBoxPropertyEditor.TabIndex = 2
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(552, 748)
        Me.Controls.Add(Me.twoWayBindingGroupBox)
        Me.Controls.Add(Me.sampleStatusBar)
        Me.Controls.Add(Me.graphGroupBox)
        Me.Controls.Add(Me.propertyEditorGroupBox)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Controls.Add(Me.chartButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Property Editor Features"
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.propertyEditorGroupBox.ResumeLayout(False)
        Me.graphGroupBox.ResumeLayout(False)
        CType(Me.statusBarPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.twoWayBindingGroupBox.ResumeLayout(False)
        Me.twoWayBindingGroupBox.PerformLayout()
        CType(Me.boundSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ReadOnly Property DefaultPropertyEditor() As PropertyEditor
        Get
            Return interactionModePropertyEditor
        End Get
    End Property

    Private Sub OnPropertyEditorInteractionModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorInteractionModeComboBox.SelectedIndexChanged
        For Each control As Control In graphGroupBox.Controls
            If (control.GetType() Is GetType(PropertyEditor)) Then
                CType(control, PropertyEditor).InteractionMode = CType(propertyEditorInteractionModeComboBox.SelectedItem, PropertyEditorInteractionMode)
            End If
        Next
    End Sub

    Private Sub OnPropertyEditorBorderStyleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorBorderStyleComboBox.SelectedIndexChanged
        For Each control As Control In graphGroupBox.Controls
            If (control.GetType() Is GetType(PropertyEditor)) Then
                CType(control, PropertyEditor).BorderStyle = CType(propertyEditorBorderStyleComboBox.SelectedItem, BorderStyle)
            End If
        Next
    End Sub

    Private Sub OnPropertyEditorDisplayModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorDisplayModeComboBox.SelectedIndexChanged
        For Each control As Control In graphGroupBox.Controls
            If (control.GetType() Is GetType(PropertyEditor)) Then
                CType(control, PropertyEditor).DisplayMode = CType(propertyEditorDisplayModeComboBox.SelectedItem, PropertyEditorDisplayMode)
            End If
        Next
    End Sub

    Private Sub OnPropertyEditorTextAlignChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorTextAlignComboBox.SelectedIndexChanged
        For Each control As Control In graphGroupBox.Controls
            If (control.GetType() Is GetType(PropertyEditor)) Then
                CType(control, PropertyEditor).TextAlign = CType(propertyEditorTextAlignComboBox.SelectedItem, HorizontalAlignment)
            End If
        Next
    End Sub

    Private Sub ResetError()
        statusBarPanel.Text = String.Empty
    End Sub

    Private Sub SetError(ByVal invalidValue As String, ByVal propertyName As String)
        statusBarPanel.Text = String.Format("{0} is an invalid value for {1}.", invalidValue, propertyName)
    End Sub

    Private Sub OnInteractionModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles interactionModePropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnInteractionModeWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles interactionModePropertyEditor.SourceValueWarning
        SetError(e.InvalidString, interactionModePropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnZoomFactorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoomFactorPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnZoomFactorWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles zoomFactorPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, zoomFactorPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnShowFocusChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles canShowFocusPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnShowFocusWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles canShowFocusPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, canShowFocusPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnCaptionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles captionPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnCaptionWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles captionPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, captionPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnBorderChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles borderPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnBorderWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles borderPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, borderPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnPlotAreaColorChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotAreaColorPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnPlotAreaColorWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles plotAreaColorPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, plotAreaColorPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnWaveformGraphFontChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fontPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnFontWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles fontPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, fontPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnXAxisLabelFormatChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xAxisLabelFormatPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnXAxisLabelFormatWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles xAxisLabelFormatPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, xAxisLabelFormatPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnXAxisModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xAxisModePropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnXAxisModeWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles xAxisModePropertyEditor.SourceValueWarning
        SetError(e.InvalidString, xAxisModePropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnXAxisMajorDivisionsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xAxisMajorDivisionsPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnXAxisMajorDivisionsWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles xAxisMajorDivisionsPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, xAxisMajorDivisionsPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnCursorsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cursorsPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnCursorsWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles cursorsPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, cursorsPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnAnnotationsChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles annotationsPropertyEditor.SourceValueChanged
        ResetError()
    End Sub

    Private Sub OnAnnotationsWarning(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs) Handles annotationsPropertyEditor.SourceValueWarning
        SetError(e.InvalidString, annotationsPropertyEditor.Source.PropertyName)
    End Sub

    Private Sub OnChartButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chartButton.Click
        timer.Enabled = Not timer.Enabled
    End Sub

    Private Sub OnTimerTick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer.Tick
        sampleWaveformGraph.PlotYAppend((random.NextDouble * yAxis1.Range.Maximum))
    End Sub

    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub
End Class
