Imports NationalInstruments.NetworkVariable
Imports System.ComponentModel

Public Class MainForm

    Private subscriber As NetworkVariableSubscriber(Of Double())
    Private Const NetworkVariableLocation As String = "\\localhost\system\doublearray"

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm())
    End Sub

    Private Sub CreateSubscriber()
        subscriber = New NetworkVariableSubscriber(Of Double())(NetworkVariableLocation)
        AddHandler subscriber.PropertyChanged, AddressOf OnPropertyChanged
        AddHandler subscriber.DataUpdated, AddressOf OnDataUpdated
    End Sub

    Private Sub OnPropertyChanged(ByVal sender As System.Object, ByVal e As PropertyChangedEventArgs)
        If (e.PropertyName = "ConnectionStatus") Then
            statusTextBox.Text = subscriber.ConnectionStatus.ToString()
        End If
    End Sub

    Private Sub OnDataUpdated(ByVal sender As Object, ByVal e As DataUpdatedEventArgs(Of Double()))
        If (e.Data.HasTimeStamp) Then
            timeStampTextBox.Text = e.Data.TimeStamp.ToLocalTime().ToString()
        End If

        If (e.Data.HasQuality) Then
            qualityTextBox.Text = e.Data.Quality.ToString()
        End If

        If (e.Data.HasValue) Then
            Dim data As Double() = e.Data.GetValue()
            displayWaveformGraph.PlotYAppend(data)
        End If

    End Sub

    Private Sub connectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connectButton.Click
        connectButton.Enabled = False
        disconnectButton.Enabled = True
        If (subscriber Is Nothing) Then
            CreateSubscriber()
        End If

        subscriber.Connect()
    End Sub

    Private Sub disconnectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles disconnectButton.Click
        statusTextBox.Text = "Disconnected"

        disconnectButton.Enabled = False
        connectButton.Enabled = True
        timeStampTextBox.Text = String.Empty
        qualityTextBox.Text = String.Empty

        subscriber.Disconnect()
        subscriber = Nothing
    End Sub
End Class
