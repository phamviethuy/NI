using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void AutoRefresh1_Refresh(object sender, NationalInstruments.UI.RefreshEventArgs e)
    {
        WaveformGraph1.PlotY((double[])NetworkVariableDataSource1.Bindings[0].GetValue());
        Tank1.Value = (double)NetworkVariableDataSource1.Bindings[1].GetValue();
    }
}
