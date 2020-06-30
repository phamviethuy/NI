Imports NationalInstruments.UI

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private radioButtonsEnabled As Boolean
    Private editorLaunched As Boolean

    Private customRadioButton As System.Windows.Forms.RadioButton
    Private editColorMapButton As System.Windows.Forms.Button
    Private grayScaleColorsRadioButton As System.Windows.Forms.RadioButton
    Private redToneColorsRadioButton As System.Windows.Forms.RadioButton
    Private rainbowColorsRadioButton As System.Windows.Forms.RadioButton
    Private highLowNormalColorsRadioButton As System.Windows.Forms.RadioButton
    Private colorMapPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Private colorScale As NationalInstruments.UI.ColorScale
    Private intensityGraph As NationalInstruments.UI.WindowsForms.IntensityGraph
    Private intensityPlot As NationalInstruments.UI.IntensityPlot
    Private intensityXAxis As NationalInstruments.UI.IntensityXAxis
    Private intensityYAxis As NationalInstruments.UI.IntensityYAxis
    Private highLowColorsRadioButton As System.Windows.Forms.RadioButton
    Private settingsGroupBox As System.Windows.Forms.GroupBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        InitializeApplication()
        AddHandler colorScale.ColorMap.CollectionChanged, AddressOf ColorMap_CollectionChanged
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




    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.editColorMapButton = New System.Windows.Forms.Button
        Me.grayScaleColorsRadioButton = New System.Windows.Forms.RadioButton
        Me.redToneColorsRadioButton = New System.Windows.Forms.RadioButton
        Me.rainbowColorsRadioButton = New System.Windows.Forms.RadioButton
        Me.highLowNormalColorsRadioButton = New System.Windows.Forms.RadioButton
        Me.colorMapPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.colorScale = New NationalInstruments.UI.ColorScale
        Me.intensityGraph = New NationalInstruments.UI.WindowsForms.IntensityGraph
        Me.intensityPlot = New NationalInstruments.UI.IntensityPlot
        Me.intensityXAxis = New NationalInstruments.UI.IntensityXAxis
        Me.intensityYAxis = New NationalInstruments.UI.IntensityYAxis
        Me.highLowColorsRadioButton = New System.Windows.Forms.RadioButton
        Me.settingsGroupBox = New System.Windows.Forms.GroupBox
        Me.customRadioButton = New System.Windows.Forms.RadioButton
        CType(Me.intensityGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.settingsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'editColorMapButton
        '
        Me.editColorMapButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.editColorMapButton.Location = New System.Drawing.Point(15, 161)
        Me.editColorMapButton.Name = "editColorMapButton"
        Me.editColorMapButton.Size = New System.Drawing.Size(95, 23)
        Me.editColorMapButton.TabIndex = 5
        Me.editColorMapButton.Text = "Edit Color Map"
        Me.editColorMapButton.UseVisualStyleBackColor = True
        AddHandler editColorMapButton.Click, AddressOf OnEditColorMapButtonClick
        '
        'grayScaleColorsRadioButton
        '
        Me.grayScaleColorsRadioButton.AutoSize = True
        Me.grayScaleColorsRadioButton.Location = New System.Drawing.Point(15, 23)
        Me.grayScaleColorsRadioButton.Name = "grayScaleColorsRadioButton"
        Me.grayScaleColorsRadioButton.Size = New System.Drawing.Size(77, 17)
        Me.grayScaleColorsRadioButton.TabIndex = 0
        Me.grayScaleColorsRadioButton.TabStop = True
        Me.grayScaleColorsRadioButton.Text = "Gray Scale"
        Me.grayScaleColorsRadioButton.UseVisualStyleBackColor = True
        AddHandler Me.grayScaleColorsRadioButton.CheckedChanged, AddressOf OnRadioButtonCheckedChanged
        '
        'redToneColorsRadioButton
        '
        Me.redToneColorsRadioButton.AutoSize = True
        Me.redToneColorsRadioButton.Location = New System.Drawing.Point(15, 46)
        Me.redToneColorsRadioButton.Name = "redToneColorsRadioButton"
        Me.redToneColorsRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.redToneColorsRadioButton.TabIndex = 1
        Me.redToneColorsRadioButton.TabStop = True
        Me.redToneColorsRadioButton.Text = "Red Tone"
        Me.redToneColorsRadioButton.UseVisualStyleBackColor = True
        AddHandler redToneColorsRadioButton.CheckedChanged, AddressOf OnRadioButtonCheckedChanged
        '
        'rainbowColorsRadioButton
        '
        Me.rainbowColorsRadioButton.AutoSize = True
        Me.rainbowColorsRadioButton.Location = New System.Drawing.Point(15, 115)
        Me.rainbowColorsRadioButton.Name = "rainbowColorsRadioButton"
        Me.rainbowColorsRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.rainbowColorsRadioButton.TabIndex = 4
        Me.rainbowColorsRadioButton.TabStop = True
        Me.rainbowColorsRadioButton.Text = "Rainbow"
        Me.rainbowColorsRadioButton.UseVisualStyleBackColor = True
        AddHandler rainbowColorsRadioButton.CheckedChanged, AddressOf OnRadioButtonCheckedChanged
        '
        'highLowNormalColorsRadioButton
        '
        Me.highLowNormalColorsRadioButton.AutoSize = True
        Me.highLowNormalColorsRadioButton.Location = New System.Drawing.Point(15, 92)
        Me.highLowNormalColorsRadioButton.Name = "highLowNormalColorsRadioButton"
        Me.highLowNormalColorsRadioButton.Size = New System.Drawing.Size(106, 17)
        Me.highLowNormalColorsRadioButton.TabIndex = 3
        Me.highLowNormalColorsRadioButton.TabStop = True
        Me.highLowNormalColorsRadioButton.Text = "High Normal Low"
        Me.highLowNormalColorsRadioButton.UseVisualStyleBackColor = True
        AddHandler highLowNormalColorsRadioButton.CheckedChanged, AddressOf OnRadioButtonCheckedChanged
        '
        'colorMapPropertyEditor
        '
        Me.colorMapPropertyEditor.BackColor = System.Drawing.SystemColors.Control
        Me.colorMapPropertyEditor.Location = New System.Drawing.Point(29, 161)
        Me.colorMapPropertyEditor.Name = "colorMapPropertyEditor"
        Me.colorMapPropertyEditor.Size = New System.Drawing.Size(81, 20)
        Me.colorMapPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.colorScale, "ColorMap")
        Me.colorMapPropertyEditor.TabIndex = 3
        Me.colorMapPropertyEditor.TabStop = False
        Me.colorMapPropertyEditor.Visible = False
        '
        'colorScale
        '
        Me.colorScale.Caption = "Color Scale"
        Me.colorScale.Range = New NationalInstruments.UI.Range(0, 10000)
        Me.colorScale.RightCaptionOrientation = NationalInstruments.UI.VerticalCaptionOrientation.BottomToTop
        '
        'intensityGraph
        '
        Me.intensityGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.intensityGraph.Caption = "Intensity Graph"
        Me.intensityGraph.ColorScales.AddRange(New NationalInstruments.UI.ColorScale() {Me.colorScale})
        Me.intensityGraph.Location = New System.Drawing.Point(150, 16)
        Me.intensityGraph.Name = "intensityGraph"
        Me.intensityGraph.Plots.AddRange(New NationalInstruments.UI.IntensityPlot() {Me.intensityPlot})
        Me.intensityGraph.Size = New System.Drawing.Size(370, 298)
        Me.intensityGraph.TabIndex = 2
        Me.intensityGraph.XAxes.AddRange(New NationalInstruments.UI.IntensityXAxis() {Me.intensityXAxis})
        Me.intensityGraph.YAxes.AddRange(New NationalInstruments.UI.IntensityYAxis() {Me.intensityYAxis})
        '
        'intensityPlot
        '
        Me.intensityPlot.ColorScale = Me.colorScale
        Me.intensityPlot.XAxis = Me.intensityXAxis
        Me.intensityPlot.YAxis = Me.intensityYAxis
        '
        'intensityXAxis
        '
        Me.intensityXAxis.Caption = "Intensity X Axis"
        '
        'intensityYAxis
        '
        Me.intensityYAxis.Caption = "Intensity Y Axis"
        '
        'highLowColorsRadioButton
        '
        Me.highLowColorsRadioButton.AutoSize = True
        Me.highLowColorsRadioButton.Location = New System.Drawing.Point(15, 69)
        Me.highLowColorsRadioButton.Name = "highLowColorsRadioButton"
        Me.highLowColorsRadioButton.Size = New System.Drawing.Size(70, 17)
        Me.highLowColorsRadioButton.TabIndex = 2
        Me.highLowColorsRadioButton.TabStop = True
        Me.highLowColorsRadioButton.Text = "High Low"
        Me.highLowColorsRadioButton.UseVisualStyleBackColor = True
        AddHandler highLowColorsRadioButton.CheckedChanged, AddressOf OnRadioButtonCheckedChanged
        '
        'settingsGroupBox
        '
        Me.settingsGroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.settingsGroupBox.Controls.Add(Me.editColorMapButton)
        Me.settingsGroupBox.Controls.Add(Me.grayScaleColorsRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.redToneColorsRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.customRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.rainbowColorsRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.highLowNormalColorsRadioButton)
        Me.settingsGroupBox.Controls.Add(Me.colorMapPropertyEditor)
        Me.settingsGroupBox.Controls.Add(Me.highLowColorsRadioButton)
        Me.settingsGroupBox.Location = New System.Drawing.Point(13, 10)
        Me.settingsGroupBox.Name = "settingsGroupBox"
        Me.settingsGroupBox.Size = New System.Drawing.Size(131, 304)
        Me.settingsGroupBox.TabIndex = 1
        Me.settingsGroupBox.TabStop = False
        Me.settingsGroupBox.Text = "Color Map Settings"
        '
        'customRadioButton
        '
        Me.customRadioButton.AutoSize = True
        Me.customRadioButton.Location = New System.Drawing.Point(15, 138)
        Me.customRadioButton.Name = "customRadioButton"
        Me.customRadioButton.Size = New System.Drawing.Size(60, 17)
        Me.customRadioButton.TabIndex = 4
        Me.customRadioButton.TabStop = True
        Me.customRadioButton.Text = "Custom"
        Me.customRadioButton.UseVisualStyleBackColor = True
        AddHandler customRadioButton.CheckedChanged, AddressOf OnRadioButtonCheckedChanged
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(532, 324)
        Me.Controls.Add(Me.intensityGraph)
        Me.Controls.Add(Me.settingsGroupBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(540, 345)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Using Color Scale In Intensity Graph"
        CType(Me.intensityGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.settingsGroupBox.ResumeLayout(False)
        Me.settingsGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Sub InitializeApplication()
        Dim data As Double(,) = GenerateIntensityData()
        intensityPlot.Plot(data)

        radioButtonsEnabled = True
        grayScaleColorsRadioButton.Checked = True
        customRadioButton.Enabled = False
    End Sub

    Private Sub OnRadioButtonCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        'A predefined ColorScale setting is selected. So just disable the custom radio button.
        If customRadioButton.Enabled = True Then
            customRadioButton.Enabled = False
        End If

        'Configure the ColorScale for the selected predefined ColorScale setting.
        ConfigureColorScale()
    End Sub

    Private Sub ConfigureColorScale()
        ' Configuring ColorScale for plotting includes configuring the following ColorScale properties : 
        ' Range, InterpolateColors, ScaleType, LowColor, HighColor and ColorMap.
        If radioButtonsEnabled Then
            editorLaunched = False
            colorScale.ColorMap.Clear()
            colorScale.Range = New Range(0, 10000)
            colorScale.InterpolateColor = True
            colorScale.ScaleType = ScaleType.Linear

            If grayScaleColorsRadioButton.Checked Then
                colorScale.LowColor = Color.Black
                colorScale.HighColor = Color.White
            ElseIf redToneColorsRadioButton.Checked Then
                colorScale.LowColor = Color.DarkRed
                colorScale.ColorMap.Add(2500, Color.Brown)
                colorScale.ColorMap.Add(5000, Color.Red)
                colorScale.ColorMap.Add(7500, Color.Orange)
                colorScale.HighColor = Color.Yellow
            ElseIf highLowColorsRadioButton.Checked Then
                colorScale.LowColor = Color.Blue
                colorScale.HighColor = Color.Red
            ElseIf highLowNormalColorsRadioButton.Checked Then
                colorScale.LowColor = Color.Blue
                colorScale.ColorMap.Add(5000, Color.Lime)
                colorScale.HighColor = Color.Red
            ElseIf rainbowColorsRadioButton.Checked Then
                colorScale.LowColor = Color.DarkViolet
                colorScale.ColorMap.Add(1500, Color.Indigo)
                colorScale.ColorMap.Add(3000, Color.Blue)
                colorScale.ColorMap.Add(5000, Color.Green)
                colorScale.ColorMap.Add(7000, Color.Yellow)
                colorScale.ColorMap.Add(8500, Color.Orange)
                colorScale.HighColor = Color.Red
            End If
        End If
    End Sub

    Private Sub OnEditColorMapButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        ' Launch the color map editor.		
        editorLaunched = True
        colorMapPropertyEditor.EditValue()
    End Sub


    Private Sub ColorScaleModified()
        radioButtonsEnabled = False
        grayScaleColorsRadioButton.Checked = False
        redToneColorsRadioButton.Checked = False
        highLowColorsRadioButton.Checked = False
        highLowNormalColorsRadioButton.Checked = False
        rainbowColorsRadioButton.Checked = False

        'Enable and select the radio button for custom settings when a ColorScale property is changed.
        customRadioButton.Checked = True
        customRadioButton.Enabled = True

        radioButtonsEnabled = True
    End Sub

    Private Function GenerateIntensityData() As Double(,)
        Dim size As Integer = 200
        Dim radius As Integer = 100
        Dim data As Double(,) = New Double(size, size) {}
        ' Here we generate data in a circular manner.
        ' Use the equation of a circle and transpose the origin.
        Dim i As Integer = -radius
        While i <= radius
            Dim j As Integer = -radius
            While j <= radius
                data(radius + i, radius + j) = i * i + j * j
                System.Math.Max(System.Threading.Interlocked.Increment(j), j - 1)
            End While
            System.Math.Max(System.Threading.Interlocked.Increment(i), i - 1)
        End While
        Return data
    End Function

    Sub ColorMap_CollectionChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
        If editorLaunched = True Then
            editorLaunched = False
            ColorScaleModified()
            ConfigureColorScale()
        End If
    End Sub
End Class
