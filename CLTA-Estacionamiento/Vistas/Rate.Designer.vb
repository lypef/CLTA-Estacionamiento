<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rate
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
        Me.ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.TarifasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtHoursXDiaEdit = New System.Windows.Forms.TextBox()
        Me.LabelHoursXDiaEdit = New System.Windows.Forms.Label()
        Me.TxtTarifaDiasEdit = New System.Windows.Forms.TextBox()
        Me.LabelTarifaDiasEdit = New System.Windows.Forms.Label()
        Me.TxtTarifaPensionEdit = New System.Windows.Forms.TextBox()
        Me.LabelTarifaPensionEdit = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtMinToleEdit = New System.Windows.Forms.TextBox()
        Me.UseFraccionesEdit = New System.Windows.Forms.CheckBox()
        Me.TxtPrecioDiaEdit = New System.Windows.Forms.TextBox()
        Me.LabelPrecioDiaEdit = New System.Windows.Forms.Label()
        Me.TxtPrecioHoraEdit = New System.Windows.Forms.TextBox()
        Me.LabelPrecioHoraEdit = New System.Windows.Forms.Label()
        Me.TxtCostoMinEdit = New System.Windows.Forms.TextBox()
        Me.LabelCostoMinEdit = New System.Windows.Forms.Label()
        Me.LabelMinToleEdit = New System.Windows.Forms.Label()
        Me.TxtNombreEdit = New System.Windows.Forms.TextBox()
        Me.LabelNombreEdit = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TxtHoursXDia = New System.Windows.Forms.TextBox()
        Me.LabelHoursXDia = New System.Windows.Forms.Label()
        Me.TxtDiasPendion = New System.Windows.Forms.TextBox()
        Me.LabelDiasPendion = New System.Windows.Forms.Label()
        Me.TxtTarifaPension = New System.Windows.Forms.TextBox()
        Me.LabelTarifaPension = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Button()
        Me.TxtMinTolerancia = New System.Windows.Forms.TextBox()
        Me.UsarFracciones = New System.Windows.Forms.CheckBox()
        Me.TxtPrcieXDia = New System.Windows.Forms.TextBox()
        Me.LabelPrcieXDia = New System.Windows.Forms.Label()
        Me.TxtPrcieXHora = New System.Windows.Forms.TextBox()
        Me.LabelPrcieXHora = New System.Windows.Forms.Label()
        Me.TxtCostoMinimo = New System.Windows.Forms.TextBox()
        Me.LabelCostoMinimo = New System.Windows.Forms.Label()
        Me.LabelMinTolerancia = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.TxtSearch, Me.TarifasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(957, 29)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem
        '
        Me.ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_exit
        Me.ToolStripMenuItem.Name = "ToolStripMenuItem"
        Me.ToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripMenuItem.Size = New System.Drawing.Size(69, 25)
        Me.ToolStripMenuItem.Text = "Salir"
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
        'TarifasToolStripMenuItem
        '
        Me.TarifasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarReporteToolStripMenuItem})
        Me.TarifasToolStripMenuItem.Name = "TarifasToolStripMenuItem"
        Me.TarifasToolStripMenuItem.Size = New System.Drawing.Size(66, 25)
        Me.TarifasToolStripMenuItem.Text = "Tarifas"
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
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Table)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(949, 395)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Tarifas"
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
        Me.TabPage2.Controls.Add(Me.TxtHoursXDiaEdit)
        Me.TabPage2.Controls.Add(Me.LabelHoursXDiaEdit)
        Me.TabPage2.Controls.Add(Me.TxtTarifaDiasEdit)
        Me.TabPage2.Controls.Add(Me.LabelTarifaDiasEdit)
        Me.TabPage2.Controls.Add(Me.TxtTarifaPensionEdit)
        Me.TabPage2.Controls.Add(Me.LabelTarifaPensionEdit)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.TxtMinToleEdit)
        Me.TabPage2.Controls.Add(Me.UseFraccionesEdit)
        Me.TabPage2.Controls.Add(Me.TxtPrecioDiaEdit)
        Me.TabPage2.Controls.Add(Me.LabelPrecioDiaEdit)
        Me.TabPage2.Controls.Add(Me.TxtPrecioHoraEdit)
        Me.TabPage2.Controls.Add(Me.LabelPrecioHoraEdit)
        Me.TabPage2.Controls.Add(Me.TxtCostoMinEdit)
        Me.TabPage2.Controls.Add(Me.LabelCostoMinEdit)
        Me.TabPage2.Controls.Add(Me.LabelMinToleEdit)
        Me.TabPage2.Controls.Add(Me.TxtNombreEdit)
        Me.TabPage2.Controls.Add(Me.LabelNombreEdit)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(949, 395)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Editar"
        '
        'TxtHoursXDiaEdit
        '
        Me.TxtHoursXDiaEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHoursXDiaEdit.Location = New System.Drawing.Point(249, 269)
        Me.TxtHoursXDiaEdit.Name = "TxtHoursXDiaEdit"
        Me.TxtHoursXDiaEdit.Size = New System.Drawing.Size(218, 20)
        Me.TxtHoursXDiaEdit.TabIndex = 6
        '
        'LabelHoursXDiaEdit
        '
        Me.LabelHoursXDiaEdit.AutoSize = True
        Me.LabelHoursXDiaEdit.Location = New System.Drawing.Point(246, 251)
        Me.LabelHoursXDiaEdit.Name = "LabelHoursXDiaEdit"
        Me.LabelHoursXDiaEdit.Size = New System.Drawing.Size(60, 13)
        Me.LabelHoursXDiaEdit.TabIndex = 43
        Me.LabelHoursXDiaEdit.Text = "Horas x dia"
        '
        'TxtTarifaDiasEdit
        '
        Me.TxtTarifaDiasEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTarifaDiasEdit.Location = New System.Drawing.Point(249, 319)
        Me.TxtTarifaDiasEdit.Name = "TxtTarifaDiasEdit"
        Me.TxtTarifaDiasEdit.Size = New System.Drawing.Size(218, 20)
        Me.TxtTarifaDiasEdit.TabIndex = 8
        '
        'LabelTarifaDiasEdit
        '
        Me.LabelTarifaDiasEdit.AutoSize = True
        Me.LabelTarifaDiasEdit.Location = New System.Drawing.Point(246, 301)
        Me.LabelTarifaDiasEdit.Name = "LabelTarifaDiasEdit"
        Me.LabelTarifaDiasEdit.Size = New System.Drawing.Size(69, 13)
        Me.LabelTarifaDiasEdit.TabIndex = 41
        Me.LabelTarifaDiasEdit.Text = "Dias Pension"
        '
        'TxtTarifaPensionEdit
        '
        Me.TxtTarifaPensionEdit.Location = New System.Drawing.Point(13, 319)
        Me.TxtTarifaPensionEdit.Name = "TxtTarifaPensionEdit"
        Me.TxtTarifaPensionEdit.Size = New System.Drawing.Size(215, 20)
        Me.TxtTarifaPensionEdit.TabIndex = 7
        '
        'LabelTarifaPensionEdit
        '
        Me.LabelTarifaPensionEdit.AutoSize = True
        Me.LabelTarifaPensionEdit.Location = New System.Drawing.Point(15, 301)
        Me.LabelTarifaPensionEdit.Name = "LabelTarifaPensionEdit"
        Me.LabelTarifaPensionEdit.Size = New System.Drawing.Size(75, 13)
        Me.LabelTarifaPensionEdit.TabIndex = 40
        Me.LabelTarifaPensionEdit.Text = "Tarifa Pension"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(324, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtMinToleEdit
        '
        Me.TxtMinToleEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMinToleEdit.Location = New System.Drawing.Point(13, 97)
        Me.TxtMinToleEdit.Name = "TxtMinToleEdit"
        Me.TxtMinToleEdit.Size = New System.Drawing.Size(454, 20)
        Me.TxtMinToleEdit.TabIndex = 2
        '
        'UseFraccionesEdit
        '
        Me.UseFraccionesEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UseFraccionesEdit.AutoSize = True
        Me.UseFraccionesEdit.Location = New System.Drawing.Point(59, 359)
        Me.UseFraccionesEdit.Name = "UseFraccionesEdit"
        Me.UseFraccionesEdit.Size = New System.Drawing.Size(100, 17)
        Me.UseFraccionesEdit.TabIndex = 9
        Me.UseFraccionesEdit.Text = "Usar fracciones"
        Me.UseFraccionesEdit.UseVisualStyleBackColor = True
        '
        'TxtPrecioDiaEdit
        '
        Me.TxtPrecioDiaEdit.Location = New System.Drawing.Point(13, 269)
        Me.TxtPrecioDiaEdit.Name = "TxtPrecioDiaEdit"
        Me.TxtPrecioDiaEdit.Size = New System.Drawing.Size(215, 20)
        Me.TxtPrecioDiaEdit.TabIndex = 5
        '
        'LabelPrecioDiaEdit
        '
        Me.LabelPrecioDiaEdit.AutoSize = True
        Me.LabelPrecioDiaEdit.Location = New System.Drawing.Point(15, 251)
        Me.LabelPrecioDiaEdit.Name = "LabelPrecioDiaEdit"
        Me.LabelPrecioDiaEdit.Size = New System.Drawing.Size(62, 13)
        Me.LabelPrecioDiaEdit.TabIndex = 37
        Me.LabelPrecioDiaEdit.Text = "Precio x dia"
        '
        'TxtPrecioHoraEdit
        '
        Me.TxtPrecioHoraEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrecioHoraEdit.Location = New System.Drawing.Point(13, 214)
        Me.TxtPrecioHoraEdit.Name = "TxtPrecioHoraEdit"
        Me.TxtPrecioHoraEdit.Size = New System.Drawing.Size(454, 20)
        Me.TxtPrecioHoraEdit.TabIndex = 4
        '
        'LabelPrecioHoraEdit
        '
        Me.LabelPrecioHoraEdit.AutoSize = True
        Me.LabelPrecioHoraEdit.Location = New System.Drawing.Point(15, 196)
        Me.LabelPrecioHoraEdit.Name = "LabelPrecioHoraEdit"
        Me.LabelPrecioHoraEdit.Size = New System.Drawing.Size(69, 13)
        Me.LabelPrecioHoraEdit.TabIndex = 36
        Me.LabelPrecioHoraEdit.Text = "Precio x hora"
        '
        'TxtCostoMinEdit
        '
        Me.TxtCostoMinEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCostoMinEdit.Location = New System.Drawing.Point(13, 160)
        Me.TxtCostoMinEdit.Name = "TxtCostoMinEdit"
        Me.TxtCostoMinEdit.Size = New System.Drawing.Size(454, 20)
        Me.TxtCostoMinEdit.TabIndex = 3
        '
        'LabelCostoMinEdit
        '
        Me.LabelCostoMinEdit.AutoSize = True
        Me.LabelCostoMinEdit.Location = New System.Drawing.Point(15, 142)
        Me.LabelCostoMinEdit.Name = "LabelCostoMinEdit"
        Me.LabelCostoMinEdit.Size = New System.Drawing.Size(69, 13)
        Me.LabelCostoMinEdit.TabIndex = 35
        Me.LabelCostoMinEdit.Text = "Costo minimo"
        '
        'LabelMinToleEdit
        '
        Me.LabelMinToleEdit.AutoSize = True
        Me.LabelMinToleEdit.Location = New System.Drawing.Point(10, 79)
        Me.LabelMinToleEdit.Name = "LabelMinToleEdit"
        Me.LabelMinToleEdit.Size = New System.Drawing.Size(108, 13)
        Me.LabelMinToleEdit.TabIndex = 34
        Me.LabelMinToleEdit.Text = "Minutos de tolerancia"
        '
        'TxtNombreEdit
        '
        Me.TxtNombreEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreEdit.Location = New System.Drawing.Point(13, 38)
        Me.TxtNombreEdit.Name = "TxtNombreEdit"
        Me.TxtNombreEdit.Size = New System.Drawing.Size(454, 20)
        Me.TxtNombreEdit.TabIndex = 1
        '
        'LabelNombreEdit
        '
        Me.LabelNombreEdit.AutoSize = True
        Me.LabelNombreEdit.Location = New System.Drawing.Point(10, 20)
        Me.LabelNombreEdit.Name = "LabelNombreEdit"
        Me.LabelNombreEdit.Size = New System.Drawing.Size(70, 13)
        Me.LabelNombreEdit.TabIndex = 33
        Me.LabelNombreEdit.Text = "Nombre tarifa"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.TxtHoursXDia)
        Me.TabPage3.Controls.Add(Me.LabelHoursXDia)
        Me.TabPage3.Controls.Add(Me.TxtDiasPendion)
        Me.TabPage3.Controls.Add(Me.LabelDiasPendion)
        Me.TabPage3.Controls.Add(Me.TxtTarifaPension)
        Me.TabPage3.Controls.Add(Me.LabelTarifaPension)
        Me.TabPage3.Controls.Add(Me.Add)
        Me.TabPage3.Controls.Add(Me.TxtMinTolerancia)
        Me.TabPage3.Controls.Add(Me.UsarFracciones)
        Me.TabPage3.Controls.Add(Me.TxtPrcieXDia)
        Me.TabPage3.Controls.Add(Me.LabelPrcieXDia)
        Me.TabPage3.Controls.Add(Me.TxtPrcieXHora)
        Me.TabPage3.Controls.Add(Me.LabelPrcieXHora)
        Me.TabPage3.Controls.Add(Me.TxtCostoMinimo)
        Me.TabPage3.Controls.Add(Me.LabelCostoMinimo)
        Me.TabPage3.Controls.Add(Me.LabelMinTolerancia)
        Me.TabPage3.Controls.Add(Me.TxtName)
        Me.TabPage3.Controls.Add(Me.LabelName)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(949, 395)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Agregar"
        '
        'TxtHoursXDia
        '
        Me.TxtHoursXDia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtHoursXDia.Location = New System.Drawing.Point(247, 261)
        Me.TxtHoursXDia.Name = "TxtHoursXDia"
        Me.TxtHoursXDia.Size = New System.Drawing.Size(218, 20)
        Me.TxtHoursXDia.TabIndex = 6
        '
        'LabelHoursXDia
        '
        Me.LabelHoursXDia.AutoSize = True
        Me.LabelHoursXDia.Location = New System.Drawing.Point(244, 243)
        Me.LabelHoursXDia.Name = "LabelHoursXDia"
        Me.LabelHoursXDia.Size = New System.Drawing.Size(60, 13)
        Me.LabelHoursXDia.TabIndex = 31
        Me.LabelHoursXDia.Text = "Horas x dia"
        '
        'TxtDiasPendion
        '
        Me.TxtDiasPendion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDiasPendion.Location = New System.Drawing.Point(247, 316)
        Me.TxtDiasPendion.Name = "TxtDiasPendion"
        Me.TxtDiasPendion.Size = New System.Drawing.Size(218, 20)
        Me.TxtDiasPendion.TabIndex = 8
        '
        'LabelDiasPendion
        '
        Me.LabelDiasPendion.AutoSize = True
        Me.LabelDiasPendion.Location = New System.Drawing.Point(244, 298)
        Me.LabelDiasPendion.Name = "LabelDiasPendion"
        Me.LabelDiasPendion.Size = New System.Drawing.Size(69, 13)
        Me.LabelDiasPendion.TabIndex = 29
        Me.LabelDiasPendion.Text = "Dias Pension"
        '
        'TxtTarifaPension
        '
        Me.TxtTarifaPension.Location = New System.Drawing.Point(11, 316)
        Me.TxtTarifaPension.Name = "TxtTarifaPension"
        Me.TxtTarifaPension.Size = New System.Drawing.Size(215, 20)
        Me.TxtTarifaPension.TabIndex = 7
        '
        'LabelTarifaPension
        '
        Me.LabelTarifaPension.AutoSize = True
        Me.LabelTarifaPension.Location = New System.Drawing.Point(13, 298)
        Me.LabelTarifaPension.Name = "LabelTarifaPension"
        Me.LabelTarifaPension.Size = New System.Drawing.Size(75, 13)
        Me.LabelTarifaPension.TabIndex = 27
        Me.LabelTarifaPension.Text = "Tarifa Pension"
        '
        'Add
        '
        Me.Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Add.Location = New System.Drawing.Point(322, 345)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(143, 42)
        Me.Add.TabIndex = 10
        Me.Add.Text = "Agregar"
        Me.Add.UseVisualStyleBackColor = True
        '
        'TxtMinTolerancia
        '
        Me.TxtMinTolerancia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMinTolerancia.Location = New System.Drawing.Point(11, 89)
        Me.TxtMinTolerancia.Name = "TxtMinTolerancia"
        Me.TxtMinTolerancia.Size = New System.Drawing.Size(454, 20)
        Me.TxtMinTolerancia.TabIndex = 2
        '
        'UsarFracciones
        '
        Me.UsarFracciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UsarFracciones.AutoSize = True
        Me.UsarFracciones.Location = New System.Drawing.Point(63, 359)
        Me.UsarFracciones.Name = "UsarFracciones"
        Me.UsarFracciones.Size = New System.Drawing.Size(100, 17)
        Me.UsarFracciones.TabIndex = 9
        Me.UsarFracciones.Text = "Usar fracciones"
        Me.UsarFracciones.UseVisualStyleBackColor = True
        '
        'TxtPrcieXDia
        '
        Me.TxtPrcieXDia.Location = New System.Drawing.Point(11, 261)
        Me.TxtPrcieXDia.Name = "TxtPrcieXDia"
        Me.TxtPrcieXDia.Size = New System.Drawing.Size(215, 20)
        Me.TxtPrcieXDia.TabIndex = 5
        '
        'LabelPrcieXDia
        '
        Me.LabelPrcieXDia.AutoSize = True
        Me.LabelPrcieXDia.Location = New System.Drawing.Point(13, 243)
        Me.LabelPrcieXDia.Name = "LabelPrcieXDia"
        Me.LabelPrcieXDia.Size = New System.Drawing.Size(62, 13)
        Me.LabelPrcieXDia.TabIndex = 25
        Me.LabelPrcieXDia.Text = "Precio x dia"
        '
        'TxtPrcieXHora
        '
        Me.TxtPrcieXHora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPrcieXHora.Location = New System.Drawing.Point(11, 206)
        Me.TxtPrcieXHora.Name = "TxtPrcieXHora"
        Me.TxtPrcieXHora.Size = New System.Drawing.Size(454, 20)
        Me.TxtPrcieXHora.TabIndex = 4
        '
        'LabelPrcieXHora
        '
        Me.LabelPrcieXHora.AutoSize = True
        Me.LabelPrcieXHora.Location = New System.Drawing.Point(13, 188)
        Me.LabelPrcieXHora.Name = "LabelPrcieXHora"
        Me.LabelPrcieXHora.Size = New System.Drawing.Size(69, 13)
        Me.LabelPrcieXHora.TabIndex = 23
        Me.LabelPrcieXHora.Text = "Precio x hora"
        '
        'TxtCostoMinimo
        '
        Me.TxtCostoMinimo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCostoMinimo.Location = New System.Drawing.Point(11, 152)
        Me.TxtCostoMinimo.Name = "TxtCostoMinimo"
        Me.TxtCostoMinimo.Size = New System.Drawing.Size(454, 20)
        Me.TxtCostoMinimo.TabIndex = 3
        '
        'LabelCostoMinimo
        '
        Me.LabelCostoMinimo.AutoSize = True
        Me.LabelCostoMinimo.Location = New System.Drawing.Point(13, 134)
        Me.LabelCostoMinimo.Name = "LabelCostoMinimo"
        Me.LabelCostoMinimo.Size = New System.Drawing.Size(69, 13)
        Me.LabelCostoMinimo.TabIndex = 21
        Me.LabelCostoMinimo.Text = "Costo minimo"
        '
        'LabelMinTolerancia
        '
        Me.LabelMinTolerancia.AutoSize = True
        Me.LabelMinTolerancia.Location = New System.Drawing.Point(8, 71)
        Me.LabelMinTolerancia.Name = "LabelMinTolerancia"
        Me.LabelMinTolerancia.Size = New System.Drawing.Size(108, 13)
        Me.LabelMinTolerancia.TabIndex = 19
        Me.LabelMinTolerancia.Text = "Minutos de tolerancia"
        '
        'TxtName
        '
        Me.TxtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtName.Location = New System.Drawing.Point(11, 30)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(454, 20)
        Me.TxtName.TabIndex = 1
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Location = New System.Drawing.Point(8, 12)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(70, 13)
        Me.LabelName.TabIndex = 17
        Me.LabelName.Text = "Nombre tarifa"
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
        'Rate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(957, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Rate"
        Me.Text = "Rate"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LabelName As Label
    Friend WithEvents UsarFracciones As CheckBox
    Friend WithEvents TxtPrcieXDia As TextBox
    Friend WithEvents LabelPrcieXDia As Label
    Friend WithEvents TxtPrcieXHora As TextBox
    Friend WithEvents LabelPrcieXHora As Label
    Friend WithEvents TxtCostoMinimo As TextBox
    Friend WithEvents LabelCostoMinimo As Label
    Friend WithEvents LabelMinTolerancia As Label
    Friend WithEvents TxtMinTolerancia As TextBox
    Friend WithEvents Add As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtMinToleEdit As TextBox
    Friend WithEvents UseFraccionesEdit As CheckBox
    Friend WithEvents TxtPrecioDiaEdit As TextBox
    Friend WithEvents LabelPrecioDiaEdit As Label
    Friend WithEvents TxtPrecioHoraEdit As TextBox
    Friend WithEvents LabelPrecioHoraEdit As Label
    Friend WithEvents TxtCostoMinEdit As TextBox
    Friend WithEvents LabelCostoMinEdit As Label
    Friend WithEvents LabelMinToleEdit As Label
    Friend WithEvents TxtNombreEdit As TextBox
    Friend WithEvents LabelNombreEdit As Label
    Friend WithEvents TarifasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TxtDiasPendion As TextBox
    Friend WithEvents LabelDiasPendion As Label
    Friend WithEvents TxtTarifaPension As TextBox
    Friend WithEvents LabelTarifaPension As Label
    Friend WithEvents TxtTarifaDiasEdit As TextBox
    Friend WithEvents LabelTarifaDiasEdit As Label
    Friend WithEvents TxtTarifaPensionEdit As TextBox
    Friend WithEvents LabelTarifaPensionEdit As Label
    Friend WithEvents TxtHoursXDia As TextBox
    Friend WithEvents LabelHoursXDia As Label
    Friend WithEvents TxtHoursXDiaEdit As TextBox
    Friend WithEvents LabelHoursXDiaEdit As Label
End Class
