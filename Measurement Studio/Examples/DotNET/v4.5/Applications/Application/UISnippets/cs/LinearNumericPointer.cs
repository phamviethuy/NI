using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Snippets
{
    class SnipsLinearNumericPointer : SnipsNumericPointer
    {
        private LinearNumericPointer linearNumeric;

        public SnipsLinearNumericPointer(LinearNumericPointer LinearNumeric)
            : base(LinearNumeric)
        {
            linearNumeric = LinearNumeric;
        }

        #region code snippets for NationalInstruments.UI.WindowsForms.LinearNumericPointer

        /// <summary>
        /// Returns a LinearNumericPointerHitTestInfo that specifies where on the control 
        /// the specified point is located.   It is implemented in the LinearNumericPointer 
        /// class. To run this method, you must first click the run snippet button, and 
        /// then click somewhere inside the slide area. 
        /// </summary>
        /// <signature>HitTest(int, int)</signature>
        /// <ExampleMethod />
        [EventBased("MouseDown")]
        public void LinearNumericPointerHitTest_int_int(object sender, MouseEventArgs e)
        {
            // The following example demonstrates using the HitTest method to determine
            // where a user clicked on a LinearNumericPointer object.
            LinearNumericPointerHitTestInfo hitTestRegion;
            Color randomColor = Color.FromArgb(RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255),
                                                RandNumberGenerator.Next(255));

            hitTestRegion = linearNumeric.HitTest(e.X, e.Y);
            
            switch (hitTestRegion)
            {
                case LinearNumericPointerHitTestInfo.Fill:
                    linearNumeric.FillColor = randomColor;
                    Debug.WriteLine("Filled area clicked");
                    break;
                case LinearNumericPointerHitTestInfo.FillBackground:
                    linearNumeric.FillBackColor = randomColor;
                    Debug.WriteLine("Fill background area clicked");
                    break;
                case LinearNumericPointerHitTestInfo.Pointer:
                    linearNumeric.PointerColor = randomColor;
                    Debug.WriteLine("Pointer clicked");
                    break;
                case LinearNumericPointerHitTestInfo.ScaleArea:
                    linearNumeric.ScaleBaseLineColor = randomColor;
                    Debug.WriteLine("The scale area was clicked");
                    break;
                case LinearNumericPointerHitTestInfo.None:
                    Debug.WriteLine("Unknown area clicked");
                    break;
            }
        }

        #endregion

        #region helper methods for the SnipsLinearNumericPointer class

        public override string ToString()
        {
            return linearNumeric.GetType().Name;
        }
        #endregion
    }
}
