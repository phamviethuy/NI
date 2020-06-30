using System;
using System.Drawing;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.UsingColorScale
{
    public class MainForm : System.Windows.Forms.Form
    {
        private bool radioButtonsEnabled;

        private IntensityGraph intensityGraph;
        private ColorScale colorScale;
        private IntensityPlot intensityPlot;
        private IntensityXAxis intensityXAxis;
        private IntensityYAxis intensityYAxis;
        private Button editColorMapButton;
        private RadioButton grayScaleColorsRadioButton;
        private RadioButton redToneColorsRadioButton;
        private RadioButton rainbowColorsRadioButton;
        private RadioButton highLowNormalColorsRadioButton;
        private PropertyEditor colorMapPropertyEditor;
        private RadioButton highLowColorsRadioButton;
        private GroupBox settingsGroupBox;
        private RadioButton customRadioButton;
        private bool editorLaunched;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeApplication();
            colorScale.ColorMap.CollectionChanged += new System.ComponentModel.CollectionChangeEventHandler(ColorMap_CollectionChanged);
        }

        void ColorMap_CollectionChanged(object sender, System.ComponentModel.CollectionChangeEventArgs e)
        {
            if (editorLaunched == true)
            {
                editorLaunched = false;
                ColorScaleModified();
                ConfigureColorScale();
            }
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
            this.grayScaleColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.redToneColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.customRadioButton = new System.Windows.Forms.RadioButton();
            this.rainbowColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.highLowNormalColorsRadioButton = new System.Windows.Forms.RadioButton();
            this.colorMapPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.highLowColorsRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.intensityGraph)).BeginInit();
            this.settingsGroupBox.SuspendLayout();
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
            this.intensityGraph.Location = new System.Drawing.Point(149, 16);
            this.intensityGraph.Name = "intensityGraph";
            this.intensityGraph.Plots.AddRange(new NationalInstruments.UI.IntensityPlot[] {
            this.intensityPlot});
            this.intensityGraph.Size = new System.Drawing.Size(370, 298);
            this.intensityGraph.TabIndex = 0;
            this.intensityGraph.XAxes.AddRange(new NationalInstruments.UI.IntensityXAxis[] {
            this.intensityXAxis});
            this.intensityGraph.YAxes.AddRange(new NationalInstruments.UI.IntensityYAxis[] {
            this.intensityYAxis});
            // 
            // colorScale
            // 
            this.colorScale.Caption = "Color Scale";
            this.colorScale.Range = new NationalInstruments.UI.Range(0, 10000);
            this.colorScale.RightCaptionOrientation = NationalInstruments.UI.VerticalCaptionOrientation.BottomToTop;
            // 
            // intensityPlot
            // 
            this.intensityPlot.ColorScale = this.colorScale;
            this.intensityPlot.XAxis = this.intensityXAxis;
            this.intensityPlot.YAxis = this.intensityYAxis;
            // 
            // intensityXAxis
            // 
            this.intensityXAxis.Caption = "Intensity X Axis";
            // 
            // intensityYAxis
            // 
            this.intensityYAxis.Caption = "Intensity Y Axis";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.settingsGroupBox.Controls.Add(this.editColorMapButton);
            this.settingsGroupBox.Controls.Add(this.grayScaleColorsRadioButton);
            this.settingsGroupBox.Controls.Add(this.redToneColorsRadioButton);
            this.settingsGroupBox.Controls.Add(this.customRadioButton);
            this.settingsGroupBox.Controls.Add(this.rainbowColorsRadioButton);
            this.settingsGroupBox.Controls.Add(this.highLowNormalColorsRadioButton);
            this.settingsGroupBox.Controls.Add(this.colorMapPropertyEditor);
            this.settingsGroupBox.Controls.Add(this.highLowColorsRadioButton);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 10);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(131, 304);
            this.settingsGroupBox.TabIndex = 0;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Color Map Settings";
            // 
            // editColorMapButton
            // 
            this.editColorMapButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.editColorMapButton.Location = new System.Drawing.Point(15, 161);
            this.editColorMapButton.Name = "editColorMapButton";
            this.editColorMapButton.Size = new System.Drawing.Size(95, 23);
            this.editColorMapButton.TabIndex = 5;
            this.editColorMapButton.Text = "Edit Color Map";
            this.editColorMapButton.UseVisualStyleBackColor = true;
            this.editColorMapButton.Click += new System.EventHandler(this.OnEditColorMapButtonClick);
            // 
            // grayScaleColorsRadioButton
            // 
            this.grayScaleColorsRadioButton.AutoSize = true;
            this.grayScaleColorsRadioButton.Location = new System.Drawing.Point(15, 23);
            this.grayScaleColorsRadioButton.Name = "grayScaleColorsRadioButton";
            this.grayScaleColorsRadioButton.Size = new System.Drawing.Size(77, 17);
            this.grayScaleColorsRadioButton.TabIndex = 0;
            this.grayScaleColorsRadioButton.TabStop = true;
            this.grayScaleColorsRadioButton.Text = "Gray Scale";
            this.grayScaleColorsRadioButton.UseVisualStyleBackColor = true;
            this.grayScaleColorsRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // redToneColorsRadioButton
            // 
            this.redToneColorsRadioButton.AutoSize = true;
            this.redToneColorsRadioButton.Location = new System.Drawing.Point(15, 46);
            this.redToneColorsRadioButton.Name = "redToneColorsRadioButton";
            this.redToneColorsRadioButton.Size = new System.Drawing.Size(73, 17);
            this.redToneColorsRadioButton.TabIndex = 1;
            this.redToneColorsRadioButton.TabStop = true;
            this.redToneColorsRadioButton.Text = "Red Tone";
            this.redToneColorsRadioButton.UseVisualStyleBackColor = true;
            this.redToneColorsRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // customRadioButton
            // 
            this.customRadioButton.AutoSize = true;
            this.customRadioButton.Location = new System.Drawing.Point(15, 138);
            this.customRadioButton.Name = "customRadioButton";
            this.customRadioButton.Size = new System.Drawing.Size(60, 17);
            this.customRadioButton.TabIndex = 4;
            this.customRadioButton.Text = "Custom";
            this.customRadioButton.UseVisualStyleBackColor = true;
            // 
            // rainbowColorsRadioButton
            // 
            this.rainbowColorsRadioButton.AutoSize = true;
            this.rainbowColorsRadioButton.Location = new System.Drawing.Point(15, 115);
            this.rainbowColorsRadioButton.Name = "rainbowColorsRadioButton";
            this.rainbowColorsRadioButton.Size = new System.Drawing.Size(67, 17);
            this.rainbowColorsRadioButton.TabIndex = 4;
            this.rainbowColorsRadioButton.TabStop = true;
            this.rainbowColorsRadioButton.Text = "Rainbow";
            this.rainbowColorsRadioButton.UseVisualStyleBackColor = true;
            this.rainbowColorsRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // highLowNormalColorsRadioButton
            // 
            this.highLowNormalColorsRadioButton.AutoSize = true;
            this.highLowNormalColorsRadioButton.Location = new System.Drawing.Point(15, 92);
            this.highLowNormalColorsRadioButton.Name = "highLowNormalColorsRadioButton";
            this.highLowNormalColorsRadioButton.Size = new System.Drawing.Size(106, 17);
            this.highLowNormalColorsRadioButton.TabIndex = 3;
            this.highLowNormalColorsRadioButton.TabStop = true;
            this.highLowNormalColorsRadioButton.Text = "High Normal Low";
            this.highLowNormalColorsRadioButton.UseVisualStyleBackColor = true;
            this.highLowNormalColorsRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // colorMapPropertyEditor
            // 
            this.colorMapPropertyEditor.BackColor = System.Drawing.SystemColors.Control;
            this.colorMapPropertyEditor.Location = new System.Drawing.Point(29, 161);
            this.colorMapPropertyEditor.Name = "colorMapPropertyEditor";
            this.colorMapPropertyEditor.Size = new System.Drawing.Size(81, 20);
            this.colorMapPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.colorScale, "ColorMap");
            this.colorMapPropertyEditor.TabIndex = 3;
            this.colorMapPropertyEditor.TabStop = false;
            this.colorMapPropertyEditor.Visible = false;
            // 
            // highLowColorsRadioButton
            // 
            this.highLowColorsRadioButton.AutoSize = true;
            this.highLowColorsRadioButton.Location = new System.Drawing.Point(15, 69);
            this.highLowColorsRadioButton.Name = "highLowColorsRadioButton";
            this.highLowColorsRadioButton.Size = new System.Drawing.Size(70, 17);
            this.highLowColorsRadioButton.TabIndex = 2;
            this.highLowColorsRadioButton.TabStop = true;
            this.highLowColorsRadioButton.Text = "High Low";
            this.highLowColorsRadioButton.UseVisualStyleBackColor = true;
            this.highLowColorsRadioButton.CheckedChanged += new System.EventHandler(this.OnRadioButtonCheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(532, 324);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.intensityGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(540, 345);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using Color Scale In Intensity Graph";
            ((System.ComponentModel.ISupportInitialize)(this.intensityGraph)).EndInit();
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private void InitializeApplication()
        {
            double[,] data = GenerateIntensityData();
            intensityPlot.Plot(data);

            radioButtonsEnabled = true;
            grayScaleColorsRadioButton.Checked = true;
            customRadioButton.Enabled = false;
        }

        private void OnRadioButtonCheckedChanged(object sender, EventArgs e)
        {
            // A predefined ColorScale setting is selected. So just disable the custom radio button.
            if (customRadioButton.Enabled == true)
            {
                customRadioButton.Enabled = false;
            }

            // Configure the ColorScale for the selected predefined ColorScale setting.
            ConfigureColorScale();
        }

        private void ConfigureColorScale()
        {
            // Configuring ColorScale for plotting includes configuring the following ColorScale properties : 
            // Range, InterpolateColors, ScaleType, LowColor, HighColor and ColorMap.
            if (radioButtonsEnabled)
            {
                editorLaunched = false;
                colorScale.ColorMap.Clear();
                colorScale.Range = new Range(0, 10000);
                colorScale.InterpolateColor = true;
                colorScale.ScaleType = ScaleType.Linear;

                if (grayScaleColorsRadioButton.Checked)
                {
                    colorScale.LowColor = Color.Black;
                    colorScale.HighColor = Color.White;
                }
                else if (redToneColorsRadioButton.Checked)
                {
                    colorScale.LowColor = Color.DarkRed;
                    colorScale.ColorMap.Add(2500, Color.Brown);
                    colorScale.ColorMap.Add(5000, Color.Red);
                    colorScale.ColorMap.Add(7500, Color.Orange);
                    colorScale.HighColor = Color.Yellow;
                }
                else if (highLowColorsRadioButton.Checked)
                {
                    colorScale.LowColor = Color.Blue;
                    colorScale.HighColor = Color.Red;
                }
                else if (highLowNormalColorsRadioButton.Checked)
                {
                    colorScale.LowColor = Color.Blue;
                    colorScale.ColorMap.Add(5000, Color.Lime);
                    colorScale.HighColor = Color.Red;
                }
                else if (rainbowColorsRadioButton.Checked)
                {
                    colorScale.LowColor = Color.DarkViolet;
                    colorScale.ColorMap.Add(1500, Color.Indigo);
                    colorScale.ColorMap.Add(3000, Color.Blue);
                    colorScale.ColorMap.Add(5000, Color.Green);
                    colorScale.ColorMap.Add(7000, Color.Yellow);
                    colorScale.ColorMap.Add(8500, Color.Orange);
                    colorScale.HighColor = Color.Red;
                }
            }
        }

        private void OnEditColorMapButtonClick(object sender, EventArgs e)
        {
            // Launch the color map editor.
            editorLaunched = true;
            colorMapPropertyEditor.EditValue();
        }

        private void ColorScaleModified()
        {
            radioButtonsEnabled = false;
            grayScaleColorsRadioButton.Checked = false;
            redToneColorsRadioButton.Checked = false;   
            highLowColorsRadioButton.Checked = false;
            highLowNormalColorsRadioButton.Checked = false;
            rainbowColorsRadioButton.Checked = false;
            
            //Enable and select the radio button for custom settings when a ColorScale property is changed.
            customRadioButton.Checked = true;
            customRadioButton.Enabled = true;

            radioButtonsEnabled = true;
        }

        private double[,] GenerateIntensityData()
        {
            int size = 201;
            int radius = 100;
            double[,] data = new double[size, size];
            // Here we generate data in a circular manner.
            // Use the equation of a circle and transpose the origin.
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    data[radius + i, radius + j] = i * i + j * j;
                }
            }
            return data;
        }
    }
}
