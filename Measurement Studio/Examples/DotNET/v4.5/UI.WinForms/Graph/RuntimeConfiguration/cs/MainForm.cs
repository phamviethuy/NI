using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.RuntimeConfiguration
{
	public class MainForm : System.Windows.Forms.Form
	{
        private Axis contextAxis;
        private XYCursor contextCursor;
        private XYPlot contextPlot;
        private XYAnnotation contextAnnotation;

        private NationalInstruments.UI.WindowsForms.Legend plotLegend;
        private NationalInstruments.UI.WindowsForms.Legend cursorLegend;
        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private NationalInstruments.UI.LegendItem sinePlotLegendItem;
        private NationalInstruments.UI.LegendItem dataLegendItem;
        private NationalInstruments.UI.XYPointAnnotation annotation;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.XYCursor dataCursor;
        private NationalInstruments.UI.WaveformPlot whiteNoisePlot;
        private System.Windows.Forms.ContextMenu plotContextMenu;
        private System.Windows.Forms.ContextMenu cursorContextMenu;
        private System.Windows.Forms.ContextMenu annotationContextMenu;
        private System.Windows.Forms.ContextMenu axisContextMenu;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            // Plot white noise data
            double[] data = new double[20];
            Random rnd = new Random();
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = rnd.NextDouble() * 10;
            }

            sampleWaveformGraph.PlotY(data);

            double x;
            double y;

            // Position annotation to a point on the plot
            whiteNoisePlot.GetDataPoint((int) data.Length / 4, out x, out y);
            annotation.XPosition = x;
            annotation.YPosition = y;

            // Position cursor to a point on the plot
            whiteNoisePlot.GetDataPoint((int) data.Length / 2, out x, out y);
            dataCursor.XPosition = x;
            dataCursor.YPosition = y;

            // Add menu items to the context menus
            bool[] bools = new bool[2] { true, false };
            string[] boolStrings = null;
            if (DataConverter.CanConvert(bools, typeof(string[])))
            {
                boolStrings = DataConverter.Convert(bools, typeof(string[])) as string[];
            }

            AddMenuItem(axisContextMenu, "Inverted", boolStrings, new EventHandler(OnInvertedMenuClick), new EventHandler(OnInvertedMenuPopup));

            string[] scaleTypes = Enum.GetNames(typeof(ScaleType));
            AddMenuItem(axisContextMenu, "Scale Type", scaleTypes, new EventHandler(OnScaleTypeMenuClick), new EventHandler(OnScaleTypeMenuPopup));

            AddMenuItem(axisContextMenu, "Major Grids Visible", boolStrings, new EventHandler(OnMajorGridsVisibleMenuClick), new EventHandler(OnMajorGridsVisibleMenuPopup));

            AddMenuItem(axisContextMenu, "Minor Grids Visible", boolStrings, new EventHandler(OnMinorGridsVisibleMenuClick), new EventHandler(OnMinorGridsVisibleMenuPopup));

            AddMenuItem(cursorContextMenu, "Color ...", new EventHandler(OnColorMenuClick), null);

            string[] snapModes = Enum.GetNames(typeof(CursorSnapMode));
            AddMenuItem(cursorContextMenu, "Snap Mode", snapModes, new EventHandler(OnSnapModeMenuClick), new EventHandler(OnSnapModeMenuPopup));

            string[] lineStyles = EnumObject.GetNames(typeof(LineStyle));
            AddMenuItem(cursorContextMenu, "Line Style", lineStyles, new EventHandler(OnLineStyleMenuClick), new EventHandler(OnLineStyleMenuPopup));

            float[] lineWidths = new float[] { 1, 2, 3, 4, 5 };
            if (DataConverter.CanConvert(lineWidths, typeof(string[])))
            {
                string[] lineWidthStrings = DataConverter.Convert(lineWidths, typeof(string[])) as string[];
                AddMenuItem(cursorContextMenu, "Line Width", lineWidthStrings, new EventHandler(OnLineWidthMenuClick), new EventHandler(OnLineWidthMenuPopup));
            }

            AddMenuItem(plotContextMenu, "Anti-Aliased", boolStrings, new EventHandler(OnAntiAliasedMenuClick), new EventHandler(OnAntiAliasedMenuPopup));

            string[] fillModes = Enum.GetNames(typeof(PlotFillMode));
            AddMenuItem(plotContextMenu, "Fill Mode", fillModes, new EventHandler(OnFillModeMenuClick), new EventHandler(OnFillModeMenuPopup));

            double[] baseYValues = new double[5] { Double.PositiveInfinity, 5, 0, -5, Double.NegativeInfinity };
            if (DataConverter.CanConvert(baseYValues, typeof(string[])))
            {
                string[] baseYValueStrings = DataConverter.Convert(baseYValues, typeof(string[])) as string[];
                AddMenuItem(plotContextMenu, "Base Y Value", baseYValueStrings, new EventHandler(OnBaseYValueMenuClick), new EventHandler(OnBaseYValueMenuPopup));
            }

            string[] fillBaseStyles = EnumObject.GetNames(typeof(FillStyle));
            AddMenuItem(plotContextMenu, "Fill To Base Style", fillBaseStyles, new EventHandler(OnFillBaseStyleMenuClick), new EventHandler(OnFillBaseStyleMenuPopup));

            string[] shapeZOrder = Enum.GetNames(typeof(AnnotationZOrder));
            AddMenuItem(annotationContextMenu, "Shape Z-Order", shapeZOrder, new EventHandler(OnShapeZOrderMenuClick), new EventHandler(OnShapeZOrderMenuPopup));

            string[] arrowHeadStyle = EnumObject.GetNames(typeof(ArrowStyle));
            AddMenuItem(annotationContextMenu, "Arrow Head Style", arrowHeadStyle,  new EventHandler(OnArrowHeadStyleMenuClick), new EventHandler(OnArrowHeadStyleMenuPopup));

            AddMenuItem(annotationContextMenu, "Caption Font ...", new EventHandler(OnCaptionFontMenuClick), null);
		}

        private static void AddMenuItem(ContextMenu destination, string caption, EventHandler onClick, EventHandler onPopup)
        {
            MenuItem menu = destination.MenuItems.Add(caption, onClick);
            menu.Popup += onPopup;
        }

        private static void AddMenuItem(ContextMenu destination, string caption, string[] menuItemCaptions, EventHandler onItemClick, EventHandler onPopup)
        {            
            MenuItem[] menuItems = new MenuItem[menuItemCaptions.Length];
            for (int i = 0; i < menuItemCaptions.Length; ++i)
            {
                menuItems[i] = new MenuItem(menuItemCaptions[i], onItemClick);
            }
            MenuItem menu = destination.MenuItems.Add(caption, menuItems);
            menu.Popup += onPopup;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.annotation = new NationalInstruments.UI.XYPointAnnotation();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.dataCursor = new NationalInstruments.UI.XYCursor();
            this.whiteNoisePlot = new NationalInstruments.UI.WaveformPlot();
            this.plotLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.sinePlotLegendItem = new NationalInstruments.UI.LegendItem();
            this.cursorLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.dataLegendItem = new NationalInstruments.UI.LegendItem();
            this.plotContextMenu = new System.Windows.Forms.ContextMenu();
            this.cursorContextMenu = new System.Windows.Forms.ContextMenu();
            this.annotationContextMenu = new System.Windows.Forms.ContextMenu();
            this.axisContextMenu = new System.Windows.Forms.ContextMenu();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotLegend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Annotations.AddRange(new NationalInstruments.UI.XYAnnotation[] {
            this.annotation});
            this.sampleWaveformGraph.Caption = "Waveform Graph";
            this.sampleWaveformGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
            this.dataCursor});
            this.sampleWaveformGraph.Location = new System.Drawing.Point(7, 7);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.whiteNoisePlot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(370, 268);
            this.sampleWaveformGraph.TabIndex = 0;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            this.sampleWaveformGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnGraphMouseDown);
            // 
            // annotation
            // 
            this.annotation.Caption = "Annotation";
            this.annotation.ShapeFillColor = System.Drawing.Color.Brown;
            this.annotation.ShapeSize = new System.Drawing.Size(25, 25);
            this.annotation.ShapeStyle = NationalInstruments.UI.ShapeStyle.Oval;
            this.annotation.XAxis = this.xAxis;
            this.annotation.YAxis = this.yAxis;
            // 
            // dataCursor
            // 
            this.dataCursor.Color = System.Drawing.Color.CornflowerBlue;
            this.dataCursor.LabelVisible = true;
            this.dataCursor.Plot = this.whiteNoisePlot;
            this.dataCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.NearestPoint;
            // 
            // whiteNoisePlot
            // 
            this.whiteNoisePlot.AntiAliased = true;
            this.whiteNoisePlot.LineColor = System.Drawing.Color.DarkOrange;
            this.whiteNoisePlot.PointColor = System.Drawing.Color.Gold;
            this.whiteNoisePlot.PointStyle = NationalInstruments.UI.PointStyle.Cross;
            this.whiteNoisePlot.ToolTipsEnabled = true;
            this.whiteNoisePlot.XAxis = this.xAxis;
            this.whiteNoisePlot.YAxis = this.yAxis;
            // 
            // plotLegend
            // 
            this.plotLegend.Border = NationalInstruments.UI.Border.Solid;
            this.plotLegend.Caption = "Plots";
            this.plotLegend.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
            this.sinePlotLegendItem});
            this.plotLegend.Location = new System.Drawing.Point(377, 7);
            this.plotLegend.Name = "plotLegend";
            this.plotLegend.Size = new System.Drawing.Size(106, 134);
            this.plotLegend.TabIndex = 1;
            this.plotLegend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnPlotLegendMouseDown);
            // 
            // sinePlotLegendItem
            // 
            this.sinePlotLegendItem.Source = this.whiteNoisePlot;
            this.sinePlotLegendItem.Text = "White Noise";
            // 
            // cursorLegend
            // 
            this.cursorLegend.Border = NationalInstruments.UI.Border.Solid;
            this.cursorLegend.Caption = "Cursors";
            this.cursorLegend.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
            this.dataLegendItem});
            this.cursorLegend.Location = new System.Drawing.Point(377, 141);
            this.cursorLegend.Name = "cursorLegend";
            this.cursorLegend.Size = new System.Drawing.Size(106, 134);
            this.cursorLegend.TabIndex = 2;
            this.cursorLegend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnCursorLegendMouseDown);
            // 
            // dataLegendItem
            // 
            this.dataLegendItem.Source = this.dataCursor;
            this.dataLegendItem.Text = "Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(491, 282);
            this.Controls.Add(this.cursorLegend);
            this.Controls.Add(this.plotLegend);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Runtime Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotLegend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorLegend)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

        private void OnGraphMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Hit test the graph and show the context menu
            if (e.Button == MouseButtons.Right)
            {
                XAxis hitXAxis = sampleWaveformGraph.GetXAxisAt(e.X, e.Y);
                if (hitXAxis != null)
                {
                    contextAxis = hitXAxis;
                    axisContextMenu.Show(sampleWaveformGraph, new Point(e.X, e.Y));
                }
                else
                {
                    YAxis hitYAxis = sampleWaveformGraph.GetYAxisAt(e.X, e.Y);
                    if (hitYAxis != null)
                    {
                        contextAxis = hitYAxis;
                        axisContextMenu.Show(sampleWaveformGraph, new Point(e.X, e.Y));
                    }
                    else
                    {
                        XYCursor hitCursor = sampleWaveformGraph.GetCursorAt(e.X, e.Y);
                        if (hitCursor != null)
                        {
                            contextCursor = hitCursor;
                            cursorContextMenu.Show(sampleWaveformGraph, new Point(e.X, e.Y));
                        }
                        else
                        {
                            XYPlot hitPlot = sampleWaveformGraph.GetPlotAt(e.X, e.Y);
                            if (hitPlot != null)
                            {
                                contextPlot = hitPlot;
                                plotContextMenu.Show(sampleWaveformGraph, new Point(e.X, e.Y));
                            }
                            else
                            {
                                XYAnnotation hitAnnotation = sampleWaveformGraph.GetAnnotationAt(e.X, e.Y);
                                if (hitAnnotation != null)
                                {
                                    contextAnnotation = hitAnnotation;
                                    annotationContextMenu.Show(sampleWaveformGraph, new Point(e.X, e.Y));
                                }
                            }
                        }
                    }
                }
            }
        }

        private void OnPlotLegendMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Hit test the legend and show the context menu
            if (e.Button == MouseButtons.Right)
            {
                LegendItem hitItem = plotLegend.GetItemAt(e.X, e.Y);
                if (hitItem != null)
                {
                    contextPlot = hitItem.Source as XYPlot;
                    plotContextMenu.Show(plotLegend, new Point(e.X, e.Y));
                }
            }
        }

        private void OnCursorLegendMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Hit test the legend and show the context menu
            if (e.Button == MouseButtons.Right)
            {
                LegendItem hitItem = cursorLegend.GetItemAt(e.X, e.Y);
                if (hitItem != null)
                {
                    contextCursor = hitItem.Source as XYCursor;
                    cursorContextMenu.Show(cursorLegend, new Point(e.X, e.Y));
                }
            }
        }

        private void OnInvertedMenuClick(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool inverted = System.Boolean.Parse(menuItem.Text);
                    contextAxis.Inverted = inverted;
                }

                contextAxis = null;
            }
        }

        private void OnInvertedMenuPopup(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool inverted = System.Boolean.Parse(menuItem.Text);
                    if (contextAxis.Inverted == inverted)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnScaleTypeMenuClick(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    ScaleType scaleType = (ScaleType) Enum.Parse(typeof(ScaleType), menuItem.Text);
                    contextAxis.ScaleType = scaleType;
                }

                contextAxis = null;
            }
        }

        private void OnScaleTypeMenuPopup(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    ScaleType scaleType = (ScaleType) Enum.Parse(typeof(ScaleType), menuItem.Text);
                    if (contextAxis.ScaleType == scaleType)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnMajorGridsVisibleMenuClick(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool majorGridsVisible = System.Boolean.Parse(menuItem.Text);
                    contextAxis.MajorDivisions.GridVisible = majorGridsVisible;
                }

                contextAxis = null;
            }
        }

        private void OnMajorGridsVisibleMenuPopup(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool majorGridsVisible = System.Boolean.Parse(menuItem.Text);
                    if (contextAxis.MajorDivisions.GridVisible == majorGridsVisible)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnMinorGridsVisibleMenuClick(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool minorGridsVisible = System.Boolean.Parse(menuItem.Text);
                    contextAxis.MinorDivisions.GridVisible = minorGridsVisible;
                }

                contextAxis = null;
            }
        }

        private void OnMinorGridsVisibleMenuPopup(object sender, EventArgs e)
        {
            if (contextAxis != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool minorGridsVisible = System.Boolean.Parse(menuItem.Text);
                    if (contextAxis.MinorDivisions.GridVisible == minorGridsVisible)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnColorMenuClick(object sender, EventArgs e)
        {
            if (contextCursor != null)
            {
                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        contextCursor.Color = colorDialog.Color;
                    }
                }

                contextCursor = null;
            }
        }

        private void OnSnapModeMenuClick(object sender, EventArgs e)
        {
            if (contextCursor != null)
            {
                MenuItem menuItem = sender as MenuItem;
                
                if (menuItem != null)
                {
                    CursorSnapMode snapMode = (CursorSnapMode) Enum.Parse(typeof(CursorSnapMode), menuItem.Text);
                    contextCursor.SnapMode = snapMode;
                }

                contextCursor = null;
            }
        }

        private void OnSnapModeMenuPopup(object sender, EventArgs e)
        {
            if (contextCursor != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    CursorSnapMode snapMode = (CursorSnapMode) Enum.Parse(typeof(CursorSnapMode), menuItem.Text);
                    if (contextCursor.SnapMode == snapMode)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnLineStyleMenuClick(object sender, EventArgs e)
        {
            if (contextCursor != null)
            {
                MenuItem menuItem = sender as MenuItem;
                
                if (menuItem != null)
                {
                    LineStyle lineStyle = EnumObject.Parse(typeof(LineStyle), menuItem.Text) as LineStyle;
                    if (lineStyle != null)
                    {
                        contextCursor.LineStyle = lineStyle;
                    }
                }

                contextCursor = null;
            }
        }

        private void OnLineStyleMenuPopup(object sender, EventArgs e)
        {
            if (contextCursor != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    LineStyle lineStyle = EnumObject.Parse(typeof(LineStyle), menuItem.Text) as LineStyle;
                    if (contextCursor.LineStyle == lineStyle)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnLineWidthMenuClick(object sender, EventArgs e)
        {
            if (contextCursor != null)
            {
                MenuItem menuItem = sender as MenuItem;
                
                if (menuItem != null)
                {
                    float lineWidth = Single.Parse(menuItem.Text);
                    contextCursor.LineWidth = lineWidth;
                }

                contextCursor = null;
            }
        }

        private void OnLineWidthMenuPopup(object sender, EventArgs e)
        {
            if (contextCursor != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    double lineWidth = Double.Parse(menuItem.Text);
                    if (contextCursor.LineWidth == lineWidth)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnAntiAliasedMenuClick(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool antiAliased = System.Boolean.Parse(menuItem.Text);
                    contextPlot.AntiAliased = antiAliased;
                }

                contextPlot = null;
            }
        }

        private void OnAntiAliasedMenuPopup(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    bool antiAliased = System.Boolean.Parse(menuItem.Text);
                    if (contextPlot.AntiAliased == antiAliased)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnFillModeMenuClick(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    PlotFillMode fillMode = (PlotFillMode) Enum.Parse(typeof(PlotFillMode), menuItem.Text);
                    contextPlot.FillMode = fillMode;
                }

                contextPlot = null;
            }
        }

        private void OnFillModeMenuPopup(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    PlotFillMode fillMode = (PlotFillMode) Enum.Parse(typeof(PlotFillMode), menuItem.Text);
                    if (contextPlot.FillMode == fillMode)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnFillBaseStyleMenuClick(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    FillStyle fillStyle = EnumObject.Parse(typeof(FillStyle), menuItem.Text) as FillStyle;
                    if (fillStyle != null)
                    {
                        contextPlot.FillToBaseStyle = fillStyle;
                    }
                }

                contextPlot = null;
            }
        }

        private void OnFillBaseStyleMenuPopup(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    FillStyle fillStyle = EnumObject.Parse(typeof(FillStyle), menuItem.Text) as FillStyle;
                    if (fillStyle != null)
                    {
                        if (contextPlot.FillToBaseStyle == fillStyle)
                        {
                            menuItem.Checked = true;
                        }
                        else
                        {
                            menuItem.Checked = false;
                        }
                    }
                }
            }
        }

        private void OnBaseYValueMenuClick(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    double baseYValue = Double.Parse(menuItem.Text, CultureInfo.CurrentCulture);
                    contextPlot.BaseYValue = baseYValue;
                }

                contextPlot = null;
            }
        }

        private void OnBaseYValueMenuPopup(object sender, EventArgs e)
        {
            if (contextPlot != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    double baseYValue = Double.Parse(menuItem.Text, CultureInfo.CurrentCulture);
                    if (contextPlot.BaseYValue == baseYValue)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnShapeZOrderMenuClick(object sender, EventArgs e)
        {
            if (contextAnnotation != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    AnnotationZOrder shapeZOrder = (AnnotationZOrder) Enum.Parse(typeof(AnnotationZOrder), menuItem.Text);
                    if (contextAnnotation is XYPointAnnotation)
                    {
                        XYPointAnnotation contextPointAnnotation = contextAnnotation as XYPointAnnotation;
                        contextPointAnnotation.ShapeZOrder = shapeZOrder;
                    }
                }

                contextAnnotation = null;
            }
        }

        private void OnShapeZOrderMenuPopup(object sender, EventArgs e)
        {
            if (contextAnnotation != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    AnnotationZOrder shapeZOrder = (AnnotationZOrder) Enum.Parse(typeof(AnnotationZOrder), menuItem.Text);
                    if (contextAnnotation is XYPointAnnotation)
                    {
                        XYPointAnnotation contextPointAnnotation = contextAnnotation as XYPointAnnotation;
                        if (contextPointAnnotation.ShapeZOrder == shapeZOrder)
                        {
                            menuItem.Checked = true;
                        }
                        else
                        {
                            menuItem.Checked = false;
                        }
                    }
                }
            }
        }

        private void OnArrowHeadStyleMenuClick(object sender, EventArgs e)
        {
            if (contextAnnotation != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    ArrowStyle arrowStyle = EnumObject.Parse(typeof(ArrowStyle), menuItem.Text) as ArrowStyle;
                    contextAnnotation.ArrowHeadStyle = arrowStyle;
                }

                contextAnnotation = null;
            }
        }

        private void OnArrowHeadStyleMenuPopup(object sender, EventArgs e)
        {
            if (contextAnnotation != null)
            {
                MenuItem menuItem = sender as MenuItem;

                if (menuItem != null)
                {
                    ArrowStyle arrowStyle = EnumObject.Parse(typeof(ArrowStyle), menuItem.Text) as ArrowStyle;
                    if (contextAnnotation.ArrowHeadStyle == arrowStyle)
                    {
                        menuItem.Checked = true;
                    }
                    else
                    {
                        menuItem.Checked = false;
                    }
                }
            }
        }

        private void OnCaptionFontMenuClick(object sender, EventArgs e)
        {
            if (contextAnnotation != null)
            {
                using (FontDialog fontDialog = new FontDialog())
                {
                    if (fontDialog.ShowDialog() == DialogResult.OK)
                    {
                        contextAnnotation.CaptionFont = fontDialog.Font;
                    }
                }

                contextAnnotation = null;
            }
        }
    }
}
