using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI.WindowsForms;
using NationalInstruments.UI;
using System.Reflection;
using System.IO;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;

namespace NationalInstruments.Examples.BooleanFeatures
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ComboBox ledStylesComboBox;
        private System.Windows.Forms.ComboBox switchStylesComboBox;
        private System.Windows.Forms.ComboBox ledResponseModesComboBox;
        private System.Windows.Forms.ComboBox switchResponseModesComboBox;
        private System.Windows.Forms.Label ledStylesLabel;
        private System.Windows.Forms.Label ledResponseModesLabel;
        private System.Windows.Forms.ComboBox ledBlinkStylesComboBox;
        private System.Windows.Forms.Button ledOnColorButton;
        private System.Windows.Forms.Button ledOffColorButton;
        private NationalInstruments.UI.WindowsForms.Led onColorLed;
        private NationalInstruments.UI.WindowsForms.Led offColorLed;
        private System.Windows.Forms.TextBox ledStateTextBox;
        private System.Windows.Forms.CheckBox switchBackgroundTransparentCheckBox;
        private System.Windows.Forms.Button switchOffColorButton;
        private System.Windows.Forms.Button switchOnColorButton;
        private System.Windows.Forms.CheckBox seeTransparentCheckBox;
        private System.ComponentModel.IContainer components;
        private NationalInstruments.UI.WindowsForms.Led switchOnColorLed;
        private NationalInstruments.UI.WindowsForms.Led switchOffColorLed;
        private System.Windows.Forms.TextBox switchStateTextBox;
        private System.Windows.Forms.CheckBox ledBackgroundTransparentCheckBox;
        private NationalInstruments.UI.WindowsForms.Switch displaySwitch;
        private NationalInstruments.UI.WindowsForms.Led displayLed;
        private System.Windows.Forms.Label ledOffColorLabel;
        private System.Windows.Forms.Label ledOnColorLabel;
        private System.Windows.Forms.Label switchOffColorLabel;
        private System.Windows.Forms.Label switchOnColorLabel;
        private System.Windows.Forms.Label switchValueLabel;
        private System.Windows.Forms.Label switchResponseModesLabel;
        private System.Windows.Forms.Label ledValueLabel;
        private System.Windows.Forms.Label ledBlinkStylesLabel;
        private System.Windows.Forms.Label ledBlinkIntervalLabel;
        private System.Windows.Forms.GroupBox switchGroupBox;
        private System.Windows.Forms.GroupBox ledGroupBox;
        private System.Windows.Forms.Label switchSwitchStylesLabel;
        private System.Windows.Forms.ToolTip transparentToolTip;
        private NationalInstruments.UI.WindowsForms.NumericEdit ledBlinkIntervalNumericEdit;
        private Image image;

        public MainForm()
        {
			
            InitializeComponent();
           
            transparentToolTip.SetToolTip(seeTransparentCheckBox, "Allows the BackgroundTransparent property of the Led\n and Switch to be seen");
            
            Stream s = this.GetType().Assembly.GetManifestResourceStream("NationalInstruments.Examples.BooleanFeatures.SplashScreen.jpg");
            image = Image.FromStream(s);

            FillComboBoxes();
            SetControlsToDesignerValues();        
        }

        private void FillComboBoxes()
        {
            foreach(string mode in Enum.GetNames(typeof(BooleanInteractionMode)))
            {
                ledResponseModesComboBox.Items.Add(mode);
                switchResponseModesComboBox.Items.Add(mode);
            }
			
            foreach(string mode in Enum.GetNames(typeof(LedBlinkMode)))
                ledBlinkStylesComboBox.Items.Add(mode);
         
            foreach(object o in EnumObject.GetValues(typeof(LedStyle)))
                ledStylesComboBox.Items.Add(o);
            
            foreach(object o in EnumObject.GetValues(typeof(SwitchStyle)))
                switchStylesComboBox.Items.Add(o);
        }

        private void SetControlsToDesignerValues()
        {   
            onColorLed.OffColor = displayLed.OnColor;
            offColorLed.OffColor = displayLed.OffColor;
            switchOnColorLed.OffColor = displaySwitch.OnColor;
            switchOffColorLed.OffColor = displaySwitch.OffColor;
            
            ledBlinkIntervalNumericEdit.Value = displayLed.BlinkInterval.TotalMilliseconds;

            switchBackgroundTransparentCheckBox.Checked = displaySwitch.BackColor == Color.Transparent;
            ledBackgroundTransparentCheckBox.Checked = displayLed.BackColor == Color.Transparent;
            
            switchStateTextBox.Text = displaySwitch.Value.ToString();
            ledStateTextBox.Text = displayLed.Value.ToString();
            
            ledStylesComboBox.SelectedItem = displayLed.LedStyle;
            switchStylesComboBox.SelectedItem = displaySwitch.SwitchStyle;

            ledBlinkStylesComboBox.SelectedItem = displayLed.BlinkMode.ToString();    
            switchResponseModesComboBox.SelectedItem = displaySwitch.InteractionMode.ToString();
            ledResponseModesComboBox.SelectedItem = displayLed.InteractionMode.ToString();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.ledStylesComboBox = new System.Windows.Forms.ComboBox();
            this.ledBackgroundTransparentCheckBox = new System.Windows.Forms.CheckBox();
            this.switchStylesComboBox = new System.Windows.Forms.ComboBox();
            this.ledResponseModesComboBox = new System.Windows.Forms.ComboBox();
            this.switchResponseModesComboBox = new System.Windows.Forms.ComboBox();
            this.ledStylesLabel = new System.Windows.Forms.Label();
            this.ledResponseModesLabel = new System.Windows.Forms.Label();
            this.ledBlinkStylesComboBox = new System.Windows.Forms.ComboBox();
            this.ledOffColorLabel = new System.Windows.Forms.Label();
            this.ledOnColorLabel = new System.Windows.Forms.Label();
            this.ledOffColorButton = new System.Windows.Forms.Button();
            this.ledOnColorButton = new System.Windows.Forms.Button();
            this.offColorLed = new NationalInstruments.UI.WindowsForms.Led();
            this.onColorLed = new NationalInstruments.UI.WindowsForms.Led();
            this.displaySwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.switchGroupBox = new System.Windows.Forms.GroupBox();
            this.switchOnColorLed = new NationalInstruments.UI.WindowsForms.Led();
            this.switchOffColorLed = new NationalInstruments.UI.WindowsForms.Led();
            this.switchOffColorButton = new System.Windows.Forms.Button();
            this.switchOnColorButton = new System.Windows.Forms.Button();
            this.switchOffColorLabel = new System.Windows.Forms.Label();
            this.switchSwitchStylesLabel = new System.Windows.Forms.Label();
            this.switchOnColorLabel = new System.Windows.Forms.Label();
            this.switchBackgroundTransparentCheckBox = new System.Windows.Forms.CheckBox();
            this.switchStateTextBox = new System.Windows.Forms.TextBox();
            this.switchValueLabel = new System.Windows.Forms.Label();
            this.switchResponseModesLabel = new System.Windows.Forms.Label();
            this.ledStateTextBox = new System.Windows.Forms.TextBox();
            this.ledValueLabel = new System.Windows.Forms.Label();
            this.ledBlinkStylesLabel = new System.Windows.Forms.Label();
            this.ledBlinkIntervalLabel = new System.Windows.Forms.Label();
            this.transparentToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.seeTransparentCheckBox = new System.Windows.Forms.CheckBox();
            this.displayLed = new NationalInstruments.UI.WindowsForms.Led();
            this.ledGroupBox = new System.Windows.Forms.GroupBox();
            this.ledBlinkIntervalNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.offColorLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onColorLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySwitch)).BeginInit();
            this.switchGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchOnColorLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchOffColorLed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayLed)).BeginInit();
            this.ledGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBlinkIntervalNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // ledStylesComboBox
            // 
            this.ledStylesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ledStylesComboBox.Location = new System.Drawing.Point(280, 124);
            this.ledStylesComboBox.Name = "ledStylesComboBox";
            this.ledStylesComboBox.Size = new System.Drawing.Size(88, 21);
            this.ledStylesComboBox.TabIndex = 4;
            this.ledStylesComboBox.SelectedIndexChanged += new System.EventHandler(this.ledStyles_SelectedIndexChanged);
            // 
            // ledBackgroundTransparentCheckBox
            // 
            this.ledBackgroundTransparentCheckBox.Location = new System.Drawing.Point(216, 28);
            this.ledBackgroundTransparentCheckBox.Name = "ledBackgroundTransparentCheckBox";
            this.ledBackgroundTransparentCheckBox.Size = new System.Drawing.Size(152, 16);
            this.ledBackgroundTransparentCheckBox.TabIndex = 1;
            this.ledBackgroundTransparentCheckBox.Text = "BackgroundTransparent";
            this.ledBackgroundTransparentCheckBox.CheckedChanged += new System.EventHandler(this.ledBackgroundTransparent_CheckedChanged);
            // 
            // switchStylesComboBox
            // 
            this.switchStylesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchStylesComboBox.Location = new System.Drawing.Point(288, 124);
            this.switchStylesComboBox.Name = "switchStylesComboBox";
            this.switchStylesComboBox.Size = new System.Drawing.Size(120, 21);
            this.switchStylesComboBox.TabIndex = 4;
            this.switchStylesComboBox.SelectedIndexChanged += new System.EventHandler(this.switchStyles_SelectedIndexChanged);
            // 
            // ledResponseModesComboBox
            // 
            this.ledResponseModesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ledResponseModesComboBox.Location = new System.Drawing.Point(520, 28);
            this.ledResponseModesComboBox.Name = "ledResponseModesComboBox";
            this.ledResponseModesComboBox.Size = new System.Drawing.Size(128, 21);
            this.ledResponseModesComboBox.TabIndex = 5;
            this.ledResponseModesComboBox.SelectedIndexChanged += new System.EventHandler(this.ledResponseModes_SelectedIndexChanged);
            // 
            // switchResponseModesComboBox
            // 
            this.switchResponseModesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.switchResponseModesComboBox.Location = new System.Drawing.Point(520, 28);
            this.switchResponseModesComboBox.Name = "switchResponseModesComboBox";
            this.switchResponseModesComboBox.Size = new System.Drawing.Size(128, 21);
            this.switchResponseModesComboBox.TabIndex = 5;
            this.switchResponseModesComboBox.SelectedIndexChanged += new System.EventHandler(this.switchResponseModes_SelectedIndexChanged);
            // 
            // ledStylesLabel
            // 
            this.ledStylesLabel.AutoSize = true;
            this.ledStylesLabel.Location = new System.Drawing.Point(216, 128);
            this.ledStylesLabel.Name = "ledStylesLabel";
            this.ledStylesLabel.Size = new System.Drawing.Size(53, 13);
            this.ledStylesLabel.TabIndex = 11;
            this.ledStylesLabel.Text = "LedStyles";
            this.ledStylesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ledResponseModesLabel
            // 
            this.ledResponseModesLabel.AutoSize = true;
            this.ledResponseModesLabel.Location = new System.Drawing.Point(396, 28);
            this.ledResponseModesLabel.Name = "ledResponseModesLabel";
            this.ledResponseModesLabel.Size = new System.Drawing.Size(123, 13);
            this.ledResponseModesLabel.TabIndex = 12;
            this.ledResponseModesLabel.Text = "BooleanInteractionMode";
            this.ledResponseModesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledBlinkStylesComboBox
            // 
            this.ledBlinkStylesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ledBlinkStylesComboBox.Location = new System.Drawing.Point(520, 60);
            this.ledBlinkStylesComboBox.Name = "ledBlinkStylesComboBox";
            this.ledBlinkStylesComboBox.Size = new System.Drawing.Size(128, 21);
            this.ledBlinkStylesComboBox.TabIndex = 6;
            this.ledBlinkStylesComboBox.SelectedIndexChanged += new System.EventHandler(this.ledBlinkStyles_SelectedIndexChanged);
            // 
            // ledOffColorLabel
            // 
            this.ledOffColorLabel.AutoSize = true;
            this.ledOffColorLabel.Location = new System.Drawing.Point(280, 92);
            this.ledOffColorLabel.Name = "ledOffColorLabel";
            this.ledOffColorLabel.Size = new System.Drawing.Size(45, 13);
            this.ledOffColorLabel.TabIndex = 11;
            this.ledOffColorLabel.Text = "OffColor";
            this.ledOffColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledOnColorLabel
            // 
            this.ledOnColorLabel.AutoSize = true;
            this.ledOnColorLabel.Location = new System.Drawing.Point(280, 60);
            this.ledOnColorLabel.Name = "ledOnColorLabel";
            this.ledOnColorLabel.Size = new System.Drawing.Size(45, 13);
            this.ledOnColorLabel.TabIndex = 10;
            this.ledOnColorLabel.Text = "OnColor";
            this.ledOnColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledOffColorButton
            // 
            this.ledOffColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ledOffColorButton.Location = new System.Drawing.Point(240, 92);
            this.ledOffColorButton.Name = "ledOffColorButton";
            this.ledOffColorButton.Size = new System.Drawing.Size(24, 16);
            this.ledOffColorButton.TabIndex = 3;
            this.ledOffColorButton.Text = "...";
            this.ledOffColorButton.Click += new System.EventHandler(this.ledOffColorButton_Click);
            // 
            // ledOnColorButton
            // 
            this.ledOnColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ledOnColorButton.Location = new System.Drawing.Point(240, 60);
            this.ledOnColorButton.Name = "ledOnColorButton";
            this.ledOnColorButton.Size = new System.Drawing.Size(24, 16);
            this.ledOnColorButton.TabIndex = 2;
            this.ledOnColorButton.Text = "...";
            this.ledOnColorButton.Click += new System.EventHandler(this.ledOnColorButton_Click);
            // 
            // offColorLed
            // 
            this.offColorLed.Location = new System.Drawing.Point(208, 84);
            this.offColorLed.Name = "offColorLed";
            this.offColorLed.Size = new System.Drawing.Size(32, 32);
            this.offColorLed.TabIndex = 7;
            // 
            // onColorLed
            // 
            this.onColorLed.Location = new System.Drawing.Point(208, 52);
            this.onColorLed.Name = "onColorLed";
            this.onColorLed.Size = new System.Drawing.Size(32, 32);
            this.onColorLed.TabIndex = 6;
            // 
            // displaySwitch
            // 
            this.displaySwitch.Dock = System.Windows.Forms.DockStyle.Left;
            this.displaySwitch.Location = new System.Drawing.Point(3, 16);
            this.displaySwitch.Name = "displaySwitch";
            this.displaySwitch.Size = new System.Drawing.Size(161, 149);
            this.displaySwitch.TabIndex = 0;
            this.displaySwitch.ValueChanged += new System.EventHandler(this.switch1_ValueChanged);
            // 
            // switchGroupBox
            // 
            this.switchGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.switchGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.switchGroupBox.Controls.Add(this.displaySwitch);
            this.switchGroupBox.Controls.Add(this.switchOnColorLed);
            this.switchGroupBox.Controls.Add(this.switchOffColorLed);
            this.switchGroupBox.Controls.Add(this.switchOffColorButton);
            this.switchGroupBox.Controls.Add(this.switchOnColorButton);
            this.switchGroupBox.Controls.Add(this.switchOffColorLabel);
            this.switchGroupBox.Controls.Add(this.switchSwitchStylesLabel);
            this.switchGroupBox.Controls.Add(this.switchOnColorLabel);
            this.switchGroupBox.Controls.Add(this.switchBackgroundTransparentCheckBox);
            this.switchGroupBox.Controls.Add(this.switchStateTextBox);
            this.switchGroupBox.Controls.Add(this.switchValueLabel);
            this.switchGroupBox.Controls.Add(this.switchResponseModesLabel);
            this.switchGroupBox.Controls.Add(this.switchStylesComboBox);
            this.switchGroupBox.Controls.Add(this.switchResponseModesComboBox);
            this.switchGroupBox.Location = new System.Drawing.Point(8, 192);
            this.switchGroupBox.Name = "switchGroupBox";
            this.switchGroupBox.Size = new System.Drawing.Size(656, 168);
            this.switchGroupBox.TabIndex = 1;
            this.switchGroupBox.TabStop = false;
            this.switchGroupBox.Text = "Switch";
            // 
            // switchOnColorLed
            // 
            this.switchOnColorLed.Location = new System.Drawing.Point(208, 52);
            this.switchOnColorLed.Name = "switchOnColorLed";
            this.switchOnColorLed.Size = new System.Drawing.Size(32, 32);
            this.switchOnColorLed.TabIndex = 12;
            // 
            // switchOffColorLed
            // 
            this.switchOffColorLed.Location = new System.Drawing.Point(208, 84);
            this.switchOffColorLed.Name = "switchOffColorLed";
            this.switchOffColorLed.Size = new System.Drawing.Size(32, 32);
            this.switchOffColorLed.TabIndex = 13;
            // 
            // switchOffColorButton
            // 
            this.switchOffColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.switchOffColorButton.Location = new System.Drawing.Point(240, 92);
            this.switchOffColorButton.Name = "switchOffColorButton";
            this.switchOffColorButton.Size = new System.Drawing.Size(24, 16);
            this.switchOffColorButton.TabIndex = 3;
            this.switchOffColorButton.Text = "...";
            this.switchOffColorButton.Click += new System.EventHandler(this.switchOffColorButton_Click);
            // 
            // switchOnColorButton
            // 
            this.switchOnColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.switchOnColorButton.Location = new System.Drawing.Point(240, 60);
            this.switchOnColorButton.Name = "switchOnColorButton";
            this.switchOnColorButton.Size = new System.Drawing.Size(24, 16);
            this.switchOnColorButton.TabIndex = 2;
            this.switchOnColorButton.Text = "...";
            this.switchOnColorButton.Click += new System.EventHandler(this.switchOnColorButton_Click);
            // 
            // switchOffColorLabel
            // 
            this.switchOffColorLabel.AutoSize = true;
            this.switchOffColorLabel.Location = new System.Drawing.Point(280, 92);
            this.switchOffColorLabel.Name = "switchOffColorLabel";
            this.switchOffColorLabel.Size = new System.Drawing.Size(45, 13);
            this.switchOffColorLabel.TabIndex = 17;
            this.switchOffColorLabel.Text = "OffColor";
            // 
            // switchSwitchStylesLabel
            // 
            this.switchSwitchStylesLabel.AutoSize = true;
            this.switchSwitchStylesLabel.Location = new System.Drawing.Point(216, 128);
            this.switchSwitchStylesLabel.Name = "switchSwitchStylesLabel";
            this.switchSwitchStylesLabel.Size = new System.Drawing.Size(67, 13);
            this.switchSwitchStylesLabel.TabIndex = 18;
            this.switchSwitchStylesLabel.Text = "SwitchStyles";
            this.switchSwitchStylesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // switchOnColorLabel
            // 
            this.switchOnColorLabel.AutoSize = true;
            this.switchOnColorLabel.Location = new System.Drawing.Point(280, 60);
            this.switchOnColorLabel.Name = "switchOnColorLabel";
            this.switchOnColorLabel.Size = new System.Drawing.Size(45, 13);
            this.switchOnColorLabel.TabIndex = 16;
            this.switchOnColorLabel.Text = "OnColor";
            // 
            // switchBackgroundTransparentCheckBox
            // 
            this.switchBackgroundTransparentCheckBox.Location = new System.Drawing.Point(216, 28);
            this.switchBackgroundTransparentCheckBox.Name = "switchBackgroundTransparentCheckBox";
            this.switchBackgroundTransparentCheckBox.Size = new System.Drawing.Size(152, 16);
            this.switchBackgroundTransparentCheckBox.TabIndex = 1;
            this.switchBackgroundTransparentCheckBox.Text = "BackgroundTransparent";
            this.switchBackgroundTransparentCheckBox.CheckedChanged += new System.EventHandler(this.switchBackgroundTransparent_CheckedChanged);
            // 
            // switchStateTextBox
            // 
            this.switchStateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.switchStateTextBox.Location = new System.Drawing.Point(520, 60);
            this.switchStateTextBox.Name = "switchStateTextBox";
            this.switchStateTextBox.ReadOnly = true;
            this.switchStateTextBox.Size = new System.Drawing.Size(32, 13);
            this.switchStateTextBox.TabIndex = 12;
            this.switchStateTextBox.TabStop = false;
            this.switchStateTextBox.Text = "false";
            // 
            // switchValueLabel
            // 
            this.switchValueLabel.AutoSize = true;
            this.switchValueLabel.Location = new System.Drawing.Point(392, 60);
            this.switchValueLabel.Name = "switchValueLabel";
            this.switchValueLabel.Size = new System.Drawing.Size(34, 13);
            this.switchValueLabel.TabIndex = 18;
            this.switchValueLabel.Text = "Value";
            this.switchValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // switchResponseModesLabel
            // 
            this.switchResponseModesLabel.AutoSize = true;
            this.switchResponseModesLabel.Location = new System.Drawing.Point(392, 28);
            this.switchResponseModesLabel.Name = "switchResponseModesLabel";
            this.switchResponseModesLabel.Size = new System.Drawing.Size(123, 13);
            this.switchResponseModesLabel.TabIndex = 11;
            this.switchResponseModesLabel.Text = "BooleanInteractionMode";
            // 
            // ledStateTextBox
            // 
            this.ledStateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ledStateTextBox.Location = new System.Drawing.Point(520, 124);
            this.ledStateTextBox.Name = "ledStateTextBox";
            this.ledStateTextBox.ReadOnly = true;
            this.ledStateTextBox.Size = new System.Drawing.Size(32, 13);
            this.ledStateTextBox.TabIndex = 1;
            this.ledStateTextBox.TabStop = false;
            this.ledStateTextBox.Text = "false";
            // 
            // ledValueLabel
            // 
            this.ledValueLabel.AutoSize = true;
            this.ledValueLabel.Location = new System.Drawing.Point(396, 124);
            this.ledValueLabel.Name = "ledValueLabel";
            this.ledValueLabel.Size = new System.Drawing.Size(34, 13);
            this.ledValueLabel.TabIndex = 17;
            this.ledValueLabel.Text = "Value";
            this.ledValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledBlinkStylesLabel
            // 
            this.ledBlinkStylesLabel.AutoSize = true;
            this.ledBlinkStylesLabel.Location = new System.Drawing.Point(396, 60);
            this.ledBlinkStylesLabel.Name = "ledBlinkStylesLabel";
            this.ledBlinkStylesLabel.Size = new System.Drawing.Size(57, 13);
            this.ledBlinkStylesLabel.TabIndex = 15;
            this.ledBlinkStylesLabel.Text = "BlinkMode";
            this.ledBlinkStylesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ledBlinkIntervalLabel
            // 
            this.ledBlinkIntervalLabel.AutoSize = true;
            this.ledBlinkIntervalLabel.Location = new System.Drawing.Point(396, 92);
            this.ledBlinkIntervalLabel.Name = "ledBlinkIntervalLabel";
            this.ledBlinkIntervalLabel.Size = new System.Drawing.Size(65, 13);
            this.ledBlinkIntervalLabel.TabIndex = 16;
            this.ledBlinkIntervalLabel.Text = "BlinkInterval";
            this.ledBlinkIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // seeTransparentCheckBox
            // 
            this.seeTransparentCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.seeTransparentCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.seeTransparentCheckBox.Location = new System.Drawing.Point(16, 368);
            this.seeTransparentCheckBox.Name = "seeTransparentCheckBox";
            this.seeTransparentCheckBox.Size = new System.Drawing.Size(160, 16);
            this.seeTransparentCheckBox.TabIndex = 2;
            this.seeTransparentCheckBox.Text = "Transparent Mode";
            this.seeTransparentCheckBox.CheckedChanged += new System.EventHandler(this.seeTransparent_CheckedChanged);
            // 
            // displayLed
            // 
            this.displayLed.InteractionMode = NationalInstruments.UI.BooleanInteractionMode.SwitchWhenPressed;
            this.displayLed.Location = new System.Drawing.Point(3, 16);
            this.displayLed.Name = "displayLed";
            this.displayLed.Size = new System.Drawing.Size(161, 149);
            this.displayLed.TabIndex = 0;
            this.displayLed.ValueChanged += new System.EventHandler(this.led1_ValueChanged);
            // 
            // ledGroupBox
            // 
            this.ledGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ledGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ledGroupBox.Controls.Add(this.displayLed);
            this.ledGroupBox.Controls.Add(this.offColorLed);
            this.ledGroupBox.Controls.Add(this.ledOnColorLabel);
            this.ledGroupBox.Controls.Add(this.ledStylesLabel);
            this.ledGroupBox.Controls.Add(this.ledStylesComboBox);
            this.ledGroupBox.Controls.Add(this.ledOffColorButton);
            this.ledGroupBox.Controls.Add(this.onColorLed);
            this.ledGroupBox.Controls.Add(this.ledOnColorButton);
            this.ledGroupBox.Controls.Add(this.ledOffColorLabel);
            this.ledGroupBox.Controls.Add(this.ledBackgroundTransparentCheckBox);
            this.ledGroupBox.Controls.Add(this.ledBlinkStylesLabel);
            this.ledGroupBox.Controls.Add(this.ledResponseModesComboBox);
            this.ledGroupBox.Controls.Add(this.ledBlinkStylesComboBox);
            this.ledGroupBox.Controls.Add(this.ledStateTextBox);
            this.ledGroupBox.Controls.Add(this.ledResponseModesLabel);
            this.ledGroupBox.Controls.Add(this.ledBlinkIntervalLabel);
            this.ledGroupBox.Controls.Add(this.ledValueLabel);
            this.ledGroupBox.Controls.Add(this.ledBlinkIntervalNumericEdit);
            this.ledGroupBox.Location = new System.Drawing.Point(8, 8);
            this.ledGroupBox.Name = "ledGroupBox";
            this.ledGroupBox.Size = new System.Drawing.Size(656, 168);
            this.ledGroupBox.TabIndex = 0;
            this.ledGroupBox.TabStop = false;
            this.ledGroupBox.Text = " Led";
            // 
            // ledBlinkIntervalNumericEdit
            // 
            this.ledBlinkIntervalNumericEdit.CoercionInterval = 20;
            this.ledBlinkIntervalNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval;
            this.ledBlinkIntervalNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.ledBlinkIntervalNumericEdit.Location = new System.Drawing.Point(520, 92);
            this.ledBlinkIntervalNumericEdit.Name = "ledBlinkIntervalNumericEdit";
            this.ledBlinkIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.ledBlinkIntervalNumericEdit.Range = new NationalInstruments.UI.Range(20, 1000);
            this.ledBlinkIntervalNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.ledBlinkIntervalNumericEdit.TabIndex = 7;
            this.ledBlinkIntervalNumericEdit.Value = 500;
            this.ledBlinkIntervalNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.ledBlinkInterval_AfterChangeValue);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(672, 397);
            this.Controls.Add(this.ledGroupBox);
            this.Controls.Add(this.switchGroupBox);
            this.Controls.Add(this.seeTransparentCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(680, 424);
            this.Name = "MainForm";
            this.Text = "Switch/Led Features";
            ((System.ComponentModel.ISupportInitialize)(this.offColorLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onColorLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displaySwitch)).EndInit();
            this.switchGroupBox.ResumeLayout(false);
            this.switchGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.switchOnColorLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.switchOffColorLed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayLed)).EndInit();
            this.ledGroupBox.ResumeLayout(false);
            this.ledGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ledBlinkIntervalNumericEdit)).EndInit();
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


        private void ledStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
	        displayLed.LedStyle = (LedStyle)ledStylesComboBox.SelectedItem;
        }

        private void ledBackgroundTransparent_CheckedChanged(object sender, System.EventArgs e)
        {
            if(ledBackgroundTransparentCheckBox.Checked)
	            displayLed.BackColor = Color.Transparent;
            else
	            displayLed.BackColor = BackColor;
        }

        private void switchStyles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            displaySwitch.SwitchStyle = (SwitchStyle)switchStylesComboBox.SelectedItem;
        }

        private void ledResponseModes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int x;
            string item = ledResponseModesComboBox.SelectedItem as string;
            if(item == null)
                return;
            for(x = 0; x < ledResponseModesComboBox.Items.Count; x++)
	            if(item == Enum.GetNames(typeof(BooleanInteractionMode))[x])
		            displayLed.InteractionMode = (BooleanInteractionMode)((int[])Enum.GetValues(typeof(BooleanInteractionMode)))[x];
        }

        private void switchResponseModes_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int x;
            string item = switchResponseModesComboBox.SelectedItem as string;
            if(item == null)
                return;
            for(x = 0; x < switchResponseModesComboBox.Items.Count; x++)
	            if(item == Enum.GetNames(typeof(BooleanInteractionMode))[x])
		            displaySwitch.InteractionMode = (BooleanInteractionMode)((int[])Enum.GetValues(typeof(BooleanInteractionMode)))[x];
        }

        private void ledBlinkStyles_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            int x;
            string item = ledBlinkStylesComboBox.SelectedItem as string;
            if(item == null)
                return;
            for(x = 0; x < ledBlinkStylesComboBox.Items.Count; x++)
                if(item == Enum.GetNames(typeof(LedBlinkMode))[x])
                    displayLed.BlinkMode = (LedBlinkMode)((int[])Enum.GetValues(typeof(LedBlinkMode)))[x];
        }

        private void ledOnColorButton_Click(object sender, System.EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                onColorLed.OffColor = colorDialog.Color;
                displayLed.OnColor = colorDialog.Color;
            }
        }

        private void ledOffColorButton_Click(object sender, System.EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                offColorLed.OffColor = colorDialog.Color;
                displayLed.OffColor = colorDialog.Color;
            }
        }

        private void led1_ValueChanged(object sender, System.EventArgs e)
        {
            ledStateTextBox.Text = displayLed.Value.ToString();
        }

        private void switchOnColorButton_Click(object sender, System.EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                switchOnColorLed.OffColor = colorDialog.Color;
                displaySwitch.OnColor = colorDialog.Color;
            }
        }

        private void switchOffColorButton_Click(object sender, System.EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                switchOffColorLed.OffColor = colorDialog.Color;
                displaySwitch.OffColor = colorDialog.Color;
            }
        }

        private void switchBackgroundTransparent_CheckedChanged(object sender, System.EventArgs e)
        {
            if(switchBackgroundTransparentCheckBox.Checked)
                displaySwitch.BackColor = Color.Transparent;
            else
                displaySwitch.BackColor = BackColor;
        }

        private void seeTransparent_CheckedChanged(object sender, System.EventArgs e)
        { 
            if(seeTransparentCheckBox.Checked)
                BackgroundImage = image;
            else
                BackgroundImage = null;
        }

        private void switch1_ValueChanged(object sender, System.EventArgs e)
        {
            switchStateTextBox.Text = displaySwitch.Value.ToString();
        }

        private void ledBlinkInterval_AfterChangeValue(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            displayLed.BlinkInterval = TimeSpan.FromMilliseconds(ledBlinkIntervalNumericEdit.Value);
        }
    }
}
