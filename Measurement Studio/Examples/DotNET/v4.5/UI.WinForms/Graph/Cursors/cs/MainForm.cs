
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NationalInstruments.Examples.Cursors
{
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private NationalInstruments.UI.XAxis xAxis;
        private NationalInstruments.UI.YAxis yAxis;
        private NationalInstruments.UI.WaveformPlot plot;
        private NationalInstruments.UI.WindowsForms.Switch cursorModeSwitch;
        private System.Windows.Forms.Label cursorLockedLabel;
        private System.Windows.Forms.Label cursorFreeLabel;
        private NationalInstruments.UI.XYCursor cursor;
        private System.Windows.Forms.GroupBox changeCursorPositionGroupBox;
        private System.Windows.Forms.Label changeXPositionLabel;
        private System.Windows.Forms.Label changeYPositionLabel;
        private System.Windows.Forms.Button setPositionButton;
        private System.Windows.Forms.GroupBox changeCursorIndexGroupBox;
        private System.Windows.Forms.Button cursorMoveBackButton;
        private System.Windows.Forms.Button cursorMoveNextButton;
        private System.Windows.Forms.Label changeCursorIndexLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeXPositionNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeYPositionNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeCursorIndexNumericEdit;
		private System.ComponentModel.IContainer components = null;
		
		public MainForm()
		{
			InitializeComponent();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null) 
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
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.cursor = new NationalInstruments.UI.XYCursor();
            this.plot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.cursorModeSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.cursorLockedLabel = new System.Windows.Forms.Label();
            this.cursorFreeLabel = new System.Windows.Forms.Label();
            this.changeCursorPositionGroupBox = new System.Windows.Forms.GroupBox();
            this.changeYPositionLabel = new System.Windows.Forms.Label();
            this.changeXPositionLabel = new System.Windows.Forms.Label();
            this.setPositionButton = new System.Windows.Forms.Button();
            this.changeXPositionNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.changeYPositionNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.changeCursorIndexGroupBox = new System.Windows.Forms.GroupBox();
            this.changeCursorIndexLabel = new System.Windows.Forms.Label();
            this.cursorMoveNextButton = new System.Windows.Forms.Button();
            this.cursorMoveBackButton = new System.Windows.Forms.Button();
            this.changeCursorIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorModeSwitch)).BeginInit();
            this.changeCursorPositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeXPositionNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeYPositionNumericEdit)).BeginInit();
            this.changeCursorIndexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeCursorIndexNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Caption = "Generated Data";
            this.sampleWaveformGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
            this.cursor});
            this.sampleWaveformGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.plot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(408, 240);
            this.sampleWaveformGraph.TabIndex = 0;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // cursor
            // 
            this.cursor.Plot = this.plot;
            this.cursor.AfterMove += new NationalInstruments.UI.AfterMoveXYCursorEventHandler(this.OnCursorAfterMove);
            // 
            // plot
            // 
            this.plot.XAxis = this.xAxis;
            this.plot.YAxis = this.yAxis;
            // 
            // cursorModeSwitch
            // 
            this.cursorModeSwitch.Location = new System.Drawing.Point(16, 280);
            this.cursorModeSwitch.Name = "cursorModeSwitch";
            this.cursorModeSwitch.Size = new System.Drawing.Size(80, 112);
            this.cursorModeSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.cursorModeSwitch.TabIndex = 1;
            this.cursorModeSwitch.Value = true;
            this.cursorModeSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.OnCursorModeStateChanged);
            // 
            // cursorLockedLabel
            // 
            this.cursorLockedLabel.Location = new System.Drawing.Point(16, 256);
            this.cursorLockedLabel.Name = "cursorLockedLabel";
            this.cursorLockedLabel.Size = new System.Drawing.Size(80, 23);
            this.cursorLockedLabel.TabIndex = 2;
            this.cursorLockedLabel.Text = "Cursor Locked";
            this.cursorLockedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cursorFreeLabel
            // 
            this.cursorFreeLabel.Location = new System.Drawing.Point(16, 392);
            this.cursorFreeLabel.Name = "cursorFreeLabel";
            this.cursorFreeLabel.Size = new System.Drawing.Size(80, 23);
            this.cursorFreeLabel.TabIndex = 3;
            this.cursorFreeLabel.Text = "Cursor Free";
            this.cursorFreeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeCursorPositionGroupBox
            // 
            this.changeCursorPositionGroupBox.Controls.Add(this.changeYPositionLabel);
            this.changeCursorPositionGroupBox.Controls.Add(this.changeXPositionLabel);
            this.changeCursorPositionGroupBox.Controls.Add(this.setPositionButton);
            this.changeCursorPositionGroupBox.Controls.Add(this.changeXPositionNumericEdit);
            this.changeCursorPositionGroupBox.Controls.Add(this.changeYPositionNumericEdit);
            this.changeCursorPositionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeCursorPositionGroupBox.Location = new System.Drawing.Point(104, 256);
            this.changeCursorPositionGroupBox.Name = "changeCursorPositionGroupBox";
            this.changeCursorPositionGroupBox.Size = new System.Drawing.Size(312, 88);
            this.changeCursorPositionGroupBox.TabIndex = 4;
            this.changeCursorPositionGroupBox.TabStop = false;
            this.changeCursorPositionGroupBox.Text = "Change Cursor Position";
            // 
            // changeYPositionLabel
            // 
            this.changeYPositionLabel.Location = new System.Drawing.Point(16, 56);
            this.changeYPositionLabel.Name = "changeYPositionLabel";
            this.changeYPositionLabel.Size = new System.Drawing.Size(64, 23);
            this.changeYPositionLabel.TabIndex = 3;
            this.changeYPositionLabel.Text = "Y Position:";
            this.changeYPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeXPositionLabel
            // 
            this.changeXPositionLabel.Location = new System.Drawing.Point(16, 24);
            this.changeXPositionLabel.Name = "changeXPositionLabel";
            this.changeXPositionLabel.Size = new System.Drawing.Size(64, 23);
            this.changeXPositionLabel.TabIndex = 2;
            this.changeXPositionLabel.Text = "X Position:";
            this.changeXPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // setPositionButton
            // 
            this.setPositionButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.setPositionButton.Location = new System.Drawing.Point(168, 40);
            this.setPositionButton.Name = "setPositionButton";
            this.setPositionButton.Size = new System.Drawing.Size(136, 23);
            this.setPositionButton.TabIndex = 2;
            this.setPositionButton.Text = "Set Position";
            this.setPositionButton.Click += new System.EventHandler(this.OnSetPositionClick);
            // 
            // changeXPositionNumericEdit
            // 
            this.changeXPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.changeXPositionNumericEdit.Location = new System.Drawing.Point(88, 24);
            this.changeXPositionNumericEdit.Name = "changeXPositionNumericEdit";
            this.changeXPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeXPositionNumericEdit.Range = new NationalInstruments.UI.Range(0, 100);
            this.changeXPositionNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeXPositionNumericEdit.TabIndex = 0;
            // 
            // changeYPositionNumericEdit
            // 
            this.changeYPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.changeYPositionNumericEdit.Location = new System.Drawing.Point(88, 56);
            this.changeYPositionNumericEdit.Name = "changeYPositionNumericEdit";
            this.changeYPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeYPositionNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.changeYPositionNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeYPositionNumericEdit.TabIndex = 1;
            // 
            // changeCursorIndexGroupBox
            // 
            this.changeCursorIndexGroupBox.Controls.Add(this.changeCursorIndexLabel);
            this.changeCursorIndexGroupBox.Controls.Add(this.cursorMoveNextButton);
            this.changeCursorIndexGroupBox.Controls.Add(this.cursorMoveBackButton);
            this.changeCursorIndexGroupBox.Controls.Add(this.changeCursorIndexNumericEdit);
            this.changeCursorIndexGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeCursorIndexGroupBox.Location = new System.Drawing.Point(104, 352);
            this.changeCursorIndexGroupBox.Name = "changeCursorIndexGroupBox";
            this.changeCursorIndexGroupBox.Size = new System.Drawing.Size(312, 64);
            this.changeCursorIndexGroupBox.TabIndex = 5;
            this.changeCursorIndexGroupBox.TabStop = false;
            this.changeCursorIndexGroupBox.Text = "Change Cursor Index";
            // 
            // changeCursorIndexLabel
            // 
            this.changeCursorIndexLabel.Location = new System.Drawing.Point(16, 24);
            this.changeCursorIndexLabel.Name = "changeCursorIndexLabel";
            this.changeCursorIndexLabel.Size = new System.Drawing.Size(64, 23);
            this.changeCursorIndexLabel.TabIndex = 2;
            this.changeCursorIndexLabel.Text = "Index:";
            this.changeCursorIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cursorMoveNextButton
            // 
            this.cursorMoveNextButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cursorMoveNextButton.Location = new System.Drawing.Point(240, 24);
            this.cursorMoveNextButton.Name = "cursorMoveNextButton";
            this.cursorMoveNextButton.Size = new System.Drawing.Size(64, 23);
            this.cursorMoveNextButton.TabIndex = 2;
            this.cursorMoveNextButton.Text = "Next >>";
            this.cursorMoveNextButton.Click += new System.EventHandler(this.OnCursorMoveNextClick);
            // 
            // cursorMoveBackButton
            // 
            this.cursorMoveBackButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cursorMoveBackButton.Location = new System.Drawing.Point(168, 24);
            this.cursorMoveBackButton.Name = "cursorMoveBackButton";
            this.cursorMoveBackButton.Size = new System.Drawing.Size(64, 23);
            this.cursorMoveBackButton.TabIndex = 1;
            this.cursorMoveBackButton.Text = "<< Back";
            this.cursorMoveBackButton.Click += new System.EventHandler(this.OnCursorMoveBackClick);
            // 
            // changeCursorIndexNumericEdit
            // 
            this.changeCursorIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.changeCursorIndexNumericEdit.Location = new System.Drawing.Point(88, 24);
            this.changeCursorIndexNumericEdit.Name = "changeCursorIndexNumericEdit";
            this.changeCursorIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeCursorIndexNumericEdit.Range = new NationalInstruments.UI.Range(0, 99);
            this.changeCursorIndexNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeCursorIndexNumericEdit.TabIndex = 0;
            this.changeCursorIndexNumericEdit.Value = 1;
            this.changeCursorIndexNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.OnChangeCursorIndexValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(426, 424);
            this.Controls.Add(this.changeCursorIndexGroupBox);
            this.Controls.Add(this.changeCursorPositionGroupBox);
            this.Controls.Add(this.cursorFreeLabel);
            this.Controls.Add(this.cursorLockedLabel);
            this.Controls.Add(this.cursorModeSwitch);
            this.Controls.Add(this.sampleWaveformGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursors";
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorModeSwitch)).EndInit();
            this.changeCursorPositionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeXPositionNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeYPositionNumericEdit)).EndInit();
            this.changeCursorIndexGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeCursorIndexNumericEdit)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new MainForm());
		}

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            double[] data = new double[100];
            for (int i = 0; i < data.Length; ++i)
                data[i] = 10.0 * Math.Sin(i / Math.PI);

            plot.PlotY(data);
        }

        private void OnCursorAfterMove(object sender, NationalInstruments.UI.AfterMoveXYCursorEventArgs e)
        {
            changeXPositionNumericEdit.Value = cursor.XPosition;
            changeYPositionNumericEdit.Value = cursor.YPosition;
            changeCursorIndexNumericEdit.Value = cursor.GetCurrentIndex();
        }

        private void OnCursorModeStateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            bool indexControlsEnabled = false;
            if (cursorModeSwitch.Value)
            {
                cursor.SnapMode = CursorSnapMode.ToPlot;
                indexControlsEnabled = true;
            }
            else
            {
                cursor.SnapMode = CursorSnapMode.Floating;
                indexControlsEnabled = false;
            }

            changeCursorIndexNumericEdit.Enabled = indexControlsEnabled;
            cursorMoveBackButton.Enabled = indexControlsEnabled;
            cursorMoveNextButton.Enabled = indexControlsEnabled;
        }

        private void OnSetPositionClick(object sender, System.EventArgs e)
        {
            double xPosition = (double)changeXPositionNumericEdit.Value;
            double yPosition = (double)changeYPositionNumericEdit.Value;
            cursor.MoveCursor(xPosition, yPosition);
        }

        private void OnChangeCursorIndexValueChanged(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            cursor.MoveCursor((int)changeCursorIndexNumericEdit.Value);
        }

        private void OnCursorMoveBackClick(object sender, System.EventArgs e)
        {
            cursor.MovePrevious();
        }

        private void OnCursorMoveNextClick(object sender, System.EventArgs e)
        {
            cursor.MoveNext();
        }
	}
}
