Public Class FrmProductos
    Private Sub FrmProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnCartelera.FlatStyle = FlatStyle.Flat
        btnProductos.FlatStyle = FlatStyle.Flat
        btnEstrenos.FlatStyle = FlatStyle.Flat
        btnBuscarProductos.FlatStyle = FlatStyle.Flat
        btnBuscarFiltro.FlatStyle = FlatStyle.Flat
        btnAdministrador.FlatStyle = FlatStyle.Flat
        btnInformacionUsuario.FlatStyle = FlatStyle.Flat
        btnAgregarCanasta.FlatStyle = FlatStyle.Flat
        btnPagarProductos.FlatStyle = FlatStyle.Flat

        btnCartelera.FlatAppearance.BorderSize = 0
        btnProductos.FlatAppearance.BorderSize = 0
        btnEstrenos.FlatAppearance.BorderSize = 0
        btnBuscarProductos.FlatAppearance.BorderSize = 0
        btnBuscarFiltro.FlatAppearance.BorderSize = 0
        btnAdministrador.FlatAppearance.BorderSize = 0
        btnInformacionUsuario.FlatAppearance.BorderSize = 0
        btnAgregarCanasta.FlatAppearance.BorderSize = 0
        btnPagarProductos.FlatAppearance.BorderSize = 0

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click

    End Sub
End Class