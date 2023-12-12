Public Class frmRelProdutos
    Private Sub frmRelProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.tbProdutos'. Você pode movê-la ou removê-la conforme necessário.
        Me.tbProdutosTableAdapter.Fill(Me.ProdutosDataSet.tbProdutos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class