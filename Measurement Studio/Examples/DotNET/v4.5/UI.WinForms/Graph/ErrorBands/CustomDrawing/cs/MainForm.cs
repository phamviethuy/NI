
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomDrawing
{

    public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.XAxis xAxis;
        private System.Windows.Forms.Panel displayModePanel;
        private NationalInstruments.UI.ScatterPlot scatterPlot;
        private System.Windows.Forms.GroupBox errorModeGroupBox;
        private System.Windows.Forms.RadioButton boxModeRadioButton;
        private System.Windows.Forms.RadioButton regionModeRadioButton;
        private System.Windows.Forms.RadioButton normalModeRadioButton;
        private NationalInstruments.UI.WindowsForms.ScatterGraph sampleScatterGraph;
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			InitializeComponent();
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
			this.yAxis = new NationalInstruments.UI.YAxis();
			this.xAxis = new NationalInstruments.UI.XAxis();
			this.displayModePanel = new System.Windows.Forms.Panel();
			this.scatterPlot = new NationalInstruments.UI.ScatterPlot();
			this.sampleScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
			this.errorModeGroupBox = new System.Windows.Forms.GroupBox();
			this.boxModeRadioButton = new System.Windows.Forms.RadioButton();
			this.regionModeRadioButton = new System.Windows.Forms.RadioButton();
			this.normalModeRadioButton = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).BeginInit();
			this.errorModeGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// displayModePanel
			// 
			this.displayModePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.displayModePanel.DockPadding.Bottom = 8;
			this.displayModePanel.DockPadding.Top = 8;
			this.displayModePanel.Location = new System.Drawing.Point(8, 294);
			this.displayModePanel.Name = "displayModePanel";
			this.displayModePanel.Size = new System.Drawing.Size(376, 8);
			this.displayModePanel.TabIndex = 4;
			// 
			// scatterPlot
			// 
			this.scatterPlot.PointSize = new System.Drawing.Size(7, 7);
			this.scatterPlot.PointStyle = NationalInstruments.UI.PointStyle.SolidDiamond;
			this.scatterPlot.XAxis = this.xAxis;
			this.scatterPlot.YAxis = this.yAxis;
			this.scatterPlot.YErrorDataMode = NationalInstruments.UI.XYErrorDataMode.CreatePercentErrorMode(4);
			this.scatterPlot.YErrorHighLineColor = System.Drawing.Color.DodgerBlue;
			this.scatterPlot.YErrorHighPointColor = System.Drawing.Color.DodgerBlue;
			this.scatterPlot.YErrorHighPointSize = new System.Drawing.Size(7, 7);
			this.scatterPlot.YErrorHighPointStyle = NationalInstruments.UI.PointStyle.SolidCircle;
			this.scatterPlot.YErrorLowLineColor = System.Drawing.Color.DodgerBlue;
			this.scatterPlot.YErrorLowPointColor = System.Drawing.Color.DodgerBlue;
			this.scatterPlot.YErrorLowPointSize = new System.Drawing.Size(7, 7);
			this.scatterPlot.YErrorLowPointStyle = NationalInstruments.UI.PointStyle.SolidCircle;
			this.scatterPlot.BeforeDraw += new NationalInstruments.UI.BeforeDrawXYPlotEventHandler(this.scatterPlot_BeforeDraw);
			// 
			// sampleScatterGraph
			// 
			this.sampleScatterGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.sampleScatterGraph.Location = new System.Drawing.Point(8, 8);
			this.sampleScatterGraph.Name = "sampleScatterGraph";
			this.sampleScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
																								this.scatterPlot});
			this.sampleScatterGraph.Size = new System.Drawing.Size(376, 286);
			this.sampleScatterGraph.TabIndex = 5;
			this.sampleScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
																						  this.xAxis});
			this.sampleScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
																						  this.yAxis});
			// 
			// errorModeGroupBox
			// 
			this.errorModeGroupBox.Controls.Add(this.boxModeRadioButton);
			this.errorModeGroupBox.Controls.Add(this.regionModeRadioButton);
			this.errorModeGroupBox.Controls.Add(this.normalModeRadioButton);
			this.errorModeGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.errorModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.errorModeGroupBox.Location = new System.Drawing.Point(8, 302);
			this.errorModeGroupBox.Name = "errorModeGroupBox";
			this.errorModeGroupBox.Size = new System.Drawing.Size(376, 112);
			this.errorModeGroupBox.TabIndex = 3;
			this.errorModeGroupBox.TabStop = false;
			this.errorModeGroupBox.Text = "&Custom Drawing";
			// 
			// boxModeRadioButton
			// 
			this.boxModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.boxModeRadioButton.Location = new System.Drawing.Point(16, 80);
			this.boxModeRadioButton.Name = "boxModeRadioButton";
			this.boxModeRadioButton.Size = new System.Drawing.Size(112, 24);
			this.boxModeRadioButton.TabIndex = 2;
			this.boxModeRadioButton.Text = "&Box and Whisker";
			this.boxModeRadioButton.CheckedChanged += new System.EventHandler(this.boxModeRadioButton_CheckedChanged);
			// 
			// regionModeRadioButton
			// 
			this.regionModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.regionModeRadioButton.Location = new System.Drawing.Point(16, 52);
			this.regionModeRadioButton.Name = "regionModeRadioButton";
			this.regionModeRadioButton.Size = new System.Drawing.Size(112, 24);
			this.regionModeRadioButton.TabIndex = 1;
			this.regionModeRadioButton.Text = "&Region";
			this.regionModeRadioButton.CheckedChanged += new System.EventHandler(this.regionModeRadioButton_CheckedChanged);
			// 
			// normalModeRadioButton
			// 
			this.normalModeRadioButton.Checked = true;
			this.normalModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.normalModeRadioButton.Location = new System.Drawing.Point(16, 24);
			this.normalModeRadioButton.Name = "normalModeRadioButton";
			this.normalModeRadioButton.Size = new System.Drawing.Size(112, 24);
			this.normalModeRadioButton.TabIndex = 0;
			this.normalModeRadioButton.TabStop = true;
			this.normalModeRadioButton.Text = "&Normal";
			this.normalModeRadioButton.CheckedChanged += new System.EventHandler(this.normalModeRadioButton_CheckedChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(392, 422);
			this.Controls.Add(this.sampleScatterGraph);
			this.Controls.Add(this.displayModePanel);
			this.Controls.Add(this.errorModeGroupBox);
			this.DockPadding.All = 8;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(200, 321);
			this.Name = "MainForm";
			this.Text = "Custom Drawing";
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).EndInit();
			this.errorModeGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
		}

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            const int pointCount = 7;
            double[] xData = new double[pointCount];
            double[] yData = new double[pointCount];

            const int regions = 3;
            const int regionThreshold = pointCount / regions;
            int threshold = -1;

            double current = 0.0;
            bool largeIncrement = false;
            double pointIncrement = 0.0;
            for (int i = 0; i < pointCount; ++i)
            {
                if (i > threshold)
                {
                    threshold += regionThreshold;
                    largeIncrement = !largeIncrement;
                    pointIncrement = (largeIncrement ? 2.0 : -1.0);
                }

                xData[i] = i;
                yData[i] = current;

                current += pointIncrement;
            }

            scatterPlot.PlotXY(xData, yData);
        }

        private void normalModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            scatterPlot.Invalidate();
        }

        private void regionModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            scatterPlot.Invalidate();
        }

        private void boxModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            // Switch to appropriate point styles.
            if(boxModeRadioButton.Checked)
            {
                scatterPlot.YErrorHighPointStyle = PointStyle.SolidTriangleUp;
                scatterPlot.YErrorLowPointStyle = PointStyle.SolidSquare;
            }
            else
            {
                scatterPlot.YErrorHighPointStyle = PointStyle.SolidCircle;
                scatterPlot.YErrorLowPointStyle = PointStyle.SolidCircle;
            }

            scatterPlot.Invalidate();
        }

        private void scatterPlot_BeforeDraw(object sender, NationalInstruments.UI.BeforeDrawXYPlotEventArgs e)
        {
            if(!normalModeRadioButton.Checked)
            {
                e.Cancel = true;

                Rectangle b = e.Bounds;
                Graphics g = e.Graphics;
                ComponentDrawArgs args = new ComponentDrawArgs(g, b);

                PointF[] highErrorPoints = e.Plot.MapYErrorHighData(b);
                PointF[] lowErrorPoints = e.Plot.MapYErrorLowData(b);
                PointF[] plotPoints = e.Plot.MapDataPoints(b);
                int length = highErrorPoints.Length;

                Color referenceColor = e.Plot.YErrorHighPointColor;
                using(Pen borderPen = new Pen(referenceColor))
                {
                    e.Plot.DrawLines(args);

                    if(regionModeRadioButton.Checked)
                    {
                        // Fill the region covered by the error data.
                        using(Brush regionBrush = new SolidBrush(Color.FromArgb(128, referenceColor)))
                        {
                            for(int i = 0; i < length - 1; ++i)
                            {
                                GraphicsPath path = new GraphicsPath(FillMode.Winding);
                                path.AddLine(highErrorPoints[i], highErrorPoints[i+1]);
                                path.AddLine(lowErrorPoints[i+1], lowErrorPoints[i]);

                                g.FillPath(regionBrush, path);
                            }
                        }

                        // Draw a border around the region.
                        g.DrawLines(borderPen, highErrorPoints);
                        g.DrawLines(borderPen, lowErrorPoints);
                    }

                    e.Plot.DrawErrorBands(args);

                    if(boxModeRadioButton.Checked)
                    {
                        // Draw boxes in the style of "Box and Whisker" statistical plots, centered on the plot data points.
                        float boxWidth = (float)(3 * b.Width) / (4 * length);
                        using(Brush boxBrush = new SolidBrush(Color.LightGray))
                        {
                            for(int i = 0; i < length; ++i)
                            {
                                float boxHeight = (lowErrorPoints[i].Y - highErrorPoints[i].Y) / 2;
                                float boxLeft = plotPoints[i].X - (boxWidth / 2);
                                float boxTop = plotPoints[i].Y - (boxHeight / 2);
                                RectangleF box = new RectangleF(boxLeft, boxTop, boxWidth, boxHeight);

                                g.FillRectangle(boxBrush, box.X, box.Y, box.Width, box.Height);
                                g.DrawRectangle(borderPen, box.X, box.Y, box.Width, box.Height);
                                g.DrawLine(borderPen, boxLeft, plotPoints[i].Y, boxLeft + boxWidth, plotPoints[i].Y);
                            }
                        }
                    }

                    e.Plot.DrawPoints(args);
                }
            }
        }
	}

}
