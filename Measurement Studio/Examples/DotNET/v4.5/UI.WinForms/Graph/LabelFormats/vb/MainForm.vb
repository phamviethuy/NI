Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private Const dataCount As Integer = 100
    Private convertedData As Double = 0
    Private r As New Random()

    Private dataType As DataType = dataType.[Double]
    Private plottingType As PlottingType = plottingType.PlotOnce

    Private NumericFormats As String() = New String() {"F2", "C0", "0.###'%'"}
    Private EngineeringFormats As String() = New String() {"EEE2", "s3", "S'Hz'"}
    Private DateTimeFormats As String() = New String() {"h:mm:ss tt", "h:mm", "MMM d, yyyy"}
    Private ElapsedTimeFormats As String() = New String() {"E:hh\:mm\:ss", "E:mm\:ss", "E:d\:hh\:mm\:ss"}

    Private sampleScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Private plotDataButton As System.Windows.Forms.Button
    Private timer As System.Windows.Forms.Timer
    Private chartDataButton As System.Windows.Forms.Button
    Private scatterPlot As NationalInstruments.UI.ScatterPlot
    Private xAxis As NationalInstruments.UI.XAxis
    Private yAxis As NationalInstruments.UI.YAxis
    Private groupBox1 As GroupBox
    Private labelFormatElapsedTimeFormat1 As RadioButton
    Private labelFormatDateTimeFormat1 As RadioButton
    Private labelFormatEngineeringFormat1 As RadioButton
    Private labelFormatNumericFormat1 As RadioButton
    Private groupBox2 As GroupBox
    Private _editRangeElapsedTimeFormat As RadioButton
    Private _editRangeDateTimeFormat As RadioButton
    Private _editRangeNumericFormat As RadioButton
    Private labelFormatElapsedTimeFormat3 As RadioButton
    Private labelFormatElapsedTimeFormat2 As RadioButton
    Private labelFormatDateTimeFormat3 As RadioButton
    Private labelFormatDateTimeFormat2 As RadioButton
    Private labelFormatEngineeringFormat3 As RadioButton
    Private labelFormatEngineeringFormat2 As RadioButton
    Private labelFormatNumericFormat3 As RadioButton
    Private labelFormatNumericFormat2 As RadioButton
    Private components As System.ComponentModel.IContainer

    Public Sub New()
        InitializeComponent()
        'InitializeData();

        ClearAndPlot(dataType.[Double], True)
        labelFormatNumericFormat1.[Select]()
        yAxis.Mode = AxisMode.AutoScaleLoose
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.sampleScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph()
        Me.scatterPlot = New NationalInstruments.UI.ScatterPlot()
        Me.xAxis = New NationalInstruments.UI.XAxis()
        Me.yAxis = New NationalInstruments.UI.YAxis()
        Me.plotDataButton = New System.Windows.Forms.Button()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.chartDataButton = New System.Windows.Forms.Button()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelFormatElapsedTimeFormat3 = New System.Windows.Forms.RadioButton()
        Me.labelFormatElapsedTimeFormat2 = New System.Windows.Forms.RadioButton()
        Me.labelFormatElapsedTimeFormat1 = New System.Windows.Forms.RadioButton()
        Me.labelFormatDateTimeFormat3 = New System.Windows.Forms.RadioButton()
        Me.labelFormatDateTimeFormat2 = New System.Windows.Forms.RadioButton()
        Me.labelFormatDateTimeFormat1 = New System.Windows.Forms.RadioButton()
        Me.labelFormatEngineeringFormat3 = New System.Windows.Forms.RadioButton()
        Me.labelFormatEngineeringFormat2 = New System.Windows.Forms.RadioButton()
        Me.labelFormatEngineeringFormat1 = New System.Windows.Forms.RadioButton()
        Me.labelFormatNumericFormat3 = New System.Windows.Forms.RadioButton()
        Me.labelFormatNumericFormat2 = New System.Windows.Forms.RadioButton()
        Me.labelFormatNumericFormat1 = New System.Windows.Forms.RadioButton()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me._editRangeElapsedTimeFormat = New System.Windows.Forms.RadioButton()
        Me._editRangeDateTimeFormat = New System.Windows.Forms.RadioButton()
        Me._editRangeNumericFormat = New System.Windows.Forms.RadioButton()
        DirectCast(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        Me.SuspendLayout()
        ' 
        ' sampleScatterGraph
        ' 
        Me.sampleScatterGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleScatterGraph.Caption = "National Instruments 2D Graph"
        Me.sampleScatterGraph.InteractionMode = DirectCast((((((((NationalInstruments.UI.GraphInteractionModes.ZoomX Or NationalInstruments.UI.GraphInteractionModes.ZoomY) Or NationalInstruments.UI.GraphInteractionModes.ZoomAroundPoint) Or NationalInstruments.UI.GraphInteractionModes.PanX) Or NationalInstruments.UI.GraphInteractionModes.PanY) Or NationalInstruments.UI.GraphInteractionModes.DragCursor) Or NationalInstruments.UI.GraphInteractionModes.DragAnnotationCaption) Or NationalInstruments.UI.GraphInteractionModes.EditRange), NationalInstruments.UI.GraphInteractionModes)
        Me.sampleScatterGraph.Location = New System.Drawing.Point(0, 0)
        Me.sampleScatterGraph.Name = "sampleScatterGraph"
        Me.sampleScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.scatterPlot})
        Me.sampleScatterGraph.Size = New System.Drawing.Size(837, 343)
        Me.sampleScatterGraph.TabIndex = 0
        Me.sampleScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        ' 
        ' scatterPlot
        ' 
        Me.scatterPlot.HistoryCapacity = 10000
        Me.scatterPlot.XAxis = Me.xAxis
        Me.scatterPlot.YAxis = Me.yAxis
        ' 
        ' xAxis
        ' 
        Me.xAxis.MajorDivisions.LabelFormat = New NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "F2")
        Me.xAxis.Mode = NationalInstruments.UI.AxisMode.ScopeChart
        ' 
        ' plotDataButton
        ' 
        Me.plotDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.plotDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.plotDataButton.Location = New System.Drawing.Point(327, 479)
        Me.plotDataButton.Name = "plotDataButton"
        Me.plotDataButton.Size = New System.Drawing.Size(88, 37)
        Me.plotDataButton.TabIndex = 1
        Me.plotDataButton.Text = "Plot Data"
        AddHandler Me.plotDataButton.Click, New System.EventHandler(AddressOf Me.plotDataButton_Click)
        ' 
        ' timer
        ' 
        AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTimer_Tick)
        ' 
        ' chartDataButton
        ' 
        Me.chartDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.chartDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.chartDataButton.Location = New System.Drawing.Point(421, 479)
        Me.chartDataButton.Name = "chartDataButton"
        Me.chartDataButton.Size = New System.Drawing.Size(96, 37)
        Me.chartDataButton.TabIndex = 2
        Me.chartDataButton.Text = "Chart Data"
        AddHandler Me.chartDataButton.Click, New System.EventHandler(AddressOf Me.chartDataButton_Click)
        ' 
        ' groupBox1
        ' 
        Me.groupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.labelFormatElapsedTimeFormat3)
        Me.groupBox1.Controls.Add(Me.labelFormatElapsedTimeFormat2)
        Me.groupBox1.Controls.Add(Me.labelFormatElapsedTimeFormat1)
        Me.groupBox1.Controls.Add(Me.labelFormatDateTimeFormat3)
        Me.groupBox1.Controls.Add(Me.labelFormatDateTimeFormat2)
        Me.groupBox1.Controls.Add(Me.labelFormatDateTimeFormat1)
        Me.groupBox1.Controls.Add(Me.labelFormatEngineeringFormat3)
        Me.groupBox1.Controls.Add(Me.labelFormatEngineeringFormat2)
        Me.groupBox1.Controls.Add(Me.labelFormatEngineeringFormat1)
        Me.groupBox1.Controls.Add(Me.labelFormatNumericFormat3)
        Me.groupBox1.Controls.Add(Me.labelFormatNumericFormat2)
        Me.groupBox1.Controls.Add(Me.labelFormatNumericFormat1)
        Me.groupBox1.Location = New System.Drawing.Point(6, 349)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Size = New System.Drawing.Size(610, 124)
        Me.groupBox1.TabIndex = 3
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Axis Label Formats Samples"
        ' 
        ' labelFormatElapsedTimeFormat3
        ' 
        Me.labelFormatElapsedTimeFormat3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatElapsedTimeFormat3.AutoSize = True
        Me.labelFormatElapsedTimeFormat3.Location = New System.Drawing.Point(408, 93)
        Me.labelFormatElapsedTimeFormat3.Name = "labelFormatElapsedTimeFormat3"
        Me.labelFormatElapsedTimeFormat3.Size = New System.Drawing.Size(185, 17)
        Me.labelFormatElapsedTimeFormat3.TabIndex = 0
        Me.labelFormatElapsedTimeFormat3.TabStop = True
        Me.labelFormatElapsedTimeFormat3.Text = "ElapsedTime, E:d\\:hh\\:mm\\:ss"
        Me.labelFormatElapsedTimeFormat3.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatElapsedTimeFormat3.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatElapsedTimeFormat3_CheckedChanged)
        ' 
        ' labelFormatElapsedTimeFormat2
        ' 
        Me.labelFormatElapsedTimeFormat2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatElapsedTimeFormat2.AutoSize = True
        Me.labelFormatElapsedTimeFormat2.Location = New System.Drawing.Point(216, 93)
        Me.labelFormatElapsedTimeFormat2.Name = "labelFormatElapsedTimeFormat2"
        Me.labelFormatElapsedTimeFormat2.Size = New System.Drawing.Size(141, 17)
        Me.labelFormatElapsedTimeFormat2.TabIndex = 0
        Me.labelFormatElapsedTimeFormat2.TabStop = True
        Me.labelFormatElapsedTimeFormat2.Text = "ElapsedTime, E:mm\\:ss"
        Me.labelFormatElapsedTimeFormat2.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatElapsedTimeFormat2.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatElapsedTimeFormat2_CheckedChanged)
        ' 
        ' labelFormatElapsedTimeFormat1
        ' 
        Me.labelFormatElapsedTimeFormat1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatElapsedTimeFormat1.AutoSize = True
        Me.labelFormatElapsedTimeFormat1.Location = New System.Drawing.Point(11, 93)
        Me.labelFormatElapsedTimeFormat1.Name = "labelFormatElapsedTimeFormat1"
        Me.labelFormatElapsedTimeFormat1.Size = New System.Drawing.Size(166, 17)
        Me.labelFormatElapsedTimeFormat1.TabIndex = 0
        Me.labelFormatElapsedTimeFormat1.TabStop = True
        Me.labelFormatElapsedTimeFormat1.Text = "ElapsedTime, E:hh\\:mm\\:ss"
        Me.labelFormatElapsedTimeFormat1.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatElapsedTimeFormat1.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatElapsedTimeFormat1_CheckedChanged)
        ' 
        ' labelFormatDateTimeFormat3
        ' 
        Me.labelFormatDateTimeFormat3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatDateTimeFormat3.AutoSize = True
        Me.labelFormatDateTimeFormat3.Location = New System.Drawing.Point(408, 70)
        Me.labelFormatDateTimeFormat3.Name = "labelFormatDateTimeFormat3"
        Me.labelFormatDateTimeFormat3.Size = New System.Drawing.Size(139, 17)
        Me.labelFormatDateTimeFormat3.TabIndex = 0
        Me.labelFormatDateTimeFormat3.TabStop = True
        Me.labelFormatDateTimeFormat3.Text = "DateTime, MMM d, yyyy"
        Me.labelFormatDateTimeFormat3.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatDateTimeFormat3.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatDateTimeFormat3_CheckedChanged)
        ' 
        ' labelFormatDateTimeFormat2
        ' 
        Me.labelFormatDateTimeFormat2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatDateTimeFormat2.AutoSize = True
        Me.labelFormatDateTimeFormat2.Location = New System.Drawing.Point(216, 70)
        Me.labelFormatDateTimeFormat2.Name = "labelFormatDateTimeFormat2"
        Me.labelFormatDateTimeFormat2.Size = New System.Drawing.Size(102, 17)
        Me.labelFormatDateTimeFormat2.TabIndex = 0
        Me.labelFormatDateTimeFormat2.TabStop = True
        Me.labelFormatDateTimeFormat2.Text = "DateTime, h:mm"
        Me.labelFormatDateTimeFormat2.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatDateTimeFormat2.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatDateTimeFormat2_CheckedChanged)
        ' 
        ' labelFormatDateTimeFormat1
        ' 
        Me.labelFormatDateTimeFormat1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatDateTimeFormat1.AutoSize = True
        Me.labelFormatDateTimeFormat1.Location = New System.Drawing.Point(11, 70)
        Me.labelFormatDateTimeFormat1.Name = "labelFormatDateTimeFormat1"
        Me.labelFormatDateTimeFormat1.Size = New System.Drawing.Size(124, 17)
        Me.labelFormatDateTimeFormat1.TabIndex = 0
        Me.labelFormatDateTimeFormat1.TabStop = True
        Me.labelFormatDateTimeFormat1.Text = "DateTime, h:mm:ss tt"
        Me.labelFormatDateTimeFormat1.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatDateTimeFormat1.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatDateTimeFormat1_CheckedChanged)
        ' 
        ' labelFormatEngineeringFormat3
        ' 
        Me.labelFormatEngineeringFormat3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatEngineeringFormat3.AutoSize = True
        Me.labelFormatEngineeringFormat3.Location = New System.Drawing.Point(408, 47)
        Me.labelFormatEngineeringFormat3.Name = "labelFormatEngineeringFormat3"
        Me.labelFormatEngineeringFormat3.Size = New System.Drawing.Size(111, 17)
        Me.labelFormatEngineeringFormat3.TabIndex = 0
        Me.labelFormatEngineeringFormat3.TabStop = True
        Me.labelFormatEngineeringFormat3.Text = "Engineering, S'Hz'"
        Me.labelFormatEngineeringFormat3.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatEngineeringFormat3.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatEngineeringFormat3_CheckedChanged)
        ' 
        ' labelFormatEngineeringFormat2
        ' 
        Me.labelFormatEngineeringFormat2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatEngineeringFormat2.AutoSize = True
        Me.labelFormatEngineeringFormat2.Location = New System.Drawing.Point(216, 47)
        Me.labelFormatEngineeringFormat2.Name = "labelFormatEngineeringFormat2"
        Me.labelFormatEngineeringFormat2.Size = New System.Drawing.Size(98, 17)
        Me.labelFormatEngineeringFormat2.TabIndex = 0
        Me.labelFormatEngineeringFormat2.TabStop = True
        Me.labelFormatEngineeringFormat2.Text = "Engineering, s3"
        Me.labelFormatEngineeringFormat2.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatEngineeringFormat2.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatEngineeringFormat2_CheckedChanged)
        ' 
        ' labelFormatEngineeringFormat1
        ' 
        Me.labelFormatEngineeringFormat1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatEngineeringFormat1.AutoSize = True
        Me.labelFormatEngineeringFormat1.Location = New System.Drawing.Point(11, 47)
        Me.labelFormatEngineeringFormat1.Name = "labelFormatEngineeringFormat1"
        Me.labelFormatEngineeringFormat1.Size = New System.Drawing.Size(114, 17)
        Me.labelFormatEngineeringFormat1.TabIndex = 0
        Me.labelFormatEngineeringFormat1.TabStop = True
        Me.labelFormatEngineeringFormat1.Text = "Engineering, EEE2"
        Me.labelFormatEngineeringFormat1.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatEngineeringFormat1.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatEngineeringFormat1_CheckedChanged)
        ' 
        ' labelFormatNumericFormat3
        ' 
        Me.labelFormatNumericFormat3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatNumericFormat3.AutoSize = True
        Me.labelFormatNumericFormat3.Location = New System.Drawing.Point(408, 24)
        Me.labelFormatNumericFormat3.Name = "labelFormatNumericFormat3"
        Me.labelFormatNumericFormat3.Size = New System.Drawing.Size(112, 17)
        Me.labelFormatNumericFormat3.TabIndex = 0
        Me.labelFormatNumericFormat3.TabStop = True
        Me.labelFormatNumericFormat3.Text = "Numeric, 0.###'%'"
        Me.labelFormatNumericFormat3.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatNumericFormat3.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatNumericFormat3_CheckedChanged)
        ' 
        ' labelFormatNumericFormat2
        ' 
        Me.labelFormatNumericFormat2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatNumericFormat2.AutoSize = True
        Me.labelFormatNumericFormat2.Location = New System.Drawing.Point(216, 24)
        Me.labelFormatNumericFormat2.Name = "labelFormatNumericFormat2"
        Me.labelFormatNumericFormat2.Size = New System.Drawing.Size(83, 17)
        Me.labelFormatNumericFormat2.TabIndex = 0
        Me.labelFormatNumericFormat2.TabStop = True
        Me.labelFormatNumericFormat2.Text = "Numeric, C0"
        Me.labelFormatNumericFormat2.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatNumericFormat2.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatNumericFormat2_CheckedChanged)
        ' 
        ' labelFormatNumericFormat1
        ' 
        Me.labelFormatNumericFormat1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.labelFormatNumericFormat1.AutoSize = True
        Me.labelFormatNumericFormat1.Location = New System.Drawing.Point(11, 24)
        Me.labelFormatNumericFormat1.Name = "labelFormatNumericFormat1"
        Me.labelFormatNumericFormat1.Size = New System.Drawing.Size(82, 17)
        Me.labelFormatNumericFormat1.TabIndex = 0
        Me.labelFormatNumericFormat1.TabStop = True
        Me.labelFormatNumericFormat1.Text = "Numeric, F2"
        Me.labelFormatNumericFormat1.UseVisualStyleBackColor = True
        AddHandler Me.labelFormatNumericFormat1.CheckedChanged, New System.EventHandler(AddressOf Me.OnLabelFormatNumericFormat1_CheckedChanged)
        ' 
        ' groupBox2
        ' 
        Me.groupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.groupBox2.Controls.Add(Me._editRangeElapsedTimeFormat)
        Me.groupBox2.Controls.Add(Me._editRangeDateTimeFormat)
        Me.groupBox2.Controls.Add(Me._editRangeNumericFormat)
        Me.groupBox2.Location = New System.Drawing.Point(622, 349)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(209, 124)
        Me.groupBox2.TabIndex = 3
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Active Edit Range Format"
        ' 
        ' _editRangeElapsedTimeFormat
        ' 
        Me._editRangeElapsedTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me._editRangeElapsedTimeFormat.AutoSize = True
        Me._editRangeElapsedTimeFormat.Location = New System.Drawing.Point(40, 82)
        Me._editRangeElapsedTimeFormat.Name = "_editRangeElapsedTimeFormat"
        Me._editRangeElapsedTimeFormat.Size = New System.Drawing.Size(109, 17)
        Me._editRangeElapsedTimeFormat.TabIndex = 0
        Me._editRangeElapsedTimeFormat.TabStop = True
        Me._editRangeElapsedTimeFormat.Text = "Elapsed time: ""G"""
        Me._editRangeElapsedTimeFormat.UseVisualStyleBackColor = True
        AddHandler Me._editRangeElapsedTimeFormat.CheckedChanged, New System.EventHandler(AddressOf Me._editRangeElapsedTimeFormat_CheckedChanged)
        ' 
        ' _editRangeDateTimeFormat
        ' 
        Me._editRangeDateTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me._editRangeDateTimeFormat.AutoSize = True
        Me._editRangeDateTimeFormat.Location = New System.Drawing.Point(40, 59)
        Me._editRangeDateTimeFormat.Name = "_editRangeDateTimeFormat"
        Me._editRangeDateTimeFormat.Size = New System.Drawing.Size(134, 17)
        Me._editRangeDateTimeFormat.TabIndex = 0
        Me._editRangeDateTimeFormat.TabStop = True
        Me._editRangeDateTimeFormat.Text = "Date time: ""ShortTime"""
        Me._editRangeDateTimeFormat.UseVisualStyleBackColor = True
        AddHandler Me._editRangeDateTimeFormat.CheckedChanged, New System.EventHandler(AddressOf Me._editRangeDateTimeFormat_CheckedChanged)
        ' 
        ' _editRangeNumericFormat
        ' 
        Me._editRangeNumericFormat.Anchor = System.Windows.Forms.AnchorStyles.None
        Me._editRangeNumericFormat.AutoSize = True
        Me._editRangeNumericFormat.Location = New System.Drawing.Point(40, 36)
        Me._editRangeNumericFormat.Name = "_editRangeNumericFormat"
        Me._editRangeNumericFormat.Size = New System.Drawing.Size(140, 17)
        Me._editRangeNumericFormat.TabIndex = 0
        Me._editRangeNumericFormat.TabStop = True
        Me._editRangeNumericFormat.Text = "Numeric:  ""Generic: G5"""
        Me._editRangeNumericFormat.UseVisualStyleBackColor = True
        AddHandler Me._editRangeNumericFormat.CheckedChanged, New System.EventHandler(AddressOf Me._editRangeNumericFormat_CheckedChanged)
        ' 
        ' MainForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(837, 528)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.groupBox1)
        Me.Controls.Add(Me.chartDataButton)
        Me.Controls.Add(Me.plotDataButton)
        Me.Controls.Add(Me.sampleScatterGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Label Formats Example"
        DirectCast(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub


    'Plots the data that has timing information
    Private Sub plotDataButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        plottingType = plottingType.PlotOnce
        PlotOnce(True)
    End Sub

    Private Sub PlotOnce(ByVal plotNewData As Boolean)
        If plotNewData Then
            xAxis.Mode = AxisMode.AutoScaleLoose
            sampleScatterGraph.ClearData()

            If dataType = dataType.[Double] Then
                For i As Integer = 0 To dataCount - 1
                    sampleScatterGraph.PlotXYAppend(i, r.[Next](1, 10))
                Next
            Else
                For i As Integer = 0 To dataCount - 1
                    Dim convertedData As Double = CDbl(DataConverter.Convert(TimeSpan.FromHours(i * 12), GetType(Double)))
                    sampleScatterGraph.PlotXYAppend(convertedData, r.[Next](1, 25))
                Next
            End If
        End If
    End Sub
    Private Sub OnTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs)

        If convertedData > 100000000L Then
            convertedData = 0
            scatterPlot.ClearData()
        End If

        If dataType = dataType.[Double] Then
            convertedData += r.NextDouble() * 10
        Else
            convertedData += CDbl(DataConverter.Convert(TimeSpan.FromHours(10.2), GetType(Double)))
        End If

        sampleScatterGraph.PlotXYAppend(convertedData, r.NextDouble() * 10)
    End Sub

    'Starts or stops the charting of data that has timing information
    Private Sub chartDataButton_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        plottingType = plottingType.Chart
        Chart()
    End Sub

    Private Sub Chart()
        scatterPlot.ClearData()
        scatterPlot.PlotXY(0, 0)
        If dataType = dataType.[Double] Then
            xAxis.Range = New Range(0, 100)
        Else
            xAxis.Range = New Range(0, TimeSpan.FromDays(10).TotalSeconds)
        End If

        xAxis.Mode = AxisMode.StripChart

        If timer.Enabled Then
            timer.Enabled = False
            plotDataButton.Enabled = True
            chartDataButton.Text = "Chart Data"
        Else
            chartDataButton.Text = "Stop Charting"
            plotDataButton.Enabled = False
            timer.Enabled = True
        End If
    End Sub

    Private Sub ClearAndPlot(ByVal type As DataType, ByVal plotNewData As Boolean)
        dataType = type

        If plottingType = plottingType.PlotOnce Then
            PlotOnce(plotNewData)
        Else
            convertedData = 0
            Chart()
        End If
    End Sub

    Private Sub OnLabelFormatNumericFormat1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.[Double], False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Numeric, NumericFormats(0))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatNumericFormat2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.[Double], False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Numeric, NumericFormats(1))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatNumericFormat3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.[Double], False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Numeric, NumericFormats(2))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatEngineeringFormat1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.[Double], False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Engineering, EngineeringFormats(0))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatEngineeringFormat2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.[Double], False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Engineering, EngineeringFormats(1))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatEngineeringFormat3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.[Double], False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Engineering, EngineeringFormats(2))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatDateTimeFormat1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.DateTime, False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, DateTimeFormats(0))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatDateTimeFormat2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.DateTime, False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, DateTimeFormats(1))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatDateTimeFormat3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.DateTime, False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, DateTimeFormats(2))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatElapsedTimeFormat1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.DateTime, False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.ElapsedTime, ElapsedTimeFormats(0))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatElapsedTimeFormat2_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.DateTime, False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.ElapsedTime, ElapsedTimeFormats(1))
        ValidateEditRange()
    End Sub

    Private Sub OnLabelFormatElapsedTimeFormat3_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ClearAndPlot(dataType.DateTime, False)
        xAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.ElapsedTime, ElapsedTimeFormats(2))
        ValidateEditRange()
    End Sub

    Private Sub ValidateEditRange()
        If xAxis.MajorDivisions.LabelFormat.Mode = FormatStringMode.Numeric OrElse xAxis.MajorDivisions.LabelFormat.Mode = FormatStringMode.Engineering Then
            _editRangeNumericFormat.Checked = True
        ElseIf xAxis.MajorDivisions.LabelFormat.Mode = FormatStringMode.DateTime Then
            _editRangeDateTimeFormat.Checked = True
        End If
        If xAxis.MajorDivisions.LabelFormat.Mode = FormatStringMode.ElapsedTime Then
            _editRangeElapsedTimeFormat.Checked = True
        End If
    End Sub

    Private Sub _editRangeNumericFormat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ValidateEditRange()
    End Sub

    Private Sub _editRangeDateTimeFormat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ValidateEditRange()
    End Sub

    Private Sub _editRangeElapsedTimeFormat_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        ValidateEditRange()
    End Sub
End Class

Public Enum DataType
    [Double]
    DateTime
End Enum

Public Enum PlottingType
    PlotOnce
    Chart
End Enum
