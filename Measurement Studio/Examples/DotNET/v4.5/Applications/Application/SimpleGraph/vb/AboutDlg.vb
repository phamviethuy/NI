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
    Friend WithEvents keys As System.Windows.Forms.ColumnHeader
    Friend WithEvents actionListView As System.Windows.Forms.ListView
    Friend WithEvents action As System.Windows.Forms.ColumnHeader
    Friend WithEvents mstudioPictureBox As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Zoom"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+LeftMouseDrag", "Zoom into Selection."}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+Alt+LeftMouseDrag", "Zoom into proportional selection."}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+LeftClick", "Zoom in around point."}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+UpArrow", "Zoom in around middle of plot area."}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+DownArrow", "Zoom out around middle of plot area."}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+MouseWheel", "Zoom in/Zoom out."}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+RightClick", "Undo."}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Shift+Backspace", "Reset."}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Pan"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ctrl+LeftMouseDrag", "Pan."}, -1)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ctrl+LeftArrow", "Pan left."}, -1)
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ctrl+RightArrow", "Pan right."}, -1)
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ctrl+UpArrow", "Pan up."}, -1)
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ctrl+DownArrow", "Pan down."}, -1)
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ctrl+RightClick", "Undo."}, -1)
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Ctrl+Backspace", "Reset."}, -1)
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AboutDlg))
        Me.keys = New System.Windows.Forms.ColumnHeader
        Me.actionListView = New System.Windows.Forms.ListView
        Me.action = New System.Windows.Forms.ColumnHeader
        Me.mstudioPictureBox = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'keys
        '
        Me.keys.Text = "Key Combination"
        Me.keys.Width = 141
        '
        'listView
        '
        Me.actionListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.keys, Me.action})
        Me.actionListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.actionListView.FullRowSelect = True
        Me.actionListView.GridLines = True
        Me.actionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.actionListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17})
        Me.actionListView.Location = New System.Drawing.Point(184, 0)
        Me.actionListView.Name = "listView"
        Me.actionListView.Scrollable = False
        Me.actionListView.Size = New System.Drawing.Size(372, 313)
        Me.actionListView.TabIndex = 3
        Me.actionListView.View = System.Windows.Forms.View.Details
        '
        'action
        '
        Me.action.Text = "Action"
        Me.action.Width = 251
        '
        'pictureBox
        '
        Me.mstudioPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mstudioPictureBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.mstudioPictureBox.Image = CType(resources.GetObject("pictureBox.Image"), System.Drawing.Image)
        Me.mstudioPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.mstudioPictureBox.Name = "pictureBox"
        Me.mstudioPictureBox.Size = New System.Drawing.Size(184, 313)
        Me.mstudioPictureBox.TabIndex = 2
        Me.mstudioPictureBox.TabStop = False
        '
        'AboutDlg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(556, 313)
        Me.Controls.Add(Me.actionListView)
        Me.Controls.Add(Me.mstudioPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graph Keyboard Help"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
