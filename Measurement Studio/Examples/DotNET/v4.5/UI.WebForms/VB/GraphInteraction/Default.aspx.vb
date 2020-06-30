
Imports NationalInstruments
Imports NationalInstruments.UI
Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Class DefaultAspx
    Inherits Page

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)

        If Not IsPostBack Then
            graph.PlotY(GenerateData(1000))
        End If
    End Sub

    Protected Sub OnInteractionModeCheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim interactionMode As GraphWebInteractionModes = GraphWebInteractionModes.None

        If editRange.Checked Then
            interactionMode = interactionMode Or GraphWebInteractionModes.EditRange
        End If

        If zoomX.Checked Then
            interactionMode = interactionMode Or GraphWebInteractionModes.ZoomX
        End If

        If zoomY.Checked Then
            interactionMode = interactionMode Or GraphWebInteractionModes.ZoomY
        End If

        If zoomAroundPoint.Checked Then
            interactionMode = interactionMode Or GraphWebInteractionModes.ZoomAroundPoint
        End If

        graph.InteractionMode = interactionMode
    End Sub

    Private Shared Function GenerateData(ByVal dataLength As Integer) As Double()
        If dataLength < 0 Then
            Throw New ArgumentOutOfRangeException("dataLength", dataLength, "Data length must be positive.")
        End If

        Dim data(dataLength) As Double
        Dim rnd As New Random()

        For i As Integer = 0 To dataLength - 1
            data(i) = rnd.NextDouble() * Math.Sin((i / 3.15))
        Next

        Return data
    End Function
End Class