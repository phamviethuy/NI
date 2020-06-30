<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET XY Graph Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td colspan="2">
                <ni:ScatterGraph Runat="server" ID="xyDataGraph" Width="600" Height="225" Caption="XY Plot">
                    <XAxes>
                        <ni:XAxis />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis />
                    </YAxes>
                    <Plots>
                        <ni:ScatterPlot XAxis="XAxes[0]" YAxis="YAxes[0]" />
                    </Plots>
                </ni:ScatterGraph>
            </td>
        </tr>
        
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="xDataGraph" Width="300" Height="200" Caption="X Data">
                    <XAxes>
                        <ni:XAxis />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis />
                    </YAxes>
                    <Plots>
                        <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" />
                    </Plots>
                </ni:WaveformGraph>
            </td>
            
            <td>
                <ni:WaveformGraph Runat="server" ID="yDataGraph" Width="300" Height="200" Caption="Y Data">
                    <XAxes>
                        <ni:XAxis />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis />
                    </YAxes>
                    <Plots>
                        <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" />
                    </Plots>
                </ni:WaveformGraph>
            </td>
        </tr>
        
        <tr>
            <td colspan="2">
                <hr width="90%" />
            </td>
        </tr>
        
        <tr>
            <td colspan="2" align="center">
                <asp:Button ID="btnPlotCircle" Runat="server" Width="125" Text="Plot Circle" OnClick="OnPlotCircleButtonClick"/>
                &nbsp;
                <asp:Button ID="btnPlotOctagon" Runat="server" Width="125" Text="Plot Octagon" OnClick="OnPlotOctagonButtonClick"/>
                &nbsp;
                <asp:Button ID="btnPlotPolar" Runat="server" Width="125" Text="Plot Polar" OnClick="OnPlotPolarButtonClick"/>
                &nbsp;
                <asp:Button ID="btnPlotSpiral" Runat="server" Width="125" Text="Plot Spiral" OnClick="OnPlotSpiralButtonClick"/>
            </td>
        </tr>
    </table>
</asp:Content>
