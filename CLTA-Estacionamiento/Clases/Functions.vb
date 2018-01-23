Imports System.Security.Cryptography

Public Class Functions
    Dim Db As New Conexion
    Shared Db_shared As New Conexion

    'Variables permisos de usuario
    Public ReadOnly Permiso_Cliet_Access As String = "client_access"

    'Numeros de alerta
    Public ReadOnly Alert_NumberInformacion As Integer = 64
    Public ReadOnly Alert_NumberCritical As Integer = 16
    Public ReadOnly Alert_NumberExclamacion As Integer = 48

    'Numeros de alerta
    Public ReadOnly Alert_PermisoNOAutorizado As String = "Permiso no autorizado"

    'Informacion de usuario
    Public Shared username_id As String
    Public Shared username_username As String

    Public Sub loadforms(desktop As Panel)
        AddForm_Desktop(Clientes, desktop)
        desktop.Controls.Clear()
    End Sub

    Public Shared username_name As String

    Public Sub Alert(ByVal txt As String, ByVal style As Integer, ByVal desktop As Panel)
        AlertContainer.style(style)
        AlertContainer.TextBoxMensaje.Text = txt.ToUpper()
        AddForm_Desktop(AlertContainer, desktop)
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
        Dim dato = Db.Consult("select id, username, name from users where username = '" + username.Text + "' and password = '" + EncriptMD5(password.Text) + "' ")

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
        form.FormBorderStyle = FormBorderStyle.None
        form.WindowState = FormWindowState.Normal
        form.Location = New Point((Desktop.Width - form.Width) / 2, (Desktop.Height - form.Height) / 2)
        form.BringToFront()
        form.Show()
    End Sub

    Public Function GetPermiso(ByVal campo As String) As Boolean
        Dim r = False
        Dim dato = Db.Consult("select " + campo + " from permissions where user =  '" + username_id + "'  ")

        If dato.Read() Then
            r = dato.GetBoolean(0)
        End If

        Return r
    End Function

    Private Function EncriptMD5(ByVal password As String) As String
        Dim PasConMd5 = ""
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer

        bytValue = System.Text.Encoding.UTF8.GetBytes(password.Replace(" ", ""))

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            PasConMd5 &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next

        Return PasConMd5
    End Function

End Class
