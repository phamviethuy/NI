<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Cursors Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
   <!-- The hidden submit button is so Firefox does not execute the other submit buttons click events below.-->
   <input type="submit" style="visibility:hidden;display:none;" />
    <table width="600" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:ComplexGraph Runat="server" ID="graph" Caption="Complex Graph Cursors Demo" Width="600" Height="325">
                    <XAxes>
                        <ni:ComplexXAxis />
                    </XAxes>
                    <YAxes>
                        <ni:ComplexYAxis Mode="Fixed" Range="-1.5, 1.5" />
                    </YAxes>
                    <Plots>
                        <ni:ComplexPlot XAxis="XAxes[0]" YAxis="YAxes[0]" LineColor="Orange" LineWidth="2" DataStateManagement="SessionState"/>
                    </Plots>
                    <Cursors>
                        <ni:ComplexCursor Plot="Plots[0]" Color="White" LabelVisible="true" />
                    </Cursors>
                </ni:ComplexGraph>
            </td>
        </tr>
        
        <tr>
            <td>
                <table width="100%" cellspacing="0" cellpadding="0" border="0">
                    <tr>
                        <td>
                            <asp:Button ID="btnMovePrevious" Runat="server" Text="&laquo; Move Previous" ToolTip="Move the cursor to the previous point in the plot." Width="125" OnClick="OnMovePreviousClick" />
                        </td>
                        <td align="right">
                            <asp:Button ID="btnMoveNext" Runat="server" Text="Move Next &raquo;" Width="125" ToolTip="Move the cursor to the next point in the plot." OnClick="OnMoveNextClick" />
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
                                        Real Position:
                                    </td>
                                    <td align="left">
                                        <ni:NumericEdit Runat="server" FormatMode="SimpleDouble: 3" ID="realPosition" Width="60" AutoPostBack="true" OnAfterChangeValue="OnRealPositionAfterChangeValue" />
                                    </td>
                                </tr>

                                <tr valign="middle">
                                    <td>
                                        Imaginary Position:
                                    </td>
                                    <td>
                                        <ni:NumericEdit Runat="server" ID="imaginaryPosition" FormatMode="SimpleDouble: 3" Width="60" AutoPostBack="true" OnAfterChangeValue="OnImaginaryPositionAfterChangeValue" />
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