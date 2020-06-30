using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NationalInstruments.Examples.Snippets
{
    public partial class MainForm : Form
    {
        private Dictionary<string, SnipsControl> snipsControls;
        private SnipsDocumentation documentation;
        private ControlInfo currentSnipsControlInfo;
        internal static SnipsLegend Legend;

        /// <summary>
        /// Form1 constructor
        /// </summary>
        public MainForm()
        {
            snipsControls = new Dictionary<string, SnipsControl>();
            InitializeComponent();

            // create all the snips controls            
            snipsControls["Legend"] = new SnipsLegend(uiLegend);
            snipsControls["WaveGraph"] = new SnipsWaveformGraph(waveformGraph);
            snipsControls["ScatterGraph"] = new SnipsScatterGraph(scatterGraph);
            snipsControls["ComplexGraph"] = new SnipsComplexGraph(complexGraph);
            snipsControls["DigitalGraph"] = new SnipsDigitalGraph(digitalWaveformGraph);
            snipsControls["IntensityGraph"] = new SnipsIntensityGraph(intensityGraph);
            snipsControls["RadialNumeric"] = new SnipsRadialNumericPointer(gauge);
            snipsControls["LinearNumeric"] = new SnipsLinearNumericPointer(slide);
            snipsControls["SwitchArray"] = new SnipsSwitchArray(optionsSwitches);
            MainForm.Legend = snipsControls["Legend"] as SnipsLegend;

            // load the documentation from Snippets.xml that will be used to 
            // populate the help box on the form
            documentation = new SnipsDocumentation("Snippets.xml");

            // add each control to the controls combo box
            foreach (SnipsControl control in snipsControls.Values)
                controlsComboBox.Items.Add(new ControlInfo(control, control.InternalControl.Parent is TabPage));

            // configure the options switches for the first time
            ((SnipsSwitchArray)snipsControls["SwitchArray"]).UpdateUIFromSwitchValues(snipsControls);

            // initialize the UI
            // first select tab 0 to be the first active tab
            controlsTabControl.SelectTab(0);
            // Set the first control on the first tab to be the control in the combo box
            SetSelectedComboboxControl(controlsTabControl.SelectedTab.Controls[0]);
        }

        private void OptionsSwitches_ValuesChanged(object sender, EventArgs e)
        {
            // update the UI appearance any time one of the switch controls is toggled
            ((SnipsSwitchArray)snipsControls["SwitchArray"]).UpdateUIFromSwitchValues(snipsControls);
        }

        private void SnipsControl_GotFocus(object sender, EventArgs e)
        {
            // Set the newly active control to be the control in the combo box
            SetSelectedComboboxControl((Control)sender);
        }

        /// <summary>
        /// We need to manage state when the user changes the selected item
        /// in the controls combobox.  This includes things like changing tabs and
        /// selecting the currently active control.
        /// </summary>
        private void controlsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ControlInfo controlInfo = controlsComboBox.SelectedItem as ControlInfo;

            if (controlInfo != null)
            {
                // if this is a control that wasn't previously selected
                if (controlInfo != currentSnipsControlInfo && currentSnipsControlInfo != null)
                {
                    // save off the previously selected method
                    currentSnipsControlInfo.Control.LastComboBoxItem = snipsComboBox.SelectedItem;
                    // unhook all old event handlers
                    currentSnipsControlInfo.UnhookOldEvents();
                }
                // if the control is on a tab, make sure that tab is the active tab
                if (controlInfo.ControlIsOnTab)
                    controlsTabControl.SelectTab(controlInfo.ControlTabIndex);
                controlInfo.Control.InternalControl.Focus();

                // update the methods combobox with the methods available to this control
                UpdateControlSnipsComboBox(controlInfo);
                // update the current snips control
                currentSnipsControlInfo = controlInfo;
            }            
        }

        /// <summary>
        /// Upon click of "Run Snippet" button, invoke the selected method
        /// </summary>
        private void RunSnippetButton_Click(object sender, EventArgs e)
        {
            SnipsMethod sm = (SnipsMethod)snipsComboBox.SelectedItem;

            //check to determine if event needs to be raised before method called
            if (sm.EventToRaise != null)
                HookHandlerAndRaiseEvent(sm, currentSnipsControlInfo, null);
            else //not event-based method, call directly
                currentSnipsControlInfo.InvokeMethod(sm.SnipsMethodName, null);
        }

        /// <summary>
        /// Reset the controls to a clean state.  
        /// </summary>        
        private void ResetButton_Click(object sender, EventArgs e)
        {
            foreach (ControlInfo controlInfo in controlsComboBox.Items)
                controlInfo.Control.ResetToDefaultState();
        }

        /// <summary>
        /// Upon tab change, clear comments field and reset the legend
        /// </summary>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            commentTextBox.Clear();
            controlsTabControl.SelectedTab.Controls[0].Focus();
        }

        /// <summary>
        /// Given a particular control instance, find it in the combobox and select it
        /// </summary>
        /// <param name="control">The control to select in the combobox</param>
        private void SetSelectedComboboxControl(Control control)
        {
            ControlInfo controlInfo = null;

            foreach (ControlInfo info in controlsComboBox.Items)
            {
                // find the control in the combobox that matches the 
                // control that has been passed in
                if (info.Control.InternalControl == control)
                {
                    controlInfo = info;
                    break;
                }
            }
            // select the control that was passed in as the current 
            // control in the combobox
            controlsComboBox.SelectedItem = controlInfo;
        }

        /// <summary>
        /// If the method has been marked as event based, add the event based information
        /// </summary>
        /// <param name="sm">The snips method under consideration</param>
        /// <param name="mi">The methodinfo for the method under consideration</param>
        /// <param name="currentCtrl">The control to which the method belongs</param>
        private static void AddEventBasedInfoForSnipsMethod(SnipsMethod sm, MethodInfo mi, ControlInfo currentCtrl)
        {
            // check for the EventBased attribute to indicate event based method
            Object[] attrs = mi.GetCustomAttributes(typeof(EventBasedAttribute), true);
            if (attrs.Length > 0)
            {
                // if we have a custom attribute the first (and only) attribute 
                // should be an EventBased attribute
                EventBasedAttribute attr = attrs[0] as EventBasedAttribute;
                if (attr != null)
                {
                    // From the strings given to the custom attributes, create the
                    // EventInfo and MethodInfo necessary to raise an event and
                    // hook a delegate to an event
                    sm.SetEventRaiser(attr.EventRaiserName, currentCtrl.Control);
                    sm.SetEventToRaise(attr.EventName, currentCtrl.Control);
                }
            }
        }

        /// <summary>
        /// Use Reflection to populate combo box with the current control's available snippets
        /// when the user clicks the arrow to drop down the combobox menu
        /// </summary>
        /// <param name="currentControlInfo">The current control info for the control
        ///  selected in the controls combo box</param>
        private void UpdateControlSnipsComboBox(ControlInfo currentControlInfo)
        {
            SnipsMethod newSnipsMethod;
            List<SnipsMethod> snippetMethods = new List<SnipsMethod>();

            snipsComboBox.Items.Clear();
            // get all the method names belonging to the current control through reflection         
            foreach (MethodInfo mi in currentControlInfo.Type.GetMethods())
            {
                // check if we can pull the method from the dictionary
                if (documentation.TryGetMethod(mi.Name, out newSnipsMethod))
                {
                    // if so, add the SnipsMethod to the list of methods
                    // available to this control.
                    snippetMethods.Add(newSnipsMethod);
                    // Check if this method is event based, and if so gather
                    // the required information
                    AddEventBasedInfoForSnipsMethod(newSnipsMethod, mi, currentControlInfo);
                }
            }
            // sort the method names alphabetically
            snippetMethods.Sort((sm1, sm2) => sm1.MethodSignature.CompareTo(sm2.MethodSignature));
            // Add the available method names to the combobox
            snipsComboBox.Items.AddRange(snippetMethods.ToArray<SnipsMethod>());
            // remember the last item selected by the control
            if (currentControlInfo.Control.LastComboBoxItem != null)
                snipsComboBox.SelectedItem = currentControlInfo.Control.LastComboBoxItem;
            else
                snipsComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Retrieve selected method's comments from the dictionary
        /// </summary>
        private void SnipsComboBox_TextChanged(object sender, EventArgs e)
        {
            if (snipsComboBox.SelectedIndex != -1)
            {
                SnipsMethod selectedMethod = (SnipsMethod)snipsComboBox.SelectedItem;
                // search for space characters following a new line - the format documentation
                // comments take in the generated xml file
                Regex regex = new Regex(@"\n\s+");

                commentTextBox.Clear();

                // Completely remove the first new line followed by spaces, this is the 
                // beginning of the documentation comment
                commentTextBox.Text = regex.Replace(selectedMethod.Documentation, "", 1);
                // remove the rest of the new lines followed by spaces, replacing them with a space
                commentTextBox.Text = regex.Replace(commentTextBox.Text, " ");
                //include additional method information if it exists
                if (selectedMethod.OtherMethods != null)
                {
                    commentTextBox.AppendText(Environment.NewLine + Environment.NewLine + "Additional Methods Used:");
                    commentTextBox.AppendText(Environment.NewLine);
                    commentTextBox.AppendText(regex.Replace(selectedMethod.OtherMethods, Environment.NewLine));
                }
            }
        }

        /// <summary>
        /// This method hooks a SnipsMethod up to be the Delegate that will be notified
        /// when a particular event happens.  It will also raise the event if necessary.
        /// </summary>
        /// <param name="sm">An instance of a SnipsMethod that is best demonstrated
        /// in the context of an event.  If this method is being called, the SnipsMethod.Event
        /// property should not be null</param>
        /// <param name="controlInfo">The ControlInfo for the the Measurement Studio UI control
        /// that exposes the event to be raised.</param>
        /// <param name="parameters">Any parameters that should be passed to the method that will
        /// raise the event</param>
        private static void HookHandlerAndRaiseEvent(SnipsMethod sm, ControlInfo controlInfo, object[] parameters)
        {
            // create a delegate type from the 'SnipsMethodName' property of the SnipsMethod we
            // are currently processing.  Use the 'EventHandlerType' of the SnipsMethod EventInfo
            // to create the correct type of delegate.
            Delegate createdDelegate = Delegate.CreateDelegate(sm.EventToRaise.EventHandlerType, controlInfo.Control, sm.SnipsMethodName);
            // If we have previously hooked up an event handler for this control, remove it            
            controlInfo.UnhookOldEvents();
            // Handle this "EventInfo's" event with the delegate just created
            sm.EventToRaise.AddEventHandler(controlInfo.Control.InternalControl, createdDelegate);
            // If we need a method to raise an event, such as 'Graph.Invalidate', 
            // invoke that method now.
            if (sm.EventRaiser != null)
                sm.EventRaiser.Invoke(controlInfo.Control.InternalControl, parameters);
            // Remember this event and delegate so that we can unhook it later
            controlInfo.SetOldEventData(sm.EventToRaise, createdDelegate);
        }
        
        /// <summary>
        /// This class contains information for the control that the
        /// user is currently working on.  It will be one of the SnipsControl
        /// types, such as SnipsComplexGraph.  We will store the control type
        /// and the control reference itself.
        /// </summary>
        private class ControlInfo
        {
            private Type _ctrlType;
            private SnipsControl _ctrl;
            private Delegate _oldDelegate;
            private EventInfo _oldEvent;
            private bool _isOnTab;
            private int _tabIndex;

            /// <summary>
            /// Public constructor taking the control itself and 
            /// the type of the control
            /// </summary>
            /// <param name="ctrl">The reference to the control</param>
            /// <param name="isOnTab">Is this control on a tab?</param>
            public ControlInfo(SnipsControl ctrl, bool isOnTab)
            {
                _ctrl = ctrl;
                _ctrlType = _ctrl.GetType();
                _tabIndex = -1;
                _isOnTab = false;
                if (isOnTab)
                {
                    _isOnTab = true;
                    TabPage page = (TabPage)_ctrl.InternalControl.Parent;
                    TabControl tab = (TabControl)page.Parent;
                    _tabIndex = tab.TabPages.IndexOf(page);
                }
            }

            /// <summary>
            /// Get the current control's type
            /// </summary>
            public Type Type { get { return _ctrlType; } }

            /// <summary>
            /// Get a reference to the current control
            /// </summary>
            public SnipsControl Control { get { return _ctrl; } }

            public bool ControlIsOnTab { get { return _isOnTab; } }

            public int ControlTabIndex { get { return _tabIndex; } }

            /// <summary>
            /// Invokes a method that the current SnipsControl defines 
            /// and implements
            /// </summary>
            /// <param name="methodName">The name of the method to invoke</param>
            /// <param name="parameters">An object array of the parameters to pass
            /// to the method being invoked</param>
            /// <returns>Returns the result of MethodInfo.Invoke</returns>
            public object InvokeMethod(string methodName, object[] parameters)
            {
                return _ctrlType.GetMethod(methodName).Invoke(_ctrl, parameters);
            }

            /// <summary>
            /// Call this method after hooking onto an event.  It stores the current
            /// event being handled and the delegate handling it for each control that
            /// has been created.  This allows old events and delegates to be removed
            /// before hooking up new events.
            /// </summary>
            /// <param name="oldEvent">The event currently being handled</param>
            /// <param name="oldDelegate">The Delegate that was just hooked up to
            /// the event currently being handled</param>
            public void SetOldEventData(EventInfo oldEvent, Delegate oldDelegate)
            {
                _oldDelegate = oldDelegate;
                _oldEvent = oldEvent;
            }

            /// <summary>  
            /// Unhooks the old event handler if one is attached.
            /// If an event handler is attached, it should mark itself as 'old'
            /// by calling SetOldEventData after hooking onto the event
            /// </summary>
            public void UnhookOldEvents()
            {
                if (_oldEvent != null)
                    _oldEvent.RemoveEventHandler(_ctrl.InternalControl, _oldDelegate);
                _oldEvent = null;
            }

            public override string ToString()
            {
                return _ctrl.ToString();
            }
        }
    }

    /// <summary>
    /// This class stores all the relevant information for each Measurement Studio UI
    /// method that has a code snippet in this example.
    /// </summary>
    public class SnipsMethod
    {
        private string _methodName, _documentation, _otherMethods, _methodSig;
        private MethodInfo _eventRaiser;
        private EventInfo _event;

        // capture something that is not a '.' but follows a '.', and 
        // is itself followed by the end of the string or '('
        private static Regex regex = new Regex(@"\.([^.]+)($|[(])");

        /// <summary>
        /// Parses the fully qualified, parameterized method name from the 
        /// xml documentation to return just the method name
        /// </summary>
        /// <param name="fullName">the fully qualified, parameterized method
        /// name from the xml documentation</param>
        /// <returns>the simple method name</returns>
        private static string GetMethodName(string fullName)
        {
            Match m = regex.Match(fullName);
            return m.Groups[1].Value;
        }

        /// <summary>
        /// The public constructor that generates most of the important information for 
        /// each Measurement Studio UI method that has a code snippet.  This information 
        /// is obtained from the xml document that is generated as a result of these
        /// xml comments.
        /// </summary>
        /// <param name="nameAttribute">The name attribute of the member element</param>
        /// <param name="docElement">The child 'Summary' element of the 'memeber' element</param>
        /// <param name="subElement">The child 'OtherMethods' element of the 'member' element</param>
        /// <param name="signatureElement">The child 'signature' element of the 'member' element</param>
        public SnipsMethod(XAttribute nameAttribute, XElement docElement, XElement subElement, XElement signatureElement)
        {
            _methodName = GetMethodName(nameAttribute.Value);
            _documentation = docElement.Value;
            _otherMethods = subElement == null ? null : subElement.Value;
            _methodSig = signatureElement.Value;
        }

        /// <summary>
        /// The name of the method this information is representing.  This method name
        /// does not contain any parameter or scoping information.
        /// </summary>
        public string SnipsMethodName
        {
            get { return _methodName; }
            set { _methodName = value; }
        }

        /// <summary>
        /// The summary documentation associated with this method.
        /// </summary>
        public string Documentation
        {
            get { return _documentation; }
            set { _documentation = value; }
        }

        /// <summary>
        /// Any other methods that are used in the implementation of this
        /// method's code snippet
        /// </summary>
        public string OtherMethods
        {
            get { return _otherMethods; }
            set { _otherMethods = value; }
        }

        /// <summary>
        /// returns the method signature for the actual Measurement Studio 
        /// UI method being called
        /// </summary>
        public string MethodSignature { get { return _methodSig; } }

        /// <summary>
        /// This method sets the internal MethodInfo for the method that will be used
        /// to raise an event to demonstrate a SnipsMethod if the SnipsMethod is best
        /// demonsrated in the context of an event.
        /// </summary>
        /// <param name="eventRaiserName">The name of the method that will raise the 
        /// event.  This would be something like 'Invalidate'.  It can be null if a 
        /// method is not needed to raise the event.</param>
        /// <param name="raiserControlOwner">The SnipsControl that contains the control
        /// exposing the method that will raise the event</param>
        public void SetEventRaiser(string eventRaiserName, SnipsControl raiserControlOwner)
        {
            if (eventRaiserName != null)
                _eventRaiser = raiserControlOwner.InternalControl.GetType().GetMethod(eventRaiserName, new Type[] { });
        }
        /// <summary>
        /// Returns the MethodInfo for the method responsible for raising the
        /// event that provides the context for the current SnipsMethod
        /// </summary>
        public MethodInfo EventRaiser { get { return _eventRaiser; } }

        /// <summary>
        /// This method sets the internal EventInfo for the event that will be used
        /// to provide the context for the current SnipsMethod.  For instance, it 
        /// could be the EventInfo for the Graph.PlotAreaMouseDown event.
        /// </summary>
        /// <param name="eventName">The name of the event to be associated with the
        /// current SnipsMethod</param>
        /// <param name="eventControlOwner">The SnipsControl that contains the control
        /// exposing the event that will be raised</param>
        public void SetEventToRaise(string eventName, SnipsControl eventControlOwner)
        {
            if (eventName != null)
                _event = eventControlOwner.InternalControl.GetType().GetEvent(eventName);
        }
        /// <summary>
        /// Returns an EventInfo for the event that will provide context for the
        /// current SnipsMethod.
        /// </summary>
        public EventInfo EventToRaise { get { return _event; } }

        /// <summary>
        /// We override ToString so that these SnipsMethod objects 
        /// display the method signature in the combobox dropdown.
        /// </summary>
        /// <returns>The simple method name to be displayed
        /// in the combobox</returns>
        public override string ToString()
        {
            return _methodSig;
        }
    }

    /// <summary>
    /// A small helper class for encapsulating the xml documentation.
    /// </summary>
    public class SnipsDocumentation
    {
        private Dictionary<string, SnipsMethod> documentation;

        /// <summary>
        /// public constructor for creating the method documentation
        /// </summary>
        /// <param name="xmlDocPath">Path to the xml document containing
        /// the method documentation</param>
        public SnipsDocumentation(string xmlDocPath)
        {
            documentation = GetMethodDocumentation(xmlDocPath);
        }

        /// <summary>
        /// Loads up the xml document and processes it for any members tagged
        /// with the 'ExampleMethod' element.  These members are SnipsMethods 
        /// that should be made available for execution.  It builds the 
        /// preliminary SnipsMethod objects that can be used to execute the
        /// method code snippets
        /// </summary>
        /// <returns>A dictionary whose keys are the simple method names and
        /// whose values are the SnipsMethod objects themselves.</returns>
        private static Dictionary<string, SnipsMethod> GetMethodDocumentation(string xmlDocPath)
        {
            XDocument docDoc = XDocument.Load(xmlDocPath);

            return
                (from method in docDoc.Descendants().Elements("member")
                 where method.Element("ExampleMethod") != null
                 select new SnipsMethod(method.Attribute("name"),
                                        method.Element("summary"),
                                        method.Element("OtherMethods"),
                                        method.Element("signature"))
                 ).ToDictionary(x => x.SnipsMethodName);
        }

        /// <summary>
        /// Tries to get the SnipsMethod associated with the specified method name
        /// </summary>
        /// <param name="methodName">The name of the method to retrieve a SnipsMethod for</param>
        /// <param name="method">The SnipsMethod that has been created from the documentation</param>
        /// <returns>A value indication whether or not the method was found</returns>
        public bool TryGetMethod(string methodName, out SnipsMethod method)
        {
            return documentation.TryGetValue(methodName, out method);
        }
    }



    /// <summary>
    /// This attribute tags SnipsMethods that are best demonstrated in the
    /// context of an event.  Methods such as GetAnnotationAt are often used
    /// in the context of an event such as PlotAreaMouseDown, and this class
    /// is used to demonstrate this. 
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class EventBasedAttribute : Attribute
    {
        private string _raiserName;
        private string _eventName;

        /// <summary>
        /// Public constructor for this attribute taking the event to be raised,
        /// and a method to raise that event.
        /// </summary>
        /// <param name="eventName">The name of the event to be raised</param>
        /// <param name="eventRaiserName">The name of a method that will raise the 
        /// event.  This could be something like Invalidate to raise the 
        /// AfterDrawPlotArea event.</param>
        public EventBasedAttribute(string eventName, string eventRaiserName)
        {
            _eventName = eventName;
            _raiserName = eventRaiserName;
        }

        /// <summary>
        /// Public constructor for this attribute taking the event to be raised.
        /// </summary>
        /// <param name="eventName">The name of the event to be raised</param>
        public EventBasedAttribute(string eventName) : this(eventName, null) { }

        /// <summary>
        /// This string is the name of the method that is to be used to 
        /// cause an event to occur.  The event to occur is specified by 
        /// the EventName property.  The result of the event occuring will
        /// be a SnipsMethod handling the event.
        /// </summary>
        public string EventRaiserName { get { return _raiserName; } }

        /// <summary>
        /// The name of the event that will be raised by EventRaiser, and
        /// handled by a SnipsMethod.  The SnipsMethod handling this event
        /// is best demonstrated in the context of an event.
        /// </summary>
        public string EventName { get { return _eventName; } }
    }
}
