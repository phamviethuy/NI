
using NationalInstruments;
using NationalInstruments.UI;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int DataLength = 101;
    private const float Frequency = 1;
    private const double Phase = 0;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!IsPostBack)
        {
            graph.PlotComplex(GenerateData(DataLength, Phase));
        }
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        realPosition.AfterChangeValue -= OnRealPositionAfterChangeValue;
        imaginaryPosition.AfterChangeValue -= OnImaginaryPositionAfterChangeValue;

        ComplexCursor cursor = graph.Cursors[0];
        realPosition.Value = cursor.Position.Real;
        imaginaryPosition.Value = cursor.Position.Imaginary;
        currentIndex.Value = cursor.GetCurrentIndex();
    }

    protected void OnMovePreviousClick(object sender, EventArgs e)
    {
        graph.Cursors[0].MovePrevious();
    }

    protected void OnMoveNextClick(object sender, EventArgs e)
    {
        graph.Cursors[0].MoveNext();
    }

    protected void OnLabelVisibleCheckedChanged(object sender, EventArgs e)
    {
        graph.Cursors[0].LabelVisible = labelVisible.Checked;
    }

    protected void OnSnapToPlotCheckedChanged(object sender, EventArgs e)
    {
        graph.Cursors[0].SnapMode = snapToPlot.Checked ? CursorSnapMode.ToPlot : CursorSnapMode.Floating;
    }

    protected void OnRealPositionAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        UpdatePosition();
    }

    protected void OnImaginaryPositionAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        UpdatePosition();
    }

    protected void OnCurrentIndexAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        int index = (int)currentIndex.Value;
        ComplexCursor cursor = graph.Cursors[0];

        if ((index >= 0) && (index < cursor.Plot.HistoryCount))
            cursor.MoveCursor(index);
    }

    private void UpdatePosition()
    {
        graph.Cursors[0].MoveCursor(new ComplexDouble(realPosition.Value, imaginaryPosition.Value));
    }

    private static ComplexDouble[] GenerateData(int length, double phase)
    {
        int halfLength = length / 2;
        double[] indices = new double[length];
        double[] data = new double[length];
        Random rand = new Random();

        for (int x = 0; x < length; x++)
        {
            double angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase;
            data[x] = Math.Sin(angle) + (rand.NextDouble() / 5);
            indices[x] = x - halfLength;
        }

        return ComplexDouble.ComposeArray(indices, data);
    }
}
