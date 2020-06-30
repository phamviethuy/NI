using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.NarrowbandFiltering
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label filterTypeLabel;
        private System.Windows.Forms.Label rippleLabel;
        private NationalInstruments.UI.ScatterPlot phasePlot;
        private NationalInstruments.UI.ScatterPlot magnitudePlot;
        private NationalInstruments.UI.XAxis magnitudeXAxis;
        private NationalInstruments.UI.YAxis magnitudeYAxis;
        private NationalInstruments.UI.XAxis phaseXAxis;
        private NationalInstruments.UI.YAxis phaseYAxis;
        private System.Windows.Forms.Label attenuationLabel;        
        private System.Windows.Forms.ComboBox filterTypeComboBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit attenuationNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit rippleNumericEdit;
		private NationalInstruments.UI.WindowsForms.ScatterGraph phaseScatterGraph;
		private NationalInstruments.UI.WindowsForms.ScatterGraph magnitudeScatterGraph;
        private System.Windows.Forms.GroupBox filterParametersGroupBox;
        private Label passbandLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit stopbandNumeric;
        private Label stopbandLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit passbandNumeric;
        private NationalInstruments.UI.WindowsForms.NumericEdit centerFrequencyNumericEdit;
        private Label centerFrequencyLabel;
        private Button updateButton;
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

            filterTypeComboBox.SelectedIndex = 0;
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
            this.filterParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.centerFrequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.centerFrequencyLabel = new System.Windows.Forms.Label();
            this.stopbandNumeric = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.stopbandLabel = new System.Windows.Forms.Label();
            this.passbandNumeric = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.passbandLabel = new System.Windows.Forms.Label();
            this.rippleLabel = new System.Windows.Forms.Label();
            this.filterTypeLabel = new System.Windows.Forms.Label();
            this.filterTypeComboBox = new System.Windows.Forms.ComboBox();
            this.attenuationLabel = new System.Windows.Forms.Label();
            this.attenuationNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.rippleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.phaseScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.phasePlot = new NationalInstruments.UI.ScatterPlot();
            this.phaseXAxis = new NationalInstruments.UI.XAxis();
            this.phaseYAxis = new NationalInstruments.UI.YAxis();
            this.magnitudeScatterGraph = new NationalInstruments.UI.WindowsForms.ScatterGraph();
            this.magnitudePlot = new NationalInstruments.UI.ScatterPlot();
            this.magnitudeXAxis = new NationalInstruments.UI.XAxis();
            this.magnitudeYAxis = new NationalInstruments.UI.YAxis();
            this.updateButton = new System.Windows.Forms.Button();
            this.filterParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerFrequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopbandNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passbandNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rippleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseScatterGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitudeScatterGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // filterParametersGroupBox
            // 
            this.filterParametersGroupBox.Controls.Add(this.centerFrequencyNumericEdit);
            this.filterParametersGroupBox.Controls.Add(this.centerFrequencyLabel);
            this.filterParametersGroupBox.Controls.Add(this.stopbandNumeric);
            this.filterParametersGroupBox.Controls.Add(this.stopbandLabel);
            this.filterParametersGroupBox.Controls.Add(this.passbandNumeric);
            this.filterParametersGroupBox.Controls.Add(this.passbandLabel);
            this.filterParametersGroupBox.Controls.Add(this.rippleLabel);
            this.filterParametersGroupBox.Controls.Add(this.filterTypeLabel);
            this.filterParametersGroupBox.Controls.Add(this.filterTypeComboBox);
            this.filterParametersGroupBox.Controls.Add(this.attenuationLabel);
            this.filterParametersGroupBox.Controls.Add(this.attenuationNumericEdit);
            this.filterParametersGroupBox.Controls.Add(this.rippleNumericEdit);
            this.filterParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filterParametersGroupBox.Location = new System.Drawing.Point(452, 10);
            this.filterParametersGroupBox.Name = "filterParametersGroupBox";
            this.filterParametersGroupBox.Size = new System.Drawing.Size(128, 304);
            this.filterParametersGroupBox.TabIndex = 8;
            this.filterParametersGroupBox.TabStop = false;
            this.filterParametersGroupBox.Text = "Filter Parameters";
            // 
            // centerFrequencyNumericEdit
            // 
            this.centerFrequencyNumericEdit.Location = new System.Drawing.Point(16, 272);
            this.centerFrequencyNumericEdit.Name = "centerFrequencyNumericEdit";
            this.centerFrequencyNumericEdit.Size = new System.Drawing.Size(96, 20);
            this.centerFrequencyNumericEdit.TabIndex = 10;
            this.centerFrequencyNumericEdit.Value = 150;
            // 
            // centerFrequencyLabel
            // 
            this.centerFrequencyLabel.AutoSize = true;
            this.centerFrequencyLabel.Location = new System.Drawing.Point(13, 256);
            this.centerFrequencyLabel.Name = "centerFrequencyLabel";
            this.centerFrequencyLabel.Size = new System.Drawing.Size(94, 13);
            this.centerFrequencyLabel.TabIndex = 4;
            this.centerFrequencyLabel.Text = "Center Frequency:";
            // 
            // stopbandNumeric
            // 
            this.stopbandNumeric.Location = new System.Drawing.Point(16, 128);
            this.stopbandNumeric.Name = "stopbandNumeric";
            this.stopbandNumeric.Size = new System.Drawing.Size(96, 20);
            this.stopbandNumeric.TabIndex = 4;
            this.stopbandNumeric.Value = 200;
            // 
            // stopbandLabel
            // 
            this.stopbandLabel.AutoSize = true;
            this.stopbandLabel.Location = new System.Drawing.Point(13, 112);
            this.stopbandLabel.Name = "stopbandLabel";
            this.stopbandLabel.Size = new System.Drawing.Size(56, 13);
            this.stopbandLabel.TabIndex = 4;
            this.stopbandLabel.Text = "Stopband:";
            // 
            // passbandNumeric
            // 
            this.passbandNumeric.Location = new System.Drawing.Point(16, 80);
            this.passbandNumeric.Name = "passbandNumeric";
            this.passbandNumeric.Size = new System.Drawing.Size(96, 20);
            this.passbandNumeric.TabIndex = 2;
            this.passbandNumeric.Value = 100;
            // 
            // passbandLabel
            // 
            this.passbandLabel.AutoSize = true;
            this.passbandLabel.Location = new System.Drawing.Point(13, 64);
            this.passbandLabel.Name = "passbandLabel";
            this.passbandLabel.Size = new System.Drawing.Size(57, 13);
            this.passbandLabel.TabIndex = 4;
            this.passbandLabel.Text = "Passband:";
            // 
            // rippleLabel
            // 
            this.rippleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rippleLabel.Location = new System.Drawing.Point(16, 160);
            this.rippleLabel.Name = "rippleLabel";
            this.rippleLabel.Size = new System.Drawing.Size(88, 16);
            this.rippleLabel.TabIndex = 1;
            this.rippleLabel.Text = "Ripple:";
            // 
            // filterTypeLabel
            // 
            this.filterTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filterTypeLabel.Location = new System.Drawing.Point(16, 16);
            this.filterTypeLabel.Name = "filterTypeLabel";
            this.filterTypeLabel.Size = new System.Drawing.Size(88, 16);
            this.filterTypeLabel.TabIndex = 1;
            this.filterTypeLabel.Text = "Filter Type:";
            // 
            // filterTypeComboBox
            // 
            this.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterTypeComboBox.Items.AddRange(new object[] {
            "Lowpass",
            "Highpass",
            "Bandpass",
            "Bandstop"});
            this.filterTypeComboBox.Location = new System.Drawing.Point(16, 32);
            this.filterTypeComboBox.Name = "filterTypeComboBox";
            this.filterTypeComboBox.Size = new System.Drawing.Size(96, 21);
            this.filterTypeComboBox.TabIndex = 0;
            this.filterTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.filterType_SelectedIndexChanged);
            // 
            // attenuationLabel
            // 
            this.attenuationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.attenuationLabel.Location = new System.Drawing.Point(16, 205);
            this.attenuationLabel.Name = "attenuationLabel";
            this.attenuationLabel.Size = new System.Drawing.Size(88, 16);
            this.attenuationLabel.TabIndex = 1;
            this.attenuationLabel.Text = "Attenuation:";
            // 
            // attenuationNumericEdit
            // 
            this.attenuationNumericEdit.CoercionInterval = 0.01;
            this.attenuationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.attenuationNumericEdit.Location = new System.Drawing.Point(16, 224);
            this.attenuationNumericEdit.Name = "attenuationNumericEdit";
            this.attenuationNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.attenuationNumericEdit.Range = new NationalInstruments.UI.Range(1, 1000);
            this.attenuationNumericEdit.Size = new System.Drawing.Size(96, 20);
            this.attenuationNumericEdit.TabIndex = 8;
            this.attenuationNumericEdit.Value = 60;
            // 
            // rippleNumericEdit
            // 
            this.rippleNumericEdit.CoercionInterval = 0.01;
            this.rippleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.rippleNumericEdit.Location = new System.Drawing.Point(16, 176);
            this.rippleNumericEdit.Name = "rippleNumericEdit";
            this.rippleNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.rippleNumericEdit.Range = new NationalInstruments.UI.Range(0.001, 1000);
            this.rippleNumericEdit.Size = new System.Drawing.Size(96, 20);
            this.rippleNumericEdit.TabIndex = 6;
            this.rippleNumericEdit.Value = 0.01;
            // 
            // phaseScatterGraph
            // 
            this.phaseScatterGraph.Caption = "Phase Graph";
            this.phaseScatterGraph.Location = new System.Drawing.Point(12, 243);
            this.phaseScatterGraph.Name = "phaseScatterGraph";
            this.phaseScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.phasePlot});
            this.phaseScatterGraph.Size = new System.Drawing.Size(432, 231);
            this.phaseScatterGraph.TabIndex = 7;
            this.phaseScatterGraph.TabStop = false;
            this.phaseScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.phaseXAxis});
            this.phaseScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.phaseYAxis});
            // 
            // phasePlot
            // 
            this.phasePlot.XAxis = this.phaseXAxis;
            this.phasePlot.YAxis = this.phaseYAxis;
            // 
            // phaseXAxis
            // 
            this.phaseXAxis.Caption = "Frequency";
            // 
            // phaseYAxis
            // 
            this.phaseYAxis.Caption = "Phase (radian)";
            // 
            // magnitudeScatterGraph
            // 
            this.magnitudeScatterGraph.Caption = "Magnitude Graph";
            this.magnitudeScatterGraph.Location = new System.Drawing.Point(13, 10);
            this.magnitudeScatterGraph.Name = "magnitudeScatterGraph";
            this.magnitudeScatterGraph.Plots.AddRange(new NationalInstruments.UI.ScatterPlot[] {
            this.magnitudePlot});
            this.magnitudeScatterGraph.Size = new System.Drawing.Size(432, 224);
            this.magnitudeScatterGraph.TabIndex = 7;
            this.magnitudeScatterGraph.TabStop = false;
            this.magnitudeScatterGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.magnitudeXAxis});
            this.magnitudeScatterGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.magnitudeYAxis});
            // 
            // magnitudePlot
            // 
            this.magnitudePlot.XAxis = this.magnitudeXAxis;
            this.magnitudePlot.YAxis = this.magnitudeYAxis;
            // 
            // magnitudeXAxis
            // 
            this.magnitudeXAxis.Caption = "Frequency";
            // 
            // magnitudeYAxis
            // 
            this.magnitudeYAxis.Caption = "Magnitude";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(471, 366);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 11;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(590, 486);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.phaseScatterGraph);
            this.Controls.Add(this.filterParametersGroupBox);
            this.Controls.Add(this.magnitudeScatterGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NarrowbandFiltering";
            this.filterParametersGroupBox.ResumeLayout(false);
            this.filterParametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.centerFrequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopbandNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passbandNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attenuationNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rippleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseScatterGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitudeScatterGraph)).EndInit();
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

        // when the filter type selected by the user gets changed.
        private void filterType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (filterTypeComboBox.SelectedIndex == 2 ||
                filterTypeComboBox.SelectedIndex == 3)
                centerFrequencyNumericEdit.Enabled = true;
            else
                centerFrequencyNumericEdit.Enabled = false;

        }

        

        private void updateButton_Click(object sender, EventArgs e)
        {

            NarrowbandFirFilterBase filter = null;
            double[] impulse = { 1.0 };
            switch (filterTypeComboBox.SelectedIndex)
            {
                    //Lowpass
                case 0:
                    filter = new NarrowbandFirLowpassFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value);
                    break;
                    //Highpass
                case 1:
                    filter = new NarrowbandFirHighpassFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value);
                    break;
                    // Bandpass
                case 2:
                    filter = new NarrowbandFirBandpassFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value);
                    break;
                    // Bandstop
                case 3:
                    filter = new NarrowbandFirBandstopFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value);
                    break;
            }
            try
            {
                double[] impulseResponse = filter.FilterData(impulse);
                ComplexDouble[] spectrum = Analysis.Dsp.Transforms.RealFft(impulseResponse);
                double[] magnitudeResponse;
                double[] phaseResponse;
                ComplexDouble.DecomposeArrayPolar(spectrum, out magnitudeResponse, out phaseResponse);
                double[] plotFrequency = Analysis.SignalGeneration.PatternGeneration.Ramp(impulseResponse.Length, 0, impulseResponse.Length * 10000);
                magnitudeScatterGraph.PlotXY(plotFrequency, magnitudeResponse);
                phaseScatterGraph.PlotXY(plotFrequency, phaseResponse);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
    }
}
