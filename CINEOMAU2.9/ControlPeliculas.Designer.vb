<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ControlPeliculas
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
        Me.dvgPeliculas = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTituloPelicula = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDuracionMinutos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.cmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNuevaPelicula = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.dvgPeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dvgPeliculas
        '
        Me.dvgPeliculas.BackgroundColor = System.Drawing.Color.White
        Me.dvgPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgPeliculas.Location = New System.Drawing.Point(11, 95)
        Me.dvgPeliculas.Name = "dvgPeliculas"
        Me.dvgPeliculas.Size = New System.Drawing.Size(586, 176)
        Me.dvgPeliculas.TabIndex = 41
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(86, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(218, 33)
        Me.Label13.TabIndex = 163
        Me.Label13.Text = "Control peliculas"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CINEOMAU2._9.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 162
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Bk", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 29)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Agregar pelicula"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 19)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Título pelicula"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTituloPelicula
        '
        Me.txtTituloPelicula.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtTituloPelicula.Location = New System.Drawing.Point(137, 331)
        Me.txtTituloPelicula.Name = "txtTituloPelicula"
        Me.txtTituloPelicula.Size = New System.Drawing.Size(460, 27)
        Me.txtTituloPelicula.TabIndex = 167
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 373)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 19)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Duración minutos"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDuracionMinutos
        '
        Me.txtDuracionMinutos.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.txtDuracionMinutos.Location = New System.Drawing.Point(154, 365)
        Me.txtDuracionMinutos.Name = "txtDuracionMinutos"
        Me.txtDuracionMinutos.Size = New System.Drawing.Size(443, 27)
        Me.txtDuracionMinutos.TabIndex = 170
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 402)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = "Clasificación"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbGenero
        '
        Me.cmbGenero.BackColor = System.Drawing.Color.White
        Me.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGenero.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.cmbGenero.ForeColor = System.Drawing.Color.Black
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Location = New System.Drawing.Point(78, 434)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(519, 27)
        Me.cmbGenero.TabIndex = 173
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.BackColor = System.Drawing.Color.White
        Me.cmbClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClasificacion.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.cmbClasificacion.ForeColor = System.Drawing.Color.Black
        Me.cmbClasificacion.FormattingEnabled = True
        Me.cmbClasificacion.Location = New System.Drawing.Point(137, 399)
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.Size = New System.Drawing.Size(460, 27)
        Me.cmbClasificacion.TabIndex = 172
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 437)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Genero"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(16, 494)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(581, 5)
        Me.Panel1.TabIndex = 175
        '
        'btnNuevaPelicula
        '
        Me.btnNuevaPelicula.BackColor = System.Drawing.Color.Black
        Me.btnNuevaPelicula.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevaPelicula.ForeColor = System.Drawing.Color.White
        Me.btnNuevaPelicula.Location = New System.Drawing.Point(16, 472)
        Me.btnNuevaPelicula.Name = "btnNuevaPelicula"
        Me.btnNuevaPelicula.Size = New System.Drawing.Size(581, 27)
        Me.btnNuevaPelicula.TabIndex = 176
        Me.btnNuevaPelicula.Text = "Añadir funcón"
        Me.btnNuevaPelicula.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(16, 530)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(581, 5)
        Me.Panel2.TabIndex = 177
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Black
        Me.btnRegresar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(16, 508)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(581, 27)
        Me.btnRegresar.TabIndex = 178
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'ControlPeliculas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(609, 547)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNuevaPelicula)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbGenero)
        Me.Controls.Add(Me.cmbClasificacion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDuracionMinutos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTituloPelicula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dvgPeliculas)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "ControlPeliculas"
        Me.Text = "ControlPeliculas"
        CType(Me.dvgPeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dvgPeliculas As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTituloPelicula As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDuracionMinutos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents cmbClasificacion As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNuevaPelicula As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRegresar As Button
End Class
