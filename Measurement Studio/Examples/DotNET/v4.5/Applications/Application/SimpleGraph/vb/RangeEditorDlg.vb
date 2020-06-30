Public Class RangeEditorDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
    Private _maximum As Double
    Private _minimum As Double
    Private mainRangeEditorUI As RangeEditorUI

    Public Sub New(ByVal minimum As Double, ByVal maximum As Double)
        MyBase.New()
        InitializeComponent()

        okButton.DialogResult = Windows.Forms.DialogResult.OK
        CancelButton.DialogResult = Windows.Forms.DialogResult.Cancel
        StartPosition = FormStartPosition.CenterParent
        mainRangeEditorUI = New RangeEditorUI(minimum, maximum)
        Controls.Add(mainRangeEditorUI)
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
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents canButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.canButton = New System.Windows.Forms.Button
        Me.okButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'canButton
        '
        Me.canButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.canButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.canButton.Location = New System.Drawing.Point(112, 60)
        Me.canButton.Name = "canButton"
        Me.canButton.TabIndex = 3
        Me.canButton.Text = "Cancel"
        '
        'okButton
        '
        Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.okButton.Location = New System.Drawing.Point(16, 60)
        Me.okButton.Name = "okButton"
        Me.okButton.TabIndex = 2
        Me.okButton.Text = "OK"
        '
        'RangeEditorDlg
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.canButton
        Me.ClientSize = New System.Drawing.Size(194, 95)
        Me.Controls.Add(Me.canButton)
        Me.Controls.Add(Me.okButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RangeEditorDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Range Editor"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public ReadOnly Property Maximum() As Double
        Get
            Return mainRangeEditorUI.Maximum
        End Get

    End Property

    Public ReadOnly Property Minimum() As Double
        Get
            Return mainRangeEditorUI.Minimum
        End Get

    End Property
End Class
