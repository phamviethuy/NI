Public Class MainForm
    Inherits System.Windows.Forms.Form


#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Application.EnableVisualStyles()
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
    Friend WithEvents stylesTabControl As System.Windows.Forms.TabControl
    Friend WithEvents knobTabPage As System.Windows.Forms.TabPage
    Friend WithEvents raisedWithThumb3DNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithThumbNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithThinNeedle3DNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatWithThinNeedleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithThumb3DKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents raisedWithThumbKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents raisedWithThinNeedle3DKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents raisedWithThinNeedleKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents flatWithThinNeedleKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents meterTabPage As System.Windows.Forms.TabPage
    Friend WithEvents flatWithThinNeedleMeterNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatWithThickNeedleMeterNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithThinNeedleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithThickNeedleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatWithThinNeedleMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents raisedWithThinNeedleMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents raisedWithThickNeedleMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents flatWithThickNeedleMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents gaugeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents sunkenWithThickNeedleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sunkenWithThinNeedleGaugeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sunkenWithThinNeedle3DNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sunkenWithThickNeedle3DNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatWithThinNeedleGaugeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatWithThickNeedleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sunkenWithThinNeedle3DGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents sunkenWithThinNeedleGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents sunkenWithThickNeedle3DGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents sunkenWithThickNeedleGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents flatWithThinNeedleGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents flatWithThickNeedleGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents tankTabPage As System.Windows.Forms.TabPage
    Friend WithEvents raised3DHorizontalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedHorizontalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raised3dVerticalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatVerticalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatHorizontalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedVerticalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raised3DHorizontalTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents raisedHorizontalTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents flatHorizontalTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents raised3DVerticalTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents raisedVerticalTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents flatVerticalTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents slideTabPage As System.Windows.Forms.TabPage
    Friend WithEvents raisedWithRoundedGrip3DHorizontalSlideNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithRoundedGripHorizontalSlideNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sunkenWithGripHorizontalSlideNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithRoundedGrip3DVerticalSlideNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithRoundedGripVerticalSlideNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sunkenWithGripVerticalSlideNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedWithRoundedGrip3DHorizontalSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents raisedWithRoundedGripHorizontalSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents sunkenWithGripHorizontalSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents raisedWithRoundedGrip3DVerticalSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents raisedWithRoundedGripVerticalSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents sunkenWithGripVerticalSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents thermometerTabPage As System.Windows.Forms.TabPage
    Friend WithEvents flatHorizontalThermometerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedVerticalThermometerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raised3DHorizontalThermometerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raisedHorizontalThermometerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raised3DVerticalThermometerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents flatVerticalThermometerNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents raised3DHorizontalThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents raisedHorizontalThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents flatHorizontalThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents raised3DVerticalThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents raisedVerticalThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents flatVerticalThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents sampleTimer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ScaleCustomDivision1 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision2 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision3 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision4 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision5 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleRangeFill1 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleCustomDivision6 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision7 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleRangeFill2 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleCustomDivision8 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleRangeFill3 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleCustomDivision9 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleRangeFill4 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill5 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.stylesTabControl = New System.Windows.Forms.TabControl
        Me.knobTabPage = New System.Windows.Forms.TabPage
        Me.raisedWithThumb3DNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithThumb3DKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.raisedWithThumbNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithThumbKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.raisedWithThinNeedle3DNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithThinNeedle3DKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.flatWithThinNeedleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatWithThinNeedleKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.raisedWithThinNeedleKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.meterTabPage = New System.Windows.Forms.TabPage
        Me.flatWithThinNeedleMeterNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatWithThinNeedleMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.flatWithThickNeedleMeterNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatWithThickNeedleMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.raisedWithThinNeedleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithThinNeedleMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.raisedWithThickNeedleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithThickNeedleMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.gaugeTabPage = New System.Windows.Forms.TabPage
        Me.sunkenWithThickNeedleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sunkenWithThickNeedleGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.sunkenWithThinNeedleGaugeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sunkenWithThinNeedleGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.sunkenWithThinNeedle3DNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sunkenWithThinNeedle3DGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.sunkenWithThickNeedle3DNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sunkenWithThickNeedle3DGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.flatWithThinNeedleGaugeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatWithThinNeedleGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.flatWithThickNeedleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatWithThickNeedleGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.tankTabPage = New System.Windows.Forms.TabPage
        Me.raised3DHorizontalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raised3DHorizontalTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.raisedHorizontalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedHorizontalTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.raised3dVerticalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raised3DVerticalTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.flatVerticalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatVerticalTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.flatHorizontalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatHorizontalTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.raisedVerticalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedVerticalTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.slideTabPage = New System.Windows.Forms.TabPage
        Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithRoundedGrip3DHorizontalSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.raisedWithRoundedGripHorizontalSlideNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithRoundedGripHorizontalSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.sunkenWithGripHorizontalSlideNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sunkenWithGripHorizontalSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithRoundedGrip3DVerticalSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.raisedWithRoundedGripVerticalSlideNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedWithRoundedGripVerticalSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.sunkenWithGripVerticalSlideNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sunkenWithGripVerticalSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.thermometerTabPage = New System.Windows.Forms.TabPage
        Me.flatHorizontalThermometerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatHorizontalThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.raisedVerticalThermometerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedVerticalThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.raised3DHorizontalThermometerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raised3DHorizontalThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.raisedHorizontalThermometerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raisedHorizontalThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.raised3DVerticalThermometerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.raised3DVerticalThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.flatVerticalThermometerNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.flatVerticalThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.sampleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.stylesTabControl.SuspendLayout()
        Me.knobTabPage.SuspendLayout()
        CType(Me.raisedWithThumb3DNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThumb3DKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThumbNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThumbKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThinNeedle3DNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThinNeedle3DKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThinNeedleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThinNeedleKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThinNeedleKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.meterTabPage.SuspendLayout()
        CType(Me.flatWithThinNeedleMeterNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThinNeedleMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThickNeedleMeterNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThickNeedleMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThinNeedleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThinNeedleMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThickNeedleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithThickNeedleMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gaugeTabPage.SuspendLayout()
        CType(Me.sunkenWithThickNeedleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithThickNeedleGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithThinNeedleGaugeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithThinNeedleGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithThinNeedle3DNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithThinNeedle3DGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithThickNeedle3DNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithThickNeedle3DGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThinNeedleGaugeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThinNeedleGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThickNeedleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatWithThickNeedleGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tankTabPage.SuspendLayout()
        CType(Me.raised3DHorizontalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raised3DHorizontalTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedHorizontalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedHorizontalTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raised3dVerticalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raised3DVerticalTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatVerticalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatVerticalTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatHorizontalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatHorizontalTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedVerticalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedVerticalTank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.slideTabPage.SuspendLayout()
        CType(Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithRoundedGrip3DHorizontalSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithRoundedGripHorizontalSlideNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithRoundedGripHorizontalSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithGripHorizontalSlideNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithGripHorizontalSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithRoundedGrip3DVerticalSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithRoundedGripVerticalSlideNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedWithRoundedGripVerticalSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithGripVerticalSlideNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sunkenWithGripVerticalSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.thermometerTabPage.SuspendLayout()
        CType(Me.flatHorizontalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatHorizontalThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedVerticalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedVerticalThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raised3DHorizontalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raised3DHorizontalThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedHorizontalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raisedHorizontalThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raised3DVerticalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.raised3DVerticalThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatVerticalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.flatVerticalThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stylesTabControl
        '
        Me.stylesTabControl.Controls.Add(Me.knobTabPage)
        Me.stylesTabControl.Controls.Add(Me.meterTabPage)
        Me.stylesTabControl.Controls.Add(Me.gaugeTabPage)
        Me.stylesTabControl.Controls.Add(Me.tankTabPage)
        Me.stylesTabControl.Controls.Add(Me.slideTabPage)
        Me.stylesTabControl.Controls.Add(Me.thermometerTabPage)
        Me.stylesTabControl.Location = New System.Drawing.Point(-4, -1)
        Me.stylesTabControl.Name = "stylesTabControl"
        Me.stylesTabControl.SelectedIndex = 0
        Me.stylesTabControl.Size = New System.Drawing.Size(632, 472)
        Me.stylesTabControl.TabIndex = 1
        '
        'knobTabPage
        '
        Me.knobTabPage.Controls.Add(Me.raisedWithThumb3DNumericEdit)
        Me.knobTabPage.Controls.Add(Me.raisedWithThumbNumericEdit)
        Me.knobTabPage.Controls.Add(Me.raisedWithThinNeedle3DNumericEdit)
        Me.knobTabPage.Controls.Add(Me.flatWithThinNeedleNumericEdit)
        Me.knobTabPage.Controls.Add(Me.raisedWithThumb3DKnob)
        Me.knobTabPage.Controls.Add(Me.raisedWithThumbKnob)
        Me.knobTabPage.Controls.Add(Me.raisedWithThinNeedle3DKnob)
        Me.knobTabPage.Controls.Add(Me.raisedWithThinNeedleKnob)
        Me.knobTabPage.Controls.Add(Me.flatWithThinNeedleKnob)
        Me.knobTabPage.Location = New System.Drawing.Point(4, 22)
        Me.knobTabPage.Name = "knobTabPage"
        Me.knobTabPage.Size = New System.Drawing.Size(624, 446)
        Me.knobTabPage.TabIndex = 0
        Me.knobTabPage.Text = "Knob"
        '
        'raisedWithThumb3DNumericEdit
        '
        Me.raisedWithThumb3DNumericEdit.Location = New System.Drawing.Point(216, 408)
        Me.raisedWithThumb3DNumericEdit.Name = "raisedWithThumb3DNumericEdit"
        Me.raisedWithThumb3DNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithThumb3DNumericEdit.Source = Me.raisedWithThumb3DKnob
        Me.raisedWithThumb3DNumericEdit.TabIndex = 9
        Me.raisedWithThumb3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithThumb3DKnob
        '
        Me.raisedWithThumb3DKnob.AutoDivisionSpacing = False
        Me.raisedWithThumb3DKnob.Caption = "RaisedWithThumb3D"
        Me.raisedWithThumb3DKnob.Location = New System.Drawing.Point(184, 232)
        Me.raisedWithThumb3DKnob.Name = "raisedWithThumb3DKnob"
        Me.raisedWithThumb3DKnob.Range = New NationalInstruments.UI.Range(0, 500)
        Me.raisedWithThumb3DKnob.Size = New System.Drawing.Size(176, 176)
        Me.raisedWithThumb3DKnob.TabIndex = 4
        Me.raisedWithThumb3DKnob.Value = 0.001
        '
        'raisedWithThumbNumericEdit
        '
        Me.raisedWithThumbNumericEdit.Location = New System.Drawing.Point(32, 408)
        Me.raisedWithThumbNumericEdit.Name = "raisedWithThumbNumericEdit"
        Me.raisedWithThumbNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithThumbNumericEdit.Source = Me.raisedWithThumbKnob
        Me.raisedWithThumbNumericEdit.TabIndex = 8
        Me.raisedWithThumbNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithThumbKnob
        '
        Me.raisedWithThumbKnob.Caption = "RaisedWithThumb"
        Me.raisedWithThumbKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThumb
        Me.raisedWithThumbKnob.Location = New System.Drawing.Point(0, 232)
        Me.raisedWithThumbKnob.Name = "raisedWithThumbKnob"
        Me.raisedWithThumbKnob.PointerColor = System.Drawing.SystemColors.ControlDark
        Me.raisedWithThumbKnob.Range = New NationalInstruments.UI.Range(0, 100)
        Me.raisedWithThumbKnob.ScaleArc = New NationalInstruments.UI.Arc(121.0!, 299.0!)
        Me.raisedWithThumbKnob.Size = New System.Drawing.Size(176, 176)
        Me.raisedWithThumbKnob.TabIndex = 3
        '
        'raisedWithThinNeedle3DNumericEdit
        '
        Me.raisedWithThinNeedle3DNumericEdit.Location = New System.Drawing.Point(448, 192)
        Me.raisedWithThinNeedle3DNumericEdit.Name = "raisedWithThinNeedle3DNumericEdit"
        Me.raisedWithThinNeedle3DNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithThinNeedle3DNumericEdit.Source = Me.raisedWithThinNeedle3DKnob
        Me.raisedWithThinNeedle3DNumericEdit.TabIndex = 7
        Me.raisedWithThinNeedle3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithThinNeedle3DKnob
        '
        Me.raisedWithThinNeedle3DKnob.AutoDivisionSpacing = False
        Me.raisedWithThinNeedle3DKnob.Caption = "RaisedWithThinNeedle3D"
        Me.raisedWithThinNeedle3DKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle3D
        Me.raisedWithThinNeedle3DKnob.Location = New System.Drawing.Point(384, 23)
        Me.raisedWithThinNeedle3DKnob.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S'V'")
        Me.raisedWithThinNeedle3DKnob.Name = "raisedWithThinNeedle3DKnob"
        Me.raisedWithThinNeedle3DKnob.PointerColor = System.Drawing.SystemColors.WindowText
        Me.raisedWithThinNeedle3DKnob.Range = New NationalInstruments.UI.Range(0, 10000)
        Me.raisedWithThinNeedle3DKnob.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.raisedWithThinNeedle3DKnob.Size = New System.Drawing.Size(240, 168)
        Me.raisedWithThinNeedle3DKnob.TabIndex = 2
        '
        'flatWithThinNeedleNumericEdit
        '
        Me.flatWithThinNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.flatWithThinNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.flatWithThinNeedleNumericEdit.Location = New System.Drawing.Point(40, 192)
        Me.flatWithThinNeedleNumericEdit.Name = "flatWithThinNeedleNumericEdit"
        Me.flatWithThinNeedleNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatWithThinNeedleNumericEdit.Source = Me.flatWithThinNeedleKnob
        Me.flatWithThinNeedleNumericEdit.TabIndex = 5
        Me.flatWithThinNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatWithThinNeedleKnob
        '
        Me.flatWithThinNeedleKnob.Caption = "FlatWithThinNeedle"
        Me.flatWithThinNeedleKnob.DialColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.flatWithThinNeedleKnob.InteractionMode = NationalInstruments.UI.RadialNumericPointerInteractionModes.Indicator
        Me.flatWithThinNeedleKnob.KnobStyle = NationalInstruments.UI.KnobStyle.FlatWithThinNeedle
        Me.flatWithThinNeedleKnob.Location = New System.Drawing.Point(0, 23)
        Me.flatWithThinNeedleKnob.Name = "flatWithThinNeedleKnob"
        Me.flatWithThinNeedleKnob.PointerColor = System.Drawing.SystemColors.WindowText
        Me.flatWithThinNeedleKnob.Size = New System.Drawing.Size(176, 160)
        Me.flatWithThinNeedleKnob.TabIndex = 0
        '
        'raisedWithThinNeedleKnob
        '
        Me.raisedWithThinNeedleKnob.Caption = "RaisedWithThinNeedle"
        Me.raisedWithThinNeedleKnob.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions
        ScaleCustomDivision1.LineWidth = 2.0!
        ScaleCustomDivision1.Text = "Start"
        ScaleCustomDivision1.TickLength = 7.0!
        ScaleCustomDivision2.LineWidth = 2.0!
        ScaleCustomDivision2.Text = "Acquire"
        ScaleCustomDivision2.TickLength = 7.0!
        ScaleCustomDivision2.Value = 2.5
        ScaleCustomDivision3.LineWidth = 2.0!
        ScaleCustomDivision3.Text = "Stop"
        ScaleCustomDivision3.TickLength = 7.0!
        ScaleCustomDivision3.Value = 5
        ScaleCustomDivision4.LineWidth = 2.0!
        ScaleCustomDivision4.Text = "Analyze"
        ScaleCustomDivision4.TickLength = 7.0!
        ScaleCustomDivision4.Value = 7.5
        ScaleCustomDivision5.LineWidth = 2.0!
        ScaleCustomDivision5.Text = "Display"
        ScaleCustomDivision5.TickLength = 7.0!
        ScaleCustomDivision5.Value = 10
        Me.raisedWithThinNeedleKnob.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision1, ScaleCustomDivision2, ScaleCustomDivision3, ScaleCustomDivision4, ScaleCustomDivision5})
        Me.raisedWithThinNeedleKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle
        Me.raisedWithThinNeedleKnob.Location = New System.Drawing.Point(184, 23)
        Me.raisedWithThinNeedleKnob.MajorDivisions.LabelVisible = False
        Me.raisedWithThinNeedleKnob.MajorDivisions.TickVisible = False
        Me.raisedWithThinNeedleKnob.MinorDivisions.TickVisible = False
        Me.raisedWithThinNeedleKnob.Name = "raisedWithThinNeedleKnob"
        Me.raisedWithThinNeedleKnob.PointerColor = System.Drawing.SystemColors.WindowText
        ScaleRangeFill1.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateGradientStyle(System.Drawing.Color.Green, System.Drawing.Color.Yellow, 0.5)
        Me.raisedWithThinNeedleKnob.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill1})
        Me.raisedWithThinNeedleKnob.Size = New System.Drawing.Size(192, 168)
        Me.raisedWithThinNeedleKnob.TabIndex = 1
        '
        'meterTabPage
        '
        Me.meterTabPage.Controls.Add(Me.flatWithThinNeedleMeterNumericEdit)
        Me.meterTabPage.Controls.Add(Me.flatWithThickNeedleMeterNumericEdit)
        Me.meterTabPage.Controls.Add(Me.raisedWithThinNeedleNumericEdit)
        Me.meterTabPage.Controls.Add(Me.raisedWithThickNeedleNumericEdit)
        Me.meterTabPage.Controls.Add(Me.flatWithThinNeedleMeter)
        Me.meterTabPage.Controls.Add(Me.raisedWithThinNeedleMeter)
        Me.meterTabPage.Controls.Add(Me.raisedWithThickNeedleMeter)
        Me.meterTabPage.Controls.Add(Me.flatWithThickNeedleMeter)
        Me.meterTabPage.Location = New System.Drawing.Point(4, 22)
        Me.meterTabPage.Name = "meterTabPage"
        Me.meterTabPage.Size = New System.Drawing.Size(624, 446)
        Me.meterTabPage.TabIndex = 1
        Me.meterTabPage.Text = "Meter"
        Me.meterTabPage.Visible = False
        '
        'flatWithThinNeedleMeterNumericEdit
        '
        Me.flatWithThinNeedleMeterNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.flatWithThinNeedleMeterNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.flatWithThinNeedleMeterNumericEdit.Location = New System.Drawing.Point(440, 400)
        Me.flatWithThinNeedleMeterNumericEdit.Name = "flatWithThinNeedleMeterNumericEdit"
        Me.flatWithThinNeedleMeterNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatWithThinNeedleMeterNumericEdit.Source = Me.flatWithThinNeedleMeter
        Me.flatWithThinNeedleMeterNumericEdit.TabIndex = 9
        Me.flatWithThinNeedleMeterNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatWithThinNeedleMeter
        '
        Me.flatWithThinNeedleMeter.AutoDivisionSpacing = False
        Me.flatWithThinNeedleMeter.Caption = "FlatWithThinNeedle"
        Me.flatWithThinNeedleMeter.Location = New System.Drawing.Point(368, 232)
        Me.flatWithThinNeedleMeter.MeterStyle = NationalInstruments.UI.MeterStyle.FlatWithThinNeedle
        Me.flatWithThinNeedleMeter.Name = "flatWithThinNeedleMeter"
        Me.flatWithThinNeedleMeter.PointerColor = System.Drawing.SystemColors.InactiveCaption
        Me.flatWithThinNeedleMeter.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.flatWithThinNeedleMeter.ScaleArc = New NationalInstruments.UI.Arc(225.0!, 90.0!)
        Me.flatWithThinNeedleMeter.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.flatWithThinNeedleMeter.Size = New System.Drawing.Size(240, 168)
        Me.flatWithThinNeedleMeter.TabIndex = 1
        '
        'flatWithThickNeedleMeterNumericEdit
        '
        Me.flatWithThickNeedleMeterNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.flatWithThickNeedleMeterNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.flatWithThickNeedleMeterNumericEdit.Location = New System.Drawing.Point(440, 187)
        Me.flatWithThickNeedleMeterNumericEdit.Name = "flatWithThickNeedleMeterNumericEdit"
        Me.flatWithThickNeedleMeterNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatWithThickNeedleMeterNumericEdit.Source = Me.flatWithThickNeedleMeter
        Me.flatWithThickNeedleMeterNumericEdit.TabIndex = 8
        Me.flatWithThickNeedleMeterNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatWithThickNeedleMeter
        '
        Me.flatWithThickNeedleMeter.Caption = "FlatWithThickNeedle"
        Me.flatWithThickNeedleMeter.Location = New System.Drawing.Point(368, 23)
        Me.flatWithThickNeedleMeter.MeterStyle = NationalInstruments.UI.MeterStyle.FlatWithThickNeedle
        Me.flatWithThickNeedleMeter.Name = "flatWithThickNeedleMeter"
        Me.flatWithThickNeedleMeter.ScaleBaseLineColor = System.Drawing.SystemColors.Highlight
        Me.flatWithThickNeedleMeter.Size = New System.Drawing.Size(232, 168)
        Me.flatWithThickNeedleMeter.SpindleColor = System.Drawing.SystemColors.Desktop
        Me.flatWithThickNeedleMeter.TabIndex = 0
        '
        'raisedWithThinNeedleNumericEdit
        '
        Me.raisedWithThinNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.raisedWithThinNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.raisedWithThinNeedleNumericEdit.Location = New System.Drawing.Point(224, 312)
        Me.raisedWithThinNeedleNumericEdit.Name = "raisedWithThinNeedleNumericEdit"
        Me.raisedWithThinNeedleNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithThinNeedleNumericEdit.Source = Me.raisedWithThinNeedleMeter
        Me.raisedWithThinNeedleNumericEdit.TabIndex = 7
        Me.raisedWithThinNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithThinNeedleMeter
        '
        Me.raisedWithThinNeedleMeter.AutoDivisionSpacing = False
        Me.raisedWithThinNeedleMeter.Caption = "RaisedWithThinNeedle"
        Me.raisedWithThinNeedleMeter.Location = New System.Drawing.Point(208, 23)
        Me.raisedWithThinNeedleMeter.MajorDivisions.Interval = 50
        Me.raisedWithThinNeedleMeter.MeterStyle = NationalInstruments.UI.MeterStyle.RaisedWithThinNeedle
        Me.raisedWithThinNeedleMeter.MinorDivisions.Interval = 25
        Me.raisedWithThinNeedleMeter.Name = "raisedWithThinNeedleMeter"
        Me.raisedWithThinNeedleMeter.Range = New NationalInstruments.UI.Range(-100, 100)
        Me.raisedWithThinNeedleMeter.ScaleArc = New NationalInstruments.UI.Arc(315.0!, 90.0!)
        Me.raisedWithThinNeedleMeter.Size = New System.Drawing.Size(136, 296)
        Me.raisedWithThinNeedleMeter.SpindleColor = System.Drawing.SystemColors.ActiveCaption
        Me.raisedWithThinNeedleMeter.TabIndex = 3
        '
        'raisedWithThickNeedleNumericEdit
        '
        Me.raisedWithThickNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.raisedWithThickNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.raisedWithThickNeedleNumericEdit.Location = New System.Drawing.Point(56, 312)
        Me.raisedWithThickNeedleNumericEdit.Name = "raisedWithThickNeedleNumericEdit"
        Me.raisedWithThickNeedleNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithThickNeedleNumericEdit.Source = Me.raisedWithThickNeedleMeter
        Me.raisedWithThickNeedleNumericEdit.TabIndex = 6
        Me.raisedWithThickNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithThickNeedleMeter
        '
        Me.raisedWithThickNeedleMeter.AutoDivisionSpacing = False
        Me.raisedWithThickNeedleMeter.Caption = "RaisedWithThickNeedle"
        ScaleCustomDivision6.LabelFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScaleCustomDivision6.LabelForeColor = System.Drawing.Color.Red
        ScaleCustomDivision6.LineWidth = 2.0!
        ScaleCustomDivision6.Text = "HOT"
        ScaleCustomDivision6.TickLength = 10.0!
        ScaleCustomDivision6.Value = 90
        ScaleCustomDivision7.LabelFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScaleCustomDivision7.LabelForeColor = System.Drawing.Color.Blue
        ScaleCustomDivision7.LineWidth = 2.0!
        ScaleCustomDivision7.Text = "COLD"
        ScaleCustomDivision7.TickColor = System.Drawing.Color.Blue
        ScaleCustomDivision7.TickLength = 10.0!
        ScaleCustomDivision7.Value = 10
        Me.raisedWithThickNeedleMeter.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision6, ScaleCustomDivision7})
        Me.raisedWithThickNeedleMeter.Location = New System.Drawing.Point(24, 23)
        Me.raisedWithThickNeedleMeter.Name = "raisedWithThickNeedleMeter"
        Me.raisedWithThickNeedleMeter.Range = New NationalInstruments.UI.Range(0, 100)
        ScaleRangeFill2.Range = New NationalInstruments.UI.Range(10, 90)
        ScaleRangeFill2.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateGradientStyle(System.Drawing.Color.Blue, System.Drawing.Color.Red, 0.5)
        Me.raisedWithThickNeedleMeter.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill2})
        Me.raisedWithThickNeedleMeter.ScaleArc = New NationalInstruments.UI.Arc(225.0!, -90.0!)
        Me.raisedWithThickNeedleMeter.Size = New System.Drawing.Size(168, 288)
        Me.raisedWithThickNeedleMeter.TabIndex = 2
        '
        'gaugeTabPage
        '
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThickNeedleNumericEdit)
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThinNeedleGaugeNumericEdit)
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThinNeedle3DNumericEdit)
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThickNeedle3DNumericEdit)
        Me.gaugeTabPage.Controls.Add(Me.flatWithThinNeedleGaugeNumericEdit)
        Me.gaugeTabPage.Controls.Add(Me.flatWithThickNeedleNumericEdit)
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThinNeedle3DGauge)
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThinNeedleGauge)
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThickNeedle3DGauge)
        Me.gaugeTabPage.Controls.Add(Me.sunkenWithThickNeedleGauge)
        Me.gaugeTabPage.Controls.Add(Me.flatWithThinNeedleGauge)
        Me.gaugeTabPage.Controls.Add(Me.flatWithThickNeedleGauge)
        Me.gaugeTabPage.Location = New System.Drawing.Point(4, 22)
        Me.gaugeTabPage.Name = "gaugeTabPage"
        Me.gaugeTabPage.Size = New System.Drawing.Size(624, 446)
        Me.gaugeTabPage.TabIndex = 2
        Me.gaugeTabPage.Text = "Gauge"
        Me.gaugeTabPage.Visible = False
        '
        'sunkenWithThickNeedleNumericEdit
        '
        Me.sunkenWithThickNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.sunkenWithThickNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.sunkenWithThickNeedleNumericEdit.Location = New System.Drawing.Point(444, 192)
        Me.sunkenWithThickNeedleNumericEdit.Name = "sunkenWithThickNeedleNumericEdit"
        Me.sunkenWithThickNeedleNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.sunkenWithThickNeedleNumericEdit.Source = Me.sunkenWithThickNeedleGauge
        Me.sunkenWithThickNeedleNumericEdit.TabIndex = 13
        Me.sunkenWithThickNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'sunkenWithThickNeedleGauge
        '
        Me.sunkenWithThickNeedleGauge.Caption = "SunkenWithThickNeedle"
        Me.sunkenWithThickNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThickNeedle
        Me.sunkenWithThickNeedleGauge.Location = New System.Drawing.Point(424, 31)
        Me.sunkenWithThickNeedleGauge.MajorDivisions.LabelForeColor = System.Drawing.Color.Red
        Me.sunkenWithThickNeedleGauge.Name = "sunkenWithThickNeedleGauge"
        Me.sunkenWithThickNeedleGauge.ScaleArc = New NationalInstruments.UI.Arc(121.0!, 299.0!)
        Me.sunkenWithThickNeedleGauge.Size = New System.Drawing.Size(160, 160)
        Me.sunkenWithThickNeedleGauge.TabIndex = 2
        '
        'sunkenWithThinNeedleGaugeNumericEdit
        '
        Me.sunkenWithThinNeedleGaugeNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.sunkenWithThinNeedleGaugeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.sunkenWithThinNeedleGaugeNumericEdit.Location = New System.Drawing.Point(236, 400)
        Me.sunkenWithThinNeedleGaugeNumericEdit.Name = "sunkenWithThinNeedleGaugeNumericEdit"
        Me.sunkenWithThinNeedleGaugeNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.sunkenWithThinNeedleGaugeNumericEdit.Source = Me.sunkenWithThinNeedleGauge
        Me.sunkenWithThinNeedleGaugeNumericEdit.TabIndex = 12
        Me.sunkenWithThinNeedleGaugeNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'sunkenWithThinNeedleGauge
        '
        Me.sunkenWithThinNeedleGauge.Caption = "SunkenWithThinNeedle"
        Me.sunkenWithThinNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThinNeedle
        Me.sunkenWithThinNeedleGauge.Location = New System.Drawing.Point(224, 240)
        Me.sunkenWithThinNeedleGauge.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0.###'%'")
        Me.sunkenWithThinNeedleGauge.Name = "sunkenWithThinNeedleGauge"
        Me.sunkenWithThinNeedleGauge.Range = New NationalInstruments.UI.Range(0, 100)
        Me.sunkenWithThinNeedleGauge.Size = New System.Drawing.Size(160, 160)
        Me.sunkenWithThinNeedleGauge.SpindleColor = System.Drawing.Color.Red
        Me.sunkenWithThinNeedleGauge.TabIndex = 4
        '
        'sunkenWithThinNeedle3DNumericEdit
        '
        Me.sunkenWithThinNeedle3DNumericEdit.Location = New System.Drawing.Point(452, 400)
        Me.sunkenWithThinNeedle3DNumericEdit.Name = "sunkenWithThinNeedle3DNumericEdit"
        Me.sunkenWithThinNeedle3DNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.sunkenWithThinNeedle3DNumericEdit.Source = Me.sunkenWithThinNeedle3DGauge
        Me.sunkenWithThinNeedle3DNumericEdit.TabIndex = 11
        Me.sunkenWithThinNeedle3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'sunkenWithThinNeedle3DGauge
        '
        Me.sunkenWithThinNeedle3DGauge.Caption = "SunkenWithThinNeedle3D"
        Me.sunkenWithThinNeedle3DGauge.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions
        Me.sunkenWithThinNeedle3DGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThinNeedle3D
        Me.sunkenWithThinNeedle3DGauge.InteractionMode = CType((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.RadialNumericPointerInteractionModes)
        Me.sunkenWithThinNeedle3DGauge.Location = New System.Drawing.Point(424, 240)
        Me.sunkenWithThinNeedle3DGauge.MajorDivisions.TickColor = System.Drawing.Color.DodgerBlue
        Me.sunkenWithThinNeedle3DGauge.MajorDivisions.TickLength = 7.0!
        Me.sunkenWithThinNeedle3DGauge.MinorDivisions.TickColor = System.Drawing.Color.Red
        Me.sunkenWithThinNeedle3DGauge.Name = "sunkenWithThinNeedle3DGauge"
        Me.sunkenWithThinNeedle3DGauge.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.sunkenWithThinNeedle3DGauge.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.sunkenWithThinNeedle3DGauge.Size = New System.Drawing.Size(160, 160)
        Me.sunkenWithThinNeedle3DGauge.TabIndex = 5
        Me.sunkenWithThinNeedle3DGauge.Value = 0.1
        '
        'sunkenWithThickNeedle3DNumericEdit
        '
        Me.sunkenWithThickNeedle3DNumericEdit.Location = New System.Drawing.Point(60, 400)
        Me.sunkenWithThickNeedle3DNumericEdit.Name = "sunkenWithThickNeedle3DNumericEdit"
        Me.sunkenWithThickNeedle3DNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.sunkenWithThickNeedle3DNumericEdit.Source = Me.sunkenWithThickNeedle3DGauge
        Me.sunkenWithThickNeedle3DNumericEdit.TabIndex = 10
        Me.sunkenWithThickNeedle3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'sunkenWithThickNeedle3DGauge
        '
        Me.sunkenWithThickNeedle3DGauge.AutoDivisionSpacing = False
        Me.sunkenWithThickNeedle3DGauge.Caption = "SunkenWithThickNeedle3D"
        Me.sunkenWithThickNeedle3DGauge.InteractionMode = CType((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.RadialNumericPointerInteractionModes)
        Me.sunkenWithThickNeedle3DGauge.Location = New System.Drawing.Point(40, 240)
        Me.sunkenWithThickNeedle3DGauge.MajorDivisions.Interval = 2
        Me.sunkenWithThickNeedle3DGauge.MajorDivisions.LabelFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sunkenWithThickNeedle3DGauge.MajorDivisions.LineWidth = 4.0!
        Me.sunkenWithThickNeedle3DGauge.MajorDivisions.TickLength = 10.0!
        Me.sunkenWithThickNeedle3DGauge.MinorDivisions.Interval = 0.5
        Me.sunkenWithThickNeedle3DGauge.MinorDivisions.LineWidth = 3.0!
        Me.sunkenWithThickNeedle3DGauge.MinorDivisions.TickLength = 5.0!
        Me.sunkenWithThickNeedle3DGauge.Name = "sunkenWithThickNeedle3DGauge"
        Me.sunkenWithThickNeedle3DGauge.Size = New System.Drawing.Size(160, 160)
        Me.sunkenWithThickNeedle3DGauge.TabIndex = 3
        '
        'flatWithThinNeedleGaugeNumericEdit
        '
        Me.flatWithThinNeedleGaugeNumericEdit.Location = New System.Drawing.Point(244, 192)
        Me.flatWithThinNeedleGaugeNumericEdit.Name = "flatWithThinNeedleGaugeNumericEdit"
        Me.flatWithThinNeedleGaugeNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatWithThinNeedleGaugeNumericEdit.Source = Me.flatWithThinNeedleGauge
        Me.flatWithThinNeedleGaugeNumericEdit.TabIndex = 9
        Me.flatWithThinNeedleGaugeNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatWithThinNeedleGauge
        '
        Me.flatWithThinNeedleGauge.Caption = "FlatWithThinNeedle"
        Me.flatWithThinNeedleGauge.DialColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.flatWithThinNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.FlatWithThinNeedle
        Me.flatWithThinNeedleGauge.InteractionMode = CType((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.RadialNumericPointerInteractionModes)
        Me.flatWithThinNeedleGauge.Location = New System.Drawing.Point(224, 31)
        Me.flatWithThinNeedleGauge.MinorDivisions.TickVisible = False
        Me.flatWithThinNeedleGauge.Name = "flatWithThinNeedleGauge"
        Me.flatWithThinNeedleGauge.PointerColor = System.Drawing.Color.Blue
        Me.flatWithThinNeedleGauge.ScaleArc = New NationalInstruments.UI.Arc(300.0!, 300.0!)
        Me.flatWithThinNeedleGauge.Size = New System.Drawing.Size(160, 160)
        Me.flatWithThinNeedleGauge.TabIndex = 1
        '
        'flatWithThickNeedleNumericEdit
        '
        Me.flatWithThickNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.flatWithThickNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.flatWithThickNeedleNumericEdit.Location = New System.Drawing.Point(68, 192)
        Me.flatWithThickNeedleNumericEdit.Name = "flatWithThickNeedleNumericEdit"
        Me.flatWithThickNeedleNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatWithThickNeedleNumericEdit.Source = Me.flatWithThickNeedleGauge
        Me.flatWithThickNeedleNumericEdit.TabIndex = 6
        Me.flatWithThickNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatWithThickNeedleGauge
        '
        Me.flatWithThickNeedleGauge.Caption = "FlatWithThickNeedle"
        ScaleCustomDivision8.LabelFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ScaleCustomDivision8.LabelForeColor = System.Drawing.Color.Red
        ScaleCustomDivision8.Text = "Hot"
        ScaleCustomDivision8.Value = 80
        Me.flatWithThickNeedleGauge.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision8})
        Me.flatWithThickNeedleGauge.DialColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.flatWithThickNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.FlatWithThickNeedle
        Me.flatWithThickNeedleGauge.Location = New System.Drawing.Point(40, 31)
        Me.flatWithThickNeedleGauge.Name = "flatWithThickNeedleGauge"
        Me.flatWithThickNeedleGauge.Range = New NationalInstruments.UI.Range(0, 100)
        ScaleRangeFill3.Range = New NationalInstruments.UI.Range(80, 100)
        ScaleRangeFill3.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateSolidStyle(System.Drawing.Color.Red)
        Me.flatWithThickNeedleGauge.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill3})
        Me.flatWithThickNeedleGauge.Size = New System.Drawing.Size(160, 160)
        Me.flatWithThickNeedleGauge.TabIndex = 0
        '
        'tankTabPage
        '
        Me.tankTabPage.Controls.Add(Me.raised3DHorizontalNumericEdit)
        Me.tankTabPage.Controls.Add(Me.raisedHorizontalNumericEdit)
        Me.tankTabPage.Controls.Add(Me.raised3dVerticalNumericEdit)
        Me.tankTabPage.Controls.Add(Me.flatVerticalNumericEdit)
        Me.tankTabPage.Controls.Add(Me.flatHorizontalNumericEdit)
        Me.tankTabPage.Controls.Add(Me.raisedVerticalNumericEdit)
        Me.tankTabPage.Controls.Add(Me.raised3DHorizontalTank)
        Me.tankTabPage.Controls.Add(Me.raisedHorizontalTank)
        Me.tankTabPage.Controls.Add(Me.flatHorizontalTank)
        Me.tankTabPage.Controls.Add(Me.raised3DVerticalTank)
        Me.tankTabPage.Controls.Add(Me.raisedVerticalTank)
        Me.tankTabPage.Controls.Add(Me.flatVerticalTank)
        Me.tankTabPage.Location = New System.Drawing.Point(4, 22)
        Me.tankTabPage.Name = "tankTabPage"
        Me.tankTabPage.Size = New System.Drawing.Size(624, 446)
        Me.tankTabPage.TabIndex = 3
        Me.tankTabPage.Text = "Tank"
        Me.tankTabPage.Visible = False
        '
        'raised3DHorizontalNumericEdit
        '
        Me.raised3DHorizontalNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.raised3DHorizontalNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.raised3DHorizontalNumericEdit.Location = New System.Drawing.Point(444, 384)
        Me.raised3DHorizontalNumericEdit.Name = "raised3DHorizontalNumericEdit"
        Me.raised3DHorizontalNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raised3DHorizontalNumericEdit.Source = Me.raised3DHorizontalTank
        Me.raised3DHorizontalNumericEdit.TabIndex = 14
        Me.raised3DHorizontalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raised3DHorizontalTank
        '
        Me.raised3DHorizontalTank.AutoDivisionSpacing = False
        Me.raised3DHorizontalTank.Caption = "Raised3D"
        Me.raised3DHorizontalTank.Location = New System.Drawing.Point(412, 259)
        Me.raised3DHorizontalTank.Name = "raised3DHorizontalTank"
        Me.raised3DHorizontalTank.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.raised3DHorizontalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.TopBottom
        Me.raised3DHorizontalTank.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.raised3DHorizontalTank.Size = New System.Drawing.Size(168, 120)
        Me.raised3DHorizontalTank.TabIndex = 5
        Me.raised3DHorizontalTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D
        '
        'raisedHorizontalNumericEdit
        '
        Me.raisedHorizontalNumericEdit.Location = New System.Drawing.Point(256, 384)
        Me.raisedHorizontalNumericEdit.Name = "raisedHorizontalNumericEdit"
        Me.raisedHorizontalNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedHorizontalNumericEdit.Source = Me.raisedHorizontalTank
        Me.raisedHorizontalNumericEdit.TabIndex = 12
        Me.raisedHorizontalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedHorizontalTank
        '
        Me.raisedHorizontalTank.Caption = "Raised"
        Me.raisedHorizontalTank.FillColor = System.Drawing.SystemColors.ControlText
        Me.raisedHorizontalTank.FillMode = NationalInstruments.UI.NumericFillMode.None
        Me.raisedHorizontalTank.InteractionMode = CType((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.LinearNumericPointerInteractionModes)
        Me.raisedHorizontalTank.InvertedScale = True
        Me.raisedHorizontalTank.Location = New System.Drawing.Point(228, 259)
        Me.raisedHorizontalTank.Name = "raisedHorizontalTank"
        Me.raisedHorizontalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Top
        Me.raisedHorizontalTank.Size = New System.Drawing.Size(168, 120)
        Me.raisedHorizontalTank.TabIndex = 4
        Me.raisedHorizontalTank.Value = 5
        '
        'raised3dVerticalNumericEdit
        '
        Me.raised3dVerticalNumericEdit.Location = New System.Drawing.Point(444, 213)
        Me.raised3dVerticalNumericEdit.Name = "raised3dVerticalNumericEdit"
        Me.raised3dVerticalNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raised3dVerticalNumericEdit.Source = Me.raised3DVerticalTank
        Me.raised3dVerticalNumericEdit.TabIndex = 11
        Me.raised3dVerticalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raised3DVerticalTank
        '
        Me.raised3DVerticalTank.Caption = "Raised3D"
        Me.raised3DVerticalTank.FillBaseValue = 2
        Me.raised3DVerticalTank.FillMode = NationalInstruments.UI.NumericFillMode.ToBaseValue
        Me.raised3DVerticalTank.InteractionMode = CType((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.LinearNumericPointerInteractionModes)
        Me.raised3DVerticalTank.Location = New System.Drawing.Point(444, 27)
        Me.raised3DVerticalTank.Name = "raised3DVerticalTank"
        Me.raised3DVerticalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Right
        Me.raised3DVerticalTank.Size = New System.Drawing.Size(120, 184)
        Me.raised3DVerticalTank.TabIndex = 2
        Me.raised3DVerticalTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D
        Me.raised3DVerticalTank.Value = 5
        '
        'flatVerticalNumericEdit
        '
        Me.flatVerticalNumericEdit.Location = New System.Drawing.Point(68, 213)
        Me.flatVerticalNumericEdit.Name = "flatVerticalNumericEdit"
        Me.flatVerticalNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatVerticalNumericEdit.Source = Me.flatVerticalTank
        Me.flatVerticalNumericEdit.TabIndex = 10
        Me.flatVerticalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatVerticalTank
        '
        Me.flatVerticalTank.Caption = "Flat"
        Me.flatVerticalTank.FillStyle = NationalInstruments.UI.FillStyle.Wave
        Me.flatVerticalTank.InteractionMode = CType((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.LinearNumericPointerInteractionModes)
        Me.flatVerticalTank.Location = New System.Drawing.Point(60, 27)
        Me.flatVerticalTank.Name = "flatVerticalTank"
        Me.flatVerticalTank.Range = New NationalInstruments.UI.Range(-100, 100)
        Me.flatVerticalTank.Size = New System.Drawing.Size(120, 184)
        Me.flatVerticalTank.TabIndex = 0
        Me.flatVerticalTank.TankStyle = NationalInstruments.UI.TankStyle.Flat
        '
        'flatHorizontalNumericEdit
        '
        Me.flatHorizontalNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.flatHorizontalNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.flatHorizontalNumericEdit.Location = New System.Drawing.Point(72, 384)
        Me.flatHorizontalNumericEdit.Name = "flatHorizontalNumericEdit"
        Me.flatHorizontalNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatHorizontalNumericEdit.Source = Me.flatHorizontalTank
        Me.flatHorizontalNumericEdit.TabIndex = 8
        Me.flatHorizontalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatHorizontalTank
        '
        Me.flatHorizontalTank.Caption = "Flat"
        Me.flatHorizontalTank.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient
        Me.flatHorizontalTank.Location = New System.Drawing.Point(44, 259)
        Me.flatHorizontalTank.Name = "flatHorizontalTank"
        Me.flatHorizontalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.flatHorizontalTank.Size = New System.Drawing.Size(168, 120)
        Me.flatHorizontalTank.TabIndex = 3
        Me.flatHorizontalTank.TankStyle = NationalInstruments.UI.TankStyle.Flat
        Me.flatHorizontalTank.Value = 2
        '
        'raisedVerticalNumericEdit
        '
        Me.raisedVerticalNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.raisedVerticalNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.raisedVerticalNumericEdit.Location = New System.Drawing.Point(252, 213)
        Me.raisedVerticalNumericEdit.Name = "raisedVerticalNumericEdit"
        Me.raisedVerticalNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedVerticalNumericEdit.Source = Me.raisedVerticalTank
        Me.raisedVerticalNumericEdit.TabIndex = 7
        Me.raisedVerticalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedVerticalTank
        '
        Me.raisedVerticalTank.Caption = "Raised"
        ScaleCustomDivision9.LabelForeColor = System.Drawing.Color.Red
        ScaleCustomDivision9.Text = "HOT"
        ScaleCustomDivision9.TickLength = 3.0!
        ScaleCustomDivision9.Value = 80
        Me.raisedVerticalTank.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision9})
        Me.raisedVerticalTank.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum
        Me.raisedVerticalTank.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient
        Me.raisedVerticalTank.Location = New System.Drawing.Point(252, 27)
        Me.raisedVerticalTank.Name = "raisedVerticalTank"
        Me.raisedVerticalTank.Range = New NationalInstruments.UI.Range(0, 100)
        ScaleRangeFill4.Range = New NationalInstruments.UI.Range(80, 100)
        ScaleRangeFill4.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateStyleFromFillStyle(NationalInstruments.UI.FillStyle.Divot, System.Drawing.Color.Red)
        Me.raisedVerticalTank.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill4})
        Me.raisedVerticalTank.Size = New System.Drawing.Size(120, 184)
        Me.raisedVerticalTank.TabIndex = 1
        Me.raisedVerticalTank.Value = 40
        '
        'slideTabPage
        '
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit)
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGripHorizontalSlideNumericEdit)
        Me.slideTabPage.Controls.Add(Me.sunkenWithGripHorizontalSlideNumericEdit)
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit)
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGripVerticalSlideNumericEdit)
        Me.slideTabPage.Controls.Add(Me.sunkenWithGripVerticalSlideNumericEdit)
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGrip3DHorizontalSlide)
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGripHorizontalSlide)
        Me.slideTabPage.Controls.Add(Me.sunkenWithGripHorizontalSlide)
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGrip3DVerticalSlide)
        Me.slideTabPage.Controls.Add(Me.raisedWithRoundedGripVerticalSlide)
        Me.slideTabPage.Controls.Add(Me.sunkenWithGripVerticalSlide)
        Me.slideTabPage.Location = New System.Drawing.Point(4, 22)
        Me.slideTabPage.Name = "slideTabPage"
        Me.slideTabPage.Size = New System.Drawing.Size(624, 446)
        Me.slideTabPage.TabIndex = 4
        Me.slideTabPage.Text = "Slide"
        Me.slideTabPage.Visible = False
        '
        'raisedWithRoundedGrip3DHorizontalSlideNumericEdit
        '
        Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Location = New System.Drawing.Point(472, 392)
        Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Name = "raisedWithRoundedGrip3DHorizontalSlideNumericEdit"
        Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Source = Me.raisedWithRoundedGrip3DHorizontalSlide
        Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.TabIndex = 15
        Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithRoundedGrip3DHorizontalSlide
        '
        Me.raisedWithRoundedGrip3DHorizontalSlide.AutoDivisionSpacing = False
        Me.raisedWithRoundedGrip3DHorizontalSlide.Caption = "RaisedWithRoundedGrip3D"
        Me.raisedWithRoundedGrip3DHorizontalSlide.Location = New System.Drawing.Point(440, 267)
        Me.raisedWithRoundedGrip3DHorizontalSlide.Name = "raisedWithRoundedGrip3DHorizontalSlide"
        Me.raisedWithRoundedGrip3DHorizontalSlide.Range = New NationalInstruments.UI.Range(0, 1000)
        Me.raisedWithRoundedGrip3DHorizontalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.TopBottom
        Me.raisedWithRoundedGrip3DHorizontalSlide.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.raisedWithRoundedGrip3DHorizontalSlide.Size = New System.Drawing.Size(176, 120)
        Me.raisedWithRoundedGrip3DHorizontalSlide.TabIndex = 5
        '
        'raisedWithRoundedGripHorizontalSlideNumericEdit
        '
        Me.raisedWithRoundedGripHorizontalSlideNumericEdit.Location = New System.Drawing.Point(248, 392)
        Me.raisedWithRoundedGripHorizontalSlideNumericEdit.Name = "raisedWithRoundedGripHorizontalSlideNumericEdit"
        Me.raisedWithRoundedGripHorizontalSlideNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithRoundedGripHorizontalSlideNumericEdit.Source = Me.raisedWithRoundedGripHorizontalSlide
        Me.raisedWithRoundedGripHorizontalSlideNumericEdit.TabIndex = 14
        Me.raisedWithRoundedGripHorizontalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithRoundedGripHorizontalSlide
        '
        Me.raisedWithRoundedGripHorizontalSlide.Caption = "RaisedWithRoundedGrip"
        Me.raisedWithRoundedGripHorizontalSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum
        Me.raisedWithRoundedGripHorizontalSlide.InvertedScale = True
        Me.raisedWithRoundedGripHorizontalSlide.Location = New System.Drawing.Point(216, 267)
        Me.raisedWithRoundedGripHorizontalSlide.Name = "raisedWithRoundedGripHorizontalSlide"
        Me.raisedWithRoundedGripHorizontalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Top
        Me.raisedWithRoundedGripHorizontalSlide.Size = New System.Drawing.Size(176, 125)
        Me.raisedWithRoundedGripHorizontalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip
        Me.raisedWithRoundedGripHorizontalSlide.TabIndex = 4
        '
        'sunkenWithGripHorizontalSlideNumericEdit
        '
        Me.sunkenWithGripHorizontalSlideNumericEdit.Location = New System.Drawing.Point(40, 392)
        Me.sunkenWithGripHorizontalSlideNumericEdit.Name = "sunkenWithGripHorizontalSlideNumericEdit"
        Me.sunkenWithGripHorizontalSlideNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.sunkenWithGripHorizontalSlideNumericEdit.Source = Me.sunkenWithGripHorizontalSlide
        Me.sunkenWithGripHorizontalSlideNumericEdit.TabIndex = 13
        Me.sunkenWithGripHorizontalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'sunkenWithGripHorizontalSlide
        '
        Me.sunkenWithGripHorizontalSlide.Caption = "SunkenWithGrip"
        Me.sunkenWithGripHorizontalSlide.Location = New System.Drawing.Point(8, 267)
        Me.sunkenWithGripHorizontalSlide.Name = "sunkenWithGripHorizontalSlide"
        Me.sunkenWithGripHorizontalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.sunkenWithGripHorizontalSlide.Size = New System.Drawing.Size(176, 125)
        Me.sunkenWithGripHorizontalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip
        Me.sunkenWithGripHorizontalSlide.TabIndex = 3
        '
        'raisedWithRoundedGrip3DVerticalSlideNumericEdit
        '
        Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Location = New System.Drawing.Point(452, 213)
        Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Name = "raisedWithRoundedGrip3DVerticalSlideNumericEdit"
        Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Source = Me.raisedWithRoundedGrip3DVerticalSlide
        Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit.TabIndex = 12
        Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithRoundedGrip3DVerticalSlide
        '
        Me.raisedWithRoundedGrip3DVerticalSlide.Caption = "RaisedWithRoundedGrip3D"
        Me.raisedWithRoundedGrip3DVerticalSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum
        Me.raisedWithRoundedGrip3DVerticalSlide.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient
        Me.raisedWithRoundedGrip3DVerticalSlide.Location = New System.Drawing.Point(432, 19)
        Me.raisedWithRoundedGrip3DVerticalSlide.Name = "raisedWithRoundedGrip3DVerticalSlide"
        Me.raisedWithRoundedGrip3DVerticalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Right
        Me.raisedWithRoundedGrip3DVerticalSlide.Size = New System.Drawing.Size(160, 192)
        Me.raisedWithRoundedGrip3DVerticalSlide.TabIndex = 2
        '
        'raisedWithRoundedGripVerticalSlideNumericEdit
        '
        Me.raisedWithRoundedGripVerticalSlideNumericEdit.Location = New System.Drawing.Point(260, 213)
        Me.raisedWithRoundedGripVerticalSlideNumericEdit.Name = "raisedWithRoundedGripVerticalSlideNumericEdit"
        Me.raisedWithRoundedGripVerticalSlideNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedWithRoundedGripVerticalSlideNumericEdit.Source = Me.raisedWithRoundedGripVerticalSlide
        Me.raisedWithRoundedGripVerticalSlideNumericEdit.TabIndex = 11
        Me.raisedWithRoundedGripVerticalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedWithRoundedGripVerticalSlide
        '
        Me.raisedWithRoundedGripVerticalSlide.Caption = "RaisedWithRoundedGrip"
        Me.raisedWithRoundedGripVerticalSlide.Location = New System.Drawing.Point(224, 19)
        Me.raisedWithRoundedGripVerticalSlide.Name = "raisedWithRoundedGripVerticalSlide"
        Me.raisedWithRoundedGripVerticalSlide.Range = New NationalInstruments.UI.Range(0, 100)
        Me.raisedWithRoundedGripVerticalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.LeftRight
        Me.raisedWithRoundedGripVerticalSlide.Size = New System.Drawing.Size(184, 192)
        Me.raisedWithRoundedGripVerticalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip
        Me.raisedWithRoundedGripVerticalSlide.TabIndex = 1
        '
        'sunkenWithGripVerticalSlideNumericEdit
        '
        Me.sunkenWithGripVerticalSlideNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.sunkenWithGripVerticalSlideNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.sunkenWithGripVerticalSlideNumericEdit.Location = New System.Drawing.Point(60, 213)
        Me.sunkenWithGripVerticalSlideNumericEdit.Name = "sunkenWithGripVerticalSlideNumericEdit"
        Me.sunkenWithGripVerticalSlideNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.sunkenWithGripVerticalSlideNumericEdit.Source = Me.sunkenWithGripVerticalSlide
        Me.sunkenWithGripVerticalSlideNumericEdit.TabIndex = 8
        Me.sunkenWithGripVerticalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'sunkenWithGripVerticalSlide
        '
        Me.sunkenWithGripVerticalSlide.Caption = "SunkenWithGrip"
        Me.sunkenWithGripVerticalSlide.FillMode = NationalInstruments.UI.NumericFillMode.None
        Me.sunkenWithGripVerticalSlide.FillStyle = NationalInstruments.UI.FillStyle.None
        Me.sunkenWithGripVerticalSlide.Location = New System.Drawing.Point(32, 19)
        Me.sunkenWithGripVerticalSlide.Name = "sunkenWithGripVerticalSlide"
        ScaleRangeFill5.Range = New NationalInstruments.UI.Range(2, 8)
        ScaleRangeFill5.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateStyleFromFillStyle(NationalInstruments.UI.FillStyle.HorizontalGradient, System.Drawing.Color.Silver)
        ScaleRangeFill5.Width = 7.0!
        Me.sunkenWithGripVerticalSlide.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill5})
        Me.sunkenWithGripVerticalSlide.Size = New System.Drawing.Size(144, 192)
        Me.sunkenWithGripVerticalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip
        Me.sunkenWithGripVerticalSlide.TabIndex = 0
        '
        'thermometerTabPage
        '
        Me.thermometerTabPage.Controls.Add(Me.flatHorizontalThermometerNumericEdit)
        Me.thermometerTabPage.Controls.Add(Me.raisedVerticalThermometerNumericEdit)
        Me.thermometerTabPage.Controls.Add(Me.raised3DHorizontalThermometerNumericEdit)
        Me.thermometerTabPage.Controls.Add(Me.raisedHorizontalThermometerNumericEdit)
        Me.thermometerTabPage.Controls.Add(Me.raised3DVerticalThermometerNumericEdit)
        Me.thermometerTabPage.Controls.Add(Me.flatVerticalThermometerNumericEdit)
        Me.thermometerTabPage.Controls.Add(Me.raised3DHorizontalThermometer)
        Me.thermometerTabPage.Controls.Add(Me.raisedHorizontalThermometer)
        Me.thermometerTabPage.Controls.Add(Me.flatHorizontalThermometer)
        Me.thermometerTabPage.Controls.Add(Me.raised3DVerticalThermometer)
        Me.thermometerTabPage.Controls.Add(Me.raisedVerticalThermometer)
        Me.thermometerTabPage.Controls.Add(Me.flatVerticalThermometer)
        Me.thermometerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.thermometerTabPage.Name = "thermometerTabPage"
        Me.thermometerTabPage.Size = New System.Drawing.Size(624, 446)
        Me.thermometerTabPage.TabIndex = 5
        Me.thermometerTabPage.Text = "Thermometer"
        Me.thermometerTabPage.Visible = False
        '
        'flatHorizontalThermometerNumericEdit
        '
        Me.flatHorizontalThermometerNumericEdit.Location = New System.Drawing.Point(56, 392)
        Me.flatHorizontalThermometerNumericEdit.Name = "flatHorizontalThermometerNumericEdit"
        Me.flatHorizontalThermometerNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatHorizontalThermometerNumericEdit.Source = Me.flatHorizontalThermometer
        Me.flatHorizontalThermometerNumericEdit.TabIndex = 12
        Me.flatHorizontalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatHorizontalThermometer
        '
        Me.flatHorizontalThermometer.Caption = "Flat"
        Me.flatHorizontalThermometer.InteractionMode = CType((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.LinearNumericPointerInteractionModes)
        Me.flatHorizontalThermometer.Location = New System.Drawing.Point(24, 295)
        Me.flatHorizontalThermometer.Name = "flatHorizontalThermometer"
        Me.flatHorizontalThermometer.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.flatHorizontalThermometer.Size = New System.Drawing.Size(168, 96)
        Me.flatHorizontalThermometer.TabIndex = 3
        Me.flatHorizontalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Flat
        '
        'raisedVerticalThermometerNumericEdit
        '
        Me.raisedVerticalThermometerNumericEdit.Location = New System.Drawing.Point(264, 256)
        Me.raisedVerticalThermometerNumericEdit.Name = "raisedVerticalThermometerNumericEdit"
        Me.raisedVerticalThermometerNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedVerticalThermometerNumericEdit.Source = Me.raisedVerticalThermometer
        Me.raisedVerticalThermometerNumericEdit.TabIndex = 11
        Me.raisedVerticalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedVerticalThermometer
        '
        Me.raisedVerticalThermometer.Caption = "Raised"
        Me.raisedVerticalThermometer.InteractionMode = CType((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.LinearNumericPointerInteractionModes)
        Me.raisedVerticalThermometer.Location = New System.Drawing.Point(284, 15)
        Me.raisedVerticalThermometer.Name = "raisedVerticalThermometer"
        Me.raisedVerticalThermometer.Range = New NationalInstruments.UI.Range(40, 100)
        Me.raisedVerticalThermometer.Size = New System.Drawing.Size(80, 240)
        Me.raisedVerticalThermometer.TabIndex = 1
        Me.raisedVerticalThermometer.Value = 50
        '
        'raised3DHorizontalThermometerNumericEdit
        '
        Me.raised3DHorizontalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.raised3DHorizontalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.raised3DHorizontalThermometerNumericEdit.Location = New System.Drawing.Point(456, 384)
        Me.raised3DHorizontalThermometerNumericEdit.Name = "raised3DHorizontalThermometerNumericEdit"
        Me.raised3DHorizontalThermometerNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raised3DHorizontalThermometerNumericEdit.Source = Me.raised3DHorizontalThermometer
        Me.raised3DHorizontalThermometerNumericEdit.TabIndex = 9
        Me.raised3DHorizontalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raised3DHorizontalThermometer
        '
        Me.raised3DHorizontalThermometer.Caption = "Raised3D"
        Me.raised3DHorizontalThermometer.Location = New System.Drawing.Point(432, 295)
        Me.raised3DHorizontalThermometer.MaximumBulbDiameter = 5.0!
        Me.raised3DHorizontalThermometer.Name = "raised3DHorizontalThermometer"
        Me.raised3DHorizontalThermometer.ScalePosition = NationalInstruments.UI.NumericScalePosition.TopBottom
        Me.raised3DHorizontalThermometer.Size = New System.Drawing.Size(168, 88)
        Me.raised3DHorizontalThermometer.TabIndex = 5
        Me.raised3DHorizontalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Raised3D
        '
        'raisedHorizontalThermometerNumericEdit
        '
        Me.raisedHorizontalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.raisedHorizontalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.raisedHorizontalThermometerNumericEdit.Location = New System.Drawing.Point(264, 392)
        Me.raisedHorizontalThermometerNumericEdit.Name = "raisedHorizontalThermometerNumericEdit"
        Me.raisedHorizontalThermometerNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raisedHorizontalThermometerNumericEdit.Source = Me.raisedHorizontalThermometer
        Me.raisedHorizontalThermometerNumericEdit.TabIndex = 8
        Me.raisedHorizontalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raisedHorizontalThermometer
        '
        Me.raisedHorizontalThermometer.CanShowFocus = True
        Me.raisedHorizontalThermometer.Caption = "Raised"
        Me.raisedHorizontalThermometer.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient
        Me.raisedHorizontalThermometer.Location = New System.Drawing.Point(224, 295)
        Me.raisedHorizontalThermometer.Name = "raisedHorizontalThermometer"
        Me.raisedHorizontalThermometer.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.raisedHorizontalThermometer.Size = New System.Drawing.Size(168, 96)
        Me.raisedHorizontalThermometer.TabIndex = 4
        '
        'raised3DVerticalThermometerNumericEdit
        '
        Me.raised3DVerticalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.raised3DVerticalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.raised3DVerticalThermometerNumericEdit.Location = New System.Drawing.Point(456, 256)
        Me.raised3DVerticalThermometerNumericEdit.Name = "raised3DVerticalThermometerNumericEdit"
        Me.raised3DVerticalThermometerNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.raised3DVerticalThermometerNumericEdit.Source = Me.raised3DVerticalThermometer
        Me.raised3DVerticalThermometerNumericEdit.TabIndex = 7
        Me.raised3DVerticalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'raised3DVerticalThermometer
        '
        Me.raised3DVerticalThermometer.Caption = "Raised3D"
        Me.raised3DVerticalThermometer.Location = New System.Drawing.Point(476, 15)
        Me.raised3DVerticalThermometer.Name = "raised3DVerticalThermometer"
        Me.raised3DVerticalThermometer.Size = New System.Drawing.Size(64, 240)
        Me.raised3DVerticalThermometer.TabIndex = 2
        Me.raised3DVerticalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Raised3D
        '
        'flatVerticalThermometerNumericEdit
        '
        Me.flatVerticalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.flatVerticalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.flatVerticalThermometerNumericEdit.Location = New System.Drawing.Point(56, 256)
        Me.flatVerticalThermometerNumericEdit.Name = "flatVerticalThermometerNumericEdit"
        Me.flatVerticalThermometerNumericEdit.Size = New System.Drawing.Size(112, 20)
        Me.flatVerticalThermometerNumericEdit.Source = Me.flatVerticalThermometer
        Me.flatVerticalThermometerNumericEdit.TabIndex = 6
        Me.flatVerticalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'flatVerticalThermometer
        '
        Me.flatVerticalThermometer.Caption = "Flat"
        Me.flatVerticalThermometer.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient
        Me.flatVerticalThermometer.Location = New System.Drawing.Point(84, 15)
        Me.flatVerticalThermometer.Name = "flatVerticalThermometer"
        Me.flatVerticalThermometer.Size = New System.Drawing.Size(80, 240)
        Me.flatVerticalThermometer.TabIndex = 0
        Me.flatVerticalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Flat
        Me.flatVerticalThermometer.Value = 20
        '
        'sampleTimer
        '
        Me.sampleTimer.Enabled = True
        Me.sampleTimer.Interval = 200
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(624, 470)
        Me.Controls.Add(Me.stylesTabControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Styles"
        Me.stylesTabControl.ResumeLayout(False)
        Me.knobTabPage.ResumeLayout(False)
        CType(Me.raisedWithThumb3DNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThumb3DKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThumbNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThumbKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThinNeedle3DNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThinNeedle3DKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThinNeedleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThinNeedleKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThinNeedleKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.meterTabPage.ResumeLayout(False)
        CType(Me.flatWithThinNeedleMeterNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThinNeedleMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThickNeedleMeterNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThickNeedleMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThinNeedleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThinNeedleMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThickNeedleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithThickNeedleMeter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gaugeTabPage.ResumeLayout(False)
        CType(Me.sunkenWithThickNeedleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithThickNeedleGauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithThinNeedleGaugeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithThinNeedleGauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithThinNeedle3DNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithThinNeedle3DGauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithThickNeedle3DNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithThickNeedle3DGauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThinNeedleGaugeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThinNeedleGauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThickNeedleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatWithThickNeedleGauge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tankTabPage.ResumeLayout(False)
        CType(Me.raised3DHorizontalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raised3DHorizontalTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedHorizontalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedHorizontalTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raised3dVerticalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raised3DVerticalTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatVerticalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatVerticalTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatHorizontalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatHorizontalTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedVerticalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedVerticalTank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slideTabPage.ResumeLayout(False)
        CType(Me.raisedWithRoundedGrip3DHorizontalSlideNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithRoundedGrip3DHorizontalSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithRoundedGripHorizontalSlideNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithRoundedGripHorizontalSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithGripHorizontalSlideNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithGripHorizontalSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithRoundedGrip3DVerticalSlideNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithRoundedGrip3DVerticalSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithRoundedGripVerticalSlideNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedWithRoundedGripVerticalSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithGripVerticalSlideNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sunkenWithGripVerticalSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.thermometerTabPage.ResumeLayout(False)
        CType(Me.flatHorizontalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatHorizontalThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedVerticalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedVerticalThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raised3DHorizontalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raised3DHorizontalThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedHorizontalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raisedHorizontalThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raised3DVerticalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.raised3DVerticalThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatVerticalThermometerNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.flatVerticalThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private raisedWithThickNeedleMeterValueIncreasing As Boolean = True
    Private raisedWithThinNeedleMeterValueIncreasing As Boolean = True
    Private flatWithThickNeedleMeterValueIncreasing As Boolean = True
    Private flatWithThinNeedleMeterValueIncreasing As Boolean = True
    Private flatWithThinNeedleKnobValueIncreasing As Boolean = True
    Private flatWithThickNeedleGaugeValueIncreasing As Boolean = True
    Private sunkenWithThickNeedleGaugeValueIncreasing As Boolean = True
    Private sunkenWithThinNeedleGaugeValueIncreasing As Boolean = True
    Private raisedVerticalTankValueIncreasing As Boolean = True
    Private flatHorizontalTankValueIncreasing As Boolean = True
    Private raised3DHorizontalTankValueIncreasing As Boolean = True
    Private sunkenWithGripVerticalSlideValueIncreasing As Boolean = True
    Private flatVerticalThermometerValueIncreasing As Boolean = True
    Private raised3DVerticalThermometerValueIncreasing As Boolean = True
    Private raisedHorizontalThermometerValueIncreasing As Boolean = True
    Private raised3DHorizontalThermometerValueIncreasing As Boolean = True

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub sampleTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sampleTimer.Tick
        If (stylesTabControl.SelectedTab Is meterTabPage) Then
            raisedWithThickNeedleMeter.Value = GetNewValue(raisedWithThickNeedleMeter.Range, raisedWithThickNeedleMeter.Value, 10, raisedWithThickNeedleMeterValueIncreasing)
            raisedWithThinNeedleMeter.Value = GetNewValue(raisedWithThinNeedleMeter.Range, raisedWithThinNeedleMeter.Value, 8, raisedWithThinNeedleMeterValueIncreasing)
            flatWithThickNeedleMeter.Value = GetNewValue(flatWithThickNeedleMeter.Range, flatWithThickNeedleMeter.Value, 10, flatWithThickNeedleMeterValueIncreasing)
            flatWithThinNeedleMeter.Value = GetNewValue(flatWithThinNeedleMeter.Range, flatWithThinNeedleMeter.Value, 50, flatWithThinNeedleMeterValueIncreasing)
        ElseIf stylesTabControl.SelectedTab Is knobTabPage Then
            flatWithThinNeedleKnob.Value = GetNewValue(flatWithThinNeedleKnob.Range, flatWithThinNeedleKnob.Value, 10, flatWithThinNeedleKnobValueIncreasing)
        ElseIf stylesTabControl.SelectedTab Is gaugeTabPage Then
            flatWithThickNeedleGauge.Value = GetNewValue(flatWithThickNeedleGauge.Range, flatWithThickNeedleGauge.Value, 10, flatWithThickNeedleGaugeValueIncreasing)
            sunkenWithThickNeedleGauge.Value = GetNewValue(sunkenWithThickNeedleGauge.Range, sunkenWithThickNeedleGauge.Value, 20, sunkenWithThickNeedleGaugeValueIncreasing)
            sunkenWithThinNeedleGauge.Value = GetNewValue(sunkenWithThinNeedleGauge.Range, sunkenWithThinNeedleGauge.Value, 15, sunkenWithThinNeedleGaugeValueIncreasing)
        ElseIf stylesTabControl.SelectedTab Is tankTabPage Then
            raisedVerticalTank.Value = GetNewValue(raisedVerticalTank.Range, raisedVerticalTank.Value, 10, raisedVerticalTankValueIncreasing)
            flatHorizontalTank.Value = GetNewValue(flatHorizontalTank.Range, flatHorizontalTank.Value, 10, flatHorizontalTankValueIncreasing)
            raised3DHorizontalTank.Value = GetNewValue(raised3DHorizontalTank.Range, raised3DHorizontalTank.Value, 20, raised3DHorizontalTankValueIncreasing)
        ElseIf stylesTabControl.SelectedTab Is slideTabPage Then
            sunkenWithGripVerticalSlide.Value = GetNewValue(sunkenWithGripVerticalSlide.Range, sunkenWithGripVerticalSlide.Value, 10, sunkenWithGripVerticalSlideValueIncreasing)
        ElseIf stylesTabControl.SelectedTab Is thermometerTabPage Then
            flatVerticalThermometer.Value = GetNewValue(flatVerticalThermometer.Range, flatVerticalThermometer.Value, 10, flatVerticalThermometerValueIncreasing)
            raised3DVerticalThermometer.Value = GetNewValue(raised3DVerticalThermometer.Range, raised3DVerticalThermometer.Value, 10, raised3DVerticalThermometerValueIncreasing)
            raisedHorizontalThermometer.Value = GetNewValue(raisedHorizontalThermometer.Range, raisedHorizontalThermometer.Value, 10, raisedHorizontalThermometerValueIncreasing)
            raised3DHorizontalThermometer.Value = GetNewValue(raised3DHorizontalThermometer.Range, raised3DHorizontalThermometer.Value, 20, raised3DHorizontalThermometerValueIncreasing)
        Else
            Debug.Fail("Invalid tab page")
        End If

    End Sub

    Private Shared Function GetNewValue(ByVal range As Range, ByVal currentValue As Double, ByVal numberOfIntervals As Integer, ByRef increasing As Boolean) As Double
        'This determines the new value of the control.
        Dim controlRange As Double = range.Maximum - range.Minimum
        Dim newValue As Double = 0
        If (increasing) Then
            newValue = currentValue + controlRange / numberOfIntervals
            If (newValue > range.Maximum) Then
                newValue = range.Maximum
                increasing = False
            End If
        Else
            newValue = currentValue - controlRange / numberOfIntervals
            If (newValue < range.Minimum) Then
                newValue = range.Minimum
                increasing = True
            End If
        End If

        Return newValue
    End Function
End Class
