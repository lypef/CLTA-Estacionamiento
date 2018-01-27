Public Class Vehicles
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Public Sub Loader()
        f.GetVehicles("SELECT v.id, c.name, v.matricula, v.modelo, v.color, v.estado FROM clients c, vehicles v where v.client = c.id ORDER by c.name asc", Table)
        Functions.Vehicle = ""
    End Sub

    Private Sub Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me, FormBorderStyle.None)
        MenuStrip1.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        ToolStripMenuItem3.Font = My.Settings.Menu_font
        ToolStripMenuItem2.Font = My.Settings.Menu_font
        SalirToolStripMenuItem.Font = My.Settings.Menu_font
        TxtSearch.Font = My.Settings.Menu_font
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
        Label1.Font = My.Settings.Menu_font
        Label1.BackColor = My.Settings.Menu_color

        TabControl1.Font = My.Settings.Menu_font
    End Sub

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

    Private Sub Vehicles_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Vehicles_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub TxtSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearch.Enter
        TxtSearch.ForeColor = Color.Black
        TxtSearch.Text = Nothing
    End Sub

    Private Sub TxtSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearch.Leave
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
    End Sub

    Private Sub TxtSearch_MouseEnter(sender As Object, e As EventArgs) Handles TxtSearch.MouseEnter
        TxtSearch.ForeColor = Color.Black
        TxtSearch.Text = Nothing
    End Sub

    Private Sub TxtSearch_MouseLeave(sender As Object, e As EventArgs) Handles TxtSearch.MouseLeave
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            'TabControl1.SelectedIndex = 0
            'f.GetClients("SELECT * FROM clients where name LIKE '%" + TxtSearch.Text + "%' or address LIKE '%" + TxtSearch.Text + "%' or phone LIKE '%" + TxtSearch.Text + "%' OR mail LIKE '%" + TxtSearch.Text + "%' OR rfc LIKE '%" + TxtSearch.Text + "%' OR razonsocial LIKE '%" + TxtSearch.Text + "%' ORDER by name asc", Table)
            'Functions.Client = ""
            'TxtSearch.Text = ""
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If (f.GetPermiso(f.Permiso_Vehicle_Edit)) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If (f.GetPermiso(f.Permiso_Vehicle_Delete)) Then
            If (MsgBox("¿Esta seguro de eliminar el vehiculo ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.Vehicles_DELETE Then
                    Loader()
                    f.Alert("Vehiculo eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El vehiculo no se elimino", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loader()
        ElseIf TabControl1.SelectedIndex = 1 Then
            If (f.GetPermiso(f.Permiso_Vehicle_Edit) And String.IsNullOrEmpty(Functions.Vehicle) = False) Then
                LoadEdit()
            Else
                f.Alert("Seleccione un vehiculo | Verifique sus permisos", f.Alert_NumberExclamacion, PanelControl.Desktop)
                TabControl1.SelectedIndex = 0
            End If
        ElseIf TabControl1.SelectedIndex = 2 Then
            f.Alert("Agregar", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub LoadEdit()
        f.Alert("editar", f.Alert_NumberInformacion, PanelControl.Desktop)
    End Sub

    Private Sub Table_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellContentDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Vehicle = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Vehicles_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

End Class