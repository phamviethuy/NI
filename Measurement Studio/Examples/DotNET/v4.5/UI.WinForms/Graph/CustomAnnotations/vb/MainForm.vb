Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private random As random = New random
    Private customArrowTailStyle As ArrowStyle
    Private customShapeStyle As ShapeStyle
    Private defaultArrowTailStyle As ArrowStyle
    Private defaultShapeStyle As ShapeStyle

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        customArrowTailStyle = New FeatherTailStyle
        customShapeStyle = New StarShapeStyle
        defaultShapeStyle = maxXYPointAnnotation.ShapeStyle
        defaultArrowTailStyle = maxXYPointAnnotation.ArrowTailStyle
        genDataButton_Click(Nothing, Nothing)

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
    Friend WithEvents annotationArrowGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultArrowRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents customArrowRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents annotationShapeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultShapeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents customShapeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents genDataButton As System.Windows.Forms.Button
    Friend WithEvents XAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents WaveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents dataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents minXYPointAnnotation As NationalInstruments.UI.XYPointAnnotation
    Friend WithEvents maxXYPointAnnotation As NationalInstruments.UI.XYPointAnnotation
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.annotationArrowGroupBox = New System.Windows.Forms.GroupBox
        Me.defaultArrowRadioButton = New System.Windows.Forms.RadioButton
        Me.customArrowRadioButton = New System.Windows.Forms.RadioButton
        Me.annotationShapeGroupBox = New System.Windows.Forms.GroupBox
        Me.defaultShapeRadioButton = New System.Windows.Forms.RadioButton
        Me.customShapeRadioButton = New System.Windows.Forms.RadioButton
        Me.genDataButton = New System.Windows.Forms.Button
        Me.dataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.maxXYPointAnnotation = New NationalInstruments.UI.XYPointAnnotation
        Me.XAxis1 = New NationalInstruments.UI.XAxis
        Me.YAxis1 = New NationalInstruments.UI.YAxis
        Me.minXYPointAnnotation = New NationalInstruments.UI.XYPointAnnotation
        Me.WaveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.annotationArrowGroupBox.SuspendLayout()
        Me.annotationShapeGroupBox.SuspendLayout()
        CType(Me.dataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'annotationArrowGroupBox
        '
        Me.annotationArrowGroupBox.Controls.Add(Me.defaultArrowRadioButton)
        Me.annotationArrowGroupBox.Controls.Add(Me.customArrowRadioButton)
        Me.annotationArrowGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.annotationArrowGroupBox.Location = New System.Drawing.Point(168, 256)
        Me.annotationArrowGroupBox.Name = "annotationArrowGroupBox"
        Me.annotationArrowGroupBox.Size = New System.Drawing.Size(144, 80)
        Me.annotationArrowGroupBox.TabIndex = 3
        Me.annotationArrowGroupBox.TabStop = False
        Me.annotationArrowGroupBox.Text = "Annotation Arrow Settings"
        '
        'defaultArrowRadioButton
        '
        Me.defaultArrowRadioButton.Checked = True
        Me.defaultArrowRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultArrowRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.defaultArrowRadioButton.Name = "defaultArrowRadioButton"
        Me.defaultArrowRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.defaultArrowRadioButton.TabIndex = 1
        Me.defaultArrowRadioButton.TabStop = True
        Me.defaultArrowRadioButton.Text = "Default"
        '
        'customArrowRadioButton
        '
        Me.customArrowRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customArrowRadioButton.Location = New System.Drawing.Point(16, 48)
        Me.customArrowRadioButton.Name = "customArrowRadioButton"
        Me.customArrowRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.customArrowRadioButton.TabIndex = 0
        Me.customArrowRadioButton.Text = "Custom"
        '
        'annotationShapeGroupBox
        '
        Me.annotationShapeGroupBox.Controls.Add(Me.defaultShapeRadioButton)
        Me.annotationShapeGroupBox.Controls.Add(Me.customShapeRadioButton)
        Me.annotationShapeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.annotationShapeGroupBox.Location = New System.Drawing.Point(8, 256)
        Me.annotationShapeGroupBox.Name = "annotationShapeGroupBox"
        Me.annotationShapeGroupBox.Size = New System.Drawing.Size(152, 80)
        Me.annotationShapeGroupBox.TabIndex = 2
        Me.annotationShapeGroupBox.TabStop = False
        Me.annotationShapeGroupBox.Text = "Annotation Shape Settings"
        '
        'defaultShapeRadioButton
        '
        Me.defaultShapeRadioButton.Checked = True
        Me.defaultShapeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultShapeRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.defaultShapeRadioButton.Name = "defaultShapeRadioButton"
        Me.defaultShapeRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.defaultShapeRadioButton.TabIndex = 1
        Me.defaultShapeRadioButton.TabStop = True
        Me.defaultShapeRadioButton.Text = "Default"
        '
        'customShapeRadioButton
        '
        Me.customShapeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customShapeRadioButton.Location = New System.Drawing.Point(16, 48)
        Me.customShapeRadioButton.Name = "customShapeRadioButton"
        Me.customShapeRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.customShapeRadioButton.TabIndex = 0
        Me.customShapeRadioButton.Text = "Custom"
        '
        'genDataButton
        '
        Me.genDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.genDataButton.Location = New System.Drawing.Point(320, 264)
        Me.genDataButton.Name = "genDataButton"
        Me.genDataButton.Size = New System.Drawing.Size(144, 72)
        Me.genDataButton.TabIndex = 0
        Me.genDataButton.Text = "Generate Data"
        '
        'dataWaveformGraph
        '
        Me.dataWaveformGraph.Annotations.AddRange(New NationalInstruments.UI.XYAnnotation() {Me.maxXYPointAnnotation, Me.minXYPointAnnotation})
        Me.dataWaveformGraph.Caption = "Data Waveform Graph"
        Me.dataWaveformGraph.Location = New System.Drawing.Point(0, 0)
        Me.dataWaveformGraph.Name = "dataWaveformGraph"
        Me.dataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.WaveformPlot1})
        Me.dataWaveformGraph.Size = New System.Drawing.Size(472, 248)
        Me.dataWaveformGraph.TabIndex = 1
        Me.dataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.dataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        '
        'maxXYPointAnnotation
        '
        Me.maxXYPointAnnotation.ArrowColor = System.Drawing.Color.Gold
        Me.maxXYPointAnnotation.ArrowLineWidth = 2.0!
        Me.maxXYPointAnnotation.ArrowTailSize = New System.Drawing.Size(20, 15)
        Me.maxXYPointAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(BoundsAlignment.TopRight, 0.0, 0.0)
        Me.maxXYPointAnnotation.Caption = "Max Value"
        Me.maxXYPointAnnotation.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxXYPointAnnotation.XAxis = Me.XAxis1
        Me.maxXYPointAnnotation.XPosition = 2
        Me.maxXYPointAnnotation.YAxis = Me.YAxis1
        Me.maxXYPointAnnotation.YPosition = 4
        '
        'YAxis1
        '
        Me.YAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.YAxis1.Range = New NationalInstruments.UI.Range(-2, 7)
        '
        'minXYPointAnnotation
        '
        Me.minXYPointAnnotation.ArrowColor = System.Drawing.Color.RoyalBlue
        Me.minXYPointAnnotation.ArrowTailSize = New System.Drawing.Size(20, 15)
        Me.minXYPointAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(BoundsAlignment.BottomLeft, 0.0, 0.0)
        Me.minXYPointAnnotation.Caption = "Min Value"
        Me.minXYPointAnnotation.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minXYPointAnnotation.XAxis = Me.XAxis1
        Me.minXYPointAnnotation.YAxis = Me.YAxis1
        '
        'WaveformPlot1
        '
        Me.WaveformPlot1.XAxis = Me.XAxis1
        Me.WaveformPlot1.YAxis = Me.YAxis1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(474, 344)
        Me.Controls.Add(Me.dataWaveformGraph)
        Me.Controls.Add(Me.annotationArrowGroupBox)
        Me.Controls.Add(Me.annotationShapeGroupBox)
        Me.Controls.Add(Me.genDataButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Annotations"
        Me.annotationArrowGroupBox.ResumeLayout(False)
        Me.annotationShapeGroupBox.ResumeLayout(False)
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

        Dim data() As Double = New Double(50) {}
        For i As Integer = 0 To 50
            data(i) = 5 * random.NextDouble()
        Next

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

    Private Sub customArrowRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles customArrowRadioButton.CheckedChanged
        If Not (customArrowTailStyle Is Nothing) Then
            minXYPointAnnotation.ArrowTailStyle = customArrowTailStyle
            maxXYPointAnnotation.ArrowTailStyle = customArrowTailStyle
        End If
    End Sub

    Private Sub customShapeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles customShapeRadioButton.CheckedChanged
        If Not (customShapeStyle Is Nothing) Then
            minXYPointAnnotation.ShapeStyle = customShapeStyle
            maxXYPointAnnotation.ShapeStyle = customShapeStyle
        End If
    End Sub

    Private Sub defaultArrowRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles defaultArrowRadioButton.CheckedChanged
        If Not (defaultArrowTailStyle Is Nothing) Then
            minXYPointAnnotation.ArrowTailStyle = defaultArrowTailStyle
            maxXYPointAnnotation.ArrowTailStyle = defaultArrowTailStyle
        End If
    End Sub

    Private Sub defaultShapeRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles defaultShapeRadioButton.CheckedChanged
        If Not (defaultShapeStyle Is Nothing) Then
            minXYPointAnnotation.ShapeStyle = defaultShapeStyle
            maxXYPointAnnotation.ShapeStyle = defaultShapeStyle
        End If
    End Sub
End Class
