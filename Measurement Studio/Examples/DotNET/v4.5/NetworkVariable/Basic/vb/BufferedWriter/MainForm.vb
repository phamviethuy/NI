Imports NationalInstruments.NetworkVariable
Imports System.ComponentModel
Imports System.Threading


Public Class MainForm

    Private WithEvents bufferedWriter As NetworkVariableBufferedWriter(Of Double())
    Private WithEvents doubleBufferedWriter As NetworkVariableBufferedWriter(Of Double)
    Private Const NetworkVariableLocation As String = "\\localhost\system\doublearray"
    Private Const DoubleNetworkVariableLocation As String = "\\localhost\system\double"
    Private workerThread As Thread

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm())
    End Sub

    Public Sub New()
        InitializeComponent()

        bufferedWriter = New NetworkVariableBufferedWriter(Of Double())(NetworkVariableLocation)
        doubleBufferedWriter = New NetworkVariableBufferedWriter(Of Double)(DoubleNetworkVariableLocation)
        AddHandler bufferedWriter.PropertyChanged, AddressOf OnPropertyChanged
        AddHandler amplitudeSlide.AfterChangeValue, AddressOf SlideAfterChange
        bufferedWriter.Connect()
        doubleBufferedWriter.Connect()

    End Sub

    Private Sub OnPropertyChanged(ByVal sender As System.Object, ByVal e As PropertyChangedEventArgs)
        If (e.PropertyName = "ConnectionStatus") Then
            connectionTextBox.Text = bufferedWriter.ConnectionStatus.ToString()
        End If
    End Sub

    Private Function GenerateDoubleArray(ByVal phase As Double) As Double()
        Dim amplitude As Double = amplitudeSlide.Value
        Dim values(999) As Double
        Dim x As Integer
        For x = 0 To 999
            values(x) = Math.Sin(((2 * Math.PI * x) / 1000) + phase) * amplitude
        Next x

        Return values
    End Function

    Private Sub WriteData(ByVal state As Object)
        Dim phase As Integer
        While (True)
            Dim values As Double() = GenerateDoubleArray(phase)
            Invoke(New WaitCallback(AddressOf UpdateGraph), values)
            bufferedWriter.WriteValue(values)
            Thread.Sleep(500)
            phase = phase + 1
        End While

    End Sub

    Private Sub UpdateGraph(ByVal state As Object)
        displayWaveformGraph.PlotYAppend(CType(state, Double()))
    End Sub


    Private Sub startButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles startButton.Click
        startButton.Enabled = False
        stopButton.Enabled = True
        workerThread = New Thread(AddressOf WriteData)
        workerThread.Start()
    End Sub

    Private Sub stopButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stopButton.Click
        startButton.Enabled = True
        stopButton.Enabled = False
        workerThread.Abort()
    End Sub


    Private Sub HandleFormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed

        If (workerThread IsNot Nothing) Then
            workerThread.Abort()
        End If

        Application.Exit()
    End Sub

    Private Sub SlideAfterChange(ByVal sender As System.Object, ByVal e As NationalInstruments.UI.AfterChangeNumericValueEventArgs)
        doubleBufferedWriter.WriteValue(amplitudeSlide.Value)
    End Sub
End Class
