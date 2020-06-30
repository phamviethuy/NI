'==================================================================================================
'
' Title      : MainForm.vb
' Purpose    : This example shows the user how to use the Analysis curve fitting
'              functions.   
'
'==================================================================================================


Imports System
Imports NationalInstruments.UI.WindowsForms
Imports NationalInstruments.Analysis.Math
Imports NationalInstruments.Analysis.SignalGeneration

    Public Class MainForm
        Inherits System.Windows.Forms.Form
   

#Region " Windows Form Designer generated code "

        Public Sub New()
            MyBase.New()

            'This call is required by the Windows Form Designer.
            InitializeComponent()


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
    Friend WithEvents PlotLegend As NationalInstruments.UI.WindowsForms.Legend
    Friend WithEvents legendItem1 As NationalInstruments.UI.LegendItem
    Friend WithEvents dataPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents legendItem2 As NationalInstruments.UI.LegendItem
    Friend WithEvents fittedPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents curveFitScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents coeff3Label As System.Windows.Forms.Label
    Friend WithEvents coeff2Label As System.Windows.Forms.Label
    Friend WithEvents coeff1Label As System.Windows.Forms.Label
    Friend WithEvents meanLabel As System.Windows.Forms.Label
    Friend WithEvents orderLabel As System.Windows.Forms.Label
    Friend WithEvents updateButton As System.Windows.Forms.Button
    Friend WithEvents samplesLabel As System.Windows.Forms.Label
    Friend WithEvents coeff1NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents coeff2NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents coeff3NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents mseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents samplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents orderNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.PlotLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.legendItem1 = New NationalInstruments.UI.LegendItem
        Me.dataPlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis1 = New NationalInstruments.UI.XAxis
        Me.yAxis1 = New NationalInstruments.UI.YAxis
        Me.legendItem2 = New NationalInstruments.UI.LegendItem
        Me.fittedPlot = New NationalInstruments.UI.ScatterPlot
        Me.curveFitScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.coeff3Label = New System.Windows.Forms.Label
        Me.coeff2Label = New System.Windows.Forms.Label
        Me.coeff1Label = New System.Windows.Forms.Label
        Me.meanLabel = New System.Windows.Forms.Label
        Me.orderLabel = New System.Windows.Forms.Label
        Me.updateButton = New System.Windows.Forms.Button
        Me.samplesLabel = New System.Windows.Forms.Label
        Me.samplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.orderNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.coeff1NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.coeff2NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.coeff3NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.mseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        CType(Me.PlotLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.curveFitScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coeff1NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coeff2NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.coeff3NumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PlotLegend
        '
        Me.PlotLegend.Items.AddRange(New NationalInstruments.UI.LegendItem() {Me.legendItem1, Me.legendItem2})
        Me.PlotLegend.Location = New System.Drawing.Point(504, 288)
        Me.PlotLegend.Name = "PlotLegend"
        Me.PlotLegend.Size = New System.Drawing.Size(104, 56)
        Me.PlotLegend.TabIndex = 37
        Me.PlotLegend.TabStop = False
        '
        'legendItem1
        '
        Me.legendItem1.Source = Me.dataPlot
        Me.legendItem1.Text = "Input Signal"
        '
        'dataPlot
        '
        Me.dataPlot.XAxis = Me.xAxis1
        Me.dataPlot.YAxis = Me.yAxis1
        '
        'legendItem2
        '
        Me.legendItem2.Source = Me.fittedPlot
        Me.legendItem2.Text = "Fitted Data"
        '
        'fittedPlot
        '
        Me.fittedPlot.XAxis = Me.xAxis1
        Me.fittedPlot.YAxis = Me.yAxis1
        '
        'curveFitScatterGraph
        '
        Me.curveFitScatterGraph.Location = New System.Drawing.Point(128, 24)
        Me.curveFitScatterGraph.Name = "curveFitScatterGraph"
        Me.curveFitScatterGraph.UseColorGenerator = True
        Me.curveFitScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.dataPlot, Me.fittedPlot})
        Me.curveFitScatterGraph.Size = New System.Drawing.Size(360, 320)
        Me.curveFitScatterGraph.TabIndex = 36
        Me.curveFitScatterGraph.TabStop = False
        Me.curveFitScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis1})
        Me.curveFitScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis1})
        '
        'coeff3Label
        '
        Me.coeff3Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coeff3Label.Location = New System.Drawing.Point(16, 208)
        Me.coeff3Label.Name = "coeff3Label"
        Me.coeff3Label.Size = New System.Drawing.Size(104, 16)
        Me.coeff3Label.TabIndex = 31
        Me.coeff3Label.Text = "Third Coefficient:"
        '
        'coeff2Label
        '
        Me.coeff2Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coeff2Label.Location = New System.Drawing.Point(16, 160)
        Me.coeff2Label.Name = "coeff2Label"
        Me.coeff2Label.Size = New System.Drawing.Size(112, 16)
        Me.coeff2Label.TabIndex = 30
        Me.coeff2Label.Text = "Second Coefficient:"
        '
        'coeff1Label
        '
        Me.coeff1Label.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.coeff1Label.Location = New System.Drawing.Point(16, 112)
        Me.coeff1Label.Name = "coeff1Label"
        Me.coeff1Label.Size = New System.Drawing.Size(88, 16)
        Me.coeff1Label.TabIndex = 29
        Me.coeff1Label.Text = "First Coefficient:"
        '
        'meanLabel
        '
        Me.meanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.meanLabel.Location = New System.Drawing.Point(16, 256)
        Me.meanLabel.Name = "meanLabel"
        Me.meanLabel.Size = New System.Drawing.Size(112, 16)
        Me.meanLabel.TabIndex = 28
        Me.meanLabel.Text = "Mean Squared Error:"
        '
        'orderLabel
        '
        Me.orderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.orderLabel.Location = New System.Drawing.Point(16, 56)
        Me.orderLabel.Name = "orderLabel"
        Me.orderLabel.Size = New System.Drawing.Size(104, 16)
        Me.orderLabel.TabIndex = 26
        Me.orderLabel.Text = "Polynomial Order:"
        '
        'updateButton
        '
        Me.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.updateButton.Location = New System.Drawing.Point(16, 312)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(96, 32)
        Me.updateButton.TabIndex = 0
        Me.updateButton.Text = "Update Plot"
        '
        'samplesLabel
        '
        Me.samplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.samplesLabel.Location = New System.Drawing.Point(16, 8)
        Me.samplesLabel.Name = "samplesLabel"
        Me.samplesLabel.Size = New System.Drawing.Size(112, 16)
        Me.samplesLabel.TabIndex = 25
        Me.samplesLabel.Text = "Number of Samples:"
        '
        'samplesNumericEdit
        '
        Me.samplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.samplesNumericEdit.Location = New System.Drawing.Point(16, 24)
        Me.samplesNumericEdit.Name = "samplesNumericEdit"
        Me.samplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplesNumericEdit.Range = New NationalInstruments.UI.Range(3, Double.PositiveInfinity)
        Me.samplesNumericEdit.Size = New System.Drawing.Size(94, 20)
        Me.samplesNumericEdit.TabIndex = 1
        Me.samplesNumericEdit.Value = 50
        '
        'orderNumericEdit
        '
        Me.orderNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.orderNumericEdit.Location = New System.Drawing.Point(16, 72)
        Me.orderNumericEdit.Name = "orderNumericEdit"
        Me.orderNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.orderNumericEdit.Range = New NationalInstruments.UI.Range(2, 50)
        Me.orderNumericEdit.Size = New System.Drawing.Size(94, 20)
        Me.orderNumericEdit.TabIndex = 2
        Me.orderNumericEdit.Value = 2
        '
        'coeff1NumericEdit
        '
        Me.coeff1NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6)
        Me.coeff1NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.coeff1NumericEdit.Location = New System.Drawing.Point(16, 128)
        Me.coeff1NumericEdit.Name = "coeff1NumericEdit"
        Me.coeff1NumericEdit.Size = New System.Drawing.Size(95, 20)
        Me.coeff1NumericEdit.TabIndex = 2
        Me.coeff1NumericEdit.TabStop = False
        '
        'coeff2NumericEdit
        '
        Me.coeff2NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6)
        Me.coeff2NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.coeff2NumericEdit.Location = New System.Drawing.Point(16, 176)
        Me.coeff2NumericEdit.Name = "coeff2NumericEdit"
        Me.coeff2NumericEdit.Size = New System.Drawing.Size(95, 20)
        Me.coeff2NumericEdit.TabIndex = 2
        Me.coeff2NumericEdit.TabStop = False
        '
        'coeff3NumericEdit
        '
        Me.coeff3NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6)
        Me.coeff3NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.coeff3NumericEdit.Location = New System.Drawing.Point(16, 224)
        Me.coeff3NumericEdit.Name = "coeff3NumericEdit"
        Me.coeff3NumericEdit.Size = New System.Drawing.Size(95, 20)
        Me.coeff3NumericEdit.TabIndex = 2
        Me.coeff3NumericEdit.TabStop = False
        '
        'mseNumericEdit
        '
        Me.mseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(6)
        Me.mseNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.mseNumericEdit.Location = New System.Drawing.Point(16, 272)
        Me.mseNumericEdit.Name = "mseNumericEdit"
        Me.mseNumericEdit.Size = New System.Drawing.Size(95, 20)
        Me.mseNumericEdit.TabIndex = 2
        Me.mseNumericEdit.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(618, 360)
        Me.Controls.Add(Me.samplesNumericEdit)
        Me.Controls.Add(Me.PlotLegend)
        Me.Controls.Add(Me.curveFitScatterGraph)
        Me.Controls.Add(Me.coeff3Label)
        Me.Controls.Add(Me.coeff2Label)
        Me.Controls.Add(Me.coeff1Label)
        Me.Controls.Add(Me.meanLabel)
        Me.Controls.Add(Me.orderLabel)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.samplesLabel)
        Me.Controls.Add(Me.orderNumericEdit)
        Me.Controls.Add(Me.coeff1NumericEdit)
        Me.Controls.Add(Me.coeff2NumericEdit)
        Me.Controls.Add(Me.coeff3NumericEdit)
        Me.Controls.Add(Me.mseNumericEdit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curve Fitting"
        CType(Me.PlotLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.curveFitScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.samplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coeff1NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coeff2NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.coeff3NumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    <STAThread()> Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub updateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateButton.Click
        Try
            ' Initialization.
            Dim mean As Double
            Dim coeffArray() As Double = {}
            Dim samples As Integer = samplesNumericEdit.Value
            Dim xArray() As Double = New Double(samples - 1) {}
            Dim dataArray() As Double = New Double(samples - 1) {}
            Dim fittedArray() As Double = New Double(samples - 1) {}
            Dim functionGen As NationalInstruments.Analysis.SignalGeneration.BasicFunctionGenerator = New BasicFunctionGenerator(BasicFunctionGeneratorSignal.Sine, 2.0 / samples, BasicFunctionGenerator.DefaultAmplitude, BasicFunctionGenerator.DefaultPhase, BasicFunctionGenerator.DefaultOffset, 1.0, samples)

            ' Generate the sine wave and the fitted plot.
            xArray = PatternGeneration.Ramp(samples, 0, samples - 1)
            dataArray = functionGen.Generate()
            fittedArray = CurveFit.PolynomialFit(xArray, dataArray, orderNumericEdit.Value, PolynomialFitAlgorithm.Svd, coeffArray, mean)

            ' Display the mean and coefficient data.
            mseNumericEdit.Value = mean
            coeff1NumericEdit.Value = coeffArray(0)
            coeff2NumericEdit.Value = coeffArray(1)
            coeff3NumericEdit.Value = coeffArray(2)

            ' Plot the data on the graph.
            dataPlot.PlotXY(xArray, dataArray)
            fittedPlot.PlotXY(xArray, fittedArray)

        Catch exception As exception
            MessageBox.Show(exception.Message)
        End Try
    End Sub




End Class

