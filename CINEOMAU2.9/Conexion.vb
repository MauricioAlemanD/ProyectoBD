Imports System.Data.Sql
Imports System.Data.SqlClient
Imports Microsoft.SqlServer

Module Conexion

    Public conexionGeneral As SqlConnection
    Public conexionUsiario As SqlConnection


    Public baseDeDatos As String = "CINEOMAU"
    Public usuarioID As String
    Public usuarioContraseña As String
    Public tabla As String

    Public comandoSQL As SqlCommand
    Public lectorSQL As SqlDataReader
    Public sentenciaSQL As String
    Public respuestaSQL As String

    Public adaptadorSQL As SqlDataAdapter
    Public tablaSQL As DataTable


    Public Sub conectar()
        conexionGeneral = New SqlConnection
        conexionGeneral.ConnectionString = "server=DESKTOP-B9ESO0B; database = master; integrated security = true"
        'conexionGeneral.ConnectionString = "server=PC-MAU; database = master; integrated security = true"
        conexionGeneral.Open()
    End Sub
    Public Sub conectarUsuario()

        conexionUsiario = New SqlConnection
        conexionUsiario.ConnectionString = "Server=DESKTOP-B9ESO0B;Database=" & baseDeDatos & ";Integrated Security=false;User ID=" & usuarioID & ";Password=" & usuarioContraseña
        'conexionUsiario.ConnectionString = "Server=PC-MAU;Database=" & baseDeDatos & ";Integrated Security=false;User ID=" & usuarioID & ";Password=" & usuarioContraseña
        conexionUsiario.Open()
    End Sub


End Module
