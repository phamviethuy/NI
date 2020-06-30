using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Snippets
{
    class SnipsRadialNumericPointer : SnipsNumericPointer
    {
        private RadialNumericPointer radialNumeric;

        public SnipsRadialNumericPointer(RadialNumericPointer RadialNumeric)
            : base(RadialNumeric)
        {
            radialNumeric = RadialNumeric;
        }

        #region code snippets for NationalInstruments.UI.WindowsForms.RadialNumericPointer

        /// <summary>
        /// Returns a RadialNumericPointerHitTestInfo that specifies where on the control
        /// the specified point is located.  It is implemented in the RadialNumericPointer 
        /// class. To run this method, you must first click the run snippet button, and 
        /// then click somewhere inside the gauge area. 
        /// </summary>
        /// <signature>HitTest(int, int)</signature>
        /// <ExampleMethod />
        [EventBased("MouseDown")]
        public void RadialNumericPointerHitTest_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates using the HitTest method to determine
            // where a user clicked on a LinearNumericPointer object.
            RadialNumericPointerHitTestInfo hitTestRegion;
            Color randomColor = Color.FromArgb(RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            hitTestRegion = radialNumeric.HitTest(e.X, e.Y);
            switch (hitTestRegion)
            {
                case RadialNumericPointerHitTestInfo.Dial:
                    radialNumeric.DialColor = randomColor;
                    Debug.WriteLine("The dial was clicked");
                    break;
                case RadialNumericPointerHitTestInfo.OuterScaleArea:
                    Debug.WriteLine("The outer scale area was clicked");
                    break;
                case RadialNumericPointerHitTestInfo.Pointer:
                    radialNumeric.PointerColor = randomColor;
                    Debug.WriteLine("The pointer was clicked");
                    break;
                case RadialNumericPointerHitTestInfo.ScaleArea:
                    radialNumeric.ScaleBaseLineColor = randomColor;
                    Debug.WriteLine("The scale was clicked");
                    break;
                case RadialNumericPointerHitTestInfo.None:
                    Debug.WriteLine("Unknown area was clicked");
                    break;
            }
        }

        #endregion

        #region helper methods for the SnipsRadialNumericPointer class

        public override string ToString()
        {
            return radialNumeric.GetType().Name;
        }

        #endregion
    }
}
