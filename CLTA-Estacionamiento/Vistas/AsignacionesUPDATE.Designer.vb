<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignacionesUPDATE
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
        Me.ComboBoxTarifas = New System.Windows.Forms.ComboBox()
        Me.ImagenPropietario = New System.Windows.Forms.PictureBox()
        Me.LabelCliente = New System.Windows.Forms.Label()
        Me.LabelVehiculo = New System.Windows.Forms.Label()
        Me.RB_Hora = New System.Windows.Forms.RadioButton()
        Me.RB_Dias = New System.Windows.Forms.RadioButton()
        Me.Rb_Pension = New System.Windows.Forms.RadioButton()
        Me.LabelMatricula = New System.Windows.Forms.Label()
        Me.Stadia = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TotalTXT = New System.Windows.Forms.Label()
        Me.DateFinalice = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ImagenPropietario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stadia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 29)
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
        'ComboBoxTarifas
        '
        Me.ComboBoxTarifas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTarifas.FormattingEnabled = True
        Me.ComboBoxTarifas.Location = New System.Drawing.Point(9, 34)
        Me.ComboBoxTarifas.Name = "ComboBoxTarifas"
        Me.ComboBoxTarifas.Size = New System.Drawing.Size(805, 21)
        Me.ComboBoxTarifas.TabIndex = 3
        '
        'ImagenPropietario
        '
        Me.ImagenPropietario.Location = New System.Drawing.Point(9, 62)
        Me.ImagenPropietario.Name = "ImagenPropietario"
        Me.ImagenPropietario.Size = New System.Drawing.Size(226, 187)
        Me.ImagenPropietario.TabIndex = 4
        Me.ImagenPropietario.TabStop = False
        '
        'LabelCliente
        '
        Me.LabelCliente.AutoSize = True
        Me.LabelCliente.Location = New System.Drawing.Point(241, 68)
        Me.LabelCliente.Name = "LabelCliente"
        Me.LabelCliente.Size = New System.Drawing.Size(65, 13)
        Me.LabelCliente.TabIndex = 5
        Me.LabelCliente.Text = "LabelCliente"
        '
        'LabelVehiculo
        '
        Me.LabelVehiculo.AutoSize = True
        Me.LabelVehiculo.Location = New System.Drawing.Point(241, 114)
        Me.LabelVehiculo.Name = "LabelVehiculo"
        Me.LabelVehiculo.Size = New System.Drawing.Size(39, 13)
        Me.LabelVehiculo.TabIndex = 6
        Me.LabelVehiculo.Text = "Label1"
        '
        'RB_Hora
        '
        Me.RB_Hora.AutoSize = True
        Me.RB_Hora.Location = New System.Drawing.Point(241, 137)
        Me.RB_Hora.Name = "RB_Hora"
        Me.RB_Hora.Size = New System.Drawing.Size(58, 17)
        Me.RB_Hora.TabIndex = 7
        Me.RB_Hora.TabStop = True
        Me.RB_Hora.Text = "X Hora"
        Me.RB_Hora.UseVisualStyleBackColor = True
        '
        'RB_Dias
        '
        Me.RB_Dias.AutoSize = True
        Me.RB_Dias.Location = New System.Drawing.Point(241, 164)
        Me.RB_Dias.Name = "RB_Dias"
        Me.RB_Dias.Size = New System.Drawing.Size(56, 17)
        Me.RB_Dias.TabIndex = 8
        Me.RB_Dias.TabStop = True
        Me.RB_Dias.Text = "X Dias"
        Me.RB_Dias.UseVisualStyleBackColor = True
        '
        'Rb_Pension
        '
        Me.Rb_Pension.AutoSize = True
        Me.Rb_Pension.Location = New System.Drawing.Point(241, 191)
        Me.Rb_Pension.Name = "Rb_Pension"
        Me.Rb_Pension.Size = New System.Drawing.Size(63, 17)
        Me.Rb_Pension.TabIndex = 9
        Me.Rb_Pension.TabStop = True
        Me.Rb_Pension.Text = "Pension"
        Me.Rb_Pension.UseVisualStyleBackColor = True
        '
        'LabelMatricula
        '
        Me.LabelMatricula.AutoSize = True
        Me.LabelMatricula.Location = New System.Drawing.Point(241, 91)
        Me.LabelMatricula.Name = "LabelMatricula"
        Me.LabelMatricula.Size = New System.Drawing.Size(39, 13)
        Me.LabelMatricula.TabIndex = 10
        Me.LabelMatricula.Text = "Label1"
        '
        'Stadia
        '
        Me.Stadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Stadia.Location = New System.Drawing.Point(730, 178)
        Me.Stadia.Name = "Stadia"
        Me.Stadia.Size = New System.Drawing.Size(84, 23)
        Me.Stadia.TabIndex = 11
        Me.Stadia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Button1.Location = New System.Drawing.Point(730, 207)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 35)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TotalTXT
        '
        Me.TotalTXT.AutoSize = True
        Me.TotalTXT.Font = New System.Drawing.Font("Segoe UI Semibold", 14.75!, System.Drawing.FontStyle.Bold)
        Me.TotalTXT.ForeColor = System.Drawing.Color.Blue
        Me.TotalTXT.Location = New System.Drawing.Point(391, 176)
        Me.TotalTXT.Name = "TotalTXT"
        Me.TotalTXT.Size = New System.Drawing.Size(68, 28)
        Me.TotalTXT.TabIndex = 13
        Me.TotalTXT.Text = "Label1"
        Me.TotalTXT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DateFinalice
        '
        Me.DateFinalice.AutoSize = True
        Me.DateFinalice.Font = New System.Drawing.Font("Segoe UI Semibold", 14.75!, System.Drawing.FontStyle.Bold)
        Me.DateFinalice.ForeColor = System.Drawing.Color.Blue
        Me.DateFinalice.Location = New System.Drawing.Point(391, 142)
        Me.DateFinalice.Name = "DateFinalice"
        Me.DateFinalice.Size = New System.Drawing.Size(289, 28)
        Me.DateFinalice.TabIndex = 14
        Me.DateFinalice.Text = "FINALIZA: 06/02/2018 13:48:00"
        Me.DateFinalice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AsignacionesUPDATE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 254)
        Me.Controls.Add(Me.DateFinalice)
        Me.Controls.Add(Me.TotalTXT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Stadia)
        Me.Controls.Add(Me.LabelMatricula)
        Me.Controls.Add(Me.Rb_Pension)
        Me.Controls.Add(Me.RB_Dias)
        Me.Controls.Add(Me.RB_Hora)
        Me.Controls.Add(Me.LabelVehiculo)
        Me.Controls.Add(Me.LabelCliente)
        Me.Controls.Add(Me.ImagenPropietario)
        Me.Controls.Add(Me.ComboBoxTarifas)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "AsignacionesUPDATE"
        Me.Text = "AsignacionesUPDATE"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ImagenPropietario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stadia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxTarifas As ComboBox
    Friend WithEvents ImagenPropietario As PictureBox
    Friend WithEvents LabelCliente As Label
    Friend WithEvents LabelVehiculo As Label
    Friend WithEvents RB_Hora As RadioButton
    Friend WithEvents RB_Dias As RadioButton
    Friend WithEvents Rb_Pension As RadioButton
    Friend WithEvents LabelMatricula As Label
    Friend WithEvents Stadia As NumericUpDown
    Friend WithEvents Button1 As Button
    Friend WithEvents TotalTXT As Label
    Friend WithEvents DateFinalice As Label
End Class
