Public Class Assigns
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Public Sub Loader()
        f.GetVehicles("SELECT v.matricula, c.name, t.name, v.modelo, v.color, v.estado FROM clients c, vehicles v, tarifas t where v.client = c.id and v.tarifa = t.id ORDER by c.name ASC", Table)
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
            If (f.IsNumber(TxtSearch.Text)) Then
                TxtSearch.Text = (Convert.ToInt32(TxtSearch.Text)).ToString
            End If
            f.GetVehicles("SELECT v.matricula, c.name, t.name, v.modelo, v.color, v.estado FROM clients c, vehicles v, tarifas t where v.client = c.id and v.tarifa = t.id and v.matricula like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and c.name like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.modelo like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.color like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.estado like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and t.name like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.rfid like '%" + TxtSearch.Text + "%' ORDER by c.name ASC", Table)
            TxtSearch.Text = ""
        End If
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

    Private Sub Assigns_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Assigns_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub Assigns_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub Assigns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me, FormBorderStyle.None)
        TxtSearch.BackColor = My.Settings.Menu_color
        TxtSearch.Font = My.Settings.Menu_font
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Matricula = Table.SelectedCells(0).Value
            AsignacionesUPDATE.Dispose()
            AsignacionesUPDATE.loadvalues()
            f.AddForm_Desktop(AsignacionesUPDATE, PanelControl.Desktop)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub
End Class