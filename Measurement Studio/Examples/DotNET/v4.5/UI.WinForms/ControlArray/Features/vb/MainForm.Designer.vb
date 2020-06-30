<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.layoutModePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.layoutNumericEditArray = New NationalInstruments.UI.WindowsForms.NumericEditArray
        Me.layoutModeLabel = New System.Windows.Forms.Label
        Me.scalingSwitchArray = New NationalInstruments.UI.WindowsForms.SwitchArray
        Me.scalingLedArray = New NationalInstruments.UI.WindowsForms.LedArray
        Me.scaleModePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.scaleModeLabel = New System.Windows.Forms.Label
        Me.valuesListBox = New System.Windows.Forms.ListBox
        Me.valuesLabel = New System.Windows.Forms.Label
        Me.booleanComboBox = New System.Windows.Forms.ComboBox
        Me.addButton = New System.Windows.Forms.Button
        Me.removeButton = New System.Windows.Forms.Button
        Me.selectValueLabel = New System.Windows.Forms.Label
        Me.automaticScaleModePanel = New System.Windows.Forms.Panel
        Me.featuresTabControl = New System.Windows.Forms.TabControl
        Me.scalingTabPage = New System.Windows.Forms.TabPage
        Me.automaticScaleModeGroupBox = New System.Windows.Forms.GroupBox
        Me.layoutTabPage = New System.Windows.Forms.TabPage
        Me.indexingGroupBox = New System.Windows.Forms.GroupBox
        Me.indexLabel = New System.Windows.Forms.Label
        Me.indexComboBox = New System.Windows.Forms.ComboBox
        Me.rangePropertyEditorLabel = New System.Windows.Forms.Label
        Me.rangePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.layoutSettingsGroupBox = New System.Windows.Forms.GroupBox
        Me.itemTemplateLabel = New System.Windows.Forms.Label
        Me.itemTemplatePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        CType(Me.layoutNumericEditArray.ItemTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scalingSwitchArray.ItemTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scalingLedArray.ItemTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.automaticScaleModePanel.SuspendLayout()
        Me.featuresTabControl.SuspendLayout()
        Me.scalingTabPage.SuspendLayout()
        Me.automaticScaleModeGroupBox.SuspendLayout()
        Me.layoutTabPage.SuspendLayout()
        Me.indexingGroupBox.SuspendLayout()
        Me.layoutSettingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'layoutModePropertyEditor
        '
        Me.layoutModePropertyEditor.Location = New System.Drawing.Point(13, 32)
        Me.layoutModePropertyEditor.Name = "layoutModePropertyEditor"
        Me.layoutModePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.layoutModePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.layoutNumericEditArray, "LayoutMode")
        Me.layoutModePropertyEditor.TabIndex = 2
        '
        'layoutNumericEditArray
        '
        '
        '
        '
        Me.layoutNumericEditArray.ItemTemplate.Location = New System.Drawing.Point(0, 0)
        Me.layoutNumericEditArray.ItemTemplate.Name = ""
        Me.layoutNumericEditArray.ItemTemplate.TabIndex = 0
        Me.layoutNumericEditArray.Location = New System.Drawing.Point(19, 16)
        Me.layoutNumericEditArray.Name = "layoutNumericEditArray"
        Me.layoutNumericEditArray.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(3)
        Me.layoutNumericEditArray.Size = New System.Drawing.Size(141, 66)
        Me.layoutNumericEditArray.TabIndex = 6
        '
        'layoutModeLabel
        '
        Me.layoutModeLabel.AutoSize = True
        Me.layoutModeLabel.Location = New System.Drawing.Point(10, 16)
        Me.layoutModeLabel.Name = "layoutModeLabel"
        Me.layoutModeLabel.Size = New System.Drawing.Size(72, 13)
        Me.layoutModeLabel.TabIndex = 3
        Me.layoutModeLabel.Text = "Layout Mode:"
        '
        'scalingSwitchArray
        '
        '
        '
        '
        Me.scalingSwitchArray.ItemTemplate.Location = New System.Drawing.Point(0, 0)
        Me.scalingSwitchArray.ItemTemplate.Name = ""
        Me.scalingSwitchArray.ItemTemplate.Size = New System.Drawing.Size(48, 80)
        Me.scalingSwitchArray.ItemTemplate.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D
        Me.scalingSwitchArray.ItemTemplate.TabIndex = 0
        Me.scalingSwitchArray.LayoutMode = NationalInstruments.UI.ControlArrayLayoutMode.Horizontal
        Me.scalingSwitchArray.Location = New System.Drawing.Point(6, 77)
        Me.scalingSwitchArray.Name = "scalingSwitchArray"
        Me.scalingSwitchArray.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(3)
        Me.scalingSwitchArray.Size = New System.Drawing.Size(154, 97)
        Me.scalingSwitchArray.TabIndex = 4
        '
        'scalingLedArray
        '
        '
        '
        '
        Me.scalingLedArray.ItemTemplate.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.scalingLedArray.ItemTemplate.Location = New System.Drawing.Point(0, 0)
        Me.scalingLedArray.ItemTemplate.Name = ""
        Me.scalingLedArray.ItemTemplate.Size = New System.Drawing.Size(48, 48)
        Me.scalingLedArray.ItemTemplate.TabIndex = 0
        Me.scalingLedArray.LayoutMode = NationalInstruments.UI.ControlArrayLayoutMode.Horizontal
        Me.scalingLedArray.Location = New System.Drawing.Point(6, 6)
        Me.scalingLedArray.Name = "scalingLedArray"
        Me.scalingLedArray.ScaleMode = NationalInstruments.UI.ControlArrayScaleMode.CreateFixedMode(3)
        Me.scalingLedArray.Size = New System.Drawing.Size(154, 65)
        Me.scalingLedArray.TabIndex = 5
        '
        'scaleModePropertyEditor
        '
        Me.scaleModePropertyEditor.Location = New System.Drawing.Point(269, 15)
        Me.scaleModePropertyEditor.Name = "scaleModePropertyEditor"
        Me.scaleModePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.scaleModePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.scalingSwitchArray, "ScaleMode")
        Me.scaleModePropertyEditor.TabIndex = 7
        '
        'scaleModeLabel
        '
        Me.scaleModeLabel.AutoSize = True
        Me.scaleModeLabel.Location = New System.Drawing.Point(185, 18)
        Me.scaleModeLabel.Name = "scaleModeLabel"
        Me.scaleModeLabel.Size = New System.Drawing.Size(67, 13)
        Me.scaleModeLabel.TabIndex = 8
        Me.scaleModeLabel.Text = "Scale Mode:"
        '
        'valuesListBox
        '
        Me.valuesListBox.FormattingEnabled = True
        Me.valuesListBox.Location = New System.Drawing.Point(12, 70)
        Me.valuesListBox.Name = "valuesListBox"
        Me.valuesListBox.Size = New System.Drawing.Size(120, 95)
        Me.valuesListBox.TabIndex = 9
        '
        'valuesLabel
        '
        Me.valuesLabel.AutoSize = True
        Me.valuesLabel.Location = New System.Drawing.Point(9, 53)
        Me.valuesLabel.Name = "valuesLabel"
        Me.valuesLabel.Size = New System.Drawing.Size(42, 13)
        Me.valuesLabel.TabIndex = 10
        Me.valuesLabel.Text = "Values:"
        '
        'booleanComboBox
        '
        Me.booleanComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.booleanComboBox.FormattingEnabled = True
        Me.booleanComboBox.Items.AddRange(New Object() {"True", "False"})
        Me.booleanComboBox.Location = New System.Drawing.Point(12, 21)
        Me.booleanComboBox.Name = "booleanComboBox"
        Me.booleanComboBox.Size = New System.Drawing.Size(121, 21)
        Me.booleanComboBox.TabIndex = 11
        '
        'addButton
        '
        Me.addButton.Location = New System.Drawing.Point(139, 18)
        Me.addButton.Name = "addButton"
        Me.addButton.Size = New System.Drawing.Size(75, 23)
        Me.addButton.TabIndex = 12
        Me.addButton.Text = "Add"
        Me.addButton.UseVisualStyleBackColor = True
        '
        'removeButton
        '
        Me.removeButton.Location = New System.Drawing.Point(139, 70)
        Me.removeButton.Name = "removeButton"
        Me.removeButton.Size = New System.Drawing.Size(75, 23)
        Me.removeButton.TabIndex = 13
        Me.removeButton.Text = "Remove"
        Me.removeButton.UseVisualStyleBackColor = True
        '
        'selectValueLabel
        '
        Me.selectValueLabel.AutoSize = True
        Me.selectValueLabel.Location = New System.Drawing.Point(9, 4)
        Me.selectValueLabel.Name = "selectValueLabel"
        Me.selectValueLabel.Size = New System.Drawing.Size(70, 13)
        Me.selectValueLabel.TabIndex = 14
        Me.selectValueLabel.Text = "Select Value:"
        '
        'automaticScaleModePanel
        '
        Me.automaticScaleModePanel.Controls.Add(Me.selectValueLabel)
        Me.automaticScaleModePanel.Controls.Add(Me.valuesListBox)
        Me.automaticScaleModePanel.Controls.Add(Me.removeButton)
        Me.automaticScaleModePanel.Controls.Add(Me.valuesLabel)
        Me.automaticScaleModePanel.Controls.Add(Me.addButton)
        Me.automaticScaleModePanel.Controls.Add(Me.booleanComboBox)
        Me.automaticScaleModePanel.Location = New System.Drawing.Point(8, 12)
        Me.automaticScaleModePanel.Name = "automaticScaleModePanel"
        Me.automaticScaleModePanel.Size = New System.Drawing.Size(228, 169)
        Me.automaticScaleModePanel.TabIndex = 15
        '
        'featuresTabControl
        '
        Me.featuresTabControl.Controls.Add(Me.scalingTabPage)
        Me.featuresTabControl.Controls.Add(Me.layoutTabPage)
        Me.featuresTabControl.Location = New System.Drawing.Point(12, 12)
        Me.featuresTabControl.Name = "featuresTabControl"
        Me.featuresTabControl.SelectedIndex = 0
        Me.featuresTabControl.Size = New System.Drawing.Size(421, 255)
        Me.featuresTabControl.TabIndex = 16
        '
        'scalingTabPage
        '
        Me.scalingTabPage.Controls.Add(Me.automaticScaleModeGroupBox)
        Me.scalingTabPage.Controls.Add(Me.scalingLedArray)
        Me.scalingTabPage.Controls.Add(Me.scalingSwitchArray)
        Me.scalingTabPage.Controls.Add(Me.scaleModeLabel)
        Me.scalingTabPage.Controls.Add(Me.scaleModePropertyEditor)
        Me.scalingTabPage.Location = New System.Drawing.Point(4, 22)
        Me.scalingTabPage.Name = "scalingTabPage"
        Me.scalingTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.scalingTabPage.Size = New System.Drawing.Size(413, 229)
        Me.scalingTabPage.TabIndex = 0
        Me.scalingTabPage.Text = "Scaling"
        Me.scalingTabPage.UseVisualStyleBackColor = True
        '
        'automaticScaleModeGroupBox
        '
        Me.automaticScaleModeGroupBox.Controls.Add(Me.automaticScaleModePanel)
        Me.automaticScaleModeGroupBox.Location = New System.Drawing.Point(166, 43)
        Me.automaticScaleModeGroupBox.Name = "automaticScaleModeGroupBox"
        Me.automaticScaleModeGroupBox.Size = New System.Drawing.Size(240, 185)
        Me.automaticScaleModeGroupBox.TabIndex = 16
        Me.automaticScaleModeGroupBox.TabStop = False
        Me.automaticScaleModeGroupBox.Text = "Automatic Scale Mode Settings"
        '
        'layoutTabPage
        '
        Me.layoutTabPage.Controls.Add(Me.indexingGroupBox)
        Me.layoutTabPage.Controls.Add(Me.layoutSettingsGroupBox)
        Me.layoutTabPage.Controls.Add(Me.layoutNumericEditArray)
        Me.layoutTabPage.Location = New System.Drawing.Point(4, 22)
        Me.layoutTabPage.Name = "layoutTabPage"
        Me.layoutTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.layoutTabPage.Size = New System.Drawing.Size(413, 229)
        Me.layoutTabPage.TabIndex = 1
        Me.layoutTabPage.Text = "Layout"
        Me.layoutTabPage.UseVisualStyleBackColor = True
        '
        'indexingGroupBox
        '
        Me.indexingGroupBox.Controls.Add(Me.indexLabel)
        Me.indexingGroupBox.Controls.Add(Me.indexComboBox)
        Me.indexingGroupBox.Controls.Add(Me.rangePropertyEditorLabel)
        Me.indexingGroupBox.Controls.Add(Me.rangePropertyEditor)
        Me.indexingGroupBox.Location = New System.Drawing.Point(222, 104)
        Me.indexingGroupBox.Name = "indexingGroupBox"
        Me.indexingGroupBox.Size = New System.Drawing.Size(169, 110)
        Me.indexingGroupBox.TabIndex = 0
        Me.indexingGroupBox.TabStop = False
        Me.indexingGroupBox.Text = "Indexing"
        '
        'indexLabel
        '
        Me.indexLabel.AutoSize = True
        Me.indexLabel.Location = New System.Drawing.Point(6, 16)
        Me.indexLabel.Name = "indexLabel"
        Me.indexLabel.Size = New System.Drawing.Size(36, 13)
        Me.indexLabel.TabIndex = 11
        Me.indexLabel.Text = "Index:"
        '
        'indexComboBox
        '
        Me.indexComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.indexComboBox.FormattingEnabled = True
        Me.indexComboBox.Location = New System.Drawing.Point(9, 32)
        Me.indexComboBox.Name = "indexComboBox"
        Me.indexComboBox.Size = New System.Drawing.Size(121, 21)
        Me.indexComboBox.TabIndex = 9
        '
        'rangePropertyEditorLabel
        '
        Me.rangePropertyEditorLabel.AutoSize = True
        Me.rangePropertyEditorLabel.Location = New System.Drawing.Point(6, 65)
        Me.rangePropertyEditorLabel.Name = "rangePropertyEditorLabel"
        Me.rangePropertyEditorLabel.Size = New System.Drawing.Size(42, 13)
        Me.rangePropertyEditorLabel.TabIndex = 12
        Me.rangePropertyEditorLabel.Text = "Range:"
        '
        'rangePropertyEditor
        '
        Me.rangePropertyEditor.Location = New System.Drawing.Point(9, 81)
        Me.rangePropertyEditor.Name = "rangePropertyEditor"
        Me.rangePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.rangePropertyEditor.TabIndex = 10
        '
        'layoutSettingsGroupBox
        '
        Me.layoutSettingsGroupBox.Controls.Add(Me.layoutModeLabel)
        Me.layoutSettingsGroupBox.Controls.Add(Me.layoutModePropertyEditor)
        Me.layoutSettingsGroupBox.Controls.Add(Me.itemTemplateLabel)
        Me.layoutSettingsGroupBox.Controls.Add(Me.itemTemplatePropertyEditor)
        Me.layoutSettingsGroupBox.Location = New System.Drawing.Point(20, 104)
        Me.layoutSettingsGroupBox.Name = "layoutSettingsGroupBox"
        Me.layoutSettingsGroupBox.Size = New System.Drawing.Size(169, 110)
        Me.layoutSettingsGroupBox.TabIndex = 13
        Me.layoutSettingsGroupBox.TabStop = False
        Me.layoutSettingsGroupBox.Text = "Settings"
        '
        'itemTemplateLabel
        '
        Me.itemTemplateLabel.AutoSize = True
        Me.itemTemplateLabel.Location = New System.Drawing.Point(10, 65)
        Me.itemTemplateLabel.Name = "itemTemplateLabel"
        Me.itemTemplateLabel.Size = New System.Drawing.Size(77, 13)
        Me.itemTemplateLabel.TabIndex = 7
        Me.itemTemplateLabel.Text = "Item Template:"
        '
        'itemTemplatePropertyEditor
        '
        Me.itemTemplatePropertyEditor.BackColor = System.Drawing.SystemColors.Control
        Me.itemTemplatePropertyEditor.Location = New System.Drawing.Point(13, 81)
        Me.itemTemplatePropertyEditor.Name = "itemTemplatePropertyEditor"
        Me.itemTemplatePropertyEditor.Size = New System.Drawing.Size(120, 20)
        Me.itemTemplatePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.layoutNumericEditArray, "ItemTemplate")
        Me.itemTemplatePropertyEditor.TabIndex = 8
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 276)
        Me.Controls.Add(Me.featuresTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Control Array Features"
        CType(Me.layoutNumericEditArray.ItemTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scalingSwitchArray.ItemTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scalingLedArray.ItemTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.automaticScaleModePanel.ResumeLayout(False)
        Me.automaticScaleModePanel.PerformLayout()
        Me.featuresTabControl.ResumeLayout(False)
        Me.scalingTabPage.ResumeLayout(False)
        Me.scalingTabPage.PerformLayout()
        Me.automaticScaleModeGroupBox.ResumeLayout(False)
        Me.layoutTabPage.ResumeLayout(False)
        Me.indexingGroupBox.ResumeLayout(False)
        Me.indexingGroupBox.PerformLayout()
        Me.layoutSettingsGroupBox.ResumeLayout(False)
        Me.layoutSettingsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Dim layoutModePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Dim layoutModeLabel As System.Windows.Forms.Label
    Dim scalingSwitchArray As NationalInstruments.UI.WindowsForms.SwitchArray
    Dim scalingLedArray As NationalInstruments.UI.WindowsForms.LedArray
    Dim layoutNumericEditArray As NationalInstruments.UI.WindowsForms.NumericEditArray
    Dim scaleModePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Dim scaleModeLabel As System.Windows.Forms.Label
    Dim valuesListBox As System.Windows.Forms.ListBox
    Dim valuesLabel As System.Windows.Forms.Label
    Dim booleanComboBox As System.Windows.Forms.ComboBox
    Dim addButton As System.Windows.Forms.Button
    Dim removeButton As System.Windows.Forms.Button
    Dim selectValueLabel As System.Windows.Forms.Label
    Dim automaticScaleModePanel As System.Windows.Forms.Panel
    Dim featuresTabControl As System.Windows.Forms.TabControl
    Dim scalingTabPage As System.Windows.Forms.TabPage
    Dim layoutTabPage As System.Windows.Forms.TabPage
    Dim itemTemplatePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Dim itemTemplateLabel As System.Windows.Forms.Label
    Dim rangePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Dim indexComboBox As System.Windows.Forms.ComboBox
    Dim rangePropertyEditorLabel As System.Windows.Forms.Label
    Dim indexLabel As System.Windows.Forms.Label
    Dim automaticScaleModeGroupBox As System.Windows.Forms.GroupBox
    Dim indexingGroupBox As System.Windows.Forms.GroupBox
    Dim layoutSettingsGroupBox As System.Windows.Forms.GroupBox

End Class
