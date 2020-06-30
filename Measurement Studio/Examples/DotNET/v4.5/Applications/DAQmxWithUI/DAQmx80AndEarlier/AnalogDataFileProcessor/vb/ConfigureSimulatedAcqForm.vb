' Form used to configure a simulated data acquisition. The caller 
' creates a BasicFunctionGenerator instance and passes it to the
' constructor of this ConfigureSimulatedAcqForm. 
' If ConfigureSimulatedAcqForm.ShowDialog() return DialogResult.OK,
' the user successfully configured the BasicFunctionGenerator instance.
Public Class ConfigureSimulatedAcqForm
    Inherits System.Windows.Forms.Form

    Private dataGenerator As BasicFunctionGenerator

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal simulatedDataGenerator As BasicFunctionGenerator)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        '
        ' Populate the combo box with all of the possible signal types.
        '
        signalTypeComboBox.Items.AddRange([Enum].GetNames(GetType(BasicFunctionGeneratorSignal)))

        dataGenerator = simulatedDataGenerator

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
    Friend WithEvents okButton As System.Windows.Forms.Button
    Friend WithEvents samplingRateNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents phaseNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents offsetNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents numberOfSamplesNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents frequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents dutyCycleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents amplitudeNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Friend WithEvents samplingRateLabel As System.Windows.Forms.Label
    Friend WithEvents phaseLabel As System.Windows.Forms.Label
    Friend WithEvents offsetLabel As System.Windows.Forms.Label
    Friend WithEvents numberOfSamplesLabel As System.Windows.Forms.Label
    Friend WithEvents frequencyLabel As System.Windows.Forms.Label
    Friend WithEvents dutyCycleLabel As System.Windows.Forms.Label
    Friend WithEvents amplitudeLabel As System.Windows.Forms.Label
    Friend WithEvents signalTypeLabel As System.Windows.Forms.Label
    Friend WithEvents signalTypeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents _cancelButton As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._cancelButton = New System.Windows.Forms.Button
        Me.okButton = New System.Windows.Forms.Button
        Me.samplingRateNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.phaseNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.offsetNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.numberOfSamplesNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.frequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.dutyCycleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.amplitudeNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit
        Me.samplingRateLabel = New System.Windows.Forms.Label
        Me.phaseLabel = New System.Windows.Forms.Label
        Me.offsetLabel = New System.Windows.Forms.Label
        Me.numberOfSamplesLabel = New System.Windows.Forms.Label
        Me.frequencyLabel = New System.Windows.Forms.Label
        Me.dutyCycleLabel = New System.Windows.Forms.Label
        Me.amplitudeLabel = New System.Windows.Forms.Label
        Me.signalTypeLabel = New System.Windows.Forms.Label
        Me.signalTypeComboBox = New System.Windows.Forms.ComboBox
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.phaseNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.offsetNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dutyCycleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.amplitudeNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_cancelButton
        '
        Me._cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me._cancelButton.Location = New System.Drawing.Point(154, 330)
        Me._cancelButton.Name = "_cancelButton"
        Me._cancelButton.TabIndex = 35
        Me._cancelButton.Text = "&Cancel"
        '
        'okButton
        '
        Me.okButton.Location = New System.Drawing.Point(58, 330)
        Me.okButton.Name = "okButton"
        Me.okButton.TabIndex = 34
        Me.okButton.Text = "&OK"
        '
        'samplingRateNumericEdit
        '
        Me.samplingRateNumericEdit.CoercionInterval = 100
        Me.samplingRateNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.samplingRateNumericEdit.Location = New System.Drawing.Point(127, 290)
        Me.samplingRateNumericEdit.Name = "samplingRateNumericEdit"
        Me.samplingRateNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.samplingRateNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.samplingRateNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.samplingRateNumericEdit.TabIndex = 33
        '
        'phaseNumericEdit
        '
        Me.phaseNumericEdit.CoercionInterval = 30
        Me.phaseNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.phaseNumericEdit.Location = New System.Drawing.Point(127, 250)
        Me.phaseNumericEdit.Name = "phaseNumericEdit"
        Me.phaseNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.phaseNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.phaseNumericEdit.TabIndex = 31
        '
        'offsetNumericEdit
        '
        Me.offsetNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.offsetNumericEdit.Location = New System.Drawing.Point(127, 210)
        Me.offsetNumericEdit.Name = "offsetNumericEdit"
        Me.offsetNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.offsetNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.offsetNumericEdit.TabIndex = 29
        '
        'numberOfSamplesNumericEdit
        '
        Me.numberOfSamplesNumericEdit.CoercionInterval = 100
        Me.numberOfSamplesNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(0)
        Me.numberOfSamplesNumericEdit.Location = New System.Drawing.Point(127, 170)
        Me.numberOfSamplesNumericEdit.Name = "numberOfSamplesNumericEdit"
        Me.numberOfSamplesNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.numberOfSamplesNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.numberOfSamplesNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.numberOfSamplesNumericEdit.TabIndex = 27
        '
        'frequencyNumericEdit
        '
        Me.frequencyNumericEdit.CoercionInterval = 100
        Me.frequencyNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.frequencyNumericEdit.Location = New System.Drawing.Point(127, 130)
        Me.frequencyNumericEdit.Name = "frequencyNumericEdit"
        Me.frequencyNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.frequencyNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.frequencyNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.frequencyNumericEdit.TabIndex = 25
        '
        'dutyCycleNumericEdit
        '
        Me.dutyCycleNumericEdit.CoercionInterval = 10
        Me.dutyCycleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.dutyCycleNumericEdit.Location = New System.Drawing.Point(127, 90)
        Me.dutyCycleNumericEdit.Name = "dutyCycleNumericEdit"
        Me.dutyCycleNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.dutyCycleNumericEdit.Range = New NationalInstruments.UI.Range(0, 100)
        Me.dutyCycleNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.dutyCycleNumericEdit.TabIndex = 23
        '
        'amplitudeNumericEdit
        '
        Me.amplitudeNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.amplitudeNumericEdit.Location = New System.Drawing.Point(127, 50)
        Me.amplitudeNumericEdit.Name = "amplitudeNumericEdit"
        Me.amplitudeNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.amplitudeNumericEdit.Range = New NationalInstruments.UI.Range(0, Double.PositiveInfinity)
        Me.amplitudeNumericEdit.Size = New System.Drawing.Size(152, 20)
        Me.amplitudeNumericEdit.TabIndex = 21
        Me.amplitudeNumericEdit.Value = 5
        '
        'samplingRateLabel
        '
        Me.samplingRateLabel.Location = New System.Drawing.Point(7, 288)
        Me.samplingRateLabel.Name = "samplingRateLabel"
        Me.samplingRateLabel.Size = New System.Drawing.Size(112, 23)
        Me.samplingRateLabel.TabIndex = 32
        Me.samplingRateLabel.Text = "Sampling Rate:"
        '
        'phaseLabel
        '
        Me.phaseLabel.Location = New System.Drawing.Point(7, 248)
        Me.phaseLabel.Name = "phaseLabel"
        Me.phaseLabel.Size = New System.Drawing.Size(112, 23)
        Me.phaseLabel.TabIndex = 30
        Me.phaseLabel.Text = "Phase:"
        '
        'offsetLabel
        '
        Me.offsetLabel.Location = New System.Drawing.Point(7, 208)
        Me.offsetLabel.Name = "offsetLabel"
        Me.offsetLabel.Size = New System.Drawing.Size(112, 23)
        Me.offsetLabel.TabIndex = 28
        Me.offsetLabel.Text = "Offset:"
        '
        'numberOfSamplesLabel
        '
        Me.numberOfSamplesLabel.Location = New System.Drawing.Point(7, 168)
        Me.numberOfSamplesLabel.Name = "numberOfSamplesLabel"
        Me.numberOfSamplesLabel.Size = New System.Drawing.Size(112, 23)
        Me.numberOfSamplesLabel.TabIndex = 26
        Me.numberOfSamplesLabel.Text = "Number of Samples:"
        '
        'frequencyLabel
        '
        Me.frequencyLabel.Location = New System.Drawing.Point(7, 128)
        Me.frequencyLabel.Name = "frequencyLabel"
        Me.frequencyLabel.Size = New System.Drawing.Size(112, 23)
        Me.frequencyLabel.TabIndex = 24
        Me.frequencyLabel.Text = "Frequency:"
        '
        'dutyCycleLabel
        '
        Me.dutyCycleLabel.Location = New System.Drawing.Point(7, 88)
        Me.dutyCycleLabel.Name = "dutyCycleLabel"
        Me.dutyCycleLabel.Size = New System.Drawing.Size(112, 23)
        Me.dutyCycleLabel.TabIndex = 22
        Me.dutyCycleLabel.Text = "Duty Cycle:"
        '
        'amplitudeLabel
        '
        Me.amplitudeLabel.Location = New System.Drawing.Point(7, 48)
        Me.amplitudeLabel.Name = "amplitudeLabel"
        Me.amplitudeLabel.Size = New System.Drawing.Size(112, 23)
        Me.amplitudeLabel.TabIndex = 20
        Me.amplitudeLabel.Text = "Amplitude:"
        '
        'signalTypeLabel
        '
        Me.signalTypeLabel.Location = New System.Drawing.Point(7, 10)
        Me.signalTypeLabel.Name = "signalTypeLabel"
        Me.signalTypeLabel.Size = New System.Drawing.Size(112, 21)
        Me.signalTypeLabel.TabIndex = 18
        Me.signalTypeLabel.Text = "Signal Type:"
        '
        'signalTypeComboBox
        '
        Me.signalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.signalTypeComboBox.Location = New System.Drawing.Point(127, 10)
        Me.signalTypeComboBox.Name = "signalTypeComboBox"
        Me.signalTypeComboBox.Size = New System.Drawing.Size(152, 21)
        Me.signalTypeComboBox.TabIndex = 19
        '
        'ConfigureSimulatedAcqForm
        '
        Me.AcceptButton = Me.okButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(288, 365)
        Me.Controls.Add(Me._cancelButton)
        Me.Controls.Add(Me.okButton)
        Me.Controls.Add(Me.samplingRateNumericEdit)
        Me.Controls.Add(Me.phaseNumericEdit)
        Me.Controls.Add(Me.offsetNumericEdit)
        Me.Controls.Add(Me.numberOfSamplesNumericEdit)
        Me.Controls.Add(Me.frequencyNumericEdit)
        Me.Controls.Add(Me.dutyCycleNumericEdit)
        Me.Controls.Add(Me.amplitudeNumericEdit)
        Me.Controls.Add(Me.samplingRateLabel)
        Me.Controls.Add(Me.phaseLabel)
        Me.Controls.Add(Me.offsetLabel)
        Me.Controls.Add(Me.numberOfSamplesLabel)
        Me.Controls.Add(Me.frequencyLabel)
        Me.Controls.Add(Me.dutyCycleLabel)
        Me.Controls.Add(Me.amplitudeLabel)
        Me.Controls.Add(Me.signalTypeLabel)
        Me.Controls.Add(Me.signalTypeComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "ConfigureSimulatedAcqForm"
        Me.Text = "Configure Simulated Acquisition"
        CType(Me.samplingRateNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.phaseNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.offsetNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numberOfSamplesNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.frequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dutyCycleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.amplitudeNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ConfigureSimulatedAcqForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PopulateControls()
    End Sub

    Private Sub signalTypeComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles signalTypeComboBox.SelectedIndexChanged
        dutyCycleNumericEdit.Enabled = (DirectCast([Enum].Parse(GetType(BasicFunctionGeneratorSignal), signalTypeComboBox.SelectedItem.ToString()), BasicFunctionGeneratorSignal) = BasicFunctionGeneratorSignal.Square)
    End Sub
    Private Sub okButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles okButton.Click
        ReadFromControls()
        DialogResult = Windows.Forms.DialogResult.OK
        Close()
    End Sub
    Private Sub PopulateControls()
        amplitudeNumericEdit.Value = dataGenerator.Amplitude
        dutyCycleNumericEdit.Value = dataGenerator.DutyCycle
        frequencyNumericEdit.Value = dataGenerator.Frequency
        numberOfSamplesNumericEdit.Value = dataGenerator.NumberOfSamples
        offsetNumericEdit.Value = dataGenerator.Offset
        phaseNumericEdit.Value = dataGenerator.Phase
        samplingRateNumericEdit.Value = dataGenerator.SamplingRate
        signalTypeComboBox.SelectedItem = dataGenerator.SignalType.ToString()
    End Sub


    Private Sub ReadFromControls()
        dataGenerator.Amplitude = amplitudeNumericEdit.Value
        dataGenerator.DutyCycle = dutyCycleNumericEdit.Value
        dataGenerator.Frequency = frequencyNumericEdit.Value
        dataGenerator.NumberOfSamples = CType(numberOfSamplesNumericEdit.Value, Integer)
        dataGenerator.Offset = offsetNumericEdit.Value
        dataGenerator.Phase = phaseNumericEdit.Value
        dataGenerator.SamplingRate = samplingRateNumericEdit.Value
        dataGenerator.SignalType = DirectCast([Enum].Parse(GetType(BasicFunctionGeneratorSignal), signalTypeComboBox.SelectedItem.ToString()), BasicFunctionGeneratorSignal)
    End Sub

End Class
