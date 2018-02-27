Public Class Vehicles
    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim editar As Boolean = False

    Public Sub Loader()
        editar = False
        f.GetVehicles("SELECT v.matricula, c.name, t.name, v.modelo, v.color, v.estado, v.fecha_salida FROM clients c, vehicles v, tarifas t where v.client = c.id and v.tarifa = t.id ORDER by c.name ASC", Table)
        Functions.Matricula = ""
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

        TabControl1.Font = My.Settings.Menu_font


        TxtRfid.Font = My.Settings.text_font
        LabelRfid.Font = My.Settings.text_font
        TxtRfid.Font = My.Settings.text_font
        LabelRfid.Font = My.Settings.text_font

        TxtRfid_Edit.Font = My.Settings.text_font
        LabelRfid_Edit.Font = My.Settings.text_font
        TxtRfid_Edit.Font = My.Settings.text_font
        LabelRfid_Edit.Font = My.Settings.text_font

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
        ComboBoxTarifa.Font = My.Settings.text_font

        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color
        TxtSearch.Font = My.Settings.Menu_font
        TxtSearch.BackColor = My.Settings.Menu_color
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
            TxtSearch.Text = TxtSearch.Text.Replace("//BUSCAR", "")
            TabControl1.SelectedIndex = 0
            If (f.IsNumber(TxtSearch.Text)) Then
                TxtSearch.Text = (Convert.ToInt32(TxtSearch.Text)).ToString
            End If
            f.GetVehicles("SELECT v.matricula, c.name, t.name, v.modelo, v.color, v.estado, v.fecha_salida FROM clients c, vehicles v, tarifas t where v.client = c.id and v.tarifa = t.id and v.matricula like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and c.name like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.modelo like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.color like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.estado like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and t.name like '%" + TxtSearch.Text + "%' or v.client = c.id and v.tarifa = t.id and v.rfid like '%" + TxtSearch.Text + "%' ORDER by c.name ASC", Table)
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
            If (f.GetPermiso(f.Permiso_Vehicle_Edit) And String.IsNullOrEmpty(Functions.Matricula) = False) Then
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
        f.ComboboxSetTarifas(ComboBoxTarifaEdit)
        f.Vehicle_LoadValues(MatriculaTextBoxEdit, ModeloTextBoxEdit, ColorTextBoxEdit, EstadoTextboxEdit, ComboClientsEdit, ComboBoxTarifaEdit, TxtRfid_Edit)
        f.ComboboxSetIMGClient(ComboClientsEdit, ImageClientEdit)
        editar = True
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboClients.SelectedIndexChanged
        f.ComboboxSetIMGClient(ComboClients, ImageClient)
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If ComboClients.SelectedIndex > 0 And f.GetPermiso(f.Permiso_Vehicle_Add) And ComboBoxTarifa.SelectedIndex > 0 Then
            If String.IsNullOrEmpty(Matricula_Textbox.Text) = False Then
                If f.AddVehicle(ComboClients, Matricula_Textbox, ModeloTextBox, Color_Textbox, Estado_Textbox, ComboBoxTarifa, TxtRfid) Then
                    LimpiarAddVehicles()
                    f.Alert("Vehiculo agregado", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("Vehiculo NO agregado. La matricula podria ya estar agregada", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            Else
                f.Alert("Ingrese una matricula", f.Alert_NumberExclamacion, PanelControl.Desktop)
            End If
        Else
            f.Alert("Seleccione un cliente || Verifique sus permisos || Seleccione una tarifa", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub LimpiarAddVehicles()
        Functions.Matricula = ""
        editar = False
        f.ComboboxSetClients(ComboClients)
        f.ComboboxSetTarifas(ComboBoxTarifa)
        Matricula_Textbox.Text = ""
        ModeloTextBox.Text = ""
        Color_Textbox.Text = ""
        Estado_Textbox.Text = ""
        TxtRfid.Text = ""
    End Sub

    Private Sub ComboClientsEdit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboClientsEdit.SelectedIndexChanged
        If editar Then
            f.ComboboxSetIMGClient(ComboClientsEdit, ImageClientEdit)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboClientsEdit.SelectedIndex > 0 And f.GetPermiso(f.Permiso_Vehicle_Edit) And ComboBoxTarifaEdit.SelectedIndex > 0 Then
            If f.Vehicle_Update(ComboClientsEdit, MatriculaTextBoxEdit, ModeloTextBoxEdit, ColorTextBoxEdit, EstadoTextboxEdit, ComboBoxTarifaEdit, TxtRfid_Edit) Then
                EnterExitControl.Loader()
                f.Alert("Vehiculo actualizado", f.Alert_NumberInformacion, PanelControl.Desktop)
                TabControl1.SelectedIndex = 0
            Else
                f.Alert("Vehiculo NO actualizado", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        End If
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Matricula = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub AsignacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsignacionesToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Assign_Access) Then
            Assignments.Dispose()
            Assignments.loadvalues()
            f.AddForm_Desktop(Assignments, PanelControl.Desktop)
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Vehicles_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
    End Sub

End Class