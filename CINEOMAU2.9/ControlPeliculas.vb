Imports System.Data.SqlClient

Public Class ControlPeliculas
    Private Sub ControlPeliculas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevaPelicula.FlatStyle = FlatStyle.Flat
        btnNuevaPelicula.FlatAppearance.BorderSize = 0
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.FlatAppearance.BorderSize = 0
        dvgPeliculas.DefaultCellStyle.ForeColor = Color.Black
        llenado()

    End Sub


    Private Sub llenado()
        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_mostrarPeliculasCompleto"
        Conexion.conectar()
        Conexion.tablaSQL = New DataTable
        Conexion.adaptadorSQL = New SqlDataAdapter(sentenciaSQL, conexionGeneral)
        Conexion.adaptadorSQL.Fill(tablaSQL)
        dvgPeliculas.DataSource = Conexion.tablaSQL
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarClasificacion"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbClasificacion.Items.Add(Conexion.lectorSQL(0))
        End While
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarGeneros"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbGenero.Items.Add(Conexion.lectorSQL(0))
        End While
        Conexion.conexionGeneral.Close()
    End Sub

    Private Sub btnNuevaPelicula_Click(sender As Object, e As EventArgs) Handles btnNuevaPelicula.Click
        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_agregarPelicula '" & txtTituloPelicula.Text & "','" & txtDuracionMinutos.Text & "','" & cmbClasificacion.SelectedItem & "','" & cmbGenero.SelectedItem & "'"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(sentenciaSQL, conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()

        llenado()
        txtDuracionMinutos.Clear()
        txtTituloPelicula.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmAdministrador.Show()
        Me.Close()
    End Sub
End Class