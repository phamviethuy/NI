using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.Formatting
{
    /// <summary>
    /// Summary description for MainForm.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.WindowsForms.Knob formatKnob;
        private System.Windows.Forms.Label precision1Label;
        private System.Windows.Forms.Label precision4Label;
        private System.Windows.Forms.Label precision16Label;
        private System.Windows.Forms.Label precision4caseLabel;
        private System.Windows.Forms.Label precision8Label;
        private System.Windows.Forms.GroupBox simpleDoubleGroupBox;
        private System.Windows.Forms.GroupBox hexGroupBox;
        private System.Windows.Forms.GroupBox scientificGroupBox;
        private System.Windows.Forms.GroupBox genericGroupBox;
        private System.Windows.Forms.GroupBox engineeringGroupBox;
        private System.Windows.Forms.Label padding8Label;
        private System.Windows.Forms.Label padding4Label;
        private System.Windows.Forms.Label padding4CaseLabel;
        private System.Windows.Forms.Label padding2CaseLabel;
        private System.Windows.Forms.Label formatCLabel;
        private System.Windows.Forms.Label formatVLabel;
        private System.Windows.Forms.Label padding8CaseLabel;
        private System.Windows.Forms.Label formatPLabel;
        private System.Windows.Forms.Label formatSLabel;
        private System.Windows.Forms.Label formatS1HzLabel;
        private System.Windows.Forms.Label formatEEHzLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit precision1NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit precision4NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit precision16NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit precision4CaseNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit precision8CaseNumericEdit;
        private System.Windows.Forms.GroupBox binaryGroupBox;
        private NationalInstruments.UI.WindowsForms.Meter formatMeter;
        private NationalInstruments.UI.WindowsForms.NumericEdit padding8NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit padding4NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit hexPad4NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit hexPad2NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit genericCNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit genericFormatVNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit hexPad8NumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit genericFormatPNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit genericSNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit engS2HzNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit engEEHzNumericEdit;
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
            this.formatKnob = new NationalInstruments.UI.WindowsForms.Knob();
            this.precision1Label = new System.Windows.Forms.Label();
            this.precision1NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.precision4Label = new System.Windows.Forms.Label();
            this.precision4NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.precision16Label = new System.Windows.Forms.Label();
            this.precision16NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.padding8Label = new System.Windows.Forms.Label();
            this.padding8NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.padding4Label = new System.Windows.Forms.Label();
            this.padding4NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.padding4CaseLabel = new System.Windows.Forms.Label();
            this.hexPad4NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.padding2CaseLabel = new System.Windows.Forms.Label();
            this.hexPad2NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.precision4caseLabel = new System.Windows.Forms.Label();
            this.precision4CaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.precision8Label = new System.Windows.Forms.Label();
            this.precision8CaseNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.formatCLabel = new System.Windows.Forms.Label();
            this.genericCNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.formatMeter = new NationalInstruments.UI.WindowsForms.Meter();
            this.formatVLabel = new System.Windows.Forms.Label();
            this.genericFormatVNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.simpleDoubleGroupBox = new System.Windows.Forms.GroupBox();
            this.binaryGroupBox = new System.Windows.Forms.GroupBox();
            this.hexGroupBox = new System.Windows.Forms.GroupBox();
            this.padding8CaseLabel = new System.Windows.Forms.Label();
            this.hexPad8NumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.scientificGroupBox = new System.Windows.Forms.GroupBox();
            this.genericGroupBox = new System.Windows.Forms.GroupBox();
            this.genericFormatPNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.formatPLabel = new System.Windows.Forms.Label();
            this.engineeringGroupBox = new System.Windows.Forms.GroupBox();
            this.formatSLabel = new System.Windows.Forms.Label();
            this.genericSNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.formatS1HzLabel = new System.Windows.Forms.Label();
            this.engS2HzNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.formatEEHzLabel = new System.Windows.Forms.Label();
            this.engEEHzNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.formatKnob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatMeter)).BeginInit();
            this.simpleDoubleGroupBox.SuspendLayout();
            this.binaryGroupBox.SuspendLayout();
            this.hexGroupBox.SuspendLayout();
            this.scientificGroupBox.SuspendLayout();
            this.genericGroupBox.SuspendLayout();
            this.engineeringGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // formatKnob
            // 
            this.formatKnob.Border = NationalInstruments.UI.Border.Etched;
            this.formatKnob.Caption = "Interactive Knob";
            this.formatKnob.DialColor = System.Drawing.SystemColors.Desktop;
            this.formatKnob.KnobStyle = NationalInstruments.UI.KnobStyle.RaisedWithThinNeedle;
            this.formatKnob.Location = new System.Drawing.Point(8, 0);
            this.formatKnob.Name = "formatKnob";
            this.formatKnob.PointerColor = System.Drawing.SystemColors.Highlight;
            this.formatKnob.Range = new NationalInstruments.UI.Range(0, 100);
            this.formatKnob.Size = new System.Drawing.Size(240, 216);
            this.formatKnob.TabIndex = 0;
            this.formatKnob.Value = 1;
            // 
            // precision1Label
            // 
            this.precision1Label.Location = new System.Drawing.Point(16, 24);
            this.precision1Label.Name = "precision1Label";
            this.precision1Label.Size = new System.Drawing.Size(128, 16);
            this.precision1Label.TabIndex = 4;
            this.precision1Label.Text = "Precision: 1";
            // 
            // precision1NumericEdit
            // 
            this.precision1NumericEdit.Location = new System.Drawing.Point(16, 40);
            this.precision1NumericEdit.Name = "precision1NumericEdit";
            this.precision1NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.precision1NumericEdit.Source = this.formatKnob;
            this.precision1NumericEdit.TabIndex = 0;
            this.precision1NumericEdit.Value = 1;
            // 
            // precision4Label
            // 
            this.precision4Label.Location = new System.Drawing.Point(16, 72);
            this.precision4Label.Name = "precision4Label";
            this.precision4Label.Size = new System.Drawing.Size(120, 16);
            this.precision4Label.TabIndex = 6;
            this.precision4Label.Text = "Precision: 4";
            // 
            // precision4NumericEdit
            // 
            this.precision4NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(4);
            this.precision4NumericEdit.Location = new System.Drawing.Point(16, 88);
            this.precision4NumericEdit.Name = "precision4NumericEdit";
            this.precision4NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.precision4NumericEdit.Source = this.formatKnob;
            this.precision4NumericEdit.TabIndex = 1;
            this.precision4NumericEdit.Value = 1;
            // 
            // precision16Label
            // 
            this.precision16Label.Location = new System.Drawing.Point(16, 120);
            this.precision16Label.Name = "precision16Label";
            this.precision16Label.Size = new System.Drawing.Size(120, 16);
            this.precision16Label.TabIndex = 8;
            this.precision16Label.Text = "Precision: 16";
            // 
            // precision16NumericEdit
            // 
            this.precision16NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(10);
            this.precision16NumericEdit.Location = new System.Drawing.Point(16, 136);
            this.precision16NumericEdit.Name = "precision16NumericEdit";
            this.precision16NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.precision16NumericEdit.Source = this.formatKnob;
            this.precision16NumericEdit.TabIndex = 2;
            this.precision16NumericEdit.Value = 1;
            // 
            // padding8Label
            // 
            this.padding8Label.Location = new System.Drawing.Point(16, 72);
            this.padding8Label.Name = "padding8Label";
            this.padding8Label.Size = new System.Drawing.Size(128, 16);
            this.padding8Label.TabIndex = 10;
            this.padding8Label.Text = "Padding: 8";
            // 
            // padding8NumericEdit
            // 
            this.padding8NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateBinaryMode();
            this.padding8NumericEdit.Location = new System.Drawing.Point(16, 88);
            this.padding8NumericEdit.Name = "padding8NumericEdit";
            this.padding8NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.padding8NumericEdit.Source = this.formatKnob;
            this.padding8NumericEdit.TabIndex = 1;
            this.padding8NumericEdit.Value = 1;
            // 
            // padding4Label
            // 
            this.padding4Label.Location = new System.Drawing.Point(16, 24);
            this.padding4Label.Name = "padding4Label";
            this.padding4Label.Size = new System.Drawing.Size(128, 16);
            this.padding4Label.TabIndex = 12;
            this.padding4Label.Text = "Padding: 4";
            // 
            // padding4NumericEdit
            // 
            this.padding4NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateBinaryMode(4);
            this.padding4NumericEdit.Location = new System.Drawing.Point(16, 40);
            this.padding4NumericEdit.Name = "padding4NumericEdit";
            this.padding4NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.padding4NumericEdit.Source = this.formatKnob;
            this.padding4NumericEdit.TabIndex = 0;
            this.padding4NumericEdit.Value = 1;
            // 
            // padding4CaseLabel
            // 
            this.padding4CaseLabel.Location = new System.Drawing.Point(16, 72);
            this.padding4CaseLabel.Name = "padding4CaseLabel";
            this.padding4CaseLabel.Size = new System.Drawing.Size(128, 16);
            this.padding4CaseLabel.TabIndex = 14;
            this.padding4CaseLabel.Text = "Padding: 4, Uppercase";
            // 
            // hexPad4NumericEdit
            // 
            this.hexPad4NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(4, true);
            this.hexPad4NumericEdit.Location = new System.Drawing.Point(16, 88);
            this.hexPad4NumericEdit.Name = "hexPad4NumericEdit";
            this.hexPad4NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.hexPad4NumericEdit.Source = this.formatKnob;
            this.hexPad4NumericEdit.TabIndex = 1;
            this.hexPad4NumericEdit.Value = 1;
            // 
            // padding2CaseLabel
            // 
            this.padding2CaseLabel.Location = new System.Drawing.Point(16, 24);
            this.padding2CaseLabel.Name = "padding2CaseLabel";
            this.padding2CaseLabel.Size = new System.Drawing.Size(128, 16);
            this.padding2CaseLabel.TabIndex = 16;
            this.padding2CaseLabel.Text = "Padding: 2, Lowercase";
            // 
            // hexPad2NumericEdit
            // 
            this.hexPad2NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(2);
            this.hexPad2NumericEdit.Location = new System.Drawing.Point(16, 40);
            this.hexPad2NumericEdit.Name = "hexPad2NumericEdit";
            this.hexPad2NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.hexPad2NumericEdit.Source = this.formatKnob;
            this.hexPad2NumericEdit.TabIndex = 0;
            this.hexPad2NumericEdit.Value = 1;
            // 
            // precision4caseLabel
            // 
            this.precision4caseLabel.Location = new System.Drawing.Point(16, 24);
            this.precision4caseLabel.Name = "precision4caseLabel";
            this.precision4caseLabel.Size = new System.Drawing.Size(136, 16);
            this.precision4caseLabel.TabIndex = 18;
            this.precision4caseLabel.Text = "Precision: 4, Lowercase";
            // 
            // precision4CaseNumericEdit
            // 
            this.precision4CaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(4);
            this.precision4CaseNumericEdit.Location = new System.Drawing.Point(16, 40);
            this.precision4CaseNumericEdit.Name = "precision4CaseNumericEdit";
            this.precision4CaseNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.precision4CaseNumericEdit.Source = this.formatKnob;
            this.precision4CaseNumericEdit.TabIndex = 0;
            this.precision4CaseNumericEdit.Value = 1;
            // 
            // precision8Label
            // 
            this.precision8Label.Location = new System.Drawing.Point(16, 80);
            this.precision8Label.Name = "precision8Label";
            this.precision8Label.Size = new System.Drawing.Size(136, 16);
            this.precision8Label.TabIndex = 20;
            this.precision8Label.Text = "Precision: 8, Uppercase";
            // 
            // precision8CaseNumericEdit
            // 
            this.precision8CaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateScientificMode(8, true);
            this.precision8CaseNumericEdit.Location = new System.Drawing.Point(16, 96);
            this.precision8CaseNumericEdit.Name = "precision8CaseNumericEdit";
            this.precision8CaseNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.precision8CaseNumericEdit.Source = this.formatKnob;
            this.precision8CaseNumericEdit.TabIndex = 1;
            this.precision8CaseNumericEdit.Value = 1;
            // 
            // formatCLabel
            // 
            this.formatCLabel.Location = new System.Drawing.Point(16, 24);
            this.formatCLabel.Name = "formatCLabel";
            this.formatCLabel.Size = new System.Drawing.Size(136, 16);
            this.formatCLabel.TabIndex = 22;
            this.formatCLabel.Text = "Format: C";
            // 
            // genericCNumericEdit
            // 
            this.genericCNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("C");
            this.genericCNumericEdit.Location = new System.Drawing.Point(16, 40);
            this.genericCNumericEdit.Name = "genericCNumericEdit";
            this.genericCNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.genericCNumericEdit.Source = this.formatMeter;
            this.genericCNumericEdit.TabIndex = 0;
            // 
            // formatMeter
            // 
            this.formatMeter.Border = NationalInstruments.UI.Border.Etched;
            this.formatMeter.Caption = "Interactive Meter";
            this.formatMeter.InteractionMode = ((NationalInstruments.UI.RadialNumericPointerInteractionModes)((NationalInstruments.UI.RadialNumericPointerInteractionModes.DragPointer | NationalInstruments.UI.RadialNumericPointerInteractionModes.SnapPointer)));
            this.formatMeter.Location = new System.Drawing.Point(256, 0);
            this.formatMeter.Name = "formatMeter";
            this.formatMeter.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.formatMeter.PointerColor = System.Drawing.SystemColors.Desktop;
            this.formatMeter.ScaleArc = new NationalInstruments.UI.Arc(180F, -180F);
            this.formatMeter.ScaleBaseLineColor = System.Drawing.Color.DeepSkyBlue;
            this.formatMeter.Size = new System.Drawing.Size(248, 152);
            this.formatMeter.TabIndex = 5;
            // 
            // formatVLabel
            // 
            this.formatVLabel.Location = new System.Drawing.Point(16, 80);
            this.formatVLabel.Name = "formatVLabel";
            this.formatVLabel.Size = new System.Drawing.Size(136, 16);
            this.formatVLabel.TabIndex = 24;
            this.formatVLabel.Text = "Format: 0.00 Volts";
            // 
            // genericFormatVNumericEdit
            // 
            this.genericFormatVNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("0.00 Volts");
            this.genericFormatVNumericEdit.Location = new System.Drawing.Point(16, 96);
            this.genericFormatVNumericEdit.Name = "genericFormatVNumericEdit";
            this.genericFormatVNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.genericFormatVNumericEdit.Source = this.formatMeter;
            this.genericFormatVNumericEdit.TabIndex = 1;
            // 
            // simpleDoubleGroupBox
            // 
            this.simpleDoubleGroupBox.Controls.Add(this.precision1Label);
            this.simpleDoubleGroupBox.Controls.Add(this.precision1NumericEdit);
            this.simpleDoubleGroupBox.Controls.Add(this.precision4Label);
            this.simpleDoubleGroupBox.Controls.Add(this.precision4NumericEdit);
            this.simpleDoubleGroupBox.Controls.Add(this.precision16Label);
            this.simpleDoubleGroupBox.Controls.Add(this.precision16NumericEdit);
            this.simpleDoubleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.simpleDoubleGroupBox.Location = new System.Drawing.Point(8, 224);
            this.simpleDoubleGroupBox.Name = "simpleDoubleGroupBox";
            this.simpleDoubleGroupBox.Size = new System.Drawing.Size(160, 168);
            this.simpleDoubleGroupBox.TabIndex = 1;
            this.simpleDoubleGroupBox.TabStop = false;
            this.simpleDoubleGroupBox.Text = "SimpleDouble";
            // 
            // binaryGroupBox
            // 
            this.binaryGroupBox.Controls.Add(this.padding8NumericEdit);
            this.binaryGroupBox.Controls.Add(this.padding8Label);
            this.binaryGroupBox.Controls.Add(this.padding4Label);
            this.binaryGroupBox.Controls.Add(this.padding4NumericEdit);
            this.binaryGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.binaryGroupBox.Location = new System.Drawing.Point(176, 224);
            this.binaryGroupBox.Name = "binaryGroupBox";
            this.binaryGroupBox.Size = new System.Drawing.Size(160, 120);
            this.binaryGroupBox.TabIndex = 3;
            this.binaryGroupBox.TabStop = false;
            this.binaryGroupBox.Text = "Binary";
            // 
            // hexGroupBox
            // 
            this.hexGroupBox.Controls.Add(this.padding8CaseLabel);
            this.hexGroupBox.Controls.Add(this.hexPad8NumericEdit);
            this.hexGroupBox.Controls.Add(this.hexPad4NumericEdit);
            this.hexGroupBox.Controls.Add(this.hexPad2NumericEdit);
            this.hexGroupBox.Controls.Add(this.padding2CaseLabel);
            this.hexGroupBox.Controls.Add(this.padding4CaseLabel);
            this.hexGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.hexGroupBox.Location = new System.Drawing.Point(176, 352);
            this.hexGroupBox.Name = "hexGroupBox";
            this.hexGroupBox.Size = new System.Drawing.Size(160, 168);
            this.hexGroupBox.TabIndex = 4;
            this.hexGroupBox.TabStop = false;
            this.hexGroupBox.Text = "Hexademical";
            // 
            // padding8CaseLabel
            // 
            this.padding8CaseLabel.Location = new System.Drawing.Point(16, 120);
            this.padding8CaseLabel.Name = "padding8CaseLabel";
            this.padding8CaseLabel.Size = new System.Drawing.Size(128, 16);
            this.padding8CaseLabel.TabIndex = 18;
            this.padding8CaseLabel.Text = "Padding: 8, Uppercase";
            // 
            // hexPad8NumericEdit
            // 
            this.hexPad8NumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode(8, true);
            this.hexPad8NumericEdit.Location = new System.Drawing.Point(16, 136);
            this.hexPad8NumericEdit.Name = "hexPad8NumericEdit";
            this.hexPad8NumericEdit.Size = new System.Drawing.Size(128, 20);
            this.hexPad8NumericEdit.Source = this.formatKnob;
            this.hexPad8NumericEdit.TabIndex = 2;
            this.hexPad8NumericEdit.Value = 1;
            // 
            // scientificGroupBox
            // 
            this.scientificGroupBox.Controls.Add(this.precision4caseLabel);
            this.scientificGroupBox.Controls.Add(this.precision4CaseNumericEdit);
            this.scientificGroupBox.Controls.Add(this.precision8Label);
            this.scientificGroupBox.Controls.Add(this.precision8CaseNumericEdit);
            this.scientificGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scientificGroupBox.Location = new System.Drawing.Point(8, 392);
            this.scientificGroupBox.Name = "scientificGroupBox";
            this.scientificGroupBox.Size = new System.Drawing.Size(160, 128);
            this.scientificGroupBox.TabIndex = 2;
            this.scientificGroupBox.TabStop = false;
            this.scientificGroupBox.Text = "Scientific";
            // 
            // genericGroupBox
            // 
            this.genericGroupBox.Controls.Add(this.genericFormatPNumericEdit);
            this.genericGroupBox.Controls.Add(this.formatPLabel);
            this.genericGroupBox.Controls.Add(this.genericCNumericEdit);
            this.genericGroupBox.Controls.Add(this.formatVLabel);
            this.genericGroupBox.Controls.Add(this.genericFormatVNumericEdit);
            this.genericGroupBox.Controls.Add(this.formatCLabel);
            this.genericGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.genericGroupBox.Location = new System.Drawing.Point(344, 160);
            this.genericGroupBox.Name = "genericGroupBox";
            this.genericGroupBox.Size = new System.Drawing.Size(160, 184);
            this.genericGroupBox.TabIndex = 6;
            this.genericGroupBox.TabStop = false;
            this.genericGroupBox.Text = "Generic";
            // 
            // genericFormatPNumericEdit
            // 
            this.genericFormatPNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateGenericMode("P");
            this.genericFormatPNumericEdit.Location = new System.Drawing.Point(16, 152);
            this.genericFormatPNumericEdit.Name = "genericFormatPNumericEdit";
            this.genericFormatPNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.genericFormatPNumericEdit.Source = this.formatMeter;
            this.genericFormatPNumericEdit.TabIndex = 2;
            // 
            // formatPLabel
            // 
            this.formatPLabel.Location = new System.Drawing.Point(16, 136);
            this.formatPLabel.Name = "formatPLabel";
            this.formatPLabel.Size = new System.Drawing.Size(128, 16);
            this.formatPLabel.TabIndex = 31;
            this.formatPLabel.Text = "Format: P";
            // 
            // engineeringGroupBox
            // 
            this.engineeringGroupBox.Controls.Add(this.formatSLabel);
            this.engineeringGroupBox.Controls.Add(this.genericSNumericEdit);
            this.engineeringGroupBox.Controls.Add(this.formatS1HzLabel);
            this.engineeringGroupBox.Controls.Add(this.engS2HzNumericEdit);
            this.engineeringGroupBox.Controls.Add(this.formatEEHzLabel);
            this.engineeringGroupBox.Controls.Add(this.engEEHzNumericEdit);
            this.engineeringGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.engineeringGroupBox.Location = new System.Drawing.Point(344, 352);
            this.engineeringGroupBox.Name = "engineeringGroupBox";
            this.engineeringGroupBox.Size = new System.Drawing.Size(160, 168);
            this.engineeringGroupBox.TabIndex = 7;
            this.engineeringGroupBox.TabStop = false;
            this.engineeringGroupBox.Text = "Engineering";
            // 
            // formatSLabel
            // 
            this.formatSLabel.Location = new System.Drawing.Point(16, 120);
            this.formatSLabel.Name = "formatSLabel";
            this.formatSLabel.Size = new System.Drawing.Size(128, 16);
            this.formatSLabel.TabIndex = 5;
            this.formatSLabel.Text = "Format: S";
            // 
            // genericSNumericEdit
            // 
            this.genericSNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateEngineeringMode("S");
            this.genericSNumericEdit.Location = new System.Drawing.Point(16, 136);
            this.genericSNumericEdit.Name = "genericSNumericEdit";
            this.genericSNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.genericSNumericEdit.Source = this.formatMeter;
            this.genericSNumericEdit.TabIndex = 2;
            // 
            // formatS1HzLabel
            // 
            this.formatS1HzLabel.Location = new System.Drawing.Point(16, 72);
            this.formatS1HzLabel.Name = "formatS1HzLabel";
            this.formatS1HzLabel.Size = new System.Drawing.Size(128, 16);
            this.formatS1HzLabel.TabIndex = 3;
            this.formatS1HzLabel.Text = "Format: S1\'Hz\'";
            // 
            // engS2HzNumericEdit
            // 
            this.engS2HzNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateEngineeringMode("S1\'Hz\'");
            this.engS2HzNumericEdit.Location = new System.Drawing.Point(16, 88);
            this.engS2HzNumericEdit.Name = "engS2HzNumericEdit";
            this.engS2HzNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.engS2HzNumericEdit.Source = this.formatMeter;
            this.engS2HzNumericEdit.TabIndex = 1;
            // 
            // formatEEHzLabel
            // 
            this.formatEEHzLabel.Location = new System.Drawing.Point(16, 24);
            this.formatEEHzLabel.Name = "formatEEHzLabel";
            this.formatEEHzLabel.Size = new System.Drawing.Size(128, 16);
            this.formatEEHzLabel.TabIndex = 0;
            this.formatEEHzLabel.Text = "Format: EE\'Hz\'";
            // 
            // engEEHzNumericEdit
            // 
            this.engEEHzNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateEngineeringMode("EE\'Hz\'");
            this.engEEHzNumericEdit.Location = new System.Drawing.Point(16, 40);
            this.engEEHzNumericEdit.Name = "engEEHzNumericEdit";
            this.engEEHzNumericEdit.Size = new System.Drawing.Size(128, 20);
            this.engEEHzNumericEdit.Source = this.formatMeter;
            this.engEEHzNumericEdit.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(512, 527);
            this.Controls.Add(this.formatMeter);
            this.Controls.Add(this.engineeringGroupBox);
            this.Controls.Add(this.formatKnob);
            this.Controls.Add(this.simpleDoubleGroupBox);
            this.Controls.Add(this.binaryGroupBox);
            this.Controls.Add(this.hexGroupBox);
            this.Controls.Add(this.scientificGroupBox);
            this.Controls.Add(this.genericGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Numeric Control";
            ((System.ComponentModel.ISupportInitialize)(this.formatKnob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formatMeter)).EndInit();
            this.simpleDoubleGroupBox.ResumeLayout(false);
            this.binaryGroupBox.ResumeLayout(false);
            this.hexGroupBox.ResumeLayout(false);
            this.scientificGroupBox.ResumeLayout(false);
            this.genericGroupBox.ResumeLayout(false);
            this.engineeringGroupBox.ResumeLayout(false);
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
    }
}
