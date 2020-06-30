using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using System.Globalization;
using System.Drawing.Design;

namespace NationalInstruments.Examples.Extensibility
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private Random rand;
        private NationalInstruments.UI.WindowsForms.WaveformGraph displayWaveformGraph;
        private NationalInstruments.UI.WindowsForms.PropertyEditor xAxisRangePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor yAxisRangePropertyEditor;
        private System.Windows.Forms.Label xAxisRangeLabel;
        private System.Windows.Forms.Label yAxisRangeLabel;
        private System.Windows.Forms.Button appendPointButton;
        private System.Windows.Forms.GroupBox customTypeConverterGroupBox;
        private System.Windows.Forms.GroupBox customEditorGroupBox;
        private System.Windows.Forms.Label lineColorLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor plotLinePropertyEditor;
        private System.Windows.Forms.Label defaultXAxisRangeLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor defaultXAxisPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor defaultYAxisPropertyEditor;
        private System.Windows.Forms.Label defaultYAxisRangeLabel;
        private System.Windows.Forms.GroupBox defaultcolorEditorGroupBox;
        private System.Windows.Forms.Label defaultLineColorLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor defaultPlotLinePropertyEditor;
        private NationalInstruments.UI.WaveformPlot defaultWaveformPlot;
        private NationalInstruments.UI.XAxis defaultXAxis;
        private NationalInstruments.UI.YAxis defaultYAxis;
        private System.Windows.Forms.GroupBox defaultTypeConverterGroupBox;
		
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			
			InitializeComponent();
            rand = new Random();
            displayWaveformGraph.PlotY(GetRandomValues(10));

            plotLinePropertyEditor.Source = new PlotColorPropertyEditorSource(defaultWaveformPlot, "LineColor");
            xAxisRangePropertyEditor.Source = new RangePropertyEditorSource(defaultXAxis, "Range");
            yAxisRangePropertyEditor.Source = new RangePropertyEditorSource(defaultYAxis, "Range");
		}        

        private double[] GetRandomValues(int count)
        {
            double[] data = new double[count];
            for(int x = 0; x < data.Length; x++)
                data[x] = rand.NextDouble() * 100;
            return data;
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
            this.displayWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.defaultWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.defaultXAxis = new NationalInstruments.UI.XAxis();
            this.defaultYAxis = new NationalInstruments.UI.YAxis();
            this.xAxisRangePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.yAxisRangePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.xAxisRangeLabel = new System.Windows.Forms.Label();
            this.yAxisRangeLabel = new System.Windows.Forms.Label();
            this.appendPointButton = new System.Windows.Forms.Button();
            this.customTypeConverterGroupBox = new System.Windows.Forms.GroupBox();
            this.customEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.lineColorLabel = new System.Windows.Forms.Label();
            this.plotLinePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.defaultTypeConverterGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultXAxisRangeLabel = new System.Windows.Forms.Label();
            this.defaultXAxisPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.defaultYAxisPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.defaultYAxisRangeLabel = new System.Windows.Forms.Label();
            this.defaultcolorEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.defaultLineColorLabel = new System.Windows.Forms.Label();
            this.defaultPlotLinePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            ((System.ComponentModel.ISupportInitialize)(this.displayWaveformGraph)).BeginInit();
            this.customTypeConverterGroupBox.SuspendLayout();
            this.customEditorGroupBox.SuspendLayout();
            this.defaultTypeConverterGroupBox.SuspendLayout();
            this.defaultcolorEditorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayWaveformGraph
            // 
            this.displayWaveformGraph.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayWaveformGraph.Location = new System.Drawing.Point(0, 0);
            this.displayWaveformGraph.Name = "displayWaveformGraph";
            this.displayWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
                                                                                                   this.defaultWaveformPlot});
            this.displayWaveformGraph.Size = new System.Drawing.Size(536, 200);
            this.displayWaveformGraph.TabIndex = 0;
            this.displayWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
                                                                                            this.defaultXAxis});
            this.displayWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
                                                                                            this.defaultYAxis});
            // 
            // defaultWaveformPlot
            // 
            this.defaultWaveformPlot.XAxis = this.defaultXAxis;
            this.defaultWaveformPlot.YAxis = this.defaultYAxis;
            // 
            // xAxisRangePropertyEditor
            // 
            this.xAxisRangePropertyEditor.Location = new System.Drawing.Point(96, 24);
            this.xAxisRangePropertyEditor.Name = "xAxisRangePropertyEditor";
            this.xAxisRangePropertyEditor.Size = new System.Drawing.Size(128, 20);
            this.xAxisRangePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.defaultXAxis, "Range");
            this.xAxisRangePropertyEditor.TabIndex = 1;
            // 
            // yAxisRangePropertyEditor
            // 
            this.yAxisRangePropertyEditor.Location = new System.Drawing.Point(96, 56);
            this.yAxisRangePropertyEditor.Name = "yAxisRangePropertyEditor";
            this.yAxisRangePropertyEditor.Size = new System.Drawing.Size(128, 20);
            this.yAxisRangePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.defaultYAxis, "Range");
            this.yAxisRangePropertyEditor.TabIndex = 2;
            // 
            // xAxisRangeLabel
            // 
            this.xAxisRangeLabel.AutoSize = true;
            this.xAxisRangeLabel.Location = new System.Drawing.Point(16, 24);
            this.xAxisRangeLabel.Name = "xAxisRangeLabel";
            this.xAxisRangeLabel.Size = new System.Drawing.Size(70, 16);
            this.xAxisRangeLabel.TabIndex = 3;
            this.xAxisRangeLabel.Text = "XAxis Range";
            // 
            // yAxisRangeLabel
            // 
            this.yAxisRangeLabel.AutoSize = true;
            this.yAxisRangeLabel.Location = new System.Drawing.Point(16, 56);
            this.yAxisRangeLabel.Name = "yAxisRangeLabel";
            this.yAxisRangeLabel.Size = new System.Drawing.Size(70, 16);
            this.yAxisRangeLabel.TabIndex = 4;
            this.yAxisRangeLabel.Text = "YAxis Range";
            // 
            // appendPointButton
            // 
            this.appendPointButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.appendPointButton.Location = new System.Drawing.Point(400, 208);
            this.appendPointButton.Name = "appendPointButton";
            this.appendPointButton.Size = new System.Drawing.Size(88, 23);
            this.appendPointButton.TabIndex = 3;
            this.appendPointButton.Text = "Append Point";
            this.appendPointButton.Click += new System.EventHandler(this.OnAppendClick);
            // 
            // customTypeConverterGroupBox
            // 
            this.customTypeConverterGroupBox.Controls.Add(this.xAxisRangeLabel);
            this.customTypeConverterGroupBox.Controls.Add(this.yAxisRangePropertyEditor);
            this.customTypeConverterGroupBox.Controls.Add(this.xAxisRangePropertyEditor);
            this.customTypeConverterGroupBox.Controls.Add(this.yAxisRangeLabel);
            this.customTypeConverterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customTypeConverterGroupBox.Location = new System.Drawing.Point(8, 344);
            this.customTypeConverterGroupBox.Name = "customTypeConverterGroupBox";
            this.customTypeConverterGroupBox.Size = new System.Drawing.Size(248, 96);
            this.customTypeConverterGroupBox.TabIndex = 2;
            this.customTypeConverterGroupBox.TabStop = false;
            this.customTypeConverterGroupBox.Text = "Custom Range Type Converter";
            // 
            // customEditorGroupBox
            // 
            this.customEditorGroupBox.Controls.Add(this.lineColorLabel);
            this.customEditorGroupBox.Controls.Add(this.plotLinePropertyEditor);
            this.customEditorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.customEditorGroupBox.Location = new System.Drawing.Point(280, 344);
            this.customEditorGroupBox.Name = "customEditorGroupBox";
            this.customEditorGroupBox.Size = new System.Drawing.Size(248, 72);
            this.customEditorGroupBox.TabIndex = 5;
            this.customEditorGroupBox.TabStop = false;
            this.customEditorGroupBox.Text = "Custom Color Editor";
            // 
            // lineColorLabel
            // 
            this.lineColorLabel.AutoSize = true;
            this.lineColorLabel.Location = new System.Drawing.Point(16, 24);
            this.lineColorLabel.Name = "lineColorLabel";
            this.lineColorLabel.Size = new System.Drawing.Size(78, 16);
            this.lineColorLabel.TabIndex = 1;
            this.lineColorLabel.Text = "Plot Line Color";
            // 
            // plotLinePropertyEditor
            // 
            this.plotLinePropertyEditor.Location = new System.Drawing.Point(104, 24);
            this.plotLinePropertyEditor.Name = "plotLinePropertyEditor";
            this.plotLinePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.defaultWaveformPlot, "LineColor");
            this.plotLinePropertyEditor.TabIndex = 0;
            // 
            // defaultTypeConverterGroupBox
            // 
            this.defaultTypeConverterGroupBox.Controls.Add(this.defaultXAxisRangeLabel);
            this.defaultTypeConverterGroupBox.Controls.Add(this.defaultXAxisPropertyEditor);
            this.defaultTypeConverterGroupBox.Controls.Add(this.defaultYAxisPropertyEditor);
            this.defaultTypeConverterGroupBox.Controls.Add(this.defaultYAxisRangeLabel);
            this.defaultTypeConverterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultTypeConverterGroupBox.Location = new System.Drawing.Point(8, 240);
            this.defaultTypeConverterGroupBox.Name = "defaultTypeConverterGroupBox";
            this.defaultTypeConverterGroupBox.Size = new System.Drawing.Size(248, 96);
            this.defaultTypeConverterGroupBox.TabIndex = 1;
            this.defaultTypeConverterGroupBox.TabStop = false;
            this.defaultTypeConverterGroupBox.Text = "Default Range Type Converter";
            // 
            // defaultXAxisRangeLabel
            // 
            this.defaultXAxisRangeLabel.AutoSize = true;
            this.defaultXAxisRangeLabel.Location = new System.Drawing.Point(16, 24);
            this.defaultXAxisRangeLabel.Name = "defaultXAxisRangeLabel";
            this.defaultXAxisRangeLabel.Size = new System.Drawing.Size(70, 16);
            this.defaultXAxisRangeLabel.TabIndex = 3;
            this.defaultXAxisRangeLabel.Text = "XAxis Range";
            // 
            // defaultXAxisPropertyEditor
            // 
            this.defaultXAxisPropertyEditor.Location = new System.Drawing.Point(96, 56);
            this.defaultXAxisPropertyEditor.Name = "defaultXAxisPropertyEditor";
            this.defaultXAxisPropertyEditor.Size = new System.Drawing.Size(128, 20);
            this.defaultXAxisPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.defaultYAxis, "Range");
            this.defaultXAxisPropertyEditor.TabIndex = 2;
            // 
            // defaultYAxisPropertyEditor
            // 
            this.defaultYAxisPropertyEditor.Location = new System.Drawing.Point(96, 24);
            this.defaultYAxisPropertyEditor.Name = "defaultYAxisPropertyEditor";
            this.defaultYAxisPropertyEditor.Size = new System.Drawing.Size(128, 20);
            this.defaultYAxisPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.defaultXAxis, "Range");
            this.defaultYAxisPropertyEditor.TabIndex = 0;
            // 
            // defaultYAxisRangeLabel
            // 
            this.defaultYAxisRangeLabel.AutoSize = true;
            this.defaultYAxisRangeLabel.Location = new System.Drawing.Point(16, 56);
            this.defaultYAxisRangeLabel.Name = "defaultYAxisRangeLabel";
            this.defaultYAxisRangeLabel.Size = new System.Drawing.Size(70, 16);
            this.defaultYAxisRangeLabel.TabIndex = 4;
            this.defaultYAxisRangeLabel.Text = "YAxis Range";
            // 
            // defaultcolorEditorGroupBox
            // 
            this.defaultcolorEditorGroupBox.Controls.Add(this.defaultLineColorLabel);
            this.defaultcolorEditorGroupBox.Controls.Add(this.defaultPlotLinePropertyEditor);
            this.defaultcolorEditorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.defaultcolorEditorGroupBox.Location = new System.Drawing.Point(280, 240);
            this.defaultcolorEditorGroupBox.Name = "defaultcolorEditorGroupBox";
            this.defaultcolorEditorGroupBox.Size = new System.Drawing.Size(248, 72);
            this.defaultcolorEditorGroupBox.TabIndex = 4;
            this.defaultcolorEditorGroupBox.TabStop = false;
            this.defaultcolorEditorGroupBox.Text = "Default Color Editor";
            // 
            // defaultLineColorLabel
            // 
            this.defaultLineColorLabel.AutoSize = true;
            this.defaultLineColorLabel.Location = new System.Drawing.Point(16, 24);
            this.defaultLineColorLabel.Name = "defaultLineColorLabel";
            this.defaultLineColorLabel.Size = new System.Drawing.Size(78, 16);
            this.defaultLineColorLabel.TabIndex = 1;
            this.defaultLineColorLabel.Text = "Plot Line Color";
            // 
            // defaultPlotLinePropertyEditor
            // 
            this.defaultPlotLinePropertyEditor.Location = new System.Drawing.Point(104, 24);
            this.defaultPlotLinePropertyEditor.Name = "defaultPlotLinePropertyEditor";
            this.defaultPlotLinePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.defaultWaveformPlot, "LineColor");
            this.defaultPlotLinePropertyEditor.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(536, 462);
            this.Controls.Add(this.defaultcolorEditorGroupBox);
            this.Controls.Add(this.defaultTypeConverterGroupBox);
            this.Controls.Add(this.customEditorGroupBox);
            this.Controls.Add(this.customTypeConverterGroupBox);
            this.Controls.Add(this.appendPointButton);
            this.Controls.Add(this.displayWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Extensibility";
            ((System.ComponentModel.ISupportInitialize)(this.displayWaveformGraph)).EndInit();
            this.customTypeConverterGroupBox.ResumeLayout(false);
            this.customEditorGroupBox.ResumeLayout(false);
            this.defaultTypeConverterGroupBox.ResumeLayout(false);
            this.defaultcolorEditorGroupBox.ResumeLayout(false);
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

        private void OnAppendClick(object sender, System.EventArgs e)
        {
            displayWaveformGraph.PlotYAppend(GetRandomValues(1));
        }

        public class CustomRangeConverter : TypeConverter
        {
            private TypeConverter _baseConverter;

            private const char Separator = '-';

            public CustomRangeConverter(TypeConverter baseConverter)
            {
                _baseConverter = baseConverter;
            }

            public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
            {
                return _baseConverter.CanConvertFrom(context, sourceType);
            }

            public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
            {
                if ((value != null) && (value is string))
                {
                    string valueText = value as string;
                    valueText = valueText.Trim();
                    string[] parts = valueText.Split(Separator);

                    if (parts.Length <= 1 || parts.Length > 2)
                    {
                        throw new FormatException();
                    }

                    double minimum;
                    double maximum;

                    try
                    {
                        minimum = Double.Parse(parts[0], CultureInfo.CurrentCulture);
                    }
                    catch (FormatException ex)
                    {
                        throw new FormatException("minimum", ex);
                    }

                    try
                    {
                        maximum = Double.Parse(parts[1], CultureInfo.CurrentCulture);
                    }
                    catch (FormatException ex)
                    {
                        throw new FormatException("maximum", ex);
                    }

                    return new Range(minimum, maximum);
                }

                return _baseConverter.ConvertFrom(context, culture, value);
            }

            public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
            {
                return _baseConverter.CanConvertTo(context, destinationType);
            }

            public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
            {
                if ((value != null) && (value is Range))
                {
                    Range range = value as Range;
                    return String.Format(CultureInfo.InvariantCulture, "{0:R} {1} {2:R}", range.Minimum, Separator, range.Maximum);
                }

                return _baseConverter.ConvertTo(context, culture, value, destinationType);
            }
        }

        public class CustomGraphColorEditor : UITypeEditor
        {
            public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
            {
                return UITypeEditorEditStyle.None;
            }

            public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
            {
                return base.EditValue (context, provider, value);
            }
        }

        public class RangePropertyEditorSource : PropertyEditorSource
        {
            private CustomRangeConverter _customRangeConverter;

            public RangePropertyEditorSource(object obj, string propertyName) : base(obj, propertyName)
            {
                TypeConverter rangeConverter = TypeDescriptor.GetConverter(typeof(Range));
                _customRangeConverter = new CustomRangeConverter(rangeConverter);
            }

            public override TypeConverter Converter
            {
                get
                {
                    return _customRangeConverter;
                }
            }
        }

        public class PlotColorPropertyEditorSource : PropertyEditorSource
        {
            private CustomGraphColorEditor _editor;

            public PlotColorPropertyEditorSource(object obj, string propertyName) : base(obj, propertyName)
            {
                _editor = new CustomGraphColorEditor();
            }

            public override UITypeEditor Editor
            {
                get
                {
                    return _editor;
                }
            }
        }



	}
}
