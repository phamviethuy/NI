Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports NationalInstruments.UI.WindowsForms
Imports System.Reflection
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Text.RegularExpressions
Imports NationalInstruments.UI


'/ <summary>
'/ Summary description for MainForm.
'/ </summary>
Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private colorDialog As System.Windows.Forms.ColorDialog
    Private WithEvents ledStylesComboBox As System.Windows.Forms.ComboBox
    Private WithEvents switchStylesComboBox As System.Windows.Forms.ComboBox
    Private WithEvents ledResponseModesComboBox As System.Windows.Forms.ComboBox
    Private WithEvents switchResponseModesComboBox As System.Windows.Forms.ComboBox
    Private ledStylesLabel As System.Windows.Forms.Label
    Private ledResponseModesLabel As System.Windows.Forms.Label
    Private WithEvents ledBlinkStylesComboBox As System.Windows.Forms.ComboBox
    Private WithEvents ledOnColorButton As System.Windows.Forms.Button
    Private WithEvents ledOffColorButton As System.Windows.Forms.Button
    Private onColorLed As NationalInstruments.UI.WindowsForms.Led
    Private offColorLed As NationalInstruments.UI.WindowsForms.Led
    Private ledStateTextBox As System.Windows.Forms.TextBox
    Private WithEvents switchBackgroundTransparentCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents switchOffColorButton As System.Windows.Forms.Button
    Private WithEvents switchOnColorButton As System.Windows.Forms.Button
    Private WithEvents seeTransparentCheckBox As System.Windows.Forms.CheckBox
    Private components As System.ComponentModel.IContainer
    Private switchOnColorLed As NationalInstruments.UI.WindowsForms.Led
    Private ledGroupBox As System.Windows.Forms.GroupBox
    Private switchOffColorLed As NationalInstruments.UI.WindowsForms.Led
    Private switchStateTextBox As System.Windows.Forms.TextBox
    Private WithEvents ledBackgroundTransparentCheckBox As System.Windows.Forms.CheckBox
    Private image As Image

    Public Sub New()

        InitializeComponent()

        transparentToolTip.SetToolTip(seeTransparentCheckBox, "Allows the BackgroundTransparent property of the Led" + ControlChars.Lf + " and Switch to be seen")

        Dim s As Stream = Me.GetType().Assembly.GetManifestResourceStream("NationalInstruments.Examples.BooleanFeatures.SplashScreen.jpg")
        image = Drawing.Image.FromStream(s)

        FillComboBoxes()
        SetControlsToDesignerValues()
    End Sub 'New


    Private Sub FillComboBoxes()
        Dim mode As String
        For Each mode In [Enum].GetNames(GetType(BooleanInteractionMode))
            ledResponseModesComboBox.Items.Add(mode)
            switchResponseModesComboBox.Items.Add(mode)
        Next mode

        For Each mode In [Enum].GetNames(GetType(LedBlinkMode))
            ledBlinkStylesComboBox.Items.Add(mode)
        Next mode

        Dim o As Object
        For Each o In EnumObject.GetValues(GetType(LedStyle))
            ledStylesComboBox.Items.Add(o)
        Next o

        For Each o In EnumObject.GetValues(GetType(SwitchStyle))
            switchStylesComboBox.Items.Add(o)
        Next

    End Sub 'FillComboBoxes         

    Private Sub SetControlsToDesignerValues()

        onColorLed.OffColor = displayLed.OnColor
        offColorLed.OffColor = displayLed.OffColor
        switchOnColorLed.OffColor = displaySwitch.OnColor
        switchOffColorLed.OffColor = displaySwitch.OffColor

        ledBlinkIntervalNumericEdit.Value = displayLed.BlinkInterval.TotalMilliseconds

        switchBackgroundTransparentCheckBox.Checked = displaySwitch.BackColor.Equals(Color.Transparent)
        ledBackgroundTransparentCheckBox.Checked = displayLed.BackColor.Equals(Color.Transparent)

        switchStateTextBox.Text = displaySwitch.Value.ToString()
        ledStateTextBox.Text = displayLed.Value.ToString()

        ledStylesComboBox.SelectedItem = displayLed.LedStyle
        switchStylesComboBox.SelectedItem = displaySwitch.SwitchStyle

        ledBlinkStylesComboBox.SelectedItem = displayLed.BlinkMode.ToString()
        switchResponseModesComboBox.SelectedItem = displaySwitch.InteractionMode.ToString()
        ledResponseModesComboBox.SelectedItem = displayLed.InteractionMode.ToString()
    End Sub 'SetControlsToDesignerValues

    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose
    Private WithEvents displayLed As NationalInstruments.UI.WindowsForms.Led
    Private WithEvents displaySwitch As NationalInstruments.UI.WindowsForms.Switch
    Private WithEvents ledOffColorLabel As System.Windows.Forms.Label
    Private WithEvents ledOnColorLabel As System.Windows.Forms.Label
    Private WithEvents switchOffColorLabel As System.Windows.Forms.Label
    Private WithEvents switchSwitchStylesLabel As System.Windows.Forms.Label
    Private WithEvents switchOnColorLabel As System.Windows.Forms.Label
    Private WithEvents switchValueLabel As System.Windows.Forms.Label
    Private WithEvents switchResponseModesLabel As System.Windows.Forms.Label
    Private WithEvents ledBlinkStylesLabel As System.Windows.Forms.Label
    Private WithEvents ledBlinkIntervalLabel As System.Windows.Forms.Label
    Private WithEvents transparentToolTip As System.Windows.Forms.ToolTip
    Private WithEvents ledBlinkIntervalNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private WithEvents switchGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents ledValueLabel As System.Windows.Forms.Label

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.colorDialog = New System.Windows.Forms.ColorDialog
        Me.ledStylesComboBox = New System.Windows.Forms.ComboBox
        Me.ledBackgroundTransparentCheckBox = New System.Windows.Forms.CheckBox
        Me.switchStylesComboBox = New System.Windows.Forms.ComboBox
        Me.ledResponseModesComboBox = New System.Windows.Forms.ComboBox
        Me.switchResponseModesComboBox = New System.Windows.Forms.ComboBox
        Me.ledStylesLabel = New System.Windows.Forms.Label
        Me.ledResponseModesLabel = New System.Windows.Forms.Label
        Me.ledBlinkStylesComboBox = New System.Windows.Forms.ComboBox
        Me.ledOffColorLabel = New System.Windows.Forms.Label
        Me.ledOnColorLabel = New System.Windows.Forms.Label
        Me.ledOffColorButton = New System.Windows.Forms.Button
        Me.ledOnColorButton = New System.Windows.Forms.Button
        Me.offColorLed = New NationalInstruments.UI.WindowsForms.Led
        Me.onColorLed = New NationalInstruments.UI.WindowsForms.Led
        Me.displaySwitch = New NationalInstruments.UI.WindowsForms.Switch
        Me.switchGroupBox = New System.Windows.Forms.GroupBox
        Me.switchOnColorLed = New NationalInstruments.UI.WindowsForms.Led
        Me.switchOffColorLed = New NationalInstruments.UI.WindowsForms.Led
        Me.switchOffColorButton = New System.Windows.Forms.Button
        Me.switchOnColorButton = New System.Windows.Forms.Button
        Me.switchOffColorLabel = New System.Windows.Forms.Label
        Me.switchSwitchStylesLabel = New System.Windows.Forms.Label
        Me.switchOnColorLabel = New System.Windows.Forms.Label
        Me.switchBackgroundTransparentCheckBox = New System.Windows.Forms.CheckBox
        Me.switchStateTextBox = New System.Windows.Forms.TextBox
        Me.switchValueLabel = New System.Windows.Forms.Label
        Me.switchResponseModesLabel = New System.Windows.Forms.Label
        Me.ledStateTextBox = New System.Windows.Forms.TextBox
        Me.ledValueLabel = New System.Windows.Forms.Label
        Me.ledBlinkStylesLabel = New System.Windows.Forms.Label
        Me.ledBlinkIntervalLabel = New System.Windows.Forms.Label
        Me.transparentToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.seeTransparentCheckBox = New System.Windows.Forms.CheckBox
        Me.displayLed = New NationalInstruments.UI.WindowsForms.Led
        Me.ledGroupBox = New System.Windows.Forms.GroupBox
        Me.ledBlinkIntervalNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        CType(Me.offColorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.onColorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displaySwitch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.switchGroupBox.SuspendLayout()
        CType(Me.switchOnColorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.switchOffColorLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displayLed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ledGroupBox.SuspendLayout()
        CType(Me.ledBlinkIntervalNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ledStylesComboBox
        '
        Me.ledStylesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ledStylesComboBox.Location = New System.Drawing.Point(280, 124)
        Me.ledStylesComboBox.Name = "ledStylesComboBox"
        Me.ledStylesComboBox.Size = New System.Drawing.Size(88, 21)
        Me.ledStylesComboBox.TabIndex = 4
        '
        'ledBackgroundTransparentCheckBox
        '
        Me.ledBackgroundTransparentCheckBox.Location = New System.Drawing.Point(216, 28)
        Me.ledBackgroundTransparentCheckBox.Name = "ledBackgroundTransparentCheckBox"
        Me.ledBackgroundTransparentCheckBox.Size = New System.Drawing.Size(152, 16)
        Me.ledBackgroundTransparentCheckBox.TabIndex = 1
        Me.ledBackgroundTransparentCheckBox.Text = "BackgroundTransparent"
        '
        'switchStylesComboBox
        '
        Me.switchStylesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.switchStylesComboBox.Location = New System.Drawing.Point(288, 124)
        Me.switchStylesComboBox.Name = "switchStylesComboBox"
        Me.switchStylesComboBox.Size = New System.Drawing.Size(120, 21)
        Me.switchStylesComboBox.TabIndex = 4
        '
        'ledResponseModesComboBox
        '
        Me.ledResponseModesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ledResponseModesComboBox.Location = New System.Drawing.Point(524, 28)
        Me.ledResponseModesComboBox.Name = "ledResponseModesComboBox"
        Me.ledResponseModesComboBox.Size = New System.Drawing.Size(128, 21)
        Me.ledResponseModesComboBox.TabIndex = 5
        '
        'switchResponseModesComboBox
        '
        Me.switchResponseModesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.switchResponseModesComboBox.Location = New System.Drawing.Point(524, 28)
        Me.switchResponseModesComboBox.Name = "switchResponseModesComboBox"
        Me.switchResponseModesComboBox.Size = New System.Drawing.Size(128, 21)
        Me.switchResponseModesComboBox.TabIndex = 5
        '
        'ledStylesLabel
        '
        Me.ledStylesLabel.AutoSize = True
        Me.ledStylesLabel.Location = New System.Drawing.Point(216, 128)
        Me.ledStylesLabel.Name = "ledStylesLabel"
        Me.ledStylesLabel.Size = New System.Drawing.Size(54, 16)
        Me.ledStylesLabel.TabIndex = 11
        Me.ledStylesLabel.Text = "LedStyles"
        Me.ledStylesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ledResponseModesLabel
        '
        Me.ledResponseModesLabel.AutoSize = True
        Me.ledResponseModesLabel.Location = New System.Drawing.Point(400, 28)
        Me.ledResponseModesLabel.Name = "ledResponseModesLabel"
        Me.ledResponseModesLabel.Size = New System.Drawing.Size(127, 16)
        Me.ledResponseModesLabel.TabIndex = 12
        Me.ledResponseModesLabel.Text = "BooleanInteractionMode"
        Me.ledResponseModesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ledBlinkStylesComboBox
        '
        Me.ledBlinkStylesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ledBlinkStylesComboBox.Location = New System.Drawing.Point(524, 60)
        Me.ledBlinkStylesComboBox.Name = "ledBlinkStylesComboBox"
        Me.ledBlinkStylesComboBox.Size = New System.Drawing.Size(128, 21)
        Me.ledBlinkStylesComboBox.TabIndex = 6
        '
        'ledOffColorLabel
        '
        Me.ledOffColorLabel.AutoSize = True
        Me.ledOffColorLabel.Location = New System.Drawing.Point(280, 92)
        Me.ledOffColorLabel.Name = "ledOffColorLabel"
        Me.ledOffColorLabel.Size = New System.Drawing.Size(46, 16)
        Me.ledOffColorLabel.TabIndex = 11
        Me.ledOffColorLabel.Text = "OffColor"
        Me.ledOffColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ledOnColorLabel
        '
        Me.ledOnColorLabel.AutoSize = True
        Me.ledOnColorLabel.Location = New System.Drawing.Point(280, 60)
        Me.ledOnColorLabel.Name = "ledOnColorLabel"
        Me.ledOnColorLabel.Size = New System.Drawing.Size(46, 16)
        Me.ledOnColorLabel.TabIndex = 10
        Me.ledOnColorLabel.Text = "OnColor"
        Me.ledOnColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ledOffColorButton
        '
        Me.ledOffColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ledOffColorButton.Location = New System.Drawing.Point(240, 92)
        Me.ledOffColorButton.Name = "ledOffColorButton"
        Me.ledOffColorButton.Size = New System.Drawing.Size(24, 16)
        Me.ledOffColorButton.TabIndex = 3
        Me.ledOffColorButton.Text = "..."
        '
        'ledOnColorButton
        '
        Me.ledOnColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ledOnColorButton.Location = New System.Drawing.Point(240, 60)
        Me.ledOnColorButton.Name = "ledOnColorButton"
        Me.ledOnColorButton.Size = New System.Drawing.Size(24, 16)
        Me.ledOnColorButton.TabIndex = 2
        Me.ledOnColorButton.Text = "..."
        '
        'offColorLed
        '
        Me.offColorLed.Location = New System.Drawing.Point(208, 84)
        Me.offColorLed.Name = "offColorLed"
        Me.offColorLed.Size = New System.Drawing.Size(32, 32)
        Me.offColorLed.TabIndex = 7
        '
        'onColorLed
        '
        Me.onColorLed.Location = New System.Drawing.Point(208, 52)
        Me.onColorLed.Name = "onColorLed"
        Me.onColorLed.Size = New System.Drawing.Size(32, 32)
        Me.onColorLed.TabIndex = 6
        '
        'displaySwitch
        '
        Me.displaySwitch.Dock = System.Windows.Forms.DockStyle.Left
        Me.displaySwitch.Location = New System.Drawing.Point(3, 16)
        Me.displaySwitch.Name = "displaySwitch"
        Me.displaySwitch.Size = New System.Drawing.Size(161, 149)
        Me.displaySwitch.TabIndex = 0
        '
        'switchGroupBox
        '
        Me.switchGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.switchGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.switchGroupBox.Controls.Add(Me.displaySwitch)
        Me.switchGroupBox.Controls.Add(Me.switchOnColorLed)
        Me.switchGroupBox.Controls.Add(Me.switchOffColorLed)
        Me.switchGroupBox.Controls.Add(Me.switchOffColorButton)
        Me.switchGroupBox.Controls.Add(Me.switchOnColorButton)
        Me.switchGroupBox.Controls.Add(Me.switchOffColorLabel)
        Me.switchGroupBox.Controls.Add(Me.switchSwitchStylesLabel)
        Me.switchGroupBox.Controls.Add(Me.switchOnColorLabel)
        Me.switchGroupBox.Controls.Add(Me.switchBackgroundTransparentCheckBox)
        Me.switchGroupBox.Controls.Add(Me.switchStateTextBox)
        Me.switchGroupBox.Controls.Add(Me.switchValueLabel)
        Me.switchGroupBox.Controls.Add(Me.switchResponseModesLabel)
        Me.switchGroupBox.Controls.Add(Me.switchStylesComboBox)
        Me.switchGroupBox.Controls.Add(Me.switchResponseModesComboBox)
        Me.switchGroupBox.Location = New System.Drawing.Point(8, 192)
        Me.switchGroupBox.Name = "switchGroupBox"
        Me.switchGroupBox.Size = New System.Drawing.Size(664, 168)
        Me.switchGroupBox.TabIndex = 1
        Me.switchGroupBox.TabStop = False
        Me.switchGroupBox.Text = "Switch"
        '
        'switchOnColorLed
        '
        Me.switchOnColorLed.Location = New System.Drawing.Point(208, 52)
        Me.switchOnColorLed.Name = "switchOnColorLed"
        Me.switchOnColorLed.Size = New System.Drawing.Size(32, 32)
        Me.switchOnColorLed.TabIndex = 12
        '
        'switchOffColorLed
        '
        Me.switchOffColorLed.Location = New System.Drawing.Point(208, 84)
        Me.switchOffColorLed.Name = "switchOffColorLed"
        Me.switchOffColorLed.Size = New System.Drawing.Size(32, 32)
        Me.switchOffColorLed.TabIndex = 13
        '
        'switchOffColorButton
        '
        Me.switchOffColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.switchOffColorButton.Location = New System.Drawing.Point(240, 92)
        Me.switchOffColorButton.Name = "switchOffColorButton"
        Me.switchOffColorButton.Size = New System.Drawing.Size(24, 16)
        Me.switchOffColorButton.TabIndex = 3
        Me.switchOffColorButton.Text = "..."
        '
        'switchOnColorButton
        '
        Me.switchOnColorButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.switchOnColorButton.Location = New System.Drawing.Point(240, 60)
        Me.switchOnColorButton.Name = "switchOnColorButton"
        Me.switchOnColorButton.Size = New System.Drawing.Size(24, 16)
        Me.switchOnColorButton.TabIndex = 2
        Me.switchOnColorButton.Text = "..."
        '
        'switchOffColorLabel
        '
        Me.switchOffColorLabel.AutoSize = True
        Me.switchOffColorLabel.Location = New System.Drawing.Point(280, 92)
        Me.switchOffColorLabel.Name = "switchOffColorLabel"
        Me.switchOffColorLabel.Size = New System.Drawing.Size(46, 16)
        Me.switchOffColorLabel.TabIndex = 17
        Me.switchOffColorLabel.Text = "OffColor"
        '
        'switchSwitchStylesLabel
        '
        Me.switchSwitchStylesLabel.AutoSize = True
        Me.switchSwitchStylesLabel.Location = New System.Drawing.Point(216, 128)
        Me.switchSwitchStylesLabel.Name = "switchSwitchStylesLabel"
        Me.switchSwitchStylesLabel.Size = New System.Drawing.Size(69, 16)
        Me.switchSwitchStylesLabel.TabIndex = 18
        Me.switchSwitchStylesLabel.Text = "SwitchStyles"
        Me.switchSwitchStylesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'switchOnColorLabel
        '
        Me.switchOnColorLabel.AutoSize = True
        Me.switchOnColorLabel.Location = New System.Drawing.Point(280, 60)
        Me.switchOnColorLabel.Name = "switchOnColorLabel"
        Me.switchOnColorLabel.Size = New System.Drawing.Size(46, 16)
        Me.switchOnColorLabel.TabIndex = 16
        Me.switchOnColorLabel.Text = "OnColor"
        '
        'switchBackgroundTransparentCheckBox
        '
        Me.switchBackgroundTransparentCheckBox.Location = New System.Drawing.Point(216, 28)
        Me.switchBackgroundTransparentCheckBox.Name = "switchBackgroundTransparentCheckBox"
        Me.switchBackgroundTransparentCheckBox.Size = New System.Drawing.Size(152, 16)
        Me.switchBackgroundTransparentCheckBox.TabIndex = 1
        Me.switchBackgroundTransparentCheckBox.Text = "BackgroundTransparent"
        '
        'switchStateTextBox
        '
        Me.switchStateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.switchStateTextBox.Location = New System.Drawing.Point(524, 60)
        Me.switchStateTextBox.Name = "switchStateTextBox"
        Me.switchStateTextBox.ReadOnly = True
        Me.switchStateTextBox.Size = New System.Drawing.Size(32, 13)
        Me.switchStateTextBox.TabIndex = 12
        Me.switchStateTextBox.TabStop = False
        Me.switchStateTextBox.Text = "false"
        '
        'switchValueLabel
        '
        Me.switchValueLabel.AutoSize = True
        Me.switchValueLabel.Location = New System.Drawing.Point(396, 60)
        Me.switchValueLabel.Name = "switchValueLabel"
        Me.switchValueLabel.Size = New System.Drawing.Size(33, 16)
        Me.switchValueLabel.TabIndex = 18
        Me.switchValueLabel.Text = "Value"
        Me.switchValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'switchResponseModesLabel
        '
        Me.switchResponseModesLabel.AutoSize = True
        Me.switchResponseModesLabel.Location = New System.Drawing.Point(396, 28)
        Me.switchResponseModesLabel.Name = "switchResponseModesLabel"
        Me.switchResponseModesLabel.Size = New System.Drawing.Size(127, 16)
        Me.switchResponseModesLabel.TabIndex = 11
        Me.switchResponseModesLabel.Text = "BooleanInteractionMode"
        '
        'ledStateTextBox
        '
        Me.ledStateTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ledStateTextBox.Location = New System.Drawing.Point(524, 124)
        Me.ledStateTextBox.Name = "ledStateTextBox"
        Me.ledStateTextBox.ReadOnly = True
        Me.ledStateTextBox.Size = New System.Drawing.Size(32, 13)
        Me.ledStateTextBox.TabIndex = 1
        Me.ledStateTextBox.TabStop = False
        Me.ledStateTextBox.Text = "false"
        '
        'ledValueLabel
        '
        Me.ledValueLabel.AutoSize = True
        Me.ledValueLabel.Location = New System.Drawing.Point(400, 124)
        Me.ledValueLabel.Name = "ledValueLabel"
        Me.ledValueLabel.Size = New System.Drawing.Size(33, 16)
        Me.ledValueLabel.TabIndex = 17
        Me.ledValueLabel.Text = "Value"
        Me.ledValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ledBlinkStylesLabel
        '
        Me.ledBlinkStylesLabel.AutoSize = True
        Me.ledBlinkStylesLabel.Location = New System.Drawing.Point(400, 64)
        Me.ledBlinkStylesLabel.Name = "ledBlinkStylesLabel"
        Me.ledBlinkStylesLabel.Size = New System.Drawing.Size(57, 16)
        Me.ledBlinkStylesLabel.TabIndex = 15
        Me.ledBlinkStylesLabel.Text = "BlinkMode"
        Me.ledBlinkStylesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ledBlinkIntervalLabel
        '
        Me.ledBlinkIntervalLabel.AutoSize = True
        Me.ledBlinkIntervalLabel.Location = New System.Drawing.Point(400, 92)
        Me.ledBlinkIntervalLabel.Name = "ledBlinkIntervalLabel"
        Me.ledBlinkIntervalLabel.Size = New System.Drawing.Size(66, 16)
        Me.ledBlinkIntervalLabel.TabIndex = 16
        Me.ledBlinkIntervalLabel.Text = "BlinkInterval"
        Me.ledBlinkIntervalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'seeTransparentCheckBox
        '
        Me.seeTransparentCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.seeTransparentCheckBox.BackColor = System.Drawing.Color.Transparent
        Me.seeTransparentCheckBox.Location = New System.Drawing.Point(16, 368)
        Me.seeTransparentCheckBox.Name = "seeTransparentCheckBox"
        Me.seeTransparentCheckBox.Size = New System.Drawing.Size(168, 16)
        Me.seeTransparentCheckBox.TabIndex = 2
        Me.seeTransparentCheckBox.Text = "Transparent Mode"
        '
        'displayLed
        '
        Me.displayLed.Dock = System.Windows.Forms.DockStyle.Left
        Me.displayLed.InteractionMode = NationalInstruments.UI.BooleanInteractionMode.SwitchWhenPressed
        Me.displayLed.Location = New System.Drawing.Point(3, 16)
        Me.displayLed.Name = "displayLed"
        Me.displayLed.Size = New System.Drawing.Size(161, 149)
        Me.displayLed.TabIndex = 0
        '
        'ledGroupBox
        '
        Me.ledGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ledGroupBox.BackColor = System.Drawing.Color.Transparent
        Me.ledGroupBox.Controls.Add(Me.displayLed)
        Me.ledGroupBox.Controls.Add(Me.offColorLed)
        Me.ledGroupBox.Controls.Add(Me.ledOnColorLabel)
        Me.ledGroupBox.Controls.Add(Me.ledStylesLabel)
        Me.ledGroupBox.Controls.Add(Me.ledStylesComboBox)
        Me.ledGroupBox.Controls.Add(Me.ledOffColorButton)
        Me.ledGroupBox.Controls.Add(Me.onColorLed)
        Me.ledGroupBox.Controls.Add(Me.ledOnColorButton)
        Me.ledGroupBox.Controls.Add(Me.ledOffColorLabel)
        Me.ledGroupBox.Controls.Add(Me.ledBackgroundTransparentCheckBox)
        Me.ledGroupBox.Controls.Add(Me.ledBlinkStylesLabel)
        Me.ledGroupBox.Controls.Add(Me.ledResponseModesComboBox)
        Me.ledGroupBox.Controls.Add(Me.ledBlinkStylesComboBox)
        Me.ledGroupBox.Controls.Add(Me.ledStateTextBox)
        Me.ledGroupBox.Controls.Add(Me.ledResponseModesLabel)
        Me.ledGroupBox.Controls.Add(Me.ledBlinkIntervalLabel)
        Me.ledGroupBox.Controls.Add(Me.ledValueLabel)
        Me.ledGroupBox.Controls.Add(Me.ledBlinkIntervalNumericEdit)
        Me.ledGroupBox.Location = New System.Drawing.Point(8, 8)
        Me.ledGroupBox.Name = "ledGroupBox"
        Me.ledGroupBox.Size = New System.Drawing.Size(664, 168)
        Me.ledGroupBox.TabIndex = 0
        Me.ledGroupBox.TabStop = False
        Me.ledGroupBox.Text = " Led"
        '
        'ledBlinkIntervalNumericEdit
        '
        Me.ledBlinkIntervalNumericEdit.CoercionInterval = 20
        Me.ledBlinkIntervalNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval
        Me.ledBlinkIntervalNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.ledBlinkIntervalNumericEdit.Location = New System.Drawing.Point(524, 92)
        Me.ledBlinkIntervalNumericEdit.Name = "ledBlinkIntervalNumericEdit"
        Me.ledBlinkIntervalNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.ledBlinkIntervalNumericEdit.Range = NationalInstruments.UI.Range.Parse("20, 1000")
        Me.ledBlinkIntervalNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.ledBlinkIntervalNumericEdit.TabIndex = 7
        Me.ledBlinkIntervalNumericEdit.Value = 500
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(680, 397)
        Me.Controls.Add(Me.ledGroupBox)
        Me.Controls.Add(Me.switchGroupBox)
        Me.Controls.Add(Me.seeTransparentCheckBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(688, 424)
        Me.Name = "MainForm"
        Me.Text = "Switch/Led Features"
        CType(Me.offColorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.onColorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displaySwitch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.switchGroupBox.ResumeLayout(False)
        CType(Me.switchOnColorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.switchOffColorLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displayLed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ledGroupBox.ResumeLayout(False)
        CType(Me.ledBlinkIntervalNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent

    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub 'Main


    Private Sub ledStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ledStylesComboBox.SelectedIndexChanged
        displayLed.LedStyle = CType(ledStylesComboBox.SelectedItem, LedStyle)
    End Sub 'ledStyles_SelectedIndexChanged

    Private Sub ledBackgroundTransparent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ledBackgroundTransparentCheckBox.CheckedChanged
        If ledBackgroundTransparentCheckBox.Checked Then
            displayLed.BackColor = Color.Transparent
        Else
            displayLed.BackColor = BackColor
        End If
    End Sub 'ledBackgroundTransparent_CheckedChanged

    Private Sub switchStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles switchStylesComboBox.SelectedIndexChanged
        displaySwitch.SwitchStyle = CType(switchStylesComboBox.SelectedItem, SwitchStyle)
    End Sub 'switchStyles_SelectedIndexChanged

    Private Sub ledResponseModes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ledResponseModesComboBox.SelectedIndexChanged
        Dim x As Integer
        Dim item As String = ledResponseModesComboBox.SelectedItem '
        If item = Nothing Then
            Return
        End If
        For x = 0 To ledResponseModesComboBox.Items.Count - 1
            If item = [Enum].GetNames(GetType(BooleanInteractionMode))(x) Then
                displayLed.InteractionMode = CType(CType([Enum].GetValues(GetType(BooleanInteractionMode)), Integer())(x), BooleanInteractionMode)
            End If
        Next x
    End Sub 'ledResponseModes_SelectedIndexChanged

    Private Sub switchResponseModes_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles switchResponseModesComboBox.SelectedIndexChanged
        Dim x As Integer
        Dim item As String = switchResponseModesComboBox.SelectedItem '
        If item = Nothing Then
            Return
        End If

        For x = 0 To switchResponseModesComboBox.Items.Count - 1
            If item = [Enum].GetNames(GetType(BooleanInteractionMode))(x) Then
                displaySwitch.InteractionMode = CType(CType([Enum].GetValues(GetType(BooleanInteractionMode)), Integer())(x), BooleanInteractionMode)
            End If
        Next x
    End Sub 'switchResponseModes_SelectedIndexChanged

    Private Sub ledBlinkStyles_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ledBlinkStylesComboBox.SelectedIndexChanged
        Dim x As Integer
        Dim item As String = ledBlinkStylesComboBox.SelectedItem '
        If item = Nothing Then
            Return
        End If
        For x = 0 To ledBlinkStylesComboBox.Items.Count - 1
            If item = [Enum].GetNames(GetType(LedBlinkMode))(x) Then
                displayLed.BlinkMode = CType(CType([Enum].GetValues(GetType(LedBlinkMode)), Integer())(x), LedBlinkMode)
            End If
        Next x
    End Sub 'ledBlinkStyles_SelectedIndexChanged

    Private Sub ledBlinkInterval_AfterValueChanged(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs) Handles ledBlinkIntervalNumericEdit.AfterChangeValue
        displayLed.BlinkInterval = TimeSpan.FromMilliseconds(ledBlinkIntervalNumericEdit.Value)
    End Sub 'ledBlinkInterval_ValueChanged

    Private Sub ledOnColorButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ledOnColorButton.Click
        If colorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            onColorLed.OffColor = colorDialog.Color
            displayLed.OnColor = colorDialog.Color
        End If
    End Sub 'ledOnColorButton_Click


    Private Sub ledOffColorButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ledOffColorButton.Click
        If colorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            offColorLed.OffColor = colorDialog.Color
            displayLed.OffColor = colorDialog.Color
        End If
    End Sub 'ledOffColorButton_Click


    Private Sub led1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displayLed.ValueChanged
        ledStateTextBox.Text = displayLed.Value.ToString()
    End Sub 'led1_ValueChanged


    Private Sub switchOnColorButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles switchOnColorButton.Click
        If colorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            switchOnColorLed.OffColor = colorDialog.Color
            displaySwitch.OnColor = colorDialog.Color
        End If
    End Sub 'switchOnColorButton_Click


    Private Sub switchOffColorButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles switchOffColorButton.Click
        If colorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            switchOffColorLed.OffColor = colorDialog.Color
            displaySwitch.OffColor = colorDialog.Color
        End If
    End Sub 'switchOffColorButton_Click


    Private Sub switchBackgroundTransparent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles switchBackgroundTransparentCheckBox.CheckedChanged
        If switchBackgroundTransparentCheckBox.Checked Then
            displaySwitch.BackColor = Color.Transparent
        Else
            displaySwitch.BackColor = BackColor
        End If
    End Sub 'switchBackgroundTransparent_CheckedChanged

    Private Sub seeTransparent_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles seeTransparentCheckBox.CheckedChanged
        If seeTransparentCheckBox.Checked Then
            BackgroundImage = image
        Else
            BackgroundImage = Nothing
        End If
    End Sub 'seeTransparent_CheckedChanged

    Private Sub switch1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles displaySwitch.ValueChanged
        switchStateTextBox.Text = displaySwitch.Value.ToString()
    End Sub 'switch1_ValueChanged


End Class '[Boolean]
