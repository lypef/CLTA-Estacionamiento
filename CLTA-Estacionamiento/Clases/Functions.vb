Public Class Functions
    Dim Db As New Conexion
    Shared Db_shared As New Conexion

    'Numeros de alerta
    Public ReadOnly Alert_NumberInformacion As Integer = 64
    Public ReadOnly Alert_NumberCritical As Integer = 16
    Public ReadOnly Alert_NumberExclamacion As Integer = 48

    'Informacion de usuario
    Public Shared username_id As String
    Public Shared username_username As String
    Public Shared username_name As String

    Public Sub Alert(ByVal txt As String, ByVal style As Integer)
        AlertContainer.Show()
        AlertContainer.style(style)
        AlertContainer.TextBoxMensaje.Text = txt.ToUpper()
    End Sub

    Public Sub forms_setmodel(ByVal form As Form)
        'form.Text = ReturnEmpresa_Parametros(Empresa_Nombre) + " - USUARIO: " + ReturnNameID(userID)
        form.Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
        form.FormBorderStyle = FormBorderStyle.FixedSingle
        form.MaximizeBox = True
        form.MaximumSize = New Size(form.Width, form.Height)
        form.MinimumSize = New Size(form.Width, form.Height)
    End Sub

    Public Function Login(ByVal username As TextBox, ByVal password As TextBox)
        Dim r = False
        Dim dato = Db.Consult("select id, username, name from users where username = '" + username.Text + "' and password = '" + password.Text + "' ")

        If dato.hasrows Then

            Do While dato.Read()
                username_id = dato.GetString(0)
                username_username = dato.GetString(1)
                username_name = dato.GetString(2)
                r = True
            Loop
        Else
            r = False
        End If

        Return r
    End Function

    Public Sub AddForm_Desktop(ByVal form As Form, ByVal Desktop As Panel)
        form.TopLevel = False
        Desktop.Controls.Add(form)
        form.Location = New Point((Desktop.Width - form.Width) / 2, (Desktop.Height - form.Height) / 2)
        form.BringToFront()
        form.Show()
    End Sub

End Class
