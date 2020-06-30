<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Special Values Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <table width="100%">
        <tr>
        <td>
            <ni:WaveformGraph ID="waveformGraph" Runat="server" Width="600" Height="300" CaptionPosition="Bottom" UseColorGenerator = "true">
                <YAxes>
                    <ni:YAxis Range="-5, 15" Mode="Fixed">
                    </ni:YAxis>
                </YAxes>
                <Plots>
                    <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" PointStyle="EmptyCircle" ProcessSpecialValues="True">
                    </ni:WaveformPlot>
                    <ni:WaveformPlot PointStyle="EmptyCircle" XAxis="XAxes[0]" YAxis="YAxes[0]" ProcessSpecialValues="True">
                    </ni:WaveformPlot>
                </Plots>
                <XAxes>
                    <ni:XAxis Range="0, 60" Mode="Fixed">
                    </ni:XAxis>
                </XAxes>
            </ni:WaveformGraph>
        </td>
        </tr>
        
        <tr>
        <td>
            <ni:Legend ID="legend" Runat="server" Width="150" Height="60" ItemSize="52, 40"
                CaptionVisible="False" VerticalScrollMode="Auto" ItemLayoutMode="LeftToRight" Border="Solid">
                <Items>
                    <ni:LegendItem Source="waveformGraph, Plots[0]" Text="NaN" OnBeforeDraw="OnLegendItemNanBeforeDraw">
                    </ni:LegendItem>
                    <ni:LegendItem Source="waveformGraph, Plots[1]" Text="+/- Infinity" OnBeforeDraw="OnLegendItemInfinityBeforeDraw">
                    </ni:LegendItem>
                </Items>
            </ni:Legend>
        </td>
        </tr>
        
        <tr>
        <td>
        The green plot contains NaN values every 7 points.  The red plot contains +/- infinity values every 10 points. Legend scrolling works only with IE5+ on Windows.
        </td>
        </tr>
    </table>
</asp:Content>