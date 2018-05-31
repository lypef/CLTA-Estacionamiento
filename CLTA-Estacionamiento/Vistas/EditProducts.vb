Public Class EditProducts
    Dim f As New Functions
    Dim matricula As String = String.Empty

    Public Sub Loader(var As String)
        matricula = var
        f.GetVtdVehicles("SELECT d.id, p.nombre, p.precio FROM delivery_tmp d, product_services p WHERE d.product = p.codebar and d.vehicle = '" + var + "'", Table)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub Tabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then

            If (MsgBox("¿Quitar producto?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.Vtd_TmpVehicle(Convert.ToInt32(Table.SelectedCells(0).Value)) = False Then
                    f.Alert("No es posible", f.Alert_NumberCritical, PanelControl.Desktop)
                Else
                    f.GetVtdVehicles("SELECT d.id, p.nombre, p.precio FROM delivery_tmp d, product_services p WHERE d.product = p.codebar and d.vehicle = '" + matricula + "'", Table)
                End If
            End If

        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EditProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
    End Sub
End Class