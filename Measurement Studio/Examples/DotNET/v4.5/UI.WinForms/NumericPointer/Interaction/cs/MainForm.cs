using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Interaction
{
	public class MainForm : System.Windows.Forms.Form
	{
        private RadialNumericPointer[] radialNumericPointers;
        private LinearNumericPointer[] linearNumericPointers;
        private NationalInstruments.UI.WindowsForms.Gauge sampleGauge;
        private NationalInstruments.UI.WindowsForms.Knob sampleKnob;
        private NationalInstruments.UI.WindowsForms.Meter sampleMeter;
        private NationalInstruments.UI.WindowsForms.Slide sampleSlide;
        private NationalInstruments.UI.WindowsForms.Tank sampleTank;
        private NationalInstruments.UI.WindowsForms.Thermometer sampleThermometer;
        private System.Windows.Forms.GroupBox radialSettingsGroupBox;
        private System.Windows.Forms.GroupBox radialGroupBox;
        private System.Windows.Forms.GroupBox linearGroupBox;
        private System.Windows.Forms.GroupBox linearSettingGroupBox;
        private System.Windows.Forms.Label radialValueLabel;
        private System.Windows.Forms.CheckedListBox radialInteractionModeCheckedListBox;
        private System.Windows.Forms.ComboBox radialCoercionModeComboBox;
        private NationalInstruments.UI.WindowsForms.NumericEdit radialCoercionIntervalBaseNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit radialCoercionIntervalNumericEdit;
        private System.Windows.Forms.Button radialMovePreviousButton;
        private System.Windows.Forms.Button radialMoveNextButton;
        private System.Windows.Forms.Label radialInteractionModesLabel;
        private System.Windows.Forms.Label radialCoercionModeLabel;
        private System.Windows.Forms.Label radialCoercionIntervalLabel;
        private System.Windows.Forms.Label radialCoercionIntervalBaseLabel;
        private System.Windows.Forms.Panel radialCoercionIntervalPanel;
        private System.Windows.Forms.Panel radialCoercionIntervalBasePanel;
        private NationalInstruments.UI.WindowsForms.NumericEdit radialValueNumericEdit;
        private System.Windows.Forms.Label linearInteractionModesLabel;
        private System.Windows.Forms.ComboBox linearCoercionModeComboBox;
        private System.Windows.Forms.Label linearCoercionModeLabel;
        private System.Windows.Forms.CheckedListBox linearInteractionModeCheckedListBox;
        private System.Windows.Forms.Panel linearCoercionIntervalPanel;
        private System.Windows.Forms.Label linearCoercionIntervalLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit linearCoercionIntervalNumericEdit;
        private System.Windows.Forms.Panel linearCoercionIntervalBasePanel;
        private NationalInstruments.UI.WindowsForms.NumericEdit linearCoercionIntervalBaseNumericEdit;
        private System.Windows.Forms.Label linearCoercionIntervalBaseLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit linearValueNumericEdit;
        private System.Windows.Forms.Label linearValueLabel;
        private System.Windows.Forms.Button linearMovePreviousButton;
        private System.Windows.Forms.Button linearMoveNextButton;
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

            radialNumericPointers = new RadialNumericPointer[3] { sampleGauge, sampleKnob, sampleMeter };
            linearNumericPointers = new LinearNumericPointer[3] { sampleSlide, sampleTank, sampleThermometer };

            RadialNumericPointerInteractionModes defaultRadialInteractionMode = RadialNumericPointerInteractionModes.DragPointer | RadialNumericPointerInteractionModes.SnapPointer;
            LinearNumericPointerInteractionModes defaultLinearInteractionMode = LinearNumericPointerInteractionModes.DragPointer | LinearNumericPointerInteractionModes.SnapPointer;
            NumericCoercionMode defaultCoercionMode = NumericCoercionMode.None;
            double defaultCoercionIntervalBase = 0;
            double defaultCoercionInterval = 2;

            foreach (RadialNumericPointer numericPointer in radialNumericPointers)
            {
                numericPointer.InteractionMode = defaultRadialInteractionMode;
                numericPointer.CoercionMode = defaultCoercionMode;
                numericPointer.CoercionIntervalBase = defaultCoercionIntervalBase;
                numericPointer.CoercionInterval = defaultCoercionInterval;
                numericPointer.Enter += new EventHandler(OnRadialNumericPointerEnter);
            }

            foreach (LinearNumericPointer numericPointer in linearNumericPointers)
            {
                numericPointer.InteractionMode = defaultLinearInteractionMode;
                numericPointer.CoercionMode = defaultCoercionMode;
                numericPointer.CoercionIntervalBase = defaultCoercionIntervalBase;
                numericPointer.CoercionInterval = defaultCoercionInterval;
                numericPointer.Enter += new EventHandler(OnLinearNumericPointerEnter);
            }

            radialInteractionModeCheckedListBox.Items.AddRange(Enum.GetNames(typeof(RadialNumericPointerInteractionModes)));
            radialInteractionModeCheckedListBox.Items.Remove(Enum.GetName(typeof(RadialNumericPointerInteractionModes), RadialNumericPointerInteractionModes.Indicator));
            for (int i = 0; i < radialInteractionModeCheckedListBox.Items.Count; ++i)
            {
                RadialNumericPointerInteractionModes mode = (RadialNumericPointerInteractionModes) Enum.Parse(typeof(RadialNumericPointerInteractionModes), radialInteractionModeCheckedListBox.Items[i] as string);
                if ((mode & defaultRadialInteractionMode) == mode)
                {
                    radialInteractionModeCheckedListBox.SetItemChecked(i, true);
                }
                else
                {
                    radialInteractionModeCheckedListBox.SetItemChecked(i, false);
                }
            }

            linearInteractionModeCheckedListBox.Items.AddRange(Enum.GetNames(typeof(LinearNumericPointerInteractionModes)));
            linearInteractionModeCheckedListBox.Items.Remove(Enum.GetName(typeof(LinearNumericPointerInteractionModes), LinearNumericPointerInteractionModes.Indicator));
            for (int i = 0; i < linearInteractionModeCheckedListBox.Items.Count; ++i)
            {
                LinearNumericPointerInteractionModes mode = (LinearNumericPointerInteractionModes) Enum.Parse(typeof(LinearNumericPointerInteractionModes), linearInteractionModeCheckedListBox.Items[i] as string);
                if ((mode & defaultLinearInteractionMode) == mode)
                {
                    linearInteractionModeCheckedListBox.SetItemChecked(i, true);
                }
                else
                {
                    linearInteractionModeCheckedListBox.SetItemChecked(i, false);
                }
            }

            string[] coercionModes = EnumObject.GetNames(typeof(NumericCoercionMode));           
            radialCoercionModeComboBox.Sorted = true;
            radialCoercionModeComboBox.Items.AddRange(coercionModes);
            radialCoercionModeComboBox.SelectedItem = defaultCoercionMode.Name;

            linearCoercionModeComboBox.Sorted = true;
            linearCoercionModeComboBox.Items.AddRange(coercionModes);
            linearCoercionModeComboBox.SelectedItem = defaultCoercionMode.Name;

            radialCoercionIntervalBaseNumericEdit.Value = defaultCoercionIntervalBase;
            radialCoercionIntervalNumericEdit.Value = defaultCoercionInterval;

            UpdateRadialCoercionModePanels();

            linearCoercionIntervalBaseNumericEdit.Value = defaultCoercionIntervalBase;
            linearCoercionIntervalNumericEdit.Value = defaultCoercionInterval;

            UpdateLinearCoercionModePanels();
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
                    foreach (RadialNumericPointer numericPointer in radialNumericPointers)
                    {
                        numericPointer.Enter -= new EventHandler(OnRadialNumericPointerEnter);
                    }

                    foreach (LinearNumericPointer numericPointer in linearNumericPointers)
                    {
                        numericPointer.Enter -= new EventHandler(OnLinearNumericPointerEnter);
                    }

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
            this.sampleGauge = new NationalInstruments.UI.WindowsForms.Gauge();
            this.sampleKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.sampleMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.sampleSlide = new NationalInstruments.UI.WindowsForms.Slide();
            this.sampleTank = new NationalInstruments.UI.WindowsForms.Tank();
            this.sampleThermometer = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.radialInteractionModeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.radialCoercionModeComboBox = new System.Windows.Forms.ComboBox();
            this.radialCoercionIntervalBaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.radialCoercionIntervalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.radialMovePreviousButton = new System.Windows.Forms.Button();
            this.radialMoveNextButton = new System.Windows.Forms.Button();
            this.radialInteractionModesLabel = new System.Windows.Forms.Label();
            this.radialCoercionModeLabel = new System.Windows.Forms.Label();
            this.radialCoercionIntervalLabel = new System.Windows.Forms.Label();
            this.radialCoercionIntervalBaseLabel = new System.Windows.Forms.Label();
            this.radialCoercionIntervalPanel = new System.Windows.Forms.Panel();
            this.radialCoercionIntervalBasePanel = new System.Windows.Forms.Panel();
            this.radialValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.radialValueLabel = new System.Windows.Forms.Label();
            this.radialSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.radialGroupBox = new System.Windows.Forms.GroupBox();
            this.linearGroupBox = new System.Windows.Forms.GroupBox();
            this.linearSettingGroupBox = new System.Windows.Forms.GroupBox();
            this.linearInteractionModesLabel = new System.Windows.Forms.Label();
            this.linearCoercionModeComboBox = new System.Windows.Forms.ComboBox();
            this.linearCoercionModeLabel = new System.Windows.Forms.Label();
            this.linearInteractionModeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.linearCoercionIntervalPanel = new System.Windows.Forms.Panel();
            this.linearCoercionIntervalLabel = new System.Windows.Forms.Label();
            this.linearCoercionIntervalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.linearCoercionIntervalBasePanel = new System.Windows.Forms.Panel();
            this.linearCoercionIntervalBaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.linearCoercionIntervalBaseLabel = new System.Windows.Forms.Label();
            this.linearValueNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.linearValueLabel = new System.Windows.Forms.Label();
            this.linearMovePreviousButton = new System.Windows.Forms.Button();
            this.linearMoveNextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sampleGauge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleMeter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleThermometer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialCoercionIntervalBaseNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialCoercionIntervalNumericEdit)).BeginInit();
            this.radialCoercionIntervalPanel.SuspendLayout();
            this.radialCoercionIntervalBasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialValueNumericEdit)).BeginInit();
            this.radialSettingsGroupBox.SuspendLayout();
            this.radialGroupBox.SuspendLayout();
            this.linearGroupBox.SuspendLayout();
            this.linearSettingGroupBox.SuspendLayout();
            this.linearCoercionIntervalPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linearCoercionIntervalNumericEdit)).BeginInit();
            this.linearCoercionIntervalBasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linearCoercionIntervalBaseNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearValueNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleGauge
            // 
            this.sampleGauge.Border = NationalInstruments.UI.Border.Etched;
            this.sampleGauge.CanShowFocus = true;
            this.sampleGauge.Caption = "Gauge";
            this.sampleGauge.Location = new System.Drawing.Point(8, 18);
            this.sampleGauge.Name = "sampleGauge";
            this.sampleGauge.Range = new NationalInstruments.UI.Range(0, 100);
            this.sampleGauge.ScaleType = NationalInstruments.UI.ScaleType.Logarithmic;
            this.sampleGauge.Size = new System.Drawing.Size(146, 197);
            this.sampleGauge.TabIndex = 0;
            // 
            // sampleKnob
            // 
            this.sampleKnob.Border = NationalInstruments.UI.Border.Etched;
            this.sampleKnob.CanShowFocus = true;
            this.sampleKnob.Caption = "Knob";
            this.sampleKnob.Location = new System.Drawing.Point(160, 18);
            this.sampleKnob.Name = "sampleKnob";
            this.sampleKnob.Size = new System.Drawing.Size(173, 197);
            this.sampleKnob.TabIndex = 1;
            // 
            // sampleMeter
            // 
            this.sampleMeter.Border = NationalInstruments.UI.Border.Etched;
            this.sampleMeter.CanShowFocus = true;
            this.sampleMeter.Caption = "Meter";
            this.sampleMeter.Location = new System.Drawing.Point(8, 220);
            this.sampleMeter.Name = "sampleMeter";
            this.sampleMeter.Size = new System.Drawing.Size(324, 156);
            this.sampleMeter.TabIndex = 2;
            // 
            // sampleSlide
            // 
            this.sampleSlide.Border = NationalInstruments.UI.Border.Etched;
            this.sampleSlide.CanShowFocus = true;
            this.sampleSlide.Caption = "Slide";
            scaleCustomDivision1.LabelForeColor = System.Drawing.SystemColors.ControlDarkDark;
            scaleCustomDivision1.Text = "Two";
            scaleCustomDivision1.TickColor = System.Drawing.SystemColors.ControlDarkDark;
            scaleCustomDivision1.Value = 2;
            scaleCustomDivision2.DisplayStyle = NationalInstruments.UI.CustomDivisionDisplayStyle.ShowValue;
            scaleCustomDivision2.LabelForeColor = System.Drawing.SystemColors.ControlDarkDark;
            scaleCustomDivision2.TickColor = System.Drawing.SystemColors.ControlDarkDark;
            scaleCustomDivision2.Value = 6.5;
            this.sampleSlide.CustomDivisions.AddRange(new NationalInstruments.UI.ScaleCustomDivision[] {
            scaleCustomDivision1,
            scaleCustomDivision2});
            this.sampleSlide.Location = new System.Drawing.Point(8, 18);
            this.sampleSlide.Name = "sampleSlide";
            this.sampleSlide.Size = new System.Drawing.Size(74, 358);
            this.sampleSlide.TabIndex = 3;
            // 
            // sampleTank
            // 
            this.sampleTank.Border = NationalInstruments.UI.Border.Etched;
            this.sampleTank.CanShowFocus = true;
            this.sampleTank.Caption = "Tank";
            this.sampleTank.Location = new System.Drawing.Point(90, 18);
            this.sampleTank.Name = "sampleTank";
            this.sampleTank.Size = new System.Drawing.Size(110, 358);
            this.sampleTank.TabIndex = 4;
            // 
            // sampleThermometer
            // 
            this.sampleThermometer.Border = NationalInstruments.UI.Border.Etched;
            this.sampleThermometer.CanShowFocus = true;
            this.sampleThermometer.Caption = "Thermometer";
            this.sampleThermometer.Location = new System.Drawing.Point(207, 18);
            this.sampleThermometer.Name = "sampleThermometer";
            this.sampleThermometer.Range = new NationalInstruments.UI.Range(0, 10);
            this.sampleThermometer.Size = new System.Drawing.Size(83, 358);
            this.sampleThermometer.TabIndex = 5;
            // 
            // radialInteractionModeCheckedListBox
            // 
            this.radialInteractionModeCheckedListBox.CheckOnClick = true;
            this.radialInteractionModeCheckedListBox.Location = new System.Drawing.Point(23, 95);
            this.radialInteractionModeCheckedListBox.Name = "radialInteractionModeCheckedListBox";
            this.radialInteractionModeCheckedListBox.Size = new System.Drawing.Size(113, 79);
            this.radialInteractionModeCheckedListBox.TabIndex = 8;
            this.radialInteractionModeCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnRadialInteractionModeItemCheck);
            // 
            // radialCoercionModeComboBox
            // 
            this.radialCoercionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.radialCoercionModeComboBox.Location = new System.Drawing.Point(173, 45);
            this.radialCoercionModeComboBox.Name = "radialCoercionModeComboBox";
            this.radialCoercionModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.radialCoercionModeComboBox.TabIndex = 9;
            this.radialCoercionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnRadialCoercionModeSelectedIndexChanged);
            // 
            // radialCoercionIntervalBaseNumericEdit
            // 
            this.radialCoercionIntervalBaseNumericEdit.Location = new System.Drawing.Point(11, 25);
            this.radialCoercionIntervalBaseNumericEdit.Name = "radialCoercionIntervalBaseNumericEdit";
            this.radialCoercionIntervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.radialCoercionIntervalBaseNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.radialCoercionIntervalBaseNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.radialCoercionIntervalBaseNumericEdit.TabIndex = 0;
            this.radialCoercionIntervalBaseNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnRadialCoercionIntervalBaseAfterChangeValue);
            // 
            // radialCoercionIntervalNumericEdit
            // 
            this.radialCoercionIntervalNumericEdit.Location = new System.Drawing.Point(10, 25);
            this.radialCoercionIntervalNumericEdit.Name = "radialCoercionIntervalNumericEdit";
            this.radialCoercionIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.radialCoercionIntervalNumericEdit.Range = new NationalInstruments.UI.Range(0.001, 10);
            this.radialCoercionIntervalNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.radialCoercionIntervalNumericEdit.TabIndex = 0;
            this.radialCoercionIntervalNumericEdit.Value = 0.001;
            this.radialCoercionIntervalNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnRadialCoercionIntervalAfterChangeValue);
            // 
            // radialMovePreviousButton
            // 
            this.radialMovePreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radialMovePreviousButton.Location = new System.Drawing.Point(23, 43);
            this.radialMovePreviousButton.Name = "radialMovePreviousButton";
            this.radialMovePreviousButton.Size = new System.Drawing.Size(26, 21);
            this.radialMovePreviousButton.TabIndex = 6;
            this.radialMovePreviousButton.Text = "<";
            this.radialMovePreviousButton.Click += new System.EventHandler(this.OnRadialMovePreviousClick);
            // 
            // radialMoveNextButton
            // 
            this.radialMoveNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radialMoveNextButton.Location = new System.Drawing.Point(111, 45);
            this.radialMoveNextButton.Name = "radialMoveNextButton";
            this.radialMoveNextButton.Size = new System.Drawing.Size(26, 21);
            this.radialMoveNextButton.TabIndex = 7;
            this.radialMoveNextButton.Text = ">";
            this.radialMoveNextButton.Click += new System.EventHandler(this.OnRadialMoveNextClick);
            // 
            // radialInteractionModesLabel
            // 
            this.radialInteractionModesLabel.AutoSize = true;
            this.radialInteractionModesLabel.Location = new System.Drawing.Point(21, 76);
            this.radialInteractionModesLabel.Name = "radialInteractionModesLabel";
            this.radialInteractionModesLabel.Size = new System.Drawing.Size(95, 13);
            this.radialInteractionModesLabel.TabIndex = 13;
            this.radialInteractionModesLabel.Text = "Interaction Modes:";
            // 
            // radialCoercionModeLabel
            // 
            this.radialCoercionModeLabel.AutoSize = true;
            this.radialCoercionModeLabel.Location = new System.Drawing.Point(171, 26);
            this.radialCoercionModeLabel.Name = "radialCoercionModeLabel";
            this.radialCoercionModeLabel.Size = new System.Drawing.Size(82, 13);
            this.radialCoercionModeLabel.TabIndex = 12;
            this.radialCoercionModeLabel.Text = "Coercion Mode:";
            // 
            // radialCoercionIntervalLabel
            // 
            this.radialCoercionIntervalLabel.AutoSize = true;
            this.radialCoercionIntervalLabel.Location = new System.Drawing.Point(8, 6);
            this.radialCoercionIntervalLabel.Name = "radialCoercionIntervalLabel";
            this.radialCoercionIntervalLabel.Size = new System.Drawing.Size(90, 13);
            this.radialCoercionIntervalLabel.TabIndex = 1;
            this.radialCoercionIntervalLabel.Text = "Coercion Interval:";
            // 
            // radialCoercionIntervalBaseLabel
            // 
            this.radialCoercionIntervalBaseLabel.AutoSize = true;
            this.radialCoercionIntervalBaseLabel.Location = new System.Drawing.Point(8, 6);
            this.radialCoercionIntervalBaseLabel.Name = "radialCoercionIntervalBaseLabel";
            this.radialCoercionIntervalBaseLabel.Size = new System.Drawing.Size(117, 13);
            this.radialCoercionIntervalBaseLabel.TabIndex = 1;
            this.radialCoercionIntervalBaseLabel.Text = "Coercion Interval Base:";
            // 
            // radialCoercionIntervalPanel
            // 
            this.radialCoercionIntervalPanel.Controls.Add(this.radialCoercionIntervalLabel);
            this.radialCoercionIntervalPanel.Controls.Add(this.radialCoercionIntervalNumericEdit);
            this.radialCoercionIntervalPanel.Location = new System.Drawing.Point(164, 70);
            this.radialCoercionIntervalPanel.Name = "radialCoercionIntervalPanel";
            this.radialCoercionIntervalPanel.Size = new System.Drawing.Size(137, 52);
            this.radialCoercionIntervalPanel.TabIndex = 10;
            // 
            // radialCoercionIntervalBasePanel
            // 
            this.radialCoercionIntervalBasePanel.Controls.Add(this.radialCoercionIntervalBaseNumericEdit);
            this.radialCoercionIntervalBasePanel.Controls.Add(this.radialCoercionIntervalBaseLabel);
            this.radialCoercionIntervalBasePanel.Location = new System.Drawing.Point(163, 128);
            this.radialCoercionIntervalBasePanel.Name = "radialCoercionIntervalBasePanel";
            this.radialCoercionIntervalBasePanel.Size = new System.Drawing.Size(140, 52);
            this.radialCoercionIntervalBasePanel.TabIndex = 11;
            // 
            // radialValueNumericEdit
            // 
            this.radialValueNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.radialValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.radialValueNumericEdit.Location = new System.Drawing.Point(52, 45);
            this.radialValueNumericEdit.Name = "radialValueNumericEdit";
            this.radialValueNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.radialValueNumericEdit.TabIndex = 14;
            // 
            // radialValueLabel
            // 
            this.radialValueLabel.AutoSize = true;
            this.radialValueLabel.Location = new System.Drawing.Point(52, 26);
            this.radialValueLabel.Name = "radialValueLabel";
            this.radialValueLabel.Size = new System.Drawing.Size(37, 13);
            this.radialValueLabel.TabIndex = 15;
            this.radialValueLabel.Text = "Value:";
            // 
            // radialSettingsGroupBox
            // 
            this.radialSettingsGroupBox.Controls.Add(this.radialInteractionModesLabel);
            this.radialSettingsGroupBox.Controls.Add(this.radialCoercionModeComboBox);
            this.radialSettingsGroupBox.Controls.Add(this.radialCoercionModeLabel);
            this.radialSettingsGroupBox.Controls.Add(this.radialInteractionModeCheckedListBox);
            this.radialSettingsGroupBox.Controls.Add(this.radialCoercionIntervalPanel);
            this.radialSettingsGroupBox.Controls.Add(this.radialCoercionIntervalBasePanel);
            this.radialSettingsGroupBox.Controls.Add(this.radialValueNumericEdit);
            this.radialSettingsGroupBox.Controls.Add(this.radialValueLabel);
            this.radialSettingsGroupBox.Controls.Add(this.radialMovePreviousButton);
            this.radialSettingsGroupBox.Controls.Add(this.radialMoveNextButton);
            this.radialSettingsGroupBox.Location = new System.Drawing.Point(8, 386);
            this.radialSettingsGroupBox.Name = "radialSettingsGroupBox";
            this.radialSettingsGroupBox.Size = new System.Drawing.Size(325, 198);
            this.radialSettingsGroupBox.TabIndex = 16;
            this.radialSettingsGroupBox.TabStop = false;
            this.radialSettingsGroupBox.Text = "Settings";
            // 
            // radialGroupBox
            // 
            this.radialGroupBox.Controls.Add(this.sampleMeter);
            this.radialGroupBox.Controls.Add(this.sampleKnob);
            this.radialGroupBox.Controls.Add(this.sampleGauge);
            this.radialGroupBox.Controls.Add(this.radialSettingsGroupBox);
            this.radialGroupBox.Location = new System.Drawing.Point(8, 9);
            this.radialGroupBox.Name = "radialGroupBox";
            this.radialGroupBox.Size = new System.Drawing.Size(341, 594);
            this.radialGroupBox.TabIndex = 17;
            this.radialGroupBox.TabStop = false;
            this.radialGroupBox.Text = "Radial";
            // 
            // linearGroupBox
            // 
            this.linearGroupBox.Controls.Add(this.linearSettingGroupBox);
            this.linearGroupBox.Controls.Add(this.sampleSlide);
            this.linearGroupBox.Controls.Add(this.sampleThermometer);
            this.linearGroupBox.Controls.Add(this.sampleTank);
            this.linearGroupBox.Location = new System.Drawing.Point(361, 9);
            this.linearGroupBox.Name = "linearGroupBox";
            this.linearGroupBox.Size = new System.Drawing.Size(299, 595);
            this.linearGroupBox.TabIndex = 18;
            this.linearGroupBox.TabStop = false;
            this.linearGroupBox.Text = "Linear";
            // 
            // linearSettingGroupBox
            // 
            this.linearSettingGroupBox.Controls.Add(this.linearInteractionModesLabel);
            this.linearSettingGroupBox.Controls.Add(this.linearCoercionModeComboBox);
            this.linearSettingGroupBox.Controls.Add(this.linearCoercionModeLabel);
            this.linearSettingGroupBox.Controls.Add(this.linearInteractionModeCheckedListBox);
            this.linearSettingGroupBox.Controls.Add(this.linearCoercionIntervalPanel);
            this.linearSettingGroupBox.Controls.Add(this.linearCoercionIntervalBasePanel);
            this.linearSettingGroupBox.Controls.Add(this.linearValueNumericEdit);
            this.linearSettingGroupBox.Controls.Add(this.linearValueLabel);
            this.linearSettingGroupBox.Controls.Add(this.linearMovePreviousButton);
            this.linearSettingGroupBox.Controls.Add(this.linearMoveNextButton);
            this.linearSettingGroupBox.Location = new System.Drawing.Point(9, 386);
            this.linearSettingGroupBox.Name = "linearSettingGroupBox";
            this.linearSettingGroupBox.Size = new System.Drawing.Size(281, 201);
            this.linearSettingGroupBox.TabIndex = 6;
            this.linearSettingGroupBox.TabStop = false;
            this.linearSettingGroupBox.Text = "Settings";
            // 
            // linearInteractionModesLabel
            // 
            this.linearInteractionModesLabel.AutoSize = true;
            this.linearInteractionModesLabel.Location = new System.Drawing.Point(9, 77);
            this.linearInteractionModesLabel.Name = "linearInteractionModesLabel";
            this.linearInteractionModesLabel.Size = new System.Drawing.Size(95, 13);
            this.linearInteractionModesLabel.TabIndex = 23;
            this.linearInteractionModesLabel.Text = "Interaction Modes:";
            // 
            // linearCoercionModeComboBox
            // 
            this.linearCoercionModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.linearCoercionModeComboBox.Location = new System.Drawing.Point(146, 44);
            this.linearCoercionModeComboBox.Name = "linearCoercionModeComboBox";
            this.linearCoercionModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.linearCoercionModeComboBox.TabIndex = 19;
            this.linearCoercionModeComboBox.SelectedIndexChanged += new System.EventHandler(this.OnLinearCoercionModeSelectedIndexChanged);
            // 
            // linearCoercionModeLabel
            // 
            this.linearCoercionModeLabel.AutoSize = true;
            this.linearCoercionModeLabel.Location = new System.Drawing.Point(144, 25);
            this.linearCoercionModeLabel.Name = "linearCoercionModeLabel";
            this.linearCoercionModeLabel.Size = new System.Drawing.Size(82, 13);
            this.linearCoercionModeLabel.TabIndex = 22;
            this.linearCoercionModeLabel.Text = "Coercion Mode:";
            // 
            // linearInteractionModeCheckedListBox
            // 
            this.linearInteractionModeCheckedListBox.CheckOnClick = true;
            this.linearInteractionModeCheckedListBox.Location = new System.Drawing.Point(11, 96);
            this.linearInteractionModeCheckedListBox.Name = "linearInteractionModeCheckedListBox";
            this.linearInteractionModeCheckedListBox.Size = new System.Drawing.Size(113, 79);
            this.linearInteractionModeCheckedListBox.TabIndex = 18;
            this.linearInteractionModeCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.OnLinearInteractionModeItemCheck);
            // 
            // linearCoercionIntervalPanel
            // 
            this.linearCoercionIntervalPanel.Controls.Add(this.linearCoercionIntervalLabel);
            this.linearCoercionIntervalPanel.Controls.Add(this.linearCoercionIntervalNumericEdit);
            this.linearCoercionIntervalPanel.Location = new System.Drawing.Point(137, 71);
            this.linearCoercionIntervalPanel.Name = "linearCoercionIntervalPanel";
            this.linearCoercionIntervalPanel.Size = new System.Drawing.Size(137, 52);
            this.linearCoercionIntervalPanel.TabIndex = 20;
            // 
            // linearCoercionIntervalLabel
            // 
            this.linearCoercionIntervalLabel.AutoSize = true;
            this.linearCoercionIntervalLabel.Location = new System.Drawing.Point(8, 6);
            this.linearCoercionIntervalLabel.Name = "linearCoercionIntervalLabel";
            this.linearCoercionIntervalLabel.Size = new System.Drawing.Size(90, 13);
            this.linearCoercionIntervalLabel.TabIndex = 1;
            this.linearCoercionIntervalLabel.Text = "Coercion Interval:";
            // 
            // linearCoercionIntervalNumericEdit
            // 
            this.linearCoercionIntervalNumericEdit.Location = new System.Drawing.Point(10, 25);
            this.linearCoercionIntervalNumericEdit.Name = "linearCoercionIntervalNumericEdit";
            this.linearCoercionIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.linearCoercionIntervalNumericEdit.Range = new NationalInstruments.UI.Range(0.001, 10);
            this.linearCoercionIntervalNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.linearCoercionIntervalNumericEdit.TabIndex = 0;
            this.linearCoercionIntervalNumericEdit.Value = 0.001;
            this.linearCoercionIntervalNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnLinearCoercionIntervalAfterChangeValue);
            // 
            // linearCoercionIntervalBasePanel
            // 
            this.linearCoercionIntervalBasePanel.Controls.Add(this.linearCoercionIntervalBaseNumericEdit);
            this.linearCoercionIntervalBasePanel.Controls.Add(this.linearCoercionIntervalBaseLabel);
            this.linearCoercionIntervalBasePanel.Location = new System.Drawing.Point(136, 130);
            this.linearCoercionIntervalBasePanel.Name = "linearCoercionIntervalBasePanel";
            this.linearCoercionIntervalBasePanel.Size = new System.Drawing.Size(140, 52);
            this.linearCoercionIntervalBasePanel.TabIndex = 21;
            // 
            // linearCoercionIntervalBaseNumericEdit
            // 
            this.linearCoercionIntervalBaseNumericEdit.Location = new System.Drawing.Point(11, 25);
            this.linearCoercionIntervalBaseNumericEdit.Name = "linearCoercionIntervalBaseNumericEdit";
            this.linearCoercionIntervalBaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.linearCoercionIntervalBaseNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.linearCoercionIntervalBaseNumericEdit.Size = new System.Drawing.Size(120, 20);
            this.linearCoercionIntervalBaseNumericEdit.TabIndex = 0;
            this.linearCoercionIntervalBaseNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnLinearCoercionIntervalBaseAfterChangeValue);
            // 
            // linearCoercionIntervalBaseLabel
            // 
            this.linearCoercionIntervalBaseLabel.AutoSize = true;
            this.linearCoercionIntervalBaseLabel.Location = new System.Drawing.Point(8, 6);
            this.linearCoercionIntervalBaseLabel.Name = "linearCoercionIntervalBaseLabel";
            this.linearCoercionIntervalBaseLabel.Size = new System.Drawing.Size(117, 13);
            this.linearCoercionIntervalBaseLabel.TabIndex = 1;
            this.linearCoercionIntervalBaseLabel.Text = "Coercion Interval Base:";
            // 
            // linearValueNumericEdit
            // 
            this.linearValueNumericEdit.BackColor = System.Drawing.SystemColors.Control;
            this.linearValueNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator;
            this.linearValueNumericEdit.Location = new System.Drawing.Point(40, 47);
            this.linearValueNumericEdit.Name = "linearValueNumericEdit";
            this.linearValueNumericEdit.Size = new System.Drawing.Size(55, 20);
            this.linearValueNumericEdit.TabIndex = 24;
            // 
            // linearValueLabel
            // 
            this.linearValueLabel.AutoSize = true;
            this.linearValueLabel.Location = new System.Drawing.Point(40, 27);
            this.linearValueLabel.Name = "linearValueLabel";
            this.linearValueLabel.Size = new System.Drawing.Size(37, 13);
            this.linearValueLabel.TabIndex = 25;
            this.linearValueLabel.Text = "Value:";
            // 
            // linearMovePreviousButton
            // 
            this.linearMovePreviousButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.linearMovePreviousButton.Location = new System.Drawing.Point(11, 44);
            this.linearMovePreviousButton.Name = "linearMovePreviousButton";
            this.linearMovePreviousButton.Size = new System.Drawing.Size(26, 21);
            this.linearMovePreviousButton.TabIndex = 16;
            this.linearMovePreviousButton.Text = "<";
            this.linearMovePreviousButton.Click += new System.EventHandler(this.OnLinearMovePreviousClick);
            // 
            // linearMoveNextButton
            // 
            this.linearMoveNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.linearMoveNextButton.Location = new System.Drawing.Point(99, 46);
            this.linearMoveNextButton.Name = "linearMoveNextButton";
            this.linearMoveNextButton.Size = new System.Drawing.Size(26, 21);
            this.linearMoveNextButton.TabIndex = 17;
            this.linearMoveNextButton.Text = ">";
            this.linearMoveNextButton.Click += new System.EventHandler(this.OnLinearMoveNextClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(668, 613);
            this.Controls.Add(this.linearGroupBox);
            this.Controls.Add(this.radialGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Interaction";
            ((System.ComponentModel.ISupportInitialize)(this.sampleGauge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleMeter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleThermometer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialCoercionIntervalBaseNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radialCoercionIntervalNumericEdit)).EndInit();
            this.radialCoercionIntervalPanel.ResumeLayout(false);
            this.radialCoercionIntervalPanel.PerformLayout();
            this.radialCoercionIntervalBasePanel.ResumeLayout(false);
            this.radialCoercionIntervalBasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radialValueNumericEdit)).EndInit();
            this.radialSettingsGroupBox.ResumeLayout(false);
            this.radialSettingsGroupBox.PerformLayout();
            this.radialGroupBox.ResumeLayout(false);
            this.linearGroupBox.ResumeLayout(false);
            this.linearSettingGroupBox.ResumeLayout(false);
            this.linearSettingGroupBox.PerformLayout();
            this.linearCoercionIntervalPanel.ResumeLayout(false);
            this.linearCoercionIntervalPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linearCoercionIntervalNumericEdit)).EndInit();
            this.linearCoercionIntervalBasePanel.ResumeLayout(false);
            this.linearCoercionIntervalBasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linearCoercionIntervalBaseNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linearValueNumericEdit)).EndInit();
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

        private void OnRadialInteractionModeItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            RadialNumericPointerInteractionModes interactionMode = (RadialNumericPointerInteractionModes) Enum.Parse(typeof(RadialNumericPointerInteractionModes), radialInteractionModeCheckedListBox.Items[e.Index] as String);
            foreach (RadialNumericPointer numericPointer in radialNumericPointers)
            {
                numericPointer.InteractionMode = (e.NewValue == CheckState.Checked) ? numericPointer.InteractionMode | interactionMode : numericPointer.InteractionMode ^ interactionMode;
            }
        }

        private void OnLinearInteractionModeItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            LinearNumericPointerInteractionModes interactionMode = (LinearNumericPointerInteractionModes) Enum.Parse(typeof(LinearNumericPointerInteractionModes), linearInteractionModeCheckedListBox.Items[e.Index] as String);
            foreach (LinearNumericPointer numericPointer in linearNumericPointers)
            {
                numericPointer.InteractionMode = (e.NewValue == CheckState.Checked) ? numericPointer.InteractionMode | interactionMode : numericPointer.InteractionMode ^ interactionMode;
            }        
        }

        private void OnRadialCoercionModeSelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateCoercionMode(radialNumericPointers, radialCoercionModeComboBox.SelectedItem as String);
            UpdateRadialCoercionModePanels();
        }

        private void OnLinearCoercionModeSelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateCoercionMode(linearNumericPointers, linearCoercionModeComboBox.SelectedItem as String);
            UpdateLinearCoercionModePanels();
        }

        private static void UpdateCoercionMode(NumericPointer[] numericPointers, string value)
        {
            NumericCoercionMode coercionMode = EnumObject.Parse(typeof(NumericCoercionMode), value) as NumericCoercionMode;
            foreach (NumericPointer numericPointer in numericPointers)
            {
                numericPointer.CoercionMode = coercionMode;
            }
        }

        private void OnRadialCoercionIntervalAfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            UpdateCoercionInterval(radialNumericPointers, e.NewValue);
        }

        private void OnLinearCoercionIntervalAfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            UpdateCoercionInterval(linearNumericPointers, e.NewValue);
        }

        private static void UpdateCoercionInterval(NumericPointer[] numericPointers, double value)
        {
            foreach (NumericPointer numericPointer in numericPointers)
            {
                numericPointer.CoercionInterval = value;
            }
        }

        private void OnRadialCoercionIntervalBaseAfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            UpdateCoercionIntervalBase(radialNumericPointers, e.NewValue);
        }

        private void OnLinearCoercionIntervalBaseAfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            UpdateCoercionIntervalBase(linearNumericPointers, e.NewValue);
        }

        private static void UpdateCoercionIntervalBase(NumericPointer[] numericPointers, double value)
        {
            foreach (NumericPointer numericPointer in numericPointers)
            {
                numericPointer.CoercionIntervalBase = value;
            }
        }

        private void OnRadialMovePreviousClick(object sender, System.EventArgs e)
        {
            MovePrevious(radialNumericPointers);
        }

        private void OnLinearMovePreviousClick(object sender, System.EventArgs e)
        {
            MovePrevious(linearNumericPointers);
        }

        private static void MovePrevious(NumericPointer[] numericPointers)
        {
            foreach (NumericPointer numericPointer in numericPointers)
            {
                numericPointer.MovePrevious();
            }
        }

        private void OnRadialMoveNextClick(object sender, System.EventArgs e)
        {
            MoveNext(radialNumericPointers);
        }

        private void OnLinearMoveNextClick(object sender, System.EventArgs e)
        {
            MoveNext(linearNumericPointers);
        }

        private static void MoveNext(NumericPointer[] numericPointers)
        {
            foreach (NumericPointer numericPointer in numericPointers)
            {
                numericPointer.MoveNext();
            }
        }

        private void UpdateRadialCoercionModePanels()
        {
            if (radialCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.None.Name))
            {
                radialCoercionIntervalPanel.Visible = true;
                radialCoercionIntervalBasePanel.Visible = false;
            }
            else if (radialCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToInterval.Name))
            {
                radialCoercionIntervalPanel.Visible = true;
                radialCoercionIntervalBasePanel.Visible = true;
            }
            else if (radialCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToDivisions.Name))
            {
                radialCoercionIntervalPanel.Visible = false;
                radialCoercionIntervalBasePanel.Visible = false;
            }
        }

        private void UpdateLinearCoercionModePanels()
        {
            if (linearCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.None.Name))
            {
                linearCoercionIntervalPanel.Visible = true;
                linearCoercionIntervalBasePanel.Visible = false;
            }
            else if (linearCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToInterval.Name))
            {
                linearCoercionIntervalPanel.Visible = true;
                linearCoercionIntervalBasePanel.Visible = true;
            }
            else if (linearCoercionModeComboBox.SelectedItem.Equals(NumericCoercionMode.ToDivisions.Name))
            {
                linearCoercionIntervalPanel.Visible = false;
                linearCoercionIntervalBasePanel.Visible = false;
            }
        }

        private void OnRadialNumericPointerEnter(object sender, EventArgs e)
        {
            radialValueNumericEdit.Source = sender as INumericValueSource;
        }

        private void OnLinearNumericPointerEnter(object sender, EventArgs e)
        {
            linearValueNumericEdit.Source = sender as INumericValueSource;
        }
    }
}
