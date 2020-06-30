//==================================================================================================
//
// Title      : MainForm.cs
// Purpose    : This example shows the user how to use the Pulse Parameter function.
//
//==================================================================================================
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.PulseAnalyzer
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Global Variables
        /// </summary>
        double []pulseWave;
        double []xPosition;
        double []xWave;
        int counter = 0;
        bool demoClicked = false; 
        bool acquireClicked = false; 
        internal System.Windows.Forms.Label messageDisplayLabel;
        internal NationalInstruments.UI.XYCursor xyCursor;
        internal NationalInstruments.UI.ScatterPlot pointPlot;
        internal NationalInstruments.UI.XAxis xAxis;
        internal NationalInstruments.UI.YAxis yAxis;
        internal System.Windows.Forms.Button demoButton;
        internal System.Windows.Forms.Label amp90Label;
        internal System.Windows.Forms.Label amp50Label;
        internal System.Windows.Forms.Label amp10Label;
        internal System.Windows.Forms.Label baseValueLabel;
        internal System.Windows.Forms.Label topValueLabel;
        internal System.Windows.Forms.Label overshootLabel;
        internal System.Windows.Forms.Label delayLabel;
        internal System.Windows.Forms.Label undershootLabel;
        internal System.Windows.Forms.Label widthLabel;
        internal System.Windows.Forms.Label fallTimeLabel;
        internal System.Windows.Forms.Label riseTimeLabel;
        internal System.Windows.Forms.Label slewRateLabel;
        private System.Windows.Forms.TextBox instructionTextBox;
        private System.Windows.Forms.Timer timer;
        internal System.Windows.Forms.Button acquireButton;
        internal System.Windows.Forms.Button analyzePulseButton;
        internal System.Windows.Forms.GroupBox outputParametersGroupBox;
        internal NationalInstruments.UI.WindowsForms.ScatterGraph pulseScatterGraph;
        internal NationalInstruments.UI.WindowsForms.NumericEdit amp90NumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit slewRateNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit fallTimeNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit riseTimeNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit dataWidthNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit delayNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit undershootNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit overshootNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit baseValueNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit topValueNumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit amp10NumericEdit;
        internal NationalInstruments.UI.WindowsForms.NumericEdit amp50NumericEdit;
        int numOfTimerClick = 0; // records how many times timer has ticked.
        
        public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
            this.components = new System.ComponentModel.Container();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.messageDisplayLabel = new System.Windows.Forms.Label();
            this.pulseScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.xyCursor = new NationalInstruments.UI.XYCursor();
            this.pointPlot = new NationalInstruments.UI.ScatterPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.acquireButton = new System.Windows.Forms.Button();
            this.analyzePulseButton = new System.Windows.Forms.Button();
            this.demoButton = new System.Windows.Forms.Button();
            this.outputParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.amp90NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.slewRateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.fallTimeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.riseTimeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.dataWidthNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.delayNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.undershootNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.overshootNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.baseValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.topValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.amp10NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.amp50NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.amp90Label = new System.Windows.Forms.Label();
            this.amp50Label = new System.Windows.Forms.Label();
            this.amp10Label = new System.Windows.Forms.Label();
            this.baseValueLabel = new System.Windows.Forms.Label();
            this.topValueLabel = new System.Windows.Forms.Label();
            this.overshootLabel = new System.Windows.Forms.Label();
            this.delayLabel = new System.Windows.Forms.Label();
            this.undershootLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.fallTimeLabel = new System.Windows.Forms.Label();
            this.riseTimeLabel = new System.Windows.Forms.Label();
            this.slewRateLabel = new System.Windows.Forms.Label();
            this.instructionTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pulseScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).BeginInit();
            this.outputParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amp90NumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slewRateNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallTimeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riseTimeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWidthNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.undershootNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overshootNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp10NumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp50NumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // messageDisplayLabel
            // 
            this.messageDisplayLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.messageDisplayLabel.Location = new System.Drawing.Point(485, 52);
            this.messageDisplayLabel.Name = "messageDisplayLabel";
            this.messageDisplayLabel.Size = new System.Drawing.Size(280, 16);
            this.messageDisplayLabel.TabIndex = 22;
            this.messageDisplayLabel.Text = "Plotting a series of points simulating a pulsed signal.";
            this.messageDisplayLabel.Visible = false;
            // 
            // pulseScatterGraph
            // 
            this.pulseScatterGraph.Caption = "Pulse Waveform";
            this.pulseScatterGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
                                                                                              this.xyCursor});
            this.pulseScatterGraph.Location = new System.Drawing.Point(341, 84);
            this.pulseScatterGraph.Name = "pulseScatterGraph";
            this.pulseScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
                                                                                               this.pointPlot});
            this.pulseScatterGraph.Size = new System.Drawing.Size(416, 280);
            this.pulseScatterGraph.TabIndex = 23;
            this.pulseScatterGraph.TabStop = false;
            this.pulseScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                         this.xAxis});
            this.pulseScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                         this.yAxis});
            // 
            // xyCursor
            // 
            this.xyCursor.Color = System.Drawing.Color.Yellow;
            this.xyCursor.Plot = this.pointPlot;
            this.xyCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.Floating;
            this.xyCursor.XPosition = 0;
            // 
            // pointPlot
            // 
            this.pointPlot.LineWidth = 3F;
            this.pointPlot.PointSize = new System.Drawing.Size(3, 3);
            this.pointPlot.XAxis = this.xAxis;
            this.pointPlot.YAxis = this.yAxis;
            // 
            // xAxis
            // 
            this.xAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.xAxis.Range = new NationalInstruments.UI.Range(0, 100);
            // 
            // yAxis
            // 
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis.Range = new NationalInstruments.UI.Range(-50, 50);
            // 
            // acquireButton
            // 
            this.acquireButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.acquireButton.Location = new System.Drawing.Point(117, 92);
            this.acquireButton.Name = "acquireButton";
            this.acquireButton.Size = new System.Drawing.Size(96, 24);
            this.acquireButton.TabIndex = 18;
            this.acquireButton.Text = "Acquire";
            this.acquireButton.Click += new System.EventHandler(this.acquire_Click);
            // 
            // analyzePulseButton
            // 
            this.analyzePulseButton.Enabled = false;
            this.analyzePulseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.analyzePulseButton.Location = new System.Drawing.Point(229, 92);
            this.analyzePulseButton.Name = "analyzePulseButton";
            this.analyzePulseButton.Size = new System.Drawing.Size(96, 24);
            this.analyzePulseButton.TabIndex = 19;
            this.analyzePulseButton.Text = "Analyze Pulse";
            this.analyzePulseButton.Click += new System.EventHandler(this.analyzePulse_Click);
            // 
            // demoButton
            // 
            this.demoButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.demoButton.Location = new System.Drawing.Point(5, 92);
            this.demoButton.Name = "demoButton";
            this.demoButton.Size = new System.Drawing.Size(96, 24);
            this.demoButton.TabIndex = 17;
            this.demoButton.Text = "Demo";
            this.demoButton.Click += new System.EventHandler(this.demoButton_Click);
            // 
            // outputParametersGroupBox
            // 
            this.outputParametersGroupBox.Controls.Add(this.amp90NumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.slewRateNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.fallTimeNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.riseTimeNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.dataWidthNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.delayNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.undershootNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.overshootNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.baseValueNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.topValueNumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.amp10NumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.amp50NumericEdit);
            this.outputParametersGroupBox.Controls.Add(this.amp90Label);
            this.outputParametersGroupBox.Controls.Add(this.amp50Label);
            this.outputParametersGroupBox.Controls.Add(this.amp10Label);
            this.outputParametersGroupBox.Controls.Add(this.baseValueLabel);
            this.outputParametersGroupBox.Controls.Add(this.topValueLabel);
            this.outputParametersGroupBox.Controls.Add(this.overshootLabel);
            this.outputParametersGroupBox.Controls.Add(this.delayLabel);
            this.outputParametersGroupBox.Controls.Add(this.undershootLabel);
            this.outputParametersGroupBox.Controls.Add(this.widthLabel);
            this.outputParametersGroupBox.Controls.Add(this.fallTimeLabel);
            this.outputParametersGroupBox.Controls.Add(this.riseTimeLabel);
            this.outputParametersGroupBox.Controls.Add(this.slewRateLabel);
            this.outputParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.outputParametersGroupBox.Location = new System.Drawing.Point(5, 140);
            this.outputParametersGroupBox.Name = "outputParametersGroupBox";
            this.outputParametersGroupBox.Size = new System.Drawing.Size(320, 224);
            this.outputParametersGroupBox.TabIndex = 21;
            this.outputParametersGroupBox.TabStop = false;
            this.outputParametersGroupBox.Text = "Output Parameters";
            // 
            // amp90NumericEdit
            // 
            this.amp90NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.amp90NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.amp90NumericEdit.Location = new System.Drawing.Point(16, 40);
            this.amp90NumericEdit.Name = "amp90NumericEdit";
            this.amp90NumericEdit.Size = new System.Drawing.Size(72, 20);
            this.amp90NumericEdit.TabIndex = 14;
            this.amp90NumericEdit.TabStop = false;
            // 
            // slewRateNumericEdit
            // 
            this.slewRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.slewRateNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.slewRateNumericEdit.Location = new System.Drawing.Point(224, 184);
            this.slewRateNumericEdit.Name = "slewRateNumericEdit";
            this.slewRateNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.slewRateNumericEdit.TabIndex = 13;
            this.slewRateNumericEdit.TabStop = false;
            // 
            // fallTimeNumericEdit
            // 
            this.fallTimeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.fallTimeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.fallTimeNumericEdit.Location = new System.Drawing.Point(120, 184);
            this.fallTimeNumericEdit.Name = "fallTimeNumericEdit";
            this.fallTimeNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.fallTimeNumericEdit.TabIndex = 12;
            this.fallTimeNumericEdit.TabStop = false;
            // 
            // riseTimeNumericEdit
            // 
            this.riseTimeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.riseTimeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.riseTimeNumericEdit.Location = new System.Drawing.Point(16, 184);
            this.riseTimeNumericEdit.Name = "riseTimeNumericEdit";
            this.riseTimeNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.riseTimeNumericEdit.TabIndex = 11;
            this.riseTimeNumericEdit.TabStop = false;
            // 
            // dataWidthNumericEdit
            // 
            this.dataWidthNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.dataWidthNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.dataWidthNumericEdit.Location = new System.Drawing.Point(224, 136);
            this.dataWidthNumericEdit.Name = "dataWidthNumericEdit";
            this.dataWidthNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.dataWidthNumericEdit.TabIndex = 10;
            this.dataWidthNumericEdit.TabStop = false;
            // 
            // delayNumericEdit
            // 
            this.delayNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.delayNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.delayNumericEdit.Location = new System.Drawing.Point(120, 136);
            this.delayNumericEdit.Name = "delayNumericEdit";
            this.delayNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.delayNumericEdit.TabIndex = 9;
            this.delayNumericEdit.TabStop = false;
            // 
            // undershootNumericEdit
            // 
            this.undershootNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.undershootNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.undershootNumericEdit.Location = new System.Drawing.Point(16, 136);
            this.undershootNumericEdit.Name = "undershootNumericEdit";
            this.undershootNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.undershootNumericEdit.TabIndex = 8;
            this.undershootNumericEdit.TabStop = false;
            // 
            // overshootNumericEdit
            // 
            this.overshootNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.overshootNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.overshootNumericEdit.Location = new System.Drawing.Point(224, 88);
            this.overshootNumericEdit.Name = "overshootNumericEdit";
            this.overshootNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.overshootNumericEdit.TabIndex = 7;
            this.overshootNumericEdit.TabStop = false;
            // 
            // baseValueNumericEdit
            // 
            this.baseValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.baseValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.baseValueNumericEdit.Location = new System.Drawing.Point(120, 88);
            this.baseValueNumericEdit.Name = "baseValueNumericEdit";
            this.baseValueNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.baseValueNumericEdit.TabIndex = 6;
            this.baseValueNumericEdit.TabStop = false;
            // 
            // topValueNumericEdit
            // 
            this.topValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.topValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.topValueNumericEdit.Location = new System.Drawing.Point(16, 88);
            this.topValueNumericEdit.Name = "topValueNumericEdit";
            this.topValueNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.topValueNumericEdit.TabIndex = 5;
            this.topValueNumericEdit.TabStop = false;
            // 
            // amp10NumericEdit
            // 
            this.amp10NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.amp10NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.amp10NumericEdit.Location = new System.Drawing.Point(224, 40);
            this.amp10NumericEdit.Name = "amp10NumericEdit";
            this.amp10NumericEdit.Size = new System.Drawing.Size(72, 20);
            this.amp10NumericEdit.TabIndex = 4;
            this.amp10NumericEdit.TabStop = false;
            // 
            // amp50NumericEdit
            // 
            this.amp50NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.amp50NumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.amp50NumericEdit.Location = new System.Drawing.Point(120, 40);
            this.amp50NumericEdit.Name = "amp50NumericEdit";
            this.amp50NumericEdit.Size = new System.Drawing.Size(72, 20);
            this.amp50NumericEdit.TabIndex = 3;
            this.amp50NumericEdit.TabStop = false;
            // 
            // amp90Label
            // 
            this.amp90Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.amp90Label.Location = new System.Drawing.Point(16, 24);
            this.amp90Label.Name = "amp90Label";
            this.amp90Label.Size = new System.Drawing.Size(88, 16);
            this.amp90Label.TabIndex = 1;
            this.amp90Label.Text = "90 % Amplitude:";
            // 
            // amp50Label
            // 
            this.amp50Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.amp50Label.Location = new System.Drawing.Point(120, 24);
            this.amp50Label.Name = "amp50Label";
            this.amp50Label.Size = new System.Drawing.Size(88, 16);
            this.amp50Label.TabIndex = 1;
            this.amp50Label.Text = "50 % Amplitude:";
            // 
            // amp10Label
            // 
            this.amp10Label.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.amp10Label.Location = new System.Drawing.Point(224, 24);
            this.amp10Label.Name = "amp10Label";
            this.amp10Label.Size = new System.Drawing.Size(88, 16);
            this.amp10Label.TabIndex = 1;
            this.amp10Label.Text = "10 % Amplitude:";
            // 
            // baseValueLabel
            // 
            this.baseValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseValueLabel.Location = new System.Drawing.Point(120, 72);
            this.baseValueLabel.Name = "baseValueLabel";
            this.baseValueLabel.Size = new System.Drawing.Size(88, 16);
            this.baseValueLabel.TabIndex = 1;
            this.baseValueLabel.Text = "Base Value:";
            // 
            // topValueLabel
            // 
            this.topValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.topValueLabel.Location = new System.Drawing.Point(16, 72);
            this.topValueLabel.Name = "topValueLabel";
            this.topValueLabel.Size = new System.Drawing.Size(88, 16);
            this.topValueLabel.TabIndex = 1;
            this.topValueLabel.Text = "Top Value:";
            // 
            // overshootLabel
            // 
            this.overshootLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.overshootLabel.Location = new System.Drawing.Point(224, 72);
            this.overshootLabel.Name = "overshootLabel";
            this.overshootLabel.Size = new System.Drawing.Size(88, 16);
            this.overshootLabel.TabIndex = 1;
            this.overshootLabel.Text = "Overshoot:";
            // 
            // delayLabel
            // 
            this.delayLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delayLabel.Location = new System.Drawing.Point(120, 120);
            this.delayLabel.Name = "delayLabel";
            this.delayLabel.Size = new System.Drawing.Size(88, 16);
            this.delayLabel.TabIndex = 1;
            this.delayLabel.Text = "Delay:";
            // 
            // undershootLabel
            // 
            this.undershootLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.undershootLabel.Location = new System.Drawing.Point(16, 120);
            this.undershootLabel.Name = "undershootLabel";
            this.undershootLabel.Size = new System.Drawing.Size(88, 16);
            this.undershootLabel.TabIndex = 1;
            this.undershootLabel.Text = "Undershoot:";
            // 
            // widthLabel
            // 
            this.widthLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.widthLabel.Location = new System.Drawing.Point(224, 120);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(88, 16);
            this.widthLabel.TabIndex = 1;
            this.widthLabel.Text = "Width:";
            // 
            // fallTimeLabel
            // 
            this.fallTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fallTimeLabel.Location = new System.Drawing.Point(120, 168);
            this.fallTimeLabel.Name = "fallTimeLabel";
            this.fallTimeLabel.Size = new System.Drawing.Size(88, 16);
            this.fallTimeLabel.TabIndex = 1;
            this.fallTimeLabel.Text = "Fall Time:";
            // 
            // riseTimeLabel
            // 
            this.riseTimeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.riseTimeLabel.Location = new System.Drawing.Point(16, 168);
            this.riseTimeLabel.Name = "riseTimeLabel";
            this.riseTimeLabel.Size = new System.Drawing.Size(88, 16);
            this.riseTimeLabel.TabIndex = 1;
            this.riseTimeLabel.Text = "Rise Time:";
            // 
            // slewRateLabel
            // 
            this.slewRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.slewRateLabel.Location = new System.Drawing.Point(224, 168);
            this.slewRateLabel.Name = "slewRateLabel";
            this.slewRateLabel.Size = new System.Drawing.Size(88, 16);
            this.slewRateLabel.TabIndex = 1;
            this.slewRateLabel.Text = "Slew Rate:";
            // 
            // instructionTextBox
            // 
            this.instructionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.instructionTextBox.Location = new System.Drawing.Point(5, 4);
            this.instructionTextBox.Multiline = true;
            this.instructionTextBox.Name = "instructionTextBox";
            this.instructionTextBox.ReadOnly = true;
            this.instructionTextBox.Size = new System.Drawing.Size(472, 64);
            this.instructionTextBox.TabIndex = 20;
            this.instructionTextBox.TabStop = false;
            this.instructionTextBox.Text = "Step 1 - Click the Aquire button to start a recording.\r\nStep 2 - Create a pulse w" +
                "aveform by dragging the graph cursor from left to right. \r\nStep 3 - When you are" +
                " done, stop the acquisition by choosing the Analyze button";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(770, 376);
            this.Controls.Add(this.messageDisplayLabel);
            this.Controls.Add(this.pulseScatterGraph);
            this.Controls.Add(this.acquireButton);
            this.Controls.Add(this.analyzePulseButton);
            this.Controls.Add(this.demoButton);
            this.Controls.Add(this.outputParametersGroupBox);
            this.Controls.Add(this.instructionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pulse Analyzer";
            ((System.ComponentModel.ISupportInitialize)(this.pulseScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xyCursor)).EndInit();
            this.outputParametersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amp90NumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slewRateNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallTimeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riseTimeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataWidthNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.undershootNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overshootNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp10NumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amp50NumericEdit)).EndInit();
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

       
        // When the tick of timer occurs, the following function is evaluated.
        private void timer_Tick(object sender, System.EventArgs e)
        {
          // When the demo button is clicked and timer has ticked.
          if(demoClicked)
            {
                messageDisplayLabel.Visible = true;
                timer.Interval = 100; // Set timer interval as 100 mili seconds.
                pointPlot.LineStyle = LineStyle.None;
                pointPlot.PointStyle = PointStyle.SolidCircle;
                pointPlot.PointColor = System.Drawing.Color.White;
                // Bring the cursor to the current point that is being plotted.
                xyCursor.XPosition = (double)numOfTimerClick;
                xyCursor.YPosition = pulseWave[numOfTimerClick];
                // Plot point by point pulseWave.
                pointPlot.PlotXYAppend((double)numOfTimerClick, pulseWave[numOfTimerClick]);
                numOfTimerClick++;
                if(numOfTimerClick == 101)
                {                       
                    numOfTimerClick = 0;
                    timer.Enabled = false; // Disable the timer.
                    pointPlot.LineStyle = LineStyle.Solid;
                    pointPlot.LineColor = System.Drawing.Color.Tomato;
                    xyCursor.XPosition = 0;
                    xyCursor.YPosition = 5;
                    // Plot continuous pulse waveform.
                    pointPlot.PlotXY(xWave, pulseWave);
                    PerformAnalysis(pulseWave);
                    demoClicked = false; // Make it zero as the demo is finished.
					messageDisplayLabel.Visible = false;
                }
           }
            // When the acquire button is clicked and timer has ticked.
            if(acquireClicked)
            {
                messageDisplayLabel.Visible = false;
                timer.Interval = 20; // Set timer interval as 10 mili seconds.
                xPosition[counter] = xyCursor.XPosition; // Store cursor x position. 
                pulseWave[counter] = xyCursor.YPosition; // Store cursor y position.
                
                pointPlot.LineStyle = LineStyle.None;
                pointPlot.PointStyle = PointStyle.SolidCircle;
                pointPlot.PointColor = System.Drawing.Color.White;
                // Plot the points of pulse.
                pointPlot.PlotXYAppend(xyCursor.XPosition, xyCursor.YPosition);
                counter++; // Increment the counter. 
                // If xPosition and pulseWave array gets full, start filling it from zero, but it will result
                // in the loss of previous data. 
                if(counter == 1000)
                    counter = 0;
            }
        }

        // On click of Demo Button.
        private void demoButton_Click(object sender, System.EventArgs e)
        {
            int i;
            double []upRamp = new double[5];
            double []downRamp = new double[5];
            double []noise = new double[101];
            pulseWave = new double[101];
            xWave = new double[101];
            
            downRamp.Initialize();
            timer.Enabled = false; // disable the timer.
            pulseScatterGraph.ClearData(); // clear graph.
            //xyCursor.Visible = false; //remove cursor.
            numOfTimerClick = 0; 
           
            // Message displayed in the text box placed over the graph.
            messageDisplayLabel.Visible = true;
            
            // Status of buttons.
            demoClicked = true;
            acquireClicked = false;
            
            // Generate an UpRamp of size 5.
            upRamp = PatternGeneration.Ramp(5, 0, 45) ;
            // Generate a downRamp of size 5.
            downRamp = PatternGeneration.Ramp(5, 45, 0) ;
            // Generation of White Noise.
            WhiteNoiseSignal whiteNoise = new WhiteNoiseSignal(1.0);
            noise = whiteNoise.Generate(10000, 101);

            // Generation of Noisy Pulse wave.
            for(i=0; i < 5; i++)
            {
                pulseWave[5 + i] = upRamp[i];
                pulseWave[10 + i] = 45;
                pulseWave[15 + i] = downRamp[i];
            }
            for (i=0; i<101; i++)
            {
                pulseWave[i] = pulseWave[i] + noise[i]; 
                xWave[i] = i;
            }
            // Start the timer.
            timer.Start();
            
        }
        
        // On click of Acquire button.
        private void acquire_Click(object sender, System.EventArgs e)
        {
            // Status of buttons.
            acquireClicked = true;
            demoClicked = false;

            // Make the counter zero.
            counter = 0;
            pulseWave = new double[1001]; 
            xPosition = new double[1001];
            
            // Cursor is visible on the Graph.
            xyCursor.Visible = true;
            // Initial position of the cursor.
            xyCursor.XPosition = 0;
            xyCursor.YPosition = 5;
            
            analyzePulseButton.Enabled = true; // Enable Stop Acquire Button.
            pulseScatterGraph.ClearData();         
            timer.Start(); // Start the timer.
        }

        // On click of Analyze Pulse button
        private void analyzePulse_Click(object sender, System.EventArgs e)
        {
            int i;

            timer.Stop(); 

            // Status of buttons on the panel.
            demoClicked = false;
            acquireClicked = false;

            // Allocate memory to store data points of pulse wave drawn by user.
            double []xPulse = new double[counter]; 
            double []yPulse = new double[counter];
            
            // Store the xPosition and pulseWave in to xPulse and yPulse arrays.
            for(i=0; i < counter; i++)
            {
                xPulse[i] = xPosition[i];
                yPulse[i] = pulseWave[i];
            }
            pointPlot.LineStyle = LineStyle.Solid;
            pointPlot.LineColor = System.Drawing.Color.Tomato;
            // Plot the continuous pulse wave.
            pointPlot.PlotXY(xPulse, yPulse);
            counter = 0; // Set counter equal to zero for the next acquiring of pulse wave.
            PerformAnalysis(yPulse); // analyze the pulse and display data.
            analyzePulseButton.Enabled = false; 
        }

        // Analyzes the pulse wave that has been drawn by user.
        void PerformAnalysis(double []yWave)
        {          
            double amplitude90Percent, amplitude50Percent, amplitude10Percent;
            double topVal, baseVal, overshootVal, undershootVal, slewRateVal;
            int delayVal, widthVal, riseTimeVal, fallTimeVal;

            // Pulse parameters are being returned by the following function.
            SignalProcessing.PulseParameters(yWave, out amplitude90Percent,
                out amplitude50Percent, out amplitude10Percent, out topVal, out baseVal,
                out overshootVal, out undershootVal, out delayVal, out widthVal, out riseTimeVal, out fallTimeVal,
                out slewRateVal);
            
            // Display the data in the text boxes.
            amp90NumericEdit.Value= amplitude90Percent;
            amp50NumericEdit.Value = amplitude50Percent;
            amp10NumericEdit.Value = amplitude10Percent;
            topValueNumericEdit.Value = topVal;
            baseValueNumericEdit.Value = baseVal;
            overshootNumericEdit.Value = overshootVal;
            undershootNumericEdit.Value = undershootVal;
            delayNumericEdit.Value = delayVal;
            dataWidthNumericEdit.Value = widthVal;
            riseTimeNumericEdit.Value = riseTimeVal;
            fallTimeNumericEdit.Value = fallTimeVal;
            slewRateNumericEdit.Value = slewRateVal;
        }
    }
}
