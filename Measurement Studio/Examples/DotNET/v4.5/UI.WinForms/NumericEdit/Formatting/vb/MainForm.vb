Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents formatMeter As NationalInstruments.UI.WindowsForms.Meter
    Friend WithEvents formatKnob As NationalInstruments.UI.WindowsForms.Knob
    Friend WithEvents simpleDoubleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents precision1Label As System.Windows.Forms.Label
    Friend WithEvents precision1NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents precision4Label As System.Windows.Forms.Label
    Friend WithEvents precision4NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents precision16Label As System.Windows.Forms.Label
    Friend WithEvents precision16NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents scientificGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents precision4caseLabel As System.Windows.Forms.Label
    Friend WithEvents precision4CaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents precision8Label As System.Windows.Forms.Label
    Friend WithEvents precision8CaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents binaryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents padding8NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents padding8Label As System.Windows.Forms.Label
    Friend WithEvents padding4Label As System.Windows.Forms.Label
    Friend WithEvents padding4NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents engineeringGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents formatSLabel As System.Windows.Forms.Label
    Friend WithEvents genericSNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents formatS1HzLabel As System.Windows.Forms.Label
    Friend WithEvents engS2HzNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents formatEEHzLabel As System.Windows.Forms.Label
    Friend WithEvents engEEHzNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents hexGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents padding8CaseLabel As System.Windows.Forms.Label
    Friend WithEvents hexPad8NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents hexPad4NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents hexPad2NumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents padding2CaseLabel As System.Windows.Forms.Label
    Friend WithEvents padding4CaseLabel As System.Windows.Forms.Label
    Friend WithEvents genericGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents genericFormatPNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents formatPLabel As System.Windows.Forms.Label
    Friend WithEvents genericCNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents formatVLabel As System.Windows.Forms.Label
    Friend WithEvents genericFormatVNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents formatCLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.formatMeter = New NationalInstruments.UI.WindowsForms.Meter
        Me.formatKnob = New NationalInstruments.UI.WindowsForms.Knob
        Me.simpleDoubleGroupBox = New System.Windows.Forms.GroupBox
        Me.precision1Label = New System.Windows.Forms.Label
        Me.precision1NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.precision4Label = New System.Windows.Forms.Label
        Me.precision4NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.precision16Label = New System.Windows.Forms.Label
        Me.precision16NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.scientificGroupBox = New System.Windows.Forms.GroupBox
        Me.precision4caseLabel = New System.Windows.Forms.Label
        Me.precision4CaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.precision8Label = New System.Windows.Forms.Label
        Me.precision8CaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.binaryGroupBox = New System.Windows.Forms.GroupBox
        Me.padding8NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.padding8Label = New System.Windows.Forms.Label
        Me.padding4Label = New System.Windows.Forms.Label
        Me.padding4NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.engineeringGroupBox = New System.Windows.Forms.GroupBox
        Me.formatSLabel = New System.Windows.Forms.Label
        Me.genericSNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.formatS1HzLabel = New System.Windows.Forms.Label
        Me.engS2HzNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.formatEEHzLabel = New System.Windows.Forms.Label
        Me.engEEHzNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.hexGroupBox = New System.Windows.Forms.GroupBox
        Me.padding8CaseLabel = New System.Windows.Forms.Label
        Me.hexPad8NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.hexPad4NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.hexPad2NumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.padding2CaseLabel = New System.Windows.Forms.Label
        Me.padding4CaseLabel = New System.Windows.Forms.Label
        Me.genericGroupBox = New System.Windows.Forms.GroupBox
        Me.genericFormatPNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.formatPLabel = New System.Windows.Forms.Label
        Me.genericCNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.formatVLabel = New System.Windows.Forms.Label
        Me.genericFormatVNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.formatCLabel = New System.Windows.Forms.Label
        CType(Me.formatMeter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.formatKnob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.simpleDoubleGroupBox.SuspendLayout()
        Me.scientificGroupBox.SuspendLayout()
        Me.binaryGroupBox.SuspendLayout()
        Me.engineeringGroupBox.SuspendLayout()
        Me.hexGroupBox.SuspendLayout()
        Me.genericGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'formatMeter
        '
        Me.formatMeter.Border = NationalInstruments.UI.Border.Etched
        Me.formatMeter.Caption = "Interactive Meter"
        Me.formatMeter.InteractionMode = CType((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer Or NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer), NationalInstruments.UI.RadialNumericPointerInteractionModes)
        Me.formatMeter.Location = New System.Drawing.Point(256, 0)
        Me.formatMeter.Name = "formatMeter"
        Me.formatMeter.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.formatMeter.PointerColor = System.Drawing.SystemColors.Desktop
        Me.formatMeter.ScaleArc = New NationalInstruments.UI.Arc(180.0!, -180.0!)
        Me.formatMeter.ScaleBaseLineColor = System.Drawing.Color.DeepSkyBlue
        Me.formatMeter.Size = New System.Drawing.Size(248, 152)
        Me.formatMeter.TabIndex = 5
        '
        'formatKnob
        '
        Me.formatKnob.Border = NationalInstruments.UI.Border.Etched
        Me.formatKnob.Caption = "Interactive Knob"
        Me.formatKnob.DialColor = System.Drawing.SystemColors.Desktop
        Me.formatKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle
        Me.formatKnob.Location = New System.Drawing.Point(8, 0)
        Me.formatKnob.Name = "formatKnob"
        Me.formatKnob.PointerColor = System.Drawing.SystemColors.Highlight
        Me.formatKnob.Range = New NationalInstruments.UI.Range(0, 100)
        Me.formatKnob.Size = New System.Drawing.Size(240, 216)
        Me.formatKnob.TabIndex = 0
        Me.formatKnob.Value = 1
        '
        'simpleDoubleGroupBox
        '
        Me.simpleDoubleGroupBox.Controls.Add(Me.precision1Label)
        Me.simpleDoubleGroupBox.Controls.Add(Me.precision1NumericEdit)
        Me.simpleDoubleGroupBox.Controls.Add(Me.precision4Label)
        Me.simpleDoubleGroupBox.Controls.Add(Me.precision4NumericEdit)
        Me.simpleDoubleGroupBox.Controls.Add(Me.precision16Label)
        Me.simpleDoubleGroupBox.Controls.Add(Me.precision16NumericEdit)
        Me.simpleDoubleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.simpleDoubleGroupBox.Location = New System.Drawing.Point(8, 216)
        Me.simpleDoubleGroupBox.Name = "simpleDoubleGroupBox"
        Me.simpleDoubleGroupBox.Size = New System.Drawing.Size(160, 168)
        Me.simpleDoubleGroupBox.TabIndex = 1
        Me.simpleDoubleGroupBox.TabStop = False
        Me.simpleDoubleGroupBox.Text = "SimpleDouble"
        '
        'precision1Label
        '
        Me.precision1Label.Location = New System.Drawing.Point(16, 24)
        Me.precision1Label.Name = "precision1Label"
        Me.precision1Label.Size = New System.Drawing.Size(128, 16)
        Me.precision1Label.TabIndex = 4
        Me.precision1Label.Text = "Precision: 1"
        '
        'precision1NumericEdit
        '
        Me.precision1NumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.precision1NumericEdit.Name = "precision1NumericEdit"
        Me.precision1NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.precision1NumericEdit.Source = Me.formatKnob
        Me.precision1NumericEdit.TabIndex = 0
        Me.precision1NumericEdit.Value = 1
        '
        'precision4Label
        '
        Me.precision4Label.Location = New System.Drawing.Point(16, 72)
        Me.precision4Label.Name = "precision4Label"
        Me.precision4Label.Size = New System.Drawing.Size(120, 16)
        Me.precision4Label.TabIndex = 6
        Me.precision4Label.Text = "Precision: 4"
        '
        'precision4NumericEdit
        '
        Me.precision4NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4)
        Me.precision4NumericEdit.Location = New System.Drawing.Point(16, 88)
        Me.precision4NumericEdit.Name = "precision4NumericEdit"
        Me.precision4NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.precision4NumericEdit.Source = Me.formatKnob
        Me.precision4NumericEdit.TabIndex = 1
        Me.precision4NumericEdit.Value = 1
        '
        'precision16Label
        '
        Me.precision16Label.Location = New System.Drawing.Point(16, 120)
        Me.precision16Label.Name = "precision16Label"
        Me.precision16Label.Size = New System.Drawing.Size(120, 16)
        Me.precision16Label.TabIndex = 8
        Me.precision16Label.Text = "Precision: 16"
        '
        'precision16NumericEdit
        '
        Me.precision16NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(10)
        Me.precision16NumericEdit.Location = New System.Drawing.Point(16, 136)
        Me.precision16NumericEdit.Name = "precision16NumericEdit"
        Me.precision16NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.precision16NumericEdit.Source = Me.formatKnob
        Me.precision16NumericEdit.TabIndex = 2
        Me.precision16NumericEdit.Value = 1
        '
        'scientificGroupBox
        '
        Me.scientificGroupBox.Controls.Add(Me.precision4caseLabel)
        Me.scientificGroupBox.Controls.Add(Me.precision4CaseNumericEdit)
        Me.scientificGroupBox.Controls.Add(Me.precision8Label)
        Me.scientificGroupBox.Controls.Add(Me.precision8CaseNumericEdit)
        Me.scientificGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.scientificGroupBox.Location = New System.Drawing.Point(8, 392)
        Me.scientificGroupBox.Name = "scientificGroupBox"
        Me.scientificGroupBox.Size = New System.Drawing.Size(160, 128)
        Me.scientificGroupBox.TabIndex = 2
        Me.scientificGroupBox.TabStop = False
        Me.scientificGroupBox.Text = "Scientific"
        '
        'precision4caseLabel
        '
        Me.precision4caseLabel.Location = New System.Drawing.Point(16, 24)
        Me.precision4caseLabel.Name = "precision4caseLabel"
        Me.precision4caseLabel.Size = New System.Drawing.Size(136, 16)
        Me.precision4caseLabel.TabIndex = 18
        Me.precision4caseLabel.Text = "Precision: 4, Lowercase"
        '
        'precision4CaseNumericEdit
        '
        Me.precision4CaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(4)
        Me.precision4CaseNumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.precision4CaseNumericEdit.Name = "precision4CaseNumericEdit"
        Me.precision4CaseNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.precision4CaseNumericEdit.Source = Me.formatKnob
        Me.precision4CaseNumericEdit.TabIndex = 0
        Me.precision4CaseNumericEdit.Value = 1
        '
        'precision8Label
        '
        Me.precision8Label.Location = New System.Drawing.Point(16, 80)
        Me.precision8Label.Name = "precision8Label"
        Me.precision8Label.Size = New System.Drawing.Size(136, 16)
        Me.precision8Label.TabIndex = 20
        Me.precision8Label.Text = "Precision: 8, Uppercase"
        '
        'precision8CaseNumericEdit
        '
        Me.precision8CaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(8, True)
        Me.precision8CaseNumericEdit.Location = New System.Drawing.Point(16, 96)
        Me.precision8CaseNumericEdit.Name = "precision8CaseNumericEdit"
        Me.precision8CaseNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.precision8CaseNumericEdit.Source = Me.formatKnob
        Me.precision8CaseNumericEdit.TabIndex = 1
        Me.precision8CaseNumericEdit.Value = 1
        '
        'binaryGroupBox
        '
        Me.binaryGroupBox.Controls.Add(Me.padding8NumericEdit)
        Me.binaryGroupBox.Controls.Add(Me.padding8Label)
        Me.binaryGroupBox.Controls.Add(Me.padding4Label)
        Me.binaryGroupBox.Controls.Add(Me.padding4NumericEdit)
        Me.binaryGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.binaryGroupBox.Location = New System.Drawing.Point(176, 216)
        Me.binaryGroupBox.Name = "binaryGroupBox"
        Me.binaryGroupBox.Size = New System.Drawing.Size(160, 120)
        Me.binaryGroupBox.TabIndex = 3
        Me.binaryGroupBox.TabStop = False
        Me.binaryGroupBox.Text = "Binary"
        '
        'padding8NumericEdit
        '
        Me.padding8NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateBinaryMode
        Me.padding8NumericEdit.Location = New System.Drawing.Point(16, 88)
        Me.padding8NumericEdit.Name = "padding8NumericEdit"
        Me.padding8NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.padding8NumericEdit.Source = Me.formatKnob
        Me.padding8NumericEdit.TabIndex = 1
        Me.padding8NumericEdit.Value = 1
        '
        'padding8Label
        '
        Me.padding8Label.Location = New System.Drawing.Point(16, 72)
        Me.padding8Label.Name = "padding8Label"
        Me.padding8Label.Size = New System.Drawing.Size(128, 16)
        Me.padding8Label.TabIndex = 10
        Me.padding8Label.Text = "Padding: 8"
        '
        'padding4Label
        '
        Me.padding4Label.Location = New System.Drawing.Point(16, 24)
        Me.padding4Label.Name = "padding4Label"
        Me.padding4Label.Size = New System.Drawing.Size(128, 16)
        Me.padding4Label.TabIndex = 12
        Me.padding4Label.Text = "Padding: 4"
        '
        'padding4NumericEdit
        '
        Me.padding4NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateBinaryMode(4)
        Me.padding4NumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.padding4NumericEdit.Name = "padding4NumericEdit"
        Me.padding4NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.padding4NumericEdit.Source = Me.formatKnob
        Me.padding4NumericEdit.TabIndex = 0
        Me.padding4NumericEdit.Value = 1
        '
        'engineeringGroupBox
        '
        Me.engineeringGroupBox.Controls.Add(Me.formatSLabel)
        Me.engineeringGroupBox.Controls.Add(Me.genericSNumericEdit)
        Me.engineeringGroupBox.Controls.Add(Me.formatS1HzLabel)
        Me.engineeringGroupBox.Controls.Add(Me.engS2HzNumericEdit)
        Me.engineeringGroupBox.Controls.Add(Me.formatEEHzLabel)
        Me.engineeringGroupBox.Controls.Add(Me.engEEHzNumericEdit)
        Me.engineeringGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.engineeringGroupBox.Location = New System.Drawing.Point(344, 352)
        Me.engineeringGroupBox.Name = "engineeringGroupBox"
        Me.engineeringGroupBox.Size = New System.Drawing.Size(160, 168)
        Me.engineeringGroupBox.TabIndex = 7
        Me.engineeringGroupBox.TabStop = False
        Me.engineeringGroupBox.Text = "Engineering"
        '
        'formatSLabel
        '
        Me.formatSLabel.Location = New System.Drawing.Point(16, 120)
        Me.formatSLabel.Name = "formatSLabel"
        Me.formatSLabel.Size = New System.Drawing.Size(128, 16)
        Me.formatSLabel.TabIndex = 5
        Me.formatSLabel.Text = "Format: S"
        '
        'genericSNumericEdit
        '
        Me.genericSNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateEngineeringMode("S")
        Me.genericSNumericEdit.Location = New System.Drawing.Point(16, 136)
        Me.genericSNumericEdit.Name = "genericSNumericEdit"
        Me.genericSNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.genericSNumericEdit.Source = Me.formatMeter
        Me.genericSNumericEdit.TabIndex = 2
        '
        'formatS1HzLabel
        '
        Me.formatS1HzLabel.Location = New System.Drawing.Point(16, 72)
        Me.formatS1HzLabel.Name = "formatS1HzLabel"
        Me.formatS1HzLabel.Size = New System.Drawing.Size(128, 16)
        Me.formatS1HzLabel.TabIndex = 3
        Me.formatS1HzLabel.Text = "Format: S1'Hz'"
        '
        'engS2HzNumericEdit
        '
        Me.engS2HzNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateEngineeringMode("S1'Hz'")
        Me.engS2HzNumericEdit.Location = New System.Drawing.Point(16, 88)
        Me.engS2HzNumericEdit.Name = "engS2HzNumericEdit"
        Me.engS2HzNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.engS2HzNumericEdit.Source = Me.formatMeter
        Me.engS2HzNumericEdit.TabIndex = 1
        '
        'formatEEHzLabel
        '
        Me.formatEEHzLabel.Location = New System.Drawing.Point(16, 24)
        Me.formatEEHzLabel.Name = "formatEEHzLabel"
        Me.formatEEHzLabel.Size = New System.Drawing.Size(128, 16)
        Me.formatEEHzLabel.TabIndex = 0
        Me.formatEEHzLabel.Text = "Format: EE'Hz'"
        '
        'engEEHzNumericEdit
        '
        Me.engEEHzNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateEngineeringMode("EE'Hz'")
        Me.engEEHzNumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.engEEHzNumericEdit.Name = "engEEHzNumericEdit"
        Me.engEEHzNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.engEEHzNumericEdit.Source = Me.formatMeter
        Me.engEEHzNumericEdit.TabIndex = 0
        '
        'hexGroupBox
        '
        Me.hexGroupBox.Controls.Add(Me.padding8CaseLabel)
        Me.hexGroupBox.Controls.Add(Me.hexPad8NumericEdit)
        Me.hexGroupBox.Controls.Add(Me.hexPad4NumericEdit)
        Me.hexGroupBox.Controls.Add(Me.hexPad2NumericEdit)
        Me.hexGroupBox.Controls.Add(Me.padding2CaseLabel)
        Me.hexGroupBox.Controls.Add(Me.padding4CaseLabel)
        Me.hexGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hexGroupBox.Location = New System.Drawing.Point(176, 344)
        Me.hexGroupBox.Name = "hexGroupBox"
        Me.hexGroupBox.Size = New System.Drawing.Size(160, 176)
        Me.hexGroupBox.TabIndex = 4
        Me.hexGroupBox.TabStop = False
        Me.hexGroupBox.Text = "Hexademical"
        '
        'padding8CaseLabel
        '
        Me.padding8CaseLabel.Location = New System.Drawing.Point(16, 120)
        Me.padding8CaseLabel.Name = "padding8CaseLabel"
        Me.padding8CaseLabel.Size = New System.Drawing.Size(128, 16)
        Me.padding8CaseLabel.TabIndex = 18
        Me.padding8CaseLabel.Text = "Padding: 8, Uppercase"
        '
        'hexPad8NumericEdit
        '
        Me.hexPad8NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(8, True)
        Me.hexPad8NumericEdit.Location = New System.Drawing.Point(16, 136)
        Me.hexPad8NumericEdit.Name = "hexPad8NumericEdit"
        Me.hexPad8NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.hexPad8NumericEdit.Source = Me.formatKnob
        Me.hexPad8NumericEdit.TabIndex = 2
        Me.hexPad8NumericEdit.Value = 1
        '
        'hexPad4NumericEdit
        '
        Me.hexPad4NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(4, True)
        Me.hexPad4NumericEdit.Location = New System.Drawing.Point(16, 88)
        Me.hexPad4NumericEdit.Name = "hexPad4NumericEdit"
        Me.hexPad4NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.hexPad4NumericEdit.Source = Me.formatKnob
        Me.hexPad4NumericEdit.TabIndex = 1
        Me.hexPad4NumericEdit.Value = 1
        '
        'hexPad2NumericEdit
        '
        Me.hexPad2NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(2)
        Me.hexPad2NumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.hexPad2NumericEdit.Name = "hexPad2NumericEdit"
        Me.hexPad2NumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.hexPad2NumericEdit.Source = Me.formatKnob
        Me.hexPad2NumericEdit.TabIndex = 0
        Me.hexPad2NumericEdit.Value = 1
        '
        'padding2CaseLabel
        '
        Me.padding2CaseLabel.Location = New System.Drawing.Point(16, 24)
        Me.padding2CaseLabel.Name = "padding2CaseLabel"
        Me.padding2CaseLabel.Size = New System.Drawing.Size(128, 16)
        Me.padding2CaseLabel.TabIndex = 16
        Me.padding2CaseLabel.Text = "Padding: 2, Lowercase"
        '
        'padding4CaseLabel
        '
        Me.padding4CaseLabel.Location = New System.Drawing.Point(16, 72)
        Me.padding4CaseLabel.Name = "padding4CaseLabel"
        Me.padding4CaseLabel.Size = New System.Drawing.Size(128, 16)
        Me.padding4CaseLabel.TabIndex = 14
        Me.padding4CaseLabel.Text = "Padding: 4, Uppercase"
        '
        'genericGroupBox
        '
        Me.genericGroupBox.Controls.Add(Me.genericFormatPNumericEdit)
        Me.genericGroupBox.Controls.Add(Me.formatPLabel)
        Me.genericGroupBox.Controls.Add(Me.genericCNumericEdit)
        Me.genericGroupBox.Controls.Add(Me.formatVLabel)
        Me.genericGroupBox.Controls.Add(Me.genericFormatVNumericEdit)
        Me.genericGroupBox.Controls.Add(Me.formatCLabel)
        Me.genericGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.genericGroupBox.Location = New System.Drawing.Point(344, 160)
        Me.genericGroupBox.Name = "genericGroupBox"
        Me.genericGroupBox.Size = New System.Drawing.Size(160, 184)
        Me.genericGroupBox.TabIndex = 6
        Me.genericGroupBox.TabStop = False
        Me.genericGroupBox.Text = "Generic"
        '
        'genericFormatPNumericEdit
        '
        Me.genericFormatPNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("P")
        Me.genericFormatPNumericEdit.Location = New System.Drawing.Point(16, 152)
        Me.genericFormatPNumericEdit.Name = "genericFormatPNumericEdit"
        Me.genericFormatPNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.genericFormatPNumericEdit.Source = Me.formatMeter
        Me.genericFormatPNumericEdit.TabIndex = 2
        '
        'formatPLabel
        '
        Me.formatPLabel.Location = New System.Drawing.Point(16, 136)
        Me.formatPLabel.Name = "formatPLabel"
        Me.formatPLabel.Size = New System.Drawing.Size(128, 16)
        Me.formatPLabel.TabIndex = 31
        Me.formatPLabel.Text = "Format: P"
        '
        'genericCNumericEdit
        '
        Me.genericCNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("C")
        Me.genericCNumericEdit.Location = New System.Drawing.Point(16, 40)
        Me.genericCNumericEdit.Name = "genericCNumericEdit"
        Me.genericCNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.genericCNumericEdit.Source = Me.formatMeter
        Me.genericCNumericEdit.TabIndex = 0
        '
        'formatVLabel
        '
        Me.formatVLabel.Location = New System.Drawing.Point(16, 80)
        Me.formatVLabel.Name = "formatVLabel"
        Me.formatVLabel.Size = New System.Drawing.Size(136, 16)
        Me.formatVLabel.TabIndex = 24
        Me.formatVLabel.Text = "Format: 0.00 Volts"
        '
        'genericFormatVNumericEdit
        '
        Me.genericFormatVNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("0.00 Volts")
        Me.genericFormatVNumericEdit.Location = New System.Drawing.Point(16, 96)
        Me.genericFormatVNumericEdit.Name = "genericFormatVNumericEdit"
        Me.genericFormatVNumericEdit.Size = New System.Drawing.Size(128, 20)
        Me.genericFormatVNumericEdit.Source = Me.formatMeter
        Me.genericFormatVNumericEdit.TabIndex = 1
        '
        'formatCLabel
        '
        Me.formatCLabel.Location = New System.Drawing.Point(16, 24)
        Me.formatCLabel.Name = "formatCLabel"
        Me.formatCLabel.Size = New System.Drawing.Size(136, 16)
        Me.formatCLabel.TabIndex = 22
        Me.formatCLabel.Text = "Format: C"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(510, 525)
        Me.Controls.Add(Me.engineeringGroupBox)
        Me.Controls.Add(Me.hexGroupBox)
        Me.Controls.Add(Me.genericGroupBox)
        Me.Controls.Add(Me.binaryGroupBox)
        Me.Controls.Add(Me.scientificGroupBox)
        Me.Controls.Add(Me.simpleDoubleGroupBox)
        Me.Controls.Add(Me.formatKnob)
        Me.Controls.Add(Me.formatMeter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Format Numeric Control"
        CType(Me.formatMeter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.formatKnob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.simpleDoubleGroupBox.ResumeLayout(False)
        Me.scientificGroupBox.ResumeLayout(False)
        Me.binaryGroupBox.ResumeLayout(False)
        Me.engineeringGroupBox.ResumeLayout(False)
        Me.hexGroupBox.ResumeLayout(False)
        Me.genericGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    <System.STAThread()> _
               Public Shared Sub Main()
        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.Run(New MainForm)
    End Sub
End Class
