using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Threading;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Data;

namespace NationalInstruments.Examples.FitAdjusterComparison
{
    public partial class MainWindow : Window
    {
        private ChartCollection<double> data;
        private readonly DispatcherTimer timer;

        public MainWindow()
        {
            data = new ChartCollection<double>();
            DataContext = data;

            InitializeComponent();

            timer = new DispatcherTimer(TimeSpan.FromSeconds(1.0 / 3.0), DispatcherPriority.Normal, OnTimerTick, Dispatcher);
        }

        private void OnPauseChecked(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = false;

            fitGraph.DefaultInteraction = GraphInteraction.PanHorizontal;
            fitVisibleGraph.DefaultInteraction = GraphInteraction.PanHorizontal;
        }

        private void OnPauseUnchecked(object sender, RoutedEventArgs e)
        {
            timer.IsEnabled = true;

            fitGraph.DefaultInteraction = GraphInteraction.None;
            fitVisibleGraph.DefaultInteraction = GraphInteraction.None;
        }

        private void OnClearClicked(object sender, RoutedEventArgs e)
        {
            data.Clear();
        }

        // Plot random data on every timer tick.
        private Random random = new Random();
        private const int NoiseFrequency = 20;
        private int counter = NoiseFrequency / 2;
        private void OnTimerTick(object sender, EventArgs e)
        {
            ++counter;
            double dataPoint = random.NextDouble() - 0.5;

            // Introduce extra noise every few points.
            if (counter % NoiseFrequency == 0)
                dataPoint *= NoiseFrequency * 2;

            data.Append(dataPoint);
        }
    }
}
