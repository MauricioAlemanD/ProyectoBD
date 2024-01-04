<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPago
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotalAsientos = New System.Windows.Forms.Label()
        Me.lblPrecioUnitario = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbMetodoPago = New System.Windows.Forms.ComboBox()
        Me.lblRecibe = New System.Windows.Forms.Label()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.txtRecibe_Tarjeta = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRegresar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CINEOMAU2._9.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Bk", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 33)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Pago de boletos"
        '
        'lblTotalAsientos
        '
        Me.lblTotalAsientos.AutoSize = True
        Me.lblTotalAsientos.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAsientos.ForeColor = System.Drawing.Color.White
        Me.lblTotalAsientos.Location = New System.Drawing.Point(168, 69)
        Me.lblTotalAsientos.Name = "lblTotalAsientos"
        Me.lblTotalAsientos.Size = New System.Drawing.Size(139, 19)
        Me.lblTotalAsientos.TabIndex = 41
        Me.lblTotalAsientos.Text = "Total de asientos: "
        '
        'lblPrecioUnitario
        '
        Me.lblPrecioUnitario.AutoSize = True
        Me.lblPrecioUnitario.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecioUnitario.ForeColor = System.Drawing.Color.White
        Me.lblPrecioUnitario.Location = New System.Drawing.Point(168, 106)
        Me.lblPrecioUnitario.Name = "lblPrecioUnitario"
        Me.lblPrecioUnitario.Size = New System.Drawing.Size(117, 19)
        Me.lblPrecioUnitario.TabIndex = 42
        Me.lblPrecioUnitario.Text = "Precio unitario:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(166, 142)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(50, 19)
        Me.lblTotal.TabIndex = 43
        Me.lblTotal.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(419, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Método de pago:"
        '
        'cmbMetodoPago
        '
        Me.cmbMetodoPago.FormattingEnabled = True
        Me.cmbMetodoPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta: DÉBITO/CRÉDITO"})
        Me.cmbMetodoPago.Location = New System.Drawing.Point(553, 69)
        Me.cmbMetodoPago.Name = "cmbMetodoPago"
        Me.cmbMetodoPago.Size = New System.Drawing.Size(121, 21)
        Me.cmbMetodoPago.TabIndex = 45
        '
        'lblRecibe
        '
        Me.lblRecibe.AutoSize = True
        Me.lblRecibe.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecibe.ForeColor = System.Drawing.Color.White
        Me.lblRecibe.Location = New System.Drawing.Point(419, 106)
        Me.lblRecibe.Name = "lblRecibe"
        Me.lblRecibe.Size = New System.Drawing.Size(60, 19)
        Me.lblRecibe.TabIndex = 46
        Me.lblRecibe.Text = "Recibe:"
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.ForeColor = System.Drawing.Color.White
        Me.lblCambio.Location = New System.Drawing.Point(419, 142)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(68, 19)
        Me.lblCambio.TabIndex = 47
        Me.lblCambio.Text = "Cambio:"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(690, 162)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(110, 5)
        Me.Panel5.TabIndex = 49
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPagar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.White
        Me.btnPagar.Location = New System.Drawing.Point(690, 142)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(110, 27)
        Me.btnPagar.TabIndex = 48
        Me.btnPagar.Text = "Pagar"
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'txtRecibe_Tarjeta
        '
        Me.txtRecibe_Tarjeta.Location = New System.Drawing.Point(542, 106)
        Me.txtRecibe_Tarjeta.Name = "txtRecibe_Tarjeta"
        Me.txtRecibe_Tarjeta.Size = New System.Drawing.Size(132, 20)
        Me.txtRecibe_Tarjeta.TabIndex = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(690, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(110, 5)
        Me.Panel1.TabIndex = 51
        '
        'btnRegresar
        '
        Me.btnRegresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRegresar.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegresar.ForeColor = System.Drawing.Color.White
        Me.btnRegresar.Location = New System.Drawing.Point(690, 102)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(110, 27)
        Me.btnRegresar.TabIndex = 50
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = False
        '
        'FrmPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 173)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtRecibe_Tarjeta)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.lblCambio)
        Me.Controls.Add(Me.lblRecibe)
        Me.Controls.Add(Me.cmbMetodoPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPrecioUnitario)
        Me.Controls.Add(Me.lblTotalAsientos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "FrmPago"
        Me.Text = "FrmPago"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTotalAsientos As Label
    Friend WithEvents lblPrecioUnitario As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbMetodoPago As ComboBox
    Friend WithEvents lblRecibe As Label
    Friend WithEvents lblCambio As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnPagar As Button
    Friend WithEvents txtRecibe_Tarjeta As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRegresar As Button
End Class
