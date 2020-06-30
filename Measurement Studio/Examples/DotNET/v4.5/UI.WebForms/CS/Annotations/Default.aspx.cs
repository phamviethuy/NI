
using NationalInstruments;
using NationalInstruments.UI;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int NumerSamples = 100;
    private const float Frequency = 1;

    private double[] GenerateData(double phase)
    {
        double[] data = new double[NumerSamples];
        double angle;
        Random rand = new Random();

        for (int x = 0; x < data.Length; x++)
        {
            angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase;
            data[x] = Math.Sin(angle) + (rand.NextDouble() / 5);
        }

        return data;
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        if (!IsPostBack)
        {
            double[] data = GenerateData(0);
            WaveformGraph1.PlotY(data);
            XYPointAnnotation minAnnotation = GetMinAnnotation();
            XYPointAnnotation maxAnnotation = GetMaxAnnotation();
            Color shapeColor = Color.FromArgb(150, Color.Lime);
            minAnnotation.ShapeFillColor = shapeColor;
            maxAnnotation.ShapeFillColor = shapeColor;

            int minIndex, maxIndex;
            GetMaxMin(data, out minIndex, out maxIndex);

            minAnnotation.XPosition = minIndex;
            minAnnotation.YPosition = data[minIndex];

            maxAnnotation.XPosition = maxIndex;
            maxAnnotation.YPosition = data[maxIndex];
        }
    }

    private TValue ParseValue<TValue>(string value)
    {
        TypeConverter converter = TypeDescriptor.GetConverter(typeof(TValue));
        return (TValue)converter.ConvertFromInvariantString(value);
    }

    private XYPointAnnotation GetMinAnnotation()
    {
        XYPointAnnotation minAnnotation = WaveformGraph1.Annotations[2] as XYPointAnnotation;
        return minAnnotation;
    }

    private XYPointAnnotation GetMaxAnnotation()
    {
        XYPointAnnotation maxAnnotation = WaveformGraph1.Annotations[3] as XYPointAnnotation;
        return maxAnnotation;
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

    protected void maxArrowHeadDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        XYPointAnnotation maxAnnotation = GetMaxAnnotation();
        maxAnnotation.ArrowHeadStyle = ParseValue<ArrowStyle>(maxArrowHeadDropDown.SelectedValue);
    }

    protected void minArrowHeadDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        XYPointAnnotation minAnnotation = GetMinAnnotation();
        minAnnotation.ArrowHeadStyle = ParseValue<ArrowStyle>(minArrowHeadDropDown.SelectedValue);
    }

    private void SetMaxCaptionAlignment()
    {
        XYPointAnnotation maxAnnotation = GetMaxAnnotation();
        BoundsAlignment alignment = ParseValue<BoundsAlignment>(maxCaptionAlignmentDropDown.SelectedValue);

        maxAnnotation.CaptionAlignment = new AnnotationCaptionAlignment(alignment, (float)maxCaptionXOffsetNumEdit.Value, (float)maxCaptionYOffsetNumEdit.Value);
    }

    private void SetMinCaptionAlignment()
    {
        XYPointAnnotation minAnnotation = GetMinAnnotation();
        BoundsAlignment alignment = ParseValue<BoundsAlignment>(minCaptionAlignmentDropDown.SelectedValue);

        minAnnotation.CaptionAlignment = new AnnotationCaptionAlignment(alignment, (float)minCaptionXOffsetNumEdit.Value, (float)minCaptionYOffsetNumEdit.Value);
    }

    protected void maxCaptionAlignmentDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetMaxCaptionAlignment();
    }

    protected void maxCaptionXOffsetNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxCaptionAlignment();
    }

    protected void maxCaptionYOffsetNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxCaptionAlignment();
    }

    protected void minCaptionAlignmentDropDown_SelectedIndexChanged(object sender, EventArgs e)
    {
        SetMinCaptionAlignment();
    }

    protected void minCaptionXOffsetNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinCaptionAlignment();
    }

    protected void minCaptionYOffsetNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinCaptionAlignment();
    }

    protected void maxShapeVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        XYPointAnnotation maxAnnotation = GetMaxAnnotation();
        maxAnnotation.ShapeVisible = maxShapeVisibleCheckBox.Checked;
    }

    protected void minShapeVisibleCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        XYPointAnnotation minAnnotation = GetMinAnnotation();
        minAnnotation.ShapeVisible = minShapeVisibleCheckBox.Checked;
    }

    private void SetMaxShapeSize()
    {
        XYPointAnnotation maxAnnotation = GetMaxAnnotation();
        maxAnnotation.ShapeSize = new Size((int)maxShapeWidthNumEdit.Value, (int)maxShapeHeightNumEdit.Value);
    }

    private void SetMinShapeSize()
    {
        XYPointAnnotation minAnnotation = GetMinAnnotation();
        minAnnotation.ShapeSize = new Size((int)minShapeWidthNumEdit.Value, (int)minShapeHeightNumEdit.Value);
    }

    protected void maxShapeWidthNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxShapeSize();
    }

    protected void maxShapeHeightNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMaxShapeSize();
    }

    protected void minShapeWidthNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinShapeSize();
    }

    protected void minShapeHeightNumEdit_AfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        SetMinShapeSize();
    }
}
