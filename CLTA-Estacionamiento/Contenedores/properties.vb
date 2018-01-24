Imports System.IO
Imports MySql.Data.MySqlClient

Public Class properties
    Dim f As New Functions

    Private Sub properties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.Reset()
        My.Settings.Save()
        Application.Restart()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class