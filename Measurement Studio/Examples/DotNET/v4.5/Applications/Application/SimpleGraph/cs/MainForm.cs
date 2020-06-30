using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis.SignalGeneration;
using System.Diagnostics;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.SimpleGraph
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.WaveformGraph mainWaveformGraph;
        private System.Windows.Forms.Timer simulateTimer;
        private System.Windows.Forms.MenuItem simulateMenuItem;
        private System.Windows.Forms.StatusBar cursorStatusBar;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.ImageList toolBarImages;
        private System.Windows.Forms.StatusBarPanel mainStatusPanel;
        private System.Windows.Forms.MenuItem toolBarMenuItem;
        private System.Windows.Forms.MenuItem statusBarMenuItem;
        private System.Windows.Forms.ToolBar mainToolBar;
        private System.Windows.Forms.ToolBarButton simulateToolButton;
        private System.Windows.Forms.ToolBarButton seperator1;
        private System.Windows.Forms.ToolBarButton XRangeToolButton;
        private System.Windows.Forms.ToolBarButton YRangeToolButton;
        private System.Windows.Forms.ToolBarButton seperator2;
        private System.Windows.Forms.ToolBarButton PanXToolButton;
        private System.Windows.Forms.ToolBarButton PanYToolButton;
        private System.Windows.Forms.ToolBarButton zoomPointToolButton;
        private System.Windows.Forms.ToolBarButton zoomXToolButton;
        private System.Windows.Forms.ToolBarButton zoomYToolButton;
        private System.Windows.Forms.StatusBarPanel cursorStatusPanel;
        private System.Windows.Forms.MenuItem dragCursorMenuItem;
        private System.Windows.Forms.MenuItem panXMenuItem;
        private System.Windows.Forms.MenuItem panYMenuItem;
        private System.Windows.Forms.MenuItem zoomPointMenuItem;
        private System.Windows.Forms.MenuItem zoomXMenuItem;
        private System.Windows.Forms.MenuItem zoomYMenuItem;
        private System.Windows.Forms.MenuItem XRangeMenuItem;
        private System.Windows.Forms.MenuItem YRangeMenuItem;
        private System.Windows.Forms.ToolBarButton dragCursorToolButton;
        private NationalInstruments.UI.WaveformPlot scrollingSineWave;
        private NationalInstruments.UI.WaveformPlot acquireSineWave;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem quitMenuItem;
        private System.Windows.Forms.MenuItem optionsMenuItem;
        private System.Windows.Forms.MenuItem interactionModesMenuItem;
        private System.Windows.Forms.MenuItem viewMenuItem;
        private System.Windows.Forms.MenuItem helpMenuItem;
        private System.Windows.Forms.MenuItem aboutMenuItem;
        
        private EventHandler menuSelectHandler;
        private string lastStatus;
        private double phase;
        private NationalInstruments.UI.XYCursor xyCursor;
        private System.Windows.Forms.MainMenu mainMenu;
        private UtilityHelper utilityHelper;

		public MainForm()
		{
			InitializeComponent();
            acquireSineWave.PlotY(AcquireData(2, 6, 0, 400, 2), -100, .5);
            scrollingSineWave.PlotY(AcquireData(20, 2, phase, 200, 0), -100, 1);
            phase = 0;
            menuSelectHandler = new EventHandler(OnMenuSelect);
            utilityHelper = new UtilityHelper();
            
            InitializeMenuHelperStrings(mainMenu.MenuItems);
            InitializeToolTips(mainToolBar.Buttons);
            MapToolBarAndMenuItems();
            InitializeInteractionMenu();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolBar = new System.Windows.Forms.ToolBar();
            this.simulateToolButton = new System.Windows.Forms.ToolBarButton();
            this.seperator1 = new System.Windows.Forms.ToolBarButton();
            this.XRangeToolButton = new System.Windows.Forms.ToolBarButton();
            this.YRangeToolButton = new System.Windows.Forms.ToolBarButton();
            this.seperator2 = new System.Windows.Forms.ToolBarButton();
            this.dragCursorToolButton = new System.Windows.Forms.ToolBarButton();
            this.PanXToolButton = new System.Windows.Forms.ToolBarButton();
            this.PanYToolButton = new System.Windows.Forms.ToolBarButton();
            this.zoomPointToolButton = new System.Windows.Forms.ToolBarButton();
            this.zoomXToolButton = new System.Windows.Forms.ToolBarButton();
            this.zoomYToolButton = new System.Windows.Forms.ToolBarButton();
            this.toolBarImages = new System.Windows.Forms.ImageList(this.components);
            this.cursorStatusBar = new System.Windows.Forms.StatusBar();
            this.mainStatusPanel = new System.Windows.Forms.StatusBarPanel();
            this.cursorStatusPanel = new System.Windows.Forms.StatusBarPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.mainWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xyCursor = new NationalInstruments.UI.XYCursor();
            this.scrollingSineWave = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.acquireSineWave = new NationalInstruments.UI.WaveformPlot();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.quitMenuItem = new System.Windows.Forms.MenuItem();
            this.optionsMenuItem = new System.Windows.Forms.MenuItem();
            this.simulateMenuItem = new System.Windows.Forms.MenuItem();
            this.XRangeMenuItem = new System.Windows.Forms.MenuItem();
            this.YRangeMenuItem = new System.Windows.Forms.MenuItem();
            this.interactionModesMenuItem = new System.Windows.Forms.MenuItem();
            this.dragCursorMenuItem = new System.Windows.Forms.MenuItem();
            this.panXMenuItem = new System.Windows.Forms.MenuItem();
            this.panYMenuItem = new System.Windows.Forms.MenuItem();
            this.zoomPointMenuItem = new System.Windows.Forms.MenuItem();
            this.zoomXMenuItem = new System.Windows.Forms.MenuItem();
            this.zoomYMenuItem = new System.Windows.Forms.MenuItem();
            this.viewMenuItem = new System.Windows.Forms.MenuItem();
            this.toolBarMenuItem = new System.Windows.Forms.MenuItem();
            this.statusBarMenuItem = new System.Windows.Forms.MenuItem();
            this.helpMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.simulateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainStatusPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorStatusPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.mainToolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.mainToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.simulateToolButton,
            this.seperator1,
            this.XRangeToolButton,
            this.YRangeToolButton,
            this.seperator2,
            this.dragCursorToolButton,
            this.PanXToolButton,
            this.PanYToolButton,
            this.zoomPointToolButton,
            this.zoomXToolButton,
            this.zoomYToolButton});
            this.mainToolBar.DropDownArrows = true;
            this.mainToolBar.ImageList = this.toolBarImages;
            this.mainToolBar.Location = new System.Drawing.Point(0, 0);
            this.mainToolBar.Name = "toolBar";
            this.mainToolBar.ShowToolTips = true;
            this.mainToolBar.Size = new System.Drawing.Size(532, 28);
            this.mainToolBar.TabIndex = 0;
            this.mainToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.OnToolbarButtonClick);
            // 
            // simulateToolButton
            // 
            this.simulateToolButton.ImageIndex = 0;
            this.simulateToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // seperator1
            // 
            this.seperator1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // XRangeToolButton
            // 
            this.XRangeToolButton.ImageIndex = 1;
            // 
            // YRangeToolButton
            // 
            this.YRangeToolButton.ImageIndex = 2;
            // 
            // seperator2
            // 
            this.seperator2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // dragCursorToolButton
            // 
            this.dragCursorToolButton.ImageIndex = 3;
            this.dragCursorToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // PanXToolButton
            // 
            this.PanXToolButton.ImageIndex = 4;
            this.PanXToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // PanYToolButton
            // 
            this.PanYToolButton.ImageIndex = 5;
            this.PanYToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // zoomPointToolButton
            // 
            this.zoomPointToolButton.ImageIndex = 6;
            this.zoomPointToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // zoomXToolButton
            // 
            this.zoomXToolButton.ImageIndex = 7;
            this.zoomXToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // zoomYToolButton
            // 
            this.zoomYToolButton.ImageIndex = 8;
            this.zoomYToolButton.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // toolBarImages
            // 
            this.toolBarImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolBarImages.ImageStream")));
            this.toolBarImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cursorStatusBar
            // 
            this.cursorStatusBar.Location = new System.Drawing.Point(0, 386);
            this.cursorStatusBar.Name = "cursorStatusBar";
            this.cursorStatusBar.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.mainStatusPanel,
            this.cursorStatusPanel});
            this.cursorStatusBar.ShowPanels = true;
            this.cursorStatusBar.Size = new System.Drawing.Size(532, 22);
            this.cursorStatusBar.TabIndex = 1;
            this.cursorStatusBar.Text = "Ready";
            // 
            // mainStatusPanel
            // 
            this.mainStatusPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
            this.mainStatusPanel.Text = "Ready";
            this.mainStatusPanel.Width = 415;
            // 
            // cursorStatusPanel
            // 
            this.cursorStatusPanel.Text = "(0,0)";
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainPanel.Controls.Add(this.mainWaveformGraph);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 28);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(532, 358);
            this.mainPanel.TabIndex = 2;
            // 
            // mainWaveformGraph
            // 
            this.mainWaveformGraph.Border = NationalInstruments.UI.Border.None;
            this.mainWaveformGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
            this.xyCursor});
            this.mainWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWaveformGraph.Location = new System.Drawing.Point(0, 0);
            this.mainWaveformGraph.Name = "mainWaveformGraph";
            this.mainWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.scrollingSineWave,
            this.acquireSineWave});
            this.mainWaveformGraph.Size = new System.Drawing.Size(528, 354);
            this.mainWaveformGraph.TabIndex = 0;
            this.mainWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.mainWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // xyCursor
            // 
            this.xyCursor.Color = System.Drawing.Color.DodgerBlue;
            this.xyCursor.Plot = this.scrollingSineWave;
            this.xyCursor.PointStyle = NationalInstruments.UI.PointStyle.None;
            this.xyCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating;
            this.xyCursor.XPosition = 0;
            this.xyCursor.YPosition = 0;
            this.xyCursor.AfterMove += new NationalInstruments.UI.AfterMoveXYCursorEventHandler(this.OnCursorMove);
            // 
            // scrollingSineWave
            // 
            this.scrollingSineWave.XAxis = this.xAxis;
            this.scrollingSineWave.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.MajorDivisions.GridVisible = true;
            this.xAxis.MinorDivisions.GridVisible = true;
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis.Range = new NationalInstruments.UI.Range(-100, 100);
            // 
            // yAxis
            // 
            this.yAxis.MajorDivisions.GridVisible = true;
            this.yAxis.MinorDivisions.GridVisible = true;
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis.Range = new NationalInstruments.UI.Range(-10, 10);
            // 
            // acquireSineWave
            // 
            this.acquireSineWave.LineColor = System.Drawing.Color.White;
            this.acquireSineWave.XAxis = this.xAxis;
            this.acquireSineWave.YAxis = this.yAxis;
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.optionsMenuItem,
            this.viewMenuItem,
            this.helpMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.quitMenuItem});
            this.fileMenuItem.Text = "&File";
            // 
            // quitMenuItem
            // 
            this.quitMenuItem.Index = 0;
            this.quitMenuItem.Text = "Quit";
            this.quitMenuItem.Click += new System.EventHandler(this.OnQuit);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Index = 1;
            this.optionsMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.simulateMenuItem,
            this.XRangeMenuItem,
            this.YRangeMenuItem,
            this.interactionModesMenuItem});
            this.optionsMenuItem.Text = "&Options";
            // 
            // simulateMenuItem
            // 
            this.simulateMenuItem.Index = 0;
            this.simulateMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.simulateMenuItem.Text = "Simulate";
            this.simulateMenuItem.Click += new System.EventHandler(this.OnSimulate);
            // 
            // XRangeMenuItem
            // 
            this.XRangeMenuItem.Index = 1;
            this.XRangeMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.XRangeMenuItem.Text = "Set X Range...";
            this.XRangeMenuItem.Click += new System.EventHandler(this.OnSetXRange);
            // 
            // YRangeMenuItem
            // 
            this.YRangeMenuItem.Index = 2;
            this.YRangeMenuItem.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.YRangeMenuItem.Text = "Set Y Range...";
            this.YRangeMenuItem.Click += new System.EventHandler(this.OnSetYRange);
            // 
            // interactionModesMenuItem
            // 
            this.interactionModesMenuItem.Index = 3;
            this.interactionModesMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.dragCursorMenuItem,
            this.panXMenuItem,
            this.panYMenuItem,
            this.zoomPointMenuItem,
            this.zoomXMenuItem,
            this.zoomYMenuItem});
            this.interactionModesMenuItem.Text = "Interaction Mode";
            // 
            // dragCursorMenuItem
            // 
            this.dragCursorMenuItem.Index = 0;
            this.dragCursorMenuItem.Text = "DragCursor";
            this.dragCursorMenuItem.Click += new System.EventHandler(this.OnDragCursor);
            // 
            // panXMenuItem
            // 
            this.panXMenuItem.Index = 1;
            this.panXMenuItem.Text = "PanX";
            this.panXMenuItem.Click += new System.EventHandler(this.OnPanX);
            // 
            // panYMenuItem
            // 
            this.panYMenuItem.Index = 2;
            this.panYMenuItem.Text = "PanY";
            this.panYMenuItem.Click += new System.EventHandler(this.OnPanY);
            // 
            // zoomPointMenuItem
            // 
            this.zoomPointMenuItem.Index = 3;
            this.zoomPointMenuItem.Text = "ZoomAroundPoint";
            this.zoomPointMenuItem.Click += new System.EventHandler(this.OnZoomAroundPoint);
            // 
            // zoomXMenuItem
            // 
            this.zoomXMenuItem.Index = 4;
            this.zoomXMenuItem.Text = "ZoomX";
            this.zoomXMenuItem.Click += new System.EventHandler(this.OnZoomX);
            // 
            // zoomYMenuItem
            // 
            this.zoomYMenuItem.Index = 5;
            this.zoomYMenuItem.Text = "ZoomY";
            this.zoomYMenuItem.Click += new System.EventHandler(this.OnZoomY);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.Index = 2;
            this.viewMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.toolBarMenuItem,
            this.statusBarMenuItem});
            this.viewMenuItem.Text = "&View";
            // 
            // toolBarMenuItem
            // 
            this.toolBarMenuItem.Checked = true;
            this.toolBarMenuItem.Index = 0;
            this.toolBarMenuItem.Text = "ToolBar";
            this.toolBarMenuItem.Click += new System.EventHandler(this.OnToolBarMenuItem);
            // 
            // statusBarMenuItem
            // 
            this.statusBarMenuItem.Checked = true;
            this.statusBarMenuItem.Index = 1;
            this.statusBarMenuItem.Text = "Status Bar";
            this.statusBarMenuItem.Click += new System.EventHandler(this.OnStatusBarMenuItem);
            // 
            // helpMenuItem
            // 
            this.helpMenuItem.Index = 3;
            this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.aboutMenuItem});
            this.helpMenuItem.Text = "&Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 0;
            this.aboutMenuItem.Text = "Graph keyboard help...";
            this.aboutMenuItem.Click += new System.EventHandler(this.OnHelp);
            // 
            // simulateTimer
            // 
            this.simulateTimer.Tick += new System.EventHandler(this.simulateTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(532, 408);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.cursorStatusBar);
            this.Controls.Add(this.mainToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Simple Graph";
            this.MenuStart += new System.EventHandler(this.OnMenuStart);
            this.MenuComplete += new System.EventHandler(this.OnMenuComplete);
            ((System.ComponentModel.ISupportInitialize)(this.mainStatusPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorStatusPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new MainForm());
		}

        private void InitializeMenuHelperStrings(Menu.MenuItemCollection menuItems)
        {
            foreach(MenuItem item in menuItems)
            {
                utilityHelper.AddMenuString(item);
                item.Select += menuSelectHandler;
                InitializeMenuHelperStrings(item.MenuItems);
            }
        }

        private void InitializeToolTips(ToolBar.ToolBarButtonCollection buttons)
        {
            int helpIndex = 0;
 
            foreach(ToolBarButton button in buttons)
            {
                if(button.Style != ToolBarButtonStyle.Separator)
                {
                    button.ToolTipText = utilityHelper.GetToolTip(helpIndex);
                    helpIndex++;
                }
            }
        }

        private bool IsInteractionModeSelected(GraphInteractionModes mode)
        {
            return ((mainWaveformGraph.InteractionMode & mode) == mode); 
        }

        private void InitializeInteractionMenu()
        {
            if(IsInteractionModeSelected(GraphInteractionModes.DragCursor))
                dragCursorMenuItem.PerformClick();
            if(IsInteractionModeSelected(GraphInteractionModes.PanX))
                panXMenuItem.PerformClick();
            if(IsInteractionModeSelected(GraphInteractionModes.PanY))
                panYMenuItem.PerformClick();
            if(IsInteractionModeSelected(GraphInteractionModes.ZoomAroundPoint))
                zoomPointMenuItem.PerformClick();
            if(IsInteractionModeSelected(GraphInteractionModes.ZoomX))
                zoomXMenuItem.PerformClick();
            if(IsInteractionModeSelected(GraphInteractionModes.ZoomY))
                zoomYMenuItem.PerformClick();
        }

        private void MapToolBarAndMenuItems()
        {
            utilityHelper.MapMenuAndToolBar(simulateToolButton, simulateMenuItem);
            utilityHelper.MapMenuAndToolBar(XRangeToolButton, XRangeMenuItem);
            utilityHelper.MapMenuAndToolBar(YRangeToolButton, YRangeMenuItem);
            utilityHelper.MapMenuAndToolBar(dragCursorToolButton, dragCursorMenuItem);
            utilityHelper.MapMenuAndToolBar(PanXToolButton, panXMenuItem);
            utilityHelper.MapMenuAndToolBar(PanYToolButton, panYMenuItem);
            utilityHelper.MapMenuAndToolBar(zoomPointToolButton, zoomPointMenuItem);
            utilityHelper.MapMenuAndToolBar(zoomXToolButton, zoomXMenuItem);
            utilityHelper.MapMenuAndToolBar(zoomYToolButton, zoomYMenuItem);
        }

        private void simulateTimer_Tick(object sender, System.EventArgs e)
        {
            acquireSineWave.PlotY(AcquireData(2, 6, 0, 400, 2), -100, .5);
            phase += 20;
            phase = phase % 360;
            scrollingSineWave.PlotY(AcquireData(20, 2, phase, 200, 0), -100, 1);
        }

        private double[] AcquireData(double frequency, double amplitude, double phase, double numberSamples, double noiseAmplitude)
        {
            SineSignal sineSignal = new SineSignal(frequency, amplitude, phase);
            WhiteNoiseSignal noise = new WhiteNoiseSignal(noiseAmplitude);
            SignalGenerator generator = new SignalGenerator(numberSamples, (long)numberSamples);
            generator.Signals.Add(sineSignal);
            generator.Signals.Add(noise);
            return generator.Generate();
        }

        private void OnSimulate(object sender, System.EventArgs e)
        {
            simulateMenuItem.Checked = !simulateMenuItem.Checked;
            
            ToolBarButton button = utilityHelper.FromMenuItem(simulateMenuItem);
            button.Pushed = simulateTimer.Enabled = simulateMenuItem.Checked;
            
            if(simulateMenuItem.Checked)
                mainStatusPanel.Text = "Simulating...";
            else
                mainStatusPanel.Text = "Ready";
        }

        private void OnToolBarMenuItem(object sender, System.EventArgs e)
        {
            mainToolBar.Visible = toolBarMenuItem.Checked = !toolBarMenuItem.Checked;
        }

        private void OnStatusBarMenuItem(object sender, System.EventArgs e)
        {
            cursorStatusBar.Visible = statusBarMenuItem.Checked = !statusBarMenuItem.Checked;
        }

        private void OnMenuSelect(object sender, EventArgs e)
        {
            mainStatusPanel.Text = utilityHelper.GetMenuString(sender);
        }

        private void OnMenuStart(object sender, System.EventArgs e)
        {
            lastStatus = mainStatusPanel.Text;
        }

        private void OnMenuComplete(object sender, System.EventArgs e)
        {
            mainStatusPanel.Text = lastStatus;
        }

        private void OnToolbarButtonClick(object sender, ToolBarButtonClickEventArgs e)
        {
            MenuItem item = utilityHelper.FromToolBarButton(e.Button);
            item.PerformClick();
        }

        private void UpdateGraphAndToolBar(MenuItem item, GraphInteractionModes mode)
        {
            item.Checked = !item.Checked;
            
            ToolBarButton button = utilityHelper.FromMenuItem(item);
            button.Pushed = item.Checked;

            if(item.Checked)
                mainWaveformGraph.InteractionMode |= mode;
            else
                mainWaveformGraph.InteractionMode &= ~mode;

        }

        private void OnDragCursor(object sender, System.EventArgs e)
        {
            UpdateGraphAndToolBar(dragCursorMenuItem, GraphInteractionModes.DragCursor);        
        }

        private void OnPanX(object sender, System.EventArgs e)
        {
            UpdateGraphAndToolBar(panXMenuItem, GraphInteractionModes.PanX);
        }

        private void OnPanY(object sender, System.EventArgs e)
        {
            UpdateGraphAndToolBar(panYMenuItem, GraphInteractionModes.PanY);
        }

        private void OnZoomAroundPoint(object sender, System.EventArgs e)
        {
            UpdateGraphAndToolBar(zoomPointMenuItem, GraphInteractionModes.ZoomAroundPoint);
        }

        private void OnZoomX(object sender, System.EventArgs e)
        {
            UpdateGraphAndToolBar(zoomXMenuItem, GraphInteractionModes.ZoomX);
        }

        private void OnZoomY(object sender, System.EventArgs e)
        {
            UpdateGraphAndToolBar(zoomYMenuItem, GraphInteractionModes.ZoomY);
        }

        private void OnCursorMove(object sender, NationalInstruments.UI.AfterMoveXYCursorEventArgs e)
        {
            cursorStatusPanel.Text = string.Format("({0:F2}, {1:F2})", e.XPosition, e.YPosition);
        }

        private void SetRange(Scale scale, string caption)
        {
            RangeEditorDlg dlg = new RangeEditorDlg(scale.Range.Minimum, scale.Range.Maximum);
            dlg.Text = caption;
            DialogResult result = dlg.ShowDialog();
            if(result != DialogResult.Cancel)
            {
                try
                {
                    scale.Range = new Range(dlg.Minimum, dlg.Maximum);
                }
                catch(Exception)
                {
                    MessageBox.Show("The Range.Minimum was greater than the Range.Maximum", "Range Error");
                }
            }
        }

        private void OnSetXRange(object sender, System.EventArgs e)
        {
            SetRange(xAxis, "Set X Range");
        }

        private void OnSetYRange(object sender, System.EventArgs e)
        {
            SetRange(yAxis, "Set Y Range");
        }

        private void OnQuit(object sender, System.EventArgs e)
        {
            Close();
        }

        private void OnHelp(object sender, System.EventArgs e)
        {
            AboutDlg dlg = new AboutDlg();
            dlg.Owner = this;
            dlg.Show();
        }


	}
}
