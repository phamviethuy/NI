using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.CustomAxisDrawing
{
	/// <summary>
	/// Summary description for MainForm
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
    	/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.ColorDialog customAxesColorDialog;
		private System.Windows.Forms.Panel settingsPanel;
		private System.Windows.Forms.Label colorLabel;
		private System.Windows.Forms.Button colorButton;
		private System.Windows.Forms.GroupBox customYAxisGroupBox;
		private System.Windows.Forms.Label yPositionLabel;
		private System.Windows.Forms.GroupBox customXAxisGroupBox;
		private System.Windows.Forms.Label xPositionLabel;
		private NationalInstruments.UI.ComplexPlot complexPlot;
		private NationalInstruments.UI.ComplexXAxis xAxis;
		private NationalInstruments.UI.ComplexYAxis yAxis;
		private System.Windows.Forms.Splitter vertSplitter;
       
		private Color customAxesColor;
		private XAxisPosition xAxisPosition;
		private YAxisPosition yAxisPosition;
		private const int minorDivisionsTickLength = 3;
		private const int majorDivisionsTickLength = 10;
        private NationalInstruments.UI.WindowsForms.Led customAxesColorIndicatorLed;
        private System.Windows.Forms.CheckBox customYAxisMinorCheckBox;
        private System.Windows.Forms.CheckBox customYAxisMajorCheckBox;
        private System.Windows.Forms.ComboBox customYAxisPositionComboBox;
        private System.Windows.Forms.CheckBox customXAxisMinorCheckBox;
        private System.Windows.Forms.CheckBox customXAxisMajorCheckBox;
        private System.Windows.Forms.ComboBox customXAxisPositionComboBox;
        private NationalInstruments.UI.WindowsForms.ComplexGraph sampleComplexGraph;
		private const int customAxisDimension = 20;

		public MainForm()
		{
			InitializeComponent();

			customAxesColor = Color.Lime;
			UpdateCustomAxesColors();
			customXAxisPositionComboBox.SelectedIndex = 0;
			customYAxisPositionComboBox.SelectedIndex = 0;
			sampleComplexGraph.PlotComplex(GenerateDefaultData());
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
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.customAxesColorIndicatorLed = new NationalInstruments.UI.WindowsForms.Led();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorButton = new System.Windows.Forms.Button();
            this.customYAxisGroupBox = new System.Windows.Forms.GroupBox();
            this.yPositionLabel = new System.Windows.Forms.Label();
            this.customYAxisMinorCheckBox = new System.Windows.Forms.CheckBox();
            this.customYAxisMajorCheckBox = new System.Windows.Forms.CheckBox();
            this.customYAxisPositionComboBox = new System.Windows.Forms.ComboBox();
            this.customXAxisGroupBox = new System.Windows.Forms.GroupBox();
            this.xPositionLabel = new System.Windows.Forms.Label();
            this.customXAxisMinorCheckBox = new System.Windows.Forms.CheckBox();
            this.customXAxisMajorCheckBox = new System.Windows.Forms.CheckBox();
            this.customXAxisPositionComboBox = new System.Windows.Forms.ComboBox();
            this.sampleComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.complexPlot = new NationalInstruments.UI.ComplexPlot();
            this.xAxis = new NationalInstruments.UI.ComplexXAxis();
            this.yAxis = new NationalInstruments.UI.ComplexYAxis();
            this.customAxesColorDialog = new System.Windows.Forms.ColorDialog();
            this.vertSplitter = new System.Windows.Forms.Splitter();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customAxesColorIndicatorLed)).BeginInit();
            this.customYAxisGroupBox.SuspendLayout();
            this.customXAxisGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoScroll = true;
            this.settingsPanel.Controls.Add(this.customAxesColorIndicatorLed);
            this.settingsPanel.Controls.Add(this.colorLabel);
            this.settingsPanel.Controls.Add(this.colorButton);
            this.settingsPanel.Controls.Add(this.customYAxisGroupBox);
            this.settingsPanel.Controls.Add(this.customXAxisGroupBox);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(208, 334);
            this.settingsPanel.TabIndex = 0;
            // 
            // customAxesColorIndicatorLed
            // 
            this.customAxesColorIndicatorLed.LedStyle = NationalInstruments.UI.LedStyle.Square;
            this.customAxesColorIndicatorLed.Location = new System.Drawing.Point(128, 4);
            this.customAxesColorIndicatorLed.Name = "customAxesColorIndicatorLed";
            this.customAxesColorIndicatorLed.Size = new System.Drawing.Size(32, 24);
            this.customAxesColorIndicatorLed.TabIndex = 8;
            this.customAxesColorIndicatorLed.TabStop = false;
            this.customAxesColorIndicatorLed.Value = true;
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(16, 8);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(112, 16);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.Text = "Custom Axes Colors:";
            // 
            // colorButton
            // 
            this.colorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorButton.Location = new System.Drawing.Point(160, 8);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(32, 16);
            this.colorButton.TabIndex = 0;
            this.colorButton.Text = "...";
            this.colorButton.Click += new System.EventHandler(this.OnColorButton);
            // 
            // customYAxisGroupBox
            // 
            this.customYAxisGroupBox.Controls.Add(this.yPositionLabel);
            this.customYAxisGroupBox.Controls.Add(this.customYAxisMinorCheckBox);
            this.customYAxisGroupBox.Controls.Add(this.customYAxisMajorCheckBox);
            this.customYAxisGroupBox.Controls.Add(this.customYAxisPositionComboBox);
            this.customYAxisGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customYAxisGroupBox.Location = new System.Drawing.Point(8, 176);
            this.customYAxisGroupBox.Name = "customYAxisGroupBox";
            this.customYAxisGroupBox.Size = new System.Drawing.Size(184, 144);
            this.customYAxisGroupBox.TabIndex = 5;
            this.customYAxisGroupBox.TabStop = false;
            this.customYAxisGroupBox.Text = "Custom YAxis";
            // 
            // yPositionLabel
            // 
            this.yPositionLabel.Location = new System.Drawing.Point(16, 16);
            this.yPositionLabel.Name = "yPositionLabel";
            this.yPositionLabel.Size = new System.Drawing.Size(120, 16);
            this.yPositionLabel.TabIndex = 15;
            this.yPositionLabel.Text = "Position:";
            // 
            // customYAxisMinorCheckBox
            // 
            this.customYAxisMinorCheckBox.Checked = true;
            this.customYAxisMinorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customYAxisMinorCheckBox.Location = new System.Drawing.Point(16, 96);
            this.customYAxisMinorCheckBox.Name = "customYAxisMinorCheckBox";
            this.customYAxisMinorCheckBox.Size = new System.Drawing.Size(152, 32);
            this.customYAxisMinorCheckBox.TabIndex = 6;
            this.customYAxisMinorCheckBox.Text = "Minor Divisions Visible";
            this.customYAxisMinorCheckBox.CheckedChanged += new System.EventHandler(this.OnSettingsChanged);
            // 
            // customYAxisMajorCheckBox
            // 
            this.customYAxisMajorCheckBox.Checked = true;
            this.customYAxisMajorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customYAxisMajorCheckBox.Location = new System.Drawing.Point(16, 64);
            this.customYAxisMajorCheckBox.Name = "customYAxisMajorCheckBox";
            this.customYAxisMajorCheckBox.Size = new System.Drawing.Size(152, 32);
            this.customYAxisMajorCheckBox.TabIndex = 5;
            this.customYAxisMajorCheckBox.Text = "Major Divisions Visible";
            this.customYAxisMajorCheckBox.CheckedChanged += new System.EventHandler(this.OnSettingsChanged);
            // 
            // customYAxisPositionComboBox
            // 
            this.customYAxisPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customYAxisPositionComboBox.Items.AddRange(new object[] {
                                                                          "Left",
                                                                          "Right",
                                                                          "Left and Right"});
            this.customYAxisPositionComboBox.Location = new System.Drawing.Point(16, 32);
            this.customYAxisPositionComboBox.Name = "customYAxisPositionComboBoxBox";
            this.customYAxisPositionComboBox.Size = new System.Drawing.Size(144, 21);
            this.customYAxisPositionComboBox.TabIndex = 4;
            this.customYAxisPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.customYAxisPositionComboBox_SelectedIndexChanged);
            // 
            // customXAxisGroupBox
            // 
            this.customXAxisGroupBox.Controls.Add(this.xPositionLabel);
            this.customXAxisGroupBox.Controls.Add(this.customXAxisMinorCheckBox);
            this.customXAxisGroupBox.Controls.Add(this.customXAxisMajorCheckBox);
            this.customXAxisGroupBox.Controls.Add(this.customXAxisPositionComboBox);
            this.customXAxisGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customXAxisGroupBox.Location = new System.Drawing.Point(8, 32);
            this.customXAxisGroupBox.Name = "customXAxisGroupBox";
            this.customXAxisGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.customXAxisGroupBox.Size = new System.Drawing.Size(184, 128);
            this.customXAxisGroupBox.TabIndex = 4;
            this.customXAxisGroupBox.TabStop = false;
            this.customXAxisGroupBox.Text = "Custom XAxis";
            // 
            // xPositionLabel
            // 
            this.xPositionLabel.Location = new System.Drawing.Point(16, 16);
            this.xPositionLabel.Name = "xPositionLabel";
            this.xPositionLabel.Size = new System.Drawing.Size(120, 16);
            this.xPositionLabel.TabIndex = 16;
            this.xPositionLabel.Text = "Position:";
            // 
            // customXAxisMinorCheckBox
            // 
            this.customXAxisMinorCheckBox.Checked = true;
            this.customXAxisMinorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customXAxisMinorCheckBox.Location = new System.Drawing.Point(16, 96);
            this.customXAxisMinorCheckBox.Name = "customXAxisMinorCheckBox";
            this.customXAxisMinorCheckBox.Size = new System.Drawing.Size(144, 24);
            this.customXAxisMinorCheckBox.TabIndex = 3;
            this.customXAxisMinorCheckBox.Text = "Minor Divisions Visible";
            this.customXAxisMinorCheckBox.CheckedChanged += new System.EventHandler(this.OnSettingsChanged);
            // 
            // customXAxisMajorCheckBox
            // 
            this.customXAxisMajorCheckBox.Checked = true;
            this.customXAxisMajorCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.customXAxisMajorCheckBox.Location = new System.Drawing.Point(16, 64);
            this.customXAxisMajorCheckBox.Name = "customXAxisMajorCheckBox";
            this.customXAxisMajorCheckBox.Size = new System.Drawing.Size(144, 24);
            this.customXAxisMajorCheckBox.TabIndex = 2;
            this.customXAxisMajorCheckBox.Text = "Major Divisions Visible";
            this.customXAxisMajorCheckBox.CheckedChanged += new System.EventHandler(this.OnSettingsChanged);
            // 
            // customXAxisPositionComboBox
            // 
            this.customXAxisPositionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customXAxisPositionComboBox.Items.AddRange(new object[] {
                                                                          "Top",
                                                                          "Bottom",
                                                                          "Top and Bottom"});
            this.customXAxisPositionComboBox.Location = new System.Drawing.Point(16, 32);
            this.customXAxisPositionComboBox.Name = "customXAxisPositionComboBoxBox";
            this.customXAxisPositionComboBox.Size = new System.Drawing.Size(136, 21);
            this.customXAxisPositionComboBox.TabIndex = 1;
            this.customXAxisPositionComboBox.SelectedIndexChanged += new System.EventHandler(this.customXAxisPositionComboBox_SelectedIndexChanged);
            // 
            // sampleComplexGraph
            // 
            this.sampleComplexGraph.Caption = "Complex Graph";
            this.sampleComplexGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleComplexGraph.Location = new System.Drawing.Point(208, 0);
            this.sampleComplexGraph.Name = "sampleComplexGraph";
            this.sampleComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
                                                                                                this.complexPlot});
            this.sampleComplexGraph.Size = new System.Drawing.Size(408, 334);
            this.sampleComplexGraph.TabIndex = 7;
            this.sampleComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
                                                                                                 this.xAxis});
            this.sampleComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
                                                                                                 this.yAxis});
            this.sampleComplexGraph.AfterDrawPlotArea += new NationalInstruments.UI.AfterDrawEventHandler(this.complexGraph_AfterDrawPlotArea);
            // 
            // complexPlot
            // 
            this.complexPlot.AntiAliased = true;
            this.complexPlot.LineColor = System.Drawing.Color.Yellow;            
            this.complexPlot.XAxis = this.xAxis;
            this.complexPlot.YAxis = this.yAxis;
            // 
            // vertSplitter
            // 
            this.vertSplitter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.vertSplitter.Location = new System.Drawing.Point(208, 0);
            this.vertSplitter.Name = "vertSplitter";
            this.vertSplitter.Size = new System.Drawing.Size(3, 334);
            this.vertSplitter.TabIndex = 3;
            this.vertSplitter.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(616, 334);
            this.Controls.Add(this.vertSplitter);
            this.Controls.Add(this.sampleComplexGraph);
            this.Controls.Add(this.settingsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Axis Drawing";
            this.settingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customAxesColorIndicatorLed)).EndInit();
            this.customYAxisGroupBox.ResumeLayout(false);
            this.customXAxisGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).EndInit();
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
		
        private void complexGraph_AfterDrawPlotArea(object sender, NationalInstruments.UI.AfterDrawEventArgs e)
        {
            PointF origin = complexPlot.MapDataPoint(sampleComplexGraph.PlotAreaBounds, ComplexDouble.Zero);

			DrawCustomXAxis(e.Graphics, origin);
			DrawCustomYAxis(e.Graphics, origin);
         }
		
		private void DrawCustomXAxis(Graphics graphics, PointF origin)
		{
			ComplexYAxis yAxisClone = (ComplexYAxis) yAxis.Clone();
           
			yAxisClone.MajorDivisions.LabelVisible = false;
			yAxisClone.MajorDivisions.TickColor = customAxesColor;
			yAxisClone.MajorDivisions.TickVisible = customYAxisMajorCheckBox.Checked;
			yAxisClone.MajorDivisions.TickLength = majorDivisionsTickLength;
			
			yAxisClone.MinorDivisions.TickVisible = customYAxisMinorCheckBox.Checked;
			yAxisClone.MinorDivisions.TickColor = customAxesColor;
			yAxisClone.MinorDivisions.TickLength = minorDivisionsTickLength;
            
			switch(yAxisPosition)
			{
				case YAxisPosition.LeftRight:
					yAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle((int)origin.X, sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension , sampleComplexGraph.PlotAreaBounds.Height)),YAxisPosition.Right);
					yAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle((int)origin.X - customAxisDimension , sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension, sampleComplexGraph.PlotAreaBounds.Height)),YAxisPosition.Left);
					break;
				case YAxisPosition.Right:
					yAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle((int)origin.X, sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension , sampleComplexGraph.PlotAreaBounds.Height)),YAxisPosition.Right);
					break;
				case YAxisPosition.Left:
					yAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle((int)origin.X - customAxisDimension , sampleComplexGraph.PlotAreaBounds.Top, customAxisDimension, sampleComplexGraph.PlotAreaBounds.Height)),YAxisPosition.Left);
					break;
				default:
					break;
			}
		}

		private void DrawCustomYAxis(Graphics graphics, PointF origin)
		{
			ComplexXAxis xAxisClone = (ComplexXAxis) xAxis.Clone();
			xAxisClone.MajorDivisions.LabelVisible = false;
			xAxisClone.MajorDivisions.TickColor = customAxesColor;
			xAxisClone.MajorDivisions.TickVisible = customXAxisMajorCheckBox.Checked;
			xAxisClone.MajorDivisions.TickLength = majorDivisionsTickLength;
			
			xAxisClone.MinorDivisions.TickVisible = customXAxisMinorCheckBox.Checked;
			xAxisClone.MinorDivisions.TickColor = customAxesColor;
			xAxisClone.MinorDivisions.TickLength = minorDivisionsTickLength;
            
			switch(xAxisPosition)
			{
				case XAxisPosition.TopBottom:
					xAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle(sampleComplexGraph.PlotAreaBounds.Left, (int)origin.Y, sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), XAxisPosition.Bottom);
					xAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle(sampleComplexGraph.PlotAreaBounds.Left, (int)origin.Y - customAxisDimension, sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), XAxisPosition.Top);
					break;
				case XAxisPosition.Top:
					xAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle(sampleComplexGraph.PlotAreaBounds.Left, (int)origin.Y - customAxisDimension, sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), XAxisPosition.Top);
					break;
				case XAxisPosition.Bottom:
					xAxisClone.Draw(new NationalInstruments.UI.ComponentDrawArgs(graphics,new Rectangle(sampleComplexGraph.PlotAreaBounds.Left, (int)origin.Y, sampleComplexGraph.PlotAreaBounds.Width, customAxisDimension)), XAxisPosition.Bottom);
					break;
				default:
					break;
			}
		}
		

		private void OnSettingsChanged(object sender, System.EventArgs e)
		{
			sampleComplexGraph.Invalidate();
		}

		private void OnColorButton(object sender, System.EventArgs e)
		{
			customAxesColorDialog.Color = customAxesColor;
			if(customAxesColorDialog.ShowDialog() != DialogResult.OK)
				return;
			customAxesColor = customAxesColorDialog.Color;
			UpdateCustomAxesColors();
			sampleComplexGraph.Invalidate();
		}
		
		private void UpdateCustomAxesColors()
		{
			xAxis.OriginLineColor = customAxesColor;
			yAxis.OriginLineColor = customAxesColor;
			customAxesColorIndicatorLed.OnColor = customAxesColor;
		}

		private void customXAxisPositionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(customXAxisPositionComboBox.SelectedIndex)
			{
				case 0:
					xAxisPosition = XAxisPosition.Top;
					break;
				case 1:
					xAxisPosition = XAxisPosition.Bottom;
					break;
				case 2:
					xAxisPosition = XAxisPosition.TopBottom;
					break;
				default:
					xAxisPosition = XAxisPosition.Top;
					break;
			}
			OnSettingsChanged(this, EventArgs.Empty);
		}

		private void customYAxisPositionComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			switch(customYAxisPositionComboBox.SelectedIndex)
			{
				case 0:
					yAxisPosition = YAxisPosition.Left;
					break;
				case 1:
					yAxisPosition = YAxisPosition.Right;
					break;
				case 2:
					yAxisPosition = YAxisPosition.LeftRight;
					break;
				default:
					yAxisPosition = YAxisPosition.Left;
					break;
			}
			OnSettingsChanged(this, EventArgs.Empty);
		}

		public static ComplexDouble[] GenerateDefaultData()
		{
			const double frequency = 10.0;
			const double samplingRate = 1000;
			const int  numberOfSamples = 100;
			const int amplitude = 10;
			
			double f1 = ((2 * Math.PI * frequency) / samplingRate);
			double f2 = ((2 * Math.PI * (frequency + 10.0)) / samplingRate);

			ComplexDouble[] complexData = new ComplexDouble[numberOfSamples];
			for (int i = 0; i < numberOfSamples - 1; ++i)
			{
				complexData[i].Real = amplitude * (Math.Sin(f1 * i));
				complexData[i].Imaginary = amplitude * (Math.Sin(f2 * i));
			}
			complexData[numberOfSamples - 1] = complexData[0];

		 return complexData;
		}
	}
}
