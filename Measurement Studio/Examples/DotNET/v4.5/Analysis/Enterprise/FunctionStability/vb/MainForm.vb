Public Class MainForm
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents denominatorLabel As System.Windows.Forms.Label
    Friend WithEvents NumeratorLabel As System.Windows.Forms.Label
    Friend WithEvents stableCheckLabel As System.Windows.Forms.Label
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents circlePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents toolTip As System.Windows.Forms.ToolTip
    Friend WithEvents polePlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents zeroPlot As NationalInstruments.UI.ScatterPlot
    Friend WithEvents horizontalAxis As NationalInstruments.UI.ScatterPlot
    Friend WithEvents verticalAxis As NationalInstruments.UI.ScatterPlot
    Friend WithEvents helpLabel As System.Windows.Forms.Label
    Friend WithEvents BzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AzTextBox As System.Windows.Forms.TextBox
    Friend WithEvents computeStabilityButton As System.Windows.Forms.Button
    Friend WithEvents stableCheckLed As NationalInstruments.UI.WindowsForms.Led
    Friend WithEvents poleZeroScatterGraph As NationalInstruments.UI.WindowsForms.ScatterGraph
    Friend WithEvents exampleLabel As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MainForm))
        Me.BzTextBox = New System.Windows.Forms.TextBox
        Me.denominatorLabel = New System.Windows.Forms.Label
        Me.AzTextBox = New System.Windows.Forms.TextBox
        Me.NumeratorLabel = New System.Windows.Forms.Label
        Me.stableCheckLed = New NationalInstruments.UI.WindowsForms.Led
        Me.computeStabilityButton = New System.Windows.Forms.Button
        Me.stableCheckLabel = New System.Windows.Forms.Label
        Me.poleZeroScatterGraph = New NationalInstruments.UI.WindowsForms.ScatterGraph
        Me.circlePlot = New NationalInstruments.UI.ScatterPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.polePlot = New NationalInstruments.UI.ScatterPlot
        Me.zeroPlot = New NationalInstruments.UI.ScatterPlot
        Me.horizontalAxis = New NationalInstruments.UI.ScatterPlot
        Me.verticalAxis = New NationalInstruments.UI.ScatterPlot
        Me.toolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.helpLabel = New System.Windows.Forms.Label
        Me.exampleLabel = New System.Windows.Forms.Label
        CType(Me.stableCheckLed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.poleZeroScatterGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BzTextBox
        '
        Me.BzTextBox.Location = New System.Drawing.Point(24, 112)
        Me.BzTextBox.Name = "BzTextBox"
        Me.BzTextBox.Size = New System.Drawing.Size(152, 20)
        Me.BzTextBox.TabIndex = 2
        Me.BzTextBox.Text = "1.1,0.25,0.3"
        '
        'denominatorLabel
        '
        Me.denominatorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.denominatorLabel.Location = New System.Drawing.Point(24, 96)
        Me.denominatorLabel.Name = "denominatorLabel"
        Me.denominatorLabel.Size = New System.Drawing.Size(56, 16)
        Me.denominatorLabel.TabIndex = 9
        Me.denominatorLabel.Text = "B(z)"
        '
        'AzTextBox
        '
        Me.AzTextBox.Location = New System.Drawing.Point(24, 56)
        Me.AzTextBox.Name = "AzTextBox"
        Me.AzTextBox.Size = New System.Drawing.Size(152, 20)
        Me.AzTextBox.TabIndex = 1
        Me.AzTextBox.Text = "1.2,0.5"
        '
        'NumeratorLabel
        '
        Me.NumeratorLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.NumeratorLabel.Location = New System.Drawing.Point(24, 40)
        Me.NumeratorLabel.Name = "NumeratorLabel"
        Me.NumeratorLabel.Size = New System.Drawing.Size(40, 16)
        Me.NumeratorLabel.TabIndex = 7
        Me.NumeratorLabel.Text = "A(z)"
        '
        'stableCheckLed
        '
        Me.stableCheckLed.LedStyle = NationalInstruments.UI.LedStyle.Round3D
        Me.stableCheckLed.Location = New System.Drawing.Point(32, 208)
        Me.stableCheckLed.Name = "stableCheckLed"
        Me.stableCheckLed.Size = New System.Drawing.Size(40, 41)
        Me.stableCheckLed.TabIndex = 11
        Me.stableCheckLed.TabStop = False
        '
        'computeStabilityButton
        '
        Me.computeStabilityButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.computeStabilityButton.Location = New System.Drawing.Point(24, 152)
        Me.computeStabilityButton.Name = "computeStabilityButton"
        Me.computeStabilityButton.Size = New System.Drawing.Size(152, 32)
        Me.computeStabilityButton.TabIndex = 0
        Me.computeStabilityButton.Text = "Compute Stability"
        Me.toolTip.SetToolTip(Me.computeStabilityButton, "Compute Stability of Y(z) = A(z)/B(z) ")
        '
        'stableCheckLabel
        '
        Me.stableCheckLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.stableCheckLabel.Location = New System.Drawing.Point(80, 220)
        Me.stableCheckLabel.Name = "stableCheckLabel"
        Me.stableCheckLabel.Size = New System.Drawing.Size(80, 17)
        Me.stableCheckLabel.TabIndex = 13
        Me.stableCheckLabel.Text = "Y(z) Unstable?"
        '
        'poleZeroScatterGraph
        '
        Me.poleZeroScatterGraph.Caption = "Pole Zero Plot"
        Me.poleZeroScatterGraph.Location = New System.Drawing.Point(216, 8)
        Me.poleZeroScatterGraph.Name = "poleZeroScatterGraph"
        Me.poleZeroScatterGraph.PlotAreaColor = System.Drawing.Color.White
        Me.poleZeroScatterGraph.Plots.AddRange(New NationalInstruments.UI.ScatterPlot() {Me.circlePlot, Me.polePlot, Me.zeroPlot, Me.horizontalAxis, Me.verticalAxis})
        Me.poleZeroScatterGraph.Size = New System.Drawing.Size(296, 296)
        Me.poleZeroScatterGraph.TabIndex = 14
        Me.poleZeroScatterGraph.TabStop = False
        Me.poleZeroScatterGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.poleZeroScatterGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'circlePlot
        '
        Me.circlePlot.LineColor = System.Drawing.Color.Red
        Me.circlePlot.XAxis = Me.xAxis
        Me.circlePlot.YAxis = Me.yAxis
        '
        'xAxis
        '
        Me.xAxis.AutoSpacing = False
        Me.xAxis.MajorDivisions.GridColor = System.Drawing.Color.LightBlue
        Me.xAxis.MajorDivisions.GridVisible = True
        Me.xAxis.MajorDivisions.Interval = 1
        Me.xAxis.MinorDivisions.GridColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
        Me.xAxis.MinorDivisions.Interval = 0.5
        Me.xAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact
        Me.xAxis.Range = New NationalInstruments.UI.Range(-2, 1.99824566019772)
        '
        'yAxis
        '
        Me.yAxis.AutoSpacing = False
        Me.yAxis.MajorDivisions.GridColor = System.Drawing.Color.LightBlue
        Me.yAxis.MajorDivisions.GridVisible = True
        Me.yAxis.MajorDivisions.Interval = 1
        Me.yAxis.MinorDivisions.Interval = 0.5
        Me.yAxis.Mode = NationalInstruments.UI.AxisMode.AutoScaleExact
        Me.yAxis.Range = New NationalInstruments.UI.Range(-2, 1.99824566019772)
        '
        'polePlot
        '
        Me.polePlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.polePlot.PointColor = System.Drawing.Color.Green
        Me.polePlot.PointStyle = NationalInstruments.UI.PointStyle.Cross
        Me.polePlot.XAxis = Me.xAxis
        Me.polePlot.YAxis = Me.yAxis
        '
        'zeroPlot
        '
        Me.zeroPlot.LineStyle = NationalInstruments.UI.LineStyle.None
        Me.zeroPlot.PointColor = System.Drawing.Color.Blue
        Me.zeroPlot.PointStyle = NationalInstruments.UI.PointStyle.EmptyCircle
        Me.zeroPlot.XAxis = Me.xAxis
        Me.zeroPlot.YAxis = Me.yAxis
        '
        'horizontalAxis
        '
        Me.horizontalAxis.LineColor = System.Drawing.Color.Red
        Me.horizontalAxis.XAxis = Me.xAxis
        Me.horizontalAxis.YAxis = Me.yAxis
        '
        'verticalAxis
        '
        Me.verticalAxis.LineColor = System.Drawing.Color.Red
        Me.verticalAxis.XAxis = Me.xAxis
        Me.verticalAxis.YAxis = Me.yAxis
        '
        'helpLabel
        '
        Me.helpLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.helpLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpLabel.Location = New System.Drawing.Point(24, 320)
        Me.helpLabel.Name = "helpLabel"
        Me.helpLabel.Size = New System.Drawing.Size(488, 48)
        Me.helpLabel.TabIndex = 15
        Me.helpLabel.Text = "This example evaluates the stability of the system: Y(z) = A(z)/B(z) and uses the" & _
        " Complex Polynomial Roots method. The coefficients for polynomial A(z) and B(z) " & _
        "are specified left to right with the highest order coefficients specified first " & _
        "."
        '
        'exampleLabel
        '
        Me.exampleLabel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.exampleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exampleLabel.Location = New System.Drawing.Point(24, 376)
        Me.exampleLabel.Name = "exampleLabel"
        Me.exampleLabel.Size = New System.Drawing.Size(336, 24)
        Me.exampleLabel.TabIndex = 16
        Me.exampleLabel.Text = "For example: 0.5x^3 + 0.3x^2 + 1 is specified as 0.5,0.3,1.0 "
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(544, 413)
        Me.Controls.Add(Me.exampleLabel)
        Me.Controls.Add(Me.helpLabel)
        Me.Controls.Add(Me.poleZeroScatterGraph)
        Me.Controls.Add(Me.stableCheckLed)
        Me.Controls.Add(Me.BzTextBox)
        Me.Controls.Add(Me.AzTextBox)
        Me.Controls.Add(Me.stableCheckLabel)
        Me.Controls.Add(Me.computeStabilityButton)
        Me.Controls.Add(Me.denominatorLabel)
        Me.Controls.Add(Me.NumeratorLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Function Stability"
        CType(Me.stableCheckLed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.poleZeroScatterGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    <STAThread()> Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.DoEvents()
        Application.Run(New MainForm)
    End Sub

    Private Sub computeStability_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles computeStabilityButton.Click
        Dim i As Integer
        Dim numeratorString As String
        Dim denominatorString As String
        Dim splitNumeratorString() As String
        Dim splitDenominatorString() As String
        Dim numeratorCoefficients() As Double
        Dim denominatorCoefficients() As Double
        Dim zeroMagnitude() As Double
        Dim zeroPhase() As Double
        Dim zeroReal() As Double
        Dim zeroImaginary() As Double
        Dim poleMagnitude() As Double
        Dim polePhase() As Double
        Dim poleReal() As Double
        Dim poleImaginary() As Double
        Dim poleMaximum, poleMinimum As Double
        Dim zeroMaximum, zeroMinimum As Double
        Dim maximumOfPoleZero As Double
        Dim xWaveform() As Double
        Dim yWaveform() As Double
        Dim horizontal() As Double
        Dim vertical() As Double
        Dim indexOfMaximum, indexOfMinimum As Integer
        Dim zeros() As NationalInstruments.ComplexDouble
        Dim poles() As NationalInstruments.ComplexDouble
        xWaveform = New Double(10000 - 1) {}
        yWaveform = New Double(10000 - 1) {}

        Dim sin As SineSignal = New SineSignal(100, 1.0, 0.0)
        Dim cos As SineSignal = New SineSignal(100, 1.0, 90.0)
        xWaveform = sin.Generate(100000, 10000)
        yWaveform = cos.Generate(100000, 10000)

        numeratorString = AzTextBox.Text 'take the numerator coefficients
        denominatorString = BzTextBox.Text 'take the denominator coefficients.

        Try
            'Extracting numerator coefficients from numeratorString.
            splitNumeratorString = System.Text.RegularExpressions.Regex.Split(numeratorString, ",")
            'Extracting denominator coefficients from denominatorString.
            splitDenominatorString = System.Text.RegularExpressions.Regex.Split(denominatorString, ",")

            'Memory allocation for numerator's coefficients arrays
            numeratorCoefficients = New Double(splitNumeratorString.Length - 1) {}

            'Memory allocation for denominator's coeffiecients arrays 
            denominatorCoefficients = New Double(splitDenominatorString.Length - 1) {}

            'Converting the string array to double array to get actual numerator coefficients.
            For i = 0 To (splitNumeratorString.Length - 1)
                numeratorCoefficients(i) = System.Convert.ToDouble(splitNumeratorString(i))
            Next i
            'Converting the string array to double array to get actual denominator coefficients.
            For i = 0 To (splitDenominatorString.Length - 1)
                denominatorCoefficients(i) = System.Convert.ToDouble(splitDenominatorString(i))
            Next i

            'Find zeros and poles of the polynomial function.
            zeros = Roots.FindPolynomialRoots(numeratorCoefficients)
            poles = Roots.FindPolynomialRoots(denominatorCoefficients)

            'memory allocation to store properties of zeros 
            zeroMagnitude = New Double(zeros.Length - 1) {}
            zeroPhase = New Double(zeros.Length - 1) {}
            zeroReal = New Double(zeros.Length - 1) {}
            zeroImaginary = New Double(zeros.Length - 1) {}

            'memory allocation to store properties of poles
            poleMagnitude = New Double(poles.Length - 1) {}
            polePhase = New Double(poles.Length - 1) {}
            poleReal = New Double(poles.Length - 1) {}
            poleImaginary = New Double(poles.Length - 1) {}

            'Storing magnitude, phase, real and imaginary values 
            'of each zero and pole of the polynomial function.
            For i = 0 To (zeros.Length - 1)
                zeroMagnitude(i) = zeros(i).Magnitude
                zeroPhase(i) = zeros(i).Phase
                zeroReal(i) = zeros(i).Real
                zeroImaginary(i) = zeros(i).Imaginary
            Next i
            For i = 0 To (poles.Length - 1)
                poleMagnitude(i) = poles(i).Magnitude
                polePhase(i) = poles(i).Phase
                poleReal(i) = poles(i).Real
                poleImaginary(i) = poles(i).Imaginary
            Next i

            ArrayOperation.MaxMin1D(zeroMagnitude, zeroMaximum, indexOfMaximum, zeroMinimum, indexOfMinimum)
            ' Check for stability. 
            ' If the magnitude of any of the poles is greater than 1, polynomial function would be
            ' unstable, otherwise the polynomial function would be stable.
            ArrayOperation.MaxMin1D(poleMagnitude, poleMaximum, indexOfMaximum, poleMinimum, indexOfMinimum)
            If (poleMaximum > 1.0) Then
                stableCheckLed.Value = True
            Else
                stableCheckLed.Value = False
            End If

            ' Assign maximum value of pole or zero to maximumOfPoleZero.
            If (poleMaximum > zeroMaximum) Then
                maximumOfPoleZero = poleMaximum
            Else
                maximumOfPoleZero = zeroMaximum
            End If

            ' Plot the zeros and poles in the z domain graph.

            ' Plot a circle of radius 1.
            circlePlot.PlotXY(xWaveform, yWaveform)

            ' Plot horizontal axis. 
            horizontal = New Double(2) {}
            vertical = New Double(2) {}
            horizontal(0) = -(maximumOfPoleZero + 2)
            horizontal(1) = (maximumOfPoleZero + 2)
            vertical(0) = 0
            vertical(1) = 0
            horizontalAxis.PlotXY(horizontal, vertical)

            ' Plot Vertical axis.
            horizontal(0) = 0
            horizontal(1) = 0
            vertical(0) = -(maximumOfPoleZero + 2)
            vertical(1) = (maximumOfPoleZero + 2)
            verticalAxis.PlotXY(horizontal, vertical)

            ' Plot poles.
            polePlot.PlotXY(poleReal, poleImaginary)

            ' Plot zeros.
            zeroPlot.PlotXY(zeroReal, zeroImaginary)
        Catch exp As System.Exception
            MessageBox.Show(exp.Message)
        End Try

    End Sub
End Class
