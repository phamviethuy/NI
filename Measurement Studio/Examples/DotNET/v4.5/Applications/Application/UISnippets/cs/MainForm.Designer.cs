namespace NationalInstruments.Examples.Snippets
{
    /// <summary>
    /// Main form for the application
    /// </summary>
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.controlsTabControl = new System.Windows.Forms.TabControl();
            this.waveformGraphTabPage = new System.Windows.Forms.TabPage();
            this.waveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.scatterGraphTabPage = new System.Windows.Forms.TabPage();
            this.scatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.scatterPlot1 = new NationalInstruments.UI.ScatterPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.complexGraphTabPage = new System.Windows.Forms.TabPage();
            this.complexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.complexPlot1 = new NationalInstruments.UI.ComplexPlot();
            this.complexXAxis1 = new NationalInstruments.UI.ComplexXAxis();
            this.complexYAxis1 = new NationalInstruments.UI.ComplexYAxis();
            this.digitalWaveformGraphTabPage = new System.Windows.Forms.TabPage();
            this.digitalWaveformGraph = new NationalInstruments.UI.WindowsForms.DigitalWaveformGraph();
            this.intensityGraphTabPage = new System.Windows.Forms.TabPage();
            this.intensityGraph = new NationalInstruments.UI.WindowsForms.IntensityGraph();
            this.colorScale1 = new NationalInstruments.UI.ColorScale();
            this.intensityPlot1 = new NationalInstruments.UI.IntensityPlot();
            this.intensityXAxis1 = new NationalInstruments.UI.IntensityXAxis();
            this.intensityYAxis1 = new NationalInstruments.UI.IntensityYAxis();
            this.numericControlsTabPage = new System.Windows.Forms.TabPage();
            this.slide = new NationalInstruments.UI.WindowsForms.Slide();
            this.gauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.uiLegend = new NationalInstruments.UI.WindowsForms.Legend();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorbandsLabel = new System.Windows.Forms.Label();
            this.tooltipsLabel = new System.Windows.Forms.Label();
            this.interpolateLabel = new System.Windows.Forms.Label();
            this.animateLabel = new System.Windows.Forms.Label();
            this.optionsLabel = new System.Windows.Forms.Label();
            this.optionsSwitches = new NationalInstruments.UI.WindowsForms.SwitchArray();
            this.panel2 = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.runSnippetButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.controlsComboBox = new System.Windows.Forms.ComboBox();
            this.availableControlsLabel = new System.Windows.Forms.Label();
            this.snipsComboBox = new System.Windows.Forms.ComboBox();
            this.availableSnippetsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.controlsTabControl.SuspendLayout();
            this.waveformGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph)).BeginInit();
            this.scatterGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph)).BeginInit();
            this.complexGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.complexGraph)).BeginInit();
            this.digitalWaveformGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digitalWaveformGraph)).BeginInit();
            this.intensityGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intensityGraph)).BeginInit();
            this.numericControlsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLegend)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsSwitches.ItemTemplate)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.tableLayoutPanel1.Controls.Add(this.commentTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.controlsTabControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.uiLegend, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(672, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(792, 572);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // commentTextBox
            // 
            this.commentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commentTextBox.Location = new System.Drawing.Point(3, 415);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentTextBox.Size = new System.Drawing.Size(356, 154);
            this.commentTextBox.TabIndex = 10;
            // 
            // controlsTabControl
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.controlsTabControl, 2);
            this.controlsTabControl.Controls.Add(this.waveformGraphTabPage);
            this.controlsTabControl.Controls.Add(this.scatterGraphTabPage);
            this.controlsTabControl.Controls.Add(this.complexGraphTabPage);
            this.controlsTabControl.Controls.Add(this.digitalWaveformGraphTabPage);
            this.controlsTabControl.Controls.Add(this.intensityGraphTabPage);
            this.controlsTabControl.Controls.Add(this.numericControlsTabPage);
            this.controlsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsTabControl.Location = new System.Drawing.Point(5, 5);
            this.controlsTabControl.Margin = new System.Windows.Forms.Padding(5);
            this.controlsTabControl.Name = "controlsTabControl";
            this.tableLayoutPanel1.SetRowSpan(this.controlsTabControl, 3);
            this.controlsTabControl.SelectedIndex = 0;
            this.controlsTabControl.Size = new System.Drawing.Size(612, 402);
            this.controlsTabControl.TabIndex = 1;
            this.controlsTabControl.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            this.controlsTabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // waveformGraphTabPage
            // 
            this.waveformGraphTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.waveformGraphTabPage.Controls.Add(this.waveformGraph);
            this.waveformGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.waveformGraphTabPage.Name = "waveformGraphTabPage";
            this.waveformGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.waveformGraphTabPage.Size = new System.Drawing.Size(604, 376);
            this.waveformGraphTabPage.TabIndex = 0;
            this.waveformGraphTabPage.Text = "Waveform Graph";
            this.waveformGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // waveformGraph
            // 
            this.waveformGraph.Caption = "Waveform Graph";
            this.waveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveformGraph.Location = new System.Drawing.Point(3, 3);
            this.waveformGraph.Name = "waveformGraph";
            this.waveformGraph.PlotLineColorGenerator = NationalInstruments.UI.FixedSetColorGenerator.Dark;
            this.waveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph.Size = new System.Drawing.Size(598, 370);
            this.waveformGraph.TabIndex = 0;
            this.waveformGraph.UseColorGenerator = true;
            this.waveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.waveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            this.waveformGraph.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.LineColor = System.Drawing.Color.Sienna;
            this.waveformPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.waveformPlot1.PointColor = System.Drawing.Color.GhostWhite;
            this.waveformPlot1.PointStyle = NationalInstruments.UI.PointStyle.Cross;
            this.waveformPlot1.XAxis = this.xAxis2;
            this.waveformPlot1.YAxis = this.yAxis2;
            // 
            // xAxis2
            // 
            this.xAxis2.Caption = "X-Axis";
            this.xAxis2.MajorDivisions.GridColor = System.Drawing.Color.DimGray;
            // 
            // yAxis2
            // 
            this.yAxis2.Caption = "Y-Axis";
            this.yAxis2.MajorDivisions.GridColor = System.Drawing.Color.DimGray;
            this.yAxis2.MajorDivisions.GridVisible = true;
            // 
            // scatterGraphTabPage
            // 
            this.scatterGraphTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.scatterGraphTabPage.Controls.Add(this.scatterGraph);
            this.scatterGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.scatterGraphTabPage.Name = "scatterGraphTabPage";
            this.scatterGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.scatterGraphTabPage.Size = new System.Drawing.Size(604, 376);
            this.scatterGraphTabPage.TabIndex = 1;
            this.scatterGraphTabPage.Text = "Scatter Graph";
            this.scatterGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // scatterGraph
            // 
            this.scatterGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scatterGraph.Location = new System.Drawing.Point(3, 3);
            this.scatterGraph.Name = "scatterGraph";
            this.scatterGraph.PlotLineColorGenerator = NationalInstruments.UI.FixedSetColorGenerator.Dark;
            this.scatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.scatterPlot1});
            this.scatterGraph.Size = new System.Drawing.Size(598, 370);
            this.scatterGraph.TabIndex = 0;
            this.scatterGraph.UseColorGenerator = true;
            this.scatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.scatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            this.scatterGraph.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            // 
            // scatterPlot1
            // 
            this.scatterPlot1.LineColor = System.Drawing.Color.Sienna;
            this.scatterPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.scatterPlot1.PointColor = System.Drawing.Color.GhostWhite;
            this.scatterPlot1.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle;
            this.scatterPlot1.XAxis = this.xAxis1;
            this.scatterPlot1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.Caption = "X-Axis";
            // 
            // yAxis1
            // 
            this.yAxis1.Caption = "Y-Axis";
            // 
            // complexGraphTabPage
            // 
            this.complexGraphTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.complexGraphTabPage.Controls.Add(this.complexGraph);
            this.complexGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.complexGraphTabPage.Name = "complexGraphTabPage";
            this.complexGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.complexGraphTabPage.Size = new System.Drawing.Size(604, 376);
            this.complexGraphTabPage.TabIndex = 2;
            this.complexGraphTabPage.Text = "Complex Graph";
            this.complexGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // complexGraph
            // 
            this.complexGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.complexGraph.Location = new System.Drawing.Point(3, 3);
            this.complexGraph.Name = "complexGraph";
            this.complexGraph.PlotLineColorGenerator = NationalInstruments.UI.FixedSetColorGenerator.Dark;
            this.complexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
            this.complexPlot1});
            this.complexGraph.Size = new System.Drawing.Size(598, 370);
            this.complexGraph.TabIndex = 0;
            this.complexGraph.UseColorGenerator = true;
            this.complexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
            this.complexXAxis1});
            this.complexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
            this.complexYAxis1});
            this.complexGraph.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            // 
            // complexPlot1
            // 
            this.complexPlot1.LineColor = System.Drawing.Color.Sienna;
            this.complexPlot1.LineColorPrecedence = NationalInstruments.UI.ColorPrecedence.UserDefinedColor;
            this.complexPlot1.PointColor = System.Drawing.Color.GhostWhite;
            this.complexPlot1.PointStyle = NationalInstruments.UI.PointStyle.EmptyDiamond;
            this.complexPlot1.XAxis = this.complexXAxis1;
            this.complexPlot1.YAxis = this.complexYAxis1;
            // 
            // complexXAxis1
            // 
            this.complexXAxis1.Caption = "Real Axis";
            // 
            // complexYAxis1
            // 
            this.complexYAxis1.Caption = "Imaginary Axis";
            // 
            // digitalWaveformGraphTabPage
            // 
            this.digitalWaveformGraphTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.digitalWaveformGraphTabPage.Controls.Add(this.digitalWaveformGraph);
            this.digitalWaveformGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.digitalWaveformGraphTabPage.Name = "digitalWaveformGraphTabPage";
            this.digitalWaveformGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.digitalWaveformGraphTabPage.Size = new System.Drawing.Size(604, 376);
            this.digitalWaveformGraphTabPage.TabIndex = 3;
            this.digitalWaveformGraphTabPage.Text = "Digital Waveform Graph";
            this.digitalWaveformGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // digitalWaveformGraph
            // 
            this.digitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.digitalWaveformGraph.Location = new System.Drawing.Point(3, 3);
            this.digitalWaveformGraph.Name = "digitalWaveformGraph";
            this.digitalWaveformGraph.Size = new System.Drawing.Size(598, 370);
            this.digitalWaveformGraph.TabIndex = 0;
            // 
            // 
            // 
            this.digitalWaveformGraph.XAxis.Caption = "X - Axis";
            this.digitalWaveformGraph.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            // 
            // intensityGraphTabPage
            // 
            this.intensityGraphTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.intensityGraphTabPage.Controls.Add(this.intensityGraph);
            this.intensityGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.intensityGraphTabPage.Name = "intensityGraphTabPage";
            this.intensityGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.intensityGraphTabPage.Size = new System.Drawing.Size(604, 376);
            this.intensityGraphTabPage.TabIndex = 5;
            this.intensityGraphTabPage.Text = "Intensity Graph";
            // 
            // intensityGraph
            // 
            this.intensityGraph.ColorScales.AddRange(new NationalInstruments.UI.ColorScale[] {
            this.colorScale1});
            this.intensityGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.intensityGraph.Location = new System.Drawing.Point(3, 3);
            this.intensityGraph.Name = "intensityGraph";
            this.intensityGraph.Plots.AddRange(new NationalInstruments.UI.IntensityPlot[] {
            this.intensityPlot1});
            this.intensityGraph.Size = new System.Drawing.Size(598, 370);
            this.intensityGraph.TabIndex = 0;
            this.intensityGraph.XAxes.AddRange(new NationalInstruments.UI.IntensityXAxis[] {
            this.intensityXAxis1});
            this.intensityGraph.YAxes.AddRange(new NationalInstruments.UI.IntensityYAxis[] {
            this.intensityYAxis1});
            this.intensityGraph.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            // 
            // colorScale1
            // 
            this.colorScale1.Caption = "Colorscale Axis";
            // 
            // intensityPlot1
            // 
            this.intensityPlot1.ColorScale = this.colorScale1;
            this.intensityPlot1.XAxis = this.intensityXAxis1;
            this.intensityPlot1.YAxis = this.intensityYAxis1;
            // 
            // intensityXAxis1
            // 
            this.intensityXAxis1.Caption = "X-Axis";
            // 
            // intensityYAxis1
            // 
            this.intensityYAxis1.Caption = "Y-Axis";
            // 
            // numericControlsTabPage
            // 
            this.numericControlsTabPage.BackColor = System.Drawing.SystemColors.Window;
            this.numericControlsTabPage.Controls.Add(this.slide);
            this.numericControlsTabPage.Controls.Add(this.gauge);
            this.numericControlsTabPage.Location = new System.Drawing.Point(4, 22);
            this.numericControlsTabPage.Name = "numericControlsTabPage";
            this.numericControlsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.numericControlsTabPage.Size = new System.Drawing.Size(604, 376);
            this.numericControlsTabPage.TabIndex = 4;
            this.numericControlsTabPage.Text = "Numeric Controls";
            // 
            // slide
            // 
            this.slide.Caption = "Slide";
            this.slide.Dock = System.Windows.Forms.DockStyle.Left;
            this.slide.InteractionMode = NationalInstruments.UI.LinearNumericPointerInteractionModes.Indicator;
            this.slide.Location = new System.Drawing.Point(3, 3);
            this.slide.Name = "slide";
            this.slide.ScaleBaseLineVisible = true;
            this.slide.Size = new System.Drawing.Size(123, 370);
            this.slide.TabIndex = 1;
            this.slide.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            // 
            // gauge
            // 
            this.gauge.Caption = "Gauge";
            this.gauge.Dock = System.Windows.Forms.DockStyle.Right;
            this.gauge.Location = new System.Drawing.Point(239, 3);
            this.gauge.Name = "gauge";
            this.gauge.ScaleBaseLineVisible = true;
            this.gauge.Size = new System.Drawing.Size(362, 370);
            this.gauge.TabIndex = 0;
            this.gauge.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            // 
            // uiLegend
            // 
            this.uiLegend.Border = NationalInstruments.UI.Border.ThinFrame3D;
            this.uiLegend.Caption = "Legend";
            this.uiLegend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLegend.Location = new System.Drawing.Point(627, 5);
            this.uiLegend.Margin = new System.Windows.Forms.Padding(5);
            this.uiLegend.Name = "uiLegend";
            this.uiLegend.Size = new System.Drawing.Size(160, 130);
            this.uiLegend.TabIndex = 2;
            this.uiLegend.VerticalScrollMode = NationalInstruments.UI.ScrollMode.Auto;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.errorbandsLabel);
            this.panel1.Controls.Add(this.tooltipsLabel);
            this.panel1.Controls.Add(this.interpolateLabel);
            this.panel1.Controls.Add(this.animateLabel);
            this.panel1.Controls.Add(this.optionsLabel);
            this.panel1.Controls.Add(this.optionsSwitches);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(625, 143);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 154);
            this.panel1.TabIndex = 6;
            // 
            // errorbandsLabel
            // 
            this.errorbandsLabel.AutoSize = true;
            this.errorbandsLabel.Location = new System.Drawing.Point(50, 129);
            this.errorbandsLabel.Name = "errorbandsLabel";
            this.errorbandsLabel.Size = new System.Drawing.Size(90, 13);
            this.errorbandsLabel.TabIndex = 16;
            this.errorbandsLabel.Text = "Show error bands";
            // 
            // tooltipsLabel
            // 
            this.tooltipsLabel.AutoSize = true;
            this.tooltipsLabel.Location = new System.Drawing.Point(50, 97);
            this.tooltipsLabel.Name = "tooltipsLabel";
            this.tooltipsLabel.Size = new System.Drawing.Size(100, 13);
            this.tooltipsLabel.TabIndex = 18;
            this.tooltipsLabel.Text = "Show graph tooltips";
            // 
            // interpolateLabel
            // 
            this.interpolateLabel.AutoSize = true;
            this.interpolateLabel.Location = new System.Drawing.Point(50, 66);
            this.interpolateLabel.Name = "interpolateLabel";
            this.interpolateLabel.Size = new System.Drawing.Size(88, 13);
            this.interpolateLabel.TabIndex = 19;
            this.interpolateLabel.Text = "Interpolate colors";
            // 
            // animateLabel
            // 
            this.animateLabel.AutoSize = true;
            this.animateLabel.Location = new System.Drawing.Point(50, 35);
            this.animateLabel.Name = "animateLabel";
            this.animateLabel.Size = new System.Drawing.Size(90, 13);
            this.animateLabel.TabIndex = 17;
            this.animateLabel.Text = "Animate numerics";
            // 
            // optionsLabel
            // 
            this.optionsLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.optionsLabel.Location = new System.Drawing.Point(2, 3);
            this.optionsLabel.Name = "optionsLabel";
            this.optionsLabel.Size = new System.Drawing.Size(160, 20);
            this.optionsLabel.TabIndex = 15;
            this.optionsLabel.Text = "Options";
            this.optionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsSwitches
            // 
            // 
            // 
            // 
            this.optionsSwitches.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.optionsSwitches.ItemTemplate.Name = "";
            this.optionsSwitches.ItemTemplate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optionsSwitches.ItemTemplate.Size = new System.Drawing.Size(50, 30);
            this.optionsSwitches.ItemTemplate.SwitchStyle = NationalInstruments.UI.SwitchStyle.HorizontalSlide3D;
            this.optionsSwitches.ItemTemplate.TabIndex = 0;
            this.optionsSwitches.ItemTemplate.TabStop = false;
            this.optionsSwitches.ItemTemplate.Value = true;
            this.optionsSwitches.Location = new System.Drawing.Point(2, 26);
            this.optionsSwitches.Name = "optionsSwitches";
            this.optionsSwitches.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(4);
            this.optionsSwitches.Size = new System.Drawing.Size(53, 132);
            this.optionsSwitches.TabIndex = 14;
            this.optionsSwitches.Enter += new System.EventHandler(this.SnipsControl_GotFocus);
            this.optionsSwitches.ValuesChanged += new System.EventHandler(this.OptionsSwitches_ValuesChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.resetButton);
            this.panel2.Controls.Add(this.runSnippetButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(625, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 68);
            this.panel2.TabIndex = 9;
            // 
            // resetButton
            // 
            this.resetButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(0, 36);
            this.resetButton.Margin = new System.Windows.Forms.Padding(5);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(164, 32);
            this.resetButton.TabIndex = 11;
            this.resetButton.Text = "Reset &Example";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // runSnippetButton
            // 
            this.runSnippetButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.runSnippetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runSnippetButton.Location = new System.Drawing.Point(0, 0);
            this.runSnippetButton.Margin = new System.Windows.Forms.Padding(5);
            this.runSnippetButton.Name = "runSnippetButton";
            this.runSnippetButton.Size = new System.Drawing.Size(164, 32);
            this.runSnippetButton.TabIndex = 9;
            this.runSnippetButton.Text = "Run &Snippet";
            this.runSnippetButton.UseVisualStyleBackColor = true;
            this.runSnippetButton.Click += new System.EventHandler(this.RunSnippetButton_Click);
            // 
            // panel3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 2);
            this.panel3.Controls.Add(this.controlsComboBox);
            this.panel3.Controls.Add(this.availableControlsLabel);
            this.panel3.Controls.Add(this.snipsComboBox);
            this.panel3.Controls.Add(this.availableSnippetsLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(365, 415);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(424, 154);
            this.panel3.TabIndex = 11;
            // 
            // controlsComboBox
            // 
            this.controlsComboBox.FormattingEnabled = true;
            this.controlsComboBox.Location = new System.Drawing.Point(8, 27);
            this.controlsComboBox.Name = "controlsComboBox";
            this.controlsComboBox.Size = new System.Drawing.Size(409, 21);
            this.controlsComboBox.TabIndex = 12;
            this.controlsComboBox.SelectedIndexChanged += new System.EventHandler(this.controlsComboBox_SelectedIndexChanged);
            // 
            // availableControlsLabel
            // 
            this.availableControlsLabel.AutoSize = true;
            this.availableControlsLabel.Location = new System.Drawing.Point(8, 11);
            this.availableControlsLabel.Name = "availableControlsLabel";
            this.availableControlsLabel.Size = new System.Drawing.Size(91, 13);
            this.availableControlsLabel.TabIndex = 11;
            this.availableControlsLabel.Text = "Available Controls";
            // 
            // snipsComboBox
            // 
            this.snipsComboBox.FormattingEnabled = true;
            this.snipsComboBox.Location = new System.Drawing.Point(8, 74);
            this.snipsComboBox.Name = "snipsComboBox";
            this.snipsComboBox.Size = new System.Drawing.Size(409, 21);
            this.snipsComboBox.TabIndex = 9;
            this.snipsComboBox.SelectionChangeCommitted += new System.EventHandler(this.SnipsComboBox_TextChanged);
            // 
            // availableSnippetsLabel
            // 
            this.availableSnippetsLabel.AutoSize = true;
            this.availableSnippetsLabel.Location = new System.Drawing.Point(8, 58);
            this.availableSnippetsLabel.Name = "availableSnippetsLabel";
            this.availableSnippetsLabel.Size = new System.Drawing.Size(190, 13);
            this.availableSnippetsLabel.TabIndex = 10;
            this.availableSnippetsLabel.Text = "Available Snippets for Selected Control";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 572);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 560);
            this.Name = "MainForm";
            this.Text = "Measurement Studio UI Code Snippets";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.controlsTabControl.ResumeLayout(false);
            this.waveformGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph)).EndInit();
            this.scatterGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scatterGraph)).EndInit();
            this.complexGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.complexGraph)).EndInit();
            this.digitalWaveformGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.digitalWaveformGraph)).EndInit();
            this.intensityGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intensityGraph)).EndInit();
            this.numericControlsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiLegend)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.optionsSwitches.ItemTemplate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl controlsTabControl;
        private System.Windows.Forms.TabPage waveformGraphTabPage;
        private UI.WindowsForms.WaveformGraph waveformGraph;
        private UI.WaveformPlot waveformPlot1;
        private UI.XAxis xAxis2;
        private UI.YAxis yAxis2;
        private System.Windows.Forms.TabPage scatterGraphTabPage;
        private UI.WindowsForms.ScatterGraph scatterGraph;
        private UI.ScatterPlot scatterPlot1;
        private UI.XAxis xAxis1;
        private UI.YAxis yAxis1;
        private System.Windows.Forms.TabPage complexGraphTabPage;
        private UI.WindowsForms.ComplexGraph complexGraph;
        private UI.ComplexPlot complexPlot1;
        private UI.ComplexXAxis complexXAxis1;
        private UI.ComplexYAxis complexYAxis1;
        private System.Windows.Forms.TabPage digitalWaveformGraphTabPage;
        private UI.WindowsForms.DigitalWaveformGraph digitalWaveformGraph;
        private System.Windows.Forms.TabPage intensityGraphTabPage;
        private UI.WindowsForms.IntensityGraph intensityGraph;
        private UI.ColorScale colorScale1;
        private UI.IntensityPlot intensityPlot1;
        private UI.IntensityXAxis intensityXAxis1;
        private UI.IntensityYAxis intensityYAxis1;
        private System.Windows.Forms.TabPage numericControlsTabPage;
        private UI.WindowsForms.Slide slide;
        private UI.WindowsForms.Gauge gauge;
        private UI.WindowsForms.Legend uiLegend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label errorbandsLabel;
        private System.Windows.Forms.Label tooltipsLabel;
        private System.Windows.Forms.Label interpolateLabel;
        private System.Windows.Forms.Label animateLabel;
        private System.Windows.Forms.Label optionsLabel;
        private UI.WindowsForms.SwitchArray optionsSwitches;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button runSnippetButton;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox controlsComboBox;
        private System.Windows.Forms.Label availableControlsLabel;
        private System.Windows.Forms.ComboBox snipsComboBox;
        private System.Windows.Forms.Label availableSnippetsLabel;
        private System.Windows.Forms.Button resetButton;       
        
    }
}

