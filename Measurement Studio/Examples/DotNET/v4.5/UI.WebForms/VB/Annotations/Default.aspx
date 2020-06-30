<%@ Page Language="VB" MasterPageFile="~/Examples.master" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="DefaultAspx" Title="Measurement Studio ASP.NET Annotations Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
<table cellpadding="5">
    <tr>
    <td colspan="2">
        <ni:WaveformGraph ID="WaveformGraph1" Runat="server" Height="350px" Width="550px">
            <YAxes>
                <ni:YAxis Range="-2, 2" Mode="Fixed">
                </ni:YAxis>
            </YAxes>
            <Plots>
                <ni:WaveformPlot XAxis="XAxes[0]" YAxis="YAxes[0]" LineWidth="2" LineColor="Yellow" DataStateManagement="SessionState">
                </ni:WaveformPlot>
            </Plots>
            <XAxes>
                <ni:XAxis>
                </ni:XAxis>
            </XAxes>
            <Annotations>
                <ni:XYRangeAnnotation YAxis="YAxes[0]" RangeFillColor="DarkBlue" ArrowVisible="False"
                    XAxis="XAxes[0]" CaptionVisible="False" CaptionFont="Microsoft Sans Serif, 8.25pt"
                    Caption="XYRangeAnnotation" YRange="-3, -1" CaptionAlignment="None, 0, -45" RangeLineStyle="Dot"
                    XRange="-Infinity, Infinity">
                </ni:XYRangeAnnotation>
                <ni:XYRangeAnnotation YAxis="YAxes[0]" RangeFillColor="DarkRed" ArrowVisible="False"
                    XAxis="XAxes[0]" CaptionVisible="False" CaptionFont="Microsoft Sans Serif, 8.25pt"
                    Caption="XYRangeAnnotation" YRange="1, 3" CaptionAlignment="None, 0, -45" RangeLineStyle="Dot"
                    XRange="-Infinity, Infinity">
                </ni:XYRangeAnnotation>
                <ni:XYPointAnnotation CaptionAlignment="None, -50, 50" XAxis="XAxes[0]" Caption="Minimum"
                    YAxis="YAxes[0]" CaptionFont="Microsoft Sans Serif, 8.25pt" ShapeStyle="Oval"
                    YPosition="1.6" XPosition="1" ShapeFillColor="Lime" ShapeZOrder="AbovePlot" ArrowHeadStyle="Open">
                </ni:XYPointAnnotation>
                <ni:XYPointAnnotation CaptionAlignment="None, 50, -50" XAxis="XAxes[0]" Caption="Maximum"
                    YAxis="YAxes[0]" CaptionFont="Microsoft Sans Serif, 8.25pt" ShapeStyle="Oval" YPosition="1.6" ShapeFillColor="Lime" ShapeZOrder="AbovePlot" ArrowHeadStyle="Open">
                </ni:XYPointAnnotation>
            </Annotations>
        </ni:WaveformGraph>
        </td>
        </tr>
        <tr>
        <td>
        <fieldset>
                    <legend>Max Annotation</legend>
        <table cellpadding="5">
        <tr>
        <td>
        ArrowHead
        </td>
        <td>
            <asp:DropDownList ID="maxArrowHeadDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="maxArrowHeadDropDown_SelectedIndexChanged">
            <asp:ListItem>EmptyDiamond</asp:ListItem>
            <asp:ListItem>EmptyRectangle</asp:ListItem>
            <asp:ListItem>EmptyRound</asp:ListItem>
            <asp:ListItem>EmptyStealth</asp:ListItem>
            <asp:ListItem>EmptyTriangle</asp:ListItem>
            <asp:ListItem>None</asp:ListItem>
            <asp:ListItem Selected="True">Open</asp:ListItem>
            <asp:ListItem>SolidDiamond</asp:ListItem>
            <asp:ListItem>SolidRectangle</asp:ListItem>
            <asp:ListItem>SolidRound</asp:ListItem>
            <asp:ListItem>SolidStealth</asp:ListItem>
            <asp:ListItem>SolidTriangle</asp:ListItem>
            </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        CaptionAlignment
        </td>
        <td>
            <asp:DropDownList ID="maxCaptionAlignmentDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="maxCaptionAlignmentDropDown_SelectedIndexChanged">
            <asp:ListItem>Auto</asp:ListItem>
            <asp:ListItem>BottomCenter</asp:ListItem>
            <asp:ListItem>BottomLeft</asp:ListItem>
            <asp:ListItem>BottomRight</asp:ListItem>
            <asp:ListItem>MiddleCenter</asp:ListItem>
            <asp:ListItem>MiddleLeft</asp:ListItem>
            <asp:ListItem>MiddleRight</asp:ListItem>
            <asp:ListItem Selected="True">None</asp:ListItem>
            <asp:ListItem>TopCenter</asp:ListItem>
            <asp:ListItem>TopLeft</asp:ListItem>
            <asp:ListItem>TopRight</asp:ListItem>
            </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        CaptionXOffset
        </td>
        <td>
            <ni:NumericEdit ID="maxCaptionXOffsetNumEdit" Runat="server" AutoPostBack="True" Value="50" OnAfterChangeValue="maxCaptionXOffsetNumEdit_AfterChangeValue" /> 
        </td>
        </tr>
        <tr>
        <td>
        CaptionYOffset
        </td>
        <td>
            <ni:NumericEdit ID="maxCaptionYOffsetNumEdit" Runat="server" AutoPostBack="True" Value="-50" OnAfterChangeValue="maxCaptionYOffsetNumEdit_AfterChangeValue" /> 
        </td>
        </tr>
        <tr>
        <td>
        ShapeWidth
        </td>
        <td>
            <ni:NumericEdit ID="maxShapeWidthNumEdit" Runat="server" FormatMode="SimpleDouble: 0" AutoPostBack="True" Value="20" OnAfterChangeValue="maxShapeWidthNumEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeHeight
        </td>
        <td>
        <ni:NumericEdit ID="maxShapeHeightNumEdit" Runat="server" FormatMode="SimpleDouble: 0" AutoPostBack="True" Value="20" OnAfterChangeValue="maxShapeHeightNumEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeVisible
        </td>
        <td>
            <asp:CheckBox ID="maxShapeVisibleCheckBox" Runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="maxShapeVisibleCheckBox_CheckedChanged" />
        </td>
        </tr>
        </table>
        </fieldset>
        </td>
        <td>
        <fieldset>
                    <legend>Min Annotation</legend>
        <table cellpadding="5">
        <tr>
        <td>
        ArrowHead
        </td>
        <td>
            <asp:DropDownList ID="minArrowHeadDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="minArrowHeadDropDown_SelectedIndexChanged">
             <asp:ListItem>EmptyDiamond</asp:ListItem>
            <asp:ListItem>EmptyRectangle</asp:ListItem>
            <asp:ListItem>EmptyRound</asp:ListItem>
            <asp:ListItem>EmptyStealth</asp:ListItem>
            <asp:ListItem>EmptyTriangle</asp:ListItem>
            <asp:ListItem>None</asp:ListItem>
            <asp:ListItem Selected="True">Open</asp:ListItem>
            <asp:ListItem>SolidDiamond</asp:ListItem>
            <asp:ListItem>SolidRectangle</asp:ListItem>
            <asp:ListItem>SolidRound</asp:ListItem>
            <asp:ListItem>SolidStealth</asp:ListItem>
            <asp:ListItem>SolidTriangle</asp:ListItem>
            </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        CaptionAlignment
        </td>
        <td>
            <asp:DropDownList ID="minCaptionAlignmentDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="minCaptionAlignmentDropDown_SelectedIndexChanged">
             <asp:ListItem>Auto</asp:ListItem>
            <asp:ListItem>BottomCenter</asp:ListItem>
            <asp:ListItem>BottomLeft</asp:ListItem>
            <asp:ListItem>BottomRight</asp:ListItem>
            <asp:ListItem>MiddleCenter</asp:ListItem>
            <asp:ListItem>MiddleLeft</asp:ListItem>
            <asp:ListItem>MiddleRight</asp:ListItem>
            <asp:ListItem Selected="True">None</asp:ListItem>
            <asp:ListItem>TopCenter</asp:ListItem>
            <asp:ListItem>TopLeft</asp:ListItem>
            <asp:ListItem>TopRight</asp:ListItem>
            </asp:DropDownList>
        </td>
        </tr>
        <tr>
        <td>
        CaptionXOffset
        </td>
        <td>
            <ni:NumericEdit ID="minCaptionXOffsetNumEdit" Runat="server" AutoPostBack="True" Value="-50" OnAfterChangeValue="minCaptionXOffsetNumEdit_AfterChangeValue" /> 
        </td>
        </tr>
        <tr>
        <td>
        CaptionYOffset
        </td>
        <td>
           <ni:NumericEdit ID="minCaptionYOffsetNumEdit" Runat="server" AutoPostBack="True" Value="50" OnAfterChangeValue="minCaptionYOffsetNumEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeWidth
        </td>
        <td>
            <ni:NumericEdit ID="minShapeWidthNumEdit" Runat="server" FormatMode="SimpleDouble: 0" AutoPostBack="True" Value="20" OnAfterChangeValue="minShapeWidthNumEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeHeight
        </td>
        <td>
        <ni:NumericEdit ID="minShapeHeightNumEdit" Runat="server" FormatMode="SimpleDouble: 0" AutoPostBack="True" Value="20" OnAfterChangeValue="minShapeHeightNumEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeVisible
        </td>
        <td>
            <asp:CheckBox ID="minShapeVisibleCheckBox" Runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="minShapeVisibleCheckBox_CheckedChanged" />
        </td>
        </tr>
        </table>
        </fieldset>
        </td>
        </tr>
        </table>
</asp:Content>
