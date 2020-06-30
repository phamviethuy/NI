using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using NationalInstruments.UI;

namespace NationalInstruments.Examples.CustomAnnotations
{
	public class FeatherTailStyle : NationalInstruments.UI.ArrowStyle
	{
		private const int numFeathers = 6;

        protected override PointF GetArrowLinePoint(PointF point, Size size)
		{
			return new PointF (point.X + size.Width, point.Y);
		}

		protected override void Draw(object context, NationalInstruments.UI.ArrowStyleDrawArgs args)
		{
			Graphics graphics = args.Graphics;
			Color color = args.Color;
			Size size = args.Size;
			PointF point = args.Point;
			float lineWidth = args.LineWidth;

			using(GraphicsPath path = new GraphicsPath())
			{
				for(int i=0; i<numFeathers; i++)
				{
					GetFeatherPolygon(path, point, size, i);
				}

				using(Pen pen = new Pen(color, lineWidth))
				{
					graphics.DrawPath(pen, path);
				}
			}  
		}
              
		private static void GetFeatherPolygon(GraphicsPath path, PointF point, Size size, int pos)
		{
			float dist = Convert.ToSingle(size.Width) / Convert.ToSingle(numFeathers);
			float offset = pos * dist;

			path.AddLine(point.X + offset, point.Y, point.X + offset + dist, point.Y);
			path.AddLine(point.X + offset + dist, point.Y, point.X + offset, point.Y - size.Height/2);
			path.AddLine(point.X + offset, point.Y - size.Height/2, point.X + offset + dist, point.Y);
			path.AddLine(point.X + offset + dist, point.Y, point.X + offset, point.Y + size.Height/2);
			path.AddLine(point.X + offset, point.Y + size.Height/2, point.X + offset + dist, point.Y);
		}
	}
}
