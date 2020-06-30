Imports NationalInstruments.NetworkVariable
Imports System.ComponentModel

Public Class MainForm
    Private reader As NetworkVariableReader(Of Double())
    Private Const NetworkVariableLocation As String = "\\localhost\system\doublearray"

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm())
    End Sub

    Private Sub CreateReader()
        reader = New NetworkVariableReader(Of Double())(NetworkVariableLocation)
        AddHandler reader.PropertyChanged, AddressOf OnPropertyChanged
    End Sub

    Private Sub OnPropertyChanged(ByVal sender As System.Object, ByVal e As PropertyChangedEventArgs)
        If (e.PropertyName = "ConnectionStatus") Then
            statusTextBox.Text = reader.ConnectionStatus.ToString()
            readButton.Enabled = (reader.ConnectionStatus = ConnectionStatus.Connected)
        End If
    End Sub

    Private Sub connectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connectButton.Click
        connectButton.Enabled = False
        disconnectButton.Enabled = True
        If (reader Is Nothing) Then
            CreateReader()
        End If

        reader.Connect()
    End Sub

    Private Sub disconnectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disconnectButton.Click
        statusTextBox.Text = "Disconnected"

        disconnectButton.Enabled = False
        connectButton.Enabled = True
        readButton.Enabled = False
        reader.Disconnect()
        reader = Nothing
    End Sub

    Private Sub readButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles readButton.Click

        Dim data As NetworkVariableData(Of Double()) = Nothing
        Try
            data = reader.ReadData()
        Catch ex As TimeoutException
            MessageBox.Show("The read has timed out.", "Timeout")
            Return
        End Try

        If (Data.HasValue) Then
            displayWaveformGraph.PlotYAppend(Data.GetValue())
        End If

    End Sub
End Class
