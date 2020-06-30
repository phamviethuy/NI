Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Private radialNumericPointers() As RadialNumericPointer
    Private linearNumericPointers() As LinearNumericPointer

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        AddHandler radialInteractionModeCheckedListBox.ItemCheck, AddressOf OnRadialInteractionModeItemCheck
        AddHandler radialCoercionModeComboBox.SelectedIndexChanged, AddressOf OnRadialCoercionModeSelectedIndexChanged
        AddHandler radialCoercionIntervalNumericEdit.AfterChangeValue, AddressOf OnRadialCoercionIntervalAfterChangeValue
        AddHandler radialCoercionIntervalBaseNumericEdit.AfterChangeValue, AddressOf OnRadialCoercionIntervalBaseAfterChangeValue
        AddHandler radialMovePreviousButton.Click, AddressOf OnRadialMovePreviousClick
        AddHandler radialMoveNextButton.Click, AddressOf OnRadialMoveNextClick

        AddHandler linearInteractionModeCheckedListBox.ItemCheck, AddressOf OnLinearInteractionModeItemCheck
        AddHandler linearCoercionModeComboBox.SelectedIndexChanged, AddressOf OnLinearCoercionModeSelectedIndexChanged
        AddHandler linearCoercionIntervalNumericEdit.AfterChangeValue, AddressOf OnLinearCoercionIntervalAfterChangeValue
        AddHandler linearCoercionIntervalBaseNumericEdit.AfterChangeValue, AddressOf OnLinearCoercionIntervalBaseAfterChangeValue
        AddHandler linearMovePreviousButton.Click, AddressOf OnLinearMovePreviousClick
        AddHandler linearMoveNextButton.Click, AddressOf OnLinearMoveNextClick

        radialNumericPointers = New RadialNumericPointer(2) {sampleGauge, sampleKnob, sampleMeter}
        linearNumericPointers = New LinearNumericPointer(2) {sampleSlide, sampleTank, sampleThermometer}

        Dim defaultRadialInteractionMode As RadialNumericPointerInteractionModes = RadialNumericPointerInteractionModes.DragPointer Or RadialNumericPointerInteractionModes.SnapPointer
        Dim defaultLinearInteractionMode As LinearNumericPointerInteractionModes = LinearNumericPointerInteractionModes.DragPointer Or LinearNumericPointerInteractionModes.SnapPointer
        Dim defaultCoercionMode As NumericCoercionMode = NumericCoercionMode.None
        Dim defaultCoercionIntervalBase As Double = 0
        Dim defaultCoercionInterval As Double = 2

        Dim radialNumericPointer As RadialNumericPointer
        For Each radialNumericPointer In radialNumericPointers
            radialNumericPointer.InteractionMode = defaultRadialInteractionMode
            radialNumericPointer.CoercionMode = defaultCoercionMode
            radialNumericPointer.CoercionIntervalBase = defaultCoercionIntervalBase
            radialNumericPointer.CoercionInterval = defaultCoercionInterval
            AddHandler radialNumericPointer.Enter, AddressOf OnRadialNumericPointerEnter
        Next

        Dim linearNumericPointer As LinearNumericPointer
        For Each linearNumericPointer In linearNumericPointers
            linearNumericPointer.InteractionMode = defaultLinearInteractionMode
            linearNumericPointer.CoercionMode = defaultCoercionMode
            linearNumericPointer.CoercionIntervalBase = defaultCoercionIntervalBase
            linearNumericPointer.CoercionInterval = defaultCoercionInterval
            AddHandler linearNumericPointer.Enter, AddressOf OnLinearNumericPointerEnter
        Next

        radialInteractionModeCheckedListBox.Items.AddRange([Enum].GetNames(GetType(RadialNumericPointerInteractionModes)))
        radialInteractionModeCheckedListBox.Items.Remove([Enum].GetName(GetType(RadialNumericPointerInteractionModes), RadialNumericPointerInteractionModes.Indicator))

        Dim i As Integer
        For i = 0 To radialInteractionModeCheckedListBox.Items.Count - 1
            Dim mode As RadialNumericPointerInteractionModes = CType([Enum].Parse(GetType(RadialNumericPointerInteractionModes), CType(radialInteractionModeCheckedListBox.Items(i), String)), RadialNumericPointerInteractionModes)
            If (mode And defaultRadialInteractionMode) = mode Then
                radialInteractionModeCheckedListBox.SetItemChecked(i, True)
            Else
                radialInteractionModeCheckedListBox.SetItemChecked(i, False)
            End If
        Next

        linearInteractionModeCheckedListBox.Items.AddRange([Enum].GetNames(GetType(LinearNumericPointerInteractionModes)))
        linearInteractionModeCheckedListBox.Items.Remove([Enum].GetName(GetType(LinearNumericPointerInteractionModes), LinearNumericPointerInteractionModes.Indicator))

        For i = 0 To linearInteractionModeCheckedListBox.Items.Count - 1
            Dim mode As LinearNumericPointerInteractionModes = CType([Enum].Parse(GetType(LinearNumericPointerInteractionModes), CType(linearInteractionModeCheckedListBox.Items(i), String)), LinearNumericPointerInteractionModes)
            If (mode And defaultLinearInteractionMode) = mode Then
                linearInteractionModeCheckedListBox.SetItemChecked(i, True)
            Else
                linearInteractionModeCheckedListBox.SetItemChecked(i, False)
            End If
        Next

        Dim coercionModes() As String = EnumObject.GetNames(GetType(NumericCoercionMode))
        radialCoercionModeComboBox.Sorted = True
        radialCoercionModeComboBox.Items.AddRange(coercionModes)
        radialCoercionModeComboBox.SelectedItem = defaultCoercionMode.Name

        linearCoercionModeComboBox.Sorted = True
        linearCoercionModeComboBox.Items.AddRange(coercionModes)
        linearCoercionModeComboBox.SelectedItem = defaultCoercionMode.Name

        radialCoercionIntervalBaseNumericEdit.Value = defaultCoercionIntervalBase
        radialCoercionIntervalNumericEdit.Value = defaultCoercionInterval

        UpdateRadialCoercionModePanels()

        linearCoercionIntervalBaseNumericEdit.Value = defaultCoercionIntervalBase
        linearCoercionIntervalNumericEdit.Value = defaultCoercionInterval

        UpdateLinearCoercionModePanels()

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                Dim radialNumericPointer As NumericPointer
                For Each radialNumericPointer In radialNumericPointers
                    RemoveHandler radialNumericPointer.Enter, AddressOf OnRadialNumericPointerEnter
                Next

                Dim linearNumericPointer As NumericPointer
                For Each linearNumericPointer In linearNumericPointers
                    RemoveHandler linearNumericPointer.Enter, AddressOf OnLinearNumericPointerEnter
                Next

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
    Friend WithEvents linearGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents linearSettingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents linearInteractionModesLabel As System.Windows.Forms.Label
    Friend WithEvents linearCoercionModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents linearCoercionModeLabel As System.Windows.Forms.Label
    Friend WithEvents linearInteractionModeCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents linearCoercionIntervalPanel As System.Windows.Forms.Panel
    Friend WithEvents linearCoercionIntervalLabel As System.Windows.Forms.Label
    Friend WithEvents linearCoercionIntervalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents linearCoercionIntervalBasePanel As System.Windows.Forms.Panel
    Friend WithEvents linearCoercionIntervalBaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents linearCoercionIntervalBaseLabel As System.Windows.Forms.Label
    Friend WithEvents linearValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents linearValueLabel As System.Windows.Forms.Label
    Friend WithEvents linearMovePreviousButton As System.Windows.Forms.Button
    Friend WithEvents linearMoveNextButton As System.Windows.Forms.Button
    Friend WithEvents sampleSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents sampleThermometer As NationalInstruments.UI.WindowsForms.Thermometer
    Friend WithEvents sampleTank As NationalInstruments.UI.WindowsForms.Tank
    Friend WithEvents radialGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents sampleMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents sampleKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents sampleGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents radialSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents radialInteractionModesLabel As System.Windows.Forms.Label
    Friend WithEvents radialCoercionModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents radialCoercionModeLabel As System.Windows.Forms.Label
    Friend WithEvents radialInteractionModeCheckedListBox As System.Windows.Forms.CheckedListBox
    Friend WithEvents radialCoercionIntervalPanel As System.Windows.Forms.Panel
    Friend WithEvents radialCoercionIntervalLabel As System.Windows.Forms.Label
    Friend WithEvents radialCoercionIntervalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents radialCoercionIntervalBasePanel As System.Windows.Forms.Panel
    Friend WithEvents radialCoercionIntervalBaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents radialCoercionIntervalBaseLabel As System.Windows.Forms.Label
    Friend WithEvents radialValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents radialValueLabel As System.Windows.Forms.Label
    Friend WithEvents radialMovePreviousButton As System.Windows.Forms.Button
    Friend WithEvents radialMoveNextButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ScaleCustomDivision1 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision2 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.linearGroupBox = New System.Windows.Forms.GroupBox
        Me.linearSettingGroupBox = New System.Windows.Forms.GroupBox
        Me.linearInteractionModesLabel = New System.Windows.Forms.Label
        Me.linearCoercionModeComboBox = New System.Windows.Forms.ComboBox
        Me.linearCoercionModeLabel = New System.Windows.Forms.Label
        Me.linearInteractionModeCheckedListBox = New System.Windows.Forms.CheckedListBox
        Me.linearCoercionIntervalPanel = New System.Windows.Forms.Panel
        Me.linearCoercionIntervalLabel = New System.Windows.Forms.Label
        Me.linearCoercionIntervalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.linearCoercionIntervalBasePanel = New System.Windows.Forms.Panel
        Me.linearCoercionIntervalBaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.linearCoercionIntervalBaseLabel = New System.Windows.Forms.Label
        Me.linearValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.linearValueLabel = New System.Windows.Forms.Label
        Me.linearMovePreviousButton = New System.Windows.Forms.Button
        Me.linearMoveNextButton = New System.Windows.Forms.Button
        Me.sampleSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.sampleThermometer = New NationalInstruments.UI.WindowsForms.Thermometer
        Me.sampleTank = New NationalInstruments.UI.WindowsForms.Tank
        Me.radialGroupBox = New System.Windows.Forms.GroupBox
        Me.sampleMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.sampleKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.sampleGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.radialSettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.radialInteractionModesLabel = New System.Windows.Forms.Label
        Me.radialCoercionModeComboBox = New System.Windows.Forms.ComboBox
        Me.radialCoercionModeLabel = New System.Windows.Forms.Label
        Me.radialInteractionModeCheckedListBox = New System.Windows.Forms.CheckedListBox
        Me.radialCoercionIntervalPanel = New System.Windows.Forms.Panel
        Me.radialCoercionIntervalLabel = New System.Windows.Forms.Label
        Me.radialCoercionIntervalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.radialCoercionIntervalBasePanel = New System.Windows.Forms.Panel
        Me.radialCoercionIntervalBaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.radialCoercionIntervalBaseLabel = New System.Windows.Forms.Label
        Me.radialValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.radialValueLabel = New System.Windows.Forms.Label
        Me.radialMovePreviousButton = New System.Windows.Forms.Button
        Me.radialMoveNextButton = New System.Windows.Forms.Button
        Me.linearGroupBox.SuspendLayout()
        Me.linearSettingGroupBox.SuspendLayout()
        Me.linearCoercionIntervalPanel.SuspendLayout()
        CType(Me.linearCoercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.linearCoercionIntervalBasePanel.SuspendLayout()
        CType(Me.linearCoercionIntervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linearValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleThermometer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleTank, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radialGroupBox.SuspendLayout()
        CType(Me.sampleMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radialSettingsGroupBox.SuspendLayout()
        Me.radialCoercionIntervalPanel.SuspendLayout()
        CType(Me.radialCoercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.radialCoercionIntervalBasePanel.SuspendLayout()
        CType(Me.radialCoercionIntervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.radialValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'linearGroupBox
        '
        Me.linearGroupBox.Controls.Add(Me.linearSettingGroupBox)
        Me.linearGroupBox.Controls.Add(Me.sampleSlide)
        Me.linearGroupBox.Controls.Add(Me.sampleThermometer)
        Me.linearGroupBox.Controls.Add(Me.sampleTank)
        Me.linearGroupBox.Location = New System.Drawing.Point(361, 9)
        Me.linearGroupBox.Name = "linearGroupBox"
        Me.linearGroupBox.Size = New System.Drawing.Size(299, 595)
        Me.linearGroupBox.TabIndex = 20
        Me.linearGroupBox.TabStop = False
        Me.linearGroupBox.Text = "Linear"
        '
        'linearSettingGroupBox
        '
        Me.linearSettingGroupBox.Controls.Add(Me.linearInteractionModesLabel)
        Me.linearSettingGroupBox.Controls.Add(Me.linearCoercionModeComboBox)
        Me.linearSettingGroupBox.Controls.Add(Me.linearCoercionModeLabel)
        Me.linearSettingGroupBox.Controls.Add(Me.linearInteractionModeCheckedListBox)
        Me.linearSettingGroupBox.Controls.Add(Me.linearCoercionIntervalPanel)
        Me.linearSettingGroupBox.Controls.Add(Me.linearCoercionIntervalBasePanel)
        Me.linearSettingGroupBox.Controls.Add(Me.linearValueNumericEdit)
        Me.linearSettingGroupBox.Controls.Add(Me.linearValueLabel)
        Me.linearSettingGroupBox.Controls.Add(Me.linearMovePreviousButton)
        Me.linearSettingGroupBox.Controls.Add(Me.linearMoveNextButton)
        Me.linearSettingGroupBox.Location = New System.Drawing.Point(9, 386)
        Me.linearSettingGroupBox.Name = "linearSettingGroupBox"
        Me.linearSettingGroupBox.Size = New System.Drawing.Size(281, 201)
        Me.linearSettingGroupBox.TabIndex = 6
        Me.linearSettingGroupBox.TabStop = False
        Me.linearSettingGroupBox.Text = "Settings"
        '
        'linearInteractionModesLabel
        '
        Me.linearInteractionModesLabel.AutoSize = True
        Me.linearInteractionModesLabel.Location = New System.Drawing.Point(9, 77)
        Me.linearInteractionModesLabel.Name = "linearInteractionModesLabel"
        Me.linearInteractionModesLabel.Size = New System.Drawing.Size(95, 13)
        Me.linearInteractionModesLabel.TabIndex = 23
        Me.linearInteractionModesLabel.Text = "Interaction Modes:"
        '
        'linearCoercionModeComboBox
        '
        Me.linearCoercionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.linearCoercionModeComboBox.Location = New System.Drawing.Point(146, 44)
        Me.linearCoercionModeComboBox.Name = "linearCoercionModeComboBox"
        Me.linearCoercionModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.linearCoercionModeComboBox.TabIndex = 19
        '
        'linearCoercionModeLabel
        '
        Me.linearCoercionModeLabel.AutoSize = True
        Me.linearCoercionModeLabel.Location = New System.Drawing.Point(144, 25)
        Me.linearCoercionModeLabel.Name = "linearCoercionModeLabel"
        Me.linearCoercionModeLabel.Size = New System.Drawing.Size(82, 13)
        Me.linearCoercionModeLabel.TabIndex = 22
        Me.linearCoercionModeLabel.Text = "Coercion Mode:"
        '
        'linearInteractionModeCheckedListBox
        '
        Me.linearInteractionModeCheckedListBox.CheckOnClick = True
        Me.linearInteractionModeCheckedListBox.Location = New System.Drawing.Point(11, 96)
        Me.linearInteractionModeCheckedListBox.Name = "linearInteractionModeCheckedListBox"
        Me.linearInteractionModeCheckedListBox.Size = New System.Drawing.Size(113, 79)
        Me.linearInteractionModeCheckedListBox.TabIndex = 18
        '
        'linearCoercionIntervalPanel
        '
        Me.linearCoercionIntervalPanel.Controls.Add(Me.linearCoercionIntervalLabel)
        Me.linearCoercionIntervalPanel.Controls.Add(Me.linearCoercionIntervalNumericEdit)
        Me.linearCoercionIntervalPanel.Location = New System.Drawing.Point(137, 71)
        Me.linearCoercionIntervalPanel.Name = "linearCoercionIntervalPanel"
        Me.linearCoercionIntervalPanel.Size = New System.Drawing.Size(137, 52)
        Me.linearCoercionIntervalPanel.TabIndex = 20
        '
        'linearCoercionIntervalLabel
        '
        Me.linearCoercionIntervalLabel.AutoSize = True
        Me.linearCoercionIntervalLabel.Location = New System.Drawing.Point(8, 6)
        Me.linearCoercionIntervalLabel.Name = "linearCoercionIntervalLabel"
        Me.linearCoercionIntervalLabel.Size = New System.Drawing.Size(90, 13)
        Me.linearCoercionIntervalLabel.TabIndex = 1
        Me.linearCoercionIntervalLabel.Text = "Coercion Interval:"
        '
        'linearCoercionIntervalNumericEdit
        '
        Me.linearCoercionIntervalNumericEdit.Location = New System.Drawing.Point(10, 25)
        Me.linearCoercionIntervalNumericEdit.Name = "linearCoercionIntervalNumericEdit"
        Me.linearCoercionIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.linearCoercionIntervalNumericEdit.Range = New NationalInstruments.UI.Range(0.001, 10)
        Me.linearCoercionIntervalNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.linearCoercionIntervalNumericEdit.TabIndex = 0
        Me.linearCoercionIntervalNumericEdit.Value = 0.001
        '
        'linearCoercionIntervalBasePanel
        '
        Me.linearCoercionIntervalBasePanel.Controls.Add(Me.linearCoercionIntervalBaseNumericEdit)
        Me.linearCoercionIntervalBasePanel.Controls.Add(Me.linearCoercionIntervalBaseLabel)
        Me.linearCoercionIntervalBasePanel.Location = New System.Drawing.Point(136, 130)
        Me.linearCoercionIntervalBasePanel.Name = "linearCoercionIntervalBasePanel"
        Me.linearCoercionIntervalBasePanel.Size = New System.Drawing.Size(140, 52)
        Me.linearCoercionIntervalBasePanel.TabIndex = 21
        '
        'linearCoercionIntervalBaseNumericEdit
        '
        Me.linearCoercionIntervalBaseNumericEdit.Location = New System.Drawing.Point(11, 25)
        Me.linearCoercionIntervalBaseNumericEdit.Name = "linearCoercionIntervalBaseNumericEdit"
        Me.linearCoercionIntervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.linearCoercionIntervalBaseNumericEdit.Range = New NationalInstruments.UI.Range(-10, 10)
        Me.linearCoercionIntervalBaseNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.linearCoercionIntervalBaseNumericEdit.TabIndex = 0
        '
        'linearCoercionIntervalBaseLabel
        '
        Me.linearCoercionIntervalBaseLabel.AutoSize = True
        Me.linearCoercionIntervalBaseLabel.Location = New System.Drawing.Point(8, 6)
        Me.linearCoercionIntervalBaseLabel.Name = "linearCoercionIntervalBaseLabel"
        Me.linearCoercionIntervalBaseLabel.Size = New System.Drawing.Size(117, 13)
        Me.linearCoercionIntervalBaseLabel.TabIndex = 1
        Me.linearCoercionIntervalBaseLabel.Text = "Coercion Interval Base:"
        '
        'linearValueNumericEdit
        '
        Me.linearValueNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.linearValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.linearValueNumericEdit.Location = New System.Drawing.Point(40, 47)
        Me.linearValueNumericEdit.Name = "linearValueNumericEdit"
        Me.linearValueNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.linearValueNumericEdit.TabIndex = 24
        '
        'linearValueLabel
        '
        Me.linearValueLabel.AutoSize = True
        Me.linearValueLabel.Location = New System.Drawing.Point(40, 27)
        Me.linearValueLabel.Name = "linearValueLabel"
        Me.linearValueLabel.Size = New System.Drawing.Size(37, 13)
        Me.linearValueLabel.TabIndex = 25
        Me.linearValueLabel.Text = "Value:"
        '
        'linearMovePreviousButton
        '
        Me.linearMovePreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.linearMovePreviousButton.Location = New System.Drawing.Point(11, 44)
        Me.linearMovePreviousButton.Name = "linearMovePreviousButton"
        Me.linearMovePreviousButton.Size = New System.Drawing.Size(26, 21)
        Me.linearMovePreviousButton.TabIndex = 16
        Me.linearMovePreviousButton.Text = "<"
        '
        'linearMoveNextButton
        '
        Me.linearMoveNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.linearMoveNextButton.Location = New System.Drawing.Point(99, 46)
        Me.linearMoveNextButton.Name = "linearMoveNextButton"
        Me.linearMoveNextButton.Size = New System.Drawing.Size(26, 21)
        Me.linearMoveNextButton.TabIndex = 17
        Me.linearMoveNextButton.Text = ">"
        '
        'sampleSlide
        '
        Me.sampleSlide.Border = NationalInstruments.UI.Border.Etched
        Me.sampleSlide.CanShowFocus = True
        Me.sampleSlide.Caption = "Slide"
        ScaleCustomDivision1.LabelForeColor = System.Drawing.SystemColors.ControlDarkDark
        ScaleCustomDivision1.Text = "Two"
        ScaleCustomDivision1.TickColor = System.Drawing.SystemColors.ControlDarkDark
        ScaleCustomDivision1.Value = 2
        ScaleCustomDivision2.DisplayStyle = NationalInstruments.UI.CustomDivisionDisplayStyle.ShowValue
        ScaleCustomDivision2.LabelForeColor = System.Drawing.SystemColors.ControlDarkDark
        ScaleCustomDivision2.TickColor = System.Drawing.SystemColors.ControlDarkDark
        ScaleCustomDivision2.Value = 6.5
        Me.sampleSlide.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision1, ScaleCustomDivision2})
        Me.sampleSlide.Location = New System.Drawing.Point(8, 18)
        Me.sampleSlide.Name = "sampleSlide"
        Me.sampleSlide.Size = New System.Drawing.Size(74, 358)
        Me.sampleSlide.TabIndex = 3
        '
        'sampleThermometer
        '
        Me.sampleThermometer.Border = NationalInstruments.UI.Border.Etched
        Me.sampleThermometer.CanShowFocus = True
        Me.sampleThermometer.Caption = "Thermometer"
        Me.sampleThermometer.Location = New System.Drawing.Point(207, 18)
        Me.sampleThermometer.Name = "sampleThermometer"
        Me.sampleThermometer.Range = New NationalInstruments.UI.Range(0, 10)
        Me.sampleThermometer.Size = New System.Drawing.Size(83, 358)
        Me.sampleThermometer.TabIndex = 5
        '
        'sampleTank
        '
        Me.sampleTank.Border = NationalInstruments.UI.Border.Etched
        Me.sampleTank.CanShowFocus = True
        Me.sampleTank.Caption = "Tank"
        Me.sampleTank.Location = New System.Drawing.Point(90, 18)
        Me.sampleTank.Name = "sampleTank"
        Me.sampleTank.Size = New System.Drawing.Size(110, 358)
        Me.sampleTank.TabIndex = 4
        '
        'radialGroupBox
        '
        Me.radialGroupBox.Controls.Add(Me.sampleMeter)
        Me.radialGroupBox.Controls.Add(Me.sampleKnob)
        Me.radialGroupBox.Controls.Add(Me.sampleGauge)
        Me.radialGroupBox.Controls.Add(Me.radialSettingsGroupBox)
        Me.radialGroupBox.Location = New System.Drawing.Point(8, 9)
        Me.radialGroupBox.Name = "radialGroupBox"
        Me.radialGroupBox.Size = New System.Drawing.Size(341, 594)
        Me.radialGroupBox.TabIndex = 19
        Me.radialGroupBox.TabStop = False
        Me.radialGroupBox.Text = "Radial"
        '
        'sampleMeter
        '
        Me.sampleMeter.Border = NationalInstruments.UI.Border.Etched
        Me.sampleMeter.CanShowFocus = True
        Me.sampleMeter.Caption = "Meter"
        Me.sampleMeter.Location = New System.Drawing.Point(8, 220)
        Me.sampleMeter.Name = "sampleMeter"
        Me.sampleMeter.Size = New System.Drawing.Size(324, 156)
        Me.sampleMeter.TabIndex = 2
        '
        'sampleKnob
        '
        Me.sampleKnob.Border = NationalInstruments.UI.Border.Etched
        Me.sampleKnob.CanShowFocus = True
        Me.sampleKnob.Caption = "Knob"
        Me.sampleKnob.Location = New System.Drawing.Point(160, 18)
        Me.sampleKnob.Name = "sampleKnob"
        Me.sampleKnob.Size = New System.Drawing.Size(173, 197)
        Me.sampleKnob.TabIndex = 1
        '
        'sampleGauge
        '
        Me.sampleGauge.Border = NationalInstruments.UI.Border.Etched
        Me.sampleGauge.CanShowFocus = True
        Me.sampleGauge.Caption = "Gauge"
        Me.sampleGauge.Location = New System.Drawing.Point(8, 18)
        Me.sampleGauge.Name = "sampleGauge"
        Me.sampleGauge.Range = New NationalInstruments.UI.Range(0, 100)
        Me.sampleGauge.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.sampleGauge.Size = New System.Drawing.Size(146, 197)
        Me.sampleGauge.TabIndex = 0
        '
        'radialSettingsGroupBox
        '
        Me.radialSettingsGroupBox.Controls.Add(Me.radialInteractionModesLabel)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialCoercionModeComboBox)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialCoercionModeLabel)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialInteractionModeCheckedListBox)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialCoercionIntervalPanel)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialCoercionIntervalBasePanel)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialValueNumericEdit)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialValueLabel)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialMovePreviousButton)
        Me.radialSettingsGroupBox.Controls.Add(Me.radialMoveNextButton)
        Me.radialSettingsGroupBox.Location = New System.Drawing.Point(8, 386)
        Me.radialSettingsGroupBox.Name = "radialSettingsGroupBox"
        Me.radialSettingsGroupBox.Size = New System.Drawing.Size(325, 198)
        Me.radialSettingsGroupBox.TabIndex = 16
        Me.radialSettingsGroupBox.TabStop = False
        Me.radialSettingsGroupBox.Text = "Settings"
        '
        'radialInteractionModesLabel
        '
        Me.radialInteractionModesLabel.AutoSize = True
        Me.radialInteractionModesLabel.Location = New System.Drawing.Point(21, 76)
        Me.radialInteractionModesLabel.Name = "radialInteractionModesLabel"
        Me.radialInteractionModesLabel.Size = New System.Drawing.Size(95, 13)
        Me.radialInteractionModesLabel.TabIndex = 13
        Me.radialInteractionModesLabel.Text = "Interaction Modes:"
        '
        'radialCoercionModeComboBox
        '
        Me.radialCoercionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.radialCoercionModeComboBox.Location = New System.Drawing.Point(173, 45)
        Me.radialCoercionModeComboBox.Name = "radialCoercionModeComboBox"
        Me.radialCoercionModeComboBox.Size = New System.Drawing.Size(121, 21)
        Me.radialCoercionModeComboBox.TabIndex = 9
        '
        'radialCoercionModeLabel
        '
        Me.radialCoercionModeLabel.AutoSize = True
        Me.radialCoercionModeLabel.Location = New System.Drawing.Point(171, 26)
        Me.radialCoercionModeLabel.Name = "radialCoercionModeLabel"
        Me.radialCoercionModeLabel.Size = New System.Drawing.Size(82, 13)
        Me.radialCoercionModeLabel.TabIndex = 12
        Me.radialCoercionModeLabel.Text = "Coercion Mode:"
        '
        'radialInteractionModeCheckedListBox
        '
        Me.radialInteractionModeCheckedListBox.CheckOnClick = True
        Me.radialInteractionModeCheckedListBox.Location = New System.Drawing.Point(23, 95)
        Me.radialInteractionModeCheckedListBox.Name = "radialInteractionModeCheckedListBox"
        Me.radialInteractionModeCheckedListBox.Size = New System.Drawing.Size(113, 79)
        Me.radialInteractionModeCheckedListBox.TabIndex = 8
        '
        'radialCoercionIntervalPanel
        '
        Me.radialCoercionIntervalPanel.Controls.Add(Me.radialCoercionIntervalLabel)
        Me.radialCoercionIntervalPanel.Controls.Add(Me.radialCoercionIntervalNumericEdit)
        Me.radialCoercionIntervalPanel.Location = New System.Drawing.Point(164, 70)
        Me.radialCoercionIntervalPanel.Name = "radialCoercionIntervalPanel"
        Me.radialCoercionIntervalPanel.Size = New System.Drawing.Size(137, 52)
        Me.radialCoercionIntervalPanel.TabIndex = 10
        '
        'radialCoercionIntervalLabel
        '
        Me.radialCoercionIntervalLabel.AutoSize = True
        Me.radialCoercionIntervalLabel.Location = New System.Drawing.Point(8, 6)
        Me.radialCoercionIntervalLabel.Name = "radialCoercionIntervalLabel"
        Me.radialCoercionIntervalLabel.Size = New System.Drawing.Size(90, 13)
        Me.radialCoercionIntervalLabel.TabIndex = 1
        Me.radialCoercionIntervalLabel.Text = "Coercion Interval:"
        '
        'radialCoercionIntervalNumericEdit
        '
        Me.radialCoercionIntervalNumericEdit.Location = New System.Drawing.Point(10, 25)
        Me.radialCoercionIntervalNumericEdit.Name = "radialCoercionIntervalNumericEdit"
        Me.radialCoercionIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.radialCoercionIntervalNumericEdit.Range = New NationalInstruments.UI.Range(0.001, 10)
        Me.radialCoercionIntervalNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.radialCoercionIntervalNumericEdit.TabIndex = 0
        Me.radialCoercionIntervalNumericEdit.Value = 0.001
        '
        'radialCoercionIntervalBasePanel
        '
        Me.radialCoercionIntervalBasePanel.Controls.Add(Me.radialCoercionIntervalBaseNumericEdit)
        Me.radialCoercionIntervalBasePanel.Controls.Add(Me.radialCoercionIntervalBaseLabel)
        Me.radialCoercionIntervalBasePanel.Location = New System.Drawing.Point(163, 128)
        Me.radialCoercionIntervalBasePanel.Name = "radialCoercionIntervalBasePanel"
        Me.radialCoercionIntervalBasePanel.Size = New System.Drawing.Size(140, 52)
        Me.radialCoercionIntervalBasePanel.TabIndex = 11
        '
        'radialCoercionIntervalBaseNumericEdit
        '
        Me.radialCoercionIntervalBaseNumericEdit.Location = New System.Drawing.Point(11, 25)
        Me.radialCoercionIntervalBaseNumericEdit.Name = "radialCoercionIntervalBaseNumericEdit"
        Me.radialCoercionIntervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.radialCoercionIntervalBaseNumericEdit.Range = New NationalInstruments.UI.Range(-10, 10)
        Me.radialCoercionIntervalBaseNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.radialCoercionIntervalBaseNumericEdit.TabIndex = 0
        '
        'radialCoercionIntervalBaseLabel
        '
        Me.radialCoercionIntervalBaseLabel.AutoSize = True
        Me.radialCoercionIntervalBaseLabel.Location = New System.Drawing.Point(8, 6)
        Me.radialCoercionIntervalBaseLabel.Name = "radialCoercionIntervalBaseLabel"
        Me.radialCoercionIntervalBaseLabel.Size = New System.Drawing.Size(117, 13)
        Me.radialCoercionIntervalBaseLabel.TabIndex = 1
        Me.radialCoercionIntervalBaseLabel.Text = "Coercion Interval Base:"
        '
        'radialValueNumericEdit
        '
        Me.radialValueNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.radialValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.radialValueNumericEdit.Location = New System.Drawing.Point(52, 45)
        Me.radialValueNumericEdit.Name = "radialValueNumericEdit"
        Me.radialValueNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.radialValueNumericEdit.TabIndex = 14
        '
        'radialValueLabel
        '
        Me.radialValueLabel.AutoSize = True
        Me.radialValueLabel.Location = New System.Drawing.Point(52, 26)
        Me.radialValueLabel.Name = "radialValueLabel"
        Me.radialValueLabel.Size = New System.Drawing.Size(37, 13)
        Me.radialValueLabel.TabIndex = 15
        Me.radialValueLabel.Text = "Value:"
        '
        'radialMovePreviousButton
        '
        Me.radialMovePreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radialMovePreviousButton.Location = New System.Drawing.Point(23, 43)
        Me.radialMovePreviousButton.Name = "radialMovePreviousButton"
        Me.radialMovePreviousButton.Size = New System.Drawing.Size(26, 21)
        Me.radialMovePreviousButton.TabIndex = 6
        Me.radialMovePreviousButton.Text = "<"
        '
        'radialMoveNextButton
        '
        Me.radialMoveNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.radialMoveNextButton.Location = New System.Drawing.Point(111, 45)
        Me.radialMoveNextButton.Name = "radialMoveNextButton"
        Me.radialMoveNextButton.Size = New System.Drawing.Size(26, 21)
        Me.radialMoveNextButton.TabIndex = 7
        Me.radialMoveNextButton.Text = ">"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(668, 613)
        Me.Controls.Add(Me.linearGroupBox)
        Me.Controls.Add(Me.radialGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Interaction"
        Me.linearGroupBox.ResumeLayout(False)
        Me.linearSettingGroupBox.ResumeLayout(False)
        Me.linearSettingGroupBox.PerformLayout()
        Me.linearCoercionIntervalPanel.ResumeLayout(False)
        Me.linearCoercionIntervalPanel.PerformLayout()
        CType(Me.linearCoercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.linearCoercionIntervalBasePanel.ResumeLayout(False)
        Me.linearCoercionIntervalBasePanel.PerformLayout()
        CType(Me.linearCoercionIntervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linearValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleThermometer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleTank, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radialGroupBox.ResumeLayout(False)
        CType(Me.sampleMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleGauge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radialSettingsGroupBox.ResumeLayout(False)
        Me.radialSettingsGroupBox.PerformLayout()
        Me.radialCoercionIntervalPanel.ResumeLayout(False)
        Me.radialCoercionIntervalPanel.PerformLayout()
        CType(Me.radialCoercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.radialCoercionIntervalBasePanel.ResumeLayout(False)
        Me.radialCoercionIntervalBasePanel.PerformLayout()
        CType(Me.radialCoercionIntervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.radialValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub OnRadialInteractionModeItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        Dim interactionMode As RadialNumericPointerInteractionModes = CType([Enum].Parse(GetType(RadialNumericPointerInteractionModes), CType(radialInteractionModeCheckedListBox.Items(e.Index), String)), RadialNumericPointerInteractionModes)
        Dim numericPointer As RadialNumericPointer
        For Each numericPointer In radialNumericPointers
            If e.NewValue = CheckState.Checked Then
                numericPointer.InteractionMode = numericPointer.InteractionMode Or interactionMode
            Else
                numericPointer.InteractionMode = numericPointer.InteractionMode And Not (interactionMode)
            End If
        Next
    End Sub

    Private Sub OnLinearInteractionModeItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        Dim interactionMode As LinearNumericPointerInteractionModes = CType([Enum].Parse(GetType(LinearNumericPointerInteractionModes), CType(linearInteractionModeCheckedListBox.Items(e.Index), String)), LinearNumericPointerInteractionModes)
        Dim numericPointer As LinearNumericPointer
        For Each numericPointer In linearNumericPointers
            If e.NewValue = CheckState.Checked Then
                numericPointer.InteractionMode = numericPointer.InteractionMode Or interactionMode
            Else
                numericPointer.InteractionMode = numericPointer.InteractionMode And Not (interactionMode)
            End If
        Next
    End Sub

    Private Sub OnRadialCoercionModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateCoercionMode(radialNumericPointers, CType(radialCoercionModeComboBox.SelectedItem, String))
        UpdateRadialCoercionModePanels()
    End Sub

    Private Sub OnLinearCoercionModeSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateCoercionMode(linearNumericPointers, CType(linearCoercionModeComboBox.SelectedItem, String))
        UpdateLinearCoercionModePanels()
    End Sub

    Private Shared Sub UpdateCoercionMode(ByVal numericPointers As NumericPointer(), ByVal value As String)
        Dim coercionMode As NumericCoercionMode = CType(EnumObject.Parse(GetType(NumericCoercionMode), value), NumericCoercionMode)
        Dim numericPointer As NumericPointer
        For Each numericPointer In numericPointers
            numericPointer.CoercionMode = coercionMode
        Next
    End Sub

    Private Sub OnRadialCoercionIntervalAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdateCoercionInterval(radialNumericPointers, e.NewValue)
    End Sub

    Private Sub OnLinearCoercionIntervalAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdateCoercionInterval(linearNumericPointers, e.NewValue)
    End Sub

    Private Shared Sub UpdateCoercionInterval(ByVal numericPointers As NumericPointer(), ByVal value As Double)
        Dim numericPointer As NumericPointer
        For Each numericPointer In numericPointers
            numericPointer.CoercionInterval = value
        Next
    End Sub

    Private Sub OnRadialCoercionIntervalBaseAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdateCoercionIntervalBase(radialNumericPointers, e.NewValue)
    End Sub

    Private Sub OnLinearCoercionIntervalBaseAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        UpdateCoercionIntervalBase(linearNumericPointers, e.NewValue)
    End Sub

    Private Shared Sub UpdateCoercionIntervalBase(ByVal numericPointers As NumericPointer(), ByVal value As Double)
        Dim numericPointer As NumericPointer
        For Each numericPointer In numericPointers
            numericPointer.CoercionIntervalBase = value
        Next
    End Sub

    Private Sub OnRadialMovePreviousClick(ByVal sender As Object, ByVal e As EventArgs)
        MovePrevious(radialNumericPointers)
    End Sub

    Private Sub OnLinearMovePreviousClick(ByVal sender As Object, ByVal e As EventArgs)
        MovePrevious(linearNumericPointers)
    End Sub

    Private Shared Sub MovePrevious(ByVal numericPointers As NumericPointer())
        Dim numericPointer As NumericPointer
        For Each numericPointer In numericPointers
            numericPointer.MovePrevious()
        Next
    End Sub

    Private Sub OnRadialMoveNextClick(ByVal sender As Object, ByVal e As EventArgs)
        MoveNext(radialNumericPointers)
    End Sub

    Private Sub OnLinearMoveNextClick(ByVal sender As Object, ByVal e As EventArgs)
        MoveNext(linearNumericPointers)
    End Sub

    Private Shared Sub MoveNext(ByVal numericPointers As NumericPointer())
        Dim numericPointer As NumericPointer
        For Each numericPointer In numericPointers
            numericPointer.MoveNext()
        Next
    End Sub

    Private Sub UpdateRadialCoercionModePanels()
        If radialCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.None.Name) Then
            radialCoercionIntervalPanel.Visible = True
            radialCoercionIntervalBasePanel.Visible = False
        ElseIf radialCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToInterval.Name) Then
            radialCoercionIntervalPanel.Visible = True
            radialCoercionIntervalBasePanel.Visible = True
        ElseIf radialCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToDivisions.Name) Then
            radialCoercionIntervalPanel.Visible = False
            radialCoercionIntervalBasePanel.Visible = False
        End If
    End Sub

    Private Sub UpdateLinearCoercionModePanels()
        If linearCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.None.Name) Then
            linearCoercionIntervalPanel.Visible = True
            linearCoercionIntervalBasePanel.Visible = False
        ElseIf linearCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToInterval.Name) Then
            linearCoercionIntervalPanel.Visible = True
            linearCoercionIntervalBasePanel.Visible = True
        ElseIf linearCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToDivisions.Name) Then
            linearCoercionIntervalPanel.Visible = False
            linearCoercionIntervalBasePanel.Visible = False
        End If
    End Sub

    Private Sub OnRadialNumericPointerEnter(ByVal sender As Object, ByVal e As EventArgs)
        radialValueNumericEdit.Source = CType(sender, INumericValueSource)
    End Sub

    Private Sub OnLinearNumericPointerEnter(ByVal sender As Object, ByVal e As EventArgs)
        linearValueNumericEdit.Source = CType(sender, INumericValueSource)
    End Sub

End Class
