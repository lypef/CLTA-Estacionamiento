﻿Public Class Adeudos
    Dim f As New Functions
    Public Matricula As String
    Public MontoTotal As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f.Vehicles_ProductsRealizarVenta(Matricula, ImpTicket.Checked)
        f.Vehicle_ChangeStatus(Matricula, 0)
        If My.Settings.vehicles_generics Then
            If f.Return_Cliente_Vehicle(Matricula) = My.Settings.id_publicoGeneral Then
                Functions.Matricula = Matricula
                Functions.Vehicles_DELETE()
            End If
        End If
        EnterExitControl.Loader()
        f.ActionBarr(My.Settings.rele_salida)
        Me.Dispose()
    End Sub

    Private Sub Adeudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Detalles.Font = My.Settings.text_font
        Button1.Font = My.Settings.Menu_font
    End Sub

    Public Sub LoadTotalButton()
        Button1.Text = "COBRAR $: " + MontoTotal.ToString + " " + My.Settings.moneda
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class