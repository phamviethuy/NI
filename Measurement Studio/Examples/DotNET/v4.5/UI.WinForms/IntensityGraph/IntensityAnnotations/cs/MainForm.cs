using System;
using System.Windows.Forms;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.IntensityAnnotations
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.IntensityXAxis xAxis1;
        private NationalInstruments.UI.IntensityYAxis yAxis1;
        private System.Windows.Forms.Button generateDataButton;
        private Random random;
        private NationalInstruments.UI.WindowsForms.IntensityGraph myIntensityGraph;
        private NationalInstruments.UI.IntensityPointAnnotation maxIntensityPointAnnotation;
        private NationalInstruments.UI.IntensityPointAnnotation minIntensityPointAnnotation;
        private System.Windows.Forms.GroupBox annotationSettingGroupBox;
        private System.Windows.Forms.RadioButton hideAnnotationRadioButton;
        private System.Windows.Forms.RadioButton hideArrowsRadioButton;
        private System.Windows.Forms.RadioButton hideShapesRadioButton;
        private System.Windows.Forms.RadioButton showAllRadioButton;
        private ColorScale colorScale1;
        private IntensityPlot intensityPlot;
        private const int DataSize = 101;
                
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
            random = new Random();          
            OnGenerateDataButtonClick(null,null);     
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
            this.myIntensityGraph = new NationalInstruments.UI.WindowsForms.IntensityGraph();
            this.maxIntensityPointAnnotation = new NationalInstruments.UI.IntensityPointAnnotation();
            this.xAxis1 = new NationalInstruments.UI.IntensityXAxis();
            this.yAxis1 = new NationalInstruments.UI.IntensityYAxis();
            this.minIntensityPointAnnotation = new NationalInstruments.UI.IntensityPointAnnotation();
            this.colorScale1 = new NationalInstruments.UI.ColorScale();
            this.intensityPlot = new NationalInstruments.UI.IntensityPlot();
            this.generateDataButton = new System.Windows.Forms.Button();
            this.annotationSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllRadioButton = new System.Windows.Forms.RadioButton();
            this.hideArrowsRadioButton = new System.Windows.Forms.RadioButton();
            this.hideAnnotationRadioButton = new System.Windows.Forms.RadioButton();
            this.hideShapesRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.myIntensityGraph)).BeginInit();
            this.annotationSettingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // myIntensityGraph
            // 
            this.myIntensityGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myIntensityGraph.Annotations.AddRange(new NationalInstruments.UI.IntensityAnnotation[] {
            this.maxIntensityPointAnnotation,
            this.minIntensityPointAnnotation});
            this.myIntensityGraph.Caption = "Intensity Graph With Annotations";
            this.myIntensityGraph.ColorScales.AddRange(new NationalInstruments.UI.ColorScale[] {
            this.colorScale1});
            this.myIntensityGraph.Location = new System.Drawing.Point(0, 0);
            this.myIntensityGraph.Name = "myIntensityGraph";
            this.myIntensityGraph.Plots.AddRange(new NationalInstruments.UI.IntensityPlot[] {
            this.intensityPlot});
            this.myIntensityGraph.Size = new System.Drawing.Size(442, 246);
            this.myIntensityGraph.TabIndex = 1;
            this.myIntensityGraph.TabStop = false;
            this.myIntensityGraph.XAxes.AddRange(new NationalInstruments.UI.IntensityXAxis[] {
            this.xAxis1});
            this.myIntensityGraph.YAxes.AddRange(new NationalInstruments.UI.IntensityYAxis[] {
            this.yAxis1});
            // 
            // maxIntensityPointAnnotation
            // 
            this.maxIntensityPointAnnotation.ArrowColor = System.Drawing.Color.Black;
            this.maxIntensityPointAnnotation.ArrowLineWidth = 2F;
            this.maxIntensityPointAnnotation.Caption = "Max Value";
            this.maxIntensityPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopRight, 0F, 0F);
            this.maxIntensityPointAnnotation.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxIntensityPointAnnotation.CaptionForeColor = System.Drawing.Color.Black;
            this.maxIntensityPointAnnotation.ShapeFillColor = System.Drawing.Color.Transparent;
            this.maxIntensityPointAnnotation.ShapeSize = new System.Drawing.Size(16, 16);
            this.maxIntensityPointAnnotation.XAxis = this.xAxis1;
            this.maxIntensityPointAnnotation.XPosition = 2D;
            this.maxIntensityPointAnnotation.YAxis = this.yAxis1;
            this.maxIntensityPointAnnotation.YPosition = 4D;
            // 
            // minIntensityPointAnnotation
            // 
            this.minIntensityPointAnnotation.ArrowColor = System.Drawing.Color.Black;
            this.minIntensityPointAnnotation.ArrowLineWidth = 2F;
            this.minIntensityPointAnnotation.Caption = "Min Value";
            this.minIntensityPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.BottomLeft, 0F, 0F);
            this.minIntensityPointAnnotation.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minIntensityPointAnnotation.CaptionForeColor = System.Drawing.Color.Black;
            this.minIntensityPointAnnotation.ShapeFillColor = System.Drawing.Color.Transparent;
            this.minIntensityPointAnnotation.ShapeSize = new System.Drawing.Size(16, 16);
            this.minIntensityPointAnnotation.XAxis = this.xAxis1;
            this.minIntensityPointAnnotation.YAxis = this.yAxis1;
            // 
            // colorScale1
            // 
            this.colorScale1.ColorMap.AddRange(new NationalInstruments.UI.ColorMapEntry[] {
            new NationalInstruments.UI.ColorMapEntry(3D, System.Drawing.Color.Green),
            new NationalInstruments.UI.ColorMapEntry(7D, System.Drawing.Color.Yellow)});
            this.colorScale1.HighColor = System.Drawing.Color.Red;
            this.colorScale1.LowColor = System.Drawing.Color.Blue;
            // 
            // intensityPlot
            // 
            this.intensityPlot.ColorScale = this.colorScale1;
            this.intensityPlot.XAxis = this.xAxis1;
            this.intensityPlot.YAxis = this.yAxis1;
            // 
            // generateDataButton
            // 
            this.generateDataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generateDataButton.Location = new System.Drawing.Point(330, 258);
            this.generateDataButton.Name = "generateDataButton";
            this.generateDataButton.Size = new System.Drawing.Size(102, 30);
            this.generateDataButton.TabIndex = 1;
            this.generateDataButton.Text = "Generate Data";
            this.generateDataButton.Click += new System.EventHandler(this.OnGenerateDataButtonClick);
            // 
            // annotationSettingGroupBox
            // 
            this.annotationSettingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.annotationSettingGroupBox.Controls.Add(this.showAllRadioButton);
            this.annotationSettingGroupBox.Controls.Add(this.hideArrowsRadioButton);
            this.annotationSettingGroupBox.Controls.Add(this.hideAnnotationRadioButton);
            this.annotationSettingGroupBox.Controls.Add(this.hideShapesRadioButton);
            this.annotationSettingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.annotationSettingGroupBox.Location = new System.Drawing.Point(12, 252);
            this.annotationSettingGroupBox.Name = "annotationSettingGroupBox";
            this.annotationSettingGroupBox.Size = new System.Drawing.Size(312, 104);
            this.annotationSettingGroupBox.TabIndex = 0;
            this.annotationSettingGroupBox.TabStop = false;
            this.annotationSettingGroupBox.Text = "Annotation Settings";
            // 
            // showAllRadioButton
            // 
            this.showAllRadioButton.AutoSize = true;
            this.showAllRadioButton.Checked = true;
            this.showAllRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showAllRadioButton.Location = new System.Drawing.Point(174, 63);
            this.showAllRadioButton.Name = "showAllRadioButton";
            this.showAllRadioButton.Size = new System.Drawing.Size(72, 18);
            this.showAllRadioButton.TabIndex = 0;
            this.showAllRadioButton.TabStop = true;
            this.showAllRadioButton.Text = "Show All";
            this.showAllRadioButton.CheckedChanged += new System.EventHandler(this.OnShowAllRadioButtonCheckedChanged);
            // 
            // hideArrowsRadioButton
            // 
            this.hideArrowsRadioButton.AutoSize = true;
            this.hideArrowsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideArrowsRadioButton.Location = new System.Drawing.Point(17, 29);
            this.hideArrowsRadioButton.Name = "hideArrowsRadioButton";
            this.hideArrowsRadioButton.Size = new System.Drawing.Size(142, 18);
            this.hideArrowsRadioButton.TabIndex = 8;
            this.hideArrowsRadioButton.Text = "Hide Annotation Arrows";
            this.hideArrowsRadioButton.CheckedChanged += new System.EventHandler(this.OnHideArrowsRadioButtonCheckedChanged);
            // 
            // hideAnnotationRadioButton
            // 
            this.hideAnnotationRadioButton.AutoSize = true;
            this.hideAnnotationRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideAnnotationRadioButton.Location = new System.Drawing.Point(174, 29);
            this.hideAnnotationRadioButton.Name = "hideAnnotationRadioButton";
            this.hideAnnotationRadioButton.Size = new System.Drawing.Size(112, 18);
            this.hideAnnotationRadioButton.TabIndex = 7;
            this.hideAnnotationRadioButton.Text = "Hide Annotations";
            this.hideAnnotationRadioButton.CheckedChanged += new System.EventHandler(this.OnHideAnnotationRadioButtonCheckedChanged);
            // 
            // hideShapesRadioButton
            // 
            this.hideShapesRadioButton.AutoSize = true;
            this.hideShapesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideShapesRadioButton.Location = new System.Drawing.Point(17, 63);
            this.hideShapesRadioButton.Name = "hideShapesRadioButton";
            this.hideShapesRadioButton.Size = new System.Drawing.Size(146, 18);
            this.hideShapesRadioButton.TabIndex = 9;
            this.hideShapesRadioButton.Text = "Hide Annotation Shapes";
            this.hideShapesRadioButton.CheckedChanged += new System.EventHandler(this.OnHideShapesRadioButtonCheckedChanged);
            // 
            // MainForm
            // 
            this.AcceptButton = this.generateDataButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(444, 368);
            this.Controls.Add(this.generateDataButton);
            this.Controls.Add(this.annotationSettingGroupBox);
            this.Controls.Add(this.myIntensityGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(450, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intensity Annotations";
            ((System.ComponentModel.ISupportInitialize)(this.myIntensityGraph)).EndInit();
            this.annotationSettingGroupBox.ResumeLayout(false);
            this.annotationSettingGroupBox.PerformLayout();
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

        private double[,] GenerateData()
        {
            // Generate some sample data to plot.

            double[,] data = new double[DataSize, DataSize];

            double value = 5;
            double incrementValue = 0.005;
            double maxValue = colorScale1.Range.Maximum - 1;
            double minValue = colorScale1.Range.Minimum + 1;

            for (int i = 0; i < DataSize; i++)
            {
                for (int j = 0; j < DataSize; j++)
                {
                    value += incrementValue;
                    if (value > maxValue || value < minValue)
                    {
                        incrementValue = -incrementValue;
                    }

                    data[i, j] = value + random.NextDouble();
                }
            }

            return data;
        }

        private void GetMinMaxValues(out int minXIndex, out int minYIndex, out int maxXIndex, out int maxYIndex)
        {
            //Scan the data to find the indices of minimum and maximum values.
            double[,] data = intensityPlot.GetZData();

            minXIndex = 0;
            minYIndex = 0;
            maxXIndex = 0;
            maxYIndex = 0;

            double max = Double.MinValue;
            double min = Double.MaxValue;

            for (int i = 0; i < DataSize; i++)
            {
                for (int j = 0; j < DataSize; j++)
                {
                    if (max < data[i, j])
                    {
                        max = data[i, j];
                        maxXIndex = i;
                        maxYIndex = j;
                    }

                    if (min > data[i, j])
                    {
                        min = data[i, j];
                        minXIndex = i;
                        minYIndex = j;
                    }
                }
            }
        }

        private void OnGenerateDataButtonClick(object sender, System.EventArgs e)
        {
            // Get the data and plot it.
            double[,] data = GenerateData();
            myIntensityGraph.Plot(data);

            int minXIndex;
            int minYIndex;
            int maxXIndex;
            int maxYIndex;

            // Get the minimum and maximum
            GetMinMaxValues(out minXIndex, out minYIndex, out maxXIndex, out maxYIndex);
            double[] xData = intensityPlot.GetXData();
            double[] yData = intensityPlot.GetYData();

            // Set the position of annotation to point to minimum and maximum indices.
            minIntensityPointAnnotation.XPosition = xData[minXIndex];
            minIntensityPointAnnotation.YPosition = yData[minYIndex];
            maxIntensityPointAnnotation.XPosition = xData[maxXIndex];
            maxIntensityPointAnnotation.YPosition = yData[maxYIndex];
        }

        private void OnHideAnnotationRadioButtonCheckedChanged(object sender, System.EventArgs e)
        {
            minIntensityPointAnnotation.Visible = !minIntensityPointAnnotation.Visible;
            maxIntensityPointAnnotation.Visible = !maxIntensityPointAnnotation.Visible;
        }

        private void OnHideShapesRadioButtonCheckedChanged(object sender, System.EventArgs e)
        {
            minIntensityPointAnnotation.ShapeVisible = !minIntensityPointAnnotation.ShapeVisible;
            maxIntensityPointAnnotation.ShapeVisible = !maxIntensityPointAnnotation.ShapeVisible;
        }

        private void OnHideArrowsRadioButtonCheckedChanged(object sender, System.EventArgs e)
        {
            minIntensityPointAnnotation.ArrowVisible = !minIntensityPointAnnotation.ArrowVisible;
            maxIntensityPointAnnotation.ArrowVisible = !maxIntensityPointAnnotation.ArrowVisible;
        }

        private void OnShowAllRadioButtonCheckedChanged(object sender, System.EventArgs e)
        {
            minIntensityPointAnnotation.ArrowVisible = true;
            maxIntensityPointAnnotation.ArrowVisible = true;
            minIntensityPointAnnotation.ShapeVisible = true;
            maxIntensityPointAnnotation.ShapeVisible = true;
            minIntensityPointAnnotation.Visible = true;
            maxIntensityPointAnnotation.Visible = true;
        }
    }
}
