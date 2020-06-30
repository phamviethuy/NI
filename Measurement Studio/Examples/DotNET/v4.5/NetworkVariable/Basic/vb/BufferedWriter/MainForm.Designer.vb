<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If

        If disposing Then
            If (bufferedWriter IsNot Nothing) Then
                bufferedWriter.Dispose()
            End If

            If (doubleBufferedWriter IsNot Nothing) Then
                doubleBufferedWriter.Dispose()
            End If

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
        Me.amplitudeSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.connectionTextBox = New System.Windows.Forms.TextBox
        Me.connectionStatusLabel = New System.Windows.Forms.Label
        Me.stopButton = New System.Windows.Forms.Button
        Me.startButton = New System.Windows.Forms.Button
        CType(Me.displayWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amplitudeSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'displayWaveformGraph
        '
        Me.displayWaveformGraph.Location = New System.Drawing.Point(89, 12)
        Me.displayWaveformGraph.Name = "displayWaveformGraph"
        Me.displayWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.WaveformPlot1})
        Me.displayWaveformGraph.Size = New System.Drawing.Size(288, 206)
        Me.displayWaveformGraph.TabIndex = 0
        Me.displayWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.displayWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        '
        'WaveformPlot1
        '
        Me.WaveformPlot1.XAxis = Me.XAxis1
        Me.WaveformPlot1.YAxis = Me.YAxis1
        '
        'YAxis1
        '
        Me.YAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.YAxis1.Range = New NationalInstruments.UI.Range(-10, 10)
        '
        'amplitudeSlide
        '
        Me.amplitudeSlide.Caption = "Amplitude"
        Me.amplitudeSlide.Location = New System.Drawing.Point(15, 12)
        Me.amplitudeSlide.Name = "amplitudeSlide"
        Me.amplitudeSlide.Size = New System.Drawing.Size(68, 206)
        Me.amplitudeSlide.TabIndex = 1
        Me.amplitudeSlide.Value = 10
        '
        'connectionTextBox
        '
        Me.connectionTextBox.Location = New System.Drawing.Point(117, 226)
        Me.connectionTextBox.Name = "connectionTextBox"
        Me.connectionTextBox.ReadOnly = True
        Me.connectionTextBox.Size = New System.Drawing.Size(157, 20)
        Me.connectionTextBox.TabIndex = 13
        Me.connectionTextBox.Text = "Disconnected"
        '
        'connectionStatusLabel
        '
        Me.connectionStatusLabel.AutoSize = True
        Me.connectionStatusLabel.Location = New System.Drawing.Point(12, 229)
        Me.connectionStatusLabel.Name = "connectionStatusLabel"
        Me.connectionStatusLabel.Size = New System.Drawing.Size(97, 13)
        Me.connectionStatusLabel.TabIndex = 12
        Me.connectionStatusLabel.Text = "Connection Status:"
        '
        'stopButton
        '
        Me.stopButton.Enabled = False
        Me.stopButton.Location = New System.Drawing.Point(117, 262)
        Me.stopButton.Name = "stopButton"
        Me.stopButton.Size = New System.Drawing.Size(91, 23)
        Me.stopButton.TabIndex = 11
        Me.stopButton.Text = "Stop Writing"
        Me.stopButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(15, 262)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(94, 23)
        Me.startButton.TabIndex = 10
        Me.startButton.Text = "Start Writing"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 297)
        Me.Controls.Add(Me.connectionTextBox)
        Me.Controls.Add(Me.connectionStatusLabel)
        Me.Controls.Add(Me.stopButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.amplitudeSlide)
        Me.Controls.Add(Me.displayWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Buffered Writer"
        CType(Me.displayWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amplitudeSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents displayWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents WaveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents XAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents amplitudeSlide As NationalInstruments.UI.WindowsForms.Slide
    Private WithEvents connectionTextBox As System.Windows.Forms.TextBox
    Private WithEvents connectionStatusLabel As System.Windows.Forms.Label
    Private WithEvents stopButton As System.Windows.Forms.Button
    Private WithEvents startButton As System.Windows.Forms.Button

End Class
