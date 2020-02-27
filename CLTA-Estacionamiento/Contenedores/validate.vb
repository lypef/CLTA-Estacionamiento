Public Class validate
    Dim f As New Functions

    Private Sub validate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If f.ValidarLicence(TextBox1) Then
            My.Settings.validate = True
            My.Settings.licencia = TextBox1.Text
            My.Settings.Save()
            MsgBox("Licencia activada con exito.", MsgBoxStyle.Information)
            Login.Visible = True
            Me.Dispose()
        Else
            MsgBox("Licencia no valida, contactenos.", MsgBoxStyle.Critical)
            Button1.Enabled = True
        End If
    End Sub
End Class