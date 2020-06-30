
Imports NationalInstruments.UI
Imports System.ComponentModel
Imports System.Drawing

Partial Class DefaultAspx
    Inherits Page

    Private Const NumerSamples As Int32 = 100
    Private Const Frequency As Single = 1

    Private Function GenerateData(ByVal phase As Double) As Double()
        Dim data(NumerSamples) As Double
        Dim angle As Double
        Dim rand As Random = New Random()

        For x As Int32 = 0 To data.Length - 1
            angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase
            data(x) = Math.Sin(angle) + (rand.NextDouble() / 5)
        Next x

        Return data
    End Function

    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
        MyBase.OnLoad(e)
        If Not IsPostBack Then
            Dim data As Double() = GenerateData(0)
            WaveformGraph1.PlotY(data)
            Dim minAnnotation As XYPointAnnotation = GetMinAnnotation()
            Dim maxAnnotation As XYPointAnnotation = GetMaxAnnotation()
            Dim shapeColor As Color = Color.FromArgb(150, Color.Lime)
            minAnnotation.ShapeFillColor = shapeColor
            maxAnnotation.ShapeFillColor = shapeColor

            Dim minIndex As Int32
            Dim MaxIndex As Int32

            GetMaxMin(data, minIndex, MaxIndex)

            minAnnotation.XPosition = minIndex
            minAnnotation.YPosition = data(minIndex)

            maxAnnotation.XPosition = MaxIndex
            maxAnnotation.YPosition = data(MaxIndex)
        End If
    End Sub

    Private Function ParseValue(Of TValue)(ByVal value As String) As TValue
        Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(TValue))
        Return CType(converter.ConvertFromInvariantString(value), TValue)
    End Function

    Private Function GetMinAnnotation() As XYPointAnnotation
        Dim minAnnotation As XYPointAnnotation = CType(WaveformGraph1.Annotations.Item(2), XYPointAnnotation)
        Return minAnnotation
    End Function

    Private Function GetMaxAnnotation() As XYPointAnnotation
        Dim maxAnnotation As XYPointAnnotation = CType(WaveformGraph1.Annotations.Item(3), XYPointAnnotation)
        Return maxAnnotation
    End Function

    Private Sub GetMaxMin(ByVal values As Double(), ByRef minIndex As Int32, ByRef maxIndex As Int32)
        If values Is Nothing Then
            Throw New ArgumentNullException("values")
        End If

        Dim minimum As Double = Double.MaxValue
        Dim maximum As Double = Double.MinValue

        For i As Int32 = 0 To values.Length - 1
            Dim currentValue As Double = values(i)

            If (currentValue < minimum) Then
                minimum = currentValue
                minIndex = i
            End If

            If (currentValue > maximum) Then
                maximum = currentValue
                maxIndex = i
            End If
        Next i

    End Sub

    Protected Sub maxArrowHeadDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim maxAnnotation As XYPointAnnotation = GetMaxAnnotation()
        maxAnnotation.ArrowHeadStyle = ParseValue(Of ArrowStyle)(maxArrowHeadDropDown.SelectedValue)
    End Sub

    Protected Sub minArrowHeadDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim minAnnotation As XYPointAnnotation = GetMinAnnotation()
        minAnnotation.ArrowHeadStyle = ParseValue(Of ArrowStyle)(minArrowHeadDropDown.SelectedValue)
    End Sub

    Private Sub SetMaxCaptionAlignment()
        Dim MaxAnnotation As XYPointAnnotation = GetMaxAnnotation()
        Dim Alignment As BoundsAlignment = ParseValue(Of BoundsAlignment)(maxCaptionAlignmentDropDown.SelectedValue)

        MaxAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(Alignment, CType(maxCaptionXOffsetNumEdit.Value, Single), CType(maxCaptionYOffsetNumEdit.Value, Single))
    End Sub

    Private Sub SetMinCaptionAlignment()
        Dim minAnnotation As XYPointAnnotation = GetMinAnnotation()
        Dim Alignment As BoundsAlignment = ParseValue(Of BoundsAlignment)(minCaptionAlignmentDropDown.SelectedValue)

        minAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(Alignment, CType(minCaptionXOffsetNumEdit.Value, Single), CType(minCaptionYOffsetNumEdit.Value, Single))
    End Sub

    Protected Sub maxCaptionAlignmentDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetMaxCaptionAlignment()
    End Sub

    Protected Sub maxCaptionXOffsetNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxCaptionAlignment()
    End Sub

    Protected Sub maxCaptionYOffsetNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxCaptionAlignment()
    End Sub

    Protected Sub minCaptionAlignmentDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetMinCaptionAlignment()
    End Sub

    Protected Sub minCaptionXOffsetNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinCaptionAlignment()
    End Sub

    Protected Sub minCaptionYOffsetNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinCaptionAlignment()
    End Sub

    Protected Sub maxShapeVisibleCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim MaxAnnotation As XYPointAnnotation = GetMaxAnnotation()
        MaxAnnotation.ShapeVisible = maxShapeVisibleCheckBox.Checked
    End Sub

    Protected Sub minShapeVisibleCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim minAnnotation As XYPointAnnotation = GetMinAnnotation()
        minAnnotation.ShapeVisible = minShapeVisibleCheckBox.Checked
    End Sub

    Private Sub SetMaxShapeSize()
        Dim MaxAnnotation As XYPointAnnotation = GetMaxAnnotation()
        MaxAnnotation.ShapeSize = New Size(CType(maxShapeWidthNumEdit.Value, Int32), CType(maxShapeHeightNumEdit.Value, Int32))
    End Sub

    Private Sub SetMinShapeSize()
        Dim minAnnotation As XYPointAnnotation = GetMinAnnotation()
        minAnnotation.ShapeSize = New Size(CType(minShapeWidthNumEdit.Value, Int32), CType(minShapeHeightNumEdit.Value, Int32))
    End Sub

    Protected Sub maxShapeWidthNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxShapeSize()
    End Sub

    Protected Sub maxShapeHeightNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxShapeSize()
    End Sub

    Protected Sub minShapeWidthNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinShapeSize()
    End Sub

    Protected Sub minShapeHeightNumEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinShapeSize()
    End Sub
End Class
