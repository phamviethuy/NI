Public Class AboutDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

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
    Friend WithEvents mstudioPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents copyrightLabel As System.Windows.Forms.Label
    Friend WithEvents temperatureSystemLabel As System.Windows.Forms.Label
    Friend WithEvents okButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutDlg))
        Me.mstudioPictureBox = New System.Windows.Forms.PictureBox
        Me.copyrightLabel = New System.Windows.Forms.Label
        Me.temperatureSystemLabel = New System.Windows.Forms.Label
        Me.okButton = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'pictureBox
        '
        Me.mstudioPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mstudioPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.mstudioPictureBox.Image = CType(resources.GetObject("pictureBox.Image"), System.Drawing.Image)
        Me.mstudioPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.mstudioPictureBox.Name = "pictureBox"
        Me.mstudioPictureBox.Size = New System.Drawing.Size(184, 192)
        Me.mstudioPictureBox.TabIndex = 2
        Me.mstudioPictureBox.TabStop = False
        '
        'copyrightLabel
        '
        Me.copyrightLabel.Location = New System.Drawing.Point(200, 71)
        Me.copyrightLabel.Name = "copyrightLabel"
        Me.copyrightLabel.Size = New System.Drawing.Size(104, 23)
        Me.copyrightLabel.TabIndex = 6
        Me.copyrightLabel.Text = "Copyright (C) 2004"
        '
        'temperatureSystemLabel
        '
        Me.temperatureSystemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.temperatureSystemLabel.Location = New System.Drawing.Point(196, 27)
        Me.temperatureSystemLabel.Name = "temperatureSystemLabel"
        Me.temperatureSystemLabel.Size = New System.Drawing.Size(224, 23)
        Me.temperatureSystemLabel.TabIndex = 5
        Me.temperatureSystemLabel.Text = "Temperature System Demo"
        '
        'okButton
        '
        Me.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.okButton.Location = New System.Drawing.Point(244, 143)
        Me.okButton.Name = "okButton"
        Me.okButton.Size = New System.Drawing.Size(100, 23)
        Me.okButton.TabIndex = 4
        Me.okButton.Text = "OK"
        '
        'AboutDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.CancelButton = Me.okButton
        Me.ClientSize = New System.Drawing.Size(426, 192)
        Me.Controls.Add(Me.copyrightLabel)
        Me.Controls.Add(Me.temperatureSystemLabel)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.mstudioPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About Temperature System"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
