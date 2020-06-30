<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.sampleWaveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.sampleXAxis = New NationalInstruments.UI.XAxis
        Me.sampleYAxis = New NationalInstruments.UI.YAxis
        Me.sampleInstrumentControlStrip = New NationalInstruments.UI.WindowsForms.InstrumentControlStrip
        Me.interactionModeToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.interactionModeToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.zoomFactorToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.zoomFactorToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.showFocusToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.showFocusToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.captionToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.captionToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.borderToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.borderToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.plotAreaColorToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.plotAreaColorToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.fontToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.fontToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.xAxisLabelFormatToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.xAxisLabelFormatToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.xAxisMajorDivisionsToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.xAxisMajorDivisionsToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.annotationsToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.annotationsToolStripPropertyEditor = New NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
        Me.toolStripPropertyEditorSettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.propertyEditorInteractionModeLabel = New System.Windows.Forms.Label
        Me.propertyEditorRenderModeLabel = New System.Windows.Forms.Label
        Me.propertyEditorInteractionModeComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorBorderStyleComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorBorderStyleLabel = New System.Windows.Forms.Label
        Me.propertyEditorRenderModeComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorTextAlignLabel = New System.Windows.Forms.Label
        Me.propertyEditorDisplayModeComboBox = New System.Windows.Forms.ComboBox
        Me.propertyEditorDisplayModeLabel = New System.Windows.Forms.Label
        Me.propertyEditorTextAlignComboBox = New System.Windows.Forms.ComboBox
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sampleInstrumentControlStrip.SuspendLayout()
        Me.toolStripPropertyEditorSettingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(12, 37)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.sampleWaveformPlot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(409, 264)
        Me.sampleWaveformGraph.TabIndex = 1
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.sampleXAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.sampleYAxis})
        '
        'sampleWaveformPlot
        '
        Me.sampleWaveformPlot.XAxis = Me.sampleXAxis
        Me.sampleWaveformPlot.XErrorHighPointSize = New System.Drawing.Size(5, 5)
        Me.sampleWaveformPlot.XErrorLowPointSize = New System.Drawing.Size(5, 5)
        Me.sampleWaveformPlot.YAxis = Me.sampleYAxis
        Me.sampleWaveformPlot.YErrorHighPointSize = New System.Drawing.Size(5, 5)
        Me.sampleWaveformPlot.YErrorLowPointSize = New System.Drawing.Size(5, 5)
        '
        'sampleInstrumentControlStrip
        '
        Me.sampleInstrumentControlStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.interactionModeToolStripLabel, Me.interactionModeToolStripPropertyEditor, Me.zoomFactorToolStripLabel, Me.zoomFactorToolStripPropertyEditor, Me.showFocusToolStripLabel, Me.showFocusToolStripPropertyEditor, Me.captionToolStripLabel, Me.captionToolStripPropertyEditor, Me.borderToolStripLabel, Me.borderToolStripPropertyEditor, Me.plotAreaColorToolStripLabel, Me.plotAreaColorToolStripPropertyEditor, Me.fontToolStripLabel, Me.fontToolStripPropertyEditor, Me.xAxisLabelFormatToolStripLabel, Me.xAxisLabelFormatToolStripPropertyEditor, Me.xAxisMajorDivisionsToolStripLabel, Me.xAxisMajorDivisionsToolStripPropertyEditor, Me.annotationsToolStripLabel, Me.annotationsToolStripPropertyEditor})
        Me.sampleInstrumentControlStrip.Location = New System.Drawing.Point(0, 0)
        Me.sampleInstrumentControlStrip.Name = "sampleInstrumentControlStrip"
        Me.sampleInstrumentControlStrip.Size = New System.Drawing.Size(433, 25)
        Me.sampleInstrumentControlStrip.TabIndex = 0
        Me.sampleInstrumentControlStrip.Text = "propertyEditorStrip"
        '
        'interactionModeToolStripLabel
        '
        Me.interactionModeToolStripLabel.Name = "interactionModeToolStripLabel"
        Me.interactionModeToolStripLabel.Size = New System.Drawing.Size(93, 22)
        Me.interactionModeToolStripLabel.Text = "Interaction Mode:"
        '
        'interactionModeToolStripPropertyEditor
        '
        Me.interactionModeToolStripPropertyEditor.AutoSize = False
        Me.interactionModeToolStripPropertyEditor.Name = "interactionModeToolStripPropertyEditor"
        Me.interactionModeToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.interactionModeToolStripPropertyEditor.Size = New System.Drawing.Size(120, 16)
        Me.interactionModeToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "InteractionMode")
        '
        'zoomFactorToolStripLabel
        '
        Me.zoomFactorToolStripLabel.Name = "zoomFactorToolStripLabel"
        Me.zoomFactorToolStripLabel.Size = New System.Drawing.Size(71, 22)
        Me.zoomFactorToolStripLabel.Text = "Zoom Factor:"
        '
        'zoomFactorToolStripPropertyEditor
        '
        Me.zoomFactorToolStripPropertyEditor.AutoSize = False
        Me.zoomFactorToolStripPropertyEditor.Name = "zoomFactorToolStripPropertyEditor"
        Me.zoomFactorToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.zoomFactorToolStripPropertyEditor.Size = New System.Drawing.Size(120, 16)
        Me.zoomFactorToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "ZoomFactor")
        '
        'showFocusToolStripLabel
        '
        Me.showFocusToolStripLabel.Name = "showFocusToolStripLabel"
        Me.showFocusToolStripLabel.Size = New System.Drawing.Size(68, 13)
        Me.showFocusToolStripLabel.Text = "Show Focus:"
        '
        'showFocusToolStripPropertyEditor
        '
        Me.showFocusToolStripPropertyEditor.AutoSize = False
        Me.showFocusToolStripPropertyEditor.Name = "showFocusToolStripPropertyEditor"
        Me.showFocusToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.showFocusToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        Me.showFocusToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "CanShowFocus")
        '
        'captionToolStripLabel
        '
        Me.captionToolStripLabel.Name = "captionToolStripLabel"
        Me.captionToolStripLabel.Size = New System.Drawing.Size(48, 13)
        Me.captionToolStripLabel.Text = "Caption:"
        '
        'captionToolStripPropertyEditor
        '
        Me.captionToolStripPropertyEditor.AutoSize = False
        Me.captionToolStripPropertyEditor.Name = "captionToolStripPropertyEditor"
        Me.captionToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.captionToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        Me.captionToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Caption")
        '
        'borderToolStripLabel
        '
        Me.borderToolStripLabel.Name = "borderToolStripLabel"
        Me.borderToolStripLabel.Size = New System.Drawing.Size(43, 13)
        Me.borderToolStripLabel.Text = "Border:"
        '
        'borderToolStripPropertyEditor
        '
        Me.borderToolStripPropertyEditor.AutoSize = False
        Me.borderToolStripPropertyEditor.Name = "borderToolStripPropertyEditor"
        Me.borderToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.borderToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        Me.borderToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Border")
        '
        'plotAreaColorToolStripLabel
        '
        Me.plotAreaColorToolStripLabel.Name = "plotAreaColorToolStripLabel"
        Me.plotAreaColorToolStripLabel.Size = New System.Drawing.Size(83, 13)
        Me.plotAreaColorToolStripLabel.Text = "Plot Area Color:"
        '
        'plotAreaColorToolStripPropertyEditor
        '
        Me.plotAreaColorToolStripPropertyEditor.AutoSize = False
        Me.plotAreaColorToolStripPropertyEditor.Name = "plotAreaColorToolStripPropertyEditor"
        Me.plotAreaColorToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.plotAreaColorToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        Me.plotAreaColorToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "PlotAreaColor")
        '
        'fontToolStripLabel
        '
        Me.fontToolStripLabel.Name = "fontToolStripLabel"
        Me.fontToolStripLabel.Size = New System.Drawing.Size(33, 13)
        Me.fontToolStripLabel.Text = "Font:"
        '
        'fontToolStripPropertyEditor
        '
        Me.fontToolStripPropertyEditor.AutoSize = False
        Me.fontToolStripPropertyEditor.Name = "fontToolStripPropertyEditor"
        Me.fontToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.fontToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        Me.fontToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Font")
        '
        'xAxisLabelFormatToolStripLabel
        '
        Me.xAxisLabelFormatToolStripLabel.Name = "xAxisLabelFormatToolStripLabel"
        Me.xAxisLabelFormatToolStripLabel.Size = New System.Drawing.Size(102, 13)
        Me.xAxisLabelFormatToolStripLabel.Text = "XAxis Label Format:"
        '
        'xAxisLabelFormatToolStripPropertyEditor
        '
        Me.xAxisLabelFormatToolStripPropertyEditor.AutoSize = False
        Me.xAxisLabelFormatToolStripPropertyEditor.Name = "xAxisLabelFormatToolStripPropertyEditor"
        Me.xAxisLabelFormatToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.xAxisLabelFormatToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        '
        'xAxisMajorDivisionsToolStripLabel
        '
        Me.xAxisMajorDivisionsToolStripLabel.Name = "xAxisMajorDivisionsToolStripLabel"
        Me.xAxisMajorDivisionsToolStripLabel.Size = New System.Drawing.Size(111, 13)
        Me.xAxisMajorDivisionsToolStripLabel.Text = "XAxis Major Divisions:"
        '
        'xAxisMajorDivisionsToolStripPropertyEditor
        '
        Me.xAxisMajorDivisionsToolStripPropertyEditor.AutoSize = False
        Me.xAxisMajorDivisionsToolStripPropertyEditor.Name = "xAxisMajorDivisionsToolStripPropertyEditor"
        Me.xAxisMajorDivisionsToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.xAxisMajorDivisionsToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        Me.xAxisMajorDivisionsToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleXAxis, "MajorDivisions")
        '
        'annotationsToolStripLabel
        '
        Me.annotationsToolStripLabel.Name = "annotationsToolStripLabel"
        Me.annotationsToolStripLabel.Size = New System.Drawing.Size(69, 13)
        Me.annotationsToolStripLabel.Text = "Annotations:"
        '
        'annotationsToolStripPropertyEditor
        '
        Me.annotationsToolStripPropertyEditor.AutoSize = False
        Me.annotationsToolStripPropertyEditor.Name = "annotationsToolStripPropertyEditor"
        Me.annotationsToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit
        Me.annotationsToolStripPropertyEditor.Size = New System.Drawing.Size(120, 21)
        Me.annotationsToolStripPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleWaveformGraph, "Annotations")
        '
        'toolStripPropertyEditorSettingsGroupBox
        '
        Me.toolStripPropertyEditorSettingsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorInteractionModeLabel)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorRenderModeLabel)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorInteractionModeComboBox)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorBorderStyleComboBox)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorBorderStyleLabel)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorRenderModeComboBox)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorTextAlignLabel)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorDisplayModeComboBox)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorDisplayModeLabel)
        Me.toolStripPropertyEditorSettingsGroupBox.Controls.Add(Me.propertyEditorTextAlignComboBox)
        Me.toolStripPropertyEditorSettingsGroupBox.Location = New System.Drawing.Point(12, 311)
        Me.toolStripPropertyEditorSettingsGroupBox.Name = "toolStripPropertyEditorSettingsGroupBox"
        Me.toolStripPropertyEditorSettingsGroupBox.Size = New System.Drawing.Size(409, 208)
        Me.toolStripPropertyEditorSettingsGroupBox.TabIndex = 2
        Me.toolStripPropertyEditorSettingsGroupBox.TabStop = False
        Me.toolStripPropertyEditorSettingsGroupBox.Text = "Tool Strip Property Editor Settings"
        '
        'propertyEditorInteractionModeLabel
        '
        Me.propertyEditorInteractionModeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorInteractionModeLabel.Location = New System.Drawing.Point(26, 26)
        Me.propertyEditorInteractionModeLabel.Name = "propertyEditorInteractionModeLabel"
        Me.propertyEditorInteractionModeLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorInteractionModeLabel.TabIndex = 7
        Me.propertyEditorInteractionModeLabel.Text = "Interaction Mode:"
        '
        'propertyEditorRenderModeLabel
        '
        Me.propertyEditorRenderModeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorRenderModeLabel.Location = New System.Drawing.Point(26, 145)
        Me.propertyEditorRenderModeLabel.Name = "propertyEditorRenderModeLabel"
        Me.propertyEditorRenderModeLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorRenderModeLabel.TabIndex = 11
        Me.propertyEditorRenderModeLabel.Text = "Render Mode:"
        '
        'propertyEditorInteractionModeComboBox
        '
        Me.propertyEditorInteractionModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorInteractionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorInteractionModeComboBox.FormattingEnabled = True
        Me.propertyEditorInteractionModeComboBox.Location = New System.Drawing.Point(29, 52)
        Me.propertyEditorInteractionModeComboBox.Name = "propertyEditorInteractionModeComboBox"
        Me.propertyEditorInteractionModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorInteractionModeComboBox.TabIndex = 2
        '
        'propertyEditorBorderStyleComboBox
        '
        Me.propertyEditorBorderStyleComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorBorderStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorBorderStyleComboBox.FormattingEnabled = True
        Me.propertyEditorBorderStyleComboBox.Location = New System.Drawing.Point(29, 111)
        Me.propertyEditorBorderStyleComboBox.Name = "propertyEditorBorderStyleComboBox"
        Me.propertyEditorBorderStyleComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorBorderStyleComboBox.TabIndex = 3
        '
        'propertyEditorBorderStyleLabel
        '
        Me.propertyEditorBorderStyleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorBorderStyleLabel.Location = New System.Drawing.Point(26, 85)
        Me.propertyEditorBorderStyleLabel.Name = "propertyEditorBorderStyleLabel"
        Me.propertyEditorBorderStyleLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorBorderStyleLabel.TabIndex = 8
        Me.propertyEditorBorderStyleLabel.Text = "Border Style:"
        '
        'propertyEditorRenderModeComboBox
        '
        Me.propertyEditorRenderModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorRenderModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorRenderModeComboBox.FormattingEnabled = True
        Me.propertyEditorRenderModeComboBox.Location = New System.Drawing.Point(29, 171)
        Me.propertyEditorRenderModeComboBox.Name = "propertyEditorRenderModeComboBox"
        Me.propertyEditorRenderModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorRenderModeComboBox.TabIndex = 4
        '
        'propertyEditorTextAlignLabel
        '
        Me.propertyEditorTextAlignLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorTextAlignLabel.Location = New System.Drawing.Point(272, 85)
        Me.propertyEditorTextAlignLabel.Name = "propertyEditorTextAlignLabel"
        Me.propertyEditorTextAlignLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorTextAlignLabel.TabIndex = 10
        Me.propertyEditorTextAlignLabel.Text = "Text Align:"
        '
        'propertyEditorDisplayModeComboBox
        '
        Me.propertyEditorDisplayModeComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorDisplayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorDisplayModeComboBox.FormattingEnabled = True
        Me.propertyEditorDisplayModeComboBox.Location = New System.Drawing.Point(275, 52)
        Me.propertyEditorDisplayModeComboBox.Name = "propertyEditorDisplayModeComboBox"
        Me.propertyEditorDisplayModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorDisplayModeComboBox.TabIndex = 5
        '
        'propertyEditorDisplayModeLabel
        '
        Me.propertyEditorDisplayModeLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorDisplayModeLabel.Location = New System.Drawing.Point(272, 26)
        Me.propertyEditorDisplayModeLabel.Name = "propertyEditorDisplayModeLabel"
        Me.propertyEditorDisplayModeLabel.Size = New System.Drawing.Size(100, 23)
        Me.propertyEditorDisplayModeLabel.TabIndex = 9
        Me.propertyEditorDisplayModeLabel.Text = "Display Mode:"
        '
        'propertyEditorTextAlignComboBox
        '
        Me.propertyEditorTextAlignComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.propertyEditorTextAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.propertyEditorTextAlignComboBox.FormattingEnabled = True
        Me.propertyEditorTextAlignComboBox.Location = New System.Drawing.Point(275, 111)
        Me.propertyEditorTextAlignComboBox.Name = "propertyEditorTextAlignComboBox"
        Me.propertyEditorTextAlignComboBox.Size = New System.Drawing.Size(121, 21)
        Me.propertyEditorTextAlignComboBox.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 527)
        Me.Controls.Add(Me.toolStripPropertyEditorSettingsGroupBox)
        Me.Controls.Add(Me.sampleInstrumentControlStrip)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Instrument Control Strip Features"
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sampleInstrumentControlStrip.ResumeLayout(False)
        Me.sampleInstrumentControlStrip.PerformLayout()
        Me.toolStripPropertyEditorSettingsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend sampleWaveformPlot As NationalInstruments.UI.WaveformPlot
    Friend sampleXAxis As NationalInstruments.UI.XAxis
    Friend sampleYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents sampleInstrumentControlStrip As NationalInstruments.UI.WindowsForms.InstrumentControlStrip
    Friend WithEvents interactionModeToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents interactionModeToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents zoomFactorToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents zoomFactorToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents showFocusToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents showFocusToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents captionToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents captionToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents borderToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents borderToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents plotAreaColorToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents plotAreaColorToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents fontToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents fontToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents xAxisLabelFormatToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents xAxisLabelFormatToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents xAxisMajorDivisionsToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents xAxisMajorDivisionsToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Friend WithEvents annotationsToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents annotationsToolStripPropertyEditor As NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor
    Private WithEvents toolStripPropertyEditorSettingsGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents propertyEditorInteractionModeLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorRenderModeLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorInteractionModeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorBorderStyleComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorBorderStyleLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorRenderModeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorTextAlignLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorDisplayModeComboBox As System.Windows.Forms.ComboBox
    Private WithEvents propertyEditorDisplayModeLabel As System.Windows.Forms.Label
    Private WithEvents propertyEditorTextAlignComboBox As System.Windows.Forms.ComboBox

End Class
