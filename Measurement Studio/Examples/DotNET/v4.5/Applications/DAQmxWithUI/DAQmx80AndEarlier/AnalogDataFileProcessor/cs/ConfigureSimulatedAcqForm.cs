using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using NationalInstruments.Analysis.SignalGeneration;

namespace NationalInstruments.Examples.AnalogDataFileProcessor
{
	/// <summary>
	/// Form used to configure a simulated data acquisition. The caller 
	/// creates a BasicFunctionGenerator instance and passes it to the
	/// constructor of this ConfigureSimulatedAcqForm. 
	/// If ConfigureSimulatedAcqForm.ShowDialog() return DialogResult.OK,
	/// the user successfully configured the BasicFunctionGenerator instance.
	/// </summary>
	public class ConfigureSimulatedAcqForm : System.Windows.Forms.Form
	{
        private BasicFunctionGenerator dataGenerator;

        private System.Windows.Forms.ComboBox signalTypeComboBox;
        private System.Windows.Forms.Label signalTypeLabel;
        private System.Windows.Forms.Label amplitudeLabel;
        private System.Windows.Forms.Label dutyCycleLabel;
        private System.Windows.Forms.Label frequencyLabel;
        private System.Windows.Forms.Label numberOfSamplesLabel;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.Label phaseLabel;
        private System.Windows.Forms.Label samplingRateLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit amplitudeNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit dutyCycleNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit frequencyNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit numberOfSamplesNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit offsetNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit phaseNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit samplingRateNumericEdit;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ConfigureSimulatedAcqForm(BasicFunctionGenerator simulatedDataGenerator)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            //
            // Populate the combo box with all of the possible signal types.
            //
            signalTypeComboBox.Items.AddRange(Enum.GetNames(typeof(BasicFunctionGeneratorSignal)));

