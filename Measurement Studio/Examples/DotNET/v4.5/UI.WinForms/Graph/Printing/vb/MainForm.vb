Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        sineWavePlot.PlotY(GenerateSineWave(100, 10))
        triangleWavePlot.PlotY(GenerateTriangleWave(100, 3, 7, 10), 0, 10)
        squareWavePlot.PlotY(GenerateTriangleWave(100, 2, 8, 10), 0, 10)
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

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents applicationToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents settingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents optionSineWaveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents optionTriangleWaveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents optionSquareWaveRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents optionGraphRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents optionStackedPlotsRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents printPreviewButton As System.Windows.Forms.Button
    Friend WithEvents printButton As System.Windows.Forms.Button
    Friend WithEvents graphPrintPreviewDialog As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents sineWavePlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents triangleWavePlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents squareWavePlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents graphLegend As NationalInstruments.UI.WindowsForms.Legend
    Friend WithEvents LegendItem1 As NationalInstruments.UI.LegendItem
    Friend WithEvents LegendItem2 As NationalInstruments.UI.LegendItem
    Friend WithEvents LegendItem3 As NationalInstruments.UI.LegendItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.applicationToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.sineWavePlot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.triangleWavePlot = New NationalInstruments.UI.WaveformPlot
        Me.squareWavePlot = New NationalInstruments.UI.WaveformPlot
        Me.optionStackedPlotsRadioButton = New System.Windows.Forms.RadioButton
        Me.optionGraphRadioButton = New System.Windows.Forms.RadioButton
        Me.optionSquareWaveRadioButton = New System.Windows.Forms.RadioButton
        Me.optionTriangleWaveRadioButton = New System.Windows.Forms.RadioButton
        Me.optionSineWaveRadioButton = New System.Windows.Forms.RadioButton
        Me.settingsGroupBox = New System.Windows.Forms.GroupBox
        Me.printButton = New System.Windows.Forms.Button
        Me.printPreviewButton = New System.Windows.Forms.Button
        Me.graphPrintPreviewDialog = New System.Windows.Forms.PrintPreviewDialog
        Me.graphLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.LegendItem1 = New NationalInstruments.UI.LegendItem
        Me.LegendItem2 = New NationalInstruments.UI.LegendItem
        Me.LegendItem3 = New NationalInstruments.UI.LegendItem
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsGroupBox.SuspendLayout()
        CType(Me.graphLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleWaveformGraph.Caption = "2D Graph"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.sineWavePlot, Me.triangleWavePlot, Me.squareWavePlot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(326, 280)
        Me.sampleWaveformGraph.TabIndex = 0
        Me.applicationToolTip.SetToolTip(Me.sampleWaveformGraph, "National Instruments 2D Graph")
        Me.sampleWaveformGraph.UseColorGenerator = True
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'sineWavePlot
        '
        Me.sineWavePlot.LineWidth = 2.0!
        Me.sineWavePlot.XAxis = Me.xAxis
        Me.sineWavePlot.YAxis = Me.yAxis
        '
        'triangleWavePlot
        '
        Me.triangleWavePlot.LineWidth = 2.0!
        Me.triangleWavePlot.XAxis = Me.xAxis
        Me.triangleWavePlot.YAxis = Me.yAxis
        '
        'squareWavePlot
        '
        Me.squareWavePlot.LineStep = NationalInstruments.UI.LineStep.XYStep
        Me.squareWavePlot.LineWidth = 2.0!
        Me.squareWavePlot.XAxis = Me.xAxis
        Me.squareWavePlot.YAxis = Me.yAxis
        '
        'optionStackedPlotsRadioButton
        '
        Me.optionStackedPlotsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionStackedPlotsRadioButton.Location = New System.Drawing.Point(128, 54)
        Me.optionStackedPlotsRadioButton.Name = "optionStackedPlotsRadioButton"
        Me.optionStackedPlotsRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.optionStackedPlotsRadioButton.TabIndex = 1
        Me.optionStackedPlotsRadioButton.Text = "Stacked plots"
        Me.applicationToolTip.SetToolTip(Me.optionStackedPlotsRadioButton, "Print all plots stacked in separate plot areas")
        '
        'optionGraphRadioButton
        '
        Me.optionGraphRadioButton.Checked = True
        Me.optionGraphRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionGraphRadioButton.Location = New System.Drawing.Point(128, 20)
        Me.optionGraphRadioButton.Name = "optionGraphRadioButton"
        Me.optionGraphRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.optionGraphRadioButton.TabIndex = 0
        Me.optionGraphRadioButton.TabStop = True
        Me.optionGraphRadioButton.Text = "Graph"
        Me.applicationToolTip.SetToolTip(Me.optionGraphRadioButton, "Print the entire graph")
        '
        'optionSquareWaveRadioButton
        '
        Me.optionSquareWaveRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionSquareWaveRadioButton.Location = New System.Drawing.Point(16, 54)
        Me.optionSquareWaveRadioButton.Name = "optionSquareWaveRadioButton"
        Me.optionSquareWaveRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.optionSquareWaveRadioButton.TabIndex = 4
        Me.optionSquareWaveRadioButton.Text = "Square wave"
        Me.applicationToolTip.SetToolTip(Me.optionSquareWaveRadioButton, "Print the square wave only")
        '
        'optionTriangleWaveRadioButton
        '
        Me.optionTriangleWaveRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionTriangleWaveRadioButton.Location = New System.Drawing.Point(16, 88)
        Me.optionTriangleWaveRadioButton.Name = "optionTriangleWaveRadioButton"
        Me.optionTriangleWaveRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.optionTriangleWaveRadioButton.TabIndex = 3
        Me.optionTriangleWaveRadioButton.Text = "Triangle wave"
        Me.applicationToolTip.SetToolTip(Me.optionTriangleWaveRadioButton, "Print the triangle wave only")
        '
        'optionSineWaveRadioButton
        '
        Me.optionSineWaveRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.optionSineWaveRadioButton.Location = New System.Drawing.Point(16, 20)
        Me.optionSineWaveRadioButton.Name = "optionSineWaveRadioButton"
        Me.optionSineWaveRadioButton.Size = New System.Drawing.Size(104, 24)
        Me.optionSineWaveRadioButton.TabIndex = 2
        Me.optionSineWaveRadioButton.Text = "Sine wave"
        Me.applicationToolTip.SetToolTip(Me.optionSineWaveRadioButton, "Print the sine wave only")
        '
        'settingsGroupBox
        '
        Me.settingsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.settingsGroupBox.Controls.Add(Me.printButton)
        Me.settingsGroupBox.Controls.Add(Me.printPreviewButton)
        Me.settingsGroupBox.Controls.Add(Me.optionStackedPlotsRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.optionGraphRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.optionSquareWaveRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.optionTriangleWaveRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.optionSineWaveRadioButton)
        Me.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.settingsGroupBox.Location = New System.Drawing.Point(8, 296)
        Me.settingsGroupBox.Name = "settingsGroupBox"
        Me.settingsGroupBox.Size = New System.Drawing.Size(329, 120)
        Me.settingsGroupBox.TabIndex = 1
        Me.settingsGroupBox.TabStop = False
        Me.settingsGroupBox.Text = "Print Settings"
        '
        'printButton
        '
        Me.printButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printButton.Location = New System.Drawing.Point(229, 56)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(92, 23)
        Me.printButton.TabIndex = 6
        Me.printButton.Text = "Print"
        '
        'printPreviewButton
        '
        Me.printPreviewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.printPreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printPreviewButton.Location = New System.Drawing.Point(229, 24)
        Me.printPreviewButton.Name = "printPreviewButton"
        Me.printPreviewButton.Size = New System.Drawing.Size(92, 23)
        Me.printPreviewButton.TabIndex = 5
        Me.printPreviewButton.Text = "Print Preview ..."
        '
        'graphPrintPreviewDialog
        '
        Me.graphPrintPreviewDialog.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.graphPrintPreviewDialog.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.graphPrintPreviewDialog.ClientSize = New System.Drawing.Size(400, 300)
        Me.graphPrintPreviewDialog.Enabled = True
        Me.graphPrintPreviewDialog.Icon = CType(resources.GetObject("graphPrintPreviewDialog.Icon"), System.Drawing.Icon)
        Me.graphPrintPreviewDialog.Name = "printPreview"
        Me.graphPrintPreviewDialog.Visible = False
        '
        'graphLegend
        '
        Me.graphLegend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graphLegend.Items.AddRange(New NationalInstruments.UI.LegendItem() {Me.LegendItem1, Me.LegendItem2, Me.LegendItem3})
        Me.graphLegend.Location = New System.Drawing.Point(344, 195)
        Me.graphLegend.Name = "graphLegend"
        Me.graphLegend.Size = New System.Drawing.Size(91, 92)
        Me.graphLegend.TabIndex = 2
        '
        'LegendItem1
        '
        Me.LegendItem1.Source = Me.sineWavePlot
        Me.LegendItem1.Text = "Sine"
        '
        'LegendItem2
        '
        Me.LegendItem2.Source = Me.squareWavePlot
        Me.LegendItem2.Text = "Square"
        '
        'LegendItem3
        '
        Me.LegendItem3.Source = Me.triangleWavePlot
        Me.LegendItem3.Text = "Triangle"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(442, 422)
        Me.Controls.Add(Me.graphLegend)
        Me.Controls.Add(Me.settingsGroupBox)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(360, 456)
        Me.Name = "MainForm"
        Me.Text = "Printing Example"
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsGroupBox.ResumeLayout(False)
        CType(Me.graphLegend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Shared Function GenerateSineWave(ByVal xRange As Integer, ByVal yRange As Integer) As Double()
        If xRange < 0 Then
            Throw New ArgumentOutOfRangeException("xRange")
        End If

        If yRange < 0 Then
            Throw New ArgumentOutOfRangeException("yRange")
        End If

        Dim data() As Double = New Double(xRange) {}
        Dim i As Integer
        For i = 0 To xRange
            data(i) = yRange / 2 * (1 - CType(Math.Sin(i * 2 * Math.PI / (xRange - 1)), Single))
        Next

        Return data
    End Function

    Private Shared Function GenerateTriangleWave(ByVal xRange As Integer, ByVal yMin As Integer, ByVal yMax As Integer, ByVal interval As Double) As Double()
        If xRange < 0 Then
            Throw New ArgumentOutOfRangeException("xRange")
        End If

        If yMin < 0 Then
            Throw New ArgumentOutOfRangeException("yMin")
        End If

        If yMax < 0 Then
            Throw New ArgumentOutOfRangeException("yMax")
        End If

        If interval < 0 Then
            Throw New ArgumentOutOfRangeException("interval")
        End If

        Dim count As Integer = CType((xRange / interval), Integer)
        Dim data() As Double = New Double(count) {}

        Dim i As Integer
        For i = 0 To count
            data(i) = IIf((Decimal.Remainder(i, 2) = 0), yMin, yMax)
        Next

        Return data
    End Function

    Private Sub PrintPageEntireGraph(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim bounds As Rectangle = e.MarginBounds

        sampleWaveformGraph.Draw(New ComponentDrawArgs(g, bounds))
    End Sub

    Private Sub PrintPageAllPlotsStacked(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics
        Dim bounds As Rectangle = e.MarginBounds

        Dim originalXAxisBounds As Rectangle = xAxis.GetBounds()
        Dim originalYAxisBounds As Rectangle = yAxis.GetBounds()

        Dim plotWidth As Integer = bounds.Width - originalYAxisBounds.Width
        Dim plotHeight As Integer = ((bounds.Height - (originalXAxisBounds.Height * 4)) / 3)

        ' Draw the sine wave plot
        Dim sinePlotBounds As Rectangle = New Rectangle( _
            bounds.X + originalYAxisBounds.Width, _
            bounds.Y + originalXAxisBounds.Height, _
            plotWidth, _
            plotHeight _
            )

        ' Draw a common x axis at the top of the stack.
        Dim topXAxisBounds As Rectangle = xAxis.GetBounds(g, sinePlotBounds, XAxisPosition.Top)
        xAxis.Draw(New ComponentDrawArgs(g, topXAxisBounds), XAxisPosition.Top)

        Dim sineYAxisBounds As Rectangle = yAxis.GetBounds(g, sinePlotBounds)
        yAxis.Draw(New ComponentDrawArgs(g, sineYAxisBounds), YAxisPosition.Left)
        g.FillRectangle(Brushes.Black, sinePlotBounds)
        sineWavePlot.Draw(New ComponentDrawArgs(g, sinePlotBounds))

        ' Draw the triangle wave plot
        Dim trianglePlotBounds As Rectangle = New Rectangle( _
                bounds.X + originalYAxisBounds.Width, _
                bounds.Y + (originalXAxisBounds.Height * 2) + plotHeight, _
                plotWidth, _
                plotHeight _
                )

        Dim triangleYAxisBounds As Rectangle = yAxis.GetBounds(g, trianglePlotBounds)
        yAxis.Draw(New ComponentDrawArgs(g, triangleYAxisBounds), YAxisPosition.Left)
        g.FillRectangle(Brushes.Black, trianglePlotBounds)
        triangleWavePlot.Draw(New ComponentDrawArgs(g, trianglePlotBounds))

        ' Draw the square wave plot
        Dim squarePlotBounds As Rectangle = New Rectangle( _
            bounds.X + originalYAxisBounds.Width, _
            bounds.Y + (originalXAxisBounds.Height * 3) + (plotHeight * 2), _
            plotWidth, _
            plotHeight _
            )

        Dim squareYAxisBounds As Rectangle = yAxis.GetBounds(g, squarePlotBounds)
        yAxis.Draw(New ComponentDrawArgs(g, squareYAxisBounds), YAxisPosition.Left)
        g.FillRectangle(Brushes.Black, squarePlotBounds)
        squareWavePlot.Draw(New ComponentDrawArgs(g, squarePlotBounds))

        ' Draw a common x axis at the bottom of the stack.
        Dim bottomXAxisBounds As Rectangle = xAxis.GetBounds(g, squarePlotBounds)
        xAxis.Draw(New ComponentDrawArgs(g, bottomXAxisBounds), XAxisPosition.Bottom)
    End Sub

    Private Sub PrintPageOnlySineWave(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        Dim plotBounds As Rectangle, xAxisBounds As Rectangle, yAxisBounds As Rectangle
        GetElementsBounds(e, plotBounds, xAxisBounds, yAxisBounds)

        xAxis.Draw(New ComponentDrawArgs(g, xAxisBounds), XAxisPosition.Bottom)
        yAxis.Draw(New ComponentDrawArgs(g, yAxisBounds), YAxisPosition.Left)

        g.FillRectangle(Brushes.Black, plotBounds)
        sineWavePlot.Draw(New ComponentDrawArgs(g, plotBounds))
    End Sub

    Private Sub PrintPageOnlyTriangleWave(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        Dim plotBounds As Rectangle, xAxisBounds As Rectangle, yAxisBounds As Rectangle
        GetElementsBounds(e, plotBounds, xAxisBounds, yAxisBounds)

        xAxis.Draw(New ComponentDrawArgs(g, xAxisBounds), XAxisPosition.Bottom)
        yAxis.Draw(New ComponentDrawArgs(g, yAxisBounds), YAxisPosition.Left)

        g.FillRectangle(Brushes.Black, plotBounds)
        triangleWavePlot.Draw(New ComponentDrawArgs(g, plotBounds))
    End Sub

    Private Sub PrintPageOnlySquareWave(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim g As Graphics = e.Graphics

        Dim plotBounds As Rectangle, xAxisBounds As Rectangle, yAxisBounds As Rectangle
        GetElementsBounds(e, plotBounds, xAxisBounds, yAxisBounds)

        xAxis.Draw(New ComponentDrawArgs(g, xAxisBounds), XAxisPosition.Bottom)
        yAxis.Draw(New ComponentDrawArgs(g, yAxisBounds), YAxisPosition.Left)

        g.FillRectangle(Brushes.Black, plotBounds)
        squareWavePlot.Draw(New ComponentDrawArgs(g, plotBounds))
    End Sub

    Private Sub OnPrintPreviewClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printPreviewButton.Click
        Dim document As PrintDocument
        document = Nothing
        Try
            document = New PrintDocument
            If document.PrinterSettings.IsValid Then
                AddHandler document.PrintPage, Me.GetPrintPageEventHandler()
                graphPrintPreviewDialog.Document = document
                graphPrintPreviewDialog.ShowDialog(Me)
            Else
                MessageBox.Show(Me, New InvalidPrinterException(document.PrinterSettings).Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            document.Dispose()
        End Try
    End Sub

    Private Sub OnPrintClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        Dim document As PrintDocument
        document = Nothing
        Try
            document = New PrintDocument
            If document.PrinterSettings.IsValid Then
                AddHandler document.PrintPage, Me.GetPrintPageEventHandler()
                document.Print()
            Else
                MessageBox.Show(Me, New InvalidPrinterException(document.PrinterSettings).Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Finally
            document.Dispose()
        End Try
    End Sub

    Private Function GetPrintPageEventHandler() As PrintPageEventHandler
        Dim handler As PrintPageEventHandler = New PrintPageEventHandler(AddressOf Me.PrintPageEntireGraph)
        If (optionGraphRadioButton.Checked) Then
            handler = New PrintPageEventHandler(AddressOf Me.PrintPageEntireGraph)
        ElseIf (optionStackedPlotsRadioButton.Checked) Then
            handler = New PrintPageEventHandler(AddressOf Me.PrintPageAllPlotsStacked)
        ElseIf (optionSineWaveRadioButton.Checked) Then
            handler = New PrintPageEventHandler(AddressOf Me.PrintPageOnlySineWave)
        ElseIf (optionTriangleWaveRadioButton.Checked) Then
            handler = New PrintPageEventHandler(AddressOf Me.PrintPageOnlyTriangleWave)
        ElseIf (optionSquareWaveRadioButton.Checked) Then
            handler = New PrintPageEventHandler(AddressOf Me.PrintPageOnlySquareWave)
        End If

        Return handler
    End Function

    Private Sub GetElementsBounds(ByVal e As PrintPageEventArgs, ByRef plotBounds As Rectangle, ByRef xAxisBounds As Rectangle, ByRef yAxisBounds As Rectangle)
        Dim g As Graphics = e.Graphics
        Dim bounds As Rectangle = Rectangle.Inflate(e.MarginBounds, 0, -2 * e.PageSettings.Margins.Top)

        Dim originalXAxisBounds As Rectangle = xAxis.GetBounds()
        Dim originalYAxisBounds As Rectangle = yAxis.GetBounds()

        plotBounds = New Rectangle( _
            bounds.X + originalYAxisBounds.Width, _
            bounds.Y + originalXAxisBounds.Height, _
            bounds.Width - originalYAxisBounds.Width, _
            bounds.Height - (originalXAxisBounds.Height * 2) _
            )

        xAxisBounds = xAxis.GetBounds(g, plotBounds)
        yAxisBounds = yAxis.GetBounds(g, plotBounds)
    End Sub
End Class
