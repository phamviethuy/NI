<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TdmsReaderUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tdmsPropertyNamesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tdmsPropertiesDataGridView = New System.Windows.Forms.DataGridView
        Me.tmdsPropertyValuesColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tdmsFileAndDataSplitContainer = New System.Windows.Forms.SplitContainer
        Me.tdmsFileAndPropertiesSplitContainer = New System.Windows.Forms.SplitContainer
        Me.tdmsFileTreeView = New System.Windows.Forms.TreeView
        Me.tdmsDataTabControl = New System.Windows.Forms.TabControl
        Me.tdmsDataTabPage = New System.Windows.Forms.TabPage
        Me.tdmsDataGridView = New System.Windows.Forms.DataGridView
        Me.tdmsGraphTabPage = New System.Windows.Forms.TabPage
        Me.tdmsWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.tdmsWaveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.tdmsXAxis = New NationalInstruments.UI.XAxis
        Me.tdmsYAxis = New NationalInstruments.UI.YAxis
        Me.tdmsDigitalWaveformGraph = New NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
        Me.tdmsPropertiesLabel = New System.Windows.Forms.Label
        Me.tmdsFileLabel = New System.Windows.Forms.Label
        Me.loadValuesButton = New System.Windows.Forms.Button
        Me.tdmsDataIndexColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tdmsDataColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.tdmsPropertiesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tdmsFileAndDataSplitContainer.Panel1.SuspendLayout()
        Me.tdmsFileAndDataSplitContainer.Panel2.SuspendLayout()
        Me.tdmsFileAndDataSplitContainer.SuspendLayout()
        Me.tdmsFileAndPropertiesSplitContainer.Panel1.SuspendLayout()
        Me.tdmsFileAndPropertiesSplitContainer.Panel2.SuspendLayout()
        Me.tdmsFileAndPropertiesSplitContainer.SuspendLayout()
        Me.tdmsDataTabControl.SuspendLayout()
        Me.tdmsDataTabPage.SuspendLayout()
        CType(Me.tdmsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tdmsGraphTabPage.SuspendLayout()
        CType(Me.tdmsWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdmsDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdmsPropertyNamesColumn
        '
        Me.tdmsPropertyNamesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tdmsPropertyNamesColumn.HeaderText = "Name"
        Me.tdmsPropertyNamesColumn.Name = "tdmsPropertyNamesColumn"
        Me.tdmsPropertyNamesColumn.ReadOnly = True
        Me.tdmsPropertyNamesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tdmsPropertyNamesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tdmsPropertiesDataGridView
        '
        Me.tdmsPropertiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tdmsPropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tdmsPropertiesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tdmsPropertyNamesColumn, Me.tmdsPropertyValuesColumn})
        Me.tdmsPropertiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdmsPropertiesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.tdmsPropertiesDataGridView.Name = "tdmsPropertiesDataGridView"
        Me.tdmsPropertiesDataGridView.RowHeadersVisible = False
        Me.tdmsPropertiesDataGridView.Size = New System.Drawing.Size(263, 268)
        Me.tdmsPropertiesDataGridView.TabIndex = 0
        '
        'tmdsPropertyValuesColumn
        '
        Me.tmdsPropertyValuesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tmdsPropertyValuesColumn.HeaderText = "Value"
        Me.tmdsPropertyValuesColumn.Name = "tmdsPropertyValuesColumn"
        Me.tmdsPropertyValuesColumn.ReadOnly = True
        Me.tmdsPropertyValuesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tmdsPropertyValuesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'tdmsFileAndDataSplitContainer
        '
        Me.tdmsFileAndDataSplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tdmsFileAndDataSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.tdmsFileAndDataSplitContainer.Location = New System.Drawing.Point(0, 16)
        Me.tdmsFileAndDataSplitContainer.Name = "tdmsFileAndDataSplitContainer"
        Me.tdmsFileAndDataSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'tdmsFileAndDataSplitContainer.Panel1
        '
        Me.tdmsFileAndDataSplitContainer.Panel1.Controls.Add(Me.tdmsFileAndPropertiesSplitContainer)
        '
        'tdmsFileAndDataSplitContainer.Panel2
        '
        Me.tdmsFileAndDataSplitContainer.Panel2.Controls.Add(Me.tdmsDataTabControl)
        Me.tdmsFileAndDataSplitContainer.Size = New System.Drawing.Size(457, 617)
        Me.tdmsFileAndDataSplitContainer.SplitterDistance = 268
        Me.tdmsFileAndDataSplitContainer.TabIndex = 11
        '
        'tdmsFileAndPropertiesSplitContainer
        '
        Me.tdmsFileAndPropertiesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdmsFileAndPropertiesSplitContainer.Location = New System.Drawing.Point(0, 0)
        Me.tdmsFileAndPropertiesSplitContainer.Name = "tdmsFileAndPropertiesSplitContainer"
        '
        'tdmsFileAndPropertiesSplitContainer.Panel1
        '
        Me.tdmsFileAndPropertiesSplitContainer.Panel1.Controls.Add(Me.tdmsFileTreeView)
        '
        'tdmsFileAndPropertiesSplitContainer.Panel2
        '
        Me.tdmsFileAndPropertiesSplitContainer.Panel2.Controls.Add(Me.tdmsPropertiesDataGridView)
        Me.tdmsFileAndPropertiesSplitContainer.Size = New System.Drawing.Size(457, 268)
        Me.tdmsFileAndPropertiesSplitContainer.SplitterDistance = 190
        Me.tdmsFileAndPropertiesSplitContainer.TabIndex = 7
        '
        'tdmsFileTreeView
        '
        Me.tdmsFileTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdmsFileTreeView.Location = New System.Drawing.Point(0, 0)
        Me.tdmsFileTreeView.Name = "tdmsFileTreeView"
        Me.tdmsFileTreeView.Size = New System.Drawing.Size(190, 268)
        Me.tdmsFileTreeView.TabIndex = 0
        '
        'tdmsDataTabControl
        '
        Me.tdmsDataTabControl.Controls.Add(Me.tdmsDataTabPage)
        Me.tdmsDataTabControl.Controls.Add(Me.tdmsGraphTabPage)
        Me.tdmsDataTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdmsDataTabControl.Location = New System.Drawing.Point(0, 0)
        Me.tdmsDataTabControl.Name = "tdmsDataTabControl"
        Me.tdmsDataTabControl.SelectedIndex = 0
        Me.tdmsDataTabControl.Size = New System.Drawing.Size(457, 345)
        Me.tdmsDataTabControl.TabIndex = 1
        '
        'tdmsDataTabPage
        '
        Me.tdmsDataTabPage.Controls.Add(Me.tdmsDataGridView)
        Me.tdmsDataTabPage.Location = New System.Drawing.Point(4, 22)
        Me.tdmsDataTabPage.Name = "tdmsDataTabPage"
        Me.tdmsDataTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tdmsDataTabPage.Size = New System.Drawing.Size(449, 319)
        Me.tdmsDataTabPage.TabIndex = 0
        Me.tdmsDataTabPage.Text = "Data"
        Me.tdmsDataTabPage.UseVisualStyleBackColor = True
        '
        'tdmsDataGridView
        '
        Me.tdmsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tdmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tdmsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tdmsDataIndexColumn, Me.tdmsDataColumn})
        Me.tdmsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdmsDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.tdmsDataGridView.Name = "tdmsDataGridView"
        Me.tdmsDataGridView.ReadOnly = True
        Me.tdmsDataGridView.RowHeadersVisible = False
        Me.tdmsDataGridView.Size = New System.Drawing.Size(443, 313)
        Me.tdmsDataGridView.TabIndex = 0
        '
        'tdmsGraphTabPage
        '
        Me.tdmsGraphTabPage.Controls.Add(Me.tdmsWaveformGraph)
        Me.tdmsGraphTabPage.Controls.Add(Me.tdmsDigitalWaveformGraph)
        Me.tdmsGraphTabPage.Location = New System.Drawing.Point(4, 22)
        Me.tdmsGraphTabPage.Name = "tdmsGraphTabPage"
        Me.tdmsGraphTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.tdmsGraphTabPage.Size = New System.Drawing.Size(449, 319)
        Me.tdmsGraphTabPage.TabIndex = 1
        Me.tdmsGraphTabPage.Text = "Graph"
        Me.tdmsGraphTabPage.UseVisualStyleBackColor = True
        '
        'tdmsWaveformGraph
        '
        Me.tdmsWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdmsWaveformGraph.Location = New System.Drawing.Point(3, 3)
        Me.tdmsWaveformGraph.Name = "tdmsWaveformGraph"
        Me.tdmsWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.tdmsWaveformPlot})
        Me.tdmsWaveformGraph.Size = New System.Drawing.Size(443, 313)
        Me.tdmsWaveformGraph.TabIndex = 1
        Me.tdmsWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.tdmsXAxis})
        Me.tdmsWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.tdmsYAxis})
        '
        'tdmsWaveformPlot
        '
        Me.tdmsWaveformPlot.XAxis = Me.tdmsXAxis
        Me.tdmsWaveformPlot.YAxis = Me.tdmsYAxis
        '
        'tdmsDigitalWaveformGraph
        '
        Me.tdmsDigitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tdmsDigitalWaveformGraph.Location = New System.Drawing.Point(3, 3)
        Me.tdmsDigitalWaveformGraph.Name = "tdmsDigitalWaveformGraph"
        Me.tdmsDigitalWaveformGraph.Size = New System.Drawing.Size(443, 313)
        Me.tdmsDigitalWaveformGraph.TabIndex = 0
        '
        'tdmsPropertiesLabel
        '
        Me.tdmsPropertiesLabel.AutoSize = True
        Me.tdmsPropertiesLabel.Location = New System.Drawing.Point(191, 0)
        Me.tdmsPropertiesLabel.Name = "tdmsPropertiesLabel"
        Me.tdmsPropertiesLabel.Size = New System.Drawing.Size(54, 13)
        Me.tdmsPropertiesLabel.TabIndex = 1
        Me.tdmsPropertiesLabel.Text = "Properties"
        '
        'tmdsFileLabel
        '
        Me.tmdsFileLabel.AutoSize = True
        Me.tmdsFileLabel.Location = New System.Drawing.Point(-3, 0)
        Me.tmdsFileLabel.Name = "tmdsFileLabel"
        Me.tmdsFileLabel.Size = New System.Drawing.Size(57, 13)
        Me.tmdsFileLabel.TabIndex = 0
        Me.tmdsFileLabel.Text = "TDMS File"
        '
        'loadValuesButton
        '
        Me.loadValuesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.loadValuesButton.Enabled = False
        Me.loadValuesButton.Location = New System.Drawing.Point(347, 641)
        Me.loadValuesButton.Name = "loadValuesButton"
        Me.loadValuesButton.Size = New System.Drawing.Size(112, 23)
        Me.loadValuesButton.TabIndex = 9
        Me.loadValuesButton.Text = "Load More Values"
        Me.loadValuesButton.UseVisualStyleBackColor = True
        '
        'tdmsDataIndexColumn
        '
        Me.tdmsDataIndexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.tdmsDataIndexColumn.HeaderText = "Index"
        Me.tdmsDataIndexColumn.Name = "tdmsDataIndexColumn"
        Me.tdmsDataIndexColumn.ReadOnly = True
        Me.tdmsDataIndexColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tdmsDataIndexColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.tdmsDataIndexColumn.Width = 39
        '
        'tdmsDataColumn
        '
        Me.tdmsDataColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.tdmsDataColumn.HeaderText = "Channel Data"
        Me.tdmsDataColumn.Name = "tdmsDataColumn"
        Me.tdmsDataColumn.ReadOnly = True
        Me.tdmsDataColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tdmsDataColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'TdmsReaderUserControl
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.Controls.Add(Me.tdmsFileAndDataSplitContainer)
        Me.Controls.Add(Me.tdmsPropertiesLabel)
        Me.Controls.Add(Me.tmdsFileLabel)
        Me.Controls.Add(Me.loadValuesButton)
        Me.Name = "TdmsReaderUserControl"
        Me.Size = New System.Drawing.Size(459, 669)
        CType(Me.tdmsPropertiesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tdmsFileAndDataSplitContainer.Panel1.ResumeLayout(False)
        Me.tdmsFileAndDataSplitContainer.Panel2.ResumeLayout(False)
        Me.tdmsFileAndDataSplitContainer.ResumeLayout(False)
        Me.tdmsFileAndPropertiesSplitContainer.Panel1.ResumeLayout(False)
        Me.tdmsFileAndPropertiesSplitContainer.Panel2.ResumeLayout(False)
        Me.tdmsFileAndPropertiesSplitContainer.ResumeLayout(False)
        Me.tdmsDataTabControl.ResumeLayout(False)
        Me.tdmsDataTabPage.ResumeLayout(False)
        CType(Me.tdmsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tdmsGraphTabPage.ResumeLayout(False)
        CType(Me.tdmsWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdmsDigitalWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tdmsPropertyNamesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents tdmsPropertiesDataGridView As System.Windows.Forms.DataGridView
    Private WithEvents tmdsPropertyValuesColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents tdmsFileAndDataSplitContainer As System.Windows.Forms.SplitContainer
    Private WithEvents tdmsFileAndPropertiesSplitContainer As System.Windows.Forms.SplitContainer
    Private WithEvents tdmsFileTreeView As System.Windows.Forms.TreeView
    Private WithEvents tdmsDataGridView As System.Windows.Forms.DataGridView
    Private WithEvents tdmsPropertiesLabel As System.Windows.Forms.Label
    Private WithEvents tmdsFileLabel As System.Windows.Forms.Label
    Private WithEvents loadValuesButton As System.Windows.Forms.Button
    Friend WithEvents tdmsDataTabControl As System.Windows.Forms.TabControl
    Friend WithEvents tdmsDataTabPage As System.Windows.Forms.TabPage
    Friend WithEvents tdmsGraphTabPage As System.Windows.Forms.TabPage
    Friend WithEvents tdmsDigitalWaveformGraph As NationalInstruments.UI.WindowsForms.DigitalWaveformGraph
    Friend WithEvents tdmsWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents tdmsWaveformPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents tdmsXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents tdmsYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents tdmsDataIndexColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tdmsDataColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
