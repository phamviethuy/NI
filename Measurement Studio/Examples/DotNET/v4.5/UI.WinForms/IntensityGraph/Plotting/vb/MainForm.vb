Imports NationalInstruments.UI

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private intensityGraph As NationalInstruments.UI.WindowsForms.IntensityGraph
    Private intensityPlot As NationalInstruments.UI.IntensityPlot
    Private intensityXAxis As NationalInstruments.UI.IntensityXAxis
    Private intensityYAxis As NationalInstruments.UI.IntensityYAxis
    Private anchorBottomLeftRightPanel As System.Windows.Forms.Panel
    Private settingsGroupBox As System.Windows.Forms.GroupBox
    Private editColorMapButton As System.Windows.Forms.Button
    Private colorMapPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private colorScale As NationalInstruments.UI.ColorScale
    Private pixelInterpolationCheckBox As System.Windows.Forms.CheckBox
    Private yIncrementNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private yStartNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private yStartLabel As System.Windows.Forms.Label
    Private xIncrementNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private xStartNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private yIncrementLabel As System.Windows.Forms.Label
    Private xIncrementLabel As System.Windows.Forms.Label
    Private xStartLabel As System.Windows.Forms.Label
    Private plotGroupBox As System.Windows.Forms.GroupBox
    Private yArraySizeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private inputDataSizeLabel As System.Windows.Forms.Label
    Private sizeIndicationLabel As System.Windows.Forms.Label
    Private xArraySizeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        InitializeColorScale()
        GenerateDataAndPlot()
    End Sub

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.intensityGraph = New NationalInstruments.UI.WindowsForms.IntensityGraph
        Me.colorScale = New NationalInstruments.UI.ColorScale
        Me.intensityPlot = New NationalInstruments.UI.IntensityPlot
        Me.intensityXAxis = New NationalInstruments.UI.IntensityXAxis
        Me.intensityYAxis = New NationalInstruments.UI.IntensityYAxis
        Me.anchorBottomLeftRightPanel = New System.Windows.Forms.Panel
        Me.settingsGroupBox = New System.Windows.Forms.GroupBox
        Me.editColorMapButton = New System.Windows.Forms.Button
        Me.colorMapPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.pixelInterpolationCheckBox = New System.Windows.Forms.CheckBox
        Me.yIncrementNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.yStartNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.yStartLabel = New System.Windows.Forms.Label
        Me.xIncrementNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.xStartNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.yIncrementLabel = New System.Windows.Forms.Label
        Me.xIncrementLabel = New System.Windows.Forms.Label
        Me.xStartLabel = New System.Windows.Forms.Label
        Me.plotGroupBox = New System.Windows.Forms.GroupBox
        Me.yArraySizeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.inputDataSizeLabel = New System.Windows.Forms.Label
        Me.sizeIndicationLabel = New System.Windows.Forms.Label
        Me.xArraySizeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        CType(Me.intensityGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.anchorBottomLeftRightPanel.SuspendLayout()
        Me.settingsGroupBox.SuspendLayout()
        CType(Me.yIncrementNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yStartNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xIncrementNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xStartNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotGroupBox.SuspendLayout()
        CType(Me.yArraySizeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xArraySizeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'intensityGraph
        '
        Me.intensityGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.intensityGraph.Caption = "Intensity Graph"
        Me.intensityGraph.ColorScales.AddRange(New NationalInstruments.UI.ColorScale() {Me.colorScale})
        Me.intensityGraph.Location = New System.Drawing.Point(10, 9)
        Me.intensityGraph.Name = "intensityGraph"
        Me.intensityGraph.Plots.AddRange(New NationalInstruments.UI.IntensityPlot() {Me.intensityPlot})
        Me.intensityGraph.Size = New System.Drawing.Size(489, 273)
        Me.intensityGraph.TabIndex = 10
        Me.intensityGraph.XAxes.AddRange(New NationalInstruments.UI.IntensityXAxis() {Me.intensityXAxis})
        Me.intensityGraph.YAxes.AddRange(New NationalInstruments.UI.IntensityYAxis() {Me.intensityYAxis})
        '
        'colorScale
        '
        Me.colorScale.Caption = "Color Scale"
        Me.colorScale.RightCaptionOrientation = NationalInstruments.UI.VerticalCaptionOrientation.BottomToTop
        '
        'intensityPlot
        '
        Me.intensityPlot.ColorScale = Me.colorScale
        Me.intensityPlot.ToolTipsEnabled = True
        Me.intensityPlot.XAxis = Me.intensityXAxis
        Me.intensityPlot.YAxis = Me.intensityYAxis
        '
        'intensityXAxis
        '
        Me.intensityXAxis.Caption = "Intensity X Axis"
        Me.intensityXAxis.Mode = NationalInstruments.UI.IntensityAxisMode.AutoScaleExact
        '
        'intensityYAxis
        '
        Me.intensityYAxis.Caption = "Intensity Y Axis"
        Me.intensityYAxis.Mode = NationalInstruments.UI.IntensityAxisMode.AutoScaleExact
        Me.intensityYAxis.Range = New NationalInstruments.UI.Range(0, 100)
        '
        'anchorBottomLeftRightPanel
        '
        Me.anchorBottomLeftRightPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.anchorBottomLeftRightPanel.Controls.Add(Me.settingsGroupBox)
        Me.anchorBottomLeftRightPanel.Controls.Add(Me.plotGroupBox)
        Me.anchorBottomLeftRightPanel.Location = New System.Drawing.Point(7, 288)
        Me.anchorBottomLeftRightPanel.Name = "anchorBottomLeftRightPanel"
        Me.anchorBottomLeftRightPanel.Size = New System.Drawing.Size(498, 149)
        Me.anchorBottomLeftRightPanel.TabIndex = 11
        '
        'settingsGroupBox
        '
        Me.settingsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsGroupBox.Controls.Add(Me.editColorMapButton)
        Me.settingsGroupBox.Controls.Add(Me.colorMapPropertyEditor)
        Me.settingsGroupBox.Controls.Add(Me.pixelInterpolationCheckBox)
        Me.settingsGroupBox.Controls.Add(Me.yIncrementNumericEdit)
        Me.settingsGroupBox.Controls.Add(Me.yStartNumericEdit)
        Me.settingsGroupBox.Controls.Add(Me.yStartLabel)
        Me.settingsGroupBox.Controls.Add(Me.xIncrementNumericEdit)
        Me.settingsGroupBox.Controls.Add(Me.xStartNumericEdit)
        Me.settingsGroupBox.Controls.Add(Me.yIncrementLabel)
        Me.settingsGroupBox.Controls.Add(Me.xIncrementLabel)
        Me.settingsGroupBox.Controls.Add(Me.xStartLabel)
        Me.settingsGroupBox.Location = New System.Drawing.Point(3, 3)
        Me.settingsGroupBox.Name = "settingsGroupBox"
        Me.settingsGroupBox.Size = New System.Drawing.Size(489, 84)
        Me.settingsGroupBox.TabIndex = 0
        Me.settingsGroupBox.TabStop = False
        Me.settingsGroupBox.Text = "Plot And Color Map Settings"
        '
        'editColorMapButton
        '
        Me.editColorMapButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.editColorMapButton.Location = New System.Drawing.Point(348, 47)
        Me.editColorMapButton.Name = "editColorMapButton"
        Me.editColorMapButton.Size = New System.Drawing.Size(106, 23)
        Me.editColorMapButton.TabIndex = 5
        Me.editColorMapButton.Text = "Edit Color Map"
        Me.editColorMapButton.UseVisualStyleBackColor = True
        AddHandler editColorMapButton.Click, AddressOf OnEditColorMapButtonClick
        '
        'colorMapPropertyEditor
        '
        Me.colorMapPropertyEditor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.colorMapPropertyEditor.BackColor = System.Drawing.SystemColors.Control
        Me.colorMapPropertyEditor.Location = New System.Drawing.Point(355, 50)
        Me.colorMapPropertyEditor.Name = "colorMapPropertyEditor"
        Me.colorMapPropertyEditor.Size = New System.Drawing.Size(82, 20)
        Me.colorMapPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.colorScale, "ColorMap")
        Me.colorMapPropertyEditor.TabIndex = 3
        Me.colorMapPropertyEditor.TabStop = False
        Me.colorMapPropertyEditor.Visible = False
        '
        'pixelInterpolationCheckBox
        '
        Me.pixelInterpolationCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.pixelInterpolationCheckBox.AutoSize = True
        Me.pixelInterpolationCheckBox.Location = New System.Drawing.Point(348, 19)
        Me.pixelInterpolationCheckBox.Name = "pixelInterpolationCheckBox"
        Me.pixelInterpolationCheckBox.Size = New System.Drawing.Size(106, 17)
        Me.pixelInterpolationCheckBox.TabIndex = 4
        Me.pixelInterpolationCheckBox.Text = "Interpolate Pixels"
        Me.pixelInterpolationCheckBox.UseVisualStyleBackColor = True
        AddHandler pixelInterpolationCheckBox.CheckedChanged, AddressOf OnPixelInterpolationCheckBoxCheckedChanged
        '
        'yIncrementNumericEdit
        '
        Me.yIncrementNumericEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.yIncrementNumericEdit.Location = New System.Drawing.Point(263, 49)
        Me.yIncrementNumericEdit.Name = "yIncrementNumericEdit"
        Me.yIncrementNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.yIncrementNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.yIncrementNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.yIncrementNumericEdit.TabIndex = 3
        Me.yIncrementNumericEdit.Value = 1
        AddHandler yIncrementNumericEdit.AfterChangeValue, AddressOf OnNumericEditAfterChangeValue
        '
        'yStartNumericEdit
        '
        Me.yStartNumericEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.yStartNumericEdit.Location = New System.Drawing.Point(263, 19)
        Me.yStartNumericEdit.Name = "yStartNumericEdit"
        Me.yStartNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.yStartNumericEdit.TabIndex = 2
        AddHandler yStartNumericEdit.AfterChangeValue, AddressOf OnNumericEditAfterChangeValue
        '
        'yStartLabel
        '
        Me.yStartLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.yStartLabel.AutoSize = True
        Me.yStartLabel.Location = New System.Drawing.Point(212, 23)
        Me.yStartLabel.Name = "yStartLabel"
        Me.yStartLabel.Size = New System.Drawing.Size(45, 13)
        Me.yStartLabel.TabIndex = 2
        Me.yStartLabel.Text = "Y Start :"
        '
        'xIncrementNumericEdit
        '
        Me.xIncrementNumericEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.xIncrementNumericEdit.Location = New System.Drawing.Point(111, 49)
        Me.xIncrementNumericEdit.Name = "xIncrementNumericEdit"
        Me.xIncrementNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.xIncrementNumericEdit.Range = New NationalInstruments.UI.Range(1, Double.PositiveInfinity)
        Me.xIncrementNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.xIncrementNumericEdit.TabIndex = 1
        Me.xIncrementNumericEdit.Value = 1
        AddHandler xIncrementNumericEdit.AfterChangeValue, AddressOf OnNumericEditAfterChangeValue
        '
        'xStartNumericEdit
        '
        Me.xStartNumericEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.xStartNumericEdit.Location = New System.Drawing.Point(111, 19)
        Me.xStartNumericEdit.Name = "xStartNumericEdit"
        Me.xStartNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.xStartNumericEdit.TabIndex = 0
        AddHandler xStartNumericEdit.AfterChangeValue, AddressOf OnNumericEditAfterChangeValue
        '
        'yIncrementLabel
        '
        Me.yIncrementLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.yIncrementLabel.AutoSize = True
        Me.yIncrementLabel.Location = New System.Drawing.Point(187, 52)
        Me.yIncrementLabel.Name = "yIncrementLabel"
        Me.yIncrementLabel.Size = New System.Drawing.Size(70, 13)
        Me.yIncrementLabel.TabIndex = 2
        Me.yIncrementLabel.Text = "Y Increment :"
        '
        'xIncrementLabel
        '
        Me.xIncrementLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.xIncrementLabel.AutoSize = True
        Me.xIncrementLabel.Location = New System.Drawing.Point(35, 52)
        Me.xIncrementLabel.Name = "xIncrementLabel"
        Me.xIncrementLabel.Size = New System.Drawing.Size(70, 13)
        Me.xIncrementLabel.TabIndex = 2
        Me.xIncrementLabel.Text = "X Increment :"
        '
        'xStartLabel
        '
        Me.xStartLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.xStartLabel.AutoSize = True
        Me.xStartLabel.Location = New System.Drawing.Point(60, 23)
        Me.xStartLabel.Name = "xStartLabel"
        Me.xStartLabel.Size = New System.Drawing.Size(45, 13)
        Me.xStartLabel.TabIndex = 2
        Me.xStartLabel.Text = "X Start :"
        '
        'plotGroupBox
        '
        Me.plotGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.plotGroupBox.Controls.Add(Me.yArraySizeNumericEdit)
        Me.plotGroupBox.Controls.Add(Me.inputDataSizeLabel)
        Me.plotGroupBox.Controls.Add(Me.sizeIndicationLabel)
        Me.plotGroupBox.Controls.Add(Me.xArraySizeNumericEdit)
        Me.plotGroupBox.Location = New System.Drawing.Point(3, 92)
        Me.plotGroupBox.Name = "plotGroupBox"
        Me.plotGroupBox.Size = New System.Drawing.Size(489, 53)
        Me.plotGroupBox.TabIndex = 1
        Me.plotGroupBox.TabStop = False
        Me.plotGroupBox.Text = "Input Data Size"
        '
        'yArraySizeNumericEdit
        '
        Me.yArraySizeNumericEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.yArraySizeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.yArraySizeNumericEdit.Location = New System.Drawing.Point(290, 20)
        Me.yArraySizeNumericEdit.Name = "yArraySizeNumericEdit"
        Me.yArraySizeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.yArraySizeNumericEdit.Range = New NationalInstruments.UI.Range(10, 500)
        Me.yArraySizeNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.yArraySizeNumericEdit.TabIndex = 8
        Me.yArraySizeNumericEdit.Value = 30
        AddHandler yArraySizeNumericEdit.AfterChangeValue, AddressOf OnNumericEditAfterChangeValue
        '
        'inputDataSizeLabel
        '
        Me.inputDataSizeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.inputDataSizeLabel.AutoSize = True
        Me.inputDataSizeLabel.Location = New System.Drawing.Point(124, 24)
        Me.inputDataSizeLabel.Name = "inputDataSizeLabel"
        Me.inputDataSizeLabel.Size = New System.Drawing.Size(86, 13)
        Me.inputDataSizeLabel.TabIndex = 5
        Me.inputDataSizeLabel.Text = "Input Data Size :"
        '
        'sizeIndicationLabel
        '
        Me.sizeIndicationLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.sizeIndicationLabel.AutoSize = True
        Me.sizeIndicationLabel.Location = New System.Drawing.Point(274, 23)
        Me.sizeIndicationLabel.Name = "sizeIndicationLabel"
        Me.sizeIndicationLabel.Size = New System.Drawing.Size(14, 13)
        Me.sizeIndicationLabel.TabIndex = 5
        Me.sizeIndicationLabel.Text = "X"
        '
        'xArraySizeNumericEdit
        '
        Me.xArraySizeNumericEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.xArraySizeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.xArraySizeNumericEdit.Location = New System.Drawing.Point(216, 20)
        Me.xArraySizeNumericEdit.Name = "xArraySizeNumericEdit"
        Me.xArraySizeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.xArraySizeNumericEdit.Range = New NationalInstruments.UI.Range(10, 500)
        Me.xArraySizeNumericEdit.Size = New System.Drawing.Size(55, 20)
        Me.xArraySizeNumericEdit.TabIndex = 7
        Me.xArraySizeNumericEdit.Value = 40
        AddHandler xArraySizeNumericEdit.AfterChangeValue, AddressOf OnNumericEditAfterChangeValue
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(512, 446)
        Me.Controls.Add(Me.anchorBottomLeftRightPanel)
        Me.Controls.Add(Me.intensityGraph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(520, 480)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intensity Graph Plotting Example"
        CType(Me.intensityGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.anchorBottomLeftRightPanel.ResumeLayout(False)
        Me.settingsGroupBox.ResumeLayout(False)
        Me.settingsGroupBox.PerformLayout()
        CType(Me.yIncrementNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yStartNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xIncrementNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xStartNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotGroupBox.ResumeLayout(False)
        Me.plotGroupBox.PerformLayout()
        CType(Me.yArraySizeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xArraySizeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub
    Private Sub InitializeColorScale()
        ' Initialize the color scale and plot data once.
        colorScale.Range = New Range(-10, 10)
        colorScale.ColorMap.AddRange(New NationalInstruments.UI.ColorMapEntry() { _
            New NationalInstruments.UI.ColorMapEntry(-8, System.Drawing.Color.Blue), _
            New NationalInstruments.UI.ColorMapEntry(-5, System.Drawing.Color.Cyan), _
            New NationalInstruments.UI.ColorMapEntry(-2, System.Drawing.Color.Green), _
            New NationalInstruments.UI.ColorMapEntry(0, System.Drawing.Color.Lime), _
            New NationalInstruments.UI.ColorMapEntry(2, System.Drawing.Color.Yellow), _
            New NationalInstruments.UI.ColorMapEntry(5, System.Drawing.Color.Orange), _
            New NationalInstruments.UI.ColorMapEntry(8, System.Drawing.Color.Red)})
    End Sub

    Private Sub GenerateDataAndPlot()
        Dim data As Double(,) = GenerateIntensityData(CInt(xArraySizeNumericEdit.Value), CInt(yArraySizeNumericEdit.Value))
        If xIncrementNumericEdit.Value > 0 And yIncrementNumericEdit.Value > 0 Then
            intensityPlot.Plot(data, xStartNumericEdit.Value, xIncrementNumericEdit.Value, yStartNumericEdit.Value, yIncrementNumericEdit.Value)
        End If
    End Sub

    Private Function GenerateIntensityData(ByVal xArraySize As Integer, ByVal yArraySize As Integer) As Double(,)
        ' We generate data in a circular manner to suite this example.
        Dim data As Double(,) = New Double(xArraySize, yArraySize) {}

        ' maxDistance is the distance that creates a maximum angle (here maxPhaseAngle = 5).
        Dim maxDistance As Double = IIf(xArraySize <= yArraySize, xArraySize, yArraySize)
        Dim maxPhaseAngle As Double = 5

        ' amplitude defines the maximum data in the data array.
        Dim maxAmplitude As Double = colorScale.Range.Interval / 2
        Dim baseValue As Double = colorScale.Range.Minimum + colorScale.Range.Interval / 2

        Dim i As Integer = 0
        While i <= xArraySize
            Dim j As Integer = 0
            While j <= yArraySize
                ' Using the cirlcle equation, we get the distance from (i,j) from (0,0).
                Dim distance As Double = Math.Sqrt(i * i + j * j)

                ' Calculate the phase angle subtended by distance.
                Dim phaseAngle As Double = distance * maxPhaseAngle / maxDistance

                ' Calculate the amplitude at the phaseAngle. Add it up with baseValue to get the data at (i,j).
                data(i, j) = baseValue + maxAmplitude * Math.Sin(phaseAngle)
                System.Math.Max(System.Threading.Interlocked.Increment(j), j - 1)
            End While
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While

        Return data
    End Function

    Private Sub OnNumericEditAfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        GenerateDataAndPlot()
    End Sub

    Private Sub OnPixelInterpolationCheckBoxCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        intensityPlot.PixelInterpolation = pixelInterpolationCheckBox.Checked
    End Sub

    Private Sub OnEditColorMapButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        ' When the 'Edit Color Map' button is clicked the property editor launches the color map editor.
        colorMapPropertyEditor.EditValue()
    End Sub
End Class