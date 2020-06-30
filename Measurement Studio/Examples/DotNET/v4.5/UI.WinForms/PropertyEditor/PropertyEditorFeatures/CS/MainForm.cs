using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.PropertyEditorFeatures
{
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private System.Windows.Forms.ComboBox propertyEditorInteractionModeComboBox;
        private System.Windows.Forms.ComboBox propertyEditorBorderStyleComboBox;
        private System.Windows.Forms.ComboBox propertyEditorDisplayModeComboBox;
        private System.Windows.Forms.ComboBox propertyEditorTextAlignComboBox;
        private System.Windows.Forms.Label propertyEditorInteractionModeLabel;
        private System.Windows.Forms.Label propertyEditorBorderStyleLabel;
        private System.Windows.Forms.Label propertyEditorDisplayModeLabel;
        private System.Windows.Forms.Label propertyEditorTextAlignLabel;
        private System.Windows.Forms.GroupBox propertyEditorGroupBox;
        private NationalInstruments.UI.WindowsForms.PropertyEditor captionPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor annotationsPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor cursorsPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor canShowFocusPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor xAxisMajorDivisionsPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor xAxisModePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor xAxisLabelFormatPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor fontPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor borderPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor plotAreaColorPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor zoomFactorPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor interactionModePropertyEditor;
        private System.Windows.Forms.GroupBox graphGroupBox;
        private System.Windows.Forms.Label captionLabel;
        private System.Windows.Forms.Label annotationsLabel;
        private System.Windows.Forms.Label cursorsLabel;
        private System.Windows.Forms.Label showFocusLabel;
        private System.Windows.Forms.Label xAxisMajorDivisionsLabel;
        private System.Windows.Forms.Label xAxisModeLabel;
        private System.Windows.Forms.Label xAxisLabelFormatLabel;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Label borderLabel;
        private System.Windows.Forms.Label plotAreaColorLabel;
        private System.Windows.Forms.Label zoomFactorLabel;
        private System.Windows.Forms.Label interactionModeLabel;
        private System.Windows.Forms.StatusBar sampleStatusBar;
        private System.Windows.Forms.StatusBarPanel statusBarPanel;
        private System.Windows.Forms.Button chartButton;
        private System.Windows.Forms.Timer timer;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.CheckBox boundCheckBox;
        private NationalInstruments.UI.WindowsForms.Switch boundSwitch;
        private System.Windows.Forms.GroupBox twoWayBindingGroupBox;
        private System.Windows.Forms.Label bindingdesciptionLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor switchPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor checkBoxPropertyEditor;
        private Label checkBoxValueLabel;
        private Label switchValueLabel;
        private Random random;

		public MainForm()
		{
			InitializeComponent();

            foreach (object value in Enum.GetValues(typeof(PropertyEditorInteractionMode)))
            {
                propertyEditorInteractionModeComboBox.Items.Add(value);

                if (DefaultPropertyEditor.InteractionMode.Equals(value))
                {
                    propertyEditorInteractionModeComboBox.SelectedItem = value;
                }
            }

            foreach (object value in Enum.GetValues(typeof(BorderStyle)))
            {
                propertyEditorBorderStyleComboBox.Items.Add(value);

                if (DefaultPropertyEditor.BorderStyle.Equals(value))
                {
                    propertyEditorBorderStyleComboBox.SelectedItem = value;
                }
            }

            foreach (object value in Enum.GetValues(typeof(PropertyEditorDisplayMode)))
            {
                propertyEditorDisplayModeComboBox.Items.Add(value);

                if (DefaultPropertyEditor.DisplayMode.Equals(value))
                {
                    propertyEditorDisplayModeComboBox.SelectedItem = value;
                }
            }

            foreach (object value in Enum.GetValues(typeof(HorizontalAlignment)))
            {
                propertyEditorTextAlignComboBox.Items.Add(value);

                if (DefaultPropertyEditor.TextAlign.Equals(value))
                {
                    propertyEditorTextAlignComboBox.SelectedItem = value;
                }
            }

            double[] data = new double[20];
            random = new Random();

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = random.NextDouble() * yAxis1.Range.Maximum;
            }

            sampleWaveformGraph.PlotY(data);

            xAxisLabelFormatPropertyEditor.Source = new PropertyEditorSource(xAxis1.MajorDivisions, "LabelFormat");
		}

        private PropertyEditor DefaultPropertyEditor
        {
            get
            {
                return interactionModePropertyEditor;
            }
        }

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}

			base.Dispose(disposing);
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
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.propertyEditorInteractionModeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorBorderStyleComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorDisplayModeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorTextAlignComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorInteractionModeLabel = new System.Windows.Forms.Label();
            this.propertyEditorBorderStyleLabel = new System.Windows.Forms.Label();
            this.propertyEditorDisplayModeLabel = new System.Windows.Forms.Label();
            this.propertyEditorTextAlignLabel = new System.Windows.Forms.Label();
            this.propertyEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.graphGroupBox = new System.Windows.Forms.GroupBox();
            this.captionLabel = new System.Windows.Forms.Label();
            this.captionPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.annotationsLabel = new System.Windows.Forms.Label();
            this.annotationsPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.cursorsLabel = new System.Windows.Forms.Label();
            this.cursorsPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.showFocusLabel = new System.Windows.Forms.Label();
            this.canShowFocusPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.xAxisMajorDivisionsLabel = new System.Windows.Forms.Label();
            this.xAxisMajorDivisionsPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.xAxisModeLabel = new System.Windows.Forms.Label();
            this.xAxisModePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.xAxisLabelFormatLabel = new System.Windows.Forms.Label();
            this.xAxisLabelFormatPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.borderLabel = new System.Windows.Forms.Label();
            this.borderPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.plotAreaColorLabel = new System.Windows.Forms.Label();
            this.plotAreaColorPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.zoomFactorLabel = new System.Windows.Forms.Label();
            this.zoomFactorPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.interactionModeLabel = new System.Windows.Forms.Label();
            this.interactionModePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.sampleStatusBar = new System.Windows.Forms.StatusBar();
            this.statusBarPanel = new System.Windows.Forms.StatusBarPanel();
            this.chartButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.twoWayBindingGroupBox = new System.Windows.Forms.GroupBox();
            this.switchValueLabel = new System.Windows.Forms.Label();
            this.checkBoxValueLabel = new System.Windows.Forms.Label();
            this.bindingdesciptionLabel = new System.Windows.Forms.Label();
            this.boundCheckBox = new System.Windows.Forms.CheckBox();
            this.switchPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.boundSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.checkBoxPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.propertyEditorGroupBox.SuspendLayout();
            this.graphGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).BeginInit();
            this.twoWayBindingGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boundSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleWaveformGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(536, 166);
            this.sampleWaveformGraph.TabIndex = 0;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // propertyEditorInteractionModeComboBox
            // 
            this.propertyEditorInteractionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorInteractionModeComboBox.Location = new System.Drawing.Point(16, 64);
            this.propertyEditorInteractionModeComboBox.Name = "propertyEditorInteractionModeComboBox";
            this.propertyEditorInteractionModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorInteractionModeComboBox.TabIndex = 1;
            this.propertyEditorInteractionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorInteractionModeChanged);
            // 
            // propertyEditorBorderStyleComboBox
            // 
            this.propertyEditorBorderStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorBorderStyleComboBox.Location = new System.Drawing.Point(144, 64);
            this.propertyEditorBorderStyleComboBox.Name = "propertyEditorBorderStyleComboBox";
            this.propertyEditorBorderStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorBorderStyleComboBox.TabIndex = 3;
            this.propertyEditorBorderStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorBorderStyleChanged);
            // 
            // propertyEditorDisplayModeComboBox
            // 
            this.propertyEditorDisplayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorDisplayModeComboBox.Location = new System.Drawing.Point(272, 64);
            this.propertyEditorDisplayModeComboBox.Name = "propertyEditorDisplayModeComboBox";
            this.propertyEditorDisplayModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorDisplayModeComboBox.TabIndex = 5;
            this.propertyEditorDisplayModeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorDisplayModeChanged);
            // 
            // propertyEditorTextAlignComboBox
            // 
            this.propertyEditorTextAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorTextAlignComboBox.Location = new System.Drawing.Point(400, 64);
            this.propertyEditorTextAlignComboBox.Name = "propertyEditorTextAlignComboBox";
            this.propertyEditorTextAlignComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorTextAlignComboBox.TabIndex = 7;
            this.propertyEditorTextAlignComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorTextAlignChanged);
            // 
            // propertyEditorInteractionModeLabel
            // 
            this.propertyEditorInteractionModeLabel.Location = new System.Drawing.Point(16, 32);
            this.propertyEditorInteractionModeLabel.Name = "propertyEditorInteractionModeLabel";
            this.propertyEditorInteractionModeLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorInteractionModeLabel.TabIndex = 0;
            this.propertyEditorInteractionModeLabel.Text = "Interaction Mode:";
            // 
            // propertyEditorBorderStyleLabel
            // 
            this.propertyEditorBorderStyleLabel.Location = new System.Drawing.Point(144, 32);
            this.propertyEditorBorderStyleLabel.Name = "propertyEditorBorderStyleLabel";
            this.propertyEditorBorderStyleLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorBorderStyleLabel.TabIndex = 2;
            this.propertyEditorBorderStyleLabel.Text = "Border Style:";
            // 
            // propertyEditorDisplayModeLabel
            // 
            this.propertyEditorDisplayModeLabel.Location = new System.Drawing.Point(272, 32);
            this.propertyEditorDisplayModeLabel.Name = "propertyEditorDisplayModeLabel";
            this.propertyEditorDisplayModeLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorDisplayModeLabel.TabIndex = 4;
            this.propertyEditorDisplayModeLabel.Text = "Display Mode:";
            // 
            // propertyEditorTextAlignLabel
            // 
            this.propertyEditorTextAlignLabel.Location = new System.Drawing.Point(400, 32);
            this.propertyEditorTextAlignLabel.Name = "propertyEditorTextAlignLabel";
            this.propertyEditorTextAlignLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorTextAlignLabel.TabIndex = 6;
            this.propertyEditorTextAlignLabel.Text = "Text Align:";
            // 
            // propertyEditorGroupBox
            // 
            this.propertyEditorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorDisplayModeComboBox);
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorInteractionModeLabel);
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorBorderStyleComboBox);
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorInteractionModeComboBox);
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorBorderStyleLabel);
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorTextAlignComboBox);
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorTextAlignLabel);
            this.propertyEditorGroupBox.Controls.Add(this.propertyEditorDisplayModeLabel);
            this.propertyEditorGroupBox.Location = new System.Drawing.Point(8, 214);
            this.propertyEditorGroupBox.Name = "propertyEditorGroupBox";
            this.propertyEditorGroupBox.Size = new System.Drawing.Size(536, 104);
            this.propertyEditorGroupBox.TabIndex = 2;
            this.propertyEditorGroupBox.TabStop = false;
            this.propertyEditorGroupBox.Text = "Property Editor";
            // 
            // graphGroupBox
            // 
            this.graphGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.graphGroupBox.Controls.Add(this.captionLabel);
            this.graphGroupBox.Controls.Add(this.captionPropertyEditor);
            this.graphGroupBox.Controls.Add(this.annotationsLabel);
            this.graphGroupBox.Controls.Add(this.annotationsPropertyEditor);
            this.graphGroupBox.Controls.Add(this.cursorsLabel);
            this.graphGroupBox.Controls.Add(this.cursorsPropertyEditor);
            this.graphGroupBox.Controls.Add(this.showFocusLabel);
            this.graphGroupBox.Controls.Add(this.canShowFocusPropertyEditor);
            this.graphGroupBox.Controls.Add(this.xAxisMajorDivisionsLabel);
            this.graphGroupBox.Controls.Add(this.xAxisMajorDivisionsPropertyEditor);
            this.graphGroupBox.Controls.Add(this.xAxisModeLabel);
            this.graphGroupBox.Controls.Add(this.xAxisModePropertyEditor);
            this.graphGroupBox.Controls.Add(this.xAxisLabelFormatLabel);
            this.graphGroupBox.Controls.Add(this.xAxisLabelFormatPropertyEditor);
            this.graphGroupBox.Controls.Add(this.fontLabel);
            this.graphGroupBox.Controls.Add(this.fontPropertyEditor);
            this.graphGroupBox.Controls.Add(this.borderLabel);
            this.graphGroupBox.Controls.Add(this.borderPropertyEditor);
            this.graphGroupBox.Controls.Add(this.plotAreaColorLabel);
            this.graphGroupBox.Controls.Add(this.plotAreaColorPropertyEditor);
            this.graphGroupBox.Controls.Add(this.zoomFactorLabel);
            this.graphGroupBox.Controls.Add(this.zoomFactorPropertyEditor);
            this.graphGroupBox.Controls.Add(this.interactionModeLabel);
            this.graphGroupBox.Controls.Add(this.interactionModePropertyEditor);
            this.graphGroupBox.Location = new System.Drawing.Point(8, 334);
            this.graphGroupBox.Name = "graphGroupBox";
            this.graphGroupBox.Size = new System.Drawing.Size(536, 232);
            this.graphGroupBox.TabIndex = 3;
            this.graphGroupBox.TabStop = false;
            this.graphGroupBox.Text = "Graph";
            // 
            // captionLabel
            // 
            this.captionLabel.Location = new System.Drawing.Point(400, 24);
            this.captionLabel.Name = "captionLabel";
            this.captionLabel.Size = new System.Drawing.Size(100, 23);
            this.captionLabel.TabIndex = 6;
            this.captionLabel.Text = "Caption:";
            // 
            // captionPropertyEditor
            // 
            this.captionPropertyEditor.Location = new System.Drawing.Point(400, 56);
            this.captionPropertyEditor.Name = "captionPropertyEditor";
            this.captionPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.captionPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Caption");
            this.captionPropertyEditor.TabIndex = 7;
            this.captionPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnCaptionWarning);
            this.captionPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnCaptionChanged);
            // 
            // annotationsLabel
            // 
            this.annotationsLabel.Location = new System.Drawing.Point(400, 168);
            this.annotationsLabel.Name = "annotationsLabel";
            this.annotationsLabel.Size = new System.Drawing.Size(100, 23);
            this.annotationsLabel.TabIndex = 22;
            this.annotationsLabel.Text = "Annotations:";
            // 
            // annotationsPropertyEditor
            // 
            this.annotationsPropertyEditor.BackColor = System.Drawing.SystemColors.Control;
            this.annotationsPropertyEditor.Location = new System.Drawing.Point(400, 200);
            this.annotationsPropertyEditor.Name = "annotationsPropertyEditor";
            this.annotationsPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.annotationsPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Annotations");
            this.annotationsPropertyEditor.TabIndex = 23;
            this.annotationsPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnAnnotationsWarning);
            this.annotationsPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnAnnotationsChanged);
            // 
            // cursorsLabel
            // 
            this.cursorsLabel.Location = new System.Drawing.Point(272, 168);
            this.cursorsLabel.Name = "cursorsLabel";
            this.cursorsLabel.Size = new System.Drawing.Size(100, 23);
            this.cursorsLabel.TabIndex = 20;
            this.cursorsLabel.Text = "Cursors:";
            // 
            // cursorsPropertyEditor
            // 
            this.cursorsPropertyEditor.BackColor = System.Drawing.SystemColors.Control;
            this.cursorsPropertyEditor.Location = new System.Drawing.Point(272, 200);
            this.cursorsPropertyEditor.Name = "cursorsPropertyEditor";
            this.cursorsPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.cursorsPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Cursors");
            this.cursorsPropertyEditor.TabIndex = 21;
            this.cursorsPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnCursorsWarning);
            this.cursorsPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnCursorsChanged);
            // 
            // showFocusLabel
            // 
            this.showFocusLabel.Location = new System.Drawing.Point(272, 24);
            this.showFocusLabel.Name = "showFocusLabel";
            this.showFocusLabel.Size = new System.Drawing.Size(100, 23);
            this.showFocusLabel.TabIndex = 4;
            this.showFocusLabel.Text = "Show Focus:";
            // 
            // canShowFocusPropertyEditor
            // 
            this.canShowFocusPropertyEditor.Location = new System.Drawing.Point(272, 56);
            this.canShowFocusPropertyEditor.Name = "canShowFocusPropertyEditor";
            this.canShowFocusPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.canShowFocusPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "CanShowFocus");
            this.canShowFocusPropertyEditor.TabIndex = 5;
            this.canShowFocusPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnShowFocusWarning);
            this.canShowFocusPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnShowFocusChanged);
            // 
            // xAxisMajorDivisionsLabel
            // 
            this.xAxisMajorDivisionsLabel.Location = new System.Drawing.Point(144, 168);
            this.xAxisMajorDivisionsLabel.Name = "xAxisMajorDivisionsLabel";
            this.xAxisMajorDivisionsLabel.Size = new System.Drawing.Size(120, 23);
            this.xAxisMajorDivisionsLabel.TabIndex = 18;
            this.xAxisMajorDivisionsLabel.Text = "XAxis Major Divisions:";
            // 
            // xAxisMajorDivisionsPropertyEditor
            // 
            this.xAxisMajorDivisionsPropertyEditor.BackColor = System.Drawing.SystemColors.Control;
            this.xAxisMajorDivisionsPropertyEditor.Location = new System.Drawing.Point(144, 200);
            this.xAxisMajorDivisionsPropertyEditor.Name = "xAxisMajorDivisionsPropertyEditor";
            this.xAxisMajorDivisionsPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.xAxisMajorDivisionsPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.xAxis1, "MajorDivisions");
            this.xAxisMajorDivisionsPropertyEditor.TabIndex = 19;
            this.xAxisMajorDivisionsPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnXAxisMajorDivisionsWarning);
            this.xAxisMajorDivisionsPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnXAxisMajorDivisionsChanged);
            // 
            // xAxisModeLabel
            // 
            this.xAxisModeLabel.Location = new System.Drawing.Point(16, 168);
            this.xAxisModeLabel.Name = "xAxisModeLabel";
            this.xAxisModeLabel.Size = new System.Drawing.Size(100, 23);
            this.xAxisModeLabel.TabIndex = 16;
            this.xAxisModeLabel.Text = "XAxis Mode:";
            // 
            // xAxisModePropertyEditor
            // 
            this.xAxisModePropertyEditor.Location = new System.Drawing.Point(16, 200);
            this.xAxisModePropertyEditor.Name = "xAxisModePropertyEditor";
            this.xAxisModePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.xAxisModePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.xAxis1, "Mode");
            this.xAxisModePropertyEditor.TabIndex = 17;
            this.xAxisModePropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnXAxisModeWarning);
            this.xAxisModePropertyEditor.SourceValueChanged += new System.EventHandler(this.OnXAxisModeChanged);
            // 
            // xAxisLabelFormatLabel
            // 
            this.xAxisLabelFormatLabel.Location = new System.Drawing.Point(400, 96);
            this.xAxisLabelFormatLabel.Name = "xAxisLabelFormatLabel";
            this.xAxisLabelFormatLabel.Size = new System.Drawing.Size(120, 23);
            this.xAxisLabelFormatLabel.TabIndex = 14;
            this.xAxisLabelFormatLabel.Text = "XAxis Label Format:";
            // 
            // xAxisLabelFormatPropertyEditor
            // 
            this.xAxisLabelFormatPropertyEditor.Location = new System.Drawing.Point(400, 128);
            this.xAxisLabelFormatPropertyEditor.Name = "xAxisLabelFormatPropertyEditor";
            this.xAxisLabelFormatPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.xAxisLabelFormatPropertyEditor.TabIndex = 15;
            this.xAxisLabelFormatPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnXAxisLabelFormatWarning);
            this.xAxisLabelFormatPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnXAxisLabelFormatChanged);
            // 
            // fontLabel
            // 
            this.fontLabel.Location = new System.Drawing.Point(272, 96);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(100, 23);
            this.fontLabel.TabIndex = 12;
            this.fontLabel.Text = "Font:";
            // 
            // fontPropertyEditor
            // 
            this.fontPropertyEditor.Location = new System.Drawing.Point(272, 128);
            this.fontPropertyEditor.Name = "fontPropertyEditor";
            this.fontPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.fontPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Font");
            this.fontPropertyEditor.TabIndex = 13;
            this.fontPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnFontWarning);
            this.fontPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // borderLabel
            // 
            this.borderLabel.Location = new System.Drawing.Point(16, 96);
            this.borderLabel.Name = "borderLabel";
            this.borderLabel.Size = new System.Drawing.Size(100, 23);
            this.borderLabel.TabIndex = 8;
            this.borderLabel.Text = "Border:";
            // 
            // borderPropertyEditor
            // 
            this.borderPropertyEditor.Location = new System.Drawing.Point(16, 128);
            this.borderPropertyEditor.Name = "borderPropertyEditor";
            this.borderPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.borderPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Border");
            this.borderPropertyEditor.TabIndex = 9;
            this.borderPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnBorderWarning);
            this.borderPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnBorderChanged);
            // 
            // plotAreaColorLabel
            // 
            this.plotAreaColorLabel.Location = new System.Drawing.Point(144, 96);
            this.plotAreaColorLabel.Name = "plotAreaColorLabel";
            this.plotAreaColorLabel.Size = new System.Drawing.Size(100, 23);
            this.plotAreaColorLabel.TabIndex = 10;
            this.plotAreaColorLabel.Text = "Plot Area Color:";
            // 
            // plotAreaColorPropertyEditor
            // 
            this.plotAreaColorPropertyEditor.Location = new System.Drawing.Point(144, 128);
            this.plotAreaColorPropertyEditor.Name = "plotAreaColorPropertyEditor";
            this.plotAreaColorPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.plotAreaColorPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "PlotAreaColor");
            this.plotAreaColorPropertyEditor.TabIndex = 11;
            this.plotAreaColorPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnPlotAreaColorWarning);
            this.plotAreaColorPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnPlotAreaColorChanged);
            // 
            // zoomFactorLabel
            // 
            this.zoomFactorLabel.Location = new System.Drawing.Point(144, 24);
            this.zoomFactorLabel.Name = "zoomFactorLabel";
            this.zoomFactorLabel.Size = new System.Drawing.Size(100, 23);
            this.zoomFactorLabel.TabIndex = 2;
            this.zoomFactorLabel.Text = "Zoom Factor:";
            // 
            // zoomFactorPropertyEditor
            // 
            this.zoomFactorPropertyEditor.Location = new System.Drawing.Point(144, 56);
            this.zoomFactorPropertyEditor.Name = "zoomFactorPropertyEditor";
            this.zoomFactorPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.zoomFactorPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "ZoomFactor");
            this.zoomFactorPropertyEditor.TabIndex = 3;
            this.zoomFactorPropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnZoomFactorWarning);
            this.zoomFactorPropertyEditor.SourceValueChanged += new System.EventHandler(this.OnZoomFactorChanged);
            // 
            // interactionModeLabel
            // 
            this.interactionModeLabel.Location = new System.Drawing.Point(16, 24);
            this.interactionModeLabel.Name = "interactionModeLabel";
            this.interactionModeLabel.Size = new System.Drawing.Size(100, 23);
            this.interactionModeLabel.TabIndex = 0;
            this.interactionModeLabel.Text = "Interaction Mode:";
            // 
            // interactionModePropertyEditor
            // 
            this.interactionModePropertyEditor.Location = new System.Drawing.Point(16, 56);
            this.interactionModePropertyEditor.Name = "interactionModePropertyEditor";
            this.interactionModePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.interactionModePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "InteractionMode");
            this.interactionModePropertyEditor.TabIndex = 1;
            this.interactionModePropertyEditor.SourceValueWarning += new NationalInstruments.UI.PropertyEditorSourceValueWarningEventHandler(this.OnInteractionModeWarning);
            this.interactionModePropertyEditor.SourceValueChanged += new System.EventHandler(this.OnInteractionModeChanged);
            // 
            // sampleStatusBar
            // 
            this.sampleStatusBar.Location = new System.Drawing.Point(0, 726);
            this.sampleStatusBar.Name = "sampleStatusBar";
            this.sampleStatusBar.ShowPanels = true;
            this.sampleStatusBar.Size = new System.Drawing.Size(552, 22);
            this.sampleStatusBar.TabIndex = 5;
            // 
            // statusBarPanel
            // 
            this.statusBarPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;            
            this.statusBarPanel.Width = 535;
            // 
            // chartButton
            // 
            this.chartButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chartButton.Location = new System.Drawing.Point(464, 190);
            this.chartButton.Name = "chartButton";
            this.chartButton.Size = new System.Drawing.Size(72, 23);
            this.chartButton.TabIndex = 1;
            this.chartButton.Text = "Chart";
            this.chartButton.Click += new System.EventHandler(this.OnChartButtonClick);
            // 
            // timer
            // 
            this.timer.Interval = 300;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // twoWayBindingGroupBox
            // 
            this.twoWayBindingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.twoWayBindingGroupBox.Controls.Add(this.switchValueLabel);
            this.twoWayBindingGroupBox.Controls.Add(this.checkBoxValueLabel);
            this.twoWayBindingGroupBox.Controls.Add(this.bindingdesciptionLabel);
            this.twoWayBindingGroupBox.Controls.Add(this.boundCheckBox);
            this.twoWayBindingGroupBox.Controls.Add(this.switchPropertyEditor);
            this.twoWayBindingGroupBox.Controls.Add(this.boundSwitch);
            this.twoWayBindingGroupBox.Controls.Add(this.checkBoxPropertyEditor);
            this.twoWayBindingGroupBox.Location = new System.Drawing.Point(16, 582);
            this.twoWayBindingGroupBox.Name = "twoWayBindingGroupBox";
            this.twoWayBindingGroupBox.Size = new System.Drawing.Size(528, 136);
            this.twoWayBindingGroupBox.TabIndex = 4;
            this.twoWayBindingGroupBox.TabStop = false;
            this.twoWayBindingGroupBox.Text = "Two-way Binding";
            // 
            // switchValueLabel
            // 
            this.switchValueLabel.AutoSize = true;
            this.switchValueLabel.Location = new System.Drawing.Point(375, 80);
            this.switchValueLabel.Name = "switchValueLabel";
            this.switchValueLabel.Size = new System.Drawing.Size(109, 13);
            this.switchValueLabel.TabIndex = 7;
            this.switchValueLabel.Text = "Property Editor Value:";
            // 
            // checkBoxValueLabel
            // 
            this.checkBoxValueLabel.AutoSize = true;
            this.checkBoxValueLabel.Location = new System.Drawing.Point(183, 80);
            this.checkBoxValueLabel.Name = "checkBoxValueLabel";
            this.checkBoxValueLabel.Size = new System.Drawing.Size(109, 13);
            this.checkBoxValueLabel.TabIndex = 6;
            this.checkBoxValueLabel.Text = "Property Editor Value:";
            // 
            // bindingdesciptionLabel
            // 
            this.bindingdesciptionLabel.Location = new System.Drawing.Point(16, 24);
            this.bindingdesciptionLabel.Name = "bindingdesciptionLabel";
            this.bindingdesciptionLabel.Size = new System.Drawing.Size(144, 96);
            this.bindingdesciptionLabel.TabIndex = 0;
            this.bindingdesciptionLabel.Text = "Change the value on the controls and property editors and verify the values stay " +
                "in sync.";
            // 
            // boundCheckBox
            // 
            this.boundCheckBox.Location = new System.Drawing.Point(184, 24);
            this.boundCheckBox.Name = "boundCheckBox";
            this.boundCheckBox.Size = new System.Drawing.Size(112, 24);
            this.boundCheckBox.TabIndex = 1;
            this.boundCheckBox.Text = "CheckBox";
            // 
            // switchPropertyEditor
            // 
            this.switchPropertyEditor.Location = new System.Drawing.Point(376, 105);
            this.switchPropertyEditor.Name = "switchPropertyEditor";
            this.switchPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.switchPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.boundSwitch, "Value");
            this.switchPropertyEditor.TabIndex = 4;
            // 
            // boundSwitch
            // 
            this.boundSwitch.Border = NationalInstruments.UI.Border.Solid;
            this.boundSwitch.Location = new System.Drawing.Point(376, 19);
            this.boundSwitch.Name = "boundSwitch";
            this.boundSwitch.Size = new System.Drawing.Size(136, 48);
            this.boundSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalSlide;
            this.boundSwitch.TabIndex = 3;
            // 
            // checkBoxPropertyEditor
            // 
            this.checkBoxPropertyEditor.Location = new System.Drawing.Point(184, 105);
            this.checkBoxPropertyEditor.Name = "checkBoxPropertyEditor";
            this.checkBoxPropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.checkBoxPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.boundCheckBox, "Checked");
            this.checkBoxPropertyEditor.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(552, 748);
            this.Controls.Add(this.twoWayBindingGroupBox);
            this.Controls.Add(this.sampleStatusBar);
            this.Controls.Add(this.graphGroupBox);
            this.Controls.Add(this.propertyEditorGroupBox);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.chartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Property Editor Features";
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            this.propertyEditorGroupBox.ResumeLayout(false);
            this.graphGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel)).EndInit();
            this.twoWayBindingGroupBox.ResumeLayout(false);
            this.twoWayBindingGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boundSwitch)).EndInit();
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

        private void OnPropertyEditorInteractionModeChanged(object sender, System.EventArgs e)
        {
            foreach (Control control in graphGroupBox.Controls)
            {
                if (control is PropertyEditor)
                {
                    ((PropertyEditor) control).InteractionMode = (PropertyEditorInteractionMode) propertyEditorInteractionModeComboBox.SelectedItem;
                }
            }
        }

        private void OnPropertyEditorBorderStyleChanged(object sender, System.EventArgs e)
        {
            foreach (Control control in graphGroupBox.Controls)
            {
                if (control is PropertyEditor)
                {
                    ((PropertyEditor) control).BorderStyle = (BorderStyle) propertyEditorBorderStyleComboBox.SelectedItem;
                }
            }        
        }

        private void OnPropertyEditorDisplayModeChanged(object sender, System.EventArgs e)
        {
            foreach (Control control in graphGroupBox.Controls)
            {
                if (control is PropertyEditor)
                {
                    ((PropertyEditor) control).DisplayMode = (PropertyEditorDisplayMode) propertyEditorDisplayModeComboBox.SelectedItem;
                }
            }        
        }

        private void OnPropertyEditorTextAlignChanged(object sender, System.EventArgs e)
        {
            foreach (Control control in graphGroupBox.Controls)
            {
                if (control is PropertyEditor)
                {
                    ((PropertyEditor) control).TextAlign = (HorizontalAlignment) propertyEditorTextAlignComboBox.SelectedItem;
                }
            }        
        }

        private void ResetError()
        {
            statusBarPanel.Text = String.Empty;
        }

        private void SetError(string invalidValue, string propertyName)
        {
            statusBarPanel.Text = String.Format("{0} is an invalid value for {1}.", invalidValue, propertyName);
        }

        private void OnInteractionModeChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnInteractionModeWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {        
            SetError(e.InvalidString, interactionModePropertyEditor.Source.PropertyName);
        }

        private void OnZoomFactorChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnZoomFactorWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, zoomFactorPropertyEditor.Source.PropertyName);
        }

        private void OnShowFocusChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnShowFocusWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, canShowFocusPropertyEditor.Source.PropertyName);
        }

        private void OnCaptionChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnCaptionWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, captionPropertyEditor.Source.PropertyName);
        }

        private void OnBorderChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnBorderWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, borderPropertyEditor.Source.PropertyName);
        }

        private void OnPlotAreaColorChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnPlotAreaColorWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, plotAreaColorPropertyEditor.Source.PropertyName);
        }

        private void OnFontChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnFontWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, fontPropertyEditor.Source.PropertyName);
        }

        private void OnXAxisLabelFormatChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnXAxisLabelFormatWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, xAxisLabelFormatPropertyEditor.Source.PropertyName);
        }

        private void OnXAxisModeChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnXAxisModeWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, xAxisModePropertyEditor.Source.PropertyName);
        }

        private void OnXAxisMajorDivisionsChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnXAxisMajorDivisionsWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, xAxisMajorDivisionsPropertyEditor.Source.PropertyName);
        }

        private void OnCursorsChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnCursorsWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, cursorsPropertyEditor.Source.PropertyName);
        }

        private void OnAnnotationsChanged(object sender, System.EventArgs e)
        {
            ResetError();
        }

        private void OnAnnotationsWarning(object sender, NationalInstruments.UI.PropertyEditorSourceValueWarningEventArgs e)
        {
            SetError(e.InvalidString, annotationsPropertyEditor.Source.PropertyName);
        }

        private void OnChartButtonClick(object sender, System.EventArgs e)
        {
            timer.Enabled = !timer.Enabled;
        }

        private void OnTimerTick(object sender, System.EventArgs e)
        {
            sampleWaveformGraph.PlotYAppend(random.NextDouble() * yAxis1.Range.Maximum);
        }
	}
}
