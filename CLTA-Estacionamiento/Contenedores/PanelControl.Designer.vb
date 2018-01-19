<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelControl
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnClientes
        '
        Me.BtnClientes.BackgroundImage = Global.CLTA_Estacionamiento.My.Resources.Resources.BtnClients_yellow
        Me.BtnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.Location = New System.Drawing.Point(12, 12)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(181, 239)
        Me.BtnClientes.TabIndex = 0
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'PanelControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 429)
        Me.Controls.Add(Me.BtnClientes)
        Me.Name = "PanelControl"
        Me.Text = "PanelControl"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnClientes As Button
End Class
