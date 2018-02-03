Public Class Assigns
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Public Sub Loader()
        f.forms_setmodel(Me, FormBorderStyle.None)
        TxtSearch.BackColor = My.Settings.Menu_color
        TxtSearch.Font = My.Settings.Menu_font
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"

        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color

    End Sub

    Private Sub Assigns_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub
End Class