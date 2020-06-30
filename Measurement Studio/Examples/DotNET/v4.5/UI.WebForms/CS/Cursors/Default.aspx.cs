
using NationalInstruments.UI;
using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int NumerSamples = 100;
    private const float Frequency = 1;

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!IsPostBack)
        {
            graph.PlotY(GenerateData(0));
        }
    }

    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);

        xPosition.AfterChangeValue -= OnXPositionAfterChangeValue;
        yPosition.AfterChangeValue -= OnYPositionAfterChangeValue;

        XYCursor cursor = graph.Cursors[0];
        xPosition.Value = cursor.XPosition;
        yPosition.Value = cursor.YPosition;
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

    protected void OnXPositionAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        UpdatePosition();
    }

    protected void OnYPositionAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        UpdatePosition();
    }

    protected void OnCurrentIndexAfterChangeValue(object sender, AfterChangeNumericValueEventArgs e)
    {
        int index = (int)currentIndex.Value;
        XYCursor cursor = graph.Cursors[0];

        if ((index >= 0) && (index < cursor.Plot.HistoryCount))
            cursor.MoveCursor(index);
    }

    private void UpdatePosition()
    {
        graph.Cursors[0].MoveCursor(xPosition.Value, yPosition.Value);
    }

    private static double[] GenerateData(double phase)
    {
        double[] data = new double[NumerSamples];
        Random rand = new Random();

        for (int x = 0; x < data.Length; x++)
        {
            double angle = ((x * (2 * Math.PI) * Frequency) / (data.Length - 1)) + phase;
            data[x] = Math.Sin(angle) + (rand.NextDouble() / 5);
        }

        return data;
    }
}
