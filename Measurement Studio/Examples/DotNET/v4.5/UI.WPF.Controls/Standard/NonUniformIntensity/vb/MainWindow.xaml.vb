
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Media.Media3D

Partial Public Class MainWindow
    Inherits Window

    Public Sub New()
        InitializeComponent()

        Dim resolutions As Double() = New Double() {2.0, 1.0, 0.5}
        Dim data As New List(Of List(Of Point3D))
        Const Radius As Integer = 6
        For Each resolution As Double In resolutions
            Dim current As New List(Of Point3D)
            data.Add(current)

            Dim offset = (resolution / 2) Mod 1.0
            For i As Integer = -Radius To Radius
                Dim x As Double = i * resolution
                For j As Integer = -Radius To Radius
                    Dim y As Double = j * resolution
                    Dim z As Double = x * y / 6
                    current.Add(New Point3D(x + offset, y + offset, z))
                Next
            Next
        Next

        graph.DataSource = data
    End Sub

End Class
