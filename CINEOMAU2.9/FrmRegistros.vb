Imports System.Data.SqlClient

Public Class FrmRegistros
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        If txtNombre.Text <> "" Or txtPrimerApellido.Text <> "" Or txtSegundoApellido.Text <> "" Or txtCorreoelectronico.Text <> "" Or rdbMasculino.Controls.OfType(Of RadioButton).Any(Function(rb) rb.Checked) Or txtNumeroTelefono.Text <> "" Or txtDireccion.Text <> "" Or txtCiudad.Text <> "" Or txtEstado.Text <> "" Or txtPais.Text <> "" Or txtcontraseña.Text <> "" Then
            MsgBox("Todos los campos estan llenos")
            Conexion.usuarioID = GenerarID()
            Try
                Dim sexo As String = ""
                If rdbMasculino.Checked Then
                    sexo = "Masculino"
                ElseIf rdbFemenino.Checked Then
                    sexo = "Femenino"
                ElseIf rdbOtro.Checked Then
                    sexo = "Otro"
                End If
                Procedimientos.nuevoLogin(ObtenerNombreUsuario(txtCorreoelectronico.Text), txtcontraseña.Text)
                Procedimientos.nuevoUsuario(Conexion.usuarioID, txtcontraseña.Text, txtNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtCorreoelectronico.Text, sexo, dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"), txtNumeroTelefono.Text, txtDireccion.Text, txtCiudad.Text, txtEstado.Text, txtPais.Text)
                FrmControlUsuario.Show()
                Me.Hide()

            Catch ex As Exception
                MsgBox("Error al crear usuario" & ex.Message)
            End Try

        Else
            MsgBox("Revisa tus que campos esten llenos")
        End If



    End Sub

    Private Sub FrmRegistros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function GenerarID() As String
        Dim primeraLetraApellidoPaterno As Char = txtPrimerApellido.Text.ToUpper()(0)
        Dim primeraVocalApellidoPaterno As Char = ObtenerPrimeraVocal(txtSegundoApellido.Text.ToUpper)
        Dim primeraLetraApellidoMaterno As Char = txtSegundoApellido.Text.ToUpper()(0)
        Dim primeraLetraNombre As Char = txtNombre.Text.ToUpper()(0)
        Dim fechaNacimiento As Date = dtpFechaNacimiento.Value
        Dim formatoFechaNacimiento As String = fechaNacimiento.ToString("ddMMyy")
        Dim letraSexo As Char
        If rdbMasculino.Checked Then
            letraSexo = "M"
        ElseIf rdbFemenino.Checked Then
            letraSexo = "F"
        ElseIf rdbOtro.Checked Then
            letraSexo = "O"
        End If
        Dim claveEstado As String = ObtenerClaveEstado(txtEstado.Text.ToUpper)
        Dim curp As String = primeraLetraApellidoPaterno & formatoFechaNacimiento & letraSexo & claveEstado

        Return curp
    End Function

    Private Function ObtenerPrimeraVocal(texto As String) As Char
        For Each letra As Char In texto
            If "AEIOU".Contains(Char.ToUpper(letra)) Then
                Return letra
            End If
        Next
        Return "X"c
    End Function

    Private Function ObtenerClaveEstado(estado As String) As String
        Return estado.Substring(0, 2)
    End Function
    Function ObtenerNombreUsuario(correoElectronico As String) As String
        Dim indiceArroba As Integer = correoElectronico.IndexOf("@")
        If indiceArroba >= 0 Then
            Return correoElectronico.Substring(0, indiceArroba)
        Else
            Return correoElectronico
        End If
    End Function
End Class
