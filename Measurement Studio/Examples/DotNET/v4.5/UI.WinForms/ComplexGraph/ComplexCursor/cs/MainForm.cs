
using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace NationalInstruments.Examples.ComplexCursor
{
	public class MainForm : System.Windows.Forms.Form
	{
        private NationalInstruments.UI.ComplexXAxis realAxis;
        private NationalInstruments.UI.ComplexYAxis imaginaryAxis;
        private NationalInstruments.UI.ComplexPlot plot;
        private NationalInstruments.UI.WindowsForms.Switch cursorModeSwitch;
        private System.Windows.Forms.Label cursorLockedLabel;
        private System.Windows.Forms.Label cursorFreeLabel;
        private System.Windows.Forms.GroupBox changeCursorPositionGroupBox;
        private System.Windows.Forms.Label changeRealPositionLabel;
        private System.Windows.Forms.Label changeImaginaryPositionLabel;
        private System.Windows.Forms.Button setPositionButton;
        private System.Windows.Forms.GroupBox changeCursorIndexGroupBox;
        private System.Windows.Forms.Button cursorMoveBackButton;
        private System.Windows.Forms.Button cursorMoveNextButton;
        private System.Windows.Forms.Label changeCursorIndexLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeRealPositionNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeImaginaryPositionNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeCursorIndexNumericEdit;
        private NationalInstruments.UI.WindowsForms.ComplexGraph sampleComplexGraph;
        private NationalInstruments.UI.ComplexCursor dataCursor;
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.sampleComplexGraph = new NationalInstruments.UI.WindowsForms.ComplexGraph();
            this.dataCursor = new NationalInstruments.UI.ComplexCursor();
            this.plot = new NationalInstruments.UI.ComplexPlot();
            this.realAxis = new NationalInstruments.UI.ComplexXAxis();
            this.imaginaryAxis = new NationalInstruments.UI.ComplexYAxis();
            this.cursorModeSwitch = new NationalInstruments.UI.WindowsForms.Switch();
            this.cursorLockedLabel = new System.Windows.Forms.Label();
            this.cursorFreeLabel = new System.Windows.Forms.Label();
            this.changeCursorPositionGroupBox = new System.Windows.Forms.GroupBox();
            this.changeImaginaryPositionLabel = new System.Windows.Forms.Label();
            this.changeRealPositionLabel = new System.Windows.Forms.Label();
            this.setPositionButton = new System.Windows.Forms.Button();
            this.changeRealPositionNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.changeImaginaryPositionNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.changeCursorIndexGroupBox = new System.Windows.Forms.GroupBox();
            this.changeCursorIndexLabel = new System.Windows.Forms.Label();
            this.cursorMoveNextButton = new System.Windows.Forms.Button();
            this.cursorMoveBackButton = new System.Windows.Forms.Button();
            this.changeCursorIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorModeSwitch)).BeginInit();
            this.changeCursorPositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeRealPositionNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeImaginaryPositionNumericEdit)).BeginInit();
            this.changeCursorIndexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeCursorIndexNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleComplexGraph
            // 
            this.sampleComplexGraph.Caption = "Generated Data";
            this.sampleComplexGraph.Cursors.AddRange(new NationalInstruments.UI.ComplexCursor[] {
                                                                                                    this.dataCursor});
            this.sampleComplexGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleComplexGraph.Name = "sampleComplexGraph";
            this.sampleComplexGraph.Plots.AddRange(new NationalInstruments.UI.ComplexPlot[] {
                                                                                                this.plot});
            this.sampleComplexGraph.Size = new System.Drawing.Size(408, 240);
            this.sampleComplexGraph.TabIndex = 0;
            this.sampleComplexGraph.XAxes.AddRange(new NationalInstruments.UI.ComplexXAxis[] {
                                                                                                 this.realAxis});
            this.sampleComplexGraph.YAxes.AddRange(new NationalInstruments.UI.ComplexYAxis[] {
                                                                                                 this.imaginaryAxis});
            // 
            // dataCursor
            // 
            this.dataCursor.Color = System.Drawing.Color.Crimson;
            this.dataCursor.LabelVisible = true;
            this.dataCursor.Plot = this.plot;
            this.dataCursor.AfterMove += new NationalInstruments.UI.AfterMoveComplexCursorEventHandler(this.OnCursorAfterMove);
            // 
            // plot
            // 
            this.plot.XAxis = this.realAxis;
            this.plot.YAxis = this.imaginaryAxis;
            // 
            // cursorModeSwitch
            // 
            this.cursorModeSwitch.Location = new System.Drawing.Point(16, 280);
            this.cursorModeSwitch.Name = "cursorModeSwitch";
            this.cursorModeSwitch.Size = new System.Drawing.Size(80, 112);
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
            this.changeCursorPositionGroupBox.Controls.Add(this.changeImaginaryPositionLabel);
            this.changeCursorPositionGroupBox.Controls.Add(this.changeRealPositionLabel);
            this.changeCursorPositionGroupBox.Controls.Add(this.setPositionButton);
            this.changeCursorPositionGroupBox.Controls.Add(this.changeRealPositionNumericEdit);
            this.changeCursorPositionGroupBox.Controls.Add(this.changeImaginaryPositionNumericEdit);
            this.changeCursorPositionGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeCursorPositionGroupBox.Location = new System.Drawing.Point(104, 256);
            this.changeCursorPositionGroupBox.Name = "changeCursorPositionGroupBox";
            this.changeCursorPositionGroupBox.Size = new System.Drawing.Size(312, 88);
            this.changeCursorPositionGroupBox.TabIndex = 4;
            this.changeCursorPositionGroupBox.TabStop = false;
            this.changeCursorPositionGroupBox.Text = "Change Cursor Position";
            // 
            // changeImaginaryPositionLabel
            // 
            this.changeImaginaryPositionLabel.Location = new System.Drawing.Point(16, 56);
            this.changeImaginaryPositionLabel.Name = "changeImaginaryPositionLabel";
            this.changeImaginaryPositionLabel.Size = new System.Drawing.Size(64, 23);
            this.changeImaginaryPositionLabel.TabIndex = 3;
            this.changeImaginaryPositionLabel.Text = "Imaginary";
            this.changeImaginaryPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeRealPositionLabel
            // 
            this.changeRealPositionLabel.Location = new System.Drawing.Point(16, 24);
            this.changeRealPositionLabel.Name = "changeRealPositionLabel";
            this.changeRealPositionLabel.Size = new System.Drawing.Size(64, 23);
            this.changeRealPositionLabel.TabIndex = 2;
            this.changeRealPositionLabel.Text = "Real:";
            this.changeRealPositionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // changeRealPositionNumericEdit
            // 
            this.changeRealPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.changeRealPositionNumericEdit.Location = new System.Drawing.Point(88, 24);
            this.changeRealPositionNumericEdit.Name = "changeRealPositionNumericEdit";
            this.changeRealPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeRealPositionNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.changeRealPositionNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeRealPositionNumericEdit.TabIndex = 0;
            // 
            // changeImaginaryPositionNumericEdit
            // 
            this.changeImaginaryPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.changeImaginaryPositionNumericEdit.Location = new System.Drawing.Point(88, 56);
            this.changeImaginaryPositionNumericEdit.Name = "changeImaginaryPositionNumericEdit";
            this.changeImaginaryPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeImaginaryPositionNumericEdit.Range = new NationalInstruments.UI.Range(-10, 10);
            this.changeImaginaryPositionNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeImaginaryPositionNumericEdit.TabIndex = 1;
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
            this.Controls.Add(this.sampleComplexGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursors";
            ((System.ComponentModel.ISupportInitialize)(this.sampleComplexGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorModeSwitch)).EndInit();
            this.changeCursorPositionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeRealPositionNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeImaginaryPositionNumericEdit)).EndInit();
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

            ComplexDouble[] data = new ComplexDouble[100];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i].Real = i / 100.0 * 20.0 - 10 ;
                data[i].Imaginary = 10.0 * Math.Sin(i / Math.PI);
            }

            plot.PlotComplex(data);            
        }

        private void OnCursorAfterMove(object sender, NationalInstruments.UI.AfterMoveComplexCursorEventArgs e)
        {
            changeRealPositionNumericEdit.Value = dataCursor.Position.Real;
            changeImaginaryPositionNumericEdit.Value = dataCursor.Position.Imaginary;
            changeCursorIndexNumericEdit.Value = dataCursor.GetCurrentIndex();
        }

        private void OnCursorModeStateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            bool indexControlsEnabled = false;
            if (cursorModeSwitch.Value)
            {
                dataCursor.SnapMode = CursorSnapMode.ToPlot;
                indexControlsEnabled = true;
            }
            else
            {
                dataCursor.SnapMode = CursorSnapMode.Floating;
                indexControlsEnabled = false;
            }

            changeCursorIndexNumericEdit.Enabled = indexControlsEnabled;
            cursorMoveBackButton.Enabled = indexControlsEnabled;
            cursorMoveNextButton.Enabled = indexControlsEnabled;
        }

        private void OnSetPositionClick(object sender, System.EventArgs e)
        {
            double xPosition = changeRealPositionNumericEdit.Value;
            double yPosition = changeImaginaryPositionNumericEdit.Value;
            dataCursor.MoveCursor(new ComplexDouble( xPosition, yPosition) );
        }

        private void OnChangeCursorIndexValueChanged(object sender, NationalInstruments.UI.AfterChangeNumericValueEventArgs e)
        {
            dataCursor.MoveCursor((int)changeCursorIndexNumericEdit.Value);
        }

        private void OnCursorMoveBackClick(object sender, System.EventArgs e)
        {
            dataCursor.MovePrevious();
        }

        private void OnCursorMoveNextClick(object sender, System.EventArgs e)
        {
            dataCursor.MoveNext();
        }
	}
}
