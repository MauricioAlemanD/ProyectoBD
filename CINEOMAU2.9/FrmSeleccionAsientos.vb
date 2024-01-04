Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class FrmSeleccionAsientos

    Private Sub FrmSeleccionAsientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPagar.FlatStyle = FlatStyle.Flat
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnPagar.FlatAppearance.BorderSize = 0
        btnRegresar.FlatAppearance.BorderSize = 0

        llenadoFuncion()


    End Sub

    Private Sub llenadoFuncion()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_funcionSeleccionada " & Procedimientos.IDFuncionGlobal.ToString
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            lblPelicula.Text = "Pelicula: " & Conexion.lectorSQL(0)
            lblClasificacion.Text = "Clasificación: " & Conexion.lectorSQL(1)
            lblDuracion.Text = "Duración: " & Conexion.lectorSQL(2)
            lblGenero.Text = "Genero: " & Conexion.lectorSQL(3)
            lblHora.Text = "Hora de función: " & Conexion.lectorSQL(4).ToString
        End While
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarCapacidad " & Procedimientos.IDFuncionGlobal.ToString
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            lblAsientos.Text = "Disponibles: " & Conexion.lectorSQL(1) & "/" & Conexion.lectorSQL(2)
            Libres = Conexion.lectorSQL(1)
            Totales = Conexion.lectorSQL(1)
        End While
        Conexion.conexionGeneral.Close()

        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_obtenerPrecio"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            PrecioBoleto = Conexion.lectorSQL(0).ToString
            precioUGlobal = Conexion.lectorSQL(0)
        End While
        Conexion.conexionGeneral.Close()
        lblPrecioBoleto.Text = "Precio individual: $" & PrecioBoleto


    End Sub

    Private Sub nmpNumeroEntradas_ValueChanged(sender As Object, e As EventArgs) Handles nmpNumeroEntradas.ValueChanged

        cantidadBoletos = nmpNumeroEntradas.Value
        precioTotal = cantidadBoletos * PrecioBoleto
        lblTotal.Text = "Total: $" & precioTotal

    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If cantidadBoletos > 0 Then

            If cantidadBoletos <= Libres Then

                FrmPago.Show()
                Me.Close()


            Else
                MsgBox("No hay suficientes asientos")
            End If

        Else

            MsgBox("Los asientos de esta función se han acabado")

        End If



    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmControlUsuario.Show()
        Me.Close
    End Sub
End Class