Imports System
Imports System.IO
Imports System.Windows.Forms

Public Class MainForm

    <System.STAThread()> _
    Public Shared Sub Main()
        System.Windows.Forms.Application.EnableVisualStyles()
        System.Windows.Forms.Application.Run(New MainForm)
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    Private Sub OnTdmsFileBrowseButtonClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdmsFileBrowseButton.Click
        tdmsOpenFileDialog.InitialDirectory = GetInitialDirectory()
        If tdmsOpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            tdmsFileTextBox.Text = tdmsOpenFileDialog.FileName

            Try
                readerTdmsReaderUserControl.LoadFile(tdmsOpenFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub

    Private Function GetInitialDirectory() As String
        Dim initialDirectory As String = "..\.."
        Dim currentDirectory As DirectoryInfo = New DirectoryInfo(Environment.CurrentDirectory)
        If Not currentDirectory.Parent Is Nothing Then
            Dim parentDirectory As DirectoryInfo = currentDirectory.Parent
            If Not parentDirectory.Parent Is Nothing Then
                initialDirectory = parentDirectory.Parent.FullName
            End If
        End If
        Return initialDirectory
    End Function
End Class
