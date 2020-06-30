using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Data;
using NationalInstruments.Controls.Rendering;

namespace NationalInstruments.Examples.WritableGraph
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeGraph();

            graph.InputData.Changed += new EventHandler(OnInputDataChanged);
        }

        // Graph initialization can be time consuming.  The code below initializes the graph during application load time.
        // This ensures that there will not be a delay during execution of your application.
        private void InitializeGraph()
        {
            graph.DataSource = new double[1];
        }

        private void GenerateData()
        {
            Random random = new Random();
            int dataCount = 101;

            double[] newData = new double[dataCount];
            for (int i = 0; i <= dataCount - 1; i++)
            {
                newData[i] = random.NextDouble() * 100;
            }

            graph.DataSource = newData;
        }

        private void OnInputDataChanged(object sender, EventArgs e)
        {
            InputDataCollection collection = (InputDataCollection)sender;
            dataCountTextBox.Text = collection.Count.ToString();
        }

        private void OnGenerateDataButtonClicked(object sender, RoutedEventArgs e)
        {
            GenerateData();
        }

        private void OnNewInputPlotButtonClicked(object sender, RoutedEventArgs e)
        {
            // The SelectedPlot is cleared so that a new input plot will be generated
            graph.SelectedPlot = null;
        }

        private void OnDrawPlotRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            graph.DefaultInteraction = GraphEditInteraction.EditWaveform;
        }

        private void OnZoomOutRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            graph.DefaultInteraction = GraphInteraction.ZoomOut;
        }

        private void OnZoomInRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            graph.DefaultInteraction = GraphInteraction.ZoomIn;
        }

        private void OnPanRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            graph.DefaultInteraction = GraphInteraction.Pan;
        }

        private void OnComboBoxSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            switch (box.SelectedIndex)
            {
                case 0:
                    InputData.SetDataInterval(horizontalAxis, 1);
                    break;
                case 1:
                    InputData.SetDataInterval(horizontalAxis, 5);
                    break;
                case 2:
                    InputData.SetDataInterval(horizontalAxis, 10);
                    break;
            }
        }
    }
}
