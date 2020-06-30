Imports System
Imports System.IO
Imports System.Windows.Forms
Imports NationalInstruments.UI
Imports NationalInstruments.Tdms

Public Class TdmsReaderUserControl

    Dim tdmsFile As TdmsFile
    Dim dataIndex As Integer
    Dim selectedNode As TreeNode = Nothing
    Dim MaxValuesToLoad As Integer = 1000
    Dim dataChanged As Boolean = False

    Public Sub New()
        InitializeComponent()
        AddHandler tdmsFileTreeView.NodeMouseClick, AddressOf OnTreeViewNodeClicked
    End Sub

    Public Sub LoadFile(ByVal path As String)
        tdmsFileTreeView.Nodes.Clear()
        tdmsPropertiesDataGridView.Rows.Clear()
        tdmsDataGridView.Rows.Clear()
        tdmsWaveformGraph.ClearData()
        tdmsDigitalWaveformGraph.ClearData()
        dataChanged = False

        If Not tdmsFile Is Nothing Then
            tdmsFile.Close()
        End If

        tdmsFile = New TdmsFile(path, New TdmsFileOptions(TdmsFileFormat.Version20, TdmsFileAccess.Read))

        Dim fileName As String = tdmsFile.Name
        If fileName = String.Empty Then
            Dim fullPath As String = tdmsFile.Path
            Dim fileInfo As FileInfo = New FileInfo(fullPath)
            fileName = fileInfo.Name
        End If

        Dim tdmsFileNode As TreeNode = tdmsFileTreeView.Nodes.Add(fileName)
        tdmsFileNode.Tag = tdmsFile

        Dim channelGroupIndex As Integer = 1
        Dim tdmsChannelGroups As TdmsChannelGroupCollection = tdmsFile.GetChannelGroups()
        For Each tdmsChannelGroup As TdmsChannelGroup In tdmsChannelGroups
            Dim channelGroupName As String = tdmsChannelGroup.Name
            If channelGroupName = String.Empty Then
                channelGroupName = String.Format("Group {0}", channelGroupIndex.ToString())
            End If
            channelGroupIndex = channelGroupIndex + 1

            Dim tdmsChannelGroupNode As TreeNode = tdmsFileNode.Nodes.Add(channelGroupName)
            tdmsChannelGroupNode.Tag = tdmsChannelGroup

            Dim channelIndex As Integer = 1
            Dim tdmsChannels As TdmsChannelCollection = tdmsChannelGroup.GetChannels()
            For Each tdmsChannel As TdmsChannel In tdmsChannels
                Dim channelName As String = tdmsChannel.Name
                If channelName = String.Empty Then
                    Dim channelProperties As TdmsPropertyCollection = tdmsChannel.GetProperties()
                    Dim channelNameProperty As TdmsProperty = channelProperties("NI_ChannelName")
                    If Not channelNameProperty Is Nothing Then
                        channelName = channelNameProperty.GetValue().ToString()
                    Else
                        channelName = String.Format("Channel {0}", channelIndex.ToString())
                    End If
                End If
                channelIndex = channelIndex + 1
                Dim tdmsChannelNode As TreeNode = tdmsChannelGroupNode.Nodes.Add(channelName)
                tdmsChannelNode.Tag = tdmsChannel
            Next
        Next

        tdmsFileTreeView.ExpandAll()
    End Sub

    Private Sub OnTreeViewNodeClicked(ByVal sender As Object, ByVal e As TreeNodeMouseClickEventArgs)
        selectedNode = e.Node
        loadValuesButton.Enabled = False
        dataIndex = 0
        tdmsPropertiesDataGridView.Rows.Clear()
        tdmsDataGridView.Rows.Clear()

        If Not e.Node.Tag Is Nothing Then
            Try
                If TypeOf e.Node.Tag Is TdmsFile Then
                    Dim file As TdmsFile = CType(e.Node.Tag, TdmsFile)
                    Dim fileProperties As TdmsPropertyCollection = file.GetProperties()
                    For Each fileProperty As TdmsProperty In fileProperties
                        tdmsPropertiesDataGridView.Rows.Add(fileProperty.Name, fileProperty.GetValue())
                    Next
                ElseIf TypeOf e.Node.Tag Is TdmsChannelGroup Then
                    Dim channelGroup As TdmsChannelGroup = CType(e.Node.Tag, TdmsChannelGroup)
                    Dim channelGroupProperties As TdmsPropertyCollection = channelGroup.GetProperties()
                    For Each channelGroupProperty As TdmsProperty In channelGroupProperties
                        tdmsPropertiesDataGridView.Rows.Add(channelGroupProperty.Name, channelGroupProperty.GetValue())
                    Next
                ElseIf TypeOf e.Node.Tag Is TdmsChannel Then
                    Dim channel As TdmsChannel = CType(e.Node.Tag, TdmsChannel)
                    Dim channelProperties As TdmsPropertyCollection = channel.GetProperties()
                    For Each channelProperty As TdmsProperty In channelProperties
                        tdmsPropertiesDataGridView.Rows.Add(channelProperty.Name, channelProperty.GetValue())
                    Next

                    Dim count As Integer = MaxValuesToLoad
                    If channel.DataCount - dataIndex <= MaxValuesToLoad Then
                        count = channel.DataCount - dataIndex
                    Else
                        loadValuesButton.Enabled = True
                    End If
                    Dim data() As Object = channel.GetData(dataIndex, count)
                    If Not data Is Nothing Then
                        For i As Integer = 0 To data.Length - 1
                            tdmsDataGridView.Rows.Add(dataIndex + i, data(i))
                        Next i
                    End If

                    dataIndex += count
                End If

                dataChanged = True
                UpdateGraph()
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
        End If

        CleanUpDataGridRows()
    End Sub


    Private Sub GraphChannelData(ByVal count As Integer)
        If dataChanged = False Then
            Return
        End If

        tdmsWaveformGraph.ClearData()
        tdmsDigitalWaveformGraph.ClearData()

        Dim channel As TdmsChannel
        If TypeOf selectedNode.Tag Is TdmsChannel Then
            channel = CType(selectedNode.Tag, TdmsChannel)
        Else
            Return
        End If

        Dim dataType As TdmsDataType = channel.TdmsDataType
        Dim channelProperties As TdmsPropertyCollection = channel.GetProperties()

        If channelProperties.Contains("wf_samples") Then
            If channelProperties.Contains("NI_DigitalCompression") Or channelProperties.Contains("NI_DigitalLine") Then
                tdmsDigitalWaveformGraph.BringToFront()

                Dim channels As TdmsChannelCollection = channel.Parent.GetChannels()
                Dim firstChannel As TdmsChannel = channels(0)
                Dim waveform As DigitalWaveform = channel.Parent.GetDigitalWaveform(firstChannel)
                tdmsDigitalWaveformGraph.PlotWaveform(waveform)
            Else
                tdmsWaveformGraph.BringToFront()

                If dataType = TdmsDataType.Int8 Then
                    Dim waveform As AnalogWaveform(Of SByte) = channel.Parent.GetAnalogWaveform(Of SByte)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.UInt8 Then
                    Dim waveform As AnalogWaveform(Of Byte) = channel.Parent.GetAnalogWaveform(Of Byte)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.Int16 Then
                    Dim waveform As AnalogWaveform(Of Short) = channel.Parent.GetAnalogWaveform(Of Short)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.UInt16 Then
                    Dim waveform As AnalogWaveform(Of UShort) = channel.Parent.GetAnalogWaveform(Of UShort)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.Int32 Then
                    Dim waveform As AnalogWaveform(Of Integer) = channel.Parent.GetAnalogWaveform(Of Integer)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.UInt32 Then
                    Dim waveform As AnalogWaveform(Of UInteger) = channel.Parent.GetAnalogWaveform(Of UInteger)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.Int64 Then
                    Dim waveform As AnalogWaveform(Of Long) = channel.Parent.GetAnalogWaveform(Of Long)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.UInt64 Then
                    Dim waveform As AnalogWaveform(Of ULong) = channel.Parent.GetAnalogWaveform(Of ULong)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.Float Then
                    Dim waveform As AnalogWaveform(Of Single) = channel.Parent.GetAnalogWaveform(Of Single)(channel)
                    PlotWaveform(waveform)
                ElseIf dataType = TdmsDataType.Double Then
                    Dim waveform As AnalogWaveform(Of Double) = channel.Parent.GetAnalogWaveform(Of Double)(channel)
                    PlotWaveform(waveform)
                End If
            End If
        Else
            If dataType <> TdmsDataType.String And dataType <> TdmsDataType.DateTime Then
                tdmsWaveformGraph.BringToFront()

                ' Since the plot history capacity is 1000, the same as the max data values to load,
                ' only plot the last 1000 data points.
                Dim dataPoints As Integer = dataIndex
                If (dataPoints > 1000) Then
                    dataPoints = 1000
                End If

                Dim data As Object() = channel.GetData(dataIndex - dataPoints, dataPoints)
                If DataConverter.CanConvert(Of Double())(data) Then
                    Dim doubleData As Double() = DataConverter.Convert(Of Double())(data)
                    tdmsXAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Numeric, "g")
                    tdmsWaveformGraph.PlotY(doubleData, dataIndex - dataPoints, 1)
                End If
            End If
        End If
    End Sub

    Private Sub PlotWaveform(Of TData)(ByVal waveform As AnalogWaveform(Of TData))
        If waveform.Timing.SampleIntervalMode = WaveformSampleIntervalMode.None Then
            tdmsXAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.Numeric, "g")
            Dim options As AnalogWaveformPlotOptions = New AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Samples, AnalogWaveformPlotScaleMode.Raw)
            tdmsWaveformGraph.PlotWaveform(waveform, options)
        Else
            tdmsXAxis.MajorDivisions.LabelFormat = New FormatString(FormatStringMode.DateTime, "g")
            Dim options As AnalogWaveformPlotOptions = New AnalogWaveformPlotOptions(AnalogWaveformPlotDisplayMode.Time, AnalogWaveformPlotScaleMode.Raw, AnalogWaveformPlotTimingMode.Auto)
            tdmsWaveformGraph.PlotWaveform(waveform, options)
        End If
    End Sub

    Private Sub CleanUpDataGridRows()
        For Each row As DataGridViewRow In tdmsPropertiesDataGridView.Rows
            row.ReadOnly = True
            row.Resizable = DataGridViewTriState.False
        Next

        For Each row As DataGridViewRow In tdmsDataGridView.Rows
            row.ReadOnly = True
            row.Resizable = DataGridViewTriState.False
        Next
    End Sub

    Private Sub OnLoadValuesButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loadValuesButton.Click
        If Not selectedNode Is Nothing And Not selectedNode.Tag Is Nothing Then
            If TypeOf selectedNode.Tag Is TdmsChannel Then
                Dim channel As TdmsChannel = CType(selectedNode.Tag, TdmsChannel)
                Dim count As Integer = MaxValuesToLoad
                If channel.DataCount - dataIndex <= MaxValuesToLoad Then
                    count = channel.DataCount - dataIndex
                    loadValuesButton.Enabled = False
                Else
                    loadValuesButton.Enabled = True
                End If
                Dim data() As Object = channel.GetData(dataIndex, count)
                If Not data Is Nothing Then
                    For i As Integer = 0 To data.Length - 1
                        tdmsDataGridView.Rows.Add(dataIndex + i, data(i))
                    Next i
                End If

                dataIndex += count
                dataChanged = True

                UpdateGraph()
            End If
        End If
    End Sub

    Private Sub OnDataTabControlSelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdmsDataTabControl.SelectedIndexChanged
        Try
            UpdateGraph()
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub UpdateGraph()
        If tdmsDataTabControl.SelectedTab Is tdmsGraphTabPage Then
            GraphChannelData(tdmsDataGridView.Rows.Count - 1)
            dataChanged = False
        End If
    End Sub
End Class
