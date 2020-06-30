Imports System.Drawing.Drawing2D

' StarShapeStyle draws a 5 point star. The star is centered around the 
' middle point of the annotation shape draw area.
Public Class StarShapeStyle
    Inherits ShapeStyle

    Protected Overloads Overrides Function GetPoints(ByVal shapePoint As System.Drawing.PointF, ByVal shapeSize As System.Drawing.Size) As System.Drawing.PointF()

        ' For a 5 point star, the angle between adjacent vertices is 
        ' 72 degrees (360 / 5 = 72). The top side vertices are 72 degrees 
        ' from the top center vertex. The top center vertex is 90 degrees 
        ' from the x axis. The top side vertices are 18 degrees from the 
        ' x axis (90 - 72 = 18).
        Dim topVerticesOffsetAngle As Double = 18 / (180 / Math.PI)

        ' The bottom vertices are centered around the y axis, so the angle 
        ' between each bottom vertex and the y axis is 36 degrees 
        ' (72 / 2 = 36).
        Dim bottomVerticesOffsetAngle As Double = 36 / (180 / Math.PI)

        ' Calculate x offsets relative to the x axis and y offsets relative 
        ' to the y axis to account for rectangles that are not square.
        Dim topVerticesXOffset As Single = CType((Math.Cos(topVerticesOffsetAngle) * (shapeSize.Width / 2)), Single)
        Dim topVerticesYOffset As Single = CType((Math.Sin(topVerticesOffsetAngle) * (shapeSize.Height / 2)), Single)

        Dim bottomVerticesXOffset As Single = CType((Math.Sin(bottomVerticesOffsetAngle) * (shapeSize.Width / 2)), Single)
        Dim bottomVerticesYOffset As Single = CType((Math.Cos(bottomVerticesOffsetAngle) * (shapeSize.Height / 2)), Single)

        Dim topCenterVertex As New PointF(shapePoint.X, shapePoint.Y - shapeSize.Height / 2)
        Dim topRightVertex As New PointF(shapePoint.X + topVerticesXOffset, shapePoint.Y - topVerticesYOffset)
        Dim bottomRightVertex As New PointF(shapePoint.X + bottomVerticesXOffset, shapePoint.Y + bottomVerticesYOffset)
        Dim bottomLeftVertex As New PointF(shapePoint.X - bottomVerticesXOffset, shapePoint.Y + bottomVerticesYOffset)
        Dim topLeftVertex As New PointF(shapePoint.X - topVerticesXOffset, shapePoint.Y - topVerticesYOffset)

        Dim path As GraphicsPath = New GraphicsPath

        Try
            path.AddLine(topCenterVertex, bottomRightVertex)
            path.AddLine(bottomRightVertex, topLeftVertex)
            path.AddLine(topLeftVertex, topRightVertex)
            path.AddLine(topRightVertex, bottomLeftVertex)
            path.AddLine(bottomLeftVertex, topCenterVertex)
            Return path.PathPoints
        Finally
            path.Dispose()
        End Try

    End Function
End Class
