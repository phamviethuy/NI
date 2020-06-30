using System.Windows;

namespace NationalInstruments.Examples.DigitalGraph
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Populate the graph with example data.
            string[] data = new[] { "0X01000X1Z1Z101101", "0X01010X1Z0Z111010" };
            var waveform = new DigitalWaveform(data[0].Length, data.Length);
            for (int signalIndex = 0; signalIndex < waveform.Signals.Count; ++signalIndex)
            {
                var signal = waveform.Signals[signalIndex];
                for (int sampleIndex = 0; sampleIndex < waveform.Samples.Count; ++sampleIndex)
                {
                    DigitalState state;
                    DigitalStateUtility.TryGetState(data[signalIndex][sampleIndex], out state);
                    signal.States[sampleIndex] = state;
                }
            }

            digitalGraph.DataSource = waveform;
        }
    }
}
