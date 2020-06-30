using System;
using System.Windows;
using NationalInstruments.Controls;

namespace NationalInstruments.Examples.Formats
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void powerLimitSlider_ValueChanging(object sender, ValueChangingEventArgs<double> e)
        {
            if (e.NewValue < powerGauge.Value)
            {
                e.NewValue = powerGauge.Value;
            }
        }

        private void voltageSlider_ValueChanging(object sender, ValueChangingEventArgs<double> e)
        {
            double power = GetPower(e.NewValue, resistanceSlider.Value);
            if (power > powerLimitSlider.Value)
            {
                e.NewValue = Math.Sqrt(powerLimitSlider.Value * resistanceSlider.Value);
                voltageSlider.Value = e.NewValue;
            }
        }

        private void voltageSlider_ValueChanged(object sender, ValueChangedEventArgs<double> e)
        {
            powerGauge.Value = GetPower(e.NewValue, resistanceSlider.Value);
        }

        private void resistanceSlider_ValueChanging(object sender, ValueChangingEventArgs<double> e)
        {
            double power = GetPower(voltageSlider.Value, e.NewValue);
            if (power > powerLimitSlider.Value)
            {
                e.NewValue = GetPower(voltageSlider.Value, powerLimitSlider.Value);
            }
        }

        private void resistanceSlider_ValueChanged(object sender, ValueChangedEventArgs<double> e)
        {
            powerGauge.Value = GetPower(voltageSlider.Value, e.NewValue);
        }

        private static double GetPower(double voltage, double resistance)
        {
            return (voltage * voltage) / resistance;
        }
    }
}
