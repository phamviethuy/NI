Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region "Windows Form Designer generated code"

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    Private components As System.ComponentModel.IContainer

    Private WithEvents changeCursorPositionGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents changeYPositionLabel As System.Windows.Forms.Label
    Private WithEvents changeXPositionLabel As System.Windows.Forms.Label
    Private WithEvents setPositionButton As System.Windows.Forms.Button
    Private WithEvents cursorFreeLabel As System.Windows.Forms.Label
    Private WithEvents cursorModeSwitch As NationalInstruments.UI.WindowsForms.Switch
    Private WithEvents xAxis As NationalInstruments.UI.XAxis
    Private WithEvents plot As NationalInstruments.UI.WaveformPlot
    Private WithEvents yAxis As NationalInstruments.UI.YAxis
    Private WithEvents changeCursorIndexGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents changeCursorIndexLabel As System.Windows.Forms.Label
    Private WithEvents cursorMoveNextButton As System.Windows.Forms.Button
    Private WithEvents cursorMoveBackButton As System.Windows.Forms.Button
    Private WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Private WithEvents cursorLockedLabel As System.Windows.Forms.Label
    Private WithEvents dataCursor As NationalInstruments.UI.XYCursor
    Private WithEvents changeXPositionNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents changeYPositionNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents changeCursorIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.changeCursorPositionGroupBox = New System.Windows.Forms.GroupBox
        Me.changeYPositionLabel = New System.Windows.Forms.Label
        Me.changeXPositionLabel = New System.Windows.Forms.Label
        Me.setPositionButton = New System.Windows.Forms.Button
        Me.changeXPositionNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.changeYPositionNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.cursorFreeLabel = New System.Windows.Forms.Label
        Me.cursorModeSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.plot = New NationalInstruments.UI.WaveformPlot
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.changeCursorIndexGroupBox = New System.Windows.Forms.GroupBox
        Me.changeCursorIndexLabel = New System.Windows.Forms.Label
        Me.cursorMoveNextButton = New System.Windows.Forms.Button
        Me.cursorMoveBackButton = New System.Windows.Forms.Button
        Me.changeCursorIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.dataCursor = New NationalInstruments.UI.XYCursor
        Me.cursorLockedLabel = New System.Windows.Forms.Label
        Me.changeCursorPositionGroupBox.SuspendLayout()
        CType(Me.changeXPositionNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeYPositionNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cursorModeSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.changeCursorIndexGroupBox.SuspendLayout()
        CType(Me.changeCursorIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'changeCursorPositionGroupBox
        '
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeYPositionLabel)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeXPositionLabel)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.setPositionButton)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeXPositionNumericEdit)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeYPositionNumericEdit)
        Me.changeCursorPositionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.changeCursorPositionGroupBox.Location = New System.Drawing.Point(105, 256)
        Me.changeCursorPositionGroupBox.Name = "changeCursorPositionGroupBox"
        Me.changeCursorPositionGroupBox.Size = New System.Drawing.Size(312, 88)
        Me.changeCursorPositionGroupBox.TabIndex = 10
        Me.changeCursorPositionGroupBox.TabStop = False
        Me.changeCursorPositionGroupBox.Text = "Change Cursor Position"
        '
        'changeYPositionLabel
        '
        Me.changeYPositionLabel.Location = New System.Drawing.Point(16, 56)
        Me.changeYPositionLabel.Name = "changeYPositionLabel"
        Me.changeYPositionLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeYPositionLabel.TabIndex = 3
        Me.changeYPositionLabel.Text = "Y Position:"
        Me.changeYPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'changeXPositionLabel
        '
        Me.changeXPositionLabel.Location = New System.Drawing.Point(16, 24)
        Me.changeXPositionLabel.Name = "changeXPositionLabel"
        Me.changeXPositionLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeXPositionLabel.TabIndex = 2
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
        Me.changeXPositionNumericEdit.Range = New NationalInstruments.UI.Range(0, 100)
        Me.changeXPositionNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeXPositionNumericEdit.TabIndex = 0
        '
        'changeYPositionNumericEdit
        '
        Me.changeYPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.changeYPositionNumericEdit.Location = New System.Drawing.Point(88, 56)
        Me.changeYPositionNumericEdit.Name = "changeYPositionNumericEdit"
        Me.changeYPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeYPositionNumericEdit.Range = New NationalInstruments.UI.Range(-10, 10)
        Me.changeYPositionNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeYPositionNumericEdit.TabIndex = 1
        '
        'cursorFreeLabel
        '
        Me.cursorFreeLabel.Location = New System.Drawing.Point(17, 392)
        Me.cursorFreeLabel.Name = "cursorFreeLabel"
        Me.cursorFreeLabel.Size = New System.Drawing.Size(80, 23)
        Me.cursorFreeLabel.TabIndex = 9
        Me.cursorFreeLabel.Text = "Cursor Free"
        Me.cursorFreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cursorModeSwitch
        '
        Me.cursorModeSwitch.Location = New System.Drawing.Point(16, 280)
        Me.cursorModeSwitch.Name = "cursorModeSwitch"
        Me.cursorModeSwitch.Size = New System.Drawing.Size(80, 112)
        Me.cursorModeSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.cursorModeSwitch.TabIndex = 1
        Me.cursorModeSwitch.Value = True
        '
        'plot
        '
        Me.plot.XAxis = Me.xAxis
        Me.plot.YAxis = Me.yAxis
        '
        'changeCursorIndexGroupBox
        '
        Me.changeCursorIndexGroupBox.Controls.Add(Me.changeCursorIndexLabel)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.cursorMoveNextButton)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.cursorMoveBackButton)
        Me.changeCursorIndexGroupBox.Controls.Add(Me.changeCursorIndexNumericEdit)
        Me.changeCursorIndexGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.changeCursorIndexGroupBox.Location = New System.Drawing.Point(105, 352)
        Me.changeCursorIndexGroupBox.Name = "changeCursorIndexGroupBox"
        Me.changeCursorIndexGroupBox.Size = New System.Drawing.Size(312, 64)
        Me.changeCursorIndexGroupBox.TabIndex = 11
        Me.changeCursorIndexGroupBox.TabStop = False
        Me.changeCursorIndexGroupBox.Text = "Change Cursor Index"
        '
        'changeCursorIndexLabel
        '
        Me.changeCursorIndexLabel.Location = New System.Drawing.Point(16, 24)
        Me.changeCursorIndexLabel.Name = "changeCursorIndexLabel"
        Me.changeCursorIndexLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeCursorIndexLabel.TabIndex = 2
        Me.changeCursorIndexLabel.Text = "Index:"
        Me.changeCursorIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cursorMoveNextButton
        '
        Me.cursorMoveNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cursorMoveNextButton.Location = New System.Drawing.Point(240, 24)
        Me.cursorMoveNextButton.Name = "cursorMoveNextButton"
        Me.cursorMoveNextButton.Size = New System.Drawing.Size(64, 23)
        Me.cursorMoveNextButton.TabIndex = 2
        Me.cursorMoveNextButton.Text = "Next >>"
        '
        'cursorMoveBackButton
        '
        Me.cursorMoveBackButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cursorMoveBackButton.Location = New System.Drawing.Point(168, 24)
        Me.cursorMoveBackButton.Name = "cursorMoveBackButton"
        Me.cursorMoveBackButton.Size = New System.Drawing.Size(64, 23)
        Me.cursorMoveBackButton.TabIndex = 1
        Me.cursorMoveBackButton.Text = "<< Back"
        '
        'changeCursorIndexNumericEdit
        '
        Me.changeCursorIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.changeCursorIndexNumericEdit.Location = New System.Drawing.Point(88, 24)
        Me.changeCursorIndexNumericEdit.Name = "changeCursorIndexNumericEdit"
        Me.changeCursorIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeCursorIndexNumericEdit.Range = New NationalInstruments.UI.Range(0, 99)
        Me.changeCursorIndexNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeCursorIndexNumericEdit.TabIndex = 0
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Caption = "Generated Data"
        Me.sampleWaveformGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.dataCursor})
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(9, 8)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.plot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(408, 240)
        Me.sampleWaveformGraph.TabIndex = 0
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'dataCursor
        '
        Me.dataCursor.Plot = Me.plot
        '
        'cursorLockedLabel
        '
        Me.cursorLockedLabel.Location = New System.Drawing.Point(17, 256)
        Me.cursorLockedLabel.Name = "cursorLockedLabel"
        Me.cursorLockedLabel.Size = New System.Drawing.Size(80, 23)
        Me.cursorLockedLabel.TabIndex = 8
        Me.cursorLockedLabel.Text = "Cursor Locked"
        Me.cursorLockedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(426, 424)
        Me.Controls.Add(Me.changeCursorPositionGroupBox)
        Me.Controls.Add(Me.cursorFreeLabel)
        Me.Controls.Add(Me.cursorModeSwitch)
        Me.Controls.Add(Me.changeCursorIndexGroupBox)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Controls.Add(Me.cursorLockedLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cursors"
        Me.changeCursorPositionGroupBox.ResumeLayout(False)
        CType(Me.changeXPositionNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeYPositionNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cursorModeSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.changeCursorIndexGroupBox.ResumeLayout(False)
        CType(Me.changeCursorIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataCursor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)

        Dim data(99) As Double
        For i As Integer = 0 To 99
            data(i) = 10.0 * Math.Sin(i / Math.PI)
        Next

        plot.PlotY(data)
    End Sub

    Private Sub OnDataCursorAfterMove(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterMoveXYCursorEventArgs) Handles dataCursor.AfterMove
        changeXPositionNumericEdit.Value = CDec(dataCursor.XPosition)
        changeYPositionNumericEdit.Value = CDec(dataCursor.YPosition)
        changeCursorIndexNumericEdit.Value = CDec(dataCursor.GetCurrentIndex())
    End Sub

    Private Sub OnCursorModeStateChanged(ByVal sender As Object, ByVal e As ActionEventArgs) Handles cursorModeSwitch.StateChanged
        Dim indexControlsEnabled As System.Boolean = False
        If cursorModeSwitch.Value Then
            dataCursor.SnapMode = CursorSnapMode.ToPlot
            indexControlsEnabled = True
        Else
            dataCursor.SnapMode = CursorSnapMode.Floating
            indexControlsEnabled = False
        End If

        changeCursorIndexNumericEdit.Enabled = indexControlsEnabled
        cursorMoveBackButton.Enabled = indexControlsEnabled
        cursorMoveNextButton.Enabled = indexControlsEnabled
    End Sub

    Private Sub OnSetPositionClick(ByVal sender As Object, ByVal e As EventArgs) Handles setPositionButton.Click
        Dim xPosition As Double = CDbl(changeXPositionNumericEdit.Value)
        Dim yPosition As Double = CDbl(changeYPositionNumericEdit.Value)
        dataCursor.MoveCursor(xPosition, yPosition)
    End Sub

    Private Sub OnChangeCursorIndexValueChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles changeCursorIndexNumericEdit.AfterChangeValue
        dataCursor.MoveCursor(CInt(changeCursorIndexNumericEdit.Value))
    End Sub

    Private Sub OnCursorMoveBackClick(ByVal sender As Object, ByVal e As EventArgs) Handles cursorMoveBackButton.Click
        dataCursor.MovePrevious()
    End Sub

    Private Sub OnCursorMoveNextClick(ByVal sender As Object, ByVal e As EventArgs) Handles cursorMoveNextButton.Click
        dataCursor.MoveNext()
    End Sub
End Class
