Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        InitializeComponent()
        radarGauge.GaugeStyle = New CustomRadarStyle

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
    Friend WithEvents radarGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents radarTimer As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.radarGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.radarTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.radarGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radarGauge
        '
        Me.radarGauge.DialColor = System.Drawing.Color.Black
        Me.radarGauge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.radarGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThinNeedle3D
        Me.radarGauge.Location = New System.Drawing.Point(0, 0)
        Me.radarGauge.Name = "radarGauge"
        Me.radarGauge.PointerColor = System.Drawing.Color.White
        Me.radarGauge.ScaleArc = New NationalInstruments.UI.Arc(270.0!, -360.0!)
        Me.radarGauge.ScaleVisible = False
        Me.radarGauge.Size = New System.Drawing.Size(292, 273)
        Me.radarGauge.SpindleVisible = False
        Me.radarGauge.TabIndex = 1
        '
        'radarTimer
        '
        Me.radarTimer.Enabled = True
        Me.radarTimer.Interval = 50
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.radarGauge)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Radar Style"
        CType(Me.radarGauge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub radarTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radarTimer.Tick

        Dim gaugeValue As Double = radarGauge.Value + 0.1

        If gaugeValue > 10 Then
            gaugeValue = 0
        End If

        radarGauge.Value = gaugeValue
    End Sub
End Class
