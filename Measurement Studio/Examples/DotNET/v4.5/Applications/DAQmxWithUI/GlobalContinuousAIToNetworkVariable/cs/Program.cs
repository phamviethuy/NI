using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NationalInstruments.Examples.GlobalContinuousAIToNetworkVariable
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.DoEvents();
            Application.Run(new MainForm());
        }
    }
}