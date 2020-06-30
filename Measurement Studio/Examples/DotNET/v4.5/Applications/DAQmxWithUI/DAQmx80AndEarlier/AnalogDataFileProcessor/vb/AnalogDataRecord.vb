Imports System

' Stores data written to and read from files.
    <Serializable()> _
    Public Class AnalogDataRecord
        Private _data As Double()
        Private _startTime As DateTime
        Private _sampleIncrement As TimeSpan

    Public Sub New(ByVal recordData As Double(), ByVal recordStartTime As DateTime, ByVal recordSampleIncrement As TimeSpan)
        _data = recordData
        _startTime = recordStartTime
        _sampleIncrement = recordSampleIncrement
    End Sub

    Public ReadOnly Property StartTime() As DateTime
        Get
            Return _startTime
        End Get
    End Property

    Public ReadOnly Property SampleIncrement() As TimeSpan
        Get
            Return _sampleIncrement
        End Get
    End Property

    Public Function GetData() As Double()
        Return _data
    End Function
End Class