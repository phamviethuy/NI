using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;


namespace NationalInstruments.Examples.OnDemandReader
{
    public partial class MainForm : Form
    {
        private NetworkVariableReader<double[]> _reader;
        private const string NetworkVariableLocation = @"\\localhost\system\doublearray";

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateReader()
        {
            _reader = new NetworkVariableReader<double[]>(NetworkVariableLocation);
            _reader.PropertyChanged += OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ConnectionStatus")
            {
                statusTextBox.Text = _reader.ConnectionStatus.ToString();
                readButton.Enabled = (_reader.ConnectionStatus == ConnectionStatus.Connected);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            if(_reader == null)
                CreateReader();

            _reader.Connect();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "Disconnected";

            disconnectButton.Enabled = false;
            connectButton.Enabled = true;
            readButton.Enabled = false;
            _reader.Disconnect();
            _reader = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NetworkVariableData<double[]> data = null;
            try
            {
                data = _reader.ReadData();
            }
            catch (TimeoutException)
            {
                MessageBox.Show("The read has timed out.", "Timeout");
                return;
            }

            if (data.HasValue)
                displayWaveformGraph.PlotYAppend(data.GetValue());
        }

    }
}