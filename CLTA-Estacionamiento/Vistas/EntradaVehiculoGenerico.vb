Public Class EntradaVehiculoGenerico
    Dim f As New Functions
    Public Sub loadvalues()
        f.ComboboxSetTarifas(ComboTarifa)

        My.Settings.lastMatricula += 1
        V_Matricula.Text = My.Settings.lastMatricula

        V_Color.Text = ""
        V_Estado.Text = ""
        V_Modelo.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboTarifa.SelectedIndex > 0 And String.IsNullOrWhiteSpace(V_Matricula.Text) = False Then
            If f.AddVehicle_Generico(V_Matricula, V_Modelo, V_Color, V_Estado, ComboTarifa) Then
                My.Settings.Save()
                EnterExitControl.Loader()
                If My.Settings.ticket_imprimir_xhora Then
                    f.TicketGeneratePrint_Cadena("INGRESO VEHICULO CON MATRICULA:", V_Matricula.Text.ToUpper, True)
                End If
                f.ActionBarr(My.Settings.rele_entrada)
                Me.Dispose()
                Else
                    f.Alert("Verifique sus datos", f.Alert_NumberExclamacion, PanelControl.Desktop)
            End If

        Else
            f.Alert("Seleccione una tarifa | Ingrese matricula", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class