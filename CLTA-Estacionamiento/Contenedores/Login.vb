Public Class Login
    Dim f As New Functions

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If f.Login(Username, Password) Then
            PanelControl.Show()
            Me.Visible = False
        End If
    End Sub
End Class