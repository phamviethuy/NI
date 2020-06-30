using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.ScaleRangeFills
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.WindowsForms.Knob sampleKnob;
        private System.Windows.Forms.TabControl numericPointerTabControl;
        private System.Windows.Forms.TabPage knobTabPage;
        private System.Windows.Forms.TabPage meterTabPage;
        private System.Windows.Forms.TabPage gaugeTabPage;
        private System.Windows.Forms.TabPage slideTabPage;
        private System.Windows.Forms.TabPage tankTabPage;
        private System.Windows.Forms.TabPage thermometerTabPage;
        private NationalInstruments.UI.WindowsForms.Meter sampleMeter;
        private NationalInstruments.UI.WindowsForms.Gauge sampleGauge;
        private NationalInstruments.UI.WindowsForms.Slide sampleSlide;
        private NationalInstruments.UI.WindowsForms.Tank sampleTank;
        private NationalInstruments.UI.WindowsForms.Thermometer sampleThermometer;
        private System.Windows.Forms.GroupBox rangeFillGroupBox;
        private NationalInstruments.UI.ScaleRangeFill rangeFill;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeFillStylePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeFillVisiblePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeFillWidthPropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeFillRangePropertyEditor;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangeFillDistancePropertyEditor;
        private System.Windows.Forms.Label rangeFillDistanceLabel;
        private System.Windows.Forms.Label rangeFillRangeLabel;
        private System.Windows.Forms.Label rangeFillStyleLabel;
        private System.Windows.Forms.Label rangeFillVisibleLabel;
        private System.Windows.Forms.Label rangeFillWidthLabel;
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
            
            rangeFill = sampleGauge.RangeFills[0];            
            rangeFillDistancePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Distance");
            rangeFillRangePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Range");
            rangeFillStylePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Style");
            rangeFillVisiblePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Visible");
            rangeFillWidthPropertyEditor.Source = new PropertyEditorSource(rangeFill, "Width");
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
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill1 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill2 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill3 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill4 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill5 = new NationalInstruments.UI.ScaleRangeFill();
            NationalInstruments.UI.ScaleRangeFill scaleRangeFill6 = new NationalInstruments.UI.ScaleRangeFill();
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.rangeFillDistancePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.rangeFillRangePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.rangeFillStylePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.rangeFillVisiblePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.rangeFillWidthPropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.sampleKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.rangeFillDistanceLabel = new System.Windows.Forms.Label();
            this.rangeFillRangeLabel = new System.Windows.Forms.Label();
            this.rangeFillStyleLabel = new System.Windows.Forms.Label();
            this.rangeFillVisibleLabel = new System.Windows.Forms.Label();
            this.rangeFillWidthLabel = new System.Windows.Forms.Label();
            this.rangeFillGroupBox = new System.Windows.Forms.GroupBox();
            this.numericPointerTabControl = new System.Windows.Forms.TabControl();
            this.gaugeTabPage = new System.Windows.Forms.TabPage();
            this.sampleGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.meterTabPage = new System.Windows.Forms.TabPage();
            this.sampleMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.knobTabPage = new System.Windows.Forms.TabPage();
            this.slideTabPage = new System.Windows.Forms.TabPage();
            this.sampleSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.tankTabPage = new System.Windows.Forms.TabPage();
            this.sampleTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.thermometerTabPage = new System.Windows.Forms.TabPage();
            this.sampleThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).BeginInit();
            this.rangeFillGroupBox.SuspendLayout();
            this.numericPointerTabControl.SuspendLayout();
            this.gaugeTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleGauge)).BeginInit();
            this.meterTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleMeter)).BeginInit();
            this.knobTabPage.SuspendLayout();
            this.slideTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleSlide)).BeginInit();
            this.tankTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTank)).BeginInit();
            this.thermometerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleThermometer)).BeginInit();
            this.SuspendLayout();
            // 
            // rangeFillDistancePropertyEditor
            // 
            this.rangeFillDistancePropertyEditor.Location = new System.Drawing.Point(168, 25);
            this.rangeFillDistancePropertyEditor.Name = "rangeFillDistancePropertyEditor";
            this.rangeFillDistancePropertyEditor.TabIndex = 2;
            // 
            // rangeFillRangePropertyEditor
            // 
            this.rangeFillRangePropertyEditor.Location = new System.Drawing.Point(168, 56);
            this.rangeFillRangePropertyEditor.Name = "rangeFillRangePropertyEditor";
            this.rangeFillRangePropertyEditor.TabIndex = 3;
            // 
            // rangeFillStylePropertyEditor
            // 
            this.rangeFillStylePropertyEditor.Location = new System.Drawing.Point(168, 88);
            this.rangeFillStylePropertyEditor.Name = "rangeFillStylePropertyEditor";
            this.rangeFillStylePropertyEditor.TabIndex = 4;
            // 
            // rangeFillVisiblePropertyEditor
            // 
            this.rangeFillVisiblePropertyEditor.Location = new System.Drawing.Point(168, 120);
            this.rangeFillVisiblePropertyEditor.Name = "rangeFillVisiblePropertyEditor";
            this.rangeFillVisiblePropertyEditor.TabIndex = 5;
            // 
            // rangeFillWidthPropertyEditor
            // 
            this.rangeFillWidthPropertyEditor.Location = new System.Drawing.Point(168, 152);
            this.rangeFillWidthPropertyEditor.Name = "rangeFillWidthPropertyEditor";
            this.rangeFillWidthPropertyEditor.TabIndex = 6;
            // 
            // sampleKnob
            // 
            this.sampleKnob.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleKnob.Location = new System.Drawing.Point(0, 0);
            this.sampleKnob.Name = "sampleKnob";
            scaleRangeFill1.Range = new NationalInstruments.UI.Range(0, 2.5);
            this.sampleKnob.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
                                                                                                scaleRangeFill1});
            this.sampleKnob.Size = new System.Drawing.Size(314, 174);
            this.sampleKnob.TabIndex = 13;
            // 
            // rangeFillDistanceLabel
            // 
            this.rangeFillDistanceLabel.Location = new System.Drawing.Point(8, 24);
            this.rangeFillDistanceLabel.Name = "rangeFillDistanceLabel";
            this.rangeFillDistanceLabel.Size = new System.Drawing.Size(120, 20);
            this.rangeFillDistanceLabel.TabIndex = 14;
            this.rangeFillDistanceLabel.Text = "Distance";
            // 
            // rangeFillRangeLabel
            // 
            this.rangeFillRangeLabel.Location = new System.Drawing.Point(8, 56);
            this.rangeFillRangeLabel.Name = "rangeFillRangeLabel";
            this.rangeFillRangeLabel.Size = new System.Drawing.Size(120, 20);
            this.rangeFillRangeLabel.TabIndex = 15;
            this.rangeFillRangeLabel.Text = "Range";
            // 
            // rangeFillStyleLabel
            // 
            this.rangeFillStyleLabel.Location = new System.Drawing.Point(8, 88);
            this.rangeFillStyleLabel.Name = "rangeFillStyleLabel";
            this.rangeFillStyleLabel.Size = new System.Drawing.Size(120, 20);
            this.rangeFillStyleLabel.TabIndex = 16;
            this.rangeFillStyleLabel.Text = "Style";
            // 
            // rangeFillVisibleLabel
            // 
            this.rangeFillVisibleLabel.Location = new System.Drawing.Point(8, 120);
            this.rangeFillVisibleLabel.Name = "rangeFillVisibleLabel";
            this.rangeFillVisibleLabel.Size = new System.Drawing.Size(120, 20);
            this.rangeFillVisibleLabel.TabIndex = 17;
            this.rangeFillVisibleLabel.Text = "Visible";
            // 
            // rangeFillWidthLabel
            // 
            this.rangeFillWidthLabel.Location = new System.Drawing.Point(8, 152);
            this.rangeFillWidthLabel.Name = "rangeFillWidthLabel";
            this.rangeFillWidthLabel.Size = new System.Drawing.Size(120, 20);
            this.rangeFillWidthLabel.TabIndex = 18;
            this.rangeFillWidthLabel.Text = "Width";
            // 
            // rangeFillGroupBox
            // 
            this.rangeFillGroupBox.Controls.Add(this.rangeFillWidthPropertyEditor);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillVisiblePropertyEditor);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillWidthLabel);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillRangePropertyEditor);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillStyleLabel);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillDistanceLabel);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillDistancePropertyEditor);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillVisibleLabel);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillStylePropertyEditor);
            this.rangeFillGroupBox.Controls.Add(this.rangeFillRangeLabel);
            this.rangeFillGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rangeFillGroupBox.Location = new System.Drawing.Point(8, 208);
            this.rangeFillGroupBox.Name = "rangeFillGroupBox";
            this.rangeFillGroupBox.Size = new System.Drawing.Size(304, 184);
            this.rangeFillGroupBox.TabIndex = 19;
            this.rangeFillGroupBox.TabStop = false;
            this.rangeFillGroupBox.Text = "RangeFill properties";
            // 
            // numericPointerTabControl
            // 
            this.numericPointerTabControl.Controls.Add(this.gaugeTabPage);
            this.numericPointerTabControl.Controls.Add(this.meterTabPage);
            this.numericPointerTabControl.Controls.Add(this.knobTabPage);
            this.numericPointerTabControl.Controls.Add(this.slideTabPage);
            this.numericPointerTabControl.Controls.Add(this.tankTabPage);
            this.numericPointerTabControl.Controls.Add(this.thermometerTabPage);
            this.numericPointerTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.numericPointerTabControl.Location = new System.Drawing.Point(0, 0);
            this.numericPointerTabControl.Name = "numericPointerTabControl";
            this.numericPointerTabControl.SelectedIndex = 0;
            this.numericPointerTabControl.Size = new System.Drawing.Size(322, 200);
            this.numericPointerTabControl.TabIndex = 20;
            this.numericPointerTabControl.SelectedIndexChanged += new System.EventHandler(this.numericPointerTabControl_SelectedIndexChanged);
            // 
            // gaugeTabPage
            // 
            this.gaugeTabPage.Controls.Add(this.sampleGauge);
            this.gaugeTabPage.Location = new System.Drawing.Point(4, 22);
            this.gaugeTabPage.Name = "gaugeTabPage";
            this.gaugeTabPage.Size = new System.Drawing.Size(314, 174);
            this.gaugeTabPage.TabIndex = 2;
            this.gaugeTabPage.Text = "Gauge";
            // 
            // sampleGauge
            // 
            this.sampleGauge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleGauge.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.sampleGauge.Location = new System.Drawing.Point(0, 0);
            this.sampleGauge.Name = "sampleGauge";
            scaleRangeFill2.Range = new NationalInstruments.UI.Range(0, 2.5);
            this.sampleGauge.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
                                                                                                 scaleRangeFill2});
            this.sampleGauge.Size = new System.Drawing.Size(314, 174);
            this.sampleGauge.TabIndex = 0;
            // 
            // meterTabPage
            // 
            this.meterTabPage.Controls.Add(this.sampleMeter);
            this.meterTabPage.Location = new System.Drawing.Point(4, 22);
            this.meterTabPage.Name = "meterTabPage";
            this.meterTabPage.Size = new System.Drawing.Size(314, 174);
            this.meterTabPage.TabIndex = 1;
            this.meterTabPage.Text = "Meter";
            // 
            // sampleMeter
            // 
            this.sampleMeter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleMeter.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.sampleMeter.Location = new System.Drawing.Point(0, 0);
            this.sampleMeter.Name = "sampleMeter";
            scaleRangeFill3.Range = new NationalInstruments.UI.Range(0, 2.5);
            this.sampleMeter.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
                                                                                                 scaleRangeFill3});
            this.sampleMeter.Size = new System.Drawing.Size(314, 174);
            this.sampleMeter.TabIndex = 0;
            // 
            // knobTabPage
            // 
            this.knobTabPage.Controls.Add(this.sampleKnob);
            this.knobTabPage.Location = new System.Drawing.Point(4, 22);
            this.knobTabPage.Name = "knobTabPage";
            this.knobTabPage.Size = new System.Drawing.Size(314, 174);
            this.knobTabPage.TabIndex = 0;
            this.knobTabPage.Text = "Knob";
            // 
            // slideTabPage
            // 
            this.slideTabPage.Controls.Add(this.sampleSlide);
            this.slideTabPage.Location = new System.Drawing.Point(4, 22);
            this.slideTabPage.Name = "slideTabPage";
            this.slideTabPage.Size = new System.Drawing.Size(314, 174);
            this.slideTabPage.TabIndex = 3;
            this.slideTabPage.Text = "Slide";
            // 
            // sampleSlide
            // 
            this.sampleSlide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleSlide.Location = new System.Drawing.Point(0, 0);
            this.sampleSlide.Name = "sampleSlide";
            scaleRangeFill4.Range = new NationalInstruments.UI.Range(0, 2.5);
            this.sampleSlide.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
                                                                                                 scaleRangeFill4});
            this.sampleSlide.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.sampleSlide.Size = new System.Drawing.Size(314, 174);
            this.sampleSlide.TabIndex = 0;
            // 
            // tankTabPage
            // 
            this.tankTabPage.Controls.Add(this.sampleTank);
            this.tankTabPage.Location = new System.Drawing.Point(4, 22);
            this.tankTabPage.Name = "tankTabPage";
            this.tankTabPage.Size = new System.Drawing.Size(314, 174);
            this.tankTabPage.TabIndex = 4;
            this.tankTabPage.Text = "Tank";
            // 
            // sampleTank
            // 
            this.sampleTank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleTank.InteractionMode = ((NationalInstruments.UI.LinearNumericPointerInteractionModes)((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer)));
            this.sampleTank.Location = new System.Drawing.Point(0, 0);
            this.sampleTank.Name = "sampleTank";
            scaleRangeFill5.Range = new NationalInstruments.UI.Range(0, 2.5);
            this.sampleTank.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
                                                                                                scaleRangeFill5});
            this.sampleTank.ScalePosition = NationalInstruments.UI.NumericScalePosition.Bottom;
            this.sampleTank.Size = new System.Drawing.Size(314, 174);
            this.sampleTank.TabIndex = 0;
            // 
            // thermometerTabPage
            // 
            this.thermometerTabPage.Controls.Add(this.sampleThermometer);
            this.thermometerTabPage.Location = new System.Drawing.Point(4, 22);
            this.thermometerTabPage.Name = "thermometerTabPage";
            this.thermometerTabPage.Size = new System.Drawing.Size(314, 174);
            this.thermometerTabPage.TabIndex = 5;
            this.thermometerTabPage.Text = "Thermometer";
            // 
            // sampleThermometer
            // 
            this.sampleThermometer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleThermometer.InteractionMode = ((NationalInstruments.UI.LinearNumericPointerInteractionModes)((NationalInstruments.UI.LinearNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.LinearNumericPointerInteractionModes.SnapPointer)));
            this.sampleThermometer.Location = new System.Drawing.Point(0, 0);
            this.sampleThermometer.Name = "sampleThermometer";
            scaleRangeFill6.Range = new NationalInstruments.UI.Range(0, 25);
            this.sampleThermometer.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
                                                                                                       scaleRangeFill6});
            this.sampleThermometer.Size = new System.Drawing.Size(314, 174);
            this.sampleThermometer.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(322, 400);
            this.Controls.Add(this.numericPointerTabControl);
            this.Controls.Add(this.rangeFillGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Scale Range Fills";
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).EndInit();
            this.rangeFillGroupBox.ResumeLayout(false);
            this.numericPointerTabControl.ResumeLayout(false);
            this.gaugeTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleGauge)).EndInit();
            this.meterTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleMeter)).EndInit();
            this.knobTabPage.ResumeLayout(false);
            this.slideTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleSlide)).EndInit();
            this.tankTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleTank)).EndInit();
            this.thermometerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleThermometer)).EndInit();
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

        private void numericPointerTabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch(numericPointerTabControl.SelectedTab.Text)
            {
                case "Gauge":
                    rangeFill = sampleGauge.RangeFills[0];
                    break;
                case "Meter":
                    rangeFill = sampleMeter.RangeFills[0];
                    break;
                case "Knob":
                    rangeFill = sampleKnob.RangeFills[0];
                    break;
                case "Slide":
                    rangeFill = sampleSlide.RangeFills[0];
                    break;
                case "Tank":
                    rangeFill = sampleTank.RangeFills[0];
                    break;
                case "Thermometer":
                    rangeFill = sampleThermometer.RangeFills[0];
                    break;
                default:
                    throw new Exception("Invalid Tab Page");
            }

            rangeFillDistancePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Distance");
            rangeFillRangePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Range");
            rangeFillStylePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Style");
            rangeFillVisiblePropertyEditor.Source = new PropertyEditorSource(rangeFill, "Visible");
            rangeFillWidthPropertyEditor.Source = new PropertyEditorSource(rangeFill, "Width");
        }
    }
}
