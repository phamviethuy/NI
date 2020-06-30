Imports NationalInstruments.NetworkVariable

Public Class MainForm

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm())
    End Sub

    Private Sub UpdateProcessList()
        Dim processes() As ServerProcessInfo = Nothing

        ProcessesListBox.Items.Clear()

        ' Get a list of all processes
        Try
            processes = ServerProcess.GetAll()
        Catch ex As Exception
            MessageBox.Show("Error gathering process list.", Me.Text)
        End Try

        If processes IsNot Nothing Then
            ' Store the process names in the process list box
            For Each procInfo As ServerProcessInfo In processes
                ProcessesListBox.Items.Add(procInfo)
            Next

            ProcessesListBox.DisplayMember = "Name"
        End If
    End Sub

    Private Sub UpdateVariableList()
        Dim variables() As ServerVariableInfo = Nothing
        Dim procInfo As ServerProcessInfo = Nothing

        ' Get the selected process
        If ProcessesListBox.SelectedItem IsNot Nothing Then
            procInfo = CType(ProcessesListBox.SelectedItem, ServerProcessInfo)

            If procInfo.Exists Then
                Try
                    variables = procInfo.GetVariables()
                Catch ex As Exception
                    MessageBox.Show("Error retrieving process variables.")
                End Try
            End If
        End If

        VariablesListBox.Items.Clear()

        If variables IsNot Nothing Then
            For Each variable As ServerVariableInfo In variables
                VariablesListBox.Items.Add(variable)
            Next

            VariablesListBox.DisplayMember = "Name"
        End If

    End Sub

    Private Sub CreateProcessButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreateProcessButton.Click
        If ProcessNameTextBox.Text.Length = 0 Then
            MessageBox.Show("Please enter a process name.", Me.Text)
        Else
            Try
                ServerProcess.Create(ProcessNameTextBox.Text)
            Catch ex As Exception
                Dim message As String = String.Format("Error creating process:{0}{1}", Environment.NewLine, ex.Message)
                MessageBox.Show(message, Me.Text)
            End Try
        End If
        UpdateProcessList()
    End Sub

    Private Sub CreateVariableButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CreateVariableButton.Click
        If VariableNameTextBox.Text.Length = 0 Then
            MessageBox.Show("Please enter a variable name.", Me.Text)
        Else
            Dim procInfo As ServerProcessInfo = Nothing

            If ProcessesListBox.SelectedItem IsNot Nothing Then
                procInfo = CType(ProcessesListBox.SelectedItem, ServerProcessInfo)

                Try
                    procInfo.CreateVariable(VariableNameTextBox.Text)
                Catch ex As Exception
                    Dim message As String = String.Format("Error creating variable:{0}{1}", Environment.NewLine, ex.Message)
                    MessageBox.Show(message, Me.Text)
                End Try
            Else
                MessageBox.Show("Please select a process.", Me.Text)
            End If
        End If
        UpdateVariableList()
    End Sub

    Private Sub DeleteProcessMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteProcessMenuItem.Click
        Dim procInfo As ServerProcessInfo = Nothing

        If ProcessesListBox.SelectedItem IsNot Nothing Then
            procInfo = CType(ProcessesListBox.SelectedItem, ServerProcessInfo)

            Try
                procInfo.Delete()
            Catch ex As Exception
                Dim message As String = String.Format("Error deleting process:{0}{1}", Environment.NewLine, ex.Message)
                MessageBox.Show(message, Me.Text)
            End Try

            UpdateProcessList()
            UpdateVariableList()
        Else
            MessageBox.Show("Please select a process.", Me.Text)
        End If
    End Sub

    Private Sub DeleteVariableMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeleteVariableMenuItem.Click
        Dim varInfo As ServerVariableInfo = Nothing

        If VariablesListBox.SelectedItem IsNot Nothing Then
            varInfo = CType(VariablesListBox.SelectedItem, ServerVariableInfo)

            Try
                varInfo.Delete()
            Catch ex As Exception
                Dim message As String = String.Format("Error deleting variable:{0}{1}", Environment.NewLine, ex.Message)
                MessageBox.Show(message, Me.Text)
            End Try

            UpdateVariableList()
        Else
            MessageBox.Show("Please select a variable.", Me.Text)
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UpdateProcessList()
    End Sub

    Private Sub ProcessesListBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ProcessesListBox.SelectedIndexChanged
        UpdateVariableList()
    End Sub

    Private Sub RefreshProcessesMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RefreshProcessesMenuItem.Click
        UpdateProcessList()
    End Sub

    Private Sub RefreshVariablesMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RrefreshVariablesMenuItem.Click
        UpdateVariableList()
    End Sub

End Class
