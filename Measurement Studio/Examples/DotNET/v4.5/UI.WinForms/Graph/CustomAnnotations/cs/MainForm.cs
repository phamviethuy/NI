using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomAnnotations
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private System.Windows.Forms.Button genDataButton;
        private Random random;
        private NationalInstruments.UI.WindowsForms.WaveformGraph dataWaveformGraph;
        private NationalInstruments.UI.XYPointAnnotation maxXYPointAnnotation;
        private NationalInstruments.UI.XYPointAnnotation minXYPointAnnotation;          
        private System.Windows.Forms.GroupBox annotationShapeGroupBox;
        private System.Windows.Forms.GroupBox annotationArrowGroupBox;
        private System.Windows.Forms.RadioButton defaultShapeRadioButton;
        private System.Windows.Forms.RadioButton customShapeRadioButton;
        private System.Windows.Forms.RadioButton defaultArrowRadioButton;
        private System.Windows.Forms.RadioButton customArrowRadioButton;
        private ArrowStyle customArrowTailStyle;    
        private ShapeStyle customShapeStyle;
        private ArrowStyle defaultArrowTailStyle;
        private ShapeStyle defaultShapeStyle;
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
            customArrowTailStyle = new FeatherTailStyle();
            customShapeStyle  = new StarShapeStyle();
            defaultShapeStyle = maxXYPointAnnotation.ShapeStyle;
            defaultArrowTailStyle = maxXYPointAnnotation.ArrowTailStyle;

            genDataButton_Click(null,null);     
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.dataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.maxXYPointAnnotation = new NationalInstruments.UI.XYPointAnnotation();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.minXYPointAnnotation = new NationalInstruments.UI.XYPointAnnotation();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.genDataButton = new System.Windows.Forms.Button();
            this.annotationShapeGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultShapeRadioButton = new System.Windows.Forms.RadioButton();
            this.customShapeRadioButton = new System.Windows.Forms.RadioButton();
            this.annotationArrowGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultArrowRadioButton = new System.Windows.Forms.RadioButton();
            this.customArrowRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).BeginInit();
            this.annotationShapeGroupBox.SuspendLayout();
            this.annotationArrowGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataWaveformGraph
            // 
            this.dataWaveformGraph.Annotations.AddRange(new NationalInstruments.UI.XYAnnotation[] {
                                                                                                      this.maxXYPointAnnotation,
                                                                                                      this.minXYPointAnnotation});
            this.dataWaveformGraph.Caption = "Data Waveform Graph";
            this.dataWaveformGraph.Location = new System.Drawing.Point(0, 0);
            this.dataWaveformGraph.Name = "dataWaveformGraph";
            this.dataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                this.waveformPlot1});
            this.dataWaveformGraph.Size = new System.Drawing.Size(472, 240);
            this.dataWaveformGraph.TabIndex = 1;
            this.dataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                         this.xAxis1});
            this.dataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                         this.yAxis1});
            // 
            // maxXYPointAnnotation
            // 
            this.maxXYPointAnnotation.ArrowColor = System.Drawing.Color.Gold;
            this.maxXYPointAnnotation.ArrowLineWidth = 2F;
            this.maxXYPointAnnotation.ArrowTailSize = new System.Drawing.Size(20, 15);
            this.maxXYPointAnnotation.Caption = "Max Value";
            this.maxXYPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopRight, 0F, 0F);
            this.maxXYPointAnnotation.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.maxXYPointAnnotation.XAxis = this.xAxis1;
            this.maxXYPointAnnotation.XPosition = 2;
            this.maxXYPointAnnotation.YAxis = this.yAxis1;
            this.maxXYPointAnnotation.YPosition = 4;
            // 
            // yAxis1
            // 
            this.yAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis1.Range = new NationalInstruments.UI.Range(-2, 7);
            // 
            // minXYPointAnnotation
            // 
            this.minXYPointAnnotation.ArrowColor = System.Drawing.Color.DeepSkyBlue;
            this.minXYPointAnnotation.ArrowTailSize = new System.Drawing.Size(20, 15);
            this.minXYPointAnnotation.Caption = "Min Value";
            this.minXYPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.BottomLeft, 0F, 0F);
            this.minXYPointAnnotation.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.minXYPointAnnotation.XAxis = this.xAxis1;
            this.minXYPointAnnotation.YAxis = this.yAxis1;
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // genDataButton
            // 
            this.genDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genDataButton.Location = new System.Drawing.Point(320, 256);
            this.genDataButton.Name = "genDataButton";
            this.genDataButton.Size = new System.Drawing.Size(144, 72);
            this.genDataButton.TabIndex = 0;
            this.genDataButton.Text = "Generate Data";
            this.genDataButton.Click += new System.EventHandler(this.genDataButton_Click);
            // 
            // annotationShapeGroupBox
            // 
            this.annotationShapeGroupBox.Controls.Add(this.defaultShapeRadioButton);
            this.annotationShapeGroupBox.Controls.Add(this.customShapeRadioButton);
            this.annotationShapeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.annotationShapeGroupBox.Location = new System.Drawing.Point(8, 248);
            this.annotationShapeGroupBox.Name = "annotationShapeGroupBox";
            this.annotationShapeGroupBox.Size = new System.Drawing.Size(152, 80);
            this.annotationShapeGroupBox.TabIndex = 2;
            this.annotationShapeGroupBox.TabStop = false;
            this.annotationShapeGroupBox.Text = "Annotation Shape Settings";
            // 
            // defaultShapeRadioButton
            // 
            this.defaultShapeRadioButton.Checked = true;
            this.defaultShapeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultShapeRadioButton.Location = new System.Drawing.Point(16, 24);
            this.defaultShapeRadioButton.Name = "defaultShapeRadioButton";
            this.defaultShapeRadioButton.Size = new System.Drawing.Size(72, 24);
            this.defaultShapeRadioButton.TabIndex = 1;
            this.defaultShapeRadioButton.TabStop = true;
            this.defaultShapeRadioButton.Text = "Default";
            this.defaultShapeRadioButton.CheckedChanged += new System.EventHandler(this.defaultShapeRadioButton_CheckedChanged);
            // 
            // customShapeRadioButton
            // 
            this.customShapeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customShapeRadioButton.Location = new System.Drawing.Point(16, 48);
            this.customShapeRadioButton.Name = "customShapeRadioButton";
            this.customShapeRadioButton.Size = new System.Drawing.Size(72, 24);
            this.customShapeRadioButton.TabIndex = 0;
            this.customShapeRadioButton.Text = "Custom";
            this.customShapeRadioButton.CheckedChanged += new System.EventHandler(this.customShapeRadioButton_CheckedChanged);
            // 
            // annotationArrowGroupBox
            // 
            this.annotationArrowGroupBox.Controls.Add(this.defaultArrowRadioButton);
            this.annotationArrowGroupBox.Controls.Add(this.customArrowRadioButton);
            this.annotationArrowGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.annotationArrowGroupBox.Location = new System.Drawing.Point(168, 248);
            this.annotationArrowGroupBox.Name = "annotationArrowGroupBox";
            this.annotationArrowGroupBox.Size = new System.Drawing.Size(144, 80);
            this.annotationArrowGroupBox.TabIndex = 3;
            this.annotationArrowGroupBox.TabStop = false;
            this.annotationArrowGroupBox.Text = "Annotation Arrow Settings";
            // 
            // defaultArrowRadioButton
            // 
            this.defaultArrowRadioButton.Checked = true;
            this.defaultArrowRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultArrowRadioButton.Location = new System.Drawing.Point(16, 24);
            this.defaultArrowRadioButton.Name = "defaultArrowRadioButton";
            this.defaultArrowRadioButton.Size = new System.Drawing.Size(72, 24);
            this.defaultArrowRadioButton.TabIndex = 1;
            this.defaultArrowRadioButton.TabStop = true;
            this.defaultArrowRadioButton.Text = "Default";
            this.defaultArrowRadioButton.CheckedChanged += new System.EventHandler(this.defaultArrowRadioButton_CheckedChanged);
            // 
            // customArrowRadioButton
            // 
            this.customArrowRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customArrowRadioButton.Location = new System.Drawing.Point(16, 48);
            this.customArrowRadioButton.Name = "customArrowRadioButton";
            this.customArrowRadioButton.Size = new System.Drawing.Size(72, 24);
            this.customArrowRadioButton.TabIndex = 0;
            this.customArrowRadioButton.Text = "Custom";
            this.customArrowRadioButton.CheckedChanged += new System.EventHandler(this.customArrowRadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(474, 336);
            this.Controls.Add(this.annotationArrowGroupBox);
            this.Controls.Add(this.annotationShapeGroupBox);
            this.Controls.Add(this.genDataButton);
            this.Controls.Add(this.dataWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 368);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Annotations";
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).EndInit();
            this.annotationShapeGroupBox.ResumeLayout(false);
            this.annotationArrowGroupBox.ResumeLayout(false);
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

        private void genDataButton_Click(object sender, System.EventArgs e)
        {
            double[] data = new double[50];
            double max,min;
            int maxIndex = 0;
            int minIndex =0;

            for(int i = 0;i<50;i++)
                data[i] = 5 * random.NextDouble();
            
            max = Double.MinValue;
            min = Double.MaxValue;

            for(int i=0;i<50;i++)
            {
                if(max < data[i])
                {
                    max = data[i];
                    maxIndex = i;
                }
                if(min > data[i])
                {
                    min = data[i];
                    minIndex = i;
                }
            }
            
            dataWaveformGraph.PlotY(data);
            maxXYPointAnnotation.SetPosition(maxIndex,max);
            minXYPointAnnotation.SetPosition(minIndex,min);
        }

        private void defaultShapeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXYPointAnnotation.ShapeStyle = defaultShapeStyle;
            maxXYPointAnnotation.ShapeStyle = defaultShapeStyle;        
        }

        private void customShapeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXYPointAnnotation.ShapeStyle = customShapeStyle;
            maxXYPointAnnotation.ShapeStyle = customShapeStyle; 
        }

        private void defaultArrowRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXYPointAnnotation.ArrowTailStyle = defaultArrowTailStyle;
            maxXYPointAnnotation.ArrowTailStyle = defaultArrowTailStyle;
        
        }

        private void customArrowRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXYPointAnnotation.ArrowTailStyle = customArrowTailStyle;
            maxXYPointAnnotation.ArrowTailStyle = customArrowTailStyle;
        }
    }
}
