Public Class AsignacionesUPDATE
    Dim f As New Functions
    Dim Client As Integer = 0
    Dim total As Double = 0
    Dim precioxhora As Double = 0
    Dim preciodia As Double = 0
    Dim precioxpension As Double = 0
    Dim dias_pencion As Integer = 0
    Dim horas_dias As Integer = 0
    Dim c_event As Boolean = False
    Dim f_exit As DateTime

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub AsignacionesUPDATE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me, FormBorderStyle.None)
        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
        ComboBoxTarifas.Font = My.Settings.text_font
        LabelCliente.Font = My.Settings.text_font
        LabelVehiculo.Font = My.Settings.text_font
        RB_Hora.Font = My.Settings.text_font
        RB_Dias.Font = My.Settings.text_font
        Rb_Pension.Font = My.Settings.text_font
        LabelMatricula.Font = My.Settings.text_font
    End Sub

    Public Sub loadvalues()
        f.ComboboxSetTarifas(ComboBoxTarifas)
        f.Vehicle_LoadValuesAsignacion(ImagenPropietario, ComboBoxTarifas, LabelCliente, LabelVehiculo, RB_Hora, RB_Dias, Rb_Pension, LabelMatricula, Client)
        LoadTotal()
        c_event = True
        DateFinalice.Text = "FINALIZA: " + DateTime.Now.ToString
        If RB_Hora.Checked Then
            Stadia.Enabled = False
        End If
    End Sub

    Private Sub LoadTotal()
        f.loadtotalAsignacion(ComboBoxTarifas, precioxhora, preciodia, precioxpension, dias_pencion, horas_dias)
        Stadia.Value = 0
        TotalTXT.Text = "0.0"
    End Sub

    Private Sub AsignacionesUPDATE_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub RB_Hora_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Hora.CheckedChanged
        If RB_Hora.Checked Then
            If c_event Then
                Stadia.Value = 0
                Stadia.Enabled = False
                TotalTXT.Text = "0.0"
                If f.Vehicle_MembresisVigente(Functions.Matricula) Then
                    f.Alert("El vehiculo tiene una membresia activa si procede a guardar el vehiculo perdera su membresia y se cobrara x horas.", f.Alert_NumberExclamacion, PanelControl.Desktop)
                End If
            End If
        End If
    End Sub

    Private Sub RB_Dias_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Dias.CheckedChanged
        If RB_Dias.Checked Then
            If c_event Then
                Stadia.Value = 0
                Stadia.Enabled = True
                TotalTXT.Text = "0.0"
                If f.Vehicle_MembresisVigente(Functions.Matricula) Then
                    f.Alert("El vehiculo tiene una membresia activa", f.Alert_NumberExclamacion, PanelControl.Desktop)
                End If
            End If
        End If
    End Sub

    Private Sub Rb_Pension_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Pension.CheckedChanged
        If Rb_Pension.Checked Then
            If c_event Then
                Stadia.Value = 0
                Stadia.Enabled = True
                TotalTXT.Text = "0.0"
                If f.Vehicle_MembresisVigente(Functions.Matricula) Then
                    f.Alert("El vehiculo tiene una membresia activa", f.Alert_NumberExclamacion, PanelControl.Desktop)
                End If
            End If
        End If
    End Sub

    Private Sub ComboBoxTarifas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxTarifas.SelectedIndexChanged
        If c_event Then
            LoadTotal()
        End If
    End Sub

    Private Sub Stadia_ValueChanged(sender As Object, e As EventArgs) Handles Stadia.ValueChanged
        If RB_Dias.Checked Then
            total = preciodia * Stadia.Value
            TotalTXT.Text = "TOTAL $: " + total.ToString
            f_exit = DateTime.Now.AddHours(Stadia.Value * horas_dias)
            DateFinalice.Text = "FINALIZA: " + f_exit.ToString()
            If f.Vehicle_MembresisVigente(Functions.Matricula) Then
                f.Alert("El vehiculo tiene una membresia activa", f.Alert_NumberExclamacion, PanelControl.Desktop)
            End If
        ElseIf Rb_Pension.Checked Then
            total = precioxpension * Stadia.Value
            TotalTXT.Text = "TOTAL $: " + total.ToString
            f_exit = DateTime.Now.AddDays(Stadia.Value * dias_pencion)
            DateFinalice.Text = "FINALIZA: " + f_exit.ToString()
            If f.Vehicle_MembresisVigente(Functions.Matricula) Then
                f.Alert("El vehiculo tiene una membresia activa", f.Alert_NumberExclamacion, PanelControl.Desktop)
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Stadia.Value > 0 Then
            If RB_Dias.Checked Then
                If (MsgBox("¿ ASIGNAR " + Stadia.Value.ToString + " DIAS A LA " + LabelVehiculo.Text + " " + LabelMatricula.Text + " ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                    If f.Vehicle_Update_dias(ComboBoxTarifas, f_exit) Then
                        Me.Dispose()
                        Vehicles.Loader()
                        If f.AddVenta(Client, "Pago de membresia x dias: hasta " + f.GetDateString(f_exit), total, f.TickerID_Siguiente()) Then
                            f.Alert("Cambios actualizados", f.Alert_NumberInformacion, PanelControl.Desktop)
                        Else
                            f.Alert("Cambios NO actualizados", f.Alert_NumberInformacion, PanelControl.Desktop)
                        End If
                    Else
                        f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberInformacion, PanelControl.Desktop)
                    End If
                End If
            ElseIf Rb_Pension.Checked Then
                If (MsgBox("¿ ASIGNAR " + Stadia.Value.ToString + " PENSIONES A LA " + LabelVehiculo.Text + " " + LabelMatricula.Text + " ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                    If f.Vehicle_Update_Pension(ComboBoxTarifas, f_exit) Then
                        Me.Dispose()
                        Vehicles.Loader()
                        If f.AddVenta(Client, "Pago de membresia x pension: hasta " + f.GetDateString(f_exit), total, f.TickerID_Siguiente()) Then
                            f.Alert("Cambios actualizados", f.Alert_NumberInformacion, PanelControl.Desktop)
                        Else
                            f.Alert("Cambios NO actualizados", f.Alert_NumberInformacion, PanelControl.Desktop)
                        End If
                    Else
                        f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberInformacion, PanelControl.Desktop)
                    End If
                End If
            End If
        Else
            If RB_Hora.Checked Then
                If f.Vehicle_Update_Horas(ComboBoxTarifas) Then
                    Me.Dispose()
                    Vehicles.Loader()
                    f.Alert("Cambios actualizados", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberInformacion, PanelControl.Desktop)
                End If
            Else
                f.Alert("Indique un numero", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        End If
    End Sub
End Class