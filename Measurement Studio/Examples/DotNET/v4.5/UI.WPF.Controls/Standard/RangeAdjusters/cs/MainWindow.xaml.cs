
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using NationalInstruments.Controls;
using NationalInstruments.Controls.Data;

namespace NationalInstruments.Examples.RangeAdjusters
{
    public partial class MainWindow : Window
    {
        private const int DataCount = 56;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGraph();

            AxisSynchronizer.AddSynchronizedAxis(graph, Orientation.Horizontal, horizontalAdjuster, horizontalMinimum, horizontalMaximum);
            AxisSynchronizer.AddSynchronizedAxis(graph, Orientation.Vertical, verticalAdjuster, verticalMinimum, verticalMaximum);
        }

        // Graph initialization can be time consuming.  The code below initializes the graph during application load time.
        // This ensures that there will not be a delay during execution of your application.
        private void InitializeGraph()
        {
            graph.DataSource = new double[1];
        }

        private void OnPlotDataClicked(object sender, RoutedEventArgs e)
        {
            // Send a full plot of data to the graph.
            Random random = new Random();
            double[] plotData = new double[DataCount];
            for (int i = 0; i < DataCount; ++i)
            {
                double value = 1.2 * random.NextDouble() * Math.Sin(i * Math.PI * Math.PI / DataCount);
                plotData[i] = value;
            }

            graph.DataSource = plotData;
        }

        private void OnChartDataClicked(object sender, RoutedEventArgs e)
        {
            // Retrieve or create a chart collection, and append ten more points.
            var chartData = graph.DataSource as ChartCollection<double> ?? new ChartCollection<double>(capacity: DataCount);
            Random random = new Random();
            do
            {
                double value = 1.2 * random.NextDouble() * Math.Cos(chartData.Count * Math.PI * Math.PI / DataCount);
                chartData.Append(value);
            } while (chartData.Count <= 1 || chartData.Last<Sample<ulong, double>>().Index % 10 != 0);

            graph.DataSource = chartData;
        }

        private void OnClearDataClicked(object sender, RoutedEventArgs e)
        {
            // Remove data from graph.
            graph.DataSource = null;
        }


        private sealed class AxisSynchronizer
        {
            private readonly AxisDouble axis;
            private readonly NumericTextBoxDouble minimum;
            private readonly NumericTextBoxDouble maximum;
            private bool updating;

            public static void AddSynchronizedAxis(Graph graph, Orientation orientation, ComboBox adjuster, NumericTextBoxDouble minimum, NumericTextBoxDouble maximum)
            {
                // Create axis for specified orientation and add to graph.
                var axis = new AxisDouble { Orientation = orientation, Range = Range.Create(0.0, 20.0) };
                graph.Axes.Add(axis);

                // Bind adjuster to combo box's selection.
                adjuster.ItemsSource = EnumObject.GetValues(typeof(RangeAdjuster));
                adjuster.SelectedItem = axis.Adjuster;
                Binding binding = new Binding { Source = adjuster, Path = new PropertyPath(ComboBox.SelectedItemProperty) };
                BindingOperations.SetBinding(axis, AxisDouble.AdjusterProperty, binding);

                // Track changes to the axis range and the text boxes to keep values in sync.
                var synchronizer = new AxisSynchronizer(axis, minimum, maximum);
                synchronizer.OnAxisRangeChanged(axis, EventArgs.Empty);
            }

            private AxisSynchronizer(AxisDouble axis, NumericTextBoxDouble minimum, NumericTextBoxDouble maximum)
            {
                this.axis = axis;
                this.minimum = minimum;
                this.maximum = maximum;

                axis.RangeChanged += OnAxisRangeChanged;
                minimum.ValueChanged += OnValueChanged;
                maximum.ValueChanged += OnValueChanged;
            }

            private void OnAxisRangeChanged(object sender, EventArgs e)
            {
                if (updating)
                    return;

                updating = true;
                {
                    Range<double> range = axis.Range;
                    minimum.Value = range.Minimum;
                    maximum.Value = range.Maximum;
                }
                updating = false;
            }

            private void OnValueChanged(object sender, EventArgs e)
            {
                if (updating)
                    return;

                bool success;
                updating = true;
                try
                {
                    axis.Range = new Range<double>(minimum.Value, maximum.Value);
                    success = true;
                }
                catch (ArgumentException)
                {
                    success = false;
                }
                finally
                {
                    updating = false;
                }

                // If the range was not valid, reset the text boxes to the current axis value.
                if (!success)
                {
                    OnAxisRangeChanged(axis, EventArgs.Empty);
                }
            }
        }
    }
}
