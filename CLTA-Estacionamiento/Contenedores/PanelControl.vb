Imports System.IO

Public Class PanelControl
    Dim f As New Functions

    Private Sub PanelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.loadforms(Desktop)
        Me.Text = "CLTA - ESTACIONAMIENTO"
        Me.Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
        Desktop.Height = Me.Height - (Footer.Height + BarraMenu.Height)
        Timer1.Start()
        If My.Computer.FileSystem.FileExists(My.Settings.DesktopBackgroundImage) Then
            Dim fs As FileStream = New System.IO.FileStream(My.Settings.DesktopBackgroundImage, FileMode.Open, FileAccess.Read)
            Desktop.BackgroundImage = Image.FromStream(fs)
            Desktop.BackgroundImageLayout = ImageLayout.Stretch
            fs.Close()
        End If
        BarraMenu.BackColor = My.Settings.Menu_color
        BarraMenu.Font = My.Settings.Menu_font
        ArchivoToolStripMenuItem.Font = My.Settings.Menu_font
        ClientesToolStripMenuItem.Font = My.Settings.Menu_font
        VentasToolStripMenuItem.Font = My.Settings.Menu_font
        ToolStripMenuItem1.Font = My.Settings.Menu_font
        AJUSTESToolStripMenuItem.Font = My.Settings.Menu_font
        LimpiarToolStripMenuItem.Font = My.Settings.Menu_font
        MinimizarToolStripMenuItem.Font = My.Settings.Menu_font
        SalirToolStripMenuItem.Font = My.Settings.Menu_font
        ToolStripMenuItem2.Font = My.Settings.Menu_font
        ToolStripMenuItem2.BackColor = My.Settings.Menu_color
        TxtBox.Font = My.Settings.Menu_font
        TxtBox.BackColor = My.Settings.Menu_color
        TxtBox.Text = "Matricula / QR"
        TxtBox.ForeColor = Color.Gray
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
        About.WindowState = FormWindowState.Normal
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Desktop.Controls.Clear()
    End Sub

    Private Sub LimpiarToolStripMenuItem1_Click(sender As Object, e As EventArgs)
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
        If f.GetPermiso(f.Permiso_Cliet_Access) Then
            Clientes.Loader()
            f.AddForm_Desktop(Clientes, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
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
        ElseIf mes = 2 Then
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
        properties.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        If f.GetPermiso(f.Permiso_Vehicle_Access) Or f.GetPermiso(f.Permiso_Assign_Access) Then
            Vehicles.Loader()
            f.AddForm_Desktop(Vehicles, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub TarifasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        EnterExitControl.Dispose()
        EnterExitControl.Loader()
        f.AddForm_Desktop(EnterExitControl, Desktop)
    End Sub

    Private Sub TxtBox_Enter(sender As Object, e As EventArgs) Handles TxtBox.Enter
        TxtBox.Text = ""
    End Sub

    Private Sub TxtBox_Leave(sender As Object, e As EventArgs) Handles TxtBox.Leave
        TxtBox.Text = "Matricula / QR"
    End Sub

    Private Sub TxtBox_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBox.KeyDown
        TxtBox.Text = TxtBox.Text.Replace("Matricula / QR", "")
        If e.KeyCode = Keys.Enter Then
            Dim hours As Boolean
            Dim day As Boolean
            Dim pension As Boolean

            If f.VehicleReturnTarifa(hours, day, pension, TxtBox) Then
                If f.Vehicle_Status(TxtBox) = False Then
                    If hours Then
                        If (MsgBox("Ingresar vehiculo con matricula: ".ToUpper + TxtBox.Text + "Para cobro por hora ?".ToUpper, f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                            If f.VehiclesUpdate_StatusForHours(TxtBox.Text, 1) Then
                                EnterExitControl.Loader()
                            Else
                                f.Alert("Error desconocido", f.Alert_NumberCritical, Desktop)
                            End If
                        End If
                    ElseIf day Then
                        'Ingresa por dia 
                        If f.VehicleValidateFecha_Salida(TxtBox) Then
                            f.Vehicle_ChangeStatus(TxtBox.Text, 1)
                            EnterExitControl.Loader()
                        Else
                            If (MsgBox("Dias vencidos. matricula: ".ToUpper + TxtBox.Text + " arrendar por hora ?".ToUpper, f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                                If f.VehiclesUpdate_DiasVencidosForHours(TxtBox.Text, 1) Then
                                    EnterExitControl.Loader()
                                End If
                            End If
                        End If
                    ElseIf pension Then
                        'Pension
                        If f.VehicleValidateFecha_Salida(TxtBox) Then
                            f.Vehicle_ChangeStatus(TxtBox.Text, 1)
                            EnterExitControl.Loader()
                        Else
                            If (MsgBox("Pension vencida. matricula: ".ToUpper + TxtBox.Text + " arrendar por hora ?".ToUpper, f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                                If f.VehiclesUpdate_DiasVencidosForHours(TxtBox.Text, 1) Then
                                    EnterExitControl.Loader()
                                End If
                            End If
                        End If
                    End If
                Else
                    f.Alert("El vehiculo ya se encuentra adento", f.Alert_NumberExclamacion, Desktop)
                End If
            Else
                f.Alert("La matricula no existe", f.Alert_NumberCritical, Desktop)
            End If
            TxtBox.Focus()
        End If
    End Sub

    Private Sub TarifasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TarifasToolStripMenuItem1.Click
        If f.GetPermiso(f.Permiso_Rate_Access) Then
            Rate.Loader()
            f.AddForm_Desktop(Rate, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        VentaDirecta.loader()
        f.AddForm_Desktop(VentaDirecta, Desktop)
    End Sub
End Class