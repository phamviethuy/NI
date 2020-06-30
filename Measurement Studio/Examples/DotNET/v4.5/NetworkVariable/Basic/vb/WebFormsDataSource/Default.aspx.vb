
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub AutoRefresh1_Refresh(ByVal sender As Object, ByVal e As NationalInstruments.UI.RefreshEventArgs) Handles AutoRefresh1.Refresh
        WaveformGraph1.PlotY(CType(NetworkVariableDataSource1.Bindings(0).GetValue(), Double()))
        Tank1.Value = CType(NetworkVariableDataSource1.Bindings(1).GetValue(), Double)
    End Sub
End Class
