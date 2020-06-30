
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NationalInstruments.Examples.IntensityCursors
{
    public class MainForm : System.Windows.Forms.Form
    {
        private NationalInstruments.UI.WindowsForms.IntensityGraph sampleIntensityGraph;
        private NationalInstruments.UI.IntensityXAxis xAxis;
        private NationalInstruments.UI.IntensityYAxis yAxis;
        private NationalInstruments.UI.IntensityPlot plot;
        private NationalInstruments.UI.ColorScale colorScale;
        private NationalInstruments.UI.WindowsForms.Switch cursorModeSwitch;
        private System.Windows.Forms.Label cursorLockedLabel;
        private System.Windows.Forms.Label cursorFreeLabel;
        private NationalInstruments.UI.IntensityCursor cursor;
        private System.Windows.Forms.GroupBox changeCursorPositionGroupBox;
        private System.Windows.Forms.Label changeXPositionLabel;
        private System.Windows.Forms.Label changeYPositionLabel;
        private System.Windows.Forms.Button setPositionButton;
        private System.Windows.Forms.GroupBox changeCursorIndexGroupBox;
        private System.Windows.Forms.Button cursorMoveBackXButton;
        private System.Windows.Forms.Button cursorMoveNextXButton;
        private System.Windows.Forms.Label changeCursorXIndexLabel;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeXPositionNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeYPositionNumericEdit;
        private NationalInstruments.UI.WindowsForms.NumericEdit changeCursorXIndexNumericEdit;
        private Label changeCursorYIndexLabel;
        private Button cursorMoveNextYButton;
        private Button cursorMoveBackYButton;
        private NumericEdit changeCursorYIndexNumericEdit;
        private CheckBox pixelInterpolationCheckBox;
        private System.ComponentModel.IContainer components = null;

        public MainForm()
        {
            InitializeComponent();

            pixelInterpolationCheckBox.Checked = plot.PixelInterpolation;
            plot.SmoothUpdates = true; // Setting SmoothUpdates to true improves Cursor Interaction.
            InitializeColorScale();
            PlotIntensityData();
        }

        #region Windows Form Designer generated code

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
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
        
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleIntensityGraph = new NationalInstruments.UI.WindowsForms.IntensityGraph();
            this.colorScale = new NationalInstruments.UI.ColorScale();
            this.cursor = new NationalInstruments.UI.IntensityCursor();
            this.plot = new NationalInstruments.UI.IntensityPlot();
            this.xAxis = new NationalInstruments.UI.IntensityXAxis();
            this.yAxis = new NationalInstruments.UI.IntensityYAxis();
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
            this.changeCursorYIndexLabel = new System.Windows.Forms.Label();
            this.changeCursorXIndexLabel = new System.Windows.Forms.Label();
            this.cursorMoveNextYButton = new System.Windows.Forms.Button();
            this.cursorMoveNextXButton = new System.Windows.Forms.Button();
            this.cursorMoveBackYButton = new System.Windows.Forms.Button();
            this.changeCursorYIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.cursorMoveBackXButton = new System.Windows.Forms.Button();
            this.changeCursorXIndexNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.pixelInterpolationCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.sampleIntensityGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorModeSwitch)).BeginInit();
            this.changeCursorPositionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeXPositionNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeYPositionNumericEdit)).BeginInit();
            this.changeCursorIndexGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.changeCursorYIndexNumericEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeCursorXIndexNumericEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleIntensityGraph
            // 
            this.sampleIntensityGraph.CanShowFocus = true;
            this.sampleIntensityGraph.Caption = "Intensity Graph";
            this.sampleIntensityGraph.ColorScales.AddRange(new NationalInstruments.UI.ColorScale[] {
            this.colorScale});
            this.sampleIntensityGraph.Cursors.AddRange(new NationalInstruments.UI.IntensityCursor[] {
            this.cursor});
            this.sampleIntensityGraph.Location = new System.Drawing.Point(8, 8);
            this.sampleIntensityGraph.Name = "sampleIntensityGraph";
            this.sampleIntensityGraph.Plots.AddRange(new NationalInstruments.UI.IntensityPlot[] {
            this.plot});
            this.sampleIntensityGraph.Size = new System.Drawing.Size(408, 240);
            this.sampleIntensityGraph.TabIndex = 0;
            this.sampleIntensityGraph.XAxes.AddRange(new NationalInstruments.UI.IntensityXAxis[] {
            this.xAxis});
            this.sampleIntensityGraph.YAxes.AddRange(new NationalInstruments.UI.IntensityYAxis[] {
            this.yAxis});
            // 
            // cursor
            // 
            this.cursor.LabelVisible = true;
            this.cursor.Plot = this.plot;
            this.cursor.AfterMove += new NationalInstruments.UI.AfterMoveIntensityCursorEventHandler(this.OnCursorAfterMove);
            // 
            // plot
            // 
            this.plot.ColorScale = this.colorScale;
            this.plot.XAxis = this.xAxis;
            this.plot.YAxis = this.yAxis;
            // 
            // cursorModeSwitch
            // 
            this.cursorModeSwitch.CanShowFocus = true;
            this.cursorModeSwitch.Location = new System.Drawing.Point(16, 301);
            this.cursorModeSwitch.Name = "cursorModeSwitch";
            this.cursorModeSwitch.Size = new System.Drawing.Size(80, 109);
            this.cursorModeSwitch.SwitchStyle = NationalInstruments.UI.SwitchStyle.VerticalToggle3D;
            this.cursorModeSwitch.TabIndex = 2;
            this.cursorModeSwitch.Value = true;
            this.cursorModeSwitch.StateChanged += new NationalInstruments.UI.ActionEventHandler(this.OnCursorModeStateChanged);
            // 
            // cursorLockedLabel
            // 
            this.cursorLockedLabel.Location = new System.Drawing.Point(16, 277);
            this.cursorLockedLabel.Name = "cursorLockedLabel";
            this.cursorLockedLabel.Size = new System.Drawing.Size(80, 23);
            this.cursorLockedLabel.TabIndex = 2;
            this.cursorLockedLabel.Text = "Cursor Locked";
            this.cursorLockedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cursorFreeLabel
            // 
            this.cursorFreeLabel.Location = new System.Drawing.Point(16, 413);
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
            this.changeCursorPositionGroupBox.Location = new System.Drawing.Point(104, 277);
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
            this.changeXPositionNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeXPositionNumericEdit.TabIndex = 0;
            // 
            // changeYPositionNumericEdit
            // 
            this.changeYPositionNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3);
            this.changeYPositionNumericEdit.Location = new System.Drawing.Point(88, 56);
            this.changeYPositionNumericEdit.Name = "changeYPositionNumericEdit";
            this.changeYPositionNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeYPositionNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeYPositionNumericEdit.TabIndex = 1;
            // 
            // changeCursorIndexGroupBox
            // 
            this.changeCursorIndexGroupBox.Controls.Add(this.changeCursorYIndexLabel);
            this.changeCursorIndexGroupBox.Controls.Add(this.changeCursorXIndexLabel);
            this.changeCursorIndexGroupBox.Controls.Add(this.cursorMoveNextYButton);
            this.changeCursorIndexGroupBox.Controls.Add(this.cursorMoveNextXButton);
            this.changeCursorIndexGroupBox.Controls.Add(this.cursorMoveBackYButton);
            this.changeCursorIndexGroupBox.Controls.Add(this.changeCursorYIndexNumericEdit);
            this.changeCursorIndexGroupBox.Controls.Add(this.cursorMoveBackXButton);
            this.changeCursorIndexGroupBox.Controls.Add(this.changeCursorXIndexNumericEdit);
            this.changeCursorIndexGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeCursorIndexGroupBox.Location = new System.Drawing.Point(104, 373);
            this.changeCursorIndexGroupBox.Name = "changeCursorIndexGroupBox";
            this.changeCursorIndexGroupBox.Size = new System.Drawing.Size(312, 88);
            this.changeCursorIndexGroupBox.TabIndex = 5;
            this.changeCursorIndexGroupBox.TabStop = false;
            this.changeCursorIndexGroupBox.Text = "Change Cursor Indexes";
            // 
            // changeCursorYIndexLabel
            // 
            this.changeCursorYIndexLabel.Location = new System.Drawing.Point(16, 57);
            this.changeCursorYIndexLabel.Name = "changeCursorYIndexLabel";
            this.changeCursorYIndexLabel.Size = new System.Drawing.Size(64, 23);
            this.changeCursorYIndexLabel.TabIndex = 2;
            this.changeCursorYIndexLabel.Text = "Y Index:";
            this.changeCursorYIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeCursorXIndexLabel
            // 
            this.changeCursorXIndexLabel.Location = new System.Drawing.Point(16, 24);
            this.changeCursorXIndexLabel.Name = "changeCursorXIndexLabel";
            this.changeCursorXIndexLabel.Size = new System.Drawing.Size(64, 23);
            this.changeCursorXIndexLabel.TabIndex = 2;
            this.changeCursorXIndexLabel.Text = "X Index:";
            this.changeCursorXIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cursorMoveNextYButton
            // 
            this.cursorMoveNextYButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cursorMoveNextYButton.Location = new System.Drawing.Point(240, 57);
            this.cursorMoveNextYButton.Name = "cursorMoveNextYButton";
            this.cursorMoveNextYButton.Size = new System.Drawing.Size(64, 23);
            this.cursorMoveNextYButton.TabIndex = 5;
            this.cursorMoveNextYButton.Text = "Next >>";
            this.cursorMoveNextYButton.Click += new System.EventHandler(this.OnCursorMoveNextYClick);
            // 
            // cursorMoveNextXButton
            // 
            this.cursorMoveNextXButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cursorMoveNextXButton.Location = new System.Drawing.Point(240, 24);
            this.cursorMoveNextXButton.Name = "cursorMoveNextXButton";
            this.cursorMoveNextXButton.Size = new System.Drawing.Size(64, 23);
            this.cursorMoveNextXButton.TabIndex = 2;
            this.cursorMoveNextXButton.Text = "Next >>";
            this.cursorMoveNextXButton.Click += new System.EventHandler(this.OnCursorMoveNextXClick);
            // 
            // cursorMoveBackYButton
            // 
            this.cursorMoveBackYButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cursorMoveBackYButton.Location = new System.Drawing.Point(168, 57);
            this.cursorMoveBackYButton.Name = "cursorMoveBackYButton";
            this.cursorMoveBackYButton.Size = new System.Drawing.Size(64, 23);
            this.cursorMoveBackYButton.TabIndex = 4;
            this.cursorMoveBackYButton.Text = "<< Back";
            this.cursorMoveBackYButton.Click += new System.EventHandler(this.OnCursorMoveBackYClick);
            // 
            // changeCursorYIndexNumericEdit
            // 
            this.changeCursorYIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.changeCursorYIndexNumericEdit.Location = new System.Drawing.Point(88, 58);
            this.changeCursorYIndexNumericEdit.Name = "changeCursorYIndexNumericEdit";
            this.changeCursorYIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeCursorYIndexNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeCursorYIndexNumericEdit.TabIndex = 3;
            this.changeCursorYIndexNumericEdit.Value = 1D;
            this.changeCursorYIndexNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.OnChangeCursorYIndexValueChanged);
            // 
            // cursorMoveBackXButton
            // 
            this.cursorMoveBackXButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cursorMoveBackXButton.Location = new System.Drawing.Point(168, 24);
            this.cursorMoveBackXButton.Name = "cursorMoveBackXButton";
            this.cursorMoveBackXButton.Size = new System.Drawing.Size(64, 23);
            this.cursorMoveBackXButton.TabIndex = 1;
            this.cursorMoveBackXButton.Text = "<< Back";
            this.cursorMoveBackXButton.Click += new System.EventHandler(this.OnCursorMoveBackXClick);
            // 
            // changeCursorXIndexNumericEdit
            // 
            this.changeCursorXIndexNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.changeCursorXIndexNumericEdit.Location = new System.Drawing.Point(88, 25);
            this.changeCursorXIndexNumericEdit.Name = "changeCursorXIndexNumericEdit";
            this.changeCursorXIndexNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.changeCursorXIndexNumericEdit.Size = new System.Drawing.Size(72, 20);
            this.changeCursorXIndexNumericEdit.TabIndex = 0;
            this.changeCursorXIndexNumericEdit.Value = 1D;
            this.changeCursorXIndexNumericEdit.BeforeChangeValue += new NationalInstruments.UI.BeforeChangeNumericValueEventHandler(this.OnChangeCursorXIndexValueChanged);
            // 
            // pixelInterpolationCheckBox
            // 
            this.pixelInterpolationCheckBox.AutoSize = true;
            this.pixelInterpolationCheckBox.Location = new System.Drawing.Point(307, 254);
            this.pixelInterpolationCheckBox.Name = "pixelInterpolationCheckBox";
            this.pixelInterpolationCheckBox.Size = new System.Drawing.Size(109, 17);
            this.pixelInterpolationCheckBox.TabIndex = 1;
            this.pixelInterpolationCheckBox.Text = "Pixel Interpolation";
            this.pixelInterpolationCheckBox.UseVisualStyleBackColor = true;
            this.pixelInterpolationCheckBox.CheckedChanged += new System.EventHandler(this.OnPixelInterpolationCheckBoxCheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(426, 467);
            this.Controls.Add(this.pixelInterpolationCheckBox);
            this.Controls.Add(this.changeCursorIndexGroupBox);
            this.Controls.Add(this.changeCursorPositionGroupBox);
            this.Controls.Add(this.cursorFreeLabel);
            this.Controls.Add(this.cursorLockedLabel);
            this.Controls.Add(this.cursorModeSwitch);
            this.Controls.Add(this.sampleIntensityGraph);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intensity Cursors";
            ((System.ComponentModel.ISupportInitialize)(this.sampleIntensityGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cursorModeSwitch)).EndInit();
            this.changeCursorPositionGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeXPositionNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeYPositionNumericEdit)).EndInit();
            this.changeCursorIndexGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.changeCursorYIndexNumericEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.changeCursorXIndexNumericEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private void InitializeColorScale()
        {
            // Initialize the ColorScale corresponding to VIBGYOR
            colorScale.Range = new Range(0, 6);
            colorScale.HighColor = Color.Violet;
            colorScale.ColorMap.Add(5, Color.Indigo);
            colorScale.ColorMap.Add(4, Color.Blue);
            colorScale.ColorMap.Add(3, Color.Green);
            colorScale.ColorMap.Add(2, Color.Yellow);
            colorScale.ColorMap.Add(1, Color.Orange);
            colorScale.LowColor = Color.Red;
        }

        private void PlotIntensityData()
        {
            // Generate Data
            int numPoints = 21;
            double[,] zData = new double[numPoints, numPoints];
            for (int i = 0; i < numPoints; i++)
            {
                for (int j = 0; j < numPoints; j++)
                {
                    zData[i, j] = i*i + j*j;
                }
            }

            // Scale the colorscale depending on the data generated.
            colorScale.ScaleColorScale(new Range(0, zData[numPoints - 1, numPoints - 1]));

            // Plot the Data.
            plot.Plot(zData);
        }

        void OnPixelInterpolationCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            plot.PixelInterpolation = pixelInterpolationCheckBox.Checked;
        }
       
        private void OnCursorAfterMove(object sender, NationalInstruments.UI.AfterMoveIntensityCursorEventArgs e)
        {
            changeXPositionNumericEdit.Value = cursor.XPosition;
            changeYPositionNumericEdit.Value = cursor.YPosition;
            int xIndex, yIndex;
            cursor.GetCurrentIndexes(out xIndex, out yIndex);
            changeCursorXIndexNumericEdit.Value = xIndex;
            changeCursorYIndexNumericEdit.Value = yIndex;
        }

        private void OnCursorModeStateChanged(object sender, NationalInstruments.UI.ActionEventArgs e)
        {
            if (cursorModeSwitch.Value)
                cursor.SnapMode = CursorSnapMode.ToPlot;
            else
                cursor.SnapMode = CursorSnapMode.Floating;

            changeCursorIndexGroupBox.Enabled = cursorModeSwitch.Value;
        }

        private void OnSetPositionClick(object sender, System.EventArgs e)
        {
            double xPosition = changeXPositionNumericEdit.Value;
            double yPosition = changeYPositionNumericEdit.Value;
            cursor.MoveCursor(xPosition, yPosition);
            changeXPositionNumericEdit.Value = cursor.XPosition;
            changeYPositionNumericEdit.Value = cursor.YPosition;
        }

        private void OnChangeCursorXIndexValueChanged(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            try
            {   
                int currentXIndex, currentYIndex;
                cursor.GetCurrentIndexes(out currentXIndex, out currentYIndex);
                cursor.MoveCursor((int)e.NewValue, currentYIndex);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void OnChangeCursorYIndexValueChanged(object sender, NationalInstruments.UI.BeforeChangeNumericValueEventArgs e)
        {
            try
            {
                int currentXIndex, currentYIndex;
                cursor.GetCurrentIndexes(out currentXIndex, out currentYIndex);
                cursor.MoveCursor(currentXIndex, (int)e.NewValue);
            }
            catch
            {
                e.Cancel = true;
            }
        }

        private void OnCursorMoveBackXClick(object sender, System.EventArgs e)
        {
            cursor.MovePreviousX();
        }

        private void OnCursorMoveNextXClick(object sender, System.EventArgs e)
        {
            cursor.MoveNextX();
        }

        private void OnCursorMoveBackYClick(object sender, System.EventArgs e)
        {
            cursor.MovePreviousY();
        }

        private void OnCursorMoveNextYClick(object sender, System.EventArgs e)
        {
            cursor.MoveNextY();
        }
    }
}
