Imports NationalInstruments.UI.WindowsForms

Class SnipsNumericPointer
    Inherits SnipsControlBase
    Private numericPointer As NumericPointer
    Private timer As Timer
    Private _animate As Boolean

    Public Sub New(ByVal NumericPointer__1 As NumericPointer)
        MyBase.New(NumericPointer__1)
        numericPointer = NumericPointer__1
        timer = New Timer()
        timer.Interval = 100
        AddHandler timer.Tick, AddressOf timer_Tick
        AddHandler numericPointer.Enter, AddressOf numericPointer_Enter
        timer.Start()
    End Sub

#Region "helper methods for the SnipsNumericPointer class"

    Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
        Try
            If _animate Then
                numericPointer.Value = If(numericPointer.Value > 9.9, 0, numericPointer.Value + 0.1)
            End If
        Catch generatedExceptionName As ObjectDisposedException
        End Try
    End Sub

    Private Sub numericPointer_Enter(ByVal sender As Object, ByVal e As EventArgs)
        MainForm.Legend.SetItems(Nothing)
    End Sub

    Public Property Animate() As Boolean
        Get
            Return _animate
        End Get
        Set(ByVal value As Boolean)
            _animate = value
        End Set
    End Property
#End Region
End Class
