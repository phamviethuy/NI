//==================================================================================================
//
// Title      : MainForm.cs
// Purpose    : This application illustrates how to use the service request event and
//              the service request status byte to determine when generated data is ready
//              and how to read it.
//
//==================================================================================================

using System;
using System.Windows.Forms;
using Ivi.Visa;
using NationalInstruments.Visa;

namespace NationalInstruments.Examples.ServiceRequest
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private IMessageBasedSession mbSession;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label selectResourceLabel;
        private System.Windows.Forms.GroupBox configuringGroupBox;
        private System.Windows.Forms.GroupBox writingGroupBox;
        private System.Windows.Forms.GroupBox readingGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label resourceNameLabel;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label commandLabel;
        private System.Windows.Forms.Button enableSRQButton;
        private System.Windows.Forms.TextBox writeTextBox;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.TextBox readTextBox;
        private System.Windows.Forms.ComboBox resourceNameComboBox;
        private System.ComponentModel.IContainer components;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            InitializeUI();
            toolTip.SetToolTip(enableSRQButton, "Enable the instrument's SRQ event on MAV by sending the following command (varies by instrument):");
            toolTip.SetToolTip(writeButton, "Send string to device");
            toolTip.SetToolTip(closeButton, "Causes the control to release its handle to the device");
            toolTip.SetToolTip(openButton, "The resource name of the device is set and the control attempts to connect to the device");

            try
            {
               // This example uses an instance of the NationalInstruments.Visa.ResourceManager class to find resources on the system.
               // Alternatively, static methods provided by the Ivi.Visa.ResourceManager class may be used when an application
               // requires additional VISA .NET implementations.
               using (var rmSession = new ResourceManager())
                {
                    var validResources = rmSession.Find("(GPIB|TCPIP|USB)?*INSTR");
                    foreach (var resource in validResources)
                    {
                        resourceNameComboBox.Items.Add(resource);
                    }
                }
            }
            catch (Exception)
            {
                resourceNameComboBox.Items.Add("No 488.2 INSTR resource found on the system");
                updateResourceNameControls(false);
                closeButton.Enabled = false;
            }
            resourceNameComboBox.SelectedIndex = 0;
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
                if (mbSession != null)
                {
                    mbSession.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.resourceNameLabel = new System.Windows.Forms.Label();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.commandLabel = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.enableSRQButton = new System.Windows.Forms.Button();
            this.configuringGroupBox = new System.Windows.Forms.GroupBox();
            this.resourceNameComboBox = new System.Windows.Forms.ComboBox();
            this.selectResourceLabel = new System.Windows.Forms.Label();
            this.writingGroupBox = new System.Windows.Forms.GroupBox();
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.readingGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.configuringGroupBox.SuspendLayout();
            this.writingGroupBox.SuspendLayout();
            this.readingGroupBox.SuspendLayout();
            this.SuspendLayout();
            //
            // resourceNameLabel
            //
            this.resourceNameLabel.Location = new System.Drawing.Point(16, 80);
            this.resourceNameLabel.Name = "resourceNameLabel";
            this.resourceNameLabel.Size = new System.Drawing.Size(112, 16);
            this.resourceNameLabel.TabIndex = 1;
            this.resourceNameLabel.Text = "Resource Name:";
            //
            // openButton
            //
            this.openButton.Location = new System.Drawing.Point(16, 128);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(104, 23);
            this.openButton.TabIndex = 2;
            this.openButton.Text = "Open Session";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            //
            // closeButton
            //
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(160, 64);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(104, 23);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close Session";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            //
            // commandLabel
            //
            this.commandLabel.Location = new System.Drawing.Point(16, 160);
            this.commandLabel.Name = "commandLabel";
            this.commandLabel.Size = new System.Drawing.Size(256, 32);
            this.commandLabel.TabIndex = 4;
            this.commandLabel.Text = "Type the command to enable the instrument\'s SRQ event on MAV:";
            //
            // commandTextBox
            //
            this.commandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTextBox.Location = new System.Drawing.Point(16, 200);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(152, 20);
            this.commandTextBox.TabIndex = 5;
            this.commandTextBox.Text = "*SRE 16";
            //
            // enableSRQButton
            //
            this.enableSRQButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.enableSRQButton.Location = new System.Drawing.Point(168, 200);
            this.enableSRQButton.Name = "enableSRQButton";
            this.enableSRQButton.Size = new System.Drawing.Size(104, 24);
            this.enableSRQButton.TabIndex = 6;
            this.enableSRQButton.Text = "Enable SRQ";
            this.enableSRQButton.Click += new System.EventHandler(this.enableSRQButton_Click);
            //
            // configuringGroupBox
            //
            this.configuringGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.configuringGroupBox.Controls.Add(this.resourceNameComboBox);
            this.configuringGroupBox.Controls.Add(this.closeButton);
            this.configuringGroupBox.Location = new System.Drawing.Point(8, 64);
            this.configuringGroupBox.Name = "configuringGroupBox";
            this.configuringGroupBox.Size = new System.Drawing.Size(272, 168);
            this.configuringGroupBox.TabIndex = 7;
            this.configuringGroupBox.TabStop = false;
            this.configuringGroupBox.Text = "Configuring";
            //
            // resourceNameComboBox
            //
            this.resourceNameComboBox.FormattingEnabled = true;
            this.resourceNameComboBox.Location = new System.Drawing.Point(11, 35);
            this.resourceNameComboBox.Name = "resourceNameComboBox";
            this.resourceNameComboBox.Size = new System.Drawing.Size(255, 21);
            this.resourceNameComboBox.TabIndex = 4;
            //
            // selectResourceLabel
            //
            this.selectResourceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectResourceLabel.Location = new System.Drawing.Point(8, 8);
            this.selectResourceLabel.Name = "selectResourceLabel";
            this.selectResourceLabel.Size = new System.Drawing.Size(272, 56);
            this.selectResourceLabel.TabIndex = 8;
            this.selectResourceLabel.Text = "Select the Resource Name associated with your device and press the Configure Devi" +
    "ce button. Then enter the command string that enables SRQ and click the Enable S" +
    "RQ button.";
            //
            // writingGroupBox
            //
            this.writingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writingGroupBox.Controls.Add(this.writeTextBox);
            this.writingGroupBox.Controls.Add(this.writeButton);
            this.writingGroupBox.Location = new System.Drawing.Point(8, 240);
            this.writingGroupBox.Name = "writingGroupBox";
            this.writingGroupBox.Size = new System.Drawing.Size(272, 56);
            this.writingGroupBox.TabIndex = 9;
            this.writingGroupBox.TabStop = false;
            this.writingGroupBox.Text = "Writing";
            //
            // writeTextBox
            //
            this.writeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writeTextBox.Location = new System.Drawing.Point(8, 24);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(152, 20);
            this.writeTextBox.TabIndex = 2;
            this.writeTextBox.Text = "*IDN?\\n";
            //
            // writeButton
            //
            this.writeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.writeButton.Location = new System.Drawing.Point(160, 24);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(104, 23);
            this.writeButton.TabIndex = 1;
            this.writeButton.Text = "Write";
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
            //
            // readingGroupBox
            //
            this.readingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readingGroupBox.Controls.Add(this.clearButton);
            this.readingGroupBox.Controls.Add(this.readTextBox);
            this.readingGroupBox.Location = new System.Drawing.Point(8, 312);
            this.readingGroupBox.Name = "readingGroupBox";
            this.readingGroupBox.Size = new System.Drawing.Size(272, 120);
            this.readingGroupBox.TabIndex = 10;
            this.readingGroupBox.TabStop = false;
            this.readingGroupBox.Text = "Reading";
            //
            // clearButton
            //
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearButton.Location = new System.Drawing.Point(8, 88);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            //
            // readTextBox
            //
            this.readTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readTextBox.Location = new System.Drawing.Point(8, 24);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.ReadOnly = true;
            this.readTextBox.Size = new System.Drawing.Size(256, 56);
            this.readTextBox.TabIndex = 0;
            //
            // MainForm
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(288, 448);
            this.Controls.Add(this.readingGroupBox);
            this.Controls.Add(this.writingGroupBox);
            this.Controls.Add(this.selectResourceLabel);
            this.Controls.Add(this.enableSRQButton);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.commandLabel);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.resourceNameLabel);
            this.Controls.Add(this.configuringGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(296, 482);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service Request";
            this.configuringGroupBox.ResumeLayout(false);
            this.writingGroupBox.ResumeLayout(false);
            this.writingGroupBox.PerformLayout();
            this.readingGroupBox.ResumeLayout(false);
            this.readingGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }

        private void updateResourceNameControls(bool enable)
        {
            resourceNameComboBox.Enabled = enable;
            openButton.Enabled = enable;
            closeButton.Enabled = !enable;
            if (enable)
                openButton.Focus();
        }

        private void updateSRQControls(bool enable)
        {
            commandTextBox.Enabled = enable;
            enableSRQButton.Enabled = enable;
            if (enable)
                enableSRQButton.Focus();
        }

        private void updateWriteControls(bool enable)
        {
            writeTextBox.Enabled = enable;
            writeButton.Enabled = enable;
            if (enable)
                writeButton.Focus();
        }

        private void InitializeUI()
        {
            updateResourceNameControls(true);
            updateSRQControls(false);
            updateWriteControls(false);
        }

        // When the Open Session button is pressed, the resource name of the
        // device is set and the control attempts to connect to the device
        private void openButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                using (var rmSession = new ResourceManager())
                {
                    mbSession = (MessageBasedSession)rmSession.Open(resourceNameComboBox.Text);
                    // Use SynchronizeCallbacks to specify that the object marshals callbacks across threads appropriately.
                    mbSession.SynchronizeCallbacks = true;
                    updateResourceNameControls(false);
                    updateSRQControls(true);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // The Enable SRQ button writes the string that tells the instrument to
        // enable the SRQ bit
        private void enableSRQButton_Click(object sender, System.EventArgs e)
        {
            try
            {   // Registering a handler for an event automatically enables that event.
                mbSession.ServiceRequest += OnServiceRequest;
                WriteToSession(commandTextBox.Text);
                updateSRQControls(false);
                updateWriteControls(true);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Pressing Close Session causes the control to release its handle to the device
        private void closeButton_Click(object sender, System.EventArgs e)
        {
            mbSession.ServiceRequest -= OnServiceRequest;
            mbSession.Dispose();
            InitializeUI();
        }

        // Clicking the Write Button causes the Send String to be written to the device
        private void writeButton_Click(object sender, System.EventArgs e)
        {
            WriteToSession(writeTextBox.Text);
        }

        // Pressing the Clear button clears the read textbox
        private void clearButton_Click(object sender, System.EventArgs e)
        {
            readTextBox.Clear();
        }

        private string ReplaceCommonEscapeSequences(string s)
        {
            return s.Replace("\\n", "\n").Replace("\\r", "\r");
        }

        private string InsertCommonEscapeSequences(string s)
        {
            return s.Replace("\n", "\\n").Replace("\r", "\\r");
        }

        private void WriteToSession(string txtWrite)
        {
            try
            {
                string textToWrite = ReplaceCommonEscapeSequences(txtWrite);
                mbSession.RawIO.Write(textToWrite);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void OnServiceRequest(object sender, VisaEventArgs e)
        {
            try
            {
                var mbs = (MessageBasedSession)sender;
                StatusByteFlags sb = mbs.ReadStatusByte();

                if ((sb & StatusByteFlags.MessageAvailable) != 0)
                {
                    string textRead = mbs.RawIO.ReadString();
                    readTextBox.Text = InsertCommonEscapeSequences(textRead);
                }
                else
                {
                    MessageBox.Show("MAV in status register is not set, which means that message is not available. Make sure the command to enable SRQ is correct, and the instrument is 488.2 compatible.");
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
