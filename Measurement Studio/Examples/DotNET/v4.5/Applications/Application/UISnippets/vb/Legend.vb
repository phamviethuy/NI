Imports NationalInstruments.UI.WindowsForms

Class SnipsLegend
    Inherits SnipsControlBase
    Private legend As Legend

    Public Sub New(ByVal Legend__1 As Legend)
        MyBase.New(Legend__1)
        legend = Legend__1
    End Sub

#Region "code snippets for NationalInstruments.UI.WindowsForms.Legend"

    ''' <summary>
    ''' Returns a LegendHitTestInfo that specifies where on the control the given
    ''' point is located.  It is implemented in the Legend class. To run this method,
    ''' you must first click the run snippet button, and then click somewhere inside 
    ''' the legend area. 
    ''' </summary>
    ''' <signature>HitTest(Integer, Integer)</signature>
    ''' <OtherMethods>
    ''' Legend.GetItemAt(Integer, Integer)
    ''' </OtherMethods>
    ''' <ExampleMethod />
    <EventBased("MouseDown")> _
    Public Sub Legend_HitTest_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates using the HitTest method to determine
        ' where a user clicked on a Legend object.
        Dim hitTestRegion As LegendHitTestInfo
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        hitTestRegion = legend.HitTest(e.X, e.Y)
        Select Case hitTestRegion
            Case LegendHitTestInfo.HorizontalScrollBar
                Debug.WriteLine("horizontal scrollbar selected")
                Exit Select
            Case LegendHitTestInfo.Item
                Dim item As LegendItem = legend.GetItemAt(e.X, e.Y)
                If TypeOf item.Source Is Plot Then
                    Dim plot As Plot = DirectCast(item.Source, Plot)
                    plot.LineColor = randomColor
                    Debug.WriteLine("Item selected was a Plot")
                ElseIf TypeOf item.Source Is DigitalPlot Then
                    Dim plot As DigitalPlot = DirectCast(item.Source, DigitalPlot)
                    plot.LineColor = randomColor
                    Debug.WriteLine("Item selected was a Digital Plot")
                End If
                Exit Select
            Case LegendHitTestInfo.Text
                Debug.WriteLine("Text area of legend selected")
                Exit Select
            Case LegendHitTestInfo.VerticalScrollBar
                Debug.WriteLine("vertical scrollbar selected")
                Exit Select
            Case LegendHitTestInfo.None
                Debug.WriteLine("Unknown legend area selected")
                Exit Select
        End Select
    End Sub

    ''' <summary>
    ''' Retrieves the size of a rectangular area Integero which the control can 
    ''' be fitted. This member overrides Control.GetPreferredSize and is 
    ''' implemented in the Legend class.  
    ''' </summary>
    ''' <signature>Legend.GetPreferredSize(Size)</signature>
    ''' <ExampleMethod />
    Public Sub GetPreferredSize_Size()
        ' The following example demonstrates getting the preferred size of a Legend object.
        Dim newSize As Size = legend.GetPreferredSize(Size.Empty)

        Debug.WriteLine(String.Format("The legend's original size is {0}", legend.Size.ToString()))
        Debug.WriteLine(String.Format("The legend's proposed size is {0}", newSize.ToString()))
    End Sub

#End Region

#Region "helper methods for the SnipsLegend class"

    Public Overrides Function ToString() As String
        Return legend.ToString()
    End Function

    ''' <summary>
    ''' Updates the legend to display the items in the SnipsLegendItem list
    ''' </summary>
    ''' <param name="items">Items to be displayed in the legend.</param>
    Public Sub SetItems(ByVal items As List(Of SnipsLegendItem))
        Dim legendItem As LegendItem

        legend.Items.Clear()

        If items IsNot Nothing Then
            For Each item As SnipsLegendItem In items
                If item.IsVisible Then
                    legendItem = New LegendItem(item, item.ItemLabel)
                    legend.Items.Add(legendItem)
                End If
            Next
        End If
    End Sub
#End Region
End Class

#Region "helper methods for the SnipsLegend class"
''' <summary>
''' A helper class for snips controls that need to be added to a legend
''' </summary>
Public Class SnipsLegendItem
    Implements ILegendItemSource
    Private item As ILegendItemSource
    Private label As String
    Private visible As Boolean

    ''' <summary>
    ''' Public constructor for the Snips Legend Item
    ''' </summary>
    ''' <param name="Item">The item to be added to the legend</param>
    ''' <param name="ItemLabel">The label to be displayed on the legend</param>
    ''' <param name="Visible">Whether or not the item is visible</param>
    Public Sub New(ByVal item As ILegendItemSource, ByVal itemLabel As String, ByVal visible As Boolean)
        Me.item = item
        Me.label = itemLabel
        Me.visible = visible
    End Sub

    ''' <summary>
    ''' Draws the symbol of a legend item
    ''' </summary>
    ''' <param name="args">A ComponentDrawArgs that contains the graphics 
    ''' surface to draw the legend item on and the bounds in which to 
    ''' draw the legend item.</param>
    Public Sub DrawLegendItem(ByVal args As ComponentDrawArgs) Implements ILegendItemSource.DrawLegendItem
        item.DrawLegendItem(args)
    End Sub

    ''' <summary>
    ''' Event signaling when the legend item has been disposed
    ''' </summary>
    Public Event Disposed As EventHandler Implements ILegendItemSource.Disposed
    Protected Overridable Sub OnDisposed(ByVal e As EventArgs)
        RaiseEvent Disposed(Me, e)
    End Sub

    ''' <summary>
    ''' Event signaling when the legend item changes
    ''' </summary>
    Public Event LegendItemChanged As EventHandler Implements ILegendItemSource.LegendItemChanged
    Protected Overridable Sub OnLegendItemChanged(ByVal e As EventArgs)
        RaiseEvent LegendItemChanged(Me, e)
    End Sub

    ''' <summary>
    ''' The label to be displayed for the legend item
    ''' </summary>
    Public Property ItemLabel() As String
        Get
            Return label
        End Get
        Set(ByVal value As String)
            label = value
        End Set
    End Property

    ''' <summary>
    ''' Whether or not the item is visible
    ''' </summary>
    Public Property IsVisible() As Boolean
        Get
            Return visible
        End Get
        Set(ByVal value As Boolean)
            visible = value
        End Set
    End Property
End Class
#End Region
