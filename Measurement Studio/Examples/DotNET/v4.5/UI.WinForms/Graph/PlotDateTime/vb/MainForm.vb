Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms
Public Class MainForm
	Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

	Public Shared Sub Main()
		Application.EnableVisualStyles()
		Application.DoEvents()
		Application.Run(New MainForm)
	End Sub
	Public Sub New()
		MyBase.New()

		'This call is required by the Windows Form Designer.
		InitializeComponent()
		InitializeData()

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

	Private Const dataCount As Integer = 100
	Dim data() As DateTime = New DateTime((dataCount) - 1) {}
	Private currentIndex As Integer
	Dim startDate As DateTime = DateTime.Now
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	Friend WithEvents chartDataButton As System.Windows.Forms.Button
	Friend WithEvents timer As System.Windows.Forms.Timer
	Friend WithEvents plotDataButton As System.Windows.Forms.Button
    Friend WithEvents sampleScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents scatterPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.sampleScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.scatterPlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.chartDataButton = New System.Windows.Forms.Button
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.plotDataButton = New System.Windows.Forms.Button
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sampleScatterGraph
        '
        Me.sampleScatterGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleScatterGraph.Caption = "National Instruments 2D Graph"
        Me.sampleScatterGraph.Location = New System.Drawing.Point(0, 0)
        Me.sampleScatterGraph.Name = "sampleScatterGraph"
        Me.sampleScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.scatterPlot})
        Me.sampleScatterGraph.Size = New System.Drawing.Size(360, 200)
        Me.sampleScatterGraph.TabIndex = 0
        Me.sampleScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'scatterPlot
        '
        Me.scatterPlot.XAxis = Me.xAxis
        Me.scatterPlot.YAxis = Me.yAxis
        '
        'chartDataButton
        '
        Me.chartDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chartDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chartDataButton.Location = New System.Drawing.Point(216, 208)
        Me.chartDataButton.Name = "chartDataButton"
        Me.chartDataButton.Size = New System.Drawing.Size(96, 23)
        Me.chartDataButton.TabIndex = 4
        Me.chartDataButton.Text = "Chart Data"
        '
        'timer
        '
        '
        'plotDataButton
        '
        Me.plotDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.plotDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotDataButton.Location = New System.Drawing.Point(48, 208)
        Me.plotDataButton.Name = "plotDataButton"
        Me.plotDataButton.Size = New System.Drawing.Size(88, 23)
        Me.plotDataButton.TabIndex = 3
        Me.plotDataButton.Text = "Plot Data"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(360, 246)
        Me.Controls.Add(Me.plotDataButton)
        Me.Controls.Add(Me.sampleScatterGraph)
        Me.Controls.Add(Me.chartDataButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Plot Date Time Example"
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Plots the data that has timing information
    Private Sub plotDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles plotDataButton.Click
        Me.xAxis.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "MMM d, yyyy")
        xAxis.Mode = AxisMode.Fixed
        xAxis.Range = New Range(startDate, CType(data.GetValue((data.Length - 1)), Date))
        Dim r As Random = New Random
        sampleScatterGraph.ClearData()
        For Each dateTime As Date In data
            Dim convertedData As Double = CType(DataConverter.Convert(dateTime, GetType(System.Double)), Double)
            sampleScatterGraph.PlotXYAppend(convertedData, r.NextDouble)
        Next
    End Sub

    Private Sub InitializeData()
        Dim r As Random = New Random
        data(0) = startDate
        Dim i As Integer = 1
        For i = 1 To (data.Length - 1)
            data(i) = data((i - 1)).AddHours(r.Next(1, 24))
        Next i
    End Sub
    'Starts or stops the charting of data that has timing information
    Private Sub chartDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chartDataButton.Click
        Me.xAxis.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "MMM d, yyyy")
        currentIndex = 0
        If timer.Enabled Then
            timer.Enabled = False
            plotDataButton.Enabled = True
            chartDataButton.Text = "Chart Data"
        Else
            sampleScatterGraph.ClearData()
            xAxis.Range = New Range(startDate, TimeSpan.FromDays(10))
            xAxis.Mode = AxisMode.StripChart
            chartDataButton.Text = "Stop Charting"
            plotDataButton.Enabled = False
            timer.Enabled = True
        End If
    End Sub

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
        If (currentIndex = data.Length) Then
            currentIndex = 0
            chartDataButton.Text = "Chart Data"
            plotDataButton.Enabled = True
            timer.Enabled = False
        Else
            Dim r As Random = New Random
            Dim convertedData As Double = CType(DataConverter.Convert(data.GetValue(currentIndex), GetType(System.Double)), Double)
            sampleScatterGraph.PlotXYAppend(convertedData, r.NextDouble)
            currentIndex = (currentIndex + 1)
        End If
    End Sub
End Class


