<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBoleto
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnImprimirBoleto = New System.Windows.Forms.Button()
        Me.lblFuncion = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.QR = New System.Windows.Forms.PictureBox()
        Me.lblPelicula = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblGenero = New System.Windows.Forms.Label()
        Me.lblClasificacion = New System.Windows.Forms.Label()
        Me.lblCantidadAsientos = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblSala = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(39, 414)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 5)
        Me.Panel1.TabIndex = 148
        '
        'btnImprimirBoleto
        '
        Me.btnImprimirBoleto.BackColor = System.Drawing.Color.Transparent
        Me.btnImprimirBoleto.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirBoleto.ForeColor = System.Drawing.Color.Black
        Me.btnImprimirBoleto.Location = New System.Drawing.Point(39, 392)
        Me.btnImprimirBoleto.Name = "btnImprimirBoleto"
        Me.btnImprimirBoleto.Size = New System.Drawing.Size(251, 27)
        Me.btnImprimirBoleto.TabIndex = 149
        Me.btnImprimirBoleto.Text = "Imprimir boleto"
        Me.btnImprimirBoleto.UseVisualStyleBackColor = False
        '
        'lblFuncion
        '
        Me.lblFuncion.AutoSize = True
        Me.lblFuncion.BackColor = System.Drawing.Color.Transparent
        Me.lblFuncion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFuncion.ForeColor = System.Drawing.Color.Black
        Me.lblFuncion.Location = New System.Drawing.Point(12, 175)
        Me.lblFuncion.Name = "lblFuncion"
        Me.lblFuncion.Size = New System.Drawing.Size(74, 19)
        Me.lblFuncion.TabIndex = 150
        Me.lblFuncion.Text = "Función: "
        Me.lblFuncion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CINEOMAU2._9.My.Resources.Resources.LOGO2
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'QR
        '
        Me.QR.Location = New System.Drawing.Point(167, 11)
        Me.QR.Name = "QR"
        Me.QR.Size = New System.Drawing.Size(150, 150)
        Me.QR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.QR.TabIndex = 152
        Me.QR.TabStop = False
        '
        'lblPelicula
        '
        Me.lblPelicula.AutoSize = True
        Me.lblPelicula.BackColor = System.Drawing.Color.Transparent
        Me.lblPelicula.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPelicula.ForeColor = System.Drawing.Color.Black
        Me.lblPelicula.Location = New System.Drawing.Point(12, 204)
        Me.lblPelicula.Name = "lblPelicula"
        Me.lblPelicula.Size = New System.Drawing.Size(69, 19)
        Me.lblPelicula.TabIndex = 153
        Me.lblPelicula.Text = "Pelicula:"
        Me.lblPelicula.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDuracion
        '
        Me.lblDuracion.AutoSize = True
        Me.lblDuracion.BackColor = System.Drawing.Color.Transparent
        Me.lblDuracion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuracion.ForeColor = System.Drawing.Color.Black
        Me.lblDuracion.Location = New System.Drawing.Point(12, 252)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(78, 19)
        Me.lblDuracion.TabIndex = 154
        Me.lblDuracion.Text = "Duración:"
        Me.lblDuracion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGenero
        '
        Me.lblGenero.AutoSize = True
        Me.lblGenero.BackColor = System.Drawing.Color.Transparent
        Me.lblGenero.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenero.ForeColor = System.Drawing.Color.Black
        Me.lblGenero.Location = New System.Drawing.Point(12, 228)
        Me.lblGenero.Name = "lblGenero"
        Me.lblGenero.Size = New System.Drawing.Size(64, 19)
        Me.lblGenero.TabIndex = 155
        Me.lblGenero.Text = "Genero:"
        Me.lblGenero.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblClasificacion
        '
        Me.lblClasificacion.AutoSize = True
        Me.lblClasificacion.BackColor = System.Drawing.Color.Transparent
        Me.lblClasificacion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClasificacion.ForeColor = System.Drawing.Color.Black
        Me.lblClasificacion.Location = New System.Drawing.Point(12, 277)
        Me.lblClasificacion.Name = "lblClasificacion"
        Me.lblClasificacion.Size = New System.Drawing.Size(104, 19)
        Me.lblClasificacion.TabIndex = 156
        Me.lblClasificacion.Text = "Clasificación:"
        Me.lblClasificacion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCantidadAsientos
        '
        Me.lblCantidadAsientos.AutoSize = True
        Me.lblCantidadAsientos.BackColor = System.Drawing.Color.Transparent
        Me.lblCantidadAsientos.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidadAsientos.ForeColor = System.Drawing.Color.Black
        Me.lblCantidadAsientos.Location = New System.Drawing.Point(12, 300)
        Me.lblCantidadAsientos.Name = "lblCantidadAsientos"
        Me.lblCantidadAsientos.Size = New System.Drawing.Size(141, 19)
        Me.lblCantidadAsientos.TabIndex = 157
        Me.lblCantidadAsientos.Text = "Cantidad asientos:"
        Me.lblCantidadAsientos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(39, 452)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(251, 5)
        Me.Panel2.TabIndex = 150
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Black
        Me.btnSalir.Location = New System.Drawing.Point(39, 430)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(251, 27)
        Me.btnSalir.TabIndex = 151
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.BackColor = System.Drawing.Color.Transparent
        Me.lblHora.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.ForeColor = System.Drawing.Color.Black
        Me.lblHora.Location = New System.Drawing.Point(12, 328)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(48, 19)
        Me.lblHora.TabIndex = 158
        Me.lblHora.Text = "Hora:"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSala
        '
        Me.lblSala.AutoSize = True
        Me.lblSala.BackColor = System.Drawing.Color.Transparent
        Me.lblSala.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSala.ForeColor = System.Drawing.Color.Black
        Me.lblSala.Location = New System.Drawing.Point(12, 356)
        Me.lblSala.Name = "lblSala"
        Me.lblSala.Size = New System.Drawing.Size(45, 19)
        Me.lblSala.TabIndex = 159
        Me.lblSala.Text = "Sala:"
        Me.lblSala.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmBoleto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(329, 461)
        Me.Controls.Add(Me.lblSala)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblCantidadAsientos)
        Me.Controls.Add(Me.lblClasificacion)
        Me.Controls.Add(Me.lblGenero)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.lblPelicula)
        Me.Controls.Add(Me.QR)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFuncion)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnImprimirBoleto)
        Me.Name = "FrmBoleto"
        Me.Text = "FrmBoleto"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnImprimirBoleto As Button
    Friend WithEvents lblFuncion As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents QR As PictureBox
    Friend WithEvents lblPelicula As Label
    Friend WithEvents lblDuracion As Label
    Friend WithEvents lblGenero As Label
    Friend WithEvents lblClasificacion As Label
    Friend WithEvents lblCantidadAsientos As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblHora As Label
    Friend WithEvents lblSala As Label
End Class
