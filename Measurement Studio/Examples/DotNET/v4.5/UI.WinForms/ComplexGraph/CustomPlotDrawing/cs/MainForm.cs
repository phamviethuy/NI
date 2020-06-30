using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.CustomPlotDrawing
{
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.ComplexGraph sampleComplexGraph;
        private System.Windows.Forms.RadioButton preDrawPlotRadioButton;
        private System.Windows.Forms.RadioButton postDrawPlotRadioButton;
        private System.Windows.Forms.RadioButton defaultRadioButton;
        private NationalInstruments.UI.ComplexPlot complexPlot;
        private NationalInstruments.UI.ComplexXAxis complexXAxis;
        private NationalInstruments.UI.ComplexYAxis complexYAxis;
		private System.Windows.Forms.GroupBox plotDrawingStylesGroupBox;
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            sampleComplexGraph.PlotComplex(GenerateData());
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
            this.sampleComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.complexPlot = new NationalInstruments.UI.ComplexPlot();
            this.complexXAxis = new NationalInstruments.UI.ComplexXAxis();
            this.complexYAxis = new NationalInstruments.UI.ComplexYAxis();
            this.preDrawPlotRadioButton = new System.Windows.Forms.RadioButton();
            this.postDrawPlotRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultRadioButton = new System.Windows.Forms.RadioButton();
            this.plotDrawingStylesGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).BeginInit();
            this.plotDrawingStylesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleComplexGraph
            // 
            this.sampleComplexGraph.Caption = "Complex Graph";
            this.sampleComplexGraph.Location = new System.Drawing.Point(16, 8);
            this.sampleComplexGraph.Name = "sampleComplexGraph";
            this.sampleComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
            this.complexPlot});
            this.sampleComplexGraph.Size = new System.Drawing.Size(392, 240);
            this.sampleComplexGraph.TabIndex = 0;
            this.sampleComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
            this.complexXAxis});
            this.sampleComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
            this.complexYAxis});
            this.sampleComplexGraph.AfterDrawPlot += new NationalInstruments.UI.AfterDrawComplexPlotEventHandler(this.OnAfterDrawPlot);
            this.sampleComplexGraph.BeforeDrawPlot += new NationalInstruments.UI.BeforeDrawComplexPlotEventHandler(this.OnBeforeDrawPlot);
            // 
            // complexPlot
            //             
            this.complexPlot.XAxis = this.complexXAxis;
            this.complexPlot.YAxis = this.complexYAxis;
            // 
            // complexYAxis
            // 
            this.complexYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.complexYAxis.Range = new NationalInstruments.UI.Range(-1, 1);
            // 
            // preDrawPlotRadioButton
            // 
            this.preDrawPlotRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.preDrawPlotRadioButton.Location = new System.Drawing.Point(8, 72);
            this.preDrawPlotRadioButton.Name = "preDrawPlotRadioButton";
            this.preDrawPlotRadioButton.Size = new System.Drawing.Size(376, 24);
            this.preDrawPlotRadioButton.TabIndex = 2;
            this.preDrawPlotRadioButton.Text = "Highlight increasing/decreasing values via custom pre plot drawing";
            this.preDrawPlotRadioButton.CheckedChanged += new System.EventHandler(this.OnDrawOptionChanged);
            // 
            // postDrawPlotRadioButton
            // 
            this.postDrawPlotRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.postDrawPlotRadioButton.Location = new System.Drawing.Point(8, 44);
            this.postDrawPlotRadioButton.Name = "postDrawPlotRadioButton";
            this.postDrawPlotRadioButton.Size = new System.Drawing.Size(376, 24);
            this.postDrawPlotRadioButton.TabIndex = 1;
            this.postDrawPlotRadioButton.Text = "Highlight min/max via custom post plot drawing";
            this.postDrawPlotRadioButton.CheckedChanged += new System.EventHandler(this.OnDrawOptionChanged);
            // 
            // defaultRadioButton
            // 
            this.defaultRadioButton.Checked = true;
            this.defaultRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultRadioButton.Location = new System.Drawing.Point(8, 16);
            this.defaultRadioButton.Name = "defaultRadioButton";
            this.defaultRadioButton.Size = new System.Drawing.Size(376, 24);
            this.defaultRadioButton.TabIndex = 0;
            this.defaultRadioButton.TabStop = true;
            this.defaultRadioButton.Text = "Default";
            this.defaultRadioButton.CheckedChanged += new System.EventHandler(this.OnDrawOptionChanged);
            // 
            // plotDrawingStylesGroupBox
            // 
            this.plotDrawingStylesGroupBox.Controls.Add(this.preDrawPlotRadioButton);
            this.plotDrawingStylesGroupBox.Controls.Add(this.postDrawPlotRadioButton);
            this.plotDrawingStylesGroupBox.Controls.Add(this.defaultRadioButton);
            this.plotDrawingStylesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotDrawingStylesGroupBox.Location = new System.Drawing.Point(16, 256);
            this.plotDrawingStylesGroupBox.Name = "plotDrawingStylesGroupBox";
            this.plotDrawingStylesGroupBox.Size = new System.Drawing.Size(392, 104);
            this.plotDrawingStylesGroupBox.TabIndex = 1;
            this.plotDrawingStylesGroupBox.TabStop = false;
            this.plotDrawingStylesGroupBox.Text = "Plot Drawing Styles";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(424, 366);
            this.Controls.Add(this.sampleComplexGraph);
            this.Controls.Add(this.plotDrawingStylesGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Plot Drawing Example";
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).EndInit();
            this.plotDrawingStylesGroupBox.ResumeLayout(false);
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
			Application.DoEvents();
			Application.Run(new MainForm());
		}

        private static ComplexDouble[] GenerateData()
        {
            ComplexDouble[] data = new ComplexDouble[49];
            Random rnd = new Random();

            for (int i = 0; i < data.Length; ++i)
            {
                data[i].Imaginary = (rnd.NextDouble() * Math.Sin(i / 3.15));
                data[i].Real = i - 25;
            }

            return data;
        }

        private void OnDrawOptionChanged(object sender, System.EventArgs e)
        {
            sampleComplexGraph.Invalidate();
        }

        private void OnBeforeDrawPlot(object sender, NationalInstruments.UI.BeforeDrawComplexPlotEventArgs e)
        {
            if (preDrawPlotRadioButton.Checked)
            {
                ComplexPlot plot = e.Plot;
                ComplexDouble[] complexData = plot.GetComplexData();

                int limit = complexData.Length - 1;
                for (int i = 0, j = 1; i < limit; ++i, ++j)
                {
                    double y1 = complexData[i].Imaginary, y2 = complexData[j].Imaginary;
                    PointF point1 = plot.MapDataPoint(e.Bounds, complexData[i]);
                    PointF point2 = plot.MapDataPoint(e.Bounds, complexData[j]);


                    Pen pen = null;
                    if (y2 > y1)
                        pen = Pens.LimeGreen;
                    else if (y2 == y1)
                        pen = Pens.Yellow;
                    else
                        pen = Pens.Red;

                    Graphics g = e.Graphics;
                    g.DrawLine(pen, point1, point2);
                }

                e.Cancel = true;
            }
        }

        private void OnAfterDrawPlot(object sender, NationalInstruments.UI.AfterDrawComplexPlotEventArgs e)
        {
            if (postDrawPlotRadioButton.Checked)
            {
                ComplexPlot plot = e.Plot;
                ComplexDouble[] complexData = plot.GetComplexData();

                double yMin = Double.MaxValue, yMax = Double.MinValue;
                ComplexDouble minComplexDouble = ComplexDouble.Zero;
                ComplexDouble maxComplexDouble = ComplexDouble.Zero;
                for (int i = 0; i < complexData.Length; ++i)
                {
                    double currentY = complexData[i].Imaginary;
                    if (currentY < yMin)
                    {
                        yMin = currentY;
                        minComplexDouble = complexData[i];
                    }

                    if (currentY > yMax)
                    {
                        yMax = currentY;
                        maxComplexDouble = complexData[i];
                    }
                }

                HighlightDataPoint(e, minComplexDouble);
                HighlightDataPoint(e, maxComplexDouble);
            }
        }

        private static void HighlightDataPoint(AfterDrawComplexPlotEventArgs e, ComplexDouble complexDouble)
        {
            Graphics g = e.Graphics;
            PointF mappedPoint = e.Plot.MapDataPoint(e.Bounds, complexDouble);
            Rectangle bounds = new Rectangle((int)(mappedPoint.X - 8), (int)(mappedPoint.Y - 8), 16, 16);

            using (Brush brush = new SolidBrush(Color.FromArgb(128, Color.Red)))
            {
                g.FillEllipse(brush, bounds);
            }

            g.DrawEllipse(Pens.Yellow, bounds);
        }
	}
}
