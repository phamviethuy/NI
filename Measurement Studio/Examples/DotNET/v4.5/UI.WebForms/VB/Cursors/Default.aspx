<%@ Page Language="VB" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.vb" Inherits="DefaultAspx" Title="Measurement Studio ASP.NET Cursors Example" %>

<asp:Content ID="Content1" Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <!-- The hidden submit button is so Firefox does not execute the other submit buttons click events below.-->
    <input type="submit" style="visibility:hidden;display:none;" />
    <table width="600" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="graph" Caption="Graph Cursors Demo" Width="600" Height="325">
                    <XAxes>
                        <ni:XAxis />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis Mode="Fixed" Range="-1.5, 1.5" />
                    </YAxes>
                    <Plots>
                        <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" LineColor="Red" LineWidth="2" DataStateManagement="SessionState"/>
                    </Plots>
                    <Cursors>
                        <ni:XYCursor Plot="Plots[0]" Color="White" LabelVisible="true" />
                    </Cursors>
                </ni:WaveformGraph>
            </td>
        </tr>
        
        <tr>
            <td>
                <table width="100%" cellspacing="0" cellpadding="0" border="0">
                    <tr>
                        <td>
                            <asp:Button ID="Button1" Runat="server" Text="&laquo; Move Previous" ToolTip="Move the cursor to the previous point in the plot." Width="125" OnClick="OnMovePreviousClick" />
                        </td>
                        <td align="right">
                            <asp:Button ID="Button2" Runat="server" Text="Move Next &raquo;" Width="125" ToolTip="Move the cursor to the next point in the plot." OnClick="OnMoveNextClick" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        
        <tr>
            <td>
                <table cellspacing="0" cellpadding="2" border="0">
                    <tr valign="top">
                        <td>
                            <table cellspacing="0" cellpadding="2" border="0">
                                <tr valign="middle">
                                    <td align="left">
                                        X Position:
                                    </td>
                                    <td align="left">
                                        <ni:NumericEdit Runat="server" FormatMode="SimpleDouble: 3" ID="xPosition" Width="60" AutoPostBack="true" OnAfterChangeValue="OnXPositionAfterChangeValue" />
                                    </td>
                                </tr>

                                <tr valign="middle">
                                    <td>
                                        Y Position:
                                    </td>
                                    <td>
                                        <ni:NumericEdit Runat="server" ID="yPosition" FormatMode="SimpleDouble: 3" Width="60" AutoPostBack="true" OnAfterChangeValue="OnYPositionAfterChangeValue" />
                                    </td>
                                </tr>

                                <tr valign="middle">
                                    <td>
                                        Current Index:
                                    </td>
                                    <td>
                                        <ni:NumericEdit Runat="server" ID="currentIndex" FormatMode="SimpleDouble: 0" Width="60" CoercionMode="ToInterval" AutoPostBack="true" OnAfterChangeValue="OnCurrentIndexAfterChangeValue" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                        
                        <td style="width:35px;">&nbsp;</td>
                        
                        <td>
                            <asp:CheckBox ID="labelVisible" Runat="server" Checked="true" Text="Label Visible" AutoPostBack="true" OnCheckedChanged="OnLabelVisibleCheckedChanged" /><br />
                            <asp:CheckBox ID="snapToPlot" Runat="server" Checked="true" Text="Snap To Plot" AutoPostBack="true" OnCheckedChanged="OnSnapToPlotCheckedChanged" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>