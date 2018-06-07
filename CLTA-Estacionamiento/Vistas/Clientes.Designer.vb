<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBoxRazonSocialEdit = New System.Windows.Forms.TextBox()
        Me.Label6Edit = New System.Windows.Forms.Label()
        Me.TextBoxRfcEdit = New System.Windows.Forms.TextBox()
        Me.Label5Edit = New System.Windows.Forms.Label()
        Me.TextBoxMailEdit = New System.Windows.Forms.TextBox()
        Me.Label4Edit = New System.Windows.Forms.Label()
        Me.TextBoxTelefonoEdit = New System.Windows.Forms.TextBox()
        Me.Label3Edit = New System.Windows.Forms.Label()
        Me.TextBoxDireccionEdit = New System.Windows.Forms.TextBox()
        Me.Label2Edit = New System.Windows.Forms.Label()
        Me.TextBoxNameEdit = New System.Windows.Forms.TextBox()
        Me.Label1Edit = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.FotoEdit = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtRfc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAdress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Add = New System.Windows.Forms.Button()
        Me.Foto = New System.Windows.Forms.PictureBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.FotoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 29)
        Me.MenuStrip1.TabIndex = 0
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
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(77, 25)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar reporte"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(957, 421)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Table)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(949, 388)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Clientes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Table
        '
        Me.Table.BackgroundColor = System.Drawing.SystemColors.Control
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(3, 3)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(943, 382)
        Me.Table.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.TextBoxRazonSocialEdit)
        Me.TabPage2.Controls.Add(Me.Label6Edit)
        Me.TabPage2.Controls.Add(Me.TextBoxRfcEdit)
        Me.TabPage2.Controls.Add(Me.Label5Edit)
        Me.TabPage2.Controls.Add(Me.TextBoxMailEdit)
        Me.TabPage2.Controls.Add(Me.Label4Edit)
        Me.TabPage2.Controls.Add(Me.TextBoxTelefonoEdit)
        Me.TabPage2.Controls.Add(Me.Label3Edit)
        Me.TabPage2.Controls.Add(Me.TextBoxDireccionEdit)
        Me.TabPage2.Controls.Add(Me.Label2Edit)
        Me.TabPage2.Controls.Add(Me.TextBoxNameEdit)
        Me.TabPage2.Controls.Add(Me.Label1Edit)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button3)
        Me.TabPage2.Controls.Add(Me.FotoEdit)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(949, 388)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        '
        'TextBoxRazonSocialEdit
        '
        Me.TextBoxRazonSocialEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRazonSocialEdit.Location = New System.Drawing.Point(31, 345)
        Me.TextBoxRazonSocialEdit.Name = "TextBoxRazonSocialEdit"
        Me.TextBoxRazonSocialEdit.Size = New System.Drawing.Size(454, 26)
        Me.TextBoxRazonSocialEdit.TabIndex = 6
        '
        'Label6Edit
        '
        Me.Label6Edit.AutoSize = True
        Me.Label6Edit.Location = New System.Drawing.Point(31, 318)
        Me.Label6Edit.Name = "Label6Edit"
        Me.Label6Edit.Size = New System.Drawing.Size(106, 20)
        Me.Label6Edit.TabIndex = 40
        Me.Label6Edit.Text = "Razon social"
        '
        'TextBoxRfcEdit
        '
        Me.TextBoxRfcEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxRfcEdit.Location = New System.Drawing.Point(31, 285)
        Me.TextBoxRfcEdit.Name = "TextBoxRfcEdit"
        Me.TextBoxRfcEdit.Size = New System.Drawing.Size(454, 26)
        Me.TextBoxRfcEdit.TabIndex = 5
        '
        'Label5Edit
        '
        Me.Label5Edit.AutoSize = True
        Me.Label5Edit.Location = New System.Drawing.Point(31, 258)
        Me.Label5Edit.Name = "Label5Edit"
        Me.Label5Edit.Size = New System.Drawing.Size(35, 20)
        Me.Label5Edit.TabIndex = 38
        Me.Label5Edit.Text = "Rfc"
        '
        'TextBoxMailEdit
        '
        Me.TextBoxMailEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxMailEdit.Location = New System.Drawing.Point(31, 225)
        Me.TextBoxMailEdit.Name = "TextBoxMailEdit"
        Me.TextBoxMailEdit.Size = New System.Drawing.Size(454, 26)
        Me.TextBoxMailEdit.TabIndex = 4
        '
        'Label4Edit
        '
        Me.Label4Edit.AutoSize = True
        Me.Label4Edit.Location = New System.Drawing.Point(31, 198)
        Me.Label4Edit.Name = "Label4Edit"
        Me.Label4Edit.Size = New System.Drawing.Size(40, 20)
        Me.Label4Edit.TabIndex = 36
        Me.Label4Edit.Text = "Mail"
        '
        'TextBoxTelefonoEdit
        '
        Me.TextBoxTelefonoEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxTelefonoEdit.Location = New System.Drawing.Point(31, 165)
        Me.TextBoxTelefonoEdit.Name = "TextBoxTelefonoEdit"
        Me.TextBoxTelefonoEdit.Size = New System.Drawing.Size(454, 26)
        Me.TextBoxTelefonoEdit.TabIndex = 3
        '
        'Label3Edit
        '
        Me.Label3Edit.AutoSize = True
        Me.Label3Edit.Location = New System.Drawing.Point(31, 138)
        Me.Label3Edit.Name = "Label3Edit"
        Me.Label3Edit.Size = New System.Drawing.Size(73, 20)
        Me.Label3Edit.TabIndex = 34
        Me.Label3Edit.Text = "Telefono"
        '
        'TextBoxDireccionEdit
        '
        Me.TextBoxDireccionEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDireccionEdit.Location = New System.Drawing.Point(31, 105)
        Me.TextBoxDireccionEdit.Name = "TextBoxDireccionEdit"
        Me.TextBoxDireccionEdit.Size = New System.Drawing.Size(454, 26)
        Me.TextBoxDireccionEdit.TabIndex = 2
        '
        'Label2Edit
        '
        Me.Label2Edit.AutoSize = True
        Me.Label2Edit.Location = New System.Drawing.Point(31, 78)
        Me.Label2Edit.Name = "Label2Edit"
        Me.Label2Edit.Size = New System.Drawing.Size(81, 20)
        Me.Label2Edit.TabIndex = 32
        Me.Label2Edit.Text = "Direccion"
        '
        'TextBoxNameEdit
        '
        Me.TextBoxNameEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNameEdit.Location = New System.Drawing.Point(31, 45)
        Me.TextBoxNameEdit.Name = "TextBoxNameEdit"
        Me.TextBoxNameEdit.Size = New System.Drawing.Size(454, 26)
        Me.TextBoxNameEdit.TabIndex = 1
        '
        'Label1Edit
        '
        Me.Label1Edit.AutoSize = True
        Me.Label1Edit.Location = New System.Drawing.Point(31, 18)
        Me.Label1Edit.Name = "Label1Edit"
        Me.Label1Edit.Size = New System.Drawing.Size(68, 20)
        Me.Label1Edit.TabIndex = 30
        Me.Label1Edit.Text = "Nombre"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(625, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 42)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Fotografia"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(774, 204)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 42)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Actualizar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FotoEdit
        '
        Me.FotoEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FotoEdit.BackColor = System.Drawing.SystemColors.Control
        Me.FotoEdit.Location = New System.Drawing.Point(560, 40)
        Me.FotoEdit.Name = "FotoEdit"
        Me.FotoEdit.Size = New System.Drawing.Size(357, 146)
        Me.FotoEdit.TabIndex = 27
        Me.FotoEdit.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.TxtRazonSocial)
        Me.TabPage3.Controls.Add(Me.Label7)
        Me.TabPage3.Controls.Add(Me.TxtRfc)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.TxtMail)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.TxtPhone)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.TxtAdress)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.TxtName)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Controls.Add(Me.Add)
        Me.TabPage3.Controls.Add(Me.Foto)
        Me.TabPage3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(949, 388)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Agregar"
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRazonSocial.Location = New System.Drawing.Point(12, 339)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.Size = New System.Drawing.Size(454, 26)
        Me.TxtRazonSocial.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 312)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Razon social"
        '
        'TxtRfc
        '
        Me.TxtRfc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRfc.Location = New System.Drawing.Point(12, 279)
        Me.TxtRfc.Name = "TxtRfc"
        Me.TxtRfc.Size = New System.Drawing.Size(454, 26)
        Me.TxtRfc.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Rfc"
        '
        'TxtMail
        '
        Me.TxtMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMail.Location = New System.Drawing.Point(12, 219)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(454, 26)
        Me.TxtMail.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Mail"
        '
        'TxtPhone
        '
        Me.TxtPhone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPhone.Location = New System.Drawing.Point(12, 159)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(454, 26)
        Me.TxtPhone.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Telefono"
        '
        'TxtAdress
        '
        Me.TxtAdress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtAdress.Location = New System.Drawing.Point(12, 99)
        Me.TxtAdress.Name = "TxtAdress"
        Me.TxtAdress.Size = New System.Drawing.Size(454, 26)
        Me.TxtAdress.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Direccion"
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.Location = New System.Drawing.Point(12, 39)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(454, 26)
        Me.TxtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(606, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 42)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Fotografia"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add.Location = New System.Drawing.Point(755, 198)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(143, 42)
        Me.Add.TabIndex = 8
        Me.Add.Text = "Agregar"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Foto
        '
        Me.Foto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Foto.BackColor = System.Drawing.SystemColors.Control
        Me.Foto.Location = New System.Drawing.Point(541, 34)
        Me.Foto.Name = "Foto"
        Me.Foto.Size = New System.Drawing.Size(357, 146)
        Me.Foto.TabIndex = 12
        Me.Foto.TabStop = False
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
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Clientes"
        Me.Text = "Clientes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.FotoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Table As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents Add As Button
    Friend WithEvents Foto As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtRazonSocial As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtRfc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtAdress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxRazonSocialEdit As TextBox
    Friend WithEvents Label6Edit As Label
    Friend WithEvents TextBoxRfcEdit As TextBox
    Friend WithEvents Label5Edit As Label
    Friend WithEvents TextBoxMailEdit As TextBox
    Friend WithEvents Label4Edit As Label
    Friend WithEvents TextBoxTelefonoEdit As TextBox
    Friend WithEvents Label3Edit As Label
    Friend WithEvents TextBoxDireccionEdit As TextBox
    Friend WithEvents Label2Edit As Label
    Friend WithEvents TextBoxNameEdit As TextBox
    Friend WithEvents Label1Edit As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents FotoEdit As PictureBox
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents TxtSearch As ToolStripTextBox
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
End Class
