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
    public class CustomRadarStyle : GaugeStyle
    {
        private ArrayList blipList;
    
        public CustomRadarStyle()
        {
            blipList = new ArrayList();    
            blipList.Add(new Blip(this, 8, -.5f, Color.White));
            blipList.Add(new Blip(this, 3, -.7f, Color.White));
            blipList.Add(new Blip(this, 4.6, -.1f, Color.White));
            blipList.Add(new Blip(this, .5, -.4f, Color.White));
            blipList.Add(new Blip(this, .7, -.3f, Color.White));
        }

        public override void DrawSpindle(IGauge context, RadialNumericPointerStyleDrawArgs args)
        {
            //don't draw spindle.
        }

        public override void DrawScale(INumericPointer context, NumericPointerStyleDrawArgs args)
        {
            //don't draw scale.
        }

        public override void DrawPointer(INumericPointer context, NumericPointerStyleDrawArgs args, double value)
        {
            PointF startPoint;
            PointF endPoint;
            MapValue(context, args.Bounds, value, out startPoint, out endPoint);

            using(Pen pen = new Pen(Color.White, 3))
            {
                args.Graphics.DrawLine(pen, startPoint, endPoint);
            }
        }

        public override float GetScaleRadius(IRadialNumericPointer context, Graphics graphics, Rectangle bounds)
        {
            return GaugeStyle.SunkenWithThinNeedle3D.GetScaleRadius (context, graphics, bounds);
        }

        public override float GetDialRadius(IRadialNumericPointer context, Graphics graphics, Rectangle bounds)
        {
            return GaugeStyle.SunkenWithThinNeedle3D.GetDialRadius(context, graphics, bounds);
        }

        public override void DrawDial(IRadialNumericPointer context, RadialNumericPointerStyleDrawArgs args)
        {
            context.DialColor = Color.Black;
            GaugeStyle.SunkenWithThinNeedle3D.DrawDial(context, args);

            Graphics graphics = args.Graphics;
            DrawGridLines(context, graphics, args.Bounds);

            foreach(Blip blip in blipList)
            {
                blip.DrawBlip(context, graphics, args.Bounds, context.Value);
            }
        }

        private void DrawGridLines(IRadialNumericPointer context, Graphics graphics, Rectangle bounds)
        {
            PointF spindlePoint = GetSpindlePoint(context, graphics, bounds);            
            float dialRadius = GetDialRadius(context, graphics, bounds);
        
            using(Pen pen = new Pen(Color.Green))
            {   
                for(float ratio = .25f; ratio <= .75f; ratio += .25f)
                {
                    float radius = dialRadius * ratio;
                    RectangleF rect = new RectangleF(spindlePoint.X - radius, spindlePoint.Y - radius, radius * 2, radius * 2);
                    graphics.DrawEllipse(pen, rect);
                }

                PointF startPoint;
                PointF endPoint;

                for(float divisionValue = 0f; divisionValue <= 10f; divisionValue += 1.25f)
                {    
                    MapValue(context, bounds, divisionValue, out startPoint, out endPoint);
                    graphics.DrawLine(pen, startPoint, endPoint);
                }
            }
        }

        public override RadialNumericPointerHitTestInfo HitTest(IRadialNumericPointer context, Rectangle bounds, int x, int y)
        {
            //no interaction.
            return RadialNumericPointerHitTestInfo.None;
        }
    }
}
