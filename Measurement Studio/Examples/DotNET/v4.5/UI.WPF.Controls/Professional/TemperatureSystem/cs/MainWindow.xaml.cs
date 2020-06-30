using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Controls;

namespace NationalInstruments.Examples.TemperatureSystem
{
    /// <summary>
    /// This example simulates acquiring temperatures using a histogram and a waveform graph.
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random;
        ChartCollection<double> chartCollection;
        List<double> pointsForAnalysis;
        DispatcherTimer timer;
        string lastStatus;

        const double UPPERLIMIT = 90;
        const double LOWERLIMIT = 70;

        public MainWindow()
        {
            timer = new DispatcherTimer();
            timer.Tick += OnMainTimerTick;

            InitializeComponent();

            lowerLimitRangeCursor.PositionChanged += OnLowerLimitRangeCursorPositionChanged;
            upperLimitRangeCursor.PositionChanged += OnUpperLimitRangeCursorPositionChanged;
            lowLimitKnob.ValueChanged += OnLowLimitKnobValueChanged;
            upperLimitKnob.ValueChanged += OnUpperLimitKnobValueChanged;

            chartCollection = new ChartCollection<double>(1000);
            temperatureGraph.DataSource = chartCollection;

            random = new Random();
            pointsForAnalysis = new List<double>();
        }

        private void OnMainTimerTick(object sender, EventArgs e)
        {
            // Get random new temperature between 70 and 90
            double currentTemp = (random.NextDouble() * 20) + 70;
            currentTemperature.Value = currentTemp;

            // Update TemperatureGraph
            chartCollection.Append(currentTemp);

            UpdateAnalysis(currentTemp);
        }

        private void UpdateAnalysis(double currentTemp)
        {
            if (analyze.Value)
            {
                pointsForAnalysis.Add(currentTemp);
                if (pointsForAnalysis.Count >= 1000)
                {
                    pointsForAnalysis.RemoveAt(0);
                }
                double[] analysisPoints = pointsForAnalysis.ToArray();

                double[] centerValues;

                int[] histogram = Statistics.Histogram(analysisPoints, minimumBin.Value, maximumBin.Value, 25, out centerValues);

                Point[] histogramData = new Point[histogram.Length];
                for (int i = 0; i < histogram.Length; i++)
                {
                    histogramData[i] = new Point(centerValues[i], histogram[i]);
                }

                temperatureHistogram.DataSource = histogramData;

                standardDeviation.Value = Statistics.StandardDeviation(analysisPoints);
                meanTemperature.Value = Statistics.Mean(analysisPoints);
            }
        }

