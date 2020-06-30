Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports NationalInstruments
Imports NationalInstruments.UI

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        numberOfPoints = 100
        maxValue = 10
        InitializeComponent()
        startMagnitudeNumericEdit.Value = 3
        magnitudeNumericEdit.Value = 4
        complexPlot.PlotComplex(GeneratePlotData(numberOfPoints, maxValue))

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

    Private numberOfPoints As Integer
    Private maxValue As Double
    Friend WithEvents annotationSettingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents aComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph
    Friend WithEvents unitFourMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents complexXAxis As NationalInstruments.UI.ComplexXAxis
    Friend WithEvents complexYAxis As NationalInstruments.UI.ComplexYAxis
    Friend WithEvents unitFiveMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents magnitudePhaseRangeAnnotation As NationalInstruments.UI.MagnitudePhaseRangeAnnotation
    Friend WithEvents unitThreeMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents unitTwoMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents unitSixMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents magnitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents startMagnitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents rangeZOrderLabel As System.Windows.Forms.Label
    Friend WithEvents rangeFillStyleLabel As System.Windows.Forms.Label
    Friend WithEvents rangeFillColorLabel As System.Windows.Forms.Label
    Friend WithEvents magnitudeLabel As System.Windows.Forms.Label
    Friend WithEvents startMagnitudeLabel As System.Windows.Forms.Label
    Friend WithEvents phaseLabel As System.Windows.Forms.Label
    Friend WithEvents rangeZOrderPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents rangeFillStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents rangeFillColorPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents phasePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents unitEightMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents unitSevenMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents unitNineMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents unitOneMagnitudeCircleAnnotation As NationalInstruments.UI.MagnitudeCircleAnnotation
    Friend WithEvents complexPlot As NationalInstruments.UI.ComplexPlot


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.unitFourMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.complexXAxis = New NationalInstruments.UI.ComplexXAxis
        Me.complexYAxis = New NationalInstruments.UI.ComplexYAxis
        Me.unitFiveMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.magnitudePhaseRangeAnnotation = New NationalInstruments.UI.MagnitudePhaseRangeAnnotation
        Me.unitThreeMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.unitTwoMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.unitSixMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.annotationSettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.magnitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.startMagnitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.rangeZOrderLabel = New System.Windows.Forms.Label
        Me.rangeFillStyleLabel = New System.Windows.Forms.Label
        Me.rangeFillColorLabel = New System.Windows.Forms.Label
        Me.magnitudeLabel = New System.Windows.Forms.Label
        Me.startMagnitudeLabel = New System.Windows.Forms.Label
        Me.phaseLabel = New System.Windows.Forms.Label
        Me.rangeZOrderPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.rangeFillStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.rangeFillColorPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.phasePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.unitEightMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.unitSevenMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.unitNineMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.unitOneMagnitudeCircleAnnotation = New NationalInstruments.UI.MagnitudeCircleAnnotation
        Me.complexPlot = New NationalInstruments.UI.ComplexPlot
        Me.aComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.annotationSettingsGroupBox.SuspendLayout()
        CType(Me.magnitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startMagnitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.aComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'unitFourMagnitudeCircleAnnotation
        '
        Me.unitFourMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitFourMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitFourMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitFourMagnitudeCircleAnnotation.Caption = "Magnitude = 4"
        Me.unitFourMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitFourMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitFourMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitFourMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitFourMagnitudeCircleAnnotation.Magnitude = 4
        Me.unitFourMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitFourMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'unitFiveMagnitudeCircleAnnotation
        '
        Me.unitFiveMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitFiveMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitFiveMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitFiveMagnitudeCircleAnnotation.Caption = "Magnitude = 5"
        Me.unitFiveMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitFiveMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitFiveMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitFiveMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitFiveMagnitudeCircleAnnotation.Magnitude = 5
        Me.unitFiveMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitFiveMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'magnitudePhaseRangeAnnotation
        '
        Me.magnitudePhaseRangeAnnotation.ArrowHeadMagnitude = 6.5
        Me.magnitudePhaseRangeAnnotation.ArrowHeadPhase = 45.0!
        Me.magnitudePhaseRangeAnnotation.Caption = "Annotated Region"
        Me.magnitudePhaseRangeAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopRight, -31.0!, 59.0!)
        Me.magnitudePhaseRangeAnnotation.Magnitude = 4
        Me.magnitudePhaseRangeAnnotation.Phase = New NationalInstruments.UI.Arc(245.0!, 90.0!)
        Me.magnitudePhaseRangeAnnotation.RangeFillColor = System.Drawing.Color.DarkGray
        Me.magnitudePhaseRangeAnnotation.RangeFillStyle = NationalInstruments.UI.FillStyle.ZigZag
        Me.magnitudePhaseRangeAnnotation.XAxis = Me.complexXAxis
        Me.magnitudePhaseRangeAnnotation.YAxis = Me.complexYAxis
        '
        'unitThreeMagnitudeCircleAnnotation
        '
        Me.unitThreeMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitThreeMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitThreeMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitThreeMagnitudeCircleAnnotation.Caption = "Magnitude = 3"
        Me.unitThreeMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitThreeMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitThreeMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitThreeMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitThreeMagnitudeCircleAnnotation.Magnitude = 3
        Me.unitThreeMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitThreeMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'unitTwoMagnitudeCircleAnnotation
        '
        Me.unitTwoMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitTwoMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitTwoMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitTwoMagnitudeCircleAnnotation.Caption = "Magnitude = 2"
        Me.unitTwoMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitTwoMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitTwoMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitTwoMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitTwoMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitTwoMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'unitSixMagnitudeCircleAnnotation
        '
        Me.unitSixMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitSixMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitSixMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitSixMagnitudeCircleAnnotation.Caption = "Magnitude = 6"
        Me.unitSixMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitSixMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitSixMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitSixMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitSixMagnitudeCircleAnnotation.Magnitude = 6
        Me.unitSixMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitSixMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'annotationSettingsGroupBox
        '
        Me.annotationSettingsGroupBox.Controls.Add(Me.magnitudeNumericEdit)
        Me.annotationSettingsGroupBox.Controls.Add(Me.startMagnitudeNumericEdit)
        Me.annotationSettingsGroupBox.Controls.Add(Me.rangeZOrderLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.rangeFillStyleLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.rangeFillColorLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.magnitudeLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.startMagnitudeLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.phaseLabel)
        Me.annotationSettingsGroupBox.Controls.Add(Me.rangeZOrderPropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.rangeFillStylePropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.rangeFillColorPropertyEditor)
        Me.annotationSettingsGroupBox.Controls.Add(Me.phasePropertyEditor)
        Me.annotationSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.annotationSettingsGroupBox.Location = New System.Drawing.Point(8, 424)
        Me.annotationSettingsGroupBox.Name = "annotationSettingsGroupBox"
        Me.annotationSettingsGroupBox.Size = New System.Drawing.Size(560, 119)
        Me.annotationSettingsGroupBox.TabIndex = 1
        Me.annotationSettingsGroupBox.TabStop = False
        Me.annotationSettingsGroupBox.Text = "Annotation Settings"
        '
        'magnitudeNumericEdit
        '
        Me.magnitudeNumericEdit.CoercionInterval = 0.1
        Me.magnitudeNumericEdit.Location = New System.Drawing.Point(112, 80)
        Me.magnitudeNumericEdit.Name = "magnitudeNumericEdit"
        Me.magnitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.magnitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.magnitudeNumericEdit.Size = New System.Drawing.Size(144, 20)
        Me.magnitudeNumericEdit.TabIndex = 13
        '
        'startMagnitudeNumericEdit
        '
        Me.startMagnitudeNumericEdit.CoercionInterval = 0.1
        Me.startMagnitudeNumericEdit.Location = New System.Drawing.Point(112, 48)
        Me.startMagnitudeNumericEdit.Name = "startMagnitudeNumericEdit"
        Me.startMagnitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.startMagnitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.startMagnitudeNumericEdit.Size = New System.Drawing.Size(144, 20)
        Me.startMagnitudeNumericEdit.TabIndex = 12
        '
        'rangeZOrderLabel
        '
        Me.rangeZOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rangeZOrderLabel.Location = New System.Drawing.Point(291, 81)
        Me.rangeZOrderLabel.Name = "rangeZOrderLabel"
        Me.rangeZOrderLabel.Size = New System.Drawing.Size(81, 17)
        Me.rangeZOrderLabel.TabIndex = 11
        Me.rangeZOrderLabel.Text = "Range Z Order:"
        '
        'rangeFillStyleLabel
        '
        Me.rangeFillStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rangeFillStyleLabel.Location = New System.Drawing.Point(291, 50)
        Me.rangeFillStyleLabel.Name = "rangeFillStyleLabel"
        Me.rangeFillStyleLabel.Size = New System.Drawing.Size(81, 17)
        Me.rangeFillStyleLabel.TabIndex = 10
        Me.rangeFillStyleLabel.Text = "Range Fill Style:"
        '
        'rangeFillColorLabel
        '
        Me.rangeFillColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rangeFillColorLabel.Location = New System.Drawing.Point(291, 20)
        Me.rangeFillColorLabel.Name = "rangeFillColorLabel"
        Me.rangeFillColorLabel.Size = New System.Drawing.Size(81, 17)
        Me.rangeFillColorLabel.TabIndex = 9
        Me.rangeFillColorLabel.Text = "Range Fill Color:"
        '
        'magnitudeLabel
        '
        Me.magnitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.magnitudeLabel.Location = New System.Drawing.Point(19, 80)
        Me.magnitudeLabel.Name = "magnitudeLabel"
        Me.magnitudeLabel.Size = New System.Drawing.Size(81, 17)
        Me.magnitudeLabel.TabIndex = 8
        Me.magnitudeLabel.Text = "Magnitude:"
        '
        'startMagnitudeLabel
        '
        Me.startMagnitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.startMagnitudeLabel.Location = New System.Drawing.Point(19, 50)
        Me.startMagnitudeLabel.Name = "startMagnitudeLabel"
        Me.startMagnitudeLabel.Size = New System.Drawing.Size(81, 17)
        Me.startMagnitudeLabel.TabIndex = 7
        Me.startMagnitudeLabel.Text = "Start Magnitude:"
        '
        'phaseLabel
        '
        Me.phaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.phaseLabel.Location = New System.Drawing.Point(19, 21)
        Me.phaseLabel.Name = "phaseLabel"
        Me.phaseLabel.Size = New System.Drawing.Size(81, 17)
        Me.phaseLabel.TabIndex = 6
        Me.phaseLabel.Text = "Phase:"
        '
        'rangeZOrderPropertyEditor
        '
        Me.rangeZOrderPropertyEditor.Location = New System.Drawing.Point(384, 80)
        Me.rangeZOrderPropertyEditor.Name = "rangeZOrderPropertyEditor"
        Me.rangeZOrderPropertyEditor.Size = New System.Drawing.Size(144, 20)
        Me.rangeZOrderPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.magnitudePhaseRangeAnnotation, "RangeZOrder")
        Me.rangeZOrderPropertyEditor.TabIndex = 5
        '
        'rangeFillStylePropertyEditor
        '
        Me.rangeFillStylePropertyEditor.Location = New System.Drawing.Point(384, 48)
        Me.rangeFillStylePropertyEditor.Name = "rangeFillStylePropertyEditor"
        Me.rangeFillStylePropertyEditor.Size = New System.Drawing.Size(144, 20)
        Me.rangeFillStylePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.magnitudePhaseRangeAnnotation, "RangeFillStyle")
        Me.rangeFillStylePropertyEditor.TabIndex = 4
        '
        'rangeFillColorPropertyEditor
        '
        Me.rangeFillColorPropertyEditor.Location = New System.Drawing.Point(384, 16)
        Me.rangeFillColorPropertyEditor.Name = "rangeFillColorPropertyEditor"
        Me.rangeFillColorPropertyEditor.Size = New System.Drawing.Size(144, 20)
        Me.rangeFillColorPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.magnitudePhaseRangeAnnotation, "RangeFillColor")
        Me.rangeFillColorPropertyEditor.TabIndex = 3
        '
        'phasePropertyEditor
        '
        Me.phasePropertyEditor.Location = New System.Drawing.Point(112, 16)
        Me.phasePropertyEditor.Name = "phasePropertyEditor"
        Me.phasePropertyEditor.Size = New System.Drawing.Size(144, 20)
        Me.phasePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.magnitudePhaseRangeAnnotation, "Phase")
        Me.phasePropertyEditor.TabIndex = 0
        '
        'unitEightMagnitudeCircleAnnotation
        '
        Me.unitEightMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitEightMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitEightMagnitudeCircleAnnotation.Caption = "Magnitude = 8"
        Me.unitEightMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitEightMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitEightMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitEightMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitEightMagnitudeCircleAnnotation.Magnitude = 8
        Me.unitEightMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitEightMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'unitSevenMagnitudeCircleAnnotation
        '
        Me.unitSevenMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitSevenMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitSevenMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitSevenMagnitudeCircleAnnotation.Caption = "Magnitude = 7"
        Me.unitSevenMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitSevenMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitSevenMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitSevenMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitSevenMagnitudeCircleAnnotation.Magnitude = 7
        Me.unitSevenMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitSevenMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'unitNineMagnitudeCircleAnnotation
        '
        Me.unitNineMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitNineMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitNineMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitNineMagnitudeCircleAnnotation.Caption = "Magnitude = 9"
        Me.unitNineMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitNineMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitNineMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitNineMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitNineMagnitudeCircleAnnotation.Magnitude = 9
        Me.unitNineMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitNineMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'unitOneMagnitudeCircleAnnotation
        '
        Me.unitOneMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7
        Me.unitOneMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitOneMagnitudeCircleAnnotation.ArrowVisible = False
        Me.unitOneMagnitudeCircleAnnotation.Caption = "Magnitude = 1"
        Me.unitOneMagnitudeCircleAnnotation.CaptionAlignment = New NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0.0!, 25.0!)
        Me.unitOneMagnitudeCircleAnnotation.CaptionVisible = False
        Me.unitOneMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray
        Me.unitOneMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot
        Me.unitOneMagnitudeCircleAnnotation.Magnitude = 1
        Me.unitOneMagnitudeCircleAnnotation.XAxis = Me.complexXAxis
        Me.unitOneMagnitudeCircleAnnotation.YAxis = Me.complexYAxis
        '
        'complexPlot
        '
        Me.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode
        Me.complexPlot.XAxis = Me.complexXAxis
        Me.complexPlot.YAxis = Me.complexYAxis
        '
        'aComplexGraph
        '
        Me.aComplexGraph.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aComplexGraph.Annotations.AddRange(New NationalInstruments.UI.ComplexAnnotation() {Me.unitOneMagnitudeCircleAnnotation, Me.unitTwoMagnitudeCircleAnnotation, Me.unitThreeMagnitudeCircleAnnotation, Me.unitFourMagnitudeCircleAnnotation, Me.unitFiveMagnitudeCircleAnnotation, Me.unitSixMagnitudeCircleAnnotation, Me.unitSevenMagnitudeCircleAnnotation, Me.unitEightMagnitudeCircleAnnotation, Me.unitNineMagnitudeCircleAnnotation, Me.magnitudePhaseRangeAnnotation})
        Me.aComplexGraph.Location = New System.Drawing.Point(0, 0)
        Me.aComplexGraph.Name = "aComplexGraph"
        Me.aComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.complexPlot})
        Me.aComplexGraph.Size = New System.Drawing.Size(579, 413)
        Me.aComplexGraph.TabIndex = 0
        Me.aComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.complexXAxis})
        Me.aComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.complexYAxis})
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(576, 550)
        Me.Controls.Add(Me.annotationSettingsGroupBox)
        Me.Controls.Add(Me.aComplexGraph)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Magnitude Phase Range Annotation"
        Me.annotationSettingsGroupBox.ResumeLayout(False)
        CType(Me.magnitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startMagnitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.aComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Shared Function GeneratePlotData(ByVal numberOfPoints As Integer, ByVal maxValue As Double) As ComplexDouble()
        Dim xMax As Double = maxValue
        Dim xMin As Double = -maxValue
        Dim yMax As Double = maxValue
        Dim yMin As Double = -maxValue
        Dim theta As Double = 0
        Dim thetaRange As Double = 10 * Math.PI
        Dim complexData() As ComplexDouble = New ComplexDouble((numberOfPoints - 1)) {}
        Dim i As Integer

        For i = 0 To numberOfPoints - 1
            complexData(i).Real = (((xMax - xMin) / (numberOfPoints - 1)) * i) + xMin
            theta = ((i - ((numberOfPoints - 1) / 2.0)) * thetaRange / (numberOfPoints - 1))

            While (theta < -(thetaRange / 2))
                theta += thetaRange
            End While

            If theta = 0 Then
                complexData(i).Imaginary = yMax
            Else
                complexData(i).Imaginary = (Math.Sin(theta) / (theta)) * (3 * (yMax - yMin) / 4.0) + ((yMax - yMin) / 4) + yMin
            End If
        Next
        Return complexData
    End Function

    Private Sub startMagnitudeNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles startMagnitudeNumericEdit.AfterChangeValue
        magnitudePhaseRangeAnnotation.StartMagnitude = startMagnitudeNumericEdit.Value
    End Sub

    Private Sub magnitudeNumericEdit_AfterChangeValue(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles magnitudeNumericEdit.AfterChangeValue
        magnitudePhaseRangeAnnotation.Magnitude = magnitudeNumericEdit.Value
    End Sub

End Class
