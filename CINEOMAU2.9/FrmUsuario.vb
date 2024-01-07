Imports System.Data.SqlClient

Public Class FrmUsuario
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDUsuario.Text = Conexion.usuarioID
        llenadoUsuario(Conexion.usuarioID)

        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Public Sub llenadoUsuario(ByVal idUsuario As String)
        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_datosUsuario " & idUsuario
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            lblIDUsuario.Text = Conexion.lectorSQL(0).ToString
            lblNombre.Text = Conexion.lectorSQL(2).ToString
            lblApellidoPaterno.Text = Conexion.lectorSQL(3).ToString()
            lblApellidoMaterno.Text = Conexion.lectorSQL(4).ToString
            lblCorreoElectronico.Text = Conexion.lectorSQL(5).ToString
            lblSexo.Text = Conexion.lectorSQL(6).ToString
            lblFechaNacimiento.Text = Conexion.lectorSQL(7).ToString
            lblTelefono.Text = Conexion.lectorSQL(8).ToString
        End While
        Conexion.conexionGeneral.Close()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmControlUsuario.Show()
        Me.Close()
    End Sub
End Class