        private void OnUpdateRateValueChanged(object sender, ValueChangedEventArgs<double> e)
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, (int)(e.NewValue * 1000));
        }

        private void OnAcquireValueChanged(object sender, RoutedEventArgs e)
        {
            if (acquire.Value)
            {
                timer.Start();
                statusBar.Text = "Acquiring...";
                ClearHistogramData();
                acquireMenuItem.IsChecked = true;
                acquireToolbarButton.IsChecked = true;
            }
            else
            {
                timer.Stop();
                statusBar.Text = "Ready.";
                acquireMenuItem.IsChecked = false;
                acquireToolbarButton.IsChecked = false;
            }
        }

        private void OnAnalyzeValueChanged(object sender, RoutedEventArgs e)
        {
            ClearHistogramData();
            analyzeMenuItem.IsChecked = analyze.Value;
            analyzeToolbarButton.IsChecked = analyze.Value;
        }

        private void ClearHistogramData()
        {
            if (analyze.Value)
            {
                minimumBin.IsEnabled = false;
                maximumBin.IsEnabled = false;

                temperatureHistogram.DataSource = null;
                pointsForAnalysis.Clear();
                standardDeviation.Value = standardDeviation.Range.Minimum;
                meanTemperature.Value = meanTemperature.Range.Minimum;
            }
            else
            {
                minimumBin.IsEnabled = true;
                maximumBin.IsEnabled = true;

            }
        }

        private void OnUpperLimitRangeCursorPositionChanged(object sender, EventArgs e)
        {
            if ((double)upperLimitRangeCursor.ActualVerticalRange.GetMinimum() < (double)lowerLimitRangeCursor.ActualVerticalRange.GetMaximum())
            {
                upperLimitRangeCursor.VerticalRange = Range.Create(lowerLimitRangeCursor.ActualVerticalRange.GetMaximum(), UPPERLIMIT);
            }
            if ((double)upperLimitRangeCursor.ActualVerticalRange.GetMaximum() < UPPERLIMIT)
            {
                upperLimitRangeCursor.VerticalRange = Range.Create(upperLimitRangeCursor.ActualVerticalRange.GetMinimum(), UPPERLIMIT);
            }
            if ((double)upperLimitRangeCursor.ActualVerticalRange.GetMinimum() > UPPERLIMIT)
            {
                upperLimitRangeCursor.VerticalRange = Range.Create(UPPERLIMIT, UPPERLIMIT);
            }
            upperLimitKnob.Value = (double)upperLimitRangeCursor.ActualVerticalRange.GetMinimum();
        }

        private void OnLowerLimitRangeCursorPositionChanged(object sender, EventArgs e)
        {
            if ((double)upperLimitRangeCursor.ActualVerticalRange.GetMinimum() < (double)lowerLimitRangeCursor.ActualVerticalRange.GetMaximum())
            {
                lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, upperLimitRangeCursor.ActualVerticalRange.GetMinimum());
            }
            if ((double)lowerLimitRangeCursor.ActualVerticalRange.GetMinimum() > LOWERLIMIT)
            {
                lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, lowerLimitRangeCursor.ActualVerticalRange.GetMaximum());
            }
            if ((double)lowerLimitRangeCursor.ActualVerticalRange.GetMaximum() < LOWERLIMIT)
            {
                lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, LOWERLIMIT);
            }
            lowLimitKnob.Value = (double)lowerLimitRangeCursor.ActualVerticalRange.GetMaximum();
        }

        private void OnLowLimitKnobValueChanged(object sender, ValueChangedEventArgs<double> e)
        {
            if (e.NewValue < LOWERLIMIT)
            {
                lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, LOWERLIMIT);
                lowLimitKnob.Value = LOWERLIMIT;
            }
            else
            {
                lowerLimitRangeCursor.VerticalRange = Range.Create(LOWERLIMIT, e.NewValue);
            }
        }

        private void OnUpperLimitKnobValueChanged(object sender, ValueChangedEventArgs<double> e)
        {
            if (e.NewValue > UPPERLIMIT)
            {
                upperLimitRangeCursor.VerticalRange = Range.Create(UPPERLIMIT, UPPERLIMIT);
                upperLimitKnob.Value = UPPERLIMIT;
            }
            else
            {
                upperLimitRangeCursor.VerticalRange = Range.Create(e.NewValue, UPPERLIMIT);
            }
        }

        private void OnMinimumBinValueChanging(object sender, ValueChangingEventArgs<double> e)
        {
            if (e.NewValue >= maximumBin.Value || e.NewValue < LOWERLIMIT)
                e.Cancel = true;
        }

        private void OnMaximumBinValueChanging(object sender, ValueChangingEventArgs<double> e)
        {
            if (e.NewValue <= minimumBin.Value || e.NewValue > UPPERLIMIT)
                e.Cancel = true;
        }

        private void OnAnalyzeMenuChecked(object sender, RoutedEventArgs e)
        {
            analyze.Value = true;
        }

        private void OnAnalyzeMenuUnchecked(object sender, RoutedEventArgs e)
        {
            analyze.Value = false;
        }

        private void OnAcquireMenuChecked(object sender, RoutedEventArgs e)
        {
            acquire.Value = true;
        }

        private void OnAcquireMenuUnchecked(object sender, RoutedEventArgs e)
        {
            acquire.Value = false;
        }

        private void OnExitMenuItemClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OnAcquireToolbarButtonClick(object sender, RoutedEventArgs e)
        {
            acquire.Value = acquireToolbarButton.IsChecked.Value;
        }

        private void OnAnalyzeToolbarButtonClick(object sender, RoutedEventArgs e)
        {
            analyze.Value = analyzeToolbarButton.IsChecked.Value;
        }

        private void OnMenuItemMouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            if (item != null)
            {
                lastStatus = statusBar.Text;
                string newStatus = item.ToolTip as string;
                statusBar.Text = newStatus == null ? lastStatus : newStatus;
            }
        }

        private void OnMenuItemMouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            statusBar.Text = lastStatus;
        }
    }
}
