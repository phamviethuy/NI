using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Printing
{
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private System.Windows.Forms.PrintPreviewDialog graphPrintPreviewDialog;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.RadioButton optionGraphRadioButton;
        private System.Windows.Forms.RadioButton optionStackedPlotsRadioButton;
        private System.Windows.Forms.RadioButton optionSineWaveRadioButton;
        private System.Windows.Forms.RadioButton optionTriangleWaveRadioButton;
        private System.Windows.Forms.RadioButton optionSquareWaveRadioButton;
        private System.Windows.Forms.Button printPreviewButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.ToolTip applicationToolTip;
        private NationalInstruments.UI.WaveformPlot sineWavePlot;
        private NationalInstruments.UI.WaveformPlot triangleWavePlot;
        private NationalInstruments.UI.WaveformPlot squareWavePlot;
		private NationalInstruments.UI.WindowsForms.Legend graphLegend;
		private NationalInstruments.UI.LegendItem legendItem1;
		private NationalInstruments.UI.LegendItem legendItem2;
		private NationalInstruments.UI.LegendItem legendItem3;
        private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            sineWavePlot.PlotY(GenerateSineWave(100, 10));
            triangleWavePlot.PlotY(GenerateTriangleWave(100, 3, 7, 10), 0, 10);
            squareWavePlot.PlotY(GenerateTriangleWave(100, 2, 8, 10), 0, 10);
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
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.sineWavePlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.triangleWavePlot = new NationalInstruments.UI.WaveformPlot();
            this.squareWavePlot = new NationalInstruments.UI.WaveformPlot();
            this.graphPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.printButton = new System.Windows.Forms.Button();
            this.printPreviewButton = new System.Windows.Forms.Button();
            this.optionSquareWaveRadioButton = new System.Windows.Forms.RadioButton();
            this.optionTriangleWaveRadioButton = new System.Windows.Forms.RadioButton();
            this.optionSineWaveRadioButton = new System.Windows.Forms.RadioButton();
            this.optionStackedPlotsRadioButton = new System.Windows.Forms.RadioButton();
            this.optionGraphRadioButton = new System.Windows.Forms.RadioButton();
            this.applicationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.graphLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.legendItem1 = new NationalInstruments.UI.LegendItem();
            this.legendItem2 = new NationalInstruments.UI.LegendItem();
            this.legendItem3 = new NationalInstruments.UI.LegendItem();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graphLegend)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleWaveformGraph.Caption = "2D Graph";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.sineWavePlot,
            this.triangleWavePlot,
            this.squareWavePlot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(313, 288);
            this.sampleWaveformGraph.TabIndex = 0;
            this.applicationToolTip.SetToolTip(this.sampleWaveformGraph, "National Instruments 2D Graph");
            this.sampleWaveformGraph.UseColorGenerator = true;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // sineWavePlot
            // 
            this.sineWavePlot.LineWidth = 2F;
            this.sineWavePlot.XAxis = this.xAxis;
            this.sineWavePlot.YAxis = this.yAxis;
            // 
            // triangleWavePlot
            // 
            this.triangleWavePlot.LineWidth = 2F;
            this.triangleWavePlot.XAxis = this.xAxis;
            this.triangleWavePlot.YAxis = this.yAxis;
            // 
            // squareWavePlot
            // 
            this.squareWavePlot.LineStep = NationalInstruments.UI.LineStep.XYStep;
            this.squareWavePlot.LineWidth = 2F;
            this.squareWavePlot.XAxis = this.xAxis;
            this.squareWavePlot.YAxis = this.yAxis;
            // 
            // graphPrintPreviewDialog
            // 
            this.graphPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.graphPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.graphPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.graphPrintPreviewDialog.Enabled = true;
            this.graphPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("graphPrintPreviewDialog.Icon")));
            this.graphPrintPreviewDialog.Name = "printPreview";
            this.graphPrintPreviewDialog.Visible = false;
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.Controls.Add(this.printButton);
            this.settingsGroupBox.Controls.Add(this.printPreviewButton);
            this.settingsGroupBox.Controls.Add(this.optionSquareWaveRadioButton);
            this.settingsGroupBox.Controls.Add(this.optionTriangleWaveRadioButton);
            this.settingsGroupBox.Controls.Add(this.optionSineWaveRadioButton);
            this.settingsGroupBox.Controls.Add(this.optionStackedPlotsRadioButton);
            this.settingsGroupBox.Controls.Add(this.optionGraphRadioButton);
            this.settingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.settingsGroupBox.Location = new System.Drawing.Point(8, 304);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(315, 120);
            this.settingsGroupBox.TabIndex = 1;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Print Settings";
            // 
            // printButton
            // 
            this.printButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printButton.Location = new System.Drawing.Point(215, 56);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(92, 23);
            this.printButton.TabIndex = 6;
            this.printButton.Text = "Print";
            this.printButton.Click += new System.EventHandler(this.OnPrintClick);
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printPreviewButton.Location = new System.Drawing.Point(215, 24);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(92, 23);
            this.printPreviewButton.TabIndex = 5;
            this.printPreviewButton.Text = "Print Preview ...";
            this.printPreviewButton.Click += new System.EventHandler(this.OnPrintPreviewClick);
            // 
            // optionSquareWaveRadioButton
            // 
            this.optionSquareWaveRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionSquareWaveRadioButton.Location = new System.Drawing.Point(16, 54);
            this.optionSquareWaveRadioButton.Name = "optionSquareWaveRadioButton";
            this.optionSquareWaveRadioButton.Size = new System.Drawing.Size(104, 24);
            this.optionSquareWaveRadioButton.TabIndex = 4;
            this.optionSquareWaveRadioButton.Text = "Square wave";
            this.applicationToolTip.SetToolTip(this.optionSquareWaveRadioButton, "Prints the square wave only.");
            // 
            // optionTriangleWaveRadioButton
            // 
            this.optionTriangleWaveRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionTriangleWaveRadioButton.Location = new System.Drawing.Point(16, 88);
            this.optionTriangleWaveRadioButton.Name = "optionTriangleWaveRadioButton";
            this.optionTriangleWaveRadioButton.Size = new System.Drawing.Size(104, 24);
            this.optionTriangleWaveRadioButton.TabIndex = 3;
            this.optionTriangleWaveRadioButton.Text = "Triangle wave";
            this.applicationToolTip.SetToolTip(this.optionTriangleWaveRadioButton, "Prints the triangle wave only.");
            // 
            // optionSineWaveRadioButton
            // 
            this.optionSineWaveRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionSineWaveRadioButton.Location = new System.Drawing.Point(16, 20);
            this.optionSineWaveRadioButton.Name = "optionSineWaveRadioButton";
            this.optionSineWaveRadioButton.Size = new System.Drawing.Size(104, 24);
            this.optionSineWaveRadioButton.TabIndex = 2;
            this.optionSineWaveRadioButton.Text = "Sine wave";
            this.applicationToolTip.SetToolTip(this.optionSineWaveRadioButton, "Prints the sine wave only.");
            // 
            // optionStackedPlotsRadioButton
            // 
            this.optionStackedPlotsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionStackedPlotsRadioButton.Location = new System.Drawing.Point(128, 54);
            this.optionStackedPlotsRadioButton.Name = "optionStackedPlotsRadioButton";
            this.optionStackedPlotsRadioButton.Size = new System.Drawing.Size(104, 24);
            this.optionStackedPlotsRadioButton.TabIndex = 1;
            this.optionStackedPlotsRadioButton.Text = "Stacked plots";
            this.applicationToolTip.SetToolTip(this.optionStackedPlotsRadioButton, "Prints all plots stacked in separate plot areas.");
            // 
            // optionGraphRadioButton
            // 
            this.optionGraphRadioButton.Checked = true;
            this.optionGraphRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.optionGraphRadioButton.Location = new System.Drawing.Point(128, 20);
            this.optionGraphRadioButton.Name = "optionGraphRadioButton";
            this.optionGraphRadioButton.Size = new System.Drawing.Size(104, 24);
            this.optionGraphRadioButton.TabIndex = 0;
            this.optionGraphRadioButton.TabStop = true;
            this.optionGraphRadioButton.Text = "Graph";
            this.applicationToolTip.SetToolTip(this.optionGraphRadioButton, "Prints the entire graph.");
            // 
            // graphLegend
            // 
            this.graphLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.graphLegend.Items.AddRange(new NationalInstruments.UI.LegendItem[] {
            this.legendItem1,
            this.legendItem2,
            this.legendItem3});
            this.graphLegend.Location = new System.Drawing.Point(329, 213);
            this.graphLegend.Name = "graphLegend";
            this.graphLegend.Size = new System.Drawing.Size(88, 98);
            this.graphLegend.TabIndex = 2;
            // 
            // legendItem1
            // 
            this.legendItem1.Source = this.sineWavePlot;
            this.legendItem1.Text = "Sine";
            // 
            // legendItem2
            // 
            this.legendItem2.Source = this.squareWavePlot;
            this.legendItem2.Text = "Square";
            // 
            // legendItem3
            // 
            this.legendItem3.Source = this.triangleWavePlot;
            this.legendItem3.Text = "Triangle";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(431, 430);
            this.Controls.Add(this.graphLegend);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(360, 456);
            this.Name = "MainForm";
            this.Text = "Printing Example";
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graphLegend)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        private static double[] GenerateSineWave(int xRange, int yRange)
        {
            if (xRange < 0)
            {
                throw new ArgumentOutOfRangeException("xRange");
            }

            if (yRange < 0)
            {
                throw new ArgumentOutOfRangeException("yRange");
            }

            double[] data = new double[xRange];
            for (int i = 0; i < xRange; ++i)
            {
                data[i] = yRange / 2 * (1 - (float)Math.Sin(i * 2 * Math.PI / (xRange - 1)));
            }

            return data;
        }

        private static double[] GenerateTriangleWave(int xRange, int yMin, int yMax, double interval)
        {
            if (xRange < 0)
            {
                throw new ArgumentOutOfRangeException("xRange");
            }

            if (yMin < 0)
            {
                throw new ArgumentOutOfRangeException("yMin");
            }

            if (yMax < 0)
            {
                throw new ArgumentOutOfRangeException("yMax");
            }

            if (interval < 0)
            {
                throw new ArgumentOutOfRangeException("interval");
            }

            int count = (int)(xRange / interval) + 1;
            double[] data = new double[count];

            for (int i = 0; i < count; ++i)
            {
                data[i] = (((i % 2) == 0) ? yMin : yMax);
            }

            return data;
        }

        private void PrintPageEntireGraph(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = e.MarginBounds;

            sampleWaveformGraph.Draw(new ComponentDrawArgs(g, bounds));
        }
    
        private void PrintPageAllPlotsStacked(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = e.MarginBounds;			
            Rectangle originalXAxisBounds = xAxis.GetBounds();
            Rectangle originalYAxisBounds = yAxis.GetBounds();

            int plotWidth = bounds.Width - originalYAxisBounds.Width;
            int plotHeight = ((bounds.Height - (originalXAxisBounds.Height * 4)) / 3);

            // Draw the sine wave plot
            Rectangle sinePlotBounds = new Rectangle(
                bounds.X + originalYAxisBounds.Width,
                bounds.Y + originalXAxisBounds.Height,
                plotWidth,
                plotHeight
                );

            // Draw a common x axis at the top of the stack.
            Rectangle topXAxisBounds = xAxis.GetBounds(g, sinePlotBounds, XAxisPosition.Top);
            xAxis.Draw(new ComponentDrawArgs(g, topXAxisBounds), XAxisPosition.Top);

            Rectangle sineYAxisBounds = yAxis.GetBounds(g, sinePlotBounds);
            yAxis.Draw(new ComponentDrawArgs(g, sineYAxisBounds), YAxisPosition.Left);
            g.FillRectangle(Brushes.Black, sinePlotBounds);
            sineWavePlot.Draw(new ComponentDrawArgs(g, sinePlotBounds));

            // Draw the triangle wave plot
            Rectangle trianglePlotBounds = new Rectangle(
                bounds.X + originalYAxisBounds.Width,
                bounds.Y + (originalXAxisBounds.Height * 2) + plotHeight,
                plotWidth,
                plotHeight
                );

            Rectangle triangleYAxisBounds = yAxis.GetBounds(g, trianglePlotBounds);
            yAxis.Draw(new ComponentDrawArgs(g, triangleYAxisBounds), YAxisPosition.Left);
            g.FillRectangle(Brushes.Black, trianglePlotBounds);
            triangleWavePlot.Draw(new ComponentDrawArgs(g, trianglePlotBounds));

            // Draw the square wave plot
            Rectangle squarePlotBounds = new Rectangle(
                bounds.X + originalYAxisBounds.Width,
                bounds.Y + (originalXAxisBounds.Height * 3) + (plotHeight * 2),
                plotWidth,
                plotHeight
                );

            Rectangle squareYAxisBounds = yAxis.GetBounds(g, squarePlotBounds);
            yAxis.Draw(new ComponentDrawArgs(g, squareYAxisBounds), YAxisPosition.Left);
            g.FillRectangle(Brushes.Black, squarePlotBounds);
            squareWavePlot.Draw(new ComponentDrawArgs(g, squarePlotBounds));

            // Draw a common x axis at the bottom of the stack.
            Rectangle bottomXAxisBounds = xAxis.GetBounds(g, squarePlotBounds);
            xAxis.Draw(new ComponentDrawArgs(g, bottomXAxisBounds), XAxisPosition.Bottom);
        }
    
        private void PrintPageOnlySineWave(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle plotBounds, xAxisBounds, yAxisBounds;
            GetElementsBounds(e, out plotBounds, out xAxisBounds, out yAxisBounds);

            xAxis.Draw(new ComponentDrawArgs(g, xAxisBounds), XAxisPosition.Bottom);
            yAxis.Draw(new ComponentDrawArgs(g, yAxisBounds), YAxisPosition.Left);

            g.FillRectangle(Brushes.Black, plotBounds);
            sineWavePlot.Draw(new ComponentDrawArgs(g, plotBounds));
        }
    
        private void PrintPageOnlyTriangleWave(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle plotBounds, xAxisBounds, yAxisBounds;
            GetElementsBounds(e, out plotBounds, out xAxisBounds, out yAxisBounds);

            xAxis.Draw(new ComponentDrawArgs(g, xAxisBounds), XAxisPosition.Bottom);
            yAxis.Draw(new ComponentDrawArgs(g, yAxisBounds), YAxisPosition.Left);

            g.FillRectangle(Brushes.Black, plotBounds);
            triangleWavePlot.Draw(new ComponentDrawArgs(g, plotBounds));
        }
    
        private void PrintPageOnlySquareWave(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle plotBounds, xAxisBounds, yAxisBounds;
            GetElementsBounds(e, out plotBounds, out xAxisBounds, out yAxisBounds);

            xAxis.Draw(new ComponentDrawArgs(g, xAxisBounds), XAxisPosition.Bottom);
            yAxis.Draw(new ComponentDrawArgs(g, yAxisBounds), YAxisPosition.Left);

            g.FillRectangle(Brushes.Black, plotBounds);
            squareWavePlot.Draw(new ComponentDrawArgs(g, plotBounds));
        }

        private void OnPrintPreviewClick(object sender, System.EventArgs e)
        {
            using (PrintDocument document = new PrintDocument())
            {
                if (document.PrinterSettings.IsValid)
                {
                    document.PrintPage += GetPrintPageEventHandler();
                    graphPrintPreviewDialog.Document = document;
                    graphPrintPreviewDialog.ShowDialog(this);
                }
                else 
                {
                    MessageBox.Show(this, new InvalidPrinterException(document.PrinterSettings).Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        }

        private void OnPrintClick(object sender, System.EventArgs e)
        {
            using (PrintDocument document = new PrintDocument())
            {
                if (document.PrinterSettings.IsValid)
                {
                    document.PrintPage += GetPrintPageEventHandler();
                    document.Print();
                }
                else 
                {
                    MessageBox.Show(this, new InvalidPrinterException(document.PrinterSettings).Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);                    
                }
            }
        }

        private PrintPageEventHandler GetPrintPageEventHandler()
        {
            PrintPageEventHandler handler = new PrintPageEventHandler(PrintPageEntireGraph);
            if (optionGraphRadioButton.Checked)
            {
                handler = new PrintPageEventHandler(PrintPageEntireGraph);
            }
            else if (optionStackedPlotsRadioButton.Checked)
            {
                handler = new PrintPageEventHandler(PrintPageAllPlotsStacked);
            }
            else if (optionSineWaveRadioButton.Checked)
            {
                handler = new PrintPageEventHandler(PrintPageOnlySineWave);
            }
            else if (optionTriangleWaveRadioButton.Checked)
            {
                handler = new PrintPageEventHandler(PrintPageOnlyTriangleWave);
            }
            else if (optionSquareWaveRadioButton.Checked)
            {
                handler = new PrintPageEventHandler(PrintPageOnlySquareWave);
            }

            return handler;
        }

        private void GetElementsBounds(PrintPageEventArgs e, out Rectangle plotBounds, out Rectangle xAxisBounds, out Rectangle yAxisBounds)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = Rectangle.Inflate(e.MarginBounds, 0, -2 * e.PageSettings.Margins.Top);

            Rectangle originalXAxisBounds = xAxis.GetBounds();
            Rectangle originalYAxisBounds = yAxis.GetBounds();

            plotBounds = new Rectangle(
                bounds.X + originalYAxisBounds.Width,
                bounds.Y + originalXAxisBounds.Height,
                bounds.Width - originalYAxisBounds.Width,
                bounds.Height - (originalXAxisBounds.Height * 2)
                );

            xAxisBounds = xAxis.GetBounds(g, plotBounds);
            yAxisBounds = yAxis.GetBounds(g, plotBounds);
        }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}
	}
}
