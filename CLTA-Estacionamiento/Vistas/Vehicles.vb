Public Class Vehicles
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim editar As Boolean = False

    Public Sub Loader()
        editar = False
        f.GetVehicles("SELECT v.matricula, c.name, v.modelo, v.color, v.estado FROM clients c, vehicles v where v.client = c.id ORDER by c.name ASC", Table)
        Functions.Vehicle = ""
    End Sub

    Private Sub Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me, FormBorderStyle.None)
        MenuStrip1.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        ToolStripMenuItem3.Font = My.Settings.Menu_font
        ToolStripMenuItem2.Font = My.Settings.Menu_font
        SalirToolStripMenuItem.Font = My.Settings.Menu_font
        TxtSearch.Font = My.Settings.Menu_font
        TxtSearch.ForeColor = Color.Gray
        TxtSearch.Text = "//BUSCAR"
        Label1.Font = My.Settings.Menu_font
        Label1.BackColor = My.Settings.Menu_color

        TabControl1.Font = My.Settings.Menu_font

        Matricula_Textbox.Font = My.Settings.text_font
        Matricula_label.Font = My.Settings.text_font
        MatriculaTextBoxEdit.Font = My.Settings.text_font
        MatriculaLabelEdit.Font = My.Settings.text_font

        ModeloTextBox.Font = My.Settings.text_font
        ModeloLabel.Font = My.Settings.text_font
        ModeloTextBoxEdit.Font = My.Settings.text_font
        ModeloLabelEdit.Font = My.Settings.text_font

        Color_Textbox.Font = My.Settings.text_font
        Color_label.Font = My.Settings.text_font
        ColorTextBoxEdit.Font = My.Settings.text_font
        ColorLabelEdit.Font = My.Settings.text_font

        Estado_Textbox.Font = My.Settings.text_font
        Estado_Label.Font = My.Settings.text_font
        EstadoTextboxEdit.Font = My.Settings.text_font
        EstadoLabelEdit.Font = My.Settings.text_font
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub Vehicles_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Vehicles_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
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
            f.GetVehicles("SELECT v.matricula, c.name, v.modelo, v.color, v.estado FROM clients c, vehicles v where v.client = c.id and v.matricula like '%" + TxtSearch.Text + "%' or v.client = c.id and c.name like '%" + TxtSearch.Text + "%' or v.client = c.id and v.modelo like '%" + TxtSearch.Text + "%' or v.client = c.id and v.color like '%" + TxtSearch.Text + "%' or v.client = c.id and v.estado like '%" + TxtSearch.Text + "%' ORDER by c.name ASC", Table)
            TxtSearch.Text = ""
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If (f.GetPermiso(f.Permiso_Vehicle_Edit)) Then
            TabControl1.SelectedIndex = 1
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If (f.GetPermiso(f.Permiso_Vehicle_Delete)) Then
            If (MsgBox("¿Esta seguro de eliminar el vehiculo ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.Vehicles_DELETE Then
                    Loader()
                    f.Alert("Vehiculo eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El vehiculo no se elimino", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loader()
        ElseIf TabControl1.SelectedIndex = 1 Then
            If (f.GetPermiso(f.Permiso_Vehicle_Edit) And String.IsNullOrEmpty(Functions.Vehicle) = False) Then
                LoadEdit()
            Else
                f.Alert("Seleccione un vehiculo | Verifique sus permisos", f.Alert_NumberExclamacion, PanelControl.Desktop)
                TabControl1.SelectedIndex = 0
            End If
        ElseIf TabControl1.SelectedIndex = 2 Then
            If f.GetPermiso(f.Permiso_Vehicle_Add) Then
                LimpiarAddVehicles()
            Else
                TabControl1.SelectedIndex = 0
                f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        End If
    End Sub

    Private Sub LoadEdit()
        f.ComboboxSetClients(ComboClientsEdit)
        f.Vehicle_LoadValues(MatriculaTextBoxEdit, ModeloTextBoxEdit, ColorTextBoxEdit, EstadoTextboxEdit, ComboClientsEdit)
        f.ComboboxSetIMGClient(ComboClientsEdit, ImageClientEdit)
        editar = True
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboClients.SelectedIndexChanged
        f.ComboboxSetIMGClient(ComboClients, ImageClient)
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If ComboClients.SelectedIndex > 0 And f.GetPermiso(f.Permiso_Vehicle_Add) Then
            If String.IsNullOrEmpty(Matricula_Textbox.Text) = False Then
                If f.AddVehicle(ComboClients, Matricula_Textbox, ModeloTextBox, Color_Textbox, Estado_Textbox) Then
                    LimpiarAddVehicles()
                    f.Alert("Vehiculo agregado", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("Vehiculo NO agregado. La matricula podria ya estar agregada", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            Else
                f.Alert("Ingrese una matricula", f.Alert_NumberExclamacion, PanelControl.Desktop)
            End If
        Else
            f.Alert("Seleccione un cliente || Verifique sus permisos", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub LimpiarAddVehicles()
        Functions.Vehicle = ""
        editar = False
        f.ComboboxSetClients(ComboClients)
        Matricula_Textbox.Text = ""
        ModeloTextBox.Text = ""
        Color_Textbox.Text = ""
        Estado_Textbox.Text = ""
    End Sub

    Private Sub ComboClientsEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboClientsEdit.SelectedIndexChanged
        If editar Then
            f.ComboboxSetIMGClient(ComboClientsEdit, ImageClientEdit)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboClientsEdit.SelectedIndex > 0 And f.GetPermiso(f.Permiso_Vehicle_Edit) Then
            If f.Vehicle_Update(ComboClientsEdit, MatriculaTextBoxEdit, ModeloTextBoxEdit, ColorTextBoxEdit, EstadoTextboxEdit) Then
                f.Alert("Vehiculo actualizado", f.Alert_NumberInformacion, PanelControl.Desktop)
                TabControl1.SelectedIndex = 0
            Else
                f.Alert("Vehiculo NO actualizado", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        End If
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Vehicle = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Vehicles_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

End Class