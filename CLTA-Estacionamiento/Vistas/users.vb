Public Class users
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub users_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub users_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub users_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuStrip1.BackColor = My.Settings.Menu_color
        TxtSearch.BackColor = My.Settings.Menu_color
        MenuStrip1.Font = My.Settings.Menu_font
        TxtSearch.Font = My.Settings.Menu_font
        TabControl1.BackColor = My.Settings.Menu_color
        TabControl1.Font = My.Settings.Menu_font
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                If f.GetPermiso(f.Permiso_User_Add) Then
                    CleanADD()
                Else
                    TabControl1.SelectedIndex = 1
                    f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            Case 1
                f.GetUsers("SELECT * FROM users", Tabla)
                CleanADD()
            Case 2
                If String.IsNullOrEmpty(Functions.User) Then
                    TabControl1.SelectedIndex = 1
                    f.Alert("Seleccione un usuario", f.Alert_NumberExclamacion, PanelControl.Desktop)
                Else
                    LoadEdit()
                End If
        End Select
    End Sub

    Private Sub CleanADD()
        TxtNombre.Text = ""
        TxtUsername.Text = ""
        TxtPassword.Text = ""
        TxtPasswordConfirm.Text = ""
        TxtNombreEdit.Text = ""
        TxtUsernameEdit.Text = ""
        TxtPasswordEdit.Text = ""
        TxtPasswordConfirmEdit.Text = ""
        For i As Integer = 0 To ListPermisos.Items.Count - 1
            ListPermisos.SetItemChecked(i, False)
        Next i
        For i As Integer = 0 To ListPermisosEdit.Items.Count - 1
            ListPermisosEdit.SetItemChecked(i, False)
        Next i
        Functions.User = ""
    End Sub

    Private Sub Tabla_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tabla.CellDoubleClick
        If String.IsNullOrEmpty(Tabla.SelectedCells(0).Value) = False Then
            Functions.User = Tabla.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Public Sub Loader()
        TabControl1.SelectedIndex = 1
        f.GetUsers("SELECT * FROM users", Tabla)
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        TabControl1.SelectedIndex = 2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Integer = 0 To ListPermisos.Items.Count - 1
            ListPermisos.SetItemChecked(i, True)
        Next i
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For i As Integer = 0 To ListPermisos.Items.Count - 1
            ListPermisos.SetItemChecked(i, False)
        Next i
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtPassword.Text = TxtPasswordConfirm.Text Then
            If f.AddUser(TxtNombre, TxtUsername, TxtPassword) Then
                If f.AddUser_permisos(f.GetLastUser, ListPermisos) Then
                    CleanADD()
                    f.Alert("Usuario agregado", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El usuario se agrego pero los permisos no. Verifiquelos", f.Alert_NumberExclamacion, PanelControl.Desktop)
                End If
            Else
                f.Alert("El usuario no se agrego", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert("Las contraseñas no coinciden", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_User_Delete) Then
            If (MsgBox("¿Esta seguro de eliminar el usuario ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.User_DELETE Then
                    Loader()
                    f.Alert("Usuario eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El usuario no se elimino", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For i As Integer = 0 To ListPermisos.Items.Count - 1
            ListPermisosEdit.SetItemChecked(i, True)
        Next i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For i As Integer = 0 To ListPermisos.Items.Count - 1
            ListPermisosEdit.SetItemChecked(i, False)
        Next i
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TxtPasswordEdit.Text = TxtPasswordConfirmEdit.Text Then
            If f.UpdateUser(TxtNombreEdit, TxtUsernameEdit, TxtPasswordEdit) Then
                If f.UpdateUser_permisos(ListPermisosEdit) Then
                    CleanADD()
                    TabControl1.SelectedIndex = 1
                    f.Alert("Usuario actualizado", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El usuario se agrego pero los permisos no. Verifiquelos", f.Alert_NumberExclamacion, PanelControl.Desktop)
                End If
            Else
                    f.Alert("El usuario no se agrego", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert("Las contraseñas no coinciden", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Public Sub LoadEdit()
        f.LoadValuesUser(TxtNombreEdit, TxtUsernameEdit, ListPermisosEdit)
    End Sub
End Class