using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.Analysis.Math;

namespace NationalInstruments.Examples.TemperatureSystem
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Splitter mainSplitter;
		private System.Windows.Forms.Panel leftPanel;
		private System.Windows.Forms.Panel rightPanel;
		private System.Windows.Forms.ImageList toolBarImages;
        private System.Windows.Forms.Label onAnalyzeLabel;
        private System.Windows.Forms.Label onAcquireLabel;
        private System.Windows.Forms.Label offAnalyzeLabel;
        private System.Windows.Forms.Label offAquireLabel;
        private NationalInstruments.UI.XYCursor lowerLimitCursor;
        private NationalInstruments.UI.XYCursor upperLimitCursor;
        private NationalInstruments.UI.WindowsForms.Knob upperLimitKnob;
        private NationalInstruments.UI.WindowsForms.Knob lowLimitKnob;
        private NationalInstruments.UI.WindowsForms.Slide updateRateSlide;
        private NationalInstruments.UI.WindowsForms.ScatterGraph temperatureHistogramScatterGraph;
        private NationalInstruments.UI.WindowsForms.WaveformGraph temperatureHistoryWaveformGraph;
        private NationalInstruments.UI.WindowsForms.Thermometer currentTemperatureThermometer;
        private NationalInstruments.UI.WindowsForms.Tank meanTempTank;
        private NationalInstruments.UI.WindowsForms.Tank stdTank;
        private System.Windows.Forms.Timer mainTimer;
		private System.ComponentModel.IContainer components;

        private NationalInstruments.UI.ScatterPlot histogramPlot;
        private NationalInstruments.UI.XAxis histogramXAxis;
        private NationalInstruments.UI.YAxis histogramYAxis;
        private NationalInstruments.UI.WaveformPlot historyPlot;
        private NationalInstruments.UI.XAxis historyXAxis;
        private NationalInstruments.UI.YAxis historyYAxis;

		private NationalInstruments.UI.WindowsForms.NumericEdit maximumBinNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit minimumBinNumericEdit;
		private NationalInstruments.UI.XYRangeAnnotation hotAnnotaion;
		private NationalInstruments.UI.XYRangeAnnotation coldAnnotaion;
		private System.Windows.Forms.GroupBox histogramSettingsGroupBox;
		private System.Windows.Forms.Label maximumBinLabel;
		private System.Windows.Forms.Label minimumBinLabel;
		private System.Windows.Forms.MenuItem fileMenu;
		private System.Windows.Forms.MenuItem acquireMenu;
		private System.Windows.Forms.MenuItem analyzeMenu;
		private System.Windows.Forms.MenuItem viewMenu;
		private System.Windows.Forms.MenuItem toolBarMenu;
		private System.Windows.Forms.MenuItem statusBarMenu;
		private System.Windows.Forms.MenuItem helpMenu;
		private System.Windows.Forms.GroupBox temperatureGroupBox;
		private System.Windows.Forms.MenuItem exitMenu;
		private System.Windows.Forms.MenuItem systemDemoMenu;
		private WaveformPlot analysisPlot;
		private System.Windows.Forms.ToolBarButton analyzeToolBar;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.StatusBar mainStatusBar;
		
		private UtilityHelper utilityHelper;
		private System.Windows.Forms.MenuItem seperatorMenuItem;
		private System.Windows.Forms.ToolBarButton acquireToolBar;
		private NationalInstruments.UI.WindowsForms.Switch acquireSwitch;
		private NationalInstruments.UI.WindowsForms.Switch analyzeSwitch;
		private System.Windows.Forms.ToolBar mainToolBar;
		private string lastStatus;
		private Random random;

		public MainForm()
		{
			InitializeComponent();
            random = new Random();
			analysisPlot = new WaveformPlot();
			analysisPlot.XAxis = new XAxis();
			analysisPlot.YAxis = new YAxis();
			
			upperLimitCursor.YPosition = 85;
			lowerLimitCursor.YPosition = 75;

			coldAnnotaion.RangeFillColor = Color.FromArgb(90, Color.Aqua);
			coldAnnotaion.RangeFillStyle = FillStyle.CreateVerticalGradient(coldAnnotaion.RangeFillColor, Color.Aqua);
			hotAnnotaion.RangeFillColor = Color.FromArgb(90, Color.Red);
			hotAnnotaion.RangeFillStyle = FillStyle.CreateVerticalGradient(Color.Red, hotAnnotaion.RangeFillColor);

			utilityHelper = new UtilityHelper();
			InitializeMenuHelperStrings(mainMenu.MenuItems);
			InitializeToolTips(mainToolBar.Buttons);
			MapToolBarAndMenuItems();

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
            this.acquireToolBar = new System.Windows.Forms.ToolBarButton();
            this.analyzeToolBar = new System.Windows.Forms.ToolBarButton();
            this.toolBarImages = new System.Windows.Forms.ImageList(this.components);
            this.mainStatusBar = new System.Windows.Forms.StatusBar();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.fileMenu = new System.Windows.Forms.MenuItem();
            this.acquireMenu = new System.Windows.Forms.MenuItem();
            this.analyzeMenu = new System.Windows.Forms.MenuItem();
            this.seperatorMenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenu = new System.Windows.Forms.MenuItem();
            this.viewMenu = new System.Windows.Forms.MenuItem();
            this.toolBarMenu = new System.Windows.Forms.MenuItem();
            this.statusBarMenu = new System.Windows.Forms.MenuItem();
            this.helpMenu = new System.Windows.Forms.MenuItem();
            this.systemDemoMenu = new System.Windows.Forms.MenuItem();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.temperatureGroupBox = new System.Windows.Forms.GroupBox();
            this.upperLimitKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.lowLimitKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.histogramSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.minimumBinNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.minimumBinLabel = new System.Windows.Forms.Label();
            this.maximumBinNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.maximumBinLabel = new System.Windows.Forms.Label();
            this.offAquireLabel = new System.Windows.Forms.Label();
            this.offAnalyzeLabel = new System.Windows.Forms.Label();
            this.onAcquireLabel = new System.Windows.Forms.Label();
            this.onAnalyzeLabel = new System.Windows.Forms.Label();
            this.updateRateSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.analyzeSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.acquireSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.mainSplitter = new System.Windows.Forms.Splitter();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.stdTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.meanTempTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.currentTemperatureThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.temperatureHistogramScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.histogramPlot = new NationalInstruments.UI.ScatterPlot();
            this.histogramXAxis = new NationalInstruments.UI.XAxis();
            this.histogramYAxis = new NationalInstruments.UI.YAxis();
            this.temperatureHistoryWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.hotAnnotaion = new NationalInstruments.UI.XYRangeAnnotation();
            this.historyXAxis = new NationalInstruments.UI.XAxis();
            this.historyYAxis = new NationalInstruments.UI.YAxis();
            this.coldAnnotaion = new NationalInstruments.UI.XYRangeAnnotation();
            this.lowerLimitCursor = new NationalInstruments.UI.XYCursor();
            this.historyPlot = new NationalInstruments.UI.WaveformPlot();
            this.upperLimitCursor = new NationalInstruments.UI.XYCursor();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.leftPanel.SuspendLayout();
            this.temperatureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowLimitKnob)).BeginInit();
            this.histogramSettingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumBinNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumBinNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateRateSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzeSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquireSwitch)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanTempTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTemperatureThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureHistogramScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureHistoryWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitCursor)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolBar
            // 
            this.mainToolBar.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.mainToolBar.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this.acquireToolBar,
            this.analyzeToolBar});
            this.mainToolBar.DropDownArrows = true;
            this.mainToolBar.ImageList = this.toolBarImages;
            this.mainToolBar.Location = new System.Drawing.Point(0, 0);
            this.mainToolBar.Name = "mainToolBar";
            this.mainToolBar.ShowToolTips = true;
            this.mainToolBar.Size = new System.Drawing.Size(944, 28);
            this.mainToolBar.TabIndex = 0;
            this.mainToolBar.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.OnToolBarButtonClick);
            // 
            // acquireToolBar
            // 
            this.acquireToolBar.ImageIndex = 0;
            this.acquireToolBar.Pushed = true;
            this.acquireToolBar.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // analyzeToolBar
            // 
            this.analyzeToolBar.ImageIndex = 1;
            this.analyzeToolBar.Pushed = true;
            this.analyzeToolBar.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            // 
            // toolBarImages
            // 
            this.toolBarImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("toolBarImages.ImageStream")));
            this.toolBarImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // mainStatusPanel
            // 
            this.mainStatusBar.Location = new System.Drawing.Point(0, 627);
            this.mainStatusBar.Name = "mainStatusPanel";
            this.mainStatusBar.Size = new System.Drawing.Size(944, 22);
            this.mainStatusBar.TabIndex = 1;
            this.mainStatusBar.Text = "Acquiring...";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenu,
            this.viewMenu,
            this.helpMenu});
            // 
            // fileMenu
            // 
            this.fileMenu.Index = 0;
            this.fileMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.acquireMenu,
            this.analyzeMenu,
            this.seperatorMenuItem,
            this.exitMenu});
            this.fileMenu.Text = "File";
            // 
            // acquireMenu
            // 
            this.acquireMenu.Checked = true;
            this.acquireMenu.Index = 0;
            this.acquireMenu.Text = "Acquire";
            this.acquireMenu.Click += new System.EventHandler(this.AquireMenuClick);
            // 
            // analyzeMenu
            // 
            this.analyzeMenu.Checked = true;
            this.analyzeMenu.Index = 1;
            this.analyzeMenu.Text = "Analyze";
            this.analyzeMenu.Click += new System.EventHandler(this.AnalyzeMenuClick);
            // 
            // seperatorMenuItem
            // 
            this.seperatorMenuItem.Index = 2;
            this.seperatorMenuItem.Text = "-";
            // 
            // exitMenu
            // 
            this.exitMenu.Index = 3;
            this.exitMenu.Text = "Exit";
            this.exitMenu.Click += new System.EventHandler(this.ExitMenuClick);
            // 
            // viewMenu
            // 
            this.viewMenu.Index = 1;
            this.viewMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.toolBarMenu,
            this.statusBarMenu});
            this.viewMenu.Text = "View";
            // 
            // toolBarMenu
            // 
            this.toolBarMenu.Checked = true;
            this.toolBarMenu.Index = 0;
            this.toolBarMenu.Text = "ToolBar";
            this.toolBarMenu.Click += new System.EventHandler(this.ToolBarMenuClick);
            // 
            // statusBarMenu
            // 
            this.statusBarMenu.Checked = true;
            this.statusBarMenu.Index = 1;
            this.statusBarMenu.Text = "Status Bar";
            this.statusBarMenu.Click += new System.EventHandler(this.StatusBarMenuClick);
            // 
            // helpMenu
            // 
            this.helpMenu.Index = 2;
            this.helpMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.systemDemoMenu});
            this.helpMenu.Text = "Help";
            // 
            // systemDemoMenu
            // 
            this.systemDemoMenu.Index = 0;
            this.systemDemoMenu.Text = "About System Demo...";
            this.systemDemoMenu.Click += new System.EventHandler(this.SystemDemoMenuClick);
            // 
            // leftPanel
            // 
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftPanel.Controls.Add(this.temperatureGroupBox);
            this.leftPanel.Controls.Add(this.histogramSettingsGroupBox);
            this.leftPanel.Controls.Add(this.offAquireLabel);
            this.leftPanel.Controls.Add(this.offAnalyzeLabel);
            this.leftPanel.Controls.Add(this.onAcquireLabel);
            this.leftPanel.Controls.Add(this.onAnalyzeLabel);
            this.leftPanel.Controls.Add(this.updateRateSlide);
            this.leftPanel.Controls.Add(this.analyzeSwitch);
            this.leftPanel.Controls.Add(this.acquireSwitch);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 28);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(264, 599);
            this.leftPanel.TabIndex = 2;
            // 
            // temperatureGroupBox
            // 
            this.temperatureGroupBox.Controls.Add(this.upperLimitKnob);
            this.temperatureGroupBox.Controls.Add(this.lowLimitKnob);
            this.temperatureGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.temperatureGroupBox.Location = new System.Drawing.Point(16, 272);
            this.temperatureGroupBox.Name = "temperatureGroupBox";
            this.temperatureGroupBox.Size = new System.Drawing.Size(232, 176);
            this.temperatureGroupBox.TabIndex = 12;
            this.temperatureGroupBox.TabStop = false;
            this.temperatureGroupBox.Text = "Temperature Range";
            // 
            // upperLimitKnob
            // 
            this.upperLimitKnob.AutoDivisionSpacing = false;
            this.upperLimitKnob.Caption = "Upper Limit";
            this.upperLimitKnob.DialColor = System.Drawing.Color.Red;
            this.upperLimitKnob.Location = new System.Drawing.Point(112, 24);
            this.upperLimitKnob.Name = "upperLimitKnob";
            this.upperLimitKnob.Range = new NationalInstruments.UI.Range(70, 90);
            this.upperLimitKnob.Size = new System.Drawing.Size(112, 144);
            this.upperLimitKnob.TabIndex = 4;
            this.upperLimitKnob.Value = 85;
            this.upperLimitKnob.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.upperLimitKnob_AfterChangeValue);
            // 
            // lowLimitknob
            // 
            this.lowLimitKnob.AutoDivisionSpacing = false;
            this.lowLimitKnob.Caption = "Low Limit";
            this.lowLimitKnob.DialColor = System.Drawing.Color.Aqua;
            this.lowLimitKnob.Location = new System.Drawing.Point(8, 24);
            this.lowLimitKnob.Name = "lowLimitknob";
            this.lowLimitKnob.Range = new NationalInstruments.UI.Range(70, 90);
            this.lowLimitKnob.Size = new System.Drawing.Size(112, 144);
            this.lowLimitKnob.TabIndex = 3;
            this.lowLimitKnob.Value = 75;
            this.lowLimitKnob.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.lowLimitknob_AfterChangeValue);
            // 
            // histogramSettingsGroupbox
            // 
            this.histogramSettingsGroupBox.Controls.Add(this.minimumBinNumericEdit);
            this.histogramSettingsGroupBox.Controls.Add(this.minimumBinLabel);
            this.histogramSettingsGroupBox.Controls.Add(this.maximumBinNumericEdit);
            this.histogramSettingsGroupBox.Controls.Add(this.maximumBinLabel);
            this.histogramSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.histogramSettingsGroupBox.Location = new System.Drawing.Point(16, 464);
            this.histogramSettingsGroupBox.Name = "histogramSettingsGroupbox";
            this.histogramSettingsGroupBox.Size = new System.Drawing.Size(232, 100);
            this.histogramSettingsGroupBox.TabIndex = 11;
            this.histogramSettingsGroupBox.TabStop = false;
            this.histogramSettingsGroupBox.Text = "Histogram Settings";
            // 
            // minimumBin
            // 
            this.minimumBinNumericEdit.Enabled = false;
            this.minimumBinNumericEdit.Location = new System.Drawing.Point(96, 24);
            this.minimumBinNumericEdit.Name = "minimumBin";
            this.minimumBinNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.minimumBinNumericEdit.Range = new NationalInstruments.UI.Range(70, double.PositiveInfinity);
            this.minimumBinNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.minimumBinNumericEdit.TabIndex = 10;
            this.minimumBinNumericEdit.Value = 70;
            this.minimumBinNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.MinBinBeforeChange);
            // 
            // minimumBinLabel
            // 
            this.minimumBinLabel.AutoSize = true;
            this.minimumBinLabel.Location = new System.Drawing.Point(16, 24);
            this.minimumBinLabel.Name = "minimumBinLabel";
            this.minimumBinLabel.Size = new System.Drawing.Size(66, 13);
            this.minimumBinLabel.TabIndex = 12;
            this.minimumBinLabel.Text = "Minimum Bin";
            // 
            // maximumBin
            // 
            this.maximumBinNumericEdit.Enabled = false;
            this.maximumBinNumericEdit.Location = new System.Drawing.Point(96, 64);
            this.maximumBinNumericEdit.Name = "maximumBin";
            this.maximumBinNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.maximumBinNumericEdit.Range = new NationalInstruments.UI.Range(double.NegativeInfinity, 90);
            this.maximumBinNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.maximumBinNumericEdit.TabIndex = 9;
            this.maximumBinNumericEdit.Value = 90;
            this.maximumBinNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.MaxBinBeforeChange);
            // 
            // maximumBinLabel
            // 
            this.maximumBinLabel.AutoSize = true;
            this.maximumBinLabel.Location = new System.Drawing.Point(16, 64);
            this.maximumBinLabel.Name = "maximumBinLabel";
            this.maximumBinLabel.Size = new System.Drawing.Size(69, 13);
            this.maximumBinLabel.TabIndex = 11;
            this.maximumBinLabel.Text = "Maximum Bin";
            // 
            // offAquireLabel
            // 
            this.offAquireLabel.AutoSize = true;
            this.offAquireLabel.Location = new System.Drawing.Point(208, 104);
            this.offAquireLabel.Name = "offAquireLabel";
            this.offAquireLabel.Size = new System.Drawing.Size(21, 13);
            this.offAquireLabel.TabIndex = 8;
            this.offAquireLabel.Text = "Off";
            // 
            // offAnalyzeLabel
            // 
            this.offAnalyzeLabel.AutoSize = true;
            this.offAnalyzeLabel.Location = new System.Drawing.Point(88, 104);
            this.offAnalyzeLabel.Name = "offAnalyzeLabel";
            this.offAnalyzeLabel.Size = new System.Drawing.Size(21, 13);
            this.offAnalyzeLabel.TabIndex = 7;
            this.offAnalyzeLabel.Text = "Off";
            // 
            // onAcquireLabel
            // 
            this.onAcquireLabel.AutoSize = true;
            this.onAcquireLabel.Location = new System.Drawing.Point(208, 48);
            this.onAcquireLabel.Name = "onAcquireLabel";
            this.onAcquireLabel.Size = new System.Drawing.Size(21, 13);
            this.onAcquireLabel.TabIndex = 6;
            this.onAcquireLabel.Text = "On";
            // 
            // onAnalyzelabel
            // 
            this.onAnalyzeLabel.AutoSize = true;
            this.onAnalyzeLabel.Location = new System.Drawing.Point(88, 48);
            this.onAnalyzeLabel.Name = "onAnalyzelabel";
            this.onAnalyzeLabel.Size = new System.Drawing.Size(21, 13);
            this.onAnalyzeLabel.TabIndex = 5;
            this.onAnalyzeLabel.Text = "On";
            // 
            // updateRateSlide
            // 
            this.updateRateSlide.AutoDivisionSpacing = false;
            this.updateRateSlide.Caption = "Update Rate (s)";
            this.updateRateSlide.FillMode = NationalInstruments.UI.NumericFillMode.None;
            this.updateRateSlide.Location = new System.Drawing.Point(8, 152);
            this.updateRateSlide.MajorDivisions.Base = 0.05;
            this.updateRateSlide.MajorDivisions.Interval = 0.19;
            this.updateRateSlide.MinorDivisions.Base = 0.05;
            this.updateRateSlide.MinorDivisions.Interval = 0.095;
            this.updateRateSlide.Name = "updateRateSlide";
            this.updateRateSlide.Range = new NationalInstruments.UI.Range(0.05, 1);
            this.updateRateSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.updateRateSlide.Size = new System.Drawing.Size(240, 96);
            this.updateRateSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip;
            this.updateRateSlide.TabIndex = 2;
            this.updateRateSlide.Value = 0.07;
            this.updateRateSlide.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.updateRateSlide_AfterChangeValue);
            // 
            // analyzeSwitch
            // 
            this.analyzeSwitch.Caption = "Analyze";
            this.analyzeSwitch.Location = new System.Drawing.Point(16, 16);
            this.analyzeSwitch.Name = "analyzeSwitch";
            this.analyzeSwitch.Size = new System.Drawing.Size(64, 120);
            this.analyzeSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide3D;
            this.analyzeSwitch.TabIndex = 1;
            this.analyzeSwitch.Value = true;
            this.analyzeSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.analysisSwitch_StateChanged);
            // 
            // acquireSwitch
            // 
            this.acquireSwitch.Caption = "Acquire";
            this.acquireSwitch.Location = new System.Drawing.Point(136, 16);
            this.acquireSwitch.Name = "acquireSwitch";
            this.acquireSwitch.Size = new System.Drawing.Size(64, 120);
            this.acquireSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalSlide3D;
            this.acquireSwitch.TabIndex = 0;
            this.acquireSwitch.Value = true;
            this.acquireSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.aquireSwitch_StateChanged);
            // 
            // splitter1
            // 
            this.mainSplitter.Location = new System.Drawing.Point(264, 28);
            this.mainSplitter.Name = "splitter1";
            this.mainSplitter.Size = new System.Drawing.Size(3, 599);
            this.mainSplitter.TabIndex = 3;
            this.mainSplitter.TabStop = false;
            // 
            // rightPanel
            // 
            this.rightPanel.AutoScroll = true;
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightPanel.Controls.Add(this.stdTank);
            this.rightPanel.Controls.Add(this.meanTempTank);
            this.rightPanel.Controls.Add(this.currentTemperatureThermometer);
            this.rightPanel.Controls.Add(this.temperatureHistogramScatterGraph);
            this.rightPanel.Controls.Add(this.temperatureHistoryWaveformGraph);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(267, 28);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(677, 599);
            this.rightPanel.TabIndex = 4;
            // 
            // stdTank
            // 
            this.stdTank.Caption = "Std Dev";
            this.stdTank.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdTank.Location = new System.Drawing.Point(584, 344);
            this.stdTank.Name = "stdTank";
            this.stdTank.Size = new System.Drawing.Size(64, 224);
            this.stdTank.TabIndex = 4;
            this.stdTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D;
            // 
            // meanTemptank
            // 
            this.meanTempTank.Caption = "Mean Temp";
            this.meanTempTank.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanTempTank.Location = new System.Drawing.Point(512, 344);
            this.meanTempTank.Name = "meanTemptank";
            this.meanTempTank.Range = new NationalInstruments.UI.Range(70, 90);
            this.meanTempTank.Size = new System.Drawing.Size(64, 224);
            this.meanTempTank.TabIndex = 3;
            this.meanTempTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D;
            this.meanTempTank.Value = 70;
            // 
            // currentTemperatureThermometer
            // 
            this.currentTemperatureThermometer.Caption = "Currrent Temp";
            this.currentTemperatureThermometer.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTemperatureThermometer.Location = new System.Drawing.Point(584, 32);
            this.currentTemperatureThermometer.Name = "currentTemperatureThermometer";
            this.currentTemperatureThermometer.Range = new NationalInstruments.UI.Range(70, 90);
            this.currentTemperatureThermometer.Size = new System.Drawing.Size(72, 280);
            this.currentTemperatureThermometer.TabIndex = 2;
            this.currentTemperatureThermometer.Value = 70;
            // 
            // temperatureHistogramGraph
            // 
            this.temperatureHistogramScatterGraph.Border = NationalInstruments.UI.Border.ThickFrame3D;
            this.temperatureHistogramScatterGraph.Caption = "Temperature Histogram";
            this.temperatureHistogramScatterGraph.Location = new System.Drawing.Point(24, 336);
            this.temperatureHistogramScatterGraph.Name = "temperatureHistogramGraph";
            this.temperatureHistogramScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.histogramPlot});
            this.temperatureHistogramScatterGraph.Size = new System.Drawing.Size(456, 232);
            this.temperatureHistogramScatterGraph.TabIndex = 1;
            this.temperatureHistogramScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.histogramXAxis});
            this.temperatureHistogramScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.histogramYAxis});
            // 
            // histogramPlot
            // 
            this.histogramPlot.FillMode = NationalInstruments.UI.PlotFillMode.FillAndBins;
            this.histogramPlot.FillToBaseColor = System.Drawing.Color.DeepSkyBlue;
            this.histogramPlot.FillToBaseStyle = NationalInstruments.UI.FillStyle.VerticalGradient;
            this.histogramPlot.LineColor = System.Drawing.Color.Aqua;
            this.histogramPlot.LineStep = NationalInstruments.UI.LineStep.CenteredXYStep;
            this.histogramPlot.LineToBaseColor = System.Drawing.Color.Aqua;
            this.histogramPlot.XAxis = this.histogramXAxis;
            this.histogramPlot.YAxis = this.histogramYAxis;
            // 
            // histogramXAxis
            // 
            this.histogramXAxis.AutoSpacing = false;
            this.histogramXAxis.MinorDivisions.TickVisible = true;
            this.histogramXAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.histogramXAxis.Range = new NationalInstruments.UI.Range(65, 95);
            // 
            // histogramYAxis
            // 
            this.histogramYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            // 
            // temperatureHistoryGraph
            // 
            this.temperatureHistoryWaveformGraph.Annotations.AddRange(new NationalInstruments.UI.XYAnnotation[] {
            this.hotAnnotaion,
            this.coldAnnotaion});
            this.temperatureHistoryWaveformGraph.Border = NationalInstruments.UI.Border.ThickFrame3D;
            this.temperatureHistoryWaveformGraph.Caption = "Temperature History";
            this.temperatureHistoryWaveformGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
            this.lowerLimitCursor,
            this.upperLimitCursor});
            this.temperatureHistoryWaveformGraph.Location = new System.Drawing.Point(24, 24);
            this.temperatureHistoryWaveformGraph.Name = "temperatureHistoryGraph";
            this.temperatureHistoryWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.historyPlot});
            this.temperatureHistoryWaveformGraph.Size = new System.Drawing.Size(536, 288);
            this.temperatureHistoryWaveformGraph.TabIndex = 0;
            this.temperatureHistoryWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.historyXAxis});
            this.temperatureHistoryWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.historyYAxis});
            // 
            // hotAnnotaion
            // 
            this.hotAnnotaion.ArrowVisible = false;
            this.hotAnnotaion.Caption = "Hot";
            this.hotAnnotaion.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopCenter, 0F, 5F);
            this.hotAnnotaion.RangeFillColor = System.Drawing.Color.Red;
            this.hotAnnotaion.XAxis = this.historyXAxis;
            this.hotAnnotaion.XRange = NationalInstruments.UI.Range.All;
            this.hotAnnotaion.YAxis = this.historyYAxis;
            this.hotAnnotaion.YRange = new NationalInstruments.UI.Range(85, double.PositiveInfinity);
            // 
            // historyXAxis
            // 
            this.historyXAxis.AutoMinorDivisionFrequency = 4;
            this.historyXAxis.MajorDivisions.GridVisible = true;
            this.historyXAxis.MinorDivisions.GridVisible = true;
            this.historyXAxis.Mode = NationalInstruments.UI.AxisMode.StripChart;
            this.historyXAxis.Range = new NationalInstruments.UI.Range(0, 100);
            // 
            // historyYAxis
            // 
            this.historyYAxis.AutoMinorDivisionFrequency = 4;
            this.historyYAxis.MajorDivisions.GridVisible = true;
            this.historyYAxis.MinorDivisions.GridVisible = true;
            this.historyYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.historyYAxis.Range = new NationalInstruments.UI.Range(70, 90);
            // 
            // coldAnnotaion
            // 
            this.coldAnnotaion.ArrowVisible = false;
            this.coldAnnotaion.Caption = "Cold";
            this.coldAnnotaion.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.BottomCenter, 0F, -5F);
            this.coldAnnotaion.RangeFillColor = System.Drawing.Color.Aqua;
            this.coldAnnotaion.XAxis = this.historyXAxis;
            this.coldAnnotaion.XRange = NationalInstruments.UI.Range.All;
            this.coldAnnotaion.YAxis = this.historyYAxis;
            this.coldAnnotaion.YRange = new NationalInstruments.UI.Range(double.NegativeInfinity, 75);
            // 
            // lowerLimitCursor
            // 
            this.lowerLimitCursor.Color = System.Drawing.Color.Aqua;
            this.lowerLimitCursor.Plot = this.historyPlot;
            this.lowerLimitCursor.PointSize = new System.Drawing.Size(0, 0);
            this.lowerLimitCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating;
            this.lowerLimitCursor.VerticalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None;
            this.lowerLimitCursor.YPosition = 75;
            this.lowerLimitCursor.BeforeMove += new NationalInstruments.UI.BeforeMoveXYCursorEventHandler(this.LowerCursorBeforeMoved);
            // 
            // historyPlot
            // 
            this.historyPlot.LineColor = System.Drawing.Color.White;
            this.historyPlot.LineWidth = 2F;
            this.historyPlot.ToolTipsEnabled = true;
            this.historyPlot.XAxis = this.historyXAxis;
            this.historyPlot.YAxis = this.historyYAxis;
            // 
            // upperLimitCursor
            // 
            this.upperLimitCursor.Color = System.Drawing.Color.Red;
            this.upperLimitCursor.Plot = this.historyPlot;
            this.upperLimitCursor.PointSize = new System.Drawing.Size(0, 0);
            this.upperLimitCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating;
            this.upperLimitCursor.VerticalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None;
            this.upperLimitCursor.YPosition = 85;
            this.upperLimitCursor.BeforeMove += new NationalInstruments.UI.BeforeMoveXYCursorEventHandler(this.UpperCursorBeforeMoved);
            // 
            // mainTimer
            // 
            this.mainTimer.Enabled = true;
            this.mainTimer.Interval = 70;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(944, 649);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.mainSplitter);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.mainStatusBar);
            this.Controls.Add(this.mainToolBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Temperature System Demo";
            this.MenuStart += new System.EventHandler(this.OnMenuStart);
            this.MenuComplete += new System.EventHandler(this.OnMenuComplete);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.temperatureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowLimitKnob)).EndInit();
            this.histogramSettingsGroupBox.ResumeLayout(false);
            this.histogramSettingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimumBinNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumBinNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateRateSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzeSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acquireSwitch)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stdTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanTempTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTemperatureThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureHistogramScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureHistoryWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerLimitCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperLimitCursor)).EndInit();
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
				if(item.Text != "-")
				{
					utilityHelper.AddMenuString(item);
					item.Select += new EventHandler(OnMenuSelect);
				}

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

		private void MapToolBarAndMenuItems()
		{
			utilityHelper.MapMenuAndToolBar(acquireToolBar, acquireMenu);
			utilityHelper.MapMenuAndToolBar(analyzeToolBar, analyzeMenu);
		}

		private void OnMenuSelect(object sender, EventArgs e)
		{
			mainStatusBar.Text = utilityHelper.GetMenuString(sender);
		}


		private void OnMenuStart(object sender, System.EventArgs e)
		{
			lastStatus = mainStatusBar.Text;
		}

		private void OnMenuComplete(object sender, System.EventArgs e)
		{
			mainStatusBar.Text = lastStatus;
		}

		private void OnToolBarButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			MenuItem item = utilityHelper.FromToolBarButton(e.Button);
			item.PerformClick();
		}

        private void mainTimer_Tick(object sender, System.EventArgs e)
        {
            //Get random new temperature between 70 and 90
            double currentTemp = (random.NextDouble() * 20) + 70;
            currentTemperatureThermometer.Value = currentTemp;

            //update TemperatureGraph
            temperatureHistoryWaveformGraph.PlotYAppend(currentTemp);

			UpdateAnalysis(currentTemp);
        }

		private void UpdateAnalysis(double currentTemp)
		{
			if(analyzeSwitch.Value)
			{
				analysisPlot.PlotYAppend(currentTemp);
				double[] analysisPoints = analysisPlot.GetYData();

				double[] centerValues;

				int[] histogram = Statistics.Histogram(analysisPoints, minimumBinNumericEdit.Value, maximumBinNumericEdit.Value, 25, out centerValues);
				double[] histogramData = (double [])DataConverter.Convert(histogram, typeof(double[]));

				temperatureHistogramScatterGraph.PlotXY(centerValues, histogramData);
				double maxValue = ArrayOperation.GetMax(histogramData);
				if(maxValue > 0)
					histogramYAxis.Range = new Range(0, maxValue);


				stdTank.Value = Statistics.StandardDeviation(analysisPoints);
				meanTempTank.Value = Statistics.Mean(analysisPoints);

			}
		}

        private void updateRateSlide_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            mainTimer.Interval = (int)(e.NewValue * 1000);
        }

        private void aquireSwitch_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            mainTimer.Enabled = acquireSwitch.Value;
            
			if(acquireSwitch.Value)
			{
				mainStatusBar.Text = "Acquiring...";
				ClearHistogramData();
			}
			else
			{
				mainStatusBar.Text = "Ready.";
			}

			if(!(e.Action == NationalInstruments.UI.Action.Programmatic))
				acquireMenu.PerformClick();
        }

        private void analysisSwitch_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
			ClearHistogramData();
			if(!(e.Action == NationalInstruments.UI.Action.Programmatic))
				analyzeMenu.PerformClick();

        }

        private void ClearHistogramData()
        {
			if(analyzeSwitch.Value)
			{
				minimumBinNumericEdit.Enabled = false;
				maximumBinNumericEdit.Enabled = false;

				temperatureHistogramScatterGraph.ClearData();
				analysisPlot.ClearData();
				stdTank.Value = stdTank.Range.Minimum;
				meanTempTank.Value = meanTempTank.Range.Minimum;
			}
			else
			{
				minimumBinNumericEdit.Enabled = true;
				maximumBinNumericEdit.Enabled = true;

			}
        }

		private void LowerCursorBeforeMoved(object sender, NationalInstruments.UI.BeforeMoveXYCursorEventArgs e)
		{
			if(e.YPosition > upperLimitCursor.YPosition)
			{
				e.Cancel = true;
			}
			else
			{
				coldAnnotaion.YRange = new Range(coldAnnotaion.YRange.Minimum, e.YPosition);
				lowLimitKnob.Value = e.YPosition;
			}
		}

		private void UpperCursorBeforeMoved(object sender, NationalInstruments.UI.BeforeMoveXYCursorEventArgs e)
		{
			if(e.YPosition < lowerLimitCursor.YPosition)
			{
				e.Cancel = true;
			}
			else
			{
				hotAnnotaion.YRange = new Range(e.YPosition, hotAnnotaion.YRange.Maximum);
				upperLimitKnob.Value = e.YPosition;
			}
		}

		private void lowLimitknob_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
		{
			lowerLimitCursor.YPosition = lowLimitKnob.Value;
		}

		private void upperLimitKnob_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
		{
			upperLimitCursor.YPosition = upperLimitKnob.Value;
		
		}

		private void AquireMenuClick(object sender, System.EventArgs e)
		{
			acquireMenu.Checked = !acquireMenu.Checked;
			acquireSwitch.Value = acquireMenu.Checked;
			ToolBarButton button = utilityHelper.FromMenuItem(acquireMenu);
			button.Pushed = acquireMenu.Checked;

		}

		private void AnalyzeMenuClick(object sender, System.EventArgs e)
		{
			analyzeMenu.Checked = !analyzeMenu.Checked;
			analyzeSwitch.Value = analyzeMenu.Checked;
			ToolBarButton button = utilityHelper.FromMenuItem(analyzeMenu);
			button.Pushed = analyzeMenu.Checked;
		}

		private void ToolBarMenuClick(object sender, System.EventArgs e)
		{
			toolBarMenu.Checked = !toolBarMenu.Checked;
			mainToolBar.Visible = toolBarMenu.Checked;
		}

		private void StatusBarMenuClick(object sender, System.EventArgs e)
		{
			statusBarMenu.Checked = !statusBarMenu.Checked;
			mainStatusBar.Visible = statusBarMenu.Checked;
		}

		private void ExitMenuClick(object sender, System.EventArgs e)
		{
			Close();
		}

		private void SystemDemoMenuClick(object sender, System.EventArgs e)
		{
			AboutDlg dlg = new AboutDlg();
			dlg.ShowDialog();
		}

		private void MinBinBeforeChange(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
		{
			if(e.NewValue >= maximumBinNumericEdit.Value)
				e.Cancel = true;
		
		}

		private void MaxBinBeforeChange(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
		{
			if(e.NewValue <= minimumBinNumericEdit.Value)
				e.Cancel = true;
		
		}

	}
}
