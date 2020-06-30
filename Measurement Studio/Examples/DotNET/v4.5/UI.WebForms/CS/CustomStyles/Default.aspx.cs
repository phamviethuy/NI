
using NationalInstruments.UI;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : Page
{
    private const int DefaultDataLength = 100;
	private const int DefaultDataRange = 10;

	protected override void OnLoad(EventArgs e)
	{
        if (!IsPostBack)
		    waveformGraph.PlotY(GenerateData());
	}

    protected void lineStyle_SelectedIndexChanged(object sender, EventArgs e)
	{
        switch (lineStyleDropDownList.SelectedValue)
        {
            case "None":
                Plot.LineStyle = LineStyle.None;
                break;

            case "Solid":
                Plot.LineStyle = LineStyle.Solid;
                break;

            case "Custom":
                Plot.LineStyle = new CustomLineStyle();
                break;
        }
    }

    protected void pointStyle_SelectedIndexChanged(object sender, EventArgs e)
	{
		largePointsCheckBox.Enabled = (pointStyleDropDownList.SelectedValue != "None");

        switch (pointStyleDropDownList.SelectedValue)
        {
            case "None":
                Plot.PointStyle = PointStyle.None;
                break;

            case "Empty Square":
                Plot.PointStyle = PointStyle.EmptySquare;
                break;

            case "Custom":
                Plot.PointStyle = new CustomPointStyle();
                break;
        }
    }

    protected void borderStyle_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (borderStyleDropDownList.SelectedValue)
        {
            case "None":
                waveformGraph.Border = Border.None;
                break;

            case "Raised":
                waveformGraph.Border = Border.Raised;
                break;

            case "Custom":
                waveformGraph.Border = new CustomBorder();
                break;
        }
    }

    protected void pointSize_CheckedChanged(object sender, EventArgs e)
	{
        if (largePointsCheckBox.Checked)
            Plot.PointSize = new Size(8, 8);
        else
            Plot.PointSize = new Size(5, 5);
    }

    private XYPlot Plot
    {
        get
        {
            return waveformGraph.Plots[0];
        }
    }

    private static double[] GenerateSineWave(int xRange, int yRange)
	{
		if (xRange < 0)
		{
			throw new ArgumentOutOfRangeException("xRange");
		}

		if (yRange < 0)
		{
			throw new ArgumentOutOfRangeException("yRange");
		}

		double[] data = new double[xRange];
		for (int i = 0; i < xRange; ++i)
		{
			data[i] = yRange / 2 * (1 - (float)Math.Sin(i * 2 * Math.PI / (xRange - 1)));
		}

		return data;
	}
	
	private static double[] GenerateData()
	{
		return GenerateSineWave(DefaultDataLength, DefaultDataRange);
	}

    [Serializable]
	private class CustomLineStyle : LineStyle
	{
		public CustomLineStyle()
		{
		}

		public override bool IsContextDependent
		{
			get
			{
				return true;
			}
		}

		public override Pen CreatePen(object context, LineStyleDrawArgs args)
		{
			Rectangle bounds = args.ContextBounds;

			bounds.Width += 1;
			bounds.Height += 1;

			using (Brush brush = new LinearGradientBrush(bounds, Color.Red, Color.Blue, LinearGradientMode.Vertical))
			{
				return new Pen(brush, args.Width);
			}
		}
	}

    [Serializable]
	private class CustomPointStyle : PointStyle
	{
		public override void Draw(object context, PointStyleDrawArgs args)
		{
			if (args.Y < 3)
			{
				PointStyle.SolidSquare.Draw(context, CreateDrawArgs(args, Color.Red));
			}
			else if (args.Y < 7)
			{
				PointStyle.EmptySquare.Draw(context, CreateDrawArgs(args, Color.Yellow));
			}
			else
			{
				PointStyle.Plus.Draw(context, CreateDrawArgs(args, Color.LightBlue));
			}
		}

		public override bool IsValueDependent
		{
			get { return true; }
		}

		private PointStyleDrawArgs CreateDrawArgs(PointStyleDrawArgs args, Color color)
		{
			return new PointStyleDrawArgs(args.Graphics, args.X, args.Y, color, args.Size);
		}
	}

    [Serializable]
	private class CustomBorder : Border
	{
		public override void Draw(object context, BorderDrawArgs args)
		{
			Graphics g = args.Graphics;
			Rectangle bounds = args.Bounds;

			using (Pen pen = new Pen(Color.Blue))
			{
				Rectangle borderRectangle = new Rectangle(bounds.X + 1, bounds.Y + 1, bounds.X + bounds.Width - 2, bounds.Y + bounds.Height - 2);
				g.DrawRectangle(pen, borderRectangle);

				borderRectangle.Inflate(-2, -2);
				g.DrawRectangle(pen, borderRectangle);
			}
		}

		public override Rectangle GetInnerRectangle(Rectangle outerRectangle)
		{
			Rectangle innerRectangle = outerRectangle;
			innerRectangle.Inflate(-5, -5);

			return innerRectangle;
		}
	}
}
