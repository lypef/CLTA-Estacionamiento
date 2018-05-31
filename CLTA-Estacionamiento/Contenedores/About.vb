Public NotInheritable Class About
    Dim f As New Functions
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Establezca el título del formulario.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("ACERCA DE {0}", ApplicationTitle)
        ' Inicialice todo el texto mostrado en el cuadro Acerca de.
        ' TODO: personalice la información del ensamblado de la aplicación en el panel "Aplicación" del 
        '    cuadro de diálogo propiedades del proyecto (bajo el menú "Proyecto").
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Versión {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
        Me.TextBoxDescription.Text = My.Application.Info.Description.Replace("%name_enterprise%", My.Settings.local_nombre).Replace("%direccion%", My.Settings.local_direccion).Replace("%rfc%", My.Settings.local_rfc)
        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
        Panel1.Height = My.Settings.Menu_font.Height + 10
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub About_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub TableLayoutPanel_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TableLayoutPanel.PreviewKeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub TextBoxDescription_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBoxDescription.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub OKButton_KeyDown(sender As Object, e As KeyEventArgs) Handles OKButton.KeyDown
        If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.Enter Then
            Me.Dispose()
        End If
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Me.Dispose()
    End Sub
End Class
