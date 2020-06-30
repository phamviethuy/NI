using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace NationalInstruments.Examples.CustomAnnotations
{
    /// <summary>
    /// StarShapeStyle draws a 5 point star. The star is centered around the 
    /// middle point of the annotation shape draw area.
    /// </summary>
    public class StarShapeStyle : NationalInstruments.UI.ShapeStyle
    {               
        protected override PointF[] GetPoints(PointF shapePoint, Size shapeSize)
        {
            // For a 5 point star, the angle between adjacent vertices is 
            // 72 degrees (360 / 5 = 72). The top side vertices are 72 degrees 
            // from the top center vertex. The top center vertex is 90 degrees 
            // from the x axis. The top side vertices are 18 degrees from the 
            // x axis (90 - 72 = 18).
            double topVerticesOffsetAngle = 18 / (180 / Math.PI);

            // The bottom vertices are centered around the y axis, so the angle 
            // between each bottom vertex and the y axis is 36 degrees 
            // (72 / 2 = 36).
            double bottomVerticesOffsetAngle = 36 / (180 / Math.PI);

            // Calculate x offsets relative to the x axis and y offsets relative 
            // to the y axis to account for rectangles that are not square.
            float topVerticesXOffset = (float)Math.Cos(topVerticesOffsetAngle) * (shapeSize.Width / 2);
            float topVerticesYOffset = (float)Math.Sin(topVerticesOffsetAngle) * (shapeSize.Height / 2);

            float bottomVerticesXOffset = (float)Math.Sin(bottomVerticesOffsetAngle) * (shapeSize.Width / 2);
            float bottomVerticesYOffset = (float)Math.Cos(bottomVerticesOffsetAngle) * (shapeSize.Height / 2);

            PointF topCenterVertex = new PointF(shapePoint.X, shapePoint.Y - shapeSize.Height / 2);
            PointF topRightVertex = new PointF(shapePoint.X + topVerticesXOffset, shapePoint.Y - topVerticesYOffset);
            PointF bottomRightVertex = new PointF(shapePoint.X + bottomVerticesXOffset, shapePoint.Y + bottomVerticesYOffset);
            PointF bottomLeftVertex = new PointF(shapePoint.X - bottomVerticesXOffset, shapePoint.Y + bottomVerticesYOffset);
            PointF topLeftVertex = new PointF(shapePoint.X - topVerticesXOffset, shapePoint.Y - topVerticesYOffset);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddLine(topCenterVertex, bottomRightVertex);
                path.AddLine(bottomRightVertex, topLeftVertex);
                path.AddLine(topLeftVertex, topRightVertex);
                path.AddLine(topRightVertex, bottomLeftVertex);
                path.AddLine(bottomLeftVertex, topCenterVertex);
                return path.PathPoints;
            }
        }
    }
}
