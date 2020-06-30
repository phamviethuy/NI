Imports NationalInstruments
Imports NationalInstruments.UI
Public Class MainForm
    Inherits System.Windows.Forms.Form
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        customAxesColor = Color.Lime
        UpdateCustomAxesColors()
        customXAxisPositionComboBox.SelectedIndex = 0
        customYAxisPositionComboBox.SelectedIndex = 0
        sampleComplexGraph.PlotComplex(GenerateDefaultData())

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
    Friend WithEvents customAxesColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents vertSplitter As System.Windows.Forms.Splitter
    Friend WithEvents settingsPanel As System.Windows.Forms.Panel
    Friend WithEvents customAxesColorIndicatorLed As NationalInstruments.UI.WindowsForms.Led
    Friend WithEvents colorLabel As System.Windows.Forms.Label
    Friend WithEvents colorButton As System.Windows.Forms.Button
    Friend WithEvents customYAxisGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents yPositionLabel As System.Windows.Forms.Label
    Friend WithEvents customYAxisMinorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents customYAxisMajorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents customYAxisPositionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents customXAxisGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents xPositionLabel As System.Windows.Forms.Label
    Friend WithEvents customXAxisMinorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents customXAxisMajorCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents customXAxisPositionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents sampleComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph
    Friend WithEvents complexPlot As NationalInstruments.UI.ComplexPlot
    Friend WithEvents xAxis As NationalInstruments.UI.ComplexXAxis
    Friend WithEvents yAxis As NationalInstruments.UI.ComplexYAxis
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.customAxesColorDialog = New System.Windows.Forms.ColorDialog
        Me.vertSplitter = New System.Windows.Forms.Splitter
        Me.settingsPanel = New System.Windows.Forms.Panel
        Me.customAxesColorIndicatorLed = New NationalInstruments.UI.WindowsForms.Led
        Me.colorLabel = New System.Windows.Forms.Label
        Me.colorButton = New System.Windows.Forms.Button
        Me.customYAxisGroupBox = New System.Windows.Forms.GroupBox
        Me.yPositionLabel = New System.Windows.Forms.Label
        Me.customYAxisMinorCheckBox = New System.Windows.Forms.CheckBox
        Me.customYAxisMajorCheckBox = New System.Windows.Forms.CheckBox
        Me.customYAxisPositionComboBox = New System.Windows.Forms.ComboBox
        Me.customXAxisGroupBox = New System.Windows.Forms.GroupBox
        Me.xPositionLabel = New System.Windows.Forms.Label
        Me.customXAxisMinorCheckBox = New System.Windows.Forms.CheckBox
        Me.customXAxisMajorCheckBox = New System.Windows.Forms.CheckBox
        Me.customXAxisPositionComboBox = New System.Windows.Forms.ComboBox
        Me.sampleComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.complexPlot = New NationalInstruments.UI.ComplexPlot
        Me.xAxis = New NationalInstruments.UI.ComplexXAxis
        Me.yAxis = New NationalInstruments.UI.ComplexYAxis
        Me.settingsPanel.SuspendLayout()
        CType(Me.customAxesColorIndicatorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.customYAxisGroupBox.SuspendLayout()
        Me.customXAxisGroupBox.SuspendLayout()
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vertSplitter
        '
        Me.vertSplitter.BackColor = System.Drawing.SystemColors.ControlDark
        Me.vertSplitter.Location = New System.Drawing.Point(208, 0)
        Me.vertSplitter.Name = "vertSplitter"
        Me.vertSplitter.Size = New System.Drawing.Size(3, 334)
        Me.vertSplitter.TabIndex = 6
        Me.vertSplitter.TabStop = False
        '
        'settingsPanel
        '
        Me.settingsPanel.AutoScroll = True
        Me.settingsPanel.Controls.Add(Me.customAxesColorIndicatorLed)
        Me.settingsPanel.Controls.Add(Me.colorLabel)
        Me.settingsPanel.Controls.Add(Me.colorButton)
        Me.settingsPanel.Controls.Add(Me.customYAxisGroupBox)
        Me.settingsPanel.Controls.Add(Me.customXAxisGroupBox)
        Me.settingsPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.settingsPanel.Location = New System.Drawing.Point(0, 0)
        Me.settingsPanel.Name = "settingsPanel"
        Me.settingsPanel.Size = New System.Drawing.Size(208, 334)
        Me.settingsPanel.TabIndex = 4
        '
        'customAxesColorIndicatorLed
        '
        Me.customAxesColorIndicatorLed.LedStyle = NationalInstruments.UI.LedStyle.Square
        Me.customAxesColorIndicatorLed.Location = New System.Drawing.Point(128, 4)
        Me.customAxesColorIndicatorLed.Name = "customAxesColorIndicatorLed"
        Me.customAxesColorIndicatorLed.Size = New System.Drawing.Size(32, 24)
        Me.customAxesColorIndicatorLed.TabIndex = 8
        Me.customAxesColorIndicatorLed.TabStop = False
        Me.customAxesColorIndicatorLed.Value = True
        '
        'colorLabel
        '
        Me.colorLabel.Location = New System.Drawing.Point(16, 8)
        Me.colorLabel.Name = "colorLabel"
        Me.colorLabel.Size = New System.Drawing.Size(112, 16)
        Me.colorLabel.TabIndex = 7
        Me.colorLabel.Text = "Custom Axes Colors:"
        '
        'colorButton
        '
        Me.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.colorButton.Location = New System.Drawing.Point(160, 8)
        Me.colorButton.Name = "colorButton"
        Me.colorButton.Size = New System.Drawing.Size(32, 16)
        Me.colorButton.TabIndex = 0
        Me.colorButton.Text = "..."
        '
        'customYAxisGroupBox
        '
        Me.customYAxisGroupBox.Controls.Add(Me.yPositionLabel)
        Me.customYAxisGroupBox.Controls.Add(Me.customYAxisMinorCheckBox)
        Me.customYAxisGroupBox.Controls.Add(Me.customYAxisMajorCheckBox)
        Me.customYAxisGroupBox.Controls.Add(Me.customYAxisPositionComboBox)
        Me.customYAxisGroupBox.Location = New System.Drawing.Point(8, 176)
        Me.customYAxisGroupBox.Name = "customYAxisGroupBox"
        Me.customYAxisGroupBox.Size = New System.Drawing.Size(184, 144)
        Me.customYAxisGroupBox.TabIndex = 5
        Me.customYAxisGroupBox.TabStop = False
        Me.customYAxisGroupBox.Text = "Custom YAxis"
        '
        'yPositionLabel
        '
        Me.yPositionLabel.Location = New System.Drawing.Point(16, 16)
        Me.yPositionLabel.Name = "yPositionLabel"
        Me.yPositionLabel.Size = New System.Drawing.Size(120, 16)
        Me.yPositionLabel.TabIndex = 15
        Me.yPositionLabel.Text = "Position:"
        '
        'customYAxisMinorCheckBox
        '
        Me.customYAxisMinorCheckBox.Checked = True
        Me.customYAxisMinorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.customYAxisMinorCheckBox.Location = New System.Drawing.Point(16, 96)
        Me.customYAxisMinorCheckBox.Name = "customYAxisMinorCheckBox"
        Me.customYAxisMinorCheckBox.Size = New System.Drawing.Size(152, 32)
        Me.customYAxisMinorCheckBox.TabIndex = 6
        Me.customYAxisMinorCheckBox.Text = "Minor Divisions Visible"
        '
        'customYAxisMajorCheckBox
        '
        Me.customYAxisMajorCheckBox.Checked = True
        Me.customYAxisMajorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.customYAxisMajorCheckBox.Location = New System.Drawing.Point(16, 64)
        Me.customYAxisMajorCheckBox.Name = "customYAxisMajorCheckBox"
        Me.customYAxisMajorCheckBox.Size = New System.Drawing.Size(152, 32)
        Me.customYAxisMajorCheckBox.TabIndex = 5
        Me.customYAxisMajorCheckBox.Text = "Major Divisions Visible"
        '
        'customYAxisPositionComboBox
        '
        Me.customYAxisPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customYAxisPositionComboBox.Items.AddRange(New Object() {"Left", "Right", "Left and Right"})
        Me.customYAxisPositionComboBox.Location = New System.Drawing.Point(16, 32)
        Me.customYAxisPositionComboBox.Name = "customYAxisPositionComboBox"
        Me.customYAxisPositionComboBox.Size = New System.Drawing.Size(144, 21)
        Me.customYAxisPositionComboBox.TabIndex = 4
        '
        'customXAxisGroupBox
        '
        Me.customXAxisGroupBox.Controls.Add(Me.xPositionLabel)
        Me.customXAxisGroupBox.Controls.Add(Me.customXAxisMinorCheckBox)
        Me.customXAxisGroupBox.Controls.Add(Me.customXAxisMajorCheckBox)
        Me.customXAxisGroupBox.Controls.Add(Me.customXAxisPositionComboBox)
        Me.customXAxisGroupBox.Location = New System.Drawing.Point(8, 32)
        Me.customXAxisGroupBox.Name = "customXAxisGroupBox"
        Me.customXAxisGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.customXAxisGroupBox.Size = New System.Drawing.Size(184, 128)
        Me.customXAxisGroupBox.TabIndex = 4
        Me.customXAxisGroupBox.TabStop = False
        Me.customXAxisGroupBox.Text = "Custom XAxis"
        '
        'xPositionLabel
        '
        Me.xPositionLabel.Location = New System.Drawing.Point(16, 16)
        Me.xPositionLabel.Name = "xPositionLabel"
        Me.xPositionLabel.Size = New System.Drawing.Size(120, 16)
        Me.xPositionLabel.TabIndex = 16
        Me.xPositionLabel.Text = "Position:"
        '
        'customXAxisMinorCheckBox
        '
        Me.customXAxisMinorCheckBox.Checked = True
        Me.customXAxisMinorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.customXAxisMinorCheckBox.Location = New System.Drawing.Point(16, 96)
        Me.customXAxisMinorCheckBox.Name = "customXAxisMinorCheckBox"
        Me.customXAxisMinorCheckBox.Size = New System.Drawing.Size(144, 24)
        Me.customXAxisMinorCheckBox.TabIndex = 3
        Me.customXAxisMinorCheckBox.Text = "Minor Divisions Visible"
        '
        'customXAxisMajorCheckBox
        '
        Me.customXAxisMajorCheckBox.Checked = True
        Me.customXAxisMajorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.customXAxisMajorCheckBox.Location = New System.Drawing.Point(16, 64)
        Me.customXAxisMajorCheckBox.Name = "customXAxisMajorCheckBox"
        Me.customXAxisMajorCheckBox.Size = New System.Drawing.Size(144, 24)
        Me.customXAxisMajorCheckBox.TabIndex = 2
        Me.customXAxisMajorCheckBox.Text = "Major Divisions Visible"
        '
        'customXAxisPositionComboBox
        '
        Me.customXAxisPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.customXAxisPositionComboBox.Items.AddRange(New Object() {"Top", "Bottom", "Top and Bottom"})
        Me.customXAxisPositionComboBox.Location = New System.Drawing.Point(16, 32)
        Me.customXAxisPositionComboBox.Name = "customXAxisPositionComboBox"
        Me.customXAxisPositionComboBox.Size = New System.Drawing.Size(136, 21)
        Me.customXAxisPositionComboBox.TabIndex = 1
        '
        'sampleComplexGraph
        '
        Me.sampleComplexGraph.Caption = "Complex Graph"
        Me.sampleComplexGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.sampleComplexGraph.Location = New System.Drawing.Point(211, 0)
        Me.sampleComplexGraph.Name = "sampleComplexGraph"
        Me.sampleComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.complexPlot})
        Me.sampleComplexGraph.Size = New System.Drawing.Size(405, 334)
        Me.sampleComplexGraph.TabIndex = 7
        Me.sampleComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.xAxis})
        Me.sampleComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.yAxis})
        '
        'complexPlot
        '
        Me.complexPlot.AntiAliased = True
        Me.complexPlot.LineColor = System.Drawing.Color.Yellow
        Me.complexPlot.XAxis = Me.xAxis
        Me.complexPlot.YAxis = Me.yAxis
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(616, 334)
        Me.Controls.Add(Me.sampleComplexGraph)
        Me.Controls.Add(Me.vertSplitter)
        Me.Controls.Add(Me.settingsPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Custom Axis Drawing"
        Me.settingsPanel.ResumeLayout(False)
        CType(Me.customAxesColorIndicatorLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.customYAxisGroupBox.ResumeLayout(False)
        Me.customXAxisGroupBox.ResumeLayout(False)
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private customAxesColor As Color
    Private xAxisPosition As XAxisPosition
    Private yAxisPosition As YAxisPosition
    Private Const minorDivisionsTickLength As Integer = 3
    Private Const majorDivisionsTickLength As Integer = 10
    Private Const customAxisDimension As Integer = 20

    Private Sub complexGraph_AfterDrawPlotArea(ByVal sender As Object, ByVal e As NationalInstruments.UI.AfterDrawEventArgs) Handles sampleComplexGraph.AfterDrawPlotArea
        Dim origin As PointF = complexPlot.MapDataPoint(sampleComplexGraph.PlotAreaBounds, ComplexDouble.Zero)

        DrawCustomXAxis(e.Graphics, origin)
        DrawCustomYAxis(e.Graphics, origin)
    End Sub


    Private Sub DrawCustomXAxis(ByVal graphics As Graphics, ByVal origin As PointF)
        Dim yAxisClone As ComplexYAxis = CType(yAxis.Clone(), ComplexYAxis)

        yAxisClone.MajorDivisions.LabelVisible = False
        yAxisClone.MajorDivisions.TickColor = customAxesColor
        yAxisClone.MajorDivisions.TickVisible = customYAxisMajorCheckBox.Checked
        yAxisClone.MajorDivisions.TickLength = majorDivisionsTickLength

        yAxisClone.MinorDivisions.TickVisible = customYAxisMinorCheckBox.Checked
        yAxisClone.MinorDivisions.TickColor = customAxesColor
        yAxisClone.MinorDivisions.TickLength = minorDivisionsTickLength

        Select Case yAxisPosition
            Case yAxisPosition.LeftRight
                yAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(CInt(origin.X), sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension, sampleComplexGraph.PlotAreaBounds.Height)), yAxisPosition.Right)
                yAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(CInt(origin.X) - customAxisDimension, sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension, sampleComplexGraph.PlotAreaBounds.Height)), yAxisPosition.Left)
            Case yAxisPosition.Right
                yAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(CInt(origin.X), sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension, sampleComplexGraph.PlotAreaBounds.Height)), yAxisPosition.Right)
            Case yAxisPosition.Left
                yAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(CInt(origin.X) - customAxisDimension, sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension, sampleComplexGraph.PlotAreaBounds.Height)), yAxisPosition.Left)
            Case Else
        End Select
    End Sub 'DrawCustomXAxis
    Private Sub DrawCustomYAxis(ByVal graphics As Graphics, ByVal origin As PointF)
        Dim xAxisClone As ComplexXAxis = CType(xAxis.Clone(), ComplexXAxis)
        xAxisClone.MajorDivisions.LabelVisible = False
        xAxisClone.MajorDivisions.TickColor = customAxesColor
        xAxisClone.MajorDivisions.TickVisible = customXAxisMajorCheckBox.Checked
        xAxisClone.MajorDivisions.TickLength = majorDivisionsTickLength

        xAxisClone.MinorDivisions.TickVisible = customXAxisMinorCheckBox.Checked
        xAxisClone.MinorDivisions.TickColor = customAxesColor
        xAxisClone.MinorDivisions.TickLength = minorDivisionsTickLength

        Select Case xAxisPosition
            Case xAxisPosition.TopBottom
                xAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(sampleComplexGraph.PlotAreaBounds.Left, CInt(origin.Y), sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), xAxisPosition.Bottom)
                xAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(sampleComplexGraph.PlotAreaBounds.Left, CInt(origin.Y) - customAxisDimension, sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), xAxisPosition.Top)
            Case xAxisPosition.Top
                xAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(sampleComplexGraph.PlotAreaBounds.Left, CInt(origin.Y) - customAxisDimension, sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), xAxisPosition.Top)
            Case xAxisPosition.Bottom
                xAxisClone.Draw(New NationalInstruments.UI.ComponentDrawArgs(graphics, New Rectangle(sampleComplexGraph.PlotAreaBounds.Left, CInt(origin.Y), sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), xAxisPosition.Bottom)
            Case Else
        End Select
    End Sub 'DrawCustomYAxis

    Private Sub OnSettingsChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        sampleComplexGraph.Invalidate()
    End Sub 'OnSettingsChanged
    Private Sub UpdateCustomAxesColors()
        xAxis.OriginLineColor = customAxesColor
        yAxis.OriginLineColor = customAxesColor
        customAxesColorIndicatorLed.OnColor = customAxesColor
    End Sub 'UpdateCustomAxesColors 

    Private Sub colorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles colorButton.Click
        customAxesColorDialog.Color = customAxesColor
        If customAxesColorDialog.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Return
        End If
        customAxesColor = customAxesColorDialog.Color
        UpdateCustomAxesColors()
        sampleComplexGraph.Invalidate()
    End Sub

    Private Sub customXAxisMajorCheckbox_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles customXAxisMajorCheckBox.CheckedChanged, customXAxisMinorCheckBox.CheckedChanged, customYAxisMinorCheckBox.CheckedChanged, customYAxisMajorCheckBox.CheckedChanged
        OnSettingsChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub customXAxisPositionCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customXAxisPositionComboBox.SelectedIndexChanged
        Select Case customXAxisPositionComboBox.SelectedIndex
            Case 0
                xAxisPosition = xAxisPosition.Top
            Case 1
                xAxisPosition = xAxisPosition.Bottom
            Case 2
                xAxisPosition = xAxisPosition.TopBottom
            Case Else
                xAxisPosition = xAxisPosition.Top
        End Select
        OnSettingsChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub customYAxisPositionCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customYAxisPositionComboBox.SelectedIndexChanged

        Select Case customYAxisPositionComboBox.SelectedIndex
            Case 0
                yAxisPosition = yAxisPosition.Left
            Case 1
                yAxisPosition = yAxisPosition.Right
            Case 2
                yAxisPosition = yAxisPosition.LeftRight
            Case Else
                yAxisPosition = yAxisPosition.Left
        End Select
        OnSettingsChanged(Me, EventArgs.Empty)

    End Sub

    Public Shared Function GenerateDefaultData() As ComplexDouble()
        Const frequency As Double = 10.0
        Const samplingRate As Double = 1000
        Const numberOfSamples As Integer = 100
        Const amplitude As Integer = 10

        Dim f1 As Double = 2 * Math.PI * frequency / samplingRate
        Dim f2 As Double = 2 * Math.PI * (frequency + 10.0) / samplingRate

        Dim complexData() As ComplexDouble = New ComplexDouble((numberOfSamples) - 1) {}
        Dim i As Integer = 0

        While i < numberOfSamples - 1
            complexData(i).Real = amplitude * Math.Sin((f1 * i))
            complexData(i).Imaginary = amplitude * Math.Sin((f2 * i))
            i = i + 1
        End While
        complexData((numberOfSamples - 1)) = complexData(0)

        Return complexData
    End Function 'GenerateDefaultData


End Class
