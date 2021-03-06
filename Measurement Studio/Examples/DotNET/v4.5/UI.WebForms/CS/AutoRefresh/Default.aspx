<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Auto Refresh Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="graph" Caption="Auto Refresh Example" Width="535" Height="250">
                    <XAxes>
                        <ni:XAxis Mode="StripChart" Range="0, 100" />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis Mode="Fixed" Range="-10, 10"/>
                    </YAxes>
                    <Plots>
                        <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" DataStateManagement="SessionState" HistoryCapacity="100"/>
                    </Plots>
                </ni:WaveformGraph>
            </td>
            <td>    
                <ni:Slide ID="currentValue" Runat="server" Width="65" Height="250" ScalePosition="Right" InteractionMode="Indicator" Range="-10, 10"/>
            </td>
        </tr>
    </table>    
    <table width="100%" cellspacing="0" cellpadding="2" border="0">    
        <tr>
            <td>
                <ni:Meter ID="minimumValue" Width="200" Height="125" Runat="server" CaptionPosition="Bottom" Caption="Minimum" CaptionBackColor="White" CaptionForeColor="Black" Range="-10, 10"/>
            </td>
            <td>    
                <ni:Meter ID="averageValue" Width="200" Height="125" Runat="server" CaptionPosition="Bottom" Caption="Average" CaptionBackColor="White" CaptionForeColor="Black" Range="-10, 10"/>
            </td>
            <td>        
                <ni:Meter ID="maximumValue" Width="200" Height="125" Runat="server" CaptionPosition="Bottom" Caption="Maximum" CaptionBackColor="White" CaptionForeColor="Black" Range="-10, 10"/>
            </td>
        </tr>
        
        <tr align="center">
            <td colspan="3">
                On
                <ni:Switch ID="enabled" Runat="server" Width="100" Height="50" SwitchStyle="HorizontalSlide" ImageAlign="Middle" OnStateChanged="OnEnabledStateChanged" />
                Off
            </td>
        </tr>
    </table>

    <ni:AutoRefresh ID="refresh" Runat="server" Interval="00:00:00.750" OnRefresh="OnRefresh">
        <DefaultRefreshItems>
            <ni:RefreshItem ItemID="graph" />
            <ni:RefreshItem ItemID="currentValue" />
        </DefaultRefreshItems>
    </ni:AutoRefresh>
</asp:Content>
