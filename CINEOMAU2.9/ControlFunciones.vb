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

    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Me.Hide()
    End Sub
End Class