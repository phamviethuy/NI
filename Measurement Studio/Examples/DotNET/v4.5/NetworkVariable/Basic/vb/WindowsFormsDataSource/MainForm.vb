Public Class MainForm

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm())
    End Sub

    Public Sub New()
        InitializeComponent()

        Try
            dataSource.Connect()
        Catch ex As Exception
            MessageBox.Show("Start the Network Variable Writer example before running this example.", "National Instruments", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
