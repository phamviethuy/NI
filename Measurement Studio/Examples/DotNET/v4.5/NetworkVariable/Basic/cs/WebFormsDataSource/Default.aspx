<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ni:NetworkVariableDataSource ID="NetworkVariableDataSource1" runat="server">
            <Bindings>
                <ni:NetworkVariableBinding DefaultReadValue="0" Location="\\localhost\system\doublearray"
                    Name="Data" />
                <ni:NetworkVariableBinding BindingType="Double" DefaultReadValue="0" Location="\\localhost\system\double"
                    Name="Amplitude" />
            </Bindings>
        </ni:NetworkVariableDataSource>
        <ni:Tank id="Tank1" runat="server">
        </ni:Tank>
        <ni:WaveformGraph id="WaveformGraph1" runat="server">
            <xaxes>
<ni:XAxis></ni:XAxis>
</xaxes>
            <plots>
<ni:WaveformPlot YAxis="YAxes[0]" XAxis="XAxes[0]"></ni:WaveformPlot>
</plots>
            <yaxes>
<ni:YAxis></ni:YAxis>
</yaxes>
        </ni:WaveformGraph></div>
        <ni:AutoRefresh ID="AutoRefresh1" runat="server" Enabled="True" Interval="00:00:01.000" OnRefresh="AutoRefresh1_Refresh">
            <DefaultRefreshItems>
                <ni:RefreshItem ItemID="WaveformGraph1" />
                <ni:RefreshItem ItemID="Tank1" />
            </DefaultRefreshItems>
        </ni:AutoRefresh>
    </form>
</body>
</html>
