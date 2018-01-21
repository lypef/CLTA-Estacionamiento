﻿Public Class PanelControl
    Dim f As New Functions

    Private Sub PanelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "CLTA - ESTACIONAMIENTO"
        Me.Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
        Desktop.Height = Me.Height - (Footer.Height + BarraMenu.Height)
        Timer1.Start()
        If My.Computer.FileSystem.FileExists(My.Settings.DesktopBackgroundImage) Then
            Desktop.BackgroundImage = Image.FromFile(My.Settings.DesktopBackgroundImage)
            Desktop.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub MinimizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿Desea salir?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        f.AddForm_Desktop(About, Desktop)
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Desktop.Controls.Clear()
    End Sub

    Private Sub LimpiarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem1.Click
        Desktop.Controls.Clear()
    End Sub

    Private Sub MinimizarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MinimizarToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        If (MsgBox("¿Desea salir?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        f.AddForm_Desktop(Clientes, Desktop)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dia As Integer = DateTime.Now.DayOfWeek
        Dim dia_mes As Integer = DateTime.Now.Day
        Dim mes As Integer = DateTime.Now.Month

        Dim fecha As String = ""

        If dia = 1 Then
            fecha = "Lunes"
        ElseIf dia = 2 Then
            fecha = "Martes"
        ElseIf dia = 3 Then
            fecha = "Miercoles"
        ElseIf dia = 3 Then
            fecha = "Miercoles"
        ElseIf dia = 4 Then
            fecha = "Jueves"
        ElseIf dia = 5 Then
            fecha = "Viernes"
        ElseIf dia = 6 Then
            fecha = "Sabado"
        ElseIf dia = 7 Then
            fecha = "Viernes"
        End If

        If mes = 1 Then
            fecha += " " + dia_mes.ToString + " de " + "Enero de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf dia = 2 Then
            fecha += " " + dia_mes.ToString + " de " + "febrero de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 3 Then
            fecha += " " + dia_mes.ToString + " de " + "marzo de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 4 Then
            fecha += " " + dia_mes.ToString + " de " + "abril de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 5 Then
            fecha += " " + dia_mes.ToString + " de " + "mayo de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 6 Then
            fecha += " " + dia_mes.ToString + " de " + "junio de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 7 Then
            fecha += " " + dia_mes.ToString + " de " + "julio de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 8 Then
            fecha += " " + dia_mes.ToString + " de " + "agosto de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 9 Then
            fecha += " " + dia_mes.ToString + " de " + "septiembre de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 10 Then
            fecha += " " + dia_mes.ToString + " de " + "octubre de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 11 Then
            fecha += " " + dia_mes.ToString + " de " + "noviembre de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        ElseIf mes = 12 Then
            fecha += " " + dia_mes.ToString + " de " + "diciembre de " + DateTime.Now.Year.ToString + " | HORA: " + DateTime.Now.Hour.ToString + ":" + DateTime.Now.Minute.ToString + ":" + DateTime.Now.Second.ToString
        End If

        LabelHora.Text = fecha.ToUpper + " | USUARIO : " + Functions.username_name
    End Sub

    Private Sub CambiarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarUsuarioToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub AjustesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem1.Click
        f.AddForm_Desktop(properties, Desktop)
    End Sub
End Class