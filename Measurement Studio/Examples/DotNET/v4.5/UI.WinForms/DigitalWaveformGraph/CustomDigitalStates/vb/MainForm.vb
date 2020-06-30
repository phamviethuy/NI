Imports NationalInstruments
Imports NationalInstruments.UI
Imports System.Drawing.Drawing2D
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

        plottingTimer_Tick(Me, EventArgs.Empty)
        OnSignalStateStyleChanged(Me, EventArgs.Empty)

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
    Friend WithEvents vertSplitter As System.Windows.Forms.Splitter
    Friend WithEvents plottingTimer As System.Windows.Forms.Timer
    Friend WithEvents plotButtonImageList As System.Windows.Forms.ImageList
    Friend WithEvents settingsPanel As System.Windows.Forms.Panel
    Friend WithEvents plotButton As System.Windows.Forms.Button
    Friend WithEvents signalStateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents customSignalStateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents defaultSignalStateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents waveformStateGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents customWaveformStateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents defaultWaveformStateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents plottingLabel As System.Windows.Forms.Label
    Friend WithEvents digitalWaveformPlot As NationalInstruments.UI.DigitalWaveformPlot
    Friend WithEvents digitalSignalPlot As NationalInstruments.UI.DigitalSignalPlot
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.digitalWaveformPlot = New NationalInstruments.UI.DigitalWaveformPlot
        Me.digitalSignalPlot = New NationalInstruments.UI.DigitalSignalPlot
        Me.sampleDigitalWaveformGraph = New NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
        Me.vertSplitter = New System.Windows.Forms.Splitter
        Me.plottingTimer = New System.Windows.Forms.Timer(Me.components)
        Me.plotButtonImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.settingsPanel = New System.Windows.Forms.Panel
        Me.plotButton = New System.Windows.Forms.Button
        Me.signalStateGroupBox = New System.Windows.Forms.GroupBox
        Me.customSignalStateRadioButton = New System.Windows.Forms.RadioButton
        Me.defaultSignalStateRadioButton = New System.Windows.Forms.RadioButton
        Me.waveformStateGroupBox = New System.Windows.Forms.GroupBox
        Me.customWaveformStateRadioButton = New System.Windows.Forms.RadioButton
        Me.defaultWaveformStateRadioButton = New System.Windows.Forms.RadioButton
        Me.plottingLabel = New System.Windows.Forms.Label
        CType(Me.sampleDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsPanel.SuspendLayout()
        Me.signalStateGroupBox.SuspendLayout()
        Me.waveformStateGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'digitalWaveformPlot
        '
        Me.digitalWaveformPlot.SignalPlots.AddRange(New NationalInstruments.UI.DigitalSignalPlot() {Me.digitalSignalPlot})
        '
        'sampleDigitalWaveformGraph
        '
        Me.sampleDigitalWaveformGraph.Caption = "Digital Waveform Graph"
        Me.sampleDigitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Right
        Me.sampleDigitalWaveformGraph.Location = New System.Drawing.Point(183, 0)
        Me.sampleDigitalWaveformGraph.Name = "sampleDigitalWaveformGraph"
        Me.sampleDigitalWaveformGraph.Plots.AddRange(New NationalInstruments.UI.DigitalWaveformPlot() {Me.digitalWaveformPlot})
        Me.sampleDigitalWaveformGraph.Size = New System.Drawing.Size(400, 316)
        Me.sampleDigitalWaveformGraph.TabIndex = 3
        '
        'vertSplitter
        '
        Me.vertSplitter.Dock = System.Windows.Forms.DockStyle.Right
        Me.vertSplitter.Location = New System.Drawing.Point(583, 0)
        Me.vertSplitter.Name = "vertSplitter"
        Me.vertSplitter.Size = New System.Drawing.Size(3, 316)
        Me.vertSplitter.TabIndex = 5
        Me.vertSplitter.TabStop = False
        '
        'plottingTimer
        '
        Me.plottingTimer.Enabled = True
        Me.plottingTimer.Interval = 1000
        '
        'plotButtonImageList
        '
        Me.plotButtonImageList.ImageSize = New System.Drawing.Size(16, 16)
        Me.plotButtonImageList.ImageStream = CType(resources.GetObject("plotButtonImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.plotButtonImageList.TransparentColor = System.Drawing.Color.Magenta
        '
        'settingsPanel
        '
        Me.settingsPanel.AutoScroll = True
        Me.settingsPanel.Controls.Add(Me.plotButton)
        Me.settingsPanel.Controls.Add(Me.signalStateGroupBox)
        Me.settingsPanel.Controls.Add(Me.waveformStateGroupBox)
        Me.settingsPanel.Controls.Add(Me.plottingLabel)
        Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.settingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(183, 316)
        Me.settingsPanel.TabIndex = 4
        '
        'plotButton
        '
        Me.plotButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.plotButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.plotButton.ImageIndex = 1
        Me.plotButton.ImageList = Me.plotButtonImageList
        Me.plotButton.Location = New System.Drawing.Point(112, 24)
        Me.plotButton.Name = "plotButton"
        Me.plotButton.Size = New System.Drawing.Size(48, 24)
        Me.plotButton.TabIndex = 5
        '
        'signalStateGroupBox
        '
        Me.signalStateGroupBox.Controls.Add(Me.customSignalStateRadioButton)
        Me.signalStateGroupBox.Controls.Add(Me.defaultSignalStateRadioButton)
        Me.signalStateGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.signalStateGroupBox.Location = New System.Drawing.Point(16, 192)
        Me.signalStateGroupBox.Name = "signalStateGroupBox"
        Me.signalStateGroupBox.Size = New System.Drawing.Size(144, 96)
        Me.signalStateGroupBox.TabIndex = 1
        Me.signalStateGroupBox.TabStop = False
        Me.signalStateGroupBox.Text = "Signal State Style"
        '
        'customSignalStateRadioButton
        '
        Me.customSignalStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customSignalStateRadioButton.Location = New System.Drawing.Point(20, 64)
        Me.customSignalStateRadioButton.Name = "customSignalStateRadioButton"
        Me.customSignalStateRadioButton.TabIndex = 2
        Me.customSignalStateRadioButton.Text = "Custom"
        '
        'defaultSignalStateRadioButton
        '
        Me.defaultSignalStateRadioButton.Checked = True
        Me.defaultSignalStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultSignalStateRadioButton.Location = New System.Drawing.Point(20, 24)
        Me.defaultSignalStateRadioButton.Name = "defaultSignalStateRadioButton"
        Me.defaultSignalStateRadioButton.TabIndex = 1
        Me.defaultSignalStateRadioButton.TabStop = True
        Me.defaultSignalStateRadioButton.Text = "Default"
        '
        'waveformStateGroupBox
        '
        Me.waveformStateGroupBox.Controls.Add(Me.customWaveformStateRadioButton)
        Me.waveformStateGroupBox.Controls.Add(Me.defaultWaveformStateRadioButton)
        Me.waveformStateGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.waveformStateGroupBox.Location = New System.Drawing.Point(16, 72)
        Me.waveformStateGroupBox.Name = "waveformStateGroupBox"
        Me.waveformStateGroupBox.Size = New System.Drawing.Size(144, 96)
        Me.waveformStateGroupBox.TabIndex = 0
        Me.waveformStateGroupBox.TabStop = False
        Me.waveformStateGroupBox.Text = "Waveform State Style"
        '
        'customWaveformStateRadioButton
        '
        Me.customWaveformStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customWaveformStateRadioButton.Location = New System.Drawing.Point(20, 64)
        Me.customWaveformStateRadioButton.Name = "customWaveformStateRadioButton"
        Me.customWaveformStateRadioButton.TabIndex = 1
        Me.customWaveformStateRadioButton.Text = "Custom"
        '
        'defaultWaveformStateRadioButton
        '
        Me.defaultWaveformStateRadioButton.Checked = True
        Me.defaultWaveformStateRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultWaveformStateRadioButton.Location = New System.Drawing.Point(20, 24)
        Me.defaultWaveformStateRadioButton.Name = "defaultWaveformStateRadioButton"
        Me.defaultWaveformStateRadioButton.TabIndex = 0
        Me.defaultWaveformStateRadioButton.TabStop = True
        Me.defaultWaveformStateRadioButton.Text = "Default"
        '
        'plottingLabel
        '
        Me.plottingLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.plottingLabel.Location = New System.Drawing.Point(16, 28)
        Me.plottingLabel.Name = "plottingLabel"
        Me.plottingLabel.Size = New System.Drawing.Size(104, 16)
        Me.plottingLabel.TabIndex = 4
        Me.plottingLabel.Text = "Plot Digital Values"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(586, 316)
        Me.Controls.Add(Me.settingsPanel)
        Me.Controls.Add(Me.sampleDigitalWaveformGraph)
        Me.Controls.Add(Me.vertSplitter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Digital States"
        CType(Me.sampleDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsPanel.ResumeLayout(False)
        Me.signalStateGroupBox.ResumeLayout(False)
        Me.waveformStateGroupBox.ResumeLayout(False)
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


    Private Sub OnWaveformStateStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles defaultWaveformStateRadioButton.CheckedChanged, customWaveformStateRadioButton.CheckedChanged
        If defaultWaveformStateRadioButton.Checked = True Then
            sampleDigitalWaveformGraph.Plots(0).SampleStyle = DigitalWaveformSampleStyle.Simple
        Else
            sampleDigitalWaveformGraph.Plots(0).SampleStyle = CustomStyles.GetShadedStyle()
        End If
    End Sub 'OnWaveformStateStyleChanged


    Private Sub OnSignalStateStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles defaultSignalStateRadioButton.CheckedChanged, customSignalStateRadioButton.CheckedChanged
        Dim signalPlot As DigitalSignalPlot
        For Each signalPlot In digitalWaveformPlot.SignalPlots
            signalPlot.StateLabelVisible = True
            If defaultSignalStateRadioButton.Checked = True Then
                signalPlot.StateStyle = DigitalStateStyle.Simple
            Else
                signalPlot.StateStyle = CustomStyles.GetCharactersStyle()
            End If
        Next signalPlot
    End Sub 'OnSignalStateStyleChanged


    Private Sub plottingTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles plottingTimer.Tick
        sampleDigitalWaveformGraph.PlotWaveform(CreateRandomWaveform(25, 6))
    End Sub 'plottingTimer_Tick


    Private Sub OnPlotButtonClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles plotButton.Click
        plottingTimer.Enabled = Not plottingTimer.Enabled
        If plottingTimer.Enabled Then
            plotButton.ImageIndex = 1
            plottingTimer_Tick(Me, EventArgs.Empty)
        Else
            plotButton.ImageIndex = 0
        End If
    End Sub 'OnPlotButtonClick


    Public Class CustomStyles

        Private Shared shadedStyle As DigitalWaveformSampleStyle = New ShadedBusStyleImpl

        Private Shared charactersStyle As DigitalStateStyle = New CharactersLineStyleImpl

        Public Shared Function GetShadedStyle() As DigitalWaveformSampleStyle
            Return shadedStyle
        End Function
        Public Shared Function GetCharactersStyle() As DigitalStateStyle
            Return charactersStyle
        End Function

        Private Class ShadedBusStyleImpl
            Inherits DigitalWaveformSampleStyle

            Private _stateColor As Color

            Public Sub New()
                MyBase.New()
                _stateColor = Color.Teal
            End Sub

            Public Overrides Sub DrawSample(ByVal context As Object, ByVal args As DigitalWaveformSampleStyleDrawArgs)
                Dim nextPoints() As PointF = {PointF.Empty}
                Dim previousPoints() As PointF = {PointF.Empty}
                GetSamplePoints(args.StateBounds, args.Sample, args.WaveformPlot.LineWidth, previousPoints, nextPoints)
                If ((previousPoints.Length > 1) _
                            AndAlso (nextPoints.Length > 1)) Then
                    Dim brush As Brush = New HatchBrush(HatchStyle.DiagonalBrick, _stateColor, Color.Red)
                    args.Graphics.FillRectangle(brush, args.LabelBounds)
                End If

                DigitalWaveformSampleStyle.Simple.DrawSample(context, args)
                args.SetTransitionInfo(previousPoints, nextPoints, _stateColor)
            End Sub
        End Class

        Private Class CharactersLineStyleImpl
            Inherits DigitalStateStyle

            Private Shared Function GetCustomChar(ByVal state As DigitalState) As Char
                Dim label As Char
                Select Case (state)
                    Case DigitalState.ForceUp
                        label = "J"c
                    Case DigitalState.ForceDown
                        label = "L"c
                    Case DigitalState.ForceOff
                        label = "M"c
                    Case DigitalState.CompareUnknown
                        label = "N"c
                    Case Else
                        label = DigitalStateUtility.ToChar(state)
                End Select
                Return label
            End Function

            Public Overrides Sub DrawLabel(ByVal context As Object, ByVal args As DigitalStateStyleDrawArgs)
                If args.SignalPlot.StateLabelVisible Then
                    Dim foreColor As Color = args.SignalPlot.StateLabelForeColor
                    Dim font As Font = New Font("WingDings", (args.SignalPlot.StateLabelFont.Size + 6))
                    Dim brush As Brush = New SolidBrush(Color.White)
                    Dim labelBounds As Rectangle = args.LabelBounds
                    Dim charLabel As Char = GetCustomChar(args.SignalState)
                    Dim label As String = charLabel.ToString
                    Dim labelSize As SizeF = args.Graphics.MeasureString(label, font)
                    Dim centerWidth As Single = ((labelBounds.Width - labelSize.Width) _
                                / 2)
                    Dim centerHeight As Single = ((labelBounds.Height - labelSize.Height) _
                                / 2)
                    Dim labelPoint As PointF = New PointF((labelBounds.X + centerWidth), (labelBounds.Y + centerHeight))

                    args.Graphics.DrawString(label, font, brush, labelPoint)
                End If
            End Sub

            Public Overrides Sub DrawState(ByVal context As Object, ByVal args As DigitalStateStyleDrawArgs)
                DigitalStateStyle.Simple.DrawState(context, args)
            End Sub
        End Class
    End Class



End Class
