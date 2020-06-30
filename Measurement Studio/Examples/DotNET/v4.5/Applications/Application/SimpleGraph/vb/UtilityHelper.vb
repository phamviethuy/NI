Imports System.Text.RegularExpressions
Imports System.Resources
Imports System.Reflection

Public Class UtilityHelper
    Private helpIndex As Int32
    Private menuHelper As Hashtable
    Private helperStrings As String()
    Private toolTips As String()
    Private list As ArrayList


    Public Sub New()
        menuHelper = New Hashtable
        helpIndex = 0
        list = New ArrayList
        
        Dim manager As ResourceManager = New ResourceManager("NationalInstruments.Examples.SimpleGraph.Strings", GetType(MainForm).Assembly)
        helperStrings = ParseResource(manager.GetString("helperStrings"))
        toolTips = ParseResource(manager.GetString("toolTips"))
    End Sub

    Private Function ParseResource(ByVal temp As String) As String()
        Dim regex As Regex = New Regex("(\t| ){2,}")
        temp = regex.Replace(temp, "")
        Return System.Text.RegularExpressions.Regex.Split(temp, Environment.NewLine)
    End Function

    Public Sub AddMenuString(ByVal key As Object)
        Debug.Assert(helpIndex >= 0 And helpIndex < helperStrings.Length, "No menu helper string found for help index")
        menuHelper.Add(key, helperStrings(helpIndex))
        helpIndex += 1
    End Sub

    Public Function GetMenuString(ByVal key As Object) As String
        Return menuHelper.Item(key)
    End Function

    Public Function GetToolTip(ByVal index As Integer) As String
        Debug.Assert(index >= 0 And index < toolTips.Length, "Specified index is not a valid tooltip index")
        Return toolTips(index)
    End Function

    Public Sub MapMenuAndToolBar(ByVal button As ToolBarButton, ByVal item As MenuItem)
        list.Add(New Pair(button, item))
    End Sub

    Public Function FromToolBarButton(ByVal toolBarButton As ToolBarButton) As MenuItem
        For Each temp As Pair In list
            If temp.Button.Equals(toolBarButton) Then
                Return temp.Item
            End If
        Next

        Debug.Fail("Cannot find MenuItem from the ToolBarButton passed in")
        Return Nothing
    End Function

    Public Function FromMenuItem(ByVal item As MenuItem) As ToolBarButton
        For Each temp As Pair In list
            If temp.Item.Equals(item) Then
                Return temp.Button
            End If
        Next

        Debug.Fail("Cannot find ToolBarButton from the MenuItem passed in")
        Return Nothing
    End Function

    Private Class Pair
        Private _button As ToolBarButton
        Private _item As MenuItem

        Public Sub New(ByVal buttonVal As ToolBarButton, ByVal itemVal As MenuItem)
            _button = buttonVal
            _item = itemVal
        End Sub

        Public Property Button() As ToolBarButton
            Get
                Return _button
            End Get
            Set(ByVal Value As ToolBarButton)
                _button = Value
            End Set
        End Property

        Public Property Item() As MenuItem
            Get
                Return _item
            End Get
            Set(ByVal Value As MenuItem)
                _item = Value
            End Set
        End Property

    End Class
End Class
