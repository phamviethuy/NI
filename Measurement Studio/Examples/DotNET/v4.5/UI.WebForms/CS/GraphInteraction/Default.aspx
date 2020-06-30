<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Graph Interaction Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
    <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="graph" Caption="Graph Interaction Example" Width="600" Height="300" InteractionMode="ZoomAroundPoint, ZoomX, ZoomY, EditRange">
                    <XAxes>
                        <ni:XAxis InteractionMode="EditRange" EditRangeNumericFormatMode="SimpleDouble: 5" Mode="Fixed" Range="450, 550" />
                    </XAxes>
                    <YAxes>
                        <ni:YAxis InteractionMode="EditRange" EditRangeNumericFormatMode="SimpleDouble: 5" Mode="Fixed" Range="-5, 5" />
                    </YAxes>
                    <Plots>
                        <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" DataStateManagement="SessionState"/>
                    </Plots>
                </ni:WaveformGraph>
            </td>
        </tr>
        
        <tr>
            <td>
                <fieldset>
                    <legend>Options</legend>
                    <table width="100%" cellspacing="0" cellpadding="2" border="0">
                        <tr valign="top">
                            <td colspan="2">
                                <table cellspacing="0" cellpadding="4" border="0">
                                    <tr>
                                        <td>
                                            <asp:CheckBox ID="editRange" Runat="server" AutoPostBack="true" Text="Edit Axis Ranges" Checked="true" OnCheckedChanged="OnInteractionModeCheckedChanged" />
                                        </td>
                                        <td>
                                            <asp:CheckBox ID="zoomAroundPoint" Runat="server" AutoPostBack="true" Text="Zoom Around Point" Checked="true" OnCheckedChanged="OnInteractionModeCheckedChanged" />
                                        </td>
                                        <td>
                                            <asp:CheckBox ID="zoomX" Runat="server" AutoPostBack="true" Text="Zoom X" Checked="true" OnCheckedChanged="OnInteractionModeCheckedChanged" />
                                        </td>
                                        <td>
                                            <asp:CheckBox ID="zoomY" Runat="server" AutoPostBack="true" Text="Zoom Y" Checked="true" OnCheckedChanged="OnInteractionModeCheckedChanged" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        
                        <tr><td colspan="2">&nbsp;</td></tr>
                        
                        <tr valign="top">
                            <td style="width:115px;font-weight:bold;">Click</td>
                            <td>If "Zoom Around Point" is enabled, zooms around the clicked point</td>
                        </tr>
                        
                        <tr valign="top">
                            <td style="width:115px;font-weight:bold;">Click+Drag</td>
                            <td>If "Zoom X" or "Zoom Y" is enabled, draws a selection rectangle and zooms into
                            the selected area.</td>
                        </tr>
                        
                        <tr valign="top">
                            <td style="width:115px;font-weight:bold;">Shift+Click</td>
                            <td>Undo a zoom operation or range edit.</td>
                        </tr>
                        
                        <tr valign="top">
                            <td style="width:115px;font-weight:bold;">Shift+Ctrl+Click</td>
                            <td>Undo all zoom operations and range edits.</td>
                        </tr>
                        
                        <tr><td colspan="2">&nbsp;</td></tr>
                        
                        <tr>
                            <td colspan="2">
                                Enable zoom and range editing options above and use the described interactions to
                                perform zooming operations.  Range editing, zoom x and zoom y options require IE5+
                                on Windows.
                            </td>
                        </tr>
                    </table>
                </fieldset>
            </td>
        </tr>
    </table>
</asp:Content>