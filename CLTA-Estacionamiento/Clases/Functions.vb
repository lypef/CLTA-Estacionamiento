Public Class Functions

    Public Sub forms_setmodel(ByVal form As Form)
        'form.Text = ReturnEmpresa_Parametros(Empresa_Nombre) + " - USUARIO: " + ReturnNameID(userID)
        form.Icon = System.Drawing.Icon.FromHandle(My.Resources.Icon.GetHicon())
        form.FormBorderStyle = FormBorderStyle.Sizable
        form.MaximizeBox = False
        form.MaximumSize = New Size(form.Width, form.Height)
        form.MinimumSize = New Size(form.Width, form.Height)
    End Sub

    Public Sub Button_SetModel(ByVal boton As Button, ByVal imagen As Bitmap)
        boton.BackgroundImage = imagen
        boton.Height = My.Resources.bOTONESESTACIONAMIENTO.Height
        boton.Width = My.Resources.bOTONESESTACIONAMIENTO.Width
        boton.FlatStyle = FlatStyle.Flat
        boton.BackgroundImageLayout = ImageLayout.Center
        boton.BackColor = Color.Transparent
        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseDownBackColor = Color.Transparent
        boton.FlatAppearance.MouseOverBackColor = Color.Transparent
        boton.Text = ""
    End Sub

    Public Sub Button_Hover_SetModel(ByVal boton As Button, ByVal imagen As Bitmap)
        boton.BackgroundImage = imagen
        boton.Height = My.Resources.BtnClients_green.Height
        boton.Width = My.Resources.BtnClients_green.Width
        boton.FlatStyle = FlatStyle.Flat
        boton.BackgroundImageLayout = ImageLayout.Center
        boton.BackColor = Color.Transparent
        boton.FlatAppearance.BorderSize = 0
        boton.FlatAppearance.MouseDownBackColor = Color.Transparent
        boton.FlatAppearance.MouseOverBackColor = Color.Transparent
        boton.Text = ""
    End Sub

    Public Function Login(ByVal username As TextBox, ByVal password As TextBox)
        Return True
    End Function
End Class
