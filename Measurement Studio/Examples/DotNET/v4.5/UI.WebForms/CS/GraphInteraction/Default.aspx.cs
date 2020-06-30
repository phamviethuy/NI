
using NationalInstruments;
using NationalInstruments.UI;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);

        if (!IsPostBack)
        {
            graph.PlotY(GenerateData(1000));
        }
    }

    protected void OnInteractionModeCheckedChanged(object sender, EventArgs e)
    {
        GraphWebInteractionModes interactionMode = GraphWebInteractionModes.None;

        if (editRange.Checked)
            interactionMode |= GraphWebInteractionModes.EditRange;

        if (zoomX.Checked)
            interactionMode |= GraphWebInteractionModes.ZoomX;

        if (zoomY.Checked)
            interactionMode |= GraphWebInteractionModes.ZoomY;

        if (zoomAroundPoint.Checked)
            interactionMode |= GraphWebInteractionModes.ZoomAroundPoint;

        graph.InteractionMode = interactionMode;
    }

    private static double[] GenerateData(int dataLength)
    {
        if (dataLength < 0)
            throw new ArgumentOutOfRangeException("dataLength", dataLength, "Data length must be positive.");

        double[] data = new double[dataLength];
        Random rnd = new Random();

        for (int i = 0; i < dataLength; ++i)
            data[i] = (rnd.NextDouble() * Math.Sin(i / 3.15));

        return data;
    }
}
