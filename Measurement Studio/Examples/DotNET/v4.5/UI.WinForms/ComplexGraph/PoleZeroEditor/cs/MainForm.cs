using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.PoleZeroEditor
{
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ContextMenu plotContextMenu;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem selectPolesMenu;
		private NationalInstruments.UI.ComplexPlot zerosPlot;
		private System.Windows.Forms.MenuItem selectZerosMenu;
		private System.Windows.Forms.ContextMenu selectionMenu;
		private System.Windows.Forms.MenuItem selectOutsideMenu;
		private System.Windows.Forms.MenuItem selectRightMenu;
		private NationalInstruments.UI.ComplexPlot polePlot;
		private System.Windows.Forms.Button addPoleButton;
		private System.Windows.Forms.DataGrid poleDataGrid;
		private System.Windows.Forms.DataGrid zeroDataGrid;
		private System.Windows.Forms.Button addZeroButton;
		private NationalInstruments.UI.WindowsForms.ComplexGraph poleZeroComplexGraph;
		private System.Windows.Forms.Label samplingFrequencyLabel;
		private System.Windows.Forms.Label numberOfPointsLabel;
		private System.Windows.Forms.Label gainLabel;
		private System.Windows.Forms.GroupBox poleZeroEditorGroupBox;
		private NationalInstruments.UI.ComplexXAxis complexXAxis;
		private NationalInstruments.UI.ComplexYAxis complexYAxis;
		private NationalInstruments.UI.WindowsForms.NumericEdit gainNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit samplingFrequencyNumericEdit;
		private NationalInstruments.UI.WindowsForms.NumericEdit numberOfPointsNumericEdit;
		private NationalInstruments.UI.WindowsForms.ScatterGraph magnitudeSpectrumScatterGraph;
		private NationalInstruments.UI.ScatterPlot magnitudePlot;
		private System.Windows.Forms.GroupBox filterGroupBox;
		private NationalInstruments.UI.LegendItem UnitCircleLegendItem;
		private NationalInstruments.UI.LegendItem polesLegendItem;
		private NationalInstruments.UI.LegendItem zerosLegendItem;
		private NationalInstruments.UI.WindowsForms.Legend poleZeroEditorLegend;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.MenuItem exitMenuItem;
		private System.Windows.Forms.MenuItem selectPolesMenuItem;
		private System.Windows.Forms.MenuItem selectZerosMenuItem;
		private System.Windows.Forms.MenuItem selectInsideUnitCircleMenuItem;
		private System.Windows.Forms.MenuItem selectOutsideUnitCircleMenuItem;
		private System.Windows.Forms.MenuItem selectAboveRealAxisMenuItem;
		private System.Windows.Forms.MenuItem selectBelowRealAxisMenuItem;
		private System.Windows.Forms.MenuItem selectLeftHalfMenuItem;
		private System.Windows.Forms.MenuItem selectRightHalfMenuItem;
		private System.Windows.Forms.MenuItem ActionMenuItem;
		private System.Windows.Forms.MenuItem helpMenuItem;
		private System.Windows.Forms.MenuItem editorHelpMenuItem;
		private System.Windows.Forms.MenuItem selectInsideMenuItem;
		private System.Windows.Forms.MenuItem menuItemSelectAbove;
		private System.Windows.Forms.MenuItem menuItemSelectBelow;
		private System.Windows.Forms.MenuItem menuSelectLeftHalf;
		private System.Windows.Forms.MenuItem invertRealContextMenuItem;
		private System.Windows.Forms.MenuItem invertImaginaryContextMenuItem;
		private System.Windows.Forms.MenuItem mirrorImaginaryContextMenuItem;
		private System.Windows.Forms.MenuItem mirrorRealContextMenuItem;
		private System.Windows.Forms.MenuItem removeContextMenuItem;
		private System.Windows.Forms.MenuItem mirrorRealMenuItem;
		private System.Windows.Forms.MenuItem mirrorImaginaryMenuItem;
		private System.Windows.Forms.MenuItem invertRealMenuItem;
		private System.Windows.Forms.MenuItem invertImaginaryMenuItem;
		private System.Windows.Forms.MenuItem removePoleZeroMenuItem;
		private System.Windows.Forms.MenuItem selectMenuItem;
		private System.Windows.Forms.Button hideShowButton;
		private NationalInstruments.UI.XAxis frequencyXAxis;
		private NationalInstruments.UI.YAxis magnitudeYAxis;
		private System.Windows.Forms.MenuItem editorMenuItem;
		private System.Windows.Forms.Panel parametersPanel;
		private System.Windows.Forms.Panel dataGridPanel;

		private bool isMoving;
		private bool multipleSelectPressed;
		private ArrayList selectedPoles;
		private ArrayList selectedZeros;
		private ArrayList polesData;
		private ArrayList zerosData;
		private ComplexPlot selectedPlot;
		private Size LargeFormSize;
		private Size SmallFormSize;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitMagnitudeCircleAnnotation;

		private bool showFilterCharacterictics;

		public MainForm()
		{
			InitializeComponent();

			magnitudeYAxis.Range = new Range(0, 10);

			polesData = new ArrayList();
			zerosData = new ArrayList();

			selectedPoles = new ArrayList();
			selectedZeros = new ArrayList();

			poleDataGrid.Enabled = false;
			zeroDataGrid.Enabled = false;

			SetupDataGrid(poleDataGrid);
			SetupDataGrid(zeroDataGrid);

			LargeFormSize = this.ClientSize;
			SmallFormSize = new Size(this.ClientSize.Width, this.ClientSize.Height - filterGroupBox.Height);
			showFilterCharacterictics = true;
		}

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.editorMenuItem = new System.Windows.Forms.MenuItem();
			this.exitMenuItem = new System.Windows.Forms.MenuItem();
			this.magnitudePlot = new NationalInstruments.UI.ScatterPlot();
			this.frequencyXAxis = new NationalInstruments.UI.XAxis();
			this.magnitudeYAxis = new NationalInstruments.UI.YAxis();
			this.invertRealContextMenuItem = new System.Windows.Forms.MenuItem();
			this.invertImaginaryContextMenuItem = new System.Windows.Forms.MenuItem();
			this.mirrorImaginaryContextMenuItem = new System.Windows.Forms.MenuItem();
			this.plotContextMenu = new System.Windows.Forms.ContextMenu();
			this.mirrorRealContextMenuItem = new System.Windows.Forms.MenuItem();
			this.removeContextMenuItem = new System.Windows.Forms.MenuItem();
			this.filterGroupBox = new System.Windows.Forms.GroupBox();
			this.magnitudeSpectrumScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
			this.parametersPanel = new System.Windows.Forms.Panel();
			this.samplingFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.samplingFrequencyLabel = new System.Windows.Forms.Label();
			this.numberOfPointsNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.numberOfPointsLabel = new System.Windows.Forms.Label();
			this.gainNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.gainLabel = new System.Windows.Forms.Label();
			this.mainMenu = new System.Windows.Forms.MainMenu();
			this.selectMenuItem = new System.Windows.Forms.MenuItem();
			this.selectPolesMenuItem = new System.Windows.Forms.MenuItem();
			this.selectZerosMenuItem = new System.Windows.Forms.MenuItem();
			this.selectInsideUnitCircleMenuItem = new System.Windows.Forms.MenuItem();
			this.selectOutsideUnitCircleMenuItem = new System.Windows.Forms.MenuItem();
			this.selectAboveRealAxisMenuItem = new System.Windows.Forms.MenuItem();
			this.selectBelowRealAxisMenuItem = new System.Windows.Forms.MenuItem();
			this.selectLeftHalfMenuItem = new System.Windows.Forms.MenuItem();
			this.selectRightHalfMenuItem = new System.Windows.Forms.MenuItem();
			this.ActionMenuItem = new System.Windows.Forms.MenuItem();
			this.mirrorRealMenuItem = new System.Windows.Forms.MenuItem();
			this.mirrorImaginaryMenuItem = new System.Windows.Forms.MenuItem();
			this.invertRealMenuItem = new System.Windows.Forms.MenuItem();
			this.invertImaginaryMenuItem = new System.Windows.Forms.MenuItem();
			this.removePoleZeroMenuItem = new System.Windows.Forms.MenuItem();
			this.helpMenuItem = new System.Windows.Forms.MenuItem();
			this.editorHelpMenuItem = new System.Windows.Forms.MenuItem();
			this.selectPolesMenu = new System.Windows.Forms.MenuItem();
			this.zerosPlot = new NationalInstruments.UI.ComplexPlot();
			this.complexXAxis = new NationalInstruments.UI.ComplexXAxis();
			this.complexYAxis = new NationalInstruments.UI.ComplexYAxis();
			this.selectInsideMenuItem = new System.Windows.Forms.MenuItem();
			this.selectZerosMenu = new System.Windows.Forms.MenuItem();
			this.selectionMenu = new System.Windows.Forms.ContextMenu();
			this.selectOutsideMenu = new System.Windows.Forms.MenuItem();
			this.menuItemSelectAbove = new System.Windows.Forms.MenuItem();
			this.menuItemSelectBelow = new System.Windows.Forms.MenuItem();
			this.menuSelectLeftHalf = new System.Windows.Forms.MenuItem();
			this.selectRightMenu = new System.Windows.Forms.MenuItem();
			this.polePlot = new NationalInstruments.UI.ComplexPlot();
			this.poleZeroEditorGroupBox = new System.Windows.Forms.GroupBox();
			this.poleZeroComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
			this.unitMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.dataGridPanel = new System.Windows.Forms.Panel();
			this.addPoleButton = new System.Windows.Forms.Button();
			this.addZeroButton = new System.Windows.Forms.Button();
			this.poleDataGrid = new System.Windows.Forms.DataGrid();
			this.zeroDataGrid = new System.Windows.Forms.DataGrid();
			this.poleZeroEditorLegend = new NationalInstruments.UI.WindowsForms.Legend();
			this.UnitCircleLegendItem = new NationalInstruments.UI.LegendItem();
			this.polesLegendItem = new NationalInstruments.UI.LegendItem();
			this.zerosLegendItem = new NationalInstruments.UI.LegendItem();
			this.hideShowButton = new System.Windows.Forms.Button();
			this.filterGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.magnitudeSpectrumScatterGraph)).BeginInit();
			this.parametersPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.samplingFrequencyNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numberOfPointsNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gainNumericEdit)).BeginInit();
			this.poleZeroEditorGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.poleZeroComplexGraph)).BeginInit();
			this.dataGridPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.poleDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.zeroDataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.poleZeroEditorLegend)).BeginInit();
			this.SuspendLayout();
			// 
			// editorMenuItem
			// 
			this.editorMenuItem.Index = 0;
			this.editorMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.exitMenuItem});
			this.editorMenuItem.Text = "&Editor";
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Index = 0;
			this.exitMenuItem.Text = "E&xit";
			this.exitMenuItem.Click += new System.EventHandler(this.OnMenuItemExitClick);
			// 
			// magnitudePlot
			// 
			this.magnitudePlot.ProcessSpecialValues = true;
			this.magnitudePlot.XAxis = this.frequencyXAxis;
			this.magnitudePlot.YAxis = this.magnitudeYAxis;
			// 
			// frequencyXAxis
			// 
			this.frequencyXAxis.Caption = "Frequency (Hz)";
			this.frequencyXAxis.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S\'Hz\'");
			// 
			// magnitudeYAxis
			// 
			this.magnitudeYAxis.Caption = "Magnitude (db)";
			this.magnitudeYAxis.MajorDivisions.GridVisible = true;
			// 
			// invertRealContextMenuItem
			// 
			this.invertRealContextMenuItem.Index = 2;
			this.invertRealContextMenuItem.Text = "Invert about Real Axis";
			this.invertRealContextMenuItem.Click += new System.EventHandler(this.OnMenuItemInvertRealClick);
			// 
			// invertImaginaryContextMenuItem
			// 
			this.invertImaginaryContextMenuItem.Index = 3;
			this.invertImaginaryContextMenuItem.Text = "Invert about Imaginary Axis";
			this.invertImaginaryContextMenuItem.Click += new System.EventHandler(this.OnMenuItemInvertImaginaryClick);
			// 
			// mirrorImaginaryContextMenuItem
			// 
			this.mirrorImaginaryContextMenuItem.Index = 1;
			this.mirrorImaginaryContextMenuItem.Text = "Mirror about Imaginary Axis";
			this.mirrorImaginaryContextMenuItem.Click += new System.EventHandler(this.OnMenuItemMirrorImaginaryClick);
			// 
			// plotContextMenu
			// 
			this.plotContextMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																							this.mirrorRealContextMenuItem,
																							this.mirrorImaginaryContextMenuItem,
																							this.invertRealContextMenuItem,
																							this.invertImaginaryContextMenuItem,
																							this.removeContextMenuItem});
			// 
			// mirrorRealContextMenuItem
			// 
			this.mirrorRealContextMenuItem.Index = 0;
			this.mirrorRealContextMenuItem.Text = "Mirror about Real Axis";
			this.mirrorRealContextMenuItem.Click += new System.EventHandler(this.OnMenuItemMirrorRealClick);
			// 
			// removeContextMenuItem
			// 
			this.removeContextMenuItem.Index = 4;
			this.removeContextMenuItem.Text = "Remove";
			this.removeContextMenuItem.Click += new System.EventHandler(this.OnMenuItemRemovePoleZeroClick);
			// 
			// filterGroupBox
			//
            this.filterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left))); 
			this.filterGroupBox.Controls.Add(this.magnitudeSpectrumScatterGraph);
			this.filterGroupBox.Controls.Add(this.parametersPanel);
			this.filterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.filterGroupBox.Location = new System.Drawing.Point(5, 370);
			this.filterGroupBox.Name = "filterGroupBox";
			this.filterGroupBox.Size = new System.Drawing.Size(690, 302);
			this.filterGroupBox.TabIndex = 2;
			this.filterGroupBox.TabStop = false;
			this.filterGroupBox.Text = "Filter Characteristics";
			// 
			// magnitudeSpectrumScatterGraph
			// 
			this.magnitudeSpectrumScatterGraph.Border = NationalInstruments.UI.Border.SolidBlack;
			this.magnitudeSpectrumScatterGraph.Caption = "Magnitude Spectrum";
			this.magnitudeSpectrumScatterGraph.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.magnitudeSpectrumScatterGraph.Dock = System.Windows.Forms.DockStyle.Top;
			this.magnitudeSpectrumScatterGraph.InteractionMode = ((NationalInstruments.UI.GraphInteractionModes)(((((NationalInstruments.UI.GraphInteractionModes.ZoomX | NationalInstruments.UI.GraphInteractionModes.ZoomY) 
				| NationalInstruments.UI.GraphInteractionModes.ZoomAroundPoint) 
				| NationalInstruments.UI.GraphInteractionModes.DragCursor) 
				| NationalInstruments.UI.GraphInteractionModes.DragAnnotationCaption)));
			this.magnitudeSpectrumScatterGraph.Location = new System.Drawing.Point(3, 56);
			this.magnitudeSpectrumScatterGraph.Name = "magnitudeSpectrumScatterGraph";
			this.magnitudeSpectrumScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
																										   this.magnitudePlot});
			this.magnitudeSpectrumScatterGraph.Size = new System.Drawing.Size(684, 246);
			this.magnitudeSpectrumScatterGraph.TabIndex = 1;
			this.magnitudeSpectrumScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
																									 this.frequencyXAxis});
			this.magnitudeSpectrumScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
																									 this.magnitudeYAxis});
			// 
			// parametersPanel
			// 
			this.parametersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.parametersPanel.Controls.Add(this.samplingFrequencyNumericEdit);
			this.parametersPanel.Controls.Add(this.samplingFrequencyLabel);
			this.parametersPanel.Controls.Add(this.numberOfPointsNumericEdit);
			this.parametersPanel.Controls.Add(this.numberOfPointsLabel);
			this.parametersPanel.Controls.Add(this.gainNumericEdit);
			this.parametersPanel.Controls.Add(this.gainLabel);
			this.parametersPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.parametersPanel.Location = new System.Drawing.Point(3, 16);
			this.parametersPanel.Name = "parametersPanel";
			this.parametersPanel.Size = new System.Drawing.Size(684, 40);
			this.parametersPanel.TabIndex = 0;
			// 
			// samplingFrequencyNumericEdit
			// 
			this.samplingFrequencyNumericEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.samplingFrequencyNumericEdit.Location = new System.Drawing.Point(134, 8);
			this.samplingFrequencyNumericEdit.Name = "samplingFrequencyNumericEdit";
			this.samplingFrequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.samplingFrequencyNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.samplingFrequencyNumericEdit.Size = new System.Drawing.Size(80, 22);
			this.samplingFrequencyNumericEdit.TabIndex = 1;
			this.samplingFrequencyNumericEdit.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged;
			this.samplingFrequencyNumericEdit.Value = 4800;
			this.samplingFrequencyNumericEdit.ValueChanged += new System.EventHandler(this.OnFilterCharacteristicsNumericEditsValueChanged);
			// 
			// samplingFrequencyLabel
			// 
			this.samplingFrequencyLabel.AutoSize = true;
			this.samplingFrequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.samplingFrequencyLabel.Location = new System.Drawing.Point(8, 11);
			this.samplingFrequencyLabel.Name = "samplingFrequencyLabel";
			this.samplingFrequencyLabel.Size = new System.Drawing.Size(133, 16);
			this.samplingFrequencyLabel.TabIndex = 0;
			this.samplingFrequencyLabel.Text = "Sampling Frequency(Hz):";
			// 
			// numberOfPointsNumericEdit
			// 
			this.numberOfPointsNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
			this.numberOfPointsNumericEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.numberOfPointsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
			this.numberOfPointsNumericEdit.Location = new System.Drawing.Point(360, 8);
			this.numberOfPointsNumericEdit.Name = "numberOfPointsNumericEdit";
			this.numberOfPointsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.numberOfPointsNumericEdit.Range = new NationalInstruments.UI.Range(1, System.Double.PositiveInfinity);
			this.numberOfPointsNumericEdit.Size = new System.Drawing.Size(80, 22);
			this.numberOfPointsNumericEdit.TabIndex = 3;
			this.numberOfPointsNumericEdit.ValidationMode = NationalInstruments.UI.NumericEditValidationMode.WhenChanged;
			this.numberOfPointsNumericEdit.Value = 256;
			this.numberOfPointsNumericEdit.ValueChanged += new System.EventHandler(this.OnFilterCharacteristicsNumericEditsValueChanged);
			// 
			// numberOfPointsLabel
			// 
			this.numberOfPointsLabel.AutoSize = true;
			this.numberOfPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.numberOfPointsLabel.Location = new System.Drawing.Point(264, 11);
			this.numberOfPointsLabel.Name = "numberOfPointsLabel";
			this.numberOfPointsLabel.Size = new System.Drawing.Size(95, 16);
			this.numberOfPointsLabel.TabIndex = 2;
			this.numberOfPointsLabel.Text = "Number of Points:";
			// 
			// gainNumericEdit
			// 
			this.gainNumericEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gainNumericEdit.Location = new System.Drawing.Point(592, 8);
			this.gainNumericEdit.Name = "gainNumericEdit";
			this.gainNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.gainNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.gainNumericEdit.Size = new System.Drawing.Size(80, 22);
			this.gainNumericEdit.TabIndex = 5;
			this.gainNumericEdit.Value = 1;
			this.gainNumericEdit.ValueChanged += new System.EventHandler(this.OnFilterCharacteristicsNumericEditsValueChanged);
			// 
			// gainLabel
			// 
			this.gainLabel.AutoSize = true;
			this.gainLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gainLabel.Location = new System.Drawing.Point(552, 10);
			this.gainLabel.Name = "gainLabel";
			this.gainLabel.Size = new System.Drawing.Size(31, 16);
			this.gainLabel.TabIndex = 4;
			this.gainLabel.Text = "Gain:";
			// 
			// mainMenu
			// 
			this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					 this.editorMenuItem,
																					 this.selectMenuItem,
																					 this.ActionMenuItem,
																					 this.helpMenuItem});
			// 
			// selectMenuItem
			// 
			this.selectMenuItem.Index = 1;
			this.selectMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.selectPolesMenuItem,
																						   this.selectZerosMenuItem,
																						   this.selectInsideUnitCircleMenuItem,
																						   this.selectOutsideUnitCircleMenuItem,
																						   this.selectAboveRealAxisMenuItem,
																						   this.selectBelowRealAxisMenuItem,
																						   this.selectLeftHalfMenuItem,
																						   this.selectRightHalfMenuItem});
			this.selectMenuItem.Text = "&Select";
			// 
			// selectPolesMenuItem
			// 
			this.selectPolesMenuItem.Index = 0;
			this.selectPolesMenuItem.Text = "Select &Poles";
			this.selectPolesMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectPolesClick);
			// 
			// selectZerosMenuItem
			// 
			this.selectZerosMenuItem.Index = 1;
			this.selectZerosMenuItem.Text = "Select &Zeros";
			this.selectZerosMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectZerosClick);
			// 
			// selectInsideUnitCircleMenuItem
			// 
			this.selectInsideUnitCircleMenuItem.Index = 2;
			this.selectInsideUnitCircleMenuItem.Text = "Select &Inside Unit Circle";
			this.selectInsideUnitCircleMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectInsideClick);
			// 
			// selectOutsideUnitCircleMenuItem
			// 
			this.selectOutsideUnitCircleMenuItem.Index = 3;
			this.selectOutsideUnitCircleMenuItem.Text = "Select &Outside Unit Circle";
			this.selectOutsideUnitCircleMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectOutsideClick);
			// 
			// selectAboveRealAxisMenuItem
			// 
			this.selectAboveRealAxisMenuItem.Index = 4;
			this.selectAboveRealAxisMenuItem.Text = "Select &Above Real Axis";
			this.selectAboveRealAxisMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectAboveClick);
			// 
			// selectBelowRealAxisMenuItem
			// 
			this.selectBelowRealAxisMenuItem.Index = 5;
			this.selectBelowRealAxisMenuItem.Text = "Select &Below Real Axis";
			this.selectBelowRealAxisMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectBelowClick);
			// 
			// selectLeftHalfMenuItem
			// 
			this.selectLeftHalfMenuItem.Index = 6;
			this.selectLeftHalfMenuItem.Text = "Select &Left Half";
			this.selectLeftHalfMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectLeftClick);
			// 
			// selectRightHalfMenuItem
			// 
			this.selectRightHalfMenuItem.Index = 7;
			this.selectRightHalfMenuItem.Text = "Select &Right Half";
			this.selectRightHalfMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectRightClick);
			// 
			// ActionMenuItem
			// 
			this.ActionMenuItem.Index = 2;
			this.ActionMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						   this.mirrorRealMenuItem,
																						   this.mirrorImaginaryMenuItem,
																						   this.invertRealMenuItem,
																						   this.invertImaginaryMenuItem,
																						   this.removePoleZeroMenuItem});
			this.ActionMenuItem.Text = "&Action";
			// 
			// mirrorRealMenuItem
			// 
			this.mirrorRealMenuItem.Index = 0;
			this.mirrorRealMenuItem.Text = "Mirror about &Real Axis";
			this.mirrorRealMenuItem.Click += new System.EventHandler(this.OnMenuItemMirrorRealClick);
			// 
			// mirrorImaginaryMenuItem
			// 
			this.mirrorImaginaryMenuItem.Index = 1;
			this.mirrorImaginaryMenuItem.Text = "Mirror about &Imaginary Axis";
			this.mirrorImaginaryMenuItem.Click += new System.EventHandler(this.OnMenuItemMirrorImaginaryClick);
			// 
			// invertRealMenuItem
			// 
			this.invertRealMenuItem.Index = 2;
			this.invertRealMenuItem.Text = "Invert about R&eal Axis";
			this.invertRealMenuItem.Click += new System.EventHandler(this.OnMenuItemInvertRealClick);
			// 
			// invertImaginaryMenuItem
			// 
			this.invertImaginaryMenuItem.Index = 3;
			this.invertImaginaryMenuItem.Text = "Invert about I&maginary Axis";
			this.invertImaginaryMenuItem.Click += new System.EventHandler(this.OnMenuItemInvertImaginaryClick);
			// 
			// removePoleZeroMenuItem
			// 
			this.removePoleZeroMenuItem.Index = 4;
			this.removePoleZeroMenuItem.Text = "Remove Pole/Zero";
			this.removePoleZeroMenuItem.Click += new System.EventHandler(this.OnMenuItemRemovePoleZeroClick);
			// 
			// helpMenuItem
			// 
			this.helpMenuItem.Index = 3;
			this.helpMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.editorHelpMenuItem});
			this.helpMenuItem.Text = "&Help";
			// 
			// editorHelpMenuItem
			// 
			this.editorHelpMenuItem.Index = 0;
			this.editorHelpMenuItem.Text = "E&ditor Help";
			this.editorHelpMenuItem.Click += new System.EventHandler(this.OnMenuItemEditorHelpClick);
			// 
			// selectPolesMenu
			// 
			this.selectPolesMenu.Index = 0;
			this.selectPolesMenu.Text = "Select All Poles";
			this.selectPolesMenu.Click += new System.EventHandler(this.OnMenuItemSelectPolesClick);
			// 
			// zerosPlot
			// 
			this.zerosPlot.LineStyle = NationalInstruments.UI.LineStyle.None;
			this.zerosPlot.PointSize = new System.Drawing.Size(8, 8);
			this.zerosPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle;
			this.zerosPlot.XAxis = this.complexXAxis;
			this.zerosPlot.YAxis = this.complexYAxis;
			// 
			// complexXAxis
			// 
			this.complexXAxis.Caption = "Real Axis";
			this.complexXAxis.MajorDivisions.GridVisible = true;
			this.complexXAxis.MinorDivisions.GridVisible = true;
			this.complexXAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
			this.complexXAxis.OriginLineWidth = 2F;
			this.complexXAxis.Range = new NationalInstruments.UI.Range(-1.5, 1.5);
			// 
			// complexYAxis
			// 
			this.complexYAxis.Caption = "Imaginary Axis";
			this.complexYAxis.MajorDivisions.GridVisible = true;
			this.complexYAxis.MinorDivisions.GridVisible = true;
			this.complexYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
			this.complexYAxis.OriginLineWidth = 2F;
			this.complexYAxis.Range = new NationalInstruments.UI.Range(-1.5, 1.5);
			// 
			// selectInsideMenuItem
			// 
			this.selectInsideMenuItem.Index = 2;
			this.selectInsideMenuItem.Text = "Select Inside Unit Circle";
			this.selectInsideMenuItem.Click += new System.EventHandler(this.OnMenuItemSelectInsideClick);
			// 
			// selectZerosMenu
			// 
			this.selectZerosMenu.Index = 1;
			this.selectZerosMenu.Text = "Select All Zeros";
			this.selectZerosMenu.Click += new System.EventHandler(this.OnMenuItemSelectZerosClick);
			// 
			// selectionMenu
			// 
			this.selectionMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						  this.selectPolesMenu,
																						  this.selectZerosMenu,
																						  this.selectInsideMenuItem,
																						  this.selectOutsideMenu,
																						  this.menuItemSelectAbove,
																						  this.menuItemSelectBelow,
																						  this.menuSelectLeftHalf,
																						  this.selectRightMenu});
			// 
			// selectOutsideMenu
			// 
			this.selectOutsideMenu.Index = 3;
			this.selectOutsideMenu.Text = "Select Outside Unit Circle";
			this.selectOutsideMenu.Click += new System.EventHandler(this.OnMenuItemSelectOutsideClick);
			// 
			// menuItemSelectAbove
			// 
			this.menuItemSelectAbove.Index = 4;
			this.menuItemSelectAbove.Text = "Select Above Real Axis";
			this.menuItemSelectAbove.Click += new System.EventHandler(this.OnMenuItemSelectAboveClick);
			// 
			// menuItemSelectBelow
			// 
			this.menuItemSelectBelow.Index = 5;
			this.menuItemSelectBelow.Text = "Select Below Real Axis";
			this.menuItemSelectBelow.Click += new System.EventHandler(this.OnMenuItemSelectBelowClick);
			// 
			// menuSelectLeftHalf
			// 
			this.menuSelectLeftHalf.Index = 6;
			this.menuSelectLeftHalf.Text = "Select Left Half";
			this.menuSelectLeftHalf.Click += new System.EventHandler(this.OnMenuItemSelectLeftClick);
			// 
			// selectRightMenu
			// 
			this.selectRightMenu.Index = 7;
			this.selectRightMenu.Text = "Select Right Half";
			this.selectRightMenu.Click += new System.EventHandler(this.OnMenuItemSelectRightClick);
			// 
			// polePlot
			// 
			this.polePlot.LineStyle = NationalInstruments.UI.LineStyle.None;
			this.polePlot.PointColor = System.Drawing.Color.OrangeRed;
			this.polePlot.PointSize = new System.Drawing.Size(8, 8);
			this.polePlot.PointStyle = NationalInstruments.UI.PointStyle.Cross;
			this.polePlot.XAxis = this.complexXAxis;
			this.polePlot.YAxis = this.complexYAxis;
			// 
			// poleZeroEditorGroupBox
			// 
			this.poleZeroEditorGroupBox.Controls.Add(this.poleZeroComplexGraph);
			this.poleZeroEditorGroupBox.Controls.Add(this.dataGridPanel);
			this.poleZeroEditorGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.poleZeroEditorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.poleZeroEditorGroupBox.Location = new System.Drawing.Point(0, 0);
			this.poleZeroEditorGroupBox.Name = "poleZeroEditorGroupBox";
			this.poleZeroEditorGroupBox.Size = new System.Drawing.Size(697, 332);
			this.poleZeroEditorGroupBox.TabIndex = 0;
			this.poleZeroEditorGroupBox.TabStop = false;
			this.poleZeroEditorGroupBox.Text = "Pole - Zero Editor";
			// 
			// poleZeroComplexGraph
			// 
			this.poleZeroComplexGraph.Annotations.AddRange(new NationalInstruments.UI.ComplexAnnotation[] {
																											  this.unitMagnitudeCircleAnnotation});
			this.poleZeroComplexGraph.ContextMenu = this.selectionMenu;
			this.poleZeroComplexGraph.Dock = System.Windows.Forms.DockStyle.Right;
			this.poleZeroComplexGraph.InteractionMode = ((NationalInstruments.UI.ComplexGraphInteractionModes)(((NationalInstruments.UI.ComplexGraphInteractionModes.ZoomX | NationalInstruments.UI.ComplexGraphInteractionModes.ZoomY) 
				| NationalInstruments.UI.ComplexGraphInteractionModes.ZoomAroundPoint)));
			this.poleZeroComplexGraph.Location = new System.Drawing.Point(294, 16);
			this.poleZeroComplexGraph.Name = "poleZeroComplexGraph";
			this.poleZeroComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
																								  this.polePlot,
																								  this.zerosPlot});
			this.poleZeroComplexGraph.Size = new System.Drawing.Size(400, 313);
			this.poleZeroComplexGraph.TabIndex = 1;
			this.poleZeroComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
																								   this.complexXAxis});
			this.poleZeroComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
																								   this.complexYAxis});
			this.poleZeroComplexGraph.BeforeDrawPlot += new NationalInstruments.UI.BeforeDrawComplexPlotEventHandler(this.OnPoleZeroGraphBeforeDrawPlot);
			this.poleZeroComplexGraph.PlotAreaMouseMove += new System.Windows.Forms.MouseEventHandler(this.OnPoleZeroGraphPlotAreaMouseMove);
			this.poleZeroComplexGraph.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnPoleZeroGraphKeyUp);
			this.poleZeroComplexGraph.PlotAreaMouseUp += new System.Windows.Forms.MouseEventHandler(this.OnPoleZeroGraphPlotAreaMouseUp);
			this.poleZeroComplexGraph.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnPoleZeroGraphKeyDown);
			this.poleZeroComplexGraph.PlotDataChanged += new NationalInstruments.UI.ComplexPlotDataChangedEventHandler(this.OnPoleZeroGraphPlotDataChanged);
			this.poleZeroComplexGraph.PlotAreaMouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPoleZeroGraphPlotAreaMouseDown);
			// 
			// unitMagnitudeCircleAnnotation
			// 
			this.unitMagnitudeCircleAnnotation.ArrowHeadMagnitude = 1;
			this.unitMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitMagnitudeCircleAnnotation.Caption = "Unit Circle";
			this.unitMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitMagnitudeCircleAnnotation.Magnitude = 1;
			this.unitMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// dataGridPanel
			// 
			this.dataGridPanel.Controls.Add(this.addPoleButton);
			this.dataGridPanel.Controls.Add(this.addZeroButton);
			this.dataGridPanel.Controls.Add(this.poleDataGrid);
			this.dataGridPanel.Controls.Add(this.zeroDataGrid);
			this.dataGridPanel.Controls.Add(this.poleZeroEditorLegend);
			this.dataGridPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridPanel.Location = new System.Drawing.Point(3, 16);
			this.dataGridPanel.Name = "dataGridPanel";
			this.dataGridPanel.Size = new System.Drawing.Size(272, 313);
			this.dataGridPanel.TabIndex = 0;
			// 
			// addPoleButton
			// 
			this.addPoleButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.addPoleButton.Location = new System.Drawing.Point(8, 2);
			this.addPoleButton.Name = "addPoleButton";
			this.addPoleButton.Size = new System.Drawing.Size(120, 24);
			this.addPoleButton.TabIndex = 0;
			this.addPoleButton.Text = "Add Pole";
			this.addPoleButton.Click += new System.EventHandler(this.OnButtonAddPoleClick);
			// 
			// addZeroButton
			// 
			this.addZeroButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.addZeroButton.Location = new System.Drawing.Point(144, 2);
			this.addZeroButton.Name = "addZeroButton";
			this.addZeroButton.Size = new System.Drawing.Size(120, 24);
			this.addZeroButton.TabIndex = 1;
			this.addZeroButton.Text = "Add Zero";
			this.addZeroButton.Click += new System.EventHandler(this.OnButtonAddZeroClick);
			// 
			// poleDataGrid
			// 
			this.poleDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
			this.poleDataGrid.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.poleDataGrid.CaptionText = "Poles";
			this.poleDataGrid.DataMember = "";
			this.poleDataGrid.GridLineColor = System.Drawing.SystemColors.Window;
			this.poleDataGrid.HeaderBackColor = System.Drawing.SystemColors.Window;
			this.poleDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.poleDataGrid.Location = new System.Drawing.Point(8, 33);
			this.poleDataGrid.Name = "poleDataGrid";
			this.poleDataGrid.ParentRowsBackColor = System.Drawing.SystemColors.Highlight;
			this.poleDataGrid.ReadOnly = true;
			this.poleDataGrid.RowHeadersVisible = false;
			this.poleDataGrid.RowHeaderWidth = 0;
			this.poleDataGrid.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.poleDataGrid.SelectionForeColor = System.Drawing.SystemColors.Window;
			this.poleDataGrid.Size = new System.Drawing.Size(256, 116);
			this.poleDataGrid.TabIndex = 2;
			this.poleDataGrid.CurrentCellChanged += new System.EventHandler(this.OnDataGridPoleCurrentCellChanged);
			this.poleDataGrid.Leave += new System.EventHandler(this.OnDataGridPoleLeave);
			this.poleDataGrid.Enter += new System.EventHandler(this.OnDataGridPoleEnter);
			// 
			// zeroDataGrid
			// 
			this.zeroDataGrid.BackgroundColor = System.Drawing.SystemColors.Window;
			this.zeroDataGrid.CaptionBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.zeroDataGrid.CaptionText = "Zeros";
			this.zeroDataGrid.DataMember = "";
			this.zeroDataGrid.GridLineColor = System.Drawing.SystemColors.Window;
			this.zeroDataGrid.HeaderBackColor = System.Drawing.SystemColors.Window;
			this.zeroDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.zeroDataGrid.Location = new System.Drawing.Point(8, 155);
			this.zeroDataGrid.Name = "zeroDataGrid";
			this.zeroDataGrid.ParentRowsBackColor = System.Drawing.SystemColors.Highlight;
			this.zeroDataGrid.ReadOnly = true;
			this.zeroDataGrid.RowHeadersVisible = false;
			this.zeroDataGrid.RowHeaderWidth = 0;
			this.zeroDataGrid.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.zeroDataGrid.SelectionForeColor = System.Drawing.SystemColors.Window;
			this.zeroDataGrid.Size = new System.Drawing.Size(256, 116);
			this.zeroDataGrid.TabIndex = 3;
			this.zeroDataGrid.CurrentCellChanged += new System.EventHandler(this.OnDataGridZeroCurrentCellChanged);
			this.zeroDataGrid.Leave += new System.EventHandler(this.OnDataGridZeroLeave);
			this.zeroDataGrid.Enter += new System.EventHandler(this.OnDataGridZeroEnter);
			// 
			// poleZeroEditorLegend
			// 
			this.poleZeroEditorLegend.Border = NationalInstruments.UI.Border.Etched;
			this.poleZeroEditorLegend.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
																								 this.UnitCircleLegendItem,
																								 this.polesLegendItem,
																								 this.zerosLegendItem});
			this.poleZeroEditorLegend.Location = new System.Drawing.Point(8, 277);
			this.poleZeroEditorLegend.Name = "poleZeroEditorLegend";
			this.poleZeroEditorLegend.Size = new System.Drawing.Size(256, 32);
			this.poleZeroEditorLegend.TabIndex = 4;
			this.poleZeroEditorLegend.TabStop = false;
			// 
			// UnitCircleLegendItem
			// 
			this.UnitCircleLegendItem.Text = "Unit Circle";
			// 
			// polesLegendItem
			// 
			this.polesLegendItem.Source = this.polePlot;
			this.polesLegendItem.Text = "Poles";
			// 
			// zerosLegendItem
			// 
			this.zerosLegendItem.Source = this.zerosPlot;
			this.zerosLegendItem.Text = "Zeros";
			// 
			// hideShowButton
			// 
			this.hideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.hideShowButton.Location = new System.Drawing.Point(5, 340);
			this.hideShowButton.Name = "hideShowButton";
			this.hideShowButton.Size = new System.Drawing.Size(200, 24);
			this.hideShowButton.TabIndex = 1;
			this.hideShowButton.Text = "<< Hide Filter Characteristics";
			this.hideShowButton.Click += new System.EventHandler(this.OnButtonHideShowClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(697, 674);
			this.Controls.Add(this.hideShowButton);
			this.Controls.Add(this.filterGroupBox);
			this.Controls.Add(this.poleZeroEditorGroupBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Menu = this.mainMenu;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Pole-Zero Editor";
			this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.MainForm_HelpRequested);
			this.filterGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.magnitudeSpectrumScatterGraph)).EndInit();
			this.parametersPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.samplingFrequencyNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numberOfPointsNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gainNumericEdit)).EndInit();
			this.poleZeroEditorGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.poleZeroComplexGraph)).EndInit();
			this.dataGridPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.poleDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.zeroDataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.poleZeroEditorLegend)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.EnableVisualStyles();
			Application.DoEvents();
			Application.Run(new MainForm());
		}

		private static void SetupDataGrid(DataGrid dataGrid)
		{
			DataGridTableStyle ts = new DataGridTableStyle();
			ts.MappingName = "ArrayList";

			int columnWidth = (dataGrid.ClientSize.Width
				- ts.RowHeaderWidth
				- SystemInformation.VerticalScrollBarWidth) / 2;

			DataGridTextBoxColumn tbc = new DataGridTextBoxColumn();           
			tbc.MappingName = "Real";
			tbc.HeaderText = "Real";
			tbc.Format = "f4";
			tbc.Width = columnWidth;
			ts.GridColumnStyles.Add(tbc);
           
			tbc = new DataGridTextBoxColumn();
			tbc.MappingName = "Imaginary";
			tbc.HeaderText = "Imaginary";
			tbc.Format = "f4";
			tbc.Width = columnWidth;            
			ts.GridColumnStyles.Add(tbc);
    
			dataGrid.TableStyles.Clear();
			dataGrid.TableStyles.Add(ts);
			dataGrid.ReadOnly = false;
		}

		private void CalculateMagnitudePhase(double samplingFrequency, int numberOfPoints, double gain)
		{
			//calculate magnitude and phase response between 0 and fs/2
			ComplexDouble[] array = new ComplexDouble[numberOfPoints];
			double[] theta = new double[numberOfPoints];

			for (int i = 0; i < numberOfPoints; i++)
			{
				theta[i] = (Math.PI * i)/ numberOfPoints;
				array[i] = ComplexDouble.FromPolar(1.0, theta[i]);
			}

			ComplexDouble[] zeros =  zerosPlot.GetComplexData();
			ComplexDouble[] poles =  polePlot.GetComplexData();
			ComplexDouble[] zerosProduct = new ComplexDouble[numberOfPoints];
			ComplexDouble[] polesProduct = new ComplexDouble[numberOfPoints];
			ComplexDouble[] h = new ComplexDouble[numberOfPoints];

			for (int i = 0; i < numberOfPoints; i++)
			{
				zerosProduct[i] = new ComplexDouble(1.0, 1.0);
				polesProduct[i] = new ComplexDouble(1.0, 1.0);
                
				for (int j = 0; j < zeros.Length; j++)
				{
					if(zeros[j] != ComplexDouble.Zero)
						zerosProduct[i] *= array[i] - zeros[j];
				}
                
				for (int j = 0; j < poles.Length; j++)
				{
					if(poles[j] != ComplexDouble.Zero)
						polesProduct[i] *= array[i] - poles[j];
				}
                
				h[i] = ComplexDouble.FromDouble(gain) * zerosProduct[i] / polesProduct[i];
			}
            
			double[] magnitude, phase;
			ComplexDouble.DecomposeArrayPolar(h, out magnitude, out phase);
           
			for(int i = 0; i < numberOfPoints; i++)
			{
				theta[i]= (theta[i]/(2*Math.PI)) * samplingFrequency;
				magnitude[i] = 20.0 * Math.Log10(magnitude[i]);
			}

			magnitudeSpectrumScatterGraph.PlotXY(theta, magnitude);
		}

		private static readonly ComplexDouble DefaultPole = ComplexDouble.Zero;
		private static readonly ComplexDouble DefaultZero = ComplexDouble.Zero;

		private void OnButtonAddPoleClick(object sender, System.EventArgs e)
		{
			polesData.Add(DefaultPole);
			poleDataGrid.DataSource = polesData;
			poleDataGrid.Enabled = true;
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void OnButtonAddZeroClick(object sender, System.EventArgs e)
		{
			zerosData.Add(DefaultZero);
			zeroDataGrid.DataSource = zerosData;
			zeroDataGrid.Enabled = true;
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void OnPoleZeroGraphPlotAreaMouseDown(object sender, MouseEventArgs e)
		{
			ComplexDouble complexDataPoint = ComplexDouble.Zero;

			selectedPlot = poleZeroComplexGraph.GetPlotAt(e.X, e.Y, out complexDataPoint);
			switch (e.Button)
			{
				case MouseButtons.Left:
					if (multipleSelectPressed == false)
					{
						selectedPoles.Clear();
						selectedZeros.Clear();
						isMoving = true;
					}

					if (selectedPlot != null)
					{
						if (selectedPlot == polePlot)
						{
							selectedPoles.Add(complexDataPoint);
						}
						else if (selectedPlot == zerosPlot)
						{
							selectedZeros.Add(complexDataPoint);
						}
					}

					poleZeroComplexGraph.Invalidate();
					break;
				case MouseButtons.Right:
					if (selectedPlot != null)
					{
						bool flag = false;

						foreach (ComplexDouble cz in selectedZeros)
						{
							if (cz.Equals(complexDataPoint))
							{
								flag = true;
							}
						}
						foreach (ComplexDouble cz in selectedPoles)
						{
							if (cz.Equals(complexDataPoint))
							{
								flag = true;
							}
						}

						if (flag == false)
						{
							selectedPoles.Clear();
							selectedZeros.Clear();
                   
							if (selectedPlot == zerosPlot)
							{
								selectedZeros.Add(complexDataPoint);
							}
							else if (selectedPlot == polePlot)
							{
								selectedPoles.Add(complexDataPoint);
							}
						}

						poleZeroComplexGraph.Invalidate();
						plotContextMenu.Show(poleZeroComplexGraph, new Point(e.X, e.Y));
					}
					else
					{
						selectedPoles.Clear();
						selectedZeros.Clear();
					}
					break;
			}

			RefreshPlot();
		}

		private void RefreshPlot()
		{
			polePlot.ClearData();
			zerosPlot.ClearData();

			if (zerosData.Count != 0)
			{
				zerosPlot.PlotComplexAppend((ComplexDouble[])zerosData.ToArray(typeof(ComplexDouble)));
			}
			if (polesData.Count != 0)
			{
				polePlot.PlotComplexAppend((ComplexDouble[])polesData.ToArray(typeof(ComplexDouble)));
			}
		}

		private void OnPoleZeroGraphPlotDataChanged(object sender, NationalInstruments.UI.ComplexPlotDataChangedEventArgs e)
		{
			CalculateMagnitudePhase(samplingFrequencyNumericEdit.Value, (int) numberOfPointsNumericEdit.Value, gainNumericEdit.Value);
          
			if (polesData != null)
			{
				CurrencyManager cm = (CurrencyManager) this.poleDataGrid.BindingContext[polesData];
				if (cm != null)
				{
					cm.Refresh();
				}
			}
			if (zerosData != null)
			{
				CurrencyManager cm = (CurrencyManager) this.zeroDataGrid.BindingContext[zerosData];
				if (cm != null)
				{
					cm.Refresh();
				}
			}
		}

		private void OnPoleZeroGraphPlotAreaMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (isMoving == true)
			{
				ComplexDouble complexDataPoint = new ComplexDouble(Double.NaN, Double.NaN);

				if (selectedPlot == polePlot && selectedPoles.Count == 1)
				{
					RemoveSelectedPoints();
					complexDataPoint = polePlot.InverseMapDataPoint(poleZeroComplexGraph.PlotAreaBounds, new PointF(e.X,e.Y));
					polesData.Add(complexDataPoint);
					selectedPoles.Clear();
					selectedPoles.Add(complexDataPoint);
				}
				else if (selectedPlot == zerosPlot && selectedZeros.Count == 1)
				{
					RemoveSelectedPoints();
					complexDataPoint = zerosPlot.InverseMapDataPoint(poleZeroComplexGraph.PlotAreaBounds, new PointF(e.X,e.Y));
					zerosData.Add(complexDataPoint);
					selectedZeros.Clear();
					selectedZeros.Add(complexDataPoint);
				}

				RefreshPlot();
			}
		}

		private void OnPoleZeroGraphPlotAreaMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			isMoving = false;           
		}

		private void OnPoleZeroGraphKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				RemoveSelectedPoints();
				selectedPoles.Clear();
				selectedZeros.Clear();
				RefreshPlot();
			}
			if ((e.KeyData & Keys.Control) == Keys.Control)
			{
				multipleSelectPressed = true;
			}
		}

		private void OnPoleZeroGraphKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			multipleSelectPressed = false;
		}

		private void OnPoleZeroGraphBeforeDrawPlot(object sender, NationalInstruments.UI.BeforeDrawComplexPlotEventArgs e)
		{
			Graphics g = e.Graphics;		
			PointF mappedPoint;
			Rectangle bounds;
			Pen pen = new Pen(Color.Blue, 1);
			SolidBrush brush = new SolidBrush(Color.FromArgb(60, Color.SteelBlue));
			g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

			foreach (ComplexDouble complexDataPoint in selectedPoles)
			{
				mappedPoint = e.Plot.MapDataPoint(e.Bounds, complexDataPoint);
				bounds = new Rectangle((int)(mappedPoint.X - (e.Plot.PointSize.Width / 2) - 2), (int)(mappedPoint.Y - (e.Plot.PointSize.Height / 2) - 2), e.Plot.PointSize.Width + 3, e.Plot.PointSize.Height + 3);
				g.FillEllipse(brush, bounds);
				g.DrawEllipse(pen, bounds);
			}
			foreach (ComplexDouble complexDataPoint in selectedZeros)
			{
				mappedPoint = e.Plot.MapDataPoint(e.Bounds, complexDataPoint);
				bounds = new Rectangle((int)(mappedPoint.X - (e.Plot.PointSize.Width / 2) - 2), (int)(mappedPoint.Y - (e.Plot.PointSize.Height / 2) - 2), e.Plot.PointSize.Width + 3, e.Plot.PointSize.Height + 3);
				g.FillEllipse(brush, bounds);
				g.DrawEllipse(pen, bounds);
			}
		}

		private void RemoveSelectedPoints()
		{
			foreach (ComplexDouble complexDataPoint in selectedPoles)
			{
				polesData.Remove(complexDataPoint);
			}            
			foreach (ComplexDouble complexDataPoint in selectedZeros)
			{
				zerosData.Remove(complexDataPoint);
			}               
		}

		private void OnMenuItemExitClick(object sender, System.EventArgs e)
		{
			Close();
		}

		private void OnFilterCharacteristicsNumericEditsValueChanged(object sender, System.EventArgs e)
		{
			CalculateMagnitudePhase(samplingFrequencyNumericEdit.Value, (int)numberOfPointsNumericEdit.Value, gainNumericEdit.Value);
		}

		private void OnMenuItemEditorHelpClick(object sender, System.EventArgs e)
		{
			HelpDlg dlg = new HelpDlg();
			dlg.Owner = this;
			dlg.Show();
		}

		private void OnDataGridPoleCurrentCellChanged(object sender, System.EventArgs e)
		{
			UpdateDataGridPole();
		}

		private void OnDataGridZeroCurrentCellChanged(object sender, System.EventArgs e)
		{
			UpdateDataGridZero();
		}

		private void OnDataGridPoleLeave(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void OnDataGridZeroLeave(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void UpdateDataGridPole()
		{
			ComplexDouble complexDataPoint = new ComplexDouble((double) poleDataGrid[poleDataGrid.CurrentCell.RowNumber, 0], (double) poleDataGrid[poleDataGrid.CurrentCell.RowNumber, 1]);
			polesData[poleDataGrid.CurrentCell.RowNumber] = complexDataPoint;
			selectedPoles.Clear();
			selectedZeros.Clear();
			selectedPoles.Add(complexDataPoint);
			RefreshPlot();
		}

		private void UpdateDataGridZero()
		{
			ComplexDouble complexDataPoint = new ComplexDouble((double) zeroDataGrid[zeroDataGrid.CurrentCell.RowNumber, 0], (double) zeroDataGrid[zeroDataGrid.CurrentCell.RowNumber, 1]);
			zerosData[zeroDataGrid.CurrentCell.RowNumber] = complexDataPoint;
			selectedPoles.Clear();
			selectedZeros.Clear();
			selectedZeros.Add(complexDataPoint);
			RefreshPlot();
		}

		private void OnDataGridPoleEnter(object sender, System.EventArgs e)
		{
			UpdateDataGridPole();
		}

		private void OnDataGridZeroEnter(object sender, System.EventArgs e)
		{
			UpdateDataGridZero();
		}

		private void OnMenuItemSelectPolesClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in polePlot.GetComplexData())
				selectedPoles.Add(complexDataPoint);
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemSelectZerosClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in zerosPlot.GetComplexData())
				selectedZeros.Add(complexDataPoint);
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemSelectInsideClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in zerosPlot.GetComplexData())
			{
				if (complexDataPoint.Magnitude <= 1.0)
					selectedZeros.Add(complexDataPoint);
			}
			foreach (ComplexDouble complexDataPoint in polePlot.GetComplexData())
			{
				if (complexDataPoint.Magnitude <= 1.0)
					selectedPoles.Add(complexDataPoint);
			}
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemSelectOutsideClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in zerosPlot.GetComplexData())
			{
				if (complexDataPoint.Magnitude > 1.0)
					selectedZeros.Add(complexDataPoint);
			}
			foreach (ComplexDouble complexDataPoint in polePlot.GetComplexData())
			{
				if (complexDataPoint.Magnitude > 1.0)
					selectedPoles.Add(complexDataPoint);
			}
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemSelectAboveClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in zerosPlot.GetComplexData())
			{
				if (complexDataPoint.Imaginary > 0.0)
					selectedZeros.Add(complexDataPoint);
			}
			foreach (ComplexDouble complexDataPoint in polePlot.GetComplexData())
			{
				if (complexDataPoint.Imaginary > 0.0)
					selectedPoles.Add(complexDataPoint);
			}
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemSelectBelowClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in zerosPlot.GetComplexData())
			{
				if (complexDataPoint.Imaginary <= 0.0)
					selectedZeros.Add(complexDataPoint);
			}
			foreach (ComplexDouble complexDataPoint in polePlot.GetComplexData())
			{
				if (complexDataPoint.Imaginary <= 0.0)
					selectedPoles.Add(complexDataPoint);
			}
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemSelectLeftClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in zerosPlot.GetComplexData())
			{
				if (complexDataPoint.Real <= 0.0)
					selectedZeros.Add(complexDataPoint);
			}
			foreach (ComplexDouble complexDataPoint in polePlot.GetComplexData())
			{
				if (complexDataPoint.Real <= 0.0)
					selectedPoles.Add(complexDataPoint);
			}
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemSelectRightClick(object sender, System.EventArgs e)
		{
			selectedPoles.Clear();
			selectedZeros.Clear();
			foreach (ComplexDouble complexDataPoint in zerosPlot.GetComplexData())
			{
				if (complexDataPoint.Real > 0.0)
					selectedZeros.Add(complexDataPoint);
			}
			foreach (ComplexDouble complexDataPoint in polePlot.GetComplexData())
			{
				if (complexDataPoint.Real > 0.0)
					selectedPoles.Add(complexDataPoint);
			}
			poleZeroComplexGraph.Invalidate();
		}

		private void OnMenuItemInvertRealClick(object sender, System.EventArgs e)
		{
			foreach (ComplexDouble complexDataPoint in selectedZeros)
			{
				zerosData.Remove(complexDataPoint);
				zerosData.Add(complexDataPoint.ComplexConjugate);
			}
			foreach(ComplexDouble complexDataPoint in selectedPoles)
			{
				polesData.Remove(complexDataPoint);
				polesData.Add(complexDataPoint.ComplexConjugate);
			}
        
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void OnMenuItemMirrorRealClick(object sender, System.EventArgs e)
		{
			foreach (ComplexDouble complexDataPoint in selectedZeros)
				zerosData.Add(complexDataPoint.ComplexConjugate);
			foreach(ComplexDouble complexDataPoint in selectedPoles)
				polesData.Add(complexDataPoint.ComplexConjugate);
        
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void OnMenuItemMirrorImaginaryClick(object sender, System.EventArgs e)
		{
			ComplexDouble mirrorImaginary; 
			foreach (ComplexDouble complexDataPoint in selectedZeros)
			{
				mirrorImaginary = new ComplexDouble(-complexDataPoint.Real, complexDataPoint.Imaginary);
				zerosData.Add(mirrorImaginary);
			}
			foreach (ComplexDouble complexDataPoint in selectedPoles)
			{
				mirrorImaginary = new ComplexDouble(-complexDataPoint.Real, complexDataPoint.Imaginary);
				polesData.Add(mirrorImaginary);
			}
            
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void OnMenuItemInvertImaginaryClick(object sender, System.EventArgs e)
		{
			ComplexDouble mirrorImaginary; 
			foreach (ComplexDouble complexDataPoint in selectedZeros)
			{
				mirrorImaginary = new ComplexDouble(-complexDataPoint.Real, complexDataPoint.Imaginary);
				zerosData.Remove(complexDataPoint);
				zerosData.Add(mirrorImaginary);
			}
			foreach (ComplexDouble complexDataPoint in selectedPoles)
			{
				mirrorImaginary = new ComplexDouble(-complexDataPoint.Real, complexDataPoint.Imaginary);
				polesData.Remove(complexDataPoint);
				polesData.Add(mirrorImaginary);
			}

			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}

		private void OnMenuItemRemovePoleZeroClick(object sender, System.EventArgs e)
		{
			RemoveSelectedPoints();
			selectedPoles.Clear();
			selectedZeros.Clear();
			RefreshPlot();
		}
		private void OnButtonHideShowClick(object sender, System.EventArgs e)
		{
			if(showFilterCharacterictics)
			{
				showFilterCharacterictics = false;
				this.ClientSize = SmallFormSize;
				this.AutoScroll = false;
				hideShowButton.Text = "Show Filter Characteristics >>";
			}
			else
			{
				showFilterCharacterictics = true;
				this.ClientSize = LargeFormSize;
				this.AutoScroll = true;
				hideShowButton.Text = "<< Hide Filter Characteristics";

			}
		}

		private void MainForm_HelpRequested(object sender, System.Windows.Forms.HelpEventArgs hlpevent)
		{
			OnMenuItemEditorHelpClick(this, System.EventArgs.Empty);
			hlpevent.Handled = true;
		}	

	}
}
