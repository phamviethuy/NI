using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using NationalInstruments.Controls;

namespace NationalInstruments.Examples.CoercionModes
{
    /// <summary>
    /// This example shows how different coercion modes work for a Knob of type double. The user 
    /// can see how the coercion works when directly manipulating the Knob and when a 
    /// value is sent to the Knob.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CoercedValueChanged(object sender, Controls.ValueChangedEventArgs<double> args)
        {
            previousValueDouble.Value = doubleKnob.CoercionMode.GetMultipleIncrementValue(doubleKnob, doubleKnob.CoercedValue, -1);
            nextValueDouble.Value = doubleKnob.CoercionMode.GetMultipleIncrementValue(doubleKnob, doubleKnob.CoercedValue, 1);
        }

        private void OnNoneCoercionModeButtonChecked(object sender, RoutedEventArgs e)
        {
            doubleKnob.CoercionMode = NumericPointerCoercionMode.None;
        }

        private void OnToDivisionsCoercionModeButtonChecked(object sender, RoutedEventArgs e)
        {
            doubleKnob.CoercionMode = NumericPointerCoercionMode.ToDivisions;
        }

        private void OnToIntervalFromMinimumCoercionModeButtonChecked(object sender, RoutedEventArgs e)
        {
            doubleKnob.CoercionMode = NumericPointerCoercionMode.ToIntervalFromMinimum;
        }

        private void OnToIntervalFromBaseCoercionModeButtonChecked(object sender, RoutedEventArgs e)
        {
            doubleKnob.CoercionMode = NumericPointerCoercionMode.CreateToIntervalFromBaseMode(intervalBaseDouble.Value);
        }

        private void OnIntervalBaseDoubleValueChanged(object sender, ValueChangedEventArgs<double> e)
        {
            doubleKnob.CoercionMode = NumericPointerCoercionMode.CreateToIntervalFromBaseMode(intervalBaseDouble.Value);
        }

        private void OnCommitButtonClick(object sender, RoutedEventArgs e)
        {
            doubleKnob.Value = setValueDouble.Value;
        }
    }
}
