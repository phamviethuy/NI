using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;



namespace NationalInstruments.Examples.MagnitudePhaseRangeAnnotation
{
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.ComplexXAxis complexXAxis;
        private NationalInstruments.UI.ComplexYAxis complexYAxis;
        private NationalInstruments.UI.ComplexPlot complexPlot;
        private System.Windows.Forms.GroupBox annotationSettingsGroupBox;
        private System.Windows.Forms.Label rangeZOrderLabel;
        private System.Windows.Forms.Label rangeFillStyleLabel;
        private System.Windows.Forms.Label rangeFillColorLabel;
        private System.Windows.Forms.Label magnitudeLabel;
        private System.Windows.Forms.Label startMagnitudeLabel;
        private System.Windows.Forms.Label phaseLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeZOrderPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeFillStylePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeFillColorPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor phasePropertyEditor;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitOneMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitTwoMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitThreeMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitFourMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitFiveMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitSixMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitSevenMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitEightMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudeCircleAnnotation unitNineMagnitudeCircleAnnotation;
        private NationalInstruments.UI.MagnitudePhaseRangeAnnotation magnitudePhaseRangeAnnotation;
        private NationalInstruments.UI.WindowsForms.NumericEdit magnitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.ComplexGraph aComplexGraph;
        private NationalInstruments.UI.WindowsForms.NumericEdit startMagnitudeNumericEdit;
        private System.ComponentModel.Container components = null;

        private int numberOfPoints;
        private Double maxValue;

        public MainForm()
        {
            InitializeComponent();
            numberOfPoints = 100;
            maxValue = 10;
            startMagnitudeNumericEdit.Value = 3;
            magnitudeNumericEdit.Value = 4;
            complexPlot.PlotComplex(GeneratePlotData(numberOfPoints, maxValue));
        }

