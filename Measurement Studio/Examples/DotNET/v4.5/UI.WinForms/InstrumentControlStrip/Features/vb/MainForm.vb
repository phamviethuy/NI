Public Class MainForm
    Private random As Random

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        For Each value As Object In [Enum].GetValues(GetType(PropertyEditorInteractionMode))
            propertyEditorInteractionModeComboBox.Items.Add(value)
            If DefaultToolStripPropertyEditor.InteractionMode.Equals(value) Then
                propertyEditorInteractionModeComboBox.SelectedItem = value
            End If
        Next
        For Each value As Object In [Enum].GetValues(GetType(BorderStyle))
            propertyEditorBorderStyleComboBox.Items.Add(value)
            If DefaultToolStripPropertyEditor.BorderStyle.Equals(value) Then
                propertyEditorBorderStyleComboBox.SelectedItem = value
            End If
        Next
        For Each value As Object In [Enum].GetValues(GetType(PropertyEditorRenderMode))
            propertyEditorRenderModeComboBox.Items.Add(value)
            If DefaultToolStripPropertyEditor.RenderMode.Equals(value) Then
                propertyEditorRenderModeComboBox.SelectedItem = value
            End If
        Next
        For Each value As Object In [Enum].GetValues(GetType(PropertyEditorDisplayMode))
            propertyEditorDisplayModeComboBox.Items.Add(value)
            If DefaultToolStripPropertyEditor.DisplayMode.Equals(value) Then
                propertyEditorDisplayModeComboBox.SelectedItem = value
            End If
        Next
        For Each value As Object In [Enum].GetValues(GetType(HorizontalAlignment))
            propertyEditorTextAlignComboBox.Items.Add(value)
            If DefaultToolStripPropertyEditor.PropertyTextAlign.Equals(value) Then
                propertyEditorTextAlignComboBox.SelectedItem = value
            End If
        Next

        Dim data() As Double = New Double(19) {}
        random = New Random

        Dim i As Integer = 0
        Do While (i < data.Length)
            data(i) = (random.NextDouble * sampleYAxis.Range.Maximum)
            i = i + 1
        Loop

        sampleWaveformGraph.PlotY(data)
        xAxisLabelFormatToolStripPropertyEditor.Source = New PropertyEditorSource(sampleXAxis.MajorDivisions, "LabelFormat")

    End Sub

    Private ReadOnly Property DefaultToolStripPropertyEditor() As ToolStripPropertyEditor
        Get
            Return interactionModeToolStripPropertyEditor
        End Get
    End Property

    Private Sub OnPropertyEditorInteractionModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorInteractionModeComboBox.SelectedIndexChanged
        For Each item As ToolStripItem In sampleInstrumentControlStrip.Items
            If (item.GetType() Is GetType(ToolStripPropertyEditor)) Then
                CType(item, ToolStripPropertyEditor).InteractionMode = CType(propertyEditorInteractionModeComboBox.SelectedItem, PropertyEditorInteractionMode)
            End If
        Next
    End Sub

    Private Sub OnPropertyEditorBorderStyleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorBorderStyleComboBox.SelectedIndexChanged
        For Each item As ToolStripItem In sampleInstrumentControlStrip.Items
            If (item.GetType() Is GetType(ToolStripPropertyEditor)) Then
                CType(item, ToolStripPropertyEditor).BorderStyle = CType(propertyEditorBorderStyleComboBox.SelectedItem, BorderStyle)
            End If
        Next
    End Sub

    Private Sub OnPropertyEditorRenderModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorRenderModeComboBox.SelectedIndexChanged
        For Each item As ToolStripItem In sampleInstrumentControlStrip.Items
            If (item.GetType() Is GetType(ToolStripPropertyEditor)) Then
                CType(item, ToolStripPropertyEditor).RenderMode = CType(propertyEditorRenderModeComboBox.SelectedItem, PropertyEditorRenderMode)
            End If
        Next
    End Sub

    Private Sub OnPropertyEditorDisplayModeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorDisplayModeComboBox.SelectedIndexChanged
        For Each item As ToolStripItem In sampleInstrumentControlStrip.Items
            If (item.GetType() Is GetType(ToolStripPropertyEditor)) Then
                CType(item, ToolStripPropertyEditor).DisplayMode = CType(propertyEditorDisplayModeComboBox.SelectedItem, PropertyEditorDisplayMode)
            End If
        Next
    End Sub

    Private Sub OnPropertyEditorTextAlignChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles propertyEditorTextAlignComboBox.SelectedIndexChanged
        For Each item As ToolStripItem In sampleInstrumentControlStrip.Items
            If (item.GetType() Is GetType(ToolStripPropertyEditor)) Then
                CType(item, ToolStripPropertyEditor).PropertyTextAlign = CType(propertyEditorTextAlignComboBox.SelectedItem, HorizontalAlignment)
            End If
        Next
    End Sub

    Public Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub
End Class
