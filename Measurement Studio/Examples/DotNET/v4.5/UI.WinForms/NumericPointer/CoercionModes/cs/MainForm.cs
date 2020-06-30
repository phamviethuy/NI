using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CoercionModes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.Knob sampleKnob;
        private System.Windows.Forms.GroupBox valuesGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit setValueNumericEdit;
        private System.Windows.Forms.Label setValueLabel;
        private System.Windows.Forms.Label coercedValueLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit coercedValueNumericEdit;
        private System.Windows.Forms.Label previousValueLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit previousValueNumericEdit;
        private System.Windows.Forms.Label nextValueLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit nextValueNumericEdit;
        private System.Windows.Forms.Button commitButton;
        private System.Windows.Forms.GroupBox coercionModeGroupBox;
        private System.Windows.Forms.RadioButton noneModeRadioButton;
        private System.Windows.Forms.RadioButton toDivisionsModeRadioButton;
        private System.Windows.Forms.RadioButton toIntervalModeRadioButton;
        private System.Windows.Forms.GroupBox divisionsGroupBox;
        private System.Windows.Forms.CheckBox enableMajorDivisionsCheckBox;
        private System.Windows.Forms.CheckBox enableMinorDivisionsCheckBox;
        private System.Windows.Forms.CheckBox enableCustomDivisionsCheckBox;
        private System.Windows.Forms.GroupBox coercionIntervalGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit intervalNumericEdit;
        private System.Windows.Forms.Label intervalBaseLabel;
        private System.Windows.Forms.Label intervalLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit intervalBaseNumericEdit;
        private System.Windows.Forms.GroupBox outOfRangeModeGroupBox;
        private System.Windows.Forms.ComboBox outOfRangeModeComboBox;
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

            //
            // Set initial control values
            //
            sampleKnob.CoercionMode = NumericCoercionMode.None;
            noneModeRadioButton.Checked = true;

            setValueNumericEdit.Value = sampleKnob.Value;

            SetCoercedValueNumericEdits();

            enableMajorDivisionsCheckBox.Checked = true;
            enableMinorDivisionsCheckBox.Checked = true;
            enableCustomDivisionsCheckBox.Checked = true;

            intervalBaseNumericEdit.Value = sampleKnob.CoercionIntervalBase;
            intervalNumericEdit.Value = sampleKnob.CoercionInterval;

            outOfRangeModeComboBox.Items.AddRange(Enum.GetNames(typeof(NumericOutOfRangeMode)));
            outOfRangeModeComboBox.SelectedIndex = outOfRangeModeComboBox.Items.IndexOf(NumericOutOfRangeMode.ThrowException.ToString());
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
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision1 = new NationalInstruments.UI.ScaleCustomDivision();
            NationalInstruments.UI.ScaleCustomDivision scaleCustomDivision2 = new NationalInstruments.UI.ScaleCustomDivision();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.valuesGroupBox = new System.Windows.Forms.GroupBox();
            this.commitButton = new System.Windows.Forms.Button();
            this.nextValueLabel = new System.Windows.Forms.Label();
            this.nextValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.previousValueLabel = new System.Windows.Forms.Label();
            this.previousValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.coercedValueLabel = new System.Windows.Forms.Label();
            this.coercedValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.setValueLabel = new System.Windows.Forms.Label();
            this.setValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.coercionModeGroupBox = new System.Windows.Forms.GroupBox();
            this.toIntervalModeRadioButton = new System.Windows.Forms.RadioButton();
            this.toDivisionsModeRadioButton = new System.Windows.Forms.RadioButton();
            this.noneModeRadioButton = new System.Windows.Forms.RadioButton();
            this.divisionsGroupBox = new System.Windows.Forms.GroupBox();
            this.enableCustomDivisionsCheckBox = new System.Windows.Forms.CheckBox();
            this.enableMinorDivisionsCheckBox = new System.Windows.Forms.CheckBox();
            this.enableMajorDivisionsCheckBox = new System.Windows.Forms.CheckBox();
            this.coercionIntervalGroupBox = new System.Windows.Forms.GroupBox();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.intervalBaseLabel = new System.Windows.Forms.Label();
            this.intervalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.intervalBaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.outOfRangeModeGroupBox = new System.Windows.Forms.GroupBox();
            this.outOfRangeModeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).BeginInit();
            this.valuesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercedValueNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setValueNumericEdit)).BeginInit();
            this.coercionModeGroupBox.SuspendLayout();
            this.divisionsGroupBox.SuspendLayout();
            this.coercionIntervalGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBaseNumericEdit)).BeginInit();
            this.outOfRangeModeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleKnob
            // 
            this.sampleKnob.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            scaleCustomDivision1.Text = "2.5";
            scaleCustomDivision1.Value = 2.5;
            scaleCustomDivision2.Text = "7.5";
            scaleCustomDivision2.Value = 7.5;
            this.sampleKnob.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
            scaleCustomDivision1,
            scaleCustomDivision2});
            this.sampleKnob.Location = new System.Drawing.Point(0, 0);
            this.sampleKnob.Name = "sampleKnob";
            this.sampleKnob.Size = new System.Drawing.Size(280, 216);
            this.sampleKnob.TabIndex = 0;
            this.sampleKnob.ValueChanged += new System.EventHandler(this.knob_ValueChanged);
            // 
            // valuesGroupBox
            // 
            this.valuesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.valuesGroupBox.Controls.Add(this.commitButton);
            this.valuesGroupBox.Controls.Add(this.nextValueLabel);
            this.valuesGroupBox.Controls.Add(this.nextValueNumericEdit);
            this.valuesGroupBox.Controls.Add(this.previousValueLabel);
            this.valuesGroupBox.Controls.Add(this.previousValueNumericEdit);
            this.valuesGroupBox.Controls.Add(this.coercedValueLabel);
            this.valuesGroupBox.Controls.Add(this.coercedValueNumericEdit);
            this.valuesGroupBox.Controls.Add(this.setValueLabel);
            this.valuesGroupBox.Controls.Add(this.setValueNumericEdit);
            this.valuesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.valuesGroupBox.Location = new System.Drawing.Point(0, 215);
            this.valuesGroupBox.Name = "valuesGroupBox";
            this.valuesGroupBox.Size = new System.Drawing.Size(280, 117);
            this.valuesGroupBox.TabIndex = 1;
            this.valuesGroupBox.TabStop = false;
            this.valuesGroupBox.Text = "Values";
            // 
            // commitButton
            // 
            this.commitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.commitButton.Location = new System.Drawing.Point(200, 15);
            this.commitButton.Name = "commitButton";
            this.commitButton.Size = new System.Drawing.Size(75, 20);
            this.commitButton.TabIndex = 8;
            this.commitButton.Text = "Commit";
            this.commitButton.Click += new System.EventHandler(this.commitButton_Click);
            // 
            // nextValueLabel
            // 
            this.nextValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextValueLabel.Location = new System.Drawing.Point(8, 88);
            this.nextValueLabel.Name = "nextValueLabel";
            this.nextValueLabel.Size = new System.Drawing.Size(80, 20);
            this.nextValueLabel.TabIndex = 7;
            this.nextValueLabel.Text = "Next Value:";
            // 
            // nextValueNumericEdit
            // 
            this.nextValueNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.nextValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.nextValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.nextValueNumericEdit.Location = new System.Drawing.Point(104, 88);
            this.nextValueNumericEdit.Name = "nextValueNumericEdit";
            this.nextValueNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.nextValueNumericEdit.TabIndex = 6;
            // 
            // previousValueLabel
            // 
            this.previousValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.previousValueLabel.Location = new System.Drawing.Point(8, 64);
            this.previousValueLabel.Name = "previousValueLabel";
            this.previousValueLabel.Size = new System.Drawing.Size(80, 20);
            this.previousValueLabel.TabIndex = 5;
            this.previousValueLabel.Text = "Previous Value:";
            // 
            // previousValueNumericEdit
            // 
            this.previousValueNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.previousValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.previousValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.previousValueNumericEdit.Location = new System.Drawing.Point(104, 64);
            this.previousValueNumericEdit.Name = "previousValueNumericEdit";
            this.previousValueNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.previousValueNumericEdit.TabIndex = 4;
            // 
            // coercedValueLabel
            // 
            this.coercedValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coercedValueLabel.Location = new System.Drawing.Point(8, 40);
            this.coercedValueLabel.Name = "coercedValueLabel";
            this.coercedValueLabel.Size = new System.Drawing.Size(80, 20);
            this.coercedValueLabel.TabIndex = 3;
            this.coercedValueLabel.Text = "Coerced Value:";
            // 
            // coercedValueNumericEdit
            // 
            this.coercedValueNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.coercedValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.coercedValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.coercedValueNumericEdit.Location = new System.Drawing.Point(104, 40);
            this.coercedValueNumericEdit.Name = "coercedValueNumericEdit";
            this.coercedValueNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.coercedValueNumericEdit.TabIndex = 2;
            // 
            // setValueLabel
            // 
            this.setValueLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.setValueLabel.Location = new System.Drawing.Point(8, 16);
            this.setValueLabel.Name = "setValueLabel";
            this.setValueLabel.Size = new System.Drawing.Size(80, 20);
            this.setValueLabel.TabIndex = 1;
            this.setValueLabel.Text = "Set Value:";
            // 
            // setValueNumericEdit
            // 
            this.setValueNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.setValueNumericEdit.Location = new System.Drawing.Point(104, 16);
            this.setValueNumericEdit.Name = "setValueNumericEdit";
            this.setValueNumericEdit.Size = new System.Drawing.Size(80, 20);
            this.setValueNumericEdit.TabIndex = 0;
            // 
            // coercionModeGroupBox
            // 
            this.coercionModeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.coercionModeGroupBox.Controls.Add(this.toIntervalModeRadioButton);
            this.coercionModeGroupBox.Controls.Add(this.toDivisionsModeRadioButton);
            this.coercionModeGroupBox.Controls.Add(this.noneModeRadioButton);
            this.coercionModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coercionModeGroupBox.Location = new System.Drawing.Point(288, 6);
            this.coercionModeGroupBox.Name = "coercionModeGroupBox";
            this.coercionModeGroupBox.Size = new System.Drawing.Size(184, 104);
            this.coercionModeGroupBox.TabIndex = 2;
            this.coercionModeGroupBox.TabStop = false;
            this.coercionModeGroupBox.Text = "Coercion Mode";
            // 
            // toIntervalModeRadioButton
            // 
            this.toIntervalModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toIntervalModeRadioButton.Location = new System.Drawing.Point(8, 64);
            this.toIntervalModeRadioButton.Name = "toIntervalModeRadioButton";
            this.toIntervalModeRadioButton.Size = new System.Drawing.Size(104, 24);
            this.toIntervalModeRadioButton.TabIndex = 2;
            this.toIntervalModeRadioButton.Text = "ToInterval";
            this.toIntervalModeRadioButton.CheckedChanged += new System.EventHandler(this.toIntervalModeRadioButton_CheckedChanged);
            // 
            // toDivisionsModeRadioButton
            // 
            this.toDivisionsModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toDivisionsModeRadioButton.Location = new System.Drawing.Point(8, 40);
            this.toDivisionsModeRadioButton.Name = "toDivisionsModeRadioButton";
            this.toDivisionsModeRadioButton.Size = new System.Drawing.Size(104, 24);
            this.toDivisionsModeRadioButton.TabIndex = 1;
            this.toDivisionsModeRadioButton.Text = "ToDivisions";
            this.toDivisionsModeRadioButton.CheckedChanged += new System.EventHandler(this.toDivisionsModeRadioButton_CheckedChanged);
            // 
            // noneModeRadioButton
            // 
            this.noneModeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noneModeRadioButton.Location = new System.Drawing.Point(8, 16);
            this.noneModeRadioButton.Name = "noneModeRadioButton";
            this.noneModeRadioButton.Size = new System.Drawing.Size(104, 24);
            this.noneModeRadioButton.TabIndex = 0;
            this.noneModeRadioButton.Text = "None";
            this.noneModeRadioButton.CheckedChanged += new System.EventHandler(this.noneModeRadioButton_CheckedChanged);
            // 
            // divisionsGroupBox
            // 
            this.divisionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.divisionsGroupBox.Controls.Add(this.enableCustomDivisionsCheckBox);
            this.divisionsGroupBox.Controls.Add(this.enableMinorDivisionsCheckBox);
            this.divisionsGroupBox.Controls.Add(this.enableMajorDivisionsCheckBox);
            this.divisionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.divisionsGroupBox.Location = new System.Drawing.Point(288, 113);
            this.divisionsGroupBox.Name = "divisionsGroupBox";
            this.divisionsGroupBox.Size = new System.Drawing.Size(184, 96);
            this.divisionsGroupBox.TabIndex = 3;
            this.divisionsGroupBox.TabStop = false;
            this.divisionsGroupBox.Text = "Divisions";
            // 
            // enableCustomDivisionsCheckBox
            // 
            this.enableCustomDivisionsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enableCustomDivisionsCheckBox.Location = new System.Drawing.Point(8, 64);
            this.enableCustomDivisionsCheckBox.Name = "enableCustomDivisionsCheckBox";
            this.enableCustomDivisionsCheckBox.Size = new System.Drawing.Size(168, 24);
            this.enableCustomDivisionsCheckBox.TabIndex = 2;
            this.enableCustomDivisionsCheckBox.Text = "Enable Custom Divisions";
            this.enableCustomDivisionsCheckBox.CheckedChanged += new System.EventHandler(this.enableCustomDivisionsCheckBox_CheckedChanged);
            // 
            // enableMinorDivisionsCheckBox
            // 
            this.enableMinorDivisionsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enableMinorDivisionsCheckBox.Location = new System.Drawing.Point(8, 40);
            this.enableMinorDivisionsCheckBox.Name = "enableMinorDivisionsCheckBox";
            this.enableMinorDivisionsCheckBox.Size = new System.Drawing.Size(168, 24);
            this.enableMinorDivisionsCheckBox.TabIndex = 1;
            this.enableMinorDivisionsCheckBox.Text = "Enable Minor Divisions";
            this.enableMinorDivisionsCheckBox.CheckedChanged += new System.EventHandler(this.enableMinorDivisionsCheckBox_CheckedChanged);
            // 
            // enableMajorDivisionsCheckBox
            // 
            this.enableMajorDivisionsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enableMajorDivisionsCheckBox.Location = new System.Drawing.Point(8, 16);
            this.enableMajorDivisionsCheckBox.Name = "enableMajorDivisionsCheckBox";
            this.enableMajorDivisionsCheckBox.Size = new System.Drawing.Size(168, 24);
            this.enableMajorDivisionsCheckBox.TabIndex = 0;
            this.enableMajorDivisionsCheckBox.Text = "Enable Major Divisions";
            this.enableMajorDivisionsCheckBox.CheckedChanged += new System.EventHandler(this.enableMajorDivisionsCheckBox_CheckedChanged);
            // 
            // coercionIntervalGroupBox
            // 
            this.coercionIntervalGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.coercionIntervalGroupBox.Controls.Add(this.intervalLabel);
            this.coercionIntervalGroupBox.Controls.Add(this.intervalBaseLabel);
            this.coercionIntervalGroupBox.Controls.Add(this.intervalNumericEdit);
            this.coercionIntervalGroupBox.Controls.Add(this.intervalBaseNumericEdit);
            this.coercionIntervalGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coercionIntervalGroupBox.Location = new System.Drawing.Point(288, 212);
            this.coercionIntervalGroupBox.Name = "coercionIntervalGroupBox";
            this.coercionIntervalGroupBox.Size = new System.Drawing.Size(184, 72);
            this.coercionIntervalGroupBox.TabIndex = 4;
            this.coercionIntervalGroupBox.TabStop = false;
            this.coercionIntervalGroupBox.Text = "Coercion Interval";
            // 
            // intervalLabel
            // 
            this.intervalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.intervalLabel.Location = new System.Drawing.Point(8, 40);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(80, 23);
            this.intervalLabel.TabIndex = 3;
            this.intervalLabel.Text = "Interval:";
            // 
            // intervalBaseLabel
            // 
            this.intervalBaseLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.intervalBaseLabel.Location = new System.Drawing.Point(8, 16);
            this.intervalBaseLabel.Name = "intervalBaseLabel";
            this.intervalBaseLabel.Size = new System.Drawing.Size(80, 23);
            this.intervalBaseLabel.TabIndex = 2;
            this.intervalBaseLabel.Text = "Interval Base:";
            // 
            // intervalNumericEdit
            // 
            this.intervalNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.intervalNumericEdit.Location = new System.Drawing.Point(96, 40);
            this.intervalNumericEdit.Name = "intervalNumericEdit";
            this.intervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.intervalNumericEdit.Size = new System.Drawing.Size(69, 20);
            this.intervalNumericEdit.TabIndex = 1;
            this.intervalNumericEdit.Value = 1;
            this.intervalNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.intervalNumericEdit_BeforeChangeValue);
            this.intervalNumericEdit.ValueChanged += new System.EventHandler(this.intervalNumericEdit_ValueChanged);
            // 
            // intervalBaseNumericEdit
            // 
            this.intervalBaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.intervalBaseNumericEdit.Location = new System.Drawing.Point(96, 16);
            this.intervalBaseNumericEdit.Name = "intervalBaseNumericEdit";
            this.intervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.intervalBaseNumericEdit.Size = new System.Drawing.Size(69, 20);
            this.intervalBaseNumericEdit.TabIndex = 0;
            this.intervalBaseNumericEdit.ValueChanged += new System.EventHandler(this.intervalBaseNumericEdit_ValueChanged);
            // 
            // outOfRangeModeGroupBox
            // 
            this.outOfRangeModeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outOfRangeModeGroupBox.Controls.Add(this.outOfRangeModeComboBox);
            this.outOfRangeModeGroupBox.Location = new System.Drawing.Point(288, 287);
            this.outOfRangeModeGroupBox.Name = "outOfRangeModeGroupBox";
            this.outOfRangeModeGroupBox.Size = new System.Drawing.Size(184, 45);
            this.outOfRangeModeGroupBox.TabIndex = 5;
            this.outOfRangeModeGroupBox.TabStop = false;
            this.outOfRangeModeGroupBox.Text = "Out Of Range Mode";
            // 
            // outOfRangeModeComboBox
            // 
            this.outOfRangeModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outOfRangeModeComboBox.Location = new System.Drawing.Point(8, 16);
            this.outOfRangeModeComboBox.Name = "outOfRangeModeComboBox";
            this.outOfRangeModeComboBox.Size = new System.Drawing.Size(168, 21);
            this.outOfRangeModeComboBox.TabIndex = 0;
            this.outOfRangeModeComboBox.SelectedIndexChanged += new System.EventHandler(this.outOfRangeModeComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(472, 341);
            this.Controls.Add(this.outOfRangeModeGroupBox);
            this.Controls.Add(this.coercionIntervalGroupBox);
            this.Controls.Add(this.divisionsGroupBox);
            this.Controls.Add(this.coercionModeGroupBox);
            this.Controls.Add(this.valuesGroupBox);
            this.Controls.Add(this.sampleKnob);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Coercion Modes";
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).EndInit();
            this.valuesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercedValueNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setValueNumericEdit)).EndInit();
            this.coercionModeGroupBox.ResumeLayout(false);
            this.divisionsGroupBox.ResumeLayout(false);
            this.coercionIntervalGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intervalNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intervalBaseNumericEdit)).EndInit();
            this.outOfRangeModeGroupBox.ResumeLayout(false);
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

        private void knob_ValueChanged(object sender, System.EventArgs e)
        {
            SetCoercedValueNumericEdits();
        }

        private void noneModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            sampleKnob.CoercionMode = NumericCoercionMode.None;
            divisionsGroupBox.Enabled = false;
            coercionIntervalGroupBox.Enabled = false;
        }

        private void toDivisionsModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            sampleKnob.CoercionMode = NumericCoercionMode.ToDivisions;
            divisionsGroupBox.Enabled = true;
            coercionIntervalGroupBox.Enabled = false;
        }

        private void toIntervalModeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            sampleKnob.CoercionMode = NumericCoercionMode.ToInterval;
            divisionsGroupBox.Enabled = false;
            coercionIntervalGroupBox.Enabled = true;
        }

        private void enableMajorDivisionsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            sampleKnob.MajorDivisions.LabelVisible = enableMajorDivisionsCheckBox.Checked;
            sampleKnob.MajorDivisions.TickVisible = enableMajorDivisionsCheckBox.Checked;
            SetCoercedValueNumericEdits();
        }

        private void enableMinorDivisionsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            sampleKnob.MinorDivisions.TickVisible = enableMinorDivisionsCheckBox.Checked;        
            SetCoercedValueNumericEdits();
        }

        private void enableCustomDivisionsCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            foreach(ScaleCustomDivision customDivision in sampleKnob.CustomDivisions)
            {
                customDivision.LabelVisible = enableCustomDivisionsCheckBox.Checked;
                customDivision.TickVisible = enableCustomDivisionsCheckBox.Checked;
            }
            SetCoercedValueNumericEdits();
        }

        private void intervalBaseNumericEdit_ValueChanged(object sender, System.EventArgs e)
        {
            sampleKnob.CoercionIntervalBase = intervalBaseNumericEdit.Value;
        }

        private void intervalNumericEdit_ValueChanged(object sender, System.EventArgs e)
        {
            sampleKnob.CoercionInterval = intervalNumericEdit.Value;
        }

        private void commitButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                sampleKnob.Value = setValueNumericEdit.Value;
                SetCoercedValueNumericEdits();
            }
            catch (ArgumentOutOfRangeException)
            {
                StringBuilder message = new StringBuilder();

                message.AppendFormat("Caught {0}\n", typeof(ArgumentOutOfRangeException).ToString());
                message.Append("The configured coercion mode did not coerce the Set Value to a value within the knob's range.\n\n");
                message.AppendFormat("Set Value: {0}\n{1}", setValueNumericEdit.Value, sampleKnob.Range.ToString());
                MessageBox.Show(message.ToString(), "Exception Caught");

                coercedValueNumericEdit.Value = double.NaN;
                previousValueNumericEdit.Value = double.NaN;
                nextValueNumericEdit.Value = double.NaN;
            }
        }

        private void outOfRangeModeComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            sampleKnob.OutOfRangeMode = (NumericOutOfRangeMode)Enum.Parse(typeof(NumericOutOfRangeMode), outOfRangeModeComboBox.SelectedItem.ToString());
        }

        private void SetCoercedValueNumericEdits()
        {
            NumericCoercionModeArgs coercionModeArgs = new NumericCoercionModeArgs(sampleKnob.Value);
            coercedValueNumericEdit.Value = sampleKnob.Value;
            previousValueNumericEdit.Value = sampleKnob.CoercionMode.GetPreviousValue((INumericControl)sampleKnob, coercionModeArgs);
            nextValueNumericEdit.Value = sampleKnob.CoercionMode.GetNextValue((INumericControl)sampleKnob, coercionModeArgs);
        }

        private void intervalNumericEdit_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            if (e.NewValue == 0)
            {
                MessageBox.Show("You cannot set CoercionInterval to 0.", "Error");
                e.Cancel = true;
            }
        }
	}
}
