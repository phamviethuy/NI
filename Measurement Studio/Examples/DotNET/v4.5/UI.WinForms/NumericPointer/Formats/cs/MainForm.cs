using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Formats
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.Slide voltSlide;
        private NationalInstruments.UI.WindowsForms.Slide ohmSlide;
        private NationalInstruments.UI.WindowsForms.Slide powerLimitSlide;
        private NationalInstruments.UI.WindowsForms.Gauge powerGauge;
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
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision1 = new NationalInstruments.UI.ScaleCustomDivision();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.voltSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.ohmSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.powerLimitSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.powerGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            ((System.ComponentModel.ISupportInitialize)(this.voltSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohmSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerLimitSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerGauge)).BeginInit();
            this.SuspendLayout();
            // 
            // voltSlide
            // 
            this.voltSlide.Caption = "Volts";
            this.voltSlide.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom;
            this.voltSlide.FillBaseValue = 5;
            this.voltSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum;
            this.voltSlide.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient;
            this.voltSlide.InvertedScale = true;
            this.voltSlide.Location = new System.Drawing.Point(0, 88);
            this.voltSlide.MajorDivisions.Interval = 1;
            this.voltSlide.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S\'V\'");
            this.voltSlide.Name = "voltSlide";
            this.voltSlide.Range = new NationalInstruments.UI.Range(0, 20);
            this.voltSlide.Size = new System.Drawing.Size(88, 232);
            this.voltSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip;
            this.voltSlide.TabIndex = 24;
            this.voltSlide.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.voltSlide_BeforeChangeValue);
            this.voltSlide.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.voltSlide_AfterChangeValue);
            // 
            // ohmSlide
            // 
            this.ohmSlide.Caption = "Resistance";
            this.ohmSlide.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom;
            this.ohmSlide.CoercionIntervalBase = 0;
            this.ohmSlide.FillBaseValue = 5;
            this.ohmSlide.FillMode = NationalInstruments.UI.NumericFillMode.ToMaximum;
            this.ohmSlide.FillStyle = NationalInstruments.UI.FillStyle.VerticalGradient;
            this.ohmSlide.InvertedScale = true;
            this.ohmSlide.Location = new System.Drawing.Point(96, 88);
            this.ohmSlide.MajorDivisions.Interval = 1;
            this.ohmSlide.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S\' Ohm\'");
            this.ohmSlide.Name = "ohmSlide";
            this.ohmSlide.Range = new NationalInstruments.UI.Range(1, 10);
            this.ohmSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Right;
            this.ohmSlide.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.ohmSlide.Size = new System.Drawing.Size(109, 232);
            this.ohmSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip;
            this.ohmSlide.TabIndex = 25;
            this.ohmSlide.Value = 1;
            this.ohmSlide.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.ohmSlide_BeforeChangeValue);
            this.ohmSlide.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.ohmSlide_AfterChangeValue);
            // 
            // powerLimitSlide
            // 
            this.powerLimitSlide.Caption = "Power Limit";
            this.powerLimitSlide.FillBaseValue = 5;
            this.powerLimitSlide.FillStyle = NationalInstruments.UI.FillStyle.HorizontalGradient;
            this.powerLimitSlide.Location = new System.Drawing.Point(8, 0);
            this.powerLimitSlide.MajorDivisions.Interval = 1000;
            this.powerLimitSlide.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Engineering, "S\'W\'");
            this.powerLimitSlide.Name = "powerLimitSlide";
            this.powerLimitSlide.Range = new NationalInstruments.UI.Range(1, 400);
            this.powerLimitSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Top;
            this.powerLimitSlide.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.powerLimitSlide.Size = new System.Drawing.Size(440, 72);
            this.powerLimitSlide.SlideStyle = NationalInstruments.UI.SlideStyle.RaisedWithRoundedGrip;
            this.powerLimitSlide.TabIndex = 26;
            this.powerLimitSlide.Value = 400;
            this.powerLimitSlide.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.powerLimitSlide_BeforeChangeValue);
            this.powerLimitSlide.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.powerLimitSlide_AfterChangeValue);
            // 
            // powerGauge
            // 
            this.powerGauge.AutoDivisionSpacing = false;
            this.powerGauge.Caption = "Power";
            this.powerGauge.CaptionPosition = NationalInstruments.UI.CaptionPosition.Bottom;
            scaleCustomDivision1.LabelVisible = false;
            scaleCustomDivision1.LineWidth = 5F;
            scaleCustomDivision1.TickLength = 10F;
            scaleCustomDivision1.Value = 400;
            this.powerGauge.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
                                                                                                          scaleCustomDivision1});
            this.powerGauge.Location = new System.Drawing.Point(224, 80);
            this.powerGauge.MajorDivisions.Interval = 40;
            this.powerGauge.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.Numeric, "0 W");
            this.powerGauge.MinorDivisions.Interval = 10;
            this.powerGauge.Name = "powerGauge";
            this.powerGauge.Range = new NationalInstruments.UI.Range(0, 400);
            this.powerGauge.Size = new System.Drawing.Size(232, 240);
            this.powerGauge.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(456, 346);
            this.Controls.Add(this.powerGauge);
            this.Controls.Add(this.powerLimitSlide);
            this.Controls.Add(this.ohmSlide);
            this.Controls.Add(this.voltSlide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Numeric Pointer Formats";
            ((System.ComponentModel.ISupportInitialize)(this.voltSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ohmSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerLimitSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.powerGauge)).EndInit();
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

        private void powerLimitSlide_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            powerGauge.CustomDivisions[0].Value = e.NewValue;
        }

        private void voltSlide_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            powerGauge.Value = GetPower(e.NewValue, ohmSlide.Value);
        }

        private void ohmSlide_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            powerGauge.Value = GetPower(voltSlide.Value, e.NewValue);
        }

        private void voltSlide_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            double power = GetPower(e.NewValue, ohmSlide.Value);
            e.Cancel = (power > powerGauge.CustomDivisions[0].Value);
        }

        private void ohmSlide_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            double power = GetPower(voltSlide.Value, e.NewValue);
            e.Cancel = (power > powerGauge.CustomDivisions[0].Value);

        }

        private void powerLimitSlide_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            e.Cancel = (e.NewValue < powerGauge.Value);
        }

        private static double GetPower(double voltage, double resistance)
        {
            return (voltage * voltage) / resistance;
        }
    }
}
