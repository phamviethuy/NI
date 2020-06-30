//==================================================================================================
//
// Title      : MainForm.cs
// Purpose    : This application illustrates how to use In/Out/MoveIn/MoveOut on register-based
//              sessions.
//
//==================================================================================================

using System;
using System.Windows.Forms;
using Ivi.Visa;
using NationalInstruments.Visa;

namespace NationalInstruments.Examples.RegisterBasedOperations
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private PxiSession pxiSession;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.NumericUpDown[] numOutputArray;
        private System.Windows.Forms.Label resourceNameLabel;
        private System.Windows.Forms.ComboBox resourceNameComboBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button moveInButton;
        private System.Windows.Forms.Button inButton;
        private System.Windows.Forms.Label spaceLabel;
        private System.Windows.Forms.Label offsetLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.ComboBox spaceComboBox;
        private System.Windows.Forms.NumericUpDown offsetNumericUpDown;
        private System.Windows.Forms.ComboBox widthComboBox;
        private System.Windows.Forms.NumericUpDown numElementsNumericUpDown;
        private System.Windows.Forms.Label numElementsLabel;
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
            SetupUI(false);
            PopulateComboBoxes();
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
                if (pxiSession != null)
                {
                    pxiSession.Dispose();
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
            this.resourceNameLabel = new System.Windows.Forms.Label();
            this.offsetNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numElementsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.offsetLabel = new System.Windows.Forms.Label();
            this.numElementsLabel = new System.Windows.Forms.Label();
            this.moveInButton = new System.Windows.Forms.Button();
            this.inButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.spaceComboBox = new System.Windows.Forms.ComboBox();
            this.spaceLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthComboBox = new System.Windows.Forms.ComboBox();
            this.resourceNameComboBox = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numElementsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            //
            // resourceNameLabel
            //
            this.resourceNameLabel.Location = new System.Drawing.Point(20, 8);
            this.resourceNameLabel.Name = "resourceNameLabel";
            this.resourceNameLabel.Size = new System.Drawing.Size(96, 16);
            this.resourceNameLabel.TabIndex = 0;
            this.resourceNameLabel.Text = "Resource Name:";
            //
            // offsetNumericUpDown
            //
            this.offsetNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetNumericUpDown.Hexadecimal = true;
            this.offsetNumericUpDown.Location = new System.Drawing.Point(20, 169);
            this.offsetNumericUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.offsetNumericUpDown.Name = "offsetNumericUpDown";
            this.offsetNumericUpDown.Size = new System.Drawing.Size(137, 20);
            this.offsetNumericUpDown.TabIndex = 8;
            //
            // numElementsNumericUpDown
            //
            this.numElementsNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numElementsNumericUpDown.Location = new System.Drawing.Point(174, 169);
            this.numElementsNumericUpDown.Name = "numElementsNumericUpDown";
            this.numElementsNumericUpDown.Size = new System.Drawing.Size(137, 20);
            this.numElementsNumericUpDown.TabIndex = 8;
            this.numElementsNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            //
            // offsetLabel
            //
            this.offsetLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.offsetLabel.Location = new System.Drawing.Point(21, 150);
            this.offsetLabel.Name = "offsetLabel";
            this.offsetLabel.Size = new System.Drawing.Size(72, 16);
            this.offsetLabel.TabIndex = 9;
            this.offsetLabel.Text = "Offset:";
            //
            // numElementsLabel
            //
            this.numElementsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numElementsLabel.Location = new System.Drawing.Point(171, 150);
            this.numElementsLabel.Name = "numElementsLabel";
            this.numElementsLabel.Size = new System.Drawing.Size(112, 16);
            this.numElementsLabel.TabIndex = 10;
            this.numElementsLabel.Text = "Number of Elements:";
            //
            // moveInButton
            //
            this.moveInButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.moveInButton.Location = new System.Drawing.Point(172, 219);
            this.moveInButton.Name = "moveInButton";
            this.moveInButton.Size = new System.Drawing.Size(139, 24);
            this.moveInButton.TabIndex = 11;
            this.moveInButton.Text = "Move In";
            this.moveInButton.Click += new System.EventHandler(this.moveInButton_Click);
            //
            // inButton
            //
            this.inButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inButton.Location = new System.Drawing.Point(20, 219);
            this.inButton.Name = "inButton";
            this.inButton.Size = new System.Drawing.Size(128, 24);
            this.inButton.TabIndex = 13;
            this.inButton.Text = "In";
            this.inButton.Click += new System.EventHandler(this.inButton_Click);
            //
            // resultTextBox
            //
            this.resultTextBox.AcceptsReturn = true;
            this.resultTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultTextBox.Location = new System.Drawing.Point(23, 276);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(292, 242);
            this.resultTextBox.TabIndex = 17;
            //
            // resultLabel
            //
            this.resultLabel.Location = new System.Drawing.Point(20, 257);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(64, 16);
            this.resultLabel.TabIndex = 18;
            this.resultLabel.Text = "Result:";
            //
            // clearButton
            //
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(235, 522);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(80, 24);
            this.clearButton.TabIndex = 24;
            this.clearButton.Text = "Clear";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            //
            // spaceComboBox
            //
            this.spaceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.spaceComboBox.Location = new System.Drawing.Point(20, 121);
            this.spaceComboBox.Name = "spaceComboBox";
            this.spaceComboBox.Size = new System.Drawing.Size(137, 21);
            this.spaceComboBox.TabIndex = 25;
            //
            // spaceLabel
            //
            this.spaceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.spaceLabel.Location = new System.Drawing.Point(20, 104);
            this.spaceLabel.Name = "spaceLabel";
            this.spaceLabel.Size = new System.Drawing.Size(52, 14);
            this.spaceLabel.TabIndex = 26;
            this.spaceLabel.Text = "Space:";
            //
            // widthLabel
            //
            this.widthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthLabel.Location = new System.Drawing.Point(171, 104);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(40, 16);
            this.widthLabel.TabIndex = 27;
            this.widthLabel.Text = "Width:";
            //
            // widthComboBox
            //
            this.widthComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.widthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.widthComboBox.Location = new System.Drawing.Point(174, 121);
            this.widthComboBox.Name = "widthComboBox";
            this.widthComboBox.Size = new System.Drawing.Size(137, 21);
            this.widthComboBox.TabIndex = 28;
            //
            // resourceNameComboBox
            //
            this.resourceNameComboBox.FormattingEnabled = true;
            this.resourceNameComboBox.Location = new System.Drawing.Point(20, 24);
            this.resourceNameComboBox.Name = "resourceNameComboBox";
            this.resourceNameComboBox.Size = new System.Drawing.Size(291, 21);
            this.resourceNameComboBox.TabIndex = 29;
            //
            // closeButton
            //
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(173, 55);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(137, 24);
            this.closeButton.TabIndex = 30;
            this.closeButton.Text = "Close Session";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            //
            // openButton
            //
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(20, 55);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(137, 24);
            this.openButton.TabIndex = 30;
            this.openButton.Text = "Open Session";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            //
            // MainForm
            //
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(327, 558);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.resourceNameComboBox);
            this.Controls.Add(this.widthComboBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.spaceLabel);
            this.Controls.Add(this.spaceComboBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.inButton);
            this.Controls.Add(this.moveInButton);
            this.Controls.Add(this.numElementsLabel);
            this.Controls.Add(this.offsetLabel);
            this.Controls.Add(this.offsetNumericUpDown);
            this.Controls.Add(this.resourceNameLabel);
            this.Controls.Add(this.numElementsNumericUpDown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 440);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register-Based Operations";
            ((System.ComponentModel.ISupportInitialize)(this.offsetNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numElementsNumericUpDown)).EndInit();
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

        private void openButton_Click(object sender, System.EventArgs e)
        {
            if(pxiSession != null)
            {
                pxiSession.Dispose();
            }

            try
            {
                using (var rmSession = new ResourceManager())
                {
                    pxiSession = (PxiSession)rmSession.Open(resourceNameComboBox.Text);
                    SetupUI(true);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void closeButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                if(pxiSession != null)
                {
                    pxiSession.Dispose();
                    SetupUI(false);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, System.EventArgs e)
        {
            resultTextBox.Clear();
        }

        // Performs an "InXX" operation
        private void inButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                AddressSpace space = (AddressSpace)spaceComboBox.SelectedItem;
                int offset = (int)offsetNumericUpDown.Value;
                DataWidth width = (DataWidth)widthComboBox.SelectedItem;

                switch (width)
                {
                    case DataWidth.Width8:
                        resultTextBox.AppendText(GetOperationText("In8"));
                        byte data8 = pxiSession.In8(space, offset);
                        resultTextBox.AppendText(GetDataText(data8.ToString("x")));
                        break;

                    case DataWidth.Width16:
                        resultTextBox.AppendText(GetOperationText("In16"));
                        short data16 = pxiSession.In16(space, offset);
                        resultTextBox.AppendText(GetDataText(data16.ToString("x")));
                        break;

                    case DataWidth.Width32:
                        resultTextBox.AppendText(GetOperationText("In32"));
                        int data32 = pxiSession.In32(space, offset);
                        resultTextBox.AppendText(GetDataText(data32.ToString("x")));
                        break;

                    case DataWidth.Width64:
                        resultTextBox.AppendText(GetOperationText("In64"));
                        long data64 = pxiSession.In64(space, offset);
                        resultTextBox.AppendText(GetDataText(data64.ToString("x")));
                        break;
                }
            }
            catch (Exception ex)
            {
                resultTextBox.AppendText(GetOperationText(ex.Message));
            }
            ScrollToBottomOfResultTextBox();
        }

        // Perform a "MoveInXX" operation.
        private void moveInButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                AddressSpace space = (AddressSpace)spaceComboBox.SelectedItem;
                int offset = (int)offsetNumericUpDown.Value;
                DataWidth width = (DataWidth)widthComboBox.SelectedItem;
                int length = (int)numElementsNumericUpDown.Value;

                switch (width)
                {
                    case DataWidth.Width8:
                        resultTextBox.AppendText(GetOperationText("MoveIn8"));
                        byte[] data8 = pxiSession.MoveIn8(space, offset, length);
                        ShowArray(data8);
                        break;

                    case DataWidth.Width16:
                        resultTextBox.AppendText(GetOperationText("MoveIn16"));
                        short[] data16 = pxiSession.MoveIn16(space, offset, length);
                        ShowArray(data16);
                        break;

                    case DataWidth.Width32:
                        resultTextBox.AppendText(GetOperationText("MoveIn32"));
                        int[] data32 = pxiSession.MoveIn32(space, offset, length);
                        ShowArray(data32);
                        break;

                    case DataWidth.Width64:
                        resultTextBox.AppendText(GetOperationText("MoveIn64"));
                        long[] data64 = pxiSession.MoveIn64(space, offset, length);
                        ShowArray(data64);
                        break;
                }
            }
            catch(Exception ex)
            {
                resultTextBox.AppendText(GetOperationText(ex.Message));
            }
            ScrollToBottomOfResultTextBox();
        }

        private void PopulateComboBoxes()
        {
            try
            {
                // This example uses an instance of the NationalInstruments.Visa.ResourceManager class to find resources on the system.
                // Alternatively, static methods provided by the Ivi.Visa.ResourceManager class may be used when an application
                // requires additional VISA .NET implementations.
                using (var rmSession = new ResourceManager())
                {
                    var pxiResources = rmSession.Find("PXI?*INSTR");
                    foreach (var resource in pxiResources)
                    {
                        resourceNameComboBox.Items.Add(resource);
                    }
                    // Add PXI specific address spaces only
                    for (AddressSpace space = AddressSpace.PxiConfiguration; space <= AddressSpace.PxiBar5; ++space)
                    {
                        spaceComboBox.Items.Add(space);
                    }
                    spaceComboBox.SelectedIndex = 0;

                    foreach (DataWidth width in Enum.GetValues(typeof(DataWidth)))
                    {
                        widthComboBox.Items.Add(width);
                    }
                    widthComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                resourceNameComboBox.Items.Add("No PXI Resource found on the system");
                resourceNameComboBox.Enabled = false;
                openButton.Enabled = false;
            }
            resourceNameComboBox.SelectedIndex = 0;
        }

        private void SetupUI(bool sessionActive)
        {
            resourceNameComboBox.Enabled = !sessionActive;
            openButton.Enabled = !sessionActive;
            closeButton.Enabled = sessionActive;
            moveInButton.Enabled = sessionActive;
            inButton.Enabled = sessionActive;
            spaceLabel.Enabled = sessionActive;
            spaceComboBox.Enabled = sessionActive;
            widthLabel.Enabled = sessionActive;
            widthComboBox.Enabled = sessionActive;
            offsetLabel.Enabled = sessionActive;
            offsetNumericUpDown.Enabled = sessionActive;
            numElementsLabel.Enabled = sessionActive;
            numElementsNumericUpDown.Enabled = sessionActive;
        }

        private void ScrollToBottomOfResultTextBox()
        {
            resultTextBox.SelectAll();
        }

        private string GetOperationText(string operation)
        {
            return operation + Environment.NewLine;
        }

        private string GetDataText(string data)
        {
            return (string.Format("Data = {0}", data) + Environment.NewLine);
        }

        private void ShowArray(Array data)
        {
            int i=0;
            foreach(object o in data)
            {
                string formattedValue = string.Empty;
                if(o is byte)
                {
                    formattedValue = ((byte)o).ToString("x");
                }
                else if(o is short)
                {
                    formattedValue = ((short)o).ToString("x");
                }
                else if(o is int)
                {
                    formattedValue = ((int)o).ToString("x");
                }
                else if (o is long)
                {
                    formattedValue = ((long)o).ToString("x");
                }
                resultTextBox.AppendText(string.Format("Data({0} = {1})", i++, formattedValue) + Environment.NewLine);
            }
        }

        private byte[] BuildByteOutputdata()
        {
            int numElements = (int)numElementsNumericUpDown.Value;
            byte[] od = new byte[numElements];
            for (int i = 0; i<numElements; i++)
            {
                od[i] = (byte)numOutputArray[i].Value;
            }
            return od;
        }

        private short[] BuildShortOutputdata()
        {
            int numElements = (int)numElementsNumericUpDown.Value;
            short[] od = new short[numElements];
            for (int i = 0; i<numElements; i++)
            {
                od[i] = (short)numOutputArray[i].Value;
            }
            return od;
        }

        private int[] BuildIntOutputdata()
        {
            int numElements = (int)numElementsNumericUpDown.Value;
            int[] od = new int[numElements];
            for (int i = 0; i<numElements; i++)
            {
                od[i] = (int)numOutputArray[i].Value;
            }
            return od;
        }
    }
}
