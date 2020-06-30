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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ProcessesGroupBox = New System.Windows.Forms.GroupBox
        Me.ProcessesListBox = New System.Windows.Forms.ListBox
        Me.ProcessContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshProcessesMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProcessSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteProcessMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateProcessButton = New System.Windows.Forms.Button
        Me.ProcessNameTextBox = New System.Windows.Forms.TextBox
        Me.VariablesGroupBox = New System.Windows.Forms.GroupBox
        Me.VariablesListBox = New System.Windows.Forms.ListBox
        Me.VariableContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RrefreshVariablesMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VariableSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.DeleteVariableMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateVariableButton = New System.Windows.Forms.Button
        Me.VariableNameTextBox = New System.Windows.Forms.TextBox
        Me.InstructionLabel = New System.Windows.Forms.Label
        Me.ProcessesGroupBox.SuspendLayout()
        Me.ProcessContextMenuStrip.SuspendLayout()
        Me.VariablesGroupBox.SuspendLayout()
        Me.VariableContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProcessesGroupBox
        '
        Me.ProcessesGroupBox.Controls.Add(Me.ProcessesListBox)
        Me.ProcessesGroupBox.Controls.Add(Me.CreateProcessButton)
        Me.ProcessesGroupBox.Controls.Add(Me.ProcessNameTextBox)
        Me.ProcessesGroupBox.Location = New System.Drawing.Point(17, 103)
        Me.ProcessesGroupBox.Name = "ProcessesGroupBox"
        Me.ProcessesGroupBox.Size = New System.Drawing.Size(179, 241)
        Me.ProcessesGroupBox.TabIndex = 0
        Me.ProcessesGroupBox.TabStop = False
        Me.ProcessesGroupBox.Text = "&Processes"
        '
        'ProcessesListBox
        '
        Me.ProcessesListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessesListBox.ContextMenuStrip = Me.ProcessContextMenuStrip
        Me.ProcessesListBox.FormattingEnabled = True
        Me.ProcessesListBox.Location = New System.Drawing.Point(7, 77)
        Me.ProcessesListBox.Name = "ProcessesListBox"
        Me.ProcessesListBox.Size = New System.Drawing.Size(166, 160)
        Me.ProcessesListBox.TabIndex = 2
        '
        'ProcessContextMenuStrip
        '
        Me.ProcessContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshProcessesMenuItem, Me.ProcessSeparator, Me.DeleteProcessMenuItem})
        Me.ProcessContextMenuStrip.Name = "processMenu"
        Me.ProcessContextMenuStrip.Size = New System.Drawing.Size(124, 54)
        '
        'RefreshProcessesMenuItem
        '
        Me.RefreshProcessesMenuItem.Name = "RefreshProcessesMenuItem"
        Me.RefreshProcessesMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.RefreshProcessesMenuItem.Text = "&Refresh"
        '
        'ProcessSeparator
        '
        Me.ProcessSeparator.Name = "ProcessSeparator"
        Me.ProcessSeparator.Size = New System.Drawing.Size(120, 6)
        '
        'DeleteProcessMenuItem
        '
        Me.DeleteProcessMenuItem.Name = "DeleteProcessMenuItem"
        Me.DeleteProcessMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.DeleteProcessMenuItem.Text = "&Delete"
        '
        'CreateProcessButton
        '
        Me.CreateProcessButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateProcessButton.Location = New System.Drawing.Point(7, 47)
        Me.CreateProcessButton.Name = "CreateProcessButton"
        Me.CreateProcessButton.Size = New System.Drawing.Size(166, 23)
        Me.CreateProcessButton.TabIndex = 1
        Me.CreateProcessButton.Text = "&Create Process"
        Me.CreateProcessButton.UseVisualStyleBackColor = True
        '
        'ProcessNameTextBox
        '
        Me.ProcessNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProcessNameTextBox.Location = New System.Drawing.Point(7, 20)
        Me.ProcessNameTextBox.Name = "ProcessNameTextBox"
        Me.ProcessNameTextBox.Size = New System.Drawing.Size(166, 20)
        Me.ProcessNameTextBox.TabIndex = 0
        '
        'VariablesGroupBox
        '
        Me.VariablesGroupBox.Controls.Add(Me.VariablesListBox)
        Me.VariablesGroupBox.Controls.Add(Me.CreateVariableButton)
        Me.VariablesGroupBox.Controls.Add(Me.VariableNameTextBox)
        Me.VariablesGroupBox.Location = New System.Drawing.Point(207, 103)
        Me.VariablesGroupBox.Name = "VariablesGroupBox"
        Me.VariablesGroupBox.Size = New System.Drawing.Size(179, 241)
        Me.VariablesGroupBox.TabIndex = 1
        Me.VariablesGroupBox.TabStop = False
        Me.VariablesGroupBox.Text = "&Variables"
        '
        'VariablesListBox
        '
        Me.VariablesListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VariablesListBox.ContextMenuStrip = Me.VariableContextMenuStrip
        Me.VariablesListBox.FormattingEnabled = True
        Me.VariablesListBox.Location = New System.Drawing.Point(7, 77)
        Me.VariablesListBox.Name = "VariablesListBox"
        Me.VariablesListBox.Size = New System.Drawing.Size(166, 160)
        Me.VariablesListBox.TabIndex = 2
        '
        'VariableContextMenuStrip
        '
        Me.VariableContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RrefreshVariablesMenuItem, Me.VariableSeparator, Me.DeleteVariableMenuItem})
        Me.VariableContextMenuStrip.Name = "variableMenu"
        Me.VariableContextMenuStrip.Size = New System.Drawing.Size(153, 76)
        '
        'RrefreshVariablesMenuItem
        '
        Me.RrefreshVariablesMenuItem.Name = "RrefreshVariablesMenuItem"
        Me.RrefreshVariablesMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RrefreshVariablesMenuItem.Text = "&Refresh"
        '
        'VariableSeparator
        '
        Me.VariableSeparator.Name = "VariableSeparator"
        Me.VariableSeparator.Size = New System.Drawing.Size(149, 6)
        '
        'DeleteVariableMenuItem
        '
        Me.DeleteVariableMenuItem.Name = "DeleteVariableMenuItem"
        Me.DeleteVariableMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteVariableMenuItem.Text = "&Delete"
        '
        'CreateVariableButton
        '
        Me.CreateVariableButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateVariableButton.Location = New System.Drawing.Point(7, 47)
        Me.CreateVariableButton.Name = "CreateVariableButton"
        Me.CreateVariableButton.Size = New System.Drawing.Size(166, 23)
        Me.CreateVariableButton.TabIndex = 1
        Me.CreateVariableButton.Text = "C&reate Variable"
        Me.CreateVariableButton.UseVisualStyleBackColor = True
        '
        'VariableNameTextBox
        '
        Me.VariableNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VariableNameTextBox.Location = New System.Drawing.Point(7, 20)
        Me.VariableNameTextBox.Name = "VariableNameTextBox"
        Me.VariableNameTextBox.Size = New System.Drawing.Size(166, 20)
        Me.VariableNameTextBox.TabIndex = 0
        '
        'InstructionLabel
        '
        Me.InstructionLabel.Location = New System.Drawing.Point(10, 13)
        Me.InstructionLabel.Name = "InstructionLabel"
        Me.InstructionLabel.Size = New System.Drawing.Size(383, 86)
        Me.InstructionLabel.TabIndex = 3
        Me.InstructionLabel.Text = resources.GetString("InstructionLabel.Text")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 350)
        Me.Controls.Add(Me.InstructionLabel)
        Me.Controls.Add(Me.ProcessesGroupBox)
        Me.Controls.Add(Me.VariablesGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Network Variable Creation"
        Me.ProcessesGroupBox.ResumeLayout(False)
        Me.ProcessesGroupBox.PerformLayout()
        Me.ProcessContextMenuStrip.ResumeLayout(False)
        Me.VariablesGroupBox.ResumeLayout(False)
        Me.VariablesGroupBox.PerformLayout()
        Me.VariableContextMenuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ProcessesGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents ProcessesListBox As System.Windows.Forms.ListBox
    Private WithEvents CreateProcessButton As System.Windows.Forms.Button
    Private WithEvents ProcessNameTextBox As System.Windows.Forms.TextBox
    Private WithEvents VariablesGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents VariablesListBox As System.Windows.Forms.ListBox
    Private WithEvents CreateVariableButton As System.Windows.Forms.Button
    Private WithEvents VariableNameTextBox As System.Windows.Forms.TextBox
    Private WithEvents ProcessContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Private WithEvents RefreshProcessesMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ProcessSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents DeleteProcessMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents VariableContextMenuStrip As System.Windows.Forms.ContextMenuStrip
    Private WithEvents RrefreshVariablesMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents VariableSeparator As System.Windows.Forms.ToolStripSeparator
    Private WithEvents DeleteVariableMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents InstructionLabel As System.Windows.Forms.Label

End Class
