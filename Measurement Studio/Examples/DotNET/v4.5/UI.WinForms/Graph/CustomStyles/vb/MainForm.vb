Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'Me call is required by the Windows Form Designer.
        InitializeComponent()
        
        AddHandler customLineStyleRadioButton.CheckedChanged, AddressOf Me.OnLineStyleChanged
        AddHandler defaultLineStyleRadioButton.CheckedChanged, AddressOf Me.OnLineStyleChanged
        AddHandler disabledLineStyleCheckBox.CheckedChanged, AddressOf Me.OnLineStyleChanged
        AddHandler defaultPointStyleRadioButton.CheckedChanged, AddressOf Me.OnPointStyleChanged
        AddHandler customPointStyleRadioButton.CheckedChanged, AddressOf Me.OnPointStyleChanged
        AddHandler disabledPointStyleCheckBox.CheckedChanged, AddressOf Me.OnPointStyleChanged
        AddHandler defaultPointSizeRadioButton.CheckedChanged, AddressOf Me.OnPointSizeChanged
        AddHandler customPointSizeRadioButton.CheckedChanged, AddressOf Me.OnPointSizeChanged
        AddHandler defaultBorderRadioButton.CheckedChanged, AddressOf Me.OnBorderChanged
        AddHandler customBorderRadioButton.CheckedChanged, AddressOf Me.OnBorderChanged
        AddHandler disabledBorderCheckBox.CheckedChanged, AddressOf Me.OnBorderChanged

        plot.PlotY(GenerateSineWave(100, 10))

        'Save default values and create custom values
        defaultLineStyle = plot.LineStyle
        customLineStyle = New CustomLineStyleImpl
        defaultPointStyle = plot.PointStyle
        customPointStyle = New CustomPointStyleImpl()
        defaultPointSize = plot.PointSize
        customPointSize = New Size(defaultPointSize.Width + 2, defaultPointSize.Height + 2)
        defaultBorder = sampleWaveformGraph.Border
        customBorder = New CustomBorderImpl()
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

    Private defaultLineStyle As LineStyle
    Private customLineStyle As LineStyle
    Private defaultPointStyle As PointStyle
    Private customPointStyle As PointStyle
    Private defaultPointSize As Size
    Private customPointSize As Size
    Private defaultBorder As Border
    Private customBorder As Border

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents plot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents lineStyleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultLineStyleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents customLineStyleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents disabledLineStyleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents pointStyleGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultPointStyleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents customPointStyleRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents disabledPointStyleCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents borderGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultBorderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents customBorderRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents disabledBorderCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents pointSizeGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents defaultPointSizeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents customPointSizeRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        Me.plot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.lineStyleGroupBox = New System.Windows.Forms.GroupBox
        Me.disabledLineStyleCheckBox = New System.Windows.Forms.CheckBox
        Me.customLineStyleRadioButton = New System.Windows.Forms.RadioButton
        Me.defaultLineStyleRadioButton = New System.Windows.Forms.RadioButton
        Me.pointStyleGroupBox = New System.Windows.Forms.GroupBox
        Me.disabledPointStyleCheckBox = New System.Windows.Forms.CheckBox
        Me.customPointStyleRadioButton = New System.Windows.Forms.RadioButton
        Me.defaultPointStyleRadioButton = New System.Windows.Forms.RadioButton
        Me.borderGroupBox = New System.Windows.Forms.GroupBox
        Me.disabledBorderCheckBox = New System.Windows.Forms.CheckBox
        Me.customBorderRadioButton = New System.Windows.Forms.RadioButton
        Me.defaultBorderRadioButton = New System.Windows.Forms.RadioButton
        Me.pointSizeGroupBox = New System.Windows.Forms.GroupBox
        Me.customPointSizeRadioButton = New System.Windows.Forms.RadioButton
        Me.defaultPointSizeRadioButton = New System.Windows.Forms.RadioButton
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lineStyleGroupBox.SuspendLayout()
        Me.pointStyleGroupBox.SuspendLayout()
        Me.borderGroupBox.SuspendLayout()
        Me.pointSizeGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sampleWaveformGraph.Caption = "2D Graph"
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(8, 8)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.plot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(384, 272)
        Me.sampleWaveformGraph.TabIndex = 0
        Me.toolTip.SetToolTip(Me.sampleWaveformGraph, "National Instruments Waveform Graph")
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'plot
        '
        Me.plot.LineWidth = 1.5!
        Me.plot.PointSize = New System.Drawing.Size(3, 3)
        Me.plot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle
        Me.plot.XAxis = Me.xAxis
        Me.plot.YAxis = Me.yAxis
        '
        'lineStyleGroupBox
        '
        Me.lineStyleGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lineStyleGroupBox.Controls.Add(Me.disabledLineStyleCheckBox)
        Me.lineStyleGroupBox.Controls.Add(Me.customLineStyleRadioButton)
        Me.lineStyleGroupBox.Controls.Add(Me.defaultLineStyleRadioButton)
        Me.lineStyleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.lineStyleGroupBox.Location = New System.Drawing.Point(8, 288)
        Me.lineStyleGroupBox.Name = "lineStyleGroupBox"
        Me.lineStyleGroupBox.Size = New System.Drawing.Size(184, 80)
        Me.lineStyleGroupBox.TabIndex = 1
        Me.lineStyleGroupBox.TabStop = False
        Me.lineStyleGroupBox.Text = "Line Style"
        '
        'disabledLineStyleCheckBox
        '
        Me.disabledLineStyleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.disabledLineStyleCheckBox.Location = New System.Drawing.Point(96, 24)
        Me.disabledLineStyleCheckBox.Name = "disabledLineStyleCheckBox"
        Me.disabledLineStyleCheckBox.Size = New System.Drawing.Size(80, 24)
        Me.disabledLineStyleCheckBox.TabIndex = 4
        Me.disabledLineStyleCheckBox.Text = "Disabled"
        Me.toolTip.SetToolTip(Me.disabledLineStyleCheckBox, "Disable line style of plot")
        '
        'customLineStyleRadioButton
        '
        Me.customLineStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customLineStyleRadioButton.Location = New System.Drawing.Point(8, 48)
        Me.customLineStyleRadioButton.Name = "customLineStyleRadioButton"
        Me.customLineStyleRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.customLineStyleRadioButton.TabIndex = 3
        Me.customLineStyleRadioButton.TabStop = True
        Me.customLineStyleRadioButton.Text = "Custom"
        Me.toolTip.SetToolTip(Me.customLineStyleRadioButton, "Set the line style to a custom value")
        '
        'defaultLineStyleRadioButton
        '
        Me.defaultLineStyleRadioButton.Checked = True
        Me.defaultLineStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultLineStyleRadioButton.Location = New System.Drawing.Point(8, 24)
        Me.defaultLineStyleRadioButton.Name = "defaultLineStyleRadioButton"
        Me.defaultLineStyleRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.defaultLineStyleRadioButton.TabIndex = 2
        Me.defaultLineStyleRadioButton.TabStop = True
        Me.defaultLineStyleRadioButton.Text = "Default"
        Me.toolTip.SetToolTip(Me.defaultLineStyleRadioButton, "Set the line style to its default value")
        '
        'pointStyleGroupBox
        '
        Me.pointStyleGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pointStyleGroupBox.Controls.Add(Me.disabledPointStyleCheckBox)
        Me.pointStyleGroupBox.Controls.Add(Me.customPointStyleRadioButton)
        Me.pointStyleGroupBox.Controls.Add(Me.defaultPointStyleRadioButton)
        Me.pointStyleGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.pointStyleGroupBox.Location = New System.Drawing.Point(208, 288)
        Me.pointStyleGroupBox.Name = "pointStyleGroupBox"
        Me.pointStyleGroupBox.Size = New System.Drawing.Size(184, 80)
        Me.pointStyleGroupBox.TabIndex = 5
        Me.pointStyleGroupBox.TabStop = False
        Me.pointStyleGroupBox.Text = "Point Style"
        '
        'disabledPointStyleCheckBox
        '
        Me.disabledPointStyleCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.disabledPointStyleCheckBox.Location = New System.Drawing.Point(96, 24)
        Me.disabledPointStyleCheckBox.Name = "disabledPointStyleCheckBox"
        Me.disabledPointStyleCheckBox.Size = New System.Drawing.Size(80, 24)
        Me.disabledPointStyleCheckBox.TabIndex = 8
        Me.disabledPointStyleCheckBox.Text = "Disabled"
        Me.toolTip.SetToolTip(Me.disabledPointStyleCheckBox, "Disable point style of plot")
        '
        'customPointStyleRadioButton
        '
        Me.customPointStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customPointStyleRadioButton.Location = New System.Drawing.Point(16, 48)
        Me.customPointStyleRadioButton.Name = "customPointStyleRadioButton"
        Me.customPointStyleRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.customPointStyleRadioButton.TabIndex = 7
        Me.customPointStyleRadioButton.TabStop = True
        Me.customPointStyleRadioButton.Text = "Custom"
        Me.toolTip.SetToolTip(Me.customPointStyleRadioButton, "Set the point style to a custom value")
        '
        'defaultPointStyleRadioButton
        '
        Me.defaultPointStyleRadioButton.Checked = True
        Me.defaultPointStyleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultPointStyleRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.defaultPointStyleRadioButton.Name = "defaultPointStyleRadioButton"
        Me.defaultPointStyleRadioButton.Size = New System.Drawing.Size(72, 24)
        Me.defaultPointStyleRadioButton.TabIndex = 6
        Me.defaultPointStyleRadioButton.TabStop = True
        Me.defaultPointStyleRadioButton.Text = "Default"
        Me.toolTip.SetToolTip(Me.defaultPointStyleRadioButton, "Set the point style to its default value")
        '
        'borderGroupBox
        '
        Me.borderGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.borderGroupBox.Controls.Add(Me.disabledBorderCheckBox)
        Me.borderGroupBox.Controls.Add(Me.customBorderRadioButton)
        Me.borderGroupBox.Controls.Add(Me.defaultBorderRadioButton)
        Me.borderGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.borderGroupBox.Location = New System.Drawing.Point(8, 376)
        Me.borderGroupBox.Name = "borderGroupBox"
        Me.borderGroupBox.Size = New System.Drawing.Size(184, 80)
        Me.borderGroupBox.TabIndex = 9
        Me.borderGroupBox.TabStop = False
        Me.borderGroupBox.Text = "Border"
        '
        'disabledBorderCheckBox
        '
        Me.disabledBorderCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.disabledBorderCheckBox.Location = New System.Drawing.Point(96, 24)
        Me.disabledBorderCheckBox.Name = "disabledBorderCheckBox"
        Me.disabledBorderCheckBox.Size = New System.Drawing.Size(80, 24)
        Me.disabledBorderCheckBox.TabIndex = 12
        Me.disabledBorderCheckBox.Text = "Disabled"
        Me.toolTip.SetToolTip(Me.disabledBorderCheckBox, "Disable graph border")
        '
        'customBorderRadioButton
        '
        Me.customBorderRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customBorderRadioButton.Location = New System.Drawing.Point(8, 48)
        Me.customBorderRadioButton.Name = "customBorderRadioButton"
        Me.customBorderRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.customBorderRadioButton.TabIndex = 11
        Me.customBorderRadioButton.TabStop = True
        Me.customBorderRadioButton.Text = "Custom"
        Me.toolTip.SetToolTip(Me.customBorderRadioButton, "Set the border to a custom value")
        '
        'defaultBorderRadioButton
        '
        Me.defaultBorderRadioButton.Checked = True
        Me.defaultBorderRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultBorderRadioButton.Location = New System.Drawing.Point(8, 24)
        Me.defaultBorderRadioButton.Name = "defaultBorderRadioButton"
        Me.defaultBorderRadioButton.Size = New System.Drawing.Size(80, 24)
        Me.defaultBorderRadioButton.TabIndex = 10
        Me.defaultBorderRadioButton.TabStop = True
        Me.defaultBorderRadioButton.Text = "Default"
        Me.toolTip.SetToolTip(Me.defaultBorderRadioButton, "Set the border to its default value")
        '
        'pointSizeGroupBox
        '
        Me.pointSizeGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pointSizeGroupBox.Controls.Add(Me.customPointSizeRadioButton)
        Me.pointSizeGroupBox.Controls.Add(Me.defaultPointSizeRadioButton)
        Me.pointSizeGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.pointSizeGroupBox.Location = New System.Drawing.Point(208, 376)
        Me.pointSizeGroupBox.Name = "pointSizeGroupBox"
        Me.pointSizeGroupBox.Size = New System.Drawing.Size(184, 80)
        Me.pointSizeGroupBox.TabIndex = 13
        Me.pointSizeGroupBox.TabStop = False
        Me.pointSizeGroupBox.Text = "Point Size"
        '
        'customPointSizeRadioButton
        '
        Me.customPointSizeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.customPointSizeRadioButton.Location = New System.Drawing.Point(16, 48)
        Me.customPointSizeRadioButton.Name = "customPointSizeRadioButton"
        Me.customPointSizeRadioButton.Size = New System.Drawing.Size(64, 24)
        Me.customPointSizeRadioButton.TabIndex = 15
        Me.customPointSizeRadioButton.TabStop = True
        Me.customPointSizeRadioButton.Text = "Custom"
        Me.toolTip.SetToolTip(Me.customPointSizeRadioButton, "Set the point size to a custom value")
        '
        'defaultPointSizeRadioButton
        '
        Me.defaultPointSizeRadioButton.Checked = True
        Me.defaultPointSizeRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.defaultPointSizeRadioButton.Location = New System.Drawing.Point(16, 24)
        Me.defaultPointSizeRadioButton.Name = "defaultPointSizeRadioButton"
        Me.defaultPointSizeRadioButton.Size = New System.Drawing.Size(64, 24)
        Me.defaultPointSizeRadioButton.TabIndex = 14
        Me.defaultPointSizeRadioButton.TabStop = True
        Me.defaultPointSizeRadioButton.Text = "Default"
        Me.toolTip.SetToolTip(Me.defaultPointSizeRadioButton, "Set the point size to its default value")
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(402, 464)
        Me.Controls.Add(Me.pointSizeGroupBox)
        Me.Controls.Add(Me.borderGroupBox)
        Me.Controls.Add(Me.pointStyleGroupBox)
        Me.Controls.Add(Me.lineStyleGroupBox)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(408, 496)
        Me.Name = "MainForm"
        Me.Text = "Custom Styles Example"
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lineStyleGroupBox.ResumeLayout(False)
        Me.pointStyleGroupBox.ResumeLayout(False)
        Me.borderGroupBox.ResumeLayout(False)
        Me.pointSizeGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub

    Private Shared Function GenerateSineWave(ByVal xRange As Integer, ByVal yRange As Integer) As Double()
        If (xRange < 1) Then
            Throw New ArgumentOutOfRangeException("xRange")
        End If

        If (yRange < 1) Then
            Throw New ArgumentOutOfRangeException("yRange")
        End If

        Dim data(xRange - 1) As Double
        Dim i As Integer

        For i = 0 To xRange - 1
            data(i) = yRange / 2 * (1 - Math.Sin(i * 2 * Math.PI / (xRange - 1)))
        Next

        Return data
    End Function

    Private Sub OnLineStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SetLineStyle()
    End Sub

    Private Sub OnPointStyleChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SetPointStyle()
    End Sub

    Private Sub OnPointSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SetPointSize()
    End Sub

    Private Sub OnBorderChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        SetBorder()
    End Sub

    Private Sub SetLineStyle()
        If (disabledLineStyleCheckBox.Checked) Then
            plot.LineStyle = LineStyle.None
        Else
            If (defaultLineStyleRadioButton.Checked) Then
                plot.LineStyle = defaultLineStyle
            Else
                plot.LineStyle = customLineStyle
            End If
        End If
    End Sub

    Private Sub SetPointStyle()
        If (disabledPointStyleCheckBox.Checked) Then
            plot.PointStyle = PointStyle.None
            pointSizeGroupBox.Enabled = False
        Else
            pointSizeGroupBox.Enabled = True
            If (defaultPointStyleRadioButton.Checked) Then
                plot.PointStyle = defaultPointStyle
            Else
                plot.PointStyle = customPointStyle
            End If
        End If
    End Sub

    Private Sub SetPointSize()
        If (defaultPointSizeRadioButton.Checked) Then
            plot.PointSize = defaultPointSize
        Else
            If (customPointSizeRadioButton.Checked) Then
                plot.PointSize = customPointSize
            End If
        End If
    End Sub

    Private Sub SetBorder()
        If (disabledBorderCheckBox.Checked) Then
            sampleWaveformGraph.Border = Border.None
        Else
            If (defaultBorderRadioButton.Checked) Then
                sampleWaveformGraph.Border = defaultBorder
            Else
                sampleWaveformGraph.Border = customBorder
            End If
        End If
    End Sub

    Private Class CustomBorderImpl
        Inherits Border

        Public Overrides Sub Draw(ByVal context As Object, ByVal args As BorderDrawArgs)
            Dim g As Graphics = args.Graphics
            Dim bounds As Rectangle = args.Bounds

            Dim pen As Pen
            pen = Nothing
            Try
                pen = New pen(SystemColors.ActiveCaption)
                Dim borderRectangle As New Rectangle(bounds.X + 1, bounds.Y + 1, bounds.X + bounds.Width - 2, bounds.Y + bounds.Height - 2)
                g.DrawRectangle(pen, borderRectangle)

                borderRectangle.Inflate(-2, -2)
                g.DrawRectangle(pen, borderRectangle)
            Finally
                pen.Dispose()
            End Try
        End Sub

        Public Overrides Function GetInnerRectangle(ByVal outerRectangle As Rectangle) As Rectangle
            Dim innerRectangle As Rectangle = outerRectangle
            innerRectangle.Inflate(-5, -5)

            Return innerRectangle
        End Function

    End Class

    Private Class CustomLineStyleImpl
        Inherits LineStyle

        Public Sub New()
        End Sub

        Public Overrides ReadOnly Property IsContextDependent() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides Function CreatePen(ByVal context As Object, ByVal args As LineStyleDrawArgs) As Pen
            Dim bounds As Rectangle = args.ContextBounds

            bounds.Width += 1
            bounds.Height += 1

            Dim brush As System.Drawing.Brush
            brush = Nothing
            Try
                brush = New LinearGradientBrush(bounds, Color.Red, Color.Blue, LinearGradientMode.Vertical)
                Return New Pen(brush, args.Width)
            Finally
                brush.Dispose()
            End Try
        End Function

    End Class

    Private Class CustomPointStyleImpl
        Inherits PointStyle

        Public Overrides Sub Draw(ByVal context As Object, ByVal args As PointStyleDrawArgs)
            If args.Y < 3 Then
                PointStyle.SolidSquare.Draw(context, CreateDrawArgs(args, Color.Red))
            ElseIf args.Y < 7 Then
                PointStyle.EmptySquare.Draw(context, CreateDrawArgs(args, Color.Yellow))
            Else
                PointStyle.Plus.Draw(context, CreateDrawArgs(args, Color.LightBlue))
            End If
        End Sub

        Public Overrides ReadOnly Property IsValueDependent() As Boolean
            Get
                Return True
            End Get
        End Property

        Private Shared Function CreateDrawArgs(ByVal args As PointStyleDrawArgs, ByVal color As Color) As PointStyleDrawArgs
            Return New PointStyleDrawArgs(args.Graphics, args.X, args.Y, color, args.Size)
        End Function

    End Class

End Class
