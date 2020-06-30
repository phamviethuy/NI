using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.ComplexPointAnnotation
{
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.ComplexGraph aComplexGraph;
        private NationalInstruments.UI.ComplexXAxis complexXAxis;
        private NationalInstruments.UI.ComplexYAxis complexYAxis;
        private NationalInstruments.UI.ComplexPlot complexPlot;
        private NationalInstruments.UI.ComplexPointAnnotation maxComplexPointAnnotation;
        private NationalInstruments.UI.ComplexPointAnnotation minComplexPointAnnotation;
        private System.Windows.Forms.GroupBox scaleGroupBox;
        private System.Windows.Forms.Button generateDataButton;
        private System.Windows.Forms.Label lineStyleLabel;
        private System.Windows.Forms.Label headStyleLabel;
        private System.Windows.Forms.Label tailStyleLabel;
        private System.Windows.Forms.Label shapeStyleLabel;
        private System.Windows.Forms.GroupBox annotationSettingsGroupBox;
        private System.Windows.Forms.Label captionsLabel;
        private NationalInstruments.UI.WindowsForms.Knob scaleDataKnob;
		private System.ComponentModel.Container components = null;
        private System.Windows.Forms.GroupBox plotSettingsGroupBox;
        private System.Windows.Forms.Label plotTypeLabel;
        private System.Windows.Forms.ComboBox plotTypeComboBox;
        private NationalInstruments.UI.WindowsForms.PropertyEditor interactionModePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor shapeStylePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor tailStylePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor headStylePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor lineStylePropertyEditor;

        private Random random; 
        private int defaultNumberOfPoints;

		public MainForm()
		{
			InitializeComponent();
			random = new Random();
			defaultNumberOfPoints = 100;

            plotTypeComboBox.SelectedItem = "Default";
            RefreshData();
		}

		protected override void Dispose( bool disposing )
		{
			if ( disposing )
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
            this.aComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.maxComplexPointAnnotation = new NationalInstruments.UI.ComplexPointAnnotation();
            this.complexXAxis = new NationalInstruments.UI.ComplexXAxis();
            this.complexYAxis = new NationalInstruments.UI.ComplexYAxis();
            this.minComplexPointAnnotation = new NationalInstruments.UI.ComplexPointAnnotation();
            this.complexPlot = new NationalInstruments.UI.ComplexPlot();
            this.scaleGroupBox = new System.Windows.Forms.GroupBox();
            this.generateDataButton = new System.Windows.Forms.Button();
            this.scaleDataKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.annotationSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.interactionModePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.shapeStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.tailStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.headStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.lineStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.captionsLabel = new System.Windows.Forms.Label();
            this.shapeStyleLabel = new System.Windows.Forms.Label();
            this.tailStyleLabel = new System.Windows.Forms.Label();
            this.headStyleLabel = new System.Windows.Forms.Label();
            this.lineStyleLabel = new System.Windows.Forms.Label();
            this.plotSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.plotTypeComboBox = new System.Windows.Forms.ComboBox();
            this.plotTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aComplexGraph)).BeginInit();
            this.scaleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleDataKnob)).BeginInit();
            this.annotationSettingsGroupBox.SuspendLayout();
            this.plotSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // aComplexGraph
            // 
            this.aComplexGraph.Annotations.AddRange(new NationalInstruments.UI.ComplexAnnotation[] {
            this.maxComplexPointAnnotation,
            this.minComplexPointAnnotation});
            this.aComplexGraph.Location = new System.Drawing.Point(16, 16);
            this.aComplexGraph.Name = "aComplexGraph";
            this.aComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
            this.complexPlot});
            this.aComplexGraph.Size = new System.Drawing.Size(568, 504);
            this.aComplexGraph.TabIndex = 4;
            this.aComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
            this.complexXAxis});
            this.aComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
            this.complexYAxis});
            // 
            // maxComplexPointAnnotation
            // 
            this.maxComplexPointAnnotation.ArrowColor = System.Drawing.Color.Firebrick;
            this.maxComplexPointAnnotation.ArrowLineWidth = 2F;
            this.maxComplexPointAnnotation.Caption = "Maximum Magnitude";
            this.maxComplexPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.MiddleCenter, -104F, -70F);
            this.maxComplexPointAnnotation.ToolTipFormatString = "{R:N:G5}+{I:N:G5}i [ {M:N:F3} ]";
            this.maxComplexPointAnnotation.ToolTipMode = NationalInstruments.UI.AnnotationToolTipMode.Data;
            this.maxComplexPointAnnotation.XAxis = this.complexXAxis;
            this.maxComplexPointAnnotation.YAxis = this.complexYAxis;
            // 
            // minComplexPointAnnotation
            // 
            this.minComplexPointAnnotation.ArrowColor = System.Drawing.Color.Gold;
            this.minComplexPointAnnotation.ArrowLineWidth = 2F;
            this.minComplexPointAnnotation.Caption = "Minimum Magnitude";
            this.minComplexPointAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.MiddleCenter, 109.1386F, -91F);
            this.minComplexPointAnnotation.ToolTipFormatString = "{R:N:G5}+{I:N:G5}i [ {M:N:F3} ]";
            this.minComplexPointAnnotation.ToolTipMode = NationalInstruments.UI.AnnotationToolTipMode.Data;
            this.minComplexPointAnnotation.XAxis = this.complexXAxis;
            this.minComplexPointAnnotation.YAxis = this.complexYAxis;
            // 
            // complexPlot
            // 
            this.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode();
            this.complexPlot.XAxis = this.complexXAxis;
            this.complexPlot.YAxis = this.complexYAxis;
            // 
            // scaleGroupBox
            // 
            this.scaleGroupBox.Controls.Add(this.generateDataButton);
            this.scaleGroupBox.Controls.Add(this.scaleDataKnob);
            this.scaleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scaleGroupBox.Location = new System.Drawing.Point(600, 280);
            this.scaleGroupBox.Name = "scaleGroupBox";
            this.scaleGroupBox.Size = new System.Drawing.Size(240, 240);
            this.scaleGroupBox.TabIndex = 1;
            this.scaleGroupBox.TabStop = false;
            this.scaleGroupBox.Text = "Scale Data";
            // 
            // generateDataButton
            // 
            this.generateDataButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generateDataButton.Location = new System.Drawing.Point(32, 192);
            this.generateDataButton.Name = "generateDataButton";
            this.generateDataButton.Size = new System.Drawing.Size(176, 32);
            this.generateDataButton.TabIndex = 1;
            this.generateDataButton.Text = "Generate Data";
            this.generateDataButton.Click += new System.EventHandler(this.generateDataButton_Click);
            // 
            // scaleDataKnob
            // 
            this.scaleDataKnob.CaptionVisible = false;
            this.scaleDataKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThumb;
            this.scaleDataKnob.Location = new System.Drawing.Point(32, 24);
            this.scaleDataKnob.MinorDivisions.TickVisible = false;
            this.scaleDataKnob.Name = "scaleDataKnob";
            this.scaleDataKnob.Range = new NationalInstruments.UI.Range(1, 10);
            this.scaleDataKnob.Size = new System.Drawing.Size(176, 160);
            this.scaleDataKnob.TabIndex = 0;
            this.scaleDataKnob.Value = 1;
            // 
            // annotationSettingsGroupBox
            // 
            this.annotationSettingsGroupBox.Controls.Add(this.interactionModePropertyEditor);
            this.annotationSettingsGroupBox.Controls.Add(this.shapeStylePropertyEditor);
            this.annotationSettingsGroupBox.Controls.Add(this.tailStylePropertyEditor);
            this.annotationSettingsGroupBox.Controls.Add(this.headStylePropertyEditor);
            this.annotationSettingsGroupBox.Controls.Add(this.lineStylePropertyEditor);
            this.annotationSettingsGroupBox.Controls.Add(this.captionsLabel);
            this.annotationSettingsGroupBox.Controls.Add(this.shapeStyleLabel);
            this.annotationSettingsGroupBox.Controls.Add(this.tailStyleLabel);
            this.annotationSettingsGroupBox.Controls.Add(this.headStyleLabel);
            this.annotationSettingsGroupBox.Controls.Add(this.lineStyleLabel);
            this.annotationSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.annotationSettingsGroupBox.Location = new System.Drawing.Point(600, 11);
            this.annotationSettingsGroupBox.Name = "annotationSettingsGroupBox";
            this.annotationSettingsGroupBox.Size = new System.Drawing.Size(240, 198);
            this.annotationSettingsGroupBox.TabIndex = 2;
            this.annotationSettingsGroupBox.TabStop = false;
            this.annotationSettingsGroupBox.Text = "Annotation Settings";
            // 
            // interactionModePropertyEditor
            // 
            this.interactionModePropertyEditor.Location = new System.Drawing.Point(112, 165);
            this.interactionModePropertyEditor.Name = "interactionModePropertyEditor";
            this.interactionModePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.interactionModePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.maxComplexPointAnnotation, "InteractionMode");
            this.interactionModePropertyEditor.TabIndex = 4;
            this.interactionModePropertyEditor.SourceValueChanged += new System.EventHandler(this.interactionModePropertyEditor_SourceValueChanged);
            // 
            // shapeStylePropertyEditor
            // 
            this.shapeStylePropertyEditor.Location = new System.Drawing.Point(112, 129);
            this.shapeStylePropertyEditor.Name = "shapeStylePropertyEditor";
            this.shapeStylePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.shapeStylePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.maxComplexPointAnnotation, "ShapeStyle");
            this.shapeStylePropertyEditor.TabIndex = 3;
            this.shapeStylePropertyEditor.SourceValueChanged += new System.EventHandler(this.shapeStylePropertyEditor_SourceValueChanged);
            // 
            // tailStylePropertyEditor
            // 
            this.tailStylePropertyEditor.Location = new System.Drawing.Point(112, 93);
            this.tailStylePropertyEditor.Name = "tailStylePropertyEditor";
            this.tailStylePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.tailStylePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.maxComplexPointAnnotation, "ArrowTailStyle");
            this.tailStylePropertyEditor.TabIndex = 2;
            this.tailStylePropertyEditor.SourceValueChanged += new System.EventHandler(this.tailStylePropertyEditor_SourceValueChanged);
            // 
            // headStylePropertyEditor
            // 
            this.headStylePropertyEditor.Location = new System.Drawing.Point(112, 57);
            this.headStylePropertyEditor.Name = "headStylePropertyEditor";
            this.headStylePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.headStylePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.maxComplexPointAnnotation, "ArrowHeadStyle");
            this.headStylePropertyEditor.TabIndex = 1;
            this.headStylePropertyEditor.SourceValueChanged += new System.EventHandler(this.headStylePropertyEditor_SourceValueChanged);
            // 
            // lineStylePropertyEditor
            // 
            this.lineStylePropertyEditor.Location = new System.Drawing.Point(112, 21);
            this.lineStylePropertyEditor.Name = "lineStylePropertyEditor";
            this.lineStylePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.lineStylePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.maxComplexPointAnnotation, "ArrowLineStyle");
            this.lineStylePropertyEditor.TabIndex = 0;
            this.lineStylePropertyEditor.SourceValueChanged += new System.EventHandler(this.lineStylePropertyEditor_SourceValueChanged);
            // 
            // captionsLabel
            // 
            this.captionsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.captionsLabel.Location = new System.Drawing.Point(16, 167);
            this.captionsLabel.Name = "captionsLabel";
            this.captionsLabel.Size = new System.Drawing.Size(88, 23);
            this.captionsLabel.TabIndex = 9;
            this.captionsLabel.Text = "Interaction Mode:";
            // 
            // shapeStyleLabel
            // 
            this.shapeStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.shapeStyleLabel.Location = new System.Drawing.Point(15, 132);
            this.shapeStyleLabel.Name = "shapeStyleLabel";
            this.shapeStyleLabel.Size = new System.Drawing.Size(89, 23);
            this.shapeStyleLabel.TabIndex = 7;
            this.shapeStyleLabel.Text = "Shape Style:";
            // 
            // tailStyleLabel
            // 
            this.tailStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tailStyleLabel.Location = new System.Drawing.Point(16, 96);
            this.tailStyleLabel.Name = "tailStyleLabel";
            this.tailStyleLabel.Size = new System.Drawing.Size(88, 23);
            this.tailStyleLabel.TabIndex = 6;
            this.tailStyleLabel.Text = "Arrow Tail Style:";
            // 
            // headStyleLabel
            // 
            this.headStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.headStyleLabel.Location = new System.Drawing.Point(16, 60);
            this.headStyleLabel.Name = "headStyleLabel";
            this.headStyleLabel.Size = new System.Drawing.Size(88, 23);
            this.headStyleLabel.TabIndex = 5;
            this.headStyleLabel.Text = "Arrow Head Style:";
            // 
            // lineStyleLabel
            // 
            this.lineStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineStyleLabel.Location = new System.Drawing.Point(16, 24);
            this.lineStyleLabel.Name = "lineStyleLabel";
            this.lineStyleLabel.Size = new System.Drawing.Size(88, 23);
            this.lineStyleLabel.TabIndex = 4;
            this.lineStyleLabel.Text = "Arrow Line Style:";
            // 
            // plotSettingsGroupBox
            // 
            this.plotSettingsGroupBox.Controls.Add(this.plotTypeComboBox);
            this.plotSettingsGroupBox.Controls.Add(this.plotTypeLabel);
            this.plotSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotSettingsGroupBox.Location = new System.Drawing.Point(600, 216);
            this.plotSettingsGroupBox.Name = "plotSettingsGroupBox";
            this.plotSettingsGroupBox.Size = new System.Drawing.Size(240, 56);
            this.plotSettingsGroupBox.TabIndex = 3;
            this.plotSettingsGroupBox.TabStop = false;
            this.plotSettingsGroupBox.Text = " Plot Settings";
            // 
            // plotTypeComboBox
            // 
            this.plotTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plotTypeComboBox.Items.AddRange(new object[] {
            "Cardioid",
            "Random",
            "Sine",
            "Cos",
            "Spiral",
            "Polar",
            "Default"});
            this.plotTypeComboBox.Location = new System.Drawing.Point(120, 18);
            this.plotTypeComboBox.Name = "plotTypeComboBox";
            this.plotTypeComboBox.Size = new System.Drawing.Size(112, 21);
            this.plotTypeComboBox.TabIndex = 5;
            this.plotTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.generateDataButton_Click);
            // 
            // plotTypeLabel
            // 
            this.plotTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotTypeLabel.Location = new System.Drawing.Point(24, 23);
            this.plotTypeLabel.Name = "plotTypeLabel";
            this.plotTypeLabel.Size = new System.Drawing.Size(80, 23);
            this.plotTypeLabel.TabIndex = 16;
            this.plotTypeLabel.Text = "Plot Type:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(856, 542);
            this.Controls.Add(this.plotSettingsGroupBox);
            this.Controls.Add(this.annotationSettingsGroupBox);
            this.Controls.Add(this.scaleGroupBox);
            this.Controls.Add(this.aComplexGraph);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Complex Graph Annotations";
            ((System.ComponentModel.ISupportInitialize)(this.aComplexGraph)).EndInit();
            this.scaleGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scaleDataKnob)).EndInit();
            this.annotationSettingsGroupBox.ResumeLayout(false);
            this.plotSettingsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }
		#endregion

		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
            Application.DoEvents();
			Application.Run(new MainForm());
		}


        public ComplexDouble[] GenerateData(int numberOfPoints, double maxValue )
        {
            ComplexDouble[] complexData = new ComplexDouble[numberOfPoints];
            int divisor = numberOfPoints - 1;
            
            switch (plotTypeComboBox.SelectedItem as String)
            {
                case "Random":
                    for (int i = 0 ; i < numberOfPoints ; i++)
                    {
                        complexData[i].Real = -maxValue + (Double)i / divisor * ( maxValue * 2 );
                        complexData[i].Imaginary = maxValue * ( random.NextDouble() - 0.5 );
                    }
                    break;
                case "Polar":
                    for (int i = 0 ; i < numberOfPoints ; i++)
                    {
                        double r = ((Double)i / divisor) * Math.PI * 2;
                        complexData[i].Real = maxValue * Math.Cos( r ) * ( Math.Sin(r * 3) + 0.5 );
                        complexData[i].Imaginary = maxValue * Math.Sin( r ) * ( Math.Sin(r * 3) + 0.5 );
                    }
                    break;
                case "Cardioid":
                    for (int i = 0; i < numberOfPoints; i++)
                    {
                        Double r = (maxValue  * (1 - Math.Sin(i * 2 * Math.PI / (numberOfPoints - 1))));
                        complexData[i].Real = r * (maxValue / 2 * ((Double)Math.Sin(i * 2 * Math.PI / (numberOfPoints - 1))));
                        complexData[i].Imaginary = r * (maxValue / 2 * ((Double)Math.Cos(i * 2 * Math.PI / (numberOfPoints - 1))));
                    }
                    break;
                case "Sine":
                    for (int i = 0 ; i < numberOfPoints ; i++)
                    {
                        complexData[i].Real = -maxValue + (Double)i / divisor * ( maxValue * 2 );
                        complexData[i].Imaginary = maxValue * Math.Sin( (Double) i / divisor * 2 * Math.PI );
                    }
                    break;
                case "Cos":
                    for (int i = 0 ; i < numberOfPoints ; i++)
                    {
                        complexData[i].Real = -maxValue + (Double)i / divisor * ( maxValue * 2 );
                        complexData[i].Imaginary = -maxValue * Math.Cos( (Double) i / divisor * 2 * Math.PI );
                    }
                    break;
                case "Spiral":
                    for (int i = 0 ; i < numberOfPoints ; i++)
                    {
                        complexData[i].Real = i * Math.Cos(i * 6 * Math.PI / divisor ) * maxValue / divisor;
                        complexData[i].Imaginary = i * Math.Sin(i * 6 * Math.PI / divisor ) * maxValue / divisor;
                    }
                    break;
                default:
                    Double xMax = maxValue, xMin = -maxValue;
                    Double yMax = maxValue, yMin = -maxValue;                    
			        Double theta = 0;
                    Double thetaRange = (10 * Math.PI);

                    for (int j = 0; j < numberOfPoints; j++)
                    {
                        complexData[j].Real = (((xMax - xMin) / (numberOfPoints - 1)) * j) + xMin;
                        theta = ((j - ((numberOfPoints - 1) / 2.0)) * thetaRange / (numberOfPoints - 1));

                        while (theta < -(thetaRange / 2)) 
                            theta += thetaRange;
                        if (theta == 0) 
                            complexData[j].Imaginary = yMax;
                        else
                            complexData[j].Imaginary = (Math.Sin(theta) / (theta)) * (3 * (yMax - yMin) / 4.0) + ((yMax - yMin) / 4) + yMin;
                    }
                    break;
            }
                return complexData;            
        }

        private void RefreshData()
        {
            complexPlot.PlotComplex(GenerateData(defaultNumberOfPoints, scaleDataKnob.Value));

            ComplexDouble maxComplexPoint = new ComplexDouble(0, 0), minComplexPoint = new ComplexDouble(0, 0);
            Double maxMag = Double.MinValue, minMag = Double.MaxValue;

            foreach (ComplexDouble point in complexPlot.GetComplexData())
            {
                if (point.Magnitude > maxMag) 
                { 
				    maxMag = point.Magnitude; 
				    maxComplexPoint = point; 
				}
                if (point.Magnitude < minMag) 
                { 
                    minMag = point.Magnitude; 
                    minComplexPoint = point; 
                }
            }

            maxComplexPointAnnotation.SetPosition(maxComplexPoint);
            minComplexPointAnnotation.SetPosition(minComplexPoint);
        }

        private void generateDataButton_Click(object sender, System.EventArgs e)
        {
            RefreshData();
        }

        private void lineStylePropertyEditor_SourceValueChanged(object sender, System.EventArgs e)
        {
            minComplexPointAnnotation.ArrowLineStyle = maxComplexPointAnnotation.ArrowLineStyle;
        }

        private void headStylePropertyEditor_SourceValueChanged(object sender, System.EventArgs e)
        {
            minComplexPointAnnotation.ArrowHeadStyle = maxComplexPointAnnotation.ArrowHeadStyle;
        }

        private void tailStylePropertyEditor_SourceValueChanged(object sender, System.EventArgs e)
        {
            minComplexPointAnnotation.ArrowTailStyle = maxComplexPointAnnotation.ArrowTailStyle;
        }

        private void shapeStylePropertyEditor_SourceValueChanged(object sender, System.EventArgs e)
        {
            minComplexPointAnnotation.ShapeStyle = maxComplexPointAnnotation.ShapeStyle;
        }

        private void interactionModePropertyEditor_SourceValueChanged(object sender, System.EventArgs e)
        {
            minComplexPointAnnotation.InteractionMode = maxComplexPointAnnotation.InteractionMode;
        } 
	}
}
