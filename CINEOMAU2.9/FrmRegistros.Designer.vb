<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistros
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
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtcontraseña = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtNumeroTelefono = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.gpbSexo = New System.Windows.Forms.GroupBox()
        Me.rdbOtro = New System.Windows.Forms.RadioButton()
        Me.rdbFemenino = New System.Windows.Forms.RadioButton()
        Me.rdbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCorreoelectronico = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gpbSexo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnRegistrar)
        Me.Panel1.Controls.Add(Me.txtcontraseña)
        Me.Panel1.Controls.Add(Me.Label23)
        Me.Panel1.Controls.Add(Me.txtPais)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.txtEstado)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.txtCiudad)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.txtDireccion)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.txtNumeroTelefono)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.dtpFechaNacimiento)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.gpbSexo)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtCorreoelectronico)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.txtSegundoApellido)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtPrimerApellido)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(98, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 1055)
        Me.Panel1.TabIndex = 24
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Roboto Cn", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegistrar.Location = New System.Drawing.Point(98, 995)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(301, 44)
        Me.btnRegistrar.TabIndex = 24
        Me.btnRegistrar.Text = "REGISTRARME"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtcontraseña
        '
        Me.txtcontraseña.Location = New System.Drawing.Point(18, 944)
        Me.txtcontraseña.MaxLength = 10
        Me.txtcontraseña.Name = "txtcontraseña"
        Me.txtcontraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontraseña.Size = New System.Drawing.Size(471, 30)
        Me.txtcontraseña.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(17, 917)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 23)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Contraseña"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(18, 859)
        Me.txtPais.MaxLength = 10
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(471, 30)
        Me.txtPais.TabIndex = 21
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(17, 832)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(47, 23)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "País"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(15, 779)
        Me.txtEstado.MaxLength = 10
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(471, 30)
        Me.txtEstado.TabIndex = 19
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(14, 752)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(68, 23)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Estado"
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(15, 706)
        Me.txtCiudad.MaxLength = 10
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(471, 30)
        Me.txtCiudad.TabIndex = 17
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(14, 679)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 23)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Ciudad"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(15, 619)
        Me.txtDireccion.MaxLength = 10
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(471, 30)
        Me.txtDireccion.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label19.Location = New System.Drawing.Point(14, 595)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(92, 23)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Dirección"
        '
        'txtNumeroTelefono
        '
        Me.txtNumeroTelefono.Location = New System.Drawing.Point(15, 542)
        Me.txtNumeroTelefono.MaxLength = 10
        Me.txtNumeroTelefono.Name = "txtNumeroTelefono"
        Me.txtNumeroTelefono.Size = New System.Drawing.Size(471, 30)
        Me.txtNumeroTelefono.TabIndex = 13
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label18.Location = New System.Drawing.Point(14, 516)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 23)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "No. telefóno"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.CalendarForeColor = System.Drawing.Color.Teal
        Me.dtpFechaNacimiento.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dtpFechaNacimiento.CalendarTrailingForeColor = System.Drawing.Color.Teal
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(15, 466)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(200, 30)
        Me.dtpFechaNacimiento.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(14, 440)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(188, 23)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Fecha de nacimineto"
        '
        'gpbSexo
        '
        Me.gpbSexo.BackColor = System.Drawing.Color.Transparent
        Me.gpbSexo.Controls.Add(Me.rdbOtro)
        Me.gpbSexo.Controls.Add(Me.rdbFemenino)
        Me.gpbSexo.Controls.Add(Me.rdbMasculino)
        Me.gpbSexo.Location = New System.Drawing.Point(18, 355)
        Me.gpbSexo.Name = "gpbSexo"
        Me.gpbSexo.Size = New System.Drawing.Size(468, 55)
        Me.gpbSexo.TabIndex = 9
        Me.gpbSexo.TabStop = False
        '
        'rdbOtro
        '
        Me.rdbOtro.AutoSize = True
        Me.rdbOtro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdbOtro.Location = New System.Drawing.Point(363, 22)
        Me.rdbOtro.Name = "rdbOtro"
        Me.rdbOtro.Size = New System.Drawing.Size(65, 27)
        Me.rdbOtro.TabIndex = 2
        Me.rdbOtro.TabStop = True
        Me.rdbOtro.Text = "Otro"
        Me.rdbOtro.UseVisualStyleBackColor = True
        '
        'rdbFemenino
        '
        Me.rdbFemenino.AutoSize = True
        Me.rdbFemenino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdbFemenino.Location = New System.Drawing.Point(171, 22)
        Me.rdbFemenino.Name = "rdbFemenino"
        Me.rdbFemenino.Size = New System.Drawing.Size(113, 27)
        Me.rdbFemenino.TabIndex = 1
        Me.rdbFemenino.TabStop = True
        Me.rdbFemenino.Text = "Femenino"
        Me.rdbFemenino.UseVisualStyleBackColor = True
        '
        'rdbMasculino
        '
        Me.rdbMasculino.AutoSize = True
        Me.rdbMasculino.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rdbMasculino.Location = New System.Drawing.Point(11, 22)
        Me.rdbMasculino.Name = "rdbMasculino"
        Me.rdbMasculino.Size = New System.Drawing.Size(118, 27)
        Me.rdbMasculino.TabIndex = 0
        Me.rdbMasculino.TabStop = True
        Me.rdbMasculino.Text = "Masculino"
        Me.rdbMasculino.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(14, 329)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 23)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Sexo"
        '
        'txtCorreoelectronico
        '
        Me.txtCorreoelectronico.Location = New System.Drawing.Point(15, 284)
        Me.txtCorreoelectronico.Name = "txtCorreoelectronico"
        Me.txtCorreoelectronico.Size = New System.Drawing.Size(471, 30)
        Me.txtCorreoelectronico.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(14, 258)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(169, 23)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "Correo electronico"
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(15, 207)
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(471, 30)
        Me.txtSegundoApellido.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(14, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 23)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Segundo apellido"
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(15, 127)
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(471, 30)
        Me.txtPrimerApellido.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(14, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(143, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Primer Apellido"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(15, 55)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(471, 30)
        Me.txtNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre(s)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.lbl1)
        Me.Panel2.Location = New System.Drawing.Point(98, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(516, 63)
        Me.Panel2.TabIndex = 26
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(185, 15)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(141, 33)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "REGISTRO"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(606, 1170)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 25
        Me.Label24.Text = " "
        Me.Label24.Visible = False
        '
        'FrmRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(732, 592)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmRegistros"
        Me.Text = "Registro"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gpbSexo.ResumeLayout(False)
        Me.gpbSexo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents gpbSexo As GroupBox
    Friend WithEvents rdbMasculino As RadioButton
    Friend WithEvents Label16 As Label
    Friend WithEvents txtCorreoelectronico As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents rdbOtro As RadioButton
    Friend WithEvents rdbFemenino As RadioButton
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtNumeroTelefono As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtcontraseña As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtPais As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl1 As Label
    Friend WithEvents Label24 As Label
End Class
