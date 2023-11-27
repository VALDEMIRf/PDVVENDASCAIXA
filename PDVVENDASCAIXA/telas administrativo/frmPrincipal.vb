Public Class frmPrincipal
    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        Dim form = New frmFuncionarios
        form.ShowDialog()
    End Sub

    Private Sub CargosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargosToolStripMenuItem.Click
        Dim form = New frmCargos
        form.ShowDialog()
    End Sub

    Private Sub FornecedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FornecedoresToolStripMenuItem.Click
        Dim form = New frmFornecedores
        form.ShowDialog()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim form = New frmCategoriaProdutos
        form.ShowDialog()
    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresaToolStripMenuItem.Click
        Dim form = New frmEmpresa
        form.ShowDialog()
    End Sub

    Private Sub UnidadeDeMedidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadeDeMedidaToolStripMenuItem.Click
        Dim form = New frmUnidadeMedidas
        form.ShowDialog()
    End Sub

    Private Sub TiposDeServiçosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeServiçosToolStripMenuItem.Click
        Dim form = New frmTipoServico
        form.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem1.Click
        Application.Exit()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim form = New frmClientes
        form.ShowDialog()
    End Sub

    Private Sub OrdemDeServiçoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdemDeServiçoToolStripMenuItem.Click
        Dim form = New frmServicos
        form.ShowDialog()
    End Sub

    Private Sub ProdutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem1.Click
        Dim form = New frmProdutos
        form.ShowDialog()
    End Sub
End Class