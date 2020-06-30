<%@ Page Language="VB" MasterPageFile="~/Examples.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="DefaultAspx" Title="Measurement Studio ASP.NET UpdatePanel and Timer Example" %>

<asp:Content ID="Content1" Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <asp:ScriptManager ID="scriptManager" runat="server">
    </asp:ScriptManager>
    <asp:Timer ID="timer" runat="server" Interval="750" ontick="Timer_Tick" Enabled="False">
    </asp:Timer>
    <asp:UpdatePanel ID="updatePanel" runat="server" UpdateMode="Conditional">
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="timer" EventName="Tick" />
        </Triggers>
        <ContentTemplate>
            <table width="100%" cellspacing="0" cellpadding="2" border="0">
                    <tr>
                        <td>
                            <ni:WaveformGraph Runat="server" ID="graph" Caption="Update Panel and Timer Example" Width="535" Height="250">
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
                            <ni:Slide ID="currentValueID" Runat="server" Width="65" Height="250" ScalePosition="Right" InteractionMode="Indicator" Range="-10, 10"/>
                        </td>
                    </tr>
            </table>        
            <table width="100%" cellspacing="0" cellpadding="2" border="0">        
                    <tr>
                        <td>
                            <ni:Meter ID="minimumValueID" Width="200" Height="125" Runat="server" CaptionPosition="Bottom" Caption="Minimum" CaptionBackColor="White" CaptionForeColor="Black" Range="-10, 10"/>
                        </td>
                        <td>    
                            <ni:Meter ID="averageValueID" Width="200" Height="125" Runat="server" CaptionPosition="Bottom" Caption="Average" CaptionBackColor="White" CaptionForeColor="Black" Range="-10, 10"/>
                        </td>
                        <td>    
                            <ni:Meter ID="maximumValueID" Width="200" Height="125" Runat="server" CaptionPosition="Bottom" Caption="Maximum" CaptionBackColor="White" CaptionForeColor="Black" Range="-10, 10"/>
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
          </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
