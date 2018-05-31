<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class users
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListPermisos = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Tabla = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListPermisosEdit = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPasswordConfirmEdit = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPasswordEdit = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtUsernameEdit = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNombreEdit = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.TxtSearch, Me.ClientesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_exit
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(69, 25)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem2.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_minimizar
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(105, 25)
        Me.ToolStripMenuItem2.Text = "Restaurar"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem3.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.maximize_48_
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(110, 25)
        Me.ToolStripMenuItem3.Text = "Maximizar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ToolStripMenuItem4.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_minimizar
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(108, 25)
        Me.ToolStripMenuItem4.Text = "Minimizar"
        '
        'TxtSearch
        '
        Me.TxtSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(140, 25)
        Me.TxtSearch.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.ClientesToolStripMenuItem.Text = "Usuarios"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(941, 382)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Controls.Add(Me.Button2)
        Me.TabPage1.Controls.Add(Me.ListPermisos)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtPasswordConfirm)
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtPassword)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TxtUsername)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtNombre)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(933, 356)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Agregar"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(279, 53)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(171, 41)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Ninguno"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(279, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(171, 41)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Todos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListPermisos
        '
        Me.ListPermisos.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListPermisos.FormattingEnabled = True
        Me.ListPermisos.Items.AddRange(New Object() {"Acceso a clientes", "Agregar cliente", "Editar cliente", "Eliminar cliente", "Acceso modulo vehiculos", "Agregar vehiculo", "Editar vehiculo", "Eliminar vehiculo", "Acceso a modulo tarifas", "Agregar tarifa", "Editar tarifa", "Eliminar tarifa", "Acceso modulo asigaciones", "Acceso modulo venta directa", "Agregar producto o servicio", "Editar  producto o servicio", "Eliminar producto o servicio", "Acceso a Ventas financieras", "Acceso a modulo usuarios", "Agregar usuario", "Editar usuario", "Eliminar usuario"})
        Me.ListPermisos.Location = New System.Drawing.Point(456, 3)
        Me.ListPermisos.Name = "ListPermisos"
        Me.ListPermisos.Size = New System.Drawing.Size(474, 350)
        Me.ListPermisos.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Confirmar Contraseña"
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPasswordConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(8, 235)
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(228, 24)
        Me.TxtPasswordConfirm.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(65, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contraseña"
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(8, 174)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(228, 24)
        Me.TxtPassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre de usuario"
        '
        'TxtUsername
        '
        Me.TxtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(8, 108)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(228, 24)
        Me.TxtUsername.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(8, 44)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(228, 24)
        Me.TxtNombre.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Tabla)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(933, 356)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultar"
        '
        'Tabla
        '
        Me.Tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Tabla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabla.Location = New System.Drawing.Point(3, 3)
        Me.Tabla.Name = "Tabla"
        Me.Tabla.Size = New System.Drawing.Size(927, 350)
        Me.Tabla.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Button4)
        Me.TabPage3.Controls.Add(Me.Button5)
        Me.TabPage3.Controls.Add(Me.ListPermisosEdit)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.TxtPasswordConfirmEdit)
        Me.TabPage3.Controls.Add(Me.Button6)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.TxtPasswordEdit)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.TxtUsernameEdit)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.TxtNombreEdit)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(933, 356)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Editar"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(275, 53)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(171, 41)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Ninguno"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(275, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(171, 41)
        Me.Button5.TabIndex = 22
        Me.Button5.Text = "Todos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListPermisosEdit
        '
        Me.ListPermisosEdit.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListPermisosEdit.FormattingEnabled = True
        Me.ListPermisosEdit.Items.AddRange(New Object() {"Acceso a clientes", "Agregar cliente", "Editar cliente", "Eliminar cliente", "Acceso modulo vehiculos", "Agregar vehiculo", "Editar vehiculo", "Eliminar vehiculo", "Acceso a modulo tarifas", "Agregar tarifa", "Editar tarifa", "Eliminar tarifa", "Acceso modulo asigaciones", "Acceso modulo venta directa", "Agregar producto o servicio", "Editar  producto o servicio", "Eliminar producto o servicio", "Acceso a Ventas financieras", "Acceso a modulo usuarios", "Agregar usuario", "Editar usuario", "Eliminar usuario"})
        Me.ListPermisosEdit.Location = New System.Drawing.Point(459, 0)
        Me.ListPermisosEdit.Name = "ListPermisosEdit"
        Me.ListPermisosEdit.Size = New System.Drawing.Size(474, 356)
        Me.ListPermisosEdit.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Confirmar Contraseña"
        '
        'TxtPasswordConfirmEdit
        '
        Me.TxtPasswordConfirmEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPasswordConfirmEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordConfirmEdit.Location = New System.Drawing.Point(4, 235)
        Me.TxtPasswordConfirmEdit.Name = "TxtPasswordConfirmEdit"
        Me.TxtPasswordConfirmEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordConfirmEdit.Size = New System.Drawing.Size(228, 24)
        Me.TxtPasswordConfirmEdit.TabIndex = 18
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.Location = New System.Drawing.Point(61, 270)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(171, 41)
        Me.Button6.TabIndex = 19
        Me.Button6.Text = "Actualizar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Contraseña"
        '
        'TxtPasswordEdit
        '
        Me.TxtPasswordEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPasswordEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPasswordEdit.Location = New System.Drawing.Point(4, 174)
        Me.TxtPasswordEdit.Name = "TxtPasswordEdit"
        Me.TxtPasswordEdit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPasswordEdit.Size = New System.Drawing.Size(228, 24)
        Me.TxtPasswordEdit.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Nombre de usuario"
        '
        'TxtUsernameEdit
        '
        Me.TxtUsernameEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtUsernameEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsernameEdit.Location = New System.Drawing.Point(4, 108)
        Me.TxtUsernameEdit.Name = "TxtUsernameEdit"
        Me.TxtUsernameEdit.Size = New System.Drawing.Size(228, 24)
        Me.TxtUsernameEdit.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(4, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Nombre"
        '
        'TxtNombreEdit
        '
        Me.TxtNombreEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreEdit.Location = New System.Drawing.Point(4, 44)
        Me.TxtNombreEdit.Name = "TxtNombreEdit"
        Me.TxtNombreEdit.Size = New System.Drawing.Size(228, 24)
        Me.TxtNombreEdit.TabIndex = 14
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 48)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.edit_24
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.delete_24
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 411)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "users"
        Me.Text = "users"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents TxtSearch As ToolStripTextBox
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Tabla As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListPermisos As CheckedListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPasswordConfirm As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ListPermisosEdit As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPasswordConfirmEdit As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPasswordEdit As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtUsernameEdit As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtNombreEdit As TextBox
End Class
