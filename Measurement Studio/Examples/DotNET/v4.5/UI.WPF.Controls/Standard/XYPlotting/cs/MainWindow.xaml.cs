using System;
using System.Windows;

namespace NationalInstruments.Examples.XYPlotting
{
    /// <summary>
    /// Example of how to write data to a graph in WPF. Specifically, we look at writing
    /// XY data to a graph using an array of points. There are three graphs displayed:
    /// the XY Plot of the data, the X component of the data, and then the Y component
    /// of the data.
    /// </summary>
    public partial class MainWindow : Window
    {
        const double TwoPi = Math.PI * 2;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGraph();
        }

        // Graph initialization can be time consuming.  The code below initializes the graph during application load time.
        // This ensures that there will not be a delay during execution of your application.
        private void InitializeGraph()
        {
            xGraph.DataSource = new double[1];
            yGraph.DataSource = new double[1];
            xyGraph.DataSource = new Point[1];
        }

        public void OnPlotCircleButtonClick(object sender, RoutedEventArgs e)
        {
            const int numberOfPoints = 100;
            const int radius = 10;
            const double angleIncrementFactor = TwoPi / (numberOfPoints - 1);

            double[] dataX = new double[numberOfPoints];
            double[] dataY = new double[numberOfPoints];
            Point[] dataXY = new Point[numberOfPoints];

            double angle = 0;
            for (int i = 0; i < numberOfPoints; ++i)
            {
                angle += angleIncrementFactor;
                dataX[i] = radius * Math.Cos(angle);
                dataY[i] = radius * Math.Sin(angle);
                dataXY[i] = new Point(dataX[i], dataY[i]);
            }

            xGraph.DataSource = dataX;
            yGraph.DataSource = dataY;
            xyGraph.DataSource = dataXY;
        }

        private void OnPlotOctagonButtonClick(object sender, RoutedEventArgs e)
        {
            const int numberOfSides = 8;
            const int numberOfPoints = numberOfSides + 1;

            double[] dataX = new double[numberOfPoints];
            double[] dataY = new double[numberOfPoints];
            Point[] dataXY = new Point[numberOfPoints];

            for (int i = 0; i < numberOfPoints; ++i)
            {
                dataX[i] = Math.Cos(((i + 0.5) / numberOfSides) * TwoPi);
                dataY[i] = Math.Sin(((i + 0.5) / numberOfSides) * TwoPi);
                dataXY[i] = new Point(dataX[i], dataY[i]);
            }

            xGraph.DataSource = dataX;
            yGraph.DataSource = dataY;
            xyGraph.DataSource = dataXY;
        }

        private void OnPlotPolarButtonClick(object sender, RoutedEventArgs e)
        {
            const int numberOfPoints = 360;
            const int divisor = numberOfPoints - 1;
            double[] radiusData = new double[numberOfPoints];
            double[] angleData = new double[numberOfPoints];
            double[] dataX = new double[numberOfPoints];
            double[] dataY = new double[numberOfPoints];
            Point[] dataXY = new Point[numberOfPoints];

            // Calculate data in polar coordinates.
            for (int i = 0; i < numberOfPoints; ++i)
            {
                angleData[i] = i;
                radiusData[i] = Math.Sin(((double)i / divisor) * TwoPi * 3) + 0.5;
            }

            // Convert polar coordinates to XY coordinates.
            for (int i = 0; i < numberOfPoints; ++i)
            {
                double current = (angleData[i] / numberOfPoints) * TwoPi;
                dataX[i] = Math.Cos(current) * radiusData[i];
                dataY[i] = Math.Sin(current) * radiusData[i];
                dataXY[i] = new Point(dataX[i], dataY[i]);
            }

            xGraph.DataSource = dataX;
            yGraph.DataSource = dataY;
            xyGraph.DataSource = dataXY;
        }

        private void OnPlotSpiralButtonClick(object sender, RoutedEventArgs e)
        {
            int numberOfPoints = 1000;

            double[] dataX = new double[numberOfPoints];
            double[] dataY = new double[numberOfPoints];
            Point[] dataXY = new Point[numberOfPoints];

            double angleIncrementFactor = 0.05;
            for (int i = 0; i < numberOfPoints; i++)
            {
                dataX[i] = Math.Cos(i * angleIncrementFactor) * i;
                dataY[i] = Math.Sin(i * angleIncrementFactor) * i;
                dataXY[i] = new Point(dataX[i], dataY[i]);
            }

            xGraph.DataSource = dataX;
            yGraph.DataSource = dataY;
            xyGraph.DataSource = dataXY;
        }
    }
}
