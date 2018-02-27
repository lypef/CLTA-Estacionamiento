Public Class EnterExitControl
    Dim f As New Functions

    Public Sub Loader()
        f.VehiclesLoadForControl(Panel1, "SELECT matricula, modelo FROM vehicles where status = '1'", ContextMenuStrip1)
        Panel1.Focus()
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

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        Loader()
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtSearch.Text = TxtSearch.Text.Replace("//BUSCAR", "")
            If (f.IsNumber(TxtSearch.Text)) Then
                TxtSearch.Text = (Convert.ToInt32(TxtSearch.Text)).ToString
            End If
            f.VehiclesLoadForControl(Panel1, "SELECT v.matricula, v.modelo FROM clients c, vehicles v where v.client = c.id and v.matricula like '%" + TxtSearch.Text + "%' and status = '1' or v.client = c.id and c.name like '%" + TxtSearch.Text + "%' and status = '1' or v.client = c.id and v.modelo like '%" + TxtSearch.Text + "%' and status = '1' or v.client = c.id and v.color like '%" + TxtSearch.Text + "%' and status = '1' or v.client = c.id and v.estado like '%" + TxtSearch.Text + "%' and status = '1' or v.client = c.id and v.rfid like '%" + TxtSearch.Text + "%' and status = '1'", ContextMenuStrip1)
            TxtSearch.Text = ""
        End If
    End Sub

    Private Sub EnterExitControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtSearch.BackColor = My.Settings.Menu_color
        TxtSearch.Font = My.Settings.Menu_font
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
        ToolStripMenuItem4.BackColor = My.Settings.Menu_color
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
        MenuStrip1.Font = My.Settings.Menu_font

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

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        MsgBox(f.ReturnInfoVehicle, MsgBoxStyle.Information)
    End Sub

    Public Sub Adeudo(Matricula As Object, monto As Double)
        Functions.Select_VehiclesMatricula = Matricula
        Adeudos.Matricula = Matricula
        Adeudos.MontoTotal = monto
        Adeudos.Detalles.Text = f.ReturnInfoVehicle()
        Adeudos.LoadTotalButton()
        Functions.Select_VehiclesMatricula = ""
        f.AddForm_Desktop(Adeudos, PanelControl.Desktop)
        Adeudos.WindowState = FormWindowState.Normal
    End Sub
End Class