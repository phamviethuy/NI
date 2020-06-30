
using NationalInstruments;
using NationalInstruments.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int NumerSamples = 101;
    private const float Frequency = 1;
    private const double Radius = 1.75;

    private double[] GenerateData(double phase, double radius, bool noise)
    {
        double[] data = new double[NumerSamples];
        double angle;
        Random rand = new Random();

        for (int x = 0; x < data.Length; x++)
        {
            angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase;
            data[x] = Math.Sin(angle) * radius + (noise ? (rand.NextDouble() - 0.5) / 2 : 0);
        }

        return data;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (!IsPostBack)
        {
            double[] realData = GenerateData(0, Radius, true);
            double[] imaginaryData = GenerateData(Math.PI / 2, Radius, false);
            complexGraph1.PlotComplex(ComplexDouble.ComposeArray(realData, imaginaryData));


            MagnitudeCircleAnnotation circleAnnotation = GetCircleAnnotation();
            circleAnnotation.Magnitude = Radius;

            MagnitudePhaseRangeAnnotation prAnnotation = GetPhaseRangeAnnotation();
            prAnnotation.StartMagnitude = Radius - 0.2;


            ComplexPointAnnotation minAnnotation = GetMinAnnotation();
            ComplexPointAnnotation maxAnnotation = GetMaxAnnotation();
            Color shapeColor = Color.FromArgb(150, Color.Lime);
            minAnnotation.ShapeFillColor = shapeColor;
            maxAnnotation.ShapeFillColor = shapeColor;

            int minIndex, maxIndex;
            GetMaxMin(realData, out minIndex, out maxIndex);

            minAnnotation.Position = new ComplexDouble(realData[minIndex], imaginaryData[minIndex]);
            maxAnnotation.Position = new ComplexDouble(realData[maxIndex], imaginaryData[maxIndex]);


            SetCircleCaptionAlignment();
            SetPhaseRangeCaptionAlignment();
            SetMinCaptionAlignment();
            SetMaxCaptionAlignment();
        }
    }


    private ComplexPointAnnotation GetMinAnnotation()
    {
        ComplexPointAnnotation minAnnotation = complexGraph1.Annotations[2] as ComplexPointAnnotation;
        return minAnnotation;
    }

    private ComplexPointAnnotation GetMaxAnnotation()
    {
        ComplexPointAnnotation maxAnnotation = complexGraph1.Annotations[3] as ComplexPointAnnotation;
        return maxAnnotation;
    }

    private MagnitudeCircleAnnotation GetCircleAnnotation()
    {
        MagnitudeCircleAnnotation circleAnnotation = complexGraph1.Annotations[4] as MagnitudeCircleAnnotation;
        return circleAnnotation;
    }

    private MagnitudePhaseRangeAnnotation GetPhaseRangeAnnotation()
    {
        MagnitudePhaseRangeAnnotation phaseRangeAnnotation = complexGraph1.Annotations[5] as MagnitudePhaseRangeAnnotation;
        return phaseRangeAnnotation;
    }


    private TValue ParseValue<TValue>(string value)
    {
        TypeConverter converter = TypeDescriptor.GetConverter(typeof(TValue));
        return (TValue)converter.ConvertFromInvariantString(value);
    }

    private void GetMaxMin(double[] values, out int minIndex, out int maxIndex)
    {
        if (values == null)
            throw new ArgumentNullException("values");

        minIndex = maxIndex = 0;
        double minimum = Double.MaxValue;
        double maximum = Double.MinValue;

        for (int i = 0; i < values.Length; ++i)
        {
            double currentValue = values[i];

            if (currentValue < minimum)
            {
                minimum = currentValue;
                minIndex = i;
            }

            if (currentValue > maximum)
            {
                maximum = currentValue;
                maxIndex = i;
            }
        }
    }


    protected void circleArrowHeadDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        MagnitudeCircleAnnotation circleAnnotation = GetCircleAnnotation();
        circleAnnotation.ArrowHeadStyle = ParseValue<ArrowStyle>(circleArrowHeadDropDown.SelectedValue);
    }

    protected void prArrowHeadDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        MagnitudePhaseRangeAnnotation prAnnotation = GetPhaseRangeAnnotation();
        prAnnotation.ArrowHeadStyle = ParseValue<ArrowStyle>(prArrowHeadDropDown.SelectedValue);
    }

    protected void maxArrowHeadDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        ComplexPointAnnotation maxAnnotation = GetMaxAnnotation();
        maxAnnotation.ArrowHeadStyle = ParseValue<ArrowStyle>(maxArrowHeadDropDown.SelectedValue);
    }

    protected void minArrowHeadDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        ComplexPointAnnotation minAnnotation = GetMinAnnotation();
        minAnnotation.ArrowHeadStyle = ParseValue<ArrowStyle>(minArrowHeadDropDown.SelectedValue);
    }


    private void SetCircleCaptionAlignment()
    {
        MagnitudeCircleAnnotation circleAnnotation = GetCircleAnnotation();
        BoundsAlignment alignment = ParseValue<BoundsAlignment>(circleCaptionAlignmentDropDown.SelectedValue);

        circleAnnotation.CaptionAlignment = new AnnotationCaptionAlignment(alignment, (float)circleCaptionRealOffsetNumericEdit.Value, (float)circleCaptionImaginaryOffsetNumericEdit.Value);
    }

    private void SetPhaseRangeCaptionAlignment()
    {
        MagnitudePhaseRangeAnnotation prAnnotation = GetPhaseRangeAnnotation();
        BoundsAlignment alignment = ParseValue<BoundsAlignment>(prCaptionAlignmentDropDown.SelectedValue);

        prAnnotation.CaptionAlignment = new AnnotationCaptionAlignment(alignment, (float)prCaptionRealOffsetNumericEdit.Value, (float)prCaptionImaginaryOffsetNumericEdit.Value);
    }

    private void SetMaxCaptionAlignment()
    {
        ComplexPointAnnotation maxAnnotation = GetMaxAnnotation();
        BoundsAlignment alignment = ParseValue<BoundsAlignment>(maxCaptionAlignmentDropDown.SelectedValue);

        maxAnnotation.CaptionAlignment = new AnnotationCaptionAlignment(alignment, (float)maxCaptionRealOffsetNumericEdit.Value, (float)maxCaptionImaginaryOffsetNumericEdit.Value);
    }

    private void SetMinCaptionAlignment()
    {
        ComplexPointAnnotation minAnnotation = GetMinAnnotation();
        BoundsAlignment alignment = ParseValue<BoundsAlignment>(minCaptionAlignmentDropDown.SelectedValue);

        minAnnotation.CaptionAlignment = new AnnotationCaptionAlignment(alignment, (float)minCaptionRealOffsetNumericEdit.Value, (float)minCaptionImaginaryOffsetNumericEdit.Value);
    }

    protected void circleCaptionAlignmentDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetCircleCaptionAlignment();
    }

    protected void circleCaptionRealOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetCircleCaptionAlignment();
    }

    protected void circleCaptionImaginaryOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetCircleCaptionAlignment();
    }

    protected void prCaptionAlignmentDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetPhaseRangeCaptionAlignment();
    }

    protected void prCaptionRealOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetPhaseRangeCaptionAlignment();
    }

    protected void prCaptionImaginaryOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetPhaseRangeCaptionAlignment();
    }

    protected void maxCaptionAlignmentDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetMaxCaptionAlignment();
    }

    protected void maxCaptionRealOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxCaptionAlignment();
    }

    protected void maxCaptionImaginaryOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxCaptionAlignment();
    }

    protected void minCaptionAlignmentDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetMinCaptionAlignment();
    }

    protected void minCaptionRealOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinCaptionAlignment();
    }

    protected void minCaptionImaginaryOffsetNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinCaptionAlignment();
    }


    protected void circleArrowVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        MagnitudeCircleAnnotation circleAnnotation = GetCircleAnnotation();
        circleAnnotation.ArrowVisible = circleArrowVisibleCheckBox.Checked;
    }

    protected void circleCaptionVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        MagnitudeCircleAnnotation circleAnnotation = GetCircleAnnotation();
        circleAnnotation.CaptionVisible = circleCaptionVisibleCheckBox.Checked;
    }

    protected void maxShapeVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        ComplexPointAnnotation maxAnnotation = GetMaxAnnotation();
        maxAnnotation.ShapeVisible = maxShapeVisibleCheckBox.Checked;
    }

    protected void minShapeVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        ComplexPointAnnotation minAnnotation = GetMinAnnotation();
        minAnnotation.ShapeVisible = minShapeVisibleCheckBox.Checked;
    }


    protected void circleCaptionTextBox_TextChanged(object sender, EventArgs e)
    {
        MagnitudeCircleAnnotation circleAnnotation = GetCircleAnnotation();
        circleAnnotation.Caption = circleCaptionTextBox.Text;
    }

    protected void circleMagnitudeNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        MagnitudeCircleAnnotation circleAnnotation = GetCircleAnnotation();
        circleAnnotation.Magnitude = circleMagnitudeNumericEdit.Value;
    }

    protected void prStartMagnitudeNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        MagnitudePhaseRangeAnnotation prAnnotation = GetPhaseRangeAnnotation();
        prAnnotation.StartMagnitude = prStartMagnitudeNumericEdit.Value;
    }

    protected void prMagnitudeNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        MagnitudePhaseRangeAnnotation prAnnotation = GetPhaseRangeAnnotation();
        prAnnotation.Magnitude = prMagnitudeNumericEdit.Value;
    }


    private void SetPhaseRange()
    {
        MagnitudePhaseRangeAnnotation prAnnotation = GetPhaseRangeAnnotation();
        prAnnotation.Phase = new Arc((float)prPhaseStartNumericEdit.Value, (float)prPhaseRangeNumericEdit.Value);
    }

    protected void prPhaseStartNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetPhaseRange();
    }

    protected void prPhaseRangeNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetPhaseRange();
    }


    private void SetMaxShapeSize()
    {
        ComplexPointAnnotation maxAnnotation = GetMaxAnnotation();
        maxAnnotation.ShapeSize = new Size((int)maxShapeWidthNumericEdit.Value, (int)maxShapeHeightNumericEdit.Value);
    }

    private void SetMinShapeSize()
    {
        ComplexPointAnnotation minAnnotation = GetMinAnnotation();
        minAnnotation.ShapeSize = new Size((int)minShapeWidthNumericEdit.Value, (int)minShapeHeightNumericEdit.Value);
    }

    protected void maxShapeWidthNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxShapeSize();
    }

    protected void maxShapeHeightNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxShapeSize();
    }

    protected void minShapeWidthNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinShapeSize();
    }

    protected void minShapeHeightNumericEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinShapeSize();
    }
}
