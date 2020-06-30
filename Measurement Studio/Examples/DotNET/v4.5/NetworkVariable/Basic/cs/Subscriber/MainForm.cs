using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;


namespace NationalInstruments.Examples.Subscriber
{
    public partial class MainForm : Form
    {
        private NetworkVariableSubscriber<double[]> _subscriber;
        private const string NetworkVariableLocation = @"\\localhost\system\doublearray";

        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateSubscriber()
        {
            _subscriber = new NetworkVariableSubscriber<double[]>(NetworkVariableLocation);
            _subscriber.PropertyChanged += new PropertyChangedEventHandler(OnPropertyChanged);
            _subscriber.DataUpdated += new EventHandler<DataUpdatedEventArgs<double[]>>(OnDataUpdated);
        }

        private void OnDataUpdated(object sender, DataUpdatedEventArgs<double[]> e)
        {
            if (e.Data.HasTimeStamp)
                timeStampTextBox.Text = e.Data.TimeStamp.ToLocalTime().ToString();

            if (e.Data.HasQuality)
                qualityTextBox.Text = e.Data.Quality.ToString();

            if (e.Data.HasValue)
            {
                double[] data = e.Data.GetValue();
                displayWaveformGraph.PlotYAppend(data);
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ConnectionStatus")
                statusTextBox.Text = _subscriber.ConnectionStatus.ToString();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            disconnectButton.Enabled = true;
            if (_subscriber == null)
                CreateSubscriber();

            _subscriber.Connect();
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "Disconnected";

            disconnectButton.Enabled = false;
            connectButton.Enabled = true;
            timeStampTextBox.Text = String.Empty;
            qualityTextBox.Text = String.Empty;

            _subscriber.Disconnect();
            _subscriber = null;
        }


    }
}