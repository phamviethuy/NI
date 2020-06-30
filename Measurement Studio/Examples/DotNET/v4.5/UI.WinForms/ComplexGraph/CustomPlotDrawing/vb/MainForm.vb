Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        sampleComplexGraph.PlotComplex(GenerateData())

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
    Friend WithEvents sampleComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph
    Friend WithEvents complexPlot As NationalInstruments.UI.ComplexPlot
    Friend WithEvents complexXAxis As NationalInstruments.UI.ComplexXAxis
    Friend WithEvents complexYAxis As NationalInstruments.UI.ComplexYAxis
    Private WithEvents defaultRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents preDrawPlotRadioButton As System.Windows.Forms.RadioButton
    Private WithEvents postDrawPlotRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents plotDrawingStylesGroupBox As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.complexPlot = New NationalInstruments.UI.ComplexPlot
        Me.complexXAxis = New NationalInstruments.UI.ComplexXAxis
        Me.complexYAxis = New NationalInstruments.UI.ComplexYAxis
        Me.defaultRadioButton = New System.Windows.Forms.RadioButton
        Me.sampleComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.preDrawPlotRadioButton = New System.Windows.Forms.RadioButton
        Me.postDrawPlotRadioButton = New System.Windows.Forms.RadioButton
        Me.plotDrawingStylesGroupBox = New System.Windows.Forms.GroupBox
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.plotDrawingStylesGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'complexPlot
        '
        Me.complexPlot.XAxis = Me.complexXAxis
        Me.complexPlot.YAxis = Me.complexYAxis
        '
        'complexYAxis
        '
        Me.complexYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.complexYAxis.Range = New NationalInstruments.UI.Range(-1, 1)
        '
        'defaultRadioButton
        '
        Me.defaultRadioButton.Checked = True
        Me.defaultRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultRadioButton.Location = New System.Drawing.Point(8, 16)
        Me.defaultRadioButton.Name = "defaultRadioButton"
        Me.defaultRadioButton.Size = New System.Drawing.Size(376, 24)
        Me.defaultRadioButton.TabIndex = 0
        Me.defaultRadioButton.TabStop = True
        Me.defaultRadioButton.Text = "Default"
        '
        'sampleComplexGraph
        '
        Me.sampleComplexGraph.Caption = "Complex Graph"
        Me.sampleComplexGraph.Location = New System.Drawing.Point(16, 8)
        Me.sampleComplexGraph.Name = "sampleComplexGraph"
        Me.sampleComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.complexPlot})
        Me.sampleComplexGraph.Size = New System.Drawing.Size(392, 240)
        Me.sampleComplexGraph.TabIndex = 0
        Me.sampleComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.complexXAxis})
        Me.sampleComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.complexYAxis})
        '
        'preDrawPlotRadioButton
        '
        Me.preDrawPlotRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.preDrawPlotRadioButton.Location = New System.Drawing.Point(8, 72)
        Me.preDrawPlotRadioButton.Name = "preDrawPlotRadioButton"
        Me.preDrawPlotRadioButton.Size = New System.Drawing.Size(376, 24)
        Me.preDrawPlotRadioButton.TabIndex = 2
        Me.preDrawPlotRadioButton.Text = "Highlight increasing/decreasing values via custom pre plot drawing"
        '
        'postDrawPlotRadioButton
        '
        Me.postDrawPlotRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.postDrawPlotRadioButton.Location = New System.Drawing.Point(8, 44)
        Me.postDrawPlotRadioButton.Name = "postDrawPlotRadioButton"
        Me.postDrawPlotRadioButton.Size = New System.Drawing.Size(376, 24)
        Me.postDrawPlotRadioButton.TabIndex = 1
        Me.postDrawPlotRadioButton.Text = "Highlight min/max via custom post plot drawing"
        '
        'plotDrawingStylesGroupBox
        '
        Me.plotDrawingStylesGroupBox.Controls.Add(Me.preDrawPlotRadioButton)
        Me.plotDrawingStylesGroupBox.Controls.Add(Me.defaultRadioButton)
        Me.plotDrawingStylesGroupBox.Controls.Add(Me.postDrawPlotRadioButton)
        Me.plotDrawingStylesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotDrawingStylesGroupBox.Location = New System.Drawing.Point(16, 256)
        Me.plotDrawingStylesGroupBox.Name = "plotDrawingStylesGroupBox"
        Me.plotDrawingStylesGroupBox.Size = New System.Drawing.Size(392, 104)
        Me.plotDrawingStylesGroupBox.TabIndex = 1
        Me.plotDrawingStylesGroupBox.TabStop = False
        Me.plotDrawingStylesGroupBox.Text = "Plot Drawing Styles"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(424, 368)
        Me.Controls.Add(Me.sampleComplexGraph)
        Me.Controls.Add(Me.plotDrawingStylesGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Plot Drawing Example"
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.plotDrawingStylesGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Shared Function GenerateData() As ComplexDouble()
        Dim data(49) As ComplexDouble
        Dim rnd As Random = New Random

        For i As Integer = 0 To data.Length - 1
            data(i).Imaginary = rnd.NextDouble() * Math.Sin(i / 3.15)
            data(i).Real = i - 25
        Next i

        Return data
    End Function

    Private Sub OnDrawOptionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defaultRadioButton.CheckedChanged, preDrawPlotRadioButton.CheckedChanged, postDrawPlotRadioButton.CheckedChanged
        sampleComplexGraph.Invalidate()
    End Sub

    Private Sub OnBeforeDrawPlot(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeDrawComplexPlotEventArgs) Handles sampleComplexGraph.BeforeDrawPlot
        If preDrawPlotRadioButton.Checked Then
            Dim plot As ComplexPlot = e.Plot
            Dim complexData() As ComplexDouble = plot.GetComplexData()

            Dim limit As Integer = complexData.Length - 1
            Dim i As Integer
            Dim j As Integer = 1
            For i = 0 To limit - 1
                Dim y1 As Double = complexData(i).Imaginary
                Dim y2 As Double = complexData(j).Imaginary

                Dim point1 As PointF = plot.MapDataPoint(e.Bounds, complexData(i))
                Dim point2 As PointF = plot.MapDataPoint(e.Bounds, complexData(j))

                Dim pen As Pen
                If (y2 > y1) Then
                    pen = Pens.LimeGreen
                ElseIf (y2 = y1) Then
                    pen = Pens.Yellow
                Else
                    pen = Pens.Red
                End If

                Dim g As Graphics = e.Graphics
                g.DrawLine(pen, point1, point2)

                j = j + 1
            Next

            e.Cancel = True

        End If
    End Sub

    Private Sub OnAfterDrawPlot(ByVal sender As Object, ByVal e As NationalInstruments.UI.AfterDrawComplexPlotEventArgs) Handles sampleComplexGraph.AfterDrawPlot
        If postDrawPlotRadioButton.Checked Then
            Dim plot As ComplexPlot = e.Plot
            Dim complexData() As ComplexDouble = plot.GetComplexData()

            Dim yMin As Double = Double.MaxValue
            Dim yMax As Double = Double.MinValue

            Dim minComplexDouble As ComplexDouble = ComplexDouble.Zero
            Dim maxComplexDouble As ComplexDouble = ComplexDouble.Zero

            Dim i As Integer
            Dim currentY As Double
            For i = 0 To complexData.Length - 1
                currentY = complexData(i).Imaginary
                If (currentY < yMin) Then
                    yMin = currentY
                    minComplexDouble = complexData(i)
                End If


                If (currentY > yMax) Then
                    yMax = currentY
                    maxComplexDouble = complexData(i)
                End If
            Next

            HighlightDataPoint(e, minComplexDouble)
            HighlightDataPoint(e, maxComplexDouble)
        End If
    End Sub

    Private Shared Sub HighlightDataPoint(ByVal e As AfterDrawComplexPlotEventArgs, ByVal complexDouble As ComplexDouble)
        Dim g As Graphics = e.Graphics
        Dim mappedPoint As PointF = e.Plot.MapDataPoint(e.Bounds, complexDouble)
        Dim bounds As Rectangle = New Rectangle(CType((mappedPoint.X - 8), Integer), CType((mappedPoint.Y - 8), Integer), 16, 16)

        Dim brush As Brush = New SolidBrush(Color.FromArgb(128, Color.Red))
        g.FillEllipse(brush, bounds)
        brush.Dispose()

        g.DrawEllipse(Pens.Yellow, bounds)
    End Sub

End Class
