<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EntradaVehiculoGenerico
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboTarifa = New System.Windows.Forms.ComboBox()
        Me.V_Matricula = New System.Windows.Forms.TextBox()
        Me.Matricula_label = New System.Windows.Forms.Label()
        Me.BarraMenu = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.V_Modelo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.V_Color = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.V_Estado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(15, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(563, 51)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "PERMITIR ACCESO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboTarifa
        '
        Me.ComboTarifa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboTarifa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTarifa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTarifa.FormattingEnabled = True
        Me.ComboTarifa.Location = New System.Drawing.Point(10, 39)
        Me.ComboTarifa.Name = "ComboTarifa"
        Me.ComboTarifa.Size = New System.Drawing.Size(568, 28)
        Me.ComboTarifa.TabIndex = 1
        '
        'V_Matricula
        '
        Me.V_Matricula.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V_Matricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_Matricula.ForeColor = System.Drawing.Color.SteelBlue
        Me.V_Matricula.Location = New System.Drawing.Point(64, 73)
        Me.V_Matricula.Name = "V_Matricula"
        Me.V_Matricula.Size = New System.Drawing.Size(514, 31)
        Me.V_Matricula.TabIndex = 2
        Me.V_Matricula.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Matricula_label
        '
        Me.Matricula_label.AutoSize = True
        Me.Matricula_label.Location = New System.Drawing.Point(12, 82)
        Me.Matricula_label.Name = "Matricula_label"
        Me.Matricula_label.Size = New System.Drawing.Size(53, 13)
        Me.Matricula_label.TabIndex = 34
        Me.Matricula_label.Text = "Matricula:"
        '
        'BarraMenu
        '
        Me.BarraMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BarraMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.BarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.BarraMenu.Name = "BarraMenu"
        Me.BarraMenu.Size = New System.Drawing.Size(590, 33)
        Me.BarraMenu.TabIndex = 35
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 13.0!)
        Me.SalirToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_exit
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'V_Modelo
        '
        Me.V_Modelo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V_Modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_Modelo.ForeColor = System.Drawing.Color.SteelBlue
        Me.V_Modelo.Location = New System.Drawing.Point(64, 110)
        Me.V_Modelo.Name = "V_Modelo"
        Me.V_Modelo.Size = New System.Drawing.Size(221, 31)
        Me.V_Modelo.TabIndex = 3
        Me.V_Modelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Modelo:"
        '
        'V_Color
        '
        Me.V_Color.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V_Color.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_Color.ForeColor = System.Drawing.Color.SteelBlue
        Me.V_Color.Location = New System.Drawing.Point(331, 110)
        Me.V_Color.Name = "V_Color"
        Me.V_Color.Size = New System.Drawing.Size(247, 31)
        Me.V_Color.TabIndex = 4
        Me.V_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(291, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Color:"
        '
        'V_Estado
        '
        Me.V_Estado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.V_Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.V_Estado.ForeColor = System.Drawing.Color.SteelBlue
        Me.V_Estado.Location = New System.Drawing.Point(64, 147)
        Me.V_Estado.Name = "V_Estado"
        Me.V_Estado.Size = New System.Drawing.Size(514, 31)
        Me.V_Estado.TabIndex = 5
        Me.V_Estado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Estado:"
        '
        'EntradaVehiculoGenerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 247)
        Me.Controls.Add(Me.V_Estado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.V_Color)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.V_Modelo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarraMenu)
        Me.Controls.Add(Me.V_Matricula)
        Me.Controls.Add(Me.Matricula_label)
        Me.Controls.Add(Me.ComboTarifa)
        Me.Controls.Add(Me.Button1)
        Me.Name = "EntradaVehiculoGenerico"
        Me.Text = "EntradaVehiculoGenerico"
        Me.BarraMenu.ResumeLayout(False)
        Me.BarraMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents ComboTarifa As ComboBox
    Friend WithEvents V_Matricula As TextBox
    Friend WithEvents Matricula_label As Label
    Friend WithEvents BarraMenu As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents V_Modelo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents V_Color As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents V_Estado As TextBox
    Friend WithEvents Label3 As Label
End Class
