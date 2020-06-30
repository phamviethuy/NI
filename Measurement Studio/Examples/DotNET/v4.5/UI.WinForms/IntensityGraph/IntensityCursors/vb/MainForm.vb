Public Class MainForm
    Inherits System.Windows.Forms.Form
    Friend WithEvents sampleIntensityGraph As NationalInstruments.UI.WindowsForms.IntensityGraph
    Friend WithEvents xAxis As NationalInstruments.UI.IntensityXAxis
    Friend WithEvents yAxis As NationalInstruments.UI.IntensityYAxis
    Friend WithEvents plot As NationalInstruments.UI.IntensityPlot
    Friend WithEvents colorScale As NationalInstruments.UI.ColorScale
    Friend WithEvents cursorModeSwitch As NationalInstruments.UI.WindowsForms.Switch
    Friend WithEvents cursorLockedLabel As System.Windows.Forms.Label
    Friend WithEvents cursorFreeLabel As System.Windows.Forms.Label
    Friend WithEvents intensityCursor As NationalInstruments.UI.IntensityCursor
    Friend WithEvents changeCursorPositionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents changeXPositionLabel As System.Windows.Forms.Label
    Friend WithEvents changeYPositionLabel As System.Windows.Forms.Label
    Friend WithEvents setPositionButton As System.Windows.Forms.Button
    Friend WithEvents changeCursorIndexGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents cursorMoveBackXButton As System.Windows.Forms.Button
    Friend WithEvents cursorMoveNextXButton As System.Windows.Forms.Button
    Friend WithEvents changeCursorXIndexLabel As System.Windows.Forms.Label
    Friend WithEvents changeXPositionNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents changeYPositionNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents changeCursorXIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents changeCursorYIndexLabel As Label
    Friend WithEvents cursorMoveNextYButton As Button
    Friend WithEvents cursorMoveBackYButton As Button
    Friend WithEvents changeCursorYIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents pixelInterpolationCheckBox As CheckBox
    Private components As System.ComponentModel.IContainer = Nothing

    Public Sub New()
        InitializeComponent()

        pixelInterpolationCheckBox.Checked = plot.PixelInterpolation
        plot.SmoothUpdates = True ' Setting SmoothUpdates to true improves Cursor Interaction.
        InitializeColorScale()
        PlotIntensityData()
    End Sub

