namespace NationalInstruments.Examples.Creation
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.ProcessesListBox = new System.Windows.Forms.ListBox();
            this.ProcessContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshProcessesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteProcessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateProcessButton = new System.Windows.Forms.Button();
            this.ProcessNameTextBox = new System.Windows.Forms.TextBox();
            this.VariableGroupBox = new System.Windows.Forms.GroupBox();
            this.VariablesListBox = new System.Windows.Forms.ListBox();
            this.VariableContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshVariablesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VariableSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteVariableMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateVariableButton = new System.Windows.Forms.Button();
            this.VariableNameTextBox = new System.Windows.Forms.TextBox();
            this.InstructionLabel = new System.Windows.Forms.Label();
            this.ProcessGroupBox.SuspendLayout();
            this.ProcessContextMenuStrip.SuspendLayout();
            this.VariableGroupBox.SuspendLayout();
            this.VariableContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessGroupBox
            // 
            this.ProcessGroupBox.Controls.Add(this.ProcessesListBox);
            this.ProcessGroupBox.Controls.Add(this.CreateProcessButton);
            this.ProcessGroupBox.Controls.Add(this.ProcessNameTextBox);
            this.ProcessGroupBox.Location = new System.Drawing.Point(17, 103);
            this.ProcessGroupBox.Name = "ProcessGroupBox";
            this.ProcessGroupBox.Size = new System.Drawing.Size(179, 241);
            this.ProcessGroupBox.TabIndex = 0;
            this.ProcessGroupBox.TabStop = false;
            this.ProcessGroupBox.Text = "&Processes";
            // 
            // ProcessesListBox
            // 
            this.ProcessesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessesListBox.ContextMenuStrip = this.ProcessContextMenuStrip;
            this.ProcessesListBox.FormattingEnabled = true;
            this.ProcessesListBox.Location = new System.Drawing.Point(7, 77);
            this.ProcessesListBox.Name = "ProcessesListBox";
            this.ProcessesListBox.Size = new System.Drawing.Size(166, 160);
            this.ProcessesListBox.TabIndex = 2;
            this.ProcessesListBox.SelectedIndexChanged += new System.EventHandler(this.lbxProcesses_SelectedIndexChanged);
            // 
            // ProcessContextMenuStrip
            // 
            this.ProcessContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshProcessesMenuItem,
            this.ProcessSeparator,
            this.DeleteProcessMenuItem});
            this.ProcessContextMenuStrip.Name = "processMenu";
            this.ProcessContextMenuStrip.Size = new System.Drawing.Size(124, 54);
            // 
            // RefreshProcessesMenuItem
            // 
            this.RefreshProcessesMenuItem.Name = "RefreshProcessesMenuItem";
            this.RefreshProcessesMenuItem.Size = new System.Drawing.Size(123, 22);
            this.RefreshProcessesMenuItem.Text = "&Refresh";
            this.RefreshProcessesMenuItem.Click += new System.EventHandler(this.refreshProcessesItem_Click);
            // 
            // ProcessSeparator
            // 
            this.ProcessSeparator.Name = "ProcessSeparator";
            this.ProcessSeparator.Size = new System.Drawing.Size(120, 6);
            // 
            // DeleteProcessMenuItem
            // 
            this.DeleteProcessMenuItem.Name = "DeleteProcessMenuItem";
            this.DeleteProcessMenuItem.Size = new System.Drawing.Size(123, 22);
            this.DeleteProcessMenuItem.Text = "&Delete";
            this.DeleteProcessMenuItem.Click += new System.EventHandler(this.deleteProcessItem_Click);
            // 
            // CreateProcessButton
            // 
            this.CreateProcessButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateProcessButton.Location = new System.Drawing.Point(7, 47);
            this.CreateProcessButton.Name = "CreateProcessButton";
            this.CreateProcessButton.Size = new System.Drawing.Size(166, 23);
            this.CreateProcessButton.TabIndex = 1;
            this.CreateProcessButton.Text = "&Create Process";
            this.CreateProcessButton.UseVisualStyleBackColor = true;
            this.CreateProcessButton.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // ProcessNameTextBox
            // 
            this.ProcessNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessNameTextBox.Location = new System.Drawing.Point(7, 20);
            this.ProcessNameTextBox.Name = "ProcessNameTextBox";
            this.ProcessNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.ProcessNameTextBox.TabIndex = 0;
            // 
            // VariableGroupBox
            // 
            this.VariableGroupBox.Controls.Add(this.VariablesListBox);
            this.VariableGroupBox.Controls.Add(this.CreateVariableButton);
            this.VariableGroupBox.Controls.Add(this.VariableNameTextBox);
            this.VariableGroupBox.Location = new System.Drawing.Point(207, 103);
            this.VariableGroupBox.Name = "VariableGroupBox";
            this.VariableGroupBox.Size = new System.Drawing.Size(179, 241);
            this.VariableGroupBox.TabIndex = 0;
            this.VariableGroupBox.TabStop = false;
            this.VariableGroupBox.Text = "&Variables";
            // 
            // VariablesListBox
            // 
            this.VariablesListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VariablesListBox.ContextMenuStrip = this.VariableContextMenuStrip;
            this.VariablesListBox.FormattingEnabled = true;
            this.VariablesListBox.Location = new System.Drawing.Point(7, 77);
            this.VariablesListBox.Name = "VariablesListBox";
            this.VariablesListBox.Size = new System.Drawing.Size(166, 160);
            this.VariablesListBox.TabIndex = 2;
            // 
            // VariableContextMenuStrip
            // 
            this.VariableContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshVariablesMenuItem,
            this.VariableSeparator,
            this.DeleteVariableMenuItem});
            this.VariableContextMenuStrip.Name = "variableMenu";
            this.VariableContextMenuStrip.Size = new System.Drawing.Size(153, 76);
            // 
            // RefreshVariablesMenuItem
            // 
            this.RefreshVariablesMenuItem.Name = "RefreshVariablesMenuItem";
            this.RefreshVariablesMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RefreshVariablesMenuItem.Text = "&Refresh";
            this.RefreshVariablesMenuItem.Click += new System.EventHandler(this.refreshVariablesItem_Click);
            // 
            // VariableSeparator
            // 
            this.VariableSeparator.Name = "VariableSeparator";
            this.VariableSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // DeleteVariableMenuItem
            // 
            this.DeleteVariableMenuItem.Name = "DeleteVariableMenuItem";
            this.DeleteVariableMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteVariableMenuItem.Text = "&Delete";
            this.DeleteVariableMenuItem.Click += new System.EventHandler(this.deleteVariableItem_Click);
            // 
            // CreateVariableButton
            // 
            this.CreateVariableButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateVariableButton.Location = new System.Drawing.Point(7, 47);
            this.CreateVariableButton.Name = "CreateVariableButton";
            this.CreateVariableButton.Size = new System.Drawing.Size(166, 23);
            this.CreateVariableButton.TabIndex = 1;
            this.CreateVariableButton.Text = "C&reate Variable";
            this.CreateVariableButton.UseVisualStyleBackColor = true;
            this.CreateVariableButton.Click += new System.EventHandler(this.btnCreateVariable_Click);
            // 
            // VariableNameTextBox
            // 
            this.VariableNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.VariableNameTextBox.Location = new System.Drawing.Point(7, 20);
            this.VariableNameTextBox.Name = "VariableNameTextBox";
            this.VariableNameTextBox.Size = new System.Drawing.Size(166, 20);
            this.VariableNameTextBox.TabIndex = 0;
            // 
            // InstructionLabel
            // 
            this.InstructionLabel.Location = new System.Drawing.Point(10, 13);
            this.InstructionLabel.Name = "InstructionLabel";
            this.InstructionLabel.Size = new System.Drawing.Size(383, 86);
            this.InstructionLabel.TabIndex = 2;
            this.InstructionLabel.Text = resources.GetString("InstructionLabel.Text");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 352);
            this.Controls.Add(this.InstructionLabel);
            this.Controls.Add(this.ProcessGroupBox);
            this.Controls.Add(this.VariableGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Network Variable Creation";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ProcessGroupBox.ResumeLayout(false);
            this.ProcessGroupBox.PerformLayout();
            this.ProcessContextMenuStrip.ResumeLayout(false);
            this.VariableGroupBox.ResumeLayout(false);
            this.VariableGroupBox.PerformLayout();
            this.VariableContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ProcessGroupBox;
        private System.Windows.Forms.ListBox ProcessesListBox;
        private System.Windows.Forms.Button CreateProcessButton;
        private System.Windows.Forms.TextBox ProcessNameTextBox;
        private System.Windows.Forms.ContextMenuStrip ProcessContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RefreshProcessesMenuItem;
        private System.Windows.Forms.ToolStripSeparator ProcessSeparator;
        private System.Windows.Forms.ToolStripMenuItem DeleteProcessMenuItem;
        private System.Windows.Forms.GroupBox VariableGroupBox;
        private System.Windows.Forms.ListBox VariablesListBox;
        private System.Windows.Forms.Button CreateVariableButton;
        private System.Windows.Forms.TextBox VariableNameTextBox;
        private System.Windows.Forms.ContextMenuStrip VariableContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RefreshVariablesMenuItem;
        private System.Windows.Forms.ToolStripSeparator VariableSeparator;
        private System.Windows.Forms.ToolStripMenuItem DeleteVariableMenuItem;
        private System.Windows.Forms.Label InstructionLabel;
    }
}