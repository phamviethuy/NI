<%@ Page Language="C#" MasterPageFile="~/Examples.master" CodeFile="Default.aspx.cs" Inherits="Default" Title="Measurement Studio ASP.NET Annotations Example" %>

<asp:Content Runat="server" ContentPlaceHolderID="exampleContentHolder">
 <table cellpadding="5">
    <tr>
    <td colspan="2" style="height: 364px">
        <ni:ComplexGraph ID="complexGraph1" Runat="server" Caption="Complex Annotations Example" Height="350px" Width="550px">
            <YAxes>
                <ni:ComplexYAxis Range="-2, 2" Mode="Fixed"></ni:ComplexYAxis>
            </YAxes>
            <Plots>
                <ni:Complexplot XAxis="XAxes[0]" YAxis="YAxes[0]" LineWidth="2" LineColor="Orange"></ni:Complexplot>
            </Plots>
            <XAxes>
                <ni:ComplexXAxis Mode="Fixed" Range="-3, 3"></ni:ComplexXAxis>
            </XAxes>
            <Annotations>
                <ni:ComplexRangeAnnotation YAxis="YAxes[0]" RangeFillColor="DarkBlue" ArrowVisible="False"
                    XAxis="XAxes[0]" CaptionVisible="False" CaptionFont="Microsoft Sans Serif, 8.25pt"
                    Caption="ComplexRangeAnnotation" YRange="-3, -1" CaptionAlignment="None, 0, -45" RangeLineStyle="Dot"
                    XRange="-Infinity, Infinity"></ni:ComplexRangeAnnotation>
                <ni:ComplexRangeAnnotation YAxis="YAxes[0]" RangeFillColor="DarkRed" ArrowVisible="False"
                    XAxis="XAxes[0]" CaptionVisible="False" CaptionFont="Microsoft Sans Serif, 8.25pt"
                    Caption="ComplexRangeAnnotation" YRange="1, 3" CaptionAlignment="None, 0, -45" RangeLineStyle="Dot"
                    XRange="-Infinity, Infinity"></ni:ComplexRangeAnnotation>
                <ni:ComplexPointAnnotation XAxis="XAxes[0]" Caption="Minimum"
                    YAxis="YAxes[0]" CaptionFont="Microsoft Sans Serif, 8.25pt" ShapeStyle="Oval"
                    Position="(1.6,1)" ShapeFillColor="Lime" ShapeZOrder="AbovePlot" ArrowHeadStyle="Open"></ni:ComplexPointAnnotation>
                <ni:ComplexPointAnnotation XAxis="XAxes[0]" Caption="Maximum"
                    YAxis="YAxes[0]" CaptionFont="Microsoft Sans Serif, 8.25pt" ShapeStyle="Oval" 
                    Position="(1,1.6)" ShapeFillColor="Lime" ShapeZOrder="AbovePlot" ArrowHeadStyle="Open"></ni:ComplexPointAnnotation>
                <ni:MagnitudeCircleAnnotation ArrowHeadMagnitude="1" ArrowHeadStyle="SolidStealth" Caption="Circle" CaptionAlignment="None, 0, 25" CaptionVisible="True"
                    CaptionFont="Microsoft Sans Serif, 8.25pt" Magnitude="1" CircleZOrder="AbovePlot" XAxis="XAxes[0]" 
                    YAxis="YAxes[0]" arrowvisible="True"></ni:MagnitudeCircleAnnotation>
                <ni:MagnitudePhaseRangeAnnotation ArrowHeadMagnitude="1.5" ArrowHeadPhase="39.34503"
                    ArrowHeadStyle="EmptyTriangle" Caption="Bottom" CaptionAlignment="BottomLeft, 50, -10"
                    CaptionFont="Microsoft Sans Serif, 8.25pt" Magnitude="0.4" Phase="210, 120" RangeFillStyle="VerticalGradient"
                    RangeLineColor="DarkGray" RangeLineStyle="Dash" StartMagnitude="0.8" XAxis="XAxes[0]"
                    YAxis="YAxes[0]"></ni:MagnitudePhaseRangeAnnotation>
            </Annotations>
        </ni:ComplexGraph>
        </td>
        </tr>
     <tr>
         <td style="width: 50%">
             <fieldset>
                 <legend>Circle Annotation</legend>
                 <table cellpadding="5">
                     <tr>
                         <td style="color: gray">
                             ArrowHead
                         </td>
                         <td>
                             <asp:DropDownList ID="circleArrowHeadDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="circleArrowHeadDropDown_SelectedIndexChanged">
                                 <asp:ListItem>EmptyDiamond</asp:ListItem>
                                 <asp:ListItem>EmptyRectangle</asp:ListItem>
                                 <asp:ListItem>EmptyRound</asp:ListItem>
                                 <asp:ListItem>EmptyStealth</asp:ListItem>
                                 <asp:ListItem>EmptyTriangle</asp:ListItem>
                                 <asp:ListItem>None</asp:ListItem>
                                 <asp:ListItem>Open</asp:ListItem>
                                 <asp:ListItem>SolidDiamond</asp:ListItem>
                                 <asp:ListItem>SolidRectangle</asp:ListItem>
                                 <asp:ListItem>SolidRound</asp:ListItem>
                                 <asp:ListItem Selected="True">SolidStealth</asp:ListItem>
                                 <asp:ListItem>SolidTriangle</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             CaptionAlignment
                         </td>
                         <td>
                             <asp:DropDownList ID="circleCaptionAlignmentDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="circleCaptionAlignmentDropDown_SelectedIndexChanged">
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
                         <td style="color: gray">
                             CaptionRealOffset
                         </td>
                         <td>
                             <ni:NumericEdit ID="circleCaptionRealOffsetNumericEdit" Runat="server" AutoPostBack="True" OnAfterChangeValue="circleCaptionRealOffsetNumericEdit_AfterChangeValue" />
                         </td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             CaptionImaginaryOffset
                         </td>
                         <td>
                             <ni:NumericEdit ID="circleCaptionImaginaryOffsetNumericEdit" Runat="server" AutoPostBack="True" Value="25" OnAfterChangeValue="circleCaptionImaginaryOffsetNumericEdit_AfterChangeValue" />
                         </td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             ArrowVisible</td>
                         <td>
                             <asp:CheckBox ID="circleArrowVisibleCheckBox" Runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="circleArrowVisibleCheckBox_CheckedChanged" /></td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             CaptionVisible
                         </td>
                         <td>
                             <asp:CheckBox ID="circleCaptionVisibleCheckBox" Runat="server" AutoPostBack="True" Checked="True" OnCheckedChanged="circleCaptionVisibleCheckBox_CheckedChanged" />
                         </td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             Caption</td>
                         <td>
                             <asp:TextBox ID="circleCaptionTextBox" runat="server" AutoPostBack="True" OnTextChanged="circleCaptionTextBox_TextChanged">Circle</asp:TextBox></td>
                     </tr>
                     <tr>
                         <td>
                             Magnitude</td>
                         <td>
                             <ni:NumericEdit ID="circleMagnitudeNumericEdit" Runat="server" AutoPostBack="True" Value="1.75" FormatMode="SimpleDouble: 2" OnAfterChangeValue="circleMagnitudeNumericEdit_AfterChangeValue" Range="0, Infinity" />
                         </td>
                     </tr>
                 </table>
             </fieldset>
         </td>
         <td style="width: 50%">
             <fieldset>
                 <legend>Phase/Range Annotation</legend>
                 <table cellpadding="5">
                     <tr>
                         <td style="color: gray">
                             ArrowHead
                         </td>
                         <td>
                             <asp:DropDownList ID="prArrowHeadDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="prArrowHeadDropDown_SelectedIndexChanged">
                                 <asp:ListItem>EmptyDiamond</asp:ListItem>
                                 <asp:ListItem>EmptyRectangle</asp:ListItem>
                                 <asp:ListItem>EmptyRound</asp:ListItem>
                                 <asp:ListItem>EmptyStealth</asp:ListItem>
                                 <asp:ListItem Selected="True">EmptyTriangle</asp:ListItem>
                                 <asp:ListItem>None</asp:ListItem>
                                 <asp:ListItem>Open</asp:ListItem>
                                 <asp:ListItem>SolidDiamond</asp:ListItem>
                                 <asp:ListItem>SolidRectangle</asp:ListItem>
                                 <asp:ListItem>SolidRound</asp:ListItem>
                                 <asp:ListItem>SolidStealth</asp:ListItem>
                                 <asp:ListItem>SolidTriangle</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             CaptionAlignment
                         </td>
                         <td>
                             <asp:DropDownList ID="prCaptionAlignmentDropDown" Runat="server" Height="22px" Width="123px" AutoPostBack="True" OnSelectedIndexChanged="prCaptionAlignmentDropDown_SelectedIndexChanged">
                                 <asp:ListItem>Auto</asp:ListItem>
                                 <asp:ListItem>BottomCenter</asp:ListItem>
                                 <asp:ListItem Selected="True">BottomLeft</asp:ListItem>
                                 <asp:ListItem>BottomRight</asp:ListItem>
                                 <asp:ListItem>MiddleCenter</asp:ListItem>
                                 <asp:ListItem>MiddleLeft</asp:ListItem>
                                 <asp:ListItem>MiddleRight</asp:ListItem>
                                 <asp:ListItem>None</asp:ListItem>
                                 <asp:ListItem>TopCenter</asp:ListItem>
                                 <asp:ListItem>TopLeft</asp:ListItem>
                                 <asp:ListItem>TopRight</asp:ListItem>
                             </asp:DropDownList>
                         </td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             CaptionRealOffset
                         </td>
                         <td>
                             <ni:NumericEdit ID="prCaptionRealOffsetNumericEdit" Runat="server" AutoPostBack="True" OnAfterChangeValue="prCaptionRealOffsetNumericEdit_AfterChangeValue" />
                         </td>
                     </tr>
                     <tr>
                         <td style="color: gray">
                             CaptionImaginaryOffset
                         </td>
                         <td>
                             <ni:NumericEdit ID="prCaptionImaginaryOffsetNumericEdit" Runat="server" AutoPostBack="True" OnAfterChangeValue="prCaptionImaginaryOffsetNumericEdit_AfterChangeValue" />
                         </td>
                     </tr>
                     <tr>
                         <td>
                             PhaseStart</td>
                         <td>
                             <ni:NumericEdit ID="prPhaseStartNumericEdit" Runat="server" AutoPostBack="True" Value="210" FormatMode="SimpleDouble: 0" OnAfterChangeValue="prPhaseStartNumericEdit_AfterChangeValue" Range="0, 360" /></td>
                     </tr>
                     <tr>
                         <td>
                             PhaseRange</td>
                         <td>
                             <ni:NumericEdit ID="prPhaseRangeNumericEdit" Runat="server" AutoPostBack="True" Value="120" FormatMode="SimpleDouble: 0" OnAfterChangeValue="prPhaseRangeNumericEdit_AfterChangeValue" Range="0, 360" /></td>
                     </tr>
                     <tr>
                         <td>
                             StartMagnitude</td>
                         <td>
                             <ni:NumericEdit ID="prStartMagnitudeNumericEdit" Runat="server" AutoPostBack="True" Value="1.55" FormatMode="SimpleDouble: 2" OnAfterChangeValue="prStartMagnitudeNumericEdit_AfterChangeValue" Range="0, Infinity" />
                         </td>
                     </tr>
                     <tr>
                         <td>
                             Magnitude</td>
                         <td>
                             <ni:NumericEdit ID="prMagnitudeNumericEdit" Runat="server" AutoPostBack="True" Value="0.4" FormatMode="SimpleDouble: 2" OnAfterChangeValue="prMagnitudeNumericEdit_AfterChangeValue" Range="0, Infinity" />
                         </td>
                     </tr>
                 </table>
             </fieldset>
         </td>
     </tr>
        <tr>
        <td style="width: 50%">
        <fieldset>
                    <legend>Min Annotation</legend>
        <table cellpadding="5">
            <tr>
                <td style="color: gray">
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
                <td style="color: gray">
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
                <td style="color: gray">
                    CaptionRealOffset
                </td>
                <td>
                    <ni:NumericEdit ID="minCaptionRealOffsetNumericEdit" Runat="server" AutoPostBack="True" Value="-50" OnAfterChangeValue="minCaptionRealOffsetNumericEdit_AfterChangeValue" />
                </td>
            </tr>
            <tr>
                <td style="color: gray">
                    CaptionImaginaryOffset
        </td>
        <td>
           <ni:NumericEdit ID="minCaptionImaginaryOffsetNumericEdit" Runat="server" AutoPostBack="True" Value="50" OnAfterChangeValue="minCaptionImaginaryOffsetNumericEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeWidth
        </td>
        <td>
            <ni:NumericEdit ID="minShapeWidthNumericEdit" Runat="server" AutoPostBack="True" Value="20" FormatMode="SimpleDouble: 0" OnAfterChangeValue="minShapeWidthNumericEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeHeight
        </td>
        <td>
        <ni:NumericEdit ID="minShapeHeightNumericEdit" Runat="server" AutoPostBack="True" Value="20" FormatMode="SimpleDouble: 0" OnAfterChangeValue="minShapeHeightNumericEdit_AfterChangeValue" />
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
            <td style="width: 50%">
        <fieldset>
                    <legend>Max Annotation</legend>
        <table cellpadding="5">
            <tr>
                <td style="color: gray">
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
                <td style="color: gray">
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
                <td style="color: gray">
                    CaptionRealOffset
                </td>
                <td>
                    <ni:NumericEdit ID="maxCaptionRealOffsetNumericEdit" Runat="server" AutoPostBack="True" Value="30" OnAfterChangeValue="maxCaptionRealOffsetNumericEdit_AfterChangeValue" />
                </td>
            </tr>
            <tr>
                <td style="color: gray">
                    CaptionImaginaryOffset
        </td>
        <td>
            <ni:NumericEdit ID="maxCaptionImaginaryOffsetNumericEdit" Runat="server" AutoPostBack="True" Value="-50" OnAfterChangeValue="maxCaptionImaginaryOffsetNumericEdit_AfterChangeValue" /> 
        </td>
        </tr>
        <tr>
        <td>
        ShapeWidth
        </td>
        <td>
            <ni:NumericEdit ID="maxShapeWidthNumericEdit" Runat="server" AutoPostBack="True" Value="20" FormatMode="SimpleDouble: 0" OnAfterChangeValue="maxShapeWidthNumericEdit_AfterChangeValue" />
        </td>
        </tr>
        <tr>
        <td>
        ShapeHeight
        </td>
        <td>
        <ni:NumericEdit ID="maxShapeHeightNumericEdit" Runat="server" AutoPostBack="True" Value="20" FormatMode="SimpleDouble: 0" OnAfterChangeValue="maxShapeHeightNumericEdit_AfterChangeValue" />
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
        </tr>
     <tr>
         <td colspan="2" style="color: gray">
             Note:<br />
             &nbsp;- Properties available to all annotations are displayed in gray text.<br />
             &nbsp;- Properties specific to a particular type of annotation are displayed in
             black text.</td>
     </tr>
        </table>
</asp:Content>