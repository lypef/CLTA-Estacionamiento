﻿Imports System.IO

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
        MinimizarToolStripMenuItem.Font = My.Settings.Menu_font
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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If (MsgBox("¿Desea salir?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        f.AddForm_Desktop(About, Desktop)
        About.WindowState = FormWindowState.Normal
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs)

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

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)

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

    Private Sub AjustesToolStripMenuItem1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)

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
                                f.ActionBarr(My.Settings.rele_entrada)
                                If My.Settings.ticket_imprimir_xhora Then
                                    f.TicketGeneratePrint_Cadena("INGRESO VEHICULO CON MATRICULA:", TxtBox.Text.ToUpper, False)
                                End If
                                EnterExitControl.Loader()
                            Else
                                f.Alert("Error desconocido", f.Alert_NumberCritical, Desktop)
                            End If
                        End If
                    ElseIf day Then
                        'Ingresa por dia 
                        If f.VehicleValidateFecha_Salida(TxtBox) Then
                            f.Vehicle_ChangeStatus(TxtBox.Text, 1)
                            f.ActionBarr(My.Settings.rele_entrada)
                            EnterExitControl.Loader()
                        Else
                            If (MsgBox("Dias vencidos. matricula: ".ToUpper + TxtBox.Text + " arrendar por hora ?".ToUpper, f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                                If f.VehiclesUpdate_DiasVencidosForHours(TxtBox.Text, 1) Then
                                    f.ActionBarr(My.Settings.rele_entrada)
                                    If My.Settings.ticket_imprimir_xhora Then
                                        f.TicketGeneratePrint_Cadena("INGRESO VEHICULO CON MATRICULA:", TxtBox.Text.ToUpper, False)
                                    End If
                                    EnterExitControl.Loader()
                                End If
                            End If
                        End If
                    ElseIf pension Then
                        'Pension
                        If f.VehicleValidateFecha_Salida(TxtBox) Then
                            f.Vehicle_ChangeStatus(TxtBox.Text, 1)
                            f.ActionBarr(My.Settings.rele_entrada)
                            EnterExitControl.Loader()
                        Else
                            If (MsgBox("Pension vencida. matricula: ".ToUpper + TxtBox.Text + " arrendar por hora ?".ToUpper, f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                                If f.VehiclesUpdate_DiasVencidosForHours(TxtBox.Text, 1) Then
                                    f.ActionBarr(My.Settings.rele_entrada)
                                    If My.Settings.ticket_imprimir_xhora Then
                                        f.TicketGeneratePrint_Cadena("INGRESO VEHICULO CON MATRICULA:", TxtBox.Text.ToUpper, False)
                                    End If
                                    EnterExitControl.Loader()
                                End If
                            End If
                        End If
                    End If
                Else
                    'f.Alert("El vehiculo ya se encuentra adentro", f.Alert_NumberCritical, Desktop)
                    If (MsgBox("VEHICULO YA SE ENCUENTRA ADENTRO, DESEA DAR SALIDA A: " + TxtBox.Text, f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                        If f.VehicleReturnAdeudoConProducts(TxtBox.Text) > 0 Then
                            EnterExitControl.Adeudo(TxtBox.Text, f.VehicleReturnAdeudoConProducts(TxtBox.Text))
                        Else
                            f.Vehicle_ChangeStatus(TxtBox.Text, 0)
                            f.ActionBarr(My.Settings.rele_salida)
                            EnterExitControl.Loader()
                        End If
                    End If
                    'Finaliza
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

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs)
        If f.GetPermiso(f.Permiso_ventas_access) Then
            Ventas.loader()
            f.AddForm_Desktop(Ventas, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem1.Click
        If f.GetPermiso(f.Permiso_User_access) Then
            users.Loader()
            f.AddForm_Desktop(users, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub AccionarBarraToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccionarBarraToolStripMenuItem.Click
        OpenBarrNum.NumericUpDown1.Value = My.Settings.rele_entrada
        OpenBarrNum.NumericUpDown1.Select()
        f.AddForm_Desktop(OpenBarrNum, Desktop)
    End Sub

    Private Sub ReimprimirTicketToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReimprimirTicketToolStripMenuItem.Click
        R_ticket.NumericUpDown1.Select()
        f.AddForm_Desktop(R_ticket, Desktop)
    End Sub

    Private Sub EntradaVehiculoGenericoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaVehiculoGenericoToolStripMenuItem.Click
        EntradaVehiculoGenerico.loadvalues()
        f.AddForm_Desktop(EntradaVehiculoGenerico, Desktop)
    End Sub

    Private Sub CorteXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorteXToolStripMenuItem.Click
        Dim Table As New DataGridView
        Dim total As Decimal = f.GetCut(Table)
        Dim concepto As String = "CONCEPTO: corte x"
        Dim footer As String = "total recaudado $: " + total.ToString
        ReaderPdf.url = f.GeneratePDF_Table(Table, concepto, footer, True)
        f.AddForm_Desktop(ReaderPdf, Desktop)
        ReaderPdf.OpenPdf()
    End Sub

    Private Sub CorteZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CorteZToolStripMenuItem.Click
        If (MsgBox("¿ REALIZAR CORTE Z Y REGRESAR A CERO LA CAJA ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
            Dim Table As New DataGridView
            Dim total As Decimal = f.GetCut(Table)
            Dim concepto As String = "CONCEPTO: corte Z"
            Dim footer As String = "total recaudado $: " + total.ToString
            ReaderPdf.url = f.GeneratePDF_Table(Table, concepto, footer, True)
            f.AddForm_Desktop(ReaderPdf, Desktop)
            ReaderPdf.OpenPdf()
            If f.UpdateCutX() = False Then
                f.Alert("No se realizo el corte Z", f.Alert_NumberInformacion, Desktop)
            End If
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripMenuItem3_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        If f.GetPermiso(f.Permiso_cutX) Then
            Dim Table As New DataGridView
            Dim total As Decimal = f.GetCutGeneral(Table)
            Dim concepto As String = "CONCEPTO: corte x general"
            Dim footer As String = "total recaudado $: " + total.ToString
            ReaderPdf.url = f.GeneratePDF_Table(Table, concepto, footer, True)
            f.AddForm_Desktop(ReaderPdf, Desktop)
            ReaderPdf.OpenPdf()
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        If f.GetPermiso(f.Permiso_cutZ) Then
            If (MsgBox("¿ REALIZAR CORTE Z GENERAL Y REGRESAR A CERO LA CAJA ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                Dim Table As New DataGridView
                Dim total As Decimal = f.GetCutGeneral(Table)
                Dim concepto As String = "CONCEPTO: corte Z GENERAL"
                Dim footer As String = "total recaudado $: " + total.ToString
                ReaderPdf.url = f.GeneratePDF_Table(Table, concepto, footer, True)
                f.AddForm_Desktop(ReaderPdf, Desktop)
                ReaderPdf.OpenPdf()
                If f.UpdateCutZGeneral() = False Then
                    f.Alert("No se realizo el corte Z general", f.Alert_NumberExclamacion, Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub VentasToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem1.Click
        If f.GetPermiso(f.Permiso_ventas_access) Then
            Ventas.loader()
            f.AddForm_Desktop(Ventas, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub VentaDirectaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaDirectaToolStripMenuItem.Click
        VentaDirecta.loader()
        f.AddForm_Desktop(VentaDirecta, Desktop)
    End Sub

    Private Sub AjustesToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem2.Click
        f.AddForm_Desktop(properties, Desktop)
        properties.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        If f.GetPermiso(f.Permiso_Cliet_Access) Then
            Clientes.Loader()
            f.AddForm_Desktop(Clientes, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub VehiculosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VehiculosToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Vehicle_Access) Or f.GetPermiso(f.Permiso_Assign_Access) Then
            Vehicles.Loader()
            f.AddForm_Desktop(Vehicles, Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, Desktop)
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem1.Click
        Desktop.Controls.Clear()
    End Sub
End Class