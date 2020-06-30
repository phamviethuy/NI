using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NationalInstruments.Examples.PlotDateTime
{
    public class MainForm : System.Windows.Forms.Form
    {
		private const int dataCount = 100;
        private DateTime[] data = new DateTime[dataCount];
        private int currentIndex;
		private DateTime startDate = DateTime.Now;

        private NationalInstruments.UI.WindowsForms.ScatterGraph sampleScatterGraph;
        private System.Windows.Forms.Button plotDataButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button chartDataButton;
        private NationalInstruments.UI.ScatterPlot scatterPlot;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private System.ComponentModel.IContainer components;

        public MainForm()
        {
            InitializeComponent();
            InitializeData();   
        }

        public void InitializeData()
        {
            Random r = new Random();
			data[0] = startDate;
            for(int i = 1; i < data.Length; i++)
            {
				data[i] = data[i - 1].AddHours(r.Next(1, 24));
            }            
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.plotDataButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.chartDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleScatterGraph
            // 
            this.sampleScatterGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleScatterGraph.Caption = "National Instruments 2D Graph";
            this.sampleScatterGraph.Location = new System.Drawing.Point(0, 0);
            this.sampleScatterGraph.Name = "sampleScatterGraph";
            this.sampleScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot});
            this.sampleScatterGraph.Size = new System.Drawing.Size(362, 200);
            this.sampleScatterGraph.TabIndex = 0;
            this.sampleScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // scatterPlot
            // 
            this.scatterPlot.XAxis = this.xAxis;
            this.scatterPlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.ScopeChart;
            // 
            // plotDataButton
            // 
            this.plotDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plotDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotDataButton.Location = new System.Drawing.Point(48, 216);
            this.plotDataButton.Name = "plotDataButton";
            this.plotDataButton.Size = new System.Drawing.Size(88, 23);
            this.plotDataButton.TabIndex = 1;
            this.plotDataButton.Text = "Plot Data";
            this.plotDataButton.Click += new System.EventHandler(this.plotDataButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // chartDataButton
            // 
            this.chartDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chartDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chartDataButton.Location = new System.Drawing.Point(216, 216);
            this.chartDataButton.Name = "chartDataButton";
            this.chartDataButton.Size = new System.Drawing.Size(96, 23);
            this.chartDataButton.TabIndex = 2;
            this.chartDataButton.Text = "Chart Data";
            this.chartDataButton.Click += new System.EventHandler(this.chartDataButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(362, 248);
            this.Controls.Add(this.chartDataButton);
            this.Controls.Add(this.plotDataButton);
            this.Controls.Add(this.sampleScatterGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Plot DateTime Example";
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).EndInit();
            this.ResumeLayout(false);

		}
        #endregion

        [STAThread]
        static void Main() 
        {
			Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }

		//Plots the data that has timing information
        private void plotDataButton_Click(object sender, System.EventArgs e)
        {
			this.xAxis.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "MMM d, yyyy");
            xAxis.Mode = AxisMode.Fixed;
            xAxis.Range = new Range(startDate, (DateTime)data.GetValue(data.Length - 1));
            Random r = new Random();            
            sampleScatterGraph.ClearData();
            foreach(DateTime dateTime in data)
            {
                double convertedData = (double)DataConverter.Convert(dateTime, typeof(double));
                sampleScatterGraph.PlotXYAppend(convertedData, r.NextDouble());
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            if(currentIndex == (data.Length))
            {
                currentIndex = 0;
                chartDataButton.Text = "Chart Data";
                plotDataButton.Enabled = true;
                timer.Enabled = false;
            }
            else
            {
                Random r = new Random();
                double convertedData = (double)DataConverter.Convert(data[currentIndex], typeof(double));
                sampleScatterGraph.PlotXYAppend(convertedData, r.NextDouble());
				currentIndex++;
            }
        }

		//Starts or stops the charting of data that has timing information
        private void chartDataButton_Click(object sender, System.EventArgs e)
        {
			this.xAxis.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "MMM d, yyyy");
			currentIndex = 0;
            if(timer.Enabled)
            {
                timer.Enabled = false;
                plotDataButton.Enabled = true;                
                chartDataButton.Text = "Chart Data";                
            }
            else
            {
                sampleScatterGraph.ClearData();
                xAxis.Mode = AxisMode.StripChart;
				xAxis.Range = new Range(startDate, TimeSpan.FromDays(10));
                chartDataButton.Text = "Stop Charting";
                plotDataButton.Enabled = false;
                timer.Enabled = true;               
            }
        }
    }
}
