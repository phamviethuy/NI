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
using NationalInstruments.UI;


namespace NationalInstruments.Examples.StatisticalFailurePrediction
{
   
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private double []buffer;
        private int counter = 0;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.Label degreesOfFreedomLabel;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label standardDeviationLabel;
        private System.Windows.Forms.GroupBox inputDataPointsSubGroupBox;
        private System.Windows.Forms.Label dataPointsLabel;
        private System.Windows.Forms.Label confidenceLevelLabel;
        private System.Windows.Forms.Label numberOfSamplesLabel;
        private System.Windows.Forms.Label userHelpLabel;
        private System.Windows.Forms.Label dataPointsEnteredLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit degreesOfFreedomNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit standardDeviationNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit confidenceLevelNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit dataPointsNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit dataPointsEnteredNumericEdit;
        private System.Windows.Forms.Button enterValueButton;
        private System.Windows.Forms.GroupBox inputDataPointsGroupBox;
        private System.Windows.Forms.TextBox meanTextBox;
        private System.Windows.Forms.GroupBox predictedParametersGroupBox;
            
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.helpLabel = new System.Windows.Forms.Label();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            this.degreesOfFreedomLabel = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.standardDeviationLabel = new System.Windows.Forms.Label();
            this.predictedParametersGroupBox = new System.Windows.Forms.GroupBox();
            this.degreesOfFreedomNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.standardDeviationNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.inputDataPointsSubGroupBox = new System.Windows.Forms.GroupBox();
            this.confidenceLevelNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.dataPointsNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.dataPointsLabel = new System.Windows.Forms.Label();
            this.confidenceLevelLabel = new System.Windows.Forms.Label();
            this.numberOfSamplesLabel = new System.Windows.Forms.Label();
            this.userHelpLabel = new System.Windows.Forms.Label();
            this.enterValueButton = new System.Windows.Forms.Button();
            this.inputDataPointsGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.dataPointsEnteredLabel = new System.Windows.Forms.Label();
            this.dataPointsEnteredNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.predictedParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.degreesOfFreedomNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardDeviationNumericEdit)).BeginInit();
            this.inputDataPointsSubGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confidenceLevelNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPointsNumericEdit)).BeginInit();
            this.inputDataPointsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPointsEnteredNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // helpLabel
            // 
            this.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.helpLabel.Location = new System.Drawing.Point(16, 296);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(424, 48);
            this.helpLabel.TabIndex = 5;
            this.helpLabel.Text = "In this example, the input data represents the mean time between failures in hour" +
                "s. The Predicted Parameters estimate when the next failure will occur with a var" +
                "iable confidence level.";
            // 
            // meanTextBox
            // 
            this.meanTextBox.Location = new System.Drawing.Point(16, 152);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.ReadOnly = true;
            this.meanTextBox.Size = new System.Drawing.Size(128, 20);
            this.meanTextBox.TabIndex = 2;
            this.meanTextBox.TabStop = false;
            this.meanTextBox.Text = "";
            // 
            // degreesOfFreedomLabel
            // 
            this.degreesOfFreedomLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.degreesOfFreedomLabel.Location = new System.Drawing.Point(16, 80);
            this.degreesOfFreedomLabel.Name = "degreesOfFreedomLabel";
            this.degreesOfFreedomLabel.Size = new System.Drawing.Size(112, 16);
            this.degreesOfFreedomLabel.TabIndex = 3;
            this.degreesOfFreedomLabel.Text = "Degrees of Freedom:";
            // 
            // meanLabel
            // 
            this.meanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.meanLabel.Location = new System.Drawing.Point(16, 136);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(40, 16);
            this.meanLabel.TabIndex = 3;
            this.meanLabel.Text = "Mean:";
            // 
            // standardDeviationLabel
            // 
            this.standardDeviationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.standardDeviationLabel.Location = new System.Drawing.Point(16, 24);
            this.standardDeviationLabel.Name = "standardDeviationLabel";
            this.standardDeviationLabel.Size = new System.Drawing.Size(128, 16);
            this.standardDeviationLabel.TabIndex = 3;
            this.standardDeviationLabel.Text = "Standard Deviation:";
            // 
            // predictedParametersGroupBox
            // 
            this.predictedParametersGroupBox.Controls.Add(this.degreesOfFreedomNumericEdit);
            this.predictedParametersGroupBox.Controls.Add(this.standardDeviationNumericEdit);
            this.predictedParametersGroupBox.Controls.Add(this.meanTextBox);
            this.predictedParametersGroupBox.Controls.Add(this.degreesOfFreedomLabel);
            this.predictedParametersGroupBox.Controls.Add(this.meanLabel);
            this.predictedParametersGroupBox.Controls.Add(this.standardDeviationLabel);
            this.predictedParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.predictedParametersGroupBox.Location = new System.Drawing.Point(264, 88);
            this.predictedParametersGroupBox.Name = "predictedParametersGroupBox";
            this.predictedParametersGroupBox.Size = new System.Drawing.Size(168, 192);
            this.predictedParametersGroupBox.TabIndex = 6;
            this.predictedParametersGroupBox.TabStop = false;
            this.predictedParametersGroupBox.Text = "Predicted Parameters";
            // 
            // degreesOfFreedomNumericEdit
            // 
            this.degreesOfFreedomNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.degreesOfFreedomNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.degreesOfFreedomNumericEdit.Location = new System.Drawing.Point(16, 96);
            this.degreesOfFreedomNumericEdit.Name = "degreesOfFreedomNumericEdit";
            this.degreesOfFreedomNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.degreesOfFreedomNumericEdit.TabIndex = 1;
            this.degreesOfFreedomNumericEdit.TabStop = false;
            // 
            // standardDeviationNumericEdit
            // 
            this.standardDeviationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5);
            this.standardDeviationNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.standardDeviationNumericEdit.Location = new System.Drawing.Point(16, 40);
            this.standardDeviationNumericEdit.Name = "standardDeviationNumericEdit";
            this.standardDeviationNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.standardDeviationNumericEdit.TabIndex = 0;
            this.standardDeviationNumericEdit.TabStop = false;
            // 
            // inputDataPointsSubGroupBox
            // 
            this.inputDataPointsSubGroupBox.Controls.Add(this.confidenceLevelNumericEdit);
            this.inputDataPointsSubGroupBox.Controls.Add(this.dataPointsNumericEdit);
            this.inputDataPointsSubGroupBox.Controls.Add(this.dataPointsLabel);
            this.inputDataPointsSubGroupBox.Controls.Add(this.confidenceLevelLabel);
            this.inputDataPointsSubGroupBox.Location = new System.Drawing.Point(16, 120);
            this.inputDataPointsSubGroupBox.Name = "inputDataPointsSubGroupBox";
            this.inputDataPointsSubGroupBox.Size = new System.Drawing.Size(120, 120);
            this.inputDataPointsSubGroupBox.TabIndex = 1;
            this.inputDataPointsSubGroupBox.TabStop = false;
            this.inputDataPointsSubGroupBox.Text = "Data";
            // 
            // confidenceLevelNumericEdit
            // 
            this.confidenceLevelNumericEdit.CoercionInterval = 0.01;
            this.confidenceLevelNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
            this.confidenceLevelNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2);
            this.confidenceLevelNumericEdit.Location = new System.Drawing.Point(16, 88);
            this.confidenceLevelNumericEdit.Name = "confidenceLevelNumericEdit";
            this.confidenceLevelNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.confidenceLevelNumericEdit.Range = new NationalInstruments.UI.Range(0.01, 0.99);
            this.confidenceLevelNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.confidenceLevelNumericEdit.TabIndex = 1;
            this.confidenceLevelNumericEdit.Value = 0.9;
            // 
            // dataPointsNumericEdit
            // 
            this.dataPointsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.dataPointsNumericEdit.Location = new System.Drawing.Point(16, 40);
            this.dataPointsNumericEdit.Name = "dataPointsNumericEdit";
            this.dataPointsNumericEdit.Range = new NationalInstruments.UI.Range(0, 10);
            this.dataPointsNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.dataPointsNumericEdit.TabIndex = 0;
            this.dataPointsNumericEdit.Value = 1;
            // 
            // dataPointsLabel
            // 
            this.dataPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dataPointsLabel.Location = new System.Drawing.Point(16, 24);
            this.dataPointsLabel.Name = "dataPointsLabel";
            this.dataPointsLabel.Size = new System.Drawing.Size(80, 16);
            this.dataPointsLabel.TabIndex = 3;
            this.dataPointsLabel.Text = "Data Point:";
            // 
            // confidenceLevelLabel
            // 
            this.confidenceLevelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.confidenceLevelLabel.Location = new System.Drawing.Point(16, 72);
            this.confidenceLevelLabel.Name = "confidenceLevelLabel";
            this.confidenceLevelLabel.Size = new System.Drawing.Size(96, 16);
            this.confidenceLevelLabel.TabIndex = 3;
            this.confidenceLevelLabel.Text = "Confidence Level:";
            // 
            // numberOfSamplesLabel
            // 
            this.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numberOfSamplesLabel.Location = new System.Drawing.Point(24, 82);
            this.numberOfSamplesLabel.Name = "numberOfSamplesLabel";
            this.numberOfSamplesLabel.Size = new System.Drawing.Size(112, 16);
            this.numberOfSamplesLabel.TabIndex = 6;
            this.numberOfSamplesLabel.Text = "Number of Samples:";
            // 
            // userHelpLabel
            // 
            this.userHelpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userHelpLabel.Location = new System.Drawing.Point(16, 24);
            this.userHelpLabel.Name = "userHelpLabel";
            this.userHelpLabel.Size = new System.Drawing.Size(208, 40);
            this.userHelpLabel.TabIndex = 4;
            this.userHelpLabel.Text = "Use the \'Enter Value\' button to specify 2 to 100 data samples. Input the value of" +
                " each data point with confidence level. ";
            // 
            // enterValueButton
            // 
            this.enterValueButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enterValueButton.Location = new System.Drawing.Point(144, 168);
            this.enterValueButton.Name = "enterValueButton";
            this.enterValueButton.Size = new System.Drawing.Size(80, 24);
            this.enterValueButton.TabIndex = 2;
            this.enterValueButton.Text = "Enter Value";
            this.enterValueButton.Click += new System.EventHandler(this.enterValue_Click);
            // 
            // inputDataPointsGroupBox
            // 
            this.inputDataPointsGroupBox.Controls.Add(this.numberOfSamplesNumericEdit);
            this.inputDataPointsGroupBox.Controls.Add(this.inputDataPointsSubGroupBox);
            this.inputDataPointsGroupBox.Controls.Add(this.numberOfSamplesLabel);
            this.inputDataPointsGroupBox.Controls.Add(this.userHelpLabel);
            this.inputDataPointsGroupBox.Controls.Add(this.enterValueButton);
            this.inputDataPointsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.inputDataPointsGroupBox.Location = new System.Drawing.Point(16, 16);
            this.inputDataPointsGroupBox.Name = "inputDataPointsGroupBox";
            this.inputDataPointsGroupBox.Size = new System.Drawing.Size(232, 264);
            this.inputDataPointsGroupBox.TabIndex = 0;
            this.inputDataPointsGroupBox.TabStop = false;
            this.inputDataPointsGroupBox.Text = "Input Data Points";
            // 
            // numberOfSamplesNumericEdit
            // 
            this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(144, 80);
            this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
            this.numberOfSamplesNumericEdit.Range = new NationalInstruments.UI.Range(2, System.Double.PositiveInfinity);
            this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(64, 20);
            this.numberOfSamplesNumericEdit.TabIndex = 0;
            this.numberOfSamplesNumericEdit.Value = 2;
            this.numberOfSamplesNumericEdit.ValueChanged += new System.EventHandler(this.numberOfSamples_ValueChanged);
            // 
            // dataPointsEnteredLabel
            // 
            this.dataPointsEnteredLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dataPointsEnteredLabel.Location = new System.Drawing.Point(264, 42);
            this.dataPointsEnteredLabel.Name = "dataPointsEnteredLabel";
            this.dataPointsEnteredLabel.Size = new System.Drawing.Size(112, 16);
            this.dataPointsEnteredLabel.TabIndex = 3;
            this.dataPointsEnteredLabel.Text = "Data Points Entered:";
            // 
            // dataPointsEnteredNumericEdit
            // 
            this.dataPointsEnteredNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.dataPointsEnteredNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.dataPointsEnteredNumericEdit.Location = new System.Drawing.Point(376, 40);
            this.dataPointsEnteredNumericEdit.Name = "dataPointsEnteredNumericEdit";
            this.dataPointsEnteredNumericEdit.Size = new System.Drawing.Size(48, 20);
            this.dataPointsEnteredNumericEdit.TabIndex = 7;
            this.dataPointsEnteredNumericEdit.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(448, 360);
            this.Controls.Add(this.dataPointsEnteredNumericEdit);
            this.Controls.Add(this.predictedParametersGroupBox);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.inputDataPointsGroupBox);
            this.Controls.Add(this.dataPointsEnteredLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistical Failure Prediction";
            this.predictedParametersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.degreesOfFreedomNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardDeviationNumericEdit)).EndInit();
            this.inputDataPointsSubGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.confidenceLevelNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPointsNumericEdit)).EndInit();
            this.inputDataPointsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPointsEnteredNumericEdit)).EndInit();
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

       
        private void enterValue_Click(object sender, System.EventArgs e)
        {   
            if(counter == 0)
            {
                buffer = new Double[(int)numberOfSamplesNumericEdit.Value];
                numberOfSamplesNumericEdit.Enabled = false;
                numberOfSamplesLabel.Enabled = false;
            }
            buffer[counter++] = (double)dataPointsNumericEdit.Value;           
                
            dataPointsEnteredNumericEdit.Text = String.Format("{0:F0} ", counter); 

            if(counter >= ((int)numberOfSamplesNumericEdit.Value))
            {
                enterValueButton.Enabled = false; 
                CalculateStatisticalFailure();
            }
        }

        private void CalculateStatisticalFailure()
        {
            double probability;
            double deviation;
            double meanValue;
            double result;
            double confidence;
            double width;
            String widthString;
            String meanString;
        
            confidence = (double)confidenceLevelNumericEdit.Value;
            probability = (1 - confidence)/2 + confidence;
            result = Probability.InverseTDistribution(probability, counter -1);
            meanValue = Statistics.Mean(buffer);
            deviation = Statistics.StandardDeviation(buffer);
            width = deviation*(result*1/(System.Math.Sqrt(counter)));
            degreesOfFreedomNumericEdit.Value = counter-1;
            standardDeviationNumericEdit.Value= deviation;
            widthString = String.Format("{0:F5} ", width);
            meanString = String.Format("{0:F5} ", meanValue);
            meanTextBox.Text = String.Concat(meanString," +/- ",widthString);

            numberOfSamplesNumericEdit.Enabled = true;
            numberOfSamplesLabel.Enabled = true;
            dataPointsNumericEdit.Enabled = false;
            confidenceLevelNumericEdit.Enabled = false;
            dataPointsLabel.Enabled = false;
            confidenceLevelLabel.Enabled = false;
            counter = 0;            
            numberOfSamplesNumericEdit.Focus();

        }

        private void numberOfSamples_ValueChanged(object sender, System.EventArgs e)
        {
            dataPointsNumericEdit.Enabled = true;
            dataPointsLabel.Enabled = true;
            confidenceLevelNumericEdit.Enabled = true;
            confidenceLevelLabel.Enabled = true;
            enterValueButton.Enabled = true;
            dataPointsEnteredNumericEdit.Value = 0;
            standardDeviationNumericEdit.Value = 0;
            degreesOfFreedomNumericEdit.Value = 0;
            meanTextBox.Clear();
        }   
        
    }
}
