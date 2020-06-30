using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NationalInstruments.Examples.Formatting
{
    /// <summary>
    /// This example shows different ways in which Numeric controls can be formatted. Most
    /// of the fomatting is done using format strings in the XAML. However, there is also 
    /// a demonstration of using a ValueFormatter class to format one of the Numeric text boxes.
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            paddingFourBinary.ValueFormatter = new BinaryValueFormatter(4);
            paddingEightBinary.ValueFormatter = new BinaryValueFormatter(8);
        }
    }
}
