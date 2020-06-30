using System;
using System.IO;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.Tdms;

namespace NationalInstruments.Examples.Reader
{
    public partial class TdmsReaderUserControl : UserControl
    {
        private TdmsFile tdmsFile;
        private int dataIndex;
        private TreeNode selectedNode = null;
        private const int MaxValuesToLoad = 1000;
        private bool dataChanged = false;

        public TdmsReaderUserControl()
        {
            InitializeComponent();
            tdmsFileTreeView.NodeMouseClick += new TreeNodeMouseClickEventHandler(OnTreeViewNodeClicked);
        }

        public void LoadFile(string path)
        {
            tdmsFileTreeView.Nodes.Clear();
            tdmsPropertiesDataGridView.Rows.Clear();
            tdmsDataGridView.Rows.Clear();
            tdmsWaveformGraph.ClearData();
            tdmsDigitalWaveformGraph.ClearData();
            dataChanged = false;

            if (tdmsFile != null)
                tdmsFile.Close();

            tdmsFile = new TdmsFile(path, new TdmsFileOptions(TdmsFileFormat.Version20, TdmsFileAccess.Read));

            string fileName = tdmsFile.Name;
            if (fileName == String.Empty)
            {
                string fullPath = tdmsFile.Path;
                FileInfo fileInfo = new FileInfo(fullPath);
                fileName = fileInfo.Name;
            }
            TreeNode tdmsFileNode = tdmsFileTreeView.Nodes.Add(fileName);
            tdmsFileNode.Tag = tdmsFile;

            int channelGroupIndex = 1;
            TdmsChannelGroupCollection tdmsChannelGroups = tdmsFile.GetChannelGroups();
            foreach (TdmsChannelGroup tdmsChannelGroup in tdmsChannelGroups)
            {
                string channelGroupName = tdmsChannelGroup.Name;
                if (channelGroupName == String.Empty)
                {
                    channelGroupName = String.Format("Group {0}", channelGroupIndex.ToString());
                }
                channelGroupIndex++;
                TreeNode tdmsChannelGroupNode = tdmsFileNode.Nodes.Add(channelGroupName);
                tdmsChannelGroupNode.Tag = tdmsChannelGroup;

                int channelIndex = 1;
                TdmsChannelCollection tdmsChannels = tdmsChannelGroup.GetChannels();
                foreach (TdmsChannel tdmsChannel in tdmsChannels)
                {
                    string channelName = tdmsChannel.Name;
                    if (channelName == String.Empty)
                    {
                        TdmsPropertyCollection channelProperties = tdmsChannel.GetProperties();
                        TdmsProperty channelNameProperty = channelProperties["NI_ChannelName"];
                        if (channelNameProperty != null)
                            channelName = channelNameProperty.GetValue().ToString();
                        else
                            channelName = String.Format("Channel {0}", channelIndex.ToString());
                    }
                    channelIndex++;
                    TreeNode tdmsChannelNode = tdmsChannelGroupNode.Nodes.Add(channelName);
                    tdmsChannelNode.Tag = tdmsChannel;
                }
            }

            tdmsFileTreeView.ExpandAll();
        }

