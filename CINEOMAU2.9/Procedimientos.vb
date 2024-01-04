Imports System.Data.SqlClient

Module Procedimientos

    Public IDPeliculaGlobal As Integer
    Public IDFuncionGlobal As String
    Public precioTotal As Decimal = 0
    Public cantidadBoletos As Integer = 0
    Public precioUGlobal As Integer = 0
    Public PrecioBoleto As String = ""
    Public Libres As String = ""
    Public Totales As String = ""
    Public usuarioGlobal As String = ""


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

        Conexion.sentenciaSQL = "EXEC nuevo_loginCompleto2 '" & correo & "', '" & contraseña & "';"
        conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()

    End Sub

    Public Sub busquedaUsuario(
    ByVal correo As String
    )

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_obtenerIDUsuario " & correo
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            usuarioGlobal = lectorSQL(0)
        End While
        Conexion.conexionGeneral.Close()


    End Sub

    Public Sub consultaSalas()

    End Sub

End Module
