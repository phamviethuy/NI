using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NationalInstruments.Examples.ToBase
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfPointsNumericEdit;
        private System.Windows.Forms.Button generateButton;
        private NationalInstruments.UI.WindowsForms.NumericEdit baseYValueNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit baseXValueNumericEdit;
        private System.Windows.Forms.ComboBox fillBaseComboBox;
        private System.Windows.Forms.ComboBox fillModeComboBox;
        private NationalInstruments.UI.WindowsForms.Led fillToBaseColorLed;
        private NationalInstruments.UI.WindowsForms.Led lineToBaseColorLed;
        private System.Windows.Forms.ComboBox lineToBaseStyleComboBox;
        private System.Windows.Forms.ComboBox fillToBaseStyleComboBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit lineToBaseLineWidthNumericEdit;
        private System.Windows.Forms.Label baseXValueLabel;
        private System.Windows.Forms.Label baseYValueLabel;
        private System.Windows.Forms.Label numberOfPointsLabel;
        private System.Windows.Forms.Label fillBaseLabel;
        private System.Windows.Forms.Label fillModeLabel;
        private System.Windows.Forms.Label lineToBaseStyleLabel;
        private System.Windows.Forms.Label fillToBaseStyleLabel;
        private System.Windows.Forms.Label lineToBaseLineWidthLabel;
        private System.Windows.Forms.Label fillToBaseColorLabel;
        private System.Windows.Forms.Label lineToBaseColorLabel;
        private System.Windows.Forms.GroupBox fillToBaseGroupBox;
        private System.Windows.Forms.GroupBox lineToBaseGroupBox;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.ColorDialog applicationColorDialog;
        private NationalInstruments.UI.XAxis mainXAxis;
        private NationalInstruments.UI.YAxis mainYAxis;
        private NationalInstruments.UI.WaveformPlot fillToBasePlot;
        private NationalInstruments.UI.WindowsForms.WaveformGraph fillToBaseWaveformGraph;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fillToBaseWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.fillToBasePlot = new NationalInstruments.UI.WaveformPlot();
            this.mainXAxis = new NationalInstruments.UI.XAxis();
            this.mainYAxis = new NationalInstruments.UI.YAxis();
            this.numberOfPointsNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numberOfPointsLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.baseYValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.baseXValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.baseXValueLabel = new System.Windows.Forms.Label();
            this.baseYValueLabel = new System.Windows.Forms.Label();
            this.fillBaseComboBox = new System.Windows.Forms.ComboBox();
            this.fillBaseLabel = new System.Windows.Forms.Label();
            this.fillModeLabel = new System.Windows.Forms.Label();
            this.fillModeComboBox = new System.Windows.Forms.ComboBox();
            this.applicationColorDialog = new System.Windows.Forms.ColorDialog();
            this.fillToBaseColorLed = new NationalInstruments.UI.WindowsForms.Led();
            this.fillToBaseColorLabel = new System.Windows.Forms.Label();
            this.lineToBaseColorLabel = new System.Windows.Forms.Label();
            this.lineToBaseColorLed = new NationalInstruments.UI.WindowsForms.Led();
            this.lineToBaseStyleLabel = new System.Windows.Forms.Label();
            this.lineToBaseStyleComboBox = new System.Windows.Forms.ComboBox();
            this.fillToBaseGroupBox = new System.Windows.Forms.GroupBox();
            this.fillToBaseStyleLabel = new System.Windows.Forms.Label();
            this.fillToBaseStyleComboBox = new System.Windows.Forms.ComboBox();
            this.lineToBaseGroupBox = new System.Windows.Forms.GroupBox();
            this.lineToBaseLineWidthLabel = new System.Windows.Forms.Label();
            this.lineToBaseLineWidthNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.fillToBaseWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPointsNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseYValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseXValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillToBaseColorLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineToBaseColorLed)).BeginInit();
            this.fillToBaseGroupBox.SuspendLayout();
            this.lineToBaseGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineToBaseLineWidthNumericEdit)).BeginInit();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fillToBaseWaveformGraph
            // 
            this.fillToBaseWaveformGraph.Location = new System.Drawing.Point(8, 8);
            this.fillToBaseWaveformGraph.Name = "fillToBaseWaveformGraph";
            this.fillToBaseWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.fillToBasePlot});
            this.fillToBaseWaveformGraph.Size = new System.Drawing.Size(352, 160);
            this.fillToBaseWaveformGraph.TabIndex = 0;
            this.fillToBaseWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.mainXAxis});
            this.fillToBaseWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.mainYAxis});
            // 
            // fillToBasePlot
            // 
            this.fillToBasePlot.CanScaleYAxis = true;
            this.fillToBasePlot.XAxis = this.mainXAxis;
            this.fillToBasePlot.YAxis = this.mainYAxis;
            // 
            // mainYAxis
            // 
            this.mainYAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.mainYAxis.Range = NationalInstruments.UI.Range.Parse("0, 100");
            // 
            // numberOfPointsNumericEdit
            // 
            this.numberOfPointsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfPointsNumericEdit.Location = new System.Drawing.Point(16, 40);
            this.numberOfPointsNumericEdit.Name = "numberOfPointsNumericEdit";
            this.numberOfPointsNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfPointsNumericEdit.Range = NationalInstruments.UI.Range.Parse("2, Infinity");
            this.numberOfPointsNumericEdit.TabIndex = 1;
            this.numberOfPointsNumericEdit.Value = 10;
            // 
            // numberOfPointsLabel
            // 
            this.numberOfPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numberOfPointsLabel.Location = new System.Drawing.Point(16, 24);
            this.numberOfPointsLabel.Name = "numberOfPointsLabel";
            this.numberOfPointsLabel.Size = new System.Drawing.Size(120, 16);
            this.numberOfPointsLabel.TabIndex = 2;
            this.numberOfPointsLabel.Text = "Number of Points";
            // 
            // generateButton
            // 
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.generateButton.Location = new System.Drawing.Point(16, 64);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(120, 23);
            this.generateButton.TabIndex = 3;
            this.generateButton.Text = "Generate";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // baseYValueNumericEdit
            // 
            this.baseYValueNumericEdit.Location = new System.Drawing.Point(96, 192);
            this.baseYValueNumericEdit.Name = "baseYValueNumericEdit";
            this.baseYValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.baseYValueNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.baseYValueNumericEdit.TabIndex = 4;
            this.baseYValueNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.baseYValueNumericEdit_AfterChangeValue);
            // 
            // baseXValueNumericEdit
            // 
            this.baseXValueNumericEdit.Location = new System.Drawing.Point(16, 192);
            this.baseXValueNumericEdit.Name = "baseXValueNumericEdit";
            this.baseXValueNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.baseXValueNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.baseXValueNumericEdit.TabIndex = 5;
            this.baseXValueNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.baseXValueNumericEdit_AfterChangeValue);
            // 
            // baseXValueLabel
            // 
            this.baseXValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseXValueLabel.Location = new System.Drawing.Point(16, 176);
            this.baseXValueLabel.Name = "baseXValueLabel";
            this.baseXValueLabel.Size = new System.Drawing.Size(80, 16);
            this.baseXValueLabel.TabIndex = 6;
            this.baseXValueLabel.Text = "Base X Value:";
            // 
            // baseYValueLabel
            // 
            this.baseYValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.baseYValueLabel.Location = new System.Drawing.Point(96, 176);
            this.baseYValueLabel.Name = "baseYValueLabel";
            this.baseYValueLabel.Size = new System.Drawing.Size(80, 16);
            this.baseYValueLabel.TabIndex = 7;
            this.baseYValueLabel.Text = "Base Y Value:";
            // 
            // fillBaseComboBox
            // 
            this.fillBaseComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillBaseComboBox.Location = new System.Drawing.Point(16, 240);
            this.fillBaseComboBox.Name = "fillBaseComboBox";
            this.fillBaseComboBox.Size = new System.Drawing.Size(121, 21);
            this.fillBaseComboBox.TabIndex = 8;
            this.fillBaseComboBox.SelectedIndexChanged += new System.EventHandler(this.fillBaseComboBox_SelectedIndexChanged);
            // 
            // fillBaseLabel
            // 
            this.fillBaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fillBaseLabel.Location = new System.Drawing.Point(16, 224);
            this.fillBaseLabel.Name = "fillBaseLabel";
            this.fillBaseLabel.Size = new System.Drawing.Size(64, 16);
            this.fillBaseLabel.TabIndex = 9;
            this.fillBaseLabel.Text = "Fill Base:";
            // 
            // fillModeLabel
            // 
            this.fillModeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fillModeLabel.Location = new System.Drawing.Point(16, 264);
            this.fillModeLabel.Name = "fillModeLabel";
            this.fillModeLabel.Size = new System.Drawing.Size(64, 16);
            this.fillModeLabel.TabIndex = 11;
            this.fillModeLabel.Text = "Fill Mode:";
            // 
            // fillModeComboBox
            // 
            this.fillModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillModeComboBox.Location = new System.Drawing.Point(16, 280);
            this.fillModeComboBox.Name = "fillModeComboBox";
            this.fillModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fillModeComboBox.TabIndex = 10;
            this.fillModeComboBox.SelectedIndexChanged += new System.EventHandler(this.fillModeComboBox_SelectedIndexChanged);
            // 
            // fillToBaseColorLed
            // 
            this.fillToBaseColorLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.fillToBaseColorLed.Location = new System.Drawing.Point(56, 80);
            this.fillToBaseColorLed.Name = "fillToBaseColorLed";
            this.fillToBaseColorLed.Size = new System.Drawing.Size(40, 40);
            this.fillToBaseColorLed.TabIndex = 13;
            this.fillToBaseColorLed.Value = true;
            this.fillToBaseColorLed.Click += new System.EventHandler(this.fillToBaseColorLed_Click);
            // 
            // fillToBaseColorLabel
            // 
            this.fillToBaseColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fillToBaseColorLabel.Location = new System.Drawing.Point(56, 64);
            this.fillToBaseColorLabel.Name = "fillToBaseColorLabel";
            this.fillToBaseColorLabel.Size = new System.Drawing.Size(40, 16);
            this.fillToBaseColorLabel.TabIndex = 14;
            this.fillToBaseColorLabel.Text = "Color";
            // 
            // lineToBaseColorLabel
            // 
            this.lineToBaseColorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineToBaseColorLabel.Location = new System.Drawing.Point(64, 104);
            this.lineToBaseColorLabel.Name = "lineToBaseColorLabel";
            this.lineToBaseColorLabel.Size = new System.Drawing.Size(40, 16);
            this.lineToBaseColorLabel.TabIndex = 19;
            this.lineToBaseColorLabel.Text = "Color";
            // 
            // lineToBaseColorLed
            // 
            this.lineToBaseColorLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.lineToBaseColorLed.Location = new System.Drawing.Point(56, 120);
            this.lineToBaseColorLed.Name = "lineToBaseColorLed";
            this.lineToBaseColorLed.Size = new System.Drawing.Size(40, 40);
            this.lineToBaseColorLed.TabIndex = 18;
            this.lineToBaseColorLed.Value = true;
            this.lineToBaseColorLed.Click += new System.EventHandler(this.lineToBaseColorLed_Click);
            // 
            // lineToBaseStyleLabel
            // 
            this.lineToBaseStyleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineToBaseStyleLabel.Location = new System.Drawing.Point(16, 24);
            this.lineToBaseStyleLabel.Name = "lineToBaseStyleLabel";
            this.lineToBaseStyleLabel.Size = new System.Drawing.Size(64, 16);
            this.lineToBaseStyleLabel.TabIndex = 21;
            this.lineToBaseStyleLabel.Text = "Style:";
            // 
            // lineToBaseStyleComboBox
            // 
            this.lineToBaseStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineToBaseStyleComboBox.Location = new System.Drawing.Point(16, 40);
            this.lineToBaseStyleComboBox.Name = "lineToBaseStyleComboBox";
            this.lineToBaseStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.lineToBaseStyleComboBox.TabIndex = 20;
            this.lineToBaseStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.lineToBaseStyleComboBox_SelectedIndexChanged);
            // 
            // fillToBaseGroupBox
            // 
            this.fillToBaseGroupBox.Controls.Add(this.fillToBaseStyleLabel);
            this.fillToBaseGroupBox.Controls.Add(this.fillToBaseStyleComboBox);
            this.fillToBaseGroupBox.Controls.Add(this.fillToBaseColorLed);
            this.fillToBaseGroupBox.Controls.Add(this.fillToBaseColorLabel);
            this.fillToBaseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fillToBaseGroupBox.Location = new System.Drawing.Point(16, 320);
            this.fillToBaseGroupBox.Name = "fillToBaseGroupBox";
            this.fillToBaseGroupBox.Size = new System.Drawing.Size(160, 128);
            this.fillToBaseGroupBox.TabIndex = 24;
            this.fillToBaseGroupBox.TabStop = false;
            this.fillToBaseGroupBox.Text = "Fill to Base";
            // 
            // fillToBaseStyleLabel
            // 
            this.fillToBaseStyleLabel.Location = new System.Drawing.Point(16, 24);
            this.fillToBaseStyleLabel.Name = "fillToBaseStyleLabel";
            this.fillToBaseStyleLabel.Size = new System.Drawing.Size(96, 16);
            this.fillToBaseStyleLabel.TabIndex = 18;
            this.fillToBaseStyleLabel.Text = "Style:";
            // 
            // fillToBaseStyleComboBox
            // 
            this.fillToBaseStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fillToBaseStyleComboBox.Location = new System.Drawing.Point(16, 40);
            this.fillToBaseStyleComboBox.Name = "fillToBaseStyleComboBox";
            this.fillToBaseStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.fillToBaseStyleComboBox.TabIndex = 17;
            this.fillToBaseStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.fillToBaseStyleComboBox_SelectedIndexChanged);
            // 
            // lineToBaseGroupBox
            // 
            this.lineToBaseGroupBox.Controls.Add(this.lineToBaseLineWidthLabel);
            this.lineToBaseGroupBox.Controls.Add(this.lineToBaseLineWidthNumericEdit);
            this.lineToBaseGroupBox.Controls.Add(this.lineToBaseColorLed);
            this.lineToBaseGroupBox.Controls.Add(this.lineToBaseColorLabel);
            this.lineToBaseGroupBox.Controls.Add(this.lineToBaseStyleComboBox);
            this.lineToBaseGroupBox.Controls.Add(this.lineToBaseStyleLabel);
            this.lineToBaseGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineToBaseGroupBox.Location = new System.Drawing.Point(192, 280);
            this.lineToBaseGroupBox.Name = "lineToBaseGroupBox";
            this.lineToBaseGroupBox.Size = new System.Drawing.Size(168, 168);
            this.lineToBaseGroupBox.TabIndex = 25;
            this.lineToBaseGroupBox.TabStop = false;
            this.lineToBaseGroupBox.Text = "Line to Base";
            // 
            // lineToBaseLineWidthLabel
            // 
            this.lineToBaseLineWidthLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lineToBaseLineWidthLabel.Location = new System.Drawing.Point(16, 64);
            this.lineToBaseLineWidthLabel.Name = "lineToBaseLineWidthLabel";
            this.lineToBaseLineWidthLabel.Size = new System.Drawing.Size(128, 16);
            this.lineToBaseLineWidthLabel.TabIndex = 25;
            this.lineToBaseLineWidthLabel.Text = "Line to Base Line Width:";
            // 
            // lineToBaseLineWidthNumericEdit
            // 
            this.lineToBaseLineWidthNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.lineToBaseLineWidthNumericEdit.Location = new System.Drawing.Point(16, 80);
            this.lineToBaseLineWidthNumericEdit.Name = "lineToBaseLineWidthNumericEdit";
            this.lineToBaseLineWidthNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.lineToBaseLineWidthNumericEdit.Range = NationalInstruments.UI.Range.Parse("1, Infinity");
            this.lineToBaseLineWidthNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.lineToBaseLineWidthNumericEdit.TabIndex = 24;
            this.lineToBaseLineWidthNumericEdit.Value = 1;
            this.lineToBaseLineWidthNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.lineToBaseLineWidthNumericEdit_AfterChangeValue);
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.generateButton);
            this.dataGroupBox.Controls.Add(this.numberOfPointsLabel);
            this.dataGroupBox.Controls.Add(this.numberOfPointsNumericEdit);
            this.dataGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dataGroupBox.Location = new System.Drawing.Point(192, 176);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(168, 100);
            this.dataGroupBox.TabIndex = 26;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Data";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(368, 462);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.lineToBaseGroupBox);
            this.Controls.Add(this.fillToBaseGroupBox);
            this.Controls.Add(this.fillModeLabel);
            this.Controls.Add(this.fillModeComboBox);
            this.Controls.Add(this.fillBaseLabel);
            this.Controls.Add(this.fillBaseComboBox);
            this.Controls.Add(this.baseYValueLabel);
            this.Controls.Add(this.baseXValueLabel);
            this.Controls.Add(this.baseXValueNumericEdit);
            this.Controls.Add(this.baseYValueNumericEdit);
            this.Controls.Add(this.fillToBaseWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "To Base";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fillToBaseWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPointsNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseYValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseXValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fillToBaseColorLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineToBaseColorLed)).EndInit();
            this.fillToBaseGroupBox.ResumeLayout(false);
            this.lineToBaseGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineToBaseLineWidthNumericEdit)).EndInit();
            this.dataGroupBox.ResumeLayout(false);
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

        private static double[] GenerateRandomData(int numDataPoints)
        {
            double[] data = new double[numDataPoints];
            Random random = new Random();
            for(int i=0; i<numDataPoints; i++)
            {
                data[i] = random.NextDouble() * 100;
            }
            return data;
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Setup the UI with the values from the control.

            baseXValueNumericEdit.Value = fillToBasePlot.BaseXValue;
            baseYValueNumericEdit.Value = fillToBasePlot.BaseYValue;

            fillBaseComboBox.Items.Add(NationalInstruments.UI.XYPlotFillBase.XValue);
            fillBaseComboBox.Items.Add(NationalInstruments.UI.XYPlotFillBase.YValue);
            fillBaseComboBox.SelectedItem = fillToBasePlot.FillBase;

            fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.Bins);
            fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.Fill);
            fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.FillAndBins);
            fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.FillAndLines);
            fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.Lines);
            fillModeComboBox.Items.Add(NationalInstruments.UI.PlotFillMode.None);
            fillModeComboBox.SelectedItem = fillToBasePlot.FillMode;

            Array values = NationalInstruments.UI.FillStyle.GetValues(fillToBasePlot.FillToBaseStyle.UnderlyingType);
            object[] vls = new object[values.Length];
            for(int i=0; i<values.Length; i++)
                vls[i] = values.GetValue(i);
            fillToBaseStyleComboBox.Items.AddRange(vls);
            fillToBaseStyleComboBox.SelectedItem = fillToBasePlot.FillToBaseStyle;

            values = NationalInstruments.UI.LineStyle.GetValues(fillToBasePlot.LineToBaseStyle.UnderlyingType);
            vls = new object[values.Length];
            for(int i=0; i<values.Length; i++)
                vls[i] = values.GetValue(i);
            lineToBaseStyleComboBox.Items.AddRange(vls);
            lineToBaseStyleComboBox.SelectedItem = fillToBasePlot.LineToBaseStyle;

            lineToBaseLineWidthNumericEdit.Value = fillToBasePlot.LineToBaseWidth;

            fillToBaseColorLed.OnColor = fillToBasePlot.FillToBaseColor;
            lineToBaseColorLed.OnColor = fillToBasePlot.LineToBaseColor;

            double[] d = GenerateRandomData(10);
            fillToBaseWaveformGraph.PlotY(d);
        }

        private void generateButton_Click(object sender, System.EventArgs e)
        {
            double[] d = GenerateRandomData(Convert.ToInt32(numberOfPointsNumericEdit.Value));
            fillToBaseWaveformGraph.PlotY(d);
        }

        private void baseXValueNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            fillToBasePlot.BaseXValue = e.NewValue;
        }

        private void baseYValueNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            fillToBasePlot.BaseYValue = e.NewValue;
        }

        private void fillBaseComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            fillToBasePlot.FillBase = (NationalInstruments.UI.XYPlotFillBase)fillBaseComboBox.SelectedItem;
        }

        private void fillToBaseColorLed_Click(object sender, System.EventArgs e)
        {
            applicationColorDialog.Color = fillToBasePlot.FillToBaseColor;
            if(applicationColorDialog.ShowDialog() != DialogResult.OK)
                return;
            fillToBaseColorLed.OnColor = applicationColorDialog.Color;
            fillToBasePlot.FillToBaseColor = applicationColorDialog.Color;
        }

        private void lineToBaseColorLed_Click(object sender, System.EventArgs e)
        {
            applicationColorDialog.Color = fillToBasePlot.LineToBaseColor;
            if(applicationColorDialog.ShowDialog() != DialogResult.OK)
                return;
            lineToBaseColorLed.OnColor = applicationColorDialog.Color;
            fillToBasePlot.LineToBaseColor = applicationColorDialog.Color;
        }

        private void fillModeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            fillToBasePlot.FillMode = (NationalInstruments.UI.PlotFillMode)fillModeComboBox.SelectedItem;
        }

        private void fillToBaseStyleComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            fillToBasePlot.FillToBaseStyle = (NationalInstruments.UI.FillStyle)fillToBaseStyleComboBox.SelectedItem;
        }

        private void lineToBaseStyleComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            fillToBasePlot.LineToBaseStyle = (NationalInstruments.UI.LineStyle)lineToBaseStyleComboBox.SelectedItem;
        }

        private void lineToBaseLineWidthNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            fillToBasePlot.LineToBaseWidth = Convert.ToSingle(e.NewValue);
        }
	}
}
