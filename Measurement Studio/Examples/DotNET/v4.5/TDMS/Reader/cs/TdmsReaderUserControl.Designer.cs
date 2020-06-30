namespace NationalInstruments.Examples.Reader
{
    partial class TdmsReaderUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tdmsDataGridView = new System.Windows.Forms.DataGridView();
            this.tdmsFileAndPropertiesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tdmsFileSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tmdsFileLabel = new System.Windows.Forms.Label();
            this.tdmsFileTreeView = new System.Windows.Forms.TreeView();
            this.tdmsPropertiesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tdmsPropertiesLabel = new System.Windows.Forms.Label();
            this.tdmsPropertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.tdmsPropertyNamesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmdsPropertyValuesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdmsFileAndDataSplitContainer = new System.Windows.Forms.SplitContainer();
            this.tdmsDataTabControl = new System.Windows.Forms.TabControl();
            this.tdmsDataTabPage = new System.Windows.Forms.TabPage();
            this.tdmsGraphTabPage = new System.Windows.Forms.TabPage();
            this.tdmsWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.tdmsWaveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.tdmsXAxis = new NationalInstruments.UI.XAxis();
            this.tdmsYAxis = new NationalInstruments.UI.YAxis();
            this.tdmsDigitalWaveformGraph = new NationalInstruments.UI.WindowsForms.DigitalWaveformGraph();
            this.loadValuesButton = new System.Windows.Forms.Button();
            this.tdmsDataIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tdmsDataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tdmsDataGridView)).BeginInit();
            this.tdmsFileAndPropertiesSplitContainer.Panel1.SuspendLayout();
            this.tdmsFileAndPropertiesSplitContainer.Panel2.SuspendLayout();
            this.tdmsFileAndPropertiesSplitContainer.SuspendLayout();
            this.tdmsFileSplitContainer.Panel1.SuspendLayout();
            this.tdmsFileSplitContainer.Panel2.SuspendLayout();
            this.tdmsFileSplitContainer.SuspendLayout();
            this.tdmsPropertiesSplitContainer.Panel1.SuspendLayout();
            this.tdmsPropertiesSplitContainer.Panel2.SuspendLayout();
            this.tdmsPropertiesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdmsPropertiesDataGridView)).BeginInit();
            this.tdmsFileAndDataSplitContainer.Panel1.SuspendLayout();
            this.tdmsFileAndDataSplitContainer.Panel2.SuspendLayout();
            this.tdmsFileAndDataSplitContainer.SuspendLayout();
            this.tdmsDataTabControl.SuspendLayout();
            this.tdmsDataTabPage.SuspendLayout();
            this.tdmsGraphTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdmsWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdmsDigitalWaveformGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // tdmsDataGridView
            // 
            this.tdmsDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tdmsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdmsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdmsDataIndexColumn,
            this.tdmsDataColumn});
            this.tdmsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.tdmsDataGridView.Name = "tdmsDataGridView";
            this.tdmsDataGridView.ReadOnly = true;
            this.tdmsDataGridView.RowHeadersVisible = false;
            this.tdmsDataGridView.Size = new System.Drawing.Size(443, 313);
            this.tdmsDataGridView.TabIndex = 0;
            // 
            // tdmsFileAndPropertiesSplitContainer
            // 
            this.tdmsFileAndPropertiesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsFileAndPropertiesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tdmsFileAndPropertiesSplitContainer.Name = "tdmsFileAndPropertiesSplitContainer";
            // 
            // tdmsFileAndPropertiesSplitContainer.Panel1
            // 
            this.tdmsFileAndPropertiesSplitContainer.Panel1.Controls.Add(this.tdmsFileSplitContainer);
            // 
            // tdmsFileAndPropertiesSplitContainer.Panel2
            // 
            this.tdmsFileAndPropertiesSplitContainer.Panel2.Controls.Add(this.tdmsPropertiesSplitContainer);
            this.tdmsFileAndPropertiesSplitContainer.Size = new System.Drawing.Size(457, 268);
            this.tdmsFileAndPropertiesSplitContainer.SplitterDistance = 190;
            this.tdmsFileAndPropertiesSplitContainer.TabIndex = 7;
            // 
            // tdmsFileSplitContainer
            // 
            this.tdmsFileSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsFileSplitContainer.IsSplitterFixed = true;
            this.tdmsFileSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tdmsFileSplitContainer.Name = "tdmsFileSplitContainer";
            this.tdmsFileSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tdmsFileSplitContainer.Panel1
            // 
            this.tdmsFileSplitContainer.Panel1.Controls.Add(this.tmdsFileLabel);
            this.tdmsFileSplitContainer.Panel1MinSize = 15;
            // 
            // tdmsFileSplitContainer.Panel2
            // 
            this.tdmsFileSplitContainer.Panel2.Controls.Add(this.tdmsFileTreeView);
            this.tdmsFileSplitContainer.Size = new System.Drawing.Size(190, 268);
            this.tdmsFileSplitContainer.SplitterDistance = 15;
            this.tdmsFileSplitContainer.TabIndex = 0;
            // 
            // tmdsFileLabel
            // 
            this.tmdsFileLabel.AutoSize = true;
            this.tmdsFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tmdsFileLabel.Location = new System.Drawing.Point(3, 0);
            this.tmdsFileLabel.Name = "tmdsFileLabel";
            this.tmdsFileLabel.Size = new System.Drawing.Size(57, 13);
            this.tmdsFileLabel.TabIndex = 10;
            this.tmdsFileLabel.Text = "TDMS File";
            // 
            // tdmsFileTreeView
            // 
            this.tdmsFileTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsFileTreeView.Location = new System.Drawing.Point(0, 0);
            this.tdmsFileTreeView.Name = "tdmsFileTreeView";
            this.tdmsFileTreeView.Size = new System.Drawing.Size(190, 249);
            this.tdmsFileTreeView.TabIndex = 1;
            // 
            // tdmsPropertiesSplitContainer
            // 
            this.tdmsPropertiesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsPropertiesSplitContainer.IsSplitterFixed = true;
            this.tdmsPropertiesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.tdmsPropertiesSplitContainer.Name = "tdmsPropertiesSplitContainer";
            this.tdmsPropertiesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tdmsPropertiesSplitContainer.Panel1
            // 
            this.tdmsPropertiesSplitContainer.Panel1.Controls.Add(this.tdmsPropertiesLabel);
            this.tdmsPropertiesSplitContainer.Panel1MinSize = 15;
            // 
            // tdmsPropertiesSplitContainer.Panel2
            // 
            this.tdmsPropertiesSplitContainer.Panel2.Controls.Add(this.tdmsPropertiesDataGridView);
            this.tdmsPropertiesSplitContainer.Size = new System.Drawing.Size(263, 268);
            this.tdmsPropertiesSplitContainer.SplitterDistance = 15;
            this.tdmsPropertiesSplitContainer.TabIndex = 0;
            // 
            // tdmsPropertiesLabel
            // 
            this.tdmsPropertiesLabel.AutoSize = true;
            this.tdmsPropertiesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tdmsPropertiesLabel.Location = new System.Drawing.Point(2, 0);
            this.tdmsPropertiesLabel.Name = "tdmsPropertiesLabel";
            this.tdmsPropertiesLabel.Size = new System.Drawing.Size(54, 13);
            this.tdmsPropertiesLabel.TabIndex = 11;
            this.tdmsPropertiesLabel.Text = "Properties";
            // 
            // tdmsPropertiesDataGridView
            // 
            this.tdmsPropertiesDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tdmsPropertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tdmsPropertiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tdmsPropertyNamesColumn,
            this.tmdsPropertyValuesColumn});
            this.tdmsPropertiesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsPropertiesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tdmsPropertiesDataGridView.Name = "tdmsPropertiesDataGridView";
            this.tdmsPropertiesDataGridView.RowHeadersVisible = false;
            this.tdmsPropertiesDataGridView.Size = new System.Drawing.Size(263, 249);
            this.tdmsPropertiesDataGridView.TabIndex = 1;
            // 
            // tdmsPropertyNamesColumn
            // 
            this.tdmsPropertyNamesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tdmsPropertyNamesColumn.HeaderText = "Name";
            this.tdmsPropertyNamesColumn.Name = "tdmsPropertyNamesColumn";
            this.tdmsPropertyNamesColumn.ReadOnly = true;
            this.tdmsPropertyNamesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tdmsPropertyNamesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tmdsPropertyValuesColumn
            // 
            this.tmdsPropertyValuesColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tmdsPropertyValuesColumn.HeaderText = "Value";
            this.tmdsPropertyValuesColumn.Name = "tmdsPropertyValuesColumn";
            this.tmdsPropertyValuesColumn.ReadOnly = true;
            this.tmdsPropertyValuesColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tmdsPropertyValuesColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tdmsFileAndDataSplitContainer
            // 
            this.tdmsFileAndDataSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tdmsFileAndDataSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.tdmsFileAndDataSplitContainer.Location = new System.Drawing.Point(0, 3);
            this.tdmsFileAndDataSplitContainer.Name = "tdmsFileAndDataSplitContainer";
            this.tdmsFileAndDataSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // tdmsFileAndDataSplitContainer.Panel1
            // 
            this.tdmsFileAndDataSplitContainer.Panel1.Controls.Add(this.tdmsFileAndPropertiesSplitContainer);
            // 
            // tdmsFileAndDataSplitContainer.Panel2
            // 
            this.tdmsFileAndDataSplitContainer.Panel2.Controls.Add(this.tdmsDataTabControl);
            this.tdmsFileAndDataSplitContainer.Size = new System.Drawing.Size(457, 617);
            this.tdmsFileAndDataSplitContainer.SplitterDistance = 268;
            this.tdmsFileAndDataSplitContainer.TabIndex = 8;
            // 
            // tdmsDataTabControl
            // 
            this.tdmsDataTabControl.Controls.Add(this.tdmsDataTabPage);
            this.tdmsDataTabControl.Controls.Add(this.tdmsGraphTabPage);
            this.tdmsDataTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsDataTabControl.Location = new System.Drawing.Point(0, 0);
            this.tdmsDataTabControl.Name = "tdmsDataTabControl";
            this.tdmsDataTabControl.SelectedIndex = 0;
            this.tdmsDataTabControl.Size = new System.Drawing.Size(457, 345);
            this.tdmsDataTabControl.TabIndex = 1;
            this.tdmsDataTabControl.SelectedIndexChanged += new System.EventHandler(this.OnDataTabControlSelectedIndexChanged);
            // 
            // tdmsDataTabPage
            // 
            this.tdmsDataTabPage.Controls.Add(this.tdmsDataGridView);
            this.tdmsDataTabPage.Location = new System.Drawing.Point(4, 22);
            this.tdmsDataTabPage.Name = "tdmsDataTabPage";
            this.tdmsDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tdmsDataTabPage.Size = new System.Drawing.Size(449, 319);
            this.tdmsDataTabPage.TabIndex = 0;
            this.tdmsDataTabPage.Text = "Data";
            this.tdmsDataTabPage.UseVisualStyleBackColor = true;
            // 
            // tdmsGraphTabPage
            // 
            this.tdmsGraphTabPage.Controls.Add(this.tdmsWaveformGraph);
            this.tdmsGraphTabPage.Controls.Add(this.tdmsDigitalWaveformGraph);
            this.tdmsGraphTabPage.Location = new System.Drawing.Point(4, 22);
            this.tdmsGraphTabPage.Name = "tdmsGraphTabPage";
            this.tdmsGraphTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tdmsGraphTabPage.Size = new System.Drawing.Size(449, 319);
            this.tdmsGraphTabPage.TabIndex = 1;
            this.tdmsGraphTabPage.Text = "Graph";
            this.tdmsGraphTabPage.UseVisualStyleBackColor = true;
            // 
            // tdmsWaveformGraph
            // 
            this.tdmsWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsWaveformGraph.Location = new System.Drawing.Point(3, 3);
            this.tdmsWaveformGraph.Name = "tdmsWaveformGraph";
            this.tdmsWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.tdmsWaveformPlot});
            this.tdmsWaveformGraph.Size = new System.Drawing.Size(443, 313);
            this.tdmsWaveformGraph.TabIndex = 0;
            this.tdmsWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.tdmsXAxis});
            this.tdmsWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.tdmsYAxis});
            // 
            // tdmsWaveformPlot
            // 
            this.tdmsWaveformPlot.XAxis = this.tdmsXAxis;
            this.tdmsWaveformPlot.YAxis = this.tdmsYAxis;
            // 
            // tdmsDigitalWaveformGraph
            // 
            this.tdmsDigitalWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tdmsDigitalWaveformGraph.Location = new System.Drawing.Point(3, 3);
            this.tdmsDigitalWaveformGraph.Name = "tdmsDigitalWaveformGraph";
            this.tdmsDigitalWaveformGraph.Size = new System.Drawing.Size(443, 313);
            this.tdmsDigitalWaveformGraph.TabIndex = 1;
            // 
            // loadValuesButton
            // 
            this.loadValuesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadValuesButton.Enabled = false;
            this.loadValuesButton.Location = new System.Drawing.Point(347, 626);
            this.loadValuesButton.Name = "loadValuesButton";
            this.loadValuesButton.Size = new System.Drawing.Size(112, 23);
            this.loadValuesButton.TabIndex = 9;
            this.loadValuesButton.Text = "Load More Values";
            this.loadValuesButton.UseVisualStyleBackColor = true;
            this.loadValuesButton.Click += new System.EventHandler(this.OnLoadValuesButtonClicked);
            // 
            // tdmsDataIndexColumn
            // 
            this.tdmsDataIndexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.tdmsDataIndexColumn.HeaderText = "Index";
            this.tdmsDataIndexColumn.Name = "tdmsDataIndexColumn";
            this.tdmsDataIndexColumn.ReadOnly = true;
            this.tdmsDataIndexColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tdmsDataIndexColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tdmsDataIndexColumn.Width = 39;
            // 
            // tdmsDataColumn
            // 
            this.tdmsDataColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tdmsDataColumn.HeaderText = "Channel Data";
            this.tdmsDataColumn.Name = "tdmsDataColumn";
            this.tdmsDataColumn.ReadOnly = true;
            this.tdmsDataColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tdmsDataColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            //
            // TdmsReaderUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.loadValuesButton);
            this.Controls.Add(this.tdmsFileAndDataSplitContainer);
            this.Name = "TdmsReaderUserControl";
            this.Size = new System.Drawing.Size(459, 653);
            ((System.ComponentModel.ISupportInitialize)(this.tdmsDataGridView)).EndInit();
            this.tdmsFileAndPropertiesSplitContainer.Panel1.ResumeLayout(false);
            this.tdmsFileAndPropertiesSplitContainer.Panel2.ResumeLayout(false);
            this.tdmsFileAndPropertiesSplitContainer.ResumeLayout(false);
            this.tdmsFileSplitContainer.Panel1.ResumeLayout(false);
            this.tdmsFileSplitContainer.Panel1.PerformLayout();
            this.tdmsFileSplitContainer.Panel2.ResumeLayout(false);
            this.tdmsFileSplitContainer.ResumeLayout(false);
            this.tdmsPropertiesSplitContainer.Panel1.ResumeLayout(false);
            this.tdmsPropertiesSplitContainer.Panel1.PerformLayout();
            this.tdmsPropertiesSplitContainer.Panel2.ResumeLayout(false);
            this.tdmsPropertiesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tdmsPropertiesDataGridView)).EndInit();
            this.tdmsFileAndDataSplitContainer.Panel1.ResumeLayout(false);
            this.tdmsFileAndDataSplitContainer.Panel2.ResumeLayout(false);
            this.tdmsFileAndDataSplitContainer.ResumeLayout(false);
            this.tdmsDataTabControl.ResumeLayout(false);
            this.tdmsDataTabPage.ResumeLayout(false);
            this.tdmsGraphTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tdmsWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdmsDigitalWaveformGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tdmsDataGridView;
        private System.Windows.Forms.SplitContainer tdmsFileAndPropertiesSplitContainer;
        private System.Windows.Forms.SplitContainer tdmsFileAndDataSplitContainer;
        private System.Windows.Forms.SplitContainer tdmsPropertiesSplitContainer;
        private System.Windows.Forms.Label tdmsPropertiesLabel;
        private System.Windows.Forms.SplitContainer tdmsFileSplitContainer;
        private System.Windows.Forms.DataGridView tdmsPropertiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdmsPropertyNamesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmdsPropertyValuesColumn;
        private System.Windows.Forms.Label tmdsFileLabel;
        private System.Windows.Forms.TreeView tdmsFileTreeView;
        private System.Windows.Forms.Button loadValuesButton;
        private System.Windows.Forms.TabControl tdmsDataTabControl;
        private System.Windows.Forms.TabPage tdmsDataTabPage;
        private System.Windows.Forms.TabPage tdmsGraphTabPage;
        private NationalInstruments.UI.WindowsForms.WaveformGraph tdmsWaveformGraph;
        private NationalInstruments.UI.WaveformPlot tdmsWaveformPlot;
        private NationalInstruments.UI.XAxis tdmsXAxis;
        private NationalInstruments.UI.YAxis tdmsYAxis;
        private NationalInstruments.UI.WindowsForms.DigitalWaveformGraph tdmsDigitalWaveformGraph;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdmsDataIndexColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tdmsDataColumn;

    }
}
