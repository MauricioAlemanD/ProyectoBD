Imports System.Data.SqlClient

Public Class ControlFunciones
    Private Sub ControlFunciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevaFuncion.FlatStyle = FlatStyle.Flat
        btnNuevaFuncion.FlatAppearance.BorderSize = 0
        btnEditarFuncion.FlatStyle = FlatStyle.Flat
        btnEditarFuncion.FlatAppearance.BorderSize = 0
        btnEliminarFuncion.FlatStyle = FlatStyle.Flat
        btnEliminarFuncion.FlatAppearance.BorderSize = 0
        btnBuscarFuncion.FlatStyle = FlatStyle.Flat
        btnBuscarFuncion.FlatAppearance.BorderSize = 0
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.FlatAppearance.BorderSize = 0


        actualizacion()


    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmAdministrador.Show()
        Me.Hide()

    End Sub

    Private Sub btnBuscarFuncion_Click(sender As Object, e As EventArgs) Handles btnBuscarFuncion.Click
        Dim FechaS As Date = dtpFechaBusqueda.Value
        Dim FFechaS As String = FechaS.ToString("yyyy-MM-d")
        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_MostrarBusquedaFunciones '" & FFechaS & "'"
        Conexion.tablaSQL = New DataTable
        Conexion.adaptadorSQL = New SqlDataAdapter(sentenciaSQL, conexionGeneral)
        Conexion.adaptadorSQL.Fill(tablaSQL)
        dvgFunciones.DataSource = Conexion.tablaSQL
        Conexion.conexionGeneral.Close()
    End Sub

    Private Sub btnNuevaFuncion_Click(sender As Object, e As EventArgs) Handles btnNuevaFuncion.Click
        Dim FechaS As Date = dptNuevaFecha.Value
        Dim FFechaS As String = FechaS.ToString("yyyy-MM-d")
        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_nuevaFuncion 0," & cmbNuevaSala.SelectedItem.ToString & ",'" & cmbNuevoHorario.SelectedItem.ToString & "','" & FFechaS & "','" & cmbNuevaPelicula.SelectedItem.ToString & "'"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(sentenciaSQL, conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()

        actualizacion()

        cmbNuevaSala.Text = ""
        dptNuevaFecha.Text = ""
        cmbNuevoHorario.Text = ""
        cmbNuevaPelicula.Text = ""

    End Sub

    Public Sub actualizacion()

        cmbNuevoHorario.Items.Clear()
        cmbNuevaSala.Items.Clear()
        cmbNuevaPelicula.Items.Clear()
        cmbEditarFuncion.Items.Clear()
        cmbEditarHorario.Items.Clear()
        cmbEditarSala.Items.Clear()
        cmbEditarPelicula.Items.Clear()



        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarHoras"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbNuevoHorario.Items.Add(Conexion.lectorSQL(0))
            cmbEditarHorario.Items.Add(Conexion.lectorSQL(0))
        End While
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarSalas"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbNuevaSala.Items.Add(Conexion.lectorSQL(0))
            cmbEditarSala.Items.Add(Conexion.lectorSQL(0))
        End While
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarPeliculas"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbNuevaPelicula.Items.Add(Conexion.lectorSQL(0))
            cmbEditarPelicula.Items.Add(Conexion.lectorSQL(0))
        End While
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarIDFunciones"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbEliminarFuncion.Items.Add(Conexion.lectorSQL(0))
            cmbEditarFuncion.Items.Add(Conexion.lectorSQL(0))
        End While
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_mostrarFunciones"
        Conexion.conectar()
        Conexion.tablaSQL = New DataTable
        Conexion.adaptadorSQL = New SqlDataAdapter(sentenciaSQL, conexionGeneral)
        Conexion.adaptadorSQL.Fill(tablaSQL)
        dvgFunciones.DataSource = Conexion.tablaSQL
        Conexion.conexionGeneral.Close()


    End Sub

    Private Sub btnEliminarFuncion_Click(sender As Object, e As EventArgs) Handles btnEliminarFuncion.Click
        Dim FuncionEliminar As String
        FuncionEliminar = cmbEliminarFuncion.SelectedItem
        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_borrarFuncion " & FuncionEliminar
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(sentenciaSQL, conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()

        actualizacion()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEditarFuncion.SelectedIndexChanged

        Dim IDSeleccionada As String = cmbEditarFuncion.SelectedItem

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_llenadoEdicion " & IDSeleccionada
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader

        While Conexion.lectorSQL.Read
            cmbEditarSala.Text = Conexion.lectorSQL(0)
            cmbEditarHorario.Text = Conexion.lectorSQL(1).ToString
            dtpEditarFecha.Text = Conexion.lectorSQL(2)
            cmbEditarPelicula.Text = Conexion.lectorSQL(3)
        End While

        Conexion.conexionGeneral.Close()

    End Sub

    Private Sub btnEditarFuncion_Click(sender As Object, e As EventArgs) Handles btnEditarFuncion.Click
        Dim FechaS As Date = dtpEditarFecha.Value
        Dim FFechaS As String = FechaS.ToString("yyyy-MM-d")
        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_actualizarFuncion '" & cmbEditarFuncion.SelectedItem.ToString & "','" & cmbEditarSala.SelectedItem.ToString & "','" & cmbEditarHorario.SelectedItem.ToString & "', '" & FFechaS & "' ,'" & cmbEditarPelicula.SelectedItem.ToString & "'"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(sentenciaSQL, conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()

        actualizacion()
    End Sub
End Class