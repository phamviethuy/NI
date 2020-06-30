Imports System.Drawing.Drawing2D

Public Class FeatherTailStyle
    Inherits ArrowStyle
    Private Const numFeathers As Integer = 6

    Protected Overloads Overrides Sub Draw(ByVal context As Object, ByVal args As UI.ArrowStyleDrawArgs)
        Dim graphics As graphics = args.Graphics
        Dim color As color = args.Color
        Dim size As size = args.Size
        Dim point As PointF = args.Point
        Dim lineWidth As Single = args.LineWidth

        Dim path As GraphicsPath = New GraphicsPath
        Try
            For i As Integer = 0 To numFeathers
                GetFeatherPolygon(path, point, size, i)
            Next i

            Dim pen As pen = New pen(color, lineWidth)
            graphics.DrawPath(pen, path)
            pen.Dispose()

        Finally
            path.Dispose()
        End Try
				

    End Sub

    Protected Overrides Function GetArrowLinePoint(ByVal point As System.Drawing.PointF, ByVal size As System.Drawing.Size) As System.Drawing.PointF
        Return New PointF(point.X + size.Width, point.Y)
    End Function

    Private Shared Sub GetFeatherPolygon(ByRef path As GraphicsPath, ByVal point As PointF, ByVal size As Size, ByVal pos As Integer)

        Dim dist As Single = Convert.ToSingle(size.Width) / Convert.ToSingle(numFeathers)
        Dim offset As Single = pos * dist

        path.AddLine(point.X + offset, point.Y, point.X + offset + dist, point.Y)
        path.AddLine(point.X + offset + dist, point.Y, point.X + offset, Convert.ToSingle(point.Y - size.Height / 2.0))
        path.AddLine(point.X + offset, Convert.ToSingle(point.Y - size.Height / 2), point.X + offset + dist, point.Y)
        path.AddLine(point.X + offset + dist, point.Y, point.X + offset, Convert.ToSingle(point.Y + size.Height / 2))
        path.AddLine(point.X + offset, Convert.ToSingle(point.Y + size.Height / 2), point.X + offset + dist, point.Y)
    End Sub
End Class
