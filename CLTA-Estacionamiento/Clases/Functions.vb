Imports System.Security.Cryptography

Public Class Functions
    Dim Db As New Conexion
    Shared Db_shared As New Conexion

    'Variables de sistema
    Public Shared Client As String

    'Variables permisos de usuario
    Public ReadOnly Permiso_Cliet_Access As String = "client_access"
    Public ReadOnly Permiso_Cliet_Add As String = "client_add"
    Public ReadOnly Permiso_Cliet_Edit As String = "client_edit"
    Public ReadOnly Permiso_Cliet_Delete As String = "client_delete"

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
        AddForm_Desktop(properties, desktop)
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

    Private Sub DataGridView_Model(ByVal d As DataGridView)
        d.RowHeadersVisible = False
        d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        d.AlternatingRowsDefaultCellStyle.BackColor = My.Settings.datagridview_color
        d.DefaultCellStyle.SelectionBackColor = My.Settings.datagridview_selectrow
        d.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        d.DefaultCellStyle.Font = My.Settings.text_font
        d.AllowUserToResizeRows = False
        d.ReadOnly = True
        d.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        d.DefaultCellStyle.WrapMode = DataGridViewTriState.True
        d.Font = My.Settings.text_font
    End Sub

    Public Sub GetClients(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("name", "Nombre")
        t.Columns.Add("address", "Direccion")
        t.Columns.Add("phone", "Telefono")
        t.Columns.Add("mail", "Correo electronico")
        t.Columns.Add("rfc", "Rfc")
        t.Columns.Add("razonsocial", "Razon social")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6))
            Loop
        End If

    End Sub

    Public Shared Function Clients_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from clients where id = " + Client + " ")
    End Function
End Class
