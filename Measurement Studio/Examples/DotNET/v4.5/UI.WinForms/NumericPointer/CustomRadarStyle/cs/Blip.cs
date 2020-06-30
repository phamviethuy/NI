using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.CustomRadarStyle
{
    public class Blip
    {
        private const float MoveBlipAmount = .001f;
        private const float BlipRadius = 2;
        private const float ErrorMargin = .1f;
        private const int AlphaReduce = 10;

        private int alpha;
        private Color color;
        private float ratioOffset;
        private double blipValue;
        private NumericPointerStyle style;

        public Blip(NumericPointerStyle numericStyle, double value, float offset, Color blipColor)
        {
            Debug.Assert(value >= 0 && value <= 10, "value must be between 0 and 10");
            Debug.Assert(offset <= 0 && offset >= -1, "offset must be between 0 and -1");
        
            color = blipColor;
            blipValue = value;
            ratioOffset = offset;
            style = numericStyle;
        }

        public void DrawBlip(IRadialNumericPointer context, Graphics graphics, Rectangle bounds, double controlValue)
        {
            PointF startPoint;
            PointF endPoint;
        
            style.MapValue(context, bounds, blipValue, out startPoint, out endPoint);
            DrawUtility.OffsetLineByRatio(startPoint, endPoint, 0, ratioOffset, out startPoint, out endPoint);
            RectangleF blimpRectangle = new RectangleF(endPoint.X - BlipRadius, endPoint.Y - BlipRadius, BlipRadius* 2, BlipRadius* 2);

            if(controlValue >= blipValue && controlValue < blipValue + ErrorMargin)
                alpha = 255;

            using(Brush brush = new SolidBrush(Color.FromArgb(alpha, color)))
                graphics.FillEllipse(brush, Rectangle.Round(blimpRectangle));
    
        
            alpha -= AlphaReduce;

            //only move blip when invisible
            if(alpha <= 0)
            {
                ratioOffset -= MoveBlipAmount;
                if(ratioOffset < -1f)
                    ratioOffset = 0;
                alpha = 0;
            }
        }
    }
}
