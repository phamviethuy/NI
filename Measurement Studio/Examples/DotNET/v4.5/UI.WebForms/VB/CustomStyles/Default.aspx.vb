
Imports NationalInstruments.UI
Imports System
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class DefaultAspx
    Inherits Page

    Const DefaultDataLength As Integer = 100
    Const DefaultDataRange As Integer = 10

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        If Not IsPostBack Then
            customWaveformGraph.PlotY(GenerateData())
        End If
    End Sub

    Protected Sub lineStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case lineStyleDropDownList.SelectedValue
            Case "None"
                Plot.LineStyle = LineStyle.None
            Case "Solid"
                Plot.LineStyle = LineStyle.Solid
            Case "Custom"
                Plot.LineStyle = New CustomLineStyle
        End Select
    End Sub

    Protected Sub pointStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        largePointsCheckBox.Enabled = (pointStyleDropDownList.SelectedValue <> "None")

        Select Case pointStyleDropDownList.SelectedValue
            Case "None"
                Plot.PointStyle = PointStyle.None
            Case "Empty Square"
                Plot.PointStyle = PointStyle.EmptySquare
            Case "Custom"
                Plot.PointStyle = New CustomPointStyle
        End Select
    End Sub

    Protected Sub borderStyle_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Select Case borderStyleDropDownList.SelectedValue
            Case "None"
                customWaveformGraph.Border = Border.None
            Case "Raised"
                customWaveformGraph.Border = Border.Raised
            Case "Custom"
                customWaveformGraph.Border = New CustomBorder
        End Select
    End Sub

    Protected Sub pointSize_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If largePointsCheckBox.Checked Then
            Plot.PointSize = New Size(8, 8)
        Else
            Plot.PointSize = New Size(5, 5)
        End If
    End Sub

    Private Shared Function GenerateSineWave(ByVal xRange As Integer, ByVal yRange As Integer) As Double()
        If (xRange < 0) Then
            Throw New ArgumentOutOfRangeException("xRange")
        End If

        If (yRange < 0) Then
            Throw New ArgumentOutOfRangeException("yRange")
        End If

        Dim data(xRange) As Double

        For i As Integer = 0 To xRange
            data(i) = yRange / 2 * (1 - Math.Sin(i * 2 * Math.PI / (xRange - 1)))
        Next
        Return data
    End Function

    Private ReadOnly Property Plot() As XYPlot
        Get
            Return customWaveformGraph.Plots(0)
        End Get
    End Property

    Private Shared Function GenerateData() As Double()
        Return GenerateSineWave(DefaultDataLength, DefaultDataRange)
    End Function

    <Serializable()> Private Class CustomLineStyle
        Inherits LineStyle

        Public Overrides ReadOnly Property IsContextDependent() As Boolean
            Get
                Return True
            End Get
        End Property

        Public Overrides Function CreatePen(ByVal context As Object, ByVal args As LineStyleDrawArgs) As Pen
            Dim bounds As Rectangle = args.ContextBounds

            bounds.Width += 1
            bounds.Height += 1

            Using penBrush As Brush = New LinearGradientBrush(bounds, Color.Red, Color.Blue, LinearGradientMode.Vertical)
                Return New Pen(penBrush, args.Width)
            End Using
        End Function
    End Class

    <Serializable()> Private Class CustomPointStyle
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

        Private Function CreateDrawArgs(ByVal args As PointStyleDrawArgs, ByVal color As Color) As PointStyleDrawArgs
            Return New PointStyleDrawArgs(args.Graphics, args.X, args.Y, color, args.Size)
        End Function

    End Class

    <Serializable()> Private Class CustomBorder
        Inherits Border

        Public Overrides Sub Draw(ByVal context As Object, ByVal args As BorderDrawArgs)
            Dim g As Graphics = args.Graphics
            Dim bounds As Rectangle = args.Bounds

            Using borderPen As Pen = New Pen(Color.Blue)
                Dim borderRectangle As New Rectangle(bounds.X + 1, bounds.Y + 1, bounds.X + bounds.Width - 2, bounds.Y + bounds.Height - 2)
                g.DrawRectangle(borderPen, borderRectangle)

                borderRectangle.Inflate(-2, -2)
                g.DrawRectangle(borderPen, borderRectangle)
            End Using
        End Sub

        Public Overrides Function GetInnerRectangle(ByVal outerRectangle As Rectangle) As Rectangle
            Dim innerRectangle As Rectangle = outerRectangle
            innerRectangle.Inflate(-5, -5)

            Return innerRectangle
        End Function

    End Class
End Class