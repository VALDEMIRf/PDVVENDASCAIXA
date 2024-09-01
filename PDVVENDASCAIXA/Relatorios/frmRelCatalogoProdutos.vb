Public Class frmRelCatalogoProdutos
    Private Sub frmRelCatalogoProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.CATALOGOPRODUTOS'. Você pode movê-la ou removê-la conforme necessário.
        Me.CATALOGOPRODUTOSTableAdapter.Fill(Me.ProdutosDataSet.CATALOGOPRODUTOS)
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.tbProdutos'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbProdutosTableAdapter.Fill(Me.ProdutosDataSet.tbProdutos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class