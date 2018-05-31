Public Class OpenBarrNum
    Dim f As New Functions

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        accionar()
    End Sub

    Private Sub accionar()
        f.ActionBarr(NumericUpDown1.Value)
        Me.Visible = False
    End Sub

    Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.Enter Then
            accionar()
        End If
    End Sub
End Class