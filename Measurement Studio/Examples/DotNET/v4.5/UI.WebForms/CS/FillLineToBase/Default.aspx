<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Fill/Line-To-Base Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
<table cellpadding="5">
        <tr>
        <td colspan="4">
        <ni:WaveformGraph ID="WaveformGraph1" Runat="server" Height="325px" Width="600px" Caption="Fill/Line-To-Base Example">
            <YAxes>
                <ni:YAxis>
                </ni:YAxis>
            </YAxes>
            <Plots>
                <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" LineColor="BurlyWood" FillMode="FillAndBins" LineStep="CenteredXYStep">
                </ni:WaveformPlot>
                <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" LineColor="Yellow">
                </ni:WaveformPlot>
            </Plots>
            <XAxes>
                <ni:XAxis>
                </ni:XAxis>
            </XAxes>
        </ni:WaveformGraph>
        </td>
        </tr>
        <tr>
        <td>FillColor</td>
        <td> <asp:DropDownList ID="fillColorDropDown" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="fillColorDropDown_SelectedIndexChanged">
                <asp:ListItem>BurlyWood</asp:ListItem>
                <asp:ListItem Selected="true">FireBrick</asp:ListItem>
                <asp:ListItem>SpringGreen</asp:ListItem>
                <asp:ListItem>DodgerBlue</asp:ListItem>
                <asp:ListItem>Gray</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
                <asp:ListItem>Turquoise</asp:ListItem>
                <asp:ListItem>Teal</asp:ListItem>
        </asp:DropDownList></td>
        <td>LineColor</td>
        <td><asp:DropDownList ID="lineColorDropDown" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="lineColorDropDown_SelectedIndexChanged">
                <asp:ListItem Selected="true">BurlyWood</asp:ListItem>
                <asp:ListItem>FireBrick</asp:ListItem>
                <asp:ListItem>SpringGreen</asp:ListItem>
                <asp:ListItem>DodgerBlue</asp:ListItem>
                <asp:ListItem>Gray</asp:ListItem>
                <asp:ListItem>White</asp:ListItem>
                <asp:ListItem>Turquoise</asp:ListItem>
                <asp:ListItem>Teal</asp:ListItem>
        </asp:DropDownList></td>
        </tr>
        <tr>
        <td>FillStyle</td>
        <td><asp:DropDownList ID="fillStyleDropDown" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="fillStyleDropDown_SelectedIndexChanged">
                <asp:ListItem>DiagonalBrick</asp:ListItem>
                <asp:ListItem>Divot</asp:ListItem>
                <asp:ListItem>HorizontalBrick</asp:ListItem>
                <asp:ListItem>HorizontalGradient</asp:ListItem>
                <asp:ListItem>None</asp:ListItem>
                <asp:ListItem>Shingle</asp:ListItem>
                <asp:ListItem Selected="True">Solid</asp:ListItem>
                <asp:ListItem>VerticalGradient</asp:ListItem>
                <asp:ListItem>Wave</asp:ListItem>
                <asp:ListItem>ZigZag</asp:ListItem>
        </asp:DropDownList></td>
        <td>LineStyle</td>
        <td><asp:DropDownList ID="lineStyleDropDown" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="lineStyleDropDown_SelectedIndexChanged">
          <asp:ListItem>Dash</asp:ListItem>
            <asp:ListItem>DashDot</asp:ListItem>
            <asp:ListItem>DashDotDot</asp:ListItem>
            <asp:ListItem>Dot</asp:ListItem>
            <asp:ListItem>None</asp:ListItem>
            <asp:ListItem Selected="True">Solid</asp:ListItem>
        </asp:DropDownList></td>
        </tr>
        <tr>
        <td>
        FillMode
        </td>
        <td> <asp:DropDownList ID="fillModeDropDown" Runat="server" Height="22px" Width="134px" AutoPostBack="True" OnSelectedIndexChanged="fillModeDropDown_SelectedIndexChanged">
        <asp:ListItem>None</asp:ListItem>
             <asp:ListItem>Fill</asp:ListItem>
             <asp:ListItem>Lines</asp:ListItem>
             <asp:ListItem>FillAndLines</asp:ListItem>
             <asp:ListItem>Bins</asp:ListItem>
             <asp:ListItem Selected="True">FillAndBins</asp:ListItem>
        </asp:DropDownList></td>
        <td>BaseValue</td>
        <td>
        <asp:DropDownList ID="baseValueDropDown" Runat="server" Height="22px" Width="134px" AutoPostBack="True">
            <asp:ListItem Selected="True">0</asp:ListItem>
            <asp:ListItem>.5</asp:ListItem>
            <asp:ListItem>-.5</asp:ListItem>
            <asp:ListItem>Plot</asp:ListItem>
        </asp:DropDownList></td>
        </tr>
        </table>
</asp:Content>