<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAdministrador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnNuevaFuncion = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNuevaPelicula = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNuevoComestible = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNuevoUsuario = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnNuevoEmpleado = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(103, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administrador"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CINEOMAU2._9.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.White
        Me.Panel19.Location = New System.Drawing.Point(556, 55)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(235, 5)
        Me.Panel19.TabIndex = 127
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Black
        Me.btnRegresar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(556, 35)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(235, 27)
        Me.btnRegresar.TabIndex = 126
        Me.btnRegresar.Text = "Volver a control usuario"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Location = New System.Drawing.Point(12, 157)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(146, 5)
        Me.Panel9.TabIndex = 128
        '
        'btnNuevaFuncion
        '
        Me.btnNuevaFuncion.BackColor = System.Drawing.Color.Black
        Me.btnNuevaFuncion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaFuncion.ForeColor = System.Drawing.Color.White
        Me.btnNuevaFuncion.Location = New System.Drawing.Point(12, 135)
        Me.btnNuevaFuncion.Name = "btnNuevaFuncion"
        Me.btnNuevaFuncion.Size = New System.Drawing.Size(146, 27)
        Me.btnNuevaFuncion.TabIndex = 129
        Me.btnNuevaFuncion.Text = "Control funciones"
        Me.btnNuevaFuncion.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(164, 157)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(146, 5)
        Me.Panel1.TabIndex = 130
        '
        'btnNuevaPelicula
        '
        Me.btnNuevaPelicula.BackColor = System.Drawing.Color.Black
        Me.btnNuevaPelicula.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaPelicula.ForeColor = System.Drawing.Color.White
        Me.btnNuevaPelicula.Location = New System.Drawing.Point(164, 135)
        Me.btnNuevaPelicula.Name = "btnNuevaPelicula"
        Me.btnNuevaPelicula.Size = New System.Drawing.Size(146, 27)
        Me.btnNuevaPelicula.TabIndex = 131
        Me.btnNuevaPelicula.Text = "Control peliculas"
        Me.btnNuevaPelicula.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(316, 157)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(171, 5)
        Me.Panel2.TabIndex = 132
        '
        'btnNuevoComestible
        '
        Me.btnNuevoComestible.BackColor = System.Drawing.Color.Black
        Me.btnNuevoComestible.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoComestible.ForeColor = System.Drawing.Color.White
        Me.btnNuevoComestible.Location = New System.Drawing.Point(316, 135)
        Me.btnNuevoComestible.Name = "btnNuevoComestible"
        Me.btnNuevoComestible.Size = New System.Drawing.Size(171, 27)
        Me.btnNuevoComestible.TabIndex = 133
        Me.btnNuevoComestible.Text = "Control comestibles"
        Me.btnNuevoComestible.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(493, 157)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(146, 5)
        Me.Panel3.TabIndex = 134
        '
        'btnNuevoUsuario
        '
        Me.btnNuevoUsuario.BackColor = System.Drawing.Color.Black
        Me.btnNuevoUsuario.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoUsuario.ForeColor = System.Drawing.Color.White
        Me.btnNuevoUsuario.Location = New System.Drawing.Point(493, 135)
        Me.btnNuevoUsuario.Name = "btnNuevoUsuario"
        Me.btnNuevoUsuario.Size = New System.Drawing.Size(146, 27)
        Me.btnNuevoUsuario.TabIndex = 135
        Me.btnNuevoUsuario.Text = "Control usuario"
        Me.btnNuevoUsuario.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(645, 157)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(146, 5)
        Me.Panel4.TabIndex = 136
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.BackColor = System.Drawing.Color.Black
        Me.btnNuevoEmpleado.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpleado.ForeColor = System.Drawing.Color.White
        Me.btnNuevoEmpleado.Location = New System.Drawing.Point(645, 135)
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.Size = New System.Drawing.Size(146, 27)
        Me.btnNuevoEmpleado.TabIndex = 137
        Me.btnNuevoEmpleado.Text = "Control empleado"
        Me.btnNuevoEmpleado.UseVisualStyleBackColor = False
        '
        'FrmAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(803, 203)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnNuevoEmpleado)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnNuevoUsuario)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnNuevoComestible)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNuevaPelicula)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.btnNuevaFuncion)
        Me.Controls.Add(Me.Panel19)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdministrador"
        Me.Text = "FrmAdministrador"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel19 As Panel
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnNuevaFuncion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNuevaPelicula As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnNuevoComestible As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnNuevoUsuario As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnNuevoEmpleado As Button
End Class