        private void OnTreeViewNodeClicked(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectedNode = e.Node;
            loadValuesButton.Enabled = false;
            dataIndex = 0;
            tdmsPropertiesDataGridView.Rows.Clear();
            tdmsDataGridView.Rows.Clear();

            if (e.Node.Tag != null)
            {
                try
                {
                    if (e.Node.Tag is TdmsFile)
                    {
                        TdmsFile file = e.Node.Tag as TdmsFile;
                        TdmsPropertyCollection fileProperties = file.GetProperties();
                        foreach (TdmsProperty fileProperty in fileProperties)
                        {
                            tdmsPropertiesDataGridView.Rows.Add(fileProperty.Name, fileProperty.GetValue());
                        }
                    }
                    else if (e.Node.Tag is TdmsChannelGroup)
                    {
                        TdmsChannelGroup channelGroup = e.Node.Tag as TdmsChannelGroup;
                        TdmsPropertyCollection channelGroupProperties = channelGroup.GetProperties();
                        foreach (TdmsProperty channelGroupProperty in channelGroupProperties)
                        {
                            tdmsPropertiesDataGridView.Rows.Add(channelGroupProperty.Name, channelGroupProperty.GetValue());
                        }
                    }
                    else if (e.Node.Tag is TdmsChannel)
                    {
                        TdmsChannel channel = e.Node.Tag as TdmsChannel;
                        TdmsPropertyCollection channelProperties = channel.GetProperties();
                        foreach (TdmsProperty channelProperty in channelProperties)
                        {
                            tdmsPropertiesDataGridView.Rows.Add(channelProperty.Name, channelProperty.GetValue());
                        }

                        int count = MaxValuesToLoad;
                        if (channel.DataCount - dataIndex <= MaxValuesToLoad)
                        {
                            count = (int)channel.DataCount - dataIndex;
                        }
                        else
                        {
                            loadValuesButton.Enabled = true;
                        }
                        object[] data = channel.GetData(dataIndex, count);
                        if (data != null)
                        {
                            for (int i = 0; i < data.Length; i++)
                            {
                                tdmsDataGridView.Rows.Add(dataIndex + i, data[i]);
                            }
                        }

                        dataIndex += count;
                    }

                    dataChanged = true;
                    UpdateGraph();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(String.Format("Error: {0}", ex.Message));
                }
            }

            CleanUpDataGridRows();
        }

        private void GraphChannelData(int count)
        {
            if (!dataChanged)
                return;

            tdmsWaveformGraph.ClearData();
            tdmsDigitalWaveformGraph.ClearData();

            TdmsChannel channel = selectedNode.Tag as TdmsChannel;
            if (channel == null)
                return;

            TdmsDataType dataType = channel.TdmsDataType;
            TdmsPropertyCollection channelProperties = channel.GetProperties();
            if (channelProperties.Contains("wf_samples"))
            {
                if (channelProperties.Contains("NI_DigitalCompression") ||
                    channelProperties.Contains("NI_DigitalLine"))
                {
                    tdmsDigitalWaveformGraph.BringToFront();

                    TdmsChannelCollection channels = channel.Parent.GetChannels();
                    TdmsChannel firstChannel = channels[0];
                    DigitalWaveform waveform = channel.Parent.GetDigitalWaveform(firstChannel);
                    tdmsDigitalWaveformGraph.PlotWaveform(waveform);
                }
                else
                {
                    tdmsWaveformGraph.BringToFront();

                    switch (dataType)
                    {
                        case TdmsDataType.Int8:
                            AnalogWaveform<sbyte> sbyteWaveform = channel.Parent.GetAnalogWaveform<sbyte>(channel);
                            PlotWaveform<sbyte>(sbyteWaveform);
                            break;
                        case TdmsDataType.UInt8:
                            AnalogWaveform<byte> byteWaveform = channel.Parent.GetAnalogWaveform<byte>(channel);
                            PlotWaveform<byte>(byteWaveform);
                            break;
                        case TdmsDataType.Int16:
                            AnalogWaveform<short> shortWaveform = channel.Parent.GetAnalogWaveform<short>(channel);
                            PlotWaveform<short>(shortWaveform);
                            break;
                        case TdmsDataType.UInt16:
                            AnalogWaveform<ushort> ushortWaveform = channel.Parent.GetAnalogWaveform<ushort>(channel);
                            PlotWaveform<ushort>(ushortWaveform);
                            break;
                        case TdmsDataType.Int32:
                            AnalogWaveform<int> intWaveform = channel.Parent.GetAnalogWaveform<int>(channel);
                            PlotWaveform<int>(intWaveform);
                            break;
                        case TdmsDataType.UInt32:
                            AnalogWaveform<uint> uintWaveform = channel.Parent.GetAnalogWaveform<uint>(channel);
                            PlotWaveform<uint>(uintWaveform);
                            break;
                        case TdmsDataType.Int64:
                            AnalogWaveform<long> longWaveform = channel.Parent.GetAnalogWaveform<long>(channel);
                            PlotWaveform<long>(longWaveform);
                            break;
                        case TdmsDataType.UInt64:
                            AnalogWaveform<ulong> ulongWaveform = channel.Parent.GetAnalogWaveform<ulong>(channel);
                            PlotWaveform<ulong>(ulongWaveform);
                            break;
                        case TdmsDataType.Float:
                            AnalogWaveform<float> floatWaveform = channel.Parent.GetAnalogWaveform<float>(channel);
                            PlotWaveform<float>(floatWaveform);
                            break;
                        case TdmsDataType.Double:
                            AnalogWaveform<double> doubleWaveform = channel.Parent.GetAnalogWaveform<double>(channel);
                            PlotWaveform<double>(doubleWaveform);
                            break;
                    }
                }
            }
            else
            {
                if(dataType != TdmsDataType.String && dataType != TdmsDataType.DateTime)
                {
                    tdmsWaveformGraph.BringToFront();

                    // Since the plot history capacity is 1000, the same as the max data values to load,
                    // only plot the last 1000 data points.
                    int dataPoints = dataIndex;
                    if (dataPoints > 1000)
                        dataPoints = 1000;

                    object[] data = channel.GetData(dataIndex - dataPoints, dataPoints);
                    if (DataConverter.CanConvert<double[]>(data))
                    {
                        double[] doubleData = DataConverter.Convert<double[]>(data);
                        tdmsXAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Numeric, "g");
                        tdmsWaveformGraph.PlotY(doubleData, dataIndex - dataPoints, 1);
                    }
                }
            }
        }

