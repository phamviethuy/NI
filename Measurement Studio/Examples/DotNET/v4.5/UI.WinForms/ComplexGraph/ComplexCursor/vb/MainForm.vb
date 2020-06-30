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
    Private WithEvents changeImaginaryPositionLabel As System.Windows.Forms.Label
    Private WithEvents changeRealPositionLabel As System.Windows.Forms.Label
    Private WithEvents setPositionButton As System.Windows.Forms.Button
    Private WithEvents cursorFreeLabel As System.Windows.Forms.Label
    Private WithEvents cursorModeSwitch As NationalInstruments.UI.WindowsForms.Switch
    Private WithEvents realAxis As NationalInstruments.UI.ComplexXAxis
    Private WithEvents plot As NationalInstruments.UI.ComplexPlot
    Private WithEvents imaginaryAxis As NationalInstruments.UI.ComplexYAxis
    Private WithEvents changeCursorIndexGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents changeCursorIndexLabel As System.Windows.Forms.Label
    Private WithEvents cursorMoveNextButton As System.Windows.Forms.Button
    Private WithEvents cursorMoveBackButton As System.Windows.Forms.Button
    Private WithEvents cursorLockedLabel As System.Windows.Forms.Label
    Private WithEvents dataCursor As NationalInstruments.UI.ComplexCursor
    Private WithEvents changeRealPositionNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents changeImaginaryPositionNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents changeCursorIndexNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents sampleComplexGraph As NationalInstruments.UI.WindowsForms.ComplexGraph

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.changeCursorPositionGroupBox = New System.Windows.Forms.GroupBox
        Me.changeImaginaryPositionLabel = New System.Windows.Forms.Label
        Me.changeRealPositionLabel = New System.Windows.Forms.Label
        Me.setPositionButton = New System.Windows.Forms.Button
        Me.changeRealPositionNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.changeImaginaryPositionNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.cursorFreeLabel = New System.Windows.Forms.Label
        Me.cursorModeSwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.realAxis = New NationalInstruments.UI.ComplexXAxis
        Me.plot = New NationalInstruments.UI.ComplexPlot
        Me.imaginaryAxis = New NationalInstruments.UI.ComplexYAxis
        Me.changeCursorIndexGroupBox = New System.Windows.Forms.GroupBox
        Me.changeCursorIndexLabel = New System.Windows.Forms.Label
        Me.cursorMoveNextButton = New System.Windows.Forms.Button
        Me.cursorMoveBackButton = New System.Windows.Forms.Button
        Me.changeCursorIndexNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.sampleComplexGraph = New NationalInstruments.UI.WindowsForms.ComplexGraph
        Me.dataCursor = New NationalInstruments.UI.ComplexCursor
        Me.cursorLockedLabel = New System.Windows.Forms.Label
        Me.changeCursorPositionGroupBox.SuspendLayout()
        CType(Me.changeRealPositionNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.changeImaginaryPositionNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cursorModeSwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.changeCursorIndexGroupBox.SuspendLayout()
        CType(Me.changeCursorIndexNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'changeCursorPositionGroupBox
        '
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeImaginaryPositionLabel)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeRealPositionLabel)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.setPositionButton)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeRealPositionNumericEdit)
        Me.changeCursorPositionGroupBox.Controls.Add(Me.changeImaginaryPositionNumericEdit)
        Me.changeCursorPositionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.changeCursorPositionGroupBox.Location = New System.Drawing.Point(105, 256)
        Me.changeCursorPositionGroupBox.Name = "changeCursorPositionGroupBox"
        Me.changeCursorPositionGroupBox.Size = New System.Drawing.Size(312, 88)
        Me.changeCursorPositionGroupBox.TabIndex = 10
        Me.changeCursorPositionGroupBox.TabStop = False
        Me.changeCursorPositionGroupBox.Text = "Change Cursor Position"
        '
        'changeImaginaryPositionLabel
        '
        Me.changeImaginaryPositionLabel.Location = New System.Drawing.Point(16, 56)
        Me.changeImaginaryPositionLabel.Name = "changeImaginaryPositionLabel"
        Me.changeImaginaryPositionLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeImaginaryPositionLabel.TabIndex = 3
        Me.changeImaginaryPositionLabel.Text = "Imaginary:"
        Me.changeImaginaryPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'changeRealPositionLabel
        '
        Me.changeRealPositionLabel.Location = New System.Drawing.Point(16, 24)
        Me.changeRealPositionLabel.Name = "changeRealPositionLabel"
        Me.changeRealPositionLabel.Size = New System.Drawing.Size(64, 23)
        Me.changeRealPositionLabel.TabIndex = 2
        Me.changeRealPositionLabel.Text = "Real :"
        Me.changeRealPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'changeRealPositionNumericEdit
        '
        Me.changeRealPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.changeRealPositionNumericEdit.Location = New System.Drawing.Point(88, 24)
        Me.changeRealPositionNumericEdit.Name = "changeRealPositionNumericEdit"
        Me.changeRealPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeRealPositionNumericEdit.Range = New NationalInstruments.UI.Range(-10, 10)
        Me.changeRealPositionNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeRealPositionNumericEdit.TabIndex = 0
        '
        'changeImaginaryPositionNumericEdit
        '
        Me.changeImaginaryPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.changeImaginaryPositionNumericEdit.Location = New System.Drawing.Point(88, 56)
        Me.changeImaginaryPositionNumericEdit.Name = "changeImaginaryPositionNumericEdit"
        Me.changeImaginaryPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.changeImaginaryPositionNumericEdit.Range = New NationalInstruments.UI.Range(-10, 10)
        Me.changeImaginaryPositionNumericEdit.Size = New System.Drawing.Size(72, 20)
        Me.changeImaginaryPositionNumericEdit.TabIndex = 1
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
        Me.cursorModeSwitch.TabIndex = 1
        Me.cursorModeSwitch.Value = True
        '
        'plot
        '
        Me.plot.XAxis = Me.realAxis
        Me.plot.YAxis = Me.imaginaryAxis
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
        'sampleComplexGraph
        '
        Me.sampleComplexGraph.Caption = "Generated Data"
        Me.sampleComplexGraph.Cursors.AddRange(New NationalInstruments.UI.ComplexCursor() {Me.dataCursor})
        Me.sampleComplexGraph.Location = New System.Drawing.Point(9, 8)
        Me.sampleComplexGraph.Name = "sampleComplexGraph"
        Me.sampleComplexGraph.Plots.AddRange(New NationalInstruments.UI.ComplexPlot() {Me.plot})
        Me.sampleComplexGraph.Size = New System.Drawing.Size(408, 240)
        Me.sampleComplexGraph.TabIndex = 0
        Me.sampleComplexGraph.XAxes.AddRange(New NationalInstruments.UI.ComplexXAxis() {Me.realAxis})
        Me.sampleComplexGraph.YAxes.AddRange(New NationalInstruments.UI.ComplexYAxis() {Me.imaginaryAxis})
        '
        'dataCursor
        '
        Me.dataCursor.Color = System.Drawing.Color.Crimson
        Me.dataCursor.LabelVisible = True
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
        Me.Controls.Add(Me.sampleComplexGraph)
        Me.Controls.Add(Me.changeCursorIndexGroupBox)
        Me.Controls.Add(Me.cursorLockedLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cursors"
        Me.changeCursorPositionGroupBox.ResumeLayout(False)
        CType(Me.changeRealPositionNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.changeImaginaryPositionNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cursorModeSwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.changeCursorIndexGroupBox.ResumeLayout(False)
        CType(Me.changeCursorIndexNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleComplexGraph, System.ComponentModel.ISupportInitialize).EndInit()
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

        Dim data(99) As ComplexDouble
        For i As Integer = 0 To 99
            data(i).Real = i / 100.0 * 20.0 - 10.0
            data(i).Imaginary = 10.0 * Math.Sin(i / Math.PI)
        Next

        plot.PlotComplex(data)
    End Sub

    Private Sub OnDataCursorAfterMove(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterMoveComplexCursorEventArgs) Handles dataCursor.AfterMove
        changeRealPositionNumericEdit.Value = dataCursor.Position.Real
        changeImaginaryPositionNumericEdit.Value = dataCursor.Position.Imaginary
        changeCursorIndexNumericEdit.Value = dataCursor.GetCurrentIndex()
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
        Dim xPosition As Double = changeRealPositionNumericEdit.Value
        Dim yPosition As Double = changeImaginaryPositionNumericEdit.Value
        dataCursor.MoveCursor(New ComplexDouble(xPosition, yPosition))
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
