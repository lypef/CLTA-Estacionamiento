<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlertContainer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlertContainer))
        Me.Boton = New System.Windows.Forms.Button()
        Me.TextBoxMensaje = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boton
        '
        Me.Boton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Boton.Location = New System.Drawing.Point(134, 118)
        Me.Boton.Name = "Boton"
        Me.Boton.Size = New System.Drawing.Size(288, 29)
        Me.Boton.TabIndex = 6
        Me.Boton.Text = "Aceptar"
        Me.Boton.UseVisualStyleBackColor = True
        '
        'TextBoxMensaje
        '
        Me.TextBoxMensaje.Location = New System.Drawing.Point(134, 0)
        Me.TextBoxMensaje.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxMensaje.Multiline = True
        Me.TextBoxMensaje.Name = "TextBoxMensaje"
        Me.TextBoxMensaje.ReadOnly = True
        Me.TextBoxMensaje.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMensaje.Size = New System.Drawing.Size(288, 112)
        Me.TextBoxMensaje.TabIndex = 4
        Me.TextBoxMensaje.TabStop = False
        Me.TextBoxMensaje.Text = resources.GetString("TextBoxMensaje.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.CLTA_Estacionamiento.My.Resources.Resources.information_128
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 147)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'AlertContainer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 147)
        Me.Controls.Add(Me.Boton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBoxMensaje)
        Me.Name = "AlertContainer"
        Me.Text = "AlertContainer"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Boton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents TextBoxMensaje As TextBox
End Class