        private void PlotWaveform<TData>(AnalogWaveform<TData> waveform)
        {
            if (waveform.Timing.SampleIntervalMode == WaveformSampleIntervalMode.None)
            {
                tdmsXAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.Numeric, "g");
                AnalogWaveformPlotOptions options = new AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Samples, AnalogWaveformPlotScaleMode.Raw);
                tdmsWaveformGraph.PlotWaveform(waveform, options);
            }
            else
            {
                tdmsXAxis.MajorDivisions.LabelFormat = new FormatString(FormatStringMode.DateTime, "g");
                AnalogWaveformPlotOptions options = new AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw, AnalogWaveformPlotTimingMode.Auto);
                tdmsWaveformGraph.PlotWaveform(waveform, options);
            }
        }

        private void CleanUpDataGridRows()
        {
            foreach (DataGridViewRow row in tdmsPropertiesDataGridView.Rows)
            {
                row.ReadOnly = true;
                row.Resizable = DataGridViewTriState.False;
            }

            foreach (DataGridViewRow row in tdmsDataGridView.Rows)
            {
                row.ReadOnly = true;
                row.Resizable = DataGridViewTriState.False;
            }
        }

        private void OnLoadValuesButtonClicked(object sender, EventArgs e)
        {
            try
            {
                if (selectedNode != null && selectedNode.Tag != null)
                {
                    if (selectedNode.Tag is TdmsChannel)
                    {
                        TdmsChannel channel = selectedNode.Tag as TdmsChannel;

                        int count = MaxValuesToLoad;
                        if (channel.DataCount - dataIndex <= MaxValuesToLoad)
                        {
                            count = (int)channel.DataCount - dataIndex;
                            loadValuesButton.Enabled = false;
                        }
                        else
                        {
                            loadValuesButton.Enabled = true;
                        }
                        object[] data = channel.GetData(dataIndex, count);
                        if (data != null)
                        {
                            for (int i = 0; i < data.Length; i++)
                            {
                                tdmsDataGridView.Rows.Add(dataIndex + i, data[i]);
                            }
                        }

                        dataIndex += count;
                        dataChanged = true;

                        UpdateGraph();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message));
            }
        }

        private void OnDataTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateGraph();
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message));
            }
        }

        private void UpdateGraph()
        {
            if (tdmsDataTabControl.SelectedTab == tdmsGraphTabPage)
            {
                GraphChannelData(tdmsDataGridView.Rows.Count - 1);
                dataChanged = false;
            }
        }
    }
}
