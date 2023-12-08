<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstenos
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
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.btnSeleccionarFuncion = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btnInformacionUsuario = New System.Windows.Forms.Button()
        Me.btnAdministrador = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dvgCartelera = New System.Windows.Forms.DataGridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.cmbGenero = New System.Windows.Forms.ComboBox()
        Me.btnBuscarFiltro = New System.Windows.Forms.Button()
        Me.cmbClasificacion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEstrenos = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCartelera = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel8.SuspendLayout()
        CType(Me.dvgCartelera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.White
        Me.Panel11.Location = New System.Drawing.Point(690, 444)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(235, 5)
        Me.Panel11.TabIndex = 39
        '
        'btnSeleccionarFuncion
        '
        Me.btnSeleccionarFuncion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSeleccionarFuncion.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarFuncion.ForeColor = System.Drawing.Color.White
        Me.btnSeleccionarFuncion.Location = New System.Drawing.Point(690, 422)
        Me.btnSeleccionarFuncion.Name = "btnSeleccionarFuncion"
        Me.btnSeleccionarFuncion.Size = New System.Drawing.Size(235, 27)
        Me.btnSeleccionarFuncion.TabIndex = 40
        Me.btnSeleccionarFuncion.Text = "Reserva de asientos"
        Me.btnSeleccionarFuncion.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Location = New System.Drawing.Point(182, 444)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(235, 5)
        Me.Panel10.TabIndex = 37
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.White
        Me.Panel9.Location = New System.Drawing.Point(15, 444)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(146, 5)
        Me.Panel9.TabIndex = 35
        '
        'btnInformacionUsuario
        '
        Me.btnInformacionUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnInformacionUsuario.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformacionUsuario.ForeColor = System.Drawing.Color.White
        Me.btnInformacionUsuario.Location = New System.Drawing.Point(182, 422)
        Me.btnInformacionUsuario.Name = "btnInformacionUsuario"
        Me.btnInformacionUsuario.Size = New System.Drawing.Size(235, 27)
        Me.btnInformacionUsuario.TabIndex = 38
        Me.btnInformacionUsuario.Text = "Información de usuario"
        Me.btnInformacionUsuario.UseVisualStyleBackColor = False
        '
        'btnAdministrador
        '
        Me.btnAdministrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdministrador.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministrador.ForeColor = System.Drawing.Color.White
        Me.btnAdministrador.Location = New System.Drawing.Point(15, 422)
        Me.btnAdministrador.Name = "btnAdministrador"
        Me.btnAdministrador.Size = New System.Drawing.Size(146, 27)
        Me.btnAdministrador.TabIndex = 36
        Me.btnAdministrador.Text = "Administrador"
        Me.btnAdministrador.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.dvgCartelera)
        Me.Panel8.Location = New System.Drawing.Point(182, 179)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(748, 234)
        Me.Panel8.TabIndex = 49
        '
        'dvgCartelera
        '
        Me.dvgCartelera.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.dvgCartelera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgCartelera.Location = New System.Drawing.Point(3, 3)
        Me.dvgCartelera.Name = "dvgCartelera"
        Me.dvgCartelera.Size = New System.Drawing.Size(740, 228)
        Me.dvgCartelera.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ComboBox1)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Controls.Add(Me.cmbGenero)
        Me.Panel6.Controls.Add(Me.btnBuscarFiltro)
        Me.Panel6.Controls.Add(Me.cmbClasificacion)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(15, 179)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(146, 234)
        Me.Panel6.TabIndex = 48
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 165)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Duración"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.White
        Me.Panel7.Location = New System.Drawing.Point(7, 214)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(121, 5)
        Me.Panel7.TabIndex = 16
        '
        'cmbGenero
        '
        Me.cmbGenero.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.cmbGenero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGenero.FormattingEnabled = True
        Me.cmbGenero.Location = New System.Drawing.Point(7, 109)
        Me.cmbGenero.Name = "cmbGenero"
        Me.cmbGenero.Size = New System.Drawing.Size(121, 21)
        Me.cmbGenero.TabIndex = 5
        '
        'btnBuscarFiltro
        '
        Me.btnBuscarFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscarFiltro.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarFiltro.ForeColor = System.Drawing.Color.White
        Me.btnBuscarFiltro.Location = New System.Drawing.Point(7, 194)
        Me.btnBuscarFiltro.Name = "btnBuscarFiltro"
        Me.btnBuscarFiltro.Size = New System.Drawing.Size(121, 27)
        Me.btnBuscarFiltro.TabIndex = 15
        Me.btnBuscarFiltro.Text = "Buscar funciones"
        Me.btnBuscarFiltro.UseVisualStyleBackColor = False
        '
        'cmbClasificacion
        '
        Me.cmbClasificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.cmbClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbClasificacion.FormattingEnabled = True
        Me.cmbClasificacion.Location = New System.Drawing.Point(7, 52)
        Me.cmbClasificacion.Name = "cmbClasificacion"
        Me.cmbClasificacion.Size = New System.Drawing.Size(121, 21)
        Me.cmbClasificacion.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 19)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Genero"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Clasificación"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Filtros"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Location = New System.Drawing.Point(182, 88)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(748, 73)
        Me.Panel4.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estrenos"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(690, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(235, 11)
        Me.Panel3.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(436, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(235, 11)
        Me.Panel2.TabIndex = 44
        '
        'btnEstrenos
        '
        Me.btnEstrenos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEstrenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEstrenos.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstrenos.ForeColor = System.Drawing.Color.White
        Me.btnEstrenos.Location = New System.Drawing.Point(690, 13)
        Me.btnEstrenos.Name = "btnEstrenos"
        Me.btnEstrenos.Size = New System.Drawing.Size(235, 51)
        Me.btnEstrenos.TabIndex = 46
        Me.btnEstrenos.Text = "Estrenos"
        Me.btnEstrenos.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Location = New System.Drawing.Point(436, 11)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(235, 51)
        Me.btnProductos.TabIndex = 45
        Me.btnProductos.Text = "Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(182, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 11)
        Me.Panel1.TabIndex = 42
        '
        'btnCartelera
        '
        Me.btnCartelera.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCartelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCartelera.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCartelera.ForeColor = System.Drawing.Color.White
        Me.btnCartelera.Location = New System.Drawing.Point(182, 11)
        Me.btnCartelera.Name = "btnCartelera"
        Me.btnCartelera.Size = New System.Drawing.Size(235, 51)
        Me.btnCartelera.TabIndex = 41
        Me.btnCartelera.Text = "Cartelera"
        Me.btnCartelera.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CINEOMAU2._9.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(248, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(422, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "¡Mira estos nuevos lanzamientos!"
        '
        'FrmEstenos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 450)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.btnSeleccionarFuncion)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.btnInformacionUsuario)
        Me.Controls.Add(Me.btnAdministrador)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnEstrenos)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCartelera)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmEstenos"
        Me.Text = "FrmEstenos"
        Me.Panel8.ResumeLayout(False)
        CType(Me.dvgCartelera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel11 As Panel
    Friend WithEvents btnSeleccionarFuncion As Button
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnInformacionUsuario As Button
    Friend WithEvents btnAdministrador As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dvgCartelera As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents cmbGenero As ComboBox
    Friend WithEvents btnBuscarFiltro As Button
    Friend WithEvents cmbClasificacion As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEstrenos As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCartelera As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
