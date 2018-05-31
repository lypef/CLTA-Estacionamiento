Public Class R_ticket
    Dim f As New Functions
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Action()
    End Sub

    Private Sub Action()
        f.TicketGeneratePrint(NumericUpDown1.Value)
        Me.Visible = False
    End Sub

    Private Sub NumericUpDown1_KeyDown(sender As Object, e As KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Action()
        End If
    End Sub
End Class