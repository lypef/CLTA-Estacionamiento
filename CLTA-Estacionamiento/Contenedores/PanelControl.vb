Public Class PanelControl
    Dim f As New Functions
    Private Sub PanelControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
    End Sub

    Private Sub MinimizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimizarToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿Desea salir?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
            Application.Exit()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        f.AddForm_Desktop(About, Desktop)
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click
        f.AddForm_Desktop(Clientes, Desktop)
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Desktop.Controls.Clear()
    End Sub
End Class