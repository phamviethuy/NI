Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        InitializeComponent()

    End Sub

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
    Friend WithEvents sampleComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph
    Friend WithEvents complexPlot As NationalInstruments.UI.ComplexPlot
    Friend WithEvents complexXAxis As NationalInstruments.UI.ComplexXAxis
    Friend WithEvents complexYAxis As NationalInstruments.UI.ComplexYAxis
    Friend WithEvents plotNaNButton As System.Windows.Forms.Button
    Friend WithEvents plotInfinityButton As System.Windows.Forms.Button
    Friend WithEvents plotNaNInfinityButton As System.Windows.Forms.Button
    Friend WithEvents toolTipVisibleLabel As System.Windows.Forms.Label
    Friend WithEvents toolTipVisiblePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents toolTipFormatStringPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents toolTipFormatStringLabel As System.Windows.Forms.Label
    Friend WithEvents arrowStyleLabel As System.Windows.Forms.Label
    Friend WithEvents arrowStylePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents arrowDirectionLabel As System.Windows.Forms.Label
    Friend WithEvents arrowDirectionPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents plotToolTipsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents plotArrowsGroupBox As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.plotNaNInfinityButton = New System.Windows.Forms.Button
        Me.plotInfinityButton = New System.Windows.Forms.Button
        Me.plotNaNButton = New System.Windows.Forms.Button
        Me.sampleComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.complexPlot = New NationalInstruments.UI.ComplexPlot
        Me.complexXAxis = New NationalInstruments.UI.ComplexXAxis
        Me.complexYAxis = New NationalInstruments.UI.ComplexYAxis
        Me.plotToolTipsGroupBox = New System.Windows.Forms.GroupBox
        Me.toolTipVisibleLabel = New System.Windows.Forms.Label
        Me.toolTipVisiblePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.toolTipFormatStringPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.toolTipFormatStringLabel = New System.Windows.Forms.Label
        Me.plotArrowsGroupBox = New System.Windows.Forms.GroupBox
        Me.arrowStyleLabel = New System.Windows.Forms.Label
        Me.arrowStylePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.arrowDirectionLabel = New System.Windows.Forms.Label
        Me.arrowDirectionPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotToolTipsGroupBox.SuspendLayout()
        Me.plotArrowsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'plotNaNInfinityButton
        '
        Me.plotNaNInfinityButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotNaNInfinityButton.Location = New System.Drawing.Point(296, 224)
        Me.plotNaNInfinityButton.Name = "plotNaNInfinityButton"
        Me.plotNaNInfinityButton.Size = New System.Drawing.Size(120, 23)
        Me.plotNaNInfinityButton.TabIndex = 3
        Me.plotNaNInfinityButton.Text = "Plot NaN and Infinity"
        '
        'plotInfinityButton
        '
        Me.plotInfinityButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotInfinityButton.Location = New System.Drawing.Point(147, 224)
        Me.plotInfinityButton.Name = "plotInfinityButton"
        Me.plotInfinityButton.Size = New System.Drawing.Size(120, 23)
        Me.plotInfinityButton.TabIndex = 2
        Me.plotInfinityButton.Text = "Plot Infinity"
        '
        'plotNaNButton
        '
        Me.plotNaNButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotNaNButton.Location = New System.Drawing.Point(8, 224)
        Me.plotNaNButton.Name = "plotNaNButton"
        Me.plotNaNButton.Size = New System.Drawing.Size(120, 23)
        Me.plotNaNButton.TabIndex = 1
        Me.plotNaNButton.Text = "Plot NaN"
        '
        'sampleComplexGraph
        '
        Me.sampleComplexGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleComplexGraph.Name = "sampleComplexGraph"
        Me.sampleComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.complexPlot})
        Me.sampleComplexGraph.Size = New System.Drawing.Size(408, 200)
        Me.sampleComplexGraph.TabIndex = 0
        Me.sampleComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.complexXAxis})
        Me.sampleComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.complexYAxis})
        '
        'complexPlot
        '
        Me.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode
        Me.complexPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle
        Me.complexPlot.XAxis = Me.complexXAxis
        Me.complexPlot.YAxis = Me.complexYAxis
        '
        'complexYAxis
        '
        Me.complexYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        '
        'plotToolTipsGroupBox
        '
        Me.plotToolTipsGroupBox.Controls.Add(Me.toolTipVisibleLabel)
        Me.plotToolTipsGroupBox.Controls.Add(Me.toolTipVisiblePropertyEditor)
        Me.plotToolTipsGroupBox.Controls.Add(Me.toolTipFormatStringPropertyEditor)
        Me.plotToolTipsGroupBox.Controls.Add(Me.toolTipFormatStringLabel)
        Me.plotToolTipsGroupBox.Location = New System.Drawing.Point(9, 320)
        Me.plotToolTipsGroupBox.Name = "plotToolTipsGroupBox"
        Me.plotToolTipsGroupBox.Size = New System.Drawing.Size(408, 56)
        Me.plotToolTipsGroupBox.TabIndex = 15
        Me.plotToolTipsGroupBox.TabStop = False
        Me.plotToolTipsGroupBox.Text = "Plot ToolTips"
        '
        'toolTipVisibleLabel
        '
        Me.toolTipVisibleLabel.Location = New System.Drawing.Point(4, 24)
        Me.toolTipVisibleLabel.Name = "toolTipVisibleLabel"
        Me.toolTipVisibleLabel.Size = New System.Drawing.Size(80, 23)
        Me.toolTipVisibleLabel.TabIndex = 10
        Me.toolTipVisibleLabel.Text = "ToolTipVisible"
        '
        'toolTipVisiblePropertyEditor
        '
        Me.toolTipVisiblePropertyEditor.Location = New System.Drawing.Point(83, 24)
        Me.toolTipVisiblePropertyEditor.Name = "toolTipVisiblePropertyEditor"
        Me.toolTipVisiblePropertyEditor.Size = New System.Drawing.Size(112, 20)
        Me.toolTipVisiblePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.complexPlot, "ToolTipsEnabled")
        Me.toolTipVisiblePropertyEditor.TabIndex = 8
        '
        'toolTipFormatStringPropertyEditor
        '
        Me.toolTipFormatStringPropertyEditor.Location = New System.Drawing.Point(304, 24)
        Me.toolTipFormatStringPropertyEditor.Name = "toolTipFormatStringPropertyEditor"
        Me.toolTipFormatStringPropertyEditor.Size = New System.Drawing.Size(96, 20)
        Me.toolTipFormatStringPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.complexPlot, "ToolTipFormatString")
        Me.toolTipFormatStringPropertyEditor.TabIndex = 9
        '
        'toolTipFormatStringLabel
        '
        Me.toolTipFormatStringLabel.Location = New System.Drawing.Point(200, 24)
        Me.toolTipFormatStringLabel.Name = "toolTipFormatStringLabel"
        Me.toolTipFormatStringLabel.Size = New System.Drawing.Size(112, 23)
        Me.toolTipFormatStringLabel.TabIndex = 11
        Me.toolTipFormatStringLabel.Text = "ToolTipFormatString"
        '
        'plotArrowsGroupBox
        '
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowStyleLabel)
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowStylePropertyEditor)
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowDirectionLabel)
        Me.plotArrowsGroupBox.Controls.Add(Me.arrowDirectionPropertyEditor)
        Me.plotArrowsGroupBox.Location = New System.Drawing.Point(9, 256)
        Me.plotArrowsGroupBox.Name = "plotArrowsGroupBox"
        Me.plotArrowsGroupBox.Size = New System.Drawing.Size(408, 56)
        Me.plotArrowsGroupBox.TabIndex = 14
        Me.plotArrowsGroupBox.TabStop = False
        Me.plotArrowsGroupBox.Text = "Plot Arrows"
        '
        'arrowStyleLabel
        '
        Me.arrowStyleLabel.Location = New System.Drawing.Point(8, 24)
        Me.arrowStyleLabel.Name = "arrowStyleLabel"
        Me.arrowStyleLabel.Size = New System.Drawing.Size(64, 19)
        Me.arrowStyleLabel.TabIndex = 6
        Me.arrowStyleLabel.Text = "Arrow style:"
        Me.arrowStyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'arrowStylePropertyEditor
        '
        Me.arrowStylePropertyEditor.Location = New System.Drawing.Point(83, 24)
        Me.arrowStylePropertyEditor.Name = "arrowStylePropertyEditor"
        Me.arrowStylePropertyEditor.Size = New System.Drawing.Size(109, 20)
        Me.arrowStylePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.complexPlot, "ArrowStyle")
        Me.arrowStylePropertyEditor.TabIndex = 4
        '
        'arrowDirectionLabel
        '
        Me.arrowDirectionLabel.Location = New System.Drawing.Point(200, 24)
        Me.arrowDirectionLabel.Name = "arrowDirectionLabel"
        Me.arrowDirectionLabel.Size = New System.Drawing.Size(83, 19)
        Me.arrowDirectionLabel.TabIndex = 7
        Me.arrowDirectionLabel.Text = "Arrow direction:"
        Me.arrowDirectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'arrowDirectionPropertyEditor
        '
        Me.arrowDirectionPropertyEditor.Location = New System.Drawing.Point(304, 24)
        Me.arrowDirectionPropertyEditor.Name = "arrowDirectionPropertyEditor"
        Me.arrowDirectionPropertyEditor.Size = New System.Drawing.Size(96, 20)
        Me.arrowDirectionPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.complexPlot, "ArrowDirection")
        Me.arrowDirectionPropertyEditor.TabIndex = 5
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(418, 384)
        Me.Controls.Add(Me.plotToolTipsGroupBox)
        Me.Controls.Add(Me.plotArrowsGroupBox)
        Me.Controls.Add(Me.sampleComplexGraph)
        Me.Controls.Add(Me.plotNaNInfinityButton)
        Me.Controls.Add(Me.plotInfinityButton)
        Me.Controls.Add(Me.plotNaNButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Special Values"
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotToolTipsGroupBox.ResumeLayout(False)
        Me.plotArrowsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Shared Function GenerateData() As ComplexDouble()
        Dim maxValue As Integer = 10
        Dim pointCount As Integer = 20

        Dim data(pointCount) As ComplexDouble
        Dim yData(pointCount) As Double

        Dim i As Integer = 0
        Do While (i < data.Length)
            yData(i) = maxValue / 2 * (1 - Math.Sin(i * 2 * Math.PI / (pointCount - 1))) - (maxValue / 2)
            data(i) = New ComplexDouble(i, yData(i))
            i = i + 1
        Loop

        Return data
    End Function

    Private Sub OnPlotNaNButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotNaNButton.Click
        complexPlot.ProcessSpecialValues = True
        Dim data() As ComplexDouble = GenerateData()
        Dim centerIndex As Integer = Convert.ToInt32((data.Length / 2))
        data(centerIndex).Imaginary = Double.NaN
        sampleComplexGraph.PlotComplex(data)
    End Sub

    Private Sub OnPlotInfinityButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotInfinityButton.Click
        complexPlot.ProcessSpecialValues = True
        Dim data() As ComplexDouble = GenerateData()
        Dim quarterIndex As Integer = Convert.ToInt32((data.Length / 4))
        Dim lastQuarterIndex As Integer = Convert.ToInt32((data.Length * (3 / 4)))
        data(quarterIndex).Imaginary = Double.PositiveInfinity
        data(lastQuarterIndex).Imaginary = Double.NegativeInfinity
        sampleComplexGraph.PlotComplex(data)
    End Sub

    Private Sub OnPlotNaNInfinityButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotNaNInfinityButton.Click
        complexPlot.ProcessSpecialValues = True
        Dim data() As ComplexDouble = GenerateData()
        Dim quarterIndex As Integer = Convert.ToInt32((data.Length / 4))
        Dim centerIndex As Integer = Convert.ToInt32((data.Length / 2))
        Dim lastQuarterIndex As Integer = Convert.ToInt32((data.Length * (3 / 4)))
        data(quarterIndex).Imaginary = Double.PositiveInfinity
        data(centerIndex).Imaginary = Double.NaN
        data(lastQuarterIndex).Imaginary = Double.NegativeInfinity
        sampleComplexGraph.PlotComplex(data)
    End Sub
End Class
