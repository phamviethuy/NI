using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomStyles
{
	public class MainForm : System.Windows.Forms.Form
	{
        private LineStyle defaultLineStyle;
        private LineStyle customLineStyle;
        private PointStyle defaultPointStyle;
        private PointStyle customPointStyle;
        private Size defaultPointSize;
        private Size customPointSize;
        private Border defaultBorder;
        private Border customBorder;

        
        private System.Windows.Forms.GroupBox lineStyleGroupBox;
        private System.Windows.Forms.RadioButton customLineStyleRadioButton;
        private System.Windows.Forms.RadioButton defaultLineStyleRadioButton;
        private System.Windows.Forms.GroupBox pointStyleGroupBox;
        private System.Windows.Forms.RadioButton defaultPointStyleRadioButton;
        private System.Windows.Forms.RadioButton customPointStyleRadioButton;
        private System.Windows.Forms.CheckBox disabledPointStyleCheckBox;
        private System.Windows.Forms.RadioButton defaultBorderRadioButton;
        private System.Windows.Forms.RadioButton customBorderRadioButton;
        private System.Windows.Forms.CheckBox disabledBorderCheckBox;
        private System.Windows.Forms.CheckBox disabledLineStyleCheckBox;
        private System.Windows.Forms.GroupBox pointSizeGroupBox;
        private System.Windows.Forms.RadioButton defaultPointSizeRadioButton;
        private System.Windows.Forms.RadioButton customPointSizeRadioButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.GroupBox borderGroupBox;
		private NationalInstruments.UI.XAxis xAxis;
		private NationalInstruments.UI.YAxis yAxis;
		private NationalInstruments.UI.WaveformPlot plot;
		private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            plot.PlotY(GenerateSineWave(100, 10));		

            // Save default values and create custom values
            defaultLineStyle = plot.LineStyle;
            customLineStyle = new CustomLineStyle();
            defaultPointStyle = plot.PointStyle;
            customPointStyle = new CustomPointStyle();
            defaultPointSize = plot.PointSize;
            customPointSize = new Size(defaultPointSize.Width + 2, defaultPointSize.Height + 2);
            defaultBorder = sampleWaveformGraph.Border;
            customBorder = new CustomBorder();			
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lineStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.disabledLineStyleCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultLineStyleRadioButton = new System.Windows.Forms.RadioButton();
            this.customLineStyleRadioButton = new System.Windows.Forms.RadioButton();
            this.pointStyleGroupBox = new System.Windows.Forms.GroupBox();
            this.disabledPointStyleCheckBox = new System.Windows.Forms.CheckBox();
            this.customPointStyleRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultPointStyleRadioButton = new System.Windows.Forms.RadioButton();
            this.borderGroupBox = new System.Windows.Forms.GroupBox();
            this.disabledBorderCheckBox = new System.Windows.Forms.CheckBox();
            this.customBorderRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultBorderRadioButton = new System.Windows.Forms.RadioButton();
            this.pointSizeGroupBox = new System.Windows.Forms.GroupBox();
            this.customPointSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.defaultPointSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.plot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.lineStyleGroupBox.SuspendLayout();
            this.pointStyleGroupBox.SuspendLayout();
            this.borderGroupBox.SuspendLayout();
            this.pointSizeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // lineStyleGroupBox
            // 
            this.lineStyleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineStyleGroupBox.Controls.Add(this.disabledLineStyleCheckBox);
            this.lineStyleGroupBox.Controls.Add(this.defaultLineStyleRadioButton);
            this.lineStyleGroupBox.Controls.Add(this.customLineStyleRadioButton);
            this.lineStyleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineStyleGroupBox.Location = new System.Drawing.Point(8, 288);
            this.lineStyleGroupBox.Name = "lineStyleGroupBox";
            this.lineStyleGroupBox.Size = new System.Drawing.Size(184, 80);
            this.lineStyleGroupBox.TabIndex = 1;
            this.lineStyleGroupBox.TabStop = false;
            this.lineStyleGroupBox.Text = "Line Style";
            // 
            // disabledLineStyleCheckBox
            // 
            this.disabledLineStyleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.disabledLineStyleCheckBox.Location = new System.Drawing.Point(96, 24);
            this.disabledLineStyleCheckBox.Name = "disabledLineStyleCheckBox";
            this.disabledLineStyleCheckBox.Size = new System.Drawing.Size(80, 24);
            this.disabledLineStyleCheckBox.TabIndex = 4;
            this.disabledLineStyleCheckBox.Text = "Disabled";
            this.toolTip.SetToolTip(this.disabledLineStyleCheckBox, "Disable line style");
            this.disabledLineStyleCheckBox.CheckedChanged += new System.EventHandler(this.OnLineStyleChanged);
            // 
            // defaultLineStyleRadioButton
            // 
            this.defaultLineStyleRadioButton.Checked = true;
            this.defaultLineStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultLineStyleRadioButton.Location = new System.Drawing.Point(8, 24);
            this.defaultLineStyleRadioButton.Name = "defaultLineStyleRadioButton";
            this.defaultLineStyleRadioButton.Size = new System.Drawing.Size(80, 24);
            this.defaultLineStyleRadioButton.TabIndex = 2;
            this.defaultLineStyleRadioButton.TabStop = true;
            this.defaultLineStyleRadioButton.Text = "Default";
            this.toolTip.SetToolTip(this.defaultLineStyleRadioButton, "Set the line style to its default value");
            this.defaultLineStyleRadioButton.CheckedChanged += new System.EventHandler(this.OnLineStyleChanged);
            // 
            // customLineStyleRadioButton
            // 
            this.customLineStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customLineStyleRadioButton.Location = new System.Drawing.Point(8, 48);
            this.customLineStyleRadioButton.Name = "customLineStyleRadioButton";
            this.customLineStyleRadioButton.Size = new System.Drawing.Size(80, 24);
            this.customLineStyleRadioButton.TabIndex = 3;
            this.customLineStyleRadioButton.TabStop = true;
            this.customLineStyleRadioButton.Text = "Custom";
            this.toolTip.SetToolTip(this.customLineStyleRadioButton, "Set the line style to a custom value");
            this.customLineStyleRadioButton.CheckedChanged += new System.EventHandler(this.OnLineStyleChanged);
            // 
            // pointStyleGroupBox
            // 
            this.pointStyleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pointStyleGroupBox.Controls.Add(this.disabledPointStyleCheckBox);
            this.pointStyleGroupBox.Controls.Add(this.customPointStyleRadioButton);
            this.pointStyleGroupBox.Controls.Add(this.defaultPointStyleRadioButton);
            this.pointStyleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pointStyleGroupBox.Location = new System.Drawing.Point(208, 288);
            this.pointStyleGroupBox.Name = "pointStyleGroupBox";
            this.pointStyleGroupBox.Size = new System.Drawing.Size(184, 80);
            this.pointStyleGroupBox.TabIndex = 5;
            this.pointStyleGroupBox.TabStop = false;
            this.pointStyleGroupBox.Text = "Point Style";
            // 
            // disabledPointStyleCheckBox
            // 
            this.disabledPointStyleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.disabledPointStyleCheckBox.Location = new System.Drawing.Point(96, 24);
            this.disabledPointStyleCheckBox.Name = "disabledPointStyleCheckBox";
            this.disabledPointStyleCheckBox.Size = new System.Drawing.Size(80, 24);
            this.disabledPointStyleCheckBox.TabIndex = 8;
            this.disabledPointStyleCheckBox.Text = "Disabled";
            this.toolTip.SetToolTip(this.disabledPointStyleCheckBox, "Disable point style");
            this.disabledPointStyleCheckBox.CheckedChanged += new System.EventHandler(this.OnPointStyleChanged);
            // 
            // customPointStyleRadioButton
            // 
            this.customPointStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customPointStyleRadioButton.Location = new System.Drawing.Point(16, 48);
            this.customPointStyleRadioButton.Name = "customPointStyleRadioButton";
            this.customPointStyleRadioButton.Size = new System.Drawing.Size(72, 24);
            this.customPointStyleRadioButton.TabIndex = 7;
            this.customPointStyleRadioButton.TabStop = true;
            this.customPointStyleRadioButton.Text = "Custom";
            this.toolTip.SetToolTip(this.customPointStyleRadioButton, "Set the point style to a custom value");
            this.customPointStyleRadioButton.CheckedChanged += new System.EventHandler(this.OnPointStyleChanged);
            // 
            // defaultPointStyleRadioButton
            // 
            this.defaultPointStyleRadioButton.Checked = true;
            this.defaultPointStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultPointStyleRadioButton.Location = new System.Drawing.Point(16, 24);
            this.defaultPointStyleRadioButton.Name = "defaultPointStyleRadioButton";
            this.defaultPointStyleRadioButton.Size = new System.Drawing.Size(72, 24);
            this.defaultPointStyleRadioButton.TabIndex = 6;
            this.defaultPointStyleRadioButton.TabStop = true;
            this.defaultPointStyleRadioButton.Text = "Default";
            this.toolTip.SetToolTip(this.defaultPointStyleRadioButton, "Set the point style to its default value");
            this.defaultPointStyleRadioButton.CheckedChanged += new System.EventHandler(this.OnPointStyleChanged);
            // 
            // borderGroupBox
            // 
            this.borderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.borderGroupBox.Controls.Add(this.disabledBorderCheckBox);
            this.borderGroupBox.Controls.Add(this.customBorderRadioButton);
            this.borderGroupBox.Controls.Add(this.defaultBorderRadioButton);
            this.borderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.borderGroupBox.Location = new System.Drawing.Point(8, 376);
            this.borderGroupBox.Name = "borderGroupBox";
            this.borderGroupBox.Size = new System.Drawing.Size(184, 80);
            this.borderGroupBox.TabIndex = 9;
            this.borderGroupBox.TabStop = false;
            this.borderGroupBox.Text = "Border";
            // 
            // disabledBorderCheckBox
            // 
            this.disabledBorderCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.disabledBorderCheckBox.Location = new System.Drawing.Point(96, 24);
            this.disabledBorderCheckBox.Name = "disabledBorderCheckBox";
            this.disabledBorderCheckBox.Size = new System.Drawing.Size(80, 24);
            this.disabledBorderCheckBox.TabIndex = 12;
            this.disabledBorderCheckBox.Text = "Disabled";
            this.toolTip.SetToolTip(this.disabledBorderCheckBox, "Disable graph border");
            this.disabledBorderCheckBox.CheckedChanged += new System.EventHandler(this.OnBorderChanged);
            // 
            // customBorderRadioButton
            // 
            this.customBorderRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customBorderRadioButton.Location = new System.Drawing.Point(8, 48);
            this.customBorderRadioButton.Name = "customBorderRadioButton";
            this.customBorderRadioButton.Size = new System.Drawing.Size(80, 24);
            this.customBorderRadioButton.TabIndex = 11;
            this.customBorderRadioButton.TabStop = true;
            this.customBorderRadioButton.Text = "Custom";
            this.toolTip.SetToolTip(this.customBorderRadioButton, "Set the border to a custom value");
            this.customBorderRadioButton.CheckedChanged += new System.EventHandler(this.OnBorderChanged);
            // 
            // defaultBorderRadioButton
            // 
            this.defaultBorderRadioButton.Checked = true;
            this.defaultBorderRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultBorderRadioButton.Location = new System.Drawing.Point(8, 24);
            this.defaultBorderRadioButton.Name = "defaultBorderRadioButton";
            this.defaultBorderRadioButton.Size = new System.Drawing.Size(80, 24);
            this.defaultBorderRadioButton.TabIndex = 10;
            this.defaultBorderRadioButton.TabStop = true;
            this.defaultBorderRadioButton.Text = "Default";
            this.toolTip.SetToolTip(this.defaultBorderRadioButton, "Set the border to its default value");
            this.defaultBorderRadioButton.CheckedChanged += new System.EventHandler(this.OnBorderChanged);
            // 
            // pointSizeGroupBox
            // 
            this.pointSizeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pointSizeGroupBox.Controls.Add(this.customPointSizeRadioButton);
            this.pointSizeGroupBox.Controls.Add(this.defaultPointSizeRadioButton);
            this.pointSizeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pointSizeGroupBox.Location = new System.Drawing.Point(208, 376);
            this.pointSizeGroupBox.Name = "pointSizeGroupBox";
            this.pointSizeGroupBox.Size = new System.Drawing.Size(184, 80);
            this.pointSizeGroupBox.TabIndex = 13;
            this.pointSizeGroupBox.TabStop = false;
            this.pointSizeGroupBox.Text = "Point Size";
            // 
            // customPointSizeRadioButton
            // 
            this.customPointSizeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customPointSizeRadioButton.Location = new System.Drawing.Point(16, 48);
            this.customPointSizeRadioButton.Name = "customPointSizeRadioButton";
            this.customPointSizeRadioButton.Size = new System.Drawing.Size(64, 24);
            this.customPointSizeRadioButton.TabIndex = 15;
            this.customPointSizeRadioButton.TabStop = true;
            this.customPointSizeRadioButton.Text = "Custom";
            this.toolTip.SetToolTip(this.customPointSizeRadioButton, "Set the point size to a custom value");
            this.customPointSizeRadioButton.CheckedChanged += new System.EventHandler(this.OnPointSizeChanged);
            // 
            // defaultPointSizeRadioButton
            // 
            this.defaultPointSizeRadioButton.Checked = true;
            this.defaultPointSizeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultPointSizeRadioButton.Location = new System.Drawing.Point(16, 24);
            this.defaultPointSizeRadioButton.Name = "defaultPointSizeRadioButton";
            this.defaultPointSizeRadioButton.Size = new System.Drawing.Size(64, 24);
            this.defaultPointSizeRadioButton.TabIndex = 14;
            this.defaultPointSizeRadioButton.TabStop = true;
            this.defaultPointSizeRadioButton.Text = "Default";
            this.toolTip.SetToolTip(this.defaultPointSizeRadioButton, "Set the point size to its default value");
            this.defaultPointSizeRadioButton.CheckedChanged += new System.EventHandler(this.OnPointSizeChanged);
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Caption = "Waveform Graph";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(16, 16);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.plot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(368, 256);
            this.sampleWaveformGraph.TabIndex = 14;
            this.toolTip.SetToolTip(this.sampleWaveformGraph, "National Instruments Waveform Graph");
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // plot
            // 
            this.plot.PointSize = new System.Drawing.Size(3, 3);
            this.plot.PointStyle = NationalInstruments.UI.PointStyle.SolidDiamond;
            this.plot.XAxis = this.xAxis;
            this.plot.YAxis = this.yAxis;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(402, 464);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.borderGroupBox);
            this.Controls.Add(this.pointStyleGroupBox);
            this.Controls.Add(this.lineStyleGroupBox);
            this.Controls.Add(this.pointSizeGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(408, 496);
            this.Name = "MainForm";
            this.Text = "Custom Styles Example";
            this.lineStyleGroupBox.ResumeLayout(false);
            this.pointStyleGroupBox.ResumeLayout(false);
            this.borderGroupBox.ResumeLayout(false);
            this.pointSizeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        private static double[] GenerateSineWave(int xRange, int yRange)
        {
            if (xRange < 0)
            {
                throw new ArgumentOutOfRangeException("xRange");
            }

            if (yRange < 0)
            {
                throw new ArgumentOutOfRangeException("yRange");
            }

            double[] data = new double[xRange];
            for (int i = 0; i < xRange; ++i)
            {
                data[i] = yRange / 2 * (1 - (float) Math.Sin(i * 2 * Math.PI / (xRange - 1)));
            }

            return data;
        }

        private void OnLineStyleChanged(object sender, System.EventArgs e)
        {
            SetLineStyle();
        }

        private void OnPointStyleChanged(object sender, System.EventArgs e)
        {
            SetPointStyle();
        }

        private void OnPointSizeChanged(object sender, System.EventArgs e)
        {
            SetPointSize();
        }

        private void OnBorderChanged(object sender, System.EventArgs e)
        {
            SetBorder();
        }

        private void SetLineStyle()
        {
            if (disabledLineStyleCheckBox.Checked)
            {
                plot.LineStyle = LineStyle.None;
            }
            else
            {
                if (defaultLineStyleRadioButton.Checked)
                {
                    plot.LineStyle = defaultLineStyle;
                }
                else if (customLineStyleRadioButton.Checked)
                {
                    plot.LineStyle = customLineStyle;
                }
            }
        }

        private void SetPointStyle()
        {
            if (disabledPointStyleCheckBox.Checked)
            {
                plot.PointStyle = PointStyle.None;
				pointSizeGroupBox.Enabled = false;
            }
            else
            {
				pointSizeGroupBox.Enabled = true;
                if (defaultPointStyleRadioButton.Checked)
                {
                    plot.PointStyle = defaultPointStyle;					
                }
                else if (customPointStyleRadioButton.Checked)
                {
                    plot.PointStyle = customPointStyle;					
                }
            }
        }

        private void SetPointSize()
        {
            if (defaultPointSizeRadioButton.Checked)
            {
                plot.PointSize = defaultPointSize;
            }
            else if (customPointSizeRadioButton.Checked)
            {
                plot.PointSize = customPointSize;
            }
        }

        private void SetBorder()
        {
            if (disabledBorderCheckBox.Checked)
            {
                sampleWaveformGraph.Border = Border.None;
            }
            else
            {
                if (defaultBorderRadioButton.Checked)
                {
                    sampleWaveformGraph.Border = defaultBorder;
                }
                else
                {
                    sampleWaveformGraph.Border = customBorder;
                }
            }
        }


        private class CustomBorder : Border
        {
            public override void Draw(object context, BorderDrawArgs args)
            {
                Graphics g = args.Graphics;
                Rectangle bounds = args.Bounds;

                using (Pen pen = new Pen(SystemColors.ActiveCaption))
                {
                    Rectangle borderRectangle = new Rectangle(bounds.X + 1, bounds.Y + 1, bounds.X + bounds.Width - 2, bounds.Y + bounds.Height - 2);
                    g.DrawRectangle(pen, borderRectangle);

                    borderRectangle.Inflate(-2, -2);
                    g.DrawRectangle(pen, borderRectangle);
                }
            }

            public override Rectangle GetInnerRectangle(Rectangle outerRectangle)
            {
                Rectangle innerRectangle = outerRectangle;
                innerRectangle.Inflate(-5, -5);

                return innerRectangle;
            }
        }

        private class CustomLineStyle : LineStyle
        {
            public CustomLineStyle()
            {
            }

            public override bool IsContextDependent
            {
                get
                {
                    return true;
                }
            }

            public override Pen CreatePen(object context, LineStyleDrawArgs args)
            {
                Rectangle bounds = args.ContextBounds;

                bounds.Width += 1;
                bounds.Height += 1;

                using (Brush brush = new LinearGradientBrush(bounds, Color.Red, Color.Blue, LinearGradientMode.Vertical))
                {
                    return new Pen(brush, args.Width);
                }
            }
        }

        private class CustomPointStyle : PointStyle
        {
            public override void Draw(object context, PointStyleDrawArgs args)
            {
                if (args.Y < 3)
                {
                    PointStyle.SolidSquare.Draw(context, CreateDrawArgs(args, Color.Red));
                }
                else if (args.Y < 7)
                {
                    PointStyle.EmptySquare.Draw(context, CreateDrawArgs(args, Color.Yellow));
                }
                else
                {
                    PointStyle.Plus.Draw(context, CreateDrawArgs(args, Color.LightBlue));
                }
            }

            public override bool IsValueDependent
            {
                get { return true; }
            }

            private static PointStyleDrawArgs CreateDrawArgs(PointStyleDrawArgs args, Color color)
            {
                return new PointStyleDrawArgs(args.Graphics, args.X, args.Y, color, args.Size);
            }
        }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}
	}
}
