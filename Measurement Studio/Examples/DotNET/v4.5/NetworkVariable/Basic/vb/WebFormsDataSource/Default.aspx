<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ni:NetworkVariableDataSource id="NetworkVariableDataSource1" runat="server">
            <Bindings>
                <ni:NetworkVariableBinding DefaultReadValue="0" Location="\\localhost\system\doublearray"
                    Name="Data" />
                <ni:NetworkVariableBinding BindingType="Double" DefaultReadValue="0" Location="\\localhost\system\double"
                    Name="Amplitude" />
            </Bindings>
        </ni:NetworkVariableDataSource><br />
        <ni:Tank ID="Tank1" runat="server">
        </ni:Tank>&nbsp;
        <ni:WaveformGraph ID="WaveformGraph1" runat="server">
            <XAxes>
                <ni:XAxis>
                </ni:XAxis>
            </XAxes>
            <Plots>
                <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" />
            </Plots>
            <YAxes>
                <ni:YAxis>
                </ni:YAxis>
            </YAxes>
        </ni:WaveformGraph>
        <ni:AutoRefresh id="AutoRefresh1" runat="server" Enabled="True" Interval="00:00:01.000">
            <defaultrefreshitems>
<ni:RefreshItem ItemID="Tank1"></ni:RefreshItem>
<ni:RefreshItem ItemID="WaveformGraph1"></ni:RefreshItem>
</defaultrefreshitems>
        </ni:AutoRefresh></div>
    </form>
</body>
</html>