            dataGenerator = simulatedDataGenerator;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
            this.signalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.signalTypeLabel = new System.Windows.Forms.Label();
            this.amplitudeLabel = new System.Windows.Forms.Label();
            this.dutyCycleLabel = new System.Windows.Forms.Label();
            this.frequencyLabel = new System.Windows.Forms.Label();
            this.numberOfSamplesLabel = new System.Windows.Forms.Label();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.phaseLabel = new System.Windows.Forms.Label();
            this.samplingRateLabel = new System.Windows.Forms.Label();
            this.amplitudeNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.dutyCycleNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.frequencyNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numberOfSamplesNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.offsetNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.phaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.samplingRateNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycleNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // signalTypeComboBox
            // 
            this.signalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signalTypeComboBox.Location = new System.Drawing.Point(128, 8);
            this.signalTypeComboBox.Name = "signalTypeComboBox";
            this.signalTypeComboBox.Size = new System.Drawing.Size(152, 21);
            this.signalTypeComboBox.TabIndex = 1;
            this.signalTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.signalTypeComboBox_SelectedIndexChanged);
            // 
            // signalTypeLabel
            // 
            this.signalTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.signalTypeLabel.Location = new System.Drawing.Point(8, 8);
            this.signalTypeLabel.Name = "signalTypeLabel";
            this.signalTypeLabel.Size = new System.Drawing.Size(112, 21);
            this.signalTypeLabel.TabIndex = 0;
            this.signalTypeLabel.Text = "Signal Type:";
            // 
            // amplitudeLabel
            // 
            this.amplitudeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.amplitudeLabel.Location = new System.Drawing.Point(8, 46);
            this.amplitudeLabel.Name = "amplitudeLabel";
            this.amplitudeLabel.Size = new System.Drawing.Size(112, 23);
            this.amplitudeLabel.TabIndex = 2;
            this.amplitudeLabel.Text = "Amplitude:";
            // 
            // dutyCycleLabel
            // 
            this.dutyCycleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.dutyCycleLabel.Location = new System.Drawing.Point(8, 86);
            this.dutyCycleLabel.Name = "dutyCycleLabel";
            this.dutyCycleLabel.Size = new System.Drawing.Size(112, 23);
            this.dutyCycleLabel.TabIndex = 4;
            this.dutyCycleLabel.Text = "Duty Cycle:";
            // 
            // frequencyLabel
            // 
            this.frequencyLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.frequencyLabel.Location = new System.Drawing.Point(8, 126);
            this.frequencyLabel.Name = "frequencyLabel";
            this.frequencyLabel.Size = new System.Drawing.Size(112, 23);
            this.frequencyLabel.TabIndex = 6;
            this.frequencyLabel.Text = "Frequency:";
            // 
            // numberOfSamplesLabel
            // 
            this.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numberOfSamplesLabel.Location = new System.Drawing.Point(8, 166);
            this.numberOfSamplesLabel.Name = "numberOfSamplesLabel";
            this.numberOfSamplesLabel.Size = new System.Drawing.Size(112, 23);
            this.numberOfSamplesLabel.TabIndex = 8;
            this.numberOfSamplesLabel.Text = "Number of Samples:";
            // 
            // offsetLabel
            // 
            this.offsetLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.offsetLabel.Location = new System.Drawing.Point(8, 206);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(112, 23);
            this.offsetLabel.TabIndex = 10;
            this.offsetLabel.Text = "Offset:";
            // 
            // phaseLabel
            // 
            this.phaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.phaseLabel.Location = new System.Drawing.Point(8, 246);
            this.phaseLabel.Name = "phaseLabel";
            this.phaseLabel.Size = new System.Drawing.Size(112, 23);
            this.phaseLabel.TabIndex = 12;
            this.phaseLabel.Text = "Phase:";
            // 
            // samplingRateLabel
            // 
            this.samplingRateLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplingRateLabel.Location = new System.Drawing.Point(8, 286);
            this.samplingRateLabel.Name = "samplingRateLabel";
            this.samplingRateLabel.Size = new System.Drawing.Size(112, 23);
            this.samplingRateLabel.TabIndex = 14;
            this.samplingRateLabel.Text = "Sampling Rate:";
            // 
            // amplitudeNumericEdit
            // 
            this.amplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.amplitudeNumericEdit.Location = new System.Drawing.Point(128, 48);
            this.amplitudeNumericEdit.Name = "amplitudeNumericEdit";
            this.amplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.amplitudeNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.amplitudeNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.amplitudeNumericEdit.TabIndex = 3;
            this.amplitudeNumericEdit.Value = 5;
            // 
            // dutyCycleNumericEdit
            // 
            this.dutyCycleNumericEdit.CoercionInterval = 10;
            this.dutyCycleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.dutyCycleNumericEdit.Location = new System.Drawing.Point(128, 88);
            this.dutyCycleNumericEdit.Name = "dutyCycleNumericEdit";
            this.dutyCycleNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.dutyCycleNumericEdit.Range = new NationalInstruments.UI.Range(0, 100);
            this.dutyCycleNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.dutyCycleNumericEdit.TabIndex = 5;
            // 
            // frequencyNumericEdit
            // 
            this.frequencyNumericEdit.CoercionInterval = 100;
            this.frequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.frequencyNumericEdit.Location = new System.Drawing.Point(128, 128);
            this.frequencyNumericEdit.Name = "frequencyNumericEdit";
            this.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.frequencyNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.frequencyNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.frequencyNumericEdit.TabIndex = 7;
            // 
            // numberOfSamplesNumericEdit
            // 
            this.numberOfSamplesNumericEdit.CoercionInterval = 100;
            this.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.numberOfSamplesNumericEdit.Location = new System.Drawing.Point(128, 168);
            this.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit";
            this.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.numberOfSamplesNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.numberOfSamplesNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.numberOfSamplesNumericEdit.TabIndex = 9;
            // 
            // offsetNumericEdit
            // 
            this.offsetNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.offsetNumericEdit.Location = new System.Drawing.Point(128, 208);
            this.offsetNumericEdit.Name = "offsetNumericEdit";
            this.offsetNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.offsetNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.offsetNumericEdit.TabIndex = 11;
            // 
            // phaseNumericEdit
            // 
            this.phaseNumericEdit.CoercionInterval = 30;
            this.phaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.phaseNumericEdit.Location = new System.Drawing.Point(128, 248);
            this.phaseNumericEdit.Name = "phaseNumericEdit";
            this.phaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.phaseNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.phaseNumericEdit.TabIndex = 13;
            // 
            // samplingRateNumericEdit
            // 
            this.samplingRateNumericEdit.CoercionInterval = 100;
            this.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.samplingRateNumericEdit.Location = new System.Drawing.Point(128, 288);
            this.samplingRateNumericEdit.Name = "samplingRateNumericEdit";
            this.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.samplingRateNumericEdit.Range = new NationalInstruments.UI.Range(0, System.Double.PositiveInfinity);
            this.samplingRateNumericEdit.Size = new System.Drawing.Size(152, 20);
            this.samplingRateNumericEdit.TabIndex = 15;
            // 
            // okButton
            // 
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.okButton.Location = new System.Drawing.Point(59, 328);
            this.okButton.Name = "okButton";
            this.okButton.TabIndex = 16;
            this.okButton.Text = "&OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cancelButton.Location = new System.Drawing.Point(155, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "&Cancel";
            // 
            // ConfigureSimulatedAcqForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(288, 365);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.samplingRateNumericEdit);
            this.Controls.Add(this.phaseNumericEdit);
            this.Controls.Add(this.offsetNumericEdit);
            this.Controls.Add(this.numberOfSamplesNumericEdit);
            this.Controls.Add(this.frequencyNumericEdit);
            this.Controls.Add(this.dutyCycleNumericEdit);
            this.Controls.Add(this.amplitudeNumericEdit);
            this.Controls.Add(this.samplingRateLabel);
            this.Controls.Add(this.phaseLabel);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.numberOfSamplesLabel);
            this.Controls.Add(this.frequencyLabel);
            this.Controls.Add(this.dutyCycleLabel);
            this.Controls.Add(this.amplitudeLabel);
            this.Controls.Add(this.signalTypeLabel);
            this.Controls.Add(this.signalTypeComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigureSimulatedAcqForm";
            this.Text = "Configure Simulated Acquisition";
            this.Load += new System.EventHandler(this.ConfigureSimulatedAcqForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dutyCycleNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfSamplesNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplingRateNumericEdit)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        private void ConfigureSimulatedAcqForm_Load(object sender, System.EventArgs e)
        {
            PopulateControls();
        }

        private void signalTypeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //
            // Duty cycle applies only to square waves.
            //
            dutyCycleNumericEdit.Enabled = ((BasicFunctionGeneratorSignal)Enum.Parse(typeof(BasicFunctionGeneratorSignal), signalTypeComboBox.SelectedItem.ToString()) == BasicFunctionGeneratorSignal.Square);
        }

        private void okButton_Click(object sender, System.EventArgs e)
        {
            ReadFromControls();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void PopulateControls()
        {
            amplitudeNumericEdit.Value = dataGenerator.Amplitude;
            dutyCycleNumericEdit.Value = dataGenerator.DutyCycle;
            frequencyNumericEdit.Value = dataGenerator.Frequency;
            numberOfSamplesNumericEdit.Value = dataGenerator.NumberOfSamples;
            offsetNumericEdit.Value = dataGenerator.Offset;
            phaseNumericEdit.Value = dataGenerator.Phase;
            samplingRateNumericEdit.Value = dataGenerator.SamplingRate;
            signalTypeComboBox.SelectedItem = dataGenerator.SignalType.ToString();
        }

        private void ReadFromControls()
        {
            dataGenerator.Amplitude = amplitudeNumericEdit.Value;
            dataGenerator.DutyCycle = dutyCycleNumericEdit.Value;
            dataGenerator.Frequency = frequencyNumericEdit.Value;
            dataGenerator.NumberOfSamples = (int)numberOfSamplesNumericEdit.Value;
            dataGenerator.Offset = offsetNumericEdit.Value;
            dataGenerator.Phase = phaseNumericEdit.Value;
            dataGenerator.SamplingRate = samplingRateNumericEdit.Value;
            dataGenerator.SignalType = (BasicFunctionGeneratorSignal)Enum.Parse(typeof(BasicFunctionGeneratorSignal), signalTypeComboBox.SelectedItem.ToString());
        }
    }
}
