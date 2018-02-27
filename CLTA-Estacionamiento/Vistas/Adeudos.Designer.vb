<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adeudos
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Detalles = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(260, 45)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Cobrar y permitir salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Detalles
        '
        Me.Detalles.Location = New System.Drawing.Point(12, 13)
        Me.Detalles.Multiline = True
        Me.Detalles.Name = "Detalles"
        Me.Detalles.ReadOnly = True
        Me.Detalles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Detalles.Size = New System.Drawing.Size(260, 149)
        Me.Detalles.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 168)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(260, 45)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Adeudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Detalles)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Adeudos"
        Me.Text = "Adeudos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Detalles As TextBox
    Public WithEvents Button1 As Button
    Public WithEvents Button2 As Button
End Class
