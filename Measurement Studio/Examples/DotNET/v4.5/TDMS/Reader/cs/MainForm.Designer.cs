namespace NationalInstruments.Examples.Reader
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
            this.tdmsFileLabel = new System.Windows.Forms.Label();
            this.tdmsFileTextBox = new System.Windows.Forms.TextBox();
            this.tdmsFileBrowseButton = new System.Windows.Forms.Button();
            this.tdmsOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.readerTdmsReaderUserControl = new NationalInstruments.Examples.Reader.TdmsReaderUserControl();
            this.SuspendLayout();
            // 
            // tdmsFileLabel
            // 
            this.tdmsFileLabel.AutoSize = true;
            this.tdmsFileLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tdmsFileLabel.Location = new System.Drawing.Point(24, 9);
            this.tdmsFileLabel.Name = "tdmsFileLabel";
            this.tdmsFileLabel.Size = new System.Drawing.Size(26, 13);
            this.tdmsFileLabel.TabIndex = 0;
            this.tdmsFileLabel.Text = "File:";
            // 
            // tdmsFileTextBox
            //
            this.tdmsFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right))); 
            this.tdmsFileTextBox.Location = new System.Drawing.Point(24, 25);
            this.tdmsFileTextBox.Name = "tdmsFileTextBox";
            this.tdmsFileTextBox.ReadOnly = true;
            this.tdmsFileTextBox.Size = new System.Drawing.Size(376, 20);
            this.tdmsFileTextBox.TabIndex = 1;
            this.tdmsFileTextBox.TabStop = false;
            // 
            // tdmsFileBrowseButton
            // 
            this.tdmsFileBrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tdmsFileBrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.tdmsFileBrowseButton.Location = new System.Drawing.Point(406, 23);
            this.tdmsFileBrowseButton.Name = "tdmsFileBrowseButton";
            this.tdmsFileBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.tdmsFileBrowseButton.TabIndex = 2;
            this.tdmsFileBrowseButton.Text = "&Browse";
            this.tdmsFileBrowseButton.UseVisualStyleBackColor = true;
            this.tdmsFileBrowseButton.Click += new System.EventHandler(this.OnTdmsFileBrowseButtonClicked);
            // 
            // tdmsOpenFileDialog
            // 
            this.tdmsOpenFileDialog.DefaultExt = "tdms";
            this.tdmsOpenFileDialog.Filter = "TDMS Files | *.tdms";
            // 
            // readerTdmsReaderUserControl
            // 
            this.readerTdmsReaderUserControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.readerTdmsReaderUserControl.Location = new System.Drawing.Point(24, 51);
            this.readerTdmsReaderUserControl.Name = "readerTdmsReaderUserControl";
            this.readerTdmsReaderUserControl.Size = new System.Drawing.Size(457, 651);
            this.readerTdmsReaderUserControl.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(504, 704);
            this.Controls.Add(this.readerTdmsReaderUserControl);
            this.Controls.Add(this.tdmsFileBrowseButton);
            this.Controls.Add(this.tdmsFileTextBox);
            this.Controls.Add(this.tdmsFileLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "TDMS File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tdmsFileLabel;
        private System.Windows.Forms.TextBox tdmsFileTextBox;
        private System.Windows.Forms.Button tdmsFileBrowseButton;
        private TdmsReaderUserControl readerTdmsReaderUserControl;
        private System.Windows.Forms.OpenFileDialog tdmsOpenFileDialog;
    }
}

