Imports System.ComponentModel
Imports NationalInstruments.UI
Imports System.Globalization
Imports System.Drawing.Design

Public Class MainForm
    Inherits System.Windows.Forms.Form

    Private rand As Random
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        InitializeComponent()
        rand = New Random
        displayWaveformGraph.PlotYAppend(GetRandomValues(10))

        plotLinePropertyEditor.Source = New PlotColorPropertyEditorSource(defaultWaveformPlot, "LineColor")
        xAxisRangePropertyEditor.Source = New RangePropertyEditorSource(defaultXAxis, "Range")
        yAxisRangePropertyEditor.Source = New RangePropertyEditorSource(defaultYAxis, "Range")


    End Sub

    Private Function GetRandomValues(ByVal count As Integer) As Double()
        Dim data(count - 1) As Double
        For x As Integer = 0 To count - 1 Step 1
            data(x) = rand.NextDouble() * 100
        Next

        Return data
    End Function


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
    Friend WithEvents displayWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents defaultWaveformPlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents defaultXAxis As NationalInstruments.UI.XAxis
    Friend WithEvents defaultYAxis As NationalInstruments.UI.YAxis
    Friend WithEvents defaultcolorEditorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultLineColorLabel As System.Windows.Forms.Label
    Friend WithEvents defaultPlotLinePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents customEditorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents lineColorLabel As System.Windows.Forms.Label
    Friend WithEvents plotLinePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents defaultXAxisRangeLabel As System.Windows.Forms.Label
    Friend WithEvents defaultXAxisPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents defaultYAxisPropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents defaultYAxisRangeLabel As System.Windows.Forms.Label
    Friend WithEvents customTypeConverterGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents xAxisRangeLabel As System.Windows.Forms.Label
    Friend WithEvents yAxisRangePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents xAxisRangePropertyEditor As NationalInstruments.UI.WindowsForms.PropertyEditor
    Friend WithEvents yAxisRangeLabel As System.Windows.Forms.Label
    Friend WithEvents appendPointButton As System.Windows.Forms.Button
    Friend WithEvents defaultTypeConverterGroupBox As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.displayWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.defaultWaveformPlot = New NationalInstruments.UI.WaveformPlot
        Me.defaultXAxis = New NationalInstruments.UI.XAxis
        Me.defaultYAxis = New NationalInstruments.UI.YAxis
        Me.defaultcolorEditorGroupBox = New System.Windows.Forms.GroupBox
        Me.defaultLineColorLabel = New System.Windows.Forms.Label
        Me.defaultPlotLinePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.customEditorGroupBox = New System.Windows.Forms.GroupBox
        Me.lineColorLabel = New System.Windows.Forms.Label
        Me.plotLinePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.defaultTypeConverterGroupBox = New System.Windows.Forms.GroupBox
        Me.defaultXAxisRangeLabel = New System.Windows.Forms.Label
        Me.defaultXAxisPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.defaultYAxisPropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.defaultYAxisRangeLabel = New System.Windows.Forms.Label
        Me.customTypeConverterGroupBox = New System.Windows.Forms.GroupBox
        Me.xAxisRangeLabel = New System.Windows.Forms.Label
        Me.yAxisRangePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.xAxisRangePropertyEditor = New NationalInstruments.UI.WindowsForms.PropertyEditor
        Me.yAxisRangeLabel = New System.Windows.Forms.Label
        Me.appendPointButton = New System.Windows.Forms.Button
        CType(Me.displayWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.defaultcolorEditorGroupBox.SuspendLayout()
        Me.customEditorGroupBox.SuspendLayout()
        Me.defaultTypeConverterGroupBox.SuspendLayout()
        Me.customTypeConverterGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'displayWaveformGraph
        '
        Me.displayWaveformGraph.Dock = System.Windows.Forms.DockStyle.Top
        Me.displayWaveformGraph.Location = New System.Drawing.Point(0, 0)
        Me.displayWaveformGraph.Name = "displayWaveformGraph"
        Me.displayWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.defaultWaveformPlot})
        Me.displayWaveformGraph.Size = New System.Drawing.Size(552, 200)
        Me.displayWaveformGraph.TabIndex = 0
        Me.displayWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.defaultXAxis})
        Me.displayWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.defaultYAxis})
        '
        'defaultWaveformPlot
        '
        Me.defaultWaveformPlot.XAxis = Me.defaultXAxis
        Me.defaultWaveformPlot.YAxis = Me.defaultYAxis
        '
        'defaultcolorEditorGroupBox
        '
        Me.defaultcolorEditorGroupBox.Controls.Add(Me.defaultLineColorLabel)
        Me.defaultcolorEditorGroupBox.Controls.Add(Me.defaultPlotLinePropertyEditor)
        Me.defaultcolorEditorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultcolorEditorGroupBox.Location = New System.Drawing.Point(280, 248)
        Me.defaultcolorEditorGroupBox.Name = "defaultcolorEditorGroupBox"
        Me.defaultcolorEditorGroupBox.Size = New System.Drawing.Size(248, 72)
        Me.defaultcolorEditorGroupBox.TabIndex = 4
        Me.defaultcolorEditorGroupBox.TabStop = False
        Me.defaultcolorEditorGroupBox.Text = "Default Color Editor"
        '
        'defaultLineColorLabel
        '
        Me.defaultLineColorLabel.AutoSize = True
        Me.defaultLineColorLabel.Location = New System.Drawing.Point(16, 24)
        Me.defaultLineColorLabel.Name = "defaultLineColorLabel"
        Me.defaultLineColorLabel.Size = New System.Drawing.Size(78, 16)
        Me.defaultLineColorLabel.TabIndex = 1
        Me.defaultLineColorLabel.Text = "Plot Line Color"
        '
        'defaultPlotLinePropertyEditor
        '
        Me.defaultPlotLinePropertyEditor.Location = New System.Drawing.Point(104, 24)
        Me.defaultPlotLinePropertyEditor.Name = "defaultPlotLinePropertyEditor"
        Me.defaultPlotLinePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.defaultWaveformPlot, "LineColor")
        Me.defaultPlotLinePropertyEditor.TabIndex = 0
        '
        'customEditorGroupBox
        '
        Me.customEditorGroupBox.Controls.Add(Me.lineColorLabel)
        Me.customEditorGroupBox.Controls.Add(Me.plotLinePropertyEditor)
        Me.customEditorGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customEditorGroupBox.Location = New System.Drawing.Point(280, 352)
        Me.customEditorGroupBox.Name = "customEditorGroupBox"
        Me.customEditorGroupBox.Size = New System.Drawing.Size(248, 72)
        Me.customEditorGroupBox.TabIndex = 5
        Me.customEditorGroupBox.TabStop = False
        Me.customEditorGroupBox.Text = "Custom Color Editor"
        '
        'lineColorLabel
        '
        Me.lineColorLabel.AutoSize = True
        Me.lineColorLabel.Location = New System.Drawing.Point(16, 24)
        Me.lineColorLabel.Name = "lineColorLabel"
        Me.lineColorLabel.Size = New System.Drawing.Size(78, 16)
        Me.lineColorLabel.TabIndex = 1
        Me.lineColorLabel.Text = "Plot Line Color"
        '
        'plotLinePropertyEditor
        '
        Me.plotLinePropertyEditor.Location = New System.Drawing.Point(104, 24)
        Me.plotLinePropertyEditor.Name = "plotLinePropertyEditor"
        Me.plotLinePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.defaultWaveformPlot, "LineColor")
        Me.plotLinePropertyEditor.TabIndex = 0
        '
        'defaultTypeConverterGroupBox
        '
        Me.defaultTypeConverterGroupBox.Controls.Add(Me.defaultXAxisRangeLabel)
        Me.defaultTypeConverterGroupBox.Controls.Add(Me.defaultXAxisPropertyEditor)
        Me.defaultTypeConverterGroupBox.Controls.Add(Me.defaultYAxisPropertyEditor)
        Me.defaultTypeConverterGroupBox.Controls.Add(Me.defaultYAxisRangeLabel)
        Me.defaultTypeConverterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultTypeConverterGroupBox.Location = New System.Drawing.Point(8, 248)
        Me.defaultTypeConverterGroupBox.Name = "defaultTypeConverterGroupBox"
        Me.defaultTypeConverterGroupBox.Size = New System.Drawing.Size(248, 96)
        Me.defaultTypeConverterGroupBox.TabIndex = 1
        Me.defaultTypeConverterGroupBox.TabStop = False
        Me.defaultTypeConverterGroupBox.Text = "Default Range Type Converter"
        '
        'defaultXAxisRangeLabel
        '
        Me.defaultXAxisRangeLabel.AutoSize = True
        Me.defaultXAxisRangeLabel.Location = New System.Drawing.Point(16, 24)
        Me.defaultXAxisRangeLabel.Name = "defaultXAxisRangeLabel"
        Me.defaultXAxisRangeLabel.Size = New System.Drawing.Size(70, 16)
        Me.defaultXAxisRangeLabel.TabIndex = 3
        Me.defaultXAxisRangeLabel.Text = "XAxis Range"
        '
        'defaultXAxisPropertyEditor
        '
        Me.defaultXAxisPropertyEditor.Location = New System.Drawing.Point(96, 56)
        Me.defaultXAxisPropertyEditor.Name = "defaultXAxisPropertyEditor"
        Me.defaultXAxisPropertyEditor.Size = New System.Drawing.Size(128, 20)
        Me.defaultXAxisPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.defaultYAxis, "Range")
        Me.defaultXAxisPropertyEditor.TabIndex = 2
        '
        'defaultYAxisPropertyEditor
        '
        Me.defaultYAxisPropertyEditor.Location = New System.Drawing.Point(96, 24)
        Me.defaultYAxisPropertyEditor.Name = "defaultYAxisPropertyEditor"
        Me.defaultYAxisPropertyEditor.Size = New System.Drawing.Size(128, 20)
        Me.defaultYAxisPropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.defaultXAxis, "Range")
        Me.defaultYAxisPropertyEditor.TabIndex = 1
        '
        'defaultYAxisRangeLabel
        '
        Me.defaultYAxisRangeLabel.AutoSize = True
        Me.defaultYAxisRangeLabel.Location = New System.Drawing.Point(16, 56)
        Me.defaultYAxisRangeLabel.Name = "defaultYAxisRangeLabel"
        Me.defaultYAxisRangeLabel.Size = New System.Drawing.Size(70, 16)
        Me.defaultYAxisRangeLabel.TabIndex = 4
        Me.defaultYAxisRangeLabel.Text = "YAxis Range"
        '
        'customTypeConverterGroupBox
        '
        Me.customTypeConverterGroupBox.Controls.Add(Me.xAxisRangeLabel)
        Me.customTypeConverterGroupBox.Controls.Add(Me.yAxisRangePropertyEditor)
        Me.customTypeConverterGroupBox.Controls.Add(Me.xAxisRangePropertyEditor)
        Me.customTypeConverterGroupBox.Controls.Add(Me.yAxisRangeLabel)
        Me.customTypeConverterGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customTypeConverterGroupBox.Location = New System.Drawing.Point(8, 352)
        Me.customTypeConverterGroupBox.Name = "customTypeConverterGroupBox"
        Me.customTypeConverterGroupBox.Size = New System.Drawing.Size(248, 96)
        Me.customTypeConverterGroupBox.TabIndex = 2
        Me.customTypeConverterGroupBox.TabStop = False
        Me.customTypeConverterGroupBox.Text = "Custom Range Type Converter"
        '
        'xAxisRangeLabel
        '
        Me.xAxisRangeLabel.AutoSize = True
        Me.xAxisRangeLabel.Location = New System.Drawing.Point(16, 24)
        Me.xAxisRangeLabel.Name = "xAxisRangeLabel"
        Me.xAxisRangeLabel.Size = New System.Drawing.Size(70, 16)
        Me.xAxisRangeLabel.TabIndex = 3
        Me.xAxisRangeLabel.Text = "XAxis Range"
        '
        'yAxisRangePropertyEditor
        '
        Me.yAxisRangePropertyEditor.Location = New System.Drawing.Point(96, 56)
        Me.yAxisRangePropertyEditor.Name = "yAxisRangePropertyEditor"
        Me.yAxisRangePropertyEditor.Size = New System.Drawing.Size(128, 20)
        Me.yAxisRangePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.defaultYAxis, "Range")
        Me.yAxisRangePropertyEditor.TabIndex = 2
        '
        'xAxisRangePropertyEditor
        '
        Me.xAxisRangePropertyEditor.Location = New System.Drawing.Point(96, 24)
        Me.xAxisRangePropertyEditor.Name = "xAxisRangePropertyEditor"
        Me.xAxisRangePropertyEditor.Size = New System.Drawing.Size(128, 20)
        Me.xAxisRangePropertyEditor.Source = New NationalInstruments.UI.PropertyEditorSource(Me.defaultXAxis, "Range")
        Me.xAxisRangePropertyEditor.TabIndex = 1
        '
        'yAxisRangeLabel
        '
        Me.yAxisRangeLabel.AutoSize = True
        Me.yAxisRangeLabel.Location = New System.Drawing.Point(16, 56)
        Me.yAxisRangeLabel.Name = "yAxisRangeLabel"
        Me.yAxisRangeLabel.Size = New System.Drawing.Size(70, 16)
        Me.yAxisRangeLabel.TabIndex = 4
        Me.yAxisRangeLabel.Text = "YAxis Range"
        '
        'appendPointButton
        '
        Me.appendPointButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.appendPointButton.Location = New System.Drawing.Point(424, 216)
        Me.appendPointButton.Name = "appendPointButton"
        Me.appendPointButton.Size = New System.Drawing.Size(88, 23)
        Me.appendPointButton.TabIndex = 3
        Me.appendPointButton.Text = "Append Point"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(552, 470)
        Me.Controls.Add(Me.displayWaveformGraph)
        Me.Controls.Add(Me.defaultcolorEditorGroupBox)
        Me.Controls.Add(Me.customEditorGroupBox)
        Me.Controls.Add(Me.defaultTypeConverterGroupBox)
        Me.Controls.Add(Me.customTypeConverterGroupBox)
        Me.Controls.Add(Me.appendPointButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Extensibility"
        CType(Me.displayWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.defaultcolorEditorGroupBox.ResumeLayout(False)
        Me.customEditorGroupBox.ResumeLayout(False)
        Me.defaultTypeConverterGroupBox.ResumeLayout(False)
        Me.customTypeConverterGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub appendPointButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles appendPointButton.Click
        displayWaveformGraph.PlotYAppend(GetRandomValues(1))
    End Sub

    Public Class CustomRangeConverter
        Inherits TypeConverter
        Private _baseConverter As TypeConverter

        Private Const Separator As Char = "-"c

        Public Sub New(ByVal baseConverter As TypeConverter)
            _baseConverter = baseConverter
        End Sub

        Public Overloads Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
            Return _baseConverter.CanConvertFrom(context, sourceType)
        End Function

        Public Overloads Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object
            If (Not (value Is Nothing)) AndAlso (TypeOf value Is String) Then
                Dim valueText As String = CType(value, String)
                valueText = valueText.Trim
                Dim parts As String() = valueText.Split(Separator)
                If parts.Length <= 1 OrElse parts.Length > 2 Then
                    Throw New FormatException
                End If
                Dim minimum As Double
                Dim maximum As Double
                Try
                    minimum = Double.Parse(parts(0), CultureInfo.CurrentCulture)
                Catch ex As FormatException
                    Throw New FormatException("minimum", ex)
                End Try
                Try
                    maximum = Double.Parse(parts(1), CultureInfo.CurrentCulture)
                Catch ex As FormatException
                    Throw New FormatException("maximum", ex)
                End Try
                Return New Range(minimum, maximum)
            End If
            Return _baseConverter.ConvertFrom(context, culture, value)
        End Function

        Public Overloads Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
            Return _baseConverter.CanConvertTo(context, destinationType)
        End Function

        Public Overloads Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
            If (Not (value Is Nothing)) AndAlso (TypeOf value Is Range) Then
                Dim range As Range = CType(value, Range)
                Return String.Format(CultureInfo.InvariantCulture, "{0:R} {1} {2:R}", range.Minimum, Separator, range.Maximum)
            End If
            Return _baseConverter.ConvertTo(context, culture, value, destinationType)
        End Function
    End Class

    Public Class RangePropertyEditorSource
        Inherits PropertyEditorSource
        Private _customRangeConverter As CustomRangeConverter

        Public Sub New(ByVal obj As Object, ByVal propertyName As String)
            MyBase.New(obj, propertyName)
            Dim rangeConverter As TypeConverter = TypeDescriptor.GetConverter(GetType(Range))
            _customRangeConverter = New CustomRangeConverter(rangeConverter)
        End Sub

        Public Overloads Overrides ReadOnly Property Converter() As TypeConverter
            Get
                Return _customRangeConverter
            End Get
        End Property
    End Class

    Public Class CustomGraphColorEditor
        Inherits UITypeEditor

        Public Overloads Overrides Function GetEditStyle(ByVal context As ITypeDescriptorContext) As UITypeEditorEditStyle
            Return UITypeEditorEditStyle.None
        End Function

        Public Overloads Overrides Function EditValue(ByVal context As ITypeDescriptorContext, ByVal provider As IServiceProvider, ByVal value As Object) As Object
            Return MyBase.EditValue(context, provider, value)
        End Function
    End Class

    Public Class PlotColorPropertyEditorSource
        Inherits PropertyEditorSource
        Private _editor As CustomGraphColorEditor

        Public Sub New(ByVal obj As Object, ByVal propertyName As String)
            MyBase.New(obj, propertyName)
            _editor = New CustomGraphColorEditor
        End Sub

        Public Overloads Overrides ReadOnly Property Editor() As UITypeEditor
            Get
                Return _editor
            End Get
        End Property
    End Class

    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub 'Main

End Class