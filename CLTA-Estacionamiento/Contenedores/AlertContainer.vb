Public Class AlertContainer
    Dim f As New Functions

    Public Sub style(style As Integer)
        If (style = f.Alert_NumberInformacion) Then
            PictureBox1.Image = My.Resources.information_128
        ElseIf (style = f.Alert_NumberCritical) Then
            PictureBox1.Image = My.Resources.critical_128
        ElseIf (style = f.Alert_NumberExclamacion) Then
            PictureBox1.Image = My.Resources.exclamacion_128
        End If
    End Sub

    Private Sub Boton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AlertContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
        TextBoxMensaje.Font = My.Settings.text_font
        MainMenuStrip.BackColor = My.Settings.Menu_color
        MainMenuStrip.Font = My.Settings.Menu_font
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Dispose()
    End Sub

    Private Sub AlertContainer_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub TextBoxMensaje_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxMensaje.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub MenuStrip1_KeyDown(sender As Object, e As KeyEventArgs) Handles MenuStrip1.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub PictureBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles PictureBox1.PreviewKeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub
End Class