using System;
using System.Windows.Forms;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Snippets
{
    class SnipsNumericPointer : SnipsControlBase
    {
        private NumericPointer numericPointer;
        private Timer timer;
        private bool _animate;

        public SnipsNumericPointer(NumericPointer NumericPointer)
            : base (NumericPointer)
        {
            numericPointer = NumericPointer;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
            numericPointer.Enter += new EventHandler(numericPointer_Enter);
            timer.Start();            
        }

        #region helper methods for the SnipsNumericPointer class

        void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (_animate)
                    numericPointer.Value = numericPointer.Value > 9.9 ? 0 : numericPointer.Value + .1;
            }
            catch (ObjectDisposedException) { }
        }

        void numericPointer_Enter(object sender, EventArgs e)
        {
            MainForm.Legend.SetItems(null);
        }

        public bool Animate
        {
            get { return _animate; }
            set { _animate = value; }
        }
        #endregion
    }
}
