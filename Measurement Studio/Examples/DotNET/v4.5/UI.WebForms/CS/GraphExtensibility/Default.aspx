<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Graph Extensibility Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
        <table>
            <tr>
                <td>
                    <ni:WaveformGraph ID="waveformGraph" Runat="server" InteractionMode="ZoomX, ZoomY, ZoomAroundPoint, EditRange" Width="600" Height="300">
                        <YAxes>
                            <ni:YAxis Range="-1.5, 1.5" Mode="Fixed">
                            </ni:YAxis>
                        </YAxes>
                        <Plots>
                            <ni:WaveformPlot DataStateManagement="SessionState" XAxis="XAxes[0]" YAxis="YAxes[0]">
                            </ni:WaveformPlot>
                        </Plots>
                        <XAxes>
                            <ni:XAxis MajorDivisions-LabelFormat="DateTime, h:mm:ss tt" Mode="AutoScaleExact">
                            </ni:XAxis>
                        </XAxes>
                    </ni:WaveformGraph>                
                </td>
            </tr>
            <tr>
                <td>
                    <fieldset>
                    <legend>
                        Extensible Styles
                    </legend>
                    <asp:RadioButtonList ID="listExtensibleStyles" Runat="server" AutoPostBack="True">
                        <asp:ListItem Value="Default" Selected="True">Default</asp:ListItem>
                        <asp:ListItem Value="HighlightMinMax">Highlight min/max via custom post-plot drawing</asp:ListItem>
                        <asp:ListItem Value="HighlightIncDec">Highlight increasing/decreasing values via custom pre-plot drawing</asp:ListItem>
                        <asp:ListItem Value="HighlightPlotArea">Highlight plot area background regions via custom pre-plot area drawing</asp:ListItem>
                    </asp:RadioButtonList>                                    
                    </fieldset>
                </td>
            </tr>
        </table>
</asp:Content>