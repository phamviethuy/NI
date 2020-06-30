<%@ Page Language="VB" MasterPageFile="~/Examples.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="DefaultAspx" Title="Measurement Studio ASP.NET Charting Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
 <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="graph" Caption="Graph Charting Example" Width="600" Height="325">
                    <XAxes>
                        <ni:XAxis MajorDivisions-GridVisible="true" />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis MajorDivisions-GridVisible="true" />
                    </YAxes>
                    <Plots>
                        <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" LineWidth="2" DataStateManagement="SessionState"/>
                    </Plots>
                </ni:WaveformGraph>
            </td>
        </tr>
        
        <tr>
            <td>
                <fieldset>
                    <legend>Charting Settings</legend>
                    <table cellspacing="0" cellpadding="2" border="0">
                        <tr valign="top">
                            <td align="center">
                                On<br />
                                <ni:Switch ID="enabled" Runat="server" SwitchStyle="VerticalToggle" Width="50" Height="100" OnStateChanged="OnEnabledStateChanged"/><br />
                                Off
                            </td>
                            
                            <td style="width:50px;">&nbsp;</td>
                            
                            <td valign="middle">
                                <table cellspacing="0" cellpadding="2" border="0">
                                    <tr>
                                        <td style="width:125px;">Charting Mode:</td>
                                        <td>
                                            <asp:DropDownList ID="chartingMode" Runat="server" Width="150" AutoPostBack="true" OnSelectedIndexChanged="OnChartingModeSelectedIndexChanged">
                                                <asp:ListItem Value="StripChart" Selected="true">Strip Chart</asp:ListItem>
                                                <asp:ListItem Value="ScopeChart">Scope Chart</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    
                                    <tr>
                                        <td style="width:125px;">Refresh Interval:</td>
                                        <td>
                                            <asp:DropDownList ID="refreshInterval" Runat="server" Width="150" AutoPostBack="true" OnSelectedIndexChanged="OnRefreshIntervalSelectedIndexChanged">
                                                <asp:ListItem  Value="0.5">Every 1/2 second</asp:ListItem>
                                                <asp:ListItem  Value="1.0" Selected="true">Every second</asp:ListItem>
                                                <asp:ListItem  Value="1.5">Every 1 1/2 second</asp:ListItem>
                                                <asp:ListItem  Value="2.0">Every 2 seconds</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                            
                            <td style="width:50px;">&nbsp;</td>
                            
                            <td align="center">
                                Chart Vertically<br />
                                <ni:Switch ID="chartVertically" Runat="server" SwitchStyle="VerticalToggle" Width="50" Height="100" OnStateChanged="OnChartVerticallyStateChanged"/><br />
                                Chart Horizontally
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>
    
    <ni:AutoRefresh ID="refresh" Runat="server" OnRefresh="OnRefresh">
        <DefaultRefreshItems>
            <ni:RefreshItem ItemID="graph" />
        </DefaultRefreshItems>
    </ni:AutoRefresh>
</asp:Content>
