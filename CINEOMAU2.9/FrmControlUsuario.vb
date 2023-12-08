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
        FrmSeleccionAsientos.Show()
        Me.Hide()
    End Sub

    Private Sub btnEstrenos_Click(sender As Object, e As EventArgs) Handles btnEstrenos.Click
        FrmEstenos.Show()
        Me.Hide()
    End Sub

    Private Sub btnInformacionUsuario_Click(sender As Object, e As EventArgs) Handles btnInformacionUsuario.Click

    End Sub
End Class