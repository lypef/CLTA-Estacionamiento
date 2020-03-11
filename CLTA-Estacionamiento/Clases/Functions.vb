Imports System.ComponentModel
Imports System.Drawing.Printing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Windows.Documents

Public Class Functions
    Dim Db As New Conexion
    Shared Db_shared As New Conexion
    Dim Licence As New validateLicence

    'Listas
    Dim ListClients As New List(Of Integer)
    Dim ListTarifas As New List(Of Integer)
    Dim ListVehiclesActivos As New List(Of String)

    'Rutas data
    Public Shared ReadOnly Data_clients As String = "\clients"
    Public Shared ReadOnly Data_reports As String = "\reports"
    Public Shared ReadOnly Data_drivers As String = "\drivers"
    Public Shared ReadOnly Data_products As String = "\products"
    Public Shared ReadOnly Data_Clients_ImgDefault As String = "\default.png"

    'Variables de sistema
    Public Shared Client As String
    Public Shared Matricula As String
    Public Shared VTD_Codebar As String
    Public Shared Tarifa As String
    Public Shared Select_VehiclesMatricula As String
    Public Shared User As String

    'Variables permisos de usuario
    Public ReadOnly Permiso_Cliet_Access As String = "client_access"
    Public ReadOnly Permiso_Cliet_Add As String = "client_add"
    Public ReadOnly Permiso_Cliet_Edit As String = "client_edit"
    Public ReadOnly Permiso_Cliet_Delete As String = "client_delete"
    Public ReadOnly Permiso_Vehicle_Access As String = "vehicle_access"
    Public ReadOnly Permiso_Vehicle_Add As String = "vehicle_add"
    Public ReadOnly Permiso_Vehicle_Edit As String = "vehicle_edit"
    Public ReadOnly Permiso_Vehicle_Delete As String = "vehicle_delete"
    Public ReadOnly Permiso_Rate_Access As String = "rate_access"
    Public ReadOnly Permiso_Rate_Add As String = "rate_add"
    Public ReadOnly Permiso_Rate_Edit As String = "rate_edit"
    Public ReadOnly Permiso_Rate_Delete As String = "rate_delete"
    Public ReadOnly Permiso_Assign_Access As String = "assign_access"
    Public ReadOnly Permiso_Vtd_access As String = "vtd_access"
    Public ReadOnly Permiso_Vtd_Add As String = "vtd_add"
    Public ReadOnly Permiso_Vtd_Edit As String = "vtd_edit"
    Public ReadOnly Permiso_Vtd_Delete As String = "vtd_delete"
    Public ReadOnly Permiso_ventas_access As String = "ventas_access"
    Public ReadOnly Permiso_User_access As String = "user_access"
    Public ReadOnly Permiso_User_Add As String = "user_add"
    Public ReadOnly Permiso_User_Edit As String = "user_edit"
    Public ReadOnly Permiso_User_Delete As String = "user_delete"
    Public ReadOnly Permiso_cutX As String = "cut_x"
    Public ReadOnly Permiso_cutZ As String = "cut_z"

    'Numeros de alerta
    Public ReadOnly Alert_NumberInformacion As Integer = 64
    Public ReadOnly Alert_NumberCritical As Integer = 16
    Public ReadOnly Alert_NumberExclamacion As Integer = 48

    'Numeros de alerta
    Public ReadOnly Alert_PermisoNOAutorizado As String = "Permiso no autorizado"

    'Informacion de usuario
    Public Shared username_id As String
    Public Shared username_username As String

    'Var estaticas
    Public NumeroRele As Integer = 0

    Public Sub loadforms(desktop As Panel)
        AddForm_Desktop(Clientes, desktop)
        AddForm_Desktop(properties, desktop)
        AddForm_Desktop(Vehicles, desktop)
        AddForm_Desktop(Rate, desktop)
        AddForm_Desktop(Assignments, desktop)
        AddForm_Desktop(EnterExitControl, desktop)
        AddForm_Desktop(Adeudos, desktop)
        AddForm_Desktop(VentaDirecta, desktop)
        AddForm_Desktop(Ventas, desktop)
        AddForm_Desktop(EditProducts, desktop)
        AddForm_Desktop(OpenBarrNum, desktop)
        AddForm_Desktop(R_ticket, desktop)
        AddForm_Desktop(EntradaVehiculoGenerico, desktop)
        AddForm_Desktop(ReaderPdf, desktop)
        desktop.Controls.Clear()
    End Sub

    Public Shared username_name As String

    Public Sub Alert(ByVal txt As String, ByVal style As Integer, ByVal desktop As Panel)
        AlertContainer.style(style)
        AlertContainer.TextBoxMensaje.Text = txt.ToUpper()
        AddForm_Desktop(AlertContainer, desktop)
        AlertContainer.WindowState = FormWindowState.Normal
    End Sub

    Public Sub forms_setmodel(ByVal form As Form, ByVal border As FormBorderStyle)
        'form.Text = ReturnEmpresa_Parametros(Empresa_Nombre) + " - USUARIO: " + ReturnNameID(userID)
        form.Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
        form.FormBorderStyle = border
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
        form.Location = New Point((Desktop.Width - form.Width) / 2, (Desktop.Height - form.Height) / 2)
        form.BringToFront()
        form.Show()
        form.Focus()

        If My.Settings.form_windowstate = 1 Then
            form.WindowState = FormWindowState.Normal
        ElseIf My.Settings.form_windowstate = 2 Then
            form.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Public Function AddVenta(id_cliente As Integer, concepto As String, monto As Double, ticket As Integer) As Boolean
        Return Db.Ejecutar("INSERT INTO ventas (id_cliente, id_usuario, id_ticket, concepto, monto, date, producto, service, membresia, cut_x, cut_z) VALUES ('" + id_cliente.ToString + "', '" + username_id.ToString + "', '" + ticket.ToString + "', '" + concepto.ToUpper + "', '" + monto.ToString + "', '" + GetDateString(DateTime.Now) + "', '0', '0', '1' , '0', '0');")
    End Function

    Public Sub LoadValuesUser(nombre As TextBox, username As TextBox, list As CheckedListBox)
        Dim dato = Db.Consult("SELECT * from users u, permissions p where p.user = u.id and u.id = '" + User + "' ")

        If dato.Read() Then
            nombre.Text = dato.GetString(3)
            username.Text = dato.GetString(1)
            list.SetItemChecked(0, dato.GetBoolean(0 + 5))
            list.SetItemChecked(1, dato.GetBoolean(1 + 5))
            list.SetItemChecked(2, dato.GetBoolean(2 + 5))
            list.SetItemChecked(3, dato.GetBoolean(3 + 5))
            list.SetItemChecked(4, dato.GetBoolean(4 + 5))
            list.SetItemChecked(5, dato.GetBoolean(5 + 5))
            list.SetItemChecked(6, dato.GetBoolean(6 + 5))
            list.SetItemChecked(7, dato.GetBoolean(7 + 5))
            list.SetItemChecked(8, dato.GetBoolean(8 + 5))
            list.SetItemChecked(9, dato.GetBoolean(9 + 5))
            list.SetItemChecked(10, dato.GetBoolean(10 + 5))
            list.SetItemChecked(11, dato.GetBoolean(11 + 5))
            list.SetItemChecked(12, dato.GetBoolean(12 + 5))
            list.SetItemChecked(13, dato.GetBoolean(13 + 5))
            list.SetItemChecked(14, dato.GetBoolean(14 + 5))
            list.SetItemChecked(15, dato.GetBoolean(15 + 5))
            list.SetItemChecked(16, dato.GetBoolean(16 + 5))
            list.SetItemChecked(17, dato.GetBoolean(17 + 5))
            list.SetItemChecked(18, dato.GetBoolean(18 + 5))
            list.SetItemChecked(19, dato.GetBoolean(19 + 5))
            list.SetItemChecked(20, dato.GetBoolean(20 + 5))
            list.SetItemChecked(21, dato.GetBoolean(21 + 5))
            list.SetItemChecked(22, dato.GetBoolean(22 + 5))
            list.SetItemChecked(23, dato.GetBoolean(23 + 5))
        End If
    End Sub

    Public Function AddUser(nombre As TextBox, username As TextBox, password As TextBox) As Boolean
        Return Db.Ejecutar("INSERT INTO users (username, password, name) VALUES ('" + username.Text + "', '" + EncriptMD5(password.Text) + "', '" + nombre.Text + "')")
    End Function

    Public Function UpdateUser(nombre As TextBox, username As TextBox, password As TextBox) As Boolean
        If String.IsNullOrEmpty(password.Text) Then
            Return Db.Ejecutar("UPDATE users SET username = '" + username.Text + "', name = '" + nombre.Text + "' WHERE id = '" + User + "' ")
        Else
            Return Db.Ejecutar("UPDATE users SET username = '" + username.Text + "', name = '" + nombre.Text + "', password = '" + EncriptMD5(password.Text) + "' WHERE id = '" + User + "' ")
        End If
    End Function

    Public Function AddUser_permisos(ByVal id As Integer, list As CheckedListBox) As Boolean
        Dim _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23 As Boolean
        For i As Integer = 0 To list.Items.Count - 1
            If i = 0 Then
                _0 = list.GetItemChecked(i)
            ElseIf i = 1 Then
                _1 = list.GetItemChecked(i)
            ElseIf i = 2 Then
                _2 = list.GetItemChecked(i)
            ElseIf i = 3 Then
                _3 = list.GetItemChecked(i)
            ElseIf i = 4 Then
                _4 = list.GetItemChecked(i)
            ElseIf i = 5 Then
                _5 = list.GetItemChecked(i)
            ElseIf i = 6 Then
                _6 = list.GetItemChecked(i)
            ElseIf i = 7 Then
                _7 = list.GetItemChecked(i)
            ElseIf i = 8 Then
                _8 = list.GetItemChecked(i)
            ElseIf i = 9 Then
                _9 = list.GetItemChecked(i)
            ElseIf i = 10 Then
                _10 = list.GetItemChecked(i)
            ElseIf i = 11 Then
                _11 = list.GetItemChecked(i)
            ElseIf i = 12 Then
                _12 = list.GetItemChecked(i)
            ElseIf i = 13 Then
                _13 = list.GetItemChecked(i)
            ElseIf i = 14 Then
                _14 = list.GetItemChecked(i)
            ElseIf i = 15 Then
                _15 = list.GetItemChecked(i)
            ElseIf i = 16 Then
                _16 = list.GetItemChecked(i)
            ElseIf i = 17 Then
                _17 = list.GetItemChecked(i)
            ElseIf i = 18 Then
                _18 = list.GetItemChecked(i)
            ElseIf i = 19 Then
                _19 = list.GetItemChecked(i)
            ElseIf i = 20 Then
                _20 = list.GetItemChecked(i)
            ElseIf i = 21 Then
                _21 = list.GetItemChecked(i)
            ElseIf i = 22 Then
                _22 = list.GetItemChecked(i)
            ElseIf i = 23 Then
                _23 = list.GetItemChecked(i)
            End If
        Next i
        Return Db.Ejecutar("INSERT INTO permissions (user, client_access, client_add, client_edit, client_delete, vehicle_access, vehicle_add, vehicle_edit, vehicle_delete, rate_access, rate_add, rate_edit, rate_delete, assign_access, vtd_access, vtd_add, vtd_edit, vtd_delete, ventas_access, user_access, user_add, user_edit, user_delete, cut_x, cut_z) VALUES ('" + id.ToString + "', '" + ReturnBooleanINT_String(_0) + "', '" + ReturnBooleanINT_String(_1) + "', '" + ReturnBooleanINT_String(_2) + "', '" + ReturnBooleanINT_String(_3) + "', '" + ReturnBooleanINT_String(_4) + "', '" + ReturnBooleanINT_String(_5) + "', '" + ReturnBooleanINT_String(_6) + "', '" + ReturnBooleanINT_String(_7) + "', '" + ReturnBooleanINT_String(_8) + "', '" + ReturnBooleanINT_String(_9) + "', '" + ReturnBooleanINT_String(_10) + "', '" + ReturnBooleanINT_String(_11) + "', '" + ReturnBooleanINT_String(_12) + "', '" + ReturnBooleanINT_String(_13) + "', '" + ReturnBooleanINT_String(_14) + "', '" + ReturnBooleanINT_String(_15) + "', '" + ReturnBooleanINT_String(_16) + "', '" + ReturnBooleanINT_String(_17) + "', '" + ReturnBooleanINT_String(_18) + "', '" + ReturnBooleanINT_String(_19) + "', '" + ReturnBooleanINT_String(_20) + "', '" + ReturnBooleanINT_String(_21) + "', '" + ReturnBooleanINT_String(_22) + "', '" + ReturnBooleanINT_String(_23) + "')")
        Return True
    End Function

    Public Function UpdateUser_permisos(list As CheckedListBox) As Boolean
        Dim _0, _1, _2, _3, _4, _5, _6, _7, _8, _9, _10, _11, _12, _13, _14, _15, _16, _17, _18, _19, _20, _21, _22, _23 As Boolean

        For i As Integer = 0 To list.Items.Count - 1
            If i = 0 Then
                _0 = list.GetItemChecked(i)
            ElseIf i = 1 Then
                _1 = list.GetItemChecked(i)
            ElseIf i = 2 Then
                _2 = list.GetItemChecked(i)
            ElseIf i = 3 Then
                _3 = list.GetItemChecked(i)
            ElseIf i = 4 Then
                _4 = list.GetItemChecked(i)
            ElseIf i = 5 Then
                _5 = list.GetItemChecked(i)
            ElseIf i = 6 Then
                _6 = list.GetItemChecked(i)
            ElseIf i = 7 Then
                _7 = list.GetItemChecked(i)
            ElseIf i = 8 Then
                _8 = list.GetItemChecked(i)
            ElseIf i = 9 Then
                _9 = list.GetItemChecked(i)
            ElseIf i = 10 Then
                _10 = list.GetItemChecked(i)
            ElseIf i = 11 Then
                _11 = list.GetItemChecked(i)
            ElseIf i = 12 Then
                _12 = list.GetItemChecked(i)
            ElseIf i = 13 Then
                _13 = list.GetItemChecked(i)
            ElseIf i = 14 Then
                _14 = list.GetItemChecked(i)
            ElseIf i = 15 Then
                _15 = list.GetItemChecked(i)
            ElseIf i = 16 Then
                _16 = list.GetItemChecked(i)
            ElseIf i = 17 Then
                _17 = list.GetItemChecked(i)
            ElseIf i = 18 Then
                _18 = list.GetItemChecked(i)
            ElseIf i = 19 Then
                _19 = list.GetItemChecked(i)
            ElseIf i = 20 Then
                _20 = list.GetItemChecked(i)
            ElseIf i = 21 Then
                _21 = list.GetItemChecked(i)
            ElseIf i = 22 Then
                _22 = list.GetItemChecked(i)
            ElseIf i = 23 Then
                _23 = list.GetItemChecked(i)
            End If
        Next i
        Return Db.Ejecutar("UPDATE permissions SET client_access = '" + ReturnBooleanINT_String(_0) + "', client_add = '" + ReturnBooleanINT_String(_1) + "', client_edit = '" + ReturnBooleanINT_String(_2) + "', client_delete = '" + ReturnBooleanINT_String(_3) + "', vehicle_access = '" + ReturnBooleanINT_String(_4) + "', vehicle_add = '" + ReturnBooleanINT_String(_5) + "', vehicle_edit = '" + ReturnBooleanINT_String(_6) + "', vehicle_delete = '" + ReturnBooleanINT_String(_7) + "', rate_access = '" + ReturnBooleanINT_String(_8) + "', rate_add = '" + ReturnBooleanINT_String(_9) + "', rate_edit = '" + ReturnBooleanINT_String(_10) + "', rate_delete = '" + ReturnBooleanINT_String(_11) + "', assign_access = '" + ReturnBooleanINT_String(_12) + "', vtd_access = '" + ReturnBooleanINT_String(_13) + "', vtd_add = '" + ReturnBooleanINT_String(_14) + "', vtd_edit = '" + ReturnBooleanINT_String(_15) + "', vtd_delete = '" + ReturnBooleanINT_String(_16) + "', ventas_access = '" + ReturnBooleanINT_String(_17) + "', user_access = '" + ReturnBooleanINT_String(_18) + "', user_add = '" + ReturnBooleanINT_String(_19) + "', user_edit = '" + ReturnBooleanINT_String(_20) + "', user_delete = '" + ReturnBooleanINT_String(_21) + "', cut_x = '" + ReturnBooleanINT_String(_22) + "', cut_z = '" + ReturnBooleanINT_String(_23) + "' where user = '" + User + "' ")
        Return True
    End Function

    Private Function ReturnBooleanINT_String(ByVal val As Boolean) As String
        If val Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function GetLastUser() As Integer
        Dim r = 0
        Dim dato = Db.Consult("SELECT MAX(id) FROM users")

        If dato.Read() Then
            r = dato.GetString(0)
        End If

        Return r
    End Function

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
        d.MultiSelect = False
    End Sub

    Public Sub Tarifa_LoadValues(txtNombreEdit As TextBox, txtMinToleEdit As TextBox, txtCostoMinEdit As TextBox, txtPrecioHoraEdit As TextBox, txtPrecioDiaEdit As TextBox, useFraccionesEdit As CheckBox, tarifaPension As TextBox, pensiondias As TextBox, HorasXdia As TextBox)
        Dim dato = Db_shared.Consult("select * from tarifas where id =  '" + Tarifa + "'  ")

        If dato.Read() Then
            txtNombreEdit.Text = dato.GetString(1)
            txtMinToleEdit.Text = dato.GetString(2)
            txtCostoMinEdit.Text = dato.GetString(3)
            txtPrecioHoraEdit.Text = dato.GetString(4)
            txtPrecioDiaEdit.Text = dato.GetString(5)
            tarifaPension.Text = dato.GetString(6)
            pensiondias.Text = dato.GetString(7)
            useFraccionesEdit.Checked = dato.GetBoolean(8)
            HorasXdia.Text = dato.GetString(9)
        End If
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

    Public Function GetVentas(ByVal sql As String, ByVal t As DataGridView, F_desde As DateTimePicker, f_hasta As DateTimePicker) As Decimal
        Dim total As Decimal
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("client", "CLIENTE")
        t.Columns.Add("id_usuario", "ATENDIO")
        t.Columns.Add("ticket", "TICKET")
        t.Columns.Add("concepto", "CONCEPTO")
        t.Columns.Add("monto", "MONTO")
        t.Columns.Add("date", "FECHA")

        Dim tmp1 = New DateTime(F_desde.Value.Year, F_desde.Value.Month, F_desde.Value.Day, 0, 0, 0)
        F_desde.Value = tmp1
        Dim tmp2 = New DateTime(f_hasta.Value.Year, f_hasta.Value.Month, f_hasta.Value.Day, 23, 59, 59)
        f_hasta.Value = tmp2

        If dato.HasRows Then
            Do While dato.Read()
                Dim FechaDB = New DateTime()
                FechaDB = Convert.ToDateTime(dato.GetString(6))

                If FechaDB.CompareTo(Convert.ToDateTime(F_desde.Value)) >= 0 And FechaDB.CompareTo(Convert.ToDateTime(f_hasta.Value)) <= 0 Then
                    total += Decimal.Parse(dato.GetString(5))
                    t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6))
                End If
            Loop
        End If
        Return total
    End Function

    Public Function UpdateCutX() As Boolean
        Return Db.Ejecutar("UPDATE ventas SET cut_x = '1' WHERE id_usuario = '" + username_id.ToString + "' ")
    End Function

    Public Function UpdateCutZGeneral() As Boolean
        Return Db.Ejecutar("UPDATE ventas SET cut_z = '1' ")
    End Function

    Public Function GetCut(ByVal t As DataGridView) As Decimal
        Dim total As Decimal
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult("SELECT v.id, c.name, u.name, v.id_ticket, v.concepto, v.monto, v.date FROM ventas v, clients c, users u WHERE v.id_cliente = c.id and v.id_usuario = u.id and v.cut_x = 0 and v.id_usuario = '" + username_id.ToString + "' ")

        t.Columns.Add("id", "ID")
        t.Columns.Add("client", "CLIENTE")
        t.Columns.Add("id_usuario", "ATENDIO")
        t.Columns.Add("ticket", "TICKET")
        t.Columns.Add("concepto", "CONCEPTO")
        t.Columns.Add("monto", "MONTO")
        t.Columns.Add("date", "FECHA")

        If dato.HasRows Then
            Do While dato.Read()
                total += Decimal.Parse(dato.GetString(5))
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6))
            Loop
        End If
        Return total
    End Function

    Public Function GetCutGeneral(ByVal t As DataGridView) As Decimal
        Dim total As Decimal
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult("SELECT v.id, c.name, u.name, v.id_ticket, v.concepto, v.monto, v.date FROM ventas v, clients c, users u WHERE v.id_cliente = c.id and v.id_usuario = u.id and v.cut_z = 0 ")

        t.Columns.Add("id", "ID")
        t.Columns.Add("client", "CLIENTE")
        t.Columns.Add("id_usuario", "ATENDIO")
        t.Columns.Add("ticket", "TICKET")
        t.Columns.Add("concepto", "CONCEPTO")
        t.Columns.Add("monto", "MONTO")
        t.Columns.Add("date", "FECHA")

        If dato.HasRows Then
            Do While dato.Read()
                total += Decimal.Parse(dato.GetString(5))
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6))
            Loop
        End If
        Return total
    End Function

    Public Sub GetProducts(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult(sql)

        t.Columns.Add("codebar", "Codigo")
        t.Columns.Add("name", "Nombre")
        t.Columns.Add("description", "Descripcion")
        t.Columns.Add("price", "Precio")
        t.Columns.Add("Stock", "Stock")
        t.Columns.Add("vendidos", "Vendidos")
        t.Columns.Add("service", "Tipo")

        If dato.HasRows Then
            Do While dato.Read()
                If dato.GetBoolean(7) Then
                    t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), "SERVICIO")
                Else
                    t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), "PRODUCTO")
                End If

            Loop
        End If

    End Sub

    Public Sub GetTarifas(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("name", "Nombre")
        t.Columns.Add("tolerancia", "Tolerancia")
        t.Columns.Add("cminimo", "Costo minimo")
        t.Columns.Add("price_hora", "Precio X hora")
        t.Columns.Add("price_dia", "Precio X dia")
        t.Columns.Add("price_pension", "Precio X pension")
        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2) + " Minutos", dato.GetString(3) + " " + My.Settings.moneda, dato.GetString(4) + " " + My.Settings.moneda, dato.GetString(5) + " " + My.Settings.moneda + "( " + dato.GetString(9) + " HORAS)", dato.GetString(6) + " " + My.Settings.moneda + "( " + dato.GetString(7) + " DIAS)")
            Loop
        End If

    End Sub

    Public Function AddVehicle(txtName As TextBox, txtMinTolerancia As TextBox, txtCostoMinimo As TextBox, txtPrcieXHora As TextBox, txtPrcieXDia As TextBox, usarFracciones As CheckBox, tarifaPension As TextBox, diasPension As TextBox, horasxdia As TextBox) As Boolean
        Return Db.Ejecutar("INSERT INTO tarifas (name, tolerance_minutes, costo_minimo, price_hora, price_dia, use_fraccion, price_pension, dias_pencion, horas_dias ) VALUES ('" + txtName.Text.ToString.ToUpper + "', '" + txtMinTolerancia.Text.ToString + "', '" + txtCostoMinimo.Text.ToString + "', '" + txtPrcieXHora.Text.ToString + "', '" + txtPrcieXDia.Text.ToString + "', '" + ReturnCheckBox(usarFracciones).ToString + "', '" + tarifaPension.Text + "', '" + diasPension.Text + "', '" + horasxdia.Text + "');")
    End Function

    Public Sub GetVehicles(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult(sql)

        t.Columns.Add("matricula", "Matricula")
        t.Columns.Add("client", "Cliente")
        t.Columns.Add("tarif", "Tarifa")
        t.Columns.Add("modelo", "Modelo")
        t.Columns.Add("color", "Color")
        t.Columns.Add("estado", "Estado")
        t.Columns.Add("f_salida", "Fecha salida")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(1), dato.GetString(2), dato.GetString(3), dato.GetString(4), dato.GetString(5), dato.GetString(6))
            Loop
        End If

    End Sub

    Public Sub GetUsers(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "ID")
        t.Columns.Add("nombre", "Nombre")
        t.Columns.Add("username", "Username")
        t.Columns.Add("password", "Contraseña")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), dato.GetString(3), dato.GetString(1), dato.GetString(2))
            Loop
        End If

    End Sub

    Public Sub GetVtdVehicles(ByVal sql As String, ByVal t As DataGridView)
        t.Columns.Clear()
        t.Rows.Clear()
        DataGridView_Model(t)

        Dim dato = Db.Consult(sql)

        t.Columns.Add("id", "Id")
        t.Columns.Add("nombre", "Articulo")
        t.Columns.Add("price", "Precio")

        If dato.HasRows Then
            Do While dato.Read()
                t.Rows.Add(dato.GetString(0), "(1) " + dato.GetString(1), dato.GetString(2) + " " + My.Settings.moneda)
            Loop
        End If

    End Sub

    Public Function UpdateRate(txtNombreEdit As TextBox, txtMinToleEdit As TextBox, txtCostoMinEdit As TextBox, txtPrecioHoraEdit As TextBox, txtPrecioDiaEdit As TextBox, useFraccionesEdit As CheckBox, TxtPricePension As TextBox, DiasPension As TextBox, TxtHoursXDiaEdit As TextBox) As Boolean
        Return Db.Ejecutar("UPDATE tarifas SET name = '" + txtNombreEdit.Text.ToUpper + "', tolerance_minutes = '" + txtMinToleEdit.Text + "', costo_minimo = '" + txtCostoMinEdit.Text + "', price_hora = '" + txtPrecioHoraEdit.Text + "', price_dia = '" + txtPrecioDiaEdit.Text + "', use_fraccion = '" + ReturnCheckBox(useFraccionesEdit).ToString + "', price_pension = '" + TxtPricePension.Text + "', dias_pencion  = '" + DiasPension.Text + "', horas_dias   = '" + TxtHoursXDiaEdit.Text + "' WHERE id = '" + Tarifa + "' ")
    End Function

    Public Sub Vehicle_LoadValues(matriculaTextBoxEdit As TextBox, modeloTextBoxEdit As TextBox, colorTextBoxEdit As TextBox, estadoTextboxEdit As TextBox, c As ComboBox, tarifa As ComboBox, Rfid As TextBox)
        Dim dato = Db.Consult("SELECT * FROM vehicles WHERE matricula = '" + Matricula + "' ")

        If dato.Read() Then
            For i As Integer = 0 To ListClients.Count - 1
                If dato.GetString(1) = ListClients.Item(i) Then
                    c.SelectedIndex = i
                End If
            Next i

            For i As Integer = 0 To ListTarifas.Count - 1
                If dato.GetString(2) = ListTarifas.Item(i) Then
                    tarifa.SelectedIndex = i
                End If
            Next i

            matriculaTextBoxEdit.Text = dato.GetString(0)
            modeloTextBoxEdit.Text = dato.GetString(3)
            colorTextBoxEdit.Text = dato.GetString(4)
            estadoTextboxEdit.Text = dato.GetString(5)
            Rfid.Text = dato.GetString(6)
        End If
    End Sub

    Public Sub Vtd_LoadValues(ByVal TxtCode As TextBox, ByVal TxtNombre As TextBox, ByVal TxtDescripcion As TextBox, ByVal TxtPrecio As TextBox, ByVal Service As CheckBox, ByVal stock As NumericUpDown, ByRef urlImage As String, imagen As PictureBox, ByRef urlImage_new As String)
        Dim dato = Db.Consult("SELECT * FROM product_services WHERE codebar = '" + VTD_Codebar + "' ")

        If dato.Read() Then
            TxtCode.Text = dato.GetString(0)
            TxtNombre.Text = dato.GetString(1)
            TxtDescripcion.Text = dato.GetString(2)
            TxtPrecio.Text = dato.GetString(3)
            stock.Value = Convert.ToInt32(dato.GetString(4))
            urlImage = My.Settings.data_url + Data_products + dato.GetString(6)
            urlImage_new = urlImage
            If My.Computer.FileSystem.FileExists(urlImage) Then
                Dim fs As FileStream = New FileStream(urlImage, FileMode.Open, FileAccess.Read)
                imagen.Image = Image.FromStream(fs)
                PictureBoxSetModel(imagen)
                fs.Close()
            Else
                imagen.Image = Nothing
            End If
            Service.Checked = dato.GetBoolean(7)
        End If
    End Sub

    Public Sub Vehicle_LoadValuesAsignacion(p As PictureBox, c As ComboBox, Propietario As Label, LabelVehiculo As Label, horas As RadioButton, dias As RadioButton, pension As RadioButton, placas As Label, ByRef id_client As Integer)
        Dim dato = Db.Consult("SELECT v.matricula, v.tarifa, c.name, c.foto, v.modelo, v.color, v.tarifa_hora, v.tarifa_dia, v.tarifa_pension, c.id FROM vehicles v, clients c where v.client = c.id and matricula = '" + Matricula + "' ")

        If dato.Read() Then
            For i As Integer = 0 To ListTarifas.Count - 1
                If dato.GetString(1) = ListTarifas.Item(i) Then
                    c.SelectedIndex = i
                End If
            Next i

            If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + dato.GetString(3)) Then
                Dim fs As FileStream = New FileStream(My.Settings.data_url + Data_clients + dato.GetString(3), FileMode.Open, FileAccess.Read)
                p.Image = Image.FromStream(fs)
                PictureBoxSetModel(p)
                fs.Close()
            End If

            Propietario.Text = "PROPIETARIO: " + dato.GetString(2)
            LabelVehiculo.Text = "UNIDAD: " + dato.GetString(4) + " COLOR: " + dato.GetString(5)
            placas.Text = "MATRICULA: " + dato.GetString(0)

            If dato.GetBoolean(6) Then
                horas.Checked = True
            ElseIf dato.GetBoolean(7) Then
                dias.Checked = True
            ElseIf dato.GetBoolean(8) Then
                pension.Checked = True
            End If
            id_client = Convert.ToInt32(dato.GetString(9))
        End If
    End Sub

    Public Function AddVehicle(c As ComboBox, matricula_Textbox As TextBox, modeloTextBox As TextBox, color_Textbox As TextBox, estado_Textbox As TextBox, ComboTarifa As ComboBox, Rfid As TextBox) As Boolean
        Return Db.Ejecutar("INSERT INTO vehicles (client, matricula, modelo, color, estado, tarifa, rfid, tarifa_hora, fecha_ingreso, fecha_salida) VALUES ('" + ListClients.Item(c.SelectedIndex).ToString() + "', '" + matricula_Textbox.Text.ToUpper() + "', '" + modeloTextBox.Text.ToUpper() + "', '" + color_Textbox.Text.ToUpper() + "', '" + estado_Textbox.Text.ToUpper() + "', '" + ListTarifas.Item(ComboTarifa.SelectedIndex).ToString() + "', '" + Rfid.Text.ToString + "', '1', '" + GetDateString(DateTime.Now.AddDays(-1)) + "', '" + GetDateString(DateTime.Now.AddDays(-1)) + "')")
    End Function

    Public Function AddVehicle_Generico(matricula_Textbox As TextBox, modeloTextBox As TextBox, color_Textbox As TextBox, estado_Textbox As TextBox, ComboTarifa As ComboBox) As Boolean
        Return Db.Ejecutar("INSERT INTO vehicles (client, matricula, modelo, color, estado, tarifa, rfid, status, tarifa_hora, fecha_ingreso, fecha_salida) VALUES ('" + My.Settings.id_publicoGeneral.ToString + "', '" + matricula_Textbox.Text.ToUpper() + "', '" + modeloTextBox.Text.ToUpper() + "', '" + color_Textbox.Text.ToUpper() + "','" + estado_Textbox.Text.ToUpper() + "','" + ListTarifas.Item(ComboTarifa.SelectedIndex).ToString() + "', '0','1', '1', '" + GetDateString(DateTime.Now) + "', '" + GetDateString(DateTime.Now.AddDays(-1)) + "')")
    End Function

    Private Function ReturnRadioButon(r As RadioButton) As Integer
        Dim res = 0

        If r.Checked Then
            res = 1
        End If

        Return res
    End Function

    Private Function ReturnCheckBox(r As CheckBox) As Integer
        Dim res = 0

        If r.Checked Then
            res = 1
        End If

        Return res
    End Function

    Public Sub ComboboxSetClients(ByVal c As ComboBox)
        c.Items.Clear()
        ListClients.Clear()

        Dim dato = Db.Consult("SELECT id, name from clients ORDER by name asc")
        c.Items.Add("SELECCIONE UN CLIENTE")
        ListClients.Add("0")
        If dato.HasRows Then
            Do While dato.Read()
                ListClients.Add(dato.GetString(0))
                c.Items.Add(dato.GetString(1))
            Loop
        End If
        c.SelectedIndex = 0
        c.Font = My.Settings.text_font
    End Sub

    Public Sub ComboboxSetVehiclesActivos(ByVal c As ComboBox)
        c.Items.Clear()
        ListVehiclesActivos.Clear()

        Dim dato = Db.Consult("SELECT matricula, modelo from vehicles where status = 1 ORDER by modelo asc")
        c.Items.Add("VEHICULOS")
        ListVehiclesActivos.Add("0")
        If dato.HasRows Then
            Do While dato.Read()
                ListVehiclesActivos.Add(dato.GetString(0))
                c.Items.Add(dato.GetString(1))
            Loop
        End If
        c.SelectedIndex = 0
        c.Font = My.Settings.text_font
    End Sub

    Public Sub ComboboxSetTarifas(ByVal c As ComboBox)
        c.Items.Clear()
        ListTarifas.Clear()

        Dim dato = Db.Consult("SELECT id, name, price_hora, price_dia, price_pension , dias_pencion, horas_dias from tarifas ORDER by name asc")
        c.Items.Add("SELECCIONE UNA TARIFA")
        ListTarifas.Add("0")
        If dato.HasRows Then
            Do While dato.Read()
                ListTarifas.Add(dato.GetString(0))
                c.Items.Add(dato.GetString(1) + " - | X HORA " + dato.GetString(2) + " " + My.Settings.moneda + " | X DIA " + dato.GetString(3) + " " + My.Settings.moneda + " (" + dato.GetString(6) + " HORAS) | PENSION " + dato.GetString(4) + " " + My.Settings.moneda + " (" + dato.GetString(5) + " DIAS)")
            Loop
        End If

        If c.Items.Count > 0 Then
            c.SelectedIndex = 1
        Else
            c.SelectedIndex = 0
        End If

        c.Font = My.Settings.text_font
    End Sub

    Public Sub ComboboxSetIMGClient(ByVal c As ComboBox, ByVal p As PictureBox)
        If c.SelectedIndex > 0 And c.Items.Count > 0 Then
            Dim dato = Db.Consult("SELECT foto from clients where id = '" + ListClients.Item(c.SelectedIndex).ToString() + "' ")

            If dato.Read() Then
                If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + dato.GetString(0)) Then
                    Dim fs As FileStream = New FileStream(My.Settings.data_url + Data_clients + dato.GetString(0), FileMode.Open, FileAccess.Read)
                    p.Image = Image.FromStream(fs)
                    PictureBoxSetModel(p)
                    fs.Close()
                End If
            End If
        Else
            p.Image = Nothing
        End If
    End Sub

    Public Shared Function Clients_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from clients where id = " + Client + " ")
    End Function

    Public Shared Function User_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from users where id = " + User + " ")
    End Function

    Public Shared Function Rate_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from tarifas where id = " + Tarifa + " ")
    End Function

    Public Function Vehicle_Update(c As ComboBox, matriculaTextBoxEdit As TextBox, modeloTextBoxEdit As TextBox, colorTextBoxEdit As TextBox, estadoTextboxEdit As TextBox, ComboTarifa As ComboBox, Rfid As TextBox)
        Return Db.Ejecutar("UPDATE vehicles SET client = '" + ListClients.Item(c.SelectedIndex).ToString() + "', tarifa = '" + ListTarifas.Item(ComboTarifa.SelectedIndex).ToString() + "', matricula = '" + matriculaTextBoxEdit.Text.ToUpper + "', modelo = '" + modeloTextBoxEdit.Text.ToUpper + "', color = '" + colorTextBoxEdit.Text.ToUpper + "', estado = '" + estadoTextboxEdit.Text.ToUpper + "', rfid = " + Rfid.Text + " where matricula = '" + Matricula + "' ")
    End Function

    Public Function Vtd_Product_Update(ByVal TxtCode As TextBox, ByVal TxtNombre As TextBox, ByVal TxtDescripcion As TextBox, ByVal TxtPrecio As TextBox, ByVal Service As CheckBox, ByVal stock As NumericUpDown, ByVal foto As String, ByVal foto_edit As String) As Boolean
        Dim ServiceTmp As Integer = 0
        If Service.Checked Then
            ServiceTmp = 1
        End If

        If foto = foto_edit Then
            Return Db.Ejecutar("UPDATE product_services SET codebar = '" + TxtCode.Text + "', nombre = '" + TxtNombre.Text.ToUpper + "', descripcion = '" + TxtDescripcion.Text.ToUpper + "', precio = '" + TxtPrecio.Text + "', stock = '" + stock.Value.ToString + "', service = '" + ServiceTmp.ToString + "' WHERE codebar = '" + VTD_Codebar + "' ")
        Else
            Dim ruta As String
            ruta = "/" + username_id + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(foto_edit)
            ruta = ruta.Replace("\", "/")

            Try
                My.Computer.FileSystem.CopyFile(foto_edit, My.Settings.data_url + Data_products + ruta)
                If My.Computer.FileSystem.FileExists(foto) Then
                    My.Computer.FileSystem.DeleteFile(foto)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Return Db.Ejecutar("UPDATE product_services SET codebar = '" + TxtCode.Text + "', nombre = '" + TxtNombre.Text.ToUpper + "', descripcion = '" + TxtDescripcion.Text.ToUpper + "', precio = '" + TxtPrecio.Text + "', stock = '" + stock.Value.ToString + "', image = '" + ruta + "', service = '" + ServiceTmp.ToString + "' WHERE codebar = '" + VTD_Codebar + "' ")
        End If
    End Function

    Public Function Vehicle_Update_Horas(c As ComboBox)
        Return Db.Ejecutar("UPDATE vehicles SET tarifa = '" + ListTarifas.Item(c.SelectedIndex).ToString() + "', tarifa_hora = '1', tarifa_dia = '0', tarifa_pension = '0' where matricula = '" + Matricula + "' ")
    End Function

    Public Function Vehicle_Update_dias(c As ComboBox, f_exit As DateTime)
        Dim fechaActual = (DateTime.Now.Year.ToString + "-" + DateTime.Now.Month.ToString + "-" + DateTime.Now.Day.ToString + " " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString).ToString
        Dim fechaSalir = (f_exit.Year.ToString + "-" + f_exit.Month.ToString + "-" + f_exit.Day.ToString + " " + f_exit.Hour.ToString + ":" + f_exit.Minute.ToString + ":" + f_exit.Second.ToString).ToString
        Return Db.Ejecutar("UPDATE vehicles SET tarifa = '" + ListTarifas.Item(c.SelectedIndex).ToString() + "', tarifa_hora = '0', tarifa_dia = '1', tarifa_pension = '0', fecha_ingreso = '" + fechaActual + "', fecha_salida = '" + fechaSalir + "' where matricula = '" + Matricula + "' ")
    End Function

    Public Function Vehicle_Update_Pension(c As ComboBox, f_exit As DateTime)
        Dim fechaActual = (DateTime.Now.Year.ToString + "-" + DateTime.Now.Month.ToString + "-" + DateTime.Now.Day.ToString + " " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString).ToString
        Dim fechaSalir = (f_exit.Year.ToString + "-" + f_exit.Month.ToString + "-" + f_exit.Day.ToString + " " + f_exit.Hour.ToString + ":" + f_exit.Minute.ToString + ":" + f_exit.Second.ToString).ToString
        Return Db.Ejecutar("UPDATE vehicles SET tarifa = '" + ListTarifas.Item(c.SelectedIndex).ToString() + "', tarifa_hora = '0', tarifa_dia = '0', tarifa_pension = '1', fecha_ingreso = '" + fechaActual + "', fecha_salida = '" + fechaSalir + "' where matricula = '" + Matricula + "' ")
    End Function

    Public Shared Function Vehicles_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from vehicles where matricula = '" + Matricula + "' ")
    End Function

    Public Shared Function Vtd_TmpVehicle(id As Integer) As Boolean
        Return Db_shared.Ejecutar("delete from delivery_tmp where id = '" + id.ToString + "' ")
    End Function

    Public Shared Function VTD_Product_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from product_services where codebar = '" + VTD_Codebar + "' ")
    End Function

    Private Shared Sub DeleteIMGClient()
        Dim dato = Db_shared.Consult("select foto from clients where id =  '" + Client + "'  ")

        If dato.Read() Then
            If (My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + dato.GetString(0))) Then
                My.Computer.FileSystem.DeleteFile(My.Settings.data_url + Data_clients + dato.GetString(0))
            End If
        End If
    End Sub

    Public Shared Function OpenFileSetPictureBox(ByVal Img As PictureBox)
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            Dim fs As FileStream = New System.IO.FileStream(file.FileName, FileMode.Open, FileAccess.Read)
            Img.Image = Image.FromStream(fs)
            Img.SizeMode = PictureBoxSizeMode.Zoom
            fs.Close()
        End If
        Return file.FileName.Replace("\", "/")
    End Function

    Public Shared Function Clients_add(ByVal TxtName As TextBox, ByVal TxtDireccion As TextBox, ByVal TxtPhone As TextBox, ByVal TxtMail As TextBox, ByVal TxtRfc As TextBox, ByVal TxtRazonSocial As TextBox, ByVal foto As String) As Boolean
        Dim ruta As String
        ruta = "/" + username_id + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(foto)
        ruta = ruta.Replace("\", "/")

        Try
            My.Computer.FileSystem.CopyFile(foto, My.Settings.data_url + Data_clients + ruta)
        Catch ex As Exception

        End Try

        Return Db_shared.Ejecutar("INSERT INTO clients (name, address, phone, mail, rfc, razonsocial, foto) VALUES ('" + TxtName.Text.ToUpper + "', '" + TxtDireccion.Text.ToUpper + "', '" + TxtPhone.Text.ToUpper + "', '" + TxtMail.Text.ToUpper + "', '" + TxtRfc.Text.ToUpper + "', '" + TxtRazonSocial.Text.ToUpper + "', '" + ruta + "')")
    End Function

    Public Shared Function Products_add(ByVal TxtCode As TextBox, ByVal TxtNombre As TextBox, ByVal TxtDescripcion As TextBox, ByVal TxtPrecio As TextBox, ByVal Service As CheckBox, ByVal stock As NumericUpDown, ByVal foto As String) As Boolean
        Dim ruta As String
        ruta = "/" + username_id + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(foto)
        ruta = ruta.Replace("\", "/")

        Try
            My.Computer.FileSystem.CopyFile(foto, My.Settings.data_url + Data_products + ruta)
        Catch ex As Exception

        End Try
        Dim ServiceTmp As Integer = 0
        If Service.Checked Then
            ServiceTmp = 1
        End If
        Return Db_shared.Ejecutar("INSERT INTO product_services (codebar, nombre, descripcion, precio, stock, vendidos, image, service) VALUES ('" + TxtCode.Text + "', '" + TxtNombre.Text.ToUpper + "', '" + TxtDescripcion.Text.ToUpper + "', '" + TxtPrecio.Text.Replace(",", ".").Replace(" ", "") + "', '" + stock.Value.ToString + "', '0', '" + ruta + "', '" + ServiceTmp.ToString + "')")
    End Function

    Public Shared Function Clients_Update(ByVal TxtName As TextBox, ByVal TxtDireccion As TextBox, ByVal TxtPhone As TextBox, ByVal TxtMail As TextBox, ByVal TxtRfc As TextBox, ByVal TxtRazonSocial As TextBox, ByVal foto As String, ByVal foto_edit As String) As Boolean
        Dim ruta As String = foto
        If foto <> foto_edit Then
            ruta = "/" + username_id + DateTime.Now.ToString().Replace("/", "").Replace(".", "").Replace(":", "").Replace(" ", "") + Path.GetExtension(foto_edit)
            ruta = ruta.Replace("\", "/")

            Try
                My.Computer.FileSystem.CopyFile(foto_edit, My.Settings.data_url + Data_clients + ruta)
                If My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + foto) Then
                    My.Computer.FileSystem.DeleteFile(My.Settings.data_url + Data_clients + foto)
                End If
            Catch ex As Exception

            End Try
        End If
        Return Db_shared.Ejecutar("UPDATE clients SET name = '" + TxtName.Text.ToUpper + "', address = '" + TxtDireccion.Text.ToUpper + "', phone = '" + TxtPhone.Text.ToUpper + "', mail = '" + TxtMail.Text.ToUpper + "', rfc = '" + TxtRfc.Text.ToUpper + "', razonsocial = '" + TxtRazonSocial.Text.ToUpper + "', foto = '" + ruta + "' WHERE id =  '" + Client + "' ")
    End Function

    Public Sub LoadValuesOneClient(ByVal TxtName As TextBox, ByVal TxtDireccion As TextBox, ByVal TxtPhone As TextBox, ByVal TxtMail As TextBox, ByVal TxtRfc As TextBox, ByVal TxtRazonSocial As TextBox, ByVal foto As PictureBox, ByRef URLfoto As String, ByRef URLfoto_edit As String)
        Dim dato = Db.Consult("select * from clients where id =  '" + Client + "'  ")

        If dato.Read() Then
            TxtName.Text = dato.getstring(1)
            TxtDireccion.Text = dato.getstring(2)
            TxtPhone.Text = dato.getstring(3)
            TxtMail.Text = dato.getstring(4)
            TxtRfc.Text = dato.getstring(5)
            TxtRazonSocial.Text = dato.getstring(6)
            URLfoto = dato.getstring(7)
            URLfoto_edit = dato.getstring(7)
            If (My.Computer.FileSystem.FileExists(My.Settings.data_url + Data_clients + dato.getstring(7))) Then
                Dim fs As FileStream = New System.IO.FileStream(My.Settings.data_url + Data_clients + dato.getstring(7), FileMode.Open, FileAccess.Read)
                foto.Image = Image.FromStream(fs)
                foto.SizeMode = PictureBoxSizeMode.Zoom
                fs.Close()
            Else
                foto.Image = Nothing
            End If

        End If
    End Sub

    Public Function Empresa_Name() As String
        Return "Nombre de la empresa"
    End Function

    Public Sub ModelTextBox(ByVal txt As TextBox)
        txt.Font = My.Settings.text_font
    End Sub

    Private Sub PictureBoxSetModel(ByVal p As PictureBox)
        p.SizeMode = PictureBoxSizeMode.Zoom
    End Sub

    Public Function IsNumber(ByVal numero As String) As Boolean
        Try
            Return Decimal.Parse(numero)
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub loadtotalAsignacion(c As ComboBox, ByRef xhora As Double, ByRef xdia As Double, ByRef pension As Double, ByRef dias_pension As Integer, ByRef horas_dia As Integer)
        If c.SelectedIndex > 0 Then
            Dim dato = Db.Consult("SELECT price_hora, price_dia, price_pension, dias_pencion, horas_dias FROM tarifas where id = '" + ListTarifas.Item(c.SelectedIndex).ToString + "' ")

            If dato.Read() Then
                xhora = dato.GetDouble(0)
                xdia = dato.GetDouble(1)
                pension = dato.GetDouble(2)
                dias_pension = Convert.ToInt32(dato.GetString(3))
                horas_dia = Convert.ToInt32(dato.GetString(4))
            End If
        End If
    End Sub

    Public Function GetDateString(d As DateTime) As String
        Return (d.Year.ToString + "-" + d.Month.ToString + "-" + d.Day.ToString + " " + d.Hour.ToString + ":" + d.Minute.ToString + ":" + d.Second.ToString).ToString

    End Function

    Public Function GetDateStringEqualDB(d As DateTime) As String
        Return (d.Day.ToString + "/" + d.Month.ToString + "/" + d.Year.ToString + " " + d.Hour.ToString + ":" + d.Minute.ToString + ":" + d.Second.ToString).ToString
    End Function

    Public Function Ticket_GenerateID() As Integer
        Dim r As Integer = 0
        Dim dato = Db.Consult("SELECT MAX(ID_TICKET) FROM ventas")

        If dato.Read() Then
            r = Convert.ToInt32(dato.GetString(0)) + 1
        End If

        Return r
    End Function

    Public Function Vehicle_MembresisVigente(Matricula As String) As Boolean
        Dim r As Boolean = False
        Dim dato = Db.Consult("SELECT fecha_salida FROM vehicles WHERE matricula = '" + Matricula + "'")

        If dato.Read() Then
            Dim f_salida As DateTime = Convert.ToDateTime(dato.GetString(0).replace("-", "/"))
            If f_salida > DateTime.Now Then
                r = True
            End If
        End If
        Return r
    End Function

    Public Sub VehiclesLoadForControl(panel1 As Panel, sql As String, c As ContextMenuStrip)
        panel1.Controls.Clear()
        Dim Height_Button As Integer = My.Settings.Height_Button
        Dim Width_Button As Integer = My.Settings.Width_Button
        Dim Space_button As Integer = My.Settings.Space_button
        Dim LocationInicial_button As Integer = 10
        Dim ItemsXFilas As Integer = My.Settings.ItemsXFilas
        Dim items As Integer = 20

        Dim dato = Db.Consult(sql)

        Dim i As Integer = 1
        If dato.HasRows Then
            Do While dato.Read()
                Dim b As New Button()
                b.Name = dato.GetString(0)
                b.Height = Height_Button
                b.Width = Width_Button
                b.Top = (i - 1) * (Height_Button + 3)
                Dim x As Integer = ((i - 1) * Width_Button + (i - 1) * Space_button) + 10
                Dim y As Integer = LocationInicial_button

                If i > ItemsXFilas Then
                    Dim fila As Double = (i - 1) / ItemsXFilas

                    Dim Columna As Integer = i Mod ItemsXFilas
                    If Columna = 0 Then
                        Columna = ItemsXFilas
                    End If

                    x = ((Columna - 1) * Width_Button + (Columna - 1) * Space_button) + 10
                    y = (Math.Truncate(fila) * Height_Button) + LocationInicial_button

                    Dim MaxFila As Integer = Math.Truncate(items / ItemsXFilas)
                    If MaxFila - 1 = Math.Truncate(fila) Then

                    End If

                End If
                b.Font = My.Settings.text_font
                b.Text = dato.GetString(1)
                b.TextAlign = ContentAlignment.TopCenter
                b.Location = New Point(x, y)
                b.ContextMenuStrip = c
                b.Image = My.Resources.verify2_128
                b.ImageAlign = ContentAlignment.MiddleCenter
                b.BackColor = My.Settings.button_color

                AddHandler b.MouseDown, AddressOf EventoClick
                AddHandler b.MouseEnter, AddressOf EventoClick_Enter
                AddHandler b.MouseLeave, AddressOf EventoClick_Leave
                panel1.Controls.Add(b)
                i += 1
            Loop
        End If
    End Sub

    Public Sub Vtd_LoadProducts(panel1 As Panel, sql As String)
        panel1.Controls.Clear()
        Dim Height_Button As Integer = My.Settings.Height_Button
        Dim Width_Button As Integer = My.Settings.Width_Button
        Dim Space_button As Integer = My.Settings.Space_button
        Dim LocationInicial_button As Integer = 10
        Dim ItemsXFilas As Integer = My.Settings.ItemsXFilas
        Dim items As Integer = 20

        Dim dato = Db.Consult(sql)

        Dim i As Integer = 1
        If dato.HasRows Then
            Do While dato.Read()
                Dim b As New Button()
                b.Height = Height_Button
                b.Width = Width_Button
                b.Top = (i - 1) * (Height_Button + 3)
                Dim x As Integer = ((i - 1) * Width_Button + (i - 1) * Space_button) + 10
                Dim y As Integer = LocationInicial_button

                If i > ItemsXFilas Then
                    Dim fila As Double = (i - 1) / ItemsXFilas

                    Dim Columna As Integer = i Mod ItemsXFilas
                    If Columna = 0 Then
                        Columna = ItemsXFilas
                    End If

                    x = ((Columna - 1) * Width_Button + (Columna - 1) * Space_button) + 10
                    y = (Math.Truncate(fila) * Height_Button) + LocationInicial_button

                    Dim MaxFila As Integer = Math.Truncate(items / ItemsXFilas)
                    If MaxFila - 1 = Math.Truncate(fila) Then

                    End If

                End If
                b.Font = My.Settings.text_font
                b.Name = dato.GetString(0)
                b.Text = dato.GetString(1)
                b.TextAlign = ContentAlignment.TopCenter
                b.Location = New Point(x, y)

                Dim UrlFoto As String = My.Settings.data_url + Data_products + dato.GetString(2)
                If My.Computer.FileSystem.FileExists(UrlFoto) Then
                    Dim fs As FileStream = New System.IO.FileStream(UrlFoto, FileMode.Open, FileAccess.Read)
                    b.BackgroundImage = Image.FromStream(fs)
                    b.BackgroundImageLayout = ImageLayout.Zoom
                    fs.Close()
                End If

                b.ImageAlign = ContentAlignment.MiddleCenter
                b.BackColor = My.Settings.button_color

                AddHandler b.MouseDown, AddressOf EventoClickVtd
                AddHandler b.MouseEnter, AddressOf EventoClick_Enter
                AddHandler b.MouseLeave, AddressOf EventoClick_Leave
                panel1.Controls.Add(b)
                i += 1
            Loop
        End If
    End Sub

    Private Sub EventoClickVtd(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            MsgBox(ReturnInfoProduct(sender.name), Alert_NumberInformacion)
        ElseIf e.Button = MouseButtons.Left Then
            VentaDirecta.addproduct(sender.name + "")
        End If
    End Sub

    Private Sub EventoClick_Leave(sender As Object, e As EventArgs)
        sender.BackColor = My.Settings.button_color
    End Sub

    Private Sub EventoClick_Enter(sender As Object, e As EventArgs)
        sender.BackColor = My.Settings.button_colorSelect
    End Sub

    Private Sub EventoClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Select_VehiclesMatricula = sender.name
        ElseIf e.Button = MouseButtons.Left Then
            If (MsgBox("DAR SALIDA A: " + sender.text, Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If VehicleReturnAdeudoConProducts(sender.name) > 0 Then
                    EnterExitControl.Adeudo(sender.name, VehicleReturnAdeudoConProducts(sender.name))
                Else
                    Vehicle_ChangeStatus(sender.name, 0)
                    ActionBarr(My.Settings.rele_salida)
                    EnterExitControl.Loader()
                End If
            End If
        End If
    End Sub

    Public Function Vehicle_Status(Mat As ToolStripTextBox) As Boolean
        Dim r = False

        Dim dato = Db.Consult("SELECT status FROM vehicles WHERE matricula = '" + Mat.Text + "' ")

        If dato.Read() Then
            r = dato.GetBoolean(0)
            Console.WriteLine(r.ToString)
        End If

        Return r

    End Function

    Public Function VehicleReturnTarifa(ByRef hours As Boolean, ByRef day As Boolean, ByRef pension As Boolean, Mat As ToolStripTextBox) As Boolean
        Dim r = True

        If IsNumber(Mat.Text) Then
            Mat.Text = (Convert.ToInt32(Mat.Text)).ToString
        End If
        Dim dato = Db.Consult("SELECT tarifa_hora, tarifa_dia, tarifa_pension, matricula FROM vehicles WHERE matricula like '%" + Mat.Text + "%' or rfid like '%" + Mat.Text + "%' ;")

        If dato.Read() Then
            hours = dato.GetBoolean(0)
            day = dato.GetBoolean(1)
            pension = dato.GetBoolean(2)
            Mat.Text = dato.GetString(3)
        Else
            r = False
        End If

        Return r
    End Function

    Public Function ReturnFechaString(f As DateTime) As String
        Return (f.Year.ToString + "-" + f.Month.ToString + "-" + f.Day.ToString + " " + f.Hour.ToString + ":" + f.Minute.ToString + ":" + f.Second.ToString).ToString
    End Function

    Public Function VehiclesUpdate_StatusForHours(ByRef Ma As String, status As Integer) As Boolean
        'Estatus 0 sale el vehiculo
        'Estatus 1 entra el vehiculo
        ActionBarr(1)
        Return Db.Ejecutar("UPDATE vehicles SET status = '" + status.ToString + "', fecha_ingreso = '" + ReturnFechaString(DateTime.Now) + "' WHERE matricula = '" + Ma + "' ")
    End Function

    Public Function VehiclesUpdate_DiasVencidosForHours(ByRef Ma As String, status As Integer) As Boolean
        Return Db.Ejecutar("UPDATE vehicles SET status = '" + status.ToString + "', fecha_ingreso = '" + ReturnFechaString(DateTime.Now) + "', tarifa_dia = '0', tarifa_hora = '1', tarifa_pension = '0' WHERE matricula = '" + Ma + "' ")
    End Function

    Public Function Vehicle_ChangeStatus(ByRef Ma As String, status As Integer) As Boolean
        Return Db.Ejecutar("UPDATE vehicles SET status = '" + status.ToString + "' WHERE matricula = '" + Ma + "' ")
    End Function

    Public Function VehicleReturnAdeudoMembresia(Matricula As String) As Double
        Dim r As Double = 0
        Dim dato = Db.Consult("SELECT v.tarifa_hora, v.tarifa_dia, v.tarifa_pension, v.fecha_ingreso, t.price_hora, t.price_dia, t.price_pension, t.costo_minimo, v.fecha_salida FROM vehicles v, tarifas t where v.tarifa = t.id and matricula = '" + Matricula + "'  ")

        If dato.Read() Then
            If dato.GetBoolean(0) Then
                r = CalculateAdeudoXHORA(Convert.ToDateTime(dato.GetString(3)), Convert.ToDouble(dato.GetString(4)), Convert.ToDouble(dato.GetString(7)))
            ElseIf dato.GetBoolean(1) Then
                r = CalculateAdeudoXDia(Convert.ToDateTime(dato.GetString(8)), Convert.ToDouble(dato.GetString(5)), Convert.ToDouble(dato.GetString(7)))
            ElseIf dato.GetBoolean(2) Then
                r = CalculateAdeudoXPension(Convert.ToDateTime(dato.GetString(8)), Convert.ToDouble(dato.GetString(6)), Convert.ToDouble(dato.GetString(7)))
            End If
        Else
            r = 0
        End If

        Return r
    End Function

    Public Function VehicleReturnAdeudoConProducts(Matricula As String) As Double
        Dim a As String = String.Empty
        Return VehicleReturnAdeudoMembresia(Matricula) + Vehicles_TotalProducts(Matricula, a)
    End Function

    Public Function VehicleValidateFecha_Salida(Mat As ToolStripTextBox) As Boolean
        Dim r = False
        If IsNumber(Mat.Text) Then
            Mat.Text = (Convert.ToInt32(Mat.Text)).ToString
        End If

        Dim dato = Db.Consult("SELECT fecha_salida FROM vehicles WHERE matricula = '" + Mat.Text + "' ")

        If dato.Read() Then
            If Convert.ToDateTime(dato.GetString(0).ToString.Replace("-", "/")) > DateTime.Now Then
                r = True
            End If
        Else
            r = False
        End If
        Return r
    End Function

    Public Function ReturnInfoVehicle() As String
        Dim r = ""
        Dim dato = Db.Consult("SELECT v.matricula, v.modelo, c.name, t.name, v.fecha_ingreso, v.fecha_salida, v.tarifa_hora, v.tarifa_dia, v.tarifa_pension, t.price_hora, t.price_dia, t.price_pension, t.horas_dias, t.dias_pencion, t.costo_minimo, v.estado from vehicles v, tarifas t, clients c WHERE matricula = '" + Select_VehiclesMatricula + "' and v.tarifa = t.id and v.client = c.id")

        If dato.Read() Then
            r = "CLIENTE: " + dato.GetString(2) + vbCrLf + vbCrLf

            r += "MATRICULA: " + dato.GetString(0) + vbCrLf
            r += "UNIDAD: " + dato.GetString(1) + vbCrLf
            r += "ESTADO: " + dato.GetString(15) + vbCrLf + vbCrLf

            r += "TARIFA: " + dato.GetString(3) + vbCrLf
            r += "PRECIO X HORA: $ 20.00 | 1 HORA, Adicionales $ 5.00" + vbCrLf
            r += "PRECIO X DIA: $ " + dato.GetString(10) + " | " + dato.GetString(12) + " HORAS" + vbCrLf
            r += "PRECIO X PENSION: $ " + dato.GetString(11) + " | " + dato.GetString(13) + " DIAS" + vbCrLf
            r += "COBRO MINIMO: $ " + dato.GetString(14) + vbCrLf + vbCrLf

            If dato.GetBoolean(6) Then
                r += "TARIFA SELECCIONADA: COBRO POR HORA" + vbCrLf
            ElseIf dato.GetBoolean(7) Then
                r += "TARIFA SELECCIONADA: COBRO POR DIA" + vbCrLf
            ElseIf dato.GetBoolean(8) Then
                r += "TARIFA SELECCIONADA: COBRO POR PENSION" + vbCrLf
            End If

            If dato.GetBoolean(6) = False Then
                If DateTime.Now > Convert.ToDateTime(dato.GetString(5)) Then
                    r += "TARIFA: VENCIDA" + vbCrLf
                Else
                    r += "TARIFA: VIGENTE" + vbCrLf
                End If
                Dim day As Long = DateDiff(DateInterval.Day, DateTime.Now, Convert.ToDateTime(dato.GetString(5)))
                Dim horas As Long = DateDiff(DateInterval.Hour, DateTime.Now, Convert.ToDateTime(dato.GetString(5)))
                r += "DIAS/HORAS RESTANTES: " + day.ToString + " DIAS Ó " + horas.ToString + " HORAS " + vbCrLf
            End If
            r += vbCrLf
            If dato.GetBoolean(6) Then
                'hora
                r += "INGRESO: " + dato.GetString(4) + vbCrLf
                r += "FECHA ACTUAL: " + DateTime.Now.ToString + vbCrLf + vbCrLf
            ElseIf dato.GetBoolean(7) Then
                'Dia
                r += "INGRESO: " + dato.GetString(4) + vbCrLf
                r += "SALIDA: " + dato.GetString(5) + vbCrLf + vbCrLf
            ElseIf dato.GetBoolean(8) Then
                'Pension
                r += "INGRESO: " + dato.GetString(4) + vbCrLf
                r += "SALIDA: " + dato.GetString(5) + vbCrLf + vbCrLf
            End If

            Dim ListVtd As String = String.Empty

            If dato.GetBoolean(6) Then
                r += "ADEUDO: $ " + (CalculateAdeudoXHORA(Convert.ToDateTime(dato.GetString(4)), Convert.ToDouble(dato.GetString(9)), Convert.ToDouble(dato.GetString(14))) + Vehicles_TotalProducts(Select_VehiclesMatricula, ListVtd)).ToString + vbCrLf + vbCrLf
            ElseIf dato.GetBoolean(7) Then
                r += "ADEUDO: $ " + (CalculateAdeudoXDia(Convert.ToDateTime(dato.GetString(5)), Convert.ToDouble(dato.GetString(9)), Convert.ToDouble(dato.GetString(14))) + Vehicles_TotalProducts(Select_VehiclesMatricula, ListVtd)).ToString + vbCrLf + vbCrLf
            ElseIf dato.GetBoolean(8) Then
                r += "ADEUDO: $ " + (CalculateAdeudoXPension(Convert.ToDateTime(dato.GetString(5)), Convert.ToDouble(dato.GetString(9)), Convert.ToDouble(dato.GetString(14))) + Vehicles_TotalProducts(Select_VehiclesMatricula, ListVtd)).ToString + vbCrLf + vbCrLf
            End If

            If String.IsNullOrEmpty(ListVtd) = False Then
                r += ListVtd
            End If

        End If
        Return r
    End Function

    Public Function ReturnInfoProduct(codebar As String) As String
        Dim r = ""
        Dim dato = Db.Consult("SELECT nombre, descripcion, precio, stock, service FROM product_services WHERE codebar = '" + codebar + "'")

        If dato.Read() Then
            r = "NOMBRE: " + dato.GetString(0) + vbCrLf
            r += "DESCRIPCION: " + dato.GetString(1) + vbCrLf
            r += "PRECIO: " + dato.GetString(2) + vbCrLf
            If dato.GetBoolean(4) Then
                r += "TIPO: ESTE PRODUCTO ES UN SERVICIO"
            Else
                r += "STOCK: " + dato.GetString(3) + vbCrLf
                r += "TIPO: PRODUCTO"
            End If

        End If
        Return r
    End Function

    Public Function Vehicles_TotalProducts(vehiculo As String, ByRef ListVtd As String) As Decimal
        Dim r As Decimal = 0

        Dim dato = Db.Consult("SELECT d.id, p.nombre, p.precio FROM delivery_tmp d, product_services p WHERE d.product = p.codebar and d.vehicle = '" + vehiculo + "'")

        If dato.hasrows Then
            ListVtd = "PRODUCTOS: "
            Do While dato.Read()
                ListVtd += "(1) " + dato.GetString(1) + " " + dato.GetString(2) + " " + My.Settings.moneda + "| "
                r += Convert.ToDecimal(dato.GetString(2))
            Loop
        End If

        Return r
    End Function

    Public Function Vehicles_ProductsRealizarVenta(vehiculo As String, ImptTicket As Boolean) As Boolean
        Dim r As Boolean = True
        Dim clientTmp As String = VehiclesPropietarioID(vehiculo).ToString

        Try
            Dim ticket As Integer = Ticket_GenerateID()

            Dim dato = Db.ConsultNewConexion("SELECT d.id, p.codebar FROM delivery_tmp d, product_services p WHERE d.product = p.codebar and d.vehicle = '" + vehiculo + "'")

            If dato.hasrows Then
                Do While dato.Read()
                    Dim dato_id As String = dato.GetString(0)
                    Dim dato_codebar As String = dato.GetString(1)

                    Dim NameProduct As String = String.Empty
                    Dim PriceProduct As Decimal = 0
                    Dim IsService As Boolean = False
                    Product_NamePrice_Return(dato_codebar, NameProduct, PriceProduct, IsService)

                    If String.IsNullOrEmpty(NameProduct) = False Then
                        Dim Add As Boolean
                        If IsService Then
                            Add = Db.Ejecutar("INSERT INTO ventas (id_cliente, id_usuario, id_ticket, concepto, monto, date, producto, service, membresia, cut_x, cut_z) VALUES ('" + clientTmp + "', '" + username_id.ToString + "', '" + ticket.ToString + "', '" + NameProduct + "', '" + PriceProduct.ToString + "', '" + GetDateString(DateTime.Now) + "', '0', '1', '0' , '0', '0')")
                        Else
                            Add = Db.Ejecutar("INSERT INTO ventas (id_cliente, id_usuario, id_ticket, concepto, monto, date, producto, service, membresia, cut_x, cut_z) VALUES ('" + clientTmp + "', '" + username_id.ToString + "', '" + ticket.ToString + "', '" + NameProduct + "', '" + PriceProduct.ToString + "', '" + GetDateString(DateTime.Now) + "', '1', '0', '0' , '0', '0')")
                        End If

                        If Add Then
                            If IsService = False Then
                                Db.Ejecutar("UPDATE product_services SET stock = stock - 1 WHERE codebar = '" + dato_codebar + "' ")
                            End If
                            Db.Ejecutar("delete from delivery_tmp where id = " + dato_id + " ")
                        Else
                            r = False
                        End If
                    End If
                Loop
            End If

            If r Then
                Db.Ejecutar("INSERT INTO ventas (id_cliente, id_usuario, id_ticket, concepto, monto, date, producto, service, membresia, cut_x, cut_z) VALUES ('" + clientTmp + "', '" + username_id.ToString + "', '" + ticket.ToString + "', 'COBRO TIEMPO', '" + VehicleReturnAdeudoMembresia(vehiculo).ToString + "', '" + GetDateString(DateTime.Now) + "', '0', '0', '1' , '0', '0')")
            End If

            If ImptTicket Then
                TicketGeneratePrint(ticket)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return r
    End Function

    Public Function CalculateAdeudoXHORA(Entrada As DateTime, Costo As Double, Costo_Minimo As Double) As Double
        Dim r = 0
        Dim Minutos As Long = DateDiff(DateInterval.Minute, Entrada, DateTime.Now)
        r = (Minutos / 60) * Costo
        If r < Costo_Minimo Then
            r = Costo_Minimo
        End If

        'Dim r = 0
        'Dim min As Long = DateDiff(DateInterval.Minute, Entrada, DateTime.Now)


        'If min <= 60 Then '1
        'r = 20
        'ElseIf min > 60 And min <= 120 Then '1
        'r = 25
        'ElseIf min > 120 And min <= 180 Then '2
        'r = 30
        'ElseIf min > 180 And min <= 240 Then '3
        'r = 35
        'ElseIf min > 240 And min <= 300 Then '4
        'r = 40
        'ElseIf min > 300 And min <= 360 Then '5
        'r = 45
        'ElseIf min > 360 And min <= 420 Then '6
        'r = 50
        'ElseIf min > 420 And min <= 480 Then '7
        'r = 55
        'ElseIf min > 480 And min <= 540 Then '8
        'r = 60
        'ElseIf min > 540 And min <= 600 Then '9
        'r = 65
        'ElseIf min > 600 And min <= 660 Then '10
        'r = 70
        'ElseIf min > 660 And min <= 720 Then '11
        'r = 75
        'ElseIf min > 720 Then '12
        'r = 120
        'End If

        Return r

    End Function

    Public Function CalculateAdeudoXDia(Salida As DateTime, Costo As Double, Costo_Minimo As Double) As Double
        Dim r = 0

        If DateTime.Now > Salida Then
            Dim Minutos As Long = DateDiff(DateInterval.Minute, DateTime.Now, Salida)
            r = (Minutos / 60) * Costo
            If r < Costo_Minimo Then
                r = Costo_Minimo
            End If
        End If

        Return r
    End Function

    Public Function CalculateAdeudoXPension(Salida As DateTime, Costo As Double, Costo_Minimo As Double) As Double
        Dim r = 0

        If DateTime.Now > Salida Then
            Dim Minutos As Long = DateDiff(DateInterval.Minute, DateTime.Now, Salida)
            r = (Minutos / 60) * Costo
            If r < Costo_Minimo Then
                r = Costo_Minimo
            End If
        End If

        Return r
    End Function

    Public Function VTD_FormatString(txt As TextBox) As Decimal
        Dim arr = txt.Text.Split("+")
        Dim cadena As String = String.Empty

        For Each item In arr
            Dim tmp As String = String.Empty
            For i = 1 To Len(item)
                tmp += Mid(item, i, 1).Replace("+", "")
            Next i

            If String.IsNullOrEmpty(tmp) = False Then
                cadena += tmp + "+"
            End If
        Next

        txt.Text = cadena
        txt.Select(txt.Text.Length, 0)

        Dim total As Decimal

        For Each item In txt.Text.Split("+")
            total += Return_ProductPrice(item)
        Next

        Return total
    End Function

    Public Function VTD_Cobrar_Delivery(txt As TextBox, vehicle As ComboBox) As Boolean
        Dim r = True
        Dim Matricula As String = ListVehiclesActivos.Item(vehicle.SelectedIndex).ToString

        For Each item In txt.Text.Split("+")
            If String.IsNullOrEmpty(item) = False Then
                If Db.Ejecutar("INSERT INTO delivery_tmp (product, vehicle) VALUES ('" + item + "', '" + Matricula + "')") = False Then
                    r = False
                End If
            End If
        Next
        Return r
    End Function

    Public Function VTD_Cobrar(txt As TextBox, client As Integer)
        Dim r = True

        Dim ticket As Integer = Ticket_GenerateID()

        For Each item In txt.Text.Split("+")
            Dim NameProduct As String = String.Empty
            Dim PriceProduct As Decimal = 0
            Dim IsService As Boolean = False
            Product_NamePrice_Return(item, NameProduct, PriceProduct, IsService)

            If String.IsNullOrEmpty(NameProduct) = False Then
                Dim Add As Boolean
                If IsService Then
                    Add = Db.Ejecutar("INSERT INTO ventas (id_cliente, id_usuario, id_ticket, concepto, monto, date, producto, service, membresia, cut_x, cut_z) VALUES ('" + client.ToString + "', '" + username_id.ToString + "', '" + ticket.ToString + "', '" + NameProduct + "', '" + PriceProduct.ToString + "', '" + GetDateString(DateTime.Now) + "', '0', '1', '0' , '0', '0')")
                Else
                    Add = Db.Ejecutar("INSERT INTO ventas (id_cliente, id_usuario, id_ticket, concepto, monto, date, producto, service, membresia, cut_x, cut_z) VALUES ('" + client.ToString + "', '" + username_id.ToString + "', '" + ticket.ToString + "', '" + NameProduct + "', '" + PriceProduct.ToString + "', '" + GetDateString(DateTime.Now) + "', '1', '0', '0' , '0', '0')")
                End If

                If Add Then
                    If IsService = False Then
                        Db.Ejecutar("UPDATE product_services SET stock = stock - 1 WHERE codebar = '" + item.ToString + "' ")
                    End If
                Else
                    r = False
                End If
            End If
        Next
        TicketGeneratePrint(ticket)
        Return r
    End Function

    Public Sub TicketGeneratePrint(ticket As Integer)
        Dim membrete As String = ""
        Dim body As String = ""
        Dim cliente As String = ""
        Dim vendedor As String = ""
        Dim fecha_compra As String = ""
        Dim total As Decimal = 0
        Dim total_compras As Int32 = 0

        membrete += My.Settings.local_nombre
        membrete += vbLf + "DIRECCION:"
        membrete += vbLf + My.Settings.local_direccion
        membrete += vbLf + "RFC: " + My.Settings.local_rfc
        membrete += vbLf + "TELEFONO: " + My.Settings.local_telefono
        membrete += vbLf + "FOLIO: #" + ticket.ToString
        membrete += vbLf + "--------------------------"

        Dim dato = Db.Consult("SELECT c.name, u.name, v.concepto, v.monto, v.date FROM ventas v, clients c, users u WHERE v.id_cliente = c.id and v.id_usuario = u.id and id_ticket = '" + ticket.ToString + "'")
        Do While dato.Read()
            cliente = dato.GetString(0)
            vendedor = dato.GetString(1)
            fecha_compra = dato.GetString(4)
            Dim tmp0 = vbLf + "(1) " + dato.GetString(2) + " $ " + dato.GetString(3)
            Dim var = ""
            If tmp0.ToString.Length > 25 Then
                var = tmp0.ToString.Substring(0, 25) + vbLf
                If tmp0.ToString.Length > 50 Then
                    var += tmp0.ToString.Substring(25, 25) + vbLf
                    If tmp0.ToString.Length > 52 Then
                        var += tmp0.ToString.Substring(50, tmp0.ToString.Length - 50)
                    End If
                Else
                    var += tmp0.ToString.Substring(25, tmp0.ToString.Length - 25)
                End If

                tmp0 = var
            End If
            body += tmp0
            total += Decimal.Parse(dato.GetString(3))
            total_compras += 1
        Loop
        membrete += vbLf + "FECHA DE COMPRA"
        membrete += vbLf + fecha_compra
        If My.Settings.ticket_mostrar_hote_impresion Then
            membrete += vbLf + "FECHA DE IMPRESION"
            membrete += vbLf + GetDateStringEqualDB(DateTime.Now)
        End If

        If My.Settings.ticket_mostrar_cliente Then
            membrete += vbLf + "CLIENTE:"
            membrete += vbLf + cliente
        End If

        If My.Settings.ticke_mostar_venderor Then
            membrete += vbLf + "ATENDIO"
            membrete += vbLf + vendedor
        End If

        membrete += vbLf + "--------------------------"
        body += vbLf + "--------------------------"
        body += vbLf + "MONTO TOTAL: $" + total.ToString
        body += vbLf + "TOTAL COMPRAS: " + total_compras.ToString

        If My.Settings.ticket_mostrar_pie_depagina Then
            body += vbLf + "--------------------------"
            body += vbLf + My.Settings.ticket_pie_de_pagina.Replace("\n", vbLf)
        End If

        BodyTicket = membrete + body
        Dim pd As New PrintDocument
        pd.PrinterSettings.PrinterName = My.Settings.ticket_impresora
        pd.DefaultPageSettings.Margins.Left = 0
        pd.DefaultPageSettings.Margins.Right = 0
        pd.DefaultPageSettings.Margins.Top = 0
        pd.DefaultPageSettings.Margins.Bottom = 0
        AddHandler pd.PrintPage, AddressOf print_PrintPage

        If pd.PrinterSettings.IsValid Then
            pd.Print()
        Else
            MsgBox("Error en la impresion", MsgBoxStyle.Critical)
        End If

    End Sub

    Public Sub GenCodeBarr(cadena As String)
        Dim barcode As New iTextSharp.text.pdf.Barcode128
        barcode.StartStopText = True

        barcode.Code = cadena

        Dim bm As New System.Drawing.Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White))
        bm.Save(My.Settings.data_url + "\CodeBar.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
    End Sub

    Public Sub TicketGeneratePrint_Cadena(cadena As String, matricula As String, ShowCodeBar As Boolean)
        ViewCodeBar = ShowCodeBar
        GenCodeBarr(matricula)
        cadena += matricula
        cadena = vbLf + "ENTRADA: " + DateTime.Now.ToString + " " + cadena
        Dim membrete As String = ""
        Dim body As String = ""
        Dim total As Decimal = 0
        Dim total_compras As Int32 = 0

        membrete += My.Settings.local_nombre
        membrete += vbLf + "DIRECCION:"
        membrete += vbLf + My.Settings.local_direccion
        membrete += vbLf + "RFC: " + My.Settings.local_rfc
        membrete += vbLf + "TELEFONO: " + My.Settings.local_telefono
        membrete += vbLf + "FOLIO: # N/A"

        Dim tmp0 = cadena
        Dim var = ""
        If tmp0.ToString.Length > 25 Then
            var = tmp0.ToString.Substring(0, 25) + vbLf
            If tmp0.ToString.Length > 50 Then
                var += tmp0.ToString.Substring(25, 25) + vbLf
                If tmp0.ToString.Length > 52 Then
                    var += tmp0.ToString.Substring(50, tmp0.ToString.Length - 50)
                End If
            Else
                var += tmp0.ToString.Substring(25, tmp0.ToString.Length - 25)
            End If

            tmp0 = var
        End If
        body += tmp0
        total_compras = 1

        membrete += vbLf + "--------------------------"

        If My.Settings.ticket_mostrar_pie_depagina Then
            body += vbLf + "--------------------------"
            body += vbLf + My.Settings.ticket_pie_de_pagina.Replace("\n", vbLf)
        End If

        BodyTicket = membrete + body
        Dim pd As New PrintDocument
        pd.PrinterSettings.PrinterName = My.Settings.ticket_impresora
        pd.DefaultPageSettings.Margins.Left = 0
        pd.DefaultPageSettings.Margins.Right = 0
        pd.DefaultPageSettings.Margins.Top = 0
        pd.DefaultPageSettings.Margins.Bottom = 0
        AddHandler pd.PrintPage, AddressOf print_PrintPage

        If pd.PrinterSettings.IsValid Then
            pd.Print()
        Else
            MsgBox("Error en la impresion", MsgBoxStyle.Critical)
        End If

    End Sub

    Dim BodyTicket As String
    Dim ViewCodeBar As Boolean = False

    Private Sub print_PrintPage(sender As Object, e As PrintPageEventArgs)
        Dim xPos As Single = e.MarginBounds.Left
        Dim prFont As New Font("Lucida Console", 8, FontStyle.Regular)
        prFont = My.Settings.ticket_font
        Dim yPos As Single = prFont.GetHeight(e.Graphics)

        Dim saltos = vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf
        e.Graphics.DrawImage(Image.FromFile(My.Settings.url_logo), 0, 0, 180, 180)

        If ViewCodeBar Then
            e.Graphics.DrawImage(Image.FromFile(My.Settings.data_url + "\CodeBar.jpg"), 1, 181, 179, 80)
            saltos += vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf + vbLf
        End If

        e.Graphics.DrawString(saltos + BodyTicket, prFont, Brushes.Black, xPos, yPos)
        e.HasMorePages = False
    End Sub

    Public Function Return_ProductPrice(codebar As String) As Decimal
        Dim r = 0
        Dim dato = Db.Consult("SELECT precio FROM product_services WHERE codebar = '" + codebar + "'")

        If dato.Read() Then
            r = dato.GetString(0)
        Else
            r = 0
        End If

        Return r
    End Function

    Public Function Return_Cliente_Vehicle(matricula As String) As Int32
        Dim r = 0
        Dim dato = Db.Consult("SELECT client FROM `vehicles` WHERE matricula = '" + matricula + "'")

        If dato.Read() Then
            r = dato.GetString(0)
        Else
            r = 0
        End If

        Return r
    End Function

    Public Sub Product_NamePrice_Return(codebar As String, ByRef name As String, ByRef price As Decimal, ByRef IsService As Boolean)
        Dim r = 0
        Dim dato = Db.Consult("SELECT nombre, precio, service FROM product_services WHERE codebar = '" + codebar + "'")

        If dato.Read() Then
            name = dato.GetString(0)
            price = dato.GetString(1)
            IsService = dato.GetBoolean(2)
        End If
    End Sub

    Public Function VehiclesPropietarioID(matricula As String) As Integer
        Dim r = 0
        Dim dato = Db.Consult("SELECT client FROM vehicles where matricula = '" + matricula + "' ")

        If dato.Read() Then
            r = Convert.ToInt32(dato.GetString(0))
        End If

        Return r

    End Function

    Public Sub ActionBarr(NumRele As Integer)
        NumeroRele = NumRele
        Dim work As New BackgroundWorker
        AddHandler work.DoWork, AddressOf ActionBarr_dowork
        work.RunWorkerAsync()
    End Sub

    Private Sub ActionBarr_dowork(sender As Object, e As DoWorkEventArgs)
        Dim a = NumeroRele.ToString
        Process.Start("cmd", "/c " + My.Settings.data_url + "\CommandApp_USBRelay.exe " + My.Settings.id_relevador + " open " + a + " ")
        System.Threading.Thread.Sleep(My.Settings.relevador_milisegundos)
        Process.Start("cmd", "/c " + My.Settings.data_url + "\CommandApp_USBRelay.exe " + My.Settings.id_relevador + " close " + a + " ")
    End Sub

    Public Function GeneratePDF_Table(t As DataGridView, concepto As String, footer As String, rotate As Boolean) As String
        Dim filename = "C:\clta_estacionamiento_data\report_tmp.pdf"

        Dim doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER)
        If rotate Then
            doc = New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER.Rotate)
        End If

        Dim writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, New FileStream(filename, FileMode.Create))
        doc.AddTitle("REPORTE CLTA - ESTACIONAMIENTO")
        doc.AddCreator("clta")
        doc.Open()

        If File.Exists(My.Settings.url_logo) Then
            Dim fs = New FileStream(My.Settings.url_logo, FileMode.Open, FileAccess.Read)
            Dim imagen = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs), iTextSharp.text.BaseColor.WHITE)
            imagen.ScaleToFit(140, 140)
            imagen.Alignment = iTextSharp.text.Element.ALIGN_RIGHT
            Dim logo = New iTextSharp.text.Chunk(imagen, 375, -132)
            If rotate Then
                logo = New iTextSharp.text.Chunk(imagen, 500, -132)
            End If
            doc.Add(logo)
        End If

        Dim _standardFont = New iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)
        doc.Add(New iTextSharp.text.Paragraph(My.Settings.local_nombre))
        doc.Add(New iTextSharp.text.Paragraph("DIRECCION: " + My.Settings.local_direccion))
        doc.Add(New iTextSharp.text.Paragraph("RFC: " + My.Settings.local_rfc))
        doc.Add(New iTextSharp.text.Paragraph("TELEFONO: " + My.Settings.local_telefono))
        doc.Add(New iTextSharp.text.Paragraph("USUARIO QUE GENERO: " + username_name))
        doc.Add(New iTextSharp.text.Paragraph("FECHA Y HORA DE GENERACION: " + GetDateString(DateTime.Now)))
        doc.Add(New iTextSharp.text.Paragraph(concepto.ToUpper))
        doc.Add(iTextSharp.text.Chunk.NEWLINE)

        Dim tabla = New iTextSharp.text.pdf.PdfPTable(t.ColumnCount)
        tabla.WidthPercentage = 100

        'Adding Header row
        For Each column As DataGridViewColumn In t.Columns
            Dim cell As New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase(column.HeaderText))
            tabla.AddCell(cell)
        Next

        'Adding DataRow
        For Each row As DataGridViewRow In t.Rows
            For Each cell As DataGridViewCell In row.Cells
                If String.IsNullOrEmpty(cell.Value) = False Then
                    tabla.AddCell(cell.Value.ToString())
                End If
            Next
        Next

        Dim ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("CONCEPTO", _standardFont))
        ClId.BorderWidth = 0
        ClId.BorderWidthBottom = 0.75F


        tabla.AddCell(ClId)

        ClId = New iTextSharp.text.pdf.PdfPCell(New iTextSharp.text.Phrase("ssssss", _standardFont))
        ClId.BorderWidth = 0
        tabla.AddCell(ClId)

        doc.Add(tabla)
        doc.Add(New iTextSharp.text.Paragraph(footer.ToString.ToUpper))
        doc.Add(New iTextSharp.text.Paragraph("SOFTWARE Y MAS - WWW.CYBERCHOAPAS.COM !"))
        doc.Close()
        writer.Close()

        Return filename
    End Function

    Public Function ValidarLicence(ByVal code As TextBox) As Boolean
        Dim resultado As New Boolean
        resultado = False
        Dim r = Licence.Consult("SELECT status FROM licence where licence = '" + code.Text + "' and status = 0")
        If r.Read() Then
            resultado = Licence.Ejecutar("update licence set status = 1 where licence = '" + code.Text + "' ")
        End If
        Return resultado
    End Function

    Public Function ComprobarLicence()
        Dim work As New BackgroundWorker
        AddHandler work.DoWork, AddressOf validar_dowork
        work.RunWorkerAsync()
    End Function

    Private Sub validar_dowork(sender As Object, e As DoWorkEventArgs)
        Dim r = Licence.Consult("SELECT status FROM licence where licence = '" + My.Settings.licencia + "' ")
        If r.Read() Then
            If r.GetString(0) = "0" Then
                My.Settings.licencia = "No PAGO"
                My.Settings.validate = False
                My.Settings.Save()
                MsgBox("Licencia no valida")
            End If
        Else
            My.Settings.licencia = "Licencia no valida"
            My.Settings.validate = False
            My.Settings.Save()
            MsgBox("Licencia no valida")
        End If
    End Sub

End Class
