Public Class Rate

    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim editar As Boolean = False

    Private Sub Rate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        editar = False
        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
        Label1.Font = My.Settings.Menu_font
        Label1.BackColor = My.Settings.Menu_color

        TxtSearch.BackColor = My.Settings.Menu_color
        TxtSearch.Font = My.Settings.Menu_font

        ToolStripMenuItem.Font = My.Settings.Menu_font
        ToolStripMenuItem2.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        ToolStripMenuItem3.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        TabControl1.Font = My.Settings.text_font
        TxtSearch.Text = "//BUSCAR"
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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub Rate_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Rate_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub Rate_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
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

    End Sub

    Private Sub TxtSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearch.Enter
        TxtSearch.ForeColor = Color.Black
        TxtSearch.Text = Nothing
    End Sub

    Private Sub TxtSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearch.Leave
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loader()
        ElseIf TabControl1.SelectedIndex = 1 Then
            Edit()
        ElseIf TabControl1.SelectedIndex = 2 Then
            Agregar()
        End If
    End Sub

    Private Sub Edit()
        f.Alert("Editar", f.Alert_NumberInformacion, PanelControl.Desktop)
    End Sub

    Private Sub Agregar()
        f.Alert("Agregar", f.Alert_NumberInformacion, PanelControl.Desktop)
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Tarifa = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Rate_Delete) Then
            If (MsgBox("¿ Eliminar esta tarifa ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.Rate_DELETE Then
                    Loader()
                    f.Alert("Tarifa eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("Tarifa no se elimino || Algun vehiculo puede estar usandola", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Public Sub Loader()
        f.GetTarifas("SELECT * FROM tarifas ORDER by name asc", Table)
        Functions.Tarifa = ""
    End Sub
End Class