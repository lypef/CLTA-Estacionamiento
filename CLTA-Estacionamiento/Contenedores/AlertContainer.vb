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

    Private Sub Boton_Click(sender As Object, e As EventArgs) Handles Boton.Click
        Me.Dispose()
    End Sub

    Private Sub AlertContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
    End Sub
End Class