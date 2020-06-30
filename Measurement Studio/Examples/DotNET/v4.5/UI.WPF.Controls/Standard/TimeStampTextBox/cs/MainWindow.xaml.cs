using System;
using System.Windows;
using System.Windows.Controls;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Primitives;

namespace NationalInstruments.Examples.TimeStampTextBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            timestamp.Value = DateTime.Now;
        }

        private void OnInteractionModeCheckBoxClicked(object sender, RoutedEventArgs e)
        {
            var checkbox = (CheckBox)e.OriginalSource;
            var flag = (TimeStampTextBoxInteractionModes)checkbox.Content;
            if (checkbox.IsChecked == true)
            {
                timestamp.InteractionMode |= flag;
            }
            else
            {
                timestamp.InteractionMode &= ~flag;
            }
        }

        private void OnRangeRadioButtonClicked(object sender, RoutedEventArgs e)
        {
            var button = (RadioButton)e.OriginalSource;
            var parent = (Panel)button.Parent;
            int index = parent.Children.IndexOf(button);

            Range<DateTime> range;
            TimeSpan interval;
            switch (index)
            {
                default:
                case 0:
                    range = Range.Create(DateTime.MinValue, DateTime.MaxValue);
                    interval = TimeSpan.FromSeconds(1);
                    break;
                case 1:
                    var today = DateTime.Now.Date;
                    range = Range.Create(today, today.AddDays(1).AddSeconds(-1));
                    interval = TimeSpan.FromHours(1);
                    break;
                case 2:
                    var year = new DateTime(DateTime.Now.Year, 1, 1);
                    range = Range.Create(year, year.AddYears(1).AddSeconds(-1));
                    interval = TimeSpan.FromDays(1);
                    break;
            }

            timestamp.Range = range;
            timestamp.Interval = interval;
        }

        private void OnFormatRadioButtonClicked(object sender, RoutedEventArgs e)
        {
            var button = (RadioButton)e.OriginalSource;
            string format = (string)button.Tag;

            timestamp.ValueFormatter = new TimeValueFormatter(format);
        }
    }
}
