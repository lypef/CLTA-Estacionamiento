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
        Me.LimpiarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.EntradaVehiculoGenericoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VehiculosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AccionarBarraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.VentaDirectaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TarifasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReimprimirTicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CorteXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CorteZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AjustesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.CambiarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtBox = New System.Windows.Forms.ToolStripTextBox()
        Me.Desktop = New System.Windows.Forms.Panel()
        Me.Footer = New System.Windows.Forms.Panel()
        Me.LabelHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BarraMenu.SuspendLayout()
        Me.Footer.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraMenu
        '
        Me.BarraMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BarraMenu.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AboutToolStripMenuItem, Me.MinimizarToolStripMenuItem, Me.ToolStripMenuItem2, Me.TxtBox})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(1164, 36)
        Me.BarraMenu.TabIndex = 2
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LimpiarToolStripMenuItem1, Me.ToolStripSeparator9, Me.EntradaVehiculoGenericoToolStripMenuItem, Me.ToolStripSeparator8, Me.ClientesToolStripMenuItem1, Me.VehiculosToolStripMenuItem, Me.ToolStripSeparator6, Me.AccionarBarraToolStripMenuItem, Me.ToolStripSeparator5, Me.VentaDirectaToolStripMenuItem, Me.ToolStripSeparator3, Me.UsuariosToolStripMenuItem1, Me.TarifasToolStripMenuItem1, Me.VentasToolStripMenuItem1, Me.ReportesToolStripMenuItem, Me.ToolStripSeparator1, Me.CorteXToolStripMenuItem, Me.CorteZToolStripMenuItem, Me.ToolStripSeparator2, Me.AjustesToolStripMenuItem2, Me.ToolStripSeparator7, Me.CambiarUsuarioToolStripMenuItem, Me.MinimizarToolStripMenuItem1, Me.SalirToolStripMenuItem1})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(113, 32)
        Me.ArchivoToolStripMenuItem.Text = "▼ Archivo"
        '
        'LimpiarToolStripMenuItem1
        '
        Me.LimpiarToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.clean
        Me.LimpiarToolStripMenuItem1.Name = "LimpiarToolStripMenuItem1"
        Me.LimpiarToolStripMenuItem1.Size = New System.Drawing.Size(314, 32)
        Me.LimpiarToolStripMenuItem1.Text = "Limpiar"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(311, 6)
        '
        'EntradaVehiculoGenericoToolStripMenuItem
        '
        Me.EntradaVehiculoGenericoToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.verify2_48
        Me.EntradaVehiculoGenericoToolStripMenuItem.Name = "EntradaVehiculoGenericoToolStripMenuItem"
        Me.EntradaVehiculoGenericoToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.EntradaVehiculoGenericoToolStripMenuItem.Text = "Entrada vehiculo generico"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(311, 6)
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.users_48
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(314, 32)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'VehiculosToolStripMenuItem
        '
        Me.VehiculosToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.verify2_48
        Me.VehiculosToolStripMenuItem.Name = "VehiculosToolStripMenuItem"
        Me.VehiculosToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.VehiculosToolStripMenuItem.Text = "Vehiculos"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(311, 6)
        '
        'AccionarBarraToolStripMenuItem
        '
        Me.AccionarBarraToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.barr_acceso
        Me.AccionarBarraToolStripMenuItem.Name = "AccionarBarraToolStripMenuItem"
        Me.AccionarBarraToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.AccionarBarraToolStripMenuItem.Text = "Accionar barra"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(311, 6)
        '
        'VentaDirectaToolStripMenuItem
        '
        Me.VentaDirectaToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.details_24
        Me.VentaDirectaToolStripMenuItem.Name = "VentaDirectaToolStripMenuItem"
        Me.VentaDirectaToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.VentaDirectaToolStripMenuItem.Text = "Venta Directa"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(311, 6)
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.users_i
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(314, 32)
        Me.UsuariosToolStripMenuItem1.Text = "Usuarios"
        '
        'TarifasToolStripMenuItem1
        '
        Me.TarifasToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.verify2_128
        Me.TarifasToolStripMenuItem1.Name = "TarifasToolStripMenuItem1"
        Me.TarifasToolStripMenuItem1.Size = New System.Drawing.Size(314, 32)
        Me.TarifasToolStripMenuItem1.Text = "Tarifas"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.ventas
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(314, 32)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReimprimirTicketToolStripMenuItem, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripSeparator4})
        Me.ReportesToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.update_48
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReimprimirTicketToolStripMenuItem
        '
        Me.ReimprimirTicketToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.ticket
        Me.ReimprimirTicketToolStripMenuItem.Name = "ReimprimirTicketToolStripMenuItem"
        Me.ReimprimirTicketToolStripMenuItem.Size = New System.Drawing.Size(237, 32)
        Me.ReimprimirTicketToolStripMenuItem.Text = "Reimprimir ticket"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(237, 32)
        Me.ToolStripMenuItem3.Text = "Corte X general"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(237, 32)
        Me.ToolStripMenuItem4.Text = "Corte Z general"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(234, 6)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(311, 6)
        '
        'CorteXToolStripMenuItem
        '
        Me.CorteXToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.CorteXToolStripMenuItem.Name = "CorteXToolStripMenuItem"
        Me.CorteXToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.CorteXToolStripMenuItem.Text = "Corte X"
        '
        'CorteZToolStripMenuItem
        '
        Me.CorteZToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.if_money_299107
        Me.CorteZToolStripMenuItem.Name = "CorteZToolStripMenuItem"
        Me.CorteZToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.CorteZToolStripMenuItem.Text = "Corte Z"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(311, 6)
        '
        'AjustesToolStripMenuItem2
        '
        Me.AjustesToolStripMenuItem2.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.AJUSTES
        Me.AjustesToolStripMenuItem2.Name = "AjustesToolStripMenuItem2"
        Me.AjustesToolStripMenuItem2.Size = New System.Drawing.Size(314, 32)
        Me.AjustesToolStripMenuItem2.Text = "Ajustes"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(311, 6)
        '
        'CambiarUsuarioToolStripMenuItem
        '
        Me.CambiarUsuarioToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.users_black_48
        Me.CambiarUsuarioToolStripMenuItem.Name = "CambiarUsuarioToolStripMenuItem"
        Me.CambiarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(314, 32)
        Me.CambiarUsuarioToolStripMenuItem.Text = "Cambiar usuario"
        '
        'MinimizarToolStripMenuItem1
        '
        Me.MinimizarToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_minimizar
        Me.MinimizarToolStripMenuItem1.Name = "MinimizarToolStripMenuItem1"
        Me.MinimizarToolStripMenuItem1.Size = New System.Drawing.Size(314, 32)
        Me.MinimizarToolStripMenuItem1.Text = "Minimizar"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_exit
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(314, 32)
        Me.SalirToolStripMenuItem1.Text = "Salir"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.AboutToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(38, 32)
        '
        'MinimizarToolStripMenuItem
        '
        Me.MinimizarToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.MinimizarToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.MinimizarToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_minimizar
        Me.MinimizarToolStripMenuItem.Name = "MinimizarToolStripMenuItem"
        Me.MinimizarToolStripMenuItem.Size = New System.Drawing.Size(129, 32)
        Me.MinimizarToolStripMenuItem.Text = "Minimizar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(124, 32)
        Me.ToolStripMenuItem2.Text = "Control E/S"
        '
        'TxtBox
        '
        Me.TxtBox.Name = "TxtBox"
        Me.TxtBox.Size = New System.Drawing.Size(200, 32)
        Me.TxtBox.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Desktop
        '
        Me.Desktop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Desktop.Dock = System.Windows.Forms.DockStyle.Top
        Me.Desktop.Location = New System.Drawing.Point(0, 36)
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
        Me.LabelHora.Size = New System.Drawing.Size(111, 25)
        Me.LabelHora.TabIndex = 0
        Me.LabelHora.Text = "LabelHora"
        '
        'Timer1
        '
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
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents TarifasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CorteXToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CorteZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReimprimirTicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents AccionarBarraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents EntradaVehiculoGenericoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents VentaDirectaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AjustesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ClientesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VehiculosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents LimpiarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
End Class
