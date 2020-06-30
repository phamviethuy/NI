Public Class SnipsControl
    Private control As Control
    Private lastBoxItem As Object
    Private randNumGenerator As Random

    Public Sub New(ByVal control As Control)
        Me.control = control
        randNumGenerator = New Random(DateTime.Now.Millisecond)
    End Sub

    ''' <summary>
    ''' A random number generator belonging to all
    ''' snips control types.
    ''' </summary>
    Protected ReadOnly Property RandNumberGenerator() As Random
        Get
            Return randNumGenerator
        End Get
    End Property

    ''' <summary>
    ''' This property retuns a reference to the control that
    ''' is being encapsulated by the SnipsControl instance
    ''' </summary>
    Public ReadOnly Property InternalControl() As Control
        Get
            Return control
        End Get
    End Property

    ''' <summary>
    ''' Reset the control to its default state
    ''' </summary>
    Public Overridable Sub ResetToDefaultState()
    End Sub

    Public Property LastComboBoxItem() As Object
        Get
            Return lastBoxItem
        End Get
        Set(ByVal value As Object)
            lastBoxItem = value
        End Set
    End Property
End Class
