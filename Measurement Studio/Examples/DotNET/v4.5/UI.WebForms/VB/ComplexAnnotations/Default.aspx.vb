
Imports NationalInstruments
Imports NationalInstruments.UI
Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Class DefaultAspx
    Inherits Page

    Private Const NumerSamples As Integer = 100
    Private Const Frequency As Single = 1
    Private Const Radius As Double = 1.75

    Private Function GenerateData(ByVal phase As Double, ByVal radius As Double, ByVal noise As Boolean) As Double()
        Dim data(NumerSamples) As Double
        Dim angle As Double
        Dim rand As Random = New Random()

        For x As Int32 = 0 To data.Length - 1
            angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase
            data(x) = Math.Sin(angle) * radius + IIf(noise, (rand.NextDouble() - 0.5) / 2, 0)
        Next x

        Return data
    End Function


    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        If Not IsPostBack Then
            Dim realData() As Double = GenerateData(0, Radius, True)
            Dim imaginaryData() As Double = GenerateData(Math.PI / 2, Radius, False)
            complexGraph1.PlotComplex(ComplexDouble.ComposeArray(realData, imaginaryData))


            Dim circleAnnotation As MagnitudeCircleAnnotation = GetCircleAnnotation()
            circleAnnotation.Magnitude = Radius

            Dim prAnnotation As MagnitudePhaseRangeAnnotation = GetPhaseRangeAnnotation()
            prAnnotation.StartMagnitude = Radius - 0.2


            Dim minAnnotation As ComplexPointAnnotation = GetMinAnnotation()
            Dim maxAnnotation As ComplexPointAnnotation = GetMaxAnnotation()
            Dim shapeColor As Color = Color.FromArgb(150, Color.Lime)
            minAnnotation.ShapeFillColor = shapeColor
            maxAnnotation.ShapeFillColor = shapeColor

            Dim minIndex As Integer, maxIndex As Integer
            GetMaxMin(realData, minIndex, maxIndex)

            minAnnotation.Position = New ComplexDouble(realData(minIndex), imaginaryData(minIndex))
            maxAnnotation.Position = New ComplexDouble(realData(maxIndex), imaginaryData(maxIndex))


            SetCircleCaptionAlignment()
            SetPhaseRangeCaptionAlignment()
            SetMinCaptionAlignment()
            SetMaxCaptionAlignment()
        End If
    End Sub


    Private Function GetMinAnnotation() As ComplexPointAnnotation
        Dim minAnnotation As ComplexPointAnnotation = CType(ComplexGraph1.Annotations.Item(2), ComplexPointAnnotation)
        Return minAnnotation
    End Function

    Private Function GetMaxAnnotation() As ComplexPointAnnotation
        Dim maxAnnotation As ComplexPointAnnotation = CType(ComplexGraph1.Annotations.Item(3), ComplexPointAnnotation)
        Return maxAnnotation
    End Function

    Private Function GetCircleAnnotation() As MagnitudeCircleAnnotation
        Dim circleAnnotation As MagnitudeCircleAnnotation = CType(ComplexGraph1.Annotations.Item(4), MagnitudeCircleAnnotation)
        Return circleAnnotation
    End Function

    Private Function GetPhaseRangeAnnotation() As MagnitudePhaseRangeAnnotation
        Dim prAnnotation As MagnitudePhaseRangeAnnotation = CType(ComplexGraph1.Annotations.Item(5), MagnitudePhaseRangeAnnotation)
        Return prAnnotation
    End Function


    Private Function ParseValue(Of TValue)(ByVal value As String) As TValue
        Dim converter As TypeConverter = TypeDescriptor.GetConverter(GetType(TValue))
        Return CType(converter.ConvertFromInvariantString(value), TValue)
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


    Protected Sub circleArrowHeadDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim circleAnnotation As MagnitudeCircleAnnotation = GetCircleAnnotation()
        circleAnnotation.ArrowHeadStyle = ParseValue(Of ArrowStyle)(circleArrowHeadDropDown.SelectedValue)
    End Sub

    Protected Sub prArrowHeadDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim prAnnotation As MagnitudePhaseRangeAnnotation = GetPhaseRangeAnnotation()
        prAnnotation.ArrowHeadStyle = ParseValue(Of ArrowStyle)(prArrowHeadDropDown.SelectedValue)
    End Sub

    Protected Sub maxArrowHeadDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim maxAnnotation As ComplexPointAnnotation = GetMaxAnnotation()
        maxAnnotation.ArrowHeadStyle = ParseValue(Of ArrowStyle)(maxArrowHeadDropDown.SelectedValue)
    End Sub

    Protected Sub minArrowHeadDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim minAnnotation As ComplexPointAnnotation = GetMinAnnotation()
        minAnnotation.ArrowHeadStyle = ParseValue(Of ArrowStyle)(minArrowHeadDropDown.SelectedValue)
    End Sub


    Private Sub SetCircleCaptionAlignment()
        Dim circleAnnotation As MagnitudeCircleAnnotation = GetCircleAnnotation()
        Dim Alignment As BoundsAlignment = ParseValue(Of BoundsAlignment)(circleCaptionAlignmentDropDown.SelectedValue)

        circleAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(Alignment, CType(circleCaptionRealOffsetNumericEdit.Value, Single), CType(circleCaptionImaginaryOffsetNumericEdit.Value, Single))
    End Sub

    Private Sub SetPhaseRangeCaptionAlignment()
        Dim prAnnotation As MagnitudePhaseRangeAnnotation = GetPhaseRangeAnnotation()
        Dim Alignment As BoundsAlignment = ParseValue(Of BoundsAlignment)(prCaptionAlignmentDropDown.SelectedValue)

        prAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(Alignment, CType(prCaptionRealOffsetNumericEdit.Value, Single), CType(prCaptionImaginaryOffsetNumericEdit.Value, Single))
    End Sub

    Private Sub SetMaxCaptionAlignment()
        Dim MaxAnnotation As ComplexPointAnnotation = GetMaxAnnotation()
        Dim Alignment As BoundsAlignment = ParseValue(Of BoundsAlignment)(maxCaptionAlignmentDropDown.SelectedValue)

        MaxAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(Alignment, CType(maxCaptionRealOffsetNumericEdit.Value, Single), CType(maxCaptionImaginaryOffsetNumericEdit.Value, Single))
    End Sub

    Private Sub SetMinCaptionAlignment()
        Dim minAnnotation As ComplexPointAnnotation = GetMinAnnotation()
        Dim Alignment As BoundsAlignment = ParseValue(Of BoundsAlignment)(minCaptionAlignmentDropDown.SelectedValue)

        minAnnotation.CaptionAlignment = New AnnotationCaptionAlignment(Alignment, CType(minCaptionRealOffsetNumericEdit.Value, Single), CType(minCaptionImaginaryOffsetNumericEdit.Value, Single))
    End Sub

    Protected Sub circleCaptionAlignmentDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetCircleCaptionAlignment()
    End Sub

    Protected Sub circleCaptionRealOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetCircleCaptionAlignment()
    End Sub

    Protected Sub circleCaptionImaginaryOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetCircleCaptionAlignment()
    End Sub

    Protected Sub prCaptionAlignmentDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetPhaseRangeCaptionAlignment()
    End Sub

    Protected Sub prCaptionRealOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetPhaseRangeCaptionAlignment()
    End Sub

    Protected Sub prCaptionImaginaryOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetPhaseRangeCaptionAlignment()
    End Sub

    Protected Sub maxCaptionAlignmentDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetMaxCaptionAlignment()
    End Sub

    Protected Sub maxCaptionRealOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxCaptionAlignment()
    End Sub

    Protected Sub maxCaptionImaginaryOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxCaptionAlignment()
    End Sub

    Protected Sub minCaptionAlignmentDropDown_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        SetMinCaptionAlignment()
    End Sub

    Protected Sub minCaptionRealOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinCaptionAlignment()
    End Sub

    Protected Sub minCaptionImaginaryOffsetNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinCaptionAlignment()
    End Sub


    Protected Sub circleArrowVisibleCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim circleAnnotation As MagnitudeCircleAnnotation = GetCircleAnnotation()
        circleAnnotation.ArrowVisible = circleArrowVisibleCheckBox.Checked
    End Sub

    Protected Sub circleCaptionVisibleCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim circleAnnotation As MagnitudeCircleAnnotation = GetCircleAnnotation()
        circleAnnotation.CaptionVisible = circleCaptionVisibleCheckBox.Checked
    End Sub

    Protected Sub maxShapeVisibleCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim MaxAnnotation As ComplexPointAnnotation = GetMaxAnnotation()
        MaxAnnotation.ShapeVisible = maxShapeVisibleCheckBox.Checked
    End Sub

    Protected Sub minShapeVisibleCheckBox_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim minAnnotation As ComplexPointAnnotation = GetMinAnnotation()
        minAnnotation.ShapeVisible = minShapeVisibleCheckBox.Checked
    End Sub


    Protected Sub circleCaptionTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim circleAnnotation As MagnitudeCircleAnnotation = GetCircleAnnotation()
        circleAnnotation.Caption = circleCaptionTextBox.Text
    End Sub

    Protected Sub circleMagnitudeNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        Dim circleAnnotation As MagnitudeCircleAnnotation = GetCircleAnnotation()
        circleAnnotation.Magnitude = circleMagnitudeNumericEdit.Value
    End Sub

    Protected Sub prStartMagnitudeNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        Dim prAnnotation As MagnitudePhaseRangeAnnotation = GetPhaseRangeAnnotation()
        prAnnotation.StartMagnitude = prStartMagnitudeNumericEdit.Value
    End Sub

    Protected Sub prMagnitudeNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        Dim prAnnotation As MagnitudePhaseRangeAnnotation = GetPhaseRangeAnnotation()
        prAnnotation.Magnitude = prMagnitudeNumericEdit.Value
    End Sub


    Private Sub SetPhaseRange()
        Dim prAnnotation As MagnitudePhaseRangeAnnotation = GetPhaseRangeAnnotation()
        prAnnotation.Phase = New Arc(CType(prPhaseStartNumericEdit.Value, Single), CType(prPhaseRangeNumericEdit.Value, Single))
    End Sub

    Protected Sub prPhaseStartNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetPhaseRange()
    End Sub

    Protected Sub prPhaseRangeNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetPhaseRange()
    End Sub


    Private Sub SetMaxShapeSize()
        Dim MaxAnnotation As ComplexPointAnnotation = GetMaxAnnotation()
        MaxAnnotation.ShapeSize = New Size(CType(maxShapeWidthNumericEdit.Value, Int32), CType(maxShapeHeightNumericEdit.Value, Int32))
    End Sub

    Private Sub SetMinShapeSize()
        Dim minAnnotation As ComplexPointAnnotation = GetMinAnnotation()
        minAnnotation.ShapeSize = New Size(CType(minShapeWidthNumericEdit.Value, Int32), CType(minShapeHeightNumericEdit.Value, Int32))
    End Sub

    Protected Sub maxShapeWidthNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxShapeSize()
    End Sub

    Protected Sub maxShapeHeightNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMaxShapeSize()
    End Sub

    Protected Sub minShapeWidthNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinShapeSize()
    End Sub

    Protected Sub minShapeHeightNumericEdit_AfterChangeValue(ByVal sender As Object, ByVal e As AfterChangeNumericValueEventArgs)
        SetMinShapeSize()
    End Sub
End Class
