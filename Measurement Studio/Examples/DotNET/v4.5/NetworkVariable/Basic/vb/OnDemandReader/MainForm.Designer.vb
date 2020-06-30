<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        If disposing AndAlso reader IsNot Nothing Then
            reader.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.displayWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.WaveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.XAxis1 = New NationalInstruments.UI.XAxis
        Me.YAxis1 = New NationalInstruments.UI.YAxis
        Me.connectionStatusLabel = New System.Windows.Forms.Label
        Me.statusTextBox = New System.Windows.Forms.TextBox
        Me.readButton = New System.Windows.Forms.Button
        Me.disconnectButton = New System.Windows.Forms.Button
        Me.connectButton = New System.Windows.Forms.Button
        CType(Me.displayWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'displayWaveformGraph
        '
        Me.displayWaveformGraph.Location = New System.Drawing.Point(12, 12)
        Me.displayWaveformGraph.Name = "displayWaveformGraph"
        Me.displayWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.WaveformPlot1})
        Me.displayWaveformGraph.Size = New System.Drawing.Size(278, 168)
        Me.displayWaveformGraph.TabIndex = 0
        Me.displayWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.displayWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        '
        'WaveformPlot1
        '
        Me.WaveformPlot1.XAxis = Me.XAxis1
        Me.WaveformPlot1.YAxis = Me.YAxis1
        '
        'connectionStatusLabel
        '
        Me.connectionStatusLabel.AutoSize = True
        Me.connectionStatusLabel.Location = New System.Drawing.Point(9, 192)
        Me.connectionStatusLabel.Name = "connectionStatusLabel"
        Me.connectionStatusLabel.Size = New System.Drawing.Size(97, 13)
        Me.connectionStatusLabel.TabIndex = 13
        Me.connectionStatusLabel.Text = "Connection Status:"
        '
        'statusTextBox
        '
        Me.statusTextBox.Location = New System.Drawing.Point(109, 189)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(129, 20)
        Me.statusTextBox.TabIndex = 12
        Me.statusTextBox.Text = "Disconnected"
        '
        'readButton
        '
        Me.readButton.Enabled = False
        Me.readButton.Location = New System.Drawing.Point(109, 215)
        Me.readButton.Name = "readButton"
        Me.readButton.Size = New System.Drawing.Size(86, 23)
        Me.readButton.TabIndex = 11
        Me.readButton.Text = "Read"
        Me.readButton.UseVisualStyleBackColor = True
        '
        'disconnectButton
        '
        Me.disconnectButton.Location = New System.Drawing.Point(12, 244)
        Me.disconnectButton.Name = "disconnectButton"
        Me.disconnectButton.Size = New System.Drawing.Size(86, 23)
        Me.disconnectButton.TabIndex = 10
        Me.disconnectButton.Text = "Disconnect"
        Me.disconnectButton.UseVisualStyleBackColor = True
        '
        'connectButton
        '
        Me.connectButton.Location = New System.Drawing.Point(12, 215)
        Me.connectButton.Name = "connectButton"
        Me.connectButton.Size = New System.Drawing.Size(86, 23)
        Me.connectButton.TabIndex = 9
        Me.connectButton.Text = "Connect"
        Me.connectButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 277)
        Me.Controls.Add(Me.connectionStatusLabel)
        Me.Controls.Add(Me.statusTextBox)
        Me.Controls.Add(Me.readButton)
        Me.Controls.Add(Me.disconnectButton)
        Me.Controls.Add(Me.connectButton)
        Me.Controls.Add(Me.displayWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "On Demand Reader"
        CType(Me.displayWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents WaveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents XAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis1 As NationalInstruments.UI.YAxis
    Private WithEvents connectionStatusLabel As System.Windows.Forms.Label
    Private WithEvents statusTextBox As System.Windows.Forms.TextBox
    Private WithEvents readButton As System.Windows.Forms.Button
    Private WithEvents disconnectButton As System.Windows.Forms.Button
    Private WithEvents connectButton As System.Windows.Forms.Button

End Class
