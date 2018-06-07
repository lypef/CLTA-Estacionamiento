Public Class Ventas
    Dim f As New Functions
    Dim total As Decimal

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Public Sub loader()
        f_desde.Value = DateTime.Now
        f_hasta.Value = DateTime.Now
        RbTodos.Checked = True
        SelectLoader()
    End Sub

    Private Sub SelectLoader()
        If RbTodos.Checked Then
            total = f.GetVentas("SELECT v.id, c.name, u.name, v.id_ticket, v.concepto, v.monto, v.date FROM ventas v, clients c, users u WHERE v.id_cliente = c.id and v.id_usuario = u.id", Table, f_desde, f_hasta)
        ElseIf RbProductos.Checked Then
            total = f.GetVentas("SELECT v.id, c.name, u.name, v.id_ticket, v.concepto, v.monto, v.date FROM ventas v, clients c, users u WHERE v.id_cliente = c.id and v.id_usuario = u.id and v.producto = 1", Table, f_desde, f_hasta)
        ElseIf RbServicios.Checked Then
            total = f.GetVentas("SELECT v.id, c.name, u.name, v.id_ticket, v.concepto, v.monto, v.date FROM ventas v, clients c, users u WHERE v.id_cliente = c.id and v.id_usuario = u.id and v.service = 1", Table, f_desde, f_hasta)
        ElseIf RbAsignaciones.Checked Then
            total = f.GetVentas("SELECT v.id, c.name, u.name, v.id_ticket, v.concepto, v.monto, v.date FROM ventas v, clients c, users u WHERE v.id_cliente = c.id and v.id_usuario = u.id and v.membresia = 1", Table, f_desde, f_hasta)
        End If

    End Sub

    Private Sub RbTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RbTodos.CheckedChanged
        If RbTodos.Checked Then
            SelectLoader()
        End If
    End Sub

    Private Sub RbProductos_CheckedChanged(sender As Object, e As EventArgs) Handles RbProductos.CheckedChanged
        If RbProductos.Checked Then
            SelectLoader()
        End If
    End Sub

    Private Sub RbServicios_CheckedChanged(sender As Object, e As EventArgs) Handles RbServicios.CheckedChanged
        If RbServicios.Checked Then
            SelectLoader()
        End If
    End Sub

    Private Sub RbAsignaciones_CheckedChanged(sender As Object, e As EventArgs) Handles RbAsignaciones.CheckedChanged
        If RbAsignaciones.Checked Then
            SelectLoader()
        End If
    End Sub

    Private Sub f_desde_ValueChanged(sender As Object, e As EventArgs) Handles f_desde.ValueChanged
        SelectLoader()
    End Sub

    Private Sub f_hasta_ValueChanged(sender As Object, e As EventArgs) Handles f_hasta.ValueChanged
        SelectLoader()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
    End Sub

    Private Sub GenerarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem.Click
        Dim concepto As String = "CONCEPTO: VENTAS Y COBROS DE: " + f_desde.Value.ToShortDateString + " HASTA: " + f_hasta.Value.ToShortDateString

        If RbProductos.Checked Then
            concepto = "CONCEPTO: VENTAS DE PRODUCTOS DE: " + f_desde.Value.ToShortDateString + " HASTA: " + f_hasta.Value.ToShortDateString
        End If

        If RbServicios.Checked Then
            concepto = "CONCEPTO: COBROS DE SERVICIOS DE: " + f_desde.Value.ToShortDateString + " HASTA: " + f_hasta.Value.ToShortDateString
        End If

        If RbAsignaciones.Checked Then
            concepto = "CONCEPTO: COBROS DE ASIGNACIONES DE: " + f_desde.Value.ToShortDateString + " HASTA: " + f_hasta.Value.ToShortDateString
        End If

        Dim footer As String = ""
        footer += "TOTAL: $ " + total.ToString

        ReaderPdf.url = f.GeneratePDF_Table(Table, concepto, footer, True)
        f.AddForm_Desktop(ReaderPdf, PanelControl.Desktop)
        ReaderPdf.OpenPdf()
    End Sub
End Class