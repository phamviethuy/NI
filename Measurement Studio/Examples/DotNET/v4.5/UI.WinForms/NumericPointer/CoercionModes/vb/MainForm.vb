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

        'Set initial control values
        sampleKnob.CoercionMode = NumericCoercionMode.None
        noneModeRadioButton.Checked = True

        setValueNumericEdit.Value = sampleKnob.Value

        SetCoercedValueNumericEdits()

        enableMajorDivisionsCheckBox.Checked = True
        enableMinorDivisionsCheckBox.Checked = True
        enableCustomDivisionsCheckBox.Checked = True

        intervalBaseNumericEdit.Value = sampleKnob.CoercionIntervalBase
        intervalNumericEdit.Value = sampleKnob.CoercionInterval

        outOfRangeModeComboBox.Items.AddRange([Enum].GetNames(GetType(NumericOutOfRangeMode)))
        outOfRangeModeComboBox.SelectedIndex = outOfRangeModeComboBox.Items.IndexOf(NumericOutOfRangeMode.ThrowException.ToString())
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
    Friend WithEvents outOfRangeModeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents outOfRangeModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents coercionIntervalGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents intervalLabel As System.Windows.Forms.Label
    Friend WithEvents intervalBaseLabel As System.Windows.Forms.Label
    Friend WithEvents intervalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents intervalBaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents divisionsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents enableCustomDivisionsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents enableMinorDivisionsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents enableMajorDivisionsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents coercionModeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents toIntervalModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents toDivisionsModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents noneModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents valuesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents commitButton As System.Windows.Forms.Button
    Friend WithEvents nextValueLabel As System.Windows.Forms.Label
    Friend WithEvents nextValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents previousValueLabel As System.Windows.Forms.Label
    Friend WithEvents previousValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents coercedValueLabel As System.Windows.Forms.Label
    Friend WithEvents coercedValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents setValueLabel As System.Windows.Forms.Label
    Friend WithEvents setValueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents sampleKnob As NationalInstruments.UI.WindowsForms.Knob
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ScaleCustomDivision1 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim ScaleCustomDivision2 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.outOfRangeModeGroupBox = New System.Windows.Forms.GroupBox
        Me.outOfRangeModeComboBox = New System.Windows.Forms.ComboBox
        Me.coercionIntervalGroupBox = New System.Windows.Forms.GroupBox
        Me.intervalLabel = New System.Windows.Forms.Label
        Me.intervalBaseLabel = New System.Windows.Forms.Label
        Me.intervalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.intervalBaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.divisionsGroupBox = New System.Windows.Forms.GroupBox
        Me.enableCustomDivisionsCheckBox = New System.Windows.Forms.CheckBox
        Me.enableMinorDivisionsCheckBox = New System.Windows.Forms.CheckBox
        Me.enableMajorDivisionsCheckBox = New System.Windows.Forms.CheckBox
        Me.coercionModeGroupBox = New System.Windows.Forms.GroupBox
        Me.toIntervalModeRadioButton = New System.Windows.Forms.RadioButton
        Me.toDivisionsModeRadioButton = New System.Windows.Forms.RadioButton
        Me.noneModeRadioButton = New System.Windows.Forms.RadioButton
        Me.valuesGroupBox = New System.Windows.Forms.GroupBox
        Me.commitButton = New System.Windows.Forms.Button
        Me.nextValueLabel = New System.Windows.Forms.Label
        Me.nextValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.previousValueLabel = New System.Windows.Forms.Label
        Me.previousValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.coercedValueLabel = New System.Windows.Forms.Label
        Me.coercedValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.setValueLabel = New System.Windows.Forms.Label
        Me.setValueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sampleKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.outOfRangeModeGroupBox.SuspendLayout()
        Me.coercionIntervalGroupBox.SuspendLayout()
        CType(Me.intervalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.divisionsGroupBox.SuspendLayout()
        Me.coercionModeGroupBox.SuspendLayout()
        Me.valuesGroupBox.SuspendLayout()
        CType(Me.nextValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previousValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coercedValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.setValueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'outOfRangeModeGroupBox
        '
        Me.outOfRangeModeGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.outOfRangeModeGroupBox.Controls.Add(Me.outOfRangeModeComboBox)
        Me.outOfRangeModeGroupBox.Location = New System.Drawing.Point(288, 291)
        Me.outOfRangeModeGroupBox.Name = "outOfRangeModeGroupBox"
        Me.outOfRangeModeGroupBox.Size = New System.Drawing.Size(184, 45)
        Me.outOfRangeModeGroupBox.TabIndex = 11
        Me.outOfRangeModeGroupBox.TabStop = False
        Me.outOfRangeModeGroupBox.Text = "Out Of Range Mode"
        '
        'outOfRangeModeComboBox
        '
        Me.outOfRangeModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.outOfRangeModeComboBox.Location = New System.Drawing.Point(8, 16)
        Me.outOfRangeModeComboBox.Name = "outOfRangeModeComboBox"
        Me.outOfRangeModeComboBox.Size = New System.Drawing.Size(168, 21)
        Me.outOfRangeModeComboBox.TabIndex = 0
        '
        'coercionIntervalGroupBox
        '
        Me.coercionIntervalGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.coercionIntervalGroupBox.Controls.Add(Me.intervalLabel)
        Me.coercionIntervalGroupBox.Controls.Add(Me.intervalBaseLabel)
        Me.coercionIntervalGroupBox.Controls.Add(Me.intervalNumericEdit)
        Me.coercionIntervalGroupBox.Controls.Add(Me.intervalBaseNumericEdit)
        Me.coercionIntervalGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coercionIntervalGroupBox.Location = New System.Drawing.Point(288, 216)
        Me.coercionIntervalGroupBox.Name = "coercionIntervalGroupBox"
        Me.coercionIntervalGroupBox.Size = New System.Drawing.Size(184, 72)
        Me.coercionIntervalGroupBox.TabIndex = 10
        Me.coercionIntervalGroupBox.TabStop = False
        Me.coercionIntervalGroupBox.Text = "Coercion Interval"
        '
        'intervalLabel
        '
        Me.intervalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.intervalLabel.Location = New System.Drawing.Point(8, 40)
        Me.intervalLabel.Name = "intervalLabel"
        Me.intervalLabel.Size = New System.Drawing.Size(80, 23)
        Me.intervalLabel.TabIndex = 3
        Me.intervalLabel.Text = "Interval:"
        '
        'intervalBaseLabel
        '
        Me.intervalBaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.intervalBaseLabel.Location = New System.Drawing.Point(8, 16)
        Me.intervalBaseLabel.Name = "intervalBaseLabel"
        Me.intervalBaseLabel.Size = New System.Drawing.Size(80, 23)
        Me.intervalBaseLabel.TabIndex = 2
        Me.intervalBaseLabel.Text = "Interval Base:"
        '
        'intervalNumericEdit
        '
        Me.intervalNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.intervalNumericEdit.Location = New System.Drawing.Point(96, 40)
        Me.intervalNumericEdit.Name = "intervalNumericEdit"
        Me.intervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.intervalNumericEdit.Size = New System.Drawing.Size(69, 20)
        Me.intervalNumericEdit.TabIndex = 1
        Me.intervalNumericEdit.Value = 1
        '
        'intervalBaseNumericEdit
        '
        Me.intervalBaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.intervalBaseNumericEdit.Location = New System.Drawing.Point(96, 16)
        Me.intervalBaseNumericEdit.Name = "intervalBaseNumericEdit"
        Me.intervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.intervalBaseNumericEdit.Size = New System.Drawing.Size(69, 20)
        Me.intervalBaseNumericEdit.TabIndex = 0
        '
        'divisionsGroupBox
        '
        Me.divisionsGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.divisionsGroupBox.Controls.Add(Me.enableCustomDivisionsCheckBox)
        Me.divisionsGroupBox.Controls.Add(Me.enableMinorDivisionsCheckBox)
        Me.divisionsGroupBox.Controls.Add(Me.enableMajorDivisionsCheckBox)
        Me.divisionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.divisionsGroupBox.Location = New System.Drawing.Point(288, 117)
        Me.divisionsGroupBox.Name = "divisionsGroupBox"
        Me.divisionsGroupBox.Size = New System.Drawing.Size(184, 96)
        Me.divisionsGroupBox.TabIndex = 9
        Me.divisionsGroupBox.TabStop = False
        Me.divisionsGroupBox.Text = "Divisions"
        '
        'enableCustomDivisionsCheckBox
        '
        Me.enableCustomDivisionsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.enableCustomDivisionsCheckBox.Location = New System.Drawing.Point(8, 64)
        Me.enableCustomDivisionsCheckBox.Name = "enableCustomDivisionsCheckBox"
        Me.enableCustomDivisionsCheckBox.Size = New System.Drawing.Size(168, 24)
        Me.enableCustomDivisionsCheckBox.TabIndex = 2
        Me.enableCustomDivisionsCheckBox.Text = "Enable Custom Divisions"
        '
        'enableMinorDivisionsCheckBox
        '
        Me.enableMinorDivisionsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.enableMinorDivisionsCheckBox.Location = New System.Drawing.Point(8, 40)
        Me.enableMinorDivisionsCheckBox.Name = "enableMinorDivisionsCheckBox"
        Me.enableMinorDivisionsCheckBox.Size = New System.Drawing.Size(168, 24)
        Me.enableMinorDivisionsCheckBox.TabIndex = 1
        Me.enableMinorDivisionsCheckBox.Text = "Enable Minor Divisions"
        '
        'enableMajorDivisionsCheckBox
        '
        Me.enableMajorDivisionsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.enableMajorDivisionsCheckBox.Location = New System.Drawing.Point(8, 16)
        Me.enableMajorDivisionsCheckBox.Name = "enableMajorDivisionsCheckBox"
        Me.enableMajorDivisionsCheckBox.Size = New System.Drawing.Size(168, 24)
        Me.enableMajorDivisionsCheckBox.TabIndex = 0
        Me.enableMajorDivisionsCheckBox.Text = "Enable Major Divisions"
        '
        'coercionModeGroupBox
        '
        Me.coercionModeGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.coercionModeGroupBox.Controls.Add(Me.toIntervalModeRadioButton)
        Me.coercionModeGroupBox.Controls.Add(Me.toDivisionsModeRadioButton)
        Me.coercionModeGroupBox.Controls.Add(Me.noneModeRadioButton)
        Me.coercionModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coercionModeGroupBox.Location = New System.Drawing.Point(288, 10)
        Me.coercionModeGroupBox.Name = "coercionModeGroupBox"
        Me.coercionModeGroupBox.Size = New System.Drawing.Size(184, 104)
        Me.coercionModeGroupBox.TabIndex = 8
        Me.coercionModeGroupBox.TabStop = False
        Me.coercionModeGroupBox.Text = "Coercion Mode"
        '
        'toIntervalModeRadioButton
        '
        Me.toIntervalModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toIntervalModeRadioButton.Location = New System.Drawing.Point(8, 64)
        Me.toIntervalModeRadioButton.Name = "toIntervalModeRadioButton"
        Me.toIntervalModeRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.toIntervalModeRadioButton.TabIndex = 2
        Me.toIntervalModeRadioButton.Text = "ToInterval"
        '
        'toDivisionsModeRadioButton
        '
        Me.toDivisionsModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.toDivisionsModeRadioButton.Location = New System.Drawing.Point(8, 40)
        Me.toDivisionsModeRadioButton.Name = "toDivisionsModeRadioButton"
        Me.toDivisionsModeRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.toDivisionsModeRadioButton.TabIndex = 1
        Me.toDivisionsModeRadioButton.Text = "ToDivisions"
        '
        'noneModeRadioButton
        '
        Me.noneModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noneModeRadioButton.Location = New System.Drawing.Point(8, 16)
        Me.noneModeRadioButton.Name = "noneModeRadioButton"
        Me.noneModeRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.noneModeRadioButton.TabIndex = 0
        Me.noneModeRadioButton.Text = "None"
        '
        'valuesGroupBox
        '
        Me.valuesGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.valuesGroupBox.Controls.Add(Me.commitButton)
        Me.valuesGroupBox.Controls.Add(Me.nextValueLabel)
        Me.valuesGroupBox.Controls.Add(Me.nextValueNumericEdit)
        Me.valuesGroupBox.Controls.Add(Me.previousValueLabel)
        Me.valuesGroupBox.Controls.Add(Me.previousValueNumericEdit)
        Me.valuesGroupBox.Controls.Add(Me.coercedValueLabel)
        Me.valuesGroupBox.Controls.Add(Me.coercedValueNumericEdit)
        Me.valuesGroupBox.Controls.Add(Me.setValueLabel)
        Me.valuesGroupBox.Controls.Add(Me.setValueNumericEdit)
        Me.valuesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.valuesGroupBox.Location = New System.Drawing.Point(0, 219)
        Me.valuesGroupBox.Name = "valuesGroupBox"
        Me.valuesGroupBox.Size = New System.Drawing.Size(280, 117)
        Me.valuesGroupBox.TabIndex = 7
        Me.valuesGroupBox.TabStop = False
        Me.valuesGroupBox.Text = "Values"
        '
        'commitButton
        '
        Me.commitButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.commitButton.Location = New System.Drawing.Point(200, 15)
        Me.commitButton.Name = "commitButton"
        Me.commitButton.Size = New System.Drawing.Size(75, 20)
        Me.commitButton.TabIndex = 8
        Me.commitButton.Text = "Commit"
        '
        'nextValueLabel
        '
        Me.nextValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.nextValueLabel.Location = New System.Drawing.Point(8, 88)
        Me.nextValueLabel.Name = "nextValueLabel"
        Me.nextValueLabel.Size = New System.Drawing.Size(80, 20)
        Me.nextValueLabel.TabIndex = 7
        Me.nextValueLabel.Text = "Next Value:"
        '
        'nextValueNumericEdit
        '
        Me.nextValueNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.nextValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.nextValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.nextValueNumericEdit.Location = New System.Drawing.Point(104, 88)
        Me.nextValueNumericEdit.Name = "nextValueNumericEdit"
        Me.nextValueNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.nextValueNumericEdit.TabIndex = 6
        '
        'previousValueLabel
        '
        Me.previousValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.previousValueLabel.Location = New System.Drawing.Point(8, 64)
        Me.previousValueLabel.Name = "previousValueLabel"
        Me.previousValueLabel.Size = New System.Drawing.Size(80, 20)
        Me.previousValueLabel.TabIndex = 5
        Me.previousValueLabel.Text = "Previous Value:"
        '
        'previousValueNumericEdit
        '
        Me.previousValueNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.previousValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.previousValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.previousValueNumericEdit.Location = New System.Drawing.Point(104, 64)
        Me.previousValueNumericEdit.Name = "previousValueNumericEdit"
        Me.previousValueNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.previousValueNumericEdit.TabIndex = 4
        '
        'coercedValueLabel
        '
        Me.coercedValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coercedValueLabel.Location = New System.Drawing.Point(8, 40)
        Me.coercedValueLabel.Name = "coercedValueLabel"
        Me.coercedValueLabel.Size = New System.Drawing.Size(80, 20)
        Me.coercedValueLabel.TabIndex = 3
        Me.coercedValueLabel.Text = "Coerced Value:"
        '
        'coercedValueNumericEdit
        '
        Me.coercedValueNumericEdit.BackColor = System.Drawing.SystemColors.Control
        Me.coercedValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.coercedValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.coercedValueNumericEdit.Location = New System.Drawing.Point(104, 40)
        Me.coercedValueNumericEdit.Name = "coercedValueNumericEdit"
        Me.coercedValueNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.coercedValueNumericEdit.TabIndex = 2
        '
        'setValueLabel
        '
        Me.setValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.setValueLabel.Location = New System.Drawing.Point(8, 16)
        Me.setValueLabel.Name = "setValueLabel"
        Me.setValueLabel.Size = New System.Drawing.Size(80, 20)
        Me.setValueLabel.TabIndex = 1
        Me.setValueLabel.Text = "Set Value:"
        '
        'setValueNumericEdit
        '
        Me.setValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.setValueNumericEdit.Location = New System.Drawing.Point(104, 16)
        Me.setValueNumericEdit.Name = "setValueNumericEdit"
        Me.setValueNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.setValueNumericEdit.TabIndex = 0
        '
        'sampleKnob
        '
        Me.sampleKnob.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ScaleCustomDivision1.LabelForeColor = System.Drawing.Color.Red
        ScaleCustomDivision1.Text = "2.5"
        ScaleCustomDivision1.Value = 2.5
        ScaleCustomDivision2.LabelForeColor = System.Drawing.Color.Red
        ScaleCustomDivision2.Text = "7.5"
        ScaleCustomDivision2.Value = 7.5
        Me.sampleKnob.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision1, ScaleCustomDivision2})
        Me.sampleKnob.Location = New System.Drawing.Point(0, 4)
        Me.sampleKnob.Name = "sampleKnob"
        Me.sampleKnob.Size = New System.Drawing.Size(280, 216)
        Me.sampleKnob.TabIndex = 6
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(472, 341)
        Me.Controls.Add(Me.outOfRangeModeGroupBox)
        Me.Controls.Add(Me.coercionIntervalGroupBox)
        Me.Controls.Add(Me.divisionsGroupBox)
        Me.Controls.Add(Me.coercionModeGroupBox)
        Me.Controls.Add(Me.valuesGroupBox)
        Me.Controls.Add(Me.sampleKnob)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Coercion Modes"
        Me.outOfRangeModeGroupBox.ResumeLayout(False)
        Me.coercionIntervalGroupBox.ResumeLayout(False)
        CType(Me.intervalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.divisionsGroupBox.ResumeLayout(False)
        Me.coercionModeGroupBox.ResumeLayout(False)
        Me.valuesGroupBox.ResumeLayout(False)
        CType(Me.nextValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previousValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coercedValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.setValueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <System.STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub SetCoercedValueNumericEdits()
        Dim coercionModeArgs As New NumericCoercionModeArgs(sampleKnob.Value)
        coercedValueNumericEdit.Value = sampleKnob.Value
        previousValueNumericEdit.Value = sampleKnob.CoercionMode.GetPreviousValue(DirectCast(sampleKnob, INumericControl), coercionModeArgs)
        nextValueNumericEdit.Value = sampleKnob.CoercionMode.GetNextValue(DirectCast(sampleKnob, INumericControl), coercionModeArgs)
    End Sub

    Private Sub knob_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles sampleKnob.ValueChanged
        SetCoercedValueNumericEdits()
    End Sub

    Private Sub noneModeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles noneModeRadioButton.CheckedChanged
        sampleKnob.CoercionMode = NumericCoercionMode.None
        divisionsGroupBox.Enabled = False
        coercionIntervalGroupBox.Enabled = False
    End Sub

    Private Sub toDivisionsModeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toDivisionsModeRadioButton.CheckedChanged
        sampleKnob.CoercionMode = NumericCoercionMode.ToDivisions
        divisionsGroupBox.Enabled = True
        coercionIntervalGroupBox.Enabled = False
    End Sub

    Private Sub toIntervalModeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles toIntervalModeRadioButton.CheckedChanged
        sampleKnob.CoercionMode = NumericCoercionMode.ToInterval
        divisionsGroupBox.Enabled = False
        coercionIntervalGroupBox.Enabled = True
    End Sub

    Private Sub enableMajorDivisionsCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles enableMajorDivisionsCheckBox.CheckedChanged
        sampleKnob.MajorDivisions.LabelVisible = enableMajorDivisionsCheckBox.Checked
        sampleKnob.MajorDivisions.TickVisible = enableMajorDivisionsCheckBox.Checked
        SetCoercedValueNumericEdits()
    End Sub

    Private Sub enableMinorDivisionsCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles enableMinorDivisionsCheckBox.CheckedChanged
        sampleKnob.MinorDivisions.TickVisible = enableMinorDivisionsCheckBox.Checked
        SetCoercedValueNumericEdits()
    End Sub

    Private Sub enableCustomDivisionsCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles enableCustomDivisionsCheckBox.CheckedChanged
        For Each customDivision As ScaleCustomDivision In sampleKnob.CustomDivisions
            customDivision.LabelVisible = enableCustomDivisionsCheckBox.Checked
            customDivision.TickVisible = enableCustomDivisionsCheckBox.Checked
        Next
        SetCoercedValueNumericEdits()
    End Sub

    Private Sub intervalBaseNumericEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles intervalBaseNumericEdit.ValueChanged
        sampleKnob.CoercionIntervalBase = intervalBaseNumericEdit.Value
    End Sub

    Private Sub intervalNumericEdit_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles intervalNumericEdit.ValueChanged
        sampleKnob.CoercionInterval = intervalNumericEdit.Value
    End Sub

    Private Sub commitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles commitButton.Click
        Try
            sampleKnob.Value = setValueNumericEdit.Value
            SetCoercedValueNumericEdits()
        Catch exception As ArgumentOutOfRangeException
            Dim message As New StringBuilder

            message.AppendFormat("Caught {0}" & vbNewLine, GetType(ArgumentOutOfRangeException).ToString())
            message.Append("The configured coercion mode did not coerce the Set Value to a value within the knob's range." & vbNewLine & vbNewLine)
            message.AppendFormat("Set Value: {0}" & vbNewLine & "{1}", setValueNumericEdit.Value, sampleKnob.Range.ToString())
            MessageBox.Show(message.ToString(), "Exception Caught")

            coercedValueNumericEdit.Value = Double.NaN
            previousValueNumericEdit.Value = Double.NaN
            nextValueNumericEdit.Value = Double.NaN
        End Try
    End Sub

    Private Sub outOfRangeModeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles outOfRangeModeComboBox.SelectedIndexChanged
        sampleKnob.OutOfRangeMode = DirectCast([Enum].Parse(GetType(NumericOutOfRangeMode), outOfRangeModeComboBox.SelectedItem.ToString()), NumericOutOfRangeMode)
    End Sub

    Private Sub intervalNumericEdit_BeforeChangeValue(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles intervalNumericEdit.BeforeChangeValue
        If e.NewValue = 0 Then
            MessageBox.Show("You cannot set CoercionInterval to 0.", "Error")
            e.Cancel = True
        End If
    End Sub
End Class
