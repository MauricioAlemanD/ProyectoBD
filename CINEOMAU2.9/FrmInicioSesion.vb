Imports System.Data.SqlClient

Public Class FrmInicioSesion

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        lblHint1.Visible = False
        If txtId.Text = "" Then
            lblHint1.Visible = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtContraseña.TextChanged
        lblHint2.Visible = False
        If txtId.Text = "" Then
            lblHint2.Visible = True
        End If
    End Sub

    Private Sub btnUnirse_Click(sender As Object, e As EventArgs) Handles btnUnirse.Click
        FrmRegistros.Show()
        Me.Hide()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click

        Conexion.usuarioID = ObtenerNombreUsuario(txtId.Text)
        Conexion.usuarioContraseña = txtContraseña.Text

        Try
            conectarUsuario()
            FrmControlUsuario.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox("Revisa tus  campos de inicio de sesión " & ex.Message)
        End Try

    End Sub

    Private Sub FrmInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Function ObtenerNombreUsuario(correoElectronico As String) As String
        Dim indiceArroba As Integer = correoElectronico.IndexOf("@")

        If indiceArroba >= 0 Then
            Return correoElectronico.Substring(0, indiceArroba)
        Else
            Return correoElectronico
        End If
    End Function
End Class