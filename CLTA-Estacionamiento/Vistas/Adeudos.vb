Public Class Adeudos
    Dim f As New Functions
    Public Matricula As String
    Public MontoTotal As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        f.Vehicle_ChangeStatus(Matricula, 0)
        EnterExitControl.Loader()
        Me.Dispose()
    End Sub

    Private Sub Adeudos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Detalles.Font = My.Settings.text_font
        Button1.Font = My.Settings.Menu_font
    End Sub

    Public Sub LoadTotalButton()
        Button1.Text = "COBRAR $: " + MontoTotal.ToString + " " + My.Settings.moneda
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class