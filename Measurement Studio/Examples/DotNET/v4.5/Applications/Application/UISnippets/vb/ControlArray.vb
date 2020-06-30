Imports System.Diagnostics
Imports System.Reflection
Imports NationalInstruments.UI.WindowsForms


Class SnipsSwitchArray
    Inherits SnipsControl
    Private boolCtrlArray As SwitchArray

    Public Sub New(ByVal switchArray As SwitchArray)
        MyBase.New(switchArray)
        boolCtrlArray = switchArray
    End Sub

#Region "Code Snippets for NationalInstruments.UI.WindowsForms.SwitchArray"
    ''' <summary>
    ''' Gets the data values of the control array.  It is 
    ''' implemented in the BooleanArray&lt;TControl&gt; class. 
    ''' </summary>cvi
    ''' <signature>GetValues()</signature>
    ''' <ExampleMethod />
    Public Sub GetValues()
        ' The following example demonstrates getting an array of values from
        ' a control array and printing the values to debug output.
        Dim vals As Boolean()

        vals = boolCtrlArray.GetValues()
        For i As Integer = 0 To vals.Length - 1
            Debug.WriteLine(String.Format("boolean control array item {0} has a value of {1}", i, vals(i)))
        Next
    End Sub
#End Region

#Region "helper methods for the SnipsSwitchArray class"

    Public Overrides Function ToString() As String
        Return "Switch Control Array"
    End Function

    Public Sub UpdateUIFromSwitchValues(ByVal snipsControls As Dictionary(Of String, SnipsControl))
        Dim vals As Boolean() = boolCtrlArray.GetValues()

        ' set the animation state of all numeric pointer controls
        For Each numericControl As SnipsNumericPointer In snipsControls.Values.OfType(Of SnipsNumericPointer)()
            numericControl.Animate = vals(0)
        Next
        ' set the Integererpolation mode for the Integerensity graph
        Dim IntegerensityGraph As IntensityGraph = TryCast(snipsControls("IntensityGraph").InternalControl, IntensityGraph)
        For Each plot As IntensityPlot In IntegerensityGraph.Plots
            plot.PixelInterpolation = vals(1)
        Next
        ' set the tooltip state for all graph controls
        SetToolTipsEnabled(snipsControls, vals(2))
        ' set the error band state for all graph controls
        SetErrorbandsEnabled(snipsControls, vals(3))
    End Sub

    Private Shared Sub SetToolTipsEnabled(ByVal snipsControls As Dictionary(Of String, SnipsControl), ByVal enabled As Boolean)
        For Each graph As SnipsGraph In snipsControls.Values.OfType(Of SnipsGraph)()
            For Each plot As Object In GetPlotsFromGraph(graph)
                ' get the type of the plot in the collection
                Dim plotType As Type = plot.[GetType]()
                ' get the 'ToolTipsEnabled' property through reflection
                Dim tte As PropertyInfo = plotType.GetProperties().First(Function(pi) pi.Name = "ToolTipsEnabled")
                ' set the 'ToolTipsEnabled' property value through reflection
                tte.SetValue(plot, enabled, Nothing)
            Next
        Next
    End Sub

    Private Shared Function GetPlotsFromGraph(ByVal graph As SnipsGraph) As IList
        ' get the type of the graph encapulated by the snips class
        Dim graphType As Type = graph.InternalControl.[GetType]()
        ' get the 'Plots' property through reflection
        Dim plotsProperty As PropertyInfo = graphType.GetProperties().First(Function(pi) pi.Name = "Plots")
        ' return the 'Plots' object
        Return TryCast(plotsProperty.GetValue(graph.InternalControl, Nothing), IList)
    End Function

    Private Shared Sub SetErrorbandsEnabled(ByVal snipsControls As Dictionary(Of String, SnipsControl), ByVal enabled As Boolean)
        Dim errorModes As New Dictionary(Of String, Object)()

        errorModes.Add("ImaginaryErrorDataMode", If(enabled, ComplexErrorDataMode.CreatePercentErrorMode(5.0), ComplexErrorDataMode.CreateNoneMode()))
        errorModes.Add("YErrorDataMode", If(enabled, XYErrorDataMode.CreatePercentErrorMode(5.0), XYErrorDataMode.CreateNoneMode()))

        For Each graph As SnipsGraph In snipsControls.Values.OfType(Of SnipsGraph)()
            For Each plot As Object In GetPlotsFromGraph(graph)
                ' get the type of the plot in the collection
                Dim plotType As Type = plot.[GetType]()
                ' get an 'ErrorDataMode' property through reflection
                Dim edm As PropertyInfo = plotType.GetProperties().FirstOrDefault(Function(pi) errorModes.ContainsKey(pi.Name))
                ' set the 'ErrorDataMode' property value through reflection
                If edm IsNot Nothing Then
                    edm.SetValue(plot, errorModes(edm.Name), Nothing)
                End If
            Next
        Next
    End Sub
#End Region
End Class

