Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader
Public Class FrmPago

    Dim cantidadRecibida As Double
    Dim cambio As Double
    Dim IDUSUARIO As String
    Private Sub FrmPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPagar.FlatStyle = FlatStyle.Flat
        btnPagar.FlatAppearance.BorderSize = 0
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.FlatAppearance.BorderSize = 0

        lblPrecioUnitario.Text = "Precio unitario: $" & precioUGlobal
        lblTotal.Text = "Total: $" & precioTotal
        lblTotalAsientos.Text = "Total de asientos: " & cantidadBoletos
    End Sub

    Private Sub cmbMetodoPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMetodoPago.SelectedIndexChanged
        If cmbMetodoPago.SelectedItem = "Efectivo" Then

            lblRecibe.Text = "Recibe: "
            lblRecibe.Visible = True
            lblCambio.Text = "Cambio: "
            lblCambio.Visible = True

        ElseIf cmbMetodoPago.SelectedItem = "Tarjeta: DÉBITO/CRÉDITO" Then

            lblRecibe.Text = "No. Tarjeta:"
            lblCambio.Visible = False

        End If

    End Sub

    Private Sub txtRecibe_Tarjeta_TextChanged(sender As Object, e As EventArgs) Handles txtRecibe_Tarjeta.TextChanged

        Try

            If cmbMetodoPago.SelectedItem = "Efectivo" Then

                cantidadRecibida = txtRecibe_Tarjeta.Text

                cambio = cantidadRecibida - precioTotal

                If cantidadRecibida >= precioTotal Then
                    lblCambio.Text = "Cambio: $" & cambio
                End If

            ElseIf cmbMetodoPago.SelectedItem = "Tarjeta: DÉBITO/CRÉDITO" Then


            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        If txtRecibe_Tarjeta.Text = "" Then

            MsgBox("Ingresa los datos correspondientes")
        Else


            Conexion.sentenciaSQL = "use cineomau; EXEC sp_comprarBoletos " & IDFuncionGlobal & "," & cantidadBoletos
            conectar()
            Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
            Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
            Conexion.conexionGeneral.Close()

            datos()

            Conexion.sentenciaSQL = "use cineomau; EXEC sp_nuevaFactura " & IDUSUARIO & "," & IDFuncionGlobal & "," & cantidadBoletos & "," & PrecioBoleto & "," & precioTotal
            conectar()
            MsgBox(sentenciaSQL)
            Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
            Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
            Conexion.conexionGeneral.Close()

            FrmBoleto.Show()
            Me.Close()


        End If



    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click

        FrmControlUsuario.Show()
        Me.Close()

    End Sub

    Private Sub datos()
        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_datosUsuario " & usuarioID
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            IDUSUARIO = Conexion.lectorSQL(0).ToString
        End While
        Conexion.conexionGeneral.Close()
    End Sub


End Class