#Region "Windows Form Designer generated code"

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If

        MyBase.Dispose(disposing)
    End Sub

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.sampleIntensityGraph = New NationalInstruments.UI.WindowsForms.IntensityGraph()
        Me.colorScale = New NationalInstruments.UI.ColorScale()
        Me.intensityCursor = New NationalInstruments.UI.IntensityCursor()
        Me.plot = New NationalInstruments.UI.IntensityPlot()
        Me.xAxis = New NationalInstruments.UI.IntensityXAxis()
        Me.yAxis = New NationalInstruments.UI.IntensityYAxis()
        Me.cursorModeSwitch = New NationalInstruments.UI.WindowsForms.Switch()
        Me.cursorLockedLabel = New System.Windows.Forms.Label()
        Me.cursorFreeLabel = New System.Windows.Forms.Label()
        Me.changeCursorPositionGroupBox = New System.Windows.Forms.GroupBox()
        Me.changeYPositionLabel = New System.Windows.Forms.Label()
        Me.changeXPositionLabel = New System.Windows.Forms.Label()
        Me.setPositionButton = New System.Windows.Forms.Button()
        Me.changeXPositionNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.changeYPositionNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.changeCursorIndexGroupBox = New System.Windows.Forms.GroupBox()
        Me.changeCursorYIndexLabel = New System.Windows.Forms.Label()
        Me.changeCursorXIndexLabel = New System.Windows.Forms.Label()
        Me.cursorMoveNextYButton = New System.Windows.Forms.Button()
        Me.cursorMoveNextXButton = New System.Windows.Forms.Button()
        Me.cursorMoveBackYButton = New System.Windows.Forms.Button()
        Me.changeCursorYIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.cursorMoveBackXButton = New System.Windows.Forms.Button()
        Me.changeCursorXIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.pixelInterpolationCheckBox = New System.Windows.Forms.CheckBox()
        CType(Me.sampleIntensityGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.intensityCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cursorModeSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.changeCursorPositionGroupBox.SuspendLayout()
        CType(Me.changeXPositionNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeYPositionNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.changeCursorIndexGroupBox.SuspendLayout()
        CType(Me.changeCursorYIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeCursorXIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sampleIntensityGraph
        '
        Me.sampleIntensityGraph.CanShowFocus = True
        Me.sampleIntensityGraph.Caption = "Intensity Graph"
        Me.sampleIntensityGraph.ColorScales.AddRange(New NationalInstruments.UI.ColorScale() {Me.colorScale})
        Me.sampleIntensityGraph.Cursors.AddRange(New NationalInstruments.UI.IntensityCursor() {Me.intensityCursor})
        Me.sampleIntensityGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleIntensityGraph.Name = "sampleIntensityGraph"
        Me.sampleIntensityGraph.Plots.AddRange(New NationalInstruments.UI.IntensityPlot() {Me.plot})
        Me.sampleIntensityGraph.Size = New System.Drawing.Size(408, 240)
        Me.sampleIntensityGraph.TabIndex = 0
        Me.sampleIntensityGraph.XAxes.AddRange(New NationalInstruments.UI.IntensityXAxis() {Me.xAxis})
        Me.sampleIntensityGraph.YAxes.AddRange(New NationalInstruments.UI.IntensityYAxis() {Me.yAxis})
        '
        'intensityCursor
        '
        Me.intensityCursor.LabelVisible = True
        Me.intensityCursor.Plot = Me.plot
        '
        'plot
        '
        Me.plot.ColorScale = Me.colorScale
        Me.plot.XAxis = Me.xAxis
        Me.plot.YAxis = Me.yAxis
        '
        'cursorModeSwitch
        '
        Me.cursorModeSwitch.CanShowFocus = True
        Me.cursorModeSwitch.Location = New System.Drawing.Point(16, 301)
        Me.cursorModeSwitch.Name = "cursorModeSwitch"
        Me.cursorModeSwitch.Size = New System.Drawing.Size(80, 109)
        Me.cursorModeSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.cursorModeSwitch.TabIndex = 2
        Me.cursorModeSwitch.Value = True
        '
        'cursorLockedLabel
        '
        Me.cursorLockedLabel.Location = New System.Drawing.Point(16, 277)
        Me.cursorLockedLabel.Name = "cursorLockedLabel"
        Me.cursorLockedLabel.Size = New System.Drawing.Size(80, 23)
        Me.cursorLockedLabel.TabIndex = 2
        Me.cursorLockedLabel.Text = "Cursor Locked"
        Me.cursorLockedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cursorFreeLabel
        '
        Me.cursorFreeLabel.Location = New System.Drawing.Point(16, 413)
        Me.cursorFreeLabel.Name = "cursorFreeLabel"
        Me.cursorFreeLabel.Size = New System.Drawing.Size(80, 23)
        Me.cursorFreeLabel.TabIndex = 3
        Me.cursorFreeLabel.Text = "Cursor Free"
        Me.cursorFreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'changeCursorPositionGroupBox
        '
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeYPositionLabel)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeXPositionLabel)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.setPositionButton)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeXPositionNumericEdit)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeYPositionNumericEdit)
        Me.changeCursorPositionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.changeCursorPositionGroupBox.Location = New System.Drawing.Point(104, 277)
        Me.changeCursorPositionGroupBox.Name = "changeCursorPositionGroupBox"
        Me.changeCursorPositionGroupBox.Size = New System.Drawing.Size(312, 88)
        Me.changeCursorPositionGroupBox.TabIndex = 4
        Me.changeCursorPositionGroupBox.TabStop = False
        Me.changeCursorPositionGroupBox.Text = "Change Cursor Position"
        '
        'changeYPositionLabel
        '
        Me.changeYPositionLabel.Location = New System.Drawing.Point(16, 56)
        Me.changeYPositionLabel.Name = "changeYPositionLabel"
        Me.changeYPositionLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeYPositionLabel.TabIndex = 2
        Me.changeYPositionLabel.Text = "Y Position:"
        Me.changeYPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'changeXPositionLabel
        '
        Me.changeXPositionLabel.Location = New System.Drawing.Point(16, 24)
        Me.changeXPositionLabel.Name = "changeXPositionLabel"
        Me.changeXPositionLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeXPositionLabel.TabIndex = 0
        Me.changeXPositionLabel.Text = "X Position:"
        Me.changeXPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'setPositionButton
        '
        Me.setPositionButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.setPositionButton.Location = New System.Drawing.Point(168, 40)
        Me.setPositionButton.Name = "setPositionButton"
        Me.setPositionButton.Size = New System.Drawing.Size(136, 23)
        Me.setPositionButton.TabIndex = 2
        Me.setPositionButton.Text = "Set Position"
        '
        'changeXPositionNumericEdit
        '
        Me.changeXPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.changeXPositionNumericEdit.Location = New System.Drawing.Point(88, 24)
        Me.changeXPositionNumericEdit.Name = "changeXPositionNumericEdit"
        Me.changeXPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeXPositionNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeXPositionNumericEdit.TabIndex = 0
        '
        'changeYPositionNumericEdit
        '
        Me.changeYPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.changeYPositionNumericEdit.Location = New System.Drawing.Point(88, 56)
        Me.changeYPositionNumericEdit.Name = "changeYPositionNumericEdit"
        Me.changeYPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeYPositionNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeYPositionNumericEdit.TabIndex = 1
        '
        'changeCursorIndexGroupBox
        '
        Me.changeCursorIndexGroupBox.Controls.Add(Me.changeCursorYIndexLabel)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.changeCursorXIndexLabel)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.cursorMoveNextYButton)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.cursorMoveNextXButton)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.cursorMoveBackYButton)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.changeCursorYIndexNumericEdit)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.cursorMoveBackXButton)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.changeCursorXIndexNumericEdit)
        Me.changeCursorIndexGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.changeCursorIndexGroupBox.Location = New System.Drawing.Point(104, 373)
        Me.changeCursorIndexGroupBox.Name = "changeCursorIndexGroupBox"
        Me.changeCursorIndexGroupBox.Size = New System.Drawing.Size(312, 88)
        Me.changeCursorIndexGroupBox.TabIndex = 5
        Me.changeCursorIndexGroupBox.TabStop = False
        Me.changeCursorIndexGroupBox.Text = "Change Cursor Indexes"
        '
        'changeCursorYIndexLabel
        '
        Me.changeCursorYIndexLabel.Location = New System.Drawing.Point(16, 57)
        Me.changeCursorYIndexLabel.Name = "changeCursorYIndexLabel"
        Me.changeCursorYIndexLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeCursorYIndexLabel.TabIndex = 2
        Me.changeCursorYIndexLabel.Text = "Y Index:"
        Me.changeCursorYIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'changeCursorXIndexLabel
        '
        Me.changeCursorXIndexLabel.Location = New System.Drawing.Point(16, 24)
        Me.changeCursorXIndexLabel.Name = "changeCursorXIndexLabel"
        Me.changeCursorXIndexLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeCursorXIndexLabel.TabIndex = 2
        Me.changeCursorXIndexLabel.Text = "X Index:"
        Me.changeCursorXIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cursorMoveNextYButton
        '
        Me.cursorMoveNextYButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cursorMoveNextYButton.Location = New System.Drawing.Point(240, 57)
        Me.cursorMoveNextYButton.Name = "cursorMoveNextYButton"
        Me.cursorMoveNextYButton.Size = New System.Drawing.Size(64, 23)
        Me.cursorMoveNextYButton.TabIndex = 5
        Me.cursorMoveNextYButton.Text = "Next >>"
        '
        'cursorMoveNextXButton
        '
        Me.cursorMoveNextXButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cursorMoveNextXButton.Location = New System.Drawing.Point(240, 24)
        Me.cursorMoveNextXButton.Name = "cursorMoveNextXButton"
        Me.cursorMoveNextXButton.Size = New System.Drawing.Size(64, 23)
        Me.cursorMoveNextXButton.TabIndex = 2
        Me.cursorMoveNextXButton.Text = "Next >>"
        '
        'cursorMoveBackYButton
        '
        Me.cursorMoveBackYButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cursorMoveBackYButton.Location = New System.Drawing.Point(168, 57)
        Me.cursorMoveBackYButton.Name = "cursorMoveBackYButton"
        Me.cursorMoveBackYButton.Size = New System.Drawing.Size(64, 23)
        Me.cursorMoveBackYButton.TabIndex = 4
        Me.cursorMoveBackYButton.Text = "<< Back"
        '
        'changeCursorYIndexNumericEdit
        '
        Me.changeCursorYIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.changeCursorYIndexNumericEdit.Location = New System.Drawing.Point(88, 58)
        Me.changeCursorYIndexNumericEdit.Name = "changeCursorYIndexNumericEdit"
        Me.changeCursorYIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeCursorYIndexNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeCursorYIndexNumericEdit.TabIndex = 3
        Me.changeCursorYIndexNumericEdit.Value = 1.0R
        '
        'cursorMoveBackXButton
        '
        Me.cursorMoveBackXButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cursorMoveBackXButton.Location = New System.Drawing.Point(168, 24)
        Me.cursorMoveBackXButton.Name = "cursorMoveBackXButton"
        Me.cursorMoveBackXButton.Size = New System.Drawing.Size(64, 23)
        Me.cursorMoveBackXButton.TabIndex = 1
        Me.cursorMoveBackXButton.Text = "<< Back"
        '
        'changeCursorXIndexNumericEdit
        '
        Me.changeCursorXIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.changeCursorXIndexNumericEdit.Location = New System.Drawing.Point(88, 25)
        Me.changeCursorXIndexNumericEdit.Name = "changeCursorXIndexNumericEdit"
        Me.changeCursorXIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeCursorXIndexNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeCursorXIndexNumericEdit.TabIndex = 0
        Me.changeCursorXIndexNumericEdit.Value = 1.0R
        '
        'pixelInterpolationCheckBox
        '
        Me.pixelInterpolationCheckBox.AutoSize = True
        Me.pixelInterpolationCheckBox.Location = New System.Drawing.Point(307, 254)
        Me.pixelInterpolationCheckBox.Name = "pixelInterpolationCheckBox"
        Me.pixelInterpolationCheckBox.Size = New System.Drawing.Size(109, 17)
        Me.pixelInterpolationCheckBox.TabIndex = 1
        Me.pixelInterpolationCheckBox.Text = "Pixel Interpolation"
        Me.pixelInterpolationCheckBox.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(426, 467)
        Me.Controls.Add(Me.pixelInterpolationCheckBox)
        Me.Controls.Add(Me.changeCursorIndexGroupBox)
        Me.Controls.Add(Me.changeCursorPositionGroupBox)
        Me.Controls.Add(Me.cursorFreeLabel)
        Me.Controls.Add(Me.cursorLockedLabel)
        Me.Controls.Add(Me.cursorModeSwitch)
        Me.Controls.Add(Me.sampleIntensityGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intensity Cursors"
        CType(Me.sampleIntensityGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.intensityCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cursorModeSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.changeCursorPositionGroupBox.ResumeLayout(False)
        CType(Me.changeXPositionNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeYPositionNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.changeCursorIndexGroupBox.ResumeLayout(False)
        CType(Me.changeCursorYIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeCursorXIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
#End Region

    Private Sub InitializeColorScale()
        ' Initialize the ColorScale corresponding to VIBGYOR
        colorScale.Range = New NationalInstruments.UI.Range(0, 6)
        colorScale.HighColor = Color.Violet
        colorScale.ColorMap.Add(5, Color.Indigo)
        colorScale.ColorMap.Add(4, Color.Blue)
        colorScale.ColorMap.Add(3, Color.Green)
        colorScale.ColorMap.Add(2, Color.Yellow)
        colorScale.ColorMap.Add(1, Color.Orange)
        colorScale.LowColor = Color.Red
    End Sub

    Private Sub PlotIntensityData()
        ' Generate Data
        Dim numPoints As Integer = 21
        Dim zData As Double(,) = New Double(numPoints - 1, numPoints - 1) {}
        For i As Integer = 0 To numPoints - 1
            For j As Integer = 0 To numPoints - 1
                zData(i, j) = i * i + j * j
            Next
        Next

        ' Scale the colorscale depending on the data generated.
        colorScale.ScaleColorScale(New NationalInstruments.UI.Range(0, zData(numPoints - 1, numPoints - 1)))

        ' Plot the Data.
        plot.Plot(zData)
    End Sub

    Private Sub OnPixelInterpolationCheckBoxCheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles pixelInterpolationCheckBox.CheckedChanged
        plot.PixelInterpolation = pixelInterpolationCheckBox.Checked
    End Sub

    Private Sub OnCursorAfterMove(ByVal sender As Object, ByVal e As NationalInstruments.UI.AfterMoveIntensityCursorEventArgs) Handles intensityCursor.AfterMove
        changeXPositionNumericEdit.Value = intensityCursor.XPosition
        changeYPositionNumericEdit.Value = intensityCursor.YPosition
        Dim xIndex As Integer, yIndex As Integer
        intensityCursor.GetCurrentIndexes(xIndex, yIndex)
        changeCursorXIndexNumericEdit.Value = xIndex
        changeCursorYIndexNumericEdit.Value = yIndex
    End Sub

    Private Sub OnCursorModeStateChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.ActionEventArgs) Handles cursorModeSwitch.StateChanged
        If cursorModeSwitch.Value Then
            intensityCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.ToPlot
        Else
            intensityCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating
        End If

        changeCursorIndexGroupBox.Enabled = cursorModeSwitch.Value
    End Sub

    Private Sub OnSetPositionClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles setPositionButton.Click
        Dim xPosition As Double = changeXPositionNumericEdit.Value
        Dim yPosition As Double = changeYPositionNumericEdit.Value
        intensityCursor.MoveCursor(xPosition, yPosition)
        changeXPositionNumericEdit.Value = intensityCursor.XPosition
        changeYPositionNumericEdit.Value = intensityCursor.YPosition
    End Sub

    Private Sub OnChangeCursorXIndexValueChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles changeCursorXIndexNumericEdit.BeforeChangeValue
        Try
            Dim currentXIndex As Integer, currentYIndex As Integer
            intensityCursor.GetCurrentIndexes(currentXIndex, currentYIndex)
            intensityCursor.MoveCursor(CInt(e.NewValue), currentYIndex)
        Catch
            e.Cancel = True
        End Try
    End Sub

    Private Sub OnChangeCursorYIndexValueChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.BeforeChangeNumericValueEventArgs) Handles changeCursorYIndexNumericEdit.BeforeChangeValue
        Try
            Dim currentXIndex As Integer, currentYIndex As Integer
            intensityCursor.GetCurrentIndexes(currentXIndex, currentYIndex)
            intensityCursor.MoveCursor(currentXIndex, CInt(e.NewValue))
        Catch
            e.Cancel = True
        End Try
    End Sub

    Private Sub OnCursorMoveBackXClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cursorMoveBackXButton.Click
        intensityCursor.MovePreviousX()
    End Sub

    Private Sub OnCursorMoveNextXClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cursorMoveNextXButton.Click
        intensityCursor.MoveNextX()
    End Sub

    Private Sub OnCursorMoveBackYClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cursorMoveBackYButton.Click
        intensityCursor.MovePreviousY()
    End Sub

    Private Sub OnCursorMoveNextYClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cursorMoveNextYButton.Click
        intensityCursor.MoveNextY()
    End Sub

End Class

