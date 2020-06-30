Imports System
Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Set the help label text
        helpLabel.Text = "Change the Interaction Modes, the Range, and the Coercion properties of the Numeric Edit by modifying the values on this dialog."

        ' Initialize coercion mode choices
        coercionModeListComboBox.Items.Add(NumericCoercionMode.None.ToString())
        coercionModeListComboBox.Items.Add(NumericCoercionMode.ToInterval.ToString())
        coercionModeListComboBox.SelectedIndex = 0

        ' Initialize NumericEdit range
        knobNumericEdit.Range = New Range(0, 10)
        rangeMinimumNumericEdit.Value = 0
        rangeMaximumNumericEdit.Value = 10

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

#Region " Windows Form Designer generated code "

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents rangeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rangeMaximumNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents rangeMaximumLabel As System.Windows.Forms.Label
    Friend WithEvents rangeMinimumNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents rangeMinimumLabel As System.Windows.Forms.Label
    Friend WithEvents CoercionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents coercionModeLabel As System.Windows.Forms.Label
    Friend WithEvents coercionModeListComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents coercionIntervalBaseLabel As System.Windows.Forms.Label
    Friend WithEvents coercionIntervalBaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents coercionIntervalLabel As System.Windows.Forms.Label
    Friend WithEvents coercionIntervalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents interactionModesGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents arrowKeysCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents buttonsCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents textCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents numericEditGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents knobCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents sampleKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents knobNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents helpLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.rangeGroupBox = New System.Windows.Forms.GroupBox
        Me.rangeMaximumNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.rangeMaximumLabel = New System.Windows.Forms.Label
        Me.rangeMinimumNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.rangeMinimumLabel = New System.Windows.Forms.Label
        Me.CoercionGroupBox = New System.Windows.Forms.GroupBox
        Me.coercionModeLabel = New System.Windows.Forms.Label
        Me.coercionModeListComboBox = New System.Windows.Forms.ComboBox
        Me.coercionIntervalBaseLabel = New System.Windows.Forms.Label
        Me.coercionIntervalBaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.coercionIntervalLabel = New System.Windows.Forms.Label
        Me.coercionIntervalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.interactionModesGroupBox = New System.Windows.Forms.GroupBox
        Me.arrowKeysCheckBox = New System.Windows.Forms.CheckBox
        Me.buttonsCheckBox = New System.Windows.Forms.CheckBox
        Me.textCheckBox = New System.Windows.Forms.CheckBox
        Me.numericEditGroupBox = New System.Windows.Forms.GroupBox
        Me.knobCheckBox = New System.Windows.Forms.CheckBox
        Me.sampleKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.knobNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.helpLabel = New System.Windows.Forms.Label
        Me.rangeGroupBox.SuspendLayout()
        CType(Me.rangeMaximumNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rangeMinimumNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoercionGroupBox.SuspendLayout()
        CType(Me.coercionIntervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.interactionModesGroupBox.SuspendLayout()
        Me.numericEditGroupBox.SuspendLayout()
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.knobNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rangeGroupBox
        '
        Me.rangeGroupBox.Controls.Add(Me.rangeMaximumNumericEdit)
        Me.rangeGroupBox.Controls.Add(Me.rangeMaximumLabel)
        Me.rangeGroupBox.Controls.Add(Me.rangeMinimumNumericEdit)
        Me.rangeGroupBox.Controls.Add(Me.rangeMinimumLabel)
        Me.rangeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rangeGroupBox.Location = New System.Drawing.Point(16, 304)
        Me.rangeGroupBox.Name = "rangeGroupBox"
        Me.rangeGroupBox.Size = New System.Drawing.Size(160, 176)
        Me.rangeGroupBox.TabIndex = 8
        Me.rangeGroupBox.TabStop = False
        Me.rangeGroupBox.Text = "Range"
        '
        'rangeMaximumNumericEdit
        '
        Me.rangeMaximumNumericEdit.Location = New System.Drawing.Point(16, 96)
        Me.rangeMaximumNumericEdit.Name = "rangeMaximumNumericEdit"
        Me.rangeMaximumNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.rangeMaximumNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.rangeMaximumNumericEdit.TabIndex = 1
        '
        'rangeMaximumLabel
        '
        Me.rangeMaximumLabel.Location = New System.Drawing.Point(16, 80)
        Me.rangeMaximumLabel.Name = "rangeMaximumLabel"
        Me.rangeMaximumLabel.Size = New System.Drawing.Size(100, 16)
        Me.rangeMaximumLabel.TabIndex = 2
        Me.rangeMaximumLabel.Text = "Maximum:"
        '
        'rangeMinimumNumericEdit
        '
        Me.rangeMinimumNumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.rangeMinimumNumericEdit.Name = "rangeMinimumNumericEdit"
        Me.rangeMinimumNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.rangeMinimumNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.rangeMinimumNumericEdit.TabIndex = 0
        '
        'rangeMinimumLabel
        '
        Me.rangeMinimumLabel.Location = New System.Drawing.Point(16, 24)
        Me.rangeMinimumLabel.Name = "rangeMinimumLabel"
        Me.rangeMinimumLabel.Size = New System.Drawing.Size(100, 16)
        Me.rangeMinimumLabel.TabIndex = 0
        Me.rangeMinimumLabel.Text = "Minimum:"
        '
        'CoercionGroupBox
        '
        Me.CoercionGroupBox.Controls.Add(Me.coercionModeLabel)
        Me.CoercionGroupBox.Controls.Add(Me.coercionModeListComboBox)
        Me.CoercionGroupBox.Controls.Add(Me.coercionIntervalBaseLabel)
        Me.CoercionGroupBox.Controls.Add(Me.coercionIntervalBaseNumericEdit)
        Me.CoercionGroupBox.Controls.Add(Me.coercionIntervalLabel)
        Me.CoercionGroupBox.Controls.Add(Me.coercionIntervalNumericEdit)
        Me.CoercionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CoercionGroupBox.Location = New System.Drawing.Point(200, 304)
        Me.CoercionGroupBox.Name = "CoercionGroupBox"
        Me.CoercionGroupBox.Size = New System.Drawing.Size(152, 176)
        Me.CoercionGroupBox.TabIndex = 9
        Me.CoercionGroupBox.TabStop = False
        Me.CoercionGroupBox.Text = "Coercion"
        '
        'coercionModeLabel
        '
        Me.coercionModeLabel.Location = New System.Drawing.Point(16, 24)
        Me.coercionModeLabel.Name = "coercionModeLabel"
        Me.coercionModeLabel.Size = New System.Drawing.Size(100, 16)
        Me.coercionModeLabel.TabIndex = 1
        Me.coercionModeLabel.Text = "Coercion Mode:"
        '
        'coercionModeListComboBox
        '
        Me.coercionModeListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.coercionModeListComboBox.Location = New System.Drawing.Point(16, 40)
        Me.coercionModeListComboBox.Name = "coercionModeListComboBox"
        Me.coercionModeListComboBox.Size = New System.Drawing.Size(121, 21)
        Me.coercionModeListComboBox.TabIndex = 0
        '
        'coercionIntervalBaseLabel
        '
        Me.coercionIntervalBaseLabel.Location = New System.Drawing.Point(16, 120)
        Me.coercionIntervalBaseLabel.Name = "coercionIntervalBaseLabel"
        Me.coercionIntervalBaseLabel.Size = New System.Drawing.Size(128, 16)
        Me.coercionIntervalBaseLabel.TabIndex = 7
        Me.coercionIntervalBaseLabel.Text = "Coercion Interval Base:"
        '
        'coercionIntervalBaseNumericEdit
        '
        Me.coercionIntervalBaseNumericEdit.Location = New System.Drawing.Point(16, 136)
        Me.coercionIntervalBaseNumericEdit.Name = "coercionIntervalBaseNumericEdit"
        Me.coercionIntervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.coercionIntervalBaseNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.coercionIntervalBaseNumericEdit.TabIndex = 2
        '
        'coercionIntervalLabel
        '
        Me.coercionIntervalLabel.Location = New System.Drawing.Point(16, 72)
        Me.coercionIntervalLabel.Name = "coercionIntervalLabel"
        Me.coercionIntervalLabel.Size = New System.Drawing.Size(100, 16)
        Me.coercionIntervalLabel.TabIndex = 5
        Me.coercionIntervalLabel.Text = "Coercion Interval:"
        '
        'coercionIntervalNumericEdit
        '
        Me.coercionIntervalNumericEdit.Location = New System.Drawing.Point(16, 88)
        Me.coercionIntervalNumericEdit.Name = "coercionIntervalNumericEdit"
        Me.coercionIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.coercionIntervalNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.coercionIntervalNumericEdit.Size = New System.Drawing.Size(120, 20)
        Me.coercionIntervalNumericEdit.TabIndex = 1
        Me.coercionIntervalNumericEdit.Value = 1
        '
        'interactionModesGroupBox
        '
        Me.interactionModesGroupBox.Controls.Add(Me.arrowKeysCheckBox)
        Me.interactionModesGroupBox.Controls.Add(Me.buttonsCheckBox)
        Me.interactionModesGroupBox.Controls.Add(Me.textCheckBox)
        Me.interactionModesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.interactionModesGroupBox.Location = New System.Drawing.Point(200, 72)
        Me.interactionModesGroupBox.Name = "interactionModesGroupBox"
        Me.interactionModesGroupBox.Size = New System.Drawing.Size(152, 216)
        Me.interactionModesGroupBox.TabIndex = 7
        Me.interactionModesGroupBox.TabStop = False
        Me.interactionModesGroupBox.Text = "Interaction Modes"
        '
        'arrowKeysCheckBox
        '
        Me.arrowKeysCheckBox.Checked = True
        Me.arrowKeysCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.arrowKeysCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.arrowKeysCheckBox.Location = New System.Drawing.Point(16, 88)
        Me.arrowKeysCheckBox.Name = "arrowKeysCheckBox"
        Me.arrowKeysCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.arrowKeysCheckBox.TabIndex = 2
        Me.arrowKeysCheckBox.Text = "Arrow Keys"
        '
        'buttonsCheckBox
        '
        Me.buttonsCheckBox.Checked = True
        Me.buttonsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.buttonsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.buttonsCheckBox.Location = New System.Drawing.Point(16, 56)
        Me.buttonsCheckBox.Name = "buttonsCheckBox"
        Me.buttonsCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.buttonsCheckBox.TabIndex = 1
        Me.buttonsCheckBox.Text = "Buttons"
        '
        'textCheckBox
        '
        Me.textCheckBox.Checked = True
        Me.textCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.textCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.textCheckBox.Location = New System.Drawing.Point(16, 24)
        Me.textCheckBox.Name = "textCheckBox"
        Me.textCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.textCheckBox.TabIndex = 0
        Me.textCheckBox.Text = "Text"
        '
        'numericEditGroupBox
        '
        Me.numericEditGroupBox.Controls.Add(Me.knobCheckBox)
        Me.numericEditGroupBox.Controls.Add(Me.sampleKnob)
        Me.numericEditGroupBox.Controls.Add(Me.knobNumericEdit)
        Me.numericEditGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numericEditGroupBox.Location = New System.Drawing.Point(16, 72)
        Me.numericEditGroupBox.Name = "numericEditGroupBox"
        Me.numericEditGroupBox.Size = New System.Drawing.Size(160, 216)
        Me.numericEditGroupBox.TabIndex = 6
        Me.numericEditGroupBox.TabStop = False
        Me.numericEditGroupBox.Text = "Numeric Edit"
        '
        'knobCheckBox
        '
        Me.knobCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.knobCheckBox.Location = New System.Drawing.Point(16, 160)
        Me.knobCheckBox.Name = "knobCheckBox"
        Me.knobCheckBox.Size = New System.Drawing.Size(128, 16)
        Me.knobCheckBox.TabIndex = 1
        Me.knobCheckBox.Text = "Connect to Knob"
        '
        'sampleKnob
        '
        Me.sampleKnob.Location = New System.Drawing.Point(8, 16)
        Me.sampleKnob.Name = "sampleKnob"
        Me.sampleKnob.Size = New System.Drawing.Size(144, 144)
        Me.sampleKnob.TabIndex = 0
        '
        'knobNumericEdit
        '
        Me.knobNumericEdit.Location = New System.Drawing.Point(16, 184)
        Me.knobNumericEdit.Name = "knobNumericEdit"
        Me.knobNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.knobNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.knobNumericEdit.TabIndex = 2
        '
        'helpLabel
        '
        Me.helpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpLabel.Location = New System.Drawing.Point(12, 15)
        Me.helpLabel.Name = "helpLabel"
        Me.helpLabel.Size = New System.Drawing.Size(344, 48)
        Me.helpLabel.TabIndex = 10
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(368, 494)
        Me.Controls.Add(Me.rangeGroupBox)
        Me.Controls.Add(Me.CoercionGroupBox)
        Me.Controls.Add(Me.interactionModesGroupBox)
        Me.Controls.Add(Me.numericEditGroupBox)
        Me.Controls.Add(Me.helpLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Simple Numeric Edit"
        Me.rangeGroupBox.ResumeLayout(False)
        CType(Me.rangeMaximumNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rangeMinimumNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoercionGroupBox.ResumeLayout(False)
        CType(Me.coercionIntervalBaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.interactionModesGroupBox.ResumeLayout(False)
        Me.numericEditGroupBox.ResumeLayout(False)
        CType(Me.sampleKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.knobNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub knobButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles knobCheckBox.CheckedChanged
        If (knobCheckBox.Checked) Then
            knobNumericEdit.Source = sampleKnob
        Else
            knobNumericEdit.Source = Nothing
        End If
    End Sub

    Private Sub textButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles textCheckBox.CheckedChanged
        If (textCheckBox.Checked) Then
            knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode Or NumericEditInteractionModes.Text
        Else
            knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode Xor NumericEditInteractionModes.Text
        End If
    End Sub

    Private Sub buttonsButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonsCheckBox.CheckedChanged
        If (buttonsCheckBox.Checked) Then
            knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode Or NumericEditInteractionModes.Buttons
        Else
            knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode Xor NumericEditInteractionModes.Buttons
        End If
    End Sub

    Private Sub arrowKeysButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arrowKeysCheckBox.CheckedChanged
        If (arrowKeysCheckBox.Checked) Then
            knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode Or NumericEditInteractionModes.ArrowKeys
        Else
            knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode Xor NumericEditInteractionModes.ArrowKeys
        End If
    End Sub

    Private Sub rangeMinimumNumeric_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles rangeMinimumNumericEdit.AfterChangeValue
        knobNumericEdit.Range = New Range(rangeMinimumNumericEdit.Value, knobNumericEdit.Range.Maximum)
    End Sub

    Private Sub rangeMaximumNumeric_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles rangeMaximumNumericEdit.AfterChangeValue
        knobNumericEdit.Range = New Range(knobNumericEdit.Range.Minimum, rangeMaximumNumericEdit.Value)
    End Sub

    Private Sub rangeMaximumNumeric_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles rangeMaximumNumericEdit.BeforeChangeValue
        If (Double.IsNaN(e.NewValue) Or e.NewValue <= knobNumericEdit.Range.Minimum) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub rangeMinimumNumeric_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles rangeMinimumNumericEdit.BeforeChangeValue
        If (Double.IsNaN(e.NewValue) Or e.NewValue >= knobNumericEdit.Range.Maximum) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub coercionModeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles coercionModeListComboBox.SelectedIndexChanged
        Dim coercionMode As NumericCoercionMode
        coercionMode = EnumObject.Parse(GetType(NumericCoercionMode), coercionModeListComboBox.SelectedItem)
        If Not (coercionMode Is Nothing) Then
            knobNumericEdit.CoercionMode = coercionMode
        End If
    End Sub

    Private Sub coercionIntervalNumeric_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles coercionIntervalNumericEdit.AfterChangeValue
        knobNumericEdit.CoercionInterval = coercionIntervalNumericEdit.Value
    End Sub

    Private Sub coercionIntervalNumeric_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles coercionIntervalNumericEdit.BeforeChangeValue
        If (Double.IsNaN(e.NewValue) Or Double.IsInfinity(e.NewValue) Or e.NewValue = 0) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub coercionIntervalBaseNumeric_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles coercionIntervalBaseNumericEdit.AfterChangeValue
        knobNumericEdit.CoercionIntervalBase = coercionIntervalBaseNumericEdit.Value
    End Sub

    Private Sub coercionIntervalBaseNumeric_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles coercionIntervalBaseNumericEdit.BeforeChangeValue
        If (Double.IsNaN(e.NewValue) Or Double.IsInfinity(e.NewValue)) Then
            e.Cancel = True
        End If
    End Sub
End Class
