Public Class HelpDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        UpdateHelpBox()

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
    Friend WithEvents helpContentsLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.helpContentsLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'helpContentsLabel
        '
        Me.helpContentsLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.helpContentsLabel.Dock = System.Windows.Forms.DockStyle.Right
        Me.helpContentsLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpContentsLabel.Location = New System.Drawing.Point(0, 0)
        Me.helpContentsLabel.Name = "helpContentsLabel"
        Me.helpContentsLabel.Size = New System.Drawing.Size(556, 313)
        Me.helpContentsLabel.TabIndex = 3
        '
        'HelpDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(556, 313)
        Me.Controls.Add(Me.helpContentsLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HelpDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pole-Zero Editor Help"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub UpdateHelpBox()
        Dim overview As String = "Introduction:" + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + "The Pole-Zero Editor is a tool that gives useful insights into the response of a filter." + " This tool assists in complex analysis of a system with respect to its stability and can be used as a basis for filter design." + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf

        Dim usingTool As String = "Using the Tool:" + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + "The Pole-Zero Editor assists users to create linear systems using a pole-zero plot. " + "Using the tool, one can interactively plot poles and zeros in the complex plane. " + "The filter characteristics of the system is updated as the user manipulates the poles and the zeros." + ControlChars.Cr + ControlChars.Lf + ControlChars.Cr + ControlChars.Lf + "Operations can be performed on individual poles/zeros or a group of them. The 'Select' menu item or the context menu has options to determine how poles and zeros can be selected. " + "The poles and the zeros can be moved, added or deleted by using the context menu, main menu items or via the list entries."

        helpContentsLabel.Text = overview + ControlChars.Cr + ControlChars.Lf + usingTool
    End Sub 'UpdateHelpBox
End Class
