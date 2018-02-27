﻿Public Class VentaDirecta
    Dim f As New Functions
    Dim urlImagen As String
    Dim urlimagenEdit As String
    Dim urlimagenEdit_Edit As String

    Private Sub VentaDirecta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f.forms_setmodel(Me, FormBorderStyle.None)
        MenuStrip1.BackColor = My.Settings.Menu_color
        MenuStrip1.Font = My.Settings.Menu_font
        ToolStripMenuItem4.Font = My.Settings.Menu_font
        TabControl1.Font = My.Settings.Menu_font
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Visible = False
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Generar_Click(sender As Object, e As EventArgs) Handles Generar.Click
        Dim numAleatorio As New Random()
        Dim valorAleatorio As Double = numAleatorio.NextDouble()
        TxtCode.Text = valorAleatorio.ToString.Replace(",", "").Replace(".", "")
    End Sub

    Private Sub Service_CheckedChanged(sender As Object, e As EventArgs) Handles Service.CheckedChanged
        If Service.Checked Then
            Stock.Value = 0
            Stock.Enabled = False
        Else
            Stock.Value = 1
            Stock.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tmp = Functions.OpenFileSetPictureBox(Imagen)
        If String.IsNullOrEmpty(tmp) = False Then
            urlImagen = tmp
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(TxtNombre.Text) = False And String.IsNullOrEmpty(TxtCode.Text) = False And f.IsNumber(TxtPrecio.Text) Then
            If Functions.Products_add(TxtCode, TxtNombre, TxtDescripcion, TxtPrecio, Service, Stock, urlImagen) Then
                f.Alert("Producto agregado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Clean_prodructAdd()
            Else
                f.Alert("Error, verifique sus datos | Verifique sus permisos", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert("Ingrese al menos un Codigo | Verifique sus datos", f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Clean_prodructAdd()
        TxtCode.Text = ""
        TxtNombre.Text = ""
        TxtDescripcion.Text = ""
        TxtPrecio.Text = ""
        Service.Checked = False
        Stock.Value = 0
        Imagen.Image = Nothing
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            If f.GetPermiso(f.Permiso_Vtd_access) Then
                f.GetProducts("SELECT * FROM product_services", Table)
            Else
                f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
                TabControl1.SelectedIndex = 0
            End If

        End If

        If TabControl1.SelectedIndex = 2 Then
            If f.GetPermiso(f.Permiso_Vtd_Add) Then
                Clean_prodructAdd()
            Else
                f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
                TabControl1.SelectedIndex = 0
            End If

        End If

        If TabControl1.SelectedIndex = 3 Then
            If f.GetPermiso(f.Permiso_Vtd_Edit) And String.IsNullOrEmpty(Functions.VTD_Codebar) = False Then
                f.Vtd_LoadValues(TxtCodeBarEdit, TxtNombreEdit, TxtDescripcionEdit, TxtPrecioEdit, ServiceEdit, StockEdit, urlimagenEdit, ImagenEdit, urlimagenEdit_Edit)
            Else
                f.Alert(f.Alert_PermisoNOAutorizado + " | Seleccione un producto", f.Alert_NumberCritical, PanelControl.Desktop)
                TabControl1.SelectedIndex = 0
            End If

        End If
    End Sub

    Private Sub Table_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Table_CellDoubleClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles Table.CellDoubleClick
        If String.IsNullOrEmpty(Table.SelectedCells(0).Value) = False Then
            Functions.VTD_Codebar = Table.SelectedCells(0).Value
            ContextMenuStrip1.Show(MousePosition)
        Else
            f.Alert("Seleccione un item verdadero", f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If (f.GetPermiso(f.Permiso_Vtd_Delete)) Then
            If (MsgBox("¿Esta seguro de eliminar el producto ?", f.Alert_NumberExclamacion + vbYesNo) = vbYes) Then
                If Functions.VTD_Product_DELETE Then
                    f.GetProducts("SELECT * FROM product_services", Table)
                    f.Alert("Vehiculo eliminado con exito", f.Alert_NumberInformacion, PanelControl.Desktop)
                Else
                    f.Alert("El vehiculo no se elimino", f.Alert_NumberCritical, PanelControl.Desktop)
                End If
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberCritical, PanelControl.Desktop)
        End If
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If f.GetPermiso(f.Permiso_Vtd_Edit) Then
            TabControl1.SelectedIndex = 3
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim tmp = Functions.OpenFileSetPictureBox(ImagenEdit)
        If String.IsNullOrEmpty(tmp) = False Then
            urlimagenEdit_Edit = tmp
        End If
    End Sub

    Private Sub ServiceEdit_CheckedChanged(sender As Object, e As EventArgs) Handles ServiceEdit.CheckedChanged
        If ServiceEdit.Checked Then
            StockEdit.Value = 0
            StockEdit.Enabled = False
        Else
            StockEdit.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If f.GetPermiso(f.Permiso_Vtd_Edit) And String.IsNullOrEmpty(TxtNombreEdit.Text) = False And String.IsNullOrEmpty(TxtCodeBarEdit.Text) = False And f.IsNumber(TxtPrecioEdit.Text) Then
            If f.Vtd_Product_Update(TxtCodeBarEdit, TxtNombreEdit, TxtDescripcionEdit, TxtPrecioEdit, ServiceEdit, StockEdit, urlimagenEdit, urlimagenEdit_Edit) Then
                f.Alert("Producto actualizado", f.Alert_NumberInformacion, PanelControl.Desktop)
                TabControl1.SelectedIndex = 1
            Else
                f.Alert("Vehiculo NO actualizado", f.Alert_NumberCritical, PanelControl.Desktop)
            End If
        Else
            f.Alert(f.Alert_PermisoNOAutorizado, f.Alert_NumberExclamacion, PanelControl.Desktop)
        End If
    End Sub

    Private Sub BuscarEnVTDToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub search_Consultas(v As String)
        f.GetProducts("SELECT *  FROM product_services WHERE codebar like '%" + v + "%' or nombre like '%" + v + "%' or descripcion like '%" + v + "%' ", Table)
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 1
            search_Consultas(ToolStripTextBox1.Text)
        End If
    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click
        ToolStripTextBox1.Text = ""
        ToolStripTextBox1.Focus()
    End Sub

    Private Sub ToolStripTextBox1_MouseLeave(sender As Object, e As EventArgs) Handles ToolStripTextBox1.MouseLeave
        ToolStripTextBox1.Text = "Buscar en consultas"
    End Sub

    Private Sub ToolStripTextBox1_MouseHover(sender As Object, e As EventArgs) Handles ToolStripTextBox1.MouseHover
        ToolStripTextBox1.Text = ""
        ToolStripTextBox1.Focus()
    End Sub

    Private Sub ToolStripTextBox2_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox2.Click
        ToolStripTextBox2.Text = ""
        ToolStripTextBox2.Focus()
    End Sub

    Private Sub ToolStripTextBox2_MouseHover(sender As Object, e As EventArgs) Handles ToolStripTextBox2.MouseHover
        ToolStripTextBox2.Text = ""
        ToolStripTextBox2.Focus()
    End Sub

    Private Sub ToolStripTextBox2_MouseLeave(sender As Object, e As EventArgs) Handles ToolStripTextBox2.MouseLeave
        ToolStripTextBox2.Text = "Buscar en VTD"
    End Sub

    Private Sub ToolStripTextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TabControl1.SelectedIndex = 0
            'search_Consultas(ToolStripTextBox1.Text)
        End If
    End Sub
End Class