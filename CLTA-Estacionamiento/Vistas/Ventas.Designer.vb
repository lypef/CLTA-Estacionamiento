<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Table = New System.Windows.Forms.DataGridView()
        Me.f_desde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.f_hasta = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbAsignaciones = New System.Windows.Forms.RadioButton()
        Me.RbServicios = New System.Windows.Forms.RadioButton()
        Me.RbProductos = New System.Windows.Forms.RadioButton()
        Me.RbTodos = New System.Windows.Forms.RadioButton()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.TxtSearch, Me.VehiculosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(941, 29)
        Me.MenuStrip1.TabIndex = 2
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
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(68, 25)
        Me.VehiculosToolStripMenuItem.Text = "Ventas"
        '
        'GenerarReporteToolStripMenuItem
        '
        Me.GenerarReporteToolStripMenuItem.Name = "GenerarReporteToolStripMenuItem"
        Me.GenerarReporteToolStripMenuItem.Size = New System.Drawing.Size(191, 26)
        Me.GenerarReporteToolStripMenuItem.Text = "Generar reporte"
        '
        'Table
        '
        Me.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table.Location = New System.Drawing.Point(0, 29)
        Me.Table.Name = "Table"
        Me.Table.Size = New System.Drawing.Size(941, 382)
        Me.Table.TabIndex = 3
        '
        'f_desde
        '
        Me.f_desde.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.f_desde.Location = New System.Drawing.Point(473, 4)
        Me.f_desde.Name = "f_desde"
        Me.f_desde.Size = New System.Drawing.Size(200, 20)
        Me.f_desde.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(423, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(688, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Hasta:"
        '
        'f_hasta
        '
        Me.f_hasta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.f_hasta.Location = New System.Drawing.Point(735, 4)
        Me.f_hasta.Name = "f_hasta"
        Me.f_hasta.Size = New System.Drawing.Size(200, 20)
        Me.f_hasta.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbAsignaciones)
        Me.Panel1.Controls.Add(Me.RbServicios)
        Me.Panel1.Controls.Add(Me.RbProductos)
        Me.Panel1.Controls.Add(Me.RbTodos)
        Me.Panel1.Controls.Add(Me.f_hasta)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.f_desde)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 383)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(941, 28)
        Me.Panel1.TabIndex = 8
        '
        'RbAsignaciones
        '
        Me.RbAsignaciones.AutoSize = True
        Me.RbAsignaciones.Location = New System.Drawing.Point(287, 6)
        Me.RbAsignaciones.Name = "RbAsignaciones"
        Me.RbAsignaciones.Size = New System.Drawing.Size(88, 17)
        Me.RbAsignaciones.TabIndex = 11
        Me.RbAsignaciones.TabStop = True
        Me.RbAsignaciones.Text = "Asignaciones"
        Me.RbAsignaciones.UseVisualStyleBackColor = True
        '
        'RbServicios
        '
        Me.RbServicios.AutoSize = True
        Me.RbServicios.Location = New System.Drawing.Point(208, 6)
        Me.RbServicios.Name = "RbServicios"
        Me.RbServicios.Size = New System.Drawing.Size(68, 17)
        Me.RbServicios.TabIndex = 10
        Me.RbServicios.TabStop = True
        Me.RbServicios.Text = "Servicios"
        Me.RbServicios.UseVisualStyleBackColor = True
        '
        'RbProductos
        '
        Me.RbProductos.AutoSize = True
        Me.RbProductos.Location = New System.Drawing.Point(124, 6)
        Me.RbProductos.Name = "RbProductos"
        Me.RbProductos.Size = New System.Drawing.Size(73, 17)
        Me.RbProductos.TabIndex = 9
        Me.RbProductos.TabStop = True
        Me.RbProductos.Text = "Productos"
        Me.RbProductos.UseVisualStyleBackColor = True
        '
        'RbTodos
        '
        Me.RbTodos.AutoSize = True
        Me.RbTodos.Location = New System.Drawing.Point(58, 6)
        Me.RbTodos.Name = "RbTodos"
        Me.RbTodos.Size = New System.Drawing.Size(55, 17)
        Me.RbTodos.TabIndex = 8
        Me.RbTodos.TabStop = True
        Me.RbTodos.Text = "Todos"
        Me.RbTodos.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 411)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Table)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents TxtSearch As ToolStripTextBox
    Friend WithEvents VehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Table As DataGridView
    Friend WithEvents f_desde As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents f_hasta As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RbAsignaciones As RadioButton
    Friend WithEvents RbServicios As RadioButton
    Friend WithEvents RbProductos As RadioButton
    Friend WithEvents RbTodos As RadioButton
End Class
