Imports NationalInstruments.UI.WindowsForms

Class SnipsRadialNumericPointer
    Inherits SnipsNumericPointer
    Private radialNumeric As RadialNumericPointer

    Public Sub New(ByVal RadialNumeric__1 As RadialNumericPointer)
        MyBase.New(RadialNumeric__1)
        radialNumeric = RadialNumeric__1
    End Sub

#Region "code snippets for NationalInstruments.UI.WindowsForms.RadialNumericPointer"

    ''' <summary>
    ''' Returns a RadialNumericPointerHitTestInfo that specifies where on the control
    ''' the specified point is located.  It is implemented in the RadialNumericPointer 
    ''' class. To run this method, you must first click the run snippet button, and 
    ''' then click somewhere inside the gauge area. 
    ''' </summary>
    ''' <signature>HitTest(Integer, Integer)</signature>
    ''' <ExampleMethod />
    <EventBased("MouseDown")> _
    Public Sub RadialNumericPointerHitTest_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates using the HitTest method to determine
        ' where a user clicked on a LinearNumericPointer object.
        Dim hitTestRegion As RadialNumericPointerHitTestInfo
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        hitTestRegion = radialNumeric.HitTest(e.X, e.Y)
        Select Case hitTestRegion
            Case RadialNumericPointerHitTestInfo.Dial
                radialNumeric.DialColor = randomColor
                Debug.WriteLine("The dial was clicked")
                Exit Select
            Case RadialNumericPointerHitTestInfo.OuterScaleArea
                Debug.WriteLine("The outer scale area was clicked")
                Exit Select
            Case RadialNumericPointerHitTestInfo.Pointer
                radialNumeric.PointerColor = randomColor
                Debug.WriteLine("The pointer was clicked")
                Exit Select
            Case RadialNumericPointerHitTestInfo.ScaleArea
                radialNumeric.ScaleBaseLineColor = randomColor
                Debug.WriteLine("The scale was clicked")
                Exit Select
            Case RadialNumericPointerHitTestInfo.None
                Debug.WriteLine("Unknown area was clicked")
                Exit Select
        End Select
    End Sub

#End Region

#Region "helper methods for the SnipsRadialNumericPointer class"

    Public Overrides Function ToString() As String
        Return radialNumeric.[GetType]().Name
    End Function

#End Region
End Class
