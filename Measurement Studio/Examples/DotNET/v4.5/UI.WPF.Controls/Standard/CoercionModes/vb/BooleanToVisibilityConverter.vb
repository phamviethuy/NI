Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Data
Imports System.Windows

''' <summary>
''' This class allows for conversion of Boolean values into System.Windows.Visibility values.
''' This conversion can be used in Bindings from Boolean controls to the visibility of another
''' control within the XAML for a UI.
''' </summary>
<ValueConversion(GetType(Boolean), GetType(Visibility))> _
Public Class BooleanToVisibilityConverter
    Implements System.Windows.Data.IValueConverter
    Public Sub New()
    End Sub

#Region "IValueConverter Members"

    Public Function Convert(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.Convert
        Dim isVisible As System.Nullable(Of Boolean) = DirectCast(value, System.Nullable(Of Boolean))
        If isVisible.HasValue Then
            Dim visible As Boolean = isVisible.Value
            If visible Then
                Return Visibility.Visible
            Else
                Return Visibility.Collapsed
            End If
        End If

        Return Visibility.Collapsed
    End Function

    Public Function ConvertBack(value As Object, targetType As Type, parameter As Object, culture As System.Globalization.CultureInfo) As Object Implements System.Windows.Data.IValueConverter.ConvertBack
        Dim visibility As Visibility = DirectCast(value, Visibility)
        If visibility = visibility.Visible Then
            Return True
        End If
        Return False
    End Function

#End Region
End Class
