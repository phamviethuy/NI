<%@ Page Language="VB" MasterPageFile="~/Examples.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="DefaultAspx" Title="Measurement Studio ASP.NET Complex Waveform Plotting Example" %>

<asp:Content ID="Content1" Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td colspan="2">
                <ni:WaveformGraph Runat="server" ID="xyDataGraph" Width="600" Height="225" Caption="Complex Waveform Plotting Example" >
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
                <asp:Button ID="btnPlotReal" Runat="server" Width="125" Text="Plot Real" OnClick="OnPlotRealButtonClick"/>
                &nbsp;
                <asp:Button ID="btnPlotImaginary" Runat="server" Width="125" Text="Plot Imaginary" OnClick="OnPlotImaginaryButtonClick"/>
                &nbsp;
                <asp:Button ID="btnPlotPhase" Runat="server" Width="125" Text="Plot Phase" OnClick="OnPlotPhaseButtonClick"/>
                &nbsp;
                <asp:Button ID="btnPlotMagnitude" Runat="server" Width="125" Text="Plot Magnitude" OnClick="OnPlotMagnitudeButtonClick"/>
            </td>
        </tr>
    </table>
</asp:Content>
