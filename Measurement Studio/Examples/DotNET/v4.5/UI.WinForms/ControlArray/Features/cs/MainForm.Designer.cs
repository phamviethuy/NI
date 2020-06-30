namespace NationalInstruments.Examples.Features
{
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
            this.layoutModePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.layoutNumericEditArray = new NationalInstruments.UI.WindowsForms.NumericEditArray();
            this.layoutModeLabel = new System.Windows.Forms.Label();
            this.scalingSwitchArray = new NationalInstruments.UI.WindowsForms.SwitchArray();
            this.scalingLedArray = new NationalInstruments.UI.WindowsForms.LedArray();
            this.scaleModePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.scaleModeLabel = new System.Windows.Forms.Label();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.valuesLabel = new System.Windows.Forms.Label();
            this.booleanComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.selectValueLabel = new System.Windows.Forms.Label();
            this.automaticScaleModePanel = new System.Windows.Forms.Panel();
            this.featuresTabControl = new System.Windows.Forms.TabControl();
            this.scalingTabPage = new System.Windows.Forms.TabPage();
            this.automaticScaleModeGroupBox = new System.Windows.Forms.GroupBox();
            this.layoutTabPage = new System.Windows.Forms.TabPage();
            this.indexingGroupBox = new System.Windows.Forms.GroupBox();
            this.indexLabel = new System.Windows.Forms.Label();
            this.indexComboBox = new System.Windows.Forms.ComboBox();
            this.rangePropertyEditorLabel = new System.Windows.Forms.Label();
            this.rangePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            this.layoutSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.itemTemplateLabel = new System.Windows.Forms.Label();
            this.itemTemplatePropertyEditor = new NationalInstruments.UI.WindowsForms.PropertyEditor();
            ((System.ComponentModel.ISupportInitialize)(this.layoutNumericEditArray.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingSwitchArray.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingLedArray.ItemTemplate)).BeginInit();
            this.automaticScaleModePanel.SuspendLayout();
            this.featuresTabControl.SuspendLayout();
            this.scalingTabPage.SuspendLayout();
            this.automaticScaleModeGroupBox.SuspendLayout();
            this.layoutTabPage.SuspendLayout();
            this.indexingGroupBox.SuspendLayout();
            this.layoutSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutModePropertyEditor
            // 
            this.layoutModePropertyEditor.Location = new System.Drawing.Point(13, 32);
            this.layoutModePropertyEditor.Name = "layoutModePropertyEditor";
            this.layoutModePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.layoutModePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.layoutNumericEditArray, "LayoutMode");
            this.layoutModePropertyEditor.TabIndex = 2;
            // 
            // layoutNumericEditArray
            // 
            // 
            // 
            // 
            this.layoutNumericEditArray.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.layoutNumericEditArray.ItemTemplate.Name = "";
            this.layoutNumericEditArray.ItemTemplate.TabIndex = 0;
            this.layoutNumericEditArray.Location = new System.Drawing.Point(19, 16);
            this.layoutNumericEditArray.Name = "layoutNumericEditArray";
            this.layoutNumericEditArray.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(3);
            this.layoutNumericEditArray.Size = new System.Drawing.Size(141, 66);
            this.layoutNumericEditArray.TabIndex = 6;
            // 
            // layoutModeLabel
            // 
            this.layoutModeLabel.AutoSize = true;
            this.layoutModeLabel.Location = new System.Drawing.Point(10, 15);
            this.layoutModeLabel.Name = "layoutModeLabel";
            this.layoutModeLabel.Size = new System.Drawing.Size(72, 13);
            this.layoutModeLabel.TabIndex = 3;
            this.layoutModeLabel.Text = "Layout Mode:";
            // 
            // scalingSwitchArray
            // 
            // 
            // 
            // 
            this.scalingSwitchArray.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.scalingSwitchArray.ItemTemplate.Name = "";
            this.scalingSwitchArray.ItemTemplate.Size = new System.Drawing.Size(48, 80);
            this.scalingSwitchArray.ItemTemplate.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.scalingSwitchArray.ItemTemplate.TabIndex = 0;
            this.scalingSwitchArray.LayoutMode = NationalInstruments.UI.ControlArrayLayoutMode.Horizontal;
            this.scalingSwitchArray.Location = new System.Drawing.Point(6, 77);
            this.scalingSwitchArray.Name = "scalingSwitchArray";
            this.scalingSwitchArray.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(3);
            this.scalingSwitchArray.Size = new System.Drawing.Size(154, 97);
            this.scalingSwitchArray.TabIndex = 4;
            this.scalingSwitchArray.ValuesChanged += new System.EventHandler(this.OnScalingSwitchArrayValuesChanged);
            // 
            // scalingLedArray
            // 
            // 
            // 
            // 
            this.scalingLedArray.ItemTemplate.LedStyle = NationalInstruments.UI.LedStyle.Round3D;
            this.scalingLedArray.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.scalingLedArray.ItemTemplate.Name = "";
            this.scalingLedArray.ItemTemplate.Size = new System.Drawing.Size(48, 48);
            this.scalingLedArray.ItemTemplate.TabIndex = 0;
            this.scalingLedArray.LayoutMode = NationalInstruments.UI.ControlArrayLayoutMode.Horizontal;
            this.scalingLedArray.Location = new System.Drawing.Point(6, 6);
            this.scalingLedArray.Name = "scalingLedArray";
            this.scalingLedArray.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(3);
            this.scalingLedArray.Size = new System.Drawing.Size(154, 65);
            this.scalingLedArray.TabIndex = 5;
            // 
            // scaleModePropertyEditor
            // 
            this.scaleModePropertyEditor.Location = new System.Drawing.Point(269, 15);
            this.scaleModePropertyEditor.Name = "scaleModePropertyEditor";
            this.scaleModePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.scaleModePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.scalingSwitchArray, "ScaleMode");
            this.scaleModePropertyEditor.TabIndex = 7;
            this.scaleModePropertyEditor.SourceValueChanged += new System.EventHandler(this.OnScaleModePropertyEditorSourceValueChanged);
            // 
            // scaleModeLabel
            // 
            this.scaleModeLabel.AutoSize = true;
            this.scaleModeLabel.Location = new System.Drawing.Point(185, 18);
            this.scaleModeLabel.Name = "scaleModeLabel";
            this.scaleModeLabel.Size = new System.Drawing.Size(67, 13);
            this.scaleModeLabel.TabIndex = 8;
            this.scaleModeLabel.Text = "Scale Mode:";
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(12, 70);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(120, 95);
            this.valuesListBox.TabIndex = 9;
            // 
            // valuesLabel
            // 
            this.valuesLabel.AutoSize = true;
            this.valuesLabel.Location = new System.Drawing.Point(9, 53);
            this.valuesLabel.Name = "valuesLabel";
            this.valuesLabel.Size = new System.Drawing.Size(42, 13);
            this.valuesLabel.TabIndex = 10;
            this.valuesLabel.Text = "Values:";
            // 
            // booleanComboBox
            // 
            this.booleanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.booleanComboBox.FormattingEnabled = true;
            this.booleanComboBox.Items.AddRange(new object[] {
            "True",
            "False"});
            this.booleanComboBox.Location = new System.Drawing.Point(12, 21);
            this.booleanComboBox.Name = "booleanComboBox";
            this.booleanComboBox.Size = new System.Drawing.Size(121, 21);
            this.booleanComboBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(139, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(139, 70);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 13;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.OnRemoveButtonClick);
            // 
            // selectValueLabel
            // 
            this.selectValueLabel.AutoSize = true;
            this.selectValueLabel.Location = new System.Drawing.Point(9, 4);
            this.selectValueLabel.Name = "selectValueLabel";
            this.selectValueLabel.Size = new System.Drawing.Size(70, 13);
            this.selectValueLabel.TabIndex = 14;
            this.selectValueLabel.Text = "Select Value:";
            // 
            // automaticScaleModePanel
            // 
            this.automaticScaleModePanel.Controls.Add(this.selectValueLabel);
            this.automaticScaleModePanel.Controls.Add(this.valuesListBox);
            this.automaticScaleModePanel.Controls.Add(this.removeButton);
            this.automaticScaleModePanel.Controls.Add(this.valuesLabel);
            this.automaticScaleModePanel.Controls.Add(this.addButton);
            this.automaticScaleModePanel.Controls.Add(this.booleanComboBox);
            this.automaticScaleModePanel.Location = new System.Drawing.Point(8, 12);
            this.automaticScaleModePanel.Name = "automaticScaleModePanel";
            this.automaticScaleModePanel.Size = new System.Drawing.Size(228, 169);
            this.automaticScaleModePanel.TabIndex = 15;
            // 
            // featuresTabControl
            // 
            this.featuresTabControl.Controls.Add(this.scalingTabPage);
            this.featuresTabControl.Controls.Add(this.layoutTabPage);
            this.featuresTabControl.Location = new System.Drawing.Point(12, 12);
            this.featuresTabControl.Name = "featuresTabControl";
            this.featuresTabControl.SelectedIndex = 0;
            this.featuresTabControl.Size = new System.Drawing.Size(421, 255);
            this.featuresTabControl.TabIndex = 16;
            // 
            // scalingTabPage
            // 
            this.scalingTabPage.Controls.Add(this.automaticScaleModeGroupBox);
            this.scalingTabPage.Controls.Add(this.scalingLedArray);
            this.scalingTabPage.Controls.Add(this.scalingSwitchArray);
            this.scalingTabPage.Controls.Add(this.scaleModeLabel);
            this.scalingTabPage.Controls.Add(this.scaleModePropertyEditor);
            this.scalingTabPage.Location = new System.Drawing.Point(4, 22);
            this.scalingTabPage.Name = "scalingTabPage";
            this.scalingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.scalingTabPage.Size = new System.Drawing.Size(413, 229);
            this.scalingTabPage.TabIndex = 0;
            this.scalingTabPage.Text = "Scaling";
            this.scalingTabPage.UseVisualStyleBackColor = true;
            // 
            // automaticScaleModeGroupBox
            // 
            this.automaticScaleModeGroupBox.Controls.Add(this.automaticScaleModePanel);
            this.automaticScaleModeGroupBox.Location = new System.Drawing.Point(166, 43);
            this.automaticScaleModeGroupBox.Name = "automaticScaleModeGroupBox";
            this.automaticScaleModeGroupBox.Size = new System.Drawing.Size(240, 185);
            this.automaticScaleModeGroupBox.TabIndex = 16;
            this.automaticScaleModeGroupBox.TabStop = false;
            this.automaticScaleModeGroupBox.Text = "Automatic Scale Mode Settings";
            // 
            // layoutTabPage
            // 
            this.layoutTabPage.Controls.Add(this.indexingGroupBox);
            this.layoutTabPage.Controls.Add(this.layoutSettingsGroupBox);
            this.layoutTabPage.Controls.Add(this.layoutNumericEditArray);
            this.layoutTabPage.Location = new System.Drawing.Point(4, 22);
            this.layoutTabPage.Name = "layoutTabPage";
            this.layoutTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.layoutTabPage.Size = new System.Drawing.Size(413, 229);
            this.layoutTabPage.TabIndex = 1;
            this.layoutTabPage.Text = "Layout";
            this.layoutTabPage.UseVisualStyleBackColor = true;
            // 
            // indexingGroupBox
            // 
            this.indexingGroupBox.Controls.Add(this.indexLabel);
            this.indexingGroupBox.Controls.Add(this.indexComboBox);
            this.indexingGroupBox.Controls.Add(this.rangePropertyEditorLabel);
            this.indexingGroupBox.Controls.Add(this.rangePropertyEditor);
            this.indexingGroupBox.Location = new System.Drawing.Point(222, 104);
            this.indexingGroupBox.Name = "indexingGroupBox";
            this.indexingGroupBox.Size = new System.Drawing.Size(169, 110);
            this.indexingGroupBox.TabIndex = 0;
            this.indexingGroupBox.TabStop = false;
            this.indexingGroupBox.Text = "Indexing";
            // 
            // indexLabel
            // 
            this.indexLabel.AutoSize = true;
            this.indexLabel.Location = new System.Drawing.Point(6, 15);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(36, 13);
            this.indexLabel.TabIndex = 11;
            this.indexLabel.Text = "Index:";
            // 
            // indexComboBox
            // 
            this.indexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.indexComboBox.FormattingEnabled = true;
            this.indexComboBox.Location = new System.Drawing.Point(9, 32);
            this.indexComboBox.Name = "indexComboBox";
            this.indexComboBox.Size = new System.Drawing.Size(121, 21);
            this.indexComboBox.TabIndex = 9;
            this.indexComboBox.SelectedIndexChanged += new System.EventHandler(this.OnIndexComboboxSelectedIndexChanged);
            // 
            // rangePropertyEditorLabel
            // 
            this.rangePropertyEditorLabel.AutoSize = true;
            this.rangePropertyEditorLabel.Location = new System.Drawing.Point(6, 64);
            this.rangePropertyEditorLabel.Name = "rangePropertyEditorLabel";
            this.rangePropertyEditorLabel.Size = new System.Drawing.Size(42, 13);
            this.rangePropertyEditorLabel.TabIndex = 12;
            this.rangePropertyEditorLabel.Text = "Range:";
            // 
            // rangePropertyEditor
            // 
            this.rangePropertyEditor.Location = new System.Drawing.Point(9, 81);
            this.rangePropertyEditor.Name = "rangePropertyEditor";
            this.rangePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.rangePropertyEditor.TabIndex = 10;
            // 
            // layoutSettingsGroupBox
            // 
            this.layoutSettingsGroupBox.Controls.Add(this.layoutModeLabel);
            this.layoutSettingsGroupBox.Controls.Add(this.layoutModePropertyEditor);
            this.layoutSettingsGroupBox.Controls.Add(this.itemTemplateLabel);
            this.layoutSettingsGroupBox.Controls.Add(this.itemTemplatePropertyEditor);
            this.layoutSettingsGroupBox.Location = new System.Drawing.Point(20, 104);
            this.layoutSettingsGroupBox.Name = "layoutSettingsGroupBox";
            this.layoutSettingsGroupBox.Size = new System.Drawing.Size(169, 110);
            this.layoutSettingsGroupBox.TabIndex = 13;
            this.layoutSettingsGroupBox.TabStop = false;
            this.layoutSettingsGroupBox.Text = "Settings";
            // 
            // itemTemplateLabel
            // 
            this.itemTemplateLabel.AutoSize = true;
            this.itemTemplateLabel.Location = new System.Drawing.Point(10, 64);
            this.itemTemplateLabel.Name = "itemTemplateLabel";
            this.itemTemplateLabel.Size = new System.Drawing.Size(77, 13);
            this.itemTemplateLabel.TabIndex = 7;
            this.itemTemplateLabel.Text = "Item Template:";
            // 
            // itemTemplatePropertyEditor
            // 
            this.itemTemplatePropertyEditor.BackColor = System.Drawing.SystemColors.Control;
            this.itemTemplatePropertyEditor.Location = new System.Drawing.Point(13, 81);
            this.itemTemplatePropertyEditor.Name = "itemTemplatePropertyEditor";
            this.itemTemplatePropertyEditor.Size = new System.Drawing.Size(120, 20);
            this.itemTemplatePropertyEditor.Source = new NationalInstruments.UI.PropertyEditorSource(this.layoutNumericEditArray, "ItemTemplate");
            this.itemTemplatePropertyEditor.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 276);
            this.Controls.Add(this.featuresTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Control Array Features";
            ((System.ComponentModel.ISupportInitialize)(this.layoutNumericEditArray.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingSwitchArray.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scalingLedArray.ItemTemplate)).EndInit();
            this.automaticScaleModePanel.ResumeLayout(false);
            this.automaticScaleModePanel.PerformLayout();
            this.featuresTabControl.ResumeLayout(false);
            this.scalingTabPage.ResumeLayout(false);
            this.scalingTabPage.PerformLayout();
            this.automaticScaleModeGroupBox.ResumeLayout(false);
            this.layoutTabPage.ResumeLayout(false);
            this.indexingGroupBox.ResumeLayout(false);
            this.indexingGroupBox.PerformLayout();
            this.layoutSettingsGroupBox.ResumeLayout(false);
            this.layoutSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.PropertyEditor layoutModePropertyEditor;
        private System.Windows.Forms.Label layoutModeLabel;
        private NationalInstruments.UI.WindowsForms.SwitchArray scalingSwitchArray;
        private NationalInstruments.UI.WindowsForms.LedArray scalingLedArray;
        private NationalInstruments.UI.WindowsForms.NumericEditArray layoutNumericEditArray;
        private NationalInstruments.UI.WindowsForms.PropertyEditor scaleModePropertyEditor;
        private System.Windows.Forms.Label scaleModeLabel;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label valuesLabel;
        private System.Windows.Forms.ComboBox booleanComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label selectValueLabel;
        private System.Windows.Forms.Panel automaticScaleModePanel;
        private System.Windows.Forms.TabControl featuresTabControl;
        private System.Windows.Forms.TabPage scalingTabPage;
        private System.Windows.Forms.TabPage layoutTabPage;
        private NationalInstruments.UI.WindowsForms.PropertyEditor itemTemplatePropertyEditor;
        private System.Windows.Forms.Label itemTemplateLabel;
        private NationalInstruments.UI.WindowsForms.PropertyEditor rangePropertyEditor;
        private System.Windows.Forms.ComboBox indexComboBox;
        private System.Windows.Forms.Label rangePropertyEditorLabel;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.GroupBox automaticScaleModeGroupBox;
        private System.Windows.Forms.GroupBox indexingGroupBox;
        private System.Windows.Forms.GroupBox layoutSettingsGroupBox;

    }
}

