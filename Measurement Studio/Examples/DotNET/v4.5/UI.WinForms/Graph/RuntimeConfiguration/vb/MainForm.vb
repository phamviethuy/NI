Imports NationalInstruments
Imports NationalInstruments.UI
Imports NationalInstruments.UI.WindowsForms

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Plot white noise data
        Dim data(20) As Double
        Dim rnd As New Random
        Dim i As Integer

        While i < data.Length
            data(i) = rnd.NextDouble() * 10
            i = i + 1
        End While

        sampleWaveformGraph.PlotY(data)

        Dim x As Double
        Dim y As Double

        ' Position annotation to a point on the plot
        whiteNoisePlot.GetDataPoint(CInt(data.Length / 4), x, y)
        annotation.XPosition = x
        annotation.YPosition = y

        ' Position cursor to a point on the plot
        whiteNoisePlot.GetDataPoint(CInt(data.Length / 2), x, y)
        dataCursor.XPosition = x
        dataCursor.YPosition = y

        ' Add menu items to the context menus
        Dim bools() As Boolean = {True, False}
        Dim boolStrings As String() = Nothing
        If DataConverter.CanConvert(bools, GetType(String())) Then
            boolStrings = CType(DataConverter.Convert(bools, GetType(String())), String())
        End If

        AddMenuItem(axisContextMenu, "Inverted", boolStrings, AddressOf OnInvertedMenuClick, AddressOf OnInvertedMenuPopup)

        Dim scaleTypes As String() = [Enum].GetNames(GetType(ScaleType))
        AddMenuItem(axisContextMenu, "Scale Type", scaleTypes, AddressOf OnScaleTypeMenuClick, AddressOf OnScaleTypeMenuPopup)

        AddMenuItem(axisContextMenu, "Major Grids Visible", boolStrings, AddressOf OnMajorGridsVisibleMenuClick, AddressOf OnMajorGridsVisibleMenuPopup)

        AddMenuItem(axisContextMenu, "Minor Grids Visible", boolStrings, AddressOf OnMinorGridsVisibleMenuClick, AddressOf OnMinorGridsVisibleMenuPopup)

        AddMenuItem(cursorContextMenu, "Color ...", AddressOf OnColorMenuClick, Nothing)

        Dim snapModes As String() = [Enum].GetNames(GetType(CursorSnapMode))
        AddMenuItem(cursorContextMenu, "Snap Mode", snapModes, AddressOf OnSnapModeMenuClick, AddressOf OnSnapModeMenuPopup)

        Dim lineStyles As String() = EnumObject.GetNames(GetType(LineStyle))
        AddMenuItem(cursorContextMenu, "Line Style", lineStyles, AddressOf OnLineStyleMenuClick, AddressOf OnLineStyleMenuPopup)

        Dim lineWidths() As Single = {1, 2, 3, 4, 5}
        If DataConverter.CanConvert(lineWidths, GetType(String())) Then
            Dim lineWidthStrings As String() = DataConverter.Convert(lineWidths, GetType(String()))
            AddMenuItem(cursorContextMenu, "Line Width", lineWidthStrings, AddressOf OnLineWidthMenuClick, AddressOf OnLineWidthMenuPopup)
        End If

        AddMenuItem(plotContextMenu, "Anti-Aliased", boolStrings, AddressOf OnAntiAliasedMenuClick, AddressOf OnAntiAliasedMenuPopup)

        Dim fillModes As String() = [Enum].GetNames(GetType(PlotFillMode))
        AddMenuItem(plotContextMenu, "Fill Mode", fillModes, AddressOf OnFillModeMenuClick, AddressOf OnFillModeMenuPopup)

        Dim baseYValues() As Double = {[Double].PositiveInfinity, 5, 0, -5, [Double].NegativeInfinity}
        If DataConverter.CanConvert(baseYValues, GetType(String())) Then
            Dim baseYValueStrings As String() = DataConverter.Convert(baseYValues, GetType(String()))
            AddMenuItem(plotContextMenu, "Base Y Value", baseYValueStrings, AddressOf OnBaseYValueMenuClick, AddressOf OnBaseYValueMenuPopup)
        End If

        Dim fillBaseStyles As String() = EnumObject.GetNames(GetType(FillStyle))
        AddMenuItem(plotContextMenu, "Fill To Base Style", fillBaseStyles, AddressOf OnFillBaseStyleMenuClick, AddressOf OnFillBaseStyleMenuPopup)

        Dim shapeZOrder As String() = [Enum].GetNames(GetType(AnnotationZOrder))
        AddMenuItem(annotationContextMenu, "Shape Z-Order", shapeZOrder, AddressOf OnShapeZOrderMenuClick, AddressOf OnShapeZOrderMenuPopup)

        Dim arrowHeadStyle As String() = EnumObject.GetNames(GetType(ArrowStyle))
        AddMenuItem(annotationContextMenu, "Arrow Head Style", arrowHeadStyle, AddressOf OnArrowHeadStyleMenuClick, AddressOf OnArrowHeadStyleMenuPopup)

        AddMenuItem(annotationContextMenu, "Caption Font ...", AddressOf OnCaptionFontMenuClick, Nothing)
    End Sub

    Private Shared Sub AddMenuItem(ByVal destination As ContextMenu, ByVal caption As String, ByVal onClick As EventHandler, ByVal onPopup As EventHandler)
        Dim menu As MenuItem = destination.MenuItems.Add(caption, onClick)
        AddHandler menu.Popup, onPopup
    End Sub


    Private Shared Sub AddMenuItem(ByVal destination As ContextMenu, ByVal caption As String, ByVal menuItemCaptions() As String, ByVal onItemClick As EventHandler, ByVal onPopup As EventHandler)
        Dim menuItems(menuItemCaptions.Length - 1) As MenuItem
        Dim i As Integer

        While i < menuItemCaptions.Length
            menuItems(i) = New MenuItem(menuItemCaptions(i), onItemClick)
            i = i + 1
        End While
        Dim menu As MenuItem = destination.MenuItems.Add(caption, menuItems)
        AddHandler menu.Popup, onPopup
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub


    Private contextAxis As Axis
    Private contextCursor As XYCursor
    Private contextPlot As XYPlot
    Private contextAnnotation As XYAnnotation

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents whiteNoisePlot As NationalInstruments.UI.WaveformPlot
    Friend WithEvents xAxis As NationalInstruments.UI.XAxis
    Friend WithEvents yAxis As NationalInstruments.UI.YAxis
    Friend WithEvents dataCursor As NationalInstruments.UI.XYCursor
    Friend WithEvents cursorContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents plotContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents sinePlotLegendItem As NationalInstruments.UI.LegendItem
    Friend WithEvents annotationContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents plotLegend As NationalInstruments.UI.WindowsForms.Legend
    Friend WithEvents dataLegendItem As NationalInstruments.UI.LegendItem
    Friend WithEvents annotation As NationalInstruments.UI.XYPointAnnotation
    Friend WithEvents cursorLegend As NationalInstruments.UI.WindowsForms.Legend
    Friend WithEvents axisContextMenu As System.Windows.Forms.ContextMenu
    Friend WithEvents sampleWaveformGraph As NationalInstruments.UI.WindowsForms.WaveformGraph
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.whiteNoisePlot = New NationalInstruments.UI.WaveformPlot
        Me.xAxis = New NationalInstruments.UI.XAxis
        Me.yAxis = New NationalInstruments.UI.YAxis
        Me.dataCursor = New NationalInstruments.UI.XYCursor
        Me.cursorContextMenu = New System.Windows.Forms.ContextMenu
        Me.plotContextMenu = New System.Windows.Forms.ContextMenu
        Me.sinePlotLegendItem = New NationalInstruments.UI.LegendItem
        Me.annotationContextMenu = New System.Windows.Forms.ContextMenu
        Me.plotLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.dataLegendItem = New NationalInstruments.UI.LegendItem
        Me.annotation = New NationalInstruments.UI.XYPointAnnotation
        Me.cursorLegend = New NationalInstruments.UI.WindowsForms.Legend
        Me.axisContextMenu = New System.Windows.Forms.ContextMenu
        Me.sampleWaveformGraph = New NationalInstruments.UI.WindowsForms.WaveformGraph
        CType(Me.dataCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.plotLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cursorLegend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'whiteNoisePlot
        '
        Me.whiteNoisePlot.AntiAliased = True
        Me.whiteNoisePlot.LineColor = System.Drawing.Color.DarkOrange
        Me.whiteNoisePlot.PointColor = System.Drawing.Color.Gold
        Me.whiteNoisePlot.PointStyle = NationalInstruments.UI.PointStyle.Cross
        Me.whiteNoisePlot.ToolTipsEnabled = True
        Me.whiteNoisePlot.XAxis = Me.xAxis
        Me.whiteNoisePlot.YAxis = Me.yAxis
        '
        'dataCursor
        '
        Me.dataCursor.Color = System.Drawing.Color.CornflowerBlue
        Me.dataCursor.LabelVisible = True
        Me.dataCursor.Plot = Me.whiteNoisePlot
        Me.dataCursor.SnapMode = NationalInstruments.UI.CursorSnapMode.NearestPoint
        '
        'sinePlotLegendItem
        '
        Me.sinePlotLegendItem.Source = Me.whiteNoisePlot
        Me.sinePlotLegendItem.Text = "White Noise"
        '
        'plotLegend
        '
        Me.plotLegend.Border = NationalInstruments.UI.Border.Solid
        Me.plotLegend.Caption = "Plots"
        Me.plotLegend.Items.AddRange(New NationalInstruments.UI.LegendItem() {Me.sinePlotLegendItem})
        Me.plotLegend.Location = New System.Drawing.Point(377, 7)
        Me.plotLegend.Name = "plotLegend"
        Me.plotLegend.Size = New System.Drawing.Size(106, 134)
        Me.plotLegend.TabIndex = 4
        '
        'dataLegendItem
        '
        Me.dataLegendItem.Source = Me.dataCursor
        Me.dataLegendItem.Text = "Data"
        '
        'annotation
        '
        Me.annotation.Caption = "Annotation"
        Me.annotation.ShapeFillColor = System.Drawing.Color.Brown
        Me.annotation.ShapeSize = New System.Drawing.Size(25, 25)
        Me.annotation.ShapeStyle = NationalInstruments.UI.ShapeStyle.Oval
        Me.annotation.XAxis = Me.xAxis
        Me.annotation.YAxis = Me.yAxis
        '
        'cursorLegend
        '
        Me.cursorLegend.Border = NationalInstruments.UI.Border.Solid
        Me.cursorLegend.Caption = "Cursors"
        Me.cursorLegend.Items.AddRange(New NationalInstruments.UI.LegendItem() {Me.dataLegendItem})
        Me.cursorLegend.Location = New System.Drawing.Point(377, 141)
        Me.cursorLegend.Name = "cursorLegend"
        Me.cursorLegend.Size = New System.Drawing.Size(106, 134)
        Me.cursorLegend.TabIndex = 5
        '
        'sampleWaveformGraph
        '
        Me.sampleWaveformGraph.Annotations.AddRange(New NationalInstruments.UI.XYAnnotation() {Me.annotation})
        Me.sampleWaveformGraph.Caption = "Waveform Graph"
        Me.sampleWaveformGraph.Cursors.AddRange(New NationalInstruments.UI.XYCursor() {Me.dataCursor})
        Me.sampleWaveformGraph.Location = New System.Drawing.Point(7, 7)
        Me.sampleWaveformGraph.Name = "sampleWaveformGraph"
        Me.sampleWaveformGraph.Plots.AddRange(New NationalInstruments.UI.WaveformPlot() {Me.whiteNoisePlot})
        Me.sampleWaveformGraph.Size = New System.Drawing.Size(370, 268)
        Me.sampleWaveformGraph.TabIndex = 3
        Me.sampleWaveformGraph.XAxes.AddRange(New NationalInstruments.UI.XAxis() {Me.xAxis})
        Me.sampleWaveformGraph.YAxes.AddRange(New NationalInstruments.UI.YAxis() {Me.yAxis})
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(491, 282)
        Me.Controls.Add(Me.plotLegend)
        Me.Controls.Add(Me.cursorLegend)
        Me.Controls.Add(Me.sampleWaveformGraph)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.Text = "Runtime Configuration"
        CType(Me.dataCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.plotLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cursorLegend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sampleWaveformGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.Run(New MainForm)
    End Sub


    Private Sub OnGraphMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles sampleWaveformGraph.MouseDown
        ' Hit test the graph and show the context menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hitXAxis As XAxis = sampleWaveformGraph.GetXAxisAt(e.X, e.Y)
            If Not (hitXAxis Is Nothing) Then
                contextAxis = hitXAxis
                axisContextMenu.Show(sampleWaveformGraph, New Point(e.X, e.Y))
            Else
                Dim hitYAxis As YAxis = sampleWaveformGraph.GetYAxisAt(e.X, e.Y)
                If Not (hitYAxis Is Nothing) Then
                    contextAxis = hitYAxis
                    axisContextMenu.Show(sampleWaveformGraph, New Point(e.X, e.Y))
                Else
                    Dim hitCursor As XYCursor = sampleWaveformGraph.GetCursorAt(e.X, e.Y)
                    If Not (hitCursor Is Nothing) Then
                        contextCursor = hitCursor
                        cursorContextMenu.Show(sampleWaveformGraph, New Point(e.X, e.Y))
                    Else
                        Dim hitPlot As XYPlot = sampleWaveformGraph.GetPlotAt(e.X, e.Y)
                        If Not (hitPlot Is Nothing) Then
                            contextPlot = hitPlot
                            plotContextMenu.Show(sampleWaveformGraph, New Point(e.X, e.Y))
                        Else
                            Dim hitAnnotation As XYAnnotation = sampleWaveformGraph.GetAnnotationAt(e.X, e.Y)
                            If Not (hitAnnotation Is Nothing) Then
                                contextAnnotation = hitAnnotation
                                annotationContextMenu.Show(sampleWaveformGraph, New Point(e.X, e.Y))
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


Private Sub OnPlotLegendMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles plotLegend.MouseDown
   ' Hit test the legend and show the context menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hitItem As LegendItem = plotLegend.GetItemAt(e.X, e.Y)
            If Not (hitItem Is Nothing) Then
                contextPlot = CType(hitItem.Source, XYPlot)
                plotContextMenu.Show(plotLegend, New Point(e.X, e.Y))
            End If
        End If
End Sub


Private Sub OnCursorLegendMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cursorLegend.MouseDown
   ' Hit test the legend and show the context menu
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim hitItem As LegendItem = cursorLegend.GetItemAt(e.X, e.Y)
            If Not (hitItem Is Nothing) Then
                contextCursor = CType(hitItem.Source, XYCursor)
                cursorContextMenu.Show(cursorLegend, New Point(e.X, e.Y))
            End If
        End If
End Sub


Private Sub OnInvertedMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim inverted As Boolean = System.Boolean.Parse(menuItem.Text)
         contextAxis.Inverted = inverted
      End If

      contextAxis = Nothing
   End If
End Sub


Private Sub OnInvertedMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim inverted As Boolean = System.Boolean.Parse(menuItem.Text)
         If contextAxis.Inverted = inverted Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnScaleTypeMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim scaleType As ScaleType = CType([Enum].Parse(GetType(ScaleType), menuItem.Text), ScaleType)
         contextAxis.ScaleType = scaleType
      End If

      contextAxis = Nothing
   End If
End Sub


Private Sub OnScaleTypeMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim scaleType As ScaleType = CType([Enum].Parse(GetType(ScaleType), menuItem.Text), ScaleType)
         If contextAxis.ScaleType = scaleType Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnMajorGridsVisibleMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim majorGridsVisible As Boolean = System.Boolean.Parse(menuItem.Text)
         contextAxis.MajorDivisions.GridVisible = majorGridsVisible
      End If

      contextAxis = Nothing
   End If
End Sub


Private Sub OnMajorGridsVisibleMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim majorGridsVisible As Boolean = System.Boolean.Parse(menuItem.Text)
         If contextAxis.MajorDivisions.GridVisible = majorGridsVisible Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnMinorGridsVisibleMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim minorGridsVisible As Boolean = System.Boolean.Parse(menuItem.Text)
         contextAxis.MinorDivisions.GridVisible = minorGridsVisible
      End If

      contextAxis = Nothing
   End If
End Sub


Private Sub OnMinorGridsVisibleMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAxis Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim minorGridsVisible As Boolean = System.Boolean.Parse(menuItem.Text)
         If contextAxis.MinorDivisions.GridVisible = minorGridsVisible Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnColorMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextCursor Is Nothing) Then
      Dim colorDialog As New ColorDialog
      Try
                If colorDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    contextCursor.Color = colorDialog.Color
                End If
      Finally
         colorDialog.Dispose()
      End Try

      contextCursor = Nothing
   End If
End Sub


Private Sub OnSnapModeMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextCursor Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim snapMode As CursorSnapMode = CType([Enum].Parse(GetType(CursorSnapMode), menuItem.Text), CursorSnapMode)
         contextCursor.SnapMode = snapMode
      End If

      contextCursor = Nothing
   End If
End Sub


Private Sub OnSnapModeMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextCursor Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim snapMode As CursorSnapMode = CType([Enum].Parse(GetType(CursorSnapMode), menuItem.Text), CursorSnapMode)
         If contextCursor.SnapMode = snapMode Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnLineStyleMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextCursor Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim lineStyle As LineStyle = EnumObject.Parse(GetType(LineStyle), menuItem.Text)
         If Not (lineStyle Is Nothing) Then
            contextCursor.LineStyle = lineStyle
         End If
      End If

      contextCursor = Nothing
   End If
End Sub


Private Sub OnLineStyleMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextCursor Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim lineStyle As LineStyle = EnumObject.Parse(GetType(LineStyle), menuItem.Text)
         If contextCursor.LineStyle.Equals(lineStyle) Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnLineWidthMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextCursor Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim lineWidth As Single = [Single].Parse(menuItem.Text)
         contextCursor.LineWidth = lineWidth
      End If

      contextCursor = Nothing
   End If
End Sub


Private Sub OnLineWidthMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextCursor Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim lineWidth As Double = [Double].Parse(menuItem.Text)
         If contextCursor.LineWidth = lineWidth Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnAntiAliasedMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim antiAliased As Boolean = System.Boolean.Parse(menuItem.Text)
         contextPlot.AntiAliased = antiAliased
      End If

      contextPlot = Nothing
   End If
End Sub


Private Sub OnAntiAliasedMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim antiAliased As Boolean = System.Boolean.Parse(menuItem.Text)
         If contextPlot.AntiAliased = antiAliased Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnFillModeMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim fillMode As PlotFillMode = CType([Enum].Parse(GetType(PlotFillMode), menuItem.Text), PlotFillMode)
         contextPlot.FillMode = fillMode
      End If

      contextPlot = Nothing
   End If
End Sub


Private Sub OnFillModeMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim fillMode As PlotFillMode = CType([Enum].Parse(GetType(PlotFillMode), menuItem.Text), PlotFillMode)
         If contextPlot.FillMode = fillMode Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnFillBaseStyleMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim fillStyle As FillStyle = EnumObject.Parse(GetType(FillStyle), menuItem.Text)
         If Not (fillStyle Is Nothing) Then
            contextPlot.FillToBaseStyle = fillStyle
         End If
      End If

      contextPlot = Nothing
   End If
End Sub


Private Sub OnFillBaseStyleMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim fillStyle As FillStyle = EnumObject.Parse(GetType(FillStyle), menuItem.Text)
         If Not (fillStyle Is Nothing) Then
            If contextPlot.FillToBaseStyle.Equals(fillStyle) Then
               menuItem.Checked = True
            Else
               menuItem.Checked = False
            End If
         End If
      End If
   End If
End Sub


Private Sub OnBaseYValueMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim baseYValue As Double = [Double].Parse(menuItem.Text, CultureInfo.CurrentCulture)
         contextPlot.BaseYValue = baseYValue
      End If

      contextPlot = Nothing
   End If
End Sub


Private Sub OnBaseYValueMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextPlot Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim baseYValue As Double = [Double].Parse(menuItem.Text, CultureInfo.CurrentCulture)
         If contextPlot.BaseYValue = baseYValue Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnShapeZOrderMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAnnotation Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim shapeZOrder As AnnotationZOrder = CType([Enum].Parse(GetType(AnnotationZOrder), menuItem.Text), AnnotationZOrder)
         If TypeOf contextAnnotation Is XYPointAnnotation Then
            Dim contextPointAnnotation As XYPointAnnotation = contextAnnotation
            contextPointAnnotation.ShapeZOrder = shapeZOrder
         End If
      End If

      contextAnnotation = Nothing
   End If
End Sub


Private Sub OnShapeZOrderMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAnnotation Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim shapeZOrder As AnnotationZOrder = CType([Enum].Parse(GetType(AnnotationZOrder), menuItem.Text), AnnotationZOrder)
         If TypeOf contextAnnotation Is XYPointAnnotation Then
            Dim contextPointAnnotation As XYPointAnnotation = contextAnnotation
            If contextPointAnnotation.ShapeZOrder = shapeZOrder Then
               menuItem.Checked = True
            Else
               menuItem.Checked = False
            End If
         End If
      End If
   End If
End Sub


Private Sub OnArrowHeadStyleMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAnnotation Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)

      If Not (menuItem Is Nothing) Then
         Dim arrowStyle As ArrowStyle = EnumObject.Parse(GetType(ArrowStyle), menuItem.Text)
         contextAnnotation.ArrowHeadStyle = arrowStyle
      End If

      contextAnnotation = Nothing
   End If
End Sub


Private Sub OnArrowHeadStyleMenuPopup(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAnnotation Is Nothing) Then
      Dim menuItem As MenuItem = CType(sender, MenuItem)
      If Not (menuItem Is Nothing) Then
         Dim arrowStyle As ArrowStyle = EnumObject.Parse(GetType(ArrowStyle), menuItem.Text)
         If contextAnnotation.ArrowHeadStyle.Equals(arrowStyle) Then
            menuItem.Checked = True
         Else
            menuItem.Checked = False
         End If
      End If
   End If
End Sub


Private Sub OnCaptionFontMenuClick(ByVal sender As Object, ByVal e As EventArgs)
   If Not (contextAnnotation Is Nothing) Then
      Dim fontDialog As New FontDialog
      Try
                If fontDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    contextAnnotation.CaptionFont = fontDialog.Font
                End If
      Finally
         fontDialog.Dispose()
      End Try

      contextAnnotation = Nothing
   End If
End Sub

End Class
