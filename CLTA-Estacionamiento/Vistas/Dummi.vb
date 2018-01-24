Public Class Clientes
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me)
    End Sub

    Private Sub MinimizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Me.WindowState = FormWindowState.Maximized
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


End Class