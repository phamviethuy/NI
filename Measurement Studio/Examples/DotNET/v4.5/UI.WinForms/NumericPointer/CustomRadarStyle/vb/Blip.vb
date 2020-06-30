Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class Blip
    Private Const MoveBlipAmount As Single = 0.001F
    Private Const BlipRadius As Single = 2.0F
    Private Const ErrorMargin As Single = 0.1F
    Private Const AlphaReduce As Integer = 10

    Private alpha As Integer
    Private color As Color
    Private ratioOffset As Single
    Private blipValue As Double
    Private style As NumericPointerStyle


    Public Sub New(ByVal numericStyle As NumericPointerStyle, ByVal value As Double, ByVal offset As Single, ByVal blipColor As Color)
        Debug.Assert(value >= 0 And value <= 10, "value must be between 0 and 10")
        Debug.Assert(offset <= 0 And offset >= -1, "offset must be between 0 and -1")

        color = blipColor
        blipValue = value
        ratioOffset = offset
        style = numericStyle
    End Sub

    Public Sub DrawBlip(ByVal context As IRadialNumericPointer, ByVal graphics As Graphics, ByVal bounds As Rectangle, ByVal controlValue As Double)
        Dim startPoint As PointF
        Dim endPoint As PointF

        style.MapValue(context, bounds, blipValue, startPoint, endPoint)
        DrawUtility.OffsetLineByRatio(startPoint, endPoint, 0, ratioOffset, startPoint, endPoint)
        Dim blimpRectangle As RectangleF = New RectangleF(endPoint.X - BlipRadius, endPoint.Y - BlipRadius, BlipRadius * 2, BlipRadius * 2)

        If controlValue >= blipValue And controlValue < blipValue + ErrorMargin Then
            alpha = 255
        End If

        Dim brush As Brush
        brush = Nothing
        Try
            brush = New SolidBrush(Drawing.Color.FromArgb(alpha, color))
            graphics.FillEllipse(brush, Rectangle.Round(blimpRectangle))
        Finally
            If Not brush Is Nothing Then
                brush.Dispose()
            End If
        End Try

        alpha -= AlphaReduce

        'only move blip when invisible
        If alpha <= 0 Then
            ratioOffset -= MoveBlipAmount
            If ratioOffset < -1.0F Then
                ratioOffset = 0
            End If
            alpha = 0
        End If
    End Sub

End Class
