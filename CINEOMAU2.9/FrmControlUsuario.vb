Imports System.Data.SqlClient

Public Class FrmControlUsuario
    Private Sub FrmControlUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCartelera.FlatStyle = FlatStyle.Flat
        btnCartelera.FlatAppearance.BorderSize = 0
        btnProductos.FlatStyle = FlatStyle.Flat
        btnProductos.FlatAppearance.BorderSize = 0
        btnEstrenos.FlatStyle = FlatStyle.Flat
        btnEstrenos.FlatAppearance.BorderSize = 0
        btnBuscarFunciones.FlatStyle = FlatStyle.Flat
        btnBuscarFunciones.FlatAppearance.BorderSize = 0
        btnBuscarFiltro.FlatStyle = FlatStyle.Flat
        btnBuscarFiltro.FlatAppearance.BorderSize = 0
        btnAdministrador.FlatStyle = FlatStyle.Flat
        btnAdministrador.FlatAppearance.BorderSize = 0
        btnInformacionUsuario.FlatStyle = FlatStyle.Flat
        btnInformacionUsuario.FlatAppearance.BorderSize = 0
        btnSeleccionarFuncion.FlatStyle = FlatStyle.Flat
        btnSeleccionarFuncion.FlatAppearance.BorderSize = 0
        dvgCartelera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dvgCartelera.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dvgCartelera.RowHeadersVisible = False
        dvgCartelera.DefaultCellStyle.BackColor = Color.FromArgb(0, 63, 193)
        dvgCartelera.ColumnHeadersVisible = False
        dvgCartelera.RowHeadersVisible = False
        dvgCartelera.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dvgCartelera.ReadOnly = True
        dvgCartelera.MultiSelect = False





        Actualizar()

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        FrmProductos.Show()
        Me.Close()
    End Sub

    Private Sub btnAdministrador_Click(sender As Object, e As EventArgs) Handles btnAdministrador.Click
        FrmAdministrador.Show()
        Me.Hide()
    End Sub

    Private Sub btnSeleccionarFuncion_Click(sender As Object, e As EventArgs) Handles btnSeleccionarFuncion.Click
        Try
            If dvgCartelera.SelectedRows.Count > 0 Then
                Dim valorPrimeraColumna As String = dvgCartelera.SelectedRows(0).Cells(0).Value.ToString()

            Else
                MessageBox.Show("Selecciona una función antes de continuar.")
            End If
            FrmSeleccionAsientos.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("No has seleccionado una función")
        End Try
    End Sub

    Private Sub btnEstrenos_Click(sender As Object, e As EventArgs) Handles btnEstrenos.Click
        FrmEstenos.Show()
        Me.Hide()
    End Sub

    Private Sub btnInformacionUsuario_Click(sender As Object, e As EventArgs) Handles btnInformacionUsuario.Click

    End Sub

    Public Sub Actualizar()
        cmbClasificacion.Items.Clear()
        cmbDuracion.Items.Clear()
        cmbGenero.Items.Clear()

        Dim FechaS As Date = dtpFechaBusqueda.Value
        Dim FFechaS As String = FechaS.ToString("yyyy-MM-d")
        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_MostrarBusquedaFunciones '" & FFechaS & "'"
        Conexion.conectar()
        Conexion.tablaSQL = New DataTable
        Conexion.adaptadorSQL = New SqlDataAdapter(sentenciaSQL, conexionGeneral)
        Conexion.adaptadorSQL.Fill(tablaSQL)
        dvgCartelera.DataSource = Conexion.tablaSQL
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

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarDuracion"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbDuracion.Items.Add(Conexion.lectorSQL(0))
        End While
        Conexion.conexionGeneral.Close()

    End Sub

    Private Sub btnBuscarFunciones_Click(sender As Object, e As EventArgs) Handles btnBuscarFunciones.Click
        Actualizar()
    End Sub

    Private Sub btnBuscarFiltro_Click(sender As Object, e As EventArgs) Handles btnBuscarFiltro.Click
        Dim ClasificacionEdad As String
        Dim ClasificacionGenero As String
        Dim ClasificacionDuracion As String

        Try
            ClasificacionEdad = cmbClasificacion.SelectedItem
            ClasificacionGenero = cmbGenero.SelectedItem
            ClasificacionDuracion = cmbDuracion.SelectedItem

            If ClasificacionEdad <> "" And ClasificacionGenero <> "" And ClasificacionDuracion <> "" Then
                Dim FechaS As Date = dtpFechaBusqueda.Value
                Dim FFechaS As String = FechaS.ToString("yyyy-MM-d")
                Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_filtroEdadGeneroDuracion '" & FFechaS & "','" & ClasificacionEdad & "','" & ClasificacionGenero & "'"
                Conexion.conectar()
                Conexion.tablaSQL = New DataTable
                Conexion.adaptadorSQL = New SqlDataAdapter(sentenciaSQL, conexionGeneral)
                Conexion.adaptadorSQL.Fill(tablaSQL)
                dvgCartelera.DataSource = Conexion.tablaSQL
                Conexion.conexionGeneral.Close()

            End If

            If ClasificacionEdad = "" And ClasificacionGenero = "" And ClasificacionDuracion = "" Then
                MsgBox("No hay ningun criterio e busqueda")
            End If

            If ClasificacionEdad <> "" And ClasificacionGenero = "" And ClasificacionDuracion = "" Then
                MsgBox("Solo clasifiacion edad")
            End If

            If ClasificacionEdad = "" And ClasificacionGenero <> "" And ClasificacionDuracion = "" Then
                MsgBox("Solo calsifiacion de genero")
            End If

            If ClasificacionEdad = "" And ClasificacionGenero = "" And ClasificacionDuracion <> "" Then
                MsgBox("Solo clasificaion de tiempo")
            End If

            If ClasificacionEdad <> "" And ClasificacionGenero <> "" And ClasificacionDuracion = "" Then
                MsgBox("Clasicicacion edad y clasificacion Genero ")
            End If

            If ClasificacionEdad <> "" And ClasificacionGenero = "" And ClasificacionDuracion <> "" Then
                MsgBox("Clasificacion edad y clasificacion duracion")
            End If

            If ClasificacionEdad = "" And ClasificacionGenero <> "" And ClasificacionDuracion <> "" Then
                MsgBox("Clasificacion genero y clasificacion duracion")
            End If






        Catch ex As Exception

            MsgBox("No hay funciones con este filtro")

        End Try
    End Sub
End Class