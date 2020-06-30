<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Axes Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
     <!-- The hidden submit button is so Firefox does not execute the other submit buttons click events below.-->
    <input type="submit" style="visibility:hidden;display:none;" />
    <table width="100%" cellspacing="0" cellpadding="2" border="0">
        <tr>
            <td>
                <ni:WaveformGraph Runat="server" ID="waveformGraph" Caption="National Instruments 2D Graph" Width="600" Height="300">
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
                <table cellspacing="0" cellpadding="2" width="100%">
                    <tr>
                        <td style="width:50%">
                            <fieldset>
                                <legend>XAxis</legend>
                                <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                    <tr valign="middle">
                                        <td align="left">
                                            <asp:RadioButton Runat="server" ID="autoscaleXRadioButton" GroupName="XAxisScale" Checked="true" Text="AutoScale" ToolTip="Autoscales the X axis" AutoPostBack="true" OnCheckedChanged="OnAutoscaleXRadioButtonCheckedChanged"/>
                                        </td>
                                        <td>
                                            <asp:Label Runat="server" ID="minXLabel">Minimum:</asp:Label>
                                        </td>
                                        <td>
                                            <ni:NumericEdit Runat="server" ID="minX" Value="0" Range="0, 49" Enabled="false" AutoPostBack="true" OnAfterChangeValue="OnMinXAfterChangeValue"/>
                                        </td>
                                    </tr>
                                    
                                    <tr valign="middle">
                                        <td align="left">
                                            <asp:RadioButton Runat="server" ID="manualXRadioButton" GroupName="XAxisScale" Text="Manual" ToolTip="Manually scale the X axis" AutoPostBack="true" OnCheckedChanged="OnManualXRadioButtonCheckedChanged"/>
                                        </td>
                                        <td>
                                            <asp:Label Runat="server" ID="maxXLabel">Maximum:</asp:Label>
                                        </td>
                                        <td>
                                            <ni:NumericEdit Runat="server" ID="maxX" Value="50" Range="50, 100" Width="100" Enabled="false" AutoPostBack="true" OnAfterChangeValue="OnMaxXAfterChangeValue" />
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
                        </td>
                        
                        <td style="width:50%">
                            <fieldset>
                                <legend>YAxis</legend>
                                <table border="0" cellspacing="0" cellpadding="2" width="100%">
                                    <tr valign="middle">
                                        <td align="left">
                                            <asp:RadioButton Runat="server" ID="autoscaleYRadioButton" GroupName="YAxisScale" Checked="true" Text="AutoScale" ToolTip="Autoscales the Y axis" AutoPostBack="true" OnCheckedChanged="OnAutoscaleYRadioButtonCheckedChanged"/>
                                        </td>
                                        <td>
                                            <asp:Label Runat="server" ID="minYLabel">Minimum:</asp:Label>
                                        </td>
                                        <td>
                                            <ni:NumericEdit Runat="server" ID="minY" Value="-10" Range="-10, -1" Width="100" Enabled="false" AutoPostBack="true" OnAfterChangeValue="OnMinYAfterChangeValue" />
                                        </td>
                                    </tr>
                                    
                                    <tr valign="middle">
                                        <td align="left">
                                            <asp:RadioButton Runat="server" ID="manualYRadioButton" GroupName="YAxisScale" Text="Manual" ToolTip="Manually scale the Y axis" AutoPostBack="true" OnCheckedChanged="OnManualYRadioButtonCheckedChanged"/>
                                        </td>
                                        <td>
                                            <asp:Label Runat="server" ID="manualYLabel">Maximum:</asp:Label>
                                        </td>
                                        <td>
                                            <ni:NumericEdit Runat="server" ID="maxY" Value="10" Range="1, 10" Width="100" Enabled="false" AutoPostBack="true" OnAfterChangeValue="OnMaxYAfterChangeValue" />
                                        </td>
                                    </tr>
                                </table>
                            </fieldset>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        
        
        <tr>
            <td>
                <asp:Button ID="btnPlotData" Runat="server" Text="Plot Data" ToolTip="Plot One Hundred Points of Data" OnClick="OnPlotDataButtonClick"/>
            </td>
        </tr>
    </table>
</asp:Content>
