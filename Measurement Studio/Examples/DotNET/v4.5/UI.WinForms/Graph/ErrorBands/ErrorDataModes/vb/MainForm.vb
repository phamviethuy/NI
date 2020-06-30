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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents errorModeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents percentModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents constantModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents noneModeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents scatterPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents displayModePanel As System.Windows.Forms.Panel
    Friend WithEvents displayModeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents displayModeLabel As System.Windows.Forms.Label
    Friend WithEvents sampleScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.errorModeGroupBox = New System.Windows.Forms.GroupBox
        Me.percentModeRadioButton = New System.Windows.Forms.RadioButton
        Me.constantModeRadioButton = New System.Windows.Forms.RadioButton
        Me.noneModeRadioButton = New System.Windows.Forms.RadioButton
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.scatterPlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.sampleScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.displayModePanel = New System.Windows.Forms.Panel
        Me.displayModeComboBox = New System.Windows.Forms.ComboBox
        Me.displayModeLabel = New System.Windows.Forms.Label
        Me.errorModeGroupBox.SuspendLayout()
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.displayModePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'errorModeGroupBox
        '
        Me.errorModeGroupBox.Controls.Add(Me.percentModeRadioButton)
        Me.errorModeGroupBox.Controls.Add(Me.constantModeRadioButton)
        Me.errorModeGroupBox.Controls.Add(Me.noneModeRadioButton)
        Me.errorModeGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.errorModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.errorModeGroupBox.Location = New System.Drawing.Point(8, 302)
        Me.errorModeGroupBox.Name = "errorModeGroupBox"
        Me.errorModeGroupBox.Size = New System.Drawing.Size(376, 112)
        Me.errorModeGroupBox.TabIndex = 3
        Me.errorModeGroupBox.TabStop = False
        Me.errorModeGroupBox.Text = "&Error Data Mode"
        '
        'percentModeRadioButton
        '
        Me.percentModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.percentModeRadioButton.Location = New System.Drawing.Point(16, 80)
        Me.percentModeRadioButton.Name = "percentModeRadioButton"
        Me.percentModeRadioButton.Size = New System.Drawing.Size(120, 24)
        Me.percentModeRadioButton.TabIndex = 2
        Me.percentModeRadioButton.Text = "&Percent (+/- 10%)"
        '
        'constantModeRadioButton
        '
        Me.constantModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.constantModeRadioButton.Location = New System.Drawing.Point(16, 52)
        Me.constantModeRadioButton.Name = "constantModeRadioButton"
        Me.constantModeRadioButton.Size = New System.Drawing.Size(112, 24)
        Me.constantModeRadioButton.TabIndex = 1
        Me.constantModeRadioButton.Text = "&Constant (+/- 5)"
        '
        'noneModeRadioButton
        '
        Me.noneModeRadioButton.Checked = True
        Me.noneModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.noneModeRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.noneModeRadioButton.Name = "noneModeRadioButton"
        Me.noneModeRadioButton.TabIndex = 0
        Me.noneModeRadioButton.TabStop = True
        Me.noneModeRadioButton.Text = "&None"
        '
        'scatterPlot
        '
        Me.scatterPlot.CanScaleYAxis = True
        Me.scatterPlot.XAxis = Me.xAxis
        Me.scatterPlot.YAxis = Me.yAxis
        '
        'sampleScatterGraph
        '
        Me.sampleScatterGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleScatterGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleScatterGraph.Name = "scatterGraph"
        Me.sampleScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.scatterPlot})
        Me.sampleScatterGraph.Size = New System.Drawing.Size(376, 257)
        Me.sampleScatterGraph.TabIndex = 5
        Me.sampleScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'displayModePanel
        '
        Me.displayModePanel.Controls.Add(Me.displayModeComboBox)
        Me.displayModePanel.Controls.Add(Me.displayModeLabel)
        Me.displayModePanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.displayModePanel.DockPadding.Bottom = 8
        Me.displayModePanel.DockPadding.Top = 8
        Me.displayModePanel.Location = New System.Drawing.Point(8, 265)
        Me.displayModePanel.Name = "displayModePanel"
        Me.displayModePanel.Size = New System.Drawing.Size(376, 37)
        Me.displayModePanel.TabIndex = 4
        '
        'displayModeComboBox
        '
        Me.displayModeComboBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.displayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.displayModeComboBox.Location = New System.Drawing.Point(76, 8)
        Me.displayModeComboBox.Name = "displayModeComboBox"
        Me.displayModeComboBox.Size = New System.Drawing.Size(100, 21)
        Me.displayModeComboBox.TabIndex = 1
        '
        'displayModeLabel
        '
        Me.displayModeLabel.Dock = System.Windows.Forms.DockStyle.Left
        Me.displayModeLabel.Location = New System.Drawing.Point(0, 8)
        Me.displayModeLabel.Name = "displayModeLabel"
        Me.displayModeLabel.Size = New System.Drawing.Size(76, 21)
        Me.displayModeLabel.TabIndex = 0
        Me.displayModeLabel.Text = "&Display Mode:"
        Me.displayModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(392, 422)
        Me.Controls.Add(Me.sampleScatterGraph)
        Me.Controls.Add(Me.displayModePanel)
        Me.Controls.Add(Me.errorModeGroupBox)
        Me.DockPadding.All = 8
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(200, 321)
        Me.Name = "MainForm"
        Me.Text = "Error Data Modes"
        Me.errorModeGroupBox.ResumeLayout(False)
        CType(Me.sampleScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.displayModePanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Const pointCount As Integer = 60
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


        Dim displayMode As ErrorBandDisplayModes
        For Each displayMode In [Enum].GetValues(GetType(ErrorBandDisplayModes))
            displayModeComboBox.Items.Add(displayMode)
        Next
        displayModeComboBox.SelectedItem = scatterPlot.YErrorDisplayMode
    End Sub

    Private Sub displayModeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayModeComboBox.SelectedIndexChanged
        scatterPlot.YErrorDisplayMode = CType(displayModeComboBox.SelectedItem, ErrorBandDisplayModes)
    End Sub

    Private Sub noneModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noneModeRadioButton.CheckedChanged
        scatterPlot.YErrorDataMode = XYErrorDataMode.CreateNoneMode()
    End Sub

    Private Sub constantModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles constantModeRadioButton.CheckedChanged
        scatterPlot.YErrorDataMode = XYErrorDataMode.CreateConstantErrorMode(5.0)
    End Sub

    Private Sub percentModeRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles percentModeRadioButton.CheckedChanged
        scatterPlot.YErrorDataMode = XYErrorDataMode.CreatePercentErrorMode(0.1)
    End Sub
End Class
