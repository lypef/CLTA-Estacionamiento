<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Vehicles
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
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtRfid_Edit = New System.Windows.Forms.TextBox()
        Me.LabelRfid_Edit = New System.Windows.Forms.Label()
        Me.ComboBoxTarifaEdit = New System.Windows.Forms.ComboBox()
        Me.ImageClientEdit = New System.Windows.Forms.PictureBox()
        Me.ComboClientsEdit = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.EstadoTextboxEdit = New System.Windows.Forms.TextBox()
        Me.EstadoLabelEdit = New System.Windows.Forms.Label()
        Me.ColorTextBoxEdit = New System.Windows.Forms.TextBox()
        Me.ColorLabelEdit = New System.Windows.Forms.Label()
        Me.ModeloTextBoxEdit = New System.Windows.Forms.TextBox()
        Me.ModeloLabelEdit = New System.Windows.Forms.Label()
        Me.MatriculaTextBoxEdit = New System.Windows.Forms.TextBox()
        Me.MatriculaLabelEdit = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtRfid = New System.Windows.Forms.TextBox()
        Me.LabelRfid = New System.Windows.Forms.Label()
        Me.ComboBoxTarifa = New System.Windows.Forms.ComboBox()
        Me.ImageClient = New System.Windows.Forms.PictureBox()
        Me.ComboClients = New System.Windows.Forms.ComboBox()
        Me.Add = New System.Windows.Forms.Button()
        Me.Estado_Textbox = New System.Windows.Forms.TextBox()
        Me.Estado_Label = New System.Windows.Forms.Label()
        Me.Color_Textbox = New System.Windows.Forms.TextBox()
        Me.Color_label = New System.Windows.Forms.Label()
        Me.ModeloTextBox = New System.Windows.Forms.TextBox()
        Me.ModeloLabel = New System.Windows.Forms.Label()
        Me.Matricula_Textbox = New System.Windows.Forms.TextBox()
        Me.Matricula_label = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.ImageClientEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ImageClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.TxtSearch, Me.VehiculosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 29)
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
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem})
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(88, 25)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculos"
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
        Me.TabControl1.Location = New System.Drawing.Point(0, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(957, 421)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Table)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(949, 395)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Vehiculos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Table
        '
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(3, 3)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(943, 389)
        Me.Table.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.TxtRfid_Edit)
        Me.TabPage2.Controls.Add(Me.LabelRfid_Edit)
        Me.TabPage2.Controls.Add(Me.ComboBoxTarifaEdit)
        Me.TabPage2.Controls.Add(Me.ImageClientEdit)
        Me.TabPage2.Controls.Add(Me.ComboClientsEdit)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.EstadoTextboxEdit)
        Me.TabPage2.Controls.Add(Me.EstadoLabelEdit)
        Me.TabPage2.Controls.Add(Me.ColorTextBoxEdit)
        Me.TabPage2.Controls.Add(Me.ColorLabelEdit)
        Me.TabPage2.Controls.Add(Me.ModeloTextBoxEdit)
        Me.TabPage2.Controls.Add(Me.ModeloLabelEdit)
        Me.TabPage2.Controls.Add(Me.MatriculaTextBoxEdit)
        Me.TabPage2.Controls.Add(Me.MatriculaLabelEdit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(949, 395)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        '
        'TxtRfid_Edit
        '
        Me.TxtRfid_Edit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRfid_Edit.Location = New System.Drawing.Point(8, 106)
        Me.TxtRfid_Edit.Name = "TxtRfid_Edit"
        Me.TxtRfid_Edit.Size = New System.Drawing.Size(457, 20)
        Me.TxtRfid_Edit.TabIndex = 53
        '
        'LabelRfid_Edit
        '
        Me.LabelRfid_Edit.AutoSize = True
        Me.LabelRfid_Edit.Location = New System.Drawing.Point(8, 85)
        Me.LabelRfid_Edit.Name = "LabelRfid_Edit"
        Me.LabelRfid_Edit.Size = New System.Drawing.Size(32, 13)
        Me.LabelRfid_Edit.TabIndex = 54
        Me.LabelRfid_Edit.Text = "RFID"
        '
        'ComboBoxTarifaEdit
        '
        Me.ComboBoxTarifaEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTarifaEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTarifaEdit.FormattingEnabled = True
        Me.ComboBoxTarifaEdit.Location = New System.Drawing.Point(8, 56)
        Me.ComboBoxTarifaEdit.Name = "ComboBoxTarifaEdit"
        Me.ComboBoxTarifaEdit.Size = New System.Drawing.Size(457, 21)
        Me.ComboBoxTarifaEdit.TabIndex = 52
        '
        'ImageClientEdit
        '
        Me.ImageClientEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageClientEdit.BackColor = System.Drawing.SystemColors.Control
        Me.ImageClientEdit.Location = New System.Drawing.Point(481, 17)
        Me.ImageClientEdit.Name = "ImageClientEdit"
        Me.ImageClientEdit.Size = New System.Drawing.Size(459, 229)
        Me.ImageClientEdit.TabIndex = 51
        Me.ImageClientEdit.TabStop = False
        '
        'ComboClientsEdit
        '
        Me.ComboClientsEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboClientsEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboClientsEdit.FormattingEnabled = True
        Me.ComboClientsEdit.Location = New System.Drawing.Point(8, 17)
        Me.ComboClientsEdit.Name = "ComboClientsEdit"
        Me.ComboClientsEdit.Size = New System.Drawing.Size(457, 21)
        Me.ComboClientsEdit.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(797, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 42)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'EstadoTextboxEdit
        '
        Me.EstadoTextboxEdit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstadoTextboxEdit.Location = New System.Drawing.Point(8, 302)
        Me.EstadoTextboxEdit.Multiline = True
        Me.EstadoTextboxEdit.Name = "EstadoTextboxEdit"
        Me.EstadoTextboxEdit.Size = New System.Drawing.Size(457, 82)
        Me.EstadoTextboxEdit.TabIndex = 44
        '
        'EstadoLabelEdit
        '
        Me.EstadoLabelEdit.AutoSize = True
        Me.EstadoLabelEdit.Location = New System.Drawing.Point(8, 281)
        Me.EstadoLabelEdit.Name = "EstadoLabelEdit"
        Me.EstadoLabelEdit.Size = New System.Drawing.Size(128, 13)
        Me.EstadoLabelEdit.TabIndex = 48
        Me.EstadoLabelEdit.Text = "Condiciones del vehiculo "
        '
        'ColorTextBoxEdit
        '
        Me.ColorTextBoxEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ColorTextBoxEdit.Location = New System.Drawing.Point(8, 253)
        Me.ColorTextBoxEdit.Name = "ColorTextBoxEdit"
        Me.ColorTextBoxEdit.Size = New System.Drawing.Size(457, 20)
        Me.ColorTextBoxEdit.TabIndex = 43
        '
        'ColorLabelEdit
        '
        Me.ColorLabelEdit.AutoSize = True
        Me.ColorLabelEdit.Location = New System.Drawing.Point(8, 232)
        Me.ColorLabelEdit.Name = "ColorLabelEdit"
        Me.ColorLabelEdit.Size = New System.Drawing.Size(31, 13)
        Me.ColorLabelEdit.TabIndex = 47
        Me.ColorLabelEdit.Text = "Color"
        '
        'ModeloTextBoxEdit
        '
        Me.ModeloTextBoxEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeloTextBoxEdit.Location = New System.Drawing.Point(8, 204)
        Me.ModeloTextBoxEdit.Name = "ModeloTextBoxEdit"
        Me.ModeloTextBoxEdit.Size = New System.Drawing.Size(457, 20)
        Me.ModeloTextBoxEdit.TabIndex = 42
        '
        'ModeloLabelEdit
        '
        Me.ModeloLabelEdit.AutoSize = True
        Me.ModeloLabelEdit.Location = New System.Drawing.Point(8, 183)
        Me.ModeloLabelEdit.Name = "ModeloLabelEdit"
        Me.ModeloLabelEdit.Size = New System.Drawing.Size(42, 13)
        Me.ModeloLabelEdit.TabIndex = 46
        Me.ModeloLabelEdit.Text = "Modelo"
        '
        'MatriculaTextBoxEdit
        '
        Me.MatriculaTextBoxEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MatriculaTextBoxEdit.Location = New System.Drawing.Point(8, 155)
        Me.MatriculaTextBoxEdit.Name = "MatriculaTextBoxEdit"
        Me.MatriculaTextBoxEdit.Size = New System.Drawing.Size(457, 20)
        Me.MatriculaTextBoxEdit.TabIndex = 41
        '
        'MatriculaLabelEdit
        '
        Me.MatriculaLabelEdit.AutoSize = True
        Me.MatriculaLabelEdit.Location = New System.Drawing.Point(8, 134)
        Me.MatriculaLabelEdit.Name = "MatriculaLabelEdit"
        Me.MatriculaLabelEdit.Size = New System.Drawing.Size(50, 13)
        Me.MatriculaLabelEdit.TabIndex = 45
        Me.MatriculaLabelEdit.Text = "Matricula"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.TxtRfid)
        Me.TabPage3.Controls.Add(Me.LabelRfid)
        Me.TabPage3.Controls.Add(Me.ComboBoxTarifa)
        Me.TabPage3.Controls.Add(Me.ImageClient)
        Me.TabPage3.Controls.Add(Me.ComboClients)
        Me.TabPage3.Controls.Add(Me.Add)
        Me.TabPage3.Controls.Add(Me.Estado_Textbox)
        Me.TabPage3.Controls.Add(Me.Estado_Label)
        Me.TabPage3.Controls.Add(Me.Color_Textbox)
        Me.TabPage3.Controls.Add(Me.Color_label)
        Me.TabPage3.Controls.Add(Me.ModeloTextBox)
        Me.TabPage3.Controls.Add(Me.ModeloLabel)
        Me.TabPage3.Controls.Add(Me.Matricula_Textbox)
        Me.TabPage3.Controls.Add(Me.Matricula_label)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(949, 395)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Agregar"
        '
        'TxtRfid
        '
        Me.TxtRfid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtRfid.Location = New System.Drawing.Point(7, 103)
        Me.TxtRfid.Name = "TxtRfid"
        Me.TxtRfid.Size = New System.Drawing.Size(457, 20)
        Me.TxtRfid.TabIndex = 3
        '
        'LabelRfid
        '
        Me.LabelRfid.AutoSize = True
        Me.LabelRfid.Location = New System.Drawing.Point(7, 82)
        Me.LabelRfid.Name = "LabelRfid"
        Me.LabelRfid.Size = New System.Drawing.Size(32, 13)
        Me.LabelRfid.TabIndex = 43
        Me.LabelRfid.Text = "RFID"
        '
        'ComboBoxTarifa
        '
        Me.ComboBoxTarifa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTarifa.FormattingEnabled = True
        Me.ComboBoxTarifa.Location = New System.Drawing.Point(7, 48)
        Me.ComboBoxTarifa.Name = "ComboBoxTarifa"
        Me.ComboBoxTarifa.Size = New System.Drawing.Size(457, 21)
        Me.ComboBoxTarifa.TabIndex = 2
        '
        'ImageClient
        '
        Me.ImageClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageClient.BackColor = System.Drawing.SystemColors.Control
        Me.ImageClient.Location = New System.Drawing.Point(482, 11)
        Me.ImageClient.Name = "ImageClient"
        Me.ImageClient.Size = New System.Drawing.Size(459, 229)
        Me.ImageClient.TabIndex = 40
        Me.ImageClient.TabStop = False
        '
        'ComboClients
        '
        Me.ComboClients.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboClients.FormattingEnabled = True
        Me.ComboClients.Location = New System.Drawing.Point(7, 11)
        Me.ComboClients.Name = "ComboClients"
        Me.ComboClients.Size = New System.Drawing.Size(457, 21)
        Me.ComboClients.TabIndex = 1
        '
        'Add
        '
        Me.Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add.Location = New System.Drawing.Point(798, 246)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(143, 42)
        Me.Add.TabIndex = 8
        Me.Add.Text = "Agregar"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Estado_Textbox
        '
        Me.Estado_Textbox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Estado_Textbox.Location = New System.Drawing.Point(7, 299)
        Me.Estado_Textbox.Multiline = True
        Me.Estado_Textbox.Name = "Estado_Textbox"
        Me.Estado_Textbox.Size = New System.Drawing.Size(457, 86)
        Me.Estado_Textbox.TabIndex = 7
        '
        'Estado_Label
        '
        Me.Estado_Label.AutoSize = True
        Me.Estado_Label.Location = New System.Drawing.Point(7, 278)
        Me.Estado_Label.Name = "Estado_Label"
        Me.Estado_Label.Size = New System.Drawing.Size(128, 13)
        Me.Estado_Label.TabIndex = 36
        Me.Estado_Label.Text = "Condiciones del vehiculo "
        '
        'Color_Textbox
        '
        Me.Color_Textbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Color_Textbox.Location = New System.Drawing.Point(7, 250)
        Me.Color_Textbox.Name = "Color_Textbox"
        Me.Color_Textbox.Size = New System.Drawing.Size(457, 20)
        Me.Color_Textbox.TabIndex = 6
        '
        'Color_label
        '
        Me.Color_label.AutoSize = True
        Me.Color_label.Location = New System.Drawing.Point(7, 229)
        Me.Color_label.Name = "Color_label"
        Me.Color_label.Size = New System.Drawing.Size(31, 13)
        Me.Color_label.TabIndex = 34
        Me.Color_label.Text = "Color"
        '
        'ModeloTextBox
        '
        Me.ModeloTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModeloTextBox.Location = New System.Drawing.Point(7, 201)
        Me.ModeloTextBox.Name = "ModeloTextBox"
        Me.ModeloTextBox.Size = New System.Drawing.Size(457, 20)
        Me.ModeloTextBox.TabIndex = 5
        '
        'ModeloLabel
        '
        Me.ModeloLabel.AutoSize = True
        Me.ModeloLabel.Location = New System.Drawing.Point(7, 180)
        Me.ModeloLabel.Name = "ModeloLabel"
        Me.ModeloLabel.Size = New System.Drawing.Size(42, 13)
        Me.ModeloLabel.TabIndex = 33
        Me.ModeloLabel.Text = "Modelo"
        '
        'Matricula_Textbox
        '
        Me.Matricula_Textbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Matricula_Textbox.Location = New System.Drawing.Point(7, 152)
        Me.Matricula_Textbox.Name = "Matricula_Textbox"
        Me.Matricula_Textbox.Size = New System.Drawing.Size(457, 20)
        Me.Matricula_Textbox.TabIndex = 4
        '
        'Matricula_label
        '
        Me.Matricula_label.AutoSize = True
        Me.Matricula_label.Location = New System.Drawing.Point(7, 131)
        Me.Matricula_label.Name = "Matricula_label"
        Me.Matricula_label.Size = New System.Drawing.Size(50, 13)
        Me.Matricula_label.TabIndex = 32
        Me.Matricula_label.Text = "Matricula"
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
        'Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Vehicles"
        Me.Text = "Vehicles"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.ImageClientEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.ImageClient, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Table As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Estado_Textbox As TextBox
    Friend WithEvents Estado_Label As Label
    Friend WithEvents Color_Textbox As TextBox
    Friend WithEvents Color_label As Label
    Friend WithEvents ModeloTextBox As TextBox
    Friend WithEvents ModeloLabel As Label
    Friend WithEvents Matricula_Textbox As TextBox
    Friend WithEvents Matricula_label As Label
    Friend WithEvents Add As Button
    Friend WithEvents ComboClients As ComboBox
    Friend WithEvents ImageClient As PictureBox
    Friend WithEvents ImageClientEdit As PictureBox
    Friend WithEvents ComboClientsEdit As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents EstadoTextboxEdit As TextBox
    Friend WithEvents EstadoLabelEdit As Label
    Friend WithEvents ColorTextBoxEdit As TextBox
    Friend WithEvents ColorLabelEdit As Label
    Friend WithEvents ModeloTextBoxEdit As TextBox
    Friend WithEvents ModeloLabelEdit As Label
    Friend WithEvents MatriculaTextBoxEdit As TextBox
    Friend WithEvents MatriculaLabelEdit As Label
    Friend WithEvents ComboBoxTarifa As ComboBox
    Friend WithEvents ComboBoxTarifaEdit As ComboBox
    Friend WithEvents TxtRfid As TextBox
    Friend WithEvents LabelRfid As Label
    Friend WithEvents TxtRfid_Edit As TextBox
    Friend WithEvents LabelRfid_Edit As Label
    Friend WithEvents VehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
End Class
