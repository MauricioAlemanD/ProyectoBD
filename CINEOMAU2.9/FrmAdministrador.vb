Public Class FrmAdministrador
    Private Sub FrmAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnNuevaFuncion.FlatStyle = FlatStyle.Flat
        btnNuevaFuncion.FlatAppearance.BorderSize = 0

        btnNuevoComestible.FlatStyle = FlatStyle.Flat
        btnNuevoComestible.FlatAppearance.BorderSize = 0

        btnNuevaPelicula.FlatStyle = FlatStyle.Flat
        btnNuevaPelicula.FlatAppearance.BorderSize = 0

        btnNuevoEmpleado.FlatStyle = FlatStyle.Flat
        btnNuevoEmpleado.FlatAppearance.BorderSize = 0

        btnNuevoUsuario.FlatStyle = FlatStyle.Flat
        btnNuevoUsuario.FlatAppearance.BorderSize = 0

        btnRegresar.FlatStyle = FlatStyle.Flat
        btnRegresar.FlatAppearance.BorderSize = 0
    End Sub


    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        FrmControlUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevaPelicula.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnNuevaFuncion_Click(sender As Object, e As EventArgs) Handles btnNuevaFuncion.Click
        ControlFunciones.Show()

    End Sub
End Class