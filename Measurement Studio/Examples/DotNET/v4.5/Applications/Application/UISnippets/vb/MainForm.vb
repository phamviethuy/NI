Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms
Imports System.Reflection
Imports System.Text.RegularExpressions

Partial Public Class MainForm
    Inherits Form
    Private snipsControls As Dictionary(Of String, SnipsControl)
    Private documentation As SnipsDocumentation
    Private currentSnipsControlInfo As ControlInfo
    Friend Shared Legend As SnipsLegend

    ''' <summary>
    ''' Form1 constructor
    ''' </summary>
    Public Sub New()
        snipsControls = New Dictionary(Of String, SnipsControl)()

        ' load the documentation from Snippets.xml that will be used to 
        ' populate the help box on the form
        documentation = New SnipsDocumentation("Snippets.xml")

        InitializeComponent()

        ' create all the snips controls            
        snipsControls("Legend") = New SnipsLegend(uiLegend)
        snipsControls("WaveGraph") = New SnipsWaveformGraph(waveformGraph)
        snipsControls("ScatterGraph") = New SnipsScatterGraph(scatterGraph)
        snipsControls("ComplexGraph") = New SnipsComplexGraph(complexGraph)
        snipsControls("DigitalGraph") = New SnipsDigitalGraph(digitalWaveformGraph)
        snipsControls("IntensityGraph") = New SnipsIntensityGraph(intensityGraph)
        snipsControls("RadialNumeric") = New SnipsRadialNumericPointer(gauge)
        snipsControls("LinearNumeric") = New SnipsLinearNumericPointer(slide)
        snipsControls("SwitchArray") = New SnipsSwitchArray(optionsSwitches)
        MainForm.Legend = TryCast(snipsControls("Legend"), SnipsLegend)

        ' add a handler for the ValuesChanged event on the options switches array of controls
        AddHandler optionsSwitches.ValuesChanged, AddressOf OptionsSwitches_ValuesChanged

        ' add each control to the controls combo box
        For Each control As SnipsControl In snipsControls.Values
            controlsComboBox.Items.Add(New ControlInfo(control, TypeOf control.InternalControl.Parent Is TabPage))
        Next

        ' configure the options switches for the first time
        DirectCast(snipsControls("SwitchArray"), SnipsSwitchArray).UpdateUIFromSwitchValues(snipsControls)

        ' initialize the UI
        ' first select tab 0 to be the first active tab
        controlsTabControl.SelectTab(0)
        ' Set the first control on the first tab to be the control in the combo box
        SetSelectedComboboxControl(controlsTabControl.SelectedTab.Controls(0))
    End Sub

    Private Sub OptionsSwitches_ValuesChanged(ByVal sender As Object, ByVal e As EventArgs)
        ' update the UI appearance any time one of the switch controls is toggled
        DirectCast(snipsControls("SwitchArray"), SnipsSwitchArray).UpdateUIFromSwitchValues(snipsControls)
    End Sub

    Private Sub SnipsControl_GotFocus(ByVal sender As Object, ByVal e As EventArgs) Handles waveformGraph.Enter, slide.Enter, scatterGraph.Enter, optionsSwitches.Enter, intensityGraph.Enter, gauge.Enter, digitalWaveformGraph.Enter, complexGraph.Enter
        ' Set the newly active control to be the control in the combo box
        SetSelectedComboboxControl(DirectCast(sender, Control))
    End Sub

    ''' <summary>
    ''' We need to manage state when the user changes the selected item
    ''' in the controls combobox.  This includes things like changing tabs and
    ''' selecting the currently active control.
    ''' </summary>
    Private Sub controlsComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles controlsComboBox.SelectedIndexChanged
        Dim controlInfo As ControlInfo = TryCast(controlsComboBox.SelectedItem, ControlInfo)

        If controlInfo IsNot Nothing Then
            ' if this is a control that wasn't previously selected
            If controlInfo IsNot currentSnipsControlInfo AndAlso currentSnipsControlInfo IsNot Nothing Then
                ' save off the previously selected method
                currentSnipsControlInfo.Control.LastComboBoxItem = snipsComboBox.SelectedItem
                ' unhook all old event handlers
                currentSnipsControlInfo.UnhookOldEvents()
            End If
            ' if the control is on a tab, make sure that tab is the active tab
            If controlInfo.ControlIsOnTab Then
                controlsTabControl.SelectTab(controlInfo.ControlTabIndex)
            End If
            controlInfo.Control.InternalControl.Focus()
        End If
        ' update the methods combobox with the methods available to this control
        UpdateControlSnipsComboBox(controlInfo)
        ' update the current snips control
        currentSnipsControlInfo = controlInfo
    End Sub

    ''' <summary>
    ''' Upon click of "Run Snippet" button, invoke the selected method
    ''' </summary>
    Private Sub RunSnippetButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles runSnippetButton.Click
        Dim sm As SnipsMethod = DirectCast(snipsComboBox.SelectedItem, SnipsMethod)

        'check to determine if event needs to be raised before method called
        If sm.EventToRaise IsNot Nothing Then
            HookHandlerAndRaiseEvent(sm, currentSnipsControlInfo, Nothing)
        Else
            'not event-based method, call directly
            currentSnipsControlInfo.InvokeMethod(sm.SnipsMethodName, Nothing)
        End If
    End Sub

    ''' <summary>
    ''' Reset the controls to a clean state.  
    ''' </summary>        
    Private Sub ResetButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles resetButton.Click
        For Each controlInfo As ControlInfo In controlsComboBox.Items
            controlInfo.Control.ResetToDefaultState()
        Next
    End Sub

    ''' <summary>
    ''' Upon tab change, clear comments field and reset the legend
    ''' </summary>
    Private Sub tabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles controlsTabControl.SelectedIndexChanged
        commentTextBox.Clear()
        controlsTabControl.SelectedTab.Controls(0).Focus()
    End Sub

    ''' <summary>
    ''' Given a particular control instance, find it in the combobox and select it
    ''' </summary>
    ''' <param name="control">The control to select in the combobox</param>
    Private Sub SetSelectedComboboxControl(ByVal control As Control)
        Dim controlInfo As ControlInfo = Nothing

        For Each info As ControlInfo In controlsComboBox.Items
            ' find the control in the combobox that matches the 
            ' control that has been passed in
            If info.Control.InternalControl Is control Then
                controlInfo = info
                Exit For
            End If
        Next
        ' select the control that was passed in as the current 
        ' control in the combobox
        controlsComboBox.SelectedItem = controlInfo
    End Sub

    ''' <summary>
    ''' If the method has been marked as event based, add the event based information
    ''' </summary>
    ''' <param name="sm">The snips method under consideration</param>
    ''' <param name="mi">The methodinfo for the method under consideration</param>
    ''' <param name="currentCtrl">The control to which the method belongs</param>
    Private Shared Sub AddEventBasedInfoForSnipsMethod(ByVal sm As SnipsMethod, ByVal mi As MethodInfo, ByVal currentCtrl As ControlInfo)
        ' check for the EventBased attribute to indicate event based method
        Dim attrs As [Object]() = mi.GetCustomAttributes(GetType(EventBasedAttribute), True)
        If attrs.Length > 0 Then
            ' if we have a custom attribute the first (and only) attribute 
            ' should be an EventBased attribute
            Dim attr As EventBasedAttribute = TryCast(attrs(0), EventBasedAttribute)
            If attr IsNot Nothing Then
                ' From the strings given to the custom attributes, create the
                ' EventInfo and MethodInfo necessary to raise an event and
                ' hook a delegate to an event
                sm.SetEventRaiser(attr.EventRaiserName, currentCtrl.Control)
                sm.SetEventToRaise(attr.EventName, currentCtrl.Control)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Use Reflection to populate combo box with the current control's available snippets
    ''' when the user clicks the arrow to drop down the combobox menu
    ''' </summary>
    ''' <param name="currentControlInfo">The current control info for the control
    '''  selected in the controls combo box</param>
    Private Sub UpdateControlSnipsComboBox(ByVal currentControlInfo As ControlInfo)
        Dim newSnipsMethod As SnipsMethod = Nothing
        Dim snippetMethods As New List(Of SnipsMethod)()

        snipsComboBox.Items.Clear()
        ' get all the method names belonging to the current control through reflection         
        For Each mi As MethodInfo In currentControlInfo.Type.GetMethods()
            ' check if we can pull the method from the dictionary
            If documentation.TryGetMethod(mi.Name, newSnipsMethod) Then
                ' if so, add the SnipsMethod to the list of methods
                ' available to this control.
                snippetMethods.Add(newSnipsMethod)
                ' Check if this method is event based, and if so gather
                ' the required information
                AddEventBasedInfoForSnipsMethod(newSnipsMethod, mi, currentControlInfo)
            End If
        Next
        ' sort the method names alphabetically
        snippetMethods.Sort(Function(sm1, sm2) sm1.MethodSignature.CompareTo(sm2.MethodSignature))
        ' Add the available method names to the combobox
        snipsComboBox.Items.AddRange(snippetMethods.ToArray())
        ' remember the last item selected by the control
        If currentControlInfo.Control.LastComboBoxItem IsNot Nothing Then
            snipsComboBox.SelectedItem = currentControlInfo.Control.LastComboBoxItem
        Else
            snipsComboBox.SelectedIndex = 0
        End If
    End Sub

    ''' <summary>
    ''' Retrieve selected method's comments from the dictionary
    ''' </summary>
    Private Sub SnipsComboBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles snipsComboBox.SelectionChangeCommitted
        If snipsComboBox.SelectedIndex <> -1 Then
            Dim selectedMethod As SnipsMethod = DirectCast(snipsComboBox.SelectedItem, SnipsMethod)
            ' search for space characters following a new line - the format documentation
            ' comments take in the generated xml file
            Dim regex As New Regex("\n\s+")

            commentTextBox.Clear()

            ' Completely remove the first new line followed by spaces, this is the 
            ' beginning of the documentation comment
            commentTextBox.Text = regex.Replace(selectedMethod.Documentation, "", 1)
            ' remove the rest of the new lines followed by spaces, replacing them with a space
            commentTextBox.Text = regex.Replace(commentTextBox.Text, " ")
            'include additional method information if it exists
            If selectedMethod.OtherMethods IsNot Nothing Then
                commentTextBox.AppendText(Environment.NewLine & Environment.NewLine & "Additional Methods Used:")
                commentTextBox.AppendText(Environment.NewLine)
                commentTextBox.AppendText(regex.Replace(selectedMethod.OtherMethods, Environment.NewLine))
            End If
        End If
    End Sub

    ''' <summary>
    ''' This method hooks a SnipsMethod up to be the Delegate that will be notified
    ''' when a particular event happens.  It will also raise the event if necessary.
    ''' </summary>
    ''' <param name="sm">An instance of a SnipsMethod that is best demonstrated
    ''' in the context of an event.  If this method is being called, the SnipsMethod.Event
    ''' property should not be null</param>
    ''' <param name="controlInfo">The ControlInfo for the the Measurement Studio UI control
    ''' that exposes the event to be raised.</param>
    ''' <param name="parameters">Any parameters that should be passed to the method that will
    ''' raise the event</param>
    Private Shared Sub HookHandlerAndRaiseEvent(ByVal sm As SnipsMethod, ByVal controlInfo As ControlInfo, ByVal parameters As Object())
        ' create a delegate type from the 'SnipsMethodName' property of the SnipsMethod we
        ' are currently processing.  Use the 'EventHandlerType' of the SnipsMethod EventInfo
        ' to create the correct type of delegate.
        Dim createdDelegate As [Delegate] = [Delegate].CreateDelegate(sm.EventToRaise.EventHandlerType, controlInfo.Control, sm.SnipsMethodName)
        ' If we have previously hooked up an event handler for this control, remove it            
        controlInfo.UnhookOldEvents()
        ' Handle this "EventInfo's" event with the delegate just created
        sm.EventToRaise.AddEventHandler(controlInfo.Control.InternalControl, createdDelegate)
        ' If we need a method to raise an event, such as 'Graph.Invalidate', 
        ' invoke that method now.
        If sm.EventRaiser IsNot Nothing Then
            sm.EventRaiser.Invoke(controlInfo.Control.InternalControl, parameters)
        End If
        ' Remember this event and delegate so that we can unhook it later
        controlInfo.SetOldEventData(sm.EventToRaise, createdDelegate)
    End Sub

    ''' <summary>
    ''' This class contains information for the control that the
    ''' user is currently working on.  It will be one of the SnipsControl
    ''' types, such as SnipsComplexGraph.  We will store the control type
    ''' and the control reference itself.
    ''' </summary>
    Private Class ControlInfo
        Private _ctrlType As Type
        Private _ctrl As SnipsControl
        Private _oldDelegate As [Delegate]
        Private _oldEvent As EventInfo
        Private _isOnTab As Boolean
        Private _tabIndex As Integer

        ''' <summary>
        ''' Public constructor taking the control itself and 
        ''' the type of the control
        ''' </summary>
        ''' <param name="ctrl">The reference to the control</param>
        ''' <param name="isOnTab">Is this control on a tab?</param>
        Public Sub New(ByVal ctrl As SnipsControl, ByVal isOnTab As Boolean)
            _ctrl = ctrl
            _ctrlType = _ctrl.[GetType]()
            _tabIndex = -1
            _isOnTab = False
            If isOnTab Then
                _isOnTab = True
                Dim page As TabPage = DirectCast(_ctrl.InternalControl.Parent, TabPage)
                Dim tab As TabControl = DirectCast(page.Parent, TabControl)
                _tabIndex = tab.TabPages.IndexOf(page)
            End If
        End Sub

        ''' <summary>
        ''' Get the current control's type
        ''' </summary>
        Public ReadOnly Property Type() As Type
            Get
                Return _ctrlType
            End Get
        End Property

        ''' <summary>
        ''' Get a reference to the current control
        ''' </summary>
        Public ReadOnly Property Control() As SnipsControl
            Get
                Return _ctrl
            End Get
        End Property

        Public ReadOnly Property ControlIsOnTab() As Boolean
            Get
                Return _isOnTab
            End Get
        End Property

        Public ReadOnly Property ControlTabIndex() As Integer
            Get
                Return _tabIndex
            End Get
        End Property

        ''' <summary>
        ''' Invokes a method that the current SnipsControl defines 
        ''' and implements
        ''' </summary>
        ''' <param name="methodName">The name of the method to invoke</param>
        ''' <param name="parameters">An object array of the parameters to pass
        ''' to the method being invoked</param>
        ''' <returns>Returns the result of MethodInfo.Invoke</returns>
        Public Function InvokeMethod(ByVal methodName As String, ByVal parameters As Object()) As Object
            Return _ctrlType.GetMethod(methodName).Invoke(_ctrl, parameters)
        End Function

        ''' <summary>
        ''' Call this method after hooking onto an event.  It stores the current
        ''' event being handled and the delegate handling it for each control that
        ''' has been created.  This allows old events and delegates to be removed
        ''' before hooking up new events.
        ''' </summary>
        ''' <param name="oldEvent">The event currently being handled</param>
        ''' <param name="oldDelegate">The Delegate that was just hooked up to
        ''' the event currently being handled</param>
        Public Sub SetOldEventData(ByVal oldEvent As EventInfo, ByVal oldDelegate As [Delegate])
            _oldDelegate = oldDelegate
            _oldEvent = oldEvent
        End Sub

        ''' <summary>  
        ''' Unhooks the old event handler if one is attached.
        ''' If an event handler is attached, it should mark itself as 'old'
        ''' by calling SetOldEventData after hooking onto the event
        ''' </summary>
        Public Sub UnhookOldEvents()
            If _oldEvent IsNot Nothing Then
                _oldEvent.RemoveEventHandler(_ctrl.InternalControl, _oldDelegate)
            End If
            _oldEvent = Nothing
        End Sub

        Public Overrides Function ToString() As String
            Return _ctrl.ToString()
        End Function
    End Class
End Class

''' <summary>
''' This class stores all the relevant information for each Measurement Studio UI
''' method that has a code snippet in this example.
''' </summary>
Public Class SnipsMethod
    Private _methodName As String, _documentation As String, _otherMethods As String, _methodSig As String
    Private _eventRaiser As MethodInfo
    Private _event As EventInfo

    ' capture something that is not a '.' but follows a '.', and 
    ' is itself followed by the end of the string or '('
    Private Shared regex As New Regex("\.([^.]+)($|[(])")

    ''' <summary>
    ''' Parses the fully qualified, parameterized method name from the 
    ''' xml documentation to return just the method name
    ''' </summary>
    ''' <param name="fullName">the fully qualified, parameterized method
    ''' name from the xml documentation</param>
    ''' <returns>the simple method name</returns>
    Private Shared Function GetMethodName(ByVal fullName As String) As String
        Dim m As Match = regex.Match(fullName)
        Return m.Groups(1).Value
    End Function

    ''' <summary>
    ''' The public constructor that generates most of the important information for 
    ''' each Measurement Studio UI method that has a code snippet.  This information 
    ''' is obtained from the xml document that is generated as a result of these
    ''' xml comments.
    ''' </summary>
    ''' <param name="nameAttribute">The name attribute of the member element</param>
    ''' <param name="docElement">The child 'Summary' element of the 'memeber' element</param>
    ''' <param name="subElement">The child 'OtherMethods' element of the 'member' element</param>
    ''' <param name="signatureElement">The child 'signature' element of the 'member' element</param>
    Public Sub New(ByVal nameAttribute As XAttribute, ByVal docElement As XElement, ByVal subElement As XElement, ByVal signatureElement As XElement)
        _methodName = GetMethodName(nameAttribute.Value)
        _documentation = docElement.Value
        _otherMethods = If(subElement Is Nothing, Nothing, subElement.Value)
        _methodSig = signatureElement.Value
    End Sub

    ''' <summary>
    ''' The name of the method this information is representing.  This method name
    ''' does not contain any parameter or scoping information.
    ''' </summary>
    Public Property SnipsMethodName() As String
        Get
            Return _methodName
        End Get
        Set(ByVal value As String)
            _methodName = value
        End Set
    End Property

    ''' <summary>
    ''' The summary documentation associated with this method.
    ''' </summary>
    Public Property Documentation() As String
        Get
            Return _documentation
        End Get
        Set(ByVal value As String)
            _documentation = value
        End Set
    End Property

    ''' <summary>
    ''' Any other methods that are used in the implementation of this
    ''' method's code snippet
    ''' </summary>
    Public Property OtherMethods() As String
        Get
            Return _otherMethods
        End Get
        Set(ByVal value As String)
            _otherMethods = value
        End Set
    End Property

    ''' <summary>
    ''' returns the method signature for the actual Measurement Studio 
    ''' UI method being called
    ''' </summary>
    Public ReadOnly Property MethodSignature() As String
        Get
            Return _methodSig
        End Get
    End Property

    ''' <summary>
    ''' This method sets the internal MethodInfo for the method that will be used
    ''' to raise an event to demonstrate a SnipsMethod if the SnipsMethod is best
    ''' demonsrated in the context of an event.
    ''' </summary>
    ''' <param name="eventRaiserName">The name of the method that will raise the 
    ''' event.  This would be something like 'Invalidate'.  It can be null if a 
    ''' method is not needed to raise the event.</param>
    ''' <param name="raiserControlOwner">The SnipsControl that contains the control
    ''' exposing the method that will raise the event</param>
    Public Sub SetEventRaiser(ByVal eventRaiserName As String, ByVal raiserControlOwner As SnipsControl)
        If eventRaiserName IsNot Nothing Then
            _eventRaiser = raiserControlOwner.InternalControl.[GetType]().GetMethod(eventRaiserName, New Type() {})
        End If
    End Sub
    ''' <summary>
    ''' Returns the MethodInfo for the method responsible for raising the
    ''' event that provides the context for the current SnipsMethod
    ''' </summary>
    Public ReadOnly Property EventRaiser() As MethodInfo
        Get
            Return _eventRaiser
        End Get
    End Property

    ''' <summary>
    ''' This method sets the internal EventInfo for the event that will be used
    ''' to provide the context for the current SnipsMethod.  For instance, it 
    ''' could be the EventInfo for the Graph.PlotAreaMouseDown event.
    ''' </summary>
    ''' <param name="eventName">The name of the event to be associated with the
    ''' current SnipsMethod</param>
    ''' <param name="eventControlOwner">The SnipsControl that contains the control
    ''' exposing the event that will be raised</param>
    Public Sub SetEventToRaise(ByVal eventName As String, ByVal eventControlOwner As SnipsControl)
        If eventName IsNot Nothing Then
            _event = eventControlOwner.InternalControl.[GetType]().GetEvent(eventName)
        End If
    End Sub
    ''' <summary>
    ''' Returns an EventInfo for the event that will provide context for the
    ''' current SnipsMethod.
    ''' </summary>
    Public ReadOnly Property EventToRaise() As EventInfo
        Get
            Return _event
        End Get
    End Property

    ''' <summary>
    ''' We override ToString so that these SnipsMethod objects 
    ''' display the method signature in the combobox dropdown.
    ''' </summary>
    ''' <returns>The simple method name to be displayed
    ''' in the combobox</returns>
    Public Overrides Function ToString() As String
        Return _methodSig
    End Function
