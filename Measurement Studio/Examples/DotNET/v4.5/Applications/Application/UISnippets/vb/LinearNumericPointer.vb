Imports NationalInstruments.UI.WindowsForms

Class SnipsLinearNumericPointer
    Inherits SnipsNumericPointer
    Private linearNumeric As LinearNumericPointer

    Public Sub New(ByVal LinearNumeric__1 As LinearNumericPointer)
        MyBase.New(LinearNumeric__1)
        linearNumeric = LinearNumeric__1
    End Sub

#Region "code snippets for NationalInstruments.UI.WindowsForms.LinearNumericPointer"

    ''' <summary>
    ''' Returns a LinearNumericPointerHitTestInfo that specifies where on the control 
    ''' the specified point is located.   It is implemented in the LinearNumericPointer 
    ''' class. To run this method, you must first click the run snippet button, and 
    ''' then click somewhere inside the slide area. 
    ''' </summary>
    ''' <signature>HitTest(Integer, Integer)</signature>
    ''' <ExampleMethod />
    <EventBased("MouseDown")> _
    Public Sub LinearNumericPointerHitTest_int_int(ByVal sender As Object, ByVal e As MouseEventArgs)
        ' The following example demonstrates using the HitTest method to determine
        ' where a user clicked on a LinearNumericPointer object.
        Dim hitTestRegion As LinearNumericPointerHitTestInfo
        Dim randomColor As Color = Color.FromArgb(RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255), RandNumberGenerator.[Next](255))

        hitTestRegion = linearNumeric.HitTest(e.X, e.Y)

        Select Case hitTestRegion
            Case LinearNumericPointerHitTestInfo.Fill
                linearNumeric.FillColor = randomColor
                Debug.WriteLine("Filled area clicked")
                Exit Select
            Case LinearNumericPointerHitTestInfo.FillBackground
                linearNumeric.FillBackColor = randomColor
                Debug.WriteLine("Fill background area clicked")
                Exit Select
            Case LinearNumericPointerHitTestInfo.Pointer
                linearNumeric.PointerColor = randomColor
                Debug.WriteLine("Pointer clicked")
                Exit Select
            Case LinearNumericPointerHitTestInfo.ScaleArea
                linearNumeric.ScaleBaseLineColor = randomColor
                Debug.WriteLine("The scale area was clicked")
                Exit Select
            Case LinearNumericPointerHitTestInfo.None
                Debug.WriteLine("Unknown area clicked")
                Exit Select
        End Select
    End Sub

#End Region

#Region "helper methods for the SnipsLinearNumericPointer class"

    Public Overrides Function ToString() As String
        Return linearNumeric.[GetType]().Name
    End Function
#End Region
End Class