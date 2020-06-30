using System;
using System.Windows.Forms;
using Ivi.Visa;
using NationalInstruments.Visa;

namespace NationalInstruments.Examples.SimpleAsynchronousReadWrite
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private MessageBasedSession mbSession;
        private string lastResourceString = null;
        private IVisaAsyncResult asyncHandle = null;
        private System.Windows.Forms.TextBox writeTextBox;
        private System.Windows.Forms.TextBox readTextBox;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button openSessionButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button closeSessionButton;
        private System.Windows.Forms.Label stringToWriteLabel;
        private System.Windows.Forms.Label stringToReadLabel;
        private System.Windows.Forms.Button terminateButton;
        private System.Windows.Forms.Label elementsTransferredLabel;
        private System.Windows.Forms.TextBox elementsTransferredTextBox;
        private System.Windows.Forms.TextBox lastIOStatusTextBox;
        private System.Windows.Forms.Label lastIOStatusLabel;
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
            SetupControlState(false);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if(mbSession != null)
                {
                    mbSession.Dispose();
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.writeButton = new System.Windows.Forms.Button();
            this.readButton = new System.Windows.Forms.Button();
            this.openSessionButton = new System.Windows.Forms.Button();
            this.writeTextBox = new System.Windows.Forms.TextBox();
            this.readTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.closeSessionButton = new System.Windows.Forms.Button();
            this.stringToWriteLabel = new System.Windows.Forms.Label();
            this.stringToReadLabel = new System.Windows.Forms.Label();
            this.terminateButton = new System.Windows.Forms.Button();
            this.elementsTransferredLabel = new System.Windows.Forms.Label();
            this.elementsTransferredTextBox = new System.Windows.Forms.TextBox();
            this.lastIOStatusTextBox = new System.Windows.Forms.TextBox();
            this.lastIOStatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // writeButton
            //
            this.writeButton.Location = new System.Drawing.Point(5, 83);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(74, 23);
            this.writeButton.TabIndex = 3;
            this.writeButton.Text = "Write";
            this.writeButton.Click += new System.EventHandler(this.write_Click);
            //
            // readButton
            //
            this.readButton.Location = new System.Drawing.Point(79, 83);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(74, 23);
            this.readButton.TabIndex = 4;
            this.readButton.Text = "Read";
            this.readButton.Click += new System.EventHandler(this.read_Click);
            //
            // openSessionButton
            //
            this.openSessionButton.Location = new System.Drawing.Point(5, 5);
            this.openSessionButton.Name = "openSessionButton";
            this.openSessionButton.Size = new System.Drawing.Size(92, 22);
            this.openSessionButton.TabIndex = 0;
            this.openSessionButton.Text = "Open Session";
            this.openSessionButton.Click += new System.EventHandler(this.openSession_Click);
            //
            // writeTextBox
            //
            this.writeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writeTextBox.Location = new System.Drawing.Point(5, 54);
            this.writeTextBox.Name = "writeTextBox";
            this.writeTextBox.Size = new System.Drawing.Size(275, 20);
            this.writeTextBox.TabIndex = 2;
            this.writeTextBox.Text = "*IDN?\\n";
            //
            // readTextBox
            //
            this.readTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.readTextBox.Location = new System.Drawing.Point(5, 136);
            this.readTextBox.Multiline = true;
            this.readTextBox.Name = "readTextBox";
            this.readTextBox.ReadOnly = true;
            this.readTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.readTextBox.Size = new System.Drawing.Size(275, 158);
            this.readTextBox.TabIndex = 6;
            this.readTextBox.TabStop = false;
            //
            // clearButton
            //
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(6, 344);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(275, 24);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clear_Click);
            //
            // closeSessionButton
            //
            this.closeSessionButton.Location = new System.Drawing.Point(97, 5);
            this.closeSessionButton.Name = "closeSessionButton";
            this.closeSessionButton.Size = new System.Drawing.Size(92, 22);
            this.closeSessionButton.TabIndex = 1;
            this.closeSessionButton.Text = "Close Session";
            this.closeSessionButton.Click += new System.EventHandler(this.closeSession_Click);
            //
            // stringToWriteLabel
            //
            this.stringToWriteLabel.Location = new System.Drawing.Point(5, 40);
            this.stringToWriteLabel.Name = "stringToWriteLabel";
            this.stringToWriteLabel.Size = new System.Drawing.Size(91, 14);
            this.stringToWriteLabel.TabIndex = 8;
            this.stringToWriteLabel.Text = "String to Write:";
            //
            // stringToReadLabel
            //
            this.stringToReadLabel.Location = new System.Drawing.Point(5, 122);
            this.stringToReadLabel.Name = "stringToReadLabel";
            this.stringToReadLabel.Size = new System.Drawing.Size(101, 14);
            this.stringToReadLabel.TabIndex = 9;
            this.stringToReadLabel.Text = "String Read:";
            //
            // terminateButton
            //
            this.terminateButton.Enabled = false;
            this.terminateButton.Location = new System.Drawing.Point(205, 83);
            this.terminateButton.Name = "terminateButton";
            this.terminateButton.Size = new System.Drawing.Size(74, 23);
            this.terminateButton.TabIndex = 5;
            this.terminateButton.Text = "Terminate";
            this.terminateButton.Click += new System.EventHandler(this.terminate_Click);
            //
            // elementsTransferredLabel
            //
            this.elementsTransferredLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementsTransferredLabel.Location = new System.Drawing.Point(5, 308);
            this.elementsTransferredLabel.Name = "elementsTransferredLabel";
            this.elementsTransferredLabel.Size = new System.Drawing.Size(116, 11);
            this.elementsTransferredLabel.TabIndex = 11;
            this.elementsTransferredLabel.Text = "Elements Transferred:";
            //
            // elementsTransferredTextBox
            //
            this.elementsTransferredTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.elementsTransferredTextBox.Location = new System.Drawing.Point(5, 321);
            this.elementsTransferredTextBox.Name = "elementsTransferredTextBox";
            this.elementsTransferredTextBox.ReadOnly = true;
            this.elementsTransferredTextBox.Size = new System.Drawing.Size(104, 20);
            this.elementsTransferredTextBox.TabIndex = 12;
            this.elementsTransferredTextBox.TabStop = false;
            //
            // lastIOStatusTextBox
            //
            this.lastIOStatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastIOStatusTextBox.Location = new System.Drawing.Point(113, 321);
            this.lastIOStatusTextBox.Name = "lastIOStatusTextBox";
            this.lastIOStatusTextBox.ReadOnly = true;
            this.lastIOStatusTextBox.Size = new System.Drawing.Size(168, 20);
            this.lastIOStatusTextBox.TabIndex = 14;
            this.lastIOStatusTextBox.TabStop = false;
            //
            // lastIOStatusLabel
            //
            this.lastIOStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lastIOStatusLabel.Location = new System.Drawing.Point(113, 308);
            this.lastIOStatusLabel.Name = "lastIOStatusLabel";
            this.lastIOStatusLabel.Size = new System.Drawing.Size(116, 11);
            this.lastIOStatusLabel.TabIndex = 13;
            this.lastIOStatusLabel.Text = "Last I/O Status:";
            //
            // MainForm
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(287, 376);
            this.Controls.Add(this.lastIOStatusTextBox);
            this.Controls.Add(this.elementsTransferredTextBox);
            this.Controls.Add(this.readTextBox);
            this.Controls.Add(this.writeTextBox);
            this.Controls.Add(this.lastIOStatusLabel);
            this.Controls.Add(this.elementsTransferredLabel);
            this.Controls.Add(this.terminateButton);
            this.Controls.Add(this.stringToReadLabel);
            this.Controls.Add(this.stringToWriteLabel);
            this.Controls.Add(this.closeSessionButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.openSessionButton);
            this.Controls.Add(this.readButton);
            this.Controls.Add(this.writeButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 316);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Asynchronous Read/Write";
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

        private void openSession_Click(object sender, System.EventArgs e)
        {
            using (SelectResource sr = new SelectResource())
            {
                if(lastResourceString != null)
                {
                    sr.ResourceName = lastResourceString;
                }
                DialogResult result = sr.ShowDialog(this);
                if(result == DialogResult.OK)
                {
                    lastResourceString = sr.ResourceName;
                    Cursor.Current = Cursors.WaitCursor;
                    try
                    {
                        using (var rmSession = new ResourceManager())
                        {
                            mbSession = (MessageBasedSession)rmSession.Open(sr.ResourceName);
                            // Use SynchronizeCallbacks to specify that the object marshals callbacks across threads appropriately.
                            mbSession.SynchronizeCallbacks = true;
                            SetupControlState(true);
                        }
                    }
                    catch(Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    finally
                    {
                        Cursor.Current = Cursors.Default;
                    }
                }
            }
        }

        private void closeSession_Click(object sender, System.EventArgs e)
        {
            SetupControlState(false);
            mbSession.Dispose();
        }

        private void write_Click(object sender, System.EventArgs e)
        {
            try
            {
                SetupWaitingControlState(true);
                string textToWrite = ReplaceCommonEscapeSequences(writeTextBox.Text);
                asyncHandle = mbSession.RawIO.BeginWrite(
                    textToWrite,
                    new VisaAsyncCallback(OnWriteComplete),
                    (object)textToWrite.Length);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void read_Click(object sender, System.EventArgs e)
        {
            try
            {
                SetupWaitingControlState(true);
                asyncHandle = mbSession.RawIO.BeginRead(
                    1024,
                    new VisaAsyncCallback(OnReadComplete),
                    null);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void clear_Click(object sender, System.EventArgs e)
        {
            ClearControls();
        }

        private void terminate_Click(object sender, System.EventArgs e)
        {
            SetupWaitingControlState(false);
            try
            {
                mbSession.RawIO.AbortAsyncOperation(asyncHandle);
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void OnWriteComplete(IVisaAsyncResult result)
        {
            try
            {
                SetupWaitingControlState(false);
                mbSession.RawIO.EndWrite(result);
                lastIOStatusTextBox.Text = "Success";
            }
            catch(Exception exp)
            {
                lastIOStatusTextBox.Text = exp.Message;
            }
            elementsTransferredTextBox.Text = ((int)result.Count).ToString();
        }

        private void OnReadComplete(IVisaAsyncResult result)
        {
            try
            {
                SetupWaitingControlState(false);
                string responseString = mbSession.RawIO.EndReadString(result);
                readTextBox.Text = InsertCommonEscapeSequences(responseString);
                lastIOStatusTextBox.Text = "Success";
            }
            catch(Exception exp)
            {
                lastIOStatusTextBox.Text = exp.Message;
            }
            elementsTransferredTextBox.Text = ((int)result.Count).ToString();
        }

        private void SetupControlState(bool isSessionOpen)
        {
            openSessionButton.Enabled = !isSessionOpen;
            closeSessionButton.Enabled = isSessionOpen;
            writeButton.Enabled = isSessionOpen;
            readButton.Enabled = isSessionOpen;
            writeTextBox.Enabled = isSessionOpen;
            clearButton.Enabled = isSessionOpen;
            if(isSessionOpen)
            {
                ClearControls();
                writeTextBox.Focus();
            }
        }

        private void SetupWaitingControlState(bool operationIsInProgress)
        {
            if (operationIsInProgress)
            {
                readTextBox.Text = String.Empty;
                elementsTransferredTextBox.Text = String.Empty;
                lastIOStatusTextBox.Text = String.Empty;
            }
            terminateButton.Enabled = operationIsInProgress;
            writeButton.Enabled = !operationIsInProgress;
            readButton.Enabled = !operationIsInProgress;
        }

        private string ReplaceCommonEscapeSequences(string s)
        {
            return (s != null) ? s.Replace("\\n", "\n").Replace("\\r", "\r") : s;
        }

        private string InsertCommonEscapeSequences(string s)
        {
            return (s != null) ? s.Replace("\n", "\\n").Replace("\r", "\\r") : s;
        }

        private void ClearControls()
        {
            readTextBox.Text = String.Empty;
            lastIOStatusTextBox.Text = String.Empty;
            elementsTransferredTextBox.Text = String.Empty;
        }
    }
}