End Class

''' <summary>
''' A small helper class for encapsulating the xml documentation.
''' </summary>
Public Class SnipsDocumentation
    Private documentation As Dictionary(Of String, SnipsMethod)

    ''' <summary>
    ''' public constructor for creating the method documentation
    ''' </summary>
    ''' <param name="xmlDocPath">Path to the xml document containing
    ''' the method documentation</param>
    Public Sub New(ByVal xmlDocPath As String)
        documentation = GetMethodDocumentation(xmlDocPath)
    End Sub

    ''' <summary>
    ''' Loads up the xml document and processes it for any members tagged
    ''' with the 'ExampleMethod' element.  These members are SnipsMethods 
    ''' that should be made available for execution.  It builds the 
    ''' preliminary SnipsMethod objects that can be used to execute the
    ''' method code snippets
    ''' </summary>
    ''' <returns>A dictionary whose keys are the simple method names and
    ''' whose values are the SnipsMethod objects themselves.</returns>
    Private Shared Function GetMethodDocumentation(ByVal xmlDocPath As String) As Dictionary(Of String, SnipsMethod)
        Dim docDoc As XDocument = XDocument.Load(xmlDocPath)

        Return _
            (From method In docDoc.Descendants().Elements("member") _
             Where IsNothing(method.Element("ExampleMethod")) <> True _
             Select New SnipsMethod(method.Attribute("name"), _
                                    method.Element("summary"), _
                                    method.Element("OtherMethods"), _
                                    method.Element("signature")) _
            ).ToDictionary(Function(sm As SnipsMethod) sm.SnipsMethodName)
    End Function

    ''' <summary>
    ''' Tries to get the SnipsMethod associated with the specified method name
    ''' </summary>
    ''' <param name="methodName">The name of the method to retrieve a SnipsMethod for</param>
    ''' <param name="method">The SnipsMethod that has been created from the documentation</param>
    ''' <returns>A value indication whether or not the method was found</returns>
    Public Function TryGetMethod(ByVal methodName As String, ByRef method As SnipsMethod) As Boolean
        Return documentation.TryGetValue(methodName, method)
    End Function
End Class



''' <summary>
''' This attribute tags SnipsMethods that are best demonstrated in the
''' context of an event.  Methods such as GetAnnotationAt are often used
''' in the context of an event such as PlotAreaMouseDown, and this class
''' is used to demonstrate this. 
''' </summary>
<AttributeUsage(AttributeTargets.Method)> _
Public NotInheritable Class EventBasedAttribute
    Inherits Attribute
    Private raiser As String
    Private eventToRaise As String

    ''' <summary>
    ''' Public constructor for this attribute taking the event to be raised,
    ''' and a method to raise that event.
    ''' </summary>
    ''' <param name="eventName">The name of the event to be raised</param>
    ''' <param name="eventRaiserName">The name of a method that will raise the 
    ''' event.  This could be something like Invalidate to raise the 
    ''' AfterDrawPlotArea event.</param>
    Public Sub New(ByVal eventName As String, ByVal eventRaiserName As String)
        Me.eventToRaise = eventName
        Me.raiser = eventRaiserName
    End Sub

    ''' <summary>
    ''' Public constructor for this attribute taking the event to be raised.
    ''' </summary>
    ''' <param name="eventName">The name of the event to be raised</param>
    Public Sub New(ByVal eventName As String)
        Me.New(eventName, Nothing)
    End Sub

    ''' <summary>
    ''' This string is the name of the method that is to be used to 
    ''' cause an event to occur.  The event to occur is specified by 
    ''' the EventName property.  The result of the event occuring will
    ''' be a SnipsMethod handling the event.
    ''' </summary>
    Public ReadOnly Property EventRaiserName() As String
        Get
            Return raiser
        End Get
    End Property

    ''' <summary>
    ''' The name of the event that will be raised by EventRaiser, and
    ''' handled by a SnipsMethod.  The SnipsMethod handling this event
    ''' is best demonstrated in the context of an event.
    ''' </summary>
    Public ReadOnly Property EventName() As String
        Get
            Return eventToRaise
        End Get
    End Property
End Class