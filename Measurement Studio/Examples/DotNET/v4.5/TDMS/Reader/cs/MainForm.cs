using System;
using System.IO;
using System.Windows.Forms;

namespace NationalInstruments.Examples.Reader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnTdmsFileBrowseButtonClicked(object sender, EventArgs e)
        {
            tdmsOpenFileDialog.InitialDirectory = GetInitialDirectory();
            if(tdmsOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                tdmsFileTextBox.Text = tdmsOpenFileDialog.FileName;

                try
                {
                    readerTdmsReaderUserControl.LoadFile(tdmsOpenFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error: {0}", ex.Message));
                }
            }
        }

        private string GetInitialDirectory()
        {
            string initialDirectory = @"..\..";
            DirectoryInfo currentDirectory = new DirectoryInfo(Environment.CurrentDirectory);
            if (currentDirectory.Parent != null)
            {
                DirectoryInfo parentDirectory = currentDirectory.Parent;
                if (parentDirectory.Parent != null)
                {
                    initialDirectory = parentDirectory.Parent.FullName;
                }
            }
            return initialDirectory;
        }
    }
}