        private static ComplexDouble[] GeneratePlotData(int numberOfPoints, Double maxValue)
        {
            Double xMax = maxValue, xMin = -maxValue;
            Double yMax = maxValue, yMin = -maxValue;                    
            Double theta = 0, thetaRange = (10 * Math.PI);
            ComplexDouble[] complexData = new ComplexDouble[ numberOfPoints ]; 

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
            return complexData;
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.complexXAxis = new NationalInstruments.UI.ComplexXAxis();
			this.complexYAxis = new NationalInstruments.UI.ComplexYAxis();
			this.complexPlot = new NationalInstruments.UI.ComplexPlot();
			this.aComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
			this.unitOneMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitTwoMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitThreeMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitFourMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitFiveMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitSixMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitSevenMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitEightMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.unitNineMagnitudeCircleAnnotation = new NationalInstruments.UI.MagnitudeCircleAnnotation();
			this.magnitudePhaseRangeAnnotation = new NationalInstruments.UI.MagnitudePhaseRangeAnnotation();
			this.annotationSettingsGroupBox = new System.Windows.Forms.GroupBox();
			this.magnitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.startMagnitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
			this.rangeZOrderLabel = new System.Windows.Forms.Label();
			this.rangeFillStyleLabel = new System.Windows.Forms.Label();
			this.rangeFillColorLabel = new System.Windows.Forms.Label();
			this.magnitudeLabel = new System.Windows.Forms.Label();
			this.startMagnitudeLabel = new System.Windows.Forms.Label();
			this.phaseLabel = new System.Windows.Forms.Label();
			this.rangeZOrderPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
			this.rangeFillStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
			this.rangeFillColorPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
			this.phasePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
			((System.ComponentModel.ISupportInitialize)(this.aComplexGraph)).BeginInit();
			this.annotationSettingsGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.magnitudeNumericEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.startMagnitudeNumericEdit)).BeginInit();
			this.SuspendLayout();
			// 
			// complexPlot
			// 
			this.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode();
			this.complexPlot.XAxis = this.complexXAxis;
			this.complexPlot.YAxis = this.complexYAxis;
			// 
			// aComplexGraph
			// 
			this.aComplexGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.aComplexGraph.Annotations.AddRange(new NationalInstruments.UI.ComplexAnnotation[] {
																									   this.unitOneMagnitudeCircleAnnotation,
																									   this.unitTwoMagnitudeCircleAnnotation,
																									   this.unitThreeMagnitudeCircleAnnotation,
																									   this.unitFourMagnitudeCircleAnnotation,
																									   this.unitFiveMagnitudeCircleAnnotation,
																									   this.unitSixMagnitudeCircleAnnotation,
																									   this.unitSevenMagnitudeCircleAnnotation,
																									   this.unitEightMagnitudeCircleAnnotation,
																									   this.unitNineMagnitudeCircleAnnotation,
																									   this.magnitudePhaseRangeAnnotation});
			this.aComplexGraph.Location = new System.Drawing.Point(0, 0);
			this.aComplexGraph.Name = "aComplexGraph";
			this.aComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
																						   this.complexPlot});
			this.aComplexGraph.Size = new System.Drawing.Size(579, 413);
			this.aComplexGraph.TabIndex = 0;
			this.aComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
																							this.complexXAxis});
			this.aComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
																							this.complexYAxis});
			// 
			// unitOneMagnitudeCircleAnnotation
			// 
			this.unitOneMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitOneMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitOneMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitOneMagnitudeCircleAnnotation.Caption = "Magnitude = 1";
			this.unitOneMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitOneMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitOneMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitOneMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitOneMagnitudeCircleAnnotation.Magnitude = 1;
			this.unitOneMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitOneMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitTwoMagnitudeCircleAnnotation
			// 
			this.unitTwoMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitTwoMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitTwoMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitTwoMagnitudeCircleAnnotation.Caption = "Magnitude = 2";
			this.unitTwoMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitTwoMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitTwoMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitTwoMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitTwoMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitTwoMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitThreeMagnitudeCircleAnnotation
			// 
			this.unitThreeMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitThreeMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitThreeMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitThreeMagnitudeCircleAnnotation.Caption = "Magnitude = 3";
			this.unitThreeMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitThreeMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitThreeMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitThreeMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitThreeMagnitudeCircleAnnotation.Magnitude = 3;
			this.unitThreeMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitThreeMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitFourMagnitudeCircleAnnotation
			// 
			this.unitFourMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitFourMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitFourMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitFourMagnitudeCircleAnnotation.Caption = "Magnitude = 4";
			this.unitFourMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitFourMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitFourMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitFourMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitFourMagnitudeCircleAnnotation.Magnitude = 4;
			this.unitFourMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitFourMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitFiveMagnitudeCircleAnnotation
			// 
			this.unitFiveMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitFiveMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitFiveMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitFiveMagnitudeCircleAnnotation.Caption = "Magnitude = 5";
			this.unitFiveMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitFiveMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitFiveMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitFiveMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitFiveMagnitudeCircleAnnotation.Magnitude = 5;
			this.unitFiveMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitFiveMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitSixMagnitudeCircleAnnotation
			// 
			this.unitSixMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitSixMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitSixMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitSixMagnitudeCircleAnnotation.Caption = "Magnitude = 6";
			this.unitSixMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitSixMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitSixMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitSixMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitSixMagnitudeCircleAnnotation.Magnitude = 6;
			this.unitSixMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitSixMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitSevenMagnitudeCircleAnnotation
			// 
			this.unitSevenMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitSevenMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitSevenMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitSevenMagnitudeCircleAnnotation.Caption = "Magnitude = 7";
			this.unitSevenMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitSevenMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitSevenMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitSevenMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitSevenMagnitudeCircleAnnotation.Magnitude = 7;
			this.unitSevenMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitSevenMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitEightMagnitudeCircleAnnotation
			// 
			this.unitEightMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitEightMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitEightMagnitudeCircleAnnotation.Caption = "Magnitude = 8";
			this.unitEightMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitEightMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitEightMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitEightMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitEightMagnitudeCircleAnnotation.Magnitude = 8;
			this.unitEightMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitEightMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// unitNineMagnitudeCircleAnnotation
			// 
			this.unitNineMagnitudeCircleAnnotation.ArrowHeadMagnitude = 7;
			this.unitNineMagnitudeCircleAnnotation.ArrowLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitNineMagnitudeCircleAnnotation.ArrowVisible = false;
			this.unitNineMagnitudeCircleAnnotation.Caption = "Magnitude = 9";
			this.unitNineMagnitudeCircleAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.None, 0F, 25F);
			this.unitNineMagnitudeCircleAnnotation.CaptionVisible = false;
			this.unitNineMagnitudeCircleAnnotation.CircleLineColor = System.Drawing.Color.DimGray;
			this.unitNineMagnitudeCircleAnnotation.CircleLineStyle = NationalInstruments.UI.LineStyle.Dot;
			this.unitNineMagnitudeCircleAnnotation.Magnitude = 9;
			this.unitNineMagnitudeCircleAnnotation.XAxis = this.complexXAxis;
			this.unitNineMagnitudeCircleAnnotation.YAxis = this.complexYAxis;
			// 
			// magnitudePhaseRangeAnnotation
			// 
			this.magnitudePhaseRangeAnnotation.ArrowHeadMagnitude = 6.5;
			this.magnitudePhaseRangeAnnotation.ArrowHeadPhase = 45F;
			this.magnitudePhaseRangeAnnotation.Caption = "Annotated Region";
			this.magnitudePhaseRangeAnnotation.CaptionAlignment = new NationalInstruments.UI.AnnotationCaptionAlignment(NationalInstruments.UI.BoundsAlignment.TopRight, -31F, 59F);
			this.magnitudePhaseRangeAnnotation.Magnitude = 4;
			this.magnitudePhaseRangeAnnotation.Phase = new NationalInstruments.UI.Arc(245F, 90F);
			this.magnitudePhaseRangeAnnotation.RangeFillColor = System.Drawing.Color.DarkGray;
			this.magnitudePhaseRangeAnnotation.RangeFillStyle = NationalInstruments.UI.FillStyle.ZigZag;
			this.magnitudePhaseRangeAnnotation.XAxis = this.complexXAxis;
			this.magnitudePhaseRangeAnnotation.YAxis = this.complexYAxis;
			// 
			// annotationSettingsGroupBox
			// 
			this.annotationSettingsGroupBox.Controls.Add(this.magnitudeNumericEdit);
			this.annotationSettingsGroupBox.Controls.Add(this.startMagnitudeNumericEdit);
			this.annotationSettingsGroupBox.Controls.Add(this.rangeZOrderLabel);
			this.annotationSettingsGroupBox.Controls.Add(this.rangeFillStyleLabel);
			this.annotationSettingsGroupBox.Controls.Add(this.rangeFillColorLabel);
			this.annotationSettingsGroupBox.Controls.Add(this.magnitudeLabel);
			this.annotationSettingsGroupBox.Controls.Add(this.startMagnitudeLabel);
			this.annotationSettingsGroupBox.Controls.Add(this.phaseLabel);
			this.annotationSettingsGroupBox.Controls.Add(this.rangeZOrderPropertyEditor);
			this.annotationSettingsGroupBox.Controls.Add(this.rangeFillStylePropertyEditor);
			this.annotationSettingsGroupBox.Controls.Add(this.rangeFillColorPropertyEditor);
			this.annotationSettingsGroupBox.Controls.Add(this.phasePropertyEditor);
			this.annotationSettingsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.annotationSettingsGroupBox.Location = new System.Drawing.Point(8, 424);
			this.annotationSettingsGroupBox.Name = "annotationSettingsGroupBox";
			this.annotationSettingsGroupBox.Size = new System.Drawing.Size(560, 119);
			this.annotationSettingsGroupBox.TabIndex = 1;
			this.annotationSettingsGroupBox.TabStop = false;
			this.annotationSettingsGroupBox.Text = "Annotation Settings";
			// 
			// magnitudeNumericEdit
			// 
			this.magnitudeNumericEdit.CoercionInterval = 0.1;
			this.magnitudeNumericEdit.Location = new System.Drawing.Point(112, 80);
			this.magnitudeNumericEdit.Name = "magnitudeNumericEdit";
			this.magnitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.magnitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.magnitudeNumericEdit.Size = new System.Drawing.Size(144, 20);
			this.magnitudeNumericEdit.TabIndex = 13;
			this.magnitudeNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.magnitudeNumericEdit_AfterChangeValue);
			// 
			// startMagnitudeNumericEdit
			// 
			this.startMagnitudeNumericEdit.CoercionInterval = 0.1;
			this.startMagnitudeNumericEdit.Location = new System.Drawing.Point(112, 48);
			this.startMagnitudeNumericEdit.Name = "startMagnitudeNumericEdit";
			this.startMagnitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
			this.startMagnitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
			this.startMagnitudeNumericEdit.Size = new System.Drawing.Size(144, 20);
			this.startMagnitudeNumericEdit.TabIndex = 12;
			this.startMagnitudeNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.startMagnitudeNumericEdit_AfterChangeValue);
			// 
			// rangeZOrderLabel
			// 
			this.rangeZOrderLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rangeZOrderLabel.Location = new System.Drawing.Point(291, 81);
			this.rangeZOrderLabel.Name = "rangeZOrderLabel";
			this.rangeZOrderLabel.Size = new System.Drawing.Size(81, 17);
			this.rangeZOrderLabel.TabIndex = 11;
			this.rangeZOrderLabel.Text = "Range Z Order:";
			// 
			// rangeFillStyleLabel
			// 
			this.rangeFillStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rangeFillStyleLabel.Location = new System.Drawing.Point(291, 50);
			this.rangeFillStyleLabel.Name = "rangeFillStyleLabel";
			this.rangeFillStyleLabel.Size = new System.Drawing.Size(81, 17);
			this.rangeFillStyleLabel.TabIndex = 10;
			this.rangeFillStyleLabel.Text = "Range Fill Style:";
			// 
			// rangeFillColorLabel
			// 
			this.rangeFillColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rangeFillColorLabel.Location = new System.Drawing.Point(291, 20);
			this.rangeFillColorLabel.Name = "rangeFillColorLabel";
			this.rangeFillColorLabel.Size = new System.Drawing.Size(81, 17);
			this.rangeFillColorLabel.TabIndex = 9;
			this.rangeFillColorLabel.Text = "Range Fill Color:";
			// 
			// magnitudeLabel
			// 
			this.magnitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.magnitudeLabel.Location = new System.Drawing.Point(19, 80);
			this.magnitudeLabel.Name = "magnitudeLabel";
			this.magnitudeLabel.Size = new System.Drawing.Size(81, 17);
			this.magnitudeLabel.TabIndex = 8;
			this.magnitudeLabel.Text = "Magnitude:";
			// 
			// startMagnitudeLabel
			// 
			this.startMagnitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.startMagnitudeLabel.Location = new System.Drawing.Point(19, 50);
			this.startMagnitudeLabel.Name = "startMagnitudeLabel";
			this.startMagnitudeLabel.Size = new System.Drawing.Size(81, 17);
			this.startMagnitudeLabel.TabIndex = 7;
			this.startMagnitudeLabel.Text = "Start Magnitude:";
			// 
			// phaseLabel
			// 
			this.phaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.phaseLabel.Location = new System.Drawing.Point(19, 21);
			this.phaseLabel.Name = "phaseLabel";
			this.phaseLabel.Size = new System.Drawing.Size(81, 17);
			this.phaseLabel.TabIndex = 6;
			this.phaseLabel.Text = "Phase:";
			// 
			// rangeZOrderPropertyEditor
			// 
			this.rangeZOrderPropertyEditor.Location = new System.Drawing.Point(384, 80);
			this.rangeZOrderPropertyEditor.Name = "rangeZOrderPropertyEditor";
			this.rangeZOrderPropertyEditor.Size = new System.Drawing.Size(144, 20);
			this.rangeZOrderPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.magnitudePhaseRangeAnnotation, "RangeZOrder");
			this.rangeZOrderPropertyEditor.TabIndex = 5;
			// 
			// rangeFillStylePropertyEditor
			// 
			this.rangeFillStylePropertyEditor.Location = new System.Drawing.Point(384, 48);
			this.rangeFillStylePropertyEditor.Name = "rangeFillStylePropertyEditor";
			this.rangeFillStylePropertyEditor.Size = new System.Drawing.Size(144, 20);
			this.rangeFillStylePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.magnitudePhaseRangeAnnotation, "RangeFillStyle");
			this.rangeFillStylePropertyEditor.TabIndex = 4;
			// 
			// rangeFillColorPropertyEditor
			// 
			this.rangeFillColorPropertyEditor.Location = new System.Drawing.Point(384, 16);
			this.rangeFillColorPropertyEditor.Name = "rangeFillColorPropertyEditor";
			this.rangeFillColorPropertyEditor.Size = new System.Drawing.Size(144, 20);
			this.rangeFillColorPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.magnitudePhaseRangeAnnotation, "RangeFillColor");
			this.rangeFillColorPropertyEditor.TabIndex = 3;
			// 
			// phasePropertyEditor
			// 
			this.phasePropertyEditor.Location = new System.Drawing.Point(112, 16);
			this.phasePropertyEditor.Name = "phasePropertyEditor";
			this.phasePropertyEditor.Size = new System.Drawing.Size(144, 20);
			this.phasePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.magnitudePhaseRangeAnnotation, "Phase");
			this.phasePropertyEditor.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(576, 550);
			this.Controls.Add(this.annotationSettingsGroupBox);
			this.Controls.Add(this.aComplexGraph);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Magnitude Phase Range Annotation";
			((System.ComponentModel.ISupportInitialize)(this.aComplexGraph)).EndInit();
			this.annotationSettingsGroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.magnitudeNumericEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.startMagnitudeNumericEdit)).EndInit();
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

        private void startMagnitudeNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            magnitudePhaseRangeAnnotation.StartMagnitude = startMagnitudeNumericEdit.Value;
        }

        private void magnitudeNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            magnitudePhaseRangeAnnotation.Magnitude = magnitudeNumericEdit.Value;
        }
    }
}
