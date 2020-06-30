Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class CustomRadarStyle
    Inherits GaugeStyle

    Private blipList As ArrayList

    Public Sub New()
        MyBase.New()
        blipList = New ArrayList
        blipList.Add(New Blip(Me, 8, -0.5F, Color.White))
        blipList.Add(New Blip(Me, 3, -0.7F, Color.White))
        blipList.Add(New Blip(Me, 4.6, -0.1F, Color.White))
        blipList.Add(New Blip(Me, 0.5, -0.4F, Color.White))
        blipList.Add(New Blip(Me, 0.7, -0.3F, Color.White))
    End Sub

    Public Overrides Sub DrawSpindle(ByVal context As IGauge, ByVal args As RadialNumericPointerStyleDrawArgs)
        'don't draw spindle.
    End Sub


    Public Overrides Sub DrawScale(ByVal context As INumericPointer, ByVal args As NumericPointerStyleDrawArgs)
        'don't draw scale.
    End Sub

    Public Overrides Sub DrawPointer(ByVal context As INumericPointer, ByVal args As NumericPointerStyleDrawArgs, ByVal value As Double)
        Dim startPoint As PointF
        Dim endPoint As PointF

        MapValue(context, args.Bounds, value, startPoint, endPoint)

        Dim pen As Pen
        pen = Nothing
        Try
            pen = New pen(Color.White, 3)
            args.Graphics.DrawLine(pen, startPoint, endPoint)
        Finally
            If Not pen Is Nothing Then
                pen.Dispose()
            End If
        End Try
    End Sub

    Public Overrides Function GetScaleRadius(ByVal context As IRadialNumericPointer, ByVal graphics As Graphics, ByVal bounds As Rectangle) As Single
        Return GaugeStyle.SunkenWithThinNeedle3D.GetScaleRadius(context, graphics, bounds)
    End Function

    Public Overrides Function GetDialRadius(ByVal context As IRadialNumericPointer, ByVal graphics As Graphics, ByVal bounds As Rectangle) As Single
        Return GaugeStyle.SunkenWithThinNeedle3D.GetDialRadius(context, graphics, bounds)
    End Function

    Public Overrides Sub DrawDial(ByVal context As IRadialNumericPointer, ByVal args As RadialNumericPointerStyleDrawArgs)
        context.DialColor = Color.Black
        GaugeStyle.SunkenWithThinNeedle3D.DrawDial(context, args)

        Dim graphics As graphics = args.Graphics
        DrawGridLines(context, graphics, args.Bounds)

        For Each blip As blip In blipList
            blip.DrawBlip(context, graphics, args.Bounds, context.Value)
        Next blip
    End Sub

    Private Sub DrawGridLines(ByVal context As IRadialNumericPointer, ByVal graphics As Graphics, ByVal bounds As Rectangle)
        Dim spindlePoint As PointF = GetSpindlePoint(context, graphics, bounds)
        Dim dialRadius As Single = GetDialRadius(context, graphics, bounds)

        Dim pen As Pen
        pen = Nothing
        Try
            pen = New pen(Color.Green)

            For ratio As Single = 0.25F To 0.75F Step 0.25F
                Dim radius As Single = dialRadius * ratio
                Dim rect As RectangleF = New RectangleF(spindlePoint.X - radius, spindlePoint.Y - radius, radius * 2, radius * 2)
                graphics.DrawEllipse(pen, rect)
            Next

            Dim startPoint As PointF
            Dim endPoint As PointF

            For divisionValue As Single = 0.0F To 10.0F Step 1.25F
                MapValue(context, bounds, divisionValue, startPoint, endPoint)
                graphics.DrawLine(pen, startPoint, endPoint)
            Next
        Finally
            If Not pen Is Nothing Then
                pen.Dispose()
            End If
        End Try

    End Sub

    Public Overrides Function HitTest(ByVal context As IRadialNumericPointer, ByVal bounds As Rectangle, ByVal x As Integer, ByVal y As Integer) As RadialNumericPointerHitTestInfo
        'no interaction.
        Return RadialNumericPointerHitTestInfo.None
    End Function


End Class
