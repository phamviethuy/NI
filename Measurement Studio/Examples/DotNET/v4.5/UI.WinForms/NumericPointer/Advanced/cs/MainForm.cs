using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Advanced
{
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.Meter tachMeter;
        private NationalInstruments.UI.WindowsForms.Gauge airspeedGauge;
        private NationalInstruments.UI.WindowsForms.Thermometer engineThermometer;
        private NationalInstruments.UI.WindowsForms.Tank fuelTank;
        private NationalInstruments.UI.WindowsForms.Gauge altimeterGauge;
        private System.Windows.Forms.Label rpmLabel;
        private System.Windows.Forms.Label airspeedLabel;
        private System.Windows.Forms.Label altitudeLabel;
        private System.Windows.Forms.Label altitude1000Label;
        private System.Windows.Forms.Label mphLabel;
        private System.Windows.Forms.Label rpm1000Label;
        private NationalInstruments.UI.WindowsForms.Switch masterSwitch;
        private NationalInstruments.UI.WindowsForms.Switch startSwitch;
        private System.Windows.Forms.Label masterLabel;
        private System.Windows.Forms.Label onLabel;
        private System.Windows.Forms.Label offLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label landingLightsLabel;
        private System.Windows.Forms.Label gphLabel;
        private NationalInstruments.UI.WindowsForms.Slide throttleSlide;
        private System.Windows.Forms.Timer sampleTimer;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label throttleLabel;
        private NationalInstruments.UI.WindowsForms.Knob landingLightsKnob;
        private System.Windows.Forms.TextBox gphStatusTextBox;
        private System.Windows.Forms.TextBox landingLightsStatusTextBox;
        private System.Windows.Forms.TextBox throttleStatusTextBox;
        
        private Random rand;
        private bool engineRunning;

		public MainForm()
		{
			InitializeComponent();

            engineRunning = true;
            rand = new Random();

            
            AdjustLabel(airspeedLabel, airspeedGauge);
            AdjustLabel(mphLabel, airspeedGauge);

            AdjustLabel(altitudeLabel, altimeterGauge);
            AdjustLabel(altitude1000Label, altimeterGauge);
		}

        private static void AdjustLabel(Label label, Control labeledControl)
        {
            // setting parent of labels to the contol instead of the form
            // so labels are transparent to the control's color instead of
            // the form's color.
            label.Parent = labeledControl;
            label.Location = new Point(label.Location.X - labeledControl.Location.X, label.Location.Y - labeledControl.Location.Y);
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
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision6 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision7 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision8 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision9 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision10 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision11 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision12 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision13 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision14 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision15 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision16 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision17 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision18 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision19 = new NationalInstruments.UI.ScaleCustomDivision();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.tachMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.airspeedGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.engineThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.fuelTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.altimeterGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.rpmLabel = new System.Windows.Forms.Label();
            this.airspeedLabel = new System.Windows.Forms.Label();
            this.altitudeLabel = new System.Windows.Forms.Label();
            this.altitude1000Label = new System.Windows.Forms.Label();
            this.mphLabel = new System.Windows.Forms.Label();
            this.rpm1000Label = new System.Windows.Forms.Label();
            this.masterSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.masterLabel = new System.Windows.Forms.Label();
            this.onLabel = new System.Windows.Forms.Label();
            this.offLabel = new System.Windows.Forms.Label();
            this.landingLightsKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.startSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.startLabel = new System.Windows.Forms.Label();
            this.landingLightsLabel = new System.Windows.Forms.Label();
            this.throttleLabel = new System.Windows.Forms.Label();
            this.gphLabel = new System.Windows.Forms.Label();
            this.throttleSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.sampleTimer = new System.Windows.Forms.Timer(this.components);
            this.gphStatusTextBox = new System.Windows.Forms.TextBox();
            this.landingLightsStatusTextBox = new System.Windows.Forms.TextBox();
            this.throttleStatusTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tachMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airspeedGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altimeterGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.landingLightsKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttleSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // tachMeter
            // 
            this.tachMeter.AutoDivisionSpacing = false;
            this.tachMeter.Location = new System.Drawing.Point(356, 12);
            this.tachMeter.MajorDivisions.Interval = 1000;
            this.tachMeter.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0,");
            this.tachMeter.MajorDivisions.LineWidth = 2F;
            this.tachMeter.MajorDivisions.TickLength = 7F;
            this.tachMeter.MinorDivisions.Interval = 500;
            this.tachMeter.MinorDivisions.TickLength = 5F;
            this.tachMeter.Name = "tachMeter";
            this.tachMeter.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.tachMeter.Range = new NationalInstruments.UI.Range(0, 8000);
            this.tachMeter.ScaleArc = new NationalInstruments.UI.Arc(224F, -263F);
            this.tachMeter.Size = new System.Drawing.Size(132, 112);
            this.tachMeter.TabIndex = 0;
            // 
            // airspeedGauge
            // 
            this.airspeedGauge.AutoDivisionSpacing = false;
            this.airspeedGauge.ImmediateUpdates = true;
            this.airspeedGauge.Location = new System.Drawing.Point(4, 12);
            this.airspeedGauge.MajorDivisions.Interval = 10;
            this.airspeedGauge.MinorDivisions.Interval = 5;
            this.airspeedGauge.Name = "airspeedGauge";
            this.airspeedGauge.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.airspeedGauge.Range = new NationalInstruments.UI.Range(0, 110);
            this.airspeedGauge.ScaleArc = new NationalInstruments.UI.Arc(90F, -323F);
            this.airspeedGauge.Size = new System.Drawing.Size(168, 168);
            this.airspeedGauge.TabIndex = 2;
            // 
            // engineThermometer
            // 
            this.engineThermometer.AutoDivisionSpacing = false;
            this.engineThermometer.Caption = "Engine Temp";
            this.engineThermometer.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.engineThermometer.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.engineThermometer.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.engineThermometer.Location = new System.Drawing.Point(496, 8);
            this.engineThermometer.MajorDivisions.Interval = 100;
            this.engineThermometer.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0�F");
            this.engineThermometer.MinorDivisions.Interval = 50;
            this.engineThermometer.Name = "engineThermometer";
            this.engineThermometer.Range = new NationalInstruments.UI.Range(0, 700);
            this.engineThermometer.Size = new System.Drawing.Size(96, 180);
            this.engineThermometer.TabIndex = 4;
            // 
            // fuelTank
            // 
            scaleCustomDivision1.Text = "E";
            scaleCustomDivision1.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision2.Text = "1/2";
            scaleCustomDivision2.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision2.Value = 5;
            scaleCustomDivision3.Text = "F";
            scaleCustomDivision3.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision3.Value = 10;
            this.fuelTank.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
                                                                                                        scaleCustomDivision1,
                                                                                                        scaleCustomDivision2,
                                                                                                        scaleCustomDivision3});
            this.fuelTank.Location = new System.Drawing.Point(356, 132);
            this.fuelTank.MajorDivisions.TickVisible = false;
            this.fuelTank.MinorDivisions.TickVisible = false;
            this.fuelTank.Name = "fuelTank";
            this.fuelTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.fuelTank.Size = new System.Drawing.Size(132, 56);
            this.fuelTank.TabIndex = 5;
            this.fuelTank.TankStyle = NationalInstruments.UI.TankStyle.Raised3D;
            this.fuelTank.Value = 9;
            // 
            // altimeterGauge
            // 
            this.altimeterGauge.AutoDivisionSpacing = false;
            scaleCustomDivision4.Value = 10000;
            scaleCustomDivision5.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision5.TickLength = 6F;
            scaleCustomDivision5.Value = 500;
            scaleCustomDivision6.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision6.TickLength = 6F;
            scaleCustomDivision6.Value = 1500;
            scaleCustomDivision7.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision7.TickLength = 6F;
            scaleCustomDivision7.Value = 2500;
            scaleCustomDivision8.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision8.TickLength = 6F;
            scaleCustomDivision8.Value = 3500;
            scaleCustomDivision9.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision9.TickLength = 6F;
            scaleCustomDivision9.Value = 4500;
            scaleCustomDivision10.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision10.TickLength = 6F;
            scaleCustomDivision10.Value = 5500;
            scaleCustomDivision11.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision11.TickLength = 6F;
            scaleCustomDivision11.Value = 6500;
            scaleCustomDivision12.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision12.TickLength = 6F;
            scaleCustomDivision12.Value = 7500;
            scaleCustomDivision13.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision13.TickLength = 6F;
            scaleCustomDivision13.Value = 8500;
            scaleCustomDivision14.TickColor = System.Drawing.SystemColors.ControlText;
            scaleCustomDivision14.TickLength = 6F;
            scaleCustomDivision14.Value = 9500;
            this.altimeterGauge.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
                                                                                                              scaleCustomDivision4,
                                                                                                              scaleCustomDivision5,
                                                                                                              scaleCustomDivision6,
                                                                                                              scaleCustomDivision7,
                                                                                                              scaleCustomDivision8,
                                                                                                              scaleCustomDivision9,
                                                                                                              scaleCustomDivision10,
                                                                                                              scaleCustomDivision11,
                                                                                                              scaleCustomDivision12,
                                                                                                              scaleCustomDivision13,
                                                                                                              scaleCustomDivision14});
            this.altimeterGauge.ImmediateUpdates = true;
            this.altimeterGauge.Location = new System.Drawing.Point(180, 12);
            this.altimeterGauge.MajorDivisions.Interval = 1000;
            this.altimeterGauge.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0,");
            this.altimeterGauge.MajorDivisions.LineWidth = 2F;
            this.altimeterGauge.MajorDivisions.TickLength = 7F;
            this.altimeterGauge.MinorDivisions.Interval = 100;
            this.altimeterGauge.Name = "altimeterGauge";
            this.altimeterGauge.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.altimeterGauge.Range = new NationalInstruments.UI.Range(0, 10000);
            this.altimeterGauge.ScaleArc = new NationalInstruments.UI.Arc(90F, -360F);
            this.altimeterGauge.Size = new System.Drawing.Size(168, 168);
            this.altimeterGauge.TabIndex = 6;
            // 
            // rpmLabel
            // 
            this.rpmLabel.AutoSize = true;
            this.rpmLabel.BackColor = System.Drawing.Color.Transparent;
            this.rpmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.rpmLabel.Location = new System.Drawing.Point(412, 96);
            this.rpmLabel.Name = "rpmLabel";
            this.rpmLabel.Size = new System.Drawing.Size(24, 14);
            this.rpmLabel.TabIndex = 7;
            this.rpmLabel.Text = "RPM";
            // 
            // airspeedLabel
            // 
            this.airspeedLabel.AutoSize = true;
            this.airspeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.airspeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.airspeedLabel.Location = new System.Drawing.Point(72, 116);
            this.airspeedLabel.Name = "airspeedLabel";
            this.airspeedLabel.Size = new System.Drawing.Size(40, 14);
            this.airspeedLabel.TabIndex = 8;
            this.airspeedLabel.Text = "Airspeed";
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.AutoSize = true;
            this.altitudeLabel.BackColor = System.Drawing.Color.Transparent;
            this.altitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.altitudeLabel.Location = new System.Drawing.Point(256, 112);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.Size = new System.Drawing.Size(21, 14);
            this.altitudeLabel.TabIndex = 9;
            this.altitudeLabel.Text = "ALT";
            // 
            // altitude1000Label
            // 
            this.altitude1000Label.AutoSize = true;
            this.altitude1000Label.BackColor = System.Drawing.Color.Transparent;
            this.altitude1000Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.altitude1000Label.Location = new System.Drawing.Point(248, 124);
            this.altitude1000Label.Name = "altitude1000Label";
            this.altitude1000Label.Size = new System.Drawing.Size(38, 14);
            this.altitude1000Label.TabIndex = 10;
            this.altitude1000Label.Text = "X1000 ft";
            // 
            // mphLabel
            // 
            this.mphLabel.AutoSize = true;
            this.mphLabel.BackColor = System.Drawing.Color.Transparent;
            this.mphLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.mphLabel.Location = new System.Drawing.Point(80, 128);
            this.mphLabel.Name = "mphLabel";
            this.mphLabel.Size = new System.Drawing.Size(22, 14);
            this.mphLabel.TabIndex = 11;
            this.mphLabel.Text = "mph";
            // 
            // rpm1000Label
            // 
            this.rpm1000Label.AutoSize = true;
            this.rpm1000Label.BackColor = System.Drawing.Color.Transparent;
            this.rpm1000Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.rpm1000Label.Location = new System.Drawing.Point(412, 108);
            this.rpm1000Label.Name = "rpm1000Label";
            this.rpm1000Label.Size = new System.Drawing.Size(30, 14);
            this.rpm1000Label.TabIndex = 12;
            this.rpm1000Label.Text = "X1000";
            // 
            // masterSwitch
            // 
            this.masterSwitch.Location = new System.Drawing.Point(540, 224);
            this.masterSwitch.Name = "masterSwitch";
            this.masterSwitch.Size = new System.Drawing.Size(56, 84);
            this.masterSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.masterSwitch.TabIndex = 13;
            this.masterSwitch.Value = true;
            this.masterSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.masterSwitch_StateChanged);
            // 
            // masterLabel
            // 
            this.masterLabel.AutoSize = true;
            this.masterLabel.Location = new System.Drawing.Point(548, 204);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(39, 16);
            this.masterLabel.TabIndex = 14;
            this.masterLabel.Text = "Master";
            // 
            // onLabel
            // 
            this.onLabel.AutoSize = true;
            this.onLabel.Location = new System.Drawing.Point(560, 224);
            this.onLabel.Name = "onLabel";
            this.onLabel.Size = new System.Drawing.Size(19, 16);
            this.onLabel.TabIndex = 15;
            this.onLabel.Text = "On";
            // 
            // offLabel
            // 
            this.offLabel.AutoSize = true;
            this.offLabel.Location = new System.Drawing.Point(560, 300);
            this.offLabel.Name = "offLabel";
            this.offLabel.Size = new System.Drawing.Size(19, 16);
            this.offLabel.TabIndex = 16;
            this.offLabel.Text = "Off";
            // 
            // landingLightsKnob
            // 
            this.landingLightsKnob.Caption = "Landing Lights";
            this.landingLightsKnob.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.landingLightsKnob.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.landingLightsKnob.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.landingLightsKnob.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom;
            this.landingLightsKnob.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToDivisions;
            scaleCustomDivision15.Text = "Off";
            scaleCustomDivision16.Text = "Low";
            scaleCustomDivision16.Value = 1;
            scaleCustomDivision17.Text = "Med";
            scaleCustomDivision17.Value = 2;
            scaleCustomDivision18.Text = "High";
            scaleCustomDivision18.Value = 3;
            this.landingLightsKnob.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
                                                                                                                 scaleCustomDivision15,
                                                                                                                 scaleCustomDivision16,
                                                                                                                 scaleCustomDivision17,
                                                                                                                 scaleCustomDivision18});
            this.landingLightsKnob.InteractionMode = NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer;
            this.landingLightsKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle3D;
            this.landingLightsKnob.Location = new System.Drawing.Point(128, 164);
            this.landingLightsKnob.MajorDivisions.LabelVisible = false;
            this.landingLightsKnob.MajorDivisions.TickVisible = false;
            this.landingLightsKnob.MinorDivisions.TickVisible = false;
            this.landingLightsKnob.Name = "landingLightsKnob";
            this.landingLightsKnob.PointerColor = System.Drawing.SystemColors.ControlText;
            this.landingLightsKnob.Range = new NationalInstruments.UI.Range(0, 3);
            this.landingLightsKnob.ScaleArc = new NationalInstruments.UI.Arc(232F, -285F);
            this.landingLightsKnob.Size = new System.Drawing.Size(176, 180);
            this.landingLightsKnob.TabIndex = 17;
            this.landingLightsKnob.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.landingLightsKnob_AfterChangeValue);
            // 
            // startSwitch
            // 
            this.startSwitch.InteractionMode = NationalInstruments.UI.BooleanInteractionMode.SwitchUntilReleased;
            this.startSwitch.Location = new System.Drawing.Point(476, 224);
            this.startSwitch.Name = "startSwitch";
            this.startSwitch.Size = new System.Drawing.Size(56, 84);
            this.startSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.startSwitch.TabIndex = 19;
            this.startSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.startSwitch_StateChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(468, 204);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(66, 16);
            this.startLabel.TabIndex = 20;
            this.startLabel.Text = "Start Engine";
            // 
            // landingLightsLabel
            // 
            this.landingLightsLabel.AutoSize = true;
            this.landingLightsLabel.Location = new System.Drawing.Point(304, 276);
            this.landingLightsLabel.Name = "landingLightsLabel";
            this.landingLightsLabel.Size = new System.Drawing.Size(78, 16);
            this.landingLightsLabel.TabIndex = 21;
            this.landingLightsLabel.Text = "Landing Lights";
            // 
            // throttleLabel
            // 
            this.throttleLabel.AutoSize = true;
            this.throttleLabel.Location = new System.Drawing.Point(304, 244);
            this.throttleLabel.Name = "throttleLabel";
            this.throttleLabel.Size = new System.Drawing.Size(43, 16);
            this.throttleLabel.TabIndex = 23;
            this.throttleLabel.Text = "Throttle";
            // 
            // gphLabel
            // 
            this.gphLabel.AutoSize = true;
            this.gphLabel.Location = new System.Drawing.Point(304, 212);
            this.gphLabel.Name = "gphLabel";
            this.gphLabel.Size = new System.Drawing.Size(29, 16);
            this.gphLabel.TabIndex = 25;
            this.gphLabel.Text = "GPH";
            // 
            // throttleSlide
            // 
            this.throttleSlide.Caption = "Throttle";
            this.throttleSlide.CaptionBackColor = System.Drawing.SystemColors.Control;
            this.throttleSlide.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.throttleSlide.CaptionForeColor = System.Drawing.SystemColors.ControlText;
            this.throttleSlide.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom;
            scaleCustomDivision19.Text = "Idle";
            scaleCustomDivision19.TickColor = System.Drawing.SystemColors.ControlText;
            this.throttleSlide.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
                                                                                                             scaleCustomDivision19});
            this.throttleSlide.Location = new System.Drawing.Point(4, 180);
            this.throttleSlide.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0\'%\'");
            this.throttleSlide.Name = "throttleSlide";
            this.throttleSlide.Range = new NationalInstruments.UI.Range(0, 100);
            this.throttleSlide.Size = new System.Drawing.Size(108, 164);
            this.throttleSlide.SlideStyle = NationalInstruments.UI.SlideStyle.SunkenWithGrip;
            this.throttleSlide.TabIndex = 27;
            this.throttleSlide.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.throttleSlide_AfterChangeValue);
            // 
            // sampleTimer
            // 
            this.sampleTimer.Enabled = true;
            this.sampleTimer.Interval = 1000;
            this.sampleTimer.Tick += new System.EventHandler(this.sampleTimer_Tick);
            // 
            // gphStatusTextBox
            // 
            this.gphStatusTextBox.BackColor = System.Drawing.Color.Lime;
            this.gphStatusTextBox.Location = new System.Drawing.Point(384, 208);
            this.gphStatusTextBox.Name = "gphStatusTextBox";
            this.gphStatusTextBox.ReadOnly = true;
            this.gphStatusTextBox.Size = new System.Drawing.Size(68, 20);
            this.gphStatusTextBox.TabIndex = 28;
            this.gphStatusTextBox.Text = "0";
            // 
            // landingLightsStatusTextBox
            // 
            this.landingLightsStatusTextBox.BackColor = System.Drawing.Color.Red;
            this.landingLightsStatusTextBox.Location = new System.Drawing.Point(384, 272);
            this.landingLightsStatusTextBox.Name = "landingLightsStatusTextBox";
            this.landingLightsStatusTextBox.ReadOnly = true;
            this.landingLightsStatusTextBox.Size = new System.Drawing.Size(68, 20);
            this.landingLightsStatusTextBox.TabIndex = 29;
            this.landingLightsStatusTextBox.Text = "OFF";
            // 
            // throttleStatusTextBox
            // 
            this.throttleStatusTextBox.BackColor = System.Drawing.Color.Lime;
            this.throttleStatusTextBox.Location = new System.Drawing.Point(384, 240);
            this.throttleStatusTextBox.Name = "throttleStatusTextBox";
            this.throttleStatusTextBox.ReadOnly = true;
            this.throttleStatusTextBox.Size = new System.Drawing.Size(68, 20);
            this.throttleStatusTextBox.TabIndex = 30;
            this.throttleStatusTextBox.Text = "Idle";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(604, 349);
            this.Controls.Add(this.throttleStatusTextBox);
            this.Controls.Add(this.landingLightsStatusTextBox);
            this.Controls.Add(this.gphStatusTextBox);
            this.Controls.Add(this.altitude1000Label);
            this.Controls.Add(this.altitudeLabel);
            this.Controls.Add(this.throttleSlide);
            this.Controls.Add(this.gphLabel);
            this.Controls.Add(this.throttleLabel);
            this.Controls.Add(this.landingLightsLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startSwitch);
            this.Controls.Add(this.offLabel);
            this.Controls.Add(this.onLabel);
            this.Controls.Add(this.masterLabel);
            this.Controls.Add(this.masterSwitch);
            this.Controls.Add(this.rpm1000Label);
            this.Controls.Add(this.mphLabel);
            this.Controls.Add(this.airspeedLabel);
            this.Controls.Add(this.rpmLabel);
            this.Controls.Add(this.fuelTank);
            this.Controls.Add(this.engineThermometer);
            this.Controls.Add(this.airspeedGauge);
            this.Controls.Add(this.tachMeter);
            this.Controls.Add(this.altimeterGauge);
            this.Controls.Add(this.landingLightsKnob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Advanced";
            ((System.ComponentModel.ISupportInitialize)(this.tachMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airspeedGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.engineThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altimeterGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.landingLightsKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.throttleSlide)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion


		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

        private void UpdateEngineStatus(double throttle)
        {
            if(engineRunning)
            {
                throttleStatusTextBox.BackColor = Color.Lime;
                if(throttle == 0)
                    throttleStatusTextBox.Text = "Idle";
                else
                    throttleStatusTextBox.Text = String.Format("{0:0}%", throttle);
            }
        }

        private void ResetGauges()
        {
            tachMeter.Value = 0;
            airspeedGauge.Value = 0;
            altimeterGauge.Value = 0;
            engineThermometer.Value = 0;
            throttleStatusTextBox.BackColor = Color.Red;
            throttleStatusTextBox.Text = "OFF";
            gphStatusTextBox.BackColor = Color.Lime;
            gphStatusTextBox.Text = "0";
        }

        private void startSwitch_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            if(startSwitch.Value)
            {
                engineRunning = true;
                UpdateEngineStatus(throttleSlide.Value);
            }
        }

        private void masterSwitch_StateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            // master switch kills engine and all electronics.  Master switch
            // must be on to start engine.
            if(!masterSwitch.Value)
            {
                engineRunning = false;
                startSwitch.Enabled = false;
                ResetGauges();
            }
            else
            {
                startSwitch.Enabled = true;
            }
        }

        private void throttleSlide_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            UpdateEngineStatus(e.NewValue);
        }

        private void landingLightsKnob_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            switch((int)e.NewValue)
            {
                case 0:
                    landingLightsStatusTextBox.BackColor = Color.Red;
                    landingLightsStatusTextBox.Text = "OFF";
                    break;
                case 1:
                    landingLightsStatusTextBox.BackColor = Color.Lime;
                    landingLightsStatusTextBox.Text = "Low";
                    break;
                case 2:
                    landingLightsStatusTextBox.BackColor = Color.Lime;
                    landingLightsStatusTextBox.Text = "Med";
                    break;
                case 3:
                    landingLightsStatusTextBox.BackColor = Color.Lime;
                    landingLightsStatusTextBox.Text = "High";
                    break;
                default:
                    Debug.Fail("Not a valid landing light value");
                    break;
            }
        }

        private void sampleTimer_Tick(object sender, System.EventArgs e)
        {
            if(engineRunning)
            {
                double throttlePercent = throttleSlide.Value / 100;
                tachMeter.Value = (6000 * throttlePercent) + 1000 + (rand.Next(-100, 100));
                airspeedGauge.Value = airspeedGauge.Value + ((throttlePercent * 100) - airspeedGauge.Value) * .4 + rand.Next(-3, 3);
                altimeterGauge.Value = altimeterGauge.Value + ((throttlePercent * 7000) - altimeterGauge.Value) * .2 + rand.Next(-30, 30);
                engineThermometer.Value = engineThermometer.Value + (350 - engineThermometer.Value) * .1;
                
                double gph = (5 * throttlePercent) + 1;
                if(gph > 5)
                    gphStatusTextBox.BackColor = Color.Red;
                else
                    gphStatusTextBox.BackColor = Color.Lime;

                gphStatusTextBox.Text = String.Format("{0:F2}", gph);                
                fuelTank.Value -= gph / 3600; //convert to gallons per second.
            }
        }
        
	}
}
