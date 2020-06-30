Imports System
Imports System.Text
Imports System.Windows.Forms

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        rangeFill = sampleGauge.RangeFills(0)
        rangeFillDistancePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Distance")
        rangeFillRangePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Range")
        rangeFillStylePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Style")
        rangeFillVisiblePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Visible")
        rangeFillWidthPropertyEditor.Source = New PropertyEditorSource(rangeFill, "Width")
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
    Friend WithEvents rangeFill As NationalInstruments.UI.ScaleRangeFill

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents rangeFillGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rangeFillWidthPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents rangeFillVisiblePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents rangeFillWidthLabel As System.Windows.Forms.Label
    Friend WithEvents rangeFillRangePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents rangeFillStyleLabel As System.Windows.Forms.Label
    Friend WithEvents rangeFillDistanceLabel As System.Windows.Forms.Label
    Friend WithEvents rangeFillDistancePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents rangeFillVisibleLabel As System.Windows.Forms.Label
    Friend WithEvents rangeFillStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents rangeFillRangeLabel As System.Windows.Forms.Label
    Friend WithEvents numericPointerTabControl As System.Windows.Forms.TabControl
    Friend WithEvents gaugeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents sampleGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents meterTabPage As System.Windows.Forms.TabPage
    Friend WithEvents sampleMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents slideTabPage As System.Windows.Forms.TabPage
    Friend WithEvents sampleSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents tankTabPage As System.Windows.Forms.TabPage
    Friend WithEvents sampleTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents knobTabPage As System.Windows.Forms.TabPage
    Friend WithEvents sampleKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents thermometerTabPage As System.Windows.Forms.TabPage
    Friend WithEvents sampleThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ScaleRangeFill1 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill2 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill3 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill4 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill5 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill6 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.rangeFillGroupBox = New System.Windows.Forms.GroupBox
        Me.rangeFillWidthPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.rangeFillVisiblePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.rangeFillWidthLabel = New System.Windows.Forms.Label
        Me.rangeFillRangePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.rangeFillStyleLabel = New System.Windows.Forms.Label
        Me.rangeFillDistanceLabel = New System.Windows.Forms.Label
        Me.rangeFillDistancePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.rangeFillVisibleLabel = New System.Windows.Forms.Label
        Me.rangeFillStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.rangeFillRangeLabel = New System.Windows.Forms.Label
        Me.numericPointerTabControl = New System.Windows.Forms.TabControl
        Me.gaugeTabPage = New System.Windows.Forms.TabPage
        Me.sampleGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.meterTabPage = New System.Windows.Forms.TabPage
        Me.sampleMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.slideTabPage = New System.Windows.Forms.TabPage
        Me.sampleSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.tankTabPage = New System.Windows.Forms.TabPage
        Me.sampleTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.knobTabPage = New System.Windows.Forms.TabPage
        Me.sampleKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.thermometerTabPage = New System.Windows.Forms.TabPage
        Me.sampleThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.rangeFillGroupBox.SuspendLayout()
        Me.numericPointerTabControl.SuspendLayout()
        Me.gaugeTabPage.SuspendLayout()
        CType(Me.sampleGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.meterTabPage.SuspendLayout()
        CType(Me.sampleMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.slideTabPage.SuspendLayout()
        CType(Me.sampleSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tankTabPage.SuspendLayout()
        CType(Me.sampleTank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.knobTabPage.SuspendLayout()
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.thermometerTabPage.SuspendLayout()
        CType(Me.sampleThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rangeFillGroupBox
        '
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillWidthPropertyEditor)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillVisiblePropertyEditor)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillWidthLabel)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillRangePropertyEditor)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillStyleLabel)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillDistanceLabel)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillDistancePropertyEditor)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillVisibleLabel)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillStylePropertyEditor)
        Me.rangeFillGroupBox.Controls.Add(Me.rangeFillRangeLabel)
        Me.rangeFillGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rangeFillGroupBox.Location = New System.Drawing.Point(8, 208)
        Me.rangeFillGroupBox.Name = "rangeFillGroupBox"
        Me.rangeFillGroupBox.Size = New System.Drawing.Size(304, 184)
        Me.rangeFillGroupBox.TabIndex = 21
        Me.rangeFillGroupBox.TabStop = False
        Me.rangeFillGroupBox.Text = "RangeFill properties"
        '
        'rangeFillWidthPropertyEditor
        '
        Me.rangeFillWidthPropertyEditor.Location = New System.Drawing.Point(168, 152)
        Me.rangeFillWidthPropertyEditor.Name = "rangeFillWidthPropertyEditor"
        Me.rangeFillWidthPropertyEditor.TabIndex = 6
        '
        'rangeFillVisiblePropertyEditor
        '
        Me.rangeFillVisiblePropertyEditor.Location = New System.Drawing.Point(168, 120)
        Me.rangeFillVisiblePropertyEditor.Name = "rangeFillVisiblePropertyEditor"
        Me.rangeFillVisiblePropertyEditor.TabIndex = 5
        '
        'rangeFillWidthLabel
        '
        Me.rangeFillWidthLabel.Location = New System.Drawing.Point(8, 152)
        Me.rangeFillWidthLabel.Name = "rangeFillWidthLabel"
        Me.rangeFillWidthLabel.Size = New System.Drawing.Size(120, 20)
        Me.rangeFillWidthLabel.TabIndex = 18
        Me.rangeFillWidthLabel.Text = "Width"
        '
        'rangeFillRangePropertyEditor
        '
        Me.rangeFillRangePropertyEditor.Location = New System.Drawing.Point(168, 56)
        Me.rangeFillRangePropertyEditor.Name = "rangeFillRangePropertyEditor"
        Me.rangeFillRangePropertyEditor.TabIndex = 3
        '
        'rangeFillStyleLabel
        '
        Me.rangeFillStyleLabel.Location = New System.Drawing.Point(8, 88)
        Me.rangeFillStyleLabel.Name = "rangeFillStyleLabel"
        Me.rangeFillStyleLabel.Size = New System.Drawing.Size(120, 20)
        Me.rangeFillStyleLabel.TabIndex = 16
        Me.rangeFillStyleLabel.Text = "Style"
        '
        'rangeFillDistanceLabel
        '
        Me.rangeFillDistanceLabel.Location = New System.Drawing.Point(8, 24)
        Me.rangeFillDistanceLabel.Name = "rangeFillDistanceLabel"
        Me.rangeFillDistanceLabel.Size = New System.Drawing.Size(120, 20)
        Me.rangeFillDistanceLabel.TabIndex = 14
        Me.rangeFillDistanceLabel.Text = "Distance"
        '
        'rangeFillDistancePropertyEditor
        '
        Me.rangeFillDistancePropertyEditor.Location = New System.Drawing.Point(168, 25)
        Me.rangeFillDistancePropertyEditor.Name = "rangeFillDistancePropertyEditor"
        Me.rangeFillDistancePropertyEditor.TabIndex = 2
        '
        'rangeFillVisibleLabel
        '
        Me.rangeFillVisibleLabel.Location = New System.Drawing.Point(8, 120)
        Me.rangeFillVisibleLabel.Name = "rangeFillVisibleLabel"
        Me.rangeFillVisibleLabel.Size = New System.Drawing.Size(120, 20)
        Me.rangeFillVisibleLabel.TabIndex = 17
        Me.rangeFillVisibleLabel.Text = "Visible"
        '
        'rangeFillStylePropertyEditor
        '
        Me.rangeFillStylePropertyEditor.Location = New System.Drawing.Point(168, 88)
        Me.rangeFillStylePropertyEditor.Name = "rangeFillStylePropertyEditor"
        Me.rangeFillStylePropertyEditor.TabIndex = 4
        '
        'rangeFillRangeLabel
        '
        Me.rangeFillRangeLabel.Location = New System.Drawing.Point(8, 56)
        Me.rangeFillRangeLabel.Name = "rangeFillRangeLabel"
        Me.rangeFillRangeLabel.Size = New System.Drawing.Size(120, 20)
        Me.rangeFillRangeLabel.TabIndex = 15
        Me.rangeFillRangeLabel.Text = "Range"
        '
        'numericPointerTabControl
        '
        Me.numericPointerTabControl.Controls.Add(Me.gaugeTabPage)
        Me.numericPointerTabControl.Controls.Add(Me.meterTabPage)
        Me.numericPointerTabControl.Controls.Add(Me.knobTabPage)
        Me.numericPointerTabControl.Controls.Add(Me.slideTabPage)
        Me.numericPointerTabControl.Controls.Add(Me.tankTabPage)
        Me.numericPointerTabControl.Controls.Add(Me.thermometerTabPage)
        Me.numericPointerTabControl.Dock = System.Windows.Forms.DockStyle.Top
        Me.numericPointerTabControl.Location = New System.Drawing.Point(0, 0)
        Me.numericPointerTabControl.Name = "numericPointerTabControl"
        Me.numericPointerTabControl.SelectedIndex = 0
        Me.numericPointerTabControl.Size = New System.Drawing.Size(320, 200)
        Me.numericPointerTabControl.TabIndex = 22
        '
        'gaugeTabPage
        '
        Me.gaugeTabPage.Controls.Add(Me.sampleGauge)
        Me.gaugeTabPage.Location = New System.Drawing.Point(4, 22)
        Me.gaugeTabPage.Name = "gaugeTabPage"
        Me.gaugeTabPage.Size = New System.Drawing.Size(312, 174)
        Me.gaugeTabPage.TabIndex = 2
        Me.gaugeTabPage.Text = "Gauge"
        '
        'sampleGauge
        '
        Me.sampleGauge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleGauge.InteractionMode = CType((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.RadialNumericPointerInteractionModes)
        Me.sampleGauge.Location = New System.Drawing.Point(0, 0)
        Me.sampleGauge.Name = "sampleGauge"
        ScaleRangeFill1.Range = New NationalInstruments.UI.Range(0, 2.5)
        Me.sampleGauge.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill1})
        Me.sampleGauge.Size = New System.Drawing.Size(312, 174)
        Me.sampleGauge.TabIndex = 0
        '
        'meterTabPage
        '
        Me.meterTabPage.Controls.Add(Me.sampleMeter)
        Me.meterTabPage.Location = New System.Drawing.Point(4, 22)
        Me.meterTabPage.Name = "meterTabPage"
        Me.meterTabPage.Size = New System.Drawing.Size(312, 174)
        Me.meterTabPage.TabIndex = 1
        Me.meterTabPage.Text = "Meter"
        Me.meterTabPage.Visible = False
        '
        'sampleMeter
        '
        Me.sampleMeter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleMeter.InteractionMode = CType((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.RadialNumericPointerInteractionModes)
        Me.sampleMeter.Location = New System.Drawing.Point(0, 0)
        Me.sampleMeter.Name = "sampleMeter"
        ScaleRangeFill2.Range = New NationalInstruments.UI.Range(0, 2.5)
        Me.sampleMeter.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill2})
        Me.sampleMeter.Size = New System.Drawing.Size(312, 174)
        Me.sampleMeter.TabIndex = 0
        '
        'slideTabPage
        '
        Me.slideTabPage.Controls.Add(Me.sampleSlide)
        Me.slideTabPage.Location = New System.Drawing.Point(4, 22)
        Me.slideTabPage.Name = "slideTabPage"
        Me.slideTabPage.Size = New System.Drawing.Size(312, 174)
        Me.slideTabPage.TabIndex = 3
        Me.slideTabPage.Text = "Slide"
        Me.slideTabPage.Visible = False
        '
        'sampleSlide
        '
        Me.sampleSlide.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleSlide.Location = New System.Drawing.Point(0, 0)
        Me.sampleSlide.Name = "sampleSlide"
        ScaleRangeFill3.Range = New NationalInstruments.UI.Range(0, 2.5)
        Me.sampleSlide.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill3})
        Me.sampleSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.sampleSlide.Size = New System.Drawing.Size(312, 174)
        Me.sampleSlide.TabIndex = 0
        '
        'tankTabPage
        '
        Me.tankTabPage.Controls.Add(Me.sampleTank)
        Me.tankTabPage.Location = New System.Drawing.Point(4, 22)
        Me.tankTabPage.Name = "tankTabPage"
        Me.tankTabPage.Size = New System.Drawing.Size(312, 174)
        Me.tankTabPage.TabIndex = 4
        Me.tankTabPage.Text = "Tank"
        Me.tankTabPage.Visible = False
        '
        'sampleTank
        '
        Me.sampleTank.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleTank.InteractionMode = CType((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.LinearNumericPointerInteractionModes)
        Me.sampleTank.Location = New System.Drawing.Point(0, 0)
        Me.sampleTank.Name = "sampleTank"
        ScaleRangeFill4.Range = New NationalInstruments.UI.Range(0, 2.5)
        Me.sampleTank.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill4})
        Me.sampleTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.sampleTank.Size = New System.Drawing.Size(312, 174)
        Me.sampleTank.TabIndex = 0
        '
        'knobTabPage
        '
        Me.knobTabPage.Controls.Add(Me.sampleKnob)
        Me.knobTabPage.Location = New System.Drawing.Point(4, 22)
        Me.knobTabPage.Name = "knobTabPage"
        Me.knobTabPage.Size = New System.Drawing.Size(312, 174)
        Me.knobTabPage.TabIndex = 0
        Me.knobTabPage.Text = "Knob"
        Me.knobTabPage.Visible = False
        '
        'sampleKnob
        '
        Me.sampleKnob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleKnob.Location = New System.Drawing.Point(0, 0)
        Me.sampleKnob.Name = "sampleKnob"
        ScaleRangeFill5.Range = New NationalInstruments.UI.Range(0, 2.5)
        Me.sampleKnob.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill5})
        Me.sampleKnob.Size = New System.Drawing.Size(312, 174)
        Me.sampleKnob.TabIndex = 13
        '
        'thermometerTabPage
        '
        Me.thermometerTabPage.Controls.Add(Me.sampleThermometer)
        Me.thermometerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.thermometerTabPage.Name = "thermometerTabPage"
        Me.thermometerTabPage.Size = New System.Drawing.Size(312, 174)
        Me.thermometerTabPage.TabIndex = 5
        Me.thermometerTabPage.Text = "Thermometer"
        Me.thermometerTabPage.Visible = False
        '
        'sampleThermometer
        '
        Me.sampleThermometer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleThermometer.InteractionMode = CType((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.LinearNumericPointerInteractionModes)
        Me.sampleThermometer.Location = New System.Drawing.Point(0, 0)
        Me.sampleThermometer.Name = "sampleThermometer"
        ScaleRangeFill6.Range = New NationalInstruments.UI.Range(0, 25)
        Me.sampleThermometer.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill6})
        Me.sampleThermometer.Size = New System.Drawing.Size(312, 174)
        Me.sampleThermometer.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(320, 398)
        Me.Controls.Add(Me.rangeFillGroupBox)
        Me.Controls.Add(Me.numericPointerTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Scale Range Fills"
        Me.rangeFillGroupBox.ResumeLayout(False)
        Me.numericPointerTabControl.ResumeLayout(False)
        Me.gaugeTabPage.ResumeLayout(False)
        CType(Me.sampleGauge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.meterTabPage.ResumeLayout(False)
        CType(Me.sampleMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slideTabPage.ResumeLayout(False)
        CType(Me.sampleSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tankTabPage.ResumeLayout(False)
        CType(Me.sampleTank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.knobTabPage.ResumeLayout(False)
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.thermometerTabPage.ResumeLayout(False)
        CType(Me.sampleThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <System.STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub numericPointerTabControl_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numericPointerTabControl.SelectedIndexChanged
        Select Case numericPointerTabControl.SelectedTab.Text
            Case "Gauge"
                rangeFill = sampleGauge.RangeFills(0)
            Case "Meter"
                rangeFill = sampleMeter.RangeFills(0)
            Case "Knob"
                rangeFill = sampleKnob.RangeFills(0)
            Case "Slide"
                rangeFill = sampleSlide.RangeFills(0)
            Case "Tank"
                rangeFill = sampleTank.RangeFills(0)
            Case "Thermometer"
                rangeFill = sampleThermometer.RangeFills(0)
            Case ""
                Exit Sub
        End Select

        rangeFillDistancePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Distance")
        rangeFillRangePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Range")
        rangeFillStylePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Style")
        rangeFillVisiblePropertyEditor.Source = New PropertyEditorSource(rangeFill, "Visible")
        rangeFillWidthPropertyEditor.Source = New PropertyEditorSource(rangeFill, "Width")
    End Sub
End Class
