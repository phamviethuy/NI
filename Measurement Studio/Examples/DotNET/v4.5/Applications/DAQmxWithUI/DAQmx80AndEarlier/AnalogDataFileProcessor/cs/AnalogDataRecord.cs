using System;

namespace NationalInstruments.Examples.AnalogDataFileProcessor
{
	/// <summary>
	/// Stores data written to and read from files.
	/// </summary>
	[Serializable]
	public class AnalogDataRecord
	{
        private double[] data;
        private DateTime startTime;
        private TimeSpan sampleIncrement;

		public AnalogDataRecord(double[] recordData, DateTime recordStartTime, TimeSpan recordSampleIncrement)
		{
            data = recordData;
            startTime = recordStartTime;
            sampleIncrement = recordSampleIncrement;
		}
        
        public DateTime StartTime
        {
            get 
            {
                return startTime;
            }
        }

        public TimeSpan SampleIncrement
        {
            get
            {
                return sampleIncrement;
            }
        }

        public double[] GetData()
        {
            return data;
        }
	}
}
