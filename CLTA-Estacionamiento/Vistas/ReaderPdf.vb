Public Class ReaderPdf
    Public url As String = ""

    Public Sub OpenPdf()
        Contenedor.src = url
        Contenedor.Height = Me.Height - MenuStrip1.Height
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub
End Class