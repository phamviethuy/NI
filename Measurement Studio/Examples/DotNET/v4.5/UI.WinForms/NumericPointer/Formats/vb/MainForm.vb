Public Class MainForm
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
    Friend WithEvents voltSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents ohmSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents powerLimitSlide As NationalInstruments.UI.WindowsForms.Slide
    Friend WithEvents powerGauge As NationalInstruments.UI.WindowsForms.Gauge
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ScaleCustomDivision1 As NationalInstruments.UI.ScaleCustomDivision = New NationalInstruments.UI.ScaleCustomDivision
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.voltSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.ohmSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.powerLimitSlide = New NationalInstruments.UI.WindowsForms.Slide
        Me.powerGauge = New NationalInstruments.UI.WindowsForms.Gauge
        CType(Me.voltSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ohmSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.powerLimitSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.powerGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'voltSlide
        '
        Me.voltSlide.Caption = "Volts"
        Me.voltSlide.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom
        Me.voltSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum
        Me.voltSlide.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient
        Me.voltSlide.InvertedScale = True
        Me.voltSlide.Location = New System.Drawing.Point(0, 88)
        Me.voltSlide.MajorDivisions.Interval = 1
        Me.voltSlide.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S'V'")
        Me.voltSlide.Name = "voltSlide"
        Me.voltSlide.Range = New NationalInstruments.UI.Range(0, 20)
        Me.voltSlide.Size = New System.Drawing.Size(88, 232)
        Me.voltSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip
        Me.voltSlide.TabIndex = 0
        '
        'ohmSlide
        '
        Me.ohmSlide.Caption = "Resistance"
        Me.ohmSlide.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom
        Me.ohmSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum
        Me.ohmSlide.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient
        Me.ohmSlide.InvertedScale = True
        Me.ohmSlide.Location = New System.Drawing.Point(96, 88)
        Me.ohmSlide.MajorDivisions.Interval = 1
        Me.ohmSlide.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S' Ohm'")
        Me.ohmSlide.Name = "ohmSlide"
        Me.ohmSlide.Range = New NationalInstruments.UI.Range(1, 10)
        Me.ohmSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Right
        Me.ohmSlide.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.ohmSlide.Size = New System.Drawing.Size(109, 232)
        Me.ohmSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip
        Me.ohmSlide.TabIndex = 1
        Me.ohmSlide.Value = 1
        '
        'powerLimitSlide
        '
        Me.powerLimitSlide.Caption = "Power Limit"
        Me.powerLimitSlide.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient
        Me.powerLimitSlide.Location = New System.Drawing.Point(8, 0)
        Me.powerLimitSlide.MajorDivisions.Interval = 1000
        Me.powerLimitSlide.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S'W'")
        Me.powerLimitSlide.Name = "powerLimitSlide"
        Me.powerLimitSlide.Range = New NationalInstruments.UI.Range(1, 400)
        Me.powerLimitSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Top
        Me.powerLimitSlide.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic
        Me.powerLimitSlide.Size = New System.Drawing.Size(440, 72)
        Me.powerLimitSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip
        Me.powerLimitSlide.TabIndex = 2
        Me.powerLimitSlide.Value = 400
        '
        'powerGauge
        '
        Me.powerGauge.AutoDivisionSpacing = False
        Me.powerGauge.Caption = "Power"
        Me.powerGauge.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom
        ScaleCustomDivision1.LabelVisible = False
        ScaleCustomDivision1.LineWidth = 5.0!
        ScaleCustomDivision1.TickLength = 10.0!
        ScaleCustomDivision1.Value = 400
        Me.powerGauge.CustomDivisions.AddRange(New NationalInstruments.UI.ScaleCustomDivision() {ScaleCustomDivision1})
        Me.powerGauge.Location = New System.Drawing.Point(224, 80)
        Me.powerGauge.MajorDivisions.Interval = 40
        Me.powerGauge.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0 W")
        Me.powerGauge.MinorDivisions.Interval = 10
        Me.powerGauge.Name = "powerGauge"
        Me.powerGauge.Range = New NationalInstruments.UI.Range(0, 400)
        Me.powerGauge.Size = New System.Drawing.Size(232, 240)
        Me.powerGauge.TabIndex = 3
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(456, 346)
        Me.Controls.Add(Me.powerGauge)
        Me.Controls.Add(Me.powerLimitSlide)
        Me.Controls.Add(Me.ohmSlide)
        Me.Controls.Add(Me.voltSlide)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Numeric Pointer Formats"
        CType(Me.voltSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ohmSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.powerLimitSlide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.powerGauge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Private Sub voltSlide_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles voltSlide.AfterChangeValue
        powerGauge.Value = GetPower(e.NewValue, ohmSlide.Value)
    End Sub
    Private Sub powerLimitSlide_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles powerLimitSlide.AfterChangeValue
        powerGauge.CustomDivisions.Item(0).Value = e.NewValue
    End Sub

    Private Sub ohmSlide_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles ohmSlide.AfterChangeValue
        powerGauge.Value = GetPower(voltSlide.Value, e.NewValue)
    End Sub
    Private Sub voltSlide_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles voltSlide.BeforeChangeValue
        Dim power As Double
        power = GetPower(e.NewValue, ohmSlide.Value)
        e.Cancel = (power > powerGauge.CustomDivisions.Item(0).Value)
    End Sub
    Private Sub ohmSlide_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles ohmSlide.BeforeChangeValue
        Dim power As Double
        power = GetPower(voltSlide.Value, e.NewValue)
        e.Cancel = (power > powerGauge.CustomDivisions.Item(0).Value)
    End Sub
    Private Sub powerLimitSlide_BeforeChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles powerLimitSlide.BeforeChangeValue
        e.Cancel = (e.NewValue < powerGauge.Value)
    End Sub
    Private Shared Function GetPower(ByVal voltage As Double, ByVal resistance As Double) As Double
        Return (voltage * voltage) / resistance
    End Function
End Class
