Public Class Login
    Dim f As New Functions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (f.Login(Username, Password)) Then

            If CheckBoxCred.Checked Then
                My.Settings.login_username = Username.Text
                My.Settings.login_password = Password.Text
            End If

            PanelControl.Show()
            Me.Visible = False
        Else
            MsgBox("Acceso no valido", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        Username.ForeColor = Color.FromArgb(36, 59, 121)
        Password.ForeColor = Color.FromArgb(36, 59, 121)
        Username.Text = My.Settings.login_username
        Password.Text = My.Settings.login_password
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Username_KeyDown(sender As Object, e As KeyEventArgs) Handles Username.KeyDown
        If e.KeyCode = Keys.Enter Then
            Username.Focus()
        End If

        If e.KeyCode = Keys.F12 Then
            OpenConfig()
        End If
    End Sub

    Private Sub OpenConfig()
        Me.Visible = False
        properties.Show()
    End Sub

    Private Sub Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
        If e.KeyCode = Keys.F12 Then
            OpenConfig()
        End If
    End Sub
End Class