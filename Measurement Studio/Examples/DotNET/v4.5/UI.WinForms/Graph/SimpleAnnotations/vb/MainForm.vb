Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private random As random
    Private newRange As NationalInstruments.UI.Range
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        Random = New Random
        genDataButton_Click(Nothing, Nothing)
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
    Friend WithEvents annotationSettingGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents scaleKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents genDataButton As System.Windows.Forms.Button
    Friend WithEvents dataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents waveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents maxXYPointAnnotation As NationalInstruments.UI.XYPointAnnotation
    Friend WithEvents minXYPointAnnotation As NationalInstruments.UI.XYPointAnnotation
    Friend WithEvents showAllRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hideArrowsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hideAnnotationRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents hideShapesRadioButton As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.annotationSettingGroupBox = New System.Windows.Forms.GroupBox
        Me.showAllRadioButton = New System.Windows.Forms.RadioButton
        Me.hideArrowsRadioButton = New System.Windows.Forms.RadioButton
        Me.hideAnnotationRadioButton = New System.Windows.Forms.RadioButton
        Me.hideShapesRadioButton = New System.Windows.Forms.RadioButton
        Me.scaleKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.genDataButton = New System.Windows.Forms.Button
        Me.dataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.maxXYPointAnnotation = New NationalInstruments.UI.XYPointAnnotation
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.minXYPointAnnotation = New NationalInstruments.UI.XYPointAnnotation
        Me.waveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.annotationSettingGroupBox.SuspendLayout()
        CType(Me.scaleKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'annotationSettingGroupBox
        '
        Me.annotationSettingGroupBox.Controls.Add(Me.showAllRadioButton)
        Me.annotationSettingGroupBox.Controls.Add(Me.hideArrowsRadioButton)
        Me.annotationSettingGroupBox.Controls.Add(Me.hideAnnotationRadioButton)
        Me.annotationSettingGroupBox.Controls.Add(Me.hideShapesRadioButton)
        Me.annotationSettingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.annotationSettingGroupBox.Location = New System.Drawing.Point(224, 240)
        Me.annotationSettingGroupBox.Name = "annotationSettingGroupBox"
        Me.annotationSettingGroupBox.Size = New System.Drawing.Size(160, 152)
        Me.annotationSettingGroupBox.TabIndex = 3
        Me.annotationSettingGroupBox.TabStop = False
        Me.annotationSettingGroupBox.Text = "Annotation Settings"
        '
        'showAllRadioButton
        '
        Me.showAllRadioButton.Checked = True
        Me.showAllRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.showAllRadioButton.Location = New System.Drawing.Point(20, 114)
        Me.showAllRadioButton.Name = "showAllRadioButton"
        Me.showAllRadioButton.Size = New System.Drawing.Size(120, 24)
        Me.showAllRadioButton.TabIndex = 14
        Me.showAllRadioButton.TabStop = True
        Me.showAllRadioButton.Text = "Show All"
        '
        'hideArrowsRadioButton
        '
        Me.hideArrowsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hideArrowsRadioButton.Location = New System.Drawing.Point(20, 46)
        Me.hideArrowsRadioButton.Name = "hideArrowsRadioButton"
        Me.hideArrowsRadioButton.Size = New System.Drawing.Size(120, 32)
        Me.hideArrowsRadioButton.TabIndex = 12
        Me.hideArrowsRadioButton.Text = "Hide Annotation Arrows"
        '
        'hideAnnotationRadioButton
        '
        Me.hideAnnotationRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hideAnnotationRadioButton.Location = New System.Drawing.Point(20, 12)
        Me.hideAnnotationRadioButton.Name = "hideAnnotationRadioButton"
        Me.hideAnnotationRadioButton.Size = New System.Drawing.Size(120, 32)
        Me.hideAnnotationRadioButton.TabIndex = 11
        Me.hideAnnotationRadioButton.Text = "Hide Annotations"
        '
        'hideShapesRadioButton
        '
        Me.hideShapesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hideShapesRadioButton.Location = New System.Drawing.Point(20, 80)
        Me.hideShapesRadioButton.Name = "hideShapesRadioButton"
        Me.hideShapesRadioButton.Size = New System.Drawing.Size(120, 32)
        Me.hideShapesRadioButton.TabIndex = 13
        Me.hideShapesRadioButton.Text = "Hide Annotation Shapes"
        '
        'scaleKnob
        '
        Me.scaleKnob.AutoDivisionSpacing = False
        Me.scaleKnob.Border = NationalInstruments.UI.Border.Etched
        Me.scaleKnob.Caption = "Scale Data"
        Me.scaleKnob.Location = New System.Drawing.Point(8, 248)
        Me.scaleKnob.MinorDivisions.Interval = 5
        Me.scaleKnob.Name = "scaleKnob"
        Me.scaleKnob.Range = New NationalInstruments.UI.Range(10, 50)
        Me.scaleKnob.Size = New System.Drawing.Size(208, 144)
        Me.scaleKnob.TabIndex = 2
        Me.scaleKnob.Value = 10
        '
        'genDataButton
        '
        Me.genDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.genDataButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.genDataButton.Location = New System.Drawing.Point(392, 248)
        Me.genDataButton.Name = "genDataButton"
        Me.genDataButton.Size = New System.Drawing.Size(136, 48)
        Me.genDataButton.TabIndex = 0
        Me.genDataButton.Text = "Generate Data"
        '
        'dataWaveformGraph
        '
        Me.dataWaveformGraph.Annotations.AddRange(New NationalInstruments.UI.XYAnnotation() {Me.maxXYPointAnnotation, Me.minXYPointAnnotation})
        Me.dataWaveformGraph.Caption = "Data Waveform Graph"
        Me.dataWaveformGraph.Location = New System.Drawing.Point(1, 0)
        Me.dataWaveformGraph.Name = "dataWaveformGraph"
        Me.dataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.waveformPlot1})
        Me.dataWaveformGraph.Size = New System.Drawing.Size(528, 240)
        Me.dataWaveformGraph.TabIndex = 1
        Me.dataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.dataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'maxXYPointAnnotation
        '
        Me.maxXYPointAnnotation.ArrowColor = System.Drawing.Color.Gold
        Me.maxXYPointAnnotation.ArrowLineWidth = 2.0!
        Me.maxXYPointAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopRight, 0.0, 0.0)
        Me.maxXYPointAnnotation.Caption = "Max Value"
        Me.maxXYPointAnnotation.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxXYPointAnnotation.XAxis = Me.xAxis1
        Me.maxXYPointAnnotation.XPosition = 2
        Me.maxXYPointAnnotation.YAxis = Me.yAxis1
        Me.maxXYPointAnnotation.YPosition = 4
        '
        'yAxis1
        '
        Me.yAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed
        '
        'minXYPointAnnotation
        '
        Me.minXYPointAnnotation.ArrowColor = System.Drawing.Color.RoyalBlue
        Me.minXYPointAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.BottomLeft, 0.0, 0.0)
        Me.minXYPointAnnotation.Caption = "Min Value"
        Me.minXYPointAnnotation.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minXYPointAnnotation.XAxis = Me.xAxis1
        Me.minXYPointAnnotation.YAxis = Me.yAxis1
        '
        'waveformPlot1
        '
        Me.waveformPlot1.XAxis = Me.xAxis1
        Me.waveformPlot1.YAxis = Me.yAxis1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(530, 400)
        Me.Controls.Add(Me.dataWaveformGraph)
        Me.Controls.Add(Me.scaleKnob)
        Me.Controls.Add(Me.annotationSettingGroupBox)
        Me.Controls.Add(Me.genDataButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Annotations"
        Me.annotationSettingGroupBox.ResumeLayout(False)
        CType(Me.scaleKnob, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    <System.STAThread()> _
                Public Shared Sub Main()
        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.Run(New MainForm)
    End Sub

    Private Sub genDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genDataButton.Click
        If Not newRange Is Nothing Then
            yAxis1.Range = newRange
        End If

        Dim data() As Double = New Double(50) {}

        For i As Integer = 0 To 50
            data(i) = scaleKnob.Value * random.NextDouble()
        Next i

        Dim max As Double, min As Double
        Dim maxIndex As Integer, minIndex As Integer

        max = Double.MinValue
        min = Double.MaxValue

        For i As Integer = 0 To 50
            If max < data(i) Then
                max = data(i)
                maxIndex = i
            End If
            If min > data(i) Then
                min = data(i)
                minIndex = i
            End If
        Next i

        dataWaveformGraph.PlotY(data)
        maxXYPointAnnotation.SetPosition(maxIndex, max)
        minXYPointAnnotation.SetPosition(minIndex, min)
    End Sub
    Private Sub hideAnnotationRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hideAnnotationRadioButton.CheckedChanged
        minXYPointAnnotation.Visible = Not minXYPointAnnotation.Visible
        maxXYPointAnnotation.Visible = Not maxXYPointAnnotation.Visible
    End Sub

    Private Sub hideArrowsRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hideArrowsRadioButton.CheckedChanged
        minXYPointAnnotation.ArrowVisible = Not minXYPointAnnotation.ArrowVisible
        maxXYPointAnnotation.ArrowVisible = Not maxXYPointAnnotation.ArrowVisible
    End Sub

    Private Sub hideShapesRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles hideShapesRadioButton.CheckedChanged
        minXYPointAnnotation.ShapeVisible = Not minXYPointAnnotation.ShapeVisible
        maxXYPointAnnotation.ShapeVisible = Not maxXYPointAnnotation.ShapeVisible
    End Sub

    Private Sub showAllRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles showAllRadioButton.CheckedChanged
        minXYPointAnnotation.ArrowVisible = True
        maxXYPointAnnotation.ArrowVisible = True
        minXYPointAnnotation.ShapeVisible = True
        maxXYPointAnnotation.ShapeVisible = True
        minXYPointAnnotation.Visible = True
        maxXYPointAnnotation.Visible = True
    End Sub

    Private Sub scaleKnob_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles scaleKnob.AfterChangeValue
        newRange = New NationalInstruments.UI.Range(-3, e.NewValue + 3)
    End Sub
End Class
