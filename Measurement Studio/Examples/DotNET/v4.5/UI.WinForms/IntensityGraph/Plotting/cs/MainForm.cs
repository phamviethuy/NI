using System;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Plotting
{
	public class MainForm : System.Windows.Forms.Form
    {
        private IntensityGraph intensityGraph;
        private ColorScale colorScale;
        private IntensityPlot intensityPlot;
        private IntensityXAxis intensityXAxis;
        private IntensityYAxis intensityYAxis;
        private GroupBox settingsGroupBox;
        private NumericEdit yIncrementNumericEdit;
        private NumericEdit yStartNumericEdit;
        private NumericEdit xIncrementNumericEdit;
        private NumericEdit xStartNumericEdit;
        private Label yIncrementLabel;
        private Label xIncrementLabel;
        private Label yStartLabel;
        private Label xStartLabel;
        private NumericEdit xArraySizeNumericEdit;
        private Label inputDataSizeLabel;
        private NumericEdit yArraySizeNumericEdit;
        private GroupBox plotGroupBox;
        private Label sizeIndicationLabel;
        private CheckBox pixelInterpolationCheckBox;
        private Button editColorMapButton;
        private Panel anchorBottomLeftRightPanel;
        private PropertyEditor colorMapPropertyEditor;

        public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            InitializeColorScale();
            GenerateDataAndPlot();
        }

        private void InitializeColorScale()
        {
            // Initialize the color scale and plot data once.
            colorScale.Range = new Range(-10, 10);
            colorScale.ColorMap.AddRange(
                new NationalInstruments.UI.ColorMapEntry[] {
                    new NationalInstruments.UI.ColorMapEntry(-8, System.Drawing.Color.Blue),
                    new NationalInstruments.UI.ColorMapEntry(-5, System.Drawing.Color.Cyan),
                    new NationalInstruments.UI.ColorMapEntry(-2, System.Drawing.Color.Green),
                    new NationalInstruments.UI.ColorMapEntry(0, System.Drawing.Color.Lime),
                    new NationalInstruments.UI.ColorMapEntry(2, System.Drawing.Color.Yellow),
                    new NationalInstruments.UI.ColorMapEntry(5, System.Drawing.Color.Orange),
                    new NationalInstruments.UI.ColorMapEntry(8, System.Drawing.Color.Red)
                }
            );
        }


		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.intensityGraph = new NationalInstruments.UI.WindowsForms.IntensityGraph();
            this.colorScale = new NationalInstruments.UI.ColorScale();
            this.intensityPlot = new NationalInstruments.UI.IntensityPlot();
            this.intensityXAxis = new NationalInstruments.UI.IntensityXAxis();
            this.intensityYAxis = new NationalInstruments.UI.IntensityYAxis();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.editColorMapButton = new System.Windows.Forms.Button();
            this.colorMapPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.pixelInterpolationCheckBox = new System.Windows.Forms.CheckBox();
            this.yIncrementNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.yStartNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.yStartLabel = new System.Windows.Forms.Label();
            this.xIncrementNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.xStartNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.yIncrementLabel = new System.Windows.Forms.Label();
            this.xIncrementLabel = new System.Windows.Forms.Label();
            this.xStartLabel = new System.Windows.Forms.Label();
            this.xArraySizeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.inputDataSizeLabel = new System.Windows.Forms.Label();
            this.yArraySizeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.plotGroupBox = new System.Windows.Forms.GroupBox();
            this.sizeIndicationLabel = new System.Windows.Forms.Label();
            this.anchorBottomLeftRightPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.intensityGraph)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yIncrementNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yStartNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIncrementNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStartNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xArraySizeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yArraySizeNumericEdit)).BeginInit();
            this.plotGroupBox.SuspendLayout();
            this.anchorBottomLeftRightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // intensityGraph
            // 
            this.intensityGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.intensityGraph.Caption = "Intensity Graph";
            this.intensityGraph.ColorScales.AddRange(new NationalInstruments.UI.ColorScale[] {
            this.colorScale});
            this.intensityGraph.Location = new System.Drawing.Point(12, 12);
            this.intensityGraph.Name = "intensityGraph";
            this.intensityGraph.Plots.AddRange(new NationalInstruments.UI.IntensityPlot[] {
            this.intensityPlot});
            this.intensityGraph.Size = new System.Drawing.Size(489, 273);
            this.intensityGraph.TabIndex = 0;
            this.intensityGraph.XAxes.AddRange(new NationalInstruments.UI.IntensityXAxis[] {
            this.intensityXAxis});
            this.intensityGraph.YAxes.AddRange(new NationalInstruments.UI.IntensityYAxis[] {
            this.intensityYAxis});
            // 
            // colorScale
            // 
            this.colorScale.Caption = "Color Scale";
            this.colorScale.RightCaptionOrientation = NationalInstruments.UI.VerticalCaptionOrientation.BottomToTop;
            // 
            // intensityPlot
            // 
            this.intensityPlot.ColorScale = this.colorScale;
            this.intensityPlot.ToolTipsEnabled = true;
            this.intensityPlot.XAxis = this.intensityXAxis;
            this.intensityPlot.YAxis = this.intensityYAxis;
            // 
            // intensityXAxis
            // 
            this.intensityXAxis.Caption = "Intensity X Axis";
            this.intensityXAxis.Mode = NationalInstruments.UI.IntensityAxisMode.AutoScaleExact;
            // 
            // intensityYAxis
            // 
            this.intensityYAxis.Caption = "Intensity Y Axis";
            this.intensityYAxis.Mode = NationalInstruments.UI.IntensityAxisMode.AutoScaleExact;
            this.intensityYAxis.Range = new NationalInstruments.UI.Range(0, 100);
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsGroupBox.Controls.Add(this.editColorMapButton);
            this.settingsGroupBox.Controls.Add(this.colorMapPropertyEditor);
            this.settingsGroupBox.Controls.Add(this.pixelInterpolationCheckBox);
            this.settingsGroupBox.Controls.Add(this.yIncrementNumericEdit);
            this.settingsGroupBox.Controls.Add(this.yStartNumericEdit);
            this.settingsGroupBox.Controls.Add(this.yStartLabel);
            this.settingsGroupBox.Controls.Add(this.xIncrementNumericEdit);
            this.settingsGroupBox.Controls.Add(this.xStartNumericEdit);
            this.settingsGroupBox.Controls.Add(this.yIncrementLabel);
            this.settingsGroupBox.Controls.Add(this.xIncrementLabel);
            this.settingsGroupBox.Controls.Add(this.xStartLabel);
            this.settingsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(489, 84);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Plot And Color Map Settings";
            // 
            // editColorMapButton
            // 
            this.editColorMapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.editColorMapButton.Location = new System.Drawing.Point(348, 47);
            this.editColorMapButton.Name = "editColorMapButton";
            this.editColorMapButton.Size = new System.Drawing.Size(106, 23);
            this.editColorMapButton.TabIndex = 5;
            this.editColorMapButton.Text = "Edit Color Map";
            this.editColorMapButton.UseVisualStyleBackColor = true;
            this.editColorMapButton.Click += new System.EventHandler(this.OnEditColorMapButtonClick);
            // 
            // colorMapPropertyEditor
            // 
            this.colorMapPropertyEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.colorMapPropertyEditor.BackColor = System.Drawing.SystemColors.Control;
            this.colorMapPropertyEditor.Location = new System.Drawing.Point(355, 50);
            this.colorMapPropertyEditor.Name = "colorMapPropertyEditor";
            this.colorMapPropertyEditor.Size = new System.Drawing.Size(82, 20);
            this.colorMapPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.colorScale, "ColorMap");
            this.colorMapPropertyEditor.TabIndex = 3;
            this.colorMapPropertyEditor.TabStop = false;
            this.colorMapPropertyEditor.Visible = false;
            // 
            // pixelInterpolationCheckBox
            // 
            this.pixelInterpolationCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pixelInterpolationCheckBox.AutoSize = true;
            this.pixelInterpolationCheckBox.Location = new System.Drawing.Point(348, 19);
            this.pixelInterpolationCheckBox.Name = "pixelInterpolationCheckBox";
            this.pixelInterpolationCheckBox.Size = new System.Drawing.Size(106, 17);
            this.pixelInterpolationCheckBox.TabIndex = 4;
            this.pixelInterpolationCheckBox.Text = "Interpolate Pixels";
            this.pixelInterpolationCheckBox.UseVisualStyleBackColor = true;
            this.pixelInterpolationCheckBox.CheckedChanged += new System.EventHandler(this.OnPixelInterpolationCheckBoxCheckedChanged);
            // 
            // yIncrementNumericEdit
            // 
            this.yIncrementNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.yIncrementNumericEdit.Location = new System.Drawing.Point(263, 49);
            this.yIncrementNumericEdit.Name = "yIncrementNumericEdit";
            this.yIncrementNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.yIncrementNumericEdit.Range = new NationalInstruments.UI.Range(1, double.PositiveInfinity);
            this.yIncrementNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.yIncrementNumericEdit.TabIndex = 3;
            this.yIncrementNumericEdit.Value = 1;
            this.yIncrementNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnNumericEditAfterChangeValue);
            // 
            // yStartNumericEdit
            // 
            this.yStartNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.yStartNumericEdit.Location = new System.Drawing.Point(263, 19);
            this.yStartNumericEdit.Name = "yStartNumericEdit";
            this.yStartNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.yStartNumericEdit.TabIndex = 2;
            this.yStartNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnNumericEditAfterChangeValue);
            // 
            // yStartLabel
            // 
            this.yStartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.yStartLabel.AutoSize = true;
            this.yStartLabel.Location = new System.Drawing.Point(212, 23);
            this.yStartLabel.Name = "yStartLabel";
            this.yStartLabel.Size = new System.Drawing.Size(45, 13);
            this.yStartLabel.TabIndex = 2;
            this.yStartLabel.Text = "Y Start :";
            // 
            // xIncrementNumericEdit
            // 
            this.xIncrementNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xIncrementNumericEdit.Location = new System.Drawing.Point(111, 49);
            this.xIncrementNumericEdit.Name = "xIncrementNumericEdit";
            this.xIncrementNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.xIncrementNumericEdit.Range = new NationalInstruments.UI.Range(1, double.PositiveInfinity);
            this.xIncrementNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.xIncrementNumericEdit.TabIndex = 1;
            this.xIncrementNumericEdit.Value = 1;
            this.xIncrementNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnNumericEditAfterChangeValue);
            // 
            // xStartNumericEdit
            // 
            this.xStartNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xStartNumericEdit.Location = new System.Drawing.Point(111, 19);
            this.xStartNumericEdit.Name = "xStartNumericEdit";
            this.xStartNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.xStartNumericEdit.TabIndex = 0;
            this.xStartNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnNumericEditAfterChangeValue);
            // 
            // yIncrementLabel
            // 
            this.yIncrementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.yIncrementLabel.AutoSize = true;
            this.yIncrementLabel.Location = new System.Drawing.Point(187, 52);
            this.yIncrementLabel.Name = "yIncrementLabel";
            this.yIncrementLabel.Size = new System.Drawing.Size(70, 13);
            this.yIncrementLabel.TabIndex = 2;
            this.yIncrementLabel.Text = "Y Increment :";
            // 
            // xIncrementLabel
            // 
            this.xIncrementLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xIncrementLabel.AutoSize = true;
            this.xIncrementLabel.Location = new System.Drawing.Point(35, 52);
            this.xIncrementLabel.Name = "xIncrementLabel";
            this.xIncrementLabel.Size = new System.Drawing.Size(70, 13);
            this.xIncrementLabel.TabIndex = 2;
            this.xIncrementLabel.Text = "X Increment :";
            // 
            // xStartLabel
            // 
            this.xStartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xStartLabel.AutoSize = true;
            this.xStartLabel.Location = new System.Drawing.Point(60, 23);
            this.xStartLabel.Name = "xStartLabel";
            this.xStartLabel.Size = new System.Drawing.Size(45, 13);
            this.xStartLabel.TabIndex = 2;
            this.xStartLabel.Text = "X Start :";
            // 
            // xArraySizeNumericEdit
            // 
            this.xArraySizeNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.xArraySizeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.xArraySizeNumericEdit.Location = new System.Drawing.Point(216, 20);
            this.xArraySizeNumericEdit.Name = "xArraySizeNumericEdit";
            this.xArraySizeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.xArraySizeNumericEdit.Range = new NationalInstruments.UI.Range(10, 500);
            this.xArraySizeNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.xArraySizeNumericEdit.TabIndex = 7;
            this.xArraySizeNumericEdit.Value = 40;
            this.xArraySizeNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnNumericEditAfterChangeValue);
            // 
            // inputDataSizeLabel
            // 
            this.inputDataSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.inputDataSizeLabel.AutoSize = true;
            this.inputDataSizeLabel.Location = new System.Drawing.Point(124, 24);
            this.inputDataSizeLabel.Name = "inputDataSizeLabel";
            this.inputDataSizeLabel.Size = new System.Drawing.Size(86, 13);
            this.inputDataSizeLabel.TabIndex = 5;
            this.inputDataSizeLabel.Text = "Input Data Size :";
            // 
            // yArraySizeNumericEdit
            // 
            this.yArraySizeNumericEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.yArraySizeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.yArraySizeNumericEdit.Location = new System.Drawing.Point(290, 20);
            this.yArraySizeNumericEdit.Name = "yArraySizeNumericEdit";
            this.yArraySizeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.yArraySizeNumericEdit.Range = new NationalInstruments.UI.Range(10, 500);
            this.yArraySizeNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.yArraySizeNumericEdit.TabIndex = 8;
            this.yArraySizeNumericEdit.Value = 30;
            this.yArraySizeNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnNumericEditAfterChangeValue);
            // 
            // plotGroupBox
            // 
            this.plotGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.plotGroupBox.Controls.Add(this.yArraySizeNumericEdit);
            this.plotGroupBox.Controls.Add(this.inputDataSizeLabel);
            this.plotGroupBox.Controls.Add(this.sizeIndicationLabel);
            this.plotGroupBox.Controls.Add(this.xArraySizeNumericEdit);
            this.plotGroupBox.Location = new System.Drawing.Point(3, 92);
            this.plotGroupBox.Name = "plotGroupBox";
            this.plotGroupBox.Size = new System.Drawing.Size(489, 53);
            this.plotGroupBox.TabIndex = 1;
            this.plotGroupBox.TabStop = false;
            this.plotGroupBox.Text = "Input Data Size";
            // 
            // sizeIndicationLabel
            // 
            this.sizeIndicationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.sizeIndicationLabel.AutoSize = true;
            this.sizeIndicationLabel.Location = new System.Drawing.Point(274, 23);
            this.sizeIndicationLabel.Name = "sizeIndicationLabel";
            this.sizeIndicationLabel.Size = new System.Drawing.Size(14, 13);
            this.sizeIndicationLabel.TabIndex = 5;
            this.sizeIndicationLabel.Text = "X";
            // 
            // anchorBottomLeftRightPanel
            // 
            this.anchorBottomLeftRightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.anchorBottomLeftRightPanel.Controls.Add(this.settingsGroupBox);
            this.anchorBottomLeftRightPanel.Controls.Add(this.plotGroupBox);
            this.anchorBottomLeftRightPanel.Location = new System.Drawing.Point(9, 291);
            this.anchorBottomLeftRightPanel.Name = "anchorBottomLeftRightPanel";
            this.anchorBottomLeftRightPanel.Size = new System.Drawing.Size(498, 149);
            this.anchorBottomLeftRightPanel.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(512, 446);
            this.Controls.Add(this.anchorBottomLeftRightPanel);
            this.Controls.Add(this.intensityGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(520, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intensity Graph Plotting Example";
            ((System.ComponentModel.ISupportInitialize)(this.intensityGraph)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yIncrementNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yStartNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xIncrementNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStartNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xArraySizeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yArraySizeNumericEdit)).EndInit();
            this.plotGroupBox.ResumeLayout(false);
            this.plotGroupBox.PerformLayout();
            this.anchorBottomLeftRightPanel.ResumeLayout(false);
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

        private void GenerateDataAndPlot()
        {
            double[,] data = GenerateIntensityData((int)xArraySizeNumericEdit.Value, (int)yArraySizeNumericEdit.Value);
            intensityPlot.Plot(data, xStartNumericEdit.Value, xIncrementNumericEdit.Value, yStartNumericEdit.Value, yIncrementNumericEdit.Value);
        }

        private double[,] GenerateIntensityData(int xArraySize, int yArraySize)
        {
            // We generate data in a circular manner to suite this example.
            double[,] data = new double[xArraySize, yArraySize];

            // maxDistance is the distance that creates a maximum angle (here maxPhaseAngle = 5).
            double maxDistance = xArraySize <= yArraySize ? xArraySize : yArraySize;
            double maxPhaseAngle = 5;

            // amplitude defines the maximum data in the data array.
            double maxAmplitude = colorScale.Range.Interval / 2;
            double baseValue = colorScale.Range.Minimum + colorScale.Range.Interval / 2;

            for (int i = 0; i < xArraySize; i++)
            {
                for (int j = 0; j < yArraySize; j++)
                {
                    // Using the cirlcle equation, we get the distance from (i,j) from (0,0).
                    double distance = Math.Sqrt(i * i + j * j);

                    // Calculate the phase angle subtended by distance.
                    double phaseAngle = distance * maxPhaseAngle / maxDistance;

                    // Calculate the amplitude at the phaseAngle. Add it up with baseValue to get the data at (i,j).
                    data[i, j] = baseValue + maxAmplitude * Math.Sin(phaseAngle);
                }
            }

            return data;
        }

        private void OnNumericEditAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
        {
            GenerateDataAndPlot();
        }

        private void OnPixelInterpolationCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            intensityPlot.PixelInterpolation = pixelInterpolationCheckBox.Checked;
        }

        private void OnEditColorMapButtonClick(object sender, EventArgs e)
        {
            // When the 'Edit Color Map' button is clicked the property editor launches the color map editor.
            colorMapPropertyEditor.EditValue();
        }
    }
}
