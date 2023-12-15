Public Class frmRelServicos
    Private Sub frmRelServicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ORDEMSERVICODataSet1.ListaDeServicos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ListaDeServicosTableAdapter.Fill(Me.ORDEMSERVICODataSet1.ListaDeServicos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class