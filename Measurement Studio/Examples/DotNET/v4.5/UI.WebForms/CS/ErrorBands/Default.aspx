<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Axes Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="waveformGraph" Caption="Error Bands Example" Width="600px" Height="300px">
                    <XAxes>
                        <ni:XAxis />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis />
                    </YAxes>
                    <Plots>
                        <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" DataStateManagement="SessionState"/>
                    </Plots>
                </ni:WaveformGraph>
            </td>
        </tr>
        <tr>
            <td align="center">
                <fieldset>
                    <legend>Error Bands Settings</legend>
                    <center>
                        <table cellspacing="0" cellpadding="2">
                            <tr>
                                <td align="right">
                                    Error Mode:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="errorModeDropDownList" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="errorMode_SelectedIndexChanged">
                                            <asp:ListItem>None</asp:ListItem>
                                            <asp:ListItem>Constant (+6, -3)</asp:ListItem>
                                            <asp:ListItem Selected="True">Percent (+/-5%)</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
                                    Example Data:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="exampleDataDropDownList" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="exampleData_SelectedIndexChanged">
                                            <asp:ListItem Selected="True">Static</asp:ListItem>
                                            <asp:ListItem>Plotted</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>                        
                        </table>
                    </center>
                </fieldset>
                <ni:AutoRefresh ID="refresh" runat="server" Interval="00:00:00.750" OnRefresh="OnRefresh">
                    <DefaultRefreshItems>
                        <ni:RefreshItem ItemID="waveformGraph" />
                    </DefaultRefreshItems>
                </ni:AutoRefresh>
            </td>
        </tr>
    </table>
</asp:Content>
