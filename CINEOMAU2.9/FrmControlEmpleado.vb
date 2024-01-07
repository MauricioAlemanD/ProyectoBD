Imports System.Data.SqlClient

Public Class FrmControlEmpleado
    Private Sub FrmControlEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnNuevoEmpleado.FlatStyle = FlatStyle.Flat
        btnNuevoEmpleado.FlatAppearance.BorderSize = 0
        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.FlatAppearance.BorderSize = 0

        llenado()

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmAdministrador.Show()
        Me.Close()
    End Sub

    Private Sub llenado()
        Conexion.sentenciaSQL = "use CINEOMAU; exec sp_mostrarCorreos"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(Conexion.sentenciaSQL, Conexion.conexionGeneral)
        Conexion.lectorSQL = Conexion.comandoSQL.ExecuteReader
        While Conexion.lectorSQL.Read
            cmbUsuario.Items.Add(Conexion.lectorSQL(0))
        End While

        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_mostrarEmpleados"
        Conexion.conectar()
        Conexion.tablaSQL = New DataTable
        Conexion.adaptadorSQL = New SqlDataAdapter(sentenciaSQL, conexionGeneral)
        Conexion.adaptadorSQL.Fill(tablaSQL)
        dvgEmpleados.DataSource = Conexion.tablaSQL
        Conexion.conexionGeneral.Close()
    End Sub

    Private Sub btnNuevoEmpleado_Click(sender As Object, e As EventArgs) Handles btnNuevoEmpleado.Click

        Dim cuenta As Integer
        cuenta = txtCuenta.Text

        Conexion.sentenciaSQL = "USE CINEOMAU; exec sp_nuevoEmpleado '" & cmbUsuario.SelectedItem & "','" & cmbTurno.SelectedItem & "','" & cmbSueldo.SelectedItem & "','" & txtRFC.Text & "','" & txtNSS.Text & "'," & txtCuenta.Text & ",'" & txtECivil.Text & "'"
        Conexion.conectar()
        Conexion.comandoSQL = New SqlCommand(sentenciaSQL, conexionGeneral)
        Conexion.respuestaSQL = Conexion.comandoSQL.ExecuteNonQuery
        Conexion.conexionGeneral.Close()

        txtCuenta.Clear()
        txtECivil.Clear()
        txtNSS.Clear()
        txtRFC.Clear()

        llenado()

    End Sub
End Class