Imports System.ComponentModel
Imports System.Threading

Public Class RangeEditorUI
    Inherits System.Windows.Forms.UserControl

    Private oldMinimum As Double
    Private oldMaximum As Double
    Private newMinimum As Double
    Private newMaximum As Double

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal minimumValue As Double, ByVal maximumValue As Double)
        MyBase.New()

        InitializeComponent()

        oldMinimum = minimumValue
        newMinimum = minimumValue
        minimumNumericEdit.Value = minimumValue
        oldMaximum = maximumValue
        newMaximum = maximumValue
        maximumNumericEdit.Value = maximumValue

    End Sub

    'UserControl overrides dispose to clean up the component list.
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
    Friend WithEvents minimumNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents maximumNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents separatorLabel As System.Windows.Forms.Label
    Friend WithEvents maximumLabel As System.Windows.Forms.Label
    Friend WithEvents minimumLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.separatorLabel = New System.Windows.Forms.Label
        Me.maximumLabel = New System.Windows.Forms.Label
        Me.minimumLabel = New System.Windows.Forms.Label
        Me.minimumNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.maximumNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.SuspendLayout()
        '
        'labelSeparator
        '
        Me.separatorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.separatorLabel.Location = New System.Drawing.Point(96, 24)
        Me.separatorLabel.Name = "labelSeparator"
        Me.separatorLabel.Size = New System.Drawing.Size(8, 16)
        Me.separatorLabel.TabIndex = 9
        Me.separatorLabel.Text = "-"
        '
        'labelMaximum
        '
        Me.maximumLabel.Location = New System.Drawing.Point(112, 8)
        Me.maximumLabel.Name = "labelMaximum"
        Me.maximumLabel.Size = New System.Drawing.Size(80, 16)
        Me.maximumLabel.TabIndex = 8
        Me.maximumLabel.Text = "Maximum"
        '
        'labelMinimum
        '
        Me.minimumLabel.Location = New System.Drawing.Point(16, 8)
        Me.minimumLabel.Name = "labelMinimum"
        Me.minimumLabel.Size = New System.Drawing.Size(88, 16)
        Me.minimumLabel.TabIndex = 7
        Me.minimumLabel.Text = "Minimum"
        '
        'minimumNumeric
        '
        Me.minimumNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.minimumNumericEdit.Location = New System.Drawing.Point(16, 24)
        Me.minimumNumericEdit.Name = "minimumNumeric"
        Me.minimumNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.minimumNumericEdit.Size = New System.Drawing.Size(76, 20)
        Me.minimumNumericEdit.TabIndex = 10
        '
        'maximumNumeric
        '
        Me.maximumNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.maximumNumericEdit.Location = New System.Drawing.Point(112, 24)
        Me.maximumNumericEdit.Name = "maximumNumeric"
        Me.maximumNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.maximumNumericEdit.Size = New System.Drawing.Size(76, 20)
        Me.maximumNumericEdit.TabIndex = 11
        '
        'RangeEditorUI
        '
        Me.Controls.Add(Me.maximumNumericEdit)
        Me.Controls.Add(Me.minimumNumericEdit)
        Me.Controls.Add(Me.separatorLabel)
        Me.Controls.Add(Me.maximumLabel)
        Me.Controls.Add(Me.minimumLabel)
        Me.Name = "RangeEditorUI"
        Me.Size = New System.Drawing.Size(200, 56)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Protected Overridable Function ProcessDialogKeys(ByVal keyData As Keys) As Boolean
        If (keyData And Keys.Escape) = Keys.Escape Then
            newMinimum = oldMinimum
            newMaximum = oldMaximum
        End If
        Return MyBase.ProcessDialogKey(keyData)
    End Function


    Public ReadOnly Property Minimum() As Double
        Get
            Return newMinimum
        End Get
    End Property

    Public ReadOnly Property Maximum() As Double
        Get
            Return newMaximum
        End Get
    End Property

    Private Sub minimumNumeric_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles minimumNumericEdit.AfterChangeValue
        newMinimum = minimumNumericEdit.Value
    End Sub

    Private Sub maximumNumeric_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles maximumNumericEdit.AfterChangeValue
        newMaximum = maximumNumericEdit.Value
    End Sub

    Private Sub minimumNumeric_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles minimumNumericEdit.BeforeChangeValue
        If (e.NewValue >= Maximum) Then
            e.Cancel = True
        End If
    End Sub

    Private Sub maximumNumeric_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles maximumNumericEdit.BeforeChangeValue
        If (e.NewValue <= Minimum) Then
            e.Cancel = True
        End If
    End Sub
End Class
