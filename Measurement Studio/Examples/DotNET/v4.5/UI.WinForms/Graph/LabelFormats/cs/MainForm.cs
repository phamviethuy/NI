using System;
using System.Windows.Forms;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.LabelFormats
{
    public class MainForm : System.Windows.Forms.Form
    {
		private const int dataCount = 100;
        double convertedData = 0;
        Random r = new Random();

        private DataType dataType = DataType.Double;
        private PlottingType plottingType = PlottingType.PlotOnce;

        private string[] NumericFormats = new string[] { "F2", "C0", "0.###'%'" };
        private string[] EngineeringFormats = new string[] { "EEE2", "s3", "S'Hz'" };
        private string[] DateTimeFormats = new string[] { "h:mm:ss tt", "h:mm", "MMM d, yyyy" };
        private string[] ElapsedTimeFormats = new string[] { "E:hh\\:mm\\:ss", "E:mm\\:ss", "E:d\\:hh\\:mm\\:ss" };

        private NationalInstruments.UI.WindowsForms.ScatterGraph sampleScatterGraph;
        private System.Windows.Forms.Button plotDataButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button chartDataButton;
        private NationalInstruments.UI.ScatterPlot scatterPlot;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private GroupBox groupBox1;
        private RadioButton labelFormatElapsedTimeFormat1;
        private RadioButton labelFormatDateTimeFormat1;
        private RadioButton labelFormatEngineeringFormat1;
        private RadioButton labelFormatNumericFormat1;
        private GroupBox groupBox2;
        private RadioButton _editRangeElapsedTimeFormat;
        private RadioButton _editRangeDateTimeFormat;
        private RadioButton _editRangeNumericFormat;
        private RadioButton labelFormatElapsedTimeFormat3;
        private RadioButton labelFormatElapsedTimeFormat2;
        private RadioButton labelFormatDateTimeFormat3;
        private RadioButton labelFormatDateTimeFormat2;
        private RadioButton labelFormatEngineeringFormat3;
        private RadioButton labelFormatEngineeringFormat2;
        private RadioButton labelFormatNumericFormat3;
        private RadioButton labelFormatNumericFormat2;
        private System.ComponentModel.IContainer components;

        public MainForm()
        {
            InitializeComponent();
            //InitializeData();

            ClearAndPlot(DataType.Double, true);
            labelFormatNumericFormat1.Select();
            yAxis.Mode = AxisMode.AutoScaleLoose;
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFormatElapsedTimeFormat3 = new System.Windows.Forms.RadioButton();
            this.labelFormatElapsedTimeFormat2 = new System.Windows.Forms.RadioButton();
            this.labelFormatElapsedTimeFormat1 = new System.Windows.Forms.RadioButton();
            this.labelFormatDateTimeFormat3 = new System.Windows.Forms.RadioButton();
            this.labelFormatDateTimeFormat2 = new System.Windows.Forms.RadioButton();
            this.labelFormatDateTimeFormat1 = new System.Windows.Forms.RadioButton();
            this.labelFormatEngineeringFormat3 = new System.Windows.Forms.RadioButton();
            this.labelFormatEngineeringFormat2 = new System.Windows.Forms.RadioButton();
            this.labelFormatEngineeringFormat1 = new System.Windows.Forms.RadioButton();
            this.labelFormatNumericFormat3 = new System.Windows.Forms.RadioButton();
            this.labelFormatNumericFormat2 = new System.Windows.Forms.RadioButton();
            this.labelFormatNumericFormat1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._editRangeElapsedTimeFormat = new System.Windows.Forms.RadioButton();
            this._editRangeDateTimeFormat = new System.Windows.Forms.RadioButton();
            this._editRangeNumericFormat = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleScatterGraph
            // 
            this.sampleScatterGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleScatterGraph.Caption = "National Instruments 2D Graph";
            this.sampleScatterGraph.InteractionMode = ((NationalInstruments.UI.GraphInteractionModes)((((((((NationalInstruments.UI.GraphInteractionModes.ZoomX | NationalInstruments.UI.GraphInteractionModes.ZoomY)
                        | NationalInstruments.UI.GraphInteractionModes.ZoomAroundPoint)
                        | NationalInstruments.UI.GraphInteractionModes.PanX)
                        | NationalInstruments.UI.GraphInteractionModes.PanY)
                        | NationalInstruments.UI.GraphInteractionModes.DragCursor)
                        | NationalInstruments.UI.GraphInteractionModes.DragAnnotationCaption)
                        | NationalInstruments.UI.GraphInteractionModes.EditRange)));
            this.sampleScatterGraph.Location = new System.Drawing.Point(0, 0);
            this.sampleScatterGraph.Name = "sampleScatterGraph";
            this.sampleScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot});
            this.sampleScatterGraph.Size = new System.Drawing.Size(837, 343);
            this.sampleScatterGraph.TabIndex = 0;
            this.sampleScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // scatterPlot
            // 
            this.scatterPlot.HistoryCapacity = 10000;
            this.scatterPlot.XAxis = this.xAxis;
            this.scatterPlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "F2");
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.ScopeChart;
            // 
            // plotDataButton
            // 
            this.plotDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plotDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotDataButton.Location = new System.Drawing.Point(327, 479);
            this.plotDataButton.Name = "plotDataButton";
            this.plotDataButton.Size = new System.Drawing.Size(88, 37);
            this.plotDataButton.TabIndex = 1;
            this.plotDataButton.Text = "Plot Data";
            this.plotDataButton.Click += new System.EventHandler(this.plotDataButton_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.OnTimer_Tick);
            // 
            // chartDataButton
            // 
            this.chartDataButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chartDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chartDataButton.Location = new System.Drawing.Point(421, 479);
            this.chartDataButton.Name = "chartDataButton";
            this.chartDataButton.Size = new System.Drawing.Size(96, 37);
            this.chartDataButton.TabIndex = 2;
            this.chartDataButton.Text = "Chart Data";
            this.chartDataButton.Click += new System.EventHandler(this.chartDataButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelFormatElapsedTimeFormat3);
            this.groupBox1.Controls.Add(this.labelFormatElapsedTimeFormat2);
            this.groupBox1.Controls.Add(this.labelFormatElapsedTimeFormat1);
            this.groupBox1.Controls.Add(this.labelFormatDateTimeFormat3);
            this.groupBox1.Controls.Add(this.labelFormatDateTimeFormat2);
            this.groupBox1.Controls.Add(this.labelFormatDateTimeFormat1);
            this.groupBox1.Controls.Add(this.labelFormatEngineeringFormat3);
            this.groupBox1.Controls.Add(this.labelFormatEngineeringFormat2);
            this.groupBox1.Controls.Add(this.labelFormatEngineeringFormat1);
            this.groupBox1.Controls.Add(this.labelFormatNumericFormat3);
            this.groupBox1.Controls.Add(this.labelFormatNumericFormat2);
            this.groupBox1.Controls.Add(this.labelFormatNumericFormat1);
            this.groupBox1.Location = new System.Drawing.Point(6, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 124);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Axis Label Formats Samples";
            // 
            // labelFormatElapsedTimeFormat3
            // 
            this.labelFormatElapsedTimeFormat3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatElapsedTimeFormat3.AutoSize = true;
            this.labelFormatElapsedTimeFormat3.Location = new System.Drawing.Point(408, 93);
            this.labelFormatElapsedTimeFormat3.Name = "labelFormatElapsedTimeFormat3";
            this.labelFormatElapsedTimeFormat3.Size = new System.Drawing.Size(185, 17);
            this.labelFormatElapsedTimeFormat3.TabIndex = 0;
            this.labelFormatElapsedTimeFormat3.TabStop = true;
            this.labelFormatElapsedTimeFormat3.Text = "ElapsedTime, E:d\\\\:hh\\\\:mm\\\\:ss";
            this.labelFormatElapsedTimeFormat3.UseVisualStyleBackColor = true;
            this.labelFormatElapsedTimeFormat3.CheckedChanged += new System.EventHandler(this.OnLabelFormatElapsedTimeFormat3_CheckedChanged);
            // 
            // labelFormatElapsedTimeFormat2
            // 
            this.labelFormatElapsedTimeFormat2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatElapsedTimeFormat2.AutoSize = true;
            this.labelFormatElapsedTimeFormat2.Location = new System.Drawing.Point(216, 93);
            this.labelFormatElapsedTimeFormat2.Name = "labelFormatElapsedTimeFormat2";
            this.labelFormatElapsedTimeFormat2.Size = new System.Drawing.Size(141, 17);
            this.labelFormatElapsedTimeFormat2.TabIndex = 0;
            this.labelFormatElapsedTimeFormat2.TabStop = true;
            this.labelFormatElapsedTimeFormat2.Text = "ElapsedTime, E:mm\\\\:ss";
            this.labelFormatElapsedTimeFormat2.UseVisualStyleBackColor = true;
            this.labelFormatElapsedTimeFormat2.CheckedChanged += new System.EventHandler(this.OnLabelFormatElapsedTimeFormat2_CheckedChanged);
            // 
            // labelFormatElapsedTimeFormat1
            // 
            this.labelFormatElapsedTimeFormat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatElapsedTimeFormat1.AutoSize = true;
            this.labelFormatElapsedTimeFormat1.Location = new System.Drawing.Point(11, 93);
            this.labelFormatElapsedTimeFormat1.Name = "labelFormatElapsedTimeFormat1";
            this.labelFormatElapsedTimeFormat1.Size = new System.Drawing.Size(166, 17);
            this.labelFormatElapsedTimeFormat1.TabIndex = 0;
            this.labelFormatElapsedTimeFormat1.TabStop = true;
            this.labelFormatElapsedTimeFormat1.Text = "ElapsedTime, E:hh\\\\:mm\\\\:ss";
            this.labelFormatElapsedTimeFormat1.UseVisualStyleBackColor = true;
            this.labelFormatElapsedTimeFormat1.CheckedChanged += new System.EventHandler(this.OnLabelFormatElapsedTimeFormat1_CheckedChanged);
            // 
            // labelFormatDateTimeFormat3
            // 
            this.labelFormatDateTimeFormat3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatDateTimeFormat3.AutoSize = true;
            this.labelFormatDateTimeFormat3.Location = new System.Drawing.Point(408, 70);
            this.labelFormatDateTimeFormat3.Name = "labelFormatDateTimeFormat3";
            this.labelFormatDateTimeFormat3.Size = new System.Drawing.Size(139, 17);
            this.labelFormatDateTimeFormat3.TabIndex = 0;
            this.labelFormatDateTimeFormat3.TabStop = true;
            this.labelFormatDateTimeFormat3.Text = "DateTime, MMM d, yyyy";
            this.labelFormatDateTimeFormat3.UseVisualStyleBackColor = true;
            this.labelFormatDateTimeFormat3.CheckedChanged += new System.EventHandler(this.OnLabelFormatDateTimeFormat3_CheckedChanged);
            // 
            // labelFormatDateTimeFormat2
            // 
            this.labelFormatDateTimeFormat2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatDateTimeFormat2.AutoSize = true;
            this.labelFormatDateTimeFormat2.Location = new System.Drawing.Point(216, 70);
            this.labelFormatDateTimeFormat2.Name = "labelFormatDateTimeFormat2";
            this.labelFormatDateTimeFormat2.Size = new System.Drawing.Size(102, 17);
            this.labelFormatDateTimeFormat2.TabIndex = 0;
            this.labelFormatDateTimeFormat2.TabStop = true;
            this.labelFormatDateTimeFormat2.Text = "DateTime, h:mm";
            this.labelFormatDateTimeFormat2.UseVisualStyleBackColor = true;
            this.labelFormatDateTimeFormat2.CheckedChanged += new System.EventHandler(this.OnLabelFormatDateTimeFormat2_CheckedChanged);
            // 
            // labelFormatDateTimeFormat1
            // 
            this.labelFormatDateTimeFormat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatDateTimeFormat1.AutoSize = true;
            this.labelFormatDateTimeFormat1.Location = new System.Drawing.Point(11, 70);
            this.labelFormatDateTimeFormat1.Name = "labelFormatDateTimeFormat1";
            this.labelFormatDateTimeFormat1.Size = new System.Drawing.Size(124, 17);
            this.labelFormatDateTimeFormat1.TabIndex = 0;
            this.labelFormatDateTimeFormat1.TabStop = true;
            this.labelFormatDateTimeFormat1.Text = "DateTime, h:mm:ss tt";
            this.labelFormatDateTimeFormat1.UseVisualStyleBackColor = true;
            this.labelFormatDateTimeFormat1.CheckedChanged += new System.EventHandler(this.OnLabelFormatDateTimeFormat1_CheckedChanged);
            // 
            // labelFormatEngineeringFormat3
            // 
            this.labelFormatEngineeringFormat3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatEngineeringFormat3.AutoSize = true;
            this.labelFormatEngineeringFormat3.Location = new System.Drawing.Point(408, 47);
            this.labelFormatEngineeringFormat3.Name = "labelFormatEngineeringFormat3";
            this.labelFormatEngineeringFormat3.Size = new System.Drawing.Size(111, 17);
            this.labelFormatEngineeringFormat3.TabIndex = 0;
            this.labelFormatEngineeringFormat3.TabStop = true;
            this.labelFormatEngineeringFormat3.Text = "Engineering, S\'Hz\'";
            this.labelFormatEngineeringFormat3.UseVisualStyleBackColor = true;
            this.labelFormatEngineeringFormat3.CheckedChanged += new System.EventHandler(this.OnLabelFormatEngineeringFormat3_CheckedChanged);
            // 
            // labelFormatEngineeringFormat2
            // 
            this.labelFormatEngineeringFormat2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatEngineeringFormat2.AutoSize = true;
            this.labelFormatEngineeringFormat2.Location = new System.Drawing.Point(216, 47);
            this.labelFormatEngineeringFormat2.Name = "labelFormatEngineeringFormat2";
            this.labelFormatEngineeringFormat2.Size = new System.Drawing.Size(98, 17);
            this.labelFormatEngineeringFormat2.TabIndex = 0;
            this.labelFormatEngineeringFormat2.TabStop = true;
            this.labelFormatEngineeringFormat2.Text = "Engineering, s3";
            this.labelFormatEngineeringFormat2.UseVisualStyleBackColor = true;
            this.labelFormatEngineeringFormat2.CheckedChanged += new System.EventHandler(this.OnLabelFormatEngineeringFormat2_CheckedChanged);
            // 
            // labelFormatEngineeringFormat1
            // 
            this.labelFormatEngineeringFormat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatEngineeringFormat1.AutoSize = true;
            this.labelFormatEngineeringFormat1.Location = new System.Drawing.Point(11, 47);
            this.labelFormatEngineeringFormat1.Name = "labelFormatEngineeringFormat1";
            this.labelFormatEngineeringFormat1.Size = new System.Drawing.Size(114, 17);
            this.labelFormatEngineeringFormat1.TabIndex = 0;
            this.labelFormatEngineeringFormat1.TabStop = true;
            this.labelFormatEngineeringFormat1.Text = "Engineering, EEE2";
            this.labelFormatEngineeringFormat1.UseVisualStyleBackColor = true;
            this.labelFormatEngineeringFormat1.CheckedChanged += new System.EventHandler(this.OnLabelFormatEngineeringFormat1_CheckedChanged);
            // 
            // labelFormatNumericFormat3
            // 
            this.labelFormatNumericFormat3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatNumericFormat3.AutoSize = true;
            this.labelFormatNumericFormat3.Location = new System.Drawing.Point(408, 24);
            this.labelFormatNumericFormat3.Name = "labelFormatNumericFormat3";
            this.labelFormatNumericFormat3.Size = new System.Drawing.Size(112, 17);
            this.labelFormatNumericFormat3.TabIndex = 0;
            this.labelFormatNumericFormat3.TabStop = true;
            this.labelFormatNumericFormat3.Text = "Numeric, 0.###\'%\'";
            this.labelFormatNumericFormat3.UseVisualStyleBackColor = true;
            this.labelFormatNumericFormat3.CheckedChanged += new System.EventHandler(this.OnLabelFormatNumericFormat3_CheckedChanged);
            // 
            // labelFormatNumericFormat2
            // 
            this.labelFormatNumericFormat2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatNumericFormat2.AutoSize = true;
            this.labelFormatNumericFormat2.Location = new System.Drawing.Point(216, 24);
            this.labelFormatNumericFormat2.Name = "labelFormatNumericFormat2";
            this.labelFormatNumericFormat2.Size = new System.Drawing.Size(83, 17);
            this.labelFormatNumericFormat2.TabIndex = 0;
            this.labelFormatNumericFormat2.TabStop = true;
            this.labelFormatNumericFormat2.Text = "Numeric, C0";
            this.labelFormatNumericFormat2.UseVisualStyleBackColor = true;
            this.labelFormatNumericFormat2.CheckedChanged += new System.EventHandler(this.OnLabelFormatNumericFormat2_CheckedChanged);
            // 
            // labelFormatNumericFormat1
            // 
            this.labelFormatNumericFormat1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFormatNumericFormat1.AutoSize = true;
            this.labelFormatNumericFormat1.Location = new System.Drawing.Point(11, 24);
            this.labelFormatNumericFormat1.Name = "labelFormatNumericFormat1";
            this.labelFormatNumericFormat1.Size = new System.Drawing.Size(82, 17);
            this.labelFormatNumericFormat1.TabIndex = 0;
            this.labelFormatNumericFormat1.TabStop = true;
            this.labelFormatNumericFormat1.Text = "Numeric, F2";
            this.labelFormatNumericFormat1.UseVisualStyleBackColor = true;
            this.labelFormatNumericFormat1.CheckedChanged += new System.EventHandler(this.OnLabelFormatNumericFormat1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this._editRangeElapsedTimeFormat);
            this.groupBox2.Controls.Add(this._editRangeDateTimeFormat);
            this.groupBox2.Controls.Add(this._editRangeNumericFormat);
            this.groupBox2.Location = new System.Drawing.Point(622, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Active Edit Range Format";
            // 
            // _editRangeElapsedTimeFormat
            // 
            this._editRangeElapsedTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._editRangeElapsedTimeFormat.AutoSize = true;
            this._editRangeElapsedTimeFormat.Location = new System.Drawing.Point(40, 82);
            this._editRangeElapsedTimeFormat.Name = "_editRangeElapsedTimeFormat";
            this._editRangeElapsedTimeFormat.Size = new System.Drawing.Size(109, 17);
            this._editRangeElapsedTimeFormat.TabIndex = 0;
            this._editRangeElapsedTimeFormat.TabStop = true;
            this._editRangeElapsedTimeFormat.Text = "Elapsed time: \"G\"";
            this._editRangeElapsedTimeFormat.UseVisualStyleBackColor = true;
            this._editRangeElapsedTimeFormat.CheckedChanged += new System.EventHandler(this._editRangeElapsedTimeFormat_CheckedChanged);
            // 
            // _editRangeDateTimeFormat
            // 
            this._editRangeDateTimeFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._editRangeDateTimeFormat.AutoSize = true;
            this._editRangeDateTimeFormat.Location = new System.Drawing.Point(40, 59);
            this._editRangeDateTimeFormat.Name = "_editRangeDateTimeFormat";
            this._editRangeDateTimeFormat.Size = new System.Drawing.Size(134, 17);
            this._editRangeDateTimeFormat.TabIndex = 0;
            this._editRangeDateTimeFormat.TabStop = true;
            this._editRangeDateTimeFormat.Text = "Date time: \"ShortTime\"";
            this._editRangeDateTimeFormat.UseVisualStyleBackColor = true;
            this._editRangeDateTimeFormat.CheckedChanged += new System.EventHandler(this._editRangeDateTimeFormat_CheckedChanged);
            // 
            // _editRangeNumericFormat
            // 
            this._editRangeNumericFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._editRangeNumericFormat.AutoSize = true;
            this._editRangeNumericFormat.Location = new System.Drawing.Point(40, 36);
            this._editRangeNumericFormat.Name = "_editRangeNumericFormat";
            this._editRangeNumericFormat.Size = new System.Drawing.Size(140, 17);
            this._editRangeNumericFormat.TabIndex = 0;
            this._editRangeNumericFormat.TabStop = true;
            this._editRangeNumericFormat.Text = "Numeric:  \"Generic: G5\"";
            this._editRangeNumericFormat.UseVisualStyleBackColor = true;
            this._editRangeNumericFormat.CheckedChanged += new System.EventHandler(this._editRangeNumericFormat_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(837, 528);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartDataButton);
            this.Controls.Add(this.plotDataButton);
            this.Controls.Add(this.sampleScatterGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Label Formats Example";
            ((System.ComponentModel.ISupportInitialize)(this.sampleScatterGraph)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
            plottingType = PlottingType.PlotOnce;
            PlotOnce(true);
        }

        private void PlotOnce(bool plotNewData)
        {
            if (plotNewData)
            {
                xAxis.Mode = AxisMode.AutoScaleLoose;
                sampleScatterGraph.ClearData();

                if (dataType == DataType.Double)
                {
                    for (int i = 0; i < dataCount; i++)
                    {
                        sampleScatterGraph.PlotXYAppend(i, r.Next(1, 10));
                    }
                }
                else
                {
                    for (int i = 0; i < dataCount; i++)
                    {
                        double convertedData = (double)DataConverter.Convert(TimeSpan.FromHours(i * 12), typeof(double));
                        sampleScatterGraph.PlotXYAppend(convertedData, r.Next(1, 25));
                    }
                }
            }
        }
        private void OnTimer_Tick(object sender, System.EventArgs e)
        {

            if (convertedData > 100000000L)
            {
                convertedData = 0;
                scatterPlot.ClearData();
            }

            if (dataType == DataType.Double)
                convertedData += r.NextDouble() * 10;
            else
                convertedData += (double)DataConverter.Convert(TimeSpan.FromHours(10.2), typeof(double));

            sampleScatterGraph.PlotXYAppend(convertedData, r.NextDouble()*10);
        }

		//Starts or stops the charting of data that has timing information
        private void chartDataButton_Click(object sender, System.EventArgs e)
        {
            plottingType = PlottingType.Chart;
            Chart();
        }

        private void Chart()
        {
            scatterPlot.ClearData();
            scatterPlot.PlotXY(0, 0);
            if (dataType == DataType.Double)
                xAxis.Range = new Range(0, 100);
            else
                xAxis.Range = new Range(0, TimeSpan.FromDays(10).TotalSeconds);

            xAxis.Mode = AxisMode.StripChart;

            if (timer.Enabled)
            {
                timer.Enabled = false;
                plotDataButton.Enabled = true;
                chartDataButton.Text = "Chart Data";
            }
            else
            {
                chartDataButton.Text = "Stop Charting";
                plotDataButton.Enabled = false;
                timer.Enabled = true;
            }
        }

        private void ClearAndPlot(DataType type, bool plotNewData)
        {
            dataType = type;
            
            if (plottingType == PlottingType.PlotOnce)
            {
                PlotOnce(plotNewData);
            }
            else
            {
                convertedData = 0;
                Chart();
            }
        }

        private void OnLabelFormatNumericFormat1_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.Double, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Numeric, NumericFormats[0]);
            ValidateEditRange();
        }

        private void OnLabelFormatNumericFormat2_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.Double, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Numeric, NumericFormats[1]);
            ValidateEditRange();
        }

        private void OnLabelFormatNumericFormat3_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.Double, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Numeric, NumericFormats[2]);
            ValidateEditRange();
        }

        private void OnLabelFormatEngineeringFormat1_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.Double, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Engineering, EngineeringFormats[0]);
            ValidateEditRange();
        }

        private void OnLabelFormatEngineeringFormat2_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.Double, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Engineering, EngineeringFormats[1]);
            ValidateEditRange();
        }

        private void OnLabelFormatEngineeringFormat3_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.Double, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Engineering, EngineeringFormats[2]);
            ValidateEditRange();
        }

        private void OnLabelFormatDateTimeFormat1_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.DateTime, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, DateTimeFormats[0]);
            ValidateEditRange();
        }

        private void OnLabelFormatDateTimeFormat2_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.DateTime, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, DateTimeFormats[1]);
            ValidateEditRange();
        }

        private void OnLabelFormatDateTimeFormat3_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.DateTime, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, DateTimeFormats[2]);
            ValidateEditRange();
        }

        private void OnLabelFormatElapsedTimeFormat1_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.DateTime, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.ElapsedTime, ElapsedTimeFormats[0]);
            ValidateEditRange();
        }

        private void OnLabelFormatElapsedTimeFormat2_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.DateTime, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.ElapsedTime, ElapsedTimeFormats[1]);
            ValidateEditRange();
        }

        private void OnLabelFormatElapsedTimeFormat3_CheckedChanged(object sender, EventArgs e)
        {
            ClearAndPlot(DataType.DateTime, false);
            xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.ElapsedTime, ElapsedTimeFormats[2]);
            ValidateEditRange();
        }

        private void ValidateEditRange()
        {
            if (xAxis.MajorDivisions.LabelFormat.Mode == FormatStringMode.Numeric || xAxis.MajorDivisions.LabelFormat.Mode == FormatStringMode.Engineering)
            {
                _editRangeNumericFormat.Checked = true;
            }
            else if (xAxis.MajorDivisions.LabelFormat.Mode == FormatStringMode.DateTime)
            {
                _editRangeDateTimeFormat.Checked = true;
            }
            if (xAxis.MajorDivisions.LabelFormat.Mode == FormatStringMode.ElapsedTime)
            {
                _editRangeElapsedTimeFormat.Checked = true;
            }
        }
        
        private void _editRangeNumericFormat_CheckedChanged(object sender, EventArgs e)
        {
            ValidateEditRange();
        }

        private void _editRangeDateTimeFormat_CheckedChanged(object sender, EventArgs e)
        {
            ValidateEditRange();
        }

        private void _editRangeElapsedTimeFormat_CheckedChanged(object sender, EventArgs e)
        {
            ValidateEditRange();
        }
    }

    public enum DataType
    {
        Double,
        DateTime
    }

    public enum PlottingType
    {
        PlotOnce,
        Chart
    }
}
