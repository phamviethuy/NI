using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.SimpleNumericEdit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private NationalInstruments.UI.WindowsForms.NumericEdit knobNumericEdit;
        private NationalInstruments.UI.WindowsForms.Knob sampleKnob;
        private System.Windows.Forms.Label helpLabel;
        private System.Windows.Forms.GroupBox numericEditGroupBox;
        private System.Windows.Forms.GroupBox interactionModesGroupBox;
        private System.Windows.Forms.GroupBox CoercionGroupBox;
        private System.Windows.Forms.GroupBox rangeGroupBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit rangeMinimumNumericEdit;
        private System.Windows.Forms.Label rangeMinimumLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit rangeMaximumNumericEdit;
        private System.Windows.Forms.Label rangeMaximumLabel;
        private System.Windows.Forms.Label coercionModeLabel;
        private System.Windows.Forms.ComboBox coercionModeListComboBox;
        private System.Windows.Forms.Label coercionIntervalBaseLabel;
        private System.Windows.Forms.Label coercionIntervalLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit coercionIntervalNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit coercionIntervalBaseNumericEdit;
        private System.Windows.Forms.CheckBox textCheckBox;
        private System.Windows.Forms.CheckBox buttonsCheckBox;
        private System.Windows.Forms.CheckBox arrowKeysCheckBox;
        private System.Windows.Forms.CheckBox knobCheckBox;
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

			// Set the help label text
			helpLabel.Text = "Change the Interaction Modes, the Range, and the Coercion properties of the Numeric Edit by modifying the values on this dialog.";

			// Initialize coercion mode choices
			coercionModeListComboBox.Items.Add(NumericCoercionMode.None.ToString());
			coercionModeListComboBox.Items.Add(NumericCoercionMode.ToInterval.ToString());
			coercionModeListComboBox.SelectedIndex = 0;

			// Initialize NumericEdit range
			knobNumericEdit.Range = new Range(0, 10);
			rangeMinimumNumericEdit.Value = 0;
			rangeMaximumNumericEdit.Value = 10;
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
            this.knobNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.numericEditGroupBox = new System.Windows.Forms.GroupBox();
            this.knobCheckBox = new System.Windows.Forms.CheckBox();
            this.sampleKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.helpLabel = new System.Windows.Forms.Label();
            this.interactionModesGroupBox = new System.Windows.Forms.GroupBox();
            this.arrowKeysCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonsCheckBox = new System.Windows.Forms.CheckBox();
            this.textCheckBox = new System.Windows.Forms.CheckBox();
            this.CoercionGroupBox = new System.Windows.Forms.GroupBox();
            this.coercionModeLabel = new System.Windows.Forms.Label();
            this.coercionModeListComboBox = new System.Windows.Forms.ComboBox();
            this.coercionIntervalBaseLabel = new System.Windows.Forms.Label();
            this.coercionIntervalBaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.coercionIntervalLabel = new System.Windows.Forms.Label();
            this.coercionIntervalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.rangeGroupBox = new System.Windows.Forms.GroupBox();
            this.rangeMaximumNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.rangeMaximumLabel = new System.Windows.Forms.Label();
            this.rangeMinimumNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.rangeMinimumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.knobNumericEdit)).BeginInit();
            this.numericEditGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).BeginInit();
            this.interactionModesGroupBox.SuspendLayout();
            this.CoercionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coercionIntervalBaseNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercionIntervalNumericEdit)).BeginInit();
            this.rangeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeMaximumNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeMinimumNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // knobNumericEdit
            // 
            this.knobNumericEdit.Location = new System.Drawing.Point(16, 184);
            this.knobNumericEdit.Name = "knobNumericEdit";
            this.knobNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.knobNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.knobNumericEdit.TabIndex = 2;
            // 
            // numericEditGroupBox
            // 
            this.numericEditGroupBox.Controls.Add(this.knobCheckBox);
            this.numericEditGroupBox.Controls.Add(this.sampleKnob);
            this.numericEditGroupBox.Controls.Add(this.knobNumericEdit);
            this.numericEditGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.numericEditGroupBox.Location = new System.Drawing.Point(16, 72);
            this.numericEditGroupBox.Name = "numericEditGroupBox";
            this.numericEditGroupBox.Size = new System.Drawing.Size(160, 216);
            this.numericEditGroupBox.TabIndex = 0;
            this.numericEditGroupBox.TabStop = false;
            this.numericEditGroupBox.Text = "Numeric Edit";
            // 
            // knobCheckBox
            // 
            this.knobCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.knobCheckBox.Location = new System.Drawing.Point(16, 160);
            this.knobCheckBox.Name = "knobCheckBox";
            this.knobCheckBox.Size = new System.Drawing.Size(128, 16);
            this.knobCheckBox.TabIndex = 1;
            this.knobCheckBox.Text = "Connect to Knob";
            this.knobCheckBox.CheckedChanged += new System.EventHandler(this.knobButton_CheckedChanged);
            // 
            // sampleKnob
            // 
            this.sampleKnob.Location = new System.Drawing.Point(8, 16);
            this.sampleKnob.Name = "sampleKnob";
            this.sampleKnob.Size = new System.Drawing.Size(144, 144);
            this.sampleKnob.TabIndex = 0;
            // 
            // helpLabel
            // 
            this.helpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLabel.Location = new System.Drawing.Point(16, 16);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(344, 48);
            this.helpLabel.TabIndex = 5;
            // 
            // interactionModesGroupBox
            // 
            this.interactionModesGroupBox.Controls.Add(this.arrowKeysCheckBox);
            this.interactionModesGroupBox.Controls.Add(this.buttonsCheckBox);
            this.interactionModesGroupBox.Controls.Add(this.textCheckBox);
            this.interactionModesGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.interactionModesGroupBox.Location = new System.Drawing.Point(200, 72);
            this.interactionModesGroupBox.Name = "interactionModesGroupBox";
            this.interactionModesGroupBox.Size = new System.Drawing.Size(152, 216);
            this.interactionModesGroupBox.TabIndex = 1;
            this.interactionModesGroupBox.TabStop = false;
            this.interactionModesGroupBox.Text = "Interaction Modes";
            // 
            // arrowKeysCheckBox
            // 
            this.arrowKeysCheckBox.Checked = true;
            this.arrowKeysCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.arrowKeysCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.arrowKeysCheckBox.Location = new System.Drawing.Point(16, 88);
            this.arrowKeysCheckBox.Name = "arrowKeysCheckBox";
            this.arrowKeysCheckBox.Size = new System.Drawing.Size(104, 24);
            this.arrowKeysCheckBox.TabIndex = 2;
            this.arrowKeysCheckBox.Text = "Arrow Keys";
            this.arrowKeysCheckBox.CheckedChanged += new System.EventHandler(this.arrowKeysButton_CheckedChanged);
            // 
            // buttonsCheckBox
            // 
            this.buttonsCheckBox.Checked = true;
            this.buttonsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.buttonsCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonsCheckBox.Location = new System.Drawing.Point(16, 56);
            this.buttonsCheckBox.Name = "buttonsCheckBox";
            this.buttonsCheckBox.Size = new System.Drawing.Size(104, 24);
            this.buttonsCheckBox.TabIndex = 1;
            this.buttonsCheckBox.Text = "Buttons";
            this.buttonsCheckBox.CheckedChanged += new System.EventHandler(this.buttonsButton_CheckedChanged);
            // 
            // textCheckBox
            // 
            this.textCheckBox.Checked = true;
            this.textCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.textCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.textCheckBox.Location = new System.Drawing.Point(16, 24);
            this.textCheckBox.Name = "textCheckBox";
            this.textCheckBox.Size = new System.Drawing.Size(104, 24);
            this.textCheckBox.TabIndex = 0;
            this.textCheckBox.Text = "Text";
            this.textCheckBox.CheckedChanged += new System.EventHandler(this.textButton_CheckedChanged);
            // 
            // CoercionGroupBox
            // 
            this.CoercionGroupBox.Controls.Add(this.coercionModeLabel);
            this.CoercionGroupBox.Controls.Add(this.coercionModeListComboBox);
            this.CoercionGroupBox.Controls.Add(this.coercionIntervalBaseLabel);
            this.CoercionGroupBox.Controls.Add(this.coercionIntervalBaseNumericEdit);
            this.CoercionGroupBox.Controls.Add(this.coercionIntervalLabel);
            this.CoercionGroupBox.Controls.Add(this.coercionIntervalNumericEdit);
            this.CoercionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CoercionGroupBox.Location = new System.Drawing.Point(200, 304);
            this.CoercionGroupBox.Name = "CoercionGroupBox";
            this.CoercionGroupBox.Size = new System.Drawing.Size(152, 176);
            this.CoercionGroupBox.TabIndex = 3;
            this.CoercionGroupBox.TabStop = false;
            this.CoercionGroupBox.Text = "Coercion";
            // 
            // coercionModeLabel
            // 
            this.coercionModeLabel.Location = new System.Drawing.Point(16, 24);
            this.coercionModeLabel.Name = "coercionModeLabel";
            this.coercionModeLabel.Size = new System.Drawing.Size(100, 16);
            this.coercionModeLabel.TabIndex = 1;
            this.coercionModeLabel.Text = "Coercion Mode:";
            // 
            // coercionModeListComboBox
            // 
            this.coercionModeListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coercionModeListComboBox.Location = new System.Drawing.Point(16, 40);
            this.coercionModeListComboBox.Name = "coercionModeListComboBox";
            this.coercionModeListComboBox.Size = new System.Drawing.Size(121, 21);
            this.coercionModeListComboBox.TabIndex = 0;
            this.coercionModeListComboBox.SelectedIndexChanged += new System.EventHandler(this.coercionModeList_SelectedIndexChanged);
            // 
            // coercionIntervalBaseLabel
            // 
            this.coercionIntervalBaseLabel.Location = new System.Drawing.Point(16, 120);
            this.coercionIntervalBaseLabel.Name = "coercionIntervalBaseLabel";
            this.coercionIntervalBaseLabel.Size = new System.Drawing.Size(128, 16);
            this.coercionIntervalBaseLabel.TabIndex = 7;
            this.coercionIntervalBaseLabel.Text = "Coercion Interval Base:";
            // 
            // coercionIntervalBaseNumericEdit
            // 
            this.coercionIntervalBaseNumericEdit.Location = new System.Drawing.Point(16, 136);
            this.coercionIntervalBaseNumericEdit.Name = "coercionIntervalBaseNumericEdit";
            this.coercionIntervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.coercionIntervalBaseNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.coercionIntervalBaseNumericEdit.TabIndex = 2;
            this.coercionIntervalBaseNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.coercionIntervalBaseNumeric_AfterChangeValue);
            this.coercionIntervalBaseNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.coercionIntervalBaseNumeric_BeforeChangeValue);
            // 
            // coercionIntervalLabel
            // 
            this.coercionIntervalLabel.Location = new System.Drawing.Point(16, 72);
            this.coercionIntervalLabel.Name = "coercionIntervalLabel";
            this.coercionIntervalLabel.Size = new System.Drawing.Size(100, 16);
            this.coercionIntervalLabel.TabIndex = 5;
            this.coercionIntervalLabel.Text = "Coercion Interval:";
            // 
            // coercionIntervalNumericEdit
            // 
            this.coercionIntervalNumericEdit.Location = new System.Drawing.Point(16, 88);
            this.coercionIntervalNumericEdit.Name = "coercionIntervalNumericEdit";
            this.coercionIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.coercionIntervalNumericEdit.Range = new NationalInstruments.UI.Range(0, double.PositiveInfinity);
            this.coercionIntervalNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.coercionIntervalNumericEdit.TabIndex = 1;
            this.coercionIntervalNumericEdit.Value = 1;
            this.coercionIntervalNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.coercionIntervalNumeric_AfterChangeValue);
            this.coercionIntervalNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.coercionIntervalNumeric_BeforeChangeValue);
            // 
            // rangeGroupBox
            // 
            this.rangeGroupBox.Controls.Add(this.rangeMaximumNumericEdit);
            this.rangeGroupBox.Controls.Add(this.rangeMaximumLabel);
            this.rangeGroupBox.Controls.Add(this.rangeMinimumNumericEdit);
            this.rangeGroupBox.Controls.Add(this.rangeMinimumLabel);
            this.rangeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rangeGroupBox.Location = new System.Drawing.Point(16, 304);
            this.rangeGroupBox.Name = "rangeGroupBox";
            this.rangeGroupBox.Size = new System.Drawing.Size(160, 176);
            this.rangeGroupBox.TabIndex = 2;
            this.rangeGroupBox.TabStop = false;
            this.rangeGroupBox.Text = "Range";
            // 
            // rangeMaximumNumericEdit
            // 
            this.rangeMaximumNumericEdit.Location = new System.Drawing.Point(16, 96);
            this.rangeMaximumNumericEdit.Name = "rangeMaximumNumericEdit";
            this.rangeMaximumNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.rangeMaximumNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.rangeMaximumNumericEdit.TabIndex = 1;
            this.rangeMaximumNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.rangeMaximumNumeric_AfterChangeValue);
            this.rangeMaximumNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.rangeMaximumNumeric_BeforeChangeValue);
            // 
            // rangeMaximumLabel
            // 
            this.rangeMaximumLabel.Location = new System.Drawing.Point(16, 80);
            this.rangeMaximumLabel.Name = "rangeMaximumLabel";
            this.rangeMaximumLabel.Size = new System.Drawing.Size(100, 16);
            this.rangeMaximumLabel.TabIndex = 2;
            this.rangeMaximumLabel.Text = "Maximum:";
            // 
            // rangeMinimumNumericEdit
            // 
            this.rangeMinimumNumericEdit.Location = new System.Drawing.Point(16, 40);
            this.rangeMinimumNumericEdit.Name = "rangeMinimumNumericEdit";
            this.rangeMinimumNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.rangeMinimumNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.rangeMinimumNumericEdit.TabIndex = 0;
            this.rangeMinimumNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.rangeMinimumNumeric_AfterChangeValue);
            this.rangeMinimumNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.rangeMinimumNumeric_BeforeChangeValue);
            // 
            // rangeMinimumLabel
            // 
            this.rangeMinimumLabel.Location = new System.Drawing.Point(16, 24);
            this.rangeMinimumLabel.Name = "rangeMinimumLabel";
            this.rangeMinimumLabel.Size = new System.Drawing.Size(100, 16);
            this.rangeMinimumLabel.TabIndex = 0;
            this.rangeMinimumLabel.Text = "Minimum:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(368, 494);
            this.Controls.Add(this.rangeGroupBox);
            this.Controls.Add(this.CoercionGroupBox);
            this.Controls.Add(this.interactionModesGroupBox);
            this.Controls.Add(this.numericEditGroupBox);
            this.Controls.Add(this.helpLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Simple Numeric Edit";
            ((System.ComponentModel.ISupportInitialize)(this.knobNumericEdit)).EndInit();
            this.numericEditGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).EndInit();
            this.interactionModesGroupBox.ResumeLayout(false);
            this.CoercionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coercionIntervalBaseNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coercionIntervalNumericEdit)).EndInit();
            this.rangeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rangeMaximumNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rangeMinimumNumericEdit)).EndInit();
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

		private void textButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if(textCheckBox.Checked)
			{
				knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode | NumericEditInteractionModes.Text;
			}
			else
			{
				knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode ^ NumericEditInteractionModes.Text;
			}
		}

		private void buttonsButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if(buttonsCheckBox.Checked)
			{
				knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode | NumericEditInteractionModes.Buttons;
			}
			else
			{
				knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode ^ NumericEditInteractionModes.Buttons;
			}
		}

		private void arrowKeysButton_CheckedChanged(object sender, System.EventArgs e)
		{
			if(arrowKeysCheckBox.Checked)
			{
				knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode | NumericEditInteractionModes.ArrowKeys;
			}
			else
			{
				knobNumericEdit.InteractionMode = knobNumericEdit.InteractionMode ^ NumericEditInteractionModes.ArrowKeys;
			}
		}

		private void rangeMinimumNumeric_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
		{
			knobNumericEdit.Range = new Range(rangeMinimumNumericEdit.Value, knobNumericEdit.Range.Maximum);
		}

		private void rangeMaximumNumeric_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
		{
			knobNumericEdit.Range = new Range(knobNumericEdit.Range.Minimum, rangeMaximumNumericEdit.Value);
		}

		private void rangeMinimumNumeric_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
		{
			if(Double.IsNaN(e.NewValue) || e.NewValue >= knobNumericEdit.Range.Maximum)
			{
				e.Cancel = true;
			}
		}

		private void rangeMaximumNumeric_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
		{
			if(Double.IsNaN(e.NewValue) || e.NewValue <= knobNumericEdit.Range.Minimum)
			{
				e.Cancel = true;
			}
		}

		private void coercionModeList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			NumericCoercionMode coercionMode = EnumObject.Parse(typeof(NumericCoercionMode), coercionModeListComboBox.SelectedItem as String) as NumericCoercionMode;
			if (coercionMode != null)
			{
				knobNumericEdit.CoercionMode = coercionMode;
			}
		}

		private void coercionIntervalNumeric_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
		{
			knobNumericEdit.CoercionInterval = coercionIntervalNumericEdit.Value;
		}

		private void coercionIntervalNumeric_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
		{
			if(Double.IsNaN(e.NewValue) || Double.IsInfinity(e.NewValue) || e.NewValue == 0)
			{
				e.Cancel = true;
			}
		}

		private void coercionIntervalBaseNumeric_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
		{
			knobNumericEdit.CoercionIntervalBase = coercionIntervalBaseNumericEdit.Value;
		}

		private void coercionIntervalBaseNumeric_BeforeChangeValue(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
		{
			if(Double.IsNaN(e.NewValue) || Double.IsInfinity(e.NewValue))
			{
				e.Cancel = true;
			}
		}

        private void knobButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if(knobCheckBox.Checked)
            {
                knobNumericEdit.Source = sampleKnob;
            }
            else
            {
                knobNumericEdit.Source = null;
            }
        }
	}
}
