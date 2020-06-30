Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms


Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        defaultNumberOfPoints = 100
        random = New Random()
        InitializeComponent()
        plotTypeComboBox.SelectedItem = "Default"
        RefreshData()

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
    Friend WithEvents maxComplexPointAnnotation As NationalInstruments.UI.ComplexPointAnnotation
    Friend WithEvents complexXAxis As NationalInstruments.UI.ComplexXAxis
    Friend WithEvents complexYAxis As NationalInstruments.UI.ComplexYAxis
    Friend WithEvents annotationSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents interactionModePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents shapeStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents tailStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents headStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents lineStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents captionsLabel As System.Windows.Forms.Label
    Friend WithEvents shapeStyleLabel As System.Windows.Forms.Label
    Friend WithEvents tailStyleLabel As System.Windows.Forms.Label
    Friend WithEvents headStyleLabel As System.Windows.Forms.Label
    Friend WithEvents lineStyleLabel As System.Windows.Forms.Label
    Friend WithEvents aComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph
    Friend WithEvents minComplexPointAnnotation As NationalInstruments.UI.ComplexPointAnnotation
    Friend WithEvents complexPlot As NationalInstruments.UI.ComplexPlot
    Friend WithEvents scaleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents generateDataButton As System.Windows.Forms.Button
    Friend WithEvents scaleDataKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents plotSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents plotTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents plotTypeLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.maxComplexPointAnnotation = New NationalInstruments.UI.ComplexPointAnnotation
        Me.complexXAxis = New NationalInstruments.UI.ComplexXAxis
        Me.complexYAxis = New NationalInstruments.UI.ComplexYAxis
        Me.annotationSettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.interactionModePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.shapeStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.tailStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.headStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.lineStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.captionsLabel = New System.Windows.Forms.Label
        Me.shapeStyleLabel = New System.Windows.Forms.Label
        Me.tailStyleLabel = New System.Windows.Forms.Label
        Me.headStyleLabel = New System.Windows.Forms.Label
        Me.lineStyleLabel = New System.Windows.Forms.Label
        Me.aComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.minComplexPointAnnotation = New NationalInstruments.UI.ComplexPointAnnotation
        Me.complexPlot = New NationalInstruments.UI.ComplexPlot
        Me.scaleGroupBox = New System.Windows.Forms.GroupBox
        Me.generateDataButton = New System.Windows.Forms.Button
        Me.scaleDataKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.plotSettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.plotTypeComboBox = New System.Windows.Forms.ComboBox
        Me.plotTypeLabel = New System.Windows.Forms.Label
        Me.annotationSettingsGroupBox.SuspendLayout()
        CType(Me.aComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scaleGroupBox.SuspendLayout()
        CType(Me.scaleDataKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotSettingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'maxComplexPointAnnotation
        '
        Me.maxComplexPointAnnotation.ArrowColor = System.Drawing.Color.Firebrick
        Me.maxComplexPointAnnotation.ArrowLineWidth = 2.0!
        Me.maxComplexPointAnnotation.Caption = "Maximum Magnitude"
        Me.maxComplexPointAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.MiddleCenter, -104.0!, -70.0!)
        Me.maxComplexPointAnnotation.ToolTipFormatString = "{R:N:G5}+{I:N:G5}i [ {M:N:F3} ]"
        Me.maxComplexPointAnnotation.ToolTipMode = NationalInstruments.UI.AnnotationToolTipMode.Data
        Me.maxComplexPointAnnotation.XAxis = Me.complexXAxis
        Me.maxComplexPointAnnotation.YAxis = Me.complexYAxis
        '
        'annotationSettingsGroupBox
        '
        Me.annotationSettingsGroupBox.Controls.Add(Me.interactionModePropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.shapeStylePropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.tailStylePropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.headStylePropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.lineStylePropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.captionsLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.shapeStyleLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.tailStyleLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.headStyleLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.lineStyleLabel)
        Me.annotationSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.annotationSettingsGroupBox.Location = New System.Drawing.Point(600, 11)
        Me.annotationSettingsGroupBox.Name = "annotationSettingsGroupBox"
        Me.annotationSettingsGroupBox.Size = New System.Drawing.Size(240, 198)
        Me.annotationSettingsGroupBox.TabIndex = 6
        Me.annotationSettingsGroupBox.TabStop = False
        Me.annotationSettingsGroupBox.Text = "Annotation Settings"
        '
        'interactionModePropertyEditor
        '
        Me.interactionModePropertyEditor.Location = New System.Drawing.Point(112, 165)
        Me.interactionModePropertyEditor.Name = "interactionModePropertyEditor"
        Me.interactionModePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.interactionModePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.maxComplexPointAnnotation, "InteractionMode")
        Me.interactionModePropertyEditor.TabIndex = 4
        '
        'shapeStylePropertyEditor
        '
        Me.shapeStylePropertyEditor.Location = New System.Drawing.Point(112, 129)
        Me.shapeStylePropertyEditor.Name = "shapeStylePropertyEditor"
        Me.shapeStylePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.shapeStylePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.maxComplexPointAnnotation, "ShapeStyle")
        Me.shapeStylePropertyEditor.TabIndex = 3
        '
        'tailStylePropertyEditor
        '
        Me.tailStylePropertyEditor.Location = New System.Drawing.Point(112, 93)
        Me.tailStylePropertyEditor.Name = "tailStylePropertyEditor"
        Me.tailStylePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.tailStylePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.maxComplexPointAnnotation, "ArrowTailStyle")
        Me.tailStylePropertyEditor.TabIndex = 2
        '
        'headStylePropertyEditor
        '
        Me.headStylePropertyEditor.Location = New System.Drawing.Point(112, 57)
        Me.headStylePropertyEditor.Name = "headStylePropertyEditor"
        Me.headStylePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.headStylePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.maxComplexPointAnnotation, "ArrowHeadStyle")
        Me.headStylePropertyEditor.TabIndex = 1
        '
        'lineStylePropertyEditor
        '
        Me.lineStylePropertyEditor.Location = New System.Drawing.Point(112, 21)
        Me.lineStylePropertyEditor.Name = "lineStylePropertyEditor"
        Me.lineStylePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.lineStylePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.maxComplexPointAnnotation, "ArrowLineStyle")
        Me.lineStylePropertyEditor.TabIndex = 0
        '
        'captionsLabel
        '
        Me.captionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.captionsLabel.Location = New System.Drawing.Point(16, 167)
        Me.captionsLabel.Name = "captionsLabel"
        Me.captionsLabel.Size = New System.Drawing.Size(88, 23)
        Me.captionsLabel.TabIndex = 9
        Me.captionsLabel.Text = "Interaction Mode:"
        '
        'shapeStyleLabel
        '
        Me.shapeStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.shapeStyleLabel.Location = New System.Drawing.Point(15, 132)
        Me.shapeStyleLabel.Name = "shapeStyleLabel"
        Me.shapeStyleLabel.Size = New System.Drawing.Size(89, 23)
        Me.shapeStyleLabel.TabIndex = 7
        Me.shapeStyleLabel.Text = "Shape Style:"
        '
        'tailStyleLabel
        '
        Me.tailStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.tailStyleLabel.Location = New System.Drawing.Point(16, 96)
        Me.tailStyleLabel.Name = "tailStyleLabel"
        Me.tailStyleLabel.Size = New System.Drawing.Size(88, 23)
        Me.tailStyleLabel.TabIndex = 6
        Me.tailStyleLabel.Text = "Arrow Tail Style:"
        '
        'headStyleLabel
        '
        Me.headStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.headStyleLabel.Location = New System.Drawing.Point(16, 60)
        Me.headStyleLabel.Name = "headStyleLabel"
        Me.headStyleLabel.Size = New System.Drawing.Size(88, 23)
        Me.headStyleLabel.TabIndex = 5
        Me.headStyleLabel.Text = "Arrow Head Style:"
        '
        'lineStyleLabel
        '
        Me.lineStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lineStyleLabel.Location = New System.Drawing.Point(16, 24)
        Me.lineStyleLabel.Name = "lineStyleLabel"
        Me.lineStyleLabel.Size = New System.Drawing.Size(88, 23)
        Me.lineStyleLabel.TabIndex = 4
        Me.lineStyleLabel.Text = "Arrow Line Style:"
        '
        'aComplexGraph
        '
        Me.aComplexGraph.Annotations.AddRange(New NationalInstruments.UI.ComplexAnnotation() {Me.maxComplexPointAnnotation, Me.minComplexPointAnnotation})
        Me.aComplexGraph.Location = New System.Drawing.Point(16, 16)
        Me.aComplexGraph.Name = "aComplexGraph"
        Me.aComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.complexPlot})
        Me.aComplexGraph.Size = New System.Drawing.Size(568, 504)
        Me.aComplexGraph.TabIndex = 8
        Me.aComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.complexXAxis})
        Me.aComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.complexYAxis})
        '
        'minComplexPointAnnotation
        '
        Me.minComplexPointAnnotation.ArrowColor = System.Drawing.Color.Gold
        Me.minComplexPointAnnotation.ArrowLineWidth = 2.0!
        Me.minComplexPointAnnotation.Caption = "Minimum Magnitude"
        Me.minComplexPointAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.MiddleCenter, 109.1386!, -91.0!)
        Me.minComplexPointAnnotation.ToolTipFormatString = "{R:N:G5}+{I:N:G5}i [ {M:N:F3} ]"
        Me.minComplexPointAnnotation.ToolTipMode = NationalInstruments.UI.AnnotationToolTipMode.Data
        Me.minComplexPointAnnotation.XAxis = Me.complexXAxis
        Me.minComplexPointAnnotation.YAxis = Me.complexYAxis
        '
        'complexPlot
        '
        Me.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode
        Me.complexPlot.XAxis = Me.complexXAxis
        Me.complexPlot.YAxis = Me.complexYAxis
        '
        'scaleGroupBox
        '
        Me.scaleGroupBox.Controls.Add(Me.generateDataButton)
        Me.scaleGroupBox.Controls.Add(Me.scaleDataKnob)
        Me.scaleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.scaleGroupBox.Location = New System.Drawing.Point(600, 280)
        Me.scaleGroupBox.Name = "scaleGroupBox"
        Me.scaleGroupBox.Size = New System.Drawing.Size(240, 240)
        Me.scaleGroupBox.TabIndex = 5
        Me.scaleGroupBox.TabStop = False
        Me.scaleGroupBox.Text = "Scale Data"
        '
        'generateDataButton
        '
        Me.generateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.generateDataButton.Location = New System.Drawing.Point(32, 192)
        Me.generateDataButton.Name = "generateDataButton"
        Me.generateDataButton.Size = New System.Drawing.Size(176, 32)
        Me.generateDataButton.TabIndex = 1
        Me.generateDataButton.Text = "Generate Data"
        '
        'scaleDataKnob
        '
        Me.scaleDataKnob.CaptionVisible = False
        Me.scaleDataKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThumb
        Me.scaleDataKnob.Location = New System.Drawing.Point(32, 24)
        Me.scaleDataKnob.MinorDivisions.TickVisible = False
        Me.scaleDataKnob.Name = "scaleDataKnob"
        Me.scaleDataKnob.Range = New NationalInstruments.UI.Range(1, 10)
        Me.scaleDataKnob.Size = New System.Drawing.Size(176, 160)
        Me.scaleDataKnob.TabIndex = 0
        Me.scaleDataKnob.Value = 1
        '
        'plotSettingsGroupBox
        '
        Me.plotSettingsGroupBox.Controls.Add(Me.plotTypeComboBox)
        Me.plotSettingsGroupBox.Controls.Add(Me.plotTypeLabel)
        Me.plotSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotSettingsGroupBox.Location = New System.Drawing.Point(600, 216)
        Me.plotSettingsGroupBox.Name = "plotSettingsGroupBox"
        Me.plotSettingsGroupBox.Size = New System.Drawing.Size(240, 56)
        Me.plotSettingsGroupBox.TabIndex = 7
        Me.plotSettingsGroupBox.TabStop = False
        Me.plotSettingsGroupBox.Text = " Plot Settings"
        '
        'plotTypeComboBox
        '
        Me.plotTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.plotTypeComboBox.Items.AddRange(New Object() {"Cardioid", "Random", "Sine", "Cos", "Spiral", "Polar", "Default"})
        Me.plotTypeComboBox.Location = New System.Drawing.Point(120, 18)
        Me.plotTypeComboBox.Name = "plotTypeComboBox"
        Me.plotTypeComboBox.Size = New System.Drawing.Size(112, 21)
        Me.plotTypeComboBox.TabIndex = 5
        '
        'plotTypeLabel
        '
        Me.plotTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotTypeLabel.Location = New System.Drawing.Point(24, 23)
        Me.plotTypeLabel.Name = "plotTypeLabel"
        Me.plotTypeLabel.Size = New System.Drawing.Size(80, 23)
        Me.plotTypeLabel.TabIndex = 16
        Me.plotTypeLabel.Text = "Plot Type:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(856, 542)
        Me.Controls.Add(Me.annotationSettingsGroupBox)
        Me.Controls.Add(Me.aComplexGraph)
        Me.Controls.Add(Me.scaleGroupBox)
        Me.Controls.Add(Me.plotSettingsGroupBox)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Complex Graph Annotations"
        Me.annotationSettingsGroupBox.ResumeLayout(False)
        CType(Me.aComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scaleGroupBox.ResumeLayout(False)
        CType(Me.scaleDataKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotSettingsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim defaultNumberOfPoints As Integer
    Dim random As Random

    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub RefreshData()
        complexPlot.PlotComplex(GenerateData(defaultNumberOfPoints, scaleDataKnob.Value))
        Dim maxComplexPoint As ComplexDouble = New ComplexDouble(0, 0)
        Dim minComplexPoint As ComplexDouble = New ComplexDouble(0, 0)
        Dim maxMag As Double = Double.MinValue
        Dim minMag As Double = Double.MaxValue
        For Each point As ComplexDouble In complexPlot.GetComplexData
            If (point.Magnitude > maxMag) Then
                maxMag = point.Magnitude
                maxComplexPoint = point
            End If
            If (point.Magnitude < minMag) Then
                minMag = point.Magnitude
                minComplexPoint = point
            End If
        Next
        maxComplexPointAnnotation.SetPosition(maxComplexPoint)
        minComplexPointAnnotation.SetPosition(minComplexPoint)
    End Sub

    Private Sub generateDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles generateDataButton.Click
        RefreshData()
    End Sub

    Private Sub lineStylePropertyEditor_SourceValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lineStylePropertyEditor.SourceValueChanged
        minComplexPointAnnotation.ArrowLineStyle = maxComplexPointAnnotation.ArrowLineStyle
    End Sub

    Private Sub headStylePropertyEditor_SourceValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles headStylePropertyEditor.SourceValueChanged
        minComplexPointAnnotation.ArrowHeadStyle = maxComplexPointAnnotation.ArrowHeadStyle
    End Sub

    Private Sub tailStylePropertyEditor_SourceValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tailStylePropertyEditor.SourceValueChanged
        minComplexPointAnnotation.ArrowTailStyle = maxComplexPointAnnotation.ArrowTailStyle
    End Sub

    Private Sub shapeStylePropertyEditor_SourceValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles shapeStylePropertyEditor.SourceValueChanged
        minComplexPointAnnotation.ShapeStyle = maxComplexPointAnnotation.ShapeStyle
    End Sub

    Private Sub interactionModePropertyEditor_SourceValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles interactionModePropertyEditor.SourceValueChanged
        minComplexPointAnnotation.InteractionMode = maxComplexPointAnnotation.InteractionMode
    End Sub

    Private Sub plotTypeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotTypeComboBox.SelectedIndexChanged
        RefreshData()
    End Sub

    Public Function GenerateData(ByVal numberOfPoints As Integer, ByVal maxValue As Double) As ComplexDouble()
        Dim complexData() As ComplexDouble = New ComplexDouble(numberOfPoints - 1) {}
        Dim divisor As Integer = (numberOfPoints - 1)

        Select Case (CType(plotTypeComboBox.SelectedItem, String))
            Case "Random"
                Dim i As Integer = 0
                For i = 0 To numberOfPoints - 1
                    complexData(i).Real = -maxValue + CType(i, Double) / divisor * (maxValue * 2)
                    complexData(i).Imaginary = maxValue * (random.NextDouble() - 0.5)
                Next i
            Case "Polar"
                Dim i As Integer = 0
                For i = 0 To numberOfPoints - 1
                    Dim r As Double = (CType(i, Double) / divisor) * (Math.PI * 2)
                    complexData(i).Real = maxValue * Math.Cos(r) * (Math.Sin(r * 3) + 0.5)
                    complexData(i).Imaginary = maxValue * Math.Sin(r) * (Math.Sin(r * 3) + 0.5)
                Next i
            Case "Cardioid"
                Dim i As Integer = 0
                For i = 0 To numberOfPoints - 1
                    Dim r As Double = maxValue * (1 - Math.Sin(i * 2 * Math.PI / (numberOfPoints - 1)))
                    complexData(i).Real = r * maxValue / 2 * Math.Sin(i * 2 * Math.PI / (numberOfPoints - 1))
                    complexData(i).Imaginary = r * maxValue / 2 * Math.Cos(i * 2 * Math.PI / (numberOfPoints - 1))
                Next i

            Case "Sine"
                Dim i As Integer = 0
                For i = 0 To numberOfPoints - 1
                    complexData(i).Real = -maxValue + CType(i, Double) / divisor * (maxValue * 2)
                    complexData(i).Imaginary = maxValue * Math.Sin(CType(i, Double) / divisor * 2 * Math.PI)
                Next i

            Case "Cos"
                Dim i As Integer = 0
                For i = 0 To numberOfPoints - 1
                    complexData(i).Real = -maxValue + CType(i, Double) / divisor * (maxValue * 2)
                    complexData(i).Imaginary = -maxValue * Math.Cos(CType(i, Double) / divisor * 2 * Math.PI)
                Next i

            Case "Spiral"
                Dim i As Integer = 0
                For i = 0 To numberOfPoints - 1
                    complexData(i).Real = i * Math.Cos(i * 6 * Math.PI / divisor) * maxValue / divisor
                    complexData(i).Imaginary = i * Math.Sin(i * 6 * Math.PI / divisor) * maxValue / divisor
                Next i

            Case Else
                Dim xMax As Double = maxValue
                Dim xMin As Double = -maxValue
                Dim yMax As Double = maxValue
                Dim yMin As Double = -maxValue
                Dim theta As Double = 0
                Dim thetaRange As Double = 10 * Math.PI
                Dim i As Integer = 0

                For i = 0 To numberOfPoints - 1
                    complexData(i).Real = ((xMax - xMin) / (numberOfPoints - 1) * i) + xMin
                    theta = (i - (numberOfPoints - 1) / 2.0) * thetaRange / (numberOfPoints - 1)

                    While (theta < ((thetaRange / 2) * -1))
                        theta = (theta + thetaRange)
                    End While

                    If (theta = 0) Then
                        complexData(i).Imaginary = yMax
                    Else
                        complexData(i).Imaginary = (Math.Sin(theta) / (theta)) * (3 * (yMax - yMin) / 4.0) + ((yMax - yMin) / 4) + yMin
                    End If
                Next i
        End Select
        Return complexData
    End Function
End Class
