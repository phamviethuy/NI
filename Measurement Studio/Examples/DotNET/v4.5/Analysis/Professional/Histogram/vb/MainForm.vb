Imports NationalInstruments.Analysis.Math
Imports NationalInstruments.Analysis.SignalGeneration

Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private Const datasize As Int32 = 100
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        genDataButton_Click(Nothing, Nothing)
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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents XAxis1 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents ScatterPlot1 As NationalInstruments.UI.ScatterPlot
    Friend WithEvents XAxis2 As NationalInstruments.UI.XAxis
    Friend WithEvents YAxis2 As NationalInstruments.UI.YAxis
    Friend WithEvents WaveformPlot1 As NationalInstruments.UI.WaveformPlot
    Friend WithEvents numBinsLabel As System.Windows.Forms.Label
    Friend WithEvents stdDevLabel As System.Windows.Forms.Label
    Friend WithEvents numBinsNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents genDataButton As System.Windows.Forms.Button
    Friend WithEvents histogramScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents dataWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents settingsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents standardDevNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.histogramScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.ScatterPlot1 = New NationalInstruments.UI.ScatterPlot
        Me.XAxis1 = New NationalInstruments.UI.XAxis
        Me.YAxis1 = New NationalInstruments.UI.YAxis
        Me.dataWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.WaveformPlot1 = New NationalInstruments.UI.WaveformPlot
        Me.XAxis2 = New NationalInstruments.UI.XAxis
        Me.YAxis2 = New NationalInstruments.UI.YAxis
        Me.settingsGroupBox = New System.Windows.Forms.GroupBox
        Me.numBinsLabel = New System.Windows.Forms.Label
        Me.stdDevLabel = New System.Windows.Forms.Label
        Me.standardDevNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numBinsNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.genDataButton = New System.Windows.Forms.Button
        CType(Me.histogramScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsGroupBox.SuspendLayout()
        CType(Me.standardDevNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBinsNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'histogramScatterGraph
        '
        Me.histogramScatterGraph.Caption = "Histogram"
        Me.histogramScatterGraph.Location = New System.Drawing.Point(8, 216)
        Me.histogramScatterGraph.Name = "histogramScatterGraph"
        Me.histogramScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.ScatterPlot1})
        Me.histogramScatterGraph.Size = New System.Drawing.Size(432, 200)
        Me.histogramScatterGraph.TabIndex = 2
        Me.histogramScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.histogramScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        '
        'ScatterPlot1
        '
        Me.ScatterPlot1.FillMode = NationalInstruments.UI.PlotFillMode.FillAndBins
        Me.ScatterPlot1.LineColor = System.Drawing.Color.BurlyWood
        Me.ScatterPlot1.LineStep = NationalInstruments.UI.LineStep.CenteredXYStep
        Me.ScatterPlot1.XAxis = Me.XAxis1
        Me.ScatterPlot1.YAxis = Me.YAxis1
        '
        'dataWaveformGraph
        '
        Me.dataWaveformGraph.Caption = "Raw Data"
        Me.dataWaveformGraph.Location = New System.Drawing.Point(8, 8)
        Me.dataWaveformGraph.Name = "dataWaveformGraph"
        Me.dataWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.WaveformPlot1})
        Me.dataWaveformGraph.Size = New System.Drawing.Size(432, 200)
        Me.dataWaveformGraph.TabIndex = 3
        Me.dataWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis2})
        Me.dataWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis2})
        '
        'WaveformPlot1
        '
        Me.WaveformPlot1.XAxis = Me.XAxis2
        Me.WaveformPlot1.YAxis = Me.YAxis2
        '
        'settingsGroupBox
        '
        Me.settingsGroupBox.Controls.Add(Me.numBinsLabel)
        Me.settingsGroupBox.Controls.Add(Me.stdDevLabel)
        Me.settingsGroupBox.Controls.Add(Me.standardDevNumericEdit)
        Me.settingsGroupBox.Controls.Add(Me.numBinsNumericEdit)
        Me.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.settingsGroupBox.Location = New System.Drawing.Point(8, 424)
        Me.settingsGroupBox.Name = "settingsGroupBox"
        Me.settingsGroupBox.Size = New System.Drawing.Size(224, 80)
        Me.settingsGroupBox.TabIndex = 1
        Me.settingsGroupBox.TabStop = False
        Me.settingsGroupBox.Text = "Data Settings"
        '
        'numBinsLabel
        '
        Me.numBinsLabel.Location = New System.Drawing.Point(16, 20)
        Me.numBinsLabel.Name = "numBinsLabel"
        Me.numBinsLabel.Size = New System.Drawing.Size(88, 16)
        Me.numBinsLabel.TabIndex = 7
        Me.numBinsLabel.Text = "Number of Bins: "
        '
        'stdDevLabel
        '
        Me.stdDevLabel.Location = New System.Drawing.Point(16, 48)
        Me.stdDevLabel.Name = "stdDevLabel"
        Me.stdDevLabel.Size = New System.Drawing.Size(104, 16)
        Me.stdDevLabel.TabIndex = 8
        Me.stdDevLabel.Text = "Standard Deviation: "
        '
        'standardDevNumericEdit
        '
        Me.standardDevNumericEdit.Location = New System.Drawing.Point(136, 48)
        Me.standardDevNumericEdit.Name = "standardDevNumericEdit"
        Me.standardDevNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.standardDevNumericEdit.Range = New NationalInstruments.UI.Range(0.1, 10000)
        Me.standardDevNumericEdit.Size = New System.Drawing.Size(77, 20)
        Me.standardDevNumericEdit.TabIndex = 1
        Me.standardDevNumericEdit.Value = 1
        '
        'numBinsNumericEdit
        '
        Me.numBinsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("F0")
        Me.numBinsNumericEdit.Location = New System.Drawing.Point(136, 16)
        Me.numBinsNumericEdit.Name = "numBinsNumericEdit"
        Me.numBinsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numBinsNumericEdit.Range = New NationalInstruments.UI.Range(1, 1000)
        Me.numBinsNumericEdit.Size = New System.Drawing.Size(77, 20)
        Me.numBinsNumericEdit.TabIndex = 0
        Me.numBinsNumericEdit.Value = 20
        '
        'genDataButton
        '
        Me.genDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.genDataButton.Location = New System.Drawing.Point(248, 432)
        Me.genDataButton.Name = "genDataButton"
        Me.genDataButton.Size = New System.Drawing.Size(192, 40)
        Me.genDataButton.TabIndex = 0
        Me.genDataButton.Text = "Display Data"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(450, 511)
        Me.Controls.Add(Me.genDataButton)
        Me.Controls.Add(Me.settingsGroupBox)
        Me.Controls.Add(Me.dataWaveformGraph)
        Me.Controls.Add(Me.histogramScatterGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Histogram"
        CType(Me.histogramScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsGroupBox.ResumeLayout(False)
        CType(Me.standardDevNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBinsNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub


    Private Sub genDataButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles genDataButton.Click

        Dim numBins As Int32 = CType(numBinsNumericEdit.Value, Int32)
        Dim histogram() As Int32
        Dim centerValues() As Double = {}
        Dim doubleHistogram() As Double
        Dim data() As Double

        Try
            Dim signal As GaussianNoiseSignal = New GaussianNoiseSignal(standardDevNumericEdit.Value)
            data = signal.Generate(1000, datasize)
            dataWaveformGraph.PlotY(data)
            Dim minValue As Double = ArrayOperation.GetMin(data)
            Dim maxValue As Double = ArrayOperation.GetMax(data)
            histogram = Statistics.Histogram(data, minValue, maxValue, numBins, centerValues)

            doubleHistogram = CType(DataConverter.Convert(histogram, GetType(Double())), Double())
            histogramScatterGraph.PlotXY(centerValues, doubleHistogram)
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try
    End Sub
End Class
