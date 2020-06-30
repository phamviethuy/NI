using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.PlotComplexWaveform
{
    public partial class MainForm : Form
    {
        private const int SampleCount = 100;
        private PrecisionDateTime[] precisionTimes;
        private ComplexWaveformPlotOptions plotOptions;
        private Range phaseRange = new Range(-4, 1);
        private Range normalRange = new Range(-90, 90);

        public MainForm()
        {
            InitializeComponent();

            plotOptions = new ComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Samples, ComplexWaveformPlotScaleMode.Scaled,
                                ComplexDataPart.Magnitude);

            //Initialize the Precision Date-Time array
            precisionTimes = new PrecisionDateTime[SampleCount];
            precisionTimes[0] = new PrecisionDateTime(new DateTime(1970, 1, 1, 0, 0, 0));
            for (int i = 1; i < SampleCount; i++)
            {
                precisionTimes[i] = precisionTimes[i-1].AddMilliseconds(i);
            }
        }

        private ComplexWaveform<ComplexDouble> GenerateComplexWaveform()
        {
            int amplitude = 30;
            int frequency = 5;
            ComplexDouble[] data = new ComplexDouble[SampleCount];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i].Real = amplitude * (Math.Sin(2 * i * Math.PI * frequency / SampleCount));
                data[i].Imaginary = amplitude * (Math.Sin(2 * i * Math.PI * frequency / SampleCount));
            }
            ComplexWaveform<ComplexDouble> waveform = ComplexWaveform<ComplexDouble>.FromArray1D(data);

            waveform.ScaleMode = ComplexWaveformScaleMode.CreateLinearMode(2, 0);
            if (noIntervalRadioButton.Checked)
            {
                
                waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithNoInterval(precisionTimes[0]);
            }
            else if (regularIntervalRadioButton.Checked)
            {
                waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(waveformPlot.DefaultWaveformPrecisionTiming.SampleInterval);
            }
            else if (irregularIntervalRadioButton.Checked)
            {
                waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithIrregularInterval(precisionTimes);
            }
            return waveform;
        }

        private void SetComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode displayMode, ComplexWaveformPlotScaleMode scaleMode, ComplexDataPart dataToPlot)
        {
            plotOptions = new ComplexWaveformPlotOptions(displayMode, scaleMode, dataToPlot);
        }

        private void PlotWaveform()
        {
            sampleWaveformGraph.PlotComplexWaveform<ComplexDouble>(GenerateComplexWaveform(), plotOptions);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            scaledDataRadioButton.Checked = true;
            samplesRadioButton.Checked = true;
            irregularIntervalRadioButton.Checked = true;
            magnitudeRadioButton.Checked = true;
            historyCapacityNumericEdit.Value = waveformPlot.HistoryCapacity;
            sampleWaveformGraph.YAxes[0].Range = normalRange;

            // Plot the Waveform once the default properties are set.
            PlotWaveform();
        }

        private void historyCapacityNumeric_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
        {
            waveformPlot.HistoryCapacity = (int)historyCapacityNumericEdit.Value;
        }

        private void noIntervalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlotWaveform();
        }

        private void regularIntervalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlotWaveform();
        }

        private void irregularIntervalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            PlotWaveform();
        }

        private void rawDataRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rawDataRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetComplexWaveformPlotOptions(plotOptions.DisplayMode, ComplexWaveformPlotScaleMode.Raw, plotOptions.DataToPlot);
                PlotWaveform();
            }
        }

        private void scaledDataRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (scaledDataRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetComplexWaveformPlotOptions(plotOptions.DisplayMode, ComplexWaveformPlotScaleMode.Scaled, plotOptions.DataToPlot);
                PlotWaveform();
            }
        }

        private void samplesRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (samplesRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Numeric, "G5");
                SetComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Samples, plotOptions.ScaleMode, plotOptions.DataToPlot);
                PlotWaveform();
            }
        }

        private void timeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if (timeRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss.fff");
                SetComplexWaveformPlotOptions(ComplexWaveformPlotDisplayMode.Time, plotOptions.ScaleMode, plotOptions.DataToPlot);
                PlotWaveform();
            }
        }

        private void realRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (realRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Real);
                sampleWaveformGraph.YAxes[0].Range = normalRange;
                PlotWaveform();
            }
        }

        private void imaginaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (imaginaryRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Imaginary);
                sampleWaveformGraph.YAxes[0].Range = normalRange;
                PlotWaveform();
            }
        }

        private void phaseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (phaseRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Phase);
                sampleWaveformGraph.YAxes[0].Range = phaseRange;
                PlotWaveform();
            }
        }

        private void magnitudeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (magnitudeRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetComplexWaveformPlotOptions(plotOptions.DisplayMode, plotOptions.ScaleMode, ComplexDataPart.Magnitude);
                sampleWaveformGraph.YAxes[0].Range = normalRange;
                PlotWaveform();
            }
        }

        private void ChartWaveform()
        {
            ComplexWaveform<ComplexDouble> waveform = GenerateComplexWaveform();

            //Modify the timing information so that the waveform charted is continuous.
            PrecisionDateTime latestDateTime = new PrecisionDateTime(new DateTime(0));
            PrecisionTimeSpan defaultInterval = waveformPlot.DefaultWaveformPrecisionTiming.SampleInterval;

            if (waveformPlot.HistoryCount > 0)
            {
                latestDateTime = (PrecisionDateTime)DataConverter.Convert(waveformPlot.GetXData()[waveformPlot.HistoryCount - 1], typeof(PrecisionDateTime));
            }

            if (irregularIntervalRadioButton.Checked)
            {
                PrecisionDateTime[] localPrecisionTimes = new PrecisionDateTime[SampleCount];
                DateTime localStartTime = (DateTime)DataConverter.Convert(latestDateTime.AddMilliseconds(defaultInterval.TotalMilliseconds), typeof(DateTime));
                localPrecisionTimes[0] = new PrecisionDateTime(localStartTime);
                for (int i = 1; i < SampleCount; i++)
                {
                    localPrecisionTimes[i] = localPrecisionTimes[i - 1].AddMilliseconds(i);
                }
                waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithIrregularInterval(localPrecisionTimes);
            }
            else
            {
                waveform.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(defaultInterval, latestDateTime.AddMilliseconds(defaultInterval.TotalMilliseconds));
            }

            sampleWaveformGraph.Plots[0].DefaultComplexWaveformPlotOptions = plotOptions;
            sampleWaveformGraph.PlotComplexWaveformAppend<ComplexDouble>(waveform);
        }

        private void plotDataAppendTimer_Tick(object sender, EventArgs e)
        {
            if (chartWaveformCheckBox.Checked)
            {
                ChartWaveform();
            }
        }

        private void chartWaveformCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chartWaveformCheckBox.Checked)
            {
                plotDataAppendTimer.Enabled = true;
                ChartWaveform();
            }
            else
            {
                plotDataAppendTimer.Enabled = false;
                sampleWaveformGraph.ClearData();
                PlotWaveform();
            }
        }        
    }
}