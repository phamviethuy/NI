/*******************************************************************************
*
* Example program:
*   AnalogDataFileProcessor
*
* Category:
*   File I/O
*
* Description:
*   This example demonstrates how to easily write DAQmx-acquired data to files 
*   and how to read the files back into an application and display the data on 
*   a graph. Use the Configure menu to configure either a real DAQmx voltage 
*   acquisition or a simulated acquisition. Use the Acquire menu to acquire 
*   DAQmx data or to generate simulated data. Use the File>>Save All menu item 
*   to save the entire data set. Move the cursors and use the 
*   File>>Save Selection menu item to save the data between the cursors. Use the
*   File>>Open menu item to open a file that you previously saved and plot the 
*   data it contains on the graph.
*
* Instructions for running:
*   1.  If you have a data acquisition device with an analog input channel, 
*       select Configure>>DAQmx Acquisition
*       1.  Select the physical channel which correspond to where your signal
*           is input on the DAQ device.
*       2.  Enter the minimum and maximum voltage ranges for the physical 
*           channels.
*       3.  Set the number of samples to acquire per channel.
*       4.  Set the rate of the acquisition, in Hertz.
*       5.  Select OK to save your settings.
*       6.  Select Acquire>>DAQmx Data.
*   2.  If you do not have a data acquisition device, select 
*       Configure>>Simulated Acquisition.
*       1.  Select a signal type to simulate.
*       2.  Specify characteristics of the signal to simulate.
*       3.  Select OK to save your settings.
*       4.  Select Acquire>>Simulated Data.
*   3.  Select File>>Save All to save all the data to a file.
*   4.  Manipulate the cursors and select File>>Save Selection to save the
*       subset of the data between the cursors.
*   5.  Select File>>Open to open and view saved data files.
*
* I/O Connections Overview:
*   Make sure your signal input terminals match the Physical Channel I/O
*   Controls.  If you have a PXI chassis, ensure that it has been properly
*   identified in MAX.  
*
*******************************************************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.DAQmx;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.AnalogDataFileProcessor
{
    /// <summary>
    /// The application main user interface form.
    /// </summary>
    public class MainForm : System.Windows.Forms.Form
    {
        private Task daqmxAnalogInputTask;
        private ConfigureDAQmxAcquisitionForm analogConfigureDAQmxAcquisitionForm;
        private BasicFunctionGenerator simulatedDataGenerator;
        private ConfigureSimulatedAcqForm analogConfigureSimulatedAcqForm;
        private ResourceManager resourceManager;
        private AnalogDataRecord activeDataRecord;
        private bool activeDataRecordSaved = true;

        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem mainMenuFileItem;
        private System.Windows.Forms.MenuItem fileMenuOpenItem;
        private System.Windows.Forms.MenuItem fileMenuSaveAllItem;
        private System.Windows.Forms.MenuItem fileMenuSaveSelectionItem;
        private System.Windows.Forms.MenuItem fileMenuExitItem;
        private System.Windows.Forms.MenuItem menuItem6;
        private System.Windows.Forms.MenuItem menuItem7;
        private System.Windows.Forms.MenuItem mainMenuAcquisitionItem;
        private System.Windows.Forms.MenuItem configureMenuDAQmxItem;
        private System.Windows.Forms.MenuItem configureMenuSimulatedItem;
        private System.Windows.Forms.MenuItem mainMenuAcquireItem;
        private System.Windows.Forms.MenuItem acquireMenuDAQmxItem;
        private System.Windows.Forms.MenuItem acquireMenuSimulationItem;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XYCursor dataCursor1;
        private NationalInstruments.UI.XYCursor dataCursor2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private NationalInstruments.UI.WindowsForms.WaveformGraph analogDataWaveformGraph;
        private IContainer components;

        public MainForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            resourceManager = new ResourceManager(this.GetType());

            analogConfigureDAQmxAcquisitionForm = new ConfigureDAQmxAcquisitionForm();
            
            simulatedDataGenerator = new BasicFunctionGenerator();
            analogConfigureSimulatedAcqForm = new ConfigureSimulatedAcqForm(simulatedDataGenerator);
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
                if (daqmxAnalogInputTask != null)
                {
                    daqmxAnalogInputTask.Dispose();
                }
                if (analogConfigureDAQmxAcquisitionForm != null)
                {
                    analogConfigureDAQmxAcquisitionForm.Dispose();
                }
                if (analogConfigureSimulatedAcqForm != null)
                {
                    analogConfigureSimulatedAcqForm.Dispose();
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
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.mainMenuFileItem = new System.Windows.Forms.MenuItem();
            this.fileMenuOpenItem = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.fileMenuSaveAllItem = new System.Windows.Forms.MenuItem();
            this.fileMenuSaveSelectionItem = new System.Windows.Forms.MenuItem();
            this.menuItem6 = new System.Windows.Forms.MenuItem();
            this.fileMenuExitItem = new System.Windows.Forms.MenuItem();
            this.mainMenuAcquisitionItem = new System.Windows.Forms.MenuItem();
            this.configureMenuDAQmxItem = new System.Windows.Forms.MenuItem();
            this.configureMenuSimulatedItem = new System.Windows.Forms.MenuItem();
            this.mainMenuAcquireItem = new System.Windows.Forms.MenuItem();
            this.acquireMenuDAQmxItem = new System.Windows.Forms.MenuItem();
            this.acquireMenuSimulationItem = new System.Windows.Forms.MenuItem();
            this.analogDataWaveformGraph = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.dataCursor1 = new NationalInstruments.UI.XYCursor();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.dataCursor2 = new NationalInstruments.UI.XYCursor();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.analogDataWaveformGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor2)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mainMenuFileItem,
            this.mainMenuAcquisitionItem,
            this.mainMenuAcquireItem});
            // 
            // mainMenuFileItem
            // 
            this.mainMenuFileItem.Index = 0;
            this.mainMenuFileItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuOpenItem,
            this.menuItem7,
            this.fileMenuSaveAllItem,
            this.fileMenuSaveSelectionItem,
            this.menuItem6,
            this.fileMenuExitItem});
            this.mainMenuFileItem.Text = "&File";
            // 
            // fileMenuOpenItem
            // 
            this.fileMenuOpenItem.Index = 0;
            this.fileMenuOpenItem.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.fileMenuOpenItem.Text = "&Open";
            this.fileMenuOpenItem.Click += new System.EventHandler(this.fileMenuOpenItem_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 1;
            this.menuItem7.Text = "-";
            // 
            // fileMenuSaveAllItem
            // 
            this.fileMenuSaveAllItem.Index = 2;
            this.fileMenuSaveAllItem.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.fileMenuSaveAllItem.Text = "Save &All";
            this.fileMenuSaveAllItem.Click += new System.EventHandler(this.fileMenuSaveAllItem_Click);
            // 
            // fileMenuSaveSelectionItem
            // 
            this.fileMenuSaveSelectionItem.Index = 3;
            this.fileMenuSaveSelectionItem.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.fileMenuSaveSelectionItem.Text = "&Save Selection";
            this.fileMenuSaveSelectionItem.Click += new System.EventHandler(this.fileMenuSaveSelectionItem_Click);
            // 
            // menuItem6
            // 
            this.menuItem6.Index = 4;
            this.menuItem6.Text = "-";
            // 
            // fileMenuExitItem
            // 
            this.fileMenuExitItem.Index = 5;
            this.fileMenuExitItem.Shortcut = System.Windows.Forms.Shortcut.AltF4;
            this.fileMenuExitItem.Text = "E&xit";
            this.fileMenuExitItem.Click += new System.EventHandler(this.fileMenuExitItem_Click);
            // 
            // mainMenuAcquisitionItem
            // 
            this.mainMenuAcquisitionItem.Index = 1;
            this.mainMenuAcquisitionItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.configureMenuDAQmxItem,
            this.configureMenuSimulatedItem});
            this.mainMenuAcquisitionItem.Text = "&Configure";
            // 
            // configureMenuDAQmxItem
            // 
            this.configureMenuDAQmxItem.Index = 0;
            this.configureMenuDAQmxItem.Text = "&DAQmx Acquistion";
            this.configureMenuDAQmxItem.Click += new System.EventHandler(this.configureMenuDAQmxItem_Click);
            // 
            // configureMenuSimulatedItem
            // 
            this.configureMenuSimulatedItem.Index = 1;
            this.configureMenuSimulatedItem.Text = "&Simulated Acquisition";
            this.configureMenuSimulatedItem.Click += new System.EventHandler(this.configureMenuSimulatedItem_Click);
            // 
            // mainMenuAcquireItem
            // 
            this.mainMenuAcquireItem.Index = 2;
            this.mainMenuAcquireItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.acquireMenuDAQmxItem,
            this.acquireMenuSimulationItem});
            this.mainMenuAcquireItem.Text = "&Acquire";
            // 
            // acquireMenuDAQmxItem
            // 
            this.acquireMenuDAQmxItem.Index = 0;
            this.acquireMenuDAQmxItem.Text = "&DAQmx Data";
            this.acquireMenuDAQmxItem.Click += new System.EventHandler(this.acquireMenuDAQmxItem_Click);
            // 
            // acquireMenuSimulationItem
            // 
            this.acquireMenuSimulationItem.Index = 1;
            this.acquireMenuSimulationItem.Text = "&Simulated Data";
            this.acquireMenuSimulationItem.Click += new System.EventHandler(this.acquireMenuSimulationItem_Click);
            // 
            // analogDataWaveformGraph
            // 
            this.analogDataWaveformGraph.Cursors.AddRange(new NationalInstruments.UI.XYCursor[] {
            this.dataCursor1,
            this.dataCursor2});
            this.analogDataWaveformGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.analogDataWaveformGraph.Location = new System.Drawing.Point(0, 0);
            this.analogDataWaveformGraph.Name = "analogDataWaveformGraph";
            this.analogDataWaveformGraph.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.analogDataWaveformGraph.Size = new System.Drawing.Size(520, 345);
            this.analogDataWaveformGraph.TabIndex = 0;
            this.analogDataWaveformGraph.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.analogDataWaveformGraph.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // dataCursor1
            // 
            this.dataCursor1.HorizontalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None;
            this.dataCursor1.LabelVisible = true;
            this.dataCursor1.Plot = this.waveformPlot1;
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // xAxis1
            // 
            this.xAxis1.MajorDivisions.LabelFormat = new NationalInstruments.UI.FormatString(NationalInstruments.UI.FormatStringMode.DateTime, "mm:ss.fff");
            // 
            // dataCursor2
            // 
            this.dataCursor2.HorizontalCrosshairMode = NationalInstruments.UI.CursorCrosshairMode.None;
            this.dataCursor2.LabelVisible = true;
            this.dataCursor2.Plot = this.waveformPlot1;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "adf";
            this.saveFileDialog.Filter = "Analog Data files (*.adf) |*.adf";
            this.saveFileDialog.Title = "Save DAQmx Analog Data File";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "adf";
            this.openFileDialog.Filter = "Analog Data files (*.adf) |*.adf";
            this.openFileDialog.Title = "Open DAQmx Analog Data File";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(520, 345);
            this.Controls.Add(this.analogDataWaveformGraph);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "DAQmx Analog Data File Processor";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.analogDataWaveformGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCursor2)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.EnableVisualStyles();
            Application.DoEvents();
            Application.Run(new MainForm());
        }

        private void fileMenuOpenItem_Click(object sender, System.EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                AnalogDataRecord record;
                if (ReadRecordFromFile(openFileDialog.FileName, out record))
                {
                    activeDataRecord = record;
                    PlotActiveDataRecord();
                }
            }
        }

        private void fileMenuSaveAllItem_Click(object sender, System.EventArgs e)
        {
            string fileName;
            if (PromptForSaveFileName(out fileName))
            {
                WriteRecordToFile(fileName, activeDataRecord);
            }
        }

        private void fileMenuSaveSelectionItem_Click(object sender, System.EventArgs e)
        {
            string fileName;
            if (PromptForSaveFileName(out fileName))
            {
                long startIndex = Math.Min(dataCursor1.GetCurrentIndex(), dataCursor2.GetCurrentIndex());
                long endIndex = Math.Max(dataCursor1.GetCurrentIndex(), dataCursor2.GetCurrentIndex());
                long numberOfSamples = endIndex - startIndex + 1;

                double[] data = new double[numberOfSamples];
                Array.Copy(activeDataRecord.GetData(), startIndex, data, 0, numberOfSamples);

                //
                // DataConverter.Convert converts the graph's double representation
                // of the time to a DateTime representation of the time. 
                //
                double firstXPosition = Math.Min(dataCursor1.XPosition, dataCursor2.XPosition);
                DateTime startTime = (DateTime)DataConverter.Convert(firstXPosition, typeof(DateTime));

                AnalogDataRecord dataRecord = new AnalogDataRecord(data, startTime, activeDataRecord.SampleIncrement);
                WriteRecordToFile(fileName, dataRecord);
            }
        }

        private void fileMenuExitItem_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void configureMenuDAQmxItem_Click(object sender, System.EventArgs e)
        {
            analogConfigureDAQmxAcquisitionForm.Task = daqmxAnalogInputTask;
            if (analogConfigureDAQmxAcquisitionForm.ShowDialog() == DialogResult.OK)
            {
                daqmxAnalogInputTask = analogConfigureDAQmxAcquisitionForm.Task;
            }
        }

        private void configureMenuSimulatedItem_Click(object sender, System.EventArgs e)
        {
            analogConfigureSimulatedAcqForm.ShowDialog();        
        }

        private void acquireMenuDAQmxItem_Click(object sender, System.EventArgs e)
        {
            if (daqmxAnalogInputTask == null)
            {
                MessageBox.Show("You must configure the DAQmx Acquistion before you can acquire data.", "Error");
                return;
            }
            else
            {
                //
                // Update the reference to the task because the configuration dialog box
                // might have created a new one.
                //
                daqmxAnalogInputTask = analogConfigureDAQmxAcquisitionForm.Task;                
            }
            try
            {
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor; 

                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(daqmxAnalogInputTask.Stream);
                activeDataRecord = new AnalogDataRecord(reader.ReadMultiSample(-1), DateTime.Now, TimeSpan.FromSeconds(1.0 / daqmxAnalogInputTask.Timing.SampleClockRate));
                activeDataRecordSaved = false;
                PlotActiveDataRecord();
            }
            catch (DaqException exception)
            {
                MessageBox.Show(exception.Message, "Error");
            }
        }

        private void acquireMenuSimulationItem_Click(object sender, System.EventArgs e)
        {
            //
            // The timespan between samples is the inverse of the sampling rate.
            //
            activeDataRecord = new AnalogDataRecord(simulatedDataGenerator.Generate(), DateTime.Now, TimeSpan.FromMinutes(1.0 / simulatedDataGenerator.SamplingRate));
            activeDataRecordSaved = false;
            PlotActiveDataRecord();
        }

        private void PlotActiveDataRecord()
        {
            analogDataWaveformGraph.PlotY(activeDataRecord.GetData(), activeDataRecord.StartTime, activeDataRecord.SampleIncrement);
            dataCursor1.MoveCursor(0);
            dataCursor2.MoveCursor(activeDataRecord.GetData().GetLength(0) - 1);
        }

        private void WriteRecordToFile(string filePath, AnalogDataRecord dataRecord)
        {
            using (FileStream fileStream = File.OpenWrite(filePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, dataRecord);
                fileStream.Close();
                activeDataRecordSaved = true;
            }
        }

        private bool ReadRecordFromFile(string filePath, out AnalogDataRecord dataRecord)
        {
            dataRecord = null;
            using (FileStream fileStream = File.OpenRead(filePath))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    dataRecord = (AnalogDataRecord)formatter.Deserialize(fileStream);
                }
                catch (SerializationException exception)
                {
                    MessageBox.Show(exception.Message, "Error Reading File");
                    return false;
                }
            }
            return true;
        }

        private bool PromptForSaveFileName(out string fileName)
        {
            fileName = null;
            if (analogDataWaveformGraph.Plots[0].HistoryCount == 0)
            {
                MessageBox.Show("No data to save. Acquire data or open a data file.", "Error");
                return false;
            }
            else if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                return true;
            }
            return false;
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!activeDataRecordSaved)
            {
                e.Cancel = (MessageBox.Show("You are quitting without saving your data. Continue?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No);
            }
        }
    }
}
