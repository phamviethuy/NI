<%@ Page Language="vb" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.vb" Inherits="DefaultAspx" Title="Measurement Studio ASP.NET Axes Example" %>

<asp:Content ID="Content1" Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="customWaveformGraph" Caption="National Instruments 2D Graph" Width="600" Height="300">
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
                    <legend>Settings</legend>
                    <center>
                        <table cellspacing="0" cellpadding="2">
                            <tr>
                                <td>
                                    Border Style:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="borderStyleDropDownList" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="borderStyle_SelectedIndexChanged">
                                            <asp:ListItem Selected="true">None</asp:ListItem>
                                            <asp:ListItem>Raised</asp:ListItem>
                                            <asp:ListItem>Custom</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Line Style:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="lineStyleDropDownList" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="lineStyle_SelectedIndexChanged">
                                            <asp:ListItem>None</asp:ListItem>
                                            <asp:ListItem Selected="true">Solid</asp:ListItem>
                                            <asp:ListItem>Custom</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>                        
                            <tr>
                                <td>
                                    Point Style:
                                </td>
                                <td align="left">
                                    <asp:DropDownList ID="pointStyleDropDownList" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="pointStyle_SelectedIndexChanged">
                                            <asp:ListItem Selected="true">None</asp:ListItem>
                                            <asp:ListItem>Empty Square</asp:ListItem>
                                            <asp:ListItem>Custom</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    Large Points:
                                </td>
                                <td align="left">
                                    <asp:CheckBox ID="largePointsCheckBox" Enabled="false" AutoPostBack="True" Runat="Server" OnCheckedChanged="pointSize_CheckedChanged"/>
                                </td>
                            </tr>
                        </table>
                    </center>
                </fieldset>
            </td>
        </tr>
    </table>
</asp:Content>
