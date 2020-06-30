using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.NetworkVariable;
using System.Threading;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.BufferedWriter
{
    public partial class MainForm : Form
    {
        private NetworkVariableBufferedWriter<double[]> _bufferedWriter;
        private NetworkVariableBufferedWriter<double> _doubleBufferedWriter;
        private const string NetworkVariableLocation = @"\\localhost\system\doublearray";
        private const string DoubleNetworkVariableLocation = @"\\localhost\system\double";
        private Thread _workerThread;

        public MainForm()
        {
            InitializeComponent();
            _bufferedWriter = new NetworkVariableBufferedWriter<double[]>(NetworkVariableLocation);
            _doubleBufferedWriter = new NetworkVariableBufferedWriter<double>(DoubleNetworkVariableLocation);
            _bufferedWriter.PropertyChanged += OnPropertyChanged;
            amplitudeSlide.AfterChangeValue += OnAmplitudeSlideValueChanged;
            _doubleBufferedWriter.Connect();
            _bufferedWriter.Connect();
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ConnectionStatus")
                connectionTextBox.Text = _bufferedWriter.ConnectionStatus.ToString();
        }

        private double[] GenerateDoubleArray(double phase)
        {
            double amplitude = amplitudeSlide.Value;
            double[] values = new double[1000];
            for(int x = 0; x < 1000; x++)
                values[x] = Math.Sin(((2 * Math.PI * x) / 1000) + phase) * amplitude;

            return values;
        }

        private void WriteData(object state)
        {
            int phase = 0;
            while (true)
            {
                double[] values = GenerateDoubleArray(phase);
                Invoke(new EventHandler(delegate{ sampleWaveformGraph.PlotYAppend(values); }));
                _bufferedWriter.WriteValue(values);
                Thread.Sleep(500);
                phase++;
            }
        }

        private void OnAmplitudeSlideValueChanged(object sender, AfterChangeNumericValueEventArgs e)
        {
            _doubleBufferedWriter.WriteValue(amplitudeSlide.Value);
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {            
            startButton.Enabled = false;
            stopButton.Enabled = true;
            _workerThread = new Thread(WriteData);
            _workerThread.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = true;
            stopButton.Enabled = false;
            _workerThread.Abort();
        }

       
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if(_workerThread != null)
                _workerThread.Abort();
            Application.Exit();
        }
    }
}