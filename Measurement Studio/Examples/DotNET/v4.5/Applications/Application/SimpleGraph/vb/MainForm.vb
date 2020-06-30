Imports NationalInstruments.Analysis.SignalGeneration
Imports NationalInstruments.UI.WindowsForms
Imports NationalInstruments.UI


Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private utilityHelper As utilityHelper
    Private phase As Integer
    Private lastStatus As String

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        utilityHelper = New utilityHelper

        AcquireSineWave.PlotY(AcquireData(2, 6, 0, 400, 2), -100, 0.5)
        ScrollingSineWave.PlotY(AcquireData(20, 2, phase, 200, 0), -100, 1)

        InitializeMenuHelperStrings(mainMenu.MenuItems)
        InitializeToolTips(mainToolBar.Buttons)
        MapToolBarAndMenuItems()
        InitializeInteractionMenu()
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
    Private WithEvents seperator1 As System.Windows.Forms.ToolBarButton
    Private WithEvents simulateToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents XRangeToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents seperator2 As System.Windows.Forms.ToolBarButton
    Private WithEvents YRangeToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents simulateTimer As System.Windows.Forms.Timer
    Private WithEvents mainToolBar As System.Windows.Forms.ToolBar
    Private WithEvents dragCursorToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents PanXToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents PanYToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents zoomPointToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents zoomXToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents zoomYToolButton As System.Windows.Forms.ToolBarButton
    Private WithEvents toolBarImages As System.Windows.Forms.ImageList
    Private WithEvents XRangeMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents aboutMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents mainStatusPanel As System.Windows.Forms.StatusBarPanel
    Private WithEvents cursorStatusBar As System.Windows.Forms.StatusBar
    Private WithEvents cursorStatusPanel As System.Windows.Forms.StatusBarPanel
    Private WithEvents simulateMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents mainMenu As System.Windows.Forms.MainMenu
    Private WithEvents fileMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents quitMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents optionsMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents YRangeMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents interactionModesMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents dragCursorMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents panXMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents panYMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents zoomPointMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents zoomXMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents zoomYMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents viewMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents toolBarMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents statusBarMenuItem As System.Windows.Forms.MenuItem
    Private WithEvents helpMenuItem As System.Windows.Forms.MenuItem
    Friend WithEvents mainPanel As System.Windows.Forms.Panel
    Friend WithEvents mainWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend XAxis1 As NationalInstruments.UI.XAxis
    Friend YAxis1 As NationalInstruments.UI.YAxis
    Friend WithEvents XyCursor1 As NationalInstruments.UI.XYCursor
    Friend WithEvents AcquireSineWave As NationalInstruments.UI.WaveformPlot
    Friend WithEvents ScrollingSineWave As NationalInstruments.UI.WaveformPlot
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.seperator1 = New System.Windows.Forms.ToolBarButton
        Me.simulateToolButton = New System.Windows.Forms.ToolBarButton
        Me.XRangeToolButton = New System.Windows.Forms.ToolBarButton
        Me.seperator2 = New System.Windows.Forms.ToolBarButton
        Me.YRangeToolButton = New System.Windows.Forms.ToolBarButton
        Me.simulateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.mainToolBar = New System.Windows.Forms.ToolBar
        Me.dragCursorToolButton = New System.Windows.Forms.ToolBarButton
        Me.PanXToolButton = New System.Windows.Forms.ToolBarButton
        Me.PanYToolButton = New System.Windows.Forms.ToolBarButton
        Me.zoomPointToolButton = New System.Windows.Forms.ToolBarButton
        Me.zoomXToolButton = New System.Windows.Forms.ToolBarButton
        Me.zoomYToolButton = New System.Windows.Forms.ToolBarButton
        Me.toolBarImages = New System.Windows.Forms.ImageList(Me.components)
        Me.XRangeMenuItem = New System.Windows.Forms.MenuItem
        Me.aboutMenuItem = New System.Windows.Forms.MenuItem
        Me.mainStatusPanel = New System.Windows.Forms.StatusBarPanel
        Me.cursorStatusBar = New System.Windows.Forms.StatusBar
        Me.cursorStatusPanel = New System.Windows.Forms.StatusBarPanel
        Me.simulateMenuItem = New System.Windows.Forms.MenuItem
        Me.mainMenu = New System.Windows.Forms.MainMenu
        Me.fileMenuItem = New System.Windows.Forms.MenuItem
        Me.quitMenuItem = New System.Windows.Forms.MenuItem
        Me.optionsMenuItem = New System.Windows.Forms.MenuItem
        Me.YRangeMenuItem = New System.Windows.Forms.MenuItem
        Me.interactionModesMenuItem = New System.Windows.Forms.MenuItem
        Me.dragCursorMenuItem = New System.Windows.Forms.MenuItem
        Me.panXMenuItem = New System.Windows.Forms.MenuItem
        Me.panYMenuItem = New System.Windows.Forms.MenuItem
        Me.zoomPointMenuItem = New System.Windows.Forms.MenuItem
        Me.zoomXMenuItem = New System.Windows.Forms.MenuItem
        Me.zoomYMenuItem = New System.Windows.Forms.MenuItem
        Me.viewMenuItem = New System.Windows.Forms.MenuItem
        Me.toolBarMenuItem = New System.Windows.Forms.MenuItem
        Me.statusBarMenuItem = New System.Windows.Forms.MenuItem
        Me.helpMenuItem = New System.Windows.Forms.MenuItem
        Me.mainPanel = New System.Windows.Forms.Panel
        Me.mainWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.XyCursor1 = New NationalInstruments.UI.XYCursor
        Me.AcquireSineWave = New NationalInstruments.UI.WaveformPlot
        Me.XAxis1 = New NationalInstruments.UI.XAxis
        Me.YAxis1 = New NationalInstruments.UI.YAxis
        Me.ScrollingSineWave = New NationalInstruments.UI.WaveformPlot
        CType(Me.mainStatusPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cursorStatusPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mainPanel.SuspendLayout()
        CType(Me.mainWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XyCursor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'seperator1
        '
        Me.seperator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'simulateToolButton
        '
        Me.simulateToolButton.ImageIndex = 0
        Me.simulateToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'XRangeToolButton
        '
        Me.XRangeToolButton.ImageIndex = 1
        '
        'seperator2
        '
        Me.seperator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'YRangeToolButton
        '
        Me.YRangeToolButton.ImageIndex = 2
        '
        'simulateTimer
        '
        '
        'mainToolBar
        '
        Me.mainToolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.mainToolBar.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.simulateToolButton, Me.seperator1, Me.XRangeToolButton, Me.YRangeToolButton, Me.seperator2, Me.dragCursorToolButton, Me.PanXToolButton, Me.PanYToolButton, Me.zoomPointToolButton, Me.zoomXToolButton, Me.zoomYToolButton})
        Me.mainToolBar.DropDownArrows = True
        Me.mainToolBar.ImageList = Me.toolBarImages
        Me.mainToolBar.Location = New System.Drawing.Point(0, 0)
        Me.mainToolBar.Name = "mainToolBar"
        Me.mainToolBar.ShowToolTips = True
        Me.mainToolBar.Size = New System.Drawing.Size(532, 28)
        Me.mainToolBar.TabIndex = 3
        '
        'dragCursorToolButton
        '
        Me.dragCursorToolButton.ImageIndex = 3
        Me.dragCursorToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'PanXToolButton
        '
        Me.PanXToolButton.ImageIndex = 4
        Me.PanXToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'PanYToolButton
        '
        Me.PanYToolButton.ImageIndex = 5
        Me.PanYToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'zoomPointToolButton
        '
        Me.zoomPointToolButton.ImageIndex = 6
        Me.zoomPointToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'zoomXToolButton
        '
        Me.zoomXToolButton.ImageIndex = 7
        Me.zoomXToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'zoomYToolButton
        '
        Me.zoomYToolButton.ImageIndex = 8
        Me.zoomYToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton
        '
        'toolBarImages
        '
        Me.toolBarImages.ImageStream = CType(resources.GetObject("toolBarImages.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.toolBarImages.TransparentColor = System.Drawing.Color.Transparent
        '
        'XRangeMenuItem
        '
        Me.XRangeMenuItem.Index = 1
        Me.XRangeMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlX
        Me.XRangeMenuItem.Text = "Set X Range..."
        '
        'aboutMenuItem
        '
        Me.aboutMenuItem.Index = 0
        Me.aboutMenuItem.Text = "Graph keyboard help..."
        '
        'mainStatusPanel
        '
        Me.mainStatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.mainStatusPanel.Text = "Ready"
        Me.mainStatusPanel.Width = 415
        '
        'cursorStatusBar
        '
        Me.cursorStatusBar.Location = New System.Drawing.Point(0, 386)
        Me.cursorStatusBar.Name = "cursorStatusBar"
        Me.cursorStatusBar.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.mainStatusPanel, Me.cursorStatusPanel})
        Me.cursorStatusBar.ShowPanels = True
        Me.cursorStatusBar.Size = New System.Drawing.Size(532, 22)
        Me.cursorStatusBar.TabIndex = 4
        Me.cursorStatusBar.Text = "Ready"
        '
        'cursorStatusPanel
        '
        Me.cursorStatusPanel.Text = "(0,0)"
        '
        'simulateMenuItem
        '
        Me.simulateMenuItem.Index = 0
        Me.simulateMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.simulateMenuItem.Text = "Simulate"
        '
        'mainMenu
        '
        Me.mainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.fileMenuItem, Me.optionsMenuItem, Me.viewMenuItem, Me.helpMenuItem})
        '
        'fileMenuItem
        '
        Me.fileMenuItem.Index = 0
        Me.fileMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.quitMenuItem})
        Me.fileMenuItem.Text = "&File"
        '
        'quitMenuItem
        '
        Me.quitMenuItem.Index = 0
        Me.quitMenuItem.Text = "Quit"
        '
        'optionsMenuItem
        '
        Me.optionsMenuItem.Index = 1
        Me.optionsMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.simulateMenuItem, Me.XRangeMenuItem, Me.YRangeMenuItem, Me.interactionModesMenuItem})
        Me.optionsMenuItem.Text = "&Options"
        '
        'YRangeMenuItem
        '
        Me.YRangeMenuItem.Index = 2
        Me.YRangeMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlY
        Me.YRangeMenuItem.Text = "Set Y Range..."
        '
        'interactionModesMenuItem
        '
        Me.interactionModesMenuItem.Index = 3
        Me.interactionModesMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.dragCursorMenuItem, Me.panXMenuItem, Me.panYMenuItem, Me.zoomPointMenuItem, Me.zoomXMenuItem, Me.zoomYMenuItem})
        Me.interactionModesMenuItem.Text = "Interaction Mode"
        '
        'dragCursorMenuItem
        '
        Me.dragCursorMenuItem.Index = 0
        Me.dragCursorMenuItem.Text = "DragCursor"
        '
        'panXMenuItem
        '
        Me.panXMenuItem.Index = 1
        Me.panXMenuItem.Text = "PanX"
        '
        'panYMenuItem
        '
        Me.panYMenuItem.Index = 2
        Me.panYMenuItem.Text = "PanY"
        '
        'zoomPointMenuItem
        '
        Me.zoomPointMenuItem.Index = 3
        Me.zoomPointMenuItem.Text = "ZoomAroundPoint"
        '
        'zoomXMenuItem
        '
        Me.zoomXMenuItem.Index = 4
        Me.zoomXMenuItem.Text = "ZoomX"
        '
        'zoomYMenuItem
        '
        Me.zoomYMenuItem.Index = 5
        Me.zoomYMenuItem.Text = "ZoomY"
        '
        'viewMenuItem
        '
        Me.viewMenuItem.Index = 2
        Me.viewMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.toolBarMenuItem, Me.statusBarMenuItem})
        Me.viewMenuItem.Text = "&View"
        '
        'toolBarMenuItem
        '
        Me.toolBarMenuItem.Checked = True
        Me.toolBarMenuItem.Index = 0
        Me.toolBarMenuItem.Text = "ToolBar"
        '
        'statusBarMenuItem
        '
        Me.statusBarMenuItem.Checked = True
        Me.statusBarMenuItem.Index = 1
        Me.statusBarMenuItem.Text = "Status Bar"
        '
        'helpMenuItem
        '
        Me.helpMenuItem.Index = 3
        Me.helpMenuItem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.aboutMenuItem})
        Me.helpMenuItem.Text = "&Help"
        '
        'mainPanel
        '
        Me.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.mainPanel.Controls.Add(Me.mainWaveformGraph)
        Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainPanel.Location = New System.Drawing.Point(0, 28)
        Me.mainPanel.Name = "mainPanel"
        Me.mainPanel.Size = New System.Drawing.Size(532, 358)
        Me.mainPanel.TabIndex = 5
        '
        'mainWaveformGraph
        '
        Me.mainWaveformGraph.Border = NationalInstruments.UI.Border.None
        Me.mainWaveformGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.XyCursor1})
        Me.mainWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainWaveformGraph.Location = New System.Drawing.Point(0, 0)
        Me.mainWaveformGraph.Name = "mainWaveformGraph"
        Me.mainWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.ScrollingSineWave, Me.AcquireSineWave})
        Me.mainWaveformGraph.Size = New System.Drawing.Size(528, 354)
        Me.mainWaveformGraph.TabIndex = 0
        Me.mainWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.XAxis1})
        Me.mainWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.YAxis1})
        '
        'XyCursor1
        '
        Me.XyCursor1.Color = System.Drawing.Color.DodgerBlue
        Me.XyCursor1.Plot = Me.AcquireSineWave
        Me.XyCursor1.PointStyle = NationalInstruments.UI.PointStyle.None
        Me.XyCursor1.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating
        Me.XyCursor1.XPosition = 0
        Me.XyCursor1.YPosition = 0
        '
        'AcquireSineWave
        '
        Me.AcquireSineWave.LineColor = System.Drawing.Color.White
        Me.AcquireSineWave.XAxis = Me.XAxis1
        Me.AcquireSineWave.YAxis = Me.YAxis1
        '
        'XAxis1
        '
        Me.XAxis1.MajorDivisions.GridVisible = True
        Me.XAxis1.MinorDivisions.GridVisible = True
        Me.XAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.XAxis1.Range = New NationalInstruments.UI.Range(-100, 100)
        '
        'YAxis1
        '
        Me.YAxis1.MajorDivisions.GridVisible = True
        Me.YAxis1.MinorDivisions.GridVisible = True
        Me.YAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed
        Me.YAxis1.Range = New NationalInstruments.UI.Range(-10, 10)
        '
        'ScrollingSineWave
        '
        Me.ScrollingSineWave.XAxis = Me.XAxis1
        Me.ScrollingSineWave.YAxis = Me.YAxis1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(532, 408)
        Me.Controls.Add(Me.mainPanel)
        Me.Controls.Add(Me.mainToolBar)
        Me.Controls.Add(Me.cursorStatusBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mainMenu
        Me.Name = "MainForm"
        Me.Text = "Simple Graph"
        CType(Me.mainStatusPanel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cursorStatusPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mainPanel.ResumeLayout(False)
        CType(Me.mainWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XyCursor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub InitializeMenuHelperStrings(ByVal menuItems As Menu.MenuItemCollection)
        For Each item As MenuItem In menuItems
            utilityHelper.AddMenuString(item)
            AddHandler item.Select, AddressOf OnMenuSelect
            InitializeMenuHelperStrings(item.MenuItems)
        Next
    End Sub

    Private Sub InitializeToolTips(ByVal buttons As toolBar.ToolBarButtonCollection)
        Dim helpIndex As Integer = 0
        For Each button As ToolBarButton In buttons
            If Not button.Style = ToolBarButtonStyle.Separator Then
                button.ToolTipText = utilityHelper.GetToolTip(helpIndex)
                helpIndex += 1
            End If
        Next

    End Sub

    Private Sub MapToolBarAndMenuItems()
        utilityHelper.MapMenuAndToolBar(simulateToolButton, simulateMenuItem)
        utilityHelper.MapMenuAndToolBar(XRangeToolButton, XRangeMenuItem)
        utilityHelper.MapMenuAndToolBar(YRangeToolButton, YRangeMenuItem)
        utilityHelper.MapMenuAndToolBar(dragCursorToolButton, dragCursorMenuItem)
        utilityHelper.MapMenuAndToolBar(PanXToolButton, panXMenuItem)
        utilityHelper.MapMenuAndToolBar(PanYToolButton, panYMenuItem)
        utilityHelper.MapMenuAndToolBar(zoomPointToolButton, zoomPointMenuItem)
        utilityHelper.MapMenuAndToolBar(zoomXToolButton, zoomXMenuItem)
        utilityHelper.MapMenuAndToolBar(zoomYToolButton, zoomYMenuItem)
    End Sub

    Private Function IsInteractionModeSelected(ByVal mode As GraphInteractionModes) As Boolean
        Return ((mainWaveformGraph.InteractionMode And mode) = mode)
    End Function

    Private Sub InitializeInteractionMenu()
        If IsInteractionModeSelected(GraphInteractionModes.DragCursor) Then
            dragCursorMenuItem.PerformClick()
        End If
        If IsInteractionModeSelected(GraphInteractionModes.PanX) Then
            panXMenuItem.PerformClick()
        End If
        If IsInteractionModeSelected(GraphInteractionModes.PanY) Then
            panYMenuItem.PerformClick()
        End If
        If IsInteractionModeSelected(GraphInteractionModes.ZoomAroundPoint) Then
            zoomPointMenuItem.PerformClick()
        End If
        If IsInteractionModeSelected(GraphInteractionModes.ZoomX) Then
            zoomXMenuItem.PerformClick()
        End If
        If IsInteractionModeSelected(GraphInteractionModes.ZoomY) Then
            zoomYMenuItem.PerformClick()
        End If
    End Sub

    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs) Handles simulateTimer.Tick
        AcquireSineWave.PlotY(AcquireData(2, 6, 0, 400, 2), -100, 0.5)
        phase += 20
        phase = phase Mod 360
        ScrollingSineWave.PlotY(AcquireData(20, 2, phase, 200, 0), -100, 1)
    End Sub

    Private Sub OnSimulate(ByVal sender As Object, ByVal e As EventArgs) Handles simulateMenuItem.Click
        simulateMenuItem.Checked = Not simulateMenuItem.Checked

        Dim button As ToolBarButton = utilityHelper.FromMenuItem(simulateMenuItem)
        simulateTimer.Enabled = simulateMenuItem.Checked
        button.Pushed = simulateMenuItem.Checked

        If simulateMenuItem.Checked Then
            mainStatusPanel.Text = "Simulating..."
        Else
            mainStatusPanel.Text = "Ready"
        End If
    End Sub

    Private Function AcquireData(ByVal frequency As Double, ByVal amplitude As Double, ByVal phase As Double, ByVal numberSamples As Double, ByVal noiseAmplitude As Double) As Double()
        Dim signal As SineSignal = New SineSignal(frequency, amplitude, phase)
        Dim noise As WhiteNoiseSignal = New WhiteNoiseSignal(noiseAmplitude)
        Dim generator As SignalGenerator = New SignalGenerator(numberSamples, numberSamples)
        generator.Signals.Add(signal)
        generator.Signals.Add(noise)
        Return generator.Generate()
    End Function

    Protected Overrides Sub OnMenuStart(ByVal e As EventArgs)
        MyBase.OnMenuStart(e)
        lastStatus = mainStatusPanel.Text
    End Sub

    Protected Overrides Sub OnMenuComplete(ByVal e As EventArgs)
        MyBase.OnMenuComplete(e)
        mainStatusPanel.Text = lastStatus
    End Sub

    Private Sub OnMenuSelect(ByVal sender As Object, ByVal e As EventArgs)
        mainStatusPanel.Text = utilityHelper.GetMenuString(sender)
    End Sub

    Private Sub OnToolBarButtonClick(ByVal sender As Object, ByVal e As ToolBarButtonClickEventArgs) Handles mainToolBar.ButtonClick
        Dim item As MenuItem = utilityHelper.FromToolBarButton(e.Button)
        item.PerformClick()
    End Sub

    Private Sub OnHelp(ByVal sender As Object, ByVal e As EventArgs) Handles aboutMenuItem.Click
        Dim dlg As AboutDlg = New AboutDlg
        dlg.Owner = Me
        dlg.Show()
    End Sub

    Private Sub UpdateGraphAndToolBar(ByVal item As MenuItem, ByVal mode As GraphInteractionModes)
        item.Checked = Not item.Checked

        Dim button As ToolBarButton = utilityHelper.FromMenuItem(item)
        button.Pushed = item.Checked

        If (item.Checked) Then
            mainWaveformGraph.InteractionMode = mode Or mainWaveformGraph.InteractionMode
        Else
            mainWaveformGraph.InteractionMode = (Not mode) And mainWaveformGraph.InteractionMode
        End If
    End Sub

    Private Sub OnDragCursor(ByVal sender As Object, ByVal e As EventArgs) Handles dragCursorMenuItem.Click
        UpdateGraphAndToolBar(dragCursorMenuItem, GraphInteractionModes.DragCursor)
    End Sub

    Private Sub OnPanX(ByVal sender As Object, ByVal e As EventArgs) Handles panXMenuItem.Click
        UpdateGraphAndToolBar(panXMenuItem, GraphInteractionModes.PanX)
    End Sub

    Private Sub OnPanY(ByVal sender As Object, ByVal e As EventArgs) Handles panYMenuItem.Click
        UpdateGraphAndToolBar(panYMenuItem, GraphInteractionModes.PanY)
    End Sub

    Private Sub OnZoomAroundPoint(ByVal sender As Object, ByVal e As EventArgs) Handles zoomPointMenuItem.Click
        UpdateGraphAndToolBar(zoomPointMenuItem, GraphInteractionModes.ZoomAroundPoint)
    End Sub

    Private Sub OnZoomX(ByVal sender As Object, ByVal e As EventArgs) Handles zoomXMenuItem.Click
        UpdateGraphAndToolBar(zoomXMenuItem, GraphInteractionModes.ZoomX)
    End Sub

    Private Sub OnZoomY(ByVal sender As Object, ByVal e As EventArgs) Handles zoomYMenuItem.Click
        UpdateGraphAndToolBar(zoomYMenuItem, GraphInteractionModes.ZoomY)
    End Sub

    Private Sub SetRange(ByVal scale As Scale, ByVal caption As String)
        Dim dlg As RangeEditorDlg = New RangeEditorDlg(scale.Range.Minimum, scale.Range.Maximum)
        dlg.Text = caption
        Dim result As DialogResult = dlg.ShowDialog()
        If Not result = Windows.Forms.DialogResult.Cancel Then
            Try
                scale.Range = New Range(dlg.Minimum, dlg.Maximum)
            Catch ex As Exception
                MessageBox.Show("The Range.Minimum was greater than the Range.Maximum", "Range Error")
            End Try
        End If
    End Sub

    Private Sub OnSetXRange(ByVal sender As Object, ByVal e As EventArgs) Handles XRangeMenuItem.Click
        SetRange(XAxis1, "Set X Range")
    End Sub

    Private Sub OnSetYRange(ByVal sender As Object, ByVal e As EventArgs) Handles YRangeMenuItem.Click
        SetRange(YAxis1, "Set Y Range")
    End Sub

    Private Sub OnToolBarMenuItem(ByVal sender As Object, ByVal e As EventArgs) Handles toolBarMenuItem.Click
        toolBarMenuItem.Checked = Not toolBarMenuItem.Checked
        mainToolBar.Visible = toolBarMenuItem.Checked
    End Sub

    Private Sub OnStatusBarMenuItem(ByVal sender As Object, ByVal e As EventArgs) Handles statusBarMenuItem.Click
        statusBarMenuItem.Checked = Not statusBarMenuItem.Checked
        cursorStatusBar.Visible = statusBarMenuItem.Checked
    End Sub

    Private Sub OnCursorMove(ByVal sender As Object, ByVal args As AfterMoveXYCursorEventArgs) Handles XyCursor1.AfterMove
        cursorStatusPanel.Text = String.Format("({0:F2}, {1:F2})", args.XPosition, args.YPosition)
    End Sub

    Private Sub OnQuit(ByVal sender As Object, ByVal e As EventArgs) Handles quitMenuItem.Click
        Close()
    End Sub


End Class
