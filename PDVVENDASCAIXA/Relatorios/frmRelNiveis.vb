Public Class frmRelNiveis
    Private Sub frmRelNiveis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ProdutosDataSet.NiveisBaixo'. Você pode movê-la ou removê-la conforme necessário.
        Me.NiveisBaixoTableAdapter.Fill(Me.ProdutosDataSet.NiveisBaixo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class