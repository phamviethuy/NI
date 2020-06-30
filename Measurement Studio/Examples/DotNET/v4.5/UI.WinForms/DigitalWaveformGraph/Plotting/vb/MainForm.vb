Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms
Imports NationalInstruments
Public Class MainForm
    Inherits System.Windows.Forms.Form
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub


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
    Friend WithEvents sampleDigitalWaveformGraph As NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
    Friend WithEvents randomPlottingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents numberOfPlotsLabel As System.Windows.Forms.Label
    Friend WithEvents displayModeLabel As System.Windows.Forms.Label
    Friend WithEvents displayModePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents plotButton As System.Windows.Forms.Button
    Friend WithEvents numberOfPlotsSlide As NationalInstruments.UI.WindowsForms.Slide
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.sampleDigitalWaveformGraph = New NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
        Me.randomPlottingGroupBox = New System.Windows.Forms.GroupBox
        Me.numberOfPlotsSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.numberOfPlotsLabel = New System.Windows.Forms.Label
        Me.displayModeLabel = New System.Windows.Forms.Label
        Me.displayModePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.plotButton = New System.Windows.Forms.Button
        CType(Me.sampleDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.randomPlottingGroupBox.SuspendLayout()
        CType(Me.numberOfPlotsSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sampleDigitalWaveformGraph
        '
        Me.sampleDigitalWaveformGraph.Caption = "Digital Waveform Graph"
        Me.sampleDigitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Top
        Me.sampleDigitalWaveformGraph.Location = New System.Drawing.Point(0, 0)
        Me.sampleDigitalWaveformGraph.Name = "sampleDigitalWaveformGraph"
        Me.sampleDigitalWaveformGraph.Size = New System.Drawing.Size(430, 252)
        Me.sampleDigitalWaveformGraph.TabIndex = 0
        '
        'randomPlottingGroupBox
        '
        Me.randomPlottingGroupBox.Controls.Add(Me.numberOfPlotsSlide)
        Me.randomPlottingGroupBox.Controls.Add(Me.numberOfPlotsLabel)
        Me.randomPlottingGroupBox.Controls.Add(Me.displayModeLabel)
        Me.randomPlottingGroupBox.Controls.Add(Me.displayModePropertyEditor)
        Me.randomPlottingGroupBox.Controls.Add(Me.plotButton)
        Me.randomPlottingGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.randomPlottingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.randomPlottingGroupBox.Location = New System.Drawing.Point(0, 252)
        Me.randomPlottingGroupBox.Name = "randomPlottingGroupBox"
        Me.randomPlottingGroupBox.Size = New System.Drawing.Size(430, 146)
        Me.randomPlottingGroupBox.TabIndex = 4
        Me.randomPlottingGroupBox.TabStop = False
        Me.randomPlottingGroupBox.Text = "Random Plotting"
        '
        'numberOfPlotsSlide
        '
        Me.numberOfPlotsSlide.AutoDivisionSpacing = False
        Me.numberOfPlotsSlide.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions
        Me.numberOfPlotsSlide.FillBackColor = System.Drawing.Color.Transparent
        Me.numberOfPlotsSlide.FillColor = System.Drawing.Color.Transparent
        Me.numberOfPlotsSlide.Location = New System.Drawing.Point(8, 41)
        Me.numberOfPlotsSlide.MajorDivisions.Interval = 1
        Me.numberOfPlotsSlide.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "F0")
        Me.numberOfPlotsSlide.Name = "numberOfPlotsSlide"
        Me.numberOfPlotsSlide.Range = New NationalInstruments.UI.Range(1, 5)
        Me.numberOfPlotsSlide.ScaleBaseLineVisible = True
        Me.numberOfPlotsSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom
        Me.numberOfPlotsSlide.Size = New System.Drawing.Size(168, 40)
        Me.numberOfPlotsSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip
        Me.numberOfPlotsSlide.TabIndex = 2
        Me.numberOfPlotsSlide.Value = 1
        '
        'numberOfPlotsLabel
        '
        Me.numberOfPlotsLabel.AutoSize = True
        Me.numberOfPlotsLabel.Location = New System.Drawing.Point(8, 23)
        Me.numberOfPlotsLabel.Name = "numberOfPlotsLabel"
        Me.numberOfPlotsLabel.Size = New System.Drawing.Size(108, 13)
        Me.numberOfPlotsLabel.TabIndex = 8
        Me.numberOfPlotsLabel.Text = "Number Of Bus Plots:"
        '
        'displayModeLabel
        '
        Me.displayModeLabel.AutoSize = True
        Me.displayModeLabel.Location = New System.Drawing.Point(240, 23)
        Me.displayModeLabel.Name = "displayModeLabel"
        Me.displayModeLabel.Size = New System.Drawing.Size(74, 13)
        Me.displayModeLabel.TabIndex = 7
        Me.displayModeLabel.Text = "Display Mode:"
        '
        'displayModePropertyEditor
        '
        Me.displayModePropertyEditor.Location = New System.Drawing.Point(240, 44)
        Me.displayModePropertyEditor.Name = "displayModePropertyEditor"
        Me.displayModePropertyEditor.Size = New System.Drawing.Size(168, 20)
        Me.displayModePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.sampleDigitalWaveformGraph, "DisplayMode")
        Me.displayModePropertyEditor.TabIndex = 3
        '
        'plotButton
        '
        Me.plotButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotButton.Location = New System.Drawing.Point(138, 96)
        Me.plotButton.Name = "plotButton"
        Me.plotButton.Size = New System.Drawing.Size(144, 32)
        Me.plotButton.TabIndex = 4
        Me.plotButton.Text = "Plot"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(430, 398)
        Me.Controls.Add(Me.randomPlottingGroupBox)
        Me.Controls.Add(Me.sampleDigitalWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plotting Example"
        CType(Me.sampleDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.randomPlottingGroupBox.ResumeLayout(False)
        Me.randomPlottingGroupBox.PerformLayout()
        CType(Me.numberOfPlotsSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Shared Function CreateRandomWaveform(ByVal sampleCount As Integer, ByVal signalCount As Integer) As DigitalWaveform
        Dim rand As New Random
        Dim randValue As Double
        Dim state As DigitalState
        Dim wave As New DigitalWaveform(sampleCount, signalCount)
        Dim s As Integer
        For s = 0 To sampleCount - 1
            Dim l As Integer
            For l = 0 To signalCount - 1
                randValue = rand.NextDouble()
                If randValue < 0.4875 Then
                    state = DigitalState.ForceUp
                Else
                    If randValue < 0.975 Then
                        state = DigitalState.ForceDown
                    Else
                        If randValue < 0.9875 Then
                            state = DigitalState.ForceOff
                        Else
                            state = DigitalState.CompareUnknown
                        End If
                    End If
                End If
                wave.Samples(s).States(l) = state
            Next l
        Next s
        Return wave
    End Function 'CreateRandomWaveform
    Private Sub plotButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotButton.Click
        Dim busPlots(CInt(numberOfPlotsSlide.Value - 1)) As DigitalWaveform
        Dim rand As New Random

        Dim i As Integer
        For i = 0 To numberOfPlotsSlide.Value - 1
            busPlots(i) = CreateRandomWaveform(rand.Next(25, 30), rand.Next(3, 8))
        Next i

        sampleDigitalWaveformGraph.PlotWaveforms(busPlots)
    End Sub
End Class
