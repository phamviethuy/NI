using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;

namespace NationalInstruments.Examples.Snippets
{
    class SnipsSwitchArray : SnipsControl
    {
        private SwitchArray boolCtrlArray;

        public SnipsSwitchArray(SwitchArray switchArray)
            : base(switchArray)
        {
            boolCtrlArray = switchArray;
        }

        #region Code Snippets for NationalInstruments.UI.WindowsForms.SwitchArray
        /// <summary>
        /// Gets the data values of the control array.  It is 
        /// implemented in the BooleanArray&lt;TControl&gt; class. 
        /// </summary>cvi
        /// <signature>GetValues()</signature>
        /// <ExampleMethod />
        public void GetValues()
        {
            // The following example demonstrates getting an array of values from
            // a control array and printing the values to debug output.
            bool[] vals;

            vals = boolCtrlArray.GetValues();
            for (int i = 0; i < vals.Length; i++)
                Debug.WriteLine(string.Format("boolean control array item {0} has a value of {1}", i, vals[i]));
        }
        #endregion

        #region helper methods for the SnipsSwitchArray class

        public override string ToString()
        {
            return "Switch Control Array";
        }

        public void UpdateUIFromSwitchValues(Dictionary<string, SnipsControl> snipsControls)
        {
            bool[] vals = boolCtrlArray.GetValues();

            // set the animation state of all numeric pointer controls
            foreach (SnipsNumericPointer numericControl in snipsControls.Values.OfType<SnipsNumericPointer>())
                numericControl.Animate = vals[0];
            // set the interpolation mode for the intensity graph
            IntensityGraph intensityGraph = snipsControls["IntensityGraph"].InternalControl as IntensityGraph;
            foreach (IntensityPlot plot in intensityGraph.Plots)
                plot.PixelInterpolation = vals[1];
            // set the tooltip state for all graph controls
            SetToolTipsEnabled(snipsControls, vals[2]);
            // set the error band state for all graph controls
            SetErrorbandsEnabled(snipsControls, vals[3]);
        }

        private static void SetToolTipsEnabled(Dictionary<string, SnipsControl> snipsControls, bool enabled)
        {
            foreach (SnipsGraph graph in snipsControls.Values.OfType<SnipsGraph>())
            {
                foreach (object plot in GetPlotsFromGraph(graph))
                {
                    // get the type of the plot in the collection
                    Type plotType = plot.GetType();
                    // get the 'ToolTipsEnabled' property through reflection
                    PropertyInfo tte = plotType.GetProperties().First<PropertyInfo>(pi => pi.Name == "ToolTipsEnabled");
                    // set the 'ToolTipsEnabled' property value through reflection
                    tte.SetValue(plot, enabled, null);
                }
            }
        }

        private static IList GetPlotsFromGraph(SnipsGraph graph)
        {
            // get the type of the graph encapulated by the snips class
            Type graphType = graph.InternalControl.GetType();
            // get the 'Plots' property through reflection
            PropertyInfo plotsProperty = graphType.GetProperties().First<PropertyInfo>(pi => pi.Name == "Plots");
            // return the 'Plots' object
            return plotsProperty.GetValue(graph.InternalControl, null) as IList;
        }

        private static void SetErrorbandsEnabled(Dictionary<string, SnipsControl> snipsControls, bool enabled)
        {
            Dictionary<string, object> errorModes = new Dictionary<string, object>
            {{"ImaginaryErrorDataMode", enabled ? ComplexErrorDataMode.CreatePercentErrorMode(5d) : ComplexErrorDataMode.CreateNoneMode()},
             {"YErrorDataMode",         enabled ? XYErrorDataMode.CreatePercentErrorMode(5d) : XYErrorDataMode.CreateNoneMode()}};

            foreach (SnipsGraph graph in snipsControls.Values.OfType<SnipsGraph>())
            {
                foreach (object plot in GetPlotsFromGraph(graph))
                {
                    // get the type of the plot in the collection
                    Type plotType = plot.GetType();
                    // get an 'ErrorDataMode' property through reflection
                    PropertyInfo edm = plotType.GetProperties().FirstOrDefault<PropertyInfo>(pi => errorModes.ContainsKey(pi.Name));
                    // set the 'ErrorDataMode' property value through reflection
                    if (edm != null)
                        edm.SetValue(plot, errorModes[edm.Name], null);
                }
            }
        }
        #endregion
    }
}
