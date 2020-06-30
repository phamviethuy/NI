using System;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.Streaming
{
    public class SineSignal
    {
        //==========================================================================================        
        // This is a helper class that is used to generate the data and timing information to create
        // an analog waveform. The data this generates is a sine wave.
        //==========================================================================================        

        private int numberOfSamples = 1000;
        private WaveformSampleIntervalMode sampleIntervalMode = WaveformSampleIntervalMode.None;
        private double frequency = 3.0;
        private double amplitude = 10.0;
        private DateTime baseTime = DateTime.Now;

        public SineSignal()
        {
        }

        public void Configure(int noOfSamples, WaveformSampleIntervalMode intervalMode, double freq, double amp)
        {
            numberOfSamples = noOfSamples;
            sampleIntervalMode = intervalMode;
            frequency = freq;
            amplitude = amp;
        }

        public double[] GenerateData()
        {
            double[] data = new double[numberOfSamples];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = amplitude * (Math.Sin(2 * i * Math.PI * frequency / numberOfSamples));
            }
            return data;
        }

        public WaveformTiming GenerateTiming()
        {
            WaveformTiming timing;
            if (sampleIntervalMode == WaveformSampleIntervalMode.None)
                timing = WaveformTiming.CreateWithNoInterval(baseTime);
            else if (sampleIntervalMode == WaveformSampleIntervalMode.Regular)
            {
                timing = WaveformTiming.CreateWithRegularInterval(new TimeSpan(0, 0, 1), baseTime);
                baseTime += new TimeSpan(0, 0, numberOfSamples);
            }
            else
            {
                DateTime[] times = new DateTime[numberOfSamples];
                times[0] = baseTime;
                Random r = new Random();
                for (int j = 1; j < numberOfSamples; j++)
                    times[j] = times[j - 1] + new TimeSpan(0, 0, r.Next(10));
                baseTime = times[numberOfSamples - 1] + new TimeSpan(0, 0, r.Next(10));
                timing = WaveformTiming.CreateWithIrregularInterval(times);
            }
            return timing;
        }
    }
}
