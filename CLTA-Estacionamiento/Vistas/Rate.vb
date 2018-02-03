Public Class Rate

    Dim f As New Functions
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Dim editar As Boolean = False

    Private Sub Rate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        editar = False
        MenuStrip1.Font = My.Settings.Menu_font
        MenuStrip1.BackColor = My.Settings.Menu_color

        TxtSearch.BackColor = My.Settings.Menu_color
        TxtSearch.Font = My.Settings.Menu_font

        ToolStripMenuItem.Font = My.Settings.Menu_font
        ToolStripMenuItem2.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        ToolStripMenuItem3.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        TabControl1.Font = My.Settings.text_font
        TxtSearch.Text = "//BUSCAR"

        LabelTarifaPension.Font = My.Settings.text_font
        TxtTarifaPension.Font = My.Settings.text_font
        LabelTarifaPensionEdit.Font = My.Settings.text_font
        TxtTarifaPensionEdit.Font = My.Settings.text_font

        LabelDiasPendion.Font = My.Settings.text_font
        LabelDiasPendion.Font = My.Settings.text_font
        LabelTarifaDiasEdit.Font = My.Settings.text_font
        TxtTarifaDiasEdit.Font = My.Settings.text_font

        LabelName.Font = My.Settings.text_font
        TxtName.Font = My.Settings.text_font


        LabelName.Font = My.Settings.text_font
        TxtName.Font = My.Settings.text_font
        LabelNombreEdit.Font = My.Settings.text_font
        TxtNombreEdit.Font = My.Settings.text_font

        LabelMinTolerancia.Font = My.Settings.text_font
        TxtMinTolerancia.Font = My.Settings.text_font
        LabelMinToleEdit.Font = My.Settings.text_font
        TxtMinToleEdit.Font = My.Settings.text_font

        LabelCostoMinimo.Font = My.Settings.text_font
        TxtCostoMinimo.Font = My.Settings.text_font
        LabelCostoMinEdit.Font = My.Settings.text_font
        TxtCostoMinEdit.Font = My.Settings.text_font

        LabelPrcieXHora.Font = My.Settings.text_font
        TxtPrcieXHora.Font = My.Settings.text_font
        LabelPrecioHoraEdit.Font = My.Settings.text_font
        TxtPrecioHoraEdit.Font = My.Settings.text_font

        LabelPrcieXDia.Font = My.Settings.text_font
        TxtPrcieXDia.Font = My.Settings.text_font
        LabelPrecioDiaEdit.Font = My.Settings.text_font
        TxtPrecioDiaEdit.Font = My.Settings.text_font

        UsarFracciones.Font = My.Settings.text_font
        UseFraccionesEdit.Font = My.Settings.text_font
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

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub Rate_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub

    Private Sub Rate_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastre Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
        End If
    End Sub

    Private Sub Rate_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Arrastre = False
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
            f.GetTarifas("SELECT * FROM tarifas where name LIKE '%" + TxtSearch.Text + "%' ORDER by name asc", Table)
            Functions.Tarifa = ""
            TxtSearch.Text = ""
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

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 0 Then
            Loader()
        ElseIf TabControl1.SelectedIndex = 1 Then
            Edit()
        ElseIf TabControl1.SelectedIndex = 2 Then
            Agregar()
        End If
    End Sub

    Private Sub Edit()
        If f.GetPermiso(f.Permiso_Rate_Edit) And String.IsNullOrEmpty(Functions.Tarifa) = False Then
            LoadValuesEdit()
        Else
            TabControl1.SelectedIndex = 0
            f.Alert(f.Alert_PermisoNOAutorizado + " || Seleccione una tarifa", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub LoadValuesEdit()
        TabControl1.SelectedIndex = 1
        f.Tarifa_LoadValues(TxtNombreEdit, TxtMinToleEdit, TxtCostoMinEdit, TxtPrecioHoraEdit, TxtPrecioDiaEdit, UseFraccionesEdit, TxtTarifaPensionEdit, TxtTarifaDiasEdit)
    End Sub

    Private Sub Agregar()
        If f.GetPermiso(f.Permiso_Rate_Add) Then
            LimpiarAddTarifa()
        Else
            TabControl1.SelectedIndex = 0
            f.Alert(f.Alert_PermisoNOAutorizado + " || Seleccione una tarifa", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.Tarifa = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un cliente verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Rate_Delete) Then
            If (MsgBox("¿ Eliminar esta tarifa ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.Rate_DELETE Then
                    Loader()
                    f.Alert("Tarifa eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("Tarifa no se elimino || Algun vehiculo puede estar usandola", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Edit()
    End Sub

    Private Sub Add_Click(sender As Object, e As EventArgs) Handles Add.Click
        If f.GetPermiso(f.Permiso_Rate_Add) And String.IsNullOrEmpty(TxtName.Text) = False And f.IsNumber(TxtPrcieXHora.Text) And f.IsNumber(TxtPrcieXDia.Text) And f.IsNumber(TxtTarifaPension.Text) And f.IsNumber(TxtDiasPendion.Text) Then
            If f.AddVehicle(TxtName, TxtMinTolerancia, TxtCostoMinimo, TxtPrcieXHora, TxtPrcieXDia, UsarFracciones, TxtTarifaPension, TxtDiasPendion) Then
                LimpiarAddTarifa()
                f.Alert("Tarifa agregada", f.Alert_NumberInformacion, PanelControl.Desktop)
            Else
                f.Alert("Tarifa NO agregada.", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert("Verifique precios || Verifique sus permisos", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub LimpiarAddTarifa()
        TxtName.Text = ""
        TxtMinTolerancia.Text = ""
        TxtCostoMinimo.Text = ""
        TxtPrcieXHora.Text = ""
        TxtPrcieXDia.Text = ""
        UsarFracciones.Checked = False
        Functions.Tarifa = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If f.GetPermiso(f.Permiso_Rate_Edit) And String.IsNullOrEmpty(TxtNombreEdit.Text) = False And f.IsNumber(TxtPrecioHoraEdit.Text) And f.IsNumber(TxtPrecioDiaEdit.Text) And f.IsNumber(TxtTarifaPensionEdit.Text) And f.IsNumber(TxtTarifaDiasEdit.Text) Then
            If f.UpdateRate(TxtNombreEdit, TxtMinToleEdit, TxtCostoMinEdit, TxtPrecioHoraEdit, TxtPrecioDiaEdit, UseFraccionesEdit, TxtTarifaPensionEdit, TxtTarifaDiasEdit) Then
                LimpiarEditTarifa()
                TabControl1.SelectedIndex = 0
                f.Alert("Tarifa actualizada", f.Alert_NumberInformacion, PanelControl.Desktop)
            Else
                f.Alert("Tarifa NO actualizada.", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert("Verifique precios || Verifique sus permisos", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub LimpiarEditTarifa()
        TxtNombreEdit.Text = ""
        TxtMinToleEdit.Text = ""
        TxtCostoMinEdit.Text = ""
        TxtPrecioHoraEdit.Text = ""
        TxtPrecioDiaEdit.Text = ""
        UseFraccionesEdit.Checked = False
    End Sub

    Public Sub Loader()
        f.GetTarifas("SELECT * FROM tarifas ORDER by name asc", Table)
        Functions.Tarifa = ""
    End Sub
End Class