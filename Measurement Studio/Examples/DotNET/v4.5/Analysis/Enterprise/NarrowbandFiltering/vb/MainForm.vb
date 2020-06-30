Public Class MainForm
    Inherits System.Windows.Forms.Form
    Private filterTypeLabel As System.Windows.Forms.Label
    Private rippleLabel As System.Windows.Forms.Label
    Private phasePlot As NationalInstruments.UI.ScatterPlot
    Private magnitudePlot As NationalInstruments.UI.ScatterPlot
    Private magnitudeXAxis As NationalInstruments.UI.XAxis
    Private magnitudeYAxis As NationalInstruments.UI.YAxis
    Private phaseXAxis As NationalInstruments.UI.XAxis
    Private phaseYAxis As NationalInstruments.UI.YAxis
    Private attenuationLabel As System.Windows.Forms.Label
    Private filterTypeComboBox As System.Windows.Forms.ComboBox
    Private attenuationNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private rippleNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private phaseScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Private magnitudeScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Private filterParametersGroupBox As System.Windows.Forms.GroupBox
    Private passbandLabel As Label
    Private stopbandNumeric As NationalInstruments.UI.WindowsForms.NumericEdit
    Private stopbandLabel As Label
    Private passbandNumeric As NationalInstruments.UI.WindowsForms.NumericEdit
    Private centerFrequencyNumericEdit As NationalInstruments.UI.WindowsForms.NumericEdit
    Private centerFrequencyLabel As Label
    Private updateButton As Button
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.Container = Nothing

    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        filterTypeComboBox.SelectedIndex = 0
    End Sub

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If components IsNot Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"
    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.filterParametersGroupBox = New System.Windows.Forms.GroupBox()
        Me.centerFrequencyNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.centerFrequencyLabel = New System.Windows.Forms.Label()
        Me.stopbandNumeric = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.stopbandLabel = New System.Windows.Forms.Label()
        Me.passbandNumeric = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.passbandLabel = New System.Windows.Forms.Label()
        Me.rippleLabel = New System.Windows.Forms.Label()
        Me.filterTypeLabel = New System.Windows.Forms.Label()
        Me.filterTypeComboBox = New System.Windows.Forms.ComboBox()
        Me.attenuationLabel = New System.Windows.Forms.Label()
        Me.attenuationNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.rippleNumericEdit = New NationalInstruments.UI.WindowsForms.NumericEdit()
        Me.phaseScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph()
        Me.phasePlot = New NationalInstruments.UI.ScatterPlot()
        Me.phaseXAxis = New NationalInstruments.UI.XAxis()
        Me.phaseYAxis = New NationalInstruments.UI.YAxis()
        Me.magnitudeScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph()
        Me.magnitudePlot = New NationalInstruments.UI.ScatterPlot()
        Me.magnitudeXAxis = New NationalInstruments.UI.XAxis()
        Me.magnitudeYAxis = New NationalInstruments.UI.YAxis()
        Me.updateButton = New System.Windows.Forms.Button()
        Me.filterParametersGroupBox.SuspendLayout()
        DirectCast(Me.centerFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.stopbandNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.passbandNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.attenuationNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.rippleNumericEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.phaseScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        DirectCast(Me.magnitudeScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' filterParametersGroupBox
        ' 
        Me.filterParametersGroupBox.Controls.Add(Me.centerFrequencyNumericEdit)
        Me.filterParametersGroupBox.Controls.Add(Me.centerFrequencyLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.stopbandNumeric)
        Me.filterParametersGroupBox.Controls.Add(Me.stopbandLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.passbandNumeric)
        Me.filterParametersGroupBox.Controls.Add(Me.passbandLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.rippleLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.filterTypeLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.filterTypeComboBox)
        Me.filterParametersGroupBox.Controls.Add(Me.attenuationLabel)
        Me.filterParametersGroupBox.Controls.Add(Me.attenuationNumericEdit)
        Me.filterParametersGroupBox.Controls.Add(Me.rippleNumericEdit)
        Me.filterParametersGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterParametersGroupBox.Location = New System.Drawing.Point(452, 10)
        Me.filterParametersGroupBox.Name = "filterParametersGroupBox"
        Me.filterParametersGroupBox.Size = New System.Drawing.Size(128, 304)
        Me.filterParametersGroupBox.TabIndex = 8
        Me.filterParametersGroupBox.TabStop = False
        Me.filterParametersGroupBox.Text = "Filter Parameters"
        ' 
        ' centerFrequencyNumericEdit
        ' 
        Me.centerFrequencyNumericEdit.Location = New System.Drawing.Point(16, 272)
        Me.centerFrequencyNumericEdit.Name = "centerFrequencyNumericEdit"
        Me.centerFrequencyNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.centerFrequencyNumericEdit.TabIndex = 10
        Me.centerFrequencyNumericEdit.Value = 150
        ' 
        ' centerFrequencyLabel
        ' 
        Me.centerFrequencyLabel.AutoSize = True
        Me.centerFrequencyLabel.Location = New System.Drawing.Point(13, 256)
        Me.centerFrequencyLabel.Name = "centerFrequencyLabel"
        Me.centerFrequencyLabel.Size = New System.Drawing.Size(94, 13)
        Me.centerFrequencyLabel.TabIndex = 4
        Me.centerFrequencyLabel.Text = "Center Frequency:"
        ' 
        ' stopbandNumeric
        ' 
        Me.stopbandNumeric.Location = New System.Drawing.Point(16, 128)
        Me.stopbandNumeric.Name = "stopbandNumeric"
        Me.stopbandNumeric.Size = New System.Drawing.Size(96, 20)
        Me.stopbandNumeric.TabIndex = 4
        Me.stopbandNumeric.Value = 200
        ' 
        ' stopbandLabel
        ' 
        Me.stopbandLabel.AutoSize = True
        Me.stopbandLabel.Location = New System.Drawing.Point(13, 112)
        Me.stopbandLabel.Name = "stopbandLabel"
        Me.stopbandLabel.Size = New System.Drawing.Size(56, 13)
        Me.stopbandLabel.TabIndex = 4
        Me.stopbandLabel.Text = "Stopband:"
        ' 
        ' passbandNumeric
        ' 
        Me.passbandNumeric.Location = New System.Drawing.Point(16, 80)
        Me.passbandNumeric.Name = "passbandNumeric"
        Me.passbandNumeric.Size = New System.Drawing.Size(96, 20)
        Me.passbandNumeric.TabIndex = 2
        Me.passbandNumeric.Value = 100
        ' 
        ' passbandLabel
        ' 
        Me.passbandLabel.AutoSize = True
        Me.passbandLabel.Location = New System.Drawing.Point(13, 64)
        Me.passbandLabel.Name = "passbandLabel"
        Me.passbandLabel.Size = New System.Drawing.Size(57, 13)
        Me.passbandLabel.TabIndex = 4
        Me.passbandLabel.Text = "Passband:"
        ' 
        ' rippleLabel
        ' 
        Me.rippleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rippleLabel.Location = New System.Drawing.Point(16, 160)
        Me.rippleLabel.Name = "rippleLabel"
        Me.rippleLabel.Size = New System.Drawing.Size(88, 16)
        Me.rippleLabel.TabIndex = 1
        Me.rippleLabel.Text = "Ripple:"
        ' 
        ' filterTypeLabel
        ' 
        Me.filterTypeLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.filterTypeLabel.Location = New System.Drawing.Point(16, 16)
        Me.filterTypeLabel.Name = "filterTypeLabel"
        Me.filterTypeLabel.Size = New System.Drawing.Size(88, 16)
        Me.filterTypeLabel.TabIndex = 1
        Me.filterTypeLabel.Text = "Filter Type:"
        ' 
        ' filterTypeComboBox
        ' 
        Me.filterTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filterTypeComboBox.Items.AddRange(New Object() {"Lowpass", "Highpass", "Bandpass", "Bandstop"})
        Me.filterTypeComboBox.Location = New System.Drawing.Point(16, 32)
        Me.filterTypeComboBox.Name = "filterTypeComboBox"
        Me.filterTypeComboBox.Size = New System.Drawing.Size(96, 21)
        Me.filterTypeComboBox.TabIndex = 0
        AddHandler Me.filterTypeComboBox.SelectedIndexChanged, New System.EventHandler(AddressOf Me.filterType_SelectedIndexChanged)
        ' 
        ' attenuationLabel
        ' 
        Me.attenuationLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.attenuationLabel.Location = New System.Drawing.Point(16, 205)
        Me.attenuationLabel.Name = "attenuationLabel"
        Me.attenuationLabel.Size = New System.Drawing.Size(88, 16)
        Me.attenuationLabel.TabIndex = 1
        Me.attenuationLabel.Text = "Attenuation:"
        ' 
        ' attenuationNumericEdit
        ' 
        Me.attenuationNumericEdit.CoercionInterval = 0.01
        Me.attenuationNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(3)
        Me.attenuationNumericEdit.Location = New System.Drawing.Point(16, 224)
        Me.attenuationNumericEdit.Name = "attenuationNumericEdit"
        Me.attenuationNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.attenuationNumericEdit.Range = New NationalInstruments.UI.Range(1, 1000)
        Me.attenuationNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.attenuationNumericEdit.TabIndex = 8
        Me.attenuationNumericEdit.Value = 60
        ' 
        ' rippleNumericEdit
        ' 
        Me.rippleNumericEdit.CoercionInterval = 0.01
        Me.rippleNumericEdit.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateSimpleDoubleMode(2)
        Me.rippleNumericEdit.Location = New System.Drawing.Point(16, 176)
        Me.rippleNumericEdit.Name = "rippleNumericEdit"
        Me.rippleNumericEdit.OutOfRangeMode = NationalInstruments.UI.NumericOutOfRangeMode.CoerceToRange
        Me.rippleNumericEdit.Range = New NationalInstruments.UI.Range(0.001, 1000)
        Me.rippleNumericEdit.Size = New System.Drawing.Size(96, 20)
        Me.rippleNumericEdit.TabIndex = 6
        Me.rippleNumericEdit.Value = 0.01
        ' 
        ' phaseScatterGraph
        ' 
        Me.phaseScatterGraph.Caption = "Phase Graph"
        Me.phaseScatterGraph.Location = New System.Drawing.Point(12, 243)
        Me.phaseScatterGraph.Name = "phaseScatterGraph"
        Me.phaseScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.phasePlot})
        Me.phaseScatterGraph.Size = New System.Drawing.Size(432, 231)
        Me.phaseScatterGraph.TabIndex = 7
        Me.phaseScatterGraph.TabStop = False
        Me.phaseScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.phaseXAxis})
        Me.phaseScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.phaseYAxis})
        ' 
        ' phasePlot
        ' 
        Me.phasePlot.XAxis = Me.phaseXAxis
        Me.phasePlot.YAxis = Me.phaseYAxis
        ' 
        ' phaseXAxis
        ' 
        Me.phaseXAxis.Caption = "Frequency"
        ' 
        ' phaseYAxis
        ' 
        Me.phaseYAxis.Caption = "Phase (radian)"
        ' 
        ' magnitudeScatterGraph
        ' 
        Me.magnitudeScatterGraph.Caption = "Magnitude Graph"
        Me.magnitudeScatterGraph.Location = New System.Drawing.Point(13, 10)
        Me.magnitudeScatterGraph.Name = "magnitudeScatterGraph"
        Me.magnitudeScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.magnitudePlot})
        Me.magnitudeScatterGraph.Size = New System.Drawing.Size(432, 224)
        Me.magnitudeScatterGraph.TabIndex = 7
        Me.magnitudeScatterGraph.TabStop = False
        Me.magnitudeScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.magnitudeXAxis})
        Me.magnitudeScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.magnitudeYAxis})
        ' 
        ' magnitudePlot
        ' 
        Me.magnitudePlot.XAxis = Me.magnitudeXAxis
        Me.magnitudePlot.YAxis = Me.magnitudeYAxis
        ' 
        ' magnitudeXAxis
        ' 
        Me.magnitudeXAxis.Caption = "Frequency"
        ' 
        ' magnitudeYAxis
        ' 
        Me.magnitudeYAxis.Caption = "Magnitude"
        ' 
        ' updateButton
        ' 
        Me.updateButton.Location = New System.Drawing.Point(471, 366)
        Me.updateButton.Name = "updateButton"
        Me.updateButton.Size = New System.Drawing.Size(75, 23)
        Me.updateButton.TabIndex = 11
        Me.updateButton.Text = "&Update"
        Me.updateButton.UseVisualStyleBackColor = True
        AddHandler Me.updateButton.Click, New System.EventHandler(AddressOf Me.updateButton_Click)
        ' 
        ' MainForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0F, 96.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(590, 486)
        Me.Controls.Add(Me.updateButton)
        Me.Controls.Add(Me.phaseScatterGraph)
        Me.Controls.Add(Me.filterParametersGroupBox)
        Me.Controls.Add(Me.magnitudeScatterGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NarrowbandFiltering"
        Me.filterParametersGroupBox.ResumeLayout(False)
        Me.filterParametersGroupBox.PerformLayout()
        DirectCast(Me.centerFrequencyNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.stopbandNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.passbandNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.attenuationNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.rippleNumericEdit, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.phaseScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        DirectCast(Me.magnitudeScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region

    

    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm())
    End Sub

    ' when the filter type selected by the user gets changed.
    Private Sub filterType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If filterTypeComboBox.SelectedIndex = 2 OrElse filterTypeComboBox.SelectedIndex = 3 Then
            centerFrequencyNumericEdit.Enabled = True
        Else
            centerFrequencyNumericEdit.Enabled = False
        End If

    End Sub



    Private Sub updateButton_Click(ByVal sender As Object, ByVal e As EventArgs)

        Dim filter As NarrowbandFirFilterBase = Nothing
        Dim impulse As Double() = {1.0}
        Select Case filterTypeComboBox.SelectedIndex
            'Lowpass
            Case 0
                filter = New NarrowbandFirLowpassFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value)
                Exit Select
                'Highpass
            Case 1
                filter = New NarrowbandFirHighpassFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value)
                Exit Select
                ' Bandpass
            Case 2
                filter = New NarrowbandFirBandpassFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value)
                Exit Select
                ' Bandstop
            Case 3
                filter = New NarrowbandFirBandstopFilter(10000, passbandNumeric.Value, stopbandNumeric.Value, centerFrequencyNumericEdit.Value)
                Exit Select
        End Select
        Try
            Dim impulseResponse As Double() = filter.FilterData(impulse)
            Dim spectrum As ComplexDouble() = Analysis.Dsp.Transforms.RealFft(impulseResponse)
            Dim magnitudeResponse As Double()
            Dim phaseResponse As Double()
            ComplexDouble.DecomposeArrayPolar(spectrum, magnitudeResponse, phaseResponse)
            Dim plotFrequency As Double() = Analysis.SignalGeneration.PatternGeneration.Ramp(impulseResponse.Length, 0, impulseResponse.Length * 10000)
            magnitudeScatterGraph.PlotXY(plotFrequency, magnitudeResponse)
            phaseScatterGraph.PlotXY(plotFrequency, phaseResponse)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class