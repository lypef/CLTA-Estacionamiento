Imports System.IO
Imports System.Security.Cryptography

Public Class Functions
    Dim Db As New Conexion
    Shared Db_shared As New Conexion

    'Listas
    Dim ListClients As New List(Of Integer)
    Dim ListTarifas As New List(Of Integer)

    'Rutas data
    Public Shared ReadOnly Data_clients As String = "\clients"
    Public Shared ReadOnly Data_reports As String = "\reports"
    Public Shared ReadOnly Data_drivers As String = "\drivers"
    Public Shared ReadOnly Data_Clients_ImgDefault As String = "\default.png"

    'Variables de sistema
    Public Shared Client As String
    Public Shared Matricula As String
    Public Shared Tarifa As String

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
        AddForm_Desktop(Vehicles, desktop)
        AddForm_Desktop(Rate, desktop)
        AddForm_Desktop(AsignacionesUPDATE, desktop)
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
        Return Db.Ejecutar("INSERT INTO ventas (id_cliente, id_usuario, id_ticket, concepto, monto, date, cut_x, cut_z) VALUES ('" + id_cliente.ToString + "', '" + username_id.ToString + "', '" + ticket.ToString + "', '" + concepto.ToUpper + "', '" + monto.ToString + "', '" + GetDateString(DateTime.Now) + "', '0', '0');")
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
        c.SelectedIndex = 0
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

    Public Shared Function Rate_DELETE() As Boolean
        Return Db_shared.Ejecutar("delete from tarifas where id = " + Tarifa + " ")
    End Function

    Public Function Vehicle_Update(c As ComboBox, matriculaTextBoxEdit As TextBox, modeloTextBoxEdit As TextBox, colorTextBoxEdit As TextBox, estadoTextboxEdit As TextBox, ComboTarifa As ComboBox, Rfid As TextBox)
        Return Db.Ejecutar("UPDATE vehicles SET client = '" + ListClients.Item(c.SelectedIndex).ToString() + "', tarifa = '" + ListTarifas.Item(ComboTarifa.SelectedIndex).ToString() + "', matricula = '" + matriculaTextBoxEdit.Text.ToUpper + "', modelo = '" + modeloTextBoxEdit.Text.ToUpper + "', color = '" + colorTextBoxEdit.Text.ToUpper + "', estado = '" + estadoTextboxEdit.Text.ToUpper + "', rfid = " + Rfid.Text + " where matricula = '" + Matricula + "' ")
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

    Public Function TickerID_Siguiente() As Integer
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
End Class
