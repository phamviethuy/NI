using System;
using System.Windows;
using System.Windows.Media;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Rendering;

namespace NationalInstruments.Examples.PlotRenderer
{
    public partial class MainWindow : Window
    {
        private static readonly LinePlotRenderer linePlotRenderer = new LinePlotRenderer() { Stroke = Brushes.Red, StrokeThickness = 2 };
        private static readonly AreaPlotRenderer areaPlotRenderer = new AreaPlotRenderer() { Fill = Brushes.Blue };
        private static readonly PointPlotRenderer pointPlotRenderer = new PointPlotRenderer() { Stroke = Brushes.Green, Fill = Brushes.RoyalBlue, Shape = PointShape.Diamond, Size = new Size(10, 10) };
        private static readonly BarPlotRenderer barPlotRenderer = new BarPlotRenderer() { Stroke = Brushes.Orange, Fill = Brushes.Purple, StrokeThickness = 3, BarWidth = 0.5 };
        private static readonly PlotRendererGroup plotRendererGroup = new PlotRendererGroup { PlotRenderers = { linePlotRenderer, pointPlotRenderer } };
        private static readonly Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
            GenerateData();
        }

        private void GenerateData()
        {
            int dataCount = 41;

            double[] newData = new double[dataCount];
            for (int i = 0; i <= dataCount - 1; i++)
            {
                newData[i] = (random.NextDouble() * 40) - 20;
            }

            graph.DataSource = newData;
        }

        private void OnGenerateDataButtonClicked(object sender, RoutedEventArgs e)
        {
            GenerateData();
        }

        private void EnableFillToRadioButtons()
        {
            if (fillToZeroRadioButton != null)
            {
                fillToZeroRadioButton.IsEnabled = true;
            }

            if (fillToPositiveInfinityRadioButton != null)
            {
                fillToPositiveInfinityRadioButton.IsEnabled = true;
            }

            if (fillToNegativeInfinityRadioButton != null)
            {
                fillToNegativeInfinityRadioButton.IsEnabled = true;
            }
        }

        private void DisableFillToRadioButtons()
        {
            if (fillToZeroRadioButton != null)
            {
                fillToZeroRadioButton.IsEnabled = false;
            }

            if (fillToPositiveInfinityRadioButton != null)
            {
                fillToPositiveInfinityRadioButton.IsEnabled = false;
            }

            if (fillToNegativeInfinityRadioButton != null)
            {
                fillToNegativeInfinityRadioButton.IsEnabled = false;
            }
        }

        private void OnBarPlotRendererRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            EnableFillToRadioButtons();
            graph.Plots[0].Renderer = barPlotRenderer;
        }

        private void OnPointPlotRendererRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            DisableFillToRadioButtons();
            graph.Plots[0].Renderer = pointPlotRenderer;
        }

        private void OnLinePlotRendererRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            DisableFillToRadioButtons();
            graph.Plots[0].Renderer = linePlotRenderer;
        }

        private void OnAreaPlotRendererRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            EnableFillToRadioButtons();
            graph.Plots[0].Renderer = areaPlotRenderer;
        }

        private void OnPlotRendererGroupRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            DisableFillToRadioButtons();
            graph.Plots[0].Renderer = plotRendererGroup;
        }

        private void OnFillToZeroRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            areaPlotRenderer.FillBaseline = FillBaseline.Zero;
            barPlotRenderer.FillBaseline = FillBaseline.Zero;
        }

        private void OnFillToPositiveInfinityRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            areaPlotRenderer.FillBaseline = FillBaseline.PositiveInfinity;
            barPlotRenderer.FillBaseline = FillBaseline.PositiveInfinity;
        }

        private void OnFillToNegativeInfinityRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            areaPlotRenderer.FillBaseline = FillBaseline.NegativeInfinity;
            barPlotRenderer.FillBaseline = FillBaseline.NegativeInfinity;
        }
    }
}
