
Imports System.Drawing.Drawing2D
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

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
    Private WithEvents xAxis As NationalInstruments.UI.XAxis
    Private WithEvents scatterPlot As NationalInstruments.UI.ScatterPlot
    Private WithEvents yAxis As NationalInstruments.UI.YAxis

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents displayModePanel As System.Windows.Forms.Panel
    Friend WithEvents errorModeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents boxModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents regionModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents normalModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents sampleScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.scatterPlot = New NationalInstruments.UI.ScatterPlot
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.displayModePanel = New System.Windows.Forms.Panel
        Me.sampleScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.errorModeGroupBox = New System.Windows.Forms.GroupBox
        Me.boxModeRadioButton = New System.Windows.Forms.RadioButton
        Me.regionModeRadioButton = New System.Windows.Forms.RadioButton
        Me.normalModeRadioButton = New System.Windows.Forms.RadioButton
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.errorModeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'scatterPlot
        '
        Me.scatterPlot.PointSize = New System.Drawing.Size(7, 7)
        Me.scatterPlot.PointStyle = NationalInstruments.UI.PointStyle.SolidDiamond
        Me.scatterPlot.XAxis = Me.xAxis
        Me.scatterPlot.YAxis = Me.yAxis
        Me.scatterPlot.YErrorDataMode = NationalInstruments.UI.XYErrorDataMode.CreatePercentErrorMode(4)
        Me.scatterPlot.YErrorHighLineColor = System.Drawing.Color.DodgerBlue
        Me.scatterPlot.YErrorHighPointColor = System.Drawing.Color.DodgerBlue
        Me.scatterPlot.YErrorHighPointSize = New System.Drawing.Size(7, 7)
        Me.scatterPlot.YErrorHighPointStyle = NationalInstruments.UI.PointStyle.SolidCircle
        Me.scatterPlot.YErrorLowLineColor = System.Drawing.Color.DodgerBlue
        Me.scatterPlot.YErrorLowPointColor = System.Drawing.Color.DodgerBlue
        Me.scatterPlot.YErrorLowPointSize = New System.Drawing.Size(7, 7)
        Me.scatterPlot.YErrorLowPointStyle = NationalInstruments.UI.PointStyle.SolidCircle
        '
        'displayModePanel
        '
        Me.displayModePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.displayModePanel.Location = New System.Drawing.Point(0, 302)
        Me.displayModePanel.Name = "displayModePanel"
        Me.displayModePanel.Size = New System.Drawing.Size(392, 8)
        Me.displayModePanel.TabIndex = 7
        '
        'sampleScatterGraph
        '
        Me.sampleScatterGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleScatterGraph.Location = New System.Drawing.Point(0, 0)
        Me.sampleScatterGraph.Name = "sampleScatterGraph"
        Me.sampleScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.scatterPlot})
        Me.sampleScatterGraph.Size = New System.Drawing.Size(392, 302)
        Me.sampleScatterGraph.TabIndex = 8
        Me.sampleScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'errorModeGroupBox
        '
        Me.errorModeGroupBox.Controls.Add(Me.boxModeRadioButton)
        Me.errorModeGroupBox.Controls.Add(Me.regionModeRadioButton)
        Me.errorModeGroupBox.Controls.Add(Me.normalModeRadioButton)
        Me.errorModeGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.errorModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.errorModeGroupBox.Location = New System.Drawing.Point(0, 310)
        Me.errorModeGroupBox.Name = "errorModeGroupBox"
        Me.errorModeGroupBox.Size = New System.Drawing.Size(392, 112)
        Me.errorModeGroupBox.TabIndex = 6
        Me.errorModeGroupBox.TabStop = False
        Me.errorModeGroupBox.Text = "&Custom Drawing"
        '
        'boxModeRadioButton
        '
        Me.boxModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.boxModeRadioButton.Location = New System.Drawing.Point(16, 80)
        Me.boxModeRadioButton.Name = "boxModeRadioButton"
        Me.boxModeRadioButton.Size = New System.Drawing.Size(112, 24)
        Me.boxModeRadioButton.TabIndex = 2
        Me.boxModeRadioButton.Text = "&Box and Whisker"
        '
        'regionModeRadioButton
        '
        Me.regionModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.regionModeRadioButton.Location = New System.Drawing.Point(16, 52)
        Me.regionModeRadioButton.Name = "regionModeRadioButton"
        Me.regionModeRadioButton.Size = New System.Drawing.Size(112, 24)
        Me.regionModeRadioButton.TabIndex = 1
        Me.regionModeRadioButton.Text = "&Region"
        '
        'normalModeRadioButton
        '
        Me.normalModeRadioButton.Checked = True
        Me.normalModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.normalModeRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.normalModeRadioButton.Name = "normalModeRadioButton"
        Me.normalModeRadioButton.Size = New System.Drawing.Size(112, 24)
        Me.normalModeRadioButton.TabIndex = 0
        Me.normalModeRadioButton.TabStop = True
        Me.normalModeRadioButton.Text = "&Normal"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(392, 422)
        Me.Controls.Add(Me.sampleScatterGraph)
        Me.Controls.Add(Me.displayModePanel)
        Me.Controls.Add(Me.errorModeGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(200, 321)
        Me.Name = "MainForm"
        Me.Text = "Custom Drawing"
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.errorModeGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Const pointCount As Integer = 6
        Dim xData() As Double = New Double(pointCount) {}
        Dim yData() As Double = New Double(pointCount) {}

        Const regions As Integer = 3
        Const regionThreshold As Integer = pointCount / regions
        Dim threshold As Integer = -1

        Dim current As Double = 0.0
        Dim largeIncrement As Boolean = False
        Dim pointIncrement As Double = 0.0
        Dim i As Integer
        For i = 0 To pointCount
            If i > threshold Then
                threshold += regionThreshold
                largeIncrement = Not largeIncrement
                pointIncrement = IIf(largeIncrement, 2.0, -1.0)
            End If

            xData(i) = i
            yData(i) = current

            current += pointIncrement
        Next

        scatterPlot.PlotXY(xData, yData)
    End Sub

    Private Sub normalModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles normalModeRadioButton.CheckedChanged
        scatterPlot.Invalidate()
    End Sub

    Private Sub regionModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles regionModeRadioButton.CheckedChanged
        scatterPlot.Invalidate()
    End Sub

    Private Sub boxModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boxModeRadioButton.CheckedChanged
        ' Switch to appropriate point styles.
        If boxModeRadioButton.Checked Then
            scatterPlot.YErrorHighPointStyle = PointStyle.SolidTriangleUp
            scatterPlot.YErrorLowPointStyle = PointStyle.SolidSquare
        Else
            scatterPlot.YErrorHighPointStyle = PointStyle.SolidCircle
            scatterPlot.YErrorLowPointStyle = PointStyle.SolidCircle
        End If

        scatterPlot.Invalidate()
    End Sub

    Private Sub scatterPlot_BeforeDraw(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeDrawXYPlotEventArgs) Handles scatterPlot.BeforeDraw
        If Not normalModeRadioButton.Checked Then
            e.Cancel = True

            Dim b As Rectangle = e.Bounds
            Dim g As Graphics = e.Graphics
            Dim args As ComponentDrawArgs = New ComponentDrawArgs(g, b)

            Dim highErrorPoints() As PointF = e.Plot.MapYErrorHighData(b)
            Dim lowErrorPoints() As PointF = e.Plot.MapYErrorLowData(b)
            Dim plotPoints() As PointF = e.Plot.MapDataPoints(b)
            Dim length As Integer = highErrorPoints.Length

            Dim referenceColor As Color = e.Plot.YErrorHighPointColor
            Dim borderPen As Pen = New Pen(referenceColor)
            e.Plot.DrawLines(args)

            If regionModeRadioButton.Checked Then
                ' Fill the region covered by the error data.
                Dim regionBrush As Brush = New SolidBrush(Color.FromArgb(128, referenceColor))
                Dim i As Integer
                For i = 0 To length - 2
                    Dim path As GraphicsPath = New GraphicsPath(FillMode.Winding)
                    path.AddLine(highErrorPoints(i), highErrorPoints(i + 1))
                    path.AddLine(lowErrorPoints(i + 1), lowErrorPoints(i))

                    g.FillPath(regionBrush, path)
                Next
                regionBrush.Dispose()

                ' Draw a border around the region.
                g.DrawLines(borderPen, highErrorPoints)
                g.DrawLines(borderPen, lowErrorPoints)
            End If

            e.Plot.DrawErrorBands(args)

            If boxModeRadioButton.Checked Then
                ' Draw boxes in the style of "Box and Whisker" statistical plots, centered on the plot data points.
                Dim boxWidth As Single = CType((3 * b.Width) / (4 * length), Single)
                Dim boxBrush As Brush = New SolidBrush(Color.LightGray)
                Dim i As Integer
                For i = 0 To length - 1
                    Dim boxHeight As Single = (lowErrorPoints(i).Y - highErrorPoints(i).Y) / 2
                    Dim boxLeft As Single = plotPoints(i).X - (boxWidth / 2)
                    Dim boxTop As Single = plotPoints(i).Y - (boxHeight / 2)
                    Dim box As RectangleF = New RectangleF(boxLeft, boxTop, boxWidth, boxHeight)

                    g.FillRectangle(boxBrush, box.X, box.Y, box.Width, box.Height)
                    g.DrawRectangle(borderPen, box.X, box.Y, box.Width, box.Height)
                    g.DrawLine(borderPen, boxLeft, plotPoints(i).Y, boxLeft + boxWidth, plotPoints(i).Y)
                Next
                boxBrush.Dispose()
            End If

            e.Plot.DrawPoints(args)
            borderPen.Dispose()
        End If
    End Sub
End Class
