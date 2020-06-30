<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        If disposing AndAlso subscriber IsNot Nothing Then
            subscriber.Dispose()
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
        Me.qualityLabel = New System.Windows.Forms.Label
        Me.timeStampLabel = New System.Windows.Forms.Label
        Me.connectionStatusLabel = New System.Windows.Forms.Label
        Me.qualityTextBox = New System.Windows.Forms.TextBox
        Me.timeStampTextBox = New System.Windows.Forms.TextBox
        Me.statusTextBox = New System.Windows.Forms.TextBox
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
        Me.displayWaveformGraph.Size = New System.Drawing.Size(347, 168)
        Me.displayWaveformGraph.TabIndex = 0
        Me.displayWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.displayWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        '
        'WaveformPlot1
        '
        Me.WaveformPlot1.XAxis = Me.XAxis1
        Me.WaveformPlot1.YAxis = Me.YAxis1
        '
        'qualityLabel
        '
        Me.qualityLabel.AutoSize = True
        Me.qualityLabel.Location = New System.Drawing.Point(15, 254)
        Me.qualityLabel.Name = "qualityLabel"
        Me.qualityLabel.Size = New System.Drawing.Size(42, 13)
        Me.qualityLabel.TabIndex = 16
        Me.qualityLabel.Text = "Quality:"
        '
        'timeStampLabel
        '
        Me.timeStampLabel.AutoSize = True
        Me.timeStampLabel.Location = New System.Drawing.Point(12, 228)
        Me.timeStampLabel.Name = "timeStampLabel"
        Me.timeStampLabel.Size = New System.Drawing.Size(66, 13)
        Me.timeStampLabel.TabIndex = 15
        Me.timeStampLabel.Text = "Time Stamp:"
        '
        'connectionStatusLabel
        '
        Me.connectionStatusLabel.AutoSize = True
        Me.connectionStatusLabel.Location = New System.Drawing.Point(12, 202)
        Me.connectionStatusLabel.Name = "connectionStatusLabel"
        Me.connectionStatusLabel.Size = New System.Drawing.Size(97, 13)
        Me.connectionStatusLabel.TabIndex = 14
        Me.connectionStatusLabel.Text = "Connection Status:"
        '
        'qualityTextBox
        '
        Me.qualityTextBox.Location = New System.Drawing.Point(112, 251)
        Me.qualityTextBox.Name = "qualityTextBox"
        Me.qualityTextBox.ReadOnly = True
        Me.qualityTextBox.Size = New System.Drawing.Size(129, 20)
        Me.qualityTextBox.TabIndex = 13
        '
        'timeStampTextBox
        '
        Me.timeStampTextBox.Location = New System.Drawing.Point(112, 225)
        Me.timeStampTextBox.Name = "timeStampTextBox"
        Me.timeStampTextBox.ReadOnly = True
        Me.timeStampTextBox.Size = New System.Drawing.Size(129, 20)
        Me.timeStampTextBox.TabIndex = 12
        '
        'statusTextBox
        '
        Me.statusTextBox.Location = New System.Drawing.Point(112, 199)
        Me.statusTextBox.Name = "statusTextBox"
        Me.statusTextBox.ReadOnly = True
        Me.statusTextBox.Size = New System.Drawing.Size(129, 20)
        Me.statusTextBox.TabIndex = 11
        Me.statusTextBox.Text = "Disconnected"
        '
        'disconnectButton
        '
        Me.disconnectButton.Enabled = False
        Me.disconnectButton.Location = New System.Drawing.Point(276, 225)
        Me.disconnectButton.Name = "disconnectButton"
        Me.disconnectButton.Size = New System.Drawing.Size(86, 23)
        Me.disconnectButton.TabIndex = 10
        Me.disconnectButton.Text = "Disconnect"
        Me.disconnectButton.UseVisualStyleBackColor = True
        '
        'connectButton
        '
        Me.connectButton.Location = New System.Drawing.Point(276, 199)
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
        Me.ClientSize = New System.Drawing.Size(376, 283)
        Me.Controls.Add(Me.qualityLabel)
        Me.Controls.Add(Me.timeStampLabel)
        Me.Controls.Add(Me.connectionStatusLabel)
        Me.Controls.Add(Me.qualityTextBox)
        Me.Controls.Add(Me.timeStampTextBox)
        Me.Controls.Add(Me.statusTextBox)
        Me.Controls.Add(Me.disconnectButton)
        Me.Controls.Add(Me.connectButton)
        Me.Controls.Add(Me.displayWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Subscriber"
        CType(Me.displayWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents WaveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents XAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis1 As NationalInstruments.UI.YAxis
    Private WithEvents qualityLabel As System.Windows.Forms.Label
    Private WithEvents timeStampLabel As System.Windows.Forms.Label
    Private WithEvents connectionStatusLabel As System.Windows.Forms.Label
    Private WithEvents qualityTextBox As System.Windows.Forms.TextBox
    Private WithEvents timeStampTextBox As System.Windows.Forms.TextBox
    Private WithEvents statusTextBox As System.Windows.Forms.TextBox
    Private WithEvents disconnectButton As System.Windows.Forms.Button
    Private WithEvents connectButton As System.Windows.Forms.Button

End Class
