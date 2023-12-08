Imports System.Data.SqlClient

Module Procedimientos

    Public Sub nuevoUsuario(
        ByVal IDUsuario As String,
        ByVal ContraseñaUsuario As String,
        ByVal NombreUsuario As String,
        ByVal PrimerApellidoUsuario As String,
        ByVal SegundoApellidoUsuario As String,
        ByVal CorreoElectronicoUsuario As String,
        ByVal SexoUsuario As String,
        ByVal NacimientoUsuario As String,
        ByVal TelefonoUsuario As String,
        ByVal DireccionUsuario As String,
        ByVal CiudadUsuario As String,
        ByVal EstadoUsuario As String,
        ByVal PaisUsuario As String)

        Conexion.sentenciaSQL = "USE CINEOMAU; EXEC nuevo_usuario '" & IDUsuario & "', '" & ContraseñaUsuario & "', '" & NombreUsuario & "', '" & PrimerApellidoUsuario & "', '" & SegundoApellidoUsuario & "', '" & CorreoElectronicoUsuario & "', '" & SexoUsuario & "', '" & NacimientoUsuario & "'," & TelefonoUsuario & ",'" & DireccionUsuario & "', '" & CiudadUsuario & "', '" & EstadoUsuario & "', '" & PaisUsuario & "';"
        conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()
    End Sub


    Public Sub nuevoLogin(
        ByVal correo As String,
        ByVal contraseña As String
        )

        Conexion.sentenciaSQL = "EXEC nuevo_loginCompleto '" & correo & "', '" & contraseña & "';"
        conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()

    End Sub

    Public Sub consultaSalas()

    End Sub

End Module
