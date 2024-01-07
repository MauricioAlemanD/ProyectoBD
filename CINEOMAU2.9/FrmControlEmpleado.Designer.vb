<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControlEmpleado
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
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNuevoEmpleado = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RFC = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSueldo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTurno = New System.Windows.Forms.ComboBox()
        Me.dvgEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtNSS = New System.Windows.Forms.TextBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtECivil = New System.Windows.Forms.TextBox()
        Me.c = New System.Windows.Forms.Label()
        CType(Me.dvgEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(11, 404)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(804, 5)
        Me.Panel5.TabIndex = 174
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.Black
        Me.btnRegresar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(11, 382)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(804, 27)
        Me.btnRegresar.TabIndex = 176
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(86, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 33)
        Me.Label13.TabIndex = 199
        Me.Label13.Text = "Control empleado"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(564, 356)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(251, 5)
        Me.Panel1.TabIndex = 183
        '
        'btnNuevoEmpleado
        '
        Me.btnNuevoEmpleado.BackColor = System.Drawing.Color.Black
        Me.btnNuevoEmpleado.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevoEmpleado.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnNuevoEmpleado.Location = New System.Drawing.Point(564, 334)
        Me.btnNuevoEmpleado.Name = "btnNuevoEmpleado"
        Me.btnNuevoEmpleado.Size = New System.Drawing.Size(251, 27)
        Me.btnNuevoEmpleado.TabIndex = 184
        Me.btnNuevoEmpleado.Text = "Añadir empleado"
        Me.btnNuevoEmpleado.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(560, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 19)
        Me.Label6.TabIndex = 182
        Me.Label6.Text = "NSS"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RFC
        '
        Me.RFC.AutoSize = True
        Me.RFC.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RFC.ForeColor = System.Drawing.Color.White
        Me.RFC.Location = New System.Drawing.Point(560, 222)
        Me.RFC.Name = "RFC"
        Me.RFC.Size = New System.Drawing.Size(38, 19)
        Me.RFC.TabIndex = 180
        Me.RFC.Text = "RFC"
        Me.RFC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(560, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 179
        Me.Label4.Text = "Sueldo"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbSueldo
        '
        Me.cmbSueldo.FormattingEnabled = True
        Me.cmbSueldo.Items.AddRange(New Object() {"1600", "1800", "2400"})
        Me.cmbSueldo.Location = New System.Drawing.Point(631, 192)
        Me.cmbSueldo.Name = "cmbSueldo"
        Me.cmbSueldo.Size = New System.Drawing.Size(184, 21)
        Me.cmbSueldo.TabIndex = 178
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(560, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 177
        Me.Label3.Text = "Turno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbTurno
        '
        Me.cmbTurno.FormattingEnabled = True
        Me.cmbTurno.Items.AddRange(New Object() {"Día", "Noche"})
        Me.cmbTurno.Location = New System.Drawing.Point(631, 165)
        Me.cmbTurno.Name = "cmbTurno"
        Me.cmbTurno.Size = New System.Drawing.Size(184, 21)
        Me.cmbTurno.TabIndex = 175
        '
        'dvgEmpleados
        '
        Me.dvgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgEmpleados.Location = New System.Drawing.Point(11, 95)
        Me.dvgEmpleados.Name = "dvgEmpleados"
        Me.dvgEmpleados.Size = New System.Drawing.Size(498, 266)
        Me.dvgEmpleados.TabIndex = 171
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Bk", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(559, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 29)
        Me.Label1.TabIndex = 167
        Me.Label1.Text = "Agregar empleado"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CINEOMAU2._9.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 168
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(560, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 205
        Me.Label2.Text = "Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbUsuario
        '
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Location = New System.Drawing.Point(631, 138)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(184, 21)
        Me.cmbUsuario.TabIndex = 206
        '
        'txtRFC
        '
        Me.txtRFC.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFC.Location = New System.Drawing.Point(631, 220)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(184, 22)
        Me.txtRFC.TabIndex = 207
        '
        'txtNSS
        '
        Me.txtNSS.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNSS.Location = New System.Drawing.Point(631, 248)
        Me.txtNSS.Name = "txtNSS"
        Me.txtNSS.Size = New System.Drawing.Size(184, 22)
        Me.txtNSS.TabIndex = 208
        '
        'txtCuenta
        '
        Me.txtCuenta.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(631, 276)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(184, 22)
        Me.txtCuenta.TabIndex = 210
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(560, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 209
        Me.Label5.Text = "Cuenta"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtECivil
        '
        Me.txtECivil.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtECivil.Location = New System.Drawing.Point(631, 304)
        Me.txtECivil.Name = "txtECivil"
        Me.txtECivil.Size = New System.Drawing.Size(184, 22)
        Me.txtECivil.TabIndex = 212
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c.ForeColor = System.Drawing.Color.White
        Me.c.Location = New System.Drawing.Point(560, 308)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(56, 19)
        Me.c.TabIndex = 211
        Me.c.Text = "E. Civil"
        Me.c.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmControlEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(837, 418)
        Me.Controls.Add(Me.txtECivil)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNSS)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNuevoEmpleado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RFC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbSueldo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbTurno)
        Me.Controls.Add(Me.dvgEmpleados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmControlEmpleado"
        Me.Text = "FrmControlEmpleado"
        CType(Me.dvgEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnRegresar As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNuevoEmpleado As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents RFC As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSueldo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbTurno As ComboBox
    Friend WithEvents dvgEmpleados As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbUsuario As ComboBox
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents txtNSS As TextBox
    Friend WithEvents txtCuenta As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtECivil As TextBox
    Friend WithEvents c As Label
End Class
