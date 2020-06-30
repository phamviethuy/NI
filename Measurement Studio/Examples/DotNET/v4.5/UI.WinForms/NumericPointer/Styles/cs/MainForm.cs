using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Styles
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.Knob raisedWithThumb3DKnob;
        private NationalInstruments.UI.WindowsForms.Knob raisedWithThumbKnob;
        private NationalInstruments.UI.WindowsForms.Knob raisedWithThinNeedle3DKnob;
        private NationalInstruments.UI.WindowsForms.Knob raisedWithThinNeedleKnob;
        private NationalInstruments.UI.WindowsForms.Knob flatWithThinNeedleKnob;
        private NationalInstruments.UI.WindowsForms.Meter flatWithThinNeedleMeter;
        private NationalInstruments.UI.WindowsForms.Meter raisedWithThinNeedleMeter;
        private NationalInstruments.UI.WindowsForms.Meter raisedWithThickNeedleMeter;
        private NationalInstruments.UI.WindowsForms.Meter flatWithThickNeedleMeter;
        private NationalInstruments.UI.WindowsForms.Gauge sunkenWithThinNeedle3DGauge;
        private NationalInstruments.UI.WindowsForms.Gauge sunkenWithThinNeedleGauge;
        private NationalInstruments.UI.WindowsForms.Gauge sunkenWithThickNeedle3DGauge;
        private NationalInstruments.UI.WindowsForms.Gauge sunkenWithThickNeedleGauge;
        private NationalInstruments.UI.WindowsForms.Gauge flatWithThinNeedleGauge;
        private NationalInstruments.UI.WindowsForms.Gauge flatWithThickNeedleGauge;
        private NationalInstruments.UI.WindowsForms.Tank raised3DHorizontalTank;
        private NationalInstruments.UI.WindowsForms.Tank raisedHorizontalTank;
        private NationalInstruments.UI.WindowsForms.Tank flatHorizontalTank;
        private NationalInstruments.UI.WindowsForms.Tank raised3DVerticalTank;
        private NationalInstruments.UI.WindowsForms.Tank raisedVerticalTank;
        private NationalInstruments.UI.WindowsForms.Tank flatVerticalTank;
        private NationalInstruments.UI.WindowsForms.Slide raisedWithRoundedGrip3DHorizontalSlide;
        private NationalInstruments.UI.WindowsForms.Slide raisedWithRoundedGripHorizontalSlide;
        private NationalInstruments.UI.WindowsForms.Slide sunkenWithGripHorizontalSlide;
        private NationalInstruments.UI.WindowsForms.Slide raisedWithRoundedGrip3DVerticalSlide;
        private NationalInstruments.UI.WindowsForms.Slide raisedWithRoundedGripVerticalSlide;
        private NationalInstruments.UI.WindowsForms.Slide sunkenWithGripVerticalSlide;
        private System.Windows.Forms.Timer sampleTimer;
        private NationalInstruments.UI.WindowsForms.Thermometer raised3DHorizontalThermometer;
        private NationalInstruments.UI.WindowsForms.Thermometer raisedHorizontalThermometer;
        private NationalInstruments.UI.WindowsForms.Thermometer flatHorizontalThermometer;
        private NationalInstruments.UI.WindowsForms.Thermometer raised3DVerticalThermometer;
        private NationalInstruments.UI.WindowsForms.Thermometer raisedVerticalThermometer;
        private NationalInstruments.UI.WindowsForms.Thermometer flatVerticalThermometer;
        private System.Windows.Forms.TabPage knobTabPage;
        private System.Windows.Forms.TabPage meterTabPage;
        private System.Windows.Forms.TabPage gaugeTabPage;
        private System.Windows.Forms.TabPage tankTabPage;
        private System.Windows.Forms.TabPage slideTabPage;
        private System.Windows.Forms.TabPage thermometerTabPage;
        private System.Windows.Forms.TabControl stylesTabControl;
        private System.ComponentModel.IContainer components;
        private bool raisedWithThickNeedleMeterValueIncreasing = true;
        private bool raisedWithThinNeedleMeterValueIncreasing = true;
        private bool flatWithThickNeedleMeterValueIncreasing = true;
        private bool flatWithThinNeedleMeterValueIncreasing = true;
        private bool flatWithThinNeedleKnobValueIncreasing = true;
        private bool flatWithThickNeedleGaugeValueIncreasing = true;
        private bool sunkenWithThickNeedleGaugeValueIncreasing = true;
        private bool sunkenWithThinNeedleGaugeValueIncreasing = true;
        private bool raisedVerticalTankValueIncreasing = true;
        private bool flatHorizontalTankValueIncreasing = true;
        private bool raised3DHorizontalTankValueIncreasing = true;
        private bool sunkenWithGripVerticalSlideValueIncreasing = true;
        private bool flatVerticalThermometerValueIncreasing = true;
        private bool raised3DVerticalThermometerValueIncreasing = true;
        private bool raisedHorizontalThermometerValueIncreasing = true;
        private bool raised3DHorizontalThermometerValueIncreasing = true;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithThumb3DNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithThumbNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithThinNeedle3DNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatWithThinNeedleNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatWithThinNeedleMeterNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatWithThickNeedleMeterNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithThinNeedleNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithThickNeedleNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatWithThickNeedleNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatWithThinNeedleGaugeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit sunkenWithThickNeedle3DNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit sunkenWithThinNeedle3DNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit sunkenWithThinNeedleGaugeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit sunkenWithThickNeedleNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedVerticalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatHorizontalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatVerticalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raised3dVerticalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedHorizontalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit sunkenWithGripVerticalSlideNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithRoundedGripVerticalSlideNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithRoundedGrip3DVerticalSlideNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit sunkenWithGripHorizontalSlideNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithRoundedGripHorizontalSlideNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedWithRoundedGrip3DHorizontalSlideNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raised3DHorizontalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatVerticalThermometerNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raised3DVerticalThermometerNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedHorizontalThermometerNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raised3DHorizontalThermometerNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit raisedVerticalThermometerNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit flatHorizontalThermometerNumericEdit;
        

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
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision1 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision2 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision3 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision4 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision5 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill1 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision6 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision7 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill2 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision8 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill3 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision9 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill4 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill5 = new NationalInstruments.UI.ScaleRangeFill();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.stylesTabControl = new System.Windows.Forms.TabControl();
            this.knobTabPage = new System.Windows.Forms.TabPage();
            this.raisedWithThumb3DNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithThumb3DKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.raisedWithThumbNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithThumbKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.raisedWithThinNeedle3DNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithThinNeedle3DKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.flatWithThinNeedleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatWithThinNeedleKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.raisedWithThinNeedleKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.meterTabPage = new System.Windows.Forms.TabPage();
            this.flatWithThinNeedleMeterNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatWithThinNeedleMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.flatWithThickNeedleMeterNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatWithThickNeedleMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.raisedWithThinNeedleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithThinNeedleMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.raisedWithThickNeedleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithThickNeedleMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.gaugeTabPage = new System.Windows.Forms.TabPage();
            this.sunkenWithThickNeedleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.sunkenWithThickNeedleGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.sunkenWithThinNeedleGaugeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.sunkenWithThinNeedleGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.sunkenWithThinNeedle3DNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.sunkenWithThinNeedle3DGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.sunkenWithThickNeedle3DNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.sunkenWithThickNeedle3DGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.flatWithThinNeedleGaugeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatWithThinNeedleGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.flatWithThickNeedleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatWithThickNeedleGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.tankTabPage = new System.Windows.Forms.TabPage();
            this.raised3DHorizontalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raised3DHorizontalTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.raisedHorizontalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedHorizontalTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.raised3dVerticalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raised3DVerticalTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.flatVerticalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatVerticalTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.flatHorizontalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatHorizontalTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.raisedVerticalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedVerticalTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.slideTabPage = new System.Windows.Forms.TabPage();
            this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithRoundedGrip3DHorizontalSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.raisedWithRoundedGripHorizontalSlideNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithRoundedGripHorizontalSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.sunkenWithGripHorizontalSlideNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.sunkenWithGripHorizontalSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.raisedWithRoundedGrip3DVerticalSlideNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithRoundedGrip3DVerticalSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.raisedWithRoundedGripVerticalSlideNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedWithRoundedGripVerticalSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.sunkenWithGripVerticalSlideNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.sunkenWithGripVerticalSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.thermometerTabPage = new System.Windows.Forms.TabPage();
            this.flatHorizontalThermometerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatHorizontalThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.raisedVerticalThermometerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedVerticalThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.raised3DHorizontalThermometerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raised3DHorizontalThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.raisedHorizontalThermometerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raisedHorizontalThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.raised3DVerticalThermometerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.raised3DVerticalThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.flatVerticalThermometerNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.flatVerticalThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.sampleTimer = new System.Windows.Forms.Timer(this.components);
            this.stylesTabControl.SuspendLayout();
            this.knobTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumb3DNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumb3DKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumbNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumbKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedle3DNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedle3DKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedleKnob)).BeginInit();
            this.meterTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleMeterNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleMeterNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedleMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThickNeedleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThickNeedleMeter)).BeginInit();
            this.gaugeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedleGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedleGaugeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedleGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedle3DNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedle3DGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedle3DNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedle3DGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleGaugeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleGauge)).BeginInit();
            this.tankTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3dVerticalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DVerticalTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalTank)).BeginInit();
            this.slideTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DHorizontalSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripHorizontalSlideNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripHorizontalSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripHorizontalSlideNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripHorizontalSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DVerticalSlideNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DVerticalSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripVerticalSlideNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripVerticalSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripVerticalSlideNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripVerticalSlide)).BeginInit();
            this.thermometerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalThermometerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalThermometerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalThermometerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalThermometerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DVerticalThermometerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DVerticalThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalThermometerNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalThermometer)).BeginInit();
            this.SuspendLayout();
            // 
            // stylesTabControl
            // 
            this.stylesTabControl.Controls.Add(this.knobTabPage);
            this.stylesTabControl.Controls.Add(this.meterTabPage);
            this.stylesTabControl.Controls.Add(this.gaugeTabPage);
            this.stylesTabControl.Controls.Add(this.tankTabPage);
            this.stylesTabControl.Controls.Add(this.slideTabPage);
            this.stylesTabControl.Controls.Add(this.thermometerTabPage);
            this.stylesTabControl.Location = new System.Drawing.Point(0, 0);
            this.stylesTabControl.Name = "stylesTabControl";
            this.stylesTabControl.SelectedIndex = 0;
            this.stylesTabControl.Size = new System.Drawing.Size(632, 472);
            this.stylesTabControl.TabIndex = 0;
            // 
            // knobTabPage
            // 
            this.knobTabPage.Controls.Add(this.raisedWithThumb3DNumericEdit);
            this.knobTabPage.Controls.Add(this.raisedWithThumbNumericEdit);
            this.knobTabPage.Controls.Add(this.raisedWithThinNeedle3DNumericEdit);
            this.knobTabPage.Controls.Add(this.flatWithThinNeedleNumericEdit);
            this.knobTabPage.Controls.Add(this.raisedWithThumb3DKnob);
            this.knobTabPage.Controls.Add(this.raisedWithThumbKnob);
            this.knobTabPage.Controls.Add(this.raisedWithThinNeedle3DKnob);
            this.knobTabPage.Controls.Add(this.raisedWithThinNeedleKnob);
            this.knobTabPage.Controls.Add(this.flatWithThinNeedleKnob);
            this.knobTabPage.Location = new System.Drawing.Point(4, 22);
            this.knobTabPage.Name = "knobTabPage";
            this.knobTabPage.Size = new System.Drawing.Size(624, 446);
            this.knobTabPage.TabIndex = 0;
            this.knobTabPage.Text = "Knob";
            // 
            // raisedWithThumb3DNumericEdit
            // 
            this.raisedWithThumb3DNumericEdit.Location = new System.Drawing.Point(216, 408);
            this.raisedWithThumb3DNumericEdit.Name = "raisedWithThumb3DNumericEdit";
            this.raisedWithThumb3DNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithThumb3DNumericEdit.Source = this.raisedWithThumb3DKnob;
            this.raisedWithThumb3DNumericEdit.TabIndex = 9;
            this.raisedWithThumb3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithThumb3DKnob
            // 
            this.raisedWithThumb3DKnob.AutoDivisionSpacing = false;
            this.raisedWithThumb3DKnob.Caption = "RaisedWithThumb3D";
            this.raisedWithThumb3DKnob.Location = new System.Drawing.Point(184, 232);
            this.raisedWithThumb3DKnob.Name = "raisedWithThumb3DKnob";
            this.raisedWithThumb3DKnob.Range = new NationalInstruments.UI.Range(0, 500);
            this.raisedWithThumb3DKnob.Size = new System.Drawing.Size(176, 176);
            this.raisedWithThumb3DKnob.TabIndex = 4;
            this.raisedWithThumb3DKnob.Value = 0.001;
            // 
            // raisedWithThumbNumericEdit
            // 
            this.raisedWithThumbNumericEdit.Location = new System.Drawing.Point(32, 408);
            this.raisedWithThumbNumericEdit.Name = "raisedWithThumbNumericEdit";
            this.raisedWithThumbNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithThumbNumericEdit.Source = this.raisedWithThumbKnob;
            this.raisedWithThumbNumericEdit.TabIndex = 8;
            this.raisedWithThumbNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithThumbKnob
            // 
            this.raisedWithThumbKnob.Caption = "RaisedWithThumb";
            this.raisedWithThumbKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThumb;
            this.raisedWithThumbKnob.Location = new System.Drawing.Point(0, 232);
            this.raisedWithThumbKnob.Name = "raisedWithThumbKnob";
            this.raisedWithThumbKnob.PointerColor = System.Drawing.SystemColors.ControlDark;
            this.raisedWithThumbKnob.Range = new NationalInstruments.UI.Range(0, 100);
            this.raisedWithThumbKnob.ScaleArc = new NationalInstruments.UI.Arc(121F, 299F);
            this.raisedWithThumbKnob.Size = new System.Drawing.Size(176, 176);
            this.raisedWithThumbKnob.TabIndex = 3;
            // 
            // raisedWithThinNeedle3DNumericEdit
            // 
            this.raisedWithThinNeedle3DNumericEdit.Location = new System.Drawing.Point(448, 192);
            this.raisedWithThinNeedle3DNumericEdit.Name = "raisedWithThinNeedle3DNumericEdit";
            this.raisedWithThinNeedle3DNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithThinNeedle3DNumericEdit.Source = this.raisedWithThinNeedle3DKnob;
            this.raisedWithThinNeedle3DNumericEdit.TabIndex = 7;
            this.raisedWithThinNeedle3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithThinNeedle3DKnob
            // 
            this.raisedWithThinNeedle3DKnob.AutoDivisionSpacing = false;
            this.raisedWithThinNeedle3DKnob.Caption = "RaisedWithThinNeedle3D";
            this.raisedWithThinNeedle3DKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle3D;
            this.raisedWithThinNeedle3DKnob.Location = new System.Drawing.Point(384, 23);
            this.raisedWithThinNeedle3DKnob.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S\'V\'");
            this.raisedWithThinNeedle3DKnob.Name = "raisedWithThinNeedle3DKnob";
            this.raisedWithThinNeedle3DKnob.PointerColor = System.Drawing.SystemColors.WindowText;
            this.raisedWithThinNeedle3DKnob.Range = new NationalInstruments.UI.Range(0, 10000);
            this.raisedWithThinNeedle3DKnob.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.raisedWithThinNeedle3DKnob.Size = new System.Drawing.Size(240, 168);
            this.raisedWithThinNeedle3DKnob.TabIndex = 2;
            // 
            // flatWithThinNeedleNumericEdit
            // 
            this.flatWithThinNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.flatWithThinNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.flatWithThinNeedleNumericEdit.Location = new System.Drawing.Point(40, 192);
            this.flatWithThinNeedleNumericEdit.Name = "flatWithThinNeedleNumericEdit";
            this.flatWithThinNeedleNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatWithThinNeedleNumericEdit.Source = this.flatWithThinNeedleKnob;
            this.flatWithThinNeedleNumericEdit.TabIndex = 5;
            this.flatWithThinNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatWithThinNeedleKnob
            // 
            this.flatWithThinNeedleKnob.Caption = "FlatWithThinNeedle";
            this.flatWithThinNeedleKnob.DialColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.flatWithThinNeedleKnob.InteractionMode = NationalInstruments.UI.RadialNumericPointerInteractionModes.Indicator;
            this.flatWithThinNeedleKnob.KnobStyle = NationalInstruments.UI.KnobStyle.FlatWithThinNeedle;
            this.flatWithThinNeedleKnob.Location = new System.Drawing.Point(0, 23);
            this.flatWithThinNeedleKnob.Name = "flatWithThinNeedleKnob";
            this.flatWithThinNeedleKnob.PointerColor = System.Drawing.SystemColors.WindowText;
            this.flatWithThinNeedleKnob.Size = new System.Drawing.Size(176, 160);
            this.flatWithThinNeedleKnob.TabIndex = 0;
            // 
            // raisedWithThinNeedleKnob
            // 
            this.raisedWithThinNeedleKnob.Caption = "RaisedWithThinNeedle";
            this.raisedWithThinNeedleKnob.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions;
            scaleCustomDivision1.LineWidth = 2F;
            scaleCustomDivision1.Text = "Start";
            scaleCustomDivision1.TickLength = 7F;
            scaleCustomDivision2.LineWidth = 2F;
            scaleCustomDivision2.Text = "Acquire";
            scaleCustomDivision2.TickLength = 7F;
            scaleCustomDivision2.Value = 2.5;
            scaleCustomDivision3.LineWidth = 2F;
            scaleCustomDivision3.Text = "Stop";
            scaleCustomDivision3.TickLength = 7F;
            scaleCustomDivision3.Value = 5;
            scaleCustomDivision4.LineWidth = 2F;
            scaleCustomDivision4.Text = "Analyze";
            scaleCustomDivision4.TickLength = 7F;
            scaleCustomDivision4.Value = 7.5;
            scaleCustomDivision5.LineWidth = 2F;
            scaleCustomDivision5.Text = "Display";
            scaleCustomDivision5.TickLength = 7F;
            scaleCustomDivision5.Value = 10;
            this.raisedWithThinNeedleKnob.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
            scaleCustomDivision1,
            scaleCustomDivision2,
            scaleCustomDivision3,
            scaleCustomDivision4,
            scaleCustomDivision5});
            this.raisedWithThinNeedleKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle;
            this.raisedWithThinNeedleKnob.Location = new System.Drawing.Point(184, 23);
            this.raisedWithThinNeedleKnob.MajorDivisions.LabelVisible = false;
            this.raisedWithThinNeedleKnob.MajorDivisions.TickVisible = false;
            this.raisedWithThinNeedleKnob.MinorDivisions.TickVisible = false;
            this.raisedWithThinNeedleKnob.Name = "raisedWithThinNeedleKnob";
            this.raisedWithThinNeedleKnob.PointerColor = System.Drawing.SystemColors.WindowText;
            scaleRangeFill1.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateGradientStyle(System.Drawing.Color.Green, System.Drawing.Color.Yellow, 0.5);
            this.raisedWithThinNeedleKnob.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
            scaleRangeFill1});
            this.raisedWithThinNeedleKnob.Size = new System.Drawing.Size(192, 168);
            this.raisedWithThinNeedleKnob.TabIndex = 1;
            // 
            // meterTabPage
            // 
            this.meterTabPage.Controls.Add(this.flatWithThinNeedleMeterNumericEdit);
            this.meterTabPage.Controls.Add(this.flatWithThickNeedleMeterNumericEdit);
            this.meterTabPage.Controls.Add(this.raisedWithThinNeedleNumericEdit);
            this.meterTabPage.Controls.Add(this.raisedWithThickNeedleNumericEdit);
            this.meterTabPage.Controls.Add(this.flatWithThinNeedleMeter);
            this.meterTabPage.Controls.Add(this.raisedWithThinNeedleMeter);
            this.meterTabPage.Controls.Add(this.raisedWithThickNeedleMeter);
            this.meterTabPage.Controls.Add(this.flatWithThickNeedleMeter);
            this.meterTabPage.Location = new System.Drawing.Point(4, 22);
            this.meterTabPage.Name = "meterTabPage";
            this.meterTabPage.Size = new System.Drawing.Size(624, 446);
            this.meterTabPage.TabIndex = 1;
            this.meterTabPage.Text = "Meter";
            // 
            // flatWithThinNeedleMeterNumericEdit
            // 
            this.flatWithThinNeedleMeterNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.flatWithThinNeedleMeterNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.flatWithThinNeedleMeterNumericEdit.Location = new System.Drawing.Point(440, 400);
            this.flatWithThinNeedleMeterNumericEdit.Name = "flatWithThinNeedleMeterNumericEdit";
            this.flatWithThinNeedleMeterNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatWithThinNeedleMeterNumericEdit.Source = this.flatWithThinNeedleMeter;
            this.flatWithThinNeedleMeterNumericEdit.TabIndex = 9;
            this.flatWithThinNeedleMeterNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatWithThinNeedleMeter
            // 
            this.flatWithThinNeedleMeter.AutoDivisionSpacing = false;
            this.flatWithThinNeedleMeter.Caption = "FlatWithThinNeedle";
            this.flatWithThinNeedleMeter.Location = new System.Drawing.Point(368, 232);
            this.flatWithThinNeedleMeter.MeterStyle = NationalInstruments.UI.MeterStyle.FlatWithThinNeedle;
            this.flatWithThinNeedleMeter.Name = "flatWithThinNeedleMeter";
            this.flatWithThinNeedleMeter.PointerColor = System.Drawing.SystemColors.InactiveCaption;
            this.flatWithThinNeedleMeter.Range = new NationalInstruments.UI.Range(0, 1000);
            this.flatWithThinNeedleMeter.ScaleArc = new NationalInstruments.UI.Arc(225F, 90F);
            this.flatWithThinNeedleMeter.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.flatWithThinNeedleMeter.Size = new System.Drawing.Size(240, 168);
            this.flatWithThinNeedleMeter.TabIndex = 1;
            // 
            // flatWithThickNeedleMeterNumericEdit
            // 
            this.flatWithThickNeedleMeterNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.flatWithThickNeedleMeterNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.flatWithThickNeedleMeterNumericEdit.Location = new System.Drawing.Point(440, 187);
            this.flatWithThickNeedleMeterNumericEdit.Name = "flatWithThickNeedleMeterNumericEdit";
            this.flatWithThickNeedleMeterNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatWithThickNeedleMeterNumericEdit.Source = this.flatWithThickNeedleMeter;
            this.flatWithThickNeedleMeterNumericEdit.TabIndex = 8;
            this.flatWithThickNeedleMeterNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatWithThickNeedleMeter
            // 
            this.flatWithThickNeedleMeter.Caption = "FlatWithThickNeedle";
            this.flatWithThickNeedleMeter.Location = new System.Drawing.Point(368, 23);
            this.flatWithThickNeedleMeter.MeterStyle = NationalInstruments.UI.MeterStyle.FlatWithThickNeedle;
            this.flatWithThickNeedleMeter.Name = "flatWithThickNeedleMeter";
            this.flatWithThickNeedleMeter.ScaleBaseLineColor = System.Drawing.SystemColors.Highlight;
            this.flatWithThickNeedleMeter.Size = new System.Drawing.Size(232, 168);
            this.flatWithThickNeedleMeter.SpindleColor = System.Drawing.SystemColors.Desktop;
            this.flatWithThickNeedleMeter.TabIndex = 0;
            // 
            // raisedWithThinNeedleNumericEdit
            // 
            this.raisedWithThinNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.raisedWithThinNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.raisedWithThinNeedleNumericEdit.Location = new System.Drawing.Point(224, 312);
            this.raisedWithThinNeedleNumericEdit.Name = "raisedWithThinNeedleNumericEdit";
            this.raisedWithThinNeedleNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithThinNeedleNumericEdit.Source = this.raisedWithThinNeedleMeter;
            this.raisedWithThinNeedleNumericEdit.TabIndex = 7;
            this.raisedWithThinNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithThinNeedleMeter
            // 
            this.raisedWithThinNeedleMeter.AutoDivisionSpacing = false;
            this.raisedWithThinNeedleMeter.Caption = "RaisedWithThinNeedle";
            this.raisedWithThinNeedleMeter.Location = new System.Drawing.Point(208, 23);
            this.raisedWithThinNeedleMeter.MajorDivisions.Interval = 50;
            this.raisedWithThinNeedleMeter.MeterStyle = NationalInstruments.UI.MeterStyle.RaisedWithThinNeedle;
            this.raisedWithThinNeedleMeter.MinorDivisions.Interval = 25;
            this.raisedWithThinNeedleMeter.Name = "raisedWithThinNeedleMeter";
            this.raisedWithThinNeedleMeter.Range = new NationalInstruments.UI.Range(-100, 100);
            this.raisedWithThinNeedleMeter.ScaleArc = new NationalInstruments.UI.Arc(315F, 90F);
            this.raisedWithThinNeedleMeter.Size = new System.Drawing.Size(136, 296);
            this.raisedWithThinNeedleMeter.SpindleColor = System.Drawing.SystemColors.ActiveCaption;
            this.raisedWithThinNeedleMeter.TabIndex = 3;
            // 
            // raisedWithThickNeedleNumericEdit
            // 
            this.raisedWithThickNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.raisedWithThickNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.raisedWithThickNeedleNumericEdit.Location = new System.Drawing.Point(56, 312);
            this.raisedWithThickNeedleNumericEdit.Name = "raisedWithThickNeedleNumericEdit";
            this.raisedWithThickNeedleNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithThickNeedleNumericEdit.Source = this.raisedWithThickNeedleMeter;
            this.raisedWithThickNeedleNumericEdit.TabIndex = 6;
            this.raisedWithThickNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithThickNeedleMeter
            // 
            this.raisedWithThickNeedleMeter.AutoDivisionSpacing = false;
            this.raisedWithThickNeedleMeter.Caption = "RaisedWithThickNeedle";
            scaleCustomDivision6.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scaleCustomDivision6.LabelForeColor = System.Drawing.Color.Red;
            scaleCustomDivision6.LineWidth = 2F;
            scaleCustomDivision6.Text = "HOT";
            scaleCustomDivision6.TickLength = 10F;
            scaleCustomDivision6.Value = 90;
            scaleCustomDivision7.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scaleCustomDivision7.LabelForeColor = System.Drawing.Color.Blue;
            scaleCustomDivision7.LineWidth = 2F;
            scaleCustomDivision7.Text = "COLD";
            scaleCustomDivision7.TickColor = System.Drawing.Color.Blue;
            scaleCustomDivision7.TickLength = 10F;
            scaleCustomDivision7.Value = 10;
            this.raisedWithThickNeedleMeter.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
            scaleCustomDivision6,
            scaleCustomDivision7});
            this.raisedWithThickNeedleMeter.Location = new System.Drawing.Point(24, 23);
            this.raisedWithThickNeedleMeter.Name = "raisedWithThickNeedleMeter";
            this.raisedWithThickNeedleMeter.Range = new NationalInstruments.UI.Range(0, 100);
            scaleRangeFill2.Range = new NationalInstruments.UI.Range(10, 90);
            scaleRangeFill2.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateGradientStyle(System.Drawing.Color.Blue, System.Drawing.Color.Red, 0.5);
            this.raisedWithThickNeedleMeter.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
            scaleRangeFill2});
            this.raisedWithThickNeedleMeter.ScaleArc = new NationalInstruments.UI.Arc(225F, -90F);
            this.raisedWithThickNeedleMeter.Size = new System.Drawing.Size(168, 288);
            this.raisedWithThickNeedleMeter.TabIndex = 2;
            // 
            // gaugeTabPage
            // 
            this.gaugeTabPage.Controls.Add(this.sunkenWithThickNeedleNumericEdit);
            this.gaugeTabPage.Controls.Add(this.sunkenWithThinNeedleGaugeNumericEdit);
            this.gaugeTabPage.Controls.Add(this.sunkenWithThinNeedle3DNumericEdit);
            this.gaugeTabPage.Controls.Add(this.sunkenWithThickNeedle3DNumericEdit);
            this.gaugeTabPage.Controls.Add(this.flatWithThinNeedleGaugeNumericEdit);
            this.gaugeTabPage.Controls.Add(this.flatWithThickNeedleNumericEdit);
            this.gaugeTabPage.Controls.Add(this.sunkenWithThinNeedle3DGauge);
            this.gaugeTabPage.Controls.Add(this.sunkenWithThinNeedleGauge);
            this.gaugeTabPage.Controls.Add(this.sunkenWithThickNeedle3DGauge);
            this.gaugeTabPage.Controls.Add(this.sunkenWithThickNeedleGauge);
            this.gaugeTabPage.Controls.Add(this.flatWithThinNeedleGauge);
            this.gaugeTabPage.Controls.Add(this.flatWithThickNeedleGauge);
            this.gaugeTabPage.Location = new System.Drawing.Point(4, 22);
            this.gaugeTabPage.Name = "gaugeTabPage";
            this.gaugeTabPage.Size = new System.Drawing.Size(624, 446);
            this.gaugeTabPage.TabIndex = 2;
            this.gaugeTabPage.Text = "Gauge";
            // 
            // sunkenWithThickNeedleNumericEdit
            // 
            this.sunkenWithThickNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.sunkenWithThickNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.sunkenWithThickNeedleNumericEdit.Location = new System.Drawing.Point(444, 192);
            this.sunkenWithThickNeedleNumericEdit.Name = "sunkenWithThickNeedleNumericEdit";
            this.sunkenWithThickNeedleNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.sunkenWithThickNeedleNumericEdit.Source = this.sunkenWithThickNeedleGauge;
            this.sunkenWithThickNeedleNumericEdit.TabIndex = 13;
            this.sunkenWithThickNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // sunkenWithThickNeedleGauge
            // 
            this.sunkenWithThickNeedleGauge.Caption = "SunkenWithThickNeedle";
            this.sunkenWithThickNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThickNeedle;
            this.sunkenWithThickNeedleGauge.Location = new System.Drawing.Point(424, 31);
            this.sunkenWithThickNeedleGauge.MajorDivisions.LabelForeColor = System.Drawing.Color.Red;
            this.sunkenWithThickNeedleGauge.Name = "sunkenWithThickNeedleGauge";
            this.sunkenWithThickNeedleGauge.ScaleArc = new NationalInstruments.UI.Arc(121F, 299F);
            this.sunkenWithThickNeedleGauge.Size = new System.Drawing.Size(160, 160);
            this.sunkenWithThickNeedleGauge.TabIndex = 2;
            // 
            // sunkenWithThinNeedleGaugeNumericEdit
            // 
            this.sunkenWithThinNeedleGaugeNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.sunkenWithThinNeedleGaugeNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.sunkenWithThinNeedleGaugeNumericEdit.Location = new System.Drawing.Point(236, 400);
            this.sunkenWithThinNeedleGaugeNumericEdit.Name = "sunkenWithThinNeedleGaugeNumericEdit";
            this.sunkenWithThinNeedleGaugeNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.sunkenWithThinNeedleGaugeNumericEdit.Source = this.sunkenWithThinNeedleGauge;
            this.sunkenWithThinNeedleGaugeNumericEdit.TabIndex = 12;
            this.sunkenWithThinNeedleGaugeNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // sunkenWithThinNeedleGauge
            // 
            this.sunkenWithThinNeedleGauge.Caption = "SunkenWithThinNeedle";
            this.sunkenWithThinNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThinNeedle;
            this.sunkenWithThinNeedleGauge.Location = new System.Drawing.Point(224, 240);
            this.sunkenWithThinNeedleGauge.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0.###\'%\'");
            this.sunkenWithThinNeedleGauge.Name = "sunkenWithThinNeedleGauge";
            this.sunkenWithThinNeedleGauge.Range = new NationalInstruments.UI.Range(0, 100);
            this.sunkenWithThinNeedleGauge.Size = new System.Drawing.Size(160, 160);
            this.sunkenWithThinNeedleGauge.SpindleColor = System.Drawing.Color.Red;
            this.sunkenWithThinNeedleGauge.TabIndex = 4;
            // 
            // sunkenWithThinNeedle3DNumericEdit
            // 
            this.sunkenWithThinNeedle3DNumericEdit.Location = new System.Drawing.Point(452, 400);
            this.sunkenWithThinNeedle3DNumericEdit.Name = "sunkenWithThinNeedle3DNumericEdit";
            this.sunkenWithThinNeedle3DNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.sunkenWithThinNeedle3DNumericEdit.Source = this.sunkenWithThinNeedle3DGauge;
            this.sunkenWithThinNeedle3DNumericEdit.TabIndex = 11;
            this.sunkenWithThinNeedle3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // sunkenWithThinNeedle3DGauge
            // 
            this.sunkenWithThinNeedle3DGauge.Caption = "SunkenWithThinNeedle3D";
            this.sunkenWithThinNeedle3DGauge.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions;
            this.sunkenWithThinNeedle3DGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThinNeedle3D;
            this.sunkenWithThinNeedle3DGauge.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.sunkenWithThinNeedle3DGauge.Location = new System.Drawing.Point(424, 240);
            this.sunkenWithThinNeedle3DGauge.MajorDivisions.TickColor = System.Drawing.Color.DodgerBlue;
            this.sunkenWithThinNeedle3DGauge.MajorDivisions.TickLength = 7F;
            this.sunkenWithThinNeedle3DGauge.MinorDivisions.TickColor = System.Drawing.Color.Red;
            this.sunkenWithThinNeedle3DGauge.Name = "sunkenWithThinNeedle3DGauge";
            this.sunkenWithThinNeedle3DGauge.Range = new NationalInstruments.UI.Range(0, 1000);
            this.sunkenWithThinNeedle3DGauge.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.sunkenWithThinNeedle3DGauge.Size = new System.Drawing.Size(160, 160);
            this.sunkenWithThinNeedle3DGauge.TabIndex = 5;
            this.sunkenWithThinNeedle3DGauge.Value = 0.1;
            // 
            // sunkenWithThickNeedle3DNumericEdit
            // 
            this.sunkenWithThickNeedle3DNumericEdit.Location = new System.Drawing.Point(60, 400);
            this.sunkenWithThickNeedle3DNumericEdit.Name = "sunkenWithThickNeedle3DNumericEdit";
            this.sunkenWithThickNeedle3DNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.sunkenWithThickNeedle3DNumericEdit.Source = this.sunkenWithThickNeedle3DGauge;
            this.sunkenWithThickNeedle3DNumericEdit.TabIndex = 10;
            this.sunkenWithThickNeedle3DNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // sunkenWithThickNeedle3DGauge
            // 
            this.sunkenWithThickNeedle3DGauge.AutoDivisionSpacing = false;
            this.sunkenWithThickNeedle3DGauge.Caption = "SunkenWithThickNeedle3D";
            this.sunkenWithThickNeedle3DGauge.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.sunkenWithThickNeedle3DGauge.Location = new System.Drawing.Point(40, 240);
            this.sunkenWithThickNeedle3DGauge.MajorDivisions.Interval = 2;
            this.sunkenWithThickNeedle3DGauge.MajorDivisions.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sunkenWithThickNeedle3DGauge.MajorDivisions.LineWidth = 4F;
            this.sunkenWithThickNeedle3DGauge.MajorDivisions.TickLength = 10F;
            this.sunkenWithThickNeedle3DGauge.MinorDivisions.Interval = 0.5;
            this.sunkenWithThickNeedle3DGauge.MinorDivisions.LineWidth = 3F;
            this.sunkenWithThickNeedle3DGauge.MinorDivisions.TickLength = 5F;
            this.sunkenWithThickNeedle3DGauge.Name = "sunkenWithThickNeedle3DGauge";
            this.sunkenWithThickNeedle3DGauge.Size = new System.Drawing.Size(160, 160);
            this.sunkenWithThickNeedle3DGauge.TabIndex = 3;
            // 
            // flatWithThinNeedleGaugeNumericEdit
            // 
            this.flatWithThinNeedleGaugeNumericEdit.Location = new System.Drawing.Point(244, 192);
            this.flatWithThinNeedleGaugeNumericEdit.Name = "flatWithThinNeedleGaugeNumericEdit";
            this.flatWithThinNeedleGaugeNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatWithThinNeedleGaugeNumericEdit.Source = this.flatWithThinNeedleGauge;
            this.flatWithThinNeedleGaugeNumericEdit.TabIndex = 9;
            this.flatWithThinNeedleGaugeNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatWithThinNeedleGauge
            // 
            this.flatWithThinNeedleGauge.Caption = "FlatWithThinNeedle";
            this.flatWithThinNeedleGauge.DialColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.flatWithThinNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.FlatWithThinNeedle;
            this.flatWithThinNeedleGauge.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.flatWithThinNeedleGauge.Location = new System.Drawing.Point(224, 31);
            this.flatWithThinNeedleGauge.MinorDivisions.TickVisible = false;
            this.flatWithThinNeedleGauge.Name = "flatWithThinNeedleGauge";
            this.flatWithThinNeedleGauge.PointerColor = System.Drawing.Color.Blue;
            this.flatWithThinNeedleGauge.ScaleArc = new NationalInstruments.UI.Arc(300F, 300F);
            this.flatWithThinNeedleGauge.Size = new System.Drawing.Size(160, 160);
            this.flatWithThinNeedleGauge.TabIndex = 1;
            // 
            // flatWithThickNeedleNumericEdit
            // 
            this.flatWithThickNeedleNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.flatWithThickNeedleNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.flatWithThickNeedleNumericEdit.Location = new System.Drawing.Point(68, 192);
            this.flatWithThickNeedleNumericEdit.Name = "flatWithThickNeedleNumericEdit";
            this.flatWithThickNeedleNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatWithThickNeedleNumericEdit.Source = this.flatWithThickNeedleGauge;
            this.flatWithThickNeedleNumericEdit.TabIndex = 6;
            this.flatWithThickNeedleNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatWithThickNeedleGauge
            // 
            this.flatWithThickNeedleGauge.Caption = "FlatWithThickNeedle";
            scaleCustomDivision8.LabelFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            scaleCustomDivision8.LabelForeColor = System.Drawing.Color.Red;
            scaleCustomDivision8.Text = "Hot";
            scaleCustomDivision8.Value = 80;
            this.flatWithThickNeedleGauge.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
            scaleCustomDivision8});
            this.flatWithThickNeedleGauge.DialColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.flatWithThickNeedleGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.FlatWithThickNeedle;
            this.flatWithThickNeedleGauge.Location = new System.Drawing.Point(40, 31);
            this.flatWithThickNeedleGauge.Name = "flatWithThickNeedleGauge";
            this.flatWithThickNeedleGauge.Range = new NationalInstruments.UI.Range(0, 100);
            scaleRangeFill3.Range = new NationalInstruments.UI.Range(80, 100);
            scaleRangeFill3.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateSolidStyle(System.Drawing.Color.Red);
            this.flatWithThickNeedleGauge.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
            scaleRangeFill3});
            this.flatWithThickNeedleGauge.Size = new System.Drawing.Size(160, 160);
            this.flatWithThickNeedleGauge.TabIndex = 0;
            // 
            // tankTabPage
            // 
            this.tankTabPage.Controls.Add(this.raised3DHorizontalNumericEdit);
            this.tankTabPage.Controls.Add(this.raisedHorizontalNumericEdit);
            this.tankTabPage.Controls.Add(this.raised3dVerticalNumericEdit);
            this.tankTabPage.Controls.Add(this.flatVerticalNumericEdit);
            this.tankTabPage.Controls.Add(this.flatHorizontalNumericEdit);
            this.tankTabPage.Controls.Add(this.raisedVerticalNumericEdit);
            this.tankTabPage.Controls.Add(this.raised3DHorizontalTank);
            this.tankTabPage.Controls.Add(this.raisedHorizontalTank);
            this.tankTabPage.Controls.Add(this.flatHorizontalTank);
            this.tankTabPage.Controls.Add(this.raised3DVerticalTank);
            this.tankTabPage.Controls.Add(this.raisedVerticalTank);
            this.tankTabPage.Controls.Add(this.flatVerticalTank);
            this.tankTabPage.Location = new System.Drawing.Point(4, 22);
            this.tankTabPage.Name = "tankTabPage";
            this.tankTabPage.Size = new System.Drawing.Size(624, 446);
            this.tankTabPage.TabIndex = 3;
            this.tankTabPage.Text = "Tank";
            // 
            // raised3DHorizontalNumericEdit
            // 
            this.raised3DHorizontalNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.raised3DHorizontalNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.raised3DHorizontalNumericEdit.Location = new System.Drawing.Point(444, 384);
            this.raised3DHorizontalNumericEdit.Name = "raised3DHorizontalNumericEdit";
            this.raised3DHorizontalNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raised3DHorizontalNumericEdit.Source = this.raised3DHorizontalTank;
            this.raised3DHorizontalNumericEdit.TabIndex = 14;
            this.raised3DHorizontalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raised3DHorizontalTank
            // 
            this.raised3DHorizontalTank.AutoDivisionSpacing = false;
            this.raised3DHorizontalTank.Caption = "Raised3D";
            this.raised3DHorizontalTank.Location = new System.Drawing.Point(412, 259);
            this.raised3DHorizontalTank.Name = "raised3DHorizontalTank";
            this.raised3DHorizontalTank.Range = new NationalInstruments.UI.Range(0, 1000);
            this.raised3DHorizontalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.TopBottom;
            this.raised3DHorizontalTank.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.raised3DHorizontalTank.Size = new System.Drawing.Size(168, 120);
            this.raised3DHorizontalTank.TabIndex = 5;
            this.raised3DHorizontalTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D;
            // 
            // raisedHorizontalNumericEdit
            // 
            this.raisedHorizontalNumericEdit.Location = new System.Drawing.Point(256, 384);
            this.raisedHorizontalNumericEdit.Name = "raisedHorizontalNumericEdit";
            this.raisedHorizontalNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedHorizontalNumericEdit.Source = this.raisedHorizontalTank;
            this.raisedHorizontalNumericEdit.TabIndex = 12;
            this.raisedHorizontalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedHorizontalTank
            // 
            this.raisedHorizontalTank.Caption = "Raised";
            this.raisedHorizontalTank.FillColor = System.Drawing.SystemColors.ControlText;
            this.raisedHorizontalTank.FillMode = NationalInstruments.UI.NumericFillMode.None;
            this.raisedHorizontalTank.InteractionMode = ((NationalInstruments.UI.LinearNumericPointerInteractionModes)((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer)));
            this.raisedHorizontalTank.InvertedScale = true;
            this.raisedHorizontalTank.Location = new System.Drawing.Point(228, 259);
            this.raisedHorizontalTank.Name = "raisedHorizontalTank";
            this.raisedHorizontalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Top;
            this.raisedHorizontalTank.Size = new System.Drawing.Size(168, 120);
            this.raisedHorizontalTank.TabIndex = 4;
            this.raisedHorizontalTank.Value = 5;
            // 
            // raised3dVerticalNumericEdit
            // 
            this.raised3dVerticalNumericEdit.Location = new System.Drawing.Point(444, 213);
            this.raised3dVerticalNumericEdit.Name = "raised3dVerticalNumericEdit";
            this.raised3dVerticalNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raised3dVerticalNumericEdit.Source = this.raised3DVerticalTank;
            this.raised3dVerticalNumericEdit.TabIndex = 11;
            this.raised3dVerticalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raised3DVerticalTank
            // 
            this.raised3DVerticalTank.Caption = "Raised3D";
            this.raised3DVerticalTank.FillBaseValue = 2;
            this.raised3DVerticalTank.FillMode = NationalInstruments.UI.NumericFillMode.ToBaseValue;
            this.raised3DVerticalTank.InteractionMode = ((NationalInstruments.UI.LinearNumericPointerInteractionModes)((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer)));
            this.raised3DVerticalTank.Location = new System.Drawing.Point(444, 27);
            this.raised3DVerticalTank.Name = "raised3DVerticalTank";
            this.raised3DVerticalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Right;
            this.raised3DVerticalTank.Size = new System.Drawing.Size(120, 184);
            this.raised3DVerticalTank.TabIndex = 2;
            this.raised3DVerticalTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D;
            this.raised3DVerticalTank.Value = 5;
            // 
            // flatVerticalNumericEdit
            // 
            this.flatVerticalNumericEdit.Location = new System.Drawing.Point(68, 213);
            this.flatVerticalNumericEdit.Name = "flatVerticalNumericEdit";
            this.flatVerticalNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatVerticalNumericEdit.Source = this.flatVerticalTank;
            this.flatVerticalNumericEdit.TabIndex = 10;
            this.flatVerticalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatVerticalTank
            // 
            this.flatVerticalTank.Caption = "Flat";
            this.flatVerticalTank.FillStyle = NationalInstruments.UI.FillStyle.Wave;
            this.flatVerticalTank.InteractionMode = ((NationalInstruments.UI.LinearNumericPointerInteractionModes)((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer)));
            this.flatVerticalTank.Location = new System.Drawing.Point(60, 27);
            this.flatVerticalTank.Name = "flatVerticalTank";
            this.flatVerticalTank.Range = new NationalInstruments.UI.Range(-100, 100);
            this.flatVerticalTank.Size = new System.Drawing.Size(120, 184);
            this.flatVerticalTank.TabIndex = 0;
            this.flatVerticalTank.TankStyle = NationalInstruments.UI.TankStyle.Flat;
            // 
            // flatHorizontalNumericEdit
            // 
            this.flatHorizontalNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.flatHorizontalNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.flatHorizontalNumericEdit.Location = new System.Drawing.Point(72, 384);
            this.flatHorizontalNumericEdit.Name = "flatHorizontalNumericEdit";
            this.flatHorizontalNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatHorizontalNumericEdit.Source = this.flatHorizontalTank;
            this.flatHorizontalNumericEdit.TabIndex = 8;
            this.flatHorizontalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatHorizontalTank
            // 
            this.flatHorizontalTank.Caption = "Flat";
            this.flatHorizontalTank.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient;
            this.flatHorizontalTank.Location = new System.Drawing.Point(44, 259);
            this.flatHorizontalTank.Name = "flatHorizontalTank";
            this.flatHorizontalTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.flatHorizontalTank.Size = new System.Drawing.Size(168, 120);
            this.flatHorizontalTank.TabIndex = 3;
            this.flatHorizontalTank.TankStyle = NationalInstruments.UI.TankStyle.Flat;
            this.flatHorizontalTank.Value = 2;
            // 
            // raisedVerticalNumericEdit
            // 
            this.raisedVerticalNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.raisedVerticalNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.raisedVerticalNumericEdit.Location = new System.Drawing.Point(252, 213);
            this.raisedVerticalNumericEdit.Name = "raisedVerticalNumericEdit";
            this.raisedVerticalNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedVerticalNumericEdit.Source = this.raisedVerticalTank;
            this.raisedVerticalNumericEdit.TabIndex = 7;
            this.raisedVerticalNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedVerticalTank
            // 
            this.raisedVerticalTank.Caption = "Raised";
            scaleCustomDivision9.LabelForeColor = System.Drawing.Color.Red;
            scaleCustomDivision9.Text = "HOT";
            scaleCustomDivision9.TickLength = 3F;
            scaleCustomDivision9.Value = 80;
            this.raisedVerticalTank.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
            scaleCustomDivision9});
            this.raisedVerticalTank.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum;
            this.raisedVerticalTank.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient;
            this.raisedVerticalTank.Location = new System.Drawing.Point(252, 27);
            this.raisedVerticalTank.Name = "raisedVerticalTank";
            this.raisedVerticalTank.Range = new NationalInstruments.UI.Range(0, 100);
            scaleRangeFill4.Range = new NationalInstruments.UI.Range(80, 100);
            scaleRangeFill4.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateStyleFromFillStyle(NationalInstruments.UI.FillStyle.Divot, System.Drawing.Color.Red);
            this.raisedVerticalTank.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
            scaleRangeFill4});
            this.raisedVerticalTank.Size = new System.Drawing.Size(120, 184);
            this.raisedVerticalTank.TabIndex = 1;
            this.raisedVerticalTank.Value = 40;
            // 
            // slideTabPage
            // 
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit);
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGripHorizontalSlideNumericEdit);
            this.slideTabPage.Controls.Add(this.sunkenWithGripHorizontalSlideNumericEdit);
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGrip3DVerticalSlideNumericEdit);
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGripVerticalSlideNumericEdit);
            this.slideTabPage.Controls.Add(this.sunkenWithGripVerticalSlideNumericEdit);
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGrip3DHorizontalSlide);
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGripHorizontalSlide);
            this.slideTabPage.Controls.Add(this.sunkenWithGripHorizontalSlide);
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGrip3DVerticalSlide);
            this.slideTabPage.Controls.Add(this.raisedWithRoundedGripVerticalSlide);
            this.slideTabPage.Controls.Add(this.sunkenWithGripVerticalSlide);
            this.slideTabPage.Location = new System.Drawing.Point(4, 22);
            this.slideTabPage.Name = "slideTabPage";
            this.slideTabPage.Size = new System.Drawing.Size(624, 446);
            this.slideTabPage.TabIndex = 4;
            this.slideTabPage.Text = "Slide";
            // 
            // raisedWithRoundedGrip3DHorizontalSlideNumericEdit
            // 
            this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Location = new System.Drawing.Point(472, 392);
            this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Name = "raisedWithRoundedGrip3DHorizontalSlideNumericEdit";
            this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.Source = this.raisedWithRoundedGrip3DHorizontalSlide;
            this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.TabIndex = 15;
            this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithRoundedGrip3DHorizontalSlide
            // 
            this.raisedWithRoundedGrip3DHorizontalSlide.AutoDivisionSpacing = false;
            this.raisedWithRoundedGrip3DHorizontalSlide.Caption = "RaisedWithRoundedGrip3D";
            this.raisedWithRoundedGrip3DHorizontalSlide.Location = new System.Drawing.Point(440, 267);
            this.raisedWithRoundedGrip3DHorizontalSlide.Name = "raisedWithRoundedGrip3DHorizontalSlide";
            this.raisedWithRoundedGrip3DHorizontalSlide.Range = new NationalInstruments.UI.Range(0, 1000);
            this.raisedWithRoundedGrip3DHorizontalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.TopBottom;
            this.raisedWithRoundedGrip3DHorizontalSlide.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.raisedWithRoundedGrip3DHorizontalSlide.Size = new System.Drawing.Size(176, 120);
            this.raisedWithRoundedGrip3DHorizontalSlide.TabIndex = 5;
            // 
            // raisedWithRoundedGripHorizontalSlideNumericEdit
            // 
            this.raisedWithRoundedGripHorizontalSlideNumericEdit.Location = new System.Drawing.Point(248, 392);
            this.raisedWithRoundedGripHorizontalSlideNumericEdit.Name = "raisedWithRoundedGripHorizontalSlideNumericEdit";
            this.raisedWithRoundedGripHorizontalSlideNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithRoundedGripHorizontalSlideNumericEdit.Source = this.raisedWithRoundedGripHorizontalSlide;
            this.raisedWithRoundedGripHorizontalSlideNumericEdit.TabIndex = 14;
            this.raisedWithRoundedGripHorizontalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithRoundedGripHorizontalSlide
            // 
            this.raisedWithRoundedGripHorizontalSlide.Caption = "RaisedWithRoundedGrip";
            this.raisedWithRoundedGripHorizontalSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum;
            this.raisedWithRoundedGripHorizontalSlide.InvertedScale = true;
            this.raisedWithRoundedGripHorizontalSlide.Location = new System.Drawing.Point(216, 267);
            this.raisedWithRoundedGripHorizontalSlide.Name = "raisedWithRoundedGripHorizontalSlide";
            this.raisedWithRoundedGripHorizontalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Top;
            this.raisedWithRoundedGripHorizontalSlide.Size = new System.Drawing.Size(176, 125);
            this.raisedWithRoundedGripHorizontalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip;
            this.raisedWithRoundedGripHorizontalSlide.TabIndex = 4;
            // 
            // sunkenWithGripHorizontalSlideNumericEdit
            // 
            this.sunkenWithGripHorizontalSlideNumericEdit.Location = new System.Drawing.Point(40, 392);
            this.sunkenWithGripHorizontalSlideNumericEdit.Name = "sunkenWithGripHorizontalSlideNumericEdit";
            this.sunkenWithGripHorizontalSlideNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.sunkenWithGripHorizontalSlideNumericEdit.Source = this.sunkenWithGripHorizontalSlide;
            this.sunkenWithGripHorizontalSlideNumericEdit.TabIndex = 13;
            this.sunkenWithGripHorizontalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // sunkenWithGripHorizontalSlide
            // 
            this.sunkenWithGripHorizontalSlide.Caption = "SunkenWithGrip";
            this.sunkenWithGripHorizontalSlide.Location = new System.Drawing.Point(8, 267);
            this.sunkenWithGripHorizontalSlide.Name = "sunkenWithGripHorizontalSlide";
            this.sunkenWithGripHorizontalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.sunkenWithGripHorizontalSlide.Size = new System.Drawing.Size(176, 125);
            this.sunkenWithGripHorizontalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip;
            this.sunkenWithGripHorizontalSlide.TabIndex = 3;
            // 
            // raisedWithRoundedGrip3DVerticalSlideNumericEdit
            // 
            this.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Location = new System.Drawing.Point(452, 213);
            this.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Name = "raisedWithRoundedGrip3DVerticalSlideNumericEdit";
            this.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithRoundedGrip3DVerticalSlideNumericEdit.Source = this.raisedWithRoundedGrip3DVerticalSlide;
            this.raisedWithRoundedGrip3DVerticalSlideNumericEdit.TabIndex = 12;
            this.raisedWithRoundedGrip3DVerticalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithRoundedGrip3DVerticalSlide
            // 
            this.raisedWithRoundedGrip3DVerticalSlide.Caption = "RaisedWithRoundedGrip3D";
            this.raisedWithRoundedGrip3DVerticalSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum;
            this.raisedWithRoundedGrip3DVerticalSlide.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient;
            this.raisedWithRoundedGrip3DVerticalSlide.Location = new System.Drawing.Point(432, 19);
            this.raisedWithRoundedGrip3DVerticalSlide.Name = "raisedWithRoundedGrip3DVerticalSlide";
            this.raisedWithRoundedGrip3DVerticalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Right;
            this.raisedWithRoundedGrip3DVerticalSlide.Size = new System.Drawing.Size(160, 192);
            this.raisedWithRoundedGrip3DVerticalSlide.TabIndex = 2;
            // 
            // raisedWithRoundedGripVerticalSlideNumericEdit
            // 
            this.raisedWithRoundedGripVerticalSlideNumericEdit.Location = new System.Drawing.Point(260, 213);
            this.raisedWithRoundedGripVerticalSlideNumericEdit.Name = "raisedWithRoundedGripVerticalSlideNumericEdit";
            this.raisedWithRoundedGripVerticalSlideNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedWithRoundedGripVerticalSlideNumericEdit.Source = this.raisedWithRoundedGripVerticalSlide;
            this.raisedWithRoundedGripVerticalSlideNumericEdit.TabIndex = 11;
            this.raisedWithRoundedGripVerticalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedWithRoundedGripVerticalSlide
            // 
            this.raisedWithRoundedGripVerticalSlide.Caption = "RaisedWithRoundedGrip";
            this.raisedWithRoundedGripVerticalSlide.Location = new System.Drawing.Point(224, 19);
            this.raisedWithRoundedGripVerticalSlide.Name = "raisedWithRoundedGripVerticalSlide";
            this.raisedWithRoundedGripVerticalSlide.Range = new NationalInstruments.UI.Range(0, 100);
            this.raisedWithRoundedGripVerticalSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.LeftRight;
            this.raisedWithRoundedGripVerticalSlide.Size = new System.Drawing.Size(184, 192);
            this.raisedWithRoundedGripVerticalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip;
            this.raisedWithRoundedGripVerticalSlide.TabIndex = 1;
            // 
            // sunkenWithGripVerticalSlideNumericEdit
            // 
            this.sunkenWithGripVerticalSlideNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.sunkenWithGripVerticalSlideNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.sunkenWithGripVerticalSlideNumericEdit.Location = new System.Drawing.Point(60, 213);
            this.sunkenWithGripVerticalSlideNumericEdit.Name = "sunkenWithGripVerticalSlideNumericEdit";
            this.sunkenWithGripVerticalSlideNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.sunkenWithGripVerticalSlideNumericEdit.Source = this.sunkenWithGripVerticalSlide;
            this.sunkenWithGripVerticalSlideNumericEdit.TabIndex = 8;
            this.sunkenWithGripVerticalSlideNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // sunkenWithGripVerticalSlide
            // 
            this.sunkenWithGripVerticalSlide.Caption = "SunkenWithGrip";
            this.sunkenWithGripVerticalSlide.FillMode = NationalInstruments.UI.NumericFillMode.None;
            this.sunkenWithGripVerticalSlide.FillStyle = NationalInstruments.UI.FillStyle.None;
            this.sunkenWithGripVerticalSlide.Location = new System.Drawing.Point(32, 19);
            this.sunkenWithGripVerticalSlide.Name = "sunkenWithGripVerticalSlide";
            scaleRangeFill5.Range = new NationalInstruments.UI.Range(2, 8);
            scaleRangeFill5.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateStyleFromFillStyle(NationalInstruments.UI.FillStyle.HorizontalGradient, System.Drawing.Color.Silver);
            scaleRangeFill5.Width = 7F;
            this.sunkenWithGripVerticalSlide.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
            scaleRangeFill5});
            this.sunkenWithGripVerticalSlide.Size = new System.Drawing.Size(144, 192);
            this.sunkenWithGripVerticalSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip;
            this.sunkenWithGripVerticalSlide.TabIndex = 0;
            // 
            // thermometerTabPage
            // 
            this.thermometerTabPage.Controls.Add(this.flatHorizontalThermometerNumericEdit);
            this.thermometerTabPage.Controls.Add(this.raisedVerticalThermometerNumericEdit);
            this.thermometerTabPage.Controls.Add(this.raised3DHorizontalThermometerNumericEdit);
            this.thermometerTabPage.Controls.Add(this.raisedHorizontalThermometerNumericEdit);
            this.thermometerTabPage.Controls.Add(this.raised3DVerticalThermometerNumericEdit);
            this.thermometerTabPage.Controls.Add(this.flatVerticalThermometerNumericEdit);
            this.thermometerTabPage.Controls.Add(this.raised3DHorizontalThermometer);
            this.thermometerTabPage.Controls.Add(this.raisedHorizontalThermometer);
            this.thermometerTabPage.Controls.Add(this.flatHorizontalThermometer);
            this.thermometerTabPage.Controls.Add(this.raised3DVerticalThermometer);
            this.thermometerTabPage.Controls.Add(this.raisedVerticalThermometer);
            this.thermometerTabPage.Controls.Add(this.flatVerticalThermometer);
            this.thermometerTabPage.Location = new System.Drawing.Point(4, 22);
            this.thermometerTabPage.Name = "thermometerTabPage";
            this.thermometerTabPage.Size = new System.Drawing.Size(624, 446);
            this.thermometerTabPage.TabIndex = 5;
            this.thermometerTabPage.Text = "Thermometer";
            // 
            // flatHorizontalThermometerNumericEdit
            // 
            this.flatHorizontalThermometerNumericEdit.Location = new System.Drawing.Point(56, 392);
            this.flatHorizontalThermometerNumericEdit.Name = "flatHorizontalThermometerNumericEdit";
            this.flatHorizontalThermometerNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatHorizontalThermometerNumericEdit.Source = this.flatHorizontalThermometer;
            this.flatHorizontalThermometerNumericEdit.TabIndex = 12;
            this.flatHorizontalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatHorizontalThermometer
            // 
            this.flatHorizontalThermometer.Caption = "Flat";
            this.flatHorizontalThermometer.InteractionMode = ((NationalInstruments.UI.LinearNumericPointerInteractionModes)((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer)));
            this.flatHorizontalThermometer.Location = new System.Drawing.Point(24, 295);
            this.flatHorizontalThermometer.Name = "flatHorizontalThermometer";
            this.flatHorizontalThermometer.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.flatHorizontalThermometer.Size = new System.Drawing.Size(168, 96);
            this.flatHorizontalThermometer.TabIndex = 3;
            this.flatHorizontalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Flat;
            // 
            // raisedVerticalThermometerNumericEdit
            // 
            this.raisedVerticalThermometerNumericEdit.Location = new System.Drawing.Point(264, 256);
            this.raisedVerticalThermometerNumericEdit.Name = "raisedVerticalThermometerNumericEdit";
            this.raisedVerticalThermometerNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedVerticalThermometerNumericEdit.Source = this.raisedVerticalThermometer;
            this.raisedVerticalThermometerNumericEdit.TabIndex = 11;
            this.raisedVerticalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedVerticalThermometer
            // 
            this.raisedVerticalThermometer.Caption = "Raised";
            this.raisedVerticalThermometer.InteractionMode = ((NationalInstruments.UI.LinearNumericPointerInteractionModes)((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer)));
            this.raisedVerticalThermometer.Location = new System.Drawing.Point(284, 15);
            this.raisedVerticalThermometer.Name = "raisedVerticalThermometer";
            this.raisedVerticalThermometer.Range = new NationalInstruments.UI.Range(40, 100);
            this.raisedVerticalThermometer.Size = new System.Drawing.Size(80, 240);
            this.raisedVerticalThermometer.TabIndex = 1;
            this.raisedVerticalThermometer.Value = 50;
            // 
            // raised3DHorizontalThermometerNumericEdit
            // 
            this.raised3DHorizontalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.raised3DHorizontalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.raised3DHorizontalThermometerNumericEdit.Location = new System.Drawing.Point(456, 384);
            this.raised3DHorizontalThermometerNumericEdit.Name = "raised3DHorizontalThermometerNumericEdit";
            this.raised3DHorizontalThermometerNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raised3DHorizontalThermometerNumericEdit.Source = this.raised3DHorizontalThermometer;
            this.raised3DHorizontalThermometerNumericEdit.TabIndex = 9;
            this.raised3DHorizontalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raised3DHorizontalThermometer
            // 
            this.raised3DHorizontalThermometer.Caption = "Raised3D";
            this.raised3DHorizontalThermometer.Location = new System.Drawing.Point(432, 295);
            this.raised3DHorizontalThermometer.MaximumBulbDiameter = 5F;
            this.raised3DHorizontalThermometer.Name = "raised3DHorizontalThermometer";
            this.raised3DHorizontalThermometer.ScalePosition = NationalInstruments.UI.NumericScalePosition.TopBottom;
            this.raised3DHorizontalThermometer.Size = new System.Drawing.Size(168, 88);
            this.raised3DHorizontalThermometer.TabIndex = 5;
            this.raised3DHorizontalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Raised3D;
            // 
            // raisedHorizontalThermometerNumericEdit
            // 
            this.raisedHorizontalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.raisedHorizontalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.raisedHorizontalThermometerNumericEdit.Location = new System.Drawing.Point(264, 392);
            this.raisedHorizontalThermometerNumericEdit.Name = "raisedHorizontalThermometerNumericEdit";
            this.raisedHorizontalThermometerNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raisedHorizontalThermometerNumericEdit.Source = this.raisedHorizontalThermometer;
            this.raisedHorizontalThermometerNumericEdit.TabIndex = 8;
            this.raisedHorizontalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raisedHorizontalThermometer
            // 
            this.raisedHorizontalThermometer.CanShowFocus = true;
            this.raisedHorizontalThermometer.Caption = "Raised";
            this.raisedHorizontalThermometer.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient;
            this.raisedHorizontalThermometer.Location = new System.Drawing.Point(224, 295);
            this.raisedHorizontalThermometer.Name = "raisedHorizontalThermometer";
            this.raisedHorizontalThermometer.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.raisedHorizontalThermometer.Size = new System.Drawing.Size(168, 96);
            this.raisedHorizontalThermometer.TabIndex = 4;
            // 
            // raised3DVerticalThermometerNumericEdit
            // 
            this.raised3DVerticalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.raised3DVerticalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.raised3DVerticalThermometerNumericEdit.Location = new System.Drawing.Point(456, 256);
            this.raised3DVerticalThermometerNumericEdit.Name = "raised3DVerticalThermometerNumericEdit";
            this.raised3DVerticalThermometerNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.raised3DVerticalThermometerNumericEdit.Source = this.raised3DVerticalThermometer;
            this.raised3DVerticalThermometerNumericEdit.TabIndex = 7;
            this.raised3DVerticalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // raised3DVerticalThermometer
            // 
            this.raised3DVerticalThermometer.Caption = "Raised3D";
            this.raised3DVerticalThermometer.Location = new System.Drawing.Point(476, 15);
            this.raised3DVerticalThermometer.Name = "raised3DVerticalThermometer";
            this.raised3DVerticalThermometer.Size = new System.Drawing.Size(64, 240);
            this.raised3DVerticalThermometer.TabIndex = 2;
            this.raised3DVerticalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Raised3D;
            // 
            // flatVerticalThermometerNumericEdit
            // 
            this.flatVerticalThermometerNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.flatVerticalThermometerNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.flatVerticalThermometerNumericEdit.Location = new System.Drawing.Point(56, 256);
            this.flatVerticalThermometerNumericEdit.Name = "flatVerticalThermometerNumericEdit";
            this.flatVerticalThermometerNumericEdit.Size = new System.Drawing.Size(112, 20);
            this.flatVerticalThermometerNumericEdit.Source = this.flatVerticalThermometer;
            this.flatVerticalThermometerNumericEdit.TabIndex = 6;
            this.flatVerticalThermometerNumericEdit.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // flatVerticalThermometer
            // 
            this.flatVerticalThermometer.Caption = "Flat";
            this.flatVerticalThermometer.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient;
            this.flatVerticalThermometer.Location = new System.Drawing.Point(84, 15);
            this.flatVerticalThermometer.Name = "flatVerticalThermometer";
            this.flatVerticalThermometer.Size = new System.Drawing.Size(80, 240);
            this.flatVerticalThermometer.TabIndex = 0;
            this.flatVerticalThermometer.ThermometerStyle = NationalInstruments.UI.ThermometerStyle.Flat;
            this.flatVerticalThermometer.Value = 20;
            // 
            // sampleTimer
            // 
            this.sampleTimer.Enabled = true;
            this.sampleTimer.Interval = 200;
            this.sampleTimer.Tick += new System.EventHandler(this.sampleTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(626, 472);
            this.Controls.Add(this.stylesTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Styles";
            this.stylesTabControl.ResumeLayout(false);
            this.knobTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumb3DNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumb3DKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumbNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThumbKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedle3DNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedle3DKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedleKnob)).EndInit();
            this.meterTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleMeterNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleMeterNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThinNeedleMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThickNeedleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithThickNeedleMeter)).EndInit();
            this.gaugeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedleGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedleGaugeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedleGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedle3DNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThinNeedle3DGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedle3DNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithThickNeedle3DGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleGaugeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThinNeedleGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatWithThickNeedleGauge)).EndInit();
            this.tankTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3dVerticalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DVerticalTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalTank)).EndInit();
            this.slideTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DHorizontalSlideNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DHorizontalSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripHorizontalSlideNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripHorizontalSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripHorizontalSlideNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripHorizontalSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DVerticalSlideNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGrip3DVerticalSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripVerticalSlideNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedWithRoundedGripVerticalSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripVerticalSlideNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sunkenWithGripVerticalSlide)).EndInit();
            this.thermometerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalThermometerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatHorizontalThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalThermometerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedVerticalThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalThermometerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DHorizontalThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalThermometerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raisedHorizontalThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DVerticalThermometerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.raised3DVerticalThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalThermometerNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flatVerticalThermometer)).EndInit();
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

        
        private void sampleTimer_Tick(object sender, System.EventArgs e)
        {
			if (stylesTabControl.SelectedTab == meterTabPage)
			{
				raisedWithThickNeedleMeter.Value = GetNewValue(raisedWithThickNeedleMeter.Range, raisedWithThickNeedleMeter.Value, 10, ref raisedWithThickNeedleMeterValueIncreasing);
				raisedWithThinNeedleMeter.Value = GetNewValue(raisedWithThinNeedleMeter.Range, raisedWithThinNeedleMeter.Value, 8, ref raisedWithThinNeedleMeterValueIncreasing);
				flatWithThickNeedleMeter.Value = GetNewValue(flatWithThickNeedleMeter.Range, flatWithThickNeedleMeter.Value, 10, ref flatWithThickNeedleMeterValueIncreasing);
				flatWithThinNeedleMeter.Value = GetNewValue(flatWithThinNeedleMeter.Range, flatWithThinNeedleMeter.Value, 50, ref flatWithThinNeedleMeterValueIncreasing);
			}
			else if (stylesTabControl.SelectedTab == knobTabPage)
				flatWithThinNeedleKnob.Value = GetNewValue(flatWithThinNeedleKnob.Range, flatWithThinNeedleKnob.Value, 10, ref flatWithThinNeedleKnobValueIncreasing);				
			else if (stylesTabControl.SelectedTab == gaugeTabPage)
			{
				flatWithThickNeedleGauge.Value = GetNewValue(flatWithThickNeedleGauge.Range, flatWithThickNeedleGauge.Value, 10, ref flatWithThickNeedleGaugeValueIncreasing);
				sunkenWithThickNeedleGauge.Value = GetNewValue(sunkenWithThickNeedleGauge.Range, sunkenWithThickNeedleGauge.Value, 20, ref sunkenWithThickNeedleGaugeValueIncreasing);
				sunkenWithThinNeedleGauge.Value = GetNewValue(sunkenWithThinNeedleGauge.Range, sunkenWithThinNeedleGauge.Value, 15, ref sunkenWithThinNeedleGaugeValueIncreasing);
			}
			else if (stylesTabControl.SelectedTab == tankTabPage)
			{
				raisedVerticalTank.Value = GetNewValue(raisedVerticalTank.Range, raisedVerticalTank.Value, 10, ref raisedVerticalTankValueIncreasing);
				flatHorizontalTank.Value = GetNewValue(flatHorizontalTank.Range, flatHorizontalTank.Value, 10, ref flatHorizontalTankValueIncreasing);
				raised3DHorizontalTank.Value = GetNewValue(raised3DHorizontalTank.Range, raised3DHorizontalTank.Value, 20, ref raised3DHorizontalTankValueIncreasing);
			}
			else if (stylesTabControl.SelectedTab == slideTabPage)
				sunkenWithGripVerticalSlide.Value = GetNewValue(sunkenWithGripVerticalSlide.Range, sunkenWithGripVerticalSlide.Value, 10, ref sunkenWithGripVerticalSlideValueIncreasing);
			else if (stylesTabControl.SelectedTab == thermometerTabPage)
			{
				flatVerticalThermometer.Value = GetNewValue(flatVerticalThermometer.Range, flatVerticalThermometer.Value, 10, ref flatVerticalThermometerValueIncreasing);
				raised3DVerticalThermometer.Value = GetNewValue(raised3DVerticalThermometer.Range, raised3DVerticalThermometer.Value, 10, ref raised3DVerticalThermometerValueIncreasing);
				raisedHorizontalThermometer.Value = GetNewValue(raisedHorizontalThermometer.Range, raisedHorizontalThermometer.Value, 10, ref raisedHorizontalThermometerValueIncreasing);
				raised3DHorizontalThermometer.Value = GetNewValue(raised3DHorizontalThermometer.Range, raised3DHorizontalThermometer.Value, 20, ref raised3DHorizontalThermometerValueIncreasing);
			}
			else
			{
				Debug.Fail("Invalid tab page");
			}
        }

        private static double GetNewValue(Range range, double currentValue, int numberOfIntervals, ref bool increasing)
        {
            //This determines the new value of the control.
            double controlRange = range.Maximum - range.Minimum;
            double newValue = 0;
            if (increasing)
            {
                newValue = currentValue + controlRange/numberOfIntervals;
                if (newValue > range.Maximum)
                {
                    newValue = range.Maximum;
                    increasing = false;
                }
            }
            else
            {
                newValue = currentValue - controlRange/numberOfIntervals;
                if (newValue < range.Minimum)
                {
                    newValue = range.Minimum;
                    increasing = true;
                }
            }
            return newValue;
        }
	}
}
