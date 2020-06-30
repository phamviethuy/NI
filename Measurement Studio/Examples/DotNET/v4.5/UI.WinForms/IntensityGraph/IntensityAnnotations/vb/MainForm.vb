Imports NationalInstruments.UI

Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private WithEvents annotationSettingGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents showAllRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents hideArrowsRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents hideAnnotationRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents hideShapesRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents myIntensityGraph As NationalInstruments.UI.WindowsForms.IntensityGraph
    Private WithEvents maxIntensityPointAnnotation As NationalInstruments.UI.IntensityPointAnnotation
    Private WithEvents xAxis1 As NationalInstruments.UI.IntensityXAxis
    Private WithEvents yAxis1 As NationalInstruments.UI.IntensityYAxis
    Private WithEvents minIntensityPointAnnotation As NationalInstruments.UI.IntensityPointAnnotation
    Private WithEvents colorScale1 As NationalInstruments.UI.ColorScale
    Private WithEvents intensityPlot As NationalInstruments.UI.IntensityPlot
    Private WithEvents generateDataButton As System.Windows.Forms.Button
    Private Const DataSize As Integer = 100
    Private random As Random

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        random = New Random()
        InitializeComponent()
        OnGenerateDataButtonClick(Nothing, Nothing)
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.annotationSettingGroupBox = New System.Windows.Forms.GroupBox()
        Me.showAllRadioButton = New System.Windows.Forms.RadioButton()
        Me.hideArrowsRadioButton = New System.Windows.Forms.RadioButton()
        Me.hideAnnotationRadioButton = New System.Windows.Forms.RadioButton()
        Me.hideShapesRadioButton = New System.Windows.Forms.RadioButton()
        Me.myIntensityGraph = New NationalInstruments.UI.WindowsForms.IntensityGraph()
        Me.maxIntensityPointAnnotation = New NationalInstruments.UI.IntensityPointAnnotation()
        Me.xAxis1 = New NationalInstruments.UI.IntensityXAxis()
        Me.yAxis1 = New NationalInstruments.UI.IntensityYAxis()
        Me.minIntensityPointAnnotation = New NationalInstruments.UI.IntensityPointAnnotation()
        Me.colorScale1 = New NationalInstruments.UI.ColorScale()
        Me.intensityPlot = New NationalInstruments.UI.IntensityPlot()
        Me.generateDataButton = New System.Windows.Forms.Button()
        Me.annotationSettingGroupBox.SuspendLayout()
        CType(Me.myIntensityGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'annotationSettingGroupBox
        '
        Me.annotationSettingGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.annotationSettingGroupBox.Controls.Add(Me.showAllRadioButton)
        Me.annotationSettingGroupBox.Controls.Add(Me.hideArrowsRadioButton)
        Me.annotationSettingGroupBox.Controls.Add(Me.hideAnnotationRadioButton)
        Me.annotationSettingGroupBox.Controls.Add(Me.hideShapesRadioButton)
        Me.annotationSettingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.annotationSettingGroupBox.Location = New System.Drawing.Point(11, 251)
        Me.annotationSettingGroupBox.Name = "annotationSettingGroupBox"
        Me.annotationSettingGroupBox.Size = New System.Drawing.Size(312, 104)
        Me.annotationSettingGroupBox.TabIndex = 0
        Me.annotationSettingGroupBox.TabStop = False
        Me.annotationSettingGroupBox.Text = "Annotation Settings"
        '
        'showAllRadioButton
        '
        Me.showAllRadioButton.AutoSize = True
        Me.showAllRadioButton.Checked = True
        Me.showAllRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.showAllRadioButton.Location = New System.Drawing.Point(174, 63)
        Me.showAllRadioButton.Name = "showAllRadioButton"
        Me.showAllRadioButton.Size = New System.Drawing.Size(72, 18)
        Me.showAllRadioButton.TabIndex = 0
        Me.showAllRadioButton.TabStop = True
        Me.showAllRadioButton.Text = "Show All"
        '
        'hideArrowsRadioButton
        '
        Me.hideArrowsRadioButton.AutoSize = True
        Me.hideArrowsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hideArrowsRadioButton.Location = New System.Drawing.Point(17, 29)
        Me.hideArrowsRadioButton.Name = "hideArrowsRadioButton"
        Me.hideArrowsRadioButton.Size = New System.Drawing.Size(142, 18)
        Me.hideArrowsRadioButton.TabIndex = 8
        Me.hideArrowsRadioButton.Text = "Hide Annotation Arrows"
        '
        'hideAnnotationRadioButton
        '
        Me.hideAnnotationRadioButton.AutoSize = True
        Me.hideAnnotationRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hideAnnotationRadioButton.Location = New System.Drawing.Point(174, 29)
        Me.hideAnnotationRadioButton.Name = "hideAnnotationRadioButton"
        Me.hideAnnotationRadioButton.Size = New System.Drawing.Size(112, 18)
        Me.hideAnnotationRadioButton.TabIndex = 7
        Me.hideAnnotationRadioButton.Text = "Hide Annotations"
        '
        'hideShapesRadioButton
        '
        Me.hideShapesRadioButton.AutoSize = True
        Me.hideShapesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hideShapesRadioButton.Location = New System.Drawing.Point(17, 63)
        Me.hideShapesRadioButton.Name = "hideShapesRadioButton"
        Me.hideShapesRadioButton.Size = New System.Drawing.Size(146, 18)
        Me.hideShapesRadioButton.TabIndex = 9
        Me.hideShapesRadioButton.Text = "Hide Annotation Shapes"
        '
        'intensityGraph
        '
        Me.myIntensityGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.myIntensityGraph.Annotations.AddRange(New NationalInstruments.UI.IntensityAnnotation() {Me.maxIntensityPointAnnotation, Me.minIntensityPointAnnotation})
        Me.myIntensityGraph.Caption = "Intensity Graph With Annotations"
        Me.myIntensityGraph.ColorScales.AddRange(New NationalInstruments.UI.ColorScale() {Me.colorScale1})
        Me.myIntensityGraph.Location = New System.Drawing.Point(-1, -1)
        Me.myIntensityGraph.Name = "intensityGraph"
        Me.myIntensityGraph.Plots.AddRange(New NationalInstruments.UI.IntensityPlot() {Me.intensityPlot})
        Me.myIntensityGraph.Size = New System.Drawing.Size(442, 246)
        Me.myIntensityGraph.TabIndex = 5
        Me.myIntensityGraph.TabStop = False
        Me.myIntensityGraph.XAxes.AddRange(New NationalInstruments.UI.IntensityXAxis() {Me.xAxis1})
        Me.myIntensityGraph.YAxes.AddRange(New NationalInstruments.UI.IntensityYAxis() {Me.yAxis1})
        '
        'maxIntensityPointAnnotation
        '
        Me.maxIntensityPointAnnotation.ArrowColor = System.Drawing.Color.Black
        Me.maxIntensityPointAnnotation.ArrowLineWidth = 2.0!
        Me.maxIntensityPointAnnotation.Caption = "Max Value"
        Me.maxIntensityPointAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopRight, 0.0!, 0.0!)
        Me.maxIntensityPointAnnotation.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maxIntensityPointAnnotation.CaptionForeColor = System.Drawing.Color.Black
        Me.maxIntensityPointAnnotation.ShapeFillColor = System.Drawing.Color.Transparent
        Me.maxIntensityPointAnnotation.ShapeSize = New System.Drawing.Size(16, 16)
        Me.maxIntensityPointAnnotation.XAxis = Me.xAxis1
        Me.maxIntensityPointAnnotation.XPosition = 2.0R
        Me.maxIntensityPointAnnotation.YAxis = Me.yAxis1
        Me.maxIntensityPointAnnotation.YPosition = 4.0R
        '
        'minIntensityPointAnnotation
        '
        Me.minIntensityPointAnnotation.ArrowColor = System.Drawing.Color.Black
        Me.minIntensityPointAnnotation.ArrowLineWidth = 2.0!
        Me.minIntensityPointAnnotation.Caption = "Min Value"
        Me.minIntensityPointAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.BottomLeft, 0.0!, 0.0!)
        Me.minIntensityPointAnnotation.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minIntensityPointAnnotation.CaptionForeColor = System.Drawing.Color.Black
        Me.minIntensityPointAnnotation.ShapeFillColor = System.Drawing.Color.Transparent
        Me.minIntensityPointAnnotation.ShapeSize = New System.Drawing.Size(16, 16)
        Me.minIntensityPointAnnotation.XAxis = Me.xAxis1
        Me.minIntensityPointAnnotation.YAxis = Me.yAxis1
        '
        'colorScale1
        '
        Me.colorScale1.ColorMap.AddRange(New NationalInstruments.UI.ColorMapEntry() {New NationalInstruments.UI.ColorMapEntry(3.0R, System.Drawing.Color.Green), New NationalInstruments.UI.ColorMapEntry(7.0R, System.Drawing.Color.Yellow)})
        Me.colorScale1.HighColor = System.Drawing.Color.Red
        Me.colorScale1.LowColor = System.Drawing.Color.Blue
        '
        'intensityPlot
        '
        Me.intensityPlot.ColorScale = Me.colorScale1
        Me.intensityPlot.XAxis = Me.xAxis1
        Me.intensityPlot.YAxis = Me.yAxis1
        '
        'generateDataButton
        '
        Me.generateDataButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.generateDataButton.Location = New System.Drawing.Point(329, 257)
        Me.generateDataButton.Name = "generateDataButton"
        Me.generateDataButton.Size = New System.Drawing.Size(102, 30)
        Me.generateDataButton.TabIndex = 1
        Me.generateDataButton.Text = "Generate Data"
        '
        'MainForm
        '
        Me.AcceptButton = Me.generateDataButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(444, 368)
        Me.Controls.Add(Me.generateDataButton)
        Me.Controls.Add(Me.annotationSettingGroupBox)
        Me.Controls.Add(Me.myIntensityGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(450, 400)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intensity Annotations"
        Me.annotationSettingGroupBox.ResumeLayout(False)
        Me.annotationSettingGroupBox.PerformLayout()
        CType(Me.myIntensityGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub OnGenerateDataButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateDataButton.Click
        ' Get the data and plot it.
        Dim data(,) As Double = GenerateData()
        myIntensityGraph.Plot(data)

        Dim minXIndex As Integer
        Dim minYIndex As Integer
        Dim maxXIndex As Integer
        Dim maxYIndex As Integer

        ' Get the minimum and maximum
        GetMinMaxValues(minXIndex, minYIndex, maxXIndex, maxYIndex)

        Dim xData As Double() = intensityPlot.GetXData()
        Dim yData As Double() = intensityPlot.GetYData()

        ' Set the position of annotation to point to minimum and maximum indices.
        minIntensityPointAnnotation.XPosition = xData(minXIndex)
        minIntensityPointAnnotation.YPosition = yData(minYIndex)
        maxIntensityPointAnnotation.XPosition = xData(maxXIndex)
        maxIntensityPointAnnotation.YPosition = yData(maxYIndex)
    End Sub

    Private Function GenerateData() As Double(,)
        ' Generate some data to plot.
        Dim data(,) As Double = New Double(DataSize, DataSize) {}

        Dim value As Double = 5
        Dim incrementValue As Double = 0.005
        Dim maxValue As Double = colorScale1.Range.Maximum - 1
        Dim minValue As Double = colorScale1.Range.Minimum + 1

        Dim i As Integer

        For i = 0 To DataSize Step i + 1
            Dim j As Integer
            j = 0
            For j = 0 To DataSize Step j + 1
                value = value + incrementValue
                If value > maxValue Or value < minValue Then
                    incrementValue = -incrementValue
                End If

                data(i, j) = value + random.NextDouble()
            Next
        Next

        Return data
    End Function

    Private Sub GetMinMaxValues(ByRef minXIndex As Integer, ByRef minYIndex As Integer, ByRef maxXIndex As Integer, ByRef maxYIndex As Integer)
        'Scan the data to find the indices of minimum and maximum values.
        Dim data As Double(,) = intensityPlot.GetZData()

        minXIndex = 0
        minYIndex = 0
        maxXIndex = 0
        maxYIndex = 0

        Dim max As Double = Double.MinValue
        Dim min As Double = Double.MaxValue

        Dim i As Integer
        For i = 0 To DataSize - 1 Step i + 1
            Dim j As Integer
            j = 0
            For j = 0 To DataSize - 1 Step j + 1
                If max < data(i, j) Then
                    max = data(i, j)
                    maxXIndex = i
                    maxYIndex = j
                End If

                If min > data(i, j) Then
                    min = data(i, j)
                    minXIndex = i
                    minYIndex = j
                End If
            Next
        Next
    End Sub

    Private Sub OnHideArrowsRadioButtonCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hideArrowsRadioButton.CheckedChanged
        minIntensityPointAnnotation.ArrowVisible = Not minIntensityPointAnnotation.ArrowVisible
        maxIntensityPointAnnotation.ArrowVisible = Not maxIntensityPointAnnotation.ArrowVisible
    End Sub


    Private Sub OnHideAnnotationRadioButtonCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hideAnnotationRadioButton.CheckedChanged
        minIntensityPointAnnotation.Visible = Not minIntensityPointAnnotation.Visible
        maxIntensityPointAnnotation.Visible = Not maxIntensityPointAnnotation.Visible
    End Sub


    Private Sub OnHideShapesRadioButtonCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hideShapesRadioButton.CheckedChanged
        minIntensityPointAnnotation.ShapeVisible = Not minIntensityPointAnnotation.ShapeVisible
        maxIntensityPointAnnotation.ShapeVisible = Not maxIntensityPointAnnotation.ShapeVisible
    End Sub


    Private Sub OnShowAllRadioButtonCheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showAllRadioButton.CheckedChanged
        minIntensityPointAnnotation.ArrowVisible = True
        maxIntensityPointAnnotation.ArrowVisible = True
        minIntensityPointAnnotation.ShapeVisible = True
        maxIntensityPointAnnotation.ShapeVisible = True
        minIntensityPointAnnotation.Visible = True
        maxIntensityPointAnnotation.Visible = True
    End Sub
End Class
