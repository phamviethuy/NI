using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.PlotWaveforms
{
    public class MainForm : System.Windows.Forms.Form
    {
        private const int SampleCount = 100;        
        private DateTime[] times;
        private AnalogWaveformPlotOptions plotOptions;

        private System.Windows.Forms.Label historyCapacityLabel;
        private System.Windows.Forms.GroupBox plotDisplayModeGroupBox;
        private System.Windows.Forms.GroupBox plotScaleModeGroupBox;
        private System.Windows.Forms.RadioButton samplesRadioButton;
        private System.Windows.Forms.RadioButton timeRadioButton;
        private System.Windows.Forms.RadioButton rawDataRadioButton;
        private System.Windows.Forms.RadioButton scaledDataRadioButton;
        private NationalInstruments.UI.WindowsForms.NumericEdit historyCapacityNumericEdit;
        private System.Windows.Forms.Button plotWaveformButton;
        private System.Windows.Forms.Button plotWaveformAppendButton;
        private NationalInstruments.UI.WindowsForms.WaveformGraph sampleWaveformGraph;
        private WaveformPlot waveformPlot;
        private XAxis xAxis;
        private YAxis yAxis;
        private GroupBox plotWaveformGroupBox;
        private RadioButton irregularIntervalRadioButton;
        private RadioButton regularIntervalRadioButton;
        private RadioButton noIntervalRadioButton;
        private Label waveformTimingIntervalLabel;
        private GroupBox chartWaveformGroupBox;
        private ToolTip plotToolTip;
        private IContainer components;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            plotOptions = new AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Samples, 
                AnalogWaveformPlotScaleMode.Scaled);

            //Initialize the Date-Time array
            times = new DateTime[SampleCount];
            times[0] = new DateTime(1970, 1, 1, 0, 0, 0);
            for(int i = 1; i < SampleCount; i++)
            {
                times[i] = times[0].AddMilliseconds(i);
            }
        }

        
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.plotWaveformButton = new System.Windows.Forms.Button();
            this.plotWaveformAppendButton = new System.Windows.Forms.Button();
            this.historyCapacityNumericEdit = new NationalInstruments.UI.WindowsForms.NumericEdit();
            this.historyCapacityLabel = new System.Windows.Forms.Label();
            this.plotDisplayModeGroupBox = new System.Windows.Forms.GroupBox();
            this.timeRadioButton = new System.Windows.Forms.RadioButton();
            this.samplesRadioButton = new System.Windows.Forms.RadioButton();
            this.plotScaleModeGroupBox = new System.Windows.Forms.GroupBox();
            this.scaledDataRadioButton = new System.Windows.Forms.RadioButton();
            this.rawDataRadioButton = new System.Windows.Forms.RadioButton();
            this.sampleWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot = new NationalInstruments.UI.WaveformPlot();
            this.xAxis = new NationalInstruments.UI.XAxis();
            this.yAxis = new NationalInstruments.UI.YAxis();
            this.plotWaveformGroupBox = new System.Windows.Forms.GroupBox();
            this.waveformTimingIntervalLabel = new System.Windows.Forms.Label();
            this.irregularIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.regularIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.noIntervalRadioButton = new System.Windows.Forms.RadioButton();
            this.chartWaveformGroupBox = new System.Windows.Forms.GroupBox();
            this.plotToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.historyCapacityNumericEdit)).BeginInit();
            this.plotDisplayModeGroupBox.SuspendLayout();
            this.plotScaleModeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).BeginInit();
            this.plotWaveformGroupBox.SuspendLayout();
            this.chartWaveformGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotWaveformButton
            // 
            this.plotWaveformButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotWaveformButton.Location = new System.Drawing.Point(5, 19);
            this.plotWaveformButton.Name = "plotWaveformButton";
            this.plotWaveformButton.Size = new System.Drawing.Size(160, 23);
            this.plotWaveformButton.TabIndex = 0;
            this.plotWaveformButton.Text = "Plot Waveform";
            this.plotWaveformButton.Click += new System.EventHandler(this.plotWaveformButton_Click);
            // 
            // plotWaveformAppendButton
            // 
            this.plotWaveformAppendButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotWaveformAppendButton.Location = new System.Drawing.Point(5, 17);
            this.plotWaveformAppendButton.Name = "plotWaveformAppendButton";
            this.plotWaveformAppendButton.Size = new System.Drawing.Size(160, 23);
            this.plotWaveformAppendButton.TabIndex = 0;
            this.plotWaveformAppendButton.Text = "Chart Waveform";
            this.plotWaveformAppendButton.Click += new System.EventHandler(this.plotWaveformAppendButton_Click);
            // 
            // historyCapacityNumericEdit
            // 
            this.historyCapacityNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0);
            this.historyCapacityNumericEdit.Location = new System.Drawing.Point(514, 374);
            this.historyCapacityNumericEdit.Name = "historyCapacityNumericEdit";
            this.historyCapacityNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange;
            this.historyCapacityNumericEdit.Range = new NationalInstruments.UI.Range(1, 10000);
            this.historyCapacityNumericEdit.Size = new System.Drawing.Size(144, 20);
            this.historyCapacityNumericEdit.TabIndex = 11;
            this.historyCapacityNumericEdit.Value = 1000;
            this.historyCapacityNumericEdit.AfterChangeValue += new NationalInstruments.UI.AfterChangeNumericValueEventHandler(this.historyCapacityNumeric_AfterChangeValue);
            // 
            // historyCapacityLabel
            // 
            this.historyCapacityLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.historyCapacityLabel.Location = new System.Drawing.Point(511, 354);
            this.historyCapacityLabel.Name = "historyCapacityLabel";
            this.historyCapacityLabel.Size = new System.Drawing.Size(96, 16);
            this.historyCapacityLabel.TabIndex = 10;
            this.historyCapacityLabel.Text = "History Capacity:";
            // 
            // plotDisplayModeGroupBox
            // 
            this.plotDisplayModeGroupBox.Controls.Add(this.timeRadioButton);
            this.plotDisplayModeGroupBox.Controls.Add(this.samplesRadioButton);
            this.plotDisplayModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotDisplayModeGroupBox.Location = new System.Drawing.Point(515, 201);
            this.plotDisplayModeGroupBox.Name = "plotDisplayModeGroupBox";
            this.plotDisplayModeGroupBox.Size = new System.Drawing.Size(176, 72);
            this.plotDisplayModeGroupBox.TabIndex = 2;
            this.plotDisplayModeGroupBox.TabStop = false;
            this.plotDisplayModeGroupBox.Text = "Plot Display Mode";
            // 
            // timeRadioButton
            // 
            this.timeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.timeRadioButton.Location = new System.Drawing.Point(8, 40);
            this.timeRadioButton.Name = "timeRadioButton";
            this.timeRadioButton.Size = new System.Drawing.Size(104, 24);
            this.timeRadioButton.TabIndex = 1;
            this.timeRadioButton.Text = "Against Time";
            this.timeRadioButton.CheckedChanged += new System.EventHandler(this.timeRadioButton_CheckedChanged);
            // 
            // samplesRadioButton
            // 
            this.samplesRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.samplesRadioButton.Location = new System.Drawing.Point(8, 16);
            this.samplesRadioButton.Name = "samplesRadioButton";
            this.samplesRadioButton.Size = new System.Drawing.Size(104, 24);
            this.samplesRadioButton.TabIndex = 0;
            this.samplesRadioButton.Text = "As Samples";
            this.samplesRadioButton.CheckedChanged += new System.EventHandler(this.samplesRadioButton_CheckedChanged);
            // 
            // plotScaleModeGroupBox
            // 
            this.plotScaleModeGroupBox.Controls.Add(this.scaledDataRadioButton);
            this.plotScaleModeGroupBox.Controls.Add(this.rawDataRadioButton);
            this.plotScaleModeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotScaleModeGroupBox.Location = new System.Drawing.Point(515, 279);
            this.plotScaleModeGroupBox.Name = "plotScaleModeGroupBox";
            this.plotScaleModeGroupBox.Size = new System.Drawing.Size(176, 72);
            this.plotScaleModeGroupBox.TabIndex = 3;
            this.plotScaleModeGroupBox.TabStop = false;
            this.plotScaleModeGroupBox.Text = "Plot Scale Mode";
            // 
            // scaledDataRadioButton
            // 
            this.scaledDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.scaledDataRadioButton.Location = new System.Drawing.Point(8, 40);
            this.scaledDataRadioButton.Name = "scaledDataRadioButton";
            this.scaledDataRadioButton.Size = new System.Drawing.Size(104, 24);
            this.scaledDataRadioButton.TabIndex = 1;
            this.scaledDataRadioButton.Text = "Scaled Data";
            this.scaledDataRadioButton.CheckedChanged += new System.EventHandler(this.scaledDataRadioButton_CheckedChanged);
            // 
            // rawDataRadioButton
            // 
            this.rawDataRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rawDataRadioButton.Location = new System.Drawing.Point(8, 16);
            this.rawDataRadioButton.Name = "rawDataRadioButton";
            this.rawDataRadioButton.Size = new System.Drawing.Size(104, 24);
            this.rawDataRadioButton.TabIndex = 0;
            this.rawDataRadioButton.Text = "Raw Data";
            this.rawDataRadioButton.CheckedChanged += new System.EventHandler(this.rawDataRadioButton_CheckedChanged);
            // 
            // sampleWaveformGraph
            // 
            this.sampleWaveformGraph.Caption = "National Instruments 2D Waveform Graph";
            this.sampleWaveformGraph.Location = new System.Drawing.Point(12, 9);
            this.sampleWaveformGraph.Name = "sampleWaveformGraph";
            this.sampleWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot});
            this.sampleWaveformGraph.Size = new System.Drawing.Size(493, 382);
            this.sampleWaveformGraph.TabIndex = 0;
            this.sampleWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis});
            this.sampleWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis});
            // 
            // waveformPlot
            // 
            this.waveformPlot.DefaultTiming = NationalInstruments.WaveformTiming.CreateWithRegularInterval(System.TimeSpan.Parse("00:00:00.0010000"), new System.DateTime(2000, 1, 1, 0, 0, 0, 0));
            this.waveformPlot.XAxis = this.xAxis;
            this.waveformPlot.YAxis = this.yAxis;
            // 
            // yAxis
            // 
            this.yAxis.Mode = NationalInstruments.UI.AxisMode.Fixed;
            this.yAxis.Range = new NationalInstruments.UI.Range(-70, 70);
            // 
            // plotWaveformGroupBox
            // 
            this.plotWaveformGroupBox.Controls.Add(this.waveformTimingIntervalLabel);
            this.plotWaveformGroupBox.Controls.Add(this.irregularIntervalRadioButton);
            this.plotWaveformGroupBox.Controls.Add(this.plotWaveformButton);
            this.plotWaveformGroupBox.Controls.Add(this.regularIntervalRadioButton);
            this.plotWaveformGroupBox.Controls.Add(this.noIntervalRadioButton);
            this.plotWaveformGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.plotWaveformGroupBox.Location = new System.Drawing.Point(515, 9);
            this.plotWaveformGroupBox.Name = "plotWaveformGroupBox";
            this.plotWaveformGroupBox.Size = new System.Drawing.Size(176, 139);
            this.plotWaveformGroupBox.TabIndex = 12;
            this.plotWaveformGroupBox.TabStop = false;
            this.plotWaveformGroupBox.Text = "Plot Waveform";
            // 
            // waveformTimingIntervalLabel
            // 
            this.waveformTimingIntervalLabel.AutoSize = true;
            this.waveformTimingIntervalLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.waveformTimingIntervalLabel.Location = new System.Drawing.Point(5, 55);
            this.waveformTimingIntervalLabel.Name = "waveformTimingIntervalLabel";
            this.waveformTimingIntervalLabel.Size = new System.Drawing.Size(131, 13);
            this.waveformTimingIntervalLabel.TabIndex = 3;
            this.waveformTimingIntervalLabel.Text = "Waveform Timing Interval:";
            // 
            // irregularIntervalRadioButton
            // 
            this.irregularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.irregularIntervalRadioButton.Location = new System.Drawing.Point(5, 117);
            this.irregularIntervalRadioButton.Name = "irregularIntervalRadioButton";
            this.irregularIntervalRadioButton.Size = new System.Drawing.Size(107, 17);
            this.irregularIntervalRadioButton.TabIndex = 2;
            this.irregularIntervalRadioButton.TabStop = true;
            this.irregularIntervalRadioButton.Text = "Irregular Interval";
            this.plotToolTip.SetToolTip(this.irregularIntervalRadioButton, "The waveform to be plotted uses the specified DateTime array to retrieve the timi" +
                    "ng information.");
            // 
            // regularIntervalRadioButton
            // 
            this.regularIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.regularIntervalRadioButton.Location = new System.Drawing.Point(5, 94);
            this.regularIntervalRadioButton.Name = "regularIntervalRadioButton";
            this.regularIntervalRadioButton.Size = new System.Drawing.Size(107, 17);
            this.regularIntervalRadioButton.TabIndex = 1;
            this.regularIntervalRadioButton.TabStop = true;
            this.regularIntervalRadioButton.Text = "Regular Interval";
            this.plotToolTip.SetToolTip(this.regularIntervalRadioButton, "The waveform to be plotted uses a specified TimeSpan object for the sample interv" +
                    "al.\r\nThe DefaultTiming property of the plot is used to retrieve the start time.");
            // 
            // noIntervalRadioButton
            // 
            this.noIntervalRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.noIntervalRadioButton.Location = new System.Drawing.Point(5, 71);
            this.noIntervalRadioButton.Name = "noIntervalRadioButton";
            this.noIntervalRadioButton.Size = new System.Drawing.Size(77, 17);
            this.noIntervalRadioButton.TabIndex = 0;
            this.noIntervalRadioButton.TabStop = true;
            this.noIntervalRadioButton.Text = "No Interval";
            this.plotToolTip.SetToolTip(this.noIntervalRadioButton, "The waveform to be plotted uses a specified time stamp for the start time.\r\nThe D" +
                    "efaultTiming property of the plot is used to retrieve the sample interval.");
            // 
            // chartWaveformGroupBox
            // 
            this.chartWaveformGroupBox.Controls.Add(this.plotWaveformAppendButton);
            this.chartWaveformGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chartWaveformGroupBox.Location = new System.Drawing.Point(515, 149);
            this.chartWaveformGroupBox.Name = "chartWaveformGroupBox";
            this.chartWaveformGroupBox.Size = new System.Drawing.Size(176, 46);
            this.chartWaveformGroupBox.TabIndex = 13;
            this.chartWaveformGroupBox.TabStop = false;
            this.chartWaveformGroupBox.Text = "Chart Waveform";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(700, 403);
            this.Controls.Add(this.sampleWaveformGraph);
            this.Controls.Add(this.historyCapacityNumericEdit);
            this.Controls.Add(this.historyCapacityLabel);
            this.Controls.Add(this.plotScaleModeGroupBox);
            this.Controls.Add(this.plotDisplayModeGroupBox);
            this.Controls.Add(this.plotWaveformGroupBox);
            this.Controls.Add(this.chartWaveformGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Plot Waveforms Example";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.historyCapacityNumericEdit)).EndInit();
            this.plotDisplayModeGroupBox.ResumeLayout(false);
            this.plotScaleModeGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sampleWaveformGraph)).EndInit();
            this.plotWaveformGroupBox.ResumeLayout(false);
            this.plotWaveformGroupBox.PerformLayout();
            this.chartWaveformGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }

        //Generates a single AnalogWaveform object, representing a sine wave of a particular amplitude and frequency.
        //The timing information is taken from the private DateTime array, which is initialized in the constructor.
