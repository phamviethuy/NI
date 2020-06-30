Public Class MainForm

    <STAThread()> _
    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm())
    End Sub

    Public Sub New()
        InitializeComponent()

        AddHandler scalingSwitchArray.ValuesChanged, AddressOf OnScalingSwitchArrayValuesChanged
        AddHandler scaleModePropertyEditor.SourceValueChanged, AddressOf OnScaleModePropertyEditorSourceValueChanged
        AddHandler addButton.Click, AddressOf OnAddButtonClick
        AddHandler removeButton.Click, AddressOf OnRemoveButtonClick
        AddHandler indexComboBox.SelectedIndexChanged, AddressOf OnIndexComboboxSelectedIndexChanged

        AddHandler scalingSwitchArray.ItemPropertyChanged, AddressOf OnScalingSwitchArrayItemPropertyChanged
        OnScaleModeChanged()

        booleanComboBox.SelectedIndex = 0

        Dim i As Integer = 0
        Do While (i < layoutNumericEditArray.Count)
            indexComboBox.Items.Add(i)
            i = i + 1
        Loop

        indexComboBox.SelectedIndex = 0
    End Sub


    Private Sub OnScalingSwitchArrayItemPropertyChanged(ByVal sender As Object, ByVal e As NationalInstruments.UI.ControlArrayPropertyChangedEventArgs(Of NationalInstruments.UI.WindowsForms.Switch))
        If e.PropertyName.Equals("Value") Then
            UpdateScalingLedArrayValues()
            UpdateValuesListBox()
        End If
    End Sub

    Private Sub OnScaleModeChanged()
        UpdateValuesListBox()

        Select Case (scalingSwitchArray.ScaleMode.Type)
            Case ControlArrayScaleModeType.Automatic
                automaticScaleModePanel.Enabled = True
            Case ControlArrayScaleModeType.Fixed
                automaticScaleModePanel.Enabled = False
        End Select
    End Sub

    Private Sub UpdateValuesListBox()
        valuesListBox.Items.Clear()
        Dim switchArrayValues() As Boolean = scalingSwitchArray.GetValues()
        For Each value As Boolean In switchArrayValues
            valuesListBox.Items.Add(value)
        Next
    End Sub

    Private Sub OnScaleModePropertyEditorSourceValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        scalingLedArray.ScaleMode = CType(scaleModePropertyEditor.SourceValue, ControlArrayScaleMode)
        OnScaleModeChanged()
    End Sub

    Private Sub OnAddButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim addedValue As Boolean = Convert.ToBoolean(booleanComboBox.SelectedItem)
        Dim switchArrayValues() As Boolean = scalingSwitchArray.GetValues
        Dim updatedValues As List(Of System.Boolean) = New List(Of System.Boolean)(switchArrayValues)
        updatedValues.Add(addedValue)
        scalingSwitchArray.SetValues(updatedValues.ToArray())
    End Sub

    Private Sub OnScalingSwitchArrayValuesChanged(ByVal sender As Object, ByVal e As EventArgs)
        UpdateScalingLedArrayValues()
        UpdateValuesListBox()
    End Sub

    Private Sub UpdateScalingLedArrayValues()
        Dim switchArrayValues() As Boolean = scalingSwitchArray.GetValues()
        scalingLedArray.SetValues(switchArrayValues)
    End Sub

    Private Sub OnRemoveButtonClick(ByVal sender As Object, ByVal e As EventArgs)
        If (valuesListBox.SelectedItems.Count > 0) Then
            For Each index As Integer In valuesListBox.SelectedIndices
                valuesListBox.Items.RemoveAt(index)
            Next

            Dim updatedValues() As Boolean = New Boolean((valuesListBox.Items.Count) - 1) {}

            Dim i As Integer = 0
            Do While (i < updatedValues.Length)
                updatedValues(i) = Convert.ToBoolean(valuesListBox.Items(i))
                i = i + 1
            Loop

            scalingSwitchArray.SetValues(updatedValues)
        End If
    End Sub

    Private Sub OnIndexComboboxSelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        rangePropertyEditor.Source = New PropertyEditorSource(layoutNumericEditArray(indexComboBox.SelectedIndex), "Range")
    End Sub

End Class
