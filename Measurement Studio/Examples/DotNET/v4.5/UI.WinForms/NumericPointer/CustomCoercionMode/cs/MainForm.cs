using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomCoercionMode
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        
        private NationalInstruments.UI.WindowsForms.Gauge coercionGauge;
        private System.Windows.Forms.Label intervalCoercionLabel;
        private System.Windows.Forms.Label noCoercionLabel;
        private System.Windows.Forms.Label toDivisionCoercionLabel;
        private System.Windows.Forms.Label gaugeValueLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit valueNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit coercionIntervalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit coercionBaseNumericEdit;
        private System.Windows.Forms.Label coercionIntervalLabel;
        private System.Windows.Forms.Label coercionBaseLabel;
        private System.Windows.Forms.GroupBox gaugeParametersGroupBox;
        private Range noCoerceRange; 
                private Range toIntervalRange; 

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            double gaugeMax = coercionGauge.Range.Maximum;
            double gaugeMin = coercionGauge.Range.Minimum;

            int rangeInterval = (int)(gaugeMax - gaugeMin) / 3;

            toIntervalRange = new Range(0, rangeInterval);
            noCoerceRange = new Range(rangeInterval, 2 * rangeInterval);            
            
            coercionGauge.CoercionMode = new CustomCoercion(noCoerceRange, toIntervalRange);

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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.coercionGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.valueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.intervalCoercionLabel = new System.Windows.Forms.Label();
            this.noCoercionLabel = new System.Windows.Forms.Label();
            this.toDivisionCoercionLabel = new System.Windows.Forms.Label();
            this.gaugeValueLabel = new System.Windows.Forms.Label();
            this.coercionIntervalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.coercionBaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.gaugeParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.coercionBaseLabel = new System.Windows.Forms.Label();
            this.coercionIntervalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.coercionGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercionIntervalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercionBaseNumericEdit)).BeginInit();
            this.gaugeParametersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // coercionGauge
            // 
            this.coercionGauge.CaptionVisible = true;
            this.coercionGauge.GaugeStyle = NationalInstruments.UI.GaugeStyle.SunkenWithThickNeedle;
            this.coercionGauge.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.coercionGauge.Location = new System.Drawing.Point(0, 0);
            this.coercionGauge.Name = "coercionGauge";
            this.coercionGauge.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            scaleRangeFill1.Range = new NationalInstruments.UI.Range(0, 3);
            scaleRangeFill2.Range = new NationalInstruments.UI.Range(3, 6);
            scaleRangeFill2.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateStyleFromFillStyle(NationalInstruments.UI.FillStyle.HorizontalBrick, System.Drawing.Color.Aqua);
            scaleRangeFill3.Range = new NationalInstruments.UI.Range(6, 10);
            scaleRangeFill3.Style = NationalInstruments.UI.ScaleRangeFillStyle.CreateGradientStyle(System.Drawing.Color.Red, System.Drawing.Color.Yellow, 0.5F);
            this.coercionGauge.RangeFills.AddRange(new NationalInstruments.UI.ScaleRangeFill[] {
                                                                                                   scaleRangeFill1,
                                                                                                   scaleRangeFill2,
                                                                                                   scaleRangeFill3});
            this.coercionGauge.Size = new System.Drawing.Size(344, 272);
            this.coercionGauge.TabIndex = 0;
            // 
            // valueNumericEdit
            // 
            this.valueNumericEdit.Location = new System.Drawing.Point(184, 24);
            this.valueNumericEdit.Name = "valueNumericEdit";
            this.valueNumericEdit.Source = this.coercionGauge;
            this.valueNumericEdit.TabIndex = 1;
            // 
            // intervalCoercionLabel
            // 
            this.intervalCoercionLabel.Location = new System.Drawing.Point(8, 232);
            this.intervalCoercionLabel.Name = "intervalCoercionLabel";
            this.intervalCoercionLabel.Size = new System.Drawing.Size(64, 24);
            this.intervalCoercionLabel.TabIndex = 5;
            this.intervalCoercionLabel.Text = "To Interval Coercion";
            // 
            // noCoercionLabel
            // 
            this.noCoercionLabel.Location = new System.Drawing.Point(16, 16);
            this.noCoercionLabel.Name = "noCoercionLabel";
            this.noCoercionLabel.Size = new System.Drawing.Size(72, 16);
            this.noCoercionLabel.TabIndex = 4;
            this.noCoercionLabel.Text = "No Coercion";
            // 
            // toDivisionCoercionLabel
            // 
            this.toDivisionCoercionLabel.Location = new System.Drawing.Point(272, 16);
            this.toDivisionCoercionLabel.Name = "toDivisionCoercionLabel";
            this.toDivisionCoercionLabel.Size = new System.Drawing.Size(72, 24);
            this.toDivisionCoercionLabel.TabIndex = 3;
            this.toDivisionCoercionLabel.Text = "To Division Coercion";
            // 
            // gaugeValueLabel
            // 
            this.gaugeValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gaugeValueLabel.Location = new System.Drawing.Point(8, 24);
            this.gaugeValueLabel.Name = "gaugeValueLabel";
            this.gaugeValueLabel.Size = new System.Drawing.Size(80, 16);
            this.gaugeValueLabel.TabIndex = 2;
            this.gaugeValueLabel.Text = "Gauge Value:";
            // 
            // coercionIntervalNumericEdit
            // 
            this.coercionIntervalNumericEdit.CoercionInterval = 0.5;
            this.coercionIntervalNumericEdit.Location = new System.Drawing.Point(184, 56);
            this.coercionIntervalNumericEdit.Name = "coercionIntervalNumericEdit";
            this.coercionIntervalNumericEdit.TabIndex = 6;
            this.coercionIntervalNumericEdit.Value = 1;
            this.coercionIntervalNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.coercionIntervalNumericEdit_AfterChangeValue);
            // 
            // coercionBaseNumericEdit
            // 
            this.coercionBaseNumericEdit.CoercionInterval = 0.5;
            this.coercionBaseNumericEdit.Location = new System.Drawing.Point(184, 88);
            this.coercionBaseNumericEdit.Name = "coercionBaseNumericEdit";
            this.coercionBaseNumericEdit.TabIndex = 7;
            this.coercionBaseNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.coercionBaseNumericEdit_AfterChangeValue);
            // 
            // gaugeParametersGroupBox
            // 
            this.gaugeParametersGroupBox.Controls.Add(this.coercionBaseLabel);
            this.gaugeParametersGroupBox.Controls.Add(this.coercionIntervalLabel);
            this.gaugeParametersGroupBox.Controls.Add(this.coercionIntervalNumericEdit);
            this.gaugeParametersGroupBox.Controls.Add(this.gaugeValueLabel);
            this.gaugeParametersGroupBox.Controls.Add(this.coercionBaseNumericEdit);
            this.gaugeParametersGroupBox.Controls.Add(this.valueNumericEdit);
            this.gaugeParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gaugeParametersGroupBox.Location = new System.Drawing.Point(8, 272);
            this.gaugeParametersGroupBox.Name = "gaugeParametersGroupBox";
            this.gaugeParametersGroupBox.Size = new System.Drawing.Size(328, 120);
            this.gaugeParametersGroupBox.TabIndex = 8;
            this.gaugeParametersGroupBox.TabStop = false;
            this.gaugeParametersGroupBox.Text = "Gauge Parameters";
            // 
            // coercionBaseLabel
            // 
            this.coercionBaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coercionBaseLabel.Location = new System.Drawing.Point(8, 88);
            this.coercionBaseLabel.Name = "coercionBaseLabel";
            this.coercionBaseLabel.Size = new System.Drawing.Size(112, 16);
            this.coercionBaseLabel.TabIndex = 9;
            this.coercionBaseLabel.Text = "Coercion Interval Base:";
            // 
            // coercionIntervalLabel
            // 
            this.coercionIntervalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coercionIntervalLabel.Location = new System.Drawing.Point(8, 56);
            this.coercionIntervalLabel.Name = "coercionIntervalLabel";
            this.coercionIntervalLabel.Size = new System.Drawing.Size(88, 16);
            this.coercionIntervalLabel.TabIndex = 8;
            this.coercionIntervalLabel.Text = "Coercion Interval:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(338, 392);
            this.Controls.Add(this.gaugeParametersGroupBox);
            this.Controls.Add(this.toDivisionCoercionLabel);
            this.Controls.Add(this.noCoercionLabel);
            this.Controls.Add(this.intervalCoercionLabel);
            this.Controls.Add(this.coercionGauge);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Coercion Mode";
            ((System.ComponentModel.ISupportInitialize)(this.coercionGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercionIntervalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercionBaseNumericEdit)).EndInit();
            this.gaugeParametersGroupBox.ResumeLayout(false);
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

        private void coercionIntervalNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            coercionGauge.CoercionInterval = coercionIntervalNumericEdit.Value;
        }

        private void coercionBaseNumericEdit_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            coercionGauge.CoercionIntervalBase = coercionBaseNumericEdit.Value;
        }
    }
}
