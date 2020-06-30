Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        InitializeComponent()
        engineRunning = True
        rand = New Random

        AdjustLabel(airspeedLabel, airspeedGauge)
        AdjustLabel(mphLabel, airspeedGauge)

        AdjustLabel(altitudeLabel, altimeterGauge)
        AdjustLabel(altitude1000Label, altimeterGauge)

    End Sub

    Private Shared Sub AdjustLabel(ByVal label As Label, ByVal labeledControl As Control)
        ' setting parent of labels to the contol instead of the form
        ' so labels are transparent to the control's color instead of
        ' the form's color.

        label.Parent = labeledControl
        label.Location = New Point(label.Location.X - labeledControl.Location.X, label.Location.Y - labeledControl.Location.Y)
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
    Friend WithEvents throttleStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents landingLightsStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gphStatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents altitude1000Label As System.Windows.Forms.Label
    Friend WithEvents altitudeLabel As System.Windows.Forms.Label
    Friend WithEvents throttleSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents gphLabel As System.Windows.Forms.Label
    Friend WithEvents throttleLabel As System.Windows.Forms.Label
    Friend WithEvents landingLightsLabel As System.Windows.Forms.Label
    Friend WithEvents startLabel As System.Windows.Forms.Label
    Friend WithEvents startSwitch As NationalInstruments.UI.WindowsForms.Switch
    Friend WithEvents offLabel As System.Windows.Forms.Label
    Friend WithEvents sampleTimer As System.Windows.Forms.Timer
    Friend WithEvents onLabel As System.Windows.Forms.Label
    Friend WithEvents masterLabel As System.Windows.Forms.Label
    Friend WithEvents masterSwitch As NationalInstruments.UI.WindowsForms.Switch
    Friend WithEvents rpm1000Label As System.Windows.Forms.Label
    Friend WithEvents mphLabel As System.Windows.Forms.Label
    Friend WithEvents airspeedLabel As System.Windows.Forms.Label
    Friend WithEvents rpmLabel As System.Windows.Forms.Label
    Friend WithEvents fuelTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents engineThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents airspeedGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents tachMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents altimeterGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents landingLightsKnob As NationalInstruments.UI.WindowsForms.Knob
    Private rand As Random
    Private engineRunning As Boolean



    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ScaleCustomDivision1 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision2 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision3 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision4 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision5 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision6 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision7 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision8 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision9 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision10 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision11 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision12 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision13 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision14 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision15 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision16 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision17 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision18 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision19 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.throttleStatusTextBox = New System.Windows.Forms.TextBox
        Me.landingLightsStatusTextBox = New System.Windows.Forms.TextBox
        Me.gphStatusTextBox = New System.Windows.Forms.TextBox
        Me.altitude1000Label = New System.Windows.Forms.Label
        Me.altitudeLabel = New System.Windows.Forms.Label
        Me.throttleSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.gphLabel = New System.Windows.Forms.Label
        Me.throttleLabel = New System.Windows.Forms.Label
        Me.landingLightsLabel = New System.Windows.Forms.Label
        Me.startLabel = New System.Windows.Forms.Label
        Me.startSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.offLabel = New System.Windows.Forms.Label
        Me.sampleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.onLabel = New System.Windows.Forms.Label
        Me.masterLabel = New System.Windows.Forms.Label
        Me.masterSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.rpm1000Label = New System.Windows.Forms.Label
        Me.mphLabel = New System.Windows.Forms.Label
        Me.airspeedLabel = New System.Windows.Forms.Label
        Me.rpmLabel = New System.Windows.Forms.Label
        Me.fuelTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.engineThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.airspeedGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.tachMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.altimeterGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.landingLightsKnob = New NationalInstruments.UI.WindowsForms.Knob
        CType(Me.throttleSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.masterSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fuelTank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.engineThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.airspeedGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tachMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.altimeterGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.landingLightsKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'throttleStatusTextBox
        '
        Me.throttleStatusTextBox.BackColor = System.Drawing.Color.Lime
        Me.throttleStatusTextBox.Location = New System.Drawing.Point(385, 237)
        Me.throttleStatusTextBox.Name = "throttleStatusTextBox"
        Me.throttleStatusTextBox.ReadOnly = True
        Me.throttleStatusTextBox.Size = New System.Drawing.Size(68, 20)
        Me.throttleStatusTextBox.TabIndex = 55
        Me.throttleStatusTextBox.Text = "Idle"
        '
        'landingLightsStatusTextBox
        '
        Me.landingLightsStatusTextBox.BackColor = System.Drawing.Color.Red
        Me.landingLightsStatusTextBox.Location = New System.Drawing.Point(385, 269)
        Me.landingLightsStatusTextBox.Name = "landingLightsStatusTextBox"
        Me.landingLightsStatusTextBox.ReadOnly = True
        Me.landingLightsStatusTextBox.Size = New System.Drawing.Size(68, 20)
        Me.landingLightsStatusTextBox.TabIndex = 54
        Me.landingLightsStatusTextBox.Text = "OFF"
        '
        'gphStatusTextBox
        '
        Me.gphStatusTextBox.BackColor = System.Drawing.Color.Lime
        Me.gphStatusTextBox.Location = New System.Drawing.Point(385, 205)
        Me.gphStatusTextBox.Name = "gphStatusTextBox"
        Me.gphStatusTextBox.ReadOnly = True
        Me.gphStatusTextBox.Size = New System.Drawing.Size(68, 20)
        Me.gphStatusTextBox.TabIndex = 53
        Me.gphStatusTextBox.Text = "0"
        '
        'altitude1000Label
        '
        Me.altitude1000Label.AutoSize = True
        Me.altitude1000Label.BackColor = System.Drawing.Color.Transparent
        Me.altitude1000Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.altitude1000Label.Location = New System.Drawing.Point(249, 121)
        Me.altitude1000Label.Name = "altitude1000Label"
        Me.altitude1000Label.Size = New System.Drawing.Size(38, 14)
        Me.altitude1000Label.TabIndex = 39
        Me.altitude1000Label.Text = "X1000 ft"
        '
        'altitudeLabel
        '
        Me.altitudeLabel.AutoSize = True
        Me.altitudeLabel.BackColor = System.Drawing.Color.Transparent
        Me.altitudeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.altitudeLabel.Location = New System.Drawing.Point(257, 109)
        Me.altitudeLabel.Name = "altitudeLabel"
        Me.altitudeLabel.Size = New System.Drawing.Size(21, 14)
        Me.altitudeLabel.TabIndex = 38
        Me.altitudeLabel.Text = "ALT"
        '
        'throttleSlide
        '
        Me.throttleSlide.Caption = "Throttle"
        Me.throttleSlide.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.throttleSlide.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.throttleSlide.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.throttleSlide.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom
        ScaleCustomDivision1.Text = "Idle"
        ScaleCustomDivision1.TickColor = System.Drawing.SystemColors.ControlText
        Me.throttleSlide.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision1})
        Me.throttleSlide.Location = New System.Drawing.Point(5, 177)
        Me.throttleSlide.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0'%'")
        Me.throttleSlide.Name = "throttleSlide"
        Me.throttleSlide.Range = New NationalInstruments.UI.Range(0, 100)
        Me.throttleSlide.Size = New System.Drawing.Size(108, 164)
        Me.throttleSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip
        Me.throttleSlide.TabIndex = 52
        '
        'gphLabel
        '
        Me.gphLabel.AutoSize = True
        Me.gphLabel.Location = New System.Drawing.Point(305, 209)
        Me.gphLabel.Name = "gphLabel"
        Me.gphLabel.Size = New System.Drawing.Size(29, 16)
        Me.gphLabel.TabIndex = 51
        Me.gphLabel.Text = "GPH"
        '
        'throttleLabel
        '
        Me.throttleLabel.AutoSize = True
        Me.throttleLabel.Location = New System.Drawing.Point(305, 241)
        Me.throttleLabel.Name = "throttleLabel"
        Me.throttleLabel.Size = New System.Drawing.Size(43, 16)
        Me.throttleLabel.TabIndex = 50
        Me.throttleLabel.Text = "Throttle"
        '
        'landingLightsLabel
        '
        Me.landingLightsLabel.AutoSize = True
        Me.landingLightsLabel.Location = New System.Drawing.Point(305, 273)
        Me.landingLightsLabel.Name = "landingLightsLabel"
        Me.landingLightsLabel.Size = New System.Drawing.Size(78, 16)
        Me.landingLightsLabel.TabIndex = 49
        Me.landingLightsLabel.Text = "Landing Lights"
        '
        'startLabel
        '
        Me.startLabel.AutoSize = True
        Me.startLabel.Location = New System.Drawing.Point(469, 201)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(66, 16)
        Me.startLabel.TabIndex = 48
        Me.startLabel.Text = "Start Engine"
        '
        'startSwitch
        '
        Me.startSwitch.InteractionMode = NationalInstruments.UI.BooleanInteractionMode.SwitchUntilReleased
        Me.startSwitch.Location = New System.Drawing.Point(477, 221)
        Me.startSwitch.Name = "startSwitch"
        Me.startSwitch.Size = New System.Drawing.Size(56, 84)
        Me.startSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.startSwitch.TabIndex = 47
        '
        'offLabel
        '
        Me.offLabel.AutoSize = True
        Me.offLabel.Location = New System.Drawing.Point(561, 297)
        Me.offLabel.Name = "offLabel"
        Me.offLabel.Size = New System.Drawing.Size(19, 16)
        Me.offLabel.TabIndex = 45
        Me.offLabel.Text = "Off"
        '
        'sampleTimer
        '
        Me.sampleTimer.Enabled = True
        Me.sampleTimer.Interval = 1000
        '
        'onLabel
        '
        Me.onLabel.AutoSize = True
        Me.onLabel.Location = New System.Drawing.Point(561, 221)
        Me.onLabel.Name = "onLabel"
        Me.onLabel.Size = New System.Drawing.Size(19, 16)
        Me.onLabel.TabIndex = 44
        Me.onLabel.Text = "On"
        '
        'masterLabel
        '
        Me.masterLabel.AutoSize = True
        Me.masterLabel.Location = New System.Drawing.Point(549, 201)
        Me.masterLabel.Name = "masterLabel"
        Me.masterLabel.Size = New System.Drawing.Size(39, 16)
        Me.masterLabel.TabIndex = 43
        Me.masterLabel.Text = "Master"
        '
        'masterSwitch
        '
        Me.masterSwitch.Location = New System.Drawing.Point(541, 221)
        Me.masterSwitch.Name = "masterSwitch"
        Me.masterSwitch.Size = New System.Drawing.Size(56, 84)
        Me.masterSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.masterSwitch.TabIndex = 42
        Me.masterSwitch.Value = True
        '
        'rpm1000Label
        '
        Me.rpm1000Label.AutoSize = True
        Me.rpm1000Label.BackColor = System.Drawing.Color.Transparent
        Me.rpm1000Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpm1000Label.Location = New System.Drawing.Point(413, 105)
        Me.rpm1000Label.Name = "rpm1000Label"
        Me.rpm1000Label.Size = New System.Drawing.Size(30, 14)
        Me.rpm1000Label.TabIndex = 41
        Me.rpm1000Label.Text = "X1000"
        '
        'mphLabel
        '
        Me.mphLabel.AutoSize = True
        Me.mphLabel.BackColor = System.Drawing.Color.Transparent
        Me.mphLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mphLabel.Location = New System.Drawing.Point(81, 125)
        Me.mphLabel.Name = "mphLabel"
        Me.mphLabel.Size = New System.Drawing.Size(22, 14)
        Me.mphLabel.TabIndex = 40
        Me.mphLabel.Text = "mph"
        '
        'airspeedLabel
        '
        Me.airspeedLabel.AutoSize = True
        Me.airspeedLabel.BackColor = System.Drawing.Color.Transparent
        Me.airspeedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.airspeedLabel.Location = New System.Drawing.Point(73, 113)
        Me.airspeedLabel.Name = "airspeedLabel"
        Me.airspeedLabel.Size = New System.Drawing.Size(40, 14)
        Me.airspeedLabel.TabIndex = 37
        Me.airspeedLabel.Text = "Airspeed"
        '
        'rpmLabel
        '
        Me.rpmLabel.AutoSize = True
        Me.rpmLabel.BackColor = System.Drawing.Color.Transparent
        Me.rpmLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rpmLabel.Location = New System.Drawing.Point(413, 93)
        Me.rpmLabel.Name = "rpmLabel"
        Me.rpmLabel.Size = New System.Drawing.Size(24, 14)
        Me.rpmLabel.TabIndex = 36
        Me.rpmLabel.Text = "RPM"
        '
        'fuelTank
        '
        ScaleCustomDivision2.Text = "E"
        ScaleCustomDivision2.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision3.Text = "1/2"
        ScaleCustomDivision3.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision3.Value = 5
        ScaleCustomDivision4.Text = "F"
        ScaleCustomDivision4.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision4.Value = 10
        Me.fuelTank.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision2, ScaleCustomDivision3, ScaleCustomDivision4})
        Me.fuelTank.Location = New System.Drawing.Point(357, 129)
        Me.fuelTank.MajorDivisions.TickVisible = False
        Me.fuelTank.MinorDivisions.TickVisible = False
        Me.fuelTank.Name = "fuelTank"
        Me.fuelTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.fuelTank.Size = New System.Drawing.Size(132, 56)
        Me.fuelTank.TabIndex = 34
        Me.fuelTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D
        Me.fuelTank.Value = 9
        '
        'engineThermometer
        '
        Me.engineThermometer.AutoDivisionSpacing = False
        Me.engineThermometer.Caption = "Engine Temp"
        Me.engineThermometer.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.engineThermometer.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.engineThermometer.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.engineThermometer.Location = New System.Drawing.Point(497, 5)
        Me.engineThermometer.MajorDivisions.Interval = 100
        Me.engineThermometer.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0�F")
        Me.engineThermometer.MinorDivisions.Interval = 50
        Me.engineThermometer.Name = "engineThermometer"
        Me.engineThermometer.Range = New NationalInstruments.UI.Range(0, 700)
        Me.engineThermometer.Size = New System.Drawing.Size(96, 180)
        Me.engineThermometer.TabIndex = 33
        '
        'airspeedGauge
        '
        Me.airspeedGauge.AutoDivisionSpacing = False
        Me.airspeedGauge.ImmediateUpdates = True
        Me.airspeedGauge.Location = New System.Drawing.Point(5, 9)
        Me.airspeedGauge.MajorDivisions.Interval = 10
        Me.airspeedGauge.MinorDivisions.Interval = 5
        Me.airspeedGauge.Name = "airspeedGauge"
        Me.airspeedGauge.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.airspeedGauge.Range = New NationalInstruments.UI.Range(0, 110)
        Me.airspeedGauge.ScaleArc = New NationalInstruments.UI.Arc(90.0!, -323.0!)
        Me.airspeedGauge.Size = New System.Drawing.Size(168, 168)
        Me.airspeedGauge.TabIndex = 32
        '
        'tachMeter
        '
        Me.tachMeter.AutoDivisionSpacing = False
        Me.tachMeter.Location = New System.Drawing.Point(357, 9)
        Me.tachMeter.MajorDivisions.Interval = 1000
        Me.tachMeter.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0,")
        Me.tachMeter.MajorDivisions.LineWidth = 2.0!
        Me.tachMeter.MajorDivisions.TickLength = 7.0!
        Me.tachMeter.MinorDivisions.Interval = 500
        Me.tachMeter.MinorDivisions.TickLength = 5.0!
        Me.tachMeter.Name = "tachMeter"
        Me.tachMeter.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.tachMeter.Range = New NationalInstruments.UI.Range(0, 8000)
        Me.tachMeter.ScaleArc = New NationalInstruments.UI.Arc(224.0!, -263.0!)
        Me.tachMeter.Size = New System.Drawing.Size(132, 112)
        Me.tachMeter.TabIndex = 31
        '
        'altimeterGauge
        '
        Me.altimeterGauge.AutoDivisionSpacing = False
        ScaleCustomDivision5.Value = 10000
        ScaleCustomDivision6.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision6.TickLength = 6.0!
        ScaleCustomDivision6.Value = 500
        ScaleCustomDivision7.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision7.TickLength = 6.0!
        ScaleCustomDivision7.Value = 1500
        ScaleCustomDivision8.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision8.TickLength = 6.0!
        ScaleCustomDivision8.Value = 2500
        ScaleCustomDivision9.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision9.TickLength = 6.0!
        ScaleCustomDivision9.Value = 3500
        ScaleCustomDivision10.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision10.TickLength = 6.0!
        ScaleCustomDivision10.Value = 4500
        ScaleCustomDivision11.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision11.TickLength = 6.0!
        ScaleCustomDivision11.Value = 5500
        ScaleCustomDivision12.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision12.TickLength = 6.0!
        ScaleCustomDivision12.Value = 6500
        ScaleCustomDivision13.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision13.TickLength = 6.0!
        ScaleCustomDivision13.Value = 7500
        ScaleCustomDivision14.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision14.TickLength = 6.0!
        ScaleCustomDivision14.Value = 8500
        ScaleCustomDivision15.TickColor = System.Drawing.SystemColors.ControlText
        ScaleCustomDivision15.TickLength = 6.0!
        ScaleCustomDivision15.Value = 9500
        Me.altimeterGauge.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision5, ScaleCustomDivision6, ScaleCustomDivision7, ScaleCustomDivision8, ScaleCustomDivision9, ScaleCustomDivision10, ScaleCustomDivision11, ScaleCustomDivision12, ScaleCustomDivision13, ScaleCustomDivision14, ScaleCustomDivision15})
        Me.altimeterGauge.ImmediateUpdates = True
        Me.altimeterGauge.Location = New System.Drawing.Point(181, 9)
        Me.altimeterGauge.MajorDivisions.Interval = 1000
        Me.altimeterGauge.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0,")
        Me.altimeterGauge.MajorDivisions.LineWidth = 2.0!
        Me.altimeterGauge.MajorDivisions.TickLength = 7.0!
        Me.altimeterGauge.MinorDivisions.Interval = 100
        Me.altimeterGauge.Name = "altimeterGauge"
        Me.altimeterGauge.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.altimeterGauge.Range = New NationalInstruments.UI.Range(0, 10000)
        Me.altimeterGauge.ScaleArc = New NationalInstruments.UI.Arc(90.0!, -360.0!)
        Me.altimeterGauge.Size = New System.Drawing.Size(168, 168)
        Me.altimeterGauge.TabIndex = 35
        '
        'landingLightsKnob
        '
        Me.landingLightsKnob.Caption = "Landing Lights"
        Me.landingLightsKnob.CaptionBackColor = System.Drawing.SystemColors.Control
        Me.landingLightsKnob.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.landingLightsKnob.CaptionForeColor = System.Drawing.SystemColors.ControlText
        Me.landingLightsKnob.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom
        Me.landingLightsKnob.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions
        ScaleCustomDivision16.Text = "Off"
        ScaleCustomDivision17.Text = "Low"
        ScaleCustomDivision17.Value = 1
        ScaleCustomDivision18.Text = "Med"
        ScaleCustomDivision18.Value = 2
        ScaleCustomDivision19.Text = "High"
        ScaleCustomDivision19.Value = 3
        Me.landingLightsKnob.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision16, ScaleCustomDivision17, ScaleCustomDivision18, ScaleCustomDivision19})
        Me.landingLightsKnob.InteractionMode = NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer
        Me.landingLightsKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle3D
        Me.landingLightsKnob.Location = New System.Drawing.Point(129, 161)
        Me.landingLightsKnob.MajorDivisions.LabelVisible = False
        Me.landingLightsKnob.MajorDivisions.TickVisible = False
        Me.landingLightsKnob.MinorDivisions.TickVisible = False
        Me.landingLightsKnob.Name = "landingLightsKnob"
        Me.landingLightsKnob.PointerColor = System.Drawing.SystemColors.ControlText
        Me.landingLightsKnob.Range = New NationalInstruments.UI.Range(0, 3)
        Me.landingLightsKnob.ScaleArc = New NationalInstruments.UI.Arc(232.0!, -285.0!)
        Me.landingLightsKnob.Size = New System.Drawing.Size(176, 180)
        Me.landingLightsKnob.TabIndex = 46
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(602, 347)
        Me.Controls.Add(Me.landingLightsStatusTextBox)
        Me.Controls.Add(Me.gphStatusTextBox)
        Me.Controls.Add(Me.altitude1000Label)
        Me.Controls.Add(Me.altitudeLabel)
        Me.Controls.Add(Me.throttleSlide)
        Me.Controls.Add(Me.gphLabel)
        Me.Controls.Add(Me.throttleLabel)
        Me.Controls.Add(Me.landingLightsLabel)
        Me.Controls.Add(Me.startLabel)
        Me.Controls.Add(Me.startSwitch)
        Me.Controls.Add(Me.offLabel)
        Me.Controls.Add(Me.onLabel)
        Me.Controls.Add(Me.masterLabel)
        Me.Controls.Add(Me.masterSwitch)
        Me.Controls.Add(Me.rpm1000Label)
        Me.Controls.Add(Me.mphLabel)
        Me.Controls.Add(Me.airspeedLabel)
        Me.Controls.Add(Me.rpmLabel)
        Me.Controls.Add(Me.fuelTank)
        Me.Controls.Add(Me.engineThermometer)
        Me.Controls.Add(Me.airspeedGauge)
        Me.Controls.Add(Me.tachMeter)
        Me.Controls.Add(Me.altimeterGauge)
        Me.Controls.Add(Me.landingLightsKnob)
        Me.Controls.Add(Me.throttleStatusTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Advanced"
        CType(Me.throttleSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.masterSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fuelTank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.engineThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.airspeedGauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tachMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.altimeterGauge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.landingLightsKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub UpdateEngineStatus(ByVal throttle As Double)
        If (engineRunning) Then
            throttleStatusTextBox.BackColor = Color.Lime
            If (throttle = 0) Then
                throttleStatusTextBox.Text = "Idle"
            Else
                throttleStatusTextBox.Text = String.Format("{0:0}%", throttle)
            End If
        End If
    End Sub

    Private Sub ResetGauges()
        tachMeter.Value = 0
        airspeedGauge.Value = 0
        altimeterGauge.Value = 0
        engineThermometer.Value = 0
        throttleStatusTextBox.BackColor = Color.Red
        throttleStatusTextBox.Text = "OFF"
        gphStatusTextBox.BackColor = Color.Lime
        gphStatusTextBox.Text = "0"
    End Sub


    Private Sub throttleSlide_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles throttleSlide.AfterChangeValue
        UpdateEngineStatus(e.NewValue)
    End Sub

    Private Sub landingLightsKnob_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles landingLightsKnob.AfterChangeValue
        Select Case e.NewValue
            Case 0
                landingLightsStatusTextBox.BackColor = Color.Red
                landingLightsStatusTextBox.Text = "OFF"
            Case 1
                landingLightsStatusTextBox.BackColor = Color.Lime
                landingLightsStatusTextBox.Text = "Low"
            Case 2
                landingLightsStatusTextBox.BackColor = Color.Lime
                landingLightsStatusTextBox.Text = "Med"
            Case 3
                landingLightsStatusTextBox.BackColor = Color.Lime
                landingLightsStatusTextBox.Text = "High"
        End Select
    End Sub

    Private Sub startSwitch_StateChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.ActionEventArgs) Handles startSwitch.StateChanged
        If (startSwitch.Value) Then
            engineRunning = True
            UpdateEngineStatus(throttleSlide.Value)
        End If
    End Sub

    Private Sub masterSwitch_StateChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.ActionEventArgs) Handles masterSwitch.StateChanged
        If Not (masterSwitch.Value) Then
            engineRunning = False
            startSwitch.Enabled = False
            ResetGauges()
        Else
            startSwitch.Enabled = True
        End If
    End Sub

    Private Sub sampleTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sampleTimer.Tick
        If (engineRunning) Then
            Dim throttlePercent As Double = throttleSlide.Value / 100
            tachMeter.Value = (6000 * throttlePercent) + 1000 + (rand.Next(-100, 100))
            airspeedGauge.Value = airspeedGauge.Value + ((throttlePercent * 100) - airspeedGauge.Value) * 0.4 + rand.Next(-3, 3)
            altimeterGauge.Value = altimeterGauge.Value + ((throttlePercent * 7000) - altimeterGauge.Value) * 0.2 + rand.Next(-30, 30)
            engineThermometer.Value = engineThermometer.Value + (350 - engineThermometer.Value) * 0.1

            Dim gph As Double = (5 * throttlePercent) + 1
            If (gph > 5) Then
                gphStatusTextBox.BackColor = Color.Red
            Else
                gphStatusTextBox.BackColor = Color.Lime
            End If

            gphStatusTextBox.Text = String.Format("{0:F2}", gph)
            fuelTank.Value -= gph / 3600 'convert to gallons per second.

        End If
    End Sub
End Class
