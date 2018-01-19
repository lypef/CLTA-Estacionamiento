Public Class PanelControl
    Dim f As New Functions
    Private Sub PanelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        f.Button_SetModel(BtnClientes, My.Resources.BtnClients_yellow)
    End Sub

    Private Sub BtnClientes_MouseEnter(sender As Object, e As EventArgs) Handles BtnClientes.MouseEnter
        f.Button_SetModel(BtnClientes, My.Resources.BtnClients_green)
    End Sub

    Private Sub BtnClientes_MouseLeave(sender As Object, e As EventArgs) Handles BtnClientes.MouseLeave
        f.Button_SetModel(BtnClientes, My.Resources.BtnClients_yellow)
    End Sub
End Class