using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Rendering;
using System.Windows.Media;

namespace DefaultPlotRenderers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly LinePlotRenderer modifiedRenderer = new LinePlotRenderer() { Stroke = Brushes.Aquamarine, StrokeThickness = 3, StrokeDashArray = new DoubleCollection() { 4, 2 } };
        private readonly PlotRendererCollection alternateDefaultRenderers = new PlotRendererCollection()
            {
                new LinePlotRenderer() { Stroke = Brushes.Yellow, StrokeThickness = 5 },
                new LinePlotRenderer() { Stroke = Brushes.Purple, StrokeThickness = 5 },
                new LinePlotRenderer() { Stroke = Brushes.Orange, StrokeThickness = 5 }
            };
       
        public MainWindow()
        {
            InitializeComponent();
            GenerateData();
        }

        private void GenerateData()
        {
            Random random = new Random();
            int rows = graph.Plots.Count;
            int columns = 21;

            double[,] data = new double[rows, columns];
            for (int i = 0; i <= rows - 1; i++)
            {
                for (int j = 0; j <= columns - 1; j++)
                {
                    data[i, j] = i + random.NextDouble();
                }
            }

            graph.DataSource = data;
        }

        private void OnChangeDefaultStylesButtonClicked(object sender, RoutedEventArgs e)
        {
            ToggleButton button = (ToggleButton)sender;
            if (Convert.ToBoolean(button.IsChecked))
            {
                graph.DefaultPlotRenderers.ReplaceAll(alternateDefaultRenderers);
            }
            else
            {
                graph.DefaultPlotRenderers.Clear();
            }
        }

        private void OnResetRenderersButtonClicked(object sender, RoutedEventArgs e)
        {
            foreach (Plot plot in graph.Plots)
            {
                plot.Renderer = null;
            }

            Plot1DefaultRendererCheckBox.IsChecked = true;
            Plot2DefaultRendererCheckBox.IsChecked = true;
            Plot3DefaultRendererCheckBox.IsChecked = true;
        }

        private void OnGenerateDataButtonClicked(object sender, RoutedEventArgs e)
        {
            GenerateData();
        }

        private void OnAddPlotButtonClicked(object sender, RoutedEventArgs e)
        {
            graph.Plots.Add(new Plot("Plot " + (graph.Plots.Count + 1)));
            GenerateData();
        }

        private void OnDefaultRendererCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            Plot plot = (Plot)checkbox.Tag;
            if (plot != null)
            {
                plot.Renderer = null;
            }
        }

        private void OnDefaultRendererCheckBoxUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            Plot plot = (Plot)checkbox.Tag;
            if (plot != null)
            {
                plot.Renderer = modifiedRenderer;
            }
        }
    }
}