#if NETFX2_0
        private AnalogWaveform<double> GenerateAnalogWaveform()
#else
        private AnalogWaveform GenerateAnalogWaveform()
#endif
        {
            int amplitude = 30;
            int frequency = 2;
            double[] data = new double[SampleCount];
            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = amplitude * (Math.Sin(2*i*Math.PI*frequency / SampleCount));
            }
#if NETFX2_0
            AnalogWaveform<double> waveform = AnalogWaveform<double>.FromArray1D(data);
#else
            AnalogWaveform waveform = AnalogWaveform.FromArray1D(data);
#endif
            waveform.ScaleMode = WaveformScaleMode.CreateLinearMode(2, 0);
            if (noIntervalRadioButton.Checked)
            {
                waveform.Timing = WaveformTiming.CreateWithNoInterval(times[0]);
            }
            else if (regularIntervalRadioButton.Checked)
            {
                waveform.Timing = WaveformTiming.CreateWithRegularInterval(waveformPlot.DefaultTiming.SampleInterval);
            }
            else if (irregularIntervalRadioButton.Checked)
            {
                waveform.Timing = WaveformTiming.CreateWithIrregularInterval(times);
            }
            return waveform;
        }

        private void SetAnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode displayMode, AnalogWaveformPlotScaleMode scaleMode)
        {
            plotOptions = new AnalogWaveformPlotOptions(displayMode, scaleMode);
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            scaledDataRadioButton.Checked = true;
            samplesRadioButton.Checked = true;
            irregularIntervalRadioButton.Checked = true;
            historyCapacityNumericEdit.Value = waveformPlot.HistoryCapacity;
        }

        private void historyCapacityNumeric_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
        {
            waveformPlot.HistoryCapacity = (int)historyCapacityNumericEdit.Value;
        }

        private void rawDataRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if(rawDataRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetAnalogWaveformPlotOptions(plotOptions.DisplayMode, AnalogWaveformPlotScaleMode.Raw);
            }
        }

        private void scaledDataRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if(scaledDataRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                SetAnalogWaveformPlotOptions(plotOptions.DisplayMode, AnalogWaveformPlotScaleMode.Scaled);
            }
        }

        private void samplesRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if(samplesRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Numeric, "G5");
                SetAnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Samples, plotOptions.ScaleMode);
            }
        }

        private void timeRadioButton_CheckedChanged(object sender, System.EventArgs e)
        {
            if(timeRadioButton.Checked)
            {
                sampleWaveformGraph.ClearData();
                xAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "m:ss.fff");
                SetAnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, plotOptions.ScaleMode);
            }
        }

        private void plotWaveformButton_Click(object sender, System.EventArgs e)
        {
            sampleWaveformGraph.PlotWaveform(GenerateAnalogWaveform(), plotOptions);
        }

        private void plotWaveformAppendButton_Click(object sender, System.EventArgs e)
        {           
#if NETFX2_0
            AnalogWaveform<double> waveform = GenerateAnalogWaveform();
#else
            AnalogWaveform waveform = GenerateAnalogWaveform();
#endif

            //Modify the timing information so that the waveform charted is continuous.
            DateTime latestDateTime = new DateTime(0);
            TimeSpan defaultInterval = waveformPlot.DefaultTiming.SampleInterval;

            if(waveformPlot.HistoryCount > 0)
            {
                latestDateTime = (DateTime)DataConverter.Convert(waveformPlot.GetXData()[waveformPlot.HistoryCount - 1], typeof(DateTime));
            }

            waveform.Timing = WaveformTiming.CreateWithRegularInterval(defaultInterval, latestDateTime.AddMilliseconds(defaultInterval.Milliseconds));
            sampleWaveformGraph.PlotWaveformAppend(waveform);
        }
    }
}