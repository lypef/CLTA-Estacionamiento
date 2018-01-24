Public Class Clientes
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
        MainMenuStrip.BackColor = My.Settings.Menu_color
        MainMenuStrip.Font = My.Settings.Menu_font
        Label1.Font = My.Settings.Menu_font

        TabPage1.Font = My.Settings.Menu_font
        TabPage2.Font = My.Settings.Menu_font
        TabPage3.Font = My.Settings.Menu_font
        Label1.Font = My.Settings.Menu_font
        ToolStripMenuItem1.Font = My.Settings.Menu_font
        ToolStripMenuItem3.Font = My.Settings.Menu_font
        ToolStripMenuItem2.Font = My.Settings.Menu_font
        SalirToolStripMenuItem.Font = My.Settings.Menu_font
    End Sub

    Private Sub MinimizarToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Clientes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Clientes_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Clientes_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Client = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Cliet_Delete) Then
            If (MsgBox("¿Esta seguro de eliminar el cliente # " + Functions.Client + " ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.Clients_DELETE Then
                    Loader()
                    f.Alert("Cliente eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El cliente no se elimino", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Public Sub Loader()
        f.GetClients("SELECT * FROM clients ORDER by name asc", Table)
    End Sub
End Class