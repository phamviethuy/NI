using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Analysis.SpectralMeasurements;
using NationalInstruments;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.LinearAlgebra
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
        private System.Windows.Forms.Label operationsLabel;
        private System.Windows.Forms.Label normTypeLabel;
        private System.Windows.Forms.DataGridTableStyle table1;
        private System.Windows.Forms.ToolTip toolTip;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Label matrixBLabel;
        private System.Windows.Forms.Label linearEquationLabel;
        private System.Windows.Forms.Label matrixXLabel;
        private System.Windows.Forms.GroupBox inputMatricesGroupBox;
        private System.Windows.Forms.TextBox helpTextBox;
        private System.Windows.Forms.Label matrixALabel;
        private System.Windows.Forms.TextBox matrixXDataTextBox;
        private System.Windows.Forms.TextBox matrixBDataTextBox;
        private System.Windows.Forms.TextBox matrixADataTextBox;
        private System.Windows.Forms.ComboBox operationsComboBox;
        private System.Windows.Forms.ComboBox normTypeComboBox;
        private System.Windows.Forms.Button computeButton;
        private System.Windows.Forms.DataGrid operationsDataGrid;
        int computeClicked = 0;
       
        

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            operationsComboBox.SelectedIndex = 0;
            normTypeComboBox.SelectedIndex =0;
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
            this.inputMatricesGroupBox = new System.Windows.Forms.GroupBox();
            this.matrixXLabel = new System.Windows.Forms.Label();
            this.matrixXDataTextBox = new System.Windows.Forms.TextBox();
            this.linearEquationLabel = new System.Windows.Forms.Label();
            this.matrixBDataTextBox = new System.Windows.Forms.TextBox();
            this.matrixALabel = new System.Windows.Forms.Label();
            this.helpTextBox = new System.Windows.Forms.TextBox();
            this.matrixADataTextBox = new System.Windows.Forms.TextBox();
            this.matrixBLabel = new System.Windows.Forms.Label();
            this.operationsComboBox = new System.Windows.Forms.ComboBox();
            this.operationsLabel = new System.Windows.Forms.Label();
            this.normTypeComboBox = new System.Windows.Forms.ComboBox();
            this.normTypeLabel = new System.Windows.Forms.Label();
            this.computeButton = new System.Windows.Forms.Button();
            this.operationsDataGrid = new System.Windows.Forms.DataGrid();
            this.table1 = new System.Windows.Forms.DataGridTableStyle();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inputMatricesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // inputMatricesGroupBox
            // 
            this.inputMatricesGroupBox.Controls.Add(this.matrixXLabel);
            this.inputMatricesGroupBox.Controls.Add(this.matrixXDataTextBox);
            this.inputMatricesGroupBox.Controls.Add(this.linearEquationLabel);
            this.inputMatricesGroupBox.Controls.Add(this.matrixBDataTextBox);
            this.inputMatricesGroupBox.Controls.Add(this.matrixALabel);
            this.inputMatricesGroupBox.Controls.Add(this.helpTextBox);
            this.inputMatricesGroupBox.Controls.Add(this.matrixADataTextBox);
            this.inputMatricesGroupBox.Controls.Add(this.matrixBLabel);
            this.inputMatricesGroupBox.Location = new System.Drawing.Point(16, 8);
            this.inputMatricesGroupBox.Name = "inputMatricesGroupBox";
            this.inputMatricesGroupBox.Size = new System.Drawing.Size(328, 248);
            this.inputMatricesGroupBox.TabIndex = 0;
            this.inputMatricesGroupBox.TabStop = false;
            this.inputMatricesGroupBox.Text = "Input Matrices";
            // 
            // matrixXLabel
            // 
            this.matrixXLabel.Enabled = false;
            this.matrixXLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.matrixXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.matrixXLabel.Location = new System.Drawing.Point(192, 72);
            this.matrixXLabel.Name = "matrixXLabel";
            this.matrixXLabel.Size = new System.Drawing.Size(16, 16);
            this.matrixXLabel.TabIndex = 12;
            this.matrixXLabel.Text = "X";
            // 
            // matrixXDataTextBox
            // 
            this.matrixXDataTextBox.Enabled = false;
            this.matrixXDataTextBox.Location = new System.Drawing.Point(184, 96);
            this.matrixXDataTextBox.Multiline = true;
            this.matrixXDataTextBox.Name = "matrixXDataTextBox";
            this.matrixXDataTextBox.ReadOnly = true;
            this.matrixXDataTextBox.Size = new System.Drawing.Size(48, 136);
            this.matrixXDataTextBox.TabIndex = 1;
            this.matrixXDataTextBox.TabStop = false;
            this.matrixXDataTextBox.Text = "";
            // 
            // linearEquationLabel
            // 
            this.linearEquationLabel.Enabled = false;
            this.linearEquationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.linearEquationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.linearEquationLabel.Location = new System.Drawing.Point(240, 144);
            this.linearEquationLabel.Name = "linearEquationLabel";
            this.linearEquationLabel.Size = new System.Drawing.Size(16, 24);
            this.linearEquationLabel.TabIndex = 10;
            this.linearEquationLabel.Text = "=         ";
            this.linearEquationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matrixBDataTextBox
            // 
            this.matrixBDataTextBox.Enabled = false;
            this.matrixBDataTextBox.Location = new System.Drawing.Point(264, 96);
            this.matrixBDataTextBox.Multiline = true;
            this.matrixBDataTextBox.Name = "matrixBDataTextBox";
            this.matrixBDataTextBox.Size = new System.Drawing.Size(48, 136);
            this.matrixBDataTextBox.TabIndex = 2;
            this.matrixBDataTextBox.Text = "2.00;\r\n12.00;\r\n10.00;";
            // 
            // matrixALabel
            // 
            this.matrixALabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.matrixALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.matrixALabel.Location = new System.Drawing.Point(72, 72);
            this.matrixALabel.Name = "matrixALabel";
            this.matrixALabel.Size = new System.Drawing.Size(16, 16);
            this.matrixALabel.TabIndex = 8;
            this.matrixALabel.Text = "A";
            // 
            // helpTextBox
            // 
            this.helpTextBox.Location = new System.Drawing.Point(8, 16);
            this.helpTextBox.Multiline = true;
            this.helpTextBox.Name = "helpTextBox";
            this.helpTextBox.ReadOnly = true;
            this.helpTextBox.Size = new System.Drawing.Size(208, 48);
            this.helpTextBox.TabIndex = 7;
            this.helpTextBox.TabStop = false;
            this.helpTextBox.Text = "Enter Matrix Data Row by Row.\r\nTerminate Each Row by a semicolon ( ; ).\r\nSeperate" +
                " elements in a row by comas ( , ).";
            // 
            // matrixADataTextBox
            // 
            this.matrixADataTextBox.Location = new System.Drawing.Point(8, 96);
            this.matrixADataTextBox.Multiline = true;
            this.matrixADataTextBox.Name = "matrixADataTextBox";
            this.matrixADataTextBox.Size = new System.Drawing.Size(152, 136);
            this.matrixADataTextBox.TabIndex = 0;
            this.matrixADataTextBox.Text = "4.00, 2.00, -1.00;\r\n1.00 ,4.00, 1.00;\r\n0.10, 1.00, 2.00;";
            // 
            // matrixBLabel
            // 
            this.matrixBLabel.Enabled = false;
            this.matrixBLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.matrixBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.matrixBLabel.Location = new System.Drawing.Point(280, 72);
            this.matrixBLabel.Name = "matrixBLabel";
            this.matrixBLabel.Size = new System.Drawing.Size(24, 16);
            this.matrixBLabel.TabIndex = 8;
            this.matrixBLabel.Text = "B";
            // 
            // operationsComboBox
            // 
            this.operationsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operationsComboBox.Items.AddRange(new object[] {
                                                                    "Determinant",
                                                                    "Trace",
                                                                    "Rank",
                                                                    "Condition Number",
                                                                    "Inverse",
                                                                    "PseudoInverse",
                                                                    "Norm",
                                                                    "TestPositiveDefinite",
                                                                    "Transpose",
                                                                    "Cholesky Factorization",
                                                                    "Eigen Values and Eigen Vectors",
                                                                    "LU Decomposition",
                                                                    "QR Factorization",
                                                                    "SolveLinearEquations (Ax = B)",
                                                                    "SingularValueDecomposition"});
            this.operationsComboBox.Location = new System.Drawing.Point(368, 176);
            this.operationsComboBox.Name = "operationsComboBox";
            this.operationsComboBox.Size = new System.Drawing.Size(192, 21);
            this.operationsComboBox.TabIndex = 1;
            this.operationsComboBox.SelectedIndexChanged += new System.EventHandler(this.operations_SelectedIndexChanged);
            // 
            // operationsLabel
            // 
            this.operationsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.operationsLabel.Location = new System.Drawing.Point(368, 160);
            this.operationsLabel.Name = "operationsLabel";
            this.operationsLabel.Size = new System.Drawing.Size(64, 32);
            this.operationsLabel.TabIndex = 2;
            this.operationsLabel.Text = "Operations";
            // 
            // normTypeComboBox
            // 
            this.normTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.normTypeComboBox.Enabled = false;
            this.normTypeComboBox.Items.AddRange(new object[] {
                                                                  "2-norm",
                                                                  "1-norm",
                                                                  "F-norm",
                                                                  "inf-norm"});
            this.normTypeComboBox.Location = new System.Drawing.Point(576, 176);
            this.normTypeComboBox.Name = "normTypeComboBox";
            this.normTypeComboBox.Size = new System.Drawing.Size(64, 21);
            this.normTypeComboBox.TabIndex = 2;
            // 
            // normTypeLabel
            // 
            this.normTypeLabel.Enabled = false;
            this.normTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.normTypeLabel.Location = new System.Drawing.Point(576, 160);
            this.normTypeLabel.Name = "normTypeLabel";
            this.normTypeLabel.Size = new System.Drawing.Size(72, 32);
            this.normTypeLabel.TabIndex = 5;
            this.normTypeLabel.Text = "Norm Type";
            // 
            // computeButton
            // 
            this.computeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.computeButton.Location = new System.Drawing.Point(440, 224);
            this.computeButton.Name = "computeButton";
            this.computeButton.Size = new System.Drawing.Size(136, 24);
            this.computeButton.TabIndex = 0;
            this.computeButton.Text = "Compute";
            this.toolTip.SetToolTip(this.computeButton, "Compute the result of the selected operation on input matrix.");
            this.computeButton.Click += new System.EventHandler(this.compute_Click);
            // 
            // operationsDataGrid
            // 
            this.operationsDataGrid.DataMember = "";
            this.operationsDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.operationsDataGrid.Location = new System.Drawing.Point(368, 16);
            this.operationsDataGrid.Name = "operationsDataGrid";
            this.operationsDataGrid.Size = new System.Drawing.Size(264, 128);
            this.operationsDataGrid.TabIndex = 8;
            this.operationsDataGrid.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
                                                                                                           this.table1});
            this.operationsDataGrid.TabStop = false;
            // 
            // table1
            // 
            this.table1.DataGrid = this.operationsDataGrid;
            this.table1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.table1.MappingName = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(656, 269);
            this.Controls.Add(this.operationsDataGrid);
            this.Controls.Add(this.computeButton);
            this.Controls.Add(this.inputMatricesGroupBox);
            this.Controls.Add(this.operationsComboBox);
            this.Controls.Add(this.operationsLabel);
            this.Controls.Add(this.normTypeComboBox);
            this.Controls.Add(this.normTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linear Algebra/Matrix Operations";
            this.inputMatricesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operationsDataGrid)).EndInit();
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

       

        // On click of compute button
        private void compute_Click(object sender, System.EventArgs e)
        { 
            int i,j;
            string []dataString;
            string []value1 = new string[1];
            double [,]matrixA;
            NationalInstruments.Analysis.Math.NormType normTypeValue = NormType.TwoNorm;
           
            computeClicked = 1; // set it to one when comput button is clicked.
            value1.Initialize();

            // create a data set.
            System.Data.DataSet data = new DataSet(" ");
            System.Data.DataTable table = data.Tables.Add(" "); // Attach a table to data set.

            try
            {

                matrixA = Read2DMatrix(matrixADataTextBox.Text); // read Matrix A.
                if ((matrixA.GetLength(0) == 0) || (matrixA.GetLength(1) == 0))
                {
                    throw new ArgumentException("Matrix A has incorrect number of rows or columns");
                }
            
                switch(operationsComboBox.SelectedIndex)
                {
                    case 0: //Determinant
                        double determinant = 0;
 
                        if(matrixA.GetLength(0) != matrixA.GetLength(1))
                            MessageBox.Show("Please enter a square matrix to perform this operation");
                        else
                        {
                            determinant = NationalInstruments.Analysis.Math.LinearAlgebra.Determinant(matrixA);
                            value1[0] = String.Format("{0:F2}", determinant);
                            table.TableName = "Determinant";
                            table.Columns.Add(" ");
                            table.Rows.Add(value1);
                            operationsDataGrid.CaptionText = "   Determinant of Matrix A";
                            operationsDataGrid.DataSource = data;
                        }
                        break;
                    case 1: // Trace
                        double trace = 0;

                        trace = NationalInstruments.Analysis.Math.LinearAlgebra.Trace(matrixA);
                        table.TableName = "Trace";
                        value1[0] = String.Format("{0:F2}", trace);
                        table.Columns.Add("  ");
                        table.Rows.Add(value1);
                        operationsDataGrid.CaptionText = "   Trace of Matrix A";
                        operationsDataGrid.DataSource = data;
                        break;
                    case 2: // Rank
                        int rank = 0;

                        rank = NationalInstruments.Analysis.Math.LinearAlgebra.Rank(matrixA, -1);
                        table.TableName = "Rank";
                        value1[0] = String.Format("{0:F2}", rank);
                        table.Columns.Add("  ");
                        table.Rows.Add(value1);
                        operationsDataGrid.CaptionText = "   Rank of Matrix A";
                        operationsDataGrid.DataSource = data;
                   
                        break;
                    case 3: // Condition Number.
                        double conditionNumber = 0;

                    switch(normTypeComboBox.SelectedIndex)
                    {
                        case 0: //2-norm.
                        default:
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.TwoNorm;
                            break;
                        case 1: // 1-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.OneNorm;
                            break;
                        case 2: // F-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.FrobeniusNorm;
                            break;
                        case 3: // I-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.InfiniteNorm;
                            break;
                    }
                        conditionNumber = NationalInstruments.Analysis.Math.LinearAlgebra.ConditionNumber(matrixA, normTypeValue);
                        table.TableName = "ConditionNumber";
                        value1[0] = String.Format("{0:F2}", conditionNumber);
                        table.Columns.Add("  ");
                        table.Rows.Add(value1);
                        operationsDataGrid.CaptionText = "   Condition Number of Matrix A";
                        operationsDataGrid.DataSource = data;
                        break;
                    case 4: // Inverse Matrix
                        double [,]inverseMatrix;

                        if(matrixA.GetLength(0) != matrixA.GetLength(1))
                            MessageBox.Show("Please enter a square matrix to perform this operation");
                        else
                        {
                            inverseMatrix = NationalInstruments.Analysis.Math.LinearAlgebra.Inverse(matrixA);
                            dataString = new string[(int)matrixA.GetLength(0)];
                       
                            table.TableName = "InverseMatrix";
                            for(i=0; i<(int)matrixA.GetLength(0); i++)
                            {
                                table.Columns.Add();
                            }
                            for (i=0; i< (int)matrixA.GetLength(0); i++)
                            {
                                for (j =0; j< (int)matrixA.GetLength(0); j++)
                                {
                                    dataString[j] = String.Format("{0:F2}", inverseMatrix[i,j]);
                                }
                                table.Rows.Add(dataString);
                            }
                            operationsDataGrid.CaptionText = "   Inverse of Matrix A";
                            operationsDataGrid.DataSource = data; 
                        }
                        break;
                    case 5: // Pseudo Inverse Matrix.
                        double [,]pseudoInverse;

                        pseudoInverse = NationalInstruments.Analysis.Math.LinearAlgebra.PseudoInverse(matrixA, -1);
                        dataString = new string[(int)pseudoInverse.GetLength(1)];
                        table.TableName = " Pseudo Inverse";
                        for(i=0; i<(int)pseudoInverse.GetLength(1); i++)
                        {
                            table.Columns.Add();
                        }
                        for (i=0; i< (int)pseudoInverse.GetLength(0); i++)
                        {
                            for (j =0; j< (int)pseudoInverse.GetLength(1); j++)
                            {
                                dataString[j] = String.Format("{0:F2}", pseudoInverse[i,j]);
                            }
                            table.Rows.Add(dataString);
                        }
                        operationsDataGrid.CaptionText = "   Pseudo Inverse of Matrix A";
                        operationsDataGrid.DataSource = data; 
                        break;
                    case 6: // Norm of the Marix.
                        double norm = 0;

                    switch(normTypeComboBox.SelectedIndex)
                    {
                        case 0: // 2-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.TwoNorm;
                            break;
                        case 1: // 1-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.OneNorm;
                            break;
                        case 2: // F-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.FrobeniusNorm;
                            break;
                        case 3: // I-norm.
                            normTypeValue = NationalInstruments.Analysis.Math.NormType.InfiniteNorm;
                            break;
                    }
                        norm = NationalInstruments.Analysis.Math.LinearAlgebra.Norm(matrixA, normTypeValue);
                        table.TableName = "Norm";
                        value1[0] = String.Format("{0:F2}", norm);
                        table.Columns.Add("  ");
                        table.Rows.Add(value1);
                        operationsDataGrid.CaptionText = "   Norm of Matrix A";
                        operationsDataGrid.DataSource = data;
                        break;
                    case 7: // Is PositiveDefinite?
                        bool isPositiveDefinite = false;

                        if(matrixA.GetLength(0) != matrixA.GetLength(1))
                            MessageBox.Show("Please enter a square matrix to perform this operation");
                        else
                        {
                            isPositiveDefinite = NationalInstruments.Analysis.Math.LinearAlgebra.IsPositiveDefinite(matrixA);
                            table.TableName = "isPositiveDefinite?";
                            if(isPositiveDefinite == false)
                                value1[0] = "False";
                            else
                                value1[0] = "True";
                            table.Columns.Add("  ");
                            table.Rows.Add(value1);
                            operationsDataGrid.CaptionText = "Test Positive Definite of Matrix A";
                            operationsDataGrid.DataSource = data;
                        }
                        break;
                    case 8: // Transpose
                        double [,]transpose;
                    
                        transpose = NationalInstruments.Analysis.Math.LinearAlgebra.Transpose(matrixA);
                        dataString = new string[(int)transpose.GetLength(1)];
                        table.TableName = " Transpose";
                        for(i=0; i<(int)transpose.GetLength(1); i++)
                        {
                            table.Columns.Add();
                        }
                        for (i=0; i< (int)transpose.GetLength(0); i++)
                        {
                            for (j =0; j< (int)transpose.GetLength(1); j++)
                            {
                                dataString[j] = String.Format("{0:F2}", transpose[i,j]);
                            }
                            table.Rows.Add(dataString);
                        }
                        operationsDataGrid.CaptionText = "   Transpose of Matrix A";
                        operationsDataGrid.DataSource = data; 
                        break;
                    case 9: // Cholesky Factorization.
                        double [,]choleskyFactorization;

                        if(matrixA.GetLength(0) != matrixA.GetLength(1))
                            MessageBox.Show("Please enter a square and non singular matrix to perform this operation");
                        else if(NationalInstruments.Analysis.Math.LinearAlgebra.IsPositiveDefinite(matrixA) == false)
                            MessageBox.Show("Input matrix is non singular.", "Error");
                        else
                        {
                            choleskyFactorization = new double[matrixA.GetLength(1), matrixA.GetLength(0)];
                            choleskyFactorization = NationalInstruments.Analysis.Math.LinearAlgebra.CholeskyFactorization(matrixA);
                            dataString = new string[(int)choleskyFactorization.GetLength(1)];
                            table.TableName = " CholeskyFactorization";
                            for(i=0; i<(int)choleskyFactorization.GetLength(1); i++)
                            {
                                table.Columns.Add();
                            }
                            for (i=0; i< (int)choleskyFactorization.GetLength(0); i++)
                            {
                                for (j =0; j< (int)choleskyFactorization.GetLength(1); j++)
                                {
                                    dataString[j] = String.Format("{0:F2}", choleskyFactorization[i,j]);
                                }
                                table.Rows.Add(dataString);
                            }
                       
                            operationsDataGrid.CaptionText = "Cholesky Factorization of Matrix A";
                            operationsDataGrid.DataSource = data; 
                        }
                        break;
                    case 10: // Eigen Values and Eigen Vectors.
                        NationalInstruments.ComplexDouble []eigenValues;
                        NationalInstruments.ComplexDouble [,]eigenVectors;

                        if(matrixA.GetLength(0) != matrixA.GetLength(1))
                            MessageBox.Show("Please enter a square matrix to perform this operation");
                        else
                        {
                            eigenValues = new NationalInstruments.ComplexDouble[matrixA.GetLength(0)];
                            eigenValues = NationalInstruments.Analysis.Math.LinearAlgebra.GeneralEigenValueVector(matrixA, out eigenVectors);
                            // Display Eigen Values in a data set table.
                            dataString = new string[1];

                            table.TableName = " Eigen Values";
                            table.Columns.Add(" ");
                        
                            for (i=0; i< (int)eigenValues.GetLength(0); i++)
                            {
                                dataString[0] = String.Format("{0:F2}", eigenValues[i]);
                                table.Rows.Add(dataString);
                            }
                            operationsDataGrid.CaptionText = "Eigen Values and Eigen Vectors of Matrix A";
                            operationsDataGrid.DataSource = data; 
                            // Display eigen vectors in another table.
                            System.Data.DataTable table2 = data.Tables.Add("Eigen Vectors ");
                            dataString = new string[(int)eigenVectors.GetLength(1)];
                        
                            for(i=0; i<(int)eigenVectors.GetLength(1); i++)
                            {
                                table2.Columns.Add();
                            }
                            for (i=0; i< (int)eigenVectors.GetLength(0); i++)
                            {
                                for (j =0; j< (int)eigenVectors.GetLength(1); j++)
                                {
                                    dataString[j] = String.Format("{0:F2}", eigenVectors[i,j]);
                                }
                                table2.Rows.Add(dataString);
                            }
                       
                            operationsDataGrid.DataSource = data; 
                        }
                        break;
                    case 11: // LU Factorization.
                        int sign;
                        int []permutationVector;
                        double [,]luFactorize;
                    
                        if(matrixA.GetLength(0) != matrixA.GetLength(1))
                            MessageBox.Show("Please enter a square matrix to perform this operation");
                        else
                        {
                            luFactorize = NationalInstruments.Analysis.Math.LinearAlgebra.LUFactorization(matrixA, out permutationVector, out sign);
                            dataString = new string[(int)luFactorize.GetLength(1)];
                            table.TableName = "LUFactorization";
                            for(i=0; i<(int)luFactorize.GetLength(1); i++)
                            {
                                table.Columns.Add();
                            }
                            for (i=0; i< (int)luFactorize.GetLength(0); i++)
                            {
                                for (j =0; j< (int)luFactorize.GetLength(1); j++)
                                {
                                    dataString[j] = String.Format("{0:F2}", luFactorize[i,j]);
                                }
                                table.Rows.Add(dataString);
                            }
                            operationsDataGrid.CaptionText = "LU Factorization of Matrix A";
                            operationsDataGrid.DataSource = data; 
                        }
                        break;
                
                    case 12: // QR Factorization.
                        double [,]qMatrix;
                        double [,]rMatrix; 

						NationalInstruments.Analysis.Math.LinearAlgebra.QRFactorization(matrixA,SizeOption.Economy,out rMatrix, out qMatrix);
                        // Display Q Matrix.
                        dataString = new string[qMatrix.GetLength(1)];

                        table.TableName = "Q Matrix";
                        for(i=0; i<(int)qMatrix.GetLength(1); i++)
                        {
                            table.Columns.Add();
                        }
                        for (i=0; i< (int)qMatrix.GetLength(0); i++)
                        {
                            for (j =0; j< (int)qMatrix.GetLength(1); j++)
                            {
                                dataString[j] = String.Format("{0:F2}", qMatrix[i,j]);
                            }
                            table.Rows.Add(dataString);
                        }
                        operationsDataGrid.CaptionText = "QR Factorization of Matrix A";
                        operationsDataGrid.DataSource = data; 
                        // Display R Matrix.
                        System.Data.DataTable table3 = data.Tables.Add("R Matrix ");
                        dataString = new string[(int)rMatrix.GetLength(1)];
                        for(i=0; i<(int)rMatrix.GetLength(1); i++)
                        {
                            table3.Columns.Add();
                        }
                        for (i=0; i< (int)rMatrix.GetLength(0); i++)
                        {
                            for (j =0; j< (int)rMatrix.GetLength(1); j++)
                            {
                                dataString[j] = String.Format("{0:F2}", rMatrix[i,j]);
                            }
                            table3.Rows.Add(dataString);
                        }
                   
                        operationsDataGrid.DataSource = data; 
                        break;
                    case 13: //Solve Linear Equations.
                        double []arrayB;
                        double []solutionMatrix;
                        string []rowStringArray;
                    
                        if(matrixA.GetLength(0) != matrixA.GetLength(1))
                            MessageBox.Show("Please enter a square matrix to perform this operation");
                        else
                        {
                            arrayB = Read1DMatrix(matrixBDataTextBox.Text);
							solutionMatrix = NationalInstruments.Analysis.Math.LinearAlgebra.SolveLinearEquationsSingleRightHand(matrixA,MatrixType.General,arrayB);
                            dataString = new string[1];
                            rowStringArray = new string[(int)solutionMatrix.Length];
                            table.TableName = "Solution x to Ax = B";
                            table.Columns.Add(" ");
                       
                            for (i=0; i< (int)solutionMatrix.GetLength(0); i++)
                            {
                                dataString[0] = String.Format("{0:F2}", solutionMatrix[i]);
                                rowStringArray[i] = String.Format("{0:F2}", solutionMatrix[i]);
                                table.Rows.Add(dataString);
                            
                            }
                            matrixXDataTextBox.Text = String.Join("\r\n", rowStringArray);
                            operationsDataGrid.CaptionText = " Solution x to Ax = B";
                            operationsDataGrid.DataSource = data; 
                        }
                        break;
                    case 14: // Singular Value Decomposition. 
                        double [,]uMatrix;
                        double [,]vMatrix;
                   
                        double []singularValues = NationalInstruments.Analysis.Math.LinearAlgebra.SvdFactorization(matrixA,SizeOption.Economy, out uMatrix, out vMatrix);
                        // Display of singular values.
                        dataString = new string[1];

                        table.TableName = "Singular Values";
                        table.Columns.Add(" ");
                    
                        for (i=0; i< (int)singularValues.GetLength(0); i++)
                        {
                            dataString[0] = String.Format("{0:F2}", singularValues[i]);
                            table.Rows.Add(dataString);
                        }
                        operationsDataGrid.CaptionText = "Singular Value Decomposition of MatrixA";
                        operationsDataGrid.DataSource = data; 
                        // To display U matrix.
                        DataTable table4 = data.Tables.Add("SVD of A - U ");
                        dataString = new string[(int)uMatrix.GetLength(1)];
                    
                        for(i=0; i<(int)uMatrix.GetLength(1); i++)
                        {
                            table4.Columns.Add();
                        }
                        for (i=0; i< (int)uMatrix.GetLength(0); i++)
                        {
                            for (j =0; j< (int)uMatrix.GetLength(1); j++)
                            {
                                dataString[j] = String.Format("{0:F2}", uMatrix[i,j]);
                            }
                            table4.Rows.Add(dataString);
                        }
                        // Display V - Matrix.
                        DataTable table5 = data.Tables.Add("SVD of A - V ");
                        dataString = new string[(int)vMatrix.GetLength(1)];
                    
                        for(i=0; i<(int)vMatrix.GetLength(1); i++)
                        {
                            table5.Columns.Add();
                        }
                        for (i=0; i< (int)vMatrix.GetLength(0); i++)
                        {
                            for (j =0; j< (int)vMatrix.GetLength(1); j++)
                            {
                                dataString[j] = String.Format("{0:F2}", vMatrix[i,j]);
                            }
                            table5.Rows.Add(dataString);
                        }
                   
                        operationsDataGrid.DataSource = data; 
                        break;
                }  
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        // Read 2D Matrix from the mainForm.cs panel.
        double[,] Read2DMatrix(string matrixData)
        {
            int rowIndex, columnIndex, numFirstRowElements=0;
            string []splitRows;
            string []splitDataByColumns;
            double [,]matrix;
            
            // store rows of Matrix in to splitRows string array.
            splitRows = System.Text.RegularExpressions.Regex.Split(matrixData,";", System.Text.RegularExpressions.RegexOptions.Multiline);
            
            // Memory Allocation for matrix.
            matrix = new double[(int)splitRows.Length - 1, (int)splitRows.Length - 1];
           
            for(rowIndex=0; rowIndex < splitRows.Length - 1; rowIndex++)
            {
                splitDataByColumns = System.Text.RegularExpressions.Regex.Split(splitRows[rowIndex],",");
                if(rowIndex == 0)
                {
                    numFirstRowElements = splitDataByColumns.Length;
                    matrix = new double[(int)splitRows.Length - 1, (int)splitDataByColumns.Length];
                }
                else
                {
                    if (numFirstRowElements != splitDataByColumns.Length)
                    {
                        //means that all of the columns dont' have equal number of elements!
                        throw new ArgumentException(String.Concat("Number of columns is incorrect for Row ",(rowIndex)));
                    }
                }
                    
                for(columnIndex=0; columnIndex < splitDataByColumns.Length; columnIndex++)
                {
                    matrix[rowIndex, columnIndex] = System.Convert.ToDouble(splitDataByColumns[columnIndex]);
                }
            }
            return matrix;
        }

        // Read 1D Matrix.
        double[] Read1DMatrix(string matrixData)
        {
            string []splitRows;
            int i;
            double []matrix;

            splitRows = System.Text.RegularExpressions.Regex.Split(matrixData, ";");
            matrix = new double[(int)splitRows.Length - 1];
            for( i=0; i < splitRows.Length - 1; i++)
            {
                matrix[i] = System.Convert.ToDouble(splitRows[i]);
            }
            return matrix;
        }
       
        // As the index of operations selection changes.
        private void operations_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if(operationsComboBox.SelectedIndex == 3 || operationsComboBox.SelectedIndex == 6 )
            {
                normTypeComboBox.Enabled = true;
                normTypeLabel.Enabled = true;
            }
            else
            {
                normTypeComboBox.Enabled = false;
                normTypeLabel.Enabled = false;
            }
            if(operationsComboBox.SelectedIndex == 13)
            {
                matrixBDataTextBox.Enabled = true;
                matrixBLabel.Enabled = true;
                matrixXLabel.Enabled = true;
                matrixXDataTextBox.Enabled = true;
                linearEquationLabel.Enabled = true;
            }
            else
            {
                matrixBDataTextBox.Enabled = false;
                matrixBLabel.Enabled = false;
                matrixXLabel.Enabled = false;
                matrixXDataTextBox.Enabled = false;
                linearEquationLabel.Enabled = false;
            }
            if(computeClicked == 1)
                computeButton.PerformClick();
        }

	}
}
