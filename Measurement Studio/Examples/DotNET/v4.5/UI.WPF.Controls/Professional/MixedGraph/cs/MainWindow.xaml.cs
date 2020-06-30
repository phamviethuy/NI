using System;
using System.Windows;
using NationalInstruments.Controls;

namespace NationalInstruments.Examples.MixedGraph
{
    public partial class MainWindow : Window
    {
        private const int DataCount = 66;

        public MainWindow()
        {
            InitializeComponent();
            PlotDigitalData();
            PlotAnalogData();
        }

        private void OnPlotDigitalDataClicked(object sender, RoutedEventArgs e)
        {
            PlotDigitalData();
        }

        private void OnPlotAnalogDataClicked(object sender, RoutedEventArgs e)
        {
            PlotAnalogData();
        }

        private void OnClearDataClicked(object sender, RoutedEventArgs e)
        {
            mixedGraph.Data.Clear();
        }

        private void PlotDigitalData()
        {
            const int DigitalReductionFactor = 10;

            Random random = new Random();
            byte[] randomValues = new byte[1 + DataCount / DigitalReductionFactor];
            random.NextBytes(randomValues);

            byte[] digitalData = new byte[DataCount];
            for (int i = 0; i < DataCount; ++i)
            {
                digitalData[i] = randomValues[i / DigitalReductionFactor];
            }

            mixedGraph.Data[0] = digitalData;
        }

        private void PlotAnalogData()
        {
            Random random = new Random();
            double[] analogData = new double[DataCount];
            for (int i = 0; i < DataCount; ++i)
            {
                double value = 12.3 * random.NextDouble() * Math.Sin(i * Math.PI * Math.PI / DataCount);
                analogData[i] = value;
            }

            mixedGraph.Data[1] = analogData;
        }

        private void OnAnalogPositionSliderValueChanged(object sender, ValueChangedEventArgs<int> e)
        {
            double change = e.NewValue - e.OldValue;
            Range<double> currentRange = yAxis.Range;
            yAxis.Range = new Range<double>(
                currentRange.Minimum + change,
                currentRange.Maximum + change);
        }
    }
}
