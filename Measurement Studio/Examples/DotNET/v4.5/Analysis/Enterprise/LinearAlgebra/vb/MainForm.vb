Public Class MainForm
    Inherits System.Windows.Forms.Form
    Dim computeClicked As Integer = 0

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        normTypeComboBox.SelectedIndex = 0
        operationsComboBox.SelectedIndex = 0

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents matrixXLabel As System.Windows.Forms.Label
    Friend WithEvents linearEquationLabel As System.Windows.Forms.Label
    Friend WithEvents matrixBLabel As System.Windows.Forms.Label
    Friend WithEvents operationsLabel As System.Windows.Forms.Label
    Friend WithEvents normTypeLabel As System.Windows.Forms.Label
    Friend WithEvents inputGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents matrixALabel As System.Windows.Forms.Label
    Friend WithEvents helpTextBox As System.Windows.Forms.TextBox
    Private WithEvents toolTip As System.Windows.Forms.ToolTip
    Private WithEvents matrixXDataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents matrixBDataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents matrixADataTextBox As System.Windows.Forms.TextBox
    Friend WithEvents operationsComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents normTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents computeButton As System.Windows.Forms.Button
    Friend WithEvents operationsDataGrid As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.inputGroupBox = New System.Windows.Forms.GroupBox
        Me.matrixXLabel = New System.Windows.Forms.Label
        Me.matrixXDataTextBox = New System.Windows.Forms.TextBox
        Me.linearEquationLabel = New System.Windows.Forms.Label
        Me.matrixBDataTextBox = New System.Windows.Forms.TextBox
        Me.matrixALabel = New System.Windows.Forms.Label
        Me.helpTextBox = New System.Windows.Forms.TextBox
        Me.matrixADataTextBox = New System.Windows.Forms.TextBox
        Me.matrixBLabel = New System.Windows.Forms.Label
        Me.operationsDataGrid = New System.Windows.Forms.DataGrid
        Me.computeButton = New System.Windows.Forms.Button
        Me.operationsComboBox = New System.Windows.Forms.ComboBox
        Me.operationsLabel = New System.Windows.Forms.Label
        Me.normTypeComboBox = New System.Windows.Forms.ComboBox
        Me.normTypeLabel = New System.Windows.Forms.Label
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.inputGroupBox.SuspendLayout()
        CType(Me.operationsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputGroupBox
        '
        Me.inputGroupBox.Controls.Add(Me.matrixXLabel)
        Me.inputGroupBox.Controls.Add(Me.matrixXDataTextBox)
        Me.inputGroupBox.Controls.Add(Me.linearEquationLabel)
        Me.inputGroupBox.Controls.Add(Me.matrixBDataTextBox)
        Me.inputGroupBox.Controls.Add(Me.matrixALabel)
        Me.inputGroupBox.Controls.Add(Me.helpTextBox)
        Me.inputGroupBox.Controls.Add(Me.matrixADataTextBox)
        Me.inputGroupBox.Controls.Add(Me.matrixBLabel)
        Me.inputGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.inputGroupBox.Location = New System.Drawing.Point(16, 8)
        Me.inputGroupBox.Name = "inputGroupBox"
        Me.inputGroupBox.Size = New System.Drawing.Size(328, 248)
        Me.inputGroupBox.TabIndex = 1
        Me.inputGroupBox.TabStop = False
        Me.inputGroupBox.Text = "Input Matrices"
        '
        'matrixXLabel
        '
        Me.matrixXLabel.Enabled = False
        Me.matrixXLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.matrixXLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixXLabel.Location = New System.Drawing.Point(192, 72)
        Me.matrixXLabel.Name = "matrixXLabel"
        Me.matrixXLabel.Size = New System.Drawing.Size(16, 16)
        Me.matrixXLabel.TabIndex = 2
        Me.matrixXLabel.Text = "X"
        '
        'matrixXDataTextBox
        '
        Me.matrixXDataTextBox.Enabled = False
        Me.matrixXDataTextBox.Location = New System.Drawing.Point(184, 96)
        Me.matrixXDataTextBox.Multiline = True
        Me.matrixXDataTextBox.Name = "matrixXDataTextBox"
        Me.matrixXDataTextBox.ReadOnly = True
        Me.matrixXDataTextBox.Size = New System.Drawing.Size(48, 136)
        Me.matrixXDataTextBox.TabIndex = 1
        Me.matrixXDataTextBox.TabStop = False
        Me.matrixXDataTextBox.Text = ""
        '
        'linearEquationLabel
        '
        Me.linearEquationLabel.Enabled = False
        Me.linearEquationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.linearEquationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linearEquationLabel.Location = New System.Drawing.Point(240, 144)
        Me.linearEquationLabel.Name = "linearEquationLabel"
        Me.linearEquationLabel.Size = New System.Drawing.Size(16, 24)
        Me.linearEquationLabel.TabIndex = 10
        Me.linearEquationLabel.Text = "=         "
        Me.linearEquationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'matrixBDataTextBox
        '
        Me.matrixBDataTextBox.Enabled = False
        Me.matrixBDataTextBox.Location = New System.Drawing.Point(264, 96)
        Me.matrixBDataTextBox.Multiline = True
        Me.matrixBDataTextBox.Name = "matrixBDataTextBox"
        Me.matrixBDataTextBox.Size = New System.Drawing.Size(48, 136)
        Me.matrixBDataTextBox.TabIndex = 2
        Me.matrixBDataTextBox.Text = "2.00;" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "12.00;" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "10.00;"
        '
        'matrixALabel
        '
        Me.matrixALabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.matrixALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixALabel.Location = New System.Drawing.Point(72, 72)
        Me.matrixALabel.Name = "matrixALabel"
        Me.matrixALabel.Size = New System.Drawing.Size(16, 16)
        Me.matrixALabel.TabIndex = 0
        Me.matrixALabel.Text = "A"
        '
        'helpTextBox
        '
        Me.helpTextBox.Location = New System.Drawing.Point(8, 16)
        Me.helpTextBox.Multiline = True
        Me.helpTextBox.Name = "helpTextBox"
        Me.helpTextBox.ReadOnly = True
        Me.helpTextBox.Size = New System.Drawing.Size(208, 48)
        Me.helpTextBox.TabIndex = 7
        Me.helpTextBox.TabStop = False
        Me.helpTextBox.Text = "Enter Matrix Data Row by Row." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Terminate Each Row by a semicolon ( ; )." & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "Seperate" & _
        " elements in a row by comas ( , )."
        '
        'matrixADataTextBox
        '
        Me.matrixADataTextBox.Location = New System.Drawing.Point(8, 96)
        Me.matrixADataTextBox.Multiline = True
        Me.matrixADataTextBox.Name = "matrixADataTextBox"
        Me.matrixADataTextBox.Size = New System.Drawing.Size(152, 136)
        Me.matrixADataTextBox.TabIndex = 0
        Me.matrixADataTextBox.Text = "4.00, 2.00, -1.00;" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "1.00 ,4.00, 1.00;" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10) & "0.10, 1.00, 2.00;"
        '
        'matrixBLabel
        '
        Me.matrixBLabel.Enabled = False
        Me.matrixBLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.matrixBLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.matrixBLabel.Location = New System.Drawing.Point(280, 72)
        Me.matrixBLabel.Name = "matrixBLabel"
        Me.matrixBLabel.Size = New System.Drawing.Size(24, 16)
        Me.matrixBLabel.TabIndex = 4
        Me.matrixBLabel.Text = "B"
        '
        'operationsDataGrid
        '
        Me.operationsDataGrid.DataMember = ""
        Me.operationsDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.operationsDataGrid.Location = New System.Drawing.Point(368, 16)
        Me.operationsDataGrid.Name = "operationsDataGrid"
        Me.operationsDataGrid.Size = New System.Drawing.Size(264, 128)
        Me.operationsDataGrid.TabIndex = 9
        Me.operationsDataGrid.TabStop = False
        '
        'computeButton
        '
        Me.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.computeButton.Location = New System.Drawing.Point(432, 224)
        Me.computeButton.Name = "computeButton"
        Me.computeButton.Size = New System.Drawing.Size(136, 24)
        Me.computeButton.TabIndex = 0
        Me.computeButton.Text = "Compute"
        Me.toolTip.SetToolTip(Me.computeButton, "Compute the result of the selected operation on input matrix.")
        '
        'operationsComboBox
        '
        Me.operationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.operationsComboBox.Items.AddRange(New Object() {"Determinant", "Trace", "Rank", "Condition Number", "Inverse", "PseudoInverse", "Norm", "TestPositiveDefinite", "Transpose", "Cholesky Factorization", "Eigen Values and Eigen Vectors", "LU Decomposition", "QR Factorization", "SolveLinearEquations (Ax = B)", "SingularValueDecomposition"})
        Me.operationsComboBox.Location = New System.Drawing.Point(360, 176)
        Me.operationsComboBox.Name = "operationsComboBox"
        Me.operationsComboBox.Size = New System.Drawing.Size(192, 21)
        Me.operationsComboBox.TabIndex = 2
        '
        'operationsLabel
        '
        Me.operationsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.operationsLabel.Location = New System.Drawing.Point(360, 160)
        Me.operationsLabel.Name = "operationsLabel"
        Me.operationsLabel.Size = New System.Drawing.Size(64, 32)
        Me.operationsLabel.TabIndex = 11
        Me.operationsLabel.Text = "Operations"
        '
        'normTypeComboBox
        '
        Me.normTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.normTypeComboBox.Enabled = False
        Me.normTypeComboBox.Items.AddRange(New Object() {"2-norm", "1-norm", "F-norm", "inf-norm"})
        Me.normTypeComboBox.Location = New System.Drawing.Point(568, 176)
        Me.normTypeComboBox.Name = "normTypeComboBox"
        Me.normTypeComboBox.Size = New System.Drawing.Size(64, 21)
        Me.normTypeComboBox.TabIndex = 3
        '
        'normTypeLabel
        '
        Me.normTypeLabel.Enabled = False
        Me.normTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.normTypeLabel.Location = New System.Drawing.Point(568, 160)
        Me.normTypeLabel.Name = "normTypeLabel"
        Me.normTypeLabel.Size = New System.Drawing.Size(72, 32)
        Me.normTypeLabel.TabIndex = 14
        Me.normTypeLabel.Text = "Norm Type"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(648, 269)
        Me.Controls.Add(Me.computeButton)
        Me.Controls.Add(Me.operationsComboBox)
        Me.Controls.Add(Me.operationsLabel)
        Me.Controls.Add(Me.normTypeComboBox)
        Me.Controls.Add(Me.normTypeLabel)
        Me.Controls.Add(Me.operationsDataGrid)
        Me.Controls.Add(Me.inputGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Linear Algebra/Matrix Operations"
        Me.inputGroupBox.ResumeLayout(False)
        CType(Me.operationsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    'Read 2D Matrix from the mainForm.cs panel.
    Private Function Read2DMatrix(ByVal matrixData As String) As Double(,)
        Dim rowIndex, columnIndex, numFirstRowElements As Integer
        Dim splitRows() As String
        Dim splitDataByColumns() As String
        Dim matrix(,) As Double

        numFirstRowElements = 0
        'store rows of Matrix in to splitRows string array.
        splitRows = System.Text.RegularExpressions.Regex.Split(matrixData, ";", System.Text.RegularExpressions.RegexOptions.Multiline)

        'Memory Allocation for matrix.
        matrix = New Double(splitRows.Length - 2, splitRows.Length - 2) {}

        For rowIndex = 0 To (splitRows.Length - 2)
            splitDataByColumns = System.Text.RegularExpressions.Regex.Split(splitRows(rowIndex), ",")
            If (rowIndex = 0) Then
                numFirstRowElements = splitDataByColumns.Length
                matrix = New Double(splitRows.Length - 2, splitDataByColumns.Length - 1) {}
            Else
                If numFirstRowElements <> splitDataByColumns.Length Then
                    Throw New ArgumentException(String.Concat("Number of columns is incorrect for Row ", (rowIndex + 1)))
                End If
                End If
                For columnIndex = 0 To (splitDataByColumns.Length - 1)
                    matrix(rowIndex, columnIndex) = System.Convert.ToDouble(splitDataByColumns(columnIndex))
                Next columnIndex
        Next rowIndex
        Return matrix
    End Function
    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub
    'Read 1D Matrix.
    Private Function Read1DMatrix(ByVal matrixData As String) As Double()
        Dim splitRows() As String
        Dim matrix() As Double
        Dim i As Integer

        splitRows = System.Text.RegularExpressions.Regex.Split(matrixData, ";", System.Text.RegularExpressions.RegexOptions.Multiline)
        matrix = New Double(splitRows.Length - 2) {}
        For i = 0 To (splitRows.Length - 2)
            matrix(i) = System.Convert.ToDouble(splitRows(i))
        Next i
        Return matrix
    End Function

    Private Sub compute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles computeButton.Click
        Dim i, j As Integer
        Dim dataString() As String
        Dim value1() As String = New String(0) {}
        Dim matrixA(,) As Double = {}
        Dim normTypeValue As NationalInstruments.Analysis.Math.NormType

        computeClicked = 1 'set it to one when comput button is clicked.
        value1.Initialize()

        'create a data set.
        Dim data As System.Data.DataSet = New DataSet(" ")
        Dim table As System.Data.DataTable = data.Tables.Add(" ") 'Attach a table to data set.

        Try
            matrixA = Read2DMatrix(matrixADataTextBox.Text) 'read Matrix A.

            If matrixA.GetLength(0) = 0 Or matrixA.GetLength(1) = 0 Then
                Throw New ArgumentException("Matrix A has incorrect number of rows or columns")
            End If

            Select Case operationsComboBox.SelectedIndex
                Case 0 'Determinant
                    Dim determinant As Double = 0

                    determinant = NationalInstruments.Analysis.Math.LinearAlgebra.Determinant(matrixA)
                    value1(0) = String.Format("{0:F2}", determinant)
                    table.TableName = "Determinant"
                    table.Columns.Add(" ")
                    table.Rows.Add(value1)
                    operationsDataGrid.CaptionText = "   Determinant of Matrix A"
                    operationsDataGrid.DataSource = data
                Case 1 'Trace
                    Dim trace As Double = 0

                    trace = NationalInstruments.Analysis.Math.LinearAlgebra.Trace(matrixA)
                    table.TableName = "Trace"
                    value1(0) = String.Format("{0:F2}", trace)
                    table.Columns.Add("  ")
                    table.Rows.Add(value1)
                    operationsDataGrid.CaptionText = "   Trace of Matrix A"
                    operationsDataGrid.DataSource = data
                Case 2 'Rank
                    Dim rank As Integer

                    rank = NationalInstruments.Analysis.Math.LinearAlgebra.Rank(matrixA, -1)
                    table.TableName = "Rank"
                    value1(0) = String.Format("{0:F2}", rank)
                    table.Columns.Add("  ")
                    table.Rows.Add(value1)
                    operationsDataGrid.CaptionText = "   Rank of Matrix A"
                    operationsDataGrid.DataSource = data
                Case 3 'Condition Number.
                    Dim conditionNumber As Double

                    Select Case normTypeComboBox.SelectedIndex
                        Case 0 '2-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.TwoNorm
                        Case 1 '1-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.OneNorm
                        Case 2 'F-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.FrobeniusNorm
                        Case 3 'I-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.InfiniteNorm
                    End Select

                    conditionNumber = NationalInstruments.Analysis.Math.LinearAlgebra.ConditionNumber(matrixA, normTypeValue)
                    table.TableName = "ConditionNumber"
                    value1(0) = String.Format("{0:F2}", conditionNumber)
                    table.Columns.Add("  ")
                    table.Rows.Add(value1)
                    operationsDataGrid.CaptionText = "   Condition Number of Matrix A"
                    operationsDataGrid.DataSource = data
                Case 4 'Inverse Matrix
                    Dim inverseMatrix As Double(,)

                    If (matrixA.GetLength(0) = matrixA.GetLength(1)) Then
                        inverseMatrix = NationalInstruments.Analysis.Math.LinearAlgebra.Inverse(matrixA)
                        dataString = New String(matrixA.GetLength(0) - 1) {}
                        table.TableName = "InverseMatrix"
                        For i = 0 To (matrixA.GetLength(0) - 1)
                            table.Columns.Add()
                        Next i
                        For i = 0 To (matrixA.GetLength(0) - 1)
                            For j = 0 To (matrixA.GetLength(0) - 1)
                                dataString(j) = String.Format("{0:F2}", inverseMatrix(i, j))
                            Next j
                            table.Rows.Add(dataString)
                        Next i
                        operationsDataGrid.CaptionText = "   Inverse of Matrix A"
                        operationsDataGrid.DataSource = data
                    Else
                        MessageBox.Show("Please enter a square matrix to perform this operation")
                    End If
                Case 5 'Pseudo Inverse Matrix.
                    Dim pseudoInverse As Double(,)

                    pseudoInverse = NationalInstruments.Analysis.Math.LinearAlgebra.PseudoInverse(matrixA, -1)
                    dataString = New String(pseudoInverse.GetLength(1) - 1) {}
                    table.TableName = " Pseudo Inverse"
                    For i = 0 To (pseudoInverse.GetLength(1) - 1)
                        table.Columns.Add()
                    Next i
                    For i = 0 To (pseudoInverse.GetLength(0) - 1)
                        For j = 0 To (pseudoInverse.GetLength(1) - 1)
                            dataString(j) = String.Format("{0:F2}", pseudoInverse(i, j))
                        Next j
                        table.Rows.Add(dataString)
                    Next i
                    operationsDataGrid.CaptionText = "   Pseudo Inverse of Matrix A"
                    operationsDataGrid.DataSource = data
                Case 6 'Norm of the Marix.
                    Dim norm As Double

                    Select Case normTypeComboBox.SelectedIndex
                        Case 0 '2-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.TwoNorm
                        Case 1 '1-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.OneNorm
                        Case 2 'F-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.FrobeniusNorm
                        Case 3 'I-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.InfiniteNorm
                    End Select
                    norm = NationalInstruments.Analysis.Math.LinearAlgebra.Norm(matrixA, normTypeValue)
                    table.TableName = "Norm"
                    value1(0) = String.Format("{0:F2}", norm)
                    table.Columns.Add("  ")
                    table.Rows.Add(value1)
                    operationsDataGrid.CaptionText = "   Norm of Matrix A"
                    operationsDataGrid.DataSource = data
                Case 7 'Is PositiveDefinite?
                    Dim isPositiveDefinite As Boolean = False

                    If (matrixA.GetLength(0) = matrixA.GetLength(1)) Then
                        isPositiveDefinite = NationalInstruments.Analysis.Math.LinearAlgebra.IsPositiveDefinite(matrixA)
                        table.TableName = "isPositiveDefinite?"
                        If (isPositiveDefinite = False) Then
                            value1(0) = "False"
                        Else
                            value1(0) = "True"
                        End If
                        table.Columns.Add("  ")
                        table.Rows.Add(value1)
                        operationsDataGrid.CaptionText = "Test Positive Definite of Matrix A"
                        operationsDataGrid.DataSource = data
                    Else
                        MessageBox.Show("Please enter a square matrix to perform this operation")
                    End If
                Case 8 'Transpose
                    Dim transpose As Double(,)

                    transpose = NationalInstruments.Analysis.Math.LinearAlgebra.Transpose(matrixA)
                    dataString = New String(transpose.GetLength(1) - 1) {}
                    table.TableName = " Transpose"
                    For i = 0 To (transpose.GetLength(1) - 1)
                        table.Columns.Add()
                    Next i
                    For i = 0 To (transpose.GetLength(0) - 1)
                        For j = 0 To (transpose.GetLength(1) - 1)
                            dataString(j) = String.Format("{0:F2}", transpose(i, j))
                        Next j
                        table.Rows.Add(dataString)
                    Next i
                    operationsDataGrid.CaptionText = "   Transpose of Matrix A"
                    operationsDataGrid.DataSource = data
                Case 9 'Cholesky Factorization.
                    Dim choleskyFactorization(,) As Double

                    If ((matrixA.GetLength(0)) = (matrixA.GetLength(1))) Then

                        If (NationalInstruments.Analysis.Math.LinearAlgebra.IsPositiveDefinite(matrixA) = False) Then
                            MessageBox.Show("Input matrix is non singular.", "Error")
                        Else
                            choleskyFactorization = New Double(matrixA.GetLength(1) - 1, matrixA.GetLength(0) - 1) {}
                            choleskyFactorization = NationalInstruments.Analysis.Math.LinearAlgebra.CholeskyFactorization(matrixA)
                            dataString = New String(choleskyFactorization.GetLength(1) - 1) {}
                            table.TableName = " CholeskyFactorization"
                            For i = 0 To (choleskyFactorization.GetLength(1) - 1)
                                table.Columns.Add()
                            Next i
                            For i = 0 To (choleskyFactorization.GetLength(0) - 1)
                                For j = 0 To (choleskyFactorization.GetLength(1) - 1)
                                    dataString(j) = String.Format("{0:F2}", choleskyFactorization(i, j))
                                Next j
                                table.Rows.Add(dataString)
                            Next i

                            operationsDataGrid.CaptionText = "Cholesky Factorization of Matrix A"
                            operationsDataGrid.DataSource = data
                        End If
                    Else
                        MessageBox.Show("Please enter a square and non singular matrix to perform this operation")
                    End If
                Case 10 'Eigen Values and Eigen Vectors.
                    Dim eigenValues() As NationalInstruments.ComplexDouble = {}
                    Dim eigenVectors(,) As NationalInstruments.ComplexDouble = {}

                    If (matrixA.GetLength(0) = matrixA.GetLength(1)) Then
                        eigenValues = New NationalInstruments.ComplexDouble(matrixA.GetLength(0) - 1) {}
                        eigenValues = NationalInstruments.Analysis.Math.LinearAlgebra.GeneralEigenValueVector(matrixA, eigenVectors)
                        'Display Eigen Values in a data set table.
                        dataString = New String(0) {}
                        table.TableName = " Eigen Values"
                        table.Columns.Add(" ")

                        For i = 0 To (eigenValues.GetLength(0) - 1)
                            dataString(0) = String.Format("{0:F2}", eigenValues(i))
                            table.Rows.Add(dataString)
                        Next i

                        operationsDataGrid.CaptionText = "Eigen Values and Eigen Vectors of Matrix A"
                        operationsDataGrid.DataSource = data
                        'Display eigen vectors in another table.
                        Dim table2 As System.Data.DataTable = data.Tables.Add("Eigen Vectors ")
                        dataString = New String(eigenVectors.GetLength(1) - 1) {}

                        For i = 0 To (eigenVectors.GetLength(1) - 1)
                            table2.Columns.Add()
                        Next i
                        For i = 0 To (eigenVectors.GetLength(0) - 1)
                            For j = 0 To (eigenVectors.GetLength(1) - 1)
                                dataString(j) = String.Format("{0:F2}", eigenVectors(i, j))
                            Next j
                            table2.Rows.Add(dataString)
                        Next i
                        operationsDataGrid.DataSource = data
                    Else
                        MessageBox.Show("Please enter a square matrix to perform this operation")
                    End If
                Case 11 'LU Factorization.
                    Dim sign As Integer
                    Dim permutationVector() As Integer = {}
                    Dim luFactorize(,) As Double

                    If (matrixA.GetLength(0) = matrixA.GetLength(1)) Then
                        luFactorize = NationalInstruments.Analysis.Math.LinearAlgebra.LUFactorization(matrixA, permutationVector, sign)
                        dataString = New String(luFactorize.GetLength(1) - 1) {}
                        table.TableName = "LUFactorization"
                        For i = 0 To (luFactorize.GetLength(1) - 1)
                            table.Columns.Add()
                        Next i
                        For i = 0 To (luFactorize.GetLength(0) - 1)
                            For j = 0 To (luFactorize.GetLength(1) - 1)
                                dataString(j) = String.Format("{0:F2}", luFactorize(i, j))
                            Next j
                            table.Rows.Add(dataString)
                        Next i
                        operationsDataGrid.CaptionText = "LU Factorization of Matrix A"
                        operationsDataGrid.DataSource = data
                    Else
                        MessageBox.Show("Please enter a square matrix to perform this operation")
                    End If
                Case 12 'QR Factorization.
                    Dim qMatrix(,) As Double = {}
                    Dim rMatrix(,) As Double = {}

                    NationalInstruments.Analysis.Math.LinearAlgebra.QRFactorization(matrixA, SizeOption.Economy, rMatrix, qMatrix)
                    'Display Q Matrix.
                    dataString = New String(qMatrix.GetLength(1) - 1) {}
                    table.TableName = "Q Matrix"
                    For i = 0 To (qMatrix.GetLength(1) - 1)
                        table.Columns.Add()
                    Next i
                    For i = 0 To (qMatrix.GetLength(0) - 1)
                        For j = 0 To (qMatrix.GetLength(1) - 1)
                            dataString(j) = String.Format("{0:F2}", qMatrix(i, j))
                        Next j
                        table.Rows.Add(dataString)
                    Next i
                    operationsDataGrid.CaptionText = "QR Factorization of Matrix A"
                    operationsDataGrid.DataSource = data
                    'Display R Matrix.
                    Dim table3 As System.Data.DataTable = data.Tables.Add("R Matrix ")
                    dataString = New String(rMatrix.GetLength(1) - 1) {}
                    For i = 0 To (rMatrix.GetLength(1) - 1)
                        table3.Columns.Add()
                    Next i
                    For i = 0 To (rMatrix.GetLength(0) - 1)
                        For j = 0 To (rMatrix.GetLength(1) - 1)
                            dataString(j) = String.Format("{0:F2}", rMatrix(i, j))
                        Next j
                        table3.Rows.Add(dataString)
                    Next i

                    operationsDataGrid.DataSource = data
                Case 13 'Solve Linear Equations.
                    Dim arrayB() As Double
                    Dim solutionMatrix() As Double
                    Dim rowStringArray() As String

                    If (matrixA.GetLength(0) = matrixA.GetLength(1)) Then
                        arrayB = Read1DMatrix(matrixBDataTextBox.Text)
                        solutionMatrix = NationalInstruments.Analysis.Math.LinearAlgebra.SolveLinearEquationsSingleRightHand(matrixA, MatrixType.General, arrayB)
                        dataString = New String(0) {}
                        rowStringArray = New String(solutionMatrix.Length - 1) {}
                        table.TableName = "Solution x to Ax = B"
                        table.Columns.Add(" ")

                        For i = 0 To (solutionMatrix.GetLength(0) - 1)
                            dataString(0) = String.Format("{0:F2}", solutionMatrix(i))
                            rowStringArray(i) = String.Format("{0:F2}", solutionMatrix(i))
                            table.Rows.Add(dataString)
                        Next i
                        Dim sep As String = vbNewLine
                        matrixXDataTextBox.Text = String.Join(sep, rowStringArray)
                        operationsDataGrid.CaptionText = " Solution x to Ax = B"
                        operationsDataGrid.DataSource = data
                    Else
                        MessageBox.Show("Please enter a square matrix to perform this operation")
                    End If
                Case 14 'Singular Value Decomposition. 
                    Dim uMatrix(,) As Double = {}
                    Dim vMatrix(,) As Double = {}
                    Dim singularValues() As Double = _
                    NationalInstruments.Analysis.Math.LinearAlgebra.SvdFactorization(matrixA, SizeOption.Economy, uMatrix, vMatrix)
                    'Display of singular values.
                    dataString = New String(0) {}

                    table.TableName = "Singular Values"
                    table.Columns.Add(" ")

                    For i = 0 To (singularValues.GetLength(0) - 1)
                        dataString(0) = String.Format("{0:F2}", singularValues(i))
                        table.Rows.Add(dataString)
                    Next i
                    operationsDataGrid.CaptionText = "Singular Value Decomposition of MatrixA"
                    operationsDataGrid.DataSource = data
                    'To display U matrix.
                    Dim table4 As DataTable = data.Tables.Add("SVD of A - U ")
                    dataString = New String(uMatrix.GetLength(1) - 1) {}

                    For i = 0 To (uMatrix.GetLength(1) - 1)
                        table4.Columns.Add()
                    Next i
                    For i = 0 To (uMatrix.GetLength(0) - 1)
                        For j = 0 To (uMatrix.GetLength(1) - 1)
                            dataString(j) = String.Format("{0:F2}", uMatrix(i, j))
                        Next j
                        table4.Rows.Add(dataString)
                    Next i
                    'Display V - Matrix.
                    Dim table5 As DataTable = data.Tables.Add("SVD of A - V ")
                    dataString = New String(vMatrix.GetLength(1) - 1) {}

                    For i = 0 To (vMatrix.GetLength(1) - 1)
                        table5.Columns.Add()
                    Next i
                    For i = 0 To (vMatrix.GetLength(0) - 1)
                        For j = 0 To (vMatrix.GetLength(1) - 1)
                            dataString(j) = String.Format("{0:F2}", vMatrix(i, j))
                        Next j
                        table5.Rows.Add(dataString)
                    Next i

                    operationsDataGrid.DataSource = data
            End Select
        Catch exp As Exception
            MessageBox.Show(exp.Message)
        End Try
    End Sub

    Private Sub operations_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles operationsComboBox.SelectedIndexChanged
        If operationsComboBox.SelectedIndex = 3 Or operationsComboBox.SelectedIndex = 6 Then
            normTypeComboBox.Enabled = True
            normTypeLabel.Enabled = True
        Else
            normTypeComboBox.Enabled = False
            normTypeLabel.Enabled = False
        End If
        If (operationsComboBox.SelectedIndex = 13) Then
            matrixBDataTextBox.Enabled = True
            matrixBLabel.Enabled = True
            matrixXLabel.Enabled = True
            matrixXDataTextBox.Enabled = True
            linearEquationLabel.Enabled = True
        Else
            matrixBDataTextBox.Enabled = False
            matrixBLabel.Enabled = False
            matrixXLabel.Enabled = False
            matrixXDataTextBox.Enabled = False
            linearEquationLabel.Enabled = False
        End If
        If (computeClicked = 1) Then
            computeButton.PerformClick()
        End If
    End Sub
End Class
