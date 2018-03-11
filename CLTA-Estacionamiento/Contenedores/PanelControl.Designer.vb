<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelControl
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
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CorteXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorteZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AJUSTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjustesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Desktop = New System.Windows.Forms.Panel()
        Me.Footer = New System.Windows.Forms.Panel()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CorteXGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorteZGeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarraMenu.SuspendLayout()
        Me.Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AboutToolStripMenuItem, Me.SalirToolStripMenuItem, Me.MinimizarToolStripMenuItem, Me.LimpiarToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.VentasToolStripMenuItem, Me.AJUSTESToolStripMenuItem, Me.TxtBox})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(1164, 34)
        Me.BarraMenu.TabIndex = 2
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem1, Me.VentasToolStripMenuItem1, Me.TarifasToolStripMenuItem1, Me.ToolStripSeparator1, Me.CorteXToolStripMenuItem, Me.CorteZToolStripMenuItem, Me.ToolStripSeparator2, Me.CambiarUsuarioToolStripMenuItem, Me.MinimizarToolStripMenuItem1, Me.SalirToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(105, 30)
        Me.ArchivoToolStripMenuItem.Text = "▼ Archivo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(210, 6)
        '
        'CorteXToolStripMenuItem
        '
        Me.CorteXToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.CorteXToolStripMenuItem.Name = "CorteXToolStripMenuItem"
        Me.CorteXToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.CorteXToolStripMenuItem.Text = "Corte X"
        '
        'CorteZToolStripMenuItem
        '
        Me.CorteZToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.CorteZToolStripMenuItem.Name = "CorteZToolStripMenuItem"
        Me.CorteZToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.CorteZToolStripMenuItem.Text = "Corte Z"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(85, 30)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(98, 30)
        Me.ToolStripMenuItem1.Text = "Vehiculos"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(114, 30)
        Me.ToolStripMenuItem2.Text = "Control E/S"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(128, 30)
        Me.VentasToolStripMenuItem.Text = "Venta Directa"
        '
        'AJUSTESToolStripMenuItem
        '
        Me.AJUSTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjustesToolStripMenuItem1})
        Me.AJUSTESToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.AJUSTESToolStripMenuItem.Name = "AJUSTESToolStripMenuItem"
        Me.AJUSTESToolStripMenuItem.Size = New System.Drawing.Size(90, 30)
        Me.AJUSTESToolStripMenuItem.Text = "▼ Otros"
        '
        'AjustesToolStripMenuItem1
        '
        Me.AjustesToolStripMenuItem1.Name = "AjustesToolStripMenuItem1"
        Me.AjustesToolStripMenuItem1.Size = New System.Drawing.Size(141, 30)
        Me.AjustesToolStripMenuItem1.Text = "Ajustes"
        '
        'TxtBox
        '
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(200, 30)
        Me.TxtBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Desktop
        '
        Me.Desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Desktop.Dock = System.Windows.Forms.DockStyle.Top
        Me.Desktop.Location = New System.Drawing.Point(0, 34)
        Me.Desktop.Name = "Desktop"
        Me.Desktop.Size = New System.Drawing.Size(1164, 359)
        Me.Desktop.TabIndex = 4
        '
        'Footer
        '
        Me.Footer.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Footer.Controls.Add(Me.LabelHora)
        Me.Footer.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Footer.Location = New System.Drawing.Point(0, 399)
        Me.Footer.Name = "Footer"
        Me.Footer.Size = New System.Drawing.Size(1164, 30)
        Me.Footer.TabIndex = 5
        '
        'LabelHora
        '
        Me.LabelHora.AutoSize = True
        Me.LabelHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.LabelHora.ForeColor = System.Drawing.Color.Maroon
        Me.LabelHora.Location = New System.Drawing.Point(5, 4)
        Me.LabelHora.Name = "LabelHora"
        Me.LabelHora.Size = New System.Drawing.Size(93, 22)
        Me.LabelHora.TabIndex = 0
        Me.LabelHora.Text = "LabelHora"
        '
        'Timer1
        '
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.users_i
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(213, 30)
        Me.UsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerToolStripMenuItem, Me.ToolStripSeparator3, Me.CorteXGeneralToolStripMenuItem, Me.CorteZGeneralToolStripMenuItem})
        Me.VentasToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.ventas
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(213, 30)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_Money_Increase_379473
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.VerToolStripMenuItem.Text = "Ver"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(203, 6)
        '
        'CorteXGeneralToolStripMenuItem
        '
        Me.CorteXGeneralToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.CorteXGeneralToolStripMenuItem.Name = "CorteXGeneralToolStripMenuItem"
        Me.CorteXGeneralToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.CorteXGeneralToolStripMenuItem.Text = "Corte X general"
        '
        'CorteZGeneralToolStripMenuItem
        '
        Me.CorteZGeneralToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.CorteZGeneralToolStripMenuItem.Name = "CorteZGeneralToolStripMenuItem"
        Me.CorteZGeneralToolStripMenuItem.Size = New System.Drawing.Size(206, 30)
        Me.CorteZGeneralToolStripMenuItem.Text = "Corte Z general"
        '
        'TarifasToolStripMenuItem1
        '
        Me.TarifasToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.verify2_128
        Me.TarifasToolStripMenuItem1.Name = "TarifasToolStripMenuItem1"
        Me.TarifasToolStripMenuItem1.Size = New System.Drawing.Size(213, 30)
        Me.TarifasToolStripMenuItem1.Text = "Tarifas"
        '
        'CambiarUsuarioToolStripMenuItem
        '
        Me.CambiarUsuarioToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.users_black_48
        Me.CambiarUsuarioToolStripMenuItem.Name = "CambiarUsuarioToolStripMenuItem"
        Me.CambiarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(213, 30)
        Me.CambiarUsuarioToolStripMenuItem.Text = "Cambiar usuario"
        '
        'MinimizarToolStripMenuItem1
        '
        Me.MinimizarToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_minimizar
        Me.MinimizarToolStripMenuItem1.Name = "MinimizarToolStripMenuItem1"
        Me.MinimizarToolStripMenuItem1.Size = New System.Drawing.Size(213, 30)
        Me.MinimizarToolStripMenuItem1.Text = "Minimizar"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_exit
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(213, 30)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.AboutToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(38, 30)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.SalirToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_exit
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(73, 30)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MinimizarToolStripMenuItem
        '
        Me.MinimizarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MinimizarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.MinimizarToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_minimizar
        Me.MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        Me.MinimizarToolStripMenuItem.Size = New System.Drawing.Size(117, 30)
        Me.MinimizarToolStripMenuItem.Text = "Minimizar"
        '
        'LimpiarToolStripMenuItem
        '
        Me.LimpiarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LimpiarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.LimpiarToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.clean
        Me.LimpiarToolStripMenuItem.Name = "LimpiarToolStripMenuItem"
        Me.LimpiarToolStripMenuItem.Size = New System.Drawing.Size(98, 30)
        Me.LimpiarToolStripMenuItem.Text = "Limpiar"
        Me.LimpiarToolStripMenuItem.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'PanelControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 429)
        Me.Controls.Add(Me.Footer)
        Me.Controls.Add(Me.Desktop)
        Me.Controls.Add(Me.BarraMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.BarraMenu
        Me.Name = "PanelControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PanelControl"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.Footer.ResumeLayout(False)
        Me.Footer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BarraMenu As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinimizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AJUSTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AjustesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MinimizarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Footer As Panel
    Friend WithEvents LabelHora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CambiarUsuarioToolStripMenuItem As ToolStripMenuItem
    Public WithEvents Desktop As Panel
    Friend WithEvents UsuariosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents TxtBox As ToolStripTextBox
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TarifasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CorteXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorteZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CorteXGeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorteZGeneralToolStripMenuItem As ToolStripMenuItem
End Class
