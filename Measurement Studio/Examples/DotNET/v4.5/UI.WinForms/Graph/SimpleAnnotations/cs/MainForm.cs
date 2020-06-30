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

namespace NationalInstruments.Examples.SimpleAnnotations
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.Range newRange;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private System.Windows.Forms.Button genDataButton;
        private Random random;
        private NationalInstruments.UI.WindowsForms.WaveformGraph dataWaveformGraph;
        private NationalInstruments.UI.XYPointAnnotation maxXYPointAnnotation;
        private NationalInstruments.UI.XYPointAnnotation minXYPointAnnotation;
        private NationalInstruments.UI.WindowsForms.Knob scaleKnob;
        private System.Windows.Forms.GroupBox annotationSettingGroupBox;
        private System.Windows.Forms.RadioButton hideAnnotationRadioButton;
        private System.Windows.Forms.RadioButton hideArrowsRadioButton;
        private System.Windows.Forms.RadioButton hideShapesRadioButton;
        private System.Windows.Forms.RadioButton showAllRadioButton;
                
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
            this.scaleKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.annotationSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.showAllRadioButton = new System.Windows.Forms.RadioButton();
            this.hideArrowsRadioButton = new System.Windows.Forms.RadioButton();
            this.hideAnnotationRadioButton = new System.Windows.Forms.RadioButton();
            this.hideShapesRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleKnob)).BeginInit();
            this.annotationSettingGroupBox.SuspendLayout();
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
            this.dataWaveformGraph.Size = new System.Drawing.Size(528, 240);
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
            this.maxXYPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopRight, 0F, 0F);
            this.maxXYPointAnnotation.Caption = "Max Value";
            this.maxXYPointAnnotation.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.maxXYPointAnnotation.XAxis = this.xAxis1;
            this.maxXYPointAnnotation.XPosition = 2;
            this.maxXYPointAnnotation.YAxis = this.yAxis1;
            this.maxXYPointAnnotation.YPosition = 4;
            // 
            // yAxis1
            // 
            this.yAxis1.Mode = NationalInstruments.UI.AxisMode.Fixed;
            // 
            // minXYPointAnnotation
            // 
            this.minXYPointAnnotation.ArrowColor = System.Drawing.Color.DeepSkyBlue;
            this.minXYPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.BottomLeft, 0F, 0F);
            this.minXYPointAnnotation.Caption = "Min Value";
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
            this.genDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.genDataButton.Location = new System.Drawing.Point(392, 248);
            this.genDataButton.Name = "genDataButton";
            this.genDataButton.Size = new System.Drawing.Size(136, 48);
            this.genDataButton.TabIndex = 0;
            this.genDataButton.Text = "Generate Data";
            this.genDataButton.Click += new System.EventHandler(this.genDataButton_Click);
            // 
            // scaleKnob
            // 
            this.scaleKnob.AutoDivisionSpacing = false;
            this.scaleKnob.Border = NationalInstruments.UI.Border.Etched;
            this.scaleKnob.Caption = "Scale Data";
            this.scaleKnob.Location = new System.Drawing.Point(8, 248);
            this.scaleKnob.MinorDivisions.Interval = 5;
            this.scaleKnob.Name = "scaleKnob";
            this.scaleKnob.Range = new NationalInstruments.UI.Range(10, 50);
            this.scaleKnob.Size = new System.Drawing.Size(208, 144);
            this.scaleKnob.TabIndex = 2;
            this.scaleKnob.Value = 10;
            this.scaleKnob.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.scaleKnob_AfterChangeValue);
            // 
            // annotationSettingGroupBox
            // 
            this.annotationSettingGroupBox.Controls.Add(this.showAllRadioButton);
            this.annotationSettingGroupBox.Controls.Add(this.hideArrowsRadioButton);
            this.annotationSettingGroupBox.Controls.Add(this.hideAnnotationRadioButton);
            this.annotationSettingGroupBox.Controls.Add(this.hideShapesRadioButton);
            this.annotationSettingGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.annotationSettingGroupBox.Location = new System.Drawing.Point(224, 240);
            this.annotationSettingGroupBox.Name = "annotationSettingGroupBox";
            this.annotationSettingGroupBox.Size = new System.Drawing.Size(160, 152);
            this.annotationSettingGroupBox.TabIndex = 3;
            this.annotationSettingGroupBox.TabStop = false;
            this.annotationSettingGroupBox.Text = "Annotation Settings";
            // 
            // showAllRadioButton
            // 
            this.showAllRadioButton.Checked = true;
            this.showAllRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showAllRadioButton.Location = new System.Drawing.Point(8, 118);
            this.showAllRadioButton.Name = "showAllRadioButton";
            this.showAllRadioButton.Size = new System.Drawing.Size(120, 24);
            this.showAllRadioButton.TabIndex = 10;
            this.showAllRadioButton.TabStop = true;
            this.showAllRadioButton.Text = "Show All";
            this.showAllRadioButton.CheckedChanged += new System.EventHandler(this.showAllRadioButton_CheckedChanged);
            // 
            // hideArrowsRadioButton
            // 
            this.hideArrowsRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideArrowsRadioButton.Location = new System.Drawing.Point(8, 50);
            this.hideArrowsRadioButton.Name = "hideArrowsRadioButton";
            this.hideArrowsRadioButton.Size = new System.Drawing.Size(120, 32);
            this.hideArrowsRadioButton.TabIndex = 8;
            this.hideArrowsRadioButton.Text = "Hide Annotation Arrows";
            this.hideArrowsRadioButton.CheckedChanged += new System.EventHandler(this.hideArrowsRadioButton_CheckedChanged);
            // 
            // hideAnnotationRadioButton
            // 
            this.hideAnnotationRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideAnnotationRadioButton.Location = new System.Drawing.Point(8, 16);
            this.hideAnnotationRadioButton.Name = "hideAnnotationRadioButton";
            this.hideAnnotationRadioButton.Size = new System.Drawing.Size(120, 32);
            this.hideAnnotationRadioButton.TabIndex = 7;
            this.hideAnnotationRadioButton.Text = "Hide Annotations";
            this.hideAnnotationRadioButton.CheckedChanged += new System.EventHandler(this.hideAnnotationRadioButton_CheckedChanged);
            // 
            // hideShapesRadioButton
            // 
            this.hideShapesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hideShapesRadioButton.Location = new System.Drawing.Point(8, 84);
            this.hideShapesRadioButton.Name = "hideShapesRadioButton";
            this.hideShapesRadioButton.Size = new System.Drawing.Size(120, 32);
            this.hideShapesRadioButton.TabIndex = 9;
            this.hideShapesRadioButton.Text = "Hide Annotation Shapes";
            this.hideShapesRadioButton.CheckedChanged += new System.EventHandler(this.hideShapesRadioButton_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(530, 400);
            this.Controls.Add(this.annotationSettingGroupBox);
            this.Controls.Add(this.scaleKnob);
            this.Controls.Add(this.dataWaveformGraph);
            this.Controls.Add(this.genDataButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(536, 432);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Annotations";
            ((System.ComponentModel.ISupportInitialize)(this.dataWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleKnob)).EndInit();
            this.annotationSettingGroupBox.ResumeLayout(false);
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
            if(newRange != null)
                yAxis1.Range = newRange;

            double[] data = new double[50];

            for(int i = 0;i<50;i++)
                data[i] = scaleKnob.Value * random.NextDouble();

            double max,min;
            int maxIndex =0;
            int minIndex = 0;

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

        private void hideAnnotationRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
        
            minXYPointAnnotation.Visible = !minXYPointAnnotation.Visible;
            maxXYPointAnnotation.Visible = !maxXYPointAnnotation.Visible;
        }

        private void hideShapesRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXYPointAnnotation.ShapeVisible = !minXYPointAnnotation.ShapeVisible;
            maxXYPointAnnotation.ShapeVisible = !maxXYPointAnnotation.ShapeVisible;
           
        }

        private void hideArrowsRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            minXYPointAnnotation.ArrowVisible = !minXYPointAnnotation.ArrowVisible;
            maxXYPointAnnotation.ArrowVisible = !maxXYPointAnnotation.ArrowVisible;
       
        }

        private void showAllRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
        
            minXYPointAnnotation.ArrowVisible = true;
            maxXYPointAnnotation.ArrowVisible = true;
            minXYPointAnnotation.ShapeVisible = true;
            maxXYPointAnnotation.ShapeVisible = true;
            minXYPointAnnotation.Visible = true;
            maxXYPointAnnotation.Visible = true;

        }

        private void scaleKnob_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            newRange = new Range(-3, e.NewValue + 3);
        }
    }
}
