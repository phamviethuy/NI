'==================================================================================================
'
' Title      : MainForm.vb
' Purpose    : This example shows the user how to use the probabilty distribution and statistical functions.
'
'==================================================================================================

Public Class MainForm
    Inherits System.Windows.Forms.Form

    'Global Variables
    Dim buffer() As Double
    Dim counter As Integer = 0

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
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
    Friend WithEvents confidenceLevelLabel As System.Windows.Forms.Label
    Friend WithEvents dataPointsLabel As System.Windows.Forms.Label
    Friend WithEvents standardDeviationLabel As System.Windows.Forms.Label
    Friend WithEvents degreesOfFreedomLabel As System.Windows.Forms.Label
    Friend WithEvents meanLabel As System.Windows.Forms.Label
    Friend WithEvents userHelpLabel As System.Windows.Forms.Label
    Friend WithEvents dataPointsEnteredLabel As System.Windows.Forms.Label
    Friend WithEvents numberOfSamplesLabel As System.Windows.Forms.Label
    Friend WithEvents helpLabel As System.Windows.Forms.Label
    Friend WithEvents inputDataGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents inputDataPointsGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents predictedParametersGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents confidenceLevelNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents dataPointsNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents degreesOfFreedomNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents standardDeviationNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents dataPointsEnteredNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents enterValueButton As System.Windows.Forms.Button
    Friend WithEvents meanTextBox As System.Windows.Forms.TextBox


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.inputDataGroupBox = New System.Windows.Forms.GroupBox
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.userHelpLabel = New System.Windows.Forms.Label
        Me.inputDataPointsGroupBox = New System.Windows.Forms.GroupBox
        Me.confidenceLevelNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.dataPointsNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.dataPointsLabel = New System.Windows.Forms.Label
        Me.confidenceLevelLabel = New System.Windows.Forms.Label
        Me.numberOfSamplesLabel = New System.Windows.Forms.Label
        Me.enterValueButton = New System.Windows.Forms.Button
        Me.meanTextBox = New System.Windows.Forms.TextBox
        Me.dataPointsEnteredLabel = New System.Windows.Forms.Label
        Me.standardDeviationLabel = New System.Windows.Forms.Label
        Me.degreesOfFreedomLabel = New System.Windows.Forms.Label
        Me.meanLabel = New System.Windows.Forms.Label
        Me.predictedParametersGroupBox = New System.Windows.Forms.GroupBox
        Me.degreesOfFreedomNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.standardDeviationNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.helpLabel = New System.Windows.Forms.Label
        Me.dataPointsEnteredNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.inputDataGroupBox.SuspendLayout()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.inputDataPointsGroupBox.SuspendLayout()
        CType(Me.confidenceLevelNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataPointsNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.predictedParametersGroupBox.SuspendLayout()
        CType(Me.degreesOfFreedomNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.standardDeviationNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataPointsEnteredNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'inputDataGroupBox
        '
        Me.inputDataGroupBox.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.inputDataGroupBox.Controls.Add(Me.userHelpLabel)
        Me.inputDataGroupBox.Controls.Add(Me.inputDataPointsGroupBox)
        Me.inputDataGroupBox.Controls.Add(Me.numberOfSamplesLabel)
        Me.inputDataGroupBox.Controls.Add(Me.enterValueButton)
        Me.inputDataGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.inputDataGroupBox.Location = New System.Drawing.Point(16, 16)
        Me.inputDataGroupBox.Name = "inputDataGroupBox"
        Me.inputDataGroupBox.Size = New System.Drawing.Size(232, 264)
        Me.inputDataGroupBox.TabIndex = 0
        Me.inputDataGroupBox.TabStop = False
        Me.inputDataGroupBox.Text = "Input Data Points"
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(136, 94)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.Range = New NationalInstruments.UI.Range(2, Double.PositiveInfinity)
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(64, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 2
        Me.numberOfSamplesNumericEdit.Value = 2
        '
        'userHelpLabel
        '
        Me.userHelpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.userHelpLabel.Location = New System.Drawing.Point(24, 24)
        Me.userHelpLabel.Name = "userHelpLabel"
        Me.userHelpLabel.Size = New System.Drawing.Size(192, 56)
        Me.userHelpLabel.TabIndex = 1
        Me.userHelpLabel.Text = "Use the 'Enter Value' button to specify 2 to 100 data samples. Input the value of" & _
        " each data point with confidence level."
        '
        'inputDataPointsGroupBox
        '
        Me.inputDataPointsGroupBox.Controls.Add(Me.confidenceLevelNumericEdit)
        Me.inputDataPointsGroupBox.Controls.Add(Me.dataPointsNumericEdit)
        Me.inputDataPointsGroupBox.Controls.Add(Me.dataPointsLabel)
        Me.inputDataPointsGroupBox.Controls.Add(Me.confidenceLevelLabel)
        Me.inputDataPointsGroupBox.Location = New System.Drawing.Point(16, 136)
        Me.inputDataPointsGroupBox.Name = "inputDataPointsGroupBox"
        Me.inputDataPointsGroupBox.Size = New System.Drawing.Size(120, 112)
        Me.inputDataPointsGroupBox.TabIndex = 3
        Me.inputDataPointsGroupBox.TabStop = False
        Me.inputDataPointsGroupBox.Text = "Data"
        '
        'confidenceLevelNumericEdit
        '
        Me.confidenceLevelNumericEdit.CoercionInterval = 0.01
        Me.confidenceLevelNumericEdit.CoercionMode = NationalInstruments.UI.NumericCoercionMode.ToInterval
        Me.confidenceLevelNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.confidenceLevelNumericEdit.Location = New System.Drawing.Point(16, 80)
        Me.confidenceLevelNumericEdit.Name = "confidenceLevelNumericEdit"
        Me.confidenceLevelNumericEdit.Range = New NationalInstruments.UI.Range(0.01, 0.99)
        Me.confidenceLevelNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.confidenceLevelNumericEdit.TabIndex = 1
        Me.confidenceLevelNumericEdit.Value = 0.9
        '
        'dataPointsNumericEdit
        '
        Me.dataPointsNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.dataPointsNumericEdit.Location = New System.Drawing.Point(16, 32)
        Me.dataPointsNumericEdit.Name = "dataPointsNumericEdit"
        Me.dataPointsNumericEdit.Range = New NationalInstruments.UI.Range(0, 10)
        Me.dataPointsNumericEdit.Size = New System.Drawing.Size(80, 20)
        Me.dataPointsNumericEdit.TabIndex = 0
        Me.dataPointsNumericEdit.Value = 1
        '
        'dataPointsLabel
        '
        Me.dataPointsLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dataPointsLabel.Location = New System.Drawing.Point(16, 16)
        Me.dataPointsLabel.Name = "dataPointsLabel"
        Me.dataPointsLabel.Size = New System.Drawing.Size(64, 16)
        Me.dataPointsLabel.TabIndex = 10
        Me.dataPointsLabel.Text = "Data Point:"
        '
        'confidenceLevelLabel
        '
        Me.confidenceLevelLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.confidenceLevelLabel.Location = New System.Drawing.Point(16, 64)
        Me.confidenceLevelLabel.Name = "confidenceLevelLabel"
        Me.confidenceLevelLabel.Size = New System.Drawing.Size(96, 16)
        Me.confidenceLevelLabel.TabIndex = 11
        Me.confidenceLevelLabel.Text = "Confidence Level:"
        '
        'numberOfSamplesLabel
        '
        Me.numberOfSamplesLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.numberOfSamplesLabel.Location = New System.Drawing.Point(24, 96)
        Me.numberOfSamplesLabel.Name = "numberOfSamplesLabel"
        Me.numberOfSamplesLabel.Size = New System.Drawing.Size(112, 16)
        Me.numberOfSamplesLabel.TabIndex = 13
        Me.numberOfSamplesLabel.Text = "Number of Samples:"
        '
        'enterValueButton
        '
        Me.enterValueButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.enterValueButton.Location = New System.Drawing.Point(144, 180)
        Me.enterValueButton.Name = "enterValueButton"
        Me.enterValueButton.Size = New System.Drawing.Size(80, 24)
        Me.enterValueButton.TabIndex = 4
        Me.enterValueButton.Text = "Enter Value"
        '
        'meanTextBox
        '
        Me.meanTextBox.Location = New System.Drawing.Point(24, 152)
        Me.meanTextBox.Name = "meanTextBox"
        Me.meanTextBox.ReadOnly = True
        Me.meanTextBox.Size = New System.Drawing.Size(128, 20)
        Me.meanTextBox.TabIndex = 7
        Me.meanTextBox.TabStop = False
        Me.meanTextBox.Text = ""
        '
        'dataPointsEnteredLabel
        '
        Me.dataPointsEnteredLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dataPointsEnteredLabel.Location = New System.Drawing.Point(272, 50)
        Me.dataPointsEnteredLabel.Name = "dataPointsEnteredLabel"
        Me.dataPointsEnteredLabel.Size = New System.Drawing.Size(112, 16)
        Me.dataPointsEnteredLabel.TabIndex = 12
        Me.dataPointsEnteredLabel.Text = "Data Points Entered:"
        '
        'standardDeviationLabel
        '
        Me.standardDeviationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.standardDeviationLabel.Location = New System.Drawing.Point(24, 24)
        Me.standardDeviationLabel.Name = "standardDeviationLabel"
        Me.standardDeviationLabel.Size = New System.Drawing.Size(128, 16)
        Me.standardDeviationLabel.TabIndex = 13
        Me.standardDeviationLabel.Text = "Standard Deviation:"
        '
        'degreesOfFreedomLabel
        '
        Me.degreesOfFreedomLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.degreesOfFreedomLabel.Location = New System.Drawing.Point(24, 80)
        Me.degreesOfFreedomLabel.Name = "degreesOfFreedomLabel"
        Me.degreesOfFreedomLabel.Size = New System.Drawing.Size(112, 16)
        Me.degreesOfFreedomLabel.TabIndex = 10
        Me.degreesOfFreedomLabel.Text = "Degrees of Freedom:"
        '
        'meanLabel
        '
        Me.meanLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.meanLabel.Location = New System.Drawing.Point(24, 136)
        Me.meanLabel.Name = "meanLabel"
        Me.meanLabel.Size = New System.Drawing.Size(40, 16)
        Me.meanLabel.TabIndex = 11
        Me.meanLabel.Text = "Mean:"
        '
        'predictedParametersGroupBox
        '
        Me.predictedParametersGroupBox.Controls.Add(Me.degreesOfFreedomNumericEdit)
        Me.predictedParametersGroupBox.Controls.Add(Me.standardDeviationNumericEdit)
        Me.predictedParametersGroupBox.Controls.Add(Me.standardDeviationLabel)
        Me.predictedParametersGroupBox.Controls.Add(Me.degreesOfFreedomLabel)
        Me.predictedParametersGroupBox.Controls.Add(Me.meanLabel)
        Me.predictedParametersGroupBox.Controls.Add(Me.meanTextBox)
        Me.predictedParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.predictedParametersGroupBox.Location = New System.Drawing.Point(264, 88)
        Me.predictedParametersGroupBox.Name = "predictedParametersGroupBox"
        Me.predictedParametersGroupBox.Size = New System.Drawing.Size(176, 192)
        Me.predictedParametersGroupBox.TabIndex = 14
        Me.predictedParametersGroupBox.TabStop = False
        Me.predictedParametersGroupBox.Text = "Predicted Parameters"
        '
        'degreesOfFreedomNumericEdit
        '
        Me.degreesOfFreedomNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.degreesOfFreedomNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.degreesOfFreedomNumericEdit.Location = New System.Drawing.Point(24, 96)
        Me.degreesOfFreedomNumericEdit.Name = "degreesOfFreedomNumericEdit"
        Me.degreesOfFreedomNumericEdit.TabIndex = 14
        Me.degreesOfFreedomNumericEdit.TabStop = False
        '
        'standardDeviationNumericEdit
        '
        Me.standardDeviationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(5)
        Me.standardDeviationNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.standardDeviationNumericEdit.Location = New System.Drawing.Point(24, 40)
        Me.standardDeviationNumericEdit.Name = "standardDeviationNumericEdit"
        Me.standardDeviationNumericEdit.TabIndex = 14
        Me.standardDeviationNumericEdit.TabStop = False
        '
        'helpLabel
        '
        Me.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.helpLabel.Location = New System.Drawing.Point(16, 296)
        Me.helpLabel.Name = "helpLabel"
        Me.helpLabel.Size = New System.Drawing.Size(424, 40)
        Me.helpLabel.TabIndex = 15
        Me.helpLabel.Text = "In this example, the input data represents the mean time between failures in hour" & _
        "s. The Predicted Parameters estimate when the next failure will occur with a var" & _
        "iable confidence level."
        '
        'dataPointsEnteredNumericEdit
        '
        Me.dataPointsEnteredNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.dataPointsEnteredNumericEdit.InteractionMode = NationalInstruments.UI.NumericEditInteractionModes.Indicator
        Me.dataPointsEnteredNumericEdit.Location = New System.Drawing.Point(384, 48)
        Me.dataPointsEnteredNumericEdit.Name = "dataPointsEnteredNumericEdit"
        Me.dataPointsEnteredNumericEdit.Size = New System.Drawing.Size(56, 20)
        Me.dataPointsEnteredNumericEdit.TabIndex = 16
        Me.dataPointsEnteredNumericEdit.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(458, 349)
        Me.Controls.Add(Me.dataPointsEnteredNumericEdit)
        Me.Controls.Add(Me.helpLabel)
        Me.Controls.Add(Me.predictedParametersGroupBox)
        Me.Controls.Add(Me.dataPointsEnteredLabel)
        Me.Controls.Add(Me.inputDataGroupBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistical Failure Prediction"
        Me.inputDataGroupBox.ResumeLayout(False)
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.inputDataPointsGroupBox.ResumeLayout(False)
        CType(Me.confidenceLevelNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataPointsNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.predictedParametersGroupBox.ResumeLayout(False)
        CType(Me.degreesOfFreedomNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.standardDeviationNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataPointsEnteredNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub
    '
    ' On click of PedictStatisticalFailure button.
    '
    Private Sub CalculateStatisticalFailure()
        'Initialization
        Dim probability As Double
        Dim deviation As Double
        Dim meanValue As Double
        Dim result As Double
        Dim confidence As Double
        Dim width As Double
        Dim widthString As String
        Dim meanString As String

        confidence = confidenceLevelNumericEdit.Value
        probability = (1 - confidence) / 2 + confidence
        result = NationalInstruments.Analysis.Math.Probability.InverseTDistribution(probability, counter - 1)
        meanValue = NationalInstruments.Analysis.Math.Statistics.Mean(buffer)
        deviation = NationalInstruments.Analysis.Math.Statistics.StandardDeviation(buffer)
        width = deviation * (result * 1 / System.Math.Sqrt(counter))
        degreesOfFreedomNumericEdit.Value = counter - 1
        standardDeviationNumericEdit.Text = deviation
        widthString = String.Format("{0:F5} ", width)
        meanString = String.Format("{0:F5} ", meanValue)
        meanTextBox.Text = String.Concat(meanString, " +/- ", widthString)

        numberOfSamplesNumericEdit.Enabled = True
        numberOfSamplesLabel.Enabled = True
        dataPointsNumericEdit.Enabled = False
        confidenceLevelNumericEdit.Enabled = False
        dataPointsLabel.Enabled = False
        confidenceLevelLabel.Enabled = False
        counter = 0
        numberOfSamplesNumericEdit.Focus()
    End Sub


    '
    ' When the EnterValue button is clicked
    '
    Private Sub enterValue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enterValueButton.Click
        If counter = 0 Then
            buffer = New Double(numberOfSamplesNumericEdit.Value) {}
            numberOfSamplesNumericEdit.Enabled = False
            numberOfSamplesLabel.Enabled = False
        End If

        buffer(counter) = dataPointsNumericEdit.Value 'Fill the buffer as dataPoints are enetered.
        counter = counter + 1               'Increment the counter each time enterValue button if clicked.

        'To show how many data points have been entered.
        dataPointsEnteredNumericEdit.Value = counter

        If counter >= numberOfSamplesNumericEdit.Value Then
            enterValueButton.Enabled = False
            CalculateStatisticalFailure()
        End If
    End Sub
    ' When the value of dataPointsEntered control is changed by the user.
    Private Sub numberOfSamples_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numberOfSamplesNumericEdit.ValueChanged
        dataPointsNumericEdit.Enabled = True
        dataPointsLabel.Enabled = True
        confidenceLevelNumericEdit.Enabled = True
        confidenceLevelLabel.Enabled = True
        enterValueButton.Enabled = True
        dataPointsEnteredNumericEdit.Value = 0
        standardDeviationNumericEdit.Value = 0.0
        degreesOfFreedomNumericEdit.Value = 0.0
        meanTextBox.Clear()
    End Sub
End Class
