namespace NationalInstruments.Examples.Features
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.sampleWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.sampleXAxis = new NationalInstruments.UI.XAxis();
            this.sampleYAxis = new NationalInstruments.UI.YAxis();
            this.sampleInstrumentControlStrip = new NationalInstruments.UI.WindowsForms.InstrumentControlStrip();
            this.interactionModeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.interactionModeToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.zoomFactorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.zoomFactorToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.showFocusToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.showFocusToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.captionToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.captionToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.borderToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.borderToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.plotAreaColorToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.plotAreaColorToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.fontToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fontToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.xAxisLabelFormatToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.xAxisLabelFormatToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.xAxisMajorDivisionsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.xAxisMajorDivisionsToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.annotationsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.annotationsToolStripPropertyEditor = new NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor();
            this.propertyEditorInteractionModeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorBorderStyleComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorRenderModeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorDisplayModeComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorTextAlignComboBox = new System.Windows.Forms.ComboBox();
            this.propertyEditorInteractionModeLabel = new System.Windows.Forms.Label();
            this.propertyEditorBorderStyleLabel = new System.Windows.Forms.Label();
            this.propertyEditorTextAlignLabel = new System.Windows.Forms.Label();
            this.propertyEditorDisplayModeLabel = new System.Windows.Forms.Label();
            this.propertyEditorRenderModeLabel = new System.Windows.Forms.Label();
            this.toolStripPropertyEditorSettingsGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.sampleInstrumentControlStrip.SuspendLayout();
            this.toolStripPropertyEditorSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleWaveformGraph.Location = new System.Drawing.Point(12, 37);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.sampleWaveformPlot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(409, 264);
            this.sampleWaveformGraph.TabIndex = 1;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.sampleXAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.sampleYAxis});
            // 
            // sampleWaveformPlot
            // 
            this.sampleWaveformPlot.XAxis = this.sampleXAxis;
            this.sampleWaveformPlot.XErrorHighPointSize = new System.Drawing.Size(5, 5);
            this.sampleWaveformPlot.XErrorLowPointSize = new System.Drawing.Size(5, 5);
            this.sampleWaveformPlot.YAxis = this.sampleYAxis;
            this.sampleWaveformPlot.YErrorHighPointSize = new System.Drawing.Size(5, 5);
            this.sampleWaveformPlot.YErrorLowPointSize = new System.Drawing.Size(5, 5);
            // 
            // sampleInstrumentControlStrip
            // 
            this.sampleInstrumentControlStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interactionModeToolStripLabel,
            this.interactionModeToolStripPropertyEditor,
            this.zoomFactorToolStripLabel,
            this.zoomFactorToolStripPropertyEditor,
            this.showFocusToolStripLabel,
            this.showFocusToolStripPropertyEditor,
            this.captionToolStripLabel,
            this.captionToolStripPropertyEditor,
            this.borderToolStripLabel,
            this.borderToolStripPropertyEditor,
            this.plotAreaColorToolStripLabel,
            this.plotAreaColorToolStripPropertyEditor,
            this.fontToolStripLabel,
            this.fontToolStripPropertyEditor,
            this.xAxisLabelFormatToolStripLabel,
            this.xAxisLabelFormatToolStripPropertyEditor,
            this.xAxisMajorDivisionsToolStripLabel,
            this.xAxisMajorDivisionsToolStripPropertyEditor,
            this.annotationsToolStripLabel,
            this.annotationsToolStripPropertyEditor});
            this.sampleInstrumentControlStrip.Location = new System.Drawing.Point(0, 0);
            this.sampleInstrumentControlStrip.Name = "sampleInstrumentControlStrip";
            this.sampleInstrumentControlStrip.Size = new System.Drawing.Size(433, 25);
            this.sampleInstrumentControlStrip.TabIndex = 0;
            this.sampleInstrumentControlStrip.Text = "propertyEditorStrip";
            // 
            // interactionModeToolStripLabel
            // 
            this.interactionModeToolStripLabel.Name = "interactionModeToolStripLabel";
            this.interactionModeToolStripLabel.Size = new System.Drawing.Size(93, 22);
            this.interactionModeToolStripLabel.Text = "Interaction Mode:";
            // 
            // interactionModeToolStripPropertyEditor
            // 
            this.interactionModeToolStripPropertyEditor.AutoSize = false;
            this.interactionModeToolStripPropertyEditor.Name = "interactionModeToolStripPropertyEditor";
            this.interactionModeToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.interactionModeToolStripPropertyEditor.Size = new System.Drawing.Size(120, 16);
            this.interactionModeToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "InteractionMode");
            // 
            // zoomFactorToolStripLabel
            // 
            this.zoomFactorToolStripLabel.Name = "zoomFactorToolStripLabel";
            this.zoomFactorToolStripLabel.Size = new System.Drawing.Size(71, 22);
            this.zoomFactorToolStripLabel.Text = "Zoom Factor:";
            // 
            // zoomFactorToolStripPropertyEditor
            // 
            this.zoomFactorToolStripPropertyEditor.AutoSize = false;
            this.zoomFactorToolStripPropertyEditor.Name = "zoomFactorToolStripPropertyEditor";
            this.zoomFactorToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.zoomFactorToolStripPropertyEditor.Size = new System.Drawing.Size(120, 16);
            this.zoomFactorToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "ZoomFactor");
            // 
            // showFocusToolStripLabel
            // 
            this.showFocusToolStripLabel.Name = "showFocusToolStripLabel";
            this.showFocusToolStripLabel.Size = new System.Drawing.Size(68, 13);
            this.showFocusToolStripLabel.Text = "Show Focus:";
            // 
            // showFocusToolStripPropertyEditor
            // 
            this.showFocusToolStripPropertyEditor.AutoSize = false;
            this.showFocusToolStripPropertyEditor.Name = "showFocusToolStripPropertyEditor";
            this.showFocusToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.showFocusToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            this.showFocusToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "CanShowFocus");
            // 
            // captionToolStripLabel
            // 
            this.captionToolStripLabel.Name = "captionToolStripLabel";
            this.captionToolStripLabel.Size = new System.Drawing.Size(48, 13);
            this.captionToolStripLabel.Text = "Caption:";
            // 
            // captionToolStripPropertyEditor
            // 
            this.captionToolStripPropertyEditor.AutoSize = false;
            this.captionToolStripPropertyEditor.Name = "captionToolStripPropertyEditor";
            this.captionToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.captionToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            this.captionToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Caption");
            // 
            // borderToolStripLabel
            // 
            this.borderToolStripLabel.Name = "borderToolStripLabel";
            this.borderToolStripLabel.Size = new System.Drawing.Size(43, 13);
            this.borderToolStripLabel.Text = "Border:";
            // 
            // borderToolStripPropertyEditor
            // 
            this.borderToolStripPropertyEditor.AutoSize = false;
            this.borderToolStripPropertyEditor.Name = "borderToolStripPropertyEditor";
            this.borderToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.borderToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            this.borderToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Border");
            // 
            // plotAreaColorToolStripLabel
            // 
            this.plotAreaColorToolStripLabel.Name = "plotAreaColorToolStripLabel";
            this.plotAreaColorToolStripLabel.Size = new System.Drawing.Size(83, 13);
            this.plotAreaColorToolStripLabel.Text = "Plot Area Color:";
            // 
            // plotAreaColorToolStripPropertyEditor
            // 
            this.plotAreaColorToolStripPropertyEditor.AutoSize = false;
            this.plotAreaColorToolStripPropertyEditor.Name = "plotAreaColorToolStripPropertyEditor";
            this.plotAreaColorToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.plotAreaColorToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            this.plotAreaColorToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "PlotAreaColor");
            // 
            // fontToolStripLabel
            // 
            this.fontToolStripLabel.Name = "fontToolStripLabel";
            this.fontToolStripLabel.Size = new System.Drawing.Size(33, 13);
            this.fontToolStripLabel.Text = "Font:";
            // 
            // fontToolStripPropertyEditor
            // 
            this.fontToolStripPropertyEditor.AutoSize = false;
            this.fontToolStripPropertyEditor.Name = "fontToolStripPropertyEditor";
            this.fontToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.fontToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            this.fontToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Font");
            // 
            // xAxisLabelFormatToolStripLabel
            // 
            this.xAxisLabelFormatToolStripLabel.Name = "xAxisLabelFormatToolStripLabel";
            this.xAxisLabelFormatToolStripLabel.Size = new System.Drawing.Size(102, 13);
            this.xAxisLabelFormatToolStripLabel.Text = "XAxis Label Format:";
            // 
            // xAxisLabelFormatToolStripPropertyEditor
            // 
            this.xAxisLabelFormatToolStripPropertyEditor.AutoSize = false;
            this.xAxisLabelFormatToolStripPropertyEditor.Name = "xAxisLabelFormatToolStripPropertyEditor";
            this.xAxisLabelFormatToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.xAxisLabelFormatToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            // 
            // xAxisMajorDivisionsToolStripLabel
            // 
            this.xAxisMajorDivisionsToolStripLabel.Name = "xAxisMajorDivisionsToolStripLabel";
            this.xAxisMajorDivisionsToolStripLabel.Size = new System.Drawing.Size(111, 13);
            this.xAxisMajorDivisionsToolStripLabel.Text = "XAxis Major Divisions:";
            // 
            // xAxisMajorDivisionsToolStripPropertyEditor
            // 
            this.xAxisMajorDivisionsToolStripPropertyEditor.AutoSize = false;
            this.xAxisMajorDivisionsToolStripPropertyEditor.Name = "xAxisMajorDivisionsToolStripPropertyEditor";
            this.xAxisMajorDivisionsToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.xAxisMajorDivisionsToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            this.xAxisMajorDivisionsToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleXAxis, "MajorDivisions");
            // 
            // annotationsToolStripLabel
            // 
            this.annotationsToolStripLabel.Name = "annotationsToolStripLabel";
            this.annotationsToolStripLabel.Size = new System.Drawing.Size(69, 13);
            this.annotationsToolStripLabel.Text = "Annotations:";
            // 
            // annotationsToolStripPropertyEditor
            // 
            this.annotationsToolStripPropertyEditor.AutoSize = false;
            this.annotationsToolStripPropertyEditor.Name = "annotationsToolStripPropertyEditor";
            this.annotationsToolStripPropertyEditor.RenderMode = NationalInstruments.UI.PropertyEditorRenderMode.Inherit;
            this.annotationsToolStripPropertyEditor.Size = new System.Drawing.Size(120, 21);
            this.annotationsToolStripPropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.sampleWaveformGraph, "Annotations");
            // 
            // propertyEditorInteractionModeComboBox
            // 
            this.propertyEditorInteractionModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyEditorInteractionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorInteractionModeComboBox.FormattingEnabled = true;
            this.propertyEditorInteractionModeComboBox.Location = new System.Drawing.Point(29, 52);
            this.propertyEditorInteractionModeComboBox.Name = "propertyEditorInteractionModeComboBox";
            this.propertyEditorInteractionModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorInteractionModeComboBox.TabIndex = 2;
            this.propertyEditorInteractionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorInteractionModeChanged);
            // 
            // propertyEditorBorderStyleComboBox
            // 
            this.propertyEditorBorderStyleComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyEditorBorderStyleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorBorderStyleComboBox.FormattingEnabled = true;
            this.propertyEditorBorderStyleComboBox.Location = new System.Drawing.Point(29, 111);
            this.propertyEditorBorderStyleComboBox.Name = "propertyEditorBorderStyleComboBox";
            this.propertyEditorBorderStyleComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorBorderStyleComboBox.TabIndex = 3;
            this.propertyEditorBorderStyleComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorBorderStyleChanged);
            // 
            // propertyEditorRenderModeComboBox
            // 
            this.propertyEditorRenderModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyEditorRenderModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorRenderModeComboBox.FormattingEnabled = true;
            this.propertyEditorRenderModeComboBox.Location = new System.Drawing.Point(29, 171);
            this.propertyEditorRenderModeComboBox.Name = "propertyEditorRenderModeComboBox";
            this.propertyEditorRenderModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorRenderModeComboBox.TabIndex = 4;
            this.propertyEditorRenderModeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorRenderModeChanged);
            // 
            // propertyEditorDisplayModeComboBox
            // 
            this.propertyEditorDisplayModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyEditorDisplayModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorDisplayModeComboBox.FormattingEnabled = true;
            this.propertyEditorDisplayModeComboBox.Location = new System.Drawing.Point(275, 52);
            this.propertyEditorDisplayModeComboBox.Name = "propertyEditorDisplayModeComboBox";
            this.propertyEditorDisplayModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorDisplayModeComboBox.TabIndex = 5;
            this.propertyEditorDisplayModeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorDisplayModeChanged);
            // 
            // propertyEditorTextAlignComboBox
            // 
            this.propertyEditorTextAlignComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyEditorTextAlignComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.propertyEditorTextAlignComboBox.FormattingEnabled = true;
            this.propertyEditorTextAlignComboBox.Location = new System.Drawing.Point(275, 111);
            this.propertyEditorTextAlignComboBox.Name = "propertyEditorTextAlignComboBox";
            this.propertyEditorTextAlignComboBox.Size = new System.Drawing.Size(121, 21);
            this.propertyEditorTextAlignComboBox.TabIndex = 6;
            this.propertyEditorTextAlignComboBox.SelectedIndexChanged += new System.EventHandler(this.OnPropertyEditorTextAlignChanged);
            // 
            // propertyEditorInteractionModeLabel
            // 
            this.propertyEditorInteractionModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyEditorInteractionModeLabel.Location = new System.Drawing.Point(26, 26);
            this.propertyEditorInteractionModeLabel.Name = "propertyEditorInteractionModeLabel";
            this.propertyEditorInteractionModeLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorInteractionModeLabel.TabIndex = 7;
            this.propertyEditorInteractionModeLabel.Text = "Interaction Mode:";
            // 
            // propertyEditorBorderStyleLabel
            // 
            this.propertyEditorBorderStyleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyEditorBorderStyleLabel.Location = new System.Drawing.Point(26, 85);
            this.propertyEditorBorderStyleLabel.Name = "propertyEditorBorderStyleLabel";
            this.propertyEditorBorderStyleLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorBorderStyleLabel.TabIndex = 8;
            this.propertyEditorBorderStyleLabel.Text = "Border Style:";
            // 
            // propertyEditorTextAlignLabel
            // 
            this.propertyEditorTextAlignLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyEditorTextAlignLabel.Location = new System.Drawing.Point(272, 85);
            this.propertyEditorTextAlignLabel.Name = "propertyEditorTextAlignLabel";
            this.propertyEditorTextAlignLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorTextAlignLabel.TabIndex = 10;
            this.propertyEditorTextAlignLabel.Text = "Text Align:";
            // 
            // propertyEditorDisplayModeLabel
            // 
            this.propertyEditorDisplayModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyEditorDisplayModeLabel.Location = new System.Drawing.Point(272, 26);
            this.propertyEditorDisplayModeLabel.Name = "propertyEditorDisplayModeLabel";
            this.propertyEditorDisplayModeLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorDisplayModeLabel.TabIndex = 9;
            this.propertyEditorDisplayModeLabel.Text = "Display Mode:";
            // 
            // propertyEditorRenderModeLabel
            // 
            this.propertyEditorRenderModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.propertyEditorRenderModeLabel.Location = new System.Drawing.Point(26, 145);
            this.propertyEditorRenderModeLabel.Name = "propertyEditorRenderModeLabel";
            this.propertyEditorRenderModeLabel.Size = new System.Drawing.Size(100, 23);
            this.propertyEditorRenderModeLabel.TabIndex = 11;
            this.propertyEditorRenderModeLabel.Text = "Render Mode:";
            // 
            // toolStripPropertyEditorSettingsGroupBox
            // 
            this.toolStripPropertyEditorSettingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorInteractionModeLabel);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorRenderModeLabel);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorInteractionModeComboBox);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorBorderStyleComboBox);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorBorderStyleLabel);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorRenderModeComboBox);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorTextAlignLabel);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorDisplayModeComboBox);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorDisplayModeLabel);
            this.toolStripPropertyEditorSettingsGroupBox.Controls.Add(this.propertyEditorTextAlignComboBox);
            this.toolStripPropertyEditorSettingsGroupBox.Location = new System.Drawing.Point(12, 311);
            this.toolStripPropertyEditorSettingsGroupBox.Name = "toolStripPropertyEditorSettingsGroupBox";
            this.toolStripPropertyEditorSettingsGroupBox.Size = new System.Drawing.Size(409, 208);
            this.toolStripPropertyEditorSettingsGroupBox.TabIndex = 2;
            this.toolStripPropertyEditorSettingsGroupBox.TabStop = false;
            this.toolStripPropertyEditorSettingsGroupBox.Text = "Tool Strip Property Editor Settings";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 527);
            this.Controls.Add(this.toolStripPropertyEditorSettingsGroupBox);
            this.Controls.Add(this.sampleInstrumentControlStrip);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Instrument Control Strip Features";
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            this.sampleInstrumentControlStrip.ResumeLayout(false);
            this.sampleInstrumentControlStrip.PerformLayout();
            this.toolStripPropertyEditorSettingsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private NationalInstruments.UI.WaveformPlot sampleWaveformPlot;
        private NationalInstruments.UI.XAxis sampleXAxis;
        private NationalInstruments.UI.YAxis sampleYAxis;
        private NationalInstruments.UI.WindowsForms.InstrumentControlStrip sampleInstrumentControlStrip;
        private System.Windows.Forms.ComboBox propertyEditorInteractionModeComboBox;
        private System.Windows.Forms.ComboBox propertyEditorBorderStyleComboBox;
        private System.Windows.Forms.ComboBox propertyEditorRenderModeComboBox;
        private System.Windows.Forms.ComboBox propertyEditorDisplayModeComboBox;
        private System.Windows.Forms.ComboBox propertyEditorTextAlignComboBox;
        private System.Windows.Forms.Label propertyEditorInteractionModeLabel;
        private System.Windows.Forms.Label propertyEditorBorderStyleLabel;
        private System.Windows.Forms.Label propertyEditorTextAlignLabel;
        private System.Windows.Forms.Label propertyEditorDisplayModeLabel;
        private System.Windows.Forms.Label propertyEditorRenderModeLabel;
        private System.Windows.Forms.ToolStripLabel interactionModeToolStripLabel;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor interactionModeToolStripPropertyEditor;
        private System.Windows.Forms.ToolStripLabel zoomFactorToolStripLabel;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor zoomFactorToolStripPropertyEditor;
        private System.Windows.Forms.ToolStripLabel showFocusToolStripLabel;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor showFocusToolStripPropertyEditor;
        private System.Windows.Forms.ToolStripLabel captionToolStripLabel;
        private System.Windows.Forms.ToolStripLabel borderToolStripLabel;
        private System.Windows.Forms.ToolStripLabel plotAreaColorToolStripLabel;
        private System.Windows.Forms.ToolStripLabel fontToolStripLabel;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor captionToolStripPropertyEditor;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor borderToolStripPropertyEditor;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor plotAreaColorToolStripPropertyEditor;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor fontToolStripPropertyEditor;
        private System.Windows.Forms.ToolStripLabel xAxisLabelFormatToolStripLabel;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor xAxisLabelFormatToolStripPropertyEditor;
        private System.Windows.Forms.ToolStripLabel xAxisMajorDivisionsToolStripLabel;
        private System.Windows.Forms.ToolStripLabel annotationsToolStripLabel;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor xAxisMajorDivisionsToolStripPropertyEditor;
        private NationalInstruments.UI.WindowsForms.ToolStripPropertyEditor annotationsToolStripPropertyEditor;
        private System.Windows.Forms.GroupBox toolStripPropertyEditorSettingsGroupBox;
    }
}

