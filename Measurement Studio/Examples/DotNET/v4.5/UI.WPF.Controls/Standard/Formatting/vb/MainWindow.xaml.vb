Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media

''' <summary>
''' This example shows different ways in which Numeric controls can be formatted. Most
''' of the fomatting is done using format strings in the XAML. However, there is also 
''' a demonstration of using a ValueFormatter class to format one of the Numeric text boxes.
''' </summary>
Class MainWindow
    Inherits Window
    Public Sub New()
        InitializeComponent()
        paddingFourBinary.ValueFormatter = New BinaryValueFormatter(4)
        paddingEightBinary.ValueFormatter = New BinaryValueFormatter(8)
    End Sub    
End Class