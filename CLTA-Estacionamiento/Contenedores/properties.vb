Imports System.IO
Imports MySql.Data.MySqlClient

Public Class properties
    Dim f As New Functions

    Private Sub properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me, FormBorderStyle.None)
        Txt_DB_Servidor.Text = My.Settings.db_servidor
        Txt_DB_Username.Text = My.Settings.db_username
        Txt_DB_Password.Text = My.Settings.db_password
        Txt_DB_DB.Text = My.Settings.db_nameDB
        Txt_DB_Puerto.Text = My.Settings.db_puerto
        TxtDesktopBackground.Text = My.Settings.DesktopBackgroundImage
        Tabla_ColorFondo.BackColor = My.Settings.datagridview_color
        TablaColorSeleccion.BackColor = My.Settings.datagridview_selectrow
        TipoLetra.Font = My.Settings.text_font
        ColorMenu.BackColor = My.Settings.Menu_color
        LetraMenu.Font = My.Settings.Menu_font

        MainMenuStrip.BackColor = My.Settings.Menu_color
        MainMenuStrip.Font = My.Settings.Menu_font

        For i As Integer = 0 To ComboBox1.Items.Count - 1
            ComboBox1.SelectedIndex = i
            If ComboBox1.SelectedItem.ToString.ToLower = My.Settings.moneda.ToLower Then
                Exit For
            End If
        Next
        Ventana.SelectedIndex = My.Settings.form_windowstate
        AltoBotones.Value = My.Settings.Height_Button
        AnchoBotones.Value = My.Settings.Width_Button
        SpacioEntreBotones.Value = My.Settings.Space_button
        BotonesXfila.Value = My.Settings.ItemsXFilas
        ColorButton.BackColor = My.Settings.button_color
        ColorButtonSelect.BackColor = My.Settings.button_colorSelect
        idPublicoGeneral.Value = My.Settings.id_publicoGeneral
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim MysqlCommand As New MySqlCommand
            Dim MysqlConnString As String = "server=" + Txt_DB_Servidor.Text + "; user id=" + Txt_DB_Username.Text + "; password=" + Txt_DB_Password.Text + "; database=" + Txt_DB_DB.Text + "; Port=" + Txt_DB_Puerto.Text + ";"
            Dim MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)
            MysqlConexion.Open()
            MsgBox("Conexion existosa", MsgBoxStyle.Information, "Respuesta Conexion DB")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("No fue posible conectarse al servidor", MsgBoxStyle.Critical, "Respuesta Conexion DB")
        End Try
    End Sub

    Private Sub TxtGuardar_Click(sender As Object, e As EventArgs) Handles TxtGuardar.Click
        My.Settings.db_servidor = Txt_DB_Servidor.Text
        My.Settings.db_username = Txt_DB_Username.Text
        My.Settings.db_password = Txt_DB_Password.Text
        My.Settings.db_nameDB = Txt_DB_DB.Text
        My.Settings.db_puerto = Txt_DB_Puerto.Text
        My.Settings.DesktopBackgroundImage = TxtDesktopBackground.Text
        My.Settings.datagridview_color = Tabla_ColorFondo.BackColor
        My.Settings.datagridview_selectrow = TablaColorSeleccion.BackColor
        My.Settings.text_font = TipoLetra.Font
        My.Settings.Menu_color = ColorMenu.BackColor
        My.Settings.Menu_font = LetraMenu.Font
        My.Settings.moneda = ComboBox1.SelectedItem.ToString.ToUpper
        My.Settings.form_windowstate = Ventana.SelectedIndex
        My.Settings.Height_Button = AltoBotones.Value
        My.Settings.Width_Button = AnchoBotones.Value
        My.Settings.Space_button = SpacioEntreBotones.Value
        My.Settings.ItemsXFilas = BotonesXfila.Value
        My.Settings.button_color = ColorButton.BackColor
        My.Settings.button_colorSelect = ColorButtonSelect.BackColor
        My.Settings.id_publicoGeneral = idPublicoGeneral.Value
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Logo |*.jpg;*.jpeg;*.png;*.gif;*.tif;"
        If file.ShowDialog() = DialogResult.OK Then
            Dim fs As FileStream = New System.IO.FileStream(file.FileName, FileMode.Open, FileAccess.Read)
            TxtDesktopBackground.Text = file.FileName.Replace("\", "/")
            fs.Close()
        End If
    End Sub

    Private Sub Tabla_ColorFondo_Click(sender As Object, e As EventArgs) Handles Tabla_ColorFondo.Click
        ColorDialog1.Color = Tabla_ColorFondo.BackColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Tabla_ColorFondo.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub TablaColorSeleccion_Click(sender As Object, e As EventArgs) Handles TablaColorSeleccion.Click
        ColorDialog1.Color = TablaColorSeleccion.BackColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            TablaColorSeleccion.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub TipoLetra_Click(sender As Object, e As EventArgs) Handles TipoLetra.Click
        FontDialog1.Font = TipoLetra.Font
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            TipoLetra.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub ColorMenu_Click(sender As Object, e As EventArgs) Handles ColorMenu.Click
        ColorDialog1.Color = ColorMenu.BackColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ColorMenu.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub LetraMenu_Click(sender As Object, e As EventArgs) Handles LetraMenu.Click
        FontDialog1.Font = LetraMenu.Font
        If FontDialog1.ShowDialog() = DialogResult.OK Then
            LetraMenu.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        ColorDialog1.Color = ColorButton.BackColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ColorButton.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ColorButtonSelect_Click(sender As Object, e As EventArgs) Handles ColorButtonSelect.Click
        ColorDialog1.Color = ColorButtonSelect.BackColor
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            ColorButtonSelect.BackColor = ColorDialog1.Color
        End If
    End Sub
End Class