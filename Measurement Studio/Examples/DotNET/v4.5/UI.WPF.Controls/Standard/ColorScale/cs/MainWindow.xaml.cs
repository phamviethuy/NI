using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using NationalInstruments.Controls;

namespace NationalInstruments.Examples.ColorScale
{
    public partial class MainWindow : Window
    {
        private static readonly ColorScaleMarker[] GrayScaleMarkers = 
            { 
                new ColorScaleMarker(0, Colors.Black), 
                new ColorScaleMarker(10000, Colors.White) 
            };
        private static readonly ColorScaleMarker[] RedToneMarkers = 
            { 
                new ColorScaleMarker(0, Colors.DarkRed), 
                new ColorScaleMarker(2500, Colors.Brown), 
                new ColorScaleMarker(5000, Colors.Red), 
                new ColorScaleMarker(7500, Colors.Orange), 
                new ColorScaleMarker(10000, Colors.Yellow) 
            };
        private static readonly ColorScaleMarker[] HighLowMarkers = 
            { 
                new ColorScaleMarker(0, Colors.Blue), 
                new ColorScaleMarker(10000, Colors.Red) 
            };
        private static readonly ColorScaleMarker[] HighNormalLowMarkers = 
            { 
                new ColorScaleMarker(0, Colors.Blue), 
                new ColorScaleMarker(5000, Colors.Lime), 
                new ColorScaleMarker(10000, Colors.Red) };
        private static readonly ColorScaleMarker[] RainbowMarkers = 
            { 
                new ColorScaleMarker(0, Colors.DarkViolet), 
                new ColorScaleMarker(1500, Colors.Indigo), 
                new ColorScaleMarker(3000, Colors.Blue), 
                new ColorScaleMarker(5000, Colors.Green), 
                new ColorScaleMarker(7000, Colors.Yellow), 
                new ColorScaleMarker(8500, Colors.Orange), 
                new ColorScaleMarker(10000, Colors.Red) 
            };

        private bool radioButtonsEnabled;

        public MainWindow()
        {
            InitializeComponent();
            InitializeColorPickers();

            radioButtonsEnabled = true;
            double[,] data = GenerateIntensityData();
            intensityGraph.DataSource = data;
            grayScaleColorsRadioButton.IsChecked = true;
        }

        private void InitializeColorPickers()
        {
            FillComboBoxWithColors(LowColorChooser);
            FillComboBoxWithColors(HighColorChooser);
            FillComboBoxWithColors(AddColorMarkerColorPicker);

            LowColorChooser.SelectedIndex = 0;
            HighColorChooser.SelectedIndex = 1;
            AddColorMarkerColorPicker.SelectedIndex = 1;
        }

        private static void FillComboBoxWithColors(ComboBox comboBox)
        {
            AddColorToComboBox(comboBox, Colors.Black);
            AddColorToComboBox(comboBox, Colors.White);
            AddColorToComboBox(comboBox, Colors.Red);
            AddColorToComboBox(comboBox, Colors.Orange);
            AddColorToComboBox(comboBox, Colors.Yellow);
            AddColorToComboBox(comboBox, Colors.Green);
            AddColorToComboBox(comboBox, Colors.Cyan);
            AddColorToComboBox(comboBox, Colors.Blue);
            AddColorToComboBox(comboBox, Colors.Magenta);
            AddColorToComboBox(comboBox, Colors.Purple);
            AddColorToComboBox(comboBox, Colors.Transparent);
        }

        private static void AddColorToComboBox(ComboBox ComboBox, Color color)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Margin = new Thickness(0, 4, 0, 4);
            rectangle.Width = 100;
            rectangle.Height = 15;
            rectangle.Fill = new SolidColorBrush(color);
            ComboBox.Items.Add(rectangle);
        }

        private static Color GetColor(ComboBox comboBox)
        {
            Rectangle rectangle = comboBox.SelectedItem as Rectangle;
            return ((SolidColorBrush)(rectangle.Fill)).Color;
        }

        private void OnRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            // A predefined ColorScale setting is selected. So just disable the custom radio button.
            if (customColorsRadioButton.IsEnabled == true)
            {
                customColorsRadioButton.IsEnabled = false;
            }

            ConfigureColorScale();
        }

        // Configure the ColorScale for the selected predefined ColorScale setting.
        private void ConfigureColorScale()
        {
            if (radioButtonsEnabled && !(bool)customColorsRadioButton.IsChecked)
            {
                colorScale.Markers.Clear();

                if ((bool)grayScaleColorsRadioButton.IsChecked)
                {
                    colorScale.Markers.ReplaceAll(GrayScaleMarkers);
                }
                else if ((bool)redToneColorsRadioButton.IsChecked)
                {
                    colorScale.Markers.ReplaceAll(RedToneMarkers);
                }
                else if ((bool)highLowColorsRadioButton.IsChecked)
                {
                    colorScale.Markers.ReplaceAll(HighLowMarkers);
                }
                else if ((bool)highNormalLowColorsRadioButton.IsChecked)
                {
                    colorScale.Markers.ReplaceAll(HighNormalLowMarkers);
                }
                else if ((bool)rainbowColorsRadioButton.IsChecked)
                {
                    colorScale.Markers.ReplaceAll(RainbowMarkers);
                }
            }
        }

        private double[,] GenerateIntensityData()
        {
            int size = 201;
            int radius = 100;
            double[,] data = new double[size, size];
            // Here we generate data in a circular manner.
            // Use the equation of a circle and transpose the origin.
            for (int i = -radius; i <= radius; i++)
            {
                for (int j = -radius; j <= radius; j++)
                {
                    data[radius + i, radius + j] = i * i + j * j;
                }
            }
            return data;
        }

        private void OnLowColorChooserSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color color = GetColor((ComboBox)sender);
            colorScale.LowColor = color;
        }

        private void OnHighColorChooserSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color color = GetColor((ComboBox)sender);
            colorScale.HighColor = color;
        }

        private void OnAddColorMarkerButtonClicked(object sender, RoutedEventArgs e)
        {
            customColorsRadioButton.IsChecked = true;
            customColorsRadioButton.IsEnabled = true;

            Color color = GetColor((ComboBox)AddColorMarkerColorPicker);
            colorScale.Markers.Add(new ColorScaleMarker(AddColorMarkerNumericTextBox.Value, color));
        }
    }
}
