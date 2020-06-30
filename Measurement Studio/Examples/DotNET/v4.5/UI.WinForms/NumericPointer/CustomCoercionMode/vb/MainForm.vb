Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "
    Private toIntervalRange As Range
    Private noCoerceRange As Range

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Dim gaugeMax As Double = coercionGauge.Range.Maximum
        Dim gaugeMin As Double = coercionGauge.Range.Minimum

        Dim rangeInterval As Integer = CInt((gaugeMax - gaugeMin) / 3)

        toIntervalRange = New Range(0, rangeInterval)
        noCoerceRange = New Range(rangeInterval, 2 * rangeInterval)

        coercionGauge.CoercionMode = New CustomCoercion(noCoerceRange, toIntervalRange)
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
    Friend WithEvents gaugeParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents coercionBaseLabel As System.Windows.Forms.Label
    Friend WithEvents coercionIntervalLabel As System.Windows.Forms.Label
    Friend WithEvents coercionIntervalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents gaugeValueLabel As System.Windows.Forms.Label
    Friend WithEvents coercionBaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents valueNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents coercionGauge As NationalInstruments.UI.WindowsForms.Gauge
    Friend WithEvents toDivisionCoercionLabel As System.Windows.Forms.Label
    Friend WithEvents noCoercionLabel As System.Windows.Forms.Label
    Friend WithEvents intervalCoercionLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim ScaleRangeFill1 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill2 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim ScaleRangeFill3 As NationalInstruments.UI.ScaleRangeFill = New NationalInstruments.UI.ScaleRangeFill
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.gaugeParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.coercionBaseLabel = New System.Windows.Forms.Label
        Me.coercionIntervalLabel = New System.Windows.Forms.Label
        Me.coercionIntervalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.gaugeValueLabel = New System.Windows.Forms.Label
        Me.coercionBaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.valueNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.coercionGauge = New NationalInstruments.UI.WindowsForms.Gauge
        Me.toDivisionCoercionLabel = New System.Windows.Forms.Label
        Me.noCoercionLabel = New System.Windows.Forms.Label
        Me.intervalCoercionLabel = New System.Windows.Forms.Label
        Me.gaugeParametersGroupBox.SuspendLayout()
        CType(Me.coercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coercionBaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.valueNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coercionGauge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gaugeParametersGroupBox
        '
        Me.gaugeParametersGroupBox.Controls.Add(Me.coercionBaseLabel)
        Me.gaugeParametersGroupBox.Controls.Add(Me.coercionIntervalLabel)
        Me.gaugeParametersGroupBox.Controls.Add(Me.coercionIntervalNumericEdit)
        Me.gaugeParametersGroupBox.Controls.Add(Me.gaugeValueLabel)
        Me.gaugeParametersGroupBox.Controls.Add(Me.coercionBaseNumericEdit)
        Me.gaugeParametersGroupBox.Controls.Add(Me.valueNumericEdit)
        Me.gaugeParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gaugeParametersGroupBox.Location = New System.Drawing.Point(5, 272)
        Me.gaugeParametersGroupBox.Name = "gaugeParametersGroupBox"
        Me.gaugeParametersGroupBox.Size = New System.Drawing.Size(328, 120)
        Me.gaugeParametersGroupBox.TabIndex = 0
        Me.gaugeParametersGroupBox.TabStop = False
        Me.gaugeParametersGroupBox.Text = "Gauge Parameters"
        '
        'coercionBaseLabel
        '
        Me.coercionBaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coercionBaseLabel.Location = New System.Drawing.Point(8, 88)
        Me.coercionBaseLabel.Name = "coercionBaseLabel"
        Me.coercionBaseLabel.Size = New System.Drawing.Size(112, 16)
        Me.coercionBaseLabel.TabIndex = 9
        Me.coercionBaseLabel.Text = "Coercion Interval Base:"
        '
        'coercionIntervalLabel
        '
        Me.coercionIntervalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coercionIntervalLabel.Location = New System.Drawing.Point(8, 56)
        Me.coercionIntervalLabel.Name = "coercionIntervalLabel"
        Me.coercionIntervalLabel.Size = New System.Drawing.Size(88, 16)
        Me.coercionIntervalLabel.TabIndex = 8
        Me.coercionIntervalLabel.Text = "Coercion Interval:"
        '
        'coercionIntervalNumericEdit
        '
        Me.coercionIntervalNumericEdit.CoercionInterval = 0.5
        Me.coercionIntervalNumericEdit.Location = New System.Drawing.Point(184, 56)
        Me.coercionIntervalNumericEdit.Name = "coercionIntervalNumericEdit"
        Me.coercionIntervalNumericEdit.TabIndex = 1
        Me.coercionIntervalNumericEdit.Value = 1
        '
        'gaugeValueLabel
        '
        Me.gaugeValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gaugeValueLabel.Location = New System.Drawing.Point(8, 24)
        Me.gaugeValueLabel.Name = "gaugeValueLabel"
        Me.gaugeValueLabel.Size = New System.Drawing.Size(80, 16)
        Me.gaugeValueLabel.TabIndex = 2
        Me.gaugeValueLabel.Text = "Gauge Value:"
        '
        'coercionBaseNumericEdit
        '
        Me.coercionBaseNumericEdit.CoercionInterval = 0.5
        Me.coercionBaseNumericEdit.Location = New System.Drawing.Point(184, 88)
        Me.coercionBaseNumericEdit.Name = "coercionBaseNumericEdit"
        Me.coercionBaseNumericEdit.TabIndex = 2
        '
        'valueNumericEdit
        '
        Me.valueNumericEdit.Location = New System.Drawing.Point(184, 24)
        Me.valueNumericEdit.Name = "valueNumericEdit"
        Me.valueNumericEdit.Source = Me.coercionGauge
        Me.valueNumericEdit.TabIndex = 0
        '
        'coercionGauge
        '
        Me.coercionGauge.CaptionVisible = True
        Me.coercionGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThickNeedle
        Me.coercionGauge.InteractionMode = CType((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.RadialNumericPointerInteractionModes)
        Me.coercionGauge.Location = New System.Drawing.Point(0, 0)
        Me.coercionGauge.Name = "coercionGauge"
        Me.coercionGauge.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        ScaleRangeFill1.Range = New NationalInstruments.UI.Range(0, 3)
        ScaleRangeFill2.Range = New NationalInstruments.UI.Range(3, 6)
        ScaleRangeFill2.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateStyleFromFillStyle(NationalInstruments.UI.FillStyle.HorizontalBrick, System.Drawing.Color.Aqua)
        ScaleRangeFill3.Range = New NationalInstruments.UI.Range(6, 10)
        ScaleRangeFill3.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateGradientStyle(System.Drawing.Color.Red, System.Drawing.Color.Yellow, 0.5!)
        Me.coercionGauge.RangeFills.AddRange(New NationalInstruments.UI.ScaleRangeFill() {ScaleRangeFill1, ScaleRangeFill2, ScaleRangeFill3})
        Me.coercionGauge.Size = New System.Drawing.Size(344, 272)
        Me.coercionGauge.TabIndex = 1
        '
        'toDivisionCoercionLabel
        '
        Me.toDivisionCoercionLabel.Location = New System.Drawing.Point(269, 16)
        Me.toDivisionCoercionLabel.Name = "toDivisionCoercionLabel"
        Me.toDivisionCoercionLabel.Size = New System.Drawing.Size(72, 24)
        Me.toDivisionCoercionLabel.TabIndex = 3
        Me.toDivisionCoercionLabel.Text = "To Division Coercion"
        '
        'noCoercionLabel
        '
        Me.noCoercionLabel.Location = New System.Drawing.Point(13, 16)
        Me.noCoercionLabel.Name = "noCoercionLabel"
        Me.noCoercionLabel.Size = New System.Drawing.Size(72, 16)
        Me.noCoercionLabel.TabIndex = 2
        Me.noCoercionLabel.Text = "No Coercion"
        '
        'intervalCoercionLabel
        '
        Me.intervalCoercionLabel.Location = New System.Drawing.Point(0, 216)
        Me.intervalCoercionLabel.Name = "intervalCoercionLabel"
        Me.intervalCoercionLabel.Size = New System.Drawing.Size(64, 24)
        Me.intervalCoercionLabel.TabIndex = 4
        Me.intervalCoercionLabel.Text = "To Interval Coercion"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(338, 400)
        Me.Controls.Add(Me.toDivisionCoercionLabel)
        Me.Controls.Add(Me.noCoercionLabel)
        Me.Controls.Add(Me.intervalCoercionLabel)
        Me.Controls.Add(Me.gaugeParametersGroupBox)
        Me.Controls.Add(Me.coercionGauge)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Coercion Mode"
        Me.gaugeParametersGroupBox.ResumeLayout(False)
        CType(Me.coercionIntervalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coercionBaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.valueNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coercionGauge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub coercionIntervalNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As UI.AfterChangeNumericValueEventArgs) Handles coercionIntervalNumericEdit.AfterChangeValue
        coercionGauge.CoercionInterval = coercionIntervalNumericEdit.Value
    End Sub

    Private Sub coercionBaseNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As UI.AfterChangeNumericValueEventArgs) Handles coercionBaseNumericEdit.AfterChangeValue
        coercionGauge.CoercionIntervalBase = coercionBaseNumericEdit.Value
    End Sub
End Class
