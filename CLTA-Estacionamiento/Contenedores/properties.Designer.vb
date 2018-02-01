<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class properties
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_DB_Puerto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_DB_DB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_DB_Password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_DB_Username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_DB_Servidor = New System.Windows.Forms.TextBox()
        Me.TxtGuardar = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDesktopBackground = New System.Windows.Forms.TextBox()
        Me.Tabla_ColorFondo = New System.Windows.Forms.Button()
        Me.TablaColorSeleccion = New System.Windows.Forms.Button()
        Me.TipoLetra = New System.Windows.Forms.Button()
        Me.ColorMenu = New System.Windows.Forms.Button()
        Me.LetraMenu = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Puerto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_DB)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Password)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Username)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Txt_DB_Servidor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 263)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BASE DE DATOS"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 218)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Probar coneccion"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Puerto"
        '
        'Txt_DB_Puerto
        '
        Me.Txt_DB_Puerto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_Puerto.Location = New System.Drawing.Point(6, 191)
        Me.Txt_DB_Puerto.Name = "Txt_DB_Puerto"
        Me.Txt_DB_Puerto.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Puerto.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Base de datos"
        '
        'Txt_DB_DB
        '
        Me.Txt_DB_DB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_DB.Location = New System.Drawing.Point(6, 152)
        Me.Txt_DB_DB.Name = "Txt_DB_DB"
        Me.Txt_DB_DB.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_DB.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contraseña"
        '
        'Txt_DB_Password
        '
        Me.Txt_DB_Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_Password.Location = New System.Drawing.Point(6, 113)
        Me.Txt_DB_Password.Name = "Txt_DB_Password"
        Me.Txt_DB_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9632)
        Me.Txt_DB_Password.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Password.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'Txt_DB_Username
        '
        Me.Txt_DB_Username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Txt_DB_Username.Location = New System.Drawing.Point(6, 74)
        Me.Txt_DB_Username.Name = "Txt_DB_Username"
        Me.Txt_DB_Username.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Username.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Servidor"
        '
        'Txt_DB_Servidor
        '
        Me.Txt_DB_Servidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DB_Servidor.Location = New System.Drawing.Point(6, 35)
        Me.Txt_DB_Servidor.Name = "Txt_DB_Servidor"
        Me.Txt_DB_Servidor.Size = New System.Drawing.Size(168, 22)
        Me.Txt_DB_Servidor.TabIndex = 1
        '
        'TxtGuardar
        '
        Me.TxtGuardar.Location = New System.Drawing.Point(507, 249)
        Me.TxtGuardar.Name = "TxtGuardar"
        Me.TxtGuardar.Size = New System.Drawing.Size(93, 33)
        Me.TxtGuardar.TabIndex = 101
        Me.TxtGuardar.Text = "Guardar"
        Me.TxtGuardar.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(201, 97)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(300, 33)
        Me.Button7.TabIndex = 102
        Me.Button7.Text = "Seleccionar imagen"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Imagen de fondo"
        '
        'TxtDesktopBackground
        '
        Me.TxtDesktopBackground.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesktopBackground.Location = New System.Drawing.Point(201, 49)
        Me.TxtDesktopBackground.Multiline = True
        Me.TxtDesktopBackground.Name = "TxtDesktopBackground"
        Me.TxtDesktopBackground.Size = New System.Drawing.Size(300, 42)
        Me.TxtDesktopBackground.TabIndex = 104
        '
        'Tabla_ColorFondo
        '
        Me.Tabla_ColorFondo.Location = New System.Drawing.Point(204, 136)
        Me.Tabla_ColorFondo.Name = "Tabla_ColorFondo"
        Me.Tabla_ColorFondo.Size = New System.Drawing.Size(143, 33)
        Me.Tabla_ColorFondo.TabIndex = 105
        Me.Tabla_ColorFondo.Text = "Color de fondo Tablas"
        Me.Tabla_ColorFondo.UseVisualStyleBackColor = True
        '
        'TablaColorSeleccion
        '
        Me.TablaColorSeleccion.Location = New System.Drawing.Point(353, 136)
        Me.TablaColorSeleccion.Name = "TablaColorSeleccion"
        Me.TablaColorSeleccion.Size = New System.Drawing.Size(148, 33)
        Me.TablaColorSeleccion.TabIndex = 106
        Me.TablaColorSeleccion.Text = "Color seleccion Tablas"
        Me.TablaColorSeleccion.UseVisualStyleBackColor = True
        '
        'TipoLetra
        '
        Me.TipoLetra.Location = New System.Drawing.Point(204, 175)
        Me.TipoLetra.Name = "TipoLetra"
        Me.TipoLetra.Size = New System.Drawing.Size(143, 33)
        Me.TipoLetra.TabIndex = 107
        Me.TipoLetra.Text = "Tipo de letra"
        Me.TipoLetra.UseVisualStyleBackColor = True
        '
        'ColorMenu
        '
        Me.ColorMenu.Location = New System.Drawing.Point(353, 175)
        Me.ColorMenu.Name = "ColorMenu"
        Me.ColorMenu.Size = New System.Drawing.Size(148, 33)
        Me.ColorMenu.TabIndex = 108
        Me.ColorMenu.Text = "Color menu"
        Me.ColorMenu.UseVisualStyleBackColor = True
        '
        'LetraMenu
        '
        Me.LetraMenu.Location = New System.Drawing.Point(204, 214)
        Me.LetraMenu.Name = "LetraMenu"
        Me.LetraMenu.Size = New System.Drawing.Size(297, 33)
        Me.LetraMenu.TabIndex = 109
        Me.LetraMenu.Text = "Letra menu"
        Me.LetraMenu.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(507, 213)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 33)
        Me.Button2.TabIndex = 110
        Me.Button2.Text = "Restaurar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(610, 24)
        Me.MenuStrip1.TabIndex = 111
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.btn_exit
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.25!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"SELECCIONE UNA MONEDA", "AED", "AFN", "ALL", "AMD", "ANG", "AOA", "ARS", "AUD", "AWG", "AZN", "BAM", "BBD", "BDT", "BGN", "BHD", "BIF", "BND", "BOB", "BRL", "BSD", "BTN", "BWP", "BYR", "BZD", "CAD", "CDF", "CHF", "CLP", "CNY", "COP", "CRC", "CUP", "CVE", "CZK", "DJF", "DKK", "DOP", "DZD", "EGP", "ERN", "ETB", "EUR", "GBP", "GEL", "GHS", "GIP", "GMD", "GNF", "GTQ", "HNL", "HRK", "HTG", "HUF", "IDR", "ILS", "INR", "IQD", "IRR", "ISK", "JMD", "JOD", "JPY", "KES", "KGS", "KHR", "KMF", "KPW", "KRW", "KWD", "KYD", "KZT", "LAK", "LBP", "LKR", "LRD", "LSL", "LTL", "LVL", "LYD", "MAD", "MDL", "MGA", "MKD", "MMK", "MNT", "MOP", "MRO", "MUR", "MVR", "MWK", "MXN", "MYR", "MZN", "NAD", "nenhum", "Nenhum", "NGN", "NIO", "NOK", "NPR", "NZD", "OMR", "PAB", "PEN", "PGK", "PHP", "PKR", "PLN", "PYG", "QAR", "RON", "RSD", "RUB", "RWF", "SAR", "SBD", "SCR", "SDG", "SEK", "SGD", "SLL", "SOS", "SRD", "SSP", "STD", "SVC", "SYP", "SZL", "THB", "TJS", "TMT", "TND", "TOP", "TRY", "TTD", "TWD", "TZS", "UAH", "UGX", "USD", "USD", "UYU", "UZS", "VEF", "VND", "VUV", "WST", "XAF", "XAF", "XAF", "XAF", "XAF", "XCD", "XCD", "XCD", "XOF", "XOF", "XOF", "XOF", "XOF", "XOF", "XOF", "XPF", "XPF", "YER", "ZAR", "ZMK", "ZWL"})
        Me.ComboBox1.Location = New System.Drawing.Point(204, 252)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(297, 30)
        Me.ComboBox1.TabIndex = 112
        '
        'properties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 311)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LetraMenu)
        Me.Controls.Add(Me.ColorMenu)
        Me.Controls.Add(Me.TipoLetra)
        Me.Controls.Add(Me.TablaColorSeleccion)
        Me.Controls.Add(Me.Tabla_ColorFondo)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtDesktopBackground)
        Me.Controls.Add(Me.TxtGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "properties"
        Me.Text = "properties"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_DB_Puerto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_DB_DB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_DB_Password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_DB_Username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_DB_Servidor As TextBox
    Friend WithEvents TxtGuardar As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtDesktopBackground As TextBox
    Friend WithEvents Tabla_ColorFondo As Button
    Friend WithEvents TablaColorSeleccion As Button
    Friend WithEvents TipoLetra As Button
    Friend WithEvents ColorMenu As Button
    Friend WithEvents LetraMenu As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBox1 As ComboBox
End Class
