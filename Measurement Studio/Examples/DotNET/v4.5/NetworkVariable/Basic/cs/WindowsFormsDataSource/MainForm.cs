using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NationalInstruments.Examples.WindowsFormsDataSource
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            try
            {
                dataSource.Connect();
            }
            catch (Exception)
            {
                MessageBox.Show("Start the Network Variable BufferedWriter example before running this example.", "National Instruments", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}