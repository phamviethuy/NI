using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using NationalInstruments.Controls.Data;
using System.Windows.Threading;
using NationalInstruments.Controls;

namespace NationalInstruments.Examples.Charting
{
    public partial class MainWindow : Window
    {
        private readonly ChartCollection<double> data = new ChartCollection<double>(100);
        private readonly DispatcherTimer timer = new DispatcherTimer();
        private readonly Random rand = new Random();

        public MainWindow()
        {
            InitializeComponent();
            graph.DataSource = data;
            timer.Tick += OnTimerTick;
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Start();
        }

        void OnTimerTick(object sender, EventArgs e)
        {
            GenerateData();
        }

        private void GenerateData()
        {
            data.Append(rand.NextDouble());
        }

        private void OnContinuousChecked(object sender, RoutedEventArgs e)
        {
            xAxis.Adjuster = RangeAdjuster.ContinuousChart;
        }

        private void OnPagedChecked(object sender, RoutedEventArgs e)
        {
            xAxis.Adjuster = RangeAdjuster.PagedChart;
        }
    }
}
