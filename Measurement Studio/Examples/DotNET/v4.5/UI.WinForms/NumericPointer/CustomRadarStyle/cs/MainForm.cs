using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NationalInstruments.Examples.CustomRadarStyle
{
	public class MainForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Timer radarTimer;
        private NationalInstruments.UI.WindowsForms.Gauge radarGauge;
        private System.ComponentModel.IContainer components;

		public MainForm()
		{
			InitializeComponent();
            radarGauge.GaugeStyle = new CustomRadarStyle();
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
            this.radarGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.radarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radarGauge)).BeginInit();
            this.SuspendLayout();
            // 
            // radarGauge
            // 
            this.radarGauge.DialColor = System.Drawing.Color.Black;
            this.radarGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radarGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThinNeedle3D;
            this.radarGauge.Location = new System.Drawing.Point(0, 0);
            this.radarGauge.Name = "radarGauge";
            this.radarGauge.PointerColor = System.Drawing.Color.White;
            this.radarGauge.ScaleArc = new NationalInstruments.UI.Arc(270F, -360F);
            this.radarGauge.ScaleVisible = false;
            this.radarGauge.Size = new System.Drawing.Size(292, 273);
            this.radarGauge.SpindleVisible = false;
            this.radarGauge.TabIndex = 0;
            // 
            // radarTimer
            // 
            this.radarTimer.Enabled = true;
            this.radarTimer.Interval = 50;
            this.radarTimer.Tick += new System.EventHandler(this.radarTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.radarGauge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Radar Style";
            ((System.ComponentModel.ISupportInitialize)(this.radarGauge)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new MainForm());
		}

        private void radarTimer_Tick(object sender, System.EventArgs e)
        {
            double gaugeValue = radarGauge.Value + .1;

            if(gaugeValue > 10)
                gaugeValue = 0;
            radarGauge.Value = gaugeValue;
        }
	}
}
