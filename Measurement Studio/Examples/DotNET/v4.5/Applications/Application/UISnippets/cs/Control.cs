using System;
using System.Windows.Forms;

namespace NationalInstruments.Examples.Snippets
{
    /// <summary>
    /// This is the base Snips class from which all other derive.
    /// </summary>
    public class SnipsControl
    {
        private Control control;
        private object lastComboBoxItem;
        private Random randNumGenerator;

        /// <summary>
        /// A random number generator belonging to all
        /// snips control types.
        /// </summary>
        protected Random RandNumberGenerator { get { return randNumGenerator; } }

        /// <summary>
        /// Public contstructor for Snips control
        /// </summary>
        /// <param name="control">Base control instance</param>
        public SnipsControl(Control control)
        {
            this.control = control;
            randNumGenerator = new Random(DateTime.Now.Millisecond);
        }

        /// <summary>
        /// This property retuns a reference to the control that
        /// is being encapsulated by the SnipsControl instance
        /// </summary>
        public Control InternalControl { get { return control; } }

        /// <summary>
        /// Reset the control to its default state
        /// </summary>
        public virtual void ResetToDefaultState() { }

        /// <summary>
        /// The last combobox item to be selected
        /// </summary>
        public object LastComboBoxItem
        {
            get { return lastComboBoxItem; }
            set { lastComboBoxItem = value; }
        }
    }
}
