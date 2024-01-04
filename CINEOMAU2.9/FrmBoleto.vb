

Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports ZXing

Public Class FrmBoleto
    Private Sub FrmBoleto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnImprimirBoleto.FlatStyle = FlatStyle.Flat
        btnImprimirBoleto.FlatAppearance.BorderSize = 0
        btnSalir.FlatStyle = FlatStyle.Flat
        btnSalir.FlatAppearance.BorderSize = 0

        Dim contenido As String = IDFuncionGlobal.ToString & "," & cantidadBoletos
        Dim codificador As New BarcodeWriter
        codificador.Format = BarcodeFormat.QR_CODE
        Dim imagen As Bitmap = codificador.Write(contenido)
        QR.Image = imagen

        llenado()

    End Sub

    Private Sub btnImprimirBoleto_Click(sender As Object, e As EventArgs) Handles btnImprimirBoleto.Click
        ' Crear un objeto SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog()

        ' Configurar el SaveFileDialog
        saveFileDialog.Filter = "Archivos PNG|*.png"
        saveFileDialog.Title = "Guardar imagen como"
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)

        ' Mostrar el cuadro de diálogo y verificar si el usuario hizo clic en Guardar
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Crear un objeto Bitmap del tamaño del formulario
            Dim bmp As New Bitmap(Me.Width, Me.Height)

            ' Crear un objeto Graphics a partir del objeto Bitmap
            Using g As Graphics = Graphics.FromImage(bmp)
                ' Copiar el contenido del formulario al objeto Graphics
                Me.DrawToBitmap(bmp, Me.ClientRectangle)
            End Using

            ' Guardar la imagen en la ruta seleccionada por el usuario en formato PNG
            bmp.Save(saveFileDialog.FileName, ImageFormat.Png)

            ' Liberar recursos
            bmp.Dispose()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FrmControlUsuario.Show()
        Me.Close()
    End Sub

    Private Sub llenado()
        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_funcionSeleccionada " & Procedimientos.IDFuncionGlobal.ToString
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            lblFuncion.Text = "Función: " & IDFuncionGlobal
            lblPelicula.Text = "Pelicula: " & Conexion.lectorSQL(0)
            lblClasificacion.Text = "Clasificación: " & Conexion.lectorSQL(1)
            lblDuracion.Text = "Duración: " & Conexion.lectorSQL(2)
            lblGenero.Text = "Genero: " & Conexion.lectorSQL(3)
            lblCantidadAsientos.Text = "Cantidad de boletos: " & cantidadBoletos
            lblHora.Text = "Hora de función: " & Conexion.lectorSQL(4).ToString
            lblSala.Text = "Sala: " & Conexion.lectorSQL(5).ToString
        End While
        Conexion.conexionGeneral.Close()
    End Sub
End Class
