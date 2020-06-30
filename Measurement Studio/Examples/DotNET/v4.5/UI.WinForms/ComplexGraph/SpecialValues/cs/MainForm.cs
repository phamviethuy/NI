using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;


namespace NationalInstruments.Examples.SpecialValues
{
	public class MainForm : System.Windows.Forms.Form
	{
		private NationalInstruments.UI.WindowsForms.ComplexGraph sampleComplexGraph;
		private NationalInstruments.UI.ComplexXAxis complexXAxis;
		private NationalInstruments.UI.ComplexYAxis complexYAxis;
        private System.Windows.Forms.Button plotInfinityButton;
        private System.Windows.Forms.Button plotNaNButton;
        private System.Windows.Forms.Button plotNaNInfinityButton;
        private NationalInstruments.UI.ComplexPlot complexPlot;
        private NationalInstruments.UI.WindowsForms.PropertyEditor arrowStylePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor arrowDirectionPropertyEditor;
        private Label arrowStyleLabel;
        private Label arrowDirectionLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor toolTipVisiblePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor toolTipFormatStringPropertyEditor;
        private System.Windows.Forms.Label toolTipVisibleLabel;
        private System.Windows.Forms.Label toolTipFormatStringLabel;
        private System.Windows.Forms.GroupBox plotArrowsGroupBox;
        private System.Windows.Forms.GroupBox plotToolTipsGroupBox;
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			InitializeComponent();
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.plotNaNInfinityButton = new System.Windows.Forms.Button();
            this.plotInfinityButton = new System.Windows.Forms.Button();
            this.plotNaNButton = new System.Windows.Forms.Button();
            this.sampleComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.complexPlot = new NationalInstruments.UI.ComplexPlot();
            this.complexXAxis = new NationalInstruments.UI.ComplexXAxis();
            this.complexYAxis = new NationalInstruments.UI.ComplexYAxis();
            this.arrowStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.arrowDirectionPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.arrowStyleLabel = new System.Windows.Forms.Label();
            this.arrowDirectionLabel = new System.Windows.Forms.Label();
            this.toolTipVisiblePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.toolTipFormatStringPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.toolTipVisibleLabel = new System.Windows.Forms.Label();
            this.toolTipFormatStringLabel = new System.Windows.Forms.Label();
            this.plotArrowsGroupBox = new System.Windows.Forms.GroupBox();
            this.plotToolTipsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).BeginInit();
            this.plotArrowsGroupBox.SuspendLayout();
            this.plotToolTipsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotNaNInfinityButton
            // 
            this.plotNaNInfinityButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotNaNInfinityButton.Location = new System.Drawing.Point(296, 224);
            this.plotNaNInfinityButton.Name = "plotNaNInfinityButton";
            this.plotNaNInfinityButton.Size = new System.Drawing.Size(120, 23);
            this.plotNaNInfinityButton.TabIndex = 3;
            this.plotNaNInfinityButton.Text = "Plot NaN and Infinity";
            this.plotNaNInfinityButton.Click += new System.EventHandler(this.OnPlotNaNInfinityButtonClick);
            // 
            // plotInfinityButton
            // 
            this.plotInfinityButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotInfinityButton.Location = new System.Drawing.Point(149, 224);
            this.plotInfinityButton.Name = "plotInfinityButton";
            this.plotInfinityButton.Size = new System.Drawing.Size(120, 23);
            this.plotInfinityButton.TabIndex = 2;
            this.plotInfinityButton.Text = "Plot Infinity";
            this.plotInfinityButton.Click += new System.EventHandler(this.OnPlotInfinityButtonClick);
            // 
            // plotNaNButton
            // 
            this.plotNaNButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotNaNButton.Location = new System.Drawing.Point(8, 224);
            this.plotNaNButton.Name = "plotNaNButton";
            this.plotNaNButton.Size = new System.Drawing.Size(120, 23);
            this.plotNaNButton.TabIndex = 1;
            this.plotNaNButton.Text = "Plot NaN";
            this.plotNaNButton.Click += new System.EventHandler(this.OnPlotNaNButtonClick);
            // 
            // sampleComplexGraph
            // 
            this.sampleComplexGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleComplexGraph.Name = "sampleComplexGraph";
            this.sampleComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
                                                                                                this.complexPlot});
            this.sampleComplexGraph.Size = new System.Drawing.Size(408, 200);
            this.sampleComplexGraph.TabIndex = 0;
            this.sampleComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
                                                                                                 this.complexXAxis});
            this.sampleComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
                                                                                                 this.complexYAxis});
            // 
            // complexPlot
            // 
            this.complexPlot.ArrowDisplayMode = NationalInstruments.UI.PlotArrowDisplayMode.CreateAutomaticMode();
            this.complexPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle;
            this.complexPlot.XAxis = this.complexXAxis;
            this.complexPlot.YAxis = this.complexYAxis;
            // 
            // complexYAxis
            // 
            this.complexYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            // 
            // arrowStylePropertyEditor
            // 
            this.arrowStylePropertyEditor.Location = new System.Drawing.Point(83, 24);
            this.arrowStylePropertyEditor.Name = "arrowStylePropertyEditor";
            this.arrowStylePropertyEditor.Size = new System.Drawing.Size(109, 20);
            this.arrowStylePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.complexPlot, "ArrowStyle");
            this.arrowStylePropertyEditor.TabIndex = 4;
            // 
            // arrowDirectionPropertyEditor
            // 
            this.arrowDirectionPropertyEditor.Location = new System.Drawing.Point(304, 24);
            this.arrowDirectionPropertyEditor.Name = "arrowDirectionPropertyEditor";
            this.arrowDirectionPropertyEditor.Size = new System.Drawing.Size(96, 20);
            this.arrowDirectionPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.complexPlot, "ArrowDirection");
            this.arrowDirectionPropertyEditor.TabIndex = 5;
            // 
            // arrowStyleLabel
            // 
            this.arrowStyleLabel.Location = new System.Drawing.Point(8, 24);
            this.arrowStyleLabel.Name = "arrowStyleLabel";
            this.arrowStyleLabel.Size = new System.Drawing.Size(64, 19);
            this.arrowStyleLabel.TabIndex = 6;
            this.arrowStyleLabel.Text = "Arrow style:";
            this.arrowStyleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // arrowDirectionLabel
            // 
            this.arrowDirectionLabel.Location = new System.Drawing.Point(200, 24);
            this.arrowDirectionLabel.Name = "arrowDirectionLabel";
            this.arrowDirectionLabel.Size = new System.Drawing.Size(83, 19);
            this.arrowDirectionLabel.TabIndex = 7;
            this.arrowDirectionLabel.Text = "Arrow direction:";
            this.arrowDirectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTipVisiblePropertyEditor
            // 
            this.toolTipVisiblePropertyEditor.Location = new System.Drawing.Point(83, 24);
            this.toolTipVisiblePropertyEditor.Name = "toolTipVisiblePropertyEditor";
            this.toolTipVisiblePropertyEditor.Size = new System.Drawing.Size(112, 20);
            this.toolTipVisiblePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.complexPlot, "ToolTipsEnabled");
            this.toolTipVisiblePropertyEditor.TabIndex = 8;
            // 
            // toolTipFormatStringPropertyEditor
            // 
            this.toolTipFormatStringPropertyEditor.Location = new System.Drawing.Point(304, 24);
            this.toolTipFormatStringPropertyEditor.Name = "toolTipFormatStringPropertyEditor";
            this.toolTipFormatStringPropertyEditor.Size = new System.Drawing.Size(96, 20);
            this.toolTipFormatStringPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.complexPlot, "ToolTipFormatString");
            this.toolTipFormatStringPropertyEditor.TabIndex = 9;
            // 
            // toolTipVisibleLabel
            // 
            this.toolTipVisibleLabel.Location = new System.Drawing.Point(4, 24);
            this.toolTipVisibleLabel.Name = "toolTipVisibleLabel";
            this.toolTipVisibleLabel.Size = new System.Drawing.Size(80, 23);
            this.toolTipVisibleLabel.TabIndex = 10;
            this.toolTipVisibleLabel.Text = "ToolTipVisible";
            // 
            // toolTipFormatStringLabel
            // 
            this.toolTipFormatStringLabel.Location = new System.Drawing.Point(200, 24);
            this.toolTipFormatStringLabel.Name = "toolTipFormatStringLabel";
            this.toolTipFormatStringLabel.Size = new System.Drawing.Size(112, 23);
            this.toolTipFormatStringLabel.TabIndex = 11;
            this.toolTipFormatStringLabel.Text = "ToolTipFormatString";
            // 
            // plotArrowsGroupBox
            // 
            this.plotArrowsGroupBox.Controls.Add(this.arrowStyleLabel);
            this.plotArrowsGroupBox.Controls.Add(this.arrowStylePropertyEditor);
            this.plotArrowsGroupBox.Controls.Add(this.arrowDirectionLabel);
            this.plotArrowsGroupBox.Controls.Add(this.arrowDirectionPropertyEditor);
            this.plotArrowsGroupBox.Location = new System.Drawing.Point(8, 256);
            this.plotArrowsGroupBox.Name = "plotArrowsGroupBox";
            this.plotArrowsGroupBox.Size = new System.Drawing.Size(408, 56);
            this.plotArrowsGroupBox.TabIndex = 12;
            this.plotArrowsGroupBox.TabStop = false;
            this.plotArrowsGroupBox.Text = "Plot Arrows";
            // 
            // plotToolTipsGroupBox
            // 
            this.plotToolTipsGroupBox.Controls.Add(this.toolTipVisibleLabel);
            this.plotToolTipsGroupBox.Controls.Add(this.toolTipVisiblePropertyEditor);
            this.plotToolTipsGroupBox.Controls.Add(this.toolTipFormatStringPropertyEditor);
            this.plotToolTipsGroupBox.Controls.Add(this.toolTipFormatStringLabel);
            this.plotToolTipsGroupBox.Location = new System.Drawing.Point(8, 320);
            this.plotToolTipsGroupBox.Name = "plotToolTipsGroupBox";
            this.plotToolTipsGroupBox.Size = new System.Drawing.Size(408, 56);
            this.plotToolTipsGroupBox.TabIndex = 13;
            this.plotToolTipsGroupBox.TabStop = false;
            this.plotToolTipsGroupBox.Text = "Plot ToolTips";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(418, 384);
            this.Controls.Add(this.plotToolTipsGroupBox);
            this.Controls.Add(this.plotArrowsGroupBox);
            this.Controls.Add(this.sampleComplexGraph);
            this.Controls.Add(this.plotNaNInfinityButton);
            this.Controls.Add(this.plotInfinityButton);
            this.Controls.Add(this.plotNaNButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Special Values";
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).EndInit();
            this.plotArrowsGroupBox.ResumeLayout(false);
            this.plotToolTipsGroupBox.ResumeLayout(false);
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

		private static ComplexDouble[] GenerateData()
		{
            int maxValue = 10;
            int pointCount = 20;
			ComplexDouble[] data = new ComplexDouble[pointCount];
            double[] yData = new double[pointCount];

			for (int i = 0; i < data.Length; ++i)
			{
                yData[i] = maxValue / 2 * (1 - (double)Math.Sin(i * 2 * Math.PI / (pointCount - 1))) - (maxValue / 2);
				data[i] = new ComplexDouble(i, yData[i]);
			}

			return data;
		}

		private void OnPlotNaNButtonClick(object sender, System.EventArgs e)
		{
			complexPlot.ProcessSpecialValues = true;

			ComplexDouble[] data = GenerateData();

			int centerIndex = Convert.ToInt32(data.Length / 2);

			data[centerIndex].Imaginary = Double.NaN;

			sampleComplexGraph.PlotComplex(data);
		}

		private void OnPlotInfinityButtonClick(object sender, System.EventArgs e)
		{
			complexPlot.ProcessSpecialValues = true;

			ComplexDouble[] data = GenerateData();

			int quarterIndex = Convert.ToInt32(data.Length / 4);
			int lastQuarterIndex = Convert.ToInt32(data.Length * 3 / 4);

			data[quarterIndex].Imaginary = Double.PositiveInfinity;
			data[lastQuarterIndex].Imaginary = Double.NegativeInfinity;

			sampleComplexGraph.PlotComplex(data);
		}

		private void OnPlotNaNInfinityButtonClick(object sender, System.EventArgs e)
		{
			complexPlot.ProcessSpecialValues = true;

			ComplexDouble[] data = GenerateData();

			int quarterIndex = Convert.ToInt32(data.Length / 4);
			int centerIndex = Convert.ToInt32(data.Length / 2);
			int lastQuarterIndex = Convert.ToInt32(data.Length * 3 / 4);

			data[quarterIndex].Imaginary = Double.PositiveInfinity;
			data[centerIndex].Imaginary = Double.NaN;
			data[lastQuarterIndex].Imaginary = Double.NegativeInfinity;

			sampleComplexGraph.PlotComplex(data);
		}
	}
}
