<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tdmsOpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.tdmsFileBrowseButton = New System.Windows.Forms.Button
        Me.tdmsFileTextBox = New System.Windows.Forms.TextBox
        Me.tdmsFileLabel = New System.Windows.Forms.Label
        Me.readerTdmsReaderUserControl = New NationalInstruments.Examples.Reader.TdmsReaderUserControl
        Me.SuspendLayout()
        '
        'tdmsOpenFileDialog
        '
        Me.tdmsOpenFileDialog.DefaultExt = "tdms"
        Me.tdmsOpenFileDialog.Filter = "TDMS Files | *.tdms"
        '
        'tdmsFileBrowseButton
        '
        Me.tdmsFileBrowseButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tdmsFileBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tdmsFileBrowseButton.Location = New System.Drawing.Point(406, 23)
        Me.tdmsFileBrowseButton.Name = "tdmsFileBrowseButton"
        Me.tdmsFileBrowseButton.Size = New System.Drawing.Size(75, 23)
        Me.tdmsFileBrowseButton.TabIndex = 2
        Me.tdmsFileBrowseButton.Text = "&Browse"
        Me.tdmsFileBrowseButton.UseVisualStyleBackColor = True
        '
        'tdmsFileTextBox
        '
        Me.tdmsFileTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tdmsFileTextBox.Location = New System.Drawing.Point(24, 25)
        Me.tdmsFileTextBox.Name = "tdmsFileTextBox"
        Me.tdmsFileTextBox.ReadOnly = True
        Me.tdmsFileTextBox.Size = New System.Drawing.Size(376, 20)
        Me.tdmsFileTextBox.TabIndex = 1
        Me.tdmsFileTextBox.TabStop = False
        '
        'tdmsFileLabel
        '
        Me.tdmsFileLabel.AutoSize = True
        Me.tdmsFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tdmsFileLabel.Location = New System.Drawing.Point(24, 9)
        Me.tdmsFileLabel.Name = "tdmsFileLabel"
        Me.tdmsFileLabel.Size = New System.Drawing.Size(26, 13)
        Me.tdmsFileLabel.TabIndex = 0
        Me.tdmsFileLabel.Text = "File:"
        '
        'readerTdmsReaderUserControl
        '
        Me.readerTdmsReaderUserControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.readerTdmsReaderUserControl.Location = New System.Drawing.Point(24, 51)
        Me.readerTdmsReaderUserControl.Name = "readerTdmsReaderUserControl"
        Me.readerTdmsReaderUserControl.Size = New System.Drawing.Size(457, 666)
        Me.readerTdmsReaderUserControl.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(504, 716)
        Me.Controls.Add(Me.readerTdmsReaderUserControl)
        Me.Controls.Add(Me.tdmsFileBrowseButton)
        Me.Controls.Add(Me.tdmsFileTextBox)
        Me.Controls.Add(Me.tdmsFileLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "TDMS File Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tdmsOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Private WithEvents readerTdmsReaderUserControl As NationalInstruments.Examples.Reader.TdmsReaderUserControl
    Private WithEvents tdmsFileBrowseButton As System.Windows.Forms.Button
    Private WithEvents tdmsFileTextBox As System.Windows.Forms.TextBox
    Private WithEvents tdmsFileLabel As System.Windows.Forms.Label

End Class
