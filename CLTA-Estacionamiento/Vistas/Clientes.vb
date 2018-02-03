Public Class Clientes
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim URLfoto As String = ""
    Dim URLfoto_edit As String = ""

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me, FormBorderStyle.None)
        MainMenuStrip.BackColor = My.Settings.Menu_color
        TxtSearch.BackColor = My.Settings.Menu_color
        MainMenuStrip.Font = My.Settings.Menu_font
        TxtSearch.Font = My.Settings.Menu_font

        TabPage1.Font = My.Settings.Menu_font
        TabPage2.Font = My.Settings.Menu_font
        TabPage3.Font = My.Settings.Menu_font
        ToolStripMenuItem3.Font = My.Settings.Menu_font
        ToolStripMenuItem2.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        SalirToolStripMenuItem.Font = My.Settings.Menu_font

        TxtName.Font = My.Settings.text_font
        TxtAdress.Font = My.Settings.text_font
        TxtPhone.Font = My.Settings.text_font
        TxtMail.Font = My.Settings.text_font
        TxtRfc.Font = My.Settings.text_font
        TxtRazonSocial.Font = My.Settings.text_font

        Label2.Font = My.Settings.text_font
        Label3.Font = My.Settings.text_font
        Label4.Font = My.Settings.text_font
        Label5.Font = My.Settings.text_font
        Label6.Font = My.Settings.text_font
        Label7.Font = My.Settings.text_font

        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
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

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Client = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Rate_Delete) Then
            If (MsgBox("¿Esta seguro de eliminar el cliente # " + Functions.Client + " ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.Clients_DELETE Then
                    Loader()
                    f.Alert("Cliente eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El cliente no se elimino", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loader()
        ElseIf TabControl1.SelectedIndex = 1 Then
            If String.IsNullOrEmpty(Functions.Client) = False And f.GetPermiso(f.Permiso_Cliet_Edit) Then
                LoaderEdit()
            Else
                TabControl1.SelectedIndex = 0
                f.Alert("Seleccione un cliente | Verifique sus permisos", f.Alert_NumberExclamacion, PanelControl.Desktop)
            End If
        ElseIf TabControl1.SelectedIndex = 2 Then
            If f.GetPermiso(f.Permiso_Cliet_Add) Then
                LimpiarAdd()
            Else
                TabControl1.SelectedIndex = 0
                f.Alert("Verifique sus permisos", f.Alert_NumberExclamacion, PanelControl.Desktop)
            End If
        End If
    End Sub

    Private Sub LoaderEdit()
        f.LoadValuesOneClient(TextBoxNameEdit, TextBoxDireccionEdit, TextBoxTelefonoEdit, TextBoxMailEdit, TextBoxRfcEdit, TextBoxRazonSocialEdit, FotoEdit, URLfoto, URLfoto_edit)
    End Sub

    Private Sub LimpiarAdd()
        TxtName.Text = ""
        TxtAdress.Text = ""
        TxtPhone.Text = ""
        TxtMail.Text = ""
        TxtRfc.Text = ""
        TxtRazonSocial.Text = ""
        Foto.Image = Nothing
        URLfoto = ""

        TextBoxNameEdit.Text = ""
        TextBoxDireccionEdit.Text = ""
        TextBoxTelefonoEdit.Text = ""
        TextBoxMailEdit.Text = ""
        TextBoxRfcEdit.Text = ""
        TextBoxRazonSocialEdit.Text = ""
        FotoEdit.Image = Nothing
        URLfoto = ""
        Functions.Client = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tmp = Functions.OpenFileSetPictureBox(Foto)
        If String.IsNullOrEmpty(tmp) = False Then
            URLfoto = tmp
        End If
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If String.IsNullOrEmpty(TxtName.Text) = False And f.GetPermiso(f.Permiso_Cliet_Add) Then
            If Functions.Clients_add(TxtName, TxtAdress, TxtPhone, TxtMail, TxtRfc, TxtRazonSocial, URLfoto) Then
                f.Alert("Cliente agregado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                LimpiarAdd()
                Functions.Client = ""
            Else
                f.Alert("Error, verifique sus datos | Verifique sus permisos", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert("Ingrese al menos un nombre | Verifique su licencia", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Cliet_Edit) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tmp = Functions.OpenFileSetPictureBox(FotoEdit)
        If String.IsNullOrEmpty(tmp) = False Then
            URLfoto_edit = tmp
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If String.IsNullOrEmpty(TextBoxNameEdit.Text) = False And f.GetPermiso(f.Permiso_Cliet_Edit) Then
            If Functions.Clients_Update(TextBoxNameEdit, TextBoxDireccionEdit, TextBoxTelefonoEdit, TextBoxMailEdit, TextBoxRfcEdit, TextBoxRazonSocialEdit, URLfoto, URLfoto_edit) Then
                f.Alert("Cliente actualizado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                LimpiarAdd()
                Functions.Client = ""
                TabControl1.SelectedIndex = 0
            Else
                f.Alert("Error, verifique sus datos | Verifique sus permisos", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert("Ingrese al menos un nombre | Verifique su licencia", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TxtSearch_Enter(sender As Object, e As EventArgs) Handles TxtSearch.Enter
        TxtSearch.ForeColor = Color.Black
        TxtSearch.Text = Nothing
    End Sub

    Private Sub TxtSearch_Leave(sender As Object, e As EventArgs) Handles TxtSearch.Leave
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
    End Sub

    Private Sub TxtSearch_MouseEnter(sender As Object, e As EventArgs) Handles TxtSearch.MouseEnter
        TxtSearch.ForeColor = Color.Black
        TxtSearch.Text = Nothing
    End Sub

    Private Sub TxtSearch_MouseLeave(sender As Object, e As EventArgs) Handles TxtSearch.MouseLeave
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 0
            f.GetClients("SELECT * FROM clients where name LIKE '%" + TxtSearch.Text + "%' or address LIKE '%" + TxtSearch.Text + "%' or phone LIKE '%" + TxtSearch.Text + "%' OR mail LIKE '%" + TxtSearch.Text + "%' OR rfc LIKE '%" + TxtSearch.Text + "%' OR razonsocial LIKE '%" + TxtSearch.Text + "%' ORDER by name asc", Table)
            Functions.Client = ""
            TxtSearch.Text = ""
        End If
    End Sub

    Public Sub Loader()
        f.GetClients("SELECT * FROM clients ORDER by name asc", Table)
        Functions.Client = ""
    End Sub
End Class