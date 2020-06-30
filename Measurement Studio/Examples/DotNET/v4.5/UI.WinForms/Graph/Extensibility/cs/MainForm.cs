using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Extensibility
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class Extensibility : System.Windows.Forms.Form
	{
        private System.Windows.Forms.RadioButton defaultRadioButton;
        private System.Windows.Forms.RadioButton minMaxRadioButton;
        private System.Windows.Forms.RadioButton backgroundRadioButton;
        private System.Windows.Forms.RadioButton incDecRadioButton;
        private NationalInstruments.UI.WindowsForms.WaveformGraph extensWaveformGraph;
        private System.Windows.Forms.GroupBox extensibleStylesGroupBox;
        private NationalInstruments.UI.WaveformPlot plotWaveformPlot;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
     
     
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Extensibility()
		{
			DateTime start;
			DateTime end;
			TimeSpan increment;

			InitializeComponent();

			start = DateTime.Today;
			end = DateTime.Today + TimeSpan.FromHours(24);
			increment = TimeSpan.FromMinutes(30);

			xAxis.Mode = AxisMode.Fixed;
			xAxis.AutoSpacing = false;
			xAxis.MajorDivisions.Base = (double)DataConverter.Convert(start, typeof(double));
			xAxis.MajorDivisions.Interval = (double)DataConverter.Convert(TimeSpan.FromHours(6), typeof(double));
			xAxis.MinorDivisions.Interval = (double)DataConverter.Convert(TimeSpan.FromHours(1), typeof(double));
			xAxis.Range = new Range((double)DataConverter.Convert(start, typeof(double)), (double)DataConverter.Convert(end, typeof(double)));
			
			yAxis.Mode = AxisMode.Fixed;
			yAxis.Range = new Range(-1.0, 1.0);
			
			plotWaveformPlot.PlotY(GenerateData(), start, increment);
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Extensibility));
            this.extensibleStylesGroupBox = new System.Windows.Forms.GroupBox();
            this.backgroundRadioButton = new System.Windows.Forms.RadioButton();
            this.incDecRadioButton = new System.Windows.Forms.RadioButton();
            this.minMaxRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.extensWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.plotWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.extensibleStylesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extensWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // extensibleStylesGroupBox
            // 
            this.extensibleStylesGroupBox.Controls.Add(this.backgroundRadioButton);
            this.extensibleStylesGroupBox.Controls.Add(this.incDecRadioButton);
            this.extensibleStylesGroupBox.Controls.Add(this.minMaxRadioButton);
            this.extensibleStylesGroupBox.Controls.Add(this.defaultRadioButton);
            this.extensibleStylesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.extensibleStylesGroupBox.Location = new System.Drawing.Point(16, 256);
            this.extensibleStylesGroupBox.Name = "extensibleStylesGroupBox";
            this.extensibleStylesGroupBox.Size = new System.Drawing.Size(632, 152);
            this.extensibleStylesGroupBox.TabIndex = 1;
            this.extensibleStylesGroupBox.TabStop = false;
            this.extensibleStylesGroupBox.Text = "Extensible Styles";
            // 
            // backgroundRadioButton
            // 
            this.backgroundRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backgroundRadioButton.Location = new System.Drawing.Point(8, 112);
            this.backgroundRadioButton.Name = "backgroundRadioButton";
            this.backgroundRadioButton.Size = new System.Drawing.Size(608, 32);
            this.backgroundRadioButton.TabIndex = 3;
            this.backgroundRadioButton.Text = "Highlight plot area background regions via custom pre-plot area drawing";
            this.backgroundRadioButton.CheckedChanged += new System.EventHandler(this.OnDrawOptionChanged);
            // 
            // incDecRadioButton
            // 
            this.incDecRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.incDecRadioButton.Location = new System.Drawing.Point(8, 80);
            this.incDecRadioButton.Name = "incDecRadioButton";
            this.incDecRadioButton.Size = new System.Drawing.Size(608, 32);
            this.incDecRadioButton.TabIndex = 2;
            this.incDecRadioButton.Text = "Highlight increasing/decreasing values via custom pre-plot drawing";
            this.incDecRadioButton.CheckedChanged += new System.EventHandler(this.OnDrawOptionChanged);
            // 
            // minMaxRadioButton
            // 
            this.minMaxRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.minMaxRadioButton.Location = new System.Drawing.Point(8, 48);
            this.minMaxRadioButton.Name = "minMaxRadioButton";
            this.minMaxRadioButton.Size = new System.Drawing.Size(608, 32);
            this.minMaxRadioButton.TabIndex = 1;
            this.minMaxRadioButton.Text = "Highlight min/max via custom post-plot drawing";
            this.minMaxRadioButton.CheckedChanged += new System.EventHandler(this.OnDrawOptionChanged);
            // 
            // defaultRadioButton
            // 
            this.defaultRadioButton.Checked = true;
            this.defaultRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultRadioButton.Location = new System.Drawing.Point(8, 16);
            this.defaultRadioButton.Name = "defaultRadioButton";
            this.defaultRadioButton.Size = new System.Drawing.Size(608, 32);
            this.defaultRadioButton.TabIndex = 0;
            this.defaultRadioButton.TabStop = true;
            this.defaultRadioButton.Text = "Default";
            this.defaultRadioButton.CheckedChanged += new System.EventHandler(this.OnDrawOptionChanged);
            // 
            // extensWaveformGraph
            // 
            this.extensWaveformGraph.Location = new System.Drawing.Point(16, 8);
            this.extensWaveformGraph.Name = "extensWaveformGraph";
            this.extensWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                  this.plotWaveformPlot});
            this.extensWaveformGraph.Size = new System.Drawing.Size(632, 240);
            this.extensWaveformGraph.TabIndex = 2;
            this.extensWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                           this.xAxis});
            this.extensWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                           this.yAxis});
            this.extensWaveformGraph.BeforeDrawPlot += new NationalInstruments.UI.BeforeDrawXYPlotEventHandler(this.OnBeforeDrawPlot);
            this.extensWaveformGraph.AfterDrawPlot += new NationalInstruments.UI.AfterDrawXYPlotEventHandler(this.OnAfterDrawPlot);
            this.extensWaveformGraph.BeforeDrawPlotArea += new NationalInstruments.UI.BeforeDrawEventHandler(this.OnBeforeDrawPlotArea);
            // 
            // plotWaveformPlot
            // 
            this.plotWaveformPlot.XAxis = this.xAxis;
            this.plotWaveformPlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "h:mm:ss tt");
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact;
            // 
            // yAxis
            // 
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis.Range = new NationalInstruments.UI.Range(-1.5, 1.5);
            // 
            // Extensibility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(658, 414);
            this.Controls.Add(this.extensWaveformGraph);
            this.Controls.Add(this.extensibleStylesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Extensibility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extensibility";
            this.extensibleStylesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.extensWaveformGraph)).EndInit();
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
			Application.Run(new Extensibility());
		}

        private void OnAfterDrawPlot(object sender, NationalInstruments.UI.AfterDrawXYPlotEventArgs e)
        {
            if(minMaxRadioButton.Checked)
            {                               
                double yMin = Double.MaxValue, yMax = Double.MinValue;
                double xIndexMin = 0, xIndexMax = 0;
				double currentY = 0, currentX = 0; 

                for (int i = 0; i < e.Plot.HistoryCount; ++i)
                {                                       
                    e.Plot.GetDataPoint(i, out currentX, out currentY);
                    
                    if (currentY < yMin)
                    {
                        yMin = currentY;
                        xIndexMin = currentX;
                    }
                    if (currentY > yMax)
                    {
                        yMax = currentY;
                        xIndexMax = currentX;
                    }
                }

                HighlightDataPoint(e, xIndexMin, yMin);
                HighlightDataPoint(e, xIndexMax, yMax);
            }
        }


        private void OnBeforeDrawPlot(object sender, NationalInstruments.UI.BeforeDrawXYPlotEventArgs e)
        {
			if(incDecRadioButton.Checked) 
			{
				// Clip data, iterate through clipped data, map, and draw.
				XYPlot plot = e.Plot;
				double[] clippedXData = null, clippedYData = null;
				plot.ClipDataPoints(out clippedXData, out clippedYData);
				for (int i = 0; i < clippedXData.Length - 1; ++i)
				{
					double x1 = clippedXData[i], x2 = clippedXData[i + 1], y1 = clippedYData[i], y2 = clippedYData[i + 1];

					PointF point1 = plot.MapDataPoint(e.Bounds, x1, y1);
					PointF point2 = plot.MapDataPoint(e.Bounds, x1, y2);
					PointF point3 = plot.MapDataPoint(e.Bounds, x2, y2);

					Pen pen = null;
					if (y2 > y1)
						pen = Pens.LimeGreen;
					else if (y2 == y1)
						pen = Pens.Yellow;
					else
						pen = Pens.Red;

					Graphics g = e.Graphics;
					g.DrawLines(pen, new PointF[] { point1, point2, point3 });					
				}

				e.Cancel = true;
			}
        }

        private void OnBeforeDrawPlotArea(object sender, NationalInstruments.UI.BeforeDrawEventArgs e)
        {
            if(backgroundRadioButton.Checked)
            {
				int segmentWidth = e.Bounds.Width / 4;
				Rectangle amBounds = new Rectangle(e.Bounds.X, e.Bounds.Y, segmentWidth, e.Bounds.Height);
				Rectangle pmBounds = new Rectangle(e.Bounds.X + (segmentWidth * 3), e.Bounds.Y, segmentWidth, e.Bounds.Height);

				e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
				e.Graphics.FillRectangle(Brushes.Navy, amBounds);
				e.Graphics.FillRectangle(Brushes.Navy, pmBounds);
            }
        }

        private void OnDrawOptionChanged(object sender, System.EventArgs e)
        {
            extensWaveformGraph.Invalidate();
        }
        
        private static double[] GenerateData()
        {
            double[] data = new double[49];
            Random rnd = new Random();

            for (int i = 0; i < data.Length; ++i)
                data[i] = (rnd.NextDouble() * Math.Sin(i / 3.15));

            return data;
        }
        

        private static void HighlightDataPoint(AfterDrawXYPlotEventArgs e, double x, double y)
        {
            Graphics g = e.Graphics;			
            PointF mappedPoint = e.Plot.MapDataPoint(e.Bounds, x, y);
            Rectangle bounds = new Rectangle((int)(mappedPoint.X - 8), (int)(mappedPoint.Y - 8), 16, 16);

            using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Red)))
            {
                g.FillEllipse(brush, bounds);
            }

            g.DrawEllipse(Pens.Yellow, bounds);
        }
	}
}
